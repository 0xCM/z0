//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using L = CsPatterns.Literals;

    [ApiComplete]
    public readonly struct CsPatterns
    {
        const string Space = " ";

        public const string Public = "public";

        public readonly struct Literals
        {
            public const string Space = " ";

            public const string Public = "public";

            public const string Readonly = "readonly";

            public const string Class = "class";

            public const string Struct = "struct";

            public const string Static = "static";

            public const string String = "string";

            public const string PublicClass = Public + Space + Class;

            public const string InlineAttribute = "[MethodImpl(Inline)]";

            public const string InlineOpAttribute = "[MethodImpl(Inline), Op]";

            public const string Open = "{";

            public const string Close = "}";

            internal const string OneLineFunc = "{0} {1}({2}) => {3};";

            internal const string StaticOneLineFunc = Static + Space + OneLineFunc;

            internal const string PublicStaticOneLineFunc = Public + Space + StaticOneLineFunc;

            internal const string PublicOneLineFunc = Public + Space + OneLineFunc;
        }

        [MethodImpl(Inline)]
        public static string Empty()
            => Root.EmptyString;

        [MethodImpl(Inline)]
        public static string Class()
            => L.Class;

        [MethodImpl(Inline)]
        public static string Open()
            => L.Open;

        [MethodImpl(Inline)]
        public static string Close()
            => L.Close;

        [MethodImpl(Inline)]
        public static string Class(string name)
            => L.Class + Space + name;

        [MethodImpl(Inline)]
        public static string PublicClass()
            => L.PublicClass;

        [MethodImpl(Inline)]
        public static string Struct()
            => L.Struct;

        [MethodImpl(Inline)]
        public static string String()
            => L.String;

        [MethodImpl(Inline)]
        public static string Struct(string name)
            => L.Struct + Space + name;

        [MethodImpl(Inline)]
        public static string ReadonlyStruct()
            => L.Readonly + Space + Struct();

        [MethodImpl(Inline)]
        public static string ReadonlyStruct(string name)
            => L.Readonly + Space + Struct(name);

        [MethodImpl(Inline)]
        public static string PublicReadonlyStruct(string name)
            => L.Public + Space + ReadonlyStruct(name);

        [MethodImpl(Inline)]
        public static string InlineAttribute()
            => L.InlineAttribute;

        [MethodImpl(Inline)]
        public static string InlineOpAttribute()
            => L.InlineOpAttribute;

        [MethodImpl(Inline)]
        public static string PublicOneLineFunc(string ret, string name, string ops, string body)
            => string.Format(L.PublicOneLineFunc, ret, name, ops, body);

        [MethodImpl(Inline)]
        public static string PublicStaticOneLineFunc(string ret, string name, string ops, string body)
            => string.Format(L.PublicStaticOneLineFunc, ret, name, ops, body);

    }
}