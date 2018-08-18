/* 
 * Model file
 * Communicates with API
 */
 
var getModel = function (atomic) {
    return {
        getApiValuePromise: function(id){
            return atomic("/api/values/" + id).then(function(response){
                //TODO: Any modification necessary for the viewmodel
                console.log(response.data);
                return {
                    apiValue: response.data
                }
            }, function(error){
                console.log(error);
            });
        }
    };
};