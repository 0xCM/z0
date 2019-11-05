//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    partial class inxoc
    {
        public static void gparts_xor_8u(int partcount, int partwidth, in byte a, in byte b, ref byte z)
            => gparts.xor(n256, partcount,partwidth,in a, in b, ref z);

        public static void gparts_xor_16u(int partcount, int partwidth, in ushort a, in ushort b, ref ushort z)
            => gparts.xor(n256, partcount,partwidth,in a, in b, ref z);

        public static void gparts_xor_32u(int partcount, int partwidth, in uint a, in uint b, ref uint z)
            => gparts.xor(n256, partcount,partwidth,in a, in b, ref z);

        public static void gparts_xor_64u(int partcount, int partwidth, in ulong a, in ulong b, ref ulong z)
            => gparts.xor(n256, partcount,partwidth,in a, in b, ref z);


    }

}