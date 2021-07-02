const btnFacebook = document.querySelector(".wrapper .btn-facebook");
const btnTwitter = document.querySelector(".wrapper .btn-twitter");
const btnLinkedIn = document.querySelector(".wrapper .btn-linkedin-in");
const btnYoutube = document.querySelector(".wrapper .btn-youtube");
const btnInstagram = document.querySelector(".wrapper .btn-instagram");
const AlertBox = document.querySelector("#alertBox");
const AlertCloseButton = document.querySelector("#alertBox button");

const inputMail = document.getElementById("input-mail");
const inputPassword = document.getElementById("input-pass");
const StudentLoginBtn = document.getElementById("studentRadioBtn");
const AcademicianLoginBtn = document.getElementById("academicianRadioBtn");


// Link Yönlendirmeleri --------------------------------------------

btnFacebook.addEventListener("click", () =>{
    window.open("https://www.facebook.com/frtbasinyayin");
});
btnTwitter.addEventListener("click", () =>{
    window.open("https://twitter.com/firatresmihesap");
});
btnLinkedIn.addEventListener("click", () =>{
    window.open("https://www.linkedin.com/school/firat-university/");
});
btnYoutube.addEventListener("click", () =>{
    window.open("https://www.youtube.com/c/F%C4%B1rat%C3%9CniversitesiResmiHesab%C4%B1");
});
btnInstagram.addEventListener("click", () =>{
    window.open("https://www.instagram.com/firatresmihesap/");
});

// Harf girişini önleyen fonksiyon --------------------------------------

function isInputNumber(event){
    var character = String.fromCharCode(event.which);

    if(StudentLoginBtn.checked){

        if(!/[0-9]/.test(character)){
            event.preventDefault();
        }
    }
}

// İnputların içini null yapan fonksiyonlar -----------------------------

StudentLoginBtn.addEventListener("click",()=>{
    inputMail.value = "";
    inputPassword.value = "";
});

AcademicianLoginBtn.addEventListener("click",()=>{
    inputMail.value = "";
    inputPassword.value = "";
});

// Uyarı kutusunu kapatma fonksiyonu ---------------------------------------

AlertCloseButton.addEventListener("click",()=>{

    alertBox.classList.remove("alert-show");
    alertBox.classList.add("alert-hide");
});