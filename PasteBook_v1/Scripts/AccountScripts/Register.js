$(document).ready(function ()
{
    RegisterUser();
});

function RegisterUser()
{
    $('.datepicker').datetimepicker();
}

function GetAccount() {
    var userName = $("#newUserName").val();
    var password = $("#newPassword").val();
    var firstName = $("#newFirstName").val();
    var lastName = $("#newLastName").val();
    var birthYear = $("#year").val();
    var birthDay = $("#day").val();
    var birthMonth = $("#month").val();
    var mobileNum = $("#newMobileNum").val();
    var gender = $("#gender").val();
    var emailAdd = $("#newMobileNum").val();
    var birthdate = new Date();

    return { USER_NAME: userName, PASSWORD: password, FIRST_NAME: firstName, LAST_NAME: lastName, MOBILE_NO: mobileNum, EMAIL_ADDRESS: emailAdd, BIRTHDATE: new Date()};


}