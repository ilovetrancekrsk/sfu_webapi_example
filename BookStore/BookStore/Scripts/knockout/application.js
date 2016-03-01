var Application = function (apiHelper, Genres) {

    var $scope = {};

    $scope.header = ko.observable('Knockout JS');
    $scope.genres = new Genres(apiHelper);

    $scope.run = function() {
        $scope.genres.fetch();
    };

    return $scope;
};