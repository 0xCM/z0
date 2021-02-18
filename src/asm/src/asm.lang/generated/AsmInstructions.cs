//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly partial struct AsmInstructions
    {
        public readonly struct Aad : IAsmInstruction<Aad>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AAD;

            public static implicit operator AsmMnemonicCode(Aad src) => src.Mnemonic;
        }

        public readonly struct Aam : IAsmInstruction<Aam>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AAM;

            public static implicit operator AsmMnemonicCode(Aam src) => src.Mnemonic;
        }

        public readonly struct Adc : IAsmInstruction<Adc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADC;

            public static implicit operator AsmMnemonicCode(Adc src) => src.Mnemonic;
        }

        public readonly struct Add : IAsmInstruction<Add>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADD;

            public static implicit operator AsmMnemonicCode(Add src) => src.Mnemonic;
        }

        public readonly struct Addpd : IAsmInstruction<Addpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDPD;

            public static implicit operator AsmMnemonicCode(Addpd src) => src.Mnemonic;
        }

        public readonly struct Vaddpd : IAsmInstruction<Vaddpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDPD;

            public static implicit operator AsmMnemonicCode(Vaddpd src) => src.Mnemonic;
        }

        public readonly struct Addps : IAsmInstruction<Addps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDPS;

            public static implicit operator AsmMnemonicCode(Addps src) => src.Mnemonic;
        }

        public readonly struct Vaddps : IAsmInstruction<Vaddps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDPS;

            public static implicit operator AsmMnemonicCode(Vaddps src) => src.Mnemonic;
        }

        public readonly struct Addsd : IAsmInstruction<Addsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSD;

            public static implicit operator AsmMnemonicCode(Addsd src) => src.Mnemonic;
        }

        public readonly struct Vaddsd : IAsmInstruction<Vaddsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSD;

            public static implicit operator AsmMnemonicCode(Vaddsd src) => src.Mnemonic;
        }

        public readonly struct Addss : IAsmInstruction<Addss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSS;

            public static implicit operator AsmMnemonicCode(Addss src) => src.Mnemonic;
        }

        public readonly struct Vaddss : IAsmInstruction<Vaddss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSS;

            public static implicit operator AsmMnemonicCode(Vaddss src) => src.Mnemonic;
        }

        public readonly struct Addsubpd : IAsmInstruction<Addsubpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSUBPD;

            public static implicit operator AsmMnemonicCode(Addsubpd src) => src.Mnemonic;
        }

        public readonly struct Vaddsubpd : IAsmInstruction<Vaddsubpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSUBPD;

            public static implicit operator AsmMnemonicCode(Vaddsubpd src) => src.Mnemonic;
        }

        public readonly struct Addsubps : IAsmInstruction<Addsubps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ADDSUBPS;

            public static implicit operator AsmMnemonicCode(Addsubps src) => src.Mnemonic;
        }

        public readonly struct Vaddsubps : IAsmInstruction<Vaddsubps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VADDSUBPS;

            public static implicit operator AsmMnemonicCode(Vaddsubps src) => src.Mnemonic;
        }

        public readonly struct Aesdec : IAsmInstruction<Aesdec>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESDEC;

            public static implicit operator AsmMnemonicCode(Aesdec src) => src.Mnemonic;
        }

        public readonly struct Vaesdec : IAsmInstruction<Vaesdec>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESDEC;

            public static implicit operator AsmMnemonicCode(Vaesdec src) => src.Mnemonic;
        }

        public readonly struct Aesdeclast : IAsmInstruction<Aesdeclast>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESDECLAST;

            public static implicit operator AsmMnemonicCode(Aesdeclast src) => src.Mnemonic;
        }

        public readonly struct Vaesdeclast : IAsmInstruction<Vaesdeclast>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESDECLAST;

            public static implicit operator AsmMnemonicCode(Vaesdeclast src) => src.Mnemonic;
        }

        public readonly struct Aesenc : IAsmInstruction<Aesenc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESENC;

            public static implicit operator AsmMnemonicCode(Aesenc src) => src.Mnemonic;
        }

        public readonly struct Vaesenc : IAsmInstruction<Vaesenc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESENC;

            public static implicit operator AsmMnemonicCode(Vaesenc src) => src.Mnemonic;
        }

        public readonly struct Aesenclast : IAsmInstruction<Aesenclast>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESENCLAST;

            public static implicit operator AsmMnemonicCode(Aesenclast src) => src.Mnemonic;
        }

        public readonly struct Vaesenclast : IAsmInstruction<Vaesenclast>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESENCLAST;

            public static implicit operator AsmMnemonicCode(Vaesenclast src) => src.Mnemonic;
        }

        public readonly struct Aesimc : IAsmInstruction<Aesimc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESIMC;

            public static implicit operator AsmMnemonicCode(Aesimc src) => src.Mnemonic;
        }

        public readonly struct Vaesimc : IAsmInstruction<Vaesimc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESIMC;

            public static implicit operator AsmMnemonicCode(Vaesimc src) => src.Mnemonic;
        }

        public readonly struct Aeskeygenassist : IAsmInstruction<Aeskeygenassist>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AESKEYGENASSIST;

            public static implicit operator AsmMnemonicCode(Aeskeygenassist src) => src.Mnemonic;
        }

        public readonly struct Vaeskeygenassist : IAsmInstruction<Vaeskeygenassist>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VAESKEYGENASSIST;

            public static implicit operator AsmMnemonicCode(Vaeskeygenassist src) => src.Mnemonic;
        }

        public readonly struct And : IAsmInstruction<And>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.AND;

            public static implicit operator AsmMnemonicCode(And src) => src.Mnemonic;
        }

        public readonly struct Andn : IAsmInstruction<Andn>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDN;

            public static implicit operator AsmMnemonicCode(Andn src) => src.Mnemonic;
        }

        public readonly struct Andpd : IAsmInstruction<Andpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDPD;

            public static implicit operator AsmMnemonicCode(Andpd src) => src.Mnemonic;
        }

        public readonly struct Vandpd : IAsmInstruction<Vandpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDPD;

            public static implicit operator AsmMnemonicCode(Vandpd src) => src.Mnemonic;
        }

        public readonly struct Andps : IAsmInstruction<Andps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDPS;

            public static implicit operator AsmMnemonicCode(Andps src) => src.Mnemonic;
        }

        public readonly struct Vandps : IAsmInstruction<Vandps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDPS;

            public static implicit operator AsmMnemonicCode(Vandps src) => src.Mnemonic;
        }

        public readonly struct Andnpd : IAsmInstruction<Andnpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDNPD;

            public static implicit operator AsmMnemonicCode(Andnpd src) => src.Mnemonic;
        }

        public readonly struct Vandnpd : IAsmInstruction<Vandnpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDNPD;

            public static implicit operator AsmMnemonicCode(Vandnpd src) => src.Mnemonic;
        }

        public readonly struct Andnps : IAsmInstruction<Andnps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ANDNPS;

            public static implicit operator AsmMnemonicCode(Andnps src) => src.Mnemonic;
        }

        public readonly struct Vandnps : IAsmInstruction<Vandnps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VANDNPS;

            public static implicit operator AsmMnemonicCode(Vandnps src) => src.Mnemonic;
        }

        public readonly struct Arpl : IAsmInstruction<Arpl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ARPL;

            public static implicit operator AsmMnemonicCode(Arpl src) => src.Mnemonic;
        }

        public readonly struct Blendpd : IAsmInstruction<Blendpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDPD;

            public static implicit operator AsmMnemonicCode(Blendpd src) => src.Mnemonic;
        }

        public readonly struct Vblendpd : IAsmInstruction<Vblendpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDPD;

            public static implicit operator AsmMnemonicCode(Vblendpd src) => src.Mnemonic;
        }

        public readonly struct Bextr : IAsmInstruction<Bextr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BEXTR;

            public static implicit operator AsmMnemonicCode(Bextr src) => src.Mnemonic;
        }

        public readonly struct Blendps : IAsmInstruction<Blendps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDPS;

            public static implicit operator AsmMnemonicCode(Blendps src) => src.Mnemonic;
        }

        public readonly struct Vblendps : IAsmInstruction<Vblendps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDPS;

            public static implicit operator AsmMnemonicCode(Vblendps src) => src.Mnemonic;
        }

        public readonly struct Blendvpd : IAsmInstruction<Blendvpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDVPD;

            public static implicit operator AsmMnemonicCode(Blendvpd src) => src.Mnemonic;
        }

        public readonly struct Vblendvpd : IAsmInstruction<Vblendvpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDVPD;

            public static implicit operator AsmMnemonicCode(Vblendvpd src) => src.Mnemonic;
        }

        public readonly struct Blendvps : IAsmInstruction<Blendvps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLENDVPS;

            public static implicit operator AsmMnemonicCode(Blendvps src) => src.Mnemonic;
        }

        public readonly struct Vblendvps : IAsmInstruction<Vblendvps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBLENDVPS;

            public static implicit operator AsmMnemonicCode(Vblendvps src) => src.Mnemonic;
        }

        public readonly struct Blsi : IAsmInstruction<Blsi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLSI;

            public static implicit operator AsmMnemonicCode(Blsi src) => src.Mnemonic;
        }

        public readonly struct Blsmsk : IAsmInstruction<Blsmsk>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLSMSK;

            public static implicit operator AsmMnemonicCode(Blsmsk src) => src.Mnemonic;
        }

        public readonly struct Blsr : IAsmInstruction<Blsr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BLSR;

            public static implicit operator AsmMnemonicCode(Blsr src) => src.Mnemonic;
        }

        public readonly struct Bound : IAsmInstruction<Bound>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BOUND;

            public static implicit operator AsmMnemonicCode(Bound src) => src.Mnemonic;
        }

        public readonly struct Bsf : IAsmInstruction<Bsf>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BSF;

            public static implicit operator AsmMnemonicCode(Bsf src) => src.Mnemonic;
        }

        public readonly struct Bsr : IAsmInstruction<Bsr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BSR;

            public static implicit operator AsmMnemonicCode(Bsr src) => src.Mnemonic;
        }

        public readonly struct Bswap : IAsmInstruction<Bswap>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BSWAP;

            public static implicit operator AsmMnemonicCode(Bswap src) => src.Mnemonic;
        }

        public readonly struct Bt : IAsmInstruction<Bt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BT;

            public static implicit operator AsmMnemonicCode(Bt src) => src.Mnemonic;
        }

        public readonly struct Btc : IAsmInstruction<Btc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BTC;

            public static implicit operator AsmMnemonicCode(Btc src) => src.Mnemonic;
        }

        public readonly struct Btr : IAsmInstruction<Btr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BTR;

            public static implicit operator AsmMnemonicCode(Btr src) => src.Mnemonic;
        }

        public readonly struct Bts : IAsmInstruction<Bts>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BTS;

            public static implicit operator AsmMnemonicCode(Bts src) => src.Mnemonic;
        }

        public readonly struct Bzhi : IAsmInstruction<Bzhi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.BZHI;

            public static implicit operator AsmMnemonicCode(Bzhi src) => src.Mnemonic;
        }

        public readonly struct Call : IAsmInstruction<Call>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CALL;

            public static implicit operator AsmMnemonicCode(Call src) => src.Mnemonic;
        }

        public readonly struct Clflush : IAsmInstruction<Clflush>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CLFLUSH;

            public static implicit operator AsmMnemonicCode(Clflush src) => src.Mnemonic;
        }

        public readonly struct Cmova : IAsmInstruction<Cmova>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVA;

            public static implicit operator AsmMnemonicCode(Cmova src) => src.Mnemonic;
        }

        public readonly struct Cmovae : IAsmInstruction<Cmovae>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVAE;

            public static implicit operator AsmMnemonicCode(Cmovae src) => src.Mnemonic;
        }

        public readonly struct Cmovb : IAsmInstruction<Cmovb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVB;

            public static implicit operator AsmMnemonicCode(Cmovb src) => src.Mnemonic;
        }

        public readonly struct Cmovbe : IAsmInstruction<Cmovbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVBE;

            public static implicit operator AsmMnemonicCode(Cmovbe src) => src.Mnemonic;
        }

        public readonly struct Cmovc : IAsmInstruction<Cmovc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVC;

            public static implicit operator AsmMnemonicCode(Cmovc src) => src.Mnemonic;
        }

        public readonly struct Cmove : IAsmInstruction<Cmove>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVE;

            public static implicit operator AsmMnemonicCode(Cmove src) => src.Mnemonic;
        }

        public readonly struct Cmovg : IAsmInstruction<Cmovg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVG;

            public static implicit operator AsmMnemonicCode(Cmovg src) => src.Mnemonic;
        }

        public readonly struct Cmovge : IAsmInstruction<Cmovge>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVGE;

            public static implicit operator AsmMnemonicCode(Cmovge src) => src.Mnemonic;
        }

        public readonly struct Cmovl : IAsmInstruction<Cmovl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVL;

            public static implicit operator AsmMnemonicCode(Cmovl src) => src.Mnemonic;
        }

        public readonly struct Cmovle : IAsmInstruction<Cmovle>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVLE;

            public static implicit operator AsmMnemonicCode(Cmovle src) => src.Mnemonic;
        }

        public readonly struct Cmovna : IAsmInstruction<Cmovna>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNA;

            public static implicit operator AsmMnemonicCode(Cmovna src) => src.Mnemonic;
        }

        public readonly struct Cmovnae : IAsmInstruction<Cmovnae>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNAE;

            public static implicit operator AsmMnemonicCode(Cmovnae src) => src.Mnemonic;
        }

        public readonly struct Cmovnb : IAsmInstruction<Cmovnb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNB;

            public static implicit operator AsmMnemonicCode(Cmovnb src) => src.Mnemonic;
        }

        public readonly struct Cmovnbe : IAsmInstruction<Cmovnbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNBE;

            public static implicit operator AsmMnemonicCode(Cmovnbe src) => src.Mnemonic;
        }

        public readonly struct Cmovnc : IAsmInstruction<Cmovnc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNC;

            public static implicit operator AsmMnemonicCode(Cmovnc src) => src.Mnemonic;
        }

        public readonly struct Cmovne : IAsmInstruction<Cmovne>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNE;

            public static implicit operator AsmMnemonicCode(Cmovne src) => src.Mnemonic;
        }

        public readonly struct Cmovng : IAsmInstruction<Cmovng>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNG;

            public static implicit operator AsmMnemonicCode(Cmovng src) => src.Mnemonic;
        }

        public readonly struct Cmovnge : IAsmInstruction<Cmovnge>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNGE;

            public static implicit operator AsmMnemonicCode(Cmovnge src) => src.Mnemonic;
        }

        public readonly struct Cmovnl : IAsmInstruction<Cmovnl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNL;

            public static implicit operator AsmMnemonicCode(Cmovnl src) => src.Mnemonic;
        }

        public readonly struct Cmovnle : IAsmInstruction<Cmovnle>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNLE;

            public static implicit operator AsmMnemonicCode(Cmovnle src) => src.Mnemonic;
        }

        public readonly struct Cmovno : IAsmInstruction<Cmovno>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNO;

            public static implicit operator AsmMnemonicCode(Cmovno src) => src.Mnemonic;
        }

        public readonly struct Cmovnp : IAsmInstruction<Cmovnp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNP;

            public static implicit operator AsmMnemonicCode(Cmovnp src) => src.Mnemonic;
        }

        public readonly struct Cmovns : IAsmInstruction<Cmovns>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNS;

            public static implicit operator AsmMnemonicCode(Cmovns src) => src.Mnemonic;
        }

        public readonly struct Cmovnz : IAsmInstruction<Cmovnz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVNZ;

            public static implicit operator AsmMnemonicCode(Cmovnz src) => src.Mnemonic;
        }

        public readonly struct Cmovo : IAsmInstruction<Cmovo>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVO;

            public static implicit operator AsmMnemonicCode(Cmovo src) => src.Mnemonic;
        }

        public readonly struct Cmovp : IAsmInstruction<Cmovp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVP;

            public static implicit operator AsmMnemonicCode(Cmovp src) => src.Mnemonic;
        }

        public readonly struct Cmovpe : IAsmInstruction<Cmovpe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVPE;

            public static implicit operator AsmMnemonicCode(Cmovpe src) => src.Mnemonic;
        }

        public readonly struct Cmovpo : IAsmInstruction<Cmovpo>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVPO;

            public static implicit operator AsmMnemonicCode(Cmovpo src) => src.Mnemonic;
        }

        public readonly struct Cmovs : IAsmInstruction<Cmovs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVS;

            public static implicit operator AsmMnemonicCode(Cmovs src) => src.Mnemonic;
        }

        public readonly struct Cmovz : IAsmInstruction<Cmovz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMOVZ;

            public static implicit operator AsmMnemonicCode(Cmovz src) => src.Mnemonic;
        }

        public readonly struct Cmp : IAsmInstruction<Cmp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMP;

            public static implicit operator AsmMnemonicCode(Cmp src) => src.Mnemonic;
        }

        public readonly struct Cmppd : IAsmInstruction<Cmppd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPPD;

            public static implicit operator AsmMnemonicCode(Cmppd src) => src.Mnemonic;
        }

        public readonly struct Vcmppd : IAsmInstruction<Vcmppd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPPD;

            public static implicit operator AsmMnemonicCode(Vcmppd src) => src.Mnemonic;
        }

        public readonly struct Cmpps : IAsmInstruction<Cmpps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPPS;

            public static implicit operator AsmMnemonicCode(Cmpps src) => src.Mnemonic;
        }

        public readonly struct Vcmpps : IAsmInstruction<Vcmpps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPPS;

            public static implicit operator AsmMnemonicCode(Vcmpps src) => src.Mnemonic;
        }

        public readonly struct Cmps : IAsmInstruction<Cmps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPS;

            public static implicit operator AsmMnemonicCode(Cmps src) => src.Mnemonic;
        }

        public readonly struct Cmpsd : IAsmInstruction<Cmpsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSD;

            public static implicit operator AsmMnemonicCode(Cmpsd src) => src.Mnemonic;
        }

        public readonly struct Vcmpsd : IAsmInstruction<Vcmpsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPSD;

            public static implicit operator AsmMnemonicCode(Vcmpsd src) => src.Mnemonic;
        }

        public readonly struct Cmpss : IAsmInstruction<Cmpss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPSS;

            public static implicit operator AsmMnemonicCode(Cmpss src) => src.Mnemonic;
        }

        public readonly struct Vcmpss : IAsmInstruction<Vcmpss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCMPSS;

            public static implicit operator AsmMnemonicCode(Vcmpss src) => src.Mnemonic;
        }

        public readonly struct Cmpxchg : IAsmInstruction<Cmpxchg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPXCHG;

            public static implicit operator AsmMnemonicCode(Cmpxchg src) => src.Mnemonic;
        }

        public readonly struct Cmpxchg8b : IAsmInstruction<Cmpxchg8b>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPXCHG8B;

            public static implicit operator AsmMnemonicCode(Cmpxchg8b src) => src.Mnemonic;
        }

        public readonly struct Cmpxchg16b : IAsmInstruction<Cmpxchg16b>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CMPXCHG16B;

            public static implicit operator AsmMnemonicCode(Cmpxchg16b src) => src.Mnemonic;
        }

        public readonly struct Comisd : IAsmInstruction<Comisd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.COMISD;

            public static implicit operator AsmMnemonicCode(Comisd src) => src.Mnemonic;
        }

        public readonly struct Vcomisd : IAsmInstruction<Vcomisd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCOMISD;

            public static implicit operator AsmMnemonicCode(Vcomisd src) => src.Mnemonic;
        }

        public readonly struct Comiss : IAsmInstruction<Comiss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.COMISS;

            public static implicit operator AsmMnemonicCode(Comiss src) => src.Mnemonic;
        }

        public readonly struct Vcomiss : IAsmInstruction<Vcomiss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCOMISS;

            public static implicit operator AsmMnemonicCode(Vcomiss src) => src.Mnemonic;
        }

        public readonly struct Crc32 : IAsmInstruction<Crc32>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CRC32;

            public static implicit operator AsmMnemonicCode(Crc32 src) => src.Mnemonic;
        }

        public readonly struct Cvtdq2pd : IAsmInstruction<Cvtdq2pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTDQ2PD;

            public static implicit operator AsmMnemonicCode(Cvtdq2pd src) => src.Mnemonic;
        }

        public readonly struct Vcvtdq2pd : IAsmInstruction<Vcvtdq2pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTDQ2PD;

            public static implicit operator AsmMnemonicCode(Vcvtdq2pd src) => src.Mnemonic;
        }

        public readonly struct Cvtdq2ps : IAsmInstruction<Cvtdq2ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTDQ2PS;

            public static implicit operator AsmMnemonicCode(Cvtdq2ps src) => src.Mnemonic;
        }

        public readonly struct Vcvtdq2ps : IAsmInstruction<Vcvtdq2ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTDQ2PS;

            public static implicit operator AsmMnemonicCode(Vcvtdq2ps src) => src.Mnemonic;
        }

        public readonly struct Cvtpd2dq : IAsmInstruction<Cvtpd2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPD2DQ;

            public static implicit operator AsmMnemonicCode(Cvtpd2dq src) => src.Mnemonic;
        }

        public readonly struct Vcvtpd2dq : IAsmInstruction<Vcvtpd2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPD2DQ;

            public static implicit operator AsmMnemonicCode(Vcvtpd2dq src) => src.Mnemonic;
        }

        public readonly struct Cvtpd2pi : IAsmInstruction<Cvtpd2pi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPD2PI;

            public static implicit operator AsmMnemonicCode(Cvtpd2pi src) => src.Mnemonic;
        }

        public readonly struct Cvtpd2ps : IAsmInstruction<Cvtpd2ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPD2PS;

            public static implicit operator AsmMnemonicCode(Cvtpd2ps src) => src.Mnemonic;
        }

        public readonly struct Vcvtpd2ps : IAsmInstruction<Vcvtpd2ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPD2PS;

            public static implicit operator AsmMnemonicCode(Vcvtpd2ps src) => src.Mnemonic;
        }

        public readonly struct Cvtpi2pd : IAsmInstruction<Cvtpi2pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPI2PD;

            public static implicit operator AsmMnemonicCode(Cvtpi2pd src) => src.Mnemonic;
        }

        public readonly struct Cvtpi2ps : IAsmInstruction<Cvtpi2ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPI2PS;

            public static implicit operator AsmMnemonicCode(Cvtpi2ps src) => src.Mnemonic;
        }

        public readonly struct Cvtps2dq : IAsmInstruction<Cvtps2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPS2DQ;

            public static implicit operator AsmMnemonicCode(Cvtps2dq src) => src.Mnemonic;
        }

        public readonly struct Vcvtps2dq : IAsmInstruction<Vcvtps2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPS2DQ;

            public static implicit operator AsmMnemonicCode(Vcvtps2dq src) => src.Mnemonic;
        }

        public readonly struct Cvtps2pd : IAsmInstruction<Cvtps2pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPS2PD;

            public static implicit operator AsmMnemonicCode(Cvtps2pd src) => src.Mnemonic;
        }

        public readonly struct Vcvtps2pd : IAsmInstruction<Vcvtps2pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPS2PD;

            public static implicit operator AsmMnemonicCode(Vcvtps2pd src) => src.Mnemonic;
        }

        public readonly struct Cvtps2pi : IAsmInstruction<Cvtps2pi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTPS2PI;

            public static implicit operator AsmMnemonicCode(Cvtps2pi src) => src.Mnemonic;
        }

        public readonly struct Cvtsd2si : IAsmInstruction<Cvtsd2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSD2SI;

            public static implicit operator AsmMnemonicCode(Cvtsd2si src) => src.Mnemonic;
        }

        public readonly struct Vcvtsd2si : IAsmInstruction<Vcvtsd2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSD2SI;

            public static implicit operator AsmMnemonicCode(Vcvtsd2si src) => src.Mnemonic;
        }

        public readonly struct Cvtsd2ss : IAsmInstruction<Cvtsd2ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSD2SS;

            public static implicit operator AsmMnemonicCode(Cvtsd2ss src) => src.Mnemonic;
        }

        public readonly struct Vcvtsd2ss : IAsmInstruction<Vcvtsd2ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSD2SS;

            public static implicit operator AsmMnemonicCode(Vcvtsd2ss src) => src.Mnemonic;
        }

        public readonly struct Cvtsi2sd : IAsmInstruction<Cvtsi2sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSI2SD;

            public static implicit operator AsmMnemonicCode(Cvtsi2sd src) => src.Mnemonic;
        }

        public readonly struct Vcvtsi2sd : IAsmInstruction<Vcvtsi2sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSI2SD;

            public static implicit operator AsmMnemonicCode(Vcvtsi2sd src) => src.Mnemonic;
        }

        public readonly struct Cvtsi2ss : IAsmInstruction<Cvtsi2ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSI2SS;

            public static implicit operator AsmMnemonicCode(Cvtsi2ss src) => src.Mnemonic;
        }

        public readonly struct Vcvtsi2ss : IAsmInstruction<Vcvtsi2ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSI2SS;

            public static implicit operator AsmMnemonicCode(Vcvtsi2ss src) => src.Mnemonic;
        }

        public readonly struct Cvtss2sd : IAsmInstruction<Cvtss2sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSS2SD;

            public static implicit operator AsmMnemonicCode(Cvtss2sd src) => src.Mnemonic;
        }

        public readonly struct Vcvtss2sd : IAsmInstruction<Vcvtss2sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSS2SD;

            public static implicit operator AsmMnemonicCode(Vcvtss2sd src) => src.Mnemonic;
        }

        public readonly struct Cvtss2si : IAsmInstruction<Cvtss2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTSS2SI;

            public static implicit operator AsmMnemonicCode(Cvtss2si src) => src.Mnemonic;
        }

        public readonly struct Vcvtss2si : IAsmInstruction<Vcvtss2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTSS2SI;

            public static implicit operator AsmMnemonicCode(Vcvtss2si src) => src.Mnemonic;
        }

        public readonly struct Cvttpd2dq : IAsmInstruction<Cvttpd2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPD2DQ;

            public static implicit operator AsmMnemonicCode(Cvttpd2dq src) => src.Mnemonic;
        }

        public readonly struct Vcvttpd2dq : IAsmInstruction<Vcvttpd2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTPD2DQ;

            public static implicit operator AsmMnemonicCode(Vcvttpd2dq src) => src.Mnemonic;
        }

        public readonly struct Cvttpd2pi : IAsmInstruction<Cvttpd2pi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPD2PI;

            public static implicit operator AsmMnemonicCode(Cvttpd2pi src) => src.Mnemonic;
        }

        public readonly struct Cvttps2dq : IAsmInstruction<Cvttps2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPS2DQ;

            public static implicit operator AsmMnemonicCode(Cvttps2dq src) => src.Mnemonic;
        }

        public readonly struct Vcvttps2dq : IAsmInstruction<Vcvttps2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTPS2DQ;

            public static implicit operator AsmMnemonicCode(Vcvttps2dq src) => src.Mnemonic;
        }

        public readonly struct Cvttps2pi : IAsmInstruction<Cvttps2pi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTPS2PI;

            public static implicit operator AsmMnemonicCode(Cvttps2pi src) => src.Mnemonic;
        }

        public readonly struct Cvttsd2si : IAsmInstruction<Cvttsd2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTSD2SI;

            public static implicit operator AsmMnemonicCode(Cvttsd2si src) => src.Mnemonic;
        }

        public readonly struct Vcvttsd2si : IAsmInstruction<Vcvttsd2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTSD2SI;

            public static implicit operator AsmMnemonicCode(Vcvttsd2si src) => src.Mnemonic;
        }

        public readonly struct Cvttss2si : IAsmInstruction<Cvttss2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.CVTTSS2SI;

            public static implicit operator AsmMnemonicCode(Cvttss2si src) => src.Mnemonic;
        }

        public readonly struct Vcvttss2si : IAsmInstruction<Vcvttss2si>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTTSS2SI;

            public static implicit operator AsmMnemonicCode(Vcvttss2si src) => src.Mnemonic;
        }

        public readonly struct Dec : IAsmInstruction<Dec>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DEC;

            public static implicit operator AsmMnemonicCode(Dec src) => src.Mnemonic;
        }

        public readonly struct Div : IAsmInstruction<Div>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIV;

            public static implicit operator AsmMnemonicCode(Div src) => src.Mnemonic;
        }

        public readonly struct Divpd : IAsmInstruction<Divpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVPD;

            public static implicit operator AsmMnemonicCode(Divpd src) => src.Mnemonic;
        }

        public readonly struct Vdivpd : IAsmInstruction<Vdivpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVPD;

            public static implicit operator AsmMnemonicCode(Vdivpd src) => src.Mnemonic;
        }

        public readonly struct Divps : IAsmInstruction<Divps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVPS;

            public static implicit operator AsmMnemonicCode(Divps src) => src.Mnemonic;
        }

        public readonly struct Vdivps : IAsmInstruction<Vdivps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVPS;

            public static implicit operator AsmMnemonicCode(Vdivps src) => src.Mnemonic;
        }

        public readonly struct Divsd : IAsmInstruction<Divsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVSD;

            public static implicit operator AsmMnemonicCode(Divsd src) => src.Mnemonic;
        }

        public readonly struct Vdivsd : IAsmInstruction<Vdivsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVSD;

            public static implicit operator AsmMnemonicCode(Vdivsd src) => src.Mnemonic;
        }

        public readonly struct Divss : IAsmInstruction<Divss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DIVSS;

            public static implicit operator AsmMnemonicCode(Divss src) => src.Mnemonic;
        }

        public readonly struct Vdivss : IAsmInstruction<Vdivss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDIVSS;

            public static implicit operator AsmMnemonicCode(Vdivss src) => src.Mnemonic;
        }

        public readonly struct Dppd : IAsmInstruction<Dppd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DPPD;

            public static implicit operator AsmMnemonicCode(Dppd src) => src.Mnemonic;
        }

        public readonly struct Vdppd : IAsmInstruction<Vdppd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDPPD;

            public static implicit operator AsmMnemonicCode(Vdppd src) => src.Mnemonic;
        }

        public readonly struct Dpps : IAsmInstruction<Dpps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.DPPS;

            public static implicit operator AsmMnemonicCode(Dpps src) => src.Mnemonic;
        }

        public readonly struct Vdpps : IAsmInstruction<Vdpps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VDPPS;

            public static implicit operator AsmMnemonicCode(Vdpps src) => src.Mnemonic;
        }

        public readonly struct Enter : IAsmInstruction<Enter>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ENTER;

            public static implicit operator AsmMnemonicCode(Enter src) => src.Mnemonic;
        }

        public readonly struct Extractps : IAsmInstruction<Extractps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.EXTRACTPS;

            public static implicit operator AsmMnemonicCode(Extractps src) => src.Mnemonic;
        }

        public readonly struct Vextractps : IAsmInstruction<Vextractps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VEXTRACTPS;

            public static implicit operator AsmMnemonicCode(Vextractps src) => src.Mnemonic;
        }

        public readonly struct Fadd : IAsmInstruction<Fadd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FADD;

            public static implicit operator AsmMnemonicCode(Fadd src) => src.Mnemonic;
        }

        public readonly struct Faddp : IAsmInstruction<Faddp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FADDP;

            public static implicit operator AsmMnemonicCode(Faddp src) => src.Mnemonic;
        }

        public readonly struct Fiadd : IAsmInstruction<Fiadd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIADD;

            public static implicit operator AsmMnemonicCode(Fiadd src) => src.Mnemonic;
        }

        public readonly struct Fbld : IAsmInstruction<Fbld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FBLD;

            public static implicit operator AsmMnemonicCode(Fbld src) => src.Mnemonic;
        }

        public readonly struct Fbstp : IAsmInstruction<Fbstp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FBSTP;

            public static implicit operator AsmMnemonicCode(Fbstp src) => src.Mnemonic;
        }

        public readonly struct Fcmovb : IAsmInstruction<Fcmovb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVB;

            public static implicit operator AsmMnemonicCode(Fcmovb src) => src.Mnemonic;
        }

        public readonly struct Fcmove : IAsmInstruction<Fcmove>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVE;

            public static implicit operator AsmMnemonicCode(Fcmove src) => src.Mnemonic;
        }

        public readonly struct Fcmovbe : IAsmInstruction<Fcmovbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVBE;

            public static implicit operator AsmMnemonicCode(Fcmovbe src) => src.Mnemonic;
        }

        public readonly struct Fcmovu : IAsmInstruction<Fcmovu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVU;

            public static implicit operator AsmMnemonicCode(Fcmovu src) => src.Mnemonic;
        }

        public readonly struct Fcmovnb : IAsmInstruction<Fcmovnb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNB;

            public static implicit operator AsmMnemonicCode(Fcmovnb src) => src.Mnemonic;
        }

        public readonly struct Fcmovne : IAsmInstruction<Fcmovne>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNE;

            public static implicit operator AsmMnemonicCode(Fcmovne src) => src.Mnemonic;
        }

        public readonly struct Fcmovnbe : IAsmInstruction<Fcmovnbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNBE;

            public static implicit operator AsmMnemonicCode(Fcmovnbe src) => src.Mnemonic;
        }

        public readonly struct Fcmovnu : IAsmInstruction<Fcmovnu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCMOVNU;

            public static implicit operator AsmMnemonicCode(Fcmovnu src) => src.Mnemonic;
        }

        public readonly struct Fcom : IAsmInstruction<Fcom>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOM;

            public static implicit operator AsmMnemonicCode(Fcom src) => src.Mnemonic;
        }

        public readonly struct Fcomp : IAsmInstruction<Fcomp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMP;

            public static implicit operator AsmMnemonicCode(Fcomp src) => src.Mnemonic;
        }

        public readonly struct Fcomi : IAsmInstruction<Fcomi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMI;

            public static implicit operator AsmMnemonicCode(Fcomi src) => src.Mnemonic;
        }

        public readonly struct Fcomip : IAsmInstruction<Fcomip>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FCOMIP;

            public static implicit operator AsmMnemonicCode(Fcomip src) => src.Mnemonic;
        }

        public readonly struct Fucomi : IAsmInstruction<Fucomi>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMI;

            public static implicit operator AsmMnemonicCode(Fucomi src) => src.Mnemonic;
        }

        public readonly struct Fucomip : IAsmInstruction<Fucomip>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMIP;

            public static implicit operator AsmMnemonicCode(Fucomip src) => src.Mnemonic;
        }

        public readonly struct Fdiv : IAsmInstruction<Fdiv>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIV;

            public static implicit operator AsmMnemonicCode(Fdiv src) => src.Mnemonic;
        }

        public readonly struct Fdivp : IAsmInstruction<Fdivp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIVP;

            public static implicit operator AsmMnemonicCode(Fdivp src) => src.Mnemonic;
        }

        public readonly struct Fidiv : IAsmInstruction<Fidiv>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIDIV;

            public static implicit operator AsmMnemonicCode(Fidiv src) => src.Mnemonic;
        }

        public readonly struct Fdivr : IAsmInstruction<Fdivr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIVR;

            public static implicit operator AsmMnemonicCode(Fdivr src) => src.Mnemonic;
        }

        public readonly struct Fdivrp : IAsmInstruction<Fdivrp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FDIVRP;

            public static implicit operator AsmMnemonicCode(Fdivrp src) => src.Mnemonic;
        }

        public readonly struct Fidivr : IAsmInstruction<Fidivr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIDIVR;

            public static implicit operator AsmMnemonicCode(Fidivr src) => src.Mnemonic;
        }

        public readonly struct Ffree : IAsmInstruction<Ffree>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FFREE;

            public static implicit operator AsmMnemonicCode(Ffree src) => src.Mnemonic;
        }

        public readonly struct Ficom : IAsmInstruction<Ficom>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FICOM;

            public static implicit operator AsmMnemonicCode(Ficom src) => src.Mnemonic;
        }

        public readonly struct Ficomp : IAsmInstruction<Ficomp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FICOMP;

            public static implicit operator AsmMnemonicCode(Ficomp src) => src.Mnemonic;
        }

        public readonly struct Fild : IAsmInstruction<Fild>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FILD;

            public static implicit operator AsmMnemonicCode(Fild src) => src.Mnemonic;
        }

        public readonly struct Fist : IAsmInstruction<Fist>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIST;

            public static implicit operator AsmMnemonicCode(Fist src) => src.Mnemonic;
        }

        public readonly struct Fistp : IAsmInstruction<Fistp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISTP;

            public static implicit operator AsmMnemonicCode(Fistp src) => src.Mnemonic;
        }

        public readonly struct Fisttp : IAsmInstruction<Fisttp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISTTP;

            public static implicit operator AsmMnemonicCode(Fisttp src) => src.Mnemonic;
        }

        public readonly struct Fld : IAsmInstruction<Fld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLD;

            public static implicit operator AsmMnemonicCode(Fld src) => src.Mnemonic;
        }

        public readonly struct Fldcw : IAsmInstruction<Fldcw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDCW;

            public static implicit operator AsmMnemonicCode(Fldcw src) => src.Mnemonic;
        }

        public readonly struct Fldenv : IAsmInstruction<Fldenv>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FLDENV;

            public static implicit operator AsmMnemonicCode(Fldenv src) => src.Mnemonic;
        }

        public readonly struct Fmul : IAsmInstruction<Fmul>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FMUL;

            public static implicit operator AsmMnemonicCode(Fmul src) => src.Mnemonic;
        }

        public readonly struct Fmulp : IAsmInstruction<Fmulp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FMULP;

            public static implicit operator AsmMnemonicCode(Fmulp src) => src.Mnemonic;
        }

        public readonly struct Fimul : IAsmInstruction<Fimul>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FIMUL;

            public static implicit operator AsmMnemonicCode(Fimul src) => src.Mnemonic;
        }

        public readonly struct Frstor : IAsmInstruction<Frstor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FRSTOR;

            public static implicit operator AsmMnemonicCode(Frstor src) => src.Mnemonic;
        }

        public readonly struct Fsave : IAsmInstruction<Fsave>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSAVE;

            public static implicit operator AsmMnemonicCode(Fsave src) => src.Mnemonic;
        }

        public readonly struct Fnsave : IAsmInstruction<Fnsave>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSAVE;

            public static implicit operator AsmMnemonicCode(Fnsave src) => src.Mnemonic;
        }

        public readonly struct Fst : IAsmInstruction<Fst>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FST;

            public static implicit operator AsmMnemonicCode(Fst src) => src.Mnemonic;
        }

        public readonly struct Fstp : IAsmInstruction<Fstp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTP;

            public static implicit operator AsmMnemonicCode(Fstp src) => src.Mnemonic;
        }

        public readonly struct Fstcw : IAsmInstruction<Fstcw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTCW;

            public static implicit operator AsmMnemonicCode(Fstcw src) => src.Mnemonic;
        }

        public readonly struct Fnstcw : IAsmInstruction<Fnstcw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSTCW;

            public static implicit operator AsmMnemonicCode(Fnstcw src) => src.Mnemonic;
        }

        public readonly struct Fstenv : IAsmInstruction<Fstenv>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTENV;

            public static implicit operator AsmMnemonicCode(Fstenv src) => src.Mnemonic;
        }

        public readonly struct Fnstenv : IAsmInstruction<Fnstenv>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSTENV;

            public static implicit operator AsmMnemonicCode(Fnstenv src) => src.Mnemonic;
        }

        public readonly struct Fstsw : IAsmInstruction<Fstsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSTSW;

            public static implicit operator AsmMnemonicCode(Fstsw src) => src.Mnemonic;
        }

        public readonly struct Fnstsw : IAsmInstruction<Fnstsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FNSTSW;

            public static implicit operator AsmMnemonicCode(Fnstsw src) => src.Mnemonic;
        }

        public readonly struct Fsub : IAsmInstruction<Fsub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUB;

            public static implicit operator AsmMnemonicCode(Fsub src) => src.Mnemonic;
        }

        public readonly struct Fsubp : IAsmInstruction<Fsubp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUBP;

            public static implicit operator AsmMnemonicCode(Fsubp src) => src.Mnemonic;
        }

        public readonly struct Fisub : IAsmInstruction<Fisub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISUB;

            public static implicit operator AsmMnemonicCode(Fisub src) => src.Mnemonic;
        }

        public readonly struct Fsubr : IAsmInstruction<Fsubr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUBR;

            public static implicit operator AsmMnemonicCode(Fsubr src) => src.Mnemonic;
        }

        public readonly struct Fsubrp : IAsmInstruction<Fsubrp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FSUBRP;

            public static implicit operator AsmMnemonicCode(Fsubrp src) => src.Mnemonic;
        }

        public readonly struct Fisubr : IAsmInstruction<Fisubr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FISUBR;

            public static implicit operator AsmMnemonicCode(Fisubr src) => src.Mnemonic;
        }

        public readonly struct Fucom : IAsmInstruction<Fucom>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOM;

            public static implicit operator AsmMnemonicCode(Fucom src) => src.Mnemonic;
        }

        public readonly struct Fucomp : IAsmInstruction<Fucomp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FUCOMP;

            public static implicit operator AsmMnemonicCode(Fucomp src) => src.Mnemonic;
        }

        public readonly struct Fxch : IAsmInstruction<Fxch>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXCH;

            public static implicit operator AsmMnemonicCode(Fxch src) => src.Mnemonic;
        }

        public readonly struct Fxrstor : IAsmInstruction<Fxrstor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXRSTOR;

            public static implicit operator AsmMnemonicCode(Fxrstor src) => src.Mnemonic;
        }

        public readonly struct Fxrstor64 : IAsmInstruction<Fxrstor64>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXRSTOR64;

            public static implicit operator AsmMnemonicCode(Fxrstor64 src) => src.Mnemonic;
        }

        public readonly struct Fxsave : IAsmInstruction<Fxsave>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXSAVE;

            public static implicit operator AsmMnemonicCode(Fxsave src) => src.Mnemonic;
        }

        public readonly struct Fxsave64 : IAsmInstruction<Fxsave64>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.FXSAVE64;

            public static implicit operator AsmMnemonicCode(Fxsave64 src) => src.Mnemonic;
        }

        public readonly struct Haddpd : IAsmInstruction<Haddpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HADDPD;

            public static implicit operator AsmMnemonicCode(Haddpd src) => src.Mnemonic;
        }

        public readonly struct Vhaddpd : IAsmInstruction<Vhaddpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHADDPD;

            public static implicit operator AsmMnemonicCode(Vhaddpd src) => src.Mnemonic;
        }

        public readonly struct Haddps : IAsmInstruction<Haddps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HADDPS;

            public static implicit operator AsmMnemonicCode(Haddps src) => src.Mnemonic;
        }

        public readonly struct Vhaddps : IAsmInstruction<Vhaddps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHADDPS;

            public static implicit operator AsmMnemonicCode(Vhaddps src) => src.Mnemonic;
        }

        public readonly struct Hsubpd : IAsmInstruction<Hsubpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HSUBPD;

            public static implicit operator AsmMnemonicCode(Hsubpd src) => src.Mnemonic;
        }

        public readonly struct Vhsubpd : IAsmInstruction<Vhsubpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHSUBPD;

            public static implicit operator AsmMnemonicCode(Vhsubpd src) => src.Mnemonic;
        }

        public readonly struct Hsubps : IAsmInstruction<Hsubps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.HSUBPS;

            public static implicit operator AsmMnemonicCode(Hsubps src) => src.Mnemonic;
        }

        public readonly struct Vhsubps : IAsmInstruction<Vhsubps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VHSUBPS;

            public static implicit operator AsmMnemonicCode(Vhsubps src) => src.Mnemonic;
        }

        public readonly struct Idiv : IAsmInstruction<Idiv>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IDIV;

            public static implicit operator AsmMnemonicCode(Idiv src) => src.Mnemonic;
        }

        public readonly struct Imul : IAsmInstruction<Imul>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IMUL;

            public static implicit operator AsmMnemonicCode(Imul src) => src.Mnemonic;
        }

        public readonly struct In : IAsmInstruction<In>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.IN;

            public static implicit operator AsmMnemonicCode(In src) => src.Mnemonic;
        }

        public readonly struct Inc : IAsmInstruction<Inc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INC;

            public static implicit operator AsmMnemonicCode(Inc src) => src.Mnemonic;
        }

        public readonly struct Ins : IAsmInstruction<Ins>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INS;

            public static implicit operator AsmMnemonicCode(Ins src) => src.Mnemonic;
        }

        public readonly struct Insertps : IAsmInstruction<Insertps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INSERTPS;

            public static implicit operator AsmMnemonicCode(Insertps src) => src.Mnemonic;
        }

        public readonly struct Vinsertps : IAsmInstruction<Vinsertps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VINSERTPS;

            public static implicit operator AsmMnemonicCode(Vinsertps src) => src.Mnemonic;
        }

        public readonly struct Int : IAsmInstruction<Int>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INT;

            public static implicit operator AsmMnemonicCode(Int src) => src.Mnemonic;
        }

        public readonly struct Invlpg : IAsmInstruction<Invlpg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INVLPG;

            public static implicit operator AsmMnemonicCode(Invlpg src) => src.Mnemonic;
        }

        public readonly struct Invpcid : IAsmInstruction<Invpcid>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.INVPCID;

            public static implicit operator AsmMnemonicCode(Invpcid src) => src.Mnemonic;
        }

        public readonly struct Ja : IAsmInstruction<Ja>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JA;

            public static implicit operator AsmMnemonicCode(Ja src) => src.Mnemonic;
        }

        public readonly struct Jae : IAsmInstruction<Jae>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JAE;

            public static implicit operator AsmMnemonicCode(Jae src) => src.Mnemonic;
        }

        public readonly struct Jb : IAsmInstruction<Jb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JB;

            public static implicit operator AsmMnemonicCode(Jb src) => src.Mnemonic;
        }

        public readonly struct Jbe : IAsmInstruction<Jbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JBE;

            public static implicit operator AsmMnemonicCode(Jbe src) => src.Mnemonic;
        }

        public readonly struct Jc : IAsmInstruction<Jc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JC;

            public static implicit operator AsmMnemonicCode(Jc src) => src.Mnemonic;
        }

        public readonly struct Jcxz : IAsmInstruction<Jcxz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JCXZ;

            public static implicit operator AsmMnemonicCode(Jcxz src) => src.Mnemonic;
        }

        public readonly struct Jecxz : IAsmInstruction<Jecxz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JECXZ;

            public static implicit operator AsmMnemonicCode(Jecxz src) => src.Mnemonic;
        }

        public readonly struct Jrcxz : IAsmInstruction<Jrcxz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JRCXZ;

            public static implicit operator AsmMnemonicCode(Jrcxz src) => src.Mnemonic;
        }

        public readonly struct Je : IAsmInstruction<Je>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JE;

            public static implicit operator AsmMnemonicCode(Je src) => src.Mnemonic;
        }

        public readonly struct Jg : IAsmInstruction<Jg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JG;

            public static implicit operator AsmMnemonicCode(Jg src) => src.Mnemonic;
        }

        public readonly struct Jge : IAsmInstruction<Jge>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JGE;

            public static implicit operator AsmMnemonicCode(Jge src) => src.Mnemonic;
        }

        public readonly struct Jl : IAsmInstruction<Jl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JL;

            public static implicit operator AsmMnemonicCode(Jl src) => src.Mnemonic;
        }

        public readonly struct Jle : IAsmInstruction<Jle>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JLE;

            public static implicit operator AsmMnemonicCode(Jle src) => src.Mnemonic;
        }

        public readonly struct Jna : IAsmInstruction<Jna>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNA;

            public static implicit operator AsmMnemonicCode(Jna src) => src.Mnemonic;
        }

        public readonly struct Jnae : IAsmInstruction<Jnae>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNAE;

            public static implicit operator AsmMnemonicCode(Jnae src) => src.Mnemonic;
        }

        public readonly struct Jnb : IAsmInstruction<Jnb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNB;

            public static implicit operator AsmMnemonicCode(Jnb src) => src.Mnemonic;
        }

        public readonly struct Jnbe : IAsmInstruction<Jnbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNBE;

            public static implicit operator AsmMnemonicCode(Jnbe src) => src.Mnemonic;
        }

        public readonly struct Jnc : IAsmInstruction<Jnc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNC;

            public static implicit operator AsmMnemonicCode(Jnc src) => src.Mnemonic;
        }

        public readonly struct Jne : IAsmInstruction<Jne>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNE;

            public static implicit operator AsmMnemonicCode(Jne src) => src.Mnemonic;
        }

        public readonly struct Jng : IAsmInstruction<Jng>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNG;

            public static implicit operator AsmMnemonicCode(Jng src) => src.Mnemonic;
        }

        public readonly struct Jnge : IAsmInstruction<Jnge>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNGE;

            public static implicit operator AsmMnemonicCode(Jnge src) => src.Mnemonic;
        }

        public readonly struct Jnl : IAsmInstruction<Jnl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNL;

            public static implicit operator AsmMnemonicCode(Jnl src) => src.Mnemonic;
        }

        public readonly struct Jnle : IAsmInstruction<Jnle>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNLE;

            public static implicit operator AsmMnemonicCode(Jnle src) => src.Mnemonic;
        }

        public readonly struct Jno : IAsmInstruction<Jno>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNO;

            public static implicit operator AsmMnemonicCode(Jno src) => src.Mnemonic;
        }

        public readonly struct Jnp : IAsmInstruction<Jnp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNP;

            public static implicit operator AsmMnemonicCode(Jnp src) => src.Mnemonic;
        }

        public readonly struct Jns : IAsmInstruction<Jns>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNS;

            public static implicit operator AsmMnemonicCode(Jns src) => src.Mnemonic;
        }

        public readonly struct Jnz : IAsmInstruction<Jnz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JNZ;

            public static implicit operator AsmMnemonicCode(Jnz src) => src.Mnemonic;
        }

        public readonly struct Jo : IAsmInstruction<Jo>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JO;

            public static implicit operator AsmMnemonicCode(Jo src) => src.Mnemonic;
        }

        public readonly struct Jp : IAsmInstruction<Jp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JP;

            public static implicit operator AsmMnemonicCode(Jp src) => src.Mnemonic;
        }

        public readonly struct Jpe : IAsmInstruction<Jpe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JPE;

            public static implicit operator AsmMnemonicCode(Jpe src) => src.Mnemonic;
        }

        public readonly struct Jpo : IAsmInstruction<Jpo>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JPO;

            public static implicit operator AsmMnemonicCode(Jpo src) => src.Mnemonic;
        }

        public readonly struct Js : IAsmInstruction<Js>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JS;

            public static implicit operator AsmMnemonicCode(Js src) => src.Mnemonic;
        }

        public readonly struct Jz : IAsmInstruction<Jz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JZ;

            public static implicit operator AsmMnemonicCode(Jz src) => src.Mnemonic;
        }

        public readonly struct Jmp : IAsmInstruction<Jmp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.JMP;

            public static implicit operator AsmMnemonicCode(Jmp src) => src.Mnemonic;
        }

        public readonly struct Lar : IAsmInstruction<Lar>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LAR;

            public static implicit operator AsmMnemonicCode(Lar src) => src.Mnemonic;
        }

        public readonly struct Lddqu : IAsmInstruction<Lddqu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LDDQU;

            public static implicit operator AsmMnemonicCode(Lddqu src) => src.Mnemonic;
        }

        public readonly struct Vlddqu : IAsmInstruction<Vlddqu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VLDDQU;

            public static implicit operator AsmMnemonicCode(Vlddqu src) => src.Mnemonic;
        }

        public readonly struct Ldmxcsr : IAsmInstruction<Ldmxcsr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LDMXCSR;

            public static implicit operator AsmMnemonicCode(Ldmxcsr src) => src.Mnemonic;
        }

        public readonly struct Vldmxcsr : IAsmInstruction<Vldmxcsr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VLDMXCSR;

            public static implicit operator AsmMnemonicCode(Vldmxcsr src) => src.Mnemonic;
        }

        public readonly struct Lds : IAsmInstruction<Lds>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LDS;

            public static implicit operator AsmMnemonicCode(Lds src) => src.Mnemonic;
        }

        public readonly struct Lss : IAsmInstruction<Lss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LSS;

            public static implicit operator AsmMnemonicCode(Lss src) => src.Mnemonic;
        }

        public readonly struct Les : IAsmInstruction<Les>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LES;

            public static implicit operator AsmMnemonicCode(Les src) => src.Mnemonic;
        }

        public readonly struct Lfs : IAsmInstruction<Lfs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LFS;

            public static implicit operator AsmMnemonicCode(Lfs src) => src.Mnemonic;
        }

        public readonly struct Lgs : IAsmInstruction<Lgs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LGS;

            public static implicit operator AsmMnemonicCode(Lgs src) => src.Mnemonic;
        }

        public readonly struct Lea : IAsmInstruction<Lea>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LEA;

            public static implicit operator AsmMnemonicCode(Lea src) => src.Mnemonic;
        }

        public readonly struct Leave : IAsmInstruction<Leave>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LEAVE;

            public static implicit operator AsmMnemonicCode(Leave src) => src.Mnemonic;
        }

        public readonly struct Lgdt : IAsmInstruction<Lgdt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LGDT;

            public static implicit operator AsmMnemonicCode(Lgdt src) => src.Mnemonic;
        }

        public readonly struct Lidt : IAsmInstruction<Lidt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LIDT;

            public static implicit operator AsmMnemonicCode(Lidt src) => src.Mnemonic;
        }

        public readonly struct Lldt : IAsmInstruction<Lldt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LLDT;

            public static implicit operator AsmMnemonicCode(Lldt src) => src.Mnemonic;
        }

        public readonly struct Lmsw : IAsmInstruction<Lmsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LMSW;

            public static implicit operator AsmMnemonicCode(Lmsw src) => src.Mnemonic;
        }

        public readonly struct Lods : IAsmInstruction<Lods>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LODS;

            public static implicit operator AsmMnemonicCode(Lods src) => src.Mnemonic;
        }

        public readonly struct Loop : IAsmInstruction<Loop>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOOP;

            public static implicit operator AsmMnemonicCode(Loop src) => src.Mnemonic;
        }

        public readonly struct Loope : IAsmInstruction<Loope>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOOPE;

            public static implicit operator AsmMnemonicCode(Loope src) => src.Mnemonic;
        }

        public readonly struct Loopne : IAsmInstruction<Loopne>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LOOPNE;

            public static implicit operator AsmMnemonicCode(Loopne src) => src.Mnemonic;
        }

        public readonly struct Lsl : IAsmInstruction<Lsl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LSL;

            public static implicit operator AsmMnemonicCode(Lsl src) => src.Mnemonic;
        }

        public readonly struct Ltr : IAsmInstruction<Ltr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LTR;

            public static implicit operator AsmMnemonicCode(Ltr src) => src.Mnemonic;
        }

        public readonly struct Lzcnt : IAsmInstruction<Lzcnt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.LZCNT;

            public static implicit operator AsmMnemonicCode(Lzcnt src) => src.Mnemonic;
        }

        public readonly struct Maskmovdqu : IAsmInstruction<Maskmovdqu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MASKMOVDQU;

            public static implicit operator AsmMnemonicCode(Maskmovdqu src) => src.Mnemonic;
        }

        public readonly struct Vmaskmovdqu : IAsmInstruction<Vmaskmovdqu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMASKMOVDQU;

            public static implicit operator AsmMnemonicCode(Vmaskmovdqu src) => src.Mnemonic;
        }

        public readonly struct Maskmovq : IAsmInstruction<Maskmovq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MASKMOVQ;

            public static implicit operator AsmMnemonicCode(Maskmovq src) => src.Mnemonic;
        }

        public readonly struct Maxpd : IAsmInstruction<Maxpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXPD;

            public static implicit operator AsmMnemonicCode(Maxpd src) => src.Mnemonic;
        }

        public readonly struct Vmaxpd : IAsmInstruction<Vmaxpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXPD;

            public static implicit operator AsmMnemonicCode(Vmaxpd src) => src.Mnemonic;
        }

        public readonly struct Maxps : IAsmInstruction<Maxps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXPS;

            public static implicit operator AsmMnemonicCode(Maxps src) => src.Mnemonic;
        }

        public readonly struct Vmaxps : IAsmInstruction<Vmaxps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXPS;

            public static implicit operator AsmMnemonicCode(Vmaxps src) => src.Mnemonic;
        }

        public readonly struct Maxsd : IAsmInstruction<Maxsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXSD;

            public static implicit operator AsmMnemonicCode(Maxsd src) => src.Mnemonic;
        }

        public readonly struct Vmaxsd : IAsmInstruction<Vmaxsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXSD;

            public static implicit operator AsmMnemonicCode(Vmaxsd src) => src.Mnemonic;
        }

        public readonly struct Maxss : IAsmInstruction<Maxss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MAXSS;

            public static implicit operator AsmMnemonicCode(Maxss src) => src.Mnemonic;
        }

        public readonly struct Vmaxss : IAsmInstruction<Vmaxss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMAXSS;

            public static implicit operator AsmMnemonicCode(Vmaxss src) => src.Mnemonic;
        }

        public readonly struct Minpd : IAsmInstruction<Minpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINPD;

            public static implicit operator AsmMnemonicCode(Minpd src) => src.Mnemonic;
        }

        public readonly struct Vminpd : IAsmInstruction<Vminpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINPD;

            public static implicit operator AsmMnemonicCode(Vminpd src) => src.Mnemonic;
        }

        public readonly struct Minps : IAsmInstruction<Minps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINPS;

            public static implicit operator AsmMnemonicCode(Minps src) => src.Mnemonic;
        }

        public readonly struct Vminps : IAsmInstruction<Vminps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINPS;

            public static implicit operator AsmMnemonicCode(Vminps src) => src.Mnemonic;
        }

        public readonly struct Minsd : IAsmInstruction<Minsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINSD;

            public static implicit operator AsmMnemonicCode(Minsd src) => src.Mnemonic;
        }

        public readonly struct Vminsd : IAsmInstruction<Vminsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINSD;

            public static implicit operator AsmMnemonicCode(Vminsd src) => src.Mnemonic;
        }

        public readonly struct Minss : IAsmInstruction<Minss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MINSS;

            public static implicit operator AsmMnemonicCode(Minss src) => src.Mnemonic;
        }

        public readonly struct Vminss : IAsmInstruction<Vminss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMINSS;

            public static implicit operator AsmMnemonicCode(Vminss src) => src.Mnemonic;
        }

        public readonly struct Mov : IAsmInstruction<Mov>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOV;

            public static implicit operator AsmMnemonicCode(Mov src) => src.Mnemonic;
        }

        public readonly struct Movapd : IAsmInstruction<Movapd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVAPD;

            public static implicit operator AsmMnemonicCode(Movapd src) => src.Mnemonic;
        }

        public readonly struct Vmovapd : IAsmInstruction<Vmovapd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVAPD;

            public static implicit operator AsmMnemonicCode(Vmovapd src) => src.Mnemonic;
        }

        public readonly struct Movaps : IAsmInstruction<Movaps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVAPS;

            public static implicit operator AsmMnemonicCode(Movaps src) => src.Mnemonic;
        }

        public readonly struct Vmovaps : IAsmInstruction<Vmovaps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVAPS;

            public static implicit operator AsmMnemonicCode(Vmovaps src) => src.Mnemonic;
        }

        public readonly struct Movbe : IAsmInstruction<Movbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVBE;

            public static implicit operator AsmMnemonicCode(Movbe src) => src.Mnemonic;
        }

        public readonly struct Movd : IAsmInstruction<Movd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVD;

            public static implicit operator AsmMnemonicCode(Movd src) => src.Mnemonic;
        }

        public readonly struct Movq : IAsmInstruction<Movq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVQ;

            public static implicit operator AsmMnemonicCode(Movq src) => src.Mnemonic;
        }

        public readonly struct Vmovd : IAsmInstruction<Vmovd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVD;

            public static implicit operator AsmMnemonicCode(Vmovd src) => src.Mnemonic;
        }

        public readonly struct Vmovq : IAsmInstruction<Vmovq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVQ;

            public static implicit operator AsmMnemonicCode(Vmovq src) => src.Mnemonic;
        }

        public readonly struct Movddup : IAsmInstruction<Movddup>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDDUP;

            public static implicit operator AsmMnemonicCode(Movddup src) => src.Mnemonic;
        }

        public readonly struct Vmovddup : IAsmInstruction<Vmovddup>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVDDUP;

            public static implicit operator AsmMnemonicCode(Vmovddup src) => src.Mnemonic;
        }

        public readonly struct Movdqa : IAsmInstruction<Movdqa>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDQA;

            public static implicit operator AsmMnemonicCode(Movdqa src) => src.Mnemonic;
        }

        public readonly struct Vmovdqa : IAsmInstruction<Vmovdqa>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVDQA;

            public static implicit operator AsmMnemonicCode(Vmovdqa src) => src.Mnemonic;
        }

        public readonly struct Movdqu : IAsmInstruction<Movdqu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDQU;

            public static implicit operator AsmMnemonicCode(Movdqu src) => src.Mnemonic;
        }

        public readonly struct Vmovdqu : IAsmInstruction<Vmovdqu>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVDQU;

            public static implicit operator AsmMnemonicCode(Vmovdqu src) => src.Mnemonic;
        }

        public readonly struct Movdq2q : IAsmInstruction<Movdq2q>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVDQ2Q;

            public static implicit operator AsmMnemonicCode(Movdq2q src) => src.Mnemonic;
        }

        public readonly struct Movhlps : IAsmInstruction<Movhlps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVHLPS;

            public static implicit operator AsmMnemonicCode(Movhlps src) => src.Mnemonic;
        }

        public readonly struct Vmovhlps : IAsmInstruction<Vmovhlps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVHLPS;

            public static implicit operator AsmMnemonicCode(Vmovhlps src) => src.Mnemonic;
        }

        public readonly struct Movhpd : IAsmInstruction<Movhpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVHPD;

            public static implicit operator AsmMnemonicCode(Movhpd src) => src.Mnemonic;
        }

        public readonly struct Vmovhpd : IAsmInstruction<Vmovhpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVHPD;

            public static implicit operator AsmMnemonicCode(Vmovhpd src) => src.Mnemonic;
        }

        public readonly struct Movhps : IAsmInstruction<Movhps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVHPS;

            public static implicit operator AsmMnemonicCode(Movhps src) => src.Mnemonic;
        }

        public readonly struct Vmovhps : IAsmInstruction<Vmovhps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVHPS;

            public static implicit operator AsmMnemonicCode(Vmovhps src) => src.Mnemonic;
        }

        public readonly struct Movlhps : IAsmInstruction<Movlhps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVLHPS;

            public static implicit operator AsmMnemonicCode(Movlhps src) => src.Mnemonic;
        }

        public readonly struct Vmovlhps : IAsmInstruction<Vmovlhps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVLHPS;

            public static implicit operator AsmMnemonicCode(Vmovlhps src) => src.Mnemonic;
        }

        public readonly struct Movlpd : IAsmInstruction<Movlpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVLPD;

            public static implicit operator AsmMnemonicCode(Movlpd src) => src.Mnemonic;
        }

        public readonly struct Vmovlpd : IAsmInstruction<Vmovlpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVLPD;

            public static implicit operator AsmMnemonicCode(Vmovlpd src) => src.Mnemonic;
        }

        public readonly struct Movlps : IAsmInstruction<Movlps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVLPS;

            public static implicit operator AsmMnemonicCode(Movlps src) => src.Mnemonic;
        }

        public readonly struct Vmovlps : IAsmInstruction<Vmovlps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVLPS;

            public static implicit operator AsmMnemonicCode(Vmovlps src) => src.Mnemonic;
        }

        public readonly struct Movmskpd : IAsmInstruction<Movmskpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVMSKPD;

            public static implicit operator AsmMnemonicCode(Movmskpd src) => src.Mnemonic;
        }

        public readonly struct Vmovmskpd : IAsmInstruction<Vmovmskpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVMSKPD;

            public static implicit operator AsmMnemonicCode(Vmovmskpd src) => src.Mnemonic;
        }

        public readonly struct Movmskps : IAsmInstruction<Movmskps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVMSKPS;

            public static implicit operator AsmMnemonicCode(Movmskps src) => src.Mnemonic;
        }

        public readonly struct Vmovmskps : IAsmInstruction<Vmovmskps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVMSKPS;

            public static implicit operator AsmMnemonicCode(Vmovmskps src) => src.Mnemonic;
        }

        public readonly struct Movntdqa : IAsmInstruction<Movntdqa>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTDQA;

            public static implicit operator AsmMnemonicCode(Movntdqa src) => src.Mnemonic;
        }

        public readonly struct Vmovntdqa : IAsmInstruction<Vmovntdqa>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTDQA;

            public static implicit operator AsmMnemonicCode(Vmovntdqa src) => src.Mnemonic;
        }

        public readonly struct Movntdq : IAsmInstruction<Movntdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTDQ;

            public static implicit operator AsmMnemonicCode(Movntdq src) => src.Mnemonic;
        }

        public readonly struct Vmovntdq : IAsmInstruction<Vmovntdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTDQ;

            public static implicit operator AsmMnemonicCode(Vmovntdq src) => src.Mnemonic;
        }

        public readonly struct Movnti : IAsmInstruction<Movnti>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTI;

            public static implicit operator AsmMnemonicCode(Movnti src) => src.Mnemonic;
        }

        public readonly struct Movntpd : IAsmInstruction<Movntpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTPD;

            public static implicit operator AsmMnemonicCode(Movntpd src) => src.Mnemonic;
        }

        public readonly struct Vmovntpd : IAsmInstruction<Vmovntpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTPD;

            public static implicit operator AsmMnemonicCode(Vmovntpd src) => src.Mnemonic;
        }

        public readonly struct Movntps : IAsmInstruction<Movntps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTPS;

            public static implicit operator AsmMnemonicCode(Movntps src) => src.Mnemonic;
        }

        public readonly struct Vmovntps : IAsmInstruction<Vmovntps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVNTPS;

            public static implicit operator AsmMnemonicCode(Vmovntps src) => src.Mnemonic;
        }

        public readonly struct Movntq : IAsmInstruction<Movntq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVNTQ;

            public static implicit operator AsmMnemonicCode(Movntq src) => src.Mnemonic;
        }

        public readonly struct Movq2dq : IAsmInstruction<Movq2dq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVQ2DQ;

            public static implicit operator AsmMnemonicCode(Movq2dq src) => src.Mnemonic;
        }

        public readonly struct Movs : IAsmInstruction<Movs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVS;

            public static implicit operator AsmMnemonicCode(Movs src) => src.Mnemonic;
        }

        public readonly struct Movsd : IAsmInstruction<Movsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSD;

            public static implicit operator AsmMnemonicCode(Movsd src) => src.Mnemonic;
        }

        public readonly struct Vmovsd : IAsmInstruction<Vmovsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSD;

            public static implicit operator AsmMnemonicCode(Vmovsd src) => src.Mnemonic;
        }

        public readonly struct Movshdup : IAsmInstruction<Movshdup>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSHDUP;

            public static implicit operator AsmMnemonicCode(Movshdup src) => src.Mnemonic;
        }

        public readonly struct Vmovshdup : IAsmInstruction<Vmovshdup>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSHDUP;

            public static implicit operator AsmMnemonicCode(Vmovshdup src) => src.Mnemonic;
        }

        public readonly struct Movsldup : IAsmInstruction<Movsldup>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSLDUP;

            public static implicit operator AsmMnemonicCode(Movsldup src) => src.Mnemonic;
        }

        public readonly struct Vmovsldup : IAsmInstruction<Vmovsldup>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSLDUP;

            public static implicit operator AsmMnemonicCode(Vmovsldup src) => src.Mnemonic;
        }

        public readonly struct Movss : IAsmInstruction<Movss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSS;

            public static implicit operator AsmMnemonicCode(Movss src) => src.Mnemonic;
        }

        public readonly struct Vmovss : IAsmInstruction<Vmovss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVSS;

            public static implicit operator AsmMnemonicCode(Vmovss src) => src.Mnemonic;
        }

        public readonly struct Movsx : IAsmInstruction<Movsx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSX;

            public static implicit operator AsmMnemonicCode(Movsx src) => src.Mnemonic;
        }

        public readonly struct Movsxd : IAsmInstruction<Movsxd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVSXD;

            public static implicit operator AsmMnemonicCode(Movsxd src) => src.Mnemonic;
        }

        public readonly struct Movupd : IAsmInstruction<Movupd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVUPD;

            public static implicit operator AsmMnemonicCode(Movupd src) => src.Mnemonic;
        }

        public readonly struct Vmovupd : IAsmInstruction<Vmovupd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVUPD;

            public static implicit operator AsmMnemonicCode(Vmovupd src) => src.Mnemonic;
        }

        public readonly struct Movups : IAsmInstruction<Movups>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVUPS;

            public static implicit operator AsmMnemonicCode(Movups src) => src.Mnemonic;
        }

        public readonly struct Vmovups : IAsmInstruction<Vmovups>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMOVUPS;

            public static implicit operator AsmMnemonicCode(Vmovups src) => src.Mnemonic;
        }

        public readonly struct Movzx : IAsmInstruction<Movzx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MOVZX;

            public static implicit operator AsmMnemonicCode(Movzx src) => src.Mnemonic;
        }

        public readonly struct Mpsadbw : IAsmInstruction<Mpsadbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MPSADBW;

            public static implicit operator AsmMnemonicCode(Mpsadbw src) => src.Mnemonic;
        }

        public readonly struct Vmpsadbw : IAsmInstruction<Vmpsadbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMPSADBW;

            public static implicit operator AsmMnemonicCode(Vmpsadbw src) => src.Mnemonic;
        }

        public readonly struct Mul : IAsmInstruction<Mul>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MUL;

            public static implicit operator AsmMnemonicCode(Mul src) => src.Mnemonic;
        }

        public readonly struct Mulpd : IAsmInstruction<Mulpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULPD;

            public static implicit operator AsmMnemonicCode(Mulpd src) => src.Mnemonic;
        }

        public readonly struct Vmulpd : IAsmInstruction<Vmulpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULPD;

            public static implicit operator AsmMnemonicCode(Vmulpd src) => src.Mnemonic;
        }

        public readonly struct Mulps : IAsmInstruction<Mulps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULPS;

            public static implicit operator AsmMnemonicCode(Mulps src) => src.Mnemonic;
        }

        public readonly struct Vmulps : IAsmInstruction<Vmulps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULPS;

            public static implicit operator AsmMnemonicCode(Vmulps src) => src.Mnemonic;
        }

        public readonly struct Mulsd : IAsmInstruction<Mulsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULSD;

            public static implicit operator AsmMnemonicCode(Mulsd src) => src.Mnemonic;
        }

        public readonly struct Vmulsd : IAsmInstruction<Vmulsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULSD;

            public static implicit operator AsmMnemonicCode(Vmulsd src) => src.Mnemonic;
        }

        public readonly struct Mulss : IAsmInstruction<Mulss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULSS;

            public static implicit operator AsmMnemonicCode(Mulss src) => src.Mnemonic;
        }

        public readonly struct Vmulss : IAsmInstruction<Vmulss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMULSS;

            public static implicit operator AsmMnemonicCode(Vmulss src) => src.Mnemonic;
        }

        public readonly struct Mulx : IAsmInstruction<Mulx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.MULX;

            public static implicit operator AsmMnemonicCode(Mulx src) => src.Mnemonic;
        }

        public readonly struct Neg : IAsmInstruction<Neg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.NEG;

            public static implicit operator AsmMnemonicCode(Neg src) => src.Mnemonic;
        }

        public readonly struct Nop : IAsmInstruction<Nop>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.NOP;

            public static implicit operator AsmMnemonicCode(Nop src) => src.Mnemonic;
        }

        public readonly struct Not : IAsmInstruction<Not>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.NOT;

            public static implicit operator AsmMnemonicCode(Not src) => src.Mnemonic;
        }

        public readonly struct Or : IAsmInstruction<Or>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OR;

            public static implicit operator AsmMnemonicCode(Or src) => src.Mnemonic;
        }

        public readonly struct Orpd : IAsmInstruction<Orpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ORPD;

            public static implicit operator AsmMnemonicCode(Orpd src) => src.Mnemonic;
        }

        public readonly struct Vorpd : IAsmInstruction<Vorpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VORPD;

            public static implicit operator AsmMnemonicCode(Vorpd src) => src.Mnemonic;
        }

        public readonly struct Orps : IAsmInstruction<Orps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ORPS;

            public static implicit operator AsmMnemonicCode(Orps src) => src.Mnemonic;
        }

        public readonly struct Vorps : IAsmInstruction<Vorps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VORPS;

            public static implicit operator AsmMnemonicCode(Vorps src) => src.Mnemonic;
        }

        public readonly struct Out : IAsmInstruction<Out>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUT;

            public static implicit operator AsmMnemonicCode(Out src) => src.Mnemonic;
        }

        public readonly struct Outs : IAsmInstruction<Outs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.OUTS;

            public static implicit operator AsmMnemonicCode(Outs src) => src.Mnemonic;
        }

        public readonly struct Pabsb : IAsmInstruction<Pabsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PABSB;

            public static implicit operator AsmMnemonicCode(Pabsb src) => src.Mnemonic;
        }

        public readonly struct Pabsw : IAsmInstruction<Pabsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PABSW;

            public static implicit operator AsmMnemonicCode(Pabsw src) => src.Mnemonic;
        }

        public readonly struct Pabsd : IAsmInstruction<Pabsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PABSD;

            public static implicit operator AsmMnemonicCode(Pabsd src) => src.Mnemonic;
        }

        public readonly struct Vpabsb : IAsmInstruction<Vpabsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPABSB;

            public static implicit operator AsmMnemonicCode(Vpabsb src) => src.Mnemonic;
        }

        public readonly struct Vpabsw : IAsmInstruction<Vpabsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPABSW;

            public static implicit operator AsmMnemonicCode(Vpabsw src) => src.Mnemonic;
        }

        public readonly struct Vpabsd : IAsmInstruction<Vpabsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPABSD;

            public static implicit operator AsmMnemonicCode(Vpabsd src) => src.Mnemonic;
        }

        public readonly struct Packsswb : IAsmInstruction<Packsswb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKSSWB;

            public static implicit operator AsmMnemonicCode(Packsswb src) => src.Mnemonic;
        }

        public readonly struct Packssdw : IAsmInstruction<Packssdw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKSSDW;

            public static implicit operator AsmMnemonicCode(Packssdw src) => src.Mnemonic;
        }

        public readonly struct Vpacksswb : IAsmInstruction<Vpacksswb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKSSWB;

            public static implicit operator AsmMnemonicCode(Vpacksswb src) => src.Mnemonic;
        }

        public readonly struct Vpackssdw : IAsmInstruction<Vpackssdw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKSSDW;

            public static implicit operator AsmMnemonicCode(Vpackssdw src) => src.Mnemonic;
        }

        public readonly struct Packusdw : IAsmInstruction<Packusdw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKUSDW;

            public static implicit operator AsmMnemonicCode(Packusdw src) => src.Mnemonic;
        }

        public readonly struct Vpackusdw : IAsmInstruction<Vpackusdw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKUSDW;

            public static implicit operator AsmMnemonicCode(Vpackusdw src) => src.Mnemonic;
        }

        public readonly struct Packuswb : IAsmInstruction<Packuswb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PACKUSWB;

            public static implicit operator AsmMnemonicCode(Packuswb src) => src.Mnemonic;
        }

        public readonly struct Vpackuswb : IAsmInstruction<Vpackuswb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPACKUSWB;

            public static implicit operator AsmMnemonicCode(Vpackuswb src) => src.Mnemonic;
        }

        public readonly struct Paddb : IAsmInstruction<Paddb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDB;

            public static implicit operator AsmMnemonicCode(Paddb src) => src.Mnemonic;
        }

        public readonly struct Paddw : IAsmInstruction<Paddw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDW;

            public static implicit operator AsmMnemonicCode(Paddw src) => src.Mnemonic;
        }

        public readonly struct Paddd : IAsmInstruction<Paddd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDD;

            public static implicit operator AsmMnemonicCode(Paddd src) => src.Mnemonic;
        }

        public readonly struct Vpaddb : IAsmInstruction<Vpaddb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDB;

            public static implicit operator AsmMnemonicCode(Vpaddb src) => src.Mnemonic;
        }

        public readonly struct Vpaddw : IAsmInstruction<Vpaddw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDW;

            public static implicit operator AsmMnemonicCode(Vpaddw src) => src.Mnemonic;
        }

        public readonly struct Vpaddd : IAsmInstruction<Vpaddd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDD;

            public static implicit operator AsmMnemonicCode(Vpaddd src) => src.Mnemonic;
        }

        public readonly struct Paddq : IAsmInstruction<Paddq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDQ;

            public static implicit operator AsmMnemonicCode(Paddq src) => src.Mnemonic;
        }

        public readonly struct Vpaddq : IAsmInstruction<Vpaddq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDQ;

            public static implicit operator AsmMnemonicCode(Vpaddq src) => src.Mnemonic;
        }

        public readonly struct Paddsb : IAsmInstruction<Paddsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDSB;

            public static implicit operator AsmMnemonicCode(Paddsb src) => src.Mnemonic;
        }

        public readonly struct Paddsw : IAsmInstruction<Paddsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDSW;

            public static implicit operator AsmMnemonicCode(Paddsw src) => src.Mnemonic;
        }

        public readonly struct Vpaddsb : IAsmInstruction<Vpaddsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDSB;

            public static implicit operator AsmMnemonicCode(Vpaddsb src) => src.Mnemonic;
        }

        public readonly struct Vpaddsw : IAsmInstruction<Vpaddsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDSW;

            public static implicit operator AsmMnemonicCode(Vpaddsw src) => src.Mnemonic;
        }

        public readonly struct Paddusb : IAsmInstruction<Paddusb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDUSB;

            public static implicit operator AsmMnemonicCode(Paddusb src) => src.Mnemonic;
        }

        public readonly struct Paddusw : IAsmInstruction<Paddusw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PADDUSW;

            public static implicit operator AsmMnemonicCode(Paddusw src) => src.Mnemonic;
        }

        public readonly struct Vpaddusb : IAsmInstruction<Vpaddusb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDUSB;

            public static implicit operator AsmMnemonicCode(Vpaddusb src) => src.Mnemonic;
        }

        public readonly struct Vpaddusw : IAsmInstruction<Vpaddusw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPADDUSW;

            public static implicit operator AsmMnemonicCode(Vpaddusw src) => src.Mnemonic;
        }

        public readonly struct Palignr : IAsmInstruction<Palignr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PALIGNR;

            public static implicit operator AsmMnemonicCode(Palignr src) => src.Mnemonic;
        }

        public readonly struct Vpalignr : IAsmInstruction<Vpalignr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPALIGNR;

            public static implicit operator AsmMnemonicCode(Vpalignr src) => src.Mnemonic;
        }

        public readonly struct Pand : IAsmInstruction<Pand>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAND;

            public static implicit operator AsmMnemonicCode(Pand src) => src.Mnemonic;
        }

        public readonly struct Vpand : IAsmInstruction<Vpand>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPAND;

            public static implicit operator AsmMnemonicCode(Vpand src) => src.Mnemonic;
        }

        public readonly struct Pandn : IAsmInstruction<Pandn>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PANDN;

            public static implicit operator AsmMnemonicCode(Pandn src) => src.Mnemonic;
        }

        public readonly struct Vpandn : IAsmInstruction<Vpandn>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPANDN;

            public static implicit operator AsmMnemonicCode(Vpandn src) => src.Mnemonic;
        }

        public readonly struct Pavgb : IAsmInstruction<Pavgb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAVGB;

            public static implicit operator AsmMnemonicCode(Pavgb src) => src.Mnemonic;
        }

        public readonly struct Pavgw : IAsmInstruction<Pavgw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PAVGW;

            public static implicit operator AsmMnemonicCode(Pavgw src) => src.Mnemonic;
        }

        public readonly struct Vpavgb : IAsmInstruction<Vpavgb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPAVGB;

            public static implicit operator AsmMnemonicCode(Vpavgb src) => src.Mnemonic;
        }

        public readonly struct Vpavgw : IAsmInstruction<Vpavgw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPAVGW;

            public static implicit operator AsmMnemonicCode(Vpavgw src) => src.Mnemonic;
        }

        public readonly struct Pblendvb : IAsmInstruction<Pblendvb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PBLENDVB;

            public static implicit operator AsmMnemonicCode(Pblendvb src) => src.Mnemonic;
        }

        public readonly struct Vpblendvb : IAsmInstruction<Vpblendvb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBLENDVB;

            public static implicit operator AsmMnemonicCode(Vpblendvb src) => src.Mnemonic;
        }

        public readonly struct Pblendw : IAsmInstruction<Pblendw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PBLENDW;

            public static implicit operator AsmMnemonicCode(Pblendw src) => src.Mnemonic;
        }

        public readonly struct Vpblendw : IAsmInstruction<Vpblendw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBLENDW;

            public static implicit operator AsmMnemonicCode(Vpblendw src) => src.Mnemonic;
        }

        public readonly struct Pclmulqdq : IAsmInstruction<Pclmulqdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCLMULQDQ;

            public static implicit operator AsmMnemonicCode(Pclmulqdq src) => src.Mnemonic;
        }

        public readonly struct Vpclmulqdq : IAsmInstruction<Vpclmulqdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCLMULQDQ;

            public static implicit operator AsmMnemonicCode(Vpclmulqdq src) => src.Mnemonic;
        }

        public readonly struct Pcmpeqb : IAsmInstruction<Pcmpeqb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQB;

            public static implicit operator AsmMnemonicCode(Pcmpeqb src) => src.Mnemonic;
        }

        public readonly struct Pcmpeqw : IAsmInstruction<Pcmpeqw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQW;

            public static implicit operator AsmMnemonicCode(Pcmpeqw src) => src.Mnemonic;
        }

        public readonly struct Pcmpeqd : IAsmInstruction<Pcmpeqd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQD;

            public static implicit operator AsmMnemonicCode(Pcmpeqd src) => src.Mnemonic;
        }

        public readonly struct Vpcmpeqb : IAsmInstruction<Vpcmpeqb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQB;

            public static implicit operator AsmMnemonicCode(Vpcmpeqb src) => src.Mnemonic;
        }

        public readonly struct Vpcmpeqw : IAsmInstruction<Vpcmpeqw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQW;

            public static implicit operator AsmMnemonicCode(Vpcmpeqw src) => src.Mnemonic;
        }

        public readonly struct Vpcmpeqd : IAsmInstruction<Vpcmpeqd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQD;

            public static implicit operator AsmMnemonicCode(Vpcmpeqd src) => src.Mnemonic;
        }

        public readonly struct Pcmpeqq : IAsmInstruction<Pcmpeqq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPEQQ;

            public static implicit operator AsmMnemonicCode(Pcmpeqq src) => src.Mnemonic;
        }

        public readonly struct Vpcmpeqq : IAsmInstruction<Vpcmpeqq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPEQQ;

            public static implicit operator AsmMnemonicCode(Vpcmpeqq src) => src.Mnemonic;
        }

        public readonly struct Pcmpestri : IAsmInstruction<Pcmpestri>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPESTRI;

            public static implicit operator AsmMnemonicCode(Pcmpestri src) => src.Mnemonic;
        }

        public readonly struct Vpcmpestri : IAsmInstruction<Vpcmpestri>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPESTRI;

            public static implicit operator AsmMnemonicCode(Vpcmpestri src) => src.Mnemonic;
        }

        public readonly struct Pcmpestrm : IAsmInstruction<Pcmpestrm>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPESTRM;

            public static implicit operator AsmMnemonicCode(Pcmpestrm src) => src.Mnemonic;
        }

        public readonly struct Vpcmpestrm : IAsmInstruction<Vpcmpestrm>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPESTRM;

            public static implicit operator AsmMnemonicCode(Vpcmpestrm src) => src.Mnemonic;
        }

        public readonly struct Pcmpgtb : IAsmInstruction<Pcmpgtb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTB;

            public static implicit operator AsmMnemonicCode(Pcmpgtb src) => src.Mnemonic;
        }

        public readonly struct Pcmpgtw : IAsmInstruction<Pcmpgtw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTW;

            public static implicit operator AsmMnemonicCode(Pcmpgtw src) => src.Mnemonic;
        }

        public readonly struct Pcmpgtd : IAsmInstruction<Pcmpgtd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTD;

            public static implicit operator AsmMnemonicCode(Pcmpgtd src) => src.Mnemonic;
        }

        public readonly struct Vpcmpgtb : IAsmInstruction<Vpcmpgtb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTB;

            public static implicit operator AsmMnemonicCode(Vpcmpgtb src) => src.Mnemonic;
        }

        public readonly struct Vpcmpgtw : IAsmInstruction<Vpcmpgtw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTW;

            public static implicit operator AsmMnemonicCode(Vpcmpgtw src) => src.Mnemonic;
        }

        public readonly struct Vpcmpgtd : IAsmInstruction<Vpcmpgtd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTD;

            public static implicit operator AsmMnemonicCode(Vpcmpgtd src) => src.Mnemonic;
        }

        public readonly struct Pcmpgtq : IAsmInstruction<Pcmpgtq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPGTQ;

            public static implicit operator AsmMnemonicCode(Pcmpgtq src) => src.Mnemonic;
        }

        public readonly struct Vpcmpgtq : IAsmInstruction<Vpcmpgtq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPGTQ;

            public static implicit operator AsmMnemonicCode(Vpcmpgtq src) => src.Mnemonic;
        }

        public readonly struct Pcmpistri : IAsmInstruction<Pcmpistri>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPISTRI;

            public static implicit operator AsmMnemonicCode(Pcmpistri src) => src.Mnemonic;
        }

        public readonly struct Vpcmpistri : IAsmInstruction<Vpcmpistri>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPISTRI;

            public static implicit operator AsmMnemonicCode(Vpcmpistri src) => src.Mnemonic;
        }

        public readonly struct Pcmpistrm : IAsmInstruction<Pcmpistrm>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PCMPISTRM;

            public static implicit operator AsmMnemonicCode(Pcmpistrm src) => src.Mnemonic;
        }

        public readonly struct Vpcmpistrm : IAsmInstruction<Vpcmpistrm>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPCMPISTRM;

            public static implicit operator AsmMnemonicCode(Vpcmpistrm src) => src.Mnemonic;
        }

        public readonly struct Pdep : IAsmInstruction<Pdep>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PDEP;

            public static implicit operator AsmMnemonicCode(Pdep src) => src.Mnemonic;
        }

        public readonly struct Pext : IAsmInstruction<Pext>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXT;

            public static implicit operator AsmMnemonicCode(Pext src) => src.Mnemonic;
        }

        public readonly struct Pextrb : IAsmInstruction<Pextrb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRB;

            public static implicit operator AsmMnemonicCode(Pextrb src) => src.Mnemonic;
        }

        public readonly struct Pextrd : IAsmInstruction<Pextrd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRD;

            public static implicit operator AsmMnemonicCode(Pextrd src) => src.Mnemonic;
        }

        public readonly struct Pextrq : IAsmInstruction<Pextrq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRQ;

            public static implicit operator AsmMnemonicCode(Pextrq src) => src.Mnemonic;
        }

        public readonly struct Vpextrb : IAsmInstruction<Vpextrb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRB;

            public static implicit operator AsmMnemonicCode(Vpextrb src) => src.Mnemonic;
        }

        public readonly struct Vpextrd : IAsmInstruction<Vpextrd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRD;

            public static implicit operator AsmMnemonicCode(Vpextrd src) => src.Mnemonic;
        }

        public readonly struct Vpextrq : IAsmInstruction<Vpextrq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRQ;

            public static implicit operator AsmMnemonicCode(Vpextrq src) => src.Mnemonic;
        }

        public readonly struct Pextrw : IAsmInstruction<Pextrw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PEXTRW;

            public static implicit operator AsmMnemonicCode(Pextrw src) => src.Mnemonic;
        }

        public readonly struct Vpextrw : IAsmInstruction<Vpextrw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPEXTRW;

            public static implicit operator AsmMnemonicCode(Vpextrw src) => src.Mnemonic;
        }

        public readonly struct Phaddw : IAsmInstruction<Phaddw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHADDW;

            public static implicit operator AsmMnemonicCode(Phaddw src) => src.Mnemonic;
        }

        public readonly struct Phaddd : IAsmInstruction<Phaddd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHADDD;

            public static implicit operator AsmMnemonicCode(Phaddd src) => src.Mnemonic;
        }

        public readonly struct Vphaddw : IAsmInstruction<Vphaddw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHADDW;

            public static implicit operator AsmMnemonicCode(Vphaddw src) => src.Mnemonic;
        }

        public readonly struct Vphaddd : IAsmInstruction<Vphaddd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHADDD;

            public static implicit operator AsmMnemonicCode(Vphaddd src) => src.Mnemonic;
        }

        public readonly struct Phaddsw : IAsmInstruction<Phaddsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHADDSW;

            public static implicit operator AsmMnemonicCode(Phaddsw src) => src.Mnemonic;
        }

        public readonly struct Vphaddsw : IAsmInstruction<Vphaddsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHADDSW;

            public static implicit operator AsmMnemonicCode(Vphaddsw src) => src.Mnemonic;
        }

        public readonly struct Phminposuw : IAsmInstruction<Phminposuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHMINPOSUW;

            public static implicit operator AsmMnemonicCode(Phminposuw src) => src.Mnemonic;
        }

        public readonly struct Vphminposuw : IAsmInstruction<Vphminposuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHMINPOSUW;

            public static implicit operator AsmMnemonicCode(Vphminposuw src) => src.Mnemonic;
        }

        public readonly struct Phsubw : IAsmInstruction<Phsubw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHSUBW;

            public static implicit operator AsmMnemonicCode(Phsubw src) => src.Mnemonic;
        }

        public readonly struct Phsubd : IAsmInstruction<Phsubd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHSUBD;

            public static implicit operator AsmMnemonicCode(Phsubd src) => src.Mnemonic;
        }

        public readonly struct Vphsubw : IAsmInstruction<Vphsubw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHSUBW;

            public static implicit operator AsmMnemonicCode(Vphsubw src) => src.Mnemonic;
        }

        public readonly struct Vphsubd : IAsmInstruction<Vphsubd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHSUBD;

            public static implicit operator AsmMnemonicCode(Vphsubd src) => src.Mnemonic;
        }

        public readonly struct Phsubsw : IAsmInstruction<Phsubsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PHSUBSW;

            public static implicit operator AsmMnemonicCode(Phsubsw src) => src.Mnemonic;
        }

        public readonly struct Vphsubsw : IAsmInstruction<Vphsubsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPHSUBSW;

            public static implicit operator AsmMnemonicCode(Vphsubsw src) => src.Mnemonic;
        }

        public readonly struct Pinsrb : IAsmInstruction<Pinsrb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRB;

            public static implicit operator AsmMnemonicCode(Pinsrb src) => src.Mnemonic;
        }

        public readonly struct Pinsrd : IAsmInstruction<Pinsrd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRD;

            public static implicit operator AsmMnemonicCode(Pinsrd src) => src.Mnemonic;
        }

        public readonly struct Pinsrq : IAsmInstruction<Pinsrq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRQ;

            public static implicit operator AsmMnemonicCode(Pinsrq src) => src.Mnemonic;
        }

        public readonly struct Vpinsrb : IAsmInstruction<Vpinsrb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRB;

            public static implicit operator AsmMnemonicCode(Vpinsrb src) => src.Mnemonic;
        }

        public readonly struct Vpinsrd : IAsmInstruction<Vpinsrd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRD;

            public static implicit operator AsmMnemonicCode(Vpinsrd src) => src.Mnemonic;
        }

        public readonly struct Vpinsrq : IAsmInstruction<Vpinsrq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRQ;

            public static implicit operator AsmMnemonicCode(Vpinsrq src) => src.Mnemonic;
        }

        public readonly struct Pinsrw : IAsmInstruction<Pinsrw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PINSRW;

            public static implicit operator AsmMnemonicCode(Pinsrw src) => src.Mnemonic;
        }

        public readonly struct Vpinsrw : IAsmInstruction<Vpinsrw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPINSRW;

            public static implicit operator AsmMnemonicCode(Vpinsrw src) => src.Mnemonic;
        }

        public readonly struct Pmaddubsw : IAsmInstruction<Pmaddubsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMADDUBSW;

            public static implicit operator AsmMnemonicCode(Pmaddubsw src) => src.Mnemonic;
        }

        public readonly struct Vpmaddubsw : IAsmInstruction<Vpmaddubsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMADDUBSW;

            public static implicit operator AsmMnemonicCode(Vpmaddubsw src) => src.Mnemonic;
        }

        public readonly struct Pmaddwd : IAsmInstruction<Pmaddwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMADDWD;

            public static implicit operator AsmMnemonicCode(Pmaddwd src) => src.Mnemonic;
        }

        public readonly struct Vpmaddwd : IAsmInstruction<Vpmaddwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMADDWD;

            public static implicit operator AsmMnemonicCode(Vpmaddwd src) => src.Mnemonic;
        }

        public readonly struct Pmaxsb : IAsmInstruction<Pmaxsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXSB;

            public static implicit operator AsmMnemonicCode(Pmaxsb src) => src.Mnemonic;
        }

        public readonly struct Vpmaxsb : IAsmInstruction<Vpmaxsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXSB;

            public static implicit operator AsmMnemonicCode(Vpmaxsb src) => src.Mnemonic;
        }

        public readonly struct Pmaxsd : IAsmInstruction<Pmaxsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXSD;

            public static implicit operator AsmMnemonicCode(Pmaxsd src) => src.Mnemonic;
        }

        public readonly struct Vpmaxsd : IAsmInstruction<Vpmaxsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXSD;

            public static implicit operator AsmMnemonicCode(Vpmaxsd src) => src.Mnemonic;
        }

        public readonly struct Pmaxsw : IAsmInstruction<Pmaxsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXSW;

            public static implicit operator AsmMnemonicCode(Pmaxsw src) => src.Mnemonic;
        }

        public readonly struct Vpmaxsw : IAsmInstruction<Vpmaxsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXSW;

            public static implicit operator AsmMnemonicCode(Vpmaxsw src) => src.Mnemonic;
        }

        public readonly struct Pmaxub : IAsmInstruction<Pmaxub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXUB;

            public static implicit operator AsmMnemonicCode(Pmaxub src) => src.Mnemonic;
        }

        public readonly struct Vpmaxub : IAsmInstruction<Vpmaxub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXUB;

            public static implicit operator AsmMnemonicCode(Vpmaxub src) => src.Mnemonic;
        }

        public readonly struct Pmaxud : IAsmInstruction<Pmaxud>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXUD;

            public static implicit operator AsmMnemonicCode(Pmaxud src) => src.Mnemonic;
        }

        public readonly struct Vpmaxud : IAsmInstruction<Vpmaxud>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXUD;

            public static implicit operator AsmMnemonicCode(Vpmaxud src) => src.Mnemonic;
        }

        public readonly struct Pmaxuw : IAsmInstruction<Pmaxuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMAXUW;

            public static implicit operator AsmMnemonicCode(Pmaxuw src) => src.Mnemonic;
        }

        public readonly struct Vpmaxuw : IAsmInstruction<Vpmaxuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMAXUW;

            public static implicit operator AsmMnemonicCode(Vpmaxuw src) => src.Mnemonic;
        }

        public readonly struct Pminsb : IAsmInstruction<Pminsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINSB;

            public static implicit operator AsmMnemonicCode(Pminsb src) => src.Mnemonic;
        }

        public readonly struct Vpminsb : IAsmInstruction<Vpminsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINSB;

            public static implicit operator AsmMnemonicCode(Vpminsb src) => src.Mnemonic;
        }

        public readonly struct Pminsd : IAsmInstruction<Pminsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINSD;

            public static implicit operator AsmMnemonicCode(Pminsd src) => src.Mnemonic;
        }

        public readonly struct Vpminsd : IAsmInstruction<Vpminsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINSD;

            public static implicit operator AsmMnemonicCode(Vpminsd src) => src.Mnemonic;
        }

        public readonly struct Pminsw : IAsmInstruction<Pminsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINSW;

            public static implicit operator AsmMnemonicCode(Pminsw src) => src.Mnemonic;
        }

        public readonly struct Vpminsw : IAsmInstruction<Vpminsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINSW;

            public static implicit operator AsmMnemonicCode(Vpminsw src) => src.Mnemonic;
        }

        public readonly struct Pminub : IAsmInstruction<Pminub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINUB;

            public static implicit operator AsmMnemonicCode(Pminub src) => src.Mnemonic;
        }

        public readonly struct Vpminub : IAsmInstruction<Vpminub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINUB;

            public static implicit operator AsmMnemonicCode(Vpminub src) => src.Mnemonic;
        }

        public readonly struct Pminud : IAsmInstruction<Pminud>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINUD;

            public static implicit operator AsmMnemonicCode(Pminud src) => src.Mnemonic;
        }

        public readonly struct Vpminud : IAsmInstruction<Vpminud>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINUD;

            public static implicit operator AsmMnemonicCode(Vpminud src) => src.Mnemonic;
        }

        public readonly struct Pminuw : IAsmInstruction<Pminuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMINUW;

            public static implicit operator AsmMnemonicCode(Pminuw src) => src.Mnemonic;
        }

        public readonly struct Vpminuw : IAsmInstruction<Vpminuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMINUW;

            public static implicit operator AsmMnemonicCode(Vpminuw src) => src.Mnemonic;
        }

        public readonly struct Pmovmskb : IAsmInstruction<Pmovmskb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVMSKB;

            public static implicit operator AsmMnemonicCode(Pmovmskb src) => src.Mnemonic;
        }

        public readonly struct Vpmovmskb : IAsmInstruction<Vpmovmskb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVMSKB;

            public static implicit operator AsmMnemonicCode(Vpmovmskb src) => src.Mnemonic;
        }

        public readonly struct Pmovsxbw : IAsmInstruction<Pmovsxbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXBW;

            public static implicit operator AsmMnemonicCode(Pmovsxbw src) => src.Mnemonic;
        }

        public readonly struct Pmovsxbd : IAsmInstruction<Pmovsxbd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXBD;

            public static implicit operator AsmMnemonicCode(Pmovsxbd src) => src.Mnemonic;
        }

        public readonly struct Pmovsxbq : IAsmInstruction<Pmovsxbq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXBQ;

            public static implicit operator AsmMnemonicCode(Pmovsxbq src) => src.Mnemonic;
        }

        public readonly struct Pmovsxwd : IAsmInstruction<Pmovsxwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXWD;

            public static implicit operator AsmMnemonicCode(Pmovsxwd src) => src.Mnemonic;
        }

        public readonly struct Pmovsxwq : IAsmInstruction<Pmovsxwq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXWQ;

            public static implicit operator AsmMnemonicCode(Pmovsxwq src) => src.Mnemonic;
        }

        public readonly struct Pmovsxdq : IAsmInstruction<Pmovsxdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVSXDQ;

            public static implicit operator AsmMnemonicCode(Pmovsxdq src) => src.Mnemonic;
        }

        public readonly struct Vpmovsxbw : IAsmInstruction<Vpmovsxbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXBW;

            public static implicit operator AsmMnemonicCode(Vpmovsxbw src) => src.Mnemonic;
        }

        public readonly struct Vpmovsxbd : IAsmInstruction<Vpmovsxbd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXBD;

            public static implicit operator AsmMnemonicCode(Vpmovsxbd src) => src.Mnemonic;
        }

        public readonly struct Vpmovsxbq : IAsmInstruction<Vpmovsxbq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXBQ;

            public static implicit operator AsmMnemonicCode(Vpmovsxbq src) => src.Mnemonic;
        }

        public readonly struct Vpmovsxwd : IAsmInstruction<Vpmovsxwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXWD;

            public static implicit operator AsmMnemonicCode(Vpmovsxwd src) => src.Mnemonic;
        }

        public readonly struct Vpmovsxwq : IAsmInstruction<Vpmovsxwq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXWQ;

            public static implicit operator AsmMnemonicCode(Vpmovsxwq src) => src.Mnemonic;
        }

        public readonly struct Vpmovsxdq : IAsmInstruction<Vpmovsxdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVSXDQ;

            public static implicit operator AsmMnemonicCode(Vpmovsxdq src) => src.Mnemonic;
        }

        public readonly struct Pmovzxbw : IAsmInstruction<Pmovzxbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXBW;

            public static implicit operator AsmMnemonicCode(Pmovzxbw src) => src.Mnemonic;
        }

        public readonly struct Pmovzxbd : IAsmInstruction<Pmovzxbd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXBD;

            public static implicit operator AsmMnemonicCode(Pmovzxbd src) => src.Mnemonic;
        }

        public readonly struct Pmovzxbq : IAsmInstruction<Pmovzxbq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXBQ;

            public static implicit operator AsmMnemonicCode(Pmovzxbq src) => src.Mnemonic;
        }

        public readonly struct Pmovzxwd : IAsmInstruction<Pmovzxwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXWD;

            public static implicit operator AsmMnemonicCode(Pmovzxwd src) => src.Mnemonic;
        }

        public readonly struct Pmovzxwq : IAsmInstruction<Pmovzxwq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXWQ;

            public static implicit operator AsmMnemonicCode(Pmovzxwq src) => src.Mnemonic;
        }

        public readonly struct Pmovzxdq : IAsmInstruction<Pmovzxdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMOVZXDQ;

            public static implicit operator AsmMnemonicCode(Pmovzxdq src) => src.Mnemonic;
        }

        public readonly struct Vpmovzxbw : IAsmInstruction<Vpmovzxbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXBW;

            public static implicit operator AsmMnemonicCode(Vpmovzxbw src) => src.Mnemonic;
        }

        public readonly struct Vpmovzxbd : IAsmInstruction<Vpmovzxbd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXBD;

            public static implicit operator AsmMnemonicCode(Vpmovzxbd src) => src.Mnemonic;
        }

        public readonly struct Vpmovzxbq : IAsmInstruction<Vpmovzxbq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXBQ;

            public static implicit operator AsmMnemonicCode(Vpmovzxbq src) => src.Mnemonic;
        }

        public readonly struct Vpmovzxwd : IAsmInstruction<Vpmovzxwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXWD;

            public static implicit operator AsmMnemonicCode(Vpmovzxwd src) => src.Mnemonic;
        }

        public readonly struct Vpmovzxwq : IAsmInstruction<Vpmovzxwq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXWQ;

            public static implicit operator AsmMnemonicCode(Vpmovzxwq src) => src.Mnemonic;
        }

        public readonly struct Vpmovzxdq : IAsmInstruction<Vpmovzxdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMOVZXDQ;

            public static implicit operator AsmMnemonicCode(Vpmovzxdq src) => src.Mnemonic;
        }

        public readonly struct Pmuldq : IAsmInstruction<Pmuldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULDQ;

            public static implicit operator AsmMnemonicCode(Pmuldq src) => src.Mnemonic;
        }

        public readonly struct Vpmuldq : IAsmInstruction<Vpmuldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULDQ;

            public static implicit operator AsmMnemonicCode(Vpmuldq src) => src.Mnemonic;
        }

        public readonly struct Pmulhrsw : IAsmInstruction<Pmulhrsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULHRSW;

            public static implicit operator AsmMnemonicCode(Pmulhrsw src) => src.Mnemonic;
        }

        public readonly struct Vpmulhrsw : IAsmInstruction<Vpmulhrsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULHRSW;

            public static implicit operator AsmMnemonicCode(Vpmulhrsw src) => src.Mnemonic;
        }

        public readonly struct Pmulhuw : IAsmInstruction<Pmulhuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULHUW;

            public static implicit operator AsmMnemonicCode(Pmulhuw src) => src.Mnemonic;
        }

        public readonly struct Vpmulhuw : IAsmInstruction<Vpmulhuw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULHUW;

            public static implicit operator AsmMnemonicCode(Vpmulhuw src) => src.Mnemonic;
        }

        public readonly struct Pmulhw : IAsmInstruction<Pmulhw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULHW;

            public static implicit operator AsmMnemonicCode(Pmulhw src) => src.Mnemonic;
        }

        public readonly struct Vpmulhw : IAsmInstruction<Vpmulhw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULHW;

            public static implicit operator AsmMnemonicCode(Vpmulhw src) => src.Mnemonic;
        }

        public readonly struct Pmulld : IAsmInstruction<Pmulld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULLD;

            public static implicit operator AsmMnemonicCode(Pmulld src) => src.Mnemonic;
        }

        public readonly struct Vpmulld : IAsmInstruction<Vpmulld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULLD;

            public static implicit operator AsmMnemonicCode(Vpmulld src) => src.Mnemonic;
        }

        public readonly struct Pmullw : IAsmInstruction<Pmullw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULLW;

            public static implicit operator AsmMnemonicCode(Pmullw src) => src.Mnemonic;
        }

        public readonly struct Vpmullw : IAsmInstruction<Vpmullw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULLW;

            public static implicit operator AsmMnemonicCode(Vpmullw src) => src.Mnemonic;
        }

        public readonly struct Pmuludq : IAsmInstruction<Pmuludq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PMULUDQ;

            public static implicit operator AsmMnemonicCode(Pmuludq src) => src.Mnemonic;
        }

        public readonly struct Vpmuludq : IAsmInstruction<Vpmuludq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMULUDQ;

            public static implicit operator AsmMnemonicCode(Vpmuludq src) => src.Mnemonic;
        }

        public readonly struct Pop : IAsmInstruction<Pop>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POP;

            public static implicit operator AsmMnemonicCode(Pop src) => src.Mnemonic;
        }

        public readonly struct Popcnt : IAsmInstruction<Popcnt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POPCNT;

            public static implicit operator AsmMnemonicCode(Popcnt src) => src.Mnemonic;
        }

        public readonly struct Por : IAsmInstruction<Por>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.POR;

            public static implicit operator AsmMnemonicCode(Por src) => src.Mnemonic;
        }

        public readonly struct Vpor : IAsmInstruction<Vpor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPOR;

            public static implicit operator AsmMnemonicCode(Vpor src) => src.Mnemonic;
        }

        public readonly struct Prefetcht0 : IAsmInstruction<Prefetcht0>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHT0;

            public static implicit operator AsmMnemonicCode(Prefetcht0 src) => src.Mnemonic;
        }

        public readonly struct Prefetcht1 : IAsmInstruction<Prefetcht1>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHT1;

            public static implicit operator AsmMnemonicCode(Prefetcht1 src) => src.Mnemonic;
        }

        public readonly struct Prefetcht2 : IAsmInstruction<Prefetcht2>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHT2;

            public static implicit operator AsmMnemonicCode(Prefetcht2 src) => src.Mnemonic;
        }

        public readonly struct Prefetchnta : IAsmInstruction<Prefetchnta>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PREFETCHNTA;

            public static implicit operator AsmMnemonicCode(Prefetchnta src) => src.Mnemonic;
        }

        public readonly struct Psadbw : IAsmInstruction<Psadbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSADBW;

            public static implicit operator AsmMnemonicCode(Psadbw src) => src.Mnemonic;
        }

        public readonly struct Vpsadbw : IAsmInstruction<Vpsadbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSADBW;

            public static implicit operator AsmMnemonicCode(Vpsadbw src) => src.Mnemonic;
        }

        public readonly struct Pshufb : IAsmInstruction<Pshufb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFB;

            public static implicit operator AsmMnemonicCode(Pshufb src) => src.Mnemonic;
        }

        public readonly struct Vpshufb : IAsmInstruction<Vpshufb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFB;

            public static implicit operator AsmMnemonicCode(Vpshufb src) => src.Mnemonic;
        }

        public readonly struct Pshufd : IAsmInstruction<Pshufd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFD;

            public static implicit operator AsmMnemonicCode(Pshufd src) => src.Mnemonic;
        }

        public readonly struct Vpshufd : IAsmInstruction<Vpshufd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFD;

            public static implicit operator AsmMnemonicCode(Vpshufd src) => src.Mnemonic;
        }

        public readonly struct Pshufhw : IAsmInstruction<Pshufhw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFHW;

            public static implicit operator AsmMnemonicCode(Pshufhw src) => src.Mnemonic;
        }

        public readonly struct Vpshufhw : IAsmInstruction<Vpshufhw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFHW;

            public static implicit operator AsmMnemonicCode(Vpshufhw src) => src.Mnemonic;
        }

        public readonly struct Pshuflw : IAsmInstruction<Pshuflw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFLW;

            public static implicit operator AsmMnemonicCode(Pshuflw src) => src.Mnemonic;
        }

        public readonly struct Vpshuflw : IAsmInstruction<Vpshuflw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSHUFLW;

            public static implicit operator AsmMnemonicCode(Vpshuflw src) => src.Mnemonic;
        }

        public readonly struct Pshufw : IAsmInstruction<Pshufw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSHUFW;

            public static implicit operator AsmMnemonicCode(Pshufw src) => src.Mnemonic;
        }

        public readonly struct Psignb : IAsmInstruction<Psignb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSIGNB;

            public static implicit operator AsmMnemonicCode(Psignb src) => src.Mnemonic;
        }

        public readonly struct Psignw : IAsmInstruction<Psignw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSIGNW;

            public static implicit operator AsmMnemonicCode(Psignw src) => src.Mnemonic;
        }

        public readonly struct Psignd : IAsmInstruction<Psignd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSIGND;

            public static implicit operator AsmMnemonicCode(Psignd src) => src.Mnemonic;
        }

        public readonly struct Vpsignb : IAsmInstruction<Vpsignb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSIGNB;

            public static implicit operator AsmMnemonicCode(Vpsignb src) => src.Mnemonic;
        }

        public readonly struct Vpsignw : IAsmInstruction<Vpsignw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSIGNW;

            public static implicit operator AsmMnemonicCode(Vpsignw src) => src.Mnemonic;
        }

        public readonly struct Vpsignd : IAsmInstruction<Vpsignd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSIGND;

            public static implicit operator AsmMnemonicCode(Vpsignd src) => src.Mnemonic;
        }

        public readonly struct Pslldq : IAsmInstruction<Pslldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLDQ;

            public static implicit operator AsmMnemonicCode(Pslldq src) => src.Mnemonic;
        }

        public readonly struct Vpslldq : IAsmInstruction<Vpslldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLDQ;

            public static implicit operator AsmMnemonicCode(Vpslldq src) => src.Mnemonic;
        }

        public readonly struct Psllw : IAsmInstruction<Psllw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLW;

            public static implicit operator AsmMnemonicCode(Psllw src) => src.Mnemonic;
        }

        public readonly struct Pslld : IAsmInstruction<Pslld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLD;

            public static implicit operator AsmMnemonicCode(Pslld src) => src.Mnemonic;
        }

        public readonly struct Psllq : IAsmInstruction<Psllq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSLLQ;

            public static implicit operator AsmMnemonicCode(Psllq src) => src.Mnemonic;
        }

        public readonly struct Vpsllw : IAsmInstruction<Vpsllw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLW;

            public static implicit operator AsmMnemonicCode(Vpsllw src) => src.Mnemonic;
        }

        public readonly struct Vpslld : IAsmInstruction<Vpslld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLD;

            public static implicit operator AsmMnemonicCode(Vpslld src) => src.Mnemonic;
        }

        public readonly struct Vpsllq : IAsmInstruction<Vpsllq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLQ;

            public static implicit operator AsmMnemonicCode(Vpsllq src) => src.Mnemonic;
        }

        public readonly struct Psraw : IAsmInstruction<Psraw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRAW;

            public static implicit operator AsmMnemonicCode(Psraw src) => src.Mnemonic;
        }

        public readonly struct Psrad : IAsmInstruction<Psrad>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRAD;

            public static implicit operator AsmMnemonicCode(Psrad src) => src.Mnemonic;
        }

        public readonly struct Vpsraw : IAsmInstruction<Vpsraw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRAW;

            public static implicit operator AsmMnemonicCode(Vpsraw src) => src.Mnemonic;
        }

        public readonly struct Vpsrad : IAsmInstruction<Vpsrad>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRAD;

            public static implicit operator AsmMnemonicCode(Vpsrad src) => src.Mnemonic;
        }

        public readonly struct Psrldq : IAsmInstruction<Psrldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLDQ;

            public static implicit operator AsmMnemonicCode(Psrldq src) => src.Mnemonic;
        }

        public readonly struct Vpsrldq : IAsmInstruction<Vpsrldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLDQ;

            public static implicit operator AsmMnemonicCode(Vpsrldq src) => src.Mnemonic;
        }

        public readonly struct Psrlw : IAsmInstruction<Psrlw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLW;

            public static implicit operator AsmMnemonicCode(Psrlw src) => src.Mnemonic;
        }

        public readonly struct Psrld : IAsmInstruction<Psrld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLD;

            public static implicit operator AsmMnemonicCode(Psrld src) => src.Mnemonic;
        }

        public readonly struct Psrlq : IAsmInstruction<Psrlq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSRLQ;

            public static implicit operator AsmMnemonicCode(Psrlq src) => src.Mnemonic;
        }

        public readonly struct Vpsrlw : IAsmInstruction<Vpsrlw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLW;

            public static implicit operator AsmMnemonicCode(Vpsrlw src) => src.Mnemonic;
        }

        public readonly struct Vpsrld : IAsmInstruction<Vpsrld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLD;

            public static implicit operator AsmMnemonicCode(Vpsrld src) => src.Mnemonic;
        }

        public readonly struct Vpsrlq : IAsmInstruction<Vpsrlq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLQ;

            public static implicit operator AsmMnemonicCode(Vpsrlq src) => src.Mnemonic;
        }

        public readonly struct Psubb : IAsmInstruction<Psubb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBB;

            public static implicit operator AsmMnemonicCode(Psubb src) => src.Mnemonic;
        }

        public readonly struct Psubw : IAsmInstruction<Psubw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBW;

            public static implicit operator AsmMnemonicCode(Psubw src) => src.Mnemonic;
        }

        public readonly struct Psubd : IAsmInstruction<Psubd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBD;

            public static implicit operator AsmMnemonicCode(Psubd src) => src.Mnemonic;
        }

        public readonly struct Vpsubb : IAsmInstruction<Vpsubb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBB;

            public static implicit operator AsmMnemonicCode(Vpsubb src) => src.Mnemonic;
        }

        public readonly struct Vpsubw : IAsmInstruction<Vpsubw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBW;

            public static implicit operator AsmMnemonicCode(Vpsubw src) => src.Mnemonic;
        }

        public readonly struct Vpsubd : IAsmInstruction<Vpsubd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBD;

            public static implicit operator AsmMnemonicCode(Vpsubd src) => src.Mnemonic;
        }

        public readonly struct Psubq : IAsmInstruction<Psubq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBQ;

            public static implicit operator AsmMnemonicCode(Psubq src) => src.Mnemonic;
        }

        public readonly struct Vpsubq : IAsmInstruction<Vpsubq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBQ;

            public static implicit operator AsmMnemonicCode(Vpsubq src) => src.Mnemonic;
        }

        public readonly struct Psubsb : IAsmInstruction<Psubsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBSB;

            public static implicit operator AsmMnemonicCode(Psubsb src) => src.Mnemonic;
        }

        public readonly struct Psubsw : IAsmInstruction<Psubsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBSW;

            public static implicit operator AsmMnemonicCode(Psubsw src) => src.Mnemonic;
        }

        public readonly struct Vpsubsb : IAsmInstruction<Vpsubsb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBSB;

            public static implicit operator AsmMnemonicCode(Vpsubsb src) => src.Mnemonic;
        }

        public readonly struct Vpsubsw : IAsmInstruction<Vpsubsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBSW;

            public static implicit operator AsmMnemonicCode(Vpsubsw src) => src.Mnemonic;
        }

        public readonly struct Psubusb : IAsmInstruction<Psubusb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBUSB;

            public static implicit operator AsmMnemonicCode(Psubusb src) => src.Mnemonic;
        }

        public readonly struct Psubusw : IAsmInstruction<Psubusw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PSUBUSW;

            public static implicit operator AsmMnemonicCode(Psubusw src) => src.Mnemonic;
        }

        public readonly struct Vpsubusb : IAsmInstruction<Vpsubusb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBUSB;

            public static implicit operator AsmMnemonicCode(Vpsubusb src) => src.Mnemonic;
        }

        public readonly struct Vpsubusw : IAsmInstruction<Vpsubusw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSUBUSW;

            public static implicit operator AsmMnemonicCode(Vpsubusw src) => src.Mnemonic;
        }

        public readonly struct Ptest : IAsmInstruction<Ptest>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PTEST;

            public static implicit operator AsmMnemonicCode(Ptest src) => src.Mnemonic;
        }

        public readonly struct Vptest : IAsmInstruction<Vptest>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPTEST;

            public static implicit operator AsmMnemonicCode(Vptest src) => src.Mnemonic;
        }

        public readonly struct Punpckhbw : IAsmInstruction<Punpckhbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHBW;

            public static implicit operator AsmMnemonicCode(Punpckhbw src) => src.Mnemonic;
        }

        public readonly struct Punpckhwd : IAsmInstruction<Punpckhwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHWD;

            public static implicit operator AsmMnemonicCode(Punpckhwd src) => src.Mnemonic;
        }

        public readonly struct Punpckhdq : IAsmInstruction<Punpckhdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHDQ;

            public static implicit operator AsmMnemonicCode(Punpckhdq src) => src.Mnemonic;
        }

        public readonly struct Punpckhqdq : IAsmInstruction<Punpckhqdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKHQDQ;

            public static implicit operator AsmMnemonicCode(Punpckhqdq src) => src.Mnemonic;
        }

        public readonly struct Vpunpckhbw : IAsmInstruction<Vpunpckhbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHBW;

            public static implicit operator AsmMnemonicCode(Vpunpckhbw src) => src.Mnemonic;
        }

        public readonly struct Vpunpckhwd : IAsmInstruction<Vpunpckhwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHWD;

            public static implicit operator AsmMnemonicCode(Vpunpckhwd src) => src.Mnemonic;
        }

        public readonly struct Vpunpckhdq : IAsmInstruction<Vpunpckhdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHDQ;

            public static implicit operator AsmMnemonicCode(Vpunpckhdq src) => src.Mnemonic;
        }

        public readonly struct Vpunpckhqdq : IAsmInstruction<Vpunpckhqdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKHQDQ;

            public static implicit operator AsmMnemonicCode(Vpunpckhqdq src) => src.Mnemonic;
        }

        public readonly struct Punpcklbw : IAsmInstruction<Punpcklbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLBW;

            public static implicit operator AsmMnemonicCode(Punpcklbw src) => src.Mnemonic;
        }

        public readonly struct Punpcklwd : IAsmInstruction<Punpcklwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLWD;

            public static implicit operator AsmMnemonicCode(Punpcklwd src) => src.Mnemonic;
        }

        public readonly struct Punpckldq : IAsmInstruction<Punpckldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLDQ;

            public static implicit operator AsmMnemonicCode(Punpckldq src) => src.Mnemonic;
        }

        public readonly struct Punpcklqdq : IAsmInstruction<Punpcklqdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUNPCKLQDQ;

            public static implicit operator AsmMnemonicCode(Punpcklqdq src) => src.Mnemonic;
        }

        public readonly struct Vpunpcklbw : IAsmInstruction<Vpunpcklbw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLBW;

            public static implicit operator AsmMnemonicCode(Vpunpcklbw src) => src.Mnemonic;
        }

        public readonly struct Vpunpcklwd : IAsmInstruction<Vpunpcklwd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLWD;

            public static implicit operator AsmMnemonicCode(Vpunpcklwd src) => src.Mnemonic;
        }

        public readonly struct Vpunpckldq : IAsmInstruction<Vpunpckldq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLDQ;

            public static implicit operator AsmMnemonicCode(Vpunpckldq src) => src.Mnemonic;
        }

        public readonly struct Vpunpcklqdq : IAsmInstruction<Vpunpcklqdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPUNPCKLQDQ;

            public static implicit operator AsmMnemonicCode(Vpunpcklqdq src) => src.Mnemonic;
        }

        public readonly struct Push : IAsmInstruction<Push>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSH;

            public static implicit operator AsmMnemonicCode(Push src) => src.Mnemonic;
        }

        public readonly struct Pushq : IAsmInstruction<Pushq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHQ;

            public static implicit operator AsmMnemonicCode(Pushq src) => src.Mnemonic;
        }

        public readonly struct Pushw : IAsmInstruction<Pushw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PUSHW;

            public static implicit operator AsmMnemonicCode(Pushw src) => src.Mnemonic;
        }

        public readonly struct Pxor : IAsmInstruction<Pxor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.PXOR;

            public static implicit operator AsmMnemonicCode(Pxor src) => src.Mnemonic;
        }

        public readonly struct Vpxor : IAsmInstruction<Vpxor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPXOR;

            public static implicit operator AsmMnemonicCode(Vpxor src) => src.Mnemonic;
        }

        public readonly struct Rcl : IAsmInstruction<Rcl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCL;

            public static implicit operator AsmMnemonicCode(Rcl src) => src.Mnemonic;
        }

        public readonly struct Rcr : IAsmInstruction<Rcr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCR;

            public static implicit operator AsmMnemonicCode(Rcr src) => src.Mnemonic;
        }

        public readonly struct Rol : IAsmInstruction<Rol>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROL;

            public static implicit operator AsmMnemonicCode(Rol src) => src.Mnemonic;
        }

        public readonly struct Ror : IAsmInstruction<Ror>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROR;

            public static implicit operator AsmMnemonicCode(Ror src) => src.Mnemonic;
        }

        public readonly struct Rcpps : IAsmInstruction<Rcpps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCPPS;

            public static implicit operator AsmMnemonicCode(Rcpps src) => src.Mnemonic;
        }

        public readonly struct Vrcpps : IAsmInstruction<Vrcpps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRCPPS;

            public static implicit operator AsmMnemonicCode(Vrcpps src) => src.Mnemonic;
        }

        public readonly struct Rcpss : IAsmInstruction<Rcpss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RCPSS;

            public static implicit operator AsmMnemonicCode(Rcpss src) => src.Mnemonic;
        }

        public readonly struct Vrcpss : IAsmInstruction<Vrcpss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRCPSS;

            public static implicit operator AsmMnemonicCode(Vrcpss src) => src.Mnemonic;
        }

        public readonly struct Rdfsbase : IAsmInstruction<Rdfsbase>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDFSBASE;

            public static implicit operator AsmMnemonicCode(Rdfsbase src) => src.Mnemonic;
        }

        public readonly struct Rdgsbase : IAsmInstruction<Rdgsbase>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDGSBASE;

            public static implicit operator AsmMnemonicCode(Rdgsbase src) => src.Mnemonic;
        }

        public readonly struct Rdrand : IAsmInstruction<Rdrand>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RDRAND;

            public static implicit operator AsmMnemonicCode(Rdrand src) => src.Mnemonic;
        }

        public readonly struct Rep_ins : IAsmInstruction<Rep_ins>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_INS;

            public static implicit operator AsmMnemonicCode(Rep_ins src) => src.Mnemonic;
        }

        public readonly struct Rep_movs : IAsmInstruction<Rep_movs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_MOVS;

            public static implicit operator AsmMnemonicCode(Rep_movs src) => src.Mnemonic;
        }

        public readonly struct Rep_outs : IAsmInstruction<Rep_outs>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_OUTS;

            public static implicit operator AsmMnemonicCode(Rep_outs src) => src.Mnemonic;
        }

        public readonly struct Rep_lods : IAsmInstruction<Rep_lods>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_LODS;

            public static implicit operator AsmMnemonicCode(Rep_lods src) => src.Mnemonic;
        }

        public readonly struct Rep_stos : IAsmInstruction<Rep_stos>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REP_STOS;

            public static implicit operator AsmMnemonicCode(Rep_stos src) => src.Mnemonic;
        }

        public readonly struct Repe_cmps : IAsmInstruction<Repe_cmps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPE_CMPS;

            public static implicit operator AsmMnemonicCode(Repe_cmps src) => src.Mnemonic;
        }

        public readonly struct Repe_scas : IAsmInstruction<Repe_scas>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPE_SCAS;

            public static implicit operator AsmMnemonicCode(Repe_scas src) => src.Mnemonic;
        }

        public readonly struct Repne_cmps : IAsmInstruction<Repne_cmps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPNE_CMPS;

            public static implicit operator AsmMnemonicCode(Repne_cmps src) => src.Mnemonic;
        }

        public readonly struct Repne_scas : IAsmInstruction<Repne_scas>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.REPNE_SCAS;

            public static implicit operator AsmMnemonicCode(Repne_scas src) => src.Mnemonic;
        }

        public readonly struct Ret : IAsmInstruction<Ret>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RET;

            public static implicit operator AsmMnemonicCode(Ret src) => src.Mnemonic;
        }

        public readonly struct Rorx : IAsmInstruction<Rorx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RORX;

            public static implicit operator AsmMnemonicCode(Rorx src) => src.Mnemonic;
        }

        public readonly struct Roundpd : IAsmInstruction<Roundpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDPD;

            public static implicit operator AsmMnemonicCode(Roundpd src) => src.Mnemonic;
        }

        public readonly struct Vroundpd : IAsmInstruction<Vroundpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDPD;

            public static implicit operator AsmMnemonicCode(Vroundpd src) => src.Mnemonic;
        }

        public readonly struct Roundps : IAsmInstruction<Roundps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDPS;

            public static implicit operator AsmMnemonicCode(Roundps src) => src.Mnemonic;
        }

        public readonly struct Vroundps : IAsmInstruction<Vroundps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDPS;

            public static implicit operator AsmMnemonicCode(Vroundps src) => src.Mnemonic;
        }

        public readonly struct Roundsd : IAsmInstruction<Roundsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDSD;

            public static implicit operator AsmMnemonicCode(Roundsd src) => src.Mnemonic;
        }

        public readonly struct Vroundsd : IAsmInstruction<Vroundsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDSD;

            public static implicit operator AsmMnemonicCode(Vroundsd src) => src.Mnemonic;
        }

        public readonly struct Roundss : IAsmInstruction<Roundss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.ROUNDSS;

            public static implicit operator AsmMnemonicCode(Roundss src) => src.Mnemonic;
        }

        public readonly struct Vroundss : IAsmInstruction<Vroundss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VROUNDSS;

            public static implicit operator AsmMnemonicCode(Vroundss src) => src.Mnemonic;
        }

        public readonly struct Rsqrtps : IAsmInstruction<Rsqrtps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RSQRTPS;

            public static implicit operator AsmMnemonicCode(Rsqrtps src) => src.Mnemonic;
        }

        public readonly struct Vrsqrtps : IAsmInstruction<Vrsqrtps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRSQRTPS;

            public static implicit operator AsmMnemonicCode(Vrsqrtps src) => src.Mnemonic;
        }

        public readonly struct Rsqrtss : IAsmInstruction<Rsqrtss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.RSQRTSS;

            public static implicit operator AsmMnemonicCode(Rsqrtss src) => src.Mnemonic;
        }

        public readonly struct Vrsqrtss : IAsmInstruction<Vrsqrtss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VRSQRTSS;

            public static implicit operator AsmMnemonicCode(Vrsqrtss src) => src.Mnemonic;
        }

        public readonly struct Sal : IAsmInstruction<Sal>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SAL;

            public static implicit operator AsmMnemonicCode(Sal src) => src.Mnemonic;
        }

        public readonly struct Sar : IAsmInstruction<Sar>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SAR;

            public static implicit operator AsmMnemonicCode(Sar src) => src.Mnemonic;
        }

        public readonly struct Shl : IAsmInstruction<Shl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHL;

            public static implicit operator AsmMnemonicCode(Shl src) => src.Mnemonic;
        }

        public readonly struct Shr : IAsmInstruction<Shr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHR;

            public static implicit operator AsmMnemonicCode(Shr src) => src.Mnemonic;
        }

        public readonly struct Sarx : IAsmInstruction<Sarx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SARX;

            public static implicit operator AsmMnemonicCode(Sarx src) => src.Mnemonic;
        }

        public readonly struct Shlx : IAsmInstruction<Shlx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHLX;

            public static implicit operator AsmMnemonicCode(Shlx src) => src.Mnemonic;
        }

        public readonly struct Shrx : IAsmInstruction<Shrx>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHRX;

            public static implicit operator AsmMnemonicCode(Shrx src) => src.Mnemonic;
        }

        public readonly struct Sbb : IAsmInstruction<Sbb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SBB;

            public static implicit operator AsmMnemonicCode(Sbb src) => src.Mnemonic;
        }

        public readonly struct Scas : IAsmInstruction<Scas>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SCAS;

            public static implicit operator AsmMnemonicCode(Scas src) => src.Mnemonic;
        }

        public readonly struct Seta : IAsmInstruction<Seta>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETA;

            public static implicit operator AsmMnemonicCode(Seta src) => src.Mnemonic;
        }

        public readonly struct Setae : IAsmInstruction<Setae>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETAE;

            public static implicit operator AsmMnemonicCode(Setae src) => src.Mnemonic;
        }

        public readonly struct Setb : IAsmInstruction<Setb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETB;

            public static implicit operator AsmMnemonicCode(Setb src) => src.Mnemonic;
        }

        public readonly struct Setbe : IAsmInstruction<Setbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETBE;

            public static implicit operator AsmMnemonicCode(Setbe src) => src.Mnemonic;
        }

        public readonly struct Setc : IAsmInstruction<Setc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETC;

            public static implicit operator AsmMnemonicCode(Setc src) => src.Mnemonic;
        }

        public readonly struct Sete : IAsmInstruction<Sete>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETE;

            public static implicit operator AsmMnemonicCode(Sete src) => src.Mnemonic;
        }

        public readonly struct Setg : IAsmInstruction<Setg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETG;

            public static implicit operator AsmMnemonicCode(Setg src) => src.Mnemonic;
        }

        public readonly struct Setge : IAsmInstruction<Setge>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETGE;

            public static implicit operator AsmMnemonicCode(Setge src) => src.Mnemonic;
        }

        public readonly struct Setl : IAsmInstruction<Setl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETL;

            public static implicit operator AsmMnemonicCode(Setl src) => src.Mnemonic;
        }

        public readonly struct Setle : IAsmInstruction<Setle>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETLE;

            public static implicit operator AsmMnemonicCode(Setle src) => src.Mnemonic;
        }

        public readonly struct Setna : IAsmInstruction<Setna>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNA;

            public static implicit operator AsmMnemonicCode(Setna src) => src.Mnemonic;
        }

        public readonly struct Setnae : IAsmInstruction<Setnae>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNAE;

            public static implicit operator AsmMnemonicCode(Setnae src) => src.Mnemonic;
        }

        public readonly struct Setnb : IAsmInstruction<Setnb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNB;

            public static implicit operator AsmMnemonicCode(Setnb src) => src.Mnemonic;
        }

        public readonly struct Setnbe : IAsmInstruction<Setnbe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNBE;

            public static implicit operator AsmMnemonicCode(Setnbe src) => src.Mnemonic;
        }

        public readonly struct Setnc : IAsmInstruction<Setnc>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNC;

            public static implicit operator AsmMnemonicCode(Setnc src) => src.Mnemonic;
        }

        public readonly struct Setne : IAsmInstruction<Setne>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNE;

            public static implicit operator AsmMnemonicCode(Setne src) => src.Mnemonic;
        }

        public readonly struct Setng : IAsmInstruction<Setng>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNG;

            public static implicit operator AsmMnemonicCode(Setng src) => src.Mnemonic;
        }

        public readonly struct Setnge : IAsmInstruction<Setnge>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNGE;

            public static implicit operator AsmMnemonicCode(Setnge src) => src.Mnemonic;
        }

        public readonly struct Setnl : IAsmInstruction<Setnl>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNL;

            public static implicit operator AsmMnemonicCode(Setnl src) => src.Mnemonic;
        }

        public readonly struct Setnle : IAsmInstruction<Setnle>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNLE;

            public static implicit operator AsmMnemonicCode(Setnle src) => src.Mnemonic;
        }

        public readonly struct Setno : IAsmInstruction<Setno>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNO;

            public static implicit operator AsmMnemonicCode(Setno src) => src.Mnemonic;
        }

        public readonly struct Setnp : IAsmInstruction<Setnp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNP;

            public static implicit operator AsmMnemonicCode(Setnp src) => src.Mnemonic;
        }

        public readonly struct Setns : IAsmInstruction<Setns>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNS;

            public static implicit operator AsmMnemonicCode(Setns src) => src.Mnemonic;
        }

        public readonly struct Setnz : IAsmInstruction<Setnz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETNZ;

            public static implicit operator AsmMnemonicCode(Setnz src) => src.Mnemonic;
        }

        public readonly struct Seto : IAsmInstruction<Seto>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETO;

            public static implicit operator AsmMnemonicCode(Seto src) => src.Mnemonic;
        }

        public readonly struct Setp : IAsmInstruction<Setp>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETP;

            public static implicit operator AsmMnemonicCode(Setp src) => src.Mnemonic;
        }

        public readonly struct Setpe : IAsmInstruction<Setpe>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETPE;

            public static implicit operator AsmMnemonicCode(Setpe src) => src.Mnemonic;
        }

        public readonly struct Setpo : IAsmInstruction<Setpo>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETPO;

            public static implicit operator AsmMnemonicCode(Setpo src) => src.Mnemonic;
        }

        public readonly struct Sets : IAsmInstruction<Sets>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETS;

            public static implicit operator AsmMnemonicCode(Sets src) => src.Mnemonic;
        }

        public readonly struct Setz : IAsmInstruction<Setz>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SETZ;

            public static implicit operator AsmMnemonicCode(Setz src) => src.Mnemonic;
        }

        public readonly struct Sgdt : IAsmInstruction<Sgdt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SGDT;

            public static implicit operator AsmMnemonicCode(Sgdt src) => src.Mnemonic;
        }

        public readonly struct Shld : IAsmInstruction<Shld>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHLD;

            public static implicit operator AsmMnemonicCode(Shld src) => src.Mnemonic;
        }

        public readonly struct Shrd : IAsmInstruction<Shrd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHRD;

            public static implicit operator AsmMnemonicCode(Shrd src) => src.Mnemonic;
        }

        public readonly struct Shufpd : IAsmInstruction<Shufpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHUFPD;

            public static implicit operator AsmMnemonicCode(Shufpd src) => src.Mnemonic;
        }

        public readonly struct Vshufpd : IAsmInstruction<Vshufpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSHUFPD;

            public static implicit operator AsmMnemonicCode(Vshufpd src) => src.Mnemonic;
        }

        public readonly struct Shufps : IAsmInstruction<Shufps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SHUFPS;

            public static implicit operator AsmMnemonicCode(Shufps src) => src.Mnemonic;
        }

        public readonly struct Vshufps : IAsmInstruction<Vshufps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSHUFPS;

            public static implicit operator AsmMnemonicCode(Vshufps src) => src.Mnemonic;
        }

        public readonly struct Sidt : IAsmInstruction<Sidt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SIDT;

            public static implicit operator AsmMnemonicCode(Sidt src) => src.Mnemonic;
        }

        public readonly struct Sldt : IAsmInstruction<Sldt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SLDT;

            public static implicit operator AsmMnemonicCode(Sldt src) => src.Mnemonic;
        }

        public readonly struct Smsw : IAsmInstruction<Smsw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SMSW;

            public static implicit operator AsmMnemonicCode(Smsw src) => src.Mnemonic;
        }

        public readonly struct Sqrtpd : IAsmInstruction<Sqrtpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTPD;

            public static implicit operator AsmMnemonicCode(Sqrtpd src) => src.Mnemonic;
        }

        public readonly struct Vsqrtpd : IAsmInstruction<Vsqrtpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTPD;

            public static implicit operator AsmMnemonicCode(Vsqrtpd src) => src.Mnemonic;
        }

        public readonly struct Sqrtps : IAsmInstruction<Sqrtps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTPS;

            public static implicit operator AsmMnemonicCode(Sqrtps src) => src.Mnemonic;
        }

        public readonly struct Vsqrtps : IAsmInstruction<Vsqrtps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTPS;

            public static implicit operator AsmMnemonicCode(Vsqrtps src) => src.Mnemonic;
        }

        public readonly struct Sqrtsd : IAsmInstruction<Sqrtsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTSD;

            public static implicit operator AsmMnemonicCode(Sqrtsd src) => src.Mnemonic;
        }

        public readonly struct Vsqrtsd : IAsmInstruction<Vsqrtsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTSD;

            public static implicit operator AsmMnemonicCode(Vsqrtsd src) => src.Mnemonic;
        }

        public readonly struct Sqrtss : IAsmInstruction<Sqrtss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SQRTSS;

            public static implicit operator AsmMnemonicCode(Sqrtss src) => src.Mnemonic;
        }

        public readonly struct Vsqrtss : IAsmInstruction<Vsqrtss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSQRTSS;

            public static implicit operator AsmMnemonicCode(Vsqrtss src) => src.Mnemonic;
        }

        public readonly struct Stmxcsr : IAsmInstruction<Stmxcsr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STMXCSR;

            public static implicit operator AsmMnemonicCode(Stmxcsr src) => src.Mnemonic;
        }

        public readonly struct Vstmxcsr : IAsmInstruction<Vstmxcsr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSTMXCSR;

            public static implicit operator AsmMnemonicCode(Vstmxcsr src) => src.Mnemonic;
        }

        public readonly struct Stos : IAsmInstruction<Stos>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STOS;

            public static implicit operator AsmMnemonicCode(Stos src) => src.Mnemonic;
        }

        public readonly struct Str : IAsmInstruction<Str>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.STR;

            public static implicit operator AsmMnemonicCode(Str src) => src.Mnemonic;
        }

        public readonly struct Sub : IAsmInstruction<Sub>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUB;

            public static implicit operator AsmMnemonicCode(Sub src) => src.Mnemonic;
        }

        public readonly struct Subpd : IAsmInstruction<Subpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBPD;

            public static implicit operator AsmMnemonicCode(Subpd src) => src.Mnemonic;
        }

        public readonly struct Vsubpd : IAsmInstruction<Vsubpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBPD;

            public static implicit operator AsmMnemonicCode(Vsubpd src) => src.Mnemonic;
        }

        public readonly struct Subps : IAsmInstruction<Subps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBPS;

            public static implicit operator AsmMnemonicCode(Subps src) => src.Mnemonic;
        }

        public readonly struct Vsubps : IAsmInstruction<Vsubps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBPS;

            public static implicit operator AsmMnemonicCode(Vsubps src) => src.Mnemonic;
        }

        public readonly struct Subsd : IAsmInstruction<Subsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBSD;

            public static implicit operator AsmMnemonicCode(Subsd src) => src.Mnemonic;
        }

        public readonly struct Vsubsd : IAsmInstruction<Vsubsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBSD;

            public static implicit operator AsmMnemonicCode(Vsubsd src) => src.Mnemonic;
        }

        public readonly struct Subss : IAsmInstruction<Subss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SUBSS;

            public static implicit operator AsmMnemonicCode(Subss src) => src.Mnemonic;
        }

        public readonly struct Vsubss : IAsmInstruction<Vsubss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VSUBSS;

            public static implicit operator AsmMnemonicCode(Vsubss src) => src.Mnemonic;
        }

        public readonly struct Sysexit : IAsmInstruction<Sysexit>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SYSEXIT;

            public static implicit operator AsmMnemonicCode(Sysexit src) => src.Mnemonic;
        }

        public readonly struct Sysret : IAsmInstruction<Sysret>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.SYSRET;

            public static implicit operator AsmMnemonicCode(Sysret src) => src.Mnemonic;
        }

        public readonly struct Test : IAsmInstruction<Test>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.TEST;

            public static implicit operator AsmMnemonicCode(Test src) => src.Mnemonic;
        }

        public readonly struct Tzcnt : IAsmInstruction<Tzcnt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.TZCNT;

            public static implicit operator AsmMnemonicCode(Tzcnt src) => src.Mnemonic;
        }

        public readonly struct Ucomisd : IAsmInstruction<Ucomisd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UCOMISD;

            public static implicit operator AsmMnemonicCode(Ucomisd src) => src.Mnemonic;
        }

        public readonly struct Vucomisd : IAsmInstruction<Vucomisd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUCOMISD;

            public static implicit operator AsmMnemonicCode(Vucomisd src) => src.Mnemonic;
        }

        public readonly struct Ucomiss : IAsmInstruction<Ucomiss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UCOMISS;

            public static implicit operator AsmMnemonicCode(Ucomiss src) => src.Mnemonic;
        }

        public readonly struct Vucomiss : IAsmInstruction<Vucomiss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUCOMISS;

            public static implicit operator AsmMnemonicCode(Vucomiss src) => src.Mnemonic;
        }

        public readonly struct Unpckhpd : IAsmInstruction<Unpckhpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKHPD;

            public static implicit operator AsmMnemonicCode(Unpckhpd src) => src.Mnemonic;
        }

        public readonly struct Vunpckhpd : IAsmInstruction<Vunpckhpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKHPD;

            public static implicit operator AsmMnemonicCode(Vunpckhpd src) => src.Mnemonic;
        }

        public readonly struct Unpckhps : IAsmInstruction<Unpckhps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKHPS;

            public static implicit operator AsmMnemonicCode(Unpckhps src) => src.Mnemonic;
        }

        public readonly struct Vunpckhps : IAsmInstruction<Vunpckhps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKHPS;

            public static implicit operator AsmMnemonicCode(Vunpckhps src) => src.Mnemonic;
        }

        public readonly struct Unpcklpd : IAsmInstruction<Unpcklpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKLPD;

            public static implicit operator AsmMnemonicCode(Unpcklpd src) => src.Mnemonic;
        }

        public readonly struct Vunpcklpd : IAsmInstruction<Vunpcklpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKLPD;

            public static implicit operator AsmMnemonicCode(Vunpcklpd src) => src.Mnemonic;
        }

        public readonly struct Unpcklps : IAsmInstruction<Unpcklps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.UNPCKLPS;

            public static implicit operator AsmMnemonicCode(Unpcklps src) => src.Mnemonic;
        }

        public readonly struct Vunpcklps : IAsmInstruction<Vunpcklps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VUNPCKLPS;

            public static implicit operator AsmMnemonicCode(Vunpcklps src) => src.Mnemonic;
        }

        public readonly struct Vbroadcastss : IAsmInstruction<Vbroadcastss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTSS;

            public static implicit operator AsmMnemonicCode(Vbroadcastss src) => src.Mnemonic;
        }

        public readonly struct Vbroadcastsd : IAsmInstruction<Vbroadcastsd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTSD;

            public static implicit operator AsmMnemonicCode(Vbroadcastsd src) => src.Mnemonic;
        }

        public readonly struct Vbroadcastf128 : IAsmInstruction<Vbroadcastf128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTF128;

            public static implicit operator AsmMnemonicCode(Vbroadcastf128 src) => src.Mnemonic;
        }

        public readonly struct Vcvtph2ps : IAsmInstruction<Vcvtph2ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPH2PS;

            public static implicit operator AsmMnemonicCode(Vcvtph2ps src) => src.Mnemonic;
        }

        public readonly struct Vcvtps2ph : IAsmInstruction<Vcvtps2ph>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VCVTPS2PH;

            public static implicit operator AsmMnemonicCode(Vcvtps2ph src) => src.Mnemonic;
        }

        public readonly struct Verr : IAsmInstruction<Verr>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VERR;

            public static implicit operator AsmMnemonicCode(Verr src) => src.Mnemonic;
        }

        public readonly struct Verw : IAsmInstruction<Verw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VERW;

            public static implicit operator AsmMnemonicCode(Verw src) => src.Mnemonic;
        }

        public readonly struct Vextractf128 : IAsmInstruction<Vextractf128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VEXTRACTF128;

            public static implicit operator AsmMnemonicCode(Vextractf128 src) => src.Mnemonic;
        }

        public readonly struct Vextracti128 : IAsmInstruction<Vextracti128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VEXTRACTI128;

            public static implicit operator AsmMnemonicCode(Vextracti128 src) => src.Mnemonic;
        }

        public readonly struct Vfmadd132pd : IAsmInstruction<Vfmadd132pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132PD;

            public static implicit operator AsmMnemonicCode(Vfmadd132pd src) => src.Mnemonic;
        }

        public readonly struct Vfmadd213pd : IAsmInstruction<Vfmadd213pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213PD;

            public static implicit operator AsmMnemonicCode(Vfmadd213pd src) => src.Mnemonic;
        }

        public readonly struct Vfmadd231pd : IAsmInstruction<Vfmadd231pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231PD;

            public static implicit operator AsmMnemonicCode(Vfmadd231pd src) => src.Mnemonic;
        }

        public readonly struct Vfmadd132ps : IAsmInstruction<Vfmadd132ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132PS;

            public static implicit operator AsmMnemonicCode(Vfmadd132ps src) => src.Mnemonic;
        }

        public readonly struct Vfmadd213ps : IAsmInstruction<Vfmadd213ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213PS;

            public static implicit operator AsmMnemonicCode(Vfmadd213ps src) => src.Mnemonic;
        }

        public readonly struct Vfmadd231ps : IAsmInstruction<Vfmadd231ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231PS;

            public static implicit operator AsmMnemonicCode(Vfmadd231ps src) => src.Mnemonic;
        }

        public readonly struct Vfmadd132sd : IAsmInstruction<Vfmadd132sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132SD;

            public static implicit operator AsmMnemonicCode(Vfmadd132sd src) => src.Mnemonic;
        }

        public readonly struct Vfmadd213sd : IAsmInstruction<Vfmadd213sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213SD;

            public static implicit operator AsmMnemonicCode(Vfmadd213sd src) => src.Mnemonic;
        }

        public readonly struct Vfmadd231sd : IAsmInstruction<Vfmadd231sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231SD;

            public static implicit operator AsmMnemonicCode(Vfmadd231sd src) => src.Mnemonic;
        }

        public readonly struct Vfmadd132ss : IAsmInstruction<Vfmadd132ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD132SS;

            public static implicit operator AsmMnemonicCode(Vfmadd132ss src) => src.Mnemonic;
        }

        public readonly struct Vfmadd213ss : IAsmInstruction<Vfmadd213ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD213SS;

            public static implicit operator AsmMnemonicCode(Vfmadd213ss src) => src.Mnemonic;
        }

        public readonly struct Vfmadd231ss : IAsmInstruction<Vfmadd231ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADD231SS;

            public static implicit operator AsmMnemonicCode(Vfmadd231ss src) => src.Mnemonic;
        }

        public readonly struct Vfmaddsub132pd : IAsmInstruction<Vfmaddsub132pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB132PD;

            public static implicit operator AsmMnemonicCode(Vfmaddsub132pd src) => src.Mnemonic;
        }

        public readonly struct Vfmaddsub213pd : IAsmInstruction<Vfmaddsub213pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB213PD;

            public static implicit operator AsmMnemonicCode(Vfmaddsub213pd src) => src.Mnemonic;
        }

        public readonly struct Vfmaddsub231pd : IAsmInstruction<Vfmaddsub231pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB231PD;

            public static implicit operator AsmMnemonicCode(Vfmaddsub231pd src) => src.Mnemonic;
        }

        public readonly struct Vfmaddsub132ps : IAsmInstruction<Vfmaddsub132ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB132PS;

            public static implicit operator AsmMnemonicCode(Vfmaddsub132ps src) => src.Mnemonic;
        }

        public readonly struct Vfmaddsub213ps : IAsmInstruction<Vfmaddsub213ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB213PS;

            public static implicit operator AsmMnemonicCode(Vfmaddsub213ps src) => src.Mnemonic;
        }

        public readonly struct Vfmaddsub231ps : IAsmInstruction<Vfmaddsub231ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMADDSUB231PS;

            public static implicit operator AsmMnemonicCode(Vfmaddsub231ps src) => src.Mnemonic;
        }

        public readonly struct Vfmsubadd132pd : IAsmInstruction<Vfmsubadd132pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD132PD;

            public static implicit operator AsmMnemonicCode(Vfmsubadd132pd src) => src.Mnemonic;
        }

        public readonly struct Vfmsubadd213pd : IAsmInstruction<Vfmsubadd213pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD213PD;

            public static implicit operator AsmMnemonicCode(Vfmsubadd213pd src) => src.Mnemonic;
        }

        public readonly struct Vfmsubadd231pd : IAsmInstruction<Vfmsubadd231pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD231PD;

            public static implicit operator AsmMnemonicCode(Vfmsubadd231pd src) => src.Mnemonic;
        }

        public readonly struct Vfmsubadd132ps : IAsmInstruction<Vfmsubadd132ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD132PS;

            public static implicit operator AsmMnemonicCode(Vfmsubadd132ps src) => src.Mnemonic;
        }

        public readonly struct Vfmsubadd213ps : IAsmInstruction<Vfmsubadd213ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD213PS;

            public static implicit operator AsmMnemonicCode(Vfmsubadd213ps src) => src.Mnemonic;
        }

        public readonly struct Vfmsubadd231ps : IAsmInstruction<Vfmsubadd231ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUBADD231PS;

            public static implicit operator AsmMnemonicCode(Vfmsubadd231ps src) => src.Mnemonic;
        }

        public readonly struct Vfmsub132pd : IAsmInstruction<Vfmsub132pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132PD;

            public static implicit operator AsmMnemonicCode(Vfmsub132pd src) => src.Mnemonic;
        }

        public readonly struct Vfmsub213pd : IAsmInstruction<Vfmsub213pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213PD;

            public static implicit operator AsmMnemonicCode(Vfmsub213pd src) => src.Mnemonic;
        }

        public readonly struct Vfmsub231pd : IAsmInstruction<Vfmsub231pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231PD;

            public static implicit operator AsmMnemonicCode(Vfmsub231pd src) => src.Mnemonic;
        }

        public readonly struct Vfmsub132ps : IAsmInstruction<Vfmsub132ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132PS;

            public static implicit operator AsmMnemonicCode(Vfmsub132ps src) => src.Mnemonic;
        }

        public readonly struct Vfmsub213ps : IAsmInstruction<Vfmsub213ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213PS;

            public static implicit operator AsmMnemonicCode(Vfmsub213ps src) => src.Mnemonic;
        }

        public readonly struct Vfmsub231ps : IAsmInstruction<Vfmsub231ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231PS;

            public static implicit operator AsmMnemonicCode(Vfmsub231ps src) => src.Mnemonic;
        }

        public readonly struct Vfmsub132sd : IAsmInstruction<Vfmsub132sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132SD;

            public static implicit operator AsmMnemonicCode(Vfmsub132sd src) => src.Mnemonic;
        }

        public readonly struct Vfmsub213sd : IAsmInstruction<Vfmsub213sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213SD;

            public static implicit operator AsmMnemonicCode(Vfmsub213sd src) => src.Mnemonic;
        }

        public readonly struct Vfmsub231sd : IAsmInstruction<Vfmsub231sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231SD;

            public static implicit operator AsmMnemonicCode(Vfmsub231sd src) => src.Mnemonic;
        }

        public readonly struct Vfmsub132ss : IAsmInstruction<Vfmsub132ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB132SS;

            public static implicit operator AsmMnemonicCode(Vfmsub132ss src) => src.Mnemonic;
        }

        public readonly struct Vfmsub213ss : IAsmInstruction<Vfmsub213ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB213SS;

            public static implicit operator AsmMnemonicCode(Vfmsub213ss src) => src.Mnemonic;
        }

        public readonly struct Vfmsub231ss : IAsmInstruction<Vfmsub231ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFMSUB231SS;

            public static implicit operator AsmMnemonicCode(Vfmsub231ss src) => src.Mnemonic;
        }

        public readonly struct Vfnmadd132pd : IAsmInstruction<Vfnmadd132pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132PD;

            public static implicit operator AsmMnemonicCode(Vfnmadd132pd src) => src.Mnemonic;
        }

        public readonly struct Vfnmadd213pd : IAsmInstruction<Vfnmadd213pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213PD;

            public static implicit operator AsmMnemonicCode(Vfnmadd213pd src) => src.Mnemonic;
        }

        public readonly struct Vfnmadd231pd : IAsmInstruction<Vfnmadd231pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231PD;

            public static implicit operator AsmMnemonicCode(Vfnmadd231pd src) => src.Mnemonic;
        }

        public readonly struct Vfnmadd132ps : IAsmInstruction<Vfnmadd132ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132PS;

            public static implicit operator AsmMnemonicCode(Vfnmadd132ps src) => src.Mnemonic;
        }

        public readonly struct Vfnmadd213ps : IAsmInstruction<Vfnmadd213ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213PS;

            public static implicit operator AsmMnemonicCode(Vfnmadd213ps src) => src.Mnemonic;
        }

        public readonly struct Vfnmadd231ps : IAsmInstruction<Vfnmadd231ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231PS;

            public static implicit operator AsmMnemonicCode(Vfnmadd231ps src) => src.Mnemonic;
        }

        public readonly struct Vfnmadd132sd : IAsmInstruction<Vfnmadd132sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132SD;

            public static implicit operator AsmMnemonicCode(Vfnmadd132sd src) => src.Mnemonic;
        }

        public readonly struct Vfnmadd213sd : IAsmInstruction<Vfnmadd213sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213SD;

            public static implicit operator AsmMnemonicCode(Vfnmadd213sd src) => src.Mnemonic;
        }

        public readonly struct Vfnmadd231sd : IAsmInstruction<Vfnmadd231sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231SD;

            public static implicit operator AsmMnemonicCode(Vfnmadd231sd src) => src.Mnemonic;
        }

        public readonly struct Vfnmadd132ss : IAsmInstruction<Vfnmadd132ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD132SS;

            public static implicit operator AsmMnemonicCode(Vfnmadd132ss src) => src.Mnemonic;
        }

        public readonly struct Vfnmadd213ss : IAsmInstruction<Vfnmadd213ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD213SS;

            public static implicit operator AsmMnemonicCode(Vfnmadd213ss src) => src.Mnemonic;
        }

        public readonly struct Vfnmadd231ss : IAsmInstruction<Vfnmadd231ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMADD231SS;

            public static implicit operator AsmMnemonicCode(Vfnmadd231ss src) => src.Mnemonic;
        }

        public readonly struct Vfnmsub132pd : IAsmInstruction<Vfnmsub132pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132PD;

            public static implicit operator AsmMnemonicCode(Vfnmsub132pd src) => src.Mnemonic;
        }

        public readonly struct Vfnmsub213pd : IAsmInstruction<Vfnmsub213pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213PD;

            public static implicit operator AsmMnemonicCode(Vfnmsub213pd src) => src.Mnemonic;
        }

        public readonly struct Vfnmsub231pd : IAsmInstruction<Vfnmsub231pd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231PD;

            public static implicit operator AsmMnemonicCode(Vfnmsub231pd src) => src.Mnemonic;
        }

        public readonly struct Vfnmsub132ps : IAsmInstruction<Vfnmsub132ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132PS;

            public static implicit operator AsmMnemonicCode(Vfnmsub132ps src) => src.Mnemonic;
        }

        public readonly struct Vfnmsub213ps : IAsmInstruction<Vfnmsub213ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213PS;

            public static implicit operator AsmMnemonicCode(Vfnmsub213ps src) => src.Mnemonic;
        }

        public readonly struct Vfnmsub231ps : IAsmInstruction<Vfnmsub231ps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231PS;

            public static implicit operator AsmMnemonicCode(Vfnmsub231ps src) => src.Mnemonic;
        }

        public readonly struct Vfnmsub132sd : IAsmInstruction<Vfnmsub132sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132SD;

            public static implicit operator AsmMnemonicCode(Vfnmsub132sd src) => src.Mnemonic;
        }

        public readonly struct Vfnmsub213sd : IAsmInstruction<Vfnmsub213sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213SD;

            public static implicit operator AsmMnemonicCode(Vfnmsub213sd src) => src.Mnemonic;
        }

        public readonly struct Vfnmsub231sd : IAsmInstruction<Vfnmsub231sd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231SD;

            public static implicit operator AsmMnemonicCode(Vfnmsub231sd src) => src.Mnemonic;
        }

        public readonly struct Vfnmsub132ss : IAsmInstruction<Vfnmsub132ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB132SS;

            public static implicit operator AsmMnemonicCode(Vfnmsub132ss src) => src.Mnemonic;
        }

        public readonly struct Vfnmsub213ss : IAsmInstruction<Vfnmsub213ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB213SS;

            public static implicit operator AsmMnemonicCode(Vfnmsub213ss src) => src.Mnemonic;
        }

        public readonly struct Vfnmsub231ss : IAsmInstruction<Vfnmsub231ss>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VFNMSUB231SS;

            public static implicit operator AsmMnemonicCode(Vfnmsub231ss src) => src.Mnemonic;
        }

        public readonly struct Vgatherdpd : IAsmInstruction<Vgatherdpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERDPD;

            public static implicit operator AsmMnemonicCode(Vgatherdpd src) => src.Mnemonic;
        }

        public readonly struct Vgatherqpd : IAsmInstruction<Vgatherqpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERQPD;

            public static implicit operator AsmMnemonicCode(Vgatherqpd src) => src.Mnemonic;
        }

        public readonly struct Vgatherdps : IAsmInstruction<Vgatherdps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERDPS;

            public static implicit operator AsmMnemonicCode(Vgatherdps src) => src.Mnemonic;
        }

        public readonly struct Vgatherqps : IAsmInstruction<Vgatherqps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VGATHERQPS;

            public static implicit operator AsmMnemonicCode(Vgatherqps src) => src.Mnemonic;
        }

        public readonly struct Vpgatherdd : IAsmInstruction<Vpgatherdd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERDD;

            public static implicit operator AsmMnemonicCode(Vpgatherdd src) => src.Mnemonic;
        }

        public readonly struct Vpgatherqd : IAsmInstruction<Vpgatherqd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERQD;

            public static implicit operator AsmMnemonicCode(Vpgatherqd src) => src.Mnemonic;
        }

        public readonly struct Vpgatherdq : IAsmInstruction<Vpgatherdq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERDQ;

            public static implicit operator AsmMnemonicCode(Vpgatherdq src) => src.Mnemonic;
        }

        public readonly struct Vpgatherqq : IAsmInstruction<Vpgatherqq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPGATHERQQ;

            public static implicit operator AsmMnemonicCode(Vpgatherqq src) => src.Mnemonic;
        }

        public readonly struct Vinsertf128 : IAsmInstruction<Vinsertf128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VINSERTF128;

            public static implicit operator AsmMnemonicCode(Vinsertf128 src) => src.Mnemonic;
        }

        public readonly struct Vinserti128 : IAsmInstruction<Vinserti128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VINSERTI128;

            public static implicit operator AsmMnemonicCode(Vinserti128 src) => src.Mnemonic;
        }

        public readonly struct Vmaskmovps : IAsmInstruction<Vmaskmovps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMASKMOVPS;

            public static implicit operator AsmMnemonicCode(Vmaskmovps src) => src.Mnemonic;
        }

        public readonly struct Vmaskmovpd : IAsmInstruction<Vmaskmovpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VMASKMOVPD;

            public static implicit operator AsmMnemonicCode(Vmaskmovpd src) => src.Mnemonic;
        }

        public readonly struct Vpblendd : IAsmInstruction<Vpblendd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBLENDD;

            public static implicit operator AsmMnemonicCode(Vpblendd src) => src.Mnemonic;
        }

        public readonly struct Vpbroadcastb : IAsmInstruction<Vpbroadcastb>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTB;

            public static implicit operator AsmMnemonicCode(Vpbroadcastb src) => src.Mnemonic;
        }

        public readonly struct Vpbroadcastw : IAsmInstruction<Vpbroadcastw>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTW;

            public static implicit operator AsmMnemonicCode(Vpbroadcastw src) => src.Mnemonic;
        }

        public readonly struct Vpbroadcastd : IAsmInstruction<Vpbroadcastd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTD;

            public static implicit operator AsmMnemonicCode(Vpbroadcastd src) => src.Mnemonic;
        }

        public readonly struct Vpbroadcastq : IAsmInstruction<Vpbroadcastq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPBROADCASTQ;

            public static implicit operator AsmMnemonicCode(Vpbroadcastq src) => src.Mnemonic;
        }

        public readonly struct Vbroadcasti128 : IAsmInstruction<Vbroadcasti128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VBROADCASTI128;

            public static implicit operator AsmMnemonicCode(Vbroadcasti128 src) => src.Mnemonic;
        }

        public readonly struct Vpermd : IAsmInstruction<Vpermd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMD;

            public static implicit operator AsmMnemonicCode(Vpermd src) => src.Mnemonic;
        }

        public readonly struct Vpermpd : IAsmInstruction<Vpermpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMPD;

            public static implicit operator AsmMnemonicCode(Vpermpd src) => src.Mnemonic;
        }

        public readonly struct Vpermps : IAsmInstruction<Vpermps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMPS;

            public static implicit operator AsmMnemonicCode(Vpermps src) => src.Mnemonic;
        }

        public readonly struct Vpermq : IAsmInstruction<Vpermq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMQ;

            public static implicit operator AsmMnemonicCode(Vpermq src) => src.Mnemonic;
        }

        public readonly struct Vperm2i128 : IAsmInstruction<Vperm2i128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERM2I128;

            public static implicit operator AsmMnemonicCode(Vperm2i128 src) => src.Mnemonic;
        }

        public readonly struct Vpermilpd : IAsmInstruction<Vpermilpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMILPD;

            public static implicit operator AsmMnemonicCode(Vpermilpd src) => src.Mnemonic;
        }

        public readonly struct Vpermilps : IAsmInstruction<Vpermilps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERMILPS;

            public static implicit operator AsmMnemonicCode(Vpermilps src) => src.Mnemonic;
        }

        public readonly struct Vperm2f128 : IAsmInstruction<Vperm2f128>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPERM2F128;

            public static implicit operator AsmMnemonicCode(Vperm2f128 src) => src.Mnemonic;
        }

        public readonly struct Vpmaskmovd : IAsmInstruction<Vpmaskmovd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMASKMOVD;

            public static implicit operator AsmMnemonicCode(Vpmaskmovd src) => src.Mnemonic;
        }

        public readonly struct Vpmaskmovq : IAsmInstruction<Vpmaskmovq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPMASKMOVQ;

            public static implicit operator AsmMnemonicCode(Vpmaskmovq src) => src.Mnemonic;
        }

        public readonly struct Vpsllvd : IAsmInstruction<Vpsllvd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLVD;

            public static implicit operator AsmMnemonicCode(Vpsllvd src) => src.Mnemonic;
        }

        public readonly struct Vpsllvq : IAsmInstruction<Vpsllvq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSLLVQ;

            public static implicit operator AsmMnemonicCode(Vpsllvq src) => src.Mnemonic;
        }

        public readonly struct Vpsravd : IAsmInstruction<Vpsravd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRAVD;

            public static implicit operator AsmMnemonicCode(Vpsravd src) => src.Mnemonic;
        }

        public readonly struct Vpsrlvd : IAsmInstruction<Vpsrlvd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLVD;

            public static implicit operator AsmMnemonicCode(Vpsrlvd src) => src.Mnemonic;
        }

        public readonly struct Vpsrlvq : IAsmInstruction<Vpsrlvq>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VPSRLVQ;

            public static implicit operator AsmMnemonicCode(Vpsrlvq src) => src.Mnemonic;
        }

        public readonly struct Vtestps : IAsmInstruction<Vtestps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VTESTPS;

            public static implicit operator AsmMnemonicCode(Vtestps src) => src.Mnemonic;
        }

        public readonly struct Vtestpd : IAsmInstruction<Vtestpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VTESTPD;

            public static implicit operator AsmMnemonicCode(Vtestpd src) => src.Mnemonic;
        }

        public readonly struct Wrfsbase : IAsmInstruction<Wrfsbase>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WRFSBASE;

            public static implicit operator AsmMnemonicCode(Wrfsbase src) => src.Mnemonic;
        }

        public readonly struct Wrgsbase : IAsmInstruction<Wrgsbase>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.WRGSBASE;

            public static implicit operator AsmMnemonicCode(Wrgsbase src) => src.Mnemonic;
        }

        public readonly struct Xabort : IAsmInstruction<Xabort>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XABORT;

            public static implicit operator AsmMnemonicCode(Xabort src) => src.Mnemonic;
        }

        public readonly struct Xadd : IAsmInstruction<Xadd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XADD;

            public static implicit operator AsmMnemonicCode(Xadd src) => src.Mnemonic;
        }

        public readonly struct Xbegin : IAsmInstruction<Xbegin>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XBEGIN;

            public static implicit operator AsmMnemonicCode(Xbegin src) => src.Mnemonic;
        }

        public readonly struct Xchg : IAsmInstruction<Xchg>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XCHG;

            public static implicit operator AsmMnemonicCode(Xchg src) => src.Mnemonic;
        }

        public readonly struct Xlat : IAsmInstruction<Xlat>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XLAT;

            public static implicit operator AsmMnemonicCode(Xlat src) => src.Mnemonic;
        }

        public readonly struct Xor : IAsmInstruction<Xor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XOR;

            public static implicit operator AsmMnemonicCode(Xor src) => src.Mnemonic;
        }

        public readonly struct Xorpd : IAsmInstruction<Xorpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XORPD;

            public static implicit operator AsmMnemonicCode(Xorpd src) => src.Mnemonic;
        }

        public readonly struct Vxorpd : IAsmInstruction<Vxorpd>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VXORPD;

            public static implicit operator AsmMnemonicCode(Vxorpd src) => src.Mnemonic;
        }

        public readonly struct Xorps : IAsmInstruction<Xorps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XORPS;

            public static implicit operator AsmMnemonicCode(Xorps src) => src.Mnemonic;
        }

        public readonly struct Vxorps : IAsmInstruction<Vxorps>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.VXORPS;

            public static implicit operator AsmMnemonicCode(Vxorps src) => src.Mnemonic;
        }

        public readonly struct Xrstor : IAsmInstruction<Xrstor>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XRSTOR;

            public static implicit operator AsmMnemonicCode(Xrstor src) => src.Mnemonic;
        }

        public readonly struct Xrstor64 : IAsmInstruction<Xrstor64>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XRSTOR64;

            public static implicit operator AsmMnemonicCode(Xrstor64 src) => src.Mnemonic;
        }

        public readonly struct Xsave : IAsmInstruction<Xsave>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVE;

            public static implicit operator AsmMnemonicCode(Xsave src) => src.Mnemonic;
        }

        public readonly struct Xsave64 : IAsmInstruction<Xsave64>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVE64;

            public static implicit operator AsmMnemonicCode(Xsave64 src) => src.Mnemonic;
        }

        public readonly struct Xsaveopt : IAsmInstruction<Xsaveopt>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVEOPT;

            public static implicit operator AsmMnemonicCode(Xsaveopt src) => src.Mnemonic;
        }

        public readonly struct Xsaveopt64 : IAsmInstruction<Xsaveopt64>
        {
            public AsmMnemonicCode Mnemonic => AsmMnemonicCode.XSAVEOPT64;

            public static implicit operator AsmMnemonicCode(Xsaveopt64 src) => src.Mnemonic;
        }

    }
}
