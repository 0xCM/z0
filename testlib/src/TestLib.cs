//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.TestLib)]

namespace Z0.Parts
{
    public sealed class TestLib : Part<TestLib>
    {        
        
    }
}

namespace Z0
{
    using System.Runtime.CompilerServices;

    public static partial class TestLib
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;   
    }

}
