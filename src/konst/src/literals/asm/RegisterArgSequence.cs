//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore; 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    /// <summary>
    /// Defines the order in which registers with the <see cref='RegisterAspect.ArgStore'/> aspect are used
    /// </summary>
    public enum RegisterArgSequence : byte
    {        
        /// <summary>
        /// Specifies the first 64-bit argument index
        /// </summary>
        RDI = 0,

        /// <summary>
        /// Specifies the 64-bit register populated with the value of the second argument
        /// </summary>
        RSI = 1,

        /// <summary>
        /// Specifies the 64-bit register populated with the value of the third argument
        /// </summary>
        RDX = 2,

        /// <summary>
        /// Specifies the 64-bit register populated with the value of the fourth argument
        /// </summary>
        RCX = 2,

        /// <summary>
        /// Specifies the 64-bit register populated with the value of the fifth argument
        /// </summary>
        R8Q = 4,

        /// <summary>
        /// Specifies the 64-bit register populated with the value of the sizth argument
        /// </summary>
        R9Q = 5
    }

    /*
asci16 Process(ReadOnlySpan<CpuidFeature:int> src, CpuidProcessStep step), located://machine/cpuidprocessor?Process#Process_(uspanCpuidFeature~32i,CpuidProcessStep)    
0000h push r15                                ; PUSH r64 || 50+ro || encoded[2]{41 57}
0002h push r14                                ; PUSH r64 || 50+ro || encoded[2]{41 56}
0004h push r13                                ; PUSH r64 || 50+ro || encoded[2]{41 55}
0006h push r12                                ; PUSH r64 || 50+ro || encoded[2]{41 54}
0008h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0009h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
000ah push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
000bh push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
000ch sub rsp,68h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 68}
0010h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}

    */    
}