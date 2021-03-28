//-----------------------------------------------------------------------------
// Generated   :  2021-03-28.14.01.17.2074
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

        public Aaa aaa() => default;

        [MethodImpl(Inline), Op]
        public Aaa aaa(AsmHexCode encoded) => new Aaa(encoded);

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

        public Aad aad() => default;

        [MethodImpl(Inline), Op]
        public Aad aad(AsmHexCode encoded) => new Aad(encoded);

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

        public Aam aam() => default;

        [MethodImpl(Inline), Op]
        public Aam aam(AsmHexCode encoded) => new Aam(encoded);

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

        public Aas aas() => default;

        [MethodImpl(Inline), Op]
        public Aas aas(AsmHexCode encoded) => new Aas(encoded);

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

        public Adc adc() => default;

        [MethodImpl(Inline), Op]
        public Adc adc(AsmHexCode encoded) => new Adc(encoded);

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

        public Add add() => default;

        [MethodImpl(Inline), Op]
        public Add add(AsmHexCode encoded) => new Add(encoded);

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

        public Addpd addpd() => default;

        [MethodImpl(Inline), Op]
        public Addpd addpd(AsmHexCode encoded) => new Addpd(encoded);

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

        public Vaddpd vaddpd() => default;

        [MethodImpl(Inline), Op]
        public Vaddpd vaddpd(AsmHexCode encoded) => new Vaddpd(encoded);

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

        public Addps addps() => default;

        [MethodImpl(Inline), Op]
        public Addps addps(AsmHexCode encoded) => new Addps(encoded);

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

        public Vaddps vaddps() => default;

        [MethodImpl(Inline), Op]
        public Vaddps vaddps(AsmHexCode encoded) => new Vaddps(encoded);

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

        public Addsd addsd() => default;

        [MethodImpl(Inline), Op]
        public Addsd addsd(AsmHexCode encoded) => new Addsd(encoded);

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

        public Vaddsd vaddsd() => default;

        [MethodImpl(Inline), Op]
        public Vaddsd vaddsd(AsmHexCode encoded) => new Vaddsd(encoded);

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

        public Addss addss() => default;

        [MethodImpl(Inline), Op]
        public Addss addss(AsmHexCode encoded) => new Addss(encoded);

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

        public Vaddss vaddss() => default;

        [MethodImpl(Inline), Op]
        public Vaddss vaddss(AsmHexCode encoded) => new Vaddss(encoded);

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

        public Addsubpd addsubpd() => default;

        [MethodImpl(Inline), Op]
        public Addsubpd addsubpd(AsmHexCode encoded) => new Addsubpd(encoded);

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

        public Vaddsubpd vaddsubpd() => default;

        [MethodImpl(Inline), Op]
        public Vaddsubpd vaddsubpd(AsmHexCode encoded) => new Vaddsubpd(encoded);

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

        public Addsubps addsubps() => default;

        [MethodImpl(Inline), Op]
        public Addsubps addsubps(AsmHexCode encoded) => new Addsubps(encoded);

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

        public Vaddsubps vaddsubps() => default;

        [MethodImpl(Inline), Op]
        public Vaddsubps vaddsubps(AsmHexCode encoded) => new Vaddsubps(encoded);

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

        public Aesdec aesdec() => default;

        [MethodImpl(Inline), Op]
        public Aesdec aesdec(AsmHexCode encoded) => new Aesdec(encoded);

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

        public Vaesdec vaesdec() => default;

        [MethodImpl(Inline), Op]
        public Vaesdec vaesdec(AsmHexCode encoded) => new Vaesdec(encoded);

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

        public Aesdeclast aesdeclast() => default;

        [MethodImpl(Inline), Op]
        public Aesdeclast aesdeclast(AsmHexCode encoded) => new Aesdeclast(encoded);

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

        public Vaesdeclast vaesdeclast() => default;

        [MethodImpl(Inline), Op]
        public Vaesdeclast vaesdeclast(AsmHexCode encoded) => new Vaesdeclast(encoded);

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

        public Aesenc aesenc() => default;

        [MethodImpl(Inline), Op]
        public Aesenc aesenc(AsmHexCode encoded) => new Aesenc(encoded);

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

        public Vaesenc vaesenc() => default;

        [MethodImpl(Inline), Op]
        public Vaesenc vaesenc(AsmHexCode encoded) => new Vaesenc(encoded);

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

        public Aesenclast aesenclast() => default;

        [MethodImpl(Inline), Op]
        public Aesenclast aesenclast(AsmHexCode encoded) => new Aesenclast(encoded);

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

        public Vaesenclast vaesenclast() => default;

        [MethodImpl(Inline), Op]
        public Vaesenclast vaesenclast(AsmHexCode encoded) => new Vaesenclast(encoded);

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

        public Aesimc aesimc() => default;

        [MethodImpl(Inline), Op]
        public Aesimc aesimc(AsmHexCode encoded) => new Aesimc(encoded);

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

        public Vaesimc vaesimc() => default;

        [MethodImpl(Inline), Op]
        public Vaesimc vaesimc(AsmHexCode encoded) => new Vaesimc(encoded);

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

        public Aeskeygenassist aeskeygenassist() => default;

        [MethodImpl(Inline), Op]
        public Aeskeygenassist aeskeygenassist(AsmHexCode encoded) => new Aeskeygenassist(encoded);

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

        public Vaeskeygenassist vaeskeygenassist() => default;

        [MethodImpl(Inline), Op]
        public Vaeskeygenassist vaeskeygenassist(AsmHexCode encoded) => new Vaeskeygenassist(encoded);

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

        public And and() => default;

        [MethodImpl(Inline), Op]
        public And and(AsmHexCode encoded) => new And(encoded);

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

        public Andn andn() => default;

        [MethodImpl(Inline), Op]
        public Andn andn(AsmHexCode encoded) => new Andn(encoded);

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

        public Andpd andpd() => default;

        [MethodImpl(Inline), Op]
        public Andpd andpd(AsmHexCode encoded) => new Andpd(encoded);

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

        public Vandpd vandpd() => default;

        [MethodImpl(Inline), Op]
        public Vandpd vandpd(AsmHexCode encoded) => new Vandpd(encoded);

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

        public Andps andps() => default;

        [MethodImpl(Inline), Op]
        public Andps andps(AsmHexCode encoded) => new Andps(encoded);

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

        public Vandps vandps() => default;

        [MethodImpl(Inline), Op]
        public Vandps vandps(AsmHexCode encoded) => new Vandps(encoded);

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

        public Andnpd andnpd() => default;

        [MethodImpl(Inline), Op]
        public Andnpd andnpd(AsmHexCode encoded) => new Andnpd(encoded);

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

        public Vandnpd vandnpd() => default;

        [MethodImpl(Inline), Op]
        public Vandnpd vandnpd(AsmHexCode encoded) => new Vandnpd(encoded);

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

        public Andnps andnps() => default;

        [MethodImpl(Inline), Op]
        public Andnps andnps(AsmHexCode encoded) => new Andnps(encoded);

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

        public Vandnps vandnps() => default;

        [MethodImpl(Inline), Op]
        public Vandnps vandnps(AsmHexCode encoded) => new Vandnps(encoded);

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

        public Arpl arpl() => default;

        [MethodImpl(Inline), Op]
        public Arpl arpl(AsmHexCode encoded) => new Arpl(encoded);

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

        public Blendpd blendpd() => default;

        [MethodImpl(Inline), Op]
        public Blendpd blendpd(AsmHexCode encoded) => new Blendpd(encoded);

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

        public Vblendpd vblendpd() => default;

        [MethodImpl(Inline), Op]
        public Vblendpd vblendpd(AsmHexCode encoded) => new Vblendpd(encoded);

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

        public Bextr bextr() => default;

        [MethodImpl(Inline), Op]
        public Bextr bextr(AsmHexCode encoded) => new Bextr(encoded);

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

        public Blendps blendps() => default;

        [MethodImpl(Inline), Op]
        public Blendps blendps(AsmHexCode encoded) => new Blendps(encoded);

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

        public Vblendps vblendps() => default;

        [MethodImpl(Inline), Op]
        public Vblendps vblendps(AsmHexCode encoded) => new Vblendps(encoded);

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

        public Blendvpd blendvpd() => default;

        [MethodImpl(Inline), Op]
        public Blendvpd blendvpd(AsmHexCode encoded) => new Blendvpd(encoded);

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

        public Vblendvpd vblendvpd() => default;

        [MethodImpl(Inline), Op]
        public Vblendvpd vblendvpd(AsmHexCode encoded) => new Vblendvpd(encoded);

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

        public Blendvps blendvps() => default;

        [MethodImpl(Inline), Op]
        public Blendvps blendvps(AsmHexCode encoded) => new Blendvps(encoded);

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

        public Vblendvps vblendvps() => default;

        [MethodImpl(Inline), Op]
        public Vblendvps vblendvps(AsmHexCode encoded) => new Vblendvps(encoded);

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

        public Blsi blsi() => default;

        [MethodImpl(Inline), Op]
        public Blsi blsi(AsmHexCode encoded) => new Blsi(encoded);

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

        public Blsmsk blsmsk() => default;

        [MethodImpl(Inline), Op]
        public Blsmsk blsmsk(AsmHexCode encoded) => new Blsmsk(encoded);

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

        public Blsr blsr() => default;

        [MethodImpl(Inline), Op]
        public Blsr blsr(AsmHexCode encoded) => new Blsr(encoded);

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

        public Bound bound() => default;

        [MethodImpl(Inline), Op]
        public Bound bound(AsmHexCode encoded) => new Bound(encoded);

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

        public Bsf bsf() => default;

        [MethodImpl(Inline), Op]
        public Bsf bsf(AsmHexCode encoded) => new Bsf(encoded);

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

        public Bsr bsr() => default;

        [MethodImpl(Inline), Op]
        public Bsr bsr(AsmHexCode encoded) => new Bsr(encoded);

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

        public Bswap bswap() => default;

        [MethodImpl(Inline), Op]
        public Bswap bswap(AsmHexCode encoded) => new Bswap(encoded);

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

        public Bt bt() => default;

        [MethodImpl(Inline), Op]
        public Bt bt(AsmHexCode encoded) => new Bt(encoded);

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

        public Btc btc() => default;

        [MethodImpl(Inline), Op]
        public Btc btc(AsmHexCode encoded) => new Btc(encoded);

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

        public Btr btr() => default;

        [MethodImpl(Inline), Op]
        public Btr btr(AsmHexCode encoded) => new Btr(encoded);

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

        public Bts bts() => default;

        [MethodImpl(Inline), Op]
        public Bts bts(AsmHexCode encoded) => new Bts(encoded);

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

        public Bzhi bzhi() => default;

        [MethodImpl(Inline), Op]
        public Bzhi bzhi(AsmHexCode encoded) => new Bzhi(encoded);

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

        public Call call() => default;

        [MethodImpl(Inline), Op]
        public Call call(AsmHexCode encoded) => new Call(encoded);

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

        public Cbw cbw() => default;

        [MethodImpl(Inline), Op]
        public Cbw cbw(AsmHexCode encoded) => new Cbw(encoded);

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

        public Cwde cwde() => default;

        [MethodImpl(Inline), Op]
        public Cwde cwde(AsmHexCode encoded) => new Cwde(encoded);

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

        public Cdqe cdqe() => default;

        [MethodImpl(Inline), Op]
        public Cdqe cdqe(AsmHexCode encoded) => new Cdqe(encoded);

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

        public Clc clc() => default;

        [MethodImpl(Inline), Op]
        public Clc clc(AsmHexCode encoded) => new Clc(encoded);

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

        public Cld cld() => default;

        [MethodImpl(Inline), Op]
        public Cld cld(AsmHexCode encoded) => new Cld(encoded);

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

        public Clflush clflush() => default;

        [MethodImpl(Inline), Op]
        public Clflush clflush(AsmHexCode encoded) => new Clflush(encoded);

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

        public Cli cli() => default;

        [MethodImpl(Inline), Op]
        public Cli cli(AsmHexCode encoded) => new Cli(encoded);

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

        public Clts clts() => default;

        [MethodImpl(Inline), Op]
        public Clts clts(AsmHexCode encoded) => new Clts(encoded);

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

        public Cmc cmc() => default;

        [MethodImpl(Inline), Op]
        public Cmc cmc(AsmHexCode encoded) => new Cmc(encoded);

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

        public Cmova cmova() => default;

        [MethodImpl(Inline), Op]
        public Cmova cmova(AsmHexCode encoded) => new Cmova(encoded);

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

        public Cmovae cmovae() => default;

        [MethodImpl(Inline), Op]
        public Cmovae cmovae(AsmHexCode encoded) => new Cmovae(encoded);

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

        public Cmovb cmovb() => default;

        [MethodImpl(Inline), Op]
        public Cmovb cmovb(AsmHexCode encoded) => new Cmovb(encoded);

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

        public Cmovbe cmovbe() => default;

        [MethodImpl(Inline), Op]
        public Cmovbe cmovbe(AsmHexCode encoded) => new Cmovbe(encoded);

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

        public Cmovc cmovc() => default;

        [MethodImpl(Inline), Op]
        public Cmovc cmovc(AsmHexCode encoded) => new Cmovc(encoded);

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

        public Cmove cmove() => default;

        [MethodImpl(Inline), Op]
        public Cmove cmove(AsmHexCode encoded) => new Cmove(encoded);

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

        public Cmovg cmovg() => default;

        [MethodImpl(Inline), Op]
        public Cmovg cmovg(AsmHexCode encoded) => new Cmovg(encoded);

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

        public Cmovge cmovge() => default;

        [MethodImpl(Inline), Op]
        public Cmovge cmovge(AsmHexCode encoded) => new Cmovge(encoded);

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

        public Cmovl cmovl() => default;

        [MethodImpl(Inline), Op]
        public Cmovl cmovl(AsmHexCode encoded) => new Cmovl(encoded);

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

        public Cmovle cmovle() => default;

        [MethodImpl(Inline), Op]
        public Cmovle cmovle(AsmHexCode encoded) => new Cmovle(encoded);

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

        public Cmovna cmovna() => default;

        [MethodImpl(Inline), Op]
        public Cmovna cmovna(AsmHexCode encoded) => new Cmovna(encoded);

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

        public Cmovnae cmovnae() => default;

        [MethodImpl(Inline), Op]
        public Cmovnae cmovnae(AsmHexCode encoded) => new Cmovnae(encoded);

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

        public Cmovnb cmovnb() => default;

        [MethodImpl(Inline), Op]
        public Cmovnb cmovnb(AsmHexCode encoded) => new Cmovnb(encoded);

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

        public Cmovnbe cmovnbe() => default;

        [MethodImpl(Inline), Op]
        public Cmovnbe cmovnbe(AsmHexCode encoded) => new Cmovnbe(encoded);

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

        public Cmovnc cmovnc() => default;

        [MethodImpl(Inline), Op]
        public Cmovnc cmovnc(AsmHexCode encoded) => new Cmovnc(encoded);

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

        public Cmovne cmovne() => default;

        [MethodImpl(Inline), Op]
        public Cmovne cmovne(AsmHexCode encoded) => new Cmovne(encoded);

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

        public Cmovng cmovng() => default;

        [MethodImpl(Inline), Op]
        public Cmovng cmovng(AsmHexCode encoded) => new Cmovng(encoded);

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

        public Cmovnge cmovnge() => default;

        [MethodImpl(Inline), Op]
        public Cmovnge cmovnge(AsmHexCode encoded) => new Cmovnge(encoded);

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

        public Cmovnl cmovnl() => default;

        [MethodImpl(Inline), Op]
        public Cmovnl cmovnl(AsmHexCode encoded) => new Cmovnl(encoded);

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

        public Cmovnle cmovnle() => default;

        [MethodImpl(Inline), Op]
        public Cmovnle cmovnle(AsmHexCode encoded) => new Cmovnle(encoded);

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

        public Cmovno cmovno() => default;

        [MethodImpl(Inline), Op]
        public Cmovno cmovno(AsmHexCode encoded) => new Cmovno(encoded);

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

        public Cmovnp cmovnp() => default;

        [MethodImpl(Inline), Op]
        public Cmovnp cmovnp(AsmHexCode encoded) => new Cmovnp(encoded);

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

        public Cmovns cmovns() => default;

        [MethodImpl(Inline), Op]
        public Cmovns cmovns(AsmHexCode encoded) => new Cmovns(encoded);

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

        public Cmovnz cmovnz() => default;

        [MethodImpl(Inline), Op]
        public Cmovnz cmovnz(AsmHexCode encoded) => new Cmovnz(encoded);

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

        public Cmovo cmovo() => default;

        [MethodImpl(Inline), Op]
        public Cmovo cmovo(AsmHexCode encoded) => new Cmovo(encoded);

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

        public Cmovp cmovp() => default;

        [MethodImpl(Inline), Op]
        public Cmovp cmovp(AsmHexCode encoded) => new Cmovp(encoded);

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

        public Cmovpe cmovpe() => default;

        [MethodImpl(Inline), Op]
        public Cmovpe cmovpe(AsmHexCode encoded) => new Cmovpe(encoded);

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

        public Cmovpo cmovpo() => default;

        [MethodImpl(Inline), Op]
        public Cmovpo cmovpo(AsmHexCode encoded) => new Cmovpo(encoded);

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

        public Cmovs cmovs() => default;

        [MethodImpl(Inline), Op]
        public Cmovs cmovs(AsmHexCode encoded) => new Cmovs(encoded);

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

        public Cmovz cmovz() => default;

        [MethodImpl(Inline), Op]
        public Cmovz cmovz(AsmHexCode encoded) => new Cmovz(encoded);

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

        public Cmp cmp() => default;

        [MethodImpl(Inline), Op]
        public Cmp cmp(AsmHexCode encoded) => new Cmp(encoded);

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

        public Cmppd cmppd() => default;

        [MethodImpl(Inline), Op]
        public Cmppd cmppd(AsmHexCode encoded) => new Cmppd(encoded);

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

        public Vcmppd vcmppd() => default;

        [MethodImpl(Inline), Op]
        public Vcmppd vcmppd(AsmHexCode encoded) => new Vcmppd(encoded);

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

        public Cmpps cmpps() => default;

        [MethodImpl(Inline), Op]
        public Cmpps cmpps(AsmHexCode encoded) => new Cmpps(encoded);

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

        public Vcmpps vcmpps() => default;

        [MethodImpl(Inline), Op]
        public Vcmpps vcmpps(AsmHexCode encoded) => new Vcmpps(encoded);

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

        public Cmps cmps() => default;

        [MethodImpl(Inline), Op]
        public Cmps cmps(AsmHexCode encoded) => new Cmps(encoded);

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

        public Cmpsb cmpsb() => default;

        [MethodImpl(Inline), Op]
        public Cmpsb cmpsb(AsmHexCode encoded) => new Cmpsb(encoded);

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

        public Cmpsw cmpsw() => default;

        [MethodImpl(Inline), Op]
        public Cmpsw cmpsw(AsmHexCode encoded) => new Cmpsw(encoded);

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

        public Cmpsd cmpsd() => default;

        [MethodImpl(Inline), Op]
        public Cmpsd cmpsd(AsmHexCode encoded) => new Cmpsd(encoded);

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

        public Cmpsq cmpsq() => default;

        [MethodImpl(Inline), Op]
        public Cmpsq cmpsq(AsmHexCode encoded) => new Cmpsq(encoded);

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

        public Vcmpsd vcmpsd() => default;

        [MethodImpl(Inline), Op]
        public Vcmpsd vcmpsd(AsmHexCode encoded) => new Vcmpsd(encoded);

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

        public Cmpss cmpss() => default;

        [MethodImpl(Inline), Op]
        public Cmpss cmpss(AsmHexCode encoded) => new Cmpss(encoded);

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

        public Vcmpss vcmpss() => default;

        [MethodImpl(Inline), Op]
        public Vcmpss vcmpss(AsmHexCode encoded) => new Vcmpss(encoded);

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

        public Cmpxchg cmpxchg() => default;

        [MethodImpl(Inline), Op]
        public Cmpxchg cmpxchg(AsmHexCode encoded) => new Cmpxchg(encoded);

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

        public Cmpxchg8b cmpxchg8b() => default;

        [MethodImpl(Inline), Op]
        public Cmpxchg8b cmpxchg8b(AsmHexCode encoded) => new Cmpxchg8b(encoded);

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

        public Cmpxchg16b cmpxchg16b() => default;

        [MethodImpl(Inline), Op]
        public Cmpxchg16b cmpxchg16b(AsmHexCode encoded) => new Cmpxchg16b(encoded);

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

        public Comisd comisd() => default;

        [MethodImpl(Inline), Op]
        public Comisd comisd(AsmHexCode encoded) => new Comisd(encoded);

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

        public Vcomisd vcomisd() => default;

        [MethodImpl(Inline), Op]
        public Vcomisd vcomisd(AsmHexCode encoded) => new Vcomisd(encoded);

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

        public Comiss comiss() => default;

        [MethodImpl(Inline), Op]
        public Comiss comiss(AsmHexCode encoded) => new Comiss(encoded);

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

        public Vcomiss vcomiss() => default;

        [MethodImpl(Inline), Op]
        public Vcomiss vcomiss(AsmHexCode encoded) => new Vcomiss(encoded);

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

        public Cpuid cpuid() => default;

        [MethodImpl(Inline), Op]
        public Cpuid cpuid(AsmHexCode encoded) => new Cpuid(encoded);

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

        public Crc32 crc32() => default;

        [MethodImpl(Inline), Op]
        public Crc32 crc32(AsmHexCode encoded) => new Crc32(encoded);

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

        public Cvtdq2pd cvtdq2pd() => default;

        [MethodImpl(Inline), Op]
        public Cvtdq2pd cvtdq2pd(AsmHexCode encoded) => new Cvtdq2pd(encoded);

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

        public Vcvtdq2pd vcvtdq2pd() => default;

        [MethodImpl(Inline), Op]
        public Vcvtdq2pd vcvtdq2pd(AsmHexCode encoded) => new Vcvtdq2pd(encoded);

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

        public Cvtdq2ps cvtdq2ps() => default;

        [MethodImpl(Inline), Op]
        public Cvtdq2ps cvtdq2ps(AsmHexCode encoded) => new Cvtdq2ps(encoded);

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

        public Vcvtdq2ps vcvtdq2ps() => default;

        [MethodImpl(Inline), Op]
        public Vcvtdq2ps vcvtdq2ps(AsmHexCode encoded) => new Vcvtdq2ps(encoded);

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

        public Cvtpd2dq cvtpd2dq() => default;

        [MethodImpl(Inline), Op]
        public Cvtpd2dq cvtpd2dq(AsmHexCode encoded) => new Cvtpd2dq(encoded);

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

        public Vcvtpd2dq vcvtpd2dq() => default;

        [MethodImpl(Inline), Op]
        public Vcvtpd2dq vcvtpd2dq(AsmHexCode encoded) => new Vcvtpd2dq(encoded);

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

        public Cvtpd2pi cvtpd2pi() => default;

        [MethodImpl(Inline), Op]
        public Cvtpd2pi cvtpd2pi(AsmHexCode encoded) => new Cvtpd2pi(encoded);

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

        public Cvtpd2ps cvtpd2ps() => default;

        [MethodImpl(Inline), Op]
        public Cvtpd2ps cvtpd2ps(AsmHexCode encoded) => new Cvtpd2ps(encoded);

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

        public Vcvtpd2ps vcvtpd2ps() => default;

        [MethodImpl(Inline), Op]
        public Vcvtpd2ps vcvtpd2ps(AsmHexCode encoded) => new Vcvtpd2ps(encoded);

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

        public Cvtpi2pd cvtpi2pd() => default;

        [MethodImpl(Inline), Op]
        public Cvtpi2pd cvtpi2pd(AsmHexCode encoded) => new Cvtpi2pd(encoded);

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

        public Cvtpi2ps cvtpi2ps() => default;

        [MethodImpl(Inline), Op]
        public Cvtpi2ps cvtpi2ps(AsmHexCode encoded) => new Cvtpi2ps(encoded);

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

        public Cvtps2dq cvtps2dq() => default;

        [MethodImpl(Inline), Op]
        public Cvtps2dq cvtps2dq(AsmHexCode encoded) => new Cvtps2dq(encoded);

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

        public Vcvtps2dq vcvtps2dq() => default;

        [MethodImpl(Inline), Op]
        public Vcvtps2dq vcvtps2dq(AsmHexCode encoded) => new Vcvtps2dq(encoded);

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

        public Cvtps2pd cvtps2pd() => default;

        [MethodImpl(Inline), Op]
        public Cvtps2pd cvtps2pd(AsmHexCode encoded) => new Cvtps2pd(encoded);

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

        public Vcvtps2pd vcvtps2pd() => default;

        [MethodImpl(Inline), Op]
        public Vcvtps2pd vcvtps2pd(AsmHexCode encoded) => new Vcvtps2pd(encoded);

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

        public Cvtps2pi cvtps2pi() => default;

        [MethodImpl(Inline), Op]
        public Cvtps2pi cvtps2pi(AsmHexCode encoded) => new Cvtps2pi(encoded);

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

        public Cvtsd2si cvtsd2si() => default;

        [MethodImpl(Inline), Op]
        public Cvtsd2si cvtsd2si(AsmHexCode encoded) => new Cvtsd2si(encoded);

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

        public Vcvtsd2si vcvtsd2si() => default;

        [MethodImpl(Inline), Op]
        public Vcvtsd2si vcvtsd2si(AsmHexCode encoded) => new Vcvtsd2si(encoded);

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

        public Cvtsd2ss cvtsd2ss() => default;

        [MethodImpl(Inline), Op]
        public Cvtsd2ss cvtsd2ss(AsmHexCode encoded) => new Cvtsd2ss(encoded);

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

        public Vcvtsd2ss vcvtsd2ss() => default;

        [MethodImpl(Inline), Op]
        public Vcvtsd2ss vcvtsd2ss(AsmHexCode encoded) => new Vcvtsd2ss(encoded);

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

        public Cvtsi2sd cvtsi2sd() => default;

        [MethodImpl(Inline), Op]
        public Cvtsi2sd cvtsi2sd(AsmHexCode encoded) => new Cvtsi2sd(encoded);

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

        public Vcvtsi2sd vcvtsi2sd() => default;

        [MethodImpl(Inline), Op]
        public Vcvtsi2sd vcvtsi2sd(AsmHexCode encoded) => new Vcvtsi2sd(encoded);

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

        public Cvtsi2ss cvtsi2ss() => default;

        [MethodImpl(Inline), Op]
        public Cvtsi2ss cvtsi2ss(AsmHexCode encoded) => new Cvtsi2ss(encoded);

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

        public Vcvtsi2ss vcvtsi2ss() => default;

        [MethodImpl(Inline), Op]
        public Vcvtsi2ss vcvtsi2ss(AsmHexCode encoded) => new Vcvtsi2ss(encoded);

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

        public Cvtss2sd cvtss2sd() => default;

        [MethodImpl(Inline), Op]
        public Cvtss2sd cvtss2sd(AsmHexCode encoded) => new Cvtss2sd(encoded);

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

        public Vcvtss2sd vcvtss2sd() => default;

        [MethodImpl(Inline), Op]
        public Vcvtss2sd vcvtss2sd(AsmHexCode encoded) => new Vcvtss2sd(encoded);

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

        public Cvtss2si cvtss2si() => default;

        [MethodImpl(Inline), Op]
        public Cvtss2si cvtss2si(AsmHexCode encoded) => new Cvtss2si(encoded);

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

        public Vcvtss2si vcvtss2si() => default;

        [MethodImpl(Inline), Op]
        public Vcvtss2si vcvtss2si(AsmHexCode encoded) => new Vcvtss2si(encoded);

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

        public Cvttpd2dq cvttpd2dq() => default;

        [MethodImpl(Inline), Op]
        public Cvttpd2dq cvttpd2dq(AsmHexCode encoded) => new Cvttpd2dq(encoded);

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

        public Vcvttpd2dq vcvttpd2dq() => default;

        [MethodImpl(Inline), Op]
        public Vcvttpd2dq vcvttpd2dq(AsmHexCode encoded) => new Vcvttpd2dq(encoded);

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

        public Cvttpd2pi cvttpd2pi() => default;

        [MethodImpl(Inline), Op]
        public Cvttpd2pi cvttpd2pi(AsmHexCode encoded) => new Cvttpd2pi(encoded);

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

        public Cvttps2dq cvttps2dq() => default;

        [MethodImpl(Inline), Op]
        public Cvttps2dq cvttps2dq(AsmHexCode encoded) => new Cvttps2dq(encoded);

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

        public Vcvttps2dq vcvttps2dq() => default;

        [MethodImpl(Inline), Op]
        public Vcvttps2dq vcvttps2dq(AsmHexCode encoded) => new Vcvttps2dq(encoded);

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

        public Cvttps2pi cvttps2pi() => default;

        [MethodImpl(Inline), Op]
        public Cvttps2pi cvttps2pi(AsmHexCode encoded) => new Cvttps2pi(encoded);

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

        public Cvttsd2si cvttsd2si() => default;

        [MethodImpl(Inline), Op]
        public Cvttsd2si cvttsd2si(AsmHexCode encoded) => new Cvttsd2si(encoded);

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

        public Vcvttsd2si vcvttsd2si() => default;

        [MethodImpl(Inline), Op]
        public Vcvttsd2si vcvttsd2si(AsmHexCode encoded) => new Vcvttsd2si(encoded);

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

        public Cvttss2si cvttss2si() => default;

        [MethodImpl(Inline), Op]
        public Cvttss2si cvttss2si(AsmHexCode encoded) => new Cvttss2si(encoded);

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

        public Vcvttss2si vcvttss2si() => default;

        [MethodImpl(Inline), Op]
        public Vcvttss2si vcvttss2si(AsmHexCode encoded) => new Vcvttss2si(encoded);

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

        public Cwd cwd() => default;

        [MethodImpl(Inline), Op]
        public Cwd cwd(AsmHexCode encoded) => new Cwd(encoded);

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

        public Cdq cdq() => default;

        [MethodImpl(Inline), Op]
        public Cdq cdq(AsmHexCode encoded) => new Cdq(encoded);

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

        public Cqo cqo() => default;

        [MethodImpl(Inline), Op]
        public Cqo cqo(AsmHexCode encoded) => new Cqo(encoded);

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

        public Daa daa() => default;

        [MethodImpl(Inline), Op]
        public Daa daa(AsmHexCode encoded) => new Daa(encoded);

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

        public Das das() => default;

        [MethodImpl(Inline), Op]
        public Das das(AsmHexCode encoded) => new Das(encoded);

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

        public Dec dec() => default;

        [MethodImpl(Inline), Op]
        public Dec dec(AsmHexCode encoded) => new Dec(encoded);

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

        public Div div() => default;

        [MethodImpl(Inline), Op]
        public Div div(AsmHexCode encoded) => new Div(encoded);

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

        public Divpd divpd() => default;

        [MethodImpl(Inline), Op]
        public Divpd divpd(AsmHexCode encoded) => new Divpd(encoded);

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

        public Vdivpd vdivpd() => default;

        [MethodImpl(Inline), Op]
        public Vdivpd vdivpd(AsmHexCode encoded) => new Vdivpd(encoded);

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

        public Divps divps() => default;

        [MethodImpl(Inline), Op]
        public Divps divps(AsmHexCode encoded) => new Divps(encoded);

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

        public Vdivps vdivps() => default;

        [MethodImpl(Inline), Op]
        public Vdivps vdivps(AsmHexCode encoded) => new Vdivps(encoded);

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

        public Divsd divsd() => default;

        [MethodImpl(Inline), Op]
        public Divsd divsd(AsmHexCode encoded) => new Divsd(encoded);

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

        public Vdivsd vdivsd() => default;

        [MethodImpl(Inline), Op]
        public Vdivsd vdivsd(AsmHexCode encoded) => new Vdivsd(encoded);

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

        public Divss divss() => default;

        [MethodImpl(Inline), Op]
        public Divss divss(AsmHexCode encoded) => new Divss(encoded);

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

        public Vdivss vdivss() => default;

        [MethodImpl(Inline), Op]
        public Vdivss vdivss(AsmHexCode encoded) => new Vdivss(encoded);

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

        public Dppd dppd() => default;

        [MethodImpl(Inline), Op]
        public Dppd dppd(AsmHexCode encoded) => new Dppd(encoded);

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

        public Vdppd vdppd() => default;

        [MethodImpl(Inline), Op]
        public Vdppd vdppd(AsmHexCode encoded) => new Vdppd(encoded);

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

        public Dpps dpps() => default;

        [MethodImpl(Inline), Op]
        public Dpps dpps(AsmHexCode encoded) => new Dpps(encoded);

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

        public Vdpps vdpps() => default;

        [MethodImpl(Inline), Op]
        public Vdpps vdpps(AsmHexCode encoded) => new Vdpps(encoded);

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

        public Emms emms() => default;

        [MethodImpl(Inline), Op]
        public Emms emms(AsmHexCode encoded) => new Emms(encoded);

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

        public Enter enter() => default;

        [MethodImpl(Inline), Op]
        public Enter enter(AsmHexCode encoded) => new Enter(encoded);

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

        public Extractps extractps() => default;

        [MethodImpl(Inline), Op]
        public Extractps extractps(AsmHexCode encoded) => new Extractps(encoded);

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

        public Vextractps vextractps() => default;

        [MethodImpl(Inline), Op]
        public Vextractps vextractps(AsmHexCode encoded) => new Vextractps(encoded);

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

        public F2xm1 f2xm1() => default;

        [MethodImpl(Inline), Op]
        public F2xm1 f2xm1(AsmHexCode encoded) => new F2xm1(encoded);

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

        public Fabs fabs() => default;

        [MethodImpl(Inline), Op]
        public Fabs fabs(AsmHexCode encoded) => new Fabs(encoded);

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

        public Fadd fadd() => default;

        [MethodImpl(Inline), Op]
        public Fadd fadd(AsmHexCode encoded) => new Fadd(encoded);

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

        public Faddp faddp() => default;

        [MethodImpl(Inline), Op]
        public Faddp faddp(AsmHexCode encoded) => new Faddp(encoded);

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

        public Fiadd fiadd() => default;

        [MethodImpl(Inline), Op]
        public Fiadd fiadd(AsmHexCode encoded) => new Fiadd(encoded);

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

        public Fbld fbld() => default;

        [MethodImpl(Inline), Op]
        public Fbld fbld(AsmHexCode encoded) => new Fbld(encoded);

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

        public Fbstp fbstp() => default;

        [MethodImpl(Inline), Op]
        public Fbstp fbstp(AsmHexCode encoded) => new Fbstp(encoded);

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

        public Fchs fchs() => default;

        [MethodImpl(Inline), Op]
        public Fchs fchs(AsmHexCode encoded) => new Fchs(encoded);

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

        public Fclex fclex() => default;

        [MethodImpl(Inline), Op]
        public Fclex fclex(AsmHexCode encoded) => new Fclex(encoded);

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

        public Fnclex fnclex() => default;

        [MethodImpl(Inline), Op]
        public Fnclex fnclex(AsmHexCode encoded) => new Fnclex(encoded);

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

        public Fcmovb fcmovb() => default;

        [MethodImpl(Inline), Op]
        public Fcmovb fcmovb(AsmHexCode encoded) => new Fcmovb(encoded);

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

        public Fcmove fcmove() => default;

        [MethodImpl(Inline), Op]
        public Fcmove fcmove(AsmHexCode encoded) => new Fcmove(encoded);

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

        public Fcmovbe fcmovbe() => default;

        [MethodImpl(Inline), Op]
        public Fcmovbe fcmovbe(AsmHexCode encoded) => new Fcmovbe(encoded);

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

        public Fcmovu fcmovu() => default;

        [MethodImpl(Inline), Op]
        public Fcmovu fcmovu(AsmHexCode encoded) => new Fcmovu(encoded);

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

        public Fcmovnb fcmovnb() => default;

        [MethodImpl(Inline), Op]
        public Fcmovnb fcmovnb(AsmHexCode encoded) => new Fcmovnb(encoded);

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

        public Fcmovne fcmovne() => default;

        [MethodImpl(Inline), Op]
        public Fcmovne fcmovne(AsmHexCode encoded) => new Fcmovne(encoded);

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

        public Fcmovnbe fcmovnbe() => default;

        [MethodImpl(Inline), Op]
        public Fcmovnbe fcmovnbe(AsmHexCode encoded) => new Fcmovnbe(encoded);

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

        public Fcmovnu fcmovnu() => default;

        [MethodImpl(Inline), Op]
        public Fcmovnu fcmovnu(AsmHexCode encoded) => new Fcmovnu(encoded);

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

        public Fcom fcom() => default;

        [MethodImpl(Inline), Op]
        public Fcom fcom(AsmHexCode encoded) => new Fcom(encoded);

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

        public Fcomp fcomp() => default;

        [MethodImpl(Inline), Op]
        public Fcomp fcomp(AsmHexCode encoded) => new Fcomp(encoded);

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

        public Fcompp fcompp() => default;

        [MethodImpl(Inline), Op]
        public Fcompp fcompp(AsmHexCode encoded) => new Fcompp(encoded);

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

        public Fcomi fcomi() => default;

        [MethodImpl(Inline), Op]
        public Fcomi fcomi(AsmHexCode encoded) => new Fcomi(encoded);

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

        public Fcomip fcomip() => default;

        [MethodImpl(Inline), Op]
        public Fcomip fcomip(AsmHexCode encoded) => new Fcomip(encoded);

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

        public Fucomi fucomi() => default;

        [MethodImpl(Inline), Op]
        public Fucomi fucomi(AsmHexCode encoded) => new Fucomi(encoded);

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

        public Fucomip fucomip() => default;

        [MethodImpl(Inline), Op]
        public Fucomip fucomip(AsmHexCode encoded) => new Fucomip(encoded);

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

        public Fcos fcos() => default;

        [MethodImpl(Inline), Op]
        public Fcos fcos(AsmHexCode encoded) => new Fcos(encoded);

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

        public Fdecstp fdecstp() => default;

        [MethodImpl(Inline), Op]
        public Fdecstp fdecstp(AsmHexCode encoded) => new Fdecstp(encoded);

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

        public Fdiv fdiv() => default;

        [MethodImpl(Inline), Op]
        public Fdiv fdiv(AsmHexCode encoded) => new Fdiv(encoded);

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

        public Fdivp fdivp() => default;

        [MethodImpl(Inline), Op]
        public Fdivp fdivp(AsmHexCode encoded) => new Fdivp(encoded);

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

        public Fidiv fidiv() => default;

        [MethodImpl(Inline), Op]
        public Fidiv fidiv(AsmHexCode encoded) => new Fidiv(encoded);

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

        public Fdivr fdivr() => default;

        [MethodImpl(Inline), Op]
        public Fdivr fdivr(AsmHexCode encoded) => new Fdivr(encoded);

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

        public Fdivrp fdivrp() => default;

        [MethodImpl(Inline), Op]
        public Fdivrp fdivrp(AsmHexCode encoded) => new Fdivrp(encoded);

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

        public Fidivr fidivr() => default;

        [MethodImpl(Inline), Op]
        public Fidivr fidivr(AsmHexCode encoded) => new Fidivr(encoded);

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

        public Ffree ffree() => default;

        [MethodImpl(Inline), Op]
        public Ffree ffree(AsmHexCode encoded) => new Ffree(encoded);

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

        public Ficom ficom() => default;

        [MethodImpl(Inline), Op]
        public Ficom ficom(AsmHexCode encoded) => new Ficom(encoded);

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

        public Ficomp ficomp() => default;

        [MethodImpl(Inline), Op]
        public Ficomp ficomp(AsmHexCode encoded) => new Ficomp(encoded);

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

        public Fild fild() => default;

        [MethodImpl(Inline), Op]
        public Fild fild(AsmHexCode encoded) => new Fild(encoded);

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

        public Fincstp fincstp() => default;

        [MethodImpl(Inline), Op]
        public Fincstp fincstp(AsmHexCode encoded) => new Fincstp(encoded);

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

        public Finit finit() => default;

        [MethodImpl(Inline), Op]
        public Finit finit(AsmHexCode encoded) => new Finit(encoded);

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

        public Fninit fninit() => default;

        [MethodImpl(Inline), Op]
        public Fninit fninit(AsmHexCode encoded) => new Fninit(encoded);

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

        public Fist fist() => default;

        [MethodImpl(Inline), Op]
        public Fist fist(AsmHexCode encoded) => new Fist(encoded);

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

        public Fistp fistp() => default;

        [MethodImpl(Inline), Op]
        public Fistp fistp(AsmHexCode encoded) => new Fistp(encoded);

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

        public Fisttp fisttp() => default;

        [MethodImpl(Inline), Op]
        public Fisttp fisttp(AsmHexCode encoded) => new Fisttp(encoded);

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

        public Fld fld() => default;

        [MethodImpl(Inline), Op]
        public Fld fld(AsmHexCode encoded) => new Fld(encoded);

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

        public Fld1 fld1() => default;

        [MethodImpl(Inline), Op]
        public Fld1 fld1(AsmHexCode encoded) => new Fld1(encoded);

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

        public Fldl2t fldl2t() => default;

        [MethodImpl(Inline), Op]
        public Fldl2t fldl2t(AsmHexCode encoded) => new Fldl2t(encoded);

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

        public Fldl2e fldl2e() => default;

        [MethodImpl(Inline), Op]
        public Fldl2e fldl2e(AsmHexCode encoded) => new Fldl2e(encoded);

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

        public Fldpi fldpi() => default;

        [MethodImpl(Inline), Op]
        public Fldpi fldpi(AsmHexCode encoded) => new Fldpi(encoded);

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

        public Fldlg2 fldlg2() => default;

        [MethodImpl(Inline), Op]
        public Fldlg2 fldlg2(AsmHexCode encoded) => new Fldlg2(encoded);

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

        public Fldln2 fldln2() => default;

        [MethodImpl(Inline), Op]
        public Fldln2 fldln2(AsmHexCode encoded) => new Fldln2(encoded);

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

        public Fldz fldz() => default;

        [MethodImpl(Inline), Op]
        public Fldz fldz(AsmHexCode encoded) => new Fldz(encoded);

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

        public Fldcw fldcw() => default;

        [MethodImpl(Inline), Op]
        public Fldcw fldcw(AsmHexCode encoded) => new Fldcw(encoded);

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

        public Fldenv fldenv() => default;

        [MethodImpl(Inline), Op]
        public Fldenv fldenv(AsmHexCode encoded) => new Fldenv(encoded);

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

        public Fmul fmul() => default;

        [MethodImpl(Inline), Op]
        public Fmul fmul(AsmHexCode encoded) => new Fmul(encoded);

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

        public Fmulp fmulp() => default;

        [MethodImpl(Inline), Op]
        public Fmulp fmulp(AsmHexCode encoded) => new Fmulp(encoded);

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

        public Fimul fimul() => default;

        [MethodImpl(Inline), Op]
        public Fimul fimul(AsmHexCode encoded) => new Fimul(encoded);

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

        public Fnop fnop() => default;

        [MethodImpl(Inline), Op]
        public Fnop fnop(AsmHexCode encoded) => new Fnop(encoded);

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

        public Fpatan fpatan() => default;

        [MethodImpl(Inline), Op]
        public Fpatan fpatan(AsmHexCode encoded) => new Fpatan(encoded);

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

        public Fprem fprem() => default;

        [MethodImpl(Inline), Op]
        public Fprem fprem(AsmHexCode encoded) => new Fprem(encoded);

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

        public Fprem1 fprem1() => default;

        [MethodImpl(Inline), Op]
        public Fprem1 fprem1(AsmHexCode encoded) => new Fprem1(encoded);

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

        public Fptan fptan() => default;

        [MethodImpl(Inline), Op]
        public Fptan fptan(AsmHexCode encoded) => new Fptan(encoded);

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

        public Frndint frndint() => default;

        [MethodImpl(Inline), Op]
        public Frndint frndint(AsmHexCode encoded) => new Frndint(encoded);

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

        public Frstor frstor() => default;

        [MethodImpl(Inline), Op]
        public Frstor frstor(AsmHexCode encoded) => new Frstor(encoded);

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

        public Fsave fsave() => default;

        [MethodImpl(Inline), Op]
        public Fsave fsave(AsmHexCode encoded) => new Fsave(encoded);

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

        public Fnsave fnsave() => default;

        [MethodImpl(Inline), Op]
        public Fnsave fnsave(AsmHexCode encoded) => new Fnsave(encoded);

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

        public Fscale fscale() => default;

        [MethodImpl(Inline), Op]
        public Fscale fscale(AsmHexCode encoded) => new Fscale(encoded);

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

        public Fsin fsin() => default;

        [MethodImpl(Inline), Op]
        public Fsin fsin(AsmHexCode encoded) => new Fsin(encoded);

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

        public Fsincos fsincos() => default;

        [MethodImpl(Inline), Op]
        public Fsincos fsincos(AsmHexCode encoded) => new Fsincos(encoded);

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

        public Fsqrt fsqrt() => default;

        [MethodImpl(Inline), Op]
        public Fsqrt fsqrt(AsmHexCode encoded) => new Fsqrt(encoded);

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

        public Fst fst() => default;

        [MethodImpl(Inline), Op]
        public Fst fst(AsmHexCode encoded) => new Fst(encoded);

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

        public Fstp fstp() => default;

        [MethodImpl(Inline), Op]
        public Fstp fstp(AsmHexCode encoded) => new Fstp(encoded);

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

        public Fstcw fstcw() => default;

        [MethodImpl(Inline), Op]
        public Fstcw fstcw(AsmHexCode encoded) => new Fstcw(encoded);

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

        public Fnstcw fnstcw() => default;

        [MethodImpl(Inline), Op]
        public Fnstcw fnstcw(AsmHexCode encoded) => new Fnstcw(encoded);

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

        public Fstenv fstenv() => default;

        [MethodImpl(Inline), Op]
        public Fstenv fstenv(AsmHexCode encoded) => new Fstenv(encoded);

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

        public Fnstenv fnstenv() => default;

        [MethodImpl(Inline), Op]
        public Fnstenv fnstenv(AsmHexCode encoded) => new Fnstenv(encoded);

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

        public Fstsw fstsw() => default;

        [MethodImpl(Inline), Op]
        public Fstsw fstsw(AsmHexCode encoded) => new Fstsw(encoded);

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

        public Fnstsw fnstsw() => default;

        [MethodImpl(Inline), Op]
        public Fnstsw fnstsw(AsmHexCode encoded) => new Fnstsw(encoded);

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

        public Fsub fsub() => default;

        [MethodImpl(Inline), Op]
        public Fsub fsub(AsmHexCode encoded) => new Fsub(encoded);

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

        public Fsubp fsubp() => default;

        [MethodImpl(Inline), Op]
        public Fsubp fsubp(AsmHexCode encoded) => new Fsubp(encoded);

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

        public Fisub fisub() => default;

        [MethodImpl(Inline), Op]
        public Fisub fisub(AsmHexCode encoded) => new Fisub(encoded);

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

        public Fsubr fsubr() => default;

        [MethodImpl(Inline), Op]
        public Fsubr fsubr(AsmHexCode encoded) => new Fsubr(encoded);

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

        public Fsubrp fsubrp() => default;

        [MethodImpl(Inline), Op]
        public Fsubrp fsubrp(AsmHexCode encoded) => new Fsubrp(encoded);

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

        public Fisubr fisubr() => default;

        [MethodImpl(Inline), Op]
        public Fisubr fisubr(AsmHexCode encoded) => new Fisubr(encoded);

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

        public Ftst ftst() => default;

        [MethodImpl(Inline), Op]
        public Ftst ftst(AsmHexCode encoded) => new Ftst(encoded);

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

        public Fucom fucom() => default;

        [MethodImpl(Inline), Op]
        public Fucom fucom(AsmHexCode encoded) => new Fucom(encoded);

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

        public Fucomp fucomp() => default;

        [MethodImpl(Inline), Op]
        public Fucomp fucomp(AsmHexCode encoded) => new Fucomp(encoded);

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

        public Fucompp fucompp() => default;

        [MethodImpl(Inline), Op]
        public Fucompp fucompp(AsmHexCode encoded) => new Fucompp(encoded);

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

        public Fxam fxam() => default;

        [MethodImpl(Inline), Op]
        public Fxam fxam(AsmHexCode encoded) => new Fxam(encoded);

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

        public Fxch fxch() => default;

        [MethodImpl(Inline), Op]
        public Fxch fxch(AsmHexCode encoded) => new Fxch(encoded);

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

        public Fxrstor fxrstor() => default;

        [MethodImpl(Inline), Op]
        public Fxrstor fxrstor(AsmHexCode encoded) => new Fxrstor(encoded);

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

        public Fxrstor64 fxrstor64() => default;

        [MethodImpl(Inline), Op]
        public Fxrstor64 fxrstor64(AsmHexCode encoded) => new Fxrstor64(encoded);

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

        public Fxsave fxsave() => default;

        [MethodImpl(Inline), Op]
        public Fxsave fxsave(AsmHexCode encoded) => new Fxsave(encoded);

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

        public Fxsave64 fxsave64() => default;

        [MethodImpl(Inline), Op]
        public Fxsave64 fxsave64(AsmHexCode encoded) => new Fxsave64(encoded);

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

        public Fxtract fxtract() => default;

        [MethodImpl(Inline), Op]
        public Fxtract fxtract(AsmHexCode encoded) => new Fxtract(encoded);

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

        public Fyl2x fyl2x() => default;

        [MethodImpl(Inline), Op]
        public Fyl2x fyl2x(AsmHexCode encoded) => new Fyl2x(encoded);

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

        public Fyl2xp1 fyl2xp1() => default;

        [MethodImpl(Inline), Op]
        public Fyl2xp1 fyl2xp1(AsmHexCode encoded) => new Fyl2xp1(encoded);

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

        public Haddpd haddpd() => default;

        [MethodImpl(Inline), Op]
        public Haddpd haddpd(AsmHexCode encoded) => new Haddpd(encoded);

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

        public Vhaddpd vhaddpd() => default;

        [MethodImpl(Inline), Op]
        public Vhaddpd vhaddpd(AsmHexCode encoded) => new Vhaddpd(encoded);

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

        public Haddps haddps() => default;

        [MethodImpl(Inline), Op]
        public Haddps haddps(AsmHexCode encoded) => new Haddps(encoded);

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

        public Vhaddps vhaddps() => default;

        [MethodImpl(Inline), Op]
        public Vhaddps vhaddps(AsmHexCode encoded) => new Vhaddps(encoded);

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

        public Hlt hlt() => default;

        [MethodImpl(Inline), Op]
        public Hlt hlt(AsmHexCode encoded) => new Hlt(encoded);

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

        public Hsubpd hsubpd() => default;

        [MethodImpl(Inline), Op]
        public Hsubpd hsubpd(AsmHexCode encoded) => new Hsubpd(encoded);

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

        public Vhsubpd vhsubpd() => default;

        [MethodImpl(Inline), Op]
        public Vhsubpd vhsubpd(AsmHexCode encoded) => new Vhsubpd(encoded);

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

        public Hsubps hsubps() => default;

        [MethodImpl(Inline), Op]
        public Hsubps hsubps(AsmHexCode encoded) => new Hsubps(encoded);

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

        public Vhsubps vhsubps() => default;

        [MethodImpl(Inline), Op]
        public Vhsubps vhsubps(AsmHexCode encoded) => new Vhsubps(encoded);

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

        public Idiv idiv() => default;

        [MethodImpl(Inline), Op]
        public Idiv idiv(AsmHexCode encoded) => new Idiv(encoded);

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

        public Imul imul() => default;

        [MethodImpl(Inline), Op]
        public Imul imul(AsmHexCode encoded) => new Imul(encoded);

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

        public In @in() => default;

        [MethodImpl(Inline), Op]
        public In @in(AsmHexCode encoded) => new In(encoded);

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

        public Inc inc() => default;

        [MethodImpl(Inline), Op]
        public Inc inc(AsmHexCode encoded) => new Inc(encoded);

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

        public Ins ins() => default;

        [MethodImpl(Inline), Op]
        public Ins ins(AsmHexCode encoded) => new Ins(encoded);

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

        public Insb insb() => default;

        [MethodImpl(Inline), Op]
        public Insb insb(AsmHexCode encoded) => new Insb(encoded);

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

        public Insw insw() => default;

        [MethodImpl(Inline), Op]
        public Insw insw(AsmHexCode encoded) => new Insw(encoded);

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

        public Insd insd() => default;

        [MethodImpl(Inline), Op]
        public Insd insd(AsmHexCode encoded) => new Insd(encoded);

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

        public Insertps insertps() => default;

        [MethodImpl(Inline), Op]
        public Insertps insertps(AsmHexCode encoded) => new Insertps(encoded);

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

        public Vinsertps vinsertps() => default;

        [MethodImpl(Inline), Op]
        public Vinsertps vinsertps(AsmHexCode encoded) => new Vinsertps(encoded);

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

        public Int @int() => default;

        [MethodImpl(Inline), Op]
        public Int @int(AsmHexCode encoded) => new Int(encoded);

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

        public Into into() => default;

        [MethodImpl(Inline), Op]
        public Into into(AsmHexCode encoded) => new Into(encoded);

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

        public Invd invd() => default;

        [MethodImpl(Inline), Op]
        public Invd invd(AsmHexCode encoded) => new Invd(encoded);

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

        public Invlpg invlpg() => default;

        [MethodImpl(Inline), Op]
        public Invlpg invlpg(AsmHexCode encoded) => new Invlpg(encoded);

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

        public Invpcid invpcid() => default;

        [MethodImpl(Inline), Op]
        public Invpcid invpcid(AsmHexCode encoded) => new Invpcid(encoded);

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

        public Iret iret() => default;

        [MethodImpl(Inline), Op]
        public Iret iret(AsmHexCode encoded) => new Iret(encoded);

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

        public Iretd iretd() => default;

        [MethodImpl(Inline), Op]
        public Iretd iretd(AsmHexCode encoded) => new Iretd(encoded);

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

        public Iretq iretq() => default;

        [MethodImpl(Inline), Op]
        public Iretq iretq(AsmHexCode encoded) => new Iretq(encoded);

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

        public Ja ja() => default;

        [MethodImpl(Inline), Op]
        public Ja ja(AsmHexCode encoded) => new Ja(encoded);

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

        public Jae jae() => default;

        [MethodImpl(Inline), Op]
        public Jae jae(AsmHexCode encoded) => new Jae(encoded);

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

        public Jb jb() => default;

        [MethodImpl(Inline), Op]
        public Jb jb(AsmHexCode encoded) => new Jb(encoded);

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

        public Jbe jbe() => default;

        [MethodImpl(Inline), Op]
        public Jbe jbe(AsmHexCode encoded) => new Jbe(encoded);

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

        public Jc jc() => default;

        [MethodImpl(Inline), Op]
        public Jc jc(AsmHexCode encoded) => new Jc(encoded);

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

        public Jcxz jcxz() => default;

        [MethodImpl(Inline), Op]
        public Jcxz jcxz(AsmHexCode encoded) => new Jcxz(encoded);

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

        public Jecxz jecxz() => default;

        [MethodImpl(Inline), Op]
        public Jecxz jecxz(AsmHexCode encoded) => new Jecxz(encoded);

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

        public Jrcxz jrcxz() => default;

        [MethodImpl(Inline), Op]
        public Jrcxz jrcxz(AsmHexCode encoded) => new Jrcxz(encoded);

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

        public Je je() => default;

        [MethodImpl(Inline), Op]
        public Je je(AsmHexCode encoded) => new Je(encoded);

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

        public Jg jg() => default;

        [MethodImpl(Inline), Op]
        public Jg jg(AsmHexCode encoded) => new Jg(encoded);

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

        public Jge jge() => default;

        [MethodImpl(Inline), Op]
        public Jge jge(AsmHexCode encoded) => new Jge(encoded);

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

        public Jl jl() => default;

        [MethodImpl(Inline), Op]
        public Jl jl(AsmHexCode encoded) => new Jl(encoded);

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

        public Jle jle() => default;

        [MethodImpl(Inline), Op]
        public Jle jle(AsmHexCode encoded) => new Jle(encoded);

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

        public Jna jna() => default;

        [MethodImpl(Inline), Op]
        public Jna jna(AsmHexCode encoded) => new Jna(encoded);

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

        public Jnae jnae() => default;

        [MethodImpl(Inline), Op]
        public Jnae jnae(AsmHexCode encoded) => new Jnae(encoded);

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

        public Jnb jnb() => default;

        [MethodImpl(Inline), Op]
        public Jnb jnb(AsmHexCode encoded) => new Jnb(encoded);

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

        public Jnbe jnbe() => default;

        [MethodImpl(Inline), Op]
        public Jnbe jnbe(AsmHexCode encoded) => new Jnbe(encoded);

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

        public Jnc jnc() => default;

        [MethodImpl(Inline), Op]
        public Jnc jnc(AsmHexCode encoded) => new Jnc(encoded);

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

        public Jne jne() => default;

        [MethodImpl(Inline), Op]
        public Jne jne(AsmHexCode encoded) => new Jne(encoded);

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

        public Jng jng() => default;

        [MethodImpl(Inline), Op]
        public Jng jng(AsmHexCode encoded) => new Jng(encoded);

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

        public Jnge jnge() => default;

        [MethodImpl(Inline), Op]
        public Jnge jnge(AsmHexCode encoded) => new Jnge(encoded);

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

        public Jnl jnl() => default;

        [MethodImpl(Inline), Op]
        public Jnl jnl(AsmHexCode encoded) => new Jnl(encoded);

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

        public Jnle jnle() => default;

        [MethodImpl(Inline), Op]
        public Jnle jnle(AsmHexCode encoded) => new Jnle(encoded);

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

        public Jno jno() => default;

        [MethodImpl(Inline), Op]
        public Jno jno(AsmHexCode encoded) => new Jno(encoded);

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

        public Jnp jnp() => default;

        [MethodImpl(Inline), Op]
        public Jnp jnp(AsmHexCode encoded) => new Jnp(encoded);

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

        public Jns jns() => default;

        [MethodImpl(Inline), Op]
        public Jns jns(AsmHexCode encoded) => new Jns(encoded);

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

        public Jnz jnz() => default;

        [MethodImpl(Inline), Op]
        public Jnz jnz(AsmHexCode encoded) => new Jnz(encoded);

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

        public Jo jo() => default;

        [MethodImpl(Inline), Op]
        public Jo jo(AsmHexCode encoded) => new Jo(encoded);

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

        public Jp jp() => default;

        [MethodImpl(Inline), Op]
        public Jp jp(AsmHexCode encoded) => new Jp(encoded);

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

        public Jpe jpe() => default;

        [MethodImpl(Inline), Op]
        public Jpe jpe(AsmHexCode encoded) => new Jpe(encoded);

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

        public Jpo jpo() => default;

        [MethodImpl(Inline), Op]
        public Jpo jpo(AsmHexCode encoded) => new Jpo(encoded);

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

        public Js js() => default;

        [MethodImpl(Inline), Op]
        public Js js(AsmHexCode encoded) => new Js(encoded);

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

        public Jz jz() => default;

        [MethodImpl(Inline), Op]
        public Jz jz(AsmHexCode encoded) => new Jz(encoded);

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

        public Jmp jmp() => default;

        [MethodImpl(Inline), Op]
        public Jmp jmp(AsmHexCode encoded) => new Jmp(encoded);

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

        public Lahf lahf() => default;

        [MethodImpl(Inline), Op]
        public Lahf lahf(AsmHexCode encoded) => new Lahf(encoded);

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

        public Lar lar() => default;

        [MethodImpl(Inline), Op]
        public Lar lar(AsmHexCode encoded) => new Lar(encoded);

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

        public Lddqu lddqu() => default;

        [MethodImpl(Inline), Op]
        public Lddqu lddqu(AsmHexCode encoded) => new Lddqu(encoded);

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

        public Vlddqu vlddqu() => default;

        [MethodImpl(Inline), Op]
        public Vlddqu vlddqu(AsmHexCode encoded) => new Vlddqu(encoded);

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

        public Ldmxcsr ldmxcsr() => default;

        [MethodImpl(Inline), Op]
        public Ldmxcsr ldmxcsr(AsmHexCode encoded) => new Ldmxcsr(encoded);

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

        public Vldmxcsr vldmxcsr() => default;

        [MethodImpl(Inline), Op]
        public Vldmxcsr vldmxcsr(AsmHexCode encoded) => new Vldmxcsr(encoded);

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

        public Lds lds() => default;

        [MethodImpl(Inline), Op]
        public Lds lds(AsmHexCode encoded) => new Lds(encoded);

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

        public Lss lss() => default;

        [MethodImpl(Inline), Op]
        public Lss lss(AsmHexCode encoded) => new Lss(encoded);

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

        public Les les() => default;

        [MethodImpl(Inline), Op]
        public Les les(AsmHexCode encoded) => new Les(encoded);

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

        public Lfs lfs() => default;

        [MethodImpl(Inline), Op]
        public Lfs lfs(AsmHexCode encoded) => new Lfs(encoded);

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

        public Lgs lgs() => default;

        [MethodImpl(Inline), Op]
        public Lgs lgs(AsmHexCode encoded) => new Lgs(encoded);

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

        public Lea lea() => default;

        [MethodImpl(Inline), Op]
        public Lea lea(AsmHexCode encoded) => new Lea(encoded);

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

        public Leave leave() => default;

        [MethodImpl(Inline), Op]
        public Leave leave(AsmHexCode encoded) => new Leave(encoded);

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

        public Lfence lfence() => default;

        [MethodImpl(Inline), Op]
        public Lfence lfence(AsmHexCode encoded) => new Lfence(encoded);

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

        public Lgdt lgdt() => default;

        [MethodImpl(Inline), Op]
        public Lgdt lgdt(AsmHexCode encoded) => new Lgdt(encoded);

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

        public Lidt lidt() => default;

        [MethodImpl(Inline), Op]
        public Lidt lidt(AsmHexCode encoded) => new Lidt(encoded);

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

        public Lldt lldt() => default;

        [MethodImpl(Inline), Op]
        public Lldt lldt(AsmHexCode encoded) => new Lldt(encoded);

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

        public Lmsw lmsw() => default;

        [MethodImpl(Inline), Op]
        public Lmsw lmsw(AsmHexCode encoded) => new Lmsw(encoded);

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

        public Lock @lock() => default;

        [MethodImpl(Inline), Op]
        public Lock @lock(AsmHexCode encoded) => new Lock(encoded);

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

        public Lods lods() => default;

        [MethodImpl(Inline), Op]
        public Lods lods(AsmHexCode encoded) => new Lods(encoded);

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

        public Lodsb lodsb() => default;

        [MethodImpl(Inline), Op]
        public Lodsb lodsb(AsmHexCode encoded) => new Lodsb(encoded);

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

        public Lodsw lodsw() => default;

        [MethodImpl(Inline), Op]
        public Lodsw lodsw(AsmHexCode encoded) => new Lodsw(encoded);

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

        public Lodsd lodsd() => default;

        [MethodImpl(Inline), Op]
        public Lodsd lodsd(AsmHexCode encoded) => new Lodsd(encoded);

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

        public Lodsq lodsq() => default;

        [MethodImpl(Inline), Op]
        public Lodsq lodsq(AsmHexCode encoded) => new Lodsq(encoded);

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

        public Loop loop() => default;

        [MethodImpl(Inline), Op]
        public Loop loop(AsmHexCode encoded) => new Loop(encoded);

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

        public Loope loope() => default;

        [MethodImpl(Inline), Op]
        public Loope loope(AsmHexCode encoded) => new Loope(encoded);

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

        public Loopne loopne() => default;

        [MethodImpl(Inline), Op]
        public Loopne loopne(AsmHexCode encoded) => new Loopne(encoded);

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

        public Lsl lsl() => default;

        [MethodImpl(Inline), Op]
        public Lsl lsl(AsmHexCode encoded) => new Lsl(encoded);

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

        public Ltr ltr() => default;

        [MethodImpl(Inline), Op]
        public Ltr ltr(AsmHexCode encoded) => new Ltr(encoded);

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

        public Lzcnt lzcnt() => default;

        [MethodImpl(Inline), Op]
        public Lzcnt lzcnt(AsmHexCode encoded) => new Lzcnt(encoded);

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

        public Maskmovdqu maskmovdqu() => default;

        [MethodImpl(Inline), Op]
        public Maskmovdqu maskmovdqu(AsmHexCode encoded) => new Maskmovdqu(encoded);

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

        public Vmaskmovdqu vmaskmovdqu() => default;

        [MethodImpl(Inline), Op]
        public Vmaskmovdqu vmaskmovdqu(AsmHexCode encoded) => new Vmaskmovdqu(encoded);

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

        public Maskmovq maskmovq() => default;

        [MethodImpl(Inline), Op]
        public Maskmovq maskmovq(AsmHexCode encoded) => new Maskmovq(encoded);

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

        public Maxpd maxpd() => default;

        [MethodImpl(Inline), Op]
        public Maxpd maxpd(AsmHexCode encoded) => new Maxpd(encoded);

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

        public Vmaxpd vmaxpd() => default;

        [MethodImpl(Inline), Op]
        public Vmaxpd vmaxpd(AsmHexCode encoded) => new Vmaxpd(encoded);

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

        public Maxps maxps() => default;

        [MethodImpl(Inline), Op]
        public Maxps maxps(AsmHexCode encoded) => new Maxps(encoded);

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

        public Vmaxps vmaxps() => default;

        [MethodImpl(Inline), Op]
        public Vmaxps vmaxps(AsmHexCode encoded) => new Vmaxps(encoded);

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

        public Maxsd maxsd() => default;

        [MethodImpl(Inline), Op]
        public Maxsd maxsd(AsmHexCode encoded) => new Maxsd(encoded);

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

        public Vmaxsd vmaxsd() => default;

        [MethodImpl(Inline), Op]
        public Vmaxsd vmaxsd(AsmHexCode encoded) => new Vmaxsd(encoded);

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

        public Maxss maxss() => default;

        [MethodImpl(Inline), Op]
        public Maxss maxss(AsmHexCode encoded) => new Maxss(encoded);

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

        public Vmaxss vmaxss() => default;

        [MethodImpl(Inline), Op]
        public Vmaxss vmaxss(AsmHexCode encoded) => new Vmaxss(encoded);

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

        public Mfence mfence() => default;

        [MethodImpl(Inline), Op]
        public Mfence mfence(AsmHexCode encoded) => new Mfence(encoded);

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

        public Minpd minpd() => default;

        [MethodImpl(Inline), Op]
        public Minpd minpd(AsmHexCode encoded) => new Minpd(encoded);

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

        public Vminpd vminpd() => default;

        [MethodImpl(Inline), Op]
        public Vminpd vminpd(AsmHexCode encoded) => new Vminpd(encoded);

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

        public Minps minps() => default;

        [MethodImpl(Inline), Op]
        public Minps minps(AsmHexCode encoded) => new Minps(encoded);

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

        public Vminps vminps() => default;

        [MethodImpl(Inline), Op]
        public Vminps vminps(AsmHexCode encoded) => new Vminps(encoded);

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

        public Minsd minsd() => default;

        [MethodImpl(Inline), Op]
        public Minsd minsd(AsmHexCode encoded) => new Minsd(encoded);

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

        public Vminsd vminsd() => default;

        [MethodImpl(Inline), Op]
        public Vminsd vminsd(AsmHexCode encoded) => new Vminsd(encoded);

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

        public Minss minss() => default;

        [MethodImpl(Inline), Op]
        public Minss minss(AsmHexCode encoded) => new Minss(encoded);

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

        public Vminss vminss() => default;

        [MethodImpl(Inline), Op]
        public Vminss vminss(AsmHexCode encoded) => new Vminss(encoded);

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

        public Monitor monitor() => default;

        [MethodImpl(Inline), Op]
        public Monitor monitor(AsmHexCode encoded) => new Monitor(encoded);

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

        public Mov mov() => default;

        [MethodImpl(Inline), Op]
        public Mov mov(AsmHexCode encoded) => new Mov(encoded);

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

        public Movapd movapd() => default;

        [MethodImpl(Inline), Op]
        public Movapd movapd(AsmHexCode encoded) => new Movapd(encoded);

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

        public Vmovapd vmovapd() => default;

        [MethodImpl(Inline), Op]
        public Vmovapd vmovapd(AsmHexCode encoded) => new Vmovapd(encoded);

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

        public Movaps movaps() => default;

        [MethodImpl(Inline), Op]
        public Movaps movaps(AsmHexCode encoded) => new Movaps(encoded);

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

        public Vmovaps vmovaps() => default;

        [MethodImpl(Inline), Op]
        public Vmovaps vmovaps(AsmHexCode encoded) => new Vmovaps(encoded);

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

        public Movbe movbe() => default;

        [MethodImpl(Inline), Op]
        public Movbe movbe(AsmHexCode encoded) => new Movbe(encoded);

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

        public Movd movd() => default;

        [MethodImpl(Inline), Op]
        public Movd movd(AsmHexCode encoded) => new Movd(encoded);

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

        public Movq movq() => default;

        [MethodImpl(Inline), Op]
        public Movq movq(AsmHexCode encoded) => new Movq(encoded);

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

        public Vmovd vmovd() => default;

        [MethodImpl(Inline), Op]
        public Vmovd vmovd(AsmHexCode encoded) => new Vmovd(encoded);

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

        public Vmovq vmovq() => default;

        [MethodImpl(Inline), Op]
        public Vmovq vmovq(AsmHexCode encoded) => new Vmovq(encoded);

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

        public Movddup movddup() => default;

        [MethodImpl(Inline), Op]
        public Movddup movddup(AsmHexCode encoded) => new Movddup(encoded);

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

        public Vmovddup vmovddup() => default;

        [MethodImpl(Inline), Op]
        public Vmovddup vmovddup(AsmHexCode encoded) => new Vmovddup(encoded);

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

        public Movdqa movdqa() => default;

        [MethodImpl(Inline), Op]
        public Movdqa movdqa(AsmHexCode encoded) => new Movdqa(encoded);

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

        public Vmovdqa vmovdqa() => default;

        [MethodImpl(Inline), Op]
        public Vmovdqa vmovdqa(AsmHexCode encoded) => new Vmovdqa(encoded);

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

        public Movdqu movdqu() => default;

        [MethodImpl(Inline), Op]
        public Movdqu movdqu(AsmHexCode encoded) => new Movdqu(encoded);

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

        public Vmovdqu vmovdqu() => default;

        [MethodImpl(Inline), Op]
        public Vmovdqu vmovdqu(AsmHexCode encoded) => new Vmovdqu(encoded);

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

        public Movdq2q movdq2q() => default;

        [MethodImpl(Inline), Op]
        public Movdq2q movdq2q(AsmHexCode encoded) => new Movdq2q(encoded);

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

        public Movhlps movhlps() => default;

        [MethodImpl(Inline), Op]
        public Movhlps movhlps(AsmHexCode encoded) => new Movhlps(encoded);

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

        public Vmovhlps vmovhlps() => default;

        [MethodImpl(Inline), Op]
        public Vmovhlps vmovhlps(AsmHexCode encoded) => new Vmovhlps(encoded);

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

        public Movhpd movhpd() => default;

        [MethodImpl(Inline), Op]
        public Movhpd movhpd(AsmHexCode encoded) => new Movhpd(encoded);

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

        public Vmovhpd vmovhpd() => default;

        [MethodImpl(Inline), Op]
        public Vmovhpd vmovhpd(AsmHexCode encoded) => new Vmovhpd(encoded);

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

        public Movhps movhps() => default;

        [MethodImpl(Inline), Op]
        public Movhps movhps(AsmHexCode encoded) => new Movhps(encoded);

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

        public Vmovhps vmovhps() => default;

        [MethodImpl(Inline), Op]
        public Vmovhps vmovhps(AsmHexCode encoded) => new Vmovhps(encoded);

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

        public Movlhps movlhps() => default;

        [MethodImpl(Inline), Op]
        public Movlhps movlhps(AsmHexCode encoded) => new Movlhps(encoded);

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

        public Vmovlhps vmovlhps() => default;

        [MethodImpl(Inline), Op]
        public Vmovlhps vmovlhps(AsmHexCode encoded) => new Vmovlhps(encoded);

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

        public Movlpd movlpd() => default;

        [MethodImpl(Inline), Op]
        public Movlpd movlpd(AsmHexCode encoded) => new Movlpd(encoded);

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

        public Vmovlpd vmovlpd() => default;

        [MethodImpl(Inline), Op]
        public Vmovlpd vmovlpd(AsmHexCode encoded) => new Vmovlpd(encoded);

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

        public Movlps movlps() => default;

        [MethodImpl(Inline), Op]
        public Movlps movlps(AsmHexCode encoded) => new Movlps(encoded);

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

        public Vmovlps vmovlps() => default;

        [MethodImpl(Inline), Op]
        public Vmovlps vmovlps(AsmHexCode encoded) => new Vmovlps(encoded);

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

        public Movmskpd movmskpd() => default;

        [MethodImpl(Inline), Op]
        public Movmskpd movmskpd(AsmHexCode encoded) => new Movmskpd(encoded);

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

        public Vmovmskpd vmovmskpd() => default;

        [MethodImpl(Inline), Op]
        public Vmovmskpd vmovmskpd(AsmHexCode encoded) => new Vmovmskpd(encoded);

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

        public Movmskps movmskps() => default;

        [MethodImpl(Inline), Op]
        public Movmskps movmskps(AsmHexCode encoded) => new Movmskps(encoded);

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

        public Vmovmskps vmovmskps() => default;

        [MethodImpl(Inline), Op]
        public Vmovmskps vmovmskps(AsmHexCode encoded) => new Vmovmskps(encoded);

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

        public Movntdqa movntdqa() => default;

        [MethodImpl(Inline), Op]
        public Movntdqa movntdqa(AsmHexCode encoded) => new Movntdqa(encoded);

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

        public Vmovntdqa vmovntdqa() => default;

        [MethodImpl(Inline), Op]
        public Vmovntdqa vmovntdqa(AsmHexCode encoded) => new Vmovntdqa(encoded);

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

        public Movntdq movntdq() => default;

        [MethodImpl(Inline), Op]
        public Movntdq movntdq(AsmHexCode encoded) => new Movntdq(encoded);

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

        public Vmovntdq vmovntdq() => default;

        [MethodImpl(Inline), Op]
        public Vmovntdq vmovntdq(AsmHexCode encoded) => new Vmovntdq(encoded);

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

        public Movnti movnti() => default;

        [MethodImpl(Inline), Op]
        public Movnti movnti(AsmHexCode encoded) => new Movnti(encoded);

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

        public Movntpd movntpd() => default;

        [MethodImpl(Inline), Op]
        public Movntpd movntpd(AsmHexCode encoded) => new Movntpd(encoded);

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

        public Vmovntpd vmovntpd() => default;

        [MethodImpl(Inline), Op]
        public Vmovntpd vmovntpd(AsmHexCode encoded) => new Vmovntpd(encoded);

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

        public Movntps movntps() => default;

        [MethodImpl(Inline), Op]
        public Movntps movntps(AsmHexCode encoded) => new Movntps(encoded);

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

        public Vmovntps vmovntps() => default;

        [MethodImpl(Inline), Op]
        public Vmovntps vmovntps(AsmHexCode encoded) => new Vmovntps(encoded);

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

        public Movntq movntq() => default;

        [MethodImpl(Inline), Op]
        public Movntq movntq(AsmHexCode encoded) => new Movntq(encoded);

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

        public Movq2dq movq2dq() => default;

        [MethodImpl(Inline), Op]
        public Movq2dq movq2dq(AsmHexCode encoded) => new Movq2dq(encoded);

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

        public Movs movs() => default;

        [MethodImpl(Inline), Op]
        public Movs movs(AsmHexCode encoded) => new Movs(encoded);

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

        public Movsb movsb() => default;

        [MethodImpl(Inline), Op]
        public Movsb movsb(AsmHexCode encoded) => new Movsb(encoded);

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

        public Movsw movsw() => default;

        [MethodImpl(Inline), Op]
        public Movsw movsw(AsmHexCode encoded) => new Movsw(encoded);

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

        public Movsd movsd() => default;

        [MethodImpl(Inline), Op]
        public Movsd movsd(AsmHexCode encoded) => new Movsd(encoded);

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

        public Movsq movsq() => default;

        [MethodImpl(Inline), Op]
        public Movsq movsq(AsmHexCode encoded) => new Movsq(encoded);

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

        public Vmovsd vmovsd() => default;

        [MethodImpl(Inline), Op]
        public Vmovsd vmovsd(AsmHexCode encoded) => new Vmovsd(encoded);

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

        public Movshdup movshdup() => default;

        [MethodImpl(Inline), Op]
        public Movshdup movshdup(AsmHexCode encoded) => new Movshdup(encoded);

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

        public Vmovshdup vmovshdup() => default;

        [MethodImpl(Inline), Op]
        public Vmovshdup vmovshdup(AsmHexCode encoded) => new Vmovshdup(encoded);

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

        public Movsldup movsldup() => default;

        [MethodImpl(Inline), Op]
        public Movsldup movsldup(AsmHexCode encoded) => new Movsldup(encoded);

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

        public Vmovsldup vmovsldup() => default;

        [MethodImpl(Inline), Op]
        public Vmovsldup vmovsldup(AsmHexCode encoded) => new Vmovsldup(encoded);

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

        public Movss movss() => default;

        [MethodImpl(Inline), Op]
        public Movss movss(AsmHexCode encoded) => new Movss(encoded);

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

        public Vmovss vmovss() => default;

        [MethodImpl(Inline), Op]
        public Vmovss vmovss(AsmHexCode encoded) => new Vmovss(encoded);

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

        public Movsx movsx() => default;

        [MethodImpl(Inline), Op]
        public Movsx movsx(AsmHexCode encoded) => new Movsx(encoded);

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

        public Movsxd movsxd() => default;

        [MethodImpl(Inline), Op]
        public Movsxd movsxd(AsmHexCode encoded) => new Movsxd(encoded);

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

        public Movupd movupd() => default;

        [MethodImpl(Inline), Op]
        public Movupd movupd(AsmHexCode encoded) => new Movupd(encoded);

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

        public Vmovupd vmovupd() => default;

        [MethodImpl(Inline), Op]
        public Vmovupd vmovupd(AsmHexCode encoded) => new Vmovupd(encoded);

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

        public Movups movups() => default;

        [MethodImpl(Inline), Op]
        public Movups movups(AsmHexCode encoded) => new Movups(encoded);

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

        public Vmovups vmovups() => default;

        [MethodImpl(Inline), Op]
        public Vmovups vmovups(AsmHexCode encoded) => new Vmovups(encoded);

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

        public Movzx movzx() => default;

        [MethodImpl(Inline), Op]
        public Movzx movzx(AsmHexCode encoded) => new Movzx(encoded);

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

        public Mpsadbw mpsadbw() => default;

        [MethodImpl(Inline), Op]
        public Mpsadbw mpsadbw(AsmHexCode encoded) => new Mpsadbw(encoded);

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

        public Vmpsadbw vmpsadbw() => default;

        [MethodImpl(Inline), Op]
        public Vmpsadbw vmpsadbw(AsmHexCode encoded) => new Vmpsadbw(encoded);

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

        public Mul mul() => default;

        [MethodImpl(Inline), Op]
        public Mul mul(AsmHexCode encoded) => new Mul(encoded);

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

        public Mulpd mulpd() => default;

        [MethodImpl(Inline), Op]
        public Mulpd mulpd(AsmHexCode encoded) => new Mulpd(encoded);

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

        public Vmulpd vmulpd() => default;

        [MethodImpl(Inline), Op]
        public Vmulpd vmulpd(AsmHexCode encoded) => new Vmulpd(encoded);

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

        public Mulps mulps() => default;

        [MethodImpl(Inline), Op]
        public Mulps mulps(AsmHexCode encoded) => new Mulps(encoded);

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

        public Vmulps vmulps() => default;

        [MethodImpl(Inline), Op]
        public Vmulps vmulps(AsmHexCode encoded) => new Vmulps(encoded);

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

        public Mulsd mulsd() => default;

        [MethodImpl(Inline), Op]
        public Mulsd mulsd(AsmHexCode encoded) => new Mulsd(encoded);

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

        public Vmulsd vmulsd() => default;

        [MethodImpl(Inline), Op]
        public Vmulsd vmulsd(AsmHexCode encoded) => new Vmulsd(encoded);

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

        public Mulss mulss() => default;

        [MethodImpl(Inline), Op]
        public Mulss mulss(AsmHexCode encoded) => new Mulss(encoded);

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

        public Vmulss vmulss() => default;

        [MethodImpl(Inline), Op]
        public Vmulss vmulss(AsmHexCode encoded) => new Vmulss(encoded);

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

        public Mulx mulx() => default;

        [MethodImpl(Inline), Op]
        public Mulx mulx(AsmHexCode encoded) => new Mulx(encoded);

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

        public Mwait mwait() => default;

        [MethodImpl(Inline), Op]
        public Mwait mwait(AsmHexCode encoded) => new Mwait(encoded);

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

        public Neg neg() => default;

        [MethodImpl(Inline), Op]
        public Neg neg(AsmHexCode encoded) => new Neg(encoded);

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

        public Nop nop() => default;

        [MethodImpl(Inline), Op]
        public Nop nop(AsmHexCode encoded) => new Nop(encoded);

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

        public Not not() => default;

        [MethodImpl(Inline), Op]
        public Not not(AsmHexCode encoded) => new Not(encoded);

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

        public Or or() => default;

        [MethodImpl(Inline), Op]
        public Or or(AsmHexCode encoded) => new Or(encoded);

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

        public Orpd orpd() => default;

        [MethodImpl(Inline), Op]
        public Orpd orpd(AsmHexCode encoded) => new Orpd(encoded);

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

        public Vorpd vorpd() => default;

        [MethodImpl(Inline), Op]
        public Vorpd vorpd(AsmHexCode encoded) => new Vorpd(encoded);

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

        public Orps orps() => default;

        [MethodImpl(Inline), Op]
        public Orps orps(AsmHexCode encoded) => new Orps(encoded);

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

        public Vorps vorps() => default;

        [MethodImpl(Inline), Op]
        public Vorps vorps(AsmHexCode encoded) => new Vorps(encoded);

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

        public Out @out() => default;

        [MethodImpl(Inline), Op]
        public Out @out(AsmHexCode encoded) => new Out(encoded);

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

        public Outs outs() => default;

        [MethodImpl(Inline), Op]
        public Outs outs(AsmHexCode encoded) => new Outs(encoded);

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

        public Outsb outsb() => default;

        [MethodImpl(Inline), Op]
        public Outsb outsb(AsmHexCode encoded) => new Outsb(encoded);

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

        public Outsw outsw() => default;

        [MethodImpl(Inline), Op]
        public Outsw outsw(AsmHexCode encoded) => new Outsw(encoded);

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

        public Outsd outsd() => default;

        [MethodImpl(Inline), Op]
        public Outsd outsd(AsmHexCode encoded) => new Outsd(encoded);

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

        public Pabsb pabsb() => default;

        [MethodImpl(Inline), Op]
        public Pabsb pabsb(AsmHexCode encoded) => new Pabsb(encoded);

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

        public Pabsw pabsw() => default;

        [MethodImpl(Inline), Op]
        public Pabsw pabsw(AsmHexCode encoded) => new Pabsw(encoded);

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

        public Pabsd pabsd() => default;

        [MethodImpl(Inline), Op]
        public Pabsd pabsd(AsmHexCode encoded) => new Pabsd(encoded);

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

        public Vpabsb vpabsb() => default;

        [MethodImpl(Inline), Op]
        public Vpabsb vpabsb(AsmHexCode encoded) => new Vpabsb(encoded);

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

        public Vpabsw vpabsw() => default;

        [MethodImpl(Inline), Op]
        public Vpabsw vpabsw(AsmHexCode encoded) => new Vpabsw(encoded);

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

        public Vpabsd vpabsd() => default;

        [MethodImpl(Inline), Op]
        public Vpabsd vpabsd(AsmHexCode encoded) => new Vpabsd(encoded);

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

        public Packsswb packsswb() => default;

        [MethodImpl(Inline), Op]
        public Packsswb packsswb(AsmHexCode encoded) => new Packsswb(encoded);

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

        public Packssdw packssdw() => default;

        [MethodImpl(Inline), Op]
        public Packssdw packssdw(AsmHexCode encoded) => new Packssdw(encoded);

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

        public Vpacksswb vpacksswb() => default;

        [MethodImpl(Inline), Op]
        public Vpacksswb vpacksswb(AsmHexCode encoded) => new Vpacksswb(encoded);

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

        public Vpackssdw vpackssdw() => default;

        [MethodImpl(Inline), Op]
        public Vpackssdw vpackssdw(AsmHexCode encoded) => new Vpackssdw(encoded);

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

        public Packusdw packusdw() => default;

        [MethodImpl(Inline), Op]
        public Packusdw packusdw(AsmHexCode encoded) => new Packusdw(encoded);

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

        public Vpackusdw vpackusdw() => default;

        [MethodImpl(Inline), Op]
        public Vpackusdw vpackusdw(AsmHexCode encoded) => new Vpackusdw(encoded);

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

        public Packuswb packuswb() => default;

        [MethodImpl(Inline), Op]
        public Packuswb packuswb(AsmHexCode encoded) => new Packuswb(encoded);

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

        public Vpackuswb vpackuswb() => default;

        [MethodImpl(Inline), Op]
        public Vpackuswb vpackuswb(AsmHexCode encoded) => new Vpackuswb(encoded);

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

        public Paddb paddb() => default;

        [MethodImpl(Inline), Op]
        public Paddb paddb(AsmHexCode encoded) => new Paddb(encoded);

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

        public Paddw paddw() => default;

        [MethodImpl(Inline), Op]
        public Paddw paddw(AsmHexCode encoded) => new Paddw(encoded);

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

        public Paddd paddd() => default;

        [MethodImpl(Inline), Op]
        public Paddd paddd(AsmHexCode encoded) => new Paddd(encoded);

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

        public Vpaddb vpaddb() => default;

        [MethodImpl(Inline), Op]
        public Vpaddb vpaddb(AsmHexCode encoded) => new Vpaddb(encoded);

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

        public Vpaddw vpaddw() => default;

        [MethodImpl(Inline), Op]
        public Vpaddw vpaddw(AsmHexCode encoded) => new Vpaddw(encoded);

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

        public Vpaddd vpaddd() => default;

        [MethodImpl(Inline), Op]
        public Vpaddd vpaddd(AsmHexCode encoded) => new Vpaddd(encoded);

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

        public Paddq paddq() => default;

        [MethodImpl(Inline), Op]
        public Paddq paddq(AsmHexCode encoded) => new Paddq(encoded);

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

        public Vpaddq vpaddq() => default;

        [MethodImpl(Inline), Op]
        public Vpaddq vpaddq(AsmHexCode encoded) => new Vpaddq(encoded);

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

        public Paddsb paddsb() => default;

        [MethodImpl(Inline), Op]
        public Paddsb paddsb(AsmHexCode encoded) => new Paddsb(encoded);

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

        public Paddsw paddsw() => default;

        [MethodImpl(Inline), Op]
        public Paddsw paddsw(AsmHexCode encoded) => new Paddsw(encoded);

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

        public Vpaddsb vpaddsb() => default;

        [MethodImpl(Inline), Op]
        public Vpaddsb vpaddsb(AsmHexCode encoded) => new Vpaddsb(encoded);

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

        public Vpaddsw vpaddsw() => default;

        [MethodImpl(Inline), Op]
        public Vpaddsw vpaddsw(AsmHexCode encoded) => new Vpaddsw(encoded);

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

        public Paddusb paddusb() => default;

        [MethodImpl(Inline), Op]
        public Paddusb paddusb(AsmHexCode encoded) => new Paddusb(encoded);

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

        public Paddusw paddusw() => default;

        [MethodImpl(Inline), Op]
        public Paddusw paddusw(AsmHexCode encoded) => new Paddusw(encoded);

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

        public Vpaddusb vpaddusb() => default;

        [MethodImpl(Inline), Op]
        public Vpaddusb vpaddusb(AsmHexCode encoded) => new Vpaddusb(encoded);

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

        public Vpaddusw vpaddusw() => default;

        [MethodImpl(Inline), Op]
        public Vpaddusw vpaddusw(AsmHexCode encoded) => new Vpaddusw(encoded);

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

        public Palignr palignr() => default;

        [MethodImpl(Inline), Op]
        public Palignr palignr(AsmHexCode encoded) => new Palignr(encoded);

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

        public Vpalignr vpalignr() => default;

        [MethodImpl(Inline), Op]
        public Vpalignr vpalignr(AsmHexCode encoded) => new Vpalignr(encoded);

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

        public Pand pand() => default;

        [MethodImpl(Inline), Op]
        public Pand pand(AsmHexCode encoded) => new Pand(encoded);

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

        public Vpand vpand() => default;

        [MethodImpl(Inline), Op]
        public Vpand vpand(AsmHexCode encoded) => new Vpand(encoded);

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

        public Pandn pandn() => default;

        [MethodImpl(Inline), Op]
        public Pandn pandn(AsmHexCode encoded) => new Pandn(encoded);

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

        public Vpandn vpandn() => default;

        [MethodImpl(Inline), Op]
        public Vpandn vpandn(AsmHexCode encoded) => new Vpandn(encoded);

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

        public Pause pause() => default;

        [MethodImpl(Inline), Op]
        public Pause pause(AsmHexCode encoded) => new Pause(encoded);

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

        public Pavgb pavgb() => default;

        [MethodImpl(Inline), Op]
        public Pavgb pavgb(AsmHexCode encoded) => new Pavgb(encoded);

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

        public Pavgw pavgw() => default;

        [MethodImpl(Inline), Op]
        public Pavgw pavgw(AsmHexCode encoded) => new Pavgw(encoded);

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

        public Vpavgb vpavgb() => default;

        [MethodImpl(Inline), Op]
        public Vpavgb vpavgb(AsmHexCode encoded) => new Vpavgb(encoded);

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

        public Vpavgw vpavgw() => default;

        [MethodImpl(Inline), Op]
        public Vpavgw vpavgw(AsmHexCode encoded) => new Vpavgw(encoded);

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

        public Pblendvb pblendvb() => default;

        [MethodImpl(Inline), Op]
        public Pblendvb pblendvb(AsmHexCode encoded) => new Pblendvb(encoded);

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

        public Vpblendvb vpblendvb() => default;

        [MethodImpl(Inline), Op]
        public Vpblendvb vpblendvb(AsmHexCode encoded) => new Vpblendvb(encoded);

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

        public Pblendw pblendw() => default;

        [MethodImpl(Inline), Op]
        public Pblendw pblendw(AsmHexCode encoded) => new Pblendw(encoded);

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

        public Vpblendw vpblendw() => default;

        [MethodImpl(Inline), Op]
        public Vpblendw vpblendw(AsmHexCode encoded) => new Vpblendw(encoded);

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

        public Pclmulqdq pclmulqdq() => default;

        [MethodImpl(Inline), Op]
        public Pclmulqdq pclmulqdq(AsmHexCode encoded) => new Pclmulqdq(encoded);

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

        public Vpclmulqdq vpclmulqdq() => default;

        [MethodImpl(Inline), Op]
        public Vpclmulqdq vpclmulqdq(AsmHexCode encoded) => new Vpclmulqdq(encoded);

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

        public Pcmpeqb pcmpeqb() => default;

        [MethodImpl(Inline), Op]
        public Pcmpeqb pcmpeqb(AsmHexCode encoded) => new Pcmpeqb(encoded);

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

        public Pcmpeqw pcmpeqw() => default;

        [MethodImpl(Inline), Op]
        public Pcmpeqw pcmpeqw(AsmHexCode encoded) => new Pcmpeqw(encoded);

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

        public Pcmpeqd pcmpeqd() => default;

        [MethodImpl(Inline), Op]
        public Pcmpeqd pcmpeqd(AsmHexCode encoded) => new Pcmpeqd(encoded);

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

        public Vpcmpeqb vpcmpeqb() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpeqb vpcmpeqb(AsmHexCode encoded) => new Vpcmpeqb(encoded);

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

        public Vpcmpeqw vpcmpeqw() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpeqw vpcmpeqw(AsmHexCode encoded) => new Vpcmpeqw(encoded);

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

        public Vpcmpeqd vpcmpeqd() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpeqd vpcmpeqd(AsmHexCode encoded) => new Vpcmpeqd(encoded);

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

        public Pcmpeqq pcmpeqq() => default;

        [MethodImpl(Inline), Op]
        public Pcmpeqq pcmpeqq(AsmHexCode encoded) => new Pcmpeqq(encoded);

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

        public Vpcmpeqq vpcmpeqq() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpeqq vpcmpeqq(AsmHexCode encoded) => new Vpcmpeqq(encoded);

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

        public Pcmpestri pcmpestri() => default;

        [MethodImpl(Inline), Op]
        public Pcmpestri pcmpestri(AsmHexCode encoded) => new Pcmpestri(encoded);

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

        public Vpcmpestri vpcmpestri() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpestri vpcmpestri(AsmHexCode encoded) => new Vpcmpestri(encoded);

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

        public Pcmpestrm pcmpestrm() => default;

        [MethodImpl(Inline), Op]
        public Pcmpestrm pcmpestrm(AsmHexCode encoded) => new Pcmpestrm(encoded);

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

        public Vpcmpestrm vpcmpestrm() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpestrm vpcmpestrm(AsmHexCode encoded) => new Vpcmpestrm(encoded);

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

        public Pcmpgtb pcmpgtb() => default;

        [MethodImpl(Inline), Op]
        public Pcmpgtb pcmpgtb(AsmHexCode encoded) => new Pcmpgtb(encoded);

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

        public Pcmpgtw pcmpgtw() => default;

        [MethodImpl(Inline), Op]
        public Pcmpgtw pcmpgtw(AsmHexCode encoded) => new Pcmpgtw(encoded);

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

        public Pcmpgtd pcmpgtd() => default;

        [MethodImpl(Inline), Op]
        public Pcmpgtd pcmpgtd(AsmHexCode encoded) => new Pcmpgtd(encoded);

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

        public Vpcmpgtb vpcmpgtb() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpgtb vpcmpgtb(AsmHexCode encoded) => new Vpcmpgtb(encoded);

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

        public Vpcmpgtw vpcmpgtw() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpgtw vpcmpgtw(AsmHexCode encoded) => new Vpcmpgtw(encoded);

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

        public Vpcmpgtd vpcmpgtd() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpgtd vpcmpgtd(AsmHexCode encoded) => new Vpcmpgtd(encoded);

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

        public Pcmpgtq pcmpgtq() => default;

        [MethodImpl(Inline), Op]
        public Pcmpgtq pcmpgtq(AsmHexCode encoded) => new Pcmpgtq(encoded);

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

        public Vpcmpgtq vpcmpgtq() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpgtq vpcmpgtq(AsmHexCode encoded) => new Vpcmpgtq(encoded);

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

        public Pcmpistri pcmpistri() => default;

        [MethodImpl(Inline), Op]
        public Pcmpistri pcmpistri(AsmHexCode encoded) => new Pcmpistri(encoded);

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

        public Vpcmpistri vpcmpistri() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpistri vpcmpistri(AsmHexCode encoded) => new Vpcmpistri(encoded);

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

        public Pcmpistrm pcmpistrm() => default;

        [MethodImpl(Inline), Op]
        public Pcmpistrm pcmpistrm(AsmHexCode encoded) => new Pcmpistrm(encoded);

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

        public Vpcmpistrm vpcmpistrm() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpistrm vpcmpistrm(AsmHexCode encoded) => new Vpcmpistrm(encoded);

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

        public Pdep pdep() => default;

        [MethodImpl(Inline), Op]
        public Pdep pdep(AsmHexCode encoded) => new Pdep(encoded);

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

        public Pext pext() => default;

        [MethodImpl(Inline), Op]
        public Pext pext(AsmHexCode encoded) => new Pext(encoded);

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

        public Pextrb pextrb() => default;

        [MethodImpl(Inline), Op]
        public Pextrb pextrb(AsmHexCode encoded) => new Pextrb(encoded);

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

        public Pextrd pextrd() => default;

        [MethodImpl(Inline), Op]
        public Pextrd pextrd(AsmHexCode encoded) => new Pextrd(encoded);

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

        public Pextrq pextrq() => default;

        [MethodImpl(Inline), Op]
        public Pextrq pextrq(AsmHexCode encoded) => new Pextrq(encoded);

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

        public Vpextrb vpextrb() => default;

        [MethodImpl(Inline), Op]
        public Vpextrb vpextrb(AsmHexCode encoded) => new Vpextrb(encoded);

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

        public Vpextrd vpextrd() => default;

        [MethodImpl(Inline), Op]
        public Vpextrd vpextrd(AsmHexCode encoded) => new Vpextrd(encoded);

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

        public Vpextrq vpextrq() => default;

        [MethodImpl(Inline), Op]
        public Vpextrq vpextrq(AsmHexCode encoded) => new Vpextrq(encoded);

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

        public Pextrw pextrw() => default;

        [MethodImpl(Inline), Op]
        public Pextrw pextrw(AsmHexCode encoded) => new Pextrw(encoded);

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

        public Vpextrw vpextrw() => default;

        [MethodImpl(Inline), Op]
        public Vpextrw vpextrw(AsmHexCode encoded) => new Vpextrw(encoded);

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

        public Phaddw phaddw() => default;

        [MethodImpl(Inline), Op]
        public Phaddw phaddw(AsmHexCode encoded) => new Phaddw(encoded);

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

        public Phaddd phaddd() => default;

        [MethodImpl(Inline), Op]
        public Phaddd phaddd(AsmHexCode encoded) => new Phaddd(encoded);

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

        public Vphaddw vphaddw() => default;

        [MethodImpl(Inline), Op]
        public Vphaddw vphaddw(AsmHexCode encoded) => new Vphaddw(encoded);

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

        public Vphaddd vphaddd() => default;

        [MethodImpl(Inline), Op]
        public Vphaddd vphaddd(AsmHexCode encoded) => new Vphaddd(encoded);

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

        public Phaddsw phaddsw() => default;

        [MethodImpl(Inline), Op]
        public Phaddsw phaddsw(AsmHexCode encoded) => new Phaddsw(encoded);

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

        public Vphaddsw vphaddsw() => default;

        [MethodImpl(Inline), Op]
        public Vphaddsw vphaddsw(AsmHexCode encoded) => new Vphaddsw(encoded);

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

        public Phminposuw phminposuw() => default;

        [MethodImpl(Inline), Op]
        public Phminposuw phminposuw(AsmHexCode encoded) => new Phminposuw(encoded);

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

        public Vphminposuw vphminposuw() => default;

        [MethodImpl(Inline), Op]
        public Vphminposuw vphminposuw(AsmHexCode encoded) => new Vphminposuw(encoded);

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

        public Phsubw phsubw() => default;

        [MethodImpl(Inline), Op]
        public Phsubw phsubw(AsmHexCode encoded) => new Phsubw(encoded);

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

        public Phsubd phsubd() => default;

        [MethodImpl(Inline), Op]
        public Phsubd phsubd(AsmHexCode encoded) => new Phsubd(encoded);

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

        public Vphsubw vphsubw() => default;

        [MethodImpl(Inline), Op]
        public Vphsubw vphsubw(AsmHexCode encoded) => new Vphsubw(encoded);

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

        public Vphsubd vphsubd() => default;

        [MethodImpl(Inline), Op]
        public Vphsubd vphsubd(AsmHexCode encoded) => new Vphsubd(encoded);

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

        public Phsubsw phsubsw() => default;

        [MethodImpl(Inline), Op]
        public Phsubsw phsubsw(AsmHexCode encoded) => new Phsubsw(encoded);

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

        public Vphsubsw vphsubsw() => default;

        [MethodImpl(Inline), Op]
        public Vphsubsw vphsubsw(AsmHexCode encoded) => new Vphsubsw(encoded);

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

        public Pinsrb pinsrb() => default;

        [MethodImpl(Inline), Op]
        public Pinsrb pinsrb(AsmHexCode encoded) => new Pinsrb(encoded);

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

        public Pinsrd pinsrd() => default;

        [MethodImpl(Inline), Op]
        public Pinsrd pinsrd(AsmHexCode encoded) => new Pinsrd(encoded);

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

        public Pinsrq pinsrq() => default;

        [MethodImpl(Inline), Op]
        public Pinsrq pinsrq(AsmHexCode encoded) => new Pinsrq(encoded);

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

        public Vpinsrb vpinsrb() => default;

        [MethodImpl(Inline), Op]
        public Vpinsrb vpinsrb(AsmHexCode encoded) => new Vpinsrb(encoded);

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

        public Vpinsrd vpinsrd() => default;

        [MethodImpl(Inline), Op]
        public Vpinsrd vpinsrd(AsmHexCode encoded) => new Vpinsrd(encoded);

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

        public Vpinsrq vpinsrq() => default;

        [MethodImpl(Inline), Op]
        public Vpinsrq vpinsrq(AsmHexCode encoded) => new Vpinsrq(encoded);

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

        public Pinsrw pinsrw() => default;

        [MethodImpl(Inline), Op]
        public Pinsrw pinsrw(AsmHexCode encoded) => new Pinsrw(encoded);

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

        public Vpinsrw vpinsrw() => default;

        [MethodImpl(Inline), Op]
        public Vpinsrw vpinsrw(AsmHexCode encoded) => new Vpinsrw(encoded);

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

        public Pmaddubsw pmaddubsw() => default;

        [MethodImpl(Inline), Op]
        public Pmaddubsw pmaddubsw(AsmHexCode encoded) => new Pmaddubsw(encoded);

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

        public Vpmaddubsw vpmaddubsw() => default;

        [MethodImpl(Inline), Op]
        public Vpmaddubsw vpmaddubsw(AsmHexCode encoded) => new Vpmaddubsw(encoded);

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

        public Pmaddwd pmaddwd() => default;

        [MethodImpl(Inline), Op]
        public Pmaddwd pmaddwd(AsmHexCode encoded) => new Pmaddwd(encoded);

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

        public Vpmaddwd vpmaddwd() => default;

        [MethodImpl(Inline), Op]
        public Vpmaddwd vpmaddwd(AsmHexCode encoded) => new Vpmaddwd(encoded);

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

        public Pmaxsb pmaxsb() => default;

        [MethodImpl(Inline), Op]
        public Pmaxsb pmaxsb(AsmHexCode encoded) => new Pmaxsb(encoded);

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

        public Vpmaxsb vpmaxsb() => default;

        [MethodImpl(Inline), Op]
        public Vpmaxsb vpmaxsb(AsmHexCode encoded) => new Vpmaxsb(encoded);

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

        public Pmaxsd pmaxsd() => default;

        [MethodImpl(Inline), Op]
        public Pmaxsd pmaxsd(AsmHexCode encoded) => new Pmaxsd(encoded);

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

        public Vpmaxsd vpmaxsd() => default;

        [MethodImpl(Inline), Op]
        public Vpmaxsd vpmaxsd(AsmHexCode encoded) => new Vpmaxsd(encoded);

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

        public Pmaxsw pmaxsw() => default;

        [MethodImpl(Inline), Op]
        public Pmaxsw pmaxsw(AsmHexCode encoded) => new Pmaxsw(encoded);

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

        public Vpmaxsw vpmaxsw() => default;

        [MethodImpl(Inline), Op]
        public Vpmaxsw vpmaxsw(AsmHexCode encoded) => new Vpmaxsw(encoded);

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

        public Pmaxub pmaxub() => default;

        [MethodImpl(Inline), Op]
        public Pmaxub pmaxub(AsmHexCode encoded) => new Pmaxub(encoded);

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

        public Vpmaxub vpmaxub() => default;

        [MethodImpl(Inline), Op]
        public Vpmaxub vpmaxub(AsmHexCode encoded) => new Vpmaxub(encoded);

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

        public Pmaxud pmaxud() => default;

        [MethodImpl(Inline), Op]
        public Pmaxud pmaxud(AsmHexCode encoded) => new Pmaxud(encoded);

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

        public Vpmaxud vpmaxud() => default;

        [MethodImpl(Inline), Op]
        public Vpmaxud vpmaxud(AsmHexCode encoded) => new Vpmaxud(encoded);

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

        public Pmaxuw pmaxuw() => default;

        [MethodImpl(Inline), Op]
        public Pmaxuw pmaxuw(AsmHexCode encoded) => new Pmaxuw(encoded);

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

        public Vpmaxuw vpmaxuw() => default;

        [MethodImpl(Inline), Op]
        public Vpmaxuw vpmaxuw(AsmHexCode encoded) => new Vpmaxuw(encoded);

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

        public Pminsb pminsb() => default;

        [MethodImpl(Inline), Op]
        public Pminsb pminsb(AsmHexCode encoded) => new Pminsb(encoded);

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

        public Vpminsb vpminsb() => default;

        [MethodImpl(Inline), Op]
        public Vpminsb vpminsb(AsmHexCode encoded) => new Vpminsb(encoded);

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

        public Pminsd pminsd() => default;

        [MethodImpl(Inline), Op]
        public Pminsd pminsd(AsmHexCode encoded) => new Pminsd(encoded);

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

        public Vpminsd vpminsd() => default;

        [MethodImpl(Inline), Op]
        public Vpminsd vpminsd(AsmHexCode encoded) => new Vpminsd(encoded);

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

        public Pminsw pminsw() => default;

        [MethodImpl(Inline), Op]
        public Pminsw pminsw(AsmHexCode encoded) => new Pminsw(encoded);

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

        public Vpminsw vpminsw() => default;

        [MethodImpl(Inline), Op]
        public Vpminsw vpminsw(AsmHexCode encoded) => new Vpminsw(encoded);

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

        public Pminub pminub() => default;

        [MethodImpl(Inline), Op]
        public Pminub pminub(AsmHexCode encoded) => new Pminub(encoded);

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

        public Vpminub vpminub() => default;

        [MethodImpl(Inline), Op]
        public Vpminub vpminub(AsmHexCode encoded) => new Vpminub(encoded);

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

        public Pminud pminud() => default;

        [MethodImpl(Inline), Op]
        public Pminud pminud(AsmHexCode encoded) => new Pminud(encoded);

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

        public Vpminud vpminud() => default;

        [MethodImpl(Inline), Op]
        public Vpminud vpminud(AsmHexCode encoded) => new Vpminud(encoded);

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

        public Pminuw pminuw() => default;

        [MethodImpl(Inline), Op]
        public Pminuw pminuw(AsmHexCode encoded) => new Pminuw(encoded);

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

        public Vpminuw vpminuw() => default;

        [MethodImpl(Inline), Op]
        public Vpminuw vpminuw(AsmHexCode encoded) => new Vpminuw(encoded);

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

        public Pmovmskb pmovmskb() => default;

        [MethodImpl(Inline), Op]
        public Pmovmskb pmovmskb(AsmHexCode encoded) => new Pmovmskb(encoded);

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

        public Vpmovmskb vpmovmskb() => default;

        [MethodImpl(Inline), Op]
        public Vpmovmskb vpmovmskb(AsmHexCode encoded) => new Vpmovmskb(encoded);

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

        public Pmovsxbw pmovsxbw() => default;

        [MethodImpl(Inline), Op]
        public Pmovsxbw pmovsxbw(AsmHexCode encoded) => new Pmovsxbw(encoded);

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

        public Pmovsxbd pmovsxbd() => default;

        [MethodImpl(Inline), Op]
        public Pmovsxbd pmovsxbd(AsmHexCode encoded) => new Pmovsxbd(encoded);

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

        public Pmovsxbq pmovsxbq() => default;

        [MethodImpl(Inline), Op]
        public Pmovsxbq pmovsxbq(AsmHexCode encoded) => new Pmovsxbq(encoded);

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

        public Pmovsxwd pmovsxwd() => default;

        [MethodImpl(Inline), Op]
        public Pmovsxwd pmovsxwd(AsmHexCode encoded) => new Pmovsxwd(encoded);

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

        public Pmovsxwq pmovsxwq() => default;

        [MethodImpl(Inline), Op]
        public Pmovsxwq pmovsxwq(AsmHexCode encoded) => new Pmovsxwq(encoded);

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

        public Pmovsxdq pmovsxdq() => default;

        [MethodImpl(Inline), Op]
        public Pmovsxdq pmovsxdq(AsmHexCode encoded) => new Pmovsxdq(encoded);

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

        public Vpmovsxbw vpmovsxbw() => default;

        [MethodImpl(Inline), Op]
        public Vpmovsxbw vpmovsxbw(AsmHexCode encoded) => new Vpmovsxbw(encoded);

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

        public Vpmovsxbd vpmovsxbd() => default;

        [MethodImpl(Inline), Op]
        public Vpmovsxbd vpmovsxbd(AsmHexCode encoded) => new Vpmovsxbd(encoded);

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

        public Vpmovsxbq vpmovsxbq() => default;

        [MethodImpl(Inline), Op]
        public Vpmovsxbq vpmovsxbq(AsmHexCode encoded) => new Vpmovsxbq(encoded);

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

        public Vpmovsxwd vpmovsxwd() => default;

        [MethodImpl(Inline), Op]
        public Vpmovsxwd vpmovsxwd(AsmHexCode encoded) => new Vpmovsxwd(encoded);

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

        public Vpmovsxwq vpmovsxwq() => default;

        [MethodImpl(Inline), Op]
        public Vpmovsxwq vpmovsxwq(AsmHexCode encoded) => new Vpmovsxwq(encoded);

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

        public Vpmovsxdq vpmovsxdq() => default;

        [MethodImpl(Inline), Op]
        public Vpmovsxdq vpmovsxdq(AsmHexCode encoded) => new Vpmovsxdq(encoded);

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

        public Pmovzxbw pmovzxbw() => default;

        [MethodImpl(Inline), Op]
        public Pmovzxbw pmovzxbw(AsmHexCode encoded) => new Pmovzxbw(encoded);

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

        public Pmovzxbd pmovzxbd() => default;

        [MethodImpl(Inline), Op]
        public Pmovzxbd pmovzxbd(AsmHexCode encoded) => new Pmovzxbd(encoded);

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

        public Pmovzxbq pmovzxbq() => default;

        [MethodImpl(Inline), Op]
        public Pmovzxbq pmovzxbq(AsmHexCode encoded) => new Pmovzxbq(encoded);

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

        public Pmovzxwd pmovzxwd() => default;

        [MethodImpl(Inline), Op]
        public Pmovzxwd pmovzxwd(AsmHexCode encoded) => new Pmovzxwd(encoded);

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

        public Pmovzxwq pmovzxwq() => default;

        [MethodImpl(Inline), Op]
        public Pmovzxwq pmovzxwq(AsmHexCode encoded) => new Pmovzxwq(encoded);

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

        public Pmovzxdq pmovzxdq() => default;

        [MethodImpl(Inline), Op]
        public Pmovzxdq pmovzxdq(AsmHexCode encoded) => new Pmovzxdq(encoded);

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

        public Vpmovzxbw vpmovzxbw() => default;

        [MethodImpl(Inline), Op]
        public Vpmovzxbw vpmovzxbw(AsmHexCode encoded) => new Vpmovzxbw(encoded);

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

        public Vpmovzxbd vpmovzxbd() => default;

        [MethodImpl(Inline), Op]
        public Vpmovzxbd vpmovzxbd(AsmHexCode encoded) => new Vpmovzxbd(encoded);

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

        public Vpmovzxbq vpmovzxbq() => default;

        [MethodImpl(Inline), Op]
        public Vpmovzxbq vpmovzxbq(AsmHexCode encoded) => new Vpmovzxbq(encoded);

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

        public Vpmovzxwd vpmovzxwd() => default;

        [MethodImpl(Inline), Op]
        public Vpmovzxwd vpmovzxwd(AsmHexCode encoded) => new Vpmovzxwd(encoded);

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

        public Vpmovzxwq vpmovzxwq() => default;

        [MethodImpl(Inline), Op]
        public Vpmovzxwq vpmovzxwq(AsmHexCode encoded) => new Vpmovzxwq(encoded);

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

        public Vpmovzxdq vpmovzxdq() => default;

        [MethodImpl(Inline), Op]
        public Vpmovzxdq vpmovzxdq(AsmHexCode encoded) => new Vpmovzxdq(encoded);

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

        public Pmuldq pmuldq() => default;

        [MethodImpl(Inline), Op]
        public Pmuldq pmuldq(AsmHexCode encoded) => new Pmuldq(encoded);

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

        public Vpmuldq vpmuldq() => default;

        [MethodImpl(Inline), Op]
        public Vpmuldq vpmuldq(AsmHexCode encoded) => new Vpmuldq(encoded);

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

        public Pmulhrsw pmulhrsw() => default;

        [MethodImpl(Inline), Op]
        public Pmulhrsw pmulhrsw(AsmHexCode encoded) => new Pmulhrsw(encoded);

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

        public Vpmulhrsw vpmulhrsw() => default;

        [MethodImpl(Inline), Op]
        public Vpmulhrsw vpmulhrsw(AsmHexCode encoded) => new Vpmulhrsw(encoded);

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

        public Pmulhuw pmulhuw() => default;

        [MethodImpl(Inline), Op]
        public Pmulhuw pmulhuw(AsmHexCode encoded) => new Pmulhuw(encoded);

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

        public Vpmulhuw vpmulhuw() => default;

        [MethodImpl(Inline), Op]
        public Vpmulhuw vpmulhuw(AsmHexCode encoded) => new Vpmulhuw(encoded);

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

        public Pmulhw pmulhw() => default;

        [MethodImpl(Inline), Op]
        public Pmulhw pmulhw(AsmHexCode encoded) => new Pmulhw(encoded);

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

        public Vpmulhw vpmulhw() => default;

        [MethodImpl(Inline), Op]
        public Vpmulhw vpmulhw(AsmHexCode encoded) => new Vpmulhw(encoded);

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

        public Pmulld pmulld() => default;

        [MethodImpl(Inline), Op]
        public Pmulld pmulld(AsmHexCode encoded) => new Pmulld(encoded);

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

        public Vpmulld vpmulld() => default;

        [MethodImpl(Inline), Op]
        public Vpmulld vpmulld(AsmHexCode encoded) => new Vpmulld(encoded);

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

        public Pmullw pmullw() => default;

        [MethodImpl(Inline), Op]
        public Pmullw pmullw(AsmHexCode encoded) => new Pmullw(encoded);

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

        public Vpmullw vpmullw() => default;

        [MethodImpl(Inline), Op]
        public Vpmullw vpmullw(AsmHexCode encoded) => new Vpmullw(encoded);

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

        public Pmuludq pmuludq() => default;

        [MethodImpl(Inline), Op]
        public Pmuludq pmuludq(AsmHexCode encoded) => new Pmuludq(encoded);

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

        public Vpmuludq vpmuludq() => default;

        [MethodImpl(Inline), Op]
        public Vpmuludq vpmuludq(AsmHexCode encoded) => new Vpmuludq(encoded);

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

        public Pop pop() => default;

        [MethodImpl(Inline), Op]
        public Pop pop(AsmHexCode encoded) => new Pop(encoded);

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

        public Popa popa() => default;

        [MethodImpl(Inline), Op]
        public Popa popa(AsmHexCode encoded) => new Popa(encoded);

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

        public Popad popad() => default;

        [MethodImpl(Inline), Op]
        public Popad popad(AsmHexCode encoded) => new Popad(encoded);

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

        public Popcnt popcnt() => default;

        [MethodImpl(Inline), Op]
        public Popcnt popcnt(AsmHexCode encoded) => new Popcnt(encoded);

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

        public Popf popf() => default;

        [MethodImpl(Inline), Op]
        public Popf popf(AsmHexCode encoded) => new Popf(encoded);

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

        public Popfd popfd() => default;

        [MethodImpl(Inline), Op]
        public Popfd popfd(AsmHexCode encoded) => new Popfd(encoded);

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

        public Popfq popfq() => default;

        [MethodImpl(Inline), Op]
        public Popfq popfq(AsmHexCode encoded) => new Popfq(encoded);

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

        public Por por() => default;

        [MethodImpl(Inline), Op]
        public Por por(AsmHexCode encoded) => new Por(encoded);

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

        public Vpor vpor() => default;

        [MethodImpl(Inline), Op]
        public Vpor vpor(AsmHexCode encoded) => new Vpor(encoded);

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

        public Prefetcht0 prefetcht0() => default;

        [MethodImpl(Inline), Op]
        public Prefetcht0 prefetcht0(AsmHexCode encoded) => new Prefetcht0(encoded);

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

        public Prefetcht1 prefetcht1() => default;

        [MethodImpl(Inline), Op]
        public Prefetcht1 prefetcht1(AsmHexCode encoded) => new Prefetcht1(encoded);

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

        public Prefetcht2 prefetcht2() => default;

        [MethodImpl(Inline), Op]
        public Prefetcht2 prefetcht2(AsmHexCode encoded) => new Prefetcht2(encoded);

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

        public Prefetchnta prefetchnta() => default;

        [MethodImpl(Inline), Op]
        public Prefetchnta prefetchnta(AsmHexCode encoded) => new Prefetchnta(encoded);

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

        public Psadbw psadbw() => default;

        [MethodImpl(Inline), Op]
        public Psadbw psadbw(AsmHexCode encoded) => new Psadbw(encoded);

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

        public Vpsadbw vpsadbw() => default;

        [MethodImpl(Inline), Op]
        public Vpsadbw vpsadbw(AsmHexCode encoded) => new Vpsadbw(encoded);

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

        public Pshufb pshufb() => default;

        [MethodImpl(Inline), Op]
        public Pshufb pshufb(AsmHexCode encoded) => new Pshufb(encoded);

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

        public Vpshufb vpshufb() => default;

        [MethodImpl(Inline), Op]
        public Vpshufb vpshufb(AsmHexCode encoded) => new Vpshufb(encoded);

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

        public Pshufd pshufd() => default;

        [MethodImpl(Inline), Op]
        public Pshufd pshufd(AsmHexCode encoded) => new Pshufd(encoded);

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

        public Vpshufd vpshufd() => default;

        [MethodImpl(Inline), Op]
        public Vpshufd vpshufd(AsmHexCode encoded) => new Vpshufd(encoded);

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

        public Pshufhw pshufhw() => default;

        [MethodImpl(Inline), Op]
        public Pshufhw pshufhw(AsmHexCode encoded) => new Pshufhw(encoded);

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

        public Vpshufhw vpshufhw() => default;

        [MethodImpl(Inline), Op]
        public Vpshufhw vpshufhw(AsmHexCode encoded) => new Vpshufhw(encoded);

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

        public Pshuflw pshuflw() => default;

        [MethodImpl(Inline), Op]
        public Pshuflw pshuflw(AsmHexCode encoded) => new Pshuflw(encoded);

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

        public Vpshuflw vpshuflw() => default;

        [MethodImpl(Inline), Op]
        public Vpshuflw vpshuflw(AsmHexCode encoded) => new Vpshuflw(encoded);

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

        public Pshufw pshufw() => default;

        [MethodImpl(Inline), Op]
        public Pshufw pshufw(AsmHexCode encoded) => new Pshufw(encoded);

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

        public Psignb psignb() => default;

        [MethodImpl(Inline), Op]
        public Psignb psignb(AsmHexCode encoded) => new Psignb(encoded);

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

        public Psignw psignw() => default;

        [MethodImpl(Inline), Op]
        public Psignw psignw(AsmHexCode encoded) => new Psignw(encoded);

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

        public Psignd psignd() => default;

        [MethodImpl(Inline), Op]
        public Psignd psignd(AsmHexCode encoded) => new Psignd(encoded);

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

        public Vpsignb vpsignb() => default;

        [MethodImpl(Inline), Op]
        public Vpsignb vpsignb(AsmHexCode encoded) => new Vpsignb(encoded);

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

        public Vpsignw vpsignw() => default;

        [MethodImpl(Inline), Op]
        public Vpsignw vpsignw(AsmHexCode encoded) => new Vpsignw(encoded);

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

        public Vpsignd vpsignd() => default;

        [MethodImpl(Inline), Op]
        public Vpsignd vpsignd(AsmHexCode encoded) => new Vpsignd(encoded);

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

        public Pslldq pslldq() => default;

        [MethodImpl(Inline), Op]
        public Pslldq pslldq(AsmHexCode encoded) => new Pslldq(encoded);

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

        public Vpslldq vpslldq() => default;

        [MethodImpl(Inline), Op]
        public Vpslldq vpslldq(AsmHexCode encoded) => new Vpslldq(encoded);

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

        public Psllw psllw() => default;

        [MethodImpl(Inline), Op]
        public Psllw psllw(AsmHexCode encoded) => new Psllw(encoded);

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

        public Pslld pslld() => default;

        [MethodImpl(Inline), Op]
        public Pslld pslld(AsmHexCode encoded) => new Pslld(encoded);

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

        public Psllq psllq() => default;

        [MethodImpl(Inline), Op]
        public Psllq psllq(AsmHexCode encoded) => new Psllq(encoded);

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

        public Vpsllw vpsllw() => default;

        [MethodImpl(Inline), Op]
        public Vpsllw vpsllw(AsmHexCode encoded) => new Vpsllw(encoded);

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

        public Vpslld vpslld() => default;

        [MethodImpl(Inline), Op]
        public Vpslld vpslld(AsmHexCode encoded) => new Vpslld(encoded);

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

        public Vpsllq vpsllq() => default;

        [MethodImpl(Inline), Op]
        public Vpsllq vpsllq(AsmHexCode encoded) => new Vpsllq(encoded);

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

        public Psraw psraw() => default;

        [MethodImpl(Inline), Op]
        public Psraw psraw(AsmHexCode encoded) => new Psraw(encoded);

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

        public Psrad psrad() => default;

        [MethodImpl(Inline), Op]
        public Psrad psrad(AsmHexCode encoded) => new Psrad(encoded);

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

        public Vpsraw vpsraw() => default;

        [MethodImpl(Inline), Op]
        public Vpsraw vpsraw(AsmHexCode encoded) => new Vpsraw(encoded);

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

        public Vpsrad vpsrad() => default;

        [MethodImpl(Inline), Op]
        public Vpsrad vpsrad(AsmHexCode encoded) => new Vpsrad(encoded);

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

        public Psrldq psrldq() => default;

        [MethodImpl(Inline), Op]
        public Psrldq psrldq(AsmHexCode encoded) => new Psrldq(encoded);

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

        public Vpsrldq vpsrldq() => default;

        [MethodImpl(Inline), Op]
        public Vpsrldq vpsrldq(AsmHexCode encoded) => new Vpsrldq(encoded);

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

        public Psrlw psrlw() => default;

        [MethodImpl(Inline), Op]
        public Psrlw psrlw(AsmHexCode encoded) => new Psrlw(encoded);

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

        public Psrld psrld() => default;

        [MethodImpl(Inline), Op]
        public Psrld psrld(AsmHexCode encoded) => new Psrld(encoded);

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

        public Psrlq psrlq() => default;

        [MethodImpl(Inline), Op]
        public Psrlq psrlq(AsmHexCode encoded) => new Psrlq(encoded);

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

        public Vpsrlw vpsrlw() => default;

        [MethodImpl(Inline), Op]
        public Vpsrlw vpsrlw(AsmHexCode encoded) => new Vpsrlw(encoded);

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

        public Vpsrld vpsrld() => default;

        [MethodImpl(Inline), Op]
        public Vpsrld vpsrld(AsmHexCode encoded) => new Vpsrld(encoded);

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

        public Vpsrlq vpsrlq() => default;

        [MethodImpl(Inline), Op]
        public Vpsrlq vpsrlq(AsmHexCode encoded) => new Vpsrlq(encoded);

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

        public Psubb psubb() => default;

        [MethodImpl(Inline), Op]
        public Psubb psubb(AsmHexCode encoded) => new Psubb(encoded);

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

        public Psubw psubw() => default;

        [MethodImpl(Inline), Op]
        public Psubw psubw(AsmHexCode encoded) => new Psubw(encoded);

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

        public Psubd psubd() => default;

        [MethodImpl(Inline), Op]
        public Psubd psubd(AsmHexCode encoded) => new Psubd(encoded);

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

        public Vpsubb vpsubb() => default;

        [MethodImpl(Inline), Op]
        public Vpsubb vpsubb(AsmHexCode encoded) => new Vpsubb(encoded);

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

        public Vpsubw vpsubw() => default;

        [MethodImpl(Inline), Op]
        public Vpsubw vpsubw(AsmHexCode encoded) => new Vpsubw(encoded);

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

        public Vpsubd vpsubd() => default;

        [MethodImpl(Inline), Op]
        public Vpsubd vpsubd(AsmHexCode encoded) => new Vpsubd(encoded);

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

        public Psubq psubq() => default;

        [MethodImpl(Inline), Op]
        public Psubq psubq(AsmHexCode encoded) => new Psubq(encoded);

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

        public Vpsubq vpsubq() => default;

        [MethodImpl(Inline), Op]
        public Vpsubq vpsubq(AsmHexCode encoded) => new Vpsubq(encoded);

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

        public Psubsb psubsb() => default;

        [MethodImpl(Inline), Op]
        public Psubsb psubsb(AsmHexCode encoded) => new Psubsb(encoded);

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

        public Psubsw psubsw() => default;

        [MethodImpl(Inline), Op]
        public Psubsw psubsw(AsmHexCode encoded) => new Psubsw(encoded);

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

        public Vpsubsb vpsubsb() => default;

        [MethodImpl(Inline), Op]
        public Vpsubsb vpsubsb(AsmHexCode encoded) => new Vpsubsb(encoded);

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

        public Vpsubsw vpsubsw() => default;

        [MethodImpl(Inline), Op]
        public Vpsubsw vpsubsw(AsmHexCode encoded) => new Vpsubsw(encoded);

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

        public Psubusb psubusb() => default;

        [MethodImpl(Inline), Op]
        public Psubusb psubusb(AsmHexCode encoded) => new Psubusb(encoded);

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

        public Psubusw psubusw() => default;

        [MethodImpl(Inline), Op]
        public Psubusw psubusw(AsmHexCode encoded) => new Psubusw(encoded);

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

        public Vpsubusb vpsubusb() => default;

        [MethodImpl(Inline), Op]
        public Vpsubusb vpsubusb(AsmHexCode encoded) => new Vpsubusb(encoded);

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

        public Vpsubusw vpsubusw() => default;

        [MethodImpl(Inline), Op]
        public Vpsubusw vpsubusw(AsmHexCode encoded) => new Vpsubusw(encoded);

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

        public Ptest ptest() => default;

        [MethodImpl(Inline), Op]
        public Ptest ptest(AsmHexCode encoded) => new Ptest(encoded);

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

        public Vptest vptest() => default;

        [MethodImpl(Inline), Op]
        public Vptest vptest(AsmHexCode encoded) => new Vptest(encoded);

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

        public Punpckhbw punpckhbw() => default;

        [MethodImpl(Inline), Op]
        public Punpckhbw punpckhbw(AsmHexCode encoded) => new Punpckhbw(encoded);

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

        public Punpckhwd punpckhwd() => default;

        [MethodImpl(Inline), Op]
        public Punpckhwd punpckhwd(AsmHexCode encoded) => new Punpckhwd(encoded);

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

        public Punpckhdq punpckhdq() => default;

        [MethodImpl(Inline), Op]
        public Punpckhdq punpckhdq(AsmHexCode encoded) => new Punpckhdq(encoded);

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

        public Punpckhqdq punpckhqdq() => default;

        [MethodImpl(Inline), Op]
        public Punpckhqdq punpckhqdq(AsmHexCode encoded) => new Punpckhqdq(encoded);

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

        public Vpunpckhbw vpunpckhbw() => default;

        [MethodImpl(Inline), Op]
        public Vpunpckhbw vpunpckhbw(AsmHexCode encoded) => new Vpunpckhbw(encoded);

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

        public Vpunpckhwd vpunpckhwd() => default;

        [MethodImpl(Inline), Op]
        public Vpunpckhwd vpunpckhwd(AsmHexCode encoded) => new Vpunpckhwd(encoded);

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

        public Vpunpckhdq vpunpckhdq() => default;

        [MethodImpl(Inline), Op]
        public Vpunpckhdq vpunpckhdq(AsmHexCode encoded) => new Vpunpckhdq(encoded);

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

        public Vpunpckhqdq vpunpckhqdq() => default;

        [MethodImpl(Inline), Op]
        public Vpunpckhqdq vpunpckhqdq(AsmHexCode encoded) => new Vpunpckhqdq(encoded);

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

        public Punpcklbw punpcklbw() => default;

        [MethodImpl(Inline), Op]
        public Punpcklbw punpcklbw(AsmHexCode encoded) => new Punpcklbw(encoded);

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

        public Punpcklwd punpcklwd() => default;

        [MethodImpl(Inline), Op]
        public Punpcklwd punpcklwd(AsmHexCode encoded) => new Punpcklwd(encoded);

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

        public Punpckldq punpckldq() => default;

        [MethodImpl(Inline), Op]
        public Punpckldq punpckldq(AsmHexCode encoded) => new Punpckldq(encoded);

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

        public Punpcklqdq punpcklqdq() => default;

        [MethodImpl(Inline), Op]
        public Punpcklqdq punpcklqdq(AsmHexCode encoded) => new Punpcklqdq(encoded);

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

        public Vpunpcklbw vpunpcklbw() => default;

        [MethodImpl(Inline), Op]
        public Vpunpcklbw vpunpcklbw(AsmHexCode encoded) => new Vpunpcklbw(encoded);

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

        public Vpunpcklwd vpunpcklwd() => default;

        [MethodImpl(Inline), Op]
        public Vpunpcklwd vpunpcklwd(AsmHexCode encoded) => new Vpunpcklwd(encoded);

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

        public Vpunpckldq vpunpckldq() => default;

        [MethodImpl(Inline), Op]
        public Vpunpckldq vpunpckldq(AsmHexCode encoded) => new Vpunpckldq(encoded);

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

        public Vpunpcklqdq vpunpcklqdq() => default;

        [MethodImpl(Inline), Op]
        public Vpunpcklqdq vpunpcklqdq(AsmHexCode encoded) => new Vpunpcklqdq(encoded);

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

        public Push push() => default;

        [MethodImpl(Inline), Op]
        public Push push(AsmHexCode encoded) => new Push(encoded);

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

        public Pushq pushq() => default;

        [MethodImpl(Inline), Op]
        public Pushq pushq(AsmHexCode encoded) => new Pushq(encoded);

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

        public Pushw pushw() => default;

        [MethodImpl(Inline), Op]
        public Pushw pushw(AsmHexCode encoded) => new Pushw(encoded);

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

        public Pusha pusha() => default;

        [MethodImpl(Inline), Op]
        public Pusha pusha(AsmHexCode encoded) => new Pusha(encoded);

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

        public Pushad pushad() => default;

        [MethodImpl(Inline), Op]
        public Pushad pushad(AsmHexCode encoded) => new Pushad(encoded);

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

        public Pushf pushf() => default;

        [MethodImpl(Inline), Op]
        public Pushf pushf(AsmHexCode encoded) => new Pushf(encoded);

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

        public Pushfd pushfd() => default;

        [MethodImpl(Inline), Op]
        public Pushfd pushfd(AsmHexCode encoded) => new Pushfd(encoded);

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

        public Pushfq pushfq() => default;

        [MethodImpl(Inline), Op]
        public Pushfq pushfq(AsmHexCode encoded) => new Pushfq(encoded);

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

        public Pxor pxor() => default;

        [MethodImpl(Inline), Op]
        public Pxor pxor(AsmHexCode encoded) => new Pxor(encoded);

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

        public Vpxor vpxor() => default;

        [MethodImpl(Inline), Op]
        public Vpxor vpxor(AsmHexCode encoded) => new Vpxor(encoded);

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

        public Rcl rcl() => default;

        [MethodImpl(Inline), Op]
        public Rcl rcl(AsmHexCode encoded) => new Rcl(encoded);

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

        public Rcr rcr() => default;

        [MethodImpl(Inline), Op]
        public Rcr rcr(AsmHexCode encoded) => new Rcr(encoded);

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

        public Rol rol() => default;

        [MethodImpl(Inline), Op]
        public Rol rol(AsmHexCode encoded) => new Rol(encoded);

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

        public Ror ror() => default;

        [MethodImpl(Inline), Op]
        public Ror ror(AsmHexCode encoded) => new Ror(encoded);

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

        public Rcpps rcpps() => default;

        [MethodImpl(Inline), Op]
        public Rcpps rcpps(AsmHexCode encoded) => new Rcpps(encoded);

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

        public Vrcpps vrcpps() => default;

        [MethodImpl(Inline), Op]
        public Vrcpps vrcpps(AsmHexCode encoded) => new Vrcpps(encoded);

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

        public Rcpss rcpss() => default;

        [MethodImpl(Inline), Op]
        public Rcpss rcpss(AsmHexCode encoded) => new Rcpss(encoded);

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

        public Vrcpss vrcpss() => default;

        [MethodImpl(Inline), Op]
        public Vrcpss vrcpss(AsmHexCode encoded) => new Vrcpss(encoded);

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

        public Rdfsbase rdfsbase() => default;

        [MethodImpl(Inline), Op]
        public Rdfsbase rdfsbase(AsmHexCode encoded) => new Rdfsbase(encoded);

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

        public Rdgsbase rdgsbase() => default;

        [MethodImpl(Inline), Op]
        public Rdgsbase rdgsbase(AsmHexCode encoded) => new Rdgsbase(encoded);

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

        public Rdmsr rdmsr() => default;

        [MethodImpl(Inline), Op]
        public Rdmsr rdmsr(AsmHexCode encoded) => new Rdmsr(encoded);

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

        public Rdpmc rdpmc() => default;

        [MethodImpl(Inline), Op]
        public Rdpmc rdpmc(AsmHexCode encoded) => new Rdpmc(encoded);

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

        public Rdrand rdrand() => default;

        [MethodImpl(Inline), Op]
        public Rdrand rdrand(AsmHexCode encoded) => new Rdrand(encoded);

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

        public Rdtsc rdtsc() => default;

        [MethodImpl(Inline), Op]
        public Rdtsc rdtsc(AsmHexCode encoded) => new Rdtsc(encoded);

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

        public Rdtscp rdtscp() => default;

        [MethodImpl(Inline), Op]
        public Rdtscp rdtscp(AsmHexCode encoded) => new Rdtscp(encoded);

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

        public Rep_ins rep_ins() => default;

        [MethodImpl(Inline), Op]
        public Rep_ins rep_ins(AsmHexCode encoded) => new Rep_ins(encoded);

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

        public Rep_movs rep_movs() => default;

        [MethodImpl(Inline), Op]
        public Rep_movs rep_movs(AsmHexCode encoded) => new Rep_movs(encoded);

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

        public Rep_outs rep_outs() => default;

        [MethodImpl(Inline), Op]
        public Rep_outs rep_outs(AsmHexCode encoded) => new Rep_outs(encoded);

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

        public Rep_lods rep_lods() => default;

        [MethodImpl(Inline), Op]
        public Rep_lods rep_lods(AsmHexCode encoded) => new Rep_lods(encoded);

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

        public Rep_stos rep_stos() => default;

        [MethodImpl(Inline), Op]
        public Rep_stos rep_stos(AsmHexCode encoded) => new Rep_stos(encoded);

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

        public Repe_cmps repe_cmps() => default;

        [MethodImpl(Inline), Op]
        public Repe_cmps repe_cmps(AsmHexCode encoded) => new Repe_cmps(encoded);

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

        public Repe_scas repe_scas() => default;

        [MethodImpl(Inline), Op]
        public Repe_scas repe_scas(AsmHexCode encoded) => new Repe_scas(encoded);

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

        public Repne_cmps repne_cmps() => default;

        [MethodImpl(Inline), Op]
        public Repne_cmps repne_cmps(AsmHexCode encoded) => new Repne_cmps(encoded);

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

        public Repne_scas repne_scas() => default;

        [MethodImpl(Inline), Op]
        public Repne_scas repne_scas(AsmHexCode encoded) => new Repne_scas(encoded);

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

        public Ret ret() => default;

        [MethodImpl(Inline), Op]
        public Ret ret(AsmHexCode encoded) => new Ret(encoded);

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

        public Rorx rorx() => default;

        [MethodImpl(Inline), Op]
        public Rorx rorx(AsmHexCode encoded) => new Rorx(encoded);

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

        public Roundpd roundpd() => default;

        [MethodImpl(Inline), Op]
        public Roundpd roundpd(AsmHexCode encoded) => new Roundpd(encoded);

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

        public Vroundpd vroundpd() => default;

        [MethodImpl(Inline), Op]
        public Vroundpd vroundpd(AsmHexCode encoded) => new Vroundpd(encoded);

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

        public Roundps roundps() => default;

        [MethodImpl(Inline), Op]
        public Roundps roundps(AsmHexCode encoded) => new Roundps(encoded);

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

        public Vroundps vroundps() => default;

        [MethodImpl(Inline), Op]
        public Vroundps vroundps(AsmHexCode encoded) => new Vroundps(encoded);

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

        public Roundsd roundsd() => default;

        [MethodImpl(Inline), Op]
        public Roundsd roundsd(AsmHexCode encoded) => new Roundsd(encoded);

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

        public Vroundsd vroundsd() => default;

        [MethodImpl(Inline), Op]
        public Vroundsd vroundsd(AsmHexCode encoded) => new Vroundsd(encoded);

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

        public Roundss roundss() => default;

        [MethodImpl(Inline), Op]
        public Roundss roundss(AsmHexCode encoded) => new Roundss(encoded);

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

        public Vroundss vroundss() => default;

        [MethodImpl(Inline), Op]
        public Vroundss vroundss(AsmHexCode encoded) => new Vroundss(encoded);

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

        public Rsm rsm() => default;

        [MethodImpl(Inline), Op]
        public Rsm rsm(AsmHexCode encoded) => new Rsm(encoded);

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

        public Rsqrtps rsqrtps() => default;

        [MethodImpl(Inline), Op]
        public Rsqrtps rsqrtps(AsmHexCode encoded) => new Rsqrtps(encoded);

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

        public Vrsqrtps vrsqrtps() => default;

        [MethodImpl(Inline), Op]
        public Vrsqrtps vrsqrtps(AsmHexCode encoded) => new Vrsqrtps(encoded);

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

        public Rsqrtss rsqrtss() => default;

        [MethodImpl(Inline), Op]
        public Rsqrtss rsqrtss(AsmHexCode encoded) => new Rsqrtss(encoded);

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

        public Vrsqrtss vrsqrtss() => default;

        [MethodImpl(Inline), Op]
        public Vrsqrtss vrsqrtss(AsmHexCode encoded) => new Vrsqrtss(encoded);

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

        public Sahf sahf() => default;

        [MethodImpl(Inline), Op]
        public Sahf sahf(AsmHexCode encoded) => new Sahf(encoded);

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

        public Sal sal() => default;

        [MethodImpl(Inline), Op]
        public Sal sal(AsmHexCode encoded) => new Sal(encoded);

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

        public Sar sar() => default;

        [MethodImpl(Inline), Op]
        public Sar sar(AsmHexCode encoded) => new Sar(encoded);

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

        public Shl shl() => default;

        [MethodImpl(Inline), Op]
        public Shl shl(AsmHexCode encoded) => new Shl(encoded);

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

        public Shr shr() => default;

        [MethodImpl(Inline), Op]
        public Shr shr(AsmHexCode encoded) => new Shr(encoded);

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

        public Sarx sarx() => default;

        [MethodImpl(Inline), Op]
        public Sarx sarx(AsmHexCode encoded) => new Sarx(encoded);

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

        public Shlx shlx() => default;

        [MethodImpl(Inline), Op]
        public Shlx shlx(AsmHexCode encoded) => new Shlx(encoded);

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

        public Shrx shrx() => default;

        [MethodImpl(Inline), Op]
        public Shrx shrx(AsmHexCode encoded) => new Shrx(encoded);

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

        public Sbb sbb() => default;

        [MethodImpl(Inline), Op]
        public Sbb sbb(AsmHexCode encoded) => new Sbb(encoded);

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

        public Scas scas() => default;

        [MethodImpl(Inline), Op]
        public Scas scas(AsmHexCode encoded) => new Scas(encoded);

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

        public Scasb scasb() => default;

        [MethodImpl(Inline), Op]
        public Scasb scasb(AsmHexCode encoded) => new Scasb(encoded);

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

        public Scasw scasw() => default;

        [MethodImpl(Inline), Op]
        public Scasw scasw(AsmHexCode encoded) => new Scasw(encoded);

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

        public Scasd scasd() => default;

        [MethodImpl(Inline), Op]
        public Scasd scasd(AsmHexCode encoded) => new Scasd(encoded);

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

        public Scasq scasq() => default;

        [MethodImpl(Inline), Op]
        public Scasq scasq(AsmHexCode encoded) => new Scasq(encoded);

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

        public Seta seta() => default;

        [MethodImpl(Inline), Op]
        public Seta seta(AsmHexCode encoded) => new Seta(encoded);

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

        public Setae setae() => default;

        [MethodImpl(Inline), Op]
        public Setae setae(AsmHexCode encoded) => new Setae(encoded);

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

        public Setb setb() => default;

        [MethodImpl(Inline), Op]
        public Setb setb(AsmHexCode encoded) => new Setb(encoded);

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

        public Setbe setbe() => default;

        [MethodImpl(Inline), Op]
        public Setbe setbe(AsmHexCode encoded) => new Setbe(encoded);

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

        public Setc setc() => default;

        [MethodImpl(Inline), Op]
        public Setc setc(AsmHexCode encoded) => new Setc(encoded);

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

        public Sete sete() => default;

        [MethodImpl(Inline), Op]
        public Sete sete(AsmHexCode encoded) => new Sete(encoded);

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

        public Setg setg() => default;

        [MethodImpl(Inline), Op]
        public Setg setg(AsmHexCode encoded) => new Setg(encoded);

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

        public Setge setge() => default;

        [MethodImpl(Inline), Op]
        public Setge setge(AsmHexCode encoded) => new Setge(encoded);

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

        public Setl setl() => default;

        [MethodImpl(Inline), Op]
        public Setl setl(AsmHexCode encoded) => new Setl(encoded);

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

        public Setle setle() => default;

        [MethodImpl(Inline), Op]
        public Setle setle(AsmHexCode encoded) => new Setle(encoded);

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

        public Setna setna() => default;

        [MethodImpl(Inline), Op]
        public Setna setna(AsmHexCode encoded) => new Setna(encoded);

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

        public Setnae setnae() => default;

        [MethodImpl(Inline), Op]
        public Setnae setnae(AsmHexCode encoded) => new Setnae(encoded);

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

        public Setnb setnb() => default;

        [MethodImpl(Inline), Op]
        public Setnb setnb(AsmHexCode encoded) => new Setnb(encoded);

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

        public Setnbe setnbe() => default;

        [MethodImpl(Inline), Op]
        public Setnbe setnbe(AsmHexCode encoded) => new Setnbe(encoded);

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

        public Setnc setnc() => default;

        [MethodImpl(Inline), Op]
        public Setnc setnc(AsmHexCode encoded) => new Setnc(encoded);

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

        public Setne setne() => default;

        [MethodImpl(Inline), Op]
        public Setne setne(AsmHexCode encoded) => new Setne(encoded);

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

        public Setng setng() => default;

        [MethodImpl(Inline), Op]
        public Setng setng(AsmHexCode encoded) => new Setng(encoded);

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

        public Setnge setnge() => default;

        [MethodImpl(Inline), Op]
        public Setnge setnge(AsmHexCode encoded) => new Setnge(encoded);

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

        public Setnl setnl() => default;

        [MethodImpl(Inline), Op]
        public Setnl setnl(AsmHexCode encoded) => new Setnl(encoded);

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

        public Setnle setnle() => default;

        [MethodImpl(Inline), Op]
        public Setnle setnle(AsmHexCode encoded) => new Setnle(encoded);

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

        public Setno setno() => default;

        [MethodImpl(Inline), Op]
        public Setno setno(AsmHexCode encoded) => new Setno(encoded);

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

        public Setnp setnp() => default;

        [MethodImpl(Inline), Op]
        public Setnp setnp(AsmHexCode encoded) => new Setnp(encoded);

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

        public Setns setns() => default;

        [MethodImpl(Inline), Op]
        public Setns setns(AsmHexCode encoded) => new Setns(encoded);

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

        public Setnz setnz() => default;

        [MethodImpl(Inline), Op]
        public Setnz setnz(AsmHexCode encoded) => new Setnz(encoded);

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

        public Seto seto() => default;

        [MethodImpl(Inline), Op]
        public Seto seto(AsmHexCode encoded) => new Seto(encoded);

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

        public Setp setp() => default;

        [MethodImpl(Inline), Op]
        public Setp setp(AsmHexCode encoded) => new Setp(encoded);

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

        public Setpe setpe() => default;

        [MethodImpl(Inline), Op]
        public Setpe setpe(AsmHexCode encoded) => new Setpe(encoded);

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

        public Setpo setpo() => default;

        [MethodImpl(Inline), Op]
        public Setpo setpo(AsmHexCode encoded) => new Setpo(encoded);

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

        public Sets sets() => default;

        [MethodImpl(Inline), Op]
        public Sets sets(AsmHexCode encoded) => new Sets(encoded);

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

        public Setz setz() => default;

        [MethodImpl(Inline), Op]
        public Setz setz(AsmHexCode encoded) => new Setz(encoded);

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

        public Sfence sfence() => default;

        [MethodImpl(Inline), Op]
        public Sfence sfence(AsmHexCode encoded) => new Sfence(encoded);

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

        public Sgdt sgdt() => default;

        [MethodImpl(Inline), Op]
        public Sgdt sgdt(AsmHexCode encoded) => new Sgdt(encoded);

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

        public Shld shld() => default;

        [MethodImpl(Inline), Op]
        public Shld shld(AsmHexCode encoded) => new Shld(encoded);

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

        public Shrd shrd() => default;

        [MethodImpl(Inline), Op]
        public Shrd shrd(AsmHexCode encoded) => new Shrd(encoded);

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

        public Shufpd shufpd() => default;

        [MethodImpl(Inline), Op]
        public Shufpd shufpd(AsmHexCode encoded) => new Shufpd(encoded);

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

        public Vshufpd vshufpd() => default;

        [MethodImpl(Inline), Op]
        public Vshufpd vshufpd(AsmHexCode encoded) => new Vshufpd(encoded);

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

        public Shufps shufps() => default;

        [MethodImpl(Inline), Op]
        public Shufps shufps(AsmHexCode encoded) => new Shufps(encoded);

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

        public Vshufps vshufps() => default;

        [MethodImpl(Inline), Op]
        public Vshufps vshufps(AsmHexCode encoded) => new Vshufps(encoded);

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

        public Sidt sidt() => default;

        [MethodImpl(Inline), Op]
        public Sidt sidt(AsmHexCode encoded) => new Sidt(encoded);

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

        public Sldt sldt() => default;

        [MethodImpl(Inline), Op]
        public Sldt sldt(AsmHexCode encoded) => new Sldt(encoded);

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

        public Smsw smsw() => default;

        [MethodImpl(Inline), Op]
        public Smsw smsw(AsmHexCode encoded) => new Smsw(encoded);

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

        public Sqrtpd sqrtpd() => default;

        [MethodImpl(Inline), Op]
        public Sqrtpd sqrtpd(AsmHexCode encoded) => new Sqrtpd(encoded);

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

        public Vsqrtpd vsqrtpd() => default;

        [MethodImpl(Inline), Op]
        public Vsqrtpd vsqrtpd(AsmHexCode encoded) => new Vsqrtpd(encoded);

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

        public Sqrtps sqrtps() => default;

        [MethodImpl(Inline), Op]
        public Sqrtps sqrtps(AsmHexCode encoded) => new Sqrtps(encoded);

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

        public Vsqrtps vsqrtps() => default;

        [MethodImpl(Inline), Op]
        public Vsqrtps vsqrtps(AsmHexCode encoded) => new Vsqrtps(encoded);

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

        public Sqrtsd sqrtsd() => default;

        [MethodImpl(Inline), Op]
        public Sqrtsd sqrtsd(AsmHexCode encoded) => new Sqrtsd(encoded);

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

        public Vsqrtsd vsqrtsd() => default;

        [MethodImpl(Inline), Op]
        public Vsqrtsd vsqrtsd(AsmHexCode encoded) => new Vsqrtsd(encoded);

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

        public Sqrtss sqrtss() => default;

        [MethodImpl(Inline), Op]
        public Sqrtss sqrtss(AsmHexCode encoded) => new Sqrtss(encoded);

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

        public Vsqrtss vsqrtss() => default;

        [MethodImpl(Inline), Op]
        public Vsqrtss vsqrtss(AsmHexCode encoded) => new Vsqrtss(encoded);

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

        public Stc stc() => default;

        [MethodImpl(Inline), Op]
        public Stc stc(AsmHexCode encoded) => new Stc(encoded);

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

        public Std std() => default;

        [MethodImpl(Inline), Op]
        public Std std(AsmHexCode encoded) => new Std(encoded);

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

        public Sti sti() => default;

        [MethodImpl(Inline), Op]
        public Sti sti(AsmHexCode encoded) => new Sti(encoded);

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

        public Stmxcsr stmxcsr() => default;

        [MethodImpl(Inline), Op]
        public Stmxcsr stmxcsr(AsmHexCode encoded) => new Stmxcsr(encoded);

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

        public Vstmxcsr vstmxcsr() => default;

        [MethodImpl(Inline), Op]
        public Vstmxcsr vstmxcsr(AsmHexCode encoded) => new Vstmxcsr(encoded);

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

        public Stos stos() => default;

        [MethodImpl(Inline), Op]
        public Stos stos(AsmHexCode encoded) => new Stos(encoded);

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

        public Stosb stosb() => default;

        [MethodImpl(Inline), Op]
        public Stosb stosb(AsmHexCode encoded) => new Stosb(encoded);

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

        public Stosw stosw() => default;

        [MethodImpl(Inline), Op]
        public Stosw stosw(AsmHexCode encoded) => new Stosw(encoded);

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

        public Stosd stosd() => default;

        [MethodImpl(Inline), Op]
        public Stosd stosd(AsmHexCode encoded) => new Stosd(encoded);

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

        public Stosq stosq() => default;

        [MethodImpl(Inline), Op]
        public Stosq stosq(AsmHexCode encoded) => new Stosq(encoded);

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

        public Str str() => default;

        [MethodImpl(Inline), Op]
        public Str str(AsmHexCode encoded) => new Str(encoded);

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

        public Sub sub() => default;

        [MethodImpl(Inline), Op]
        public Sub sub(AsmHexCode encoded) => new Sub(encoded);

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

        public Subpd subpd() => default;

        [MethodImpl(Inline), Op]
        public Subpd subpd(AsmHexCode encoded) => new Subpd(encoded);

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

        public Vsubpd vsubpd() => default;

        [MethodImpl(Inline), Op]
        public Vsubpd vsubpd(AsmHexCode encoded) => new Vsubpd(encoded);

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

        public Subps subps() => default;

        [MethodImpl(Inline), Op]
        public Subps subps(AsmHexCode encoded) => new Subps(encoded);

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

        public Vsubps vsubps() => default;

        [MethodImpl(Inline), Op]
        public Vsubps vsubps(AsmHexCode encoded) => new Vsubps(encoded);

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

        public Subsd subsd() => default;

        [MethodImpl(Inline), Op]
        public Subsd subsd(AsmHexCode encoded) => new Subsd(encoded);

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

        public Vsubsd vsubsd() => default;

        [MethodImpl(Inline), Op]
        public Vsubsd vsubsd(AsmHexCode encoded) => new Vsubsd(encoded);

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

        public Subss subss() => default;

        [MethodImpl(Inline), Op]
        public Subss subss(AsmHexCode encoded) => new Subss(encoded);

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

        public Vsubss vsubss() => default;

        [MethodImpl(Inline), Op]
        public Vsubss vsubss(AsmHexCode encoded) => new Vsubss(encoded);

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

        public Swapgs swapgs() => default;

        [MethodImpl(Inline), Op]
        public Swapgs swapgs(AsmHexCode encoded) => new Swapgs(encoded);

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

        public Syscall syscall() => default;

        [MethodImpl(Inline), Op]
        public Syscall syscall(AsmHexCode encoded) => new Syscall(encoded);

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

        public Sysenter sysenter() => default;

        [MethodImpl(Inline), Op]
        public Sysenter sysenter(AsmHexCode encoded) => new Sysenter(encoded);

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

        public Sysexit sysexit() => default;

        [MethodImpl(Inline), Op]
        public Sysexit sysexit(AsmHexCode encoded) => new Sysexit(encoded);

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

        public Sysret sysret() => default;

        [MethodImpl(Inline), Op]
        public Sysret sysret(AsmHexCode encoded) => new Sysret(encoded);

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

        public Test test() => default;

        [MethodImpl(Inline), Op]
        public Test test(AsmHexCode encoded) => new Test(encoded);

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

        public Tzcnt tzcnt() => default;

        [MethodImpl(Inline), Op]
        public Tzcnt tzcnt(AsmHexCode encoded) => new Tzcnt(encoded);

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

        public Ucomisd ucomisd() => default;

        [MethodImpl(Inline), Op]
        public Ucomisd ucomisd(AsmHexCode encoded) => new Ucomisd(encoded);

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

        public Vucomisd vucomisd() => default;

        [MethodImpl(Inline), Op]
        public Vucomisd vucomisd(AsmHexCode encoded) => new Vucomisd(encoded);

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

        public Ucomiss ucomiss() => default;

        [MethodImpl(Inline), Op]
        public Ucomiss ucomiss(AsmHexCode encoded) => new Ucomiss(encoded);

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

        public Vucomiss vucomiss() => default;

        [MethodImpl(Inline), Op]
        public Vucomiss vucomiss(AsmHexCode encoded) => new Vucomiss(encoded);

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

        public Ud2 ud2() => default;

        [MethodImpl(Inline), Op]
        public Ud2 ud2(AsmHexCode encoded) => new Ud2(encoded);

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

        public Unpckhpd unpckhpd() => default;

        [MethodImpl(Inline), Op]
        public Unpckhpd unpckhpd(AsmHexCode encoded) => new Unpckhpd(encoded);

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

        public Vunpckhpd vunpckhpd() => default;

        [MethodImpl(Inline), Op]
        public Vunpckhpd vunpckhpd(AsmHexCode encoded) => new Vunpckhpd(encoded);

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

        public Unpckhps unpckhps() => default;

        [MethodImpl(Inline), Op]
        public Unpckhps unpckhps(AsmHexCode encoded) => new Unpckhps(encoded);

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

        public Vunpckhps vunpckhps() => default;

        [MethodImpl(Inline), Op]
        public Vunpckhps vunpckhps(AsmHexCode encoded) => new Vunpckhps(encoded);

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

        public Unpcklpd unpcklpd() => default;

        [MethodImpl(Inline), Op]
        public Unpcklpd unpcklpd(AsmHexCode encoded) => new Unpcklpd(encoded);

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

        public Vunpcklpd vunpcklpd() => default;

        [MethodImpl(Inline), Op]
        public Vunpcklpd vunpcklpd(AsmHexCode encoded) => new Vunpcklpd(encoded);

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

        public Unpcklps unpcklps() => default;

        [MethodImpl(Inline), Op]
        public Unpcklps unpcklps(AsmHexCode encoded) => new Unpcklps(encoded);

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

        public Vunpcklps vunpcklps() => default;

        [MethodImpl(Inline), Op]
        public Vunpcklps vunpcklps(AsmHexCode encoded) => new Vunpcklps(encoded);

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

        public Vbroadcastss vbroadcastss() => default;

        [MethodImpl(Inline), Op]
        public Vbroadcastss vbroadcastss(AsmHexCode encoded) => new Vbroadcastss(encoded);

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

        public Vbroadcastsd vbroadcastsd() => default;

        [MethodImpl(Inline), Op]
        public Vbroadcastsd vbroadcastsd(AsmHexCode encoded) => new Vbroadcastsd(encoded);

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

        public Vbroadcastf128 vbroadcastf128() => default;

        [MethodImpl(Inline), Op]
        public Vbroadcastf128 vbroadcastf128(AsmHexCode encoded) => new Vbroadcastf128(encoded);

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

        public Vcvtph2ps vcvtph2ps() => default;

        [MethodImpl(Inline), Op]
        public Vcvtph2ps vcvtph2ps(AsmHexCode encoded) => new Vcvtph2ps(encoded);

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

        public Vcvtps2ph vcvtps2ph() => default;

        [MethodImpl(Inline), Op]
        public Vcvtps2ph vcvtps2ph(AsmHexCode encoded) => new Vcvtps2ph(encoded);

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

        public Verr verr() => default;

        [MethodImpl(Inline), Op]
        public Verr verr(AsmHexCode encoded) => new Verr(encoded);

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

        public Verw verw() => default;

        [MethodImpl(Inline), Op]
        public Verw verw(AsmHexCode encoded) => new Verw(encoded);

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

        public Vextractf128 vextractf128() => default;

        [MethodImpl(Inline), Op]
        public Vextractf128 vextractf128(AsmHexCode encoded) => new Vextractf128(encoded);

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

        public Vextracti128 vextracti128() => default;

        [MethodImpl(Inline), Op]
        public Vextracti128 vextracti128(AsmHexCode encoded) => new Vextracti128(encoded);

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

        public Vfmadd132pd vfmadd132pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd132pd vfmadd132pd(AsmHexCode encoded) => new Vfmadd132pd(encoded);

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

        public Vfmadd213pd vfmadd213pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd213pd vfmadd213pd(AsmHexCode encoded) => new Vfmadd213pd(encoded);

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

        public Vfmadd231pd vfmadd231pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd231pd vfmadd231pd(AsmHexCode encoded) => new Vfmadd231pd(encoded);

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

        public Vfmadd132ps vfmadd132ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd132ps vfmadd132ps(AsmHexCode encoded) => new Vfmadd132ps(encoded);

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

        public Vfmadd213ps vfmadd213ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd213ps vfmadd213ps(AsmHexCode encoded) => new Vfmadd213ps(encoded);

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

        public Vfmadd231ps vfmadd231ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd231ps vfmadd231ps(AsmHexCode encoded) => new Vfmadd231ps(encoded);

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

        public Vfmadd132sd vfmadd132sd() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd132sd vfmadd132sd(AsmHexCode encoded) => new Vfmadd132sd(encoded);

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

        public Vfmadd213sd vfmadd213sd() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd213sd vfmadd213sd(AsmHexCode encoded) => new Vfmadd213sd(encoded);

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

        public Vfmadd231sd vfmadd231sd() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd231sd vfmadd231sd(AsmHexCode encoded) => new Vfmadd231sd(encoded);

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

        public Vfmadd132ss vfmadd132ss() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd132ss vfmadd132ss(AsmHexCode encoded) => new Vfmadd132ss(encoded);

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

        public Vfmadd213ss vfmadd213ss() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd213ss vfmadd213ss(AsmHexCode encoded) => new Vfmadd213ss(encoded);

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

        public Vfmadd231ss vfmadd231ss() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd231ss vfmadd231ss(AsmHexCode encoded) => new Vfmadd231ss(encoded);

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

        public Vfmaddsub132pd vfmaddsub132pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmaddsub132pd vfmaddsub132pd(AsmHexCode encoded) => new Vfmaddsub132pd(encoded);

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

        public Vfmaddsub213pd vfmaddsub213pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmaddsub213pd vfmaddsub213pd(AsmHexCode encoded) => new Vfmaddsub213pd(encoded);

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

        public Vfmaddsub231pd vfmaddsub231pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmaddsub231pd vfmaddsub231pd(AsmHexCode encoded) => new Vfmaddsub231pd(encoded);

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

        public Vfmaddsub132ps vfmaddsub132ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmaddsub132ps vfmaddsub132ps(AsmHexCode encoded) => new Vfmaddsub132ps(encoded);

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

        public Vfmaddsub213ps vfmaddsub213ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmaddsub213ps vfmaddsub213ps(AsmHexCode encoded) => new Vfmaddsub213ps(encoded);

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

        public Vfmaddsub231ps vfmaddsub231ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmaddsub231ps vfmaddsub231ps(AsmHexCode encoded) => new Vfmaddsub231ps(encoded);

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

        public Vfmsubadd132pd vfmsubadd132pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsubadd132pd vfmsubadd132pd(AsmHexCode encoded) => new Vfmsubadd132pd(encoded);

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

        public Vfmsubadd213pd vfmsubadd213pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsubadd213pd vfmsubadd213pd(AsmHexCode encoded) => new Vfmsubadd213pd(encoded);

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

        public Vfmsubadd231pd vfmsubadd231pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsubadd231pd vfmsubadd231pd(AsmHexCode encoded) => new Vfmsubadd231pd(encoded);

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

        public Vfmsubadd132ps vfmsubadd132ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmsubadd132ps vfmsubadd132ps(AsmHexCode encoded) => new Vfmsubadd132ps(encoded);

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

        public Vfmsubadd213ps vfmsubadd213ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmsubadd213ps vfmsubadd213ps(AsmHexCode encoded) => new Vfmsubadd213ps(encoded);

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

        public Vfmsubadd231ps vfmsubadd231ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmsubadd231ps vfmsubadd231ps(AsmHexCode encoded) => new Vfmsubadd231ps(encoded);

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

        public Vfmsub132pd vfmsub132pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub132pd vfmsub132pd(AsmHexCode encoded) => new Vfmsub132pd(encoded);

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

        public Vfmsub213pd vfmsub213pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub213pd vfmsub213pd(AsmHexCode encoded) => new Vfmsub213pd(encoded);

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

        public Vfmsub231pd vfmsub231pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub231pd vfmsub231pd(AsmHexCode encoded) => new Vfmsub231pd(encoded);

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

        public Vfmsub132ps vfmsub132ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub132ps vfmsub132ps(AsmHexCode encoded) => new Vfmsub132ps(encoded);

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

        public Vfmsub213ps vfmsub213ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub213ps vfmsub213ps(AsmHexCode encoded) => new Vfmsub213ps(encoded);

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

        public Vfmsub231ps vfmsub231ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub231ps vfmsub231ps(AsmHexCode encoded) => new Vfmsub231ps(encoded);

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

        public Vfmsub132sd vfmsub132sd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub132sd vfmsub132sd(AsmHexCode encoded) => new Vfmsub132sd(encoded);

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

        public Vfmsub213sd vfmsub213sd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub213sd vfmsub213sd(AsmHexCode encoded) => new Vfmsub213sd(encoded);

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

        public Vfmsub231sd vfmsub231sd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub231sd vfmsub231sd(AsmHexCode encoded) => new Vfmsub231sd(encoded);

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

        public Vfmsub132ss vfmsub132ss() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub132ss vfmsub132ss(AsmHexCode encoded) => new Vfmsub132ss(encoded);

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

        public Vfmsub213ss vfmsub213ss() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub213ss vfmsub213ss(AsmHexCode encoded) => new Vfmsub213ss(encoded);

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

        public Vfmsub231ss vfmsub231ss() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub231ss vfmsub231ss(AsmHexCode encoded) => new Vfmsub231ss(encoded);

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

        public Vfnmadd132pd vfnmadd132pd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd132pd vfnmadd132pd(AsmHexCode encoded) => new Vfnmadd132pd(encoded);

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

        public Vfnmadd213pd vfnmadd213pd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd213pd vfnmadd213pd(AsmHexCode encoded) => new Vfnmadd213pd(encoded);

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

        public Vfnmadd231pd vfnmadd231pd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd231pd vfnmadd231pd(AsmHexCode encoded) => new Vfnmadd231pd(encoded);

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

        public Vfnmadd132ps vfnmadd132ps() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd132ps vfnmadd132ps(AsmHexCode encoded) => new Vfnmadd132ps(encoded);

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

        public Vfnmadd213ps vfnmadd213ps() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd213ps vfnmadd213ps(AsmHexCode encoded) => new Vfnmadd213ps(encoded);

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

        public Vfnmadd231ps vfnmadd231ps() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd231ps vfnmadd231ps(AsmHexCode encoded) => new Vfnmadd231ps(encoded);

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

        public Vfnmadd132sd vfnmadd132sd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd132sd vfnmadd132sd(AsmHexCode encoded) => new Vfnmadd132sd(encoded);

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

        public Vfnmadd213sd vfnmadd213sd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd213sd vfnmadd213sd(AsmHexCode encoded) => new Vfnmadd213sd(encoded);

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

        public Vfnmadd231sd vfnmadd231sd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd231sd vfnmadd231sd(AsmHexCode encoded) => new Vfnmadd231sd(encoded);

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

        public Vfnmadd132ss vfnmadd132ss() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd132ss vfnmadd132ss(AsmHexCode encoded) => new Vfnmadd132ss(encoded);

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

        public Vfnmadd213ss vfnmadd213ss() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd213ss vfnmadd213ss(AsmHexCode encoded) => new Vfnmadd213ss(encoded);

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

        public Vfnmadd231ss vfnmadd231ss() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd231ss vfnmadd231ss(AsmHexCode encoded) => new Vfnmadd231ss(encoded);

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

        public Vfnmsub132pd vfnmsub132pd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub132pd vfnmsub132pd(AsmHexCode encoded) => new Vfnmsub132pd(encoded);

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

        public Vfnmsub213pd vfnmsub213pd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub213pd vfnmsub213pd(AsmHexCode encoded) => new Vfnmsub213pd(encoded);

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

        public Vfnmsub231pd vfnmsub231pd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub231pd vfnmsub231pd(AsmHexCode encoded) => new Vfnmsub231pd(encoded);

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

        public Vfnmsub132ps vfnmsub132ps() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub132ps vfnmsub132ps(AsmHexCode encoded) => new Vfnmsub132ps(encoded);

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

        public Vfnmsub213ps vfnmsub213ps() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub213ps vfnmsub213ps(AsmHexCode encoded) => new Vfnmsub213ps(encoded);

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

        public Vfnmsub231ps vfnmsub231ps() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub231ps vfnmsub231ps(AsmHexCode encoded) => new Vfnmsub231ps(encoded);

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

        public Vfnmsub132sd vfnmsub132sd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub132sd vfnmsub132sd(AsmHexCode encoded) => new Vfnmsub132sd(encoded);

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

        public Vfnmsub213sd vfnmsub213sd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub213sd vfnmsub213sd(AsmHexCode encoded) => new Vfnmsub213sd(encoded);

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

        public Vfnmsub231sd vfnmsub231sd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub231sd vfnmsub231sd(AsmHexCode encoded) => new Vfnmsub231sd(encoded);

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

        public Vfnmsub132ss vfnmsub132ss() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub132ss vfnmsub132ss(AsmHexCode encoded) => new Vfnmsub132ss(encoded);

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

        public Vfnmsub213ss vfnmsub213ss() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub213ss vfnmsub213ss(AsmHexCode encoded) => new Vfnmsub213ss(encoded);

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

        public Vfnmsub231ss vfnmsub231ss() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub231ss vfnmsub231ss(AsmHexCode encoded) => new Vfnmsub231ss(encoded);

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

        public Vgatherdpd vgatherdpd() => default;

        [MethodImpl(Inline), Op]
        public Vgatherdpd vgatherdpd(AsmHexCode encoded) => new Vgatherdpd(encoded);

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

        public Vgatherqpd vgatherqpd() => default;

        [MethodImpl(Inline), Op]
        public Vgatherqpd vgatherqpd(AsmHexCode encoded) => new Vgatherqpd(encoded);

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

        public Vgatherdps vgatherdps() => default;

        [MethodImpl(Inline), Op]
        public Vgatherdps vgatherdps(AsmHexCode encoded) => new Vgatherdps(encoded);

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

        public Vgatherqps vgatherqps() => default;

        [MethodImpl(Inline), Op]
        public Vgatherqps vgatherqps(AsmHexCode encoded) => new Vgatherqps(encoded);

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

        public Vpgatherdd vpgatherdd() => default;

        [MethodImpl(Inline), Op]
        public Vpgatherdd vpgatherdd(AsmHexCode encoded) => new Vpgatherdd(encoded);

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

        public Vpgatherqd vpgatherqd() => default;

        [MethodImpl(Inline), Op]
        public Vpgatherqd vpgatherqd(AsmHexCode encoded) => new Vpgatherqd(encoded);

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

        public Vpgatherdq vpgatherdq() => default;

        [MethodImpl(Inline), Op]
        public Vpgatherdq vpgatherdq(AsmHexCode encoded) => new Vpgatherdq(encoded);

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

        public Vpgatherqq vpgatherqq() => default;

        [MethodImpl(Inline), Op]
        public Vpgatherqq vpgatherqq(AsmHexCode encoded) => new Vpgatherqq(encoded);

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

        public Vinsertf128 vinsertf128() => default;

        [MethodImpl(Inline), Op]
        public Vinsertf128 vinsertf128(AsmHexCode encoded) => new Vinsertf128(encoded);

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

        public Vinserti128 vinserti128() => default;

        [MethodImpl(Inline), Op]
        public Vinserti128 vinserti128(AsmHexCode encoded) => new Vinserti128(encoded);

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

        public Vmaskmovps vmaskmovps() => default;

        [MethodImpl(Inline), Op]
        public Vmaskmovps vmaskmovps(AsmHexCode encoded) => new Vmaskmovps(encoded);

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

        public Vmaskmovpd vmaskmovpd() => default;

        [MethodImpl(Inline), Op]
        public Vmaskmovpd vmaskmovpd(AsmHexCode encoded) => new Vmaskmovpd(encoded);

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

        public Vpblendd vpblendd() => default;

        [MethodImpl(Inline), Op]
        public Vpblendd vpblendd(AsmHexCode encoded) => new Vpblendd(encoded);

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

        public Vpbroadcastb vpbroadcastb() => default;

        [MethodImpl(Inline), Op]
        public Vpbroadcastb vpbroadcastb(AsmHexCode encoded) => new Vpbroadcastb(encoded);

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

        public Vpbroadcastw vpbroadcastw() => default;

        [MethodImpl(Inline), Op]
        public Vpbroadcastw vpbroadcastw(AsmHexCode encoded) => new Vpbroadcastw(encoded);

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

        public Vpbroadcastd vpbroadcastd() => default;

        [MethodImpl(Inline), Op]
        public Vpbroadcastd vpbroadcastd(AsmHexCode encoded) => new Vpbroadcastd(encoded);

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

        public Vpbroadcastq vpbroadcastq() => default;

        [MethodImpl(Inline), Op]
        public Vpbroadcastq vpbroadcastq(AsmHexCode encoded) => new Vpbroadcastq(encoded);

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

        public Vbroadcasti128 vbroadcasti128() => default;

        [MethodImpl(Inline), Op]
        public Vbroadcasti128 vbroadcasti128(AsmHexCode encoded) => new Vbroadcasti128(encoded);

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

        public Vpermd vpermd() => default;

        [MethodImpl(Inline), Op]
        public Vpermd vpermd(AsmHexCode encoded) => new Vpermd(encoded);

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

        public Vpermpd vpermpd() => default;

        [MethodImpl(Inline), Op]
        public Vpermpd vpermpd(AsmHexCode encoded) => new Vpermpd(encoded);

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

        public Vpermps vpermps() => default;

        [MethodImpl(Inline), Op]
        public Vpermps vpermps(AsmHexCode encoded) => new Vpermps(encoded);

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

        public Vpermq vpermq() => default;

        [MethodImpl(Inline), Op]
        public Vpermq vpermq(AsmHexCode encoded) => new Vpermq(encoded);

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

        public Vperm2i128 vperm2i128() => default;

        [MethodImpl(Inline), Op]
        public Vperm2i128 vperm2i128(AsmHexCode encoded) => new Vperm2i128(encoded);

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

        public Vpermilpd vpermilpd() => default;

        [MethodImpl(Inline), Op]
        public Vpermilpd vpermilpd(AsmHexCode encoded) => new Vpermilpd(encoded);

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

        public Vpermilps vpermilps() => default;

        [MethodImpl(Inline), Op]
        public Vpermilps vpermilps(AsmHexCode encoded) => new Vpermilps(encoded);

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

        public Vperm2f128 vperm2f128() => default;

        [MethodImpl(Inline), Op]
        public Vperm2f128 vperm2f128(AsmHexCode encoded) => new Vperm2f128(encoded);

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

        public Vpmaskmovd vpmaskmovd() => default;

        [MethodImpl(Inline), Op]
        public Vpmaskmovd vpmaskmovd(AsmHexCode encoded) => new Vpmaskmovd(encoded);

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

        public Vpmaskmovq vpmaskmovq() => default;

        [MethodImpl(Inline), Op]
        public Vpmaskmovq vpmaskmovq(AsmHexCode encoded) => new Vpmaskmovq(encoded);

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

        public Vpsllvd vpsllvd() => default;

        [MethodImpl(Inline), Op]
        public Vpsllvd vpsllvd(AsmHexCode encoded) => new Vpsllvd(encoded);

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

        public Vpsllvq vpsllvq() => default;

        [MethodImpl(Inline), Op]
        public Vpsllvq vpsllvq(AsmHexCode encoded) => new Vpsllvq(encoded);

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

        public Vpsravd vpsravd() => default;

        [MethodImpl(Inline), Op]
        public Vpsravd vpsravd(AsmHexCode encoded) => new Vpsravd(encoded);

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

        public Vpsrlvd vpsrlvd() => default;

        [MethodImpl(Inline), Op]
        public Vpsrlvd vpsrlvd(AsmHexCode encoded) => new Vpsrlvd(encoded);

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

        public Vpsrlvq vpsrlvq() => default;

        [MethodImpl(Inline), Op]
        public Vpsrlvq vpsrlvq(AsmHexCode encoded) => new Vpsrlvq(encoded);

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

        public Vtestps vtestps() => default;

        [MethodImpl(Inline), Op]
        public Vtestps vtestps(AsmHexCode encoded) => new Vtestps(encoded);

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

        public Vtestpd vtestpd() => default;

        [MethodImpl(Inline), Op]
        public Vtestpd vtestpd(AsmHexCode encoded) => new Vtestpd(encoded);

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

        public Vzeroall vzeroall() => default;

        [MethodImpl(Inline), Op]
        public Vzeroall vzeroall(AsmHexCode encoded) => new Vzeroall(encoded);

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

        public Vzeroupper vzeroupper() => default;

        [MethodImpl(Inline), Op]
        public Vzeroupper vzeroupper(AsmHexCode encoded) => new Vzeroupper(encoded);

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

        public Wait wait() => default;

        [MethodImpl(Inline), Op]
        public Wait wait(AsmHexCode encoded) => new Wait(encoded);

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

        public Fwait fwait() => default;

        [MethodImpl(Inline), Op]
        public Fwait fwait(AsmHexCode encoded) => new Fwait(encoded);

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

        public Wbinvd wbinvd() => default;

        [MethodImpl(Inline), Op]
        public Wbinvd wbinvd(AsmHexCode encoded) => new Wbinvd(encoded);

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

        public Wrfsbase wrfsbase() => default;

        [MethodImpl(Inline), Op]
        public Wrfsbase wrfsbase(AsmHexCode encoded) => new Wrfsbase(encoded);

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

        public Wrgsbase wrgsbase() => default;

        [MethodImpl(Inline), Op]
        public Wrgsbase wrgsbase(AsmHexCode encoded) => new Wrgsbase(encoded);

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

        public Wrmsr wrmsr() => default;

        [MethodImpl(Inline), Op]
        public Wrmsr wrmsr(AsmHexCode encoded) => new Wrmsr(encoded);

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

        public Xacquire xacquire() => default;

        [MethodImpl(Inline), Op]
        public Xacquire xacquire(AsmHexCode encoded) => new Xacquire(encoded);

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

        public Xrelease xrelease() => default;

        [MethodImpl(Inline), Op]
        public Xrelease xrelease(AsmHexCode encoded) => new Xrelease(encoded);

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

        public Xabort xabort() => default;

        [MethodImpl(Inline), Op]
        public Xabort xabort(AsmHexCode encoded) => new Xabort(encoded);

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

        public Xadd xadd() => default;

        [MethodImpl(Inline), Op]
        public Xadd xadd(AsmHexCode encoded) => new Xadd(encoded);

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

        public Xbegin xbegin() => default;

        [MethodImpl(Inline), Op]
        public Xbegin xbegin(AsmHexCode encoded) => new Xbegin(encoded);

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

        public Xchg xchg() => default;

        [MethodImpl(Inline), Op]
        public Xchg xchg(AsmHexCode encoded) => new Xchg(encoded);

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

        public Xend xend() => default;

        [MethodImpl(Inline), Op]
        public Xend xend(AsmHexCode encoded) => new Xend(encoded);

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

        public Xgetbv xgetbv() => default;

        [MethodImpl(Inline), Op]
        public Xgetbv xgetbv(AsmHexCode encoded) => new Xgetbv(encoded);

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

        public Xlat xlat() => default;

        [MethodImpl(Inline), Op]
        public Xlat xlat(AsmHexCode encoded) => new Xlat(encoded);

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

        public Xlatb xlatb() => default;

        [MethodImpl(Inline), Op]
        public Xlatb xlatb(AsmHexCode encoded) => new Xlatb(encoded);

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

        public Xor xor() => default;

        [MethodImpl(Inline), Op]
        public Xor xor(AsmHexCode encoded) => new Xor(encoded);

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

        public Xorpd xorpd() => default;

        [MethodImpl(Inline), Op]
        public Xorpd xorpd(AsmHexCode encoded) => new Xorpd(encoded);

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

        public Vxorpd vxorpd() => default;

        [MethodImpl(Inline), Op]
        public Vxorpd vxorpd(AsmHexCode encoded) => new Vxorpd(encoded);

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

        public Xorps xorps() => default;

        [MethodImpl(Inline), Op]
        public Xorps xorps(AsmHexCode encoded) => new Xorps(encoded);

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

        public Vxorps vxorps() => default;

        [MethodImpl(Inline), Op]
        public Vxorps vxorps(AsmHexCode encoded) => new Vxorps(encoded);

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

        public Xrstor xrstor() => default;

        [MethodImpl(Inline), Op]
        public Xrstor xrstor(AsmHexCode encoded) => new Xrstor(encoded);

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

        public Xrstor64 xrstor64() => default;

        [MethodImpl(Inline), Op]
        public Xrstor64 xrstor64(AsmHexCode encoded) => new Xrstor64(encoded);

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

        public Xsave xsave() => default;

        [MethodImpl(Inline), Op]
        public Xsave xsave(AsmHexCode encoded) => new Xsave(encoded);

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

        public Xsave64 xsave64() => default;

        [MethodImpl(Inline), Op]
        public Xsave64 xsave64(AsmHexCode encoded) => new Xsave64(encoded);

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

        public Xsaveopt xsaveopt() => default;

        [MethodImpl(Inline), Op]
        public Xsaveopt xsaveopt(AsmHexCode encoded) => new Xsaveopt(encoded);

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

        public Xsaveopt64 xsaveopt64() => default;

        [MethodImpl(Inline), Op]
        public Xsaveopt64 xsaveopt64(AsmHexCode encoded) => new Xsaveopt64(encoded);

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

        public Xsetbv xsetbv() => default;

        [MethodImpl(Inline), Op]
        public Xsetbv xsetbv(AsmHexCode encoded) => new Xsetbv(encoded);

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

        public Xtest xtest() => default;

        [MethodImpl(Inline), Op]
        public Xtest xtest(AsmHexCode encoded) => new Xtest(encoded);

    }
}
