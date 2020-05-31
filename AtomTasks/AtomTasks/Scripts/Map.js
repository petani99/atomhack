
ymaps.ready(init);

function init() {
    var myMap = new ymaps.Map('map', {
        center: [56.80713643662941, 61.32392772418745],
        zoom: 14
    }, {
        searchControlProvider: 'yandex#search'
    }),
        objectManager = new ymaps.ObjectManager();
    
    myMap.geoObjects.add(objectManager);
    myMap.events.add('click', function (e) {
        if (!(document.getElementById('newTask').style.display == 'none'))
        var coords = e.get('coords');
        $('#geopointX').val(coords[0].toPrecision(6));
        $('#geopointY').val(coords[1].toPrecision(6));
        myMap.balloon.open(coords, 'Местонахождение отмечено!<br><sup>Вы можете закрыть или выбрать другое местоположение.</sup>');
    });
    $.ajax({
        url: '/api/tasks/'
        , beforeSend: function () {alert("Test")}
        , success: function (data) { objectManager.add(data); }
        , error: function (x, y, z) { alert(x + '\n' + y + '\n' + z); }});

}
