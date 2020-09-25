//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TokenInfoTable
    {
        public const byte FieldCount = 4;

        public static ReadOnlySpan<byte> FieldWidths
            => new byte[FieldCount]{10,16,16,60};

        public static Type TableType
            => typeof(TokenInfo);

        public static ReadOnlySpan<string> FieldNames
            => Fields.Map(f => f.Name);

        public static ReadOnlySpan<FieldInfo> Fields
            => TableType.DeclaredInstanceFields();
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TokenInfo
    {
        public Sequential Index;

        public StringRef Identifier;

        public StringRef Value;

        public StringRef Description;

        [MethodImpl(Inline)]
        public TokenInfo(uint index, string id, string value, string description)
        {
            Index = index;
            Identifier = id ?? EmptyString;
            Value = value ?? EmptyString;
            Description = description ?? EmptyString;
        }
    }
}