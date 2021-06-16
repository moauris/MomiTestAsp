// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function CheckAnswer(correctAns, selectedAns, labelId) {
    console.log(`The answer to this question is ${correctAns}`);
    console.log(`User selected ${selectedAns}`);
    console.log(`User answer is ${correctAns === selectedAns ? "Correct" : "Incorrect"}`);

    document.getElementById(labelId).classList = ['btn',
        correctAns === selectedAns ? 'btn-success' : 'btn-danger',
        'text-left', 'border-0'].join(' ');
    return;
}