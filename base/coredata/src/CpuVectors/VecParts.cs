//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.InteropServices;
    
    using static zfunc;    

    public static class VecParts128x8u
    {
        public const byte A = 0;

        public const byte B = A + 1;

        public const byte C = B + 1;

        public const byte D = C + 1;

        public const byte E = D + 1;

        public const byte F = E + 1;

        public const byte G = F + 1;

        public const byte H = G + 1;

        public const byte I = H + 1;

        public const byte J = I + 1;

        public const byte K = J + 1;

        public const byte L = K + 1;

        public const byte M = L + 1;

        public const byte N = M + 1;

        public const byte O = N + 1;        

        public const byte P = O + 1;        
    }

    public static class VecParts256x8u
    {
        public const byte LA = 0;

        public const byte LB = LA + 1;

        public const byte LC = LB + 1;

        public const byte LD = LC + 1;

        public const byte LE = LD + 1;

        public const byte LF = LE + 1;

        public const byte LG = LF + 1;

        public const byte LH = LG + 1;

        public const byte LI = LH + 1;

        public const byte LJ = LI + 1;

        public const byte LK = LJ + 1;

        public const byte LL = LK + 1;

        public const byte LM = LL + 1;

        public const byte LN = LM + 1;

        public const byte LO = LN + 1;        

        public const byte LP = LO + 1;        

        public const byte BA = LP + 1;

        public const byte BB = LB + BA;

        public const byte BC = LC + BA;

        public const byte BD = LD + BA;

        public const byte BE = LE + BA;

        public const byte BF = LF + BA;

        public const byte BG = LG + BA;

        public const byte BH = LH + BA;

        public const byte BI = LI + BA;

        public const byte BJ = LJ + BA;

        public const byte BK = LK + BA;

        public const byte BL = LL + BA;

        public const byte BM = LM + BA;

        public const byte BN = LN + BA;

        public const byte BO = LO + BA;

        public const byte BP = LP + BA;

    }

    public static class VecParts128x16u
    {
        public const ushort A = 0;

        public const ushort B = A + 1;

        public const ushort C = B + 1;

        public const ushort D = C + 1;

        public const ushort E = D + 1;

        public const ushort F = E + 1;

        public const ushort G = F + 1;

        public const ushort H = G + 1;

    }

    public static class VecParts256x16u
    {
        public const ushort LA = 0;

        public const ushort LB = LA + 1;

        public const ushort LC = LB + 1;

        public const ushort LD = LC + 1;

        public const ushort LE = LD + 1;

        public const ushort LF = LE + 1;

        public const ushort LG = LF + 1;

        public const ushort LH = LG + 1;

        public const ushort BA = LH + 1;

        public const ushort BB = LB + BA;

        public const ushort BC = LC + BA;

        public const ushort BD = LD + BA;

        public const ushort BE = LE + BA;

        public const ushort BF = LF + BA;

        public const ushort BG = LG + BA;

        public const ushort BH = LH + BA;

    }

    public static class VecParts128x32u
    {
        public const uint A = 0;

        public const uint B = A + 1;

        public const uint C = B + 1;

        public const uint D = C + 1;

    }

    public static class VecParts256x32u
    {
        public const ushort LA = 0;

        public const ushort LB = LA + 1;

        public const ushort LC = LB + 1;

        public const ushort LD = LC + 1;

        public const ushort BA = LD + 1;

        public const ushort BB = LB + BA;

        public const ushort BC = LC + BA;

        public const ushort BD = LD + BA;


    }

    public static class VecParts128x64u
    {
        public const uint A = 0;

        public const uint B = A + 1;

    }

    public static class VecParts256x64u
    {
        public const ushort LA = 0;

        public const ushort LB = LA + 1;


        public const ushort BA = LB + 1;

        public const ushort BB = LB + BA;



    }


}