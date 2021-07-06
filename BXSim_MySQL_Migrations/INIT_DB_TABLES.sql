CREATE SCHEMA IF NOT EXISTS BXSimDB CHARACTER SET utf8;
USE BXSimDB;
CREATE TABLE IF NOT EXISTS PracticeSets (
    id INT UNSIGNED NOT NULL,
    PracticeName VARCHAR(100) NOT NULL UNIQUE,
    PracticeIntroPage TEXT,
    PRIMARY KEY (id)
) ENGINE=INNODB;
CREATE TABLE IF NOT EXISTS Scenarios (
    id INT UNSIGNED NOT NULL,
    ScenarioPage TEXT,
    PracticeID INT,
    PRIMARY KEY (id),
    FOREIGN KEY (PracticeID)
        REFERENCES PracticeSets(id)
        ON DELETE CASCADE
) ENGINE=INNODB;
CREATE TABLE IF NOT EXISTS Quizzes (
    id INT UNSIGNED NOT NULL,
    Question VARCHAR(255),
    ScenarioID INT,
    PRIMARY KEY (id),
    FOREIGN KEY (ScenarioID)
        REFERENCES Scenarios(id)
        ON DELETE CASCADE
) ENGINE=INNODB;
CREATE TABLE IF NOT EXISTS rel_OptionQuiz (
    id INT UNSIGNED NOT NULL,
    QuizzesID INT REQUIRED,
    OptionID INT REQUIRED,
    AnswerState TINYINT REQUIRED,
    PRIMARY KEY (id),
    FOREIGN KEY (QuizzesID)
        REFERENCES Quizzes(id)
        ON DELETE CASCADE,
    FOREIGN KEY (OptionID)
        REFERENCES Options(id)
        ON DELETE CASCADE
) ENGINE=INNODB;
CREATE TABLE IF NOT EXISTS Options (
    id INT UNSIGNED NOT NULL,
    Content VARCHAR(255) REQUIRED,
    PRIMARY KEY (id)
) ENGINE=INNODB;

INSERT INTO PracticeSets (PracticeName, PracticeIntroPage) VALUES (
    'Technical Rehydration - C# CLR',
    '<p>Technical Rehydration series are designed to quickly pick-up knowledge points from past learning sessions.</p><p>For this particular practice set we focus on the CLR mechanisms in C#. Most knowledge points can be found in the book <i>CLR via C#</i>.</p>'
);

SET @max_id = (SELECT MAX(id) FROM PracticeSets);
INSERT INTO Scenarios (ScenarioPage, PracticeID) VALUES (
    '<p>In C#, we often use the new operator</p>',
    @max_id
);
\G