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
    public readonly struct CmdFlagSpec
    {
        /// <summary>
        /// The index of this flag relative to other flags in a collection
        /// </summary>
        public byte Index {get;}

        /// <summary>
        /// The flag name
        /// </summary>
        public Name Name {get;}

        [MethodImpl(Inline)]
        public CmdFlagSpec(byte index)
        {
            Index = index;
            Name = EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdFlagSpec(string name)
        {
            Index = 0;
            Name = EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdFlagSpec(byte index, string name)
        {
            Index = index;
            Name = name;
        }

        [MethodImpl(Inline)]
        public CmdFlagSpec WithIndex(byte index)
            => new CmdFlagSpec(index,Name);

        [MethodImpl(Inline)]
        public CmdFlagSpec WithName(string name)
            => new CmdFlagSpec(Index,name);

        public string Format()
            => Cmd.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdFlagSpec(byte index)
            => new CmdFlagSpec(index);

        [MethodImpl(Inline)]
        public static implicit operator CmdFlagSpec(string name)
            => new CmdFlagSpec(name);
    }
}