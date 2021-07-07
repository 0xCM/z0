//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Iteratee<T> : IIteratee<T>
        where T : unmanaged
    {
        readonly Action<T,T,T> Receiver;

        [MethodImpl(Inline), Op]
        public Iteratee(Action<T,T,T> receiver)
            => Receiver = receiver;

        [MethodImpl(Inline), Op]
        public void Invoke(T a0, T a1, T a2)
            => Receiver(a0, a1, a2);
    }
}