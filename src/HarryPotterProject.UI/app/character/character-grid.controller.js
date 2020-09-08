app.controller("characterGridCtrl", function($scope, $location, characterFactory, harryPotterApi){

        $scope.filter = {};
        $scope.searchCharacters = searchCharacters;
        $scope.addCharacter = addCharacter;
        $scope.viewCharacter = viewCharacter;
        $scope.deleteCharacter = deleteCharacter;
        $scope.editCharacter = editCharacter;

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

    function viewCharacter(id){
        $location.path("view-character").search({id});
    }

    function editCharacter(id){
        $location.path("edit-character").search({id});
    }

    function deleteCharacter(id){
        characterFactory.deleteCharacter(id, function(result){
            if(result.data){
                searchCharacters();
                alert("Deleted Succesfully");
            }
        })
    }
});