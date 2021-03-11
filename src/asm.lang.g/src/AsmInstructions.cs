//-----------------------------------------------------------------------------
// Generated   :  2021-03-11.15.45.32.4893
// Copyright   :  (c) Chris Moore, 2021
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using static Part;

    public readonly struct AsmInstructions
    {
        public struct Aaa : IAsmInstruction<Aaa>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Aaa(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AAA;

            public static implicit operator AsmMnemonicCode(Aaa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aaa src) => AsmMnemonics.AAA;
        }

        public static Aaa aaa() => default;

        [MethodImpl(Inline)]
        public static Aaa aaa(AsmHexCode encoded) => new Aaa(encoded);

        public struct Aad : IAsmInstruction<Aad>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Aad(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AAD;

            public static implicit operator AsmMnemonicCode(Aad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aad src) => AsmMnemonics.AAD;
        }

        public static Aad aad() => default;

        [MethodImpl(Inline)]
        public static Aad aad(AsmHexCode encoded) => new Aad(encoded);

        public struct Aam : IAsmInstruction<Aam>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Aam(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AAM;

            public static implicit operator AsmMnemonicCode(Aam src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aam src) => AsmMnemonics.AAM;
        }

        public static Aam aam() => default;

        [MethodImpl(Inline)]
        public static Aam aam(AsmHexCode encoded) => new Aam(encoded);

        public struct Aas : IAsmInstruction<Aas>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Aas(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AAS;

            public static implicit operator AsmMnemonicCode(Aas src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aas src) => AsmMnemonics.AAS;
        }

        public static Aas aas() => default;

        [MethodImpl(Inline)]
        public static Aas aas(AsmHexCode encoded) => new Aas(encoded);

        public struct Adc : IAsmInstruction<Adc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Adc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADC;

            public static implicit operator AsmMnemonicCode(Adc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Adc src) => AsmMnemonics.ADC;
        }

        public static Adc adc() => default;

        [MethodImpl(Inline)]
        public static Adc adc(AsmHexCode encoded) => new Adc(encoded);

        public struct Add : IAsmInstruction<Add>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Add(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADD;

            public static implicit operator AsmMnemonicCode(Add src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Add src) => AsmMnemonics.ADD;
        }

        public static Add add() => default;

        [MethodImpl(Inline)]
        public static Add add(AsmHexCode encoded) => new Add(encoded);

        public struct Addpd : IAsmInstruction<Addpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Addpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDPD;

            public static implicit operator AsmMnemonicCode(Addpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addpd src) => AsmMnemonics.ADDPD;
        }

        public static Addpd addpd() => default;

        [MethodImpl(Inline)]
        public static Addpd addpd(AsmHexCode encoded) => new Addpd(encoded);

        public struct Vaddpd : IAsmInstruction<Vaddpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vaddpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDPD;

            public static implicit operator AsmMnemonicCode(Vaddpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddpd src) => AsmMnemonics.VADDPD;
        }

        public static Vaddpd vaddpd() => default;

        [MethodImpl(Inline)]
        public static Vaddpd vaddpd(AsmHexCode encoded) => new Vaddpd(encoded);

        public struct Addps : IAsmInstruction<Addps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Addps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDPS;

            public static implicit operator AsmMnemonicCode(Addps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addps src) => AsmMnemonics.ADDPS;
        }

        public static Addps addps() => default;

        [MethodImpl(Inline)]
        public static Addps addps(AsmHexCode encoded) => new Addps(encoded);

        public struct Vaddps : IAsmInstruction<Vaddps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vaddps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDPS;

            public static implicit operator AsmMnemonicCode(Vaddps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddps src) => AsmMnemonics.VADDPS;
        }

        public static Vaddps vaddps() => default;

        [MethodImpl(Inline)]
        public static Vaddps vaddps(AsmHexCode encoded) => new Vaddps(encoded);

        public struct Addsd : IAsmInstruction<Addsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Addsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSD;

            public static implicit operator AsmMnemonicCode(Addsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addsd src) => AsmMnemonics.ADDSD;
        }

        public static Addsd addsd() => default;

        [MethodImpl(Inline)]
        public static Addsd addsd(AsmHexCode encoded) => new Addsd(encoded);

        public struct Vaddsd : IAsmInstruction<Vaddsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vaddsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSD;

            public static implicit operator AsmMnemonicCode(Vaddsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddsd src) => AsmMnemonics.VADDSD;
        }

        public static Vaddsd vaddsd() => default;

        [MethodImpl(Inline)]
        public static Vaddsd vaddsd(AsmHexCode encoded) => new Vaddsd(encoded);

        public struct Addss : IAsmInstruction<Addss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Addss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSS;

            public static implicit operator AsmMnemonicCode(Addss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addss src) => AsmMnemonics.ADDSS;
        }

        public static Addss addss() => default;

        [MethodImpl(Inline)]
        public static Addss addss(AsmHexCode encoded) => new Addss(encoded);

        public struct Vaddss : IAsmInstruction<Vaddss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vaddss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSS;

            public static implicit operator AsmMnemonicCode(Vaddss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddss src) => AsmMnemonics.VADDSS;
        }

        public static Vaddss vaddss() => default;

        [MethodImpl(Inline)]
        public static Vaddss vaddss(AsmHexCode encoded) => new Vaddss(encoded);

        public struct Addsubpd : IAsmInstruction<Addsubpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Addsubpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSUBPD;

            public static implicit operator AsmMnemonicCode(Addsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addsubpd src) => AsmMnemonics.ADDSUBPD;
        }

        public static Addsubpd addsubpd() => default;

        [MethodImpl(Inline)]
        public static Addsubpd addsubpd(AsmHexCode encoded) => new Addsubpd(encoded);

        public struct Vaddsubpd : IAsmInstruction<Vaddsubpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vaddsubpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSUBPD;

            public static implicit operator AsmMnemonicCode(Vaddsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddsubpd src) => AsmMnemonics.VADDSUBPD;
        }

        public static Vaddsubpd vaddsubpd() => default;

        [MethodImpl(Inline)]
        public static Vaddsubpd vaddsubpd(AsmHexCode encoded) => new Vaddsubpd(encoded);

        public struct Addsubps : IAsmInstruction<Addsubps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Addsubps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSUBPS;

            public static implicit operator AsmMnemonicCode(Addsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addsubps src) => AsmMnemonics.ADDSUBPS;
        }

        public static Addsubps addsubps() => default;

        [MethodImpl(Inline)]
        public static Addsubps addsubps(AsmHexCode encoded) => new Addsubps(encoded);

        public struct Vaddsubps : IAsmInstruction<Vaddsubps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vaddsubps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSUBPS;

            public static implicit operator AsmMnemonicCode(Vaddsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddsubps src) => AsmMnemonics.VADDSUBPS;
        }

        public static Vaddsubps vaddsubps() => default;

        [MethodImpl(Inline)]
        public static Vaddsubps vaddsubps(AsmHexCode encoded) => new Vaddsubps(encoded);

        public struct Aesdec : IAsmInstruction<Aesdec>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Aesdec(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESDEC;

            public static implicit operator AsmMnemonicCode(Aesdec src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesdec src) => AsmMnemonics.AESDEC;
        }

        public static Aesdec aesdec() => default;

        [MethodImpl(Inline)]
        public static Aesdec aesdec(AsmHexCode encoded) => new Aesdec(encoded);

        public struct Vaesdec : IAsmInstruction<Vaesdec>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vaesdec(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESDEC;

            public static implicit operator AsmMnemonicCode(Vaesdec src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesdec src) => AsmMnemonics.VAESDEC;
        }

        public static Vaesdec vaesdec() => default;

        [MethodImpl(Inline)]
        public static Vaesdec vaesdec(AsmHexCode encoded) => new Vaesdec(encoded);

        public struct Aesdeclast : IAsmInstruction<Aesdeclast>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Aesdeclast(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESDECLAST;

            public static implicit operator AsmMnemonicCode(Aesdeclast src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesdeclast src) => AsmMnemonics.AESDECLAST;
        }

        public static Aesdeclast aesdeclast() => default;

        [MethodImpl(Inline)]
        public static Aesdeclast aesdeclast(AsmHexCode encoded) => new Aesdeclast(encoded);

        public struct Vaesdeclast : IAsmInstruction<Vaesdeclast>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vaesdeclast(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESDECLAST;

            public static implicit operator AsmMnemonicCode(Vaesdeclast src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesdeclast src) => AsmMnemonics.VAESDECLAST;
        }

        public static Vaesdeclast vaesdeclast() => default;

        [MethodImpl(Inline)]
        public static Vaesdeclast vaesdeclast(AsmHexCode encoded) => new Vaesdeclast(encoded);

        public struct Aesenc : IAsmInstruction<Aesenc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Aesenc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESENC;

            public static implicit operator AsmMnemonicCode(Aesenc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesenc src) => AsmMnemonics.AESENC;
        }

        public static Aesenc aesenc() => default;

        [MethodImpl(Inline)]
        public static Aesenc aesenc(AsmHexCode encoded) => new Aesenc(encoded);

        public struct Vaesenc : IAsmInstruction<Vaesenc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vaesenc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESENC;

            public static implicit operator AsmMnemonicCode(Vaesenc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesenc src) => AsmMnemonics.VAESENC;
        }

        public static Vaesenc vaesenc() => default;

        [MethodImpl(Inline)]
        public static Vaesenc vaesenc(AsmHexCode encoded) => new Vaesenc(encoded);

        public struct Aesenclast : IAsmInstruction<Aesenclast>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Aesenclast(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESENCLAST;

            public static implicit operator AsmMnemonicCode(Aesenclast src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesenclast src) => AsmMnemonics.AESENCLAST;
        }

        public static Aesenclast aesenclast() => default;

        [MethodImpl(Inline)]
        public static Aesenclast aesenclast(AsmHexCode encoded) => new Aesenclast(encoded);

        public struct Vaesenclast : IAsmInstruction<Vaesenclast>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vaesenclast(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESENCLAST;

            public static implicit operator AsmMnemonicCode(Vaesenclast src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesenclast src) => AsmMnemonics.VAESENCLAST;
        }

        public static Vaesenclast vaesenclast() => default;

        [MethodImpl(Inline)]
        public static Vaesenclast vaesenclast(AsmHexCode encoded) => new Vaesenclast(encoded);

        public struct Aesimc : IAsmInstruction<Aesimc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Aesimc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESIMC;

            public static implicit operator AsmMnemonicCode(Aesimc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesimc src) => AsmMnemonics.AESIMC;
        }

        public static Aesimc aesimc() => default;

        [MethodImpl(Inline)]
        public static Aesimc aesimc(AsmHexCode encoded) => new Aesimc(encoded);

        public struct Vaesimc : IAsmInstruction<Vaesimc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vaesimc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESIMC;

            public static implicit operator AsmMnemonicCode(Vaesimc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesimc src) => AsmMnemonics.VAESIMC;
        }

        public static Vaesimc vaesimc() => default;

        [MethodImpl(Inline)]
        public static Vaesimc vaesimc(AsmHexCode encoded) => new Vaesimc(encoded);

        public struct Aeskeygenassist : IAsmInstruction<Aeskeygenassist>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Aeskeygenassist(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESKEYGENASSIST;

            public static implicit operator AsmMnemonicCode(Aeskeygenassist src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aeskeygenassist src) => AsmMnemonics.AESKEYGENASSIST;
        }

        public static Aeskeygenassist aeskeygenassist() => default;

        [MethodImpl(Inline)]
        public static Aeskeygenassist aeskeygenassist(AsmHexCode encoded) => new Aeskeygenassist(encoded);

        public struct Vaeskeygenassist : IAsmInstruction<Vaeskeygenassist>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vaeskeygenassist(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESKEYGENASSIST;

            public static implicit operator AsmMnemonicCode(Vaeskeygenassist src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaeskeygenassist src) => AsmMnemonics.VAESKEYGENASSIST;
        }

        public static Vaeskeygenassist vaeskeygenassist() => default;

        [MethodImpl(Inline)]
        public static Vaeskeygenassist vaeskeygenassist(AsmHexCode encoded) => new Vaeskeygenassist(encoded);

        public struct And : IAsmInstruction<And>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public And(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AND;

            public static implicit operator AsmMnemonicCode(And src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(And src) => AsmMnemonics.AND;
        }

        public static And and() => default;

        [MethodImpl(Inline)]
        public static And and(AsmHexCode encoded) => new And(encoded);

        public struct Andn : IAsmInstruction<Andn>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Andn(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDN;

            public static implicit operator AsmMnemonicCode(Andn src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andn src) => AsmMnemonics.ANDN;
        }

        public static Andn andn() => default;

        [MethodImpl(Inline)]
        public static Andn andn(AsmHexCode encoded) => new Andn(encoded);

        public struct Andpd : IAsmInstruction<Andpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Andpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDPD;

            public static implicit operator AsmMnemonicCode(Andpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andpd src) => AsmMnemonics.ANDPD;
        }

        public static Andpd andpd() => default;

        [MethodImpl(Inline)]
        public static Andpd andpd(AsmHexCode encoded) => new Andpd(encoded);

        public struct Vandpd : IAsmInstruction<Vandpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vandpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDPD;

            public static implicit operator AsmMnemonicCode(Vandpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vandpd src) => AsmMnemonics.VANDPD;
        }

        public static Vandpd vandpd() => default;

        [MethodImpl(Inline)]
        public static Vandpd vandpd(AsmHexCode encoded) => new Vandpd(encoded);

        public struct Andps : IAsmInstruction<Andps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Andps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDPS;

            public static implicit operator AsmMnemonicCode(Andps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andps src) => AsmMnemonics.ANDPS;
        }

        public static Andps andps() => default;

        [MethodImpl(Inline)]
        public static Andps andps(AsmHexCode encoded) => new Andps(encoded);

        public struct Vandps : IAsmInstruction<Vandps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vandps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDPS;

            public static implicit operator AsmMnemonicCode(Vandps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vandps src) => AsmMnemonics.VANDPS;
        }

        public static Vandps vandps() => default;

        [MethodImpl(Inline)]
        public static Vandps vandps(AsmHexCode encoded) => new Vandps(encoded);

        public struct Andnpd : IAsmInstruction<Andnpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Andnpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDNPD;

            public static implicit operator AsmMnemonicCode(Andnpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andnpd src) => AsmMnemonics.ANDNPD;
        }

        public static Andnpd andnpd() => default;

        [MethodImpl(Inline)]
        public static Andnpd andnpd(AsmHexCode encoded) => new Andnpd(encoded);

        public struct Vandnpd : IAsmInstruction<Vandnpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vandnpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDNPD;

            public static implicit operator AsmMnemonicCode(Vandnpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vandnpd src) => AsmMnemonics.VANDNPD;
        }

        public static Vandnpd vandnpd() => default;

        [MethodImpl(Inline)]
        public static Vandnpd vandnpd(AsmHexCode encoded) => new Vandnpd(encoded);

        public struct Andnps : IAsmInstruction<Andnps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Andnps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDNPS;

            public static implicit operator AsmMnemonicCode(Andnps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andnps src) => AsmMnemonics.ANDNPS;
        }

        public static Andnps andnps() => default;

        [MethodImpl(Inline)]
        public static Andnps andnps(AsmHexCode encoded) => new Andnps(encoded);

        public struct Vandnps : IAsmInstruction<Vandnps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vandnps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDNPS;

            public static implicit operator AsmMnemonicCode(Vandnps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vandnps src) => AsmMnemonics.VANDNPS;
        }

        public static Vandnps vandnps() => default;

        [MethodImpl(Inline)]
        public static Vandnps vandnps(AsmHexCode encoded) => new Vandnps(encoded);

        public struct Arpl : IAsmInstruction<Arpl>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Arpl(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ARPL;

            public static implicit operator AsmMnemonicCode(Arpl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Arpl src) => AsmMnemonics.ARPL;
        }

        public static Arpl arpl() => default;

        [MethodImpl(Inline)]
        public static Arpl arpl(AsmHexCode encoded) => new Arpl(encoded);

        public struct Blendpd : IAsmInstruction<Blendpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Blendpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDPD;

            public static implicit operator AsmMnemonicCode(Blendpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blendpd src) => AsmMnemonics.BLENDPD;
        }

        public static Blendpd blendpd() => default;

        [MethodImpl(Inline)]
        public static Blendpd blendpd(AsmHexCode encoded) => new Blendpd(encoded);

        public struct Vblendpd : IAsmInstruction<Vblendpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vblendpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDPD;

            public static implicit operator AsmMnemonicCode(Vblendpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vblendpd src) => AsmMnemonics.VBLENDPD;
        }

        public static Vblendpd vblendpd() => default;

        [MethodImpl(Inline)]
        public static Vblendpd vblendpd(AsmHexCode encoded) => new Vblendpd(encoded);

        public struct Bextr : IAsmInstruction<Bextr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Bextr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BEXTR;

            public static implicit operator AsmMnemonicCode(Bextr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bextr src) => AsmMnemonics.BEXTR;
        }

        public static Bextr bextr() => default;

        [MethodImpl(Inline)]
        public static Bextr bextr(AsmHexCode encoded) => new Bextr(encoded);

        public struct Blendps : IAsmInstruction<Blendps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Blendps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDPS;

            public static implicit operator AsmMnemonicCode(Blendps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blendps src) => AsmMnemonics.BLENDPS;
        }

        public static Blendps blendps() => default;

        [MethodImpl(Inline)]
        public static Blendps blendps(AsmHexCode encoded) => new Blendps(encoded);

        public struct Vblendps : IAsmInstruction<Vblendps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vblendps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDPS;

            public static implicit operator AsmMnemonicCode(Vblendps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vblendps src) => AsmMnemonics.VBLENDPS;
        }

        public static Vblendps vblendps() => default;

        [MethodImpl(Inline)]
        public static Vblendps vblendps(AsmHexCode encoded) => new Vblendps(encoded);

        public struct Blendvpd : IAsmInstruction<Blendvpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Blendvpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDVPD;

            public static implicit operator AsmMnemonicCode(Blendvpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blendvpd src) => AsmMnemonics.BLENDVPD;
        }

        public static Blendvpd blendvpd() => default;

        [MethodImpl(Inline)]
        public static Blendvpd blendvpd(AsmHexCode encoded) => new Blendvpd(encoded);

        public struct Vblendvpd : IAsmInstruction<Vblendvpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vblendvpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDVPD;

            public static implicit operator AsmMnemonicCode(Vblendvpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vblendvpd src) => AsmMnemonics.VBLENDVPD;
        }

        public static Vblendvpd vblendvpd() => default;

        [MethodImpl(Inline)]
        public static Vblendvpd vblendvpd(AsmHexCode encoded) => new Vblendvpd(encoded);

        public struct Blendvps : IAsmInstruction<Blendvps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Blendvps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDVPS;

            public static implicit operator AsmMnemonicCode(Blendvps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blendvps src) => AsmMnemonics.BLENDVPS;
        }

        public static Blendvps blendvps() => default;

        [MethodImpl(Inline)]
        public static Blendvps blendvps(AsmHexCode encoded) => new Blendvps(encoded);

        public struct Vblendvps : IAsmInstruction<Vblendvps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vblendvps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDVPS;

            public static implicit operator AsmMnemonicCode(Vblendvps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vblendvps src) => AsmMnemonics.VBLENDVPS;
        }

        public static Vblendvps vblendvps() => default;

        [MethodImpl(Inline)]
        public static Vblendvps vblendvps(AsmHexCode encoded) => new Vblendvps(encoded);

        public struct Blsi : IAsmInstruction<Blsi>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Blsi(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLSI;

            public static implicit operator AsmMnemonicCode(Blsi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blsi src) => AsmMnemonics.BLSI;
        }

        public static Blsi blsi() => default;

        [MethodImpl(Inline)]
        public static Blsi blsi(AsmHexCode encoded) => new Blsi(encoded);

        public struct Blsmsk : IAsmInstruction<Blsmsk>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Blsmsk(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLSMSK;

            public static implicit operator AsmMnemonicCode(Blsmsk src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blsmsk src) => AsmMnemonics.BLSMSK;
        }

        public static Blsmsk blsmsk() => default;

        [MethodImpl(Inline)]
        public static Blsmsk blsmsk(AsmHexCode encoded) => new Blsmsk(encoded);

        public struct Blsr : IAsmInstruction<Blsr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Blsr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLSR;

            public static implicit operator AsmMnemonicCode(Blsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blsr src) => AsmMnemonics.BLSR;
        }

        public static Blsr blsr() => default;

        [MethodImpl(Inline)]
        public static Blsr blsr(AsmHexCode encoded) => new Blsr(encoded);

        public struct Bound : IAsmInstruction<Bound>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Bound(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BOUND;

            public static implicit operator AsmMnemonicCode(Bound src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bound src) => AsmMnemonics.BOUND;
        }

        public static Bound bound() => default;

        [MethodImpl(Inline)]
        public static Bound bound(AsmHexCode encoded) => new Bound(encoded);

        public struct Bsf : IAsmInstruction<Bsf>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Bsf(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BSF;

            public static implicit operator AsmMnemonicCode(Bsf src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bsf src) => AsmMnemonics.BSF;
        }

        public static Bsf bsf() => default;

        [MethodImpl(Inline)]
        public static Bsf bsf(AsmHexCode encoded) => new Bsf(encoded);

        public struct Bsr : IAsmInstruction<Bsr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Bsr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BSR;

            public static implicit operator AsmMnemonicCode(Bsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bsr src) => AsmMnemonics.BSR;
        }

        public static Bsr bsr() => default;

        [MethodImpl(Inline)]
        public static Bsr bsr(AsmHexCode encoded) => new Bsr(encoded);

        public struct Bswap : IAsmInstruction<Bswap>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Bswap(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BSWAP;

            public static implicit operator AsmMnemonicCode(Bswap src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bswap src) => AsmMnemonics.BSWAP;
        }

        public static Bswap bswap() => default;

        [MethodImpl(Inline)]
        public static Bswap bswap(AsmHexCode encoded) => new Bswap(encoded);

        public struct Bt : IAsmInstruction<Bt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Bt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BT;

            public static implicit operator AsmMnemonicCode(Bt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bt src) => AsmMnemonics.BT;
        }

        public static Bt bt() => default;

        [MethodImpl(Inline)]
        public static Bt bt(AsmHexCode encoded) => new Bt(encoded);

        public struct Btc : IAsmInstruction<Btc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Btc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BTC;

            public static implicit operator AsmMnemonicCode(Btc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Btc src) => AsmMnemonics.BTC;
        }

        public static Btc btc() => default;

        [MethodImpl(Inline)]
        public static Btc btc(AsmHexCode encoded) => new Btc(encoded);

        public struct Btr : IAsmInstruction<Btr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Btr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BTR;

            public static implicit operator AsmMnemonicCode(Btr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Btr src) => AsmMnemonics.BTR;
        }

        public static Btr btr() => default;

        [MethodImpl(Inline)]
        public static Btr btr(AsmHexCode encoded) => new Btr(encoded);

        public struct Bts : IAsmInstruction<Bts>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Bts(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BTS;

            public static implicit operator AsmMnemonicCode(Bts src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bts src) => AsmMnemonics.BTS;
        }

        public static Bts bts() => default;

        [MethodImpl(Inline)]
        public static Bts bts(AsmHexCode encoded) => new Bts(encoded);

        public struct Bzhi : IAsmInstruction<Bzhi>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Bzhi(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BZHI;

            public static implicit operator AsmMnemonicCode(Bzhi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bzhi src) => AsmMnemonics.BZHI;
        }

        public static Bzhi bzhi() => default;

        [MethodImpl(Inline)]
        public static Bzhi bzhi(AsmHexCode encoded) => new Bzhi(encoded);

        public struct Call : IAsmInstruction<Call>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Call(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CALL;

            public static implicit operator AsmMnemonicCode(Call src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Call src) => AsmMnemonics.CALL;
        }

        public static Call call() => default;

        [MethodImpl(Inline)]
        public static Call call(AsmHexCode encoded) => new Call(encoded);

        public struct Cbw : IAsmInstruction<Cbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CBW;

            public static implicit operator AsmMnemonicCode(Cbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cbw src) => AsmMnemonics.CBW;
        }

        public static Cbw cbw() => default;

        [MethodImpl(Inline)]
        public static Cbw cbw(AsmHexCode encoded) => new Cbw(encoded);

        public struct Cwde : IAsmInstruction<Cwde>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cwde(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CWDE;

            public static implicit operator AsmMnemonicCode(Cwde src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cwde src) => AsmMnemonics.CWDE;
        }

        public static Cwde cwde() => default;

        [MethodImpl(Inline)]
        public static Cwde cwde(AsmHexCode encoded) => new Cwde(encoded);

        public struct Cdqe : IAsmInstruction<Cdqe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cdqe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CDQE;

            public static implicit operator AsmMnemonicCode(Cdqe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cdqe src) => AsmMnemonics.CDQE;
        }

        public static Cdqe cdqe() => default;

        [MethodImpl(Inline)]
        public static Cdqe cdqe(AsmHexCode encoded) => new Cdqe(encoded);

        public struct Clc : IAsmInstruction<Clc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Clc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CLC;

            public static implicit operator AsmMnemonicCode(Clc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Clc src) => AsmMnemonics.CLC;
        }

        public static Clc clc() => default;

        [MethodImpl(Inline)]
        public static Clc clc(AsmHexCode encoded) => new Clc(encoded);

        public struct Cld : IAsmInstruction<Cld>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cld(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CLD;

            public static implicit operator AsmMnemonicCode(Cld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cld src) => AsmMnemonics.CLD;
        }

        public static Cld cld() => default;

        [MethodImpl(Inline)]
        public static Cld cld(AsmHexCode encoded) => new Cld(encoded);

        public struct Clflush : IAsmInstruction<Clflush>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Clflush(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CLFLUSH;

            public static implicit operator AsmMnemonicCode(Clflush src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Clflush src) => AsmMnemonics.CLFLUSH;
        }

        public static Clflush clflush() => default;

        [MethodImpl(Inline)]
        public static Clflush clflush(AsmHexCode encoded) => new Clflush(encoded);

        public struct Cli : IAsmInstruction<Cli>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cli(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CLI;

            public static implicit operator AsmMnemonicCode(Cli src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cli src) => AsmMnemonics.CLI;
        }

        public static Cli cli() => default;

        [MethodImpl(Inline)]
        public static Cli cli(AsmHexCode encoded) => new Cli(encoded);

        public struct Clts : IAsmInstruction<Clts>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Clts(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CLTS;

            public static implicit operator AsmMnemonicCode(Clts src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Clts src) => AsmMnemonics.CLTS;
        }

        public static Clts clts() => default;

        [MethodImpl(Inline)]
        public static Clts clts(AsmHexCode encoded) => new Clts(encoded);

        public struct Cmc : IAsmInstruction<Cmc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMC;

            public static implicit operator AsmMnemonicCode(Cmc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmc src) => AsmMnemonics.CMC;
        }

        public static Cmc cmc() => default;

        [MethodImpl(Inline)]
        public static Cmc cmc(AsmHexCode encoded) => new Cmc(encoded);

        public struct Cmova : IAsmInstruction<Cmova>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmova(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVA;

            public static implicit operator AsmMnemonicCode(Cmova src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmova src) => AsmMnemonics.CMOVA;
        }

        public static Cmova cmova() => default;

        [MethodImpl(Inline)]
        public static Cmova cmova(AsmHexCode encoded) => new Cmova(encoded);

        public struct Cmovae : IAsmInstruction<Cmovae>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovae(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVAE;

            public static implicit operator AsmMnemonicCode(Cmovae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovae src) => AsmMnemonics.CMOVAE;
        }

        public static Cmovae cmovae() => default;

        [MethodImpl(Inline)]
        public static Cmovae cmovae(AsmHexCode encoded) => new Cmovae(encoded);

        public struct Cmovb : IAsmInstruction<Cmovb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVB;

            public static implicit operator AsmMnemonicCode(Cmovb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovb src) => AsmMnemonics.CMOVB;
        }

        public static Cmovb cmovb() => default;

        [MethodImpl(Inline)]
        public static Cmovb cmovb(AsmHexCode encoded) => new Cmovb(encoded);

        public struct Cmovbe : IAsmInstruction<Cmovbe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovbe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVBE;

            public static implicit operator AsmMnemonicCode(Cmovbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovbe src) => AsmMnemonics.CMOVBE;
        }

        public static Cmovbe cmovbe() => default;

        [MethodImpl(Inline)]
        public static Cmovbe cmovbe(AsmHexCode encoded) => new Cmovbe(encoded);

        public struct Cmovc : IAsmInstruction<Cmovc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVC;

            public static implicit operator AsmMnemonicCode(Cmovc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovc src) => AsmMnemonics.CMOVC;
        }

        public static Cmovc cmovc() => default;

        [MethodImpl(Inline)]
        public static Cmovc cmovc(AsmHexCode encoded) => new Cmovc(encoded);

        public struct Cmove : IAsmInstruction<Cmove>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmove(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVE;

            public static implicit operator AsmMnemonicCode(Cmove src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmove src) => AsmMnemonics.CMOVE;
        }

        public static Cmove cmove() => default;

        [MethodImpl(Inline)]
        public static Cmove cmove(AsmHexCode encoded) => new Cmove(encoded);

        public struct Cmovg : IAsmInstruction<Cmovg>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovg(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVG;

            public static implicit operator AsmMnemonicCode(Cmovg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovg src) => AsmMnemonics.CMOVG;
        }

        public static Cmovg cmovg() => default;

        [MethodImpl(Inline)]
        public static Cmovg cmovg(AsmHexCode encoded) => new Cmovg(encoded);

        public struct Cmovge : IAsmInstruction<Cmovge>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovge(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVGE;

            public static implicit operator AsmMnemonicCode(Cmovge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovge src) => AsmMnemonics.CMOVGE;
        }

        public static Cmovge cmovge() => default;

        [MethodImpl(Inline)]
        public static Cmovge cmovge(AsmHexCode encoded) => new Cmovge(encoded);

        public struct Cmovl : IAsmInstruction<Cmovl>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovl(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVL;

            public static implicit operator AsmMnemonicCode(Cmovl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovl src) => AsmMnemonics.CMOVL;
        }

        public static Cmovl cmovl() => default;

        [MethodImpl(Inline)]
        public static Cmovl cmovl(AsmHexCode encoded) => new Cmovl(encoded);

        public struct Cmovle : IAsmInstruction<Cmovle>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovle(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVLE;

            public static implicit operator AsmMnemonicCode(Cmovle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovle src) => AsmMnemonics.CMOVLE;
        }

        public static Cmovle cmovle() => default;

        [MethodImpl(Inline)]
        public static Cmovle cmovle(AsmHexCode encoded) => new Cmovle(encoded);

        public struct Cmovna : IAsmInstruction<Cmovna>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovna(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNA;

            public static implicit operator AsmMnemonicCode(Cmovna src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovna src) => AsmMnemonics.CMOVNA;
        }

        public static Cmovna cmovna() => default;

        [MethodImpl(Inline)]
        public static Cmovna cmovna(AsmHexCode encoded) => new Cmovna(encoded);

        public struct Cmovnae : IAsmInstruction<Cmovnae>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovnae(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNAE;

            public static implicit operator AsmMnemonicCode(Cmovnae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnae src) => AsmMnemonics.CMOVNAE;
        }

        public static Cmovnae cmovnae() => default;

        [MethodImpl(Inline)]
        public static Cmovnae cmovnae(AsmHexCode encoded) => new Cmovnae(encoded);

        public struct Cmovnb : IAsmInstruction<Cmovnb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovnb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNB;

            public static implicit operator AsmMnemonicCode(Cmovnb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnb src) => AsmMnemonics.CMOVNB;
        }

        public static Cmovnb cmovnb() => default;

        [MethodImpl(Inline)]
        public static Cmovnb cmovnb(AsmHexCode encoded) => new Cmovnb(encoded);

        public struct Cmovnbe : IAsmInstruction<Cmovnbe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovnbe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNBE;

            public static implicit operator AsmMnemonicCode(Cmovnbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnbe src) => AsmMnemonics.CMOVNBE;
        }

        public static Cmovnbe cmovnbe() => default;

        [MethodImpl(Inline)]
        public static Cmovnbe cmovnbe(AsmHexCode encoded) => new Cmovnbe(encoded);

        public struct Cmovnc : IAsmInstruction<Cmovnc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovnc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNC;

            public static implicit operator AsmMnemonicCode(Cmovnc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnc src) => AsmMnemonics.CMOVNC;
        }

        public static Cmovnc cmovnc() => default;

        [MethodImpl(Inline)]
        public static Cmovnc cmovnc(AsmHexCode encoded) => new Cmovnc(encoded);

        public struct Cmovne : IAsmInstruction<Cmovne>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovne(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNE;

            public static implicit operator AsmMnemonicCode(Cmovne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovne src) => AsmMnemonics.CMOVNE;
        }

        public static Cmovne cmovne() => default;

        [MethodImpl(Inline)]
        public static Cmovne cmovne(AsmHexCode encoded) => new Cmovne(encoded);

        public struct Cmovng : IAsmInstruction<Cmovng>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovng(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNG;

            public static implicit operator AsmMnemonicCode(Cmovng src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovng src) => AsmMnemonics.CMOVNG;
        }

        public static Cmovng cmovng() => default;

        [MethodImpl(Inline)]
        public static Cmovng cmovng(AsmHexCode encoded) => new Cmovng(encoded);

        public struct Cmovnge : IAsmInstruction<Cmovnge>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovnge(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNGE;

            public static implicit operator AsmMnemonicCode(Cmovnge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnge src) => AsmMnemonics.CMOVNGE;
        }

        public static Cmovnge cmovnge() => default;

        [MethodImpl(Inline)]
        public static Cmovnge cmovnge(AsmHexCode encoded) => new Cmovnge(encoded);

        public struct Cmovnl : IAsmInstruction<Cmovnl>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovnl(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNL;

            public static implicit operator AsmMnemonicCode(Cmovnl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnl src) => AsmMnemonics.CMOVNL;
        }

        public static Cmovnl cmovnl() => default;

        [MethodImpl(Inline)]
        public static Cmovnl cmovnl(AsmHexCode encoded) => new Cmovnl(encoded);

        public struct Cmovnle : IAsmInstruction<Cmovnle>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovnle(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNLE;

            public static implicit operator AsmMnemonicCode(Cmovnle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnle src) => AsmMnemonics.CMOVNLE;
        }

        public static Cmovnle cmovnle() => default;

        [MethodImpl(Inline)]
        public static Cmovnle cmovnle(AsmHexCode encoded) => new Cmovnle(encoded);

        public struct Cmovno : IAsmInstruction<Cmovno>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovno(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNO;

            public static implicit operator AsmMnemonicCode(Cmovno src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovno src) => AsmMnemonics.CMOVNO;
        }

        public static Cmovno cmovno() => default;

        [MethodImpl(Inline)]
        public static Cmovno cmovno(AsmHexCode encoded) => new Cmovno(encoded);

        public struct Cmovnp : IAsmInstruction<Cmovnp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovnp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNP;

            public static implicit operator AsmMnemonicCode(Cmovnp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnp src) => AsmMnemonics.CMOVNP;
        }

        public static Cmovnp cmovnp() => default;

        [MethodImpl(Inline)]
        public static Cmovnp cmovnp(AsmHexCode encoded) => new Cmovnp(encoded);

        public struct Cmovns : IAsmInstruction<Cmovns>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovns(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNS;

            public static implicit operator AsmMnemonicCode(Cmovns src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovns src) => AsmMnemonics.CMOVNS;
        }

        public static Cmovns cmovns() => default;

        [MethodImpl(Inline)]
        public static Cmovns cmovns(AsmHexCode encoded) => new Cmovns(encoded);

        public struct Cmovnz : IAsmInstruction<Cmovnz>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovnz(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNZ;

            public static implicit operator AsmMnemonicCode(Cmovnz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnz src) => AsmMnemonics.CMOVNZ;
        }

        public static Cmovnz cmovnz() => default;

        [MethodImpl(Inline)]
        public static Cmovnz cmovnz(AsmHexCode encoded) => new Cmovnz(encoded);

        public struct Cmovo : IAsmInstruction<Cmovo>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovo(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVO;

            public static implicit operator AsmMnemonicCode(Cmovo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovo src) => AsmMnemonics.CMOVO;
        }

        public static Cmovo cmovo() => default;

        [MethodImpl(Inline)]
        public static Cmovo cmovo(AsmHexCode encoded) => new Cmovo(encoded);

        public struct Cmovp : IAsmInstruction<Cmovp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVP;

            public static implicit operator AsmMnemonicCode(Cmovp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovp src) => AsmMnemonics.CMOVP;
        }

        public static Cmovp cmovp() => default;

        [MethodImpl(Inline)]
        public static Cmovp cmovp(AsmHexCode encoded) => new Cmovp(encoded);

        public struct Cmovpe : IAsmInstruction<Cmovpe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovpe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVPE;

            public static implicit operator AsmMnemonicCode(Cmovpe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovpe src) => AsmMnemonics.CMOVPE;
        }

        public static Cmovpe cmovpe() => default;

        [MethodImpl(Inline)]
        public static Cmovpe cmovpe(AsmHexCode encoded) => new Cmovpe(encoded);

        public struct Cmovpo : IAsmInstruction<Cmovpo>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovpo(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVPO;

            public static implicit operator AsmMnemonicCode(Cmovpo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovpo src) => AsmMnemonics.CMOVPO;
        }

        public static Cmovpo cmovpo() => default;

        [MethodImpl(Inline)]
        public static Cmovpo cmovpo(AsmHexCode encoded) => new Cmovpo(encoded);

        public struct Cmovs : IAsmInstruction<Cmovs>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovs(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVS;

            public static implicit operator AsmMnemonicCode(Cmovs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovs src) => AsmMnemonics.CMOVS;
        }

        public static Cmovs cmovs() => default;

        [MethodImpl(Inline)]
        public static Cmovs cmovs(AsmHexCode encoded) => new Cmovs(encoded);

        public struct Cmovz : IAsmInstruction<Cmovz>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmovz(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVZ;

            public static implicit operator AsmMnemonicCode(Cmovz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovz src) => AsmMnemonics.CMOVZ;
        }

        public static Cmovz cmovz() => default;

        [MethodImpl(Inline)]
        public static Cmovz cmovz(AsmHexCode encoded) => new Cmovz(encoded);

        public struct Cmp : IAsmInstruction<Cmp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMP;

            public static implicit operator AsmMnemonicCode(Cmp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmp src) => AsmMnemonics.CMP;
        }

        public static Cmp cmp() => default;

        [MethodImpl(Inline)]
        public static Cmp cmp(AsmHexCode encoded) => new Cmp(encoded);

        public struct Cmppd : IAsmInstruction<Cmppd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmppd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPPD;

            public static implicit operator AsmMnemonicCode(Cmppd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmppd src) => AsmMnemonics.CMPPD;
        }

        public static Cmppd cmppd() => default;

        [MethodImpl(Inline)]
        public static Cmppd cmppd(AsmHexCode encoded) => new Cmppd(encoded);

        public struct Vcmppd : IAsmInstruction<Vcmppd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcmppd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPPD;

            public static implicit operator AsmMnemonicCode(Vcmppd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcmppd src) => AsmMnemonics.VCMPPD;
        }

        public static Vcmppd vcmppd() => default;

        [MethodImpl(Inline)]
        public static Vcmppd vcmppd(AsmHexCode encoded) => new Vcmppd(encoded);

        public struct Cmpps : IAsmInstruction<Cmpps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmpps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPPS;

            public static implicit operator AsmMnemonicCode(Cmpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpps src) => AsmMnemonics.CMPPS;
        }

        public static Cmpps cmpps() => default;

        [MethodImpl(Inline)]
        public static Cmpps cmpps(AsmHexCode encoded) => new Cmpps(encoded);

        public struct Vcmpps : IAsmInstruction<Vcmpps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcmpps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPPS;

            public static implicit operator AsmMnemonicCode(Vcmpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcmpps src) => AsmMnemonics.VCMPPS;
        }

        public static Vcmpps vcmpps() => default;

        [MethodImpl(Inline)]
        public static Vcmpps vcmpps(AsmHexCode encoded) => new Vcmpps(encoded);

        public struct Cmps : IAsmInstruction<Cmps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPS;

            public static implicit operator AsmMnemonicCode(Cmps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmps src) => AsmMnemonics.CMPS;
        }

        public static Cmps cmps() => default;

        [MethodImpl(Inline)]
        public static Cmps cmps(AsmHexCode encoded) => new Cmps(encoded);

        public struct Cmpsb : IAsmInstruction<Cmpsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmpsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSB;

            public static implicit operator AsmMnemonicCode(Cmpsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpsb src) => AsmMnemonics.CMPSB;
        }

        public static Cmpsb cmpsb() => default;

        [MethodImpl(Inline)]
        public static Cmpsb cmpsb(AsmHexCode encoded) => new Cmpsb(encoded);

        public struct Cmpsw : IAsmInstruction<Cmpsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmpsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSW;

            public static implicit operator AsmMnemonicCode(Cmpsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpsw src) => AsmMnemonics.CMPSW;
        }

        public static Cmpsw cmpsw() => default;

        [MethodImpl(Inline)]
        public static Cmpsw cmpsw(AsmHexCode encoded) => new Cmpsw(encoded);

        public struct Cmpsd : IAsmInstruction<Cmpsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmpsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSD;

            public static implicit operator AsmMnemonicCode(Cmpsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpsd src) => AsmMnemonics.CMPSD;
        }

        public static Cmpsd cmpsd() => default;

        [MethodImpl(Inline)]
        public static Cmpsd cmpsd(AsmHexCode encoded) => new Cmpsd(encoded);

        public struct Cmpsq : IAsmInstruction<Cmpsq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmpsq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSQ;

            public static implicit operator AsmMnemonicCode(Cmpsq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpsq src) => AsmMnemonics.CMPSQ;
        }

        public static Cmpsq cmpsq() => default;

        [MethodImpl(Inline)]
        public static Cmpsq cmpsq(AsmHexCode encoded) => new Cmpsq(encoded);

        public struct Vcmpsd : IAsmInstruction<Vcmpsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcmpsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPSD;

            public static implicit operator AsmMnemonicCode(Vcmpsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcmpsd src) => AsmMnemonics.VCMPSD;
        }

        public static Vcmpsd vcmpsd() => default;

        [MethodImpl(Inline)]
        public static Vcmpsd vcmpsd(AsmHexCode encoded) => new Vcmpsd(encoded);

        public struct Cmpss : IAsmInstruction<Cmpss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmpss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSS;

            public static implicit operator AsmMnemonicCode(Cmpss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpss src) => AsmMnemonics.CMPSS;
        }

        public static Cmpss cmpss() => default;

        [MethodImpl(Inline)]
        public static Cmpss cmpss(AsmHexCode encoded) => new Cmpss(encoded);

        public struct Vcmpss : IAsmInstruction<Vcmpss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcmpss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPSS;

            public static implicit operator AsmMnemonicCode(Vcmpss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcmpss src) => AsmMnemonics.VCMPSS;
        }

        public static Vcmpss vcmpss() => default;

        [MethodImpl(Inline)]
        public static Vcmpss vcmpss(AsmHexCode encoded) => new Vcmpss(encoded);

        public struct Cmpxchg : IAsmInstruction<Cmpxchg>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmpxchg(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPXCHG;

            public static implicit operator AsmMnemonicCode(Cmpxchg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpxchg src) => AsmMnemonics.CMPXCHG;
        }

        public static Cmpxchg cmpxchg() => default;

        [MethodImpl(Inline)]
        public static Cmpxchg cmpxchg(AsmHexCode encoded) => new Cmpxchg(encoded);

        public struct Cmpxchg8b : IAsmInstruction<Cmpxchg8b>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmpxchg8b(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPXCHG8B;

            public static implicit operator AsmMnemonicCode(Cmpxchg8b src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpxchg8b src) => AsmMnemonics.CMPXCHG8B;
        }

        public static Cmpxchg8b cmpxchg8b() => default;

        [MethodImpl(Inline)]
        public static Cmpxchg8b cmpxchg8b(AsmHexCode encoded) => new Cmpxchg8b(encoded);

        public struct Cmpxchg16b : IAsmInstruction<Cmpxchg16b>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cmpxchg16b(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPXCHG16B;

            public static implicit operator AsmMnemonicCode(Cmpxchg16b src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpxchg16b src) => AsmMnemonics.CMPXCHG16B;
        }

        public static Cmpxchg16b cmpxchg16b() => default;

        [MethodImpl(Inline)]
        public static Cmpxchg16b cmpxchg16b(AsmHexCode encoded) => new Cmpxchg16b(encoded);

        public struct Comisd : IAsmInstruction<Comisd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Comisd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.COMISD;

            public static implicit operator AsmMnemonicCode(Comisd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Comisd src) => AsmMnemonics.COMISD;
        }

        public static Comisd comisd() => default;

        [MethodImpl(Inline)]
        public static Comisd comisd(AsmHexCode encoded) => new Comisd(encoded);

        public struct Vcomisd : IAsmInstruction<Vcomisd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcomisd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCOMISD;

            public static implicit operator AsmMnemonicCode(Vcomisd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcomisd src) => AsmMnemonics.VCOMISD;
        }

        public static Vcomisd vcomisd() => default;

        [MethodImpl(Inline)]
        public static Vcomisd vcomisd(AsmHexCode encoded) => new Vcomisd(encoded);

        public struct Comiss : IAsmInstruction<Comiss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Comiss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.COMISS;

            public static implicit operator AsmMnemonicCode(Comiss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Comiss src) => AsmMnemonics.COMISS;
        }

        public static Comiss comiss() => default;

        [MethodImpl(Inline)]
        public static Comiss comiss(AsmHexCode encoded) => new Comiss(encoded);

        public struct Vcomiss : IAsmInstruction<Vcomiss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcomiss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCOMISS;

            public static implicit operator AsmMnemonicCode(Vcomiss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcomiss src) => AsmMnemonics.VCOMISS;
        }

        public static Vcomiss vcomiss() => default;

        [MethodImpl(Inline)]
        public static Vcomiss vcomiss(AsmHexCode encoded) => new Vcomiss(encoded);

        public struct Cpuid : IAsmInstruction<Cpuid>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cpuid(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CPUID;

            public static implicit operator AsmMnemonicCode(Cpuid src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cpuid src) => AsmMnemonics.CPUID;
        }

        public static Cpuid cpuid() => default;

        [MethodImpl(Inline)]
        public static Cpuid cpuid(AsmHexCode encoded) => new Cpuid(encoded);

        public struct Crc32 : IAsmInstruction<Crc32>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Crc32(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CRC32;

            public static implicit operator AsmMnemonicCode(Crc32 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Crc32 src) => AsmMnemonics.CRC32;
        }

        public static Crc32 crc32() => default;

        [MethodImpl(Inline)]
        public static Crc32 crc32(AsmHexCode encoded) => new Crc32(encoded);

        public struct Cvtdq2pd : IAsmInstruction<Cvtdq2pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtdq2pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTDQ2PD;

            public static implicit operator AsmMnemonicCode(Cvtdq2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtdq2pd src) => AsmMnemonics.CVTDQ2PD;
        }

        public static Cvtdq2pd cvtdq2pd() => default;

        [MethodImpl(Inline)]
        public static Cvtdq2pd cvtdq2pd(AsmHexCode encoded) => new Cvtdq2pd(encoded);

        public struct Vcvtdq2pd : IAsmInstruction<Vcvtdq2pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtdq2pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTDQ2PD;

            public static implicit operator AsmMnemonicCode(Vcvtdq2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtdq2pd src) => AsmMnemonics.VCVTDQ2PD;
        }

        public static Vcvtdq2pd vcvtdq2pd() => default;

        [MethodImpl(Inline)]
        public static Vcvtdq2pd vcvtdq2pd(AsmHexCode encoded) => new Vcvtdq2pd(encoded);

        public struct Cvtdq2ps : IAsmInstruction<Cvtdq2ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtdq2ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTDQ2PS;

            public static implicit operator AsmMnemonicCode(Cvtdq2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtdq2ps src) => AsmMnemonics.CVTDQ2PS;
        }

        public static Cvtdq2ps cvtdq2ps() => default;

        [MethodImpl(Inline)]
        public static Cvtdq2ps cvtdq2ps(AsmHexCode encoded) => new Cvtdq2ps(encoded);

        public struct Vcvtdq2ps : IAsmInstruction<Vcvtdq2ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtdq2ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTDQ2PS;

            public static implicit operator AsmMnemonicCode(Vcvtdq2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtdq2ps src) => AsmMnemonics.VCVTDQ2PS;
        }

        public static Vcvtdq2ps vcvtdq2ps() => default;

        [MethodImpl(Inline)]
        public static Vcvtdq2ps vcvtdq2ps(AsmHexCode encoded) => new Vcvtdq2ps(encoded);

        public struct Cvtpd2dq : IAsmInstruction<Cvtpd2dq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtpd2dq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPD2DQ;

            public static implicit operator AsmMnemonicCode(Cvtpd2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpd2dq src) => AsmMnemonics.CVTPD2DQ;
        }

        public static Cvtpd2dq cvtpd2dq() => default;

        [MethodImpl(Inline)]
        public static Cvtpd2dq cvtpd2dq(AsmHexCode encoded) => new Cvtpd2dq(encoded);

        public struct Vcvtpd2dq : IAsmInstruction<Vcvtpd2dq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtpd2dq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPD2DQ;

            public static implicit operator AsmMnemonicCode(Vcvtpd2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtpd2dq src) => AsmMnemonics.VCVTPD2DQ;
        }

        public static Vcvtpd2dq vcvtpd2dq() => default;

        [MethodImpl(Inline)]
        public static Vcvtpd2dq vcvtpd2dq(AsmHexCode encoded) => new Vcvtpd2dq(encoded);

        public struct Cvtpd2pi : IAsmInstruction<Cvtpd2pi>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtpd2pi(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPD2PI;

            public static implicit operator AsmMnemonicCode(Cvtpd2pi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpd2pi src) => AsmMnemonics.CVTPD2PI;
        }

        public static Cvtpd2pi cvtpd2pi() => default;

        [MethodImpl(Inline)]
        public static Cvtpd2pi cvtpd2pi(AsmHexCode encoded) => new Cvtpd2pi(encoded);

        public struct Cvtpd2ps : IAsmInstruction<Cvtpd2ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtpd2ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPD2PS;

            public static implicit operator AsmMnemonicCode(Cvtpd2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpd2ps src) => AsmMnemonics.CVTPD2PS;
        }

        public static Cvtpd2ps cvtpd2ps() => default;

        [MethodImpl(Inline)]
        public static Cvtpd2ps cvtpd2ps(AsmHexCode encoded) => new Cvtpd2ps(encoded);

        public struct Vcvtpd2ps : IAsmInstruction<Vcvtpd2ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtpd2ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPD2PS;

            public static implicit operator AsmMnemonicCode(Vcvtpd2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtpd2ps src) => AsmMnemonics.VCVTPD2PS;
        }

        public static Vcvtpd2ps vcvtpd2ps() => default;

        [MethodImpl(Inline)]
        public static Vcvtpd2ps vcvtpd2ps(AsmHexCode encoded) => new Vcvtpd2ps(encoded);

        public struct Cvtpi2pd : IAsmInstruction<Cvtpi2pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtpi2pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPI2PD;

            public static implicit operator AsmMnemonicCode(Cvtpi2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpi2pd src) => AsmMnemonics.CVTPI2PD;
        }

        public static Cvtpi2pd cvtpi2pd() => default;

        [MethodImpl(Inline)]
        public static Cvtpi2pd cvtpi2pd(AsmHexCode encoded) => new Cvtpi2pd(encoded);

        public struct Cvtpi2ps : IAsmInstruction<Cvtpi2ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtpi2ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPI2PS;

            public static implicit operator AsmMnemonicCode(Cvtpi2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpi2ps src) => AsmMnemonics.CVTPI2PS;
        }

        public static Cvtpi2ps cvtpi2ps() => default;

        [MethodImpl(Inline)]
        public static Cvtpi2ps cvtpi2ps(AsmHexCode encoded) => new Cvtpi2ps(encoded);

        public struct Cvtps2dq : IAsmInstruction<Cvtps2dq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtps2dq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPS2DQ;

            public static implicit operator AsmMnemonicCode(Cvtps2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtps2dq src) => AsmMnemonics.CVTPS2DQ;
        }

        public static Cvtps2dq cvtps2dq() => default;

        [MethodImpl(Inline)]
        public static Cvtps2dq cvtps2dq(AsmHexCode encoded) => new Cvtps2dq(encoded);

        public struct Vcvtps2dq : IAsmInstruction<Vcvtps2dq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtps2dq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPS2DQ;

            public static implicit operator AsmMnemonicCode(Vcvtps2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtps2dq src) => AsmMnemonics.VCVTPS2DQ;
        }

        public static Vcvtps2dq vcvtps2dq() => default;

        [MethodImpl(Inline)]
        public static Vcvtps2dq vcvtps2dq(AsmHexCode encoded) => new Vcvtps2dq(encoded);

        public struct Cvtps2pd : IAsmInstruction<Cvtps2pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtps2pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPS2PD;

            public static implicit operator AsmMnemonicCode(Cvtps2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtps2pd src) => AsmMnemonics.CVTPS2PD;
        }

        public static Cvtps2pd cvtps2pd() => default;

        [MethodImpl(Inline)]
        public static Cvtps2pd cvtps2pd(AsmHexCode encoded) => new Cvtps2pd(encoded);

        public struct Vcvtps2pd : IAsmInstruction<Vcvtps2pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtps2pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPS2PD;

            public static implicit operator AsmMnemonicCode(Vcvtps2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtps2pd src) => AsmMnemonics.VCVTPS2PD;
        }

        public static Vcvtps2pd vcvtps2pd() => default;

        [MethodImpl(Inline)]
        public static Vcvtps2pd vcvtps2pd(AsmHexCode encoded) => new Vcvtps2pd(encoded);

        public struct Cvtps2pi : IAsmInstruction<Cvtps2pi>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtps2pi(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPS2PI;

            public static implicit operator AsmMnemonicCode(Cvtps2pi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtps2pi src) => AsmMnemonics.CVTPS2PI;
        }

        public static Cvtps2pi cvtps2pi() => default;

        [MethodImpl(Inline)]
        public static Cvtps2pi cvtps2pi(AsmHexCode encoded) => new Cvtps2pi(encoded);

        public struct Cvtsd2si : IAsmInstruction<Cvtsd2si>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtsd2si(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSD2SI;

            public static implicit operator AsmMnemonicCode(Cvtsd2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtsd2si src) => AsmMnemonics.CVTSD2SI;
        }

        public static Cvtsd2si cvtsd2si() => default;

        [MethodImpl(Inline)]
        public static Cvtsd2si cvtsd2si(AsmHexCode encoded) => new Cvtsd2si(encoded);

        public struct Vcvtsd2si : IAsmInstruction<Vcvtsd2si>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtsd2si(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSD2SI;

            public static implicit operator AsmMnemonicCode(Vcvtsd2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtsd2si src) => AsmMnemonics.VCVTSD2SI;
        }

        public static Vcvtsd2si vcvtsd2si() => default;

        [MethodImpl(Inline)]
        public static Vcvtsd2si vcvtsd2si(AsmHexCode encoded) => new Vcvtsd2si(encoded);

        public struct Cvtsd2ss : IAsmInstruction<Cvtsd2ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtsd2ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSD2SS;

            public static implicit operator AsmMnemonicCode(Cvtsd2ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtsd2ss src) => AsmMnemonics.CVTSD2SS;
        }

        public static Cvtsd2ss cvtsd2ss() => default;

        [MethodImpl(Inline)]
        public static Cvtsd2ss cvtsd2ss(AsmHexCode encoded) => new Cvtsd2ss(encoded);

        public struct Vcvtsd2ss : IAsmInstruction<Vcvtsd2ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtsd2ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSD2SS;

            public static implicit operator AsmMnemonicCode(Vcvtsd2ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtsd2ss src) => AsmMnemonics.VCVTSD2SS;
        }

        public static Vcvtsd2ss vcvtsd2ss() => default;

        [MethodImpl(Inline)]
        public static Vcvtsd2ss vcvtsd2ss(AsmHexCode encoded) => new Vcvtsd2ss(encoded);

        public struct Cvtsi2sd : IAsmInstruction<Cvtsi2sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtsi2sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSI2SD;

            public static implicit operator AsmMnemonicCode(Cvtsi2sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtsi2sd src) => AsmMnemonics.CVTSI2SD;
        }

        public static Cvtsi2sd cvtsi2sd() => default;

        [MethodImpl(Inline)]
        public static Cvtsi2sd cvtsi2sd(AsmHexCode encoded) => new Cvtsi2sd(encoded);

        public struct Vcvtsi2sd : IAsmInstruction<Vcvtsi2sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtsi2sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSI2SD;

            public static implicit operator AsmMnemonicCode(Vcvtsi2sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtsi2sd src) => AsmMnemonics.VCVTSI2SD;
        }

        public static Vcvtsi2sd vcvtsi2sd() => default;

        [MethodImpl(Inline)]
        public static Vcvtsi2sd vcvtsi2sd(AsmHexCode encoded) => new Vcvtsi2sd(encoded);

        public struct Cvtsi2ss : IAsmInstruction<Cvtsi2ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtsi2ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSI2SS;

            public static implicit operator AsmMnemonicCode(Cvtsi2ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtsi2ss src) => AsmMnemonics.CVTSI2SS;
        }

        public static Cvtsi2ss cvtsi2ss() => default;

        [MethodImpl(Inline)]
        public static Cvtsi2ss cvtsi2ss(AsmHexCode encoded) => new Cvtsi2ss(encoded);

        public struct Vcvtsi2ss : IAsmInstruction<Vcvtsi2ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtsi2ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSI2SS;

            public static implicit operator AsmMnemonicCode(Vcvtsi2ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtsi2ss src) => AsmMnemonics.VCVTSI2SS;
        }

        public static Vcvtsi2ss vcvtsi2ss() => default;

        [MethodImpl(Inline)]
        public static Vcvtsi2ss vcvtsi2ss(AsmHexCode encoded) => new Vcvtsi2ss(encoded);

        public struct Cvtss2sd : IAsmInstruction<Cvtss2sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtss2sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSS2SD;

            public static implicit operator AsmMnemonicCode(Cvtss2sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtss2sd src) => AsmMnemonics.CVTSS2SD;
        }

        public static Cvtss2sd cvtss2sd() => default;

        [MethodImpl(Inline)]
        public static Cvtss2sd cvtss2sd(AsmHexCode encoded) => new Cvtss2sd(encoded);

        public struct Vcvtss2sd : IAsmInstruction<Vcvtss2sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtss2sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSS2SD;

            public static implicit operator AsmMnemonicCode(Vcvtss2sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtss2sd src) => AsmMnemonics.VCVTSS2SD;
        }

        public static Vcvtss2sd vcvtss2sd() => default;

        [MethodImpl(Inline)]
        public static Vcvtss2sd vcvtss2sd(AsmHexCode encoded) => new Vcvtss2sd(encoded);

        public struct Cvtss2si : IAsmInstruction<Cvtss2si>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvtss2si(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSS2SI;

            public static implicit operator AsmMnemonicCode(Cvtss2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtss2si src) => AsmMnemonics.CVTSS2SI;
        }

        public static Cvtss2si cvtss2si() => default;

        [MethodImpl(Inline)]
        public static Cvtss2si cvtss2si(AsmHexCode encoded) => new Cvtss2si(encoded);

        public struct Vcvtss2si : IAsmInstruction<Vcvtss2si>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtss2si(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSS2SI;

            public static implicit operator AsmMnemonicCode(Vcvtss2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtss2si src) => AsmMnemonics.VCVTSS2SI;
        }

        public static Vcvtss2si vcvtss2si() => default;

        [MethodImpl(Inline)]
        public static Vcvtss2si vcvtss2si(AsmHexCode encoded) => new Vcvtss2si(encoded);

        public struct Cvttpd2dq : IAsmInstruction<Cvttpd2dq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvttpd2dq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPD2DQ;

            public static implicit operator AsmMnemonicCode(Cvttpd2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttpd2dq src) => AsmMnemonics.CVTTPD2DQ;
        }

        public static Cvttpd2dq cvttpd2dq() => default;

        [MethodImpl(Inline)]
        public static Cvttpd2dq cvttpd2dq(AsmHexCode encoded) => new Cvttpd2dq(encoded);

        public struct Vcvttpd2dq : IAsmInstruction<Vcvttpd2dq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvttpd2dq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTPD2DQ;

            public static implicit operator AsmMnemonicCode(Vcvttpd2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvttpd2dq src) => AsmMnemonics.VCVTTPD2DQ;
        }

        public static Vcvttpd2dq vcvttpd2dq() => default;

        [MethodImpl(Inline)]
        public static Vcvttpd2dq vcvttpd2dq(AsmHexCode encoded) => new Vcvttpd2dq(encoded);

        public struct Cvttpd2pi : IAsmInstruction<Cvttpd2pi>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvttpd2pi(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPD2PI;

            public static implicit operator AsmMnemonicCode(Cvttpd2pi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttpd2pi src) => AsmMnemonics.CVTTPD2PI;
        }

        public static Cvttpd2pi cvttpd2pi() => default;

        [MethodImpl(Inline)]
        public static Cvttpd2pi cvttpd2pi(AsmHexCode encoded) => new Cvttpd2pi(encoded);

        public struct Cvttps2dq : IAsmInstruction<Cvttps2dq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvttps2dq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPS2DQ;

            public static implicit operator AsmMnemonicCode(Cvttps2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttps2dq src) => AsmMnemonics.CVTTPS2DQ;
        }

        public static Cvttps2dq cvttps2dq() => default;

        [MethodImpl(Inline)]
        public static Cvttps2dq cvttps2dq(AsmHexCode encoded) => new Cvttps2dq(encoded);

        public struct Vcvttps2dq : IAsmInstruction<Vcvttps2dq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvttps2dq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTPS2DQ;

            public static implicit operator AsmMnemonicCode(Vcvttps2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvttps2dq src) => AsmMnemonics.VCVTTPS2DQ;
        }

        public static Vcvttps2dq vcvttps2dq() => default;

        [MethodImpl(Inline)]
        public static Vcvttps2dq vcvttps2dq(AsmHexCode encoded) => new Vcvttps2dq(encoded);

        public struct Cvttps2pi : IAsmInstruction<Cvttps2pi>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvttps2pi(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPS2PI;

            public static implicit operator AsmMnemonicCode(Cvttps2pi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttps2pi src) => AsmMnemonics.CVTTPS2PI;
        }

        public static Cvttps2pi cvttps2pi() => default;

        [MethodImpl(Inline)]
        public static Cvttps2pi cvttps2pi(AsmHexCode encoded) => new Cvttps2pi(encoded);

        public struct Cvttsd2si : IAsmInstruction<Cvttsd2si>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvttsd2si(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTSD2SI;

            public static implicit operator AsmMnemonicCode(Cvttsd2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttsd2si src) => AsmMnemonics.CVTTSD2SI;
        }

        public static Cvttsd2si cvttsd2si() => default;

        [MethodImpl(Inline)]
        public static Cvttsd2si cvttsd2si(AsmHexCode encoded) => new Cvttsd2si(encoded);

        public struct Vcvttsd2si : IAsmInstruction<Vcvttsd2si>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvttsd2si(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTSD2SI;

            public static implicit operator AsmMnemonicCode(Vcvttsd2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvttsd2si src) => AsmMnemonics.VCVTTSD2SI;
        }

        public static Vcvttsd2si vcvttsd2si() => default;

        [MethodImpl(Inline)]
        public static Vcvttsd2si vcvttsd2si(AsmHexCode encoded) => new Vcvttsd2si(encoded);

        public struct Cvttss2si : IAsmInstruction<Cvttss2si>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cvttss2si(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTSS2SI;

            public static implicit operator AsmMnemonicCode(Cvttss2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttss2si src) => AsmMnemonics.CVTTSS2SI;
        }

        public static Cvttss2si cvttss2si() => default;

        [MethodImpl(Inline)]
        public static Cvttss2si cvttss2si(AsmHexCode encoded) => new Cvttss2si(encoded);

        public struct Vcvttss2si : IAsmInstruction<Vcvttss2si>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvttss2si(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTSS2SI;

            public static implicit operator AsmMnemonicCode(Vcvttss2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvttss2si src) => AsmMnemonics.VCVTTSS2SI;
        }

        public static Vcvttss2si vcvttss2si() => default;

        [MethodImpl(Inline)]
        public static Vcvttss2si vcvttss2si(AsmHexCode encoded) => new Vcvttss2si(encoded);

        public struct Cwd : IAsmInstruction<Cwd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cwd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CWD;

            public static implicit operator AsmMnemonicCode(Cwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cwd src) => AsmMnemonics.CWD;
        }

        public static Cwd cwd() => default;

        [MethodImpl(Inline)]
        public static Cwd cwd(AsmHexCode encoded) => new Cwd(encoded);

        public struct Cdq : IAsmInstruction<Cdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CDQ;

            public static implicit operator AsmMnemonicCode(Cdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cdq src) => AsmMnemonics.CDQ;
        }

        public static Cdq cdq() => default;

        [MethodImpl(Inline)]
        public static Cdq cdq(AsmHexCode encoded) => new Cdq(encoded);

        public struct Cqo : IAsmInstruction<Cqo>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Cqo(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CQO;

            public static implicit operator AsmMnemonicCode(Cqo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cqo src) => AsmMnemonics.CQO;
        }

        public static Cqo cqo() => default;

        [MethodImpl(Inline)]
        public static Cqo cqo(AsmHexCode encoded) => new Cqo(encoded);

        public struct Daa : IAsmInstruction<Daa>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Daa(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DAA;

            public static implicit operator AsmMnemonicCode(Daa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Daa src) => AsmMnemonics.DAA;
        }

        public static Daa daa() => default;

        [MethodImpl(Inline)]
        public static Daa daa(AsmHexCode encoded) => new Daa(encoded);

        public struct Das : IAsmInstruction<Das>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Das(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DAS;

            public static implicit operator AsmMnemonicCode(Das src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Das src) => AsmMnemonics.DAS;
        }

        public static Das das() => default;

        [MethodImpl(Inline)]
        public static Das das(AsmHexCode encoded) => new Das(encoded);

        public struct Dec : IAsmInstruction<Dec>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Dec(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DEC;

            public static implicit operator AsmMnemonicCode(Dec src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Dec src) => AsmMnemonics.DEC;
        }

        public static Dec dec() => default;

        [MethodImpl(Inline)]
        public static Dec dec(AsmHexCode encoded) => new Dec(encoded);

        public struct Div : IAsmInstruction<Div>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Div(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIV;

            public static implicit operator AsmMnemonicCode(Div src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Div src) => AsmMnemonics.DIV;
        }

        public static Div div() => default;

        [MethodImpl(Inline)]
        public static Div div(AsmHexCode encoded) => new Div(encoded);

        public struct Divpd : IAsmInstruction<Divpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Divpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVPD;

            public static implicit operator AsmMnemonicCode(Divpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Divpd src) => AsmMnemonics.DIVPD;
        }

        public static Divpd divpd() => default;

        [MethodImpl(Inline)]
        public static Divpd divpd(AsmHexCode encoded) => new Divpd(encoded);

        public struct Vdivpd : IAsmInstruction<Vdivpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vdivpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVPD;

            public static implicit operator AsmMnemonicCode(Vdivpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdivpd src) => AsmMnemonics.VDIVPD;
        }

        public static Vdivpd vdivpd() => default;

        [MethodImpl(Inline)]
        public static Vdivpd vdivpd(AsmHexCode encoded) => new Vdivpd(encoded);

        public struct Divps : IAsmInstruction<Divps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Divps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVPS;

            public static implicit operator AsmMnemonicCode(Divps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Divps src) => AsmMnemonics.DIVPS;
        }

        public static Divps divps() => default;

        [MethodImpl(Inline)]
        public static Divps divps(AsmHexCode encoded) => new Divps(encoded);

        public struct Vdivps : IAsmInstruction<Vdivps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vdivps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVPS;

            public static implicit operator AsmMnemonicCode(Vdivps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdivps src) => AsmMnemonics.VDIVPS;
        }

        public static Vdivps vdivps() => default;

        [MethodImpl(Inline)]
        public static Vdivps vdivps(AsmHexCode encoded) => new Vdivps(encoded);

        public struct Divsd : IAsmInstruction<Divsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Divsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVSD;

            public static implicit operator AsmMnemonicCode(Divsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Divsd src) => AsmMnemonics.DIVSD;
        }

        public static Divsd divsd() => default;

        [MethodImpl(Inline)]
        public static Divsd divsd(AsmHexCode encoded) => new Divsd(encoded);

        public struct Vdivsd : IAsmInstruction<Vdivsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vdivsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVSD;

            public static implicit operator AsmMnemonicCode(Vdivsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdivsd src) => AsmMnemonics.VDIVSD;
        }

        public static Vdivsd vdivsd() => default;

        [MethodImpl(Inline)]
        public static Vdivsd vdivsd(AsmHexCode encoded) => new Vdivsd(encoded);

        public struct Divss : IAsmInstruction<Divss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Divss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVSS;

            public static implicit operator AsmMnemonicCode(Divss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Divss src) => AsmMnemonics.DIVSS;
        }

        public static Divss divss() => default;

        [MethodImpl(Inline)]
        public static Divss divss(AsmHexCode encoded) => new Divss(encoded);

        public struct Vdivss : IAsmInstruction<Vdivss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vdivss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVSS;

            public static implicit operator AsmMnemonicCode(Vdivss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdivss src) => AsmMnemonics.VDIVSS;
        }

        public static Vdivss vdivss() => default;

        [MethodImpl(Inline)]
        public static Vdivss vdivss(AsmHexCode encoded) => new Vdivss(encoded);

        public struct Dppd : IAsmInstruction<Dppd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Dppd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DPPD;

            public static implicit operator AsmMnemonicCode(Dppd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Dppd src) => AsmMnemonics.DPPD;
        }

        public static Dppd dppd() => default;

        [MethodImpl(Inline)]
        public static Dppd dppd(AsmHexCode encoded) => new Dppd(encoded);

        public struct Vdppd : IAsmInstruction<Vdppd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vdppd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDPPD;

            public static implicit operator AsmMnemonicCode(Vdppd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdppd src) => AsmMnemonics.VDPPD;
        }

        public static Vdppd vdppd() => default;

        [MethodImpl(Inline)]
        public static Vdppd vdppd(AsmHexCode encoded) => new Vdppd(encoded);

        public struct Dpps : IAsmInstruction<Dpps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Dpps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DPPS;

            public static implicit operator AsmMnemonicCode(Dpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Dpps src) => AsmMnemonics.DPPS;
        }

        public static Dpps dpps() => default;

        [MethodImpl(Inline)]
        public static Dpps dpps(AsmHexCode encoded) => new Dpps(encoded);

        public struct Vdpps : IAsmInstruction<Vdpps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vdpps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDPPS;

            public static implicit operator AsmMnemonicCode(Vdpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdpps src) => AsmMnemonics.VDPPS;
        }

        public static Vdpps vdpps() => default;

        [MethodImpl(Inline)]
        public static Vdpps vdpps(AsmHexCode encoded) => new Vdpps(encoded);

        public struct Emms : IAsmInstruction<Emms>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Emms(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.EMMS;

            public static implicit operator AsmMnemonicCode(Emms src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Emms src) => AsmMnemonics.EMMS;
        }

        public static Emms emms() => default;

        [MethodImpl(Inline)]
        public static Emms emms(AsmHexCode encoded) => new Emms(encoded);

        public struct Enter : IAsmInstruction<Enter>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Enter(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ENTER;

            public static implicit operator AsmMnemonicCode(Enter src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Enter src) => AsmMnemonics.ENTER;
        }

        public static Enter enter() => default;

        [MethodImpl(Inline)]
        public static Enter enter(AsmHexCode encoded) => new Enter(encoded);

        public struct Extractps : IAsmInstruction<Extractps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Extractps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.EXTRACTPS;

            public static implicit operator AsmMnemonicCode(Extractps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Extractps src) => AsmMnemonics.EXTRACTPS;
        }

        public static Extractps extractps() => default;

        [MethodImpl(Inline)]
        public static Extractps extractps(AsmHexCode encoded) => new Extractps(encoded);

        public struct Vextractps : IAsmInstruction<Vextractps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vextractps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VEXTRACTPS;

            public static implicit operator AsmMnemonicCode(Vextractps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vextractps src) => AsmMnemonics.VEXTRACTPS;
        }

        public static Vextractps vextractps() => default;

        [MethodImpl(Inline)]
        public static Vextractps vextractps(AsmHexCode encoded) => new Vextractps(encoded);

        public struct F2xm1 : IAsmInstruction<F2xm1>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public F2xm1(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.F2XM1;

            public static implicit operator AsmMnemonicCode(F2xm1 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(F2xm1 src) => AsmMnemonics.F2XM1;
        }

        public static F2xm1 f2xm1() => default;

        [MethodImpl(Inline)]
        public static F2xm1 f2xm1(AsmHexCode encoded) => new F2xm1(encoded);

        public struct Fabs : IAsmInstruction<Fabs>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fabs(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FABS;

            public static implicit operator AsmMnemonicCode(Fabs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fabs src) => AsmMnemonics.FABS;
        }

        public static Fabs fabs() => default;

        [MethodImpl(Inline)]
        public static Fabs fabs(AsmHexCode encoded) => new Fabs(encoded);

        public struct Fadd : IAsmInstruction<Fadd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fadd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FADD;

            public static implicit operator AsmMnemonicCode(Fadd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fadd src) => AsmMnemonics.FADD;
        }

        public static Fadd fadd() => default;

        [MethodImpl(Inline)]
        public static Fadd fadd(AsmHexCode encoded) => new Fadd(encoded);

        public struct Faddp : IAsmInstruction<Faddp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Faddp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FADDP;

            public static implicit operator AsmMnemonicCode(Faddp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Faddp src) => AsmMnemonics.FADDP;
        }

        public static Faddp faddp() => default;

        [MethodImpl(Inline)]
        public static Faddp faddp(AsmHexCode encoded) => new Faddp(encoded);

        public struct Fiadd : IAsmInstruction<Fiadd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fiadd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIADD;

            public static implicit operator AsmMnemonicCode(Fiadd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fiadd src) => AsmMnemonics.FIADD;
        }

        public static Fiadd fiadd() => default;

        [MethodImpl(Inline)]
        public static Fiadd fiadd(AsmHexCode encoded) => new Fiadd(encoded);

        public struct Fbld : IAsmInstruction<Fbld>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fbld(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FBLD;

            public static implicit operator AsmMnemonicCode(Fbld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fbld src) => AsmMnemonics.FBLD;
        }

        public static Fbld fbld() => default;

        [MethodImpl(Inline)]
        public static Fbld fbld(AsmHexCode encoded) => new Fbld(encoded);

        public struct Fbstp : IAsmInstruction<Fbstp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fbstp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FBSTP;

            public static implicit operator AsmMnemonicCode(Fbstp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fbstp src) => AsmMnemonics.FBSTP;
        }

        public static Fbstp fbstp() => default;

        [MethodImpl(Inline)]
        public static Fbstp fbstp(AsmHexCode encoded) => new Fbstp(encoded);

        public struct Fchs : IAsmInstruction<Fchs>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fchs(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCHS;

            public static implicit operator AsmMnemonicCode(Fchs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fchs src) => AsmMnemonics.FCHS;
        }

        public static Fchs fchs() => default;

        [MethodImpl(Inline)]
        public static Fchs fchs(AsmHexCode encoded) => new Fchs(encoded);

        public struct Fclex : IAsmInstruction<Fclex>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fclex(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCLEX;

            public static implicit operator AsmMnemonicCode(Fclex src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fclex src) => AsmMnemonics.FCLEX;
        }

        public static Fclex fclex() => default;

        [MethodImpl(Inline)]
        public static Fclex fclex(AsmHexCode encoded) => new Fclex(encoded);

        public struct Fnclex : IAsmInstruction<Fnclex>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fnclex(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNCLEX;

            public static implicit operator AsmMnemonicCode(Fnclex src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnclex src) => AsmMnemonics.FNCLEX;
        }

        public static Fnclex fnclex() => default;

        [MethodImpl(Inline)]
        public static Fnclex fnclex(AsmHexCode encoded) => new Fnclex(encoded);

        public struct Fcmovb : IAsmInstruction<Fcmovb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcmovb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVB;

            public static implicit operator AsmMnemonicCode(Fcmovb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovb src) => AsmMnemonics.FCMOVB;
        }

        public static Fcmovb fcmovb() => default;

        [MethodImpl(Inline)]
        public static Fcmovb fcmovb(AsmHexCode encoded) => new Fcmovb(encoded);

        public struct Fcmove : IAsmInstruction<Fcmove>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcmove(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVE;

            public static implicit operator AsmMnemonicCode(Fcmove src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmove src) => AsmMnemonics.FCMOVE;
        }

        public static Fcmove fcmove() => default;

        [MethodImpl(Inline)]
        public static Fcmove fcmove(AsmHexCode encoded) => new Fcmove(encoded);

        public struct Fcmovbe : IAsmInstruction<Fcmovbe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcmovbe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVBE;

            public static implicit operator AsmMnemonicCode(Fcmovbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovbe src) => AsmMnemonics.FCMOVBE;
        }

        public static Fcmovbe fcmovbe() => default;

        [MethodImpl(Inline)]
        public static Fcmovbe fcmovbe(AsmHexCode encoded) => new Fcmovbe(encoded);

        public struct Fcmovu : IAsmInstruction<Fcmovu>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcmovu(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVU;

            public static implicit operator AsmMnemonicCode(Fcmovu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovu src) => AsmMnemonics.FCMOVU;
        }

        public static Fcmovu fcmovu() => default;

        [MethodImpl(Inline)]
        public static Fcmovu fcmovu(AsmHexCode encoded) => new Fcmovu(encoded);

        public struct Fcmovnb : IAsmInstruction<Fcmovnb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcmovnb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNB;

            public static implicit operator AsmMnemonicCode(Fcmovnb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovnb src) => AsmMnemonics.FCMOVNB;
        }

        public static Fcmovnb fcmovnb() => default;

        [MethodImpl(Inline)]
        public static Fcmovnb fcmovnb(AsmHexCode encoded) => new Fcmovnb(encoded);

        public struct Fcmovne : IAsmInstruction<Fcmovne>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcmovne(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNE;

            public static implicit operator AsmMnemonicCode(Fcmovne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovne src) => AsmMnemonics.FCMOVNE;
        }

        public static Fcmovne fcmovne() => default;

        [MethodImpl(Inline)]
        public static Fcmovne fcmovne(AsmHexCode encoded) => new Fcmovne(encoded);

        public struct Fcmovnbe : IAsmInstruction<Fcmovnbe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcmovnbe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNBE;

            public static implicit operator AsmMnemonicCode(Fcmovnbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovnbe src) => AsmMnemonics.FCMOVNBE;
        }

        public static Fcmovnbe fcmovnbe() => default;

        [MethodImpl(Inline)]
        public static Fcmovnbe fcmovnbe(AsmHexCode encoded) => new Fcmovnbe(encoded);

        public struct Fcmovnu : IAsmInstruction<Fcmovnu>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcmovnu(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNU;

            public static implicit operator AsmMnemonicCode(Fcmovnu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovnu src) => AsmMnemonics.FCMOVNU;
        }

        public static Fcmovnu fcmovnu() => default;

        [MethodImpl(Inline)]
        public static Fcmovnu fcmovnu(AsmHexCode encoded) => new Fcmovnu(encoded);

        public struct Fcom : IAsmInstruction<Fcom>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcom(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOM;

            public static implicit operator AsmMnemonicCode(Fcom src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcom src) => AsmMnemonics.FCOM;
        }

        public static Fcom fcom() => default;

        [MethodImpl(Inline)]
        public static Fcom fcom(AsmHexCode encoded) => new Fcom(encoded);

        public struct Fcomp : IAsmInstruction<Fcomp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcomp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMP;

            public static implicit operator AsmMnemonicCode(Fcomp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcomp src) => AsmMnemonics.FCOMP;
        }

        public static Fcomp fcomp() => default;

        [MethodImpl(Inline)]
        public static Fcomp fcomp(AsmHexCode encoded) => new Fcomp(encoded);

        public struct Fcompp : IAsmInstruction<Fcompp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcompp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMPP;

            public static implicit operator AsmMnemonicCode(Fcompp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcompp src) => AsmMnemonics.FCOMPP;
        }

        public static Fcompp fcompp() => default;

        [MethodImpl(Inline)]
        public static Fcompp fcompp(AsmHexCode encoded) => new Fcompp(encoded);

        public struct Fcomi : IAsmInstruction<Fcomi>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcomi(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMI;

            public static implicit operator AsmMnemonicCode(Fcomi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcomi src) => AsmMnemonics.FCOMI;
        }

        public static Fcomi fcomi() => default;

        [MethodImpl(Inline)]
        public static Fcomi fcomi(AsmHexCode encoded) => new Fcomi(encoded);

        public struct Fcomip : IAsmInstruction<Fcomip>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcomip(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMIP;

            public static implicit operator AsmMnemonicCode(Fcomip src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcomip src) => AsmMnemonics.FCOMIP;
        }

        public static Fcomip fcomip() => default;

        [MethodImpl(Inline)]
        public static Fcomip fcomip(AsmHexCode encoded) => new Fcomip(encoded);

        public struct Fucomi : IAsmInstruction<Fucomi>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fucomi(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMI;

            public static implicit operator AsmMnemonicCode(Fucomi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucomi src) => AsmMnemonics.FUCOMI;
        }

        public static Fucomi fucomi() => default;

        [MethodImpl(Inline)]
        public static Fucomi fucomi(AsmHexCode encoded) => new Fucomi(encoded);

        public struct Fucomip : IAsmInstruction<Fucomip>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fucomip(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMIP;

            public static implicit operator AsmMnemonicCode(Fucomip src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucomip src) => AsmMnemonics.FUCOMIP;
        }

        public static Fucomip fucomip() => default;

        [MethodImpl(Inline)]
        public static Fucomip fucomip(AsmHexCode encoded) => new Fucomip(encoded);

        public struct Fcos : IAsmInstruction<Fcos>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fcos(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOS;

            public static implicit operator AsmMnemonicCode(Fcos src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcos src) => AsmMnemonics.FCOS;
        }

        public static Fcos fcos() => default;

        [MethodImpl(Inline)]
        public static Fcos fcos(AsmHexCode encoded) => new Fcos(encoded);

        public struct Fdecstp : IAsmInstruction<Fdecstp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fdecstp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDECSTP;

            public static implicit operator AsmMnemonicCode(Fdecstp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdecstp src) => AsmMnemonics.FDECSTP;
        }

        public static Fdecstp fdecstp() => default;

        [MethodImpl(Inline)]
        public static Fdecstp fdecstp(AsmHexCode encoded) => new Fdecstp(encoded);

        public struct Fdiv : IAsmInstruction<Fdiv>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fdiv(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIV;

            public static implicit operator AsmMnemonicCode(Fdiv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdiv src) => AsmMnemonics.FDIV;
        }

        public static Fdiv fdiv() => default;

        [MethodImpl(Inline)]
        public static Fdiv fdiv(AsmHexCode encoded) => new Fdiv(encoded);

        public struct Fdivp : IAsmInstruction<Fdivp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fdivp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIVP;

            public static implicit operator AsmMnemonicCode(Fdivp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdivp src) => AsmMnemonics.FDIVP;
        }

        public static Fdivp fdivp() => default;

        [MethodImpl(Inline)]
        public static Fdivp fdivp(AsmHexCode encoded) => new Fdivp(encoded);

        public struct Fidiv : IAsmInstruction<Fidiv>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fidiv(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIDIV;

            public static implicit operator AsmMnemonicCode(Fidiv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fidiv src) => AsmMnemonics.FIDIV;
        }

        public static Fidiv fidiv() => default;

        [MethodImpl(Inline)]
        public static Fidiv fidiv(AsmHexCode encoded) => new Fidiv(encoded);

        public struct Fdivr : IAsmInstruction<Fdivr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fdivr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIVR;

            public static implicit operator AsmMnemonicCode(Fdivr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdivr src) => AsmMnemonics.FDIVR;
        }

        public static Fdivr fdivr() => default;

        [MethodImpl(Inline)]
        public static Fdivr fdivr(AsmHexCode encoded) => new Fdivr(encoded);

        public struct Fdivrp : IAsmInstruction<Fdivrp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fdivrp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIVRP;

            public static implicit operator AsmMnemonicCode(Fdivrp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdivrp src) => AsmMnemonics.FDIVRP;
        }

        public static Fdivrp fdivrp() => default;

        [MethodImpl(Inline)]
        public static Fdivrp fdivrp(AsmHexCode encoded) => new Fdivrp(encoded);

        public struct Fidivr : IAsmInstruction<Fidivr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fidivr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIDIVR;

            public static implicit operator AsmMnemonicCode(Fidivr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fidivr src) => AsmMnemonics.FIDIVR;
        }

        public static Fidivr fidivr() => default;

        [MethodImpl(Inline)]
        public static Fidivr fidivr(AsmHexCode encoded) => new Fidivr(encoded);

        public struct Ffree : IAsmInstruction<Ffree>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ffree(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FFREE;

            public static implicit operator AsmMnemonicCode(Ffree src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ffree src) => AsmMnemonics.FFREE;
        }

        public static Ffree ffree() => default;

        [MethodImpl(Inline)]
        public static Ffree ffree(AsmHexCode encoded) => new Ffree(encoded);

        public struct Ficom : IAsmInstruction<Ficom>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ficom(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FICOM;

            public static implicit operator AsmMnemonicCode(Ficom src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ficom src) => AsmMnemonics.FICOM;
        }

        public static Ficom ficom() => default;

        [MethodImpl(Inline)]
        public static Ficom ficom(AsmHexCode encoded) => new Ficom(encoded);

        public struct Ficomp : IAsmInstruction<Ficomp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ficomp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FICOMP;

            public static implicit operator AsmMnemonicCode(Ficomp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ficomp src) => AsmMnemonics.FICOMP;
        }

        public static Ficomp ficomp() => default;

        [MethodImpl(Inline)]
        public static Ficomp ficomp(AsmHexCode encoded) => new Ficomp(encoded);

        public struct Fild : IAsmInstruction<Fild>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fild(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FILD;

            public static implicit operator AsmMnemonicCode(Fild src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fild src) => AsmMnemonics.FILD;
        }

        public static Fild fild() => default;

        [MethodImpl(Inline)]
        public static Fild fild(AsmHexCode encoded) => new Fild(encoded);

        public struct Fincstp : IAsmInstruction<Fincstp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fincstp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FINCSTP;

            public static implicit operator AsmMnemonicCode(Fincstp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fincstp src) => AsmMnemonics.FINCSTP;
        }

        public static Fincstp fincstp() => default;

        [MethodImpl(Inline)]
        public static Fincstp fincstp(AsmHexCode encoded) => new Fincstp(encoded);

        public struct Finit : IAsmInstruction<Finit>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Finit(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FINIT;

            public static implicit operator AsmMnemonicCode(Finit src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Finit src) => AsmMnemonics.FINIT;
        }

        public static Finit finit() => default;

        [MethodImpl(Inline)]
        public static Finit finit(AsmHexCode encoded) => new Finit(encoded);

        public struct Fninit : IAsmInstruction<Fninit>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fninit(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNINIT;

            public static implicit operator AsmMnemonicCode(Fninit src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fninit src) => AsmMnemonics.FNINIT;
        }

        public static Fninit fninit() => default;

        [MethodImpl(Inline)]
        public static Fninit fninit(AsmHexCode encoded) => new Fninit(encoded);

        public struct Fist : IAsmInstruction<Fist>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fist(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIST;

            public static implicit operator AsmMnemonicCode(Fist src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fist src) => AsmMnemonics.FIST;
        }

        public static Fist fist() => default;

        [MethodImpl(Inline)]
        public static Fist fist(AsmHexCode encoded) => new Fist(encoded);

        public struct Fistp : IAsmInstruction<Fistp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fistp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISTP;

            public static implicit operator AsmMnemonicCode(Fistp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fistp src) => AsmMnemonics.FISTP;
        }

        public static Fistp fistp() => default;

        [MethodImpl(Inline)]
        public static Fistp fistp(AsmHexCode encoded) => new Fistp(encoded);

        public struct Fisttp : IAsmInstruction<Fisttp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fisttp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISTTP;

            public static implicit operator AsmMnemonicCode(Fisttp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fisttp src) => AsmMnemonics.FISTTP;
        }

        public static Fisttp fisttp() => default;

        [MethodImpl(Inline)]
        public static Fisttp fisttp(AsmHexCode encoded) => new Fisttp(encoded);

        public struct Fld : IAsmInstruction<Fld>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fld(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLD;

            public static implicit operator AsmMnemonicCode(Fld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fld src) => AsmMnemonics.FLD;
        }

        public static Fld fld() => default;

        [MethodImpl(Inline)]
        public static Fld fld(AsmHexCode encoded) => new Fld(encoded);

        public struct Fld1 : IAsmInstruction<Fld1>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fld1(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLD1;

            public static implicit operator AsmMnemonicCode(Fld1 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fld1 src) => AsmMnemonics.FLD1;
        }

        public static Fld1 fld1() => default;

        [MethodImpl(Inline)]
        public static Fld1 fld1(AsmHexCode encoded) => new Fld1(encoded);

        public struct Fldl2t : IAsmInstruction<Fldl2t>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fldl2t(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDL2T;

            public static implicit operator AsmMnemonicCode(Fldl2t src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldl2t src) => AsmMnemonics.FLDL2T;
        }

        public static Fldl2t fldl2t() => default;

        [MethodImpl(Inline)]
        public static Fldl2t fldl2t(AsmHexCode encoded) => new Fldl2t(encoded);

        public struct Fldl2e : IAsmInstruction<Fldl2e>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fldl2e(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDL2E;

            public static implicit operator AsmMnemonicCode(Fldl2e src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldl2e src) => AsmMnemonics.FLDL2E;
        }

        public static Fldl2e fldl2e() => default;

        [MethodImpl(Inline)]
        public static Fldl2e fldl2e(AsmHexCode encoded) => new Fldl2e(encoded);

        public struct Fldpi : IAsmInstruction<Fldpi>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fldpi(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDPI;

            public static implicit operator AsmMnemonicCode(Fldpi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldpi src) => AsmMnemonics.FLDPI;
        }

        public static Fldpi fldpi() => default;

        [MethodImpl(Inline)]
        public static Fldpi fldpi(AsmHexCode encoded) => new Fldpi(encoded);

        public struct Fldlg2 : IAsmInstruction<Fldlg2>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fldlg2(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDLG2;

            public static implicit operator AsmMnemonicCode(Fldlg2 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldlg2 src) => AsmMnemonics.FLDLG2;
        }

        public static Fldlg2 fldlg2() => default;

        [MethodImpl(Inline)]
        public static Fldlg2 fldlg2(AsmHexCode encoded) => new Fldlg2(encoded);

        public struct Fldln2 : IAsmInstruction<Fldln2>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fldln2(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDLN2;

            public static implicit operator AsmMnemonicCode(Fldln2 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldln2 src) => AsmMnemonics.FLDLN2;
        }

        public static Fldln2 fldln2() => default;

        [MethodImpl(Inline)]
        public static Fldln2 fldln2(AsmHexCode encoded) => new Fldln2(encoded);

        public struct Fldz : IAsmInstruction<Fldz>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fldz(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDZ;

            public static implicit operator AsmMnemonicCode(Fldz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldz src) => AsmMnemonics.FLDZ;
        }

        public static Fldz fldz() => default;

        [MethodImpl(Inline)]
        public static Fldz fldz(AsmHexCode encoded) => new Fldz(encoded);

        public struct Fldcw : IAsmInstruction<Fldcw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fldcw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDCW;

            public static implicit operator AsmMnemonicCode(Fldcw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldcw src) => AsmMnemonics.FLDCW;
        }

        public static Fldcw fldcw() => default;

        [MethodImpl(Inline)]
        public static Fldcw fldcw(AsmHexCode encoded) => new Fldcw(encoded);

        public struct Fldenv : IAsmInstruction<Fldenv>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fldenv(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDENV;

            public static implicit operator AsmMnemonicCode(Fldenv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldenv src) => AsmMnemonics.FLDENV;
        }

        public static Fldenv fldenv() => default;

        [MethodImpl(Inline)]
        public static Fldenv fldenv(AsmHexCode encoded) => new Fldenv(encoded);

        public struct Fmul : IAsmInstruction<Fmul>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fmul(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FMUL;

            public static implicit operator AsmMnemonicCode(Fmul src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fmul src) => AsmMnemonics.FMUL;
        }

        public static Fmul fmul() => default;

        [MethodImpl(Inline)]
        public static Fmul fmul(AsmHexCode encoded) => new Fmul(encoded);

        public struct Fmulp : IAsmInstruction<Fmulp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fmulp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FMULP;

            public static implicit operator AsmMnemonicCode(Fmulp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fmulp src) => AsmMnemonics.FMULP;
        }

        public static Fmulp fmulp() => default;

        [MethodImpl(Inline)]
        public static Fmulp fmulp(AsmHexCode encoded) => new Fmulp(encoded);

        public struct Fimul : IAsmInstruction<Fimul>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fimul(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIMUL;

            public static implicit operator AsmMnemonicCode(Fimul src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fimul src) => AsmMnemonics.FIMUL;
        }

        public static Fimul fimul() => default;

        [MethodImpl(Inline)]
        public static Fimul fimul(AsmHexCode encoded) => new Fimul(encoded);

        public struct Fnop : IAsmInstruction<Fnop>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fnop(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNOP;

            public static implicit operator AsmMnemonicCode(Fnop src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnop src) => AsmMnemonics.FNOP;
        }

        public static Fnop fnop() => default;

        [MethodImpl(Inline)]
        public static Fnop fnop(AsmHexCode encoded) => new Fnop(encoded);

        public struct Fpatan : IAsmInstruction<Fpatan>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fpatan(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FPATAN;

            public static implicit operator AsmMnemonicCode(Fpatan src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fpatan src) => AsmMnemonics.FPATAN;
        }

        public static Fpatan fpatan() => default;

        [MethodImpl(Inline)]
        public static Fpatan fpatan(AsmHexCode encoded) => new Fpatan(encoded);

        public struct Fprem : IAsmInstruction<Fprem>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fprem(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FPREM;

            public static implicit operator AsmMnemonicCode(Fprem src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fprem src) => AsmMnemonics.FPREM;
        }

        public static Fprem fprem() => default;

        [MethodImpl(Inline)]
        public static Fprem fprem(AsmHexCode encoded) => new Fprem(encoded);

        public struct Fprem1 : IAsmInstruction<Fprem1>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fprem1(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FPREM1;

            public static implicit operator AsmMnemonicCode(Fprem1 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fprem1 src) => AsmMnemonics.FPREM1;
        }

        public static Fprem1 fprem1() => default;

        [MethodImpl(Inline)]
        public static Fprem1 fprem1(AsmHexCode encoded) => new Fprem1(encoded);

        public struct Fptan : IAsmInstruction<Fptan>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fptan(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FPTAN;

            public static implicit operator AsmMnemonicCode(Fptan src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fptan src) => AsmMnemonics.FPTAN;
        }

        public static Fptan fptan() => default;

        [MethodImpl(Inline)]
        public static Fptan fptan(AsmHexCode encoded) => new Fptan(encoded);

        public struct Frndint : IAsmInstruction<Frndint>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Frndint(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FRNDINT;

            public static implicit operator AsmMnemonicCode(Frndint src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Frndint src) => AsmMnemonics.FRNDINT;
        }

        public static Frndint frndint() => default;

        [MethodImpl(Inline)]
        public static Frndint frndint(AsmHexCode encoded) => new Frndint(encoded);

        public struct Frstor : IAsmInstruction<Frstor>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Frstor(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FRSTOR;

            public static implicit operator AsmMnemonicCode(Frstor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Frstor src) => AsmMnemonics.FRSTOR;
        }

        public static Frstor frstor() => default;

        [MethodImpl(Inline)]
        public static Frstor frstor(AsmHexCode encoded) => new Frstor(encoded);

        public struct Fsave : IAsmInstruction<Fsave>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fsave(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSAVE;

            public static implicit operator AsmMnemonicCode(Fsave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsave src) => AsmMnemonics.FSAVE;
        }

        public static Fsave fsave() => default;

        [MethodImpl(Inline)]
        public static Fsave fsave(AsmHexCode encoded) => new Fsave(encoded);

        public struct Fnsave : IAsmInstruction<Fnsave>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fnsave(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSAVE;

            public static implicit operator AsmMnemonicCode(Fnsave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnsave src) => AsmMnemonics.FNSAVE;
        }

        public static Fnsave fnsave() => default;

        [MethodImpl(Inline)]
        public static Fnsave fnsave(AsmHexCode encoded) => new Fnsave(encoded);

        public struct Fscale : IAsmInstruction<Fscale>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fscale(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSCALE;

            public static implicit operator AsmMnemonicCode(Fscale src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fscale src) => AsmMnemonics.FSCALE;
        }

        public static Fscale fscale() => default;

        [MethodImpl(Inline)]
        public static Fscale fscale(AsmHexCode encoded) => new Fscale(encoded);

        public struct Fsin : IAsmInstruction<Fsin>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fsin(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSIN;

            public static implicit operator AsmMnemonicCode(Fsin src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsin src) => AsmMnemonics.FSIN;
        }

        public static Fsin fsin() => default;

        [MethodImpl(Inline)]
        public static Fsin fsin(AsmHexCode encoded) => new Fsin(encoded);

        public struct Fsincos : IAsmInstruction<Fsincos>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fsincos(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSINCOS;

            public static implicit operator AsmMnemonicCode(Fsincos src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsincos src) => AsmMnemonics.FSINCOS;
        }

        public static Fsincos fsincos() => default;

        [MethodImpl(Inline)]
        public static Fsincos fsincos(AsmHexCode encoded) => new Fsincos(encoded);

        public struct Fsqrt : IAsmInstruction<Fsqrt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fsqrt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSQRT;

            public static implicit operator AsmMnemonicCode(Fsqrt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsqrt src) => AsmMnemonics.FSQRT;
        }

        public static Fsqrt fsqrt() => default;

        [MethodImpl(Inline)]
        public static Fsqrt fsqrt(AsmHexCode encoded) => new Fsqrt(encoded);

        public struct Fst : IAsmInstruction<Fst>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fst(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FST;

            public static implicit operator AsmMnemonicCode(Fst src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fst src) => AsmMnemonics.FST;
        }

        public static Fst fst() => default;

        [MethodImpl(Inline)]
        public static Fst fst(AsmHexCode encoded) => new Fst(encoded);

        public struct Fstp : IAsmInstruction<Fstp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fstp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTP;

            public static implicit operator AsmMnemonicCode(Fstp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fstp src) => AsmMnemonics.FSTP;
        }

        public static Fstp fstp() => default;

        [MethodImpl(Inline)]
        public static Fstp fstp(AsmHexCode encoded) => new Fstp(encoded);

        public struct Fstcw : IAsmInstruction<Fstcw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fstcw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTCW;

            public static implicit operator AsmMnemonicCode(Fstcw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fstcw src) => AsmMnemonics.FSTCW;
        }

        public static Fstcw fstcw() => default;

        [MethodImpl(Inline)]
        public static Fstcw fstcw(AsmHexCode encoded) => new Fstcw(encoded);

        public struct Fnstcw : IAsmInstruction<Fnstcw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fnstcw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSTCW;

            public static implicit operator AsmMnemonicCode(Fnstcw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnstcw src) => AsmMnemonics.FNSTCW;
        }

        public static Fnstcw fnstcw() => default;

        [MethodImpl(Inline)]
        public static Fnstcw fnstcw(AsmHexCode encoded) => new Fnstcw(encoded);

        public struct Fstenv : IAsmInstruction<Fstenv>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fstenv(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTENV;

            public static implicit operator AsmMnemonicCode(Fstenv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fstenv src) => AsmMnemonics.FSTENV;
        }

        public static Fstenv fstenv() => default;

        [MethodImpl(Inline)]
        public static Fstenv fstenv(AsmHexCode encoded) => new Fstenv(encoded);

        public struct Fnstenv : IAsmInstruction<Fnstenv>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fnstenv(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSTENV;

            public static implicit operator AsmMnemonicCode(Fnstenv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnstenv src) => AsmMnemonics.FNSTENV;
        }

        public static Fnstenv fnstenv() => default;

        [MethodImpl(Inline)]
        public static Fnstenv fnstenv(AsmHexCode encoded) => new Fnstenv(encoded);

        public struct Fstsw : IAsmInstruction<Fstsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fstsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTSW;

            public static implicit operator AsmMnemonicCode(Fstsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fstsw src) => AsmMnemonics.FSTSW;
        }

        public static Fstsw fstsw() => default;

        [MethodImpl(Inline)]
        public static Fstsw fstsw(AsmHexCode encoded) => new Fstsw(encoded);

        public struct Fnstsw : IAsmInstruction<Fnstsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fnstsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSTSW;

            public static implicit operator AsmMnemonicCode(Fnstsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnstsw src) => AsmMnemonics.FNSTSW;
        }

        public static Fnstsw fnstsw() => default;

        [MethodImpl(Inline)]
        public static Fnstsw fnstsw(AsmHexCode encoded) => new Fnstsw(encoded);

        public struct Fsub : IAsmInstruction<Fsub>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fsub(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUB;

            public static implicit operator AsmMnemonicCode(Fsub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsub src) => AsmMnemonics.FSUB;
        }

        public static Fsub fsub() => default;

        [MethodImpl(Inline)]
        public static Fsub fsub(AsmHexCode encoded) => new Fsub(encoded);

        public struct Fsubp : IAsmInstruction<Fsubp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fsubp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUBP;

            public static implicit operator AsmMnemonicCode(Fsubp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsubp src) => AsmMnemonics.FSUBP;
        }

        public static Fsubp fsubp() => default;

        [MethodImpl(Inline)]
        public static Fsubp fsubp(AsmHexCode encoded) => new Fsubp(encoded);

        public struct Fisub : IAsmInstruction<Fisub>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fisub(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISUB;

            public static implicit operator AsmMnemonicCode(Fisub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fisub src) => AsmMnemonics.FISUB;
        }

        public static Fisub fisub() => default;

        [MethodImpl(Inline)]
        public static Fisub fisub(AsmHexCode encoded) => new Fisub(encoded);

        public struct Fsubr : IAsmInstruction<Fsubr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fsubr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUBR;

            public static implicit operator AsmMnemonicCode(Fsubr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsubr src) => AsmMnemonics.FSUBR;
        }

        public static Fsubr fsubr() => default;

        [MethodImpl(Inline)]
        public static Fsubr fsubr(AsmHexCode encoded) => new Fsubr(encoded);

        public struct Fsubrp : IAsmInstruction<Fsubrp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fsubrp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUBRP;

            public static implicit operator AsmMnemonicCode(Fsubrp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsubrp src) => AsmMnemonics.FSUBRP;
        }

        public static Fsubrp fsubrp() => default;

        [MethodImpl(Inline)]
        public static Fsubrp fsubrp(AsmHexCode encoded) => new Fsubrp(encoded);

        public struct Fisubr : IAsmInstruction<Fisubr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fisubr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISUBR;

            public static implicit operator AsmMnemonicCode(Fisubr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fisubr src) => AsmMnemonics.FISUBR;
        }

        public static Fisubr fisubr() => default;

        [MethodImpl(Inline)]
        public static Fisubr fisubr(AsmHexCode encoded) => new Fisubr(encoded);

        public struct Ftst : IAsmInstruction<Ftst>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ftst(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FTST;

            public static implicit operator AsmMnemonicCode(Ftst src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ftst src) => AsmMnemonics.FTST;
        }

        public static Ftst ftst() => default;

        [MethodImpl(Inline)]
        public static Ftst ftst(AsmHexCode encoded) => new Ftst(encoded);

        public struct Fucom : IAsmInstruction<Fucom>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fucom(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOM;

            public static implicit operator AsmMnemonicCode(Fucom src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucom src) => AsmMnemonics.FUCOM;
        }

        public static Fucom fucom() => default;

        [MethodImpl(Inline)]
        public static Fucom fucom(AsmHexCode encoded) => new Fucom(encoded);

        public struct Fucomp : IAsmInstruction<Fucomp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fucomp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMP;

            public static implicit operator AsmMnemonicCode(Fucomp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucomp src) => AsmMnemonics.FUCOMP;
        }

        public static Fucomp fucomp() => default;

        [MethodImpl(Inline)]
        public static Fucomp fucomp(AsmHexCode encoded) => new Fucomp(encoded);

        public struct Fucompp : IAsmInstruction<Fucompp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fucompp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMPP;

            public static implicit operator AsmMnemonicCode(Fucompp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucompp src) => AsmMnemonics.FUCOMPP;
        }

        public static Fucompp fucompp() => default;

        [MethodImpl(Inline)]
        public static Fucompp fucompp(AsmHexCode encoded) => new Fucompp(encoded);

        public struct Fxam : IAsmInstruction<Fxam>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fxam(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXAM;

            public static implicit operator AsmMnemonicCode(Fxam src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxam src) => AsmMnemonics.FXAM;
        }

        public static Fxam fxam() => default;

        [MethodImpl(Inline)]
        public static Fxam fxam(AsmHexCode encoded) => new Fxam(encoded);

        public struct Fxch : IAsmInstruction<Fxch>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fxch(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXCH;

            public static implicit operator AsmMnemonicCode(Fxch src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxch src) => AsmMnemonics.FXCH;
        }

        public static Fxch fxch() => default;

        [MethodImpl(Inline)]
        public static Fxch fxch(AsmHexCode encoded) => new Fxch(encoded);

        public struct Fxrstor : IAsmInstruction<Fxrstor>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fxrstor(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXRSTOR;

            public static implicit operator AsmMnemonicCode(Fxrstor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxrstor src) => AsmMnemonics.FXRSTOR;
        }

        public static Fxrstor fxrstor() => default;

        [MethodImpl(Inline)]
        public static Fxrstor fxrstor(AsmHexCode encoded) => new Fxrstor(encoded);

        public struct Fxrstor64 : IAsmInstruction<Fxrstor64>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fxrstor64(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXRSTOR64;

            public static implicit operator AsmMnemonicCode(Fxrstor64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxrstor64 src) => AsmMnemonics.FXRSTOR64;
        }

        public static Fxrstor64 fxrstor64() => default;

        [MethodImpl(Inline)]
        public static Fxrstor64 fxrstor64(AsmHexCode encoded) => new Fxrstor64(encoded);

        public struct Fxsave : IAsmInstruction<Fxsave>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fxsave(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXSAVE;

            public static implicit operator AsmMnemonicCode(Fxsave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxsave src) => AsmMnemonics.FXSAVE;
        }

        public static Fxsave fxsave() => default;

        [MethodImpl(Inline)]
        public static Fxsave fxsave(AsmHexCode encoded) => new Fxsave(encoded);

        public struct Fxsave64 : IAsmInstruction<Fxsave64>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fxsave64(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXSAVE64;

            public static implicit operator AsmMnemonicCode(Fxsave64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxsave64 src) => AsmMnemonics.FXSAVE64;
        }

        public static Fxsave64 fxsave64() => default;

        [MethodImpl(Inline)]
        public static Fxsave64 fxsave64(AsmHexCode encoded) => new Fxsave64(encoded);

        public struct Fxtract : IAsmInstruction<Fxtract>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fxtract(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXTRACT;

            public static implicit operator AsmMnemonicCode(Fxtract src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxtract src) => AsmMnemonics.FXTRACT;
        }

        public static Fxtract fxtract() => default;

        [MethodImpl(Inline)]
        public static Fxtract fxtract(AsmHexCode encoded) => new Fxtract(encoded);

        public struct Fyl2x : IAsmInstruction<Fyl2x>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fyl2x(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FYL2X;

            public static implicit operator AsmMnemonicCode(Fyl2x src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fyl2x src) => AsmMnemonics.FYL2X;
        }

        public static Fyl2x fyl2x() => default;

        [MethodImpl(Inline)]
        public static Fyl2x fyl2x(AsmHexCode encoded) => new Fyl2x(encoded);

        public struct Fyl2xp1 : IAsmInstruction<Fyl2xp1>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fyl2xp1(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FYL2XP1;

            public static implicit operator AsmMnemonicCode(Fyl2xp1 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fyl2xp1 src) => AsmMnemonics.FYL2XP1;
        }

        public static Fyl2xp1 fyl2xp1() => default;

        [MethodImpl(Inline)]
        public static Fyl2xp1 fyl2xp1(AsmHexCode encoded) => new Fyl2xp1(encoded);

        public struct Haddpd : IAsmInstruction<Haddpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Haddpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HADDPD;

            public static implicit operator AsmMnemonicCode(Haddpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Haddpd src) => AsmMnemonics.HADDPD;
        }

        public static Haddpd haddpd() => default;

        [MethodImpl(Inline)]
        public static Haddpd haddpd(AsmHexCode encoded) => new Haddpd(encoded);

        public struct Vhaddpd : IAsmInstruction<Vhaddpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vhaddpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHADDPD;

            public static implicit operator AsmMnemonicCode(Vhaddpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vhaddpd src) => AsmMnemonics.VHADDPD;
        }

        public static Vhaddpd vhaddpd() => default;

        [MethodImpl(Inline)]
        public static Vhaddpd vhaddpd(AsmHexCode encoded) => new Vhaddpd(encoded);

        public struct Haddps : IAsmInstruction<Haddps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Haddps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HADDPS;

            public static implicit operator AsmMnemonicCode(Haddps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Haddps src) => AsmMnemonics.HADDPS;
        }

        public static Haddps haddps() => default;

        [MethodImpl(Inline)]
        public static Haddps haddps(AsmHexCode encoded) => new Haddps(encoded);

        public struct Vhaddps : IAsmInstruction<Vhaddps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vhaddps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHADDPS;

            public static implicit operator AsmMnemonicCode(Vhaddps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vhaddps src) => AsmMnemonics.VHADDPS;
        }

        public static Vhaddps vhaddps() => default;

        [MethodImpl(Inline)]
        public static Vhaddps vhaddps(AsmHexCode encoded) => new Vhaddps(encoded);

        public struct Hlt : IAsmInstruction<Hlt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Hlt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HLT;

            public static implicit operator AsmMnemonicCode(Hlt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Hlt src) => AsmMnemonics.HLT;
        }

        public static Hlt hlt() => default;

        [MethodImpl(Inline)]
        public static Hlt hlt(AsmHexCode encoded) => new Hlt(encoded);

        public struct Hsubpd : IAsmInstruction<Hsubpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Hsubpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HSUBPD;

            public static implicit operator AsmMnemonicCode(Hsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Hsubpd src) => AsmMnemonics.HSUBPD;
        }

        public static Hsubpd hsubpd() => default;

        [MethodImpl(Inline)]
        public static Hsubpd hsubpd(AsmHexCode encoded) => new Hsubpd(encoded);

        public struct Vhsubpd : IAsmInstruction<Vhsubpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vhsubpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHSUBPD;

            public static implicit operator AsmMnemonicCode(Vhsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vhsubpd src) => AsmMnemonics.VHSUBPD;
        }

        public static Vhsubpd vhsubpd() => default;

        [MethodImpl(Inline)]
        public static Vhsubpd vhsubpd(AsmHexCode encoded) => new Vhsubpd(encoded);

        public struct Hsubps : IAsmInstruction<Hsubps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Hsubps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HSUBPS;

            public static implicit operator AsmMnemonicCode(Hsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Hsubps src) => AsmMnemonics.HSUBPS;
        }

        public static Hsubps hsubps() => default;

        [MethodImpl(Inline)]
        public static Hsubps hsubps(AsmHexCode encoded) => new Hsubps(encoded);

        public struct Vhsubps : IAsmInstruction<Vhsubps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vhsubps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHSUBPS;

            public static implicit operator AsmMnemonicCode(Vhsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vhsubps src) => AsmMnemonics.VHSUBPS;
        }

        public static Vhsubps vhsubps() => default;

        [MethodImpl(Inline)]
        public static Vhsubps vhsubps(AsmHexCode encoded) => new Vhsubps(encoded);

        public struct Idiv : IAsmInstruction<Idiv>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Idiv(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IDIV;

            public static implicit operator AsmMnemonicCode(Idiv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Idiv src) => AsmMnemonics.IDIV;
        }

        public static Idiv idiv() => default;

        [MethodImpl(Inline)]
        public static Idiv idiv(AsmHexCode encoded) => new Idiv(encoded);

        public struct Imul : IAsmInstruction<Imul>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Imul(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IMUL;

            public static implicit operator AsmMnemonicCode(Imul src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Imul src) => AsmMnemonics.IMUL;
        }

        public static Imul imul() => default;

        [MethodImpl(Inline)]
        public static Imul imul(AsmHexCode encoded) => new Imul(encoded);

        public struct In : IAsmInstruction<In>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public In(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IN;

            public static implicit operator AsmMnemonicCode(In src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(In src) => AsmMnemonics.IN;
        }

        public static In @in() => default;

        [MethodImpl(Inline)]
        public static In @in(AsmHexCode encoded) => new In(encoded);

        public struct Inc : IAsmInstruction<Inc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Inc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INC;

            public static implicit operator AsmMnemonicCode(Inc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Inc src) => AsmMnemonics.INC;
        }

        public static Inc inc() => default;

        [MethodImpl(Inline)]
        public static Inc inc(AsmHexCode encoded) => new Inc(encoded);

        public struct Ins : IAsmInstruction<Ins>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ins(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INS;

            public static implicit operator AsmMnemonicCode(Ins src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ins src) => AsmMnemonics.INS;
        }

        public static Ins ins() => default;

        [MethodImpl(Inline)]
        public static Ins ins(AsmHexCode encoded) => new Ins(encoded);

        public struct Insb : IAsmInstruction<Insb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Insb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INSB;

            public static implicit operator AsmMnemonicCode(Insb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Insb src) => AsmMnemonics.INSB;
        }

        public static Insb insb() => default;

        [MethodImpl(Inline)]
        public static Insb insb(AsmHexCode encoded) => new Insb(encoded);

        public struct Insw : IAsmInstruction<Insw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Insw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INSW;

            public static implicit operator AsmMnemonicCode(Insw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Insw src) => AsmMnemonics.INSW;
        }

        public static Insw insw() => default;

        [MethodImpl(Inline)]
        public static Insw insw(AsmHexCode encoded) => new Insw(encoded);

        public struct Insd : IAsmInstruction<Insd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Insd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INSD;

            public static implicit operator AsmMnemonicCode(Insd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Insd src) => AsmMnemonics.INSD;
        }

        public static Insd insd() => default;

        [MethodImpl(Inline)]
        public static Insd insd(AsmHexCode encoded) => new Insd(encoded);

        public struct Insertps : IAsmInstruction<Insertps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Insertps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INSERTPS;

            public static implicit operator AsmMnemonicCode(Insertps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Insertps src) => AsmMnemonics.INSERTPS;
        }

        public static Insertps insertps() => default;

        [MethodImpl(Inline)]
        public static Insertps insertps(AsmHexCode encoded) => new Insertps(encoded);

        public struct Vinsertps : IAsmInstruction<Vinsertps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vinsertps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VINSERTPS;

            public static implicit operator AsmMnemonicCode(Vinsertps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vinsertps src) => AsmMnemonics.VINSERTPS;
        }

        public static Vinsertps vinsertps() => default;

        [MethodImpl(Inline)]
        public static Vinsertps vinsertps(AsmHexCode encoded) => new Vinsertps(encoded);

        public struct Int : IAsmInstruction<Int>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Int(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INT;

            public static implicit operator AsmMnemonicCode(Int src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Int src) => AsmMnemonics.INT;
        }

        public static Int @int() => default;

        [MethodImpl(Inline)]
        public static Int @int(AsmHexCode encoded) => new Int(encoded);

        public struct Into : IAsmInstruction<Into>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Into(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INTO;

            public static implicit operator AsmMnemonicCode(Into src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Into src) => AsmMnemonics.INTO;
        }

        public static Into into() => default;

        [MethodImpl(Inline)]
        public static Into into(AsmHexCode encoded) => new Into(encoded);

        public struct Invd : IAsmInstruction<Invd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Invd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INVD;

            public static implicit operator AsmMnemonicCode(Invd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Invd src) => AsmMnemonics.INVD;
        }

        public static Invd invd() => default;

        [MethodImpl(Inline)]
        public static Invd invd(AsmHexCode encoded) => new Invd(encoded);

        public struct Invlpg : IAsmInstruction<Invlpg>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Invlpg(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INVLPG;

            public static implicit operator AsmMnemonicCode(Invlpg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Invlpg src) => AsmMnemonics.INVLPG;
        }

        public static Invlpg invlpg() => default;

        [MethodImpl(Inline)]
        public static Invlpg invlpg(AsmHexCode encoded) => new Invlpg(encoded);

        public struct Invpcid : IAsmInstruction<Invpcid>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Invpcid(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INVPCID;

            public static implicit operator AsmMnemonicCode(Invpcid src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Invpcid src) => AsmMnemonics.INVPCID;
        }

        public static Invpcid invpcid() => default;

        [MethodImpl(Inline)]
        public static Invpcid invpcid(AsmHexCode encoded) => new Invpcid(encoded);

        public struct Iret : IAsmInstruction<Iret>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Iret(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IRET;

            public static implicit operator AsmMnemonicCode(Iret src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Iret src) => AsmMnemonics.IRET;
        }

        public static Iret iret() => default;

        [MethodImpl(Inline)]
        public static Iret iret(AsmHexCode encoded) => new Iret(encoded);

        public struct Iretd : IAsmInstruction<Iretd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Iretd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IRETD;

            public static implicit operator AsmMnemonicCode(Iretd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Iretd src) => AsmMnemonics.IRETD;
        }

        public static Iretd iretd() => default;

        [MethodImpl(Inline)]
        public static Iretd iretd(AsmHexCode encoded) => new Iretd(encoded);

        public struct Iretq : IAsmInstruction<Iretq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Iretq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IRETQ;

            public static implicit operator AsmMnemonicCode(Iretq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Iretq src) => AsmMnemonics.IRETQ;
        }

        public static Iretq iretq() => default;

        [MethodImpl(Inline)]
        public static Iretq iretq(AsmHexCode encoded) => new Iretq(encoded);

        public struct Ja : IAsmInstruction<Ja>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ja(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JA;

            public static implicit operator AsmMnemonicCode(Ja src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ja src) => AsmMnemonics.JA;
        }

        public static Ja ja() => default;

        [MethodImpl(Inline)]
        public static Ja ja(AsmHexCode encoded) => new Ja(encoded);

        public struct Jae : IAsmInstruction<Jae>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jae(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JAE;

            public static implicit operator AsmMnemonicCode(Jae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jae src) => AsmMnemonics.JAE;
        }

        public static Jae jae() => default;

        [MethodImpl(Inline)]
        public static Jae jae(AsmHexCode encoded) => new Jae(encoded);

        public struct Jb : IAsmInstruction<Jb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JB;

            public static implicit operator AsmMnemonicCode(Jb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jb src) => AsmMnemonics.JB;
        }

        public static Jb jb() => default;

        [MethodImpl(Inline)]
        public static Jb jb(AsmHexCode encoded) => new Jb(encoded);

        public struct Jbe : IAsmInstruction<Jbe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jbe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JBE;

            public static implicit operator AsmMnemonicCode(Jbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jbe src) => AsmMnemonics.JBE;
        }

        public static Jbe jbe() => default;

        [MethodImpl(Inline)]
        public static Jbe jbe(AsmHexCode encoded) => new Jbe(encoded);

        public struct Jc : IAsmInstruction<Jc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JC;

            public static implicit operator AsmMnemonicCode(Jc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jc src) => AsmMnemonics.JC;
        }

        public static Jc jc() => default;

        [MethodImpl(Inline)]
        public static Jc jc(AsmHexCode encoded) => new Jc(encoded);

        public struct Jcxz : IAsmInstruction<Jcxz>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jcxz(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JCXZ;

            public static implicit operator AsmMnemonicCode(Jcxz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jcxz src) => AsmMnemonics.JCXZ;
        }

        public static Jcxz jcxz() => default;

        [MethodImpl(Inline)]
        public static Jcxz jcxz(AsmHexCode encoded) => new Jcxz(encoded);

        public struct Jecxz : IAsmInstruction<Jecxz>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jecxz(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JECXZ;

            public static implicit operator AsmMnemonicCode(Jecxz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jecxz src) => AsmMnemonics.JECXZ;
        }

        public static Jecxz jecxz() => default;

        [MethodImpl(Inline)]
        public static Jecxz jecxz(AsmHexCode encoded) => new Jecxz(encoded);

        public struct Jrcxz : IAsmInstruction<Jrcxz>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jrcxz(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JRCXZ;

            public static implicit operator AsmMnemonicCode(Jrcxz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jrcxz src) => AsmMnemonics.JRCXZ;
        }

        public static Jrcxz jrcxz() => default;

        [MethodImpl(Inline)]
        public static Jrcxz jrcxz(AsmHexCode encoded) => new Jrcxz(encoded);

        public struct Je : IAsmInstruction<Je>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Je(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JE;

            public static implicit operator AsmMnemonicCode(Je src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Je src) => AsmMnemonics.JE;
        }

        public static Je je() => default;

        [MethodImpl(Inline)]
        public static Je je(AsmHexCode encoded) => new Je(encoded);

        public struct Jg : IAsmInstruction<Jg>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jg(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JG;

            public static implicit operator AsmMnemonicCode(Jg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jg src) => AsmMnemonics.JG;
        }

        public static Jg jg() => default;

        [MethodImpl(Inline)]
        public static Jg jg(AsmHexCode encoded) => new Jg(encoded);

        public struct Jge : IAsmInstruction<Jge>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jge(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JGE;

            public static implicit operator AsmMnemonicCode(Jge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jge src) => AsmMnemonics.JGE;
        }

        public static Jge jge() => default;

        [MethodImpl(Inline)]
        public static Jge jge(AsmHexCode encoded) => new Jge(encoded);

        public struct Jl : IAsmInstruction<Jl>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jl(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JL;

            public static implicit operator AsmMnemonicCode(Jl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jl src) => AsmMnemonics.JL;
        }

        public static Jl jl() => default;

        [MethodImpl(Inline)]
        public static Jl jl(AsmHexCode encoded) => new Jl(encoded);

        public struct Jle : IAsmInstruction<Jle>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jle(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JLE;

            public static implicit operator AsmMnemonicCode(Jle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jle src) => AsmMnemonics.JLE;
        }

        public static Jle jle() => default;

        [MethodImpl(Inline)]
        public static Jle jle(AsmHexCode encoded) => new Jle(encoded);

        public struct Jna : IAsmInstruction<Jna>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jna(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNA;

            public static implicit operator AsmMnemonicCode(Jna src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jna src) => AsmMnemonics.JNA;
        }

        public static Jna jna() => default;

        [MethodImpl(Inline)]
        public static Jna jna(AsmHexCode encoded) => new Jna(encoded);

        public struct Jnae : IAsmInstruction<Jnae>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jnae(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNAE;

            public static implicit operator AsmMnemonicCode(Jnae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnae src) => AsmMnemonics.JNAE;
        }

        public static Jnae jnae() => default;

        [MethodImpl(Inline)]
        public static Jnae jnae(AsmHexCode encoded) => new Jnae(encoded);

        public struct Jnb : IAsmInstruction<Jnb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jnb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNB;

            public static implicit operator AsmMnemonicCode(Jnb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnb src) => AsmMnemonics.JNB;
        }

        public static Jnb jnb() => default;

        [MethodImpl(Inline)]
        public static Jnb jnb(AsmHexCode encoded) => new Jnb(encoded);

        public struct Jnbe : IAsmInstruction<Jnbe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jnbe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNBE;

            public static implicit operator AsmMnemonicCode(Jnbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnbe src) => AsmMnemonics.JNBE;
        }

        public static Jnbe jnbe() => default;

        [MethodImpl(Inline)]
        public static Jnbe jnbe(AsmHexCode encoded) => new Jnbe(encoded);

        public struct Jnc : IAsmInstruction<Jnc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jnc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNC;

            public static implicit operator AsmMnemonicCode(Jnc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnc src) => AsmMnemonics.JNC;
        }

        public static Jnc jnc() => default;

        [MethodImpl(Inline)]
        public static Jnc jnc(AsmHexCode encoded) => new Jnc(encoded);

        public struct Jne : IAsmInstruction<Jne>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jne(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNE;

            public static implicit operator AsmMnemonicCode(Jne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jne src) => AsmMnemonics.JNE;
        }

        public static Jne jne() => default;

        [MethodImpl(Inline)]
        public static Jne jne(AsmHexCode encoded) => new Jne(encoded);

        public struct Jng : IAsmInstruction<Jng>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jng(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNG;

            public static implicit operator AsmMnemonicCode(Jng src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jng src) => AsmMnemonics.JNG;
        }

        public static Jng jng() => default;

        [MethodImpl(Inline)]
        public static Jng jng(AsmHexCode encoded) => new Jng(encoded);

        public struct Jnge : IAsmInstruction<Jnge>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jnge(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNGE;

            public static implicit operator AsmMnemonicCode(Jnge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnge src) => AsmMnemonics.JNGE;
        }

        public static Jnge jnge() => default;

        [MethodImpl(Inline)]
        public static Jnge jnge(AsmHexCode encoded) => new Jnge(encoded);

        public struct Jnl : IAsmInstruction<Jnl>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jnl(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNL;

            public static implicit operator AsmMnemonicCode(Jnl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnl src) => AsmMnemonics.JNL;
        }

        public static Jnl jnl() => default;

        [MethodImpl(Inline)]
        public static Jnl jnl(AsmHexCode encoded) => new Jnl(encoded);

        public struct Jnle : IAsmInstruction<Jnle>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jnle(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNLE;

            public static implicit operator AsmMnemonicCode(Jnle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnle src) => AsmMnemonics.JNLE;
        }

        public static Jnle jnle() => default;

        [MethodImpl(Inline)]
        public static Jnle jnle(AsmHexCode encoded) => new Jnle(encoded);

        public struct Jno : IAsmInstruction<Jno>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jno(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNO;

            public static implicit operator AsmMnemonicCode(Jno src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jno src) => AsmMnemonics.JNO;
        }

        public static Jno jno() => default;

        [MethodImpl(Inline)]
        public static Jno jno(AsmHexCode encoded) => new Jno(encoded);

        public struct Jnp : IAsmInstruction<Jnp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jnp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNP;

            public static implicit operator AsmMnemonicCode(Jnp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnp src) => AsmMnemonics.JNP;
        }

        public static Jnp jnp() => default;

        [MethodImpl(Inline)]
        public static Jnp jnp(AsmHexCode encoded) => new Jnp(encoded);

        public struct Jns : IAsmInstruction<Jns>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jns(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNS;

            public static implicit operator AsmMnemonicCode(Jns src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jns src) => AsmMnemonics.JNS;
        }

        public static Jns jns() => default;

        [MethodImpl(Inline)]
        public static Jns jns(AsmHexCode encoded) => new Jns(encoded);

        public struct Jnz : IAsmInstruction<Jnz>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jnz(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNZ;

            public static implicit operator AsmMnemonicCode(Jnz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnz src) => AsmMnemonics.JNZ;
        }

        public static Jnz jnz() => default;

        [MethodImpl(Inline)]
        public static Jnz jnz(AsmHexCode encoded) => new Jnz(encoded);

        public struct Jo : IAsmInstruction<Jo>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jo(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JO;

            public static implicit operator AsmMnemonicCode(Jo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jo src) => AsmMnemonics.JO;
        }

        public static Jo jo() => default;

        [MethodImpl(Inline)]
        public static Jo jo(AsmHexCode encoded) => new Jo(encoded);

        public struct Jp : IAsmInstruction<Jp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JP;

            public static implicit operator AsmMnemonicCode(Jp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jp src) => AsmMnemonics.JP;
        }

        public static Jp jp() => default;

        [MethodImpl(Inline)]
        public static Jp jp(AsmHexCode encoded) => new Jp(encoded);

        public struct Jpe : IAsmInstruction<Jpe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jpe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JPE;

            public static implicit operator AsmMnemonicCode(Jpe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jpe src) => AsmMnemonics.JPE;
        }

        public static Jpe jpe() => default;

        [MethodImpl(Inline)]
        public static Jpe jpe(AsmHexCode encoded) => new Jpe(encoded);

        public struct Jpo : IAsmInstruction<Jpo>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jpo(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JPO;

            public static implicit operator AsmMnemonicCode(Jpo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jpo src) => AsmMnemonics.JPO;
        }

        public static Jpo jpo() => default;

        [MethodImpl(Inline)]
        public static Jpo jpo(AsmHexCode encoded) => new Jpo(encoded);

        public struct Js : IAsmInstruction<Js>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Js(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JS;

            public static implicit operator AsmMnemonicCode(Js src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Js src) => AsmMnemonics.JS;
        }

        public static Js js() => default;

        [MethodImpl(Inline)]
        public static Js js(AsmHexCode encoded) => new Js(encoded);

        public struct Jz : IAsmInstruction<Jz>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jz(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JZ;

            public static implicit operator AsmMnemonicCode(Jz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jz src) => AsmMnemonics.JZ;
        }

        public static Jz jz() => default;

        [MethodImpl(Inline)]
        public static Jz jz(AsmHexCode encoded) => new Jz(encoded);

        public struct Jmp : IAsmInstruction<Jmp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Jmp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JMP;

            public static implicit operator AsmMnemonicCode(Jmp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jmp src) => AsmMnemonics.JMP;
        }

        public static Jmp jmp() => default;

        [MethodImpl(Inline)]
        public static Jmp jmp(AsmHexCode encoded) => new Jmp(encoded);

        public struct Lahf : IAsmInstruction<Lahf>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lahf(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LAHF;

            public static implicit operator AsmMnemonicCode(Lahf src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lahf src) => AsmMnemonics.LAHF;
        }

        public static Lahf lahf() => default;

        [MethodImpl(Inline)]
        public static Lahf lahf(AsmHexCode encoded) => new Lahf(encoded);

        public struct Lar : IAsmInstruction<Lar>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lar(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LAR;

            public static implicit operator AsmMnemonicCode(Lar src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lar src) => AsmMnemonics.LAR;
        }

        public static Lar lar() => default;

        [MethodImpl(Inline)]
        public static Lar lar(AsmHexCode encoded) => new Lar(encoded);

        public struct Lddqu : IAsmInstruction<Lddqu>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lddqu(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LDDQU;

            public static implicit operator AsmMnemonicCode(Lddqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lddqu src) => AsmMnemonics.LDDQU;
        }

        public static Lddqu lddqu() => default;

        [MethodImpl(Inline)]
        public static Lddqu lddqu(AsmHexCode encoded) => new Lddqu(encoded);

        public struct Vlddqu : IAsmInstruction<Vlddqu>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vlddqu(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VLDDQU;

            public static implicit operator AsmMnemonicCode(Vlddqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vlddqu src) => AsmMnemonics.VLDDQU;
        }

        public static Vlddqu vlddqu() => default;

        [MethodImpl(Inline)]
        public static Vlddqu vlddqu(AsmHexCode encoded) => new Vlddqu(encoded);

        public struct Ldmxcsr : IAsmInstruction<Ldmxcsr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ldmxcsr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LDMXCSR;

            public static implicit operator AsmMnemonicCode(Ldmxcsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ldmxcsr src) => AsmMnemonics.LDMXCSR;
        }

        public static Ldmxcsr ldmxcsr() => default;

        [MethodImpl(Inline)]
        public static Ldmxcsr ldmxcsr(AsmHexCode encoded) => new Ldmxcsr(encoded);

        public struct Vldmxcsr : IAsmInstruction<Vldmxcsr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vldmxcsr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VLDMXCSR;

            public static implicit operator AsmMnemonicCode(Vldmxcsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vldmxcsr src) => AsmMnemonics.VLDMXCSR;
        }

        public static Vldmxcsr vldmxcsr() => default;

        [MethodImpl(Inline)]
        public static Vldmxcsr vldmxcsr(AsmHexCode encoded) => new Vldmxcsr(encoded);

        public struct Lds : IAsmInstruction<Lds>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lds(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LDS;

            public static implicit operator AsmMnemonicCode(Lds src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lds src) => AsmMnemonics.LDS;
        }

        public static Lds lds() => default;

        [MethodImpl(Inline)]
        public static Lds lds(AsmHexCode encoded) => new Lds(encoded);

        public struct Lss : IAsmInstruction<Lss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LSS;

            public static implicit operator AsmMnemonicCode(Lss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lss src) => AsmMnemonics.LSS;
        }

        public static Lss lss() => default;

        [MethodImpl(Inline)]
        public static Lss lss(AsmHexCode encoded) => new Lss(encoded);

        public struct Les : IAsmInstruction<Les>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Les(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LES;

            public static implicit operator AsmMnemonicCode(Les src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Les src) => AsmMnemonics.LES;
        }

        public static Les les() => default;

        [MethodImpl(Inline)]
        public static Les les(AsmHexCode encoded) => new Les(encoded);

        public struct Lfs : IAsmInstruction<Lfs>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lfs(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LFS;

            public static implicit operator AsmMnemonicCode(Lfs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lfs src) => AsmMnemonics.LFS;
        }

        public static Lfs lfs() => default;

        [MethodImpl(Inline)]
        public static Lfs lfs(AsmHexCode encoded) => new Lfs(encoded);

        public struct Lgs : IAsmInstruction<Lgs>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lgs(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LGS;

            public static implicit operator AsmMnemonicCode(Lgs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lgs src) => AsmMnemonics.LGS;
        }

        public static Lgs lgs() => default;

        [MethodImpl(Inline)]
        public static Lgs lgs(AsmHexCode encoded) => new Lgs(encoded);

        public struct Lea : IAsmInstruction<Lea>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lea(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LEA;

            public static implicit operator AsmMnemonicCode(Lea src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lea src) => AsmMnemonics.LEA;
        }

        public static Lea lea() => default;

        [MethodImpl(Inline)]
        public static Lea lea(AsmHexCode encoded) => new Lea(encoded);

        public struct Leave : IAsmInstruction<Leave>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Leave(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LEAVE;

            public static implicit operator AsmMnemonicCode(Leave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Leave src) => AsmMnemonics.LEAVE;
        }

        public static Leave leave() => default;

        [MethodImpl(Inline)]
        public static Leave leave(AsmHexCode encoded) => new Leave(encoded);

        public struct Lfence : IAsmInstruction<Lfence>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lfence(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LFENCE;

            public static implicit operator AsmMnemonicCode(Lfence src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lfence src) => AsmMnemonics.LFENCE;
        }

        public static Lfence lfence() => default;

        [MethodImpl(Inline)]
        public static Lfence lfence(AsmHexCode encoded) => new Lfence(encoded);

        public struct Lgdt : IAsmInstruction<Lgdt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lgdt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LGDT;

            public static implicit operator AsmMnemonicCode(Lgdt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lgdt src) => AsmMnemonics.LGDT;
        }

        public static Lgdt lgdt() => default;

        [MethodImpl(Inline)]
        public static Lgdt lgdt(AsmHexCode encoded) => new Lgdt(encoded);

        public struct Lidt : IAsmInstruction<Lidt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lidt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LIDT;

            public static implicit operator AsmMnemonicCode(Lidt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lidt src) => AsmMnemonics.LIDT;
        }

        public static Lidt lidt() => default;

        [MethodImpl(Inline)]
        public static Lidt lidt(AsmHexCode encoded) => new Lidt(encoded);

        public struct Lldt : IAsmInstruction<Lldt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lldt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LLDT;

            public static implicit operator AsmMnemonicCode(Lldt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lldt src) => AsmMnemonics.LLDT;
        }

        public static Lldt lldt() => default;

        [MethodImpl(Inline)]
        public static Lldt lldt(AsmHexCode encoded) => new Lldt(encoded);

        public struct Lmsw : IAsmInstruction<Lmsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lmsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LMSW;

            public static implicit operator AsmMnemonicCode(Lmsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lmsw src) => AsmMnemonics.LMSW;
        }

        public static Lmsw lmsw() => default;

        [MethodImpl(Inline)]
        public static Lmsw lmsw(AsmHexCode encoded) => new Lmsw(encoded);

        public struct Lock : IAsmInstruction<Lock>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lock(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOCK;

            public static implicit operator AsmMnemonicCode(Lock src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lock src) => AsmMnemonics.LOCK;
        }

        public static Lock @lock() => default;

        [MethodImpl(Inline)]
        public static Lock @lock(AsmHexCode encoded) => new Lock(encoded);

        public struct Lods : IAsmInstruction<Lods>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lods(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LODS;

            public static implicit operator AsmMnemonicCode(Lods src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lods src) => AsmMnemonics.LODS;
        }

        public static Lods lods() => default;

        [MethodImpl(Inline)]
        public static Lods lods(AsmHexCode encoded) => new Lods(encoded);

        public struct Lodsb : IAsmInstruction<Lodsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lodsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LODSB;

            public static implicit operator AsmMnemonicCode(Lodsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lodsb src) => AsmMnemonics.LODSB;
        }

        public static Lodsb lodsb() => default;

        [MethodImpl(Inline)]
        public static Lodsb lodsb(AsmHexCode encoded) => new Lodsb(encoded);

        public struct Lodsw : IAsmInstruction<Lodsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lodsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LODSW;

            public static implicit operator AsmMnemonicCode(Lodsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lodsw src) => AsmMnemonics.LODSW;
        }

        public static Lodsw lodsw() => default;

        [MethodImpl(Inline)]
        public static Lodsw lodsw(AsmHexCode encoded) => new Lodsw(encoded);

        public struct Lodsd : IAsmInstruction<Lodsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lodsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LODSD;

            public static implicit operator AsmMnemonicCode(Lodsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lodsd src) => AsmMnemonics.LODSD;
        }

        public static Lodsd lodsd() => default;

        [MethodImpl(Inline)]
        public static Lodsd lodsd(AsmHexCode encoded) => new Lodsd(encoded);

        public struct Lodsq : IAsmInstruction<Lodsq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lodsq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LODSQ;

            public static implicit operator AsmMnemonicCode(Lodsq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lodsq src) => AsmMnemonics.LODSQ;
        }

        public static Lodsq lodsq() => default;

        [MethodImpl(Inline)]
        public static Lodsq lodsq(AsmHexCode encoded) => new Lodsq(encoded);

        public struct Loop : IAsmInstruction<Loop>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Loop(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOOP;

            public static implicit operator AsmMnemonicCode(Loop src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Loop src) => AsmMnemonics.LOOP;
        }

        public static Loop loop() => default;

        [MethodImpl(Inline)]
        public static Loop loop(AsmHexCode encoded) => new Loop(encoded);

        public struct Loope : IAsmInstruction<Loope>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Loope(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOOPE;

            public static implicit operator AsmMnemonicCode(Loope src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Loope src) => AsmMnemonics.LOOPE;
        }

        public static Loope loope() => default;

        [MethodImpl(Inline)]
        public static Loope loope(AsmHexCode encoded) => new Loope(encoded);

        public struct Loopne : IAsmInstruction<Loopne>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Loopne(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOOPNE;

            public static implicit operator AsmMnemonicCode(Loopne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Loopne src) => AsmMnemonics.LOOPNE;
        }

        public static Loopne loopne() => default;

        [MethodImpl(Inline)]
        public static Loopne loopne(AsmHexCode encoded) => new Loopne(encoded);

        public struct Lsl : IAsmInstruction<Lsl>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lsl(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LSL;

            public static implicit operator AsmMnemonicCode(Lsl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lsl src) => AsmMnemonics.LSL;
        }

        public static Lsl lsl() => default;

        [MethodImpl(Inline)]
        public static Lsl lsl(AsmHexCode encoded) => new Lsl(encoded);

        public struct Ltr : IAsmInstruction<Ltr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ltr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LTR;

            public static implicit operator AsmMnemonicCode(Ltr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ltr src) => AsmMnemonics.LTR;
        }

        public static Ltr ltr() => default;

        [MethodImpl(Inline)]
        public static Ltr ltr(AsmHexCode encoded) => new Ltr(encoded);

        public struct Lzcnt : IAsmInstruction<Lzcnt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Lzcnt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LZCNT;

            public static implicit operator AsmMnemonicCode(Lzcnt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lzcnt src) => AsmMnemonics.LZCNT;
        }

        public static Lzcnt lzcnt() => default;

        [MethodImpl(Inline)]
        public static Lzcnt lzcnt(AsmHexCode encoded) => new Lzcnt(encoded);

        public struct Maskmovdqu : IAsmInstruction<Maskmovdqu>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Maskmovdqu(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MASKMOVDQU;

            public static implicit operator AsmMnemonicCode(Maskmovdqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maskmovdqu src) => AsmMnemonics.MASKMOVDQU;
        }

        public static Maskmovdqu maskmovdqu() => default;

        [MethodImpl(Inline)]
        public static Maskmovdqu maskmovdqu(AsmHexCode encoded) => new Maskmovdqu(encoded);

        public struct Vmaskmovdqu : IAsmInstruction<Vmaskmovdqu>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmaskmovdqu(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMASKMOVDQU;

            public static implicit operator AsmMnemonicCode(Vmaskmovdqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaskmovdqu src) => AsmMnemonics.VMASKMOVDQU;
        }

        public static Vmaskmovdqu vmaskmovdqu() => default;

        [MethodImpl(Inline)]
        public static Vmaskmovdqu vmaskmovdqu(AsmHexCode encoded) => new Vmaskmovdqu(encoded);

        public struct Maskmovq : IAsmInstruction<Maskmovq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Maskmovq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MASKMOVQ;

            public static implicit operator AsmMnemonicCode(Maskmovq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maskmovq src) => AsmMnemonics.MASKMOVQ;
        }

        public static Maskmovq maskmovq() => default;

        [MethodImpl(Inline)]
        public static Maskmovq maskmovq(AsmHexCode encoded) => new Maskmovq(encoded);

        public struct Maxpd : IAsmInstruction<Maxpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Maxpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXPD;

            public static implicit operator AsmMnemonicCode(Maxpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maxpd src) => AsmMnemonics.MAXPD;
        }

        public static Maxpd maxpd() => default;

        [MethodImpl(Inline)]
        public static Maxpd maxpd(AsmHexCode encoded) => new Maxpd(encoded);

        public struct Vmaxpd : IAsmInstruction<Vmaxpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmaxpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXPD;

            public static implicit operator AsmMnemonicCode(Vmaxpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaxpd src) => AsmMnemonics.VMAXPD;
        }

        public static Vmaxpd vmaxpd() => default;

        [MethodImpl(Inline)]
        public static Vmaxpd vmaxpd(AsmHexCode encoded) => new Vmaxpd(encoded);

        public struct Maxps : IAsmInstruction<Maxps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Maxps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXPS;

            public static implicit operator AsmMnemonicCode(Maxps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maxps src) => AsmMnemonics.MAXPS;
        }

        public static Maxps maxps() => default;

        [MethodImpl(Inline)]
        public static Maxps maxps(AsmHexCode encoded) => new Maxps(encoded);

        public struct Vmaxps : IAsmInstruction<Vmaxps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmaxps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXPS;

            public static implicit operator AsmMnemonicCode(Vmaxps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaxps src) => AsmMnemonics.VMAXPS;
        }

        public static Vmaxps vmaxps() => default;

        [MethodImpl(Inline)]
        public static Vmaxps vmaxps(AsmHexCode encoded) => new Vmaxps(encoded);

        public struct Maxsd : IAsmInstruction<Maxsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Maxsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXSD;

            public static implicit operator AsmMnemonicCode(Maxsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maxsd src) => AsmMnemonics.MAXSD;
        }

        public static Maxsd maxsd() => default;

        [MethodImpl(Inline)]
        public static Maxsd maxsd(AsmHexCode encoded) => new Maxsd(encoded);

        public struct Vmaxsd : IAsmInstruction<Vmaxsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmaxsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXSD;

            public static implicit operator AsmMnemonicCode(Vmaxsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaxsd src) => AsmMnemonics.VMAXSD;
        }

        public static Vmaxsd vmaxsd() => default;

        [MethodImpl(Inline)]
        public static Vmaxsd vmaxsd(AsmHexCode encoded) => new Vmaxsd(encoded);

        public struct Maxss : IAsmInstruction<Maxss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Maxss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXSS;

            public static implicit operator AsmMnemonicCode(Maxss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maxss src) => AsmMnemonics.MAXSS;
        }

        public static Maxss maxss() => default;

        [MethodImpl(Inline)]
        public static Maxss maxss(AsmHexCode encoded) => new Maxss(encoded);

        public struct Vmaxss : IAsmInstruction<Vmaxss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmaxss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXSS;

            public static implicit operator AsmMnemonicCode(Vmaxss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaxss src) => AsmMnemonics.VMAXSS;
        }

        public static Vmaxss vmaxss() => default;

        [MethodImpl(Inline)]
        public static Vmaxss vmaxss(AsmHexCode encoded) => new Vmaxss(encoded);

        public struct Mfence : IAsmInstruction<Mfence>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Mfence(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MFENCE;

            public static implicit operator AsmMnemonicCode(Mfence src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mfence src) => AsmMnemonics.MFENCE;
        }

        public static Mfence mfence() => default;

        [MethodImpl(Inline)]
        public static Mfence mfence(AsmHexCode encoded) => new Mfence(encoded);

        public struct Minpd : IAsmInstruction<Minpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Minpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINPD;

            public static implicit operator AsmMnemonicCode(Minpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Minpd src) => AsmMnemonics.MINPD;
        }

        public static Minpd minpd() => default;

        [MethodImpl(Inline)]
        public static Minpd minpd(AsmHexCode encoded) => new Minpd(encoded);

        public struct Vminpd : IAsmInstruction<Vminpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vminpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINPD;

            public static implicit operator AsmMnemonicCode(Vminpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vminpd src) => AsmMnemonics.VMINPD;
        }

        public static Vminpd vminpd() => default;

        [MethodImpl(Inline)]
        public static Vminpd vminpd(AsmHexCode encoded) => new Vminpd(encoded);

        public struct Minps : IAsmInstruction<Minps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Minps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINPS;

            public static implicit operator AsmMnemonicCode(Minps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Minps src) => AsmMnemonics.MINPS;
        }

        public static Minps minps() => default;

        [MethodImpl(Inline)]
        public static Minps minps(AsmHexCode encoded) => new Minps(encoded);

        public struct Vminps : IAsmInstruction<Vminps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vminps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINPS;

            public static implicit operator AsmMnemonicCode(Vminps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vminps src) => AsmMnemonics.VMINPS;
        }

        public static Vminps vminps() => default;

        [MethodImpl(Inline)]
        public static Vminps vminps(AsmHexCode encoded) => new Vminps(encoded);

        public struct Minsd : IAsmInstruction<Minsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Minsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINSD;

            public static implicit operator AsmMnemonicCode(Minsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Minsd src) => AsmMnemonics.MINSD;
        }

        public static Minsd minsd() => default;

        [MethodImpl(Inline)]
        public static Minsd minsd(AsmHexCode encoded) => new Minsd(encoded);

        public struct Vminsd : IAsmInstruction<Vminsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vminsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINSD;

            public static implicit operator AsmMnemonicCode(Vminsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vminsd src) => AsmMnemonics.VMINSD;
        }

        public static Vminsd vminsd() => default;

        [MethodImpl(Inline)]
        public static Vminsd vminsd(AsmHexCode encoded) => new Vminsd(encoded);

        public struct Minss : IAsmInstruction<Minss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Minss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINSS;

            public static implicit operator AsmMnemonicCode(Minss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Minss src) => AsmMnemonics.MINSS;
        }

        public static Minss minss() => default;

        [MethodImpl(Inline)]
        public static Minss minss(AsmHexCode encoded) => new Minss(encoded);

        public struct Vminss : IAsmInstruction<Vminss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vminss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINSS;

            public static implicit operator AsmMnemonicCode(Vminss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vminss src) => AsmMnemonics.VMINSS;
        }

        public static Vminss vminss() => default;

        [MethodImpl(Inline)]
        public static Vminss vminss(AsmHexCode encoded) => new Vminss(encoded);

        public struct Monitor : IAsmInstruction<Monitor>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Monitor(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MONITOR;

            public static implicit operator AsmMnemonicCode(Monitor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Monitor src) => AsmMnemonics.MONITOR;
        }

        public static Monitor monitor() => default;

        [MethodImpl(Inline)]
        public static Monitor monitor(AsmHexCode encoded) => new Monitor(encoded);

        public struct Mov : IAsmInstruction<Mov>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Mov(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOV;

            public static implicit operator AsmMnemonicCode(Mov src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mov src) => AsmMnemonics.MOV;
        }

        public static Mov mov() => default;

        [MethodImpl(Inline)]
        public static Mov mov(AsmHexCode encoded) => new Mov(encoded);

        public struct Movapd : IAsmInstruction<Movapd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movapd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVAPD;

            public static implicit operator AsmMnemonicCode(Movapd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movapd src) => AsmMnemonics.MOVAPD;
        }

        public static Movapd movapd() => default;

        [MethodImpl(Inline)]
        public static Movapd movapd(AsmHexCode encoded) => new Movapd(encoded);

        public struct Vmovapd : IAsmInstruction<Vmovapd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovapd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVAPD;

            public static implicit operator AsmMnemonicCode(Vmovapd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovapd src) => AsmMnemonics.VMOVAPD;
        }

        public static Vmovapd vmovapd() => default;

        [MethodImpl(Inline)]
        public static Vmovapd vmovapd(AsmHexCode encoded) => new Vmovapd(encoded);

        public struct Movaps : IAsmInstruction<Movaps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movaps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVAPS;

            public static implicit operator AsmMnemonicCode(Movaps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movaps src) => AsmMnemonics.MOVAPS;
        }

        public static Movaps movaps() => default;

        [MethodImpl(Inline)]
        public static Movaps movaps(AsmHexCode encoded) => new Movaps(encoded);

        public struct Vmovaps : IAsmInstruction<Vmovaps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovaps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVAPS;

            public static implicit operator AsmMnemonicCode(Vmovaps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovaps src) => AsmMnemonics.VMOVAPS;
        }

        public static Vmovaps vmovaps() => default;

        [MethodImpl(Inline)]
        public static Vmovaps vmovaps(AsmHexCode encoded) => new Vmovaps(encoded);

        public struct Movbe : IAsmInstruction<Movbe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movbe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVBE;

            public static implicit operator AsmMnemonicCode(Movbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movbe src) => AsmMnemonics.MOVBE;
        }

        public static Movbe movbe() => default;

        [MethodImpl(Inline)]
        public static Movbe movbe(AsmHexCode encoded) => new Movbe(encoded);

        public struct Movd : IAsmInstruction<Movd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVD;

            public static implicit operator AsmMnemonicCode(Movd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movd src) => AsmMnemonics.MOVD;
        }

        public static Movd movd() => default;

        [MethodImpl(Inline)]
        public static Movd movd(AsmHexCode encoded) => new Movd(encoded);

        public struct Movq : IAsmInstruction<Movq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVQ;

            public static implicit operator AsmMnemonicCode(Movq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movq src) => AsmMnemonics.MOVQ;
        }

        public static Movq movq() => default;

        [MethodImpl(Inline)]
        public static Movq movq(AsmHexCode encoded) => new Movq(encoded);

        public struct Vmovd : IAsmInstruction<Vmovd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVD;

            public static implicit operator AsmMnemonicCode(Vmovd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovd src) => AsmMnemonics.VMOVD;
        }

        public static Vmovd vmovd() => default;

        [MethodImpl(Inline)]
        public static Vmovd vmovd(AsmHexCode encoded) => new Vmovd(encoded);

        public struct Vmovq : IAsmInstruction<Vmovq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVQ;

            public static implicit operator AsmMnemonicCode(Vmovq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovq src) => AsmMnemonics.VMOVQ;
        }

        public static Vmovq vmovq() => default;

        [MethodImpl(Inline)]
        public static Vmovq vmovq(AsmHexCode encoded) => new Vmovq(encoded);

        public struct Movddup : IAsmInstruction<Movddup>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movddup(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDDUP;

            public static implicit operator AsmMnemonicCode(Movddup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movddup src) => AsmMnemonics.MOVDDUP;
        }

        public static Movddup movddup() => default;

        [MethodImpl(Inline)]
        public static Movddup movddup(AsmHexCode encoded) => new Movddup(encoded);

        public struct Vmovddup : IAsmInstruction<Vmovddup>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovddup(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVDDUP;

            public static implicit operator AsmMnemonicCode(Vmovddup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovddup src) => AsmMnemonics.VMOVDDUP;
        }

        public static Vmovddup vmovddup() => default;

        [MethodImpl(Inline)]
        public static Vmovddup vmovddup(AsmHexCode encoded) => new Vmovddup(encoded);

        public struct Movdqa : IAsmInstruction<Movdqa>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movdqa(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDQA;

            public static implicit operator AsmMnemonicCode(Movdqa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movdqa src) => AsmMnemonics.MOVDQA;
        }

        public static Movdqa movdqa() => default;

        [MethodImpl(Inline)]
        public static Movdqa movdqa(AsmHexCode encoded) => new Movdqa(encoded);

        public struct Vmovdqa : IAsmInstruction<Vmovdqa>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovdqa(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVDQA;

            public static implicit operator AsmMnemonicCode(Vmovdqa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovdqa src) => AsmMnemonics.VMOVDQA;
        }

        public static Vmovdqa vmovdqa() => default;

        [MethodImpl(Inline)]
        public static Vmovdqa vmovdqa(AsmHexCode encoded) => new Vmovdqa(encoded);

        public struct Movdqu : IAsmInstruction<Movdqu>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movdqu(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDQU;

            public static implicit operator AsmMnemonicCode(Movdqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movdqu src) => AsmMnemonics.MOVDQU;
        }

        public static Movdqu movdqu() => default;

        [MethodImpl(Inline)]
        public static Movdqu movdqu(AsmHexCode encoded) => new Movdqu(encoded);

        public struct Vmovdqu : IAsmInstruction<Vmovdqu>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovdqu(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVDQU;

            public static implicit operator AsmMnemonicCode(Vmovdqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovdqu src) => AsmMnemonics.VMOVDQU;
        }

        public static Vmovdqu vmovdqu() => default;

        [MethodImpl(Inline)]
        public static Vmovdqu vmovdqu(AsmHexCode encoded) => new Vmovdqu(encoded);

        public struct Movdq2q : IAsmInstruction<Movdq2q>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movdq2q(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDQ2Q;

            public static implicit operator AsmMnemonicCode(Movdq2q src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movdq2q src) => AsmMnemonics.MOVDQ2Q;
        }

        public static Movdq2q movdq2q() => default;

        [MethodImpl(Inline)]
        public static Movdq2q movdq2q(AsmHexCode encoded) => new Movdq2q(encoded);

        public struct Movhlps : IAsmInstruction<Movhlps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movhlps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVHLPS;

            public static implicit operator AsmMnemonicCode(Movhlps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movhlps src) => AsmMnemonics.MOVHLPS;
        }

        public static Movhlps movhlps() => default;

        [MethodImpl(Inline)]
        public static Movhlps movhlps(AsmHexCode encoded) => new Movhlps(encoded);

        public struct Vmovhlps : IAsmInstruction<Vmovhlps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovhlps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVHLPS;

            public static implicit operator AsmMnemonicCode(Vmovhlps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovhlps src) => AsmMnemonics.VMOVHLPS;
        }

        public static Vmovhlps vmovhlps() => default;

        [MethodImpl(Inline)]
        public static Vmovhlps vmovhlps(AsmHexCode encoded) => new Vmovhlps(encoded);

        public struct Movhpd : IAsmInstruction<Movhpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movhpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVHPD;

            public static implicit operator AsmMnemonicCode(Movhpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movhpd src) => AsmMnemonics.MOVHPD;
        }

        public static Movhpd movhpd() => default;

        [MethodImpl(Inline)]
        public static Movhpd movhpd(AsmHexCode encoded) => new Movhpd(encoded);

        public struct Vmovhpd : IAsmInstruction<Vmovhpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovhpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVHPD;

            public static implicit operator AsmMnemonicCode(Vmovhpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovhpd src) => AsmMnemonics.VMOVHPD;
        }

        public static Vmovhpd vmovhpd() => default;

        [MethodImpl(Inline)]
        public static Vmovhpd vmovhpd(AsmHexCode encoded) => new Vmovhpd(encoded);

        public struct Movhps : IAsmInstruction<Movhps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movhps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVHPS;

            public static implicit operator AsmMnemonicCode(Movhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movhps src) => AsmMnemonics.MOVHPS;
        }

        public static Movhps movhps() => default;

        [MethodImpl(Inline)]
        public static Movhps movhps(AsmHexCode encoded) => new Movhps(encoded);

        public struct Vmovhps : IAsmInstruction<Vmovhps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovhps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVHPS;

            public static implicit operator AsmMnemonicCode(Vmovhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovhps src) => AsmMnemonics.VMOVHPS;
        }

        public static Vmovhps vmovhps() => default;

        [MethodImpl(Inline)]
        public static Vmovhps vmovhps(AsmHexCode encoded) => new Vmovhps(encoded);

        public struct Movlhps : IAsmInstruction<Movlhps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movlhps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVLHPS;

            public static implicit operator AsmMnemonicCode(Movlhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movlhps src) => AsmMnemonics.MOVLHPS;
        }

        public static Movlhps movlhps() => default;

        [MethodImpl(Inline)]
        public static Movlhps movlhps(AsmHexCode encoded) => new Movlhps(encoded);

        public struct Vmovlhps : IAsmInstruction<Vmovlhps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovlhps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVLHPS;

            public static implicit operator AsmMnemonicCode(Vmovlhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovlhps src) => AsmMnemonics.VMOVLHPS;
        }

        public static Vmovlhps vmovlhps() => default;

        [MethodImpl(Inline)]
        public static Vmovlhps vmovlhps(AsmHexCode encoded) => new Vmovlhps(encoded);

        public struct Movlpd : IAsmInstruction<Movlpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movlpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVLPD;

            public static implicit operator AsmMnemonicCode(Movlpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movlpd src) => AsmMnemonics.MOVLPD;
        }

        public static Movlpd movlpd() => default;

        [MethodImpl(Inline)]
        public static Movlpd movlpd(AsmHexCode encoded) => new Movlpd(encoded);

        public struct Vmovlpd : IAsmInstruction<Vmovlpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovlpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVLPD;

            public static implicit operator AsmMnemonicCode(Vmovlpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovlpd src) => AsmMnemonics.VMOVLPD;
        }

        public static Vmovlpd vmovlpd() => default;

        [MethodImpl(Inline)]
        public static Vmovlpd vmovlpd(AsmHexCode encoded) => new Vmovlpd(encoded);

        public struct Movlps : IAsmInstruction<Movlps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movlps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVLPS;

            public static implicit operator AsmMnemonicCode(Movlps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movlps src) => AsmMnemonics.MOVLPS;
        }

        public static Movlps movlps() => default;

        [MethodImpl(Inline)]
        public static Movlps movlps(AsmHexCode encoded) => new Movlps(encoded);

        public struct Vmovlps : IAsmInstruction<Vmovlps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovlps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVLPS;

            public static implicit operator AsmMnemonicCode(Vmovlps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovlps src) => AsmMnemonics.VMOVLPS;
        }

        public static Vmovlps vmovlps() => default;

        [MethodImpl(Inline)]
        public static Vmovlps vmovlps(AsmHexCode encoded) => new Vmovlps(encoded);

        public struct Movmskpd : IAsmInstruction<Movmskpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movmskpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVMSKPD;

            public static implicit operator AsmMnemonicCode(Movmskpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movmskpd src) => AsmMnemonics.MOVMSKPD;
        }

        public static Movmskpd movmskpd() => default;

        [MethodImpl(Inline)]
        public static Movmskpd movmskpd(AsmHexCode encoded) => new Movmskpd(encoded);

        public struct Vmovmskpd : IAsmInstruction<Vmovmskpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovmskpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVMSKPD;

            public static implicit operator AsmMnemonicCode(Vmovmskpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovmskpd src) => AsmMnemonics.VMOVMSKPD;
        }

        public static Vmovmskpd vmovmskpd() => default;

        [MethodImpl(Inline)]
        public static Vmovmskpd vmovmskpd(AsmHexCode encoded) => new Vmovmskpd(encoded);

        public struct Movmskps : IAsmInstruction<Movmskps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movmskps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVMSKPS;

            public static implicit operator AsmMnemonicCode(Movmskps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movmskps src) => AsmMnemonics.MOVMSKPS;
        }

        public static Movmskps movmskps() => default;

        [MethodImpl(Inline)]
        public static Movmskps movmskps(AsmHexCode encoded) => new Movmskps(encoded);

        public struct Vmovmskps : IAsmInstruction<Vmovmskps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovmskps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVMSKPS;

            public static implicit operator AsmMnemonicCode(Vmovmskps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovmskps src) => AsmMnemonics.VMOVMSKPS;
        }

        public static Vmovmskps vmovmskps() => default;

        [MethodImpl(Inline)]
        public static Vmovmskps vmovmskps(AsmHexCode encoded) => new Vmovmskps(encoded);

        public struct Movntdqa : IAsmInstruction<Movntdqa>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movntdqa(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTDQA;

            public static implicit operator AsmMnemonicCode(Movntdqa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntdqa src) => AsmMnemonics.MOVNTDQA;
        }

        public static Movntdqa movntdqa() => default;

        [MethodImpl(Inline)]
        public static Movntdqa movntdqa(AsmHexCode encoded) => new Movntdqa(encoded);

        public struct Vmovntdqa : IAsmInstruction<Vmovntdqa>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovntdqa(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTDQA;

            public static implicit operator AsmMnemonicCode(Vmovntdqa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovntdqa src) => AsmMnemonics.VMOVNTDQA;
        }

        public static Vmovntdqa vmovntdqa() => default;

        [MethodImpl(Inline)]
        public static Vmovntdqa vmovntdqa(AsmHexCode encoded) => new Vmovntdqa(encoded);

        public struct Movntdq : IAsmInstruction<Movntdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movntdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTDQ;

            public static implicit operator AsmMnemonicCode(Movntdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntdq src) => AsmMnemonics.MOVNTDQ;
        }

        public static Movntdq movntdq() => default;

        [MethodImpl(Inline)]
        public static Movntdq movntdq(AsmHexCode encoded) => new Movntdq(encoded);

        public struct Vmovntdq : IAsmInstruction<Vmovntdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovntdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTDQ;

            public static implicit operator AsmMnemonicCode(Vmovntdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovntdq src) => AsmMnemonics.VMOVNTDQ;
        }

        public static Vmovntdq vmovntdq() => default;

        [MethodImpl(Inline)]
        public static Vmovntdq vmovntdq(AsmHexCode encoded) => new Vmovntdq(encoded);

        public struct Movnti : IAsmInstruction<Movnti>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movnti(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTI;

            public static implicit operator AsmMnemonicCode(Movnti src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movnti src) => AsmMnemonics.MOVNTI;
        }

        public static Movnti movnti() => default;

        [MethodImpl(Inline)]
        public static Movnti movnti(AsmHexCode encoded) => new Movnti(encoded);

        public struct Movntpd : IAsmInstruction<Movntpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movntpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTPD;

            public static implicit operator AsmMnemonicCode(Movntpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntpd src) => AsmMnemonics.MOVNTPD;
        }

        public static Movntpd movntpd() => default;

        [MethodImpl(Inline)]
        public static Movntpd movntpd(AsmHexCode encoded) => new Movntpd(encoded);

        public struct Vmovntpd : IAsmInstruction<Vmovntpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovntpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTPD;

            public static implicit operator AsmMnemonicCode(Vmovntpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovntpd src) => AsmMnemonics.VMOVNTPD;
        }

        public static Vmovntpd vmovntpd() => default;

        [MethodImpl(Inline)]
        public static Vmovntpd vmovntpd(AsmHexCode encoded) => new Vmovntpd(encoded);

        public struct Movntps : IAsmInstruction<Movntps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movntps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTPS;

            public static implicit operator AsmMnemonicCode(Movntps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntps src) => AsmMnemonics.MOVNTPS;
        }

        public static Movntps movntps() => default;

        [MethodImpl(Inline)]
        public static Movntps movntps(AsmHexCode encoded) => new Movntps(encoded);

        public struct Vmovntps : IAsmInstruction<Vmovntps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovntps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTPS;

            public static implicit operator AsmMnemonicCode(Vmovntps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovntps src) => AsmMnemonics.VMOVNTPS;
        }

        public static Vmovntps vmovntps() => default;

        [MethodImpl(Inline)]
        public static Vmovntps vmovntps(AsmHexCode encoded) => new Vmovntps(encoded);

        public struct Movntq : IAsmInstruction<Movntq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movntq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTQ;

            public static implicit operator AsmMnemonicCode(Movntq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntq src) => AsmMnemonics.MOVNTQ;
        }

        public static Movntq movntq() => default;

        [MethodImpl(Inline)]
        public static Movntq movntq(AsmHexCode encoded) => new Movntq(encoded);

        public struct Movq2dq : IAsmInstruction<Movq2dq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movq2dq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVQ2DQ;

            public static implicit operator AsmMnemonicCode(Movq2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movq2dq src) => AsmMnemonics.MOVQ2DQ;
        }

        public static Movq2dq movq2dq() => default;

        [MethodImpl(Inline)]
        public static Movq2dq movq2dq(AsmHexCode encoded) => new Movq2dq(encoded);

        public struct Movs : IAsmInstruction<Movs>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movs(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVS;

            public static implicit operator AsmMnemonicCode(Movs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movs src) => AsmMnemonics.MOVS;
        }

        public static Movs movs() => default;

        [MethodImpl(Inline)]
        public static Movs movs(AsmHexCode encoded) => new Movs(encoded);

        public struct Movsb : IAsmInstruction<Movsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSB;

            public static implicit operator AsmMnemonicCode(Movsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsb src) => AsmMnemonics.MOVSB;
        }

        public static Movsb movsb() => default;

        [MethodImpl(Inline)]
        public static Movsb movsb(AsmHexCode encoded) => new Movsb(encoded);

        public struct Movsw : IAsmInstruction<Movsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSW;

            public static implicit operator AsmMnemonicCode(Movsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsw src) => AsmMnemonics.MOVSW;
        }

        public static Movsw movsw() => default;

        [MethodImpl(Inline)]
        public static Movsw movsw(AsmHexCode encoded) => new Movsw(encoded);

        public struct Movsd : IAsmInstruction<Movsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSD;

            public static implicit operator AsmMnemonicCode(Movsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsd src) => AsmMnemonics.MOVSD;
        }

        public static Movsd movsd() => default;

        [MethodImpl(Inline)]
        public static Movsd movsd(AsmHexCode encoded) => new Movsd(encoded);

        public struct Movsq : IAsmInstruction<Movsq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movsq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSQ;

            public static implicit operator AsmMnemonicCode(Movsq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsq src) => AsmMnemonics.MOVSQ;
        }

        public static Movsq movsq() => default;

        [MethodImpl(Inline)]
        public static Movsq movsq(AsmHexCode encoded) => new Movsq(encoded);

        public struct Vmovsd : IAsmInstruction<Vmovsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSD;

            public static implicit operator AsmMnemonicCode(Vmovsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovsd src) => AsmMnemonics.VMOVSD;
        }

        public static Vmovsd vmovsd() => default;

        [MethodImpl(Inline)]
        public static Vmovsd vmovsd(AsmHexCode encoded) => new Vmovsd(encoded);

        public struct Movshdup : IAsmInstruction<Movshdup>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movshdup(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSHDUP;

            public static implicit operator AsmMnemonicCode(Movshdup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movshdup src) => AsmMnemonics.MOVSHDUP;
        }

        public static Movshdup movshdup() => default;

        [MethodImpl(Inline)]
        public static Movshdup movshdup(AsmHexCode encoded) => new Movshdup(encoded);

        public struct Vmovshdup : IAsmInstruction<Vmovshdup>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovshdup(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSHDUP;

            public static implicit operator AsmMnemonicCode(Vmovshdup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovshdup src) => AsmMnemonics.VMOVSHDUP;
        }

        public static Vmovshdup vmovshdup() => default;

        [MethodImpl(Inline)]
        public static Vmovshdup vmovshdup(AsmHexCode encoded) => new Vmovshdup(encoded);

        public struct Movsldup : IAsmInstruction<Movsldup>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movsldup(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSLDUP;

            public static implicit operator AsmMnemonicCode(Movsldup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsldup src) => AsmMnemonics.MOVSLDUP;
        }

        public static Movsldup movsldup() => default;

        [MethodImpl(Inline)]
        public static Movsldup movsldup(AsmHexCode encoded) => new Movsldup(encoded);

        public struct Vmovsldup : IAsmInstruction<Vmovsldup>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovsldup(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSLDUP;

            public static implicit operator AsmMnemonicCode(Vmovsldup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovsldup src) => AsmMnemonics.VMOVSLDUP;
        }

        public static Vmovsldup vmovsldup() => default;

        [MethodImpl(Inline)]
        public static Vmovsldup vmovsldup(AsmHexCode encoded) => new Vmovsldup(encoded);

        public struct Movss : IAsmInstruction<Movss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSS;

            public static implicit operator AsmMnemonicCode(Movss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movss src) => AsmMnemonics.MOVSS;
        }

        public static Movss movss() => default;

        [MethodImpl(Inline)]
        public static Movss movss(AsmHexCode encoded) => new Movss(encoded);

        public struct Vmovss : IAsmInstruction<Vmovss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSS;

            public static implicit operator AsmMnemonicCode(Vmovss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovss src) => AsmMnemonics.VMOVSS;
        }

        public static Vmovss vmovss() => default;

        [MethodImpl(Inline)]
        public static Vmovss vmovss(AsmHexCode encoded) => new Vmovss(encoded);

        public struct Movsx : IAsmInstruction<Movsx>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movsx(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSX;

            public static implicit operator AsmMnemonicCode(Movsx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsx src) => AsmMnemonics.MOVSX;
        }

        public static Movsx movsx() => default;

        [MethodImpl(Inline)]
        public static Movsx movsx(AsmHexCode encoded) => new Movsx(encoded);

        public struct Movsxd : IAsmInstruction<Movsxd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movsxd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSXD;

            public static implicit operator AsmMnemonicCode(Movsxd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsxd src) => AsmMnemonics.MOVSXD;
        }

        public static Movsxd movsxd() => default;

        [MethodImpl(Inline)]
        public static Movsxd movsxd(AsmHexCode encoded) => new Movsxd(encoded);

        public struct Movupd : IAsmInstruction<Movupd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movupd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVUPD;

            public static implicit operator AsmMnemonicCode(Movupd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movupd src) => AsmMnemonics.MOVUPD;
        }

        public static Movupd movupd() => default;

        [MethodImpl(Inline)]
        public static Movupd movupd(AsmHexCode encoded) => new Movupd(encoded);

        public struct Vmovupd : IAsmInstruction<Vmovupd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovupd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVUPD;

            public static implicit operator AsmMnemonicCode(Vmovupd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovupd src) => AsmMnemonics.VMOVUPD;
        }

        public static Vmovupd vmovupd() => default;

        [MethodImpl(Inline)]
        public static Vmovupd vmovupd(AsmHexCode encoded) => new Vmovupd(encoded);

        public struct Movups : IAsmInstruction<Movups>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movups(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVUPS;

            public static implicit operator AsmMnemonicCode(Movups src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movups src) => AsmMnemonics.MOVUPS;
        }

        public static Movups movups() => default;

        [MethodImpl(Inline)]
        public static Movups movups(AsmHexCode encoded) => new Movups(encoded);

        public struct Vmovups : IAsmInstruction<Vmovups>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmovups(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVUPS;

            public static implicit operator AsmMnemonicCode(Vmovups src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovups src) => AsmMnemonics.VMOVUPS;
        }

        public static Vmovups vmovups() => default;

        [MethodImpl(Inline)]
        public static Vmovups vmovups(AsmHexCode encoded) => new Vmovups(encoded);

        public struct Movzx : IAsmInstruction<Movzx>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Movzx(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVZX;

            public static implicit operator AsmMnemonicCode(Movzx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movzx src) => AsmMnemonics.MOVZX;
        }

        public static Movzx movzx() => default;

        [MethodImpl(Inline)]
        public static Movzx movzx(AsmHexCode encoded) => new Movzx(encoded);

        public struct Mpsadbw : IAsmInstruction<Mpsadbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Mpsadbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MPSADBW;

            public static implicit operator AsmMnemonicCode(Mpsadbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mpsadbw src) => AsmMnemonics.MPSADBW;
        }

        public static Mpsadbw mpsadbw() => default;

        [MethodImpl(Inline)]
        public static Mpsadbw mpsadbw(AsmHexCode encoded) => new Mpsadbw(encoded);

        public struct Vmpsadbw : IAsmInstruction<Vmpsadbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmpsadbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMPSADBW;

            public static implicit operator AsmMnemonicCode(Vmpsadbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmpsadbw src) => AsmMnemonics.VMPSADBW;
        }

        public static Vmpsadbw vmpsadbw() => default;

        [MethodImpl(Inline)]
        public static Vmpsadbw vmpsadbw(AsmHexCode encoded) => new Vmpsadbw(encoded);

        public struct Mul : IAsmInstruction<Mul>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Mul(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MUL;

            public static implicit operator AsmMnemonicCode(Mul src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mul src) => AsmMnemonics.MUL;
        }

        public static Mul mul() => default;

        [MethodImpl(Inline)]
        public static Mul mul(AsmHexCode encoded) => new Mul(encoded);

        public struct Mulpd : IAsmInstruction<Mulpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Mulpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULPD;

            public static implicit operator AsmMnemonicCode(Mulpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulpd src) => AsmMnemonics.MULPD;
        }

        public static Mulpd mulpd() => default;

        [MethodImpl(Inline)]
        public static Mulpd mulpd(AsmHexCode encoded) => new Mulpd(encoded);

        public struct Vmulpd : IAsmInstruction<Vmulpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmulpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULPD;

            public static implicit operator AsmMnemonicCode(Vmulpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmulpd src) => AsmMnemonics.VMULPD;
        }

        public static Vmulpd vmulpd() => default;

        [MethodImpl(Inline)]
        public static Vmulpd vmulpd(AsmHexCode encoded) => new Vmulpd(encoded);

        public struct Mulps : IAsmInstruction<Mulps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Mulps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULPS;

            public static implicit operator AsmMnemonicCode(Mulps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulps src) => AsmMnemonics.MULPS;
        }

        public static Mulps mulps() => default;

        [MethodImpl(Inline)]
        public static Mulps mulps(AsmHexCode encoded) => new Mulps(encoded);

        public struct Vmulps : IAsmInstruction<Vmulps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmulps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULPS;

            public static implicit operator AsmMnemonicCode(Vmulps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmulps src) => AsmMnemonics.VMULPS;
        }

        public static Vmulps vmulps() => default;

        [MethodImpl(Inline)]
        public static Vmulps vmulps(AsmHexCode encoded) => new Vmulps(encoded);

        public struct Mulsd : IAsmInstruction<Mulsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Mulsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULSD;

            public static implicit operator AsmMnemonicCode(Mulsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulsd src) => AsmMnemonics.MULSD;
        }

        public static Mulsd mulsd() => default;

        [MethodImpl(Inline)]
        public static Mulsd mulsd(AsmHexCode encoded) => new Mulsd(encoded);

        public struct Vmulsd : IAsmInstruction<Vmulsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmulsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULSD;

            public static implicit operator AsmMnemonicCode(Vmulsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmulsd src) => AsmMnemonics.VMULSD;
        }

        public static Vmulsd vmulsd() => default;

        [MethodImpl(Inline)]
        public static Vmulsd vmulsd(AsmHexCode encoded) => new Vmulsd(encoded);

        public struct Mulss : IAsmInstruction<Mulss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Mulss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULSS;

            public static implicit operator AsmMnemonicCode(Mulss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulss src) => AsmMnemonics.MULSS;
        }

        public static Mulss mulss() => default;

        [MethodImpl(Inline)]
        public static Mulss mulss(AsmHexCode encoded) => new Mulss(encoded);

        public struct Vmulss : IAsmInstruction<Vmulss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmulss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULSS;

            public static implicit operator AsmMnemonicCode(Vmulss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmulss src) => AsmMnemonics.VMULSS;
        }

        public static Vmulss vmulss() => default;

        [MethodImpl(Inline)]
        public static Vmulss vmulss(AsmHexCode encoded) => new Vmulss(encoded);

        public struct Mulx : IAsmInstruction<Mulx>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Mulx(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULX;

            public static implicit operator AsmMnemonicCode(Mulx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulx src) => AsmMnemonics.MULX;
        }

        public static Mulx mulx() => default;

        [MethodImpl(Inline)]
        public static Mulx mulx(AsmHexCode encoded) => new Mulx(encoded);

        public struct Mwait : IAsmInstruction<Mwait>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Mwait(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MWAIT;

            public static implicit operator AsmMnemonicCode(Mwait src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mwait src) => AsmMnemonics.MWAIT;
        }

        public static Mwait mwait() => default;

        [MethodImpl(Inline)]
        public static Mwait mwait(AsmHexCode encoded) => new Mwait(encoded);

        public struct Neg : IAsmInstruction<Neg>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Neg(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.NEG;

            public static implicit operator AsmMnemonicCode(Neg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Neg src) => AsmMnemonics.NEG;
        }

        public static Neg neg() => default;

        [MethodImpl(Inline)]
        public static Neg neg(AsmHexCode encoded) => new Neg(encoded);

        public struct Nop : IAsmInstruction<Nop>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Nop(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.NOP;

            public static implicit operator AsmMnemonicCode(Nop src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Nop src) => AsmMnemonics.NOP;
        }

        public static Nop nop() => default;

        [MethodImpl(Inline)]
        public static Nop nop(AsmHexCode encoded) => new Nop(encoded);

        public struct Not : IAsmInstruction<Not>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Not(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.NOT;

            public static implicit operator AsmMnemonicCode(Not src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Not src) => AsmMnemonics.NOT;
        }

        public static Not not() => default;

        [MethodImpl(Inline)]
        public static Not not(AsmHexCode encoded) => new Not(encoded);

        public struct Or : IAsmInstruction<Or>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Or(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OR;

            public static implicit operator AsmMnemonicCode(Or src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Or src) => AsmMnemonics.OR;
        }

        public static Or or() => default;

        [MethodImpl(Inline)]
        public static Or or(AsmHexCode encoded) => new Or(encoded);

        public struct Orpd : IAsmInstruction<Orpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Orpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ORPD;

            public static implicit operator AsmMnemonicCode(Orpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Orpd src) => AsmMnemonics.ORPD;
        }

        public static Orpd orpd() => default;

        [MethodImpl(Inline)]
        public static Orpd orpd(AsmHexCode encoded) => new Orpd(encoded);

        public struct Vorpd : IAsmInstruction<Vorpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vorpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VORPD;

            public static implicit operator AsmMnemonicCode(Vorpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vorpd src) => AsmMnemonics.VORPD;
        }

        public static Vorpd vorpd() => default;

        [MethodImpl(Inline)]
        public static Vorpd vorpd(AsmHexCode encoded) => new Vorpd(encoded);

        public struct Orps : IAsmInstruction<Orps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Orps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ORPS;

            public static implicit operator AsmMnemonicCode(Orps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Orps src) => AsmMnemonics.ORPS;
        }

        public static Orps orps() => default;

        [MethodImpl(Inline)]
        public static Orps orps(AsmHexCode encoded) => new Orps(encoded);

        public struct Vorps : IAsmInstruction<Vorps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vorps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VORPS;

            public static implicit operator AsmMnemonicCode(Vorps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vorps src) => AsmMnemonics.VORPS;
        }

        public static Vorps vorps() => default;

        [MethodImpl(Inline)]
        public static Vorps vorps(AsmHexCode encoded) => new Vorps(encoded);

        public struct Out : IAsmInstruction<Out>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Out(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUT;

            public static implicit operator AsmMnemonicCode(Out src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Out src) => AsmMnemonics.OUT;
        }

        public static Out @out() => default;

        [MethodImpl(Inline)]
        public static Out @out(AsmHexCode encoded) => new Out(encoded);

        public struct Outs : IAsmInstruction<Outs>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Outs(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUTS;

            public static implicit operator AsmMnemonicCode(Outs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Outs src) => AsmMnemonics.OUTS;
        }

        public static Outs outs() => default;

        [MethodImpl(Inline)]
        public static Outs outs(AsmHexCode encoded) => new Outs(encoded);

        public struct Outsb : IAsmInstruction<Outsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Outsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUTSB;

            public static implicit operator AsmMnemonicCode(Outsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Outsb src) => AsmMnemonics.OUTSB;
        }

        public static Outsb outsb() => default;

        [MethodImpl(Inline)]
        public static Outsb outsb(AsmHexCode encoded) => new Outsb(encoded);

        public struct Outsw : IAsmInstruction<Outsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Outsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUTSW;

            public static implicit operator AsmMnemonicCode(Outsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Outsw src) => AsmMnemonics.OUTSW;
        }

        public static Outsw outsw() => default;

        [MethodImpl(Inline)]
        public static Outsw outsw(AsmHexCode encoded) => new Outsw(encoded);

        public struct Outsd : IAsmInstruction<Outsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Outsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUTSD;

            public static implicit operator AsmMnemonicCode(Outsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Outsd src) => AsmMnemonics.OUTSD;
        }

        public static Outsd outsd() => default;

        [MethodImpl(Inline)]
        public static Outsd outsd(AsmHexCode encoded) => new Outsd(encoded);

        public struct Pabsb : IAsmInstruction<Pabsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pabsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PABSB;

            public static implicit operator AsmMnemonicCode(Pabsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pabsb src) => AsmMnemonics.PABSB;
        }

        public static Pabsb pabsb() => default;

        [MethodImpl(Inline)]
        public static Pabsb pabsb(AsmHexCode encoded) => new Pabsb(encoded);

        public struct Pabsw : IAsmInstruction<Pabsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pabsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PABSW;

            public static implicit operator AsmMnemonicCode(Pabsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pabsw src) => AsmMnemonics.PABSW;
        }

        public static Pabsw pabsw() => default;

        [MethodImpl(Inline)]
        public static Pabsw pabsw(AsmHexCode encoded) => new Pabsw(encoded);

        public struct Pabsd : IAsmInstruction<Pabsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pabsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PABSD;

            public static implicit operator AsmMnemonicCode(Pabsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pabsd src) => AsmMnemonics.PABSD;
        }

        public static Pabsd pabsd() => default;

        [MethodImpl(Inline)]
        public static Pabsd pabsd(AsmHexCode encoded) => new Pabsd(encoded);

        public struct Vpabsb : IAsmInstruction<Vpabsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpabsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPABSB;

            public static implicit operator AsmMnemonicCode(Vpabsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpabsb src) => AsmMnemonics.VPABSB;
        }

        public static Vpabsb vpabsb() => default;

        [MethodImpl(Inline)]
        public static Vpabsb vpabsb(AsmHexCode encoded) => new Vpabsb(encoded);

        public struct Vpabsw : IAsmInstruction<Vpabsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpabsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPABSW;

            public static implicit operator AsmMnemonicCode(Vpabsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpabsw src) => AsmMnemonics.VPABSW;
        }

        public static Vpabsw vpabsw() => default;

        [MethodImpl(Inline)]
        public static Vpabsw vpabsw(AsmHexCode encoded) => new Vpabsw(encoded);

        public struct Vpabsd : IAsmInstruction<Vpabsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpabsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPABSD;

            public static implicit operator AsmMnemonicCode(Vpabsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpabsd src) => AsmMnemonics.VPABSD;
        }

        public static Vpabsd vpabsd() => default;

        [MethodImpl(Inline)]
        public static Vpabsd vpabsd(AsmHexCode encoded) => new Vpabsd(encoded);

        public struct Packsswb : IAsmInstruction<Packsswb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Packsswb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKSSWB;

            public static implicit operator AsmMnemonicCode(Packsswb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Packsswb src) => AsmMnemonics.PACKSSWB;
        }

        public static Packsswb packsswb() => default;

        [MethodImpl(Inline)]
        public static Packsswb packsswb(AsmHexCode encoded) => new Packsswb(encoded);

        public struct Packssdw : IAsmInstruction<Packssdw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Packssdw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKSSDW;

            public static implicit operator AsmMnemonicCode(Packssdw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Packssdw src) => AsmMnemonics.PACKSSDW;
        }

        public static Packssdw packssdw() => default;

        [MethodImpl(Inline)]
        public static Packssdw packssdw(AsmHexCode encoded) => new Packssdw(encoded);

        public struct Vpacksswb : IAsmInstruction<Vpacksswb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpacksswb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKSSWB;

            public static implicit operator AsmMnemonicCode(Vpacksswb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpacksswb src) => AsmMnemonics.VPACKSSWB;
        }

        public static Vpacksswb vpacksswb() => default;

        [MethodImpl(Inline)]
        public static Vpacksswb vpacksswb(AsmHexCode encoded) => new Vpacksswb(encoded);

        public struct Vpackssdw : IAsmInstruction<Vpackssdw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpackssdw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKSSDW;

            public static implicit operator AsmMnemonicCode(Vpackssdw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpackssdw src) => AsmMnemonics.VPACKSSDW;
        }

        public static Vpackssdw vpackssdw() => default;

        [MethodImpl(Inline)]
        public static Vpackssdw vpackssdw(AsmHexCode encoded) => new Vpackssdw(encoded);

        public struct Packusdw : IAsmInstruction<Packusdw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Packusdw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKUSDW;

            public static implicit operator AsmMnemonicCode(Packusdw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Packusdw src) => AsmMnemonics.PACKUSDW;
        }

        public static Packusdw packusdw() => default;

        [MethodImpl(Inline)]
        public static Packusdw packusdw(AsmHexCode encoded) => new Packusdw(encoded);

        public struct Vpackusdw : IAsmInstruction<Vpackusdw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpackusdw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKUSDW;

            public static implicit operator AsmMnemonicCode(Vpackusdw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpackusdw src) => AsmMnemonics.VPACKUSDW;
        }

        public static Vpackusdw vpackusdw() => default;

        [MethodImpl(Inline)]
        public static Vpackusdw vpackusdw(AsmHexCode encoded) => new Vpackusdw(encoded);

        public struct Packuswb : IAsmInstruction<Packuswb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Packuswb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKUSWB;

            public static implicit operator AsmMnemonicCode(Packuswb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Packuswb src) => AsmMnemonics.PACKUSWB;
        }

        public static Packuswb packuswb() => default;

        [MethodImpl(Inline)]
        public static Packuswb packuswb(AsmHexCode encoded) => new Packuswb(encoded);

        public struct Vpackuswb : IAsmInstruction<Vpackuswb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpackuswb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKUSWB;

            public static implicit operator AsmMnemonicCode(Vpackuswb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpackuswb src) => AsmMnemonics.VPACKUSWB;
        }

        public static Vpackuswb vpackuswb() => default;

        [MethodImpl(Inline)]
        public static Vpackuswb vpackuswb(AsmHexCode encoded) => new Vpackuswb(encoded);

        public struct Paddb : IAsmInstruction<Paddb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Paddb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDB;

            public static implicit operator AsmMnemonicCode(Paddb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddb src) => AsmMnemonics.PADDB;
        }

        public static Paddb paddb() => default;

        [MethodImpl(Inline)]
        public static Paddb paddb(AsmHexCode encoded) => new Paddb(encoded);

        public struct Paddw : IAsmInstruction<Paddw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Paddw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDW;

            public static implicit operator AsmMnemonicCode(Paddw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddw src) => AsmMnemonics.PADDW;
        }

        public static Paddw paddw() => default;

        [MethodImpl(Inline)]
        public static Paddw paddw(AsmHexCode encoded) => new Paddw(encoded);

        public struct Paddd : IAsmInstruction<Paddd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Paddd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDD;

            public static implicit operator AsmMnemonicCode(Paddd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddd src) => AsmMnemonics.PADDD;
        }

        public static Paddd paddd() => default;

        [MethodImpl(Inline)]
        public static Paddd paddd(AsmHexCode encoded) => new Paddd(encoded);

        public struct Vpaddb : IAsmInstruction<Vpaddb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpaddb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDB;

            public static implicit operator AsmMnemonicCode(Vpaddb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddb src) => AsmMnemonics.VPADDB;
        }

        public static Vpaddb vpaddb() => default;

        [MethodImpl(Inline)]
        public static Vpaddb vpaddb(AsmHexCode encoded) => new Vpaddb(encoded);

        public struct Vpaddw : IAsmInstruction<Vpaddw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpaddw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDW;

            public static implicit operator AsmMnemonicCode(Vpaddw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddw src) => AsmMnemonics.VPADDW;
        }

        public static Vpaddw vpaddw() => default;

        [MethodImpl(Inline)]
        public static Vpaddw vpaddw(AsmHexCode encoded) => new Vpaddw(encoded);

        public struct Vpaddd : IAsmInstruction<Vpaddd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpaddd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDD;

            public static implicit operator AsmMnemonicCode(Vpaddd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddd src) => AsmMnemonics.VPADDD;
        }

        public static Vpaddd vpaddd() => default;

        [MethodImpl(Inline)]
        public static Vpaddd vpaddd(AsmHexCode encoded) => new Vpaddd(encoded);

        public struct Paddq : IAsmInstruction<Paddq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Paddq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDQ;

            public static implicit operator AsmMnemonicCode(Paddq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddq src) => AsmMnemonics.PADDQ;
        }

        public static Paddq paddq() => default;

        [MethodImpl(Inline)]
        public static Paddq paddq(AsmHexCode encoded) => new Paddq(encoded);

        public struct Vpaddq : IAsmInstruction<Vpaddq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpaddq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDQ;

            public static implicit operator AsmMnemonicCode(Vpaddq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddq src) => AsmMnemonics.VPADDQ;
        }

        public static Vpaddq vpaddq() => default;

        [MethodImpl(Inline)]
        public static Vpaddq vpaddq(AsmHexCode encoded) => new Vpaddq(encoded);

        public struct Paddsb : IAsmInstruction<Paddsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Paddsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDSB;

            public static implicit operator AsmMnemonicCode(Paddsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddsb src) => AsmMnemonics.PADDSB;
        }

        public static Paddsb paddsb() => default;

        [MethodImpl(Inline)]
        public static Paddsb paddsb(AsmHexCode encoded) => new Paddsb(encoded);

        public struct Paddsw : IAsmInstruction<Paddsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Paddsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDSW;

            public static implicit operator AsmMnemonicCode(Paddsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddsw src) => AsmMnemonics.PADDSW;
        }

        public static Paddsw paddsw() => default;

        [MethodImpl(Inline)]
        public static Paddsw paddsw(AsmHexCode encoded) => new Paddsw(encoded);

        public struct Vpaddsb : IAsmInstruction<Vpaddsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpaddsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDSB;

            public static implicit operator AsmMnemonicCode(Vpaddsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddsb src) => AsmMnemonics.VPADDSB;
        }

        public static Vpaddsb vpaddsb() => default;

        [MethodImpl(Inline)]
        public static Vpaddsb vpaddsb(AsmHexCode encoded) => new Vpaddsb(encoded);

        public struct Vpaddsw : IAsmInstruction<Vpaddsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpaddsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDSW;

            public static implicit operator AsmMnemonicCode(Vpaddsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddsw src) => AsmMnemonics.VPADDSW;
        }

        public static Vpaddsw vpaddsw() => default;

        [MethodImpl(Inline)]
        public static Vpaddsw vpaddsw(AsmHexCode encoded) => new Vpaddsw(encoded);

        public struct Paddusb : IAsmInstruction<Paddusb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Paddusb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDUSB;

            public static implicit operator AsmMnemonicCode(Paddusb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddusb src) => AsmMnemonics.PADDUSB;
        }

        public static Paddusb paddusb() => default;

        [MethodImpl(Inline)]
        public static Paddusb paddusb(AsmHexCode encoded) => new Paddusb(encoded);

        public struct Paddusw : IAsmInstruction<Paddusw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Paddusw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDUSW;

            public static implicit operator AsmMnemonicCode(Paddusw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddusw src) => AsmMnemonics.PADDUSW;
        }

        public static Paddusw paddusw() => default;

        [MethodImpl(Inline)]
        public static Paddusw paddusw(AsmHexCode encoded) => new Paddusw(encoded);

        public struct Vpaddusb : IAsmInstruction<Vpaddusb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpaddusb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDUSB;

            public static implicit operator AsmMnemonicCode(Vpaddusb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddusb src) => AsmMnemonics.VPADDUSB;
        }

        public static Vpaddusb vpaddusb() => default;

        [MethodImpl(Inline)]
        public static Vpaddusb vpaddusb(AsmHexCode encoded) => new Vpaddusb(encoded);

        public struct Vpaddusw : IAsmInstruction<Vpaddusw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpaddusw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDUSW;

            public static implicit operator AsmMnemonicCode(Vpaddusw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddusw src) => AsmMnemonics.VPADDUSW;
        }

        public static Vpaddusw vpaddusw() => default;

        [MethodImpl(Inline)]
        public static Vpaddusw vpaddusw(AsmHexCode encoded) => new Vpaddusw(encoded);

        public struct Palignr : IAsmInstruction<Palignr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Palignr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PALIGNR;

            public static implicit operator AsmMnemonicCode(Palignr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Palignr src) => AsmMnemonics.PALIGNR;
        }

        public static Palignr palignr() => default;

        [MethodImpl(Inline)]
        public static Palignr palignr(AsmHexCode encoded) => new Palignr(encoded);

        public struct Vpalignr : IAsmInstruction<Vpalignr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpalignr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPALIGNR;

            public static implicit operator AsmMnemonicCode(Vpalignr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpalignr src) => AsmMnemonics.VPALIGNR;
        }

        public static Vpalignr vpalignr() => default;

        [MethodImpl(Inline)]
        public static Vpalignr vpalignr(AsmHexCode encoded) => new Vpalignr(encoded);

        public struct Pand : IAsmInstruction<Pand>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pand(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAND;

            public static implicit operator AsmMnemonicCode(Pand src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pand src) => AsmMnemonics.PAND;
        }

        public static Pand pand() => default;

        [MethodImpl(Inline)]
        public static Pand pand(AsmHexCode encoded) => new Pand(encoded);

        public struct Vpand : IAsmInstruction<Vpand>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpand(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPAND;

            public static implicit operator AsmMnemonicCode(Vpand src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpand src) => AsmMnemonics.VPAND;
        }

        public static Vpand vpand() => default;

        [MethodImpl(Inline)]
        public static Vpand vpand(AsmHexCode encoded) => new Vpand(encoded);

        public struct Pandn : IAsmInstruction<Pandn>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pandn(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PANDN;

            public static implicit operator AsmMnemonicCode(Pandn src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pandn src) => AsmMnemonics.PANDN;
        }

        public static Pandn pandn() => default;

        [MethodImpl(Inline)]
        public static Pandn pandn(AsmHexCode encoded) => new Pandn(encoded);

        public struct Vpandn : IAsmInstruction<Vpandn>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpandn(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPANDN;

            public static implicit operator AsmMnemonicCode(Vpandn src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpandn src) => AsmMnemonics.VPANDN;
        }

        public static Vpandn vpandn() => default;

        [MethodImpl(Inline)]
        public static Vpandn vpandn(AsmHexCode encoded) => new Vpandn(encoded);

        public struct Pause : IAsmInstruction<Pause>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pause(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAUSE;

            public static implicit operator AsmMnemonicCode(Pause src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pause src) => AsmMnemonics.PAUSE;
        }

        public static Pause pause() => default;

        [MethodImpl(Inline)]
        public static Pause pause(AsmHexCode encoded) => new Pause(encoded);

        public struct Pavgb : IAsmInstruction<Pavgb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pavgb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAVGB;

            public static implicit operator AsmMnemonicCode(Pavgb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pavgb src) => AsmMnemonics.PAVGB;
        }

        public static Pavgb pavgb() => default;

        [MethodImpl(Inline)]
        public static Pavgb pavgb(AsmHexCode encoded) => new Pavgb(encoded);

        public struct Pavgw : IAsmInstruction<Pavgw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pavgw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAVGW;

            public static implicit operator AsmMnemonicCode(Pavgw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pavgw src) => AsmMnemonics.PAVGW;
        }

        public static Pavgw pavgw() => default;

        [MethodImpl(Inline)]
        public static Pavgw pavgw(AsmHexCode encoded) => new Pavgw(encoded);

        public struct Vpavgb : IAsmInstruction<Vpavgb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpavgb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPAVGB;

            public static implicit operator AsmMnemonicCode(Vpavgb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpavgb src) => AsmMnemonics.VPAVGB;
        }

        public static Vpavgb vpavgb() => default;

        [MethodImpl(Inline)]
        public static Vpavgb vpavgb(AsmHexCode encoded) => new Vpavgb(encoded);

        public struct Vpavgw : IAsmInstruction<Vpavgw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpavgw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPAVGW;

            public static implicit operator AsmMnemonicCode(Vpavgw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpavgw src) => AsmMnemonics.VPAVGW;
        }

        public static Vpavgw vpavgw() => default;

        [MethodImpl(Inline)]
        public static Vpavgw vpavgw(AsmHexCode encoded) => new Vpavgw(encoded);

        public struct Pblendvb : IAsmInstruction<Pblendvb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pblendvb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PBLENDVB;

            public static implicit operator AsmMnemonicCode(Pblendvb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pblendvb src) => AsmMnemonics.PBLENDVB;
        }

        public static Pblendvb pblendvb() => default;

        [MethodImpl(Inline)]
        public static Pblendvb pblendvb(AsmHexCode encoded) => new Pblendvb(encoded);

        public struct Vpblendvb : IAsmInstruction<Vpblendvb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpblendvb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBLENDVB;

            public static implicit operator AsmMnemonicCode(Vpblendvb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpblendvb src) => AsmMnemonics.VPBLENDVB;
        }

        public static Vpblendvb vpblendvb() => default;

        [MethodImpl(Inline)]
        public static Vpblendvb vpblendvb(AsmHexCode encoded) => new Vpblendvb(encoded);

        public struct Pblendw : IAsmInstruction<Pblendw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pblendw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PBLENDW;

            public static implicit operator AsmMnemonicCode(Pblendw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pblendw src) => AsmMnemonics.PBLENDW;
        }

        public static Pblendw pblendw() => default;

        [MethodImpl(Inline)]
        public static Pblendw pblendw(AsmHexCode encoded) => new Pblendw(encoded);

        public struct Vpblendw : IAsmInstruction<Vpblendw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpblendw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBLENDW;

            public static implicit operator AsmMnemonicCode(Vpblendw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpblendw src) => AsmMnemonics.VPBLENDW;
        }

        public static Vpblendw vpblendw() => default;

        [MethodImpl(Inline)]
        public static Vpblendw vpblendw(AsmHexCode encoded) => new Vpblendw(encoded);

        public struct Pclmulqdq : IAsmInstruction<Pclmulqdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pclmulqdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCLMULQDQ;

            public static implicit operator AsmMnemonicCode(Pclmulqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pclmulqdq src) => AsmMnemonics.PCLMULQDQ;
        }

        public static Pclmulqdq pclmulqdq() => default;

        [MethodImpl(Inline)]
        public static Pclmulqdq pclmulqdq(AsmHexCode encoded) => new Pclmulqdq(encoded);

        public struct Vpclmulqdq : IAsmInstruction<Vpclmulqdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpclmulqdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCLMULQDQ;

            public static implicit operator AsmMnemonicCode(Vpclmulqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpclmulqdq src) => AsmMnemonics.VPCLMULQDQ;
        }

        public static Vpclmulqdq vpclmulqdq() => default;

        [MethodImpl(Inline)]
        public static Vpclmulqdq vpclmulqdq(AsmHexCode encoded) => new Vpclmulqdq(encoded);

        public struct Pcmpeqb : IAsmInstruction<Pcmpeqb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pcmpeqb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQB;

            public static implicit operator AsmMnemonicCode(Pcmpeqb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpeqb src) => AsmMnemonics.PCMPEQB;
        }

        public static Pcmpeqb pcmpeqb() => default;

        [MethodImpl(Inline)]
        public static Pcmpeqb pcmpeqb(AsmHexCode encoded) => new Pcmpeqb(encoded);

        public struct Pcmpeqw : IAsmInstruction<Pcmpeqw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pcmpeqw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQW;

            public static implicit operator AsmMnemonicCode(Pcmpeqw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpeqw src) => AsmMnemonics.PCMPEQW;
        }

        public static Pcmpeqw pcmpeqw() => default;

        [MethodImpl(Inline)]
        public static Pcmpeqw pcmpeqw(AsmHexCode encoded) => new Pcmpeqw(encoded);

        public struct Pcmpeqd : IAsmInstruction<Pcmpeqd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pcmpeqd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQD;

            public static implicit operator AsmMnemonicCode(Pcmpeqd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpeqd src) => AsmMnemonics.PCMPEQD;
        }

        public static Pcmpeqd pcmpeqd() => default;

        [MethodImpl(Inline)]
        public static Pcmpeqd pcmpeqd(AsmHexCode encoded) => new Pcmpeqd(encoded);

        public struct Vpcmpeqb : IAsmInstruction<Vpcmpeqb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpcmpeqb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQB;

            public static implicit operator AsmMnemonicCode(Vpcmpeqb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpeqb src) => AsmMnemonics.VPCMPEQB;
        }

        public static Vpcmpeqb vpcmpeqb() => default;

        [MethodImpl(Inline)]
        public static Vpcmpeqb vpcmpeqb(AsmHexCode encoded) => new Vpcmpeqb(encoded);

        public struct Vpcmpeqw : IAsmInstruction<Vpcmpeqw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpcmpeqw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQW;

            public static implicit operator AsmMnemonicCode(Vpcmpeqw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpeqw src) => AsmMnemonics.VPCMPEQW;
        }

        public static Vpcmpeqw vpcmpeqw() => default;

        [MethodImpl(Inline)]
        public static Vpcmpeqw vpcmpeqw(AsmHexCode encoded) => new Vpcmpeqw(encoded);

        public struct Vpcmpeqd : IAsmInstruction<Vpcmpeqd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpcmpeqd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQD;

            public static implicit operator AsmMnemonicCode(Vpcmpeqd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpeqd src) => AsmMnemonics.VPCMPEQD;
        }

        public static Vpcmpeqd vpcmpeqd() => default;

        [MethodImpl(Inline)]
        public static Vpcmpeqd vpcmpeqd(AsmHexCode encoded) => new Vpcmpeqd(encoded);

        public struct Pcmpeqq : IAsmInstruction<Pcmpeqq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pcmpeqq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQQ;

            public static implicit operator AsmMnemonicCode(Pcmpeqq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpeqq src) => AsmMnemonics.PCMPEQQ;
        }

        public static Pcmpeqq pcmpeqq() => default;

        [MethodImpl(Inline)]
        public static Pcmpeqq pcmpeqq(AsmHexCode encoded) => new Pcmpeqq(encoded);

        public struct Vpcmpeqq : IAsmInstruction<Vpcmpeqq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpcmpeqq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQQ;

            public static implicit operator AsmMnemonicCode(Vpcmpeqq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpeqq src) => AsmMnemonics.VPCMPEQQ;
        }

        public static Vpcmpeqq vpcmpeqq() => default;

        [MethodImpl(Inline)]
        public static Vpcmpeqq vpcmpeqq(AsmHexCode encoded) => new Vpcmpeqq(encoded);

        public struct Pcmpestri : IAsmInstruction<Pcmpestri>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pcmpestri(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPESTRI;

            public static implicit operator AsmMnemonicCode(Pcmpestri src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpestri src) => AsmMnemonics.PCMPESTRI;
        }

        public static Pcmpestri pcmpestri() => default;

        [MethodImpl(Inline)]
        public static Pcmpestri pcmpestri(AsmHexCode encoded) => new Pcmpestri(encoded);

        public struct Vpcmpestri : IAsmInstruction<Vpcmpestri>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpcmpestri(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPESTRI;

            public static implicit operator AsmMnemonicCode(Vpcmpestri src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpestri src) => AsmMnemonics.VPCMPESTRI;
        }

        public static Vpcmpestri vpcmpestri() => default;

        [MethodImpl(Inline)]
        public static Vpcmpestri vpcmpestri(AsmHexCode encoded) => new Vpcmpestri(encoded);

        public struct Pcmpestrm : IAsmInstruction<Pcmpestrm>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pcmpestrm(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPESTRM;

            public static implicit operator AsmMnemonicCode(Pcmpestrm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpestrm src) => AsmMnemonics.PCMPESTRM;
        }

        public static Pcmpestrm pcmpestrm() => default;

        [MethodImpl(Inline)]
        public static Pcmpestrm pcmpestrm(AsmHexCode encoded) => new Pcmpestrm(encoded);

        public struct Vpcmpestrm : IAsmInstruction<Vpcmpestrm>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpcmpestrm(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPESTRM;

            public static implicit operator AsmMnemonicCode(Vpcmpestrm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpestrm src) => AsmMnemonics.VPCMPESTRM;
        }

        public static Vpcmpestrm vpcmpestrm() => default;

        [MethodImpl(Inline)]
        public static Vpcmpestrm vpcmpestrm(AsmHexCode encoded) => new Vpcmpestrm(encoded);

        public struct Pcmpgtb : IAsmInstruction<Pcmpgtb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pcmpgtb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTB;

            public static implicit operator AsmMnemonicCode(Pcmpgtb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpgtb src) => AsmMnemonics.PCMPGTB;
        }

        public static Pcmpgtb pcmpgtb() => default;

        [MethodImpl(Inline)]
        public static Pcmpgtb pcmpgtb(AsmHexCode encoded) => new Pcmpgtb(encoded);

        public struct Pcmpgtw : IAsmInstruction<Pcmpgtw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pcmpgtw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTW;

            public static implicit operator AsmMnemonicCode(Pcmpgtw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpgtw src) => AsmMnemonics.PCMPGTW;
        }

        public static Pcmpgtw pcmpgtw() => default;

        [MethodImpl(Inline)]
        public static Pcmpgtw pcmpgtw(AsmHexCode encoded) => new Pcmpgtw(encoded);

        public struct Pcmpgtd : IAsmInstruction<Pcmpgtd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pcmpgtd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTD;

            public static implicit operator AsmMnemonicCode(Pcmpgtd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpgtd src) => AsmMnemonics.PCMPGTD;
        }

        public static Pcmpgtd pcmpgtd() => default;

        [MethodImpl(Inline)]
        public static Pcmpgtd pcmpgtd(AsmHexCode encoded) => new Pcmpgtd(encoded);

        public struct Vpcmpgtb : IAsmInstruction<Vpcmpgtb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpcmpgtb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTB;

            public static implicit operator AsmMnemonicCode(Vpcmpgtb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpgtb src) => AsmMnemonics.VPCMPGTB;
        }

        public static Vpcmpgtb vpcmpgtb() => default;

        [MethodImpl(Inline)]
        public static Vpcmpgtb vpcmpgtb(AsmHexCode encoded) => new Vpcmpgtb(encoded);

        public struct Vpcmpgtw : IAsmInstruction<Vpcmpgtw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpcmpgtw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTW;

            public static implicit operator AsmMnemonicCode(Vpcmpgtw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpgtw src) => AsmMnemonics.VPCMPGTW;
        }

        public static Vpcmpgtw vpcmpgtw() => default;

        [MethodImpl(Inline)]
        public static Vpcmpgtw vpcmpgtw(AsmHexCode encoded) => new Vpcmpgtw(encoded);

        public struct Vpcmpgtd : IAsmInstruction<Vpcmpgtd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpcmpgtd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTD;

            public static implicit operator AsmMnemonicCode(Vpcmpgtd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpgtd src) => AsmMnemonics.VPCMPGTD;
        }

        public static Vpcmpgtd vpcmpgtd() => default;

        [MethodImpl(Inline)]
        public static Vpcmpgtd vpcmpgtd(AsmHexCode encoded) => new Vpcmpgtd(encoded);

        public struct Pcmpgtq : IAsmInstruction<Pcmpgtq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pcmpgtq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTQ;

            public static implicit operator AsmMnemonicCode(Pcmpgtq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpgtq src) => AsmMnemonics.PCMPGTQ;
        }

        public static Pcmpgtq pcmpgtq() => default;

        [MethodImpl(Inline)]
        public static Pcmpgtq pcmpgtq(AsmHexCode encoded) => new Pcmpgtq(encoded);

        public struct Vpcmpgtq : IAsmInstruction<Vpcmpgtq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpcmpgtq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTQ;

            public static implicit operator AsmMnemonicCode(Vpcmpgtq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpgtq src) => AsmMnemonics.VPCMPGTQ;
        }

        public static Vpcmpgtq vpcmpgtq() => default;

        [MethodImpl(Inline)]
        public static Vpcmpgtq vpcmpgtq(AsmHexCode encoded) => new Vpcmpgtq(encoded);

        public struct Pcmpistri : IAsmInstruction<Pcmpistri>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pcmpistri(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPISTRI;

            public static implicit operator AsmMnemonicCode(Pcmpistri src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpistri src) => AsmMnemonics.PCMPISTRI;
        }

        public static Pcmpistri pcmpistri() => default;

        [MethodImpl(Inline)]
        public static Pcmpistri pcmpistri(AsmHexCode encoded) => new Pcmpistri(encoded);

        public struct Vpcmpistri : IAsmInstruction<Vpcmpistri>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpcmpistri(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPISTRI;

            public static implicit operator AsmMnemonicCode(Vpcmpistri src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpistri src) => AsmMnemonics.VPCMPISTRI;
        }

        public static Vpcmpistri vpcmpistri() => default;

        [MethodImpl(Inline)]
        public static Vpcmpistri vpcmpistri(AsmHexCode encoded) => new Vpcmpistri(encoded);

        public struct Pcmpistrm : IAsmInstruction<Pcmpistrm>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pcmpistrm(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPISTRM;

            public static implicit operator AsmMnemonicCode(Pcmpistrm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpistrm src) => AsmMnemonics.PCMPISTRM;
        }

        public static Pcmpistrm pcmpistrm() => default;

        [MethodImpl(Inline)]
        public static Pcmpistrm pcmpistrm(AsmHexCode encoded) => new Pcmpistrm(encoded);

        public struct Vpcmpistrm : IAsmInstruction<Vpcmpistrm>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpcmpistrm(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPISTRM;

            public static implicit operator AsmMnemonicCode(Vpcmpistrm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpistrm src) => AsmMnemonics.VPCMPISTRM;
        }

        public static Vpcmpistrm vpcmpistrm() => default;

        [MethodImpl(Inline)]
        public static Vpcmpistrm vpcmpistrm(AsmHexCode encoded) => new Vpcmpistrm(encoded);

        public struct Pdep : IAsmInstruction<Pdep>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pdep(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PDEP;

            public static implicit operator AsmMnemonicCode(Pdep src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pdep src) => AsmMnemonics.PDEP;
        }

        public static Pdep pdep() => default;

        [MethodImpl(Inline)]
        public static Pdep pdep(AsmHexCode encoded) => new Pdep(encoded);

        public struct Pext : IAsmInstruction<Pext>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pext(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXT;

            public static implicit operator AsmMnemonicCode(Pext src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pext src) => AsmMnemonics.PEXT;
        }

        public static Pext pext() => default;

        [MethodImpl(Inline)]
        public static Pext pext(AsmHexCode encoded) => new Pext(encoded);

        public struct Pextrb : IAsmInstruction<Pextrb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pextrb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRB;

            public static implicit operator AsmMnemonicCode(Pextrb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pextrb src) => AsmMnemonics.PEXTRB;
        }

        public static Pextrb pextrb() => default;

        [MethodImpl(Inline)]
        public static Pextrb pextrb(AsmHexCode encoded) => new Pextrb(encoded);

        public struct Pextrd : IAsmInstruction<Pextrd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pextrd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRD;

            public static implicit operator AsmMnemonicCode(Pextrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pextrd src) => AsmMnemonics.PEXTRD;
        }

        public static Pextrd pextrd() => default;

        [MethodImpl(Inline)]
        public static Pextrd pextrd(AsmHexCode encoded) => new Pextrd(encoded);

        public struct Pextrq : IAsmInstruction<Pextrq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pextrq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRQ;

            public static implicit operator AsmMnemonicCode(Pextrq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pextrq src) => AsmMnemonics.PEXTRQ;
        }

        public static Pextrq pextrq() => default;

        [MethodImpl(Inline)]
        public static Pextrq pextrq(AsmHexCode encoded) => new Pextrq(encoded);

        public struct Vpextrb : IAsmInstruction<Vpextrb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpextrb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRB;

            public static implicit operator AsmMnemonicCode(Vpextrb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpextrb src) => AsmMnemonics.VPEXTRB;
        }

        public static Vpextrb vpextrb() => default;

        [MethodImpl(Inline)]
        public static Vpextrb vpextrb(AsmHexCode encoded) => new Vpextrb(encoded);

        public struct Vpextrd : IAsmInstruction<Vpextrd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpextrd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRD;

            public static implicit operator AsmMnemonicCode(Vpextrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpextrd src) => AsmMnemonics.VPEXTRD;
        }

        public static Vpextrd vpextrd() => default;

        [MethodImpl(Inline)]
        public static Vpextrd vpextrd(AsmHexCode encoded) => new Vpextrd(encoded);

        public struct Vpextrq : IAsmInstruction<Vpextrq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpextrq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRQ;

            public static implicit operator AsmMnemonicCode(Vpextrq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpextrq src) => AsmMnemonics.VPEXTRQ;
        }

        public static Vpextrq vpextrq() => default;

        [MethodImpl(Inline)]
        public static Vpextrq vpextrq(AsmHexCode encoded) => new Vpextrq(encoded);

        public struct Pextrw : IAsmInstruction<Pextrw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pextrw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRW;

            public static implicit operator AsmMnemonicCode(Pextrw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pextrw src) => AsmMnemonics.PEXTRW;
        }

        public static Pextrw pextrw() => default;

        [MethodImpl(Inline)]
        public static Pextrw pextrw(AsmHexCode encoded) => new Pextrw(encoded);

        public struct Vpextrw : IAsmInstruction<Vpextrw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpextrw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRW;

            public static implicit operator AsmMnemonicCode(Vpextrw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpextrw src) => AsmMnemonics.VPEXTRW;
        }

        public static Vpextrw vpextrw() => default;

        [MethodImpl(Inline)]
        public static Vpextrw vpextrw(AsmHexCode encoded) => new Vpextrw(encoded);

        public struct Phaddw : IAsmInstruction<Phaddw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Phaddw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHADDW;

            public static implicit operator AsmMnemonicCode(Phaddw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phaddw src) => AsmMnemonics.PHADDW;
        }

        public static Phaddw phaddw() => default;

        [MethodImpl(Inline)]
        public static Phaddw phaddw(AsmHexCode encoded) => new Phaddw(encoded);

        public struct Phaddd : IAsmInstruction<Phaddd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Phaddd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHADDD;

            public static implicit operator AsmMnemonicCode(Phaddd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phaddd src) => AsmMnemonics.PHADDD;
        }

        public static Phaddd phaddd() => default;

        [MethodImpl(Inline)]
        public static Phaddd phaddd(AsmHexCode encoded) => new Phaddd(encoded);

        public struct Vphaddw : IAsmInstruction<Vphaddw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vphaddw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHADDW;

            public static implicit operator AsmMnemonicCode(Vphaddw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphaddw src) => AsmMnemonics.VPHADDW;
        }

        public static Vphaddw vphaddw() => default;

        [MethodImpl(Inline)]
        public static Vphaddw vphaddw(AsmHexCode encoded) => new Vphaddw(encoded);

        public struct Vphaddd : IAsmInstruction<Vphaddd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vphaddd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHADDD;

            public static implicit operator AsmMnemonicCode(Vphaddd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphaddd src) => AsmMnemonics.VPHADDD;
        }

        public static Vphaddd vphaddd() => default;

        [MethodImpl(Inline)]
        public static Vphaddd vphaddd(AsmHexCode encoded) => new Vphaddd(encoded);

        public struct Phaddsw : IAsmInstruction<Phaddsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Phaddsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHADDSW;

            public static implicit operator AsmMnemonicCode(Phaddsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phaddsw src) => AsmMnemonics.PHADDSW;
        }

        public static Phaddsw phaddsw() => default;

        [MethodImpl(Inline)]
        public static Phaddsw phaddsw(AsmHexCode encoded) => new Phaddsw(encoded);

        public struct Vphaddsw : IAsmInstruction<Vphaddsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vphaddsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHADDSW;

            public static implicit operator AsmMnemonicCode(Vphaddsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphaddsw src) => AsmMnemonics.VPHADDSW;
        }

        public static Vphaddsw vphaddsw() => default;

        [MethodImpl(Inline)]
        public static Vphaddsw vphaddsw(AsmHexCode encoded) => new Vphaddsw(encoded);

        public struct Phminposuw : IAsmInstruction<Phminposuw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Phminposuw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHMINPOSUW;

            public static implicit operator AsmMnemonicCode(Phminposuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phminposuw src) => AsmMnemonics.PHMINPOSUW;
        }

        public static Phminposuw phminposuw() => default;

        [MethodImpl(Inline)]
        public static Phminposuw phminposuw(AsmHexCode encoded) => new Phminposuw(encoded);

        public struct Vphminposuw : IAsmInstruction<Vphminposuw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vphminposuw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHMINPOSUW;

            public static implicit operator AsmMnemonicCode(Vphminposuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphminposuw src) => AsmMnemonics.VPHMINPOSUW;
        }

        public static Vphminposuw vphminposuw() => default;

        [MethodImpl(Inline)]
        public static Vphminposuw vphminposuw(AsmHexCode encoded) => new Vphminposuw(encoded);

        public struct Phsubw : IAsmInstruction<Phsubw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Phsubw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHSUBW;

            public static implicit operator AsmMnemonicCode(Phsubw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phsubw src) => AsmMnemonics.PHSUBW;
        }

        public static Phsubw phsubw() => default;

        [MethodImpl(Inline)]
        public static Phsubw phsubw(AsmHexCode encoded) => new Phsubw(encoded);

        public struct Phsubd : IAsmInstruction<Phsubd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Phsubd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHSUBD;

            public static implicit operator AsmMnemonicCode(Phsubd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phsubd src) => AsmMnemonics.PHSUBD;
        }

        public static Phsubd phsubd() => default;

        [MethodImpl(Inline)]
        public static Phsubd phsubd(AsmHexCode encoded) => new Phsubd(encoded);

        public struct Vphsubw : IAsmInstruction<Vphsubw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vphsubw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHSUBW;

            public static implicit operator AsmMnemonicCode(Vphsubw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphsubw src) => AsmMnemonics.VPHSUBW;
        }

        public static Vphsubw vphsubw() => default;

        [MethodImpl(Inline)]
        public static Vphsubw vphsubw(AsmHexCode encoded) => new Vphsubw(encoded);

        public struct Vphsubd : IAsmInstruction<Vphsubd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vphsubd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHSUBD;

            public static implicit operator AsmMnemonicCode(Vphsubd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphsubd src) => AsmMnemonics.VPHSUBD;
        }

        public static Vphsubd vphsubd() => default;

        [MethodImpl(Inline)]
        public static Vphsubd vphsubd(AsmHexCode encoded) => new Vphsubd(encoded);

        public struct Phsubsw : IAsmInstruction<Phsubsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Phsubsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHSUBSW;

            public static implicit operator AsmMnemonicCode(Phsubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phsubsw src) => AsmMnemonics.PHSUBSW;
        }

        public static Phsubsw phsubsw() => default;

        [MethodImpl(Inline)]
        public static Phsubsw phsubsw(AsmHexCode encoded) => new Phsubsw(encoded);

        public struct Vphsubsw : IAsmInstruction<Vphsubsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vphsubsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHSUBSW;

            public static implicit operator AsmMnemonicCode(Vphsubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphsubsw src) => AsmMnemonics.VPHSUBSW;
        }

        public static Vphsubsw vphsubsw() => default;

        [MethodImpl(Inline)]
        public static Vphsubsw vphsubsw(AsmHexCode encoded) => new Vphsubsw(encoded);

        public struct Pinsrb : IAsmInstruction<Pinsrb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pinsrb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRB;

            public static implicit operator AsmMnemonicCode(Pinsrb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pinsrb src) => AsmMnemonics.PINSRB;
        }

        public static Pinsrb pinsrb() => default;

        [MethodImpl(Inline)]
        public static Pinsrb pinsrb(AsmHexCode encoded) => new Pinsrb(encoded);

        public struct Pinsrd : IAsmInstruction<Pinsrd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pinsrd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRD;

            public static implicit operator AsmMnemonicCode(Pinsrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pinsrd src) => AsmMnemonics.PINSRD;
        }

        public static Pinsrd pinsrd() => default;

        [MethodImpl(Inline)]
        public static Pinsrd pinsrd(AsmHexCode encoded) => new Pinsrd(encoded);

        public struct Pinsrq : IAsmInstruction<Pinsrq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pinsrq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRQ;

            public static implicit operator AsmMnemonicCode(Pinsrq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pinsrq src) => AsmMnemonics.PINSRQ;
        }

        public static Pinsrq pinsrq() => default;

        [MethodImpl(Inline)]
        public static Pinsrq pinsrq(AsmHexCode encoded) => new Pinsrq(encoded);

        public struct Vpinsrb : IAsmInstruction<Vpinsrb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpinsrb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRB;

            public static implicit operator AsmMnemonicCode(Vpinsrb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpinsrb src) => AsmMnemonics.VPINSRB;
        }

        public static Vpinsrb vpinsrb() => default;

        [MethodImpl(Inline)]
        public static Vpinsrb vpinsrb(AsmHexCode encoded) => new Vpinsrb(encoded);

        public struct Vpinsrd : IAsmInstruction<Vpinsrd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpinsrd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRD;

            public static implicit operator AsmMnemonicCode(Vpinsrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpinsrd src) => AsmMnemonics.VPINSRD;
        }

        public static Vpinsrd vpinsrd() => default;

        [MethodImpl(Inline)]
        public static Vpinsrd vpinsrd(AsmHexCode encoded) => new Vpinsrd(encoded);

        public struct Vpinsrq : IAsmInstruction<Vpinsrq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpinsrq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRQ;

            public static implicit operator AsmMnemonicCode(Vpinsrq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpinsrq src) => AsmMnemonics.VPINSRQ;
        }

        public static Vpinsrq vpinsrq() => default;

        [MethodImpl(Inline)]
        public static Vpinsrq vpinsrq(AsmHexCode encoded) => new Vpinsrq(encoded);

        public struct Pinsrw : IAsmInstruction<Pinsrw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pinsrw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRW;

            public static implicit operator AsmMnemonicCode(Pinsrw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pinsrw src) => AsmMnemonics.PINSRW;
        }

        public static Pinsrw pinsrw() => default;

        [MethodImpl(Inline)]
        public static Pinsrw pinsrw(AsmHexCode encoded) => new Pinsrw(encoded);

        public struct Vpinsrw : IAsmInstruction<Vpinsrw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpinsrw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRW;

            public static implicit operator AsmMnemonicCode(Vpinsrw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpinsrw src) => AsmMnemonics.VPINSRW;
        }

        public static Vpinsrw vpinsrw() => default;

        [MethodImpl(Inline)]
        public static Vpinsrw vpinsrw(AsmHexCode encoded) => new Vpinsrw(encoded);

        public struct Pmaddubsw : IAsmInstruction<Pmaddubsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmaddubsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMADDUBSW;

            public static implicit operator AsmMnemonicCode(Pmaddubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaddubsw src) => AsmMnemonics.PMADDUBSW;
        }

        public static Pmaddubsw pmaddubsw() => default;

        [MethodImpl(Inline)]
        public static Pmaddubsw pmaddubsw(AsmHexCode encoded) => new Pmaddubsw(encoded);

        public struct Vpmaddubsw : IAsmInstruction<Vpmaddubsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmaddubsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMADDUBSW;

            public static implicit operator AsmMnemonicCode(Vpmaddubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaddubsw src) => AsmMnemonics.VPMADDUBSW;
        }

        public static Vpmaddubsw vpmaddubsw() => default;

        [MethodImpl(Inline)]
        public static Vpmaddubsw vpmaddubsw(AsmHexCode encoded) => new Vpmaddubsw(encoded);

        public struct Pmaddwd : IAsmInstruction<Pmaddwd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmaddwd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMADDWD;

            public static implicit operator AsmMnemonicCode(Pmaddwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaddwd src) => AsmMnemonics.PMADDWD;
        }

        public static Pmaddwd pmaddwd() => default;

        [MethodImpl(Inline)]
        public static Pmaddwd pmaddwd(AsmHexCode encoded) => new Pmaddwd(encoded);

        public struct Vpmaddwd : IAsmInstruction<Vpmaddwd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmaddwd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMADDWD;

            public static implicit operator AsmMnemonicCode(Vpmaddwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaddwd src) => AsmMnemonics.VPMADDWD;
        }

        public static Vpmaddwd vpmaddwd() => default;

        [MethodImpl(Inline)]
        public static Vpmaddwd vpmaddwd(AsmHexCode encoded) => new Vpmaddwd(encoded);

        public struct Pmaxsb : IAsmInstruction<Pmaxsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmaxsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXSB;

            public static implicit operator AsmMnemonicCode(Pmaxsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxsb src) => AsmMnemonics.PMAXSB;
        }

        public static Pmaxsb pmaxsb() => default;

        [MethodImpl(Inline)]
        public static Pmaxsb pmaxsb(AsmHexCode encoded) => new Pmaxsb(encoded);

        public struct Vpmaxsb : IAsmInstruction<Vpmaxsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmaxsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXSB;

            public static implicit operator AsmMnemonicCode(Vpmaxsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxsb src) => AsmMnemonics.VPMAXSB;
        }

        public static Vpmaxsb vpmaxsb() => default;

        [MethodImpl(Inline)]
        public static Vpmaxsb vpmaxsb(AsmHexCode encoded) => new Vpmaxsb(encoded);

        public struct Pmaxsd : IAsmInstruction<Pmaxsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmaxsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXSD;

            public static implicit operator AsmMnemonicCode(Pmaxsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxsd src) => AsmMnemonics.PMAXSD;
        }

        public static Pmaxsd pmaxsd() => default;

        [MethodImpl(Inline)]
        public static Pmaxsd pmaxsd(AsmHexCode encoded) => new Pmaxsd(encoded);

        public struct Vpmaxsd : IAsmInstruction<Vpmaxsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmaxsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXSD;

            public static implicit operator AsmMnemonicCode(Vpmaxsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxsd src) => AsmMnemonics.VPMAXSD;
        }

        public static Vpmaxsd vpmaxsd() => default;

        [MethodImpl(Inline)]
        public static Vpmaxsd vpmaxsd(AsmHexCode encoded) => new Vpmaxsd(encoded);

        public struct Pmaxsw : IAsmInstruction<Pmaxsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmaxsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXSW;

            public static implicit operator AsmMnemonicCode(Pmaxsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxsw src) => AsmMnemonics.PMAXSW;
        }

        public static Pmaxsw pmaxsw() => default;

        [MethodImpl(Inline)]
        public static Pmaxsw pmaxsw(AsmHexCode encoded) => new Pmaxsw(encoded);

        public struct Vpmaxsw : IAsmInstruction<Vpmaxsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmaxsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXSW;

            public static implicit operator AsmMnemonicCode(Vpmaxsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxsw src) => AsmMnemonics.VPMAXSW;
        }

        public static Vpmaxsw vpmaxsw() => default;

        [MethodImpl(Inline)]
        public static Vpmaxsw vpmaxsw(AsmHexCode encoded) => new Vpmaxsw(encoded);

        public struct Pmaxub : IAsmInstruction<Pmaxub>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmaxub(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXUB;

            public static implicit operator AsmMnemonicCode(Pmaxub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxub src) => AsmMnemonics.PMAXUB;
        }

        public static Pmaxub pmaxub() => default;

        [MethodImpl(Inline)]
        public static Pmaxub pmaxub(AsmHexCode encoded) => new Pmaxub(encoded);

        public struct Vpmaxub : IAsmInstruction<Vpmaxub>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmaxub(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXUB;

            public static implicit operator AsmMnemonicCode(Vpmaxub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxub src) => AsmMnemonics.VPMAXUB;
        }

        public static Vpmaxub vpmaxub() => default;

        [MethodImpl(Inline)]
        public static Vpmaxub vpmaxub(AsmHexCode encoded) => new Vpmaxub(encoded);

        public struct Pmaxud : IAsmInstruction<Pmaxud>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmaxud(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXUD;

            public static implicit operator AsmMnemonicCode(Pmaxud src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxud src) => AsmMnemonics.PMAXUD;
        }

        public static Pmaxud pmaxud() => default;

        [MethodImpl(Inline)]
        public static Pmaxud pmaxud(AsmHexCode encoded) => new Pmaxud(encoded);

        public struct Vpmaxud : IAsmInstruction<Vpmaxud>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmaxud(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXUD;

            public static implicit operator AsmMnemonicCode(Vpmaxud src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxud src) => AsmMnemonics.VPMAXUD;
        }

        public static Vpmaxud vpmaxud() => default;

        [MethodImpl(Inline)]
        public static Vpmaxud vpmaxud(AsmHexCode encoded) => new Vpmaxud(encoded);

        public struct Pmaxuw : IAsmInstruction<Pmaxuw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmaxuw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXUW;

            public static implicit operator AsmMnemonicCode(Pmaxuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxuw src) => AsmMnemonics.PMAXUW;
        }

        public static Pmaxuw pmaxuw() => default;

        [MethodImpl(Inline)]
        public static Pmaxuw pmaxuw(AsmHexCode encoded) => new Pmaxuw(encoded);

        public struct Vpmaxuw : IAsmInstruction<Vpmaxuw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmaxuw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXUW;

            public static implicit operator AsmMnemonicCode(Vpmaxuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxuw src) => AsmMnemonics.VPMAXUW;
        }

        public static Vpmaxuw vpmaxuw() => default;

        [MethodImpl(Inline)]
        public static Vpmaxuw vpmaxuw(AsmHexCode encoded) => new Vpmaxuw(encoded);

        public struct Pminsb : IAsmInstruction<Pminsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pminsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINSB;

            public static implicit operator AsmMnemonicCode(Pminsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminsb src) => AsmMnemonics.PMINSB;
        }

        public static Pminsb pminsb() => default;

        [MethodImpl(Inline)]
        public static Pminsb pminsb(AsmHexCode encoded) => new Pminsb(encoded);

        public struct Vpminsb : IAsmInstruction<Vpminsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpminsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINSB;

            public static implicit operator AsmMnemonicCode(Vpminsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminsb src) => AsmMnemonics.VPMINSB;
        }

        public static Vpminsb vpminsb() => default;

        [MethodImpl(Inline)]
        public static Vpminsb vpminsb(AsmHexCode encoded) => new Vpminsb(encoded);

        public struct Pminsd : IAsmInstruction<Pminsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pminsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINSD;

            public static implicit operator AsmMnemonicCode(Pminsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminsd src) => AsmMnemonics.PMINSD;
        }

        public static Pminsd pminsd() => default;

        [MethodImpl(Inline)]
        public static Pminsd pminsd(AsmHexCode encoded) => new Pminsd(encoded);

        public struct Vpminsd : IAsmInstruction<Vpminsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpminsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINSD;

            public static implicit operator AsmMnemonicCode(Vpminsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminsd src) => AsmMnemonics.VPMINSD;
        }

        public static Vpminsd vpminsd() => default;

        [MethodImpl(Inline)]
        public static Vpminsd vpminsd(AsmHexCode encoded) => new Vpminsd(encoded);

        public struct Pminsw : IAsmInstruction<Pminsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pminsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINSW;

            public static implicit operator AsmMnemonicCode(Pminsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminsw src) => AsmMnemonics.PMINSW;
        }

        public static Pminsw pminsw() => default;

        [MethodImpl(Inline)]
        public static Pminsw pminsw(AsmHexCode encoded) => new Pminsw(encoded);

        public struct Vpminsw : IAsmInstruction<Vpminsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpminsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINSW;

            public static implicit operator AsmMnemonicCode(Vpminsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminsw src) => AsmMnemonics.VPMINSW;
        }

        public static Vpminsw vpminsw() => default;

        [MethodImpl(Inline)]
        public static Vpminsw vpminsw(AsmHexCode encoded) => new Vpminsw(encoded);

        public struct Pminub : IAsmInstruction<Pminub>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pminub(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINUB;

            public static implicit operator AsmMnemonicCode(Pminub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminub src) => AsmMnemonics.PMINUB;
        }

        public static Pminub pminub() => default;

        [MethodImpl(Inline)]
        public static Pminub pminub(AsmHexCode encoded) => new Pminub(encoded);

        public struct Vpminub : IAsmInstruction<Vpminub>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpminub(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINUB;

            public static implicit operator AsmMnemonicCode(Vpminub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminub src) => AsmMnemonics.VPMINUB;
        }

        public static Vpminub vpminub() => default;

        [MethodImpl(Inline)]
        public static Vpminub vpminub(AsmHexCode encoded) => new Vpminub(encoded);

        public struct Pminud : IAsmInstruction<Pminud>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pminud(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINUD;

            public static implicit operator AsmMnemonicCode(Pminud src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminud src) => AsmMnemonics.PMINUD;
        }

        public static Pminud pminud() => default;

        [MethodImpl(Inline)]
        public static Pminud pminud(AsmHexCode encoded) => new Pminud(encoded);

        public struct Vpminud : IAsmInstruction<Vpminud>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpminud(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINUD;

            public static implicit operator AsmMnemonicCode(Vpminud src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminud src) => AsmMnemonics.VPMINUD;
        }

        public static Vpminud vpminud() => default;

        [MethodImpl(Inline)]
        public static Vpminud vpminud(AsmHexCode encoded) => new Vpminud(encoded);

        public struct Pminuw : IAsmInstruction<Pminuw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pminuw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINUW;

            public static implicit operator AsmMnemonicCode(Pminuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminuw src) => AsmMnemonics.PMINUW;
        }

        public static Pminuw pminuw() => default;

        [MethodImpl(Inline)]
        public static Pminuw pminuw(AsmHexCode encoded) => new Pminuw(encoded);

        public struct Vpminuw : IAsmInstruction<Vpminuw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpminuw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINUW;

            public static implicit operator AsmMnemonicCode(Vpminuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminuw src) => AsmMnemonics.VPMINUW;
        }

        public static Vpminuw vpminuw() => default;

        [MethodImpl(Inline)]
        public static Vpminuw vpminuw(AsmHexCode encoded) => new Vpminuw(encoded);

        public struct Pmovmskb : IAsmInstruction<Pmovmskb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovmskb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVMSKB;

            public static implicit operator AsmMnemonicCode(Pmovmskb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovmskb src) => AsmMnemonics.PMOVMSKB;
        }

        public static Pmovmskb pmovmskb() => default;

        [MethodImpl(Inline)]
        public static Pmovmskb pmovmskb(AsmHexCode encoded) => new Pmovmskb(encoded);

        public struct Vpmovmskb : IAsmInstruction<Vpmovmskb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovmskb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVMSKB;

            public static implicit operator AsmMnemonicCode(Vpmovmskb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovmskb src) => AsmMnemonics.VPMOVMSKB;
        }

        public static Vpmovmskb vpmovmskb() => default;

        [MethodImpl(Inline)]
        public static Vpmovmskb vpmovmskb(AsmHexCode encoded) => new Vpmovmskb(encoded);

        public struct Pmovsxbw : IAsmInstruction<Pmovsxbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovsxbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXBW;

            public static implicit operator AsmMnemonicCode(Pmovsxbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxbw src) => AsmMnemonics.PMOVSXBW;
        }

        public static Pmovsxbw pmovsxbw() => default;

        [MethodImpl(Inline)]
        public static Pmovsxbw pmovsxbw(AsmHexCode encoded) => new Pmovsxbw(encoded);

        public struct Pmovsxbd : IAsmInstruction<Pmovsxbd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovsxbd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXBD;

            public static implicit operator AsmMnemonicCode(Pmovsxbd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxbd src) => AsmMnemonics.PMOVSXBD;
        }

        public static Pmovsxbd pmovsxbd() => default;

        [MethodImpl(Inline)]
        public static Pmovsxbd pmovsxbd(AsmHexCode encoded) => new Pmovsxbd(encoded);

        public struct Pmovsxbq : IAsmInstruction<Pmovsxbq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovsxbq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXBQ;

            public static implicit operator AsmMnemonicCode(Pmovsxbq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxbq src) => AsmMnemonics.PMOVSXBQ;
        }

        public static Pmovsxbq pmovsxbq() => default;

        [MethodImpl(Inline)]
        public static Pmovsxbq pmovsxbq(AsmHexCode encoded) => new Pmovsxbq(encoded);

        public struct Pmovsxwd : IAsmInstruction<Pmovsxwd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovsxwd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXWD;

            public static implicit operator AsmMnemonicCode(Pmovsxwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxwd src) => AsmMnemonics.PMOVSXWD;
        }

        public static Pmovsxwd pmovsxwd() => default;

        [MethodImpl(Inline)]
        public static Pmovsxwd pmovsxwd(AsmHexCode encoded) => new Pmovsxwd(encoded);

        public struct Pmovsxwq : IAsmInstruction<Pmovsxwq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovsxwq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXWQ;

            public static implicit operator AsmMnemonicCode(Pmovsxwq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxwq src) => AsmMnemonics.PMOVSXWQ;
        }

        public static Pmovsxwq pmovsxwq() => default;

        [MethodImpl(Inline)]
        public static Pmovsxwq pmovsxwq(AsmHexCode encoded) => new Pmovsxwq(encoded);

        public struct Pmovsxdq : IAsmInstruction<Pmovsxdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovsxdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXDQ;

            public static implicit operator AsmMnemonicCode(Pmovsxdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxdq src) => AsmMnemonics.PMOVSXDQ;
        }

        public static Pmovsxdq pmovsxdq() => default;

        [MethodImpl(Inline)]
        public static Pmovsxdq pmovsxdq(AsmHexCode encoded) => new Pmovsxdq(encoded);

        public struct Vpmovsxbw : IAsmInstruction<Vpmovsxbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovsxbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXBW;

            public static implicit operator AsmMnemonicCode(Vpmovsxbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxbw src) => AsmMnemonics.VPMOVSXBW;
        }

        public static Vpmovsxbw vpmovsxbw() => default;

        [MethodImpl(Inline)]
        public static Vpmovsxbw vpmovsxbw(AsmHexCode encoded) => new Vpmovsxbw(encoded);

        public struct Vpmovsxbd : IAsmInstruction<Vpmovsxbd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovsxbd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXBD;

            public static implicit operator AsmMnemonicCode(Vpmovsxbd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxbd src) => AsmMnemonics.VPMOVSXBD;
        }

        public static Vpmovsxbd vpmovsxbd() => default;

        [MethodImpl(Inline)]
        public static Vpmovsxbd vpmovsxbd(AsmHexCode encoded) => new Vpmovsxbd(encoded);

        public struct Vpmovsxbq : IAsmInstruction<Vpmovsxbq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovsxbq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXBQ;

            public static implicit operator AsmMnemonicCode(Vpmovsxbq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxbq src) => AsmMnemonics.VPMOVSXBQ;
        }

        public static Vpmovsxbq vpmovsxbq() => default;

        [MethodImpl(Inline)]
        public static Vpmovsxbq vpmovsxbq(AsmHexCode encoded) => new Vpmovsxbq(encoded);

        public struct Vpmovsxwd : IAsmInstruction<Vpmovsxwd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovsxwd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXWD;

            public static implicit operator AsmMnemonicCode(Vpmovsxwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxwd src) => AsmMnemonics.VPMOVSXWD;
        }

        public static Vpmovsxwd vpmovsxwd() => default;

        [MethodImpl(Inline)]
        public static Vpmovsxwd vpmovsxwd(AsmHexCode encoded) => new Vpmovsxwd(encoded);

        public struct Vpmovsxwq : IAsmInstruction<Vpmovsxwq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovsxwq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXWQ;

            public static implicit operator AsmMnemonicCode(Vpmovsxwq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxwq src) => AsmMnemonics.VPMOVSXWQ;
        }

        public static Vpmovsxwq vpmovsxwq() => default;

        [MethodImpl(Inline)]
        public static Vpmovsxwq vpmovsxwq(AsmHexCode encoded) => new Vpmovsxwq(encoded);

        public struct Vpmovsxdq : IAsmInstruction<Vpmovsxdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovsxdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXDQ;

            public static implicit operator AsmMnemonicCode(Vpmovsxdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxdq src) => AsmMnemonics.VPMOVSXDQ;
        }

        public static Vpmovsxdq vpmovsxdq() => default;

        [MethodImpl(Inline)]
        public static Vpmovsxdq vpmovsxdq(AsmHexCode encoded) => new Vpmovsxdq(encoded);

        public struct Pmovzxbw : IAsmInstruction<Pmovzxbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovzxbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXBW;

            public static implicit operator AsmMnemonicCode(Pmovzxbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxbw src) => AsmMnemonics.PMOVZXBW;
        }

        public static Pmovzxbw pmovzxbw() => default;

        [MethodImpl(Inline)]
        public static Pmovzxbw pmovzxbw(AsmHexCode encoded) => new Pmovzxbw(encoded);

        public struct Pmovzxbd : IAsmInstruction<Pmovzxbd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovzxbd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXBD;

            public static implicit operator AsmMnemonicCode(Pmovzxbd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxbd src) => AsmMnemonics.PMOVZXBD;
        }

        public static Pmovzxbd pmovzxbd() => default;

        [MethodImpl(Inline)]
        public static Pmovzxbd pmovzxbd(AsmHexCode encoded) => new Pmovzxbd(encoded);

        public struct Pmovzxbq : IAsmInstruction<Pmovzxbq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovzxbq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXBQ;

            public static implicit operator AsmMnemonicCode(Pmovzxbq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxbq src) => AsmMnemonics.PMOVZXBQ;
        }

        public static Pmovzxbq pmovzxbq() => default;

        [MethodImpl(Inline)]
        public static Pmovzxbq pmovzxbq(AsmHexCode encoded) => new Pmovzxbq(encoded);

        public struct Pmovzxwd : IAsmInstruction<Pmovzxwd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovzxwd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXWD;

            public static implicit operator AsmMnemonicCode(Pmovzxwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxwd src) => AsmMnemonics.PMOVZXWD;
        }

        public static Pmovzxwd pmovzxwd() => default;

        [MethodImpl(Inline)]
        public static Pmovzxwd pmovzxwd(AsmHexCode encoded) => new Pmovzxwd(encoded);

        public struct Pmovzxwq : IAsmInstruction<Pmovzxwq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovzxwq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXWQ;

            public static implicit operator AsmMnemonicCode(Pmovzxwq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxwq src) => AsmMnemonics.PMOVZXWQ;
        }

        public static Pmovzxwq pmovzxwq() => default;

        [MethodImpl(Inline)]
        public static Pmovzxwq pmovzxwq(AsmHexCode encoded) => new Pmovzxwq(encoded);

        public struct Pmovzxdq : IAsmInstruction<Pmovzxdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmovzxdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXDQ;

            public static implicit operator AsmMnemonicCode(Pmovzxdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxdq src) => AsmMnemonics.PMOVZXDQ;
        }

        public static Pmovzxdq pmovzxdq() => default;

        [MethodImpl(Inline)]
        public static Pmovzxdq pmovzxdq(AsmHexCode encoded) => new Pmovzxdq(encoded);

        public struct Vpmovzxbw : IAsmInstruction<Vpmovzxbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovzxbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXBW;

            public static implicit operator AsmMnemonicCode(Vpmovzxbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxbw src) => AsmMnemonics.VPMOVZXBW;
        }

        public static Vpmovzxbw vpmovzxbw() => default;

        [MethodImpl(Inline)]
        public static Vpmovzxbw vpmovzxbw(AsmHexCode encoded) => new Vpmovzxbw(encoded);

        public struct Vpmovzxbd : IAsmInstruction<Vpmovzxbd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovzxbd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXBD;

            public static implicit operator AsmMnemonicCode(Vpmovzxbd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxbd src) => AsmMnemonics.VPMOVZXBD;
        }

        public static Vpmovzxbd vpmovzxbd() => default;

        [MethodImpl(Inline)]
        public static Vpmovzxbd vpmovzxbd(AsmHexCode encoded) => new Vpmovzxbd(encoded);

        public struct Vpmovzxbq : IAsmInstruction<Vpmovzxbq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovzxbq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXBQ;

            public static implicit operator AsmMnemonicCode(Vpmovzxbq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxbq src) => AsmMnemonics.VPMOVZXBQ;
        }

        public static Vpmovzxbq vpmovzxbq() => default;

        [MethodImpl(Inline)]
        public static Vpmovzxbq vpmovzxbq(AsmHexCode encoded) => new Vpmovzxbq(encoded);

        public struct Vpmovzxwd : IAsmInstruction<Vpmovzxwd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovzxwd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXWD;

            public static implicit operator AsmMnemonicCode(Vpmovzxwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxwd src) => AsmMnemonics.VPMOVZXWD;
        }

        public static Vpmovzxwd vpmovzxwd() => default;

        [MethodImpl(Inline)]
        public static Vpmovzxwd vpmovzxwd(AsmHexCode encoded) => new Vpmovzxwd(encoded);

        public struct Vpmovzxwq : IAsmInstruction<Vpmovzxwq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovzxwq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXWQ;

            public static implicit operator AsmMnemonicCode(Vpmovzxwq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxwq src) => AsmMnemonics.VPMOVZXWQ;
        }

        public static Vpmovzxwq vpmovzxwq() => default;

        [MethodImpl(Inline)]
        public static Vpmovzxwq vpmovzxwq(AsmHexCode encoded) => new Vpmovzxwq(encoded);

        public struct Vpmovzxdq : IAsmInstruction<Vpmovzxdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmovzxdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXDQ;

            public static implicit operator AsmMnemonicCode(Vpmovzxdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxdq src) => AsmMnemonics.VPMOVZXDQ;
        }

        public static Vpmovzxdq vpmovzxdq() => default;

        [MethodImpl(Inline)]
        public static Vpmovzxdq vpmovzxdq(AsmHexCode encoded) => new Vpmovzxdq(encoded);

        public struct Pmuldq : IAsmInstruction<Pmuldq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmuldq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULDQ;

            public static implicit operator AsmMnemonicCode(Pmuldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmuldq src) => AsmMnemonics.PMULDQ;
        }

        public static Pmuldq pmuldq() => default;

        [MethodImpl(Inline)]
        public static Pmuldq pmuldq(AsmHexCode encoded) => new Pmuldq(encoded);

        public struct Vpmuldq : IAsmInstruction<Vpmuldq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmuldq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULDQ;

            public static implicit operator AsmMnemonicCode(Vpmuldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmuldq src) => AsmMnemonics.VPMULDQ;
        }

        public static Vpmuldq vpmuldq() => default;

        [MethodImpl(Inline)]
        public static Vpmuldq vpmuldq(AsmHexCode encoded) => new Vpmuldq(encoded);

        public struct Pmulhrsw : IAsmInstruction<Pmulhrsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmulhrsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULHRSW;

            public static implicit operator AsmMnemonicCode(Pmulhrsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmulhrsw src) => AsmMnemonics.PMULHRSW;
        }

        public static Pmulhrsw pmulhrsw() => default;

        [MethodImpl(Inline)]
        public static Pmulhrsw pmulhrsw(AsmHexCode encoded) => new Pmulhrsw(encoded);

        public struct Vpmulhrsw : IAsmInstruction<Vpmulhrsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmulhrsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULHRSW;

            public static implicit operator AsmMnemonicCode(Vpmulhrsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmulhrsw src) => AsmMnemonics.VPMULHRSW;
        }

        public static Vpmulhrsw vpmulhrsw() => default;

        [MethodImpl(Inline)]
        public static Vpmulhrsw vpmulhrsw(AsmHexCode encoded) => new Vpmulhrsw(encoded);

        public struct Pmulhuw : IAsmInstruction<Pmulhuw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmulhuw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULHUW;

            public static implicit operator AsmMnemonicCode(Pmulhuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmulhuw src) => AsmMnemonics.PMULHUW;
        }

        public static Pmulhuw pmulhuw() => default;

        [MethodImpl(Inline)]
        public static Pmulhuw pmulhuw(AsmHexCode encoded) => new Pmulhuw(encoded);

        public struct Vpmulhuw : IAsmInstruction<Vpmulhuw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmulhuw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULHUW;

            public static implicit operator AsmMnemonicCode(Vpmulhuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmulhuw src) => AsmMnemonics.VPMULHUW;
        }

        public static Vpmulhuw vpmulhuw() => default;

        [MethodImpl(Inline)]
        public static Vpmulhuw vpmulhuw(AsmHexCode encoded) => new Vpmulhuw(encoded);

        public struct Pmulhw : IAsmInstruction<Pmulhw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmulhw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULHW;

            public static implicit operator AsmMnemonicCode(Pmulhw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmulhw src) => AsmMnemonics.PMULHW;
        }

        public static Pmulhw pmulhw() => default;

        [MethodImpl(Inline)]
        public static Pmulhw pmulhw(AsmHexCode encoded) => new Pmulhw(encoded);

        public struct Vpmulhw : IAsmInstruction<Vpmulhw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmulhw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULHW;

            public static implicit operator AsmMnemonicCode(Vpmulhw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmulhw src) => AsmMnemonics.VPMULHW;
        }

        public static Vpmulhw vpmulhw() => default;

        [MethodImpl(Inline)]
        public static Vpmulhw vpmulhw(AsmHexCode encoded) => new Vpmulhw(encoded);

        public struct Pmulld : IAsmInstruction<Pmulld>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmulld(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULLD;

            public static implicit operator AsmMnemonicCode(Pmulld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmulld src) => AsmMnemonics.PMULLD;
        }

        public static Pmulld pmulld() => default;

        [MethodImpl(Inline)]
        public static Pmulld pmulld(AsmHexCode encoded) => new Pmulld(encoded);

        public struct Vpmulld : IAsmInstruction<Vpmulld>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmulld(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULLD;

            public static implicit operator AsmMnemonicCode(Vpmulld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmulld src) => AsmMnemonics.VPMULLD;
        }

        public static Vpmulld vpmulld() => default;

        [MethodImpl(Inline)]
        public static Vpmulld vpmulld(AsmHexCode encoded) => new Vpmulld(encoded);

        public struct Pmullw : IAsmInstruction<Pmullw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmullw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULLW;

            public static implicit operator AsmMnemonicCode(Pmullw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmullw src) => AsmMnemonics.PMULLW;
        }

        public static Pmullw pmullw() => default;

        [MethodImpl(Inline)]
        public static Pmullw pmullw(AsmHexCode encoded) => new Pmullw(encoded);

        public struct Vpmullw : IAsmInstruction<Vpmullw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmullw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULLW;

            public static implicit operator AsmMnemonicCode(Vpmullw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmullw src) => AsmMnemonics.VPMULLW;
        }

        public static Vpmullw vpmullw() => default;

        [MethodImpl(Inline)]
        public static Vpmullw vpmullw(AsmHexCode encoded) => new Vpmullw(encoded);

        public struct Pmuludq : IAsmInstruction<Pmuludq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pmuludq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULUDQ;

            public static implicit operator AsmMnemonicCode(Pmuludq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmuludq src) => AsmMnemonics.PMULUDQ;
        }

        public static Pmuludq pmuludq() => default;

        [MethodImpl(Inline)]
        public static Pmuludq pmuludq(AsmHexCode encoded) => new Pmuludq(encoded);

        public struct Vpmuludq : IAsmInstruction<Vpmuludq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmuludq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULUDQ;

            public static implicit operator AsmMnemonicCode(Vpmuludq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmuludq src) => AsmMnemonics.VPMULUDQ;
        }

        public static Vpmuludq vpmuludq() => default;

        [MethodImpl(Inline)]
        public static Vpmuludq vpmuludq(AsmHexCode encoded) => new Vpmuludq(encoded);

        public struct Pop : IAsmInstruction<Pop>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pop(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POP;

            public static implicit operator AsmMnemonicCode(Pop src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pop src) => AsmMnemonics.POP;
        }

        public static Pop pop() => default;

        [MethodImpl(Inline)]
        public static Pop pop(AsmHexCode encoded) => new Pop(encoded);

        public struct Popa : IAsmInstruction<Popa>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Popa(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPA;

            public static implicit operator AsmMnemonicCode(Popa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popa src) => AsmMnemonics.POPA;
        }

        public static Popa popa() => default;

        [MethodImpl(Inline)]
        public static Popa popa(AsmHexCode encoded) => new Popa(encoded);

        public struct Popad : IAsmInstruction<Popad>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Popad(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPAD;

            public static implicit operator AsmMnemonicCode(Popad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popad src) => AsmMnemonics.POPAD;
        }

        public static Popad popad() => default;

        [MethodImpl(Inline)]
        public static Popad popad(AsmHexCode encoded) => new Popad(encoded);

        public struct Popcnt : IAsmInstruction<Popcnt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Popcnt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPCNT;

            public static implicit operator AsmMnemonicCode(Popcnt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popcnt src) => AsmMnemonics.POPCNT;
        }

        public static Popcnt popcnt() => default;

        [MethodImpl(Inline)]
        public static Popcnt popcnt(AsmHexCode encoded) => new Popcnt(encoded);

        public struct Popf : IAsmInstruction<Popf>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Popf(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPF;

            public static implicit operator AsmMnemonicCode(Popf src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popf src) => AsmMnemonics.POPF;
        }

        public static Popf popf() => default;

        [MethodImpl(Inline)]
        public static Popf popf(AsmHexCode encoded) => new Popf(encoded);

        public struct Popfd : IAsmInstruction<Popfd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Popfd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPFD;

            public static implicit operator AsmMnemonicCode(Popfd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popfd src) => AsmMnemonics.POPFD;
        }

        public static Popfd popfd() => default;

        [MethodImpl(Inline)]
        public static Popfd popfd(AsmHexCode encoded) => new Popfd(encoded);

        public struct Popfq : IAsmInstruction<Popfq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Popfq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPFQ;

            public static implicit operator AsmMnemonicCode(Popfq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popfq src) => AsmMnemonics.POPFQ;
        }

        public static Popfq popfq() => default;

        [MethodImpl(Inline)]
        public static Popfq popfq(AsmHexCode encoded) => new Popfq(encoded);

        public struct Por : IAsmInstruction<Por>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Por(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POR;

            public static implicit operator AsmMnemonicCode(Por src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Por src) => AsmMnemonics.POR;
        }

        public static Por por() => default;

        [MethodImpl(Inline)]
        public static Por por(AsmHexCode encoded) => new Por(encoded);

        public struct Vpor : IAsmInstruction<Vpor>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpor(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPOR;

            public static implicit operator AsmMnemonicCode(Vpor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpor src) => AsmMnemonics.VPOR;
        }

        public static Vpor vpor() => default;

        [MethodImpl(Inline)]
        public static Vpor vpor(AsmHexCode encoded) => new Vpor(encoded);

        public struct Prefetcht0 : IAsmInstruction<Prefetcht0>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Prefetcht0(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHT0;

            public static implicit operator AsmMnemonicCode(Prefetcht0 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Prefetcht0 src) => AsmMnemonics.PREFETCHT0;
        }

        public static Prefetcht0 prefetcht0() => default;

        [MethodImpl(Inline)]
        public static Prefetcht0 prefetcht0(AsmHexCode encoded) => new Prefetcht0(encoded);

        public struct Prefetcht1 : IAsmInstruction<Prefetcht1>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Prefetcht1(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHT1;

            public static implicit operator AsmMnemonicCode(Prefetcht1 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Prefetcht1 src) => AsmMnemonics.PREFETCHT1;
        }

        public static Prefetcht1 prefetcht1() => default;

        [MethodImpl(Inline)]
        public static Prefetcht1 prefetcht1(AsmHexCode encoded) => new Prefetcht1(encoded);

        public struct Prefetcht2 : IAsmInstruction<Prefetcht2>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Prefetcht2(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHT2;

            public static implicit operator AsmMnemonicCode(Prefetcht2 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Prefetcht2 src) => AsmMnemonics.PREFETCHT2;
        }

        public static Prefetcht2 prefetcht2() => default;

        [MethodImpl(Inline)]
        public static Prefetcht2 prefetcht2(AsmHexCode encoded) => new Prefetcht2(encoded);

        public struct Prefetchnta : IAsmInstruction<Prefetchnta>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Prefetchnta(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHNTA;

            public static implicit operator AsmMnemonicCode(Prefetchnta src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Prefetchnta src) => AsmMnemonics.PREFETCHNTA;
        }

        public static Prefetchnta prefetchnta() => default;

        [MethodImpl(Inline)]
        public static Prefetchnta prefetchnta(AsmHexCode encoded) => new Prefetchnta(encoded);

        public struct Psadbw : IAsmInstruction<Psadbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psadbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSADBW;

            public static implicit operator AsmMnemonicCode(Psadbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psadbw src) => AsmMnemonics.PSADBW;
        }

        public static Psadbw psadbw() => default;

        [MethodImpl(Inline)]
        public static Psadbw psadbw(AsmHexCode encoded) => new Psadbw(encoded);

        public struct Vpsadbw : IAsmInstruction<Vpsadbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsadbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSADBW;

            public static implicit operator AsmMnemonicCode(Vpsadbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsadbw src) => AsmMnemonics.VPSADBW;
        }

        public static Vpsadbw vpsadbw() => default;

        [MethodImpl(Inline)]
        public static Vpsadbw vpsadbw(AsmHexCode encoded) => new Vpsadbw(encoded);

        public struct Pshufb : IAsmInstruction<Pshufb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pshufb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFB;

            public static implicit operator AsmMnemonicCode(Pshufb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshufb src) => AsmMnemonics.PSHUFB;
        }

        public static Pshufb pshufb() => default;

        [MethodImpl(Inline)]
        public static Pshufb pshufb(AsmHexCode encoded) => new Pshufb(encoded);

        public struct Vpshufb : IAsmInstruction<Vpshufb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpshufb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFB;

            public static implicit operator AsmMnemonicCode(Vpshufb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpshufb src) => AsmMnemonics.VPSHUFB;
        }

        public static Vpshufb vpshufb() => default;

        [MethodImpl(Inline)]
        public static Vpshufb vpshufb(AsmHexCode encoded) => new Vpshufb(encoded);

        public struct Pshufd : IAsmInstruction<Pshufd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pshufd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFD;

            public static implicit operator AsmMnemonicCode(Pshufd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshufd src) => AsmMnemonics.PSHUFD;
        }

        public static Pshufd pshufd() => default;

        [MethodImpl(Inline)]
        public static Pshufd pshufd(AsmHexCode encoded) => new Pshufd(encoded);

        public struct Vpshufd : IAsmInstruction<Vpshufd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpshufd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFD;

            public static implicit operator AsmMnemonicCode(Vpshufd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpshufd src) => AsmMnemonics.VPSHUFD;
        }

        public static Vpshufd vpshufd() => default;

        [MethodImpl(Inline)]
        public static Vpshufd vpshufd(AsmHexCode encoded) => new Vpshufd(encoded);

        public struct Pshufhw : IAsmInstruction<Pshufhw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pshufhw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFHW;

            public static implicit operator AsmMnemonicCode(Pshufhw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshufhw src) => AsmMnemonics.PSHUFHW;
        }

        public static Pshufhw pshufhw() => default;

        [MethodImpl(Inline)]
        public static Pshufhw pshufhw(AsmHexCode encoded) => new Pshufhw(encoded);

        public struct Vpshufhw : IAsmInstruction<Vpshufhw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpshufhw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFHW;

            public static implicit operator AsmMnemonicCode(Vpshufhw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpshufhw src) => AsmMnemonics.VPSHUFHW;
        }

        public static Vpshufhw vpshufhw() => default;

        [MethodImpl(Inline)]
        public static Vpshufhw vpshufhw(AsmHexCode encoded) => new Vpshufhw(encoded);

        public struct Pshuflw : IAsmInstruction<Pshuflw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pshuflw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFLW;

            public static implicit operator AsmMnemonicCode(Pshuflw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshuflw src) => AsmMnemonics.PSHUFLW;
        }

        public static Pshuflw pshuflw() => default;

        [MethodImpl(Inline)]
        public static Pshuflw pshuflw(AsmHexCode encoded) => new Pshuflw(encoded);

        public struct Vpshuflw : IAsmInstruction<Vpshuflw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpshuflw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFLW;

            public static implicit operator AsmMnemonicCode(Vpshuflw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpshuflw src) => AsmMnemonics.VPSHUFLW;
        }

        public static Vpshuflw vpshuflw() => default;

        [MethodImpl(Inline)]
        public static Vpshuflw vpshuflw(AsmHexCode encoded) => new Vpshuflw(encoded);

        public struct Pshufw : IAsmInstruction<Pshufw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pshufw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFW;

            public static implicit operator AsmMnemonicCode(Pshufw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshufw src) => AsmMnemonics.PSHUFW;
        }

        public static Pshufw pshufw() => default;

        [MethodImpl(Inline)]
        public static Pshufw pshufw(AsmHexCode encoded) => new Pshufw(encoded);

        public struct Psignb : IAsmInstruction<Psignb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psignb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSIGNB;

            public static implicit operator AsmMnemonicCode(Psignb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psignb src) => AsmMnemonics.PSIGNB;
        }

        public static Psignb psignb() => default;

        [MethodImpl(Inline)]
        public static Psignb psignb(AsmHexCode encoded) => new Psignb(encoded);

        public struct Psignw : IAsmInstruction<Psignw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psignw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSIGNW;

            public static implicit operator AsmMnemonicCode(Psignw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psignw src) => AsmMnemonics.PSIGNW;
        }

        public static Psignw psignw() => default;

        [MethodImpl(Inline)]
        public static Psignw psignw(AsmHexCode encoded) => new Psignw(encoded);

        public struct Psignd : IAsmInstruction<Psignd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psignd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSIGND;

            public static implicit operator AsmMnemonicCode(Psignd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psignd src) => AsmMnemonics.PSIGND;
        }

        public static Psignd psignd() => default;

        [MethodImpl(Inline)]
        public static Psignd psignd(AsmHexCode encoded) => new Psignd(encoded);

        public struct Vpsignb : IAsmInstruction<Vpsignb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsignb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSIGNB;

            public static implicit operator AsmMnemonicCode(Vpsignb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsignb src) => AsmMnemonics.VPSIGNB;
        }

        public static Vpsignb vpsignb() => default;

        [MethodImpl(Inline)]
        public static Vpsignb vpsignb(AsmHexCode encoded) => new Vpsignb(encoded);

        public struct Vpsignw : IAsmInstruction<Vpsignw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsignw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSIGNW;

            public static implicit operator AsmMnemonicCode(Vpsignw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsignw src) => AsmMnemonics.VPSIGNW;
        }

        public static Vpsignw vpsignw() => default;

        [MethodImpl(Inline)]
        public static Vpsignw vpsignw(AsmHexCode encoded) => new Vpsignw(encoded);

        public struct Vpsignd : IAsmInstruction<Vpsignd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsignd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSIGND;

            public static implicit operator AsmMnemonicCode(Vpsignd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsignd src) => AsmMnemonics.VPSIGND;
        }

        public static Vpsignd vpsignd() => default;

        [MethodImpl(Inline)]
        public static Vpsignd vpsignd(AsmHexCode encoded) => new Vpsignd(encoded);

        public struct Pslldq : IAsmInstruction<Pslldq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pslldq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLDQ;

            public static implicit operator AsmMnemonicCode(Pslldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pslldq src) => AsmMnemonics.PSLLDQ;
        }

        public static Pslldq pslldq() => default;

        [MethodImpl(Inline)]
        public static Pslldq pslldq(AsmHexCode encoded) => new Pslldq(encoded);

        public struct Vpslldq : IAsmInstruction<Vpslldq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpslldq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLDQ;

            public static implicit operator AsmMnemonicCode(Vpslldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpslldq src) => AsmMnemonics.VPSLLDQ;
        }

        public static Vpslldq vpslldq() => default;

        [MethodImpl(Inline)]
        public static Vpslldq vpslldq(AsmHexCode encoded) => new Vpslldq(encoded);

        public struct Psllw : IAsmInstruction<Psllw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psllw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLW;

            public static implicit operator AsmMnemonicCode(Psllw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psllw src) => AsmMnemonics.PSLLW;
        }

        public static Psllw psllw() => default;

        [MethodImpl(Inline)]
        public static Psllw psllw(AsmHexCode encoded) => new Psllw(encoded);

        public struct Pslld : IAsmInstruction<Pslld>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pslld(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLD;

            public static implicit operator AsmMnemonicCode(Pslld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pslld src) => AsmMnemonics.PSLLD;
        }

        public static Pslld pslld() => default;

        [MethodImpl(Inline)]
        public static Pslld pslld(AsmHexCode encoded) => new Pslld(encoded);

        public struct Psllq : IAsmInstruction<Psllq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psllq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLQ;

            public static implicit operator AsmMnemonicCode(Psllq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psllq src) => AsmMnemonics.PSLLQ;
        }

        public static Psllq psllq() => default;

        [MethodImpl(Inline)]
        public static Psllq psllq(AsmHexCode encoded) => new Psllq(encoded);

        public struct Vpsllw : IAsmInstruction<Vpsllw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsllw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLW;

            public static implicit operator AsmMnemonicCode(Vpsllw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsllw src) => AsmMnemonics.VPSLLW;
        }

        public static Vpsllw vpsllw() => default;

        [MethodImpl(Inline)]
        public static Vpsllw vpsllw(AsmHexCode encoded) => new Vpsllw(encoded);

        public struct Vpslld : IAsmInstruction<Vpslld>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpslld(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLD;

            public static implicit operator AsmMnemonicCode(Vpslld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpslld src) => AsmMnemonics.VPSLLD;
        }

        public static Vpslld vpslld() => default;

        [MethodImpl(Inline)]
        public static Vpslld vpslld(AsmHexCode encoded) => new Vpslld(encoded);

        public struct Vpsllq : IAsmInstruction<Vpsllq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsllq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLQ;

            public static implicit operator AsmMnemonicCode(Vpsllq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsllq src) => AsmMnemonics.VPSLLQ;
        }

        public static Vpsllq vpsllq() => default;

        [MethodImpl(Inline)]
        public static Vpsllq vpsllq(AsmHexCode encoded) => new Vpsllq(encoded);

        public struct Psraw : IAsmInstruction<Psraw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psraw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRAW;

            public static implicit operator AsmMnemonicCode(Psraw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psraw src) => AsmMnemonics.PSRAW;
        }

        public static Psraw psraw() => default;

        [MethodImpl(Inline)]
        public static Psraw psraw(AsmHexCode encoded) => new Psraw(encoded);

        public struct Psrad : IAsmInstruction<Psrad>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psrad(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRAD;

            public static implicit operator AsmMnemonicCode(Psrad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrad src) => AsmMnemonics.PSRAD;
        }

        public static Psrad psrad() => default;

        [MethodImpl(Inline)]
        public static Psrad psrad(AsmHexCode encoded) => new Psrad(encoded);

        public struct Vpsraw : IAsmInstruction<Vpsraw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsraw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRAW;

            public static implicit operator AsmMnemonicCode(Vpsraw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsraw src) => AsmMnemonics.VPSRAW;
        }

        public static Vpsraw vpsraw() => default;

        [MethodImpl(Inline)]
        public static Vpsraw vpsraw(AsmHexCode encoded) => new Vpsraw(encoded);

        public struct Vpsrad : IAsmInstruction<Vpsrad>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsrad(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRAD;

            public static implicit operator AsmMnemonicCode(Vpsrad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrad src) => AsmMnemonics.VPSRAD;
        }

        public static Vpsrad vpsrad() => default;

        [MethodImpl(Inline)]
        public static Vpsrad vpsrad(AsmHexCode encoded) => new Vpsrad(encoded);

        public struct Psrldq : IAsmInstruction<Psrldq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psrldq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLDQ;

            public static implicit operator AsmMnemonicCode(Psrldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrldq src) => AsmMnemonics.PSRLDQ;
        }

        public static Psrldq psrldq() => default;

        [MethodImpl(Inline)]
        public static Psrldq psrldq(AsmHexCode encoded) => new Psrldq(encoded);

        public struct Vpsrldq : IAsmInstruction<Vpsrldq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsrldq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLDQ;

            public static implicit operator AsmMnemonicCode(Vpsrldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrldq src) => AsmMnemonics.VPSRLDQ;
        }

        public static Vpsrldq vpsrldq() => default;

        [MethodImpl(Inline)]
        public static Vpsrldq vpsrldq(AsmHexCode encoded) => new Vpsrldq(encoded);

        public struct Psrlw : IAsmInstruction<Psrlw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psrlw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLW;

            public static implicit operator AsmMnemonicCode(Psrlw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrlw src) => AsmMnemonics.PSRLW;
        }

        public static Psrlw psrlw() => default;

        [MethodImpl(Inline)]
        public static Psrlw psrlw(AsmHexCode encoded) => new Psrlw(encoded);

        public struct Psrld : IAsmInstruction<Psrld>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psrld(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLD;

            public static implicit operator AsmMnemonicCode(Psrld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrld src) => AsmMnemonics.PSRLD;
        }

        public static Psrld psrld() => default;

        [MethodImpl(Inline)]
        public static Psrld psrld(AsmHexCode encoded) => new Psrld(encoded);

        public struct Psrlq : IAsmInstruction<Psrlq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psrlq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLQ;

            public static implicit operator AsmMnemonicCode(Psrlq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrlq src) => AsmMnemonics.PSRLQ;
        }

        public static Psrlq psrlq() => default;

        [MethodImpl(Inline)]
        public static Psrlq psrlq(AsmHexCode encoded) => new Psrlq(encoded);

        public struct Vpsrlw : IAsmInstruction<Vpsrlw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsrlw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLW;

            public static implicit operator AsmMnemonicCode(Vpsrlw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrlw src) => AsmMnemonics.VPSRLW;
        }

        public static Vpsrlw vpsrlw() => default;

        [MethodImpl(Inline)]
        public static Vpsrlw vpsrlw(AsmHexCode encoded) => new Vpsrlw(encoded);

        public struct Vpsrld : IAsmInstruction<Vpsrld>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsrld(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLD;

            public static implicit operator AsmMnemonicCode(Vpsrld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrld src) => AsmMnemonics.VPSRLD;
        }

        public static Vpsrld vpsrld() => default;

        [MethodImpl(Inline)]
        public static Vpsrld vpsrld(AsmHexCode encoded) => new Vpsrld(encoded);

        public struct Vpsrlq : IAsmInstruction<Vpsrlq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsrlq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLQ;

            public static implicit operator AsmMnemonicCode(Vpsrlq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrlq src) => AsmMnemonics.VPSRLQ;
        }

        public static Vpsrlq vpsrlq() => default;

        [MethodImpl(Inline)]
        public static Vpsrlq vpsrlq(AsmHexCode encoded) => new Vpsrlq(encoded);

        public struct Psubb : IAsmInstruction<Psubb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psubb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBB;

            public static implicit operator AsmMnemonicCode(Psubb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubb src) => AsmMnemonics.PSUBB;
        }

        public static Psubb psubb() => default;

        [MethodImpl(Inline)]
        public static Psubb psubb(AsmHexCode encoded) => new Psubb(encoded);

        public struct Psubw : IAsmInstruction<Psubw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psubw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBW;

            public static implicit operator AsmMnemonicCode(Psubw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubw src) => AsmMnemonics.PSUBW;
        }

        public static Psubw psubw() => default;

        [MethodImpl(Inline)]
        public static Psubw psubw(AsmHexCode encoded) => new Psubw(encoded);

        public struct Psubd : IAsmInstruction<Psubd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psubd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBD;

            public static implicit operator AsmMnemonicCode(Psubd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubd src) => AsmMnemonics.PSUBD;
        }

        public static Psubd psubd() => default;

        [MethodImpl(Inline)]
        public static Psubd psubd(AsmHexCode encoded) => new Psubd(encoded);

        public struct Vpsubb : IAsmInstruction<Vpsubb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsubb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBB;

            public static implicit operator AsmMnemonicCode(Vpsubb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubb src) => AsmMnemonics.VPSUBB;
        }

        public static Vpsubb vpsubb() => default;

        [MethodImpl(Inline)]
        public static Vpsubb vpsubb(AsmHexCode encoded) => new Vpsubb(encoded);

        public struct Vpsubw : IAsmInstruction<Vpsubw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsubw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBW;

            public static implicit operator AsmMnemonicCode(Vpsubw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubw src) => AsmMnemonics.VPSUBW;
        }

        public static Vpsubw vpsubw() => default;

        [MethodImpl(Inline)]
        public static Vpsubw vpsubw(AsmHexCode encoded) => new Vpsubw(encoded);

        public struct Vpsubd : IAsmInstruction<Vpsubd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsubd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBD;

            public static implicit operator AsmMnemonicCode(Vpsubd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubd src) => AsmMnemonics.VPSUBD;
        }

        public static Vpsubd vpsubd() => default;

        [MethodImpl(Inline)]
        public static Vpsubd vpsubd(AsmHexCode encoded) => new Vpsubd(encoded);

        public struct Psubq : IAsmInstruction<Psubq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psubq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBQ;

            public static implicit operator AsmMnemonicCode(Psubq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubq src) => AsmMnemonics.PSUBQ;
        }

        public static Psubq psubq() => default;

        [MethodImpl(Inline)]
        public static Psubq psubq(AsmHexCode encoded) => new Psubq(encoded);

        public struct Vpsubq : IAsmInstruction<Vpsubq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsubq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBQ;

            public static implicit operator AsmMnemonicCode(Vpsubq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubq src) => AsmMnemonics.VPSUBQ;
        }

        public static Vpsubq vpsubq() => default;

        [MethodImpl(Inline)]
        public static Vpsubq vpsubq(AsmHexCode encoded) => new Vpsubq(encoded);

        public struct Psubsb : IAsmInstruction<Psubsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psubsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBSB;

            public static implicit operator AsmMnemonicCode(Psubsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubsb src) => AsmMnemonics.PSUBSB;
        }

        public static Psubsb psubsb() => default;

        [MethodImpl(Inline)]
        public static Psubsb psubsb(AsmHexCode encoded) => new Psubsb(encoded);

        public struct Psubsw : IAsmInstruction<Psubsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psubsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBSW;

            public static implicit operator AsmMnemonicCode(Psubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubsw src) => AsmMnemonics.PSUBSW;
        }

        public static Psubsw psubsw() => default;

        [MethodImpl(Inline)]
        public static Psubsw psubsw(AsmHexCode encoded) => new Psubsw(encoded);

        public struct Vpsubsb : IAsmInstruction<Vpsubsb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsubsb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBSB;

            public static implicit operator AsmMnemonicCode(Vpsubsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubsb src) => AsmMnemonics.VPSUBSB;
        }

        public static Vpsubsb vpsubsb() => default;

        [MethodImpl(Inline)]
        public static Vpsubsb vpsubsb(AsmHexCode encoded) => new Vpsubsb(encoded);

        public struct Vpsubsw : IAsmInstruction<Vpsubsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsubsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBSW;

            public static implicit operator AsmMnemonicCode(Vpsubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubsw src) => AsmMnemonics.VPSUBSW;
        }

        public static Vpsubsw vpsubsw() => default;

        [MethodImpl(Inline)]
        public static Vpsubsw vpsubsw(AsmHexCode encoded) => new Vpsubsw(encoded);

        public struct Psubusb : IAsmInstruction<Psubusb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psubusb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBUSB;

            public static implicit operator AsmMnemonicCode(Psubusb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubusb src) => AsmMnemonics.PSUBUSB;
        }

        public static Psubusb psubusb() => default;

        [MethodImpl(Inline)]
        public static Psubusb psubusb(AsmHexCode encoded) => new Psubusb(encoded);

        public struct Psubusw : IAsmInstruction<Psubusw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Psubusw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBUSW;

            public static implicit operator AsmMnemonicCode(Psubusw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubusw src) => AsmMnemonics.PSUBUSW;
        }

        public static Psubusw psubusw() => default;

        [MethodImpl(Inline)]
        public static Psubusw psubusw(AsmHexCode encoded) => new Psubusw(encoded);

        public struct Vpsubusb : IAsmInstruction<Vpsubusb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsubusb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBUSB;

            public static implicit operator AsmMnemonicCode(Vpsubusb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubusb src) => AsmMnemonics.VPSUBUSB;
        }

        public static Vpsubusb vpsubusb() => default;

        [MethodImpl(Inline)]
        public static Vpsubusb vpsubusb(AsmHexCode encoded) => new Vpsubusb(encoded);

        public struct Vpsubusw : IAsmInstruction<Vpsubusw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsubusw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBUSW;

            public static implicit operator AsmMnemonicCode(Vpsubusw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubusw src) => AsmMnemonics.VPSUBUSW;
        }

        public static Vpsubusw vpsubusw() => default;

        [MethodImpl(Inline)]
        public static Vpsubusw vpsubusw(AsmHexCode encoded) => new Vpsubusw(encoded);

        public struct Ptest : IAsmInstruction<Ptest>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ptest(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PTEST;

            public static implicit operator AsmMnemonicCode(Ptest src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ptest src) => AsmMnemonics.PTEST;
        }

        public static Ptest ptest() => default;

        [MethodImpl(Inline)]
        public static Ptest ptest(AsmHexCode encoded) => new Ptest(encoded);

        public struct Vptest : IAsmInstruction<Vptest>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vptest(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPTEST;

            public static implicit operator AsmMnemonicCode(Vptest src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vptest src) => AsmMnemonics.VPTEST;
        }

        public static Vptest vptest() => default;

        [MethodImpl(Inline)]
        public static Vptest vptest(AsmHexCode encoded) => new Vptest(encoded);

        public struct Punpckhbw : IAsmInstruction<Punpckhbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Punpckhbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHBW;

            public static implicit operator AsmMnemonicCode(Punpckhbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckhbw src) => AsmMnemonics.PUNPCKHBW;
        }

        public static Punpckhbw punpckhbw() => default;

        [MethodImpl(Inline)]
        public static Punpckhbw punpckhbw(AsmHexCode encoded) => new Punpckhbw(encoded);

        public struct Punpckhwd : IAsmInstruction<Punpckhwd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Punpckhwd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHWD;

            public static implicit operator AsmMnemonicCode(Punpckhwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckhwd src) => AsmMnemonics.PUNPCKHWD;
        }

        public static Punpckhwd punpckhwd() => default;

        [MethodImpl(Inline)]
        public static Punpckhwd punpckhwd(AsmHexCode encoded) => new Punpckhwd(encoded);

        public struct Punpckhdq : IAsmInstruction<Punpckhdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Punpckhdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHDQ;

            public static implicit operator AsmMnemonicCode(Punpckhdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckhdq src) => AsmMnemonics.PUNPCKHDQ;
        }

        public static Punpckhdq punpckhdq() => default;

        [MethodImpl(Inline)]
        public static Punpckhdq punpckhdq(AsmHexCode encoded) => new Punpckhdq(encoded);

        public struct Punpckhqdq : IAsmInstruction<Punpckhqdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Punpckhqdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHQDQ;

            public static implicit operator AsmMnemonicCode(Punpckhqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckhqdq src) => AsmMnemonics.PUNPCKHQDQ;
        }

        public static Punpckhqdq punpckhqdq() => default;

        [MethodImpl(Inline)]
        public static Punpckhqdq punpckhqdq(AsmHexCode encoded) => new Punpckhqdq(encoded);

        public struct Vpunpckhbw : IAsmInstruction<Vpunpckhbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpunpckhbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHBW;

            public static implicit operator AsmMnemonicCode(Vpunpckhbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckhbw src) => AsmMnemonics.VPUNPCKHBW;
        }

        public static Vpunpckhbw vpunpckhbw() => default;

        [MethodImpl(Inline)]
        public static Vpunpckhbw vpunpckhbw(AsmHexCode encoded) => new Vpunpckhbw(encoded);

        public struct Vpunpckhwd : IAsmInstruction<Vpunpckhwd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpunpckhwd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHWD;

            public static implicit operator AsmMnemonicCode(Vpunpckhwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckhwd src) => AsmMnemonics.VPUNPCKHWD;
        }

        public static Vpunpckhwd vpunpckhwd() => default;

        [MethodImpl(Inline)]
        public static Vpunpckhwd vpunpckhwd(AsmHexCode encoded) => new Vpunpckhwd(encoded);

        public struct Vpunpckhdq : IAsmInstruction<Vpunpckhdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpunpckhdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHDQ;

            public static implicit operator AsmMnemonicCode(Vpunpckhdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckhdq src) => AsmMnemonics.VPUNPCKHDQ;
        }

        public static Vpunpckhdq vpunpckhdq() => default;

        [MethodImpl(Inline)]
        public static Vpunpckhdq vpunpckhdq(AsmHexCode encoded) => new Vpunpckhdq(encoded);

        public struct Vpunpckhqdq : IAsmInstruction<Vpunpckhqdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpunpckhqdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHQDQ;

            public static implicit operator AsmMnemonicCode(Vpunpckhqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckhqdq src) => AsmMnemonics.VPUNPCKHQDQ;
        }

        public static Vpunpckhqdq vpunpckhqdq() => default;

        [MethodImpl(Inline)]
        public static Vpunpckhqdq vpunpckhqdq(AsmHexCode encoded) => new Vpunpckhqdq(encoded);

        public struct Punpcklbw : IAsmInstruction<Punpcklbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Punpcklbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLBW;

            public static implicit operator AsmMnemonicCode(Punpcklbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpcklbw src) => AsmMnemonics.PUNPCKLBW;
        }

        public static Punpcklbw punpcklbw() => default;

        [MethodImpl(Inline)]
        public static Punpcklbw punpcklbw(AsmHexCode encoded) => new Punpcklbw(encoded);

        public struct Punpcklwd : IAsmInstruction<Punpcklwd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Punpcklwd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLWD;

            public static implicit operator AsmMnemonicCode(Punpcklwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpcklwd src) => AsmMnemonics.PUNPCKLWD;
        }

        public static Punpcklwd punpcklwd() => default;

        [MethodImpl(Inline)]
        public static Punpcklwd punpcklwd(AsmHexCode encoded) => new Punpcklwd(encoded);

        public struct Punpckldq : IAsmInstruction<Punpckldq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Punpckldq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLDQ;

            public static implicit operator AsmMnemonicCode(Punpckldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckldq src) => AsmMnemonics.PUNPCKLDQ;
        }

        public static Punpckldq punpckldq() => default;

        [MethodImpl(Inline)]
        public static Punpckldq punpckldq(AsmHexCode encoded) => new Punpckldq(encoded);

        public struct Punpcklqdq : IAsmInstruction<Punpcklqdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Punpcklqdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLQDQ;

            public static implicit operator AsmMnemonicCode(Punpcklqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpcklqdq src) => AsmMnemonics.PUNPCKLQDQ;
        }

        public static Punpcklqdq punpcklqdq() => default;

        [MethodImpl(Inline)]
        public static Punpcklqdq punpcklqdq(AsmHexCode encoded) => new Punpcklqdq(encoded);

        public struct Vpunpcklbw : IAsmInstruction<Vpunpcklbw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpunpcklbw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLBW;

            public static implicit operator AsmMnemonicCode(Vpunpcklbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpcklbw src) => AsmMnemonics.VPUNPCKLBW;
        }

        public static Vpunpcklbw vpunpcklbw() => default;

        [MethodImpl(Inline)]
        public static Vpunpcklbw vpunpcklbw(AsmHexCode encoded) => new Vpunpcklbw(encoded);

        public struct Vpunpcklwd : IAsmInstruction<Vpunpcklwd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpunpcklwd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLWD;

            public static implicit operator AsmMnemonicCode(Vpunpcklwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpcklwd src) => AsmMnemonics.VPUNPCKLWD;
        }

        public static Vpunpcklwd vpunpcklwd() => default;

        [MethodImpl(Inline)]
        public static Vpunpcklwd vpunpcklwd(AsmHexCode encoded) => new Vpunpcklwd(encoded);

        public struct Vpunpckldq : IAsmInstruction<Vpunpckldq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpunpckldq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLDQ;

            public static implicit operator AsmMnemonicCode(Vpunpckldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckldq src) => AsmMnemonics.VPUNPCKLDQ;
        }

        public static Vpunpckldq vpunpckldq() => default;

        [MethodImpl(Inline)]
        public static Vpunpckldq vpunpckldq(AsmHexCode encoded) => new Vpunpckldq(encoded);

        public struct Vpunpcklqdq : IAsmInstruction<Vpunpcklqdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpunpcklqdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLQDQ;

            public static implicit operator AsmMnemonicCode(Vpunpcklqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpcklqdq src) => AsmMnemonics.VPUNPCKLQDQ;
        }

        public static Vpunpcklqdq vpunpcklqdq() => default;

        [MethodImpl(Inline)]
        public static Vpunpcklqdq vpunpcklqdq(AsmHexCode encoded) => new Vpunpcklqdq(encoded);

        public struct Push : IAsmInstruction<Push>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Push(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSH;

            public static implicit operator AsmMnemonicCode(Push src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Push src) => AsmMnemonics.PUSH;
        }

        public static Push push() => default;

        [MethodImpl(Inline)]
        public static Push push(AsmHexCode encoded) => new Push(encoded);

        public struct Pushq : IAsmInstruction<Pushq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pushq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHQ;

            public static implicit operator AsmMnemonicCode(Pushq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushq src) => AsmMnemonics.PUSHQ;
        }

        public static Pushq pushq() => default;

        [MethodImpl(Inline)]
        public static Pushq pushq(AsmHexCode encoded) => new Pushq(encoded);

        public struct Pushw : IAsmInstruction<Pushw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pushw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHW;

            public static implicit operator AsmMnemonicCode(Pushw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushw src) => AsmMnemonics.PUSHW;
        }

        public static Pushw pushw() => default;

        [MethodImpl(Inline)]
        public static Pushw pushw(AsmHexCode encoded) => new Pushw(encoded);

        public struct Pusha : IAsmInstruction<Pusha>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pusha(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHA;

            public static implicit operator AsmMnemonicCode(Pusha src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pusha src) => AsmMnemonics.PUSHA;
        }

        public static Pusha pusha() => default;

        [MethodImpl(Inline)]
        public static Pusha pusha(AsmHexCode encoded) => new Pusha(encoded);

        public struct Pushad : IAsmInstruction<Pushad>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pushad(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHAD;

            public static implicit operator AsmMnemonicCode(Pushad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushad src) => AsmMnemonics.PUSHAD;
        }

        public static Pushad pushad() => default;

        [MethodImpl(Inline)]
        public static Pushad pushad(AsmHexCode encoded) => new Pushad(encoded);

        public struct Pushf : IAsmInstruction<Pushf>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pushf(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHF;

            public static implicit operator AsmMnemonicCode(Pushf src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushf src) => AsmMnemonics.PUSHF;
        }

        public static Pushf pushf() => default;

        [MethodImpl(Inline)]
        public static Pushf pushf(AsmHexCode encoded) => new Pushf(encoded);

        public struct Pushfd : IAsmInstruction<Pushfd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pushfd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHFD;

            public static implicit operator AsmMnemonicCode(Pushfd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushfd src) => AsmMnemonics.PUSHFD;
        }

        public static Pushfd pushfd() => default;

        [MethodImpl(Inline)]
        public static Pushfd pushfd(AsmHexCode encoded) => new Pushfd(encoded);

        public struct Pushfq : IAsmInstruction<Pushfq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pushfq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHFQ;

            public static implicit operator AsmMnemonicCode(Pushfq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushfq src) => AsmMnemonics.PUSHFQ;
        }

        public static Pushfq pushfq() => default;

        [MethodImpl(Inline)]
        public static Pushfq pushfq(AsmHexCode encoded) => new Pushfq(encoded);

        public struct Pxor : IAsmInstruction<Pxor>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Pxor(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PXOR;

            public static implicit operator AsmMnemonicCode(Pxor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pxor src) => AsmMnemonics.PXOR;
        }

        public static Pxor pxor() => default;

        [MethodImpl(Inline)]
        public static Pxor pxor(AsmHexCode encoded) => new Pxor(encoded);

        public struct Vpxor : IAsmInstruction<Vpxor>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpxor(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPXOR;

            public static implicit operator AsmMnemonicCode(Vpxor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpxor src) => AsmMnemonics.VPXOR;
        }

        public static Vpxor vpxor() => default;

        [MethodImpl(Inline)]
        public static Vpxor vpxor(AsmHexCode encoded) => new Vpxor(encoded);

        public struct Rcl : IAsmInstruction<Rcl>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rcl(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCL;

            public static implicit operator AsmMnemonicCode(Rcl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rcl src) => AsmMnemonics.RCL;
        }

        public static Rcl rcl() => default;

        [MethodImpl(Inline)]
        public static Rcl rcl(AsmHexCode encoded) => new Rcl(encoded);

        public struct Rcr : IAsmInstruction<Rcr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rcr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCR;

            public static implicit operator AsmMnemonicCode(Rcr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rcr src) => AsmMnemonics.RCR;
        }

        public static Rcr rcr() => default;

        [MethodImpl(Inline)]
        public static Rcr rcr(AsmHexCode encoded) => new Rcr(encoded);

        public struct Rol : IAsmInstruction<Rol>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rol(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROL;

            public static implicit operator AsmMnemonicCode(Rol src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rol src) => AsmMnemonics.ROL;
        }

        public static Rol rol() => default;

        [MethodImpl(Inline)]
        public static Rol rol(AsmHexCode encoded) => new Rol(encoded);

        public struct Ror : IAsmInstruction<Ror>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ror(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROR;

            public static implicit operator AsmMnemonicCode(Ror src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ror src) => AsmMnemonics.ROR;
        }

        public static Ror ror() => default;

        [MethodImpl(Inline)]
        public static Ror ror(AsmHexCode encoded) => new Ror(encoded);

        public struct Rcpps : IAsmInstruction<Rcpps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rcpps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCPPS;

            public static implicit operator AsmMnemonicCode(Rcpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rcpps src) => AsmMnemonics.RCPPS;
        }

        public static Rcpps rcpps() => default;

        [MethodImpl(Inline)]
        public static Rcpps rcpps(AsmHexCode encoded) => new Rcpps(encoded);

        public struct Vrcpps : IAsmInstruction<Vrcpps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vrcpps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRCPPS;

            public static implicit operator AsmMnemonicCode(Vrcpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vrcpps src) => AsmMnemonics.VRCPPS;
        }

        public static Vrcpps vrcpps() => default;

        [MethodImpl(Inline)]
        public static Vrcpps vrcpps(AsmHexCode encoded) => new Vrcpps(encoded);

        public struct Rcpss : IAsmInstruction<Rcpss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rcpss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCPSS;

            public static implicit operator AsmMnemonicCode(Rcpss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rcpss src) => AsmMnemonics.RCPSS;
        }

        public static Rcpss rcpss() => default;

        [MethodImpl(Inline)]
        public static Rcpss rcpss(AsmHexCode encoded) => new Rcpss(encoded);

        public struct Vrcpss : IAsmInstruction<Vrcpss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vrcpss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRCPSS;

            public static implicit operator AsmMnemonicCode(Vrcpss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vrcpss src) => AsmMnemonics.VRCPSS;
        }

        public static Vrcpss vrcpss() => default;

        [MethodImpl(Inline)]
        public static Vrcpss vrcpss(AsmHexCode encoded) => new Vrcpss(encoded);

        public struct Rdfsbase : IAsmInstruction<Rdfsbase>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rdfsbase(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDFSBASE;

            public static implicit operator AsmMnemonicCode(Rdfsbase src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdfsbase src) => AsmMnemonics.RDFSBASE;
        }

        public static Rdfsbase rdfsbase() => default;

        [MethodImpl(Inline)]
        public static Rdfsbase rdfsbase(AsmHexCode encoded) => new Rdfsbase(encoded);

        public struct Rdgsbase : IAsmInstruction<Rdgsbase>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rdgsbase(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDGSBASE;

            public static implicit operator AsmMnemonicCode(Rdgsbase src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdgsbase src) => AsmMnemonics.RDGSBASE;
        }

        public static Rdgsbase rdgsbase() => default;

        [MethodImpl(Inline)]
        public static Rdgsbase rdgsbase(AsmHexCode encoded) => new Rdgsbase(encoded);

        public struct Rdmsr : IAsmInstruction<Rdmsr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rdmsr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDMSR;

            public static implicit operator AsmMnemonicCode(Rdmsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdmsr src) => AsmMnemonics.RDMSR;
        }

        public static Rdmsr rdmsr() => default;

        [MethodImpl(Inline)]
        public static Rdmsr rdmsr(AsmHexCode encoded) => new Rdmsr(encoded);

        public struct Rdpmc : IAsmInstruction<Rdpmc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rdpmc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDPMC;

            public static implicit operator AsmMnemonicCode(Rdpmc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdpmc src) => AsmMnemonics.RDPMC;
        }

        public static Rdpmc rdpmc() => default;

        [MethodImpl(Inline)]
        public static Rdpmc rdpmc(AsmHexCode encoded) => new Rdpmc(encoded);

        public struct Rdrand : IAsmInstruction<Rdrand>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rdrand(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDRAND;

            public static implicit operator AsmMnemonicCode(Rdrand src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdrand src) => AsmMnemonics.RDRAND;
        }

        public static Rdrand rdrand() => default;

        [MethodImpl(Inline)]
        public static Rdrand rdrand(AsmHexCode encoded) => new Rdrand(encoded);

        public struct Rdtsc : IAsmInstruction<Rdtsc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rdtsc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDTSC;

            public static implicit operator AsmMnemonicCode(Rdtsc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdtsc src) => AsmMnemonics.RDTSC;
        }

        public static Rdtsc rdtsc() => default;

        [MethodImpl(Inline)]
        public static Rdtsc rdtsc(AsmHexCode encoded) => new Rdtsc(encoded);

        public struct Rdtscp : IAsmInstruction<Rdtscp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rdtscp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDTSCP;

            public static implicit operator AsmMnemonicCode(Rdtscp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdtscp src) => AsmMnemonics.RDTSCP;
        }

        public static Rdtscp rdtscp() => default;

        [MethodImpl(Inline)]
        public static Rdtscp rdtscp(AsmHexCode encoded) => new Rdtscp(encoded);

        public struct Rep_ins : IAsmInstruction<Rep_ins>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rep_ins(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_INS;

            public static implicit operator AsmMnemonicCode(Rep_ins src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_ins src) => AsmMnemonics.REP_INS;
        }

        public static Rep_ins rep_ins() => default;

        [MethodImpl(Inline)]
        public static Rep_ins rep_ins(AsmHexCode encoded) => new Rep_ins(encoded);

        public struct Rep_movs : IAsmInstruction<Rep_movs>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rep_movs(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_MOVS;

            public static implicit operator AsmMnemonicCode(Rep_movs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_movs src) => AsmMnemonics.REP_MOVS;
        }

        public static Rep_movs rep_movs() => default;

        [MethodImpl(Inline)]
        public static Rep_movs rep_movs(AsmHexCode encoded) => new Rep_movs(encoded);

        public struct Rep_outs : IAsmInstruction<Rep_outs>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rep_outs(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_OUTS;

            public static implicit operator AsmMnemonicCode(Rep_outs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_outs src) => AsmMnemonics.REP_OUTS;
        }

        public static Rep_outs rep_outs() => default;

        [MethodImpl(Inline)]
        public static Rep_outs rep_outs(AsmHexCode encoded) => new Rep_outs(encoded);

        public struct Rep_lods : IAsmInstruction<Rep_lods>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rep_lods(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_LODS;

            public static implicit operator AsmMnemonicCode(Rep_lods src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_lods src) => AsmMnemonics.REP_LODS;
        }

        public static Rep_lods rep_lods() => default;

        [MethodImpl(Inline)]
        public static Rep_lods rep_lods(AsmHexCode encoded) => new Rep_lods(encoded);

        public struct Rep_stos : IAsmInstruction<Rep_stos>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rep_stos(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_STOS;

            public static implicit operator AsmMnemonicCode(Rep_stos src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_stos src) => AsmMnemonics.REP_STOS;
        }

        public static Rep_stos rep_stos() => default;

        [MethodImpl(Inline)]
        public static Rep_stos rep_stos(AsmHexCode encoded) => new Rep_stos(encoded);

        public struct Repe_cmps : IAsmInstruction<Repe_cmps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Repe_cmps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPE_CMPS;

            public static implicit operator AsmMnemonicCode(Repe_cmps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Repe_cmps src) => AsmMnemonics.REPE_CMPS;
        }

        public static Repe_cmps repe_cmps() => default;

        [MethodImpl(Inline)]
        public static Repe_cmps repe_cmps(AsmHexCode encoded) => new Repe_cmps(encoded);

        public struct Repe_scas : IAsmInstruction<Repe_scas>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Repe_scas(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPE_SCAS;

            public static implicit operator AsmMnemonicCode(Repe_scas src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Repe_scas src) => AsmMnemonics.REPE_SCAS;
        }

        public static Repe_scas repe_scas() => default;

        [MethodImpl(Inline)]
        public static Repe_scas repe_scas(AsmHexCode encoded) => new Repe_scas(encoded);

        public struct Repne_cmps : IAsmInstruction<Repne_cmps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Repne_cmps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPNE_CMPS;

            public static implicit operator AsmMnemonicCode(Repne_cmps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Repne_cmps src) => AsmMnemonics.REPNE_CMPS;
        }

        public static Repne_cmps repne_cmps() => default;

        [MethodImpl(Inline)]
        public static Repne_cmps repne_cmps(AsmHexCode encoded) => new Repne_cmps(encoded);

        public struct Repne_scas : IAsmInstruction<Repne_scas>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Repne_scas(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPNE_SCAS;

            public static implicit operator AsmMnemonicCode(Repne_scas src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Repne_scas src) => AsmMnemonics.REPNE_SCAS;
        }

        public static Repne_scas repne_scas() => default;

        [MethodImpl(Inline)]
        public static Repne_scas repne_scas(AsmHexCode encoded) => new Repne_scas(encoded);

        public struct Ret : IAsmInstruction<Ret>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ret(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RET;

            public static implicit operator AsmMnemonicCode(Ret src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ret src) => AsmMnemonics.RET;
        }

        public static Ret ret() => default;

        [MethodImpl(Inline)]
        public static Ret ret(AsmHexCode encoded) => new Ret(encoded);

        public struct Rorx : IAsmInstruction<Rorx>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rorx(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RORX;

            public static implicit operator AsmMnemonicCode(Rorx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rorx src) => AsmMnemonics.RORX;
        }

        public static Rorx rorx() => default;

        [MethodImpl(Inline)]
        public static Rorx rorx(AsmHexCode encoded) => new Rorx(encoded);

        public struct Roundpd : IAsmInstruction<Roundpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Roundpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDPD;

            public static implicit operator AsmMnemonicCode(Roundpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Roundpd src) => AsmMnemonics.ROUNDPD;
        }

        public static Roundpd roundpd() => default;

        [MethodImpl(Inline)]
        public static Roundpd roundpd(AsmHexCode encoded) => new Roundpd(encoded);

        public struct Vroundpd : IAsmInstruction<Vroundpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vroundpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDPD;

            public static implicit operator AsmMnemonicCode(Vroundpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vroundpd src) => AsmMnemonics.VROUNDPD;
        }

        public static Vroundpd vroundpd() => default;

        [MethodImpl(Inline)]
        public static Vroundpd vroundpd(AsmHexCode encoded) => new Vroundpd(encoded);

        public struct Roundps : IAsmInstruction<Roundps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Roundps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDPS;

            public static implicit operator AsmMnemonicCode(Roundps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Roundps src) => AsmMnemonics.ROUNDPS;
        }

        public static Roundps roundps() => default;

        [MethodImpl(Inline)]
        public static Roundps roundps(AsmHexCode encoded) => new Roundps(encoded);

        public struct Vroundps : IAsmInstruction<Vroundps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vroundps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDPS;

            public static implicit operator AsmMnemonicCode(Vroundps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vroundps src) => AsmMnemonics.VROUNDPS;
        }

        public static Vroundps vroundps() => default;

        [MethodImpl(Inline)]
        public static Vroundps vroundps(AsmHexCode encoded) => new Vroundps(encoded);

        public struct Roundsd : IAsmInstruction<Roundsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Roundsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDSD;

            public static implicit operator AsmMnemonicCode(Roundsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Roundsd src) => AsmMnemonics.ROUNDSD;
        }

        public static Roundsd roundsd() => default;

        [MethodImpl(Inline)]
        public static Roundsd roundsd(AsmHexCode encoded) => new Roundsd(encoded);

        public struct Vroundsd : IAsmInstruction<Vroundsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vroundsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDSD;

            public static implicit operator AsmMnemonicCode(Vroundsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vroundsd src) => AsmMnemonics.VROUNDSD;
        }

        public static Vroundsd vroundsd() => default;

        [MethodImpl(Inline)]
        public static Vroundsd vroundsd(AsmHexCode encoded) => new Vroundsd(encoded);

        public struct Roundss : IAsmInstruction<Roundss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Roundss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDSS;

            public static implicit operator AsmMnemonicCode(Roundss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Roundss src) => AsmMnemonics.ROUNDSS;
        }

        public static Roundss roundss() => default;

        [MethodImpl(Inline)]
        public static Roundss roundss(AsmHexCode encoded) => new Roundss(encoded);

        public struct Vroundss : IAsmInstruction<Vroundss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vroundss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDSS;

            public static implicit operator AsmMnemonicCode(Vroundss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vroundss src) => AsmMnemonics.VROUNDSS;
        }

        public static Vroundss vroundss() => default;

        [MethodImpl(Inline)]
        public static Vroundss vroundss(AsmHexCode encoded) => new Vroundss(encoded);

        public struct Rsm : IAsmInstruction<Rsm>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rsm(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RSM;

            public static implicit operator AsmMnemonicCode(Rsm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rsm src) => AsmMnemonics.RSM;
        }

        public static Rsm rsm() => default;

        [MethodImpl(Inline)]
        public static Rsm rsm(AsmHexCode encoded) => new Rsm(encoded);

        public struct Rsqrtps : IAsmInstruction<Rsqrtps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rsqrtps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RSQRTPS;

            public static implicit operator AsmMnemonicCode(Rsqrtps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rsqrtps src) => AsmMnemonics.RSQRTPS;
        }

        public static Rsqrtps rsqrtps() => default;

        [MethodImpl(Inline)]
        public static Rsqrtps rsqrtps(AsmHexCode encoded) => new Rsqrtps(encoded);

        public struct Vrsqrtps : IAsmInstruction<Vrsqrtps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vrsqrtps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRSQRTPS;

            public static implicit operator AsmMnemonicCode(Vrsqrtps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vrsqrtps src) => AsmMnemonics.VRSQRTPS;
        }

        public static Vrsqrtps vrsqrtps() => default;

        [MethodImpl(Inline)]
        public static Vrsqrtps vrsqrtps(AsmHexCode encoded) => new Vrsqrtps(encoded);

        public struct Rsqrtss : IAsmInstruction<Rsqrtss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Rsqrtss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RSQRTSS;

            public static implicit operator AsmMnemonicCode(Rsqrtss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rsqrtss src) => AsmMnemonics.RSQRTSS;
        }

        public static Rsqrtss rsqrtss() => default;

        [MethodImpl(Inline)]
        public static Rsqrtss rsqrtss(AsmHexCode encoded) => new Rsqrtss(encoded);

        public struct Vrsqrtss : IAsmInstruction<Vrsqrtss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vrsqrtss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRSQRTSS;

            public static implicit operator AsmMnemonicCode(Vrsqrtss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vrsqrtss src) => AsmMnemonics.VRSQRTSS;
        }

        public static Vrsqrtss vrsqrtss() => default;

        [MethodImpl(Inline)]
        public static Vrsqrtss vrsqrtss(AsmHexCode encoded) => new Vrsqrtss(encoded);

        public struct Sahf : IAsmInstruction<Sahf>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sahf(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SAHF;

            public static implicit operator AsmMnemonicCode(Sahf src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sahf src) => AsmMnemonics.SAHF;
        }

        public static Sahf sahf() => default;

        [MethodImpl(Inline)]
        public static Sahf sahf(AsmHexCode encoded) => new Sahf(encoded);

        public struct Sal : IAsmInstruction<Sal>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sal(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SAL;

            public static implicit operator AsmMnemonicCode(Sal src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sal src) => AsmMnemonics.SAL;
        }

        public static Sal sal() => default;

        [MethodImpl(Inline)]
        public static Sal sal(AsmHexCode encoded) => new Sal(encoded);

        public struct Sar : IAsmInstruction<Sar>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sar(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SAR;

            public static implicit operator AsmMnemonicCode(Sar src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sar src) => AsmMnemonics.SAR;
        }

        public static Sar sar() => default;

        [MethodImpl(Inline)]
        public static Sar sar(AsmHexCode encoded) => new Sar(encoded);

        public struct Shl : IAsmInstruction<Shl>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Shl(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHL;

            public static implicit operator AsmMnemonicCode(Shl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shl src) => AsmMnemonics.SHL;
        }

        public static Shl shl() => default;

        [MethodImpl(Inline)]
        public static Shl shl(AsmHexCode encoded) => new Shl(encoded);

        public struct Shr : IAsmInstruction<Shr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Shr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHR;

            public static implicit operator AsmMnemonicCode(Shr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shr src) => AsmMnemonics.SHR;
        }

        public static Shr shr() => default;

        [MethodImpl(Inline)]
        public static Shr shr(AsmHexCode encoded) => new Shr(encoded);

        public struct Sarx : IAsmInstruction<Sarx>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sarx(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SARX;

            public static implicit operator AsmMnemonicCode(Sarx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sarx src) => AsmMnemonics.SARX;
        }

        public static Sarx sarx() => default;

        [MethodImpl(Inline)]
        public static Sarx sarx(AsmHexCode encoded) => new Sarx(encoded);

        public struct Shlx : IAsmInstruction<Shlx>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Shlx(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHLX;

            public static implicit operator AsmMnemonicCode(Shlx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shlx src) => AsmMnemonics.SHLX;
        }

        public static Shlx shlx() => default;

        [MethodImpl(Inline)]
        public static Shlx shlx(AsmHexCode encoded) => new Shlx(encoded);

        public struct Shrx : IAsmInstruction<Shrx>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Shrx(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHRX;

            public static implicit operator AsmMnemonicCode(Shrx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shrx src) => AsmMnemonics.SHRX;
        }

        public static Shrx shrx() => default;

        [MethodImpl(Inline)]
        public static Shrx shrx(AsmHexCode encoded) => new Shrx(encoded);

        public struct Sbb : IAsmInstruction<Sbb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sbb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SBB;

            public static implicit operator AsmMnemonicCode(Sbb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sbb src) => AsmMnemonics.SBB;
        }

        public static Sbb sbb() => default;

        [MethodImpl(Inline)]
        public static Sbb sbb(AsmHexCode encoded) => new Sbb(encoded);

        public struct Scas : IAsmInstruction<Scas>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Scas(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SCAS;

            public static implicit operator AsmMnemonicCode(Scas src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Scas src) => AsmMnemonics.SCAS;
        }

        public static Scas scas() => default;

        [MethodImpl(Inline)]
        public static Scas scas(AsmHexCode encoded) => new Scas(encoded);

        public struct Scasb : IAsmInstruction<Scasb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Scasb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SCASB;

            public static implicit operator AsmMnemonicCode(Scasb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Scasb src) => AsmMnemonics.SCASB;
        }

        public static Scasb scasb() => default;

        [MethodImpl(Inline)]
        public static Scasb scasb(AsmHexCode encoded) => new Scasb(encoded);

        public struct Scasw : IAsmInstruction<Scasw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Scasw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SCASW;

            public static implicit operator AsmMnemonicCode(Scasw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Scasw src) => AsmMnemonics.SCASW;
        }

        public static Scasw scasw() => default;

        [MethodImpl(Inline)]
        public static Scasw scasw(AsmHexCode encoded) => new Scasw(encoded);

        public struct Scasd : IAsmInstruction<Scasd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Scasd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SCASD;

            public static implicit operator AsmMnemonicCode(Scasd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Scasd src) => AsmMnemonics.SCASD;
        }

        public static Scasd scasd() => default;

        [MethodImpl(Inline)]
        public static Scasd scasd(AsmHexCode encoded) => new Scasd(encoded);

        public struct Scasq : IAsmInstruction<Scasq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Scasq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SCASQ;

            public static implicit operator AsmMnemonicCode(Scasq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Scasq src) => AsmMnemonics.SCASQ;
        }

        public static Scasq scasq() => default;

        [MethodImpl(Inline)]
        public static Scasq scasq(AsmHexCode encoded) => new Scasq(encoded);

        public struct Seta : IAsmInstruction<Seta>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Seta(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETA;

            public static implicit operator AsmMnemonicCode(Seta src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Seta src) => AsmMnemonics.SETA;
        }

        public static Seta seta() => default;

        [MethodImpl(Inline)]
        public static Seta seta(AsmHexCode encoded) => new Seta(encoded);

        public struct Setae : IAsmInstruction<Setae>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setae(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETAE;

            public static implicit operator AsmMnemonicCode(Setae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setae src) => AsmMnemonics.SETAE;
        }

        public static Setae setae() => default;

        [MethodImpl(Inline)]
        public static Setae setae(AsmHexCode encoded) => new Setae(encoded);

        public struct Setb : IAsmInstruction<Setb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETB;

            public static implicit operator AsmMnemonicCode(Setb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setb src) => AsmMnemonics.SETB;
        }

        public static Setb setb() => default;

        [MethodImpl(Inline)]
        public static Setb setb(AsmHexCode encoded) => new Setb(encoded);

        public struct Setbe : IAsmInstruction<Setbe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setbe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETBE;

            public static implicit operator AsmMnemonicCode(Setbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setbe src) => AsmMnemonics.SETBE;
        }

        public static Setbe setbe() => default;

        [MethodImpl(Inline)]
        public static Setbe setbe(AsmHexCode encoded) => new Setbe(encoded);

        public struct Setc : IAsmInstruction<Setc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETC;

            public static implicit operator AsmMnemonicCode(Setc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setc src) => AsmMnemonics.SETC;
        }

        public static Setc setc() => default;

        [MethodImpl(Inline)]
        public static Setc setc(AsmHexCode encoded) => new Setc(encoded);

        public struct Sete : IAsmInstruction<Sete>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sete(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETE;

            public static implicit operator AsmMnemonicCode(Sete src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sete src) => AsmMnemonics.SETE;
        }

        public static Sete sete() => default;

        [MethodImpl(Inline)]
        public static Sete sete(AsmHexCode encoded) => new Sete(encoded);

        public struct Setg : IAsmInstruction<Setg>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setg(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETG;

            public static implicit operator AsmMnemonicCode(Setg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setg src) => AsmMnemonics.SETG;
        }

        public static Setg setg() => default;

        [MethodImpl(Inline)]
        public static Setg setg(AsmHexCode encoded) => new Setg(encoded);

        public struct Setge : IAsmInstruction<Setge>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setge(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETGE;

            public static implicit operator AsmMnemonicCode(Setge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setge src) => AsmMnemonics.SETGE;
        }

        public static Setge setge() => default;

        [MethodImpl(Inline)]
        public static Setge setge(AsmHexCode encoded) => new Setge(encoded);

        public struct Setl : IAsmInstruction<Setl>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setl(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETL;

            public static implicit operator AsmMnemonicCode(Setl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setl src) => AsmMnemonics.SETL;
        }

        public static Setl setl() => default;

        [MethodImpl(Inline)]
        public static Setl setl(AsmHexCode encoded) => new Setl(encoded);

        public struct Setle : IAsmInstruction<Setle>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setle(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETLE;

            public static implicit operator AsmMnemonicCode(Setle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setle src) => AsmMnemonics.SETLE;
        }

        public static Setle setle() => default;

        [MethodImpl(Inline)]
        public static Setle setle(AsmHexCode encoded) => new Setle(encoded);

        public struct Setna : IAsmInstruction<Setna>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setna(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNA;

            public static implicit operator AsmMnemonicCode(Setna src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setna src) => AsmMnemonics.SETNA;
        }

        public static Setna setna() => default;

        [MethodImpl(Inline)]
        public static Setna setna(AsmHexCode encoded) => new Setna(encoded);

        public struct Setnae : IAsmInstruction<Setnae>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setnae(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNAE;

            public static implicit operator AsmMnemonicCode(Setnae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnae src) => AsmMnemonics.SETNAE;
        }

        public static Setnae setnae() => default;

        [MethodImpl(Inline)]
        public static Setnae setnae(AsmHexCode encoded) => new Setnae(encoded);

        public struct Setnb : IAsmInstruction<Setnb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setnb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNB;

            public static implicit operator AsmMnemonicCode(Setnb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnb src) => AsmMnemonics.SETNB;
        }

        public static Setnb setnb() => default;

        [MethodImpl(Inline)]
        public static Setnb setnb(AsmHexCode encoded) => new Setnb(encoded);

        public struct Setnbe : IAsmInstruction<Setnbe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setnbe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNBE;

            public static implicit operator AsmMnemonicCode(Setnbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnbe src) => AsmMnemonics.SETNBE;
        }

        public static Setnbe setnbe() => default;

        [MethodImpl(Inline)]
        public static Setnbe setnbe(AsmHexCode encoded) => new Setnbe(encoded);

        public struct Setnc : IAsmInstruction<Setnc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setnc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNC;

            public static implicit operator AsmMnemonicCode(Setnc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnc src) => AsmMnemonics.SETNC;
        }

        public static Setnc setnc() => default;

        [MethodImpl(Inline)]
        public static Setnc setnc(AsmHexCode encoded) => new Setnc(encoded);

        public struct Setne : IAsmInstruction<Setne>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setne(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNE;

            public static implicit operator AsmMnemonicCode(Setne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setne src) => AsmMnemonics.SETNE;
        }

        public static Setne setne() => default;

        [MethodImpl(Inline)]
        public static Setne setne(AsmHexCode encoded) => new Setne(encoded);

        public struct Setng : IAsmInstruction<Setng>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setng(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNG;

            public static implicit operator AsmMnemonicCode(Setng src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setng src) => AsmMnemonics.SETNG;
        }

        public static Setng setng() => default;

        [MethodImpl(Inline)]
        public static Setng setng(AsmHexCode encoded) => new Setng(encoded);

        public struct Setnge : IAsmInstruction<Setnge>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setnge(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNGE;

            public static implicit operator AsmMnemonicCode(Setnge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnge src) => AsmMnemonics.SETNGE;
        }

        public static Setnge setnge() => default;

        [MethodImpl(Inline)]
        public static Setnge setnge(AsmHexCode encoded) => new Setnge(encoded);

        public struct Setnl : IAsmInstruction<Setnl>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setnl(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNL;

            public static implicit operator AsmMnemonicCode(Setnl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnl src) => AsmMnemonics.SETNL;
        }

        public static Setnl setnl() => default;

        [MethodImpl(Inline)]
        public static Setnl setnl(AsmHexCode encoded) => new Setnl(encoded);

        public struct Setnle : IAsmInstruction<Setnle>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setnle(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNLE;

            public static implicit operator AsmMnemonicCode(Setnle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnle src) => AsmMnemonics.SETNLE;
        }

        public static Setnle setnle() => default;

        [MethodImpl(Inline)]
        public static Setnle setnle(AsmHexCode encoded) => new Setnle(encoded);

        public struct Setno : IAsmInstruction<Setno>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setno(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNO;

            public static implicit operator AsmMnemonicCode(Setno src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setno src) => AsmMnemonics.SETNO;
        }

        public static Setno setno() => default;

        [MethodImpl(Inline)]
        public static Setno setno(AsmHexCode encoded) => new Setno(encoded);

        public struct Setnp : IAsmInstruction<Setnp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setnp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNP;

            public static implicit operator AsmMnemonicCode(Setnp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnp src) => AsmMnemonics.SETNP;
        }

        public static Setnp setnp() => default;

        [MethodImpl(Inline)]
        public static Setnp setnp(AsmHexCode encoded) => new Setnp(encoded);

        public struct Setns : IAsmInstruction<Setns>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setns(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNS;

            public static implicit operator AsmMnemonicCode(Setns src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setns src) => AsmMnemonics.SETNS;
        }

        public static Setns setns() => default;

        [MethodImpl(Inline)]
        public static Setns setns(AsmHexCode encoded) => new Setns(encoded);

        public struct Setnz : IAsmInstruction<Setnz>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setnz(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNZ;

            public static implicit operator AsmMnemonicCode(Setnz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnz src) => AsmMnemonics.SETNZ;
        }

        public static Setnz setnz() => default;

        [MethodImpl(Inline)]
        public static Setnz setnz(AsmHexCode encoded) => new Setnz(encoded);

        public struct Seto : IAsmInstruction<Seto>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Seto(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETO;

            public static implicit operator AsmMnemonicCode(Seto src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Seto src) => AsmMnemonics.SETO;
        }

        public static Seto seto() => default;

        [MethodImpl(Inline)]
        public static Seto seto(AsmHexCode encoded) => new Seto(encoded);

        public struct Setp : IAsmInstruction<Setp>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setp(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETP;

            public static implicit operator AsmMnemonicCode(Setp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setp src) => AsmMnemonics.SETP;
        }

        public static Setp setp() => default;

        [MethodImpl(Inline)]
        public static Setp setp(AsmHexCode encoded) => new Setp(encoded);

        public struct Setpe : IAsmInstruction<Setpe>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setpe(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETPE;

            public static implicit operator AsmMnemonicCode(Setpe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setpe src) => AsmMnemonics.SETPE;
        }

        public static Setpe setpe() => default;

        [MethodImpl(Inline)]
        public static Setpe setpe(AsmHexCode encoded) => new Setpe(encoded);

        public struct Setpo : IAsmInstruction<Setpo>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setpo(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETPO;

            public static implicit operator AsmMnemonicCode(Setpo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setpo src) => AsmMnemonics.SETPO;
        }

        public static Setpo setpo() => default;

        [MethodImpl(Inline)]
        public static Setpo setpo(AsmHexCode encoded) => new Setpo(encoded);

        public struct Sets : IAsmInstruction<Sets>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sets(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETS;

            public static implicit operator AsmMnemonicCode(Sets src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sets src) => AsmMnemonics.SETS;
        }

        public static Sets sets() => default;

        [MethodImpl(Inline)]
        public static Sets sets(AsmHexCode encoded) => new Sets(encoded);

        public struct Setz : IAsmInstruction<Setz>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Setz(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETZ;

            public static implicit operator AsmMnemonicCode(Setz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setz src) => AsmMnemonics.SETZ;
        }

        public static Setz setz() => default;

        [MethodImpl(Inline)]
        public static Setz setz(AsmHexCode encoded) => new Setz(encoded);

        public struct Sfence : IAsmInstruction<Sfence>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sfence(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SFENCE;

            public static implicit operator AsmMnemonicCode(Sfence src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sfence src) => AsmMnemonics.SFENCE;
        }

        public static Sfence sfence() => default;

        [MethodImpl(Inline)]
        public static Sfence sfence(AsmHexCode encoded) => new Sfence(encoded);

        public struct Sgdt : IAsmInstruction<Sgdt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sgdt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SGDT;

            public static implicit operator AsmMnemonicCode(Sgdt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sgdt src) => AsmMnemonics.SGDT;
        }

        public static Sgdt sgdt() => default;

        [MethodImpl(Inline)]
        public static Sgdt sgdt(AsmHexCode encoded) => new Sgdt(encoded);

        public struct Shld : IAsmInstruction<Shld>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Shld(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHLD;

            public static implicit operator AsmMnemonicCode(Shld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shld src) => AsmMnemonics.SHLD;
        }

        public static Shld shld() => default;

        [MethodImpl(Inline)]
        public static Shld shld(AsmHexCode encoded) => new Shld(encoded);

        public struct Shrd : IAsmInstruction<Shrd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Shrd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHRD;

            public static implicit operator AsmMnemonicCode(Shrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shrd src) => AsmMnemonics.SHRD;
        }

        public static Shrd shrd() => default;

        [MethodImpl(Inline)]
        public static Shrd shrd(AsmHexCode encoded) => new Shrd(encoded);

        public struct Shufpd : IAsmInstruction<Shufpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Shufpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHUFPD;

            public static implicit operator AsmMnemonicCode(Shufpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shufpd src) => AsmMnemonics.SHUFPD;
        }

        public static Shufpd shufpd() => default;

        [MethodImpl(Inline)]
        public static Shufpd shufpd(AsmHexCode encoded) => new Shufpd(encoded);

        public struct Vshufpd : IAsmInstruction<Vshufpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vshufpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSHUFPD;

            public static implicit operator AsmMnemonicCode(Vshufpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vshufpd src) => AsmMnemonics.VSHUFPD;
        }

        public static Vshufpd vshufpd() => default;

        [MethodImpl(Inline)]
        public static Vshufpd vshufpd(AsmHexCode encoded) => new Vshufpd(encoded);

        public struct Shufps : IAsmInstruction<Shufps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Shufps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHUFPS;

            public static implicit operator AsmMnemonicCode(Shufps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shufps src) => AsmMnemonics.SHUFPS;
        }

        public static Shufps shufps() => default;

        [MethodImpl(Inline)]
        public static Shufps shufps(AsmHexCode encoded) => new Shufps(encoded);

        public struct Vshufps : IAsmInstruction<Vshufps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vshufps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSHUFPS;

            public static implicit operator AsmMnemonicCode(Vshufps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vshufps src) => AsmMnemonics.VSHUFPS;
        }

        public static Vshufps vshufps() => default;

        [MethodImpl(Inline)]
        public static Vshufps vshufps(AsmHexCode encoded) => new Vshufps(encoded);

        public struct Sidt : IAsmInstruction<Sidt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sidt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SIDT;

            public static implicit operator AsmMnemonicCode(Sidt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sidt src) => AsmMnemonics.SIDT;
        }

        public static Sidt sidt() => default;

        [MethodImpl(Inline)]
        public static Sidt sidt(AsmHexCode encoded) => new Sidt(encoded);

        public struct Sldt : IAsmInstruction<Sldt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sldt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SLDT;

            public static implicit operator AsmMnemonicCode(Sldt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sldt src) => AsmMnemonics.SLDT;
        }

        public static Sldt sldt() => default;

        [MethodImpl(Inline)]
        public static Sldt sldt(AsmHexCode encoded) => new Sldt(encoded);

        public struct Smsw : IAsmInstruction<Smsw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Smsw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SMSW;

            public static implicit operator AsmMnemonicCode(Smsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Smsw src) => AsmMnemonics.SMSW;
        }

        public static Smsw smsw() => default;

        [MethodImpl(Inline)]
        public static Smsw smsw(AsmHexCode encoded) => new Smsw(encoded);

        public struct Sqrtpd : IAsmInstruction<Sqrtpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sqrtpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTPD;

            public static implicit operator AsmMnemonicCode(Sqrtpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sqrtpd src) => AsmMnemonics.SQRTPD;
        }

        public static Sqrtpd sqrtpd() => default;

        [MethodImpl(Inline)]
        public static Sqrtpd sqrtpd(AsmHexCode encoded) => new Sqrtpd(encoded);

        public struct Vsqrtpd : IAsmInstruction<Vsqrtpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vsqrtpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTPD;

            public static implicit operator AsmMnemonicCode(Vsqrtpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsqrtpd src) => AsmMnemonics.VSQRTPD;
        }

        public static Vsqrtpd vsqrtpd() => default;

        [MethodImpl(Inline)]
        public static Vsqrtpd vsqrtpd(AsmHexCode encoded) => new Vsqrtpd(encoded);

        public struct Sqrtps : IAsmInstruction<Sqrtps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sqrtps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTPS;

            public static implicit operator AsmMnemonicCode(Sqrtps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sqrtps src) => AsmMnemonics.SQRTPS;
        }

        public static Sqrtps sqrtps() => default;

        [MethodImpl(Inline)]
        public static Sqrtps sqrtps(AsmHexCode encoded) => new Sqrtps(encoded);

        public struct Vsqrtps : IAsmInstruction<Vsqrtps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vsqrtps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTPS;

            public static implicit operator AsmMnemonicCode(Vsqrtps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsqrtps src) => AsmMnemonics.VSQRTPS;
        }

        public static Vsqrtps vsqrtps() => default;

        [MethodImpl(Inline)]
        public static Vsqrtps vsqrtps(AsmHexCode encoded) => new Vsqrtps(encoded);

        public struct Sqrtsd : IAsmInstruction<Sqrtsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sqrtsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTSD;

            public static implicit operator AsmMnemonicCode(Sqrtsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sqrtsd src) => AsmMnemonics.SQRTSD;
        }

        public static Sqrtsd sqrtsd() => default;

        [MethodImpl(Inline)]
        public static Sqrtsd sqrtsd(AsmHexCode encoded) => new Sqrtsd(encoded);

        public struct Vsqrtsd : IAsmInstruction<Vsqrtsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vsqrtsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTSD;

            public static implicit operator AsmMnemonicCode(Vsqrtsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsqrtsd src) => AsmMnemonics.VSQRTSD;
        }

        public static Vsqrtsd vsqrtsd() => default;

        [MethodImpl(Inline)]
        public static Vsqrtsd vsqrtsd(AsmHexCode encoded) => new Vsqrtsd(encoded);

        public struct Sqrtss : IAsmInstruction<Sqrtss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sqrtss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTSS;

            public static implicit operator AsmMnemonicCode(Sqrtss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sqrtss src) => AsmMnemonics.SQRTSS;
        }

        public static Sqrtss sqrtss() => default;

        [MethodImpl(Inline)]
        public static Sqrtss sqrtss(AsmHexCode encoded) => new Sqrtss(encoded);

        public struct Vsqrtss : IAsmInstruction<Vsqrtss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vsqrtss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTSS;

            public static implicit operator AsmMnemonicCode(Vsqrtss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsqrtss src) => AsmMnemonics.VSQRTSS;
        }

        public static Vsqrtss vsqrtss() => default;

        [MethodImpl(Inline)]
        public static Vsqrtss vsqrtss(AsmHexCode encoded) => new Vsqrtss(encoded);

        public struct Stc : IAsmInstruction<Stc>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Stc(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STC;

            public static implicit operator AsmMnemonicCode(Stc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stc src) => AsmMnemonics.STC;
        }

        public static Stc stc() => default;

        [MethodImpl(Inline)]
        public static Stc stc(AsmHexCode encoded) => new Stc(encoded);

        public struct Std : IAsmInstruction<Std>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Std(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STD;

            public static implicit operator AsmMnemonicCode(Std src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Std src) => AsmMnemonics.STD;
        }

        public static Std std() => default;

        [MethodImpl(Inline)]
        public static Std std(AsmHexCode encoded) => new Std(encoded);

        public struct Sti : IAsmInstruction<Sti>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sti(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STI;

            public static implicit operator AsmMnemonicCode(Sti src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sti src) => AsmMnemonics.STI;
        }

        public static Sti sti() => default;

        [MethodImpl(Inline)]
        public static Sti sti(AsmHexCode encoded) => new Sti(encoded);

        public struct Stmxcsr : IAsmInstruction<Stmxcsr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Stmxcsr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STMXCSR;

            public static implicit operator AsmMnemonicCode(Stmxcsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stmxcsr src) => AsmMnemonics.STMXCSR;
        }

        public static Stmxcsr stmxcsr() => default;

        [MethodImpl(Inline)]
        public static Stmxcsr stmxcsr(AsmHexCode encoded) => new Stmxcsr(encoded);

        public struct Vstmxcsr : IAsmInstruction<Vstmxcsr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vstmxcsr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSTMXCSR;

            public static implicit operator AsmMnemonicCode(Vstmxcsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vstmxcsr src) => AsmMnemonics.VSTMXCSR;
        }

        public static Vstmxcsr vstmxcsr() => default;

        [MethodImpl(Inline)]
        public static Vstmxcsr vstmxcsr(AsmHexCode encoded) => new Vstmxcsr(encoded);

        public struct Stos : IAsmInstruction<Stos>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Stos(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STOS;

            public static implicit operator AsmMnemonicCode(Stos src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stos src) => AsmMnemonics.STOS;
        }

        public static Stos stos() => default;

        [MethodImpl(Inline)]
        public static Stos stos(AsmHexCode encoded) => new Stos(encoded);

        public struct Stosb : IAsmInstruction<Stosb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Stosb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STOSB;

            public static implicit operator AsmMnemonicCode(Stosb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stosb src) => AsmMnemonics.STOSB;
        }

        public static Stosb stosb() => default;

        [MethodImpl(Inline)]
        public static Stosb stosb(AsmHexCode encoded) => new Stosb(encoded);

        public struct Stosw : IAsmInstruction<Stosw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Stosw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STOSW;

            public static implicit operator AsmMnemonicCode(Stosw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stosw src) => AsmMnemonics.STOSW;
        }

        public static Stosw stosw() => default;

        [MethodImpl(Inline)]
        public static Stosw stosw(AsmHexCode encoded) => new Stosw(encoded);

        public struct Stosd : IAsmInstruction<Stosd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Stosd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STOSD;

            public static implicit operator AsmMnemonicCode(Stosd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stosd src) => AsmMnemonics.STOSD;
        }

        public static Stosd stosd() => default;

        [MethodImpl(Inline)]
        public static Stosd stosd(AsmHexCode encoded) => new Stosd(encoded);

        public struct Stosq : IAsmInstruction<Stosq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Stosq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STOSQ;

            public static implicit operator AsmMnemonicCode(Stosq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stosq src) => AsmMnemonics.STOSQ;
        }

        public static Stosq stosq() => default;

        [MethodImpl(Inline)]
        public static Stosq stosq(AsmHexCode encoded) => new Stosq(encoded);

        public struct Str : IAsmInstruction<Str>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Str(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STR;

            public static implicit operator AsmMnemonicCode(Str src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Str src) => AsmMnemonics.STR;
        }

        public static Str str() => default;

        [MethodImpl(Inline)]
        public static Str str(AsmHexCode encoded) => new Str(encoded);

        public struct Sub : IAsmInstruction<Sub>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sub(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUB;

            public static implicit operator AsmMnemonicCode(Sub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sub src) => AsmMnemonics.SUB;
        }

        public static Sub sub() => default;

        [MethodImpl(Inline)]
        public static Sub sub(AsmHexCode encoded) => new Sub(encoded);

        public struct Subpd : IAsmInstruction<Subpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Subpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBPD;

            public static implicit operator AsmMnemonicCode(Subpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Subpd src) => AsmMnemonics.SUBPD;
        }

        public static Subpd subpd() => default;

        [MethodImpl(Inline)]
        public static Subpd subpd(AsmHexCode encoded) => new Subpd(encoded);

        public struct Vsubpd : IAsmInstruction<Vsubpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vsubpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBPD;

            public static implicit operator AsmMnemonicCode(Vsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsubpd src) => AsmMnemonics.VSUBPD;
        }

        public static Vsubpd vsubpd() => default;

        [MethodImpl(Inline)]
        public static Vsubpd vsubpd(AsmHexCode encoded) => new Vsubpd(encoded);

        public struct Subps : IAsmInstruction<Subps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Subps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBPS;

            public static implicit operator AsmMnemonicCode(Subps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Subps src) => AsmMnemonics.SUBPS;
        }

        public static Subps subps() => default;

        [MethodImpl(Inline)]
        public static Subps subps(AsmHexCode encoded) => new Subps(encoded);

        public struct Vsubps : IAsmInstruction<Vsubps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vsubps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBPS;

            public static implicit operator AsmMnemonicCode(Vsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsubps src) => AsmMnemonics.VSUBPS;
        }

        public static Vsubps vsubps() => default;

        [MethodImpl(Inline)]
        public static Vsubps vsubps(AsmHexCode encoded) => new Vsubps(encoded);

        public struct Subsd : IAsmInstruction<Subsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Subsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBSD;

            public static implicit operator AsmMnemonicCode(Subsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Subsd src) => AsmMnemonics.SUBSD;
        }

        public static Subsd subsd() => default;

        [MethodImpl(Inline)]
        public static Subsd subsd(AsmHexCode encoded) => new Subsd(encoded);

        public struct Vsubsd : IAsmInstruction<Vsubsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vsubsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBSD;

            public static implicit operator AsmMnemonicCode(Vsubsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsubsd src) => AsmMnemonics.VSUBSD;
        }

        public static Vsubsd vsubsd() => default;

        [MethodImpl(Inline)]
        public static Vsubsd vsubsd(AsmHexCode encoded) => new Vsubsd(encoded);

        public struct Subss : IAsmInstruction<Subss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Subss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBSS;

            public static implicit operator AsmMnemonicCode(Subss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Subss src) => AsmMnemonics.SUBSS;
        }

        public static Subss subss() => default;

        [MethodImpl(Inline)]
        public static Subss subss(AsmHexCode encoded) => new Subss(encoded);

        public struct Vsubss : IAsmInstruction<Vsubss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vsubss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBSS;

            public static implicit operator AsmMnemonicCode(Vsubss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsubss src) => AsmMnemonics.VSUBSS;
        }

        public static Vsubss vsubss() => default;

        [MethodImpl(Inline)]
        public static Vsubss vsubss(AsmHexCode encoded) => new Vsubss(encoded);

        public struct Swapgs : IAsmInstruction<Swapgs>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Swapgs(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SWAPGS;

            public static implicit operator AsmMnemonicCode(Swapgs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Swapgs src) => AsmMnemonics.SWAPGS;
        }

        public static Swapgs swapgs() => default;

        [MethodImpl(Inline)]
        public static Swapgs swapgs(AsmHexCode encoded) => new Swapgs(encoded);

        public struct Syscall : IAsmInstruction<Syscall>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Syscall(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SYSCALL;

            public static implicit operator AsmMnemonicCode(Syscall src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Syscall src) => AsmMnemonics.SYSCALL;
        }

        public static Syscall syscall() => default;

        [MethodImpl(Inline)]
        public static Syscall syscall(AsmHexCode encoded) => new Syscall(encoded);

        public struct Sysenter : IAsmInstruction<Sysenter>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sysenter(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SYSENTER;

            public static implicit operator AsmMnemonicCode(Sysenter src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sysenter src) => AsmMnemonics.SYSENTER;
        }

        public static Sysenter sysenter() => default;

        [MethodImpl(Inline)]
        public static Sysenter sysenter(AsmHexCode encoded) => new Sysenter(encoded);

        public struct Sysexit : IAsmInstruction<Sysexit>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sysexit(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SYSEXIT;

            public static implicit operator AsmMnemonicCode(Sysexit src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sysexit src) => AsmMnemonics.SYSEXIT;
        }

        public static Sysexit sysexit() => default;

        [MethodImpl(Inline)]
        public static Sysexit sysexit(AsmHexCode encoded) => new Sysexit(encoded);

        public struct Sysret : IAsmInstruction<Sysret>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Sysret(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SYSRET;

            public static implicit operator AsmMnemonicCode(Sysret src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sysret src) => AsmMnemonics.SYSRET;
        }

        public static Sysret sysret() => default;

        [MethodImpl(Inline)]
        public static Sysret sysret(AsmHexCode encoded) => new Sysret(encoded);

        public struct Test : IAsmInstruction<Test>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Test(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.TEST;

            public static implicit operator AsmMnemonicCode(Test src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Test src) => AsmMnemonics.TEST;
        }

        public static Test test() => default;

        [MethodImpl(Inline)]
        public static Test test(AsmHexCode encoded) => new Test(encoded);

        public struct Tzcnt : IAsmInstruction<Tzcnt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Tzcnt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.TZCNT;

            public static implicit operator AsmMnemonicCode(Tzcnt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Tzcnt src) => AsmMnemonics.TZCNT;
        }

        public static Tzcnt tzcnt() => default;

        [MethodImpl(Inline)]
        public static Tzcnt tzcnt(AsmHexCode encoded) => new Tzcnt(encoded);

        public struct Ucomisd : IAsmInstruction<Ucomisd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ucomisd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UCOMISD;

            public static implicit operator AsmMnemonicCode(Ucomisd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ucomisd src) => AsmMnemonics.UCOMISD;
        }

        public static Ucomisd ucomisd() => default;

        [MethodImpl(Inline)]
        public static Ucomisd ucomisd(AsmHexCode encoded) => new Ucomisd(encoded);

        public struct Vucomisd : IAsmInstruction<Vucomisd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vucomisd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUCOMISD;

            public static implicit operator AsmMnemonicCode(Vucomisd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vucomisd src) => AsmMnemonics.VUCOMISD;
        }

        public static Vucomisd vucomisd() => default;

        [MethodImpl(Inline)]
        public static Vucomisd vucomisd(AsmHexCode encoded) => new Vucomisd(encoded);

        public struct Ucomiss : IAsmInstruction<Ucomiss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ucomiss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UCOMISS;

            public static implicit operator AsmMnemonicCode(Ucomiss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ucomiss src) => AsmMnemonics.UCOMISS;
        }

        public static Ucomiss ucomiss() => default;

        [MethodImpl(Inline)]
        public static Ucomiss ucomiss(AsmHexCode encoded) => new Ucomiss(encoded);

        public struct Vucomiss : IAsmInstruction<Vucomiss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vucomiss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUCOMISS;

            public static implicit operator AsmMnemonicCode(Vucomiss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vucomiss src) => AsmMnemonics.VUCOMISS;
        }

        public static Vucomiss vucomiss() => default;

        [MethodImpl(Inline)]
        public static Vucomiss vucomiss(AsmHexCode encoded) => new Vucomiss(encoded);

        public struct Ud2 : IAsmInstruction<Ud2>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Ud2(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UD2;

            public static implicit operator AsmMnemonicCode(Ud2 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ud2 src) => AsmMnemonics.UD2;
        }

        public static Ud2 ud2() => default;

        [MethodImpl(Inline)]
        public static Ud2 ud2(AsmHexCode encoded) => new Ud2(encoded);

        public struct Unpckhpd : IAsmInstruction<Unpckhpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Unpckhpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKHPD;

            public static implicit operator AsmMnemonicCode(Unpckhpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Unpckhpd src) => AsmMnemonics.UNPCKHPD;
        }

        public static Unpckhpd unpckhpd() => default;

        [MethodImpl(Inline)]
        public static Unpckhpd unpckhpd(AsmHexCode encoded) => new Unpckhpd(encoded);

        public struct Vunpckhpd : IAsmInstruction<Vunpckhpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vunpckhpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKHPD;

            public static implicit operator AsmMnemonicCode(Vunpckhpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vunpckhpd src) => AsmMnemonics.VUNPCKHPD;
        }

        public static Vunpckhpd vunpckhpd() => default;

        [MethodImpl(Inline)]
        public static Vunpckhpd vunpckhpd(AsmHexCode encoded) => new Vunpckhpd(encoded);

        public struct Unpckhps : IAsmInstruction<Unpckhps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Unpckhps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKHPS;

            public static implicit operator AsmMnemonicCode(Unpckhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Unpckhps src) => AsmMnemonics.UNPCKHPS;
        }

        public static Unpckhps unpckhps() => default;

        [MethodImpl(Inline)]
        public static Unpckhps unpckhps(AsmHexCode encoded) => new Unpckhps(encoded);

        public struct Vunpckhps : IAsmInstruction<Vunpckhps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vunpckhps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKHPS;

            public static implicit operator AsmMnemonicCode(Vunpckhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vunpckhps src) => AsmMnemonics.VUNPCKHPS;
        }

        public static Vunpckhps vunpckhps() => default;

        [MethodImpl(Inline)]
        public static Vunpckhps vunpckhps(AsmHexCode encoded) => new Vunpckhps(encoded);

        public struct Unpcklpd : IAsmInstruction<Unpcklpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Unpcklpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKLPD;

            public static implicit operator AsmMnemonicCode(Unpcklpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Unpcklpd src) => AsmMnemonics.UNPCKLPD;
        }

        public static Unpcklpd unpcklpd() => default;

        [MethodImpl(Inline)]
        public static Unpcklpd unpcklpd(AsmHexCode encoded) => new Unpcklpd(encoded);

        public struct Vunpcklpd : IAsmInstruction<Vunpcklpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vunpcklpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKLPD;

            public static implicit operator AsmMnemonicCode(Vunpcklpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vunpcklpd src) => AsmMnemonics.VUNPCKLPD;
        }

        public static Vunpcklpd vunpcklpd() => default;

        [MethodImpl(Inline)]
        public static Vunpcklpd vunpcklpd(AsmHexCode encoded) => new Vunpcklpd(encoded);

        public struct Unpcklps : IAsmInstruction<Unpcklps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Unpcklps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKLPS;

            public static implicit operator AsmMnemonicCode(Unpcklps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Unpcklps src) => AsmMnemonics.UNPCKLPS;
        }

        public static Unpcklps unpcklps() => default;

        [MethodImpl(Inline)]
        public static Unpcklps unpcklps(AsmHexCode encoded) => new Unpcklps(encoded);

        public struct Vunpcklps : IAsmInstruction<Vunpcklps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vunpcklps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKLPS;

            public static implicit operator AsmMnemonicCode(Vunpcklps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vunpcklps src) => AsmMnemonics.VUNPCKLPS;
        }

        public static Vunpcklps vunpcklps() => default;

        [MethodImpl(Inline)]
        public static Vunpcklps vunpcklps(AsmHexCode encoded) => new Vunpcklps(encoded);

        public struct Vbroadcastss : IAsmInstruction<Vbroadcastss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vbroadcastss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTSS;

            public static implicit operator AsmMnemonicCode(Vbroadcastss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vbroadcastss src) => AsmMnemonics.VBROADCASTSS;
        }

        public static Vbroadcastss vbroadcastss() => default;

        [MethodImpl(Inline)]
        public static Vbroadcastss vbroadcastss(AsmHexCode encoded) => new Vbroadcastss(encoded);

        public struct Vbroadcastsd : IAsmInstruction<Vbroadcastsd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vbroadcastsd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTSD;

            public static implicit operator AsmMnemonicCode(Vbroadcastsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vbroadcastsd src) => AsmMnemonics.VBROADCASTSD;
        }

        public static Vbroadcastsd vbroadcastsd() => default;

        [MethodImpl(Inline)]
        public static Vbroadcastsd vbroadcastsd(AsmHexCode encoded) => new Vbroadcastsd(encoded);

        public struct Vbroadcastf128 : IAsmInstruction<Vbroadcastf128>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vbroadcastf128(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTF128;

            public static implicit operator AsmMnemonicCode(Vbroadcastf128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vbroadcastf128 src) => AsmMnemonics.VBROADCASTF128;
        }

        public static Vbroadcastf128 vbroadcastf128() => default;

        [MethodImpl(Inline)]
        public static Vbroadcastf128 vbroadcastf128(AsmHexCode encoded) => new Vbroadcastf128(encoded);

        public struct Vcvtph2ps : IAsmInstruction<Vcvtph2ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtph2ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPH2PS;

            public static implicit operator AsmMnemonicCode(Vcvtph2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtph2ps src) => AsmMnemonics.VCVTPH2PS;
        }

        public static Vcvtph2ps vcvtph2ps() => default;

        [MethodImpl(Inline)]
        public static Vcvtph2ps vcvtph2ps(AsmHexCode encoded) => new Vcvtph2ps(encoded);

        public struct Vcvtps2ph : IAsmInstruction<Vcvtps2ph>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vcvtps2ph(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPS2PH;

            public static implicit operator AsmMnemonicCode(Vcvtps2ph src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtps2ph src) => AsmMnemonics.VCVTPS2PH;
        }

        public static Vcvtps2ph vcvtps2ph() => default;

        [MethodImpl(Inline)]
        public static Vcvtps2ph vcvtps2ph(AsmHexCode encoded) => new Vcvtps2ph(encoded);

        public struct Verr : IAsmInstruction<Verr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Verr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VERR;

            public static implicit operator AsmMnemonicCode(Verr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Verr src) => AsmMnemonics.VERR;
        }

        public static Verr verr() => default;

        [MethodImpl(Inline)]
        public static Verr verr(AsmHexCode encoded) => new Verr(encoded);

        public struct Verw : IAsmInstruction<Verw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Verw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VERW;

            public static implicit operator AsmMnemonicCode(Verw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Verw src) => AsmMnemonics.VERW;
        }

        public static Verw verw() => default;

        [MethodImpl(Inline)]
        public static Verw verw(AsmHexCode encoded) => new Verw(encoded);

        public struct Vextractf128 : IAsmInstruction<Vextractf128>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vextractf128(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VEXTRACTF128;

            public static implicit operator AsmMnemonicCode(Vextractf128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vextractf128 src) => AsmMnemonics.VEXTRACTF128;
        }

        public static Vextractf128 vextractf128() => default;

        [MethodImpl(Inline)]
        public static Vextractf128 vextractf128(AsmHexCode encoded) => new Vextractf128(encoded);

        public struct Vextracti128 : IAsmInstruction<Vextracti128>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vextracti128(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VEXTRACTI128;

            public static implicit operator AsmMnemonicCode(Vextracti128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vextracti128 src) => AsmMnemonics.VEXTRACTI128;
        }

        public static Vextracti128 vextracti128() => default;

        [MethodImpl(Inline)]
        public static Vextracti128 vextracti128(AsmHexCode encoded) => new Vextracti128(encoded);

        public struct Vfmadd132pd : IAsmInstruction<Vfmadd132pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmadd132pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132PD;

            public static implicit operator AsmMnemonicCode(Vfmadd132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd132pd src) => AsmMnemonics.VFMADD132PD;
        }

        public static Vfmadd132pd vfmadd132pd() => default;

        [MethodImpl(Inline)]
        public static Vfmadd132pd vfmadd132pd(AsmHexCode encoded) => new Vfmadd132pd(encoded);

        public struct Vfmadd213pd : IAsmInstruction<Vfmadd213pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmadd213pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213PD;

            public static implicit operator AsmMnemonicCode(Vfmadd213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd213pd src) => AsmMnemonics.VFMADD213PD;
        }

        public static Vfmadd213pd vfmadd213pd() => default;

        [MethodImpl(Inline)]
        public static Vfmadd213pd vfmadd213pd(AsmHexCode encoded) => new Vfmadd213pd(encoded);

        public struct Vfmadd231pd : IAsmInstruction<Vfmadd231pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmadd231pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231PD;

            public static implicit operator AsmMnemonicCode(Vfmadd231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd231pd src) => AsmMnemonics.VFMADD231PD;
        }

        public static Vfmadd231pd vfmadd231pd() => default;

        [MethodImpl(Inline)]
        public static Vfmadd231pd vfmadd231pd(AsmHexCode encoded) => new Vfmadd231pd(encoded);

        public struct Vfmadd132ps : IAsmInstruction<Vfmadd132ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmadd132ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132PS;

            public static implicit operator AsmMnemonicCode(Vfmadd132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd132ps src) => AsmMnemonics.VFMADD132PS;
        }

        public static Vfmadd132ps vfmadd132ps() => default;

        [MethodImpl(Inline)]
        public static Vfmadd132ps vfmadd132ps(AsmHexCode encoded) => new Vfmadd132ps(encoded);

        public struct Vfmadd213ps : IAsmInstruction<Vfmadd213ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmadd213ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213PS;

            public static implicit operator AsmMnemonicCode(Vfmadd213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd213ps src) => AsmMnemonics.VFMADD213PS;
        }

        public static Vfmadd213ps vfmadd213ps() => default;

        [MethodImpl(Inline)]
        public static Vfmadd213ps vfmadd213ps(AsmHexCode encoded) => new Vfmadd213ps(encoded);

        public struct Vfmadd231ps : IAsmInstruction<Vfmadd231ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmadd231ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231PS;

            public static implicit operator AsmMnemonicCode(Vfmadd231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd231ps src) => AsmMnemonics.VFMADD231PS;
        }

        public static Vfmadd231ps vfmadd231ps() => default;

        [MethodImpl(Inline)]
        public static Vfmadd231ps vfmadd231ps(AsmHexCode encoded) => new Vfmadd231ps(encoded);

        public struct Vfmadd132sd : IAsmInstruction<Vfmadd132sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmadd132sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132SD;

            public static implicit operator AsmMnemonicCode(Vfmadd132sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd132sd src) => AsmMnemonics.VFMADD132SD;
        }

        public static Vfmadd132sd vfmadd132sd() => default;

        [MethodImpl(Inline)]
        public static Vfmadd132sd vfmadd132sd(AsmHexCode encoded) => new Vfmadd132sd(encoded);

        public struct Vfmadd213sd : IAsmInstruction<Vfmadd213sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmadd213sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213SD;

            public static implicit operator AsmMnemonicCode(Vfmadd213sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd213sd src) => AsmMnemonics.VFMADD213SD;
        }

        public static Vfmadd213sd vfmadd213sd() => default;

        [MethodImpl(Inline)]
        public static Vfmadd213sd vfmadd213sd(AsmHexCode encoded) => new Vfmadd213sd(encoded);

        public struct Vfmadd231sd : IAsmInstruction<Vfmadd231sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmadd231sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231SD;

            public static implicit operator AsmMnemonicCode(Vfmadd231sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd231sd src) => AsmMnemonics.VFMADD231SD;
        }

        public static Vfmadd231sd vfmadd231sd() => default;

        [MethodImpl(Inline)]
        public static Vfmadd231sd vfmadd231sd(AsmHexCode encoded) => new Vfmadd231sd(encoded);

        public struct Vfmadd132ss : IAsmInstruction<Vfmadd132ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmadd132ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132SS;

            public static implicit operator AsmMnemonicCode(Vfmadd132ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd132ss src) => AsmMnemonics.VFMADD132SS;
        }

        public static Vfmadd132ss vfmadd132ss() => default;

        [MethodImpl(Inline)]
        public static Vfmadd132ss vfmadd132ss(AsmHexCode encoded) => new Vfmadd132ss(encoded);

        public struct Vfmadd213ss : IAsmInstruction<Vfmadd213ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmadd213ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213SS;

            public static implicit operator AsmMnemonicCode(Vfmadd213ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd213ss src) => AsmMnemonics.VFMADD213SS;
        }

        public static Vfmadd213ss vfmadd213ss() => default;

        [MethodImpl(Inline)]
        public static Vfmadd213ss vfmadd213ss(AsmHexCode encoded) => new Vfmadd213ss(encoded);

        public struct Vfmadd231ss : IAsmInstruction<Vfmadd231ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmadd231ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231SS;

            public static implicit operator AsmMnemonicCode(Vfmadd231ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd231ss src) => AsmMnemonics.VFMADD231SS;
        }

        public static Vfmadd231ss vfmadd231ss() => default;

        [MethodImpl(Inline)]
        public static Vfmadd231ss vfmadd231ss(AsmHexCode encoded) => new Vfmadd231ss(encoded);

        public struct Vfmaddsub132pd : IAsmInstruction<Vfmaddsub132pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmaddsub132pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB132PD;

            public static implicit operator AsmMnemonicCode(Vfmaddsub132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub132pd src) => AsmMnemonics.VFMADDSUB132PD;
        }

        public static Vfmaddsub132pd vfmaddsub132pd() => default;

        [MethodImpl(Inline)]
        public static Vfmaddsub132pd vfmaddsub132pd(AsmHexCode encoded) => new Vfmaddsub132pd(encoded);

        public struct Vfmaddsub213pd : IAsmInstruction<Vfmaddsub213pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmaddsub213pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB213PD;

            public static implicit operator AsmMnemonicCode(Vfmaddsub213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub213pd src) => AsmMnemonics.VFMADDSUB213PD;
        }

        public static Vfmaddsub213pd vfmaddsub213pd() => default;

        [MethodImpl(Inline)]
        public static Vfmaddsub213pd vfmaddsub213pd(AsmHexCode encoded) => new Vfmaddsub213pd(encoded);

        public struct Vfmaddsub231pd : IAsmInstruction<Vfmaddsub231pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmaddsub231pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB231PD;

            public static implicit operator AsmMnemonicCode(Vfmaddsub231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub231pd src) => AsmMnemonics.VFMADDSUB231PD;
        }

        public static Vfmaddsub231pd vfmaddsub231pd() => default;

        [MethodImpl(Inline)]
        public static Vfmaddsub231pd vfmaddsub231pd(AsmHexCode encoded) => new Vfmaddsub231pd(encoded);

        public struct Vfmaddsub132ps : IAsmInstruction<Vfmaddsub132ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmaddsub132ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB132PS;

            public static implicit operator AsmMnemonicCode(Vfmaddsub132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub132ps src) => AsmMnemonics.VFMADDSUB132PS;
        }

        public static Vfmaddsub132ps vfmaddsub132ps() => default;

        [MethodImpl(Inline)]
        public static Vfmaddsub132ps vfmaddsub132ps(AsmHexCode encoded) => new Vfmaddsub132ps(encoded);

        public struct Vfmaddsub213ps : IAsmInstruction<Vfmaddsub213ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmaddsub213ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB213PS;

            public static implicit operator AsmMnemonicCode(Vfmaddsub213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub213ps src) => AsmMnemonics.VFMADDSUB213PS;
        }

        public static Vfmaddsub213ps vfmaddsub213ps() => default;

        [MethodImpl(Inline)]
        public static Vfmaddsub213ps vfmaddsub213ps(AsmHexCode encoded) => new Vfmaddsub213ps(encoded);

        public struct Vfmaddsub231ps : IAsmInstruction<Vfmaddsub231ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmaddsub231ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB231PS;

            public static implicit operator AsmMnemonicCode(Vfmaddsub231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub231ps src) => AsmMnemonics.VFMADDSUB231PS;
        }

        public static Vfmaddsub231ps vfmaddsub231ps() => default;

        [MethodImpl(Inline)]
        public static Vfmaddsub231ps vfmaddsub231ps(AsmHexCode encoded) => new Vfmaddsub231ps(encoded);

        public struct Vfmsubadd132pd : IAsmInstruction<Vfmsubadd132pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsubadd132pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD132PD;

            public static implicit operator AsmMnemonicCode(Vfmsubadd132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd132pd src) => AsmMnemonics.VFMSUBADD132PD;
        }

        public static Vfmsubadd132pd vfmsubadd132pd() => default;

        [MethodImpl(Inline)]
        public static Vfmsubadd132pd vfmsubadd132pd(AsmHexCode encoded) => new Vfmsubadd132pd(encoded);

        public struct Vfmsubadd213pd : IAsmInstruction<Vfmsubadd213pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsubadd213pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD213PD;

            public static implicit operator AsmMnemonicCode(Vfmsubadd213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd213pd src) => AsmMnemonics.VFMSUBADD213PD;
        }

        public static Vfmsubadd213pd vfmsubadd213pd() => default;

        [MethodImpl(Inline)]
        public static Vfmsubadd213pd vfmsubadd213pd(AsmHexCode encoded) => new Vfmsubadd213pd(encoded);

        public struct Vfmsubadd231pd : IAsmInstruction<Vfmsubadd231pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsubadd231pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD231PD;

            public static implicit operator AsmMnemonicCode(Vfmsubadd231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd231pd src) => AsmMnemonics.VFMSUBADD231PD;
        }

        public static Vfmsubadd231pd vfmsubadd231pd() => default;

        [MethodImpl(Inline)]
        public static Vfmsubadd231pd vfmsubadd231pd(AsmHexCode encoded) => new Vfmsubadd231pd(encoded);

        public struct Vfmsubadd132ps : IAsmInstruction<Vfmsubadd132ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsubadd132ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD132PS;

            public static implicit operator AsmMnemonicCode(Vfmsubadd132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd132ps src) => AsmMnemonics.VFMSUBADD132PS;
        }

        public static Vfmsubadd132ps vfmsubadd132ps() => default;

        [MethodImpl(Inline)]
        public static Vfmsubadd132ps vfmsubadd132ps(AsmHexCode encoded) => new Vfmsubadd132ps(encoded);

        public struct Vfmsubadd213ps : IAsmInstruction<Vfmsubadd213ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsubadd213ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD213PS;

            public static implicit operator AsmMnemonicCode(Vfmsubadd213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd213ps src) => AsmMnemonics.VFMSUBADD213PS;
        }

        public static Vfmsubadd213ps vfmsubadd213ps() => default;

        [MethodImpl(Inline)]
        public static Vfmsubadd213ps vfmsubadd213ps(AsmHexCode encoded) => new Vfmsubadd213ps(encoded);

        public struct Vfmsubadd231ps : IAsmInstruction<Vfmsubadd231ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsubadd231ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD231PS;

            public static implicit operator AsmMnemonicCode(Vfmsubadd231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd231ps src) => AsmMnemonics.VFMSUBADD231PS;
        }

        public static Vfmsubadd231ps vfmsubadd231ps() => default;

        [MethodImpl(Inline)]
        public static Vfmsubadd231ps vfmsubadd231ps(AsmHexCode encoded) => new Vfmsubadd231ps(encoded);

        public struct Vfmsub132pd : IAsmInstruction<Vfmsub132pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsub132pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132PD;

            public static implicit operator AsmMnemonicCode(Vfmsub132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub132pd src) => AsmMnemonics.VFMSUB132PD;
        }

        public static Vfmsub132pd vfmsub132pd() => default;

        [MethodImpl(Inline)]
        public static Vfmsub132pd vfmsub132pd(AsmHexCode encoded) => new Vfmsub132pd(encoded);

        public struct Vfmsub213pd : IAsmInstruction<Vfmsub213pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsub213pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213PD;

            public static implicit operator AsmMnemonicCode(Vfmsub213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub213pd src) => AsmMnemonics.VFMSUB213PD;
        }

        public static Vfmsub213pd vfmsub213pd() => default;

        [MethodImpl(Inline)]
        public static Vfmsub213pd vfmsub213pd(AsmHexCode encoded) => new Vfmsub213pd(encoded);

        public struct Vfmsub231pd : IAsmInstruction<Vfmsub231pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsub231pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231PD;

            public static implicit operator AsmMnemonicCode(Vfmsub231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub231pd src) => AsmMnemonics.VFMSUB231PD;
        }

        public static Vfmsub231pd vfmsub231pd() => default;

        [MethodImpl(Inline)]
        public static Vfmsub231pd vfmsub231pd(AsmHexCode encoded) => new Vfmsub231pd(encoded);

        public struct Vfmsub132ps : IAsmInstruction<Vfmsub132ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsub132ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132PS;

            public static implicit operator AsmMnemonicCode(Vfmsub132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub132ps src) => AsmMnemonics.VFMSUB132PS;
        }

        public static Vfmsub132ps vfmsub132ps() => default;

        [MethodImpl(Inline)]
        public static Vfmsub132ps vfmsub132ps(AsmHexCode encoded) => new Vfmsub132ps(encoded);

        public struct Vfmsub213ps : IAsmInstruction<Vfmsub213ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsub213ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213PS;

            public static implicit operator AsmMnemonicCode(Vfmsub213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub213ps src) => AsmMnemonics.VFMSUB213PS;
        }

        public static Vfmsub213ps vfmsub213ps() => default;

        [MethodImpl(Inline)]
        public static Vfmsub213ps vfmsub213ps(AsmHexCode encoded) => new Vfmsub213ps(encoded);

        public struct Vfmsub231ps : IAsmInstruction<Vfmsub231ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsub231ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231PS;

            public static implicit operator AsmMnemonicCode(Vfmsub231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub231ps src) => AsmMnemonics.VFMSUB231PS;
        }

        public static Vfmsub231ps vfmsub231ps() => default;

        [MethodImpl(Inline)]
        public static Vfmsub231ps vfmsub231ps(AsmHexCode encoded) => new Vfmsub231ps(encoded);

        public struct Vfmsub132sd : IAsmInstruction<Vfmsub132sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsub132sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132SD;

            public static implicit operator AsmMnemonicCode(Vfmsub132sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub132sd src) => AsmMnemonics.VFMSUB132SD;
        }

        public static Vfmsub132sd vfmsub132sd() => default;

        [MethodImpl(Inline)]
        public static Vfmsub132sd vfmsub132sd(AsmHexCode encoded) => new Vfmsub132sd(encoded);

        public struct Vfmsub213sd : IAsmInstruction<Vfmsub213sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsub213sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213SD;

            public static implicit operator AsmMnemonicCode(Vfmsub213sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub213sd src) => AsmMnemonics.VFMSUB213SD;
        }

        public static Vfmsub213sd vfmsub213sd() => default;

        [MethodImpl(Inline)]
        public static Vfmsub213sd vfmsub213sd(AsmHexCode encoded) => new Vfmsub213sd(encoded);

        public struct Vfmsub231sd : IAsmInstruction<Vfmsub231sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsub231sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231SD;

            public static implicit operator AsmMnemonicCode(Vfmsub231sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub231sd src) => AsmMnemonics.VFMSUB231SD;
        }

        public static Vfmsub231sd vfmsub231sd() => default;

        [MethodImpl(Inline)]
        public static Vfmsub231sd vfmsub231sd(AsmHexCode encoded) => new Vfmsub231sd(encoded);

        public struct Vfmsub132ss : IAsmInstruction<Vfmsub132ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsub132ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132SS;

            public static implicit operator AsmMnemonicCode(Vfmsub132ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub132ss src) => AsmMnemonics.VFMSUB132SS;
        }

        public static Vfmsub132ss vfmsub132ss() => default;

        [MethodImpl(Inline)]
        public static Vfmsub132ss vfmsub132ss(AsmHexCode encoded) => new Vfmsub132ss(encoded);

        public struct Vfmsub213ss : IAsmInstruction<Vfmsub213ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsub213ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213SS;

            public static implicit operator AsmMnemonicCode(Vfmsub213ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub213ss src) => AsmMnemonics.VFMSUB213SS;
        }

        public static Vfmsub213ss vfmsub213ss() => default;

        [MethodImpl(Inline)]
        public static Vfmsub213ss vfmsub213ss(AsmHexCode encoded) => new Vfmsub213ss(encoded);

        public struct Vfmsub231ss : IAsmInstruction<Vfmsub231ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfmsub231ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231SS;

            public static implicit operator AsmMnemonicCode(Vfmsub231ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub231ss src) => AsmMnemonics.VFMSUB231SS;
        }

        public static Vfmsub231ss vfmsub231ss() => default;

        [MethodImpl(Inline)]
        public static Vfmsub231ss vfmsub231ss(AsmHexCode encoded) => new Vfmsub231ss(encoded);

        public struct Vfnmadd132pd : IAsmInstruction<Vfnmadd132pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmadd132pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132PD;

            public static implicit operator AsmMnemonicCode(Vfnmadd132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd132pd src) => AsmMnemonics.VFNMADD132PD;
        }

        public static Vfnmadd132pd vfnmadd132pd() => default;

        [MethodImpl(Inline)]
        public static Vfnmadd132pd vfnmadd132pd(AsmHexCode encoded) => new Vfnmadd132pd(encoded);

        public struct Vfnmadd213pd : IAsmInstruction<Vfnmadd213pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmadd213pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213PD;

            public static implicit operator AsmMnemonicCode(Vfnmadd213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd213pd src) => AsmMnemonics.VFNMADD213PD;
        }

        public static Vfnmadd213pd vfnmadd213pd() => default;

        [MethodImpl(Inline)]
        public static Vfnmadd213pd vfnmadd213pd(AsmHexCode encoded) => new Vfnmadd213pd(encoded);

        public struct Vfnmadd231pd : IAsmInstruction<Vfnmadd231pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmadd231pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231PD;

            public static implicit operator AsmMnemonicCode(Vfnmadd231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd231pd src) => AsmMnemonics.VFNMADD231PD;
        }

        public static Vfnmadd231pd vfnmadd231pd() => default;

        [MethodImpl(Inline)]
        public static Vfnmadd231pd vfnmadd231pd(AsmHexCode encoded) => new Vfnmadd231pd(encoded);

        public struct Vfnmadd132ps : IAsmInstruction<Vfnmadd132ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmadd132ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132PS;

            public static implicit operator AsmMnemonicCode(Vfnmadd132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd132ps src) => AsmMnemonics.VFNMADD132PS;
        }

        public static Vfnmadd132ps vfnmadd132ps() => default;

        [MethodImpl(Inline)]
        public static Vfnmadd132ps vfnmadd132ps(AsmHexCode encoded) => new Vfnmadd132ps(encoded);

        public struct Vfnmadd213ps : IAsmInstruction<Vfnmadd213ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmadd213ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213PS;

            public static implicit operator AsmMnemonicCode(Vfnmadd213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd213ps src) => AsmMnemonics.VFNMADD213PS;
        }

        public static Vfnmadd213ps vfnmadd213ps() => default;

        [MethodImpl(Inline)]
        public static Vfnmadd213ps vfnmadd213ps(AsmHexCode encoded) => new Vfnmadd213ps(encoded);

        public struct Vfnmadd231ps : IAsmInstruction<Vfnmadd231ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmadd231ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231PS;

            public static implicit operator AsmMnemonicCode(Vfnmadd231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd231ps src) => AsmMnemonics.VFNMADD231PS;
        }

        public static Vfnmadd231ps vfnmadd231ps() => default;

        [MethodImpl(Inline)]
        public static Vfnmadd231ps vfnmadd231ps(AsmHexCode encoded) => new Vfnmadd231ps(encoded);

        public struct Vfnmadd132sd : IAsmInstruction<Vfnmadd132sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmadd132sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132SD;

            public static implicit operator AsmMnemonicCode(Vfnmadd132sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd132sd src) => AsmMnemonics.VFNMADD132SD;
        }

        public static Vfnmadd132sd vfnmadd132sd() => default;

        [MethodImpl(Inline)]
        public static Vfnmadd132sd vfnmadd132sd(AsmHexCode encoded) => new Vfnmadd132sd(encoded);

        public struct Vfnmadd213sd : IAsmInstruction<Vfnmadd213sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmadd213sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213SD;

            public static implicit operator AsmMnemonicCode(Vfnmadd213sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd213sd src) => AsmMnemonics.VFNMADD213SD;
        }

        public static Vfnmadd213sd vfnmadd213sd() => default;

        [MethodImpl(Inline)]
        public static Vfnmadd213sd vfnmadd213sd(AsmHexCode encoded) => new Vfnmadd213sd(encoded);

        public struct Vfnmadd231sd : IAsmInstruction<Vfnmadd231sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmadd231sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231SD;

            public static implicit operator AsmMnemonicCode(Vfnmadd231sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd231sd src) => AsmMnemonics.VFNMADD231SD;
        }

        public static Vfnmadd231sd vfnmadd231sd() => default;

        [MethodImpl(Inline)]
        public static Vfnmadd231sd vfnmadd231sd(AsmHexCode encoded) => new Vfnmadd231sd(encoded);

        public struct Vfnmadd132ss : IAsmInstruction<Vfnmadd132ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmadd132ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132SS;

            public static implicit operator AsmMnemonicCode(Vfnmadd132ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd132ss src) => AsmMnemonics.VFNMADD132SS;
        }

        public static Vfnmadd132ss vfnmadd132ss() => default;

        [MethodImpl(Inline)]
        public static Vfnmadd132ss vfnmadd132ss(AsmHexCode encoded) => new Vfnmadd132ss(encoded);

        public struct Vfnmadd213ss : IAsmInstruction<Vfnmadd213ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmadd213ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213SS;

            public static implicit operator AsmMnemonicCode(Vfnmadd213ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd213ss src) => AsmMnemonics.VFNMADD213SS;
        }

        public static Vfnmadd213ss vfnmadd213ss() => default;

        [MethodImpl(Inline)]
        public static Vfnmadd213ss vfnmadd213ss(AsmHexCode encoded) => new Vfnmadd213ss(encoded);

        public struct Vfnmadd231ss : IAsmInstruction<Vfnmadd231ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmadd231ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231SS;

            public static implicit operator AsmMnemonicCode(Vfnmadd231ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd231ss src) => AsmMnemonics.VFNMADD231SS;
        }

        public static Vfnmadd231ss vfnmadd231ss() => default;

        [MethodImpl(Inline)]
        public static Vfnmadd231ss vfnmadd231ss(AsmHexCode encoded) => new Vfnmadd231ss(encoded);

        public struct Vfnmsub132pd : IAsmInstruction<Vfnmsub132pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmsub132pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132PD;

            public static implicit operator AsmMnemonicCode(Vfnmsub132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub132pd src) => AsmMnemonics.VFNMSUB132PD;
        }

        public static Vfnmsub132pd vfnmsub132pd() => default;

        [MethodImpl(Inline)]
        public static Vfnmsub132pd vfnmsub132pd(AsmHexCode encoded) => new Vfnmsub132pd(encoded);

        public struct Vfnmsub213pd : IAsmInstruction<Vfnmsub213pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmsub213pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213PD;

            public static implicit operator AsmMnemonicCode(Vfnmsub213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub213pd src) => AsmMnemonics.VFNMSUB213PD;
        }

        public static Vfnmsub213pd vfnmsub213pd() => default;

        [MethodImpl(Inline)]
        public static Vfnmsub213pd vfnmsub213pd(AsmHexCode encoded) => new Vfnmsub213pd(encoded);

        public struct Vfnmsub231pd : IAsmInstruction<Vfnmsub231pd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmsub231pd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231PD;

            public static implicit operator AsmMnemonicCode(Vfnmsub231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub231pd src) => AsmMnemonics.VFNMSUB231PD;
        }

        public static Vfnmsub231pd vfnmsub231pd() => default;

        [MethodImpl(Inline)]
        public static Vfnmsub231pd vfnmsub231pd(AsmHexCode encoded) => new Vfnmsub231pd(encoded);

        public struct Vfnmsub132ps : IAsmInstruction<Vfnmsub132ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmsub132ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132PS;

            public static implicit operator AsmMnemonicCode(Vfnmsub132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub132ps src) => AsmMnemonics.VFNMSUB132PS;
        }

        public static Vfnmsub132ps vfnmsub132ps() => default;

        [MethodImpl(Inline)]
        public static Vfnmsub132ps vfnmsub132ps(AsmHexCode encoded) => new Vfnmsub132ps(encoded);

        public struct Vfnmsub213ps : IAsmInstruction<Vfnmsub213ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmsub213ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213PS;

            public static implicit operator AsmMnemonicCode(Vfnmsub213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub213ps src) => AsmMnemonics.VFNMSUB213PS;
        }

        public static Vfnmsub213ps vfnmsub213ps() => default;

        [MethodImpl(Inline)]
        public static Vfnmsub213ps vfnmsub213ps(AsmHexCode encoded) => new Vfnmsub213ps(encoded);

        public struct Vfnmsub231ps : IAsmInstruction<Vfnmsub231ps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmsub231ps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231PS;

            public static implicit operator AsmMnemonicCode(Vfnmsub231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub231ps src) => AsmMnemonics.VFNMSUB231PS;
        }

        public static Vfnmsub231ps vfnmsub231ps() => default;

        [MethodImpl(Inline)]
        public static Vfnmsub231ps vfnmsub231ps(AsmHexCode encoded) => new Vfnmsub231ps(encoded);

        public struct Vfnmsub132sd : IAsmInstruction<Vfnmsub132sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmsub132sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132SD;

            public static implicit operator AsmMnemonicCode(Vfnmsub132sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub132sd src) => AsmMnemonics.VFNMSUB132SD;
        }

        public static Vfnmsub132sd vfnmsub132sd() => default;

        [MethodImpl(Inline)]
        public static Vfnmsub132sd vfnmsub132sd(AsmHexCode encoded) => new Vfnmsub132sd(encoded);

        public struct Vfnmsub213sd : IAsmInstruction<Vfnmsub213sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmsub213sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213SD;

            public static implicit operator AsmMnemonicCode(Vfnmsub213sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub213sd src) => AsmMnemonics.VFNMSUB213SD;
        }

        public static Vfnmsub213sd vfnmsub213sd() => default;

        [MethodImpl(Inline)]
        public static Vfnmsub213sd vfnmsub213sd(AsmHexCode encoded) => new Vfnmsub213sd(encoded);

        public struct Vfnmsub231sd : IAsmInstruction<Vfnmsub231sd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmsub231sd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231SD;

            public static implicit operator AsmMnemonicCode(Vfnmsub231sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub231sd src) => AsmMnemonics.VFNMSUB231SD;
        }

        public static Vfnmsub231sd vfnmsub231sd() => default;

        [MethodImpl(Inline)]
        public static Vfnmsub231sd vfnmsub231sd(AsmHexCode encoded) => new Vfnmsub231sd(encoded);

        public struct Vfnmsub132ss : IAsmInstruction<Vfnmsub132ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmsub132ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132SS;

            public static implicit operator AsmMnemonicCode(Vfnmsub132ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub132ss src) => AsmMnemonics.VFNMSUB132SS;
        }

        public static Vfnmsub132ss vfnmsub132ss() => default;

        [MethodImpl(Inline)]
        public static Vfnmsub132ss vfnmsub132ss(AsmHexCode encoded) => new Vfnmsub132ss(encoded);

        public struct Vfnmsub213ss : IAsmInstruction<Vfnmsub213ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmsub213ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213SS;

            public static implicit operator AsmMnemonicCode(Vfnmsub213ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub213ss src) => AsmMnemonics.VFNMSUB213SS;
        }

        public static Vfnmsub213ss vfnmsub213ss() => default;

        [MethodImpl(Inline)]
        public static Vfnmsub213ss vfnmsub213ss(AsmHexCode encoded) => new Vfnmsub213ss(encoded);

        public struct Vfnmsub231ss : IAsmInstruction<Vfnmsub231ss>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vfnmsub231ss(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231SS;

            public static implicit operator AsmMnemonicCode(Vfnmsub231ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub231ss src) => AsmMnemonics.VFNMSUB231SS;
        }

        public static Vfnmsub231ss vfnmsub231ss() => default;

        [MethodImpl(Inline)]
        public static Vfnmsub231ss vfnmsub231ss(AsmHexCode encoded) => new Vfnmsub231ss(encoded);

        public struct Vgatherdpd : IAsmInstruction<Vgatherdpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vgatherdpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERDPD;

            public static implicit operator AsmMnemonicCode(Vgatherdpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vgatherdpd src) => AsmMnemonics.VGATHERDPD;
        }

        public static Vgatherdpd vgatherdpd() => default;

        [MethodImpl(Inline)]
        public static Vgatherdpd vgatherdpd(AsmHexCode encoded) => new Vgatherdpd(encoded);

        public struct Vgatherqpd : IAsmInstruction<Vgatherqpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vgatherqpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERQPD;

            public static implicit operator AsmMnemonicCode(Vgatherqpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vgatherqpd src) => AsmMnemonics.VGATHERQPD;
        }

        public static Vgatherqpd vgatherqpd() => default;

        [MethodImpl(Inline)]
        public static Vgatherqpd vgatherqpd(AsmHexCode encoded) => new Vgatherqpd(encoded);

        public struct Vgatherdps : IAsmInstruction<Vgatherdps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vgatherdps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERDPS;

            public static implicit operator AsmMnemonicCode(Vgatherdps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vgatherdps src) => AsmMnemonics.VGATHERDPS;
        }

        public static Vgatherdps vgatherdps() => default;

        [MethodImpl(Inline)]
        public static Vgatherdps vgatherdps(AsmHexCode encoded) => new Vgatherdps(encoded);

        public struct Vgatherqps : IAsmInstruction<Vgatherqps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vgatherqps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERQPS;

            public static implicit operator AsmMnemonicCode(Vgatherqps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vgatherqps src) => AsmMnemonics.VGATHERQPS;
        }

        public static Vgatherqps vgatherqps() => default;

        [MethodImpl(Inline)]
        public static Vgatherqps vgatherqps(AsmHexCode encoded) => new Vgatherqps(encoded);

        public struct Vpgatherdd : IAsmInstruction<Vpgatherdd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpgatherdd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERDD;

            public static implicit operator AsmMnemonicCode(Vpgatherdd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpgatherdd src) => AsmMnemonics.VPGATHERDD;
        }

        public static Vpgatherdd vpgatherdd() => default;

        [MethodImpl(Inline)]
        public static Vpgatherdd vpgatherdd(AsmHexCode encoded) => new Vpgatherdd(encoded);

        public struct Vpgatherqd : IAsmInstruction<Vpgatherqd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpgatherqd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERQD;

            public static implicit operator AsmMnemonicCode(Vpgatherqd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpgatherqd src) => AsmMnemonics.VPGATHERQD;
        }

        public static Vpgatherqd vpgatherqd() => default;

        [MethodImpl(Inline)]
        public static Vpgatherqd vpgatherqd(AsmHexCode encoded) => new Vpgatherqd(encoded);

        public struct Vpgatherdq : IAsmInstruction<Vpgatherdq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpgatherdq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERDQ;

            public static implicit operator AsmMnemonicCode(Vpgatherdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpgatherdq src) => AsmMnemonics.VPGATHERDQ;
        }

        public static Vpgatherdq vpgatherdq() => default;

        [MethodImpl(Inline)]
        public static Vpgatherdq vpgatherdq(AsmHexCode encoded) => new Vpgatherdq(encoded);

        public struct Vpgatherqq : IAsmInstruction<Vpgatherqq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpgatherqq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERQQ;

            public static implicit operator AsmMnemonicCode(Vpgatherqq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpgatherqq src) => AsmMnemonics.VPGATHERQQ;
        }

        public static Vpgatherqq vpgatherqq() => default;

        [MethodImpl(Inline)]
        public static Vpgatherqq vpgatherqq(AsmHexCode encoded) => new Vpgatherqq(encoded);

        public struct Vinsertf128 : IAsmInstruction<Vinsertf128>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vinsertf128(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VINSERTF128;

            public static implicit operator AsmMnemonicCode(Vinsertf128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vinsertf128 src) => AsmMnemonics.VINSERTF128;
        }

        public static Vinsertf128 vinsertf128() => default;

        [MethodImpl(Inline)]
        public static Vinsertf128 vinsertf128(AsmHexCode encoded) => new Vinsertf128(encoded);

        public struct Vinserti128 : IAsmInstruction<Vinserti128>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vinserti128(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VINSERTI128;

            public static implicit operator AsmMnemonicCode(Vinserti128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vinserti128 src) => AsmMnemonics.VINSERTI128;
        }

        public static Vinserti128 vinserti128() => default;

        [MethodImpl(Inline)]
        public static Vinserti128 vinserti128(AsmHexCode encoded) => new Vinserti128(encoded);

        public struct Vmaskmovps : IAsmInstruction<Vmaskmovps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmaskmovps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMASKMOVPS;

            public static implicit operator AsmMnemonicCode(Vmaskmovps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaskmovps src) => AsmMnemonics.VMASKMOVPS;
        }

        public static Vmaskmovps vmaskmovps() => default;

        [MethodImpl(Inline)]
        public static Vmaskmovps vmaskmovps(AsmHexCode encoded) => new Vmaskmovps(encoded);

        public struct Vmaskmovpd : IAsmInstruction<Vmaskmovpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vmaskmovpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMASKMOVPD;

            public static implicit operator AsmMnemonicCode(Vmaskmovpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaskmovpd src) => AsmMnemonics.VMASKMOVPD;
        }

        public static Vmaskmovpd vmaskmovpd() => default;

        [MethodImpl(Inline)]
        public static Vmaskmovpd vmaskmovpd(AsmHexCode encoded) => new Vmaskmovpd(encoded);

        public struct Vpblendd : IAsmInstruction<Vpblendd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpblendd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBLENDD;

            public static implicit operator AsmMnemonicCode(Vpblendd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpblendd src) => AsmMnemonics.VPBLENDD;
        }

        public static Vpblendd vpblendd() => default;

        [MethodImpl(Inline)]
        public static Vpblendd vpblendd(AsmHexCode encoded) => new Vpblendd(encoded);

        public struct Vpbroadcastb : IAsmInstruction<Vpbroadcastb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpbroadcastb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTB;

            public static implicit operator AsmMnemonicCode(Vpbroadcastb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpbroadcastb src) => AsmMnemonics.VPBROADCASTB;
        }

        public static Vpbroadcastb vpbroadcastb() => default;

        [MethodImpl(Inline)]
        public static Vpbroadcastb vpbroadcastb(AsmHexCode encoded) => new Vpbroadcastb(encoded);

        public struct Vpbroadcastw : IAsmInstruction<Vpbroadcastw>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpbroadcastw(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTW;

            public static implicit operator AsmMnemonicCode(Vpbroadcastw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpbroadcastw src) => AsmMnemonics.VPBROADCASTW;
        }

        public static Vpbroadcastw vpbroadcastw() => default;

        [MethodImpl(Inline)]
        public static Vpbroadcastw vpbroadcastw(AsmHexCode encoded) => new Vpbroadcastw(encoded);

        public struct Vpbroadcastd : IAsmInstruction<Vpbroadcastd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpbroadcastd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTD;

            public static implicit operator AsmMnemonicCode(Vpbroadcastd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpbroadcastd src) => AsmMnemonics.VPBROADCASTD;
        }

        public static Vpbroadcastd vpbroadcastd() => default;

        [MethodImpl(Inline)]
        public static Vpbroadcastd vpbroadcastd(AsmHexCode encoded) => new Vpbroadcastd(encoded);

        public struct Vpbroadcastq : IAsmInstruction<Vpbroadcastq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpbroadcastq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTQ;

            public static implicit operator AsmMnemonicCode(Vpbroadcastq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpbroadcastq src) => AsmMnemonics.VPBROADCASTQ;
        }

        public static Vpbroadcastq vpbroadcastq() => default;

        [MethodImpl(Inline)]
        public static Vpbroadcastq vpbroadcastq(AsmHexCode encoded) => new Vpbroadcastq(encoded);

        public struct Vbroadcasti128 : IAsmInstruction<Vbroadcasti128>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vbroadcasti128(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTI128;

            public static implicit operator AsmMnemonicCode(Vbroadcasti128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vbroadcasti128 src) => AsmMnemonics.VBROADCASTI128;
        }

        public static Vbroadcasti128 vbroadcasti128() => default;

        [MethodImpl(Inline)]
        public static Vbroadcasti128 vbroadcasti128(AsmHexCode encoded) => new Vbroadcasti128(encoded);

        public struct Vpermd : IAsmInstruction<Vpermd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpermd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMD;

            public static implicit operator AsmMnemonicCode(Vpermd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermd src) => AsmMnemonics.VPERMD;
        }

        public static Vpermd vpermd() => default;

        [MethodImpl(Inline)]
        public static Vpermd vpermd(AsmHexCode encoded) => new Vpermd(encoded);

        public struct Vpermpd : IAsmInstruction<Vpermpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpermpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMPD;

            public static implicit operator AsmMnemonicCode(Vpermpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermpd src) => AsmMnemonics.VPERMPD;
        }

        public static Vpermpd vpermpd() => default;

        [MethodImpl(Inline)]
        public static Vpermpd vpermpd(AsmHexCode encoded) => new Vpermpd(encoded);

        public struct Vpermps : IAsmInstruction<Vpermps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpermps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMPS;

            public static implicit operator AsmMnemonicCode(Vpermps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermps src) => AsmMnemonics.VPERMPS;
        }

        public static Vpermps vpermps() => default;

        [MethodImpl(Inline)]
        public static Vpermps vpermps(AsmHexCode encoded) => new Vpermps(encoded);

        public struct Vpermq : IAsmInstruction<Vpermq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpermq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMQ;

            public static implicit operator AsmMnemonicCode(Vpermq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermq src) => AsmMnemonics.VPERMQ;
        }

        public static Vpermq vpermq() => default;

        [MethodImpl(Inline)]
        public static Vpermq vpermq(AsmHexCode encoded) => new Vpermq(encoded);

        public struct Vperm2i128 : IAsmInstruction<Vperm2i128>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vperm2i128(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERM2I128;

            public static implicit operator AsmMnemonicCode(Vperm2i128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vperm2i128 src) => AsmMnemonics.VPERM2I128;
        }

        public static Vperm2i128 vperm2i128() => default;

        [MethodImpl(Inline)]
        public static Vperm2i128 vperm2i128(AsmHexCode encoded) => new Vperm2i128(encoded);

        public struct Vpermilpd : IAsmInstruction<Vpermilpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpermilpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMILPD;

            public static implicit operator AsmMnemonicCode(Vpermilpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermilpd src) => AsmMnemonics.VPERMILPD;
        }

        public static Vpermilpd vpermilpd() => default;

        [MethodImpl(Inline)]
        public static Vpermilpd vpermilpd(AsmHexCode encoded) => new Vpermilpd(encoded);

        public struct Vpermilps : IAsmInstruction<Vpermilps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpermilps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMILPS;

            public static implicit operator AsmMnemonicCode(Vpermilps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermilps src) => AsmMnemonics.VPERMILPS;
        }

        public static Vpermilps vpermilps() => default;

        [MethodImpl(Inline)]
        public static Vpermilps vpermilps(AsmHexCode encoded) => new Vpermilps(encoded);

        public struct Vperm2f128 : IAsmInstruction<Vperm2f128>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vperm2f128(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERM2F128;

            public static implicit operator AsmMnemonicCode(Vperm2f128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vperm2f128 src) => AsmMnemonics.VPERM2F128;
        }

        public static Vperm2f128 vperm2f128() => default;

        [MethodImpl(Inline)]
        public static Vperm2f128 vperm2f128(AsmHexCode encoded) => new Vperm2f128(encoded);

        public struct Vpmaskmovd : IAsmInstruction<Vpmaskmovd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmaskmovd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMASKMOVD;

            public static implicit operator AsmMnemonicCode(Vpmaskmovd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaskmovd src) => AsmMnemonics.VPMASKMOVD;
        }

        public static Vpmaskmovd vpmaskmovd() => default;

        [MethodImpl(Inline)]
        public static Vpmaskmovd vpmaskmovd(AsmHexCode encoded) => new Vpmaskmovd(encoded);

        public struct Vpmaskmovq : IAsmInstruction<Vpmaskmovq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpmaskmovq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMASKMOVQ;

            public static implicit operator AsmMnemonicCode(Vpmaskmovq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaskmovq src) => AsmMnemonics.VPMASKMOVQ;
        }

        public static Vpmaskmovq vpmaskmovq() => default;

        [MethodImpl(Inline)]
        public static Vpmaskmovq vpmaskmovq(AsmHexCode encoded) => new Vpmaskmovq(encoded);

        public struct Vpsllvd : IAsmInstruction<Vpsllvd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsllvd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLVD;

            public static implicit operator AsmMnemonicCode(Vpsllvd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsllvd src) => AsmMnemonics.VPSLLVD;
        }

        public static Vpsllvd vpsllvd() => default;

        [MethodImpl(Inline)]
        public static Vpsllvd vpsllvd(AsmHexCode encoded) => new Vpsllvd(encoded);

        public struct Vpsllvq : IAsmInstruction<Vpsllvq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsllvq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLVQ;

            public static implicit operator AsmMnemonicCode(Vpsllvq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsllvq src) => AsmMnemonics.VPSLLVQ;
        }

        public static Vpsllvq vpsllvq() => default;

        [MethodImpl(Inline)]
        public static Vpsllvq vpsllvq(AsmHexCode encoded) => new Vpsllvq(encoded);

        public struct Vpsravd : IAsmInstruction<Vpsravd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsravd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRAVD;

            public static implicit operator AsmMnemonicCode(Vpsravd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsravd src) => AsmMnemonics.VPSRAVD;
        }

        public static Vpsravd vpsravd() => default;

        [MethodImpl(Inline)]
        public static Vpsravd vpsravd(AsmHexCode encoded) => new Vpsravd(encoded);

        public struct Vpsrlvd : IAsmInstruction<Vpsrlvd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsrlvd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLVD;

            public static implicit operator AsmMnemonicCode(Vpsrlvd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrlvd src) => AsmMnemonics.VPSRLVD;
        }

        public static Vpsrlvd vpsrlvd() => default;

        [MethodImpl(Inline)]
        public static Vpsrlvd vpsrlvd(AsmHexCode encoded) => new Vpsrlvd(encoded);

        public struct Vpsrlvq : IAsmInstruction<Vpsrlvq>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vpsrlvq(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLVQ;

            public static implicit operator AsmMnemonicCode(Vpsrlvq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrlvq src) => AsmMnemonics.VPSRLVQ;
        }

        public static Vpsrlvq vpsrlvq() => default;

        [MethodImpl(Inline)]
        public static Vpsrlvq vpsrlvq(AsmHexCode encoded) => new Vpsrlvq(encoded);

        public struct Vtestps : IAsmInstruction<Vtestps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vtestps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VTESTPS;

            public static implicit operator AsmMnemonicCode(Vtestps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vtestps src) => AsmMnemonics.VTESTPS;
        }

        public static Vtestps vtestps() => default;

        [MethodImpl(Inline)]
        public static Vtestps vtestps(AsmHexCode encoded) => new Vtestps(encoded);

        public struct Vtestpd : IAsmInstruction<Vtestpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vtestpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VTESTPD;

            public static implicit operator AsmMnemonicCode(Vtestpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vtestpd src) => AsmMnemonics.VTESTPD;
        }

        public static Vtestpd vtestpd() => default;

        [MethodImpl(Inline)]
        public static Vtestpd vtestpd(AsmHexCode encoded) => new Vtestpd(encoded);

        public struct Vzeroall : IAsmInstruction<Vzeroall>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vzeroall(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VZEROALL;

            public static implicit operator AsmMnemonicCode(Vzeroall src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vzeroall src) => AsmMnemonics.VZEROALL;
        }

        public static Vzeroall vzeroall() => default;

        [MethodImpl(Inline)]
        public static Vzeroall vzeroall(AsmHexCode encoded) => new Vzeroall(encoded);

        public struct Vzeroupper : IAsmInstruction<Vzeroupper>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vzeroupper(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VZEROUPPER;

            public static implicit operator AsmMnemonicCode(Vzeroupper src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vzeroupper src) => AsmMnemonics.VZEROUPPER;
        }

        public static Vzeroupper vzeroupper() => default;

        [MethodImpl(Inline)]
        public static Vzeroupper vzeroupper(AsmHexCode encoded) => new Vzeroupper(encoded);

        public struct Wait : IAsmInstruction<Wait>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Wait(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WAIT;

            public static implicit operator AsmMnemonicCode(Wait src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Wait src) => AsmMnemonics.WAIT;
        }

        public static Wait wait() => default;

        [MethodImpl(Inline)]
        public static Wait wait(AsmHexCode encoded) => new Wait(encoded);

        public struct Fwait : IAsmInstruction<Fwait>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Fwait(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FWAIT;

            public static implicit operator AsmMnemonicCode(Fwait src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fwait src) => AsmMnemonics.FWAIT;
        }

        public static Fwait fwait() => default;

        [MethodImpl(Inline)]
        public static Fwait fwait(AsmHexCode encoded) => new Fwait(encoded);

        public struct Wbinvd : IAsmInstruction<Wbinvd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Wbinvd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WBINVD;

            public static implicit operator AsmMnemonicCode(Wbinvd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Wbinvd src) => AsmMnemonics.WBINVD;
        }

        public static Wbinvd wbinvd() => default;

        [MethodImpl(Inline)]
        public static Wbinvd wbinvd(AsmHexCode encoded) => new Wbinvd(encoded);

        public struct Wrfsbase : IAsmInstruction<Wrfsbase>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Wrfsbase(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WRFSBASE;

            public static implicit operator AsmMnemonicCode(Wrfsbase src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Wrfsbase src) => AsmMnemonics.WRFSBASE;
        }

        public static Wrfsbase wrfsbase() => default;

        [MethodImpl(Inline)]
        public static Wrfsbase wrfsbase(AsmHexCode encoded) => new Wrfsbase(encoded);

        public struct Wrgsbase : IAsmInstruction<Wrgsbase>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Wrgsbase(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WRGSBASE;

            public static implicit operator AsmMnemonicCode(Wrgsbase src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Wrgsbase src) => AsmMnemonics.WRGSBASE;
        }

        public static Wrgsbase wrgsbase() => default;

        [MethodImpl(Inline)]
        public static Wrgsbase wrgsbase(AsmHexCode encoded) => new Wrgsbase(encoded);

        public struct Wrmsr : IAsmInstruction<Wrmsr>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Wrmsr(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WRMSR;

            public static implicit operator AsmMnemonicCode(Wrmsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Wrmsr src) => AsmMnemonics.WRMSR;
        }

        public static Wrmsr wrmsr() => default;

        [MethodImpl(Inline)]
        public static Wrmsr wrmsr(AsmHexCode encoded) => new Wrmsr(encoded);

        public struct Xacquire : IAsmInstruction<Xacquire>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xacquire(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XACQUIRE;

            public static implicit operator AsmMnemonicCode(Xacquire src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xacquire src) => AsmMnemonics.XACQUIRE;
        }

        public static Xacquire xacquire() => default;

        [MethodImpl(Inline)]
        public static Xacquire xacquire(AsmHexCode encoded) => new Xacquire(encoded);

        public struct Xrelease : IAsmInstruction<Xrelease>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xrelease(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XRELEASE;

            public static implicit operator AsmMnemonicCode(Xrelease src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xrelease src) => AsmMnemonics.XRELEASE;
        }

        public static Xrelease xrelease() => default;

        [MethodImpl(Inline)]
        public static Xrelease xrelease(AsmHexCode encoded) => new Xrelease(encoded);

        public struct Xabort : IAsmInstruction<Xabort>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xabort(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XABORT;

            public static implicit operator AsmMnemonicCode(Xabort src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xabort src) => AsmMnemonics.XABORT;
        }

        public static Xabort xabort() => default;

        [MethodImpl(Inline)]
        public static Xabort xabort(AsmHexCode encoded) => new Xabort(encoded);

        public struct Xadd : IAsmInstruction<Xadd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xadd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XADD;

            public static implicit operator AsmMnemonicCode(Xadd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xadd src) => AsmMnemonics.XADD;
        }

        public static Xadd xadd() => default;

        [MethodImpl(Inline)]
        public static Xadd xadd(AsmHexCode encoded) => new Xadd(encoded);

        public struct Xbegin : IAsmInstruction<Xbegin>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xbegin(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XBEGIN;

            public static implicit operator AsmMnemonicCode(Xbegin src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xbegin src) => AsmMnemonics.XBEGIN;
        }

        public static Xbegin xbegin() => default;

        [MethodImpl(Inline)]
        public static Xbegin xbegin(AsmHexCode encoded) => new Xbegin(encoded);

        public struct Xchg : IAsmInstruction<Xchg>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xchg(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XCHG;

            public static implicit operator AsmMnemonicCode(Xchg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xchg src) => AsmMnemonics.XCHG;
        }

        public static Xchg xchg() => default;

        [MethodImpl(Inline)]
        public static Xchg xchg(AsmHexCode encoded) => new Xchg(encoded);

        public struct Xend : IAsmInstruction<Xend>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xend(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XEND;

            public static implicit operator AsmMnemonicCode(Xend src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xend src) => AsmMnemonics.XEND;
        }

        public static Xend xend() => default;

        [MethodImpl(Inline)]
        public static Xend xend(AsmHexCode encoded) => new Xend(encoded);

        public struct Xgetbv : IAsmInstruction<Xgetbv>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xgetbv(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XGETBV;

            public static implicit operator AsmMnemonicCode(Xgetbv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xgetbv src) => AsmMnemonics.XGETBV;
        }

        public static Xgetbv xgetbv() => default;

        [MethodImpl(Inline)]
        public static Xgetbv xgetbv(AsmHexCode encoded) => new Xgetbv(encoded);

        public struct Xlat : IAsmInstruction<Xlat>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xlat(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XLAT;

            public static implicit operator AsmMnemonicCode(Xlat src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xlat src) => AsmMnemonics.XLAT;
        }

        public static Xlat xlat() => default;

        [MethodImpl(Inline)]
        public static Xlat xlat(AsmHexCode encoded) => new Xlat(encoded);

        public struct Xlatb : IAsmInstruction<Xlatb>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xlatb(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XLATB;

            public static implicit operator AsmMnemonicCode(Xlatb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xlatb src) => AsmMnemonics.XLATB;
        }

        public static Xlatb xlatb() => default;

        [MethodImpl(Inline)]
        public static Xlatb xlatb(AsmHexCode encoded) => new Xlatb(encoded);

        public struct Xor : IAsmInstruction<Xor>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xor(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XOR;

            public static implicit operator AsmMnemonicCode(Xor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xor src) => AsmMnemonics.XOR;
        }

        public static Xor xor() => default;

        [MethodImpl(Inline)]
        public static Xor xor(AsmHexCode encoded) => new Xor(encoded);

        public struct Xorpd : IAsmInstruction<Xorpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xorpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XORPD;

            public static implicit operator AsmMnemonicCode(Xorpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xorpd src) => AsmMnemonics.XORPD;
        }

        public static Xorpd xorpd() => default;

        [MethodImpl(Inline)]
        public static Xorpd xorpd(AsmHexCode encoded) => new Xorpd(encoded);

        public struct Vxorpd : IAsmInstruction<Vxorpd>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vxorpd(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VXORPD;

            public static implicit operator AsmMnemonicCode(Vxorpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vxorpd src) => AsmMnemonics.VXORPD;
        }

        public static Vxorpd vxorpd() => default;

        [MethodImpl(Inline)]
        public static Vxorpd vxorpd(AsmHexCode encoded) => new Vxorpd(encoded);

        public struct Xorps : IAsmInstruction<Xorps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xorps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XORPS;

            public static implicit operator AsmMnemonicCode(Xorps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xorps src) => AsmMnemonics.XORPS;
        }

        public static Xorps xorps() => default;

        [MethodImpl(Inline)]
        public static Xorps xorps(AsmHexCode encoded) => new Xorps(encoded);

        public struct Vxorps : IAsmInstruction<Vxorps>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Vxorps(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VXORPS;

            public static implicit operator AsmMnemonicCode(Vxorps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vxorps src) => AsmMnemonics.VXORPS;
        }

        public static Vxorps vxorps() => default;

        [MethodImpl(Inline)]
        public static Vxorps vxorps(AsmHexCode encoded) => new Vxorps(encoded);

        public struct Xrstor : IAsmInstruction<Xrstor>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xrstor(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XRSTOR;

            public static implicit operator AsmMnemonicCode(Xrstor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xrstor src) => AsmMnemonics.XRSTOR;
        }

        public static Xrstor xrstor() => default;

        [MethodImpl(Inline)]
        public static Xrstor xrstor(AsmHexCode encoded) => new Xrstor(encoded);

        public struct Xrstor64 : IAsmInstruction<Xrstor64>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xrstor64(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XRSTOR64;

            public static implicit operator AsmMnemonicCode(Xrstor64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xrstor64 src) => AsmMnemonics.XRSTOR64;
        }

        public static Xrstor64 xrstor64() => default;

        [MethodImpl(Inline)]
        public static Xrstor64 xrstor64(AsmHexCode encoded) => new Xrstor64(encoded);

        public struct Xsave : IAsmInstruction<Xsave>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xsave(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVE;

            public static implicit operator AsmMnemonicCode(Xsave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsave src) => AsmMnemonics.XSAVE;
        }

        public static Xsave xsave() => default;

        [MethodImpl(Inline)]
        public static Xsave xsave(AsmHexCode encoded) => new Xsave(encoded);

        public struct Xsave64 : IAsmInstruction<Xsave64>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xsave64(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVE64;

            public static implicit operator AsmMnemonicCode(Xsave64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsave64 src) => AsmMnemonics.XSAVE64;
        }

        public static Xsave64 xsave64() => default;

        [MethodImpl(Inline)]
        public static Xsave64 xsave64(AsmHexCode encoded) => new Xsave64(encoded);

        public struct Xsaveopt : IAsmInstruction<Xsaveopt>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xsaveopt(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVEOPT;

            public static implicit operator AsmMnemonicCode(Xsaveopt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsaveopt src) => AsmMnemonics.XSAVEOPT;
        }

        public static Xsaveopt xsaveopt() => default;

        [MethodImpl(Inline)]
        public static Xsaveopt xsaveopt(AsmHexCode encoded) => new Xsaveopt(encoded);

        public struct Xsaveopt64 : IAsmInstruction<Xsaveopt64>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xsaveopt64(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVEOPT64;

            public static implicit operator AsmMnemonicCode(Xsaveopt64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsaveopt64 src) => AsmMnemonics.XSAVEOPT64;
        }

        public static Xsaveopt64 xsaveopt64() => default;

        [MethodImpl(Inline)]
        public static Xsaveopt64 xsaveopt64(AsmHexCode encoded) => new Xsaveopt64(encoded);

        public struct Xsetbv : IAsmInstruction<Xsetbv>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xsetbv(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSETBV;

            public static implicit operator AsmMnemonicCode(Xsetbv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsetbv src) => AsmMnemonics.XSETBV;
        }

        public static Xsetbv xsetbv() => default;

        [MethodImpl(Inline)]
        public static Xsetbv xsetbv(AsmHexCode encoded) => new Xsetbv(encoded);

        public struct Xtest : IAsmInstruction<Xtest>
        {
            public AsmHexCode Encoded;

            [MethodImpl(Inline)]
            public Xtest(AsmHexCode encoded)
            {
                Encoded = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XTEST;

            public static implicit operator AsmMnemonicCode(Xtest src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xtest src) => AsmMnemonics.XTEST;
        }

        public static Xtest xtest() => default;

        [MethodImpl(Inline)]
        public static Xtest xtest(AsmHexCode encoded) => new Xtest(encoded);

    }
}
