﻿CREATE TABLE Goalies (
	ID INTEGER PRIMARY KEY NOT NULL,
	S INTEGER,
	B INTEGER,
	T INTEGER,
	FOREIGN KEY (S)
		REFERENCES Player (ID)
			ON DELETE CASCADE
			ON UPDATE NO ACTION,
	FOREIGN KEY (B)
		REFERENCES Player (ID)
			ON DELETE CASCADE
			ON UPDATE NO ACTION,
	FOREIGN KEY (T)
		REFERENCES Player (ID)
			ON DELETE CASCADE
			ON UPDATE NO ACTION
);