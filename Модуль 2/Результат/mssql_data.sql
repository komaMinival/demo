-- MS SQL Server / SSMS
-- Заполнение базы demo данными для модулей 1-3.
-- Перед запуском выполните mssql.sql.

USE demo;
GO

INSERT INTO dbo.unit (name) VALUES
(N'шт'),
(N'кг');
GO

-- Данные из Заказчики.json + заказчик из заказа покупателя.
INSERT INTO dbo.contragent (id, name, inn, address, phone, email, is_salesman, is_buyer) VALUES
(1, N'ООО "Поставка"', NULL, N'г.Пятигорск', N'+79198634592', NULL, 1, 1),
(2, N'ООО "Кинотеатр Квант"', N'26320045123', N'г. Железноводск, ул. Мира, 123', N'+79884581555', NULL, 1, 0),
(8, N'ООО "Новый JDTO"', N'26320045111', N'г. Железноводсу', N'+79884581555', NULL, 1, 0),
(3, N'ООО "Ромашка"', N'4140784214', N'г. Омск, ул. Строителей, 294', N'+79882584546', NULL, 0, 1),
(9, N'ООО "Ипподром"', N'5874045632', N'г. Уфа, ул. Набережная,  37', N'+79627486389', NULL, 1, 1),
(10, N'ООО "Ассоль"', N'2629011278', N'г. Калуга, ул. Пушкина, 94', N'+79184572398', NULL, 0, 1),
(4, N'ООО "Фрегат"', NULL, NULL, NULL, NULL, 0, 1);
GO

SET IDENTITY_INSERT dbo.material ON;
INSERT INTO dbo.material (id, code, name, unit_id, price) VALUES
(1, N'НФ-00000023', N'Закваска сметанная', 2, 45.00),
(2, N'НФ-00000020', N'Изюм', 2, 150.00),
(3, N'НФ-00000021', N'Масло сливочное', 2, 124.00),
(4, N'НФ-00000004', N'Молоко нормализованное', 2, 34.00),
(5, N'НФ-00000018', N'Мука', 2, 220.00),
(6, N'НФ-00000019', N'Сода', 1, 60.00),
(7, N'НФ-00000022', N'Яйца', 1, 80.00);
SET IDENTITY_INSERT dbo.material OFF;
GO

SET IDENTITY_INSERT dbo.product ON;
INSERT INTO dbo.product (id, code, name, unit_id, price) VALUES
(1, N'НФ-00000010', N'Батон нарезной', 1, 45.00),
(2, N'НФ-00000014', N'Булочка с изюмом', 1, 35.00),
(3, N'НФ-00000015', N'Булочка с корицей', 1, 35.00),
(4, N'НФ-00000011', N'Хлеб белый 1 кг.', 1, 42.00),
(5, N'НФ-00000012', N'Хлеб Кронштадтский 1 кг.', 1, 120.00),
(6, N'НФ-00000013', N'Хлеб ржаной 800г.', 1, 47.00);
SET IDENTITY_INSERT dbo.product OFF;
GO

INSERT INTO dbo.specification (product_id, material_id, quantity) VALUES
(2, 2, 0.0200),
(2, 3, 0.0200),
(2, 4, 0.1500),
(2, 7, 0.2500),
(2, 5, 0.1000),
(2, 6, 0.0050),
(4, 4, 0.2000),
(4, 5, 0.5000),
(4, 6, 0.0100),
(6, 5, 0.3500),
(6, 6, 0.0100);
GO

SET IDENTITY_INSERT dbo.customer_order ON;
INSERT INTO dbo.customer_order (id, number, order_date, contragent_id, status) VALUES
(1, 3, '2025-06-07', 4, N'accepted'),
(2, 4, '2025-06-08', 1, N'accepted');
SET IDENTITY_INSERT dbo.customer_order OFF;
GO

INSERT INTO dbo.order_item (order_id, product_id, quantity, price, total) VALUES
(1, 4, 8, 42.00, 336.00),
(1, 6, 7, 47.00, 329.00),
(2, 2, 10, 35.00, 350.00);
GO

SET IDENTITY_INSERT dbo.production ON;
INSERT INTO dbo.production (id, number, production_date, product_id, quantity) VALUES
(1, 1, '2025-06-09', 2, 1);
SET IDENTITY_INSERT dbo.production OFF;
GO

INSERT INTO dbo.production_material (production_id, material_id, quantity) VALUES
(1, 2, 0.0200),
(1, 3, 0.0200),
(1, 4, 0.1500),
(1, 7, 0.2500),
(1, 5, 0.1000),
(1, 6, 0.0050);
GO
