//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableRows<T>
        where T : ITable
    {        
        public readonly TableRow<T>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator TableRows<T>(TableRow<T>[] data)
            => new TableRows<T>(data);

        [MethodImpl(Inline)]
        public TableRows(TableRow<T>[] data)
        {
            Data = data;
        }        

        public ref TableRow<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref TableRow<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }
    }
}