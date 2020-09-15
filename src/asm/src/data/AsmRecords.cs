//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmRecords
    {
        readonly AsmRecord[] Data;

        [MethodImpl(Inline)]
        public static implicit operator AsmRecords(AsmRecord[] src)
            => new AsmRecords(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmRecord[](AsmRecords src)
            => src.Data;

        [MethodImpl(Inline)]
        public AsmRecords(AsmRecord[] src)
        {
            Data = src;
        }

        public AsmRecord[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}