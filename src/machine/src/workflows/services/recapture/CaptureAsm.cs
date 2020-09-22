//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.IO;

    using Z0.Asm;

    using static Konst;
    using static z;

    partial struct Recapture
    {
        void Save(ApiCaptureBlock capture, StreamWriter dst)
        {
            var asm = Context.RoutineDecoder.Decode(capture).Require();
            var formatted = Context.Formatter.FormatFunction(asm);
            dst.Write(formatted);
        }

        public CapturedAccessor[] Capture(ApiHostUri host, FilePath dst)
            => Capture(host, ApiQuery.resources(Context.ContextRoot.Api.Components), dst);

        public CapturedAccessor[] Capture(ApiHostUri host, ReadOnlySpan<ResourceAccessor> src, FilePath dst)
        {
            var count = src.Length;
            var codes = span(alloc<ApiCaptureBlock>(count));
            var captured = alloc<CapturedAccessor>(count);
            var target = span(captured);

            using var writer = dst.Writer();
            using var quick = QuickCapture.create(Context);

            for(var i=0u; i<count; i++)
            {
                ref readonly var accessor = ref skip(src,i);
                var code = quick.Capture(accessor.Member).ValueOrDefault(ApiCaptureBlock.Empty);
                seek(codes, i) = code;

                if(code.IsNonEmpty)
                {
                    ref readonly var data = ref skip(codes,i);
                    seek(target, i) = new CapturedAccessor(nameof(Recapture), host, accessor, CreateFunction(data).ValueOrDefault(AsmRoutineCode.Empty), default);
                    Save(data, writer);
                }
            }

            return captured;
        }

        Option<AsmRoutineCode> CreateFunction(ApiCaptureBlock capture)
        {
            var decoded = Context.RoutineDecoder.Decode(capture);
            if(decoded)
                return new AsmRoutineCode(decoded.Value, capture);
            else
                return z.none<AsmRoutineCode>();
        }

        /// <summary>
        /// All of your resbytes belong to us
        /// </summary>
        public void CaptureResBytes()
        {
            var resfile = z.insist(ResBytesCompiled);
            var captured = Capture(resfile, ResBytesUncompiled);
            var csvfile = ResIndexDir + FileName.define("z0.res.bytes", FileExtensions.Csv);
            SaveIndex(captured, csvfile);
        }

        public CapturedAccessor[] Capture(FilePath src, FolderPath dst)
        {
            var resdll = Assembly.LoadFrom(src.Name);
            var indices = span(Resources.declarations(resdll));
            var count = indices.Length;

            term.magenta($"Capturing {count} host resource sets from {src} -> {dst}");

            var results = list<CapturedAccessor>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var index = ref skip(indices,i);
                var host = Flow.uri(index.DeclaringType);
                var path = dst + host.FileName(FileExtensions.Asm);
                results.AddRange(Capture(host, index.Data, path));
            }

            var data = results.ToArray();
            term.print(new CapturedResourceSets(nameof(Recapture), data, src, dst));
            return data;
        }
    }
}