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
    public struct xed_uint64_t
    {
        public ulong data;

        [MethodImpl(Inline), Op]
        public static implicit operator ulong(xed_uint64_t src)
            => src.data;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_uint64_t(ulong src)
            => new xed_uint64_t(src);

        [MethodImpl(Inline), Op]
        public static bool operator true(xed_uint64_t src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bool operator false(xed_uint64_t src)
            => src == 0;

        [MethodImpl(Inline), Op]
        public xed_uint64_t(ulong src)
            => data = src;
    }
}