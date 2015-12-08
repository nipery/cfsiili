//bookingCtrl.js
(function () {

    angular
      .module('app.booking')
      .controller('bookingCtrl', adminCtrl);

    adminCtrl.$inject = ['$state', '$http'];

    function adminCtrl($state, $http) {
        var vm = this;

        vm.wods = [];
        vm.title = 'booking controller';
    }
})();

