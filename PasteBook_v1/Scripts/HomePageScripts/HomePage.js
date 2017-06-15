$(document).ready(function () {

    $('#button_post').on('click', function () {
        AddPost();
    })
    
    $("#textarea_homepage").on('keypress keyup',function () {
        var postLength = $(this).val().length;
        $("#character_counter").text(5000 - postLength + " characters left");
        if (!IsValidPost()) {
           
            $(this).addClass('add-textarea-error');
            $("#add_post_error").text("The maximum characters accepted is 5000");
        } else {
            
            $("#add_post_error").text("");
            $(this).removeClass('add-textarea-error');
        }
    });

    function AddPost() {
        var postLength = $("#textarea_homepage").val().length;

        var data = { content: $("#textarea_homepage").val() };
        if (!IsValidPost()) {

        } else {
            $.ajax({
                url: AddPostUrl,
                type: 'GET',
                data: data,
                success: function () {
                    $("#add_post_error").text("Successfully posted");
                    $('#textarea_homepage').val('');
                },
                error: function () {
                    $("#add_post_error").text("Not successfully posted");
                    alert("not successful");
                }
            });
        }
    }
    function IsValidPost(){
        var postLength =  $("#textarea_homepage").val().length;
        if (postLength > 5000){
            return false;
        }else{
            return true
        }
    }
    
});