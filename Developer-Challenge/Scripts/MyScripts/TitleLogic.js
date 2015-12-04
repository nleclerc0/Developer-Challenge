
var app = angular.module('ngmodule', []);

//Service to inject pathing and aquire data on different Titles
app.service('ngservice', function ($http) {
    
    this.getTitles = function () {
        var res = $http.get("/Title");
        return res;
    };

    this.getfilteredData = function (value) {
        var res;
        if (value.length == 0) {
            res = $http.get("/Title");
            return res;
        } else {
            res = $http.get("/Title/" + value);
            return res;
        }

    };


});

//Controller to retreive data for different Titles
app.controller('ngcontroller', function ($scope, ngservice) {
    $scope.Selectors = ["TitleName"];
    $scope.SelectedCriteria = ""; 
    $scope.filterValue = ""; 
    $scope.onClick = function () {
        $scope.output.text = $scope.inputText;
    }

    loadTitles();

    function loadTitles() {
        var promise = ngservice.getTitles();
        promise.then(function (resp) {
            $scope.Titles = resp.data;
            $scope.Message = "Call is Completed Successfully";
        }, function (err) {
            $scope.Message = "Call Failed " + err.status;
        });
    };

    $scope.getFilteredData = function () {
        var promise = ngservice.getfilteredData($scope.filterValue);
        //var promise = ngservice.getfilteredData($scope.output.text);
        promise.then(function (resp) {
            $scope.Titles = resp.data;
            $scope.Message = "Call is Completed Successfully";
        }, function (err) {
            $scope.Message = "Call Failed " + err.status;
        });
    };
});