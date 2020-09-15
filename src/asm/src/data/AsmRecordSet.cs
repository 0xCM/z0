//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmRecordSet<T>
    {
        public readonly T Key;

        readonly AsmRecord[] Records;

        [MethodImpl(Inline)]
        public static implicit operator AsmRecord[](AsmRecordSet<T> src)
            => src.Records;

        [MethodImpl(Inline)]
        public AsmRecordSet(T key, AsmRecord[] data)
        {
            Key = key;
            Records = data;
        }

        public AsmRecord[] Sequenced
        {
            [MethodImpl(Inline)]
            get => Records.OrderBy(x => x.Sequence);
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Records.Length;
        }
    }
}