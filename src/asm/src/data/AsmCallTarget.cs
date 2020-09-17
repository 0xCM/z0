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

    public struct AsmCallTarget
    {
        /// <summary>
        /// The target's identifier
        /// </summary>
        public StringRef Id;

        /// <summary>
        /// The target's base address
        /// </summary>
        public MemoryAddress Base;

        [MethodImpl(Inline)]
        public AsmCallTarget(MemoryAddress @base)
        {
            Id = EmptyString;
            Base = @base;
        }

        [MethodImpl(Inline)]
        public AsmCallTarget(string id, MemoryAddress @base)
        {
            Id = id;
            Base = @base;
        }

        public string Format()
            => text.concat(Base.Format(), Chars.Colon, Chars.Space, ifempty(Id, "target"));

        public override string ToString()
            => Format();
    }
}