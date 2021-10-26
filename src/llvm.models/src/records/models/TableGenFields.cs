//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.records
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TableGenFields
    {
        public Identifier Id {get;}

        readonly Index<TableGenField> Data;

        [MethodImpl(Inline)]
        public TableGenFields(Identifier id, TableGenField[] src)
        {
            Id = id;
            Data = src;
        }

        public ReadOnlySpan<TableGenField> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}