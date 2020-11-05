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

    /// <summary>
    /// Reprents a tool command operand that accepts no arguments; the presence of a flag is the argument
    /// </summary>
    public readonly struct ToolFlag<F>
        where F : unmanaged
    {
        public F FlagValue {get;}

        [MethodImpl(Inline)]
        public ToolFlag(F value)
             => FlagValue = value;

        [MethodImpl(Inline)]
        public static implicit operator ToolFlag<F>(F value)
            => new ToolFlag<F>(value);
    }
}