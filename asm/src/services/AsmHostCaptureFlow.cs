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
    using System.Reflection;
    using Z0.Asm;

    using static zfunc;

    readonly struct AsmHostCaptureFlow : IAsmHostCaptureFlow
    {
        public IAsmContext Context {get;}

        public HashSet<AssemblyId> Selected {get;}

        [MethodImpl(Inline)]
        public static IAsmHostCaptureFlow Create(IAsmContext context, params AssemblyId[] selected)
            => new AsmHostCaptureFlow(context,selected);

        [MethodImpl(Inline)]
        AsmHostCaptureFlow(IAsmContext context, AssemblyId[] selected)
        {
            this.Context = context;
            this.Selected = selected.Length == 0 ? context.Assemblies.ToHashSet() : selected.ToHashSet();
        }

        AsmEmissionPaths EmissionPaths
            => Context.EmissionPaths();

        void CreateLocationReport(AssemblyId id)
            => Context.MemberLocations(id).OnSome(report => report.Save());

        public IEnumerable<AsmCaptureSet> Execute()
        {            
            var owners = Context.Compostion.Catalogs.SelectMany(c => c.ApiHosts).GroupBy(x => x.Owner);
            var config = Context.AsmFormat.WithSectionDelimiter();
            EmissionPaths.DecodedDir.Clear();
            foreach(var owner in owners)
            {
                var id = owner.Key;
                if(Selected.Contains(id))
                    foreach(var host in owner)
                       yield return RunHostCaptureFlow(host);
            }

            iter(Selected, CreateLocationReport);
        }

        AsmFunction Decode(ParsedEncodingRecord src, IAsmFunctionDecoder decoder,  IAsmFunctionWriter dst)
        {
            var f = decoder.DecodeFunction(src);
            dst.Write(f);
            return f;

        }

        static void EmitCil(Assembly src)
        {
            var index = src.CreateIndex();
            var dir = AsmEmissionPaths.Current.CilDir;
            var srcId = src.AssemblyId();
            var context = AsmContext.New(index, DataResourceIndex.Empty, AsmFormatConfig.Default.WithSectionDelimiter());

            foreach(var host in src.ApiHosts())
            {
                var dstPath = AsmEmissionPaths.Current.CilPath(host);
                //var functions = capture.CaptureFunctions(host);
                //context.CilEmitter().EmitCil(functions, dstPath).OnSome(e => throw e);
            }            
        }

        public static AppMsg HostCaptured(ApiHost host, FilePath dst)
            => AppMsg.Info($"Emitted {host} encodings to {dst}");

        public static AppMsg HostCaptureFailed(ApiHost host)
            => AppMsg.Define($"Error emitting {host} encodings", AppMsgKind.Error);

        CapturedEncodingReport CaptureHostOps(ApiHost host)
        {
            var capture = Context.HostCapture();
            var captured = capture.CaptureHostOps(host);
            var target = EmissionPaths.CapturePath(host);  
            var sink = Context;
            captured.Save(target)
                     .OnSome(file => sink.PostMessage(HostCaptured(host,file)))
                     .OnNone(() => sink.PostMessage(HostCaptureFailed(host)));
            return captured;
        }

        ParsedEncodingReport ParseHostOps(ApiHost host, CapturedEncodingReport captured)
        {
            var parser = Context.EncodingParser();
            var parsed = parser.Parse(host,captured);
            var target = EmissionPaths.ParsedPath(host);
            var sink = Context;
            parsed.Save(target)
                        .OnSome(file => sink.PostMessage($"Emitted parsed {host} encodings to {file}"))
                        .OnNone(() => sink.PostMessage($"Error parsing {host} encodings", AppMsgKind.Error));
            require(captured.RecordCount == parsed.RecordCount);
            return parsed;
        }

        AsmFunctionList Decode(ApiHost host, CapturedEncodingReport captured, ParsedEncodingReport parsed)
        {
            var path = EmissionPaths.DecodedPath(host);
            var decoder = Context.FunctionDecoder();
            var functions = new AsmFunction[captured.RecordCount];
            using var dst = Context.AsmWriter(Context.AsmFormat.WithSectionDelimiter(), path);            
            for(var i=0; i< captured.RecordCount; i++)
            {
                var record = parsed[i];
                if(record.Length != 0)
                    functions[i] = Decode(record, decoder, dst);
                else
                    functions[i] = AsmFunction.Empty;
            }
            return AsmFunctionList.Define(functions);
        }

        AsmCaptureSet RunHostCaptureFlow(ApiHost host)        
        {
            Context.PostMessage($"Capturing {host}");
            var captured = CaptureHostOps(host);
            var parsed = ParseHostOps(host, captured);
            var decoded = Decode(host, captured, parsed);        
            return (host.Path, captured, parsed, decoded);
        }
    }
}