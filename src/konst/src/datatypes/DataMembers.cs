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

    [ApiHost]
    public readonly struct DataMembers
    {
        /// <summary>
        /// Determines whether a structural value is 'empty':
        /// A structural value is *empty* if, when rendered as an array of bytes, each aelement of the array is zero.
        /// </summary>
        /// <param name="src">The value to adjudicate</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bool empty<T>(in T src)
            where T : struct
        {            
            var x = z.bytes(src);
            var y = z.bytes(default(T));
            var length = y.Length;
            
            if(x.Length != length)
                return false;
            
            for(var i=0u; i<length; i++)
                if(skip(x,i) != 0)
                    return false;
            
            return true;
        }
    }
}