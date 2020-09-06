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
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;
    using static z;

    public readonly ref struct CapturePart
    {
        readonly IAsmContext Asm;

        readonly IAsmDecoder Decoder;

        readonly IAsmFormatter Formatter;

        readonly ICaptureServices Services;

        readonly IWfShell Wf;

        readonly Span<byte> Buffer;

        readonly CapturePartStep Host;

        public CapturePart(IWfShell wf, IAsmContext asm, CapturePartStep host)
        {
            Wf = wf;
            Asm = asm;
            Host = host;
            Services = CaptureServices.create(Asm);
            var format = AsmFormatSpec.DefaultStreamFormat;
            Formatter = Services.Formatter(format);
            Decoder = Services.RoutineDecoder(format);
            Buffer = sys.alloc<byte>(Pow2.T16);
            Wf.Created(Host.Id);
        }


        public void Dispose()
        {
            Wf.Disposed(Host.Id);
        }

        static IMultiDiviner Diviner
            => MultiDiviner.Service;

        public static ReadOnlySpan<IdentifiedMethod> methods(ApiDataType[] src)
        {
            var dst = z.list<IdentifiedMethod>();
            var count = src.Length;
            var exclusions = new HashSet<string>(new string[4]{"ToString","GetHashCode", "Equals", "ToString"});

            for(var i=0; i<count; i++)
            {
                var host = src[i];
                dst.AddRange(host.HostType.DeclaredMethods().Unignored().NonGeneric().Exclude(exclusions).Select(m => new IdentifiedMethod(Diviner.Identify(m),m)));
            }
            return dst.ToArray();
        }

        public ReadOnlySpan<AsmMemberRoutine> Capture(Assembly src)
        {
            Wf.Running(Host.Id);

            var buffer = span<byte>(Pow2.T14);
            var catalog = ApiQuery.catalog(src);
            var members = methods(catalog.ApiDataTypes);
            var count = members.Length;
            var target = sys.alloc<AsmMemberRoutine>(count);
            var dst = span(target);
            for(var j=0u; j<count; j++)
            {
                buffer.Clear();

                ref readonly var method = ref skip(members, j);
                var capture = CaptureAlt.capture(method,buffer);
                var decoded = Decoder.Decode(capture).Require();
                seek(dst, j).Member = method;
                seek(dst, j).Encoded = capture;
                seek(dst, j).Routine = decoded;
                seek(dst, j).Asm = Formatter.FormatFunction(decoded);
            }

            Array.Sort(target);

            Wf.Ran(Host.Id);

            return dst;
        }

        public ReadOnlySpan<AsmRoutineCode> Capture(ApiHostUri host, ReadOnlySpan<MethodInfo> src, FilePath dst)
        {
            var count = src.Length;
            var code = span<X86ApiCapture>(count);
            var target = span<AsmRoutineCode>(count);

            using var writer = dst.Writer();
            using var quick = QuickCapture.create(Asm);

            for(var i=0u; i<count; i++)
            {
                ref readonly var method = ref skip(src,i);
                var captured = quick.Capture(method).ValueOrDefault(X86ApiCapture.Empty);
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

        void Save(X86ApiCapture code, StreamWriter dst)
        {
            var asm = Decoder.Decode(code).Require();
            var formatted = Formatter.FormatFunction(asm);
            dst.Write(formatted);
        }
    }
}