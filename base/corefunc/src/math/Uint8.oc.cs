//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class zfoc
    {

        public static UInt8 bitview8_and(UInt8 a, UInt8 b)
            => a & b;

        public static UInt8 bitview8_sll(UInt8 a, int offset)
            => a << offset;

        public static UInt8 bitview8_rotl(UInt8 a, int offset)
            => UInt8.rotl(a,offset);

        public static UInt8 bitview8_rotr(UInt8 a, int offset)
            => UInt8.rotr(a,offset);

        public static UInt8 bitview8_mul(UInt8 a, UInt8 b)
            => a * b;

        public static UInt8 bitview8_or(UInt8 a, UInt8 b)
            => a | b;

    }

}