let dotNetObjectReferences = [];

window.ClickLibrary = {
    init: function (methodName, dotNetRef) {
        window.addEventListener('click', this.onClick);
    },
    apply: function (methodName, dotNetRef) {
        let exists = dotNetObjectReferences.some(item => item.ref === dotNetRef && item.method === methodName);
        if (!exists) {
            dotNetObjectReferences.push({ ref: dotNetRef, method: methodName });
        }
    },
    onClick: function () {
        for (const dotNetAndMethod of dotNetObjectReferences) {
            try {
                if (dotNetAndMethod.ref) {
                    dotNetAndMethod.ref.invokeMethodAsync(dotNetAndMethod.method);
                }
            } catch (error) {
                console.log("Skipped a bad dotNetRef.");
            }
        }
    },
    cleanup: function (methodName, dotNetRef) {
        dotNetObjectReferences = dotNetObjectReferences.filter(item => !(item.ref === dotNetRef && item.method === methodName));
    }
}