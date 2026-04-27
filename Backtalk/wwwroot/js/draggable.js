document.addEventListener("DOMContentLoaded", (event) => {
    gsap.registerPlugin(Draggable, InertiaPlugin);
});

window.gsapInterop = {
    makeDraggable: function (selector) {
        if (!window.gsap || !window.Draggable) {
            console.error("GSAP or Draggable not loaded");
            return;
        }

        const draggableElement = document.querySelector(selector);

        const draggable = Draggable.create(selector, {
            type: "x,y",
            edgeResistance: 0.65,
            inertia: false,
            cursor: "inherit",
            dragClickables: false,
            onPress: function (e) {
                const rect = this.target.getBoundingClientRect();
                const handleSize = 35;

                const nearRight = e.clientX >= rect.right - handleSize;
                const nearBottom = e.clientY >= rect.bottom - handleSize;

                if (nearRight && nearBottom) {
                    this.disable();
                }
            }
        })[0];

        draggableElement.addEventListener("mouseup", () => {
            if (!draggable.enabled()) {
                draggable.enable();
                draggable.update();
            }
        });
    }
};