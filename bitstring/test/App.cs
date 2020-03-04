//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0{ class App : TestApp<App>{ public static void Main(params string[] args) => Run(args); } }

namespace Z0.Resolutions
{
    public sealed class BitStringTest : AssemblyResolution<BitStringTest> 
    { 
         public BitStringTest() : base(AssemblyId.BitStringTest) {} 
    } 
}