const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'https://localhost:7067';

//const PROXY_CONFIG = [
//  {
//    context: [
//      "/weatherforecast",
//    ],
//    target,
//    secure: false
//  }
//]

const PROXY_CONFIG = [
  {
    context: ["/api"],               // proxy all /api requests
    target: "http://localhost:5000", // use HTTP if backend runs on 5000
    secure: false,                   // ignore self-signed certificates (HTTPS optional)
    changeOrigin: true,
    logLevel: "debug"                // prints proxy info in terminal
  }
];

module.exports = PROXY_CONFIG;
