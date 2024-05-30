//Drop Tables
DROP TABLE Tickets;
DROP TABLE Departures;
DROP TABLE Vehicle_Types;
DROP TABLE Ports;

//Create Tables

CREATE TABLE Ports (
    P_Code char(1),
    P_Name varchar2(15) NOT NULL,
    CONSTRAINT pk_Ports PRIMARY KEY (P_Code)
);


CREATE TABLE Vehicle_Types (
    V_Code char(2),
    V_Description varchar2(25),
    Price numeric(4,2) NOT NULL CHECK (Price >= 0),
    V_Status char(1)  DEFAULT 'A' CHECK (V_Status IN ('A', 'U')),
    CONSTRAINT pk_Vehicle_Types PRIMARY KEY (V_Code)
);

CREATE TABLE Departures (
    Dep_ID numeric(9),
    Dep_Time char(5),
    Arr_Time char(5),
    Dep_Port char(1),
    Dep_Status char(1) DEFAULT 'A' CHECK (Dep_Status IN ('A', 'I')),
    CONSTRAINT pk_Departures PRIMARY KEY (Dep_ID),
    CONSTRAINT fk_Departures_Ports FOREIGN KEY (Dep_Port) REFERENCES Ports(P_Code)
);



CREATE TABLE Tickets (
    T_Code numeric(9),
    T_Date date NOT NULL,
    T_Time char(5) NOT NULL,
    V_Code char(2) NOT NULL,
    Sale_Price numeric(4,2) NOT NULL CHECK (Sale_Price >= 0),
    Dep_ID numeric(9) NOT NULL,
    CONSTRAINT pk_Tickets PRIMARY KEY (T_Code),
    CONSTRAINT fk_Tickets_Vehicle_Types FOREIGN KEY (V_Code) REFERENCES Vehicle_Types(V_Code),
    CONSTRAINT fk_Tickets_Departures FOREIGN KEY (Dep_ID) REFERENCES Departures(Dep_ID)
);

/*Data for reference file Ports*/
INSERT INTO Ports
VALUES('M', 'Mainland');

INSERT INTO Ports
VALUES('I', 'Island');

/*Data for Departures file -- for testing */
INSERT INTO Departures
VALUES(1, '09:00', '09:30', 'M', 'A');
INSERT INTO Departures
VALUES(2, '09:40', '10:10', 'I', 'A');
INSERT INTO Departures
VALUES(3, '10:20', '10:50', 'M', 'A');
INSERT INTO Departures
VALUES(4, '11:00', '11:30', 'I', 'A');
INSERT INTO Departures
VALUES(5, '11:40', '12:10', 'M', 'A');
INSERT INTO Departures
VALUES(6, '12:20', '12:50', 'I', 'A');
INSERT INTO Departures
VALUES(7, '13:00', '13:30', 'M', 'A');
INSERT INTO Departures
VALUES(8, '13:40', '14:10', 'I', 'A');
INSERT INTO Departures
VALUES(9, '14:20', '14:50', 'M', 'A');
INSERT INTO Departures
VALUES(10, '15:00', '15:30', 'I', 'A');
INSERT INTO Departures
VALUES(11, '15:40', '16:10', 'M', 'A');
INSERT INTO Departures
VALUES(12, '16:20', '16:50', 'I', 'A');
INSERT INTO Departures
VALUES(13, '17:00', '17:30', 'M', 'A');
INSERT INTO Departures
VALUES(14, '17:40', '18:10', 'I', 'A');

/*Data for Vehicle Types file - for testing Sell Ticket*/
INSERT INTO vehicle_types
VALUES('CR', 'Car (Hatchback)', 25.50, 'A');
INSERT INTO vehicle_types
VALUES('VN', 'Van (Transit)', 30.75, 'A');

/*Data for Tickets file for checking chart functionality*/
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (1,to_date('05-APR-24','DD-MON-RR'),'09:19','CR',25.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (2,to_date('05-APR-24','DD-MON-RR'),'09:24','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (0,to_date('05-APR-24','DD-MON-RR'),'09:24','CR',25.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (3,to_date('05-APR-24','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (4,to_date('05-APR-24','DD-MON-RR'),'09:27','CR',25.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (5,to_date('05-APR-24','DD-MON-RR'),'09:27','CR',25.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (6,to_date('05-APR-24','DD-MON-RR'),'09:28','CR',25.5,3);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (7,to_date('05-APR-24','DD-MON-RR'),'09:19','CR',25.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (8,to_date('05-APR-24','DD-MON-RR'),'09:24','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (9,to_date('05-APR-24','DD-MON-RR'),'09:24','CR',25.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (10,to_date('05-APR-24','DD-MON-RR'),'09:27','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (11,to_date('05-APR-24','DD-MON-RR'),'09:27','CR',25.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (12,to_date('05-APR-24','DD-MON-RR'),'09:27','CR',25.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (13,to_date('05-APR-24','DD-MON-RR'),'09:28','CR',25.5,4);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (14,to_date('05-MAY-24','DD-MON-RR'),'09:19','CR',25.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (15,to_date('05-MAY-24','DD-MON-RR'),'09:24','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (16,to_date('05-MAY-24','DD-MON-RR'),'09:24','CR',25.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (17,to_date('05-MAY-24','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (18,to_date('05-MAY-24','DD-MON-RR'),'09:27','CR',25.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (19,to_date('05-MAY-24','DD-MON-RR'),'09:27','CR',25.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (20,to_date('05-MAY-24','DD-MON-RR'),'09:28','CR',25.5,3);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (21,to_date('05-APR-23','DD-MON-RR'),'09:19','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (22,to_date('05-APR-23','DD-MON-RR'),'09:23','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (23,to_date('05-APR-23','DD-MON-RR'),'09:23','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (24,to_date('05-APR-23','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (25,to_date('05-APR-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (26,to_date('05-APR-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (27,to_date('05-APR-23','DD-MON-RR'),'09:28','CR',23.5,3);


Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (28,to_date('05-APR-23','DD-MON-RR'),'09:23','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (29,to_date('05-APR-23','DD-MON-RR'),'09:23','CR',23.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (30,to_date('05-APR-23','DD-MON-RR'),'09:27','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (31,to_date('05-APR-23','DD-MON-RR'),'09:27','CR',23.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (32,to_date('05-APR-23','DD-MON-RR'),'09:27','CR',23.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (33,to_date('05-APR-23','DD-MON-RR'),'09:28','CR',23.5,4);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (34,to_date('05-MAY-23','DD-MON-RR'),'09:19','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (35,to_date('05-MAY-23','DD-MON-RR'),'09:23','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (36,to_date('05-MAY-23','DD-MON-RR'),'09:23','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (37,to_date('05-MAY-23','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (38,to_date('05-MAY-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (39,to_date('05-MAY-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (40,to_date('05-MAY-23','DD-MON-RR'),'09:28','CR',23.5,3);        

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (41,to_date('05-JAN-23','DD-MON-RR'),'09:19','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (42,to_date('05-JAN-23','DD-MON-RR'),'09:23','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (43,to_date('05-JAN-23','DD-MON-RR'),'09:23','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (44,to_date('05-JAN-23','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (45,to_date('05-JAN-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (46,to_date('05-JAN-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (47,to_date('05-JAN-23','DD-MON-RR'),'09:28','CR',23.5,3);


Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (48,to_date('05-FEB-23','DD-MON-RR'),'09:23','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (49,to_date('05-FEB-23','DD-MON-RR'),'09:23','CR',23.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (50,to_date('05-FEB-23','DD-MON-RR'),'09:27','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (51,to_date('05-FEB-23','DD-MON-RR'),'09:27','CR',23.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (52,to_date('05-FEB-23','DD-MON-RR'),'09:27','CR',23.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (53,to_date('05-FEB-23','DD-MON-RR'),'09:28','CR',23.5,4);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (54,to_date('05-MAR-23','DD-MON-RR'),'09:19','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (55,to_date('05-MAR-23','DD-MON-RR'),'09:23','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (56,to_date('05-MAR-23','DD-MON-RR'),'09:23','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (57,to_date('05-MAR-23','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (58,to_date('05-MAR-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (59,to_date('05-MAR-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (60,to_date('05-MAR-23','DD-MON-RR'),'09:28','CR',23.5,3);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (61,to_date('05-JUN-23','DD-MON-RR'),'09:19','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (62,to_date('05-JUN-23','DD-MON-RR'),'09:23','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (63,to_date('05-JUN-23','DD-MON-RR'),'09:23','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (64,to_date('05-JUN-23','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (65,to_date('05-JUN-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (66,to_date('05-JUN-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (67,to_date('05-JUN-23','DD-MON-RR'),'09:28','CR',23.5,3);


Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (68,to_date('05-JUL-23','DD-MON-RR'),'09:23','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (69,to_date('05-JUL-23','DD-MON-RR'),'09:23','CR',23.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (70,to_date('05-JUL-23','DD-MON-RR'),'09:27','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (71,to_date('05-JUL-23','DD-MON-RR'),'09:27','CR',23.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (72,to_date('05-JUL-23','DD-MON-RR'),'09:27','CR',23.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (73,to_date('05-JUL-23','DD-MON-RR'),'09:28','CR',23.5,4);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (74,to_date('05-AUG-23','DD-MON-RR'),'09:19','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (75,to_date('05-AUG-23','DD-MON-RR'),'09:23','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (76,to_date('05-AUG-23','DD-MON-RR'),'09:23','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (77,to_date('05-AUG-23','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (78,to_date('05-AUG-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (79,to_date('05-AUG-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (80,to_date('05-AUG-23','DD-MON-RR'),'09:28','CR',23.5,3);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (81,to_date('05-SEP-23','DD-MON-RR'),'09:19','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (82,to_date('05-SEP-23','DD-MON-RR'),'09:23','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (83,to_date('05-SEP-23','DD-MON-RR'),'09:23','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (84,to_date('05-SEP-23','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (85,to_date('05-SEP-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (86,to_date('05-SEP-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (87,to_date('05-SEP-23','DD-MON-RR'),'09:28','CR',23.5,3);


Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (88,to_date('05-OCT-23','DD-MON-RR'),'09:23','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (89,to_date('05-OCT-23','DD-MON-RR'),'09:23','CR',23.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (90,to_date('05-OCT-23','DD-MON-RR'),'09:27','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (91,to_date('05-OCT-23','DD-MON-RR'),'09:27','CR',23.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (92,to_date('05-OCT-23','DD-MON-RR'),'09:27','CR',23.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (93,to_date('05-OCT-23','DD-MON-RR'),'09:28','CR',23.5,4);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (94,to_date('05-NOV-23','DD-MON-RR'),'09:19','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (95,to_date('05-NOV-23','DD-MON-RR'),'09:23','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (96,to_date('05-NOV-23','DD-MON-RR'),'09:23','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (97,to_date('05-NOV-23','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (98,to_date('05-NOV-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (99,to_date('05-NOV-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (100,to_date('05-NOV-23','DD-MON-RR'),'09:28','CR',23.5,3);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (101,to_date('05-DEC-23','DD-MON-RR'),'09:19','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (102,to_date('05-DEC-23','DD-MON-RR'),'09:23','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (103,to_date('05-DEC-23','DD-MON-RR'),'09:23','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (104,to_date('05-DEC-23','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (105,to_date('05-DEC-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (106,to_date('05-DEC-23','DD-MON-RR'),'09:27','CR',23.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (107,to_date('05-DEC-23','DD-MON-RR'),'09:28','CR',23.5,3);


Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (108,to_date('05-JAN-24','DD-MON-RR'),'09:24','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (109,to_date('05-JAN-24','DD-MON-RR'),'09:24','CR',24.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (110,to_date('05-JAN-24','DD-MON-RR'),'09:27','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (111,to_date('05-JAN-24','DD-MON-RR'),'09:27','CR',24.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (112,to_date('05-JAN-24','DD-MON-RR'),'09:27','CR',24.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (113,to_date('05-JAN-24','DD-MON-RR'),'09:28','CR',24.5,4);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (114,to_date('05-FEB-24','DD-MON-RR'),'09:19','CR',24.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (115,to_date('05-FEB-24','DD-MON-RR'),'09:24','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (116,to_date('05-FEB-24','DD-MON-RR'),'09:24','CR',24.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (117,to_date('05-FEB-24','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (118,to_date('05-FEB-24','DD-MON-RR'),'09:27','CR',24.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (119,to_date('05-FEB-24','DD-MON-RR'),'09:27','CR',24.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (120,to_date('05-FEB-24','DD-MON-RR'),'09:28','CR',24.5,3);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (121,to_date('05-MAR-24','DD-MON-RR'),'09:19','CR',24.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (122,to_date('05-MAR-24','DD-MON-RR'),'09:24','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (123,to_date('05-MAR-24','DD-MON-RR'),'09:24','CR',24.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (124,to_date('05-MAR-24','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (125,to_date('05-MAR-24','DD-MON-RR'),'09:27','CR',24.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (126,to_date('05-MAR-24','DD-MON-RR'),'09:27','CR',24.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (127,to_date('05-MAR-24','DD-MON-RR'),'09:28','CR',24.5,3);


Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (128,to_date('05-MAR-24','DD-MON-RR'),'09:24','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (129,to_date('05-MAR-24','DD-MON-RR'),'09:24','CR',24.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (130,to_date('05-MAR-24','DD-MON-RR'),'09:27','VN',30.75,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (131,to_date('05-MAR-24','DD-MON-RR'),'09:27','CR',24.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (132,to_date('05-MAR-24','DD-MON-RR'),'09:27','CR',24.5,4);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (133,to_date('05-MAR-24','DD-MON-RR'),'09:28','CR',24.5,4);

Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (134,to_date('05-MAR-24','DD-MON-RR'),'09:19','CR',24.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (135,to_date('05-MAR-24','DD-MON-RR'),'09:24','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (136,to_date('05-MAR-24','DD-MON-RR'),'09:24','CR',24.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (137,to_date('05-MAR-24','DD-MON-RR'),'09:27','VN',30.75,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (138,to_date('05-MAR-24','DD-MON-RR'),'09:27','CR',24.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (139,to_date('05-MAR-24','DD-MON-RR'),'09:27','CR',24.5,3);
Insert into TICKETS (T_CODE,T_DATE,T_TIME,V_CODE,SALE_PRICE,DEP_ID) values (140,to_date('05-MAR-24','DD-MON-RR'),'09:28','CR',24.5,3);

COMMIT;      
    
