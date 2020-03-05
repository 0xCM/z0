//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2018
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
        public struct R8D : IGpReg32<R8>
        {

            [FieldOffset(0)]
            uint content;

            [FieldOffset(0)]
            R8W r8w;

            [FieldOffset(0)]
            R8B r8b;
 
            public const GpRegId Id = GpRegId.r8d;            

            [MethodImpl(Inline)]
            public static implicit operator uint(R8D src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R8D(uint src)
                => new R8D(src);

            [MethodImpl(Inline)]
            public R8D(uint src)
                : this()
            {
                content = src;
            }

            byte IGpReg32<R8>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r8b; 
 
                [MethodImpl(Inline)]
                set => r8b = value;
            }
            
            ushort IGpReg32<R8>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r8w; 
 
                [MethodImpl(Inline)]
                set => r8w = value;
            }


            GpRegId IGpReg.Id 
                => Id;
       }
    }
}