//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Mem : IMemory
    {
        readonly byte[] Cells;

        public DataWidth Width {get;}

        [MethodImpl(Inline)]
        public Mem(byte[] data)
        {
            Cells = data;
            Width = (DataWidth)(data.Length * 8);
        }

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => Cells;
        }        
    }
}