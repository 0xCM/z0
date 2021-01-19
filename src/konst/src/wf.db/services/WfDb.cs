//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [WfService]
    public sealed class WfDb : WfService<WfDb,IWfDb>, IWfDb
    {
        public FS.FolderPath Root {get; private set;}

        public WfDb()
        {

        }

        [MethodImpl(Inline)]
        internal WfDb(IWfShell wf)
            : base(wf)
        {
            Root = Wf.DbRoot;
        }

        protected override void OnInit()
        {
            Root = Wf.DbRoot;
        }

        IWfDb Service => this;

        public WfExecToken EmitTable<T>(ReadOnlySpan<T> src, string name)
            where T : struct, IRecord<T>
        {
            var dst = Service.Table<T>(name);
            var flow = Wf.EmittingTable<T>(dst);
            var count = (uint)src.Length;
            var formatter = Records.formatter<T>();
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0u; i<count; i++)
                writer.WriteLine(formatter.Format(skip(src,i)));
            return Wf.EmittedTable<T>(flow, count, dst);
        }
    }
}