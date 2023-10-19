
function cargarYMostrarTemporadas(serieId) {
    $.ajax({
        url: "/Home/GetTemporadasSerieAjax/" ,
        type: "POST",
        dataType: "JSON",
        success: 
         function (response) {
          
          
            console.log(response)
          let temporadaHtml = '';
          for(let i = 0; i<response.length; i++)
          {
            temporadaHtml+= response[i].numeroTemporada + ' - ' + response.tituloTemporada
          }
          $('#info').html(temporadaHtml);
          $('#nombreModal').html("Temporadas")
        }
        });
      
}


function cargarYMostrarActores(serieId) {
    $.ajax({
        url: "/Home/GetActoresSerieAjax/" ,
        type: "POST",
        dataType: "JSON",
        success: 
        
        function (response) {
          
          
            console.log(response)
          let actoresHtml = '';
          for(let i = 0; i<response.length; i++)
          {
            actoresHtml+= response[i]
          }
          $('#info').html(actoresHtml);
          $('#nombreModal').html("Actores")
        }
      
    });
}

function MasInfo(serieId)
{
$.ajax(
{
    url: "/Home/GetMasInfo/" ,
    type: "POST",
    data: {Serieid:serieId},
    success:
    function(response)
    {
        console.log(response)
        $('#info').html("Sinopsis: " + response.sinopsis + "Año Inicio " + response.añoInicio)
        $('#nombreModal').html("Mas Info");
    }
}

);
}