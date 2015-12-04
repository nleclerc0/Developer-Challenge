
var app = angular.module('StoryLinengmodule', []);

//Service to inject pathing and aquire data on different StoryLines
app.service('StoryLinengservice', function ($http) {

    this.getStoryLine = function () {
        var res = $http.get("/StoryLine/" + value);
        return res;
    };


});

//Controller to retreive data for different StoryLines
app.controller('StoryLinengcontroller', function ($scope, ngservice) {
    $scope.Selectors = ["StoryLineId"];
    $scope.filterValue = "";
    $scope.onClick = function () {
        $scope.output.text = $scope.inputText;
    }

    loadStoryLines();

    $scope.getStoryLine = function () {
        var promise = ngservice.getfilteredData($scope.filterValue);
        //var promise = ngservice.getfilteredData($scope.output.text);
        promise.then(function (resp) {
            $scope.StoryLines = resp.data;
            $scope.Message = "Call is Completed Successfully";
        }, function (err) {
            $scope.Message = "Call Failed " + err.status;
        });
    };
});