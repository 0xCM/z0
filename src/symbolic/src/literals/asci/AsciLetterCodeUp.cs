//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    using Sym = AsciLetterSymbolUp;

    /// <summary>
    /// Defines asci codes corresponding to the letters A,..Z
    /// </summary>
    public enum AsciLetterCodeUp : byte
    {
        /// <summary>
        /// The 'A' symbol code 65
        /// </summary>
        A = (byte)Sym.A,
        
        /// <summary>
        /// The 'B' symbol code 66
        /// </summary>
        B = (byte)Sym.B,
        
        /// <summary>
        /// The 'C' symbol code 67
        /// </summary>
        C = (byte)Sym.C,
        
        /// <summary>
        /// The 'D' symbol code 68
        /// </summary>
        D = (byte)Sym.D,
        
        /// <summary>
        /// The 'E' symbol code 69
        /// </summary>
        E = (byte)Sym.E,
        
        /// <summary>
        /// The 'F' symbol code 70
        /// </summary>
        F = (byte)Sym.F,
        
        /// <summary>
        /// The 'G' symbol code 71
        /// </summary>
        G = (byte)Sym.G,
        
        /// <summary>
        /// The 'H' symbol code 72
        /// </summary>
        H = (byte)Sym.H,
        
        /// <summary>
        /// The 'I' symbol code 73
        /// </summary>
        I = (byte)Sym.I,
        
        /// <summary>
        /// The 'J' symbol code 74
        /// </summary>
        J = (byte)Sym.J,

        /// <summary>
        /// The 'K' symbol code 75
        /// </summary>
        K = (byte)Sym.K,

        /// <summary>
        /// The 'L' symbol code 76
        /// </summary>
        L = (byte)Sym.L,
        
        /// <summary>
        /// The 'M' symbol code 77
        /// </summary>
        M = (byte)Sym.M,
        
        /// <summary>
        /// The 'N' symbol code 78
        /// </summary>
        N = (byte)Sym.N,
        
        /// <summary>
        /// The 'O' symbol code 79
        /// </summary>
        O = (byte)Sym.O,
        
        /// <summary>
        /// The 'P' symbol code 80
        /// </summary>
        P = (byte)Sym.P,
        
        /// <summary>
        /// The 'Q' symbol code 81
        /// </summary>
        Q = (byte)Sym.Q,
        
        /// <summary>
        /// The 'R' symbol code 82
        /// </summary>
        R = (byte)Sym.R,
        
        /// <summary>
        /// The 'S' symbol code 83
        /// </summary>
        S = (byte)Sym.S,
        
        /// <summary>
        /// The 'T' symbol code 84
        /// </summary>
        T = (byte)Sym.T,
        
        /// <summary>
        /// The 'U' symbol code 85
        /// </summary>
        U = (byte)Sym.U,
        
        /// <summary>
        /// The 'V' symbol code 86
        /// </summary>
        V = (byte)Sym.V,

        /// <summary>
        /// The 'W' symbol code 87
        /// </summary>
        W = (byte)Sym.W,

        /// <summary>
        /// The 'X' symbol code 88
        /// </summary>
        X = (byte)Sym.X,

        /// <summary>
        /// The 'Y' symbol code 89
        /// </summary>
        Y = (byte)Sym.Y,

        /// <summary>
        /// The 'Z' symbol code 90
        /// </summary>
        Z = (byte)Sym.Z,

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