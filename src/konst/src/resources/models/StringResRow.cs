//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    using api = Resources;

    [StructLayout(LayoutKind.Sequential)]
    public struct StringResRow : ITextual
    {
        public const string RenderPattern = "{0} | {1} | {2}";

        public CliToken Id;

        public MemoryAddress Address;

        public uint Length;

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}