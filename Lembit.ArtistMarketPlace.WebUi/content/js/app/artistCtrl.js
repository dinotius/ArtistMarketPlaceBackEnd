artistApp.controller('artistController', function ($scope, venueService) {
    //'$scope', function ($scope) {
        //$scope.greeting = 'hello';

        $scope.callNotify = function () {

            venueService.doCall().
                success(function (users) {
                    $scope.greeting = users;
                })
                .error(function (status, body) {
                    $scope.greeting = body;
                });
        }
    }
);

