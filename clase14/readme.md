El colegio tiene varios alumnos. De cada alumno se conoce su legajo (secuencial 1 a n),
calificacio n (aleatorio 1 a 10), su altura (aleatorio entre 150 y 180) y puede saludar. Adema s,
dice si aprobo o no (el colegio define el criterio, es decir, nota mí nima para aprobar).
Hay dos tipos de colegios. El que ordena en fila a sus alumnos de forma decreciente y el que
lo hace de forma decreciente.

Cada manñana el colegio los hace formar fila y les pide a todos que saluden.

1. (2 puntos) Diagrama de clases.
2. (3 puntos) Incorporar 10 alumnos. El colegio pide que cada alumno salude. Adema s,
obtener el promedio de su calificacio n, la nota ma s baja y la ma s alta. Listar los datos
de los alumnos y si aprobo o no.
3. (2 puntos) El colegio debe poner a los alumnos en orden segu n su altura. Listar por
pantalla los resultados. Mostrar el funcionamiento de ordenamiento para ambas
instituciones.
4. (3 puntos) Registrar los datos de los alumnos en la base de datos. Luego buscar los
valores y mostrar los resultados por pantalla.

Nota:
Considere los atributos que sean solo visibles dentro de la clase o sus dependientes.
Aplique correctamente el concepto de responsabilidad de las clases.
En el Main incluya instancias y llamados a métodos.
Limpiar el user y password de la cadena de conexión.


Recursos SQL:

create table Alumnos
(
legajo int,
calificacion int,
altura int
)