//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmRoutines
    {
        public readonly AsmRoutine[] Data;

        [MethodImpl(Inline)]
        public static implicit operator AsmRoutines(AsmRoutine[] src)
            => new AsmRoutines(src);

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
    }
}