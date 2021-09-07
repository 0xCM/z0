//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct Literal<V>
        {
            public Name Name;

            public LiteralKind Kind;

            public V Value;

            [MethodImpl(Inline)]
            public Literal(Name n, LiteralKind kind, V value)
            {
                Name = n;
                Kind = kind;
                Value = value;
            }
        }
    }
}
