//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct EnvData
    {
        readonly Env Source;

        [MethodImpl(Inline)]
        internal EnvData(PartId part, Env src)
        {
            Source = src;
            AppId = part;
        }

        public PartId AppId {get;}

        public FS.FolderPath ZDev => Source.ZDev;

        public FS.FolderPath DevRoot => Source.DevRoot;

        public FS.FolderPath Db => Source.Db;

        public FS.FolderPath Control => Source.Control;

        public FS.FolderPath Packages => Source.Packages;

        public FS.FolderPath Tools => Source.Tools;

        public FS.FolderPath Archives => Source.Archives;

        public FS.FolderPath Logs => Source.Logs;

        public FS.FolderPath Tmp => Source.Tmp;

        public FS.FolderPath ZBin => Source.ZBin;

        public FS.FilePath CdbLogPath => Source.CdbLogPath;

        public FS.FolderPath SymCacheRoot => Source.SymCacheRoot;

        public FS.FolderPath DefaultSymbolCache => Source.DefaultSymbolCache;

        public FS.FolderPath CacheRoot => Source.CacheRoot;

        public FS.FolderPath Libs => Source.Libs;

        public FS.FolderPath DataRoot => Source.DataRoot;

        public FS.FolderPath VendorDocs => Source.VendorDocs;

        public FS.FolderPath CapturePacks => Source.CapturePacks;

        public ulong CpuCount => Source.CpuCount;
    }
}