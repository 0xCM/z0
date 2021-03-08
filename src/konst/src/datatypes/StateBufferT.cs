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

    public struct StateBuffer<T>
        where T : unmanaged
    {
        readonly Index<T> States;

        [MethodImpl(Inline)]
        public StateBuffer(uint count)
            => States = alloc<T>(count);

        [MethodImpl(Inline)]
        public StateBuffer(T[] states)
            => States = states;

        public ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref States[index];
        }
    }
}