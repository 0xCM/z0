//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct DataCell
    {
        public DataWidth Width {get;}

        [MethodImpl(Inline)]
        public DataCell(DataWidth width)
        {
            Width = width;
        }
    }
}