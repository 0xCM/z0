//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Api)]

namespace Z0.Parts
{        
    public sealed class Api : Part<Api>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class Api
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

    public static partial class XTend
    {
        
    }
}
