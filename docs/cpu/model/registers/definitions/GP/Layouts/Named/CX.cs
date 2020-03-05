//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.CpuModel
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;
    
    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct CX : IGpReg16<CX>
        {
            [FieldOffset(0)]
            ushort content;

            [FieldOffset(0)]
            CL cl;

            [FieldOffset(1)]
            CH ch;

            public const GpRegId Id = GpRegId.cx;          

            [MethodImpl(Inline)]
            public static ushort operator !(CX r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator CX(ushort src)
                => new CX(src);

            [MethodImpl(Inline)]
            public CX(ushort src)
                : this()
            {
                this.content = src;
            }

            byte IGpReg16<CX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !cl; 
 
                [MethodImpl(Inline)]
                set => cl = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}