//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public sealed class AsciCodeGrid : Grid<AsciCharCode>
    {
        public AsciCodeGrid(GridDim dim)
            : base(dim)
        {

        }

        [MethodImpl(Inline)]
        public AsciCodeGrid(GridDim dim, AsciCharCode[] storage)
            : base(dim,storage)
        {

        }
    }
}