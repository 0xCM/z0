//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend 
    {        
        public static string Format(this DataSize src)
            => ((byte)src).ToString();

        [MethodImpl(Inline)]
        public static string FormatValue(this TypeWidth w)
            => ((uint)w).ToString();

        [MethodImpl(Inline)]
        public static string FormatValue(this DataWidth w)
            => ((uint)w).ToString();

        [MethodImpl(Inline)]
        public static string FormatValue(this NumericWidth w)
            => ((uint)w).ToString();

        [MethodImpl(Inline)]
        public static string FormatValue(this FixedWidth w)
            => ((uint)w).ToString();

        [MethodImpl(Inline)]
        public static string FormatValue(this VectorWidth w)
            => ((uint)w).ToString();
    }
}