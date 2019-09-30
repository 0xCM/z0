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
        public struct R9D : IGpReg32<R9D>
        {

            [FieldOffset(0)]
            uint content;

            [FieldOffset(0)]
            R9W r9w;

            [FieldOffset(0)]
            R9B r9b;

            public const GpRegId Id = GpRegId.r9d;            

            [MethodImpl(Inline)]
            public static implicit operator uint(R9D src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R9D(uint src)
                => new R9D(src);

            [MethodImpl(Inline)]
            public R9D(uint src)
                : this()
            {
                content = src;
            }

            byte IGpReg32<R9D>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r9b; 
 
                [MethodImpl(Inline)]
                set => r9b = value;
            }
            
            ushort IGpReg32<R9D>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r9w; 
 
                [MethodImpl(Inline)]
                set => r9w = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}