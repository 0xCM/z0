//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Reifies an application environment service predicated on environment variables
    /// </summary>
    public struct Env
    {
        const string ZDev = nameof(ZDev);

        const string ZLogs = nameof(ZLogs);

        const string ZControl = nameof(ZControl);

        const string ZToolRoot = nameof(ZToolRoot);

        const string ZArchive = nameof(ZArchive);

        const string ZDb = nameof(ZDb);

        public FS.FolderPath LogRoot;

        public FS.FolderPath DevRoot;

        public FS.FolderPath ArchiveRoot;

        public FS.FolderPath ToolRoot;

        public FS.FolderPath DbRoot;

        public FS.FolderPath SystemControl;

        [MethodImpl(Inline), Op]
        public static Env create()
        {
            var dst = new Env();
            dst.LogRoot = read(ZLogs).Transform(FS.dir);
            dst.DevRoot = read(ZDev).Transform(FS.dir);
            dst.DbRoot = read(ZDb).Transform(FS.dir);
            dst.ArchiveRoot = read(ZArchive).Transform(FS.dir);
            dst.SystemControl = read(ZControl).Transform(FS.dir);
            dst.ToolRoot = read(ZToolRoot).Transform(FS.dir);
            return dst;
        }

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