//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using Z0.Asm;

    public readonly struct MemoryCapture
    {
        /// <summary>
        /// Creates a memory capture service
        /// </summary>
        /// <param name="buffer">The buffer size to allocate</param>
        public static MemoryCapture service(IWfShell wf, IAsmContext asm)
            => new MemoryCapture(wf, asm);

        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IAsmDecoder Decoder;

        readonly IAsmFormatter Formatter;

        readonly byte[] ExtractBuffer;

        readonly byte[] ParseBuffer;

        [MethodImpl(Inline)]
        internal MemoryCapture(IWfShell wf, IAsmContext asm, uint bufferlen = Pow2.T14)
        {
            Host = WfShell.host(typeof(MemoryCapture));
            Wf = wf.WithHost(Host);
            Formatter = asm.Formatter;
            ExtractBuffer = alloc<byte>(bufferlen);
            ParseBuffer = alloc<byte>(bufferlen);
            Decoder = asm.RoutineDecoder;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        [MethodImpl(Inline)]
        void ClearBuffers()
        {
            ExtractBuffer.Clear();
            ParseBuffer.Clear();
        }

        public CapturedBlock Capture(MemoryAddress src)
        {
            var flow = Wf.Running(src);

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
                        var summary = IceExtractors.Summarize(src, fx, new CodeBlock(src + offset, slice(parsedView, offset, size).ToArray()), fx.FormattedInstruction, offset);
                        seek(formatTarget,i) = Formatter.FormatInstruction(src, summary);
                        offset += size;
                    }

                    captured = new CapturedBlock(new CapturedCodeBlock(src, raw, parsed), decoded, formatBuffer);
                }
            }

            Wf.Ran(flow, captured);

            return captured;
        }
    }
}