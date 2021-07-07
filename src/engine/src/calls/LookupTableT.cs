//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = LookupTables;

    public readonly struct LookupTable<T>
    {
        readonly Index<T> Values;

        readonly GridDim<ushort> Dim;

        [MethodImpl(Inline)]
        internal LookupTable(GridDim<ushort> dim, T[] values)
        {
            Dim = dim;
            Require.invariant(values.Length == dim.RowCount * dim.ColCount);
            Values = values;
        }

        [MethodImpl(Inline)]
        public ref T Value(LookupKey key)
            => ref Values[api.offset(Dim,key)];

        [MethodImpl(Inline)]
        public KeyMap<T> Map(LookupKey key)
            => (key,Value(key));

        public ref T this[LookupKey key]
        {
            [MethodImpl(Inline)]
            get => ref Value(key);
        }
    }
}