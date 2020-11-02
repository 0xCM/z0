//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ApiNameParts;

    readonly struct ApiNames
    {
        public const string Signatures = signatures;

        public const string Cmd = cmd + dot + core;

        public const string CmdPatterns = cmd + dot + patterns;

        public const string CmdRunners = cmd + dot + "runners";

        public const string FilePathParser = parsers + dot + files + dot + paths;

        public const string EnumCatalogs = enums + dot + catalogs;

        public const string SyntaxModels = syntax + dot + models;

        public const string UnmanagedParsers = parsers + dot + unmanaged;

        public const string UnmanagedParserCases = parsers + dot + unmanaged + dot + cases;

        public const string BufferSegments = buffers + dot + segments;

        public const string StateBuffers = buffers + dot + states;

        public const string FixedBuffers = buffers + dot + @fixed;

        public const string JsonData = data + dot + json;

        public const string ApiData = api + dot + data;

        public const string ApiRuntime = api + dot + runtime;
    }
}