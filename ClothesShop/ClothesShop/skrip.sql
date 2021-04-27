CREATE TABLE Users (
	username TEXT NOT NULL,
	full_name TEXT NOT NULL,
	address TEXT NOT NULL,
	phone TEXT NOT NULL,
	passwd TEXT NOT NULL,
	gender TEXT NOT NULL,
	email TEXT NOT NULL,
	birthday TEXT NOT NULL,
	PRIMARY KEY (username)
);

CREATE TABLE Admin (
	adminID INTEGER NOT NULL,
	name TEXT NOT NULL,
	passwd TEXT NOT NULL,
	PRIMARY KEY (adminID)
);

CREATE TABLE Cart (
	cartID INTEGER NOT NULL,
	username TEXT NOT NULL,
	PRIMARY KEY (cartID),
	FOREIGN KEY (username) REFERENCES Users (username)
);

CREATE TABLE Cloth (
	image BLOB,
	productID INTEGER NOT NULL,
	name TEXT NOT NULL,
	price INTEGER NOT NULL,
	size TEXT NOT NULL,
	quantity INTEGER NOT NULL,
	adminID INTEGER NOT NULL,
	PRIMARY KEY (productID),
	FOREIGN KEY (adminID) REFERENCES Admin (adminID)
);

CREATE TABLE Orders (
	orderID INTEGER NOT NULL,
	name TEXT NOT NULL,
	price INTEGER NOT NULL,
	quantity INTEGER NOT NULL,
	username TEXT NOT NULL,
	productID INTEGER NOT NULL,
	cartID INTEGER NOT NULL,
	PRIMARY KEY (orderID),
	FOREIGN KEY (username) REFERENCES Users (username),
	FOREIGN KEY (productID) REFERENCES Cloth (productID),
	FOREIGN KEY (cartID) REFERENCES Cart (cartID)
);

CREATE TABLE Wishlist (
	username TEXT NOT NULL,
	productID INTEGER NOT NULL,	
	FOREIGN KEY (username) REFERENCES Users (username),
	FOREIGN KEY (productID) REFERENCES Cloth (productID)
);