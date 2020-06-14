//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static Control;

    public readonly struct AccessorCapture
    {
        readonly IAsmContext Context;

        [MethodImpl(Inline)]
        public static AccessorCapture Service(IAsmContext context)
            => new AccessorCapture(context);
        
        [MethodImpl(Inline)]
        internal AccessorCapture(IAsmContext context)
        {
            Context = context;
        }

        void WriteAsm(CapturedCode capture, StreamWriter dst)
        {
            var asm = Context.Decoder.Decode(capture).Require();
            var formatted = Context.Formatter.FormatFunction(asm);
            dst.Write(formatted);            
        }

        Option<AsmFunctionCode> FunctionCode(CapturedCode capture)
        {
            var decoded = Context.Decoder.Decode(capture);
            if(decoded)
                return new AsmFunctionCode(decoded.Value, capture);
            else
                return Option.none<AsmFunctionCode>();
        }

        public CapturedAccessor[] CaptureAccessors(FilePath outpath)
        {
            var stores = ResourceStore.Service;
            var assemblies = Context.ApiSet.Composition.Assemblies;
            var methods = span(stores.Accessors(assemblies));
            var captured = list<CapturedAccessor>();
            using var writer = outpath.Writer();
            using var capture = QuickCapture.Alloc(Context);
            var dst = span(alloc<CapturedCode>(methods.Length));

            for(var i=0; i<methods.Length; i++)
            {
                ref readonly var accessor = ref skip(methods,i);
                var result = capture.Capture(accessor.Member);
                seek(dst,i) = result.ValueOrDefault(CapturedCode.Empty);
                if(result)
                {
                    ref readonly var code = ref skip(dst,i);
                    WriteAsm(code, writer);

                    var f = FunctionCode(code);
                    if(f)
                        captured.Add(new CapturedAccessor(accessor,f.Value));
                }
            }
            return captured.ToArray();
        }
    }
}