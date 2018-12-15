# tmpps.infrastructure.common

## command

#### build

`dotnet build Tmpps.Infrastructure.Common.Tests/`

#### test

`dotnet test Tmpps.Infrastructure.Common.Tests/`

#### register nuget

```bash
dotnet build -c Release Tmpps.Infrastructure.Common
# replace version,api-key
dotnet pack -c Release --include-source -p:PackageVersion=${version} Tmpps.Infrastructure.Common
dotnet nuget push ./Tmpps.Infrastructure.Common/bin/Release/Tmpps.Infrastructure.Common.${version}.nupkg -k ${api-key} -s https://api.nuget.org/v3/index.json
```

## use circleCI CLI

#### validation config

`circleci config validate`

#### test

`circleci local execute --job test`

#### release

```bash
git tag X.Y.Z
git push origin --tags
```
