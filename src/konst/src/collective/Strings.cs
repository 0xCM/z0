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

    }
}