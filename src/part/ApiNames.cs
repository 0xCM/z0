//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ApiNameAtoms;

    using A = ApiNameAtoms;

    [ApiNameProvider]
    readonly struct ApiNames
    {
        public const string TextApi = A.text + dot + core;

        public const string SymbolQuery = symbolic + dot + query;

        public const string Memory = A.memory + dot + core;

        public const string PartExtensions = part + dot + extensions;

        public const string LiteralKinds = literals + dot + kinds;

        public const string Arrays = A.memory + dot + arrays;

        public const string ArrayBuilder = A.memory + dot + arrays + dot + builder;
    }
}