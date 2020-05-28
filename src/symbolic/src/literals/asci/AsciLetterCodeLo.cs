//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    using Code = AsciLetterCode;

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
        a = Code.a,
        
        /// <summary>
        /// The 'b' symbol code 98
        /// </summary>
        b = Code.b,
        
        /// <summary>
        /// The 'c' symbol code 99
        /// </summary>
        c = Code.c,
        
        /// <summary>
        /// The 'd' symbol code 100
        /// </summary>
        d = Code.d,
        
        /// <summary>
        /// The 'e' symbol code 101
        /// </summary>
        e = Code.e,
        
        /// <summary>
        /// The 'f' symbol code 102
        /// </summary>
        f = Code.f,
        
        /// <summary>
        /// The 'g' symbol code 103
        /// </summary>
        g = Code.g,
        
        /// <summary>
        /// The 'h' symbol code 104
        /// </summary>
        h = Code.h,
        
        /// <summary>
        /// The 'i' symbol code 105
        /// </summary>
        i = Code.i,
        
        /// <summary>
        /// The 'j' symbol code 106
        /// </summary>
        j = Code.j,
        
        /// <summary>
        /// The 'k' symbol code 107
        /// </summary>
        k = Code.k,
        
        /// <summary>
        /// The 'l' symbol code 108
        /// </summary>
        l = Code.l,
        
        /// <summary>
        /// The 'm' symbol code 109
        /// </summary>
        m = Code.m,
        
        /// <summary>
        /// The 'n' symbol code 110
        /// </summary>
        n = Code.n,
        
        /// <summary>
        /// The 'o' symbol code 111
        /// </summary>
        o = Code.o,
        
        /// <summary>
        /// The 'p' symbol code 112
        /// </summary>
        p = Code.p,
        
        /// <summary>
        /// The 'q' symbol code 113
        /// </summary>
        q = Code.q,
        
        /// <summary>
        /// The 'r' symbol code 114
        /// </summary>
        r = Code.r,
        
        /// <summary>
        /// The 's' symbol code 115
        /// </summary>
        s = Code.s,
        
        /// <summary>
        /// The 't' symbol code 116
        /// </summary>
        t = Code.t,
        
        /// <summary>
        /// The 'u' symbol code 117
        /// </summary>
        u = Code.u,
        
        /// <summary>
        /// The 'v' symbol code 118
        /// </summary>
        v = Code.v,
        
        /// <summary>
        /// The 'w' symbol code 119
        /// </summary>
        w = Code.w,
        
        /// <summary>
        /// The 'x' symbol code 120
        /// </summary>
        x = Code.x,
        
        /// <summary>
        /// The 'y' symbol code 121
        /// </summary>
        y = Code.y,
        
        /// <summary>
        /// The 'z' symbol code 122
        /// </summary>
        z = Code.z,
    
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