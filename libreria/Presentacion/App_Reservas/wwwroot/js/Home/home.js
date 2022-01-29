$(document).ready(function () {
    var player = {};
    player.id = 5;
    $.ajax({
        url: "Home/Reservar", type: "GET",  contentType: "application/json",
        success: function (result) {
            $.each(result, function (index, value) {
                if (value !== null)
                    $("#titulo").val(value.titulo);
            });
        }
    });
    //data: { player: player },
})