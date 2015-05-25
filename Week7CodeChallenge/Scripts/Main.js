//make sure page is ready
$(document).ready(function () {
    //listens for a click of anything with the class of fakesiteTab
    $('Body').on('click', '.fakesiteTab', function (event) {
        //set new variable to grab it's href attr
        var tabUrl = $(this).attr('href');
        //disable normal behavior of <a> tag
        event.preventDefault();

        //then make get action for Ajax
        $.get(tabUrl, function (data) { $('#bodyContent').html(data)});
    });
});