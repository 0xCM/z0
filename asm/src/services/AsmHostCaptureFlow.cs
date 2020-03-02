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

    using static AsmServiceMessages;
    using static Root;

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

        AsmEmissionPaths Paths
            => Context.EmissionPaths();

        void CreateLocationReport(AssemblyId id)
            => Context.MemberLocations(id).OnSome(report => report.Save());
        
        public IEnumerable<AsmHostExtract> Execute()
        {            
            var owners = Context.Compostion.Catalogs.SelectMany(c => c.ApiHosts).GroupBy(x => x.Owner);
            var config = Context.AsmFormat.WithSectionDelimiter();
            Paths.DecodeCapturedDir.Clear();
            Paths.ParsedCaptureDir.Clear();
            Paths.RawCaptureDir.Clear();

            foreach(var owner in owners)
            {
                var id = owner.Key;
                if(Selected.Contains(id))
                    foreach(var host in owner)
                       yield return RunHostCaptureFlow(host);
            }

            iter(Selected, CreateLocationReport);
        }

        AsmFunction Decode(AsmParseRecord src, IAsmFunctionDecoder decoder,  IAsmFunctionWriter dst)
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
                var dstPath = AsmEmissionPaths.Current.CilPath(host.Path);
                //var functions = capture.CaptureFunctions(host);
                //context.CilEmitter().EmitCil(functions, dstPath).OnSome(e => throw e);
            }            
        }

        AsmOpExtractReport CaptureHostOps(ApiHost host)
        {
            var capture = Context.HostExtractor();
            var captured = capture.ExtractOps(host);
            var target = Paths.RawCapturePath(host.Path);  
            var sink = Context;
            captured.Save(target)
                     .OnSome(file => sink.PostMessage(CapturedRaw(host.Path,file)))
                     .OnNone(() => sink.PostMessage(CaptureRawFailed(host.Path)));
            return captured;
        }

        AsmParseReport Parse(ApiHost host, AsmOpExtractReport captured)
        {
            var parser = Context.ExtractReportParser(new byte[Context.DefaultBufferLength]);
            var parsed = parser.Parse(host,captured);
            var target = Paths.ParsedCapturePath(host.Path);
            var sink = Context;
            parsed.Save(target)
                        .OnSome(file => sink.PostMessage(ParsedEncodings(host.Path,file)))
                        .OnNone(() => sink.PostMessage(ParseEncodingFailure(host.Path)));
            require(captured.RecordCount == parsed.RecordCount);
            return parsed;
        }

        AsmFunctionList Decode(ApiHost host, AsmOpExtractReport captured, AsmParseReport parsed)
        {
            var path = Paths.DecodedCapturePath(host.Path);
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

        AsmHostExtract RunHostCaptureFlow(ApiHost host)        
        {
            Context.PostMessage($"Executing {host} capture workflow");
            var captured = CaptureHostOps(host);
            var parsed = Parse(host, captured);
            var decoded = Decode(host, captured, parsed);        
            return (host.Path, captured, parsed, decoded);
        }
    }
}