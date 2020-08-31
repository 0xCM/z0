//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    partial struct Recapture
    {
        public CapturedAccessor[] Capture(ApiHostUri host, FilePath dst)
            => Capture(host, ApiQuery.resources(Context.ContextRoot.Api.Composition.Assemblies), dst);

        public CapturedAccessor[] Capture(ApiHostUri host, ReadOnlySpan<ResourceAccessor> src, FilePath dst)
        {
            var count = src.Length;
            var codes = span(alloc<X86ApiCapture>(count));
            var captured = alloc<CapturedAccessor>(count);
            var target = span(captured);

            using var writer = dst.Writer();
            using var quick = QuickCapture.create(Context);

            for(var i=0u; i<count; i++)
            {
                ref readonly var accessor = ref skip(src,i);
                var code = quick.Capture(accessor.Member).ValueOrDefault(X86ApiCapture.Empty);
                seek(codes, i) = code;

                if(code.IsNonEmpty)
                {
                    ref readonly var data = ref skip(codes,i);
                    seek(target, i) = new CapturedAccessor(nameof(Recapture), host, accessor, CreateFunction(data).ValueOrDefault(AsmRoutineCode.Empty));
                    Save(data, writer);
                }
            }

            return captured;
        }

        Option<AsmRoutineCode> CreateFunction(X86ApiCapture capture)
        {
            var decoded = Context.RoutineDecoder.Decode(capture);
            if(decoded)
                return new AsmRoutineCode(decoded.Value, capture);
            else
                return z.none<AsmRoutineCode>();
        }
    }
}