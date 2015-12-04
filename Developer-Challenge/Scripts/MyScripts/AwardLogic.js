
var app = angular.module('Awardngmodule', []);

//Service to inject pathing and aquire data on different Awards
app.service('Awardngservice', function ($http) {

    this.getAward = function () {
        var res = $http.get("/Award/" + value);
        return res;
    }; 


});

//Controller to retreive data for different Awards
app.controller('Awardngcontroller', function ($scope, ngservice) {
    $scope.Selectors = ["AwardId"];   
    $scope.filterValue = "";
    $scope.onClick = function () {
        $scope.output.text = $scope.inputText;
    }

    loadAwards();

    $scope.getAward = function () {
        var promise = ngservice.getfilteredData($scope.filterValue);
        //var promise = ngservice.getfilteredData($scope.output.text);
        promise.then(function (resp) {
            $scope.Awards = resp.data;
            $scope.Message = "Call is Completed Successfully";
        }, function (err) {
            $scope.Message = "Call Failed " + err.status;
        });
    };
});