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
        public struct ScalarType
        {
            public readonly ScalarKind Kind;

            public readonly uint StorageSize;

            public readonly uint DataWidth;

            [MethodImpl(Inline)]
            public ScalarType(ScalarKind kind, uint s, uint w)
            {
                Kind = kind;
                StorageSize = s;
                DataWidth = w;
            }
        }
    }
}
