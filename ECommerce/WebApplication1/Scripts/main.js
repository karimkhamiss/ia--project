$(document).ready(function(){
    var popup;
    $("*").click(function(){
        if(this.hasAttribute('data-popup'))
        {
            popup  = $(this).attr("data-popup");
            $(".background").fadeIn(200,function(){
                $("#"+popup+"-popup").css("top","65px");
            })
        }
    })
    $(".popup-close ,body>.background").click(function(){
        $("#"+popup+"-popup").css("top","-1000px");
        $("body>.background").fadeOut(200,function(){
        })
    })
    height = $("div.page-container").scrollHeight;
    $("div.page-container .nav").height(height);
    width = $("div.page-container .nav").width();
    $("div.page-container .nav nav").width(width);
    $(".drop-down").click(function(){
        if($(this).hasClass("closed-toggle"))
        {
            $(this).removeClass("closed-toggle")
            $(this).next().show(200);
        }
        else
        {
            $(this).addClass("closed-toggle")
            $(this).next().hide(200);
        }
    })
    // $('.selectpicker').selectpicker({
    //     style: 'btn-info',
    //     size: 4
    // });
    $("input.cards-search").keyup(function(){
        var filter = $(this).val();
        var container = $(this).parent().siblings(".cards").find(".card .caption h3");
        container.each(function(){
            if ($(this).text().search(new RegExp(filter, "i")) < 0) {
                $(this).parent().parent().hide(300);
            } else {
                $(this).parent().parent().show(300);
            }
        });
    });
$('.input-container input,.input-container textarea').focus(function(){
    $(this).parents('.input-container').addClass('focused');
});

$('.input-container input,.input-container textarea').blur(function(){
    var inputValue = $(this).val();
    if ( inputValue == "" ) {
        $(this).removeClass('filled');
        $(this).parents('.input-container').removeClass('focused');
    } else {
        $(this).addClass('filled');
    }
})
    // var projects = $("div.projects").html();
    // for (var i=0;i<50;i++)
    // {
    //     $("div.projects").append(projects);
    // }
});