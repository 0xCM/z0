//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using Z0;
    using static Z0.Root;

    namespace generic
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct literal<V>
        {
            public name Name;

            public LiteralKind Kind;

            public V Value;

            [MethodImpl(Inline)]
            public literal(name n, LiteralKind kind, V value)
            {
                Name = n;
                Kind = kind;
                Value = value;
            }
        }
    }
}