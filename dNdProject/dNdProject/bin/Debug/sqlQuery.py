import sqlite3
con = sqlite3.connect("DND.db")
cur = con.cursor()

cur.execute("insert into spells (spellName,spellAttackType) VALUES ('waterball','water')")

res = cur.execute("SELECT * from spells")
print(res.fetchall())