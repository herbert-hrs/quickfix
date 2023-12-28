# Quickfix Babet #

## 1 Alterar versão

No arquivo **Quickfix.csproj** alterar a versão 

    <Version>1.0.0</Version>

## 2 Criar pacote

* Na mesma pasta do arquivo **Quickfix.csproj**  criar pacotes:

```
dotnet build -c Release
```
- Obs: O pacote será criado na respectiva pasta, na sub pasta **Bin/Release**.


## 3 Publicação do pacote no Repositório NuGet SLTools

* Na pasta do pacote (.nupkg) de interesse, adicionar pacote:

```
dotnet nuget push {NOME_PACOTE}.nupkg -k {apiKey} -s http://{host}/v3/index.json
```