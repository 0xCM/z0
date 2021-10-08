//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RecordDataTypes
    {
        public readonly struct bits : IDataType<bits>
        {
            public readonly uint N;

            [MethodImpl(Inline)]
            public bits(uint n)
            {
                N = n;
            }

            public TypeKind TypeKind
                => TypeKind.Bits;

            public string TypeName
                => string.Format("bits<{0}>", N);
        }
    }
}