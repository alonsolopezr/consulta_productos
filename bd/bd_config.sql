CREATE DATABASE productos_pdv;

use productos_pdv;

CREATE TABLE `productos` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `codigo_barras` varchar(20) NOT NULL,
  `descripcion` text DEFAULT NULL,
  `precio` double NOT NULL,
  `imagen` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `nombre`, `codigo_barras`, `descripcion`, `precio`, `imagen`) VALUES
(1, 'Maruchan Habanero Rebelde', '123123123', 'Maruchan limón camarón habanero', 16.5, '123123');


CREATE TABLE usuarios (id int primary key auto_increment, nombre varchar(200), password varchar(100), correo varchar(255), foto varchar(255) );