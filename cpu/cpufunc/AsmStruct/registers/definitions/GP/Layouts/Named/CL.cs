//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        [StructLayout(LayoutKind.Explicit)]
        public struct CL : IGpReg8<CL>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.cl;            

            [MethodImpl(Inline)]
            public static byte operator !(CL r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator CL(byte src)
                => new CL(src);

            [MethodImpl(Inline)]
            public CL(byte src)
                => content = src;

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}