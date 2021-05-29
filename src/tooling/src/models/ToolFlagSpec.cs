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
    public readonly struct ToolFlagSpec
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
        public ToolFlagSpec(byte index)
        {
            Index = index;
            Name = EmptyString;
        }

        [MethodImpl(Inline)]
        public ToolFlagSpec(string name)
        {
            Index = 0;
            Name = EmptyString;
        }

        [MethodImpl(Inline)]
        public ToolFlagSpec(byte index, string name)
        {
            Index = index;
            Name = name;
        }

        [MethodImpl(Inline)]
        public ToolFlagSpec WithIndex(byte index)
            => new ToolFlagSpec(index,Name);

        [MethodImpl(Inline)]
        public ToolFlagSpec WithName(string name)
            => new ToolFlagSpec(Index,name);

        public string Format()
            => ToolCmd.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ToolFlagSpec(byte index)
            => new ToolFlagSpec(index);

        [MethodImpl(Inline)]
        public static implicit operator ToolFlagSpec(string name)
            => new ToolFlagSpec(name);
    }
}