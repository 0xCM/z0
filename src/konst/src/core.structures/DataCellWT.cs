//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DataCell<W,T>
        where W : unmanaged, IDataWidth
        where T : struct
    {
        public readonly T Content;

        [MethodImpl(Inline)]
        public DataCell(T data)
            => Content = data;

        public uint CellWidth
        {
            [MethodImpl(Inline)]
            get => (uint)Widths.data<W>();
        }
    }
}