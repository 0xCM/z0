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
        public struct EDX : IGpReg32<EDX>
        {
            [FieldOffset(0)]
            uint content;

            [FieldOffset(0)]
            DX dx;

            [FieldOffset(0)]
            DL dl;

            [FieldOffset(1)]
            DH dh;

            public const GpRegId Id = GpRegId.edx;          

            [MethodImpl(Inline)]
            public static uint operator !(EDX r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator EDX(uint src)
                => new EDX(src);

            [MethodImpl(Inline)]
            public EDX(uint src)
                : this()
            {
                this.content = src;
            }

            public uint Content 
            { 
                [MethodImpl(Inline)]
                get => content; 

                [MethodImpl(Inline)]
                set => content = value;
            }

            byte IGpReg32<EDX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !dl; 
 
                [MethodImpl(Inline)]
                set => dl = value;
            }
            
            ushort IGpReg32<EDX>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => !dx; 
 
                [MethodImpl(Inline)]
                set => dx = value;
            }
  
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}