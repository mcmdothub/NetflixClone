
const gridCarousel = document.querySelector(".js-carousel"),
  items = document.querySelectorAll(".js-item"),
  itemsArray = Array.from(items),
  carouselScrollWidth = gridCarousel.scrollWidth,
  carouselVisibleWidth = gridCarousel.clientWidth;

gridCarousel.style.gridTemplateColumns = `repeat(${itemsArray.length}, 200px)`;

console.log(carouselScrollWidth, carouselVisibleWidth);
