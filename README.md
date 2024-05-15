# function
Template struct folders to azure c# Function.

## Prerequits
1. Vscode
1. dotnet 8.0
1. Azure function core tools
1. Extensions
    1. Rest CLinet
    1. C#
    1. .NET Install Tool
1. git


## Create Template - (step by step)

``` sh
# create solution
dotnet new sln

# criate folders
mkdir src
mkdir testes
mkdir src/FBusiness
mkdir src/FBusiness.Models

# Create fucntion Add function to sln
func new --template "Http Trigger" --authlevel anonymous --name fBusiness
 
dotnet sln add src/FBusiness/fBusiness.csproj

#Create model project and add to sln
dotnet new classlib

dotnet sln add src/FBusiness.Models/FBusiness.Models.csproj

# Add Project reference
dotnet add reference ../FBusiness.Models/FBusiness.Models.csproj

# Add Project Reference to test project
dotnet add reference ../FBusiness.Models/FBusiness.Models.csproj
dotnet add src/tests/FBusiness.Tests/FBusiness.Tests.csproj

```


## Folders Structure
![Alt text](/docs/tree.png "tree Image")