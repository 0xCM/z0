//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;
    
    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit, Size = 10)]
        public struct ST : IFpuReg80
        {
            [FieldOffset(0)]
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

            public Volatility Volatility
                => Volatility.Volatile;

        }
    }
}


