//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CliTableIndex
    {
        public readonly CliArtifactKey Key;

        public readonly TableIndex Source;

        [MethodImpl(Inline)]
        public CliTableIndex(CliArtifactKey token, TableIndex src)
        {
            Key = token;
            Source = src;
        }

        public static CliTableIndex Empty
            => default;
    }
}