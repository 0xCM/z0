//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Fixed
    {
        [MethodImpl(Inline), Op]
        public static Fixed8 fix(byte src)
            => src;

        [MethodImpl(Inline), Op]
        public static Fixed8 fix(sbyte src)
            => src;

        [MethodImpl(Inline), Op]
        public static Fixed16 fix(short src)
            => src;

        [MethodImpl(Inline), Op]
        public static Fixed16 fix(ushort src)
            => src;

        [MethodImpl(Inline), Op]
        public static Fixed32 fix(int src)
            => src;

        [MethodImpl(Inline), Op]
        public static Fixed32 fix(uint src)
            => src;

        [MethodImpl(Inline), Op]
        public static Fixed64 fix(long src)
            => src;

        [MethodImpl(Inline), Op]
        public static Fixed64 fix(ulong src)
            => src;        
    }
}