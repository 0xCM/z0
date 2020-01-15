; 2020-01-15 03:57:57:891
; function: int devirt1()
; static ReadOnlySpan<byte> devirt1Bytes => new byte[36]{0x48,0x83,0xEC,0x28,0x90,0x48,0xB9,0xE0,0x86,0x05,0xC8,0xF7,0x7F,0x00,0x00,0xE8,0xCC,0xC2,0xAE,0x5F,0x8B,0x50,0x08,0xFF,0xC2,0x89,0x50,0x08,0x8D,0x42,0x63,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
0005h mov rcx,7FF7C80586E0h                   ; MOV(Mov_r64_imm64) [RCX,7ff7c80586e0h:imm64] encoding(10 bytes) = 48 b9 e0 86 05 c8 f7 7f 00 00
000fh call 7FF827996CB0h                      ; CALL(Call_rel32_64) [5FAEC2E0h:jmp64]      encoding(5 bytes) = e8 cc c2 ae 5f
0014h mov edx,[rax+8]                         ; MOV(Mov_r32_rm32) [EDX,mem(32u,RAX:br,:sr)] encoding(3 bytes) = 8b 50 08
0017h inc edx                                 ; INC(Inc_rm32) [EDX]                        encoding(2 bytes) = ff c2
0019h mov [rax+8],edx                         ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX] encoding(3 bytes) = 89 50 08
001ch lea eax,[rdx+63h]                       ; LEA(Lea_r32_m) [EAX,mem(Unknown,RDX:br,:sr)] encoding(3 bytes) = 8d 42 63
001fh add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0023h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_0Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,0                     ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,0h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 00
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_1(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_1Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,1                     ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,1h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 01
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_2(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_2Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x02,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,2                     ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,2h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 02
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_3(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_3Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x03,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,3                     ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,3h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 03
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_4(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_4Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,4                     ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,4h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 04
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_5(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_5Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x05,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,5                     ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,5h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 05
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_6(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_6Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x06,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,6                     ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,6h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 06
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_7(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_7Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x07,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,7                     ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,7h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 07
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_8(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_8Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x08,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,8                     ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,8h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 08
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_9(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_9Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x09,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,9                     ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,9h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 09
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_11(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_11Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x0B,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,0Bh                   ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,bh:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 0b
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_23(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_23Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x17,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,17h                   ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,17h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 17
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbsrl_128x32u_200(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_200Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0xC8,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrldq xmm0,xmm0,0C8h                  ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,c8h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 c8
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte opA_8u(byte dl, byte r8b, byte r9b, byte rsp28)
; static ReadOnlySpan<byte> opA_8uBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD1,0x33,0xC2,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x0B,0xD0,0x0F,0xB6,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                           ; MOVZX(Movzx_r32_rm8) [EDX,R8L]             encoding(4 bytes) = 41 0f b6 d0
000ch imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h movzx edx,r9b                           ; MOVZX(Movzx_r32_rm8) [EDX,R9L]             encoding(4 bytes) = 41 0f b6 d1
0016h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh mov edx,[rsp+28h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 28
001fh movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
0022h or edx,eax                              ; OR(Or_r32_rm32) [EDX,EAX]                  encoding(2 bytes) = 0b d0
0024h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0027h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort opA_16u(ushort dx, ushort r8w, ushort r9w, ushort rsp28)
; static ReadOnlySpan<byte> opA_16uBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x41,0x0F,0xB7,0xD0,0x0F,0xAF,0xC2,0x0F,0xB7,0xC0,0x41,0x0F,0xB7,0xD1,0x33,0xC2,0x0F,0xB7,0xC0,0x8B,0x54,0x24,0x28,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0008h movzx edx,r8w                           ; MOVZX(Movzx_r32_rm16) [EDX,R8W]            encoding(4 bytes) = 41 0f b7 d0
000ch imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000fh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0012h movzx edx,r9w                           ; MOVZX(Movzx_r32_rm16) [EDX,R9W]            encoding(4 bytes) = 41 0f b7 d1
0016h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0018h movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
001bh mov edx,[rsp+28h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 28
001fh movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
0022h or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
0024h movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0027h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint opA_32u(uint edx, uint r8d, uint r9d, uint rsp28)
; static ReadOnlySpan<byte> opA_32uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xAF,0xD0,0x41,0x33,0xD1,0x8B,0xC2,0x0B,0x44,0x24,0x28,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,r8d                            ; IMUL(Imul_r32_rm32) [EDX,R8D]              encoding(4 bytes) = 41 0f af d0
0009h xor edx,r9d                             ; XOR(Xor_r32_rm32) [EDX,R9D]                encoding(3 bytes) = 41 33 d1
000ch mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000eh or eax,[rsp+28h]                        ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]  encoding(4 bytes) = 0b 44 24 28
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong opA_64u(ulong rdx, ulong r8, ulong r9, ulong rsp28)
; static ReadOnlySpan<byte> opA_64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0F,0xAF,0xD0,0x49,0x33,0xD1,0x48,0x8B,0xC2,0x48,0x0B,0x44,0x24,0x28,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,r8                             ; IMUL(Imul_r64_rm64) [RDX,R8]               encoding(4 bytes) = 49 0f af d0
0009h xor rdx,r9                              ; XOR(Xor_r64_rm64) [RDX,R9]                 encoding(3 bytes) = 49 33 d1
000ch mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000fh or rax,[rsp+28h]                        ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]  encoding(5 bytes) = 48 0b 44 24 28
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte opB_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30)
; static ReadOnlySpan<byte> opB_8uBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD1,0x33,0xC2,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x0B,0xD0,0x0F,0xB6,0xC2,0x8B,0x54,0x24,0x30,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                           ; MOVZX(Movzx_r32_rm8) [EDX,R8L]             encoding(4 bytes) = 41 0f b6 d0
000ch imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h movzx edx,r9b                           ; MOVZX(Movzx_r32_rm8) [EDX,R9L]             encoding(4 bytes) = 41 0f b6 d1
0016h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh mov edx,[rsp+28h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 28
001fh movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
0022h or edx,eax                              ; OR(Or_r32_rm32) [EDX,EAX]                  encoding(2 bytes) = 0b d0
0024h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0027h mov edx,[rsp+30h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 30
002bh movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
002eh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
0030h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0033h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte opC_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30, byte rsp38)
; static ReadOnlySpan<byte> opC_8uBytes => new byte[64]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD1,0x33,0xC2,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x0B,0xD0,0x0F,0xB6,0xC2,0x8B,0x54,0x24,0x30,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x38,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                           ; MOVZX(Movzx_r32_rm8) [EDX,R8L]             encoding(4 bytes) = 41 0f b6 d0
000ch imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h movzx edx,r9b                           ; MOVZX(Movzx_r32_rm8) [EDX,R9L]             encoding(4 bytes) = 41 0f b6 d1
0016h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh mov edx,[rsp+28h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 28
001fh movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
0022h or edx,eax                              ; OR(Or_r32_rm32) [EDX,EAX]                  encoding(2 bytes) = 0b d0
0024h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0027h mov edx,[rsp+30h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 30
002bh movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
002eh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
0030h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0033h mov edx,[rsp+38h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 38
0037h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
003ah xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
003ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
003fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void opD_8u(byte dl, byte r8b, out byte r9, out byte rdx)
; static ReadOnlySpan<byte> opD_8uBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x83,0xF0,0x05,0x41,0x88,0x01,0x41,0x0F,0xB6,0xC0,0x83,0xC8,0x07,0x48,0x8B,0x54,0x24,0x28,0x88,0x02,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h xor eax,5                               ; XOR(Xor_rm32_imm8) [EAX,5h:imm32]          encoding(3 bytes) = 83 f0 05
000bh mov [r9],al                             ; MOV(Mov_rm8_r8) [mem(8u,R9:br,:sr),AL]     encoding(3 bytes) = 41 88 01
000eh movzx eax,r8b                           ; MOVZX(Movzx_r32_rm8) [EAX,R8L]             encoding(4 bytes) = 41 0f b6 c0
0012h or eax,7                                ; OR(Or_rm32_imm8) [EAX,7h:imm32]            encoding(3 bytes) = 83 c8 07
0015h mov rdx,[rsp+28h]                       ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 8b 54 24 28
001ah mov [rdx],al                            ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]    encoding(2 bytes) = 88 02
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void opD_64u(ulong rdx, ulong r8, out ulong r9, out ulong rax)
; static ReadOnlySpan<byte> opD_64uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x83,0xF2,0x05,0x49,0x89,0x11,0x49,0x83,0xC8,0x07,0x48,0x8B,0x44,0x24,0x28,0x4C,0x89,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,5                               ; XOR(Xor_rm64_imm8) [RDX,5h:imm64]          encoding(4 bytes) = 48 83 f2 05
0009h mov [r9],rdx                            ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RDX] encoding(3 bytes) = 49 89 11
000ch or r8,7                                 ; OR(Or_rm64_imm8) [R8,7h:imm64]             encoding(4 bytes) = 49 83 c8 07
0010h mov rax,[rsp+28h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 8b 44 24 28
0015h mov [rax],r8                            ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8] encoding(3 bytes) = 4c 89 00
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void opE_64u(ulong rdx, out ulong r8, out ulong r9)
; static ReadOnlySpan<byte> opE_64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x83,0xF0,0x05,0x49,0x89,0x00,0x48,0x83,0xCA,0x07,0x49,0x89,0x11,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0008h xor rax,5                               ; XOR(Xor_rm64_imm8) [RAX,5h:imm64]          encoding(4 bytes) = 48 83 f0 05
000ch mov [r8],rax                            ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX] encoding(3 bytes) = 49 89 00
000fh or rdx,7                                ; OR(Or_rm64_imm8) [RDX,7h:imm64]            encoding(4 bytes) = 48 83 ca 07
0013h mov [r9],rdx                            ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RDX] encoding(3 bytes) = 49 89 11
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void opF_64u(ulong rdx, out ulong r8, out ulong r9, out ulong rax)
; static ReadOnlySpan<byte> opF_64uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x83,0xF0,0x05,0x49,0x89,0x00,0x48,0x8B,0xC2,0x48,0x83,0xC8,0x07,0x49,0x89,0x01,0x48,0x83,0xE2,0x0D,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x10,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0008h xor rax,5                               ; XOR(Xor_rm64_imm8) [RAX,5h:imm64]          encoding(4 bytes) = 48 83 f0 05
000ch mov [r8],rax                            ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX] encoding(3 bytes) = 49 89 00
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h or rax,7                                ; OR(Or_rm64_imm8) [RAX,7h:imm64]            encoding(4 bytes) = 48 83 c8 07
0016h mov [r9],rax                            ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RAX] encoding(3 bytes) = 49 89 01
0019h and rdx,0Dh                             ; AND(And_rm64_imm8) [RDX,dh:imm64]          encoding(4 bytes) = 48 83 e2 0d
001dh mov rax,[rsp+28h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 8b 44 24 28
0022h mov [rax],rdx                           ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX] encoding(3 bytes) = 48 89 10
0025h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
