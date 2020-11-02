//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiNameParts;

    using A = ApiNameParts;

    readonly struct ApiNames
    {
        public const string Cs = A.lang + dot + cs;

        public const string Asm = A.lang + dot + A.asm;

        public const string DynamicOperators = dynamic + dot + operators;

        public const string AlgorithmDynamic = dynamic + dot + algorithms;

        public const string CilTableBuilder = cil + dot + tables + dot + builder;

        public const string CilTables = cil + dot + tables;

        // ~~ LinqX
        // ~~ -----------------------------------------------------------------------------------------

        public const string LinqXPress = linq + dot + expressions;

        public const string LinqXQuery = linq + dot + expressions + dot + query;

        public const string LinqXFunc = linq + dot + expressions + dot + functions;

        public const string LinqXFuncX = linq + dot + expressions + dot + extensions;
    }
}