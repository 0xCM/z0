//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public ref struct NumericBits<T,S,I>
        where T : unmanaged
        where S : unmanaged
        where I : unmanaged
    {
        readonly ReadOnlySpan<byte> Positions;

        readonly ReadOnlySpan<byte> Widths;

        T Data;

        [MethodImpl(Inline)]
        public NumericBits(T data, ReadOnlySpan<byte> positions, ReadOnlySpan<byte> widths)
        {
            Data = data;
            Positions = positions;
            Widths = widths;
        }

        public T Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref readonly T Update(in T src)
        {
            Data = src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public S Read(I index)
            => @as<T,S>(gbits.extract(Data, Position(index), Width(index)));

        [MethodImpl(Inline)]
        public void Write(I index, S value)
            => Data = gbits.copy(@as<S,T>(value), Position(index), Width(index), Data);

        [MethodImpl(Inline)]
        public ref readonly byte Position(in I index)
            => ref skip(Positions, bw8(index));

        [MethodImpl(Inline)]
        public ref readonly byte Width(in I index)
            => ref skip(Widths, bw8(index));

        public S this[I index]
        {
            [MethodImpl(Inline)]
            get => Read(index);

            [MethodImpl(Inline)]
            set => Write(index, value);
        }
    }
}