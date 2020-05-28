//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    [ApiHost]
    public class Cpu : IApiHost<Cpu>
    {
        public static Cpu Create()
            => new Cpu();

        const int BufferSize = ByteBuffer.BufferSize;

        ByteBuffer<HexCode> _StepBuffer;

        ByteBuffer<HexCode> _RunBuffer;

        char[] _LogBuffer;

        int _RunIndex;

        public Cpu()
        {
            _LogBuffer = Control.alloc<char>(BufferSize);
            _StepBuffer = ByteBuffer.Init(Control.alloc<HexCode>(BufferSize));
            _RunBuffer = ByteBuffer.Init(Control.alloc<HexCode>(BufferSize));            
            _RunIndex = 0;
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

        [Op]
        public void Run()
        {
            Commands.Extract();
            
            var data = 0xCE_38ul;
            Run(data);
            var steps = RunBuffer.Slice(0, _RunIndex);
            var buffer = LogBuffer();
            var count = Symbolic.render(steps, buffer);
            var hexline = buffer.Slice(0,count).ToString();
            term.print(hexline);
        }

        [Op, MethodImpl(Inline)]
        public void Run(ulong data)
            => Dispatch(Commands.define(data));

        [Op, MethodImpl(Inline)]
        public void Dispatch(in Command src)
        {
            var bytes = src.Encoded.Slice(0,src.Size);
            Execute(bytes);
        }

        [Op]
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