/*
 * ViewModel
 * Links model with view
 */

//Note: has an implicit dependency on DOM, JQuery, Placeholders, and Animate
var getViewmodel = function (model) {
    return {
        initialize: function() {
            //TODO Any control initialization steps

            var animationElement = document.querySelector('#animation-element');
            var notificationContainer = document.getElementById('notification-container');

            window.fitText(document.querySelector('.responsive-headline'));

            model.getApiValue(2).then(function(response) {
                //This shows how placeholder.js is used
                var template = 'I called the api and it returned: {{apiValue}}';
                var renderedText = placeholders(template, response);
                var elem = document.getElementById('apivalue');

                if (elem){
                    elem.innerHTML = renderedText;
                }
            });

            //SignalR connection
            var connection = new signalR.HubConnectionBuilder()
                .withUrl('/notificationHub')
                .configureLogging(signalR.LogLevel.Information)
                .build();

            //All SignalR handlers here
            connection.on('ServerTime', function(serverTime) { 
                //Another example of using placeholders.js
                var notificationTemplate = 
                    '<div class="alert {{alertType}}" role="alert">' +
                    '    The current server time is reported to be: {{serverTime}}' +
                    '</div>';
                var notificationData = {
                    serverTime: serverTime,
                    alertType: 'alert-info'
                };
                var tempContainer = document.createElement('div');
                tempContainer.innerHTML = placeholders(notificationTemplate, notificationData);
                notificationContainer.appendChild(tempContainer.firstChild);
            });

            //Start SignalR connection after all handlers are set up
            connection.start().catch(function(err) {
                console.error(err.toString());
            });

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

                //Call notification hub
                if (event.target.matches('.notify')) {
                    connection.invoke('PingServerTime', 'serverTime').catch(function(err) {
                        console.error(err.toString())
                    });
                }
            }, false);

        }
    };
};