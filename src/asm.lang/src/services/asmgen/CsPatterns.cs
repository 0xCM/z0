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

            public const string Using = "using";

            public const string Open = "{";

            public const string Close = "}";

            public const string UShort = "ushort";

            public const string Short = "short";

            public const string Byte = "byte";

            public const string Namespace = "namespace";

            public const string NamespaceDeclPattern = Namespace + Space + "{0}";

            public const string UsingStatic = Using + Space + Static;

            public const string UsingNamespace = Using + Space + "{0};";

            public const string UsingType = UsingStatic + Space + "{0};";

            public const string InlineAttribute = "[MethodImpl(Inline)]";

            public const string InlineOpAttribute = "[MethodImpl(Inline), Op]";

            public const string ApiCompleteAttribute = "[ApiComplete]";

            public const string PublicClass = Public + Space + Class;

            public const string ReadOnlyStruct = Readonly + Space + Struct;

            public const string UsingCompilerServices = "using System.Runtime.CompilerServices;";

            internal const string OneLineFunc = "{0} {1}({2}) => {3};";

            internal const string StaticOneLineFunc = Static + Space + OneLineFunc;

            internal const string PublicStaticOneLineFunc = Public + Space + StaticOneLineFunc;

            internal const string PublicOneLineFunc = Public + Space + OneLineFunc;

            public const string EnumDeclPattern = "public enum {0} : {1}";
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
        public static string Using()
            => L.Using;

        public static string UsingNs(string name)
            => string.Format(L.UsingNamespace, name);

        public static string UsingType(string name)
            => string.Format(L.UsingType, name);

       public static string NamespaceDecl(string name)
            => string.Format(L.NamespaceDeclPattern, name);

        [MethodImpl(Inline)]
        public static string String()
            => L.String;

        [MethodImpl(Inline)]
        public static string UShort()
            => L.UShort;

        [MethodImpl(Inline)]
        public static string Struct(string name)
            => L.Struct + Space + name;

        [MethodImpl(Inline)]
        public static string ReadonlyStruct()
            => L.ReadOnlyStruct;

        [MethodImpl(Inline)]
        public static string ReadonlyStruct(string name)
            => L.Readonly + Space + Struct(name);

        [MethodImpl(Inline)]
        public static string PublicReadonlyStruct(string name)
            => L.Public + Space + ReadonlyStruct(name);

        [MethodImpl(Inline)]
        public static string InlineAttrib()
            => L.InlineAttribute;

        [MethodImpl(Inline)]
        public static string InlineOpAttrib()
            => L.InlineOpAttribute;

        [MethodImpl(Inline)]
        public static string ApiCompleteAttrib()
            => L.ApiCompleteAttribute;

        [MethodImpl(Inline)]
        public static string UsingCompilerServices()
            => L.UsingCompilerServices;

        public static string EnumDecl(string name, string @base)
            => string.Format(L.EnumDeclPattern, name, @base);

        public static string PublicOneLineFunc(string ret, string name, string ops, string body)
            => string.Format(L.PublicOneLineFunc, ret, name, ops, body);

        public static string PublicStaticOneLineFunc(string ret, string name, string ops, string body)
            => string.Format(L.PublicStaticOneLineFunc, ret, name, ops, body);
    }
}