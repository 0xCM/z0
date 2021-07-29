//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static SdmModels;

    partial struct IntelSdm
    {
        public static Index<TableColumn> columns(ReadOnlySpan<string> src)
            => Tables.columns<ColumnKind>(src);
    }
}