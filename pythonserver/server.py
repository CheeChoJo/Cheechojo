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
    account_name = data.get('accountName')
    file_name = os.path.join(os.getcwd(), account_name + '.json')  # Use absolute path for clarity
    # Log the file name being checked
    print(f"Checking if file exists: {file_name}")

    if os.path.exists(file_name):
        # Log the file existence check
        print("File exists, returning 202")
        # If the file already exists, return 202 status
        return '', 202
    else:
        # Log the file creation process
        print("File does not exist, creating new file and returning 201")
        # Create a new file and write data to it
        with open(file_name, 'w') as account_file:
            json.dump(data, account_file)
        return '', 201
    

@app.route('/login')
def login():
    data = request.get_json()
    file_name = data.get('accountName')+'.json'

    if file_name:
        return send_file(file_name, as_attachment=True, mimetype='application/json')
    else:
        return "nope"


@app.route('/change', methods=['POST', 'GET'])
def change():
    data = request.get_json()
    try: #pokud existuje soubor
        file_name = data.get('accountName')+'.json'
        with open(file_name, 'r') as file:
            orig = json.load(file)
        for key, value in data.items():
            if key not in data:  
                orig[key] = value
        with open(file_name, 'w') as account_file: #tim ze se soubor otevre ve write modu, viz 'w' se vymaze vsechno info v nem
            json.dump(orig, account_file) #dropujeme novy info
        return send_file(file_name, as_attachment=True, mimetype='application/json') #posle soubor zpatky
    except:
        return "no such file"
    

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=7142)  # Allow connections from any IP

