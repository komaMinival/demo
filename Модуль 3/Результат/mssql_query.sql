-- MS SQL Server / SSMS
-- Запрос к базе demo: расчет себестоимости заказов покупателей.

USE demo;
GO

SELECT
    co.id AS order_id,
    co.number AS order_number,
    co.order_date,
    co.status,
    c.name AS contragent_name,
    CAST(SUM(oi.quantity * material_cost.cost_per_unit) AS DECIMAL(10,2)) AS order_total
FROM dbo.customer_order AS co
INNER JOIN dbo.contragent AS c
    ON c.id = co.contragent_id
INNER JOIN dbo.order_item AS oi
    ON oi.order_id = co.id
INNER JOIN (
    SELECT
        s.product_id,
        SUM(s.quantity * m.price) AS cost_per_unit
    FROM dbo.specification AS s
    INNER JOIN dbo.material AS m
        ON m.id = s.material_id
    GROUP BY s.product_id
) AS material_cost
    ON material_cost.product_id = oi.product_id
GROUP BY
    co.id,
    co.number,
    co.order_date,
    co.status,
    c.name
ORDER BY
    co.order_date,
    co.number;
GO
