(function () {


    function wodCtrl() {

        var vm = this;

        vm.title = 'new kind of Wodcontroller..';
    }

    angular
  .module('app.wods')
  .controller('wodCtrl', wodCtrl);


})();