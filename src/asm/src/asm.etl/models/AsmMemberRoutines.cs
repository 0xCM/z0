//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmMemberRoutines : IIndex<AsmMemberRoutine>
    {
        readonly Index<AsmMemberRoutine> Data;

        [MethodImpl(Inline)]
        public AsmMemberRoutines(AsmMemberRoutine[] src)
            => Data = src;

        public Index<AsmRoutine> AsmRoutines
        {
            [MethodImpl(Inline)]
            get => Data.Select(x => x.Routine);
        }
        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref AsmMemberRoutine First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ReadOnlySpan<AsmMemberRoutine> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<AsmMemberRoutine> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public AsmMemberRoutine[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmMemberRoutines(AsmMemberRoutine[] src)
            => new AsmMemberRoutines(src);

        public static AsmMemberRoutines Empty
        {
            [MethodImpl(Inline)]
            get => new AsmMemberRoutines(sys.empty<AsmMemberRoutine>());
        }
    }
}