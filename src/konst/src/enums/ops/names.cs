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

    partial class Enums
    {
        /// <summary>
        /// Gets the names of the (unique) enumeration literals
        /// </summary>
        /// <param name="e">An enum type representative</param>
        /// <typeparam name="E">The enum type</typeparam>
         [MethodImpl(NotInline)]
         public static string[] names<E>()
            where E : unmanaged, Enum
                => literals<E>().Map(f => f.ToString());
        
        [MethodImpl(NotInline)]
        public static Z0.EnumNames<E> names2<E>()                   
            where E : unmanaged, Enum
                => new Z0.EnumNames<E>(System.Enum.GetNames(typeof(E)));

        [MethodImpl(NotInline), Op]
        public static Z0.EnumNames names(Type src)                   
            => new Z0.EnumNames(src, System.Enum.GetNames(src));
    }
}