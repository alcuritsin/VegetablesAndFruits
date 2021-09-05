-- Создание таблици продуктов
CREATE TABLE table_product
(
    id            INT AUTO_INCREMENT PRIMARY KEY,
    name          VARCHAR(50) NOT NULL,
    type_product  VARCHAR(50) NOT NULL,
    color_product VARCHAR(50) NOT NULL,
    energy_value  INT         NOT NULL
);

-- Вставить значение в таблицу продукты
-- bool IsertProduct(Product product){}
INSERT INTO table_product
    (name, type_product, color_product, energy_value)
    VALUE ('Капуста','Овощ','Зелёный','25');

-- Получить таблицу всех значений из таблицы продукты
-- List<Product> GetProducts(){}
SELECT *
FROM table_product;

-- Получить таблицу всех имён из таблицы продукты
-- List<string> GetNameProduct() {}
SELECT name
FROM table_product;

-- Получить таблицу всех цветов из таблицы продукты
-- List<string> GetColorProduct() {}
SELECT color_product
FROM table_product;

-- Показать максимальную калорийность
-- int GetMaxEnergyValue() {}
SELECT MAX(energy_value) as max
FROM table_product;

-- Показать минимальную калорийность
-- int GetMinEnergyValue() {}
SELECT MIN(energy_value) as min
FROM table_product;

-- Показать среднюю калорийность
-- public decimal GetAvgEnergyValue() {}
SELECT AVG(energy_value) as avg
FROM table_product;