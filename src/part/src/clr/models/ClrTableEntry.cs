//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata.Ecma335;

    using static Root;

    public struct ClrTableEntry : IRecord<ClrTableEntry>
    {
        public CliToken Token;

        public TableIndex Table;

        [MethodImpl(Inline)]
        public ClrTableEntry(CliToken token, TableIndex src)
        {
            Token = token;
            Table = src;
        }

        public static ClrTableEntry Empty
        {
            get
            {
                var dst = new ClrTableEntry();
                dst.Token = default;
                dst.Table = (TableIndex)byte.MaxValue;
                return dst;
            }
        }
    }
}