import sqlite3

conn = sqlite3.connect("DND.db")
cur = conn.cursor()

cur.execute("""CREATE TABLE CharacterInfo (
    characterID INT,
    Proficiency INT,
    CharacterName TEXT,
    Background TEXT,
    Alignment TEXT,
    Initiative INT,
    ArmorClass INT,
    CurrentHp INT,
    HpMax INT,
    Level INT
);""")

conn.commit()
conn.close()
