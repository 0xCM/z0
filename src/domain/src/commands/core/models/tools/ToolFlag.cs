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

    public readonly struct ToolFlag
    {
        /// <summary>
        /// The flag name
        /// </summary>
        public string FlagName {get;}

        [MethodImpl(Inline)]
        public ToolFlag(string name)
        {
            FlagName = name;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolFlag(string name)
            => new ToolFlag(name);
    }
}