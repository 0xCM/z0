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
        [StructLayout(LayoutKind.Explicit, Size = Size)]
        public struct AX : IGpReg16<AX>
        {
            [FieldOffset(0)]
            ushort content;

            [FieldOffset(0)]
            AL al;

            [FieldOffset(1)]
            AH ah;

            public const int Size = 2;

            public const GpRegId Id = GpRegId.ax;            

            [MethodImpl(Inline)]
            public static ushort operator !(AX r)
                => r.content;
            
            [MethodImpl(Inline)]
            public static implicit operator AX(ushort src)
                => new AX(src);

            [MethodImpl(Inline)]
            public AX(ushort src)
                : this()
            {
                this.content = src;
            }

            byte IGpReg16<AX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !al; 
 
                [MethodImpl(Inline)]
                set => al = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}