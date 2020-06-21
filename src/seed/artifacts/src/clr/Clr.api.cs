//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    [ApiHost]
    public class Clr : IApiHost<Clr>
    {
        /// <summary>
        /// Embeds a clr type descriptor within a parametric data adapter
        /// </summary>
        /// <param name="src">The source property</param>
        /// <typeparam name="T">The adapter parameter</typeparam>
        [MethodImpl(Inline)]
        public static ClrType<T> type<T>(Type src)
            => new ClrType<T>();

        /// <summary>
        /// Embeds a clr property descriptor within a parametric data adapter
        /// </summary>
        /// <param name="src">The source property</param>
        /// <typeparam name="T">The adapter parameter</typeparam>
        [MethodImpl(Inline)]
        public static ClrProperty<T> property<T>(PropertyInfo src)
            => new ClrProperty<T>(src);
 
        public static ClrProperty<T>[] properties<T>(PropertyInfo[] src)
            => src.Select(p => property<T>(p));

    }
}