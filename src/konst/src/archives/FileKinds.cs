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

    public readonly struct FileKinds
    {
        readonly Type[] KindReps;

        [MethodImpl(Inline)]
        public FileKinds(Type[] src)
        {
            KindReps = src;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)KindReps.Length;
        }

        public ReadOnlySpan<Type> Reps
        {
            [MethodImpl(Inline)]
            get => KindReps;
        }
    }
}