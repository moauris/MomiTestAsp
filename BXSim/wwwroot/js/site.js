// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var multiOptQuizzes = {};
var sequenceQuizzes = {};

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

        //judge if the question is answer correctly
        //format card based on this
        if (isValid) {
            $(`#${quizId}_exp_card`).addClass(["bg-info", "text-white"]);
        } else {

            $(`#${quizId}_exp_card`).addClass(["bg-warning", "text-black-50"]);
        }
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

class SequenceQuiz {
    constructor(quizId, answerCount) {
        this.quizId = quizId;
        this.answerCount = answerCount;
        this.isAnswerCompleted = false;
        this.stillCorrect = true;
    }
    
}

// A Sequence is a series of answers where the order matters
// This question validates based on $sequence
// invalid = -1
// 0,1,2.. meaning their respective sequence.
function ValidateSequence(sequence, labelId, quizId, answerCount) {
    if (!sequenceQuizzes[quizId])
        sequenceQuizzes[quizId] = new SequenceQuiz(quizId, answerCount);
    var quiz = sequenceQuizzes[quizId];

    if (quiz.isAnswerCompleted) return;
    //Add the content of the card value to step_quizId_i
    var answer = $(`#${labelId}`).text();
    $(`#step_${quizId}_${answerCount - quiz.answerCount}`)
        .html(answer);
    $(`#step_${quizId}_${answerCount - quiz.answerCount}`)
        .removeClass("btn-secondary");
    $(`#step_${quizId}_${answerCount - quiz.answerCount}`)
        .addClass("btn-outline-secondary");
    $(`#${labelId}`).hide();

    if (quiz.stillCorrect) {
        if (sequence < 0) {
            quiz.stillCorrect = false;
        }
        if (quiz.answerCount > 0) {
            //if answers count 4
            //when seq = 0, ans = 4, its correct
            //when seq = 1, ans = 3, its correct
            //when seq = 2, ans = 2, its correct.
            quiz.stillCorrect = (sequence + quiz.answerCount) === answerCount;
        }
    }
    quiz.answerCount--;
    if (!quiz.answerCount) {
        //no answers left to answer, render results
        //$(`#${label}`).removeClass('btn-outline-secondary');
        if (quiz.stillCorrect) {
            $(`#step_${quizId} label`).addClass(["bg-success", "text-white"]);
            $(`#${quizId}_exp_card`).addClass(["bg-info", "text-white"]);
        } else {
            $(`#step_${quizId} label`).addClass(["bg-danger","text-white"]);
            $(`#${quizId}_exp_card`).addClass(["bg-warning", "text-black-50"]);
        }

        $(`#${quizId}_exp`).collapse('show');
        quiz.isAnswerCompleted = true;
    }
}