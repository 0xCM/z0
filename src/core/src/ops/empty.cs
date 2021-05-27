//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct core
    {
        /// <summary>
        /// Returns a canonical non-null empty value
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T empty<T>()
        {
            if(typeof(T) == typeof(string))
                return generic<T>(EmptyString);
            else if(typeof(T) == typeof(Type))
                return generic<T>(typeof(void));
            else
                return default;
        }
    }
}