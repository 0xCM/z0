//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Components;

    public static class AssemblyIdOps
    {
        [MethodImpl(Inline)]
        public static string Format(this AssemblyId id)
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
        public static bool IsTest(this AssemblyId a)
            => (a & AssemblyId.Test) != 0;

        [MethodImpl(Inline)]
        public static bool IsSvc(this AssemblyId a)
            => (a & AssemblyId.Svc) != 0;

        [MethodImpl(Inline)]
        public static AssemblyId WithoutTest(this AssemblyId a)
            => a & ~ AssemblyId.Test;

        [MethodImpl(Inline)]
        public static AssemblyId WithTest(this AssemblyId a)
            => a | AssemblyId.Test;

        [MethodImpl(Inline)]
        public static AssemblyId WithoutSvc(this AssemblyId a)
            => a & ~ AssemblyId.Svc;

        [MethodImpl(Inline)]
        public static AssemblyId WithSvc(this AssemblyId a)
            => a | AssemblyId.Svc;

        [MethodImpl(Inline)]
        public static AssemblyId Base(this AssemblyId a)
            => a.WithoutSvc().WithoutTest();

        [MethodImpl(Inline)]
        public static AssemblyId Id(this Assembly src)
            =>  src.GetTag<AssemblyIdAttribute>()?.Id ?? AssemblyId.None;

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