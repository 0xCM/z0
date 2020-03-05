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
        public struct R14D : IGpReg32<R14>
        {

            [FieldOffset(0)]
            uint content;

            [FieldOffset(0)]
            R14W r14w;

            [FieldOffset(0)]
            R14B r14b;
 
            public const GpRegId Id = GpRegId.r14;            

            [MethodImpl(Inline)]
            public static implicit operator uint(R14D src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R14D(uint src)
                => new R14D(src);

            [MethodImpl(Inline)]
            public R14D(uint src)
                : this()
            {
                content = src;
            }

            byte IGpReg32<R14>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r14b; 
 
                [MethodImpl(Inline)]
                set => r14b = value;
            }
            
            ushort IGpReg32<R14>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r14w; 
 
                [MethodImpl(Inline)]
                set => r14w = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}