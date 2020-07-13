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

    [ApiHost]
    public readonly struct CpuBuffers
    {
        readonly CpuBuffer<N64,W8,HexCode> step;        

        readonly CpuBuffer<N64,W8,HexCode> run;

        readonly char[] log;

        [MethodImpl(Inline), Op]
        public static CpuBuffers Alloc(int size)
            => new CpuBuffers(size);
        
        [MethodImpl(Inline)]
        internal CpuBuffers(int size)
        {
            log = Root.alloc<char>(size);
            step = CpuBuffer.Alloc<N64,W8,HexCode>();
            run = CpuBuffer.Alloc<N64,W8,HexCode>();
        }

        [MethodImpl(Inline), Op]
        public Span<HexCode> Step()
        {            
            step.Clear(w128);
            return step.Content;
        }

        [MethodImpl(Inline), Op]
        public Span<HexCode> Run()        
            => run.Content;

        [MethodImpl(Inline), Op]
        public Span<char> Log()
        {
            Span<char> buffer = log;
            buffer.Clear();
            return buffer;                
        }
    }
}