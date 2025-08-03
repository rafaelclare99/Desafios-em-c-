
## Programa 4: NullReferenceException

### Descrição do Problema
Este programa tenta obter o comprimento de uma string.

### Bug Intencional
A variável `texto` é inicializada como `null`, e o programa tenta acessar a propriedade `Length` de uma string nula, o que causará uma `NullReferenceException` em tempo de execução.

### Objetivo
Identificar e corrigir o erro para que o programa não tente acessar membros de uma referência nula. O objetivo é garantir que a string tenha um valor antes de tentar acessar suas propriedades ou métodos.

