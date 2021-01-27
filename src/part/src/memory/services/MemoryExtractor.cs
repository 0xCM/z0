//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines *core* memory extraction operations
    /// </summary>
    [ApiHost]
    public unsafe readonly struct MemoryExtractor
    {
        const int MaxZeroCount = 10;

        [MethodImpl(Inline), Op]
        public static int extract(MemoryAddress src, Span<byte> dst, int? count = null)
        {
            var pSrc = src.Pointer<byte>();
            var limit = count ?? dst.Length;
            return read(ref pSrc, limit, dst);
        }

        [MethodImpl(Inline), Op]
        public static int extract(MemoryAddress src, ref byte dst, int count)
        {
            var pSrc = memory.pointer(ref dst);
            return read(ref pSrc, count, ref dst);
        }

        [MethodImpl(Inline), Op]
        static int read(ref byte* pSrc, int count, Span<byte> dst)
            => read(ref pSrc, count, ref memory.first(dst));

        [MethodImpl(Inline), Op]
        static int read(ref byte* pSrc, int limit, ref byte dst)
        {
            var offset = 0;
            var count = 0;
            while(offset < limit && count < MaxZeroCount)
            {
                var value = Unsafe.Read<byte>(pSrc++);
                memory.seek(dst, offset++) = value;
                if(value != 0)
                    count = 0;
                else
                    count++;
            }
            return offset;
        }
    }
}