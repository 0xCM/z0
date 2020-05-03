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
    
    using static Reflective;

    [ApiHost]
    public class Clr : IApiHost<Clr>
    {
        /// <summary>
        /// Embeds a clr type descriptor within a parametric data adapter
        /// </summary>
        /// <param name="src">The source property</param>
        /// <typeparam name="T">The adapter parameter</typeparam>
        [MethodImpl(Inline)]
        public static TypeData<T> data<T>(Type src)
            => new TypeData<T>(src);

        /// <summary>
        /// Embeds a clr property descriptor within a parametric data adapter
        /// </summary>
        /// <param name="src">The source property</param>
        /// <typeparam name="T">The adapter parameter</typeparam>
        [MethodImpl(Inline)]
        public static PropertyData<T> data<T>(PropertyInfo src)
            => new PropertyData<T>(src);

        public static IEnumerable<TypeData<T>> data<T>(IEnumerable<TypeInfo> src)
            => src.Select(p => data<T>(p));
 
        public static PropertyData<T>[] data<T>(PropertyInfo[] src)
            => src.Select(p => data<T>(p));
    
        public static IEnumerable<PropertyData<T>> data<T>(IEnumerable<PropertyInfo> src)
            => src.Select(p => data<T>(p));
    }
}