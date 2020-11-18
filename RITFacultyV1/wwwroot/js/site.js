// go back to top on reload
$(window).on('load', function () {
    $("body, html").animate({
        scrollTop: 0
    }, 'slow');
});



$(document).ready(function () {

    // target modal screen and open it on lick
    $('.modal_open_degrees').click(function () {
        var target = $(this).data("target");
        $('html').addClass('is-clipped');
        $(target).addClass('is-active');
        $('.delete').click(function () {
            $("html").removeClass("is-clipped");
            $(target).removeClass('is-active');
        });
    });

    $('.faculty-box').click(function () {
        var target = $(this).data("target");
        $('html').addClass('is-clipped');
        $(target).addClass('is-active');
        $('.delete').click(function () {
            $("html").removeClass("is-clipped");
            $(target).removeClass('is-active');
        });
    });

    $('.modal_open_minors').click(function () {
        var target = $(this).data("target");
        $('html').addClass('is-clipped');
        $(target).addClass('is-active');
        $('.delete').click(function () {
            $("html").removeClass("is-clipped");
            $(target).removeClass('is-active');
        });
    });

    $('#open_emp').click(function () {
        var target = $(this).data("target");
        $('html').addClass('is-clipped');
        $(target).addClass('is-active');
        $('.delete').click(function () {
            $("html").removeClass("is-clipped");
            $(target).removeClass('is-active');
        });
    });

    $('#open_coop').click(function () {
        var target = $(this).data("target");
        $('html').addClass('is-clipped');
        $(target).addClass('is-active');
        $('.delete').click(function () {
            $("html").removeClass("is-clipped");
            $(target).removeClass('is-active');
        });
    });

    // add ids to the cards created above
    $('.degrees-undergrad-name').each(function (i) {
        this.id = 'degrees-undergrad-image_' + i;
    });
    $('.degrees-grad-name').each(function (i) {
        this.id = 'degrees-grad-image_' + i;
    });
    $('.minors-name').each(function (i) {
        this.id = 'minors-image_' + i;
    });
    
    /**
     * add icons to the cards
     */
    $('#degrees-undergrad-image_0').prepend('<i class="fa fa-mobile-alt fa-7x" style="color:#fe2a70; padding-top: 30px; "></i>');
    $('#degrees-undergrad-image_1').prepend('<i class="fa fa-brain fa-7x" style="color:#f8b64d; padding-top: 30px; "></i>');
    $('#degrees-undergrad-image_2').prepend('<i class="fa fa-laptop fa-7x" style="color:#00a2ff; padding-top: 30px;"></i>');
    $('#degrees-grad-image_0').prepend('<i class="fa fa-keyboard fa-7x" style="color:#fe2a70; padding-top: 30px; "></i>');
    $('#degrees-grad-image_1').prepend('<i class="fa fa-users fa-7x" style="color:#f8b64d; padding-top: 30px; "></i>');
    $('#degrees-grad-image_2').prepend('<i class="fa fa-database fa-7x" style="color:#00a2ff; padding-top: 30px;"></i>');
    $('#icon_Web').prepend('<i class="fab fa-html5 fa-7x" style = "color: #e34f26; padding-top: 30px;"></i>');
    $('#icon_Net').prepend('<i class="fas fa-project-diagram fa-7x" style = "color: #8c2bd6; padding-top: 30px;"></i>');
    $('#minors-image_0').prepend('<i class="fa fa-database fa-5x" style="color:#F5D76E; padding-top: 30px;"></i>');
    $('#minors-image_1').prepend('<i class="fas fa-map-marker-alt fa-5x" style="color:#37AEF0; padding-top: 30px;"></i>');
    $('#minors-image_2').prepend('<i class="fas fa-heartbeat fa-5x" style="color:#019875; padding-top: 30px;"></i>');
    $('#minors-image_3').prepend('<i class="fas fa-code fa-5x" style="color:#6C7A89; padding-top: 30px;"></i>');
    $('#minors-image_4').prepend('<i class="fa fa-mobile-alt fa-5x" style="color:#F27935; padding-top: 30px; "></i>');
    $('#minors-image_5').prepend('<i class="fas fa-project-diagram fa-5x" style = "color: #EB974E; padding-top: 30px;"></i>');
    $('#minors-image_6').prepend('<i class="fab fa-html5 fa-5x" style = "color: #5ED0C9; padding-top: 30px;"></i>');
    $('#minors-image_7').prepend('<i class="fas fa-wifi fa-5x" style = "color: #A9ACAE; padding-top: 30px;"></i>');

    // get height of navbar
    $('#progress_site').css({
        top: $('.navbar').innerHeight()
    });

    // change between burger menu and flex menu
    $(".navbar-burger").click(function () {
        $(".navbar-burger").toggleClass("is-active");
        $(".navbar-menu").toggleClass("is-active");
    });

    // style function contained in the plugin
    $('#coopTable').DataTable({
        ordering: true
    });

    $('#empTable').DataTable({
        ordering: true
    });


     // increase or decrease the value of the progress bar according to the scroll
    $(window).scroll(function () {
        let s = $(this).scrollTop();
        let d = $(document).height() - $(window).height();
        let scrollPercentage = (s / d) * 100;
        $('#progress_site').attr('value', scrollPercentage);
    });

    // icon disappears when not on top of the page
    $(window).scroll(function () {
        if ($(this).scrollTop()) {
            $('#go_to_top').fadeIn();
        } else {
            $('#go_to_top').fadeOut();
        }
    });

    // when icon is clicked, go back to top of menu
    $("#go_to_top").click(function () {
        $("html, body").animate({
            scrollTop: 0
        }, 1000);
    });
});