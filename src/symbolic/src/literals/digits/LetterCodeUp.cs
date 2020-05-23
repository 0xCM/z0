//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    using Sym = LetterSymbolUp;

    /// <summary>
    /// Defines asci codes corresponding to the letters A,..Z
    /// </summary>
    public enum LetterCodeUp : byte
    {
        /// <summary>
        /// The 'A' code
        /// </summary>
        A = (byte)Sym.A,
        
        /// <summary>
        /// The 'B' code
        /// </summary>
        B = (byte)Sym.B,
        
        /// <summary>
        /// The 'C' code
        /// </summary>
        C = (byte)Sym.C,
        
        /// <summary>
        /// The 'D' code
        /// </summary>
        D = (byte)Sym.D,
        
        /// <summary>
        /// The 'E' code
        /// </summary>
        E = (byte)Sym.E,
        
        /// <summary>
        /// The 'F' code
        /// </summary>
        F = (byte)Sym.F,
        
        /// <summary>
        /// The 'G' code
        /// </summary>
        G = (byte)Sym.G,
        
        /// <summary>
        /// The 'H' code
        /// </summary>
        H = (byte)Sym.H,
        
        /// <summary>
        /// The 'I' code
        /// </summary>
        I = (byte)Sym.I,
        
        /// <summary>
        /// The 'J' code
        /// </summary>
        J = (byte)Sym.J,

        /// <summary>
        /// The 'K' code
        /// </summary>
        K = (byte)Sym.K,

        /// <summary>
        /// The 'L' code
        /// </summary>
        L = (byte)Sym.L,
        
        /// <summary>
        /// The 'M' code
        /// </summary>
        M = (byte)Sym.M,
        
        /// <summary>
        /// The 'N' code
        /// </summary>
        N = (byte)Sym.N,
        
        /// <summary>
        /// The 'O' code
        /// </summary>
        O = (byte)Sym.O,
        
        /// <summary>
        /// The 'P' code
        /// </summary>
        P = (byte)Sym.P,
        
        /// <summary>
        /// The 'Q' code
        /// </summary>
        Q = (byte)Sym.Q,
        
        /// <summary>
        /// The 'R' code
        /// </summary>
        R = (byte)Sym.R,
        
        /// <summary>
        /// The 'S' code
        /// </summary>
        S = (byte)Sym.S,
        
        /// <summary>
        /// The 'T' code
        /// </summary>
        T = (byte)Sym.T,
        
        /// <summary>
        /// The 'U' code
        /// </summary>
        U = (byte)Sym.U,
        
        /// <summary>
        /// The 'V' code
        /// </summary>
        V = (byte)Sym.V,

        /// <summary>
        /// The 'W' code
        /// </summary>
        W = (byte)Sym.W,

        /// <summary>
        /// The 'X' code
        /// </summary>
        X = (byte)Sym.X,

        /// <summary>
        /// The 'Y' code
        /// </summary>
        Y = (byte)Sym.Y,

        /// <summary>
        /// The 'Z' code
        /// </summary>
        Z = (byte)Sym.Z,

        /// <summary>
        /// The first declared code
        /// </summary>
        First = A,

        /// <summary>
        /// The last declared code
        /// </summary>
        Last = Z,

        /// <summary>
        /// The code declaration count
        /// </summary>
        Count = Last - First + 1        
    }
}