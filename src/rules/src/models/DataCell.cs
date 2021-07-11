//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct DataCell : IRuleDataType<DataCell>
        {
            public DataWidth Width {get;}

            [MethodImpl(Inline)]
            public DataCell(DataWidth width)
            {
                Width = width;
            }
        }
    }
}