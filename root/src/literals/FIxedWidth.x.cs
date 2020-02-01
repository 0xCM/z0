//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using NK = NumericKind;
    using FW = FixedWidth;
    using NI = NumericIndicator;

    public static partial class RootX
    {
        /// <summary>
        /// Converts a fixed width kind to an integer corresponding to the with represented by the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static int ToInteger(this FixedWidth src)
            => (int)src;

        [MethodImpl(Inline)]
        public static string Format(this FixedWidth src)
            => src.ToInteger().ToString();

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this FixedWidth src)
            => src != FixedWidth.None;

        public static NumericKind ToNumericKind(this FW width, NI indicator)
            => indicator switch {
                NI.Signed 
                    => width switch {                    
                        FW.W8  => NK.I8,
                        FW.W16 => NK.I16,
                        FW.W32 => NK.I32,
                        FW.W64 => NK.I64,
                        _ => NK.None
                    },
                NI.Unsigned 
                    => width switch {
                        FW.W8  => NK.U8,
                        FW.W16 => NK.U16,
                        FW.W32 => NK.U32,
                        FW.W64 => NK.U64,
                        _ => NK.None
                    },
                NI.Float 
                    => width switch {
                        FW.W32 => NK.F32,
                        FW.W64 => NK.F64,
                        _ => NK.None
                    },
                _ => NK.None
            };
    }
}