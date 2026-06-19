-- Полная стоимость заказа покупателя
-- Стоимость = кол-во продукции * сумма(норма расхода материала * цена материала)
SELECT
    co.id AS order_id,
    co.number AS order_number,
    co.order_date,
    co.status,
    c.name AS contragent_name,
    ROUND(SUM(
        oi.quantity * material_cost.cost_per_unit
    ), 2) AS order_total
FROM customer_order co
JOIN contragent c ON c.id = co.contragent_id
JOIN order_item oi ON oi.order_id = co.id
JOIN (
    SELECT
        s.product_id,
        SUM(s.quantity * m.price) AS cost_per_unit
    FROM specification s
    JOIN material m ON m.id = s.material_id
    GROUP BY s.product_id
) material_cost ON material_cost.product_id = oi.product_id
GROUP BY co.id, co.number, co.order_date, co.status, c.name
ORDER BY co.order_date, co.number;
