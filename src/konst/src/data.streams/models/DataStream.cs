//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public ref struct DataStream<I,T>
    {
        Span<T> Data;

        ulong Pos;

        ulong Count;

        [MethodImpl(Inline)]
        public DataStream(Span<T> src)
        {
            Data = src;
            Pos = 0;
            Count = (ulong)src.Length;
        }

        [MethodImpl(Inline)]
        public ref readonly T Next()
        {
            if(Pos >= Count)
                Pos = 0;

            return ref skip(Data, Pos++);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> TryRead(I wanted, out I actual)
        {
            var length = uint64(wanted);
            if(Pos + length < Count)
            {
                var take = slice(Data, Pos, Count);
                actual = wanted;
                Pos += Count;
                return take;
            }
            else
            {
                var available = Count - Pos;
                var take = slice(Data,Pos, available);
                actual = @as<ulong,I>(available);
                Pos = 0;
                return take;
            }
        }
    }
}