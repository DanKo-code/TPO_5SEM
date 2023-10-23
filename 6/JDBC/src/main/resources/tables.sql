CREATE TABLE Players (
    player_id NUMBER PRIMARY KEY,
    name VARCHAR(255)
);

CREATE TABLE Weapons (
    weapon_id NUMBER PRIMARY KEY,
    type VARCHAR(255),
    price NUMBER,
    player_id NUMBER,
    FOREIGN KEY (player_id) REFERENCES Players(player_id)
);
-- Вставка данных в таблицу Manufacturers
INSERT INTO Players (player_id, name)
VALUES (1, 'Manufacturer1');

INSERT INTO Players (player_id, name)
VALUES (2, 'Manufacturer2');

-- Вставка данных в таблицу Watches
INSERT INTO Weapons (weapon_id, type, price, player_id)
VALUES (1,'pistol', 10.00, 1);
INSERT INTO Weapons (weapon_id, type, price, player_id)
VALUES (3, 'muchinegun', 100.00, 1);

INSERT INTO Weapons (weapon_id, type, price, player_id)
VALUES (2,'knife', 2.00, 2);
INSERT INTO Weapons (weapon_id, type, price, player_id)
VALUES (4, 'muchinegun', 100.00, 2);
commit;
