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

        static ReadOnlySpan<MethodInfo> ByteSpanResourceCases
            => typeof(Z0.Data).DeclaredStaticProperties()
                                         .Where(p => p.PropertyType == typeof(ReadOnlySpan<byte>))
                                         .Select(p => p.GetGetMethod())
                                         .Where(m => m != null)
                                         .ToArray();




        ReadOnlySpan<MethodInfo> ResourceAccessors()
        {
            var assemblies = Api.Resolved.Select(x => x.Owner);
            var types = assemblies.SelectMany(a => a.GetTypes());
            var props = types.SelectMany(t => t.DeclaredStaticProperties()).Where(p => p.PropertyType == typeof(ReadOnlySpan<byte>));
            var methods = props.Select(p => p.GetGetMethod()).Where(m  => m != null);
            return methods.ToArray();
        }                             
        
        public void resource_method_capture()
        {

            var restype = typeof(ReadOnlySpan<byte>);
            var methods = ResourceAccessors();

            
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
                }
            }

        }

    }
}