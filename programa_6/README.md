
## Programa 6: Overflow

### Descrição do Problema
Este programa calcula o fatorial de um número inteiro fornecido pelo usuário.

### Bug Intencional
Para números de entrada relativamente pequenos, o cálculo do fatorial pode exceder o valor máximo que um tipo `long` pode armazenar, resultando em um overflow e um resultado incorreto.

### Objetivo
Identificar e corrigir o problema de overflow. O objetivo é garantir que o programa lide com números grandes de forma adequada, seja alertando o usuário sobre o limite ou utilizando um tipo de dado que possa acomodar valores maiores, se aplicável.

