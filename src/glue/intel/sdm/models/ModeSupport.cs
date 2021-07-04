//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct IntelSdm
    {
        public readonly struct ModeSupport
        {
            public Mode64Support Mode64 {get;}

            public Mode32Support Mode32 {get;}

            [MethodImpl(Inline)]
            public ModeSupport(Mode64Support m64, Mode32Support m32)
            {
                Mode64 = m64;
                Mode32 = m32;
            }

            public string Format()
            {
                var buffer = text.buffer();
                render(this,buffer);
                return buffer.Emit();
            }

            public override string ToString()
                => Format();
        }

        [SymSource]
        public enum Mode64Support : byte
        {
            None,

            [Symbol("V", "Supported")]
            V,

            [Symbol("I", "Not Supported")]
            I,

            [Symbol("N.E.", "Indicates an instruction syntax is not encodable in 64-bit mode")]
            NE,

            [Symbol("N.P.", "Indicates the REX prefix does not affect the legacy instruction in 64-bit mode")]
            NP,

            [Symbol("N.I.", "Indicates the opcode is treated as a new instruction in 64-bit mode")]
            NI,

            [Symbol("N.S.", "Indicates an instruction syntax that requires an address override prefix in 64-bit mode and is not suported")]
            NS
        }

        [SymSource]
        public enum Mode32Support : byte
        {
            None,

            [Symbol("V", "Supported")]
            V,

            [Symbol("I", "Not Supported")]
            I,

            [Symbol("N.E.", "Not Encodable; the opbode sequence is not applicable as n individual instruction in compatiblity or IA-32 mode")]
            NE,
        }
    }
}