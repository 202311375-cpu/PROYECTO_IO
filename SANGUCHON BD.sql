-------------------------------------------------------------------
-- SANGUCHON BD
-------------------------------------------------------------------
CREATE DATABASE SANGUCHON_BD
USE SANGUCHON_BD

-- Tabla PRODUCTO
CREATE TABLE PRODUCTO (
    id_producto INT PRIMARY KEY IDENTITY(1,1),
    nombre_producto VARCHAR(100) NOT NULL,
    costo_unitario DECIMAL(10,2) NOT NULL,
    max_kilogramos INT NOT NULL
);

-- Tabla TIENDA
CREATE TABLE TIENDA (
    id_tienda INT PRIMARY KEY IDENTITY(1,1),
    nombre_tienda VARCHAR(50) NOT NULL,
    volumen INT NOT NULL,
    inventario_inicial INT NOT NULL,
    area_despensa INT NOT NULL
);

-- Tabla DEMANDA_MENSUAL
CREATE TABLE DEMANDA_MENSUAL (
    id_demanda INT PRIMARY KEY IDENTITY(1,1),
    id_tienda INT NOT NULL,
    id_producto INT NOT NULL,
    mes INT NOT NULL, -- 1 = MES1, 2 = MES2, 3 = MES3
    cantidad_demandada INT NOT NULL,
    FOREIGN KEY (id_tienda) REFERENCES TIENDA(id_tienda),
    FOREIGN KEY (id_producto) REFERENCES PRODUCTO(id_producto)
);

-- Tabla RESULTADO_MENSUAL
CREATE TABLE RESULTADO_MENSUAL (
    id_resultado INT PRIMARY KEY IDENTITY(1,1),
    id_tienda INT NOT NULL,
    id_producto INT NOT NULL,
    mes INT NOT NULL,
    cantidad_entregada INT NOT NULL,
    FOREIGN KEY (id_tienda) REFERENCES TIENDA(id_tienda),
    FOREIGN KEY (id_producto) REFERENCES PRODUCTO(id_producto)
);

--Tabla PLANIFICACION_MENSUAL
CREATE TABLE PLANIFICACION_MENSUAL (
    id_planificacion INT PRIMARY KEY IDENTITY(1,1),
    mes INT NOT NULL, -- 1 = MES1, 2 = MES2, 3 = MES3
    id_producto INT NOT NULL,
    id_tienda INT NOT NULL,
    cantidad_planificada INT NOT NULL,
    FOREIGN KEY (id_producto) REFERENCES PRODUCTO(id_producto),
    FOREIGN KEY (id_tienda) REFERENCES TIENDA(id_tienda)
);


--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------

CREATE PROCEDURE sp_Producto_CRUD
    @Operacion NVARCHAR(10),
    @id_producto INT = NULL,
    @nombre_producto NVARCHAR(100) = NULL,
    @costo_unitario DECIMAL(10,2) = NULL,
    @max_kilogramos INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Operacion = 'INSERT'
        INSERT INTO PRODUCTO (nombre_producto, costo_unitario, max_kilogramos)
        VALUES (@nombre_producto, @costo_unitario, @max_kilogramos);

    ELSE IF @Operacion = 'UPDATE'
        UPDATE PRODUCTO
        SET nombre_producto = @nombre_producto,
            costo_unitario = @costo_unitario,
            max_kilogramos = @max_kilogramos
        WHERE id_producto = @id_producto;

    ELSE IF @Operacion = 'DELETE'
        DELETE FROM PRODUCTO WHERE id_producto = @id_producto;
END;

--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------

CREATE PROCEDURE sp_Tienda_CRUD
    @Operacion NVARCHAR(10),
    @id_tienda INT = NULL,
    @nombre_tienda NVARCHAR(50) = NULL,
    @volumen INT = NULL,
    @inventario_inicial INT = NULL,
    @area_despensa INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Operacion = 'INSERT'
        INSERT INTO TIENDA (nombre_tienda, volumen, inventario_inicial, area_despensa)
        VALUES (@nombre_tienda, @volumen, @inventario_inicial, @area_despensa);

    ELSE IF @Operacion = 'UPDATE'
        UPDATE TIENDA
        SET nombre_tienda = @nombre_tienda,
            volumen = @volumen,
            inventario_inicial = @inventario_inicial,
            area_despensa = @area_despensa
        WHERE id_tienda = @id_tienda;

    ELSE IF @Operacion = 'DELETE'
        DELETE FROM TIENDA WHERE id_tienda = @id_tienda;
END;

--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------

CREATE PROCEDURE sp_DemandaMensual_CRUD
    @Operacion NVARCHAR(10),
    @id_demanda INT = NULL,
    @id_tienda INT = NULL,
    @id_producto INT = NULL,
    @mes INT = NULL,
    @cantidad_demandada INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Operacion = 'INSERT'
        INSERT INTO DEMANDA_MENSUAL (id_tienda, id_producto, mes, cantidad_demandada)
        VALUES (@id_tienda, @id_producto, @mes, @cantidad_demandada);

    ELSE IF @Operacion = 'UPDATE'
        UPDATE DEMANDA_MENSUAL
        SET id_tienda = @id_tienda,
            id_producto = @id_producto,
            mes = @mes,
            cantidad_demandada = @cantidad_demandada
        WHERE id_demanda = @id_demanda;

    ELSE IF @Operacion = 'DELETE'
        DELETE FROM DEMANDA_MENSUAL WHERE id_demanda = @id_demanda;
END;



--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------

CREATE PROCEDURE sp_ResultadoMensual_CRUD
    @Operacion NVARCHAR(10),
    @id_resultado INT = NULL,
    @id_tienda INT = NULL,
    @id_producto INT = NULL,
    @mes INT = NULL,
    @cantidad_entregada INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Operacion = 'INSERT'
        INSERT INTO RESULTADO_MENSUAL (id_tienda, id_producto, mes, cantidad_entregada)
        VALUES (@id_tienda, @id_producto, @mes, @cantidad_entregada);

    ELSE IF @Operacion = 'UPDATE'
        UPDATE RESULTADO_MENSUAL
        SET id_tienda = @id_tienda,
            id_producto = @id_producto,
            mes = @mes,
            cantidad_entregada = @cantidad_entregada
        WHERE id_resultado = @id_resultado;

    ELSE IF @Operacion = 'DELETE'
        DELETE FROM RESULTADO_MENSUAL WHERE id_resultado = @id_resultado;
END;



--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------

--Vista de demanda mensual por tienda y producto
CREATE VIEW VistaDemandaMensual AS
SELECT 
    dm.id_demanda,
    t.nombre_tienda AS tienda,
    p.nombre_producto AS producto,
    dm.mes,
    dm.cantidad_demandada
FROM DEMANDA_MENSUAL dm
INNER JOIN TIENDA t ON dm.id_tienda = t.id_tienda
INNER JOIN PRODUCTO p ON dm.id_producto = p.id_producto;



--Vista de resultados mensuales por tienda y producto
CREATE VIEW VistaResultadoMensual AS
SELECT 
    rm.id_resultado,
    t.nombre_tienda AS tienda,
    p.nombre_producto AS producto,
    rm.mes,
    rm.cantidad_entregada
FROM RESULTADO_MENSUAL rm
INNER JOIN TIENDA t ON rm.id_tienda = t.id_tienda
INNER JOIN PRODUCTO p ON rm.id_producto = p.id_producto;



--------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------

--insertar datos por tabla productos
INSERT INTO PRODUCTO (nombre_producto, costo_unitario, max_kilogramos) VALUES
('Pan Integral', 12.00, 4800),
('Jamón', 18.00, 3200),
('Lechuga', 9.00, 2500),
('Pollo', 45.00, 2500),
('Jugo Naranja', 15.00, 3000);


--insertar datos por tabla tienda
INSERT INTO TIENDA (nombre_tienda, volumen, inventario_inicial, area_despensa) VALUES
('PS1', 450, 200, 115000),
('PS2', 650, 300, 155000),
('PS3', 350, 180, 95000),
('PS4', 520, 220, 80000),
('PS5', 250, 210, 60000);


--insertar datos por tabla PLANIFICACION_MENSUAL PARA MES 1 MES 2 MES 3

-- MES1
INSERT INTO PLANIFICACION_MENSUAL (mes, id_producto, id_tienda, cantidad_planificada) VALUES
(1, 1, 1, 300), (1, 1, 2, 280), (1, 1, 3, 230), (1, 1, 4, 240), (1, 1, 5, 220),
(1, 2, 1, 280), (1, 2, 2, 260), (1, 2, 3, 240), (1, 2, 4, 230), (1, 2, 5, 210),
(1, 3, 1, 200), (1, 3, 2, 190), (1, 3, 3, 160), (1, 3, 4, 180), (1, 3, 5, 150),
(1, 4, 1, 180), (1, 4, 2, 160), (1, 4, 3, 150), (1, 4, 4, 140), (1, 4, 5, 130),
(1, 5, 1, 260), (1, 5, 2, 240), (1, 5, 3, 230), (1, 5, 4, 220), (1, 5, 5, 210);

-- MES2
INSERT INTO PLANIFICACION_MENSUAL (mes, id_producto, id_tienda, cantidad_planificada) VALUES
(2, 1, 1, 320), (2, 1, 2, 300), (2, 1, 3, 260), (2, 1, 4, 280), (2, 1, 5, 240),
(2, 2, 1, 300), (2, 2, 2, 280), (2, 2, 3, 260), (2, 2, 4, 240), (2, 2, 5, 210),
(2, 3, 1, 210), (2, 3, 2, 200), (2, 3, 3, 170), (2, 3, 4, 190), (2, 3, 5, 160),
(2, 4, 1, 200), (2, 4, 2, 180), (2, 4, 3, 160), (2, 4, 4, 150), (2, 4, 5, 140),
(2, 5, 1, 280), (2, 5, 2, 260), (2, 5, 3, 240), (2, 5, 4, 230), (2, 5, 5, 220);

-- MES3
INSERT INTO PLANIFICACION_MENSUAL (mes, id_producto, id_tienda, cantidad_planificada) VALUES
(3, 1, 1, 340), (3, 1, 2, 320), (3, 1, 3, 280), (3, 1, 4, 300), (3, 1, 5, 260),
(3, 2, 1, 320), (3, 2, 2, 300), (3, 2, 3, 280), (3, 2, 4, 260), (3, 2, 5, 230),
(3, 3, 1, 220), (3, 3, 2, 210), (3, 3, 3, 180), (3, 3, 4, 200), (3, 3, 5, 170),
(3, 4, 1, 210), (3, 4, 2, 190), (3, 4, 3, 170), (3, 4, 4, 160), (3, 4, 5, 150),
(3, 5, 1, 300), (3, 5, 2, 280), (3, 5, 3, 260), (3, 5, 4, 250), (3, 5, 5, 240);


--insertar datos por tabla DEMANDA MES 1 MES 2 MES 3 

-- MES1
INSERT INTO DEMANDA_MENSUAL (id_tienda, id_producto, mes, cantidad_demandada) VALUES
(1, 1, 1, 300), (1, 2, 1, 280), (1, 3, 1, 200), (1, 4, 1, 180), (1, 5, 1, 260),
(2, 1, 1, 280), (2, 2, 1, 260), (2, 3, 1, 190), (2, 4, 1, 160), (2, 5, 1, 240),
(3, 1, 1, 230), (3, 2, 1, 240), (3, 3, 1, 160), (3, 4, 1, 150), (3, 5, 1, 230),
(4, 1, 1, 240), (4, 2, 1, 230), (4, 3, 1, 180), (4, 4, 1, 140), (4, 5, 1, 220),
(5, 1, 1, 220), (5, 2, 1, 210), (5, 3, 1, 150), (5, 4, 1, 130), (5, 5, 1, 210);

-- MES2
INSERT INTO DEMANDA_MENSUAL (id_tienda, id_producto, mes, cantidad_demandada) VALUES
(1, 1, 2, 920), (1, 2, 2, 500), (1, 3, 2, 550), (1, 4, 2, 2800), (1, 5, 2, 350),
(2, 1, 2, 800), (2, 2, 2, 320), (2, 3, 2, 400), (2, 4, 2, 2500), (2, 5, 2, 420),
(3, 1, 2, 870), (3, 2, 2, 450), (3, 3, 2, 230), (3, 4, 2, 3100), (3, 5, 2, 290),
(4, 1, 2, 830), (4, 2, 2, 230), (4, 3, 2, 230), (4, 4, 2, 3050), (4, 5, 2, 360),
(5, 1, 2, 940), (5, 2, 2, 410), (5, 3, 2, 610), (5, 4, 2, 2950), (5, 5, 2, 310);

-- MES3
INSERT INTO DEMANDA_MENSUAL (id_tienda, id_producto, mes, cantidad_demandada) VALUES
(1, 1, 3, 1100), (1, 2, 3, 1200), (1, 3, 3, 900), (1, 4, 3, 3500), (1, 5, 3, 450),
(2, 1, 3, 950), (2, 2, 3, 600), (2, 3, 3, 500), (2, 4, 3, 3200), (2, 5, 3, 400),
(3, 1, 3, 9500), (3, 2, 3, 6800), (3, 3, 3, 2900), (3, 4, 3, 3800), (3, 5, 3, 4600),
(4, 1, 3, 970), (4, 2, 3, 490), (4, 3, 3, 420), (4, 4, 3, 3900), (4, 5, 3, 400),
(5, 1, 3, 520), (5, 2, 3, 650), (5, 3, 3, 780), (5, 4, 3, 1150), (5, 5, 3, 470);

