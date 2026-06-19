-- Справочник единиц измерения
CREATE TABLE unit (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50) NOT NULL UNIQUE
);

-- Контрагенты (поставщики и покупатели)
CREATE TABLE contragent (
    id INTEGER PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    inn VARCHAR(12),
    address VARCHAR(255),
    phone VARCHAR(20),
    is_salesman BOOLEAN NOT NULL DEFAULT FALSE,
    is_buyer BOOLEAN NOT NULL DEFAULT FALSE
);

-- Материалы
CREATE TABLE material (
    id SERIAL PRIMARY KEY,
    code VARCHAR(20) NOT NULL UNIQUE,
    name VARCHAR(255) NOT NULL,
    unit_id INTEGER NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    CONSTRAINT fk_material_unit FOREIGN KEY (unit_id) REFERENCES unit(id)
);

-- Продукция
CREATE TABLE product (
    id SERIAL PRIMARY KEY,
    code VARCHAR(20) NOT NULL UNIQUE,
    name VARCHAR(255) NOT NULL,
    unit_id INTEGER NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    CONSTRAINT fk_product_unit FOREIGN KEY (unit_id) REFERENCES unit(id)
);

-- Спецификация (состав продукции)
CREATE TABLE specification (
    id SERIAL PRIMARY KEY,
    product_id INTEGER NOT NULL,
    material_id INTEGER NOT NULL,
    quantity DECIMAL(10, 4) NOT NULL,
    CONSTRAINT fk_specification_product FOREIGN KEY (product_id) REFERENCES product(id),
    CONSTRAINT fk_specification_material FOREIGN KEY (material_id) REFERENCES material(id)
);

-- Заказы покупателей
CREATE TABLE customer_order (
    id SERIAL PRIMARY KEY,
    number INTEGER NOT NULL,
    order_date DATE NOT NULL,
    contragent_id INTEGER NOT NULL,
    CONSTRAINT fk_order_contragent FOREIGN KEY (contragent_id) REFERENCES contragent(id)
);

-- Строки заказа
CREATE TABLE order_item (
    id SERIAL PRIMARY KEY,
    order_id INTEGER NOT NULL,
    product_id INTEGER NOT NULL,
    quantity INTEGER NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    total DECIMAL(10, 2) NOT NULL,
    CONSTRAINT fk_orderitem_order FOREIGN KEY (order_id) REFERENCES customer_order(id),
    CONSTRAINT fk_orderitem_product FOREIGN KEY (product_id) REFERENCES product(id)
);

-- Производство
CREATE TABLE production (
    id SERIAL PRIMARY KEY,
    number INTEGER NOT NULL,
    production_date DATE NOT NULL,
    product_id INTEGER NOT NULL,
    quantity INTEGER NOT NULL,
    CONSTRAINT fk_production_product FOREIGN KEY (product_id) REFERENCES product(id)
);

-- Материалы производства
CREATE TABLE production_material (
    id SERIAL PRIMARY KEY,
    production_id INTEGER NOT NULL,
    material_id INTEGER NOT NULL,
    quantity DECIMAL(10, 4) NOT NULL,
    CONSTRAINT fk_prodmat_production FOREIGN KEY (production_id) REFERENCES production(id),
    CONSTRAINT fk_prodmat_material FOREIGN KEY (material_id) REFERENCES material(id)
);

-- Импорт данных из Заказчики.json
INSERT INTO contragent (id, name, inn, address, phone, is_salesman, is_buyer) VALUES
(1, 'ООО "Поставка"', NULL, 'г.Пятигорск', '+79198634592', TRUE, TRUE),
(2, 'ООО "Кинотеатр Квант"', '26320045123', 'г. Железноводск, ул. Мира, 123', '+79884581555', TRUE, FALSE),
(8, 'ООО "Новый JDTO"', '26320045111', 'г. Железноводсу', '+79884581555', TRUE, FALSE),
(3, 'ООО "Ромашка"', '4140784214', 'г. Омск, ул. Строителей, 294', '+79882584546', FALSE, TRUE),
(9, 'ООО "Ипподром"', '5874045632', 'г. Уфа, ул. Набережная,  37', '+79627486389', TRUE, TRUE),
(10, 'ООО "Ассоль"', '2629011278', 'г. Калуга, ул. Пушкина, 94', '+79184572398', FALSE, TRUE);
