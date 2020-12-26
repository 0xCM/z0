//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct CmdVarTypes
    {
        public static Index<ICmdVar> members<T>(T set)
            where T : ICmdVars<T>, new()
                => typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Select(x => (ICmdVar)x.GetValue(set));

        [Op]
        public static EnvVars env()
        {
            var dst = new EnvVars();
            dst.DevRoot = (nameof(dst.DevRoot), FS.dir(Environment.GetEnvironmentVariable("ZDev")));
            dst.Db = (nameof(dst.Db), FS.dir(Environment.GetEnvironmentVariable("ZDb")));
            dst.Control = (nameof(dst.Control), FS.dir(Environment.GetEnvironmentVariable("ZControl")));
            return dst;
        }

        public struct EnvVars : ICmdVars<EnvVars>
        {
            public DirVar DevRoot;

            public DirVar Db;

            public DirVar Control;

            [MethodImpl(Inline)]
            public Index<ICmdVar> Members()
                => members(this);

            [MethodImpl(Inline)]
            public string Format()
                => Cmd.format(this);

            public override string ToString()
                => Format();
        }
    }
}