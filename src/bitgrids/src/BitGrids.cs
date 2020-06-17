//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    [ApiHost("api")]
    public partial class BitGrid : IApiHost<BitGrid>
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

    [ApiHost("allocating")]
    public partial class BitGridA : IApiHost<BitGridA>
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    }

    [ApiHost("patterns")]
    public partial class GridPatterns : IApiHost<GridPatterns>
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    }

    [ApiHost]
    public partial class SubGrid : IApiHost<SubGrid>
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    }

    [ApiHost]
    public static partial class GridLoad
    {   
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

    public static partial class BitGridX
    {   

    }

    public static partial class XTend
    {   

    }

}