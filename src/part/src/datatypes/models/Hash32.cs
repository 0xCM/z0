//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Hash32 : IHashCode<uint,uint>
    {
        public uint Value {get;}

        [MethodImpl(Inline)]
        public Hash32(uint value)
            => Value = value;

        public uint Primitive
        {
            [MethodImpl(Inline)]
           get => Value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Hash32(uint src)
            => new Hash32(src);
    }

    public readonly struct Hash32<T> : IHashCode<T,uint>
        where T : unmanaged
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public Hash32(T value)
            => Value = value;

        public uint Primitive
        {
            [MethodImpl(Inline)]
            get => memory.u32(Value);
        }

        [MethodImpl(Inline)]
        public static implicit operator Hash32(Hash32<T> src)
            => new Hash32(src.Primitive);
    }
}