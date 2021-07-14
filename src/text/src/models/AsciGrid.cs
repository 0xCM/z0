//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsciGrid
    {
        readonly AsciSequence Data;

        public uint RowCount {get;}

        public ushort RowWidth {get;}

        public AsciGrid(AsciSequence data, uint count, ushort width)
        {
            Data = data;
            RowCount = count;
            RowWidth = width;
        }

        public ReadOnlySpan<byte> Rows
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Row(ushort index)
            => text.row(this,index);

        public string Format()
            => Data.Format();

        public override string ToString()
            => Format();
    }
}