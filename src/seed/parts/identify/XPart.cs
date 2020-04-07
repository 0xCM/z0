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

    public static class XPart
    {
        [MethodImpl(Inline)]
        public static TargetPart<S,T> Target<S,T>(this S src, T dst)        
            where S : struct, IPart
            where T : struct, IPart
                => Part.target(src,dst);

        public static Option<IPart> FindPart(this PartId src)
            => Index.Search(src);


        [MethodImpl(Inline)]
        public static PartId Id(this Assembly src)
            =>  src.GetTag<PartIdAttribute>()?.Id ?? PartId.None;

        static PartIndex Index => DeferredIndex.Value;        

        static Lazy<PartIndex> DeferredIndex {get;} 
            = new Lazy<PartIndex>(Part.index);        

        /// <summary>
        /// Gets the identified assembly attribute if present, otherwise NULL
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="A">The type of attribute for which to search</typeparam>
        static A GetTag<A>(this Assembly a) 
            where A : Attribute
                => (A)System.Attribute.GetCustomAttribute(a, typeof(A));
    }
}