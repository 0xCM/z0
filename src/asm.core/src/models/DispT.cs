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

    public readonly struct Disp<T>
        where T : unmanaged
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public Disp(T value)
        {
            Value = value;
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
            => src.Value;
    }
}