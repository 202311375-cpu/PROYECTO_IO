--------------------------
------ SANGUCHON BD ------
--------------------------

CREATE DATABASE SANGUCHON_BD
USE SANGUCHON_BD

-- Tabla DEMANDA_MENSUAL
CREATE TABLE DEMANDA_MENSUAL (
    id_demanda INT PRIMARY KEY IDENTITY(1,1),
    id_tienda INT NOT NULL,
    mes INT NOT NULL, -- 1 = MES1, 2 = MES2, 3 = MES3
    id_producto INT NOT NULL,
    cantidad_demandada INT NOT NULL,
    FOREIGN KEY (id_tienda) REFERENCES TIENDA(id_tienda),
    FOREIGN KEY (id_producto) REFERENCES PRODUCTO(id_producto)
);

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

-- Tabla RESULTADO_MENSUAL
CREATE TABLE RESULTADO_MENSUAL (
    id_resultado INT PRIMARY KEY IDENTITY(1,1),
    id_tienda INT NOT NULL,
	mes INT NOT NULL,
    id_producto INT NOT NULL,
    cantidad_entregada INT NOT NULL,
    FOREIGN KEY (id_tienda) REFERENCES TIENDA(id_tienda),
    FOREIGN KEY (id_producto) REFERENCES PRODUCTO(id_producto)
);


----------------------------------------
------ PROCEDIMEINTOS ALMACENADOS ------
----------------------------------------

---- Insertar, Actualizar y Eliminar ... ---

-- Producto
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


-- Tienda
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

-- Demanda Mensual
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

-- Planificacion Mensual
CREATE PROCEDURE sp_PlanificacionMensual_CRUD
    @Operacion NVARCHAR(10),
    @id_planificacion INT = NULL,
    @mes INT = NULL,
    @id_producto INT = NULL,
    @id_tienda INT = NULL,
    @cantidad_planificada INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Operacion = 'INSERT'
        INSERT INTO PLANIFICACION_MENSUAL (mes, id_producto, id_tienda, cantidad_planificada)
        VALUES (@mes, @id_producto, @id_tienda, @cantidad_planificada);

    ELSE IF @Operacion = 'UPDATE'
        UPDATE PLANIFICACION_MENSUAL
        SET mes = @mes,
            id_producto = @id_producto,
            id_tienda = @id_tienda,
            cantidad_planificada = @cantidad_planificada
        WHERE id_planificacion = @id_planificacion;

    ELSE IF @Operacion = 'DELETE'
        DELETE FROM PLANIFICACION_MENSUAL
        WHERE id_planificacion = @id_planificacion;
END;


--------------------
------ VISTAS ------
--------------------

-- Vista de demanda mensual por tienda y producto
CREATE VIEW VistaDemandaMensual AS
SELECT 
    dm.id_demanda,
    t.nombre_tienda AS tienda,
	dm.mes,
    p.nombre_producto AS producto,
    dm.cantidad_demandada
FROM DEMANDA_MENSUAL dm
INNER JOIN TIENDA t ON dm.id_tienda = t.id_tienda
INNER JOIN PRODUCTO p ON dm.id_producto = p.id_producto;

-- Vista de planificacion mensual por tienda y producto
CREATE VIEW VistaPlanificacionMensual AS
SELECT
    pm.id_planificacion,
    t.nombre_tienda AS tienda,
    pm.mes,
    p.nombre_producto AS producto,
    pm.cantidad_planificada
FROM PLANIFICACION_MENSUAL pm
INNER JOIN TIENDA t ON pm.id_tienda = t.id_tienda
INNER JOIN PRODUCTO p ON pm.id_producto = p.id_producto;

-- Vista de resultados mensuales por tienda y producto
CREATE VIEW VistaResultadoMensual AS
SELECT 
    rm.id_resultado,
    t.nombre_tienda AS tienda,
	rm.mes,
    p.nombre_producto AS producto,
    rm.cantidad_entregada
FROM RESULTADO_MENSUAL rm
INNER JOIN TIENDA t ON rm.id_tienda = t.id_tienda
INNER JOIN PRODUCTO p ON rm.id_producto = p.id_producto;