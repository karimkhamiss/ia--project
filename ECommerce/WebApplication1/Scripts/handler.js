function button_waiting(button)
{
    var text = button.html();
    button.prop('disabled', true)
    button.animate({
        opacity:.8
    },400,function(){
        button.html(text+"<img width='22' src='img/button_loading.gif'>");
    });
}
function button_finish(button)
{
    button.children('i').fadeOut();
    button.css({
        opacity:1
    });
    selector.prop('disabled', false)
}
function waiting()
{
    $("#background").fadeIn();
    $("#waiting_loading").fadeIn();
}
function finish()
{
    $("#background").fadeOut();
    $("#waiting_loading").fadeOut();
}
function reload()
{
        waiting();
        $("#waiting_loading").append("<b class='text-center ' style='padding:5px 20px;font-size:18px;display: block !important; width:100% !important;'>Sorry , The page will reload now <br> Try Again Later</b>");
        $("#waiting_loading").delay(2500).fadeOut(function () {
            location.reload();
        });
}