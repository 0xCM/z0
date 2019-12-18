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
        [StructLayout(LayoutKind.Explicit, Size = ByteCount)]
        public struct DX : IGpReg16<DX>
        {
            [FieldOffset(0)]
            ushort content;

            [FieldOffset(0)]
            DL dl;

            [FieldOffset(1)]
            DH dh;

            public const int BitWidth = 16;        

            public const int ByteCount = 2;

            public const string Name = nameof(DX);

            public const GpRegId Id = GpRegId.dx;            

            [MethodImpl(Inline)]
            public static ushort operator !(DX r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator DX(ushort src)
                => new DX(src);

            [MethodImpl(Inline)]
            public DX(ushort src)
                : this()
            {
                this.content = src;
            }
 
            byte IGpReg16<DX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !dl; 
 
                [MethodImpl(Inline)]
                set => dl = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}