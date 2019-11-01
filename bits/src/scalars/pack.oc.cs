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

    partial class bvoc
    {

        public static void pack8(ref bit src, ref uint dst)
            => Bits.pack(n8, ref src, ref dst);

        public static void pack16(ref bit src, ref uint dst)
            => Bits.pack(n16, ref src, ref dst);

        public static void pack32(ref bit src, ref uint dst)
            => Bits.pack(n32, ref src, ref dst);

    }

}