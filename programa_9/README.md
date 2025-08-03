
## Programa 9: Vazamento de Memória

### Descrição do Problema
Este programa aloca continuamente blocos de memória em uma lista.

### Bug Intencional
O programa aloca grandes quantidades de memória em um loop infinito sem liberar os recursos. Isso pode levar a um consumo excessivo de memória RAM, eventualmente causando uma `OutOfMemoryException` e travando o aplicativo ou o sistema.

### Objetivo
Identificar e corrigir o vazamento de memória. O objetivo é modificar o programa para que ele gerencie a memória de forma eficiente, seja limitando a alocação, liberando recursos após o uso ou implementando um padrão de uso de memória mais adequado.

