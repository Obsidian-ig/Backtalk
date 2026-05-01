window.setupClickEventListener = (dotNetHelper, methodName) => {
    window.addEventListener('click', (event) => {
        dotNetHelper.invokeMethodAsync(methodName);
    });
};