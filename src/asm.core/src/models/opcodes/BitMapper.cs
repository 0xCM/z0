//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct BitMappers
    {
        public static BitMapper<K,T> define<K,T>(Symbols<K> symbols)
            where K : unmanaged
            where T : unmanaged
        {
            var count = symbols.Length;
            var buffer = alloc<BitMap<K,T>>(count);
            var symview = symbols.View;
            ref var dst = ref first(buffer);
            for(byte i=0; i<count; i++)
            {
                ref readonly var k = ref skip(symview,i);
                ref var map = ref seek(dst,i);
                kseek(dst, k.Kind).Index = k.Kind;
                kseek(dst, k.Kind).Bits = @as<T>(Pow2.pow(i));
            }
            return new BitMapper<K,T>(buffer);
        }

        [Op]
        public static Index<byte> serialize<K,T>(BitMapper<K,T> src)
            where K : unmanaged
            where T : unmanaged
        {
            var points = src.Points;
            var count = points.Length;
            var ksize = size<K>()*count;
            var tsize = size<T>()*count;
            var buffer = alloc<byte>(ksize + tsize);
            var lo = recover<K>(slice(span(buffer),0,size<K>()*count));
            var hi = recover<T>(slice(span(buffer), ksize, tsize));
            var j=0;
            for(var i=0; i<count; i++)
            {
                ref readonly var point = ref seek(points,i);
                seek(lo,i) = point.Index;
                seek(hi,i) = point.Bits;
            }

            return buffer;
        }
    }

    public readonly struct BitMapper<I,T>
        where I : unmanaged
        where T : unmanaged
    {
        readonly Index<I,BitMap<I,T>> Storage;

        public BitMapper(BitMap<I,T>[] maps)
        {
            Storage = maps;
        }

        [MethodImpl(Inline)]
        public ref BitMap<I,T> Map(I index)
            => ref Storage[index];

        public ref BitMap<I,T> this[I index]
        {
            [MethodImpl(Inline)]
            get => ref Map(index);
        }

        public Span<BitMap<I,T>> Points
        {
            [MethodImpl(Inline)]
            get => Storage.Edit;
        }

        public uint PointCount
        {
            [MethodImpl(Inline)]
            get => Storage.Count;
        }
    }
}