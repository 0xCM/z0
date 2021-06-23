//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct RegName
    {
        readonly ulong Data;

        [MethodImpl(Inline)]
        internal RegName(ulong data)
        {
            Data = data;
        }

        public string Format()
            => AsmRegNames.format(this);
    }
}