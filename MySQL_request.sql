CREATE TABLE categories
 (category_id SMALLINT UNSIGNED  PRIMARY KEY NOT NULL,
  category_name VARCHAR(20) NOT NULL UNIQUE
 );

CREATE TABLE products
 (product_id SMALLINT UNSIGNED PRIMARY KEY NOT NULL,
  product_name VARCHAR(20) NOT NULL UNIQUE
 );

CREATE TABLE product_categories
 (product_id SMALLINT UNSIGNED NOT NULL,
  category_id SMALLINT UNSIGNED NOT NULL,
  FOREIGN KEY(product_id) REFERENCES products(product_id),
  FOREIGN KEY(category_id) REFERENCES categories(category_id),
  PRIMARY KEY(product_id, category_id)
 );

 SELECT p.product_name, c.category_name
 FROM products p
 INNER JOIN product_categories p_c
 ON p.product_id = p_c.product_id
 INNER JOIN categories c
 ON p_c.category_id = c.category_id
 ORDER BY product_name;

 INSERT INTO products
  (product_id, product_name)
  VALUE(1, 'prod_1'),
       (2, 'prod_2'),
       (3, 'prod_3'),
       (4, 'prod_4'),
       (5, 'prod_5');

  INSERT INTO categories
   (category_name)
  VALUE('cat_1'),
       ('cat_2'),
       ('cat_3'),
       ('cat_4'),
       ('cat_5');

  INSERT INTO product_categories
   (product_id, category_id)
  VALUE(1, 2),
       (2, 3),
       (3, 1),
       (1, 4),
       (1, 5);