from flask import Flask, jsonify, request, send_file
import time
import requests
import json
import os
from flask_bcrypt import Bcrypt
import datetime

app = Flask(__name__)
bcrypt = Bcrypt(app)

def ping(url):
    start_time = time.time()
    try:
        response = requests.get(url)
        response.raise_for_status()  # Raise an exception for non-2xx status codes
    except requests.exceptions.RequestException as e:
        print(f"Error pinging {url}: {e}")
        return None

    end_time = time.time()
    return end_time - start_time

@app.route('/')
def get_data():
    sotowebVal = round(1065 * ping("https://www.sotoweb.cz/"))
    bakalariVal = round(8000 * ping("https://gateway.gymvod.cz:444/login"))
    start = datetime.datetime(2024, 4, 10)
    now = datetime.datetime.now()
    diff = now - start
    betbotVal = 200 - diff.days
    data = {'sotowebVal': sotowebVal, 'bakalariVal': bakalariVal, 'betbotVal': betbotVal}
    return jsonify(data)

@app.route('/new-user', methods=['POST'])
def newuser():
    data = request.get_json()
    
    account_name = data.get('userName')
    if account_name is None:
        return "Account name is required", 400
    
    file_name = account_name + '.json'
    
    if os.path.exists(file_name):
        return "User already exists", 400
    
    try:
        with open(file_name, 'w') as account_file:
            json.dump(data, account_file)
        return '', 201
    except Exception as e:
        print(f"Error creating new user file: {e}")
        return str(e), 500

@app.route('/login', methods=['POST'])
def login():
    data = request.get_json()
    
    account_name = data.get('accountName')
    if account_name is None:
        return "Account name is required", 400
    
    file_name = account_name + '.json'
    
    if os.path.exists(file_name):
        return send_file(file_name, as_attachment=True, mimetype='application/json')
    else:
        return "nope", 404

@app.route('/change', methods=['POST'])
def change():
    data = request.get_json()
    
    account_name = data.get('accountName')
    if account_name is None:
        return "Account name is required", 400
    
    file_name = account_name + '.json'
    
    try:
        with open(file_name, 'r') as file:
            orig = json.load(file)
        for key, value in data.items():
            if key not in data:
                orig[key] = value
        with open(file_name, 'w') as account_file:
            json.dump(orig, account_file)
        return send_file(file_name, as_attachment=True, mimetype='application/json')
    except Exception as e:
        print(f"Error changing user data: {e}")
        return "no such file", 404

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=7142)  # Allow connections from any IP
