//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    [ApiHost("api")]
    public partial class BitSpans : IApiHost<BitSpans>
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    }
    
    [ApiHost("direct")]
    public partial class SpannedBits : IApiHost<SpannedBits>
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    }

    public static partial class XTend
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;


    }
}