//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20112
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
        public struct R12 : IGpReg64<R12>
        { 
            [FieldOffset(0)]
            ulong content;

            [FieldOffset(0)]
            R12D r12d;

            [FieldOffset(0)]
            R12W r12w;

            [FieldOffset(0)]
            R12B r12b;

            public const GpRegId Id = GpRegId.r12;            

            [MethodImpl(Inline)]
            public static implicit operator ulong(R12 src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R12(ulong src)
                => new R12(src);

            [MethodImpl(Inline)]
            public R12(ulong src)
                : this()
            {
                content = src;
            }

            public GpRegId64 RegKind 
                => GpRegId64.r12;

            byte IGpReg64<R12>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r12b; 
 
                [MethodImpl(Inline)]
                set => r12b = value;
            }
            
            ushort IGpReg64<R12>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r12w; 
 
                [MethodImpl(Inline)]
                set => r12w = value;
            }

            uint IGpReg64<R12>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r12d; 
 
                [MethodImpl(Inline)]
                set => r12d = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}