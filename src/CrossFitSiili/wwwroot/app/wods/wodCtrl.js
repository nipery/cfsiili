(function () {
    
    angular
      .module('app.wods')
      .controller('wodCtrl', wodCtrl);

    wodCtrl.$inject = ['$state', '$http'];

    function wodCtrl($state, $http) {
        var vm = this;

        vm.wods = [];
        vm.title = 'new kind of Wodcontroller..';

        activate();

        function activate() {

            return getWods();
        }

        function getWods() {

            $http.get("/api/wods").then(function (response) {

                angular.copy(response.data, vm.wods);
                return vm.wods;

            }, function (error) {

                $scope.errorMessage = "Failed to load application list from server. " + error;
            });
        }        
    }

})();