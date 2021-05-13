function setProduct(id) {
    const cardName = 'card';
    let card = JSON.parse(window.localStorage.getItem(cardName));

    if (!card) {
        card = [];
    }

    const quantity = card.filter(x => x.key === id)[0] ? +card.filter(x => x.key === id)[0].quantity + 1 : 1;
    card = card.filter(x => x.key !== id);
    card.push({ key: id, quantity });
    window.localStorage.setItem(cardName, JSON.stringify(card));
}

function deleteProduct(id) {
    const cardName = 'card';
    let card = JSON.parse(window.localStorage.getItem(cardName));

}

function decreaseQuantity() {
}

function increaseQuantity() {

}

function getProducts() {
    const cardName = 'card';
    let card = JSON.parse(window.localStorage.getItem(cardName));

}

function getCard() {
    const cardName = 'card';
    let card = JSON.parse(window.localStorage.getItem(cardName));

    if (card) {
        return null;
    }

    return cart;
}

function postContent(dataFromDb) {
    const cardName = 'card';
    let dataToJson = JSON.parse(dataFromDb);
    let cart = JSON.parse(window.localStorage.getItem(cardName));
    let filteredData = [];
    let pic = "";

    for (let product of cart) {

        for (let data of dataToJson) {
            let pic = data.key["picture"];

            if (product.id === data) {
                filteredData.push(data);
                return;
            }
        }
    }

    return pic;
}



/*"[{"id":"0a43835e - 4fb6 - 4f90 - 98e4 - ba5526e2bcde","name":"Kurt Hammet Guitar","price":4879.99,"quantity":11,"picture":"https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632570/musical_shop_product_images/u5luo3a40yq6xg8l5xh3.jpg"},{"id":"0b7847d1-baab-4b68-b878-158b92214ef9","name":"Jim Dunlop Crybaby 535Q Wah Pedal","price":5123.99,"quantity":16,"picture":"https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632319/musical_shop_product_images/xvi7gvfcxw9rnixr8ogq.jpg"},{"id":"372252c1-977d-4140-9949-1c1384a836a1","name":"KAWAI GL20","price":17853.00,"quantity":6,"picture":"https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632479/musical_shop_product_images/ppu0wj4mntqnrptypqdy.jpg"},{"id":"7cd175bd-0f91-4036-ba0c-e725ed1bf4e5","name":"Exclusive Violin","price":32141.00,"quantity":5,"picture":"https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632375/musical_shop_product_images/yuudpwcps7pm0ncm5pdt.jpg"},{"id":"b6b53fc8-f508-46b7-b8d2-6486d9bf7bee","name":"GREG BENNETT MINI ELECTRIC GUITAR","price":4214.99,"quantity":14,"picture":"https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632285/musical_shop_product_images/i2u2i1pwenbbhhp6hbnx.jpg"},{"id":"c6395c03-71a1-4095-ab53-6ee0abcb3708","name":"Cool Ukulele","price":119.99,"quantity":100,"picture":"https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632532/musical_shop_product_images/gdkgnu8tw0ee0ebblay3.jpg"},{"id":"cfdf1b45-2bb3-496c-8f38-c2a054a771ad","name":"Lâg HyVibe THV30DCE","price":3659.99,"quantity":12,"picture":"https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632170/musical_shop_product_images/bkxhp1un78kfi5rozwjm.jpg"},{"id":"daab42d6-4354-4f37-88b4-6a07afbc2a25","name":"Rincon Tenor Ukulele","price":299.99,"quantity":40,"picture":"https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632408/musical_shop_product_images/t3vmvilc98fftgavtt7r.jpg"},{"id":"f229930d-d4d0-4739-b988-5200b193060c","name":"Acoustic Drums","price":8953.00,"quantity":8,"picture":"https://res.cloudinary.com/dnbwy7p6f/image/upload/v1619632446/musical_shop_product_images/qrs9cilcayb9i8oilrcd.jpg"}]"*/