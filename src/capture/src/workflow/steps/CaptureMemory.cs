//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using static CaptureMemoryStep;

    public ref struct CaptureMemory
    {
        readonly IWfShell Wf;

        readonly IAsmContext Root;

        readonly IAsmDecoder Decoder;

        readonly IAsmFormatter Formatter;

        readonly AsmFormatSpec FormatConfig;

        readonly byte[] ExtractBuffer;

        readonly byte[] ParseBuffer;

        [MethodImpl(Inline)]
        public CaptureMemory(IWfShell wf, IAsmContext root, int bufferlen)
        {
            Root = root;
            Wf = wf;
            Formatter = root.Formatter;
            FormatConfig = root.FormatConfig;
            ExtractBuffer = alloc<byte>(bufferlen);
            ParseBuffer = alloc<byte>(bufferlen);
            Decoder = AsmDecoderProxy.Service;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        [MethodImpl(Inline)]
        void ClearBuffers()
        {
            ExtractBuffer.Clear();
            ParseBuffer.Clear();
        }

        public CapturedMemory Run(MemoryAddress src)
        {
            Wf.Running(StepId, src);

            ClearBuffers();

            var raw = Extractors.extract(src, ExtractBuffer);
            var tryParse = Extractors.parse(raw, ParseBuffer);
            var captured = default(CapturedMemory);
            if(tryParse.IsSome())
            {
                var parsed = tryParse.Value;
                var parsedView = @readonly(parsed.Data);
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
                        var fxData = slice(parsedView, offset, size);
                        var summary = asm.Summarize(src, fx, fxData, fx.FormattedInstruction, offset);
                        seek(formatTarget,i) = Formatter.FormatInstruction(src,summary);
                        offset += size;
                    }

                    captured = new CapturedMemory(new ParsedEncoding(src, raw, parsed), decoded, formatBuffer);
                }
            }

            Wf.Ran(StepId, captured);

            return captured;
        }
    }
}