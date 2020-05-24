//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    using SN = SymNotKind;

    public enum SyntaxSymbol : ushort
    {
        ᛜ = SN.Diamond,

        ﾉ = SN.FSlashSmall,

        ᕀ = SN.Plus,

        ተ = SN.Dagger,

        ㆍ = SN.Dot,

        ᐤ = SN.Circle,        

        ǀ = SN.LeftPipe,

        ℎ = SN.HSmall,

        /// <summary>
        /// Gt
        /// </summary>
        ᐳ = SN.Gt,


        /// <summary>
        /// Lt
        /// </summary>
        ᐸ = SN.Lt,

        ｰ = SN.HalfDash,


        ᛁ = SN.Pipe,


    }

    class OpCodeIdentifiers
    {
        public const string Cmpᐸ38ﾉrㆍw8ᐳ = "Cmpᐸrm8ㆍr8ᐳ";    

        public const string Cmpᐸ39ﾉrㆍw16ᐳ = "Cmpᐸrm16ㆍr16ᐳ";    

        public const string Cmpᐸ39ﾉrㆍw32ᐳ = "Cmpᐸrm16ㆍr16ᐳ";    

        public const string CmpᐸRexᕀ38ﾉrㆍw32ᐳ = "Cmpᐸrm8ㆍr8ᐳ";    

        public const string CmpᐸRexㆍWᕀ39ﾉrㆍw32ᐳ = "Cmpᐸrm64ㆍr64ᐳ";    

        public const string Cmpᐸ3Aﾉrㆍw8ᐳ = "Cmpᐸr8ㆍrm8ᐳ";

    }
}