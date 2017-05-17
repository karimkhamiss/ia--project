$(document).ready(function(){
    var cards = $("section.current-projects div.cards").html();
    for (var i=0;i<3;i++)
    {
        $("section.current-projects div.cards").append(cards);
    }
})