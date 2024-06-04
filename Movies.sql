create database Movies

use Movies

CREATE TABLE Movies (
    Id INT PRIMARY KEY,
    Genero VARCHAR(255),
    Precio DECIMAL(10, 2),
    Lanzamiento DATE,
    Titulo VARCHAR(255)
);