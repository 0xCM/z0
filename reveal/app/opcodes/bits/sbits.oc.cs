//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class sbitsoc
    {

        public static uint pack32x1(ConstBlock256<byte> src)
            => Bits.pack8x1(src);

    }

}