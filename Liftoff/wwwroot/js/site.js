// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

'use strict';

$(document).ready(function () {
    n = new Date();
    y = n.getFullYear();
    m = n.getMonth() + 1;
    d = n.getDate();
    document.getElementById("date").innerHTML = m + "/" + d + "/" + y;

    //let's create the empty editable spreadsheet

    var table = document.getElementById("trackingSheet");
    var i;

    for (i = 1; i < 65; i++) {

        //table.append("<tr><td></td></tr>");
        table.insertRow(i);

    }

    $('#trackingSheet').editableTableWidget();

    $('#trackingSheet').editableTableWidget({ editor: $('<textarea>') });

    $('#trackingSheet').editableTableWidget({
        cloneProperties: ['background', 'border', 'outline']
    });

    /*$('table td').on('validate', function (evt, newValue) {
        if (....) {
        return false; // mark cell as invalid
    }
});

    $('table td').on('change', function (evt, newValue) {
        // do something with the new cell value
        if (....) {
        return false; // reject change
    }
});*/
});


