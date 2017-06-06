$(document).ready(function () {
    CheckUser();
});

function CheckUser() {
    $("#loginUser").click(function () {
        var account = GetAccount();

        $.ajax({
            url: checkAccountUrl,
            type: "POST",
            data: account,
            //contentType: 'application/json; charset=utf-8',
            datatype: "json",
            success: function (data) {
                if (data.accountExists == true) {
                    $("#successLabel").html(data.M);
                }
                else {
                    $("#successLabel").html(data.M);
                }
            },
            error: function (data) {
                $("#successLabel").html(data.M);
            }
        })
    });

}

function GetAccount() {
    var userName = $("#userName").val();
    var password = $("#userPassword").val();

    return { UserName: userName, Password: password };


}