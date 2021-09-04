//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct SwitchCases<C,T>
        {
            readonly Index<SwitchCase<C,T>> Data;

            [MethodImpl(Inline)]
            public SwitchCases(Index<SwitchCase<C,T>> src)
            {
                Data = src;
            }

            public Span<SwitchCase<C,T>> Edit
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
            }

            public ReadOnlySpan<SwitchCase<C,T>> View
            {
                [MethodImpl(Inline)]
                get => Data.View;
            }

            public uint Count
            {
                [MethodImpl(Inline)]
                get => Data.Count;
            }

            public ref SwitchCase<C,T> this[uint index]
            {
                [MethodImpl(Inline)]
                get => ref Data[index];
            }
        }
    }
}