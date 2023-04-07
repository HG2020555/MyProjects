/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     5/25/2022 6:57:23 AM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"Add"') and o.name = 'FK_ADD_REFERENCE_GAME')
alter table "Add"
   drop constraint FK_ADD_REFERENCE_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"Add"') and o.name = 'FK_ADD_REFERENCE_VENDOR')
alter table "Add"
   drop constraint FK_ADD_REFERENCE_VENDOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Game') and o.name = 'FK_GAME_REFERENCE_VENDOR')
alter table Game
   drop constraint FK_GAME_REFERENCE_VENDOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('rent') and o.name = 'FK_RENT_REFERENCE_CLIENT')
alter table rent
   drop constraint FK_RENT_REFERENCE_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('rent') and o.name = 'FK_RENT_REFERENCE_GAME')
alter table rent
   drop constraint FK_RENT_REFERENCE_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"return"') and o.name = 'FK_RETURN_REFERENCE_GAME')
alter table "return"
   drop constraint FK_RETURN_REFERENCE_GAME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"return"') and o.name = 'FK_RETURN_REFERENCE_CLIENT')
alter table "return"
   drop constraint FK_RETURN_REFERENCE_CLIENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"Add"')
            and   type = 'U')
   drop table "Add"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Game')
            and   type = 'U')
   drop table Game
go

if exists (select 1
            from  sysobjects
           where  id = object_id('client')
            and   type = 'U')
   drop table client
go

if exists (select 1
            from  sysobjects
           where  id = object_id('rent')
            and   type = 'U')
   drop table rent
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"return"')
            and   type = 'U')
   drop table "return"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('vendor')
            and   type = 'U')
   drop table vendor
go

/*==============================================================*/
/* Table: "Add"                                                 */
/*==============================================================*/
create table "Add" (
   GID                  numeric(4)           not null,
   VID                  numeric(4)           not null,
   date                 datetime             not null,
   constraint PK_ADD primary key (GID, VID)
)
go

/*==============================================================*/
/* Table: Game                                                  */
/*==============================================================*/
create table Game (
   GID                  numeric(4)           not null,
   VID                  numeric(4)           null,
   Gname                varchar(10)          not null,
   state                varchar(10)          not null,
   category             varchar(10)          not null,
   price                numeric(3)           not null,
   constraint PK_GAME primary key (GID)
)
go

/*==============================================================*/
/* Table: client                                                */
/*==============================================================*/
create table client (
   CID                  numeric(4)           not null,
   Cname                varchar(12)          not null,
   Cpass                varchar(7)           not null,
   constraint PK_CLIENT primary key (CID)
)
go

/*==============================================================*/
/* Table: rent                                                  */
/*==============================================================*/
create table rent (
   CID                  numeric(4)           not null,
   GID                  numeric(4)           not null,
   rent_date            datetime             not null,
   constraint PK_RENT primary key (CID, GID)
)
go

/*==============================================================*/
/* Table: "return"                                              */
/*==============================================================*/
create table "return" (
   GID                  numeric(4)           not null,
   CID                  numeric(4)           not null,
   return_date          datetime             not null,
   cost                 numeric(7)           not null,
   constraint PK_RETURN primary key (GID, CID)
)
go

/*==============================================================*/
/* Table: vendor                                                */
/*==============================================================*/
create table vendor (
   VID                  numeric(4)           not null,
   Vname                varchar(12)          not null,
   Vpass                varchar(7)           not null,
   constraint PK_VENDOR primary key (VID)
)
go

alter table "Add"
   add constraint FK_ADD_REFERENCE_GAME foreign key (GID)
      references Game (GID)
go

alter table "Add"
   add constraint FK_ADD_REFERENCE_VENDOR foreign key (VID)
      references vendor (VID)
go

alter table Game
   add constraint FK_GAME_REFERENCE_VENDOR foreign key (VID)
      references vendor (VID)
go

alter table rent
   add constraint FK_RENT_REFERENCE_CLIENT foreign key (CID)
      references client (CID)
go

alter table rent
   add constraint FK_RENT_REFERENCE_GAME foreign key (GID)
      references Game (GID)
go

alter table "return"
   add constraint FK_RETURN_REFERENCE_GAME foreign key (GID)
      references Game (GID)
go

alter table "return"
   add constraint FK_RETURN_REFERENCE_CLIENT foreign key (CID)
      references client (CID)
go

