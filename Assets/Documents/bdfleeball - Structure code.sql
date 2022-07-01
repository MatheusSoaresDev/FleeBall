Create database bdfleeball default character set utf8
default collate utf8_general_ci;

use bdfleeball;

Create table bdfleeball(
	`user_id` int(11) auto_increment not null unique,
    `user_nickname` varchar(50),
    `user_bestscore` int(11)
);

Alter table bdfleeball
	modify column `user_bestscore` int(11) default '0';


Select * from bdfleeball;

