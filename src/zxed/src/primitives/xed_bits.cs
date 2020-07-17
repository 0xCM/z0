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
    public struct xed_bits_t
    {
        public uint data;

        [MethodImpl(Inline), Op]
        public static implicit operator uint(xed_bits_t src)
            => src.data;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_bits_t(uint src)
            => new xed_bits_t(src);

        [MethodImpl(Inline), Op]
        public static bool operator true(xed_bits_t src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bool operator false(xed_bits_t src)
            => src == 0;

        [MethodImpl(Inline), Op]
        public xed_bits_t(uint src)
            => data = src;
    }
}