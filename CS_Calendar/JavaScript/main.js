function animateForm() {
    $('form').animate({ height: "toggle", opacity: "toggle" }, "slow");
}

function validateFieldsRegister() {
    if (document.getElementById('registerUsername').value === "") {
        return false;
    }
    else if (document.getElementById('registerEmail').value === "") {
        return false;
    }
    else if (document.getElementById('registerPassword').value === "") {
        return false;
    }
    else if (document.getElementById('registerRetype').value === "") {
        return false;
    }
    else {
        return true;
    }
}

function validateFieldsLogin() {
    if (document.getElementById('inputUsername').value === "") {
        return false;
    }
    else if (document.getElementById('inputPassword').value === "") {
        return false;
    }
    else {
        return false;
    }
}

