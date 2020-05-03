SET FOREIGN_KEY_CHECKS=0; -- Disabling so if a table is needed to be deleted, it can

DROP TABLE IF EXISTS Users;

CREATE TABLE Users(
	userID INTEGER,
    firstName VARCHAR(25) NOT NULL,
    lastName VARCHAR(25) NOT NULL,
    gender BIT(2) NOT NULL, -- 00 Male, 01 Female, 10 Unspecified
	homeTown VARCHAR(25) NOT NULL, -- Longest in dataset is 22
    currentCity VARCHAR(25), -- Longest in dataset is 22
    relationshipStatus BIT(2) NOT NULL, -- 00 Single, 01 Engaged, 10 Married, 11 Complicated
    PRIMARY KEY (userID)
);

DROP TABLE IF EXISTS Workplaces;

CREATE TABLE Workplaces(
	workplaceID INTEGER AUTO_INCREMENT,
    workplaceName VARCHAR(25) NOT NULL, -- Longest in dataset is 21
    PRIMARY KEY (workplaceID)
);

DROP TABLE IF EXISTS Workers;

CREATE TABLE Workers(
	userID INTEGER NOT NULL,
    workplaceID INTEGER,
	dateStarted DATE NOT NULL,
    dateLeft DATE,
    PRIMARY KEY (userID, workplaceID),
    FOREIGN KEY (workplaceID) REFERENCES Workplaces(workplaceID),
    FOREIGN KEY (userID) REFERENCES Users(userID)
);

DROP TABLE IF EXISTS Universities;

CREATE TABLE Universities(
	uniID INTEGER AUTO_INCREMENT,
    universityName VARCHAR(55) NOT NULL, -- Longest in dataset is 52
    PRIMARY KEY(uniID)
);

DROP TABLE IF EXISTS Students;

CREATE TABLE Students(
	userID INTEGER NOT NULL,
    uniID INTEGER NOT NULL,
	dateStarted DATE NOT NULL,
    dateLeft DATE,
    PRIMARY KEY (userID, uniID),
    FOREIGN KEY (uniID) REFERENCES Universities(uniID),
    FOREIGN KEY (userID) REFERENCES Users(userID)
);

DROP TABLE IF EXISTS Friendships;

CREATE TABLE Friendships(
		userID_1 INTEGER NOT NULL,
    userID_2 INTEGER NOT NULL,
		isAccepted BOOLEAN NOT NULL,
    PRIMARY KEY (userID_1, userID_2),
    FOREIGN KEY (userID_1) REFERENCES Users(userID),
    FOREIGN KEY (userID_2) REFERENCES Users(userID)
);

DROP TABLE IF EXISTS Messages;

CREATE TABLE Messages(
	senderID INTEGER NOT NULL,
    recipientID INTEGER NOT NULL,
    sentTime DATETIME NOT NULL,
    messageText VARCHAR(255),
		isRead BOOLEAN NOT NULL,
    PRIMARY KEY (recipientID, sentTime),
    FOREIGN KEY (senderID) REFERENCES Users(userID),
    FOREIGN KEY (recipientID) REFERENCES Users(userID)
);

SET FOREIGN_KEY_CHECKS=1; -- Re-enable them
