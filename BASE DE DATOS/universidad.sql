-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 24, 2022 at 04:06 PM
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
-- Database: `universidad`
--

-- --------------------------------------------------------

--
-- Table structure for table `asignaturas`
--

CREATE TABLE `asignaturas` (
  `codigo` varchar(20) NOT NULL,
  `nombre` varchar(200) DEFAULT NULL,
  `Nro_creditos` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `curso`
--

CREATE TABLE `curso` (
  `Nro_ID` int(10) NOT NULL,
  `cedula_doc` varchar(20) DEFAULT NULL,
  `codigo_asi` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `decanos`
--

CREATE TABLE `decanos` (
  `cedula` varchar(20) NOT NULL,
  `nombres` varchar(200) DEFAULT NULL,
  `apellidos` varchar(200) DEFAULT NULL,
  `celular` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `decanos`
--

INSERT INTO `decanos` (`cedula`, `nombres`, `apellidos`, `celular`) VALUES
('1002637181', 'ARNULFO', 'FLORES', '3106307188'),
('1064933', 'PEDRO', 'FLOREZ', '315786466'),
('1234234', 'JULIAN', 'PARRA', '3103216547'),
('5373548', 'DIANA', 'FLOREZ', '3206766674'),
('9585835', 'SANDRA', 'RUIZ', '3114046784');

-- --------------------------------------------------------

--
-- Table structure for table `docentes`
--

CREATE TABLE `docentes` (
  `cedula` varchar(20) NOT NULL,
  `nombres` varchar(200) DEFAULT NULL,
  `apellidos` varchar(200) DEFAULT NULL,
  `titulo` varchar(200) DEFAULT NULL,
  `numero_fac` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `empleados`
--

CREATE TABLE `empleados` (
  `cedula` int(50) NOT NULL,
  `nombres` varchar(200) DEFAULT NULL,
  `apellidos` varchar(200) DEFAULT NULL,
  `genero` varchar(10) DEFAULT NULL,
  `salario` int(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `empleados`
--

INSERT INTO `empleados` (`cedula`, `nombres`, `apellidos`, `genero`, `salario`) VALUES
(34764456, 'Rubén', 'Osorio', 'M', 350000),
(43532658, 'Viviana', 'Rodríguez', 'F', 300000),
(54637829, 'Martha', 'Castro', 'F', 450000),
(63297867, 'Fernando', 'Muñoz', 'M', 400000),
(76543275, 'Raúl', 'Franco', 'M', 250000),
(98765434, 'Sergio', 'Gálvez', 'M', 500000);

-- --------------------------------------------------------

--
-- Table structure for table `estudiantes`
--

CREATE TABLE `estudiantes` (
  `Nro_ID` int(10) NOT NULL,
  `nombres` varchar(200) DEFAULT NULL,
  `apellidos` varchar(200) DEFAULT NULL,
  `direccion` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `facultad`
--

CREATE TABLE `facultad` (
  `numero` int(5) NOT NULL,
  `nombre_facultad` varchar(200) DEFAULT NULL,
  `ubicacion` varchar(200) DEFAULT NULL,
  `cedula_dec` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `facultad`
--

INSERT INTO `facultad` (`numero`, `nombre_facultad`, `ubicacion`, `cedula_dec`) VALUES
(1, 'MEDICINA', 'EDIFICIO 2 , PISO 1', '1002637181'),
(2, 'DEPORTES', 'EDIFICIO 3 , PISO 1', '1064933'),
(3, 'FISICA', 'EDIFICIO 2 , PISO 2', '1234234'),
(4, 'BELLAS ARTES', 'EDIFICIO 1 , PISO 1', '5373548'),
(5, 'ADSI', 'CENTRO', '1002637181'),
(6, 'QUIMICA', 'EDIFICIO 3 , PISO 2', '9585835');

-- --------------------------------------------------------

--
-- Table structure for table `inscripcion`
--

CREATE TABLE `inscripcion` (
  `Nro_inscripcion` int(20) NOT NULL,
  `codigo_asi2` varchar(20) DEFAULT NULL,
  `Nro_ID_est` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `libros`
--

CREATE TABLE `libros` (
  `codigo` int(11) NOT NULL,
  `titulo` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `libros`
--

INSERT INTO `libros` (`codigo`, `titulo`) VALUES
(1, 'la cama sin patas');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asignaturas`
--
ALTER TABLE `asignaturas`
  ADD PRIMARY KEY (`codigo`);

--
-- Indexes for table `curso`
--
ALTER TABLE `curso`
  ADD PRIMARY KEY (`Nro_ID`),
  ADD KEY `cedula_doc` (`cedula_doc`),
  ADD KEY `codigo_asi` (`codigo_asi`);

--
-- Indexes for table `decanos`
--
ALTER TABLE `decanos`
  ADD PRIMARY KEY (`cedula`);

--
-- Indexes for table `docentes`
--
ALTER TABLE `docentes`
  ADD PRIMARY KEY (`cedula`),
  ADD KEY `numero_fac` (`numero_fac`);

--
-- Indexes for table `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`cedula`);

--
-- Indexes for table `estudiantes`
--
ALTER TABLE `estudiantes`
  ADD PRIMARY KEY (`Nro_ID`);

--
-- Indexes for table `facultad`
--
ALTER TABLE `facultad`
  ADD PRIMARY KEY (`numero`),
  ADD KEY `cedula_dec` (`cedula_dec`);

--
-- Indexes for table `inscripcion`
--
ALTER TABLE `inscripcion`
  ADD PRIMARY KEY (`Nro_inscripcion`),
  ADD KEY `codigo_asi2` (`codigo_asi2`),
  ADD KEY `Nro_ID_est` (`Nro_ID_est`);

--
-- Indexes for table `libros`
--
ALTER TABLE `libros`
  ADD PRIMARY KEY (`codigo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `libros`
--
ALTER TABLE `libros`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `curso`
--
ALTER TABLE `curso`
  ADD CONSTRAINT `curso_ibfk_1` FOREIGN KEY (`cedula_doc`) REFERENCES `docentes` (`cedula`),
  ADD CONSTRAINT `curso_ibfk_2` FOREIGN KEY (`codigo_asi`) REFERENCES `asignaturas` (`codigo`);

--
-- Constraints for table `docentes`
--
ALTER TABLE `docentes`
  ADD CONSTRAINT `docentes_ibfk_1` FOREIGN KEY (`numero_fac`) REFERENCES `facultad` (`numero`);

--
-- Constraints for table `facultad`
--
ALTER TABLE `facultad`
  ADD CONSTRAINT `facultad_ibfk_1` FOREIGN KEY (`cedula_dec`) REFERENCES `decanos` (`cedula`);

--
-- Constraints for table `inscripcion`
--
ALTER TABLE `inscripcion`
  ADD CONSTRAINT `inscripcion_ibfk_1` FOREIGN KEY (`codigo_asi2`) REFERENCES `asignaturas` (`codigo`),
  ADD CONSTRAINT `inscripcion_ibfk_2` FOREIGN KEY (`Nro_ID_est`) REFERENCES `estudiantes` (`Nro_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
