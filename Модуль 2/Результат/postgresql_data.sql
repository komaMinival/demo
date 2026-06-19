-- Данные из М1

-- Единицы измерения
INSERT INTO unit (name) VALUES
('шт'),
('кг');

-- Контрагент из заказа покупателя (отсутствует в Заказчики.json)
INSERT INTO contragent (id, name, inn, address, phone, is_salesman, is_buyer) VALUES
(4, 'ООО "Фрегат"', NULL, NULL, NULL, FALSE, TRUE);

-- Материалы (Цены.xlsx + коды из Производство.xlsx)
INSERT INTO material (id, code, name, unit_id, price) VALUES
(1, 'НФ-00000023', 'Закваска сметанная', 2, 45.00),
(2, 'НФ-00000020', 'Изюм', 2, 150.00),
(3, 'НФ-00000021', 'Масло сливочное', 2, 124.00),
(4, 'НФ-00000004', 'Молоко нормализованное', 2, 34.00),
(5, 'НФ-00000018', 'Мука', 2, 220.00),
(6, 'НФ-00000019', 'Сода', 1, 60.00),
(7, 'НФ-00000022', 'Яйца', 1, 80.00);
SELECT setval('material_id_seq', 7);

-- Продукция (Цены.xlsx + код из Производство.xlsx)
INSERT INTO product (id, code, name, unit_id, price) VALUES
(1, 'НФ-00000010', 'Батон нарезной', 1, 45.00),
(2, 'НФ-00000014', 'Булочка с изюмом', 1, 35.00),
(3, 'НФ-00000015', 'Булочка с корицей', 1, 35.00),
(4, 'НФ-00000011', 'Хлеб белый 1 кг.', 1, 42.00),
(5, 'НФ-00000012', 'Хлеб Кронштадтский 1 кг.', 1, 120.00),
(6, 'НФ-00000013', 'Хлеб ржаной 800г.', 1, 47.00);
SELECT setval('product_id_seq', 6);

-- Спецификация "Булочка с изюмом" (Спецификация.xlsx)
INSERT INTO specification (product_id, material_id, quantity) VALUES
(2, 2, 0.0200),  -- Изюм 0.02 кг
(2, 3, 0.0200),  -- Масло сливочное 0.02 кг
(2, 4, 0.1500),  -- Молоко нормализованное 0.15 кг
(2, 7, 0.2500),  -- Яйца 0.25 шт
(2, 5, 0.1000),  -- Мука 0.1 кг
(2, 6, 0.0050);  -- Сода 0.005 шт

-- Заказ покупателя №3 от 07.06.2025 (Заказ покупателя.xlsx)
INSERT INTO customer_order (id, number, order_date, contragent_id) VALUES
(1, 3, '2025-06-07', 4);

INSERT INTO order_item (order_id, product_id, quantity, price, total) VALUES
(1, 4, 8, 45.00, 360.00),   -- Хлеб белый 1 кг. x8
(1, 6, 7, 47.00, 329.00);   -- Хлеб ржаной 800г. x7

-- Заказ покупателя №4 (тестовый, для проверки запроса М3)
INSERT INTO customer_order (id, number, order_date, contragent_id) VALUES
(2, 4, '2025-06-08', 1);

INSERT INTO order_item (order_id, product_id, quantity, price, total) VALUES
(2, 2, 10, 35.00, 350.00);  -- Булочка с изюмом x10

SELECT setval('customer_order_id_seq', 2);
SELECT setval('order_item_id_seq', 3);

-- Производство №1 от 09.06.2025 (Производство.xlsx)
INSERT INTO production (id, number, production_date, product_id, quantity) VALUES
(1, 1, '2025-06-09', 2, 1);  -- Булочка с изюмом x1

INSERT INTO production_material (production_id, material_id, quantity) VALUES
(1, 2, 0.0200),  -- Изюм
(1, 3, 0.0200),  -- Масло сливочное
(1, 4, 0.1500),  -- Молоко нормализованное
(1, 7, 0.2500),  -- Яйца
(1, 5, 0.1000),  -- Мука
(1, 6, 0.0050);  -- Сода

SELECT setval('production_id_seq', 1);
SELECT setval('production_material_id_seq', 6);
