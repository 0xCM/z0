//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Linq;
    
    using static Seed;

    public static class PartIdOps
    {
        [MethodImpl(Inline)]
        public static TargetPart<S,T> Target<S,T>(this S src, T dst = default)        
            where S : struct, IPartId<S>
            where T : struct, IPartId<T>
                => Part.target(src,dst);

        public static IPartId AsType(this PartId src)
        {            
            if(PartIndex.TryGetValue(src, out var part))
                return part;
            else
                return Part.Empty;
        }

        [MethodImpl(Inline)]
        public static bool IsEmpty<P>(this P src)
            where P : struct, IPartId<P>
                => src.Id == 0;

        [MethodImpl(Inline)]
        public static bool IsEmpty(this IPartId src)
            => src.Id == 0;


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

        static ConcurrentDictionary<PartId, IPartId> PartIndex
            => PartIndexData.Value;

        static ConcurrentDictionary<PartId, IPartId> CreatePartIndex()
        {
            var index = new ConcurrentDictionary<PartId, IPartId>();
            try
            {
                var parts = typeof(PartIdentity).GetNestedTypes().Select(t => (IPartId)Activator.CreateInstance(t));
                var pairs = parts.Select(p => (p.Id, p));
                foreach(var p in parts)            
                    index.TryAdd(p.Id,p);
            }
            catch(Exception e)
            {
                Console.Error.WriteLine(e);
            }
            return index;
        }
        
        static Lazy<ConcurrentDictionary<PartId, IPartId>> PartIndexData {get;} 
            = new Lazy<ConcurrentDictionary<PartId, IPartId>>(CreatePartIndex);        

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