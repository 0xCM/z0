//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial struct MetaRecordKinds
    {
        public readonly struct LiteralRecord  : IMetaRecordKind<LiteralRecord>
        {
            [MethodImpl(Inline)]
            public static implicit operator MetaRecordKind(LiteralRecord src)
                => src.RecordType;

            public MetaRecordKind RecordType => MetaRecordKind.Literal;            
        }
    }
}