﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var len;
var results = '';

function apiSearch() {
    var params = {
        "q": $("#query").val(),
        "count": "50",
        "offset": "0",
        "mkt": "en-us"
    };

    $.ajax({
        url: 'https://maensor-421-search-api.cognitiveservices.azure.com/bing/v7.0/search/?' + $.param(params),
        beforeSend: function (xhrObj) {
            xhrObj.setRequestHeader("Ocp-Apim-Subscription-Key", "05f3dc9eae2041edbc0b33d6b134d142");
        },
        type: "GET",
    })
        .done(function (data) {
            len = data.webPages.value.length;
            for (var = 0; i < len; i++) {
        results += "<p><a href='" + data.webPages.value[i].url + "'>" + data.webPages.value[i].name + "</a>: " + data.webPages.value[i].snippet + "</p>";
    }

    $('#searchResults').html(results);
    $('#searchResults').dialog();
})
        .fail(function () {
    alert("error");
});
}
$(document).ready(function () {
    $('#searchButton').click(function () {
        apiSearch();
    });
});
