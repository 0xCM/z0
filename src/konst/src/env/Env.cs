//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Reifies an application environment service predicated on environment variables
    /// </summary>
    public struct Env : IEnv<EnvVars>
    {
        public FS.FolderPath LogRoot;

        public FS.FolderPath DevRoot;

        public FS.FolderPath ArchiveRoot;

        public FS.FolderPath DbRoot;

        public EnvVars Vars;

        [MethodImpl(Inline), Op]
        public static Env create()
        {
            var dst = new Env();
            dst.Vars = EnvVars.read();
            dst.LogRoot = read(EnvVarNames.AppLogs).Transform(FS.dir);
            dst.DevRoot = read(EnvVarNames.Dev).Transform(FS.dir);
            dst.DbRoot = read(EnvVarNames.Db).Transform(FS.dir);
            dst.ArchiveRoot = read(EnvVarNames.Archives).Transform(FS.dir);
            return dst;
        }

        public Index<IEnvVar> Provided
            => Vars.Provided;

        public EnvVars Variables
            => Vars;

        [MethodImpl(Inline), Op]
        static EnvVar read(string name)
        {
            var v = Environment.GetEnvironmentVariable(name);
            if(text.nonempty(v))
                return new EnvVar(name, v);
            else
                return EnvVar.Empty;
        }
    }
}