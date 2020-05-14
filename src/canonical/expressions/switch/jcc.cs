//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class AsmExpr
    {
        const byte JB = 0x72;

        const byte JAE = 0x73;

        const byte JE = 0x74;

        const byte JNE = 0x75;        

        const byte JBE = 0x76;        

        const byte JA = 0x77;

        const byte JG = 0x7F;

        const byte JGE = 0x7D;

        const byte JLE = 0x7e;

        const byte JL = 0x7c;

        const byte UNMATCHED = 0xFF;

        [Op]
        public uint je(byte x)
            => x == 7 ? je_target() : UNMATCHED;

        [Op]
        public uint jne(byte x)
            => x != 7 ? jne_target() : UNMATCHED;

        [Op]
        public uint ja(byte x)
            => x > 7 ? ja_target() : UNMATCHED;

        [Op]
        public uint jae(byte x)
            => x >= 7 ? jae_target() : UNMATCHED;

        [Op]
        public uint jb(byte x)
            => x < 7 ? jb_target() : UNMATCHED;

        [Op]
        public uint jbe(byte x)
            => x <= 7 ? jbe_target() : UNMATCHED;

        [Op]
        public uint je(int x)
            => x == 7 ? je_target() : UNMATCHED;

        [Op]
        public uint jne(int x)
            => x != 7 ? jne_target() : UNMATCHED;

        [Op]
        public uint ja(int x)
            => x > 7 ? ja_target() : UNMATCHED;

        [Op]
        public uint jge(int x)
            => x >= 7 ? jge_target() : UNMATCHED;

        [Op]
        public uint jl(int x)
            => x < 7 ? jl_target() : UNMATCHED;

        [Op]
        public uint jle(int x)
            => x <= 7 ? jle_target() : UNMATCHED;

        [Op, MethodImpl(NotInline)]
        public uint jl_target()
            => JL;

        [Op, MethodImpl(NotInline)]
        public uint jle_target()
            => JLE;

        [Op, MethodImpl(NotInline)]
        public uint jg_target()
            => JG;

        [Op, MethodImpl(NotInline)]
        public uint jge_target()
            => JGE;

        [Op, MethodImpl(NotInline)]
        public uint je_target()
            => JE;

        [Op, MethodImpl(NotInline)]
        public uint jne_target()
            => JNE;

        [Op, MethodImpl(NotInline)]
        public uint jb_target()
            => JB;

        [Op, MethodImpl(NotInline)]
        public uint ja_target()
            => JA;

        [Op, MethodImpl(NotInline)]
        public uint jae_target()
            => JAE;

        [Op, MethodImpl(NotInline)]
        public uint jbe_target()
            => JBE;
    }
}