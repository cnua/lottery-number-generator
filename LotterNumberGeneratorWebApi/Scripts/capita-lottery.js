var app = angular.module('capitaLotteryApp', []);
app.controller('capitaLotteryController', function($scope, $http) {
        $scope.numberSetCount = 1;
        $scope.CapitaLotteryTicket = {};//{ "NumberSet": [[7, 14, 34, 41, 3, 12], [18, 22, 34, 1, 3, 5]], "TicketReference": "7d900dc9421d4eea9d5b6942250dd9b0" };
 
    $scope.GenerateLotteryTicket = function () {

        $http.get("api/CapitaLotteryDTO?numberSetCount=" + $scope.numberSetCount).
        success(function (data, status, headers, config) {
            $scope.CapitaLotteryTicket = data;
        }).
        error(function (data, status, headers, config) {
            alert("An error occurred during the AJAX request");
        });

   }
});
