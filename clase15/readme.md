El colectivo realiza un recorrido todos los dí as y pasa por diferentes paradas y tiene la
ma quina que es para cobrar el boleto. El monto puede ser $50, $75 o $100. Cuando va a
cobrar, aplica de forma aleatoria uno de los 3 importes.
Cada pasajero habitual tiene su tarjeta con un monto asignado y realiza el pago de acuerdo
con el importe que le indique el colectivero. Actualmente el monto negativo es de $200, si
no puede abonar, debe informar que tiene saldo insuficiente, caso contrario indique cua l es
el saldo actual. Adema s, conoce el u ltimo cobro que le hicieron.
Existen tambie n los estudiantes, que, a diferencia del pasajero habitual, pagan un boleto de
$10, no importa el importe que indique la ma quina.
Importante: El colectivo tiene registro de ambos tipos de pasajeros en listas diferentes.
Resolver:
1. (2 puntos) Diagrama de clases.
2. (3 puntos) Crear el colectivo y 10 pasajeros comunes y 10 estudiantes con montos
iniciales de $50 que se encuentran en una parada.
a. Generar un cobro a cada pasajero (realice el cobro a todos en un u nico
me todo). Considere a los estudiantes y realice los cobros.
b. Sube el inspector y le pregunta al chofer cua nto tiene recaudado, por lo que
debe responder a esa pregunta.

3. (2 puntos) Registrar en una tabla los cobros realizados a los pasajeros comunes y a
estudiantes.
4. (3 puntos) Unificar en una tercera lista y mostrar el listado ordenado por monto.
Tambie n el total de los montos.
Nota:
Considere los atributos que sean solo visibles dentro de la clase o sus dependientes.
Aplique correctamente el concepto de responsabilidad de las clases.
En el Main incluya instancias y llamados a métodos.
Limpiar el user y password de la cadena de conexión.
Recursos SQL:
create table Cobros
(
tipo varchar(1),
monto int
)
insert into Cobros values (@tipo, @monto)

Tipo: ‘E’ es estudiante, ‘C’ es comu n. Monto es del u ltimo monto cobrado siempre que haya
sido factible.