//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolOption<F> : IToolOption<F>
        where F : unmanaged
    {
        public StringRef Name {get;}

        public F Id {get;}

        public utf8 Value {get;}

        [MethodImpl(Inline)]
        public ToolOption(string name, F id, string value)
        {
            Name = name;
            Id = id;
            Value = value;
        }
    }
}