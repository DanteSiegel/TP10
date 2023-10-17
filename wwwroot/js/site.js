$(document).ready(function () {
    $(".info-link").click(function () {
        var info = $(this).data("info");
        $("#infoModalContent").text(info);
        $("#infoModal").show();
    });

    $(".temporadas-link").click(function () {
        var serieId = $(this).data("temporadas");

        $.ajax({
            url: "/Series/Temporadas/" + serieId,
            type: "GET",
            success: function (data) {

            },
            error: function (error) {

            }
        });
    });

    $(".actores-link").click(function () {
        var serieId = $(this).data("actores");


        $.ajax({
            url: "/Series/Actores/" + serieId,
            type: "GET",
            success: function (data) {

            },
            error: function (error) {

            }
        });
    });

    $("#infoModalClose").click(function () {
        $("#infoModal").hide();
    });
});
