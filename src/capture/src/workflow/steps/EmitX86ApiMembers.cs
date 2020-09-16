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

    public ref struct EmitX86ApiMembers
    {
        public X86ApiCodeRow[] Emitted;

        public X86UriHexSaved Event;

        readonly IWfShell Wf;

        readonly EmitX86HexHost Host;

        readonly ApiHostUri Uri;

        readonly X86ApiMembers Source;

        readonly FS.FilePath Target;

        public EmitX86ApiMembers(IWfShell wf, EmitX86HexHost host, ApiHostUri uri, X86ApiMembers src)
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
            Emitted = EncodedX86.save(Source.Storage.Map(x => new X86ApiCode(x.Uri, x.Address, x.Encoded)), Target);
            Event = new X86UriHexSaved(Host.Id, Uri, Emitted, Target, Wf.Ct);
            Wf.Raise(Event);
        }
    }
}