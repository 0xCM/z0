//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Reads up to 64 bits from a source value and presents the result as a <see cref='long'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op]
        public static long signed<T>(T src)
        {
            if(size<T>() == 1)
                return i8(src);
            else if(size<T>() == 2)
                return i16(src);
            else if(size<T>() == 4)
                return i32(src);
            else
                return i64(src);
        }
    }
}