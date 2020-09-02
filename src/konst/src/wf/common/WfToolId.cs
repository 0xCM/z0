//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfToolId : ITextual
    {
        public readonly StringRef Name;

        public readonly ulong Key;

        [MethodImpl(Inline)]
        public static implicit operator WfToolId(string name)
            => new WfToolId(name);

        [MethodImpl(Inline)]
        public WfToolId(string name)
        {
            Name = name;
            Key = Name.Address;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Name.Format();
    }
}