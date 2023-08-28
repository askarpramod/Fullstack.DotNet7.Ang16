# Overview
Web application with Dot Net 7 and Angular 16 

# command handy 

C:\CodeP\Fullstack.DotNet7.Ang16>git fetch
C:\CodeP\Fullstack.DotNet7.Ang16>git pull


C:\CodeP\Fullstack.DotNet7.Ang16>git status
C:\CodeP\Fullstack.DotNet7.Ang16>git add .
C:\CodeP\Fullstack.DotNet7.Ang16>git commit -m "Initial commit with Backend API working with EF Code First"

Now it has been checked in to local repository, now we will push to remote repo
C:\CodeP\Fullstack.DotNet7.Ang16>git push

PS C:\CodeP\Fullstack.DotNet7.Ang16\FrontEnd.UI\CodePramod.UI.Angular16> ng serve --open 


## Fullstack.DotNet7.Ang16
[TODO] Add an overview of your project

###Request and Response

####  https://localhost:7127/swagger/index.html
 Post to Creat Category : https://localhost:7127/api/Categories
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

## Next Steps


  - Submit a pull request

## Getting Started

### Software dependencies

#### Required

1. [Visual Studio latest version](https://visualstudio.microsoft.com/downloads/)
1. [.NET Core Latest LTS](https://www.microsoft.com/net/download/dotnet-core/)
1. [Git](https://git-scm.com/downloads)
1. [Arcus Platform Developer Setup](https://dev.azure.com/mindbody/MBScrum/_wiki/wikis/MBScrum.wiki/1675/Developer-Setup)
   1. Docker
   1. Kubernetes (K8) CLI & Helm
   1. Google Cloud Platform Services
   1. Draft

#### Nice-To-Have

1. [Markdown Editor, Visual Studio extension](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.MarkdownEditor)

## Local Build and Test

- Open the project in Visual Studio
- Hit F5

## Development Environment Test

- Open powershell as administrator
- cd aaaa


## Contribute

1. Pull down the latest main branch.
1. Create a feature branch out of main.
1. Write tests for what you're going to change. They should fail.
1. Make your code changes until your new, and ALL the old, tests pass.
1. Add and commit your changes to your feature branch.
1. Pull down the latest changes from main.
1. Merge main into your feature branch.
1. Make sure ALL the tests pass. Fix, if necessary.
1. Push your changes.
1. Submit a PR.

