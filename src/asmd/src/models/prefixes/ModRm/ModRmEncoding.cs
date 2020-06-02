//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct ModRmEncoding : ITextual
    {
        [MethodImpl(Inline)]
        public ModRmEncoding(triad Rm, Triad Reg, Duet Mod, ModRm Encoded)
        {
            this.Rm = Rm;
            this.Reg = Reg;
            this.Mod = Mod;
            this.Encoded = Encoded;
        }
        
        public readonly triad Rm;
        
        public readonly triad Reg;

        public readonly duet Mod;

        public readonly ModRm Encoded;

        const string Sep = " | ";

        const string Assign = " = ";

        public string Format()
        {
            var a = Rm.Format();
            var b = Reg.Format();
            var c = Mod.Format();
            var e = Encoded.Format();
            return text.concat(a, Sep, b, Sep, c, Assign, e);
        }
    }
}