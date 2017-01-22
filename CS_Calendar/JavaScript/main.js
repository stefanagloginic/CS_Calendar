function main() {
    $('#loginWrap').animate({ height: "toggle", opacity: "toggle" }, "slow"); // makes the form appear after dom has loaded.
}

$(document).ready(main); //makes sure dom is loaded before running function main();

function animateForm() {
    $('#loginWrap').animate({ height: "toggle", opacity: "toggle" }, "slow");
    $('#loginWrap').promise().done(function () {
        $('#registerWrap').animate({ height: "toggle", opacity: "toggle" }, "slow");
    });
}

function animateFormReg() {
    $('#registerWrap').animate({ height: "toggle", opacity: "toggle" }, "slow");
    $('#registerWrap').promise().done(function () {
        $('#loginWrap').animate({ height: "toggle", opacity: "toggle" }, "slow");
    });
}

function validateFieldsRegister() {
    if (document.getElementById('registerUsername').value == "") {
        document.getElementById('registerUsername').style.background = "rgba(255, 0, 0, 0.4)";
        return false;
    }
    else if (document.getElementById('registerEmail').value == "") {
        document.getElementById('registerEmail').style.background = "rgba(255, 0, 0, 0.4)";
        return false;
    }
    else if (document.getElementById('registerPassword').value == "") {
        document.getElementById('registerPassword').style.background = "rgba(255, 0, 0, 0.4)";
        return false;
    }
    else if (document.getElementById('registerRetype').value == "") {
        document.getElementById('registerRetype').style.background = "rgba(255, 0, 0, 0.4)";
        return false;
    }
    else {
        return true;
    }
}

function validateFieldsLogin() {
    if (document.getElementById('inputUsername').value == "") {
        document.getElementById('inputUsername').style.background = "rgba(255, 0, 0, 0.4)";
        return false;
    }
    else if (document.getElementById('inputPassword').value == "") {
        document.getElementById('inputPassword').style.background = "rgba(255, 0, 0, 0.4)";
        return false;
    }
    else {
        return true;
    }
}