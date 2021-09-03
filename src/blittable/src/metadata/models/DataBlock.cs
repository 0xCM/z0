//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct Blit
    {
        partial struct Types
        {
            [StructLayout(LayoutKind.Sequential, Pack=1)]
            public struct DataBlock
            {
                public ByteSize Capacity {get;}

                public BitWidth CellWidth {get;}

                public BlittableKind CellKind {get;}

                [MethodImpl(Inline)]
                public DataBlock(ByteSize capacity, BitWidth cellwidth, BlittableKind cellkind)
                {
                    Capacity = capacity;
                    CellWidth = cellwidth;
                    CellKind = cellkind;
                }
            }
        }
    }
}