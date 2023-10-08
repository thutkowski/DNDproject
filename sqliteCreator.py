import sqlite3

cur = sqlite3.connect("/Users/Tim/Documents/DNDproject/dNdProject/dNdProject/bin/Debug/DND.db")

cur.execute("CREATE TABLE tbl1 (id, name, age )")
cur.execute("""INSERT INTO tbl1 (id, name, age ) VALUES (1,"Tim",20)""")
cur.execute("""INSERT INTO tbl1 (id, name, age ) VALUES (2,"Marcos",20)""")
cur.execute("""INSERT INTO tbl1 (id, name, age ) VALUES (3,"Zach",20)""")
cur.commit()
cur.close()
