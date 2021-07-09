//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Buffers
    {
        [Op]
        static void @check(in BinaryCode src, BufferToken dst)
        {
            var srcSize = src.Length;
            var dstSize = dst.BufferSize;
            if(src.Length > dst.BufferSize)
                Errors.Throw("The buffer is too small");
        }

        [Op]
        static void @check<T>(ReadOnlySpan<T> src, BufferToken dst)
            where T : unmanaged
        {
            var srcSize = src.Length;
            var dstSize = dst.BufferSize;
            if(src.Length > dst.BufferSize)
                Errors.Throw("The buffer is too small");
        }
    }
}