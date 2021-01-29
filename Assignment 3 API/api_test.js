var http = require("http");

const fetch = require("node-fetch");

//http.createServer(function (request, response) {
   // Send the HTTP header 
   // HTTP Status: 200 : OK
   // Content Type: text/plain
   //response.writeHead(200, {'Content-Type': 'text/plain'});

   fetch('https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY')
      .then(res => res.json())
      .then(json => console.log(json));
      
  //response.end(url);
//}).listen(8081);

// Console will print the message
//console.log('Server running at http://127.0.0.1:8081/');