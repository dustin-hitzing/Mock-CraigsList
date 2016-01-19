namespace MockCraigsList {

    angular.module("MockCraigsList", ['ngRoute', 'ui.bootstrap'])
        .config(function ($routeProvider) {
            //$routeProvider.when('/', {
            // templateUrl: '/path/to/view',
            // controller: MockCraigsList.Controllers.ControllerClass,
            // controllerAs: 'views variable name for controller'
            //});
            $routeProvider.when('/', {
                template: 'hello world'
            })
                .when('/listings', {
                    templateUrl: '/ngApp/views/listListings.html',
                    controller: MockCraigsList.Controllers.ListListingController,
                    controllerAs: 'displayList'
                });

        });
}          