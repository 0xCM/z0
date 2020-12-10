//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct CallClient
    {
        /// <summary>
        /// The clients's operation identifier
        /// </summary>
        public StringRef Id;

        /// <summary>
        /// The clients's base address
        /// </summary>
        public MemoryAddress Base;

        [MethodImpl(Inline)]
        public CallClient(MemoryAddress @base)
        {
            Id = EmptyString;
            Base = @base;
        }

        [MethodImpl(Inline)]
        public CallClient(string id, MemoryAddress @base)
        {
            Id = id;
            Base = @base;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.concat(Base.Format(), Chars.Colon, Chars.Space, Id.Format());

        public override string ToString()
            => Format();
    }
}