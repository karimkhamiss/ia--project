$(document).ready(function(){
    var projects = $("div.projects").html();
    for (var i=0;i<50;i++)
    {
        $("div.projects").append(projects);
    }
})