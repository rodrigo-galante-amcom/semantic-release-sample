# semantic-release POC
- Controle de releases automatizado que se baseia na especificação **[Semantic Version](https://semver.org/)**

# Como usuar?

- Para utilização em conjunto com o github é necessário criar um arquivo .yml com as definições do workflow do semantic-release. Nele podemos definir quais branches estarão envolvidas neste fluxo bem como as etapas de validação e variáveis de ambiente.

- Esse arquivo será utilizado pelo github Actions 

# Tipos de commit

** Prefixos **
- Commit com o prefixo - feat (Minor Feature release)
    *Exemplo de comando:*  git commit -m "feat: ajuste A"

- Commit com o prefixo - fix (Patch release)
*Exemplo de comando:* git commit -m "fix: correção do bug na funcionalidade a"

- Commit com o prefixo - perf (Patch release)
*Exemplo de comando:* git commit -m "perf: ajuste na implementação na funcionalidade a"

- [Referência](https://github.com/semantic-release/semantic-release/blob/master/docs/recipes/distribution-channels.md#publishing-on-distribution-channels)

# Referências

- **[Semantic Version](https://semver.org/)**

- **[How to Create a NPM TOKEN](https://docs.npmjs.com/creating-and-viewing-authentication-tokens)**


