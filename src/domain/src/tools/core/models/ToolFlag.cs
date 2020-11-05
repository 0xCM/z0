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
    public readonly struct ToolFlag
    {
        public string FlagValue {get;}

        [MethodImpl(Inline)]
        public ToolFlag(string name)
            => FlagValue = name;

        [MethodImpl(Inline)]
        public static implicit operator ToolFlag(string name)
            => new ToolFlag(name);
    }
}