//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using ASym = AsciChar;

    public enum AsciCharCode : byte
    {
        /// <summary>
        /// The asci code for null
        /// </summary>
        Null = 0,

         /// <summary>
        /// The tab character code 9
        /// </summary>
        Tab = (byte)ASym.Tab,

        /// <summary>
        /// The new-line character code 10
        /// </summary>
        NL = (byte)ASym.NL,

        /// <summary>
        /// The line-feed character code 13
        /// </summary>
        CR = (byte)ASym.CR,

        /// <summary>
        /// The ' ' character code 32
        /// </summary>
        Space = (byte)ASym.Space,

        /// <summary>
        /// The '!' character code 33
        /// </summary>
        Bang = (byte)ASym.Bang,

        /// <summary>
        /// The '"' character code 34
        /// </summary>
        Quote = (byte)ASym.Quote,

        /// <summary>
        /// The '#' character code 35
        /// </summary>
        Hash = (byte)ASym.Hash,

        /// <summary>
        /// The '$' character code 36
        /// </summary>
        Dollar = (byte)ASym.Dollar,

        /// <summary>
        /// The '%' character code 37
        /// </summary>
        Percent = (byte)ASym.Percent,

        /// <summary>
        /// The '&' character code 38
        /// </summary>
        Amp = (byte)ASym.Amp,

        /// <summary>
        /// The ''' character code 39
        /// </summary>
        SQuote = (byte)ASym.SQuote,

        /// <summary>
        /// The '(' character code 40
        /// </summary>
        LParen = (byte)ASym.LParen,        

        /// <summary>
        /// The ')' character code 41
        /// </summary>
        RParen = (byte)ASym.RParen,        

        /// <summary>
        /// The '}' character code 41
        /// </summary>
        RBrace = (byte)ASym.RParen,

        /// <summary>
        /// The '*' character code 42
        /// </summary>
        Star = (byte)ASym.MUL,

        /// <summary>
        /// The '+' character code 43
        /// </summary>
        Plus = (byte)ASym.Plus,

        /// <summary>
        /// The ,' character code 44
        /// </summary>
        Comma = (byte)ASym.Comma,

        /// <summary>
        /// The '-' character code 45
        /// </summary>
        Dash = (byte)ASym.Dash,

        /// <summary>
        /// The '.' character code 46
        /// </summary>
        Dot = (byte)ASym.Dot,

        /// <summary>
        /// The '/' character code 47
        /// </summary>
        FSlash = (byte)ASym.FSlash,

        /// <summary>
        /// Specifies the asci code for the digit '0'
        /// </summary>
        d0 = (byte)ASym.d0,

        /// <summary>
        /// Specifies the asci code for the digit '1'
        /// </summary>
        d1 = (byte)ASym.d1,
        
        /// <summary>
        /// Specifies the asci code for the digit '2'
        /// </summary>
        d2 = (byte)ASym.d2,
        
        /// <summary>
        /// Specifies the asci code for the digit '3'
        /// </summary>
        d3 = (byte)ASym.d3,

        /// <summary>
        /// Specifies the asci code for the digit '4'
        /// </summary>
        d4 = (byte)ASym.d4,

        /// <summary>
        /// Specifies the asci code for the digit '5'
        /// </summary>
        d5 = (byte)ASym.d5,

        /// <summary>
        /// Specifies the asci code for the digit '6'
        /// </summary>
        d6 = (byte)ASym.d6,

        /// <summary>
        /// Specifies the asci code for the digit '7'
        /// </summary>
        d7 = (byte)ASym.d7,
        
        /// <summary>
        /// Specifies the asci code for the digit '8'
        /// </summary>
        d8 = (byte)ASym.d8,
        
        /// <summary>
        /// Specifies the asci code for the digit '9'
        /// </summary>
        d9 = (byte)ASym.d9,        

        /// <summary>
        /// The 'a' symbol code 97
        /// </summary>
        a = (byte)ASym.a,
        
        /// <summary>
        /// The 'b' symbol code 98
        /// </summary>
        b = (byte)ASym.b,
        
        /// <summary>
        /// The 'c' symbol code 99
        /// </summary>
        c = (byte)ASym.c,
        
        /// <summary>
        /// The 'd' symbol code 100
        /// </summary>
        d = (byte)ASym.d,
        
        /// <summary>
        /// The 'e' symbol code 101
        /// </summary>
        e = (byte)ASym.e,
        
        /// <summary>
        /// The 'f' symbol code 102
        /// </summary>
        f = (byte)ASym.f,
        
        /// <summary>
        /// The 'g' symbol code 103
        /// </summary>
        g = (byte)ASym.g,
        
        /// <summary>
        /// The 'h' symbol code 104
        /// </summary>
        h = (byte)ASym.h,
        
        /// <summary>
        /// The 'i' symbol code 105
        /// </summary>
        i = (byte)ASym.i,
        
        /// <summary>
        /// The 'j' symbol code 106
        /// </summary>
        j = (byte)ASym.j,
        
        /// <summary>
        /// The 'k' symbol code 107
        /// </summary>
        k = (byte)ASym.k,
        
        /// <summary>
        /// The 'l' symbol code 108
        /// </summary>
        l = (byte)ASym.l,
        
        /// <summary>
        /// The 'm' symbol code 109
        /// </summary>
        m = (byte)ASym.m,
        
        /// <summary>
        /// The 'n' symbol code 110
        /// </summary>
        n = (byte)ASym.n,
        
        /// <summary>
        /// The 'o' symbol code 111
        /// </summary>
        o = (byte)ASym.o,
        
        /// <summary>
        /// The 'p' symbol code 112
        /// </summary>
        p = (byte)ASym.p,
        
        /// <summary>
        /// The 'q' symbol code 113
        /// </summary>
        q = (byte)ASym.q,
        
        /// <summary>
        /// The 'r' symbol code 114
        /// </summary>
        r = (byte)ASym.r,
        
        /// <summary>
        /// The 's' symbol code 115
        /// </summary>
        s = (byte)ASym.s,
        
        /// <summary>
        /// The 't' symbol code 116
        /// </summary>
        t = (byte)ASym.t,
        
        /// <summary>
        /// The 'u' symbol code 117
        /// </summary>
        u = (byte)ASym.u,
        
        /// <summary>
        /// The 'v' symbol code 118
        /// </summary>
        v = (byte)ASym.v,
        
        /// <summary>
        /// The 'w' symbol code 119
        /// </summary>
        w = (byte)ASym.w,
        
        /// <summary>
        /// The 'x' symbol code 120
        /// </summary>
        x = (byte)ASym.x,
        
        /// <summary>
        /// The 'y' symbol code 121
        /// </summary>
        y = (byte)ASym.y,
        
        /// <summary>
        /// The 'z' symbol code 122
        /// </summary>
        z = (byte)ASym.z,

        /// <summary>
        /// The 'A' symbol code 65
        /// </summary>
        A = (byte)ASym.A,
        
        /// <summary>
        /// The 'B' symbol code 66
        /// </summary>
        B = (byte)ASym.B,
        
        /// <summary>
        /// The 'C' symbol code 67
        /// </summary>
        C = (byte)ASym.C,
        
        /// <summary>
        /// The 'D' symbol code 68
        /// </summary>
        D = (byte)ASym.D,
        
        /// <summary>
        /// The 'E' symbol code 69
        /// </summary>
        E = (byte)ASym.E,
        
        /// <summary>
        /// The 'F' symbol code 70
        /// </summary>
        F = (byte)ASym.F,
        
        /// <summary>
        /// The 'G' symbol code 71
        /// </summary>
        G = (byte)ASym.G,
        
        /// <summary>
        /// The 'H' symbol code 72
        /// </summary>
        H = (byte)ASym.H,
        
        /// <summary>
        /// The 'I' symbol code 73
        /// </summary>
        I = (byte)ASym.I,
        
        /// <summary>
        /// The 'J' symbol code 74
        /// </summary>
        J = (byte)ASym.J,

        /// <summary>
        /// The 'K' symbol code 75
        /// </summary>
        K = (byte)ASym.K,

        /// <summary>
        /// The 'L' symbol code 76
        /// </summary>
        L = (byte)ASym.L,
        
        /// <summary>
        /// The 'M' symbol code 77
        /// </summary>
        M = (byte)ASym.M,
        
        /// <summary>
        /// The 'N' symbol code 78
        /// </summary>
        N = (byte)ASym.N,
        
        /// <summary>
        /// The 'O' symbol code 79
        /// </summary>
        O = (byte)ASym.O,
        
        /// <summary>
        /// The 'P' symbol code 80
        /// </summary>
        P = (byte)ASym.P,
        
        /// <summary>
        /// The 'Q' symbol code 81
        /// </summary>
        Q = (byte)ASym.Q,
        
        /// <summary>
        /// The 'R' symbol code 82
        /// </summary>
        R = (byte)ASym.R,
        
        /// <summary>
        /// The 'S' symbol code 83
        /// </summary>
        S = (byte)ASym.S,
        
        /// <summary>
        /// The 'T' symbol code 84
        /// </summary>
        T = (byte)ASym.T,
        
        /// <summary>
        /// The 'U' symbol code 85
        /// </summary>
        U = (byte)ASym.U,
        
        /// <summary>
        /// The 'V' symbol code 86
        /// </summary>
        V = (byte)ASym.V,

        /// <summary>
        /// The 'W' symbol code 87
        /// </summary>
        W = (byte)ASym.W,

        /// <summary>
        /// The 'X' symbol code 88
        /// </summary>
        X = (byte)ASym.X,

        /// <summary>
        /// The 'Y' symbol code 89
        /// </summary>
        Y = (byte)ASym.Y,

        /// <summary>
        /// The 'Z' symbol code 90
        /// </summary>
        Z = (byte)ASym.Z,

        /// <summary>
        /// The ':' character code 58
        /// </summary>
        Colon = (byte)ASym.Colon,

        /// <summary>
        /// The ,' character code 59
        /// </summary>
        Semicolon = (byte)ASym.Semicolon,

        /// <summary>
        /// The '@' character code 64
        /// </summary>
        At = (byte)ASym.At,

        /// <summary>
        /// The backslash character code 92
        /// </summary>
        BSlash = (byte)ASym.BSlash,

        /// <summary>
        /// The '^' character code 94
        /// </summary>
        Caret = (byte)ASym.Caret,

        /// <summary>
        /// The '=' character code 61
        /// </summary>
        Eq = (byte)ASym.Eq,

        /// <summary>
        /// The '>' character code 62
        /// </summary>
        Gt = (byte)ASym.Gt,

        /// <summary>
        /// The '{' character code 128
        /// </summary>
        LBrace = (byte)ASym.LBrace,

        /// <summary>
        /// The '[' character code 91
        /// </summary>
        LBracket = (byte)ASym.LBracket,

        /// <summary>
        /// The '<' character code 60
        /// </summary>
        Lt = (byte)ASym.Lt,

        /// <summary>
        /// The '|' character code 124
        /// </summary>
        Pipe = (byte)ASym.Pipe,

        /// <summary>
        /// The '?' character code 63
        /// </summary>
        Question = (byte)ASym.Question,
      
        /// <summary>
        /// The ']' character code 93
        /// </summary>
        RBracket = (byte)ASym.RBracket,

        /// <summary>
        /// The '~' character code 126
        /// </summary>
        SYM = (byte)ASym.SYM, 

        /// <summary>
        /// The '~' character code 95
        /// </summary>
        Underscore = (byte)ASym.US, 
    }
}