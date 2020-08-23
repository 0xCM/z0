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
    using static CaptureAlt;
    using static z;

    public readonly ref struct Reveal
    {
        readonly IAppContext Root;

        readonly IAsmContext Asm;

        readonly IAsmDecoder Decoder;

        readonly IAsmFormatter Formatter;

        readonly ICaptureServices Services;

        readonly Span<byte> Buffer;

        public Reveal(IAppContext root)
        {
            Root = root;
            Asm = WfBuilder.asm(root);
            Services = CaptureServices.create(Asm);
            var format = AsmFormatSpec.DefaultStreamFormat;
            Formatter = Services.Formatter(format);
            Decoder = Services.RoutineDecoder(format);
            Buffer = sys.alloc<byte>(Pow2.T16);
        }

        public ReadOnlySpan<AsmRoutineCode> FunctionCode(FolderPath root)
        {
            var assemblies = span(Root.Composition.Assemblies);
            var dst = list<AsmRoutineCode>();
            var count = assemblies.Length;
            for(var i=0; i<count; i++)
            {
                var ass = skip(assemblies,i);
                dst.AddRange(Capture(ass));

            }
            return dst.ToArray();
        }

        public AsmRoutineCode[] Capture(Assembly src)
        {
            var dataTypes = span(src.Types().Tagged<ApiDataTypeAttribute>());
            var apiHosts = span(src.Types().Tagged<ApiHostAttribute>());
            var dtCount = dataTypes.Length;
            var apiHostCount = apiHosts.Length;

            var dst = list<AsmRoutineCode>();
            for(var j=0u; j<dtCount; j++)
            {
                var type = skip(dataTypes,j);
                var uri = Flow.uri(type);
                var methods = span(type.Methods().Concrete().NonGeneric().Unignored());

                var mCount = methods.Length;

                for(var k=0u; k<mCount; k++)
                {
                    ref readonly var method = ref skip(methods,k);
                    var identified = IdentifiedMethod.Define(identify(method), method);
                    var code = capture(identified, Buffer);
                    var f = Decoder.Decode(code).Require();
                    dst.Add(new AsmRoutineCode(f, code));
                }
            }

            for(var j=0u; j<apiHostCount; j++)
            {
                var host = skip(apiHosts, j);
                var uri = Flow.uri(host);
                var methods = host.DeclaredMethods().NonGeneric().Concrete();
                var mCount = methods.Length;
            }

            return dst.ToArray();
        }

        public ReadOnlySpan<AsmRoutineCode> Capture(ApiHostUri host, ReadOnlySpan<MethodInfo> src, FilePath dst)
        {
            var count = src.Length;
            var code = span<CapturedCode>(count);
            var target = span<AsmRoutineCode>(count);

            using var writer = dst.Writer();
            using var quick = QuickCapture.create(Asm);

            for(var i=0u; i<count; i++)
            {
                ref readonly var method = ref skip(src,i);
                var captured = quick.Capture(method).ValueOrDefault(CapturedCode.Empty);
                if(captured.IsNonEmpty)
                {
                    seek(code, i) = captured;
                    var decoded = Decoder.Decode(captured).ValueOrDefault(AsmRoutine.Empty);
                    seek(target, i) = new AsmRoutineCode(decoded, captured);
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

        static OpIdentity identify(MethodInfo src)
            => Identity.identify(src);
    }
}