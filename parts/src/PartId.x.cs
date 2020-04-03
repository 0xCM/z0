//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static PartIdentity;

    public static partial class XTend
    {
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
    }
}