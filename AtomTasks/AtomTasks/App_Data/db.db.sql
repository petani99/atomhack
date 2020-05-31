BEGIN TRANSACTION;
DROP TABLE IF EXISTS "Users";
CREATE TABLE IF NOT EXISTS "Users" (
	"UserId"	INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Login"	TEXT,
	"Password"	TEXT,
	"Name"	TEXT,
	"UserCategory"	INTEGER,
	"CellPhone"	TEXT,
	FOREIGN KEY("UserCategory") REFERENCES "UserCategories"("UserCategoryId")
);
DROP TABLE IF EXISTS "UserTaskAllows";
CREATE TABLE IF NOT EXISTS "UserTaskAllows" (
	"UserTaskAllowId"	INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
	"UserCategory"	INTEGER NOT NULL,
	"TaskCategory"	INTEGER NOT NULL,
	FOREIGN KEY("UserCategory") REFERENCES "UserCategories"("UserCategoryId"),
	FOREIGN KEY("TaskCategory") REFERENCES "TaskCategories"("TaskCategoryId")
);
DROP TABLE IF EXISTS "Statuses";
CREATE TABLE IF NOT EXISTS "Statuses" (
	"StatusId"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"ClassName"	TEXT CHECK(ClassName IN ('REQUEST','TASK')),
	"Code"	TEXT,
	"Name"	TEXT
);
DROP TABLE IF EXISTS "UserMarks";
CREATE TABLE IF NOT EXISTS "UserMarks" (
	"UserMarkId"	INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Mark"	INTEGER,
	"Text"	TEXT,
	FOREIGN KEY("Mark") REFERENCES "Marks"("MarkId")
);
DROP TABLE IF EXISTS "Requests";
CREATE TABLE IF NOT EXISTS "Requests" (
	"RequestId"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Executor"	INTEGER NOT NULL,
	"Task"	INTEGER NOT NULL,
	"Price"	INTEGER,
	"Timestamp"	INTEGER,
	"RequestStatus"	INTEGER,
	"UserMark"	INTEGER,
	FOREIGN KEY("Executor") REFERENCES "Users"("UserId"),
	FOREIGN KEY("Task") REFERENCES "Tasks"("TaskId"),
	FOREIGN KEY("RequestStatus") REFERENCES "Statuses"("StatusModelId"),
	FOREIGN KEY("UserMark") REFERENCES "UserMarks"("UserMarkId")
);
DROP TABLE IF EXISTS "Messages";
CREATE TABLE IF NOT EXISTS "Messages" (
	"MessageId"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	"User"	INTEGER NOT NULL,
	"Text"	TEXT,
	"Task"	INTEGER NOT NULL,
	FOREIGN KEY("User") REFERENCES "Users"("UserId"),
	FOREIGN KEY("Task") REFERENCES "Tasks"("TaskId")
);
DROP TABLE IF EXISTS "Marks";
CREATE TABLE IF NOT EXISTS "Marks" (
	"MarkId"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Name"	TEXT NOT NULL UNIQUE,
	"Description"	TEXT
);
DROP TABLE IF EXISTS "Tasks";
CREATE TABLE IF NOT EXISTS "Tasks" (
	"TaskId"	INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Customer"	INTEGER,
	"TaskCategory"	INTEGER,
	"Name"	TEXT,
	"Description"	TEXT,
	"Start_price"	INTEGER,
	"Date"	BLOB,
	"Location_X"	INTEGER,
	"Location_Y"	INTEGER,
	"TaskStatus"	INTEGER,
	"UserMark"	INTEGER,
	FOREIGN KEY("UserMark") REFERENCES "UserMarks"("UserMarkId"),
	FOREIGN KEY("Customer") REFERENCES "Users"("UserId"),
	FOREIGN KEY("TaskCategory") REFERENCES "TaskCategories"("TaskCategoryId"),
	FOREIGN KEY("TaskStatus") REFERENCES "Statuses"("StatusModelId")
);
DROP TABLE IF EXISTS "TaskCategories";
CREATE TABLE IF NOT EXISTS "TaskCategories" (
	"TaskCategoryId"	INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Code"	TEXT UNIQUE,
	"Name"	TEXT,
	"Description"	TEXT
);
DROP TABLE IF EXISTS "UserCategories";
CREATE TABLE IF NOT EXISTS "UserCategories" (
	"UserCategoryId"	INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Code"	TEXT UNIQUE,
	"Name"	TEXT
);
INSERT INTO "Users" ("UserId","Login","Password","Name","UserCategory","CellPhone") VALUES (1,'test_customer_ooo','123','Заказчик ООО',2,4537353);
INSERT INTO "Users" ("UserId","Login","Password","Name","UserCategory","CellPhone") VALUES (2,'test_executor_child','123','Исполнитель ребенок',5,6435778232);
INSERT INTO "Users" ("UserId","Login","Password","Name","UserCategory","CellPhone") VALUES (3,'test_customer_fl','123','ФЛ',4,245674556233);
INSERT INTO "Users" ("UserId","Login","Password","Name","UserCategory","CellPhone") VALUES (4,'test_executor_fl','123','ФЛ 2',4,3456234562);
INSERT INTO "UserTaskAllows" ("UserTaskAllowId","UserCategory","TaskCategory") VALUES (1,1,1);
INSERT INTO "UserTaskAllows" ("UserTaskAllowId","UserCategory","TaskCategory") VALUES (2,1,2);
INSERT INTO "UserTaskAllows" ("UserTaskAllowId","UserCategory","TaskCategory") VALUES (3,1,3);
INSERT INTO "UserTaskAllows" ("UserTaskAllowId","UserCategory","TaskCategory") VALUES (4,2,1);
INSERT INTO "UserTaskAllows" ("UserTaskAllowId","UserCategory","TaskCategory") VALUES (5,2,2);
INSERT INTO "UserTaskAllows" ("UserTaskAllowId","UserCategory","TaskCategory") VALUES (6,2,3);
INSERT INTO "UserTaskAllows" ("UserTaskAllowId","UserCategory","TaskCategory") VALUES (7,3,1);
INSERT INTO "UserTaskAllows" ("UserTaskAllowId","UserCategory","TaskCategory") VALUES (8,3,2);
INSERT INTO "UserTaskAllows" ("UserTaskAllowId","UserCategory","TaskCategory") VALUES (9,4,1);
INSERT INTO "UserTaskAllows" ("UserTaskAllowId","UserCategory","TaskCategory") VALUES (10,4,2);
INSERT INTO "UserTaskAllows" ("UserTaskAllowId","UserCategory","TaskCategory") VALUES (11,5,2);
INSERT INTO "Statuses" ("StatusId","ClassName","Code","Name") VALUES (1,'REQUEST','SENT','Предложение сделано Заказчику');
INSERT INTO "Statuses" ("StatusId","ClassName","Code","Name") VALUES (2,'REQUEST','REJECTED','Предложение отклонено Заказчиком');
INSERT INTO "Statuses" ("StatusId","ClassName","Code","Name") VALUES (3,'REQUEST','ACCEPTED','Предложение принято Заказчиком');
INSERT INTO "Statuses" ("StatusId","ClassName","Code","Name") VALUES (4,'TASK','PLACED','Задача размещена');
INSERT INTO "Statuses" ("StatusId","ClassName","Code","Name") VALUES (5,'TASK','INPROGRESS','Задача выполняется');
INSERT INTO "Statuses" ("StatusId","ClassName","Code","Name") VALUES (6,'TASK','DONE','Задача выполнена');
INSERT INTO "Marks" ("MarkId","Name","Description") VALUES (1,'5','Отлично');
INSERT INTO "Marks" ("MarkId","Name","Description") VALUES (2,'4','Хорошо');
INSERT INTO "Marks" ("MarkId","Name","Description") VALUES (3,'3','Удовлетворительно');
INSERT INTO "Marks" ("MarkId","Name","Description") VALUES (4,'2','Не удовлетворительно');
INSERT INTO "Marks" ("MarkId","Name","Description") VALUES (5,'1','Выгнать из системы ');
INSERT INTO "TaskCategories" ("TaskCategoryId","Code","Name","Description") VALUES (1,'SIMPLE _HARD_WORK','Простая тяжелая работа',NULL);
INSERT INTO "TaskCategories" ("TaskCategoryId","Code","Name","Description") VALUES (2,'SIMPLE_EASY_WORK','Простая легкая работа',NULL);
INSERT INTO "TaskCategories" ("TaskCategoryId","Code","Name","Description") VALUES (3,'COMPLEX_WORK','Сложная работа',NULL);
INSERT INTO "UserCategories" ("UserCategoryId","Code","Name") VALUES (1,'ИП','Может все по договору, отвечает своим имуществом');
INSERT INTO "UserCategories" ("UserCategoryId","Code","Name") VALUES (2,'ООО','Может все по договору, отвечает уставным капиталом');
INSERT INTO "UserCategories" ("UserCategoryId","Code","Name") VALUES (3,'Самозанятый','Может все, но неизвестна ответственность');
INSERT INTO "UserCategories" ("UserCategoryId","Code","Name") VALUES (4,'Физлицо','Может все по договору подряда, если не пропадет');
INSERT INTO "UserCategories" ("UserCategoryId","Code","Name") VALUES (5,'Ребенок','Сделает дешево, но все заинтересованные службы города будут следить за процессом');
INSERT INTO "UserCategories" ("UserCategoryId","Code","Name") VALUES (6,'Муниципалитет','Как правило, Заказчик');
COMMIT;
