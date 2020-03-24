$(() => {
    $("input").on('keyup', function () {
        ensureValidity();
        setNewsLetterCheckbox();
    });

    //$("#my-form").on('submit', function () {
    //    $("#newsletter").prop('disabled', false);
    //});

    function isValid() {
        const firstName = $("#first-name").val();
        const lastName = $("#last-name").val();
        const age = $("#age").val();
        return firstName && lastName && age;
    }

    function ensureValidity() {
        $("#submit-button").prop('disabled', !isValid());
    }

    function setNewsLetterCheckbox() {
        const age = $("#age").val();
        if (!age) {
            return;
        }
        if (parseInt(age) < 50) {
            $("#newsletter").prop('disabled', false);
            $("#my-hidden").remove();
        }
        else {
            $("#newsletter").prop('checked', true);
            $("#newsletter").prop('disabled', true);
            $("#my-form").append("<input type='hidden' name='subscribetonewsletter' id='my-hidden' value='true' />")
        }
    }
});