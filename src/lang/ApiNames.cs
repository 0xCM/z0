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
    }
}