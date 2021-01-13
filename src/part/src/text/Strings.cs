//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost(ApiNames.Strings, true)]
    public readonly struct Strings
    {
        const NumericKind Closure = UnsignedInts;

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