-- Dashboard, Gráficos 

-- Crear un procedimiento almacenado llamado dash
DELIMITER //
CREATE PROCEDURE Dashboard(
    OUT nlocal INT,
    OUT nmuni INT,
    OUT nvivi INT,
    OUT nhab INT,
    OUT nact INT,
    OUT nusu INT
)
BEGIN
    SELECT COUNT(ID_Localidad) INTO nlocal FROM localidades;
    SELECT COUNT(ID_Municipio) INTO nmuni FROM municipios;
    SELECT COUNT(ID_Vivienda) INTO nvivi FROM vivienda;
    SELECT COUNT(ID_Habitante) INTO nhab FROM habitante;
    SELECT COUNT(ID_Actividad) INTO nact FROM actividadEconomica;
    SELECT COUNT(ID_Usuario) INTO nusu FROM usuario;
END //
DELIMITER ;

-- Promedio de habitantes por vivienda. (2 VIVIENDAS)
DELIMITER //
CREATE PROCEDURE HabiVivienda()
BEGIN
    SELECT CONCAT(V.TIPO, ' ', L.Nombre, ' ', M.Nombre) AS Vivienda, COUNT(H.ID_Vivienda) as People 
    FROM habitante as H
    Inner join Vivienda as V on V.ID_Vivienda = H.ID_Vivienda
    Inner join localidades as L on L.ID_Localidad = V.ID_Localidad
    INNER JOIN municipios as M on M.ID_Municipio = L.ID_Municipio
    GROUP BY H.ID_Vivienda, V.TIPO, L.Nombre, M.Nombre
    ORDER BY COUNT(H.ID_Vivienda) DESC LIMIT 3;
END //
DELIMITER ;

-- Cantidad de actividades económicas por Vivenda. (2 VIVIENDAS)
DELIMITER //
CREATE PROCEDURE ActiVivienda()
BEGIN
    SELECT CONCAT(V.Tipo, ' ', L.Nombre, ' ', M.Nombre) AS Vivienda, COUNT(VA.ID_Actividad) as Num_Actividades_Economicas
    FROM Vivienda V
    LEFT JOIN ViviendaActividad VA ON V.ID_Vivienda = VA.ID_Vivienda
    INNER JOIN Localidades L ON V.ID_Localidad = L.ID_Localidad
    INNER JOIN Municipios M ON L.ID_Municipio = M.ID_Municipio
    GROUP BY V.ID_Vivienda, V.Tipo, L.Nombre, M.Nombre
    ORDER BY V.ID_Vivienda;
END //
DELIMITER ;