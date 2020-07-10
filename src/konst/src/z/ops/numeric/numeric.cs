//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                        
        /// <summary>
        /// Unconditionally casts from one numeric kind to another
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <typeparam name="S">The source numeric kind</typeparam>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]   
        public static T numeric<S,T>(S src)
            => Cast.numeric_u<S,T>(src);
    }
}