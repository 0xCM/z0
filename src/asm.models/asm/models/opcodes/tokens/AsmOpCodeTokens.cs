//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tokens
{    
    public readonly struct AsmOpCodeTokens
    {
        public const AsmOpCodeToken First = AsmOpCodeToken.NE;

        public const AsmOpCodeToken Last = AsmOpCodeToken.ᕀi;
        
        public const byte Count = (byte)Last + 1;
        
        public const string NE = "N.E.";

        public const string NP = "NP";
        
        public const string NFx = "NFx";
        
        public const string REXᕀW  = "REX.W";

        public const string ﾉ0 = "/0";
        
        public const string ﾉ1 = "/1";
        
        public const string ﾉ2 = "/2";

        public const string ﾉ3 = "/3";

        public const string ﾉ4 = "/4";

        public const string ﾉ5 = "/5";

        public const string ﾉ6 = "/6";

        public const string ﾉ7 = "/7";

        public const string ﾉr = "/r";

        public const string cb = "cb";

        public const string cw = "cw";

        public const string cd = "cd";

        public const string cp = "cp";

        public const string co = "co";

        public const string ct = "ct";

        public const string ib = "ib";

        public const string iw = "iw";

        public const string id = "id";         

        public const string io = "io";

        public const string ᕀrb = "+rb";

        public const string ᕀrw = "+rw";

        public const string ᕀrd = "+rd";

        public const string ᕀro = "+ro";
 
        public const string ᕀi = "+i";
    }
}