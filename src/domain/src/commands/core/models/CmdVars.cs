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

    public readonly struct CmdVars
    {
        readonly CmdVar[] Data;

        [MethodImpl(Inline)]
        public CmdVars(CmdVar[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator CmdVars(CmdVar[] src)
            => new CmdVars(src);

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