app.controller("characterCtrl", function($scope, $location, $routeParams, characterFactory, harryPotterApi){

    $scope.close = close;
    $scope.save = save;
    $scope.title = $location.path() == "/add-character" ? "Add Character" : $location.path() == "/view-character" ? "View Character" : "Edit Character";

    $scope.disableControls = $location.path() == "/view-character" ? true : false;

    Initialize();

    function Initialize(){
        if($routeParams.id)
            getCharacter($routeParams.id);
        
        getHouses();
    };

    function getHouses(){
        harryPotterApi.getHouses(function(result){
            $scope.houses = result.data;
        });
    }

    function close(){
        $location.path("character").search("id", null);
    }

    function save(form){
        if(form.$invalid)
            return;

        if($scope.character && $scope.character.id)
            update();
        else
            insert();
    }

    function insert(){
        characterFactory.insert($scope.character, function(result) {
            $scope.character.id = result.data;
        });
    }

    function update(){
        characterFactory.update($scope.character, function(result) {
            result.data;
        });
    }

    function getCharacter(id){
        characterFactory.getById(id, function(result) {
            $scope.character = result.data;
        });

        showToast();
    }

    function showToast(message){
        // $mdToast.show(
        //     $mdToast.simple()
        //     .textContent('Simple Toast!')
        //     // .position(pinTo)
        //     .hideDelay(3000))
        //   .then(function() {
        //     $log.log('Toast dismissed.');
        //   }).catch(function() {
        //     $log.log('Toast failed or was forced to close early by another toast.');
        //   });
    }
});