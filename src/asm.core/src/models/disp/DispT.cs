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

    public readonly struct Disp<T> : IDisplacement
        where T : unmanaged, IDisplacement<T>
    {
        public T Source {get;}

        [MethodImpl(Inline)]
        public Disp(T src)
        {
            Source = src;
        }

        public uint Value
        {
            [MethodImpl(Inline)]
            get => bw32(Source.Value);
        }

        public byte Width
        {
            [MethodImpl(Inline)]
            get => Source.Width;
        }

        [MethodImpl(Inline)]
        public static implicit operator Disp<T>(byte src)
            => new Disp<T>(@as<byte,T>(src));

        [MethodImpl(Inline)]
        public static implicit operator Disp<T>(Disp8 src)
            => new Disp<T>(@as<byte,T>(src.Value));

        [MethodImpl(Inline)]
        public static implicit operator Disp<T>(ushort src)
            => new Disp<T>(@as<ushort,T>(src));

        [MethodImpl(Inline)]
        public static implicit operator Disp<T>(Disp16 src)
            => new Disp<T>(@as<ushort,T>(src.Value));

        [MethodImpl(Inline)]
        public static implicit operator Disp<T>(uint src)
            => new Disp<T>(@as<uint,T>(src));

        [MethodImpl(Inline)]
        public static implicit operator Disp<T>(Disp32 src)
            => new Disp<T>(@as<uint,T>(src.Value));

        [MethodImpl(Inline)]
        public static implicit operator T(Disp<T> src)
            => src.Source;
    }
}