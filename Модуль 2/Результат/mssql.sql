-- MS SQL Server / SSMS
-- Создание базы данных и таблиц для модулей 1-3.

IF DB_ID(N'demo') IS NULL
BEGIN
    CREATE DATABASE demo;
END;
GO

USE demo;
GO

IF OBJECT_ID(N'dbo.production_material', N'U') IS NOT NULL DROP TABLE dbo.production_material;
IF OBJECT_ID(N'dbo.production', N'U') IS NOT NULL DROP TABLE dbo.production;
IF OBJECT_ID(N'dbo.order_item', N'U') IS NOT NULL DROP TABLE dbo.order_item;
IF OBJECT_ID(N'dbo.customer_order', N'U') IS NOT NULL DROP TABLE dbo.customer_order;
IF OBJECT_ID(N'dbo.specification', N'U') IS NOT NULL DROP TABLE dbo.specification;
IF OBJECT_ID(N'dbo.product', N'U') IS NOT NULL DROP TABLE dbo.product;
IF OBJECT_ID(N'dbo.material', N'U') IS NOT NULL DROP TABLE dbo.material;
IF OBJECT_ID(N'dbo.contragent', N'U') IS NOT NULL DROP TABLE dbo.contragent;
IF OBJECT_ID(N'dbo.unit', N'U') IS NOT NULL DROP TABLE dbo.unit;
GO

CREATE TABLE dbo.unit (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(50) NOT NULL UNIQUE
);
GO

CREATE TABLE dbo.contragent (
    id INT PRIMARY KEY,
    name NVARCHAR(255) NOT NULL,
    inn NVARCHAR(12) NULL,
    address NVARCHAR(255) NULL,
    phone NVARCHAR(20) NULL,
    email NVARCHAR(120) NULL,
    is_salesman BIT NOT NULL CONSTRAINT DF_contragent_is_salesman DEFAULT 0,
    is_buyer BIT NOT NULL CONSTRAINT DF_contragent_is_buyer DEFAULT 0
);
GO

CREATE TABLE dbo.material (
    id INT IDENTITY(1,1) PRIMARY KEY,
    code NVARCHAR(20) NOT NULL UNIQUE,
    name NVARCHAR(255) NOT NULL,
    unit_id INT NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_material_unit FOREIGN KEY (unit_id) REFERENCES dbo.unit(id),
    CONSTRAINT CK_material_price CHECK (price >= 0)
);
GO

CREATE TABLE dbo.product (
    id INT IDENTITY(1,1) PRIMARY KEY,
    code NVARCHAR(20) NOT NULL UNIQUE,
    name NVARCHAR(255) NOT NULL,
    unit_id INT NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_product_unit FOREIGN KEY (unit_id) REFERENCES dbo.unit(id),
    CONSTRAINT CK_product_price CHECK (price >= 0)
);
GO

CREATE TABLE dbo.specification (
    id INT IDENTITY(1,1) PRIMARY KEY,
    product_id INT NOT NULL,
    material_id INT NOT NULL,
    quantity DECIMAL(10,4) NOT NULL,
    CONSTRAINT FK_specification_product FOREIGN KEY (product_id) REFERENCES dbo.product(id),
    CONSTRAINT FK_specification_material FOREIGN KEY (material_id) REFERENCES dbo.material(id),
    CONSTRAINT CK_specification_quantity CHECK (quantity > 0)
);
GO

CREATE TABLE dbo.customer_order (
    id INT IDENTITY(1,1) PRIMARY KEY,
    number INT NOT NULL,
    order_date DATE NOT NULL,
    contragent_id INT NOT NULL,
    status NVARCHAR(30) NOT NULL CONSTRAINT DF_customer_order_status DEFAULT N'new',
    CONSTRAINT FK_order_contragent FOREIGN KEY (contragent_id) REFERENCES dbo.contragent(id)
);
GO

CREATE TABLE dbo.order_item (
    id INT IDENTITY(1,1) PRIMARY KEY,
    order_id INT NOT NULL,
    product_id INT NOT NULL,
    quantity INT NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_orderitem_order FOREIGN KEY (order_id) REFERENCES dbo.customer_order(id),
    CONSTRAINT FK_orderitem_product FOREIGN KEY (product_id) REFERENCES dbo.product(id),
    CONSTRAINT CK_orderitem_quantity CHECK (quantity > 0),
    CONSTRAINT CK_orderitem_price CHECK (price >= 0),
    CONSTRAINT CK_orderitem_total CHECK (total >= 0)
);
GO

CREATE TABLE dbo.production (
    id INT IDENTITY(1,1) PRIMARY KEY,
    number INT NOT NULL,
    production_date DATE NOT NULL,
    product_id INT NOT NULL,
    quantity INT NOT NULL,
    CONSTRAINT FK_production_product FOREIGN KEY (product_id) REFERENCES dbo.product(id),
    CONSTRAINT CK_production_quantity CHECK (quantity > 0)
);
GO

CREATE TABLE dbo.production_material (
    id INT IDENTITY(1,1) PRIMARY KEY,
    production_id INT NOT NULL,
    material_id INT NOT NULL,
    quantity DECIMAL(10,4) NOT NULL,
    CONSTRAINT FK_prodmat_production FOREIGN KEY (production_id) REFERENCES dbo.production(id),
    CONSTRAINT FK_prodmat_material FOREIGN KEY (material_id) REFERENCES dbo.material(id),
    CONSTRAINT CK_prodmat_quantity CHECK (quantity > 0)
);
GO
