//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    [ApiHost]
    public readonly partial struct root
    {
        /// <summary>
        /// The number of bits to shift a field specifier left/right to reveal/specify the width of an identified field
        /// </summary>
        public const int WidthOffset = 16;

        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline), Op]
        public static uint hash(PartId src)
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static bool isSvc(PartId a)
            => (a & PartId.Svc) != 0;

        [MethodImpl(Inline), Op]
        public static bool isTest(PartId a)
            => (a & PartId.Test) != 0;

        public static T[] array<T>(params T[] src)
            => src;

        [Op]
        public static bool test(Assembly src)
            => Attribute.IsDefined(src, typeof(PartIdAttribute));

        /// <summary>
        /// Retrieves the part identifier, if any, of a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
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

        [Op]
        public static string name(Assembly src)
            => src.GetName().Name;

        [Op]
        public static string format(PartId src)
        {
            var baseId = @base(src);
            var dst = baseId.ToString().ToLower();

            if(isTest(src))
                return dst + TestSuffix;
            else if(isSvc(src))
                return dst + SvcSuffix;
            else
                return dst + BaseSuffix;
        }

        [MethodImpl(Inline), Op]
        public static string format(ExternId id)
            => id.ToString().ToLower();

        const string TestSuffix = ".test";

        const string SvcSuffix = ".svc";

        const string BaseSuffix = "";
    }
}