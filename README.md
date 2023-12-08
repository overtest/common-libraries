# Overtest Common Libraries
[![GitHub License](https://img.shields.io/github/license/overtest/common-libraries)](https://github.com/overtest/common-libraries/blob/main/LICENSE.MD)
[![build_and_deploy](https://github.com/overtest/common-libraries/actions/workflows/publish.yml/badge.svg)](https://github.com/overtest/common-libraries/actions/workflows/publish.yml)
[![Codeberg NuGet registry](https://badgen.net/badge/NuGet%20registry/Codeberg/#2185D0?icon=nuget)](https://codeberg.org/overtest/-/packages)

This repository contains various library projects (mainly written in `C#`), used by [Overtest](https://github.com/overtest) and its components. Note that these libraries are not intended to be used outside the Overtest ecosystem, so their APIs are very unstable and can be changed even in minor releases. If you want to use some of them in your own projects, we highly recommend you to create a fork of this repository and adapt it to your needs.

## Libraries & packages list
- [`overtest_task_models`](https://github.com/overtest/common-libraries/tree/main/overtest_task_models) — a [NuGet package](https://codeberg.org/overtest/-/packages/nuget/sirkadirov.overtest.common.taskmodels/) of a library containing models used to serialize and deserialize programming task projects for Overtest.

## How to install NuGet packages
**First step:** Add a [new NuGet source](https://docs.gitea.io/en-us/usage/packages/nuget/) pointing to our [NuGet registry](https://codeberg.org/overtest/-/packages) at Codeberg. We use it instead of GitHub Packages because you don't need to be registered on Codeberg to access published packages, so it's easier to use.
```
dotnet nuget add source --name overtest https://codeberg.org/api/packages/overtest/nuget/index.json
```

**Second step:** Now you can install desired packages from our NuGet registry using built-in UI in your development environment or from the terminal using this command:
```
dotnet add package --source overtest --version <package version> <package name>
```

## Project license agreement
```
Overtest Common Libraries project
Copyright (C) 2023 Yurii Kadirov (aka Sirkadirov)
https://github.com/overtest/common-libraries

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
Lesser General Public License for more details.
```