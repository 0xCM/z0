//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public partial class BitGrid
    {
        const NumericKind Closure = UnsignedInts;
    }

    [ApiHost("allocating")]
    public partial class BitGridA
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

    public partial class BGI
    {

    }

    [ApiHost]
    public partial class GridPatterns
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    }

    [ApiHost]
    public partial class SubGrid
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