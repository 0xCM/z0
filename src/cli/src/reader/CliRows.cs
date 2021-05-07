//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct CliRows
    {
        readonly Index<CliTableKind,Index<Address32>> Data;

        public CliRows(Index<CliTableKind,Index<Address32>> src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public Span<Address32> Edit(CliTableKind table)
            => Data[table].Edit;

        [MethodImpl(Inline)]
        public uint Count(CliTableKind table)
            => Data[table].Count;
    }
}