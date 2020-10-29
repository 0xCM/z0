//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using static ApiNameAtoms;

[ApiNameProvider]
readonly struct ApiNames
{
    public const string TextApi = text + dot + core;

    public const string SymbolQuery = symbolic + dot + query;

    public const string Memory = memory + dot + core;

    public const string PartExtensions = part + dot + extensions;

    public const string LiteralKinds = literals + dot + kinds;

    public const string Arrays = memory + dot + arrays;

    public const string ArrayBuilder = memory + dot + arrays + dot + builder;
}