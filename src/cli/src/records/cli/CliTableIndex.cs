//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Record]
    public struct CliTableIndex : IRecord<CliTableIndex>
    {
        public CliArtifactKey Key;

        public TableIndex Source;

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