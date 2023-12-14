import sqlite3

conn = sqlite3.connect("DND.db")
cur = conn.cursor()

cur.execute("""CREATE TABLE skills (
    characterID INTEGER ,
    Survival INTEGER DEFAULT 0,
    Stealth INTEGER DEFAULT 0,
    Sleight INTEGER DEFAULT 0,
    Religion INTEGER DEFAULT 0,
    Persuasion INTEGER DEFAULT 0,
    Performance INTEGER DEFAULT 0,
    Perception INTEGER DEFAULT 0,
    Nature INTEGER DEFAULT 0,
    Medicine INTEGER DEFAULT 0,
    Investigation INTEGER DEFAULT 0,
    Intimidation INTEGER DEFAULT 0,
    History INTEGER DEFAULT 0,
    Deception INTEGER DEFAULT 0,
    Athletics INTEGER DEFAULT 0,
    Arcana INTEGER DEFAULT 0,
    Animal INTEGER DEFAULT 0,
    Acrobatics INTEGER DEFAULT 0
);""")

conn.commit()
conn.close()

