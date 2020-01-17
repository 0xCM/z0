; 2020-01-16 19:14:09:554
; function: int devirt1()
; static ReadOnlySpan<byte> devirt1Bytes => new byte[36]{0x48,0x83,0xEC,0x28,0x90,0x48,0xB9,0x58,0x9D,0x05,0xC8,0xF7,0x7F,0x00,0x00,0xE8,0x3C,0xC3,0xB0,0x5F,0x8B,0x50,0x08,0xFF,0xC2,0x89,0x50,0x08,0x8D,0x42,0x63,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
0005h mov rcx,7FF7C8059D58h                   ; MOV(Mov_r64_imm64) [RCX,7ff7c8059d58h:imm64] encoding(10 bytes) = 48 b9 58 9d 05 c8 f7 7f 00 00
000fh call 7FF827996CB0h                      ; CALL(Call_rel32_64) [5FB0C350h:jmp64]      encoding(5 bytes) = e8 3c c3 b0 5f
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
