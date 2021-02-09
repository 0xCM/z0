//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmRoutines : IIndex<AsmRoutine>
    {
        public readonly AsmRoutine[] Data;

        [MethodImpl(Inline)]
        public AsmRoutines(AsmRoutine[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ref AsmRoutine First
        {
            [MethodImpl(Inline)]
            get => ref Data[0];
        }

        public ReadOnlySpan<AsmRoutine> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public AsmRoutine[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmRoutines(AsmRoutine[] src)
            => new AsmRoutines(src);

        public static AsmRoutines Empty
        {
            [MethodImpl(Inline)]
            get => new AsmRoutines(sys.empty<AsmRoutine>());
        }
    }
}