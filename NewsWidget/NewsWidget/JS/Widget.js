


window.onload = function () {
    someList = [{ FirstName: "delhi " }, { FirstName: "hyderabad " }, { FirstName: "banglore" }, { FirstName: "chennai" }, { FirstName: "pune" }, { FirstName: "mumbai" }, { FirstName: "kolkata" }]


    $("#divTable").append('<ul id="list"  class ="nav nav-tabs"></ul>');
    $.each(someList, function (n, elem) {
        $("#list").append('<li id="' + elem.FirstName + '">' + '<a href="' + '#' + elem.FirstName + '">' + elem.FirstName + "</a>" + "</li>");
        $("#divTable").append('<div id=" '+ elem.FirstName + '" ></ul>');
    });

    $.getJSON("http://training.appyoda.io/api/news/delhi", function (data) {

        $("#divTable").append('<div id="innerDiv"></div>');
        $("#innerDiv").append("<ul id='listTwo' ></ul>");
        $.each(data.responseData.feed.entries, function (n, entries) {

            $("#listTwo").append('<li>' + '<a href="' + entries.link + '">' + entries.title + '</a>' + '</li><br/>');
        });
    });

    $(document).ready(function () {
        $(".nav-tabs a").click(function () {          
            $.getJSON("http://training.appyoda.io/api/news/"+this.innerText,function (data) {
                $("#innerDiv").empty();
                $("#innerDiv").append("<ul id='listTwo' ></ul>");
                $.each(data.responseData.feed.entries, function (n, entries) {

                    $("#listTwo").append('<li>' + '<a href="' + entries.link + '">' + entries.title + '</a>' + '</li><br/>');
                });
            });
             $(this).tab('show');
        })
    });
}


