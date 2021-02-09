//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct DataCell : IDataType<DataCell>
    {
        public DataWidth Width {get;}

        [MethodImpl(Inline)]
        public DataCell(DataWidth width)
        {
            Width = width;
        }
    }
}