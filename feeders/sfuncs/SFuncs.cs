//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.SFuncs)]

namespace Z0.Parts
{        
    public sealed class SFuncs : Part<SFuncs>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class SFuncs
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

}
