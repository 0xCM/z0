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

    public readonly ref struct CpuBuffer<T>
    {
        readonly Span<T> Data;

        [MethodImpl(Inline)]
        internal CpuBuffer(T[] data)
        {
            Data = data;
        }

        public Span<T> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}