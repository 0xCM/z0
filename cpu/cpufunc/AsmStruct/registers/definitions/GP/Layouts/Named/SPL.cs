//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public struct SPL : IGpReg8<SPL>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.spl;            

            [MethodImpl(Inline)]
            public static byte operator !(SPL r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator SPL(byte src)
                => new SPL(src);

            [MethodImpl(Inline)]
            public SPL(byte src)
                =>content = src;

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}