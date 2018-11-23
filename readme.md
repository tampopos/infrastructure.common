# tmpps.infrastructure.common

## register nuget

```bash
npm run publish
# replace version,api-key
dotnet nuget push ./Tmpps.Infrastructure.Common/bin/Release/Tmpps.Infrastructure.Common.${version}.nupkg -k ${api-key} -s https://api.nuget.org/v3/index.json
```
