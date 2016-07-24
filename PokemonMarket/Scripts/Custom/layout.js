function moveBackground() {
    window.currentBackgroundPositionX--;
    $("body").css("background-position-x", currentBackgroundPositionX);
}

(function initModeBackGround() {
    window.currentBackgroundPositionX = 0;
    window.setInterval(moveBackground, 20)
})();