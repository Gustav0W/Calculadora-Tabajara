# Calculadora Tabajara 2025	

![](https://i.imgur.com/ehh1jfT.gif)

## Introdução

É uma calculadora que consegue fazer as 4 operações matemáticas e mostrar a tabuada, incrível.

## Funcionalidades

- **Operações básicas**: Realize somas, subtrações, multiplicações, divisões e veja a tabuada de qualquer número.
- **Suporte a decimais**: Trabalhe com números de até duas casas decimais, não arredonda.
- **Entradas validadas**: A calculadora garante que apenas opções válidas sejam aceitas.
- **Tratamento de divisão por zero**: A calculadora identifica e valida erros de divisão por zero.
- **Histórico de operações**: Ela também armazena o histórico de operações!

## Como Utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raíz.
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```
4. Em seguida compile com o comando: 
```
dotnet build --configuration Release
```

5. Execute com o comando:
```
dotnet run
```

6. Você verá esse terminal:
```
Console.WriteLine("=================================");
Console.WriteLine("    Calculadora Tabajara 2025    ");
Console.WriteLine("=================================");

Console.WriteLine("1- Somar");
Console.WriteLine("2- Subtrair");
Console.WriteLine("3- Multiplicar");
Console.WriteLine("4- Divisão");
Console.WriteLine("5- Tabuada");
Console.WriteLine("6- Histórico");
Console.WriteLine("S- Sair");
```