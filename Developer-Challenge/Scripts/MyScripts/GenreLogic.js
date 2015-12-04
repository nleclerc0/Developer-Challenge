
var app = angular.module('Genrengmodule', []);

//Service to inject pathing and aquire data on different Genres
app.service('Genrengservice', function ($http) {

    this.getGenre = function () {
        var res = $http.get("/Genre/" + value);
        return res;
    };


});

//Controller to retreive data for different Genres
app.controller('Genrengcontroller', function ($scope, ngservice) {
    $scope.Selectors = ["GenreId"];
    $scope.filterValue = "";
    $scope.onClick = function () {
        $scope.output.text = $scope.inputText;
    }

    loadGenres();

    $scope.getGenre = function () {
        var promise = ngservice.getfilteredData($scope.filterValue);
        //var promise = ngservice.getfilteredData($scope.output.text);
        promise.then(function (resp) {
            $scope.Genres = resp.data;
            $scope.Message = "Call is Completed Successfully";
        }, function (err) {
            $scope.Message = "Call Failed " + err.status;
        });
    };
});