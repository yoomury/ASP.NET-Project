
(function ()
{
    /*
    var element = $("#username");
    //element.innerHTML = "Vladut"
    element.text("Vladut");

    var main = $("#main");
    main.on("mouseenter",  function() {
        main.style = "background-color: #888;";
    });

    main.on("mouseleave", function() {
        main.style = "";
    });

    var menuItems = $("ul.menu li a");
    menuItems.on("click",function() {
        var me = $(this);
        alert("Hello" + me.text());
    });*/

    var $sidebarAndWrapper = $("#sidebar,#wrapper");
    $("#sidebarToggle").on("click", function() {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidearAndWrapper.hasClass("hide-sidebar")) {
            $(this).Text("Show SideBar");
        } else {
            $(this).Text("Hide SideBar");
        }
    });

})();   