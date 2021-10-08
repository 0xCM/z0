//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Grammars;

    public readonly struct Atom<T> : ITerm<T>
        where T : unmanaged
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public Atom(T src)
        {
            Value = src;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public static implicit operator Atom<T>(T src)
            => new Atom<T>(src);
    }
}