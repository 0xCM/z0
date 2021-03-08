//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Record(TableId)]
    public struct CilRow : IRecord<CilRow>
    {
        public const string TableId = "cil.data";

        public MemoryAddress BaseAddress;

        public OpUri Uri;

        public BinaryCode CilCode;
    }
}