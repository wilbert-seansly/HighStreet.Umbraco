

NavShrink = function (id) {

    this.id = id;
    this.initialHeight = 0;

    function setupNav(id) {
        initialHeight = $("#" + id).height() + 80;

        $(window).scroll(function () {
            if (!menuOpen) {
                if ($(document).scrollTop() > initialHeight) {
                    if (!$("#" + id).hasClass("navbar-shrink")) {
                        $("#" + id).addClass("navbar-shrink");
                    }

                } else {
                    if ($("#" + id).hasClass("navbar-shrink")) {
                        $("#" + id).removeClass("navbar-shrink");
                    }
                }
            }
            
        });
    }

    setupNav(this.id);
};