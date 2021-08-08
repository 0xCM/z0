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

    partial struct Blit
    {
        partial struct Factory
        {
            [MethodImpl(Inline), Op]
            public static name128 name(W128 w, ReadOnlySpan<char> src)
            {
                const byte Max = name128.MaxLength;
                var length = (byte)min(available(src), Max);
                var storage = Cell128.Empty;
                var dst = storage.Bytes;
                pack(src, length, dst);
                seek(dst,15) = length;
                return new name128(storage);
            }

            [MethodImpl(Inline), Op]
            public static name64 name(W64 w, ReadOnlySpan<char> src)
            {
                const byte Max = name64.MaxLength;
                var length = (byte)min(available(src), Max);
                var storage = 0ul;
                var dst = bytes(storage);
                pack(src, length, dst);
                seek(dst,7) = length;
                return new name64(storage);
            }

            [MethodImpl(Inline),Op, Closures(Closure)]
            public static uint names<T>(in Symbols<T> src, Span<name64> dst)
                where T : unmanaged
            {
                var count = (uint)min(src.Length, dst.Length);
                var symbols = src.View;
                for(var i=0; i<count; i++)
                {
                    ref readonly var symbol = ref skip(symbols,i);
                    var data = symbol.Expr.Data;
                    seek(dst, i) = name(w64, data);
                }
                return count;
            }

            [MethodImpl(Inline), Op]
            static uint available(ReadOnlySpan<char> src)
            {
                var present = 0u;
                var count = src.Length;
                for(var i=0; i<count; i++)
                {
                    if(skip(src,i) != 0)
                        present++;
                    else
                        break;
                }
                return present;
            }

            [MethodImpl(Inline), Op]
            static void pack(ReadOnlySpan<char> src, uint count, Span<byte> dst)
            {
                for(var i=0; i<count; i++)
                    seek(dst,i) = (byte)skip(src,i);
            }
        }
   }
}