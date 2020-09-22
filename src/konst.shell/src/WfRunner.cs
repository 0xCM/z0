//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    [ApiHost]
    public class WfRunner : IDisposable
    {
        readonly IWfShell Wf;

        readonly WfStepId Id;

        [MethodImpl(Inline)]
        public WfRunner(IWfShell wf)
        {
            Wf = wf;
            Id = typeof(WfRunner);
            Wf.Created(Id);

        }

        public void Dispose()
        {
            Wf.Disposed(Id);
        }

        void PrintLetterns()
        {
            Wf.Running(Id);
            var data = Resources.text(typeof(AsciLetterLoText));
            var resources = @readonly(data);
            var rows = Resources.rows(data).View;
            var count = resources.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var res = ref skip(resources,i);
                ref readonly var row = ref skip(rows,i);
                Wf.DataRow(delimit(row.Id, row.Address, row.Value));
            }

            Wf.Ran(Id);

        }

        void Print(in ListedFiles src)
        {
            for(var i=0; i<src.Count; i++)
                Wf.DataRow(src[i]);
        }

        void ListApiHex()
        {
            var archive = ApiArchives.hex(Wf);
            var listing = archive.List();
            if(listing.Count == 0)
                Wf.Warn(Id, $"No files found in archive with root {archive.Root}");
            Print(listing);
        }

        void Summarize(ApiHex src)
        {
            Wf.Status(Id, src.OpUri);
        }

        [Op]
        public void Run()
        {
            Wf.Running(Id);

            var archive = ApiArchives.hex(Wf);
            var files = archive.List();
            foreach(var file in files.Storage)
            {
                var lines = archive.Read(file.Path);
                foreach(var line in lines)
                {
                    Summarize(line);
                }


            }

            Wf.Ran(Id);
        }
    }
}