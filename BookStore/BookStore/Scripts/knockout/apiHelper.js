var ApiHelper = function() {
    var $scope = {};

    var baseRequest = function (xhr, successCallback, errorCallback) {
        return xhr
            .success(function (data) {
                console.info(data);
                if (typeof successCallback === 'function') {
                    successCallback(data);
                }
            })
            .error(function (p1, p2, p3) {
                console.error(p3);
                if (typeof errorCallback === 'function') {
                    errorCallback(arguments);
                }
            });
    };

    $scope.get = function (url, successCallback, errorCallback) {
        var xhr = $.ajax(url, {
            method: 'GET',
            dataType: 'json'
        });

        return baseRequest(xhr, successCallback, errorCallback);
    };

    $scope.post = function (url, data, successCallback, errorCallback) {
        var xhr = $.ajax(url, {
            method: 'POST',
            dataType: 'json',
            data: data
        });

        return baseRequest(xhr, successCallback, errorCallback);
    };

    return $scope;
};