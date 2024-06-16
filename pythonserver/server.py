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
        print(f"Error pinging")
        return None

    end_time = time.time()
    return end_time - start_time

@app.route('/')
def get_data():
    # Simulate some data
    while True:
        sotowebVal = round(1065 *ping("https://www.sotoweb.cz/"))
        bakalariVal = round(8000* ping("https://gateway.gymvod.cz:444/login"))
        start = datetime.datetime(2024, 4, 10)
        now = datetime.datetime.now()
        diff = now - start
        #print(diff.days)
        betbotVal = 200-diff.days

        data = {'sotowebVal': sotowebVal, 'bakalariVal': bakalariVal, 'betbotVal':betbotVal}

        return jsonify(data)
        

@app.route('/new-user', methods=["POST"])
def newuser():
    data = request.get_json()  # Get the JSON data
    account_name = data.get('userName')
    file_name = os.path.join(os.getcwd(), account_name + '.json')
    print(f"Checking if file exists: {file_name}")

    if os.path.exists(file_name):
        return '', 202
    else:
       with open(file_name, 'w') as account_file:
            json.dump(data, account_file)
            return '', 201
    

@app.route('/login', methods=["POST"])
def login():
    data = request.get_json()
    account_name = data.get('userName')
    password = data.get('password')
    file_name = account_name + '.json'
    if os.path.exists(file_name):
        with open(file_name, 'r') as account_file:
            account_data = json.load(account_file)
            if account_data.get('password') == password:
                return jsonify(account_data)
            else:
                return jsonify({"error": "Invalid password"}), 403
    else:
        return jsonify({"error": "User not found"}), 404


@app.route('/change', methods=['POST'])
def change():
    data = request.get_json()
    account_name = data.get('userName')
    if not account_name:
        return jsonify({"error": "Account name is required"}), 400
    file_name = account_name + '.json'
    if os.path.exists(file_name):
        try:
            with open(file_name, 'r') as file:
                orig = json.load(file)
            for key, value in data.items():
                if key in orig:
                    orig[key] = value
            with open(file_name, 'w') as account_file:
                json.dump(orig, account_file)

            return jsonify(orig)
        except Exception as e:
            return jsonify({"error": str(e)}), 500
    else:
        return jsonify({"error": "No such file"}), 404

    

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=7142)  # Allow connections from any IP

