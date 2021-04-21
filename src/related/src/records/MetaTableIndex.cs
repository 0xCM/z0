//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    partial struct Images
    {
        [Record]
        public struct MetaTableIndex : IRecord<MetaTableIndex>
        {
            public ClrToken Key;

            public TableIndex Source;

            [MethodImpl(Inline)]
            public MetaTableIndex(ClrToken token, TableIndex src)
            {
                Key = token;
                Source = src;
            }

            public static MetaTableIndex Empty
                => default;
        }
    }
}