//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    public ref struct EmitApiHexTable
    {
        public ApiHexRow[] Emitted;

        public ApiHexTableSaved Event;

        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiHostUri Uri;

        readonly ApiMemberCodeTable Source;

        readonly FS.FilePath Target;

        public EmitApiHexTable(IWfShell wf, WfHost host, ApiHostUri uri, ApiMemberCodeTable src)
        {
            Wf = wf;
            Host = host;
            Uri = uri;
            Source = src;
            Target = FS.path(Wf.Paths.CaptureArchive(uri).HostX86Path.Name);
            Emitted = default;
            Event = default;
            Wf.Created(Host.Id);
        }

        public void Dispose()
        {
            Wf.Disposed(Host.Id);
        }

        public void Run()
        {
            Emitted = EncodedX86.save(Source.Storage.Map(x => new ApiCodeBlock(x.Uri, x.Address, x.Encoded)), Target);
            Event = new ApiHexTableSaved(Host.Id, Uri, Emitted, Target, Wf.Ct);
            Wf.Raise(Event);
        }
    }
}