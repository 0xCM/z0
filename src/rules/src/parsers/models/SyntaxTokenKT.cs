//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct SyntaxToken<K,T> : ISyntaxToken<K,T>
        where K : unmanaged
    {
        public K Kind {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public SyntaxToken(K kind, T value)
        {
            Kind = kind;
            Value = value;
        }
    }
}