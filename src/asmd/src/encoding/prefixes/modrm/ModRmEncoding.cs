//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static math;

    /// <summary>
    /// Captures both the input and encoding for a modrm prefix
    /// </summary>
    public readonly struct ModRmEncoding
    {
        readonly octet Input;

        public readonly ModRm Encoded;

        public readonly triad Rm 
        {
            get => (triad)Input;
        }
        
        public readonly triad Reg 
        {
            get => (triad)(srl(Input,3));
        }

        public readonly duet Mod 
        {
            get => (duet)(srl(Input,3 + 3));
        }

        [MethodImpl(Inline)]
        public ModRmEncoding(triad rm, Triad reg, Duet mod, ModRm encoded)
        {
            Input = or((byte)rm, sll((byte)reg,3), sll((byte)mod, 3 + 3));
            // Rm = rm;
            // Reg = reg;
            // Mod = mod;
            Encoded = encoded;
        }
        
        // public string Format()
        // {
        //     const string Sep = " | ";

        //     const string Assign = " = ";

        //     var a = Rm.Format();
        //     var b = Reg.Format();
        //     var c = Mod.Format();
        //     var e = Encoded.Format();
        //     return text.concat(a, Sep, b, Sep, c, Assign, e);
        // }
    }
}