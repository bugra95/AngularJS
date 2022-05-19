(function () {
    "use strict";

    // Cihaz hazır olduğunda tetiklenen metottur. addEventListener metodu içerisine eklediğimiz ilk parametrenin yazımı çok önemlidir! Bu parametre eventin çeşidini belirtir. Yanlış yazıldığında doğru event tetiklenmeyecektir. İkinci parametre, event tetiklendiğinde çalışacak olan metodun adıdır. Metot isimlerinden sonra gelen .bind( this ) kısımları silinebilir. 
    document.addEventListener( 'deviceready', onDeviceReady, false );

    function onDeviceReady() {
        alert('on device ready');

        document.addEventListener( 'pause', onPause, false );
        document.addEventListener( 'resume', onResume, false );
        
        
        //var parentElement = document.getElementById('deviceready');
        //var listeningElement = parentElement.querySelector('.listening');
        //var receivedElement = parentElement.querySelector('.received');
        //listeningElement.setAttribute('style', 'display:none;');
        //receivedElement.setAttribute('style', 'display:block;');
    };

    function onPause() {
        alert('on pause');
    };

    function onResume() {
        alert('on resume');
    };
} )();