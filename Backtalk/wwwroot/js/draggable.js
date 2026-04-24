document.addEventListener("DOMContentLoaded", (event) => {
    gsap.registerPlugin(Draggable, InertiaPlugin);
});

window.initDraggable = (element) => {
    Draggable.create(element, {
        type: "x,y",
        edge
    });
}