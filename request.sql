CREATE TABLE table_product
(
    id            INT AUTO_INCREMENT PRIMARY KEY,
    name          VARCHAR(50) NOT NULL,
    type_product  VARCHAR(50) NOT NULL,
    color_product VARCHAR(50) NOT NULL,
    energy_value  INT         NOT NULL
);

INSERT INTO table_product
    (name, type_product, color_product, energy_value)
    VALUE ('Капуста','Овощ','Зелёный','25');

SELECT name, type_product, color_product, energy_value
FROM table_product;

