// Write your Javascript code.

var $clickBtn = $('.click-btn'),
    $trainer1Btn = $('.krillin-btn'),
    $trainer2Btn = $('.vegeta-btn'),
    $trainer3Btn = $('.masterRoshi-btn'),
    $trainer4Btn = $('.cell-btn'),
    $trainer5Btn = $('.shenLong-btn'),
    $levelUp = $('.levelUp')


$trainer1Btn.on('click', function(){
    console.log('krillin');
    $.post('/add/krillin', function(data){
        console.log('request returned'+data);
    });
})
$trainer2Btn.on('click', function(){
    console.log('vegeta');
    $.post('/add/vegeta', function(data){
        console.log('request returned'+data);
    });
})
$trainer3Btn.on('click', function(){
    console.log('roshi');
    $.post('/add/roshi', function(data){
        console.log('request returned'+data);
    });
})
$trainer4Btn.on('click', function(){
    console.log('cell');
    $.post('/add/cell', function(data){
        console.log('request returned'+data);
    });
})
$trainer5Btn.on('click', function(){
    console.log('shenLong');
    $.post('/add/shenLong', function(data){
        console.log('request returned'+data);
    });
})

function click(){

}

function bindAlly()