//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential)]
    public struct TokenRecord
    {
        public Sequential Index;

        public StringRef Identifier;

        public StringRef Value;

        public StringRef Description;

        [MethodImpl(Inline)]
        public TokenRecord(uint index, string id, string value, string description)
        {
            Index = index;
            Identifier = id ?? EmptyString;
            Value = value ?? EmptyString;
            Description = description ?? EmptyString;
        }
    }
}