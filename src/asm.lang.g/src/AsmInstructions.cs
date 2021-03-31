//-----------------------------------------------------------------------------
// Generated   :  2021-03-31.15.21.10.9889
// Copyright   :  (c) Chris Moore, 2021
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using static Part;

    public readonly struct AsmInstructions
    {
        public struct Aaa : ITypedInstruction<Aaa>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Aaa(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AAA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Aaa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aaa src) => AsmMnemonics.AAA;

            public static implicit operator AsmHexCode(Aaa src) => src.Encoded;
        }

        public Aaa aaa() => default;

        [MethodImpl(Inline), Op]
        public Aaa aaa(AsmHexCode encoded) => new Aaa(encoded);

        public struct Aad : ITypedInstruction<Aad>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Aad(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AAD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Aad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aad src) => AsmMnemonics.AAD;

            public static implicit operator AsmHexCode(Aad src) => src.Encoded;
        }

        public Aad aad() => default;

        [MethodImpl(Inline), Op]
        public Aad aad(AsmHexCode encoded) => new Aad(encoded);

        public struct Aam : ITypedInstruction<Aam>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Aam(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AAM;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Aam src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aam src) => AsmMnemonics.AAM;

            public static implicit operator AsmHexCode(Aam src) => src.Encoded;
        }

        public Aam aam() => default;

        [MethodImpl(Inline), Op]
        public Aam aam(AsmHexCode encoded) => new Aam(encoded);

        public struct Aas : ITypedInstruction<Aas>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Aas(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AAS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Aas src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aas src) => AsmMnemonics.AAS;

            public static implicit operator AsmHexCode(Aas src) => src.Encoded;
        }

        public Aas aas() => default;

        [MethodImpl(Inline), Op]
        public Aas aas(AsmHexCode encoded) => new Aas(encoded);

        public struct Adc : ITypedInstruction<Adc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Adc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Adc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Adc src) => AsmMnemonics.ADC;

            public static implicit operator AsmHexCode(Adc src) => src.Encoded;
        }

        public Adc adc() => default;

        [MethodImpl(Inline), Op]
        public Adc adc(AsmHexCode encoded) => new Adc(encoded);

        public struct Add : ITypedInstruction<Add>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Add(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Add src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Add src) => AsmMnemonics.ADD;

            public static implicit operator AsmHexCode(Add src) => src.Encoded;
        }

        public Add add() => default;

        [MethodImpl(Inline), Op]
        public Add add(AsmHexCode encoded) => new Add(encoded);

        public struct Addpd : ITypedInstruction<Addpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Addpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Addpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addpd src) => AsmMnemonics.ADDPD;

            public static implicit operator AsmHexCode(Addpd src) => src.Encoded;
        }

        public Addpd addpd() => default;

        [MethodImpl(Inline), Op]
        public Addpd addpd(AsmHexCode encoded) => new Addpd(encoded);

        public struct Vaddpd : ITypedInstruction<Vaddpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vaddpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vaddpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddpd src) => AsmMnemonics.VADDPD;

            public static implicit operator AsmHexCode(Vaddpd src) => src.Encoded;
        }

        public Vaddpd vaddpd() => default;

        [MethodImpl(Inline), Op]
        public Vaddpd vaddpd(AsmHexCode encoded) => new Vaddpd(encoded);

        public struct Addps : ITypedInstruction<Addps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Addps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Addps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addps src) => AsmMnemonics.ADDPS;

            public static implicit operator AsmHexCode(Addps src) => src.Encoded;
        }

        public Addps addps() => default;

        [MethodImpl(Inline), Op]
        public Addps addps(AsmHexCode encoded) => new Addps(encoded);

        public struct Vaddps : ITypedInstruction<Vaddps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vaddps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vaddps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddps src) => AsmMnemonics.VADDPS;

            public static implicit operator AsmHexCode(Vaddps src) => src.Encoded;
        }

        public Vaddps vaddps() => default;

        [MethodImpl(Inline), Op]
        public Vaddps vaddps(AsmHexCode encoded) => new Vaddps(encoded);

        public struct Addsd : ITypedInstruction<Addsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Addsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Addsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addsd src) => AsmMnemonics.ADDSD;

            public static implicit operator AsmHexCode(Addsd src) => src.Encoded;
        }

        public Addsd addsd() => default;

        [MethodImpl(Inline), Op]
        public Addsd addsd(AsmHexCode encoded) => new Addsd(encoded);

        public struct Vaddsd : ITypedInstruction<Vaddsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vaddsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vaddsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddsd src) => AsmMnemonics.VADDSD;

            public static implicit operator AsmHexCode(Vaddsd src) => src.Encoded;
        }

        public Vaddsd vaddsd() => default;

        [MethodImpl(Inline), Op]
        public Vaddsd vaddsd(AsmHexCode encoded) => new Vaddsd(encoded);

        public struct Addss : ITypedInstruction<Addss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Addss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Addss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addss src) => AsmMnemonics.ADDSS;

            public static implicit operator AsmHexCode(Addss src) => src.Encoded;
        }

        public Addss addss() => default;

        [MethodImpl(Inline), Op]
        public Addss addss(AsmHexCode encoded) => new Addss(encoded);

        public struct Vaddss : ITypedInstruction<Vaddss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vaddss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vaddss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddss src) => AsmMnemonics.VADDSS;

            public static implicit operator AsmHexCode(Vaddss src) => src.Encoded;
        }

        public Vaddss vaddss() => default;

        [MethodImpl(Inline), Op]
        public Vaddss vaddss(AsmHexCode encoded) => new Vaddss(encoded);

        public struct Addsubpd : ITypedInstruction<Addsubpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Addsubpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSUBPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Addsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addsubpd src) => AsmMnemonics.ADDSUBPD;

            public static implicit operator AsmHexCode(Addsubpd src) => src.Encoded;
        }

        public Addsubpd addsubpd() => default;

        [MethodImpl(Inline), Op]
        public Addsubpd addsubpd(AsmHexCode encoded) => new Addsubpd(encoded);

        public struct Vaddsubpd : ITypedInstruction<Vaddsubpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vaddsubpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSUBPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vaddsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddsubpd src) => AsmMnemonics.VADDSUBPD;

            public static implicit operator AsmHexCode(Vaddsubpd src) => src.Encoded;
        }

        public Vaddsubpd vaddsubpd() => default;

        [MethodImpl(Inline), Op]
        public Vaddsubpd vaddsubpd(AsmHexCode encoded) => new Vaddsubpd(encoded);

        public struct Addsubps : ITypedInstruction<Addsubps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Addsubps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSUBPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Addsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addsubps src) => AsmMnemonics.ADDSUBPS;

            public static implicit operator AsmHexCode(Addsubps src) => src.Encoded;
        }

        public Addsubps addsubps() => default;

        [MethodImpl(Inline), Op]
        public Addsubps addsubps(AsmHexCode encoded) => new Addsubps(encoded);

        public struct Vaddsubps : ITypedInstruction<Vaddsubps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vaddsubps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSUBPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vaddsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddsubps src) => AsmMnemonics.VADDSUBPS;

            public static implicit operator AsmHexCode(Vaddsubps src) => src.Encoded;
        }

        public Vaddsubps vaddsubps() => default;

        [MethodImpl(Inline), Op]
        public Vaddsubps vaddsubps(AsmHexCode encoded) => new Vaddsubps(encoded);

        public struct Aesdec : ITypedInstruction<Aesdec>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Aesdec(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESDEC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Aesdec src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesdec src) => AsmMnemonics.AESDEC;

            public static implicit operator AsmHexCode(Aesdec src) => src.Encoded;
        }

        public Aesdec aesdec() => default;

        [MethodImpl(Inline), Op]
        public Aesdec aesdec(AsmHexCode encoded) => new Aesdec(encoded);

        public struct Vaesdec : ITypedInstruction<Vaesdec>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vaesdec(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESDEC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vaesdec src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesdec src) => AsmMnemonics.VAESDEC;

            public static implicit operator AsmHexCode(Vaesdec src) => src.Encoded;
        }

        public Vaesdec vaesdec() => default;

        [MethodImpl(Inline), Op]
        public Vaesdec vaesdec(AsmHexCode encoded) => new Vaesdec(encoded);

        public struct Aesdeclast : ITypedInstruction<Aesdeclast>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Aesdeclast(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESDECLAST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Aesdeclast src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesdeclast src) => AsmMnemonics.AESDECLAST;

            public static implicit operator AsmHexCode(Aesdeclast src) => src.Encoded;
        }

        public Aesdeclast aesdeclast() => default;

        [MethodImpl(Inline), Op]
        public Aesdeclast aesdeclast(AsmHexCode encoded) => new Aesdeclast(encoded);

        public struct Vaesdeclast : ITypedInstruction<Vaesdeclast>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vaesdeclast(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESDECLAST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vaesdeclast src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesdeclast src) => AsmMnemonics.VAESDECLAST;

            public static implicit operator AsmHexCode(Vaesdeclast src) => src.Encoded;
        }

        public Vaesdeclast vaesdeclast() => default;

        [MethodImpl(Inline), Op]
        public Vaesdeclast vaesdeclast(AsmHexCode encoded) => new Vaesdeclast(encoded);

        public struct Aesenc : ITypedInstruction<Aesenc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Aesenc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESENC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Aesenc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesenc src) => AsmMnemonics.AESENC;

            public static implicit operator AsmHexCode(Aesenc src) => src.Encoded;
        }

        public Aesenc aesenc() => default;

        [MethodImpl(Inline), Op]
        public Aesenc aesenc(AsmHexCode encoded) => new Aesenc(encoded);

        public struct Vaesenc : ITypedInstruction<Vaesenc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vaesenc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESENC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vaesenc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesenc src) => AsmMnemonics.VAESENC;

            public static implicit operator AsmHexCode(Vaesenc src) => src.Encoded;
        }

        public Vaesenc vaesenc() => default;

        [MethodImpl(Inline), Op]
        public Vaesenc vaesenc(AsmHexCode encoded) => new Vaesenc(encoded);

        public struct Aesenclast : ITypedInstruction<Aesenclast>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Aesenclast(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESENCLAST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Aesenclast src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesenclast src) => AsmMnemonics.AESENCLAST;

            public static implicit operator AsmHexCode(Aesenclast src) => src.Encoded;
        }

        public Aesenclast aesenclast() => default;

        [MethodImpl(Inline), Op]
        public Aesenclast aesenclast(AsmHexCode encoded) => new Aesenclast(encoded);

        public struct Vaesenclast : ITypedInstruction<Vaesenclast>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vaesenclast(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESENCLAST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vaesenclast src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesenclast src) => AsmMnemonics.VAESENCLAST;

            public static implicit operator AsmHexCode(Vaesenclast src) => src.Encoded;
        }

        public Vaesenclast vaesenclast() => default;

        [MethodImpl(Inline), Op]
        public Vaesenclast vaesenclast(AsmHexCode encoded) => new Vaesenclast(encoded);

        public struct Aesimc : ITypedInstruction<Aesimc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Aesimc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESIMC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Aesimc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesimc src) => AsmMnemonics.AESIMC;

            public static implicit operator AsmHexCode(Aesimc src) => src.Encoded;
        }

        public Aesimc aesimc() => default;

        [MethodImpl(Inline), Op]
        public Aesimc aesimc(AsmHexCode encoded) => new Aesimc(encoded);

        public struct Vaesimc : ITypedInstruction<Vaesimc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vaesimc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESIMC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vaesimc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesimc src) => AsmMnemonics.VAESIMC;

            public static implicit operator AsmHexCode(Vaesimc src) => src.Encoded;
        }

        public Vaesimc vaesimc() => default;

        [MethodImpl(Inline), Op]
        public Vaesimc vaesimc(AsmHexCode encoded) => new Vaesimc(encoded);

        public struct Aeskeygenassist : ITypedInstruction<Aeskeygenassist>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Aeskeygenassist(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESKEYGENASSIST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Aeskeygenassist src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aeskeygenassist src) => AsmMnemonics.AESKEYGENASSIST;

            public static implicit operator AsmHexCode(Aeskeygenassist src) => src.Encoded;
        }

        public Aeskeygenassist aeskeygenassist() => default;

        [MethodImpl(Inline), Op]
        public Aeskeygenassist aeskeygenassist(AsmHexCode encoded) => new Aeskeygenassist(encoded);

        public struct Vaeskeygenassist : ITypedInstruction<Vaeskeygenassist>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vaeskeygenassist(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESKEYGENASSIST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vaeskeygenassist src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaeskeygenassist src) => AsmMnemonics.VAESKEYGENASSIST;

            public static implicit operator AsmHexCode(Vaeskeygenassist src) => src.Encoded;
        }

        public Vaeskeygenassist vaeskeygenassist() => default;

        [MethodImpl(Inline), Op]
        public Vaeskeygenassist vaeskeygenassist(AsmHexCode encoded) => new Vaeskeygenassist(encoded);

        public struct And : ITypedInstruction<And>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public And(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AND;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(And src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(And src) => AsmMnemonics.AND;

            public static implicit operator AsmHexCode(And src) => src.Encoded;
        }

        public And and() => default;

        [MethodImpl(Inline), Op]
        public And and(AsmHexCode encoded) => new And(encoded);

        public struct Andn : ITypedInstruction<Andn>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Andn(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDN;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Andn src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andn src) => AsmMnemonics.ANDN;

            public static implicit operator AsmHexCode(Andn src) => src.Encoded;
        }

        public Andn andn() => default;

        [MethodImpl(Inline), Op]
        public Andn andn(AsmHexCode encoded) => new Andn(encoded);

        public struct Andpd : ITypedInstruction<Andpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Andpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Andpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andpd src) => AsmMnemonics.ANDPD;

            public static implicit operator AsmHexCode(Andpd src) => src.Encoded;
        }

        public Andpd andpd() => default;

        [MethodImpl(Inline), Op]
        public Andpd andpd(AsmHexCode encoded) => new Andpd(encoded);

        public struct Vandpd : ITypedInstruction<Vandpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vandpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vandpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vandpd src) => AsmMnemonics.VANDPD;

            public static implicit operator AsmHexCode(Vandpd src) => src.Encoded;
        }

        public Vandpd vandpd() => default;

        [MethodImpl(Inline), Op]
        public Vandpd vandpd(AsmHexCode encoded) => new Vandpd(encoded);

        public struct Andps : ITypedInstruction<Andps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Andps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Andps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andps src) => AsmMnemonics.ANDPS;

            public static implicit operator AsmHexCode(Andps src) => src.Encoded;
        }

        public Andps andps() => default;

        [MethodImpl(Inline), Op]
        public Andps andps(AsmHexCode encoded) => new Andps(encoded);

        public struct Vandps : ITypedInstruction<Vandps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vandps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vandps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vandps src) => AsmMnemonics.VANDPS;

            public static implicit operator AsmHexCode(Vandps src) => src.Encoded;
        }

        public Vandps vandps() => default;

        [MethodImpl(Inline), Op]
        public Vandps vandps(AsmHexCode encoded) => new Vandps(encoded);

        public struct Andnpd : ITypedInstruction<Andnpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Andnpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDNPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Andnpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andnpd src) => AsmMnemonics.ANDNPD;

            public static implicit operator AsmHexCode(Andnpd src) => src.Encoded;
        }

        public Andnpd andnpd() => default;

        [MethodImpl(Inline), Op]
        public Andnpd andnpd(AsmHexCode encoded) => new Andnpd(encoded);

        public struct Vandnpd : ITypedInstruction<Vandnpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vandnpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDNPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vandnpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vandnpd src) => AsmMnemonics.VANDNPD;

            public static implicit operator AsmHexCode(Vandnpd src) => src.Encoded;
        }

        public Vandnpd vandnpd() => default;

        [MethodImpl(Inline), Op]
        public Vandnpd vandnpd(AsmHexCode encoded) => new Vandnpd(encoded);

        public struct Andnps : ITypedInstruction<Andnps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Andnps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDNPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Andnps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andnps src) => AsmMnemonics.ANDNPS;

            public static implicit operator AsmHexCode(Andnps src) => src.Encoded;
        }

        public Andnps andnps() => default;

        [MethodImpl(Inline), Op]
        public Andnps andnps(AsmHexCode encoded) => new Andnps(encoded);

        public struct Vandnps : ITypedInstruction<Vandnps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vandnps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDNPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vandnps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vandnps src) => AsmMnemonics.VANDNPS;

            public static implicit operator AsmHexCode(Vandnps src) => src.Encoded;
        }

        public Vandnps vandnps() => default;

        [MethodImpl(Inline), Op]
        public Vandnps vandnps(AsmHexCode encoded) => new Vandnps(encoded);

        public struct Arpl : ITypedInstruction<Arpl>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Arpl(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ARPL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Arpl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Arpl src) => AsmMnemonics.ARPL;

            public static implicit operator AsmHexCode(Arpl src) => src.Encoded;
        }

        public Arpl arpl() => default;

        [MethodImpl(Inline), Op]
        public Arpl arpl(AsmHexCode encoded) => new Arpl(encoded);

        public struct Blendpd : ITypedInstruction<Blendpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Blendpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Blendpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blendpd src) => AsmMnemonics.BLENDPD;

            public static implicit operator AsmHexCode(Blendpd src) => src.Encoded;
        }

        public Blendpd blendpd() => default;

        [MethodImpl(Inline), Op]
        public Blendpd blendpd(AsmHexCode encoded) => new Blendpd(encoded);

        public struct Vblendpd : ITypedInstruction<Vblendpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vblendpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vblendpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vblendpd src) => AsmMnemonics.VBLENDPD;

            public static implicit operator AsmHexCode(Vblendpd src) => src.Encoded;
        }

        public Vblendpd vblendpd() => default;

        [MethodImpl(Inline), Op]
        public Vblendpd vblendpd(AsmHexCode encoded) => new Vblendpd(encoded);

        public struct Bextr : ITypedInstruction<Bextr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Bextr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BEXTR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Bextr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bextr src) => AsmMnemonics.BEXTR;

            public static implicit operator AsmHexCode(Bextr src) => src.Encoded;
        }

        public Bextr bextr() => default;

        [MethodImpl(Inline), Op]
        public Bextr bextr(AsmHexCode encoded) => new Bextr(encoded);

        public struct Blendps : ITypedInstruction<Blendps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Blendps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Blendps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blendps src) => AsmMnemonics.BLENDPS;

            public static implicit operator AsmHexCode(Blendps src) => src.Encoded;
        }

        public Blendps blendps() => default;

        [MethodImpl(Inline), Op]
        public Blendps blendps(AsmHexCode encoded) => new Blendps(encoded);

        public struct Vblendps : ITypedInstruction<Vblendps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vblendps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vblendps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vblendps src) => AsmMnemonics.VBLENDPS;

            public static implicit operator AsmHexCode(Vblendps src) => src.Encoded;
        }

        public Vblendps vblendps() => default;

        [MethodImpl(Inline), Op]
        public Vblendps vblendps(AsmHexCode encoded) => new Vblendps(encoded);

        public struct Blendvpd : ITypedInstruction<Blendvpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Blendvpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDVPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Blendvpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blendvpd src) => AsmMnemonics.BLENDVPD;

            public static implicit operator AsmHexCode(Blendvpd src) => src.Encoded;
        }

        public Blendvpd blendvpd() => default;

        [MethodImpl(Inline), Op]
        public Blendvpd blendvpd(AsmHexCode encoded) => new Blendvpd(encoded);

        public struct Vblendvpd : ITypedInstruction<Vblendvpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vblendvpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDVPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vblendvpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vblendvpd src) => AsmMnemonics.VBLENDVPD;

            public static implicit operator AsmHexCode(Vblendvpd src) => src.Encoded;
        }

        public Vblendvpd vblendvpd() => default;

        [MethodImpl(Inline), Op]
        public Vblendvpd vblendvpd(AsmHexCode encoded) => new Vblendvpd(encoded);

        public struct Blendvps : ITypedInstruction<Blendvps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Blendvps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDVPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Blendvps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blendvps src) => AsmMnemonics.BLENDVPS;

            public static implicit operator AsmHexCode(Blendvps src) => src.Encoded;
        }

        public Blendvps blendvps() => default;

        [MethodImpl(Inline), Op]
        public Blendvps blendvps(AsmHexCode encoded) => new Blendvps(encoded);

        public struct Vblendvps : ITypedInstruction<Vblendvps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vblendvps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDVPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vblendvps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vblendvps src) => AsmMnemonics.VBLENDVPS;

            public static implicit operator AsmHexCode(Vblendvps src) => src.Encoded;
        }

        public Vblendvps vblendvps() => default;

        [MethodImpl(Inline), Op]
        public Vblendvps vblendvps(AsmHexCode encoded) => new Vblendvps(encoded);

        public struct Blsi : ITypedInstruction<Blsi>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Blsi(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLSI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Blsi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blsi src) => AsmMnemonics.BLSI;

            public static implicit operator AsmHexCode(Blsi src) => src.Encoded;
        }

        public Blsi blsi() => default;

        [MethodImpl(Inline), Op]
        public Blsi blsi(AsmHexCode encoded) => new Blsi(encoded);

        public struct Blsmsk : ITypedInstruction<Blsmsk>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Blsmsk(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLSMSK;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Blsmsk src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blsmsk src) => AsmMnemonics.BLSMSK;

            public static implicit operator AsmHexCode(Blsmsk src) => src.Encoded;
        }

        public Blsmsk blsmsk() => default;

        [MethodImpl(Inline), Op]
        public Blsmsk blsmsk(AsmHexCode encoded) => new Blsmsk(encoded);

        public struct Blsr : ITypedInstruction<Blsr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Blsr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLSR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Blsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blsr src) => AsmMnemonics.BLSR;

            public static implicit operator AsmHexCode(Blsr src) => src.Encoded;
        }

        public Blsr blsr() => default;

        [MethodImpl(Inline), Op]
        public Blsr blsr(AsmHexCode encoded) => new Blsr(encoded);

        public struct Bound : ITypedInstruction<Bound>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Bound(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BOUND;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Bound src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bound src) => AsmMnemonics.BOUND;

            public static implicit operator AsmHexCode(Bound src) => src.Encoded;
        }

        public Bound bound() => default;

        [MethodImpl(Inline), Op]
        public Bound bound(AsmHexCode encoded) => new Bound(encoded);

        public struct Bsf : ITypedInstruction<Bsf>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Bsf(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BSF;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Bsf src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bsf src) => AsmMnemonics.BSF;

            public static implicit operator AsmHexCode(Bsf src) => src.Encoded;
        }

        public Bsf bsf() => default;

        [MethodImpl(Inline), Op]
        public Bsf bsf(AsmHexCode encoded) => new Bsf(encoded);

        public struct Bsr : ITypedInstruction<Bsr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Bsr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BSR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Bsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bsr src) => AsmMnemonics.BSR;

            public static implicit operator AsmHexCode(Bsr src) => src.Encoded;
        }

        public Bsr bsr() => default;

        [MethodImpl(Inline), Op]
        public Bsr bsr(AsmHexCode encoded) => new Bsr(encoded);

        public struct Bswap : ITypedInstruction<Bswap>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Bswap(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BSWAP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Bswap src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bswap src) => AsmMnemonics.BSWAP;

            public static implicit operator AsmHexCode(Bswap src) => src.Encoded;
        }

        public Bswap bswap() => default;

        [MethodImpl(Inline), Op]
        public Bswap bswap(AsmHexCode encoded) => new Bswap(encoded);

        public struct Bt : ITypedInstruction<Bt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Bt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Bt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bt src) => AsmMnemonics.BT;

            public static implicit operator AsmHexCode(Bt src) => src.Encoded;
        }

        public Bt bt() => default;

        [MethodImpl(Inline), Op]
        public Bt bt(AsmHexCode encoded) => new Bt(encoded);

        public struct Btc : ITypedInstruction<Btc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Btc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BTC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Btc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Btc src) => AsmMnemonics.BTC;

            public static implicit operator AsmHexCode(Btc src) => src.Encoded;
        }

        public Btc btc() => default;

        [MethodImpl(Inline), Op]
        public Btc btc(AsmHexCode encoded) => new Btc(encoded);

        public struct Btr : ITypedInstruction<Btr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Btr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BTR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Btr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Btr src) => AsmMnemonics.BTR;

            public static implicit operator AsmHexCode(Btr src) => src.Encoded;
        }

        public Btr btr() => default;

        [MethodImpl(Inline), Op]
        public Btr btr(AsmHexCode encoded) => new Btr(encoded);

        public struct Bts : ITypedInstruction<Bts>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Bts(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BTS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Bts src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bts src) => AsmMnemonics.BTS;

            public static implicit operator AsmHexCode(Bts src) => src.Encoded;
        }

        public Bts bts() => default;

        [MethodImpl(Inline), Op]
        public Bts bts(AsmHexCode encoded) => new Bts(encoded);

        public struct Bzhi : ITypedInstruction<Bzhi>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Bzhi(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BZHI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Bzhi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bzhi src) => AsmMnemonics.BZHI;

            public static implicit operator AsmHexCode(Bzhi src) => src.Encoded;
        }

        public Bzhi bzhi() => default;

        [MethodImpl(Inline), Op]
        public Bzhi bzhi(AsmHexCode encoded) => new Bzhi(encoded);

        public struct Call : ITypedInstruction<Call>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Call(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CALL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Call src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Call src) => AsmMnemonics.CALL;

            public static implicit operator AsmHexCode(Call src) => src.Encoded;
        }

        public Call call() => default;

        [MethodImpl(Inline), Op]
        public Call call(AsmHexCode encoded) => new Call(encoded);

        public struct Cbw : ITypedInstruction<Cbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cbw src) => AsmMnemonics.CBW;

            public static implicit operator AsmHexCode(Cbw src) => src.Encoded;
        }

        public Cbw cbw() => default;

        [MethodImpl(Inline), Op]
        public Cbw cbw(AsmHexCode encoded) => new Cbw(encoded);

        public struct Cwde : ITypedInstruction<Cwde>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cwde(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CWDE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cwde src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cwde src) => AsmMnemonics.CWDE;

            public static implicit operator AsmHexCode(Cwde src) => src.Encoded;
        }

        public Cwde cwde() => default;

        [MethodImpl(Inline), Op]
        public Cwde cwde(AsmHexCode encoded) => new Cwde(encoded);

        public struct Cdqe : ITypedInstruction<Cdqe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cdqe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CDQE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cdqe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cdqe src) => AsmMnemonics.CDQE;

            public static implicit operator AsmHexCode(Cdqe src) => src.Encoded;
        }

        public Cdqe cdqe() => default;

        [MethodImpl(Inline), Op]
        public Cdqe cdqe(AsmHexCode encoded) => new Cdqe(encoded);

        public struct Clc : ITypedInstruction<Clc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Clc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CLC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Clc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Clc src) => AsmMnemonics.CLC;

            public static implicit operator AsmHexCode(Clc src) => src.Encoded;
        }

        public Clc clc() => default;

        [MethodImpl(Inline), Op]
        public Clc clc(AsmHexCode encoded) => new Clc(encoded);

        public struct Cld : ITypedInstruction<Cld>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cld(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CLD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cld src) => AsmMnemonics.CLD;

            public static implicit operator AsmHexCode(Cld src) => src.Encoded;
        }

        public Cld cld() => default;

        [MethodImpl(Inline), Op]
        public Cld cld(AsmHexCode encoded) => new Cld(encoded);

        public struct Clflush : ITypedInstruction<Clflush>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Clflush(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CLFLUSH;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Clflush src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Clflush src) => AsmMnemonics.CLFLUSH;

            public static implicit operator AsmHexCode(Clflush src) => src.Encoded;
        }

        public Clflush clflush() => default;

        [MethodImpl(Inline), Op]
        public Clflush clflush(AsmHexCode encoded) => new Clflush(encoded);

        public struct Cli : ITypedInstruction<Cli>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cli(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CLI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cli src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cli src) => AsmMnemonics.CLI;

            public static implicit operator AsmHexCode(Cli src) => src.Encoded;
        }

        public Cli cli() => default;

        [MethodImpl(Inline), Op]
        public Cli cli(AsmHexCode encoded) => new Cli(encoded);

        public struct Clts : ITypedInstruction<Clts>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Clts(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CLTS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Clts src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Clts src) => AsmMnemonics.CLTS;

            public static implicit operator AsmHexCode(Clts src) => src.Encoded;
        }

        public Clts clts() => default;

        [MethodImpl(Inline), Op]
        public Clts clts(AsmHexCode encoded) => new Clts(encoded);

        public struct Cmc : ITypedInstruction<Cmc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmc src) => AsmMnemonics.CMC;

            public static implicit operator AsmHexCode(Cmc src) => src.Encoded;
        }

        public Cmc cmc() => default;

        [MethodImpl(Inline), Op]
        public Cmc cmc(AsmHexCode encoded) => new Cmc(encoded);

        public struct Cmova : ITypedInstruction<Cmova>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmova(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmova src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmova src) => AsmMnemonics.CMOVA;

            public static implicit operator AsmHexCode(Cmova src) => src.Encoded;
        }

        public Cmova cmova() => default;

        [MethodImpl(Inline), Op]
        public Cmova cmova(AsmHexCode encoded) => new Cmova(encoded);

        public struct Cmovae : ITypedInstruction<Cmovae>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovae(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVAE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovae src) => AsmMnemonics.CMOVAE;

            public static implicit operator AsmHexCode(Cmovae src) => src.Encoded;
        }

        public Cmovae cmovae() => default;

        [MethodImpl(Inline), Op]
        public Cmovae cmovae(AsmHexCode encoded) => new Cmovae(encoded);

        public struct Cmovb : ITypedInstruction<Cmovb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovb src) => AsmMnemonics.CMOVB;

            public static implicit operator AsmHexCode(Cmovb src) => src.Encoded;
        }

        public Cmovb cmovb() => default;

        [MethodImpl(Inline), Op]
        public Cmovb cmovb(AsmHexCode encoded) => new Cmovb(encoded);

        public struct Cmovbe : ITypedInstruction<Cmovbe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovbe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVBE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovbe src) => AsmMnemonics.CMOVBE;

            public static implicit operator AsmHexCode(Cmovbe src) => src.Encoded;
        }

        public Cmovbe cmovbe() => default;

        [MethodImpl(Inline), Op]
        public Cmovbe cmovbe(AsmHexCode encoded) => new Cmovbe(encoded);

        public struct Cmovc : ITypedInstruction<Cmovc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovc src) => AsmMnemonics.CMOVC;

            public static implicit operator AsmHexCode(Cmovc src) => src.Encoded;
        }

        public Cmovc cmovc() => default;

        [MethodImpl(Inline), Op]
        public Cmovc cmovc(AsmHexCode encoded) => new Cmovc(encoded);

        public struct Cmove : ITypedInstruction<Cmove>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmove(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmove src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmove src) => AsmMnemonics.CMOVE;

            public static implicit operator AsmHexCode(Cmove src) => src.Encoded;
        }

        public Cmove cmove() => default;

        [MethodImpl(Inline), Op]
        public Cmove cmove(AsmHexCode encoded) => new Cmove(encoded);

        public struct Cmovg : ITypedInstruction<Cmovg>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovg(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVG;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovg src) => AsmMnemonics.CMOVG;

            public static implicit operator AsmHexCode(Cmovg src) => src.Encoded;
        }

        public Cmovg cmovg() => default;

        [MethodImpl(Inline), Op]
        public Cmovg cmovg(AsmHexCode encoded) => new Cmovg(encoded);

        public struct Cmovge : ITypedInstruction<Cmovge>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovge(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVGE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovge src) => AsmMnemonics.CMOVGE;

            public static implicit operator AsmHexCode(Cmovge src) => src.Encoded;
        }

        public Cmovge cmovge() => default;

        [MethodImpl(Inline), Op]
        public Cmovge cmovge(AsmHexCode encoded) => new Cmovge(encoded);

        public struct Cmovl : ITypedInstruction<Cmovl>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovl(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovl src) => AsmMnemonics.CMOVL;

            public static implicit operator AsmHexCode(Cmovl src) => src.Encoded;
        }

        public Cmovl cmovl() => default;

        [MethodImpl(Inline), Op]
        public Cmovl cmovl(AsmHexCode encoded) => new Cmovl(encoded);

        public struct Cmovle : ITypedInstruction<Cmovle>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovle(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVLE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovle src) => AsmMnemonics.CMOVLE;

            public static implicit operator AsmHexCode(Cmovle src) => src.Encoded;
        }

        public Cmovle cmovle() => default;

        [MethodImpl(Inline), Op]
        public Cmovle cmovle(AsmHexCode encoded) => new Cmovle(encoded);

        public struct Cmovna : ITypedInstruction<Cmovna>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovna(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovna src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovna src) => AsmMnemonics.CMOVNA;

            public static implicit operator AsmHexCode(Cmovna src) => src.Encoded;
        }

        public Cmovna cmovna() => default;

        [MethodImpl(Inline), Op]
        public Cmovna cmovna(AsmHexCode encoded) => new Cmovna(encoded);

        public struct Cmovnae : ITypedInstruction<Cmovnae>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovnae(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNAE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovnae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnae src) => AsmMnemonics.CMOVNAE;

            public static implicit operator AsmHexCode(Cmovnae src) => src.Encoded;
        }

        public Cmovnae cmovnae() => default;

        [MethodImpl(Inline), Op]
        public Cmovnae cmovnae(AsmHexCode encoded) => new Cmovnae(encoded);

        public struct Cmovnb : ITypedInstruction<Cmovnb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovnb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovnb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnb src) => AsmMnemonics.CMOVNB;

            public static implicit operator AsmHexCode(Cmovnb src) => src.Encoded;
        }

        public Cmovnb cmovnb() => default;

        [MethodImpl(Inline), Op]
        public Cmovnb cmovnb(AsmHexCode encoded) => new Cmovnb(encoded);

        public struct Cmovnbe : ITypedInstruction<Cmovnbe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovnbe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNBE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovnbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnbe src) => AsmMnemonics.CMOVNBE;

            public static implicit operator AsmHexCode(Cmovnbe src) => src.Encoded;
        }

        public Cmovnbe cmovnbe() => default;

        [MethodImpl(Inline), Op]
        public Cmovnbe cmovnbe(AsmHexCode encoded) => new Cmovnbe(encoded);

        public struct Cmovnc : ITypedInstruction<Cmovnc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovnc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovnc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnc src) => AsmMnemonics.CMOVNC;

            public static implicit operator AsmHexCode(Cmovnc src) => src.Encoded;
        }

        public Cmovnc cmovnc() => default;

        [MethodImpl(Inline), Op]
        public Cmovnc cmovnc(AsmHexCode encoded) => new Cmovnc(encoded);

        public struct Cmovne : ITypedInstruction<Cmovne>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovne(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovne src) => AsmMnemonics.CMOVNE;

            public static implicit operator AsmHexCode(Cmovne src) => src.Encoded;
        }

        public Cmovne cmovne() => default;

        [MethodImpl(Inline), Op]
        public Cmovne cmovne(AsmHexCode encoded) => new Cmovne(encoded);

        public struct Cmovng : ITypedInstruction<Cmovng>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovng(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNG;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovng src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovng src) => AsmMnemonics.CMOVNG;

            public static implicit operator AsmHexCode(Cmovng src) => src.Encoded;
        }

        public Cmovng cmovng() => default;

        [MethodImpl(Inline), Op]
        public Cmovng cmovng(AsmHexCode encoded) => new Cmovng(encoded);

        public struct Cmovnge : ITypedInstruction<Cmovnge>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovnge(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNGE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovnge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnge src) => AsmMnemonics.CMOVNGE;

            public static implicit operator AsmHexCode(Cmovnge src) => src.Encoded;
        }

        public Cmovnge cmovnge() => default;

        [MethodImpl(Inline), Op]
        public Cmovnge cmovnge(AsmHexCode encoded) => new Cmovnge(encoded);

        public struct Cmovnl : ITypedInstruction<Cmovnl>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovnl(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovnl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnl src) => AsmMnemonics.CMOVNL;

            public static implicit operator AsmHexCode(Cmovnl src) => src.Encoded;
        }

        public Cmovnl cmovnl() => default;

        [MethodImpl(Inline), Op]
        public Cmovnl cmovnl(AsmHexCode encoded) => new Cmovnl(encoded);

        public struct Cmovnle : ITypedInstruction<Cmovnle>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovnle(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNLE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovnle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnle src) => AsmMnemonics.CMOVNLE;

            public static implicit operator AsmHexCode(Cmovnle src) => src.Encoded;
        }

        public Cmovnle cmovnle() => default;

        [MethodImpl(Inline), Op]
        public Cmovnle cmovnle(AsmHexCode encoded) => new Cmovnle(encoded);

        public struct Cmovno : ITypedInstruction<Cmovno>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovno(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNO;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovno src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovno src) => AsmMnemonics.CMOVNO;

            public static implicit operator AsmHexCode(Cmovno src) => src.Encoded;
        }

        public Cmovno cmovno() => default;

        [MethodImpl(Inline), Op]
        public Cmovno cmovno(AsmHexCode encoded) => new Cmovno(encoded);

        public struct Cmovnp : ITypedInstruction<Cmovnp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovnp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovnp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnp src) => AsmMnemonics.CMOVNP;

            public static implicit operator AsmHexCode(Cmovnp src) => src.Encoded;
        }

        public Cmovnp cmovnp() => default;

        [MethodImpl(Inline), Op]
        public Cmovnp cmovnp(AsmHexCode encoded) => new Cmovnp(encoded);

        public struct Cmovns : ITypedInstruction<Cmovns>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovns(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovns src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovns src) => AsmMnemonics.CMOVNS;

            public static implicit operator AsmHexCode(Cmovns src) => src.Encoded;
        }

        public Cmovns cmovns() => default;

        [MethodImpl(Inline), Op]
        public Cmovns cmovns(AsmHexCode encoded) => new Cmovns(encoded);

        public struct Cmovnz : ITypedInstruction<Cmovnz>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovnz(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNZ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovnz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnz src) => AsmMnemonics.CMOVNZ;

            public static implicit operator AsmHexCode(Cmovnz src) => src.Encoded;
        }

        public Cmovnz cmovnz() => default;

        [MethodImpl(Inline), Op]
        public Cmovnz cmovnz(AsmHexCode encoded) => new Cmovnz(encoded);

        public struct Cmovo : ITypedInstruction<Cmovo>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovo(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVO;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovo src) => AsmMnemonics.CMOVO;

            public static implicit operator AsmHexCode(Cmovo src) => src.Encoded;
        }

        public Cmovo cmovo() => default;

        [MethodImpl(Inline), Op]
        public Cmovo cmovo(AsmHexCode encoded) => new Cmovo(encoded);

        public struct Cmovp : ITypedInstruction<Cmovp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovp src) => AsmMnemonics.CMOVP;

            public static implicit operator AsmHexCode(Cmovp src) => src.Encoded;
        }

        public Cmovp cmovp() => default;

        [MethodImpl(Inline), Op]
        public Cmovp cmovp(AsmHexCode encoded) => new Cmovp(encoded);

        public struct Cmovpe : ITypedInstruction<Cmovpe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovpe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVPE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovpe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovpe src) => AsmMnemonics.CMOVPE;

            public static implicit operator AsmHexCode(Cmovpe src) => src.Encoded;
        }

        public Cmovpe cmovpe() => default;

        [MethodImpl(Inline), Op]
        public Cmovpe cmovpe(AsmHexCode encoded) => new Cmovpe(encoded);

        public struct Cmovpo : ITypedInstruction<Cmovpo>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovpo(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVPO;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovpo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovpo src) => AsmMnemonics.CMOVPO;

            public static implicit operator AsmHexCode(Cmovpo src) => src.Encoded;
        }

        public Cmovpo cmovpo() => default;

        [MethodImpl(Inline), Op]
        public Cmovpo cmovpo(AsmHexCode encoded) => new Cmovpo(encoded);

        public struct Cmovs : ITypedInstruction<Cmovs>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovs(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovs src) => AsmMnemonics.CMOVS;

            public static implicit operator AsmHexCode(Cmovs src) => src.Encoded;
        }

        public Cmovs cmovs() => default;

        [MethodImpl(Inline), Op]
        public Cmovs cmovs(AsmHexCode encoded) => new Cmovs(encoded);

        public struct Cmovz : ITypedInstruction<Cmovz>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmovz(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVZ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmovz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovz src) => AsmMnemonics.CMOVZ;

            public static implicit operator AsmHexCode(Cmovz src) => src.Encoded;
        }

        public Cmovz cmovz() => default;

        [MethodImpl(Inline), Op]
        public Cmovz cmovz(AsmHexCode encoded) => new Cmovz(encoded);

        public struct Cmp : ITypedInstruction<Cmp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmp src) => AsmMnemonics.CMP;

            public static implicit operator AsmHexCode(Cmp src) => src.Encoded;
        }

        public Cmp cmp() => default;

        [MethodImpl(Inline), Op]
        public Cmp cmp(AsmHexCode encoded) => new Cmp(encoded);

        public struct Cmppd : ITypedInstruction<Cmppd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmppd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmppd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmppd src) => AsmMnemonics.CMPPD;

            public static implicit operator AsmHexCode(Cmppd src) => src.Encoded;
        }

        public Cmppd cmppd() => default;

        [MethodImpl(Inline), Op]
        public Cmppd cmppd(AsmHexCode encoded) => new Cmppd(encoded);

        public struct Vcmppd : ITypedInstruction<Vcmppd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcmppd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcmppd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcmppd src) => AsmMnemonics.VCMPPD;

            public static implicit operator AsmHexCode(Vcmppd src) => src.Encoded;
        }

        public Vcmppd vcmppd() => default;

        [MethodImpl(Inline), Op]
        public Vcmppd vcmppd(AsmHexCode encoded) => new Vcmppd(encoded);

        public struct Cmpps : ITypedInstruction<Cmpps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmpps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpps src) => AsmMnemonics.CMPPS;

            public static implicit operator AsmHexCode(Cmpps src) => src.Encoded;
        }

        public Cmpps cmpps() => default;

        [MethodImpl(Inline), Op]
        public Cmpps cmpps(AsmHexCode encoded) => new Cmpps(encoded);

        public struct Vcmpps : ITypedInstruction<Vcmpps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcmpps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcmpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcmpps src) => AsmMnemonics.VCMPPS;

            public static implicit operator AsmHexCode(Vcmpps src) => src.Encoded;
        }

        public Vcmpps vcmpps() => default;

        [MethodImpl(Inline), Op]
        public Vcmpps vcmpps(AsmHexCode encoded) => new Vcmpps(encoded);

        public struct Cmps : ITypedInstruction<Cmps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmps src) => AsmMnemonics.CMPS;

            public static implicit operator AsmHexCode(Cmps src) => src.Encoded;
        }

        public Cmps cmps() => default;

        [MethodImpl(Inline), Op]
        public Cmps cmps(AsmHexCode encoded) => new Cmps(encoded);

        public struct Cmpsb : ITypedInstruction<Cmpsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmpsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmpsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpsb src) => AsmMnemonics.CMPSB;

            public static implicit operator AsmHexCode(Cmpsb src) => src.Encoded;
        }

        public Cmpsb cmpsb() => default;

        [MethodImpl(Inline), Op]
        public Cmpsb cmpsb(AsmHexCode encoded) => new Cmpsb(encoded);

        public struct Cmpsw : ITypedInstruction<Cmpsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmpsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmpsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpsw src) => AsmMnemonics.CMPSW;

            public static implicit operator AsmHexCode(Cmpsw src) => src.Encoded;
        }

        public Cmpsw cmpsw() => default;

        [MethodImpl(Inline), Op]
        public Cmpsw cmpsw(AsmHexCode encoded) => new Cmpsw(encoded);

        public struct Cmpsd : ITypedInstruction<Cmpsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmpsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmpsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpsd src) => AsmMnemonics.CMPSD;

            public static implicit operator AsmHexCode(Cmpsd src) => src.Encoded;
        }

        public Cmpsd cmpsd() => default;

        [MethodImpl(Inline), Op]
        public Cmpsd cmpsd(AsmHexCode encoded) => new Cmpsd(encoded);

        public struct Cmpsq : ITypedInstruction<Cmpsq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmpsq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmpsq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpsq src) => AsmMnemonics.CMPSQ;

            public static implicit operator AsmHexCode(Cmpsq src) => src.Encoded;
        }

        public Cmpsq cmpsq() => default;

        [MethodImpl(Inline), Op]
        public Cmpsq cmpsq(AsmHexCode encoded) => new Cmpsq(encoded);

        public struct Vcmpsd : ITypedInstruction<Vcmpsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcmpsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcmpsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcmpsd src) => AsmMnemonics.VCMPSD;

            public static implicit operator AsmHexCode(Vcmpsd src) => src.Encoded;
        }

        public Vcmpsd vcmpsd() => default;

        [MethodImpl(Inline), Op]
        public Vcmpsd vcmpsd(AsmHexCode encoded) => new Vcmpsd(encoded);

        public struct Cmpss : ITypedInstruction<Cmpss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmpss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmpss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpss src) => AsmMnemonics.CMPSS;

            public static implicit operator AsmHexCode(Cmpss src) => src.Encoded;
        }

        public Cmpss cmpss() => default;

        [MethodImpl(Inline), Op]
        public Cmpss cmpss(AsmHexCode encoded) => new Cmpss(encoded);

        public struct Vcmpss : ITypedInstruction<Vcmpss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcmpss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcmpss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcmpss src) => AsmMnemonics.VCMPSS;

            public static implicit operator AsmHexCode(Vcmpss src) => src.Encoded;
        }

        public Vcmpss vcmpss() => default;

        [MethodImpl(Inline), Op]
        public Vcmpss vcmpss(AsmHexCode encoded) => new Vcmpss(encoded);

        public struct Cmpxchg : ITypedInstruction<Cmpxchg>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmpxchg(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPXCHG;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmpxchg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpxchg src) => AsmMnemonics.CMPXCHG;

            public static implicit operator AsmHexCode(Cmpxchg src) => src.Encoded;
        }

        public Cmpxchg cmpxchg() => default;

        [MethodImpl(Inline), Op]
        public Cmpxchg cmpxchg(AsmHexCode encoded) => new Cmpxchg(encoded);

        public struct Cmpxchg8b : ITypedInstruction<Cmpxchg8b>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmpxchg8b(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPXCHG8B;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmpxchg8b src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpxchg8b src) => AsmMnemonics.CMPXCHG8B;

            public static implicit operator AsmHexCode(Cmpxchg8b src) => src.Encoded;
        }

        public Cmpxchg8b cmpxchg8b() => default;

        [MethodImpl(Inline), Op]
        public Cmpxchg8b cmpxchg8b(AsmHexCode encoded) => new Cmpxchg8b(encoded);

        public struct Cmpxchg16b : ITypedInstruction<Cmpxchg16b>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cmpxchg16b(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPXCHG16B;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cmpxchg16b src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpxchg16b src) => AsmMnemonics.CMPXCHG16B;

            public static implicit operator AsmHexCode(Cmpxchg16b src) => src.Encoded;
        }

        public Cmpxchg16b cmpxchg16b() => default;

        [MethodImpl(Inline), Op]
        public Cmpxchg16b cmpxchg16b(AsmHexCode encoded) => new Cmpxchg16b(encoded);

        public struct Comisd : ITypedInstruction<Comisd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Comisd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.COMISD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Comisd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Comisd src) => AsmMnemonics.COMISD;

            public static implicit operator AsmHexCode(Comisd src) => src.Encoded;
        }

        public Comisd comisd() => default;

        [MethodImpl(Inline), Op]
        public Comisd comisd(AsmHexCode encoded) => new Comisd(encoded);

        public struct Vcomisd : ITypedInstruction<Vcomisd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcomisd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCOMISD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcomisd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcomisd src) => AsmMnemonics.VCOMISD;

            public static implicit operator AsmHexCode(Vcomisd src) => src.Encoded;
        }

        public Vcomisd vcomisd() => default;

        [MethodImpl(Inline), Op]
        public Vcomisd vcomisd(AsmHexCode encoded) => new Vcomisd(encoded);

        public struct Comiss : ITypedInstruction<Comiss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Comiss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.COMISS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Comiss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Comiss src) => AsmMnemonics.COMISS;

            public static implicit operator AsmHexCode(Comiss src) => src.Encoded;
        }

        public Comiss comiss() => default;

        [MethodImpl(Inline), Op]
        public Comiss comiss(AsmHexCode encoded) => new Comiss(encoded);

        public struct Vcomiss : ITypedInstruction<Vcomiss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcomiss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCOMISS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcomiss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcomiss src) => AsmMnemonics.VCOMISS;

            public static implicit operator AsmHexCode(Vcomiss src) => src.Encoded;
        }

        public Vcomiss vcomiss() => default;

        [MethodImpl(Inline), Op]
        public Vcomiss vcomiss(AsmHexCode encoded) => new Vcomiss(encoded);

        public struct Cpuid : ITypedInstruction<Cpuid>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cpuid(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CPUID;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cpuid src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cpuid src) => AsmMnemonics.CPUID;

            public static implicit operator AsmHexCode(Cpuid src) => src.Encoded;
        }

        public Cpuid cpuid() => default;

        [MethodImpl(Inline), Op]
        public Cpuid cpuid(AsmHexCode encoded) => new Cpuid(encoded);

        public struct Crc32 : ITypedInstruction<Crc32>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Crc32(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CRC32;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Crc32 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Crc32 src) => AsmMnemonics.CRC32;

            public static implicit operator AsmHexCode(Crc32 src) => src.Encoded;
        }

        public Crc32 crc32() => default;

        [MethodImpl(Inline), Op]
        public Crc32 crc32(AsmHexCode encoded) => new Crc32(encoded);

        public struct Cvtdq2pd : ITypedInstruction<Cvtdq2pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtdq2pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTDQ2PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtdq2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtdq2pd src) => AsmMnemonics.CVTDQ2PD;

            public static implicit operator AsmHexCode(Cvtdq2pd src) => src.Encoded;
        }

        public Cvtdq2pd cvtdq2pd() => default;

        [MethodImpl(Inline), Op]
        public Cvtdq2pd cvtdq2pd(AsmHexCode encoded) => new Cvtdq2pd(encoded);

        public struct Vcvtdq2pd : ITypedInstruction<Vcvtdq2pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtdq2pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTDQ2PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtdq2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtdq2pd src) => AsmMnemonics.VCVTDQ2PD;

            public static implicit operator AsmHexCode(Vcvtdq2pd src) => src.Encoded;
        }

        public Vcvtdq2pd vcvtdq2pd() => default;

        [MethodImpl(Inline), Op]
        public Vcvtdq2pd vcvtdq2pd(AsmHexCode encoded) => new Vcvtdq2pd(encoded);

        public struct Cvtdq2ps : ITypedInstruction<Cvtdq2ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtdq2ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTDQ2PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtdq2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtdq2ps src) => AsmMnemonics.CVTDQ2PS;

            public static implicit operator AsmHexCode(Cvtdq2ps src) => src.Encoded;
        }

        public Cvtdq2ps cvtdq2ps() => default;

        [MethodImpl(Inline), Op]
        public Cvtdq2ps cvtdq2ps(AsmHexCode encoded) => new Cvtdq2ps(encoded);

        public struct Vcvtdq2ps : ITypedInstruction<Vcvtdq2ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtdq2ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTDQ2PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtdq2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtdq2ps src) => AsmMnemonics.VCVTDQ2PS;

            public static implicit operator AsmHexCode(Vcvtdq2ps src) => src.Encoded;
        }

        public Vcvtdq2ps vcvtdq2ps() => default;

        [MethodImpl(Inline), Op]
        public Vcvtdq2ps vcvtdq2ps(AsmHexCode encoded) => new Vcvtdq2ps(encoded);

        public struct Cvtpd2dq : ITypedInstruction<Cvtpd2dq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtpd2dq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPD2DQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtpd2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpd2dq src) => AsmMnemonics.CVTPD2DQ;

            public static implicit operator AsmHexCode(Cvtpd2dq src) => src.Encoded;
        }

        public Cvtpd2dq cvtpd2dq() => default;

        [MethodImpl(Inline), Op]
        public Cvtpd2dq cvtpd2dq(AsmHexCode encoded) => new Cvtpd2dq(encoded);

        public struct Vcvtpd2dq : ITypedInstruction<Vcvtpd2dq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtpd2dq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPD2DQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtpd2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtpd2dq src) => AsmMnemonics.VCVTPD2DQ;

            public static implicit operator AsmHexCode(Vcvtpd2dq src) => src.Encoded;
        }

        public Vcvtpd2dq vcvtpd2dq() => default;

        [MethodImpl(Inline), Op]
        public Vcvtpd2dq vcvtpd2dq(AsmHexCode encoded) => new Vcvtpd2dq(encoded);

        public struct Cvtpd2pi : ITypedInstruction<Cvtpd2pi>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtpd2pi(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPD2PI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtpd2pi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpd2pi src) => AsmMnemonics.CVTPD2PI;

            public static implicit operator AsmHexCode(Cvtpd2pi src) => src.Encoded;
        }

        public Cvtpd2pi cvtpd2pi() => default;

        [MethodImpl(Inline), Op]
        public Cvtpd2pi cvtpd2pi(AsmHexCode encoded) => new Cvtpd2pi(encoded);

        public struct Cvtpd2ps : ITypedInstruction<Cvtpd2ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtpd2ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPD2PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtpd2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpd2ps src) => AsmMnemonics.CVTPD2PS;

            public static implicit operator AsmHexCode(Cvtpd2ps src) => src.Encoded;
        }

        public Cvtpd2ps cvtpd2ps() => default;

        [MethodImpl(Inline), Op]
        public Cvtpd2ps cvtpd2ps(AsmHexCode encoded) => new Cvtpd2ps(encoded);

        public struct Vcvtpd2ps : ITypedInstruction<Vcvtpd2ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtpd2ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPD2PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtpd2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtpd2ps src) => AsmMnemonics.VCVTPD2PS;

            public static implicit operator AsmHexCode(Vcvtpd2ps src) => src.Encoded;
        }

        public Vcvtpd2ps vcvtpd2ps() => default;

        [MethodImpl(Inline), Op]
        public Vcvtpd2ps vcvtpd2ps(AsmHexCode encoded) => new Vcvtpd2ps(encoded);

        public struct Cvtpi2pd : ITypedInstruction<Cvtpi2pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtpi2pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPI2PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtpi2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpi2pd src) => AsmMnemonics.CVTPI2PD;

            public static implicit operator AsmHexCode(Cvtpi2pd src) => src.Encoded;
        }

        public Cvtpi2pd cvtpi2pd() => default;

        [MethodImpl(Inline), Op]
        public Cvtpi2pd cvtpi2pd(AsmHexCode encoded) => new Cvtpi2pd(encoded);

        public struct Cvtpi2ps : ITypedInstruction<Cvtpi2ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtpi2ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPI2PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtpi2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpi2ps src) => AsmMnemonics.CVTPI2PS;

            public static implicit operator AsmHexCode(Cvtpi2ps src) => src.Encoded;
        }

        public Cvtpi2ps cvtpi2ps() => default;

        [MethodImpl(Inline), Op]
        public Cvtpi2ps cvtpi2ps(AsmHexCode encoded) => new Cvtpi2ps(encoded);

        public struct Cvtps2dq : ITypedInstruction<Cvtps2dq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtps2dq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPS2DQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtps2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtps2dq src) => AsmMnemonics.CVTPS2DQ;

            public static implicit operator AsmHexCode(Cvtps2dq src) => src.Encoded;
        }

        public Cvtps2dq cvtps2dq() => default;

        [MethodImpl(Inline), Op]
        public Cvtps2dq cvtps2dq(AsmHexCode encoded) => new Cvtps2dq(encoded);

        public struct Vcvtps2dq : ITypedInstruction<Vcvtps2dq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtps2dq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPS2DQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtps2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtps2dq src) => AsmMnemonics.VCVTPS2DQ;

            public static implicit operator AsmHexCode(Vcvtps2dq src) => src.Encoded;
        }

        public Vcvtps2dq vcvtps2dq() => default;

        [MethodImpl(Inline), Op]
        public Vcvtps2dq vcvtps2dq(AsmHexCode encoded) => new Vcvtps2dq(encoded);

        public struct Cvtps2pd : ITypedInstruction<Cvtps2pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtps2pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPS2PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtps2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtps2pd src) => AsmMnemonics.CVTPS2PD;

            public static implicit operator AsmHexCode(Cvtps2pd src) => src.Encoded;
        }

        public Cvtps2pd cvtps2pd() => default;

        [MethodImpl(Inline), Op]
        public Cvtps2pd cvtps2pd(AsmHexCode encoded) => new Cvtps2pd(encoded);

        public struct Vcvtps2pd : ITypedInstruction<Vcvtps2pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtps2pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPS2PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtps2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtps2pd src) => AsmMnemonics.VCVTPS2PD;

            public static implicit operator AsmHexCode(Vcvtps2pd src) => src.Encoded;
        }

        public Vcvtps2pd vcvtps2pd() => default;

        [MethodImpl(Inline), Op]
        public Vcvtps2pd vcvtps2pd(AsmHexCode encoded) => new Vcvtps2pd(encoded);

        public struct Cvtps2pi : ITypedInstruction<Cvtps2pi>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtps2pi(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPS2PI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtps2pi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtps2pi src) => AsmMnemonics.CVTPS2PI;

            public static implicit operator AsmHexCode(Cvtps2pi src) => src.Encoded;
        }

        public Cvtps2pi cvtps2pi() => default;

        [MethodImpl(Inline), Op]
        public Cvtps2pi cvtps2pi(AsmHexCode encoded) => new Cvtps2pi(encoded);

        public struct Cvtsd2si : ITypedInstruction<Cvtsd2si>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtsd2si(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSD2SI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtsd2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtsd2si src) => AsmMnemonics.CVTSD2SI;

            public static implicit operator AsmHexCode(Cvtsd2si src) => src.Encoded;
        }

        public Cvtsd2si cvtsd2si() => default;

        [MethodImpl(Inline), Op]
        public Cvtsd2si cvtsd2si(AsmHexCode encoded) => new Cvtsd2si(encoded);

        public struct Vcvtsd2si : ITypedInstruction<Vcvtsd2si>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtsd2si(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSD2SI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtsd2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtsd2si src) => AsmMnemonics.VCVTSD2SI;

            public static implicit operator AsmHexCode(Vcvtsd2si src) => src.Encoded;
        }

        public Vcvtsd2si vcvtsd2si() => default;

        [MethodImpl(Inline), Op]
        public Vcvtsd2si vcvtsd2si(AsmHexCode encoded) => new Vcvtsd2si(encoded);

        public struct Cvtsd2ss : ITypedInstruction<Cvtsd2ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtsd2ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSD2SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtsd2ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtsd2ss src) => AsmMnemonics.CVTSD2SS;

            public static implicit operator AsmHexCode(Cvtsd2ss src) => src.Encoded;
        }

        public Cvtsd2ss cvtsd2ss() => default;

        [MethodImpl(Inline), Op]
        public Cvtsd2ss cvtsd2ss(AsmHexCode encoded) => new Cvtsd2ss(encoded);

        public struct Vcvtsd2ss : ITypedInstruction<Vcvtsd2ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtsd2ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSD2SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtsd2ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtsd2ss src) => AsmMnemonics.VCVTSD2SS;

            public static implicit operator AsmHexCode(Vcvtsd2ss src) => src.Encoded;
        }

        public Vcvtsd2ss vcvtsd2ss() => default;

        [MethodImpl(Inline), Op]
        public Vcvtsd2ss vcvtsd2ss(AsmHexCode encoded) => new Vcvtsd2ss(encoded);

        public struct Cvtsi2sd : ITypedInstruction<Cvtsi2sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtsi2sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSI2SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtsi2sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtsi2sd src) => AsmMnemonics.CVTSI2SD;

            public static implicit operator AsmHexCode(Cvtsi2sd src) => src.Encoded;
        }

        public Cvtsi2sd cvtsi2sd() => default;

        [MethodImpl(Inline), Op]
        public Cvtsi2sd cvtsi2sd(AsmHexCode encoded) => new Cvtsi2sd(encoded);

        public struct Vcvtsi2sd : ITypedInstruction<Vcvtsi2sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtsi2sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSI2SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtsi2sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtsi2sd src) => AsmMnemonics.VCVTSI2SD;

            public static implicit operator AsmHexCode(Vcvtsi2sd src) => src.Encoded;
        }

        public Vcvtsi2sd vcvtsi2sd() => default;

        [MethodImpl(Inline), Op]
        public Vcvtsi2sd vcvtsi2sd(AsmHexCode encoded) => new Vcvtsi2sd(encoded);

        public struct Cvtsi2ss : ITypedInstruction<Cvtsi2ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtsi2ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSI2SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtsi2ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtsi2ss src) => AsmMnemonics.CVTSI2SS;

            public static implicit operator AsmHexCode(Cvtsi2ss src) => src.Encoded;
        }

        public Cvtsi2ss cvtsi2ss() => default;

        [MethodImpl(Inline), Op]
        public Cvtsi2ss cvtsi2ss(AsmHexCode encoded) => new Cvtsi2ss(encoded);

        public struct Vcvtsi2ss : ITypedInstruction<Vcvtsi2ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtsi2ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSI2SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtsi2ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtsi2ss src) => AsmMnemonics.VCVTSI2SS;

            public static implicit operator AsmHexCode(Vcvtsi2ss src) => src.Encoded;
        }

        public Vcvtsi2ss vcvtsi2ss() => default;

        [MethodImpl(Inline), Op]
        public Vcvtsi2ss vcvtsi2ss(AsmHexCode encoded) => new Vcvtsi2ss(encoded);

        public struct Cvtss2sd : ITypedInstruction<Cvtss2sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtss2sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSS2SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtss2sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtss2sd src) => AsmMnemonics.CVTSS2SD;

            public static implicit operator AsmHexCode(Cvtss2sd src) => src.Encoded;
        }

        public Cvtss2sd cvtss2sd() => default;

        [MethodImpl(Inline), Op]
        public Cvtss2sd cvtss2sd(AsmHexCode encoded) => new Cvtss2sd(encoded);

        public struct Vcvtss2sd : ITypedInstruction<Vcvtss2sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtss2sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSS2SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtss2sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtss2sd src) => AsmMnemonics.VCVTSS2SD;

            public static implicit operator AsmHexCode(Vcvtss2sd src) => src.Encoded;
        }

        public Vcvtss2sd vcvtss2sd() => default;

        [MethodImpl(Inline), Op]
        public Vcvtss2sd vcvtss2sd(AsmHexCode encoded) => new Vcvtss2sd(encoded);

        public struct Cvtss2si : ITypedInstruction<Cvtss2si>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvtss2si(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSS2SI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvtss2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtss2si src) => AsmMnemonics.CVTSS2SI;

            public static implicit operator AsmHexCode(Cvtss2si src) => src.Encoded;
        }

        public Cvtss2si cvtss2si() => default;

        [MethodImpl(Inline), Op]
        public Cvtss2si cvtss2si(AsmHexCode encoded) => new Cvtss2si(encoded);

        public struct Vcvtss2si : ITypedInstruction<Vcvtss2si>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtss2si(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSS2SI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtss2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtss2si src) => AsmMnemonics.VCVTSS2SI;

            public static implicit operator AsmHexCode(Vcvtss2si src) => src.Encoded;
        }

        public Vcvtss2si vcvtss2si() => default;

        [MethodImpl(Inline), Op]
        public Vcvtss2si vcvtss2si(AsmHexCode encoded) => new Vcvtss2si(encoded);

        public struct Cvttpd2dq : ITypedInstruction<Cvttpd2dq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvttpd2dq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPD2DQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvttpd2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttpd2dq src) => AsmMnemonics.CVTTPD2DQ;

            public static implicit operator AsmHexCode(Cvttpd2dq src) => src.Encoded;
        }

        public Cvttpd2dq cvttpd2dq() => default;

        [MethodImpl(Inline), Op]
        public Cvttpd2dq cvttpd2dq(AsmHexCode encoded) => new Cvttpd2dq(encoded);

        public struct Vcvttpd2dq : ITypedInstruction<Vcvttpd2dq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvttpd2dq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTPD2DQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvttpd2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvttpd2dq src) => AsmMnemonics.VCVTTPD2DQ;

            public static implicit operator AsmHexCode(Vcvttpd2dq src) => src.Encoded;
        }

        public Vcvttpd2dq vcvttpd2dq() => default;

        [MethodImpl(Inline), Op]
        public Vcvttpd2dq vcvttpd2dq(AsmHexCode encoded) => new Vcvttpd2dq(encoded);

        public struct Cvttpd2pi : ITypedInstruction<Cvttpd2pi>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvttpd2pi(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPD2PI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvttpd2pi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttpd2pi src) => AsmMnemonics.CVTTPD2PI;

            public static implicit operator AsmHexCode(Cvttpd2pi src) => src.Encoded;
        }

        public Cvttpd2pi cvttpd2pi() => default;

        [MethodImpl(Inline), Op]
        public Cvttpd2pi cvttpd2pi(AsmHexCode encoded) => new Cvttpd2pi(encoded);

        public struct Cvttps2dq : ITypedInstruction<Cvttps2dq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvttps2dq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPS2DQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvttps2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttps2dq src) => AsmMnemonics.CVTTPS2DQ;

            public static implicit operator AsmHexCode(Cvttps2dq src) => src.Encoded;
        }

        public Cvttps2dq cvttps2dq() => default;

        [MethodImpl(Inline), Op]
        public Cvttps2dq cvttps2dq(AsmHexCode encoded) => new Cvttps2dq(encoded);

        public struct Vcvttps2dq : ITypedInstruction<Vcvttps2dq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvttps2dq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTPS2DQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvttps2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvttps2dq src) => AsmMnemonics.VCVTTPS2DQ;

            public static implicit operator AsmHexCode(Vcvttps2dq src) => src.Encoded;
        }

        public Vcvttps2dq vcvttps2dq() => default;

        [MethodImpl(Inline), Op]
        public Vcvttps2dq vcvttps2dq(AsmHexCode encoded) => new Vcvttps2dq(encoded);

        public struct Cvttps2pi : ITypedInstruction<Cvttps2pi>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvttps2pi(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPS2PI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvttps2pi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttps2pi src) => AsmMnemonics.CVTTPS2PI;

            public static implicit operator AsmHexCode(Cvttps2pi src) => src.Encoded;
        }

        public Cvttps2pi cvttps2pi() => default;

        [MethodImpl(Inline), Op]
        public Cvttps2pi cvttps2pi(AsmHexCode encoded) => new Cvttps2pi(encoded);

        public struct Cvttsd2si : ITypedInstruction<Cvttsd2si>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvttsd2si(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTSD2SI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvttsd2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttsd2si src) => AsmMnemonics.CVTTSD2SI;

            public static implicit operator AsmHexCode(Cvttsd2si src) => src.Encoded;
        }

        public Cvttsd2si cvttsd2si() => default;

        [MethodImpl(Inline), Op]
        public Cvttsd2si cvttsd2si(AsmHexCode encoded) => new Cvttsd2si(encoded);

        public struct Vcvttsd2si : ITypedInstruction<Vcvttsd2si>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvttsd2si(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTSD2SI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvttsd2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvttsd2si src) => AsmMnemonics.VCVTTSD2SI;

            public static implicit operator AsmHexCode(Vcvttsd2si src) => src.Encoded;
        }

        public Vcvttsd2si vcvttsd2si() => default;

        [MethodImpl(Inline), Op]
        public Vcvttsd2si vcvttsd2si(AsmHexCode encoded) => new Vcvttsd2si(encoded);

        public struct Cvttss2si : ITypedInstruction<Cvttss2si>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cvttss2si(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTSS2SI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cvttss2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttss2si src) => AsmMnemonics.CVTTSS2SI;

            public static implicit operator AsmHexCode(Cvttss2si src) => src.Encoded;
        }

        public Cvttss2si cvttss2si() => default;

        [MethodImpl(Inline), Op]
        public Cvttss2si cvttss2si(AsmHexCode encoded) => new Cvttss2si(encoded);

        public struct Vcvttss2si : ITypedInstruction<Vcvttss2si>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvttss2si(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTSS2SI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvttss2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvttss2si src) => AsmMnemonics.VCVTTSS2SI;

            public static implicit operator AsmHexCode(Vcvttss2si src) => src.Encoded;
        }

        public Vcvttss2si vcvttss2si() => default;

        [MethodImpl(Inline), Op]
        public Vcvttss2si vcvttss2si(AsmHexCode encoded) => new Vcvttss2si(encoded);

        public struct Cwd : ITypedInstruction<Cwd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cwd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CWD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cwd src) => AsmMnemonics.CWD;

            public static implicit operator AsmHexCode(Cwd src) => src.Encoded;
        }

        public Cwd cwd() => default;

        [MethodImpl(Inline), Op]
        public Cwd cwd(AsmHexCode encoded) => new Cwd(encoded);

        public struct Cdq : ITypedInstruction<Cdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cdq src) => AsmMnemonics.CDQ;

            public static implicit operator AsmHexCode(Cdq src) => src.Encoded;
        }

        public Cdq cdq() => default;

        [MethodImpl(Inline), Op]
        public Cdq cdq(AsmHexCode encoded) => new Cdq(encoded);

        public struct Cqo : ITypedInstruction<Cqo>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Cqo(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CQO;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Cqo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cqo src) => AsmMnemonics.CQO;

            public static implicit operator AsmHexCode(Cqo src) => src.Encoded;
        }

        public Cqo cqo() => default;

        [MethodImpl(Inline), Op]
        public Cqo cqo(AsmHexCode encoded) => new Cqo(encoded);

        public struct Daa : ITypedInstruction<Daa>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Daa(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DAA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Daa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Daa src) => AsmMnemonics.DAA;

            public static implicit operator AsmHexCode(Daa src) => src.Encoded;
        }

        public Daa daa() => default;

        [MethodImpl(Inline), Op]
        public Daa daa(AsmHexCode encoded) => new Daa(encoded);

        public struct Das : ITypedInstruction<Das>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Das(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DAS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Das src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Das src) => AsmMnemonics.DAS;

            public static implicit operator AsmHexCode(Das src) => src.Encoded;
        }

        public Das das() => default;

        [MethodImpl(Inline), Op]
        public Das das(AsmHexCode encoded) => new Das(encoded);

        public struct Dec : ITypedInstruction<Dec>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Dec(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DEC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Dec src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Dec src) => AsmMnemonics.DEC;

            public static implicit operator AsmHexCode(Dec src) => src.Encoded;
        }

        public Dec dec() => default;

        [MethodImpl(Inline), Op]
        public Dec dec(AsmHexCode encoded) => new Dec(encoded);

        public struct Div : ITypedInstruction<Div>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Div(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIV;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Div src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Div src) => AsmMnemonics.DIV;

            public static implicit operator AsmHexCode(Div src) => src.Encoded;
        }

        public Div div() => default;

        [MethodImpl(Inline), Op]
        public Div div(AsmHexCode encoded) => new Div(encoded);

        public struct Divpd : ITypedInstruction<Divpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Divpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Divpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Divpd src) => AsmMnemonics.DIVPD;

            public static implicit operator AsmHexCode(Divpd src) => src.Encoded;
        }

        public Divpd divpd() => default;

        [MethodImpl(Inline), Op]
        public Divpd divpd(AsmHexCode encoded) => new Divpd(encoded);

        public struct Vdivpd : ITypedInstruction<Vdivpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vdivpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vdivpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdivpd src) => AsmMnemonics.VDIVPD;

            public static implicit operator AsmHexCode(Vdivpd src) => src.Encoded;
        }

        public Vdivpd vdivpd() => default;

        [MethodImpl(Inline), Op]
        public Vdivpd vdivpd(AsmHexCode encoded) => new Vdivpd(encoded);

        public struct Divps : ITypedInstruction<Divps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Divps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Divps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Divps src) => AsmMnemonics.DIVPS;

            public static implicit operator AsmHexCode(Divps src) => src.Encoded;
        }

        public Divps divps() => default;

        [MethodImpl(Inline), Op]
        public Divps divps(AsmHexCode encoded) => new Divps(encoded);

        public struct Vdivps : ITypedInstruction<Vdivps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vdivps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vdivps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdivps src) => AsmMnemonics.VDIVPS;

            public static implicit operator AsmHexCode(Vdivps src) => src.Encoded;
        }

        public Vdivps vdivps() => default;

        [MethodImpl(Inline), Op]
        public Vdivps vdivps(AsmHexCode encoded) => new Vdivps(encoded);

        public struct Divsd : ITypedInstruction<Divsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Divsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Divsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Divsd src) => AsmMnemonics.DIVSD;

            public static implicit operator AsmHexCode(Divsd src) => src.Encoded;
        }

        public Divsd divsd() => default;

        [MethodImpl(Inline), Op]
        public Divsd divsd(AsmHexCode encoded) => new Divsd(encoded);

        public struct Vdivsd : ITypedInstruction<Vdivsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vdivsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vdivsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdivsd src) => AsmMnemonics.VDIVSD;

            public static implicit operator AsmHexCode(Vdivsd src) => src.Encoded;
        }

        public Vdivsd vdivsd() => default;

        [MethodImpl(Inline), Op]
        public Vdivsd vdivsd(AsmHexCode encoded) => new Vdivsd(encoded);

        public struct Divss : ITypedInstruction<Divss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Divss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Divss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Divss src) => AsmMnemonics.DIVSS;

            public static implicit operator AsmHexCode(Divss src) => src.Encoded;
        }

        public Divss divss() => default;

        [MethodImpl(Inline), Op]
        public Divss divss(AsmHexCode encoded) => new Divss(encoded);

        public struct Vdivss : ITypedInstruction<Vdivss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vdivss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vdivss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdivss src) => AsmMnemonics.VDIVSS;

            public static implicit operator AsmHexCode(Vdivss src) => src.Encoded;
        }

        public Vdivss vdivss() => default;

        [MethodImpl(Inline), Op]
        public Vdivss vdivss(AsmHexCode encoded) => new Vdivss(encoded);

        public struct Dppd : ITypedInstruction<Dppd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Dppd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DPPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Dppd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Dppd src) => AsmMnemonics.DPPD;

            public static implicit operator AsmHexCode(Dppd src) => src.Encoded;
        }

        public Dppd dppd() => default;

        [MethodImpl(Inline), Op]
        public Dppd dppd(AsmHexCode encoded) => new Dppd(encoded);

        public struct Vdppd : ITypedInstruction<Vdppd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vdppd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDPPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vdppd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdppd src) => AsmMnemonics.VDPPD;

            public static implicit operator AsmHexCode(Vdppd src) => src.Encoded;
        }

        public Vdppd vdppd() => default;

        [MethodImpl(Inline), Op]
        public Vdppd vdppd(AsmHexCode encoded) => new Vdppd(encoded);

        public struct Dpps : ITypedInstruction<Dpps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Dpps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DPPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Dpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Dpps src) => AsmMnemonics.DPPS;

            public static implicit operator AsmHexCode(Dpps src) => src.Encoded;
        }

        public Dpps dpps() => default;

        [MethodImpl(Inline), Op]
        public Dpps dpps(AsmHexCode encoded) => new Dpps(encoded);

        public struct Vdpps : ITypedInstruction<Vdpps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vdpps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDPPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vdpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdpps src) => AsmMnemonics.VDPPS;

            public static implicit operator AsmHexCode(Vdpps src) => src.Encoded;
        }

        public Vdpps vdpps() => default;

        [MethodImpl(Inline), Op]
        public Vdpps vdpps(AsmHexCode encoded) => new Vdpps(encoded);

        public struct Emms : ITypedInstruction<Emms>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Emms(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.EMMS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Emms src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Emms src) => AsmMnemonics.EMMS;

            public static implicit operator AsmHexCode(Emms src) => src.Encoded;
        }

        public Emms emms() => default;

        [MethodImpl(Inline), Op]
        public Emms emms(AsmHexCode encoded) => new Emms(encoded);

        public struct Enter : ITypedInstruction<Enter>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Enter(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ENTER;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Enter src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Enter src) => AsmMnemonics.ENTER;

            public static implicit operator AsmHexCode(Enter src) => src.Encoded;
        }

        public Enter enter() => default;

        [MethodImpl(Inline), Op]
        public Enter enter(AsmHexCode encoded) => new Enter(encoded);

        public struct Extractps : ITypedInstruction<Extractps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Extractps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.EXTRACTPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Extractps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Extractps src) => AsmMnemonics.EXTRACTPS;

            public static implicit operator AsmHexCode(Extractps src) => src.Encoded;
        }

        public Extractps extractps() => default;

        [MethodImpl(Inline), Op]
        public Extractps extractps(AsmHexCode encoded) => new Extractps(encoded);

        public struct Vextractps : ITypedInstruction<Vextractps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vextractps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VEXTRACTPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vextractps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vextractps src) => AsmMnemonics.VEXTRACTPS;

            public static implicit operator AsmHexCode(Vextractps src) => src.Encoded;
        }

        public Vextractps vextractps() => default;

        [MethodImpl(Inline), Op]
        public Vextractps vextractps(AsmHexCode encoded) => new Vextractps(encoded);

        public struct F2xm1 : ITypedInstruction<F2xm1>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public F2xm1(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.F2XM1;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(F2xm1 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(F2xm1 src) => AsmMnemonics.F2XM1;

            public static implicit operator AsmHexCode(F2xm1 src) => src.Encoded;
        }

        public F2xm1 f2xm1() => default;

        [MethodImpl(Inline), Op]
        public F2xm1 f2xm1(AsmHexCode encoded) => new F2xm1(encoded);

        public struct Fabs : ITypedInstruction<Fabs>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fabs(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FABS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fabs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fabs src) => AsmMnemonics.FABS;

            public static implicit operator AsmHexCode(Fabs src) => src.Encoded;
        }

        public Fabs fabs() => default;

        [MethodImpl(Inline), Op]
        public Fabs fabs(AsmHexCode encoded) => new Fabs(encoded);

        public struct Fadd : ITypedInstruction<Fadd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fadd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FADD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fadd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fadd src) => AsmMnemonics.FADD;

            public static implicit operator AsmHexCode(Fadd src) => src.Encoded;
        }

        public Fadd fadd() => default;

        [MethodImpl(Inline), Op]
        public Fadd fadd(AsmHexCode encoded) => new Fadd(encoded);

        public struct Faddp : ITypedInstruction<Faddp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Faddp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FADDP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Faddp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Faddp src) => AsmMnemonics.FADDP;

            public static implicit operator AsmHexCode(Faddp src) => src.Encoded;
        }

        public Faddp faddp() => default;

        [MethodImpl(Inline), Op]
        public Faddp faddp(AsmHexCode encoded) => new Faddp(encoded);

        public struct Fiadd : ITypedInstruction<Fiadd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fiadd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIADD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fiadd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fiadd src) => AsmMnemonics.FIADD;

            public static implicit operator AsmHexCode(Fiadd src) => src.Encoded;
        }

        public Fiadd fiadd() => default;

        [MethodImpl(Inline), Op]
        public Fiadd fiadd(AsmHexCode encoded) => new Fiadd(encoded);

        public struct Fbld : ITypedInstruction<Fbld>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fbld(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FBLD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fbld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fbld src) => AsmMnemonics.FBLD;

            public static implicit operator AsmHexCode(Fbld src) => src.Encoded;
        }

        public Fbld fbld() => default;

        [MethodImpl(Inline), Op]
        public Fbld fbld(AsmHexCode encoded) => new Fbld(encoded);

        public struct Fbstp : ITypedInstruction<Fbstp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fbstp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FBSTP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fbstp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fbstp src) => AsmMnemonics.FBSTP;

            public static implicit operator AsmHexCode(Fbstp src) => src.Encoded;
        }

        public Fbstp fbstp() => default;

        [MethodImpl(Inline), Op]
        public Fbstp fbstp(AsmHexCode encoded) => new Fbstp(encoded);

        public struct Fchs : ITypedInstruction<Fchs>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fchs(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCHS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fchs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fchs src) => AsmMnemonics.FCHS;

            public static implicit operator AsmHexCode(Fchs src) => src.Encoded;
        }

        public Fchs fchs() => default;

        [MethodImpl(Inline), Op]
        public Fchs fchs(AsmHexCode encoded) => new Fchs(encoded);

        public struct Fclex : ITypedInstruction<Fclex>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fclex(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCLEX;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fclex src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fclex src) => AsmMnemonics.FCLEX;

            public static implicit operator AsmHexCode(Fclex src) => src.Encoded;
        }

        public Fclex fclex() => default;

        [MethodImpl(Inline), Op]
        public Fclex fclex(AsmHexCode encoded) => new Fclex(encoded);

        public struct Fnclex : ITypedInstruction<Fnclex>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fnclex(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNCLEX;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fnclex src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnclex src) => AsmMnemonics.FNCLEX;

            public static implicit operator AsmHexCode(Fnclex src) => src.Encoded;
        }

        public Fnclex fnclex() => default;

        [MethodImpl(Inline), Op]
        public Fnclex fnclex(AsmHexCode encoded) => new Fnclex(encoded);

        public struct Fcmovb : ITypedInstruction<Fcmovb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcmovb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcmovb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovb src) => AsmMnemonics.FCMOVB;

            public static implicit operator AsmHexCode(Fcmovb src) => src.Encoded;
        }

        public Fcmovb fcmovb() => default;

        [MethodImpl(Inline), Op]
        public Fcmovb fcmovb(AsmHexCode encoded) => new Fcmovb(encoded);

        public struct Fcmove : ITypedInstruction<Fcmove>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcmove(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcmove src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmove src) => AsmMnemonics.FCMOVE;

            public static implicit operator AsmHexCode(Fcmove src) => src.Encoded;
        }

        public Fcmove fcmove() => default;

        [MethodImpl(Inline), Op]
        public Fcmove fcmove(AsmHexCode encoded) => new Fcmove(encoded);

        public struct Fcmovbe : ITypedInstruction<Fcmovbe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcmovbe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVBE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcmovbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovbe src) => AsmMnemonics.FCMOVBE;

            public static implicit operator AsmHexCode(Fcmovbe src) => src.Encoded;
        }

        public Fcmovbe fcmovbe() => default;

        [MethodImpl(Inline), Op]
        public Fcmovbe fcmovbe(AsmHexCode encoded) => new Fcmovbe(encoded);

        public struct Fcmovu : ITypedInstruction<Fcmovu>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcmovu(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVU;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcmovu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovu src) => AsmMnemonics.FCMOVU;

            public static implicit operator AsmHexCode(Fcmovu src) => src.Encoded;
        }

        public Fcmovu fcmovu() => default;

        [MethodImpl(Inline), Op]
        public Fcmovu fcmovu(AsmHexCode encoded) => new Fcmovu(encoded);

        public struct Fcmovnb : ITypedInstruction<Fcmovnb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcmovnb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcmovnb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovnb src) => AsmMnemonics.FCMOVNB;

            public static implicit operator AsmHexCode(Fcmovnb src) => src.Encoded;
        }

        public Fcmovnb fcmovnb() => default;

        [MethodImpl(Inline), Op]
        public Fcmovnb fcmovnb(AsmHexCode encoded) => new Fcmovnb(encoded);

        public struct Fcmovne : ITypedInstruction<Fcmovne>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcmovne(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcmovne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovne src) => AsmMnemonics.FCMOVNE;

            public static implicit operator AsmHexCode(Fcmovne src) => src.Encoded;
        }

        public Fcmovne fcmovne() => default;

        [MethodImpl(Inline), Op]
        public Fcmovne fcmovne(AsmHexCode encoded) => new Fcmovne(encoded);

        public struct Fcmovnbe : ITypedInstruction<Fcmovnbe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcmovnbe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNBE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcmovnbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovnbe src) => AsmMnemonics.FCMOVNBE;

            public static implicit operator AsmHexCode(Fcmovnbe src) => src.Encoded;
        }

        public Fcmovnbe fcmovnbe() => default;

        [MethodImpl(Inline), Op]
        public Fcmovnbe fcmovnbe(AsmHexCode encoded) => new Fcmovnbe(encoded);

        public struct Fcmovnu : ITypedInstruction<Fcmovnu>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcmovnu(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNU;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcmovnu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovnu src) => AsmMnemonics.FCMOVNU;

            public static implicit operator AsmHexCode(Fcmovnu src) => src.Encoded;
        }

        public Fcmovnu fcmovnu() => default;

        [MethodImpl(Inline), Op]
        public Fcmovnu fcmovnu(AsmHexCode encoded) => new Fcmovnu(encoded);

        public struct Fcom : ITypedInstruction<Fcom>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcom(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOM;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcom src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcom src) => AsmMnemonics.FCOM;

            public static implicit operator AsmHexCode(Fcom src) => src.Encoded;
        }

        public Fcom fcom() => default;

        [MethodImpl(Inline), Op]
        public Fcom fcom(AsmHexCode encoded) => new Fcom(encoded);

        public struct Fcomp : ITypedInstruction<Fcomp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcomp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcomp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcomp src) => AsmMnemonics.FCOMP;

            public static implicit operator AsmHexCode(Fcomp src) => src.Encoded;
        }

        public Fcomp fcomp() => default;

        [MethodImpl(Inline), Op]
        public Fcomp fcomp(AsmHexCode encoded) => new Fcomp(encoded);

        public struct Fcompp : ITypedInstruction<Fcompp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcompp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMPP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcompp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcompp src) => AsmMnemonics.FCOMPP;

            public static implicit operator AsmHexCode(Fcompp src) => src.Encoded;
        }

        public Fcompp fcompp() => default;

        [MethodImpl(Inline), Op]
        public Fcompp fcompp(AsmHexCode encoded) => new Fcompp(encoded);

        public struct Fcomi : ITypedInstruction<Fcomi>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcomi(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcomi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcomi src) => AsmMnemonics.FCOMI;

            public static implicit operator AsmHexCode(Fcomi src) => src.Encoded;
        }

        public Fcomi fcomi() => default;

        [MethodImpl(Inline), Op]
        public Fcomi fcomi(AsmHexCode encoded) => new Fcomi(encoded);

        public struct Fcomip : ITypedInstruction<Fcomip>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcomip(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMIP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcomip src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcomip src) => AsmMnemonics.FCOMIP;

            public static implicit operator AsmHexCode(Fcomip src) => src.Encoded;
        }

        public Fcomip fcomip() => default;

        [MethodImpl(Inline), Op]
        public Fcomip fcomip(AsmHexCode encoded) => new Fcomip(encoded);

        public struct Fucomi : ITypedInstruction<Fucomi>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fucomi(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fucomi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucomi src) => AsmMnemonics.FUCOMI;

            public static implicit operator AsmHexCode(Fucomi src) => src.Encoded;
        }

        public Fucomi fucomi() => default;

        [MethodImpl(Inline), Op]
        public Fucomi fucomi(AsmHexCode encoded) => new Fucomi(encoded);

        public struct Fucomip : ITypedInstruction<Fucomip>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fucomip(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMIP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fucomip src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucomip src) => AsmMnemonics.FUCOMIP;

            public static implicit operator AsmHexCode(Fucomip src) => src.Encoded;
        }

        public Fucomip fucomip() => default;

        [MethodImpl(Inline), Op]
        public Fucomip fucomip(AsmHexCode encoded) => new Fucomip(encoded);

        public struct Fcos : ITypedInstruction<Fcos>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fcos(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fcos src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcos src) => AsmMnemonics.FCOS;

            public static implicit operator AsmHexCode(Fcos src) => src.Encoded;
        }

        public Fcos fcos() => default;

        [MethodImpl(Inline), Op]
        public Fcos fcos(AsmHexCode encoded) => new Fcos(encoded);

        public struct Fdecstp : ITypedInstruction<Fdecstp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fdecstp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDECSTP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fdecstp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdecstp src) => AsmMnemonics.FDECSTP;

            public static implicit operator AsmHexCode(Fdecstp src) => src.Encoded;
        }

        public Fdecstp fdecstp() => default;

        [MethodImpl(Inline), Op]
        public Fdecstp fdecstp(AsmHexCode encoded) => new Fdecstp(encoded);

        public struct Fdiv : ITypedInstruction<Fdiv>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fdiv(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIV;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fdiv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdiv src) => AsmMnemonics.FDIV;

            public static implicit operator AsmHexCode(Fdiv src) => src.Encoded;
        }

        public Fdiv fdiv() => default;

        [MethodImpl(Inline), Op]
        public Fdiv fdiv(AsmHexCode encoded) => new Fdiv(encoded);

        public struct Fdivp : ITypedInstruction<Fdivp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fdivp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIVP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fdivp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdivp src) => AsmMnemonics.FDIVP;

            public static implicit operator AsmHexCode(Fdivp src) => src.Encoded;
        }

        public Fdivp fdivp() => default;

        [MethodImpl(Inline), Op]
        public Fdivp fdivp(AsmHexCode encoded) => new Fdivp(encoded);

        public struct Fidiv : ITypedInstruction<Fidiv>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fidiv(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIDIV;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fidiv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fidiv src) => AsmMnemonics.FIDIV;

            public static implicit operator AsmHexCode(Fidiv src) => src.Encoded;
        }

        public Fidiv fidiv() => default;

        [MethodImpl(Inline), Op]
        public Fidiv fidiv(AsmHexCode encoded) => new Fidiv(encoded);

        public struct Fdivr : ITypedInstruction<Fdivr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fdivr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIVR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fdivr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdivr src) => AsmMnemonics.FDIVR;

            public static implicit operator AsmHexCode(Fdivr src) => src.Encoded;
        }

        public Fdivr fdivr() => default;

        [MethodImpl(Inline), Op]
        public Fdivr fdivr(AsmHexCode encoded) => new Fdivr(encoded);

        public struct Fdivrp : ITypedInstruction<Fdivrp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fdivrp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIVRP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fdivrp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdivrp src) => AsmMnemonics.FDIVRP;

            public static implicit operator AsmHexCode(Fdivrp src) => src.Encoded;
        }

        public Fdivrp fdivrp() => default;

        [MethodImpl(Inline), Op]
        public Fdivrp fdivrp(AsmHexCode encoded) => new Fdivrp(encoded);

        public struct Fidivr : ITypedInstruction<Fidivr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fidivr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIDIVR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fidivr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fidivr src) => AsmMnemonics.FIDIVR;

            public static implicit operator AsmHexCode(Fidivr src) => src.Encoded;
        }

        public Fidivr fidivr() => default;

        [MethodImpl(Inline), Op]
        public Fidivr fidivr(AsmHexCode encoded) => new Fidivr(encoded);

        public struct Ffree : ITypedInstruction<Ffree>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ffree(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FFREE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ffree src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ffree src) => AsmMnemonics.FFREE;

            public static implicit operator AsmHexCode(Ffree src) => src.Encoded;
        }

        public Ffree ffree() => default;

        [MethodImpl(Inline), Op]
        public Ffree ffree(AsmHexCode encoded) => new Ffree(encoded);

        public struct Ficom : ITypedInstruction<Ficom>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ficom(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FICOM;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ficom src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ficom src) => AsmMnemonics.FICOM;

            public static implicit operator AsmHexCode(Ficom src) => src.Encoded;
        }

        public Ficom ficom() => default;

        [MethodImpl(Inline), Op]
        public Ficom ficom(AsmHexCode encoded) => new Ficom(encoded);

        public struct Ficomp : ITypedInstruction<Ficomp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ficomp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FICOMP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ficomp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ficomp src) => AsmMnemonics.FICOMP;

            public static implicit operator AsmHexCode(Ficomp src) => src.Encoded;
        }

        public Ficomp ficomp() => default;

        [MethodImpl(Inline), Op]
        public Ficomp ficomp(AsmHexCode encoded) => new Ficomp(encoded);

        public struct Fild : ITypedInstruction<Fild>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fild(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FILD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fild src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fild src) => AsmMnemonics.FILD;

            public static implicit operator AsmHexCode(Fild src) => src.Encoded;
        }

        public Fild fild() => default;

        [MethodImpl(Inline), Op]
        public Fild fild(AsmHexCode encoded) => new Fild(encoded);

        public struct Fincstp : ITypedInstruction<Fincstp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fincstp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FINCSTP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fincstp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fincstp src) => AsmMnemonics.FINCSTP;

            public static implicit operator AsmHexCode(Fincstp src) => src.Encoded;
        }

        public Fincstp fincstp() => default;

        [MethodImpl(Inline), Op]
        public Fincstp fincstp(AsmHexCode encoded) => new Fincstp(encoded);

        public struct Finit : ITypedInstruction<Finit>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Finit(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FINIT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Finit src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Finit src) => AsmMnemonics.FINIT;

            public static implicit operator AsmHexCode(Finit src) => src.Encoded;
        }

        public Finit finit() => default;

        [MethodImpl(Inline), Op]
        public Finit finit(AsmHexCode encoded) => new Finit(encoded);

        public struct Fninit : ITypedInstruction<Fninit>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fninit(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNINIT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fninit src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fninit src) => AsmMnemonics.FNINIT;

            public static implicit operator AsmHexCode(Fninit src) => src.Encoded;
        }

        public Fninit fninit() => default;

        [MethodImpl(Inline), Op]
        public Fninit fninit(AsmHexCode encoded) => new Fninit(encoded);

        public struct Fist : ITypedInstruction<Fist>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fist(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fist src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fist src) => AsmMnemonics.FIST;

            public static implicit operator AsmHexCode(Fist src) => src.Encoded;
        }

        public Fist fist() => default;

        [MethodImpl(Inline), Op]
        public Fist fist(AsmHexCode encoded) => new Fist(encoded);

        public struct Fistp : ITypedInstruction<Fistp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fistp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISTP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fistp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fistp src) => AsmMnemonics.FISTP;

            public static implicit operator AsmHexCode(Fistp src) => src.Encoded;
        }

        public Fistp fistp() => default;

        [MethodImpl(Inline), Op]
        public Fistp fistp(AsmHexCode encoded) => new Fistp(encoded);

        public struct Fisttp : ITypedInstruction<Fisttp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fisttp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISTTP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fisttp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fisttp src) => AsmMnemonics.FISTTP;

            public static implicit operator AsmHexCode(Fisttp src) => src.Encoded;
        }

        public Fisttp fisttp() => default;

        [MethodImpl(Inline), Op]
        public Fisttp fisttp(AsmHexCode encoded) => new Fisttp(encoded);

        public struct Fld : ITypedInstruction<Fld>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fld(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fld src) => AsmMnemonics.FLD;

            public static implicit operator AsmHexCode(Fld src) => src.Encoded;
        }

        public Fld fld() => default;

        [MethodImpl(Inline), Op]
        public Fld fld(AsmHexCode encoded) => new Fld(encoded);

        public struct Fld1 : ITypedInstruction<Fld1>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fld1(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLD1;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fld1 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fld1 src) => AsmMnemonics.FLD1;

            public static implicit operator AsmHexCode(Fld1 src) => src.Encoded;
        }

        public Fld1 fld1() => default;

        [MethodImpl(Inline), Op]
        public Fld1 fld1(AsmHexCode encoded) => new Fld1(encoded);

        public struct Fldl2t : ITypedInstruction<Fldl2t>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fldl2t(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDL2T;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fldl2t src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldl2t src) => AsmMnemonics.FLDL2T;

            public static implicit operator AsmHexCode(Fldl2t src) => src.Encoded;
        }

        public Fldl2t fldl2t() => default;

        [MethodImpl(Inline), Op]
        public Fldl2t fldl2t(AsmHexCode encoded) => new Fldl2t(encoded);

        public struct Fldl2e : ITypedInstruction<Fldl2e>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fldl2e(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDL2E;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fldl2e src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldl2e src) => AsmMnemonics.FLDL2E;

            public static implicit operator AsmHexCode(Fldl2e src) => src.Encoded;
        }

        public Fldl2e fldl2e() => default;

        [MethodImpl(Inline), Op]
        public Fldl2e fldl2e(AsmHexCode encoded) => new Fldl2e(encoded);

        public struct Fldpi : ITypedInstruction<Fldpi>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fldpi(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDPI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fldpi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldpi src) => AsmMnemonics.FLDPI;

            public static implicit operator AsmHexCode(Fldpi src) => src.Encoded;
        }

        public Fldpi fldpi() => default;

        [MethodImpl(Inline), Op]
        public Fldpi fldpi(AsmHexCode encoded) => new Fldpi(encoded);

        public struct Fldlg2 : ITypedInstruction<Fldlg2>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fldlg2(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDLG2;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fldlg2 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldlg2 src) => AsmMnemonics.FLDLG2;

            public static implicit operator AsmHexCode(Fldlg2 src) => src.Encoded;
        }

        public Fldlg2 fldlg2() => default;

        [MethodImpl(Inline), Op]
        public Fldlg2 fldlg2(AsmHexCode encoded) => new Fldlg2(encoded);

        public struct Fldln2 : ITypedInstruction<Fldln2>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fldln2(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDLN2;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fldln2 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldln2 src) => AsmMnemonics.FLDLN2;

            public static implicit operator AsmHexCode(Fldln2 src) => src.Encoded;
        }

        public Fldln2 fldln2() => default;

        [MethodImpl(Inline), Op]
        public Fldln2 fldln2(AsmHexCode encoded) => new Fldln2(encoded);

        public struct Fldz : ITypedInstruction<Fldz>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fldz(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDZ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fldz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldz src) => AsmMnemonics.FLDZ;

            public static implicit operator AsmHexCode(Fldz src) => src.Encoded;
        }

        public Fldz fldz() => default;

        [MethodImpl(Inline), Op]
        public Fldz fldz(AsmHexCode encoded) => new Fldz(encoded);

        public struct Fldcw : ITypedInstruction<Fldcw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fldcw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDCW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fldcw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldcw src) => AsmMnemonics.FLDCW;

            public static implicit operator AsmHexCode(Fldcw src) => src.Encoded;
        }

        public Fldcw fldcw() => default;

        [MethodImpl(Inline), Op]
        public Fldcw fldcw(AsmHexCode encoded) => new Fldcw(encoded);

        public struct Fldenv : ITypedInstruction<Fldenv>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fldenv(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDENV;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fldenv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldenv src) => AsmMnemonics.FLDENV;

            public static implicit operator AsmHexCode(Fldenv src) => src.Encoded;
        }

        public Fldenv fldenv() => default;

        [MethodImpl(Inline), Op]
        public Fldenv fldenv(AsmHexCode encoded) => new Fldenv(encoded);

        public struct Fmul : ITypedInstruction<Fmul>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fmul(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FMUL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fmul src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fmul src) => AsmMnemonics.FMUL;

            public static implicit operator AsmHexCode(Fmul src) => src.Encoded;
        }

        public Fmul fmul() => default;

        [MethodImpl(Inline), Op]
        public Fmul fmul(AsmHexCode encoded) => new Fmul(encoded);

        public struct Fmulp : ITypedInstruction<Fmulp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fmulp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FMULP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fmulp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fmulp src) => AsmMnemonics.FMULP;

            public static implicit operator AsmHexCode(Fmulp src) => src.Encoded;
        }

        public Fmulp fmulp() => default;

        [MethodImpl(Inline), Op]
        public Fmulp fmulp(AsmHexCode encoded) => new Fmulp(encoded);

        public struct Fimul : ITypedInstruction<Fimul>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fimul(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIMUL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fimul src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fimul src) => AsmMnemonics.FIMUL;

            public static implicit operator AsmHexCode(Fimul src) => src.Encoded;
        }

        public Fimul fimul() => default;

        [MethodImpl(Inline), Op]
        public Fimul fimul(AsmHexCode encoded) => new Fimul(encoded);

        public struct Fnop : ITypedInstruction<Fnop>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fnop(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNOP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fnop src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnop src) => AsmMnemonics.FNOP;

            public static implicit operator AsmHexCode(Fnop src) => src.Encoded;
        }

        public Fnop fnop() => default;

        [MethodImpl(Inline), Op]
        public Fnop fnop(AsmHexCode encoded) => new Fnop(encoded);

        public struct Fpatan : ITypedInstruction<Fpatan>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fpatan(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FPATAN;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fpatan src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fpatan src) => AsmMnemonics.FPATAN;

            public static implicit operator AsmHexCode(Fpatan src) => src.Encoded;
        }

        public Fpatan fpatan() => default;

        [MethodImpl(Inline), Op]
        public Fpatan fpatan(AsmHexCode encoded) => new Fpatan(encoded);

        public struct Fprem : ITypedInstruction<Fprem>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fprem(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FPREM;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fprem src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fprem src) => AsmMnemonics.FPREM;

            public static implicit operator AsmHexCode(Fprem src) => src.Encoded;
        }

        public Fprem fprem() => default;

        [MethodImpl(Inline), Op]
        public Fprem fprem(AsmHexCode encoded) => new Fprem(encoded);

        public struct Fprem1 : ITypedInstruction<Fprem1>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fprem1(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FPREM1;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fprem1 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fprem1 src) => AsmMnemonics.FPREM1;

            public static implicit operator AsmHexCode(Fprem1 src) => src.Encoded;
        }

        public Fprem1 fprem1() => default;

        [MethodImpl(Inline), Op]
        public Fprem1 fprem1(AsmHexCode encoded) => new Fprem1(encoded);

        public struct Fptan : ITypedInstruction<Fptan>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fptan(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FPTAN;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fptan src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fptan src) => AsmMnemonics.FPTAN;

            public static implicit operator AsmHexCode(Fptan src) => src.Encoded;
        }

        public Fptan fptan() => default;

        [MethodImpl(Inline), Op]
        public Fptan fptan(AsmHexCode encoded) => new Fptan(encoded);

        public struct Frndint : ITypedInstruction<Frndint>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Frndint(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FRNDINT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Frndint src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Frndint src) => AsmMnemonics.FRNDINT;

            public static implicit operator AsmHexCode(Frndint src) => src.Encoded;
        }

        public Frndint frndint() => default;

        [MethodImpl(Inline), Op]
        public Frndint frndint(AsmHexCode encoded) => new Frndint(encoded);

        public struct Frstor : ITypedInstruction<Frstor>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Frstor(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FRSTOR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Frstor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Frstor src) => AsmMnemonics.FRSTOR;

            public static implicit operator AsmHexCode(Frstor src) => src.Encoded;
        }

        public Frstor frstor() => default;

        [MethodImpl(Inline), Op]
        public Frstor frstor(AsmHexCode encoded) => new Frstor(encoded);

        public struct Fsave : ITypedInstruction<Fsave>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fsave(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSAVE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fsave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsave src) => AsmMnemonics.FSAVE;

            public static implicit operator AsmHexCode(Fsave src) => src.Encoded;
        }

        public Fsave fsave() => default;

        [MethodImpl(Inline), Op]
        public Fsave fsave(AsmHexCode encoded) => new Fsave(encoded);

        public struct Fnsave : ITypedInstruction<Fnsave>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fnsave(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSAVE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fnsave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnsave src) => AsmMnemonics.FNSAVE;

            public static implicit operator AsmHexCode(Fnsave src) => src.Encoded;
        }

        public Fnsave fnsave() => default;

        [MethodImpl(Inline), Op]
        public Fnsave fnsave(AsmHexCode encoded) => new Fnsave(encoded);

        public struct Fscale : ITypedInstruction<Fscale>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fscale(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSCALE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fscale src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fscale src) => AsmMnemonics.FSCALE;

            public static implicit operator AsmHexCode(Fscale src) => src.Encoded;
        }

        public Fscale fscale() => default;

        [MethodImpl(Inline), Op]
        public Fscale fscale(AsmHexCode encoded) => new Fscale(encoded);

        public struct Fsin : ITypedInstruction<Fsin>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fsin(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSIN;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fsin src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsin src) => AsmMnemonics.FSIN;

            public static implicit operator AsmHexCode(Fsin src) => src.Encoded;
        }

        public Fsin fsin() => default;

        [MethodImpl(Inline), Op]
        public Fsin fsin(AsmHexCode encoded) => new Fsin(encoded);

        public struct Fsincos : ITypedInstruction<Fsincos>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fsincos(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSINCOS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fsincos src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsincos src) => AsmMnemonics.FSINCOS;

            public static implicit operator AsmHexCode(Fsincos src) => src.Encoded;
        }

        public Fsincos fsincos() => default;

        [MethodImpl(Inline), Op]
        public Fsincos fsincos(AsmHexCode encoded) => new Fsincos(encoded);

        public struct Fsqrt : ITypedInstruction<Fsqrt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fsqrt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSQRT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fsqrt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsqrt src) => AsmMnemonics.FSQRT;

            public static implicit operator AsmHexCode(Fsqrt src) => src.Encoded;
        }

        public Fsqrt fsqrt() => default;

        [MethodImpl(Inline), Op]
        public Fsqrt fsqrt(AsmHexCode encoded) => new Fsqrt(encoded);

        public struct Fst : ITypedInstruction<Fst>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fst(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fst src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fst src) => AsmMnemonics.FST;

            public static implicit operator AsmHexCode(Fst src) => src.Encoded;
        }

        public Fst fst() => default;

        [MethodImpl(Inline), Op]
        public Fst fst(AsmHexCode encoded) => new Fst(encoded);

        public struct Fstp : ITypedInstruction<Fstp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fstp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fstp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fstp src) => AsmMnemonics.FSTP;

            public static implicit operator AsmHexCode(Fstp src) => src.Encoded;
        }

        public Fstp fstp() => default;

        [MethodImpl(Inline), Op]
        public Fstp fstp(AsmHexCode encoded) => new Fstp(encoded);

        public struct Fstcw : ITypedInstruction<Fstcw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fstcw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTCW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fstcw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fstcw src) => AsmMnemonics.FSTCW;

            public static implicit operator AsmHexCode(Fstcw src) => src.Encoded;
        }

        public Fstcw fstcw() => default;

        [MethodImpl(Inline), Op]
        public Fstcw fstcw(AsmHexCode encoded) => new Fstcw(encoded);

        public struct Fnstcw : ITypedInstruction<Fnstcw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fnstcw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSTCW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fnstcw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnstcw src) => AsmMnemonics.FNSTCW;

            public static implicit operator AsmHexCode(Fnstcw src) => src.Encoded;
        }

        public Fnstcw fnstcw() => default;

        [MethodImpl(Inline), Op]
        public Fnstcw fnstcw(AsmHexCode encoded) => new Fnstcw(encoded);

        public struct Fstenv : ITypedInstruction<Fstenv>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fstenv(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTENV;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fstenv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fstenv src) => AsmMnemonics.FSTENV;

            public static implicit operator AsmHexCode(Fstenv src) => src.Encoded;
        }

        public Fstenv fstenv() => default;

        [MethodImpl(Inline), Op]
        public Fstenv fstenv(AsmHexCode encoded) => new Fstenv(encoded);

        public struct Fnstenv : ITypedInstruction<Fnstenv>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fnstenv(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSTENV;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fnstenv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnstenv src) => AsmMnemonics.FNSTENV;

            public static implicit operator AsmHexCode(Fnstenv src) => src.Encoded;
        }

        public Fnstenv fnstenv() => default;

        [MethodImpl(Inline), Op]
        public Fnstenv fnstenv(AsmHexCode encoded) => new Fnstenv(encoded);

        public struct Fstsw : ITypedInstruction<Fstsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fstsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fstsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fstsw src) => AsmMnemonics.FSTSW;

            public static implicit operator AsmHexCode(Fstsw src) => src.Encoded;
        }

        public Fstsw fstsw() => default;

        [MethodImpl(Inline), Op]
        public Fstsw fstsw(AsmHexCode encoded) => new Fstsw(encoded);

        public struct Fnstsw : ITypedInstruction<Fnstsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fnstsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSTSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fnstsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnstsw src) => AsmMnemonics.FNSTSW;

            public static implicit operator AsmHexCode(Fnstsw src) => src.Encoded;
        }

        public Fnstsw fnstsw() => default;

        [MethodImpl(Inline), Op]
        public Fnstsw fnstsw(AsmHexCode encoded) => new Fnstsw(encoded);

        public struct Fsub : ITypedInstruction<Fsub>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fsub(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fsub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsub src) => AsmMnemonics.FSUB;

            public static implicit operator AsmHexCode(Fsub src) => src.Encoded;
        }

        public Fsub fsub() => default;

        [MethodImpl(Inline), Op]
        public Fsub fsub(AsmHexCode encoded) => new Fsub(encoded);

        public struct Fsubp : ITypedInstruction<Fsubp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fsubp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUBP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fsubp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsubp src) => AsmMnemonics.FSUBP;

            public static implicit operator AsmHexCode(Fsubp src) => src.Encoded;
        }

        public Fsubp fsubp() => default;

        [MethodImpl(Inline), Op]
        public Fsubp fsubp(AsmHexCode encoded) => new Fsubp(encoded);

        public struct Fisub : ITypedInstruction<Fisub>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fisub(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISUB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fisub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fisub src) => AsmMnemonics.FISUB;

            public static implicit operator AsmHexCode(Fisub src) => src.Encoded;
        }

        public Fisub fisub() => default;

        [MethodImpl(Inline), Op]
        public Fisub fisub(AsmHexCode encoded) => new Fisub(encoded);

        public struct Fsubr : ITypedInstruction<Fsubr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fsubr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUBR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fsubr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsubr src) => AsmMnemonics.FSUBR;

            public static implicit operator AsmHexCode(Fsubr src) => src.Encoded;
        }

        public Fsubr fsubr() => default;

        [MethodImpl(Inline), Op]
        public Fsubr fsubr(AsmHexCode encoded) => new Fsubr(encoded);

        public struct Fsubrp : ITypedInstruction<Fsubrp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fsubrp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUBRP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fsubrp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsubrp src) => AsmMnemonics.FSUBRP;

            public static implicit operator AsmHexCode(Fsubrp src) => src.Encoded;
        }

        public Fsubrp fsubrp() => default;

        [MethodImpl(Inline), Op]
        public Fsubrp fsubrp(AsmHexCode encoded) => new Fsubrp(encoded);

        public struct Fisubr : ITypedInstruction<Fisubr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fisubr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISUBR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fisubr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fisubr src) => AsmMnemonics.FISUBR;

            public static implicit operator AsmHexCode(Fisubr src) => src.Encoded;
        }

        public Fisubr fisubr() => default;

        [MethodImpl(Inline), Op]
        public Fisubr fisubr(AsmHexCode encoded) => new Fisubr(encoded);

        public struct Ftst : ITypedInstruction<Ftst>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ftst(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FTST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ftst src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ftst src) => AsmMnemonics.FTST;

            public static implicit operator AsmHexCode(Ftst src) => src.Encoded;
        }

        public Ftst ftst() => default;

        [MethodImpl(Inline), Op]
        public Ftst ftst(AsmHexCode encoded) => new Ftst(encoded);

        public struct Fucom : ITypedInstruction<Fucom>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fucom(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOM;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fucom src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucom src) => AsmMnemonics.FUCOM;

            public static implicit operator AsmHexCode(Fucom src) => src.Encoded;
        }

        public Fucom fucom() => default;

        [MethodImpl(Inline), Op]
        public Fucom fucom(AsmHexCode encoded) => new Fucom(encoded);

        public struct Fucomp : ITypedInstruction<Fucomp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fucomp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fucomp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucomp src) => AsmMnemonics.FUCOMP;

            public static implicit operator AsmHexCode(Fucomp src) => src.Encoded;
        }

        public Fucomp fucomp() => default;

        [MethodImpl(Inline), Op]
        public Fucomp fucomp(AsmHexCode encoded) => new Fucomp(encoded);

        public struct Fucompp : ITypedInstruction<Fucompp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fucompp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMPP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fucompp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucompp src) => AsmMnemonics.FUCOMPP;

            public static implicit operator AsmHexCode(Fucompp src) => src.Encoded;
        }

        public Fucompp fucompp() => default;

        [MethodImpl(Inline), Op]
        public Fucompp fucompp(AsmHexCode encoded) => new Fucompp(encoded);

        public struct Fxam : ITypedInstruction<Fxam>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fxam(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXAM;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fxam src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxam src) => AsmMnemonics.FXAM;

            public static implicit operator AsmHexCode(Fxam src) => src.Encoded;
        }

        public Fxam fxam() => default;

        [MethodImpl(Inline), Op]
        public Fxam fxam(AsmHexCode encoded) => new Fxam(encoded);

        public struct Fxch : ITypedInstruction<Fxch>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fxch(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXCH;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fxch src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxch src) => AsmMnemonics.FXCH;

            public static implicit operator AsmHexCode(Fxch src) => src.Encoded;
        }

        public Fxch fxch() => default;

        [MethodImpl(Inline), Op]
        public Fxch fxch(AsmHexCode encoded) => new Fxch(encoded);

        public struct Fxrstor : ITypedInstruction<Fxrstor>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fxrstor(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXRSTOR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fxrstor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxrstor src) => AsmMnemonics.FXRSTOR;

            public static implicit operator AsmHexCode(Fxrstor src) => src.Encoded;
        }

        public Fxrstor fxrstor() => default;

        [MethodImpl(Inline), Op]
        public Fxrstor fxrstor(AsmHexCode encoded) => new Fxrstor(encoded);

        public struct Fxrstor64 : ITypedInstruction<Fxrstor64>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fxrstor64(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXRSTOR64;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fxrstor64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxrstor64 src) => AsmMnemonics.FXRSTOR64;

            public static implicit operator AsmHexCode(Fxrstor64 src) => src.Encoded;
        }

        public Fxrstor64 fxrstor64() => default;

        [MethodImpl(Inline), Op]
        public Fxrstor64 fxrstor64(AsmHexCode encoded) => new Fxrstor64(encoded);

        public struct Fxsave : ITypedInstruction<Fxsave>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fxsave(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXSAVE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fxsave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxsave src) => AsmMnemonics.FXSAVE;

            public static implicit operator AsmHexCode(Fxsave src) => src.Encoded;
        }

        public Fxsave fxsave() => default;

        [MethodImpl(Inline), Op]
        public Fxsave fxsave(AsmHexCode encoded) => new Fxsave(encoded);

        public struct Fxsave64 : ITypedInstruction<Fxsave64>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fxsave64(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXSAVE64;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fxsave64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxsave64 src) => AsmMnemonics.FXSAVE64;

            public static implicit operator AsmHexCode(Fxsave64 src) => src.Encoded;
        }

        public Fxsave64 fxsave64() => default;

        [MethodImpl(Inline), Op]
        public Fxsave64 fxsave64(AsmHexCode encoded) => new Fxsave64(encoded);

        public struct Fxtract : ITypedInstruction<Fxtract>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fxtract(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXTRACT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fxtract src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxtract src) => AsmMnemonics.FXTRACT;

            public static implicit operator AsmHexCode(Fxtract src) => src.Encoded;
        }

        public Fxtract fxtract() => default;

        [MethodImpl(Inline), Op]
        public Fxtract fxtract(AsmHexCode encoded) => new Fxtract(encoded);

        public struct Fyl2x : ITypedInstruction<Fyl2x>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fyl2x(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FYL2X;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fyl2x src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fyl2x src) => AsmMnemonics.FYL2X;

            public static implicit operator AsmHexCode(Fyl2x src) => src.Encoded;
        }

        public Fyl2x fyl2x() => default;

        [MethodImpl(Inline), Op]
        public Fyl2x fyl2x(AsmHexCode encoded) => new Fyl2x(encoded);

        public struct Fyl2xp1 : ITypedInstruction<Fyl2xp1>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fyl2xp1(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FYL2XP1;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fyl2xp1 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fyl2xp1 src) => AsmMnemonics.FYL2XP1;

            public static implicit operator AsmHexCode(Fyl2xp1 src) => src.Encoded;
        }

        public Fyl2xp1 fyl2xp1() => default;

        [MethodImpl(Inline), Op]
        public Fyl2xp1 fyl2xp1(AsmHexCode encoded) => new Fyl2xp1(encoded);

        public struct Haddpd : ITypedInstruction<Haddpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Haddpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HADDPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Haddpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Haddpd src) => AsmMnemonics.HADDPD;

            public static implicit operator AsmHexCode(Haddpd src) => src.Encoded;
        }

        public Haddpd haddpd() => default;

        [MethodImpl(Inline), Op]
        public Haddpd haddpd(AsmHexCode encoded) => new Haddpd(encoded);

        public struct Vhaddpd : ITypedInstruction<Vhaddpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vhaddpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHADDPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vhaddpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vhaddpd src) => AsmMnemonics.VHADDPD;

            public static implicit operator AsmHexCode(Vhaddpd src) => src.Encoded;
        }

        public Vhaddpd vhaddpd() => default;

        [MethodImpl(Inline), Op]
        public Vhaddpd vhaddpd(AsmHexCode encoded) => new Vhaddpd(encoded);

        public struct Haddps : ITypedInstruction<Haddps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Haddps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HADDPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Haddps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Haddps src) => AsmMnemonics.HADDPS;

            public static implicit operator AsmHexCode(Haddps src) => src.Encoded;
        }

        public Haddps haddps() => default;

        [MethodImpl(Inline), Op]
        public Haddps haddps(AsmHexCode encoded) => new Haddps(encoded);

        public struct Vhaddps : ITypedInstruction<Vhaddps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vhaddps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHADDPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vhaddps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vhaddps src) => AsmMnemonics.VHADDPS;

            public static implicit operator AsmHexCode(Vhaddps src) => src.Encoded;
        }

        public Vhaddps vhaddps() => default;

        [MethodImpl(Inline), Op]
        public Vhaddps vhaddps(AsmHexCode encoded) => new Vhaddps(encoded);

        public struct Hlt : ITypedInstruction<Hlt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Hlt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HLT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Hlt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Hlt src) => AsmMnemonics.HLT;

            public static implicit operator AsmHexCode(Hlt src) => src.Encoded;
        }

        public Hlt hlt() => default;

        [MethodImpl(Inline), Op]
        public Hlt hlt(AsmHexCode encoded) => new Hlt(encoded);

        public struct Hsubpd : ITypedInstruction<Hsubpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Hsubpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HSUBPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Hsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Hsubpd src) => AsmMnemonics.HSUBPD;

            public static implicit operator AsmHexCode(Hsubpd src) => src.Encoded;
        }

        public Hsubpd hsubpd() => default;

        [MethodImpl(Inline), Op]
        public Hsubpd hsubpd(AsmHexCode encoded) => new Hsubpd(encoded);

        public struct Vhsubpd : ITypedInstruction<Vhsubpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vhsubpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHSUBPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vhsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vhsubpd src) => AsmMnemonics.VHSUBPD;

            public static implicit operator AsmHexCode(Vhsubpd src) => src.Encoded;
        }

        public Vhsubpd vhsubpd() => default;

        [MethodImpl(Inline), Op]
        public Vhsubpd vhsubpd(AsmHexCode encoded) => new Vhsubpd(encoded);

        public struct Hsubps : ITypedInstruction<Hsubps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Hsubps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HSUBPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Hsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Hsubps src) => AsmMnemonics.HSUBPS;

            public static implicit operator AsmHexCode(Hsubps src) => src.Encoded;
        }

        public Hsubps hsubps() => default;

        [MethodImpl(Inline), Op]
        public Hsubps hsubps(AsmHexCode encoded) => new Hsubps(encoded);

        public struct Vhsubps : ITypedInstruction<Vhsubps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vhsubps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHSUBPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vhsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vhsubps src) => AsmMnemonics.VHSUBPS;

            public static implicit operator AsmHexCode(Vhsubps src) => src.Encoded;
        }

        public Vhsubps vhsubps() => default;

        [MethodImpl(Inline), Op]
        public Vhsubps vhsubps(AsmHexCode encoded) => new Vhsubps(encoded);

        public struct Idiv : ITypedInstruction<Idiv>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Idiv(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IDIV;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Idiv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Idiv src) => AsmMnemonics.IDIV;

            public static implicit operator AsmHexCode(Idiv src) => src.Encoded;
        }

        public Idiv idiv() => default;

        [MethodImpl(Inline), Op]
        public Idiv idiv(AsmHexCode encoded) => new Idiv(encoded);

        public struct Imul : ITypedInstruction<Imul>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Imul(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IMUL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Imul src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Imul src) => AsmMnemonics.IMUL;

            public static implicit operator AsmHexCode(Imul src) => src.Encoded;
        }

        public Imul imul() => default;

        [MethodImpl(Inline), Op]
        public Imul imul(AsmHexCode encoded) => new Imul(encoded);

        public struct In : ITypedInstruction<In>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public In(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IN;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(In src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(In src) => AsmMnemonics.IN;

            public static implicit operator AsmHexCode(In src) => src.Encoded;
        }

        public In @in() => default;

        [MethodImpl(Inline), Op]
        public In @in(AsmHexCode encoded) => new In(encoded);

        public struct Inc : ITypedInstruction<Inc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Inc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Inc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Inc src) => AsmMnemonics.INC;

            public static implicit operator AsmHexCode(Inc src) => src.Encoded;
        }

        public Inc inc() => default;

        [MethodImpl(Inline), Op]
        public Inc inc(AsmHexCode encoded) => new Inc(encoded);

        public struct Ins : ITypedInstruction<Ins>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ins(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ins src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ins src) => AsmMnemonics.INS;

            public static implicit operator AsmHexCode(Ins src) => src.Encoded;
        }

        public Ins ins() => default;

        [MethodImpl(Inline), Op]
        public Ins ins(AsmHexCode encoded) => new Ins(encoded);

        public struct Insb : ITypedInstruction<Insb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Insb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Insb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Insb src) => AsmMnemonics.INSB;

            public static implicit operator AsmHexCode(Insb src) => src.Encoded;
        }

        public Insb insb() => default;

        [MethodImpl(Inline), Op]
        public Insb insb(AsmHexCode encoded) => new Insb(encoded);

        public struct Insw : ITypedInstruction<Insw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Insw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Insw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Insw src) => AsmMnemonics.INSW;

            public static implicit operator AsmHexCode(Insw src) => src.Encoded;
        }

        public Insw insw() => default;

        [MethodImpl(Inline), Op]
        public Insw insw(AsmHexCode encoded) => new Insw(encoded);

        public struct Insd : ITypedInstruction<Insd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Insd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Insd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Insd src) => AsmMnemonics.INSD;

            public static implicit operator AsmHexCode(Insd src) => src.Encoded;
        }

        public Insd insd() => default;

        [MethodImpl(Inline), Op]
        public Insd insd(AsmHexCode encoded) => new Insd(encoded);

        public struct Insertps : ITypedInstruction<Insertps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Insertps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INSERTPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Insertps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Insertps src) => AsmMnemonics.INSERTPS;

            public static implicit operator AsmHexCode(Insertps src) => src.Encoded;
        }

        public Insertps insertps() => default;

        [MethodImpl(Inline), Op]
        public Insertps insertps(AsmHexCode encoded) => new Insertps(encoded);

        public struct Vinsertps : ITypedInstruction<Vinsertps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vinsertps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VINSERTPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vinsertps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vinsertps src) => AsmMnemonics.VINSERTPS;

            public static implicit operator AsmHexCode(Vinsertps src) => src.Encoded;
        }

        public Vinsertps vinsertps() => default;

        [MethodImpl(Inline), Op]
        public Vinsertps vinsertps(AsmHexCode encoded) => new Vinsertps(encoded);

        public struct Int : ITypedInstruction<Int>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Int(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Int src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Int src) => AsmMnemonics.INT;

            public static implicit operator AsmHexCode(Int src) => src.Encoded;
        }

        public Int @int() => default;

        [MethodImpl(Inline), Op]
        public Int @int(AsmHexCode encoded) => new Int(encoded);

        public struct Into : ITypedInstruction<Into>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Into(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INTO;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Into src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Into src) => AsmMnemonics.INTO;

            public static implicit operator AsmHexCode(Into src) => src.Encoded;
        }

        public Into into() => default;

        [MethodImpl(Inline), Op]
        public Into into(AsmHexCode encoded) => new Into(encoded);

        public struct Invd : ITypedInstruction<Invd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Invd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INVD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Invd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Invd src) => AsmMnemonics.INVD;

            public static implicit operator AsmHexCode(Invd src) => src.Encoded;
        }

        public Invd invd() => default;

        [MethodImpl(Inline), Op]
        public Invd invd(AsmHexCode encoded) => new Invd(encoded);

        public struct Invlpg : ITypedInstruction<Invlpg>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Invlpg(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INVLPG;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Invlpg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Invlpg src) => AsmMnemonics.INVLPG;

            public static implicit operator AsmHexCode(Invlpg src) => src.Encoded;
        }

        public Invlpg invlpg() => default;

        [MethodImpl(Inline), Op]
        public Invlpg invlpg(AsmHexCode encoded) => new Invlpg(encoded);

        public struct Invpcid : ITypedInstruction<Invpcid>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Invpcid(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INVPCID;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Invpcid src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Invpcid src) => AsmMnemonics.INVPCID;

            public static implicit operator AsmHexCode(Invpcid src) => src.Encoded;
        }

        public Invpcid invpcid() => default;

        [MethodImpl(Inline), Op]
        public Invpcid invpcid(AsmHexCode encoded) => new Invpcid(encoded);

        public struct Iret : ITypedInstruction<Iret>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Iret(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IRET;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Iret src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Iret src) => AsmMnemonics.IRET;

            public static implicit operator AsmHexCode(Iret src) => src.Encoded;
        }

        public Iret iret() => default;

        [MethodImpl(Inline), Op]
        public Iret iret(AsmHexCode encoded) => new Iret(encoded);

        public struct Iretd : ITypedInstruction<Iretd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Iretd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IRETD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Iretd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Iretd src) => AsmMnemonics.IRETD;

            public static implicit operator AsmHexCode(Iretd src) => src.Encoded;
        }

        public Iretd iretd() => default;

        [MethodImpl(Inline), Op]
        public Iretd iretd(AsmHexCode encoded) => new Iretd(encoded);

        public struct Iretq : ITypedInstruction<Iretq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Iretq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IRETQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Iretq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Iretq src) => AsmMnemonics.IRETQ;

            public static implicit operator AsmHexCode(Iretq src) => src.Encoded;
        }

        public Iretq iretq() => default;

        [MethodImpl(Inline), Op]
        public Iretq iretq(AsmHexCode encoded) => new Iretq(encoded);

        public struct Ja : ITypedInstruction<Ja>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ja(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ja src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ja src) => AsmMnemonics.JA;

            public static implicit operator AsmHexCode(Ja src) => src.Encoded;
        }

        public Ja ja() => default;

        [MethodImpl(Inline), Op]
        public Ja ja(AsmHexCode encoded) => new Ja(encoded);

        public struct Jae : ITypedInstruction<Jae>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jae(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JAE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jae src) => AsmMnemonics.JAE;

            public static implicit operator AsmHexCode(Jae src) => src.Encoded;
        }

        public Jae jae() => default;

        [MethodImpl(Inline), Op]
        public Jae jae(AsmHexCode encoded) => new Jae(encoded);

        public struct Jb : ITypedInstruction<Jb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jb src) => AsmMnemonics.JB;

            public static implicit operator AsmHexCode(Jb src) => src.Encoded;
        }

        public Jb jb() => default;

        [MethodImpl(Inline), Op]
        public Jb jb(AsmHexCode encoded) => new Jb(encoded);

        public struct Jbe : ITypedInstruction<Jbe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jbe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JBE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jbe src) => AsmMnemonics.JBE;

            public static implicit operator AsmHexCode(Jbe src) => src.Encoded;
        }

        public Jbe jbe() => default;

        [MethodImpl(Inline), Op]
        public Jbe jbe(AsmHexCode encoded) => new Jbe(encoded);

        public struct Jc : ITypedInstruction<Jc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jc src) => AsmMnemonics.JC;

            public static implicit operator AsmHexCode(Jc src) => src.Encoded;
        }

        public Jc jc() => default;

        [MethodImpl(Inline), Op]
        public Jc jc(AsmHexCode encoded) => new Jc(encoded);

        public struct Jcxz : ITypedInstruction<Jcxz>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jcxz(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JCXZ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jcxz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jcxz src) => AsmMnemonics.JCXZ;

            public static implicit operator AsmHexCode(Jcxz src) => src.Encoded;
        }

        public Jcxz jcxz() => default;

        [MethodImpl(Inline), Op]
        public Jcxz jcxz(AsmHexCode encoded) => new Jcxz(encoded);

        public struct Jecxz : ITypedInstruction<Jecxz>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jecxz(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JECXZ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jecxz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jecxz src) => AsmMnemonics.JECXZ;

            public static implicit operator AsmHexCode(Jecxz src) => src.Encoded;
        }

        public Jecxz jecxz() => default;

        [MethodImpl(Inline), Op]
        public Jecxz jecxz(AsmHexCode encoded) => new Jecxz(encoded);

        public struct Jrcxz : ITypedInstruction<Jrcxz>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jrcxz(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JRCXZ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jrcxz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jrcxz src) => AsmMnemonics.JRCXZ;

            public static implicit operator AsmHexCode(Jrcxz src) => src.Encoded;
        }

        public Jrcxz jrcxz() => default;

        [MethodImpl(Inline), Op]
        public Jrcxz jrcxz(AsmHexCode encoded) => new Jrcxz(encoded);

        public struct Je : ITypedInstruction<Je>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Je(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Je src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Je src) => AsmMnemonics.JE;

            public static implicit operator AsmHexCode(Je src) => src.Encoded;
        }

        public Je je() => default;

        [MethodImpl(Inline), Op]
        public Je je(AsmHexCode encoded) => new Je(encoded);

        public struct Jg : ITypedInstruction<Jg>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jg(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JG;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jg src) => AsmMnemonics.JG;

            public static implicit operator AsmHexCode(Jg src) => src.Encoded;
        }

        public Jg jg() => default;

        [MethodImpl(Inline), Op]
        public Jg jg(AsmHexCode encoded) => new Jg(encoded);

        public struct Jge : ITypedInstruction<Jge>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jge(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JGE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jge src) => AsmMnemonics.JGE;

            public static implicit operator AsmHexCode(Jge src) => src.Encoded;
        }

        public Jge jge() => default;

        [MethodImpl(Inline), Op]
        public Jge jge(AsmHexCode encoded) => new Jge(encoded);

        public struct Jl : ITypedInstruction<Jl>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jl(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jl src) => AsmMnemonics.JL;

            public static implicit operator AsmHexCode(Jl src) => src.Encoded;
        }

        public Jl jl() => default;

        [MethodImpl(Inline), Op]
        public Jl jl(AsmHexCode encoded) => new Jl(encoded);

        public struct Jle : ITypedInstruction<Jle>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jle(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JLE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jle src) => AsmMnemonics.JLE;

            public static implicit operator AsmHexCode(Jle src) => src.Encoded;
        }

        public Jle jle() => default;

        [MethodImpl(Inline), Op]
        public Jle jle(AsmHexCode encoded) => new Jle(encoded);

        public struct Jna : ITypedInstruction<Jna>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jna(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jna src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jna src) => AsmMnemonics.JNA;

            public static implicit operator AsmHexCode(Jna src) => src.Encoded;
        }

        public Jna jna() => default;

        [MethodImpl(Inline), Op]
        public Jna jna(AsmHexCode encoded) => new Jna(encoded);

        public struct Jnae : ITypedInstruction<Jnae>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jnae(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNAE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jnae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnae src) => AsmMnemonics.JNAE;

            public static implicit operator AsmHexCode(Jnae src) => src.Encoded;
        }

        public Jnae jnae() => default;

        [MethodImpl(Inline), Op]
        public Jnae jnae(AsmHexCode encoded) => new Jnae(encoded);

        public struct Jnb : ITypedInstruction<Jnb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jnb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jnb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnb src) => AsmMnemonics.JNB;

            public static implicit operator AsmHexCode(Jnb src) => src.Encoded;
        }

        public Jnb jnb() => default;

        [MethodImpl(Inline), Op]
        public Jnb jnb(AsmHexCode encoded) => new Jnb(encoded);

        public struct Jnbe : ITypedInstruction<Jnbe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jnbe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNBE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jnbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnbe src) => AsmMnemonics.JNBE;

            public static implicit operator AsmHexCode(Jnbe src) => src.Encoded;
        }

        public Jnbe jnbe() => default;

        [MethodImpl(Inline), Op]
        public Jnbe jnbe(AsmHexCode encoded) => new Jnbe(encoded);

        public struct Jnc : ITypedInstruction<Jnc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jnc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jnc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnc src) => AsmMnemonics.JNC;

            public static implicit operator AsmHexCode(Jnc src) => src.Encoded;
        }

        public Jnc jnc() => default;

        [MethodImpl(Inline), Op]
        public Jnc jnc(AsmHexCode encoded) => new Jnc(encoded);

        public struct Jne : ITypedInstruction<Jne>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jne(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jne src) => AsmMnemonics.JNE;

            public static implicit operator AsmHexCode(Jne src) => src.Encoded;
        }

        public Jne jne() => default;

        [MethodImpl(Inline), Op]
        public Jne jne(AsmHexCode encoded) => new Jne(encoded);

        public struct Jng : ITypedInstruction<Jng>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jng(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNG;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jng src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jng src) => AsmMnemonics.JNG;

            public static implicit operator AsmHexCode(Jng src) => src.Encoded;
        }

        public Jng jng() => default;

        [MethodImpl(Inline), Op]
        public Jng jng(AsmHexCode encoded) => new Jng(encoded);

        public struct Jnge : ITypedInstruction<Jnge>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jnge(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNGE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jnge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnge src) => AsmMnemonics.JNGE;

            public static implicit operator AsmHexCode(Jnge src) => src.Encoded;
        }

        public Jnge jnge() => default;

        [MethodImpl(Inline), Op]
        public Jnge jnge(AsmHexCode encoded) => new Jnge(encoded);

        public struct Jnl : ITypedInstruction<Jnl>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jnl(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jnl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnl src) => AsmMnemonics.JNL;

            public static implicit operator AsmHexCode(Jnl src) => src.Encoded;
        }

        public Jnl jnl() => default;

        [MethodImpl(Inline), Op]
        public Jnl jnl(AsmHexCode encoded) => new Jnl(encoded);

        public struct Jnle : ITypedInstruction<Jnle>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jnle(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNLE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jnle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnle src) => AsmMnemonics.JNLE;

            public static implicit operator AsmHexCode(Jnle src) => src.Encoded;
        }

        public Jnle jnle() => default;

        [MethodImpl(Inline), Op]
        public Jnle jnle(AsmHexCode encoded) => new Jnle(encoded);

        public struct Jno : ITypedInstruction<Jno>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jno(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNO;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jno src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jno src) => AsmMnemonics.JNO;

            public static implicit operator AsmHexCode(Jno src) => src.Encoded;
        }

        public Jno jno() => default;

        [MethodImpl(Inline), Op]
        public Jno jno(AsmHexCode encoded) => new Jno(encoded);

        public struct Jnp : ITypedInstruction<Jnp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jnp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jnp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnp src) => AsmMnemonics.JNP;

            public static implicit operator AsmHexCode(Jnp src) => src.Encoded;
        }

        public Jnp jnp() => default;

        [MethodImpl(Inline), Op]
        public Jnp jnp(AsmHexCode encoded) => new Jnp(encoded);

        public struct Jns : ITypedInstruction<Jns>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jns(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jns src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jns src) => AsmMnemonics.JNS;

            public static implicit operator AsmHexCode(Jns src) => src.Encoded;
        }

        public Jns jns() => default;

        [MethodImpl(Inline), Op]
        public Jns jns(AsmHexCode encoded) => new Jns(encoded);

        public struct Jnz : ITypedInstruction<Jnz>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jnz(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNZ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jnz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnz src) => AsmMnemonics.JNZ;

            public static implicit operator AsmHexCode(Jnz src) => src.Encoded;
        }

        public Jnz jnz() => default;

        [MethodImpl(Inline), Op]
        public Jnz jnz(AsmHexCode encoded) => new Jnz(encoded);

        public struct Jo : ITypedInstruction<Jo>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jo(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JO;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jo src) => AsmMnemonics.JO;

            public static implicit operator AsmHexCode(Jo src) => src.Encoded;
        }

        public Jo jo() => default;

        [MethodImpl(Inline), Op]
        public Jo jo(AsmHexCode encoded) => new Jo(encoded);

        public struct Jp : ITypedInstruction<Jp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jp src) => AsmMnemonics.JP;

            public static implicit operator AsmHexCode(Jp src) => src.Encoded;
        }

        public Jp jp() => default;

        [MethodImpl(Inline), Op]
        public Jp jp(AsmHexCode encoded) => new Jp(encoded);

        public struct Jpe : ITypedInstruction<Jpe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jpe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JPE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jpe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jpe src) => AsmMnemonics.JPE;

            public static implicit operator AsmHexCode(Jpe src) => src.Encoded;
        }

        public Jpe jpe() => default;

        [MethodImpl(Inline), Op]
        public Jpe jpe(AsmHexCode encoded) => new Jpe(encoded);

        public struct Jpo : ITypedInstruction<Jpo>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jpo(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JPO;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jpo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jpo src) => AsmMnemonics.JPO;

            public static implicit operator AsmHexCode(Jpo src) => src.Encoded;
        }

        public Jpo jpo() => default;

        [MethodImpl(Inline), Op]
        public Jpo jpo(AsmHexCode encoded) => new Jpo(encoded);

        public struct Js : ITypedInstruction<Js>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Js(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Js src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Js src) => AsmMnemonics.JS;

            public static implicit operator AsmHexCode(Js src) => src.Encoded;
        }

        public Js js() => default;

        [MethodImpl(Inline), Op]
        public Js js(AsmHexCode encoded) => new Js(encoded);

        public struct Jz : ITypedInstruction<Jz>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jz(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JZ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jz src) => AsmMnemonics.JZ;

            public static implicit operator AsmHexCode(Jz src) => src.Encoded;
        }

        public Jz jz() => default;

        [MethodImpl(Inline), Op]
        public Jz jz(AsmHexCode encoded) => new Jz(encoded);

        public struct Jmp : ITypedInstruction<Jmp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Jmp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JMP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Jmp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jmp src) => AsmMnemonics.JMP;

            public static implicit operator AsmHexCode(Jmp src) => src.Encoded;
        }

        public Jmp jmp() => default;

        [MethodImpl(Inline), Op]
        public Jmp jmp(AsmHexCode encoded) => new Jmp(encoded);

        public struct Lahf : ITypedInstruction<Lahf>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lahf(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LAHF;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lahf src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lahf src) => AsmMnemonics.LAHF;

            public static implicit operator AsmHexCode(Lahf src) => src.Encoded;
        }

        public Lahf lahf() => default;

        [MethodImpl(Inline), Op]
        public Lahf lahf(AsmHexCode encoded) => new Lahf(encoded);

        public struct Lar : ITypedInstruction<Lar>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lar(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LAR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lar src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lar src) => AsmMnemonics.LAR;

            public static implicit operator AsmHexCode(Lar src) => src.Encoded;
        }

        public Lar lar() => default;

        [MethodImpl(Inline), Op]
        public Lar lar(AsmHexCode encoded) => new Lar(encoded);

        public struct Lddqu : ITypedInstruction<Lddqu>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lddqu(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LDDQU;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lddqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lddqu src) => AsmMnemonics.LDDQU;

            public static implicit operator AsmHexCode(Lddqu src) => src.Encoded;
        }

        public Lddqu lddqu() => default;

        [MethodImpl(Inline), Op]
        public Lddqu lddqu(AsmHexCode encoded) => new Lddqu(encoded);

        public struct Vlddqu : ITypedInstruction<Vlddqu>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vlddqu(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VLDDQU;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vlddqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vlddqu src) => AsmMnemonics.VLDDQU;

            public static implicit operator AsmHexCode(Vlddqu src) => src.Encoded;
        }

        public Vlddqu vlddqu() => default;

        [MethodImpl(Inline), Op]
        public Vlddqu vlddqu(AsmHexCode encoded) => new Vlddqu(encoded);

        public struct Ldmxcsr : ITypedInstruction<Ldmxcsr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ldmxcsr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LDMXCSR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ldmxcsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ldmxcsr src) => AsmMnemonics.LDMXCSR;

            public static implicit operator AsmHexCode(Ldmxcsr src) => src.Encoded;
        }

        public Ldmxcsr ldmxcsr() => default;

        [MethodImpl(Inline), Op]
        public Ldmxcsr ldmxcsr(AsmHexCode encoded) => new Ldmxcsr(encoded);

        public struct Vldmxcsr : ITypedInstruction<Vldmxcsr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vldmxcsr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VLDMXCSR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vldmxcsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vldmxcsr src) => AsmMnemonics.VLDMXCSR;

            public static implicit operator AsmHexCode(Vldmxcsr src) => src.Encoded;
        }

        public Vldmxcsr vldmxcsr() => default;

        [MethodImpl(Inline), Op]
        public Vldmxcsr vldmxcsr(AsmHexCode encoded) => new Vldmxcsr(encoded);

        public struct Lds : ITypedInstruction<Lds>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lds(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LDS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lds src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lds src) => AsmMnemonics.LDS;

            public static implicit operator AsmHexCode(Lds src) => src.Encoded;
        }

        public Lds lds() => default;

        [MethodImpl(Inline), Op]
        public Lds lds(AsmHexCode encoded) => new Lds(encoded);

        public struct Lss : ITypedInstruction<Lss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lss src) => AsmMnemonics.LSS;

            public static implicit operator AsmHexCode(Lss src) => src.Encoded;
        }

        public Lss lss() => default;

        [MethodImpl(Inline), Op]
        public Lss lss(AsmHexCode encoded) => new Lss(encoded);

        public struct Les : ITypedInstruction<Les>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Les(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LES;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Les src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Les src) => AsmMnemonics.LES;

            public static implicit operator AsmHexCode(Les src) => src.Encoded;
        }

        public Les les() => default;

        [MethodImpl(Inline), Op]
        public Les les(AsmHexCode encoded) => new Les(encoded);

        public struct Lfs : ITypedInstruction<Lfs>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lfs(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LFS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lfs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lfs src) => AsmMnemonics.LFS;

            public static implicit operator AsmHexCode(Lfs src) => src.Encoded;
        }

        public Lfs lfs() => default;

        [MethodImpl(Inline), Op]
        public Lfs lfs(AsmHexCode encoded) => new Lfs(encoded);

        public struct Lgs : ITypedInstruction<Lgs>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lgs(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LGS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lgs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lgs src) => AsmMnemonics.LGS;

            public static implicit operator AsmHexCode(Lgs src) => src.Encoded;
        }

        public Lgs lgs() => default;

        [MethodImpl(Inline), Op]
        public Lgs lgs(AsmHexCode encoded) => new Lgs(encoded);

        public struct Lea : ITypedInstruction<Lea>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lea(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LEA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lea src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lea src) => AsmMnemonics.LEA;

            public static implicit operator AsmHexCode(Lea src) => src.Encoded;
        }

        public Lea lea() => default;

        [MethodImpl(Inline), Op]
        public Lea lea(AsmHexCode encoded) => new Lea(encoded);

        public struct Leave : ITypedInstruction<Leave>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Leave(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LEAVE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Leave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Leave src) => AsmMnemonics.LEAVE;

            public static implicit operator AsmHexCode(Leave src) => src.Encoded;
        }

        public Leave leave() => default;

        [MethodImpl(Inline), Op]
        public Leave leave(AsmHexCode encoded) => new Leave(encoded);

        public struct Lfence : ITypedInstruction<Lfence>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lfence(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LFENCE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lfence src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lfence src) => AsmMnemonics.LFENCE;

            public static implicit operator AsmHexCode(Lfence src) => src.Encoded;
        }

        public Lfence lfence() => default;

        [MethodImpl(Inline), Op]
        public Lfence lfence(AsmHexCode encoded) => new Lfence(encoded);

        public struct Lgdt : ITypedInstruction<Lgdt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lgdt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LGDT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lgdt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lgdt src) => AsmMnemonics.LGDT;

            public static implicit operator AsmHexCode(Lgdt src) => src.Encoded;
        }

        public Lgdt lgdt() => default;

        [MethodImpl(Inline), Op]
        public Lgdt lgdt(AsmHexCode encoded) => new Lgdt(encoded);

        public struct Lidt : ITypedInstruction<Lidt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lidt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LIDT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lidt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lidt src) => AsmMnemonics.LIDT;

            public static implicit operator AsmHexCode(Lidt src) => src.Encoded;
        }

        public Lidt lidt() => default;

        [MethodImpl(Inline), Op]
        public Lidt lidt(AsmHexCode encoded) => new Lidt(encoded);

        public struct Lldt : ITypedInstruction<Lldt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lldt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LLDT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lldt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lldt src) => AsmMnemonics.LLDT;

            public static implicit operator AsmHexCode(Lldt src) => src.Encoded;
        }

        public Lldt lldt() => default;

        [MethodImpl(Inline), Op]
        public Lldt lldt(AsmHexCode encoded) => new Lldt(encoded);

        public struct Lmsw : ITypedInstruction<Lmsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lmsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LMSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lmsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lmsw src) => AsmMnemonics.LMSW;

            public static implicit operator AsmHexCode(Lmsw src) => src.Encoded;
        }

        public Lmsw lmsw() => default;

        [MethodImpl(Inline), Op]
        public Lmsw lmsw(AsmHexCode encoded) => new Lmsw(encoded);

        public struct Lock : ITypedInstruction<Lock>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lock(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOCK;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lock src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lock src) => AsmMnemonics.LOCK;

            public static implicit operator AsmHexCode(Lock src) => src.Encoded;
        }

        public Lock @lock() => default;

        [MethodImpl(Inline), Op]
        public Lock @lock(AsmHexCode encoded) => new Lock(encoded);

        public struct Lods : ITypedInstruction<Lods>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lods(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LODS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lods src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lods src) => AsmMnemonics.LODS;

            public static implicit operator AsmHexCode(Lods src) => src.Encoded;
        }

        public Lods lods() => default;

        [MethodImpl(Inline), Op]
        public Lods lods(AsmHexCode encoded) => new Lods(encoded);

        public struct Lodsb : ITypedInstruction<Lodsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lodsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LODSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lodsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lodsb src) => AsmMnemonics.LODSB;

            public static implicit operator AsmHexCode(Lodsb src) => src.Encoded;
        }

        public Lodsb lodsb() => default;

        [MethodImpl(Inline), Op]
        public Lodsb lodsb(AsmHexCode encoded) => new Lodsb(encoded);

        public struct Lodsw : ITypedInstruction<Lodsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lodsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LODSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lodsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lodsw src) => AsmMnemonics.LODSW;

            public static implicit operator AsmHexCode(Lodsw src) => src.Encoded;
        }

        public Lodsw lodsw() => default;

        [MethodImpl(Inline), Op]
        public Lodsw lodsw(AsmHexCode encoded) => new Lodsw(encoded);

        public struct Lodsd : ITypedInstruction<Lodsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lodsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LODSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lodsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lodsd src) => AsmMnemonics.LODSD;

            public static implicit operator AsmHexCode(Lodsd src) => src.Encoded;
        }

        public Lodsd lodsd() => default;

        [MethodImpl(Inline), Op]
        public Lodsd lodsd(AsmHexCode encoded) => new Lodsd(encoded);

        public struct Lodsq : ITypedInstruction<Lodsq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lodsq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LODSQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lodsq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lodsq src) => AsmMnemonics.LODSQ;

            public static implicit operator AsmHexCode(Lodsq src) => src.Encoded;
        }

        public Lodsq lodsq() => default;

        [MethodImpl(Inline), Op]
        public Lodsq lodsq(AsmHexCode encoded) => new Lodsq(encoded);

        public struct Loop : ITypedInstruction<Loop>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Loop(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOOP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Loop src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Loop src) => AsmMnemonics.LOOP;

            public static implicit operator AsmHexCode(Loop src) => src.Encoded;
        }

        public Loop loop() => default;

        [MethodImpl(Inline), Op]
        public Loop loop(AsmHexCode encoded) => new Loop(encoded);

        public struct Loope : ITypedInstruction<Loope>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Loope(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOOPE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Loope src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Loope src) => AsmMnemonics.LOOPE;

            public static implicit operator AsmHexCode(Loope src) => src.Encoded;
        }

        public Loope loope() => default;

        [MethodImpl(Inline), Op]
        public Loope loope(AsmHexCode encoded) => new Loope(encoded);

        public struct Loopne : ITypedInstruction<Loopne>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Loopne(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOOPNE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Loopne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Loopne src) => AsmMnemonics.LOOPNE;

            public static implicit operator AsmHexCode(Loopne src) => src.Encoded;
        }

        public Loopne loopne() => default;

        [MethodImpl(Inline), Op]
        public Loopne loopne(AsmHexCode encoded) => new Loopne(encoded);

        public struct Lsl : ITypedInstruction<Lsl>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lsl(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LSL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lsl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lsl src) => AsmMnemonics.LSL;

            public static implicit operator AsmHexCode(Lsl src) => src.Encoded;
        }

        public Lsl lsl() => default;

        [MethodImpl(Inline), Op]
        public Lsl lsl(AsmHexCode encoded) => new Lsl(encoded);

        public struct Ltr : ITypedInstruction<Ltr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ltr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LTR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ltr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ltr src) => AsmMnemonics.LTR;

            public static implicit operator AsmHexCode(Ltr src) => src.Encoded;
        }

        public Ltr ltr() => default;

        [MethodImpl(Inline), Op]
        public Ltr ltr(AsmHexCode encoded) => new Ltr(encoded);

        public struct Lzcnt : ITypedInstruction<Lzcnt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Lzcnt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LZCNT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Lzcnt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lzcnt src) => AsmMnemonics.LZCNT;

            public static implicit operator AsmHexCode(Lzcnt src) => src.Encoded;
        }

        public Lzcnt lzcnt() => default;

        [MethodImpl(Inline), Op]
        public Lzcnt lzcnt(AsmHexCode encoded) => new Lzcnt(encoded);

        public struct Maskmovdqu : ITypedInstruction<Maskmovdqu>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Maskmovdqu(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MASKMOVDQU;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Maskmovdqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maskmovdqu src) => AsmMnemonics.MASKMOVDQU;

            public static implicit operator AsmHexCode(Maskmovdqu src) => src.Encoded;
        }

        public Maskmovdqu maskmovdqu() => default;

        [MethodImpl(Inline), Op]
        public Maskmovdqu maskmovdqu(AsmHexCode encoded) => new Maskmovdqu(encoded);

        public struct Vmaskmovdqu : ITypedInstruction<Vmaskmovdqu>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmaskmovdqu(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMASKMOVDQU;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmaskmovdqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaskmovdqu src) => AsmMnemonics.VMASKMOVDQU;

            public static implicit operator AsmHexCode(Vmaskmovdqu src) => src.Encoded;
        }

        public Vmaskmovdqu vmaskmovdqu() => default;

        [MethodImpl(Inline), Op]
        public Vmaskmovdqu vmaskmovdqu(AsmHexCode encoded) => new Vmaskmovdqu(encoded);

        public struct Maskmovq : ITypedInstruction<Maskmovq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Maskmovq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MASKMOVQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Maskmovq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maskmovq src) => AsmMnemonics.MASKMOVQ;

            public static implicit operator AsmHexCode(Maskmovq src) => src.Encoded;
        }

        public Maskmovq maskmovq() => default;

        [MethodImpl(Inline), Op]
        public Maskmovq maskmovq(AsmHexCode encoded) => new Maskmovq(encoded);

        public struct Maxpd : ITypedInstruction<Maxpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Maxpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Maxpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maxpd src) => AsmMnemonics.MAXPD;

            public static implicit operator AsmHexCode(Maxpd src) => src.Encoded;
        }

        public Maxpd maxpd() => default;

        [MethodImpl(Inline), Op]
        public Maxpd maxpd(AsmHexCode encoded) => new Maxpd(encoded);

        public struct Vmaxpd : ITypedInstruction<Vmaxpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmaxpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmaxpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaxpd src) => AsmMnemonics.VMAXPD;

            public static implicit operator AsmHexCode(Vmaxpd src) => src.Encoded;
        }

        public Vmaxpd vmaxpd() => default;

        [MethodImpl(Inline), Op]
        public Vmaxpd vmaxpd(AsmHexCode encoded) => new Vmaxpd(encoded);

        public struct Maxps : ITypedInstruction<Maxps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Maxps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Maxps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maxps src) => AsmMnemonics.MAXPS;

            public static implicit operator AsmHexCode(Maxps src) => src.Encoded;
        }

        public Maxps maxps() => default;

        [MethodImpl(Inline), Op]
        public Maxps maxps(AsmHexCode encoded) => new Maxps(encoded);

        public struct Vmaxps : ITypedInstruction<Vmaxps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmaxps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmaxps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaxps src) => AsmMnemonics.VMAXPS;

            public static implicit operator AsmHexCode(Vmaxps src) => src.Encoded;
        }

        public Vmaxps vmaxps() => default;

        [MethodImpl(Inline), Op]
        public Vmaxps vmaxps(AsmHexCode encoded) => new Vmaxps(encoded);

        public struct Maxsd : ITypedInstruction<Maxsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Maxsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Maxsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maxsd src) => AsmMnemonics.MAXSD;

            public static implicit operator AsmHexCode(Maxsd src) => src.Encoded;
        }

        public Maxsd maxsd() => default;

        [MethodImpl(Inline), Op]
        public Maxsd maxsd(AsmHexCode encoded) => new Maxsd(encoded);

        public struct Vmaxsd : ITypedInstruction<Vmaxsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmaxsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmaxsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaxsd src) => AsmMnemonics.VMAXSD;

            public static implicit operator AsmHexCode(Vmaxsd src) => src.Encoded;
        }

        public Vmaxsd vmaxsd() => default;

        [MethodImpl(Inline), Op]
        public Vmaxsd vmaxsd(AsmHexCode encoded) => new Vmaxsd(encoded);

        public struct Maxss : ITypedInstruction<Maxss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Maxss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Maxss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maxss src) => AsmMnemonics.MAXSS;

            public static implicit operator AsmHexCode(Maxss src) => src.Encoded;
        }

        public Maxss maxss() => default;

        [MethodImpl(Inline), Op]
        public Maxss maxss(AsmHexCode encoded) => new Maxss(encoded);

        public struct Vmaxss : ITypedInstruction<Vmaxss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmaxss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmaxss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaxss src) => AsmMnemonics.VMAXSS;

            public static implicit operator AsmHexCode(Vmaxss src) => src.Encoded;
        }

        public Vmaxss vmaxss() => default;

        [MethodImpl(Inline), Op]
        public Vmaxss vmaxss(AsmHexCode encoded) => new Vmaxss(encoded);

        public struct Mfence : ITypedInstruction<Mfence>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Mfence(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MFENCE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Mfence src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mfence src) => AsmMnemonics.MFENCE;

            public static implicit operator AsmHexCode(Mfence src) => src.Encoded;
        }

        public Mfence mfence() => default;

        [MethodImpl(Inline), Op]
        public Mfence mfence(AsmHexCode encoded) => new Mfence(encoded);

        public struct Minpd : ITypedInstruction<Minpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Minpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Minpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Minpd src) => AsmMnemonics.MINPD;

            public static implicit operator AsmHexCode(Minpd src) => src.Encoded;
        }

        public Minpd minpd() => default;

        [MethodImpl(Inline), Op]
        public Minpd minpd(AsmHexCode encoded) => new Minpd(encoded);

        public struct Vminpd : ITypedInstruction<Vminpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vminpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vminpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vminpd src) => AsmMnemonics.VMINPD;

            public static implicit operator AsmHexCode(Vminpd src) => src.Encoded;
        }

        public Vminpd vminpd() => default;

        [MethodImpl(Inline), Op]
        public Vminpd vminpd(AsmHexCode encoded) => new Vminpd(encoded);

        public struct Minps : ITypedInstruction<Minps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Minps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Minps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Minps src) => AsmMnemonics.MINPS;

            public static implicit operator AsmHexCode(Minps src) => src.Encoded;
        }

        public Minps minps() => default;

        [MethodImpl(Inline), Op]
        public Minps minps(AsmHexCode encoded) => new Minps(encoded);

        public struct Vminps : ITypedInstruction<Vminps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vminps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vminps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vminps src) => AsmMnemonics.VMINPS;

            public static implicit operator AsmHexCode(Vminps src) => src.Encoded;
        }

        public Vminps vminps() => default;

        [MethodImpl(Inline), Op]
        public Vminps vminps(AsmHexCode encoded) => new Vminps(encoded);

        public struct Minsd : ITypedInstruction<Minsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Minsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Minsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Minsd src) => AsmMnemonics.MINSD;

            public static implicit operator AsmHexCode(Minsd src) => src.Encoded;
        }

        public Minsd minsd() => default;

        [MethodImpl(Inline), Op]
        public Minsd minsd(AsmHexCode encoded) => new Minsd(encoded);

        public struct Vminsd : ITypedInstruction<Vminsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vminsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vminsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vminsd src) => AsmMnemonics.VMINSD;

            public static implicit operator AsmHexCode(Vminsd src) => src.Encoded;
        }

        public Vminsd vminsd() => default;

        [MethodImpl(Inline), Op]
        public Vminsd vminsd(AsmHexCode encoded) => new Vminsd(encoded);

        public struct Minss : ITypedInstruction<Minss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Minss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Minss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Minss src) => AsmMnemonics.MINSS;

            public static implicit operator AsmHexCode(Minss src) => src.Encoded;
        }

        public Minss minss() => default;

        [MethodImpl(Inline), Op]
        public Minss minss(AsmHexCode encoded) => new Minss(encoded);

        public struct Vminss : ITypedInstruction<Vminss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vminss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vminss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vminss src) => AsmMnemonics.VMINSS;

            public static implicit operator AsmHexCode(Vminss src) => src.Encoded;
        }

        public Vminss vminss() => default;

        [MethodImpl(Inline), Op]
        public Vminss vminss(AsmHexCode encoded) => new Vminss(encoded);

        public struct Monitor : ITypedInstruction<Monitor>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Monitor(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MONITOR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Monitor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Monitor src) => AsmMnemonics.MONITOR;

            public static implicit operator AsmHexCode(Monitor src) => src.Encoded;
        }

        public Monitor monitor() => default;

        [MethodImpl(Inline), Op]
        public Monitor monitor(AsmHexCode encoded) => new Monitor(encoded);

        public struct Mov : ITypedInstruction<Mov>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Mov(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOV;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Mov src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mov src) => AsmMnemonics.MOV;

            public static implicit operator AsmHexCode(Mov src) => src.Encoded;
        }

        public Mov mov() => default;

        [MethodImpl(Inline), Op]
        public Mov mov(AsmHexCode encoded) => new Mov(encoded);

        public struct Movapd : ITypedInstruction<Movapd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movapd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVAPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movapd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movapd src) => AsmMnemonics.MOVAPD;

            public static implicit operator AsmHexCode(Movapd src) => src.Encoded;
        }

        public Movapd movapd() => default;

        [MethodImpl(Inline), Op]
        public Movapd movapd(AsmHexCode encoded) => new Movapd(encoded);

        public struct Vmovapd : ITypedInstruction<Vmovapd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovapd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVAPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovapd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovapd src) => AsmMnemonics.VMOVAPD;

            public static implicit operator AsmHexCode(Vmovapd src) => src.Encoded;
        }

        public Vmovapd vmovapd() => default;

        [MethodImpl(Inline), Op]
        public Vmovapd vmovapd(AsmHexCode encoded) => new Vmovapd(encoded);

        public struct Movaps : ITypedInstruction<Movaps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movaps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVAPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movaps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movaps src) => AsmMnemonics.MOVAPS;

            public static implicit operator AsmHexCode(Movaps src) => src.Encoded;
        }

        public Movaps movaps() => default;

        [MethodImpl(Inline), Op]
        public Movaps movaps(AsmHexCode encoded) => new Movaps(encoded);

        public struct Vmovaps : ITypedInstruction<Vmovaps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovaps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVAPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovaps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovaps src) => AsmMnemonics.VMOVAPS;

            public static implicit operator AsmHexCode(Vmovaps src) => src.Encoded;
        }

        public Vmovaps vmovaps() => default;

        [MethodImpl(Inline), Op]
        public Vmovaps vmovaps(AsmHexCode encoded) => new Vmovaps(encoded);

        public struct Movbe : ITypedInstruction<Movbe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movbe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVBE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movbe src) => AsmMnemonics.MOVBE;

            public static implicit operator AsmHexCode(Movbe src) => src.Encoded;
        }

        public Movbe movbe() => default;

        [MethodImpl(Inline), Op]
        public Movbe movbe(AsmHexCode encoded) => new Movbe(encoded);

        public struct Movd : ITypedInstruction<Movd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movd src) => AsmMnemonics.MOVD;

            public static implicit operator AsmHexCode(Movd src) => src.Encoded;
        }

        public Movd movd() => default;

        [MethodImpl(Inline), Op]
        public Movd movd(AsmHexCode encoded) => new Movd(encoded);

        public struct Movq : ITypedInstruction<Movq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movq src) => AsmMnemonics.MOVQ;

            public static implicit operator AsmHexCode(Movq src) => src.Encoded;
        }

        public Movq movq() => default;

        [MethodImpl(Inline), Op]
        public Movq movq(AsmHexCode encoded) => new Movq(encoded);

        public struct Vmovd : ITypedInstruction<Vmovd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovd src) => AsmMnemonics.VMOVD;

            public static implicit operator AsmHexCode(Vmovd src) => src.Encoded;
        }

        public Vmovd vmovd() => default;

        [MethodImpl(Inline), Op]
        public Vmovd vmovd(AsmHexCode encoded) => new Vmovd(encoded);

        public struct Vmovq : ITypedInstruction<Vmovq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovq src) => AsmMnemonics.VMOVQ;

            public static implicit operator AsmHexCode(Vmovq src) => src.Encoded;
        }

        public Vmovq vmovq() => default;

        [MethodImpl(Inline), Op]
        public Vmovq vmovq(AsmHexCode encoded) => new Vmovq(encoded);

        public struct Movddup : ITypedInstruction<Movddup>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movddup(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDDUP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movddup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movddup src) => AsmMnemonics.MOVDDUP;

            public static implicit operator AsmHexCode(Movddup src) => src.Encoded;
        }

        public Movddup movddup() => default;

        [MethodImpl(Inline), Op]
        public Movddup movddup(AsmHexCode encoded) => new Movddup(encoded);

        public struct Vmovddup : ITypedInstruction<Vmovddup>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovddup(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVDDUP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovddup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovddup src) => AsmMnemonics.VMOVDDUP;

            public static implicit operator AsmHexCode(Vmovddup src) => src.Encoded;
        }

        public Vmovddup vmovddup() => default;

        [MethodImpl(Inline), Op]
        public Vmovddup vmovddup(AsmHexCode encoded) => new Vmovddup(encoded);

        public struct Movdqa : ITypedInstruction<Movdqa>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movdqa(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDQA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movdqa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movdqa src) => AsmMnemonics.MOVDQA;

            public static implicit operator AsmHexCode(Movdqa src) => src.Encoded;
        }

        public Movdqa movdqa() => default;

        [MethodImpl(Inline), Op]
        public Movdqa movdqa(AsmHexCode encoded) => new Movdqa(encoded);

        public struct Vmovdqa : ITypedInstruction<Vmovdqa>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovdqa(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVDQA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovdqa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovdqa src) => AsmMnemonics.VMOVDQA;

            public static implicit operator AsmHexCode(Vmovdqa src) => src.Encoded;
        }

        public Vmovdqa vmovdqa() => default;

        [MethodImpl(Inline), Op]
        public Vmovdqa vmovdqa(AsmHexCode encoded) => new Vmovdqa(encoded);

        public struct Movdqu : ITypedInstruction<Movdqu>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movdqu(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDQU;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movdqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movdqu src) => AsmMnemonics.MOVDQU;

            public static implicit operator AsmHexCode(Movdqu src) => src.Encoded;
        }

        public Movdqu movdqu() => default;

        [MethodImpl(Inline), Op]
        public Movdqu movdqu(AsmHexCode encoded) => new Movdqu(encoded);

        public struct Vmovdqu : ITypedInstruction<Vmovdqu>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovdqu(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVDQU;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovdqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovdqu src) => AsmMnemonics.VMOVDQU;

            public static implicit operator AsmHexCode(Vmovdqu src) => src.Encoded;
        }

        public Vmovdqu vmovdqu() => default;

        [MethodImpl(Inline), Op]
        public Vmovdqu vmovdqu(AsmHexCode encoded) => new Vmovdqu(encoded);

        public struct Movdq2q : ITypedInstruction<Movdq2q>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movdq2q(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDQ2Q;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movdq2q src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movdq2q src) => AsmMnemonics.MOVDQ2Q;

            public static implicit operator AsmHexCode(Movdq2q src) => src.Encoded;
        }

        public Movdq2q movdq2q() => default;

        [MethodImpl(Inline), Op]
        public Movdq2q movdq2q(AsmHexCode encoded) => new Movdq2q(encoded);

        public struct Movhlps : ITypedInstruction<Movhlps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movhlps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVHLPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movhlps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movhlps src) => AsmMnemonics.MOVHLPS;

            public static implicit operator AsmHexCode(Movhlps src) => src.Encoded;
        }

        public Movhlps movhlps() => default;

        [MethodImpl(Inline), Op]
        public Movhlps movhlps(AsmHexCode encoded) => new Movhlps(encoded);

        public struct Vmovhlps : ITypedInstruction<Vmovhlps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovhlps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVHLPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovhlps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovhlps src) => AsmMnemonics.VMOVHLPS;

            public static implicit operator AsmHexCode(Vmovhlps src) => src.Encoded;
        }

        public Vmovhlps vmovhlps() => default;

        [MethodImpl(Inline), Op]
        public Vmovhlps vmovhlps(AsmHexCode encoded) => new Vmovhlps(encoded);

        public struct Movhpd : ITypedInstruction<Movhpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movhpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVHPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movhpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movhpd src) => AsmMnemonics.MOVHPD;

            public static implicit operator AsmHexCode(Movhpd src) => src.Encoded;
        }

        public Movhpd movhpd() => default;

        [MethodImpl(Inline), Op]
        public Movhpd movhpd(AsmHexCode encoded) => new Movhpd(encoded);

        public struct Vmovhpd : ITypedInstruction<Vmovhpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovhpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVHPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovhpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovhpd src) => AsmMnemonics.VMOVHPD;

            public static implicit operator AsmHexCode(Vmovhpd src) => src.Encoded;
        }

        public Vmovhpd vmovhpd() => default;

        [MethodImpl(Inline), Op]
        public Vmovhpd vmovhpd(AsmHexCode encoded) => new Vmovhpd(encoded);

        public struct Movhps : ITypedInstruction<Movhps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movhps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVHPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movhps src) => AsmMnemonics.MOVHPS;

            public static implicit operator AsmHexCode(Movhps src) => src.Encoded;
        }

        public Movhps movhps() => default;

        [MethodImpl(Inline), Op]
        public Movhps movhps(AsmHexCode encoded) => new Movhps(encoded);

        public struct Vmovhps : ITypedInstruction<Vmovhps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovhps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVHPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovhps src) => AsmMnemonics.VMOVHPS;

            public static implicit operator AsmHexCode(Vmovhps src) => src.Encoded;
        }

        public Vmovhps vmovhps() => default;

        [MethodImpl(Inline), Op]
        public Vmovhps vmovhps(AsmHexCode encoded) => new Vmovhps(encoded);

        public struct Movlhps : ITypedInstruction<Movlhps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movlhps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVLHPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movlhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movlhps src) => AsmMnemonics.MOVLHPS;

            public static implicit operator AsmHexCode(Movlhps src) => src.Encoded;
        }

        public Movlhps movlhps() => default;

        [MethodImpl(Inline), Op]
        public Movlhps movlhps(AsmHexCode encoded) => new Movlhps(encoded);

        public struct Vmovlhps : ITypedInstruction<Vmovlhps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovlhps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVLHPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovlhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovlhps src) => AsmMnemonics.VMOVLHPS;

            public static implicit operator AsmHexCode(Vmovlhps src) => src.Encoded;
        }

        public Vmovlhps vmovlhps() => default;

        [MethodImpl(Inline), Op]
        public Vmovlhps vmovlhps(AsmHexCode encoded) => new Vmovlhps(encoded);

        public struct Movlpd : ITypedInstruction<Movlpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movlpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVLPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movlpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movlpd src) => AsmMnemonics.MOVLPD;

            public static implicit operator AsmHexCode(Movlpd src) => src.Encoded;
        }

        public Movlpd movlpd() => default;

        [MethodImpl(Inline), Op]
        public Movlpd movlpd(AsmHexCode encoded) => new Movlpd(encoded);

        public struct Vmovlpd : ITypedInstruction<Vmovlpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovlpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVLPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovlpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovlpd src) => AsmMnemonics.VMOVLPD;

            public static implicit operator AsmHexCode(Vmovlpd src) => src.Encoded;
        }

        public Vmovlpd vmovlpd() => default;

        [MethodImpl(Inline), Op]
        public Vmovlpd vmovlpd(AsmHexCode encoded) => new Vmovlpd(encoded);

        public struct Movlps : ITypedInstruction<Movlps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movlps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVLPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movlps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movlps src) => AsmMnemonics.MOVLPS;

            public static implicit operator AsmHexCode(Movlps src) => src.Encoded;
        }

        public Movlps movlps() => default;

        [MethodImpl(Inline), Op]
        public Movlps movlps(AsmHexCode encoded) => new Movlps(encoded);

        public struct Vmovlps : ITypedInstruction<Vmovlps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovlps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVLPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovlps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovlps src) => AsmMnemonics.VMOVLPS;

            public static implicit operator AsmHexCode(Vmovlps src) => src.Encoded;
        }

        public Vmovlps vmovlps() => default;

        [MethodImpl(Inline), Op]
        public Vmovlps vmovlps(AsmHexCode encoded) => new Vmovlps(encoded);

        public struct Movmskpd : ITypedInstruction<Movmskpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movmskpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVMSKPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movmskpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movmskpd src) => AsmMnemonics.MOVMSKPD;

            public static implicit operator AsmHexCode(Movmskpd src) => src.Encoded;
        }

        public Movmskpd movmskpd() => default;

        [MethodImpl(Inline), Op]
        public Movmskpd movmskpd(AsmHexCode encoded) => new Movmskpd(encoded);

        public struct Vmovmskpd : ITypedInstruction<Vmovmskpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovmskpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVMSKPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovmskpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovmskpd src) => AsmMnemonics.VMOVMSKPD;

            public static implicit operator AsmHexCode(Vmovmskpd src) => src.Encoded;
        }

        public Vmovmskpd vmovmskpd() => default;

        [MethodImpl(Inline), Op]
        public Vmovmskpd vmovmskpd(AsmHexCode encoded) => new Vmovmskpd(encoded);

        public struct Movmskps : ITypedInstruction<Movmskps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movmskps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVMSKPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movmskps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movmskps src) => AsmMnemonics.MOVMSKPS;

            public static implicit operator AsmHexCode(Movmskps src) => src.Encoded;
        }

        public Movmskps movmskps() => default;

        [MethodImpl(Inline), Op]
        public Movmskps movmskps(AsmHexCode encoded) => new Movmskps(encoded);

        public struct Vmovmskps : ITypedInstruction<Vmovmskps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovmskps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVMSKPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovmskps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovmskps src) => AsmMnemonics.VMOVMSKPS;

            public static implicit operator AsmHexCode(Vmovmskps src) => src.Encoded;
        }

        public Vmovmskps vmovmskps() => default;

        [MethodImpl(Inline), Op]
        public Vmovmskps vmovmskps(AsmHexCode encoded) => new Vmovmskps(encoded);

        public struct Movntdqa : ITypedInstruction<Movntdqa>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movntdqa(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTDQA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movntdqa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntdqa src) => AsmMnemonics.MOVNTDQA;

            public static implicit operator AsmHexCode(Movntdqa src) => src.Encoded;
        }

        public Movntdqa movntdqa() => default;

        [MethodImpl(Inline), Op]
        public Movntdqa movntdqa(AsmHexCode encoded) => new Movntdqa(encoded);

        public struct Vmovntdqa : ITypedInstruction<Vmovntdqa>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovntdqa(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTDQA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovntdqa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovntdqa src) => AsmMnemonics.VMOVNTDQA;

            public static implicit operator AsmHexCode(Vmovntdqa src) => src.Encoded;
        }

        public Vmovntdqa vmovntdqa() => default;

        [MethodImpl(Inline), Op]
        public Vmovntdqa vmovntdqa(AsmHexCode encoded) => new Vmovntdqa(encoded);

        public struct Movntdq : ITypedInstruction<Movntdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movntdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movntdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntdq src) => AsmMnemonics.MOVNTDQ;

            public static implicit operator AsmHexCode(Movntdq src) => src.Encoded;
        }

        public Movntdq movntdq() => default;

        [MethodImpl(Inline), Op]
        public Movntdq movntdq(AsmHexCode encoded) => new Movntdq(encoded);

        public struct Vmovntdq : ITypedInstruction<Vmovntdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovntdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovntdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovntdq src) => AsmMnemonics.VMOVNTDQ;

            public static implicit operator AsmHexCode(Vmovntdq src) => src.Encoded;
        }

        public Vmovntdq vmovntdq() => default;

        [MethodImpl(Inline), Op]
        public Vmovntdq vmovntdq(AsmHexCode encoded) => new Vmovntdq(encoded);

        public struct Movnti : ITypedInstruction<Movnti>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movnti(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movnti src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movnti src) => AsmMnemonics.MOVNTI;

            public static implicit operator AsmHexCode(Movnti src) => src.Encoded;
        }

        public Movnti movnti() => default;

        [MethodImpl(Inline), Op]
        public Movnti movnti(AsmHexCode encoded) => new Movnti(encoded);

        public struct Movntpd : ITypedInstruction<Movntpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movntpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movntpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntpd src) => AsmMnemonics.MOVNTPD;

            public static implicit operator AsmHexCode(Movntpd src) => src.Encoded;
        }

        public Movntpd movntpd() => default;

        [MethodImpl(Inline), Op]
        public Movntpd movntpd(AsmHexCode encoded) => new Movntpd(encoded);

        public struct Vmovntpd : ITypedInstruction<Vmovntpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovntpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovntpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovntpd src) => AsmMnemonics.VMOVNTPD;

            public static implicit operator AsmHexCode(Vmovntpd src) => src.Encoded;
        }

        public Vmovntpd vmovntpd() => default;

        [MethodImpl(Inline), Op]
        public Vmovntpd vmovntpd(AsmHexCode encoded) => new Vmovntpd(encoded);

        public struct Movntps : ITypedInstruction<Movntps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movntps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movntps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntps src) => AsmMnemonics.MOVNTPS;

            public static implicit operator AsmHexCode(Movntps src) => src.Encoded;
        }

        public Movntps movntps() => default;

        [MethodImpl(Inline), Op]
        public Movntps movntps(AsmHexCode encoded) => new Movntps(encoded);

        public struct Vmovntps : ITypedInstruction<Vmovntps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovntps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovntps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovntps src) => AsmMnemonics.VMOVNTPS;

            public static implicit operator AsmHexCode(Vmovntps src) => src.Encoded;
        }

        public Vmovntps vmovntps() => default;

        [MethodImpl(Inline), Op]
        public Vmovntps vmovntps(AsmHexCode encoded) => new Vmovntps(encoded);

        public struct Movntq : ITypedInstruction<Movntq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movntq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movntq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntq src) => AsmMnemonics.MOVNTQ;

            public static implicit operator AsmHexCode(Movntq src) => src.Encoded;
        }

        public Movntq movntq() => default;

        [MethodImpl(Inline), Op]
        public Movntq movntq(AsmHexCode encoded) => new Movntq(encoded);

        public struct Movq2dq : ITypedInstruction<Movq2dq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movq2dq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVQ2DQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movq2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movq2dq src) => AsmMnemonics.MOVQ2DQ;

            public static implicit operator AsmHexCode(Movq2dq src) => src.Encoded;
        }

        public Movq2dq movq2dq() => default;

        [MethodImpl(Inline), Op]
        public Movq2dq movq2dq(AsmHexCode encoded) => new Movq2dq(encoded);

        public struct Movs : ITypedInstruction<Movs>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movs(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movs src) => AsmMnemonics.MOVS;

            public static implicit operator AsmHexCode(Movs src) => src.Encoded;
        }

        public Movs movs() => default;

        [MethodImpl(Inline), Op]
        public Movs movs(AsmHexCode encoded) => new Movs(encoded);

        public struct Movsb : ITypedInstruction<Movsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsb src) => AsmMnemonics.MOVSB;

            public static implicit operator AsmHexCode(Movsb src) => src.Encoded;
        }

        public Movsb movsb() => default;

        [MethodImpl(Inline), Op]
        public Movsb movsb(AsmHexCode encoded) => new Movsb(encoded);

        public struct Movsw : ITypedInstruction<Movsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsw src) => AsmMnemonics.MOVSW;

            public static implicit operator AsmHexCode(Movsw src) => src.Encoded;
        }

        public Movsw movsw() => default;

        [MethodImpl(Inline), Op]
        public Movsw movsw(AsmHexCode encoded) => new Movsw(encoded);

        public struct Movsd : ITypedInstruction<Movsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsd src) => AsmMnemonics.MOVSD;

            public static implicit operator AsmHexCode(Movsd src) => src.Encoded;
        }

        public Movsd movsd() => default;

        [MethodImpl(Inline), Op]
        public Movsd movsd(AsmHexCode encoded) => new Movsd(encoded);

        public struct Movsq : ITypedInstruction<Movsq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movsq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movsq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsq src) => AsmMnemonics.MOVSQ;

            public static implicit operator AsmHexCode(Movsq src) => src.Encoded;
        }

        public Movsq movsq() => default;

        [MethodImpl(Inline), Op]
        public Movsq movsq(AsmHexCode encoded) => new Movsq(encoded);

        public struct Vmovsd : ITypedInstruction<Vmovsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovsd src) => AsmMnemonics.VMOVSD;

            public static implicit operator AsmHexCode(Vmovsd src) => src.Encoded;
        }

        public Vmovsd vmovsd() => default;

        [MethodImpl(Inline), Op]
        public Vmovsd vmovsd(AsmHexCode encoded) => new Vmovsd(encoded);

        public struct Movshdup : ITypedInstruction<Movshdup>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movshdup(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSHDUP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movshdup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movshdup src) => AsmMnemonics.MOVSHDUP;

            public static implicit operator AsmHexCode(Movshdup src) => src.Encoded;
        }

        public Movshdup movshdup() => default;

        [MethodImpl(Inline), Op]
        public Movshdup movshdup(AsmHexCode encoded) => new Movshdup(encoded);

        public struct Vmovshdup : ITypedInstruction<Vmovshdup>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovshdup(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSHDUP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovshdup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovshdup src) => AsmMnemonics.VMOVSHDUP;

            public static implicit operator AsmHexCode(Vmovshdup src) => src.Encoded;
        }

        public Vmovshdup vmovshdup() => default;

        [MethodImpl(Inline), Op]
        public Vmovshdup vmovshdup(AsmHexCode encoded) => new Vmovshdup(encoded);

        public struct Movsldup : ITypedInstruction<Movsldup>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movsldup(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSLDUP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movsldup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsldup src) => AsmMnemonics.MOVSLDUP;

            public static implicit operator AsmHexCode(Movsldup src) => src.Encoded;
        }

        public Movsldup movsldup() => default;

        [MethodImpl(Inline), Op]
        public Movsldup movsldup(AsmHexCode encoded) => new Movsldup(encoded);

        public struct Vmovsldup : ITypedInstruction<Vmovsldup>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovsldup(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSLDUP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovsldup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovsldup src) => AsmMnemonics.VMOVSLDUP;

            public static implicit operator AsmHexCode(Vmovsldup src) => src.Encoded;
        }

        public Vmovsldup vmovsldup() => default;

        [MethodImpl(Inline), Op]
        public Vmovsldup vmovsldup(AsmHexCode encoded) => new Vmovsldup(encoded);

        public struct Movss : ITypedInstruction<Movss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movss src) => AsmMnemonics.MOVSS;

            public static implicit operator AsmHexCode(Movss src) => src.Encoded;
        }

        public Movss movss() => default;

        [MethodImpl(Inline), Op]
        public Movss movss(AsmHexCode encoded) => new Movss(encoded);

        public struct Vmovss : ITypedInstruction<Vmovss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovss src) => AsmMnemonics.VMOVSS;

            public static implicit operator AsmHexCode(Vmovss src) => src.Encoded;
        }

        public Vmovss vmovss() => default;

        [MethodImpl(Inline), Op]
        public Vmovss vmovss(AsmHexCode encoded) => new Vmovss(encoded);

        public struct Movsx : ITypedInstruction<Movsx>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movsx(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSX;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movsx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsx src) => AsmMnemonics.MOVSX;

            public static implicit operator AsmHexCode(Movsx src) => src.Encoded;
        }

        public Movsx movsx() => default;

        [MethodImpl(Inline), Op]
        public Movsx movsx(AsmHexCode encoded) => new Movsx(encoded);

        public struct Movsxd : ITypedInstruction<Movsxd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movsxd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSXD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movsxd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsxd src) => AsmMnemonics.MOVSXD;

            public static implicit operator AsmHexCode(Movsxd src) => src.Encoded;
        }

        public Movsxd movsxd() => default;

        [MethodImpl(Inline), Op]
        public Movsxd movsxd(AsmHexCode encoded) => new Movsxd(encoded);

        public struct Movupd : ITypedInstruction<Movupd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movupd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVUPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movupd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movupd src) => AsmMnemonics.MOVUPD;

            public static implicit operator AsmHexCode(Movupd src) => src.Encoded;
        }

        public Movupd movupd() => default;

        [MethodImpl(Inline), Op]
        public Movupd movupd(AsmHexCode encoded) => new Movupd(encoded);

        public struct Vmovupd : ITypedInstruction<Vmovupd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovupd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVUPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovupd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovupd src) => AsmMnemonics.VMOVUPD;

            public static implicit operator AsmHexCode(Vmovupd src) => src.Encoded;
        }

        public Vmovupd vmovupd() => default;

        [MethodImpl(Inline), Op]
        public Vmovupd vmovupd(AsmHexCode encoded) => new Vmovupd(encoded);

        public struct Movups : ITypedInstruction<Movups>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movups(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVUPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movups src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movups src) => AsmMnemonics.MOVUPS;

            public static implicit operator AsmHexCode(Movups src) => src.Encoded;
        }

        public Movups movups() => default;

        [MethodImpl(Inline), Op]
        public Movups movups(AsmHexCode encoded) => new Movups(encoded);

        public struct Vmovups : ITypedInstruction<Vmovups>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmovups(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVUPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmovups src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovups src) => AsmMnemonics.VMOVUPS;

            public static implicit operator AsmHexCode(Vmovups src) => src.Encoded;
        }

        public Vmovups vmovups() => default;

        [MethodImpl(Inline), Op]
        public Vmovups vmovups(AsmHexCode encoded) => new Vmovups(encoded);

        public struct Movzx : ITypedInstruction<Movzx>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Movzx(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVZX;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Movzx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movzx src) => AsmMnemonics.MOVZX;

            public static implicit operator AsmHexCode(Movzx src) => src.Encoded;
        }

        public Movzx movzx() => default;

        [MethodImpl(Inline), Op]
        public Movzx movzx(AsmHexCode encoded) => new Movzx(encoded);

        public struct Mpsadbw : ITypedInstruction<Mpsadbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Mpsadbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MPSADBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Mpsadbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mpsadbw src) => AsmMnemonics.MPSADBW;

            public static implicit operator AsmHexCode(Mpsadbw src) => src.Encoded;
        }

        public Mpsadbw mpsadbw() => default;

        [MethodImpl(Inline), Op]
        public Mpsadbw mpsadbw(AsmHexCode encoded) => new Mpsadbw(encoded);

        public struct Vmpsadbw : ITypedInstruction<Vmpsadbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmpsadbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMPSADBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmpsadbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmpsadbw src) => AsmMnemonics.VMPSADBW;

            public static implicit operator AsmHexCode(Vmpsadbw src) => src.Encoded;
        }

        public Vmpsadbw vmpsadbw() => default;

        [MethodImpl(Inline), Op]
        public Vmpsadbw vmpsadbw(AsmHexCode encoded) => new Vmpsadbw(encoded);

        public struct Mul : ITypedInstruction<Mul>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Mul(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MUL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Mul src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mul src) => AsmMnemonics.MUL;

            public static implicit operator AsmHexCode(Mul src) => src.Encoded;
        }

        public Mul mul() => default;

        [MethodImpl(Inline), Op]
        public Mul mul(AsmHexCode encoded) => new Mul(encoded);

        public struct Mulpd : ITypedInstruction<Mulpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Mulpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Mulpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulpd src) => AsmMnemonics.MULPD;

            public static implicit operator AsmHexCode(Mulpd src) => src.Encoded;
        }

        public Mulpd mulpd() => default;

        [MethodImpl(Inline), Op]
        public Mulpd mulpd(AsmHexCode encoded) => new Mulpd(encoded);

        public struct Vmulpd : ITypedInstruction<Vmulpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmulpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmulpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmulpd src) => AsmMnemonics.VMULPD;

            public static implicit operator AsmHexCode(Vmulpd src) => src.Encoded;
        }

        public Vmulpd vmulpd() => default;

        [MethodImpl(Inline), Op]
        public Vmulpd vmulpd(AsmHexCode encoded) => new Vmulpd(encoded);

        public struct Mulps : ITypedInstruction<Mulps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Mulps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Mulps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulps src) => AsmMnemonics.MULPS;

            public static implicit operator AsmHexCode(Mulps src) => src.Encoded;
        }

        public Mulps mulps() => default;

        [MethodImpl(Inline), Op]
        public Mulps mulps(AsmHexCode encoded) => new Mulps(encoded);

        public struct Vmulps : ITypedInstruction<Vmulps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmulps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmulps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmulps src) => AsmMnemonics.VMULPS;

            public static implicit operator AsmHexCode(Vmulps src) => src.Encoded;
        }

        public Vmulps vmulps() => default;

        [MethodImpl(Inline), Op]
        public Vmulps vmulps(AsmHexCode encoded) => new Vmulps(encoded);

        public struct Mulsd : ITypedInstruction<Mulsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Mulsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Mulsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulsd src) => AsmMnemonics.MULSD;

            public static implicit operator AsmHexCode(Mulsd src) => src.Encoded;
        }

        public Mulsd mulsd() => default;

        [MethodImpl(Inline), Op]
        public Mulsd mulsd(AsmHexCode encoded) => new Mulsd(encoded);

        public struct Vmulsd : ITypedInstruction<Vmulsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmulsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmulsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmulsd src) => AsmMnemonics.VMULSD;

            public static implicit operator AsmHexCode(Vmulsd src) => src.Encoded;
        }

        public Vmulsd vmulsd() => default;

        [MethodImpl(Inline), Op]
        public Vmulsd vmulsd(AsmHexCode encoded) => new Vmulsd(encoded);

        public struct Mulss : ITypedInstruction<Mulss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Mulss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Mulss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulss src) => AsmMnemonics.MULSS;

            public static implicit operator AsmHexCode(Mulss src) => src.Encoded;
        }

        public Mulss mulss() => default;

        [MethodImpl(Inline), Op]
        public Mulss mulss(AsmHexCode encoded) => new Mulss(encoded);

        public struct Vmulss : ITypedInstruction<Vmulss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmulss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmulss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmulss src) => AsmMnemonics.VMULSS;

            public static implicit operator AsmHexCode(Vmulss src) => src.Encoded;
        }

        public Vmulss vmulss() => default;

        [MethodImpl(Inline), Op]
        public Vmulss vmulss(AsmHexCode encoded) => new Vmulss(encoded);

        public struct Mulx : ITypedInstruction<Mulx>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Mulx(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULX;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Mulx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulx src) => AsmMnemonics.MULX;

            public static implicit operator AsmHexCode(Mulx src) => src.Encoded;
        }

        public Mulx mulx() => default;

        [MethodImpl(Inline), Op]
        public Mulx mulx(AsmHexCode encoded) => new Mulx(encoded);

        public struct Mwait : ITypedInstruction<Mwait>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Mwait(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MWAIT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Mwait src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mwait src) => AsmMnemonics.MWAIT;

            public static implicit operator AsmHexCode(Mwait src) => src.Encoded;
        }

        public Mwait mwait() => default;

        [MethodImpl(Inline), Op]
        public Mwait mwait(AsmHexCode encoded) => new Mwait(encoded);

        public struct Neg : ITypedInstruction<Neg>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Neg(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.NEG;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Neg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Neg src) => AsmMnemonics.NEG;

            public static implicit operator AsmHexCode(Neg src) => src.Encoded;
        }

        public Neg neg() => default;

        [MethodImpl(Inline), Op]
        public Neg neg(AsmHexCode encoded) => new Neg(encoded);

        public struct Nop : ITypedInstruction<Nop>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Nop(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.NOP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Nop src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Nop src) => AsmMnemonics.NOP;

            public static implicit operator AsmHexCode(Nop src) => src.Encoded;
        }

        public Nop nop() => default;

        [MethodImpl(Inline), Op]
        public Nop nop(AsmHexCode encoded) => new Nop(encoded);

        public struct Not : ITypedInstruction<Not>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Not(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.NOT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Not src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Not src) => AsmMnemonics.NOT;

            public static implicit operator AsmHexCode(Not src) => src.Encoded;
        }

        public Not not() => default;

        [MethodImpl(Inline), Op]
        public Not not(AsmHexCode encoded) => new Not(encoded);

        public struct Or : ITypedInstruction<Or>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Or(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Or src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Or src) => AsmMnemonics.OR;

            public static implicit operator AsmHexCode(Or src) => src.Encoded;
        }

        public Or or() => default;

        [MethodImpl(Inline), Op]
        public Or or(AsmHexCode encoded) => new Or(encoded);

        public struct Orpd : ITypedInstruction<Orpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Orpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ORPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Orpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Orpd src) => AsmMnemonics.ORPD;

            public static implicit operator AsmHexCode(Orpd src) => src.Encoded;
        }

        public Orpd orpd() => default;

        [MethodImpl(Inline), Op]
        public Orpd orpd(AsmHexCode encoded) => new Orpd(encoded);

        public struct Vorpd : ITypedInstruction<Vorpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vorpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VORPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vorpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vorpd src) => AsmMnemonics.VORPD;

            public static implicit operator AsmHexCode(Vorpd src) => src.Encoded;
        }

        public Vorpd vorpd() => default;

        [MethodImpl(Inline), Op]
        public Vorpd vorpd(AsmHexCode encoded) => new Vorpd(encoded);

        public struct Orps : ITypedInstruction<Orps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Orps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ORPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Orps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Orps src) => AsmMnemonics.ORPS;

            public static implicit operator AsmHexCode(Orps src) => src.Encoded;
        }

        public Orps orps() => default;

        [MethodImpl(Inline), Op]
        public Orps orps(AsmHexCode encoded) => new Orps(encoded);

        public struct Vorps : ITypedInstruction<Vorps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vorps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VORPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vorps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vorps src) => AsmMnemonics.VORPS;

            public static implicit operator AsmHexCode(Vorps src) => src.Encoded;
        }

        public Vorps vorps() => default;

        [MethodImpl(Inline), Op]
        public Vorps vorps(AsmHexCode encoded) => new Vorps(encoded);

        public struct Out : ITypedInstruction<Out>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Out(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Out src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Out src) => AsmMnemonics.OUT;

            public static implicit operator AsmHexCode(Out src) => src.Encoded;
        }

        public Out @out() => default;

        [MethodImpl(Inline), Op]
        public Out @out(AsmHexCode encoded) => new Out(encoded);

        public struct Outs : ITypedInstruction<Outs>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Outs(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUTS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Outs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Outs src) => AsmMnemonics.OUTS;

            public static implicit operator AsmHexCode(Outs src) => src.Encoded;
        }

        public Outs outs() => default;

        [MethodImpl(Inline), Op]
        public Outs outs(AsmHexCode encoded) => new Outs(encoded);

        public struct Outsb : ITypedInstruction<Outsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Outsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUTSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Outsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Outsb src) => AsmMnemonics.OUTSB;

            public static implicit operator AsmHexCode(Outsb src) => src.Encoded;
        }

        public Outsb outsb() => default;

        [MethodImpl(Inline), Op]
        public Outsb outsb(AsmHexCode encoded) => new Outsb(encoded);

        public struct Outsw : ITypedInstruction<Outsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Outsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUTSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Outsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Outsw src) => AsmMnemonics.OUTSW;

            public static implicit operator AsmHexCode(Outsw src) => src.Encoded;
        }

        public Outsw outsw() => default;

        [MethodImpl(Inline), Op]
        public Outsw outsw(AsmHexCode encoded) => new Outsw(encoded);

        public struct Outsd : ITypedInstruction<Outsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Outsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUTSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Outsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Outsd src) => AsmMnemonics.OUTSD;

            public static implicit operator AsmHexCode(Outsd src) => src.Encoded;
        }

        public Outsd outsd() => default;

        [MethodImpl(Inline), Op]
        public Outsd outsd(AsmHexCode encoded) => new Outsd(encoded);

        public struct Pabsb : ITypedInstruction<Pabsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pabsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PABSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pabsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pabsb src) => AsmMnemonics.PABSB;

            public static implicit operator AsmHexCode(Pabsb src) => src.Encoded;
        }

        public Pabsb pabsb() => default;

        [MethodImpl(Inline), Op]
        public Pabsb pabsb(AsmHexCode encoded) => new Pabsb(encoded);

        public struct Pabsw : ITypedInstruction<Pabsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pabsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PABSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pabsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pabsw src) => AsmMnemonics.PABSW;

            public static implicit operator AsmHexCode(Pabsw src) => src.Encoded;
        }

        public Pabsw pabsw() => default;

        [MethodImpl(Inline), Op]
        public Pabsw pabsw(AsmHexCode encoded) => new Pabsw(encoded);

        public struct Pabsd : ITypedInstruction<Pabsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pabsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PABSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pabsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pabsd src) => AsmMnemonics.PABSD;

            public static implicit operator AsmHexCode(Pabsd src) => src.Encoded;
        }

        public Pabsd pabsd() => default;

        [MethodImpl(Inline), Op]
        public Pabsd pabsd(AsmHexCode encoded) => new Pabsd(encoded);

        public struct Vpabsb : ITypedInstruction<Vpabsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpabsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPABSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpabsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpabsb src) => AsmMnemonics.VPABSB;

            public static implicit operator AsmHexCode(Vpabsb src) => src.Encoded;
        }

        public Vpabsb vpabsb() => default;

        [MethodImpl(Inline), Op]
        public Vpabsb vpabsb(AsmHexCode encoded) => new Vpabsb(encoded);

        public struct Vpabsw : ITypedInstruction<Vpabsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpabsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPABSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpabsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpabsw src) => AsmMnemonics.VPABSW;

            public static implicit operator AsmHexCode(Vpabsw src) => src.Encoded;
        }

        public Vpabsw vpabsw() => default;

        [MethodImpl(Inline), Op]
        public Vpabsw vpabsw(AsmHexCode encoded) => new Vpabsw(encoded);

        public struct Vpabsd : ITypedInstruction<Vpabsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpabsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPABSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpabsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpabsd src) => AsmMnemonics.VPABSD;

            public static implicit operator AsmHexCode(Vpabsd src) => src.Encoded;
        }

        public Vpabsd vpabsd() => default;

        [MethodImpl(Inline), Op]
        public Vpabsd vpabsd(AsmHexCode encoded) => new Vpabsd(encoded);

        public struct Packsswb : ITypedInstruction<Packsswb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Packsswb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKSSWB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Packsswb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Packsswb src) => AsmMnemonics.PACKSSWB;

            public static implicit operator AsmHexCode(Packsswb src) => src.Encoded;
        }

        public Packsswb packsswb() => default;

        [MethodImpl(Inline), Op]
        public Packsswb packsswb(AsmHexCode encoded) => new Packsswb(encoded);

        public struct Packssdw : ITypedInstruction<Packssdw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Packssdw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKSSDW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Packssdw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Packssdw src) => AsmMnemonics.PACKSSDW;

            public static implicit operator AsmHexCode(Packssdw src) => src.Encoded;
        }

        public Packssdw packssdw() => default;

        [MethodImpl(Inline), Op]
        public Packssdw packssdw(AsmHexCode encoded) => new Packssdw(encoded);

        public struct Vpacksswb : ITypedInstruction<Vpacksswb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpacksswb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKSSWB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpacksswb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpacksswb src) => AsmMnemonics.VPACKSSWB;

            public static implicit operator AsmHexCode(Vpacksswb src) => src.Encoded;
        }

        public Vpacksswb vpacksswb() => default;

        [MethodImpl(Inline), Op]
        public Vpacksswb vpacksswb(AsmHexCode encoded) => new Vpacksswb(encoded);

        public struct Vpackssdw : ITypedInstruction<Vpackssdw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpackssdw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKSSDW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpackssdw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpackssdw src) => AsmMnemonics.VPACKSSDW;

            public static implicit operator AsmHexCode(Vpackssdw src) => src.Encoded;
        }

        public Vpackssdw vpackssdw() => default;

        [MethodImpl(Inline), Op]
        public Vpackssdw vpackssdw(AsmHexCode encoded) => new Vpackssdw(encoded);

        public struct Packusdw : ITypedInstruction<Packusdw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Packusdw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKUSDW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Packusdw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Packusdw src) => AsmMnemonics.PACKUSDW;

            public static implicit operator AsmHexCode(Packusdw src) => src.Encoded;
        }

        public Packusdw packusdw() => default;

        [MethodImpl(Inline), Op]
        public Packusdw packusdw(AsmHexCode encoded) => new Packusdw(encoded);

        public struct Vpackusdw : ITypedInstruction<Vpackusdw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpackusdw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKUSDW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpackusdw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpackusdw src) => AsmMnemonics.VPACKUSDW;

            public static implicit operator AsmHexCode(Vpackusdw src) => src.Encoded;
        }

        public Vpackusdw vpackusdw() => default;

        [MethodImpl(Inline), Op]
        public Vpackusdw vpackusdw(AsmHexCode encoded) => new Vpackusdw(encoded);

        public struct Packuswb : ITypedInstruction<Packuswb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Packuswb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKUSWB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Packuswb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Packuswb src) => AsmMnemonics.PACKUSWB;

            public static implicit operator AsmHexCode(Packuswb src) => src.Encoded;
        }

        public Packuswb packuswb() => default;

        [MethodImpl(Inline), Op]
        public Packuswb packuswb(AsmHexCode encoded) => new Packuswb(encoded);

        public struct Vpackuswb : ITypedInstruction<Vpackuswb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpackuswb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKUSWB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpackuswb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpackuswb src) => AsmMnemonics.VPACKUSWB;

            public static implicit operator AsmHexCode(Vpackuswb src) => src.Encoded;
        }

        public Vpackuswb vpackuswb() => default;

        [MethodImpl(Inline), Op]
        public Vpackuswb vpackuswb(AsmHexCode encoded) => new Vpackuswb(encoded);

        public struct Paddb : ITypedInstruction<Paddb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Paddb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Paddb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddb src) => AsmMnemonics.PADDB;

            public static implicit operator AsmHexCode(Paddb src) => src.Encoded;
        }

        public Paddb paddb() => default;

        [MethodImpl(Inline), Op]
        public Paddb paddb(AsmHexCode encoded) => new Paddb(encoded);

        public struct Paddw : ITypedInstruction<Paddw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Paddw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Paddw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddw src) => AsmMnemonics.PADDW;

            public static implicit operator AsmHexCode(Paddw src) => src.Encoded;
        }

        public Paddw paddw() => default;

        [MethodImpl(Inline), Op]
        public Paddw paddw(AsmHexCode encoded) => new Paddw(encoded);

        public struct Paddd : ITypedInstruction<Paddd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Paddd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Paddd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddd src) => AsmMnemonics.PADDD;

            public static implicit operator AsmHexCode(Paddd src) => src.Encoded;
        }

        public Paddd paddd() => default;

        [MethodImpl(Inline), Op]
        public Paddd paddd(AsmHexCode encoded) => new Paddd(encoded);

        public struct Vpaddb : ITypedInstruction<Vpaddb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpaddb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpaddb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddb src) => AsmMnemonics.VPADDB;

            public static implicit operator AsmHexCode(Vpaddb src) => src.Encoded;
        }

        public Vpaddb vpaddb() => default;

        [MethodImpl(Inline), Op]
        public Vpaddb vpaddb(AsmHexCode encoded) => new Vpaddb(encoded);

        public struct Vpaddw : ITypedInstruction<Vpaddw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpaddw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpaddw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddw src) => AsmMnemonics.VPADDW;

            public static implicit operator AsmHexCode(Vpaddw src) => src.Encoded;
        }

        public Vpaddw vpaddw() => default;

        [MethodImpl(Inline), Op]
        public Vpaddw vpaddw(AsmHexCode encoded) => new Vpaddw(encoded);

        public struct Vpaddd : ITypedInstruction<Vpaddd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpaddd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpaddd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddd src) => AsmMnemonics.VPADDD;

            public static implicit operator AsmHexCode(Vpaddd src) => src.Encoded;
        }

        public Vpaddd vpaddd() => default;

        [MethodImpl(Inline), Op]
        public Vpaddd vpaddd(AsmHexCode encoded) => new Vpaddd(encoded);

        public struct Paddq : ITypedInstruction<Paddq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Paddq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Paddq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddq src) => AsmMnemonics.PADDQ;

            public static implicit operator AsmHexCode(Paddq src) => src.Encoded;
        }

        public Paddq paddq() => default;

        [MethodImpl(Inline), Op]
        public Paddq paddq(AsmHexCode encoded) => new Paddq(encoded);

        public struct Vpaddq : ITypedInstruction<Vpaddq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpaddq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpaddq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddq src) => AsmMnemonics.VPADDQ;

            public static implicit operator AsmHexCode(Vpaddq src) => src.Encoded;
        }

        public Vpaddq vpaddq() => default;

        [MethodImpl(Inline), Op]
        public Vpaddq vpaddq(AsmHexCode encoded) => new Vpaddq(encoded);

        public struct Paddsb : ITypedInstruction<Paddsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Paddsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Paddsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddsb src) => AsmMnemonics.PADDSB;

            public static implicit operator AsmHexCode(Paddsb src) => src.Encoded;
        }

        public Paddsb paddsb() => default;

        [MethodImpl(Inline), Op]
        public Paddsb paddsb(AsmHexCode encoded) => new Paddsb(encoded);

        public struct Paddsw : ITypedInstruction<Paddsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Paddsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Paddsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddsw src) => AsmMnemonics.PADDSW;

            public static implicit operator AsmHexCode(Paddsw src) => src.Encoded;
        }

        public Paddsw paddsw() => default;

        [MethodImpl(Inline), Op]
        public Paddsw paddsw(AsmHexCode encoded) => new Paddsw(encoded);

        public struct Vpaddsb : ITypedInstruction<Vpaddsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpaddsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpaddsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddsb src) => AsmMnemonics.VPADDSB;

            public static implicit operator AsmHexCode(Vpaddsb src) => src.Encoded;
        }

        public Vpaddsb vpaddsb() => default;

        [MethodImpl(Inline), Op]
        public Vpaddsb vpaddsb(AsmHexCode encoded) => new Vpaddsb(encoded);

        public struct Vpaddsw : ITypedInstruction<Vpaddsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpaddsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpaddsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddsw src) => AsmMnemonics.VPADDSW;

            public static implicit operator AsmHexCode(Vpaddsw src) => src.Encoded;
        }

        public Vpaddsw vpaddsw() => default;

        [MethodImpl(Inline), Op]
        public Vpaddsw vpaddsw(AsmHexCode encoded) => new Vpaddsw(encoded);

        public struct Paddusb : ITypedInstruction<Paddusb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Paddusb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDUSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Paddusb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddusb src) => AsmMnemonics.PADDUSB;

            public static implicit operator AsmHexCode(Paddusb src) => src.Encoded;
        }

        public Paddusb paddusb() => default;

        [MethodImpl(Inline), Op]
        public Paddusb paddusb(AsmHexCode encoded) => new Paddusb(encoded);

        public struct Paddusw : ITypedInstruction<Paddusw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Paddusw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDUSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Paddusw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddusw src) => AsmMnemonics.PADDUSW;

            public static implicit operator AsmHexCode(Paddusw src) => src.Encoded;
        }

        public Paddusw paddusw() => default;

        [MethodImpl(Inline), Op]
        public Paddusw paddusw(AsmHexCode encoded) => new Paddusw(encoded);

        public struct Vpaddusb : ITypedInstruction<Vpaddusb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpaddusb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDUSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpaddusb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddusb src) => AsmMnemonics.VPADDUSB;

            public static implicit operator AsmHexCode(Vpaddusb src) => src.Encoded;
        }

        public Vpaddusb vpaddusb() => default;

        [MethodImpl(Inline), Op]
        public Vpaddusb vpaddusb(AsmHexCode encoded) => new Vpaddusb(encoded);

        public struct Vpaddusw : ITypedInstruction<Vpaddusw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpaddusw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDUSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpaddusw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddusw src) => AsmMnemonics.VPADDUSW;

            public static implicit operator AsmHexCode(Vpaddusw src) => src.Encoded;
        }

        public Vpaddusw vpaddusw() => default;

        [MethodImpl(Inline), Op]
        public Vpaddusw vpaddusw(AsmHexCode encoded) => new Vpaddusw(encoded);

        public struct Palignr : ITypedInstruction<Palignr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Palignr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PALIGNR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Palignr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Palignr src) => AsmMnemonics.PALIGNR;

            public static implicit operator AsmHexCode(Palignr src) => src.Encoded;
        }

        public Palignr palignr() => default;

        [MethodImpl(Inline), Op]
        public Palignr palignr(AsmHexCode encoded) => new Palignr(encoded);

        public struct Vpalignr : ITypedInstruction<Vpalignr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpalignr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPALIGNR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpalignr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpalignr src) => AsmMnemonics.VPALIGNR;

            public static implicit operator AsmHexCode(Vpalignr src) => src.Encoded;
        }

        public Vpalignr vpalignr() => default;

        [MethodImpl(Inline), Op]
        public Vpalignr vpalignr(AsmHexCode encoded) => new Vpalignr(encoded);

        public struct Pand : ITypedInstruction<Pand>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pand(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAND;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pand src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pand src) => AsmMnemonics.PAND;

            public static implicit operator AsmHexCode(Pand src) => src.Encoded;
        }

        public Pand pand() => default;

        [MethodImpl(Inline), Op]
        public Pand pand(AsmHexCode encoded) => new Pand(encoded);

        public struct Vpand : ITypedInstruction<Vpand>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpand(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPAND;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpand src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpand src) => AsmMnemonics.VPAND;

            public static implicit operator AsmHexCode(Vpand src) => src.Encoded;
        }

        public Vpand vpand() => default;

        [MethodImpl(Inline), Op]
        public Vpand vpand(AsmHexCode encoded) => new Vpand(encoded);

        public struct Pandn : ITypedInstruction<Pandn>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pandn(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PANDN;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pandn src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pandn src) => AsmMnemonics.PANDN;

            public static implicit operator AsmHexCode(Pandn src) => src.Encoded;
        }

        public Pandn pandn() => default;

        [MethodImpl(Inline), Op]
        public Pandn pandn(AsmHexCode encoded) => new Pandn(encoded);

        public struct Vpandn : ITypedInstruction<Vpandn>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpandn(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPANDN;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpandn src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpandn src) => AsmMnemonics.VPANDN;

            public static implicit operator AsmHexCode(Vpandn src) => src.Encoded;
        }

        public Vpandn vpandn() => default;

        [MethodImpl(Inline), Op]
        public Vpandn vpandn(AsmHexCode encoded) => new Vpandn(encoded);

        public struct Pause : ITypedInstruction<Pause>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pause(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAUSE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pause src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pause src) => AsmMnemonics.PAUSE;

            public static implicit operator AsmHexCode(Pause src) => src.Encoded;
        }

        public Pause pause() => default;

        [MethodImpl(Inline), Op]
        public Pause pause(AsmHexCode encoded) => new Pause(encoded);

        public struct Pavgb : ITypedInstruction<Pavgb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pavgb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAVGB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pavgb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pavgb src) => AsmMnemonics.PAVGB;

            public static implicit operator AsmHexCode(Pavgb src) => src.Encoded;
        }

        public Pavgb pavgb() => default;

        [MethodImpl(Inline), Op]
        public Pavgb pavgb(AsmHexCode encoded) => new Pavgb(encoded);

        public struct Pavgw : ITypedInstruction<Pavgw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pavgw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAVGW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pavgw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pavgw src) => AsmMnemonics.PAVGW;

            public static implicit operator AsmHexCode(Pavgw src) => src.Encoded;
        }

        public Pavgw pavgw() => default;

        [MethodImpl(Inline), Op]
        public Pavgw pavgw(AsmHexCode encoded) => new Pavgw(encoded);

        public struct Vpavgb : ITypedInstruction<Vpavgb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpavgb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPAVGB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpavgb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpavgb src) => AsmMnemonics.VPAVGB;

            public static implicit operator AsmHexCode(Vpavgb src) => src.Encoded;
        }

        public Vpavgb vpavgb() => default;

        [MethodImpl(Inline), Op]
        public Vpavgb vpavgb(AsmHexCode encoded) => new Vpavgb(encoded);

        public struct Vpavgw : ITypedInstruction<Vpavgw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpavgw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPAVGW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpavgw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpavgw src) => AsmMnemonics.VPAVGW;

            public static implicit operator AsmHexCode(Vpavgw src) => src.Encoded;
        }

        public Vpavgw vpavgw() => default;

        [MethodImpl(Inline), Op]
        public Vpavgw vpavgw(AsmHexCode encoded) => new Vpavgw(encoded);

        public struct Pblendvb : ITypedInstruction<Pblendvb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pblendvb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PBLENDVB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pblendvb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pblendvb src) => AsmMnemonics.PBLENDVB;

            public static implicit operator AsmHexCode(Pblendvb src) => src.Encoded;
        }

        public Pblendvb pblendvb() => default;

        [MethodImpl(Inline), Op]
        public Pblendvb pblendvb(AsmHexCode encoded) => new Pblendvb(encoded);

        public struct Vpblendvb : ITypedInstruction<Vpblendvb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpblendvb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBLENDVB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpblendvb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpblendvb src) => AsmMnemonics.VPBLENDVB;

            public static implicit operator AsmHexCode(Vpblendvb src) => src.Encoded;
        }

        public Vpblendvb vpblendvb() => default;

        [MethodImpl(Inline), Op]
        public Vpblendvb vpblendvb(AsmHexCode encoded) => new Vpblendvb(encoded);

        public struct Pblendw : ITypedInstruction<Pblendw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pblendw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PBLENDW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pblendw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pblendw src) => AsmMnemonics.PBLENDW;

            public static implicit operator AsmHexCode(Pblendw src) => src.Encoded;
        }

        public Pblendw pblendw() => default;

        [MethodImpl(Inline), Op]
        public Pblendw pblendw(AsmHexCode encoded) => new Pblendw(encoded);

        public struct Vpblendw : ITypedInstruction<Vpblendw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpblendw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBLENDW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpblendw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpblendw src) => AsmMnemonics.VPBLENDW;

            public static implicit operator AsmHexCode(Vpblendw src) => src.Encoded;
        }

        public Vpblendw vpblendw() => default;

        [MethodImpl(Inline), Op]
        public Vpblendw vpblendw(AsmHexCode encoded) => new Vpblendw(encoded);

        public struct Pclmulqdq : ITypedInstruction<Pclmulqdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pclmulqdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCLMULQDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pclmulqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pclmulqdq src) => AsmMnemonics.PCLMULQDQ;

            public static implicit operator AsmHexCode(Pclmulqdq src) => src.Encoded;
        }

        public Pclmulqdq pclmulqdq() => default;

        [MethodImpl(Inline), Op]
        public Pclmulqdq pclmulqdq(AsmHexCode encoded) => new Pclmulqdq(encoded);

        public struct Vpclmulqdq : ITypedInstruction<Vpclmulqdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpclmulqdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCLMULQDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpclmulqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpclmulqdq src) => AsmMnemonics.VPCLMULQDQ;

            public static implicit operator AsmHexCode(Vpclmulqdq src) => src.Encoded;
        }

        public Vpclmulqdq vpclmulqdq() => default;

        [MethodImpl(Inline), Op]
        public Vpclmulqdq vpclmulqdq(AsmHexCode encoded) => new Vpclmulqdq(encoded);

        public struct Pcmpeqb : ITypedInstruction<Pcmpeqb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pcmpeqb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pcmpeqb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpeqb src) => AsmMnemonics.PCMPEQB;

            public static implicit operator AsmHexCode(Pcmpeqb src) => src.Encoded;
        }

        public Pcmpeqb pcmpeqb() => default;

        [MethodImpl(Inline), Op]
        public Pcmpeqb pcmpeqb(AsmHexCode encoded) => new Pcmpeqb(encoded);

        public struct Pcmpeqw : ITypedInstruction<Pcmpeqw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pcmpeqw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pcmpeqw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpeqw src) => AsmMnemonics.PCMPEQW;

            public static implicit operator AsmHexCode(Pcmpeqw src) => src.Encoded;
        }

        public Pcmpeqw pcmpeqw() => default;

        [MethodImpl(Inline), Op]
        public Pcmpeqw pcmpeqw(AsmHexCode encoded) => new Pcmpeqw(encoded);

        public struct Pcmpeqd : ITypedInstruction<Pcmpeqd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pcmpeqd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pcmpeqd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpeqd src) => AsmMnemonics.PCMPEQD;

            public static implicit operator AsmHexCode(Pcmpeqd src) => src.Encoded;
        }

        public Pcmpeqd pcmpeqd() => default;

        [MethodImpl(Inline), Op]
        public Pcmpeqd pcmpeqd(AsmHexCode encoded) => new Pcmpeqd(encoded);

        public struct Vpcmpeqb : ITypedInstruction<Vpcmpeqb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpcmpeqb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpcmpeqb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpeqb src) => AsmMnemonics.VPCMPEQB;

            public static implicit operator AsmHexCode(Vpcmpeqb src) => src.Encoded;
        }

        public Vpcmpeqb vpcmpeqb() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpeqb vpcmpeqb(AsmHexCode encoded) => new Vpcmpeqb(encoded);

        public struct Vpcmpeqw : ITypedInstruction<Vpcmpeqw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpcmpeqw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpcmpeqw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpeqw src) => AsmMnemonics.VPCMPEQW;

            public static implicit operator AsmHexCode(Vpcmpeqw src) => src.Encoded;
        }

        public Vpcmpeqw vpcmpeqw() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpeqw vpcmpeqw(AsmHexCode encoded) => new Vpcmpeqw(encoded);

        public struct Vpcmpeqd : ITypedInstruction<Vpcmpeqd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpcmpeqd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpcmpeqd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpeqd src) => AsmMnemonics.VPCMPEQD;

            public static implicit operator AsmHexCode(Vpcmpeqd src) => src.Encoded;
        }

        public Vpcmpeqd vpcmpeqd() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpeqd vpcmpeqd(AsmHexCode encoded) => new Vpcmpeqd(encoded);

        public struct Pcmpeqq : ITypedInstruction<Pcmpeqq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pcmpeqq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pcmpeqq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpeqq src) => AsmMnemonics.PCMPEQQ;

            public static implicit operator AsmHexCode(Pcmpeqq src) => src.Encoded;
        }

        public Pcmpeqq pcmpeqq() => default;

        [MethodImpl(Inline), Op]
        public Pcmpeqq pcmpeqq(AsmHexCode encoded) => new Pcmpeqq(encoded);

        public struct Vpcmpeqq : ITypedInstruction<Vpcmpeqq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpcmpeqq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpcmpeqq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpeqq src) => AsmMnemonics.VPCMPEQQ;

            public static implicit operator AsmHexCode(Vpcmpeqq src) => src.Encoded;
        }

        public Vpcmpeqq vpcmpeqq() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpeqq vpcmpeqq(AsmHexCode encoded) => new Vpcmpeqq(encoded);

        public struct Pcmpestri : ITypedInstruction<Pcmpestri>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pcmpestri(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPESTRI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pcmpestri src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpestri src) => AsmMnemonics.PCMPESTRI;

            public static implicit operator AsmHexCode(Pcmpestri src) => src.Encoded;
        }

        public Pcmpestri pcmpestri() => default;

        [MethodImpl(Inline), Op]
        public Pcmpestri pcmpestri(AsmHexCode encoded) => new Pcmpestri(encoded);

        public struct Vpcmpestri : ITypedInstruction<Vpcmpestri>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpcmpestri(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPESTRI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpcmpestri src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpestri src) => AsmMnemonics.VPCMPESTRI;

            public static implicit operator AsmHexCode(Vpcmpestri src) => src.Encoded;
        }

        public Vpcmpestri vpcmpestri() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpestri vpcmpestri(AsmHexCode encoded) => new Vpcmpestri(encoded);

        public struct Pcmpestrm : ITypedInstruction<Pcmpestrm>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pcmpestrm(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPESTRM;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pcmpestrm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpestrm src) => AsmMnemonics.PCMPESTRM;

            public static implicit operator AsmHexCode(Pcmpestrm src) => src.Encoded;
        }

        public Pcmpestrm pcmpestrm() => default;

        [MethodImpl(Inline), Op]
        public Pcmpestrm pcmpestrm(AsmHexCode encoded) => new Pcmpestrm(encoded);

        public struct Vpcmpestrm : ITypedInstruction<Vpcmpestrm>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpcmpestrm(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPESTRM;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpcmpestrm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpestrm src) => AsmMnemonics.VPCMPESTRM;

            public static implicit operator AsmHexCode(Vpcmpestrm src) => src.Encoded;
        }

        public Vpcmpestrm vpcmpestrm() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpestrm vpcmpestrm(AsmHexCode encoded) => new Vpcmpestrm(encoded);

        public struct Pcmpgtb : ITypedInstruction<Pcmpgtb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pcmpgtb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pcmpgtb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpgtb src) => AsmMnemonics.PCMPGTB;

            public static implicit operator AsmHexCode(Pcmpgtb src) => src.Encoded;
        }

        public Pcmpgtb pcmpgtb() => default;

        [MethodImpl(Inline), Op]
        public Pcmpgtb pcmpgtb(AsmHexCode encoded) => new Pcmpgtb(encoded);

        public struct Pcmpgtw : ITypedInstruction<Pcmpgtw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pcmpgtw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pcmpgtw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpgtw src) => AsmMnemonics.PCMPGTW;

            public static implicit operator AsmHexCode(Pcmpgtw src) => src.Encoded;
        }

        public Pcmpgtw pcmpgtw() => default;

        [MethodImpl(Inline), Op]
        public Pcmpgtw pcmpgtw(AsmHexCode encoded) => new Pcmpgtw(encoded);

        public struct Pcmpgtd : ITypedInstruction<Pcmpgtd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pcmpgtd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pcmpgtd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpgtd src) => AsmMnemonics.PCMPGTD;

            public static implicit operator AsmHexCode(Pcmpgtd src) => src.Encoded;
        }

        public Pcmpgtd pcmpgtd() => default;

        [MethodImpl(Inline), Op]
        public Pcmpgtd pcmpgtd(AsmHexCode encoded) => new Pcmpgtd(encoded);

        public struct Vpcmpgtb : ITypedInstruction<Vpcmpgtb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpcmpgtb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpcmpgtb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpgtb src) => AsmMnemonics.VPCMPGTB;

            public static implicit operator AsmHexCode(Vpcmpgtb src) => src.Encoded;
        }

        public Vpcmpgtb vpcmpgtb() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpgtb vpcmpgtb(AsmHexCode encoded) => new Vpcmpgtb(encoded);

        public struct Vpcmpgtw : ITypedInstruction<Vpcmpgtw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpcmpgtw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpcmpgtw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpgtw src) => AsmMnemonics.VPCMPGTW;

            public static implicit operator AsmHexCode(Vpcmpgtw src) => src.Encoded;
        }

        public Vpcmpgtw vpcmpgtw() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpgtw vpcmpgtw(AsmHexCode encoded) => new Vpcmpgtw(encoded);

        public struct Vpcmpgtd : ITypedInstruction<Vpcmpgtd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpcmpgtd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpcmpgtd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpgtd src) => AsmMnemonics.VPCMPGTD;

            public static implicit operator AsmHexCode(Vpcmpgtd src) => src.Encoded;
        }

        public Vpcmpgtd vpcmpgtd() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpgtd vpcmpgtd(AsmHexCode encoded) => new Vpcmpgtd(encoded);

        public struct Pcmpgtq : ITypedInstruction<Pcmpgtq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pcmpgtq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pcmpgtq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpgtq src) => AsmMnemonics.PCMPGTQ;

            public static implicit operator AsmHexCode(Pcmpgtq src) => src.Encoded;
        }

        public Pcmpgtq pcmpgtq() => default;

        [MethodImpl(Inline), Op]
        public Pcmpgtq pcmpgtq(AsmHexCode encoded) => new Pcmpgtq(encoded);

        public struct Vpcmpgtq : ITypedInstruction<Vpcmpgtq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpcmpgtq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpcmpgtq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpgtq src) => AsmMnemonics.VPCMPGTQ;

            public static implicit operator AsmHexCode(Vpcmpgtq src) => src.Encoded;
        }

        public Vpcmpgtq vpcmpgtq() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpgtq vpcmpgtq(AsmHexCode encoded) => new Vpcmpgtq(encoded);

        public struct Pcmpistri : ITypedInstruction<Pcmpistri>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pcmpistri(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPISTRI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pcmpistri src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpistri src) => AsmMnemonics.PCMPISTRI;

            public static implicit operator AsmHexCode(Pcmpistri src) => src.Encoded;
        }

        public Pcmpistri pcmpistri() => default;

        [MethodImpl(Inline), Op]
        public Pcmpistri pcmpistri(AsmHexCode encoded) => new Pcmpistri(encoded);

        public struct Vpcmpistri : ITypedInstruction<Vpcmpistri>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpcmpistri(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPISTRI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpcmpistri src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpistri src) => AsmMnemonics.VPCMPISTRI;

            public static implicit operator AsmHexCode(Vpcmpistri src) => src.Encoded;
        }

        public Vpcmpistri vpcmpistri() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpistri vpcmpistri(AsmHexCode encoded) => new Vpcmpistri(encoded);

        public struct Pcmpistrm : ITypedInstruction<Pcmpistrm>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pcmpistrm(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPISTRM;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pcmpistrm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpistrm src) => AsmMnemonics.PCMPISTRM;

            public static implicit operator AsmHexCode(Pcmpistrm src) => src.Encoded;
        }

        public Pcmpistrm pcmpistrm() => default;

        [MethodImpl(Inline), Op]
        public Pcmpistrm pcmpistrm(AsmHexCode encoded) => new Pcmpistrm(encoded);

        public struct Vpcmpistrm : ITypedInstruction<Vpcmpistrm>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpcmpistrm(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPISTRM;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpcmpistrm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpistrm src) => AsmMnemonics.VPCMPISTRM;

            public static implicit operator AsmHexCode(Vpcmpistrm src) => src.Encoded;
        }

        public Vpcmpistrm vpcmpistrm() => default;

        [MethodImpl(Inline), Op]
        public Vpcmpistrm vpcmpistrm(AsmHexCode encoded) => new Vpcmpistrm(encoded);

        public struct Pdep : ITypedInstruction<Pdep>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pdep(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PDEP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pdep src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pdep src) => AsmMnemonics.PDEP;

            public static implicit operator AsmHexCode(Pdep src) => src.Encoded;
        }

        public Pdep pdep() => default;

        [MethodImpl(Inline), Op]
        public Pdep pdep(AsmHexCode encoded) => new Pdep(encoded);

        public struct Pext : ITypedInstruction<Pext>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pext(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pext src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pext src) => AsmMnemonics.PEXT;

            public static implicit operator AsmHexCode(Pext src) => src.Encoded;
        }

        public Pext pext() => default;

        [MethodImpl(Inline), Op]
        public Pext pext(AsmHexCode encoded) => new Pext(encoded);

        public struct Pextrb : ITypedInstruction<Pextrb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pextrb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pextrb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pextrb src) => AsmMnemonics.PEXTRB;

            public static implicit operator AsmHexCode(Pextrb src) => src.Encoded;
        }

        public Pextrb pextrb() => default;

        [MethodImpl(Inline), Op]
        public Pextrb pextrb(AsmHexCode encoded) => new Pextrb(encoded);

        public struct Pextrd : ITypedInstruction<Pextrd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pextrd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pextrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pextrd src) => AsmMnemonics.PEXTRD;

            public static implicit operator AsmHexCode(Pextrd src) => src.Encoded;
        }

        public Pextrd pextrd() => default;

        [MethodImpl(Inline), Op]
        public Pextrd pextrd(AsmHexCode encoded) => new Pextrd(encoded);

        public struct Pextrq : ITypedInstruction<Pextrq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pextrq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pextrq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pextrq src) => AsmMnemonics.PEXTRQ;

            public static implicit operator AsmHexCode(Pextrq src) => src.Encoded;
        }

        public Pextrq pextrq() => default;

        [MethodImpl(Inline), Op]
        public Pextrq pextrq(AsmHexCode encoded) => new Pextrq(encoded);

        public struct Vpextrb : ITypedInstruction<Vpextrb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpextrb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpextrb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpextrb src) => AsmMnemonics.VPEXTRB;

            public static implicit operator AsmHexCode(Vpextrb src) => src.Encoded;
        }

        public Vpextrb vpextrb() => default;

        [MethodImpl(Inline), Op]
        public Vpextrb vpextrb(AsmHexCode encoded) => new Vpextrb(encoded);

        public struct Vpextrd : ITypedInstruction<Vpextrd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpextrd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpextrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpextrd src) => AsmMnemonics.VPEXTRD;

            public static implicit operator AsmHexCode(Vpextrd src) => src.Encoded;
        }

        public Vpextrd vpextrd() => default;

        [MethodImpl(Inline), Op]
        public Vpextrd vpextrd(AsmHexCode encoded) => new Vpextrd(encoded);

        public struct Vpextrq : ITypedInstruction<Vpextrq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpextrq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpextrq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpextrq src) => AsmMnemonics.VPEXTRQ;

            public static implicit operator AsmHexCode(Vpextrq src) => src.Encoded;
        }

        public Vpextrq vpextrq() => default;

        [MethodImpl(Inline), Op]
        public Vpextrq vpextrq(AsmHexCode encoded) => new Vpextrq(encoded);

        public struct Pextrw : ITypedInstruction<Pextrw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pextrw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pextrw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pextrw src) => AsmMnemonics.PEXTRW;

            public static implicit operator AsmHexCode(Pextrw src) => src.Encoded;
        }

        public Pextrw pextrw() => default;

        [MethodImpl(Inline), Op]
        public Pextrw pextrw(AsmHexCode encoded) => new Pextrw(encoded);

        public struct Vpextrw : ITypedInstruction<Vpextrw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpextrw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpextrw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpextrw src) => AsmMnemonics.VPEXTRW;

            public static implicit operator AsmHexCode(Vpextrw src) => src.Encoded;
        }

        public Vpextrw vpextrw() => default;

        [MethodImpl(Inline), Op]
        public Vpextrw vpextrw(AsmHexCode encoded) => new Vpextrw(encoded);

        public struct Phaddw : ITypedInstruction<Phaddw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Phaddw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHADDW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Phaddw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phaddw src) => AsmMnemonics.PHADDW;

            public static implicit operator AsmHexCode(Phaddw src) => src.Encoded;
        }

        public Phaddw phaddw() => default;

        [MethodImpl(Inline), Op]
        public Phaddw phaddw(AsmHexCode encoded) => new Phaddw(encoded);

        public struct Phaddd : ITypedInstruction<Phaddd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Phaddd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHADDD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Phaddd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phaddd src) => AsmMnemonics.PHADDD;

            public static implicit operator AsmHexCode(Phaddd src) => src.Encoded;
        }

        public Phaddd phaddd() => default;

        [MethodImpl(Inline), Op]
        public Phaddd phaddd(AsmHexCode encoded) => new Phaddd(encoded);

        public struct Vphaddw : ITypedInstruction<Vphaddw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vphaddw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHADDW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vphaddw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphaddw src) => AsmMnemonics.VPHADDW;

            public static implicit operator AsmHexCode(Vphaddw src) => src.Encoded;
        }

        public Vphaddw vphaddw() => default;

        [MethodImpl(Inline), Op]
        public Vphaddw vphaddw(AsmHexCode encoded) => new Vphaddw(encoded);

        public struct Vphaddd : ITypedInstruction<Vphaddd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vphaddd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHADDD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vphaddd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphaddd src) => AsmMnemonics.VPHADDD;

            public static implicit operator AsmHexCode(Vphaddd src) => src.Encoded;
        }

        public Vphaddd vphaddd() => default;

        [MethodImpl(Inline), Op]
        public Vphaddd vphaddd(AsmHexCode encoded) => new Vphaddd(encoded);

        public struct Phaddsw : ITypedInstruction<Phaddsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Phaddsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHADDSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Phaddsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phaddsw src) => AsmMnemonics.PHADDSW;

            public static implicit operator AsmHexCode(Phaddsw src) => src.Encoded;
        }

        public Phaddsw phaddsw() => default;

        [MethodImpl(Inline), Op]
        public Phaddsw phaddsw(AsmHexCode encoded) => new Phaddsw(encoded);

        public struct Vphaddsw : ITypedInstruction<Vphaddsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vphaddsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHADDSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vphaddsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphaddsw src) => AsmMnemonics.VPHADDSW;

            public static implicit operator AsmHexCode(Vphaddsw src) => src.Encoded;
        }

        public Vphaddsw vphaddsw() => default;

        [MethodImpl(Inline), Op]
        public Vphaddsw vphaddsw(AsmHexCode encoded) => new Vphaddsw(encoded);

        public struct Phminposuw : ITypedInstruction<Phminposuw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Phminposuw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHMINPOSUW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Phminposuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phminposuw src) => AsmMnemonics.PHMINPOSUW;

            public static implicit operator AsmHexCode(Phminposuw src) => src.Encoded;
        }

        public Phminposuw phminposuw() => default;

        [MethodImpl(Inline), Op]
        public Phminposuw phminposuw(AsmHexCode encoded) => new Phminposuw(encoded);

        public struct Vphminposuw : ITypedInstruction<Vphminposuw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vphminposuw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHMINPOSUW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vphminposuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphminposuw src) => AsmMnemonics.VPHMINPOSUW;

            public static implicit operator AsmHexCode(Vphminposuw src) => src.Encoded;
        }

        public Vphminposuw vphminposuw() => default;

        [MethodImpl(Inline), Op]
        public Vphminposuw vphminposuw(AsmHexCode encoded) => new Vphminposuw(encoded);

        public struct Phsubw : ITypedInstruction<Phsubw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Phsubw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHSUBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Phsubw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phsubw src) => AsmMnemonics.PHSUBW;

            public static implicit operator AsmHexCode(Phsubw src) => src.Encoded;
        }

        public Phsubw phsubw() => default;

        [MethodImpl(Inline), Op]
        public Phsubw phsubw(AsmHexCode encoded) => new Phsubw(encoded);

        public struct Phsubd : ITypedInstruction<Phsubd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Phsubd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHSUBD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Phsubd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phsubd src) => AsmMnemonics.PHSUBD;

            public static implicit operator AsmHexCode(Phsubd src) => src.Encoded;
        }

        public Phsubd phsubd() => default;

        [MethodImpl(Inline), Op]
        public Phsubd phsubd(AsmHexCode encoded) => new Phsubd(encoded);

        public struct Vphsubw : ITypedInstruction<Vphsubw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vphsubw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHSUBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vphsubw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphsubw src) => AsmMnemonics.VPHSUBW;

            public static implicit operator AsmHexCode(Vphsubw src) => src.Encoded;
        }

        public Vphsubw vphsubw() => default;

        [MethodImpl(Inline), Op]
        public Vphsubw vphsubw(AsmHexCode encoded) => new Vphsubw(encoded);

        public struct Vphsubd : ITypedInstruction<Vphsubd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vphsubd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHSUBD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vphsubd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphsubd src) => AsmMnemonics.VPHSUBD;

            public static implicit operator AsmHexCode(Vphsubd src) => src.Encoded;
        }

        public Vphsubd vphsubd() => default;

        [MethodImpl(Inline), Op]
        public Vphsubd vphsubd(AsmHexCode encoded) => new Vphsubd(encoded);

        public struct Phsubsw : ITypedInstruction<Phsubsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Phsubsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHSUBSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Phsubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phsubsw src) => AsmMnemonics.PHSUBSW;

            public static implicit operator AsmHexCode(Phsubsw src) => src.Encoded;
        }

        public Phsubsw phsubsw() => default;

        [MethodImpl(Inline), Op]
        public Phsubsw phsubsw(AsmHexCode encoded) => new Phsubsw(encoded);

        public struct Vphsubsw : ITypedInstruction<Vphsubsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vphsubsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHSUBSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vphsubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphsubsw src) => AsmMnemonics.VPHSUBSW;

            public static implicit operator AsmHexCode(Vphsubsw src) => src.Encoded;
        }

        public Vphsubsw vphsubsw() => default;

        [MethodImpl(Inline), Op]
        public Vphsubsw vphsubsw(AsmHexCode encoded) => new Vphsubsw(encoded);

        public struct Pinsrb : ITypedInstruction<Pinsrb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pinsrb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pinsrb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pinsrb src) => AsmMnemonics.PINSRB;

            public static implicit operator AsmHexCode(Pinsrb src) => src.Encoded;
        }

        public Pinsrb pinsrb() => default;

        [MethodImpl(Inline), Op]
        public Pinsrb pinsrb(AsmHexCode encoded) => new Pinsrb(encoded);

        public struct Pinsrd : ITypedInstruction<Pinsrd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pinsrd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pinsrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pinsrd src) => AsmMnemonics.PINSRD;

            public static implicit operator AsmHexCode(Pinsrd src) => src.Encoded;
        }

        public Pinsrd pinsrd() => default;

        [MethodImpl(Inline), Op]
        public Pinsrd pinsrd(AsmHexCode encoded) => new Pinsrd(encoded);

        public struct Pinsrq : ITypedInstruction<Pinsrq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pinsrq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pinsrq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pinsrq src) => AsmMnemonics.PINSRQ;

            public static implicit operator AsmHexCode(Pinsrq src) => src.Encoded;
        }

        public Pinsrq pinsrq() => default;

        [MethodImpl(Inline), Op]
        public Pinsrq pinsrq(AsmHexCode encoded) => new Pinsrq(encoded);

        public struct Vpinsrb : ITypedInstruction<Vpinsrb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpinsrb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpinsrb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpinsrb src) => AsmMnemonics.VPINSRB;

            public static implicit operator AsmHexCode(Vpinsrb src) => src.Encoded;
        }

        public Vpinsrb vpinsrb() => default;

        [MethodImpl(Inline), Op]
        public Vpinsrb vpinsrb(AsmHexCode encoded) => new Vpinsrb(encoded);

        public struct Vpinsrd : ITypedInstruction<Vpinsrd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpinsrd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpinsrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpinsrd src) => AsmMnemonics.VPINSRD;

            public static implicit operator AsmHexCode(Vpinsrd src) => src.Encoded;
        }

        public Vpinsrd vpinsrd() => default;

        [MethodImpl(Inline), Op]
        public Vpinsrd vpinsrd(AsmHexCode encoded) => new Vpinsrd(encoded);

        public struct Vpinsrq : ITypedInstruction<Vpinsrq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpinsrq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpinsrq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpinsrq src) => AsmMnemonics.VPINSRQ;

            public static implicit operator AsmHexCode(Vpinsrq src) => src.Encoded;
        }

        public Vpinsrq vpinsrq() => default;

        [MethodImpl(Inline), Op]
        public Vpinsrq vpinsrq(AsmHexCode encoded) => new Vpinsrq(encoded);

        public struct Pinsrw : ITypedInstruction<Pinsrw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pinsrw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pinsrw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pinsrw src) => AsmMnemonics.PINSRW;

            public static implicit operator AsmHexCode(Pinsrw src) => src.Encoded;
        }

        public Pinsrw pinsrw() => default;

        [MethodImpl(Inline), Op]
        public Pinsrw pinsrw(AsmHexCode encoded) => new Pinsrw(encoded);

        public struct Vpinsrw : ITypedInstruction<Vpinsrw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpinsrw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpinsrw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpinsrw src) => AsmMnemonics.VPINSRW;

            public static implicit operator AsmHexCode(Vpinsrw src) => src.Encoded;
        }

        public Vpinsrw vpinsrw() => default;

        [MethodImpl(Inline), Op]
        public Vpinsrw vpinsrw(AsmHexCode encoded) => new Vpinsrw(encoded);

        public struct Pmaddubsw : ITypedInstruction<Pmaddubsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmaddubsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMADDUBSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmaddubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaddubsw src) => AsmMnemonics.PMADDUBSW;

            public static implicit operator AsmHexCode(Pmaddubsw src) => src.Encoded;
        }

        public Pmaddubsw pmaddubsw() => default;

        [MethodImpl(Inline), Op]
        public Pmaddubsw pmaddubsw(AsmHexCode encoded) => new Pmaddubsw(encoded);

        public struct Vpmaddubsw : ITypedInstruction<Vpmaddubsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmaddubsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMADDUBSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmaddubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaddubsw src) => AsmMnemonics.VPMADDUBSW;

            public static implicit operator AsmHexCode(Vpmaddubsw src) => src.Encoded;
        }

        public Vpmaddubsw vpmaddubsw() => default;

        [MethodImpl(Inline), Op]
        public Vpmaddubsw vpmaddubsw(AsmHexCode encoded) => new Vpmaddubsw(encoded);

        public struct Pmaddwd : ITypedInstruction<Pmaddwd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmaddwd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMADDWD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmaddwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaddwd src) => AsmMnemonics.PMADDWD;

            public static implicit operator AsmHexCode(Pmaddwd src) => src.Encoded;
        }

        public Pmaddwd pmaddwd() => default;

        [MethodImpl(Inline), Op]
        public Pmaddwd pmaddwd(AsmHexCode encoded) => new Pmaddwd(encoded);

        public struct Vpmaddwd : ITypedInstruction<Vpmaddwd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmaddwd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMADDWD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmaddwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaddwd src) => AsmMnemonics.VPMADDWD;

            public static implicit operator AsmHexCode(Vpmaddwd src) => src.Encoded;
        }

        public Vpmaddwd vpmaddwd() => default;

        [MethodImpl(Inline), Op]
        public Vpmaddwd vpmaddwd(AsmHexCode encoded) => new Vpmaddwd(encoded);

        public struct Pmaxsb : ITypedInstruction<Pmaxsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmaxsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmaxsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxsb src) => AsmMnemonics.PMAXSB;

            public static implicit operator AsmHexCode(Pmaxsb src) => src.Encoded;
        }

        public Pmaxsb pmaxsb() => default;

        [MethodImpl(Inline), Op]
        public Pmaxsb pmaxsb(AsmHexCode encoded) => new Pmaxsb(encoded);

        public struct Vpmaxsb : ITypedInstruction<Vpmaxsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmaxsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmaxsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxsb src) => AsmMnemonics.VPMAXSB;

            public static implicit operator AsmHexCode(Vpmaxsb src) => src.Encoded;
        }

        public Vpmaxsb vpmaxsb() => default;

        [MethodImpl(Inline), Op]
        public Vpmaxsb vpmaxsb(AsmHexCode encoded) => new Vpmaxsb(encoded);

        public struct Pmaxsd : ITypedInstruction<Pmaxsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmaxsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmaxsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxsd src) => AsmMnemonics.PMAXSD;

            public static implicit operator AsmHexCode(Pmaxsd src) => src.Encoded;
        }

        public Pmaxsd pmaxsd() => default;

        [MethodImpl(Inline), Op]
        public Pmaxsd pmaxsd(AsmHexCode encoded) => new Pmaxsd(encoded);

        public struct Vpmaxsd : ITypedInstruction<Vpmaxsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmaxsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmaxsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxsd src) => AsmMnemonics.VPMAXSD;

            public static implicit operator AsmHexCode(Vpmaxsd src) => src.Encoded;
        }

        public Vpmaxsd vpmaxsd() => default;

        [MethodImpl(Inline), Op]
        public Vpmaxsd vpmaxsd(AsmHexCode encoded) => new Vpmaxsd(encoded);

        public struct Pmaxsw : ITypedInstruction<Pmaxsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmaxsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmaxsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxsw src) => AsmMnemonics.PMAXSW;

            public static implicit operator AsmHexCode(Pmaxsw src) => src.Encoded;
        }

        public Pmaxsw pmaxsw() => default;

        [MethodImpl(Inline), Op]
        public Pmaxsw pmaxsw(AsmHexCode encoded) => new Pmaxsw(encoded);

        public struct Vpmaxsw : ITypedInstruction<Vpmaxsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmaxsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmaxsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxsw src) => AsmMnemonics.VPMAXSW;

            public static implicit operator AsmHexCode(Vpmaxsw src) => src.Encoded;
        }

        public Vpmaxsw vpmaxsw() => default;

        [MethodImpl(Inline), Op]
        public Vpmaxsw vpmaxsw(AsmHexCode encoded) => new Vpmaxsw(encoded);

        public struct Pmaxub : ITypedInstruction<Pmaxub>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmaxub(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXUB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmaxub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxub src) => AsmMnemonics.PMAXUB;

            public static implicit operator AsmHexCode(Pmaxub src) => src.Encoded;
        }

        public Pmaxub pmaxub() => default;

        [MethodImpl(Inline), Op]
        public Pmaxub pmaxub(AsmHexCode encoded) => new Pmaxub(encoded);

        public struct Vpmaxub : ITypedInstruction<Vpmaxub>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmaxub(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXUB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmaxub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxub src) => AsmMnemonics.VPMAXUB;

            public static implicit operator AsmHexCode(Vpmaxub src) => src.Encoded;
        }

        public Vpmaxub vpmaxub() => default;

        [MethodImpl(Inline), Op]
        public Vpmaxub vpmaxub(AsmHexCode encoded) => new Vpmaxub(encoded);

        public struct Pmaxud : ITypedInstruction<Pmaxud>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmaxud(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXUD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmaxud src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxud src) => AsmMnemonics.PMAXUD;

            public static implicit operator AsmHexCode(Pmaxud src) => src.Encoded;
        }

        public Pmaxud pmaxud() => default;

        [MethodImpl(Inline), Op]
        public Pmaxud pmaxud(AsmHexCode encoded) => new Pmaxud(encoded);

        public struct Vpmaxud : ITypedInstruction<Vpmaxud>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmaxud(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXUD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmaxud src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxud src) => AsmMnemonics.VPMAXUD;

            public static implicit operator AsmHexCode(Vpmaxud src) => src.Encoded;
        }

        public Vpmaxud vpmaxud() => default;

        [MethodImpl(Inline), Op]
        public Vpmaxud vpmaxud(AsmHexCode encoded) => new Vpmaxud(encoded);

        public struct Pmaxuw : ITypedInstruction<Pmaxuw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmaxuw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXUW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmaxuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxuw src) => AsmMnemonics.PMAXUW;

            public static implicit operator AsmHexCode(Pmaxuw src) => src.Encoded;
        }

        public Pmaxuw pmaxuw() => default;

        [MethodImpl(Inline), Op]
        public Pmaxuw pmaxuw(AsmHexCode encoded) => new Pmaxuw(encoded);

        public struct Vpmaxuw : ITypedInstruction<Vpmaxuw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmaxuw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXUW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmaxuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxuw src) => AsmMnemonics.VPMAXUW;

            public static implicit operator AsmHexCode(Vpmaxuw src) => src.Encoded;
        }

        public Vpmaxuw vpmaxuw() => default;

        [MethodImpl(Inline), Op]
        public Vpmaxuw vpmaxuw(AsmHexCode encoded) => new Vpmaxuw(encoded);

        public struct Pminsb : ITypedInstruction<Pminsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pminsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pminsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminsb src) => AsmMnemonics.PMINSB;

            public static implicit operator AsmHexCode(Pminsb src) => src.Encoded;
        }

        public Pminsb pminsb() => default;

        [MethodImpl(Inline), Op]
        public Pminsb pminsb(AsmHexCode encoded) => new Pminsb(encoded);

        public struct Vpminsb : ITypedInstruction<Vpminsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpminsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpminsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminsb src) => AsmMnemonics.VPMINSB;

            public static implicit operator AsmHexCode(Vpminsb src) => src.Encoded;
        }

        public Vpminsb vpminsb() => default;

        [MethodImpl(Inline), Op]
        public Vpminsb vpminsb(AsmHexCode encoded) => new Vpminsb(encoded);

        public struct Pminsd : ITypedInstruction<Pminsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pminsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pminsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminsd src) => AsmMnemonics.PMINSD;

            public static implicit operator AsmHexCode(Pminsd src) => src.Encoded;
        }

        public Pminsd pminsd() => default;

        [MethodImpl(Inline), Op]
        public Pminsd pminsd(AsmHexCode encoded) => new Pminsd(encoded);

        public struct Vpminsd : ITypedInstruction<Vpminsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpminsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpminsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminsd src) => AsmMnemonics.VPMINSD;

            public static implicit operator AsmHexCode(Vpminsd src) => src.Encoded;
        }

        public Vpminsd vpminsd() => default;

        [MethodImpl(Inline), Op]
        public Vpminsd vpminsd(AsmHexCode encoded) => new Vpminsd(encoded);

        public struct Pminsw : ITypedInstruction<Pminsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pminsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pminsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminsw src) => AsmMnemonics.PMINSW;

            public static implicit operator AsmHexCode(Pminsw src) => src.Encoded;
        }

        public Pminsw pminsw() => default;

        [MethodImpl(Inline), Op]
        public Pminsw pminsw(AsmHexCode encoded) => new Pminsw(encoded);

        public struct Vpminsw : ITypedInstruction<Vpminsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpminsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpminsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminsw src) => AsmMnemonics.VPMINSW;

            public static implicit operator AsmHexCode(Vpminsw src) => src.Encoded;
        }

        public Vpminsw vpminsw() => default;

        [MethodImpl(Inline), Op]
        public Vpminsw vpminsw(AsmHexCode encoded) => new Vpminsw(encoded);

        public struct Pminub : ITypedInstruction<Pminub>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pminub(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINUB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pminub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminub src) => AsmMnemonics.PMINUB;

            public static implicit operator AsmHexCode(Pminub src) => src.Encoded;
        }

        public Pminub pminub() => default;

        [MethodImpl(Inline), Op]
        public Pminub pminub(AsmHexCode encoded) => new Pminub(encoded);

        public struct Vpminub : ITypedInstruction<Vpminub>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpminub(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINUB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpminub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminub src) => AsmMnemonics.VPMINUB;

            public static implicit operator AsmHexCode(Vpminub src) => src.Encoded;
        }

        public Vpminub vpminub() => default;

        [MethodImpl(Inline), Op]
        public Vpminub vpminub(AsmHexCode encoded) => new Vpminub(encoded);

        public struct Pminud : ITypedInstruction<Pminud>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pminud(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINUD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pminud src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminud src) => AsmMnemonics.PMINUD;

            public static implicit operator AsmHexCode(Pminud src) => src.Encoded;
        }

        public Pminud pminud() => default;

        [MethodImpl(Inline), Op]
        public Pminud pminud(AsmHexCode encoded) => new Pminud(encoded);

        public struct Vpminud : ITypedInstruction<Vpminud>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpminud(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINUD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpminud src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminud src) => AsmMnemonics.VPMINUD;

            public static implicit operator AsmHexCode(Vpminud src) => src.Encoded;
        }

        public Vpminud vpminud() => default;

        [MethodImpl(Inline), Op]
        public Vpminud vpminud(AsmHexCode encoded) => new Vpminud(encoded);

        public struct Pminuw : ITypedInstruction<Pminuw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pminuw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINUW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pminuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminuw src) => AsmMnemonics.PMINUW;

            public static implicit operator AsmHexCode(Pminuw src) => src.Encoded;
        }

        public Pminuw pminuw() => default;

        [MethodImpl(Inline), Op]
        public Pminuw pminuw(AsmHexCode encoded) => new Pminuw(encoded);

        public struct Vpminuw : ITypedInstruction<Vpminuw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpminuw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINUW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpminuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminuw src) => AsmMnemonics.VPMINUW;

            public static implicit operator AsmHexCode(Vpminuw src) => src.Encoded;
        }

        public Vpminuw vpminuw() => default;

        [MethodImpl(Inline), Op]
        public Vpminuw vpminuw(AsmHexCode encoded) => new Vpminuw(encoded);

        public struct Pmovmskb : ITypedInstruction<Pmovmskb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovmskb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVMSKB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovmskb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovmskb src) => AsmMnemonics.PMOVMSKB;

            public static implicit operator AsmHexCode(Pmovmskb src) => src.Encoded;
        }

        public Pmovmskb pmovmskb() => default;

        [MethodImpl(Inline), Op]
        public Pmovmskb pmovmskb(AsmHexCode encoded) => new Pmovmskb(encoded);

        public struct Vpmovmskb : ITypedInstruction<Vpmovmskb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovmskb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVMSKB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovmskb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovmskb src) => AsmMnemonics.VPMOVMSKB;

            public static implicit operator AsmHexCode(Vpmovmskb src) => src.Encoded;
        }

        public Vpmovmskb vpmovmskb() => default;

        [MethodImpl(Inline), Op]
        public Vpmovmskb vpmovmskb(AsmHexCode encoded) => new Vpmovmskb(encoded);

        public struct Pmovsxbw : ITypedInstruction<Pmovsxbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovsxbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovsxbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxbw src) => AsmMnemonics.PMOVSXBW;

            public static implicit operator AsmHexCode(Pmovsxbw src) => src.Encoded;
        }

        public Pmovsxbw pmovsxbw() => default;

        [MethodImpl(Inline), Op]
        public Pmovsxbw pmovsxbw(AsmHexCode encoded) => new Pmovsxbw(encoded);

        public struct Pmovsxbd : ITypedInstruction<Pmovsxbd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovsxbd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXBD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovsxbd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxbd src) => AsmMnemonics.PMOVSXBD;

            public static implicit operator AsmHexCode(Pmovsxbd src) => src.Encoded;
        }

        public Pmovsxbd pmovsxbd() => default;

        [MethodImpl(Inline), Op]
        public Pmovsxbd pmovsxbd(AsmHexCode encoded) => new Pmovsxbd(encoded);

        public struct Pmovsxbq : ITypedInstruction<Pmovsxbq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovsxbq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXBQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovsxbq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxbq src) => AsmMnemonics.PMOVSXBQ;

            public static implicit operator AsmHexCode(Pmovsxbq src) => src.Encoded;
        }

        public Pmovsxbq pmovsxbq() => default;

        [MethodImpl(Inline), Op]
        public Pmovsxbq pmovsxbq(AsmHexCode encoded) => new Pmovsxbq(encoded);

        public struct Pmovsxwd : ITypedInstruction<Pmovsxwd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovsxwd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXWD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovsxwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxwd src) => AsmMnemonics.PMOVSXWD;

            public static implicit operator AsmHexCode(Pmovsxwd src) => src.Encoded;
        }

        public Pmovsxwd pmovsxwd() => default;

        [MethodImpl(Inline), Op]
        public Pmovsxwd pmovsxwd(AsmHexCode encoded) => new Pmovsxwd(encoded);

        public struct Pmovsxwq : ITypedInstruction<Pmovsxwq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovsxwq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXWQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovsxwq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxwq src) => AsmMnemonics.PMOVSXWQ;

            public static implicit operator AsmHexCode(Pmovsxwq src) => src.Encoded;
        }

        public Pmovsxwq pmovsxwq() => default;

        [MethodImpl(Inline), Op]
        public Pmovsxwq pmovsxwq(AsmHexCode encoded) => new Pmovsxwq(encoded);

        public struct Pmovsxdq : ITypedInstruction<Pmovsxdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovsxdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovsxdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxdq src) => AsmMnemonics.PMOVSXDQ;

            public static implicit operator AsmHexCode(Pmovsxdq src) => src.Encoded;
        }

        public Pmovsxdq pmovsxdq() => default;

        [MethodImpl(Inline), Op]
        public Pmovsxdq pmovsxdq(AsmHexCode encoded) => new Pmovsxdq(encoded);

        public struct Vpmovsxbw : ITypedInstruction<Vpmovsxbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovsxbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovsxbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxbw src) => AsmMnemonics.VPMOVSXBW;

            public static implicit operator AsmHexCode(Vpmovsxbw src) => src.Encoded;
        }

        public Vpmovsxbw vpmovsxbw() => default;

        [MethodImpl(Inline), Op]
        public Vpmovsxbw vpmovsxbw(AsmHexCode encoded) => new Vpmovsxbw(encoded);

        public struct Vpmovsxbd : ITypedInstruction<Vpmovsxbd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovsxbd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXBD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovsxbd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxbd src) => AsmMnemonics.VPMOVSXBD;

            public static implicit operator AsmHexCode(Vpmovsxbd src) => src.Encoded;
        }

        public Vpmovsxbd vpmovsxbd() => default;

        [MethodImpl(Inline), Op]
        public Vpmovsxbd vpmovsxbd(AsmHexCode encoded) => new Vpmovsxbd(encoded);

        public struct Vpmovsxbq : ITypedInstruction<Vpmovsxbq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovsxbq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXBQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovsxbq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxbq src) => AsmMnemonics.VPMOVSXBQ;

            public static implicit operator AsmHexCode(Vpmovsxbq src) => src.Encoded;
        }

        public Vpmovsxbq vpmovsxbq() => default;

        [MethodImpl(Inline), Op]
        public Vpmovsxbq vpmovsxbq(AsmHexCode encoded) => new Vpmovsxbq(encoded);

        public struct Vpmovsxwd : ITypedInstruction<Vpmovsxwd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovsxwd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXWD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovsxwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxwd src) => AsmMnemonics.VPMOVSXWD;

            public static implicit operator AsmHexCode(Vpmovsxwd src) => src.Encoded;
        }

        public Vpmovsxwd vpmovsxwd() => default;

        [MethodImpl(Inline), Op]
        public Vpmovsxwd vpmovsxwd(AsmHexCode encoded) => new Vpmovsxwd(encoded);

        public struct Vpmovsxwq : ITypedInstruction<Vpmovsxwq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovsxwq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXWQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovsxwq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxwq src) => AsmMnemonics.VPMOVSXWQ;

            public static implicit operator AsmHexCode(Vpmovsxwq src) => src.Encoded;
        }

        public Vpmovsxwq vpmovsxwq() => default;

        [MethodImpl(Inline), Op]
        public Vpmovsxwq vpmovsxwq(AsmHexCode encoded) => new Vpmovsxwq(encoded);

        public struct Vpmovsxdq : ITypedInstruction<Vpmovsxdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovsxdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovsxdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxdq src) => AsmMnemonics.VPMOVSXDQ;

            public static implicit operator AsmHexCode(Vpmovsxdq src) => src.Encoded;
        }

        public Vpmovsxdq vpmovsxdq() => default;

        [MethodImpl(Inline), Op]
        public Vpmovsxdq vpmovsxdq(AsmHexCode encoded) => new Vpmovsxdq(encoded);

        public struct Pmovzxbw : ITypedInstruction<Pmovzxbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovzxbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovzxbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxbw src) => AsmMnemonics.PMOVZXBW;

            public static implicit operator AsmHexCode(Pmovzxbw src) => src.Encoded;
        }

        public Pmovzxbw pmovzxbw() => default;

        [MethodImpl(Inline), Op]
        public Pmovzxbw pmovzxbw(AsmHexCode encoded) => new Pmovzxbw(encoded);

        public struct Pmovzxbd : ITypedInstruction<Pmovzxbd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovzxbd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXBD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovzxbd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxbd src) => AsmMnemonics.PMOVZXBD;

            public static implicit operator AsmHexCode(Pmovzxbd src) => src.Encoded;
        }

        public Pmovzxbd pmovzxbd() => default;

        [MethodImpl(Inline), Op]
        public Pmovzxbd pmovzxbd(AsmHexCode encoded) => new Pmovzxbd(encoded);

        public struct Pmovzxbq : ITypedInstruction<Pmovzxbq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovzxbq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXBQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovzxbq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxbq src) => AsmMnemonics.PMOVZXBQ;

            public static implicit operator AsmHexCode(Pmovzxbq src) => src.Encoded;
        }

        public Pmovzxbq pmovzxbq() => default;

        [MethodImpl(Inline), Op]
        public Pmovzxbq pmovzxbq(AsmHexCode encoded) => new Pmovzxbq(encoded);

        public struct Pmovzxwd : ITypedInstruction<Pmovzxwd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovzxwd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXWD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovzxwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxwd src) => AsmMnemonics.PMOVZXWD;

            public static implicit operator AsmHexCode(Pmovzxwd src) => src.Encoded;
        }

        public Pmovzxwd pmovzxwd() => default;

        [MethodImpl(Inline), Op]
        public Pmovzxwd pmovzxwd(AsmHexCode encoded) => new Pmovzxwd(encoded);

        public struct Pmovzxwq : ITypedInstruction<Pmovzxwq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovzxwq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXWQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovzxwq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxwq src) => AsmMnemonics.PMOVZXWQ;

            public static implicit operator AsmHexCode(Pmovzxwq src) => src.Encoded;
        }

        public Pmovzxwq pmovzxwq() => default;

        [MethodImpl(Inline), Op]
        public Pmovzxwq pmovzxwq(AsmHexCode encoded) => new Pmovzxwq(encoded);

        public struct Pmovzxdq : ITypedInstruction<Pmovzxdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmovzxdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmovzxdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxdq src) => AsmMnemonics.PMOVZXDQ;

            public static implicit operator AsmHexCode(Pmovzxdq src) => src.Encoded;
        }

        public Pmovzxdq pmovzxdq() => default;

        [MethodImpl(Inline), Op]
        public Pmovzxdq pmovzxdq(AsmHexCode encoded) => new Pmovzxdq(encoded);

        public struct Vpmovzxbw : ITypedInstruction<Vpmovzxbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovzxbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovzxbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxbw src) => AsmMnemonics.VPMOVZXBW;

            public static implicit operator AsmHexCode(Vpmovzxbw src) => src.Encoded;
        }

        public Vpmovzxbw vpmovzxbw() => default;

        [MethodImpl(Inline), Op]
        public Vpmovzxbw vpmovzxbw(AsmHexCode encoded) => new Vpmovzxbw(encoded);

        public struct Vpmovzxbd : ITypedInstruction<Vpmovzxbd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovzxbd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXBD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovzxbd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxbd src) => AsmMnemonics.VPMOVZXBD;

            public static implicit operator AsmHexCode(Vpmovzxbd src) => src.Encoded;
        }

        public Vpmovzxbd vpmovzxbd() => default;

        [MethodImpl(Inline), Op]
        public Vpmovzxbd vpmovzxbd(AsmHexCode encoded) => new Vpmovzxbd(encoded);

        public struct Vpmovzxbq : ITypedInstruction<Vpmovzxbq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovzxbq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXBQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovzxbq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxbq src) => AsmMnemonics.VPMOVZXBQ;

            public static implicit operator AsmHexCode(Vpmovzxbq src) => src.Encoded;
        }

        public Vpmovzxbq vpmovzxbq() => default;

        [MethodImpl(Inline), Op]
        public Vpmovzxbq vpmovzxbq(AsmHexCode encoded) => new Vpmovzxbq(encoded);

        public struct Vpmovzxwd : ITypedInstruction<Vpmovzxwd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovzxwd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXWD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovzxwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxwd src) => AsmMnemonics.VPMOVZXWD;

            public static implicit operator AsmHexCode(Vpmovzxwd src) => src.Encoded;
        }

        public Vpmovzxwd vpmovzxwd() => default;

        [MethodImpl(Inline), Op]
        public Vpmovzxwd vpmovzxwd(AsmHexCode encoded) => new Vpmovzxwd(encoded);

        public struct Vpmovzxwq : ITypedInstruction<Vpmovzxwq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovzxwq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXWQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovzxwq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxwq src) => AsmMnemonics.VPMOVZXWQ;

            public static implicit operator AsmHexCode(Vpmovzxwq src) => src.Encoded;
        }

        public Vpmovzxwq vpmovzxwq() => default;

        [MethodImpl(Inline), Op]
        public Vpmovzxwq vpmovzxwq(AsmHexCode encoded) => new Vpmovzxwq(encoded);

        public struct Vpmovzxdq : ITypedInstruction<Vpmovzxdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmovzxdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmovzxdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxdq src) => AsmMnemonics.VPMOVZXDQ;

            public static implicit operator AsmHexCode(Vpmovzxdq src) => src.Encoded;
        }

        public Vpmovzxdq vpmovzxdq() => default;

        [MethodImpl(Inline), Op]
        public Vpmovzxdq vpmovzxdq(AsmHexCode encoded) => new Vpmovzxdq(encoded);

        public struct Pmuldq : ITypedInstruction<Pmuldq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmuldq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmuldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmuldq src) => AsmMnemonics.PMULDQ;

            public static implicit operator AsmHexCode(Pmuldq src) => src.Encoded;
        }

        public Pmuldq pmuldq() => default;

        [MethodImpl(Inline), Op]
        public Pmuldq pmuldq(AsmHexCode encoded) => new Pmuldq(encoded);

        public struct Vpmuldq : ITypedInstruction<Vpmuldq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmuldq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmuldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmuldq src) => AsmMnemonics.VPMULDQ;

            public static implicit operator AsmHexCode(Vpmuldq src) => src.Encoded;
        }

        public Vpmuldq vpmuldq() => default;

        [MethodImpl(Inline), Op]
        public Vpmuldq vpmuldq(AsmHexCode encoded) => new Vpmuldq(encoded);

        public struct Pmulhrsw : ITypedInstruction<Pmulhrsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmulhrsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULHRSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmulhrsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmulhrsw src) => AsmMnemonics.PMULHRSW;

            public static implicit operator AsmHexCode(Pmulhrsw src) => src.Encoded;
        }

        public Pmulhrsw pmulhrsw() => default;

        [MethodImpl(Inline), Op]
        public Pmulhrsw pmulhrsw(AsmHexCode encoded) => new Pmulhrsw(encoded);

        public struct Vpmulhrsw : ITypedInstruction<Vpmulhrsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmulhrsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULHRSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmulhrsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmulhrsw src) => AsmMnemonics.VPMULHRSW;

            public static implicit operator AsmHexCode(Vpmulhrsw src) => src.Encoded;
        }

        public Vpmulhrsw vpmulhrsw() => default;

        [MethodImpl(Inline), Op]
        public Vpmulhrsw vpmulhrsw(AsmHexCode encoded) => new Vpmulhrsw(encoded);

        public struct Pmulhuw : ITypedInstruction<Pmulhuw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmulhuw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULHUW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmulhuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmulhuw src) => AsmMnemonics.PMULHUW;

            public static implicit operator AsmHexCode(Pmulhuw src) => src.Encoded;
        }

        public Pmulhuw pmulhuw() => default;

        [MethodImpl(Inline), Op]
        public Pmulhuw pmulhuw(AsmHexCode encoded) => new Pmulhuw(encoded);

        public struct Vpmulhuw : ITypedInstruction<Vpmulhuw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmulhuw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULHUW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmulhuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmulhuw src) => AsmMnemonics.VPMULHUW;

            public static implicit operator AsmHexCode(Vpmulhuw src) => src.Encoded;
        }

        public Vpmulhuw vpmulhuw() => default;

        [MethodImpl(Inline), Op]
        public Vpmulhuw vpmulhuw(AsmHexCode encoded) => new Vpmulhuw(encoded);

        public struct Pmulhw : ITypedInstruction<Pmulhw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmulhw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULHW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmulhw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmulhw src) => AsmMnemonics.PMULHW;

            public static implicit operator AsmHexCode(Pmulhw src) => src.Encoded;
        }

        public Pmulhw pmulhw() => default;

        [MethodImpl(Inline), Op]
        public Pmulhw pmulhw(AsmHexCode encoded) => new Pmulhw(encoded);

        public struct Vpmulhw : ITypedInstruction<Vpmulhw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmulhw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULHW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmulhw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmulhw src) => AsmMnemonics.VPMULHW;

            public static implicit operator AsmHexCode(Vpmulhw src) => src.Encoded;
        }

        public Vpmulhw vpmulhw() => default;

        [MethodImpl(Inline), Op]
        public Vpmulhw vpmulhw(AsmHexCode encoded) => new Vpmulhw(encoded);

        public struct Pmulld : ITypedInstruction<Pmulld>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmulld(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULLD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmulld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmulld src) => AsmMnemonics.PMULLD;

            public static implicit operator AsmHexCode(Pmulld src) => src.Encoded;
        }

        public Pmulld pmulld() => default;

        [MethodImpl(Inline), Op]
        public Pmulld pmulld(AsmHexCode encoded) => new Pmulld(encoded);

        public struct Vpmulld : ITypedInstruction<Vpmulld>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmulld(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULLD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmulld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmulld src) => AsmMnemonics.VPMULLD;

            public static implicit operator AsmHexCode(Vpmulld src) => src.Encoded;
        }

        public Vpmulld vpmulld() => default;

        [MethodImpl(Inline), Op]
        public Vpmulld vpmulld(AsmHexCode encoded) => new Vpmulld(encoded);

        public struct Pmullw : ITypedInstruction<Pmullw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmullw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULLW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmullw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmullw src) => AsmMnemonics.PMULLW;

            public static implicit operator AsmHexCode(Pmullw src) => src.Encoded;
        }

        public Pmullw pmullw() => default;

        [MethodImpl(Inline), Op]
        public Pmullw pmullw(AsmHexCode encoded) => new Pmullw(encoded);

        public struct Vpmullw : ITypedInstruction<Vpmullw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmullw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULLW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmullw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmullw src) => AsmMnemonics.VPMULLW;

            public static implicit operator AsmHexCode(Vpmullw src) => src.Encoded;
        }

        public Vpmullw vpmullw() => default;

        [MethodImpl(Inline), Op]
        public Vpmullw vpmullw(AsmHexCode encoded) => new Vpmullw(encoded);

        public struct Pmuludq : ITypedInstruction<Pmuludq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pmuludq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULUDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pmuludq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmuludq src) => AsmMnemonics.PMULUDQ;

            public static implicit operator AsmHexCode(Pmuludq src) => src.Encoded;
        }

        public Pmuludq pmuludq() => default;

        [MethodImpl(Inline), Op]
        public Pmuludq pmuludq(AsmHexCode encoded) => new Pmuludq(encoded);

        public struct Vpmuludq : ITypedInstruction<Vpmuludq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmuludq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULUDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmuludq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmuludq src) => AsmMnemonics.VPMULUDQ;

            public static implicit operator AsmHexCode(Vpmuludq src) => src.Encoded;
        }

        public Vpmuludq vpmuludq() => default;

        [MethodImpl(Inline), Op]
        public Vpmuludq vpmuludq(AsmHexCode encoded) => new Vpmuludq(encoded);

        public struct Pop : ITypedInstruction<Pop>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pop(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pop src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pop src) => AsmMnemonics.POP;

            public static implicit operator AsmHexCode(Pop src) => src.Encoded;
        }

        public Pop pop() => default;

        [MethodImpl(Inline), Op]
        public Pop pop(AsmHexCode encoded) => new Pop(encoded);

        public struct Popa : ITypedInstruction<Popa>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Popa(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Popa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popa src) => AsmMnemonics.POPA;

            public static implicit operator AsmHexCode(Popa src) => src.Encoded;
        }

        public Popa popa() => default;

        [MethodImpl(Inline), Op]
        public Popa popa(AsmHexCode encoded) => new Popa(encoded);

        public struct Popad : ITypedInstruction<Popad>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Popad(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPAD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Popad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popad src) => AsmMnemonics.POPAD;

            public static implicit operator AsmHexCode(Popad src) => src.Encoded;
        }

        public Popad popad() => default;

        [MethodImpl(Inline), Op]
        public Popad popad(AsmHexCode encoded) => new Popad(encoded);

        public struct Popcnt : ITypedInstruction<Popcnt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Popcnt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPCNT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Popcnt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popcnt src) => AsmMnemonics.POPCNT;

            public static implicit operator AsmHexCode(Popcnt src) => src.Encoded;
        }

        public Popcnt popcnt() => default;

        [MethodImpl(Inline), Op]
        public Popcnt popcnt(AsmHexCode encoded) => new Popcnt(encoded);

        public struct Popf : ITypedInstruction<Popf>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Popf(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPF;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Popf src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popf src) => AsmMnemonics.POPF;

            public static implicit operator AsmHexCode(Popf src) => src.Encoded;
        }

        public Popf popf() => default;

        [MethodImpl(Inline), Op]
        public Popf popf(AsmHexCode encoded) => new Popf(encoded);

        public struct Popfd : ITypedInstruction<Popfd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Popfd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPFD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Popfd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popfd src) => AsmMnemonics.POPFD;

            public static implicit operator AsmHexCode(Popfd src) => src.Encoded;
        }

        public Popfd popfd() => default;

        [MethodImpl(Inline), Op]
        public Popfd popfd(AsmHexCode encoded) => new Popfd(encoded);

        public struct Popfq : ITypedInstruction<Popfq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Popfq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPFQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Popfq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popfq src) => AsmMnemonics.POPFQ;

            public static implicit operator AsmHexCode(Popfq src) => src.Encoded;
        }

        public Popfq popfq() => default;

        [MethodImpl(Inline), Op]
        public Popfq popfq(AsmHexCode encoded) => new Popfq(encoded);

        public struct Por : ITypedInstruction<Por>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Por(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Por src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Por src) => AsmMnemonics.POR;

            public static implicit operator AsmHexCode(Por src) => src.Encoded;
        }

        public Por por() => default;

        [MethodImpl(Inline), Op]
        public Por por(AsmHexCode encoded) => new Por(encoded);

        public struct Vpor : ITypedInstruction<Vpor>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpor(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPOR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpor src) => AsmMnemonics.VPOR;

            public static implicit operator AsmHexCode(Vpor src) => src.Encoded;
        }

        public Vpor vpor() => default;

        [MethodImpl(Inline), Op]
        public Vpor vpor(AsmHexCode encoded) => new Vpor(encoded);

        public struct Prefetcht0 : ITypedInstruction<Prefetcht0>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Prefetcht0(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHT0;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Prefetcht0 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Prefetcht0 src) => AsmMnemonics.PREFETCHT0;

            public static implicit operator AsmHexCode(Prefetcht0 src) => src.Encoded;
        }

        public Prefetcht0 prefetcht0() => default;

        [MethodImpl(Inline), Op]
        public Prefetcht0 prefetcht0(AsmHexCode encoded) => new Prefetcht0(encoded);

        public struct Prefetcht1 : ITypedInstruction<Prefetcht1>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Prefetcht1(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHT1;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Prefetcht1 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Prefetcht1 src) => AsmMnemonics.PREFETCHT1;

            public static implicit operator AsmHexCode(Prefetcht1 src) => src.Encoded;
        }

        public Prefetcht1 prefetcht1() => default;

        [MethodImpl(Inline), Op]
        public Prefetcht1 prefetcht1(AsmHexCode encoded) => new Prefetcht1(encoded);

        public struct Prefetcht2 : ITypedInstruction<Prefetcht2>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Prefetcht2(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHT2;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Prefetcht2 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Prefetcht2 src) => AsmMnemonics.PREFETCHT2;

            public static implicit operator AsmHexCode(Prefetcht2 src) => src.Encoded;
        }

        public Prefetcht2 prefetcht2() => default;

        [MethodImpl(Inline), Op]
        public Prefetcht2 prefetcht2(AsmHexCode encoded) => new Prefetcht2(encoded);

        public struct Prefetchnta : ITypedInstruction<Prefetchnta>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Prefetchnta(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHNTA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Prefetchnta src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Prefetchnta src) => AsmMnemonics.PREFETCHNTA;

            public static implicit operator AsmHexCode(Prefetchnta src) => src.Encoded;
        }

        public Prefetchnta prefetchnta() => default;

        [MethodImpl(Inline), Op]
        public Prefetchnta prefetchnta(AsmHexCode encoded) => new Prefetchnta(encoded);

        public struct Psadbw : ITypedInstruction<Psadbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psadbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSADBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psadbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psadbw src) => AsmMnemonics.PSADBW;

            public static implicit operator AsmHexCode(Psadbw src) => src.Encoded;
        }

        public Psadbw psadbw() => default;

        [MethodImpl(Inline), Op]
        public Psadbw psadbw(AsmHexCode encoded) => new Psadbw(encoded);

        public struct Vpsadbw : ITypedInstruction<Vpsadbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsadbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSADBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsadbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsadbw src) => AsmMnemonics.VPSADBW;

            public static implicit operator AsmHexCode(Vpsadbw src) => src.Encoded;
        }

        public Vpsadbw vpsadbw() => default;

        [MethodImpl(Inline), Op]
        public Vpsadbw vpsadbw(AsmHexCode encoded) => new Vpsadbw(encoded);

        public struct Pshufb : ITypedInstruction<Pshufb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pshufb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pshufb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshufb src) => AsmMnemonics.PSHUFB;

            public static implicit operator AsmHexCode(Pshufb src) => src.Encoded;
        }

        public Pshufb pshufb() => default;

        [MethodImpl(Inline), Op]
        public Pshufb pshufb(AsmHexCode encoded) => new Pshufb(encoded);

        public struct Vpshufb : ITypedInstruction<Vpshufb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpshufb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpshufb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpshufb src) => AsmMnemonics.VPSHUFB;

            public static implicit operator AsmHexCode(Vpshufb src) => src.Encoded;
        }

        public Vpshufb vpshufb() => default;

        [MethodImpl(Inline), Op]
        public Vpshufb vpshufb(AsmHexCode encoded) => new Vpshufb(encoded);

        public struct Pshufd : ITypedInstruction<Pshufd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pshufd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pshufd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshufd src) => AsmMnemonics.PSHUFD;

            public static implicit operator AsmHexCode(Pshufd src) => src.Encoded;
        }

        public Pshufd pshufd() => default;

        [MethodImpl(Inline), Op]
        public Pshufd pshufd(AsmHexCode encoded) => new Pshufd(encoded);

        public struct Vpshufd : ITypedInstruction<Vpshufd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpshufd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpshufd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpshufd src) => AsmMnemonics.VPSHUFD;

            public static implicit operator AsmHexCode(Vpshufd src) => src.Encoded;
        }

        public Vpshufd vpshufd() => default;

        [MethodImpl(Inline), Op]
        public Vpshufd vpshufd(AsmHexCode encoded) => new Vpshufd(encoded);

        public struct Pshufhw : ITypedInstruction<Pshufhw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pshufhw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFHW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pshufhw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshufhw src) => AsmMnemonics.PSHUFHW;

            public static implicit operator AsmHexCode(Pshufhw src) => src.Encoded;
        }

        public Pshufhw pshufhw() => default;

        [MethodImpl(Inline), Op]
        public Pshufhw pshufhw(AsmHexCode encoded) => new Pshufhw(encoded);

        public struct Vpshufhw : ITypedInstruction<Vpshufhw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpshufhw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFHW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpshufhw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpshufhw src) => AsmMnemonics.VPSHUFHW;

            public static implicit operator AsmHexCode(Vpshufhw src) => src.Encoded;
        }

        public Vpshufhw vpshufhw() => default;

        [MethodImpl(Inline), Op]
        public Vpshufhw vpshufhw(AsmHexCode encoded) => new Vpshufhw(encoded);

        public struct Pshuflw : ITypedInstruction<Pshuflw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pshuflw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFLW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pshuflw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshuflw src) => AsmMnemonics.PSHUFLW;

            public static implicit operator AsmHexCode(Pshuflw src) => src.Encoded;
        }

        public Pshuflw pshuflw() => default;

        [MethodImpl(Inline), Op]
        public Pshuflw pshuflw(AsmHexCode encoded) => new Pshuflw(encoded);

        public struct Vpshuflw : ITypedInstruction<Vpshuflw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpshuflw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFLW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpshuflw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpshuflw src) => AsmMnemonics.VPSHUFLW;

            public static implicit operator AsmHexCode(Vpshuflw src) => src.Encoded;
        }

        public Vpshuflw vpshuflw() => default;

        [MethodImpl(Inline), Op]
        public Vpshuflw vpshuflw(AsmHexCode encoded) => new Vpshuflw(encoded);

        public struct Pshufw : ITypedInstruction<Pshufw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pshufw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pshufw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshufw src) => AsmMnemonics.PSHUFW;

            public static implicit operator AsmHexCode(Pshufw src) => src.Encoded;
        }

        public Pshufw pshufw() => default;

        [MethodImpl(Inline), Op]
        public Pshufw pshufw(AsmHexCode encoded) => new Pshufw(encoded);

        public struct Psignb : ITypedInstruction<Psignb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psignb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSIGNB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psignb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psignb src) => AsmMnemonics.PSIGNB;

            public static implicit operator AsmHexCode(Psignb src) => src.Encoded;
        }

        public Psignb psignb() => default;

        [MethodImpl(Inline), Op]
        public Psignb psignb(AsmHexCode encoded) => new Psignb(encoded);

        public struct Psignw : ITypedInstruction<Psignw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psignw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSIGNW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psignw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psignw src) => AsmMnemonics.PSIGNW;

            public static implicit operator AsmHexCode(Psignw src) => src.Encoded;
        }

        public Psignw psignw() => default;

        [MethodImpl(Inline), Op]
        public Psignw psignw(AsmHexCode encoded) => new Psignw(encoded);

        public struct Psignd : ITypedInstruction<Psignd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psignd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSIGND;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psignd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psignd src) => AsmMnemonics.PSIGND;

            public static implicit operator AsmHexCode(Psignd src) => src.Encoded;
        }

        public Psignd psignd() => default;

        [MethodImpl(Inline), Op]
        public Psignd psignd(AsmHexCode encoded) => new Psignd(encoded);

        public struct Vpsignb : ITypedInstruction<Vpsignb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsignb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSIGNB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsignb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsignb src) => AsmMnemonics.VPSIGNB;

            public static implicit operator AsmHexCode(Vpsignb src) => src.Encoded;
        }

        public Vpsignb vpsignb() => default;

        [MethodImpl(Inline), Op]
        public Vpsignb vpsignb(AsmHexCode encoded) => new Vpsignb(encoded);

        public struct Vpsignw : ITypedInstruction<Vpsignw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsignw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSIGNW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsignw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsignw src) => AsmMnemonics.VPSIGNW;

            public static implicit operator AsmHexCode(Vpsignw src) => src.Encoded;
        }

        public Vpsignw vpsignw() => default;

        [MethodImpl(Inline), Op]
        public Vpsignw vpsignw(AsmHexCode encoded) => new Vpsignw(encoded);

        public struct Vpsignd : ITypedInstruction<Vpsignd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsignd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSIGND;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsignd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsignd src) => AsmMnemonics.VPSIGND;

            public static implicit operator AsmHexCode(Vpsignd src) => src.Encoded;
        }

        public Vpsignd vpsignd() => default;

        [MethodImpl(Inline), Op]
        public Vpsignd vpsignd(AsmHexCode encoded) => new Vpsignd(encoded);

        public struct Pslldq : ITypedInstruction<Pslldq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pslldq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pslldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pslldq src) => AsmMnemonics.PSLLDQ;

            public static implicit operator AsmHexCode(Pslldq src) => src.Encoded;
        }

        public Pslldq pslldq() => default;

        [MethodImpl(Inline), Op]
        public Pslldq pslldq(AsmHexCode encoded) => new Pslldq(encoded);

        public struct Vpslldq : ITypedInstruction<Vpslldq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpslldq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpslldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpslldq src) => AsmMnemonics.VPSLLDQ;

            public static implicit operator AsmHexCode(Vpslldq src) => src.Encoded;
        }

        public Vpslldq vpslldq() => default;

        [MethodImpl(Inline), Op]
        public Vpslldq vpslldq(AsmHexCode encoded) => new Vpslldq(encoded);

        public struct Psllw : ITypedInstruction<Psllw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psllw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psllw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psllw src) => AsmMnemonics.PSLLW;

            public static implicit operator AsmHexCode(Psllw src) => src.Encoded;
        }

        public Psllw psllw() => default;

        [MethodImpl(Inline), Op]
        public Psllw psllw(AsmHexCode encoded) => new Psllw(encoded);

        public struct Pslld : ITypedInstruction<Pslld>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pslld(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pslld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pslld src) => AsmMnemonics.PSLLD;

            public static implicit operator AsmHexCode(Pslld src) => src.Encoded;
        }

        public Pslld pslld() => default;

        [MethodImpl(Inline), Op]
        public Pslld pslld(AsmHexCode encoded) => new Pslld(encoded);

        public struct Psllq : ITypedInstruction<Psllq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psllq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psllq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psllq src) => AsmMnemonics.PSLLQ;

            public static implicit operator AsmHexCode(Psllq src) => src.Encoded;
        }

        public Psllq psllq() => default;

        [MethodImpl(Inline), Op]
        public Psllq psllq(AsmHexCode encoded) => new Psllq(encoded);

        public struct Vpsllw : ITypedInstruction<Vpsllw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsllw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsllw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsllw src) => AsmMnemonics.VPSLLW;

            public static implicit operator AsmHexCode(Vpsllw src) => src.Encoded;
        }

        public Vpsllw vpsllw() => default;

        [MethodImpl(Inline), Op]
        public Vpsllw vpsllw(AsmHexCode encoded) => new Vpsllw(encoded);

        public struct Vpslld : ITypedInstruction<Vpslld>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpslld(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpslld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpslld src) => AsmMnemonics.VPSLLD;

            public static implicit operator AsmHexCode(Vpslld src) => src.Encoded;
        }

        public Vpslld vpslld() => default;

        [MethodImpl(Inline), Op]
        public Vpslld vpslld(AsmHexCode encoded) => new Vpslld(encoded);

        public struct Vpsllq : ITypedInstruction<Vpsllq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsllq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsllq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsllq src) => AsmMnemonics.VPSLLQ;

            public static implicit operator AsmHexCode(Vpsllq src) => src.Encoded;
        }

        public Vpsllq vpsllq() => default;

        [MethodImpl(Inline), Op]
        public Vpsllq vpsllq(AsmHexCode encoded) => new Vpsllq(encoded);

        public struct Psraw : ITypedInstruction<Psraw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psraw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRAW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psraw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psraw src) => AsmMnemonics.PSRAW;

            public static implicit operator AsmHexCode(Psraw src) => src.Encoded;
        }

        public Psraw psraw() => default;

        [MethodImpl(Inline), Op]
        public Psraw psraw(AsmHexCode encoded) => new Psraw(encoded);

        public struct Psrad : ITypedInstruction<Psrad>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psrad(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRAD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psrad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrad src) => AsmMnemonics.PSRAD;

            public static implicit operator AsmHexCode(Psrad src) => src.Encoded;
        }

        public Psrad psrad() => default;

        [MethodImpl(Inline), Op]
        public Psrad psrad(AsmHexCode encoded) => new Psrad(encoded);

        public struct Vpsraw : ITypedInstruction<Vpsraw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsraw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRAW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsraw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsraw src) => AsmMnemonics.VPSRAW;

            public static implicit operator AsmHexCode(Vpsraw src) => src.Encoded;
        }

        public Vpsraw vpsraw() => default;

        [MethodImpl(Inline), Op]
        public Vpsraw vpsraw(AsmHexCode encoded) => new Vpsraw(encoded);

        public struct Vpsrad : ITypedInstruction<Vpsrad>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsrad(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRAD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsrad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrad src) => AsmMnemonics.VPSRAD;

            public static implicit operator AsmHexCode(Vpsrad src) => src.Encoded;
        }

        public Vpsrad vpsrad() => default;

        [MethodImpl(Inline), Op]
        public Vpsrad vpsrad(AsmHexCode encoded) => new Vpsrad(encoded);

        public struct Psrldq : ITypedInstruction<Psrldq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psrldq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psrldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrldq src) => AsmMnemonics.PSRLDQ;

            public static implicit operator AsmHexCode(Psrldq src) => src.Encoded;
        }

        public Psrldq psrldq() => default;

        [MethodImpl(Inline), Op]
        public Psrldq psrldq(AsmHexCode encoded) => new Psrldq(encoded);

        public struct Vpsrldq : ITypedInstruction<Vpsrldq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsrldq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsrldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrldq src) => AsmMnemonics.VPSRLDQ;

            public static implicit operator AsmHexCode(Vpsrldq src) => src.Encoded;
        }

        public Vpsrldq vpsrldq() => default;

        [MethodImpl(Inline), Op]
        public Vpsrldq vpsrldq(AsmHexCode encoded) => new Vpsrldq(encoded);

        public struct Psrlw : ITypedInstruction<Psrlw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psrlw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psrlw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrlw src) => AsmMnemonics.PSRLW;

            public static implicit operator AsmHexCode(Psrlw src) => src.Encoded;
        }

        public Psrlw psrlw() => default;

        [MethodImpl(Inline), Op]
        public Psrlw psrlw(AsmHexCode encoded) => new Psrlw(encoded);

        public struct Psrld : ITypedInstruction<Psrld>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psrld(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psrld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrld src) => AsmMnemonics.PSRLD;

            public static implicit operator AsmHexCode(Psrld src) => src.Encoded;
        }

        public Psrld psrld() => default;

        [MethodImpl(Inline), Op]
        public Psrld psrld(AsmHexCode encoded) => new Psrld(encoded);

        public struct Psrlq : ITypedInstruction<Psrlq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psrlq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psrlq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrlq src) => AsmMnemonics.PSRLQ;

            public static implicit operator AsmHexCode(Psrlq src) => src.Encoded;
        }

        public Psrlq psrlq() => default;

        [MethodImpl(Inline), Op]
        public Psrlq psrlq(AsmHexCode encoded) => new Psrlq(encoded);

        public struct Vpsrlw : ITypedInstruction<Vpsrlw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsrlw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsrlw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrlw src) => AsmMnemonics.VPSRLW;

            public static implicit operator AsmHexCode(Vpsrlw src) => src.Encoded;
        }

        public Vpsrlw vpsrlw() => default;

        [MethodImpl(Inline), Op]
        public Vpsrlw vpsrlw(AsmHexCode encoded) => new Vpsrlw(encoded);

        public struct Vpsrld : ITypedInstruction<Vpsrld>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsrld(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsrld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrld src) => AsmMnemonics.VPSRLD;

            public static implicit operator AsmHexCode(Vpsrld src) => src.Encoded;
        }

        public Vpsrld vpsrld() => default;

        [MethodImpl(Inline), Op]
        public Vpsrld vpsrld(AsmHexCode encoded) => new Vpsrld(encoded);

        public struct Vpsrlq : ITypedInstruction<Vpsrlq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsrlq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsrlq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrlq src) => AsmMnemonics.VPSRLQ;

            public static implicit operator AsmHexCode(Vpsrlq src) => src.Encoded;
        }

        public Vpsrlq vpsrlq() => default;

        [MethodImpl(Inline), Op]
        public Vpsrlq vpsrlq(AsmHexCode encoded) => new Vpsrlq(encoded);

        public struct Psubb : ITypedInstruction<Psubb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psubb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psubb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubb src) => AsmMnemonics.PSUBB;

            public static implicit operator AsmHexCode(Psubb src) => src.Encoded;
        }

        public Psubb psubb() => default;

        [MethodImpl(Inline), Op]
        public Psubb psubb(AsmHexCode encoded) => new Psubb(encoded);

        public struct Psubw : ITypedInstruction<Psubw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psubw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psubw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubw src) => AsmMnemonics.PSUBW;

            public static implicit operator AsmHexCode(Psubw src) => src.Encoded;
        }

        public Psubw psubw() => default;

        [MethodImpl(Inline), Op]
        public Psubw psubw(AsmHexCode encoded) => new Psubw(encoded);

        public struct Psubd : ITypedInstruction<Psubd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psubd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psubd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubd src) => AsmMnemonics.PSUBD;

            public static implicit operator AsmHexCode(Psubd src) => src.Encoded;
        }

        public Psubd psubd() => default;

        [MethodImpl(Inline), Op]
        public Psubd psubd(AsmHexCode encoded) => new Psubd(encoded);

        public struct Vpsubb : ITypedInstruction<Vpsubb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsubb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsubb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubb src) => AsmMnemonics.VPSUBB;

            public static implicit operator AsmHexCode(Vpsubb src) => src.Encoded;
        }

        public Vpsubb vpsubb() => default;

        [MethodImpl(Inline), Op]
        public Vpsubb vpsubb(AsmHexCode encoded) => new Vpsubb(encoded);

        public struct Vpsubw : ITypedInstruction<Vpsubw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsubw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsubw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubw src) => AsmMnemonics.VPSUBW;

            public static implicit operator AsmHexCode(Vpsubw src) => src.Encoded;
        }

        public Vpsubw vpsubw() => default;

        [MethodImpl(Inline), Op]
        public Vpsubw vpsubw(AsmHexCode encoded) => new Vpsubw(encoded);

        public struct Vpsubd : ITypedInstruction<Vpsubd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsubd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsubd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubd src) => AsmMnemonics.VPSUBD;

            public static implicit operator AsmHexCode(Vpsubd src) => src.Encoded;
        }

        public Vpsubd vpsubd() => default;

        [MethodImpl(Inline), Op]
        public Vpsubd vpsubd(AsmHexCode encoded) => new Vpsubd(encoded);

        public struct Psubq : ITypedInstruction<Psubq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psubq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psubq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubq src) => AsmMnemonics.PSUBQ;

            public static implicit operator AsmHexCode(Psubq src) => src.Encoded;
        }

        public Psubq psubq() => default;

        [MethodImpl(Inline), Op]
        public Psubq psubq(AsmHexCode encoded) => new Psubq(encoded);

        public struct Vpsubq : ITypedInstruction<Vpsubq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsubq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsubq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubq src) => AsmMnemonics.VPSUBQ;

            public static implicit operator AsmHexCode(Vpsubq src) => src.Encoded;
        }

        public Vpsubq vpsubq() => default;

        [MethodImpl(Inline), Op]
        public Vpsubq vpsubq(AsmHexCode encoded) => new Vpsubq(encoded);

        public struct Psubsb : ITypedInstruction<Psubsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psubsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psubsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubsb src) => AsmMnemonics.PSUBSB;

            public static implicit operator AsmHexCode(Psubsb src) => src.Encoded;
        }

        public Psubsb psubsb() => default;

        [MethodImpl(Inline), Op]
        public Psubsb psubsb(AsmHexCode encoded) => new Psubsb(encoded);

        public struct Psubsw : ITypedInstruction<Psubsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psubsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubsw src) => AsmMnemonics.PSUBSW;

            public static implicit operator AsmHexCode(Psubsw src) => src.Encoded;
        }

        public Psubsw psubsw() => default;

        [MethodImpl(Inline), Op]
        public Psubsw psubsw(AsmHexCode encoded) => new Psubsw(encoded);

        public struct Vpsubsb : ITypedInstruction<Vpsubsb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsubsb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsubsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubsb src) => AsmMnemonics.VPSUBSB;

            public static implicit operator AsmHexCode(Vpsubsb src) => src.Encoded;
        }

        public Vpsubsb vpsubsb() => default;

        [MethodImpl(Inline), Op]
        public Vpsubsb vpsubsb(AsmHexCode encoded) => new Vpsubsb(encoded);

        public struct Vpsubsw : ITypedInstruction<Vpsubsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsubsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubsw src) => AsmMnemonics.VPSUBSW;

            public static implicit operator AsmHexCode(Vpsubsw src) => src.Encoded;
        }

        public Vpsubsw vpsubsw() => default;

        [MethodImpl(Inline), Op]
        public Vpsubsw vpsubsw(AsmHexCode encoded) => new Vpsubsw(encoded);

        public struct Psubusb : ITypedInstruction<Psubusb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psubusb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBUSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psubusb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubusb src) => AsmMnemonics.PSUBUSB;

            public static implicit operator AsmHexCode(Psubusb src) => src.Encoded;
        }

        public Psubusb psubusb() => default;

        [MethodImpl(Inline), Op]
        public Psubusb psubusb(AsmHexCode encoded) => new Psubusb(encoded);

        public struct Psubusw : ITypedInstruction<Psubusw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Psubusw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBUSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Psubusw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubusw src) => AsmMnemonics.PSUBUSW;

            public static implicit operator AsmHexCode(Psubusw src) => src.Encoded;
        }

        public Psubusw psubusw() => default;

        [MethodImpl(Inline), Op]
        public Psubusw psubusw(AsmHexCode encoded) => new Psubusw(encoded);

        public struct Vpsubusb : ITypedInstruction<Vpsubusb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsubusb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBUSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsubusb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubusb src) => AsmMnemonics.VPSUBUSB;

            public static implicit operator AsmHexCode(Vpsubusb src) => src.Encoded;
        }

        public Vpsubusb vpsubusb() => default;

        [MethodImpl(Inline), Op]
        public Vpsubusb vpsubusb(AsmHexCode encoded) => new Vpsubusb(encoded);

        public struct Vpsubusw : ITypedInstruction<Vpsubusw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsubusw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBUSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsubusw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubusw src) => AsmMnemonics.VPSUBUSW;

            public static implicit operator AsmHexCode(Vpsubusw src) => src.Encoded;
        }

        public Vpsubusw vpsubusw() => default;

        [MethodImpl(Inline), Op]
        public Vpsubusw vpsubusw(AsmHexCode encoded) => new Vpsubusw(encoded);

        public struct Ptest : ITypedInstruction<Ptest>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ptest(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PTEST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ptest src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ptest src) => AsmMnemonics.PTEST;

            public static implicit operator AsmHexCode(Ptest src) => src.Encoded;
        }

        public Ptest ptest() => default;

        [MethodImpl(Inline), Op]
        public Ptest ptest(AsmHexCode encoded) => new Ptest(encoded);

        public struct Vptest : ITypedInstruction<Vptest>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vptest(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPTEST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vptest src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vptest src) => AsmMnemonics.VPTEST;

            public static implicit operator AsmHexCode(Vptest src) => src.Encoded;
        }

        public Vptest vptest() => default;

        [MethodImpl(Inline), Op]
        public Vptest vptest(AsmHexCode encoded) => new Vptest(encoded);

        public struct Punpckhbw : ITypedInstruction<Punpckhbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Punpckhbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Punpckhbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckhbw src) => AsmMnemonics.PUNPCKHBW;

            public static implicit operator AsmHexCode(Punpckhbw src) => src.Encoded;
        }

        public Punpckhbw punpckhbw() => default;

        [MethodImpl(Inline), Op]
        public Punpckhbw punpckhbw(AsmHexCode encoded) => new Punpckhbw(encoded);

        public struct Punpckhwd : ITypedInstruction<Punpckhwd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Punpckhwd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHWD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Punpckhwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckhwd src) => AsmMnemonics.PUNPCKHWD;

            public static implicit operator AsmHexCode(Punpckhwd src) => src.Encoded;
        }

        public Punpckhwd punpckhwd() => default;

        [MethodImpl(Inline), Op]
        public Punpckhwd punpckhwd(AsmHexCode encoded) => new Punpckhwd(encoded);

        public struct Punpckhdq : ITypedInstruction<Punpckhdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Punpckhdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Punpckhdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckhdq src) => AsmMnemonics.PUNPCKHDQ;

            public static implicit operator AsmHexCode(Punpckhdq src) => src.Encoded;
        }

        public Punpckhdq punpckhdq() => default;

        [MethodImpl(Inline), Op]
        public Punpckhdq punpckhdq(AsmHexCode encoded) => new Punpckhdq(encoded);

        public struct Punpckhqdq : ITypedInstruction<Punpckhqdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Punpckhqdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHQDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Punpckhqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckhqdq src) => AsmMnemonics.PUNPCKHQDQ;

            public static implicit operator AsmHexCode(Punpckhqdq src) => src.Encoded;
        }

        public Punpckhqdq punpckhqdq() => default;

        [MethodImpl(Inline), Op]
        public Punpckhqdq punpckhqdq(AsmHexCode encoded) => new Punpckhqdq(encoded);

        public struct Vpunpckhbw : ITypedInstruction<Vpunpckhbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpunpckhbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpunpckhbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckhbw src) => AsmMnemonics.VPUNPCKHBW;

            public static implicit operator AsmHexCode(Vpunpckhbw src) => src.Encoded;
        }

        public Vpunpckhbw vpunpckhbw() => default;

        [MethodImpl(Inline), Op]
        public Vpunpckhbw vpunpckhbw(AsmHexCode encoded) => new Vpunpckhbw(encoded);

        public struct Vpunpckhwd : ITypedInstruction<Vpunpckhwd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpunpckhwd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHWD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpunpckhwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckhwd src) => AsmMnemonics.VPUNPCKHWD;

            public static implicit operator AsmHexCode(Vpunpckhwd src) => src.Encoded;
        }

        public Vpunpckhwd vpunpckhwd() => default;

        [MethodImpl(Inline), Op]
        public Vpunpckhwd vpunpckhwd(AsmHexCode encoded) => new Vpunpckhwd(encoded);

        public struct Vpunpckhdq : ITypedInstruction<Vpunpckhdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpunpckhdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpunpckhdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckhdq src) => AsmMnemonics.VPUNPCKHDQ;

            public static implicit operator AsmHexCode(Vpunpckhdq src) => src.Encoded;
        }

        public Vpunpckhdq vpunpckhdq() => default;

        [MethodImpl(Inline), Op]
        public Vpunpckhdq vpunpckhdq(AsmHexCode encoded) => new Vpunpckhdq(encoded);

        public struct Vpunpckhqdq : ITypedInstruction<Vpunpckhqdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpunpckhqdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHQDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpunpckhqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckhqdq src) => AsmMnemonics.VPUNPCKHQDQ;

            public static implicit operator AsmHexCode(Vpunpckhqdq src) => src.Encoded;
        }

        public Vpunpckhqdq vpunpckhqdq() => default;

        [MethodImpl(Inline), Op]
        public Vpunpckhqdq vpunpckhqdq(AsmHexCode encoded) => new Vpunpckhqdq(encoded);

        public struct Punpcklbw : ITypedInstruction<Punpcklbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Punpcklbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Punpcklbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpcklbw src) => AsmMnemonics.PUNPCKLBW;

            public static implicit operator AsmHexCode(Punpcklbw src) => src.Encoded;
        }

        public Punpcklbw punpcklbw() => default;

        [MethodImpl(Inline), Op]
        public Punpcklbw punpcklbw(AsmHexCode encoded) => new Punpcklbw(encoded);

        public struct Punpcklwd : ITypedInstruction<Punpcklwd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Punpcklwd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLWD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Punpcklwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpcklwd src) => AsmMnemonics.PUNPCKLWD;

            public static implicit operator AsmHexCode(Punpcklwd src) => src.Encoded;
        }

        public Punpcklwd punpcklwd() => default;

        [MethodImpl(Inline), Op]
        public Punpcklwd punpcklwd(AsmHexCode encoded) => new Punpcklwd(encoded);

        public struct Punpckldq : ITypedInstruction<Punpckldq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Punpckldq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Punpckldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckldq src) => AsmMnemonics.PUNPCKLDQ;

            public static implicit operator AsmHexCode(Punpckldq src) => src.Encoded;
        }

        public Punpckldq punpckldq() => default;

        [MethodImpl(Inline), Op]
        public Punpckldq punpckldq(AsmHexCode encoded) => new Punpckldq(encoded);

        public struct Punpcklqdq : ITypedInstruction<Punpcklqdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Punpcklqdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLQDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Punpcklqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpcklqdq src) => AsmMnemonics.PUNPCKLQDQ;

            public static implicit operator AsmHexCode(Punpcklqdq src) => src.Encoded;
        }

        public Punpcklqdq punpcklqdq() => default;

        [MethodImpl(Inline), Op]
        public Punpcklqdq punpcklqdq(AsmHexCode encoded) => new Punpcklqdq(encoded);

        public struct Vpunpcklbw : ITypedInstruction<Vpunpcklbw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpunpcklbw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLBW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpunpcklbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpcklbw src) => AsmMnemonics.VPUNPCKLBW;

            public static implicit operator AsmHexCode(Vpunpcklbw src) => src.Encoded;
        }

        public Vpunpcklbw vpunpcklbw() => default;

        [MethodImpl(Inline), Op]
        public Vpunpcklbw vpunpcklbw(AsmHexCode encoded) => new Vpunpcklbw(encoded);

        public struct Vpunpcklwd : ITypedInstruction<Vpunpcklwd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpunpcklwd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLWD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpunpcklwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpcklwd src) => AsmMnemonics.VPUNPCKLWD;

            public static implicit operator AsmHexCode(Vpunpcklwd src) => src.Encoded;
        }

        public Vpunpcklwd vpunpcklwd() => default;

        [MethodImpl(Inline), Op]
        public Vpunpcklwd vpunpcklwd(AsmHexCode encoded) => new Vpunpcklwd(encoded);

        public struct Vpunpckldq : ITypedInstruction<Vpunpckldq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpunpckldq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpunpckldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckldq src) => AsmMnemonics.VPUNPCKLDQ;

            public static implicit operator AsmHexCode(Vpunpckldq src) => src.Encoded;
        }

        public Vpunpckldq vpunpckldq() => default;

        [MethodImpl(Inline), Op]
        public Vpunpckldq vpunpckldq(AsmHexCode encoded) => new Vpunpckldq(encoded);

        public struct Vpunpcklqdq : ITypedInstruction<Vpunpcklqdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpunpcklqdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLQDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpunpcklqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpcklqdq src) => AsmMnemonics.VPUNPCKLQDQ;

            public static implicit operator AsmHexCode(Vpunpcklqdq src) => src.Encoded;
        }

        public Vpunpcklqdq vpunpcklqdq() => default;

        [MethodImpl(Inline), Op]
        public Vpunpcklqdq vpunpcklqdq(AsmHexCode encoded) => new Vpunpcklqdq(encoded);

        public struct Push : ITypedInstruction<Push>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Push(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSH;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Push src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Push src) => AsmMnemonics.PUSH;

            public static implicit operator AsmHexCode(Push src) => src.Encoded;
        }

        public Push push() => default;

        [MethodImpl(Inline), Op]
        public Push push(AsmHexCode encoded) => new Push(encoded);

        public struct Pushq : ITypedInstruction<Pushq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pushq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pushq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushq src) => AsmMnemonics.PUSHQ;

            public static implicit operator AsmHexCode(Pushq src) => src.Encoded;
        }

        public Pushq pushq() => default;

        [MethodImpl(Inline), Op]
        public Pushq pushq(AsmHexCode encoded) => new Pushq(encoded);

        public struct Pushw : ITypedInstruction<Pushw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pushw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pushw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushw src) => AsmMnemonics.PUSHW;

            public static implicit operator AsmHexCode(Pushw src) => src.Encoded;
        }

        public Pushw pushw() => default;

        [MethodImpl(Inline), Op]
        public Pushw pushw(AsmHexCode encoded) => new Pushw(encoded);

        public struct Pusha : ITypedInstruction<Pusha>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pusha(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pusha src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pusha src) => AsmMnemonics.PUSHA;

            public static implicit operator AsmHexCode(Pusha src) => src.Encoded;
        }

        public Pusha pusha() => default;

        [MethodImpl(Inline), Op]
        public Pusha pusha(AsmHexCode encoded) => new Pusha(encoded);

        public struct Pushad : ITypedInstruction<Pushad>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pushad(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHAD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pushad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushad src) => AsmMnemonics.PUSHAD;

            public static implicit operator AsmHexCode(Pushad src) => src.Encoded;
        }

        public Pushad pushad() => default;

        [MethodImpl(Inline), Op]
        public Pushad pushad(AsmHexCode encoded) => new Pushad(encoded);

        public struct Pushf : ITypedInstruction<Pushf>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pushf(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHF;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pushf src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushf src) => AsmMnemonics.PUSHF;

            public static implicit operator AsmHexCode(Pushf src) => src.Encoded;
        }

        public Pushf pushf() => default;

        [MethodImpl(Inline), Op]
        public Pushf pushf(AsmHexCode encoded) => new Pushf(encoded);

        public struct Pushfd : ITypedInstruction<Pushfd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pushfd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHFD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pushfd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushfd src) => AsmMnemonics.PUSHFD;

            public static implicit operator AsmHexCode(Pushfd src) => src.Encoded;
        }

        public Pushfd pushfd() => default;

        [MethodImpl(Inline), Op]
        public Pushfd pushfd(AsmHexCode encoded) => new Pushfd(encoded);

        public struct Pushfq : ITypedInstruction<Pushfq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pushfq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHFQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pushfq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushfq src) => AsmMnemonics.PUSHFQ;

            public static implicit operator AsmHexCode(Pushfq src) => src.Encoded;
        }

        public Pushfq pushfq() => default;

        [MethodImpl(Inline), Op]
        public Pushfq pushfq(AsmHexCode encoded) => new Pushfq(encoded);

        public struct Pxor : ITypedInstruction<Pxor>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Pxor(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PXOR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Pxor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pxor src) => AsmMnemonics.PXOR;

            public static implicit operator AsmHexCode(Pxor src) => src.Encoded;
        }

        public Pxor pxor() => default;

        [MethodImpl(Inline), Op]
        public Pxor pxor(AsmHexCode encoded) => new Pxor(encoded);

        public struct Vpxor : ITypedInstruction<Vpxor>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpxor(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPXOR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpxor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpxor src) => AsmMnemonics.VPXOR;

            public static implicit operator AsmHexCode(Vpxor src) => src.Encoded;
        }

        public Vpxor vpxor() => default;

        [MethodImpl(Inline), Op]
        public Vpxor vpxor(AsmHexCode encoded) => new Vpxor(encoded);

        public struct Rcl : ITypedInstruction<Rcl>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rcl(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rcl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rcl src) => AsmMnemonics.RCL;

            public static implicit operator AsmHexCode(Rcl src) => src.Encoded;
        }

        public Rcl rcl() => default;

        [MethodImpl(Inline), Op]
        public Rcl rcl(AsmHexCode encoded) => new Rcl(encoded);

        public struct Rcr : ITypedInstruction<Rcr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rcr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rcr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rcr src) => AsmMnemonics.RCR;

            public static implicit operator AsmHexCode(Rcr src) => src.Encoded;
        }

        public Rcr rcr() => default;

        [MethodImpl(Inline), Op]
        public Rcr rcr(AsmHexCode encoded) => new Rcr(encoded);

        public struct Rol : ITypedInstruction<Rol>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rol(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rol src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rol src) => AsmMnemonics.ROL;

            public static implicit operator AsmHexCode(Rol src) => src.Encoded;
        }

        public Rol rol() => default;

        [MethodImpl(Inline), Op]
        public Rol rol(AsmHexCode encoded) => new Rol(encoded);

        public struct Ror : ITypedInstruction<Ror>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ror(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ror src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ror src) => AsmMnemonics.ROR;

            public static implicit operator AsmHexCode(Ror src) => src.Encoded;
        }

        public Ror ror() => default;

        [MethodImpl(Inline), Op]
        public Ror ror(AsmHexCode encoded) => new Ror(encoded);

        public struct Rcpps : ITypedInstruction<Rcpps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rcpps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCPPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rcpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rcpps src) => AsmMnemonics.RCPPS;

            public static implicit operator AsmHexCode(Rcpps src) => src.Encoded;
        }

        public Rcpps rcpps() => default;

        [MethodImpl(Inline), Op]
        public Rcpps rcpps(AsmHexCode encoded) => new Rcpps(encoded);

        public struct Vrcpps : ITypedInstruction<Vrcpps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vrcpps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRCPPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vrcpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vrcpps src) => AsmMnemonics.VRCPPS;

            public static implicit operator AsmHexCode(Vrcpps src) => src.Encoded;
        }

        public Vrcpps vrcpps() => default;

        [MethodImpl(Inline), Op]
        public Vrcpps vrcpps(AsmHexCode encoded) => new Vrcpps(encoded);

        public struct Rcpss : ITypedInstruction<Rcpss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rcpss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCPSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rcpss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rcpss src) => AsmMnemonics.RCPSS;

            public static implicit operator AsmHexCode(Rcpss src) => src.Encoded;
        }

        public Rcpss rcpss() => default;

        [MethodImpl(Inline), Op]
        public Rcpss rcpss(AsmHexCode encoded) => new Rcpss(encoded);

        public struct Vrcpss : ITypedInstruction<Vrcpss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vrcpss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRCPSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vrcpss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vrcpss src) => AsmMnemonics.VRCPSS;

            public static implicit operator AsmHexCode(Vrcpss src) => src.Encoded;
        }

        public Vrcpss vrcpss() => default;

        [MethodImpl(Inline), Op]
        public Vrcpss vrcpss(AsmHexCode encoded) => new Vrcpss(encoded);

        public struct Rdfsbase : ITypedInstruction<Rdfsbase>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rdfsbase(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDFSBASE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rdfsbase src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdfsbase src) => AsmMnemonics.RDFSBASE;

            public static implicit operator AsmHexCode(Rdfsbase src) => src.Encoded;
        }

        public Rdfsbase rdfsbase() => default;

        [MethodImpl(Inline), Op]
        public Rdfsbase rdfsbase(AsmHexCode encoded) => new Rdfsbase(encoded);

        public struct Rdgsbase : ITypedInstruction<Rdgsbase>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rdgsbase(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDGSBASE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rdgsbase src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdgsbase src) => AsmMnemonics.RDGSBASE;

            public static implicit operator AsmHexCode(Rdgsbase src) => src.Encoded;
        }

        public Rdgsbase rdgsbase() => default;

        [MethodImpl(Inline), Op]
        public Rdgsbase rdgsbase(AsmHexCode encoded) => new Rdgsbase(encoded);

        public struct Rdmsr : ITypedInstruction<Rdmsr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rdmsr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDMSR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rdmsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdmsr src) => AsmMnemonics.RDMSR;

            public static implicit operator AsmHexCode(Rdmsr src) => src.Encoded;
        }

        public Rdmsr rdmsr() => default;

        [MethodImpl(Inline), Op]
        public Rdmsr rdmsr(AsmHexCode encoded) => new Rdmsr(encoded);

        public struct Rdpmc : ITypedInstruction<Rdpmc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rdpmc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDPMC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rdpmc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdpmc src) => AsmMnemonics.RDPMC;

            public static implicit operator AsmHexCode(Rdpmc src) => src.Encoded;
        }

        public Rdpmc rdpmc() => default;

        [MethodImpl(Inline), Op]
        public Rdpmc rdpmc(AsmHexCode encoded) => new Rdpmc(encoded);

        public struct Rdrand : ITypedInstruction<Rdrand>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rdrand(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDRAND;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rdrand src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdrand src) => AsmMnemonics.RDRAND;

            public static implicit operator AsmHexCode(Rdrand src) => src.Encoded;
        }

        public Rdrand rdrand() => default;

        [MethodImpl(Inline), Op]
        public Rdrand rdrand(AsmHexCode encoded) => new Rdrand(encoded);

        public struct Rdtsc : ITypedInstruction<Rdtsc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rdtsc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDTSC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rdtsc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdtsc src) => AsmMnemonics.RDTSC;

            public static implicit operator AsmHexCode(Rdtsc src) => src.Encoded;
        }

        public Rdtsc rdtsc() => default;

        [MethodImpl(Inline), Op]
        public Rdtsc rdtsc(AsmHexCode encoded) => new Rdtsc(encoded);

        public struct Rdtscp : ITypedInstruction<Rdtscp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rdtscp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDTSCP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rdtscp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdtscp src) => AsmMnemonics.RDTSCP;

            public static implicit operator AsmHexCode(Rdtscp src) => src.Encoded;
        }

        public Rdtscp rdtscp() => default;

        [MethodImpl(Inline), Op]
        public Rdtscp rdtscp(AsmHexCode encoded) => new Rdtscp(encoded);

        public struct Rep_ins : ITypedInstruction<Rep_ins>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rep_ins(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_INS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rep_ins src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_ins src) => AsmMnemonics.REP_INS;

            public static implicit operator AsmHexCode(Rep_ins src) => src.Encoded;
        }

        public Rep_ins rep_ins() => default;

        [MethodImpl(Inline), Op]
        public Rep_ins rep_ins(AsmHexCode encoded) => new Rep_ins(encoded);

        public struct Rep_movs : ITypedInstruction<Rep_movs>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rep_movs(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_MOVS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rep_movs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_movs src) => AsmMnemonics.REP_MOVS;

            public static implicit operator AsmHexCode(Rep_movs src) => src.Encoded;
        }

        public Rep_movs rep_movs() => default;

        [MethodImpl(Inline), Op]
        public Rep_movs rep_movs(AsmHexCode encoded) => new Rep_movs(encoded);

        public struct Rep_outs : ITypedInstruction<Rep_outs>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rep_outs(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_OUTS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rep_outs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_outs src) => AsmMnemonics.REP_OUTS;

            public static implicit operator AsmHexCode(Rep_outs src) => src.Encoded;
        }

        public Rep_outs rep_outs() => default;

        [MethodImpl(Inline), Op]
        public Rep_outs rep_outs(AsmHexCode encoded) => new Rep_outs(encoded);

        public struct Rep_lods : ITypedInstruction<Rep_lods>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rep_lods(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_LODS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rep_lods src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_lods src) => AsmMnemonics.REP_LODS;

            public static implicit operator AsmHexCode(Rep_lods src) => src.Encoded;
        }

        public Rep_lods rep_lods() => default;

        [MethodImpl(Inline), Op]
        public Rep_lods rep_lods(AsmHexCode encoded) => new Rep_lods(encoded);

        public struct Rep_stos : ITypedInstruction<Rep_stos>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rep_stos(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_STOS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rep_stos src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_stos src) => AsmMnemonics.REP_STOS;

            public static implicit operator AsmHexCode(Rep_stos src) => src.Encoded;
        }

        public Rep_stos rep_stos() => default;

        [MethodImpl(Inline), Op]
        public Rep_stos rep_stos(AsmHexCode encoded) => new Rep_stos(encoded);

        public struct Repe_cmps : ITypedInstruction<Repe_cmps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Repe_cmps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPE_CMPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Repe_cmps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Repe_cmps src) => AsmMnemonics.REPE_CMPS;

            public static implicit operator AsmHexCode(Repe_cmps src) => src.Encoded;
        }

        public Repe_cmps repe_cmps() => default;

        [MethodImpl(Inline), Op]
        public Repe_cmps repe_cmps(AsmHexCode encoded) => new Repe_cmps(encoded);

        public struct Repe_scas : ITypedInstruction<Repe_scas>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Repe_scas(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPE_SCAS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Repe_scas src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Repe_scas src) => AsmMnemonics.REPE_SCAS;

            public static implicit operator AsmHexCode(Repe_scas src) => src.Encoded;
        }

        public Repe_scas repe_scas() => default;

        [MethodImpl(Inline), Op]
        public Repe_scas repe_scas(AsmHexCode encoded) => new Repe_scas(encoded);

        public struct Repne_cmps : ITypedInstruction<Repne_cmps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Repne_cmps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPNE_CMPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Repne_cmps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Repne_cmps src) => AsmMnemonics.REPNE_CMPS;

            public static implicit operator AsmHexCode(Repne_cmps src) => src.Encoded;
        }

        public Repne_cmps repne_cmps() => default;

        [MethodImpl(Inline), Op]
        public Repne_cmps repne_cmps(AsmHexCode encoded) => new Repne_cmps(encoded);

        public struct Repne_scas : ITypedInstruction<Repne_scas>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Repne_scas(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPNE_SCAS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Repne_scas src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Repne_scas src) => AsmMnemonics.REPNE_SCAS;

            public static implicit operator AsmHexCode(Repne_scas src) => src.Encoded;
        }

        public Repne_scas repne_scas() => default;

        [MethodImpl(Inline), Op]
        public Repne_scas repne_scas(AsmHexCode encoded) => new Repne_scas(encoded);

        public struct Ret : ITypedInstruction<Ret>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ret(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RET;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ret src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ret src) => AsmMnemonics.RET;

            public static implicit operator AsmHexCode(Ret src) => src.Encoded;
        }

        public Ret ret() => default;

        [MethodImpl(Inline), Op]
        public Ret ret(AsmHexCode encoded) => new Ret(encoded);

        public struct Rorx : ITypedInstruction<Rorx>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rorx(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RORX;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rorx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rorx src) => AsmMnemonics.RORX;

            public static implicit operator AsmHexCode(Rorx src) => src.Encoded;
        }

        public Rorx rorx() => default;

        [MethodImpl(Inline), Op]
        public Rorx rorx(AsmHexCode encoded) => new Rorx(encoded);

        public struct Roundpd : ITypedInstruction<Roundpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Roundpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Roundpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Roundpd src) => AsmMnemonics.ROUNDPD;

            public static implicit operator AsmHexCode(Roundpd src) => src.Encoded;
        }

        public Roundpd roundpd() => default;

        [MethodImpl(Inline), Op]
        public Roundpd roundpd(AsmHexCode encoded) => new Roundpd(encoded);

        public struct Vroundpd : ITypedInstruction<Vroundpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vroundpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vroundpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vroundpd src) => AsmMnemonics.VROUNDPD;

            public static implicit operator AsmHexCode(Vroundpd src) => src.Encoded;
        }

        public Vroundpd vroundpd() => default;

        [MethodImpl(Inline), Op]
        public Vroundpd vroundpd(AsmHexCode encoded) => new Vroundpd(encoded);

        public struct Roundps : ITypedInstruction<Roundps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Roundps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Roundps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Roundps src) => AsmMnemonics.ROUNDPS;

            public static implicit operator AsmHexCode(Roundps src) => src.Encoded;
        }

        public Roundps roundps() => default;

        [MethodImpl(Inline), Op]
        public Roundps roundps(AsmHexCode encoded) => new Roundps(encoded);

        public struct Vroundps : ITypedInstruction<Vroundps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vroundps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vroundps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vroundps src) => AsmMnemonics.VROUNDPS;

            public static implicit operator AsmHexCode(Vroundps src) => src.Encoded;
        }

        public Vroundps vroundps() => default;

        [MethodImpl(Inline), Op]
        public Vroundps vroundps(AsmHexCode encoded) => new Vroundps(encoded);

        public struct Roundsd : ITypedInstruction<Roundsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Roundsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Roundsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Roundsd src) => AsmMnemonics.ROUNDSD;

            public static implicit operator AsmHexCode(Roundsd src) => src.Encoded;
        }

        public Roundsd roundsd() => default;

        [MethodImpl(Inline), Op]
        public Roundsd roundsd(AsmHexCode encoded) => new Roundsd(encoded);

        public struct Vroundsd : ITypedInstruction<Vroundsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vroundsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vroundsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vroundsd src) => AsmMnemonics.VROUNDSD;

            public static implicit operator AsmHexCode(Vroundsd src) => src.Encoded;
        }

        public Vroundsd vroundsd() => default;

        [MethodImpl(Inline), Op]
        public Vroundsd vroundsd(AsmHexCode encoded) => new Vroundsd(encoded);

        public struct Roundss : ITypedInstruction<Roundss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Roundss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Roundss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Roundss src) => AsmMnemonics.ROUNDSS;

            public static implicit operator AsmHexCode(Roundss src) => src.Encoded;
        }

        public Roundss roundss() => default;

        [MethodImpl(Inline), Op]
        public Roundss roundss(AsmHexCode encoded) => new Roundss(encoded);

        public struct Vroundss : ITypedInstruction<Vroundss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vroundss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vroundss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vroundss src) => AsmMnemonics.VROUNDSS;

            public static implicit operator AsmHexCode(Vroundss src) => src.Encoded;
        }

        public Vroundss vroundss() => default;

        [MethodImpl(Inline), Op]
        public Vroundss vroundss(AsmHexCode encoded) => new Vroundss(encoded);

        public struct Rsm : ITypedInstruction<Rsm>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rsm(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RSM;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rsm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rsm src) => AsmMnemonics.RSM;

            public static implicit operator AsmHexCode(Rsm src) => src.Encoded;
        }

        public Rsm rsm() => default;

        [MethodImpl(Inline), Op]
        public Rsm rsm(AsmHexCode encoded) => new Rsm(encoded);

        public struct Rsqrtps : ITypedInstruction<Rsqrtps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rsqrtps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RSQRTPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rsqrtps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rsqrtps src) => AsmMnemonics.RSQRTPS;

            public static implicit operator AsmHexCode(Rsqrtps src) => src.Encoded;
        }

        public Rsqrtps rsqrtps() => default;

        [MethodImpl(Inline), Op]
        public Rsqrtps rsqrtps(AsmHexCode encoded) => new Rsqrtps(encoded);

        public struct Vrsqrtps : ITypedInstruction<Vrsqrtps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vrsqrtps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRSQRTPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vrsqrtps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vrsqrtps src) => AsmMnemonics.VRSQRTPS;

            public static implicit operator AsmHexCode(Vrsqrtps src) => src.Encoded;
        }

        public Vrsqrtps vrsqrtps() => default;

        [MethodImpl(Inline), Op]
        public Vrsqrtps vrsqrtps(AsmHexCode encoded) => new Vrsqrtps(encoded);

        public struct Rsqrtss : ITypedInstruction<Rsqrtss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Rsqrtss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RSQRTSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Rsqrtss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rsqrtss src) => AsmMnemonics.RSQRTSS;

            public static implicit operator AsmHexCode(Rsqrtss src) => src.Encoded;
        }

        public Rsqrtss rsqrtss() => default;

        [MethodImpl(Inline), Op]
        public Rsqrtss rsqrtss(AsmHexCode encoded) => new Rsqrtss(encoded);

        public struct Vrsqrtss : ITypedInstruction<Vrsqrtss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vrsqrtss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRSQRTSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vrsqrtss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vrsqrtss src) => AsmMnemonics.VRSQRTSS;

            public static implicit operator AsmHexCode(Vrsqrtss src) => src.Encoded;
        }

        public Vrsqrtss vrsqrtss() => default;

        [MethodImpl(Inline), Op]
        public Vrsqrtss vrsqrtss(AsmHexCode encoded) => new Vrsqrtss(encoded);

        public struct Sahf : ITypedInstruction<Sahf>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sahf(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SAHF;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sahf src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sahf src) => AsmMnemonics.SAHF;

            public static implicit operator AsmHexCode(Sahf src) => src.Encoded;
        }

        public Sahf sahf() => default;

        [MethodImpl(Inline), Op]
        public Sahf sahf(AsmHexCode encoded) => new Sahf(encoded);

        public struct Sal : ITypedInstruction<Sal>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sal(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SAL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sal src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sal src) => AsmMnemonics.SAL;

            public static implicit operator AsmHexCode(Sal src) => src.Encoded;
        }

        public Sal sal() => default;

        [MethodImpl(Inline), Op]
        public Sal sal(AsmHexCode encoded) => new Sal(encoded);

        public struct Sar : ITypedInstruction<Sar>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sar(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SAR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sar src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sar src) => AsmMnemonics.SAR;

            public static implicit operator AsmHexCode(Sar src) => src.Encoded;
        }

        public Sar sar() => default;

        [MethodImpl(Inline), Op]
        public Sar sar(AsmHexCode encoded) => new Sar(encoded);

        public struct Shl : ITypedInstruction<Shl>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Shl(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Shl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shl src) => AsmMnemonics.SHL;

            public static implicit operator AsmHexCode(Shl src) => src.Encoded;
        }

        public Shl shl() => default;

        [MethodImpl(Inline), Op]
        public Shl shl(AsmHexCode encoded) => new Shl(encoded);

        public struct Shr : ITypedInstruction<Shr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Shr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Shr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shr src) => AsmMnemonics.SHR;

            public static implicit operator AsmHexCode(Shr src) => src.Encoded;
        }

        public Shr shr() => default;

        [MethodImpl(Inline), Op]
        public Shr shr(AsmHexCode encoded) => new Shr(encoded);

        public struct Sarx : ITypedInstruction<Sarx>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sarx(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SARX;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sarx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sarx src) => AsmMnemonics.SARX;

            public static implicit operator AsmHexCode(Sarx src) => src.Encoded;
        }

        public Sarx sarx() => default;

        [MethodImpl(Inline), Op]
        public Sarx sarx(AsmHexCode encoded) => new Sarx(encoded);

        public struct Shlx : ITypedInstruction<Shlx>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Shlx(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHLX;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Shlx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shlx src) => AsmMnemonics.SHLX;

            public static implicit operator AsmHexCode(Shlx src) => src.Encoded;
        }

        public Shlx shlx() => default;

        [MethodImpl(Inline), Op]
        public Shlx shlx(AsmHexCode encoded) => new Shlx(encoded);

        public struct Shrx : ITypedInstruction<Shrx>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Shrx(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHRX;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Shrx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shrx src) => AsmMnemonics.SHRX;

            public static implicit operator AsmHexCode(Shrx src) => src.Encoded;
        }

        public Shrx shrx() => default;

        [MethodImpl(Inline), Op]
        public Shrx shrx(AsmHexCode encoded) => new Shrx(encoded);

        public struct Sbb : ITypedInstruction<Sbb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sbb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SBB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sbb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sbb src) => AsmMnemonics.SBB;

            public static implicit operator AsmHexCode(Sbb src) => src.Encoded;
        }

        public Sbb sbb() => default;

        [MethodImpl(Inline), Op]
        public Sbb sbb(AsmHexCode encoded) => new Sbb(encoded);

        public struct Scas : ITypedInstruction<Scas>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Scas(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SCAS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Scas src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Scas src) => AsmMnemonics.SCAS;

            public static implicit operator AsmHexCode(Scas src) => src.Encoded;
        }

        public Scas scas() => default;

        [MethodImpl(Inline), Op]
        public Scas scas(AsmHexCode encoded) => new Scas(encoded);

        public struct Scasb : ITypedInstruction<Scasb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Scasb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SCASB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Scasb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Scasb src) => AsmMnemonics.SCASB;

            public static implicit operator AsmHexCode(Scasb src) => src.Encoded;
        }

        public Scasb scasb() => default;

        [MethodImpl(Inline), Op]
        public Scasb scasb(AsmHexCode encoded) => new Scasb(encoded);

        public struct Scasw : ITypedInstruction<Scasw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Scasw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SCASW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Scasw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Scasw src) => AsmMnemonics.SCASW;

            public static implicit operator AsmHexCode(Scasw src) => src.Encoded;
        }

        public Scasw scasw() => default;

        [MethodImpl(Inline), Op]
        public Scasw scasw(AsmHexCode encoded) => new Scasw(encoded);

        public struct Scasd : ITypedInstruction<Scasd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Scasd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SCASD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Scasd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Scasd src) => AsmMnemonics.SCASD;

            public static implicit operator AsmHexCode(Scasd src) => src.Encoded;
        }

        public Scasd scasd() => default;

        [MethodImpl(Inline), Op]
        public Scasd scasd(AsmHexCode encoded) => new Scasd(encoded);

        public struct Scasq : ITypedInstruction<Scasq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Scasq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SCASQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Scasq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Scasq src) => AsmMnemonics.SCASQ;

            public static implicit operator AsmHexCode(Scasq src) => src.Encoded;
        }

        public Scasq scasq() => default;

        [MethodImpl(Inline), Op]
        public Scasq scasq(AsmHexCode encoded) => new Scasq(encoded);

        public struct Seta : ITypedInstruction<Seta>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Seta(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Seta src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Seta src) => AsmMnemonics.SETA;

            public static implicit operator AsmHexCode(Seta src) => src.Encoded;
        }

        public Seta seta() => default;

        [MethodImpl(Inline), Op]
        public Seta seta(AsmHexCode encoded) => new Seta(encoded);

        public struct Setae : ITypedInstruction<Setae>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setae(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETAE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setae src) => AsmMnemonics.SETAE;

            public static implicit operator AsmHexCode(Setae src) => src.Encoded;
        }

        public Setae setae() => default;

        [MethodImpl(Inline), Op]
        public Setae setae(AsmHexCode encoded) => new Setae(encoded);

        public struct Setb : ITypedInstruction<Setb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setb src) => AsmMnemonics.SETB;

            public static implicit operator AsmHexCode(Setb src) => src.Encoded;
        }

        public Setb setb() => default;

        [MethodImpl(Inline), Op]
        public Setb setb(AsmHexCode encoded) => new Setb(encoded);

        public struct Setbe : ITypedInstruction<Setbe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setbe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETBE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setbe src) => AsmMnemonics.SETBE;

            public static implicit operator AsmHexCode(Setbe src) => src.Encoded;
        }

        public Setbe setbe() => default;

        [MethodImpl(Inline), Op]
        public Setbe setbe(AsmHexCode encoded) => new Setbe(encoded);

        public struct Setc : ITypedInstruction<Setc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setc src) => AsmMnemonics.SETC;

            public static implicit operator AsmHexCode(Setc src) => src.Encoded;
        }

        public Setc setc() => default;

        [MethodImpl(Inline), Op]
        public Setc setc(AsmHexCode encoded) => new Setc(encoded);

        public struct Sete : ITypedInstruction<Sete>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sete(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sete src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sete src) => AsmMnemonics.SETE;

            public static implicit operator AsmHexCode(Sete src) => src.Encoded;
        }

        public Sete sete() => default;

        [MethodImpl(Inline), Op]
        public Sete sete(AsmHexCode encoded) => new Sete(encoded);

        public struct Setg : ITypedInstruction<Setg>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setg(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETG;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setg src) => AsmMnemonics.SETG;

            public static implicit operator AsmHexCode(Setg src) => src.Encoded;
        }

        public Setg setg() => default;

        [MethodImpl(Inline), Op]
        public Setg setg(AsmHexCode encoded) => new Setg(encoded);

        public struct Setge : ITypedInstruction<Setge>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setge(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETGE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setge src) => AsmMnemonics.SETGE;

            public static implicit operator AsmHexCode(Setge src) => src.Encoded;
        }

        public Setge setge() => default;

        [MethodImpl(Inline), Op]
        public Setge setge(AsmHexCode encoded) => new Setge(encoded);

        public struct Setl : ITypedInstruction<Setl>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setl(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setl src) => AsmMnemonics.SETL;

            public static implicit operator AsmHexCode(Setl src) => src.Encoded;
        }

        public Setl setl() => default;

        [MethodImpl(Inline), Op]
        public Setl setl(AsmHexCode encoded) => new Setl(encoded);

        public struct Setle : ITypedInstruction<Setle>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setle(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETLE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setle src) => AsmMnemonics.SETLE;

            public static implicit operator AsmHexCode(Setle src) => src.Encoded;
        }

        public Setle setle() => default;

        [MethodImpl(Inline), Op]
        public Setle setle(AsmHexCode encoded) => new Setle(encoded);

        public struct Setna : ITypedInstruction<Setna>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setna(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNA;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setna src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setna src) => AsmMnemonics.SETNA;

            public static implicit operator AsmHexCode(Setna src) => src.Encoded;
        }

        public Setna setna() => default;

        [MethodImpl(Inline), Op]
        public Setna setna(AsmHexCode encoded) => new Setna(encoded);

        public struct Setnae : ITypedInstruction<Setnae>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setnae(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNAE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setnae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnae src) => AsmMnemonics.SETNAE;

            public static implicit operator AsmHexCode(Setnae src) => src.Encoded;
        }

        public Setnae setnae() => default;

        [MethodImpl(Inline), Op]
        public Setnae setnae(AsmHexCode encoded) => new Setnae(encoded);

        public struct Setnb : ITypedInstruction<Setnb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setnb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setnb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnb src) => AsmMnemonics.SETNB;

            public static implicit operator AsmHexCode(Setnb src) => src.Encoded;
        }

        public Setnb setnb() => default;

        [MethodImpl(Inline), Op]
        public Setnb setnb(AsmHexCode encoded) => new Setnb(encoded);

        public struct Setnbe : ITypedInstruction<Setnbe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setnbe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNBE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setnbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnbe src) => AsmMnemonics.SETNBE;

            public static implicit operator AsmHexCode(Setnbe src) => src.Encoded;
        }

        public Setnbe setnbe() => default;

        [MethodImpl(Inline), Op]
        public Setnbe setnbe(AsmHexCode encoded) => new Setnbe(encoded);

        public struct Setnc : ITypedInstruction<Setnc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setnc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setnc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnc src) => AsmMnemonics.SETNC;

            public static implicit operator AsmHexCode(Setnc src) => src.Encoded;
        }

        public Setnc setnc() => default;

        [MethodImpl(Inline), Op]
        public Setnc setnc(AsmHexCode encoded) => new Setnc(encoded);

        public struct Setne : ITypedInstruction<Setne>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setne(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setne src) => AsmMnemonics.SETNE;

            public static implicit operator AsmHexCode(Setne src) => src.Encoded;
        }

        public Setne setne() => default;

        [MethodImpl(Inline), Op]
        public Setne setne(AsmHexCode encoded) => new Setne(encoded);

        public struct Setng : ITypedInstruction<Setng>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setng(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNG;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setng src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setng src) => AsmMnemonics.SETNG;

            public static implicit operator AsmHexCode(Setng src) => src.Encoded;
        }

        public Setng setng() => default;

        [MethodImpl(Inline), Op]
        public Setng setng(AsmHexCode encoded) => new Setng(encoded);

        public struct Setnge : ITypedInstruction<Setnge>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setnge(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNGE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setnge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnge src) => AsmMnemonics.SETNGE;

            public static implicit operator AsmHexCode(Setnge src) => src.Encoded;
        }

        public Setnge setnge() => default;

        [MethodImpl(Inline), Op]
        public Setnge setnge(AsmHexCode encoded) => new Setnge(encoded);

        public struct Setnl : ITypedInstruction<Setnl>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setnl(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setnl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnl src) => AsmMnemonics.SETNL;

            public static implicit operator AsmHexCode(Setnl src) => src.Encoded;
        }

        public Setnl setnl() => default;

        [MethodImpl(Inline), Op]
        public Setnl setnl(AsmHexCode encoded) => new Setnl(encoded);

        public struct Setnle : ITypedInstruction<Setnle>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setnle(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNLE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setnle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnle src) => AsmMnemonics.SETNLE;

            public static implicit operator AsmHexCode(Setnle src) => src.Encoded;
        }

        public Setnle setnle() => default;

        [MethodImpl(Inline), Op]
        public Setnle setnle(AsmHexCode encoded) => new Setnle(encoded);

        public struct Setno : ITypedInstruction<Setno>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setno(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNO;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setno src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setno src) => AsmMnemonics.SETNO;

            public static implicit operator AsmHexCode(Setno src) => src.Encoded;
        }

        public Setno setno() => default;

        [MethodImpl(Inline), Op]
        public Setno setno(AsmHexCode encoded) => new Setno(encoded);

        public struct Setnp : ITypedInstruction<Setnp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setnp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setnp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnp src) => AsmMnemonics.SETNP;

            public static implicit operator AsmHexCode(Setnp src) => src.Encoded;
        }

        public Setnp setnp() => default;

        [MethodImpl(Inline), Op]
        public Setnp setnp(AsmHexCode encoded) => new Setnp(encoded);

        public struct Setns : ITypedInstruction<Setns>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setns(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setns src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setns src) => AsmMnemonics.SETNS;

            public static implicit operator AsmHexCode(Setns src) => src.Encoded;
        }

        public Setns setns() => default;

        [MethodImpl(Inline), Op]
        public Setns setns(AsmHexCode encoded) => new Setns(encoded);

        public struct Setnz : ITypedInstruction<Setnz>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setnz(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNZ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setnz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnz src) => AsmMnemonics.SETNZ;

            public static implicit operator AsmHexCode(Setnz src) => src.Encoded;
        }

        public Setnz setnz() => default;

        [MethodImpl(Inline), Op]
        public Setnz setnz(AsmHexCode encoded) => new Setnz(encoded);

        public struct Seto : ITypedInstruction<Seto>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Seto(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETO;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Seto src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Seto src) => AsmMnemonics.SETO;

            public static implicit operator AsmHexCode(Seto src) => src.Encoded;
        }

        public Seto seto() => default;

        [MethodImpl(Inline), Op]
        public Seto seto(AsmHexCode encoded) => new Seto(encoded);

        public struct Setp : ITypedInstruction<Setp>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setp(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETP;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setp src) => AsmMnemonics.SETP;

            public static implicit operator AsmHexCode(Setp src) => src.Encoded;
        }

        public Setp setp() => default;

        [MethodImpl(Inline), Op]
        public Setp setp(AsmHexCode encoded) => new Setp(encoded);

        public struct Setpe : ITypedInstruction<Setpe>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setpe(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETPE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setpe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setpe src) => AsmMnemonics.SETPE;

            public static implicit operator AsmHexCode(Setpe src) => src.Encoded;
        }

        public Setpe setpe() => default;

        [MethodImpl(Inline), Op]
        public Setpe setpe(AsmHexCode encoded) => new Setpe(encoded);

        public struct Setpo : ITypedInstruction<Setpo>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setpo(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETPO;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setpo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setpo src) => AsmMnemonics.SETPO;

            public static implicit operator AsmHexCode(Setpo src) => src.Encoded;
        }

        public Setpo setpo() => default;

        [MethodImpl(Inline), Op]
        public Setpo setpo(AsmHexCode encoded) => new Setpo(encoded);

        public struct Sets : ITypedInstruction<Sets>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sets(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sets src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sets src) => AsmMnemonics.SETS;

            public static implicit operator AsmHexCode(Sets src) => src.Encoded;
        }

        public Sets sets() => default;

        [MethodImpl(Inline), Op]
        public Sets sets(AsmHexCode encoded) => new Sets(encoded);

        public struct Setz : ITypedInstruction<Setz>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Setz(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETZ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Setz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setz src) => AsmMnemonics.SETZ;

            public static implicit operator AsmHexCode(Setz src) => src.Encoded;
        }

        public Setz setz() => default;

        [MethodImpl(Inline), Op]
        public Setz setz(AsmHexCode encoded) => new Setz(encoded);

        public struct Sfence : ITypedInstruction<Sfence>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sfence(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SFENCE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sfence src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sfence src) => AsmMnemonics.SFENCE;

            public static implicit operator AsmHexCode(Sfence src) => src.Encoded;
        }

        public Sfence sfence() => default;

        [MethodImpl(Inline), Op]
        public Sfence sfence(AsmHexCode encoded) => new Sfence(encoded);

        public struct Sgdt : ITypedInstruction<Sgdt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sgdt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SGDT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sgdt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sgdt src) => AsmMnemonics.SGDT;

            public static implicit operator AsmHexCode(Sgdt src) => src.Encoded;
        }

        public Sgdt sgdt() => default;

        [MethodImpl(Inline), Op]
        public Sgdt sgdt(AsmHexCode encoded) => new Sgdt(encoded);

        public struct Shld : ITypedInstruction<Shld>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Shld(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHLD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Shld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shld src) => AsmMnemonics.SHLD;

            public static implicit operator AsmHexCode(Shld src) => src.Encoded;
        }

        public Shld shld() => default;

        [MethodImpl(Inline), Op]
        public Shld shld(AsmHexCode encoded) => new Shld(encoded);

        public struct Shrd : ITypedInstruction<Shrd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Shrd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHRD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Shrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shrd src) => AsmMnemonics.SHRD;

            public static implicit operator AsmHexCode(Shrd src) => src.Encoded;
        }

        public Shrd shrd() => default;

        [MethodImpl(Inline), Op]
        public Shrd shrd(AsmHexCode encoded) => new Shrd(encoded);

        public struct Shufpd : ITypedInstruction<Shufpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Shufpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHUFPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Shufpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shufpd src) => AsmMnemonics.SHUFPD;

            public static implicit operator AsmHexCode(Shufpd src) => src.Encoded;
        }

        public Shufpd shufpd() => default;

        [MethodImpl(Inline), Op]
        public Shufpd shufpd(AsmHexCode encoded) => new Shufpd(encoded);

        public struct Vshufpd : ITypedInstruction<Vshufpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vshufpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSHUFPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vshufpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vshufpd src) => AsmMnemonics.VSHUFPD;

            public static implicit operator AsmHexCode(Vshufpd src) => src.Encoded;
        }

        public Vshufpd vshufpd() => default;

        [MethodImpl(Inline), Op]
        public Vshufpd vshufpd(AsmHexCode encoded) => new Vshufpd(encoded);

        public struct Shufps : ITypedInstruction<Shufps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Shufps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHUFPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Shufps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shufps src) => AsmMnemonics.SHUFPS;

            public static implicit operator AsmHexCode(Shufps src) => src.Encoded;
        }

        public Shufps shufps() => default;

        [MethodImpl(Inline), Op]
        public Shufps shufps(AsmHexCode encoded) => new Shufps(encoded);

        public struct Vshufps : ITypedInstruction<Vshufps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vshufps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSHUFPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vshufps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vshufps src) => AsmMnemonics.VSHUFPS;

            public static implicit operator AsmHexCode(Vshufps src) => src.Encoded;
        }

        public Vshufps vshufps() => default;

        [MethodImpl(Inline), Op]
        public Vshufps vshufps(AsmHexCode encoded) => new Vshufps(encoded);

        public struct Sidt : ITypedInstruction<Sidt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sidt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SIDT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sidt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sidt src) => AsmMnemonics.SIDT;

            public static implicit operator AsmHexCode(Sidt src) => src.Encoded;
        }

        public Sidt sidt() => default;

        [MethodImpl(Inline), Op]
        public Sidt sidt(AsmHexCode encoded) => new Sidt(encoded);

        public struct Sldt : ITypedInstruction<Sldt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sldt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SLDT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sldt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sldt src) => AsmMnemonics.SLDT;

            public static implicit operator AsmHexCode(Sldt src) => src.Encoded;
        }

        public Sldt sldt() => default;

        [MethodImpl(Inline), Op]
        public Sldt sldt(AsmHexCode encoded) => new Sldt(encoded);

        public struct Smsw : ITypedInstruction<Smsw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Smsw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SMSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Smsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Smsw src) => AsmMnemonics.SMSW;

            public static implicit operator AsmHexCode(Smsw src) => src.Encoded;
        }

        public Smsw smsw() => default;

        [MethodImpl(Inline), Op]
        public Smsw smsw(AsmHexCode encoded) => new Smsw(encoded);

        public struct Sqrtpd : ITypedInstruction<Sqrtpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sqrtpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sqrtpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sqrtpd src) => AsmMnemonics.SQRTPD;

            public static implicit operator AsmHexCode(Sqrtpd src) => src.Encoded;
        }

        public Sqrtpd sqrtpd() => default;

        [MethodImpl(Inline), Op]
        public Sqrtpd sqrtpd(AsmHexCode encoded) => new Sqrtpd(encoded);

        public struct Vsqrtpd : ITypedInstruction<Vsqrtpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vsqrtpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vsqrtpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsqrtpd src) => AsmMnemonics.VSQRTPD;

            public static implicit operator AsmHexCode(Vsqrtpd src) => src.Encoded;
        }

        public Vsqrtpd vsqrtpd() => default;

        [MethodImpl(Inline), Op]
        public Vsqrtpd vsqrtpd(AsmHexCode encoded) => new Vsqrtpd(encoded);

        public struct Sqrtps : ITypedInstruction<Sqrtps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sqrtps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sqrtps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sqrtps src) => AsmMnemonics.SQRTPS;

            public static implicit operator AsmHexCode(Sqrtps src) => src.Encoded;
        }

        public Sqrtps sqrtps() => default;

        [MethodImpl(Inline), Op]
        public Sqrtps sqrtps(AsmHexCode encoded) => new Sqrtps(encoded);

        public struct Vsqrtps : ITypedInstruction<Vsqrtps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vsqrtps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vsqrtps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsqrtps src) => AsmMnemonics.VSQRTPS;

            public static implicit operator AsmHexCode(Vsqrtps src) => src.Encoded;
        }

        public Vsqrtps vsqrtps() => default;

        [MethodImpl(Inline), Op]
        public Vsqrtps vsqrtps(AsmHexCode encoded) => new Vsqrtps(encoded);

        public struct Sqrtsd : ITypedInstruction<Sqrtsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sqrtsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sqrtsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sqrtsd src) => AsmMnemonics.SQRTSD;

            public static implicit operator AsmHexCode(Sqrtsd src) => src.Encoded;
        }

        public Sqrtsd sqrtsd() => default;

        [MethodImpl(Inline), Op]
        public Sqrtsd sqrtsd(AsmHexCode encoded) => new Sqrtsd(encoded);

        public struct Vsqrtsd : ITypedInstruction<Vsqrtsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vsqrtsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vsqrtsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsqrtsd src) => AsmMnemonics.VSQRTSD;

            public static implicit operator AsmHexCode(Vsqrtsd src) => src.Encoded;
        }

        public Vsqrtsd vsqrtsd() => default;

        [MethodImpl(Inline), Op]
        public Vsqrtsd vsqrtsd(AsmHexCode encoded) => new Vsqrtsd(encoded);

        public struct Sqrtss : ITypedInstruction<Sqrtss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sqrtss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sqrtss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sqrtss src) => AsmMnemonics.SQRTSS;

            public static implicit operator AsmHexCode(Sqrtss src) => src.Encoded;
        }

        public Sqrtss sqrtss() => default;

        [MethodImpl(Inline), Op]
        public Sqrtss sqrtss(AsmHexCode encoded) => new Sqrtss(encoded);

        public struct Vsqrtss : ITypedInstruction<Vsqrtss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vsqrtss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vsqrtss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsqrtss src) => AsmMnemonics.VSQRTSS;

            public static implicit operator AsmHexCode(Vsqrtss src) => src.Encoded;
        }

        public Vsqrtss vsqrtss() => default;

        [MethodImpl(Inline), Op]
        public Vsqrtss vsqrtss(AsmHexCode encoded) => new Vsqrtss(encoded);

        public struct Stc : ITypedInstruction<Stc>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Stc(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STC;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Stc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stc src) => AsmMnemonics.STC;

            public static implicit operator AsmHexCode(Stc src) => src.Encoded;
        }

        public Stc stc() => default;

        [MethodImpl(Inline), Op]
        public Stc stc(AsmHexCode encoded) => new Stc(encoded);

        public struct Std : ITypedInstruction<Std>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Std(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Std src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Std src) => AsmMnemonics.STD;

            public static implicit operator AsmHexCode(Std src) => src.Encoded;
        }

        public Std std() => default;

        [MethodImpl(Inline), Op]
        public Std std(AsmHexCode encoded) => new Std(encoded);

        public struct Sti : ITypedInstruction<Sti>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sti(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STI;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sti src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sti src) => AsmMnemonics.STI;

            public static implicit operator AsmHexCode(Sti src) => src.Encoded;
        }

        public Sti sti() => default;

        [MethodImpl(Inline), Op]
        public Sti sti(AsmHexCode encoded) => new Sti(encoded);

        public struct Stmxcsr : ITypedInstruction<Stmxcsr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Stmxcsr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STMXCSR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Stmxcsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stmxcsr src) => AsmMnemonics.STMXCSR;

            public static implicit operator AsmHexCode(Stmxcsr src) => src.Encoded;
        }

        public Stmxcsr stmxcsr() => default;

        [MethodImpl(Inline), Op]
        public Stmxcsr stmxcsr(AsmHexCode encoded) => new Stmxcsr(encoded);

        public struct Vstmxcsr : ITypedInstruction<Vstmxcsr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vstmxcsr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSTMXCSR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vstmxcsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vstmxcsr src) => AsmMnemonics.VSTMXCSR;

            public static implicit operator AsmHexCode(Vstmxcsr src) => src.Encoded;
        }

        public Vstmxcsr vstmxcsr() => default;

        [MethodImpl(Inline), Op]
        public Vstmxcsr vstmxcsr(AsmHexCode encoded) => new Vstmxcsr(encoded);

        public struct Stos : ITypedInstruction<Stos>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Stos(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STOS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Stos src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stos src) => AsmMnemonics.STOS;

            public static implicit operator AsmHexCode(Stos src) => src.Encoded;
        }

        public Stos stos() => default;

        [MethodImpl(Inline), Op]
        public Stos stos(AsmHexCode encoded) => new Stos(encoded);

        public struct Stosb : ITypedInstruction<Stosb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Stosb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STOSB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Stosb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stosb src) => AsmMnemonics.STOSB;

            public static implicit operator AsmHexCode(Stosb src) => src.Encoded;
        }

        public Stosb stosb() => default;

        [MethodImpl(Inline), Op]
        public Stosb stosb(AsmHexCode encoded) => new Stosb(encoded);

        public struct Stosw : ITypedInstruction<Stosw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Stosw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STOSW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Stosw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stosw src) => AsmMnemonics.STOSW;

            public static implicit operator AsmHexCode(Stosw src) => src.Encoded;
        }

        public Stosw stosw() => default;

        [MethodImpl(Inline), Op]
        public Stosw stosw(AsmHexCode encoded) => new Stosw(encoded);

        public struct Stosd : ITypedInstruction<Stosd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Stosd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STOSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Stosd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stosd src) => AsmMnemonics.STOSD;

            public static implicit operator AsmHexCode(Stosd src) => src.Encoded;
        }

        public Stosd stosd() => default;

        [MethodImpl(Inline), Op]
        public Stosd stosd(AsmHexCode encoded) => new Stosd(encoded);

        public struct Stosq : ITypedInstruction<Stosq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Stosq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STOSQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Stosq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stosq src) => AsmMnemonics.STOSQ;

            public static implicit operator AsmHexCode(Stosq src) => src.Encoded;
        }

        public Stosq stosq() => default;

        [MethodImpl(Inline), Op]
        public Stosq stosq(AsmHexCode encoded) => new Stosq(encoded);

        public struct Str : ITypedInstruction<Str>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Str(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Str src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Str src) => AsmMnemonics.STR;

            public static implicit operator AsmHexCode(Str src) => src.Encoded;
        }

        public Str str() => default;

        [MethodImpl(Inline), Op]
        public Str str(AsmHexCode encoded) => new Str(encoded);

        public struct Sub : ITypedInstruction<Sub>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sub(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sub src) => AsmMnemonics.SUB;

            public static implicit operator AsmHexCode(Sub src) => src.Encoded;
        }

        public Sub sub() => default;

        [MethodImpl(Inline), Op]
        public Sub sub(AsmHexCode encoded) => new Sub(encoded);

        public struct Subpd : ITypedInstruction<Subpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Subpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Subpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Subpd src) => AsmMnemonics.SUBPD;

            public static implicit operator AsmHexCode(Subpd src) => src.Encoded;
        }

        public Subpd subpd() => default;

        [MethodImpl(Inline), Op]
        public Subpd subpd(AsmHexCode encoded) => new Subpd(encoded);

        public struct Vsubpd : ITypedInstruction<Vsubpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vsubpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsubpd src) => AsmMnemonics.VSUBPD;

            public static implicit operator AsmHexCode(Vsubpd src) => src.Encoded;
        }

        public Vsubpd vsubpd() => default;

        [MethodImpl(Inline), Op]
        public Vsubpd vsubpd(AsmHexCode encoded) => new Vsubpd(encoded);

        public struct Subps : ITypedInstruction<Subps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Subps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Subps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Subps src) => AsmMnemonics.SUBPS;

            public static implicit operator AsmHexCode(Subps src) => src.Encoded;
        }

        public Subps subps() => default;

        [MethodImpl(Inline), Op]
        public Subps subps(AsmHexCode encoded) => new Subps(encoded);

        public struct Vsubps : ITypedInstruction<Vsubps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vsubps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsubps src) => AsmMnemonics.VSUBPS;

            public static implicit operator AsmHexCode(Vsubps src) => src.Encoded;
        }

        public Vsubps vsubps() => default;

        [MethodImpl(Inline), Op]
        public Vsubps vsubps(AsmHexCode encoded) => new Vsubps(encoded);

        public struct Subsd : ITypedInstruction<Subsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Subsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Subsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Subsd src) => AsmMnemonics.SUBSD;

            public static implicit operator AsmHexCode(Subsd src) => src.Encoded;
        }

        public Subsd subsd() => default;

        [MethodImpl(Inline), Op]
        public Subsd subsd(AsmHexCode encoded) => new Subsd(encoded);

        public struct Vsubsd : ITypedInstruction<Vsubsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vsubsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vsubsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsubsd src) => AsmMnemonics.VSUBSD;

            public static implicit operator AsmHexCode(Vsubsd src) => src.Encoded;
        }

        public Vsubsd vsubsd() => default;

        [MethodImpl(Inline), Op]
        public Vsubsd vsubsd(AsmHexCode encoded) => new Vsubsd(encoded);

        public struct Subss : ITypedInstruction<Subss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Subss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Subss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Subss src) => AsmMnemonics.SUBSS;

            public static implicit operator AsmHexCode(Subss src) => src.Encoded;
        }

        public Subss subss() => default;

        [MethodImpl(Inline), Op]
        public Subss subss(AsmHexCode encoded) => new Subss(encoded);

        public struct Vsubss : ITypedInstruction<Vsubss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vsubss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vsubss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsubss src) => AsmMnemonics.VSUBSS;

            public static implicit operator AsmHexCode(Vsubss src) => src.Encoded;
        }

        public Vsubss vsubss() => default;

        [MethodImpl(Inline), Op]
        public Vsubss vsubss(AsmHexCode encoded) => new Vsubss(encoded);

        public struct Swapgs : ITypedInstruction<Swapgs>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Swapgs(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SWAPGS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Swapgs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Swapgs src) => AsmMnemonics.SWAPGS;

            public static implicit operator AsmHexCode(Swapgs src) => src.Encoded;
        }

        public Swapgs swapgs() => default;

        [MethodImpl(Inline), Op]
        public Swapgs swapgs(AsmHexCode encoded) => new Swapgs(encoded);

        public struct Syscall : ITypedInstruction<Syscall>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Syscall(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SYSCALL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Syscall src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Syscall src) => AsmMnemonics.SYSCALL;

            public static implicit operator AsmHexCode(Syscall src) => src.Encoded;
        }

        public Syscall syscall() => default;

        [MethodImpl(Inline), Op]
        public Syscall syscall(AsmHexCode encoded) => new Syscall(encoded);

        public struct Sysenter : ITypedInstruction<Sysenter>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sysenter(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SYSENTER;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sysenter src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sysenter src) => AsmMnemonics.SYSENTER;

            public static implicit operator AsmHexCode(Sysenter src) => src.Encoded;
        }

        public Sysenter sysenter() => default;

        [MethodImpl(Inline), Op]
        public Sysenter sysenter(AsmHexCode encoded) => new Sysenter(encoded);

        public struct Sysexit : ITypedInstruction<Sysexit>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sysexit(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SYSEXIT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sysexit src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sysexit src) => AsmMnemonics.SYSEXIT;

            public static implicit operator AsmHexCode(Sysexit src) => src.Encoded;
        }

        public Sysexit sysexit() => default;

        [MethodImpl(Inline), Op]
        public Sysexit sysexit(AsmHexCode encoded) => new Sysexit(encoded);

        public struct Sysret : ITypedInstruction<Sysret>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Sysret(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SYSRET;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Sysret src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sysret src) => AsmMnemonics.SYSRET;

            public static implicit operator AsmHexCode(Sysret src) => src.Encoded;
        }

        public Sysret sysret() => default;

        [MethodImpl(Inline), Op]
        public Sysret sysret(AsmHexCode encoded) => new Sysret(encoded);

        public struct Test : ITypedInstruction<Test>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Test(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.TEST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Test src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Test src) => AsmMnemonics.TEST;

            public static implicit operator AsmHexCode(Test src) => src.Encoded;
        }

        public Test test() => default;

        [MethodImpl(Inline), Op]
        public Test test(AsmHexCode encoded) => new Test(encoded);

        public struct Tzcnt : ITypedInstruction<Tzcnt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Tzcnt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.TZCNT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Tzcnt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Tzcnt src) => AsmMnemonics.TZCNT;

            public static implicit operator AsmHexCode(Tzcnt src) => src.Encoded;
        }

        public Tzcnt tzcnt() => default;

        [MethodImpl(Inline), Op]
        public Tzcnt tzcnt(AsmHexCode encoded) => new Tzcnt(encoded);

        public struct Ucomisd : ITypedInstruction<Ucomisd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ucomisd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UCOMISD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ucomisd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ucomisd src) => AsmMnemonics.UCOMISD;

            public static implicit operator AsmHexCode(Ucomisd src) => src.Encoded;
        }

        public Ucomisd ucomisd() => default;

        [MethodImpl(Inline), Op]
        public Ucomisd ucomisd(AsmHexCode encoded) => new Ucomisd(encoded);

        public struct Vucomisd : ITypedInstruction<Vucomisd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vucomisd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUCOMISD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vucomisd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vucomisd src) => AsmMnemonics.VUCOMISD;

            public static implicit operator AsmHexCode(Vucomisd src) => src.Encoded;
        }

        public Vucomisd vucomisd() => default;

        [MethodImpl(Inline), Op]
        public Vucomisd vucomisd(AsmHexCode encoded) => new Vucomisd(encoded);

        public struct Ucomiss : ITypedInstruction<Ucomiss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ucomiss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UCOMISS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ucomiss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ucomiss src) => AsmMnemonics.UCOMISS;

            public static implicit operator AsmHexCode(Ucomiss src) => src.Encoded;
        }

        public Ucomiss ucomiss() => default;

        [MethodImpl(Inline), Op]
        public Ucomiss ucomiss(AsmHexCode encoded) => new Ucomiss(encoded);

        public struct Vucomiss : ITypedInstruction<Vucomiss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vucomiss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUCOMISS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vucomiss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vucomiss src) => AsmMnemonics.VUCOMISS;

            public static implicit operator AsmHexCode(Vucomiss src) => src.Encoded;
        }

        public Vucomiss vucomiss() => default;

        [MethodImpl(Inline), Op]
        public Vucomiss vucomiss(AsmHexCode encoded) => new Vucomiss(encoded);

        public struct Ud2 : ITypedInstruction<Ud2>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Ud2(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UD2;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Ud2 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ud2 src) => AsmMnemonics.UD2;

            public static implicit operator AsmHexCode(Ud2 src) => src.Encoded;
        }

        public Ud2 ud2() => default;

        [MethodImpl(Inline), Op]
        public Ud2 ud2(AsmHexCode encoded) => new Ud2(encoded);

        public struct Unpckhpd : ITypedInstruction<Unpckhpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Unpckhpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKHPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Unpckhpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Unpckhpd src) => AsmMnemonics.UNPCKHPD;

            public static implicit operator AsmHexCode(Unpckhpd src) => src.Encoded;
        }

        public Unpckhpd unpckhpd() => default;

        [MethodImpl(Inline), Op]
        public Unpckhpd unpckhpd(AsmHexCode encoded) => new Unpckhpd(encoded);

        public struct Vunpckhpd : ITypedInstruction<Vunpckhpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vunpckhpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKHPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vunpckhpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vunpckhpd src) => AsmMnemonics.VUNPCKHPD;

            public static implicit operator AsmHexCode(Vunpckhpd src) => src.Encoded;
        }

        public Vunpckhpd vunpckhpd() => default;

        [MethodImpl(Inline), Op]
        public Vunpckhpd vunpckhpd(AsmHexCode encoded) => new Vunpckhpd(encoded);

        public struct Unpckhps : ITypedInstruction<Unpckhps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Unpckhps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKHPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Unpckhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Unpckhps src) => AsmMnemonics.UNPCKHPS;

            public static implicit operator AsmHexCode(Unpckhps src) => src.Encoded;
        }

        public Unpckhps unpckhps() => default;

        [MethodImpl(Inline), Op]
        public Unpckhps unpckhps(AsmHexCode encoded) => new Unpckhps(encoded);

        public struct Vunpckhps : ITypedInstruction<Vunpckhps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vunpckhps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKHPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vunpckhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vunpckhps src) => AsmMnemonics.VUNPCKHPS;

            public static implicit operator AsmHexCode(Vunpckhps src) => src.Encoded;
        }

        public Vunpckhps vunpckhps() => default;

        [MethodImpl(Inline), Op]
        public Vunpckhps vunpckhps(AsmHexCode encoded) => new Vunpckhps(encoded);

        public struct Unpcklpd : ITypedInstruction<Unpcklpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Unpcklpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKLPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Unpcklpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Unpcklpd src) => AsmMnemonics.UNPCKLPD;

            public static implicit operator AsmHexCode(Unpcklpd src) => src.Encoded;
        }

        public Unpcklpd unpcklpd() => default;

        [MethodImpl(Inline), Op]
        public Unpcklpd unpcklpd(AsmHexCode encoded) => new Unpcklpd(encoded);

        public struct Vunpcklpd : ITypedInstruction<Vunpcklpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vunpcklpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKLPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vunpcklpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vunpcklpd src) => AsmMnemonics.VUNPCKLPD;

            public static implicit operator AsmHexCode(Vunpcklpd src) => src.Encoded;
        }

        public Vunpcklpd vunpcklpd() => default;

        [MethodImpl(Inline), Op]
        public Vunpcklpd vunpcklpd(AsmHexCode encoded) => new Vunpcklpd(encoded);

        public struct Unpcklps : ITypedInstruction<Unpcklps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Unpcklps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKLPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Unpcklps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Unpcklps src) => AsmMnemonics.UNPCKLPS;

            public static implicit operator AsmHexCode(Unpcklps src) => src.Encoded;
        }

        public Unpcklps unpcklps() => default;

        [MethodImpl(Inline), Op]
        public Unpcklps unpcklps(AsmHexCode encoded) => new Unpcklps(encoded);

        public struct Vunpcklps : ITypedInstruction<Vunpcklps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vunpcklps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKLPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vunpcklps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vunpcklps src) => AsmMnemonics.VUNPCKLPS;

            public static implicit operator AsmHexCode(Vunpcklps src) => src.Encoded;
        }

        public Vunpcklps vunpcklps() => default;

        [MethodImpl(Inline), Op]
        public Vunpcklps vunpcklps(AsmHexCode encoded) => new Vunpcklps(encoded);

        public struct Vbroadcastss : ITypedInstruction<Vbroadcastss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vbroadcastss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTSS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vbroadcastss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vbroadcastss src) => AsmMnemonics.VBROADCASTSS;

            public static implicit operator AsmHexCode(Vbroadcastss src) => src.Encoded;
        }

        public Vbroadcastss vbroadcastss() => default;

        [MethodImpl(Inline), Op]
        public Vbroadcastss vbroadcastss(AsmHexCode encoded) => new Vbroadcastss(encoded);

        public struct Vbroadcastsd : ITypedInstruction<Vbroadcastsd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vbroadcastsd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTSD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vbroadcastsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vbroadcastsd src) => AsmMnemonics.VBROADCASTSD;

            public static implicit operator AsmHexCode(Vbroadcastsd src) => src.Encoded;
        }

        public Vbroadcastsd vbroadcastsd() => default;

        [MethodImpl(Inline), Op]
        public Vbroadcastsd vbroadcastsd(AsmHexCode encoded) => new Vbroadcastsd(encoded);

        public struct Vbroadcastf128 : ITypedInstruction<Vbroadcastf128>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vbroadcastf128(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTF128;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vbroadcastf128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vbroadcastf128 src) => AsmMnemonics.VBROADCASTF128;

            public static implicit operator AsmHexCode(Vbroadcastf128 src) => src.Encoded;
        }

        public Vbroadcastf128 vbroadcastf128() => default;

        [MethodImpl(Inline), Op]
        public Vbroadcastf128 vbroadcastf128(AsmHexCode encoded) => new Vbroadcastf128(encoded);

        public struct Vcvtph2ps : ITypedInstruction<Vcvtph2ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtph2ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPH2PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtph2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtph2ps src) => AsmMnemonics.VCVTPH2PS;

            public static implicit operator AsmHexCode(Vcvtph2ps src) => src.Encoded;
        }

        public Vcvtph2ps vcvtph2ps() => default;

        [MethodImpl(Inline), Op]
        public Vcvtph2ps vcvtph2ps(AsmHexCode encoded) => new Vcvtph2ps(encoded);

        public struct Vcvtps2ph : ITypedInstruction<Vcvtps2ph>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vcvtps2ph(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPS2PH;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vcvtps2ph src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtps2ph src) => AsmMnemonics.VCVTPS2PH;

            public static implicit operator AsmHexCode(Vcvtps2ph src) => src.Encoded;
        }

        public Vcvtps2ph vcvtps2ph() => default;

        [MethodImpl(Inline), Op]
        public Vcvtps2ph vcvtps2ph(AsmHexCode encoded) => new Vcvtps2ph(encoded);

        public struct Verr : ITypedInstruction<Verr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Verr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VERR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Verr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Verr src) => AsmMnemonics.VERR;

            public static implicit operator AsmHexCode(Verr src) => src.Encoded;
        }

        public Verr verr() => default;

        [MethodImpl(Inline), Op]
        public Verr verr(AsmHexCode encoded) => new Verr(encoded);

        public struct Verw : ITypedInstruction<Verw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Verw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VERW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Verw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Verw src) => AsmMnemonics.VERW;

            public static implicit operator AsmHexCode(Verw src) => src.Encoded;
        }

        public Verw verw() => default;

        [MethodImpl(Inline), Op]
        public Verw verw(AsmHexCode encoded) => new Verw(encoded);

        public struct Vextractf128 : ITypedInstruction<Vextractf128>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vextractf128(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VEXTRACTF128;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vextractf128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vextractf128 src) => AsmMnemonics.VEXTRACTF128;

            public static implicit operator AsmHexCode(Vextractf128 src) => src.Encoded;
        }

        public Vextractf128 vextractf128() => default;

        [MethodImpl(Inline), Op]
        public Vextractf128 vextractf128(AsmHexCode encoded) => new Vextractf128(encoded);

        public struct Vextracti128 : ITypedInstruction<Vextracti128>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vextracti128(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VEXTRACTI128;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vextracti128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vextracti128 src) => AsmMnemonics.VEXTRACTI128;

            public static implicit operator AsmHexCode(Vextracti128 src) => src.Encoded;
        }

        public Vextracti128 vextracti128() => default;

        [MethodImpl(Inline), Op]
        public Vextracti128 vextracti128(AsmHexCode encoded) => new Vextracti128(encoded);

        public struct Vfmadd132pd : ITypedInstruction<Vfmadd132pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmadd132pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmadd132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd132pd src) => AsmMnemonics.VFMADD132PD;

            public static implicit operator AsmHexCode(Vfmadd132pd src) => src.Encoded;
        }

        public Vfmadd132pd vfmadd132pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd132pd vfmadd132pd(AsmHexCode encoded) => new Vfmadd132pd(encoded);

        public struct Vfmadd213pd : ITypedInstruction<Vfmadd213pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmadd213pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmadd213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd213pd src) => AsmMnemonics.VFMADD213PD;

            public static implicit operator AsmHexCode(Vfmadd213pd src) => src.Encoded;
        }

        public Vfmadd213pd vfmadd213pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd213pd vfmadd213pd(AsmHexCode encoded) => new Vfmadd213pd(encoded);

        public struct Vfmadd231pd : ITypedInstruction<Vfmadd231pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmadd231pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmadd231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd231pd src) => AsmMnemonics.VFMADD231PD;

            public static implicit operator AsmHexCode(Vfmadd231pd src) => src.Encoded;
        }

        public Vfmadd231pd vfmadd231pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd231pd vfmadd231pd(AsmHexCode encoded) => new Vfmadd231pd(encoded);

        public struct Vfmadd132ps : ITypedInstruction<Vfmadd132ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmadd132ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmadd132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd132ps src) => AsmMnemonics.VFMADD132PS;

            public static implicit operator AsmHexCode(Vfmadd132ps src) => src.Encoded;
        }

        public Vfmadd132ps vfmadd132ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd132ps vfmadd132ps(AsmHexCode encoded) => new Vfmadd132ps(encoded);

        public struct Vfmadd213ps : ITypedInstruction<Vfmadd213ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmadd213ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmadd213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd213ps src) => AsmMnemonics.VFMADD213PS;

            public static implicit operator AsmHexCode(Vfmadd213ps src) => src.Encoded;
        }

        public Vfmadd213ps vfmadd213ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd213ps vfmadd213ps(AsmHexCode encoded) => new Vfmadd213ps(encoded);

        public struct Vfmadd231ps : ITypedInstruction<Vfmadd231ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmadd231ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmadd231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd231ps src) => AsmMnemonics.VFMADD231PS;

            public static implicit operator AsmHexCode(Vfmadd231ps src) => src.Encoded;
        }

        public Vfmadd231ps vfmadd231ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd231ps vfmadd231ps(AsmHexCode encoded) => new Vfmadd231ps(encoded);

        public struct Vfmadd132sd : ITypedInstruction<Vfmadd132sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmadd132sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmadd132sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd132sd src) => AsmMnemonics.VFMADD132SD;

            public static implicit operator AsmHexCode(Vfmadd132sd src) => src.Encoded;
        }

        public Vfmadd132sd vfmadd132sd() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd132sd vfmadd132sd(AsmHexCode encoded) => new Vfmadd132sd(encoded);

        public struct Vfmadd213sd : ITypedInstruction<Vfmadd213sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmadd213sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmadd213sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd213sd src) => AsmMnemonics.VFMADD213SD;

            public static implicit operator AsmHexCode(Vfmadd213sd src) => src.Encoded;
        }

        public Vfmadd213sd vfmadd213sd() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd213sd vfmadd213sd(AsmHexCode encoded) => new Vfmadd213sd(encoded);

        public struct Vfmadd231sd : ITypedInstruction<Vfmadd231sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmadd231sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmadd231sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd231sd src) => AsmMnemonics.VFMADD231SD;

            public static implicit operator AsmHexCode(Vfmadd231sd src) => src.Encoded;
        }

        public Vfmadd231sd vfmadd231sd() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd231sd vfmadd231sd(AsmHexCode encoded) => new Vfmadd231sd(encoded);

        public struct Vfmadd132ss : ITypedInstruction<Vfmadd132ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmadd132ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmadd132ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd132ss src) => AsmMnemonics.VFMADD132SS;

            public static implicit operator AsmHexCode(Vfmadd132ss src) => src.Encoded;
        }

        public Vfmadd132ss vfmadd132ss() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd132ss vfmadd132ss(AsmHexCode encoded) => new Vfmadd132ss(encoded);

        public struct Vfmadd213ss : ITypedInstruction<Vfmadd213ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmadd213ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmadd213ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd213ss src) => AsmMnemonics.VFMADD213SS;

            public static implicit operator AsmHexCode(Vfmadd213ss src) => src.Encoded;
        }

        public Vfmadd213ss vfmadd213ss() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd213ss vfmadd213ss(AsmHexCode encoded) => new Vfmadd213ss(encoded);

        public struct Vfmadd231ss : ITypedInstruction<Vfmadd231ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmadd231ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmadd231ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd231ss src) => AsmMnemonics.VFMADD231SS;

            public static implicit operator AsmHexCode(Vfmadd231ss src) => src.Encoded;
        }

        public Vfmadd231ss vfmadd231ss() => default;

        [MethodImpl(Inline), Op]
        public Vfmadd231ss vfmadd231ss(AsmHexCode encoded) => new Vfmadd231ss(encoded);

        public struct Vfmaddsub132pd : ITypedInstruction<Vfmaddsub132pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmaddsub132pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB132PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmaddsub132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub132pd src) => AsmMnemonics.VFMADDSUB132PD;

            public static implicit operator AsmHexCode(Vfmaddsub132pd src) => src.Encoded;
        }

        public Vfmaddsub132pd vfmaddsub132pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmaddsub132pd vfmaddsub132pd(AsmHexCode encoded) => new Vfmaddsub132pd(encoded);

        public struct Vfmaddsub213pd : ITypedInstruction<Vfmaddsub213pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmaddsub213pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB213PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmaddsub213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub213pd src) => AsmMnemonics.VFMADDSUB213PD;

            public static implicit operator AsmHexCode(Vfmaddsub213pd src) => src.Encoded;
        }

        public Vfmaddsub213pd vfmaddsub213pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmaddsub213pd vfmaddsub213pd(AsmHexCode encoded) => new Vfmaddsub213pd(encoded);

        public struct Vfmaddsub231pd : ITypedInstruction<Vfmaddsub231pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmaddsub231pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB231PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmaddsub231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub231pd src) => AsmMnemonics.VFMADDSUB231PD;

            public static implicit operator AsmHexCode(Vfmaddsub231pd src) => src.Encoded;
        }

        public Vfmaddsub231pd vfmaddsub231pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmaddsub231pd vfmaddsub231pd(AsmHexCode encoded) => new Vfmaddsub231pd(encoded);

        public struct Vfmaddsub132ps : ITypedInstruction<Vfmaddsub132ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmaddsub132ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB132PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmaddsub132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub132ps src) => AsmMnemonics.VFMADDSUB132PS;

            public static implicit operator AsmHexCode(Vfmaddsub132ps src) => src.Encoded;
        }

        public Vfmaddsub132ps vfmaddsub132ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmaddsub132ps vfmaddsub132ps(AsmHexCode encoded) => new Vfmaddsub132ps(encoded);

        public struct Vfmaddsub213ps : ITypedInstruction<Vfmaddsub213ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmaddsub213ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB213PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmaddsub213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub213ps src) => AsmMnemonics.VFMADDSUB213PS;

            public static implicit operator AsmHexCode(Vfmaddsub213ps src) => src.Encoded;
        }

        public Vfmaddsub213ps vfmaddsub213ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmaddsub213ps vfmaddsub213ps(AsmHexCode encoded) => new Vfmaddsub213ps(encoded);

        public struct Vfmaddsub231ps : ITypedInstruction<Vfmaddsub231ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmaddsub231ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB231PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmaddsub231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub231ps src) => AsmMnemonics.VFMADDSUB231PS;

            public static implicit operator AsmHexCode(Vfmaddsub231ps src) => src.Encoded;
        }

        public Vfmaddsub231ps vfmaddsub231ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmaddsub231ps vfmaddsub231ps(AsmHexCode encoded) => new Vfmaddsub231ps(encoded);

        public struct Vfmsubadd132pd : ITypedInstruction<Vfmsubadd132pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsubadd132pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD132PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsubadd132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd132pd src) => AsmMnemonics.VFMSUBADD132PD;

            public static implicit operator AsmHexCode(Vfmsubadd132pd src) => src.Encoded;
        }

        public Vfmsubadd132pd vfmsubadd132pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsubadd132pd vfmsubadd132pd(AsmHexCode encoded) => new Vfmsubadd132pd(encoded);

        public struct Vfmsubadd213pd : ITypedInstruction<Vfmsubadd213pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsubadd213pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD213PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsubadd213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd213pd src) => AsmMnemonics.VFMSUBADD213PD;

            public static implicit operator AsmHexCode(Vfmsubadd213pd src) => src.Encoded;
        }

        public Vfmsubadd213pd vfmsubadd213pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsubadd213pd vfmsubadd213pd(AsmHexCode encoded) => new Vfmsubadd213pd(encoded);

        public struct Vfmsubadd231pd : ITypedInstruction<Vfmsubadd231pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsubadd231pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD231PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsubadd231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd231pd src) => AsmMnemonics.VFMSUBADD231PD;

            public static implicit operator AsmHexCode(Vfmsubadd231pd src) => src.Encoded;
        }

        public Vfmsubadd231pd vfmsubadd231pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsubadd231pd vfmsubadd231pd(AsmHexCode encoded) => new Vfmsubadd231pd(encoded);

        public struct Vfmsubadd132ps : ITypedInstruction<Vfmsubadd132ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsubadd132ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD132PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsubadd132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd132ps src) => AsmMnemonics.VFMSUBADD132PS;

            public static implicit operator AsmHexCode(Vfmsubadd132ps src) => src.Encoded;
        }

        public Vfmsubadd132ps vfmsubadd132ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmsubadd132ps vfmsubadd132ps(AsmHexCode encoded) => new Vfmsubadd132ps(encoded);

        public struct Vfmsubadd213ps : ITypedInstruction<Vfmsubadd213ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsubadd213ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD213PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsubadd213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd213ps src) => AsmMnemonics.VFMSUBADD213PS;

            public static implicit operator AsmHexCode(Vfmsubadd213ps src) => src.Encoded;
        }

        public Vfmsubadd213ps vfmsubadd213ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmsubadd213ps vfmsubadd213ps(AsmHexCode encoded) => new Vfmsubadd213ps(encoded);

        public struct Vfmsubadd231ps : ITypedInstruction<Vfmsubadd231ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsubadd231ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD231PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsubadd231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd231ps src) => AsmMnemonics.VFMSUBADD231PS;

            public static implicit operator AsmHexCode(Vfmsubadd231ps src) => src.Encoded;
        }

        public Vfmsubadd231ps vfmsubadd231ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmsubadd231ps vfmsubadd231ps(AsmHexCode encoded) => new Vfmsubadd231ps(encoded);

        public struct Vfmsub132pd : ITypedInstruction<Vfmsub132pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsub132pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsub132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub132pd src) => AsmMnemonics.VFMSUB132PD;

            public static implicit operator AsmHexCode(Vfmsub132pd src) => src.Encoded;
        }

        public Vfmsub132pd vfmsub132pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub132pd vfmsub132pd(AsmHexCode encoded) => new Vfmsub132pd(encoded);

        public struct Vfmsub213pd : ITypedInstruction<Vfmsub213pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsub213pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsub213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub213pd src) => AsmMnemonics.VFMSUB213PD;

            public static implicit operator AsmHexCode(Vfmsub213pd src) => src.Encoded;
        }

        public Vfmsub213pd vfmsub213pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub213pd vfmsub213pd(AsmHexCode encoded) => new Vfmsub213pd(encoded);

        public struct Vfmsub231pd : ITypedInstruction<Vfmsub231pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsub231pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsub231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub231pd src) => AsmMnemonics.VFMSUB231PD;

            public static implicit operator AsmHexCode(Vfmsub231pd src) => src.Encoded;
        }

        public Vfmsub231pd vfmsub231pd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub231pd vfmsub231pd(AsmHexCode encoded) => new Vfmsub231pd(encoded);

        public struct Vfmsub132ps : ITypedInstruction<Vfmsub132ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsub132ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsub132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub132ps src) => AsmMnemonics.VFMSUB132PS;

            public static implicit operator AsmHexCode(Vfmsub132ps src) => src.Encoded;
        }

        public Vfmsub132ps vfmsub132ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub132ps vfmsub132ps(AsmHexCode encoded) => new Vfmsub132ps(encoded);

        public struct Vfmsub213ps : ITypedInstruction<Vfmsub213ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsub213ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsub213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub213ps src) => AsmMnemonics.VFMSUB213PS;

            public static implicit operator AsmHexCode(Vfmsub213ps src) => src.Encoded;
        }

        public Vfmsub213ps vfmsub213ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub213ps vfmsub213ps(AsmHexCode encoded) => new Vfmsub213ps(encoded);

        public struct Vfmsub231ps : ITypedInstruction<Vfmsub231ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsub231ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsub231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub231ps src) => AsmMnemonics.VFMSUB231PS;

            public static implicit operator AsmHexCode(Vfmsub231ps src) => src.Encoded;
        }

        public Vfmsub231ps vfmsub231ps() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub231ps vfmsub231ps(AsmHexCode encoded) => new Vfmsub231ps(encoded);

        public struct Vfmsub132sd : ITypedInstruction<Vfmsub132sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsub132sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsub132sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub132sd src) => AsmMnemonics.VFMSUB132SD;

            public static implicit operator AsmHexCode(Vfmsub132sd src) => src.Encoded;
        }

        public Vfmsub132sd vfmsub132sd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub132sd vfmsub132sd(AsmHexCode encoded) => new Vfmsub132sd(encoded);

        public struct Vfmsub213sd : ITypedInstruction<Vfmsub213sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsub213sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsub213sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub213sd src) => AsmMnemonics.VFMSUB213SD;

            public static implicit operator AsmHexCode(Vfmsub213sd src) => src.Encoded;
        }

        public Vfmsub213sd vfmsub213sd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub213sd vfmsub213sd(AsmHexCode encoded) => new Vfmsub213sd(encoded);

        public struct Vfmsub231sd : ITypedInstruction<Vfmsub231sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsub231sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsub231sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub231sd src) => AsmMnemonics.VFMSUB231SD;

            public static implicit operator AsmHexCode(Vfmsub231sd src) => src.Encoded;
        }

        public Vfmsub231sd vfmsub231sd() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub231sd vfmsub231sd(AsmHexCode encoded) => new Vfmsub231sd(encoded);

        public struct Vfmsub132ss : ITypedInstruction<Vfmsub132ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsub132ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsub132ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub132ss src) => AsmMnemonics.VFMSUB132SS;

            public static implicit operator AsmHexCode(Vfmsub132ss src) => src.Encoded;
        }

        public Vfmsub132ss vfmsub132ss() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub132ss vfmsub132ss(AsmHexCode encoded) => new Vfmsub132ss(encoded);

        public struct Vfmsub213ss : ITypedInstruction<Vfmsub213ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsub213ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsub213ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub213ss src) => AsmMnemonics.VFMSUB213SS;

            public static implicit operator AsmHexCode(Vfmsub213ss src) => src.Encoded;
        }

        public Vfmsub213ss vfmsub213ss() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub213ss vfmsub213ss(AsmHexCode encoded) => new Vfmsub213ss(encoded);

        public struct Vfmsub231ss : ITypedInstruction<Vfmsub231ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfmsub231ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfmsub231ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub231ss src) => AsmMnemonics.VFMSUB231SS;

            public static implicit operator AsmHexCode(Vfmsub231ss src) => src.Encoded;
        }

        public Vfmsub231ss vfmsub231ss() => default;

        [MethodImpl(Inline), Op]
        public Vfmsub231ss vfmsub231ss(AsmHexCode encoded) => new Vfmsub231ss(encoded);

        public struct Vfnmadd132pd : ITypedInstruction<Vfnmadd132pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmadd132pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmadd132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd132pd src) => AsmMnemonics.VFNMADD132PD;

            public static implicit operator AsmHexCode(Vfnmadd132pd src) => src.Encoded;
        }

        public Vfnmadd132pd vfnmadd132pd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd132pd vfnmadd132pd(AsmHexCode encoded) => new Vfnmadd132pd(encoded);

        public struct Vfnmadd213pd : ITypedInstruction<Vfnmadd213pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmadd213pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmadd213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd213pd src) => AsmMnemonics.VFNMADD213PD;

            public static implicit operator AsmHexCode(Vfnmadd213pd src) => src.Encoded;
        }

        public Vfnmadd213pd vfnmadd213pd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd213pd vfnmadd213pd(AsmHexCode encoded) => new Vfnmadd213pd(encoded);

        public struct Vfnmadd231pd : ITypedInstruction<Vfnmadd231pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmadd231pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmadd231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd231pd src) => AsmMnemonics.VFNMADD231PD;

            public static implicit operator AsmHexCode(Vfnmadd231pd src) => src.Encoded;
        }

        public Vfnmadd231pd vfnmadd231pd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd231pd vfnmadd231pd(AsmHexCode encoded) => new Vfnmadd231pd(encoded);

        public struct Vfnmadd132ps : ITypedInstruction<Vfnmadd132ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmadd132ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmadd132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd132ps src) => AsmMnemonics.VFNMADD132PS;

            public static implicit operator AsmHexCode(Vfnmadd132ps src) => src.Encoded;
        }

        public Vfnmadd132ps vfnmadd132ps() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd132ps vfnmadd132ps(AsmHexCode encoded) => new Vfnmadd132ps(encoded);

        public struct Vfnmadd213ps : ITypedInstruction<Vfnmadd213ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmadd213ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmadd213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd213ps src) => AsmMnemonics.VFNMADD213PS;

            public static implicit operator AsmHexCode(Vfnmadd213ps src) => src.Encoded;
        }

        public Vfnmadd213ps vfnmadd213ps() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd213ps vfnmadd213ps(AsmHexCode encoded) => new Vfnmadd213ps(encoded);

        public struct Vfnmadd231ps : ITypedInstruction<Vfnmadd231ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmadd231ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmadd231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd231ps src) => AsmMnemonics.VFNMADD231PS;

            public static implicit operator AsmHexCode(Vfnmadd231ps src) => src.Encoded;
        }

        public Vfnmadd231ps vfnmadd231ps() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd231ps vfnmadd231ps(AsmHexCode encoded) => new Vfnmadd231ps(encoded);

        public struct Vfnmadd132sd : ITypedInstruction<Vfnmadd132sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmadd132sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmadd132sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd132sd src) => AsmMnemonics.VFNMADD132SD;

            public static implicit operator AsmHexCode(Vfnmadd132sd src) => src.Encoded;
        }

        public Vfnmadd132sd vfnmadd132sd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd132sd vfnmadd132sd(AsmHexCode encoded) => new Vfnmadd132sd(encoded);

        public struct Vfnmadd213sd : ITypedInstruction<Vfnmadd213sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmadd213sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmadd213sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd213sd src) => AsmMnemonics.VFNMADD213SD;

            public static implicit operator AsmHexCode(Vfnmadd213sd src) => src.Encoded;
        }

        public Vfnmadd213sd vfnmadd213sd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd213sd vfnmadd213sd(AsmHexCode encoded) => new Vfnmadd213sd(encoded);

        public struct Vfnmadd231sd : ITypedInstruction<Vfnmadd231sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmadd231sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmadd231sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd231sd src) => AsmMnemonics.VFNMADD231SD;

            public static implicit operator AsmHexCode(Vfnmadd231sd src) => src.Encoded;
        }

        public Vfnmadd231sd vfnmadd231sd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd231sd vfnmadd231sd(AsmHexCode encoded) => new Vfnmadd231sd(encoded);

        public struct Vfnmadd132ss : ITypedInstruction<Vfnmadd132ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmadd132ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmadd132ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd132ss src) => AsmMnemonics.VFNMADD132SS;

            public static implicit operator AsmHexCode(Vfnmadd132ss src) => src.Encoded;
        }

        public Vfnmadd132ss vfnmadd132ss() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd132ss vfnmadd132ss(AsmHexCode encoded) => new Vfnmadd132ss(encoded);

        public struct Vfnmadd213ss : ITypedInstruction<Vfnmadd213ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmadd213ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmadd213ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd213ss src) => AsmMnemonics.VFNMADD213SS;

            public static implicit operator AsmHexCode(Vfnmadd213ss src) => src.Encoded;
        }

        public Vfnmadd213ss vfnmadd213ss() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd213ss vfnmadd213ss(AsmHexCode encoded) => new Vfnmadd213ss(encoded);

        public struct Vfnmadd231ss : ITypedInstruction<Vfnmadd231ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmadd231ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmadd231ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd231ss src) => AsmMnemonics.VFNMADD231SS;

            public static implicit operator AsmHexCode(Vfnmadd231ss src) => src.Encoded;
        }

        public Vfnmadd231ss vfnmadd231ss() => default;

        [MethodImpl(Inline), Op]
        public Vfnmadd231ss vfnmadd231ss(AsmHexCode encoded) => new Vfnmadd231ss(encoded);

        public struct Vfnmsub132pd : ITypedInstruction<Vfnmsub132pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmsub132pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmsub132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub132pd src) => AsmMnemonics.VFNMSUB132PD;

            public static implicit operator AsmHexCode(Vfnmsub132pd src) => src.Encoded;
        }

        public Vfnmsub132pd vfnmsub132pd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub132pd vfnmsub132pd(AsmHexCode encoded) => new Vfnmsub132pd(encoded);

        public struct Vfnmsub213pd : ITypedInstruction<Vfnmsub213pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmsub213pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmsub213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub213pd src) => AsmMnemonics.VFNMSUB213PD;

            public static implicit operator AsmHexCode(Vfnmsub213pd src) => src.Encoded;
        }

        public Vfnmsub213pd vfnmsub213pd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub213pd vfnmsub213pd(AsmHexCode encoded) => new Vfnmsub213pd(encoded);

        public struct Vfnmsub231pd : ITypedInstruction<Vfnmsub231pd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmsub231pd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231PD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmsub231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub231pd src) => AsmMnemonics.VFNMSUB231PD;

            public static implicit operator AsmHexCode(Vfnmsub231pd src) => src.Encoded;
        }

        public Vfnmsub231pd vfnmsub231pd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub231pd vfnmsub231pd(AsmHexCode encoded) => new Vfnmsub231pd(encoded);

        public struct Vfnmsub132ps : ITypedInstruction<Vfnmsub132ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmsub132ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmsub132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub132ps src) => AsmMnemonics.VFNMSUB132PS;

            public static implicit operator AsmHexCode(Vfnmsub132ps src) => src.Encoded;
        }

        public Vfnmsub132ps vfnmsub132ps() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub132ps vfnmsub132ps(AsmHexCode encoded) => new Vfnmsub132ps(encoded);

        public struct Vfnmsub213ps : ITypedInstruction<Vfnmsub213ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmsub213ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmsub213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub213ps src) => AsmMnemonics.VFNMSUB213PS;

            public static implicit operator AsmHexCode(Vfnmsub213ps src) => src.Encoded;
        }

        public Vfnmsub213ps vfnmsub213ps() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub213ps vfnmsub213ps(AsmHexCode encoded) => new Vfnmsub213ps(encoded);

        public struct Vfnmsub231ps : ITypedInstruction<Vfnmsub231ps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmsub231ps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231PS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmsub231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub231ps src) => AsmMnemonics.VFNMSUB231PS;

            public static implicit operator AsmHexCode(Vfnmsub231ps src) => src.Encoded;
        }

        public Vfnmsub231ps vfnmsub231ps() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub231ps vfnmsub231ps(AsmHexCode encoded) => new Vfnmsub231ps(encoded);

        public struct Vfnmsub132sd : ITypedInstruction<Vfnmsub132sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmsub132sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmsub132sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub132sd src) => AsmMnemonics.VFNMSUB132SD;

            public static implicit operator AsmHexCode(Vfnmsub132sd src) => src.Encoded;
        }

        public Vfnmsub132sd vfnmsub132sd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub132sd vfnmsub132sd(AsmHexCode encoded) => new Vfnmsub132sd(encoded);

        public struct Vfnmsub213sd : ITypedInstruction<Vfnmsub213sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmsub213sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmsub213sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub213sd src) => AsmMnemonics.VFNMSUB213SD;

            public static implicit operator AsmHexCode(Vfnmsub213sd src) => src.Encoded;
        }

        public Vfnmsub213sd vfnmsub213sd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub213sd vfnmsub213sd(AsmHexCode encoded) => new Vfnmsub213sd(encoded);

        public struct Vfnmsub231sd : ITypedInstruction<Vfnmsub231sd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmsub231sd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231SD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmsub231sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub231sd src) => AsmMnemonics.VFNMSUB231SD;

            public static implicit operator AsmHexCode(Vfnmsub231sd src) => src.Encoded;
        }

        public Vfnmsub231sd vfnmsub231sd() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub231sd vfnmsub231sd(AsmHexCode encoded) => new Vfnmsub231sd(encoded);

        public struct Vfnmsub132ss : ITypedInstruction<Vfnmsub132ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmsub132ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmsub132ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub132ss src) => AsmMnemonics.VFNMSUB132SS;

            public static implicit operator AsmHexCode(Vfnmsub132ss src) => src.Encoded;
        }

        public Vfnmsub132ss vfnmsub132ss() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub132ss vfnmsub132ss(AsmHexCode encoded) => new Vfnmsub132ss(encoded);

        public struct Vfnmsub213ss : ITypedInstruction<Vfnmsub213ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmsub213ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmsub213ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub213ss src) => AsmMnemonics.VFNMSUB213SS;

            public static implicit operator AsmHexCode(Vfnmsub213ss src) => src.Encoded;
        }

        public Vfnmsub213ss vfnmsub213ss() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub213ss vfnmsub213ss(AsmHexCode encoded) => new Vfnmsub213ss(encoded);

        public struct Vfnmsub231ss : ITypedInstruction<Vfnmsub231ss>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vfnmsub231ss(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231SS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vfnmsub231ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub231ss src) => AsmMnemonics.VFNMSUB231SS;

            public static implicit operator AsmHexCode(Vfnmsub231ss src) => src.Encoded;
        }

        public Vfnmsub231ss vfnmsub231ss() => default;

        [MethodImpl(Inline), Op]
        public Vfnmsub231ss vfnmsub231ss(AsmHexCode encoded) => new Vfnmsub231ss(encoded);

        public struct Vgatherdpd : ITypedInstruction<Vgatherdpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vgatherdpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERDPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vgatherdpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vgatherdpd src) => AsmMnemonics.VGATHERDPD;

            public static implicit operator AsmHexCode(Vgatherdpd src) => src.Encoded;
        }

        public Vgatherdpd vgatherdpd() => default;

        [MethodImpl(Inline), Op]
        public Vgatherdpd vgatherdpd(AsmHexCode encoded) => new Vgatherdpd(encoded);

        public struct Vgatherqpd : ITypedInstruction<Vgatherqpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vgatherqpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERQPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vgatherqpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vgatherqpd src) => AsmMnemonics.VGATHERQPD;

            public static implicit operator AsmHexCode(Vgatherqpd src) => src.Encoded;
        }

        public Vgatherqpd vgatherqpd() => default;

        [MethodImpl(Inline), Op]
        public Vgatherqpd vgatherqpd(AsmHexCode encoded) => new Vgatherqpd(encoded);

        public struct Vgatherdps : ITypedInstruction<Vgatherdps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vgatherdps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERDPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vgatherdps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vgatherdps src) => AsmMnemonics.VGATHERDPS;

            public static implicit operator AsmHexCode(Vgatherdps src) => src.Encoded;
        }

        public Vgatherdps vgatherdps() => default;

        [MethodImpl(Inline), Op]
        public Vgatherdps vgatherdps(AsmHexCode encoded) => new Vgatherdps(encoded);

        public struct Vgatherqps : ITypedInstruction<Vgatherqps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vgatherqps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERQPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vgatherqps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vgatherqps src) => AsmMnemonics.VGATHERQPS;

            public static implicit operator AsmHexCode(Vgatherqps src) => src.Encoded;
        }

        public Vgatherqps vgatherqps() => default;

        [MethodImpl(Inline), Op]
        public Vgatherqps vgatherqps(AsmHexCode encoded) => new Vgatherqps(encoded);

        public struct Vpgatherdd : ITypedInstruction<Vpgatherdd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpgatherdd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERDD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpgatherdd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpgatherdd src) => AsmMnemonics.VPGATHERDD;

            public static implicit operator AsmHexCode(Vpgatherdd src) => src.Encoded;
        }

        public Vpgatherdd vpgatherdd() => default;

        [MethodImpl(Inline), Op]
        public Vpgatherdd vpgatherdd(AsmHexCode encoded) => new Vpgatherdd(encoded);

        public struct Vpgatherqd : ITypedInstruction<Vpgatherqd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpgatherqd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERQD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpgatherqd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpgatherqd src) => AsmMnemonics.VPGATHERQD;

            public static implicit operator AsmHexCode(Vpgatherqd src) => src.Encoded;
        }

        public Vpgatherqd vpgatherqd() => default;

        [MethodImpl(Inline), Op]
        public Vpgatherqd vpgatherqd(AsmHexCode encoded) => new Vpgatherqd(encoded);

        public struct Vpgatherdq : ITypedInstruction<Vpgatherdq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpgatherdq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERDQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpgatherdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpgatherdq src) => AsmMnemonics.VPGATHERDQ;

            public static implicit operator AsmHexCode(Vpgatherdq src) => src.Encoded;
        }

        public Vpgatherdq vpgatherdq() => default;

        [MethodImpl(Inline), Op]
        public Vpgatherdq vpgatherdq(AsmHexCode encoded) => new Vpgatherdq(encoded);

        public struct Vpgatherqq : ITypedInstruction<Vpgatherqq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpgatherqq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERQQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpgatherqq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpgatherqq src) => AsmMnemonics.VPGATHERQQ;

            public static implicit operator AsmHexCode(Vpgatherqq src) => src.Encoded;
        }

        public Vpgatherqq vpgatherqq() => default;

        [MethodImpl(Inline), Op]
        public Vpgatherqq vpgatherqq(AsmHexCode encoded) => new Vpgatherqq(encoded);

        public struct Vinsertf128 : ITypedInstruction<Vinsertf128>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vinsertf128(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VINSERTF128;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vinsertf128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vinsertf128 src) => AsmMnemonics.VINSERTF128;

            public static implicit operator AsmHexCode(Vinsertf128 src) => src.Encoded;
        }

        public Vinsertf128 vinsertf128() => default;

        [MethodImpl(Inline), Op]
        public Vinsertf128 vinsertf128(AsmHexCode encoded) => new Vinsertf128(encoded);

        public struct Vinserti128 : ITypedInstruction<Vinserti128>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vinserti128(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VINSERTI128;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vinserti128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vinserti128 src) => AsmMnemonics.VINSERTI128;

            public static implicit operator AsmHexCode(Vinserti128 src) => src.Encoded;
        }

        public Vinserti128 vinserti128() => default;

        [MethodImpl(Inline), Op]
        public Vinserti128 vinserti128(AsmHexCode encoded) => new Vinserti128(encoded);

        public struct Vmaskmovps : ITypedInstruction<Vmaskmovps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmaskmovps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMASKMOVPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmaskmovps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaskmovps src) => AsmMnemonics.VMASKMOVPS;

            public static implicit operator AsmHexCode(Vmaskmovps src) => src.Encoded;
        }

        public Vmaskmovps vmaskmovps() => default;

        [MethodImpl(Inline), Op]
        public Vmaskmovps vmaskmovps(AsmHexCode encoded) => new Vmaskmovps(encoded);

        public struct Vmaskmovpd : ITypedInstruction<Vmaskmovpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vmaskmovpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMASKMOVPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vmaskmovpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaskmovpd src) => AsmMnemonics.VMASKMOVPD;

            public static implicit operator AsmHexCode(Vmaskmovpd src) => src.Encoded;
        }

        public Vmaskmovpd vmaskmovpd() => default;

        [MethodImpl(Inline), Op]
        public Vmaskmovpd vmaskmovpd(AsmHexCode encoded) => new Vmaskmovpd(encoded);

        public struct Vpblendd : ITypedInstruction<Vpblendd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpblendd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBLENDD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpblendd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpblendd src) => AsmMnemonics.VPBLENDD;

            public static implicit operator AsmHexCode(Vpblendd src) => src.Encoded;
        }

        public Vpblendd vpblendd() => default;

        [MethodImpl(Inline), Op]
        public Vpblendd vpblendd(AsmHexCode encoded) => new Vpblendd(encoded);

        public struct Vpbroadcastb : ITypedInstruction<Vpbroadcastb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpbroadcastb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpbroadcastb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpbroadcastb src) => AsmMnemonics.VPBROADCASTB;

            public static implicit operator AsmHexCode(Vpbroadcastb src) => src.Encoded;
        }

        public Vpbroadcastb vpbroadcastb() => default;

        [MethodImpl(Inline), Op]
        public Vpbroadcastb vpbroadcastb(AsmHexCode encoded) => new Vpbroadcastb(encoded);

        public struct Vpbroadcastw : ITypedInstruction<Vpbroadcastw>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpbroadcastw(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTW;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpbroadcastw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpbroadcastw src) => AsmMnemonics.VPBROADCASTW;

            public static implicit operator AsmHexCode(Vpbroadcastw src) => src.Encoded;
        }

        public Vpbroadcastw vpbroadcastw() => default;

        [MethodImpl(Inline), Op]
        public Vpbroadcastw vpbroadcastw(AsmHexCode encoded) => new Vpbroadcastw(encoded);

        public struct Vpbroadcastd : ITypedInstruction<Vpbroadcastd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpbroadcastd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpbroadcastd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpbroadcastd src) => AsmMnemonics.VPBROADCASTD;

            public static implicit operator AsmHexCode(Vpbroadcastd src) => src.Encoded;
        }

        public Vpbroadcastd vpbroadcastd() => default;

        [MethodImpl(Inline), Op]
        public Vpbroadcastd vpbroadcastd(AsmHexCode encoded) => new Vpbroadcastd(encoded);

        public struct Vpbroadcastq : ITypedInstruction<Vpbroadcastq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpbroadcastq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpbroadcastq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpbroadcastq src) => AsmMnemonics.VPBROADCASTQ;

            public static implicit operator AsmHexCode(Vpbroadcastq src) => src.Encoded;
        }

        public Vpbroadcastq vpbroadcastq() => default;

        [MethodImpl(Inline), Op]
        public Vpbroadcastq vpbroadcastq(AsmHexCode encoded) => new Vpbroadcastq(encoded);

        public struct Vbroadcasti128 : ITypedInstruction<Vbroadcasti128>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vbroadcasti128(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTI128;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vbroadcasti128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vbroadcasti128 src) => AsmMnemonics.VBROADCASTI128;

            public static implicit operator AsmHexCode(Vbroadcasti128 src) => src.Encoded;
        }

        public Vbroadcasti128 vbroadcasti128() => default;

        [MethodImpl(Inline), Op]
        public Vbroadcasti128 vbroadcasti128(AsmHexCode encoded) => new Vbroadcasti128(encoded);

        public struct Vpermd : ITypedInstruction<Vpermd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpermd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpermd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermd src) => AsmMnemonics.VPERMD;

            public static implicit operator AsmHexCode(Vpermd src) => src.Encoded;
        }

        public Vpermd vpermd() => default;

        [MethodImpl(Inline), Op]
        public Vpermd vpermd(AsmHexCode encoded) => new Vpermd(encoded);

        public struct Vpermpd : ITypedInstruction<Vpermpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpermpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpermpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermpd src) => AsmMnemonics.VPERMPD;

            public static implicit operator AsmHexCode(Vpermpd src) => src.Encoded;
        }

        public Vpermpd vpermpd() => default;

        [MethodImpl(Inline), Op]
        public Vpermpd vpermpd(AsmHexCode encoded) => new Vpermpd(encoded);

        public struct Vpermps : ITypedInstruction<Vpermps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpermps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpermps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermps src) => AsmMnemonics.VPERMPS;

            public static implicit operator AsmHexCode(Vpermps src) => src.Encoded;
        }

        public Vpermps vpermps() => default;

        [MethodImpl(Inline), Op]
        public Vpermps vpermps(AsmHexCode encoded) => new Vpermps(encoded);

        public struct Vpermq : ITypedInstruction<Vpermq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpermq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpermq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermq src) => AsmMnemonics.VPERMQ;

            public static implicit operator AsmHexCode(Vpermq src) => src.Encoded;
        }

        public Vpermq vpermq() => default;

        [MethodImpl(Inline), Op]
        public Vpermq vpermq(AsmHexCode encoded) => new Vpermq(encoded);

        public struct Vperm2i128 : ITypedInstruction<Vperm2i128>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vperm2i128(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERM2I128;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vperm2i128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vperm2i128 src) => AsmMnemonics.VPERM2I128;

            public static implicit operator AsmHexCode(Vperm2i128 src) => src.Encoded;
        }

        public Vperm2i128 vperm2i128() => default;

        [MethodImpl(Inline), Op]
        public Vperm2i128 vperm2i128(AsmHexCode encoded) => new Vperm2i128(encoded);

        public struct Vpermilpd : ITypedInstruction<Vpermilpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpermilpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMILPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpermilpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermilpd src) => AsmMnemonics.VPERMILPD;

            public static implicit operator AsmHexCode(Vpermilpd src) => src.Encoded;
        }

        public Vpermilpd vpermilpd() => default;

        [MethodImpl(Inline), Op]
        public Vpermilpd vpermilpd(AsmHexCode encoded) => new Vpermilpd(encoded);

        public struct Vpermilps : ITypedInstruction<Vpermilps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpermilps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMILPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpermilps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermilps src) => AsmMnemonics.VPERMILPS;

            public static implicit operator AsmHexCode(Vpermilps src) => src.Encoded;
        }

        public Vpermilps vpermilps() => default;

        [MethodImpl(Inline), Op]
        public Vpermilps vpermilps(AsmHexCode encoded) => new Vpermilps(encoded);

        public struct Vperm2f128 : ITypedInstruction<Vperm2f128>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vperm2f128(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERM2F128;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vperm2f128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vperm2f128 src) => AsmMnemonics.VPERM2F128;

            public static implicit operator AsmHexCode(Vperm2f128 src) => src.Encoded;
        }

        public Vperm2f128 vperm2f128() => default;

        [MethodImpl(Inline), Op]
        public Vperm2f128 vperm2f128(AsmHexCode encoded) => new Vperm2f128(encoded);

        public struct Vpmaskmovd : ITypedInstruction<Vpmaskmovd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmaskmovd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMASKMOVD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmaskmovd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaskmovd src) => AsmMnemonics.VPMASKMOVD;

            public static implicit operator AsmHexCode(Vpmaskmovd src) => src.Encoded;
        }

        public Vpmaskmovd vpmaskmovd() => default;

        [MethodImpl(Inline), Op]
        public Vpmaskmovd vpmaskmovd(AsmHexCode encoded) => new Vpmaskmovd(encoded);

        public struct Vpmaskmovq : ITypedInstruction<Vpmaskmovq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpmaskmovq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMASKMOVQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpmaskmovq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaskmovq src) => AsmMnemonics.VPMASKMOVQ;

            public static implicit operator AsmHexCode(Vpmaskmovq src) => src.Encoded;
        }

        public Vpmaskmovq vpmaskmovq() => default;

        [MethodImpl(Inline), Op]
        public Vpmaskmovq vpmaskmovq(AsmHexCode encoded) => new Vpmaskmovq(encoded);

        public struct Vpsllvd : ITypedInstruction<Vpsllvd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsllvd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLVD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsllvd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsllvd src) => AsmMnemonics.VPSLLVD;

            public static implicit operator AsmHexCode(Vpsllvd src) => src.Encoded;
        }

        public Vpsllvd vpsllvd() => default;

        [MethodImpl(Inline), Op]
        public Vpsllvd vpsllvd(AsmHexCode encoded) => new Vpsllvd(encoded);

        public struct Vpsllvq : ITypedInstruction<Vpsllvq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsllvq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLVQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsllvq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsllvq src) => AsmMnemonics.VPSLLVQ;

            public static implicit operator AsmHexCode(Vpsllvq src) => src.Encoded;
        }

        public Vpsllvq vpsllvq() => default;

        [MethodImpl(Inline), Op]
        public Vpsllvq vpsllvq(AsmHexCode encoded) => new Vpsllvq(encoded);

        public struct Vpsravd : ITypedInstruction<Vpsravd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsravd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRAVD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsravd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsravd src) => AsmMnemonics.VPSRAVD;

            public static implicit operator AsmHexCode(Vpsravd src) => src.Encoded;
        }

        public Vpsravd vpsravd() => default;

        [MethodImpl(Inline), Op]
        public Vpsravd vpsravd(AsmHexCode encoded) => new Vpsravd(encoded);

        public struct Vpsrlvd : ITypedInstruction<Vpsrlvd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsrlvd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLVD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsrlvd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrlvd src) => AsmMnemonics.VPSRLVD;

            public static implicit operator AsmHexCode(Vpsrlvd src) => src.Encoded;
        }

        public Vpsrlvd vpsrlvd() => default;

        [MethodImpl(Inline), Op]
        public Vpsrlvd vpsrlvd(AsmHexCode encoded) => new Vpsrlvd(encoded);

        public struct Vpsrlvq : ITypedInstruction<Vpsrlvq>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vpsrlvq(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLVQ;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vpsrlvq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrlvq src) => AsmMnemonics.VPSRLVQ;

            public static implicit operator AsmHexCode(Vpsrlvq src) => src.Encoded;
        }

        public Vpsrlvq vpsrlvq() => default;

        [MethodImpl(Inline), Op]
        public Vpsrlvq vpsrlvq(AsmHexCode encoded) => new Vpsrlvq(encoded);

        public struct Vtestps : ITypedInstruction<Vtestps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vtestps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VTESTPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vtestps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vtestps src) => AsmMnemonics.VTESTPS;

            public static implicit operator AsmHexCode(Vtestps src) => src.Encoded;
        }

        public Vtestps vtestps() => default;

        [MethodImpl(Inline), Op]
        public Vtestps vtestps(AsmHexCode encoded) => new Vtestps(encoded);

        public struct Vtestpd : ITypedInstruction<Vtestpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vtestpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VTESTPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vtestpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vtestpd src) => AsmMnemonics.VTESTPD;

            public static implicit operator AsmHexCode(Vtestpd src) => src.Encoded;
        }

        public Vtestpd vtestpd() => default;

        [MethodImpl(Inline), Op]
        public Vtestpd vtestpd(AsmHexCode encoded) => new Vtestpd(encoded);

        public struct Vzeroall : ITypedInstruction<Vzeroall>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vzeroall(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VZEROALL;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vzeroall src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vzeroall src) => AsmMnemonics.VZEROALL;

            public static implicit operator AsmHexCode(Vzeroall src) => src.Encoded;
        }

        public Vzeroall vzeroall() => default;

        [MethodImpl(Inline), Op]
        public Vzeroall vzeroall(AsmHexCode encoded) => new Vzeroall(encoded);

        public struct Vzeroupper : ITypedInstruction<Vzeroupper>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vzeroupper(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VZEROUPPER;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vzeroupper src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vzeroupper src) => AsmMnemonics.VZEROUPPER;

            public static implicit operator AsmHexCode(Vzeroupper src) => src.Encoded;
        }

        public Vzeroupper vzeroupper() => default;

        [MethodImpl(Inline), Op]
        public Vzeroupper vzeroupper(AsmHexCode encoded) => new Vzeroupper(encoded);

        public struct Wait : ITypedInstruction<Wait>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Wait(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WAIT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Wait src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Wait src) => AsmMnemonics.WAIT;

            public static implicit operator AsmHexCode(Wait src) => src.Encoded;
        }

        public Wait wait() => default;

        [MethodImpl(Inline), Op]
        public Wait wait(AsmHexCode encoded) => new Wait(encoded);

        public struct Fwait : ITypedInstruction<Fwait>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Fwait(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FWAIT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Fwait src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fwait src) => AsmMnemonics.FWAIT;

            public static implicit operator AsmHexCode(Fwait src) => src.Encoded;
        }

        public Fwait fwait() => default;

        [MethodImpl(Inline), Op]
        public Fwait fwait(AsmHexCode encoded) => new Fwait(encoded);

        public struct Wbinvd : ITypedInstruction<Wbinvd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Wbinvd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WBINVD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Wbinvd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Wbinvd src) => AsmMnemonics.WBINVD;

            public static implicit operator AsmHexCode(Wbinvd src) => src.Encoded;
        }

        public Wbinvd wbinvd() => default;

        [MethodImpl(Inline), Op]
        public Wbinvd wbinvd(AsmHexCode encoded) => new Wbinvd(encoded);

        public struct Wrfsbase : ITypedInstruction<Wrfsbase>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Wrfsbase(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WRFSBASE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Wrfsbase src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Wrfsbase src) => AsmMnemonics.WRFSBASE;

            public static implicit operator AsmHexCode(Wrfsbase src) => src.Encoded;
        }

        public Wrfsbase wrfsbase() => default;

        [MethodImpl(Inline), Op]
        public Wrfsbase wrfsbase(AsmHexCode encoded) => new Wrfsbase(encoded);

        public struct Wrgsbase : ITypedInstruction<Wrgsbase>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Wrgsbase(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WRGSBASE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Wrgsbase src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Wrgsbase src) => AsmMnemonics.WRGSBASE;

            public static implicit operator AsmHexCode(Wrgsbase src) => src.Encoded;
        }

        public Wrgsbase wrgsbase() => default;

        [MethodImpl(Inline), Op]
        public Wrgsbase wrgsbase(AsmHexCode encoded) => new Wrgsbase(encoded);

        public struct Wrmsr : ITypedInstruction<Wrmsr>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Wrmsr(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WRMSR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Wrmsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Wrmsr src) => AsmMnemonics.WRMSR;

            public static implicit operator AsmHexCode(Wrmsr src) => src.Encoded;
        }

        public Wrmsr wrmsr() => default;

        [MethodImpl(Inline), Op]
        public Wrmsr wrmsr(AsmHexCode encoded) => new Wrmsr(encoded);

        public struct Xacquire : ITypedInstruction<Xacquire>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xacquire(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XACQUIRE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xacquire src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xacquire src) => AsmMnemonics.XACQUIRE;

            public static implicit operator AsmHexCode(Xacquire src) => src.Encoded;
        }

        public Xacquire xacquire() => default;

        [MethodImpl(Inline), Op]
        public Xacquire xacquire(AsmHexCode encoded) => new Xacquire(encoded);

        public struct Xrelease : ITypedInstruction<Xrelease>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xrelease(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XRELEASE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xrelease src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xrelease src) => AsmMnemonics.XRELEASE;

            public static implicit operator AsmHexCode(Xrelease src) => src.Encoded;
        }

        public Xrelease xrelease() => default;

        [MethodImpl(Inline), Op]
        public Xrelease xrelease(AsmHexCode encoded) => new Xrelease(encoded);

        public struct Xabort : ITypedInstruction<Xabort>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xabort(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XABORT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xabort src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xabort src) => AsmMnemonics.XABORT;

            public static implicit operator AsmHexCode(Xabort src) => src.Encoded;
        }

        public Xabort xabort() => default;

        [MethodImpl(Inline), Op]
        public Xabort xabort(AsmHexCode encoded) => new Xabort(encoded);

        public struct Xadd : ITypedInstruction<Xadd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xadd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XADD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xadd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xadd src) => AsmMnemonics.XADD;

            public static implicit operator AsmHexCode(Xadd src) => src.Encoded;
        }

        public Xadd xadd() => default;

        [MethodImpl(Inline), Op]
        public Xadd xadd(AsmHexCode encoded) => new Xadd(encoded);

        public struct Xbegin : ITypedInstruction<Xbegin>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xbegin(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XBEGIN;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xbegin src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xbegin src) => AsmMnemonics.XBEGIN;

            public static implicit operator AsmHexCode(Xbegin src) => src.Encoded;
        }

        public Xbegin xbegin() => default;

        [MethodImpl(Inline), Op]
        public Xbegin xbegin(AsmHexCode encoded) => new Xbegin(encoded);

        public struct Xchg : ITypedInstruction<Xchg>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xchg(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XCHG;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xchg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xchg src) => AsmMnemonics.XCHG;

            public static implicit operator AsmHexCode(Xchg src) => src.Encoded;
        }

        public Xchg xchg() => default;

        [MethodImpl(Inline), Op]
        public Xchg xchg(AsmHexCode encoded) => new Xchg(encoded);

        public struct Xend : ITypedInstruction<Xend>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xend(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XEND;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xend src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xend src) => AsmMnemonics.XEND;

            public static implicit operator AsmHexCode(Xend src) => src.Encoded;
        }

        public Xend xend() => default;

        [MethodImpl(Inline), Op]
        public Xend xend(AsmHexCode encoded) => new Xend(encoded);

        public struct Xgetbv : ITypedInstruction<Xgetbv>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xgetbv(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XGETBV;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xgetbv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xgetbv src) => AsmMnemonics.XGETBV;

            public static implicit operator AsmHexCode(Xgetbv src) => src.Encoded;
        }

        public Xgetbv xgetbv() => default;

        [MethodImpl(Inline), Op]
        public Xgetbv xgetbv(AsmHexCode encoded) => new Xgetbv(encoded);

        public struct Xlat : ITypedInstruction<Xlat>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xlat(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XLAT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xlat src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xlat src) => AsmMnemonics.XLAT;

            public static implicit operator AsmHexCode(Xlat src) => src.Encoded;
        }

        public Xlat xlat() => default;

        [MethodImpl(Inline), Op]
        public Xlat xlat(AsmHexCode encoded) => new Xlat(encoded);

        public struct Xlatb : ITypedInstruction<Xlatb>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xlatb(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XLATB;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xlatb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xlatb src) => AsmMnemonics.XLATB;

            public static implicit operator AsmHexCode(Xlatb src) => src.Encoded;
        }

        public Xlatb xlatb() => default;

        [MethodImpl(Inline), Op]
        public Xlatb xlatb(AsmHexCode encoded) => new Xlatb(encoded);

        public struct Xor : ITypedInstruction<Xor>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xor(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XOR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xor src) => AsmMnemonics.XOR;

            public static implicit operator AsmHexCode(Xor src) => src.Encoded;
        }

        public Xor xor() => default;

        [MethodImpl(Inline), Op]
        public Xor xor(AsmHexCode encoded) => new Xor(encoded);

        public struct Xorpd : ITypedInstruction<Xorpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xorpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XORPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xorpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xorpd src) => AsmMnemonics.XORPD;

            public static implicit operator AsmHexCode(Xorpd src) => src.Encoded;
        }

        public Xorpd xorpd() => default;

        [MethodImpl(Inline), Op]
        public Xorpd xorpd(AsmHexCode encoded) => new Xorpd(encoded);

        public struct Vxorpd : ITypedInstruction<Vxorpd>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vxorpd(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VXORPD;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vxorpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vxorpd src) => AsmMnemonics.VXORPD;

            public static implicit operator AsmHexCode(Vxorpd src) => src.Encoded;
        }

        public Vxorpd vxorpd() => default;

        [MethodImpl(Inline), Op]
        public Vxorpd vxorpd(AsmHexCode encoded) => new Vxorpd(encoded);

        public struct Xorps : ITypedInstruction<Xorps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xorps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XORPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xorps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xorps src) => AsmMnemonics.XORPS;

            public static implicit operator AsmHexCode(Xorps src) => src.Encoded;
        }

        public Xorps xorps() => default;

        [MethodImpl(Inline), Op]
        public Xorps xorps(AsmHexCode encoded) => new Xorps(encoded);

        public struct Vxorps : ITypedInstruction<Vxorps>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Vxorps(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VXORPS;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Vxorps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vxorps src) => AsmMnemonics.VXORPS;

            public static implicit operator AsmHexCode(Vxorps src) => src.Encoded;
        }

        public Vxorps vxorps() => default;

        [MethodImpl(Inline), Op]
        public Vxorps vxorps(AsmHexCode encoded) => new Vxorps(encoded);

        public struct Xrstor : ITypedInstruction<Xrstor>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xrstor(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XRSTOR;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xrstor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xrstor src) => AsmMnemonics.XRSTOR;

            public static implicit operator AsmHexCode(Xrstor src) => src.Encoded;
        }

        public Xrstor xrstor() => default;

        [MethodImpl(Inline), Op]
        public Xrstor xrstor(AsmHexCode encoded) => new Xrstor(encoded);

        public struct Xrstor64 : ITypedInstruction<Xrstor64>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xrstor64(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XRSTOR64;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xrstor64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xrstor64 src) => AsmMnemonics.XRSTOR64;

            public static implicit operator AsmHexCode(Xrstor64 src) => src.Encoded;
        }

        public Xrstor64 xrstor64() => default;

        [MethodImpl(Inline), Op]
        public Xrstor64 xrstor64(AsmHexCode encoded) => new Xrstor64(encoded);

        public struct Xsave : ITypedInstruction<Xsave>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xsave(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVE;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xsave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsave src) => AsmMnemonics.XSAVE;

            public static implicit operator AsmHexCode(Xsave src) => src.Encoded;
        }

        public Xsave xsave() => default;

        [MethodImpl(Inline), Op]
        public Xsave xsave(AsmHexCode encoded) => new Xsave(encoded);

        public struct Xsave64 : ITypedInstruction<Xsave64>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xsave64(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVE64;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xsave64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsave64 src) => AsmMnemonics.XSAVE64;

            public static implicit operator AsmHexCode(Xsave64 src) => src.Encoded;
        }

        public Xsave64 xsave64() => default;

        [MethodImpl(Inline), Op]
        public Xsave64 xsave64(AsmHexCode encoded) => new Xsave64(encoded);

        public struct Xsaveopt : ITypedInstruction<Xsaveopt>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xsaveopt(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVEOPT;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xsaveopt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsaveopt src) => AsmMnemonics.XSAVEOPT;

            public static implicit operator AsmHexCode(Xsaveopt src) => src.Encoded;
        }

        public Xsaveopt xsaveopt() => default;

        [MethodImpl(Inline), Op]
        public Xsaveopt xsaveopt(AsmHexCode encoded) => new Xsaveopt(encoded);

        public struct Xsaveopt64 : ITypedInstruction<Xsaveopt64>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xsaveopt64(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVEOPT64;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xsaveopt64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsaveopt64 src) => AsmMnemonics.XSAVEOPT64;

            public static implicit operator AsmHexCode(Xsaveopt64 src) => src.Encoded;
        }

        public Xsaveopt64 xsaveopt64() => default;

        [MethodImpl(Inline), Op]
        public Xsaveopt64 xsaveopt64(AsmHexCode encoded) => new Xsaveopt64(encoded);

        public struct Xsetbv : ITypedInstruction<Xsetbv>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xsetbv(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSETBV;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xsetbv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsetbv src) => AsmMnemonics.XSETBV;

            public static implicit operator AsmHexCode(Xsetbv src) => src.Encoded;
        }

        public Xsetbv xsetbv() => default;

        [MethodImpl(Inline), Op]
        public Xsetbv xsetbv(AsmHexCode encoded) => new Xsetbv(encoded);

        public struct Xtest : ITypedInstruction<Xtest>
        {
            public AsmHexCode Content;

            [MethodImpl(Inline)]
            public Xtest(AsmHexCode encoded)
            {
                Content = encoded;
            }

            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XTEST;

            public AsmHexCode Encoded => Content;

            public static implicit operator AsmMnemonicCode(Xtest src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xtest src) => AsmMnemonics.XTEST;

            public static implicit operator AsmHexCode(Xtest src) => src.Encoded;
        }

        public Xtest xtest() => default;

        [MethodImpl(Inline), Op]
        public Xtest xtest(AsmHexCode encoded) => new Xtest(encoded);

    }
}
