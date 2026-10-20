-- =====================================================
-- Proyecto Final ISB-13 Programación II
-- Sistema de control de parqueo
-- Script de creación de la base de datos
-- =====================================================

-- 1. Crear la base de datos (si no existe)
IF DB_ID('Parqueo') IS NULL
    CREATE DATABASE Parqueo;
GO

USE Parqueo;
GO

-- 2. Borrar tablas si ya existen (en orden por las llaves foráneas)
IF OBJECT_ID('Registro') IS NOT NULL DROP TABLE Registro;
IF OBJECT_ID('Vehiculo') IS NOT NULL DROP TABLE Vehiculo;
IF OBJECT_ID('Espacio') IS NOT NULL DROP TABLE Espacio;
IF OBJECT_ID('Cliente') IS NOT NULL DROP TABLE Cliente;
GO

-- 3. Tabla Cliente
CREATE TABLE Cliente (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    Cedula VARCHAR(15) NOT NULL UNIQUE,
    Nombre VARCHAR(80) NOT NULL,
    Telefono VARCHAR(15) NOT NULL
);
GO

-- 4. Tabla Vehiculo (un cliente puede tener varios vehículos)
CREATE TABLE Vehiculo (
    IdVehiculo INT IDENTITY(1,1) PRIMARY KEY,
    Placa VARCHAR(10) NOT NULL UNIQUE,
    Tipo VARCHAR(10) NOT NULL CHECK (Tipo IN ('Carro', 'Moto')),
    Marca VARCHAR(40) NOT NULL,
    Color VARCHAR(30) NOT NULL,
    IdCliente INT NOT NULL,
    FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente)
);
GO

-- 5. Tabla Espacio
CREATE TABLE Espacio (
    IdEspacio INT IDENTITY(1,1) PRIMARY KEY,
    Numero INT NOT NULL UNIQUE,
    TipoVehiculo VARCHAR(10) NOT NULL CHECK (TipoVehiculo IN ('Carro', 'Moto')),
    Estado VARCHAR(12) NOT NULL DEFAULT 'Disponible'
        CHECK (Estado IN ('Disponible', 'Ocupado'))
);
GO

-- 6. Tabla Registro (entradas y salidas)
-- Si HoraSalida es NULL, el vehículo todavía está dentro del parqueo
CREATE TABLE Registro (
    IdRegistro INT IDENTITY(1,1) PRIMARY KEY,
    IdVehiculo INT NOT NULL,
    IdEspacio INT NOT NULL,
    HoraEntrada DATETIME NOT NULL DEFAULT GETDATE(),
    HoraSalida DATETIME NULL,
    MontoPagado DECIMAL(10,2) NULL,
    FOREIGN KEY (IdVehiculo) REFERENCES Vehiculo(IdVehiculo),
    FOREIGN KEY (IdEspacio) REFERENCES Espacio(IdEspacio)
);
GO

-- =====================================================
-- DATOS DE PRUEBA
-- =====================================================

INSERT INTO Cliente (Cedula, Nombre, Telefono) VALUES
('1-1234-5678', 'María Rodríguez Mora', '8888-1111'),
('2-0456-0789', 'Carlos Jiménez Solano', '8777-2222'),
('3-0321-0654', 'Ana Vargas Soto', '8666-3333'),
('1-0987-0123', 'Luis Fernández Rojas', '8555-4444');
GO

INSERT INTO Vehiculo (Placa, Tipo, Marca, Color, IdCliente) VALUES
('ABC123', 'Carro', 'Toyota', 'Rojo', 1),
('BCD456', 'Carro', 'Hyundai', 'Blanco', 2),
('MOT789', 'Moto', 'Honda', 'Negro', 2),
('CDE321', 'Carro', 'Nissan', 'Gris', 3),
('MOT456', 'Moto', 'Yamaha', 'Azul', 4),
('DEF654', 'Carro', 'Kia', 'Negro', 4);
GO

-- Espacios 1 al 6 son para carros y del 7 al 10 para motos
INSERT INTO Espacio (Numero, TipoVehiculo, Estado) VALUES
(1, 'Carro', 'Ocupado'),
(2, 'Carro', 'Disponible'),
(3, 'Carro', 'Disponible'),
(4, 'Carro', 'Disponible'),
(5, 'Carro', 'Disponible'),
(6, 'Carro', 'Disponible'),
(7, 'Moto', 'Ocupado'),
(8, 'Moto', 'Disponible'),
(9, 'Moto', 'Disponible'),
(10, 'Moto', 'Disponible');
GO

-- Registros finalizados (con hora de salida y monto)
INSERT INTO Registro (IdVehiculo, IdEspacio, HoraEntrada, HoraSalida, MontoPagado) VALUES
(2, 2, '2026-10-18 09:00', '2026-10-18 11:30', 3000),
(4, 3, '2026-10-18 13:15', '2026-10-18 14:00', 1000),
(5, 8, '2026-10-18 10:00', '2026-10-18 12:00', 1000);
GO

-- Registros activos (el vehículo sigue dentro, sin salida ni monto)
INSERT INTO Registro (IdVehiculo, IdEspacio, HoraEntrada) VALUES
(1, 1, '2026-10-19 08:00'),
(3, 7, '2026-10-19 07:30');
GO

-- =====================================================
-- CONSULTA DE PRUEBA: vehículos que están dentro del parqueo
-- =====================================================
SELECT r.IdRegistro, v.Placa, v.Tipo, c.Nombre AS Cliente,
       e.Numero AS Espacio, r.HoraEntrada
FROM Registro r
INNER JOIN Vehiculo v ON r.IdVehiculo = v.IdVehiculo
INNER JOIN Cliente c ON v.IdCliente = c.IdCliente
INNER JOIN Espacio e ON r.IdEspacio = e.IdEspacio
WHERE r.HoraSalida IS NULL;
GO
