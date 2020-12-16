//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using Z0.Asm;

    public sealed class CaptureMemory : WfHost<CaptureMemory>
    {
        IAsmContext Asm;

        MemoryAddress[] Sources;

        /// <summary>
        /// Creates a memory capture service
        /// </summary>
        /// <param name="buffer">The buffer size to allocate</param>
        public static CaptureMemory create(IAsmContext asm, MemoryAddress[] addresses)
        {
            var host = new CaptureMemory();
            host.Asm = asm;
            host.Sources = addresses;
            return host;
        }

        protected override void Execute(IWfShell wf)
        {
            using var step = new CaptureMemoryStep(wf, this, Asm, Sources);
            step.Run();
        }
    }

    ref struct CaptureMemoryStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IAsmDecoder Decoder;

        readonly IAsmFormatter Formatter;

        readonly byte[] ExtractBuffer;

        readonly byte[] ParseBuffer;

        public readonly ReadOnlySpan<MemoryAddress> Sources;

        public readonly uint SourceCount;

        public readonly Span<CapturedBlock> Captured;

        [MethodImpl(Inline)]
        public CaptureMemoryStep(IWfShell wf, WfHost host, IAsmContext asm, MemoryAddress[] addresses, uint bufferlen = Pow2.T14)
        {
            Host = host;
            Wf = wf;
            Formatter = asm.Formatter;
            ExtractBuffer = alloc<byte>(bufferlen);
            ParseBuffer = alloc<byte>(bufferlen);
            Decoder = asm.RoutineDecoder;
            Sources = addresses;
            SourceCount = (uint)addresses.Length;
            Captured = alloc<CapturedBlock>(SourceCount);
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        [MethodImpl(Inline)]
        void ClearBuffers()
        {
            ExtractBuffer.Clear();
            ParseBuffer.Clear();
        }

        public void Run()
        {
            ref readonly var address = ref first(Sources);
            for(var i=0u; i<SourceCount; i++)
                seek(Captured,i) = Capture(skip(Sources,i));
        }

        CapturedBlock Capture(MemoryAddress src)
        {
            Wf.Running(Host, src);

            ClearBuffers();

            var raw = ApiCodeExtractors.extract(src, ExtractBuffer);
            var tryParse = ApiCodeExtractors.parse(raw, ParseBuffer);
            var captured = default(CapturedBlock);
            if(tryParse.IsSome())
            {
                var parsed = tryParse.Value;
                var parsedView = parsed.Code.View;
                var tryDecode = Decoder.Decode(parsed);
                if(tryDecode.IsSome())
                {
                    var decoded = tryDecode.Value;
                    var fxView = decoded.View;
                    var count = decoded.Length;
                    var formatBuffer = alloc<string>(count);
                    var formatTarget = span(formatBuffer);
                    ushort offset = 0;
                    for(ushort i=0; i<count; i++)
                    {
                        ref readonly var fx = ref skip(fxView, i);
                        var size = (byte)fx.ByteLength;
                        var summary = asm.Summarize(src, fx, new CodeBlock(src + offset, slice(parsedView, offset, size).ToArray()), fx.FormattedInstruction, offset);
                        seek(formatTarget,i) = Formatter.FormatInstruction(src,summary);
                        offset += size;
                    }

                    captured = new CapturedBlock(new CapturedCodeBlock(src, raw, parsed), decoded, formatBuffer);
                }
            }

            Wf.Ran(Host, captured);

            return captured;
        }
    }
}