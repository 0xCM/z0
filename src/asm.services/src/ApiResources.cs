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

    public readonly struct ApiResources
    {
        public static CapturedApiResource[] capture(IAsmContext context, ApiHostUri host, FS.FilePath dst)
            => capture(context, host, Resources.accessors(context.ContextRoot.Api.Components), dst);

        public static CapturedApiResource[] capture(IAsmContext context, ApiHostUri host, ReadOnlySpan<ApiResource> src, FS.FilePath dst)
        {
            var count = src.Length;
            var codes = span(alloc<ApiCaptureBlock>(count));
            var captured = alloc<CapturedApiResource>(count);
            var target = span(captured);

            using var writer = dst.Writer();
            using var quick = QuickCapture.create(context);

            for(var i=0u; i<count; i++)
            {
                ref readonly var accessor = ref skip(src,i);
                var code = quick.Capture(accessor.Member).ValueOrDefault(ApiCaptureBlock.Empty);
                seek(codes, i) = code;

                if(code.IsNonEmpty)
                {
                    ref readonly var data = ref skip(codes,i);
                    seek(target, i) = new CapturedApiResource(host, accessor, routine(context, data).ValueOrDefault(AsmRoutineCode.Empty));
                    save(context, data, writer);
                }
            }

            return captured;
        }

        public static CapturedApiResource[] capture(IAsmContext context, FS.FilePath src, FS.FolderPath dst)
        {
            var resdll = Assembly.LoadFrom(src.Name);
            var indices = span(Resources.declarations(resdll));
            var count = indices.Length;

            var results = list<CapturedApiResource>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var index = ref skip(indices,i);
                var host = WfCore.uri(index.DeclaringType);
                var path = dst + host.FileName(FileExtensions.Asm);
                results.AddRange(capture(context, host, index.Data, path));
            }

            return results.ToArray();
        }

        static Option<AsmRoutineCode> routine(IAsmContext context, ApiCaptureBlock capture)
        {
            var decoded = context.RoutineDecoder.Decode(capture);
            if(decoded)
                return new AsmRoutineCode(decoded.Value, capture);
            else
                return z.none<AsmRoutineCode>();
        }

        static void save(IAsmContext context, ApiCaptureBlock capture, StreamWriter dst)
        {
            var asm = context.RoutineDecoder.Decode(capture).Require();
            var formatted = context.Formatter.FormatFunction(asm);
            dst.Write(formatted);
        }
    }
}