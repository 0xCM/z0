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

    public struct StateBuffer<I,T>
        where T : unmanaged
    {
        readonly IndexedSeq<T> States;

        [MethodImpl(Inline)]
        public StateBuffer(uint count)
            => States = alloc<T>(count);

        [MethodImpl(Inline)]
        public StateBuffer(T[] states)
            => States = states;

        public ref T this[I index]
        {
            [MethodImpl(Inline)]
            get => ref States[@as<I,uint>(index)];
        }
    }
}