const navigationBar = document.querySelector("nav");
const contentArea = document.querySelector(".content");
const btnSlider = document.querySelector(".sliderButton");
const checkbox = document.querySelector("#flexCheckDefault");
const iconArrow = document.querySelector(".fa-chevron-left")

btnSlider.addEventListener("click", () => {

    if (checkbox.checked) {
        navigationBar.classList.add("nav-show");
        navigationBar.classList.remove("nav-hide");

        iconArrow.classList.remove("pos-right");
        iconArrow.classList.add("turn-left");
        iconArrow.classList.add("pos-left");
        iconArrow.classList.remove("turn-right");

        contentArea.style.width = "calc(100% - 260px)";
        checkbox.checked = false;
    }
    else {
        navigationBar.classList.remove("nav-show");
        navigationBar.classList.add("nav-hide");

        iconArrow.classList.remove("pos-left");
        iconArrow.classList.add("turn-right");
        iconArrow.classList.add("pos-right");
        iconArrow.classList.remove("turn-left");

        contentArea.style.width = "calc(100% - 50px)";
        checkbox.checked = true;
    }
});
