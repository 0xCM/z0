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
    /// Defines a tool flag argument
    /// </summary>
    public readonly struct CmdFlagArg
    {
        /// <summary>
        /// The flag name
        /// </summary>
        public Name Name {get;}

        /// <summary>
        /// Whether the flag is enabled
        /// </summary>
        public bool Value {get;}

        [MethodImpl(Inline)]
        public CmdFlagArg(string name, bool enabled)
        {
            Name = name;
            Value = enabled;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdFlagArg(string src)
            => new CmdFlagArg(src,true);

        [MethodImpl(Inline)]
        public static implicit operator bool(CmdFlagArg src)
            => src.Value;

        [MethodImpl(Inline)]
        public static bool operator true(CmdFlagArg src)
            => src.Value;

        [MethodImpl(Inline)]
        public static bool operator false(CmdFlagArg src)
            => !src.Value;
    }
}