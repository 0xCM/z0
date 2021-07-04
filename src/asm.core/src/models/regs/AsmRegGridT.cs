//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmRegGrid<K>
        where K : unmanaged
    {
        readonly AsciSequence _Data;

        public ushort RowCount {get;}

        [MethodImpl(Inline)]
        public AsmRegGrid(AsciSequence src, ushort rows)
        {
            _Data = src;
            RowCount = rows;
        }

        public ReadOnlySpan<byte> Rows
        {
            [MethodImpl(Inline)]
            get => _Data.View;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Row(ushort index)
            => AsmRegGrids.row(this,index);

        public string Format()
            => _Data.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmRegGrid(AsmRegGrid<K> src)
            => new AsmRegGrid(src._Data, src.RowCount);
    }
}