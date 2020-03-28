//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Errors)]

namespace Z0.Parts
{        
    public sealed class Errors : Part<Errors>
    {

    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Errors
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

}
