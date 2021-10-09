//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct ClassRelations : IRecordRelations<ClassRelations>
    {
        public const string TableId = "llvm.classes.relations";

        public const byte FieldCount = 3;

        public LineNumber SourceLine;

        public Identifier Name;

        public Lineage Ancestors;

        LineNumber IRecordRelations<ClassRelations>.SourceLine
            => SourceLine;

        Identifier IRecordRelations<ClassRelations>.Name
            => Name;

        Lineage IRecordRelations<ClassRelations>.Ancestors
            => Ancestors;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{14,64,1};
    }
}