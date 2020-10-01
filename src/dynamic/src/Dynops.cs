//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiNameAtoms;

    public readonly struct Dynops : IDynamic
    {
        public static IDynamic Services => default(Dynops);
    }

    readonly struct ApiNames
    {
        public const string DynamicOperators = dynamic + dot + operators;
    }
}