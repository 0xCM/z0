//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a tool flag argument
    /// </summary>
    public readonly struct CmdFlagArg<T>
        where T : unmanaged
    {
        /// <summary>
        /// The flag name
        /// </summary>
        public Name Name {get;}

        /// <summary>
        /// Whether the flag is enabled
        /// </summary>
        public T Value {get;}

        [MethodImpl(Inline)]
        public CmdFlagArg(string name, T value)
        {
            Name = name;
            Value = value;
        }
    }
}