//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20115
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
        public struct R15D : IGpReg32<R15>
        {

            [FieldOffset(0)]
            uint content;

            [FieldOffset(0)]
            R15W r15w;

            [FieldOffset(0)]
            R15B r15b;
 
            public const GpRegId Id = GpRegId.r15;            

            [MethodImpl(Inline)]
            public static implicit operator uint(R15D src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R15D(uint src)
                => new R15D(src);

            [MethodImpl(Inline)]
            public R15D(uint src)
                : this()
            {
                content = src;
            }

            byte IGpReg32<R15>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r15b; 
 
                [MethodImpl(Inline)]
                set => r15b = value;
            }
            
            ushort IGpReg32<R15>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r15w; 
 
                [MethodImpl(Inline)]
                set => r15w = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}