export function ShowPrompt(element, dotNetReference) {
    element.addEventListener('click', () => {
        dotNetReference.invokeMethodAsync('IncrementCount');
    });
}