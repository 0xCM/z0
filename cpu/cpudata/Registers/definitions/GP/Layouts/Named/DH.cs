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
        [StructLayout(LayoutKind.Explicit)]
        public struct DH : IGpReg8<DH>
        {
            [FieldOffset(0)]
            byte content;            

            public const GpRegId Id = GpRegId.dh;          

            [MethodImpl(Inline)]
            public static byte operator !(DH r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator DH(byte src)
                => new DH(src);            

            [MethodImpl(Inline)]
            public DH(byte src)
                => this.content = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}