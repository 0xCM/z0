//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;

    public ref struct CpuBuffers
    {
        [MethodImpl(Inline), Op]
        public static CpuBuffers create(uint size)
            => new CpuBuffers(size);

        [MethodImpl(Inline)]
        static CpuBuffer<N,W,T> buffer<N,W,T>()
            where N : unmanaged, ITypeNat
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CpuBuffer<N,W,T>(new T[nat64u<N>()]);

        readonly CpuBuffer<N64,W8,HexCode> step;

        readonly CpuBuffer<N64,W8,HexCode> run;

        readonly char[] log;

        [MethodImpl(Inline)]
        internal CpuBuffers(uint size)
        {
            log = memory.alloc<char>(size);
            step = buffer<N64,W8,HexCode>();
            run = buffer<N64,W8,HexCode>();
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