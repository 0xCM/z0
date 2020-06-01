//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm.Data;

    using static Seed;
    using static Memories;

    readonly struct AsmParseCases
    {
        public const string Case01 = "002ch vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}";

    }

    [ApiHost]
    public struct Cpu
    {
        readonly ByteBuffer<HexCode> _StepBuffer;

        readonly ByteBuffer<HexCode> _RunBuffer;

        readonly char[] _LogBuffer;

        int _RunIndex;

        [MethodImpl(Inline), Op]
        public static Cpu alloc()
            => new Cpu(0);

        [MethodImpl(Inline), Op]
        public static Cpu init(char[] logBuffer, in ByteBuffer<HexCode> stepBuffer, in ByteBuffer<HexCode> runBuffer) 
            => new Cpu(logBuffer,stepBuffer,runBuffer);

        const int DefaultBufferSize = ByteBuffer.BufferSize;

        [MethodImpl(Inline)]
        internal Cpu(char[] logBuffer, in ByteBuffer<HexCode> stepBuffer, in ByteBuffer<HexCode> runBuffer)
        {
            _LogBuffer = logBuffer;
            _StepBuffer = stepBuffer;
            _RunBuffer = runBuffer;
            _RunIndex = 0;
        }

        [MethodImpl(Inline)]
        internal Cpu(int runidx)
        {
            _LogBuffer = Control.alloc<char>(DefaultBufferSize);
            _StepBuffer = ByteBuffer.Init(Control.alloc<HexCode>(DefaultBufferSize));
            _RunBuffer = ByteBuffer.Init(Control.alloc<HexCode>(DefaultBufferSize));            
            _RunIndex = runidx;
        }

        [MethodImpl(Inline), Op]
        Span<HexCode> StepBuffer()
        {            
            _StepBuffer.Clear(w128);
            return _StepBuffer.Content;
        }

        [MethodImpl(Inline), Op]
        Span<char> LogBuffer()
        {
            Span<char> buffer = _LogBuffer;
            buffer.Clear();
            return buffer;                
        }

        Span<HexCode> RunBuffer
        {
            [MethodImpl(Inline)]
            get => _RunBuffer.Content;
        }

        [Op, MethodImpl(Inline)]
        public void Run()
        {            
            var data = 0xCE_38ul;
            var command = Asm.Data.Commands.encode(data);
            Dispatch(command);

            var steps = RunBuffer.Slice(0, _RunIndex);
            var buffer = LogBuffer();
            var count = Symbolic.render(steps, buffer);
            var hexline = buffer.Slice(0,count).ToString();
            term.print(hexline);

            var seq = 0;
            var parsed = Asm.Data.AsmCommandParser.ParseAsmLine(AsmParseCases.Case01,ref seq);
            if(parsed)
                term.print($"{parsed.Value.Statement.ToString()}");
            else
                term.print("Parse failed");
        }

        void Notify(CpuEvent e)
        {
            term.print(e);
        }

        [Op, MethodImpl(Inline)]
        public void Run(ulong data)
        {
            Dispatch(Asm.Data.Commands.encode(data));
        }

        [Op, MethodImpl(Inline)]
        public void Dispatch(in EncodedCommand src)
        {
            Execute(src.Encoding);
        }

        [Op, MethodImpl]
        public void Execute(in ReadOnlySpan<byte> src)
        {
            var buffer = StepBuffer();
            var count = Symbolic.codes(src, UpperCased.Case, buffer);
            var ran = buffer.Slice(0, count);
            ran.CopyTo(RunBuffer, _RunIndex);
            _RunIndex += count;
        }
    }
}