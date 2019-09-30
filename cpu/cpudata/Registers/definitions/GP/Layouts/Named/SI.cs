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
        public struct SI : IGpReg16<SI>
        {
            [FieldOffset(0)]
            ushort content;

            [FieldOffset(0)]
            SIL sil;

            public const GpRegId Id = GpRegId.si;            

            [MethodImpl(Inline)]
            public static ushort operator !(SI r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator SI(ushort src)
                => new SI(src);

            [MethodImpl(Inline)]
            public SI(ushort src)
                : this()
            {
                this.content = src;
            }

            byte IGpReg16<SI>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => sil; 
 
                [MethodImpl(Inline)]
                set => sil = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}