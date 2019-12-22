//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    
    partial class Bits
    {       
        [MethodImpl(Inline)]
        public static byte project(byte src, byte spec)
            => (byte)scatter(src, (uint)spec);

        [MethodImpl(Inline)]
        public static byte select(byte src, byte spec)
            => (byte)gather(src, (uint)spec);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, ushort spec)
            => (ushort)scatter(src, (uint)spec);

        [MethodImpl(Inline)]
        public static ushort select(ushort src, ushort spec)
            => (ushort)gather(src, (uint)spec);
    }
}