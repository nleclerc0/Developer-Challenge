
var app = angular.module('OtherNamengmodule', []);

//Service to inject pathing and aquire data on different OtherNames
app.service('OtherNamengservice', function ($http) {

    this.getOtherName = function () {
        var res = $http.get("/OtherName/" + value);
        return res;
    };


});

//Controller to retreive data for different OtherNames
app.controller('OtherNamengcontroller', function ($scope, ngservice) {
    $scope.Selectors = ["OtherNameId"];
    $scope.filterValue = "";
    $scope.onClick = function () {
        $scope.output.text = $scope.inputText;
    }

    loadOtherNames();

    $scope.getOtherName = function () {
        var promise = ngservice.getfilteredData($scope.filterValue);
        //var promise = ngservice.getfilteredData($scope.output.text);
        promise.then(function (resp) {
            $scope.OtherNames = resp.data;
            $scope.Message = "Call is Completed Successfully";
        }, function (err) {
            $scope.Message = "Call Failed " + err.status;
        });
    };
});