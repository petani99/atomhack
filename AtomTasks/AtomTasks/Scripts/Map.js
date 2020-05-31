
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
    alert(x + '\n' + y + '\n' + z)
    $.ajax({
        // В файле data.json заданы геометрия, опции и данные меток .
        url: 'http://localhost:52724/home/taskpoints/'
        , success: function (data) { objectManager.add(data); }
        , error: function (x, y, z) { alert(x + '\n' + y + '\n' + z); }});

}
