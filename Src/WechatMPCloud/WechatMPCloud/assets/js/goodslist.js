(function ($) {
    'use strict';

    $(function () {
      //to do..
    });

    $('.sorting-type>ul>li').click(function () {
        $(this).parent().children(".am-active").removeClass("am-active");
        $(this).addClass("am-active");
     
    })

})(jQuery);
