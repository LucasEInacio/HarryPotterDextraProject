angular.module("app").value("config", {
    baseUrl: "https://localhost:44339/api/",
    character: {
        crud: "character/"
    },
    harryPotterApi: {
        baseUri: "HarryPotterApi/",
        getHouses: "houses/" 
    }
});