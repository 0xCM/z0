//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    using Sym = AsciLetter;

    public enum AsciLetterCode : byte
    {
        /// <summary>
        /// The code with no code
        /// </summary>
        None = 0,

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
        /// The 'a' symbol code 97
        /// </summary>
        a = (byte)Sym.a,
        
        /// <summary>
        /// The 'b' symbol code 98
        /// </summary>
        b = (byte)Sym.b,
        
        /// <summary>
        /// The 'c' symbol code 99
        /// </summary>
        c = (byte)Sym.c,
        
        /// <summary>
        /// The 'd' symbol code 100
        /// </summary>
        d = (byte)Sym.d,
        
        /// <summary>
        /// The 'e' symbol code 101
        /// </summary>
        e = (byte)Sym.e,
        
        /// <summary>
        /// The 'f' symbol code 102
        /// </summary>
        f = (byte)Sym.f,
        
        /// <summary>
        /// The 'g' symbol code 103
        /// </summary>
        g = (byte)Sym.g,
        
        /// <summary>
        /// The 'h' symbol code 104
        /// </summary>
        h = (byte)Sym.h,
        
        /// <summary>
        /// The 'i' symbol code 105
        /// </summary>
        i = (byte)Sym.i,
        
        /// <summary>
        /// The 'j' symbol code 106
        /// </summary>
        j = (byte)Sym.j,
        
        /// <summary>
        /// The 'k' symbol code 107
        /// </summary>
        k = (byte)Sym.k,
        
        /// <summary>
        /// The 'l' symbol code 108
        /// </summary>
        l = (byte)Sym.l,
        
        /// <summary>
        /// The 'm' symbol code 109
        /// </summary>
        m = (byte)Sym.m,
        
        /// <summary>
        /// The 'n' symbol code 110
        /// </summary>
        n = (byte)Sym.n,
        
        /// <summary>
        /// The 'o' symbol code 111
        /// </summary>
        o = (byte)Sym.o,
        
        /// <summary>
        /// The 'p' symbol code 112
        /// </summary>
        p = (byte)Sym.p,
        
        /// <summary>
        /// The 'q' symbol code 113
        /// </summary>
        q = (byte)Sym.q,
        
        /// <summary>
        /// The 'r' symbol code 114
        /// </summary>
        r = (byte)Sym.r,
        
        /// <summary>
        /// The 's' symbol code 115
        /// </summary>
        s = (byte)Sym.s,
        
        /// <summary>
        /// The 't' symbol code 116
        /// </summary>
        t = (byte)Sym.t,
        
        /// <summary>
        /// The 'u' symbol code 117
        /// </summary>
        u = (byte)Sym.u,
        
        /// <summary>
        /// The 'v' symbol code 118
        /// </summary>
        v = (byte)Sym.v,
        
        /// <summary>
        /// The 'w' symbol code 119
        /// </summary>
        w = (byte)Sym.w,
        
        /// <summary>
        /// The 'x' symbol code 120
        /// </summary>
        x = (byte)Sym.x,
        
        /// <summary>
        /// The 'y' symbol code 121
        /// </summary>
        y = (byte)Sym.y,
        
        /// <summary>
        /// The 'z' symbol code 122
        /// </summary>
        z = (byte)Sym.z,
    }
}