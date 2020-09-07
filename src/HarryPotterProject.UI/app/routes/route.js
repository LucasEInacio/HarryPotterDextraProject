app.config(function($routeProvider) {
    
    $routeProvider
        .when("/home", {
            templateUrl: "app/views/home.html",
            controller: "homeCtrl"
        })

        .when("/character", {
            templateUrl: "app/character/views/character-grid.html",
            controller: "characterGridCtrl"
        })

        .when("/add-character", {
            templateUrl: "app/character/views/character.html",
            controller: "characterCtrl"
        })

        .when("/view-character", {
            templateUrl: "app/character/views/character.html",
            controller: "characterCtrl"
        })

        .otherwise({ redirectTo: "/" });
});