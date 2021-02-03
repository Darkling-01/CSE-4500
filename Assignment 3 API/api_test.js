var http = require("http");

const fetch = require("node-fetch");


   fetch('https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY')
  
   //json() - parses the response body into a JSON object.

      .then(res => res.json())
      .then(json => console.log(json));

/*The Fetch API returns a response stream in the promise. The response stream is not JSON, 
so trying to call JSON.parse on it will fail. To correctly parse a JSON response, 
you'll need to use the response.json function. 
*/