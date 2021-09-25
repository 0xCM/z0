//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct SyntaxToken<K> : ISyntaxToken<K>
        where K : unmanaged
    {
        public K Kind {get;}

        [MethodImpl(Inline)]
        public SyntaxToken(K kind)
        {
            Kind = kind;
        }
    }
}