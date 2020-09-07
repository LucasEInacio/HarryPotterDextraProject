angular.module("app").factory("characterFactory", function($http, config){
    var getAll = function(filter, callBack) {
        return $http({
            method: "GET",
            url: config.baseUrl + config.character.crud,
            params: filter
        }).then(callBack);
    };

    var getById = function(id, callBack) {
        return $http({
            method: "GET",
            url: config.baseUrl + config.character.crud + id
        }).then(callBack);
    };

    var insert = function(character, callBack, onError) {
        return $http({
            method: "POST",
            url: config.baseUrl + config.character.crud,
            data: character
        }).then(callBack, onError);
    };

    var update = function(character, callBack, onError) {
        return $http({
            method: "PUT",
            url: config.baseUrl + config.character.crud,
            data: character
        }).then(callBack, onError);
    };

    var deleteCharacter = function(id, callBack) {
        return $http({
            method: "DELETE",
            url: config.baseUrl + config.character.crud + id
        }).then(callBack);
    };

    return {
        getAll,
        getById,
        insert,
        update,
        deleteCharacter
    };
});