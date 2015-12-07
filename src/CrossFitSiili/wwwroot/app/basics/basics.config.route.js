//config.route.js

(function () {

    'use strict';

    angular
        .module('app.basics')
        .config([
            '$urlRouterProvider', '$stateProvider', function($urlRouterProvider, $stateProvider) {
                $urlRouterProvider.otherwise('/');

                $stateProvider
                  .state('basics.prices', {
                    url: '/prices',
                    templateUrl: 'app/basics/pricelist.html'

                }).state('basics.schedule', {
                        url: '/schedule',
                        templateUrl: 'app/basics/schedule.html'

                }).state('basics.rules', {
                    url: '/rules',
                    templateUrl: 'app/basics/rules.html'

                }).state('basics.workouts', {
                    url: '/workouts',
                    templateUrl: 'app/basics/workouts.html'

                }).state('basics.dict', {
                    url: '/dict',
                    templateUrl: 'app/basics/dictionary.html'

                });

            }
        ]);

})();