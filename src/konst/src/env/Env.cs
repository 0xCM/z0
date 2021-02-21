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

        public FS.FolderPath ControlRoot;

        public EnvVars Vars;

        [MethodImpl(Inline), Op]
        public static Env create()
        {
            var dst = new Env();
            var vars = EnvVars.read();
            dst.Vars = vars;
            dst.LogRoot = vars.Logs.Value;
            dst.DevRoot = vars.Dev.Value;
            dst.DbRoot = vars.Db.Value;
            dst.ArchiveRoot = vars.Archives.Value;
            dst.ControlRoot = vars.Control.Value;
            return dst;
        }

        public Index<IEnvVar> Provided
            => Vars.Provided;

        public EnvVars Variables
            => Vars;
    }
}