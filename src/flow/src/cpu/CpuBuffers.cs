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

    public ref struct CpuBuffers
    {
        readonly CpuBuffer<N64,W8,HexCode> step;

        readonly CpuBuffer<N64,W8,HexCode> run;

        readonly char[] log;

        [MethodImpl(Inline)]
        public CpuBuffers(uint size)
        {
            log = z.alloc<char>(size);
            step = CpuBuffer.alloc<N64,W8,HexCode>();
            run = CpuBuffer.alloc<N64,W8,HexCode>();
        }

        [MethodImpl(Inline), Op]
        public Span<HexCode> Step()
        {
            step.Clear(w128);
            return step.Edit;
        }

        [MethodImpl(Inline), Op]
        public Span<HexCode> Run()
            => run.Edit;

        [MethodImpl(Inline), Op]
        public Span<char> Log()
        {
            Span<char> buffer = log;
            buffer.Clear();
            return buffer;
        }
    }
}