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

    [ApiHost]
    public readonly struct LookupTables
    {
        const NumericKind Closure = UnsignedInts;

        public static LookupTable<T> table<T>(ushort rows, ushort cols)
            => new LookupTable<T>((rows,cols), alloc<T>(rows*cols));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LookupTable<T> table<T>(ushort rows, ushort cols, T[] targets)
            => new LookupTable<T>((rows,cols), targets);

        [Op]
        public static string format(LookupKey key)
        {
            const string Pattern = "({0},{1})";
            return string.Format(Pattern, key.Row(), key.Col());
        }

        public static string format<T>(KeyMap<T> src)
        {
            const string Pattern = "({0},{1}) -> {2}";
            return string.Format(Pattern, src.Key.Row(), src.Key.Col(), src.Target);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static KeyMap<T> map<T>(LookupKey src, T dst)
            => new KeyMap<T>(src,dst);

        [Op]
        public static LookupKeys keys(ushort rows, ushort cols)
        {
            var dst = alloc<LookupKey>(rows*cols);
            fill(rows,cols,dst);
            return new LookupKeys((rows,cols),dst);
        }

        [MethodImpl(Inline), Op]
        public static ref readonly LookupKey key(LookupKeys src, ushort row, ushort col)
        {
            var data = src.View;
            var i = offset(src.Dim, row, col);
            return ref skip(data,i);
        }

        [MethodImpl(Inline), Op]
        public static uint offset(GridDim<ushort> dim, ushort row, ushort col)
            => CellCalcs.offset(dim,row,col);

        [MethodImpl(Inline), Op]
        public static uint offset(GridDim<ushort> dim, LookupKey key)
            => CellCalcs.offset(dim,key.Row(), key.Col());

        [MethodImpl(Inline), Op]
        public static ref T value<T>(GridDim<ushort> dim, LookupKey key, Span<T> src)
        {
            var i = offset(dim, key.Row(), key.Col());
            return ref seek(src,i);
        }

        [MethodImpl(Inline), Op]
        public static void fill(ushort rows, ushort cols, Span<LookupKey> dst)
        {
            var dim = new GridDim<ushort>(rows,cols);
            for(var i=0; i<rows; i++)
            for(var j=0; j<cols; j++)
                seek(dst, offset(dim,(ushort)i,(ushort)j)) = LookupKey.define((ushort)i, (ushort)j);
        }
    }
}