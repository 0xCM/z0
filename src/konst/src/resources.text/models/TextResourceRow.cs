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
    using static z;

    using api = TextResources;

    [StructLayout(LayoutKind.Sequential)]
    public struct TextResourceRow : ITextual
    {
        public const string RenderPattern = "{0} | {1} | {2}";

        public ClrArtifactKey Id;

        public MemoryAddress Address;

        public uint Length;

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}