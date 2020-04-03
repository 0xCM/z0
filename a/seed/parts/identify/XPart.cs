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
        public static string Format(this PartId id)
        {
            const string TestSuffix = ".test";
            const string SvcSuffix = ".svc";
            const string BaseSuffix = "";

            var @base = id.Base();
            var dst = @base.ToString().ToLower();
                        
            if(id.IsTest())
                return dst + TestSuffix;
            else if(id.IsSvc())
                return dst + SvcSuffix;
            else
                return dst + BaseSuffix;
        }

        [MethodImpl(Inline)]
        public static string Format(this ExternId id)
            => id.ToString().ToLower();        

        [MethodImpl(Inline)]
        public static bool IsTest(this PartId a)
            => (a & PartId.Test) != 0;

        [MethodImpl(Inline)]
        public static bool IsSvc(this PartId a)
            => (a & PartId.Svc) != 0;

        [MethodImpl(Inline)]
        public static PartId WithoutTest(this PartId a)
            => a & ~ PartId.Test;

        [MethodImpl(Inline)]
        public static PartId WithTest(this PartId a)
            => a | PartId.Test;

        [MethodImpl(Inline)]
        public static PartId WithoutSvc(this PartId a)
            => a & ~ PartId.Svc;

        [MethodImpl(Inline)]
        public static PartId WithSvc(this PartId a)
            => a | PartId.Svc;

        [MethodImpl(Inline)]
        public static PartId Base(this PartId a)
            => a.WithoutSvc().WithoutTest();

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