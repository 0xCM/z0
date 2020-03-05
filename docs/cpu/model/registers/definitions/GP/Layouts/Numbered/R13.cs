//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20113
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
        public struct R13 : IGpReg64<R13>
        { 
            [FieldOffset(0)]
            ulong content;

            [FieldOffset(0)]
            R13D r13d;

            [FieldOffset(0)]
            R13W r13w;

            [FieldOffset(0)]
            R13B r13b;

            public const GpRegId Id = GpRegId.r13;            

            [MethodImpl(Inline)]
            public static implicit operator ulong(R13 src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R13(ulong src)
                => new R13(src);

            [MethodImpl(Inline)]
            public R13(ulong src)
                : this()
            {
                content = src;
            }

            public GpRegId64 RegKind 
                => GpRegId64.r13;

            byte IGpReg64<R13>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r13b; 
 
                [MethodImpl(Inline)]
                set => r13b = value;
            }
            
            ushort IGpReg64<R13>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r13w; 
 
                [MethodImpl(Inline)]
                set => r13w = value;
            }

            uint IGpReg64<R13>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r13d; 
 
                [MethodImpl(Inline)]
                set => r13d = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}