//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static z;
    using static Konst;
    using static CmdVarTypes;

    using Types = CmdVarTypes;

    [ApiHost]
    public readonly partial struct CmdVars
    {
        const NumericKind Closure = UnsignedInts;

        internal const byte MaxVarCount = 16;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdVar<K> define<K>(K id, in Cell128 value)
            where K : unmanaged
                => new CmdVar<K>(id, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdVar<K> define<K>(K id, string value)
            where K : unmanaged
                => new CmdVar<K>(id, value);
        [Op]
        public static CmdVarIndex init(byte count)
            => new CmdVarIndex(new CmdVar[count]);

        [Op]
        public static CmdVarIndex init()
            => new CmdVarIndex(new CmdVar[MaxVarCount]);

        [Op, Closures(Closure)]
        public static CmdVarIndex<K> init<K>()
            where K : unmanaged
                => new CmdVarIndex<K>(new CmdVar<K>[MaxVarCount]);
        [Op]
        public static Types.EnvVars env()
        {
            var dst = new CmdVarTypes.EnvVars();
            dst.DevRoot = (nameof(dst.DevRoot), FS.dir(Environment.GetEnvironmentVariable("ZDev")));
            dst.Db = (nameof(dst.Db), FS.dir(Environment.GetEnvironmentVariable("ZDb")));
            dst.Control = (nameof(dst.Control), FS.dir(Environment.GetEnvironmentVariable("ZControl")));
            return dst;
        }
    }
}