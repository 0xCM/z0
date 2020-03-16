//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.IdentityTest)]

namespace Z0
{
     class App : TestApp<App>
     {
          public static void Main(params string[] args) => Run(args); 
        }
     }

namespace Z0.Resolutions
{
    public sealed class IdentityTest : AssemblyResolution<IdentityTest> { }
}