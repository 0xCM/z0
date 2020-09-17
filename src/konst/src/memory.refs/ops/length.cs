//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial struct Refs
    {
        [MethodImpl(Inline), Op]
        public static uint length<T>(Vector128<ulong> src)
        {
            Refs.unpack(vcell(src,1), out var size, out var _);
            return size/scale<T>();
        }
    }
}