# criacao de um global.json, pra definir as configuracoes do projeto e versao do dotnet.

{
	"sdk": {
		"version": "6.0.116"
	}
}

{
	"sdk": {
		"version": "7.0.105"
	}
}
# Criar projeto
dotnet new wepapi -o EntityFramework7Relationships

# Instalar dotnet ef global
dotnet tool install --global dotnet-ef
# Criar arquivo de solution Sln
dotnet new sln

# Adicionar Projeto a Solucao
dotnet sln add EntityFramework7Relationships/EntityFramework7Relationships.csproj%  

# Criar container com banco SQL Server
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -e "MSSQL_PID=Express" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest 
docker run -d -t --name sqlserverexpress -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=I@u9j7p9" -e "MSSQL_PID=Express" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
# Acessar container 


docker exec -it <container_id|container_name> /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P <your_password>
docker exec -it 0b9 /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P SENHA


# Criar migrations
dotnet ef migrations add CreateInitial

# Criar o banco de fato no SGBD
dotnet ef database update

// // "DefaultConnection": "Server=localhost,1433;Database=superherodb;User Id=sa;Password=SENHA;Encrypt=false;"
