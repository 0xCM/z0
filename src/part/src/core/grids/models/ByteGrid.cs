//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public sealed class ByteGrid : Grid<byte>
    {
        public ByteGrid(GridDim dim)
            : base(dim)
        {

        }

        [MethodImpl(Inline)]
        public ByteGrid(GridDim dim, byte[] storage)
            : base(dim, storage)
        {

        }
    }
}