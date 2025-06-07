try {

    if (5 != eval("(() => 5)()")) {
        alertInvalidBrowser();
    } else if ("hello" != eval("`hello`")) {
        alertInvalidBrowser();
    } else if (5 != eval("let x = 5; x")) {
        alertInvalidBrowser();
    } else if (!window.MutationObserver) {
        alertInvalidBrowser();
    } else {
        const appBasePath = "%V<APP_BASE_PATH>"
        $.ajax({
            url: appBasePath + "script/vault.js?_=" + Math.round(Math.random() * 1000000),
            dataType: 'script'
        });
    }

} catch (e) {
    alertInvalidBrowser();
}

function alertInvalidBrowser() {
    alert("A böngésző nem képes futtatni a Vault-ot, kérjük próbálja újra egy újabb verziójú Chrome, Firefox, Safari vagy Edge böngészővel.");
}