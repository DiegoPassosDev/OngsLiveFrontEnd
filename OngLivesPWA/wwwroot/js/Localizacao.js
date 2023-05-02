$("main").append("<script src='https://maps.googleapis.com/maps/api/js?key=AIzaSyA5caEwpXijUm3VTmIg6fRpZ0DFiXj95hw&callback=initMap' defer></script>");

// Initialize and add the map
function initMap() {
    // The location
    var aracaju = { lat: -10.9095, lng: -37.0748 };
    // The map, centered at location
    var map = new google.maps.Map(document.getElementById("map"), {
        zoom: 12,
        center: aracaju,
    });
    // The marker, positioned at location
    let orla = { lat: -10.9943417, lng: -37.0529881 };
    const ong1 = new google.maps.Marker({
        position: orla,
        map: map,
    });

    const ong2 = new google.maps.Marker({
        position: aracaju,
        map: map,
    });

    const ong3 = new google.maps.Marker({
        position: { lat: -10.9691348, lng: -37.0888108 },
        map: map,
    });
}

window.initMap = initMap;