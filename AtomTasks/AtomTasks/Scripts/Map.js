
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
         // В файле data.json заданы геометрия, опции и данные меток .
        url: "../json/data.json",
        header: "Content-type: text/html; charset=utf-8"

    }).done(function (data) {
        objectManager.add(data);
    });

}
