//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.IO;

    [ApiHost]
    public readonly partial struct Part
    {
        [MethodImpl(Inline), Op]
        public static PartId @base(PartId src)
            => Root.@base(src);

        [Op]
        public static string name(Assembly src)
            => Root.name(src);

        [MethodImpl(Inline), Op]
        public static string format(ExternId src)
            => Root.format(src);

        /// <summary>
        /// Retrieves the part identifier, if any, of a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static PartId id(Assembly src)
            => Root.id(src);

        [Op]
        public static bool test(Assembly src)
            => Root.test(src);

        /// <summary>
        /// Retrieves the part identifier, if any, of the entry assembly
        /// </summary>
        public static PartId ExecutingPart
            => id(Assembly.GetEntryAssembly());

        public static string AppName
            => Assembly.GetEntryAssembly().GetName().Name;

        public static string ShellExeDir
            => Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        public static PartId[] identities(Assembly[] src)
            => src.Where(test).Select(x => Part.@base(x.Id()));

        public static PartId CallingPart
            => id(Assembly.GetCallingAssembly());

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
    }
}