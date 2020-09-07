angular.module("app").factory("harryPotterApi", function ($http, config){
    var getHouses = function(callback){
        return $http({
            method: "GET",
            url: config.baseUrl + config.harryPotterApi.baseUri + config.harryPotterApi.getHouses
        }).then(callback);
    };

    return { getHouses };
})