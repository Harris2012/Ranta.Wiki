function BlogService($resource, $q) {
    var blog_resource = $resource('api/blog', {}, {
        create: {
            method: 'POST',
            url: '/api/blog/create'
        },
        update: {
            method: 'PUT',
            url:'/api/blog/:id'
        }
    });

    return {
        create: function (blog) {
            var d = $q.defer();
            blog_resource.create({}, blog, function (result) {
                d.resolve(result);
            }, function (result) {
                d.reject(result);
            });
            return d.promise;
        },
        update: function () {
            var d = $q.defer();
            blog_resource.update({}, function (result) {
                d.resolve(result);
            }, function (result) {
                d.reject(result);
            });
            return d.promise;
        }
    }
}