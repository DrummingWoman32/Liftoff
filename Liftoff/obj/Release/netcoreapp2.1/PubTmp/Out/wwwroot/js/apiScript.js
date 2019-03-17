'use strict';

//i'm implementing the bing maps local search api

$(document).ready(() => {

    //testing for now...

    //now to display the results on the front end...
    function accessAPI() {
        const app = document.getElementById('results');

        const container = document.createElement('div');
        container.setAttribute('class', 'container');

        app.appendChild(container);


        //create request variable and assign a new XMLHttpRequest object to it
        var request = new XMLHttpRequest();

        request.open('GET', 'https://dev.virtualearth.net/REST/v1/LocalSearch', true);

        request.onload = function () {

            //Begin accessing JSON data here
            var data = JSON.parse(this.response);

            if (request.status >= 200 && request.status < 400) {
                data.forEach(business => {

                    const card = document.createElement('div');
                    card.setAttribute('class', 'card');

                    const h3 = document.createElement('h3');
                    h3.textContent = business.name;

                    const p = document.createElement('p');
                    business.address = business.address.substring(0, 300);
                    p.textContent = `${business.address}...`;

                    const h4 = document.createElement('h4');
                    h4.textContent = business.telephone;

                    container.appendChild(card);

                    card.appendChild(h3);
                    card.appendChild(p);
                    card.appendChild(h4);
                });

            } else {
                const errorMessage = document.createElement('h4');
                errorMessage.textContent = `Sorry, no results`;
                app.appendChild(errorMessage);
            }
        }

        //send request
        request.send();
    }

    

   
//function lookForResults() {


        /*$.ajax({
            url: ,
            type: "GET",
            success: (data) => {
                $.each(data['business'], (key, value) => {
                    //console.log(key);
                    $('#results').append(key, value);
                });

            // $.each( array/object,  ( key, value ) => {
            //   // run this code at each loop
            // } );

            error: (err) => {
                //console.log(err);
                document.getElementById("results").innerHTML = "Sorry, no results.";
            }
    //}*/

    /*
     * upon some event happening, like when the submit button is hit after
     * the user enters something in the search bar:
     * $.ajax({
     *      type: 'GET',
     *      url: apiurl in double quotes,
     *      dataType: 'json',
     *      success: function(data) {
     *          $.each(data, function(index, val) {
     *              //append each business to the results div
     *          });
     *      }
     * });
     */

});

    
    
    
            /*so what i need to do is call the api, return search results
             * and then spit out the search results. look up how search bars
             * work and then implement that in code. Use GET request parameters
             * to know what user is searching for, and then use POST request
             * to post results. Learn to debug the issues. check that i'm
             * sending the right parameters, then pass those parameters to the api
             * when make call to api, then get results back and spit 'em out (the
             * api call returns json), and then display it on front-end*/

            //use google along with resources i already use, if use google
            //check date it was posted, u don't want something from 2010, for example

            //look up how ajax displays search results

            //-------------------------------------------------------------------
            /* to make app mobile phone-friendly, read bootstrap documentation
             * to know what classes to apply to code, and to test app, change size
             * of screen and if everything then looks like screen of mobile phone,
             * it is done well.*/
            //-------------------------------------------------------------------

            //--------------------------------------------------------------------
            /* refer to C# tutorials from LC101 for save functionality, although
             with rest of time left, this would best be saved for last, whether
             or not this can be part of MVP depends on how fast i can get stuff
             done.*/
            //--------------------------------------------------------------------


            //the parameters for bizsearch seem to be text, submit, searchBy
            // for example --https://localhost:44368/Account/BizSearch?text=Kendall+Bakery&submit=Search&searchBy=name--
        //},
        
    //});



// Parts of an API REQUEST
  // BASEURL    > /* http://www.dogapi.com*/
  // ENDPOINT / ROUTE / Query Paramter    >    "/breed/hounds/images" or "?breed=hounds&type=images"
  // Request Type / Method / Verb     >     GET, POST...
  // Headers    >    Authorization, Content-type, User-Agent
  // Body [for post requests]    >    content you need to pass to the API [json object]

// Parts of an API RESPONSE
  // Headers
  // Status Code
  // Body

//I think I kind of understand...so the api request needs the api url with the needed parameters
//and then there is the api response







// BACKTICKS
// Allows Multiline strings
// $('#content').append( "<img src='" + imageLink + "'>" );
// $('#content').append( `<img src='${ imageLink }'>` );