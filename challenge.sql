-- MySQL script to pre-load records for this API.

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

--
-- Database: `challenge`
--
CREATE DATABASE IF NOT EXISTS `challenge` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `challenge`;

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

DROP TABLE IF EXISTS `course`;
CREATE TABLE `course` (
  `course_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `desc` varchar(1000) DEFAULT NULL,
  `price` decimal(9,2) DEFAULT '0.00',
  `status` varchar(10) DEFAULT 'available'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`course_id`, `name`, `desc`, `price`, `status`) VALUES
(1, 'Windows', 'Windows 10 Pro', '299.00', 'available'),
(2, 'React', 'React JS', '899.00', 'available'),
(3, 'Office', 'Office for Mac', '199.00', 'available'),
(4, 'Newtorking', 'Topology, Protocols, IT', '1499.00', 'available'),
(5, 'MAC OSX', 'Mac for Devs', '2599.00', 'available');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`course_id`);
