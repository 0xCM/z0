//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.InteropServices;
    using static core;
    using static Root;

    using SQ = SymbolicQuery;

    [ApiHost("llvm.records")]
    public partial class Records : WsService<Records>
    {
        LlvmRecordSources _Sources;

        public Records()
        {
            _Sources = new();
        }

        public ReadOnlySpan<string> Defs(LlvmDatasetKind kind)
        {
            var results = core.array<string>();
            var sources = Sources();
            var source = Index<TextLine>.Empty;

            switch(kind)
            {
                case LlvmDatasetKind.Instructions:
                    source = sources.InstructionSummary;
                break;
                case LlvmDatasetKind.Intrinsics:
                    source = sources.IntrinsicsSummary;
                break;
                case LlvmDatasetKind.ValueTypes:
                    source = sources.ValueTypesSummary;
                break;
            }
            return Defs(source);
        }

        ReadOnlySpan<string> Defs(ReadOnlySpan<TextLine> src)
        {
            var result = Outcome.Success;
            const string Marker = "def ";
            var fields = list<RecordField>();
            var lines = list<TextLine>();
            var dst = list<string>();
            var name = EmptyString;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var line = ref skip(src,i);
                var content = line.Content;
                var j = text.index(content, Marker);
                if(j >= 0)
                {
                    var k = text.index(content, Chars.LBrace);
                    if(k>=0)
                    {
                        name = text.trim(text.between(content, j + Marker.Length - 1, k));
                        var m = SQ.index(content, Chars.FSlash, Chars.FSlash);
                        if(m >= 0)
                        {
                            var ancestors = text.trim(text.right(content,m+1));
                            name = string.Format("{0} :> ({1})", name, ancestors);
                        }

                        dst.Add(name);

                    }
                }
            }
            return dst.ViewDeposited();
        }

        public LlvmRecordSources Sources()
        {
            if(_Sources.IsEmtpty)
            {
                var svc = Wf.LlvmDatasets(Ws.Sources());
                var result = svc.Load(LlvmDatasetKind.Instructions | LlvmDatasetKind.Details, ref _Sources);
                result.OnSuccess(path => Write(path.ToUri().Format(), _Sources.InstructionDetails.Count));

                result = svc.Load(LlvmDatasetKind.Instructions | LlvmDatasetKind.Summary, ref _Sources);
                result.OnSuccess(path => Write(path.ToUri().Format(), _Sources.InstructionSummary.Count));

                result = svc.Load(LlvmDatasetKind.Intrinsics | LlvmDatasetKind.Details, ref _Sources);
                result.OnSuccess(path => Write(path.ToUri().Format(), _Sources.IntrinsicsDetails.Count));

                result = svc.Load(LlvmDatasetKind.Intrinsics | LlvmDatasetKind.Summary, ref _Sources);
                result.OnSuccess(path => Write(path.ToUri().Format(), _Sources.IntrinsicsSummary.Count));

                result = svc.Load(LlvmDatasetKind.ValueTypes | LlvmDatasetKind.Summary, ref _Sources);
                result.OnSuccess(path => Write(path.ToUri().Format(), _Sources.ValueTypesSummary.Count));

                result = svc.Load(LlvmDatasetKind.ValueTypes | LlvmDatasetKind.Details, ref _Sources);
                result.OnSuccess(path => Write(path.ToUri().Format(), _Sources.ValueTypesDetails.Count));

                Write(string.Format("Loaded {0} lines", _Sources.TotalLineCount()));
            }
            return _Sources;
        }
    }
}