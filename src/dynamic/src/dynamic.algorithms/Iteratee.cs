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

    using static SFx;

    public readonly struct Iteratee<T> : IAction<T,T,T>
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

    public struct Iteratee32 : IAction<uint,uint,uint>
    {
        uint A0;

        uint A1;

        uint A2;

        [MethodImpl(Inline)]
        public void Invoke(uint a0, uint a1, uint a2)
        {
            A0 = a1;
            A1 = a1;
            A2 = a2;
        }

        public Triple<uint> Current
        {
            [MethodImpl(Inline)]
            get => triple(A0,A1,A2);
        }
    }
}