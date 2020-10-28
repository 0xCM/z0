//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ApiNameAtoms;
    using static CmdCodeAtoms;


    readonly struct ApiNames
    {
        public const string Signatures = signatures;

        public const string Cmd = cmd + dot + core;

        public const string CmdParse = cmd + dot + "parse";

        public const string FilePathParser = parsers + dot + files + dot + paths;

        public const string EnumCatalogs = enums + dot + catalogs;

        public const string SyntaxModels = "syntax" + dot + models;

        public const string UnmanagedParsers = parsers + dot + unmanaged;

        public const string UnmanagedParserCases = parsers + dot + unmanaged + dot + cases;

        public const string BufferSegments = buffers + dot + segments;

        public const string StateBuffers = buffers + dot + states;

        public const string CmdPatterns = cmd + dot + "patterns";

        const string syntax = nameof(syntax);
    }
}