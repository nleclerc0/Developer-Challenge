
var app = angular.module('TitleParticipantngmodule', []);

//Service to inject pathing and aquire data on different TitleParticipants
app.service('TitleParticipantngservice', function ($http) {

    this.getTitleParticipant = function () {
        var res = $http.get("/TitleParticipant/" + value);
        return res;
    };


});

//Controller to retreive data for different TitleParticipants
app.controller('TitleParticipantngcontroller', function ($scope, ngservice) {
    $scope.Selectors = ["TitleParticipantId"];
    $scope.filterValue = "";
    $scope.onClick = function () {
        $scope.output.text = $scope.inputText;
    }

    loadTitleParticipants();

    $scope.getTitleParticipant = function () {
        var promise = ngservice.getfilteredData($scope.filterValue);
        //var promise = ngservice.getfilteredData($scope.output.text);
        promise.then(function (resp) {
            $scope.TitleParticipants = resp.data;
            $scope.Message = "Call is Completed Successfully";
        }, function (err) {
            $scope.Message = "Call Failed " + err.status;
        });
    };
});