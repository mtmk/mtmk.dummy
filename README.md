# mtmk.dummy

An example GitHub repository showing how a dotnet library can be published to nuget
by maintaining a `version.txt` file and using git tags and GitHub actions.

## MSBuild and NuGet version options

What determines your package version for NuGet is the `<PackageVersion>` element.
Your DLLs file and assembly version as well as the product version is determined by
the `<Version>` element in your project's properties.

Here we drive both of these values using the `version.txt` file.


## Packaging using GitHub Actions

We use the 'publish.yml' workflow to publish to NuGet. You would need to set you Nuget API
in you GitHub repository Action secrets with name `NUGET_API_KEY`. You also need to
give workflows write access so that `publish` workflow can create tags as the packages
are published to NuGet.

Currently `publish` workflow is set to be run manually by using `workflow_dispatch` trigger.
You can set this to be triggered on push as well safely, since NuGet publish would only happen on
changes to `version.txt` file as long as the version doesn't match any existing tags.

## Targeting multiple frameworks

You can target multiple frameworks by adding multiple `<TargetFramework>` elements in your
project file. You can also use `TargetFrameworks` element to specify multiple frameworks
separated by semicolon. You can also use wildcards in your framework names.
