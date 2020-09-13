//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiDataType]
    public readonly struct X86ApiMembers
    {
        readonly TableSpan<X86ApiMember> Data;

        [MethodImpl(Inline)]
        public static implicit operator X86ApiMembers(X86ApiMember[] src)
            => new X86ApiMembers(src);

        [MethodImpl(Inline)]
        public X86ApiMembers(X86ApiMember[] src)
            => Data = src;

        public ReadOnlySpan<X86ApiMember> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<X86ApiMember> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref X86ApiMember First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public X86ApiMember[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}