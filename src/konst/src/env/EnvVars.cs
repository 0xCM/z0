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

    using N = EnvVarNames;

    public class EnvVars : IEnvVarProvider
    {
        public static EnvVars read()
            => new EnvVars();

        EnvVars()
        {
            var dst = this;
            dst.Dev = read(N.ZDev);
            dst.Db = read(N.Db);
            dst.Control = read(N.Control);
            dst.Packages = read(N.Packages);
            dst.Tools = read(N.Tools);
            dst.Archives = read(N.Archives);
            dst.DotNetSdk = read(N.DotNetSdk);
            dst.Logs = read(N.Logs);
        }

        public EnvDirVar Dev;

        public EnvDirVar Db;

        public EnvDirVar Control;

        public EnvDirVar Packages;

        public EnvDirVar Tools;

        public EnvDirVar Archives;

        public EnvDirVar DotNetSdk;

        public EnvDirVar Logs;

        public string Format()
        {
            var dst = text.buffer();
            var vars = Provided;
            var count = vars.Count;
            root.iter(vars, var => dst.AppendLine(var.Format()));
            return dst.Emit();
        }

        public string Format(VarContextKind vck)
        {
            var dst = text.buffer();
            var vars = Provided;
            var count = vars.Count;
            root.iter(vars, var => dst.AppendLine(var.Format(vck)));
            return dst.Emit();
        }

        public override string ToString()
            => Format();

        public Index<IEnvVar> Provided
            => Members(this);

        [Op]
        static EnvDirVar read(string name)
        {
            var value = Environment.GetEnvironmentVariable(name);
            if(text.blank(value))
                root.@throw($"The environment variable '{name}' is undefined");
            return (name, FS.dir(value));
        }

        static Index<IEnvVar> Members(EnvVars src)
            => typeof(EnvVars).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Select(x => (IEnvVar)x.GetValue(src));
    }
}