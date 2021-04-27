//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public sealed class WfDb : AppService<WfDb>, IWfDb
    {
        public FS.FolderPath Root {get; private set;}

        public Env Env {get; private set;}

        public WfDb()
        {

        }

        internal WfDb(IWfRuntime wf, FS.FolderPath root)
            : base(wf)
        {
            Env = wf.Env;
            Root = root;
        }

        protected override void OnInit()
        {
            base.OnInit();
            Env = Env.create();
            Root = Env.Db.Value;
        }

        IEnvPaths Paths => this;

        public FS.Files Clear(FS.FolderName id)
        {
            var cleared = (Paths.TableRoot() + id).Clear(root.list<FS.FilePath>()).Array();
            root.iter(cleared, file => Wf.Status(Msg.ClearedFile.Format(file.ToUri())));
            return cleared;
        }

        public FS.Files Clear(string id)
        {
            var cleared = (Paths.TableRoot() + FS.folder(id)).Clear(root.list<FS.FilePath>()).Array();
            root.iter(cleared, file => Wf.Status(Msg.ClearedFile.Format(file.ToUri())));
            return cleared;
        }

        FS.Files Clear(FS.Files src)
        {
            var cleared = src.Clear();
            root.iter(cleared, file => Wf.Status(Msg.ClearedFile.Format(file.ToUri())));
            return cleared;
        }

        public FS.Files ClearTables<T>()
            where T : struct, IRecord<T>
        {
            var dir = Paths.TableDir<T>();
            return Clear(dir.EnumerateFiles(FS.Csv, false).Array());
        }

        public WfExecToken EmitTable<T>(ReadOnlySpan<T> src, string name)
            where T : struct, IRecord<T>
        {
            var dst = Paths.Table<T>(name);
            var flow = Wf.EmittingTable<T>(dst);
            var count = Tables.emit(src,dst);
            return Wf.EmittedTable<T>(flow, count);
        }

        public FS.FilePath EmitSettings<T>(T settings)
            where T : ISettingsSet<T>, new()
        {
            var dst = Paths.SettingsPath(typeof(T).Name);
            dst.Overwrite(settings.Format());
            return dst;
        }
    }

    partial struct Msg
    {
        public static MsgPattern<FS.FileUri> ClearedFile => "Cleared {0}";
    }
}