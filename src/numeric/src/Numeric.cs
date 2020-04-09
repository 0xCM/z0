namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class XNumeric
    {
        
    }

    [ApiHost("api")]
    public static partial class Numeric
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }


    [ApiHost("parity.generic", ApiHostKind.Generic)]
    public static partial class parity
    {

    }

    [ApiHost("parity.direct", ApiHostKind.Direct)]
    static partial class Parity
    {

    }

    [ApiHost("as.numeric")]
    public static partial class AsNumeric
    {                

    }

    [ApiHost]
    public static partial class Scalar
    {

    }

    [ApiHost]
    public static partial class ScalarPairs
    {

    }

    [ApiHost]
    public static partial class BmiMul
    {

    }

    public static partial class XTend
    {
        
    }
}