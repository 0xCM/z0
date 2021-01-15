//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Text;

    using static Part;
    using static memory;

    [ApiHost(ApiNames.Strings, true)]
    public readonly struct Strings
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Creates a new stringbuilder
        /// </summary>
        public static StringBuilder build()
            => EmptyString.Build();

        [MethodImpl(Inline), Op]
        public static string value(in StringIndex src, uint key)
        {
            value(src,key, out var s);
            return s;
        }

        [MethodImpl(Inline), Op]
        public static uint index(in StringIndex src, uint key)
        {
            var keys = src.Keys.View;
            var values = src.Values.View;
            var count = keys.Length;
            for(var i=0u; i<count; i++)
                if(skip(keys,i) == key)
                    return i;

            return uint.MaxValue;
        }

        [MethodImpl(Inline), Op]
        public static bool value(in StringIndex src, uint key, out TextBlock value)
        {
            var keys = src.Keys.View;
            var values = src.Values.View;
            var count = keys.Length;
            var ix = index(src,key);
            if(ix != uint.MaxValue)
                value = skip(values,ix);
            else
                value = TextBlock.Empty;
            return false;
        }

        /// <summary>
        /// Concatenates a sequence of characters with no intervening delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        [MethodImpl(Inline), Op]
        public static string concat(IEnumerable<char> src)
            => string.Concat(src);

        [Op]
        public static string concat(ReadOnlySpan<string> src, char? delimiter)
        {
            var dst = text.build();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0 && delimiter != null)
                    dst.Append(delimiter.Value);
                dst.Append(src[i]);
            }
            return dst.ToString();
        }

        [Op]
        public static string concat(ReadOnlySpan<string> src, string delimiter)
        {
            var dst = text.build();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0 && delimiter != null)
                    dst.Append(delimiter);
                dst.Append(src[i]);
            }
            return dst.ToString();
        }
    }
}