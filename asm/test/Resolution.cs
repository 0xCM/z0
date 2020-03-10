//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.AsmTest)]

namespace Z0.Resolutions
{
    public sealed class AsmCoreTest : AssemblyResolution<AsmCoreTest> { public AsmCoreTest() : base(AssemblyId.AsmTest) {} }
}