//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.CilTest)]

namespace Z0.Resolutions
{
    public sealed class CilTest : AssemblyResolution<CilTest> 
    {
         public CilTest() : base(AssemblyId.CilTest) {} 
    }
}