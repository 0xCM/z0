//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmRecordSets<T>
    {
        readonly AsmRecordSet<T>[] Data;

        [MethodImpl(Inline)]
        public AsmRecordSets(params AsmRecordSet<T>[] src)
            => Data = src;

        public ReadOnlySpan<AsmRecordSet<T>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}