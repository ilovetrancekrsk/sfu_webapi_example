var Genres = function (apiHelper) {

    var $scope = {};

    $scope.models = ko.observableArray(null);

    $scope.fetch = function () {
        apiHelper.get('/api/genres', function (data) {
            $scope.models(data);
        });
    };

    return $scope;
};