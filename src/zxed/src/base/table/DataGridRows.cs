//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DataGridRows<T>
    {        
        public readonly DataGridRow<T>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator DataGridRows<T>(DataGridRow<T>[] data)
            => new DataGridRows<T>(data);

        [MethodImpl(Inline)]
        public DataGridRows(DataGridRow<T>[] data)
        {
            Data = data;
        }        

        public ref DataGridRow<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref DataGridRow<T> this[int index]
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