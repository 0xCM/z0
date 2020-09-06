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
    using static BuildGlobalIndexStep;


    [Step(typeof(BuildGlobalCodeIndex))]
    public readonly struct BuildGlobalIndexStep : IWfStep<BuildGlobalIndexStep>
    {
        public static WfStepId StepId => Flow.step<BuildGlobalIndexStep>();
    }

    public class BuildGlobalCodeIndex : IDisposable
    {
        readonly Dictionary<MemoryAddress,X86ApiCode> CodeAddress;

        readonly Dictionary<MemoryAddress,OpUri> UriAddress;

        readonly Dictionary<OpUri,X86ApiCode> Locations;

        readonly IWfShell Wf;

        public BuildGlobalCodeIndex(IWfShell wf)
        {
            Wf = wf;
            CodeAddress = dict<MemoryAddress,X86ApiCode>();
            UriAddress = dict<MemoryAddress,OpUri>();
            Locations = dict<OpUri,X86ApiCode>();
        }

        public GlobalIndexStatus Status()
        {
            var dst = default(GlobalIndexStatus);
            dst.Parts = Parts;
            dst.Hosts = Hosts;
            dst.Addresses = Addresses;
            dst.MemberCount = MemberCount;
            dst.Encoded = new EncodedMemoryIndex(dst.Parts, Encoded);
            return dst;
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
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

        public GlobalCodeIndex Freeze()
        {
            var memories = Encoded;
            var locations = Located;
            var parts = Parts;
            var code = CodeAddress.Values.Select(x => (x.OpUri.Host, Code: x))
                .Array()
                .GroupBy(g => g.Host)
                .Select(x => (new EncodedHost(x.Key, x.Select(y => y.Code).ToArray()))).Array();

            return new GlobalCodeIndex(parts,
                   new EncodedMemoryIndex(parts, memories),
                   new UriLocationIndex(parts, locations),
                   new HostedCodeIndex(parts, code.Select(x => (x.Host, x)).ToDictionary()));
        }

        public Triple<bool> Include(in X86ApiCode src)
        {
            var a = CodeAddress.TryAdd(src.Base, src);
            var b = UriAddress.TryAdd(src.Base, src.OpUri);
            var c = Locations.TryAdd(src.OpUri, src);
            return (a,b,c);
        }

        // public void Include(ReadOnlySpan<MemberParseRecord> src)
        // {
        //     var count = src.Length;
        //     for(var i=0; i<count; i++)
        //         Include(skip(src,i));
        // }

        // void Include(in MemberParseRecord src)
        // {
        //     if(src.Address.IsEmpty)
        //         return;

        //     var code = new X86ApiCode(src.Uri, src.Data);

        //     // if(!Include(code))
        //     //     Wf.Warn(StepId, $"Duplicate | {src.Uri.Format()}");
        // }
    }
}