artistApp.factory('venueService', function ($http) {

    return {
        doCall: function() {
            //return 'test message';
            var url = 'http://artistmarketplacebackend.azurewebsites.net/api/venues?callback=JSON_CALLBACK';
                //"https://api.mongolab.com/api/1/databases/angularjs-intro/collections/users?apiKey=terrPcifZzn01_ImGsFOIZ96SwvSXgN9";
            //return $http.get(url);
            return $http({
                method: 'JSONP',
                url: url
            });
        }
    };

});