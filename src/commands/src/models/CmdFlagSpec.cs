//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a tool flag argument
    /// </summary>
    public readonly struct CmdFlagSpec
    {
        /// <summary>
        /// The index of this flag relative to other flags in a collection
        /// </summary>
        public ushort Index {get;}

        /// <summary>
        /// The flag name
        /// </summary>
        public AsciBlock<N32> Name {get;}

        [MethodImpl(Inline)]
        public CmdFlagSpec(AsciBlock<N32> name, ushort index)
        {
            Index = index;
            Name = name;
        }

        public string Format()
            => Cmd.format(this);

        public override string ToString()
            => Format();
    }
}