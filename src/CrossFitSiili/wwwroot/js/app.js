//app.js

var cfsiili = angular.module('cfApp', ['ngRoute']);

cfsiili.config(function ($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: 'pages/main.html',
            controller: 'mainController'
        })
        .when('/wod/', {
            templateUrl: 'pages/wods.html',
            controller: 'wodController'
        })
        .when('/manage/', {
            templateUrl: 'pages/managementMain.html',
            controller: 'managementMainController'
        })
        .when('/manage/wod', {
            templateUrl: 'pages/manage/wod.html',
            controller: 'wodController'
        });

    
});

cfsiili.controller('mainController', ['$scope', function ($scope) {
  

}]);


cfsiili.controller('wodController', ['$scope','$http', function ($scope,$http) {

    $scope.wods = [];
    $scope.isCreating = false;
    
    $http.get("/api/wods")
       .then(function (response) {
           angular.copy(response.data, $scope.wods);
       
       }, function (error) {
       
           $scope.errorMessage = "Failed to load application list from server. " + error;
       });

    $scope.toggle = function () {
        $scope.isCreating = !$scope.isCreating;
    }
 
}]);