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

    [Datatype]
    public struct Sequential<T> : IDataType<T>
        where T : unmanaged
    {
        const ulong Step = 1;

        public T Value;

        [MethodImpl(Inline)]
        public Sequential(T src)
            => Value = src;

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString();

        public void Increment()
        {
            ref var x = ref @as<T,ulong>(Value);
            x += Step;
        }

        public void Decrement()
        {
            ref var x = ref @as<T,ulong>(Value);
            x -= Step;
        }

        [MethodImpl(Inline)]
        public static Sequential<T> operator ++(Sequential<T> src)
        {
            src.Increment();
            return src;
        }

        [MethodImpl(Inline)]
        public static Sequential<T> operator --(Sequential<T> src)
        {
            src.Decrement();
            return src;
        }

        [MethodImpl(Inline)]
        public static implicit operator Sequential<T>(T src)
            => new Sequential<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(Sequential<T> src)
            => src.Value;
    }
}