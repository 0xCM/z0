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
    public readonly struct LineCounts
    {
        [MethodImpl(Inline)]
        static bit match(byte a, byte b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static uint count(ReadOnlySpan<byte> src)
        {
            const byte CR = (byte)AsciControlCode.CR;
            var size = src.Length;
            var counter = 0u;
            for(var i=0; i<size; i++)
                counter += (uint)match(skip(src,i),CR);
            return counter;
        }

        [Op]
        public static LineCount count(FS.FilePath src)
        {
            using var file = MemoryFiles.map(src);
            return (src, count(file.View()));
        }

        [Op]
        public static Index<LineCount> count(ReadOnlySpan<FS.FilePath> src)
        {
            var dst = bag<LineCount>();
            iter(src, path => dst.Add(count(path)), true);
            return dst.ToArray().Sort();
        }
    }
}