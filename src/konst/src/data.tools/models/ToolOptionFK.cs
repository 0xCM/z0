//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolOption<F,K> : IToolOption<F,K>
        where F : unmanaged
        where K : unmanaged
    {
        public StringRef Name {get;}

        public F Id {get;}

        public K Value {get;}

        [MethodImpl(Inline)]
        public ToolOption(string name, F id, K value)
        {
            Name = name;
            Id = id;
            Value = value;
        }
    }
}