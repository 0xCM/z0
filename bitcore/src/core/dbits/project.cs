//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;

    partial class Bits
    {       
        [MethodImpl(Inline), Op]
        public static byte project(byte src, byte spec)
            => (byte)scatter(src, (uint)spec);

        [MethodImpl(Inline), Op]
        public static byte select(byte src, byte spec)
            => (byte)gather(src, (uint)spec);

        [MethodImpl(Inline), Op]
        public static ushort project(ushort src, ushort spec)
            => (ushort)scatter(src, (uint)spec);

        [MethodImpl(Inline), Op]
        public static ushort select(ushort src, ushort spec)
            => (ushort)gather(src, (uint)spec);
    }
}