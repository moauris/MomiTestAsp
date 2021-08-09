CREATE SCHEMA IF NOT EXISTS db_bxsim CHARACTER SET utf8;

USE db_bxsim;

CREATE TABLE IF NOT EXISTS tbl_practicesets (
    id INT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    Code CHAR(8) NOT NULL UNIQUE KEY,
    Title VARCHAR(100) NOT NULL UNIQUE,
    IntroPage TEXT
) ENGINE=INNODB;

CREATE TABLE IF NOT EXISTS tbl_scenarios (
    id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    PageText TEXT,
    PracticeID INT NOT NULL REFERENCES tbl_practicesets(id) 
        ON DELETE CASCADE
) ENGINE=INNODB;

CREATE TABLE IF NOT EXISTS tbl_quizzes (
    id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    Question VARCHAR(255),
    ScenarioID INT NOT NULL REFERENCES tbl_scenarios(id)
        ON DELETE CASCADE
) ENGINE=INNODB;

CREATE TABLE IF NOT EXISTS tbl_options (
    id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    Content VARCHAR(255) NOT NULL
) ENGINE=INNODB;

CREATE TABLE IF NOT EXISTS rel_optionquiz (
    id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    QuizID INT NOT NULL REFERENCES tbl_quizzes(id)
        ON DELETE CASCADE,
    OptionID INT NOT NULL REFERENCES tbl_options(id)
        ON DELETE CASCADE,
    AnswerState TINYINT NOT NULL
) ENGINE=INNODB;

INSERT INTO tbl_practicesets (Code, Title, IntroPage) VALUES (
    'TRCLR001',
    'Technical Rehydration - C# CLR',
    '<p>Technical Rehydration series are designed to quickly pick-up knowledge points from past learning sessions.</p>
    <p>For this particular practice set we focus on the CLR mechanisms in C#.</p>
    <p>Most knowledge points can be found in the book <i>CLR via C#</i>.</p>'
);

INSERT INTO tbl_scenarios (PageText, PracticeID) VALUES (
    'In C#, we often use the new operator to initialize new instance of a type.',
    @prac_id:=(SELECT MAX(id) FROM tbl_practicesets)
);

INSERT INTO tbl_options (Content) VALUES ('Yes');
INSERT INTO tbl_options (Content) VALUES ('No');
INSERT INTO tbl_quizzes (Question, ScenarioID) VALUES (
    "What is the first thing the 'new' operator does?",
    @scen_id:=(SELECT MAX(id) FROM tbl_scenarios)
);

SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);

INSERT INTO tbl_options (Content) VALUES (
    'Request to allocate memory on heap'
);

SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, 0
);

INSERT INTO tbl_options (Content) VALUES (
    "Call the type's constructor function to initialize the instance"
);

SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);

INSERT INTO tbl_options (Content) VALUES (
    "Build resources that this instance is trying to access"
);

SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);

INSERT INTO tbl_options (Content) VALUES (
    "Validates the security requirements to prevent memory leakage"
);

SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);

INSERT INTO tbl_practicesets (Code, Title, IntroPage) VALUES (
    'DyCRM001',
    'Dynamics 365 - Set I',
    '<p>Fundamental Level Learning Material for Microsoft Dynamics 365</p>'
);

INSERT INTO tbl_scenarios (PageText, PracticeID) VALUES (
    '<p>The Microsoft Dynamics CRM focuses mainly on Sales, Marketing, and Customer Service sectors.</p>
    <p>However, Microsoft has been marketing it as an XRM platform.</p>',
    @prac_id:=(SELECT MAX(id) FROM tbl_practicesets)
);

INSERT INTO tbl_quizzes (Question, ScenarioID) VALUES (
    "What does the term 'XRM' stand for?",
    @scen_id:=(SELECT MAX(id) FROM tbl_scenarios)
);
SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);

INSERT INTO tbl_options (Content) VALUES (
    "Xamarin Refactoring Model"
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);

INSERT INTO tbl_options (Content) VALUES (
    "Extreme Relation Management"
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);

INSERT INTO tbl_options (Content) VALUES (
    "Just like CRM, but with the C being replaced by anything"
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, 0
);

INSERT INTO tbl_quizzes (Question, ScenarioID) VALUES (
    "By marketing Dynamics CRM as 'XRM', Microsoft encourages partners to _____ .",
    @scen_id:=(SELECT MAX(id) FROM tbl_scenarios)
);
SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);

INSERT INTO tbl_options (Content) VALUES (
    "customize it via proprietary framework"
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, 0
);
INSERT INTO tbl_options (Content) VALUES (
    "think creatively in an competitive business environment"
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);
INSERT INTO tbl_options (Content) VALUES (
    "use tightly sealed but dynamic and flexible default feature offerings"
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);
INSERT INTO tbl_options (Content) VALUES (
    "stay away from trying to temper with the official functionalities"
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);

INSERT INTO tbl_practicesets (Code, Title, IntroPage) VALUES (
    'Azure900',
    'AZ900 Quiz Set',
    '<p>Want to pass the AZ900 Could Fundamentals Certificate Exam?</p>
    <p>Practice on interactive quizzes.</p>
    <p>Reinforce your knowledge.</p>'
);

INSERT INTO tbl_practicesets (Code, Title, IntroPage) VALUES (
    'Azure104',
    'AZ104 Quiz Set',
    '<p>Want to pass the AZ104 Could Administrator Certificate Exam?</p>
    <p>Practice on interactive quizzes.</p>
    <p>Reinforce your knowledge.</p>'
);

