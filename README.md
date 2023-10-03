
# Senac Rio - Cadastrado Professores e Alunos

Reposit�rio para a turma de desenvolvimento .net de aplica��es back-end para Web - MAF - 2023.1


## Documenta��o da API

#### Retorna todos os itens

### Aluno Controller
#### Retorna a lista de alunos

```http
  GET /api/aluno
```

### Professor Controller
#### Retorna a lista de professores

```http
  GET /api/professor/lista
```
#### Retorna uma lista de professores filtrando pelo nome

```http
  GET /api/professor/busca?nome={nome}
```

| Par�metro   | Tipo       | Descri��o                                   |
| :---------- | :--------- | :------------------------------------------ |
| `nome`      | `string` | **Obrigat�rio**. O NOME do professor que voc� quer |


## Autores

- [@lpjunior](https://www.github.com/lpjunior)


## Refer�ncia

 - [.Net](https://learn.microsoft.com/pt-br/dotnet/)
 - [What is REST](https://restfulapi.net)
 - [What is JSON](https://restfulapi.net/introduction-to-json/)

