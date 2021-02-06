-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 06, 2021 at 02:17 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ordergo`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteCategory` (IN `cid` TINYINT)  MODIFIES SQL DATA
DELETE FROM categories WHERE c_id = cid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteMenu` (IN `menuID` TINYINT)  MODIFIES SQL DATA
DELETE FROM menu WHERE m_id = menuID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteRole` (IN `rid` TINYINT)  MODIFIES SQL DATA
DELETE FROM roles WHERE r_id=rid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteTax` (IN `tid` TINYINT)  MODIFIES SQL DATA
DELETE FROM taxes WHERE t_id = tid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteUser` (IN `userID` INT)  MODIFIES SQL DATA
DELETE FROM users WHERE u_id = userID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getCategories` ()  READS SQL DATA
SELECT c.c_id AS 'CategoryID', c.c_name AS 'Category' FROM categories c$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getCompletedOrders` ()  READS SQL DATA
SELECT o.o_id AS 'Order ID', o.o_orderType AS 'Order Type', o.o_totalAmount AS 'Total Amount', o.o_phone AS 'Phone', o.o_address AS 'Address', o.o_tax AS 'Tax', CASE o.o_status WHEN 0 THEN 'Pending' WHEN 1 THEN 'Completed' WHEN 2 THEN 'Paid' END AS 'Status' FROM orders o WHERE o.o_status = 1 ORDER BY o.o_id ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getDeliveryOrderReport` (IN `oid` BIGINT)  READS SQL DATA
SELECT o.o_id AS 'Order ID', o.o_date AS 'Date', m.m_name AS 'Item', od.od_quantity AS 'Quantity', m.m_price * od.od_quantity AS 'Price', o.o_totalAmount as "Total Bill", o.o_tax AS 'Tax', o.o_phone 'Phone', o.o_address AS 'Address'  FROM orders o INNER JOIN orderdetails od ON od.od_orderID = o.o_id INNER JOIN menu m ON od.od_itemID = m.m_id WHERE o.o_id = oid AND o.o_status = 2$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getDineInOrderReport` (IN `oid` BIGINT)  READS SQL DATA
SELECT o.o_id AS 'Order ID', o.o_date AS 'Date', m.m_name AS 'Item', od.od_quantity AS 'Quantity', m.m_price * od.od_quantity AS 'Price', o.o_totalAmount as "Total Bill", o.o_tax AS 'Tax'  FROM orders o INNER JOIN orderdetails od ON od.od_orderID = o.o_id INNER JOIN menu m ON od.od_itemID = m.m_id WHERE o.o_id = oid AND o.o_status = 2$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getFinance` (IN `fromD` DATE, IN `toD` DATE)  READS SQL DATA
SELECT o.o_date AS 'Date', CASE o.o_orderType WHEN 0 THEN 'Dine-In' WHEN 1 THEN 'Delivery' END AS 'Order Type', o.o_totalAmount AS 'Total' From orders o WHERE o.o_status = 2 AND o.o_date BETWEEN fromD AND toD ORDER BY o.o_id ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getItemsByCategory` (IN `cid` TINYINT)  READS SQL DATA
SELECT m.m_id AS 'MenuID', m.m_name AS 'Menu Item', m.m_price AS 'Price', c.c_id AS 'CategoryID', c.c_name AS 'Category' FROM menu m INNER JOIN categories c ON m.m_categoryID = c.c_id WHERE c.c_id = cid ORDER BY c.c_name ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getLastOrderID` ()  READS SQL DATA
SELECT o.o_id FROM orders o ORDER BY o.o_id DESC LIMIT 1$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getMenu` ()  READS SQL DATA
SELECT m.m_id AS 'MenuID', m.m_name AS 'Menu Item', m.m_price AS 'Price', m.m_photo AS 'Photo', m.m_categoryID AS 'CategoryID', c.c_name AS 'Category' FROM menu m INNER JOIN categories c ON m.m_categoryID = c.c_id ORDER BY c.c_name ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getOrderDetails` (IN `oid` BIGINT)  READS SQL DATA
SELECT m.m_name AS 'Item', od.od_quantity as 'Quantity' FROM orderdetails od INNER JOIN menu m ON od.od_itemID = m.m_id WHERE od.od_orderID = oid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getPendingOrders` ()  READS SQL DATA
SELECT o.o_id AS 'Order ID', CASE o.o_status WHEN 0 THEN 'Pending' WHEN 1 THEN 'Completed' WHEN 2 THEN 'Paid' END AS 'Status' FROM orders o WHERE o.o_status = 0 ORDER BY o.o_id ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getPriceByItem` (IN `mid` INT)  READS SQL DATA
SELECT m.m_price AS 'Price' FROM menu m WHERE m.m_id = mid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getRoles` ()  READS SQL DATA
SELECT r.r_id AS 'RoleID', r.r_name AS 'Role' FROM roles r$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getTaxes` ()  READS SQL DATA
SELECT t.t_id AS 'Tax ID', t.t_name AS 'Name', t.t_amount AS 'Amount' FROM taxes t$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getUserForAuth` (IN `username` VARCHAR(30), IN `password` VARCHAR(30))  READS SQL DATA
SELECT u.u_id AS 'User ID', u.u_name AS 'User', u.u_uname AS 'Username', u.u_password AS 'Password', u.u_phone AS 'Phone', u.u_address AS 'Address', u.u_roleID AS 'Role ID', r.r_name AS 'Role' From users u INNER JOIN roles r ON u.u_roleID = r.r_id WHERE u.u_uname = username AND u.u_password = password$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getUsers` ()  READS SQL DATA
SELECT
u.u_id AS 'User ID',
u.u_name AS 'User',
u.u_uname AS 'Username',
u.u_password AS 'Password',
u.u_phone AS 'Phone',
u.u_address AS 'Address',
u.u_roleID AS 'Role ID',
r.r_name AS 'Role'
From users u
INNER JOIN roles r
ON u.u_roleID = r.r_id
ORDER BY u.u_name ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertCategory` (IN `name` VARCHAR(30))  MODIFIES SQL DATA
INSERT INTO categories(c_name) VALUES(name)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertMenu` (IN `name` VARCHAR(30), IN `catID` TINYINT, IN `price` DECIMAL(5,2), IN `photo` VARCHAR(254))  MODIFIES SQL DATA
INSERT INTO menu(m_name, m_categoryID, m_price, m_photo) VALUES(name, catID, price, photo)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertOrder` (IN `date` DATE, IN `orderType` TINYINT, IN `tAmount` DECIMAL(5,2), IN `status` TINYINT, IN `phone` VARCHAR(20), IN `address` VARCHAR(50), IN `tax` DECIMAL(5,2))  MODIFIES SQL DATA
INSERT INTO orders(o_date, o_orderType, o_totalAmount, o_status, o_phone, o_address, o_tax) VALUES(date, orderType, tAmount, status, phone, address, tax)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertOrderDetails` (IN `oid` BIGINT, IN `itemID` INT, IN `quantity` TINYINT)  MODIFIES SQL DATA
INSERT INTO orderdetails(od_orderID, od_itemID, od_quantity) VALUES(oid, itemID, quantity)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertRole` (IN `name` VARCHAR(30))  MODIFIES SQL DATA
INSERT INTO roles(r_name) VALUES(name)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertTax` (IN `name` VARCHAR(30), IN `amount` DECIMAL(5,2))  MODIFIES SQL DATA
INSERT INTO taxes(t_name, t_amount) VALUES(name, amount)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `insertUser` (IN `name` VARCHAR(30), IN `username` VARCHAR(30), IN `password` VARCHAR(30), IN `phone` VARCHAR(15), IN `address` VARCHAR(100), IN `roleID` TINYINT)  MODIFIES SQL DATA
INSERT INTO users(u_name, u_uname, u_password, u_phone, u_address, u_roleID) VALUES(name, username, password, phone, address, roleID)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `searchCategory` (IN `name` VARCHAR(30))  READS SQL DATA
SELECT c.c_id AS 'CategoryID', c.c_name AS 'Category' FROM categories c WHERE c.c_name LIKE CONCAT('%', name, '%')$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `searchMenu` (IN `name` VARCHAR(30))  READS SQL DATA
SELECT m.m_id AS 'MenuID', m.m_name AS 'Menu Item', m.m_price AS 'Price', m.m_categoryID AS 'CategoryID', c.c_name AS 'Category' FROM menu m INNER JOIN categories c ON m.m_categoryID = c.c_id WHERE m.m_name LIKE CONCAT('%', name, '%') ORDER BY c.c_name ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `searchRole` (IN `rname` VARCHAR(30))  READS SQL DATA
SELECT r.r_id AS 'RoleID', r.r_name AS 'Role' FROM roles r WHERE r.r_name LIKE CONCAT('%', rname , '%')$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `searchTax` (IN `name` VARCHAR(30))  READS SQL DATA
SELECT t.t_id AS 'Tax ID', t.t_name AS 'Name', t.t_amount AS 'Amount' FROM taxes t WHERE t.t_name LIKE CONCAT('%', name, '%')$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `searchUser` (IN `name` VARCHAR(30))  READS SQL DATA
SELECT
u.u_id AS 'User ID',
u.u_name AS 'User',
u.u_uname AS 'Username',
u.u_password AS 'Password',
u.u_phone AS 'Phone',
u.u_address AS 'Address',
u.u_roleID AS 'Role ID',
r.r_name AS 'Role'
From users u
INNER JOIN roles r
ON u.u_roleID = r.r_id
WHERE u.u_name LIKE CONCAT('%', name, '%')
ORDER BY u.u_name ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateCategory` (IN `name` VARCHAR(30), IN `cid` TINYINT)  MODIFIES SQL DATA
UPDATE categories SET c_name = name WHERE c_id = cid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateMenu` (IN `name` VARCHAR(30), IN `catID` TINYINT, IN `price` DECIMAL(5,2), IN `photo` VARCHAR(254), IN `menuID` TINYINT)  MODIFIES SQL DATA
UPDATE menu SET m_name = name, m_categoryID = catID, m_price = price, m_photo = photo WHERE m_id = menuID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateOrderStatus` (IN `status` TINYINT, IN `oid` BIGINT)  MODIFIES SQL DATA
UPDATE orders SET o_status = status WHERE o_id = oid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateRole` (IN `name` VARCHAR(30), IN `rid` TINYINT)  MODIFIES SQL DATA
UPDATE roles SET r_name=name WHERE r_id=rid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateTax` (IN `name` VARCHAR(30), IN `amount` DECIMAL(5,2), IN `tid` TINYINT)  MODIFIES SQL DATA
UPDATE taxes SET t_name = name, t_amount = amount WHERE t_id = tid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateUser` (IN `name` VARCHAR(30), IN `username` VARCHAR(30), IN `password` VARCHAR(30), IN `phone` VARCHAR(15), IN `address` VARCHAR(100), IN `roleID` TINYINT, IN `userID` INT)  MODIFIES SQL DATA
UPDATE users
SET
u_name = name,
u_uname = username,
u_password = password,
u_phone = phone,
u_address = address,
u_roleID = roleID
WHERE
u_id = userID$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `c_id` tinyint(4) NOT NULL,
  `c_name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`c_id`, `c_name`) VALUES
(3, 'Burgers'),
(2, 'Drinks'),
(1, 'Pizza');

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `m_id` int(11) NOT NULL,
  `m_name` varchar(30) NOT NULL,
  `m_categoryID` tinyint(4) NOT NULL,
  `m_price` decimal(5,2) NOT NULL,
  `m_photo` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`m_id`, `m_name`, `m_categoryID`, `m_price`, `m_photo`) VALUES
(1, 'Margarita', 1, '4.30', 'https://jamiecooksitup.net/wp-content/uploads/2015/05/Margarita-Pizza-from-Jamie-Cooks-It-Up.jpg'),
(2, 'Pepperoni', 1, '4.60', 'https://townsquare.media/site/959/files/2020/08/GettyImages-1133727757.jpg'),
(3, 'Vegetarian Burger', 3, '3.60', 'https://www.recipetineats.com/wp-content/uploads/2018/04/Veggie-Burgers_9a.jpg'),
(4, 'Beef Burger', 3, '4.00', 'https://mapleleafhh.com/wp-content/uploads/Broiled-Beef-Burger-e1556647638183.jpg'),
(5, 'RedBull', 2, '2.00', 'https://cdn.shopify.com/s/files/1/1719/2651/articles/red-bull-3301415_1280_1024x1024.jpg'),
(6, 'CocaCola', 2, '1.00', 'https://specials-images.forbesimg.com/imageserve/1189255149/960x0.jpg'),
(7, 'Wine', 2, '2.20', 'https://nomansgrace.com/wp-content/uploads/2020/06/176361.jpg'),
(8, 'Heniken', 2, '2.50', 'https://cdn.shopify.com/s/files/1/2788/1238/products/heineken_330ml_763ab3a4-a925-4ef1-956a-5ddbfe71bd15_1024x1024.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `orderdetails`
--

CREATE TABLE `orderdetails` (
  `od_id` bigint(20) NOT NULL,
  `od_orderID` bigint(20) NOT NULL,
  `od_itemID` int(11) NOT NULL,
  `od_quantity` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orderdetails`
--

INSERT INTO `orderdetails` (`od_id`, `od_orderID`, `od_itemID`, `od_quantity`) VALUES
(1, 1, 4, 3),
(2, 1, 15, 3),
(3, 2, 13, 2),
(4, 3, 15, 2),
(5, 3, 4, 2),
(6, 4, 9, 1),
(7, 4, 10, 1),
(8, 4, 15, 2),
(9, 5, 14, 2),
(10, 6, 4, 2),
(11, 6, 10, 1),
(12, 6, 15, 3),
(13, 7, 9, 1),
(14, 7, 8, 1),
(15, 8, 8, 1),
(16, 8, 9, 1),
(17, 8, 10, 1),
(18, 8, 16, 3),
(19, 9, 2, 2),
(20, 10, 13, 2),
(21, 11, 3, 2),
(22, 12, 1, 2),
(23, 13, 4, 2),
(24, 13, 1, 2),
(25, 14, 2, 2),
(26, 15, 9, 2),
(27, 16, 14, 3),
(28, 17, 4, 2);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `o_id` bigint(20) NOT NULL,
  `o_date` date NOT NULL,
  `o_orderType` tinyint(4) NOT NULL,
  `o_totalAmount` decimal(5,2) NOT NULL,
  `o_status` tinyint(4) NOT NULL,
  `o_phone` varchar(20) DEFAULT NULL,
  `o_address` varchar(50) DEFAULT NULL,
  `o_tax` decimal(5,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`o_id`, `o_date`, `o_orderType`, `o_totalAmount`, `o_status`, `o_phone`, `o_address`, `o_tax`) VALUES
(1, '2020-10-22', 1, '20.40', 2, '0698316868', 'Kalceto Mengel', '3.00'),
(2, '2020-10-22', 0, '1.00', 2, NULL, NULL, '0.00'),
(3, '2020-10-23', 0, '11.60', 2, NULL, NULL, '0.00'),
(4, '2020-10-23', 0, '14.00', 2, NULL, NULL, '0.00'),
(5, '2020-10-23', 0, '1.00', 2, NULL, NULL, '0.00'),
(6, '2020-10-23', 0, '17.90', 2, NULL, NULL, '0.00'),
(7, '2020-10-23', 1, '14.20', 2, '0698316868', 'Rr. Kozma Naska, Vila 4 Kateshe', '3.00'),
(8, '2020-10-23', 0, '19.60', 2, NULL, NULL, '0.00'),
(9, '2020-11-14', 1, '8.00', 2, '0698316868', 'Vila perball Varrezave te Deshmorve', '3.00'),
(10, '2020-12-01', 0, '1.00', 2, NULL, NULL, '0.00'),
(11, '2020-12-09', 1, '6.00', 2, '0698314545', 'Rr. Selim Brahja', '3.00'),
(12, '2020-12-10', 0, '3.00', 2, NULL, NULL, '0.00'),
(13, '2020-12-10', 0, '11.60', 2, NULL, NULL, '0.00'),
(14, '2020-12-10', 0, '5.00', 2, NULL, NULL, '0.00'),
(15, '2020-12-15', 0, '12.40', 2, NULL, NULL, '0.00'),
(16, '2020-12-16', 1, '4.50', 2, '069471212', 'Rr. Shefqet Beri', '3.00'),
(17, '2020-12-16', 1, '11.60', 2, '0698316868', 'Rr.Kozma Naska', '3.00');

-- --------------------------------------------------------

--
-- Table structure for table `roles`
--

CREATE TABLE `roles` (
  `r_id` tinyint(4) NOT NULL,
  `r_name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `roles`
--

INSERT INTO `roles` (`r_id`, `r_name`) VALUES
(1, 'Admin'),
(5, 'Chef');

-- --------------------------------------------------------

--
-- Table structure for table `taxes`
--

CREATE TABLE `taxes` (
  `t_id` tinyint(4) NOT NULL,
  `t_name` varchar(30) NOT NULL,
  `t_amount` decimal(5,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `taxes`
--

INSERT INTO `taxes` (`t_id`, `t_name`, `t_amount`) VALUES
(1, 'Dine-In', '0.00'),
(2, 'Delivery', '3.00');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `u_id` int(11) NOT NULL,
  `u_name` varchar(30) NOT NULL,
  `u_uname` varchar(30) NOT NULL,
  `u_password` varchar(30) NOT NULL,
  `u_phone` varchar(15) NOT NULL,
  `u_address` varchar(100) NOT NULL,
  `u_roleID` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`u_id`, `u_name`, `u_uname`, `u_password`, `u_phone`, `u_address`, `u_roleID`) VALUES
(1, 'Deivid Teta', 'dteta', '1109', '0698316868', 'L. Emin Matraxhiu', 1),
(6, 'Fabio Bucaj', 'fbucaj', '1234', '0692383145', 'L. Ali Dem', 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`c_id`),
  ADD UNIQUE KEY `c_name` (`c_name`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`m_id`),
  ADD UNIQUE KEY `m_name` (`m_name`),
  ADD KEY `m_categoryID` (`m_categoryID`);

--
-- Indexes for table `orderdetails`
--
ALTER TABLE `orderdetails`
  ADD PRIMARY KEY (`od_id`),
  ADD KEY `od_orderID` (`od_orderID`),
  ADD KEY `od_itemID` (`od_itemID`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`o_id`);

--
-- Indexes for table `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`r_id`),
  ADD UNIQUE KEY `r_name` (`r_name`);

--
-- Indexes for table `taxes`
--
ALTER TABLE `taxes`
  ADD PRIMARY KEY (`t_id`),
  ADD UNIQUE KEY `t_name` (`t_name`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`u_id`),
  ADD UNIQUE KEY `u_uname` (`u_uname`),
  ADD KEY `u_roleID` (`u_roleID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `c_id` tinyint(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `menu`
--
ALTER TABLE `menu`
  MODIFY `m_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `orderdetails`
--
ALTER TABLE `orderdetails`
  MODIFY `od_id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `o_id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `roles`
--
ALTER TABLE `roles`
  MODIFY `r_id` tinyint(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `taxes`
--
ALTER TABLE `taxes`
  MODIFY `t_id` tinyint(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `u_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `menu`
--
ALTER TABLE `menu`
  ADD CONSTRAINT `menu_ibfk_1` FOREIGN KEY (`m_categoryID`) REFERENCES `categories` (`c_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `orderdetails`
--
ALTER TABLE `orderdetails`
  ADD CONSTRAINT `orderdetails_ibfk_1` FOREIGN KEY (`od_orderID`) REFERENCES `orders` (`o_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `orderdetails_ibfk_2` FOREIGN KEY (`od_itemID`) REFERENCES `menu` (`m_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`u_roleID`) REFERENCES `roles` (`r_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
