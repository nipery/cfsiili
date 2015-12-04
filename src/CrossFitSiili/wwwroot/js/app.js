//app.js
//var settingManager = angular.module('settingManager', ['ngRoute', 'xeditable']);




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
        });

    //.when('/app/:appId', {
    //        templateUrl: 'pages/app.html',
    //        controller: 'appController'
    //    });
});

cfsiili.controller('mainController', ['$scope', function ($scope) {
    $scope.message = 'Iam in main page';
}]);


cfsiili.controller('wodController', ['$scope', function ($scope) {
    $scope.message = 'Iam in wod page';

    $scope.wods = [
  { id: 1, title: 'PERJANTAI 4.12.2015', wod: "Back squat 3-2-1-1-1" +
      "" +
      "4 rounds for time" +
      "21 Box jumps 24/20" +
      "18 KB swing 32/24" +
    "15 Wall ball" +
    "12 Burpees" },
  { id: 2, name: 'IsTwoScreenModeOn', wod: "Is two screen mode on"  },
  { id: 3, name: 'FontSliderValue', wod: "Font slider value" }
    ];
}]);