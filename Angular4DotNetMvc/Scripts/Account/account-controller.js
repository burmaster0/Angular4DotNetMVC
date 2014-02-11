registrationModule.controller('accountController', function ($scope, $location, accountRepository) {
    $scope.errors = [];
    $scope.save = function (student) {
        accountRepository.save(student).$promise.then(
            function () { $location.url('Registration/Courses'); },
            function (response) { $scope.errors = response.data; }
            );
    };
});