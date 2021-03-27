//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmRoutineIndex : IIndex<AsmRoutine>
    {
        readonly Index<AsmRoutine> Data;

        [MethodImpl(Inline)]
        public AsmRoutineIndex(AsmRoutine[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref AsmRoutine First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ReadOnlySpan<AsmRoutine> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<AsmRoutine> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public AsmRoutine[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmRoutineIndex(AsmRoutine[] src)
            => new AsmRoutineIndex(src);

        public static AsmRoutineIndex Empty
        {
            [MethodImpl(Inline)]
            get => new AsmRoutineIndex(sys.empty<AsmRoutine>());
        }
    }
}