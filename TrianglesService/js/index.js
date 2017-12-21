
$(document).ready(function () {

    // add vertices drop-down options
    var opts = "<option value=\"0\">0</option><option value= \"10\">10</option><option value=\"20\">20</option><option value=\"30\">30</option><option value=\"40\">40</option><option value=\"50\">50</option><option value=\"60\">60</option>";
    $("#v1x").append(opts);
    $("#v1y").append(opts);
    $("#v2x").append(opts);
    $("#v2y").append(opts);
    $("#v3x").append(opts);
    $("#v3y").append(opts);
    
    // hide input sections
    $('#echoice').change(function () {
        if ($(this).val() == 'rc') {
            $('.rowcol').show();
            $('.verts').hide();

        }
        if ($(this).val() == 'verts') {
            $('.rowcol').hide();
            $('.verts').show();
        }
    });

    // call ajax functions on submit
    $('#btnSubmit').click(function (event) {
        if ($('#echoice').val() == 'rc' )
            GetVertices($("#triRow").val(), $("#triCol").val());

        if ($('#echoice').val() == 'verts')
            GetRowColumn($("#v1x").val(), $("#v1y").val(), $("#v2x").val(), $("#v2y").val(), $("#v3x").val(), $("#v3y").val());

    });

    $('.verts').hide();
    
});

// retrieves vertices from web api service call
function GetVertices(row, column) {

    var param = { row: row, column: column };

    $.ajax({

        url: "api/GetVertices",
        data: param, 
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" },
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            alert("v1x: " + data.V1x + ", v1y: " + data.V1y + "\n" +
                "v2x: " + data.V2x + ", v2y: " + data.V2y + "\n" +
                "v3x: " + data.V3x + ", v3y: " + data.V3y);            
        },
        error: function (data) {
            alert("There was an retrieving the vertices: " + data.error);
        }

    });

}

// retrieves row and column from web api service call
function GetRowColumn(v1x, v1y, v2x, v2y, v3x, v3y) {

    var param = { V1x: v1x, V1y: v1y, V2x: v2x, V2y: v2y, V3x: v3x, V3y: v3y };

    $.ajax({

        url: "/api/GetRowColumn",
        data: param,
        method: "GET",
        headers: { "Accept": "application/json; odata=verbose" },
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            alert("row: " + data.Row + ", column: " + data.Column);
        },
        error: function (data) {
            alert("Invalid vertices entered, please use the grid image as a guide.");
        }

    });

}
