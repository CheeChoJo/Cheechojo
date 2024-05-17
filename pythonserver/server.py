from flask import Flask
import time
import requests

app = Flask(__name__)

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
        sotowebVal = 1065 *ping("https://www.sotoweb.cz/")
        bakalariVal = 8* ping("https://gateway.gymvod.cz:444/login")
        print(sotowebVal)
    

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=7142)  # Allow connections from any IP

