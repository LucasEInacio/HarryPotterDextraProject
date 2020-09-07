app.controller("characterGridCtrl", function($scope, $location, characterFactory, harryPotterApi){

        $scope.filter = {};
        $scope.searchCharacters = searchCharacters;
        $scope.addCharacter = addCharacter;
        $scope.close = close;
        $scope.viewCharacter = viewCharacter;
        $scope.deleteCharacter = deleteCharacter;

    Initialize();

    function Initialize(){
        searchCharacters();
        getHouses();
    };

    function getHouses(){
        harryPotterApi.getHouses(function(result){
            $scope.houses = result.data;
        });
    }

    function searchCharacters(){
        characterFactory.getAll($scope.filter, function(result) {
            $scope.characterList = result.data;
        });
    }

    function addCharacter(){
        $location.path("add-character");
    }

    function close(){
        $location.path("character");
    }

    function viewCharacter(id){
        $location.path("view-character").search({id});
    }

    function deleteCharacter(id){
        characterFactory.deleteCharacter(id, function(result){
            if(result.data)
                searchCharacters();
        })
    }
});