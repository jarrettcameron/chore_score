-- Active: 1715613946315@@127.0.0.1@3306@vibrant_rain_e478fb_db
CREATE TABLE IF NOT EXISTS accounts (
    id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
    name varchar(255) COMMENT 'User Name',
    email varchar(255) COMMENT 'User Email',
    picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

SELECT * FROM chores;

INSERT INTO
    chores (name, description)
VALUES (
        "Walk the raccoons",
        "Don't go to the dog park, we are banned for life."
    );