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

    public struct Flags<T>
        where T : unmanaged
    {
        T State;

        [MethodImpl(Inline)]
        public Flags(T state)
        {
            State = state;
        }

        public string Format()
        {
            var formatter = BitFormatter.create<T>();
            return formatter.Format(State);
        }

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Flags<T>(T src)
            => new Flags<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(Flags<T> src)
            => src.State;
    }
}