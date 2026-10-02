# GamerProfile xUnit

Projeto desenvolvido para a disciplina de **Gestão e Qualidade de Software** (Centro Universitário UNA), com o objetivo de praticar **testes unitários em C# com xUnit**.

## Propósito do sistema

O sistema simula regras simples do perfil de um jogador, reunidas na classe `PerfilJogadorService`:

| Método | Retorno | O que faz |
| :--- | :--- | :--- |
| `GerarTagUsuario(string nickname, string codigo)` | `string` | Junta o nickname e o código com o caractere `#`. Exempllo.: `"Aragorn"` e `"1042"` geram `"Aragorn#1042"`. |
| `CalcularXPTotal(int xpFase1, int xpFase2)` | `int` | Soma o XP de duas fases e aplica um bônus fixo de 100 pontos. Ex.: `200` e `300` geram `600`. |
| `EEligivelParaRanked(int nivelJogador)` | `bool` | Retorna `true` se o nível for maior ou igual a 15, e `false` caso contrário. |

## Testes unitários realizados

Os testes ficam em `GamerProfile.Tests/PerfilJogadorServiceTests.cs`, usam o atributo `[Fact]` e seguem o padrão **AAA** (Arrange, Act, Assert). São três, um para cada tipo de retorno:

1. **Teste de string:** valida se `GerarTagUsuario` gera o formato `Nickname#0000`, usando `Assert.Equal`.
2. **Teste de int:** valida se `CalcularXPTotal` soma as duas fases e aplica o bônus de 100 pontos, usando `Assert.Equal`.
3. **Teste de bool:** valida a regra de elegibilidade para partidas ranqueadas, usando `Assert.True` para níveis a partir de 15 e `Assert.False` para níveis abaixo de 15 (incluindo o valor de fronteira, 14 e 15).

## Estrutura do repositório

```
gamer-profile-xunit/
├── GamerProfile.slnx
├── GamerProfile.App/        # Código de produção (PerfilJogadorService)
├── GamerProfile.Tests/      # Testes unitários com xUnit
├── .gitignore
├── LICENSE
└── README.md
```

## Como executar os testes

**Pré-requisito:** ter o .NET SDK instalado.

```bash
git clone https://github.com/SEU_USUARIO/gamer-profile-xunit.git
cd gamer-profile-xunit
dotnet test
```

Se tudo estiver certo, o resultado esperado é `Passed! - Failed: 0, Passed: 3`.
