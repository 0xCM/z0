//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.Strings, true)]
    public readonly struct Strings
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static StringLookup lookup(ReadOnlySpan<StringRef> src)
            => new StringLookup(src);

        [MethodImpl(Inline), Op]
        public static StringTableCell cell(string data)
            => data;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static StringTableCell<T> cell<T>(in T data)
            => data;

        [MethodImpl(Inline), Op]
        public static StringTable table(string name, TableHeader header, StringTableRow[] rows)
            => new StringTable(name, header,rows);

        [MethodImpl(Inline), Op]
        public static StringTable table(string name, HeaderCell[] cells, StringTableRow[] rows)
            => new StringTable(name, cells, rows);


        [MethodImpl(Inline), Op]
        public static StringIndex index(params string[] src)
            => new StringIndex(src.Select(z.hash), src);

        [Op]
        public static KeyedValues<uint,string> pairs(in StringIndex src)
            => pairs(src,sys.alloc<KeyedValue<uint,string>>(src.Count));

        [MethodImpl(Inline), Op]
        public static KeyedValues<uint,string> pairs(in StringIndex src, KeyedValue<uint,string>[] buffer)
        {
            var keys = @readonly(src.Keys);
            var values = @readonly(src.Values);
            var count = keys.Length;
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = z.kvp(skip(keys,i), skip(values,i));
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static string value(in StringIndex src, uint key)
        {
            value(src,key, out var s);
            return s;
        }

        [MethodImpl(Inline), Op]
        public static uint index(in StringIndex src, uint key)
        {
            var keys = @readonly(src.Keys);
            var values = @readonly(src.Values);
            var count = keys.Length;
            for(var i=0u; i<count; i++)
                if(skip(keys,i) == key)
                    return i;

            return uint.MaxValue;
        }

        [MethodImpl(Inline), Op]
        public static bool value(in StringIndex src, uint key, out string value)
        {
            var keys = @readonly(src.Keys);
            var values = @readonly(src.Values);
            var count = keys.Length;
            var ix = index(src,key);
            if(ix != uint.MaxValue)
                value = skip(values,ix);
            else
                value = EmptyString;
            return false;
        }

        [MethodImpl(Inline), Op]
        public static ref StringTable fill(StringTableRow[] src, ref StringTable dst)
        {
            dst.Fill(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref StringTableRow fill(StringTableCell[] src, ref StringTableRow dst)
        {
            dst.Fill(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref StringTableCell fill(in string src, ref StringTableCell dst)
        {
            dst.Fill(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref StringTableCell<T> fill<T>(in T src, ref StringTableCell<T> dst)
        {
            dst.Fill(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref StringTableCells<T> fill<T>(StringTableCell<T>[] src, ref StringTableCells<T> dst)
        {
            dst.Fill(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref StringTableRows<T> Fill<T>(StringTableRow<T>[] src, ref StringTableRows<T> dst)
        {
            dst.Fill(src);
            return ref dst;
        }
    }
}