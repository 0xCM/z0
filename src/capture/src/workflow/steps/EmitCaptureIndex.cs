//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    public class EmitCaptureIndex : IDisposable
    {
        readonly Dictionary<MemoryAddress,X86ApiCode> CodeAddress;

        readonly Dictionary<MemoryAddress,OpUri> UriAddress;

        readonly Dictionary<OpUri,X86ApiCode> Locations;

        readonly IWfShell Wf;

        readonly EmitCaptureIndexHost Host;

        public X86CodeIndex Index;

        public EmitCaptureIndex(IWfShell wf, EmitCaptureIndexHost host)
        {
            Wf = wf;
            Host = host;
            CodeAddress = dict<MemoryAddress,X86ApiCode>();
            UriAddress = dict<MemoryAddress,OpUri>();
            Locations = dict<OpUri,X86ApiCode>();
        }

        public X86IndexStatus Status()
        {
            var dst = default(X86IndexStatus);
            dst.Parts = Parts;
            dst.Hosts = Hosts;
            dst.Addresses = Addresses;
            dst.MemberCount = MemberCount;
            dst.Encoded = new X86MemoryIndex(dst.Parts, Encoded);
            return dst;
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public PartId[] Parts
            => Locations.Keys.Select(x => x.Host.Owner).Distinct().Array();

        public ApiHostUri[] Hosts
            => Locations.Keys.Select(x => x.Host).Distinct().Array();

        public MemoryAddress[] Addresses
            => CodeAddress.Keys.Array();

        public uint MemberCount
            => (uint)CodeAddress.Keys.Count;

        public KeyValuePairs<MemoryAddress,X86ApiCode> Encoded
            => CodeAddress.ToKVPairs();

        public KeyValuePairs<MemoryAddress,OpUri> Located
            => UriAddress.ToKVPairs();

        public void Run()
        {
            Index = Freeze();
        }

        X86CodeIndex Freeze()
        {
            var memories = Encoded;
            var locations = Located;
            var parts = Parts;
            var code = CodeAddress.Values.Select(x => (x.OpUri.Host, Code: x))
                .Array()
                .GroupBy(g => g.Host)
                .Select(x => (new X86HostCode(x.Key, x.Select(y => y.Code).ToArray()))).Array();

            return new X86CodeIndex(parts,
                   new X86MemoryIndex(parts, memories),
                   new X86UriAddresses(parts, locations),
                   new X86PartCodeIndex(parts, code.Select(x => (x.Host, x)).ToDictionary()));
        }

        public Triple<bool> Include(in X86ApiCode src)
        {
            var a = CodeAddress.TryAdd(src.Base, src);
            var b = UriAddress.TryAdd(src.Base, src.OpUri);
            var c = Locations.TryAdd(src.OpUri, src);
            return (a,b,c);
        }
    }
}