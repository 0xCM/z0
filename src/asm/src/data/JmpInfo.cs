//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static Konst;
    using static z;

    public struct JmpInfo
    {
        public const byte FieldCount = 7;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{16,16,16,16,16,16,32};

        public MemoryAddress Base;

        public MemoryAddress Source;

        public ByteSize FxSize;

        public MemoryAddress CallSite;

        public MemoryAddress Target;

        public JmpKind Kind;

        public string Asm;
    }

}