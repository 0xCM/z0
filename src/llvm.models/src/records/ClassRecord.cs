//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    [Record]
    public struct ClassRecord
    {
        public const string TableId = "llvm.classes";

        public const byte FieldCount = 3;

        public LineNumber Offset;

        public Identifier Name;

        public TextBlock Ancestors;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{12,64,1};
    }
}