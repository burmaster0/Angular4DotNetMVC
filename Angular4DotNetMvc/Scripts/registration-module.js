var registrationModule = angular.module("registrationModule", ["ngRoute", 'ngResource'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when("/Registration/Courses", {
            templateUrl: "/templates/courses.html", controller: "coursesController"
        });
        $routeProvider.when("/Registration/Instructors", {
            templateUrl: "/templates/instructors.html", controller: "instructorsController"
        });
        $routeProvider.when("/Registration/CreateAccount", {
            templateUrl: "/templates/create-account.html", controller: "accountController"
        });
        $locationProvider.html5Mode(true);
    });