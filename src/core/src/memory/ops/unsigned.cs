//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        /// <summary>
        /// Reads up to 64 bits from a source value and presents the result as a <see cref='ulong'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op]
        public static ulong unsigned<T>(T src)
        {
            if(size<T>() == 1)
                return u8(src);
            else if(size<T>() == 2)
                return u16(src);
            else if(size<T>() == 4)
                return u32(src);
            else
                return u64(src);
        }
    }
}