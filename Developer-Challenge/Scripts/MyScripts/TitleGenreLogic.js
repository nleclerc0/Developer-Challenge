
var app = angular.module('TitleGenrengmodule', []);

//Service to inject pathing and aquire data on different TitleGenres
app.service('TitleGenrengservice', function ($http) {

    this.getTitleGenre = function () {
        var res = $http.get("/TitleGenre/" + value);
        return res;
    };


});

//Controller to retreive data for different TitleGenres
app.controller('TitleGenrengcontroller', function ($scope, ngservice) {
    $scope.Selectors = ["TitleGenreId"];
    $scope.filterValue = "";
    $scope.onClick = function () {
        $scope.output.text = $scope.inputText;
    }

    loadTitleGenres();

    $scope.getTitleGenre = function () {
        var promise = ngservice.getfilteredData($scope.filterValue);
        //var promise = ngservice.getfilteredData($scope.output.text);
        promise.then(function (resp) {
            $scope.TitleGenres = resp.data;
            $scope.Message = "Call is Completed Successfully";
        }, function (err) {
            $scope.Message = "Call Failed " + err.status;
        });
    };
});