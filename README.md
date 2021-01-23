# CA1062
Show CA1062 firing

Minimal project to show that CA1062 fires even when arguments are checked with
 a method having a [NotNull] attribute.

This works for net5.0 (netstandard2.1 and later)
This fails for net48 and netstandard 2.0 because there is no public
NotNullAttribute

# Build

The project uses 3 different way to get a NotNullAttribute for use in netstandard2.0:

* [Nullable](https://www.nuget.org/packages/Nullable/)
* [ReferenceAssemblyAnnotator](https://www.nuget.org/packages/TunnelVisionLabs.ReferenceAssemblyAnnotator/1.0.0-alpha.160)
* Own class.
  * internal
  * public

```bash
msbuild -p:NullableOption=Nullable
msbuild -p:NullableOption=TunnelVision
msbuild -p:NullableOption=DefineMyOwn
msbuild -p:NullableOption=DefineMyOwnPublic
```
