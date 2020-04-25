var searchIcon = document.getElementsByClassName("search-box__icon")[0];
var searchBox = document.getElementsByClassName("search-box")[0];

searchIcon.addEventListener("click", activateSearch);

function activateSearch() {
    searchBox.classList.toggle("active");
}