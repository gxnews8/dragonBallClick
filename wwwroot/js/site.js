// Write your Javascript code.

var $clickBtn = $('.click-btn'),
    $trainer1Btn = $('.krillin-btn'),
    $trainer2Btn = $('.vegeta-btn'),
    $trainer3Btn = $('.masterRoshi-btn'),
    $trainer4Btn = $('.cell-btn'),
    $trainer5Btn = $('.shenLong-btn'),
    $levelUp = $('.levelUp')

function click(){

}

function ally(who){
    if (act == 'feed') url = '/api/krillin'
    else if (act == 'play') url = '/api/play'
    else if (act == 'work') url = '/api/work'
    else if (act == 'sleep') url = '/api/sleep'
}