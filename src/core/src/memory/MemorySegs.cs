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

    [ApiHost]
    public readonly struct MemorySegs
    {
        [Op]
        public static void materialize(ReadOnlySpan<SegRef> src, Span<byte> dst, byte? delimiter = null)
        {
            var m = src.Length;
            var n = dst.Length;
            var o = 0u;
            var d = delimiter ?? 0;
            for(var i=0u; i<m; i++)
            {
                var c = skip(src,i).Edit;
                var p = c.Length;

                for(var j=0u; j<p && o<n; j++, o++)
                    seek(dst,o) = skip(c,j);

                if(delimiter != null)
                    seek(dst, ++o) = d;
            }
        }

        /// <summary>
        /// Defines a memory <see cref='MemorySeg'/> with a specified base and size
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="bytes">The number of reference bytes</param>
        [MethodImpl(Inline), Op]
        public static MemorySeg define(MemoryAddress @base, ByteSize bytes)
            => new MemorySeg(@base,bytes);

        /// <summary>
        /// Defines a memory <see cref='MemorySeg'/> over source span content
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public unsafe static MemorySeg define(ReadOnlySpan<byte> src)
            => define((ulong)gptr(src), src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe MemorySeg define(string src)
            => define(pchar(src), (uint)src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe MemorySeg define(char* src, uint count)
            => new MemorySeg(address(src), count*2);
    }
}