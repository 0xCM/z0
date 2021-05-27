//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using N = EnvVarNames;

    public class Env : IEnvProvider
    {
        public PartId AppId
            => Assembly.GetEntryAssembly().Id();

        public static Env create()
            => new Env();

        Env()
        {
            var dst = this;
            dst.ZDev = dir(N.ZDev);
            dst.Db = dir(N.Db);
            dst.Control = dir(N.Control);
            dst.Packages = dir(N.Packages);
            dst.Tools = dir(N.Tools);
            dst.Archives = dir(N.Archives);
            dst.Logs = dir(N.Logs);
            dst.ZBin = dir(N.ZBin);
            dst.DevRoot = dir(N.DevRoot);
            dst.Tmp = dir(N.ZTmp);
            dst.CdbLogPath = path(N.CdbLogPath);
            dst.DefaultSymbolCache = dir(N.DefaultSymbolCache);
            dst.SymCacheRoot = dir(N.SymCacheRoot);
            dst.CacheRoot = dir(N.CacheRoot);
            dst.Libs = dir(N.Libs);
            dst.DataRoot = dir(N.ZData);
            dst.VendorDocs = dir(N.VendorDocs);
            dst.CapturePacks = dir(N.CapturePacks);
        }

        public EnvDirVar ZDev;

        public EnvDirVar DevRoot;

        public EnvDirVar Db;

        public EnvDirVar Control;

        public EnvDirVar Packages;

        public EnvDirVar Tools;

        public EnvDirVar Archives;

        public EnvDirVar Logs;

        public EnvDirVar Tmp;

        public EnvDirVar ZBin;

        public EnvPathVar CdbLogPath;

        public EnvDirVar SymCacheRoot;

        public EnvDirVar DefaultSymbolCache;

        public EnvDirVar CacheRoot;

        public EnvDirVar Libs;

        public EnvDirVar DataRoot;

        public EnvDirVar VendorDocs;

        public EnvDirVar CapturePacks;

        public string Format()
        {
            var dst = text.buffer();
            var vars = Provided;
            var count = vars.Length;
            root.iter(vars, var => dst.AppendLine(var.Format()));
            return dst.Emit();
        }

        public string Format(VarContextKind vck)
        {
            var dst = text.buffer();
            var vars = Provided;
            var count = vars.Length;
            root.iter(vars, var => dst.AppendLine(var.Format(vck)));
            return dst.Emit();
        }

        public override string ToString()
            => Format();

        public ReadOnlySpan<IEnvVar> Provided
            => Members(this);

        [Op]
        static EnvDirVar dir(string name)
        {
            var value = Environment.GetEnvironmentVariable(name);
            if(text.blank(value))
                core.@throw($"The environment variable '{name}' is undefined");
            return (name, FS.dir(value));
        }

        [Op]
        static EnvPathVar path(string name)
        {
            var value = Environment.GetEnvironmentVariable(name);
            if(text.blank(value))
                core.@throw($"The environment variable '{name}' is undefined");
            return (name, FS.path(value));
        }

        static Index<IEnvVar> Members(Env src)
            => typeof(Env).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Select(x => (IEnvVar)x.GetValue(src));
    }
}