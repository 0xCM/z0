//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static Control;

    public class t_resource_check : t_asm<t_resource_check>
    {
        public void check_no_copy()
        {
            //Verifies that the "GetBytes" function doesn't return
            //a copy of the data but rather a refererence to the
            //data that exists in memory as a resource
            foreach(var d in Z0.Data.Resources)
                Claim.eq(d.RuntimeAddress, d.Address);

        }

        public void check_report()
        {
            var report = ResourceReport.Create(Z0.Data.Resources);
            var path = CasePath(FileExtensions.Csv);
            report.Save(path).Require();            
        }

        void WriteAsm(CapturedCode capture, StreamWriter dst)
        {
            var asm = Context.Decoder.Decode(capture).Require();
            var formatted = Context.Formatter.FormatFunction(asm);
            dst.WriteLine(formatted);            
        }

        Option<AsmFunctionCode> FunctionCode(CapturedCode capture)
        {
            var decoded = Context.Decoder.Decode(capture);
            if(decoded)
                return new AsmFunctionCode(decoded.Value, capture);
            else
                return Option.none<AsmFunctionCode>();
        }

        public void resource_method_capture()
        {

            var restype = typeof(ReadOnlySpan<byte>);
            var methods = AppResources.Service.ByteSpanAccessors(Api.Resolved.Select(x => x.Owner)).ToReadOnlySpan();
            var functions = new List<AsmFunctionCode>();
            using var writer = CaseWriter(FileExtensions.Asm);
            using var capture = QuickCapture.Alloc(Context);
            var dst = Spans.alloc<CapturedCode>(methods.Length);

            for(var i=0; i<methods.Length; i++)
            {
                ref readonly var m = ref skip(methods,i);
                var result = capture.Capture(m);
                seek(dst,i) = result.ValueOrDefault(CapturedCode.Empty);
                if(result)
                {
                    ref readonly var code = ref skip(dst,i);
                    WriteAsm(code, writer);

                    var f = FunctionCode(code);
                    if(f)
                        functions.Add(f.Value);
                }
            }

            Span<AsmInstructionList> lists = new AsmInstructionList[functions.Count];
            for(var i = 0; i<functions.Count; i++)
                seek(lists,i) = functions[i].Function.Inxs;
            
            var results = AsmAnalyzer.Analyze(lists);
            for(var i = 0; i<results.Length; i++)
            {
                var result = results[i];
                Trace(result);
            }
        }

    }
}