function NewBlogController($scope, BlogService) {

    $scope.init = function () {

        $scope.editorOptions = {
            mode: 'gfm',
            styleActiveLine: true,
            lineNumbers: true,
            lineWrapping: true
        };
    };

    $scope.create = function () {

        if ($scope.blog.title == null || $scope.blog.title.length == 0) {
            alert("填写文章标题");
            return;
        }

        if ($scope.blog.body == null || $scope.blog.body.length == 0) {
            alert("请填写正文");
            return;
        }

        var request = $scope.blog;
        //request.__RequestVerificationToken = $('input[name="__RequestVerificationToken"]').val();

        BlogService.create(request).then(function (result) {
            console.log(result);
        })

        //$.post("/blog/new", request, function (response) {

        //    $('#responseContent').empty();

        //    if (response.status == 0) {

        //        var data = response.data;

        //    } else {
        //        console.log("出错了");
        //    }
        //})
    };
}