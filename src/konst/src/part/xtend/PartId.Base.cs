//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static PartId Base(this PartId a)
            => a.WithoutSvc().WithoutTest();

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
    }
}