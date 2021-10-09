//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    [Record(TableId)]
    public struct DefRelations : IRecordRelations<DefRelations>
    {
        public const string TableId = "llvm.defs.relations";

        public const byte FieldCount = 3;

        public LineNumber SourceLine;

        public Identifier Name;

        public Lineage Ancestors;

       LineNumber IRecordRelations<DefRelations>.SourceLine
            => SourceLine;

        Identifier IRecordRelations<DefRelations>.Name
            => Name;

        Lineage IRecordRelations<DefRelations>.Ancestors
            => Ancestors;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{14,64,1};
    }
}