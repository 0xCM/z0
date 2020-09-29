//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public struct xed_int64_t
    {
        public long data;

        [MethodImpl(Inline), Op]
        public static implicit operator long(xed_int64_t src)
            => src.data;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_int64_t(long src)
            => new xed_int64_t(src);

        [MethodImpl(Inline), Op]
        public static bool operator true(xed_int64_t src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bool operator false(xed_int64_t src)
            => src == 0;

        [MethodImpl(Inline), Op]
        public xed_int64_t(long src)
            => data = src;
    }
}