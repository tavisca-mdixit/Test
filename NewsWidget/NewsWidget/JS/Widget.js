(function () {
    if (window.jQuery === undefined) {
       
        var link = document.createElement("link");
        link.rel = "stylesheet";
        link.href = "http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css";
        document.getElementsByTagName("head")[0].appendChild(link);

        var script = document.createElement('script');
        script.src = "https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js";
        (document.getElementsByTagName("head") || document.documentElement)[0].appendChild(script);
    }
})();

 window.onload=function() {
    cityList = [{ Name: "delhi" }, { Name: "hyderabad " }, { Name: "banglore" }, { Name: "chennai" }, { Name: "pune" }, { Name: "mumbai" }, { Name: "kolkata" }]

    //Adding CSS to the widget
    $("body").append('<div id="divTag"></div>')
    $("#divTag").append('<h1 id="heading">' + "Times of India" + '<h1>')
    $("#divTag").append('<ul id="list"  class ="nav nav-tabs"></ul>')
    $("#divTag").css("class", "container");
    $("#divTag").css("width", "300px");
    $("#divTag").css("background-color", "#141212");
    $("#divTag").css("border", " 2px solid black");
    $("#divTag").css("overflow", "auto");


    //function to create header tabs 
    $.each(cityList, function (n, city) {
        $("#list").append('<li id="' + city.Name + '">' + '<a href="' + '#' + city.Name + '">' + city.Name + "</a>" + "</li>");
    });


    //function to initially load data of delhi city
    $.getJSON("http://training.appyoda.io/api/news/delhi", function (data) {
        $("#divTag").append('<div id="innerDivTag"></div>');
        $("#innerDivTag").append('<ul id="listTwo" class="subheads"></ul>');
        $("#innerDivTag").css("background-color", "#fcf67a");
        $("#innerDivTag").css("border", " 1px solid black");
        $("#innerDivTag").css("overflow", "auto");

        $.each(data.responseData.feed.entries, function (n, entries) {
            $("#listTwo").append('<li>' + '<a href="' + entries.link + '">' + entries.title + '</a>' + '</li><br/>');
        });
    });

    //Function to listen to click events
    $(document).ready(function () {
        $(".nav-tabs a").click(function () {
            $.getJSON("http://training.appyoda.io/api/news/" + this.innerText, function (data) {
                $("#innerDivTag").empty();
                $("#innerDivTag").append('<ul id="listTwo" ></ul>');
                $.each(data.responseData.feed.entries, function (n, entries) {
                    $("#listTwo").append('<li>' + '<a href="' + entries.link + '">' + entries.title + '</a>' + '</li><br/>');
                });
            });
            $(this).tab('show');
        })
    });
 }




