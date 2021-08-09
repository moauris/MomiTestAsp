USE db_bxsim;
--INSERT INTO tbl_practicesets (Code, Title, IntroPage) VALUES (
--    'DyCRM001',
--    'Dynamics 365 - Set I',
--    '<p>Fundamental Level Learning Material for Microsoft Dynamics 365</p>'
--);

INSERT INTO tbl_scenarios (PageText, PracticeID) VALUES (
    '<p>The Microsoft Dynamics CRM offers two categpries</p>
    <ul><li>CRM Online</li><li>CRM On-Premise</li></ul>
    <p>They offer similar functionalities, but there are still differences.</p>',
    2
);

INSERT INTO tbl_quizzes (Question, ScenarioID) VALUES (
    "Which two of these below are not advantages of a CRM On-Premise offering?",
    @scen_id:=(SELECT MAX(id) FROM tbl_scenarios)
);
SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);
INSERT INTO tbl_options (Content) VALUES (
    'Supports relatively more customization and extensions'
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);

SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);
INSERT INTO tbl_options (Content) VALUES (
    'Has no limits on storage size'
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);

SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);
INSERT INTO tbl_options (Content) VALUES (
    'Supports automatic updates to future version'
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, 0
);
SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);
INSERT INTO tbl_options (Content) VALUES (
    'Microsoft performs daily backup on your databases'
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, 0
);
SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);
INSERT INTO tbl_options (Content) VALUES (
    'Complete control over databases and infrastructures'
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);

INSERT INTO tbl_quizzes (Question, ScenarioID) VALUES (
    "Which two of these below are not advantages of a CRM Online offering?",
    @scen_id:=(SELECT MAX(id) FROM tbl_scenarios)
);
SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);
INSERT INTO tbl_options (Content) VALUES (
    'The servers and databases are managed by Microsoft'
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);
SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);
INSERT INTO tbl_options (Content) VALUES (
    'Can be setup and running quicker'
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);
SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);
INSERT INTO tbl_options (Content) VALUES (
    'Fees are charged depending on number of users and space on-the-go'
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);
SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);
INSERT INTO tbl_options (Content) VALUES (
    'Has no limitations on database'
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, 0
);
SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);
INSERT INTO tbl_options (Content) VALUES (
    'Can choose which updates to install by the administrators'
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, 0
);

INSERT INTO tbl_scenarios (PageText, PracticeID) VALUES (
    '<p>There are several ways to access the CRM</p>',
    2
);

INSERT INTO tbl_quizzes (Question, ScenarioID) VALUES (
    "Which two of these below are not advantages of a CRM On-Premise offering?",
    @scen_id:=(SELECT MAX(id) FROM tbl_scenarios)
);
SET @quiz_id:=(SELECT MAX(id) FROM tbl_quizzes);
INSERT INTO tbl_options (Content) VALUES (
    'Supports relatively more customization and extensions'
);
SET @opts_id:=(SELECT MAX(id) FROM tbl_options);
INSERT INTO rel_OptionQuiz (QuizID, OptionID, AnswerState) VALUES (
    @quiz_id, @opts_id, -1
);