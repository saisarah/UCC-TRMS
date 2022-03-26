-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 26, 2022 at 07:05 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.0.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbtrms`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblstudents`
--

CREATE TABLE `tblstudents` (
  `ID` int(11) NOT NULL,
  `fullname` varchar(100) NOT NULL,
  `studentno` varchar(20) NOT NULL,
  `email` varchar(20) NOT NULL,
  `course` varchar(20) NOT NULL,
  `year` varchar(20) NOT NULL,
  `contact` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tblthesis`
--

CREATE TABLE `tblthesis` (
  `ID` int(20) NOT NULL,
  `title` varchar(255) NOT NULL,
  `objectives` varchar(255) NOT NULL,
  `scope` varchar(255) NOT NULL,
  `limitations` varchar(255) NOT NULL,
  `teamname` varchar(255) NOT NULL,
  `members` varchar(255) NOT NULL,
  `panels` varchar(255) NOT NULL,
  `category` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblthesis`
--

INSERT INTO `tblthesis` (`ID`, `title`, `objectives`, `scope`, `limitations`, `teamname`, `members`, `panels`, `category`) VALUES
(1, 'TRMS', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'WEB DEVELOPMENT'),
(2, 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', '', 'LOREM IPSUM', 'WEB DEVELOPMENT'),
(3, 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'APP DEVELOPMENT'),
(4, 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'WEB DEVELOPMENT'),
(5, '', '', '', '', '', '', '', ''),
(6, 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'LOREM IPSUM', 'WEB DEVELOPMENT'),
(7, 'SAS', '', '', '', '', '', '', ''),
(8, 'SASASADA', '', '', '', '', '', '', ''),
(9, 'SASA', '', '', '', '', '', '', ''),
(10, '', 'SASA', '', '', '', '', '', 'WEB DEVELOPMENT');

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `ID` int(11) NOT NULL,
  `username` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblthesis`
--
ALTER TABLE `tblthesis`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblthesis`
--
ALTER TABLE `tblthesis`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;