-- Crear base de datos si no existe (válido solo para SQL Server)
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'AppTarata')
BEGIN
    CREATE DATABASE AppTarata;
END;
GO

-- Seleccionar la base de datos
USE AppTarata;
GO

-- Tabla Usuario
CREATE TABLE Usuario (
    idUsuario INT PRIMARY KEY IDENTITY(1,1),
    correo NVARCHAR(100) NOT NULL,
    clave NVARCHAR(100) NOT NULL
);

-- Tabla Rutas
CREATE TABLE Rutas (
    idRuta INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    Estado NVARCHAR(50)
);

-- Tabla DetalleRuta
CREATE TABLE DetalleRuta (
    idDetalleRuta INT PRIMARY KEY IDENTITY(1,1),
    fkidRuta INT,
    nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    costo DECIMAL(10, 2),
    Horario NVARCHAR(100),
    FOREIGN KEY (fkidRuta) REFERENCES Rutas(idRuta)
);



-- INSERT DE DATOS
-- Rutas
INSERT INTO Rutas (Nombre, Descripcion, Estado)
VALUES
('Senderismo', 'Senderismo por la montaña', '1'),
('Relax', 'Recorrido por la ciudad', '1'),
('Deportes Extremos', 'Ruta para ciclismo de montaña', '1');

--detallesrutas

INSERT INTO DetalleRuta(fkidRuta, nombre, Descripcion, costo, Horario)
VALUES
(1,'Mercado','El camino del inca...', '10','5:00 a 10:00pm'),
(1,'Templo San Benedicto','El camino del inca...', '10','5:00 a 10:00pm'),
(1,'Municipalidad de Tarata','El camino del inca...', '10','5:00 a 10:00pm'),
(2,'Camino inca','El camino del inca...', '10','5:00 a 10:00pm'),
(2,'Cueva de Qala','El camino del inca...', '10','5:00 a 10:00pm'),
(2,'Centro arqueologico','El camino del inca...', '10','5:00 a 10:00pm');