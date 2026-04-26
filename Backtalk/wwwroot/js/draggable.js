document.addEventListener("DOMContentLoaded", (event) => {
    gsap.registerPlugin(Draggable, InertiaPlugin);
});

window.gsapInterop = {
    makeDraggable: function (selector) {
        if (!window.gsap || !window.Draggable) {
            console.error("GSAP or Draggable not loaded");
            return;
        }

        gsap.registerPlugin(Draggable);

        return Draggable.create(selector, {
            type: "x,y",
            edgeResistance: 0.65,
            inertia: false,
            cursor: "inherit",
            dragClickables: false,
            onDrag: function () {
                console.log("onDrag!");
            }
        });
    }
};