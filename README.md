# TP1_IS
## Ejercicio 1) 
* ¿Puedes identificar pruebas de unidad y de integración en la práctica que realizaste?

Puedo distinguir pruebas unitarias en la practica realizada pero no pruebas de integracion ya que en todos los casos de prueba solo verifico que sea correcto el funcionamiento de una sola clase, ya sea Producto o Tienda.

## Ejercicio 2)
* Podría haber escrito las pruebas primero antes de modificar el código de la aplicación? ¿Cómo sería el proceso de escribir primero los tests?

Sí podría haber escrito primero las pruebas antes de modificar el codigo. 

El proceso sería el siguiente: 
- escribo las pruebas 
- ejecuto el test
- las pruebas no se van a superar ya que todavia no está implementado el codigo
- modifico el codigo
- ejecuto el test nuevamente para corroborar que el codigo agregado supera las pruebas

## Ejercicio 3)
* En lo que va del trabajo práctico, ¿puedes identificar 'Controladores' y 'Resguardos'?

La clase **Tienda** podria considerarse como un 'controlador' ya que es la que coordina todas las acciones del sistema. En el caso de los 'resguardos', se podria decir que el mock de **Producto** entra en esa categoria.


* ¿Qué es un mock? ¿Hay otros nombres para los objetos/funciones simulados?

Los **mocks** son objetos preprogramados con expectativas que conforman la especificación de lo que se espera que reciban las llamadas, es decir, son objetos que se usan para probar que se realizan correctamente llamadas a otros métodos. Se utilizan para verificar el comportamiento de una unidad bajo prueba (como una clase o método), sin depender de implementaciones reales que pueden ser costosas, complejas, o que involucran interacciones externas.

Otros nombres para los objetos simulados son: stub, dummy, fake, spy. Son distintos tipos de objetos simulados que se pueden usar dependiendo de lo que se requiera.

## Ejercicio 4)
* ¿Qué ventajas ve en el uso de fixtures? ¿Qué enfoque estaría aplicando?

El uso de fixtures nos proporciona varias ventajas como la reutilización de codigo, consistencia en las pruebas y un mayor rendimiento ya que el fixture se inicializa una única vez durante el periodo de pruebas y no hay que inicializar una misma dependencia en cada prueba que se ejecuta.

Se podría decir que se aplica un enfoque "global" ya que se utiliza una instancia de la clase Tienda para todas las pruebas para mantener la consistencia entre estas.

* Explique los conceptos de Setup y Teardown en testing.

- Setup: Es el proceso de preparar el entorno antes de la ejecución de cada prueba o conjunto de pruebas. Se utiliza para inicializar las dependencias que cada prueba necesita.
- Teardown: Es el proceso de limpieza del entorno de pruebas después de que se haya ejecutado una prueba o conjunto de pruebas. Se utiliza para liberar recursos que fueron utilizados durante la prueba.