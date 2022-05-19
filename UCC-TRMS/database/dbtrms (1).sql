-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2022 at 02:03 PM
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
-- Table structure for table `tblarchive`
--

CREATE TABLE `tblarchive` (
  `ID` int(20) NOT NULL,
  `thesis_id` int(255) NOT NULL,
  `title` varchar(255) NOT NULL,
  `objectives` varchar(255) NOT NULL,
  `scope` varchar(255) NOT NULL,
  `limitations` varchar(255) NOT NULL,
  `teamname` varchar(255) NOT NULL,
  `members` varchar(255) NOT NULL,
  `panels` varchar(255) NOT NULL,
  `category` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tblarchivedstud`
--

CREATE TABLE `tblarchivedstud` (
  `ID` int(20) NOT NULL,
  `studID` int(11) NOT NULL,
  `fullname` varchar(255) NOT NULL,
  `studentno` int(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `course` varchar(255) NOT NULL,
  `year` int(255) NOT NULL,
  `section` varchar(10) NOT NULL,
  `contact` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tblenrolled`
--

CREATE TABLE `tblenrolled` (
  `ID` int(20) NOT NULL,
  `studno` varchar(255) NOT NULL,
  `lname` varchar(255) NOT NULL,
  `fname` varchar(255) NOT NULL,
  `midname` varchar(255) NOT NULL,
  `contact` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblenrolled`
--

INSERT INTO `tblenrolled` (`ID`, `studno`, `lname`, `fname`, `midname`, `contact`, `email`) VALUES
(1, '20191940', 'OBEN', 'SARAH GRACE ARLYN', '-', '09469103169', 'oben.sarah.bscs2019@gmail.com'),
(2, '20192509', 'SANCHEZ', 'JIMUEL', 'LAPIDES', '09123456789', 'sanchez.jimuel.bscs2019@gmail.com'),
(3, '20192091', 'GAPUSAN', 'JESSICA JOY', 'SUMODEBILA', '09381731409', 'jessicagapusan23@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudents`
--

CREATE TABLE `tblstudents` (
  `ID` int(11) NOT NULL,
  `fullname` varchar(100) NOT NULL,
  `studentno` int(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `course` varchar(20) NOT NULL,
  `year` int(20) NOT NULL,
  `section` varchar(20) NOT NULL,
  `contact` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tblstudents`
--

INSERT INTO `tblstudents` (`ID`, `fullname`, `studentno`, `email`, `course`, `year`, `section`, `contact`) VALUES
(1, 'SARAH GRACE ARLYN OBEN', 20191940, 'sarah@email.com', 'BSIT', 4, 'C', '09123456789');

-- --------------------------------------------------------

--
-- Table structure for table `tblthesis`
--

CREATE TABLE `tblthesis` (
  `thesis_id` varchar(10) NOT NULL,
  `title` varchar(255) NOT NULL,
  `objectives` varchar(255) NOT NULL,
  `scope` varchar(255) NOT NULL,
  `limitations` varchar(255) NOT NULL,
  `teamname` varchar(255) NOT NULL,
  `members` varchar(255) NOT NULL,
  `panels` varchar(255) NOT NULL,
  `category` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `ID` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`ID`, `username`, `status`) VALUES
(1, 'Admin', 'ACTIVE'),
(2, 'Sarah', 'ACTIVE');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblarchive`
--
ALTER TABLE `tblarchive`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblarchivedstud`
--
ALTER TABLE `tblarchivedstud`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblenrolled`
--
ALTER TABLE `tblenrolled`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblstudents`
--
ALTER TABLE `tblstudents`
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
-- AUTO_INCREMENT for table `tblarchive`
--
ALTER TABLE `tblarchive`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblarchivedstud`
--
ALTER TABLE `tblarchivedstud`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblenrolled`
--
ALTER TABLE `tblenrolled`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tblstudents`
--
ALTER TABLE `tblstudents`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
