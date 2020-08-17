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

    partial struct Structures
    {
        /// <summary>
        /// Determines whether at least one byte of a structural value is nonzero
        /// </summary>
        /// <param name="src">The value to evaluate</param>
        /// <typeparam name="T">The structure type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bool nonempty<T>(in T src)
            where T : struct
        {
            ref var data = ref @as<T,byte>(src);
            var count = size<T>();
            for(var i=0u; i<count; i++)
                if(skip(data,i) != 0)
                    return true;
            return false;
        }       
    }
}