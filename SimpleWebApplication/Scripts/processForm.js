
$(document).ready(function () {
    $('#contact-form').validate({
        rules: {
            name: {
                minlength: 3,
                required: true
            },
            email: {
                required: true,
                email: true
            },
            message: {
                minlength: 3,
                required: true
            },
        },
        highlight: function (label) {
            $(label).closest('.control-group').addClass('error');
        },
        success: function (label) {
            label
				.text('OK!').addClass('valid')
				.closest('.control-group').addClass('success');
        }
    });

});

$("#cancel").click(function () {
    $("label.error").hide();
    $(".error").removeClass("error");
});

$("#submit").click(function () {

    if ($("#contact-form").valid()) {
        var formData = $('#contact-form').serialize();
        $.support.cors = true;
        $.ajax({
            url: "http://localhost:51817/api/Contactform/Post",
            type: "POST",
            crossDomain: true,
            data: formData,
            dataType: "html",
            success: function (result) {
                $('#contactForm').html(result);
            },
            error: function (jqXHR, tranStatus, errorThrown) {
                $('#contactForm').html("<h3>POST Error!</h3>Browser may not support <a href='http://en.wikipedia.org/wiki/Cross-origin_resource_sharing#Browser_support'>Cross Origin Resource Sharing</a> ");
            }
        });
    }
});



