//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericKinds;

    using NK = NumericKind;
    using NI = NumericIndicator;
    using NW = NumericWidth;

    partial class NumericKinds
    {            
        /// <summary>
        /// Determines the width of the identified numeric type
        /// </summary>
        /// <param name="kind">The source kind</param>
        [MethodImpl(Inline), Op]
        public static TypeWidth width(NumericKind kind)
            => (TypeWidth)(ushort)kind;         

        /// <summary>
        /// Computes the numeric kind determined by a bit-width and numeric indicator
        /// </summary>
        /// <param name="nw">The type width, in bits</param>
        /// <param name="ni">The numeric indicator</param>
        [Op]
        public static NK kind(NumericWidth nw, NumericIndicator ni) 
            => ni switch {
                NI.Signed 
                    => nw switch {                    
                        NW.W8  => NK.I8,
                        NW.W16 => NK.I16,
                        NW.W32 => NK.I32,
                        NW.W64 => NK.I64,
                        _ => NK.None
                    },
                NI.Unsigned 
                    => nw switch {
                        NW.W8  => NK.U8,
                        NW.W16 => NK.U16,
                        NW.W32 => NK.U32,
                        NW.W64 => NK.U64,
                        _ => NK.None
                    },
                NI.Float 
                    => nw switch {
                        NW.W32 => NK.F32,
                        NW.W64 => NK.F64,
                        _ => NK.None
                    },
                _ => NK.None
            };
    }

    partial class XTend
    {
        /// <summary>
        /// Determines the width of a numeric kind
        /// </summary>
        /// <param name="kind">The source kind</param>
        [MethodImpl(Inline)]
        public static TypeWidth TypeWidth(this NumericKind kind)
            => width(kind);            

        /// <summary>
        /// Determines the width of the represented kind in bits
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static int Width(this NumericKind k)
            => (int)(ushort)k;

        /// <summary>
        /// Determines the width of the represented kind in bytes
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static int Size(this NumericKind k)
            => ((int)(ushort)k)/8;            
    }
}