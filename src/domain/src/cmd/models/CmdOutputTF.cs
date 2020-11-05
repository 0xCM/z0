//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct CmdOutput<T,F>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {
        readonly CmdTarget<T,F>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator CmdOutput<T,F>(CmdTarget<T,F>[] src)
            => new CmdOutput<T,F>(src);

        [MethodImpl(Inline)]
        public CmdOutput(CmdTarget<T,F>[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }
        public ref CmdTarget<T,F> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ReadOnlySpan<CmdTarget<T,F>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<CmdTarget<T,F>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}
