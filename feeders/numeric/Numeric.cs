//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Numeric)]

namespace Z0.Parts
{        
    public sealed class Numeric : Part<Numeric> { }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class XNumeric
    {

        
    }

    [ApiHost("numeric.api")]
    public static partial class Numeric
    {

        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }
    // public static class Numeric
    // {
    //     public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    // }

}
