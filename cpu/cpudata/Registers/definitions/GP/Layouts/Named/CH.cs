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
        public struct CH : IGpReg8<CH>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.ch;            

            [MethodImpl(Inline)]
            public static byte operator !(CH r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator CH(byte src)
                => new CH(src);

            [MethodImpl(Inline)]
            public CH(byte src)
                => content = src;

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}