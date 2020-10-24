//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    public readonly struct ArchiveMonitor : IArchiveMonitor
    {
        [MethodImpl(Inline), Op]
        public static IArchiveMonitor create(FS.FolderPath src, FS.ChangeHandler handler, bool recursive = true, string filter = null)
            => new ArchiveMonitor(src, handler, recursive, filter);

        public FS.FolderPath Subject {get;}

        readonly FileSystemWatcher Watcher;

        readonly FS.ChangeHandler Handler;

        public ArchiveMonitor(FS.FolderPath subject, FS.ChangeHandler handler, bool recursive = true, string filter = null)
        {
            Subject = subject;
            Watcher = new FileSystemWatcher(subject.Name, filter ?? EmptyString);
            Watcher.IncludeSubdirectories = recursive;
            Handler = handler;
            Subscribe();
        }

        [MethodImpl(Inline)]
        public static FsEntry objects(FileSystemEventArgs src)
            => new FsEntry(src.FullPath, FS.ObjectKind.File);

        [MethodImpl(Inline)]
        void Created(object sender, FileSystemEventArgs e)
        {
            Handler(objects(e), (FS.ChangeKind)e.ChangeType);
        }

        [MethodImpl(Inline)]
        void Deleted(object sender, FileSystemEventArgs e)
        {
            Handler(objects(e), (FS.ChangeKind)e.ChangeType);
        }

        [MethodImpl(Inline)]
        void Changed(object sender, FileSystemEventArgs e)
        {
            Handler(objects(e), (FS.ChangeKind)e.ChangeType);
        }

        [MethodImpl(Inline)]
        void Renamed(object sender, FileSystemEventArgs e)
        {
            Handler(objects(e), (FS.ChangeKind)e.ChangeType);
        }

        void Subscribe()
        {
            Watcher.Created += Created;
            Watcher.Deleted += Deleted;
            Watcher.Changed += Changed;
            Watcher.Renamed += Renamed;
            Watcher.Error += Error;
        }

        [MethodImpl(Inline)]
        public void Start()
        {
            Watcher.EnableRaisingEvents = true;
        }

        [MethodImpl(Inline)]
        public void Stop()
        {
            Watcher.EnableRaisingEvents = false;
        }

        public void Dispose()
        {
            Watcher?.Dispose();
        }

        void Error(object sender, ErrorEventArgs e)
        {
            term.error(e.GetException());
        }
    }
}