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
    data = request.get_json() #veme json a hodi to do data
    file_name = data.get('accountName')+'.json'
    with open(file_name, 'w') as account_file: #vytvori novej file 
        json.dump(data, account_file)

@app.route('/change', methods=['POST', 'GET'])
def change():
    data = request.get_json()
    try: #pokud existuje soubor
        file_name = data.get('accountName')+'.json'
        with open(file_name, 'w') as account_file: #tim ze se soubor otevre ve write modu, viz 'w' se vymaze vsechno info v nem
            json.dump(data, account_file) #dropujeme novy info
        return send_file(file_name, as_attachment=True, mimetype='application/json') #posle soubor zpatky
    except:
        return "no such file"
    

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=7142)  # Allow connections from any IP

