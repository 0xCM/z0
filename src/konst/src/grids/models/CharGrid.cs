//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public sealed class CharGrid : Grid<char>
    {
        public CharGrid(GridDim dim)
            : base(dim)
        {

        }

        [MethodImpl(Inline)]
        public CharGrid(GridDim dim, char[] storage)
            : base(dim,storage)
        {

        }
    }
}