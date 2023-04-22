# Locust.Base
This library contains basic utilities and type helpers. It also holds some multi-purpose attributes such as Ignore and Size that could be leveraged by other libraries for their own purpose. Locust.Base depends on no other library and is standalone.

## Helper classes
- `TypeHelper`: a helper class with static type properties for primitive and most-used types.

- `InstanceProvider<TAbstraction, TImplementation>`: a general-purpose singleton instance provider.

- `AnyComparer`:
a utility comparer class that is able to compare anything with anything safely using its singleton IComparer instance. The default instance is of type `DefaultAnyComparer`. It first checks whether any of the two arguments or both of them are null. If so, the result is specified based on the rule 'null equals with null, but is less than any not-null value'. If both of them are none-null, it tries to cast either of the arguments to `IComparable` and use their `CompareTo()` method. If neither implements `IComparable`, it falls back to comparing their `GetHashCode()` at the end.

## Attributes
- `Ignore`: could be used to decorate any custom class/method/property. It implies that the target should be ignored (based on any usage the developer intends)
- `Size`: could be used to decorate properties to denote a size or length for that.
- `EnumDefault`: applies to enums and is used to specify a default value for the enum.

## TypeHelper methods
- `TAbstraction EnsureInitialized<TAbstraction, TConcretion>(ref TAbstraction value, bool threadSafe = false)`:
       a utility method to -safely- instantiate and return an implementation for a given abstraction.
- `Type FindType(string typename)`
      searches current appdomain's assemblies for a type based on its string name.
- `IEnumerable<T> GetValues<T>()`
    converts list of values in an enum of type T into an IEnumerable&lt;T&gt;
- `object FindTypeAndInstantiate(string typename, params object[] args)`
    looks for the given type based on its name in current appdomain's assemblies and instantiates from it using the given arguments (passes the arguments to the found type constructor).
- `object FindTypeAndTryInstantiate(string typename, params object[] args)`
      performs the same as FindTypeAndInstantiate() except that it handles exceptions using a try/catch when instantiating object to prevent errors.

## Utilities
- `AssemblyLoader`
- `InstanceProvider`
- `ObjectActivator`
- `Language Constructs`

## Types
- `DotNetType`
- `DotNetTypeList`
- `DynamicDTO`

## Language Constructs
### Try

Example 1:
```csharp
using static Locust.Constructs;

if (Try(() => DoSomething(), out Exception ex))
{
    Console.WriteLine("Succeeded!");
}
else
{
    Console.WriteLine(ex.Message);
}
```

Example 2:
```csharp
using static Locust.Constructs;

var content = Try(() => File.ReadAllText(@"c:\myfile.txt"), out Exception ex);

Console.WriteLine(content);
Console.WriteLine(ex?.Message);

```

