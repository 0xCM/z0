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

    public ref struct StateBuffer<T>
        where T : unmanaged
    {
        readonly Span<T> States;

        [MethodImpl(Inline)]
        public StateBuffer(uint count)
            => States = alloc<T>(count);

        [MethodImpl(Inline)]
        public StateBuffer(T[] states)
            => States = states;

        public ref T this[T index]
        {
            [MethodImpl(Inline)]
            get => ref seek(States, z.@as<T,uint>(index));
        }
    }
}