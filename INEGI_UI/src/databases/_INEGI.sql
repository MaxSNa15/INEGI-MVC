CREATE DATABASE CensoPoblacion;

USE CensoPoblacion;

-- Permisos para el usuario root
GRANT EXECUTE ON CensoPoblacion.* TO 'root'@'localhost';
FLUSH PRIVILEGES;

-- Tabla Municipios
CREATE TABLE Municipios (
    ID_Municipio INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    Region VARCHAR(255) NOT NULL,
    Poblacion2020 INT NOT NULL
);

-- Tabla Localidades
CREATE TABLE Localidades (
    ID_Localidad INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    ID_Municipio INT,
    FOREIGN KEY (ID_Municipio) REFERENCES Municipios(ID_Municipio)
);

-- Tabla Vivienda
CREATE TABLE Vivienda (
    ID_Vivienda INT AUTO_INCREMENT PRIMARY KEY,
    Direccion VARCHAR(255) NOT NULL,
    Tipo ENUM('concreto', 'adobe antiguo', 'ladrillo', 'madera', 'cartón', 'piedra', 'prefabricada', 'material ecológico', 'paja/ramas/caña', 'adobe moderno') NOT NULL,
    ID_Localidad INT,
    FOREIGN KEY (ID_Localidad) REFERENCES Localidades(ID_Localidad)
);

-- Tabla Habitante
CREATE TABLE Habitante (
    ID_Habitante INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Genero ENUM('Masculino', 'Femenino', 'Otro') NOT NULL,
    ID_Vivienda INT,
    FOREIGN KEY (ID_Vivienda) REFERENCES Vivienda(ID_Vivienda)
);

-- Tabla ActividadEconomica
CREATE TABLE ActividadEconomica (
    ID_Actividad INT AUTO_INCREMENT PRIMARY KEY,
    Descripcion VARCHAR(255) NOT NULL
);

-- Tabla ViviendaActividad (relación muchos a muchos entre Vivienda y ActividadEconomica)
CREATE TABLE ViviendaActividad (
    ID_Vivienda INT,
    ID_Actividad INT,
    PRIMARY KEY (ID_Vivienda, ID_Actividad),
    FOREIGN KEY (ID_Vivienda) REFERENCES Vivienda(ID_Vivienda),
    FOREIGN KEY (ID_Actividad) REFERENCES ActividadEconomica(ID_Actividad)
);

-- Tabla Usuario
CREATE TABLE Usuario (
    ID_Usuario INT AUTO_INCREMENT PRIMARY KEY,
    Nickname VARCHAR(255) NOT NULL,
    Contrasena VARCHAR(255) NOT NULL,
    FIRSTNAME VARCHAR(255),
    LASTNAME VARCHAR(255)
);

INSERT INTO Usuario (Nickname, Contrasena, FIRSTNAME, LASTNAME) VALUES ('admin', 'admin', 'Administrador', 'Principal');