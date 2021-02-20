function createAlert() {
}

function createPrompt(question) {
    return prompt(question);
}

function setElementTextById(id, text) {
    document.getElementById(id).innerText = text;
}



function giveMeRandomInt() {
    DotNet.invokeMethodAsync('ServerBlazor', 'GenerateRandomInt')
        .then(result => {
            setElementTextById('randomNumberSpan', result);
        });
}