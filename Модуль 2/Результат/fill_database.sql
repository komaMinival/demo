-- Заполнение базы данных для модулей 1-3
-- Включает данные из Заказчики.json.

INSERT INTO unit (id, name) VALUES
(1, 'шт'),
(2, 'кг');
SELECT setval('unit_id_seq', 2);

INSERT INTO contragent (id, name, inn, address, phone, email, is_salesman, is_buyer) VALUES
(1, 'ООО "Поставка"', NULL, 'г.Пятигорск', '+79198634592', NULL, TRUE, TRUE),
(2, 'ООО "Кинотеатр Квант"', '26320045123', 'г. Железноводск, ул. Мира, 123', '+79884581555', NULL, TRUE, FALSE),
(8, 'ООО "Новый JDTO"', '26320045111', 'г. Железноводсу', '+79884581555', NULL, TRUE, FALSE),
(3, 'ООО "Ромашка"', '4140784214', 'г. Омск, ул. Строителей, 294', '+79882584546', NULL, FALSE, TRUE),
(9, 'ООО "Ипподром"', '5874045632', 'г. Уфа, ул. Набережная,  37', '+79627486389', NULL, TRUE, TRUE),
(10, 'ООО "Ассоль"', '2629011278', 'г. Калуга, ул. Пушкина, 94', '+79184572398', NULL, FALSE, TRUE),
(4, 'ООО "Фрегат"', NULL, NULL, NULL, NULL, FALSE, TRUE);

INSERT INTO material (id, code, name, unit_id, price) VALUES
(1, 'НФ-00000023', 'Закваска сметанная', 2, 45.00),
(2, 'НФ-00000020', 'Изюм', 2, 150.00),
(3, 'НФ-00000021', 'Масло сливочное', 2, 124.00),
(4, 'НФ-00000004', 'Молоко нормализованное', 2, 34.00),
(5, 'НФ-00000018', 'Мука', 2, 220.00),
(6, 'НФ-00000019', 'Сода', 1, 60.00),
(7, 'НФ-00000022', 'Яйца', 1, 80.00);
SELECT setval('material_id_seq', 7);

INSERT INTO product (id, code, name, unit_id, price) VALUES
(1, 'НФ-00000010', 'Батон нарезной', 1, 45.00),
(2, 'НФ-00000014', 'Булочка с изюмом', 1, 35.00),
(3, 'НФ-00000015', 'Булочка с корицей', 1, 35.00),
(4, 'НФ-00000011', 'Хлеб белый 1 кг.', 1, 42.00),
(5, 'НФ-00000012', 'Хлеб Кронштадтский 1 кг.', 1, 120.00),
(6, 'НФ-00000013', 'Хлеб ржаной 800г.', 1, 47.00);
SELECT setval('product_id_seq', 6);

INSERT INTO specification (product_id, material_id, quantity) VALUES
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

INSERT INTO customer_order (id, number, order_date, contragent_id, status) VALUES
(1, 3, '2025-06-07', 4, 'accepted'),
(2, 4, '2025-06-08', 1, 'accepted');

INSERT INTO order_item (order_id, product_id, quantity, price, total) VALUES
(1, 4, 8, 42.00, 336.00),
(1, 6, 7, 47.00, 329.00),
(2, 2, 10, 35.00, 350.00);
SELECT setval('customer_order_id_seq', 2);
SELECT setval('order_item_id_seq', 3);

INSERT INTO production (id, number, production_date, product_id, quantity) VALUES
(1, 1, '2025-06-09', 2, 1);

INSERT INTO production_material (production_id, material_id, quantity) VALUES
(1, 2, 0.0200),
(1, 3, 0.0200),
(1, 4, 0.1500),
(1, 7, 0.2500),
(1, 5, 0.1000),
(1, 6, 0.0050);
SELECT setval('production_id_seq', 1);
SELECT setval('production_material_id_seq', 6);
