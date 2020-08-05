//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Rows<T>
    {        
        public readonly Row<T>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator Rows<T>(Row<T>[] data)
            => new Rows<T>(data);

        [MethodImpl(Inline)]
        public Rows(Row<T>[] data)
        {
            Data = data;
        }        

        public ref Row<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref Row<T> this[int index]
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