
microsoft.entityframeworkcore.Sql
microsoft.entityframeworkcore.tools

---- Add Migration and Create DB and Tables as per Domain models
PM> Add-Migration "Initial Migration"
PM> Update-Database



#####
https://localhost:7127/swagger/index.html
### Post to Creat Category : https://localhost:7127/api/Categories
Req : {
  "name": "ASP Dot Net Core with Repo",
  "urlHandle": "DotNEtCoreWithRepository"
}

or Curl : 
curl -X 'POST' \
  'https://localhost:7127/api/Categories' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "name": "ASP Dot Net Core with Repo",
  "urlHandle": "DotNEtCoreWithRepository"
}'


Res :
{
  "id": "095d0605-af2f-4dc8-1576-08dba2ddf349",
  "name": "ASP Dot Net Core with Repo",
  "urlHandle": "DotNEtCoreWithRepository"
}
