DROP DATABASE IF EXISTS GolfBooking;
CREATE DATABASE Golfbooking;

USE Golfbooking;


CREATE USER GolfBookingUser IDENTIFIED BY "GolfPassword";
GRANT SELECT, DELETE, INSERT, UPDATE, EXECUTE
ON Golfbooking.*
TO GolfBookingUser;

DROP TABLE IF EXISTS GolfUser;
CREATE TABLE GolfUser(
UserID INT PRIMARY KEY AUTO_INCREMENT,
Email VARCHAR(100) NOT NULL UNIQUE,
UserPassword VARCHAR(100) NOT NULL,
FirstName VARCHAR(45) NOT NULL,
LastName VARCHAR(45) NOT NULL,
GolfHandicap INT DEFAULT 54
);

INSERT INTO GolfUser VALUES (Default, "bengt@gmail.com", "benganboi", "Bengt", "Karlsson", DEFAULT);
INSERT INTO GolfUser VALUES (Default, "ulla@gmail.com", "lösen", "Ulla", "Andersson", DEFAULT);
INSERT INTO GolfUser VALUES (Default, "tiger@gmail.com", "woods", "Tiger", "Woods", DEFAULT);
INSERT INTO GolfUser VALUES (Default, "peter@gmail.com", "katt", "Peter", "Bengtsson", DEFAULT);
INSERT INTO GolfUser VALUES (Default, "calle@gmail.com", "123", "Carl-erik", "Jönsson", DEFAULT);
INSERT INTO GolfUser VALUES (Default, "olof@gmail.com", "hund", "Olof", "Larsson", DEFAULT);
INSERT INTO GolfUser VALUES (Default, "victoria@gmail.com", "handboll", "Victoria", "Larsson", DEFAULT);
INSERT INTO GolfUser VALUES (Default, "engla@gmail.com", "password", "Engla", "Strömberg", DEFAULT);



DROP TABLE IF EXISTS GolfClub;
CREATE TABLE GolfClub(
ClubID INT PRIMARY KEY AUTO_INCREMENT,
ClubName VARCHAR(100) NOT NULL,
Location VARCHAR (100) NOT NULL
);


DROP PROCEDURE IF EXISTS AddClub;
DELIMITER ¤¤
CREATE PROCEDURE AddClub(
	ClubName VARCHAR(100),
    Location VARCHAR (100)
)
BEGIN
	INSERT INTO GolfClub VALUES(DEFAULT, ClubName, Location);
END¤¤
DELIMITER ;



INSERT INTO GolfClub (ClubName, Location) VALUES ('Bosjökloster GK', 'Höör');
INSERT INTO GolfClub (ClubName, Location) VALUES ('Skyrups GolfKlubb', 'Skyrup');
INSERT INTO GolfClub (ClubName, Location) VALUES ('Ellinge GK', 'Eslöv');
INSERT INTO GolfClub (ClubName, Location) VALUES ('Åhus MasterClub', 'Åhus');
INSERT INTO GolfClub (ClubName, Location) VALUES ('Elisefarm', 'Hörby');
                               


DROP TABLE IF EXISTS GolfCourse;
CREATE TABLE GolfCourse (
    GolfCoursedID INT PRIMARY KEY AUTO_INCREMENT,
    GolfClubID Int,
    CourseName VARCHAR(255),
    Hole1Par INT,
    Hole2Par INT,
    Hole3Par INT,
    Hole4Par INT,
    Hole5Par INT,
    Hole6Par INT,
    Hole7Par INT,
    Hole8Par INT,
    Hole9Par INT,
    Hole10Par INT,
    Hole11Par INT,
    Hole12Par INT,
    Hole13Par INT,
    Hole14Par INT,
    Hole15Par INT,
    Hole16Par INT,
    Hole17Par INT,
    Hole18Par INT
);



INSERT INTO GolfCourse (GolfClubID, CourseName, Hole1Par, Hole2Par, Hole3Par, Hole4Par, Hole5Par, Hole6Par, Hole7Par, Hole8Par, Hole9Par, Hole10Par, Hole11Par, Hole12Par, Hole13Par, Hole14Par, Hole15Par, Hole16Par, Hole17Par, Hole18Par)
VALUES (1, 'Old Course', 5, 4, 3, 4, 5, 4, 4, 3, 4, 4, 5, 3, 4, 4, 3, 5, 4, 4);
INSERT INTO GolfCourse (GolfClubID, CourseName, Hole1Par, Hole2Par, Hole3Par, Hole4Par, Hole5Par, Hole6Par, Hole7Par, Hole8Par, Hole9Par, Hole10Par, Hole11Par, Hole12Par, Hole13Par, Hole14Par, Hole15Par, Hole16Par, Hole17Par, Hole18Par)
VALUES (1, 'New Course', 4, 3, 5, 5, 3, 4, 4, 3, 5, 3, 4, 4, 4, 5, 4, 4, 4, 4);
INSERT INTO GolfCourse (GolfClubID, CourseName, Hole1Par, Hole2Par, Hole3Par, Hole4Par, Hole5Par, Hole6Par, Hole7Par, Hole8Par, Hole9Par, Hole10Par, Hole11Par, Hole12Par, Hole13Par, Hole14Par, Hole15Par, Hole16Par, Hole17Par, Hole18Par)
VALUES (2, 'Master Course', 5, 3, 4, 4, 4, 3, 3, 5, 4, 4, 4, 5, 4, 4, 3, 5, 4, 4);
INSERT INTO GolfCourse (GolfClubID, CourseName, Hole1Par, Hole2Par, Hole3Par, Hole4Par, Hole5Par, Hole6Par, Hole7Par, Hole8Par, Hole9Par, Hole10Par, Hole11Par, Hole12Par, Hole13Par, Hole14Par, Hole15Par, Hole16Par, Hole17Par, Hole18Par)
VALUES (2, 'Champion Course', 4, 4, 3, 5, 5, 4, 4, 3, 4, 5, 4, 3, 4, 4, 4, 4, 5, 3);
INSERT INTO GolfCourse (GolfClubID, CourseName, Hole1Par, Hole2Par, Hole3Par, Hole4Par, Hole5Par, Hole6Par, Hole7Par, Hole8Par, Hole9Par, Hole10Par, Hole11Par, Hole12Par, Hole13Par, Hole14Par, Hole15Par, Hole16Par, Hole17Par, Hole18Par)
VALUES (3, 'Ellinge Banan', 3, 4, 3, 4, 4, 4, 5, 4, 3, 3, 4, 5, 4, 4, 4, 5, 4, 5);
INSERT INTO GolfCourse (GolfClubID, CourseName, Hole1Par, Hole2Par, Hole3Par, Hole4Par, Hole5Par, Hole6Par, Hole7Par, Hole8Par, Hole9Par, Hole10Par, Hole11Par, Hole12Par, Hole13Par, Hole14Par, Hole15Par, Hole16Par, Hole17Par, Hole18Par)
VALUES (3, 'Volvo Banan', 4, 5, 4, 5, 4, 3, 3, 4, 4, 4, 3, 4, 4, 5, 4, 4, 5, 3);
INSERT INTO GolfCourse (GolfClubID, CourseName, Hole1Par, Hole2Par, Hole3Par, Hole4Par, Hole5Par, Hole6Par, Hole7Par, Hole8Par, Hole9Par, Hole10Par, Hole11Par, Hole12Par, Hole13Par, Hole14Par, Hole15Par, Hole16Par, Hole17Par, Hole18Par)
VALUES (4, 'Beach Course', 3, 4, 5, 4, 3, 4, 3, 4, 5, 4, 4, 5, 4, 4, 4, 3, 4, 5);
INSERT INTO GolfCourse (GolfClubID, CourseName, Hole1Par, Hole2Par, Hole3Par, Hole4Par, Hole5Par, Hole6Par, Hole7Par, Hole8Par, Hole9Par, Hole10Par, Hole11Par, Hole12Par, Hole13Par, Hole14Par, Hole15Par, Hole16Par, Hole17Par, Hole18Par)
VALUES (4, 'Wood Course', 5, 4, 4, 3, 5, 4, 4, 4, 5, 3, 4, 4, 5, 4, 4, 3, 3, 4);
INSERT INTO GolfCourse (GolfClubID, CourseName, Hole1Par, Hole2Par, Hole3Par, Hole4Par, Hole5Par, Hole6Par, Hole7Par, Hole8Par, Hole9Par, Hole10Par, Hole11Par, Hole12Par, Hole13Par, Hole14Par, Hole15Par, Hole16Par, Hole17Par, Hole18Par)
VALUES (5, 'Tiger Course', 4, 4, 3, 4, 5, 3, 4, 4, 5, 5, 4, 3, 4, 4, 4, 5, 3, 4);
INSERT INTO GolfCourse (GolfClubID, CourseName, Hole1Par, Hole2Par, Hole3Par, Hole4Par, Hole5Par, Hole6Par, Hole7Par, Hole8Par, Hole9Par, Hole10Par, Hole11Par, Hole12Par, Hole13Par, Hole14Par, Hole15Par, Hole16Par, Hole17Par, Hole18Par)
VALUES (5, 'Old Course', 3, 4, 4, 3, 4, 3, 4, 5, 4, 5, 4, 3, 4, 5, 4, 5, 4, 4);
        
DROP PROCEDURE IF EXISTS AddGolfCourse;
DELIMITER $$
CREATE PROCEDURE AddGolfCourse(
	GolfClubID Int,
    CourseName VARCHAR(255),
    Hole1Par INT,
    Hole2Par INT,
    Hole3Par INT,
    Hole4Par INT,
    Hole5Par INT,
    Hole6Par INT,
    Hole7Par INT,
    Hole8Par INT,
    Hole9Par INT,
    Hole10Par INT,
    Hole11Par INT,
    Hole12Par INT,
    Hole13Par INT,
    Hole14Par INT,
    Hole15Par INT,
    Hole16Par INT,
    Hole17Par INT,
    Hole18Par INT
)
BEGIN
	INSERT INTO course VALUES(DEFAULT, GolfClubID, CourseName, Hole1Par, Hole2Par, Hole3Par, Hole4Par, Hole5Par, Hole6Par, Hole7Par, Hole8Par, Hole9Par, Hole10Par, Hole11Par, 
							  Hole12Par, Hole13Par, Hole14Par, Hole15Par, Hole16Par, Hole17Par, Hole18Par);
END$$
DELIMITER ;
        



DROP TABLE IF EXISTS UserRound;
CREATE TABLE UserRound (
	RoundID INT PRIMARY KEY AUTO_INCREMENT,
    GolfCourseID INT,
    GolfUserID INT,
    Hole1Strokes INT,
    Hole2Strokes INT,
    Hole3Strokes INT,
    Hole4Strokes INT,
    Hole5Strokes INT,
    Hole6Strokes INT,
    Hole7Strokes INT,
    Hole8Strokes INT,
    Hole9Strokes INT,
    Hole10Strokes INT,
    Hole11Strokes INT,
    Hole12Strokes INT,
    Hole13Strokes INT,
    Hole14Strokes INT,
    Hole15Strokes INT,
    Hole16Strokes INT,
    Hole17Strokes INT,
    Hole18Strokes INT
);





DROP PROCEDURE IF EXISTS CreateNewGolfUser;


DELIMITER ¤¤
CREATE PROCEDURE CreateNewGolfUser (
	Email VARCHAR(100),
    UserPassword VARCHAR(100),
    FirstName VARCHAR(45),
    LastName VARCHAR(45)
)
BEGIN
INSERT INTO GolfUser VALUES (DEFAULT, Email,
 UserPassword, FirstName, LastName, 54);
 SELECT MAX(UserID) AS "NewID" FROM GolfUser;
END ¤¤
DELIMITER ;

DROP PROCEDURE IF EXISTS CreateNewRound;
DELIMITER ¤¤
CREATE PROCEDURE CreateNewRound (
    GolfCourseID INT,
    GolfUserID INT,
    Hole1Strokes INT,
    Hole2Strokes INT,
    Hole3Strokes INT,
    Hole4Strokes INT,
    Hole5Strokes INT,
    Hole6Strokes INT,
    Hole7Strokes INT,
    Hole8Strokes INT,
    Hole9Strokes INT,
    Hole10Strokes INT,
    Hole11Strokes INT,
    Hole12Strokes INT,
    Hole13Strokes INT,
    Hole14Strokes INT,
    Hole15Strokes INT,
    Hole16Strokes INT,
    Hole17Strokes INT,
    Hole18Strokes INT
)
BEGIN
INSERT INTO UserRound VALUES (DEFAULT, GolfCourseID, GolfUserID, Hole1Strokes, Hole2Strokes, Hole3Strokes, Hole4Strokes, Hole5Strokes,
                            Hole6Strokes, Hole7Strokes, Hole8Strokes, Hole9Strokes,
                            Hole10Strokes, Hole11Strokes, Hole12Strokes, Hole13Strokes, Hole14Strokes,
                            Hole15Strokes, Hole16Strokes, Hole17Strokes, Hole18Strokes);
SELECT MAX(RoundID) AS "NewID" FROM UserRound;                            
END ¤¤
DELIMITER ;

CALL CreateNewRound(1, 1, 6, 5, 4, 5, 4, 3, 5, 6, 7, 7, 6, 5, 5, 6, 4, 6, 7, 5);
CALL CreateNewRound(10, 1, 5, 5, 6, 6, 4, 5, 7, 5, 4, 5, 5, 6, 7, 4, 6, 4, 4, 4);
CALL CreateNewRound(5, 1, 5, 4, 3, 5, 6, 5, 4, 6, 7, 3, 4, 6, 4, 3, 5, 2, 6, 3);
CALL CreateNewRound(4, 1, 6, 5, 4, 5, 4, 3, 5, 6, 5, 7, 6, 5, 5, 6, 4, 6, 7, 5);
CALL CreateNewRound(3, 2, 5, 4, 4, 4, 5, 3, 6, 5, 5, 4, 6, 7, 6, 6, 6, 5, 4, 3);
CALL CreateNewRound(8, 2, 5, 4, 4, 4, 5, 3, 4, 5, 5, 4, 6, 7, 6, 6, 6, 5, 4, 3);
CALL CreateNewRound(9, 2, 5, 4, 4, 4, 5, 3, 6, 5, 5, 7, 6, 7, 6, 6, 6, 5, 4, 3);
CALL CreateNewRound(2, 2, 5, 4, 4, 3, 5, 3, 6, 5, 5, 4, 6, 8, 6, 6, 5, 5, 4, 3);
CALL CreateNewRound(9, 3, 4, 4, 2, 3, 5, 3, 4, 5, 3, 4, 4, 3, 3, 4, 5, 5, 4, 3);
CALL CreateNewRound(4, 3, 4, 4, 2, 3, 5, 3, 4, 5, 3, 4, 4, 3, 3, 4, 5, 5, 4, 3);
CALL CreateNewRound(5, 3, 4, 4, 3, 3, 5, 3, 4, 4, 3, 4, 4, 3, 3, 4, 5, 5, 4, 3);
CALL CreateNewRound(9, 3, 4, 4, 2, 3, 5, 3, 4, 4, 3, 4, 4, 3, 3, 3, 5, 5, 4, 3);
CALL CreateNewRound(6, 4, 6, 5, 7, 5, 7, 8, 6, 6, 7, 6, 4, 7, 5, 5, 7, 6, 8, 5);
CALL CreateNewRound(7, 4, 6, 5, 7, 7, 7, 8, 6, 6, 7, 6, 6, 7, 5, 5, 7, 6, 8, 5);
CALL CreateNewRound(2, 4, 6, 5, 7, 5, 7, 7, 6, 6, 7, 6, 4, 7, 5, 5, 7, 6, 8, 5);
CALL CreateNewRound(3, 4, 3, 5, 7, 5, 7, 8, 6, 6, 5, 5, 4, 7, 5, 5, 7, 6, 8, 5);
CALL CreateNewRound(4, 5, 5, 5, 6, 5, 4, 7, 4, 4, 6, 8, 5, 5, 6, 8, 9, 4, 3, 4);
CALL CreateNewRound(7, 5, 5, 5, 6, 4, 4, 7, 4, 4, 6, 8, 5, 5, 6, 7, 7, 4, 3, 4);
CALL CreateNewRound(2, 5, 6, 5, 6, 5, 4, 5, 4, 4, 6, 8, 5, 5, 6, 8, 3, 4, 3, 4);
CALL CreateNewRound(1, 5, 5, 5, 7, 5, 4, 7, 4, 4, 6, 8, 5, 5, 6, 6, 8, 4, 3, 4);
CALL CreateNewRound(7, 6, 5, 6, 7, 5, 3, 6, 5, 8, 6, 7, 3, 4, 5, 8, 4, 6, 2, 6);
CALL CreateNewRound(9, 5, 5, 3, 5, 6, 5, 4, 5, 8, 6, 7, 8, 3, 4, 8, 4, 6, 3, 6);
CALL CreateNewRound(4, 6, 5, 6, 7, 5, 3, 3, 5, 8, 6, 7, 3, 4, 5, 8, 4, 6, 4, 6);
CALL CreateNewRound(6, 6, 5, 6, 5, 5, 3, 6, 5, 8, 6, 3, 3, 3, 5, 7, 4, 6, 6, 6);
CALL CreateNewRound(2, 7, 8, 7, 4, 6, 7, 6, 7, 8, 6, 5, 6, 8, 5, 6, 6, 5, 4, 6);
CALL CreateNewRound(7, 7, 8, 7, 4, 5, 4, 6, 7, 8, 6, 5, 6, 8, 5, 6, 7, 5, 4, 6);
CALL CreateNewRound(8, 7, 8, 7, 4, 6, 6, 6, 7, 8, 8, 5, 6, 8, 5, 6, 6, 5, 4, 6);
CALL CreateNewRound(6, 7, 8, 7, 4, 3, 7, 6, 7, 6, 6, 5, 6, 9, 5, 4, 9, 2, 4, 6);
CALL CreateNewRound(6, 8, 5, 4, 4, 5, 4, 3, 4, 5, 5, 6, 5, 7, 4, 5, 6, 6, 4, 3);
CALL CreateNewRound(6, 8, 4, 5, 4, 5, 5, 3, 6, 5, 5, 6, 5, 7, 7, 5, 6, 6, 4, 4);
CALL CreateNewRound(6, 8, 6, 3, 4, 5, 3, 3, 4, 5, 6, 6, 5, 7, 4, 5, 5, 6, 5, 3);
CALL CreateNewRound(6, 8, 5, 6, 4, 5, 6, 3, 6, 5, 5, 6, 5, 7, 4, 5, 6, 6, 4, 6);


DROP TABLE IF EXISTS UsersInClubs;
CREATE TABLE UsersInClubs(
	UserID INT,
    ClubID INT,
    PRIMARY KEY(UserID, ClubID)
);

SELECT * FROM UsersInClubs;

DROP PROCEDURE IF EXISTS UserJoinClub;
DELIMITER ¤¤
CREATE PROCEDURE UserJoinClub(
	UserID INT,
    ClubID INT
)
BEGIN
	INSERT INTO UsersInClubs VALUES (UserID, ClubID);
END¤¤
DELIMITER ;

CALL UserJoinClub(1, 1);
CALL UserJoinClub(1, 5);
CALL UserJoinClub(2, 4);
CALL UserJoinClub(2, 2);
CALL UserJoinClub(3, 4);
CALL UserJoinClub(3, 5);
CALL UserJoinClub(4, 1);
CALL UserJoinClub(4, 3);
CALL UserJoinClub(5, 4);
CALL UserJoinClub(5, 2);
CALL UserJoinClub(6, 3);
CALL UserJoinClub(6, 1);
CALL UserJoinClub(7, 3);
CALL UserJoinClub(7, 2);
CALL UserJoinClub(8, 3);
CALL UserJoinClub(8, 5);

DROP PROCEDURE IF EXISTS SearchGolfClub;
DELIMITER ¤¤
CREATE PROCEDURE SearchGolfClub(
	SearchClub VARCHAR(450)
)
BEGIN
	DECLARE searchTerm VARCHAR(500);
    SET searchTerm = CONCAT("%", SearchClub, "%");
    SELECT * FROM GolfClub
    WHERE ClubName LIKE searchTerm;
END¤¤
DELIMITER ;



DROP PROCEDURE IF EXISTS RemoveRound;

DELIMITER ¤¤
CREATE PROCEDURE RemoveRound(RoundIdToRemove INT)
BEGIN
    DELETE FROM UserRound
    WHERE RoundID = RoundIdToRemove;

    SELECT "Successful" AS "result";
END¤¤
DELIMITER ;

CREATE OR REPLACE VIEW HandicapsUnder30 AS
SELECT g.UserID, g.FirstName, g.LastName, g.GolfHandicap FROM GolfUser g
WHERE g.GolfHandicap < 30;

SELECT * FROM HandicapsUnder30;

-- DROP INDEX UserHandicapIndex ON GolfUser;
CREATE INDEX UserHandicapIndex ON GolfUser(GolfHandicap);
