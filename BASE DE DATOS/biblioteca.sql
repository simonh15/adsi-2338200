-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 25, 2022 at 06:03 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `biblioteca`
--

-- --------------------------------------------------------

--
-- Table structure for table `autor`
--

CREATE TABLE `autor` (
  `cedula` varchar(20) NOT NULL,
  `nombre` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `autor`
--

INSERT INTO `autor` (`cedula`, `nombre`) VALUES
('2155789632', 'EDGAR ALLAN POE'),
('2428746952', 'MARIO VARGAS LLOSA'),
('3568615156', 'JULIO VERNE');

-- --------------------------------------------------------

--
-- Table structure for table `clase`
--

CREATE TABLE `clase` (
  `clave` varchar(200) NOT NULL,
  `tiempo_maximo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `clase`
--

INSERT INTO `clase` (`clave`, `tiempo_maximo`) VALUES
('FICCION', 15),
('TERROR', 20);

-- --------------------------------------------------------

--
-- Table structure for table `editorial`
--

CREATE TABLE `editorial` (
  `ID_editorial` int(11) NOT NULL,
  `nombre` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `editorial`
--

INSERT INTO `editorial` (`ID_editorial`, `nombre`) VALUES
(563214, 'EDITORIAL JHON JAIRO');

-- --------------------------------------------------------

--
-- Table structure for table `escribe`
--

CREATE TABLE `escribe` (
  `codigo_libro_lib1` int(11) DEFAULT NULL,
  `cedula_aut` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `escribe`
--

INSERT INTO `escribe` (`codigo_libro_lib1`, `cedula_aut`) VALUES
(1, '2428746952'),
(3, '2155789632'),
(5, '2428746952'),
(2, '3568615156');

-- --------------------------------------------------------

--
-- Table structure for table `libros`
--

CREATE TABLE `libros` (
  `codigo_libro` int(11) NOT NULL,
  `N°_paginas` int(11) DEFAULT NULL,
  `titulo` varchar(200) DEFAULT NULL,
  `ID_editorial_edi` int(11) DEFAULT NULL,
  `clave_cla` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `libros`
--

INSERT INTO `libros` (`codigo_libro`, `N°_paginas`, `titulo`, `ID_editorial_edi`, `clave_cla`) VALUES
(1, 1002, 'LA CASA SIN PUERTAS NI VENTANAS', 563214, 'FICCION'),
(2, 705, 'EL CUARTO SIN ESQUINAS', 563214, 'TERROR'),
(3, 989, 'LA NOCHE SIN LUNA', 563214, 'FICCION'),
(4, 500, 'CUANDO LLUEVA DE PARA ARRIBA', 563214, 'TERROR'),
(5, 400, 'EL INICIO DEL MUNDO', 563214, 'FICCION');

-- --------------------------------------------------------

--
-- Table structure for table `prestamos`
--

CREATE TABLE `prestamos` (
  `N°_carnet_usu` int(11) DEFAULT NULL,
  `codigo_libro_lib` int(11) DEFAULT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_devolucion` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `prestamos`
--

INSERT INTO `prestamos` (`N°_carnet_usu`, `codigo_libro_lib`, `fecha_inicio`, `fecha_devolucion`) VALUES
(1, 5, '2022-12-01', '2023-02-01'),
(2, 4, '2022-07-01', '2022-10-01'),
(3, 3, '2022-11-01', '2023-01-01'),
(4, 2, '2022-10-01', '2022-12-01'),
(5, 1, '2022-04-01', '2022-06-01');

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `N°_carnet` int(11) NOT NULL,
  `direccion` varchar(200) DEFAULT NULL,
  `nombre` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`N°_carnet`, `direccion`, `nombre`) VALUES
(1, 'ENEA', 'CARLOS GIRALDO'),
(2, 'ENTRADA VILLA MARIA', 'DANIEL CASTRILLON'),
(3, 'VILLA MARIA', 'SANTIAGO ARANGO'),
(4, 'TORRES DE BARCELONA', 'CAMILO ROJAS'),
(5, 'BAJO TABLAZO', 'CRISTIAN LOPEZ');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `autor`
--
ALTER TABLE `autor`
  ADD PRIMARY KEY (`cedula`);

--
-- Indexes for table `clase`
--
ALTER TABLE `clase`
  ADD PRIMARY KEY (`clave`);

--
-- Indexes for table `editorial`
--
ALTER TABLE `editorial`
  ADD PRIMARY KEY (`ID_editorial`);

--
-- Indexes for table `escribe`
--
ALTER TABLE `escribe`
  ADD KEY `FK_cedula_aut` (`cedula_aut`),
  ADD KEY `FK_codigo_libro_lib1` (`codigo_libro_lib1`);

--
-- Indexes for table `libros`
--
ALTER TABLE `libros`
  ADD PRIMARY KEY (`codigo_libro`),
  ADD KEY `ID_editorial_edi` (`ID_editorial_edi`),
  ADD KEY `clave_cla` (`clave_cla`);

--
-- Indexes for table `prestamos`
--
ALTER TABLE `prestamos`
  ADD KEY `N°_carnet_usu` (`N°_carnet_usu`),
  ADD KEY `codigo_libro_lib` (`codigo_libro_lib`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`N°_carnet`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `libros`
--
ALTER TABLE `libros`
  MODIFY `codigo_libro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `N°_carnet` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `escribe`
--
ALTER TABLE `escribe`
  ADD CONSTRAINT `FK_cedula_aut` FOREIGN KEY (`cedula_aut`) REFERENCES `autor` (`cedula`),
  ADD CONSTRAINT `FK_codigo_libro_lib1` FOREIGN KEY (`codigo_libro_lib1`) REFERENCES `libros` (`codigo_libro`);

--
-- Constraints for table `libros`
--
ALTER TABLE `libros`
  ADD CONSTRAINT `libros_ibfk_1` FOREIGN KEY (`ID_editorial_edi`) REFERENCES `editorial` (`ID_editorial`),
  ADD CONSTRAINT `libros_ibfk_2` FOREIGN KEY (`clave_cla`) REFERENCES `clase` (`clave`);

--
-- Constraints for table `prestamos`
--
ALTER TABLE `prestamos`
  ADD CONSTRAINT `prestamos_ibfk_1` FOREIGN KEY (`N°_carnet_usu`) REFERENCES `usuario` (`N°_carnet`),
  ADD CONSTRAINT `prestamos_ibfk_2` FOREIGN KEY (`codigo_libro_lib`) REFERENCES `libros` (`codigo_libro`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
