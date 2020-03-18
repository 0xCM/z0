//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections.Concurrent;

    using static Root;

    using NK = NumericKind;
    using TC = System.TypeCode;
    using FW = FixedWidth;
    using NI = NumericIndicator;
    using ID = NumericKindId;

    partial class Numeric
    {
        [Op]
        public static NumericKind from(FixedWidth width, NumericIndicator indicator)
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