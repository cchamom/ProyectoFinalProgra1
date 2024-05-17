create database Usuarios
use Usuarios

CREATE TABLE Usuario
(
    Id_Usuarios int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Nombre varchar(50) NULL,
    Usuario varchar(50) NULL,
    Contraseña varchar(50) NULL,
    Tipo_Usuario varchar(50) NULL
);

INSERT INTO Usuarios (Nombre, Usuario, Contraseña, Tipo_Usuario) VALUES
('Juan Pérez', 'juanperez', 'password123', 'Médico'),
('María García', 'mariagarcia', 'abc456', 'Enfermera'),
('Carlos López', 'carloslopez', 'qwerty', 'Administrativo');

SELECT Usuario, Nombre, Usuario, Contraseña From Usuarios

CREATE TABLE PASIENTES
(
    Nombre_Pasiente varchar(50) Null,
	Sexo varchar(50),
	Edad int Not null,
	Telefono int not null,
	Direccion varchar(150) null,
	Email varchar(100) null,
); 

INSERT INTO pasientes(Nombre_Pasiente, Sexo, Edad, Telefono, Direccion,Email) VALUES
('Maria Jose Rivas Aguilar', 'Femenino', '24', '34239056', 'Jalapa, Jalapa, calle principal', 'majorivas@gmail.com1'),
('Jose Alejandro Morales Gutierrez', 'Masculino','30', '34290548', 'Coliz, calle principal', 'josealejmorales@gmail.com');

 



