//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    using S = AsciMath;

    public enum AsciMathCode : byte
    {        
        Null = 0,

        /// <summary>
        /// The '!' character code 33
        /// </summary>
        NOT = (byte)S.NOT,

        /// <summary>
        /// The '%' character code 37
        /// </summary>
        MOD = (byte)S.MOD,

        /// <summary>
        /// The '*' character code 42
        /// </summary>
        MUL = (byte)S.MUL,

        /// <summary>
        /// The '+' character code 43
        /// </summary>
        ADD = (byte)S.ADD,

        /// <summary>
        /// The '-' character code 45
        /// </summary>
        SUB = (byte)S.SUB,

        /// <summary>
        /// The '/' character code 47
        /// </summary>
        DIV = (byte)S.DIV,

        /// <summary>
        /// The '<' character code 60
        /// </summary>
        LT = (byte)S.LT,

        /// <summary>
        /// The '=' character code 61
        /// </summary>
        Eq = (byte)S.EQ,

        /// <summary>
        /// The '>' character code 62
        /// </summary>
        GT = (byte)S.GT,

        /// <summary>
        /// The '^' character code 94
        /// </summary>
        EXP = (byte)S.EXP,

        /// <summary>
        /// The '~' character code 126
        /// </summary>
        SYM = (byte)S.SYM, 
    }
}