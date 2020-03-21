//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.CpuModel
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Root;
    
    partial class Registers
    {
        public struct ST : IFpuReg80
        {
            Float80 data;

            [MethodImpl(Inline)]
            public ST(float src)
                : this()
            {
                data = src;
            }

            [MethodImpl(Inline)]
            public ST(double src)
                : this()
            {
                data = src;
            }

            public VolatilityKind Volatility
                => VolatilityKind.Volatile;

        }
    }
}


