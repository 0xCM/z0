//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Hash8 : IHashCode<byte,byte>
    {
        public byte Value {get;}

        [MethodImpl(Inline)]
        public Hash8(byte value)
            => Value = value;

        public byte Primitive
        {
            [MethodImpl(Inline)]
            get => Value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Hash8(byte src)
            => new Hash8(src);

        [MethodImpl(Inline)]
        public static implicit operator Hash<byte,byte>(Hash8 src)
            => new Hash<byte,byte>(src.Value);
    }

    public readonly struct Hash8<T> : IHashCode<T,byte>
        where T : unmanaged
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public Hash8(T value)
            => Value = value;

        public byte Primitive
        {
            [MethodImpl(Inline)]
            get => memory.u8(Value);
        }

        [MethodImpl(Inline)]
        public static implicit operator Hash8(Hash8<T> src)
            => new Hash8(src.Primitive);

        [MethodImpl(Inline)]
        public static implicit operator Hash<T,byte>(Hash8<T> src)
            => new Hash<T,byte>(src.Value);
    }
}