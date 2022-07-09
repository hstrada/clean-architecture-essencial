#  clean-architecture-essencial

![clean architecture](https://github.com/hstrada/clean-architecture-essencial/blob/master/.github/clean-arch-01.png?raw=true)


## Requirements & technologies

  - .NET6.0
    - CleanArch follows (.NET5.0)
    - CleanArchMVC follows (.NET6.0)
  - SQL Server
  - Visual Studio 2022 Community or Visual Studio Code
  - EFCore
  - Clean Architecture
  - DDD
  - CQRS

## Run

### API

Check for swagger docs:
> https://localhost:7143/swagger/index.html

#### Preview

![clean architecture](https://github.com/hstrada/clean-architecture-essencial/blob/master/.github/swagger-api.jpeg?raw=true)

### WebUI

Check for WebUI:
> https://localhost:7003/

#### Preview

![clean architecture](https://github.com/hstrada/clean-architecture-essencial/blob/master/.github/home-webui.jpeg?raw=true)

## Default Access

Admin:

```json
{
  "email": "admin@localhost",
  "password": "admin#123456"
}
```

User:

```json
{
  "email": "usuario@localhost",
  "password": "usuario#123456"
}
```

## Useful commands while developing

CleanArch.Infra.Data

-- criar a migração
> add-migration Initial

-- aplicar o script de migração
> update-database

-- adicionar seed
> add-migration SeedProducts

-- criar a migração para o contexto do identity
> add-migration CreateIdentityTables

## More Images

![clean architecture](https://github.com/hstrada/clean-architecture-essencial/blob/master/.github/clean-arch.PNG?raw=true)

![clean architecture](https://github.com/hstrada/clean-architecture-essencial/blob/master/.github/clean-arch-02.PNG?raw=true)