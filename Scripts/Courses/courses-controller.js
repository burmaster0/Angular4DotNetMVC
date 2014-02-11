registrationModule.controller("coursesController", function ($scope, coursesRepository) {
    $scope.courses = coursesRepository.get();
});