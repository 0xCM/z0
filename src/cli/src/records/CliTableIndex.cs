//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.CompilerServices;

    using static Part;

    [Record]
    public struct CliTableIndex : IRecord<CliTableIndex>
    {
        public ClrToken Key;

        public TableIndex Source;

        [MethodImpl(Inline)]
        public CliTableIndex(ClrToken token, TableIndex src)
        {
            Key = token;
            Source = src;
        }

        public static CliTableIndex Empty
            => default;
    }
}