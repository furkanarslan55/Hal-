// Fotoğraf değiştirme dizileri
const photos1 = [
    'https://images.unsplash.com/photo-1522071820081-009f0129c71c?w=800&h=600&fit=crop',
    'https://images.unsplash.com/photo-1556761175-b413da4baf72?w=800&h=600&fit=crop',
    'https://images.unsplash.com/photo-1542744173-8e7e53415bb0?w=800&h=600&fit=crop',
    'https://images.unsplash.com/photo-1519389950473-47ba0277781c?w=800&h=600&fit=crop'
];

const photos2 = [
    'https://images.unsplash.com/photo-1600880292203-757bb62b4baf?w=800&h=600&fit=crop',
    'https://images.unsplash.com/photo-1553877522-43269d4ea984?w=800&h=600&fit=crop',
    'https://images.unsplash.com/photo-1521737711867-e3b97375f902?w=800&h=600&fit=crop',
    'https://images.unsplash.com/photo-1531482615713-2afd69097998?w=800&h=600&fit=crop'
];

let index1 = 0;
let index2 = 0;

// İlk fotoğrafı değiştir
function changePhoto1() {
    const img = document.getElementById('photo1');
    img.style.opacity = '0';

    setTimeout(() => {
        index1 = (index1 + 1) % photos1.length;
        img.src = photos1[index1];
        img.style.opacity = '1';
    }, 500);
}

// İkinci fotoğrafı değiştir
function changePhoto2() {
    const img = document.getElementById('photo2');
    img.style.opacity = '0';

    setTimeout(() => {
        index2 = (index2 + 1) % photos2.length;
        img.src = photos2[index2];
        img.style.opacity = '1';
    }, 500);
}

// Her 4 saniyede bir fotoğrafları değiştir (farklı zamanlarda)
setInterval(changePhoto1, 4000);
setInterval(changePhoto2, 4500);