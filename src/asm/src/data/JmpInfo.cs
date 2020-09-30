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
        public const string RenderPattern = "{0,-16} | {1,-16} | {2,-16} | {3,-16} | {4,-16} | {5,-16:g} | {6,-32}";

        public MemoryAddress Base;

        public MemoryAddress Source;

        public ByteSize FxSize;

        public MemoryAddress CallSite;

        public MemoryAddress Target;

        public JmpKind Kind;

        public string Asm;
    }
}