CREATE SCHEMA IF NOT EXISTS db_bxsim CHARACTER SET utf8;

USE db_bxsim;

CREATE TABLE IF NOT EXISTS tbl_practicesets (
    id INT UNSIGNED PRIMARY KEY AUTO_INCREMENT,
    PracticeName VARCHAR(100) NOT NULL UNIQUE,
    PracticeIntroPage TEXT
) ENGINE=INNODB;

CREATE TABLE IF NOT EXISTS tbl_scenarios (
    id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    ScenarioPage TEXT,
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
    QuizzesID INT NOT NULL REFERENCES tbl_quizzes(id)
        ON DELETE CASCADE,
    OptionID INT NOT NULL REFERENCES tbl_options(id)
        ON DELETE CASCADE,
    AnswerState TINYINT NOT NULL
) ENGINE=INNODB;

INSERT INTO tbl_practicesets (PracticeName, PracticeIntroPage) VALUES (
    'Technical Rehydration - C# CLR',
    '<p>Technical Rehydration series are designed to quickly pick-up knowledge points from past learning sessions.</p><p>For this particular practice set we focus on the CLR mechanisms in C#. Most knowledge points can be found in the book <i>CLR via C#</i>.</p>'
);

INSERT INTO tbl_scenarios (ScenarioPage, PracticeID) VALUES (
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
INSERT INTO rel_OptionQuiz (QuizzesID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, 0
);

INSERT INTO tbl_options (Content) VALUES (
    "Call the type's constructor function to initialize the instance"
);

SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizzesID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);

INSERT INTO tbl_options (Content) VALUES (
    "Build resources that this instance is trying to access"
);

SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizzesID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);

INSERT INTO tbl_options (Content) VALUES (
    "Validates the security requirements to prevent memory leakage"
);

SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizzesID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);

SELECT * FROM tbl_quizzes q 
    INNER JOIN rel_optionquiz l ON (
        q.id = l.QuizzesID) 
    INNER JOIN tbl_options o ON (
        o.id = l.OptionID) \G