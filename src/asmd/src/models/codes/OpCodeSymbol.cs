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
}