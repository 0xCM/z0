//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static IDI;

    class OpIdentityPatterns
    {
        public const string _name_ = "name";
        
        public const string _arg1_ = "arg1";

        public const string _arg2_ = "arg2";

        public static string Pattern1 = $"{_name_}{PartSep}{ArgsOpen}{_arg1_}{ArgSep}{_arg2_}{ArgsClose}";
     
        public static string Pattern1_g = $"{_name_}{PartSep}{Generic}{ArgsOpen}{_arg1_}{ArgSep}{_arg2_}{ArgsClose}";
     
        public static string Pattern1_Legal = $"{_name_}{PartSep}{SymNot.Circle}{_arg1_}{SymNot.Dot}{_arg2_}{SymNot.Circle}";

        public static string Pattern1_g_Legal = $"{_name_}{PartSep}{Generic}{SymNot.Circle}{_arg1_}{SymNot.Dot}{_arg2_}{SymNot.Circle}";
    }
}