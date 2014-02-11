registrationModule.controller("instructorsController", function ($scope, instructorsRepository) {
    $scope.instructors = instructorsRepository.get();
});