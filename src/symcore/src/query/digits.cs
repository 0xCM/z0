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

    using C = AsciCode;

    partial struct SymbolicQuery
    {
       /// <summary>
        /// Determines whether a span segment consists only of decimal digits
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        [MethodImpl(Inline), Op]
        public static bool digits(Base10 @base, ReadOnlySpan<char> src, uint offset, uint count)
        {
            for(var i=offset; i<count+offset; i++)
            {
                ref readonly var c = ref skip(src,i);
                if(!digit(@base, c))
                    return false;
            }
            return true;
        }
    }

}