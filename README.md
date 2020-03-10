# MySQL_Unity_Server
MySQL数据库 基于Unity服务器端

1，什么是数据库？
	Excel就是一个数据表，人操作
	MySQL是一个数据库，便于程序操作，便于存储百万以上级别的数据
	
	对于数据库的基本操作：增删改查
	如何对数据库操作 SQL语句 SQL命令 Structured Query Language(SQL)
		1，每个命令后;
		2，不区分大小写
2，数据库排行(2016.10)
	Oracle
	MySQL
	SQL Server
	MongoDB
	PostgreSQL
	DB2
3，关系数据库，
是建立在关系模型基础上的数据库，借助于集合代数等数学概念和方法来处理数据库中的数据。
现实世界中的各种实体以及实体之间的各种联系均用关系模型来表示。

Oracle、SQL Server、MySQL

4，服务器端运行原理图
（理解什么是ip和端口号）
	Web Application Server
	Game Server
	
6, 图示示例见笔记

7，什么是表（Table）（表，行，列，格子）
	表有表头（表头表示这个表有哪些列）
	表里面的每一行都是我们存储的数据

8，MySQL安装
	默认超级管理员
		root root
9，
	MySQL Workbench介绍
	MySQL Command Line Editor
	
数据库的链接
	localhost  127.0.0.1  都代表本机
	
10，什么是表（Table）（表，行，列，格子）
	表有表头（表头表示这个表有哪些列）
	表里面的每一行都是我们存储的数据
	主键(Primary Ke y)
		1,每行数据独一无二的标识
		2,一个表必须有主键(只能有一个主键)
		3,不能为NULL(空值)
		4,由一列或者多列组成
	Unique Key
		1，表示该项数据不能重复
		2，允许一条可以为NULL
	外键(Foreign Key)
		1，这列数据引用了另外一个表的主键 

	表的关系
		一对一 OneToOne
		一对多 OneToMany
		多对多 ManyToMany
	
数据库的创建
表的创建
列的设置

数据添加

数据删除

数据修改

数据查询

10，数据类型
	字符串 - char varchar(length) - string
	整数 - int - int
	小数 - float - float
	日期时间 - date - DateTime
	
	默认值
	可以为NULL
	自动增长
11，MySQL控制台
	help;
	quit;
	show databases;
	use databasexxx;
	show tables;
	select * from tablename;
12，MySQL Workbench全面功能学习
	http://dev.mysql.com/doc/workbench/en/
	
	添加表
	添加数据
	数据的查询
	数据的更改
	数据的提交
	添加数据
	修改表结构查看表结构 alter table