//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Scope<T>
    {
        public T Name {get;}

        [MethodImpl(Inline)]
        public Scope(T name)
        {
            Name = name;
        }

        [MethodImpl(Inline)]
        public static implicit operator Scope<T>(T src)
            => new Scope<T>(src);
    }
}