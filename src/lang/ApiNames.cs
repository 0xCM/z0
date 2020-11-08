//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiNameParts;

    readonly struct ApiNames
    {
       public const string LanguageModels = lang + dot + models;

        public const string CsLang = lang + dot + cs;

        public const string CsRender = lang + dot + cs + dot + render;

        public const string CsBuilder = lang + dot + cs + dot + builder;

        public const string CsPrototypes = lang + dot + cs + dot + "prototypes";

        public const string Cil = cil + dot + api;

        public const string CilTableBuilder = cil + dot + tables + dot + builder;

        public const string CilTables = cil + dot + tables;

        public const string FilePathParser = parsers + dot + files + dot + paths;

        public const string SyntaxModels = syntax + dot + models;

        public const string SyntaxParsers = syntax + dot + parsers;

        public const string SyntaxParserCases = syntax + dot + parsers + dot + cases;

        public const string BufferSegments = buffers + dot + segments;

        public const string StateBuffers = buffers + dot + states;

        public const string FixedBuffers = buffers + dot + @fixed;
    }
}