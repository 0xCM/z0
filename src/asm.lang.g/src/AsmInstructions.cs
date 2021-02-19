//-----------------------------------------------------------------------------
// Generated   :  20210219.04.12.01.1025
// Copyright   :  (c) Chris Moore, 2021
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct AsmInstructions
    {
        public readonly struct Aad : IAsmInstruction<Aad>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AAD;

            public static implicit operator AsmMnemonicCode(Aad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aad src) => AsmMnemonics.AAD;
        }

        public static Aad aad() => default;

        public readonly struct Aam : IAsmInstruction<Aam>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AAM;

            public static implicit operator AsmMnemonicCode(Aam src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aam src) => AsmMnemonics.AAM;
        }

        public static Aam aam() => default;

        public readonly struct Adc : IAsmInstruction<Adc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADC;

            public static implicit operator AsmMnemonicCode(Adc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Adc src) => AsmMnemonics.ADC;
        }

        public static Adc adc() => default;

        public readonly struct Add : IAsmInstruction<Add>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADD;

            public static implicit operator AsmMnemonicCode(Add src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Add src) => AsmMnemonics.ADD;
        }

        public static Add add() => default;

        public readonly struct Addpd : IAsmInstruction<Addpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDPD;

            public static implicit operator AsmMnemonicCode(Addpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addpd src) => AsmMnemonics.ADDPD;
        }

        public static Addpd addpd() => default;

        public readonly struct Vaddpd : IAsmInstruction<Vaddpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDPD;

            public static implicit operator AsmMnemonicCode(Vaddpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddpd src) => AsmMnemonics.VADDPD;
        }

        public static Vaddpd vaddpd() => default;

        public readonly struct Addps : IAsmInstruction<Addps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDPS;

            public static implicit operator AsmMnemonicCode(Addps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addps src) => AsmMnemonics.ADDPS;
        }

        public static Addps addps() => default;

        public readonly struct Vaddps : IAsmInstruction<Vaddps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDPS;

            public static implicit operator AsmMnemonicCode(Vaddps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddps src) => AsmMnemonics.VADDPS;
        }

        public static Vaddps vaddps() => default;

        public readonly struct Addsd : IAsmInstruction<Addsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSD;

            public static implicit operator AsmMnemonicCode(Addsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addsd src) => AsmMnemonics.ADDSD;
        }

        public static Addsd addsd() => default;

        public readonly struct Vaddsd : IAsmInstruction<Vaddsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSD;

            public static implicit operator AsmMnemonicCode(Vaddsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddsd src) => AsmMnemonics.VADDSD;
        }

        public static Vaddsd vaddsd() => default;

        public readonly struct Addss : IAsmInstruction<Addss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSS;

            public static implicit operator AsmMnemonicCode(Addss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addss src) => AsmMnemonics.ADDSS;
        }

        public static Addss addss() => default;

        public readonly struct Vaddss : IAsmInstruction<Vaddss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSS;

            public static implicit operator AsmMnemonicCode(Vaddss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddss src) => AsmMnemonics.VADDSS;
        }

        public static Vaddss vaddss() => default;

        public readonly struct Addsubpd : IAsmInstruction<Addsubpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSUBPD;

            public static implicit operator AsmMnemonicCode(Addsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addsubpd src) => AsmMnemonics.ADDSUBPD;
        }

        public static Addsubpd addsubpd() => default;

        public readonly struct Vaddsubpd : IAsmInstruction<Vaddsubpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSUBPD;

            public static implicit operator AsmMnemonicCode(Vaddsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddsubpd src) => AsmMnemonics.VADDSUBPD;
        }

        public static Vaddsubpd vaddsubpd() => default;

        public readonly struct Addsubps : IAsmInstruction<Addsubps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSUBPS;

            public static implicit operator AsmMnemonicCode(Addsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Addsubps src) => AsmMnemonics.ADDSUBPS;
        }

        public static Addsubps addsubps() => default;

        public readonly struct Vaddsubps : IAsmInstruction<Vaddsubps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSUBPS;

            public static implicit operator AsmMnemonicCode(Vaddsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaddsubps src) => AsmMnemonics.VADDSUBPS;
        }

        public static Vaddsubps vaddsubps() => default;

        public readonly struct Aesdec : IAsmInstruction<Aesdec>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESDEC;

            public static implicit operator AsmMnemonicCode(Aesdec src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesdec src) => AsmMnemonics.AESDEC;
        }

        public static Aesdec aesdec() => default;

        public readonly struct Vaesdec : IAsmInstruction<Vaesdec>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESDEC;

            public static implicit operator AsmMnemonicCode(Vaesdec src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesdec src) => AsmMnemonics.VAESDEC;
        }

        public static Vaesdec vaesdec() => default;

        public readonly struct Aesdeclast : IAsmInstruction<Aesdeclast>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESDECLAST;

            public static implicit operator AsmMnemonicCode(Aesdeclast src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesdeclast src) => AsmMnemonics.AESDECLAST;
        }

        public static Aesdeclast aesdeclast() => default;

        public readonly struct Vaesdeclast : IAsmInstruction<Vaesdeclast>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESDECLAST;

            public static implicit operator AsmMnemonicCode(Vaesdeclast src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesdeclast src) => AsmMnemonics.VAESDECLAST;
        }

        public static Vaesdeclast vaesdeclast() => default;

        public readonly struct Aesenc : IAsmInstruction<Aesenc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESENC;

            public static implicit operator AsmMnemonicCode(Aesenc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesenc src) => AsmMnemonics.AESENC;
        }

        public static Aesenc aesenc() => default;

        public readonly struct Vaesenc : IAsmInstruction<Vaesenc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESENC;

            public static implicit operator AsmMnemonicCode(Vaesenc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesenc src) => AsmMnemonics.VAESENC;
        }

        public static Vaesenc vaesenc() => default;

        public readonly struct Aesenclast : IAsmInstruction<Aesenclast>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESENCLAST;

            public static implicit operator AsmMnemonicCode(Aesenclast src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesenclast src) => AsmMnemonics.AESENCLAST;
        }

        public static Aesenclast aesenclast() => default;

        public readonly struct Vaesenclast : IAsmInstruction<Vaesenclast>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESENCLAST;

            public static implicit operator AsmMnemonicCode(Vaesenclast src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesenclast src) => AsmMnemonics.VAESENCLAST;
        }

        public static Vaesenclast vaesenclast() => default;

        public readonly struct Aesimc : IAsmInstruction<Aesimc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESIMC;

            public static implicit operator AsmMnemonicCode(Aesimc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aesimc src) => AsmMnemonics.AESIMC;
        }

        public static Aesimc aesimc() => default;

        public readonly struct Vaesimc : IAsmInstruction<Vaesimc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESIMC;

            public static implicit operator AsmMnemonicCode(Vaesimc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaesimc src) => AsmMnemonics.VAESIMC;
        }

        public static Vaesimc vaesimc() => default;

        public readonly struct Aeskeygenassist : IAsmInstruction<Aeskeygenassist>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESKEYGENASSIST;

            public static implicit operator AsmMnemonicCode(Aeskeygenassist src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Aeskeygenassist src) => AsmMnemonics.AESKEYGENASSIST;
        }

        public static Aeskeygenassist aeskeygenassist() => default;

        public readonly struct Vaeskeygenassist : IAsmInstruction<Vaeskeygenassist>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESKEYGENASSIST;

            public static implicit operator AsmMnemonicCode(Vaeskeygenassist src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vaeskeygenassist src) => AsmMnemonics.VAESKEYGENASSIST;
        }

        public static Vaeskeygenassist vaeskeygenassist() => default;

        public readonly struct And : IAsmInstruction<And>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AND;

            public static implicit operator AsmMnemonicCode(And src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(And src) => AsmMnemonics.AND;
        }

        public static And and() => default;

        public readonly struct Andn : IAsmInstruction<Andn>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDN;

            public static implicit operator AsmMnemonicCode(Andn src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andn src) => AsmMnemonics.ANDN;
        }

        public static Andn andn() => default;

        public readonly struct Andpd : IAsmInstruction<Andpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDPD;

            public static implicit operator AsmMnemonicCode(Andpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andpd src) => AsmMnemonics.ANDPD;
        }

        public static Andpd andpd() => default;

        public readonly struct Vandpd : IAsmInstruction<Vandpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDPD;

            public static implicit operator AsmMnemonicCode(Vandpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vandpd src) => AsmMnemonics.VANDPD;
        }

        public static Vandpd vandpd() => default;

        public readonly struct Andps : IAsmInstruction<Andps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDPS;

            public static implicit operator AsmMnemonicCode(Andps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andps src) => AsmMnemonics.ANDPS;
        }

        public static Andps andps() => default;

        public readonly struct Vandps : IAsmInstruction<Vandps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDPS;

            public static implicit operator AsmMnemonicCode(Vandps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vandps src) => AsmMnemonics.VANDPS;
        }

        public static Vandps vandps() => default;

        public readonly struct Andnpd : IAsmInstruction<Andnpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDNPD;

            public static implicit operator AsmMnemonicCode(Andnpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andnpd src) => AsmMnemonics.ANDNPD;
        }

        public static Andnpd andnpd() => default;

        public readonly struct Vandnpd : IAsmInstruction<Vandnpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDNPD;

            public static implicit operator AsmMnemonicCode(Vandnpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vandnpd src) => AsmMnemonics.VANDNPD;
        }

        public static Vandnpd vandnpd() => default;

        public readonly struct Andnps : IAsmInstruction<Andnps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDNPS;

            public static implicit operator AsmMnemonicCode(Andnps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Andnps src) => AsmMnemonics.ANDNPS;
        }

        public static Andnps andnps() => default;

        public readonly struct Vandnps : IAsmInstruction<Vandnps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDNPS;

            public static implicit operator AsmMnemonicCode(Vandnps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vandnps src) => AsmMnemonics.VANDNPS;
        }

        public static Vandnps vandnps() => default;

        public readonly struct Arpl : IAsmInstruction<Arpl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ARPL;

            public static implicit operator AsmMnemonicCode(Arpl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Arpl src) => AsmMnemonics.ARPL;
        }

        public static Arpl arpl() => default;

        public readonly struct Blendpd : IAsmInstruction<Blendpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDPD;

            public static implicit operator AsmMnemonicCode(Blendpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blendpd src) => AsmMnemonics.BLENDPD;
        }

        public static Blendpd blendpd() => default;

        public readonly struct Vblendpd : IAsmInstruction<Vblendpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDPD;

            public static implicit operator AsmMnemonicCode(Vblendpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vblendpd src) => AsmMnemonics.VBLENDPD;
        }

        public static Vblendpd vblendpd() => default;

        public readonly struct Bextr : IAsmInstruction<Bextr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BEXTR;

            public static implicit operator AsmMnemonicCode(Bextr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bextr src) => AsmMnemonics.BEXTR;
        }

        public static Bextr bextr() => default;

        public readonly struct Blendps : IAsmInstruction<Blendps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDPS;

            public static implicit operator AsmMnemonicCode(Blendps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blendps src) => AsmMnemonics.BLENDPS;
        }

        public static Blendps blendps() => default;

        public readonly struct Vblendps : IAsmInstruction<Vblendps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDPS;

            public static implicit operator AsmMnemonicCode(Vblendps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vblendps src) => AsmMnemonics.VBLENDPS;
        }

        public static Vblendps vblendps() => default;

        public readonly struct Blendvpd : IAsmInstruction<Blendvpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDVPD;

            public static implicit operator AsmMnemonicCode(Blendvpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blendvpd src) => AsmMnemonics.BLENDVPD;
        }

        public static Blendvpd blendvpd() => default;

        public readonly struct Vblendvpd : IAsmInstruction<Vblendvpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDVPD;

            public static implicit operator AsmMnemonicCode(Vblendvpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vblendvpd src) => AsmMnemonics.VBLENDVPD;
        }

        public static Vblendvpd vblendvpd() => default;

        public readonly struct Blendvps : IAsmInstruction<Blendvps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDVPS;

            public static implicit operator AsmMnemonicCode(Blendvps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blendvps src) => AsmMnemonics.BLENDVPS;
        }

        public static Blendvps blendvps() => default;

        public readonly struct Vblendvps : IAsmInstruction<Vblendvps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDVPS;

            public static implicit operator AsmMnemonicCode(Vblendvps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vblendvps src) => AsmMnemonics.VBLENDVPS;
        }

        public static Vblendvps vblendvps() => default;

        public readonly struct Blsi : IAsmInstruction<Blsi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLSI;

            public static implicit operator AsmMnemonicCode(Blsi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blsi src) => AsmMnemonics.BLSI;
        }

        public static Blsi blsi() => default;

        public readonly struct Blsmsk : IAsmInstruction<Blsmsk>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLSMSK;

            public static implicit operator AsmMnemonicCode(Blsmsk src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blsmsk src) => AsmMnemonics.BLSMSK;
        }

        public static Blsmsk blsmsk() => default;

        public readonly struct Blsr : IAsmInstruction<Blsr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLSR;

            public static implicit operator AsmMnemonicCode(Blsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Blsr src) => AsmMnemonics.BLSR;
        }

        public static Blsr blsr() => default;

        public readonly struct Bound : IAsmInstruction<Bound>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BOUND;

            public static implicit operator AsmMnemonicCode(Bound src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bound src) => AsmMnemonics.BOUND;
        }

        public static Bound bound() => default;

        public readonly struct Bsf : IAsmInstruction<Bsf>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BSF;

            public static implicit operator AsmMnemonicCode(Bsf src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bsf src) => AsmMnemonics.BSF;
        }

        public static Bsf bsf() => default;

        public readonly struct Bsr : IAsmInstruction<Bsr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BSR;

            public static implicit operator AsmMnemonicCode(Bsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bsr src) => AsmMnemonics.BSR;
        }

        public static Bsr bsr() => default;

        public readonly struct Bswap : IAsmInstruction<Bswap>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BSWAP;

            public static implicit operator AsmMnemonicCode(Bswap src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bswap src) => AsmMnemonics.BSWAP;
        }

        public static Bswap bswap() => default;

        public readonly struct Bt : IAsmInstruction<Bt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BT;

            public static implicit operator AsmMnemonicCode(Bt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bt src) => AsmMnemonics.BT;
        }

        public static Bt bt() => default;

        public readonly struct Btc : IAsmInstruction<Btc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BTC;

            public static implicit operator AsmMnemonicCode(Btc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Btc src) => AsmMnemonics.BTC;
        }

        public static Btc btc() => default;

        public readonly struct Btr : IAsmInstruction<Btr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BTR;

            public static implicit operator AsmMnemonicCode(Btr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Btr src) => AsmMnemonics.BTR;
        }

        public static Btr btr() => default;

        public readonly struct Bts : IAsmInstruction<Bts>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BTS;

            public static implicit operator AsmMnemonicCode(Bts src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bts src) => AsmMnemonics.BTS;
        }

        public static Bts bts() => default;

        public readonly struct Bzhi : IAsmInstruction<Bzhi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BZHI;

            public static implicit operator AsmMnemonicCode(Bzhi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Bzhi src) => AsmMnemonics.BZHI;
        }

        public static Bzhi bzhi() => default;

        public readonly struct Call : IAsmInstruction<Call>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CALL;

            public static implicit operator AsmMnemonicCode(Call src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Call src) => AsmMnemonics.CALL;
        }

        public static Call call() => default;

        public readonly struct Clflush : IAsmInstruction<Clflush>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CLFLUSH;

            public static implicit operator AsmMnemonicCode(Clflush src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Clflush src) => AsmMnemonics.CLFLUSH;
        }

        public static Clflush clflush() => default;

        public readonly struct Cmova : IAsmInstruction<Cmova>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVA;

            public static implicit operator AsmMnemonicCode(Cmova src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmova src) => AsmMnemonics.CMOVA;
        }

        public static Cmova cmova() => default;

        public readonly struct Cmovae : IAsmInstruction<Cmovae>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVAE;

            public static implicit operator AsmMnemonicCode(Cmovae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovae src) => AsmMnemonics.CMOVAE;
        }

        public static Cmovae cmovae() => default;

        public readonly struct Cmovb : IAsmInstruction<Cmovb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVB;

            public static implicit operator AsmMnemonicCode(Cmovb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovb src) => AsmMnemonics.CMOVB;
        }

        public static Cmovb cmovb() => default;

        public readonly struct Cmovbe : IAsmInstruction<Cmovbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVBE;

            public static implicit operator AsmMnemonicCode(Cmovbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovbe src) => AsmMnemonics.CMOVBE;
        }

        public static Cmovbe cmovbe() => default;

        public readonly struct Cmovc : IAsmInstruction<Cmovc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVC;

            public static implicit operator AsmMnemonicCode(Cmovc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovc src) => AsmMnemonics.CMOVC;
        }

        public static Cmovc cmovc() => default;

        public readonly struct Cmove : IAsmInstruction<Cmove>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVE;

            public static implicit operator AsmMnemonicCode(Cmove src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmove src) => AsmMnemonics.CMOVE;
        }

        public static Cmove cmove() => default;

        public readonly struct Cmovg : IAsmInstruction<Cmovg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVG;

            public static implicit operator AsmMnemonicCode(Cmovg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovg src) => AsmMnemonics.CMOVG;
        }

        public static Cmovg cmovg() => default;

        public readonly struct Cmovge : IAsmInstruction<Cmovge>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVGE;

            public static implicit operator AsmMnemonicCode(Cmovge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovge src) => AsmMnemonics.CMOVGE;
        }

        public static Cmovge cmovge() => default;

        public readonly struct Cmovl : IAsmInstruction<Cmovl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVL;

            public static implicit operator AsmMnemonicCode(Cmovl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovl src) => AsmMnemonics.CMOVL;
        }

        public static Cmovl cmovl() => default;

        public readonly struct Cmovle : IAsmInstruction<Cmovle>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVLE;

            public static implicit operator AsmMnemonicCode(Cmovle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovle src) => AsmMnemonics.CMOVLE;
        }

        public static Cmovle cmovle() => default;

        public readonly struct Cmovna : IAsmInstruction<Cmovna>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNA;

            public static implicit operator AsmMnemonicCode(Cmovna src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovna src) => AsmMnemonics.CMOVNA;
        }

        public static Cmovna cmovna() => default;

        public readonly struct Cmovnae : IAsmInstruction<Cmovnae>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNAE;

            public static implicit operator AsmMnemonicCode(Cmovnae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnae src) => AsmMnemonics.CMOVNAE;
        }

        public static Cmovnae cmovnae() => default;

        public readonly struct Cmovnb : IAsmInstruction<Cmovnb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNB;

            public static implicit operator AsmMnemonicCode(Cmovnb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnb src) => AsmMnemonics.CMOVNB;
        }

        public static Cmovnb cmovnb() => default;

        public readonly struct Cmovnbe : IAsmInstruction<Cmovnbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNBE;

            public static implicit operator AsmMnemonicCode(Cmovnbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnbe src) => AsmMnemonics.CMOVNBE;
        }

        public static Cmovnbe cmovnbe() => default;

        public readonly struct Cmovnc : IAsmInstruction<Cmovnc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNC;

            public static implicit operator AsmMnemonicCode(Cmovnc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnc src) => AsmMnemonics.CMOVNC;
        }

        public static Cmovnc cmovnc() => default;

        public readonly struct Cmovne : IAsmInstruction<Cmovne>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNE;

            public static implicit operator AsmMnemonicCode(Cmovne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovne src) => AsmMnemonics.CMOVNE;
        }

        public static Cmovne cmovne() => default;

        public readonly struct Cmovng : IAsmInstruction<Cmovng>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNG;

            public static implicit operator AsmMnemonicCode(Cmovng src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovng src) => AsmMnemonics.CMOVNG;
        }

        public static Cmovng cmovng() => default;

        public readonly struct Cmovnge : IAsmInstruction<Cmovnge>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNGE;

            public static implicit operator AsmMnemonicCode(Cmovnge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnge src) => AsmMnemonics.CMOVNGE;
        }

        public static Cmovnge cmovnge() => default;

        public readonly struct Cmovnl : IAsmInstruction<Cmovnl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNL;

            public static implicit operator AsmMnemonicCode(Cmovnl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnl src) => AsmMnemonics.CMOVNL;
        }

        public static Cmovnl cmovnl() => default;

        public readonly struct Cmovnle : IAsmInstruction<Cmovnle>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNLE;

            public static implicit operator AsmMnemonicCode(Cmovnle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnle src) => AsmMnemonics.CMOVNLE;
        }

        public static Cmovnle cmovnle() => default;

        public readonly struct Cmovno : IAsmInstruction<Cmovno>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNO;

            public static implicit operator AsmMnemonicCode(Cmovno src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovno src) => AsmMnemonics.CMOVNO;
        }

        public static Cmovno cmovno() => default;

        public readonly struct Cmovnp : IAsmInstruction<Cmovnp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNP;

            public static implicit operator AsmMnemonicCode(Cmovnp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnp src) => AsmMnemonics.CMOVNP;
        }

        public static Cmovnp cmovnp() => default;

        public readonly struct Cmovns : IAsmInstruction<Cmovns>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNS;

            public static implicit operator AsmMnemonicCode(Cmovns src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovns src) => AsmMnemonics.CMOVNS;
        }

        public static Cmovns cmovns() => default;

        public readonly struct Cmovnz : IAsmInstruction<Cmovnz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNZ;

            public static implicit operator AsmMnemonicCode(Cmovnz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovnz src) => AsmMnemonics.CMOVNZ;
        }

        public static Cmovnz cmovnz() => default;

        public readonly struct Cmovo : IAsmInstruction<Cmovo>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVO;

            public static implicit operator AsmMnemonicCode(Cmovo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovo src) => AsmMnemonics.CMOVO;
        }

        public static Cmovo cmovo() => default;

        public readonly struct Cmovp : IAsmInstruction<Cmovp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVP;

            public static implicit operator AsmMnemonicCode(Cmovp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovp src) => AsmMnemonics.CMOVP;
        }

        public static Cmovp cmovp() => default;

        public readonly struct Cmovpe : IAsmInstruction<Cmovpe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVPE;

            public static implicit operator AsmMnemonicCode(Cmovpe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovpe src) => AsmMnemonics.CMOVPE;
        }

        public static Cmovpe cmovpe() => default;

        public readonly struct Cmovpo : IAsmInstruction<Cmovpo>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVPO;

            public static implicit operator AsmMnemonicCode(Cmovpo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovpo src) => AsmMnemonics.CMOVPO;
        }

        public static Cmovpo cmovpo() => default;

        public readonly struct Cmovs : IAsmInstruction<Cmovs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVS;

            public static implicit operator AsmMnemonicCode(Cmovs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovs src) => AsmMnemonics.CMOVS;
        }

        public static Cmovs cmovs() => default;

        public readonly struct Cmovz : IAsmInstruction<Cmovz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVZ;

            public static implicit operator AsmMnemonicCode(Cmovz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmovz src) => AsmMnemonics.CMOVZ;
        }

        public static Cmovz cmovz() => default;

        public readonly struct Cmp : IAsmInstruction<Cmp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMP;

            public static implicit operator AsmMnemonicCode(Cmp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmp src) => AsmMnemonics.CMP;
        }

        public static Cmp cmp() => default;

        public readonly struct Cmppd : IAsmInstruction<Cmppd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPPD;

            public static implicit operator AsmMnemonicCode(Cmppd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmppd src) => AsmMnemonics.CMPPD;
        }

        public static Cmppd cmppd() => default;

        public readonly struct Vcmppd : IAsmInstruction<Vcmppd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPPD;

            public static implicit operator AsmMnemonicCode(Vcmppd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcmppd src) => AsmMnemonics.VCMPPD;
        }

        public static Vcmppd vcmppd() => default;

        public readonly struct Cmpps : IAsmInstruction<Cmpps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPPS;

            public static implicit operator AsmMnemonicCode(Cmpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpps src) => AsmMnemonics.CMPPS;
        }

        public static Cmpps cmpps() => default;

        public readonly struct Vcmpps : IAsmInstruction<Vcmpps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPPS;

            public static implicit operator AsmMnemonicCode(Vcmpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcmpps src) => AsmMnemonics.VCMPPS;
        }

        public static Vcmpps vcmpps() => default;

        public readonly struct Cmps : IAsmInstruction<Cmps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPS;

            public static implicit operator AsmMnemonicCode(Cmps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmps src) => AsmMnemonics.CMPS;
        }

        public static Cmps cmps() => default;

        public readonly struct Cmpsd : IAsmInstruction<Cmpsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSD;

            public static implicit operator AsmMnemonicCode(Cmpsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpsd src) => AsmMnemonics.CMPSD;
        }

        public static Cmpsd cmpsd() => default;

        public readonly struct Vcmpsd : IAsmInstruction<Vcmpsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPSD;

            public static implicit operator AsmMnemonicCode(Vcmpsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcmpsd src) => AsmMnemonics.VCMPSD;
        }

        public static Vcmpsd vcmpsd() => default;

        public readonly struct Cmpss : IAsmInstruction<Cmpss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSS;

            public static implicit operator AsmMnemonicCode(Cmpss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpss src) => AsmMnemonics.CMPSS;
        }

        public static Cmpss cmpss() => default;

        public readonly struct Vcmpss : IAsmInstruction<Vcmpss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPSS;

            public static implicit operator AsmMnemonicCode(Vcmpss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcmpss src) => AsmMnemonics.VCMPSS;
        }

        public static Vcmpss vcmpss() => default;

        public readonly struct Cmpxchg : IAsmInstruction<Cmpxchg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPXCHG;

            public static implicit operator AsmMnemonicCode(Cmpxchg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpxchg src) => AsmMnemonics.CMPXCHG;
        }

        public static Cmpxchg cmpxchg() => default;

        public readonly struct Cmpxchg8b : IAsmInstruction<Cmpxchg8b>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPXCHG8B;

            public static implicit operator AsmMnemonicCode(Cmpxchg8b src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpxchg8b src) => AsmMnemonics.CMPXCHG8B;
        }

        public static Cmpxchg8b cmpxchg8b() => default;

        public readonly struct Cmpxchg16b : IAsmInstruction<Cmpxchg16b>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPXCHG16B;

            public static implicit operator AsmMnemonicCode(Cmpxchg16b src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cmpxchg16b src) => AsmMnemonics.CMPXCHG16B;
        }

        public static Cmpxchg16b cmpxchg16b() => default;

        public readonly struct Comisd : IAsmInstruction<Comisd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.COMISD;

            public static implicit operator AsmMnemonicCode(Comisd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Comisd src) => AsmMnemonics.COMISD;
        }

        public static Comisd comisd() => default;

        public readonly struct Vcomisd : IAsmInstruction<Vcomisd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCOMISD;

            public static implicit operator AsmMnemonicCode(Vcomisd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcomisd src) => AsmMnemonics.VCOMISD;
        }

        public static Vcomisd vcomisd() => default;

        public readonly struct Comiss : IAsmInstruction<Comiss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.COMISS;

            public static implicit operator AsmMnemonicCode(Comiss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Comiss src) => AsmMnemonics.COMISS;
        }

        public static Comiss comiss() => default;

        public readonly struct Vcomiss : IAsmInstruction<Vcomiss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCOMISS;

            public static implicit operator AsmMnemonicCode(Vcomiss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcomiss src) => AsmMnemonics.VCOMISS;
        }

        public static Vcomiss vcomiss() => default;

        public readonly struct Crc32 : IAsmInstruction<Crc32>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CRC32;

            public static implicit operator AsmMnemonicCode(Crc32 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Crc32 src) => AsmMnemonics.CRC32;
        }

        public static Crc32 crc32() => default;

        public readonly struct Cvtdq2pd : IAsmInstruction<Cvtdq2pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTDQ2PD;

            public static implicit operator AsmMnemonicCode(Cvtdq2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtdq2pd src) => AsmMnemonics.CVTDQ2PD;
        }

        public static Cvtdq2pd cvtdq2pd() => default;

        public readonly struct Vcvtdq2pd : IAsmInstruction<Vcvtdq2pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTDQ2PD;

            public static implicit operator AsmMnemonicCode(Vcvtdq2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtdq2pd src) => AsmMnemonics.VCVTDQ2PD;
        }

        public static Vcvtdq2pd vcvtdq2pd() => default;

        public readonly struct Cvtdq2ps : IAsmInstruction<Cvtdq2ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTDQ2PS;

            public static implicit operator AsmMnemonicCode(Cvtdq2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtdq2ps src) => AsmMnemonics.CVTDQ2PS;
        }

        public static Cvtdq2ps cvtdq2ps() => default;

        public readonly struct Vcvtdq2ps : IAsmInstruction<Vcvtdq2ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTDQ2PS;

            public static implicit operator AsmMnemonicCode(Vcvtdq2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtdq2ps src) => AsmMnemonics.VCVTDQ2PS;
        }

        public static Vcvtdq2ps vcvtdq2ps() => default;

        public readonly struct Cvtpd2dq : IAsmInstruction<Cvtpd2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPD2DQ;

            public static implicit operator AsmMnemonicCode(Cvtpd2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpd2dq src) => AsmMnemonics.CVTPD2DQ;
        }

        public static Cvtpd2dq cvtpd2dq() => default;

        public readonly struct Vcvtpd2dq : IAsmInstruction<Vcvtpd2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPD2DQ;

            public static implicit operator AsmMnemonicCode(Vcvtpd2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtpd2dq src) => AsmMnemonics.VCVTPD2DQ;
        }

        public static Vcvtpd2dq vcvtpd2dq() => default;

        public readonly struct Cvtpd2pi : IAsmInstruction<Cvtpd2pi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPD2PI;

            public static implicit operator AsmMnemonicCode(Cvtpd2pi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpd2pi src) => AsmMnemonics.CVTPD2PI;
        }

        public static Cvtpd2pi cvtpd2pi() => default;

        public readonly struct Cvtpd2ps : IAsmInstruction<Cvtpd2ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPD2PS;

            public static implicit operator AsmMnemonicCode(Cvtpd2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpd2ps src) => AsmMnemonics.CVTPD2PS;
        }

        public static Cvtpd2ps cvtpd2ps() => default;

        public readonly struct Vcvtpd2ps : IAsmInstruction<Vcvtpd2ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPD2PS;

            public static implicit operator AsmMnemonicCode(Vcvtpd2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtpd2ps src) => AsmMnemonics.VCVTPD2PS;
        }

        public static Vcvtpd2ps vcvtpd2ps() => default;

        public readonly struct Cvtpi2pd : IAsmInstruction<Cvtpi2pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPI2PD;

            public static implicit operator AsmMnemonicCode(Cvtpi2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpi2pd src) => AsmMnemonics.CVTPI2PD;
        }

        public static Cvtpi2pd cvtpi2pd() => default;

        public readonly struct Cvtpi2ps : IAsmInstruction<Cvtpi2ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPI2PS;

            public static implicit operator AsmMnemonicCode(Cvtpi2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtpi2ps src) => AsmMnemonics.CVTPI2PS;
        }

        public static Cvtpi2ps cvtpi2ps() => default;

        public readonly struct Cvtps2dq : IAsmInstruction<Cvtps2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPS2DQ;

            public static implicit operator AsmMnemonicCode(Cvtps2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtps2dq src) => AsmMnemonics.CVTPS2DQ;
        }

        public static Cvtps2dq cvtps2dq() => default;

        public readonly struct Vcvtps2dq : IAsmInstruction<Vcvtps2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPS2DQ;

            public static implicit operator AsmMnemonicCode(Vcvtps2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtps2dq src) => AsmMnemonics.VCVTPS2DQ;
        }

        public static Vcvtps2dq vcvtps2dq() => default;

        public readonly struct Cvtps2pd : IAsmInstruction<Cvtps2pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPS2PD;

            public static implicit operator AsmMnemonicCode(Cvtps2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtps2pd src) => AsmMnemonics.CVTPS2PD;
        }

        public static Cvtps2pd cvtps2pd() => default;

        public readonly struct Vcvtps2pd : IAsmInstruction<Vcvtps2pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPS2PD;

            public static implicit operator AsmMnemonicCode(Vcvtps2pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtps2pd src) => AsmMnemonics.VCVTPS2PD;
        }

        public static Vcvtps2pd vcvtps2pd() => default;

        public readonly struct Cvtps2pi : IAsmInstruction<Cvtps2pi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPS2PI;

            public static implicit operator AsmMnemonicCode(Cvtps2pi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtps2pi src) => AsmMnemonics.CVTPS2PI;
        }

        public static Cvtps2pi cvtps2pi() => default;

        public readonly struct Cvtsd2si : IAsmInstruction<Cvtsd2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSD2SI;

            public static implicit operator AsmMnemonicCode(Cvtsd2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtsd2si src) => AsmMnemonics.CVTSD2SI;
        }

        public static Cvtsd2si cvtsd2si() => default;

        public readonly struct Vcvtsd2si : IAsmInstruction<Vcvtsd2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSD2SI;

            public static implicit operator AsmMnemonicCode(Vcvtsd2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtsd2si src) => AsmMnemonics.VCVTSD2SI;
        }

        public static Vcvtsd2si vcvtsd2si() => default;

        public readonly struct Cvtsd2ss : IAsmInstruction<Cvtsd2ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSD2SS;

            public static implicit operator AsmMnemonicCode(Cvtsd2ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtsd2ss src) => AsmMnemonics.CVTSD2SS;
        }

        public static Cvtsd2ss cvtsd2ss() => default;

        public readonly struct Vcvtsd2ss : IAsmInstruction<Vcvtsd2ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSD2SS;

            public static implicit operator AsmMnemonicCode(Vcvtsd2ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtsd2ss src) => AsmMnemonics.VCVTSD2SS;
        }

        public static Vcvtsd2ss vcvtsd2ss() => default;

        public readonly struct Cvtsi2sd : IAsmInstruction<Cvtsi2sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSI2SD;

            public static implicit operator AsmMnemonicCode(Cvtsi2sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtsi2sd src) => AsmMnemonics.CVTSI2SD;
        }

        public static Cvtsi2sd cvtsi2sd() => default;

        public readonly struct Vcvtsi2sd : IAsmInstruction<Vcvtsi2sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSI2SD;

            public static implicit operator AsmMnemonicCode(Vcvtsi2sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtsi2sd src) => AsmMnemonics.VCVTSI2SD;
        }

        public static Vcvtsi2sd vcvtsi2sd() => default;

        public readonly struct Cvtsi2ss : IAsmInstruction<Cvtsi2ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSI2SS;

            public static implicit operator AsmMnemonicCode(Cvtsi2ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtsi2ss src) => AsmMnemonics.CVTSI2SS;
        }

        public static Cvtsi2ss cvtsi2ss() => default;

        public readonly struct Vcvtsi2ss : IAsmInstruction<Vcvtsi2ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSI2SS;

            public static implicit operator AsmMnemonicCode(Vcvtsi2ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtsi2ss src) => AsmMnemonics.VCVTSI2SS;
        }

        public static Vcvtsi2ss vcvtsi2ss() => default;

        public readonly struct Cvtss2sd : IAsmInstruction<Cvtss2sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSS2SD;

            public static implicit operator AsmMnemonicCode(Cvtss2sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtss2sd src) => AsmMnemonics.CVTSS2SD;
        }

        public static Cvtss2sd cvtss2sd() => default;

        public readonly struct Vcvtss2sd : IAsmInstruction<Vcvtss2sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSS2SD;

            public static implicit operator AsmMnemonicCode(Vcvtss2sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtss2sd src) => AsmMnemonics.VCVTSS2SD;
        }

        public static Vcvtss2sd vcvtss2sd() => default;

        public readonly struct Cvtss2si : IAsmInstruction<Cvtss2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSS2SI;

            public static implicit operator AsmMnemonicCode(Cvtss2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvtss2si src) => AsmMnemonics.CVTSS2SI;
        }

        public static Cvtss2si cvtss2si() => default;

        public readonly struct Vcvtss2si : IAsmInstruction<Vcvtss2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSS2SI;

            public static implicit operator AsmMnemonicCode(Vcvtss2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtss2si src) => AsmMnemonics.VCVTSS2SI;
        }

        public static Vcvtss2si vcvtss2si() => default;

        public readonly struct Cvttpd2dq : IAsmInstruction<Cvttpd2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPD2DQ;

            public static implicit operator AsmMnemonicCode(Cvttpd2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttpd2dq src) => AsmMnemonics.CVTTPD2DQ;
        }

        public static Cvttpd2dq cvttpd2dq() => default;

        public readonly struct Vcvttpd2dq : IAsmInstruction<Vcvttpd2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTPD2DQ;

            public static implicit operator AsmMnemonicCode(Vcvttpd2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvttpd2dq src) => AsmMnemonics.VCVTTPD2DQ;
        }

        public static Vcvttpd2dq vcvttpd2dq() => default;

        public readonly struct Cvttpd2pi : IAsmInstruction<Cvttpd2pi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPD2PI;

            public static implicit operator AsmMnemonicCode(Cvttpd2pi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttpd2pi src) => AsmMnemonics.CVTTPD2PI;
        }

        public static Cvttpd2pi cvttpd2pi() => default;

        public readonly struct Cvttps2dq : IAsmInstruction<Cvttps2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPS2DQ;

            public static implicit operator AsmMnemonicCode(Cvttps2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttps2dq src) => AsmMnemonics.CVTTPS2DQ;
        }

        public static Cvttps2dq cvttps2dq() => default;

        public readonly struct Vcvttps2dq : IAsmInstruction<Vcvttps2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTPS2DQ;

            public static implicit operator AsmMnemonicCode(Vcvttps2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvttps2dq src) => AsmMnemonics.VCVTTPS2DQ;
        }

        public static Vcvttps2dq vcvttps2dq() => default;

        public readonly struct Cvttps2pi : IAsmInstruction<Cvttps2pi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPS2PI;

            public static implicit operator AsmMnemonicCode(Cvttps2pi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttps2pi src) => AsmMnemonics.CVTTPS2PI;
        }

        public static Cvttps2pi cvttps2pi() => default;

        public readonly struct Cvttsd2si : IAsmInstruction<Cvttsd2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTSD2SI;

            public static implicit operator AsmMnemonicCode(Cvttsd2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttsd2si src) => AsmMnemonics.CVTTSD2SI;
        }

        public static Cvttsd2si cvttsd2si() => default;

        public readonly struct Vcvttsd2si : IAsmInstruction<Vcvttsd2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTSD2SI;

            public static implicit operator AsmMnemonicCode(Vcvttsd2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvttsd2si src) => AsmMnemonics.VCVTTSD2SI;
        }

        public static Vcvttsd2si vcvttsd2si() => default;

        public readonly struct Cvttss2si : IAsmInstruction<Cvttss2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTSS2SI;

            public static implicit operator AsmMnemonicCode(Cvttss2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Cvttss2si src) => AsmMnemonics.CVTTSS2SI;
        }

        public static Cvttss2si cvttss2si() => default;

        public readonly struct Vcvttss2si : IAsmInstruction<Vcvttss2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTSS2SI;

            public static implicit operator AsmMnemonicCode(Vcvttss2si src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvttss2si src) => AsmMnemonics.VCVTTSS2SI;
        }

        public static Vcvttss2si vcvttss2si() => default;

        public readonly struct Dec : IAsmInstruction<Dec>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DEC;

            public static implicit operator AsmMnemonicCode(Dec src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Dec src) => AsmMnemonics.DEC;
        }

        public static Dec dec() => default;

        public readonly struct Div : IAsmInstruction<Div>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIV;

            public static implicit operator AsmMnemonicCode(Div src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Div src) => AsmMnemonics.DIV;
        }

        public static Div div() => default;

        public readonly struct Divpd : IAsmInstruction<Divpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVPD;

            public static implicit operator AsmMnemonicCode(Divpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Divpd src) => AsmMnemonics.DIVPD;
        }

        public static Divpd divpd() => default;

        public readonly struct Vdivpd : IAsmInstruction<Vdivpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVPD;

            public static implicit operator AsmMnemonicCode(Vdivpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdivpd src) => AsmMnemonics.VDIVPD;
        }

        public static Vdivpd vdivpd() => default;

        public readonly struct Divps : IAsmInstruction<Divps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVPS;

            public static implicit operator AsmMnemonicCode(Divps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Divps src) => AsmMnemonics.DIVPS;
        }

        public static Divps divps() => default;

        public readonly struct Vdivps : IAsmInstruction<Vdivps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVPS;

            public static implicit operator AsmMnemonicCode(Vdivps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdivps src) => AsmMnemonics.VDIVPS;
        }

        public static Vdivps vdivps() => default;

        public readonly struct Divsd : IAsmInstruction<Divsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVSD;

            public static implicit operator AsmMnemonicCode(Divsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Divsd src) => AsmMnemonics.DIVSD;
        }

        public static Divsd divsd() => default;

        public readonly struct Vdivsd : IAsmInstruction<Vdivsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVSD;

            public static implicit operator AsmMnemonicCode(Vdivsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdivsd src) => AsmMnemonics.VDIVSD;
        }

        public static Vdivsd vdivsd() => default;

        public readonly struct Divss : IAsmInstruction<Divss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVSS;

            public static implicit operator AsmMnemonicCode(Divss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Divss src) => AsmMnemonics.DIVSS;
        }

        public static Divss divss() => default;

        public readonly struct Vdivss : IAsmInstruction<Vdivss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVSS;

            public static implicit operator AsmMnemonicCode(Vdivss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdivss src) => AsmMnemonics.VDIVSS;
        }

        public static Vdivss vdivss() => default;

        public readonly struct Dppd : IAsmInstruction<Dppd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DPPD;

            public static implicit operator AsmMnemonicCode(Dppd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Dppd src) => AsmMnemonics.DPPD;
        }

        public static Dppd dppd() => default;

        public readonly struct Vdppd : IAsmInstruction<Vdppd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDPPD;

            public static implicit operator AsmMnemonicCode(Vdppd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdppd src) => AsmMnemonics.VDPPD;
        }

        public static Vdppd vdppd() => default;

        public readonly struct Dpps : IAsmInstruction<Dpps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DPPS;

            public static implicit operator AsmMnemonicCode(Dpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Dpps src) => AsmMnemonics.DPPS;
        }

        public static Dpps dpps() => default;

        public readonly struct Vdpps : IAsmInstruction<Vdpps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDPPS;

            public static implicit operator AsmMnemonicCode(Vdpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vdpps src) => AsmMnemonics.VDPPS;
        }

        public static Vdpps vdpps() => default;

        public readonly struct Enter : IAsmInstruction<Enter>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ENTER;

            public static implicit operator AsmMnemonicCode(Enter src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Enter src) => AsmMnemonics.ENTER;
        }

        public static Enter enter() => default;

        public readonly struct Extractps : IAsmInstruction<Extractps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.EXTRACTPS;

            public static implicit operator AsmMnemonicCode(Extractps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Extractps src) => AsmMnemonics.EXTRACTPS;
        }

        public static Extractps extractps() => default;

        public readonly struct Vextractps : IAsmInstruction<Vextractps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VEXTRACTPS;

            public static implicit operator AsmMnemonicCode(Vextractps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vextractps src) => AsmMnemonics.VEXTRACTPS;
        }

        public static Vextractps vextractps() => default;

        public readonly struct Fadd : IAsmInstruction<Fadd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FADD;

            public static implicit operator AsmMnemonicCode(Fadd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fadd src) => AsmMnemonics.FADD;
        }

        public static Fadd fadd() => default;

        public readonly struct Faddp : IAsmInstruction<Faddp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FADDP;

            public static implicit operator AsmMnemonicCode(Faddp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Faddp src) => AsmMnemonics.FADDP;
        }

        public static Faddp faddp() => default;

        public readonly struct Fiadd : IAsmInstruction<Fiadd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIADD;

            public static implicit operator AsmMnemonicCode(Fiadd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fiadd src) => AsmMnemonics.FIADD;
        }

        public static Fiadd fiadd() => default;

        public readonly struct Fbld : IAsmInstruction<Fbld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FBLD;

            public static implicit operator AsmMnemonicCode(Fbld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fbld src) => AsmMnemonics.FBLD;
        }

        public static Fbld fbld() => default;

        public readonly struct Fbstp : IAsmInstruction<Fbstp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FBSTP;

            public static implicit operator AsmMnemonicCode(Fbstp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fbstp src) => AsmMnemonics.FBSTP;
        }

        public static Fbstp fbstp() => default;

        public readonly struct Fcmovb : IAsmInstruction<Fcmovb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVB;

            public static implicit operator AsmMnemonicCode(Fcmovb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovb src) => AsmMnemonics.FCMOVB;
        }

        public static Fcmovb fcmovb() => default;

        public readonly struct Fcmove : IAsmInstruction<Fcmove>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVE;

            public static implicit operator AsmMnemonicCode(Fcmove src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmove src) => AsmMnemonics.FCMOVE;
        }

        public static Fcmove fcmove() => default;

        public readonly struct Fcmovbe : IAsmInstruction<Fcmovbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVBE;

            public static implicit operator AsmMnemonicCode(Fcmovbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovbe src) => AsmMnemonics.FCMOVBE;
        }

        public static Fcmovbe fcmovbe() => default;

        public readonly struct Fcmovu : IAsmInstruction<Fcmovu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVU;

            public static implicit operator AsmMnemonicCode(Fcmovu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovu src) => AsmMnemonics.FCMOVU;
        }

        public static Fcmovu fcmovu() => default;

        public readonly struct Fcmovnb : IAsmInstruction<Fcmovnb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNB;

            public static implicit operator AsmMnemonicCode(Fcmovnb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovnb src) => AsmMnemonics.FCMOVNB;
        }

        public static Fcmovnb fcmovnb() => default;

        public readonly struct Fcmovne : IAsmInstruction<Fcmovne>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNE;

            public static implicit operator AsmMnemonicCode(Fcmovne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovne src) => AsmMnemonics.FCMOVNE;
        }

        public static Fcmovne fcmovne() => default;

        public readonly struct Fcmovnbe : IAsmInstruction<Fcmovnbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNBE;

            public static implicit operator AsmMnemonicCode(Fcmovnbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovnbe src) => AsmMnemonics.FCMOVNBE;
        }

        public static Fcmovnbe fcmovnbe() => default;

        public readonly struct Fcmovnu : IAsmInstruction<Fcmovnu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNU;

            public static implicit operator AsmMnemonicCode(Fcmovnu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcmovnu src) => AsmMnemonics.FCMOVNU;
        }

        public static Fcmovnu fcmovnu() => default;

        public readonly struct Fcom : IAsmInstruction<Fcom>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOM;

            public static implicit operator AsmMnemonicCode(Fcom src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcom src) => AsmMnemonics.FCOM;
        }

        public static Fcom fcom() => default;

        public readonly struct Fcomp : IAsmInstruction<Fcomp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMP;

            public static implicit operator AsmMnemonicCode(Fcomp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcomp src) => AsmMnemonics.FCOMP;
        }

        public static Fcomp fcomp() => default;

        public readonly struct Fcomi : IAsmInstruction<Fcomi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMI;

            public static implicit operator AsmMnemonicCode(Fcomi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcomi src) => AsmMnemonics.FCOMI;
        }

        public static Fcomi fcomi() => default;

        public readonly struct Fcomip : IAsmInstruction<Fcomip>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMIP;

            public static implicit operator AsmMnemonicCode(Fcomip src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fcomip src) => AsmMnemonics.FCOMIP;
        }

        public static Fcomip fcomip() => default;

        public readonly struct Fucomi : IAsmInstruction<Fucomi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMI;

            public static implicit operator AsmMnemonicCode(Fucomi src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucomi src) => AsmMnemonics.FUCOMI;
        }

        public static Fucomi fucomi() => default;

        public readonly struct Fucomip : IAsmInstruction<Fucomip>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMIP;

            public static implicit operator AsmMnemonicCode(Fucomip src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucomip src) => AsmMnemonics.FUCOMIP;
        }

        public static Fucomip fucomip() => default;

        public readonly struct Fdiv : IAsmInstruction<Fdiv>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIV;

            public static implicit operator AsmMnemonicCode(Fdiv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdiv src) => AsmMnemonics.FDIV;
        }

        public static Fdiv fdiv() => default;

        public readonly struct Fdivp : IAsmInstruction<Fdivp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIVP;

            public static implicit operator AsmMnemonicCode(Fdivp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdivp src) => AsmMnemonics.FDIVP;
        }

        public static Fdivp fdivp() => default;

        public readonly struct Fidiv : IAsmInstruction<Fidiv>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIDIV;

            public static implicit operator AsmMnemonicCode(Fidiv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fidiv src) => AsmMnemonics.FIDIV;
        }

        public static Fidiv fidiv() => default;

        public readonly struct Fdivr : IAsmInstruction<Fdivr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIVR;

            public static implicit operator AsmMnemonicCode(Fdivr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdivr src) => AsmMnemonics.FDIVR;
        }

        public static Fdivr fdivr() => default;

        public readonly struct Fdivrp : IAsmInstruction<Fdivrp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIVRP;

            public static implicit operator AsmMnemonicCode(Fdivrp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fdivrp src) => AsmMnemonics.FDIVRP;
        }

        public static Fdivrp fdivrp() => default;

        public readonly struct Fidivr : IAsmInstruction<Fidivr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIDIVR;

            public static implicit operator AsmMnemonicCode(Fidivr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fidivr src) => AsmMnemonics.FIDIVR;
        }

        public static Fidivr fidivr() => default;

        public readonly struct Ffree : IAsmInstruction<Ffree>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FFREE;

            public static implicit operator AsmMnemonicCode(Ffree src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ffree src) => AsmMnemonics.FFREE;
        }

        public static Ffree ffree() => default;

        public readonly struct Ficom : IAsmInstruction<Ficom>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FICOM;

            public static implicit operator AsmMnemonicCode(Ficom src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ficom src) => AsmMnemonics.FICOM;
        }

        public static Ficom ficom() => default;

        public readonly struct Ficomp : IAsmInstruction<Ficomp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FICOMP;

            public static implicit operator AsmMnemonicCode(Ficomp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ficomp src) => AsmMnemonics.FICOMP;
        }

        public static Ficomp ficomp() => default;

        public readonly struct Fild : IAsmInstruction<Fild>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FILD;

            public static implicit operator AsmMnemonicCode(Fild src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fild src) => AsmMnemonics.FILD;
        }

        public static Fild fild() => default;

        public readonly struct Fist : IAsmInstruction<Fist>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIST;

            public static implicit operator AsmMnemonicCode(Fist src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fist src) => AsmMnemonics.FIST;
        }

        public static Fist fist() => default;

        public readonly struct Fistp : IAsmInstruction<Fistp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISTP;

            public static implicit operator AsmMnemonicCode(Fistp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fistp src) => AsmMnemonics.FISTP;
        }

        public static Fistp fistp() => default;

        public readonly struct Fisttp : IAsmInstruction<Fisttp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISTTP;

            public static implicit operator AsmMnemonicCode(Fisttp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fisttp src) => AsmMnemonics.FISTTP;
        }

        public static Fisttp fisttp() => default;

        public readonly struct Fld : IAsmInstruction<Fld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLD;

            public static implicit operator AsmMnemonicCode(Fld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fld src) => AsmMnemonics.FLD;
        }

        public static Fld fld() => default;

        public readonly struct Fldcw : IAsmInstruction<Fldcw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDCW;

            public static implicit operator AsmMnemonicCode(Fldcw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldcw src) => AsmMnemonics.FLDCW;
        }

        public static Fldcw fldcw() => default;

        public readonly struct Fldenv : IAsmInstruction<Fldenv>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDENV;

            public static implicit operator AsmMnemonicCode(Fldenv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fldenv src) => AsmMnemonics.FLDENV;
        }

        public static Fldenv fldenv() => default;

        public readonly struct Fmul : IAsmInstruction<Fmul>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FMUL;

            public static implicit operator AsmMnemonicCode(Fmul src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fmul src) => AsmMnemonics.FMUL;
        }

        public static Fmul fmul() => default;

        public readonly struct Fmulp : IAsmInstruction<Fmulp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FMULP;

            public static implicit operator AsmMnemonicCode(Fmulp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fmulp src) => AsmMnemonics.FMULP;
        }

        public static Fmulp fmulp() => default;

        public readonly struct Fimul : IAsmInstruction<Fimul>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIMUL;

            public static implicit operator AsmMnemonicCode(Fimul src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fimul src) => AsmMnemonics.FIMUL;
        }

        public static Fimul fimul() => default;

        public readonly struct Frstor : IAsmInstruction<Frstor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FRSTOR;

            public static implicit operator AsmMnemonicCode(Frstor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Frstor src) => AsmMnemonics.FRSTOR;
        }

        public static Frstor frstor() => default;

        public readonly struct Fsave : IAsmInstruction<Fsave>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSAVE;

            public static implicit operator AsmMnemonicCode(Fsave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsave src) => AsmMnemonics.FSAVE;
        }

        public static Fsave fsave() => default;

        public readonly struct Fnsave : IAsmInstruction<Fnsave>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSAVE;

            public static implicit operator AsmMnemonicCode(Fnsave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnsave src) => AsmMnemonics.FNSAVE;
        }

        public static Fnsave fnsave() => default;

        public readonly struct Fst : IAsmInstruction<Fst>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FST;

            public static implicit operator AsmMnemonicCode(Fst src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fst src) => AsmMnemonics.FST;
        }

        public static Fst fst() => default;

        public readonly struct Fstp : IAsmInstruction<Fstp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTP;

            public static implicit operator AsmMnemonicCode(Fstp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fstp src) => AsmMnemonics.FSTP;
        }

        public static Fstp fstp() => default;

        public readonly struct Fstcw : IAsmInstruction<Fstcw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTCW;

            public static implicit operator AsmMnemonicCode(Fstcw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fstcw src) => AsmMnemonics.FSTCW;
        }

        public static Fstcw fstcw() => default;

        public readonly struct Fnstcw : IAsmInstruction<Fnstcw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSTCW;

            public static implicit operator AsmMnemonicCode(Fnstcw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnstcw src) => AsmMnemonics.FNSTCW;
        }

        public static Fnstcw fnstcw() => default;

        public readonly struct Fstenv : IAsmInstruction<Fstenv>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTENV;

            public static implicit operator AsmMnemonicCode(Fstenv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fstenv src) => AsmMnemonics.FSTENV;
        }

        public static Fstenv fstenv() => default;

        public readonly struct Fnstenv : IAsmInstruction<Fnstenv>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSTENV;

            public static implicit operator AsmMnemonicCode(Fnstenv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnstenv src) => AsmMnemonics.FNSTENV;
        }

        public static Fnstenv fnstenv() => default;

        public readonly struct Fstsw : IAsmInstruction<Fstsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTSW;

            public static implicit operator AsmMnemonicCode(Fstsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fstsw src) => AsmMnemonics.FSTSW;
        }

        public static Fstsw fstsw() => default;

        public readonly struct Fnstsw : IAsmInstruction<Fnstsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSTSW;

            public static implicit operator AsmMnemonicCode(Fnstsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fnstsw src) => AsmMnemonics.FNSTSW;
        }

        public static Fnstsw fnstsw() => default;

        public readonly struct Fsub : IAsmInstruction<Fsub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUB;

            public static implicit operator AsmMnemonicCode(Fsub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsub src) => AsmMnemonics.FSUB;
        }

        public static Fsub fsub() => default;

        public readonly struct Fsubp : IAsmInstruction<Fsubp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUBP;

            public static implicit operator AsmMnemonicCode(Fsubp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsubp src) => AsmMnemonics.FSUBP;
        }

        public static Fsubp fsubp() => default;

        public readonly struct Fisub : IAsmInstruction<Fisub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISUB;

            public static implicit operator AsmMnemonicCode(Fisub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fisub src) => AsmMnemonics.FISUB;
        }

        public static Fisub fisub() => default;

        public readonly struct Fsubr : IAsmInstruction<Fsubr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUBR;

            public static implicit operator AsmMnemonicCode(Fsubr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsubr src) => AsmMnemonics.FSUBR;
        }

        public static Fsubr fsubr() => default;

        public readonly struct Fsubrp : IAsmInstruction<Fsubrp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUBRP;

            public static implicit operator AsmMnemonicCode(Fsubrp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fsubrp src) => AsmMnemonics.FSUBRP;
        }

        public static Fsubrp fsubrp() => default;

        public readonly struct Fisubr : IAsmInstruction<Fisubr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISUBR;

            public static implicit operator AsmMnemonicCode(Fisubr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fisubr src) => AsmMnemonics.FISUBR;
        }

        public static Fisubr fisubr() => default;

        public readonly struct Fucom : IAsmInstruction<Fucom>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOM;

            public static implicit operator AsmMnemonicCode(Fucom src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucom src) => AsmMnemonics.FUCOM;
        }

        public static Fucom fucom() => default;

        public readonly struct Fucomp : IAsmInstruction<Fucomp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMP;

            public static implicit operator AsmMnemonicCode(Fucomp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fucomp src) => AsmMnemonics.FUCOMP;
        }

        public static Fucomp fucomp() => default;

        public readonly struct Fxch : IAsmInstruction<Fxch>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXCH;

            public static implicit operator AsmMnemonicCode(Fxch src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxch src) => AsmMnemonics.FXCH;
        }

        public static Fxch fxch() => default;

        public readonly struct Fxrstor : IAsmInstruction<Fxrstor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXRSTOR;

            public static implicit operator AsmMnemonicCode(Fxrstor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxrstor src) => AsmMnemonics.FXRSTOR;
        }

        public static Fxrstor fxrstor() => default;

        public readonly struct Fxrstor64 : IAsmInstruction<Fxrstor64>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXRSTOR64;

            public static implicit operator AsmMnemonicCode(Fxrstor64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxrstor64 src) => AsmMnemonics.FXRSTOR64;
        }

        public static Fxrstor64 fxrstor64() => default;

        public readonly struct Fxsave : IAsmInstruction<Fxsave>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXSAVE;

            public static implicit operator AsmMnemonicCode(Fxsave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxsave src) => AsmMnemonics.FXSAVE;
        }

        public static Fxsave fxsave() => default;

        public readonly struct Fxsave64 : IAsmInstruction<Fxsave64>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXSAVE64;

            public static implicit operator AsmMnemonicCode(Fxsave64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Fxsave64 src) => AsmMnemonics.FXSAVE64;
        }

        public static Fxsave64 fxsave64() => default;

        public readonly struct Haddpd : IAsmInstruction<Haddpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HADDPD;

            public static implicit operator AsmMnemonicCode(Haddpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Haddpd src) => AsmMnemonics.HADDPD;
        }

        public static Haddpd haddpd() => default;

        public readonly struct Vhaddpd : IAsmInstruction<Vhaddpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHADDPD;

            public static implicit operator AsmMnemonicCode(Vhaddpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vhaddpd src) => AsmMnemonics.VHADDPD;
        }

        public static Vhaddpd vhaddpd() => default;

        public readonly struct Haddps : IAsmInstruction<Haddps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HADDPS;

            public static implicit operator AsmMnemonicCode(Haddps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Haddps src) => AsmMnemonics.HADDPS;
        }

        public static Haddps haddps() => default;

        public readonly struct Vhaddps : IAsmInstruction<Vhaddps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHADDPS;

            public static implicit operator AsmMnemonicCode(Vhaddps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vhaddps src) => AsmMnemonics.VHADDPS;
        }

        public static Vhaddps vhaddps() => default;

        public readonly struct Hsubpd : IAsmInstruction<Hsubpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HSUBPD;

            public static implicit operator AsmMnemonicCode(Hsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Hsubpd src) => AsmMnemonics.HSUBPD;
        }

        public static Hsubpd hsubpd() => default;

        public readonly struct Vhsubpd : IAsmInstruction<Vhsubpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHSUBPD;

            public static implicit operator AsmMnemonicCode(Vhsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vhsubpd src) => AsmMnemonics.VHSUBPD;
        }

        public static Vhsubpd vhsubpd() => default;

        public readonly struct Hsubps : IAsmInstruction<Hsubps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HSUBPS;

            public static implicit operator AsmMnemonicCode(Hsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Hsubps src) => AsmMnemonics.HSUBPS;
        }

        public static Hsubps hsubps() => default;

        public readonly struct Vhsubps : IAsmInstruction<Vhsubps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHSUBPS;

            public static implicit operator AsmMnemonicCode(Vhsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vhsubps src) => AsmMnemonics.VHSUBPS;
        }

        public static Vhsubps vhsubps() => default;

        public readonly struct Idiv : IAsmInstruction<Idiv>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IDIV;

            public static implicit operator AsmMnemonicCode(Idiv src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Idiv src) => AsmMnemonics.IDIV;
        }

        public static Idiv idiv() => default;

        public readonly struct Imul : IAsmInstruction<Imul>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IMUL;

            public static implicit operator AsmMnemonicCode(Imul src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Imul src) => AsmMnemonics.IMUL;
        }

        public static Imul imul() => default;

        public readonly struct In : IAsmInstruction<In>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IN;

            public static implicit operator AsmMnemonicCode(In src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(In src) => AsmMnemonics.IN;
        }

        public static In @in() => default;

        public readonly struct Inc : IAsmInstruction<Inc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INC;

            public static implicit operator AsmMnemonicCode(Inc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Inc src) => AsmMnemonics.INC;
        }

        public static Inc inc() => default;

        public readonly struct Ins : IAsmInstruction<Ins>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INS;

            public static implicit operator AsmMnemonicCode(Ins src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ins src) => AsmMnemonics.INS;
        }

        public static Ins ins() => default;

        public readonly struct Insertps : IAsmInstruction<Insertps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INSERTPS;

            public static implicit operator AsmMnemonicCode(Insertps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Insertps src) => AsmMnemonics.INSERTPS;
        }

        public static Insertps insertps() => default;

        public readonly struct Vinsertps : IAsmInstruction<Vinsertps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VINSERTPS;

            public static implicit operator AsmMnemonicCode(Vinsertps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vinsertps src) => AsmMnemonics.VINSERTPS;
        }

        public static Vinsertps vinsertps() => default;

        public readonly struct Int : IAsmInstruction<Int>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INT;

            public static implicit operator AsmMnemonicCode(Int src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Int src) => AsmMnemonics.INT;
        }

        public static Int @int() => default;

        public readonly struct Invlpg : IAsmInstruction<Invlpg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INVLPG;

            public static implicit operator AsmMnemonicCode(Invlpg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Invlpg src) => AsmMnemonics.INVLPG;
        }

        public static Invlpg invlpg() => default;

        public readonly struct Invpcid : IAsmInstruction<Invpcid>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INVPCID;

            public static implicit operator AsmMnemonicCode(Invpcid src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Invpcid src) => AsmMnemonics.INVPCID;
        }

        public static Invpcid invpcid() => default;

        public readonly struct Ja : IAsmInstruction<Ja>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JA;

            public static implicit operator AsmMnemonicCode(Ja src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ja src) => AsmMnemonics.JA;
        }

        public static Ja ja() => default;

        public readonly struct Jae : IAsmInstruction<Jae>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JAE;

            public static implicit operator AsmMnemonicCode(Jae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jae src) => AsmMnemonics.JAE;
        }

        public static Jae jae() => default;

        public readonly struct Jb : IAsmInstruction<Jb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JB;

            public static implicit operator AsmMnemonicCode(Jb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jb src) => AsmMnemonics.JB;
        }

        public static Jb jb() => default;

        public readonly struct Jbe : IAsmInstruction<Jbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JBE;

            public static implicit operator AsmMnemonicCode(Jbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jbe src) => AsmMnemonics.JBE;
        }

        public static Jbe jbe() => default;

        public readonly struct Jc : IAsmInstruction<Jc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JC;

            public static implicit operator AsmMnemonicCode(Jc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jc src) => AsmMnemonics.JC;
        }

        public static Jc jc() => default;

        public readonly struct Jcxz : IAsmInstruction<Jcxz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JCXZ;

            public static implicit operator AsmMnemonicCode(Jcxz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jcxz src) => AsmMnemonics.JCXZ;
        }

        public static Jcxz jcxz() => default;

        public readonly struct Jecxz : IAsmInstruction<Jecxz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JECXZ;

            public static implicit operator AsmMnemonicCode(Jecxz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jecxz src) => AsmMnemonics.JECXZ;
        }

        public static Jecxz jecxz() => default;

        public readonly struct Jrcxz : IAsmInstruction<Jrcxz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JRCXZ;

            public static implicit operator AsmMnemonicCode(Jrcxz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jrcxz src) => AsmMnemonics.JRCXZ;
        }

        public static Jrcxz jrcxz() => default;

        public readonly struct Je : IAsmInstruction<Je>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JE;

            public static implicit operator AsmMnemonicCode(Je src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Je src) => AsmMnemonics.JE;
        }

        public static Je je() => default;

        public readonly struct Jg : IAsmInstruction<Jg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JG;

            public static implicit operator AsmMnemonicCode(Jg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jg src) => AsmMnemonics.JG;
        }

        public static Jg jg() => default;

        public readonly struct Jge : IAsmInstruction<Jge>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JGE;

            public static implicit operator AsmMnemonicCode(Jge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jge src) => AsmMnemonics.JGE;
        }

        public static Jge jge() => default;

        public readonly struct Jl : IAsmInstruction<Jl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JL;

            public static implicit operator AsmMnemonicCode(Jl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jl src) => AsmMnemonics.JL;
        }

        public static Jl jl() => default;

        public readonly struct Jle : IAsmInstruction<Jle>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JLE;

            public static implicit operator AsmMnemonicCode(Jle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jle src) => AsmMnemonics.JLE;
        }

        public static Jle jle() => default;

        public readonly struct Jna : IAsmInstruction<Jna>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNA;

            public static implicit operator AsmMnemonicCode(Jna src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jna src) => AsmMnemonics.JNA;
        }

        public static Jna jna() => default;

        public readonly struct Jnae : IAsmInstruction<Jnae>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNAE;

            public static implicit operator AsmMnemonicCode(Jnae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnae src) => AsmMnemonics.JNAE;
        }

        public static Jnae jnae() => default;

        public readonly struct Jnb : IAsmInstruction<Jnb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNB;

            public static implicit operator AsmMnemonicCode(Jnb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnb src) => AsmMnemonics.JNB;
        }

        public static Jnb jnb() => default;

        public readonly struct Jnbe : IAsmInstruction<Jnbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNBE;

            public static implicit operator AsmMnemonicCode(Jnbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnbe src) => AsmMnemonics.JNBE;
        }

        public static Jnbe jnbe() => default;

        public readonly struct Jnc : IAsmInstruction<Jnc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNC;

            public static implicit operator AsmMnemonicCode(Jnc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnc src) => AsmMnemonics.JNC;
        }

        public static Jnc jnc() => default;

        public readonly struct Jne : IAsmInstruction<Jne>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNE;

            public static implicit operator AsmMnemonicCode(Jne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jne src) => AsmMnemonics.JNE;
        }

        public static Jne jne() => default;

        public readonly struct Jng : IAsmInstruction<Jng>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNG;

            public static implicit operator AsmMnemonicCode(Jng src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jng src) => AsmMnemonics.JNG;
        }

        public static Jng jng() => default;

        public readonly struct Jnge : IAsmInstruction<Jnge>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNGE;

            public static implicit operator AsmMnemonicCode(Jnge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnge src) => AsmMnemonics.JNGE;
        }

        public static Jnge jnge() => default;

        public readonly struct Jnl : IAsmInstruction<Jnl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNL;

            public static implicit operator AsmMnemonicCode(Jnl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnl src) => AsmMnemonics.JNL;
        }

        public static Jnl jnl() => default;

        public readonly struct Jnle : IAsmInstruction<Jnle>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNLE;

            public static implicit operator AsmMnemonicCode(Jnle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnle src) => AsmMnemonics.JNLE;
        }

        public static Jnle jnle() => default;

        public readonly struct Jno : IAsmInstruction<Jno>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNO;

            public static implicit operator AsmMnemonicCode(Jno src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jno src) => AsmMnemonics.JNO;
        }

        public static Jno jno() => default;

        public readonly struct Jnp : IAsmInstruction<Jnp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNP;

            public static implicit operator AsmMnemonicCode(Jnp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnp src) => AsmMnemonics.JNP;
        }

        public static Jnp jnp() => default;

        public readonly struct Jns : IAsmInstruction<Jns>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNS;

            public static implicit operator AsmMnemonicCode(Jns src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jns src) => AsmMnemonics.JNS;
        }

        public static Jns jns() => default;

        public readonly struct Jnz : IAsmInstruction<Jnz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNZ;

            public static implicit operator AsmMnemonicCode(Jnz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jnz src) => AsmMnemonics.JNZ;
        }

        public static Jnz jnz() => default;

        public readonly struct Jo : IAsmInstruction<Jo>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JO;

            public static implicit operator AsmMnemonicCode(Jo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jo src) => AsmMnemonics.JO;
        }

        public static Jo jo() => default;

        public readonly struct Jp : IAsmInstruction<Jp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JP;

            public static implicit operator AsmMnemonicCode(Jp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jp src) => AsmMnemonics.JP;
        }

        public static Jp jp() => default;

        public readonly struct Jpe : IAsmInstruction<Jpe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JPE;

            public static implicit operator AsmMnemonicCode(Jpe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jpe src) => AsmMnemonics.JPE;
        }

        public static Jpe jpe() => default;

        public readonly struct Jpo : IAsmInstruction<Jpo>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JPO;

            public static implicit operator AsmMnemonicCode(Jpo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jpo src) => AsmMnemonics.JPO;
        }

        public static Jpo jpo() => default;

        public readonly struct Js : IAsmInstruction<Js>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JS;

            public static implicit operator AsmMnemonicCode(Js src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Js src) => AsmMnemonics.JS;
        }

        public static Js js() => default;

        public readonly struct Jz : IAsmInstruction<Jz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JZ;

            public static implicit operator AsmMnemonicCode(Jz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jz src) => AsmMnemonics.JZ;
        }

        public static Jz jz() => default;

        public readonly struct Jmp : IAsmInstruction<Jmp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JMP;

            public static implicit operator AsmMnemonicCode(Jmp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Jmp src) => AsmMnemonics.JMP;
        }

        public static Jmp jmp() => default;

        public readonly struct Lar : IAsmInstruction<Lar>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LAR;

            public static implicit operator AsmMnemonicCode(Lar src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lar src) => AsmMnemonics.LAR;
        }

        public static Lar lar() => default;

        public readonly struct Lddqu : IAsmInstruction<Lddqu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LDDQU;

            public static implicit operator AsmMnemonicCode(Lddqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lddqu src) => AsmMnemonics.LDDQU;
        }

        public static Lddqu lddqu() => default;

        public readonly struct Vlddqu : IAsmInstruction<Vlddqu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VLDDQU;

            public static implicit operator AsmMnemonicCode(Vlddqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vlddqu src) => AsmMnemonics.VLDDQU;
        }

        public static Vlddqu vlddqu() => default;

        public readonly struct Ldmxcsr : IAsmInstruction<Ldmxcsr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LDMXCSR;

            public static implicit operator AsmMnemonicCode(Ldmxcsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ldmxcsr src) => AsmMnemonics.LDMXCSR;
        }

        public static Ldmxcsr ldmxcsr() => default;

        public readonly struct Vldmxcsr : IAsmInstruction<Vldmxcsr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VLDMXCSR;

            public static implicit operator AsmMnemonicCode(Vldmxcsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vldmxcsr src) => AsmMnemonics.VLDMXCSR;
        }

        public static Vldmxcsr vldmxcsr() => default;

        public readonly struct Lds : IAsmInstruction<Lds>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LDS;

            public static implicit operator AsmMnemonicCode(Lds src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lds src) => AsmMnemonics.LDS;
        }

        public static Lds lds() => default;

        public readonly struct Lss : IAsmInstruction<Lss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LSS;

            public static implicit operator AsmMnemonicCode(Lss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lss src) => AsmMnemonics.LSS;
        }

        public static Lss lss() => default;

        public readonly struct Les : IAsmInstruction<Les>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LES;

            public static implicit operator AsmMnemonicCode(Les src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Les src) => AsmMnemonics.LES;
        }

        public static Les les() => default;

        public readonly struct Lfs : IAsmInstruction<Lfs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LFS;

            public static implicit operator AsmMnemonicCode(Lfs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lfs src) => AsmMnemonics.LFS;
        }

        public static Lfs lfs() => default;

        public readonly struct Lgs : IAsmInstruction<Lgs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LGS;

            public static implicit operator AsmMnemonicCode(Lgs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lgs src) => AsmMnemonics.LGS;
        }

        public static Lgs lgs() => default;

        public readonly struct Lea : IAsmInstruction<Lea>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LEA;

            public static implicit operator AsmMnemonicCode(Lea src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lea src) => AsmMnemonics.LEA;
        }

        public static Lea lea() => default;

        public readonly struct Leave : IAsmInstruction<Leave>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LEAVE;

            public static implicit operator AsmMnemonicCode(Leave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Leave src) => AsmMnemonics.LEAVE;
        }

        public static Leave leave() => default;

        public readonly struct Lgdt : IAsmInstruction<Lgdt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LGDT;

            public static implicit operator AsmMnemonicCode(Lgdt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lgdt src) => AsmMnemonics.LGDT;
        }

        public static Lgdt lgdt() => default;

        public readonly struct Lidt : IAsmInstruction<Lidt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LIDT;

            public static implicit operator AsmMnemonicCode(Lidt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lidt src) => AsmMnemonics.LIDT;
        }

        public static Lidt lidt() => default;

        public readonly struct Lldt : IAsmInstruction<Lldt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LLDT;

            public static implicit operator AsmMnemonicCode(Lldt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lldt src) => AsmMnemonics.LLDT;
        }

        public static Lldt lldt() => default;

        public readonly struct Lmsw : IAsmInstruction<Lmsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LMSW;

            public static implicit operator AsmMnemonicCode(Lmsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lmsw src) => AsmMnemonics.LMSW;
        }

        public static Lmsw lmsw() => default;

        public readonly struct Lods : IAsmInstruction<Lods>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LODS;

            public static implicit operator AsmMnemonicCode(Lods src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lods src) => AsmMnemonics.LODS;
        }

        public static Lods lods() => default;

        public readonly struct Loop : IAsmInstruction<Loop>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOOP;

            public static implicit operator AsmMnemonicCode(Loop src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Loop src) => AsmMnemonics.LOOP;
        }

        public static Loop loop() => default;

        public readonly struct Loope : IAsmInstruction<Loope>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOOPE;

            public static implicit operator AsmMnemonicCode(Loope src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Loope src) => AsmMnemonics.LOOPE;
        }

        public static Loope loope() => default;

        public readonly struct Loopne : IAsmInstruction<Loopne>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOOPNE;

            public static implicit operator AsmMnemonicCode(Loopne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Loopne src) => AsmMnemonics.LOOPNE;
        }

        public static Loopne loopne() => default;

        public readonly struct Lsl : IAsmInstruction<Lsl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LSL;

            public static implicit operator AsmMnemonicCode(Lsl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lsl src) => AsmMnemonics.LSL;
        }

        public static Lsl lsl() => default;

        public readonly struct Ltr : IAsmInstruction<Ltr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LTR;

            public static implicit operator AsmMnemonicCode(Ltr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ltr src) => AsmMnemonics.LTR;
        }

        public static Ltr ltr() => default;

        public readonly struct Lzcnt : IAsmInstruction<Lzcnt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LZCNT;

            public static implicit operator AsmMnemonicCode(Lzcnt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Lzcnt src) => AsmMnemonics.LZCNT;
        }

        public static Lzcnt lzcnt() => default;

        public readonly struct Maskmovdqu : IAsmInstruction<Maskmovdqu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MASKMOVDQU;

            public static implicit operator AsmMnemonicCode(Maskmovdqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maskmovdqu src) => AsmMnemonics.MASKMOVDQU;
        }

        public static Maskmovdqu maskmovdqu() => default;

        public readonly struct Vmaskmovdqu : IAsmInstruction<Vmaskmovdqu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMASKMOVDQU;

            public static implicit operator AsmMnemonicCode(Vmaskmovdqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaskmovdqu src) => AsmMnemonics.VMASKMOVDQU;
        }

        public static Vmaskmovdqu vmaskmovdqu() => default;

        public readonly struct Maskmovq : IAsmInstruction<Maskmovq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MASKMOVQ;

            public static implicit operator AsmMnemonicCode(Maskmovq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maskmovq src) => AsmMnemonics.MASKMOVQ;
        }

        public static Maskmovq maskmovq() => default;

        public readonly struct Maxpd : IAsmInstruction<Maxpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXPD;

            public static implicit operator AsmMnemonicCode(Maxpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maxpd src) => AsmMnemonics.MAXPD;
        }

        public static Maxpd maxpd() => default;

        public readonly struct Vmaxpd : IAsmInstruction<Vmaxpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXPD;

            public static implicit operator AsmMnemonicCode(Vmaxpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaxpd src) => AsmMnemonics.VMAXPD;
        }

        public static Vmaxpd vmaxpd() => default;

        public readonly struct Maxps : IAsmInstruction<Maxps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXPS;

            public static implicit operator AsmMnemonicCode(Maxps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maxps src) => AsmMnemonics.MAXPS;
        }

        public static Maxps maxps() => default;

        public readonly struct Vmaxps : IAsmInstruction<Vmaxps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXPS;

            public static implicit operator AsmMnemonicCode(Vmaxps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaxps src) => AsmMnemonics.VMAXPS;
        }

        public static Vmaxps vmaxps() => default;

        public readonly struct Maxsd : IAsmInstruction<Maxsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXSD;

            public static implicit operator AsmMnemonicCode(Maxsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maxsd src) => AsmMnemonics.MAXSD;
        }

        public static Maxsd maxsd() => default;

        public readonly struct Vmaxsd : IAsmInstruction<Vmaxsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXSD;

            public static implicit operator AsmMnemonicCode(Vmaxsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaxsd src) => AsmMnemonics.VMAXSD;
        }

        public static Vmaxsd vmaxsd() => default;

        public readonly struct Maxss : IAsmInstruction<Maxss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXSS;

            public static implicit operator AsmMnemonicCode(Maxss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Maxss src) => AsmMnemonics.MAXSS;
        }

        public static Maxss maxss() => default;

        public readonly struct Vmaxss : IAsmInstruction<Vmaxss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXSS;

            public static implicit operator AsmMnemonicCode(Vmaxss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaxss src) => AsmMnemonics.VMAXSS;
        }

        public static Vmaxss vmaxss() => default;

        public readonly struct Minpd : IAsmInstruction<Minpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINPD;

            public static implicit operator AsmMnemonicCode(Minpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Minpd src) => AsmMnemonics.MINPD;
        }

        public static Minpd minpd() => default;

        public readonly struct Vminpd : IAsmInstruction<Vminpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINPD;

            public static implicit operator AsmMnemonicCode(Vminpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vminpd src) => AsmMnemonics.VMINPD;
        }

        public static Vminpd vminpd() => default;

        public readonly struct Minps : IAsmInstruction<Minps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINPS;

            public static implicit operator AsmMnemonicCode(Minps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Minps src) => AsmMnemonics.MINPS;
        }

        public static Minps minps() => default;

        public readonly struct Vminps : IAsmInstruction<Vminps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINPS;

            public static implicit operator AsmMnemonicCode(Vminps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vminps src) => AsmMnemonics.VMINPS;
        }

        public static Vminps vminps() => default;

        public readonly struct Minsd : IAsmInstruction<Minsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINSD;

            public static implicit operator AsmMnemonicCode(Minsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Minsd src) => AsmMnemonics.MINSD;
        }

        public static Minsd minsd() => default;

        public readonly struct Vminsd : IAsmInstruction<Vminsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINSD;

            public static implicit operator AsmMnemonicCode(Vminsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vminsd src) => AsmMnemonics.VMINSD;
        }

        public static Vminsd vminsd() => default;

        public readonly struct Minss : IAsmInstruction<Minss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINSS;

            public static implicit operator AsmMnemonicCode(Minss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Minss src) => AsmMnemonics.MINSS;
        }

        public static Minss minss() => default;

        public readonly struct Vminss : IAsmInstruction<Vminss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINSS;

            public static implicit operator AsmMnemonicCode(Vminss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vminss src) => AsmMnemonics.VMINSS;
        }

        public static Vminss vminss() => default;

        public readonly struct Mov : IAsmInstruction<Mov>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOV;

            public static implicit operator AsmMnemonicCode(Mov src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mov src) => AsmMnemonics.MOV;
        }

        public static Mov mov() => default;

        public readonly struct Movapd : IAsmInstruction<Movapd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVAPD;

            public static implicit operator AsmMnemonicCode(Movapd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movapd src) => AsmMnemonics.MOVAPD;
        }

        public static Movapd movapd() => default;

        public readonly struct Vmovapd : IAsmInstruction<Vmovapd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVAPD;

            public static implicit operator AsmMnemonicCode(Vmovapd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovapd src) => AsmMnemonics.VMOVAPD;
        }

        public static Vmovapd vmovapd() => default;

        public readonly struct Movaps : IAsmInstruction<Movaps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVAPS;

            public static implicit operator AsmMnemonicCode(Movaps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movaps src) => AsmMnemonics.MOVAPS;
        }

        public static Movaps movaps() => default;

        public readonly struct Vmovaps : IAsmInstruction<Vmovaps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVAPS;

            public static implicit operator AsmMnemonicCode(Vmovaps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovaps src) => AsmMnemonics.VMOVAPS;
        }

        public static Vmovaps vmovaps() => default;

        public readonly struct Movbe : IAsmInstruction<Movbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVBE;

            public static implicit operator AsmMnemonicCode(Movbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movbe src) => AsmMnemonics.MOVBE;
        }

        public static Movbe movbe() => default;

        public readonly struct Movd : IAsmInstruction<Movd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVD;

            public static implicit operator AsmMnemonicCode(Movd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movd src) => AsmMnemonics.MOVD;
        }

        public static Movd movd() => default;

        public readonly struct Movq : IAsmInstruction<Movq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVQ;

            public static implicit operator AsmMnemonicCode(Movq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movq src) => AsmMnemonics.MOVQ;
        }

        public static Movq movq() => default;

        public readonly struct Vmovd : IAsmInstruction<Vmovd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVD;

            public static implicit operator AsmMnemonicCode(Vmovd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovd src) => AsmMnemonics.VMOVD;
        }

        public static Vmovd vmovd() => default;

        public readonly struct Vmovq : IAsmInstruction<Vmovq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVQ;

            public static implicit operator AsmMnemonicCode(Vmovq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovq src) => AsmMnemonics.VMOVQ;
        }

        public static Vmovq vmovq() => default;

        public readonly struct Movddup : IAsmInstruction<Movddup>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDDUP;

            public static implicit operator AsmMnemonicCode(Movddup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movddup src) => AsmMnemonics.MOVDDUP;
        }

        public static Movddup movddup() => default;

        public readonly struct Vmovddup : IAsmInstruction<Vmovddup>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVDDUP;

            public static implicit operator AsmMnemonicCode(Vmovddup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovddup src) => AsmMnemonics.VMOVDDUP;
        }

        public static Vmovddup vmovddup() => default;

        public readonly struct Movdqa : IAsmInstruction<Movdqa>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDQA;

            public static implicit operator AsmMnemonicCode(Movdqa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movdqa src) => AsmMnemonics.MOVDQA;
        }

        public static Movdqa movdqa() => default;

        public readonly struct Vmovdqa : IAsmInstruction<Vmovdqa>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVDQA;

            public static implicit operator AsmMnemonicCode(Vmovdqa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovdqa src) => AsmMnemonics.VMOVDQA;
        }

        public static Vmovdqa vmovdqa() => default;

        public readonly struct Movdqu : IAsmInstruction<Movdqu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDQU;

            public static implicit operator AsmMnemonicCode(Movdqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movdqu src) => AsmMnemonics.MOVDQU;
        }

        public static Movdqu movdqu() => default;

        public readonly struct Vmovdqu : IAsmInstruction<Vmovdqu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVDQU;

            public static implicit operator AsmMnemonicCode(Vmovdqu src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovdqu src) => AsmMnemonics.VMOVDQU;
        }

        public static Vmovdqu vmovdqu() => default;

        public readonly struct Movdq2q : IAsmInstruction<Movdq2q>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDQ2Q;

            public static implicit operator AsmMnemonicCode(Movdq2q src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movdq2q src) => AsmMnemonics.MOVDQ2Q;
        }

        public static Movdq2q movdq2q() => default;

        public readonly struct Movhlps : IAsmInstruction<Movhlps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVHLPS;

            public static implicit operator AsmMnemonicCode(Movhlps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movhlps src) => AsmMnemonics.MOVHLPS;
        }

        public static Movhlps movhlps() => default;

        public readonly struct Vmovhlps : IAsmInstruction<Vmovhlps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVHLPS;

            public static implicit operator AsmMnemonicCode(Vmovhlps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovhlps src) => AsmMnemonics.VMOVHLPS;
        }

        public static Vmovhlps vmovhlps() => default;

        public readonly struct Movhpd : IAsmInstruction<Movhpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVHPD;

            public static implicit operator AsmMnemonicCode(Movhpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movhpd src) => AsmMnemonics.MOVHPD;
        }

        public static Movhpd movhpd() => default;

        public readonly struct Vmovhpd : IAsmInstruction<Vmovhpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVHPD;

            public static implicit operator AsmMnemonicCode(Vmovhpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovhpd src) => AsmMnemonics.VMOVHPD;
        }

        public static Vmovhpd vmovhpd() => default;

        public readonly struct Movhps : IAsmInstruction<Movhps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVHPS;

            public static implicit operator AsmMnemonicCode(Movhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movhps src) => AsmMnemonics.MOVHPS;
        }

        public static Movhps movhps() => default;

        public readonly struct Vmovhps : IAsmInstruction<Vmovhps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVHPS;

            public static implicit operator AsmMnemonicCode(Vmovhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovhps src) => AsmMnemonics.VMOVHPS;
        }

        public static Vmovhps vmovhps() => default;

        public readonly struct Movlhps : IAsmInstruction<Movlhps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVLHPS;

            public static implicit operator AsmMnemonicCode(Movlhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movlhps src) => AsmMnemonics.MOVLHPS;
        }

        public static Movlhps movlhps() => default;

        public readonly struct Vmovlhps : IAsmInstruction<Vmovlhps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVLHPS;

            public static implicit operator AsmMnemonicCode(Vmovlhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovlhps src) => AsmMnemonics.VMOVLHPS;
        }

        public static Vmovlhps vmovlhps() => default;

        public readonly struct Movlpd : IAsmInstruction<Movlpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVLPD;

            public static implicit operator AsmMnemonicCode(Movlpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movlpd src) => AsmMnemonics.MOVLPD;
        }

        public static Movlpd movlpd() => default;

        public readonly struct Vmovlpd : IAsmInstruction<Vmovlpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVLPD;

            public static implicit operator AsmMnemonicCode(Vmovlpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovlpd src) => AsmMnemonics.VMOVLPD;
        }

        public static Vmovlpd vmovlpd() => default;

        public readonly struct Movlps : IAsmInstruction<Movlps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVLPS;

            public static implicit operator AsmMnemonicCode(Movlps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movlps src) => AsmMnemonics.MOVLPS;
        }

        public static Movlps movlps() => default;

        public readonly struct Vmovlps : IAsmInstruction<Vmovlps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVLPS;

            public static implicit operator AsmMnemonicCode(Vmovlps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovlps src) => AsmMnemonics.VMOVLPS;
        }

        public static Vmovlps vmovlps() => default;

        public readonly struct Movmskpd : IAsmInstruction<Movmskpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVMSKPD;

            public static implicit operator AsmMnemonicCode(Movmskpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movmskpd src) => AsmMnemonics.MOVMSKPD;
        }

        public static Movmskpd movmskpd() => default;

        public readonly struct Vmovmskpd : IAsmInstruction<Vmovmskpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVMSKPD;

            public static implicit operator AsmMnemonicCode(Vmovmskpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovmskpd src) => AsmMnemonics.VMOVMSKPD;
        }

        public static Vmovmskpd vmovmskpd() => default;

        public readonly struct Movmskps : IAsmInstruction<Movmskps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVMSKPS;

            public static implicit operator AsmMnemonicCode(Movmskps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movmskps src) => AsmMnemonics.MOVMSKPS;
        }

        public static Movmskps movmskps() => default;

        public readonly struct Vmovmskps : IAsmInstruction<Vmovmskps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVMSKPS;

            public static implicit operator AsmMnemonicCode(Vmovmskps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovmskps src) => AsmMnemonics.VMOVMSKPS;
        }

        public static Vmovmskps vmovmskps() => default;

        public readonly struct Movntdqa : IAsmInstruction<Movntdqa>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTDQA;

            public static implicit operator AsmMnemonicCode(Movntdqa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntdqa src) => AsmMnemonics.MOVNTDQA;
        }

        public static Movntdqa movntdqa() => default;

        public readonly struct Vmovntdqa : IAsmInstruction<Vmovntdqa>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTDQA;

            public static implicit operator AsmMnemonicCode(Vmovntdqa src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovntdqa src) => AsmMnemonics.VMOVNTDQA;
        }

        public static Vmovntdqa vmovntdqa() => default;

        public readonly struct Movntdq : IAsmInstruction<Movntdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTDQ;

            public static implicit operator AsmMnemonicCode(Movntdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntdq src) => AsmMnemonics.MOVNTDQ;
        }

        public static Movntdq movntdq() => default;

        public readonly struct Vmovntdq : IAsmInstruction<Vmovntdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTDQ;

            public static implicit operator AsmMnemonicCode(Vmovntdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovntdq src) => AsmMnemonics.VMOVNTDQ;
        }

        public static Vmovntdq vmovntdq() => default;

        public readonly struct Movnti : IAsmInstruction<Movnti>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTI;

            public static implicit operator AsmMnemonicCode(Movnti src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movnti src) => AsmMnemonics.MOVNTI;
        }

        public static Movnti movnti() => default;

        public readonly struct Movntpd : IAsmInstruction<Movntpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTPD;

            public static implicit operator AsmMnemonicCode(Movntpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntpd src) => AsmMnemonics.MOVNTPD;
        }

        public static Movntpd movntpd() => default;

        public readonly struct Vmovntpd : IAsmInstruction<Vmovntpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTPD;

            public static implicit operator AsmMnemonicCode(Vmovntpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovntpd src) => AsmMnemonics.VMOVNTPD;
        }

        public static Vmovntpd vmovntpd() => default;

        public readonly struct Movntps : IAsmInstruction<Movntps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTPS;

            public static implicit operator AsmMnemonicCode(Movntps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntps src) => AsmMnemonics.MOVNTPS;
        }

        public static Movntps movntps() => default;

        public readonly struct Vmovntps : IAsmInstruction<Vmovntps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTPS;

            public static implicit operator AsmMnemonicCode(Vmovntps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovntps src) => AsmMnemonics.VMOVNTPS;
        }

        public static Vmovntps vmovntps() => default;

        public readonly struct Movntq : IAsmInstruction<Movntq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTQ;

            public static implicit operator AsmMnemonicCode(Movntq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movntq src) => AsmMnemonics.MOVNTQ;
        }

        public static Movntq movntq() => default;

        public readonly struct Movq2dq : IAsmInstruction<Movq2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVQ2DQ;

            public static implicit operator AsmMnemonicCode(Movq2dq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movq2dq src) => AsmMnemonics.MOVQ2DQ;
        }

        public static Movq2dq movq2dq() => default;

        public readonly struct Movs : IAsmInstruction<Movs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVS;

            public static implicit operator AsmMnemonicCode(Movs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movs src) => AsmMnemonics.MOVS;
        }

        public static Movs movs() => default;

        public readonly struct Movsd : IAsmInstruction<Movsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSD;

            public static implicit operator AsmMnemonicCode(Movsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsd src) => AsmMnemonics.MOVSD;
        }

        public static Movsd movsd() => default;

        public readonly struct Vmovsd : IAsmInstruction<Vmovsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSD;

            public static implicit operator AsmMnemonicCode(Vmovsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovsd src) => AsmMnemonics.VMOVSD;
        }

        public static Vmovsd vmovsd() => default;

        public readonly struct Movshdup : IAsmInstruction<Movshdup>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSHDUP;

            public static implicit operator AsmMnemonicCode(Movshdup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movshdup src) => AsmMnemonics.MOVSHDUP;
        }

        public static Movshdup movshdup() => default;

        public readonly struct Vmovshdup : IAsmInstruction<Vmovshdup>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSHDUP;

            public static implicit operator AsmMnemonicCode(Vmovshdup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovshdup src) => AsmMnemonics.VMOVSHDUP;
        }

        public static Vmovshdup vmovshdup() => default;

        public readonly struct Movsldup : IAsmInstruction<Movsldup>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSLDUP;

            public static implicit operator AsmMnemonicCode(Movsldup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsldup src) => AsmMnemonics.MOVSLDUP;
        }

        public static Movsldup movsldup() => default;

        public readonly struct Vmovsldup : IAsmInstruction<Vmovsldup>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSLDUP;

            public static implicit operator AsmMnemonicCode(Vmovsldup src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovsldup src) => AsmMnemonics.VMOVSLDUP;
        }

        public static Vmovsldup vmovsldup() => default;

        public readonly struct Movss : IAsmInstruction<Movss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSS;

            public static implicit operator AsmMnemonicCode(Movss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movss src) => AsmMnemonics.MOVSS;
        }

        public static Movss movss() => default;

        public readonly struct Vmovss : IAsmInstruction<Vmovss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSS;

            public static implicit operator AsmMnemonicCode(Vmovss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovss src) => AsmMnemonics.VMOVSS;
        }

        public static Vmovss vmovss() => default;

        public readonly struct Movsx : IAsmInstruction<Movsx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSX;

            public static implicit operator AsmMnemonicCode(Movsx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsx src) => AsmMnemonics.MOVSX;
        }

        public static Movsx movsx() => default;

        public readonly struct Movsxd : IAsmInstruction<Movsxd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSXD;

            public static implicit operator AsmMnemonicCode(Movsxd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movsxd src) => AsmMnemonics.MOVSXD;
        }

        public static Movsxd movsxd() => default;

        public readonly struct Movupd : IAsmInstruction<Movupd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVUPD;

            public static implicit operator AsmMnemonicCode(Movupd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movupd src) => AsmMnemonics.MOVUPD;
        }

        public static Movupd movupd() => default;

        public readonly struct Vmovupd : IAsmInstruction<Vmovupd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVUPD;

            public static implicit operator AsmMnemonicCode(Vmovupd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovupd src) => AsmMnemonics.VMOVUPD;
        }

        public static Vmovupd vmovupd() => default;

        public readonly struct Movups : IAsmInstruction<Movups>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVUPS;

            public static implicit operator AsmMnemonicCode(Movups src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movups src) => AsmMnemonics.MOVUPS;
        }

        public static Movups movups() => default;

        public readonly struct Vmovups : IAsmInstruction<Vmovups>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVUPS;

            public static implicit operator AsmMnemonicCode(Vmovups src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmovups src) => AsmMnemonics.VMOVUPS;
        }

        public static Vmovups vmovups() => default;

        public readonly struct Movzx : IAsmInstruction<Movzx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVZX;

            public static implicit operator AsmMnemonicCode(Movzx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Movzx src) => AsmMnemonics.MOVZX;
        }

        public static Movzx movzx() => default;

        public readonly struct Mpsadbw : IAsmInstruction<Mpsadbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MPSADBW;

            public static implicit operator AsmMnemonicCode(Mpsadbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mpsadbw src) => AsmMnemonics.MPSADBW;
        }

        public static Mpsadbw mpsadbw() => default;

        public readonly struct Vmpsadbw : IAsmInstruction<Vmpsadbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMPSADBW;

            public static implicit operator AsmMnemonicCode(Vmpsadbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmpsadbw src) => AsmMnemonics.VMPSADBW;
        }

        public static Vmpsadbw vmpsadbw() => default;

        public readonly struct Mul : IAsmInstruction<Mul>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MUL;

            public static implicit operator AsmMnemonicCode(Mul src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mul src) => AsmMnemonics.MUL;
        }

        public static Mul mul() => default;

        public readonly struct Mulpd : IAsmInstruction<Mulpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULPD;

            public static implicit operator AsmMnemonicCode(Mulpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulpd src) => AsmMnemonics.MULPD;
        }

        public static Mulpd mulpd() => default;

        public readonly struct Vmulpd : IAsmInstruction<Vmulpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULPD;

            public static implicit operator AsmMnemonicCode(Vmulpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmulpd src) => AsmMnemonics.VMULPD;
        }

        public static Vmulpd vmulpd() => default;

        public readonly struct Mulps : IAsmInstruction<Mulps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULPS;

            public static implicit operator AsmMnemonicCode(Mulps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulps src) => AsmMnemonics.MULPS;
        }

        public static Mulps mulps() => default;

        public readonly struct Vmulps : IAsmInstruction<Vmulps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULPS;

            public static implicit operator AsmMnemonicCode(Vmulps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmulps src) => AsmMnemonics.VMULPS;
        }

        public static Vmulps vmulps() => default;

        public readonly struct Mulsd : IAsmInstruction<Mulsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULSD;

            public static implicit operator AsmMnemonicCode(Mulsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulsd src) => AsmMnemonics.MULSD;
        }

        public static Mulsd mulsd() => default;

        public readonly struct Vmulsd : IAsmInstruction<Vmulsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULSD;

            public static implicit operator AsmMnemonicCode(Vmulsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmulsd src) => AsmMnemonics.VMULSD;
        }

        public static Vmulsd vmulsd() => default;

        public readonly struct Mulss : IAsmInstruction<Mulss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULSS;

            public static implicit operator AsmMnemonicCode(Mulss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulss src) => AsmMnemonics.MULSS;
        }

        public static Mulss mulss() => default;

        public readonly struct Vmulss : IAsmInstruction<Vmulss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULSS;

            public static implicit operator AsmMnemonicCode(Vmulss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmulss src) => AsmMnemonics.VMULSS;
        }

        public static Vmulss vmulss() => default;

        public readonly struct Mulx : IAsmInstruction<Mulx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULX;

            public static implicit operator AsmMnemonicCode(Mulx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Mulx src) => AsmMnemonics.MULX;
        }

        public static Mulx mulx() => default;

        public readonly struct Neg : IAsmInstruction<Neg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.NEG;

            public static implicit operator AsmMnemonicCode(Neg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Neg src) => AsmMnemonics.NEG;
        }

        public static Neg neg() => default;

        public readonly struct Nop : IAsmInstruction<Nop>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.NOP;

            public static implicit operator AsmMnemonicCode(Nop src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Nop src) => AsmMnemonics.NOP;
        }

        public static Nop nop() => default;

        public readonly struct Not : IAsmInstruction<Not>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.NOT;

            public static implicit operator AsmMnemonicCode(Not src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Not src) => AsmMnemonics.NOT;
        }

        public static Not not() => default;

        public readonly struct Or : IAsmInstruction<Or>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OR;

            public static implicit operator AsmMnemonicCode(Or src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Or src) => AsmMnemonics.OR;
        }

        public static Or or() => default;

        public readonly struct Orpd : IAsmInstruction<Orpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ORPD;

            public static implicit operator AsmMnemonicCode(Orpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Orpd src) => AsmMnemonics.ORPD;
        }

        public static Orpd orpd() => default;

        public readonly struct Vorpd : IAsmInstruction<Vorpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VORPD;

            public static implicit operator AsmMnemonicCode(Vorpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vorpd src) => AsmMnemonics.VORPD;
        }

        public static Vorpd vorpd() => default;

        public readonly struct Orps : IAsmInstruction<Orps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ORPS;

            public static implicit operator AsmMnemonicCode(Orps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Orps src) => AsmMnemonics.ORPS;
        }

        public static Orps orps() => default;

        public readonly struct Vorps : IAsmInstruction<Vorps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VORPS;

            public static implicit operator AsmMnemonicCode(Vorps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vorps src) => AsmMnemonics.VORPS;
        }

        public static Vorps vorps() => default;

        public readonly struct Out : IAsmInstruction<Out>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUT;

            public static implicit operator AsmMnemonicCode(Out src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Out src) => AsmMnemonics.OUT;
        }

        public static Out @out() => default;

        public readonly struct Outs : IAsmInstruction<Outs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUTS;

            public static implicit operator AsmMnemonicCode(Outs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Outs src) => AsmMnemonics.OUTS;
        }

        public static Outs outs() => default;

        public readonly struct Pabsb : IAsmInstruction<Pabsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PABSB;

            public static implicit operator AsmMnemonicCode(Pabsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pabsb src) => AsmMnemonics.PABSB;
        }

        public static Pabsb pabsb() => default;

        public readonly struct Pabsw : IAsmInstruction<Pabsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PABSW;

            public static implicit operator AsmMnemonicCode(Pabsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pabsw src) => AsmMnemonics.PABSW;
        }

        public static Pabsw pabsw() => default;

        public readonly struct Pabsd : IAsmInstruction<Pabsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PABSD;

            public static implicit operator AsmMnemonicCode(Pabsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pabsd src) => AsmMnemonics.PABSD;
        }

        public static Pabsd pabsd() => default;

        public readonly struct Vpabsb : IAsmInstruction<Vpabsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPABSB;

            public static implicit operator AsmMnemonicCode(Vpabsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpabsb src) => AsmMnemonics.VPABSB;
        }

        public static Vpabsb vpabsb() => default;

        public readonly struct Vpabsw : IAsmInstruction<Vpabsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPABSW;

            public static implicit operator AsmMnemonicCode(Vpabsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpabsw src) => AsmMnemonics.VPABSW;
        }

        public static Vpabsw vpabsw() => default;

        public readonly struct Vpabsd : IAsmInstruction<Vpabsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPABSD;

            public static implicit operator AsmMnemonicCode(Vpabsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpabsd src) => AsmMnemonics.VPABSD;
        }

        public static Vpabsd vpabsd() => default;

        public readonly struct Packsswb : IAsmInstruction<Packsswb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKSSWB;

            public static implicit operator AsmMnemonicCode(Packsswb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Packsswb src) => AsmMnemonics.PACKSSWB;
        }

        public static Packsswb packsswb() => default;

        public readonly struct Packssdw : IAsmInstruction<Packssdw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKSSDW;

            public static implicit operator AsmMnemonicCode(Packssdw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Packssdw src) => AsmMnemonics.PACKSSDW;
        }

        public static Packssdw packssdw() => default;

        public readonly struct Vpacksswb : IAsmInstruction<Vpacksswb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKSSWB;

            public static implicit operator AsmMnemonicCode(Vpacksswb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpacksswb src) => AsmMnemonics.VPACKSSWB;
        }

        public static Vpacksswb vpacksswb() => default;

        public readonly struct Vpackssdw : IAsmInstruction<Vpackssdw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKSSDW;

            public static implicit operator AsmMnemonicCode(Vpackssdw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpackssdw src) => AsmMnemonics.VPACKSSDW;
        }

        public static Vpackssdw vpackssdw() => default;

        public readonly struct Packusdw : IAsmInstruction<Packusdw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKUSDW;

            public static implicit operator AsmMnemonicCode(Packusdw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Packusdw src) => AsmMnemonics.PACKUSDW;
        }

        public static Packusdw packusdw() => default;

        public readonly struct Vpackusdw : IAsmInstruction<Vpackusdw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKUSDW;

            public static implicit operator AsmMnemonicCode(Vpackusdw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpackusdw src) => AsmMnemonics.VPACKUSDW;
        }

        public static Vpackusdw vpackusdw() => default;

        public readonly struct Packuswb : IAsmInstruction<Packuswb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKUSWB;

            public static implicit operator AsmMnemonicCode(Packuswb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Packuswb src) => AsmMnemonics.PACKUSWB;
        }

        public static Packuswb packuswb() => default;

        public readonly struct Vpackuswb : IAsmInstruction<Vpackuswb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKUSWB;

            public static implicit operator AsmMnemonicCode(Vpackuswb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpackuswb src) => AsmMnemonics.VPACKUSWB;
        }

        public static Vpackuswb vpackuswb() => default;

        public readonly struct Paddb : IAsmInstruction<Paddb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDB;

            public static implicit operator AsmMnemonicCode(Paddb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddb src) => AsmMnemonics.PADDB;
        }

        public static Paddb paddb() => default;

        public readonly struct Paddw : IAsmInstruction<Paddw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDW;

            public static implicit operator AsmMnemonicCode(Paddw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddw src) => AsmMnemonics.PADDW;
        }

        public static Paddw paddw() => default;

        public readonly struct Paddd : IAsmInstruction<Paddd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDD;

            public static implicit operator AsmMnemonicCode(Paddd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddd src) => AsmMnemonics.PADDD;
        }

        public static Paddd paddd() => default;

        public readonly struct Vpaddb : IAsmInstruction<Vpaddb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDB;

            public static implicit operator AsmMnemonicCode(Vpaddb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddb src) => AsmMnemonics.VPADDB;
        }

        public static Vpaddb vpaddb() => default;

        public readonly struct Vpaddw : IAsmInstruction<Vpaddw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDW;

            public static implicit operator AsmMnemonicCode(Vpaddw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddw src) => AsmMnemonics.VPADDW;
        }

        public static Vpaddw vpaddw() => default;

        public readonly struct Vpaddd : IAsmInstruction<Vpaddd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDD;

            public static implicit operator AsmMnemonicCode(Vpaddd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddd src) => AsmMnemonics.VPADDD;
        }

        public static Vpaddd vpaddd() => default;

        public readonly struct Paddq : IAsmInstruction<Paddq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDQ;

            public static implicit operator AsmMnemonicCode(Paddq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddq src) => AsmMnemonics.PADDQ;
        }

        public static Paddq paddq() => default;

        public readonly struct Vpaddq : IAsmInstruction<Vpaddq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDQ;

            public static implicit operator AsmMnemonicCode(Vpaddq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddq src) => AsmMnemonics.VPADDQ;
        }

        public static Vpaddq vpaddq() => default;

        public readonly struct Paddsb : IAsmInstruction<Paddsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDSB;

            public static implicit operator AsmMnemonicCode(Paddsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddsb src) => AsmMnemonics.PADDSB;
        }

        public static Paddsb paddsb() => default;

        public readonly struct Paddsw : IAsmInstruction<Paddsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDSW;

            public static implicit operator AsmMnemonicCode(Paddsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddsw src) => AsmMnemonics.PADDSW;
        }

        public static Paddsw paddsw() => default;

        public readonly struct Vpaddsb : IAsmInstruction<Vpaddsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDSB;

            public static implicit operator AsmMnemonicCode(Vpaddsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddsb src) => AsmMnemonics.VPADDSB;
        }

        public static Vpaddsb vpaddsb() => default;

        public readonly struct Vpaddsw : IAsmInstruction<Vpaddsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDSW;

            public static implicit operator AsmMnemonicCode(Vpaddsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddsw src) => AsmMnemonics.VPADDSW;
        }

        public static Vpaddsw vpaddsw() => default;

        public readonly struct Paddusb : IAsmInstruction<Paddusb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDUSB;

            public static implicit operator AsmMnemonicCode(Paddusb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddusb src) => AsmMnemonics.PADDUSB;
        }

        public static Paddusb paddusb() => default;

        public readonly struct Paddusw : IAsmInstruction<Paddusw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDUSW;

            public static implicit operator AsmMnemonicCode(Paddusw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Paddusw src) => AsmMnemonics.PADDUSW;
        }

        public static Paddusw paddusw() => default;

        public readonly struct Vpaddusb : IAsmInstruction<Vpaddusb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDUSB;

            public static implicit operator AsmMnemonicCode(Vpaddusb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddusb src) => AsmMnemonics.VPADDUSB;
        }

        public static Vpaddusb vpaddusb() => default;

        public readonly struct Vpaddusw : IAsmInstruction<Vpaddusw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDUSW;

            public static implicit operator AsmMnemonicCode(Vpaddusw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpaddusw src) => AsmMnemonics.VPADDUSW;
        }

        public static Vpaddusw vpaddusw() => default;

        public readonly struct Palignr : IAsmInstruction<Palignr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PALIGNR;

            public static implicit operator AsmMnemonicCode(Palignr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Palignr src) => AsmMnemonics.PALIGNR;
        }

        public static Palignr palignr() => default;

        public readonly struct Vpalignr : IAsmInstruction<Vpalignr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPALIGNR;

            public static implicit operator AsmMnemonicCode(Vpalignr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpalignr src) => AsmMnemonics.VPALIGNR;
        }

        public static Vpalignr vpalignr() => default;

        public readonly struct Pand : IAsmInstruction<Pand>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAND;

            public static implicit operator AsmMnemonicCode(Pand src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pand src) => AsmMnemonics.PAND;
        }

        public static Pand pand() => default;

        public readonly struct Vpand : IAsmInstruction<Vpand>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPAND;

            public static implicit operator AsmMnemonicCode(Vpand src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpand src) => AsmMnemonics.VPAND;
        }

        public static Vpand vpand() => default;

        public readonly struct Pandn : IAsmInstruction<Pandn>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PANDN;

            public static implicit operator AsmMnemonicCode(Pandn src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pandn src) => AsmMnemonics.PANDN;
        }

        public static Pandn pandn() => default;

        public readonly struct Vpandn : IAsmInstruction<Vpandn>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPANDN;

            public static implicit operator AsmMnemonicCode(Vpandn src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpandn src) => AsmMnemonics.VPANDN;
        }

        public static Vpandn vpandn() => default;

        public readonly struct Pavgb : IAsmInstruction<Pavgb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAVGB;

            public static implicit operator AsmMnemonicCode(Pavgb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pavgb src) => AsmMnemonics.PAVGB;
        }

        public static Pavgb pavgb() => default;

        public readonly struct Pavgw : IAsmInstruction<Pavgw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAVGW;

            public static implicit operator AsmMnemonicCode(Pavgw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pavgw src) => AsmMnemonics.PAVGW;
        }

        public static Pavgw pavgw() => default;

        public readonly struct Vpavgb : IAsmInstruction<Vpavgb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPAVGB;

            public static implicit operator AsmMnemonicCode(Vpavgb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpavgb src) => AsmMnemonics.VPAVGB;
        }

        public static Vpavgb vpavgb() => default;

        public readonly struct Vpavgw : IAsmInstruction<Vpavgw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPAVGW;

            public static implicit operator AsmMnemonicCode(Vpavgw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpavgw src) => AsmMnemonics.VPAVGW;
        }

        public static Vpavgw vpavgw() => default;

        public readonly struct Pblendvb : IAsmInstruction<Pblendvb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PBLENDVB;

            public static implicit operator AsmMnemonicCode(Pblendvb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pblendvb src) => AsmMnemonics.PBLENDVB;
        }

        public static Pblendvb pblendvb() => default;

        public readonly struct Vpblendvb : IAsmInstruction<Vpblendvb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBLENDVB;

            public static implicit operator AsmMnemonicCode(Vpblendvb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpblendvb src) => AsmMnemonics.VPBLENDVB;
        }

        public static Vpblendvb vpblendvb() => default;

        public readonly struct Pblendw : IAsmInstruction<Pblendw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PBLENDW;

            public static implicit operator AsmMnemonicCode(Pblendw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pblendw src) => AsmMnemonics.PBLENDW;
        }

        public static Pblendw pblendw() => default;

        public readonly struct Vpblendw : IAsmInstruction<Vpblendw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBLENDW;

            public static implicit operator AsmMnemonicCode(Vpblendw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpblendw src) => AsmMnemonics.VPBLENDW;
        }

        public static Vpblendw vpblendw() => default;

        public readonly struct Pclmulqdq : IAsmInstruction<Pclmulqdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCLMULQDQ;

            public static implicit operator AsmMnemonicCode(Pclmulqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pclmulqdq src) => AsmMnemonics.PCLMULQDQ;
        }

        public static Pclmulqdq pclmulqdq() => default;

        public readonly struct Vpclmulqdq : IAsmInstruction<Vpclmulqdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCLMULQDQ;

            public static implicit operator AsmMnemonicCode(Vpclmulqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpclmulqdq src) => AsmMnemonics.VPCLMULQDQ;
        }

        public static Vpclmulqdq vpclmulqdq() => default;

        public readonly struct Pcmpeqb : IAsmInstruction<Pcmpeqb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQB;

            public static implicit operator AsmMnemonicCode(Pcmpeqb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpeqb src) => AsmMnemonics.PCMPEQB;
        }

        public static Pcmpeqb pcmpeqb() => default;

        public readonly struct Pcmpeqw : IAsmInstruction<Pcmpeqw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQW;

            public static implicit operator AsmMnemonicCode(Pcmpeqw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpeqw src) => AsmMnemonics.PCMPEQW;
        }

        public static Pcmpeqw pcmpeqw() => default;

        public readonly struct Pcmpeqd : IAsmInstruction<Pcmpeqd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQD;

            public static implicit operator AsmMnemonicCode(Pcmpeqd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpeqd src) => AsmMnemonics.PCMPEQD;
        }

        public static Pcmpeqd pcmpeqd() => default;

        public readonly struct Vpcmpeqb : IAsmInstruction<Vpcmpeqb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQB;

            public static implicit operator AsmMnemonicCode(Vpcmpeqb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpeqb src) => AsmMnemonics.VPCMPEQB;
        }

        public static Vpcmpeqb vpcmpeqb() => default;

        public readonly struct Vpcmpeqw : IAsmInstruction<Vpcmpeqw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQW;

            public static implicit operator AsmMnemonicCode(Vpcmpeqw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpeqw src) => AsmMnemonics.VPCMPEQW;
        }

        public static Vpcmpeqw vpcmpeqw() => default;

        public readonly struct Vpcmpeqd : IAsmInstruction<Vpcmpeqd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQD;

            public static implicit operator AsmMnemonicCode(Vpcmpeqd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpeqd src) => AsmMnemonics.VPCMPEQD;
        }

        public static Vpcmpeqd vpcmpeqd() => default;

        public readonly struct Pcmpeqq : IAsmInstruction<Pcmpeqq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQQ;

            public static implicit operator AsmMnemonicCode(Pcmpeqq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpeqq src) => AsmMnemonics.PCMPEQQ;
        }

        public static Pcmpeqq pcmpeqq() => default;

        public readonly struct Vpcmpeqq : IAsmInstruction<Vpcmpeqq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQQ;

            public static implicit operator AsmMnemonicCode(Vpcmpeqq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpeqq src) => AsmMnemonics.VPCMPEQQ;
        }

        public static Vpcmpeqq vpcmpeqq() => default;

        public readonly struct Pcmpestri : IAsmInstruction<Pcmpestri>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPESTRI;

            public static implicit operator AsmMnemonicCode(Pcmpestri src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpestri src) => AsmMnemonics.PCMPESTRI;
        }

        public static Pcmpestri pcmpestri() => default;

        public readonly struct Vpcmpestri : IAsmInstruction<Vpcmpestri>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPESTRI;

            public static implicit operator AsmMnemonicCode(Vpcmpestri src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpestri src) => AsmMnemonics.VPCMPESTRI;
        }

        public static Vpcmpestri vpcmpestri() => default;

        public readonly struct Pcmpestrm : IAsmInstruction<Pcmpestrm>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPESTRM;

            public static implicit operator AsmMnemonicCode(Pcmpestrm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpestrm src) => AsmMnemonics.PCMPESTRM;
        }

        public static Pcmpestrm pcmpestrm() => default;

        public readonly struct Vpcmpestrm : IAsmInstruction<Vpcmpestrm>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPESTRM;

            public static implicit operator AsmMnemonicCode(Vpcmpestrm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpestrm src) => AsmMnemonics.VPCMPESTRM;
        }

        public static Vpcmpestrm vpcmpestrm() => default;

        public readonly struct Pcmpgtb : IAsmInstruction<Pcmpgtb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTB;

            public static implicit operator AsmMnemonicCode(Pcmpgtb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpgtb src) => AsmMnemonics.PCMPGTB;
        }

        public static Pcmpgtb pcmpgtb() => default;

        public readonly struct Pcmpgtw : IAsmInstruction<Pcmpgtw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTW;

            public static implicit operator AsmMnemonicCode(Pcmpgtw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpgtw src) => AsmMnemonics.PCMPGTW;
        }

        public static Pcmpgtw pcmpgtw() => default;

        public readonly struct Pcmpgtd : IAsmInstruction<Pcmpgtd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTD;

            public static implicit operator AsmMnemonicCode(Pcmpgtd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpgtd src) => AsmMnemonics.PCMPGTD;
        }

        public static Pcmpgtd pcmpgtd() => default;

        public readonly struct Vpcmpgtb : IAsmInstruction<Vpcmpgtb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTB;

            public static implicit operator AsmMnemonicCode(Vpcmpgtb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpgtb src) => AsmMnemonics.VPCMPGTB;
        }

        public static Vpcmpgtb vpcmpgtb() => default;

        public readonly struct Vpcmpgtw : IAsmInstruction<Vpcmpgtw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTW;

            public static implicit operator AsmMnemonicCode(Vpcmpgtw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpgtw src) => AsmMnemonics.VPCMPGTW;
        }

        public static Vpcmpgtw vpcmpgtw() => default;

        public readonly struct Vpcmpgtd : IAsmInstruction<Vpcmpgtd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTD;

            public static implicit operator AsmMnemonicCode(Vpcmpgtd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpgtd src) => AsmMnemonics.VPCMPGTD;
        }

        public static Vpcmpgtd vpcmpgtd() => default;

        public readonly struct Pcmpgtq : IAsmInstruction<Pcmpgtq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTQ;

            public static implicit operator AsmMnemonicCode(Pcmpgtq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpgtq src) => AsmMnemonics.PCMPGTQ;
        }

        public static Pcmpgtq pcmpgtq() => default;

        public readonly struct Vpcmpgtq : IAsmInstruction<Vpcmpgtq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTQ;

            public static implicit operator AsmMnemonicCode(Vpcmpgtq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpgtq src) => AsmMnemonics.VPCMPGTQ;
        }

        public static Vpcmpgtq vpcmpgtq() => default;

        public readonly struct Pcmpistri : IAsmInstruction<Pcmpistri>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPISTRI;

            public static implicit operator AsmMnemonicCode(Pcmpistri src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpistri src) => AsmMnemonics.PCMPISTRI;
        }

        public static Pcmpistri pcmpistri() => default;

        public readonly struct Vpcmpistri : IAsmInstruction<Vpcmpistri>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPISTRI;

            public static implicit operator AsmMnemonicCode(Vpcmpistri src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpistri src) => AsmMnemonics.VPCMPISTRI;
        }

        public static Vpcmpistri vpcmpistri() => default;

        public readonly struct Pcmpistrm : IAsmInstruction<Pcmpistrm>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPISTRM;

            public static implicit operator AsmMnemonicCode(Pcmpistrm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pcmpistrm src) => AsmMnemonics.PCMPISTRM;
        }

        public static Pcmpistrm pcmpistrm() => default;

        public readonly struct Vpcmpistrm : IAsmInstruction<Vpcmpistrm>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPISTRM;

            public static implicit operator AsmMnemonicCode(Vpcmpistrm src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpcmpistrm src) => AsmMnemonics.VPCMPISTRM;
        }

        public static Vpcmpistrm vpcmpistrm() => default;

        public readonly struct Pdep : IAsmInstruction<Pdep>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PDEP;

            public static implicit operator AsmMnemonicCode(Pdep src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pdep src) => AsmMnemonics.PDEP;
        }

        public static Pdep pdep() => default;

        public readonly struct Pext : IAsmInstruction<Pext>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXT;

            public static implicit operator AsmMnemonicCode(Pext src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pext src) => AsmMnemonics.PEXT;
        }

        public static Pext pext() => default;

        public readonly struct Pextrb : IAsmInstruction<Pextrb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRB;

            public static implicit operator AsmMnemonicCode(Pextrb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pextrb src) => AsmMnemonics.PEXTRB;
        }

        public static Pextrb pextrb() => default;

        public readonly struct Pextrd : IAsmInstruction<Pextrd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRD;

            public static implicit operator AsmMnemonicCode(Pextrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pextrd src) => AsmMnemonics.PEXTRD;
        }

        public static Pextrd pextrd() => default;

        public readonly struct Pextrq : IAsmInstruction<Pextrq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRQ;

            public static implicit operator AsmMnemonicCode(Pextrq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pextrq src) => AsmMnemonics.PEXTRQ;
        }

        public static Pextrq pextrq() => default;

        public readonly struct Vpextrb : IAsmInstruction<Vpextrb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRB;

            public static implicit operator AsmMnemonicCode(Vpextrb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpextrb src) => AsmMnemonics.VPEXTRB;
        }

        public static Vpextrb vpextrb() => default;

        public readonly struct Vpextrd : IAsmInstruction<Vpextrd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRD;

            public static implicit operator AsmMnemonicCode(Vpextrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpextrd src) => AsmMnemonics.VPEXTRD;
        }

        public static Vpextrd vpextrd() => default;

        public readonly struct Vpextrq : IAsmInstruction<Vpextrq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRQ;

            public static implicit operator AsmMnemonicCode(Vpextrq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpextrq src) => AsmMnemonics.VPEXTRQ;
        }

        public static Vpextrq vpextrq() => default;

        public readonly struct Pextrw : IAsmInstruction<Pextrw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRW;

            public static implicit operator AsmMnemonicCode(Pextrw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pextrw src) => AsmMnemonics.PEXTRW;
        }

        public static Pextrw pextrw() => default;

        public readonly struct Vpextrw : IAsmInstruction<Vpextrw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRW;

            public static implicit operator AsmMnemonicCode(Vpextrw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpextrw src) => AsmMnemonics.VPEXTRW;
        }

        public static Vpextrw vpextrw() => default;

        public readonly struct Phaddw : IAsmInstruction<Phaddw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHADDW;

            public static implicit operator AsmMnemonicCode(Phaddw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phaddw src) => AsmMnemonics.PHADDW;
        }

        public static Phaddw phaddw() => default;

        public readonly struct Phaddd : IAsmInstruction<Phaddd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHADDD;

            public static implicit operator AsmMnemonicCode(Phaddd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phaddd src) => AsmMnemonics.PHADDD;
        }

        public static Phaddd phaddd() => default;

        public readonly struct Vphaddw : IAsmInstruction<Vphaddw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHADDW;

            public static implicit operator AsmMnemonicCode(Vphaddw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphaddw src) => AsmMnemonics.VPHADDW;
        }

        public static Vphaddw vphaddw() => default;

        public readonly struct Vphaddd : IAsmInstruction<Vphaddd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHADDD;

            public static implicit operator AsmMnemonicCode(Vphaddd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphaddd src) => AsmMnemonics.VPHADDD;
        }

        public static Vphaddd vphaddd() => default;

        public readonly struct Phaddsw : IAsmInstruction<Phaddsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHADDSW;

            public static implicit operator AsmMnemonicCode(Phaddsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phaddsw src) => AsmMnemonics.PHADDSW;
        }

        public static Phaddsw phaddsw() => default;

        public readonly struct Vphaddsw : IAsmInstruction<Vphaddsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHADDSW;

            public static implicit operator AsmMnemonicCode(Vphaddsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphaddsw src) => AsmMnemonics.VPHADDSW;
        }

        public static Vphaddsw vphaddsw() => default;

        public readonly struct Phminposuw : IAsmInstruction<Phminposuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHMINPOSUW;

            public static implicit operator AsmMnemonicCode(Phminposuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phminposuw src) => AsmMnemonics.PHMINPOSUW;
        }

        public static Phminposuw phminposuw() => default;

        public readonly struct Vphminposuw : IAsmInstruction<Vphminposuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHMINPOSUW;

            public static implicit operator AsmMnemonicCode(Vphminposuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphminposuw src) => AsmMnemonics.VPHMINPOSUW;
        }

        public static Vphminposuw vphminposuw() => default;

        public readonly struct Phsubw : IAsmInstruction<Phsubw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHSUBW;

            public static implicit operator AsmMnemonicCode(Phsubw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phsubw src) => AsmMnemonics.PHSUBW;
        }

        public static Phsubw phsubw() => default;

        public readonly struct Phsubd : IAsmInstruction<Phsubd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHSUBD;

            public static implicit operator AsmMnemonicCode(Phsubd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phsubd src) => AsmMnemonics.PHSUBD;
        }

        public static Phsubd phsubd() => default;

        public readonly struct Vphsubw : IAsmInstruction<Vphsubw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHSUBW;

            public static implicit operator AsmMnemonicCode(Vphsubw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphsubw src) => AsmMnemonics.VPHSUBW;
        }

        public static Vphsubw vphsubw() => default;

        public readonly struct Vphsubd : IAsmInstruction<Vphsubd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHSUBD;

            public static implicit operator AsmMnemonicCode(Vphsubd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphsubd src) => AsmMnemonics.VPHSUBD;
        }

        public static Vphsubd vphsubd() => default;

        public readonly struct Phsubsw : IAsmInstruction<Phsubsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHSUBSW;

            public static implicit operator AsmMnemonicCode(Phsubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Phsubsw src) => AsmMnemonics.PHSUBSW;
        }

        public static Phsubsw phsubsw() => default;

        public readonly struct Vphsubsw : IAsmInstruction<Vphsubsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHSUBSW;

            public static implicit operator AsmMnemonicCode(Vphsubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vphsubsw src) => AsmMnemonics.VPHSUBSW;
        }

        public static Vphsubsw vphsubsw() => default;

        public readonly struct Pinsrb : IAsmInstruction<Pinsrb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRB;

            public static implicit operator AsmMnemonicCode(Pinsrb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pinsrb src) => AsmMnemonics.PINSRB;
        }

        public static Pinsrb pinsrb() => default;

        public readonly struct Pinsrd : IAsmInstruction<Pinsrd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRD;

            public static implicit operator AsmMnemonicCode(Pinsrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pinsrd src) => AsmMnemonics.PINSRD;
        }

        public static Pinsrd pinsrd() => default;

        public readonly struct Pinsrq : IAsmInstruction<Pinsrq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRQ;

            public static implicit operator AsmMnemonicCode(Pinsrq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pinsrq src) => AsmMnemonics.PINSRQ;
        }

        public static Pinsrq pinsrq() => default;

        public readonly struct Vpinsrb : IAsmInstruction<Vpinsrb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRB;

            public static implicit operator AsmMnemonicCode(Vpinsrb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpinsrb src) => AsmMnemonics.VPINSRB;
        }

        public static Vpinsrb vpinsrb() => default;

        public readonly struct Vpinsrd : IAsmInstruction<Vpinsrd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRD;

            public static implicit operator AsmMnemonicCode(Vpinsrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpinsrd src) => AsmMnemonics.VPINSRD;
        }

        public static Vpinsrd vpinsrd() => default;

        public readonly struct Vpinsrq : IAsmInstruction<Vpinsrq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRQ;

            public static implicit operator AsmMnemonicCode(Vpinsrq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpinsrq src) => AsmMnemonics.VPINSRQ;
        }

        public static Vpinsrq vpinsrq() => default;

        public readonly struct Pinsrw : IAsmInstruction<Pinsrw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRW;

            public static implicit operator AsmMnemonicCode(Pinsrw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pinsrw src) => AsmMnemonics.PINSRW;
        }

        public static Pinsrw pinsrw() => default;

        public readonly struct Vpinsrw : IAsmInstruction<Vpinsrw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRW;

            public static implicit operator AsmMnemonicCode(Vpinsrw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpinsrw src) => AsmMnemonics.VPINSRW;
        }

        public static Vpinsrw vpinsrw() => default;

        public readonly struct Pmaddubsw : IAsmInstruction<Pmaddubsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMADDUBSW;

            public static implicit operator AsmMnemonicCode(Pmaddubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaddubsw src) => AsmMnemonics.PMADDUBSW;
        }

        public static Pmaddubsw pmaddubsw() => default;

        public readonly struct Vpmaddubsw : IAsmInstruction<Vpmaddubsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMADDUBSW;

            public static implicit operator AsmMnemonicCode(Vpmaddubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaddubsw src) => AsmMnemonics.VPMADDUBSW;
        }

        public static Vpmaddubsw vpmaddubsw() => default;

        public readonly struct Pmaddwd : IAsmInstruction<Pmaddwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMADDWD;

            public static implicit operator AsmMnemonicCode(Pmaddwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaddwd src) => AsmMnemonics.PMADDWD;
        }

        public static Pmaddwd pmaddwd() => default;

        public readonly struct Vpmaddwd : IAsmInstruction<Vpmaddwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMADDWD;

            public static implicit operator AsmMnemonicCode(Vpmaddwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaddwd src) => AsmMnemonics.VPMADDWD;
        }

        public static Vpmaddwd vpmaddwd() => default;

        public readonly struct Pmaxsb : IAsmInstruction<Pmaxsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXSB;

            public static implicit operator AsmMnemonicCode(Pmaxsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxsb src) => AsmMnemonics.PMAXSB;
        }

        public static Pmaxsb pmaxsb() => default;

        public readonly struct Vpmaxsb : IAsmInstruction<Vpmaxsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXSB;

            public static implicit operator AsmMnemonicCode(Vpmaxsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxsb src) => AsmMnemonics.VPMAXSB;
        }

        public static Vpmaxsb vpmaxsb() => default;

        public readonly struct Pmaxsd : IAsmInstruction<Pmaxsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXSD;

            public static implicit operator AsmMnemonicCode(Pmaxsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxsd src) => AsmMnemonics.PMAXSD;
        }

        public static Pmaxsd pmaxsd() => default;

        public readonly struct Vpmaxsd : IAsmInstruction<Vpmaxsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXSD;

            public static implicit operator AsmMnemonicCode(Vpmaxsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxsd src) => AsmMnemonics.VPMAXSD;
        }

        public static Vpmaxsd vpmaxsd() => default;

        public readonly struct Pmaxsw : IAsmInstruction<Pmaxsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXSW;

            public static implicit operator AsmMnemonicCode(Pmaxsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxsw src) => AsmMnemonics.PMAXSW;
        }

        public static Pmaxsw pmaxsw() => default;

        public readonly struct Vpmaxsw : IAsmInstruction<Vpmaxsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXSW;

            public static implicit operator AsmMnemonicCode(Vpmaxsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxsw src) => AsmMnemonics.VPMAXSW;
        }

        public static Vpmaxsw vpmaxsw() => default;

        public readonly struct Pmaxub : IAsmInstruction<Pmaxub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXUB;

            public static implicit operator AsmMnemonicCode(Pmaxub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxub src) => AsmMnemonics.PMAXUB;
        }

        public static Pmaxub pmaxub() => default;

        public readonly struct Vpmaxub : IAsmInstruction<Vpmaxub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXUB;

            public static implicit operator AsmMnemonicCode(Vpmaxub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxub src) => AsmMnemonics.VPMAXUB;
        }

        public static Vpmaxub vpmaxub() => default;

        public readonly struct Pmaxud : IAsmInstruction<Pmaxud>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXUD;

            public static implicit operator AsmMnemonicCode(Pmaxud src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxud src) => AsmMnemonics.PMAXUD;
        }

        public static Pmaxud pmaxud() => default;

        public readonly struct Vpmaxud : IAsmInstruction<Vpmaxud>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXUD;

            public static implicit operator AsmMnemonicCode(Vpmaxud src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxud src) => AsmMnemonics.VPMAXUD;
        }

        public static Vpmaxud vpmaxud() => default;

        public readonly struct Pmaxuw : IAsmInstruction<Pmaxuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXUW;

            public static implicit operator AsmMnemonicCode(Pmaxuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmaxuw src) => AsmMnemonics.PMAXUW;
        }

        public static Pmaxuw pmaxuw() => default;

        public readonly struct Vpmaxuw : IAsmInstruction<Vpmaxuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXUW;

            public static implicit operator AsmMnemonicCode(Vpmaxuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaxuw src) => AsmMnemonics.VPMAXUW;
        }

        public static Vpmaxuw vpmaxuw() => default;

        public readonly struct Pminsb : IAsmInstruction<Pminsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINSB;

            public static implicit operator AsmMnemonicCode(Pminsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminsb src) => AsmMnemonics.PMINSB;
        }

        public static Pminsb pminsb() => default;

        public readonly struct Vpminsb : IAsmInstruction<Vpminsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINSB;

            public static implicit operator AsmMnemonicCode(Vpminsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminsb src) => AsmMnemonics.VPMINSB;
        }

        public static Vpminsb vpminsb() => default;

        public readonly struct Pminsd : IAsmInstruction<Pminsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINSD;

            public static implicit operator AsmMnemonicCode(Pminsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminsd src) => AsmMnemonics.PMINSD;
        }

        public static Pminsd pminsd() => default;

        public readonly struct Vpminsd : IAsmInstruction<Vpminsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINSD;

            public static implicit operator AsmMnemonicCode(Vpminsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminsd src) => AsmMnemonics.VPMINSD;
        }

        public static Vpminsd vpminsd() => default;

        public readonly struct Pminsw : IAsmInstruction<Pminsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINSW;

            public static implicit operator AsmMnemonicCode(Pminsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminsw src) => AsmMnemonics.PMINSW;
        }

        public static Pminsw pminsw() => default;

        public readonly struct Vpminsw : IAsmInstruction<Vpminsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINSW;

            public static implicit operator AsmMnemonicCode(Vpminsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminsw src) => AsmMnemonics.VPMINSW;
        }

        public static Vpminsw vpminsw() => default;

        public readonly struct Pminub : IAsmInstruction<Pminub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINUB;

            public static implicit operator AsmMnemonicCode(Pminub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminub src) => AsmMnemonics.PMINUB;
        }

        public static Pminub pminub() => default;

        public readonly struct Vpminub : IAsmInstruction<Vpminub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINUB;

            public static implicit operator AsmMnemonicCode(Vpminub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminub src) => AsmMnemonics.VPMINUB;
        }

        public static Vpminub vpminub() => default;

        public readonly struct Pminud : IAsmInstruction<Pminud>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINUD;

            public static implicit operator AsmMnemonicCode(Pminud src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminud src) => AsmMnemonics.PMINUD;
        }

        public static Pminud pminud() => default;

        public readonly struct Vpminud : IAsmInstruction<Vpminud>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINUD;

            public static implicit operator AsmMnemonicCode(Vpminud src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminud src) => AsmMnemonics.VPMINUD;
        }

        public static Vpminud vpminud() => default;

        public readonly struct Pminuw : IAsmInstruction<Pminuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINUW;

            public static implicit operator AsmMnemonicCode(Pminuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pminuw src) => AsmMnemonics.PMINUW;
        }

        public static Pminuw pminuw() => default;

        public readonly struct Vpminuw : IAsmInstruction<Vpminuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINUW;

            public static implicit operator AsmMnemonicCode(Vpminuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpminuw src) => AsmMnemonics.VPMINUW;
        }

        public static Vpminuw vpminuw() => default;

        public readonly struct Pmovmskb : IAsmInstruction<Pmovmskb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVMSKB;

            public static implicit operator AsmMnemonicCode(Pmovmskb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovmskb src) => AsmMnemonics.PMOVMSKB;
        }

        public static Pmovmskb pmovmskb() => default;

        public readonly struct Vpmovmskb : IAsmInstruction<Vpmovmskb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVMSKB;

            public static implicit operator AsmMnemonicCode(Vpmovmskb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovmskb src) => AsmMnemonics.VPMOVMSKB;
        }

        public static Vpmovmskb vpmovmskb() => default;

        public readonly struct Pmovsxbw : IAsmInstruction<Pmovsxbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXBW;

            public static implicit operator AsmMnemonicCode(Pmovsxbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxbw src) => AsmMnemonics.PMOVSXBW;
        }

        public static Pmovsxbw pmovsxbw() => default;

        public readonly struct Pmovsxbd : IAsmInstruction<Pmovsxbd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXBD;

            public static implicit operator AsmMnemonicCode(Pmovsxbd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxbd src) => AsmMnemonics.PMOVSXBD;
        }

        public static Pmovsxbd pmovsxbd() => default;

        public readonly struct Pmovsxbq : IAsmInstruction<Pmovsxbq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXBQ;

            public static implicit operator AsmMnemonicCode(Pmovsxbq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxbq src) => AsmMnemonics.PMOVSXBQ;
        }

        public static Pmovsxbq pmovsxbq() => default;

        public readonly struct Pmovsxwd : IAsmInstruction<Pmovsxwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXWD;

            public static implicit operator AsmMnemonicCode(Pmovsxwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxwd src) => AsmMnemonics.PMOVSXWD;
        }

        public static Pmovsxwd pmovsxwd() => default;

        public readonly struct Pmovsxwq : IAsmInstruction<Pmovsxwq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXWQ;

            public static implicit operator AsmMnemonicCode(Pmovsxwq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxwq src) => AsmMnemonics.PMOVSXWQ;
        }

        public static Pmovsxwq pmovsxwq() => default;

        public readonly struct Pmovsxdq : IAsmInstruction<Pmovsxdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXDQ;

            public static implicit operator AsmMnemonicCode(Pmovsxdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovsxdq src) => AsmMnemonics.PMOVSXDQ;
        }

        public static Pmovsxdq pmovsxdq() => default;

        public readonly struct Vpmovsxbw : IAsmInstruction<Vpmovsxbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXBW;

            public static implicit operator AsmMnemonicCode(Vpmovsxbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxbw src) => AsmMnemonics.VPMOVSXBW;
        }

        public static Vpmovsxbw vpmovsxbw() => default;

        public readonly struct Vpmovsxbd : IAsmInstruction<Vpmovsxbd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXBD;

            public static implicit operator AsmMnemonicCode(Vpmovsxbd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxbd src) => AsmMnemonics.VPMOVSXBD;
        }

        public static Vpmovsxbd vpmovsxbd() => default;

        public readonly struct Vpmovsxbq : IAsmInstruction<Vpmovsxbq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXBQ;

            public static implicit operator AsmMnemonicCode(Vpmovsxbq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxbq src) => AsmMnemonics.VPMOVSXBQ;
        }

        public static Vpmovsxbq vpmovsxbq() => default;

        public readonly struct Vpmovsxwd : IAsmInstruction<Vpmovsxwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXWD;

            public static implicit operator AsmMnemonicCode(Vpmovsxwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxwd src) => AsmMnemonics.VPMOVSXWD;
        }

        public static Vpmovsxwd vpmovsxwd() => default;

        public readonly struct Vpmovsxwq : IAsmInstruction<Vpmovsxwq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXWQ;

            public static implicit operator AsmMnemonicCode(Vpmovsxwq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxwq src) => AsmMnemonics.VPMOVSXWQ;
        }

        public static Vpmovsxwq vpmovsxwq() => default;

        public readonly struct Vpmovsxdq : IAsmInstruction<Vpmovsxdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXDQ;

            public static implicit operator AsmMnemonicCode(Vpmovsxdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovsxdq src) => AsmMnemonics.VPMOVSXDQ;
        }

        public static Vpmovsxdq vpmovsxdq() => default;

        public readonly struct Pmovzxbw : IAsmInstruction<Pmovzxbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXBW;

            public static implicit operator AsmMnemonicCode(Pmovzxbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxbw src) => AsmMnemonics.PMOVZXBW;
        }

        public static Pmovzxbw pmovzxbw() => default;

        public readonly struct Pmovzxbd : IAsmInstruction<Pmovzxbd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXBD;

            public static implicit operator AsmMnemonicCode(Pmovzxbd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxbd src) => AsmMnemonics.PMOVZXBD;
        }

        public static Pmovzxbd pmovzxbd() => default;

        public readonly struct Pmovzxbq : IAsmInstruction<Pmovzxbq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXBQ;

            public static implicit operator AsmMnemonicCode(Pmovzxbq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxbq src) => AsmMnemonics.PMOVZXBQ;
        }

        public static Pmovzxbq pmovzxbq() => default;

        public readonly struct Pmovzxwd : IAsmInstruction<Pmovzxwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXWD;

            public static implicit operator AsmMnemonicCode(Pmovzxwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxwd src) => AsmMnemonics.PMOVZXWD;
        }

        public static Pmovzxwd pmovzxwd() => default;

        public readonly struct Pmovzxwq : IAsmInstruction<Pmovzxwq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXWQ;

            public static implicit operator AsmMnemonicCode(Pmovzxwq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxwq src) => AsmMnemonics.PMOVZXWQ;
        }

        public static Pmovzxwq pmovzxwq() => default;

        public readonly struct Pmovzxdq : IAsmInstruction<Pmovzxdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXDQ;

            public static implicit operator AsmMnemonicCode(Pmovzxdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmovzxdq src) => AsmMnemonics.PMOVZXDQ;
        }

        public static Pmovzxdq pmovzxdq() => default;

        public readonly struct Vpmovzxbw : IAsmInstruction<Vpmovzxbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXBW;

            public static implicit operator AsmMnemonicCode(Vpmovzxbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxbw src) => AsmMnemonics.VPMOVZXBW;
        }

        public static Vpmovzxbw vpmovzxbw() => default;

        public readonly struct Vpmovzxbd : IAsmInstruction<Vpmovzxbd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXBD;

            public static implicit operator AsmMnemonicCode(Vpmovzxbd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxbd src) => AsmMnemonics.VPMOVZXBD;
        }

        public static Vpmovzxbd vpmovzxbd() => default;

        public readonly struct Vpmovzxbq : IAsmInstruction<Vpmovzxbq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXBQ;

            public static implicit operator AsmMnemonicCode(Vpmovzxbq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxbq src) => AsmMnemonics.VPMOVZXBQ;
        }

        public static Vpmovzxbq vpmovzxbq() => default;

        public readonly struct Vpmovzxwd : IAsmInstruction<Vpmovzxwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXWD;

            public static implicit operator AsmMnemonicCode(Vpmovzxwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxwd src) => AsmMnemonics.VPMOVZXWD;
        }

        public static Vpmovzxwd vpmovzxwd() => default;

        public readonly struct Vpmovzxwq : IAsmInstruction<Vpmovzxwq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXWQ;

            public static implicit operator AsmMnemonicCode(Vpmovzxwq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxwq src) => AsmMnemonics.VPMOVZXWQ;
        }

        public static Vpmovzxwq vpmovzxwq() => default;

        public readonly struct Vpmovzxdq : IAsmInstruction<Vpmovzxdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXDQ;

            public static implicit operator AsmMnemonicCode(Vpmovzxdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmovzxdq src) => AsmMnemonics.VPMOVZXDQ;
        }

        public static Vpmovzxdq vpmovzxdq() => default;

        public readonly struct Pmuldq : IAsmInstruction<Pmuldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULDQ;

            public static implicit operator AsmMnemonicCode(Pmuldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmuldq src) => AsmMnemonics.PMULDQ;
        }

        public static Pmuldq pmuldq() => default;

        public readonly struct Vpmuldq : IAsmInstruction<Vpmuldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULDQ;

            public static implicit operator AsmMnemonicCode(Vpmuldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmuldq src) => AsmMnemonics.VPMULDQ;
        }

        public static Vpmuldq vpmuldq() => default;

        public readonly struct Pmulhrsw : IAsmInstruction<Pmulhrsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULHRSW;

            public static implicit operator AsmMnemonicCode(Pmulhrsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmulhrsw src) => AsmMnemonics.PMULHRSW;
        }

        public static Pmulhrsw pmulhrsw() => default;

        public readonly struct Vpmulhrsw : IAsmInstruction<Vpmulhrsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULHRSW;

            public static implicit operator AsmMnemonicCode(Vpmulhrsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmulhrsw src) => AsmMnemonics.VPMULHRSW;
        }

        public static Vpmulhrsw vpmulhrsw() => default;

        public readonly struct Pmulhuw : IAsmInstruction<Pmulhuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULHUW;

            public static implicit operator AsmMnemonicCode(Pmulhuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmulhuw src) => AsmMnemonics.PMULHUW;
        }

        public static Pmulhuw pmulhuw() => default;

        public readonly struct Vpmulhuw : IAsmInstruction<Vpmulhuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULHUW;

            public static implicit operator AsmMnemonicCode(Vpmulhuw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmulhuw src) => AsmMnemonics.VPMULHUW;
        }

        public static Vpmulhuw vpmulhuw() => default;

        public readonly struct Pmulhw : IAsmInstruction<Pmulhw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULHW;

            public static implicit operator AsmMnemonicCode(Pmulhw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmulhw src) => AsmMnemonics.PMULHW;
        }

        public static Pmulhw pmulhw() => default;

        public readonly struct Vpmulhw : IAsmInstruction<Vpmulhw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULHW;

            public static implicit operator AsmMnemonicCode(Vpmulhw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmulhw src) => AsmMnemonics.VPMULHW;
        }

        public static Vpmulhw vpmulhw() => default;

        public readonly struct Pmulld : IAsmInstruction<Pmulld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULLD;

            public static implicit operator AsmMnemonicCode(Pmulld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmulld src) => AsmMnemonics.PMULLD;
        }

        public static Pmulld pmulld() => default;

        public readonly struct Vpmulld : IAsmInstruction<Vpmulld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULLD;

            public static implicit operator AsmMnemonicCode(Vpmulld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmulld src) => AsmMnemonics.VPMULLD;
        }

        public static Vpmulld vpmulld() => default;

        public readonly struct Pmullw : IAsmInstruction<Pmullw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULLW;

            public static implicit operator AsmMnemonicCode(Pmullw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmullw src) => AsmMnemonics.PMULLW;
        }

        public static Pmullw pmullw() => default;

        public readonly struct Vpmullw : IAsmInstruction<Vpmullw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULLW;

            public static implicit operator AsmMnemonicCode(Vpmullw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmullw src) => AsmMnemonics.VPMULLW;
        }

        public static Vpmullw vpmullw() => default;

        public readonly struct Pmuludq : IAsmInstruction<Pmuludq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULUDQ;

            public static implicit operator AsmMnemonicCode(Pmuludq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pmuludq src) => AsmMnemonics.PMULUDQ;
        }

        public static Pmuludq pmuludq() => default;

        public readonly struct Vpmuludq : IAsmInstruction<Vpmuludq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULUDQ;

            public static implicit operator AsmMnemonicCode(Vpmuludq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmuludq src) => AsmMnemonics.VPMULUDQ;
        }

        public static Vpmuludq vpmuludq() => default;

        public readonly struct Pop : IAsmInstruction<Pop>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POP;

            public static implicit operator AsmMnemonicCode(Pop src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pop src) => AsmMnemonics.POP;
        }

        public static Pop pop() => default;

        public readonly struct Popcnt : IAsmInstruction<Popcnt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPCNT;

            public static implicit operator AsmMnemonicCode(Popcnt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Popcnt src) => AsmMnemonics.POPCNT;
        }

        public static Popcnt popcnt() => default;

        public readonly struct Por : IAsmInstruction<Por>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POR;

            public static implicit operator AsmMnemonicCode(Por src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Por src) => AsmMnemonics.POR;
        }

        public static Por por() => default;

        public readonly struct Vpor : IAsmInstruction<Vpor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPOR;

            public static implicit operator AsmMnemonicCode(Vpor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpor src) => AsmMnemonics.VPOR;
        }

        public static Vpor vpor() => default;

        public readonly struct Prefetcht0 : IAsmInstruction<Prefetcht0>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHT0;

            public static implicit operator AsmMnemonicCode(Prefetcht0 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Prefetcht0 src) => AsmMnemonics.PREFETCHT0;
        }

        public static Prefetcht0 prefetcht0() => default;

        public readonly struct Prefetcht1 : IAsmInstruction<Prefetcht1>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHT1;

            public static implicit operator AsmMnemonicCode(Prefetcht1 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Prefetcht1 src) => AsmMnemonics.PREFETCHT1;
        }

        public static Prefetcht1 prefetcht1() => default;

        public readonly struct Prefetcht2 : IAsmInstruction<Prefetcht2>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHT2;

            public static implicit operator AsmMnemonicCode(Prefetcht2 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Prefetcht2 src) => AsmMnemonics.PREFETCHT2;
        }

        public static Prefetcht2 prefetcht2() => default;

        public readonly struct Prefetchnta : IAsmInstruction<Prefetchnta>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHNTA;

            public static implicit operator AsmMnemonicCode(Prefetchnta src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Prefetchnta src) => AsmMnemonics.PREFETCHNTA;
        }

        public static Prefetchnta prefetchnta() => default;

        public readonly struct Psadbw : IAsmInstruction<Psadbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSADBW;

            public static implicit operator AsmMnemonicCode(Psadbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psadbw src) => AsmMnemonics.PSADBW;
        }

        public static Psadbw psadbw() => default;

        public readonly struct Vpsadbw : IAsmInstruction<Vpsadbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSADBW;

            public static implicit operator AsmMnemonicCode(Vpsadbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsadbw src) => AsmMnemonics.VPSADBW;
        }

        public static Vpsadbw vpsadbw() => default;

        public readonly struct Pshufb : IAsmInstruction<Pshufb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFB;

            public static implicit operator AsmMnemonicCode(Pshufb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshufb src) => AsmMnemonics.PSHUFB;
        }

        public static Pshufb pshufb() => default;

        public readonly struct Vpshufb : IAsmInstruction<Vpshufb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFB;

            public static implicit operator AsmMnemonicCode(Vpshufb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpshufb src) => AsmMnemonics.VPSHUFB;
        }

        public static Vpshufb vpshufb() => default;

        public readonly struct Pshufd : IAsmInstruction<Pshufd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFD;

            public static implicit operator AsmMnemonicCode(Pshufd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshufd src) => AsmMnemonics.PSHUFD;
        }

        public static Pshufd pshufd() => default;

        public readonly struct Vpshufd : IAsmInstruction<Vpshufd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFD;

            public static implicit operator AsmMnemonicCode(Vpshufd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpshufd src) => AsmMnemonics.VPSHUFD;
        }

        public static Vpshufd vpshufd() => default;

        public readonly struct Pshufhw : IAsmInstruction<Pshufhw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFHW;

            public static implicit operator AsmMnemonicCode(Pshufhw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshufhw src) => AsmMnemonics.PSHUFHW;
        }

        public static Pshufhw pshufhw() => default;

        public readonly struct Vpshufhw : IAsmInstruction<Vpshufhw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFHW;

            public static implicit operator AsmMnemonicCode(Vpshufhw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpshufhw src) => AsmMnemonics.VPSHUFHW;
        }

        public static Vpshufhw vpshufhw() => default;

        public readonly struct Pshuflw : IAsmInstruction<Pshuflw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFLW;

            public static implicit operator AsmMnemonicCode(Pshuflw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshuflw src) => AsmMnemonics.PSHUFLW;
        }

        public static Pshuflw pshuflw() => default;

        public readonly struct Vpshuflw : IAsmInstruction<Vpshuflw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFLW;

            public static implicit operator AsmMnemonicCode(Vpshuflw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpshuflw src) => AsmMnemonics.VPSHUFLW;
        }

        public static Vpshuflw vpshuflw() => default;

        public readonly struct Pshufw : IAsmInstruction<Pshufw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFW;

            public static implicit operator AsmMnemonicCode(Pshufw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pshufw src) => AsmMnemonics.PSHUFW;
        }

        public static Pshufw pshufw() => default;

        public readonly struct Psignb : IAsmInstruction<Psignb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSIGNB;

            public static implicit operator AsmMnemonicCode(Psignb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psignb src) => AsmMnemonics.PSIGNB;
        }

        public static Psignb psignb() => default;

        public readonly struct Psignw : IAsmInstruction<Psignw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSIGNW;

            public static implicit operator AsmMnemonicCode(Psignw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psignw src) => AsmMnemonics.PSIGNW;
        }

        public static Psignw psignw() => default;

        public readonly struct Psignd : IAsmInstruction<Psignd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSIGND;

            public static implicit operator AsmMnemonicCode(Psignd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psignd src) => AsmMnemonics.PSIGND;
        }

        public static Psignd psignd() => default;

        public readonly struct Vpsignb : IAsmInstruction<Vpsignb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSIGNB;

            public static implicit operator AsmMnemonicCode(Vpsignb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsignb src) => AsmMnemonics.VPSIGNB;
        }

        public static Vpsignb vpsignb() => default;

        public readonly struct Vpsignw : IAsmInstruction<Vpsignw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSIGNW;

            public static implicit operator AsmMnemonicCode(Vpsignw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsignw src) => AsmMnemonics.VPSIGNW;
        }

        public static Vpsignw vpsignw() => default;

        public readonly struct Vpsignd : IAsmInstruction<Vpsignd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSIGND;

            public static implicit operator AsmMnemonicCode(Vpsignd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsignd src) => AsmMnemonics.VPSIGND;
        }

        public static Vpsignd vpsignd() => default;

        public readonly struct Pslldq : IAsmInstruction<Pslldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLDQ;

            public static implicit operator AsmMnemonicCode(Pslldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pslldq src) => AsmMnemonics.PSLLDQ;
        }

        public static Pslldq pslldq() => default;

        public readonly struct Vpslldq : IAsmInstruction<Vpslldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLDQ;

            public static implicit operator AsmMnemonicCode(Vpslldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpslldq src) => AsmMnemonics.VPSLLDQ;
        }

        public static Vpslldq vpslldq() => default;

        public readonly struct Psllw : IAsmInstruction<Psllw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLW;

            public static implicit operator AsmMnemonicCode(Psllw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psllw src) => AsmMnemonics.PSLLW;
        }

        public static Psllw psllw() => default;

        public readonly struct Pslld : IAsmInstruction<Pslld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLD;

            public static implicit operator AsmMnemonicCode(Pslld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pslld src) => AsmMnemonics.PSLLD;
        }

        public static Pslld pslld() => default;

        public readonly struct Psllq : IAsmInstruction<Psllq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLQ;

            public static implicit operator AsmMnemonicCode(Psllq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psllq src) => AsmMnemonics.PSLLQ;
        }

        public static Psllq psllq() => default;

        public readonly struct Vpsllw : IAsmInstruction<Vpsllw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLW;

            public static implicit operator AsmMnemonicCode(Vpsllw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsllw src) => AsmMnemonics.VPSLLW;
        }

        public static Vpsllw vpsllw() => default;

        public readonly struct Vpslld : IAsmInstruction<Vpslld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLD;

            public static implicit operator AsmMnemonicCode(Vpslld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpslld src) => AsmMnemonics.VPSLLD;
        }

        public static Vpslld vpslld() => default;

        public readonly struct Vpsllq : IAsmInstruction<Vpsllq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLQ;

            public static implicit operator AsmMnemonicCode(Vpsllq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsllq src) => AsmMnemonics.VPSLLQ;
        }

        public static Vpsllq vpsllq() => default;

        public readonly struct Psraw : IAsmInstruction<Psraw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRAW;

            public static implicit operator AsmMnemonicCode(Psraw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psraw src) => AsmMnemonics.PSRAW;
        }

        public static Psraw psraw() => default;

        public readonly struct Psrad : IAsmInstruction<Psrad>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRAD;

            public static implicit operator AsmMnemonicCode(Psrad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrad src) => AsmMnemonics.PSRAD;
        }

        public static Psrad psrad() => default;

        public readonly struct Vpsraw : IAsmInstruction<Vpsraw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRAW;

            public static implicit operator AsmMnemonicCode(Vpsraw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsraw src) => AsmMnemonics.VPSRAW;
        }

        public static Vpsraw vpsraw() => default;

        public readonly struct Vpsrad : IAsmInstruction<Vpsrad>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRAD;

            public static implicit operator AsmMnemonicCode(Vpsrad src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrad src) => AsmMnemonics.VPSRAD;
        }

        public static Vpsrad vpsrad() => default;

        public readonly struct Psrldq : IAsmInstruction<Psrldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLDQ;

            public static implicit operator AsmMnemonicCode(Psrldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrldq src) => AsmMnemonics.PSRLDQ;
        }

        public static Psrldq psrldq() => default;

        public readonly struct Vpsrldq : IAsmInstruction<Vpsrldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLDQ;

            public static implicit operator AsmMnemonicCode(Vpsrldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrldq src) => AsmMnemonics.VPSRLDQ;
        }

        public static Vpsrldq vpsrldq() => default;

        public readonly struct Psrlw : IAsmInstruction<Psrlw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLW;

            public static implicit operator AsmMnemonicCode(Psrlw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrlw src) => AsmMnemonics.PSRLW;
        }

        public static Psrlw psrlw() => default;

        public readonly struct Psrld : IAsmInstruction<Psrld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLD;

            public static implicit operator AsmMnemonicCode(Psrld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrld src) => AsmMnemonics.PSRLD;
        }

        public static Psrld psrld() => default;

        public readonly struct Psrlq : IAsmInstruction<Psrlq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLQ;

            public static implicit operator AsmMnemonicCode(Psrlq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psrlq src) => AsmMnemonics.PSRLQ;
        }

        public static Psrlq psrlq() => default;

        public readonly struct Vpsrlw : IAsmInstruction<Vpsrlw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLW;

            public static implicit operator AsmMnemonicCode(Vpsrlw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrlw src) => AsmMnemonics.VPSRLW;
        }

        public static Vpsrlw vpsrlw() => default;

        public readonly struct Vpsrld : IAsmInstruction<Vpsrld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLD;

            public static implicit operator AsmMnemonicCode(Vpsrld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrld src) => AsmMnemonics.VPSRLD;
        }

        public static Vpsrld vpsrld() => default;

        public readonly struct Vpsrlq : IAsmInstruction<Vpsrlq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLQ;

            public static implicit operator AsmMnemonicCode(Vpsrlq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrlq src) => AsmMnemonics.VPSRLQ;
        }

        public static Vpsrlq vpsrlq() => default;

        public readonly struct Psubb : IAsmInstruction<Psubb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBB;

            public static implicit operator AsmMnemonicCode(Psubb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubb src) => AsmMnemonics.PSUBB;
        }

        public static Psubb psubb() => default;

        public readonly struct Psubw : IAsmInstruction<Psubw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBW;

            public static implicit operator AsmMnemonicCode(Psubw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubw src) => AsmMnemonics.PSUBW;
        }

        public static Psubw psubw() => default;

        public readonly struct Psubd : IAsmInstruction<Psubd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBD;

            public static implicit operator AsmMnemonicCode(Psubd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubd src) => AsmMnemonics.PSUBD;
        }

        public static Psubd psubd() => default;

        public readonly struct Vpsubb : IAsmInstruction<Vpsubb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBB;

            public static implicit operator AsmMnemonicCode(Vpsubb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubb src) => AsmMnemonics.VPSUBB;
        }

        public static Vpsubb vpsubb() => default;

        public readonly struct Vpsubw : IAsmInstruction<Vpsubw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBW;

            public static implicit operator AsmMnemonicCode(Vpsubw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubw src) => AsmMnemonics.VPSUBW;
        }

        public static Vpsubw vpsubw() => default;

        public readonly struct Vpsubd : IAsmInstruction<Vpsubd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBD;

            public static implicit operator AsmMnemonicCode(Vpsubd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubd src) => AsmMnemonics.VPSUBD;
        }

        public static Vpsubd vpsubd() => default;

        public readonly struct Psubq : IAsmInstruction<Psubq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBQ;

            public static implicit operator AsmMnemonicCode(Psubq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubq src) => AsmMnemonics.PSUBQ;
        }

        public static Psubq psubq() => default;

        public readonly struct Vpsubq : IAsmInstruction<Vpsubq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBQ;

            public static implicit operator AsmMnemonicCode(Vpsubq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubq src) => AsmMnemonics.VPSUBQ;
        }

        public static Vpsubq vpsubq() => default;

        public readonly struct Psubsb : IAsmInstruction<Psubsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBSB;

            public static implicit operator AsmMnemonicCode(Psubsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubsb src) => AsmMnemonics.PSUBSB;
        }

        public static Psubsb psubsb() => default;

        public readonly struct Psubsw : IAsmInstruction<Psubsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBSW;

            public static implicit operator AsmMnemonicCode(Psubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubsw src) => AsmMnemonics.PSUBSW;
        }

        public static Psubsw psubsw() => default;

        public readonly struct Vpsubsb : IAsmInstruction<Vpsubsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBSB;

            public static implicit operator AsmMnemonicCode(Vpsubsb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubsb src) => AsmMnemonics.VPSUBSB;
        }

        public static Vpsubsb vpsubsb() => default;

        public readonly struct Vpsubsw : IAsmInstruction<Vpsubsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBSW;

            public static implicit operator AsmMnemonicCode(Vpsubsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubsw src) => AsmMnemonics.VPSUBSW;
        }

        public static Vpsubsw vpsubsw() => default;

        public readonly struct Psubusb : IAsmInstruction<Psubusb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBUSB;

            public static implicit operator AsmMnemonicCode(Psubusb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubusb src) => AsmMnemonics.PSUBUSB;
        }

        public static Psubusb psubusb() => default;

        public readonly struct Psubusw : IAsmInstruction<Psubusw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBUSW;

            public static implicit operator AsmMnemonicCode(Psubusw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Psubusw src) => AsmMnemonics.PSUBUSW;
        }

        public static Psubusw psubusw() => default;

        public readonly struct Vpsubusb : IAsmInstruction<Vpsubusb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBUSB;

            public static implicit operator AsmMnemonicCode(Vpsubusb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubusb src) => AsmMnemonics.VPSUBUSB;
        }

        public static Vpsubusb vpsubusb() => default;

        public readonly struct Vpsubusw : IAsmInstruction<Vpsubusw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBUSW;

            public static implicit operator AsmMnemonicCode(Vpsubusw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsubusw src) => AsmMnemonics.VPSUBUSW;
        }

        public static Vpsubusw vpsubusw() => default;

        public readonly struct Ptest : IAsmInstruction<Ptest>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PTEST;

            public static implicit operator AsmMnemonicCode(Ptest src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ptest src) => AsmMnemonics.PTEST;
        }

        public static Ptest ptest() => default;

        public readonly struct Vptest : IAsmInstruction<Vptest>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPTEST;

            public static implicit operator AsmMnemonicCode(Vptest src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vptest src) => AsmMnemonics.VPTEST;
        }

        public static Vptest vptest() => default;

        public readonly struct Punpckhbw : IAsmInstruction<Punpckhbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHBW;

            public static implicit operator AsmMnemonicCode(Punpckhbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckhbw src) => AsmMnemonics.PUNPCKHBW;
        }

        public static Punpckhbw punpckhbw() => default;

        public readonly struct Punpckhwd : IAsmInstruction<Punpckhwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHWD;

            public static implicit operator AsmMnemonicCode(Punpckhwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckhwd src) => AsmMnemonics.PUNPCKHWD;
        }

        public static Punpckhwd punpckhwd() => default;

        public readonly struct Punpckhdq : IAsmInstruction<Punpckhdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHDQ;

            public static implicit operator AsmMnemonicCode(Punpckhdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckhdq src) => AsmMnemonics.PUNPCKHDQ;
        }

        public static Punpckhdq punpckhdq() => default;

        public readonly struct Punpckhqdq : IAsmInstruction<Punpckhqdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHQDQ;

            public static implicit operator AsmMnemonicCode(Punpckhqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckhqdq src) => AsmMnemonics.PUNPCKHQDQ;
        }

        public static Punpckhqdq punpckhqdq() => default;

        public readonly struct Vpunpckhbw : IAsmInstruction<Vpunpckhbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHBW;

            public static implicit operator AsmMnemonicCode(Vpunpckhbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckhbw src) => AsmMnemonics.VPUNPCKHBW;
        }

        public static Vpunpckhbw vpunpckhbw() => default;

        public readonly struct Vpunpckhwd : IAsmInstruction<Vpunpckhwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHWD;

            public static implicit operator AsmMnemonicCode(Vpunpckhwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckhwd src) => AsmMnemonics.VPUNPCKHWD;
        }

        public static Vpunpckhwd vpunpckhwd() => default;

        public readonly struct Vpunpckhdq : IAsmInstruction<Vpunpckhdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHDQ;

            public static implicit operator AsmMnemonicCode(Vpunpckhdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckhdq src) => AsmMnemonics.VPUNPCKHDQ;
        }

        public static Vpunpckhdq vpunpckhdq() => default;

        public readonly struct Vpunpckhqdq : IAsmInstruction<Vpunpckhqdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHQDQ;

            public static implicit operator AsmMnemonicCode(Vpunpckhqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckhqdq src) => AsmMnemonics.VPUNPCKHQDQ;
        }

        public static Vpunpckhqdq vpunpckhqdq() => default;

        public readonly struct Punpcklbw : IAsmInstruction<Punpcklbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLBW;

            public static implicit operator AsmMnemonicCode(Punpcklbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpcklbw src) => AsmMnemonics.PUNPCKLBW;
        }

        public static Punpcklbw punpcklbw() => default;

        public readonly struct Punpcklwd : IAsmInstruction<Punpcklwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLWD;

            public static implicit operator AsmMnemonicCode(Punpcklwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpcklwd src) => AsmMnemonics.PUNPCKLWD;
        }

        public static Punpcklwd punpcklwd() => default;

        public readonly struct Punpckldq : IAsmInstruction<Punpckldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLDQ;

            public static implicit operator AsmMnemonicCode(Punpckldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpckldq src) => AsmMnemonics.PUNPCKLDQ;
        }

        public static Punpckldq punpckldq() => default;

        public readonly struct Punpcklqdq : IAsmInstruction<Punpcklqdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLQDQ;

            public static implicit operator AsmMnemonicCode(Punpcklqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Punpcklqdq src) => AsmMnemonics.PUNPCKLQDQ;
        }

        public static Punpcklqdq punpcklqdq() => default;

        public readonly struct Vpunpcklbw : IAsmInstruction<Vpunpcklbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLBW;

            public static implicit operator AsmMnemonicCode(Vpunpcklbw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpcklbw src) => AsmMnemonics.VPUNPCKLBW;
        }

        public static Vpunpcklbw vpunpcklbw() => default;

        public readonly struct Vpunpcklwd : IAsmInstruction<Vpunpcklwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLWD;

            public static implicit operator AsmMnemonicCode(Vpunpcklwd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpcklwd src) => AsmMnemonics.VPUNPCKLWD;
        }

        public static Vpunpcklwd vpunpcklwd() => default;

        public readonly struct Vpunpckldq : IAsmInstruction<Vpunpckldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLDQ;

            public static implicit operator AsmMnemonicCode(Vpunpckldq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpckldq src) => AsmMnemonics.VPUNPCKLDQ;
        }

        public static Vpunpckldq vpunpckldq() => default;

        public readonly struct Vpunpcklqdq : IAsmInstruction<Vpunpcklqdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLQDQ;

            public static implicit operator AsmMnemonicCode(Vpunpcklqdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpunpcklqdq src) => AsmMnemonics.VPUNPCKLQDQ;
        }

        public static Vpunpcklqdq vpunpcklqdq() => default;

        public readonly struct Push : IAsmInstruction<Push>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSH;

            public static implicit operator AsmMnemonicCode(Push src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Push src) => AsmMnemonics.PUSH;
        }

        public static Push push() => default;

        public readonly struct Pushq : IAsmInstruction<Pushq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHQ;

            public static implicit operator AsmMnemonicCode(Pushq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushq src) => AsmMnemonics.PUSHQ;
        }

        public static Pushq pushq() => default;

        public readonly struct Pushw : IAsmInstruction<Pushw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHW;

            public static implicit operator AsmMnemonicCode(Pushw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pushw src) => AsmMnemonics.PUSHW;
        }

        public static Pushw pushw() => default;

        public readonly struct Pxor : IAsmInstruction<Pxor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PXOR;

            public static implicit operator AsmMnemonicCode(Pxor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Pxor src) => AsmMnemonics.PXOR;
        }

        public static Pxor pxor() => default;

        public readonly struct Vpxor : IAsmInstruction<Vpxor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPXOR;

            public static implicit operator AsmMnemonicCode(Vpxor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpxor src) => AsmMnemonics.VPXOR;
        }

        public static Vpxor vpxor() => default;

        public readonly struct Rcl : IAsmInstruction<Rcl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCL;

            public static implicit operator AsmMnemonicCode(Rcl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rcl src) => AsmMnemonics.RCL;
        }

        public static Rcl rcl() => default;

        public readonly struct Rcr : IAsmInstruction<Rcr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCR;

            public static implicit operator AsmMnemonicCode(Rcr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rcr src) => AsmMnemonics.RCR;
        }

        public static Rcr rcr() => default;

        public readonly struct Rol : IAsmInstruction<Rol>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROL;

            public static implicit operator AsmMnemonicCode(Rol src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rol src) => AsmMnemonics.ROL;
        }

        public static Rol rol() => default;

        public readonly struct Ror : IAsmInstruction<Ror>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROR;

            public static implicit operator AsmMnemonicCode(Ror src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ror src) => AsmMnemonics.ROR;
        }

        public static Ror ror() => default;

        public readonly struct Rcpps : IAsmInstruction<Rcpps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCPPS;

            public static implicit operator AsmMnemonicCode(Rcpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rcpps src) => AsmMnemonics.RCPPS;
        }

        public static Rcpps rcpps() => default;

        public readonly struct Vrcpps : IAsmInstruction<Vrcpps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRCPPS;

            public static implicit operator AsmMnemonicCode(Vrcpps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vrcpps src) => AsmMnemonics.VRCPPS;
        }

        public static Vrcpps vrcpps() => default;

        public readonly struct Rcpss : IAsmInstruction<Rcpss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCPSS;

            public static implicit operator AsmMnemonicCode(Rcpss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rcpss src) => AsmMnemonics.RCPSS;
        }

        public static Rcpss rcpss() => default;

        public readonly struct Vrcpss : IAsmInstruction<Vrcpss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRCPSS;

            public static implicit operator AsmMnemonicCode(Vrcpss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vrcpss src) => AsmMnemonics.VRCPSS;
        }

        public static Vrcpss vrcpss() => default;

        public readonly struct Rdfsbase : IAsmInstruction<Rdfsbase>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDFSBASE;

            public static implicit operator AsmMnemonicCode(Rdfsbase src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdfsbase src) => AsmMnemonics.RDFSBASE;
        }

        public static Rdfsbase rdfsbase() => default;

        public readonly struct Rdgsbase : IAsmInstruction<Rdgsbase>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDGSBASE;

            public static implicit operator AsmMnemonicCode(Rdgsbase src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdgsbase src) => AsmMnemonics.RDGSBASE;
        }

        public static Rdgsbase rdgsbase() => default;

        public readonly struct Rdrand : IAsmInstruction<Rdrand>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDRAND;

            public static implicit operator AsmMnemonicCode(Rdrand src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rdrand src) => AsmMnemonics.RDRAND;
        }

        public static Rdrand rdrand() => default;

        public readonly struct Rep_ins : IAsmInstruction<Rep_ins>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_INS;

            public static implicit operator AsmMnemonicCode(Rep_ins src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_ins src) => AsmMnemonics.REP_INS;
        }

        public static Rep_ins rep_ins() => default;

        public readonly struct Rep_movs : IAsmInstruction<Rep_movs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_MOVS;

            public static implicit operator AsmMnemonicCode(Rep_movs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_movs src) => AsmMnemonics.REP_MOVS;
        }

        public static Rep_movs rep_movs() => default;

        public readonly struct Rep_outs : IAsmInstruction<Rep_outs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_OUTS;

            public static implicit operator AsmMnemonicCode(Rep_outs src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_outs src) => AsmMnemonics.REP_OUTS;
        }

        public static Rep_outs rep_outs() => default;

        public readonly struct Rep_lods : IAsmInstruction<Rep_lods>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_LODS;

            public static implicit operator AsmMnemonicCode(Rep_lods src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_lods src) => AsmMnemonics.REP_LODS;
        }

        public static Rep_lods rep_lods() => default;

        public readonly struct Rep_stos : IAsmInstruction<Rep_stos>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_STOS;

            public static implicit operator AsmMnemonicCode(Rep_stos src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rep_stos src) => AsmMnemonics.REP_STOS;
        }

        public static Rep_stos rep_stos() => default;

        public readonly struct Repe_cmps : IAsmInstruction<Repe_cmps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPE_CMPS;

            public static implicit operator AsmMnemonicCode(Repe_cmps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Repe_cmps src) => AsmMnemonics.REPE_CMPS;
        }

        public static Repe_cmps repe_cmps() => default;

        public readonly struct Repe_scas : IAsmInstruction<Repe_scas>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPE_SCAS;

            public static implicit operator AsmMnemonicCode(Repe_scas src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Repe_scas src) => AsmMnemonics.REPE_SCAS;
        }

        public static Repe_scas repe_scas() => default;

        public readonly struct Repne_cmps : IAsmInstruction<Repne_cmps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPNE_CMPS;

            public static implicit operator AsmMnemonicCode(Repne_cmps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Repne_cmps src) => AsmMnemonics.REPNE_CMPS;
        }

        public static Repne_cmps repne_cmps() => default;

        public readonly struct Repne_scas : IAsmInstruction<Repne_scas>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPNE_SCAS;

            public static implicit operator AsmMnemonicCode(Repne_scas src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Repne_scas src) => AsmMnemonics.REPNE_SCAS;
        }

        public static Repne_scas repne_scas() => default;

        public readonly struct Ret : IAsmInstruction<Ret>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RET;

            public static implicit operator AsmMnemonicCode(Ret src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ret src) => AsmMnemonics.RET;
        }

        public static Ret ret() => default;

        public readonly struct Rorx : IAsmInstruction<Rorx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RORX;

            public static implicit operator AsmMnemonicCode(Rorx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rorx src) => AsmMnemonics.RORX;
        }

        public static Rorx rorx() => default;

        public readonly struct Roundpd : IAsmInstruction<Roundpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDPD;

            public static implicit operator AsmMnemonicCode(Roundpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Roundpd src) => AsmMnemonics.ROUNDPD;
        }

        public static Roundpd roundpd() => default;

        public readonly struct Vroundpd : IAsmInstruction<Vroundpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDPD;

            public static implicit operator AsmMnemonicCode(Vroundpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vroundpd src) => AsmMnemonics.VROUNDPD;
        }

        public static Vroundpd vroundpd() => default;

        public readonly struct Roundps : IAsmInstruction<Roundps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDPS;

            public static implicit operator AsmMnemonicCode(Roundps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Roundps src) => AsmMnemonics.ROUNDPS;
        }

        public static Roundps roundps() => default;

        public readonly struct Vroundps : IAsmInstruction<Vroundps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDPS;

            public static implicit operator AsmMnemonicCode(Vroundps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vroundps src) => AsmMnemonics.VROUNDPS;
        }

        public static Vroundps vroundps() => default;

        public readonly struct Roundsd : IAsmInstruction<Roundsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDSD;

            public static implicit operator AsmMnemonicCode(Roundsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Roundsd src) => AsmMnemonics.ROUNDSD;
        }

        public static Roundsd roundsd() => default;

        public readonly struct Vroundsd : IAsmInstruction<Vroundsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDSD;

            public static implicit operator AsmMnemonicCode(Vroundsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vroundsd src) => AsmMnemonics.VROUNDSD;
        }

        public static Vroundsd vroundsd() => default;

        public readonly struct Roundss : IAsmInstruction<Roundss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDSS;

            public static implicit operator AsmMnemonicCode(Roundss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Roundss src) => AsmMnemonics.ROUNDSS;
        }

        public static Roundss roundss() => default;

        public readonly struct Vroundss : IAsmInstruction<Vroundss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDSS;

            public static implicit operator AsmMnemonicCode(Vroundss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vroundss src) => AsmMnemonics.VROUNDSS;
        }

        public static Vroundss vroundss() => default;

        public readonly struct Rsqrtps : IAsmInstruction<Rsqrtps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RSQRTPS;

            public static implicit operator AsmMnemonicCode(Rsqrtps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rsqrtps src) => AsmMnemonics.RSQRTPS;
        }

        public static Rsqrtps rsqrtps() => default;

        public readonly struct Vrsqrtps : IAsmInstruction<Vrsqrtps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRSQRTPS;

            public static implicit operator AsmMnemonicCode(Vrsqrtps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vrsqrtps src) => AsmMnemonics.VRSQRTPS;
        }

        public static Vrsqrtps vrsqrtps() => default;

        public readonly struct Rsqrtss : IAsmInstruction<Rsqrtss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RSQRTSS;

            public static implicit operator AsmMnemonicCode(Rsqrtss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Rsqrtss src) => AsmMnemonics.RSQRTSS;
        }

        public static Rsqrtss rsqrtss() => default;

        public readonly struct Vrsqrtss : IAsmInstruction<Vrsqrtss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRSQRTSS;

            public static implicit operator AsmMnemonicCode(Vrsqrtss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vrsqrtss src) => AsmMnemonics.VRSQRTSS;
        }

        public static Vrsqrtss vrsqrtss() => default;

        public readonly struct Sal : IAsmInstruction<Sal>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SAL;

            public static implicit operator AsmMnemonicCode(Sal src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sal src) => AsmMnemonics.SAL;
        }

        public static Sal sal() => default;

        public readonly struct Sar : IAsmInstruction<Sar>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SAR;

            public static implicit operator AsmMnemonicCode(Sar src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sar src) => AsmMnemonics.SAR;
        }

        public static Sar sar() => default;

        public readonly struct Shl : IAsmInstruction<Shl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHL;

            public static implicit operator AsmMnemonicCode(Shl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shl src) => AsmMnemonics.SHL;
        }

        public static Shl shl() => default;

        public readonly struct Shr : IAsmInstruction<Shr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHR;

            public static implicit operator AsmMnemonicCode(Shr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shr src) => AsmMnemonics.SHR;
        }

        public static Shr shr() => default;

        public readonly struct Sarx : IAsmInstruction<Sarx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SARX;

            public static implicit operator AsmMnemonicCode(Sarx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sarx src) => AsmMnemonics.SARX;
        }

        public static Sarx sarx() => default;

        public readonly struct Shlx : IAsmInstruction<Shlx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHLX;

            public static implicit operator AsmMnemonicCode(Shlx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shlx src) => AsmMnemonics.SHLX;
        }

        public static Shlx shlx() => default;

        public readonly struct Shrx : IAsmInstruction<Shrx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHRX;

            public static implicit operator AsmMnemonicCode(Shrx src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shrx src) => AsmMnemonics.SHRX;
        }

        public static Shrx shrx() => default;

        public readonly struct Sbb : IAsmInstruction<Sbb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SBB;

            public static implicit operator AsmMnemonicCode(Sbb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sbb src) => AsmMnemonics.SBB;
        }

        public static Sbb sbb() => default;

        public readonly struct Scas : IAsmInstruction<Scas>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SCAS;

            public static implicit operator AsmMnemonicCode(Scas src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Scas src) => AsmMnemonics.SCAS;
        }

        public static Scas scas() => default;

        public readonly struct Seta : IAsmInstruction<Seta>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETA;

            public static implicit operator AsmMnemonicCode(Seta src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Seta src) => AsmMnemonics.SETA;
        }

        public static Seta seta() => default;

        public readonly struct Setae : IAsmInstruction<Setae>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETAE;

            public static implicit operator AsmMnemonicCode(Setae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setae src) => AsmMnemonics.SETAE;
        }

        public static Setae setae() => default;

        public readonly struct Setb : IAsmInstruction<Setb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETB;

            public static implicit operator AsmMnemonicCode(Setb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setb src) => AsmMnemonics.SETB;
        }

        public static Setb setb() => default;

        public readonly struct Setbe : IAsmInstruction<Setbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETBE;

            public static implicit operator AsmMnemonicCode(Setbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setbe src) => AsmMnemonics.SETBE;
        }

        public static Setbe setbe() => default;

        public readonly struct Setc : IAsmInstruction<Setc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETC;

            public static implicit operator AsmMnemonicCode(Setc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setc src) => AsmMnemonics.SETC;
        }

        public static Setc setc() => default;

        public readonly struct Sete : IAsmInstruction<Sete>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETE;

            public static implicit operator AsmMnemonicCode(Sete src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sete src) => AsmMnemonics.SETE;
        }

        public static Sete sete() => default;

        public readonly struct Setg : IAsmInstruction<Setg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETG;

            public static implicit operator AsmMnemonicCode(Setg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setg src) => AsmMnemonics.SETG;
        }

        public static Setg setg() => default;

        public readonly struct Setge : IAsmInstruction<Setge>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETGE;

            public static implicit operator AsmMnemonicCode(Setge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setge src) => AsmMnemonics.SETGE;
        }

        public static Setge setge() => default;

        public readonly struct Setl : IAsmInstruction<Setl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETL;

            public static implicit operator AsmMnemonicCode(Setl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setl src) => AsmMnemonics.SETL;
        }

        public static Setl setl() => default;

        public readonly struct Setle : IAsmInstruction<Setle>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETLE;

            public static implicit operator AsmMnemonicCode(Setle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setle src) => AsmMnemonics.SETLE;
        }

        public static Setle setle() => default;

        public readonly struct Setna : IAsmInstruction<Setna>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNA;

            public static implicit operator AsmMnemonicCode(Setna src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setna src) => AsmMnemonics.SETNA;
        }

        public static Setna setna() => default;

        public readonly struct Setnae : IAsmInstruction<Setnae>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNAE;

            public static implicit operator AsmMnemonicCode(Setnae src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnae src) => AsmMnemonics.SETNAE;
        }

        public static Setnae setnae() => default;

        public readonly struct Setnb : IAsmInstruction<Setnb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNB;

            public static implicit operator AsmMnemonicCode(Setnb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnb src) => AsmMnemonics.SETNB;
        }

        public static Setnb setnb() => default;

        public readonly struct Setnbe : IAsmInstruction<Setnbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNBE;

            public static implicit operator AsmMnemonicCode(Setnbe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnbe src) => AsmMnemonics.SETNBE;
        }

        public static Setnbe setnbe() => default;

        public readonly struct Setnc : IAsmInstruction<Setnc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNC;

            public static implicit operator AsmMnemonicCode(Setnc src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnc src) => AsmMnemonics.SETNC;
        }

        public static Setnc setnc() => default;

        public readonly struct Setne : IAsmInstruction<Setne>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNE;

            public static implicit operator AsmMnemonicCode(Setne src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setne src) => AsmMnemonics.SETNE;
        }

        public static Setne setne() => default;

        public readonly struct Setng : IAsmInstruction<Setng>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNG;

            public static implicit operator AsmMnemonicCode(Setng src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setng src) => AsmMnemonics.SETNG;
        }

        public static Setng setng() => default;

        public readonly struct Setnge : IAsmInstruction<Setnge>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNGE;

            public static implicit operator AsmMnemonicCode(Setnge src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnge src) => AsmMnemonics.SETNGE;
        }

        public static Setnge setnge() => default;

        public readonly struct Setnl : IAsmInstruction<Setnl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNL;

            public static implicit operator AsmMnemonicCode(Setnl src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnl src) => AsmMnemonics.SETNL;
        }

        public static Setnl setnl() => default;

        public readonly struct Setnle : IAsmInstruction<Setnle>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNLE;

            public static implicit operator AsmMnemonicCode(Setnle src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnle src) => AsmMnemonics.SETNLE;
        }

        public static Setnle setnle() => default;

        public readonly struct Setno : IAsmInstruction<Setno>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNO;

            public static implicit operator AsmMnemonicCode(Setno src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setno src) => AsmMnemonics.SETNO;
        }

        public static Setno setno() => default;

        public readonly struct Setnp : IAsmInstruction<Setnp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNP;

            public static implicit operator AsmMnemonicCode(Setnp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnp src) => AsmMnemonics.SETNP;
        }

        public static Setnp setnp() => default;

        public readonly struct Setns : IAsmInstruction<Setns>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNS;

            public static implicit operator AsmMnemonicCode(Setns src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setns src) => AsmMnemonics.SETNS;
        }

        public static Setns setns() => default;

        public readonly struct Setnz : IAsmInstruction<Setnz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNZ;

            public static implicit operator AsmMnemonicCode(Setnz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setnz src) => AsmMnemonics.SETNZ;
        }

        public static Setnz setnz() => default;

        public readonly struct Seto : IAsmInstruction<Seto>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETO;

            public static implicit operator AsmMnemonicCode(Seto src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Seto src) => AsmMnemonics.SETO;
        }

        public static Seto seto() => default;

        public readonly struct Setp : IAsmInstruction<Setp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETP;

            public static implicit operator AsmMnemonicCode(Setp src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setp src) => AsmMnemonics.SETP;
        }

        public static Setp setp() => default;

        public readonly struct Setpe : IAsmInstruction<Setpe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETPE;

            public static implicit operator AsmMnemonicCode(Setpe src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setpe src) => AsmMnemonics.SETPE;
        }

        public static Setpe setpe() => default;

        public readonly struct Setpo : IAsmInstruction<Setpo>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETPO;

            public static implicit operator AsmMnemonicCode(Setpo src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setpo src) => AsmMnemonics.SETPO;
        }

        public static Setpo setpo() => default;

        public readonly struct Sets : IAsmInstruction<Sets>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETS;

            public static implicit operator AsmMnemonicCode(Sets src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sets src) => AsmMnemonics.SETS;
        }

        public static Sets sets() => default;

        public readonly struct Setz : IAsmInstruction<Setz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETZ;

            public static implicit operator AsmMnemonicCode(Setz src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Setz src) => AsmMnemonics.SETZ;
        }

        public static Setz setz() => default;

        public readonly struct Sgdt : IAsmInstruction<Sgdt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SGDT;

            public static implicit operator AsmMnemonicCode(Sgdt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sgdt src) => AsmMnemonics.SGDT;
        }

        public static Sgdt sgdt() => default;

        public readonly struct Shld : IAsmInstruction<Shld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHLD;

            public static implicit operator AsmMnemonicCode(Shld src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shld src) => AsmMnemonics.SHLD;
        }

        public static Shld shld() => default;

        public readonly struct Shrd : IAsmInstruction<Shrd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHRD;

            public static implicit operator AsmMnemonicCode(Shrd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shrd src) => AsmMnemonics.SHRD;
        }

        public static Shrd shrd() => default;

        public readonly struct Shufpd : IAsmInstruction<Shufpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHUFPD;

            public static implicit operator AsmMnemonicCode(Shufpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shufpd src) => AsmMnemonics.SHUFPD;
        }

        public static Shufpd shufpd() => default;

        public readonly struct Vshufpd : IAsmInstruction<Vshufpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSHUFPD;

            public static implicit operator AsmMnemonicCode(Vshufpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vshufpd src) => AsmMnemonics.VSHUFPD;
        }

        public static Vshufpd vshufpd() => default;

        public readonly struct Shufps : IAsmInstruction<Shufps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHUFPS;

            public static implicit operator AsmMnemonicCode(Shufps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Shufps src) => AsmMnemonics.SHUFPS;
        }

        public static Shufps shufps() => default;

        public readonly struct Vshufps : IAsmInstruction<Vshufps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSHUFPS;

            public static implicit operator AsmMnemonicCode(Vshufps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vshufps src) => AsmMnemonics.VSHUFPS;
        }

        public static Vshufps vshufps() => default;

        public readonly struct Sidt : IAsmInstruction<Sidt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SIDT;

            public static implicit operator AsmMnemonicCode(Sidt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sidt src) => AsmMnemonics.SIDT;
        }

        public static Sidt sidt() => default;

        public readonly struct Sldt : IAsmInstruction<Sldt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SLDT;

            public static implicit operator AsmMnemonicCode(Sldt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sldt src) => AsmMnemonics.SLDT;
        }

        public static Sldt sldt() => default;

        public readonly struct Smsw : IAsmInstruction<Smsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SMSW;

            public static implicit operator AsmMnemonicCode(Smsw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Smsw src) => AsmMnemonics.SMSW;
        }

        public static Smsw smsw() => default;

        public readonly struct Sqrtpd : IAsmInstruction<Sqrtpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTPD;

            public static implicit operator AsmMnemonicCode(Sqrtpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sqrtpd src) => AsmMnemonics.SQRTPD;
        }

        public static Sqrtpd sqrtpd() => default;

        public readonly struct Vsqrtpd : IAsmInstruction<Vsqrtpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTPD;

            public static implicit operator AsmMnemonicCode(Vsqrtpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsqrtpd src) => AsmMnemonics.VSQRTPD;
        }

        public static Vsqrtpd vsqrtpd() => default;

        public readonly struct Sqrtps : IAsmInstruction<Sqrtps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTPS;

            public static implicit operator AsmMnemonicCode(Sqrtps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sqrtps src) => AsmMnemonics.SQRTPS;
        }

        public static Sqrtps sqrtps() => default;

        public readonly struct Vsqrtps : IAsmInstruction<Vsqrtps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTPS;

            public static implicit operator AsmMnemonicCode(Vsqrtps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsqrtps src) => AsmMnemonics.VSQRTPS;
        }

        public static Vsqrtps vsqrtps() => default;

        public readonly struct Sqrtsd : IAsmInstruction<Sqrtsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTSD;

            public static implicit operator AsmMnemonicCode(Sqrtsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sqrtsd src) => AsmMnemonics.SQRTSD;
        }

        public static Sqrtsd sqrtsd() => default;

        public readonly struct Vsqrtsd : IAsmInstruction<Vsqrtsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTSD;

            public static implicit operator AsmMnemonicCode(Vsqrtsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsqrtsd src) => AsmMnemonics.VSQRTSD;
        }

        public static Vsqrtsd vsqrtsd() => default;

        public readonly struct Sqrtss : IAsmInstruction<Sqrtss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTSS;

            public static implicit operator AsmMnemonicCode(Sqrtss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sqrtss src) => AsmMnemonics.SQRTSS;
        }

        public static Sqrtss sqrtss() => default;

        public readonly struct Vsqrtss : IAsmInstruction<Vsqrtss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTSS;

            public static implicit operator AsmMnemonicCode(Vsqrtss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsqrtss src) => AsmMnemonics.VSQRTSS;
        }

        public static Vsqrtss vsqrtss() => default;

        public readonly struct Stmxcsr : IAsmInstruction<Stmxcsr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STMXCSR;

            public static implicit operator AsmMnemonicCode(Stmxcsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stmxcsr src) => AsmMnemonics.STMXCSR;
        }

        public static Stmxcsr stmxcsr() => default;

        public readonly struct Vstmxcsr : IAsmInstruction<Vstmxcsr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSTMXCSR;

            public static implicit operator AsmMnemonicCode(Vstmxcsr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vstmxcsr src) => AsmMnemonics.VSTMXCSR;
        }

        public static Vstmxcsr vstmxcsr() => default;

        public readonly struct Stos : IAsmInstruction<Stos>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STOS;

            public static implicit operator AsmMnemonicCode(Stos src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Stos src) => AsmMnemonics.STOS;
        }

        public static Stos stos() => default;

        public readonly struct Str : IAsmInstruction<Str>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STR;

            public static implicit operator AsmMnemonicCode(Str src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Str src) => AsmMnemonics.STR;
        }

        public static Str str() => default;

        public readonly struct Sub : IAsmInstruction<Sub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUB;

            public static implicit operator AsmMnemonicCode(Sub src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sub src) => AsmMnemonics.SUB;
        }

        public static Sub sub() => default;

        public readonly struct Subpd : IAsmInstruction<Subpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBPD;

            public static implicit operator AsmMnemonicCode(Subpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Subpd src) => AsmMnemonics.SUBPD;
        }

        public static Subpd subpd() => default;

        public readonly struct Vsubpd : IAsmInstruction<Vsubpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBPD;

            public static implicit operator AsmMnemonicCode(Vsubpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsubpd src) => AsmMnemonics.VSUBPD;
        }

        public static Vsubpd vsubpd() => default;

        public readonly struct Subps : IAsmInstruction<Subps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBPS;

            public static implicit operator AsmMnemonicCode(Subps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Subps src) => AsmMnemonics.SUBPS;
        }

        public static Subps subps() => default;

        public readonly struct Vsubps : IAsmInstruction<Vsubps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBPS;

            public static implicit operator AsmMnemonicCode(Vsubps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsubps src) => AsmMnemonics.VSUBPS;
        }

        public static Vsubps vsubps() => default;

        public readonly struct Subsd : IAsmInstruction<Subsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBSD;

            public static implicit operator AsmMnemonicCode(Subsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Subsd src) => AsmMnemonics.SUBSD;
        }

        public static Subsd subsd() => default;

        public readonly struct Vsubsd : IAsmInstruction<Vsubsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBSD;

            public static implicit operator AsmMnemonicCode(Vsubsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsubsd src) => AsmMnemonics.VSUBSD;
        }

        public static Vsubsd vsubsd() => default;

        public readonly struct Subss : IAsmInstruction<Subss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBSS;

            public static implicit operator AsmMnemonicCode(Subss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Subss src) => AsmMnemonics.SUBSS;
        }

        public static Subss subss() => default;

        public readonly struct Vsubss : IAsmInstruction<Vsubss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBSS;

            public static implicit operator AsmMnemonicCode(Vsubss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vsubss src) => AsmMnemonics.VSUBSS;
        }

        public static Vsubss vsubss() => default;

        public readonly struct Sysexit : IAsmInstruction<Sysexit>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SYSEXIT;

            public static implicit operator AsmMnemonicCode(Sysexit src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sysexit src) => AsmMnemonics.SYSEXIT;
        }

        public static Sysexit sysexit() => default;

        public readonly struct Sysret : IAsmInstruction<Sysret>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SYSRET;

            public static implicit operator AsmMnemonicCode(Sysret src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Sysret src) => AsmMnemonics.SYSRET;
        }

        public static Sysret sysret() => default;

        public readonly struct Test : IAsmInstruction<Test>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.TEST;

            public static implicit operator AsmMnemonicCode(Test src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Test src) => AsmMnemonics.TEST;
        }

        public static Test test() => default;

        public readonly struct Tzcnt : IAsmInstruction<Tzcnt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.TZCNT;

            public static implicit operator AsmMnemonicCode(Tzcnt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Tzcnt src) => AsmMnemonics.TZCNT;
        }

        public static Tzcnt tzcnt() => default;

        public readonly struct Ucomisd : IAsmInstruction<Ucomisd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UCOMISD;

            public static implicit operator AsmMnemonicCode(Ucomisd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ucomisd src) => AsmMnemonics.UCOMISD;
        }

        public static Ucomisd ucomisd() => default;

        public readonly struct Vucomisd : IAsmInstruction<Vucomisd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUCOMISD;

            public static implicit operator AsmMnemonicCode(Vucomisd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vucomisd src) => AsmMnemonics.VUCOMISD;
        }

        public static Vucomisd vucomisd() => default;

        public readonly struct Ucomiss : IAsmInstruction<Ucomiss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UCOMISS;

            public static implicit operator AsmMnemonicCode(Ucomiss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Ucomiss src) => AsmMnemonics.UCOMISS;
        }

        public static Ucomiss ucomiss() => default;

        public readonly struct Vucomiss : IAsmInstruction<Vucomiss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUCOMISS;

            public static implicit operator AsmMnemonicCode(Vucomiss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vucomiss src) => AsmMnemonics.VUCOMISS;
        }

        public static Vucomiss vucomiss() => default;

        public readonly struct Unpckhpd : IAsmInstruction<Unpckhpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKHPD;

            public static implicit operator AsmMnemonicCode(Unpckhpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Unpckhpd src) => AsmMnemonics.UNPCKHPD;
        }

        public static Unpckhpd unpckhpd() => default;

        public readonly struct Vunpckhpd : IAsmInstruction<Vunpckhpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKHPD;

            public static implicit operator AsmMnemonicCode(Vunpckhpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vunpckhpd src) => AsmMnemonics.VUNPCKHPD;
        }

        public static Vunpckhpd vunpckhpd() => default;

        public readonly struct Unpckhps : IAsmInstruction<Unpckhps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKHPS;

            public static implicit operator AsmMnemonicCode(Unpckhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Unpckhps src) => AsmMnemonics.UNPCKHPS;
        }

        public static Unpckhps unpckhps() => default;

        public readonly struct Vunpckhps : IAsmInstruction<Vunpckhps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKHPS;

            public static implicit operator AsmMnemonicCode(Vunpckhps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vunpckhps src) => AsmMnemonics.VUNPCKHPS;
        }

        public static Vunpckhps vunpckhps() => default;

        public readonly struct Unpcklpd : IAsmInstruction<Unpcklpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKLPD;

            public static implicit operator AsmMnemonicCode(Unpcklpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Unpcklpd src) => AsmMnemonics.UNPCKLPD;
        }

        public static Unpcklpd unpcklpd() => default;

        public readonly struct Vunpcklpd : IAsmInstruction<Vunpcklpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKLPD;

            public static implicit operator AsmMnemonicCode(Vunpcklpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vunpcklpd src) => AsmMnemonics.VUNPCKLPD;
        }

        public static Vunpcklpd vunpcklpd() => default;

        public readonly struct Unpcklps : IAsmInstruction<Unpcklps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKLPS;

            public static implicit operator AsmMnemonicCode(Unpcklps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Unpcklps src) => AsmMnemonics.UNPCKLPS;
        }

        public static Unpcklps unpcklps() => default;

        public readonly struct Vunpcklps : IAsmInstruction<Vunpcklps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKLPS;

            public static implicit operator AsmMnemonicCode(Vunpcklps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vunpcklps src) => AsmMnemonics.VUNPCKLPS;
        }

        public static Vunpcklps vunpcklps() => default;

        public readonly struct Vbroadcastss : IAsmInstruction<Vbroadcastss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTSS;

            public static implicit operator AsmMnemonicCode(Vbroadcastss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vbroadcastss src) => AsmMnemonics.VBROADCASTSS;
        }

        public static Vbroadcastss vbroadcastss() => default;

        public readonly struct Vbroadcastsd : IAsmInstruction<Vbroadcastsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTSD;

            public static implicit operator AsmMnemonicCode(Vbroadcastsd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vbroadcastsd src) => AsmMnemonics.VBROADCASTSD;
        }

        public static Vbroadcastsd vbroadcastsd() => default;

        public readonly struct Vbroadcastf128 : IAsmInstruction<Vbroadcastf128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTF128;

            public static implicit operator AsmMnemonicCode(Vbroadcastf128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vbroadcastf128 src) => AsmMnemonics.VBROADCASTF128;
        }

        public static Vbroadcastf128 vbroadcastf128() => default;

        public readonly struct Vcvtph2ps : IAsmInstruction<Vcvtph2ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPH2PS;

            public static implicit operator AsmMnemonicCode(Vcvtph2ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtph2ps src) => AsmMnemonics.VCVTPH2PS;
        }

        public static Vcvtph2ps vcvtph2ps() => default;

        public readonly struct Vcvtps2ph : IAsmInstruction<Vcvtps2ph>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPS2PH;

            public static implicit operator AsmMnemonicCode(Vcvtps2ph src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vcvtps2ph src) => AsmMnemonics.VCVTPS2PH;
        }

        public static Vcvtps2ph vcvtps2ph() => default;

        public readonly struct Verr : IAsmInstruction<Verr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VERR;

            public static implicit operator AsmMnemonicCode(Verr src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Verr src) => AsmMnemonics.VERR;
        }

        public static Verr verr() => default;

        public readonly struct Verw : IAsmInstruction<Verw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VERW;

            public static implicit operator AsmMnemonicCode(Verw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Verw src) => AsmMnemonics.VERW;
        }

        public static Verw verw() => default;

        public readonly struct Vextractf128 : IAsmInstruction<Vextractf128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VEXTRACTF128;

            public static implicit operator AsmMnemonicCode(Vextractf128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vextractf128 src) => AsmMnemonics.VEXTRACTF128;
        }

        public static Vextractf128 vextractf128() => default;

        public readonly struct Vextracti128 : IAsmInstruction<Vextracti128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VEXTRACTI128;

            public static implicit operator AsmMnemonicCode(Vextracti128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vextracti128 src) => AsmMnemonics.VEXTRACTI128;
        }

        public static Vextracti128 vextracti128() => default;

        public readonly struct Vfmadd132pd : IAsmInstruction<Vfmadd132pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132PD;

            public static implicit operator AsmMnemonicCode(Vfmadd132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd132pd src) => AsmMnemonics.VFMADD132PD;
        }

        public static Vfmadd132pd vfmadd132pd() => default;

        public readonly struct Vfmadd213pd : IAsmInstruction<Vfmadd213pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213PD;

            public static implicit operator AsmMnemonicCode(Vfmadd213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd213pd src) => AsmMnemonics.VFMADD213PD;
        }

        public static Vfmadd213pd vfmadd213pd() => default;

        public readonly struct Vfmadd231pd : IAsmInstruction<Vfmadd231pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231PD;

            public static implicit operator AsmMnemonicCode(Vfmadd231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd231pd src) => AsmMnemonics.VFMADD231PD;
        }

        public static Vfmadd231pd vfmadd231pd() => default;

        public readonly struct Vfmadd132ps : IAsmInstruction<Vfmadd132ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132PS;

            public static implicit operator AsmMnemonicCode(Vfmadd132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd132ps src) => AsmMnemonics.VFMADD132PS;
        }

        public static Vfmadd132ps vfmadd132ps() => default;

        public readonly struct Vfmadd213ps : IAsmInstruction<Vfmadd213ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213PS;

            public static implicit operator AsmMnemonicCode(Vfmadd213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd213ps src) => AsmMnemonics.VFMADD213PS;
        }

        public static Vfmadd213ps vfmadd213ps() => default;

        public readonly struct Vfmadd231ps : IAsmInstruction<Vfmadd231ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231PS;

            public static implicit operator AsmMnemonicCode(Vfmadd231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd231ps src) => AsmMnemonics.VFMADD231PS;
        }

        public static Vfmadd231ps vfmadd231ps() => default;

        public readonly struct Vfmadd132sd : IAsmInstruction<Vfmadd132sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132SD;

            public static implicit operator AsmMnemonicCode(Vfmadd132sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd132sd src) => AsmMnemonics.VFMADD132SD;
        }

        public static Vfmadd132sd vfmadd132sd() => default;

        public readonly struct Vfmadd213sd : IAsmInstruction<Vfmadd213sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213SD;

            public static implicit operator AsmMnemonicCode(Vfmadd213sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd213sd src) => AsmMnemonics.VFMADD213SD;
        }

        public static Vfmadd213sd vfmadd213sd() => default;

        public readonly struct Vfmadd231sd : IAsmInstruction<Vfmadd231sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231SD;

            public static implicit operator AsmMnemonicCode(Vfmadd231sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd231sd src) => AsmMnemonics.VFMADD231SD;
        }

        public static Vfmadd231sd vfmadd231sd() => default;

        public readonly struct Vfmadd132ss : IAsmInstruction<Vfmadd132ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132SS;

            public static implicit operator AsmMnemonicCode(Vfmadd132ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd132ss src) => AsmMnemonics.VFMADD132SS;
        }

        public static Vfmadd132ss vfmadd132ss() => default;

        public readonly struct Vfmadd213ss : IAsmInstruction<Vfmadd213ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213SS;

            public static implicit operator AsmMnemonicCode(Vfmadd213ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd213ss src) => AsmMnemonics.VFMADD213SS;
        }

        public static Vfmadd213ss vfmadd213ss() => default;

        public readonly struct Vfmadd231ss : IAsmInstruction<Vfmadd231ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231SS;

            public static implicit operator AsmMnemonicCode(Vfmadd231ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmadd231ss src) => AsmMnemonics.VFMADD231SS;
        }

        public static Vfmadd231ss vfmadd231ss() => default;

        public readonly struct Vfmaddsub132pd : IAsmInstruction<Vfmaddsub132pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB132PD;

            public static implicit operator AsmMnemonicCode(Vfmaddsub132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub132pd src) => AsmMnemonics.VFMADDSUB132PD;
        }

        public static Vfmaddsub132pd vfmaddsub132pd() => default;

        public readonly struct Vfmaddsub213pd : IAsmInstruction<Vfmaddsub213pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB213PD;

            public static implicit operator AsmMnemonicCode(Vfmaddsub213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub213pd src) => AsmMnemonics.VFMADDSUB213PD;
        }

        public static Vfmaddsub213pd vfmaddsub213pd() => default;

        public readonly struct Vfmaddsub231pd : IAsmInstruction<Vfmaddsub231pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB231PD;

            public static implicit operator AsmMnemonicCode(Vfmaddsub231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub231pd src) => AsmMnemonics.VFMADDSUB231PD;
        }

        public static Vfmaddsub231pd vfmaddsub231pd() => default;

        public readonly struct Vfmaddsub132ps : IAsmInstruction<Vfmaddsub132ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB132PS;

            public static implicit operator AsmMnemonicCode(Vfmaddsub132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub132ps src) => AsmMnemonics.VFMADDSUB132PS;
        }

        public static Vfmaddsub132ps vfmaddsub132ps() => default;

        public readonly struct Vfmaddsub213ps : IAsmInstruction<Vfmaddsub213ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB213PS;

            public static implicit operator AsmMnemonicCode(Vfmaddsub213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub213ps src) => AsmMnemonics.VFMADDSUB213PS;
        }

        public static Vfmaddsub213ps vfmaddsub213ps() => default;

        public readonly struct Vfmaddsub231ps : IAsmInstruction<Vfmaddsub231ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB231PS;

            public static implicit operator AsmMnemonicCode(Vfmaddsub231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmaddsub231ps src) => AsmMnemonics.VFMADDSUB231PS;
        }

        public static Vfmaddsub231ps vfmaddsub231ps() => default;

        public readonly struct Vfmsubadd132pd : IAsmInstruction<Vfmsubadd132pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD132PD;

            public static implicit operator AsmMnemonicCode(Vfmsubadd132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd132pd src) => AsmMnemonics.VFMSUBADD132PD;
        }

        public static Vfmsubadd132pd vfmsubadd132pd() => default;

        public readonly struct Vfmsubadd213pd : IAsmInstruction<Vfmsubadd213pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD213PD;

            public static implicit operator AsmMnemonicCode(Vfmsubadd213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd213pd src) => AsmMnemonics.VFMSUBADD213PD;
        }

        public static Vfmsubadd213pd vfmsubadd213pd() => default;

        public readonly struct Vfmsubadd231pd : IAsmInstruction<Vfmsubadd231pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD231PD;

            public static implicit operator AsmMnemonicCode(Vfmsubadd231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd231pd src) => AsmMnemonics.VFMSUBADD231PD;
        }

        public static Vfmsubadd231pd vfmsubadd231pd() => default;

        public readonly struct Vfmsubadd132ps : IAsmInstruction<Vfmsubadd132ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD132PS;

            public static implicit operator AsmMnemonicCode(Vfmsubadd132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd132ps src) => AsmMnemonics.VFMSUBADD132PS;
        }

        public static Vfmsubadd132ps vfmsubadd132ps() => default;

        public readonly struct Vfmsubadd213ps : IAsmInstruction<Vfmsubadd213ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD213PS;

            public static implicit operator AsmMnemonicCode(Vfmsubadd213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd213ps src) => AsmMnemonics.VFMSUBADD213PS;
        }

        public static Vfmsubadd213ps vfmsubadd213ps() => default;

        public readonly struct Vfmsubadd231ps : IAsmInstruction<Vfmsubadd231ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD231PS;

            public static implicit operator AsmMnemonicCode(Vfmsubadd231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsubadd231ps src) => AsmMnemonics.VFMSUBADD231PS;
        }

        public static Vfmsubadd231ps vfmsubadd231ps() => default;

        public readonly struct Vfmsub132pd : IAsmInstruction<Vfmsub132pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132PD;

            public static implicit operator AsmMnemonicCode(Vfmsub132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub132pd src) => AsmMnemonics.VFMSUB132PD;
        }

        public static Vfmsub132pd vfmsub132pd() => default;

        public readonly struct Vfmsub213pd : IAsmInstruction<Vfmsub213pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213PD;

            public static implicit operator AsmMnemonicCode(Vfmsub213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub213pd src) => AsmMnemonics.VFMSUB213PD;
        }

        public static Vfmsub213pd vfmsub213pd() => default;

        public readonly struct Vfmsub231pd : IAsmInstruction<Vfmsub231pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231PD;

            public static implicit operator AsmMnemonicCode(Vfmsub231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub231pd src) => AsmMnemonics.VFMSUB231PD;
        }

        public static Vfmsub231pd vfmsub231pd() => default;

        public readonly struct Vfmsub132ps : IAsmInstruction<Vfmsub132ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132PS;

            public static implicit operator AsmMnemonicCode(Vfmsub132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub132ps src) => AsmMnemonics.VFMSUB132PS;
        }

        public static Vfmsub132ps vfmsub132ps() => default;

        public readonly struct Vfmsub213ps : IAsmInstruction<Vfmsub213ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213PS;

            public static implicit operator AsmMnemonicCode(Vfmsub213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub213ps src) => AsmMnemonics.VFMSUB213PS;
        }

        public static Vfmsub213ps vfmsub213ps() => default;

        public readonly struct Vfmsub231ps : IAsmInstruction<Vfmsub231ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231PS;

            public static implicit operator AsmMnemonicCode(Vfmsub231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub231ps src) => AsmMnemonics.VFMSUB231PS;
        }

        public static Vfmsub231ps vfmsub231ps() => default;

        public readonly struct Vfmsub132sd : IAsmInstruction<Vfmsub132sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132SD;

            public static implicit operator AsmMnemonicCode(Vfmsub132sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub132sd src) => AsmMnemonics.VFMSUB132SD;
        }

        public static Vfmsub132sd vfmsub132sd() => default;

        public readonly struct Vfmsub213sd : IAsmInstruction<Vfmsub213sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213SD;

            public static implicit operator AsmMnemonicCode(Vfmsub213sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub213sd src) => AsmMnemonics.VFMSUB213SD;
        }

        public static Vfmsub213sd vfmsub213sd() => default;

        public readonly struct Vfmsub231sd : IAsmInstruction<Vfmsub231sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231SD;

            public static implicit operator AsmMnemonicCode(Vfmsub231sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub231sd src) => AsmMnemonics.VFMSUB231SD;
        }

        public static Vfmsub231sd vfmsub231sd() => default;

        public readonly struct Vfmsub132ss : IAsmInstruction<Vfmsub132ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132SS;

            public static implicit operator AsmMnemonicCode(Vfmsub132ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub132ss src) => AsmMnemonics.VFMSUB132SS;
        }

        public static Vfmsub132ss vfmsub132ss() => default;

        public readonly struct Vfmsub213ss : IAsmInstruction<Vfmsub213ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213SS;

            public static implicit operator AsmMnemonicCode(Vfmsub213ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub213ss src) => AsmMnemonics.VFMSUB213SS;
        }

        public static Vfmsub213ss vfmsub213ss() => default;

        public readonly struct Vfmsub231ss : IAsmInstruction<Vfmsub231ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231SS;

            public static implicit operator AsmMnemonicCode(Vfmsub231ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfmsub231ss src) => AsmMnemonics.VFMSUB231SS;
        }

        public static Vfmsub231ss vfmsub231ss() => default;

        public readonly struct Vfnmadd132pd : IAsmInstruction<Vfnmadd132pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132PD;

            public static implicit operator AsmMnemonicCode(Vfnmadd132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd132pd src) => AsmMnemonics.VFNMADD132PD;
        }

        public static Vfnmadd132pd vfnmadd132pd() => default;

        public readonly struct Vfnmadd213pd : IAsmInstruction<Vfnmadd213pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213PD;

            public static implicit operator AsmMnemonicCode(Vfnmadd213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd213pd src) => AsmMnemonics.VFNMADD213PD;
        }

        public static Vfnmadd213pd vfnmadd213pd() => default;

        public readonly struct Vfnmadd231pd : IAsmInstruction<Vfnmadd231pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231PD;

            public static implicit operator AsmMnemonicCode(Vfnmadd231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd231pd src) => AsmMnemonics.VFNMADD231PD;
        }

        public static Vfnmadd231pd vfnmadd231pd() => default;

        public readonly struct Vfnmadd132ps : IAsmInstruction<Vfnmadd132ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132PS;

            public static implicit operator AsmMnemonicCode(Vfnmadd132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd132ps src) => AsmMnemonics.VFNMADD132PS;
        }

        public static Vfnmadd132ps vfnmadd132ps() => default;

        public readonly struct Vfnmadd213ps : IAsmInstruction<Vfnmadd213ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213PS;

            public static implicit operator AsmMnemonicCode(Vfnmadd213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd213ps src) => AsmMnemonics.VFNMADD213PS;
        }

        public static Vfnmadd213ps vfnmadd213ps() => default;

        public readonly struct Vfnmadd231ps : IAsmInstruction<Vfnmadd231ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231PS;

            public static implicit operator AsmMnemonicCode(Vfnmadd231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd231ps src) => AsmMnemonics.VFNMADD231PS;
        }

        public static Vfnmadd231ps vfnmadd231ps() => default;

        public readonly struct Vfnmadd132sd : IAsmInstruction<Vfnmadd132sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132SD;

            public static implicit operator AsmMnemonicCode(Vfnmadd132sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd132sd src) => AsmMnemonics.VFNMADD132SD;
        }

        public static Vfnmadd132sd vfnmadd132sd() => default;

        public readonly struct Vfnmadd213sd : IAsmInstruction<Vfnmadd213sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213SD;

            public static implicit operator AsmMnemonicCode(Vfnmadd213sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd213sd src) => AsmMnemonics.VFNMADD213SD;
        }

        public static Vfnmadd213sd vfnmadd213sd() => default;

        public readonly struct Vfnmadd231sd : IAsmInstruction<Vfnmadd231sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231SD;

            public static implicit operator AsmMnemonicCode(Vfnmadd231sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd231sd src) => AsmMnemonics.VFNMADD231SD;
        }

        public static Vfnmadd231sd vfnmadd231sd() => default;

        public readonly struct Vfnmadd132ss : IAsmInstruction<Vfnmadd132ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132SS;

            public static implicit operator AsmMnemonicCode(Vfnmadd132ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd132ss src) => AsmMnemonics.VFNMADD132SS;
        }

        public static Vfnmadd132ss vfnmadd132ss() => default;

        public readonly struct Vfnmadd213ss : IAsmInstruction<Vfnmadd213ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213SS;

            public static implicit operator AsmMnemonicCode(Vfnmadd213ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd213ss src) => AsmMnemonics.VFNMADD213SS;
        }

        public static Vfnmadd213ss vfnmadd213ss() => default;

        public readonly struct Vfnmadd231ss : IAsmInstruction<Vfnmadd231ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231SS;

            public static implicit operator AsmMnemonicCode(Vfnmadd231ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmadd231ss src) => AsmMnemonics.VFNMADD231SS;
        }

        public static Vfnmadd231ss vfnmadd231ss() => default;

        public readonly struct Vfnmsub132pd : IAsmInstruction<Vfnmsub132pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132PD;

            public static implicit operator AsmMnemonicCode(Vfnmsub132pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub132pd src) => AsmMnemonics.VFNMSUB132PD;
        }

        public static Vfnmsub132pd vfnmsub132pd() => default;

        public readonly struct Vfnmsub213pd : IAsmInstruction<Vfnmsub213pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213PD;

            public static implicit operator AsmMnemonicCode(Vfnmsub213pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub213pd src) => AsmMnemonics.VFNMSUB213PD;
        }

        public static Vfnmsub213pd vfnmsub213pd() => default;

        public readonly struct Vfnmsub231pd : IAsmInstruction<Vfnmsub231pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231PD;

            public static implicit operator AsmMnemonicCode(Vfnmsub231pd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub231pd src) => AsmMnemonics.VFNMSUB231PD;
        }

        public static Vfnmsub231pd vfnmsub231pd() => default;

        public readonly struct Vfnmsub132ps : IAsmInstruction<Vfnmsub132ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132PS;

            public static implicit operator AsmMnemonicCode(Vfnmsub132ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub132ps src) => AsmMnemonics.VFNMSUB132PS;
        }

        public static Vfnmsub132ps vfnmsub132ps() => default;

        public readonly struct Vfnmsub213ps : IAsmInstruction<Vfnmsub213ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213PS;

            public static implicit operator AsmMnemonicCode(Vfnmsub213ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub213ps src) => AsmMnemonics.VFNMSUB213PS;
        }

        public static Vfnmsub213ps vfnmsub213ps() => default;

        public readonly struct Vfnmsub231ps : IAsmInstruction<Vfnmsub231ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231PS;

            public static implicit operator AsmMnemonicCode(Vfnmsub231ps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub231ps src) => AsmMnemonics.VFNMSUB231PS;
        }

        public static Vfnmsub231ps vfnmsub231ps() => default;

        public readonly struct Vfnmsub132sd : IAsmInstruction<Vfnmsub132sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132SD;

            public static implicit operator AsmMnemonicCode(Vfnmsub132sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub132sd src) => AsmMnemonics.VFNMSUB132SD;
        }

        public static Vfnmsub132sd vfnmsub132sd() => default;

        public readonly struct Vfnmsub213sd : IAsmInstruction<Vfnmsub213sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213SD;

            public static implicit operator AsmMnemonicCode(Vfnmsub213sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub213sd src) => AsmMnemonics.VFNMSUB213SD;
        }

        public static Vfnmsub213sd vfnmsub213sd() => default;

        public readonly struct Vfnmsub231sd : IAsmInstruction<Vfnmsub231sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231SD;

            public static implicit operator AsmMnemonicCode(Vfnmsub231sd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub231sd src) => AsmMnemonics.VFNMSUB231SD;
        }

        public static Vfnmsub231sd vfnmsub231sd() => default;

        public readonly struct Vfnmsub132ss : IAsmInstruction<Vfnmsub132ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132SS;

            public static implicit operator AsmMnemonicCode(Vfnmsub132ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub132ss src) => AsmMnemonics.VFNMSUB132SS;
        }

        public static Vfnmsub132ss vfnmsub132ss() => default;

        public readonly struct Vfnmsub213ss : IAsmInstruction<Vfnmsub213ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213SS;

            public static implicit operator AsmMnemonicCode(Vfnmsub213ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub213ss src) => AsmMnemonics.VFNMSUB213SS;
        }

        public static Vfnmsub213ss vfnmsub213ss() => default;

        public readonly struct Vfnmsub231ss : IAsmInstruction<Vfnmsub231ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231SS;

            public static implicit operator AsmMnemonicCode(Vfnmsub231ss src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vfnmsub231ss src) => AsmMnemonics.VFNMSUB231SS;
        }

        public static Vfnmsub231ss vfnmsub231ss() => default;

        public readonly struct Vgatherdpd : IAsmInstruction<Vgatherdpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERDPD;

            public static implicit operator AsmMnemonicCode(Vgatherdpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vgatherdpd src) => AsmMnemonics.VGATHERDPD;
        }

        public static Vgatherdpd vgatherdpd() => default;

        public readonly struct Vgatherqpd : IAsmInstruction<Vgatherqpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERQPD;

            public static implicit operator AsmMnemonicCode(Vgatherqpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vgatherqpd src) => AsmMnemonics.VGATHERQPD;
        }

        public static Vgatherqpd vgatherqpd() => default;

        public readonly struct Vgatherdps : IAsmInstruction<Vgatherdps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERDPS;

            public static implicit operator AsmMnemonicCode(Vgatherdps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vgatherdps src) => AsmMnemonics.VGATHERDPS;
        }

        public static Vgatherdps vgatherdps() => default;

        public readonly struct Vgatherqps : IAsmInstruction<Vgatherqps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERQPS;

            public static implicit operator AsmMnemonicCode(Vgatherqps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vgatherqps src) => AsmMnemonics.VGATHERQPS;
        }

        public static Vgatherqps vgatherqps() => default;

        public readonly struct Vpgatherdd : IAsmInstruction<Vpgatherdd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERDD;

            public static implicit operator AsmMnemonicCode(Vpgatherdd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpgatherdd src) => AsmMnemonics.VPGATHERDD;
        }

        public static Vpgatherdd vpgatherdd() => default;

        public readonly struct Vpgatherqd : IAsmInstruction<Vpgatherqd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERQD;

            public static implicit operator AsmMnemonicCode(Vpgatherqd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpgatherqd src) => AsmMnemonics.VPGATHERQD;
        }

        public static Vpgatherqd vpgatherqd() => default;

        public readonly struct Vpgatherdq : IAsmInstruction<Vpgatherdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERDQ;

            public static implicit operator AsmMnemonicCode(Vpgatherdq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpgatherdq src) => AsmMnemonics.VPGATHERDQ;
        }

        public static Vpgatherdq vpgatherdq() => default;

        public readonly struct Vpgatherqq : IAsmInstruction<Vpgatherqq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERQQ;

            public static implicit operator AsmMnemonicCode(Vpgatherqq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpgatherqq src) => AsmMnemonics.VPGATHERQQ;
        }

        public static Vpgatherqq vpgatherqq() => default;

        public readonly struct Vinsertf128 : IAsmInstruction<Vinsertf128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VINSERTF128;

            public static implicit operator AsmMnemonicCode(Vinsertf128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vinsertf128 src) => AsmMnemonics.VINSERTF128;
        }

        public static Vinsertf128 vinsertf128() => default;

        public readonly struct Vinserti128 : IAsmInstruction<Vinserti128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VINSERTI128;

            public static implicit operator AsmMnemonicCode(Vinserti128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vinserti128 src) => AsmMnemonics.VINSERTI128;
        }

        public static Vinserti128 vinserti128() => default;

        public readonly struct Vmaskmovps : IAsmInstruction<Vmaskmovps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMASKMOVPS;

            public static implicit operator AsmMnemonicCode(Vmaskmovps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaskmovps src) => AsmMnemonics.VMASKMOVPS;
        }

        public static Vmaskmovps vmaskmovps() => default;

        public readonly struct Vmaskmovpd : IAsmInstruction<Vmaskmovpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMASKMOVPD;

            public static implicit operator AsmMnemonicCode(Vmaskmovpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vmaskmovpd src) => AsmMnemonics.VMASKMOVPD;
        }

        public static Vmaskmovpd vmaskmovpd() => default;

        public readonly struct Vpblendd : IAsmInstruction<Vpblendd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBLENDD;

            public static implicit operator AsmMnemonicCode(Vpblendd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpblendd src) => AsmMnemonics.VPBLENDD;
        }

        public static Vpblendd vpblendd() => default;

        public readonly struct Vpbroadcastb : IAsmInstruction<Vpbroadcastb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTB;

            public static implicit operator AsmMnemonicCode(Vpbroadcastb src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpbroadcastb src) => AsmMnemonics.VPBROADCASTB;
        }

        public static Vpbroadcastb vpbroadcastb() => default;

        public readonly struct Vpbroadcastw : IAsmInstruction<Vpbroadcastw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTW;

            public static implicit operator AsmMnemonicCode(Vpbroadcastw src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpbroadcastw src) => AsmMnemonics.VPBROADCASTW;
        }

        public static Vpbroadcastw vpbroadcastw() => default;

        public readonly struct Vpbroadcastd : IAsmInstruction<Vpbroadcastd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTD;

            public static implicit operator AsmMnemonicCode(Vpbroadcastd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpbroadcastd src) => AsmMnemonics.VPBROADCASTD;
        }

        public static Vpbroadcastd vpbroadcastd() => default;

        public readonly struct Vpbroadcastq : IAsmInstruction<Vpbroadcastq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTQ;

            public static implicit operator AsmMnemonicCode(Vpbroadcastq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpbroadcastq src) => AsmMnemonics.VPBROADCASTQ;
        }

        public static Vpbroadcastq vpbroadcastq() => default;

        public readonly struct Vbroadcasti128 : IAsmInstruction<Vbroadcasti128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTI128;

            public static implicit operator AsmMnemonicCode(Vbroadcasti128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vbroadcasti128 src) => AsmMnemonics.VBROADCASTI128;
        }

        public static Vbroadcasti128 vbroadcasti128() => default;

        public readonly struct Vpermd : IAsmInstruction<Vpermd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMD;

            public static implicit operator AsmMnemonicCode(Vpermd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermd src) => AsmMnemonics.VPERMD;
        }

        public static Vpermd vpermd() => default;

        public readonly struct Vpermpd : IAsmInstruction<Vpermpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMPD;

            public static implicit operator AsmMnemonicCode(Vpermpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermpd src) => AsmMnemonics.VPERMPD;
        }

        public static Vpermpd vpermpd() => default;

        public readonly struct Vpermps : IAsmInstruction<Vpermps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMPS;

            public static implicit operator AsmMnemonicCode(Vpermps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermps src) => AsmMnemonics.VPERMPS;
        }

        public static Vpermps vpermps() => default;

        public readonly struct Vpermq : IAsmInstruction<Vpermq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMQ;

            public static implicit operator AsmMnemonicCode(Vpermq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermq src) => AsmMnemonics.VPERMQ;
        }

        public static Vpermq vpermq() => default;

        public readonly struct Vperm2i128 : IAsmInstruction<Vperm2i128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERM2I128;

            public static implicit operator AsmMnemonicCode(Vperm2i128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vperm2i128 src) => AsmMnemonics.VPERM2I128;
        }

        public static Vperm2i128 vperm2i128() => default;

        public readonly struct Vpermilpd : IAsmInstruction<Vpermilpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMILPD;

            public static implicit operator AsmMnemonicCode(Vpermilpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermilpd src) => AsmMnemonics.VPERMILPD;
        }

        public static Vpermilpd vpermilpd() => default;

        public readonly struct Vpermilps : IAsmInstruction<Vpermilps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMILPS;

            public static implicit operator AsmMnemonicCode(Vpermilps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpermilps src) => AsmMnemonics.VPERMILPS;
        }

        public static Vpermilps vpermilps() => default;

        public readonly struct Vperm2f128 : IAsmInstruction<Vperm2f128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERM2F128;

            public static implicit operator AsmMnemonicCode(Vperm2f128 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vperm2f128 src) => AsmMnemonics.VPERM2F128;
        }

        public static Vperm2f128 vperm2f128() => default;

        public readonly struct Vpmaskmovd : IAsmInstruction<Vpmaskmovd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMASKMOVD;

            public static implicit operator AsmMnemonicCode(Vpmaskmovd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaskmovd src) => AsmMnemonics.VPMASKMOVD;
        }

        public static Vpmaskmovd vpmaskmovd() => default;

        public readonly struct Vpmaskmovq : IAsmInstruction<Vpmaskmovq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMASKMOVQ;

            public static implicit operator AsmMnemonicCode(Vpmaskmovq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpmaskmovq src) => AsmMnemonics.VPMASKMOVQ;
        }

        public static Vpmaskmovq vpmaskmovq() => default;

        public readonly struct Vpsllvd : IAsmInstruction<Vpsllvd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLVD;

            public static implicit operator AsmMnemonicCode(Vpsllvd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsllvd src) => AsmMnemonics.VPSLLVD;
        }

        public static Vpsllvd vpsllvd() => default;

        public readonly struct Vpsllvq : IAsmInstruction<Vpsllvq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLVQ;

            public static implicit operator AsmMnemonicCode(Vpsllvq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsllvq src) => AsmMnemonics.VPSLLVQ;
        }

        public static Vpsllvq vpsllvq() => default;

        public readonly struct Vpsravd : IAsmInstruction<Vpsravd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRAVD;

            public static implicit operator AsmMnemonicCode(Vpsravd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsravd src) => AsmMnemonics.VPSRAVD;
        }

        public static Vpsravd vpsravd() => default;

        public readonly struct Vpsrlvd : IAsmInstruction<Vpsrlvd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLVD;

            public static implicit operator AsmMnemonicCode(Vpsrlvd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrlvd src) => AsmMnemonics.VPSRLVD;
        }

        public static Vpsrlvd vpsrlvd() => default;

        public readonly struct Vpsrlvq : IAsmInstruction<Vpsrlvq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLVQ;

            public static implicit operator AsmMnemonicCode(Vpsrlvq src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vpsrlvq src) => AsmMnemonics.VPSRLVQ;
        }

        public static Vpsrlvq vpsrlvq() => default;

        public readonly struct Vtestps : IAsmInstruction<Vtestps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VTESTPS;

            public static implicit operator AsmMnemonicCode(Vtestps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vtestps src) => AsmMnemonics.VTESTPS;
        }

        public static Vtestps vtestps() => default;

        public readonly struct Vtestpd : IAsmInstruction<Vtestpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VTESTPD;

            public static implicit operator AsmMnemonicCode(Vtestpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vtestpd src) => AsmMnemonics.VTESTPD;
        }

        public static Vtestpd vtestpd() => default;

        public readonly struct Wrfsbase : IAsmInstruction<Wrfsbase>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WRFSBASE;

            public static implicit operator AsmMnemonicCode(Wrfsbase src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Wrfsbase src) => AsmMnemonics.WRFSBASE;
        }

        public static Wrfsbase wrfsbase() => default;

        public readonly struct Wrgsbase : IAsmInstruction<Wrgsbase>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WRGSBASE;

            public static implicit operator AsmMnemonicCode(Wrgsbase src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Wrgsbase src) => AsmMnemonics.WRGSBASE;
        }

        public static Wrgsbase wrgsbase() => default;

        public readonly struct Xabort : IAsmInstruction<Xabort>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XABORT;

            public static implicit operator AsmMnemonicCode(Xabort src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xabort src) => AsmMnemonics.XABORT;
        }

        public static Xabort xabort() => default;

        public readonly struct Xadd : IAsmInstruction<Xadd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XADD;

            public static implicit operator AsmMnemonicCode(Xadd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xadd src) => AsmMnemonics.XADD;
        }

        public static Xadd xadd() => default;

        public readonly struct Xbegin : IAsmInstruction<Xbegin>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XBEGIN;

            public static implicit operator AsmMnemonicCode(Xbegin src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xbegin src) => AsmMnemonics.XBEGIN;
        }

        public static Xbegin xbegin() => default;

        public readonly struct Xchg : IAsmInstruction<Xchg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XCHG;

            public static implicit operator AsmMnemonicCode(Xchg src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xchg src) => AsmMnemonics.XCHG;
        }

        public static Xchg xchg() => default;

        public readonly struct Xlat : IAsmInstruction<Xlat>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XLAT;

            public static implicit operator AsmMnemonicCode(Xlat src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xlat src) => AsmMnemonics.XLAT;
        }

        public static Xlat xlat() => default;

        public readonly struct Xor : IAsmInstruction<Xor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XOR;

            public static implicit operator AsmMnemonicCode(Xor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xor src) => AsmMnemonics.XOR;
        }

        public static Xor xor() => default;

        public readonly struct Xorpd : IAsmInstruction<Xorpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XORPD;

            public static implicit operator AsmMnemonicCode(Xorpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xorpd src) => AsmMnemonics.XORPD;
        }

        public static Xorpd xorpd() => default;

        public readonly struct Vxorpd : IAsmInstruction<Vxorpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VXORPD;

            public static implicit operator AsmMnemonicCode(Vxorpd src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vxorpd src) => AsmMnemonics.VXORPD;
        }

        public static Vxorpd vxorpd() => default;

        public readonly struct Xorps : IAsmInstruction<Xorps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XORPS;

            public static implicit operator AsmMnemonicCode(Xorps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xorps src) => AsmMnemonics.XORPS;
        }

        public static Xorps xorps() => default;

        public readonly struct Vxorps : IAsmInstruction<Vxorps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VXORPS;

            public static implicit operator AsmMnemonicCode(Vxorps src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Vxorps src) => AsmMnemonics.VXORPS;
        }

        public static Vxorps vxorps() => default;

        public readonly struct Xrstor : IAsmInstruction<Xrstor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XRSTOR;

            public static implicit operator AsmMnemonicCode(Xrstor src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xrstor src) => AsmMnemonics.XRSTOR;
        }

        public static Xrstor xrstor() => default;

        public readonly struct Xrstor64 : IAsmInstruction<Xrstor64>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XRSTOR64;

            public static implicit operator AsmMnemonicCode(Xrstor64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xrstor64 src) => AsmMnemonics.XRSTOR64;
        }

        public static Xrstor64 xrstor64() => default;

        public readonly struct Xsave : IAsmInstruction<Xsave>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVE;

            public static implicit operator AsmMnemonicCode(Xsave src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsave src) => AsmMnemonics.XSAVE;
        }

        public static Xsave xsave() => default;

        public readonly struct Xsave64 : IAsmInstruction<Xsave64>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVE64;

            public static implicit operator AsmMnemonicCode(Xsave64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsave64 src) => AsmMnemonics.XSAVE64;
        }

        public static Xsave64 xsave64() => default;

        public readonly struct Xsaveopt : IAsmInstruction<Xsaveopt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVEOPT;

            public static implicit operator AsmMnemonicCode(Xsaveopt src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsaveopt src) => AsmMnemonics.XSAVEOPT;
        }

        public static Xsaveopt xsaveopt() => default;

        public readonly struct Xsaveopt64 : IAsmInstruction<Xsaveopt64>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVEOPT64;

            public static implicit operator AsmMnemonicCode(Xsaveopt64 src) => src.Mnemonic;

            public static implicit operator AsmMnemonic(Xsaveopt64 src) => AsmMnemonics.XSAVEOPT64;
        }

        public static Xsaveopt64 xsaveopt64() => default;

    }
}
