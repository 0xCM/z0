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
        public struct AH : IGpReg8<AH>
        {
            [FieldOffset(0)]
            byte content;
            
            [MethodImpl(Inline)]
            public static byte operator !(AH r)
                => r.content;

            public const GpRegId Id = GpRegId.ah;            

            [MethodImpl(Inline)]
            public static implicit operator AH(byte src)
                => new AH(src);

            [MethodImpl(Inline)]
            public AH(byte src)
                => content = src;
                
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}