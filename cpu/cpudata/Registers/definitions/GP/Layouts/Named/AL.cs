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
        public struct AL : IGpReg8<AL>
        {
            [FieldOffset(0)]
            public byte al;

            public const GpRegId Id = GpRegId.al;            

            /// <summary>
            /// Dereferences al to produce its content [al]
            /// </summary>
            /// <param name="r">The source register</param>
            [MethodImpl(Inline)]
            public static byte operator !(AL r)
                => r.al;

            [MethodImpl(Inline)]
            public static implicit operator AL(byte src)
                => new AL(src);

            [MethodImpl(Inline)]
            public AL(byte src)
                =>al = src;

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}