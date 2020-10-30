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

    using CK = FS.ChangeKind;

    public struct FileSystemChange
    {
        public FS.ChangeKind ChangeKind;

        public FS.ObjectKind ObjectKind;

        public AsciEncoded ObjectName;
    }

    public readonly struct ArchiveMonitor : IArchiveMonitor
    {
        [MethodImpl(Inline), Op]
        public static IArchiveMonitor create(IWfShell wf, FS.FolderPath src, FS.ChangeHandler handler = null, bool recursive = true, string filter = null)
            => new ArchiveMonitor(wf, src, handler, recursive, filter);

        public FS.FolderPath ArchiveRoot {get;}

        readonly FileSystemWatcher Watcher;

        readonly FS.ChangeHandler Handler;

        readonly IWfShell Wf;

        public ArchiveMonitor(IWfShell wf, FS.FolderPath subject, FS.ChangeHandler handler, bool recursive = true, string filter = null)
            : this()
        {
            Wf = wf;
            ArchiveRoot = subject;
            Watcher = new FileSystemWatcher(subject.Name, filter ?? EmptyString);
            Watcher.IncludeSubdirectories = recursive;
            Handler = handler ?? OnChange;
            Subscribe();
        }

        void OnChange(FsEntry subject, FS.ChangeKind kind)
        {
            try
            {
                if(kind != 0)
                {
                    Log(subject, kind);

                    switch(kind)
                    {
                        case CK.Created:
                        break;
                        case CK.Deleted:
                        break;
                        case CK.Modified:
                        break;
                        case CK.Renamed:
                        break;
                    }
                }
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        FileSystemChange Log(FsEntry subject, FS.ChangeKind kind)
        {
            var record = new FileSystemChange();
            record.ChangeKind = kind;
            record.ObjectKind = subject.Kind;
            record.ObjectName = subject.Name;
            return record;

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
            => Watcher.EnableRaisingEvents = true;

        [MethodImpl(Inline)]
        public void Stop()
            => Watcher.EnableRaisingEvents = false;

        public void Dispose()
        {
            Watcher?.Dispose();
        }

        void Error(object sender, ErrorEventArgs e)
        {
            Wf.Error(e.GetException());
        }
    }
}