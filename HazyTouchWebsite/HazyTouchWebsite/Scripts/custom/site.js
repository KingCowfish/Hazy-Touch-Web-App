$('.button').click(function () {
	var modal = $(this).data("modal");
	$(this).hide();
	$('.front').addClass('front-open');
	$('.back').addClass('back-open');
	$('.opened').addClass('opened-open');
	$(modal).show();
	setTimeout(function () {
		$('.modal').addClass('shadow');
	}, 1000);
	setTimeout(function () {
		$('.front').removeClass('front-open');
		$('.back').removeClass('back-open');
		$('.opened').removeClass('opened-open');
	}, 1200);
	$('.wrapper').delay(500).fadeIn();
});

$('.close').click(function () {
	$('.wrapper').fadeOut(300);
	$('.modal').removeClass('shadow');
	$('.front').addClass('front-close');
	$('.back').addClass('back-close');
	$('.opened').addClass('opened-close');
	setTimeout(function () {
		$('.modal').hide();
		$('.button').show();
		$('.front').removeClass('front-close');
		$('.back').removeClass('back-close');
		$('.opened').removeClass('opened-close');
	}, 1100)
})

$('.wrapper').click(function () {
	$('.wrapper').fadeOut(300);
	$('.modal').removeClass('shadow');
	$('.front').addClass('front-close');
	$('.back').addClass('back-close');
	$('.opened').addClass('opened-close');
	setTimeout(function () {
		$('.modal').hide();
		$('.button').show();
		$('.front').removeClass('front-close');
		$('.back').removeClass('back-close');
		$('.opened').removeClass('opened-close');
	}, 1100)
})




//outline for smothing out modal transition.  waiting to hear back
//from overstack.com as it currently does not work.

//$('.button').click(function () {
//	if ($(this).attr("trigger") === "0") {
//		$(this).animate({
//			left: $(window).width() / 2,
//			top: $(window).height() / 2
//		}, 100, function () {
//				$(this).hide();
//		});
//		$(this).attr("trigger", "1");
//	}
//	else {
//		$(this).animate({ "left": "0px" }, 100);
//		$(this).attr("trigger", "0");
//	}
//});