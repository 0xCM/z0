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
    
    partial struct AccessorCapture
    {
        public CapturedAccessor[] CaptureAsm(ApiHostUri host, ReadOnlySpan<ResourceAccessor> src, FilePath dst)
        {            
            var srcount = src.Length;
            var codes = span(alloc<CapturedCode>(srcount));
            var captured = alloc<CapturedAccessor>(srcount);
            var target = span(captured);
            
            using var writer = dst.Writer();
            using var quick = QuickCapture.Alloc(Context);
                        
            for(var i=0u; i<srcount; i++)
            {
                ref readonly var accessor = ref skip(src,i);

                var code = quick.Capture(accessor.Member).ValueOrDefault(CapturedCode.Empty);
                seek(codes, i) = code;
                
                if(code.IsNonEmpty)
                {
                    ref readonly var data = ref skip(codes,i);                    
                    seek(target, i) = new CapturedAccessor(host, accessor, CreatFunction(data).ValueOrDefault(AsmFunctionCode.Empty));
                    WriteAsm(data, writer);                                        
                }
            }
            
            return captured;
        }
    }
}