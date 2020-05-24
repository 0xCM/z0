//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    using Sym = AsciLetterSymbolLo;

    /// <summary>
    /// Defines asci codes corresponding to the letters a,...z
    /// </summary>
    public enum AsciLetterCodeLo : byte
    {
        /// <summary>
        /// The code with no code
        /// </summary>
        None = 0,

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
    
        /// <summary>
        /// The first declared code, 97
        /// </summary>
        First = a,

        /// <summary>
        /// The last declared code, 122
        /// </summary>
        Last = z,

        /// <summary>
        /// The code declaration count, 26
        /// </summary>
        Count = Last - First + 1
    }
}