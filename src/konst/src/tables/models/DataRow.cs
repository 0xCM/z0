//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct DataRow<F,T> : IDataRow<F,T>
        where F : unmanaged
        where T : struct
    {

        public T Data;

        public BinaryCode[] Cells;


        public ref BinaryCode this[F index]
        {
            get => ref Cells[z.u16(index)];
        }

        T IDataRow<F, T>.Data
            => Data;

        BinaryCode[] IDataRow.Cells
            => Cells;
    }
}