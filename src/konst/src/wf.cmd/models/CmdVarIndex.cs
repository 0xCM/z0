//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdVarIndex : IIndex<CmdVar>
    {
        readonly CmdVar[] Data;

        [MethodImpl(Inline)]
        public CmdVarIndex(CmdVar[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator CmdVarIndex(CmdVar[] src)
            => new CmdVarIndex(src);

        public CmdVar[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<CmdVar> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<CmdVar> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public byte Count
        {
            [MethodImpl(Inline)]
            get => (byte)Data.Length;
        }

        public ref CmdVar this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}