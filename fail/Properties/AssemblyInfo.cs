#region using

using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#endregion

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

[assembly: AssemblyVersion("9.9.9.0")]
[assembly: AssemblyFileVersion("9.9.9.0")]
[assembly: AssemblyInformationalVersion("9.9.9.0-7a17ea4")]

// Needed to avoid "CA1416: Validate platform compatibility" as this assembly needs Windows compatibility
// See https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1416#tfm-target-platforms
[assembly: SupportedOSPlatform("windows10.0.19041")]