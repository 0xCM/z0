//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    public struct ClassRecord
    {
        public const string TableId = "llvm.classes";

        public const byte FieldCount = 4;

        public LlvmDatasetKind Dataset;

        public LineNumber Offset;

        public Identifier Name;

        public TextBlock Ancestors;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{22,12,64,1};
    }
}