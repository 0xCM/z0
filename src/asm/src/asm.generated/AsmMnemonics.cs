//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct AsmMnemonics
    {
        public static AsmMnemonicExpr AAD => nameof(AAD);

        public static AsmMnemonicExpr AAM => nameof(AAM);

        public static AsmMnemonicExpr ADC => nameof(ADC);

        public static AsmMnemonicExpr ADD => nameof(ADD);

        public static AsmMnemonicExpr ADDPD => nameof(ADDPD);

        public static AsmMnemonicExpr VADDPD => nameof(VADDPD);

        public static AsmMnemonicExpr ADDPS => nameof(ADDPS);

        public static AsmMnemonicExpr VADDPS => nameof(VADDPS);

        public static AsmMnemonicExpr ADDSD => nameof(ADDSD);

        public static AsmMnemonicExpr VADDSD => nameof(VADDSD);

        public static AsmMnemonicExpr ADDSS => nameof(ADDSS);

        public static AsmMnemonicExpr VADDSS => nameof(VADDSS);

        public static AsmMnemonicExpr ADDSUBPD => nameof(ADDSUBPD);

        public static AsmMnemonicExpr VADDSUBPD => nameof(VADDSUBPD);

        public static AsmMnemonicExpr ADDSUBPS => nameof(ADDSUBPS);

        public static AsmMnemonicExpr VADDSUBPS => nameof(VADDSUBPS);

        public static AsmMnemonicExpr AESDEC => nameof(AESDEC);

        public static AsmMnemonicExpr VAESDEC => nameof(VAESDEC);

        public static AsmMnemonicExpr AESDECLAST => nameof(AESDECLAST);

        public static AsmMnemonicExpr VAESDECLAST => nameof(VAESDECLAST);

        public static AsmMnemonicExpr AESENC => nameof(AESENC);

        public static AsmMnemonicExpr VAESENC => nameof(VAESENC);

        public static AsmMnemonicExpr AESENCLAST => nameof(AESENCLAST);

        public static AsmMnemonicExpr VAESENCLAST => nameof(VAESENCLAST);

        public static AsmMnemonicExpr AESIMC => nameof(AESIMC);

        public static AsmMnemonicExpr VAESIMC => nameof(VAESIMC);

        public static AsmMnemonicExpr AESKEYGENASSIST => nameof(AESKEYGENASSIST);

        public static AsmMnemonicExpr VAESKEYGENASSIST => nameof(VAESKEYGENASSIST);

        public static AsmMnemonicExpr AND => nameof(AND);

        public static AsmMnemonicExpr ANDN => nameof(ANDN);

        public static AsmMnemonicExpr ANDPD => nameof(ANDPD);

        public static AsmMnemonicExpr VANDPD => nameof(VANDPD);

        public static AsmMnemonicExpr ANDPS => nameof(ANDPS);

        public static AsmMnemonicExpr VANDPS => nameof(VANDPS);

        public static AsmMnemonicExpr ANDNPD => nameof(ANDNPD);

        public static AsmMnemonicExpr VANDNPD => nameof(VANDNPD);

        public static AsmMnemonicExpr ANDNPS => nameof(ANDNPS);

        public static AsmMnemonicExpr VANDNPS => nameof(VANDNPS);

        public static AsmMnemonicExpr ARPL => nameof(ARPL);

        public static AsmMnemonicExpr BLENDPD => nameof(BLENDPD);

        public static AsmMnemonicExpr VBLENDPD => nameof(VBLENDPD);

        public static AsmMnemonicExpr BEXTR => nameof(BEXTR);

        public static AsmMnemonicExpr BLENDPS => nameof(BLENDPS);

        public static AsmMnemonicExpr VBLENDPS => nameof(VBLENDPS);

        public static AsmMnemonicExpr BLENDVPD => nameof(BLENDVPD);

        public static AsmMnemonicExpr VBLENDVPD => nameof(VBLENDVPD);

        public static AsmMnemonicExpr BLENDVPS => nameof(BLENDVPS);

        public static AsmMnemonicExpr VBLENDVPS => nameof(VBLENDVPS);

        public static AsmMnemonicExpr BLSI => nameof(BLSI);

        public static AsmMnemonicExpr BLSMSK => nameof(BLSMSK);

        public static AsmMnemonicExpr BLSR => nameof(BLSR);

        public static AsmMnemonicExpr BOUND => nameof(BOUND);

        public static AsmMnemonicExpr BSF => nameof(BSF);

        public static AsmMnemonicExpr BSR => nameof(BSR);

        public static AsmMnemonicExpr BSWAP => nameof(BSWAP);

        public static AsmMnemonicExpr BT => nameof(BT);

        public static AsmMnemonicExpr BTC => nameof(BTC);

        public static AsmMnemonicExpr BTR => nameof(BTR);

        public static AsmMnemonicExpr BTS => nameof(BTS);

        public static AsmMnemonicExpr BZHI => nameof(BZHI);

        public static AsmMnemonicExpr CALL => nameof(CALL);

        public static AsmMnemonicExpr CLFLUSH => nameof(CLFLUSH);

        public static AsmMnemonicExpr CMOVA => nameof(CMOVA);

        public static AsmMnemonicExpr CMOVAE => nameof(CMOVAE);

        public static AsmMnemonicExpr CMOVB => nameof(CMOVB);

        public static AsmMnemonicExpr CMOVBE => nameof(CMOVBE);

        public static AsmMnemonicExpr CMOVC => nameof(CMOVC);

        public static AsmMnemonicExpr CMOVE => nameof(CMOVE);

        public static AsmMnemonicExpr CMOVG => nameof(CMOVG);

        public static AsmMnemonicExpr CMOVGE => nameof(CMOVGE);

        public static AsmMnemonicExpr CMOVL => nameof(CMOVL);

        public static AsmMnemonicExpr CMOVLE => nameof(CMOVLE);

        public static AsmMnemonicExpr CMOVNA => nameof(CMOVNA);

        public static AsmMnemonicExpr CMOVNAE => nameof(CMOVNAE);

        public static AsmMnemonicExpr CMOVNB => nameof(CMOVNB);

        public static AsmMnemonicExpr CMOVNBE => nameof(CMOVNBE);

        public static AsmMnemonicExpr CMOVNC => nameof(CMOVNC);

        public static AsmMnemonicExpr CMOVNE => nameof(CMOVNE);

        public static AsmMnemonicExpr CMOVNG => nameof(CMOVNG);

        public static AsmMnemonicExpr CMOVNGE => nameof(CMOVNGE);

        public static AsmMnemonicExpr CMOVNL => nameof(CMOVNL);

        public static AsmMnemonicExpr CMOVNLE => nameof(CMOVNLE);

        public static AsmMnemonicExpr CMOVNO => nameof(CMOVNO);

        public static AsmMnemonicExpr CMOVNP => nameof(CMOVNP);

        public static AsmMnemonicExpr CMOVNS => nameof(CMOVNS);

        public static AsmMnemonicExpr CMOVNZ => nameof(CMOVNZ);

        public static AsmMnemonicExpr CMOVO => nameof(CMOVO);

        public static AsmMnemonicExpr CMOVP => nameof(CMOVP);

        public static AsmMnemonicExpr CMOVPE => nameof(CMOVPE);

        public static AsmMnemonicExpr CMOVPO => nameof(CMOVPO);

        public static AsmMnemonicExpr CMOVS => nameof(CMOVS);

        public static AsmMnemonicExpr CMOVZ => nameof(CMOVZ);

        public static AsmMnemonicExpr CMP => nameof(CMP);

        public static AsmMnemonicExpr CMPPD => nameof(CMPPD);

        public static AsmMnemonicExpr VCMPPD => nameof(VCMPPD);

        public static AsmMnemonicExpr CMPPS => nameof(CMPPS);

        public static AsmMnemonicExpr VCMPPS => nameof(VCMPPS);

        public static AsmMnemonicExpr CMPS => nameof(CMPS);

        public static AsmMnemonicExpr CMPSD => nameof(CMPSD);

        public static AsmMnemonicExpr VCMPSD => nameof(VCMPSD);

        public static AsmMnemonicExpr CMPSS => nameof(CMPSS);

        public static AsmMnemonicExpr VCMPSS => nameof(VCMPSS);

        public static AsmMnemonicExpr CMPXCHG => nameof(CMPXCHG);

        public static AsmMnemonicExpr CMPXCHG8B => nameof(CMPXCHG8B);

        public static AsmMnemonicExpr CMPXCHG16B => nameof(CMPXCHG16B);

        public static AsmMnemonicExpr COMISD => nameof(COMISD);

        public static AsmMnemonicExpr VCOMISD => nameof(VCOMISD);

        public static AsmMnemonicExpr COMISS => nameof(COMISS);

        public static AsmMnemonicExpr VCOMISS => nameof(VCOMISS);

        public static AsmMnemonicExpr CRC32 => nameof(CRC32);

        public static AsmMnemonicExpr CVTDQ2PD => nameof(CVTDQ2PD);

        public static AsmMnemonicExpr VCVTDQ2PD => nameof(VCVTDQ2PD);

        public static AsmMnemonicExpr CVTDQ2PS => nameof(CVTDQ2PS);

        public static AsmMnemonicExpr VCVTDQ2PS => nameof(VCVTDQ2PS);

        public static AsmMnemonicExpr CVTPD2DQ => nameof(CVTPD2DQ);

        public static AsmMnemonicExpr VCVTPD2DQ => nameof(VCVTPD2DQ);

        public static AsmMnemonicExpr CVTPD2PI => nameof(CVTPD2PI);

        public static AsmMnemonicExpr CVTPD2PS => nameof(CVTPD2PS);

        public static AsmMnemonicExpr VCVTPD2PS => nameof(VCVTPD2PS);

        public static AsmMnemonicExpr CVTPI2PD => nameof(CVTPI2PD);

        public static AsmMnemonicExpr CVTPI2PS => nameof(CVTPI2PS);

        public static AsmMnemonicExpr CVTPS2DQ => nameof(CVTPS2DQ);

        public static AsmMnemonicExpr VCVTPS2DQ => nameof(VCVTPS2DQ);

        public static AsmMnemonicExpr CVTPS2PD => nameof(CVTPS2PD);

        public static AsmMnemonicExpr VCVTPS2PD => nameof(VCVTPS2PD);

        public static AsmMnemonicExpr CVTPS2PI => nameof(CVTPS2PI);

        public static AsmMnemonicExpr CVTSD2SI => nameof(CVTSD2SI);

        public static AsmMnemonicExpr VCVTSD2SI => nameof(VCVTSD2SI);

        public static AsmMnemonicExpr CVTSD2SS => nameof(CVTSD2SS);

        public static AsmMnemonicExpr VCVTSD2SS => nameof(VCVTSD2SS);

        public static AsmMnemonicExpr CVTSI2SD => nameof(CVTSI2SD);

        public static AsmMnemonicExpr VCVTSI2SD => nameof(VCVTSI2SD);

        public static AsmMnemonicExpr CVTSI2SS => nameof(CVTSI2SS);

        public static AsmMnemonicExpr VCVTSI2SS => nameof(VCVTSI2SS);

        public static AsmMnemonicExpr CVTSS2SD => nameof(CVTSS2SD);

        public static AsmMnemonicExpr VCVTSS2SD => nameof(VCVTSS2SD);

        public static AsmMnemonicExpr CVTSS2SI => nameof(CVTSS2SI);

        public static AsmMnemonicExpr VCVTSS2SI => nameof(VCVTSS2SI);

        public static AsmMnemonicExpr CVTTPD2DQ => nameof(CVTTPD2DQ);

        public static AsmMnemonicExpr VCVTTPD2DQ => nameof(VCVTTPD2DQ);

        public static AsmMnemonicExpr CVTTPD2PI => nameof(CVTTPD2PI);

        public static AsmMnemonicExpr CVTTPS2DQ => nameof(CVTTPS2DQ);

        public static AsmMnemonicExpr VCVTTPS2DQ => nameof(VCVTTPS2DQ);

        public static AsmMnemonicExpr CVTTPS2PI => nameof(CVTTPS2PI);

        public static AsmMnemonicExpr CVTTSD2SI => nameof(CVTTSD2SI);

        public static AsmMnemonicExpr VCVTTSD2SI => nameof(VCVTTSD2SI);

        public static AsmMnemonicExpr CVTTSS2SI => nameof(CVTTSS2SI);

        public static AsmMnemonicExpr VCVTTSS2SI => nameof(VCVTTSS2SI);

        public static AsmMnemonicExpr DEC => nameof(DEC);

        public static AsmMnemonicExpr DIV => nameof(DIV);

        public static AsmMnemonicExpr DIVPD => nameof(DIVPD);

        public static AsmMnemonicExpr VDIVPD => nameof(VDIVPD);

        public static AsmMnemonicExpr DIVPS => nameof(DIVPS);

        public static AsmMnemonicExpr VDIVPS => nameof(VDIVPS);

        public static AsmMnemonicExpr DIVSD => nameof(DIVSD);

        public static AsmMnemonicExpr VDIVSD => nameof(VDIVSD);

        public static AsmMnemonicExpr DIVSS => nameof(DIVSS);

        public static AsmMnemonicExpr VDIVSS => nameof(VDIVSS);

        public static AsmMnemonicExpr DPPD => nameof(DPPD);

        public static AsmMnemonicExpr VDPPD => nameof(VDPPD);

        public static AsmMnemonicExpr DPPS => nameof(DPPS);

        public static AsmMnemonicExpr VDPPS => nameof(VDPPS);

        public static AsmMnemonicExpr ENTER => nameof(ENTER);

        public static AsmMnemonicExpr EXTRACTPS => nameof(EXTRACTPS);

        public static AsmMnemonicExpr VEXTRACTPS => nameof(VEXTRACTPS);

        public static AsmMnemonicExpr FADD => nameof(FADD);

        public static AsmMnemonicExpr FADDP => nameof(FADDP);

        public static AsmMnemonicExpr FIADD => nameof(FIADD);

        public static AsmMnemonicExpr FBLD => nameof(FBLD);

        public static AsmMnemonicExpr FBSTP => nameof(FBSTP);

        public static AsmMnemonicExpr FCMOVB => nameof(FCMOVB);

        public static AsmMnemonicExpr FCMOVE => nameof(FCMOVE);

        public static AsmMnemonicExpr FCMOVBE => nameof(FCMOVBE);

        public static AsmMnemonicExpr FCMOVU => nameof(FCMOVU);

        public static AsmMnemonicExpr FCMOVNB => nameof(FCMOVNB);

        public static AsmMnemonicExpr FCMOVNE => nameof(FCMOVNE);

        public static AsmMnemonicExpr FCMOVNBE => nameof(FCMOVNBE);

        public static AsmMnemonicExpr FCMOVNU => nameof(FCMOVNU);

        public static AsmMnemonicExpr FCOM => nameof(FCOM);

        public static AsmMnemonicExpr FCOMP => nameof(FCOMP);

        public static AsmMnemonicExpr FCOMI => nameof(FCOMI);

        public static AsmMnemonicExpr FCOMIP => nameof(FCOMIP);

        public static AsmMnemonicExpr FUCOMI => nameof(FUCOMI);

        public static AsmMnemonicExpr FUCOMIP => nameof(FUCOMIP);

        public static AsmMnemonicExpr FDIV => nameof(FDIV);

        public static AsmMnemonicExpr FDIVP => nameof(FDIVP);

        public static AsmMnemonicExpr FIDIV => nameof(FIDIV);

        public static AsmMnemonicExpr FDIVR => nameof(FDIVR);

        public static AsmMnemonicExpr FDIVRP => nameof(FDIVRP);

        public static AsmMnemonicExpr FIDIVR => nameof(FIDIVR);

        public static AsmMnemonicExpr FFREE => nameof(FFREE);

        public static AsmMnemonicExpr FICOM => nameof(FICOM);

        public static AsmMnemonicExpr FICOMP => nameof(FICOMP);

        public static AsmMnemonicExpr FILD => nameof(FILD);

        public static AsmMnemonicExpr FIST => nameof(FIST);

        public static AsmMnemonicExpr FISTP => nameof(FISTP);

        public static AsmMnemonicExpr FISTTP => nameof(FISTTP);

        public static AsmMnemonicExpr FLD => nameof(FLD);

        public static AsmMnemonicExpr FLDCW => nameof(FLDCW);

        public static AsmMnemonicExpr FLDENV => nameof(FLDENV);

        public static AsmMnemonicExpr FMUL => nameof(FMUL);

        public static AsmMnemonicExpr FMULP => nameof(FMULP);

        public static AsmMnemonicExpr FIMUL => nameof(FIMUL);

        public static AsmMnemonicExpr FRSTOR => nameof(FRSTOR);

        public static AsmMnemonicExpr FSAVE => nameof(FSAVE);

        public static AsmMnemonicExpr FNSAVE => nameof(FNSAVE);

        public static AsmMnemonicExpr FST => nameof(FST);

        public static AsmMnemonicExpr FSTP => nameof(FSTP);

        public static AsmMnemonicExpr FSTCW => nameof(FSTCW);

        public static AsmMnemonicExpr FNSTCW => nameof(FNSTCW);

        public static AsmMnemonicExpr FSTENV => nameof(FSTENV);

        public static AsmMnemonicExpr FNSTENV => nameof(FNSTENV);

        public static AsmMnemonicExpr FSTSW => nameof(FSTSW);

        public static AsmMnemonicExpr FNSTSW => nameof(FNSTSW);

        public static AsmMnemonicExpr FSUB => nameof(FSUB);

        public static AsmMnemonicExpr FSUBP => nameof(FSUBP);

        public static AsmMnemonicExpr FISUB => nameof(FISUB);

        public static AsmMnemonicExpr FSUBR => nameof(FSUBR);

        public static AsmMnemonicExpr FSUBRP => nameof(FSUBRP);

        public static AsmMnemonicExpr FISUBR => nameof(FISUBR);

        public static AsmMnemonicExpr FUCOM => nameof(FUCOM);

        public static AsmMnemonicExpr FUCOMP => nameof(FUCOMP);

        public static AsmMnemonicExpr FXCH => nameof(FXCH);

        public static AsmMnemonicExpr FXRSTOR => nameof(FXRSTOR);

        public static AsmMnemonicExpr FXRSTOR64 => nameof(FXRSTOR64);

        public static AsmMnemonicExpr FXSAVE => nameof(FXSAVE);

        public static AsmMnemonicExpr FXSAVE64 => nameof(FXSAVE64);

        public static AsmMnemonicExpr HADDPD => nameof(HADDPD);

        public static AsmMnemonicExpr VHADDPD => nameof(VHADDPD);

        public static AsmMnemonicExpr HADDPS => nameof(HADDPS);

        public static AsmMnemonicExpr VHADDPS => nameof(VHADDPS);

        public static AsmMnemonicExpr HSUBPD => nameof(HSUBPD);

        public static AsmMnemonicExpr VHSUBPD => nameof(VHSUBPD);

        public static AsmMnemonicExpr HSUBPS => nameof(HSUBPS);

        public static AsmMnemonicExpr VHSUBPS => nameof(VHSUBPS);

        public static AsmMnemonicExpr IDIV => nameof(IDIV);

        public static AsmMnemonicExpr IMUL => nameof(IMUL);

        public static AsmMnemonicExpr IN => nameof(IN);

        public static AsmMnemonicExpr INC => nameof(INC);

        public static AsmMnemonicExpr INS => nameof(INS);

        public static AsmMnemonicExpr INSERTPS => nameof(INSERTPS);

        public static AsmMnemonicExpr VINSERTPS => nameof(VINSERTPS);

        public static AsmMnemonicExpr INT => nameof(INT);

        public static AsmMnemonicExpr INVLPG => nameof(INVLPG);

        public static AsmMnemonicExpr INVPCID => nameof(INVPCID);

        public static AsmMnemonicExpr JA => nameof(JA);

        public static AsmMnemonicExpr JAE => nameof(JAE);

        public static AsmMnemonicExpr JB => nameof(JB);

        public static AsmMnemonicExpr JBE => nameof(JBE);

        public static AsmMnemonicExpr JC => nameof(JC);

        public static AsmMnemonicExpr JCXZ => nameof(JCXZ);

        public static AsmMnemonicExpr JECXZ => nameof(JECXZ);

        public static AsmMnemonicExpr JRCXZ => nameof(JRCXZ);

        public static AsmMnemonicExpr JE => nameof(JE);

        public static AsmMnemonicExpr JG => nameof(JG);

        public static AsmMnemonicExpr JGE => nameof(JGE);

        public static AsmMnemonicExpr JL => nameof(JL);

        public static AsmMnemonicExpr JLE => nameof(JLE);

        public static AsmMnemonicExpr JNA => nameof(JNA);

        public static AsmMnemonicExpr JNAE => nameof(JNAE);

        public static AsmMnemonicExpr JNB => nameof(JNB);

        public static AsmMnemonicExpr JNBE => nameof(JNBE);

        public static AsmMnemonicExpr JNC => nameof(JNC);

        public static AsmMnemonicExpr JNE => nameof(JNE);

        public static AsmMnemonicExpr JNG => nameof(JNG);

        public static AsmMnemonicExpr JNGE => nameof(JNGE);

        public static AsmMnemonicExpr JNL => nameof(JNL);

        public static AsmMnemonicExpr JNLE => nameof(JNLE);

        public static AsmMnemonicExpr JNO => nameof(JNO);

        public static AsmMnemonicExpr JNP => nameof(JNP);

        public static AsmMnemonicExpr JNS => nameof(JNS);

        public static AsmMnemonicExpr JNZ => nameof(JNZ);

        public static AsmMnemonicExpr JO => nameof(JO);

        public static AsmMnemonicExpr JP => nameof(JP);

        public static AsmMnemonicExpr JPE => nameof(JPE);

        public static AsmMnemonicExpr JPO => nameof(JPO);

        public static AsmMnemonicExpr JS => nameof(JS);

        public static AsmMnemonicExpr JZ => nameof(JZ);

        public static AsmMnemonicExpr JMP => nameof(JMP);

        public static AsmMnemonicExpr LAR => nameof(LAR);

        public static AsmMnemonicExpr LDDQU => nameof(LDDQU);

        public static AsmMnemonicExpr VLDDQU => nameof(VLDDQU);

        public static AsmMnemonicExpr LDMXCSR => nameof(LDMXCSR);

        public static AsmMnemonicExpr VLDMXCSR => nameof(VLDMXCSR);

        public static AsmMnemonicExpr LDS => nameof(LDS);

        public static AsmMnemonicExpr LSS => nameof(LSS);

        public static AsmMnemonicExpr LES => nameof(LES);

        public static AsmMnemonicExpr LFS => nameof(LFS);

        public static AsmMnemonicExpr LGS => nameof(LGS);

        public static AsmMnemonicExpr LEA => nameof(LEA);

        public static AsmMnemonicExpr LEAVE => nameof(LEAVE);

        public static AsmMnemonicExpr LGDT => nameof(LGDT);

        public static AsmMnemonicExpr LIDT => nameof(LIDT);

        public static AsmMnemonicExpr LLDT => nameof(LLDT);

        public static AsmMnemonicExpr LMSW => nameof(LMSW);

        public static AsmMnemonicExpr LODS => nameof(LODS);

        public static AsmMnemonicExpr LOOP => nameof(LOOP);

        public static AsmMnemonicExpr LOOPE => nameof(LOOPE);

        public static AsmMnemonicExpr LOOPNE => nameof(LOOPNE);

        public static AsmMnemonicExpr LSL => nameof(LSL);

        public static AsmMnemonicExpr LTR => nameof(LTR);

        public static AsmMnemonicExpr LZCNT => nameof(LZCNT);

        public static AsmMnemonicExpr MASKMOVDQU => nameof(MASKMOVDQU);

        public static AsmMnemonicExpr VMASKMOVDQU => nameof(VMASKMOVDQU);

        public static AsmMnemonicExpr MASKMOVQ => nameof(MASKMOVQ);

        public static AsmMnemonicExpr MAXPD => nameof(MAXPD);

        public static AsmMnemonicExpr VMAXPD => nameof(VMAXPD);

        public static AsmMnemonicExpr MAXPS => nameof(MAXPS);

        public static AsmMnemonicExpr VMAXPS => nameof(VMAXPS);

        public static AsmMnemonicExpr MAXSD => nameof(MAXSD);

        public static AsmMnemonicExpr VMAXSD => nameof(VMAXSD);

        public static AsmMnemonicExpr MAXSS => nameof(MAXSS);

        public static AsmMnemonicExpr VMAXSS => nameof(VMAXSS);

        public static AsmMnemonicExpr MINPD => nameof(MINPD);

        public static AsmMnemonicExpr VMINPD => nameof(VMINPD);

        public static AsmMnemonicExpr MINPS => nameof(MINPS);

        public static AsmMnemonicExpr VMINPS => nameof(VMINPS);

        public static AsmMnemonicExpr MINSD => nameof(MINSD);

        public static AsmMnemonicExpr VMINSD => nameof(VMINSD);

        public static AsmMnemonicExpr MINSS => nameof(MINSS);

        public static AsmMnemonicExpr VMINSS => nameof(VMINSS);

        public static AsmMnemonicExpr MOV => nameof(MOV);

        public static AsmMnemonicExpr MOVAPD => nameof(MOVAPD);

        public static AsmMnemonicExpr VMOVAPD => nameof(VMOVAPD);

        public static AsmMnemonicExpr MOVAPS => nameof(MOVAPS);

        public static AsmMnemonicExpr VMOVAPS => nameof(VMOVAPS);

        public static AsmMnemonicExpr MOVBE => nameof(MOVBE);

        public static AsmMnemonicExpr MOVD => nameof(MOVD);

        public static AsmMnemonicExpr MOVQ => nameof(MOVQ);

        public static AsmMnemonicExpr VMOVD => nameof(VMOVD);

        public static AsmMnemonicExpr VMOVQ => nameof(VMOVQ);

        public static AsmMnemonicExpr MOVDDUP => nameof(MOVDDUP);

        public static AsmMnemonicExpr VMOVDDUP => nameof(VMOVDDUP);

        public static AsmMnemonicExpr MOVDQA => nameof(MOVDQA);

        public static AsmMnemonicExpr VMOVDQA => nameof(VMOVDQA);

        public static AsmMnemonicExpr MOVDQU => nameof(MOVDQU);

        public static AsmMnemonicExpr VMOVDQU => nameof(VMOVDQU);

        public static AsmMnemonicExpr MOVDQ2Q => nameof(MOVDQ2Q);

        public static AsmMnemonicExpr MOVHLPS => nameof(MOVHLPS);

        public static AsmMnemonicExpr VMOVHLPS => nameof(VMOVHLPS);

        public static AsmMnemonicExpr MOVHPD => nameof(MOVHPD);

        public static AsmMnemonicExpr VMOVHPD => nameof(VMOVHPD);

        public static AsmMnemonicExpr MOVHPS => nameof(MOVHPS);

        public static AsmMnemonicExpr VMOVHPS => nameof(VMOVHPS);

        public static AsmMnemonicExpr MOVLHPS => nameof(MOVLHPS);

        public static AsmMnemonicExpr VMOVLHPS => nameof(VMOVLHPS);

        public static AsmMnemonicExpr MOVLPD => nameof(MOVLPD);

        public static AsmMnemonicExpr VMOVLPD => nameof(VMOVLPD);

        public static AsmMnemonicExpr MOVLPS => nameof(MOVLPS);

        public static AsmMnemonicExpr VMOVLPS => nameof(VMOVLPS);

        public static AsmMnemonicExpr MOVMSKPD => nameof(MOVMSKPD);

        public static AsmMnemonicExpr VMOVMSKPD => nameof(VMOVMSKPD);

        public static AsmMnemonicExpr MOVMSKPS => nameof(MOVMSKPS);

        public static AsmMnemonicExpr VMOVMSKPS => nameof(VMOVMSKPS);

        public static AsmMnemonicExpr MOVNTDQA => nameof(MOVNTDQA);

        public static AsmMnemonicExpr VMOVNTDQA => nameof(VMOVNTDQA);

        public static AsmMnemonicExpr MOVNTDQ => nameof(MOVNTDQ);

        public static AsmMnemonicExpr VMOVNTDQ => nameof(VMOVNTDQ);

        public static AsmMnemonicExpr MOVNTI => nameof(MOVNTI);

        public static AsmMnemonicExpr MOVNTPD => nameof(MOVNTPD);

        public static AsmMnemonicExpr VMOVNTPD => nameof(VMOVNTPD);

        public static AsmMnemonicExpr MOVNTPS => nameof(MOVNTPS);

        public static AsmMnemonicExpr VMOVNTPS => nameof(VMOVNTPS);

        public static AsmMnemonicExpr MOVNTQ => nameof(MOVNTQ);

        public static AsmMnemonicExpr MOVQ2DQ => nameof(MOVQ2DQ);

        public static AsmMnemonicExpr MOVS => nameof(MOVS);

        public static AsmMnemonicExpr MOVSD => nameof(MOVSD);

        public static AsmMnemonicExpr VMOVSD => nameof(VMOVSD);

        public static AsmMnemonicExpr MOVSHDUP => nameof(MOVSHDUP);

        public static AsmMnemonicExpr VMOVSHDUP => nameof(VMOVSHDUP);

        public static AsmMnemonicExpr MOVSLDUP => nameof(MOVSLDUP);

        public static AsmMnemonicExpr VMOVSLDUP => nameof(VMOVSLDUP);

        public static AsmMnemonicExpr MOVSS => nameof(MOVSS);

        public static AsmMnemonicExpr VMOVSS => nameof(VMOVSS);

        public static AsmMnemonicExpr MOVSX => nameof(MOVSX);

        public static AsmMnemonicExpr MOVSXD => nameof(MOVSXD);

        public static AsmMnemonicExpr MOVUPD => nameof(MOVUPD);

        public static AsmMnemonicExpr VMOVUPD => nameof(VMOVUPD);

        public static AsmMnemonicExpr MOVUPS => nameof(MOVUPS);

        public static AsmMnemonicExpr VMOVUPS => nameof(VMOVUPS);

        public static AsmMnemonicExpr MOVZX => nameof(MOVZX);

        public static AsmMnemonicExpr MPSADBW => nameof(MPSADBW);

        public static AsmMnemonicExpr VMPSADBW => nameof(VMPSADBW);

        public static AsmMnemonicExpr MUL => nameof(MUL);

        public static AsmMnemonicExpr MULPD => nameof(MULPD);

        public static AsmMnemonicExpr VMULPD => nameof(VMULPD);

        public static AsmMnemonicExpr MULPS => nameof(MULPS);

        public static AsmMnemonicExpr VMULPS => nameof(VMULPS);

        public static AsmMnemonicExpr MULSD => nameof(MULSD);

        public static AsmMnemonicExpr VMULSD => nameof(VMULSD);

        public static AsmMnemonicExpr MULSS => nameof(MULSS);

        public static AsmMnemonicExpr VMULSS => nameof(VMULSS);

        public static AsmMnemonicExpr MULX => nameof(MULX);

        public static AsmMnemonicExpr NEG => nameof(NEG);

        public static AsmMnemonicExpr NOP => nameof(NOP);

        public static AsmMnemonicExpr NOT => nameof(NOT);

        public static AsmMnemonicExpr OR => nameof(OR);

        public static AsmMnemonicExpr ORPD => nameof(ORPD);

        public static AsmMnemonicExpr VORPD => nameof(VORPD);

        public static AsmMnemonicExpr ORPS => nameof(ORPS);

        public static AsmMnemonicExpr VORPS => nameof(VORPS);

        public static AsmMnemonicExpr OUT => nameof(OUT);

        public static AsmMnemonicExpr OUTS => nameof(OUTS);

        public static AsmMnemonicExpr PABSB => nameof(PABSB);

        public static AsmMnemonicExpr PABSW => nameof(PABSW);

        public static AsmMnemonicExpr PABSD => nameof(PABSD);

        public static AsmMnemonicExpr VPABSB => nameof(VPABSB);

        public static AsmMnemonicExpr VPABSW => nameof(VPABSW);

        public static AsmMnemonicExpr VPABSD => nameof(VPABSD);

        public static AsmMnemonicExpr PACKSSWB => nameof(PACKSSWB);

        public static AsmMnemonicExpr PACKSSDW => nameof(PACKSSDW);

        public static AsmMnemonicExpr VPACKSSWB => nameof(VPACKSSWB);

        public static AsmMnemonicExpr VPACKSSDW => nameof(VPACKSSDW);

        public static AsmMnemonicExpr PACKUSDW => nameof(PACKUSDW);

        public static AsmMnemonicExpr VPACKUSDW => nameof(VPACKUSDW);

        public static AsmMnemonicExpr PACKUSWB => nameof(PACKUSWB);

        public static AsmMnemonicExpr VPACKUSWB => nameof(VPACKUSWB);

        public static AsmMnemonicExpr PADDB => nameof(PADDB);

        public static AsmMnemonicExpr PADDW => nameof(PADDW);

        public static AsmMnemonicExpr PADDD => nameof(PADDD);

        public static AsmMnemonicExpr VPADDB => nameof(VPADDB);

        public static AsmMnemonicExpr VPADDW => nameof(VPADDW);

        public static AsmMnemonicExpr VPADDD => nameof(VPADDD);

        public static AsmMnemonicExpr PADDQ => nameof(PADDQ);

        public static AsmMnemonicExpr VPADDQ => nameof(VPADDQ);

        public static AsmMnemonicExpr PADDSB => nameof(PADDSB);

        public static AsmMnemonicExpr PADDSW => nameof(PADDSW);

        public static AsmMnemonicExpr VPADDSB => nameof(VPADDSB);

        public static AsmMnemonicExpr VPADDSW => nameof(VPADDSW);

        public static AsmMnemonicExpr PADDUSB => nameof(PADDUSB);

        public static AsmMnemonicExpr PADDUSW => nameof(PADDUSW);

        public static AsmMnemonicExpr VPADDUSB => nameof(VPADDUSB);

        public static AsmMnemonicExpr VPADDUSW => nameof(VPADDUSW);

        public static AsmMnemonicExpr PALIGNR => nameof(PALIGNR);

        public static AsmMnemonicExpr VPALIGNR => nameof(VPALIGNR);

        public static AsmMnemonicExpr PAND => nameof(PAND);

        public static AsmMnemonicExpr VPAND => nameof(VPAND);

        public static AsmMnemonicExpr PANDN => nameof(PANDN);

        public static AsmMnemonicExpr VPANDN => nameof(VPANDN);

        public static AsmMnemonicExpr PAVGB => nameof(PAVGB);

        public static AsmMnemonicExpr PAVGW => nameof(PAVGW);

        public static AsmMnemonicExpr VPAVGB => nameof(VPAVGB);

        public static AsmMnemonicExpr VPAVGW => nameof(VPAVGW);

        public static AsmMnemonicExpr PBLENDVB => nameof(PBLENDVB);

        public static AsmMnemonicExpr VPBLENDVB => nameof(VPBLENDVB);

        public static AsmMnemonicExpr PBLENDW => nameof(PBLENDW);

        public static AsmMnemonicExpr VPBLENDW => nameof(VPBLENDW);

        public static AsmMnemonicExpr PCLMULQDQ => nameof(PCLMULQDQ);

        public static AsmMnemonicExpr VPCLMULQDQ => nameof(VPCLMULQDQ);

        public static AsmMnemonicExpr PCMPEQB => nameof(PCMPEQB);

        public static AsmMnemonicExpr PCMPEQW => nameof(PCMPEQW);

        public static AsmMnemonicExpr PCMPEQD => nameof(PCMPEQD);

        public static AsmMnemonicExpr VPCMPEQB => nameof(VPCMPEQB);

        public static AsmMnemonicExpr VPCMPEQW => nameof(VPCMPEQW);

        public static AsmMnemonicExpr VPCMPEQD => nameof(VPCMPEQD);

        public static AsmMnemonicExpr PCMPEQQ => nameof(PCMPEQQ);

        public static AsmMnemonicExpr VPCMPEQQ => nameof(VPCMPEQQ);

        public static AsmMnemonicExpr PCMPESTRI => nameof(PCMPESTRI);

        public static AsmMnemonicExpr VPCMPESTRI => nameof(VPCMPESTRI);

        public static AsmMnemonicExpr PCMPESTRM => nameof(PCMPESTRM);

        public static AsmMnemonicExpr VPCMPESTRM => nameof(VPCMPESTRM);

        public static AsmMnemonicExpr PCMPGTB => nameof(PCMPGTB);

        public static AsmMnemonicExpr PCMPGTW => nameof(PCMPGTW);

        public static AsmMnemonicExpr PCMPGTD => nameof(PCMPGTD);

        public static AsmMnemonicExpr VPCMPGTB => nameof(VPCMPGTB);

        public static AsmMnemonicExpr VPCMPGTW => nameof(VPCMPGTW);

        public static AsmMnemonicExpr VPCMPGTD => nameof(VPCMPGTD);

        public static AsmMnemonicExpr PCMPGTQ => nameof(PCMPGTQ);

        public static AsmMnemonicExpr VPCMPGTQ => nameof(VPCMPGTQ);

        public static AsmMnemonicExpr PCMPISTRI => nameof(PCMPISTRI);

        public static AsmMnemonicExpr VPCMPISTRI => nameof(VPCMPISTRI);

        public static AsmMnemonicExpr PCMPISTRM => nameof(PCMPISTRM);

        public static AsmMnemonicExpr VPCMPISTRM => nameof(VPCMPISTRM);

        public static AsmMnemonicExpr PDEP => nameof(PDEP);

        public static AsmMnemonicExpr PEXT => nameof(PEXT);

        public static AsmMnemonicExpr PEXTRB => nameof(PEXTRB);

        public static AsmMnemonicExpr PEXTRD => nameof(PEXTRD);

        public static AsmMnemonicExpr PEXTRQ => nameof(PEXTRQ);

        public static AsmMnemonicExpr VPEXTRB => nameof(VPEXTRB);

        public static AsmMnemonicExpr VPEXTRD => nameof(VPEXTRD);

        public static AsmMnemonicExpr VPEXTRQ => nameof(VPEXTRQ);

        public static AsmMnemonicExpr PEXTRW => nameof(PEXTRW);

        public static AsmMnemonicExpr VPEXTRW => nameof(VPEXTRW);

        public static AsmMnemonicExpr PHADDW => nameof(PHADDW);

        public static AsmMnemonicExpr PHADDD => nameof(PHADDD);

        public static AsmMnemonicExpr VPHADDW => nameof(VPHADDW);

        public static AsmMnemonicExpr VPHADDD => nameof(VPHADDD);

        public static AsmMnemonicExpr PHADDSW => nameof(PHADDSW);

        public static AsmMnemonicExpr VPHADDSW => nameof(VPHADDSW);

        public static AsmMnemonicExpr PHMINPOSUW => nameof(PHMINPOSUW);

        public static AsmMnemonicExpr VPHMINPOSUW => nameof(VPHMINPOSUW);

        public static AsmMnemonicExpr PHSUBW => nameof(PHSUBW);

        public static AsmMnemonicExpr PHSUBD => nameof(PHSUBD);

        public static AsmMnemonicExpr VPHSUBW => nameof(VPHSUBW);

        public static AsmMnemonicExpr VPHSUBD => nameof(VPHSUBD);

        public static AsmMnemonicExpr PHSUBSW => nameof(PHSUBSW);

        public static AsmMnemonicExpr VPHSUBSW => nameof(VPHSUBSW);

        public static AsmMnemonicExpr PINSRB => nameof(PINSRB);

        public static AsmMnemonicExpr PINSRD => nameof(PINSRD);

        public static AsmMnemonicExpr PINSRQ => nameof(PINSRQ);

        public static AsmMnemonicExpr VPINSRB => nameof(VPINSRB);

        public static AsmMnemonicExpr VPINSRD => nameof(VPINSRD);

        public static AsmMnemonicExpr VPINSRQ => nameof(VPINSRQ);

        public static AsmMnemonicExpr PINSRW => nameof(PINSRW);

        public static AsmMnemonicExpr VPINSRW => nameof(VPINSRW);

        public static AsmMnemonicExpr PMADDUBSW => nameof(PMADDUBSW);

        public static AsmMnemonicExpr VPMADDUBSW => nameof(VPMADDUBSW);

        public static AsmMnemonicExpr PMADDWD => nameof(PMADDWD);

        public static AsmMnemonicExpr VPMADDWD => nameof(VPMADDWD);

        public static AsmMnemonicExpr PMAXSB => nameof(PMAXSB);

        public static AsmMnemonicExpr VPMAXSB => nameof(VPMAXSB);

        public static AsmMnemonicExpr PMAXSD => nameof(PMAXSD);

        public static AsmMnemonicExpr VPMAXSD => nameof(VPMAXSD);

        public static AsmMnemonicExpr PMAXSW => nameof(PMAXSW);

        public static AsmMnemonicExpr VPMAXSW => nameof(VPMAXSW);

        public static AsmMnemonicExpr PMAXUB => nameof(PMAXUB);

        public static AsmMnemonicExpr VPMAXUB => nameof(VPMAXUB);

        public static AsmMnemonicExpr PMAXUD => nameof(PMAXUD);

        public static AsmMnemonicExpr VPMAXUD => nameof(VPMAXUD);

        public static AsmMnemonicExpr PMAXUW => nameof(PMAXUW);

        public static AsmMnemonicExpr VPMAXUW => nameof(VPMAXUW);

        public static AsmMnemonicExpr PMINSB => nameof(PMINSB);

        public static AsmMnemonicExpr VPMINSB => nameof(VPMINSB);

        public static AsmMnemonicExpr PMINSD => nameof(PMINSD);

        public static AsmMnemonicExpr VPMINSD => nameof(VPMINSD);

        public static AsmMnemonicExpr PMINSW => nameof(PMINSW);

        public static AsmMnemonicExpr VPMINSW => nameof(VPMINSW);

        public static AsmMnemonicExpr PMINUB => nameof(PMINUB);

        public static AsmMnemonicExpr VPMINUB => nameof(VPMINUB);

        public static AsmMnemonicExpr PMINUD => nameof(PMINUD);

        public static AsmMnemonicExpr VPMINUD => nameof(VPMINUD);

        public static AsmMnemonicExpr PMINUW => nameof(PMINUW);

        public static AsmMnemonicExpr VPMINUW => nameof(VPMINUW);

        public static AsmMnemonicExpr PMOVMSKB => nameof(PMOVMSKB);

        public static AsmMnemonicExpr VPMOVMSKB => nameof(VPMOVMSKB);

        public static AsmMnemonicExpr PMOVSXBW => nameof(PMOVSXBW);

        public static AsmMnemonicExpr PMOVSXBD => nameof(PMOVSXBD);

        public static AsmMnemonicExpr PMOVSXBQ => nameof(PMOVSXBQ);

        public static AsmMnemonicExpr PMOVSXWD => nameof(PMOVSXWD);

        public static AsmMnemonicExpr PMOVSXWQ => nameof(PMOVSXWQ);

        public static AsmMnemonicExpr PMOVSXDQ => nameof(PMOVSXDQ);

        public static AsmMnemonicExpr VPMOVSXBW => nameof(VPMOVSXBW);

        public static AsmMnemonicExpr VPMOVSXBD => nameof(VPMOVSXBD);

        public static AsmMnemonicExpr VPMOVSXBQ => nameof(VPMOVSXBQ);

        public static AsmMnemonicExpr VPMOVSXWD => nameof(VPMOVSXWD);

        public static AsmMnemonicExpr VPMOVSXWQ => nameof(VPMOVSXWQ);

        public static AsmMnemonicExpr VPMOVSXDQ => nameof(VPMOVSXDQ);

        public static AsmMnemonicExpr PMOVZXBW => nameof(PMOVZXBW);

        public static AsmMnemonicExpr PMOVZXBD => nameof(PMOVZXBD);

        public static AsmMnemonicExpr PMOVZXBQ => nameof(PMOVZXBQ);

        public static AsmMnemonicExpr PMOVZXWD => nameof(PMOVZXWD);

        public static AsmMnemonicExpr PMOVZXWQ => nameof(PMOVZXWQ);

        public static AsmMnemonicExpr PMOVZXDQ => nameof(PMOVZXDQ);

        public static AsmMnemonicExpr VPMOVZXBW => nameof(VPMOVZXBW);

        public static AsmMnemonicExpr VPMOVZXBD => nameof(VPMOVZXBD);

        public static AsmMnemonicExpr VPMOVZXBQ => nameof(VPMOVZXBQ);

        public static AsmMnemonicExpr VPMOVZXWD => nameof(VPMOVZXWD);

        public static AsmMnemonicExpr VPMOVZXWQ => nameof(VPMOVZXWQ);

        public static AsmMnemonicExpr VPMOVZXDQ => nameof(VPMOVZXDQ);

        public static AsmMnemonicExpr PMULDQ => nameof(PMULDQ);

        public static AsmMnemonicExpr VPMULDQ => nameof(VPMULDQ);

        public static AsmMnemonicExpr PMULHRSW => nameof(PMULHRSW);

        public static AsmMnemonicExpr VPMULHRSW => nameof(VPMULHRSW);

        public static AsmMnemonicExpr PMULHUW => nameof(PMULHUW);

        public static AsmMnemonicExpr VPMULHUW => nameof(VPMULHUW);

        public static AsmMnemonicExpr PMULHW => nameof(PMULHW);

        public static AsmMnemonicExpr VPMULHW => nameof(VPMULHW);

        public static AsmMnemonicExpr PMULLD => nameof(PMULLD);

        public static AsmMnemonicExpr VPMULLD => nameof(VPMULLD);

        public static AsmMnemonicExpr PMULLW => nameof(PMULLW);

        public static AsmMnemonicExpr VPMULLW => nameof(VPMULLW);

        public static AsmMnemonicExpr PMULUDQ => nameof(PMULUDQ);

        public static AsmMnemonicExpr VPMULUDQ => nameof(VPMULUDQ);

        public static AsmMnemonicExpr POP => nameof(POP);

        public static AsmMnemonicExpr POPCNT => nameof(POPCNT);

        public static AsmMnemonicExpr POR => nameof(POR);

        public static AsmMnemonicExpr VPOR => nameof(VPOR);

        public static AsmMnemonicExpr PREFETCHT0 => nameof(PREFETCHT0);

        public static AsmMnemonicExpr PREFETCHT1 => nameof(PREFETCHT1);

        public static AsmMnemonicExpr PREFETCHT2 => nameof(PREFETCHT2);

        public static AsmMnemonicExpr PREFETCHNTA => nameof(PREFETCHNTA);

        public static AsmMnemonicExpr PSADBW => nameof(PSADBW);

        public static AsmMnemonicExpr VPSADBW => nameof(VPSADBW);

        public static AsmMnemonicExpr PSHUFB => nameof(PSHUFB);

        public static AsmMnemonicExpr VPSHUFB => nameof(VPSHUFB);

        public static AsmMnemonicExpr PSHUFD => nameof(PSHUFD);

        public static AsmMnemonicExpr VPSHUFD => nameof(VPSHUFD);

        public static AsmMnemonicExpr PSHUFHW => nameof(PSHUFHW);

        public static AsmMnemonicExpr VPSHUFHW => nameof(VPSHUFHW);

        public static AsmMnemonicExpr PSHUFLW => nameof(PSHUFLW);

        public static AsmMnemonicExpr VPSHUFLW => nameof(VPSHUFLW);

        public static AsmMnemonicExpr PSHUFW => nameof(PSHUFW);

        public static AsmMnemonicExpr PSIGNB => nameof(PSIGNB);

        public static AsmMnemonicExpr PSIGNW => nameof(PSIGNW);

        public static AsmMnemonicExpr PSIGND => nameof(PSIGND);

        public static AsmMnemonicExpr VPSIGNB => nameof(VPSIGNB);

        public static AsmMnemonicExpr VPSIGNW => nameof(VPSIGNW);

        public static AsmMnemonicExpr VPSIGND => nameof(VPSIGND);

        public static AsmMnemonicExpr PSLLDQ => nameof(PSLLDQ);

        public static AsmMnemonicExpr VPSLLDQ => nameof(VPSLLDQ);

        public static AsmMnemonicExpr PSLLW => nameof(PSLLW);

        public static AsmMnemonicExpr PSLLD => nameof(PSLLD);

        public static AsmMnemonicExpr PSLLQ => nameof(PSLLQ);

        public static AsmMnemonicExpr VPSLLW => nameof(VPSLLW);

        public static AsmMnemonicExpr VPSLLD => nameof(VPSLLD);

        public static AsmMnemonicExpr VPSLLQ => nameof(VPSLLQ);

        public static AsmMnemonicExpr PSRAW => nameof(PSRAW);

        public static AsmMnemonicExpr PSRAD => nameof(PSRAD);

        public static AsmMnemonicExpr VPSRAW => nameof(VPSRAW);

        public static AsmMnemonicExpr VPSRAD => nameof(VPSRAD);

        public static AsmMnemonicExpr PSRLDQ => nameof(PSRLDQ);

        public static AsmMnemonicExpr VPSRLDQ => nameof(VPSRLDQ);

        public static AsmMnemonicExpr PSRLW => nameof(PSRLW);

        public static AsmMnemonicExpr PSRLD => nameof(PSRLD);

        public static AsmMnemonicExpr PSRLQ => nameof(PSRLQ);

        public static AsmMnemonicExpr VPSRLW => nameof(VPSRLW);

        public static AsmMnemonicExpr VPSRLD => nameof(VPSRLD);

        public static AsmMnemonicExpr VPSRLQ => nameof(VPSRLQ);

        public static AsmMnemonicExpr PSUBB => nameof(PSUBB);

        public static AsmMnemonicExpr PSUBW => nameof(PSUBW);

        public static AsmMnemonicExpr PSUBD => nameof(PSUBD);

        public static AsmMnemonicExpr VPSUBB => nameof(VPSUBB);

        public static AsmMnemonicExpr VPSUBW => nameof(VPSUBW);

        public static AsmMnemonicExpr VPSUBD => nameof(VPSUBD);

        public static AsmMnemonicExpr PSUBQ => nameof(PSUBQ);

        public static AsmMnemonicExpr VPSUBQ => nameof(VPSUBQ);

        public static AsmMnemonicExpr PSUBSB => nameof(PSUBSB);

        public static AsmMnemonicExpr PSUBSW => nameof(PSUBSW);

        public static AsmMnemonicExpr VPSUBSB => nameof(VPSUBSB);

        public static AsmMnemonicExpr VPSUBSW => nameof(VPSUBSW);

        public static AsmMnemonicExpr PSUBUSB => nameof(PSUBUSB);

        public static AsmMnemonicExpr PSUBUSW => nameof(PSUBUSW);

        public static AsmMnemonicExpr VPSUBUSB => nameof(VPSUBUSB);

        public static AsmMnemonicExpr VPSUBUSW => nameof(VPSUBUSW);

        public static AsmMnemonicExpr PTEST => nameof(PTEST);

        public static AsmMnemonicExpr VPTEST => nameof(VPTEST);

        public static AsmMnemonicExpr PUNPCKHBW => nameof(PUNPCKHBW);

        public static AsmMnemonicExpr PUNPCKHWD => nameof(PUNPCKHWD);

        public static AsmMnemonicExpr PUNPCKHDQ => nameof(PUNPCKHDQ);

        public static AsmMnemonicExpr PUNPCKHQDQ => nameof(PUNPCKHQDQ);

        public static AsmMnemonicExpr VPUNPCKHBW => nameof(VPUNPCKHBW);

        public static AsmMnemonicExpr VPUNPCKHWD => nameof(VPUNPCKHWD);

        public static AsmMnemonicExpr VPUNPCKHDQ => nameof(VPUNPCKHDQ);

        public static AsmMnemonicExpr VPUNPCKHQDQ => nameof(VPUNPCKHQDQ);

        public static AsmMnemonicExpr PUNPCKLBW => nameof(PUNPCKLBW);

        public static AsmMnemonicExpr PUNPCKLWD => nameof(PUNPCKLWD);

        public static AsmMnemonicExpr PUNPCKLDQ => nameof(PUNPCKLDQ);

        public static AsmMnemonicExpr PUNPCKLQDQ => nameof(PUNPCKLQDQ);

        public static AsmMnemonicExpr VPUNPCKLBW => nameof(VPUNPCKLBW);

        public static AsmMnemonicExpr VPUNPCKLWD => nameof(VPUNPCKLWD);

        public static AsmMnemonicExpr VPUNPCKLDQ => nameof(VPUNPCKLDQ);

        public static AsmMnemonicExpr VPUNPCKLQDQ => nameof(VPUNPCKLQDQ);

        public static AsmMnemonicExpr PUSH => nameof(PUSH);

        public static AsmMnemonicExpr PUSHQ => nameof(PUSHQ);

        public static AsmMnemonicExpr PUSHW => nameof(PUSHW);

        public static AsmMnemonicExpr PXOR => nameof(PXOR);

        public static AsmMnemonicExpr VPXOR => nameof(VPXOR);

        public static AsmMnemonicExpr RCL => nameof(RCL);

        public static AsmMnemonicExpr RCR => nameof(RCR);

        public static AsmMnemonicExpr ROL => nameof(ROL);

        public static AsmMnemonicExpr ROR => nameof(ROR);

        public static AsmMnemonicExpr RCPPS => nameof(RCPPS);

        public static AsmMnemonicExpr VRCPPS => nameof(VRCPPS);

        public static AsmMnemonicExpr RCPSS => nameof(RCPSS);

        public static AsmMnemonicExpr VRCPSS => nameof(VRCPSS);

        public static AsmMnemonicExpr RDFSBASE => nameof(RDFSBASE);

        public static AsmMnemonicExpr RDGSBASE => nameof(RDGSBASE);

        public static AsmMnemonicExpr RDRAND => nameof(RDRAND);

        public static AsmMnemonicExpr REP_INS => nameof(REP_INS);

        public static AsmMnemonicExpr REP_MOVS => nameof(REP_MOVS);

        public static AsmMnemonicExpr REP_OUTS => nameof(REP_OUTS);

        public static AsmMnemonicExpr REP_LODS => nameof(REP_LODS);

        public static AsmMnemonicExpr REP_STOS => nameof(REP_STOS);

        public static AsmMnemonicExpr REPE_CMPS => nameof(REPE_CMPS);

        public static AsmMnemonicExpr REPE_SCAS => nameof(REPE_SCAS);

        public static AsmMnemonicExpr REPNE_CMPS => nameof(REPNE_CMPS);

        public static AsmMnemonicExpr REPNE_SCAS => nameof(REPNE_SCAS);

        public static AsmMnemonicExpr RET => nameof(RET);

        public static AsmMnemonicExpr RORX => nameof(RORX);

        public static AsmMnemonicExpr ROUNDPD => nameof(ROUNDPD);

        public static AsmMnemonicExpr VROUNDPD => nameof(VROUNDPD);

        public static AsmMnemonicExpr ROUNDPS => nameof(ROUNDPS);

        public static AsmMnemonicExpr VROUNDPS => nameof(VROUNDPS);

        public static AsmMnemonicExpr ROUNDSD => nameof(ROUNDSD);

        public static AsmMnemonicExpr VROUNDSD => nameof(VROUNDSD);

        public static AsmMnemonicExpr ROUNDSS => nameof(ROUNDSS);

        public static AsmMnemonicExpr VROUNDSS => nameof(VROUNDSS);

        public static AsmMnemonicExpr RSQRTPS => nameof(RSQRTPS);

        public static AsmMnemonicExpr VRSQRTPS => nameof(VRSQRTPS);

        public static AsmMnemonicExpr RSQRTSS => nameof(RSQRTSS);

        public static AsmMnemonicExpr VRSQRTSS => nameof(VRSQRTSS);

        public static AsmMnemonicExpr SAL => nameof(SAL);

        public static AsmMnemonicExpr SAR => nameof(SAR);

        public static AsmMnemonicExpr SHL => nameof(SHL);

        public static AsmMnemonicExpr SHR => nameof(SHR);

        public static AsmMnemonicExpr SARX => nameof(SARX);

        public static AsmMnemonicExpr SHLX => nameof(SHLX);

        public static AsmMnemonicExpr SHRX => nameof(SHRX);

        public static AsmMnemonicExpr SBB => nameof(SBB);

        public static AsmMnemonicExpr SCAS => nameof(SCAS);

        public static AsmMnemonicExpr SETA => nameof(SETA);

        public static AsmMnemonicExpr SETAE => nameof(SETAE);

        public static AsmMnemonicExpr SETB => nameof(SETB);

        public static AsmMnemonicExpr SETBE => nameof(SETBE);

        public static AsmMnemonicExpr SETC => nameof(SETC);

        public static AsmMnemonicExpr SETE => nameof(SETE);

        public static AsmMnemonicExpr SETG => nameof(SETG);

        public static AsmMnemonicExpr SETGE => nameof(SETGE);

        public static AsmMnemonicExpr SETL => nameof(SETL);

        public static AsmMnemonicExpr SETLE => nameof(SETLE);

        public static AsmMnemonicExpr SETNA => nameof(SETNA);

        public static AsmMnemonicExpr SETNAE => nameof(SETNAE);

        public static AsmMnemonicExpr SETNB => nameof(SETNB);

        public static AsmMnemonicExpr SETNBE => nameof(SETNBE);

        public static AsmMnemonicExpr SETNC => nameof(SETNC);

        public static AsmMnemonicExpr SETNE => nameof(SETNE);

        public static AsmMnemonicExpr SETNG => nameof(SETNG);

        public static AsmMnemonicExpr SETNGE => nameof(SETNGE);

        public static AsmMnemonicExpr SETNL => nameof(SETNL);

        public static AsmMnemonicExpr SETNLE => nameof(SETNLE);

        public static AsmMnemonicExpr SETNO => nameof(SETNO);

        public static AsmMnemonicExpr SETNP => nameof(SETNP);

        public static AsmMnemonicExpr SETNS => nameof(SETNS);

        public static AsmMnemonicExpr SETNZ => nameof(SETNZ);

        public static AsmMnemonicExpr SETO => nameof(SETO);

        public static AsmMnemonicExpr SETP => nameof(SETP);

        public static AsmMnemonicExpr SETPE => nameof(SETPE);

        public static AsmMnemonicExpr SETPO => nameof(SETPO);

        public static AsmMnemonicExpr SETS => nameof(SETS);

        public static AsmMnemonicExpr SETZ => nameof(SETZ);

        public static AsmMnemonicExpr SGDT => nameof(SGDT);

        public static AsmMnemonicExpr SHLD => nameof(SHLD);

        public static AsmMnemonicExpr SHRD => nameof(SHRD);

        public static AsmMnemonicExpr SHUFPD => nameof(SHUFPD);

        public static AsmMnemonicExpr VSHUFPD => nameof(VSHUFPD);

        public static AsmMnemonicExpr SHUFPS => nameof(SHUFPS);

        public static AsmMnemonicExpr VSHUFPS => nameof(VSHUFPS);

        public static AsmMnemonicExpr SIDT => nameof(SIDT);

        public static AsmMnemonicExpr SLDT => nameof(SLDT);

        public static AsmMnemonicExpr SMSW => nameof(SMSW);

        public static AsmMnemonicExpr SQRTPD => nameof(SQRTPD);

        public static AsmMnemonicExpr VSQRTPD => nameof(VSQRTPD);

        public static AsmMnemonicExpr SQRTPS => nameof(SQRTPS);

        public static AsmMnemonicExpr VSQRTPS => nameof(VSQRTPS);

        public static AsmMnemonicExpr SQRTSD => nameof(SQRTSD);

        public static AsmMnemonicExpr VSQRTSD => nameof(VSQRTSD);

        public static AsmMnemonicExpr SQRTSS => nameof(SQRTSS);

        public static AsmMnemonicExpr VSQRTSS => nameof(VSQRTSS);

        public static AsmMnemonicExpr STMXCSR => nameof(STMXCSR);

        public static AsmMnemonicExpr VSTMXCSR => nameof(VSTMXCSR);

        public static AsmMnemonicExpr STOS => nameof(STOS);

        public static AsmMnemonicExpr STR => nameof(STR);

        public static AsmMnemonicExpr SUB => nameof(SUB);

        public static AsmMnemonicExpr SUBPD => nameof(SUBPD);

        public static AsmMnemonicExpr VSUBPD => nameof(VSUBPD);

        public static AsmMnemonicExpr SUBPS => nameof(SUBPS);

        public static AsmMnemonicExpr VSUBPS => nameof(VSUBPS);

        public static AsmMnemonicExpr SUBSD => nameof(SUBSD);

        public static AsmMnemonicExpr VSUBSD => nameof(VSUBSD);

        public static AsmMnemonicExpr SUBSS => nameof(SUBSS);

        public static AsmMnemonicExpr VSUBSS => nameof(VSUBSS);

        public static AsmMnemonicExpr SYSEXIT => nameof(SYSEXIT);

        public static AsmMnemonicExpr SYSRET => nameof(SYSRET);

        public static AsmMnemonicExpr TEST => nameof(TEST);

        public static AsmMnemonicExpr TZCNT => nameof(TZCNT);

        public static AsmMnemonicExpr UCOMISD => nameof(UCOMISD);

        public static AsmMnemonicExpr VUCOMISD => nameof(VUCOMISD);

        public static AsmMnemonicExpr UCOMISS => nameof(UCOMISS);

        public static AsmMnemonicExpr VUCOMISS => nameof(VUCOMISS);

        public static AsmMnemonicExpr UNPCKHPD => nameof(UNPCKHPD);

        public static AsmMnemonicExpr VUNPCKHPD => nameof(VUNPCKHPD);

        public static AsmMnemonicExpr UNPCKHPS => nameof(UNPCKHPS);

        public static AsmMnemonicExpr VUNPCKHPS => nameof(VUNPCKHPS);

        public static AsmMnemonicExpr UNPCKLPD => nameof(UNPCKLPD);

        public static AsmMnemonicExpr VUNPCKLPD => nameof(VUNPCKLPD);

        public static AsmMnemonicExpr UNPCKLPS => nameof(UNPCKLPS);

        public static AsmMnemonicExpr VUNPCKLPS => nameof(VUNPCKLPS);

        public static AsmMnemonicExpr VBROADCASTSS => nameof(VBROADCASTSS);

        public static AsmMnemonicExpr VBROADCASTSD => nameof(VBROADCASTSD);

        public static AsmMnemonicExpr VBROADCASTF128 => nameof(VBROADCASTF128);

        public static AsmMnemonicExpr VCVTPH2PS => nameof(VCVTPH2PS);

        public static AsmMnemonicExpr VCVTPS2PH => nameof(VCVTPS2PH);

        public static AsmMnemonicExpr VERR => nameof(VERR);

        public static AsmMnemonicExpr VERW => nameof(VERW);

        public static AsmMnemonicExpr VEXTRACTF128 => nameof(VEXTRACTF128);

        public static AsmMnemonicExpr VEXTRACTI128 => nameof(VEXTRACTI128);

        public static AsmMnemonicExpr VFMADD132PD => nameof(VFMADD132PD);

        public static AsmMnemonicExpr VFMADD213PD => nameof(VFMADD213PD);

        public static AsmMnemonicExpr VFMADD231PD => nameof(VFMADD231PD);

        public static AsmMnemonicExpr VFMADD132PS => nameof(VFMADD132PS);

        public static AsmMnemonicExpr VFMADD213PS => nameof(VFMADD213PS);

        public static AsmMnemonicExpr VFMADD231PS => nameof(VFMADD231PS);

        public static AsmMnemonicExpr VFMADD132SD => nameof(VFMADD132SD);

        public static AsmMnemonicExpr VFMADD213SD => nameof(VFMADD213SD);

        public static AsmMnemonicExpr VFMADD231SD => nameof(VFMADD231SD);

        public static AsmMnemonicExpr VFMADD132SS => nameof(VFMADD132SS);

        public static AsmMnemonicExpr VFMADD213SS => nameof(VFMADD213SS);

        public static AsmMnemonicExpr VFMADD231SS => nameof(VFMADD231SS);

        public static AsmMnemonicExpr VFMADDSUB132PD => nameof(VFMADDSUB132PD);

        public static AsmMnemonicExpr VFMADDSUB213PD => nameof(VFMADDSUB213PD);

        public static AsmMnemonicExpr VFMADDSUB231PD => nameof(VFMADDSUB231PD);

        public static AsmMnemonicExpr VFMADDSUB132PS => nameof(VFMADDSUB132PS);

        public static AsmMnemonicExpr VFMADDSUB213PS => nameof(VFMADDSUB213PS);

        public static AsmMnemonicExpr VFMADDSUB231PS => nameof(VFMADDSUB231PS);

        public static AsmMnemonicExpr VFMSUBADD132PD => nameof(VFMSUBADD132PD);

        public static AsmMnemonicExpr VFMSUBADD213PD => nameof(VFMSUBADD213PD);

        public static AsmMnemonicExpr VFMSUBADD231PD => nameof(VFMSUBADD231PD);

        public static AsmMnemonicExpr VFMSUBADD132PS => nameof(VFMSUBADD132PS);

        public static AsmMnemonicExpr VFMSUBADD213PS => nameof(VFMSUBADD213PS);

        public static AsmMnemonicExpr VFMSUBADD231PS => nameof(VFMSUBADD231PS);

        public static AsmMnemonicExpr VFMSUB132PD => nameof(VFMSUB132PD);

        public static AsmMnemonicExpr VFMSUB213PD => nameof(VFMSUB213PD);

        public static AsmMnemonicExpr VFMSUB231PD => nameof(VFMSUB231PD);

        public static AsmMnemonicExpr VFMSUB132PS => nameof(VFMSUB132PS);

        public static AsmMnemonicExpr VFMSUB213PS => nameof(VFMSUB213PS);

        public static AsmMnemonicExpr VFMSUB231PS => nameof(VFMSUB231PS);

        public static AsmMnemonicExpr VFMSUB132SD => nameof(VFMSUB132SD);

        public static AsmMnemonicExpr VFMSUB213SD => nameof(VFMSUB213SD);

        public static AsmMnemonicExpr VFMSUB231SD => nameof(VFMSUB231SD);

        public static AsmMnemonicExpr VFMSUB132SS => nameof(VFMSUB132SS);

        public static AsmMnemonicExpr VFMSUB213SS => nameof(VFMSUB213SS);

        public static AsmMnemonicExpr VFMSUB231SS => nameof(VFMSUB231SS);

        public static AsmMnemonicExpr VFNMADD132PD => nameof(VFNMADD132PD);

        public static AsmMnemonicExpr VFNMADD213PD => nameof(VFNMADD213PD);

        public static AsmMnemonicExpr VFNMADD231PD => nameof(VFNMADD231PD);

        public static AsmMnemonicExpr VFNMADD132PS => nameof(VFNMADD132PS);

        public static AsmMnemonicExpr VFNMADD213PS => nameof(VFNMADD213PS);

        public static AsmMnemonicExpr VFNMADD231PS => nameof(VFNMADD231PS);

        public static AsmMnemonicExpr VFNMADD132SD => nameof(VFNMADD132SD);

        public static AsmMnemonicExpr VFNMADD213SD => nameof(VFNMADD213SD);

        public static AsmMnemonicExpr VFNMADD231SD => nameof(VFNMADD231SD);

        public static AsmMnemonicExpr VFNMADD132SS => nameof(VFNMADD132SS);

        public static AsmMnemonicExpr VFNMADD213SS => nameof(VFNMADD213SS);

        public static AsmMnemonicExpr VFNMADD231SS => nameof(VFNMADD231SS);

        public static AsmMnemonicExpr VFNMSUB132PD => nameof(VFNMSUB132PD);

        public static AsmMnemonicExpr VFNMSUB213PD => nameof(VFNMSUB213PD);

        public static AsmMnemonicExpr VFNMSUB231PD => nameof(VFNMSUB231PD);

        public static AsmMnemonicExpr VFNMSUB132PS => nameof(VFNMSUB132PS);

        public static AsmMnemonicExpr VFNMSUB213PS => nameof(VFNMSUB213PS);

        public static AsmMnemonicExpr VFNMSUB231PS => nameof(VFNMSUB231PS);

        public static AsmMnemonicExpr VFNMSUB132SD => nameof(VFNMSUB132SD);

        public static AsmMnemonicExpr VFNMSUB213SD => nameof(VFNMSUB213SD);

        public static AsmMnemonicExpr VFNMSUB231SD => nameof(VFNMSUB231SD);

        public static AsmMnemonicExpr VFNMSUB132SS => nameof(VFNMSUB132SS);

        public static AsmMnemonicExpr VFNMSUB213SS => nameof(VFNMSUB213SS);

        public static AsmMnemonicExpr VFNMSUB231SS => nameof(VFNMSUB231SS);

        public static AsmMnemonicExpr VGATHERDPD => nameof(VGATHERDPD);

        public static AsmMnemonicExpr VGATHERQPD => nameof(VGATHERQPD);

        public static AsmMnemonicExpr VGATHERDPS => nameof(VGATHERDPS);

        public static AsmMnemonicExpr VGATHERQPS => nameof(VGATHERQPS);

        public static AsmMnemonicExpr VPGATHERDD => nameof(VPGATHERDD);

        public static AsmMnemonicExpr VPGATHERQD => nameof(VPGATHERQD);

        public static AsmMnemonicExpr VPGATHERDQ => nameof(VPGATHERDQ);

        public static AsmMnemonicExpr VPGATHERQQ => nameof(VPGATHERQQ);

        public static AsmMnemonicExpr VINSERTF128 => nameof(VINSERTF128);

        public static AsmMnemonicExpr VINSERTI128 => nameof(VINSERTI128);

        public static AsmMnemonicExpr VMASKMOVPS => nameof(VMASKMOVPS);

        public static AsmMnemonicExpr VMASKMOVPD => nameof(VMASKMOVPD);

        public static AsmMnemonicExpr VPBLENDD => nameof(VPBLENDD);

        public static AsmMnemonicExpr VPBROADCASTB => nameof(VPBROADCASTB);

        public static AsmMnemonicExpr VPBROADCASTW => nameof(VPBROADCASTW);

        public static AsmMnemonicExpr VPBROADCASTD => nameof(VPBROADCASTD);

        public static AsmMnemonicExpr VPBROADCASTQ => nameof(VPBROADCASTQ);

        public static AsmMnemonicExpr VBROADCASTI128 => nameof(VBROADCASTI128);

        public static AsmMnemonicExpr VPERMD => nameof(VPERMD);

        public static AsmMnemonicExpr VPERMPD => nameof(VPERMPD);

        public static AsmMnemonicExpr VPERMPS => nameof(VPERMPS);

        public static AsmMnemonicExpr VPERMQ => nameof(VPERMQ);

        public static AsmMnemonicExpr VPERM2I128 => nameof(VPERM2I128);

        public static AsmMnemonicExpr VPERMILPD => nameof(VPERMILPD);

        public static AsmMnemonicExpr VPERMILPS => nameof(VPERMILPS);

        public static AsmMnemonicExpr VPERM2F128 => nameof(VPERM2F128);

        public static AsmMnemonicExpr VPMASKMOVD => nameof(VPMASKMOVD);

        public static AsmMnemonicExpr VPMASKMOVQ => nameof(VPMASKMOVQ);

        public static AsmMnemonicExpr VPSLLVD => nameof(VPSLLVD);

        public static AsmMnemonicExpr VPSLLVQ => nameof(VPSLLVQ);

        public static AsmMnemonicExpr VPSRAVD => nameof(VPSRAVD);

        public static AsmMnemonicExpr VPSRLVD => nameof(VPSRLVD);

        public static AsmMnemonicExpr VPSRLVQ => nameof(VPSRLVQ);

        public static AsmMnemonicExpr VTESTPS => nameof(VTESTPS);

        public static AsmMnemonicExpr VTESTPD => nameof(VTESTPD);

        public static AsmMnemonicExpr WRFSBASE => nameof(WRFSBASE);

        public static AsmMnemonicExpr WRGSBASE => nameof(WRGSBASE);

        public static AsmMnemonicExpr XABORT => nameof(XABORT);

        public static AsmMnemonicExpr XADD => nameof(XADD);

        public static AsmMnemonicExpr XBEGIN => nameof(XBEGIN);

        public static AsmMnemonicExpr XCHG => nameof(XCHG);

        public static AsmMnemonicExpr XLAT => nameof(XLAT);

        public static AsmMnemonicExpr XOR => nameof(XOR);

        public static AsmMnemonicExpr XORPD => nameof(XORPD);

        public static AsmMnemonicExpr VXORPD => nameof(VXORPD);

        public static AsmMnemonicExpr XORPS => nameof(XORPS);

        public static AsmMnemonicExpr VXORPS => nameof(VXORPS);

        public static AsmMnemonicExpr XRSTOR => nameof(XRSTOR);

        public static AsmMnemonicExpr XRSTOR64 => nameof(XRSTOR64);

        public static AsmMnemonicExpr XSAVE => nameof(XSAVE);

        public static AsmMnemonicExpr XSAVE64 => nameof(XSAVE64);

        public static AsmMnemonicExpr XSAVEOPT => nameof(XSAVEOPT);

        public static AsmMnemonicExpr XSAVEOPT64 => nameof(XSAVEOPT64);
    }
}