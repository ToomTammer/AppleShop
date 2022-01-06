var n = 1;
function pic_change() {
    switch (n) {
        case 1: document.getElementById('show').src = "/image/b1.png"; break;
        case 2: document.getElementById('show').src = "/image/b2.jpeg"; break;
        case 3: document.getElementById('show').src = "/image/b3.jpeg"; break;
        case 4: document.getElementById('show').src = "/image/b4.jpeg"; break;
    }

    if (n == 1) {
        document.getElementsByClassName('icon1').disabled = true;
        document.getElementsByClassName('icon2').disabled = false;
    } else if (n == 4) {
        document.getElementsByClassName('icon1').disabled = false;
        document.getElementsByClassName('icon2').disabled = true;
    } else {
        document.getElementsByClassName('icon1').disabled = false;
        document.getElementsByClassName('icon2').disabled = false;
    }
}

