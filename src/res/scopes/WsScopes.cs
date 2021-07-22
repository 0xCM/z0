//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiComplete]
    public readonly struct WsScopes
    {
        public static Scope asm => "asm";

        public static Scope control => "control";

        public static Scope gen => "gen";

        public static Scope imports => "imports";

        public static Scope logs => "logs";

        public static Scope sources => "sources";

        public static Scope tables => "tables";

        public static Scope tools => "tools";
    }
}