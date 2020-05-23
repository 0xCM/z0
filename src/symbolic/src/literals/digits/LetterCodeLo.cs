//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    using Sym = LetterSymbolLo;

    /// <summary>
    /// Defines asci codes corresponding to the letters a,...z
    /// </summary>
    public enum LetterCodeLo : byte
    {
        /// <summary>
        /// The code with no code
        /// </summary>
        None = 0,

        /// <summary>
        /// The 'a' code
        /// </summary>
        a = (byte)Sym.a,
        
        /// <summary>
        /// The 'b' code
        /// </summary>
        b = (byte)Sym.b,
        
        /// <summary>
        /// The 'c' code
        /// </summary>
        c = (byte)Sym.c,
        
        /// <summary>
        /// The 'd' code
        /// </summary>
        d = (byte)Sym.d,
        
        /// <summary>
        /// The 'e' code
        /// </summary>
        e = (byte)Sym.e,
        
        /// <summary>
        /// The 'f' code
        /// </summary>
        f = (byte)Sym.f,
        
        /// <summary>
        /// The 'g' code
        /// </summary>
        g = (byte)Sym.g,
        
        /// <summary>
        /// The 'h' code
        /// </summary>
        h = (byte)Sym.h,
        
        /// <summary>
        /// The 'i' code
        /// </summary>
        i = (byte)Sym.i,
        
        /// <summary>
        /// The 'j' code
        /// </summary>
        j = (byte)Sym.j,
        
        /// <summary>
        /// The 'k' code
        /// </summary>
        k = (byte)Sym.k,
        
        /// <summary>
        /// The 'l' code
        /// </summary>
        l = (byte)Sym.l,
        
        /// <summary>
        /// The 'm' code
        /// </summary>
        m = (byte)Sym.m,
        
        /// <summary>
        /// The 'n' code
        /// </summary>
        n = (byte)Sym.n,
        
        /// <summary>
        /// The 'o' code
        /// </summary>
        o = (byte)Sym.o,
        
        /// <summary>
        /// The 'p' code
        /// </summary>
        p = (byte)Sym.p,
        
        /// <summary>
        /// The 'q' code
        /// </summary>
        q = (byte)Sym.q,
        
        /// <summary>
        /// The 'r' code
        /// </summary>
        r = (byte)Sym.r,
        
        /// <summary>
        /// The 's' code
        /// </summary>
        s = (byte)Sym.s,
        
        /// <summary>
        /// The 't' code
        /// </summary>
        t = (byte)Sym.t,
        
        /// <summary>
        /// The 'u' code
        /// </summary>
        u = (byte)Sym.u,
        
        /// <summary>
        /// The 'v' code
        /// </summary>
        v = (byte)Sym.v,
        
        /// <summary>
        /// The 'w' code
        /// </summary>
        w = (byte)Sym.w,
        
        /// <summary>
        /// The 'x' code
        /// </summary>
        x = (byte)Sym.x,
        
        /// <summary>
        /// The 'y' code
        /// </summary>
        y = (byte)Sym.y,
        
        /// <summary>
        /// The 'z' code
        /// </summary>
        z = (byte)Sym.z,
    
        /// <summary>
        /// The first declared code
        /// </summary>
        First = a,

        /// <summary>
        /// The last declared code
        /// </summary>
        Last = z,

        /// <summary>
        /// The code declaration count
        /// </summary>
        Count = Last - First + 1
    }
}