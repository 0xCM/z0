//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Reflection;

    using Z0.Asm;

    using static Konst;
    using static z;

    public readonly ref struct Reveal
    {
        public static Reveal create(IAppContext context)
            => new Reveal(context);
        
        readonly IAppContext Root;
        
        readonly IAsmContext Asm;
        
        readonly IAsmFunctionDecoder Decoder;
        
        readonly IAsmFormatter Formatter;
        
        readonly ICaptureServices Services;
        
        public Reveal(IAppContext root)
        {
            Root = root;
            Asm = ContextFactory.asm(root);
            Services = CaptureServices.create(Asm);
            var format = AsmFormatSpec.DefaultStreamFormat;
            Formatter = Services.Formatter(format);
            Decoder = Services.AsmDecoder(format);
        }
                
        public ReadOnlySpan<AsmFunctionCode> Show(ApiHostUri host, ReadOnlySpan<MethodInfo> src, FilePath dst)
        {            
            var count = src.Length;
            var code = span<CapturedCode>(count);
            var target = span<AsmFunctionCode>(count);
            
            using var writer = dst.Writer();
            using var quick = QuickCapture.create(Asm);
                        
            for(var i=0u; i<count; i++)
            {
                ref readonly var method = ref skip(src,i);
                var captured = quick.Capture(method).ValueOrDefault(CapturedCode.Empty);
                if(captured.IsNonEmpty)
                {
                    seek(code, i) = captured;                
                    var decoded = Decoder.Decode(captured).ValueOrDefault(AsmFunction.Empty);      
                    seek(target, i) = new AsmFunctionCode(decoded, captured);
                    Save(captured, writer);                                        
                }
            }
            
            return target;
        }

        void Save(CapturedCode code, StreamWriter dst)
        {
            var asm = Decoder.Decode(code).Require();
            var formatted = Formatter.FormatFunction(asm);
            dst.Write(formatted);            
        }
    }
}