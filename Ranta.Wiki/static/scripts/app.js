var wiki_module = angular.module('wiki', ['ngResource', 'ui.codemirror']);

//services
wiki_module.service('BlogService', ['$resource', '$q', BlogService]);

//controllers
wiki_module.controller('new_blog_controller', ['$scope', 'BlogService', NewBlogController]);