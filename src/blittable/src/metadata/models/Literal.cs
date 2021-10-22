//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitFlow
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct Literal<V>
        {
            public Label Name;

            public V Value;

            [MethodImpl(Inline)]
            public Literal(Label n, V value)
            {
                Name = n;
                Value = value;
            }
        }
    }
}
