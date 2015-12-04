
var app = angular.module('Participantngmodule', []);

//Service to inject pathing and aquire data on different Participants
app.service('Participantngservice', function ($http) {

    this.getParticipant = function () {
        var res = $http.get("/Participant/" + value);
        return res;
    };


});

//Controller to retreive data for different Participants
app.controller('Participantngcontroller', function ($scope, ngservice) {
    $scope.Selectors = ["ParticipantId"];
    $scope.filterValue = "";
    $scope.onClick = function () {
        $scope.output.text = $scope.inputText;
    }

    loadParticipants();

    $scope.getParticipant = function () {
        var promise = ngservice.getfilteredData($scope.filterValue);
        //var promise = ngservice.getfilteredData($scope.output.text);
        promise.then(function (resp) {
            $scope.Participants = resp.data;
            $scope.Message = "Call is Completed Successfully";
        }, function (err) {
            $scope.Message = "Call Failed " + err.status;
        });
    };
});