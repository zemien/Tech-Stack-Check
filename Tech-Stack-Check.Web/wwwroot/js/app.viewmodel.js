/*
 * ViewModel
 * Links model with view
 */

//Note: has an implicit dependency on DOM, JQuery, Placeholders, and Animate
var getViewmodel = function (model) {
    return {
        initialize: function() {
            //TODO Any control initialization steps

            model.getApiValuePromise(2).then(function(response){
                //This shows how placeholder.js is used
                var template = "I called the api and it returned: {{apiValue}}";
                var renderedText = placeholders(template, response);
                var elem = document.getElementById("apivalue");

                if (elem){
                    elem.innerHTML = renderedText;
                }
            });

            var animationElement = document.querySelector('#animationElement');

            //All click event handlers come here
            document.addEventListener('click', function (event) {

                // Show the element
                if (event.target.matches('.animate-in')) {
                    //This shows how animate.js is used
                    animate(animationElement, 'fadeInDown');
                }

                //  Hide the element
                if (event.target.matches('.animate-out')) {
                    animate(animationElement, 'fadeOutUp', true);
                }

            }, false);
        }
    };
};