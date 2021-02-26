//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public sealed class WfDb : WfService<WfDb,IWfDb>, IWfDb
    {
        public FS.FolderPath Root {get; private set;}

        public Env Env {get; private set;}

        public WfDb()
        {

        }

        internal WfDb(IWfShell wf, FS.FolderPath root)
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

        public WfExecToken EmitTable<T>(ReadOnlySpan<T> src, string name)
            where T : struct, IRecord<T>
        {
            var dst = (this as IWfDb).Table<T>(name);
            var flow = Wf.EmittingTable<T>(dst);
            var count = (uint)src.Length;
            var formatter = Records.formatter<T>();
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0u; i<count; i++)
                writer.WriteLine(formatter.Format(skip(src,i)));
            return Wf.EmittedTable<T>(flow, count);
        }
    }
}