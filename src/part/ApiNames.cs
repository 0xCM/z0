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

        public const string SymbolQuery = A.text + dot + symbols + dot + query;

        public const string Memory = A.memory + dot + core;

        public const string PartExtensions = part + dot + extensions;
    }
}