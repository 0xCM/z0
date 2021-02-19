//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    partial struct Root
    {
        [MethodImpl(Inline), Op]
        public static bool isSvc(PartId a)
            => (a & PartId.Svc) != 0;

        [MethodImpl(Inline), Op]
        public static bool isTest(PartId a)
            => (a & PartId.Test) != 0;

        [Op]
        public static bool test(Assembly src)
            => Attribute.IsDefined(src, typeof(PartIdAttribute));

        public static PartId id(Assembly src)
        {
            if(src != null && test(src))
                return ((PartIdAttribute)Attribute.GetCustomAttribute(src, typeof(PartIdAttribute))).Id;
            else
                return PartId.None;
        }

        [MethodImpl(Inline), Op]
        public static PartId withoutTest(PartId a)
            => a & ~ PartId.Test;

        [MethodImpl(Inline), Op]
        public static PartId withTest(PartId a)
            => a | PartId.Test;

        [MethodImpl(Inline), Op]
        public static PartId withoutSvc(PartId a)
            => a & ~ PartId.Svc;

        [MethodImpl(Inline), Op]
        public static PartId withSvc(PartId a)
            => a | PartId.Svc;

        [MethodImpl(Inline), Op]
        public static PartId @base(PartId a)
            => withoutTest(withoutSvc(a));
    }
}
