
## Programa 8: Problema de Concorrência (Thread Safety)

### Descrição do Problema
Este programa utiliza múltiplas threads para incrementar um contador compartilhado.

### Bug Intencional
O acesso ao contador compartilhado não é sincronizado entre as threads. Isso pode levar a uma condição de corrida (race condition), onde o valor final do contador pode ser menor do que o esperado devido a operações de leitura e escrita sobrepostas.

### Objetivo
Identificar e corrigir o problema de concorrência. O objetivo é garantir que o acesso ao contador compartilhado seja thread-safe, utilizando mecanismos de sincronização adequados (como `lock` ou `Interlocked`) para que o resultado final seja sempre correto.

