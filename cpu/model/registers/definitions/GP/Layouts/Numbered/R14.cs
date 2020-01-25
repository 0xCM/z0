//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20114
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
        public struct R14 : IGpReg64<R14>
        { 
            [FieldOffset(0)]
            ulong content;

            [FieldOffset(0)]
            R14D r14d;

            [FieldOffset(0)]
            R14W r14w;

            [FieldOffset(0)]
            R14B r14b;

            public const GpRegId Id = GpRegId.r14;            

            [MethodImpl(Inline)]
            public static implicit operator ulong(R14 src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R14(ulong src)
                => new R14(src);

            [MethodImpl(Inline)]
            public R14(ulong src)
                : this()
            {
                content = src;
            }

            public GpRegId64 RegKind 
                => GpRegId64.r14;

            byte IGpReg64<R14>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r14b; 
 
                [MethodImpl(Inline)]
                set => r14b = value;
            }
            
            ushort IGpReg64<R14>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r14w; 
 
                [MethodImpl(Inline)]
                set => r14w = value;
            }

            uint IGpReg64<R14>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r14d; 
 
                [MethodImpl(Inline)]
                set => r14d = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}