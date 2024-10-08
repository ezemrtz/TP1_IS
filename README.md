# TP1_IS 

## Integrantes:  

* Albarracín William Fernando 
* Díaz Álvaro Augusto 
* González Ley Ignacio 
* Martinez Ezequiel 

## Ejercicio 1)  
* ¿Puedes identificar **pruebas de unidad y de integración** en la práctica que realizaste? 

En la práctica realizada se pueden ver **pruebas de unidad** ya que se prueban funcionalidades básicas de las clases producto y tienda. En cuanto a las **pruebas de integración** se puede considerar las pruebas realizadas para controlar el funcionamiento de la clase producto con la clase tienda, a pesar de que la dependencia no sea de gran complejidad. 

## Ejercicio 2) 
* Podría haber escrito las pruebas primero antes de modificar el código de la aplicación? ¿Cómo sería el proceso de escribir primero los tests? 

Sí podría haber escrito primero las pruebas antes de modificar el código. Este proceso se denomina **desarrollo guiado por pruebas** o por sus siglas en ingles **(TDD, Test Driven Development)**.
El proceso sería el siguiente:  

1. Escribo las pruebas.
2. Ejecuto el test.
3. Las pruebas no se van a superar ya que todavía no está implementado el código.
4. Implemento el código.
5. Ejecuto el test nuevamente para corroborar que el código agregado supera las pruebas.
6. Refactorizo el código con el propócito de mejorar la estructura y legibilidad del código.

## Ejercicio 3) 
* En lo que va del trabajo práctico, ¿puedes identificar **Controladores** y **Resguardos**? 

No pudimos identificar controladores en lo que va del practico, pero sí se identifican resguardos, los cuales serían los mocks de 'Producto' utilizados para realizar este ejercicio. 

* ¿Qué es un **mock**? ¿Hay otros nombres para los objetos/funciones simulados? 

Los **mocks** son objetos preprogramados con expectativas que conforman la especificación de lo que se espera que reciban las llamadas, es decir, son objetos que se usan para probar que se realizan correctamente llamadas a otros métodos. Se utilizan para verificar el comportamiento de una unidad bajo prueba (como una clase o método), sin depender de implementaciones reales que pueden ser costosas, complejas, o que involucran interacciones externas. 

Otros nombres para los objetos simulados son: stub, dummy, fake, spy. Son distintos tipos de objetos simulados que se pueden usar dependiendo de lo que se requiera. 

* Stubs: Objetos simulados que solo devuelven valores predeterminados, no tienen una logica interna. 
* Fakes: Objetos simulados que tiene una logica simplificada de la logica real implementada. 
* Spies: Objetos simulados que tienen la capacidad de registrar cuando son llamados, registrando de esta manera las interacciones con el mismo.

## Ejercicio 4) 
* ¿Qué ventajas ve en el uso de **fixtures**? ¿Qué enfoque estaría aplicando? 

Los **fixtures** son escenarios configurados para la ejecucion de pruebas, este contiene el conjunto de pruebas iniciales, datos de prueba y objetos necesarios para que las pruebas puedan se ejecutadas.
El uso de fixtures nos proporciona varias ventajas como la reutilización de código, consistencia en las pruebas y un mayor rendimiento ya que el fixture se inicializa una única vez durante el periodo de pruebas y no hay que inicializar una misma dependencia en cada prueba que se ejecuta. 

Se podría decir que se aplica un enfoque de "**caja negra**" porque los datos no se inicializan con características específicas para evaluar el comportamiento interno de las clases o métodos. En cambio, se utilizan como entradas en las pruebas para facilitar la validación de las funcionalidades de la tienda sin tener en cuenta los detalles de implementación. 

* Explique los conceptos de **Setup** y **Teardown** en testing. 

- Setup: Es el proceso de preparar el entorno antes de la ejecución de cada prueba o conjunto de pruebas. Se utiliza para inicializar las dependencias que cada prueba necesita. 

- Teardown: Es el proceso de limpieza del entorno de pruebas después de que se haya ejecutado una prueba o conjunto de pruebas. Se utiliza para liberar recursos que fueron utilizados durante la prueba. 

## Ejercicio 5) 
* ¿Puede describir una situación de desarrollo para este caso en donde se plantee pruebas de integración ascendente? Describa la situación. 

En el desarrollo del trabajo practico se llevó a cabo una prueba de integración ascendente con la prueba de calcular_total_carrito ya que, en primer lugar, se hicieron las pruebas unitarias de los módulos más pequeños del sistema como lo son agregar_producto, buscar_producto. Una vez que esos módulos se probaron y se verificó su correcto funcionamiento, se procedió a hacer la prueba de calcular_total_carrito en donde se integran esos módulos más pequeños y se verifica el funcionamiento del sistema desde un módulo más abarcativo. 