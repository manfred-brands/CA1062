# CA1062
Show CA1062 firing

Minimal project to show that CA1062 fires even when arguments are checked with a method having a [NotNull] attribute.

This works for net5.0 (netstandard2.1 and later)
This fails for net48 and netstandard 2.0 because there is no public NotNullAttribute
