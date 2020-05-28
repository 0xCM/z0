//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    using Code = AsciLetterCode;

    /// <summary>
    /// Defines asci codes corresponding to the letters A,..Z
    /// </summary>
    public enum AsciLetterCodeUp : byte
    {
        /// <summary>
        /// The 'A' symbol code 65
        /// </summary>
        A = Code.A,
        
        /// <summary>
        /// The 'B' symbol code 66
        /// </summary>
        B = Code.B,
        
        /// <summary>
        /// The 'C' symbol code 67
        /// </summary>
        C = Code.C,
        
        /// <summary>
        /// The 'D' symbol code 68
        /// </summary>
        D = Code.D,
        
        /// <summary>
        /// The 'E' symbol code 69
        /// </summary>
        E = Code.E,
        
        /// <summary>
        /// The 'F' symbol code 70
        /// </summary>
        F = Code.F,
        
        /// <summary>
        /// The 'G' symbol code 71
        /// </summary>
        G = Code.G,
        
        /// <summary>
        /// The 'H' symbol code 72
        /// </summary>
        H = Code.H,
        
        /// <summary>
        /// The 'I' symbol code 73
        /// </summary>
        I = Code.I,
        
        /// <summary>
        /// The 'J' symbol code 74
        /// </summary>
        J = Code.J,

        /// <summary>
        /// The 'K' symbol code 75
        /// </summary>
        K = Code.K,

        /// <summary>
        /// The 'L' symbol code 76
        /// </summary>
        L = Code.L,
        
        /// <summary>
        /// The 'M' symbol code 77
        /// </summary>
        M = Code.M,
        
        /// <summary>
        /// The 'N' symbol code 78
        /// </summary>
        N = Code.N,
        
        /// <summary>
        /// The 'O' symbol code 79
        /// </summary>
        O = Code.O,
        
        /// <summary>
        /// The 'P' symbol code 80
        /// </summary>
        P = Code.P,
        
        /// <summary>
        /// The 'Q' symbol code 81
        /// </summary>
        Q = Code.Q,
        
        /// <summary>
        /// The 'R' symbol code 82
        /// </summary>
        R = Code.R,
        
        /// <summary>
        /// The 'S' symbol code 83
        /// </summary>
        S = Code.S,
        
        /// <summary>
        /// The 'T' symbol code 84
        /// </summary>
        T = Code.T,
        
        /// <summary>
        /// The 'U' symbol code 85
        /// </summary>
        U = Code.U,
        
        /// <summary>
        /// The 'V' symbol code 86
        /// </summary>
        V = Code.V,

        /// <summary>
        /// The 'W' symbol code 87
        /// </summary>
        W = Code.W,

        /// <summary>
        /// The 'X' symbol code 88
        /// </summary>
        X = Code.X,

        /// <summary>
        /// The 'Y' symbol code 89
        /// </summary>
        Y = Code.Y,

        /// <summary>
        /// The 'Z' symbol code 90
        /// </summary>
        Z = Code.Z,

        /// <summary>
        /// The first declared code, 65
        /// </summary>
        First = A,

        /// <summary>
        /// The last declared code, 90
        /// </summary>
        Last = Z,

        /// <summary>
        /// The code declaration count, 26
        /// </summary>
        Count = Last - First + 1        
    }
}