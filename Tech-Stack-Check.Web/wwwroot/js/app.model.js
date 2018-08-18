/* 
 * Model file
 * Communicates with API
 */
 
var getModel = function (atomic) {
    return {
        getApiValue: function(id){
            return atomic("/api/values/" + id).then(function(response){
                //TODO: Any modification necessary for the viewmodel
                console.log(response.data);
                return {
                    apiValue: response.data
                }
            }, function(error){
                console.log(error);
            });
        },
        //Jasmine unit test demo method only
        add: function (a, b) {
            return a + b;
        }
    };
};