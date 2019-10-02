![Icon](https://i.imgur.com/WC1Fzeb.png?1)
# GitCommands
[![Build status](https://ci.appveyor.com/api/projects/status/p2lcfokntt0almiw?svg=true)](https://ci.appveyor.com/project/lvermeulen/gitcommands) [![license](https://img.shields.io/github/license/lvermeulen/GitCommands.svg?maxAge=2592000)](https://github.com/lvermeulen/Flurl.Http.Xml/blob/master/LICENSE) [![NuGet](https://img.shields.io/nuget/v/GitCommands.svg?maxAge=86400)](https://www.nuget.org/packages/GitCommands/)

Dotnet tool to execute git commands when git is not available.

## Features:
* git status
* git add --all
* git commit
* git push

## Installation:
~~~~
dotnet tool install -g gitcommands
~~~~

## Usage:

* git status
~~~~
    gitcommands status --path=<path/to/repo>
~~~~

* git add --all
~~~~
    gitcommands addall --path=<path/to/repo>
~~~~

* git commit
~~~~
    gitcommands commit  --path=<path/to/repo> --username=<your/user/name> --email=<your@emailaddress.com> --message=<your commit message>
~~~~

## Thanks
* [Merge](https://thenounproject.com/mfucek1/collection/round-the-world/?i=1853539) icon by [Marko Fuček](https://thenounproject.com/mfucek1/) from [The Noun Project](https://thenounproject.com)
