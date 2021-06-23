// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var multiOptQuizzes = {};

function CheckAnswer(correctAns, selectedAns, labelId) {
    document.getElementById(labelId).classList = ['btn',
        correctAns === selectedAns ? 'btn-success' : 'btn-danger',
        'text-left', 'border-0'].join(' ');
    return;
}

function ValidateOption(isValid, labelId, quizId, numOpts) {
    if (multiOptQuizzes[quizId] === undefined) {
        multiOptQuizzes[quizId] = new MultiOptQuiz(quizId, numOpts);
    }
    var quiz = multiOptQuizzes[quizId];

    if (quiz.tries === 0) return;
    quiz.tries--;
    if (quiz.tries === 0) {
        //uncollapse the explanation on all answer supplied 
        //regardless of right or wrong
        console.log("Trying to display collapsibles");
        $(`#${quizId}_exp`).collapse('show');
    }
    var colorCssClass = "btn-danger";
    if (isValid) {
        quiz.optionsLeft--;
        quiz.partiallyCorrectPeers.push(labelId);
        console.log(`There are ${quiz.optionsLeft} correct options left to be selected`)
        console.log(`${quiz.optionsLeft > 0}`)
        if (quiz.optionsLeft > 0) {
            console.log("The answer is valid but still opptions left");
            colorCssClass = "btn-warning";
        } else {

            console.log("The answer is valid and no opptions left");
            colorCssClass = "btn-success";
            quiz.isAnswerCompleted = true;
        }
        quiz.partiallyCorrectPeers.forEach(x => {
            document.getElementById(x).classList = ['btn',
                colorCssClass,
                'text-left', 'border-0'].join(' ');
        });
    } else {
        document.getElementById(labelId).classList = ['btn',
            colorCssClass,
            'text-left', 'border-0'].join(' ');
    }
    
}

class MultiOptQuiz {
    constructor(quizId, optionsLeft) {
        this.quizId = quizId;
        this.optionsLeft = optionsLeft;
        this.tries = optionsLeft;
        this.partiallyCorrectPeers = [];
    }
}