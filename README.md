CleanArch.Infra.Data

-- criar a migração
> add-migration Initial

-- aplicar o script de migração
> update-database

-- adicionar seed
> add-migration SeedProducts

-- criar a migração para o contexto do identity
> add-migration CreateIdentityTables