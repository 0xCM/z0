//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class XTend
    {
        public static Z Zero<Z>(this Zed z)
            where Z : INullary<Z>, new()
                => new Z();                

        /// <summary>
        /// Gets the identified assembly attribute if present, otherwise NULL
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="A">The type of attribute for which to search</typeparam>
        static A GetTag<A>(this Assembly a) 
            where A : Attribute
                => (A)System.Attribute.GetCustomAttribute(a, typeof(A));


        [MethodImpl(Inline)]
        public static PartId Id(this Assembly src)
            =>  src.GetTag<PartIdAttribute>()?.Id ?? PartId.None;

    }
}