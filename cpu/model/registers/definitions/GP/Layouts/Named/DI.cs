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
        public struct DI : IGpReg16<DI>
        {
            [FieldOffset(0)]
            ushort content;

            [FieldOffset(0)]
            DIL dil;

            public const GpRegId Id = GpRegId.edi;          

            [MethodImpl(Inline)]
            public static ushort operator !(DI r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator DI(ushort src)
                => new DI(src);

            [MethodImpl(Inline)]
            public DI(ushort src)
                : this()
            {
                this.content = src;
            }

            public ushort Content 
            { 
                [MethodImpl(Inline)]
                get => content; 

                [MethodImpl(Inline)]
                set => content = value;
            }

            byte IGpReg16<DI>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !dil; 
 
                [MethodImpl(Inline)]
                set => dil = value;
            }
            
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}