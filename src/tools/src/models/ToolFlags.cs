//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolFlags<F> : ITextual
        where F : unmanaged, Enum
    {
        public readonly F[] Available;
        
        [MethodImpl(Inline)]
        public ToolFlags(int i)
        {
            Available = Enums.literals<F>();
        }

        public ref readonly F this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Available[index];
        }

        public string Format()
            => Available.Format();
    }
}