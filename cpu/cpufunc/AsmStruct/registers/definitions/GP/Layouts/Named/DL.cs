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
        public struct DL : IGpReg8<DL>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.dl;          

            [MethodImpl(Inline)]
            public static byte operator !(DL r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator DL(byte src)
                => new DL(src);
            

            [MethodImpl(Inline)]
            public DL(byte src)
                => this.content = src;

            GpRegId IGpReg.Id 
                => Id;
 
        }
    }
}