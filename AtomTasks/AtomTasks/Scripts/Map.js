
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
   
    $.ajax({
        url: '/api/tasks/'
        , beforeSend: function () {alert("Test")}
        , success: function (data) { objectManager.add(data); }
        , error: function (x, y, z) { alert(x + '\n' + y + '\n' + z); }});

}
