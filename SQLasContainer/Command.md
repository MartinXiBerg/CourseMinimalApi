# WebApi (ASP NET Anwendung)
- docker run -p 80:8080 --rm -d --name beer-service beer-service:v1.0.0

# MSSQL Settings
## Vorbereitungen
- docker run -p 80:8080 --rm

## Aufsetzen ohne Volume
- docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Pa$$w0rd" -p 14333:1433 --name mssql1 --hostname mssql1 -d mcr.microsoft.com/mssql/server:2022-latest
> Pa$$w0rd does not work with PowerShell

## Aufsetzen eines Volume
> docker volume create
>> Example docker volume create db_storage


## MSSQL mit Volume
- docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Pabbw0rd" -p 14333:1433 --name mssql1 --hostname mssql1 -v db_storage:/var/opt/mssql -d mcr.microsoft.com/mssql/server:2022-latest

## Logs für MSSQl anzeigen
- docker container logs mssql1
> Logs anzeigen
- docker container ls -a
> Alle Container anzeigen

## Start and Stop configured MSSQL
> docker **stop** mssql1
> 
> docker **start** mssql1
