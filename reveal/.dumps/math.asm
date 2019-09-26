; 2019-09-26 00:47:44:605
; function: short sub(short lhs, short rhs)
; location: [7FFDDDBC5C90h, 7FFDDDBC5CA3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x2B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sub(ushort lhs, ushort rhs)
; location: [7FFDDDBC5CC0h, 7FFDDDBC5CD0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x2B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sub(int lhs, int rhs)
; location: [7FFDDDBC5CF0h, 7FFDDDBC5CF9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sub(uint lhs, uint rhs)
; location: [7FFDDDBC5D10h, 7FFDDDBC5D19h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sub(long lhs, long rhs)
; location: [7FFDDDBC5D30h, 7FFDDDBC5D3Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sub(ulong lhs, ulong rhs)
; location: [7FFDDDBC5D50h, 7FFDDDBC5D5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float sub(float lhs, float rhs)
; location: [7FFDDDBC5D70h, 7FFDDDBC5D79h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vsubss xmm0,xmm0,xmm1         ; VSUBSS(VEX_Vsubss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5c c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5C,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double sub(double lhs, double rhs)
; location: [7FFDDDBC5D90h, 7FFDDDBC5D99h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vsubsd xmm0,xmm0,xmm1         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5c c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5C,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte sub(ref sbyte lhs, sbyte rhs)
; location: [7FFDDDBC5DB0h, 7FFDDDBC5DBEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h sub [rcx],al                  ; SUB(Sub_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 28 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x28,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte sub(ref byte lhs, byte rhs)
; location: [7FFDDDBC5DD0h, 7FFDDDBC5DDDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub [rcx],al                  ; SUB(Sub_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 28 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x28,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short sub(ref short lhs, short rhs)
; location: [7FFDDDBC5DF0h, 7FFDDDBC5DFFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h sub [rcx],ax                  ; SUB(Sub_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 29 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x66,0x29,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort sub(ref ushort lhs, ushort rhs)
; location: [7FFDDDBC5E10h, 7FFDDDBC5E1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h sub [rcx],ax                  ; SUB(Sub_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 29 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x66,0x29,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int sub(ref int lhs, int rhs)
; location: [7FFDDDBC5E30h, 7FFDDDBC5E3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub [rcx],edx                 ; SUB(Sub_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 29 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x29,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint sub(ref uint lhs, uint rhs)
; location: [7FFDDDBC5E50h, 7FFDDDBC5E5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub [rcx],edx                 ; SUB(Sub_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 29 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x29,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long sub(ref long lhs, long rhs)
; location: [7FFDDDBC5E70h, 7FFDDDBC5E7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub [rcx],rdx                 ; SUB(Sub_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 29 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x29,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong sub(ref ulong lhs, ulong rhs)
; location: [7FFDDDBC5E90h, 7FFDDDBC5E9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub [rcx],rdx                 ; SUB(Sub_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 29 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x29,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float sub(ref float lhs, float rhs)
; location: [7FFDDDBC5EB0h, 7FFDDDBC5EC4h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
0009h vsubss xmm0,xmm0,xmm1         ; VSUBSS(VEX_Vsubss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5c c1
000dh vmovss dword ptr [rcx],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x5C,0xC1,0xC5,0xFA,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double sub(ref double lhs, double rhs)
; location: [7FFDDDBC5EE0h, 7FFDDDBC5EF4h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
0009h vsubsd xmm0,xmm0,xmm1         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5c c1
000dh vmovsd qword ptr [rcx],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x5C,0xC1,0xC5,0xFB,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sum(ReadOnlySpan<sbyte> src)
; location: [7FFDDDBC5F10h, 7FFDDDBC5F52h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 0036h               ; JLE(Jle_rel8_64) [36h:jmp64]                         encoding(2 bytes) = 7e 22
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h movsx r9,byte ptr [rax+r9]    ; MOVSX(Movsx_r64_rm8) [R9,mem(8i,RAX:br,DS:sr)]       encoding(5 bytes) = 4e 0f be 0c 08
001ch add ecx,r9d                   ; ADD(Add_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 03 c9
001fh jo short 003dh                ; JO(Jo_rel8_64) [3Dh:jmp64]                           encoding(2 bytes) = 70 1c
0021h cmp ecx,7Fh                   ; CMP(Cmp_rm32_imm8) [ECX,7fh:imm32]                   encoding(3 bytes) = 83 f9 7f
0024h jg short 003dh                ; JG(Jg_rel8_64) [3Dh:jmp64]                           encoding(2 bytes) = 7f 17
0026h cmp ecx,0FFFFFF80h            ; CMP(Cmp_rm32_imm8) [ECX,ffffffffffffff80h:imm32]     encoding(3 bytes) = 83 f9 80
0029h jl short 003dh                ; JL(Jl_rel8_64) [3Dh:jmp64]                           encoding(2 bytes) = 7c 12
002bh add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
002fh jo short 003dh                ; JO(Jo_rel8_64) [3Dh:jmp64]                           encoding(2 bytes) = 70 0c
0031h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0034h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c de
0036h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0038h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003dh call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F658E40h:jmp64]                encoding(5 bytes) = e8 fe 8d 65 5f
0042h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> sumBytes => new byte[67]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x22,0x4D,0x63,0xC8,0x4E,0x0F,0xBE,0x0C,0x08,0x41,0x03,0xC9,0x70,0x1C,0x83,0xF9,0x7F,0x7F,0x17,0x83,0xF9,0x80,0x7C,0x12,0x41,0x83,0xC0,0x01,0x70,0x0C,0x44,0x3B,0xC2,0x7C,0xDE,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xFE,0x8D,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sum(ReadOnlySpan<byte> src)
; location: [7FFDDDBC5F70h, 7FFDDDBC5FB0h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 0034h               ; JLE(Jle_rel8_64) [34h:jmp64]                         encoding(2 bytes) = 7e 20
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h movzx r9d,byte ptr [rax+r9]   ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 46 0f b6 0c 08
001ch add ecx,r9d                   ; ADD(Add_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 03 c9
001fh jo short 003bh                ; JO(Jo_rel8_64) [3Bh:jmp64]                           encoding(2 bytes) = 70 1a
0021h cmp ecx,0FFh                  ; CMP(Cmp_rm32_imm32) [ECX,ffh:imm32]                  encoding(6 bytes) = 81 f9 ff 00 00 00
0027h ja short 003bh                ; JA(Ja_rel8_64) [3Bh:jmp64]                           encoding(2 bytes) = 77 12
0029h add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
002dh jo short 003bh                ; JO(Jo_rel8_64) [3Bh:jmp64]                           encoding(2 bytes) = 70 0c
002fh cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0032h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c e0
0034h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0036h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003bh call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F658DE0h:jmp64]                encoding(5 bytes) = e8 a0 8d 65 5f
0040h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> sumBytes => new byte[65]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x20,0x4D,0x63,0xC8,0x46,0x0F,0xB6,0x0C,0x08,0x41,0x03,0xC9,0x70,0x1A,0x81,0xF9,0xFF,0x00,0x00,0x00,0x77,0x12,0x41,0x83,0xC0,0x01,0x70,0x0C,0x44,0x3B,0xC2,0x7C,0xE0,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xA0,0x8D,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sum(ReadOnlySpan<short> src)
; location: [7FFDDDBC63D0h, 7FFDDDBC6418h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 003ch               ; JLE(Jle_rel8_64) [3Ch:jmp64]                         encoding(2 bytes) = 7e 28
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h movsx r9,word ptr [rax+r9*2]  ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,RAX:br,DS:sr)]     encoding(5 bytes) = 4e 0f bf 0c 48
001ch add ecx,r9d                   ; ADD(Add_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 03 c9
001fh jo short 0043h                ; JO(Jo_rel8_64) [43h:jmp64]                           encoding(2 bytes) = 70 22
0021h cmp ecx,7FFFh                 ; CMP(Cmp_rm32_imm32) [ECX,7fffh:imm32]                encoding(6 bytes) = 81 f9 ff 7f 00 00
0027h jg short 0043h                ; JG(Jg_rel8_64) [43h:jmp64]                           encoding(2 bytes) = 7f 1a
0029h cmp ecx,0FFFF8000h            ; CMP(Cmp_rm32_imm32) [ECX,ffff8000h:imm32]            encoding(6 bytes) = 81 f9 00 80 ff ff
002fh jl short 0043h                ; JL(Jl_rel8_64) [43h:jmp64]                           encoding(2 bytes) = 7c 12
0031h add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0035h jo short 0043h                ; JO(Jo_rel8_64) [43h:jmp64]                           encoding(2 bytes) = 70 0c
0037h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
003ah jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c d8
003ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
003eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0043h call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F658980h:jmp64]                encoding(5 bytes) = e8 38 89 65 5f
0048h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> sumBytes => new byte[73]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x28,0x4D,0x63,0xC8,0x4E,0x0F,0xBF,0x0C,0x48,0x41,0x03,0xC9,0x70,0x22,0x81,0xF9,0xFF,0x7F,0x00,0x00,0x7F,0x1A,0x81,0xF9,0x00,0x80,0xFF,0xFF,0x7C,0x12,0x41,0x83,0xC0,0x01,0x70,0x0C,0x44,0x3B,0xC2,0x7C,0xD8,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x38,0x89,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sum(ReadOnlySpan<ushort> src)
; location: [7FFDDDBC6430h, 7FFDDDBC6470h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 0034h               ; JLE(Jle_rel8_64) [34h:jmp64]                         encoding(2 bytes) = 7e 20
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h movzx r9d,word ptr [rax+r9*2] ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,RAX:br,DS:sr)]    encoding(5 bytes) = 46 0f b7 0c 48
001ch add ecx,r9d                   ; ADD(Add_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 03 c9
001fh jo short 003bh                ; JO(Jo_rel8_64) [3Bh:jmp64]                           encoding(2 bytes) = 70 1a
0021h cmp ecx,0FFFFh                ; CMP(Cmp_rm32_imm32) [ECX,ffffh:imm32]                encoding(6 bytes) = 81 f9 ff ff 00 00
0027h ja short 003bh                ; JA(Ja_rel8_64) [3Bh:jmp64]                           encoding(2 bytes) = 77 12
0029h add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
002dh jo short 003bh                ; JO(Jo_rel8_64) [3Bh:jmp64]                           encoding(2 bytes) = 70 0c
002fh cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0032h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c e0
0034h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0036h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003bh call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F658920h:jmp64]                encoding(5 bytes) = e8 e0 88 65 5f
0040h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> sumBytes => new byte[65]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x20,0x4D,0x63,0xC8,0x46,0x0F,0xB7,0x0C,0x48,0x41,0x03,0xC9,0x70,0x1A,0x81,0xF9,0xFF,0xFF,0x00,0x00,0x77,0x12,0x41,0x83,0xC0,0x01,0x70,0x0C,0x44,0x3B,0xC2,0x7C,0xE0,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xE0,0x88,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sum(ReadOnlySpan<int> src)
; location: [7FFDDDBC6490h, 7FFDDDBC64C4h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 0028h               ; JLE(Jle_rel8_64) [28h:jmp64]                         encoding(2 bytes) = 7e 14
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h add ecx,[rax+r9*4]            ; ADD(Add_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 42 03 0c 88
001bh jo short 002fh                ; JO(Jo_rel8_64) [2Fh:jmp64]                           encoding(2 bytes) = 70 12
001dh add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0021h jo short 002fh                ; JO(Jo_rel8_64) [2Fh:jmp64]                           encoding(2 bytes) = 70 0c
0023h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0026h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c ec
0028h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
002fh call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F6588C0h:jmp64]                encoding(5 bytes) = e8 8c 88 65 5f
0034h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> sumBytes => new byte[53]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x14,0x4D,0x63,0xC8,0x42,0x03,0x0C,0x88,0x70,0x12,0x41,0x83,0xC0,0x01,0x70,0x0C,0x44,0x3B,0xC2,0x7C,0xEC,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x8C,0x88,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sum(ReadOnlySpan<uint> src)
; location: [7FFDDDBC64E0h, 7FFDDDBC6514h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 0028h               ; JLE(Jle_rel8_64) [28h:jmp64]                         encoding(2 bytes) = 7e 14
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h add ecx,[rax+r9*4]            ; ADD(Add_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 42 03 0c 88
001bh jb short 002fh                ; JB(Jb_rel8_64) [2Fh:jmp64]                           encoding(2 bytes) = 72 12
001dh add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0021h jo short 002fh                ; JO(Jo_rel8_64) [2Fh:jmp64]                           encoding(2 bytes) = 70 0c
0023h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0026h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c ec
0028h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
002fh call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F658870h:jmp64]                encoding(5 bytes) = e8 3c 88 65 5f
0034h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> sumBytes => new byte[53]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x14,0x4D,0x63,0xC8,0x42,0x03,0x0C,0x88,0x72,0x12,0x41,0x83,0xC0,0x01,0x70,0x0C,0x44,0x3B,0xC2,0x7C,0xEC,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x3C,0x88,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sum(ReadOnlySpan<long> src)
; location: [7FFDDDBC6530h, 7FFDDDBC6565h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 0028h               ; JLE(Jle_rel8_64) [28h:jmp64]                         encoding(2 bytes) = 7e 14
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h add rcx,[rax+r9*8]            ; ADD(Add_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(4 bytes) = 4a 03 0c c8
001bh jo short 0030h                ; JO(Jo_rel8_64) [30h:jmp64]                           encoding(2 bytes) = 70 13
001dh add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0021h jo short 0030h                ; JO(Jo_rel8_64) [30h:jmp64]                           encoding(2 bytes) = 70 0d
0023h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0026h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c ec
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0030h call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F658820h:jmp64]                encoding(5 bytes) = e8 eb 87 65 5f
0035h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> sumBytes => new byte[54]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x14,0x4D,0x63,0xC8,0x4A,0x03,0x0C,0xC8,0x70,0x13,0x41,0x83,0xC0,0x01,0x70,0x0D,0x44,0x3B,0xC2,0x7C,0xEC,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xEB,0x87,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sum(ReadOnlySpan<ulong> src)
; location: [7FFDDDBC6580h, 7FFDDDBC65B5h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 0028h               ; JLE(Jle_rel8_64) [28h:jmp64]                         encoding(2 bytes) = 7e 14
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h add rcx,[rax+r9*8]            ; ADD(Add_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(4 bytes) = 4a 03 0c c8
001bh jb short 0030h                ; JB(Jb_rel8_64) [30h:jmp64]                           encoding(2 bytes) = 72 13
001dh add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0021h jo short 0030h                ; JO(Jo_rel8_64) [30h:jmp64]                           encoding(2 bytes) = 70 0d
0023h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0026h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c ec
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0030h call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F6587D0h:jmp64]                encoding(5 bytes) = e8 9b 87 65 5f
0035h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> sumBytes => new byte[54]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x14,0x4D,0x63,0xC8,0x4A,0x03,0x0C,0xC8,0x72,0x13,0x41,0x83,0xC0,0x01,0x70,0x0D,0x44,0x3B,0xC2,0x7C,0xEC,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x9B,0x87,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float sum(ReadOnlySpan<float> src)
; location: [7FFDDDBC69E0h, 7FFDDDBC6A13h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000ah mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000dh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0011h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0013h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0015h jle short 0029h               ; JLE(Jle_rel8_64) [29h:jmp64]                         encoding(2 bytes) = 7e 12
0017h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
001ah vaddss xmm0,xmm0,dword ptr [rax+r8*4]; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,mem(Float32,RAX:br,DS:sr)] encoding(VEX, 6 bytes) = c4 a1 7a 58 04 80
0020h add ecx,1                     ; ADD(Add_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 c1 01
0023h jo short 002eh                ; JO(Jo_rel8_64) [2Eh:jmp64]                           encoding(2 bytes) = 70 09
0025h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0027h jl short 0017h                ; JL(Jl_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7c ee
0029h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
002eh call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F658370h:jmp64]                encoding(5 bytes) = e8 3d 83 65 5f
0033h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> sumBytes => new byte[52]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x8B,0x51,0x08,0xC5,0xF8,0x57,0xC0,0x33,0xC9,0x85,0xD2,0x7E,0x12,0x4C,0x63,0xC1,0xC4,0xA1,0x7A,0x58,0x04,0x80,0x83,0xC1,0x01,0x70,0x09,0x3B,0xCA,0x7C,0xEE,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x3D,0x83,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double sum(ReadOnlySpan<double> src)
; location: [7FFDDDBC6A30h, 7FFDDDBC6A63h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000ah mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000dh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0011h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0013h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0015h jle short 0029h               ; JLE(Jle_rel8_64) [29h:jmp64]                         encoding(2 bytes) = 7e 12
0017h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
001ah vaddsd xmm0,xmm0,qword ptr [rax+r8*8]; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,mem(Float64,RAX:br,DS:sr)] encoding(VEX, 6 bytes) = c4 a1 7b 58 04 c0
0020h add ecx,1                     ; ADD(Add_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 c1 01
0023h jo short 002eh                ; JO(Jo_rel8_64) [2Eh:jmp64]                           encoding(2 bytes) = 70 09
0025h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0027h jl short 0017h                ; JL(Jl_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7c ee
0029h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
002eh call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F658320h:jmp64]                encoding(5 bytes) = e8 ed 82 65 5f
0033h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> sumBytes => new byte[52]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x8B,0x51,0x08,0xC5,0xF8,0x57,0xC0,0x33,0xC9,0x85,0xD2,0x7E,0x12,0x4C,0x63,0xC1,0xC4,0xA1,0x7B,0x58,0x04,0xC0,0x83,0xC1,0x01,0x70,0x09,0x3B,0xCA,0x7C,0xEE,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xED,0x82,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool within(byte lhs, byte rhs, byte epsilon)
; location: [7FFDDDBC6A80h, 7FFDDDBC6AACh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
000dh jg short 001eh                ; JG(Jg_rel8_64) [1Eh:jmp64]                           encoding(2 bytes) = 7f 0f
000fh sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
0011h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0015h cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
0017h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001eh sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0020h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0024h cmp ecx,eax                   ; CMP(Cmp_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 3b c8
0026h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0029h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> withinBytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0x3B,0xCA,0x7F,0x0F,0x2B,0xD1,0x41,0x0F,0xB6,0xC0,0x3B,0xD0,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3,0x2B,0xCA,0x41,0x0F,0xB6,0xC0,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool within(sbyte lhs, sbyte rhs, sbyte epsilon)
; location: [7FFDDDBC6AC0h, 7FFDDDBC6AEEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
000fh jg short 0020h                ; JG(Jg_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 7f 0f
0011h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
0013h movsx rax,r8b                 ; MOVSX(Movsx_r64_rm8) [RAX,R8L]                       encoding(4 bytes) = 49 0f be c0
0017h cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
0019h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0020h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0022h movsx rax,r8b                 ; MOVSX(Movsx_r64_rm8) [RAX,R8L]                       encoding(4 bytes) = 49 0f be c0
0026h cmp ecx,eax                   ; CMP(Cmp_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 3b c8
0028h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> withinBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC9,0x48,0x0F,0xBE,0xD2,0x3B,0xCA,0x7F,0x0F,0x2B,0xD1,0x49,0x0F,0xBE,0xC0,0x3B,0xD0,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3,0x2B,0xCA,0x49,0x0F,0xBE,0xC0,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool within(short lhs, short rhs, short epsilon)
; location: [7FFDDDBC6B00h, 7FFDDDBC6B2Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
000fh jg short 0020h                ; JG(Jg_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 7f 0f
0011h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
0013h movsx rax,r8w                 ; MOVSX(Movsx_r64_rm16) [RAX,R8W]                      encoding(4 bytes) = 49 0f bf c0
0017h cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
0019h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0020h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0022h movsx rax,r8w                 ; MOVSX(Movsx_r64_rm16) [RAX,R8W]                      encoding(4 bytes) = 49 0f bf c0
0026h cmp ecx,eax                   ; CMP(Cmp_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 3b c8
0028h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> withinBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC9,0x48,0x0F,0xBF,0xD2,0x3B,0xCA,0x7F,0x0F,0x2B,0xD1,0x49,0x0F,0xBF,0xC0,0x3B,0xD0,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3,0x2B,0xCA,0x49,0x0F,0xBF,0xC0,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool within(ushort lhs, ushort rhs, ushort epsilon)
; location: [7FFDDDBC6B40h, 7FFDDDBC6B6Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
000dh jg short 001eh                ; JG(Jg_rel8_64) [1Eh:jmp64]                           encoding(2 bytes) = 7f 0f
000fh sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
0011h movzx eax,r8w                 ; MOVZX(Movzx_r32_rm16) [EAX,R8W]                      encoding(4 bytes) = 41 0f b7 c0
0015h cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
0017h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001eh sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0020h movzx eax,r8w                 ; MOVZX(Movzx_r32_rm16) [EAX,R8W]                      encoding(4 bytes) = 41 0f b7 c0
0024h cmp ecx,eax                   ; CMP(Cmp_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 3b c8
0026h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0029h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> withinBytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC9,0x0F,0xB7,0xD2,0x3B,0xCA,0x7F,0x0F,0x2B,0xD1,0x41,0x0F,0xB7,0xC0,0x3B,0xD0,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3,0x2B,0xCA,0x41,0x0F,0xB7,0xC0,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool within(int lhs, int rhs, int epsilon)
; location: [7FFDDDBC6B80h, 7FFDDDBC6BA0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jg short 0015h                ; JG(Jg_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 7f 0c
0009h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
000bh cmp edx,r8d                   ; CMP(Cmp_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 3b d0
000eh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0015h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0017h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
001ah setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> withinBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7F,0x0C,0x2B,0xD1,0x41,0x3B,0xD0,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3,0x2B,0xCA,0x41,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool within(uint lhs, uint rhs, uint epsilon)
; location: [7FFDDDBC6BC0h, 7FFDDDBC6BE0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h ja short 0015h                ; JA(Ja_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 77 0c
0009h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
000bh cmp edx,r8d                   ; CMP(Cmp_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 3b d0
000eh setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0015h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0017h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
001ah setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> withinBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x77,0x0C,0x2B,0xD1,0x41,0x3B,0xD0,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3,0x2B,0xCA,0x41,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool within(long lhs, long rhs, long epsilon)
; location: [7FFDDDBC6C00h, 7FFDDDBC6C23h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jg short 0017h                ; JG(Jg_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7f 0d
000ah sub rdx,rcx                   ; SUB(Sub_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 2b d1
000dh cmp rdx,r8                    ; CMP(Cmp_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 3b d0
0010h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0017h sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
001ah cmp rcx,r8                    ; CMP(Cmp_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 3b c8
001dh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> withinBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7F,0x0D,0x48,0x2B,0xD1,0x49,0x3B,0xD0,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3,0x48,0x2B,0xCA,0x49,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool within(ulong lhs, ulong rhs, ulong epsilon)
; location: [7FFDDDBC6C40h, 7FFDDDBC6C63h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h ja short 0017h                ; JA(Ja_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 77 0d
000ah sub rdx,rcx                   ; SUB(Sub_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 2b d1
000dh cmp rdx,r8                    ; CMP(Cmp_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 3b d0
0010h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0017h sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
001ah cmp rcx,r8                    ; CMP(Cmp_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 3b c8
001dh setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> withinBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x77,0x0D,0x48,0x2B,0xD1,0x49,0x3B,0xD0,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3,0x48,0x2B,0xCA,0x49,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool within(float lhs, float rhs, float epsilon)
; location: [7FFDDDBC6C80h, 7FFDDDBC6CA8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h ja short 001ah                ; JA(Ja_rel8_64) [1Ah:jmp64]                           encoding(2 bytes) = 77 0f
000bh vsubss xmm1,xmm1,xmm0         ; VSUBSS(VEX_Vsubss_xmm_xmm_xmmm32) [XMM1,XMM1,XMM0]   encoding(VEX, 4 bytes) = c5 f2 5c c8
000fh vucomiss xmm2,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM2,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e d1
0013h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001ah vsubss xmm0,xmm0,xmm1         ; VSUBSS(VEX_Vsubss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5c c1
001eh vucomiss xmm2,xmm0            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM2,XMM0]        encoding(VEX, 4 bytes) = c5 f8 2e d0
0022h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> withinBytes => new byte[41]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x77,0x0F,0xC5,0xF2,0x5C,0xC8,0xC5,0xF8,0x2E,0xD1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3,0xC5,0xFA,0x5C,0xC1,0xC5,0xF8,0x2E,0xD0,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool within(double lhs, double rhs, double epsilon)
; location: [7FFDDDBC6CC0h, 7FFDDDBC6CE8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h ja short 001ah                ; JA(Ja_rel8_64) [1Ah:jmp64]                           encoding(2 bytes) = 77 0f
000bh vsubsd xmm1,xmm1,xmm0         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM0]   encoding(VEX, 4 bytes) = c5 f3 5c c8
000fh vucomisd xmm2,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM2,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e d1
0013h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001ah vsubsd xmm0,xmm0,xmm1         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5c c1
001eh vucomisd xmm2,xmm0            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM2,XMM0]        encoding(VEX, 4 bytes) = c5 f9 2e d0
0022h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> withinBytes => new byte[41]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x77,0x0F,0xC5,0xF3,0x5C,0xC8,0xC5,0xF9,0x2E,0xD1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3,0xC5,0xFB,0x5C,0xC1,0xC5,0xF9,0x2E,0xD0,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte width(byte lhs, byte rhs)
; location: [7FFDDDBC6D00h, 7FFDDDBC6D1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jg short 0013h                ; JG(Jg_rel8_64) [13h:jmp64]                           encoding(2 bytes) = 7f 04
000fh sub edx,eax                   ; SUB(Sub_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 2b d0
0011h jmp short 0017h               ; JMP(Jmp_rel8_64) [17h:jmp64]                         encoding(2 bytes) = eb 04
0013h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0015h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0017h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x7F,0x04,0x2B,0xD0,0xEB,0x04,0x2B,0xC2,0x8B,0xD0,0x0F,0xB6,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort width(sbyte lhs, sbyte rhs)
; location: [7FFDDDBC6D30h, 7FFDDDBC6D4Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jg short 0015h                ; JG(Jg_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 7f 04
0011h sub edx,eax                   ; SUB(Sub_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 2b d0
0013h jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 04
0015h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0017h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0019h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7F,0x04,0x2B,0xD0,0xEB,0x04,0x2B,0xC2,0x8B,0xD0,0x0F,0xB7,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint width(short lhs, short rhs)
; location: [7FFDDDBC6D60h, 7FFDDDBC6D78h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000fh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0011h sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
0014h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0016h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x48,0x0F,0xBF,0xD1,0x2B,0xC2,0x8B,0xD0,0xC1,0xFA,0x1F,0x03,0xC2,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong width(int lhs, int rhs)
; location: [7FFDDDBC6D90h, 7FFDDDBC6DABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0008h movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
000bh sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000eh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0011h sar rdx,3Fh                   ; SAR(Sar_rm64_imm8) [RDX,3fh:imm8]                    encoding(4 bytes) = 48 c1 fa 3f
0015h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0018h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x63,0xD1,0x48,0x2B,0xC2,0x48,0x8B,0xD0,0x48,0xC1,0xFA,0x3F,0x48,0x03,0xC2,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong width(long lhs, long rhs)
; location: [7FFDDDBC6DC0h, 7FFDDDBC6DD5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub rdx,rcx                   ; SUB(Sub_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 2b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh sar rax,3Fh                   ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f8 3f
000fh add rdx,rax                   ; ADD(Add_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 03 d0
0012h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x2B,0xD1,0x48,0x8B,0xC2,0x48,0xC1,0xF8,0x3F,0x48,0x03,0xD0,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort width(ushort lhs, ushort rhs)
; location: [7FFDDDBC6DF0h, 7FFDDDBC6E0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jg short 0013h                ; JG(Jg_rel8_64) [13h:jmp64]                           encoding(2 bytes) = 7f 04
000fh sub edx,eax                   ; SUB(Sub_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 2b d0
0011h jmp short 0017h               ; JMP(Jmp_rel8_64) [17h:jmp64]                         encoding(2 bytes) = eb 04
0013h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0015h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0017h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x7F,0x04,0x2B,0xD0,0xEB,0x04,0x2B,0xC2,0x8B,0xD0,0x0F,0xB7,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint width(uint lhs, uint rhs)
; location: [7FFDDDBC6E20h, 7FFDDDBC6E32h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h ja short 000eh                ; JA(Ja_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 77 05
0009h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000bh sub eax,ecx                   ; SUB(Sub_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 2b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000eh sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0010h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x77,0x05,0x8B,0xC2,0x2B,0xC1,0xC3,0x2B,0xCA,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong width(ulong lhs, ulong rhs)
; location: [7FFDDDBC6E50h, 7FFDDDBC6E67h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h ja short 0011h                ; JA(Ja_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 77 07
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh sub rax,rcx                   ; SUB(Sub_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 2b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0011h sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
0014h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x77,0x07,0x48,0x8B,0xC2,0x48,0x2B,0xC1,0xC3,0x48,0x2B,0xCA,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double width(float lhs, float rhs)
; location: [7FFDDDBC6E80h, 7FFDDDBC6E9Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvtss2sd xmm1,xmm1,xmm1      ; VCVTSS2SD(VEX_Vcvtss2sd_xmm_xmm_xmmm32) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f2 5a c9
0009h vcvtss2sd xmm0,xmm0,xmm0      ; VCVTSS2SD(VEX_Vcvtss2sd_xmm_xmm_xmmm32) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fa 5a c0
000dh vsubsd xmm1,xmm1,xmm0         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM0]   encoding(VEX, 4 bytes) = c5 f3 5c c8
0011h vmovsd xmm0,qword ptr [7FFDDDBC6EA8h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 0f 00 00 00
0019h vandps xmm0,xmm0,xmm1         ; VANDPS(VEX_Vandps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 54 c1
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF2,0x5A,0xC9,0xC5,0xFA,0x5A,0xC0,0xC5,0xF3,0x5C,0xC8,0xC5,0xFB,0x10,0x05,0x0F,0x00,0x00,0x00,0xC5,0xF8,0x54,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double width(double lhs, double rhs)
; location: [7FFDDDBC6EC0h, 7FFDDDBC6ED5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vsubsd xmm1,xmm1,xmm0         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM0]   encoding(VEX, 4 bytes) = c5 f3 5c c8
0009h vmovsd xmm0,qword ptr [7FFDDDBC6EE0h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 0f 00 00 00
0011h vandps xmm0,xmm0,xmm1         ; VANDPS(VEX_Vandps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 54 c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF3,0x5C,0xC8,0xC5,0xFB,0x10,0x05,0x0F,0x00,0x00,0x00,0xC5,0xF8,0x54,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xor(sbyte lhs, sbyte rhs)
; location: [7FFDDDBC6F00h, 7FFDDDBC6F13h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xor(byte lhs, byte rhs)
; location: [7FFDDDBC6F30h, 7FFDDDBC6F40h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xor(short lhs, short rhs)
; location: [7FFDDDBC6F60h, 7FFDDDBC6F73h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xor(ushort lhs, ushort rhs)
; location: [7FFDDDBC6F90h, 7FFDDDBC6FA0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xor(int lhs, int rhs)
; location: [7FFDDDBC6FC0h, 7FFDDDBC6FC9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xor(uint lhs, uint rhs)
; location: [7FFDDDBC6FE0h, 7FFDDDBC6FE9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xor(long lhs, long rhs)
; location: [7FFDDDBC7000h, 7FFDDDBC700Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor(ulong lhs, ulong rhs)
; location: [7FFDDDBC7020h, 7FFDDDBC702Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte xor(ref sbyte lhs, sbyte rhs)
; location: [7FFDDDBC7040h, 7FFDDDBC704Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h xor [rcx],al                  ; XOR(Xor_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 30 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x30,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte xor(ref byte lhs, byte rhs)
; location: [7FFDDDBC7060h, 7FFDDDBC706Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h xor [rcx],al                  ; XOR(Xor_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 30 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x30,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short xor(ref short lhs, short rhs)
; location: [7FFDDDBC7080h, 7FFDDDBC708Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h xor [rcx],ax                  ; XOR(Xor_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 31 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x66,0x31,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort xor(ref ushort lhs, ushort rhs)
; location: [7FFDDDBC70A0h, 7FFDDDBC70AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h xor [rcx],ax                  ; XOR(Xor_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 31 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x66,0x31,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int xor(ref int lhs, int rhs)
; location: [7FFDDDBC70C0h, 7FFDDDBC70CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor [rcx],edx                 ; XOR(Xor_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 31 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x31,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint xor(ref uint lhs, uint rhs)
; location: [7FFDDDBC70E0h, 7FFDDDBC70EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor [rcx],edx                 ; XOR(Xor_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 31 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x31,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long xor(ref long lhs, long rhs)
; location: [7FFDDDBC7100h, 7FFDDDBC710Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor [rcx],rdx                 ; XOR(Xor_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 31 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x31,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong xor(ref ulong lhs, ulong rhs)
; location: [7FFDDDBC7120h, 7FFDDDBC712Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor [rcx],rdx                 ; XOR(Xor_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 31 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x31,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte xor(in sbyte lhs, in sbyte rhs, ref sbyte dst)
; location: [7FFDDDBC7140h, 7FFDDDBC7155h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h movsx rdx,byte ptr [rdx]      ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RDX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 12
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0012h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x48,0x0F,0xBE,0x12,0x33,0xC2,0x41,0x88,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte xor(in byte lhs, in byte rhs, ref byte dst)
; location: [7FFDDDBC7170h, 7FFDDDBC7183h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h movzx edx,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RDX:br,DS:sr)]      encoding(3 bytes) = 0f b6 12
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0010h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x0F,0xB6,0x12,0x33,0xC2,0x41,0x88,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short xor(in short lhs, in short rhs, ref short dst)
; location: [7FFDDDBC71A0h, 7FFDDDBC71B6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h movsx rdx,word ptr [rdx]      ; MOVSX(Movsx_r64_rm16) [RDX,mem(16i,RDX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 12
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),AX]          encoding(4 bytes) = 66 41 89 00
0013h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x48,0x0F,0xBF,0x12,0x33,0xC2,0x66,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort xor(in ushort lhs, in ushort rhs, ref ushort dst)
; location: [7FFDDDBC71D0h, 7FFDDDBC71E4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h movzx edx,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EDX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 12
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),AX]          encoding(4 bytes) = 66 41 89 00
0011h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x0F,0xB7,0x12,0x33,0xC2,0x66,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int xor(in int lhs, in int rhs, ref int dst)
; location: [7FFDDDBC7200h, 7FFDDDBC720Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h xor eax,[rdx]                 ; XOR(Xor_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 33 02
0009h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x33,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint xor(in uint lhs, in uint rhs, ref uint dst)
; location: [7FFDDDBC7220h, 7FFDDDBC722Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h xor eax,[rdx]                 ; XOR(Xor_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 33 02
0009h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x33,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long xor(in long lhs, in long rhs, ref long dst)
; location: [7FFDDDBC7240h, 7FFDDDBC7251h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h xor rax,[rdx]                 ; XOR(Xor_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 33 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x33,0x02,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong xor(in ulong lhs, in ulong rhs, ref ulong dst)
; location: [7FFDDDBC7270h, 7FFDDDBC7281h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h xor rax,[rdx]                 ; XOR(Xor_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 33 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x33,0x02,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float xor(in float lhs, in float rhs, ref float dst)
; location: [7FFDDDBC7630h, 7FFDDDBC7669h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
000bh vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
0011h mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0015h vmovss xmm0,dword ptr [rdx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 02
0019h vmovss dword ptr [rsp+10h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 10
001fh xor eax,[rsp+10h]             ; XOR(Xor_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 33 44 24 10
0023h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0027h vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
002dh vmovss dword ptr [r8],xmm0    ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 11 00
0032h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0035h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[58]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x10,0x02,0xC5,0xFA,0x11,0x44,0x24,0x10,0x33,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0xC4,0xC1,0x7A,0x11,0x00,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double xor(in double lhs, in double rhs, ref double dst)
; location: [7FFDDDBC7690h, 7FFDDDBC76CAh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
000bh vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0011h mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0016h vmovsd xmm0,qword ptr [rdx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 02
001ah vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
0020h xor rax,[rsp+8]               ; XOR(Xor_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 33 44 24 08
0025h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0029h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
002eh vmovsd qword ptr [r8],xmm0    ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7b 11 00
0033h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0036h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[59]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x10,0x02,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x33,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0xC4,0xC1,0x7B,0x11,0x00,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long or(long lhs, long rhs)
; location: [7FFDDDBC76F0h, 7FFDDDBC76FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong or(ulong lhs, ulong rhs)
; location: [7FFDDDBC7710h, 7FFDDDBC771Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float or(float lhs, float rhs)
; location: [7FFDDDBC7730h, 7FFDDDBC7759h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h or eax,[rsp+10h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 44 24 10
001bh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x0B,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double or(double lhs, double rhs)
; location: [7FFDDDBC7780h, 7FFDDDBC77AAh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
001dh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte or(ref sbyte lhs, sbyte rhs)
; location: [7FFDDDBC77D0h, 7FFDDDBC77DEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h or [rcx],al                   ; OR(Or_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]              encoding(2 bytes) = 08 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x08,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte or(ref byte lhs, byte rhs)
; location: [7FFDDDBC77F0h, 7FFDDDBC77FDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h or [rcx],al                   ; OR(Or_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]              encoding(2 bytes) = 08 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x08,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short or(ref short lhs, short rhs)
; location: [7FFDDDBC7810h, 7FFDDDBC781Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h or [rcx],ax                   ; OR(Or_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]           encoding(3 bytes) = 66 09 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x66,0x09,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort or(ref ushort lhs, ushort rhs)
; location: [7FFDDDBC7830h, 7FFDDDBC783Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h or [rcx],ax                   ; OR(Or_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]           encoding(3 bytes) = 66 09 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x66,0x09,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int or(ref int lhs, int rhs)
; location: [7FFDDDBC7850h, 7FFDDDBC785Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or [rcx],edx                  ; OR(Or_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]          encoding(2 bytes) = 09 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x09,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint or(ref uint lhs, uint rhs)
; location: [7FFDDDBC7870h, 7FFDDDBC787Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or [rcx],edx                  ; OR(Or_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]          encoding(2 bytes) = 09 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x09,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long or(ref long lhs, long rhs)
; location: [7FFDDDBC7890h, 7FFDDDBC789Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or [rcx],rdx                  ; OR(Or_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x09,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong or(ref ulong lhs, ulong rhs)
; location: [7FFDDDBC78B0h, 7FFDDDBC78BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or [rcx],rdx                  ; OR(Or_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x09,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float or(ref float lhs, float rhs)
; location: [7FFDDDBC78D0h, 7FFDDDBC7904h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
000bh vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
0011h mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0015h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
001bh or eax,[rsp+10h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 44 24 10
001fh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0023h vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0029h vmovss dword ptr [rcx],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[53]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x0B,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0xC5,0xFA,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double or(ref double lhs, double rhs)
; location: [7FFDDDBC7920h, 7FFDDDBC7955h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
000bh vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0011h mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0016h vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
001ch or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
0021h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0025h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
002ah vmovsd qword ptr [rcx],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 01
002eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0031h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[54]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0xC5,0xFB,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte or(in sbyte lhs, in sbyte rhs, ref sbyte dst)
; location: [7FFDDDBC7970h, 7FFDDDBC7985h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h movsx rdx,byte ptr [rdx]      ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RDX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 12
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0012h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x48,0x0F,0xBE,0x12,0x0B,0xC2,0x41,0x88,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte or(in byte lhs, in byte rhs, ref byte dst)
; location: [7FFDDDBC79A0h, 7FFDDDBC79B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h movzx edx,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RDX:br,DS:sr)]      encoding(3 bytes) = 0f b6 12
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0010h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x0F,0xB6,0x12,0x0B,0xC2,0x41,0x88,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short or(in short lhs, in short rhs, ref short dst)
; location: [7FFDDDBC79D0h, 7FFDDDBC79E6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h movsx rdx,word ptr [rdx]      ; MOVSX(Movsx_r64_rm16) [RDX,mem(16i,RDX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 12
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),AX]          encoding(4 bytes) = 66 41 89 00
0013h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x48,0x0F,0xBF,0x12,0x0B,0xC2,0x66,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort or(in ushort lhs, in ushort rhs, ref ushort dst)
; location: [7FFDDDBC7A00h, 7FFDDDBC7A14h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h movzx edx,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EDX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 12
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),AX]          encoding(4 bytes) = 66 41 89 00
0011h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x0F,0xB7,0x12,0x0B,0xC2,0x66,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int or(in int lhs, in int rhs, ref int dst)
; location: [7FFDDDBC7A30h, 7FFDDDBC7A3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h or eax,[rdx]                  ; OR(Or_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]          encoding(2 bytes) = 0b 02
0009h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x0B,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint or(in uint lhs, in uint rhs, ref uint dst)
; location: [7FFDDDBC7A50h, 7FFDDDBC7A5Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h or eax,[rdx]                  ; OR(Or_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]          encoding(2 bytes) = 0b 02
0009h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x0B,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long or(in long lhs, in long rhs, ref long dst)
; location: [7FFDDDBC7A70h, 7FFDDDBC7A81h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h or rax,[rdx]                  ; OR(Or_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]          encoding(3 bytes) = 48 0b 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x0B,0x02,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong or(in ulong lhs, in ulong rhs, ref ulong dst)
; location: [7FFDDDBC7AA0h, 7FFDDDBC7AB1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h or rax,[rdx]                  ; OR(Or_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]          encoding(3 bytes) = 48 0b 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x0B,0x02,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float or(in float lhs, in float rhs, ref float dst)
; location: [7FFDDDBC7AD0h, 7FFDDDBC7B09h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
000bh vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
0011h mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0015h vmovss xmm0,dword ptr [rdx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 02
0019h vmovss dword ptr [rsp+10h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 10
001fh or eax,[rsp+10h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 44 24 10
0023h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0027h vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
002dh vmovss dword ptr [r8],xmm0    ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 11 00
0032h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0035h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[58]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x10,0x02,0xC5,0xFA,0x11,0x44,0x24,0x10,0x0B,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0xC4,0xC1,0x7A,0x11,0x00,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double or(in double lhs, in double rhs, ref double dst)
; location: [7FFDDDBC7B30h, 7FFDDDBC7B6Ah]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
000bh vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0011h mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0016h vmovsd xmm0,qword ptr [rdx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 02
001ah vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
0020h or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
0025h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0029h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
002eh vmovsd qword ptr [r8],xmm0    ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7b 11 00
0033h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0036h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[59]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x10,0x02,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0xC4,0xC1,0x7B,0x11,0x00,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte parse(string src, out sbyte dst)
; location: [7FFDDDBC7B90h, 7FFDDDBC7C26h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+38h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 38
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
0018h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
001bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
001eh je short 0076h                ; JE(Je_rel8_64) [76h:jmp64]                           encoding(2 bytes) = 74 56
0020h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 79 0c
0024h mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 59 08
0027h call 7FFE37EDB590h            ; CALL(Call_rel32_64) [5A313A00h:jmp64]                encoding(5 bytes) = e8 d4 39 31 5a
002ch mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002fh lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0034h mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0037h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
003ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
003fh lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
0044h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0049h call 7FFE37ECC710h            ; CALL(Call_rel32_64) [5A304B80h:jmp64]                encoding(5 bytes) = e8 32 4b 30 5a
004eh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0050h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0052h jne short 0081h               ; JNE(Jne_rel8_64) [81h:jmp64]                         encoding(2 bytes) = 75 2d
0054h mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
0058h add eax,80h                   ; ADD(Add_EAX_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = 05 80 00 00 00
005dh cmp eax,0FFh                  ; CMP(Cmp_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 3d ff 00 00 00
0062h ja short 008ch                ; JA(Ja_rel8_64) [8Ch:jmp64]                           encoding(2 bytes) = 77 28
0064h mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
0068h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
006ch mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]            encoding(2 bytes) = 88 06
006eh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0072h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0073h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0074h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0075h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0076h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
007bh call 7FFDDD617478h            ; CALL(Call_rel32_64) [FFFFFFFFFFA4F8E8h:jmp64]        encoding(5 bytes) = e8 68 f8 a4 ff
0080h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0081h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0086h call 7FFDDD622A68h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AED8h:jmp64]        encoding(5 bytes) = e8 4d ae a5 ff
008bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
008ch mov ecx,5                     ; MOV(Mov_r32_imm32) [ECX,5h:imm32]                    encoding(5 bytes) = b9 05 00 00 00
0091h call 7FFDDD622A70h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AEE0h:jmp64]        encoding(5 bytes) = e8 4a ae a5 ff
0096h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[151]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x56,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xD4,0x39,0x31,0x5A,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0x32,0x4B,0x30,0x5A,0x8B,0xC8,0x85,0xC9,0x75,0x2D,0x8B,0x44,0x24,0x38,0x05,0x80,0x00,0x00,0x00,0x3D,0xFF,0x00,0x00,0x00,0x77,0x28,0x8B,0x44,0x24,0x38,0x48,0x0F,0xBE,0xC0,0x88,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x68,0xF8,0xA4,0xFF,0xCC,0xBA,0x05,0x00,0x00,0x00,0xE8,0x4D,0xAE,0xA5,0xFF,0xCC,0xB9,0x05,0x00,0x00,0x00,0xE8,0x4A,0xAE,0xA5,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte parse(string src, out byte dst)
; location: [7FFDDDBC7C40h, 7FFDDDBC7CCFh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+38h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 38
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
0018h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
001bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
001eh je short 006fh                ; JE(Je_rel8_64) [6Fh:jmp64]                           encoding(2 bytes) = 74 4f
0020h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 79 0c
0024h mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 59 08
0027h call 7FFE37EDB590h            ; CALL(Call_rel32_64) [5A313950h:jmp64]                encoding(5 bytes) = e8 24 39 31 5a
002ch mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002fh lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0034h mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0037h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
003ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
003fh lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
0044h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0049h call 7FFDDD6229D0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AD90h:jmp64]        encoding(5 bytes) = e8 42 ad a5 ff
004eh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0050h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0052h jne short 007ah               ; JNE(Jne_rel8_64) [7Ah:jmp64]                         encoding(2 bytes) = 75 26
0054h cmp dword ptr [rsp+38h],0FFh  ; CMP(Cmp_rm32_imm32) [mem(32u,RSP:br,SS:sr),ffh:imm32] encoding(8 bytes) = 81 7c 24 38 ff 00 00 00
005ch ja short 0085h                ; JA(Ja_rel8_64) [85h:jmp64]                           encoding(2 bytes) = 77 27
005eh mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
0062h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0065h mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]            encoding(2 bytes) = 88 06
0067h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
006bh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
006ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006dh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
006eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
006fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0074h call 7FFDDD617478h            ; CALL(Call_rel32_64) [FFFFFFFFFFA4F838h:jmp64]        encoding(5 bytes) = e8 bf f7 a4 ff
0079h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007ah mov edx,6                     ; MOV(Mov_r32_imm32) [EDX,6h:imm32]                    encoding(5 bytes) = ba 06 00 00 00
007fh call 7FFDDD622A68h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AE28h:jmp64]        encoding(5 bytes) = e8 a4 ad a5 ff
0084h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0085h mov ecx,6                     ; MOV(Mov_r32_imm32) [ECX,6h:imm32]                    encoding(5 bytes) = b9 06 00 00 00
008ah call 7FFDDD622A70h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AE30h:jmp64]        encoding(5 bytes) = e8 a1 ad a5 ff
008fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[144]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x4F,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x24,0x39,0x31,0x5A,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0x42,0xAD,0xA5,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x26,0x81,0x7C,0x24,0x38,0xFF,0x00,0x00,0x00,0x77,0x27,0x8B,0x44,0x24,0x38,0x0F,0xB6,0xC0,0x88,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xBF,0xF7,0xA4,0xFF,0xCC,0xBA,0x06,0x00,0x00,0x00,0xE8,0xA4,0xAD,0xA5,0xFF,0xCC,0xB9,0x06,0x00,0x00,0x00,0xE8,0xA1,0xAD,0xA5,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short parse(string src, out short dst)
; location: [7FFDDDBC7CF0h, 7FFDDDBC7D87h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+38h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 38
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
0018h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
001bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
001eh je short 0077h                ; JE(Je_rel8_64) [77h:jmp64]                           encoding(2 bytes) = 74 57
0020h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 79 0c
0024h mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 59 08
0027h call 7FFE37EDB590h            ; CALL(Call_rel32_64) [5A3138A0h:jmp64]                encoding(5 bytes) = e8 74 38 31 5a
002ch mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002fh lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0034h mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0037h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
003ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
003fh lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
0044h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0049h call 7FFE37ECC710h            ; CALL(Call_rel32_64) [5A304A20h:jmp64]                encoding(5 bytes) = e8 d2 49 30 5a
004eh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0050h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0052h jne short 0082h               ; JNE(Jne_rel8_64) [82h:jmp64]                         encoding(2 bytes) = 75 2e
0054h mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
0058h add eax,8000h                 ; ADD(Add_EAX_imm32) [EAX,8000h:imm32]                 encoding(5 bytes) = 05 00 80 00 00
005dh cmp eax,0FFFFh                ; CMP(Cmp_EAX_imm32) [EAX,ffffh:imm32]                 encoding(5 bytes) = 3d ff ff 00 00
0062h ja short 008dh                ; JA(Ja_rel8_64) [8Dh:jmp64]                           encoding(2 bytes) = 77 29
0064h mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
0068h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
006ch mov [rsi],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSI:br,DS:sr),AX]         encoding(3 bytes) = 66 89 06
006fh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0073h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0074h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0075h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0076h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0077h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
007ch call 7FFDDD617478h            ; CALL(Call_rel32_64) [FFFFFFFFFFA4F788h:jmp64]        encoding(5 bytes) = e8 07 f7 a4 ff
0081h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0082h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0087h call 7FFDDD622A68h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AD78h:jmp64]        encoding(5 bytes) = e8 ec ac a5 ff
008ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
008dh mov ecx,7                     ; MOV(Mov_r32_imm32) [ECX,7h:imm32]                    encoding(5 bytes) = b9 07 00 00 00
0092h call 7FFDDD622A70h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AD80h:jmp64]        encoding(5 bytes) = e8 e9 ac a5 ff
0097h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[152]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x57,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x74,0x38,0x31,0x5A,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0xD2,0x49,0x30,0x5A,0x8B,0xC8,0x85,0xC9,0x75,0x2E,0x8B,0x44,0x24,0x38,0x05,0x00,0x80,0x00,0x00,0x3D,0xFF,0xFF,0x00,0x00,0x77,0x29,0x8B,0x44,0x24,0x38,0x48,0x0F,0xBF,0xC0,0x66,0x89,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x07,0xF7,0xA4,0xFF,0xCC,0xBA,0x07,0x00,0x00,0x00,0xE8,0xEC,0xAC,0xA5,0xFF,0xCC,0xB9,0x07,0x00,0x00,0x00,0xE8,0xE9,0xAC,0xA5,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort parse(string src, out ushort dst)
; location: [7FFDDDBC7DA0h, 7FFDDDBC7E30h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+38h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 38
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
0018h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
001bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
001eh je short 0070h                ; JE(Je_rel8_64) [70h:jmp64]                           encoding(2 bytes) = 74 50
0020h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 79 0c
0024h mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 59 08
0027h call 7FFE37EDB590h            ; CALL(Call_rel32_64) [5A3137F0h:jmp64]                encoding(5 bytes) = e8 c4 37 31 5a
002ch mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002fh lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0034h mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0037h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
003ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
003fh lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
0044h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0049h call 7FFDDD6229D0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AC30h:jmp64]        encoding(5 bytes) = e8 e2 ab a5 ff
004eh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0050h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0052h jne short 007bh               ; JNE(Jne_rel8_64) [7Bh:jmp64]                         encoding(2 bytes) = 75 27
0054h cmp dword ptr [rsp+38h],0FFFFh; CMP(Cmp_rm32_imm32) [mem(32u,RSP:br,SS:sr),ffffh:imm32] encoding(8 bytes) = 81 7c 24 38 ff ff 00 00
005ch ja short 0086h                ; JA(Ja_rel8_64) [86h:jmp64]                           encoding(2 bytes) = 77 28
005eh mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
0062h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0065h mov [rsi],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSI:br,DS:sr),AX]         encoding(3 bytes) = 66 89 06
0068h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
006ch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
006dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006eh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
006fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0070h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0075h call 7FFDDD617478h            ; CALL(Call_rel32_64) [FFFFFFFFFFA4F6D8h:jmp64]        encoding(5 bytes) = e8 5e f6 a4 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007bh mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
0080h call 7FFDDD622A68h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5ACC8h:jmp64]        encoding(5 bytes) = e8 43 ac a5 ff
0085h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0086h mov ecx,8                     ; MOV(Mov_r32_imm32) [ECX,8h:imm32]                    encoding(5 bytes) = b9 08 00 00 00
008bh call 7FFDDD622A70h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5ACD0h:jmp64]        encoding(5 bytes) = e8 40 ac a5 ff
0090h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[145]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x50,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xC4,0x37,0x31,0x5A,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0xE2,0xAB,0xA5,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x27,0x81,0x7C,0x24,0x38,0xFF,0xFF,0x00,0x00,0x77,0x28,0x8B,0x44,0x24,0x38,0x0F,0xB7,0xC0,0x66,0x89,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x5E,0xF6,0xA4,0xFF,0xCC,0xBA,0x08,0x00,0x00,0x00,0xE8,0x43,0xAC,0xA5,0xFF,0xCC,0xB9,0x08,0x00,0x00,0x00,0xE8,0x40,0xAC,0xA5,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int parse(string src, out int dst)
; location: [7FFDDDBC7E50h, 7FFDDDBC7EA4h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0017h je short 004ah                ; JE(Je_rel8_64) [4Ah:jmp64]                           encoding(2 bytes) = 74 31
0019h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 0c
001dh mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
0020h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0025h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0028h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
002bh call 7FFE37EDB590h            ; CALL(Call_rel32_64) [5A313740h:jmp64]                encoding(5 bytes) = e8 10 37 31 5a
0030h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0033h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0038h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003dh call 7FFDDD622968h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AB18h:jmp64]        encoding(5 bytes) = e8 d6 aa a5 ff
0042h mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 89 06
0044h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0048h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0049h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004ah mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004fh call 7FFDDD617478h            ; CALL(Call_rel32_64) [FFFFFFFFFFA4F628h:jmp64]        encoding(5 bytes) = e8 d4 f5 a4 ff
0054h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[85]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x31,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x10,0x37,0x31,0x5A,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0xD6,0xAA,0xA5,0xFF,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xD4,0xF5,0xA4,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint parse(string src, out uint dst)
; location: [7FFDDDBC7EC0h, 7FFDDDBC7F14h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0017h je short 004ah                ; JE(Je_rel8_64) [4Ah:jmp64]                           encoding(2 bytes) = 74 31
0019h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 0c
001dh mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
0020h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0025h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0028h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
002bh call 7FFE37EDB590h            ; CALL(Call_rel32_64) [5A3136D0h:jmp64]                encoding(5 bytes) = e8 a0 36 31 5a
0030h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0033h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0038h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003dh call 7FFDDD622978h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AAB8h:jmp64]        encoding(5 bytes) = e8 76 aa a5 ff
0042h mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 89 06
0044h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0048h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0049h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004ah mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004fh call 7FFDDD617478h            ; CALL(Call_rel32_64) [FFFFFFFFFFA4F5B8h:jmp64]        encoding(5 bytes) = e8 64 f5 a4 ff
0054h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[85]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x31,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xA0,0x36,0x31,0x5A,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x76,0xAA,0xA5,0xFF,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x64,0xF5,0xA4,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long parse(string src, out long dst)
; location: [7FFDDDBC7F30h, 7FFDDDBC7F85h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0017h je short 004bh                ; JE(Je_rel8_64) [4Bh:jmp64]                           encoding(2 bytes) = 74 32
0019h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 0c
001dh mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
0020h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0025h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0028h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
002bh call 7FFE37EDB590h            ; CALL(Call_rel32_64) [5A313660h:jmp64]                encoding(5 bytes) = e8 30 36 31 5a
0030h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0033h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0038h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003dh call 7FFDDD622970h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AA40h:jmp64]        encoding(5 bytes) = e8 fe a9 a5 ff
0042h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0045h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004bh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0050h call 7FFDDD617478h            ; CALL(Call_rel32_64) [FFFFFFFFFFA4F548h:jmp64]        encoding(5 bytes) = e8 f3 f4 a4 ff
0055h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[86]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x32,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x30,0x36,0x31,0x5A,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0xFE,0xA9,0xA5,0xFF,0x48,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xF3,0xF4,0xA4,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong parse(string src, out ulong dst)
; location: [7FFDDDBC7FA0h, 7FFDDDBC7FF5h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0017h je short 004bh                ; JE(Je_rel8_64) [4Bh:jmp64]                           encoding(2 bytes) = 74 32
0019h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 0c
001dh mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
0020h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0025h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0028h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
002bh call 7FFE37EDB590h            ; CALL(Call_rel32_64) [5A3135F0h:jmp64]                encoding(5 bytes) = e8 c0 35 31 5a
0030h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0033h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0038h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003dh call 7FFE37FAB840h            ; CALL(Call_rel32_64) [5A3E38A0h:jmp64]                encoding(5 bytes) = e8 5e 38 3e 5a
0042h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0045h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004bh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0050h call 7FFDDD617478h            ; CALL(Call_rel32_64) [FFFFFFFFFFA4F4D8h:jmp64]        encoding(5 bytes) = e8 83 f4 a4 ff
0055h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[86]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x32,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xC0,0x35,0x31,0x5A,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x5E,0x38,0x3E,0x5A,0x48,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x83,0xF4,0xA4,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float parse(string src, out float dst)
; location: [7FFDDDBC8010h, 7FFDDDBC808Dh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch mov [rsp+3Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 3c
0010h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0015h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
001ah mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
001dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0020h je short 0066h                ; JE(Je_rel8_64) [66h:jmp64]                           encoding(2 bytes) = 74 44
0022h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 79 0c
0026h mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 59 08
0029h call 7FFE37EDB590h            ; CALL(Call_rel32_64) [5A313580h:jmp64]                encoding(5 bytes) = e8 52 35 31 5a
002eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0031h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0036h mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0039h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
003ch lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0041h lea r9,[rsp+3Ch]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 3c
0046h mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
004bh call 7FFDDD622A30h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AA20h:jmp64]        encoding(5 bytes) = e8 d0 a9 a5 ff
0050h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0052h je short 0071h                ; JE(Je_rel8_64) [71h:jmp64]                           encoding(2 bytes) = 74 1d
0054h vmovss xmm0,dword ptr [rsp+3Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 3c
005ah vmovss dword ptr [rsi],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 06
005eh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0062h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0063h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0064h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0066h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
006bh call 7FFDDD617478h            ; CALL(Call_rel32_64) [FFFFFFFFFFA4F468h:jmp64]        encoding(5 bytes) = e8 f8 f3 a4 ff
0070h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0071h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0076h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0078h call 7FFDDD622A68h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5AA58h:jmp64]        encoding(5 bytes) = e8 db a9 a5 ff
007dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[126]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x89,0x44,0x24,0x3C,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x44,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x52,0x35,0x31,0x5A,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x3C,0xBA,0xE7,0x00,0x00,0x00,0xE8,0xD0,0xA9,0xA5,0xFF,0x85,0xC0,0x74,0x1D,0xC5,0xFA,0x10,0x44,0x24,0x3C,0xC5,0xFA,0x11,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xF8,0xF3,0xA4,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0xDB,0xA9,0xA5,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double parse(string src, out double dst)
; location: [7FFDDDBC80B0h, 7FFDDDBC812Eh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch mov [rsp+38h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 38
0011h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0016h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
001bh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
001eh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0021h je short 0067h                ; JE(Je_rel8_64) [67h:jmp64]                           encoding(2 bytes) = 74 44
0023h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 79 0c
0027h mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 59 08
002ah call 7FFE37EDB590h            ; CALL(Call_rel32_64) [5A3134E0h:jmp64]                encoding(5 bytes) = e8 b1 34 31 5a
002fh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0032h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0037h mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
003ah mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
003dh lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0042h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
0047h mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
004ch call 7FFDDD622A28h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5A978h:jmp64]        encoding(5 bytes) = e8 27 a9 a5 ff
0051h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0053h je short 0072h                ; JE(Je_rel8_64) [72h:jmp64]                           encoding(2 bytes) = 74 1d
0055h vmovsd xmm0,qword ptr [rsp+38h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 38
005bh vmovsd qword ptr [rsi],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 06
005fh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0063h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0064h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0065h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0066h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0067h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
006ch call 7FFDDD617478h            ; CALL(Call_rel32_64) [FFFFFFFFFFA4F3C8h:jmp64]        encoding(5 bytes) = e8 57 f3 a4 ff
0071h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0072h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0077h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0079h call 7FFDDD622A68h            ; CALL(Call_rel32_64) [FFFFFFFFFFA5A9B8h:jmp64]        encoding(5 bytes) = e8 3a a9 a5 ff
007eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[127]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x44,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xB1,0x34,0x31,0x5A,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0xE7,0x00,0x00,0x00,0xE8,0x27,0xA9,0xA5,0xFF,0x85,0xC0,0x74,0x1D,0xC5,0xFB,0x10,0x44,0x24,0x38,0xC5,0xFB,0x11,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x57,0xF3,0xA4,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0x3A,0xA9,0xA5,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte pow(sbyte b, uint exp)
; location: [7FFDDDBC8150h, 7FFDDDBC818Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0007h jne short 000fh               ; JNE(Jne_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 75 06
0009h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0014h test dl,1                     ; TEST(Test_rm8_imm8) [DL,1h:imm8]                     encoding(3 bytes) = f6 c2 01
0017h je short 0025h                ; JE(Je_rel8_64) [25h:jmp64]                           encoding(2 bytes) = 74 0c
0019h movsx r8,cl                   ; MOVSX(Movsx_r64_rm8) [R8,CL]                         encoding(4 bytes) = 4c 0f be c1
001dh imul eax,r8d                  ; IMUL(Imul_r32_rm32) [EAX,R8D]                        encoding(4 bytes) = 41 0f af c0
0021h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0025h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0027h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0029h je short 003ch                ; JE(Je_rel8_64) [3Ch:jmp64]                           encoding(2 bytes) = 74 11
002bh movsx r8,cl                   ; MOVSX(Movsx_r64_rm8) [R8,CL]                         encoding(4 bytes) = 4c 0f be c1
002fh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0032h imul ecx,r8d                  ; IMUL(Imul_r32_rm32) [ECX,R8D]                        encoding(4 bytes) = 41 0f af c8
0036h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
003ah jmp short 0014h               ; JMP(Jmp_rel8_64) [14h:jmp64]                         encoding(2 bytes) = eb d8
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[61]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x0C,0x4C,0x0F,0xBE,0xC1,0x41,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xD1,0xEA,0x85,0xD2,0x74,0x11,0x4C,0x0F,0xBE,0xC1,0x41,0x8B,0xC8,0x41,0x0F,0xAF,0xC8,0x48,0x0F,0xBE,0xC9,0xEB,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pow(byte b, uint exp)
; location: [7FFDDDBC81A0h, 7FFDDDBC81DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0007h jne short 000fh               ; JNE(Jne_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 75 06
0009h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0014h test dl,1                     ; TEST(Test_rm8_imm8) [DL,1h:imm8]                     encoding(3 bytes) = f6 c2 01
0017h je short 0024h                ; JE(Je_rel8_64) [24h:jmp64]                           encoding(2 bytes) = 74 0b
0019h movzx r8d,cl                  ; MOVZX(Movzx_r32_rm8) [R8D,CL]                        encoding(4 bytes) = 44 0f b6 c1
001dh imul eax,r8d                  ; IMUL(Imul_r32_rm32) [EAX,R8D]                        encoding(4 bytes) = 41 0f af c0
0021h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0024h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0026h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0028h je short 003ah                ; JE(Je_rel8_64) [3Ah:jmp64]                           encoding(2 bytes) = 74 10
002ah movzx r8d,cl                  ; MOVZX(Movzx_r32_rm8) [R8D,CL]                        encoding(4 bytes) = 44 0f b6 c1
002eh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0031h imul ecx,r8d                  ; IMUL(Imul_r32_rm32) [ECX,R8D]                        encoding(4 bytes) = 41 0f af c8
0035h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0038h jmp short 0014h               ; JMP(Jmp_rel8_64) [14h:jmp64]                         encoding(2 bytes) = eb da
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x0B,0x44,0x0F,0xB6,0xC1,0x41,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xD1,0xEA,0x85,0xD2,0x74,0x10,0x44,0x0F,0xB6,0xC1,0x41,0x8B,0xC8,0x41,0x0F,0xAF,0xC8,0x0F,0xB6,0xC9,0xEB,0xDA,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short pow(short b, uint exp)
; location: [7FFDDDBC81F0h, 7FFDDDBC822Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0007h jne short 000fh               ; JNE(Jne_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 75 06
0009h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0014h test dl,1                     ; TEST(Test_rm8_imm8) [DL,1h:imm8]                     encoding(3 bytes) = f6 c2 01
0017h je short 0025h                ; JE(Je_rel8_64) [25h:jmp64]                           encoding(2 bytes) = 74 0c
0019h movsx r8,cx                   ; MOVSX(Movsx_r64_rm16) [R8,CX]                        encoding(4 bytes) = 4c 0f bf c1
001dh imul eax,r8d                  ; IMUL(Imul_r32_rm32) [EAX,R8D]                        encoding(4 bytes) = 41 0f af c0
0021h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0025h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0027h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0029h je short 003ch                ; JE(Je_rel8_64) [3Ch:jmp64]                           encoding(2 bytes) = 74 11
002bh movsx r8,cx                   ; MOVSX(Movsx_r64_rm16) [R8,CX]                        encoding(4 bytes) = 4c 0f bf c1
002fh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0032h imul ecx,r8d                  ; IMUL(Imul_r32_rm32) [ECX,R8D]                        encoding(4 bytes) = 41 0f af c8
0036h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
003ah jmp short 0014h               ; JMP(Jmp_rel8_64) [14h:jmp64]                         encoding(2 bytes) = eb d8
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[61]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x0C,0x4C,0x0F,0xBF,0xC1,0x41,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xD1,0xEA,0x85,0xD2,0x74,0x11,0x4C,0x0F,0xBF,0xC1,0x41,0x8B,0xC8,0x41,0x0F,0xAF,0xC8,0x48,0x0F,0xBF,0xC9,0xEB,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pow(ushort b, uint exp)
; location: [7FFDDDBC8240h, 7FFDDDBC827Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0007h jne short 000fh               ; JNE(Jne_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 75 06
0009h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0014h test dl,1                     ; TEST(Test_rm8_imm8) [DL,1h:imm8]                     encoding(3 bytes) = f6 c2 01
0017h je short 0024h                ; JE(Je_rel8_64) [24h:jmp64]                           encoding(2 bytes) = 74 0b
0019h movzx r8d,cx                  ; MOVZX(Movzx_r32_rm16) [R8D,CX]                       encoding(4 bytes) = 44 0f b7 c1
001dh imul eax,r8d                  ; IMUL(Imul_r32_rm32) [EAX,R8D]                        encoding(4 bytes) = 41 0f af c0
0021h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0024h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0026h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0028h je short 003ah                ; JE(Je_rel8_64) [3Ah:jmp64]                           encoding(2 bytes) = 74 10
002ah movzx r8d,cx                  ; MOVZX(Movzx_r32_rm16) [R8D,CX]                       encoding(4 bytes) = 44 0f b7 c1
002eh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0031h imul ecx,r8d                  ; IMUL(Imul_r32_rm32) [ECX,R8D]                        encoding(4 bytes) = 41 0f af c8
0035h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0038h jmp short 0014h               ; JMP(Jmp_rel8_64) [14h:jmp64]                         encoding(2 bytes) = eb da
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x0B,0x44,0x0F,0xB7,0xC1,0x41,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xD1,0xEA,0x85,0xD2,0x74,0x10,0x44,0x0F,0xB7,0xC1,0x41,0x8B,0xC8,0x41,0x0F,0xAF,0xC8,0x0F,0xB7,0xC9,0xEB,0xDA,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int pow(int b, uint exp)
; location: [7FFDDDBC8290h, 7FFDDDBC82B7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0007h jne short 000fh               ; JNE(Jne_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 75 06
0009h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0014h test dl,1                     ; TEST(Test_rm8_imm8) [DL,1h:imm8]                     encoding(3 bytes) = f6 c2 01
0017h je short 001ch                ; JE(Je_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 74 03
0019h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
001ch shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
001eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0020h je short 0027h                ; JE(Je_rel8_64) [27h:jmp64]                           encoding(2 bytes) = 74 05
0022h imul ecx,ecx                  ; IMUL(Imul_r32_rm32) [ECX,ECX]                        encoding(3 bytes) = 0f af c9
0025h jmp short 0014h               ; JMP(Jmp_rel8_64) [14h:jmp64]                         encoding(2 bytes) = eb ed
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x03,0x0F,0xAF,0xC1,0xD1,0xEA,0x85,0xD2,0x74,0x05,0x0F,0xAF,0xC9,0xEB,0xED,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pow(uint b, uint exp)
; location: [7FFDDDBC82D0h, 7FFDDDBC82F7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0007h jne short 000fh               ; JNE(Jne_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 75 06
0009h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0014h test dl,1                     ; TEST(Test_rm8_imm8) [DL,1h:imm8]                     encoding(3 bytes) = f6 c2 01
0017h je short 001ch                ; JE(Je_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 74 03
0019h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
001ch shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
001eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0020h je short 0027h                ; JE(Je_rel8_64) [27h:jmp64]                           encoding(2 bytes) = 74 05
0022h imul ecx,ecx                  ; IMUL(Imul_r32_rm32) [ECX,ECX]                        encoding(3 bytes) = 0f af c9
0025h jmp short 0014h               ; JMP(Jmp_rel8_64) [14h:jmp64]                         encoding(2 bytes) = eb ed
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x03,0x0F,0xAF,0xC1,0xD1,0xEA,0x85,0xD2,0x74,0x05,0x0F,0xAF,0xC9,0xEB,0xED,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long pow(long b, uint exp)
; location: [7FFDDDBC8310h, 7FFDDDBC8339h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0007h jne short 000fh               ; JNE(Jne_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 75 06
0009h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0014h test dl,1                     ; TEST(Test_rm8_imm8) [DL,1h:imm8]                     encoding(3 bytes) = f6 c2 01
0017h je short 001dh                ; JE(Je_rel8_64) [1Dh:jmp64]                           encoding(2 bytes) = 74 04
0019h imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
001dh shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
001fh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0021h je short 0029h                ; JE(Je_rel8_64) [29h:jmp64]                           encoding(2 bytes) = 74 06
0023h imul rcx,rcx                  ; IMUL(Imul_r64_rm64) [RCX,RCX]                        encoding(4 bytes) = 48 0f af c9
0027h jmp short 0014h               ; JMP(Jmp_rel8_64) [14h:jmp64]                         encoding(2 bytes) = eb eb
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x04,0x48,0x0F,0xAF,0xC1,0xD1,0xEA,0x85,0xD2,0x74,0x06,0x48,0x0F,0xAF,0xC9,0xEB,0xEB,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow(ulong b, uint exp)
; location: [7FFDDDBC8350h, 7FFDDDBC8379h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0007h jne short 000fh               ; JNE(Jne_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 75 06
0009h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0014h test dl,1                     ; TEST(Test_rm8_imm8) [DL,1h:imm8]                     encoding(3 bytes) = f6 c2 01
0017h je short 001dh                ; JE(Je_rel8_64) [1Dh:jmp64]                           encoding(2 bytes) = 74 04
0019h imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
001dh shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
001fh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0021h je short 0029h                ; JE(Je_rel8_64) [29h:jmp64]                           encoding(2 bytes) = 74 06
0023h imul rcx,rcx                  ; IMUL(Imul_r64_rm64) [RCX,RCX]                        encoding(4 bytes) = 48 0f af c9
0027h jmp short 0014h               ; JMP(Jmp_rel8_64) [14h:jmp64]                         encoding(2 bytes) = eb eb
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x04,0x48,0x0F,0xAF,0xC1,0xD1,0xEA,0x85,0xD2,0x74,0x06,0x48,0x0F,0xAF,0xC9,0xEB,0xEB,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte pow(ref sbyte src, uint exp)
; location: [7FFDDDBC8390h, 7FFDDDBC83ABh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h movsx rcx,byte ptr [rsi]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RSI:br,DS:sr)]      encoding(4 bytes) = 48 0f be 0e
000ch call 7FFDDDBC8150h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFDC0h:jmp64]        encoding(5 bytes) = e8 af fd ff ff
0011h mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]            encoding(2 bytes) = 88 06
0013h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0016h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
001ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[28]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x0F,0xBE,0x0E,0xE8,0xAF,0xFD,0xFF,0xFF,0x88,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte pow(ref byte src, uint exp)
; location: [7FFDDDBC83C0h, 7FFDDDBC83DAh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h movzx ecx,byte ptr [rsi]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSI:br,DS:sr)]      encoding(3 bytes) = 0f b6 0e
000bh call 7FFDDDBC81A0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFDE0h:jmp64]        encoding(5 bytes) = e8 d0 fd ff ff
0010h mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]            encoding(2 bytes) = 88 06
0012h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0015h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0019h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[27]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x0F,0xB6,0x0E,0xE8,0xD0,0xFD,0xFF,0xFF,0x88,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short pow(ref short src, uint exp)
; location: [7FFDDDBC83F0h, 7FFDDDBC840Ch]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h movsx rcx,word ptr [rsi]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RSI:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 0e
000ch call 7FFDDDBC81F0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE00h:jmp64]        encoding(5 bytes) = e8 ef fd ff ff
0011h mov [rsi],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSI:br,DS:sr),AX]         encoding(3 bytes) = 66 89 06
0014h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0017h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
001bh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[29]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x0F,0xBF,0x0E,0xE8,0xEF,0xFD,0xFF,0xFF,0x66,0x89,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort pow(ref ushort src, uint exp)
; location: [7FFDDDBC8430h, 7FFDDDBC844Bh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h movzx ecx,word ptr [rsi]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RSI:br,DS:sr)]    encoding(3 bytes) = 0f b7 0e
000bh call 7FFDDDBC8240h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE10h:jmp64]        encoding(5 bytes) = e8 00 fe ff ff
0010h mov [rsi],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSI:br,DS:sr),AX]         encoding(3 bytes) = 66 89 06
0013h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0016h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
001ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[28]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x0F,0xB7,0x0E,0xE8,0x00,0xFE,0xFF,0xFF,0x66,0x89,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int pow(ref int src, uint exp)
; location: [7FFDDDBC8460h, 7FFDDDBC8479h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov ecx,[rsi]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSI:br,DS:sr)]        encoding(2 bytes) = 8b 0e
000ah call 7FFDDDBC8290h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE30h:jmp64]        encoding(5 bytes) = e8 21 fe ff ff
000fh mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 89 06
0011h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0014h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0018h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[26]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x8B,0x0E,0xE8,0x21,0xFE,0xFF,0xFF,0x89,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pow(ref uint src, uint exp)
; location: [7FFDDDBC8490h, 7FFDDDBC84A9h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov ecx,[rsi]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSI:br,DS:sr)]        encoding(2 bytes) = 8b 0e
000ah call 7FFDDDBC82D0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE40h:jmp64]        encoding(5 bytes) = e8 31 fe ff ff
000fh mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 89 06
0011h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0014h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0018h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[26]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x8B,0x0E,0xE8,0x31,0xFE,0xFF,0xFF,0x89,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long pow(ref long src, uint exp)
; location: [7FFDDDBC84C0h, 7FFDDDBC84DBh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
000bh call 7FFDDDBC8310h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE50h:jmp64]        encoding(5 bytes) = e8 40 fe ff ff
0010h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0013h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0016h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
001ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[28]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0x0E,0xE8,0x40,0xFE,0xFF,0xFF,0x48,0x89,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong ipow(ref ulong src, uint exp)
; location: [7FFDDDBC84F0h, 7FFDDDBC850Bh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
000bh call 7FFDDDBC8350h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE60h:jmp64]        encoding(5 bytes) = e8 50 fe ff ff
0010h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0013h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0016h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
001ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ipowBytes => new byte[28]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0x0E,0xE8,0x50,0xFE,0xFF,0xFF,0x48,0x89,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte sal(ref sbyte src, int offset)
; location: [7FFDDDBC8520h, 7FFDDDBC8534h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,byte ptr [rax]       ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 0f be 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0011h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBE,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte sal(ref byte src, int offset)
; location: [7FFDDDBC8550h, 7FFDDDBC8564h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0011h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB6,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short sal(ref short src, int offset)
; location: [7FFDDDBC8580h, 7FFDDDBC8595h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,word ptr [rax]       ; MOVSX(Movsx_r64_rm16) [R8,mem(16i,RAX:br,DS:sr)]     encoding(4 bytes) = 4c 0f bf 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0011h mov [rax],r8w                 ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R8W]        encoding(4 bytes) = 66 44 89 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBF,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x66,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort sal(ref ushort src, int offset)
; location: [7FFDDDBC85B0h, 7FFDDDBC85C5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RAX:br,DS:sr)]    encoding(4 bytes) = 44 0f b7 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0011h mov [rax],r8w                 ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R8W]        encoding(4 bytes) = 66 44 89 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB7,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x66,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int sal(ref int src, int offset)
; location: [7FFDDDBC85E0h, 7FFDDDBC85ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0xD3,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint sal(ref uint src, int offset)
; location: [7FFDDDBC8600h, 7FFDDDBC860Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0xD3,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long sal(ref long src, int offset)
; location: [7FFDDDBC8620h, 7FFDDDBC862Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong sal(ref ulong src, int offset)
; location: [7FFDDDBC8640h, 7FFDDDBC864Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte sar(ref sbyte src, int offset)
; location: [7FFDDDBC8660h, 7FFDDDBC8674h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,byte ptr [rax]       ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 0f be 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0011h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBE,0x00,0x8B,0xCA,0x41,0xD3,0xF8,0x44,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte sar(ref byte src, int offset)
; location: [7FFDDDBC8690h, 7FFDDDBC86A4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0011h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB6,0x00,0x8B,0xCA,0x41,0xD3,0xF8,0x44,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short sar(ref short src, int offset)
; location: [7FFDDDBC86C0h, 7FFDDDBC86D5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,word ptr [rax]       ; MOVSX(Movsx_r64_rm16) [R8,mem(16i,RAX:br,DS:sr)]     encoding(4 bytes) = 4c 0f bf 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0011h mov [rax],r8w                 ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R8W]        encoding(4 bytes) = 66 44 89 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBF,0x00,0x8B,0xCA,0x41,0xD3,0xF8,0x66,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort sar(ref ushort src, int offset)
; location: [7FFDDDBC86F0h, 7FFDDDBC8705h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RAX:br,DS:sr)]    encoding(4 bytes) = 44 0f b7 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0011h mov [rax],r8w                 ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R8W]        encoding(4 bytes) = 66 44 89 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB7,0x00,0x8B,0xCA,0x41,0xD3,0xF8,0x66,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int sar(ref int src, int offset)
; location: [7FFDDDBC8720h, 7FFDDDBC872Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar dword ptr [rax],cl        ; SAR(Sar_rm32_CL) [mem(32i,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 38
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0xD3,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint sar(ref uint src, int offset)
; location: [7FFDDDBC8740h, 7FFDDDBC874Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr dword ptr [rax],cl        ; SHR(Shr_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 28
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0xD3,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long sar(ref long src, int offset)
; location: [7FFDDDBC8760h, 7FFDDDBC876Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar qword ptr [rax],cl        ; SAR(Sar_rm64_CL) [mem(64i,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 38
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong sar(ref ulong src, int offset)
; location: [7FFDDDBC8780h, 7FFDDDBC878Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr qword ptr [rax],cl        ; SHR(Shr_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 28
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(int src)
; location: [7FFDDDBC87A0h, 7FFDDDBC87B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh shr eax,1Fh                   ; SHR(Shr_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 e8 1f
000eh sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
0011h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signumBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC1,0xE8,0x1F,0xC1,0xF9,0x1F,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(uint src)
; location: [7FFDDDBC87D0h, 7FFDDDBC87DDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signumBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(long src)
; location: [7FFDDDBC87F0h, 7FFDDDBC880Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh shr rax,3Fh                   ; SHR(Shr_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 e8 3f
0012h sar rcx,3Fh                   ; SAR(Sar_rm64_imm8) [RCX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f9 3f
0016h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0018h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signumBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0x48,0xC1,0xE8,0x3F,0x48,0xC1,0xF9,0x3F,0x8B,0xD1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(ulong src)
; location: [7FFDDDBC8820h, 7FFDDDBC882Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signumBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(float src)
; location: [7FFDDDBC8840h, 7FFDDDBC884Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,7FFDDD8B8AB8h         ; MOV(Mov_r64_imm64) [RAX,7ffddd8b8ab8h:imm64]         encoding(10 bytes) = 48 b8 b8 8a 8b dd fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signumBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0xB8,0x8A,0x8B,0xDD,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(double src)
; location: [7FFDDDBC8870h, 7FFDDDBC887Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,7FFDDD8B8A90h         ; MOV(Mov_r64_imm64) [RAX,7ffddd8b8a90h:imm64]         encoding(10 bytes) = 48 b8 90 8a 8b dd fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signumBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0x90,0x8A,0x8B,0xDD,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(sbyte src)
; location: [7FFDDDBC88A0h, 7FFDDDBC88B7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000dh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000fh shr edx,1Fh                   ; SHR(Shr_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 ea 1f
0012h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signumBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC2,0xC1,0xEA,0x1F,0xC1,0xF8,0x1F,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(byte src)
; location: [7FFDDDBC88D0h, 7FFDDDBC88DDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signumBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(short src)
; location: [7FFDDDBC88F0h, 7FFDDDBC8907h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000dh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000fh shr edx,1Fh                   ; SHR(Shr_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 ea 1f
0012h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signumBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC2,0xC1,0xEA,0x1F,0xC1,0xF8,0x1F,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(ushort src)
; location: [7FFDDDBC8920h, 7FFDDDBC8930h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signumBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte square(sbyte src)
; location: [7FFDDDBC8950h, 7FFDDDBC8960h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte square(byte src)
; location: [7FFDDDBC8980h, 7FFDDDBC898Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short square(short src)
; location: [7FFDDDBC89A0h, 7FFDDDBC89B0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort square(ushort src)
; location: [7FFDDDBC89D0h, 7FFDDDBC89DEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int square(int src)
; location: [7FFDDDBC89F0h, 7FFDDDBC89FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint square(uint src)
; location: [7FFDDDBC8A10h, 7FFDDDBC8A1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long square(long src)
; location: [7FFDDDBC8A30h, 7FFDDDBC8A47h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2sd xmm0,xmm0,rcx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RCX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c1
000eh vsqrtsd xmm0,xmm0,xmm0        ; VSQRTSD(VEX_Vsqrtsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fb 51 c0
0012h vcvttsd2si rax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r64_xmmm64) [RAX,XMM0]     encoding(VEX, 5 bytes) = c4 e1 fb 2c c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC1,0xC5,0xFB,0x51,0xC0,0xC4,0xE1,0xFB,0x2C,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong square(ulong src)
; location: [7FFDDDBC8A60h, 7FFDDDBC8A6Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float square(float src)
; location: [7FFDDDBC8A80h, 7FFDDDBC8A89h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmulss xmm0,xmm0,xmm0         ; VMULSS(VEX_Vmulss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM0]   encoding(VEX, 4 bytes) = c5 fa 59 c0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x59,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double square(double src)
; location: [7FFDDDBC8AA0h, 7FFDDDBC8AA9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmulsd xmm0,xmm0,xmm0         ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0]   encoding(VEX, 4 bytes) = c5 fb 59 c0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x59,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte square(ref sbyte src)
; location: [7FFDDDBC8AC0h, 7FFDDDBC8AD1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x0F,0xAF,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte square(ref byte src)
; location: [7FFDDDBC8AF0h, 7FFDDDBC8B00h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x0F,0xAF,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short square(ref short src)
; location: [7FFDDDBC8B20h, 7FFDDDBC8B32h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x0F,0xAF,0xC0,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort square(ref ushort src)
; location: [7FFDDDBC8B50h, 7FFDDDBC8B61h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x0F,0xAF,0xC0,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int square(ref int src)
; location: [7FFDDDBC8B80h, 7FFDDDBC8B8Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ah mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x0F,0xAF,0xC0,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint square(ref uint src)
; location: [7FFDDDBC8BA0h, 7FFDDDBC8BAFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ah mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x0F,0xAF,0xC0,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long square(ref long src)
; location: [7FFDDDBC8BC0h, 7FFDDDBC8BD2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h imul rax,rax                  ; IMUL(Imul_r64_rm64) [RAX,RAX]                        encoding(4 bytes) = 48 0f af c0
000ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x0F,0xAF,0xC0,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong square(ref ulong src)
; location: [7FFDDDBC8BF0h, 7FFDDDBC8C02h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h imul rax,rax                  ; IMUL(Imul_r64_rm64) [RAX,RAX]                        encoding(4 bytes) = 48 0f af c0
000ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x0F,0xAF,0xC0,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float square(ref float src)
; location: [7FFDDDBC8C20h, 7FFDDDBC8C34h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
0009h vmulss xmm0,xmm0,xmm0         ; VMULSS(VEX_Vmulss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM0]   encoding(VEX, 4 bytes) = c5 fa 59 c0
000dh vmovss dword ptr [rcx],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x59,0xC0,0xC5,0xFA,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double square(ref double src)
; location: [7FFDDDBC8C50h, 7FFDDDBC8C64h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
0009h vmulsd xmm0,xmm0,xmm0         ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0]   encoding(VEX, 4 bytes) = c5 fb 59 c0
000dh vmovsd qword ptr [rcx],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x59,0xC0,0xC5,0xFB,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte square(sbyte src, out sbyte dst)
; location: [7FFDDDBC8C80h, 7FFDDDBC8CABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movsx rax,byte ptr [rsp+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 44 24 08
000fh movsx rcx,byte ptr [rsp+8]    ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 4c 24 08
0015h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
0018h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001ch mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0020h movsx rax,byte ptr [rsp+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 44 24 08
0026h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0028h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[44]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x0F,0xBE,0x44,0x24,0x08,0x48,0x0F,0xBE,0x4C,0x24,0x08,0x0F,0xAF,0xC1,0x48,0x0F,0xBE,0xC0,0x88,0x44,0x24,0x08,0x48,0x0F,0xBE,0x44,0x24,0x08,0x88,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte square(byte src, out byte dst)
; location: [7FFDDDBC8CC0h, 7FFDDDBC8CE7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
000eh movzx ecx,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 08
0013h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
001dh movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
0022h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0024h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x0F,0xB6,0x44,0x24,0x08,0x0F,0xB6,0x4C,0x24,0x08,0x0F,0xAF,0xC1,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x0F,0xB6,0x44,0x24,0x08,0x88,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short square(short src, out short dst)
; location: [7FFDDDBC8D00h, 7FFDDDBC8D2Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movsx rax,word ptr [rsp+8]    ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 44 24 08
000fh movsx rcx,word ptr [rsp+8]    ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 4c 24 08
0015h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
0018h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001ch mov [rsp+8],ax                ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),AX]         encoding(5 bytes) = 66 89 44 24 08
0021h movsx rax,word ptr [rsp+8]    ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 44 24 08
0027h mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
002ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[46]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x0F,0xBF,0x44,0x24,0x08,0x48,0x0F,0xBF,0x4C,0x24,0x08,0x0F,0xAF,0xC1,0x48,0x0F,0xBF,0xC0,0x66,0x89,0x44,0x24,0x08,0x48,0x0F,0xBF,0x44,0x24,0x08,0x66,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort square(ushort src, out ushort dst)
; location: [7FFDDDBC8D40h, 7FFDDDBC8D69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movzx eax,word ptr [rsp+8]    ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RSP:br,SS:sr)]    encoding(5 bytes) = 0f b7 44 24 08
000eh movzx ecx,word ptr [rsp+8]    ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RSP:br,SS:sr)]    encoding(5 bytes) = 0f b7 4c 24 08
0013h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
0016h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0019h mov [rsp+8],ax                ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),AX]         encoding(5 bytes) = 66 89 44 24 08
001eh movzx eax,word ptr [rsp+8]    ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RSP:br,SS:sr)]    encoding(5 bytes) = 0f b7 44 24 08
0023h mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
0026h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x0F,0xB7,0x44,0x24,0x08,0x0F,0xB7,0x4C,0x24,0x08,0x0F,0xAF,0xC1,0x0F,0xB7,0xC0,0x66,0x89,0x44,0x24,0x08,0x0F,0xB7,0x44,0x24,0x08,0x66,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int square(int src, out int dst)
; location: [7FFDDDBC8D80h, 7FFDDDBC8D8Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul ecx,ecx                  ; IMUL(Imul_r32_rm32) [ECX,ECX]                        encoding(3 bytes) = 0f af c9
0008h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xC9,0x89,0x0A,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint square(uint src, out uint dst)
; location: [7FFDDDBC8DA0h, 7FFDDDBC8DADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul ecx,ecx                  ; IMUL(Imul_r32_rm32) [ECX,ECX]                        encoding(3 bytes) = 0f af c9
0008h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xC9,0x89,0x0A,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long square(long src, out long dst)
; location: [7FFDDDBC8DC0h, 7FFDDDBC8DCFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rcx,rcx                  ; IMUL(Imul_r64_rm64) [RCX,RCX]                        encoding(4 bytes) = 48 0f af c9
0009h mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RCX]        encoding(3 bytes) = 48 89 0a
000ch mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xC9,0x48,0x89,0x0A,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong square(ulong src, out ulong dst)
; location: [7FFDDDBC8DE0h, 7FFDDDBC8DEFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rcx,rcx                  ; IMUL(Imul_r64_rm64) [RCX,RCX]                        encoding(4 bytes) = 48 0f af c9
0009h mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RCX]        encoding(3 bytes) = 48 89 0a
000ch mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xC9,0x48,0x89,0x0A,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float square(float src, out float dst)
; location: [7FFDDDBC8E00h, 7FFDDDBC8E10h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmulss xmm0,xmm0,xmm0         ; VMULSS(VEX_Vmulss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM0]   encoding(VEX, 4 bytes) = c5 fa 59 c0
0009h vmovss dword ptr [rdx],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 02
000dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x59,0xC0,0xC5,0xFA,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double square(double src, out double dst)
; location: [7FFDDDBC8E30h, 7FFDDDBC8E40h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmulsd xmm0,xmm0,xmm0         ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0]   encoding(VEX, 4 bytes) = c5 fb 59 c0
0009h vmovsd qword ptr [rdx],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 02
000dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x59,0xC0,0xC5,0xFB,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint srl(uint src, int offset)
; location: [7FFDDDBC8E60h, 7FFDDDBC8E6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long srl(long src, int offset)
; location: [7FFDDDBC8E80h, 7FFDDDBC8E8Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl(ulong src, int offset)
; location: [7FFDDDBC8EA0h, 7FFDDDBC8EADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte srl(sbyte src, int offset)
; location: [7FFDDDBC8EC0h, 7FFDDDBC8ED1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte srl(byte src, int offset)
; location: [7FFDDDBC8EF0h, 7FFDDDBC8EFFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short srl(short src, int offset)
; location: [7FFDDDBC8F10h, 7FFDDDBC8F21h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort srl(ushort src, int offset)
; location: [7FFDDDBC8F40h, 7FFDDDBC8F4Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int srl(int src, int offset)
; location: [7FFDDDBC8F60h, 7FFDDDBC8F6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte srl(ref sbyte src, int offset)
; location: [7FFDDDBC8F80h, 7FFDDDBC8F94h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,byte ptr [rax]       ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 0f be 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
0011h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBE,0x00,0x8B,0xCA,0x41,0xD3,0xE8,0x44,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte srl(ref byte src, int offset)
; location: [7FFDDDBC8FB0h, 7FFDDDBC8FC4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
0011h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB6,0x00,0x8B,0xCA,0x41,0xD3,0xE8,0x44,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short srl(ref short src, int offset)
; location: [7FFDDDBC8FE0h, 7FFDDDBC8FF5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,word ptr [rax]       ; MOVSX(Movsx_r64_rm16) [R8,mem(16i,RAX:br,DS:sr)]     encoding(4 bytes) = 4c 0f bf 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
0011h mov [rax],r8w                 ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R8W]        encoding(4 bytes) = 66 44 89 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBF,0x00,0x8B,0xCA,0x41,0xD3,0xE8,0x66,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort srl(ref ushort src, int offset)
; location: [7FFDDDBC9010h, 7FFDDDBC9025h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RAX:br,DS:sr)]    encoding(4 bytes) = 44 0f b7 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
0011h mov [rax],r8w                 ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R8W]        encoding(4 bytes) = 66 44 89 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB7,0x00,0x8B,0xCA,0x41,0xD3,0xE8,0x66,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int srl(ref int src, int offset)
; location: [7FFDDDBC9040h, 7FFDDDBC9053h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
0010h mov [rax],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(3 bytes) = 44 89 00
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x8B,0xCA,0x41,0xD3,0xE8,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint srl(ref uint src, int offset)
; location: [7FFDDDBC9070h, 7FFDDDBC9083h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
0010h mov [rax],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(3 bytes) = 44 89 00
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x8B,0xCA,0x41,0xD3,0xE8,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long srl(ref long src, int offset)
; location: [7FFDDDBC90A0h, 7FFDDDBC90B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh shr r8,cl                     ; SHR(Shr_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e8
0010h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 00
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x00,0x8B,0xCA,0x49,0xD3,0xE8,0x4C,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong srl(ref ulong src, int offset)
; location: [7FFDDDBC90D0h, 7FFDDDBC90E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh shr r8,cl                     ; SHR(Shr_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e8
0010h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 00
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x00,0x8B,0xCA,0x49,0xD3,0xE8,0x4C,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int srl32i(int src, int offset)
; location: [7FFDDDBC9100h, 7FFDDDBC910Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint srl32u(uint src, int offset)
; location: [7FFDDDBC9120h, 7FFDDDBC912Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long srl64i(long src, int offset)
; location: [7FFDDDBC9140h, 7FFDDDBC914Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl64u(ulong src, int offset)
; location: [7FFDDDBC9160h, 7FFDDDBC916Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sub(sbyte lhs, sbyte rhs)
; location: [7FFDDDBC9180h, 7FFDDDBC9193h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x2B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sub(byte lhs, byte rhs)
; location: [7FFDDDBC91B0h, 7FFDDDBC91C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x2B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq(long lhs, long rhs)
; location: [7FFDDDBC91E0h, 7FFDDDBC91EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq(ulong lhs, ulong rhs)
; location: [7FFDDDBC9200h, 7FFDDDBC920Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte max(sbyte lhs, sbyte rhs)
; location: [7FFDDDBC9220h, 7FFDDDBC9234h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jg short 0014h                ; JG(Jg_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7f 03
0011h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7F,0x03,0x8B,0xC2,0xC3,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte max(byte lhs, byte rhs)
; location: [7FFDDDBC9250h, 7FFDDDBC9262h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jg short 0012h                ; JG(Jg_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 7f 03
000fh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x7F,0x03,0x8B,0xC2,0xC3,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short max(short lhs, short rhs)
; location: [7FFDDDBC9280h, 7FFDDDBC9294h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jg short 0014h                ; JG(Jg_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7f 03
0011h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7F,0x03,0x8B,0xC2,0xC3,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort max(ushort lhs, ushort rhs)
; location: [7FFDDDBC92B0h, 7FFDDDBC92C2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jg short 0012h                ; JG(Jg_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 7f 03
000fh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x7F,0x03,0x8B,0xC2,0xC3,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int max(int lhs, int rhs)
; location: [7FFDDDBC92E0h, 7FFDDDBC92EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jg short 000ch                ; JG(Jg_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 7f 03
0009h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7F,0x03,0x8B,0xC2,0xC3,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint max(uint lhs, uint rhs)
; location: [7FFDDDBC9300h, 7FFDDDBC930Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h ja short 000ch                ; JA(Ja_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 77 03
0009h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x77,0x03,0x8B,0xC2,0xC3,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long max(long lhs, long rhs)
; location: [7FFDDDBC9320h, 7FFDDDBC9331h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jg short 000eh                ; JG(Jg_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 7f 04
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7F,0x04,0x48,0x8B,0xC2,0xC3,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong max(ulong lhs, ulong rhs)
; location: [7FFDDDBC9350h, 7FFDDDBC9361h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h ja short 000eh                ; JA(Ja_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 77 04
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x77,0x04,0x48,0x8B,0xC2,0xC3,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float max(float lhs, float rhs)
; location: [7FFDDDBC9380h, 7FFDDDBC9390h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h ja short 0010h                ; JA(Ja_rel8_64) [10h:jmp64]                           encoding(2 bytes) = 77 05
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x77,0x05,0xC5,0xF8,0x28,0xC1,0xC3,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double max(double lhs, double rhs)
; location: [7FFDDDBC93B0h, 7FFDDDBC93C0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h ja short 0010h                ; JA(Ja_rel8_64) [10h:jmp64]                           encoding(2 bytes) = 77 05
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x77,0x05,0xC5,0xF8,0x28,0xC1,0xC3,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte min(sbyte lhs, sbyte rhs)
; location: [7FFDDDBC93E0h, 7FFDDDBC93F4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c 03
0011h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7C,0x03,0x8B,0xC2,0xC3,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte min(byte lhs, byte rhs)
; location: [7FFDDDBC9410h, 7FFDDDBC9422h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jl short 0012h                ; JL(Jl_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 7c 03
000fh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x7C,0x03,0x8B,0xC2,0xC3,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short min(short lhs, short rhs)
; location: [7FFDDDBC9440h, 7FFDDDBC9454h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c 03
0011h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7C,0x03,0x8B,0xC2,0xC3,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort min(ushort lhs, ushort rhs)
; location: [7FFDDDBC9470h, 7FFDDDBC9482h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jl short 0012h                ; JL(Jl_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 7c 03
000fh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x7C,0x03,0x8B,0xC2,0xC3,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int min(int lhs, int rhs)
; location: [7FFDDDBC94A0h, 7FFDDDBC94AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jl short 000ch                ; JL(Jl_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 7c 03
0009h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x03,0x8B,0xC2,0xC3,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint min(uint lhs, uint rhs)
; location: [7FFDDDBC94C0h, 7FFDDDBC94CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jb short 000ch                ; JB(Jb_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 72 03
0009h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x03,0x8B,0xC2,0xC3,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long min(long lhs, long rhs)
; location: [7FFDDDBC94E0h, 7FFDDDBC94F1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jl short 000eh                ; JL(Jl_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 7c 04
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x04,0x48,0x8B,0xC2,0xC3,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong min(ulong lhs, ulong rhs)
; location: [7FFDDDBC9510h, 7FFDDDBC9521h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jb short 000eh                ; JB(Jb_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 72 04
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x04,0x48,0x8B,0xC2,0xC3,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte min(ReadOnlySpan<sbyte> src)
; location: [7FFDDDBC9540h, 7FFDDDBC9579h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 11
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
000dh ja short 0012h                ; JA(Ja_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 77 03
000fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0012h movsx rax,byte ptr [rdx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RDX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 02
0016h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001ch cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
001fh jle short 0039h               ; JLE(Jle_rel8_64) [39h:jmp64]                         encoding(2 bytes) = 7e 18
0021h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0024h movsx r9,byte ptr [rdx+r9]    ; MOVSX(Movsx_r64_rm8) [R9,mem(8i,RDX:br,DS:sr)]       encoding(5 bytes) = 4e 0f be 0c 0a
0029h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
002ch jge short 0031h               ; JGE(Jge_rel8_64) [31h:jmp64]                         encoding(2 bytes) = 7d 03
002eh mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
0031h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0034h cmp r8d,ecx                   ; CMP(Cmp_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 3b c1
0037h jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c e8
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[58]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x11,0x8B,0x49,0x08,0x85,0xC9,0x77,0x03,0x33,0xC0,0xC3,0x48,0x0F,0xBE,0x02,0x41,0xB8,0x01,0x00,0x00,0x00,0x83,0xF9,0x01,0x7E,0x18,0x4D,0x63,0xC8,0x4E,0x0F,0xBE,0x0C,0x0A,0x44,0x3B,0xC8,0x7D,0x03,0x41,0x8B,0xC1,0x41,0xFF,0xC0,0x44,0x3B,0xC1,0x7C,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte min(ReadOnlySpan<byte> src)
; location: [7FFDDDBC9590h, 7FFDDDBC95C8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 11
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
000dh ja short 0012h                ; JA(Ja_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 77 03
000fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0012h movzx eax,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RDX:br,DS:sr)]      encoding(3 bytes) = 0f b6 02
0015h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001bh cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
001eh jle short 0038h               ; JLE(Jle_rel8_64) [38h:jmp64]                         encoding(2 bytes) = 7e 18
0020h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0023h movzx r9d,byte ptr [rdx+r9]   ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,RDX:br,DS:sr)]      encoding(5 bytes) = 46 0f b6 0c 0a
0028h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
002bh jge short 0030h               ; JGE(Jge_rel8_64) [30h:jmp64]                         encoding(2 bytes) = 7d 03
002dh mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
0030h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0033h cmp r8d,ecx                   ; CMP(Cmp_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 3b c1
0036h jl short 0020h                ; JL(Jl_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 7c e8
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[57]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x11,0x8B,0x49,0x08,0x85,0xC9,0x77,0x03,0x33,0xC0,0xC3,0x0F,0xB6,0x02,0x41,0xB8,0x01,0x00,0x00,0x00,0x83,0xF9,0x01,0x7E,0x18,0x4D,0x63,0xC8,0x46,0x0F,0xB6,0x0C,0x0A,0x44,0x3B,0xC8,0x7D,0x03,0x41,0x8B,0xC1,0x41,0xFF,0xC0,0x44,0x3B,0xC1,0x7C,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short min(ReadOnlySpan<short> src)
; location: [7FFDDDBC95E0h, 7FFDDDBC9619h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 11
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
000dh ja short 0012h                ; JA(Ja_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 77 03
000fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0012h movsx rax,word ptr [rdx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RDX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 02
0016h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001ch cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
001fh jle short 0039h               ; JLE(Jle_rel8_64) [39h:jmp64]                         encoding(2 bytes) = 7e 18
0021h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0024h movsx r9,word ptr [rdx+r9*2]  ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,RDX:br,DS:sr)]     encoding(5 bytes) = 4e 0f bf 0c 4a
0029h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
002ch jge short 0031h               ; JGE(Jge_rel8_64) [31h:jmp64]                         encoding(2 bytes) = 7d 03
002eh mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
0031h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0034h cmp r8d,ecx                   ; CMP(Cmp_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 3b c1
0037h jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c e8
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[58]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x11,0x8B,0x49,0x08,0x85,0xC9,0x77,0x03,0x33,0xC0,0xC3,0x48,0x0F,0xBF,0x02,0x41,0xB8,0x01,0x00,0x00,0x00,0x83,0xF9,0x01,0x7E,0x18,0x4D,0x63,0xC8,0x4E,0x0F,0xBF,0x0C,0x4A,0x44,0x3B,0xC8,0x7D,0x03,0x41,0x8B,0xC1,0x41,0xFF,0xC0,0x44,0x3B,0xC1,0x7C,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort min(ReadOnlySpan<ushort> src)
; location: [7FFDDDBC9630h, 7FFDDDBC9668h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 11
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
000dh ja short 0012h                ; JA(Ja_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 77 03
000fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0012h movzx eax,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 02
0015h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001bh cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
001eh jle short 0038h               ; JLE(Jle_rel8_64) [38h:jmp64]                         encoding(2 bytes) = 7e 18
0020h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0023h movzx r9d,word ptr [rdx+r9*2] ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,RDX:br,DS:sr)]    encoding(5 bytes) = 46 0f b7 0c 4a
0028h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
002bh jge short 0030h               ; JGE(Jge_rel8_64) [30h:jmp64]                         encoding(2 bytes) = 7d 03
002dh mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
0030h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0033h cmp r8d,ecx                   ; CMP(Cmp_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 3b c1
0036h jl short 0020h                ; JL(Jl_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 7c e8
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[57]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x11,0x8B,0x49,0x08,0x85,0xC9,0x77,0x03,0x33,0xC0,0xC3,0x0F,0xB7,0x02,0x41,0xB8,0x01,0x00,0x00,0x00,0x83,0xF9,0x01,0x7E,0x18,0x4D,0x63,0xC8,0x46,0x0F,0xB7,0x0C,0x4A,0x44,0x3B,0xC8,0x7D,0x03,0x41,0x8B,0xC1,0x41,0xFF,0xC0,0x44,0x3B,0xC1,0x7C,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int min(ReadOnlySpan<int> src)
; location: [7FFDDDBC9680h, 7FFDDDBC96B6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 11
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
000dh ja short 0012h                ; JA(Ja_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 77 03
000fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0012h mov eax,[rdx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 02
0014h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001ah cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
001dh jle short 0036h               ; JLE(Jle_rel8_64) [36h:jmp64]                         encoding(2 bytes) = 7e 17
001fh movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0022h mov r9d,[rdx+r9*4]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 46 8b 0c 8a
0026h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
0029h jge short 002eh               ; JGE(Jge_rel8_64) [2Eh:jmp64]                         encoding(2 bytes) = 7d 03
002bh mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
002eh inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0031h cmp r8d,ecx                   ; CMP(Cmp_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 3b c1
0034h jl short 001fh                ; JL(Jl_rel8_64) [1Fh:jmp64]                           encoding(2 bytes) = 7c e9
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x11,0x8B,0x49,0x08,0x85,0xC9,0x77,0x03,0x33,0xC0,0xC3,0x8B,0x02,0x41,0xB8,0x01,0x00,0x00,0x00,0x83,0xF9,0x01,0x7E,0x17,0x4D,0x63,0xC8,0x46,0x8B,0x0C,0x8A,0x44,0x3B,0xC8,0x7D,0x03,0x41,0x8B,0xC1,0x41,0xFF,0xC0,0x44,0x3B,0xC1,0x7C,0xE9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint min(ReadOnlySpan<uint> src)
; location: [7FFDDDBC96D0h, 7FFDDDBC9706h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 11
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
000dh ja short 0012h                ; JA(Ja_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 77 03
000fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0012h mov eax,[rdx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 02
0014h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001ah cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
001dh jle short 0036h               ; JLE(Jle_rel8_64) [36h:jmp64]                         encoding(2 bytes) = 7e 17
001fh movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0022h mov r9d,[rdx+r9*4]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 46 8b 0c 8a
0026h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
0029h jae short 002eh               ; JAE(Jae_rel8_64) [2Eh:jmp64]                         encoding(2 bytes) = 73 03
002bh mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
002eh inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0031h cmp r8d,ecx                   ; CMP(Cmp_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 3b c1
0034h jl short 001fh                ; JL(Jl_rel8_64) [1Fh:jmp64]                           encoding(2 bytes) = 7c e9
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x11,0x8B,0x49,0x08,0x85,0xC9,0x77,0x03,0x33,0xC0,0xC3,0x8B,0x02,0x41,0xB8,0x01,0x00,0x00,0x00,0x83,0xF9,0x01,0x7E,0x17,0x4D,0x63,0xC8,0x46,0x8B,0x0C,0x8A,0x44,0x3B,0xC8,0x73,0x03,0x41,0x8B,0xC1,0x41,0xFF,0xC0,0x44,0x3B,0xC1,0x7C,0xE9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long min(ReadOnlySpan<long> src)
; location: [7FFDDDBC9720h, 7FFDDDBC9757h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 11
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
000dh ja short 0012h                ; JA(Ja_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 77 03
000fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0012h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0015h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001bh cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
001eh jle short 0037h               ; JLE(Jle_rel8_64) [37h:jmp64]                         encoding(2 bytes) = 7e 17
0020h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0023h mov r9,[rdx+r9*8]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,DS:sr)]         encoding(4 bytes) = 4e 8b 0c ca
0027h cmp r9,rax                    ; CMP(Cmp_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 3b c8
002ah jge short 002fh               ; JGE(Jge_rel8_64) [2Fh:jmp64]                         encoding(2 bytes) = 7d 03
002ch mov rax,r9                    ; MOV(Mov_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 8b c1
002fh inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0032h cmp r8d,ecx                   ; CMP(Cmp_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 3b c1
0035h jl short 0020h                ; JL(Jl_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 7c e9
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[56]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x11,0x8B,0x49,0x08,0x85,0xC9,0x77,0x03,0x33,0xC0,0xC3,0x48,0x8B,0x02,0x41,0xB8,0x01,0x00,0x00,0x00,0x83,0xF9,0x01,0x7E,0x17,0x4D,0x63,0xC8,0x4E,0x8B,0x0C,0xCA,0x4C,0x3B,0xC8,0x7D,0x03,0x49,0x8B,0xC1,0x41,0xFF,0xC0,0x44,0x3B,0xC1,0x7C,0xE9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong min(ReadOnlySpan<ulong> src)
; location: [7FFDDDBC9770h, 7FFDDDBC97A7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 11
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
000dh ja short 0012h                ; JA(Ja_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 77 03
000fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0012h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0015h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001bh cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
001eh jle short 0037h               ; JLE(Jle_rel8_64) [37h:jmp64]                         encoding(2 bytes) = 7e 17
0020h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0023h mov r9,[rdx+r9*8]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,DS:sr)]         encoding(4 bytes) = 4e 8b 0c ca
0027h cmp r9,rax                    ; CMP(Cmp_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 3b c8
002ah jae short 002fh               ; JAE(Jae_rel8_64) [2Fh:jmp64]                         encoding(2 bytes) = 73 03
002ch mov rax,r9                    ; MOV(Mov_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 8b c1
002fh inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0032h cmp r8d,ecx                   ; CMP(Cmp_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 3b c1
0035h jl short 0020h                ; JL(Jl_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 7c e9
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[56]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x11,0x8B,0x49,0x08,0x85,0xC9,0x77,0x03,0x33,0xC0,0xC3,0x48,0x8B,0x02,0x41,0xB8,0x01,0x00,0x00,0x00,0x83,0xF9,0x01,0x7E,0x17,0x4D,0x63,0xC8,0x4E,0x8B,0x0C,0xCA,0x4C,0x3B,0xC8,0x73,0x03,0x49,0x8B,0xC1,0x41,0xFF,0xC0,0x44,0x3B,0xC1,0x7C,0xE9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float min(ReadOnlySpan<float> src)
; location: [7FFDDDBC97C0h, 7FFDDDBC97FBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh ja short 0014h                ; JA(Ja_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 77 05
000fh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0014h vmovss xmm0,dword ptr [rax]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 00
0018h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
001dh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0020h jle short 003bh               ; JLE(Jle_rel8_64) [3Bh:jmp64]                         encoding(2 bytes) = 7e 19
0022h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
0025h vmovss xmm1,dword ptr [rax+r8*4]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RAX:br,DS:sr)] encoding(VEX, 6 bytes) = c4 a1 7a 10 0c 80
002bh vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
002fh jbe short 0035h               ; JBE(Jbe_rel8_64) [35h:jmp64]                         encoding(2 bytes) = 76 04
0031h vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
0035h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
0037h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0039h jl short 0022h                ; JL(Jl_rel8_64) [22h:jmp64]                           encoding(2 bytes) = 7c e7
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[60]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x85,0xD2,0x77,0x05,0xC5,0xF8,0x57,0xC0,0xC3,0xC5,0xFA,0x10,0x00,0xB9,0x01,0x00,0x00,0x00,0x83,0xFA,0x01,0x7E,0x19,0x4C,0x63,0xC1,0xC4,0xA1,0x7A,0x10,0x0C,0x80,0xC5,0xF8,0x2E,0xC1,0x76,0x04,0xC5,0xF8,0x28,0xC1,0xFF,0xC1,0x3B,0xCA,0x7C,0xE7,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double min(ReadOnlySpan<double> src)
; location: [7FFDDDBC9810h, 7FFDDDBC984Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh ja short 0014h                ; JA(Ja_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 77 05
000fh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0014h vmovsd xmm0,qword ptr [rax]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 00
0018h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
001dh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0020h jle short 003bh               ; JLE(Jle_rel8_64) [3Bh:jmp64]                         encoding(2 bytes) = 7e 19
0022h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
0025h vmovsd xmm1,qword ptr [rax+r8*8]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RAX:br,DS:sr)] encoding(VEX, 6 bytes) = c4 a1 7b 10 0c c0
002bh vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
002fh jbe short 0035h               ; JBE(Jbe_rel8_64) [35h:jmp64]                         encoding(2 bytes) = 76 04
0031h vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
0035h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
0037h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0039h jl short 0022h                ; JL(Jl_rel8_64) [22h:jmp64]                           encoding(2 bytes) = 7c e7
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[60]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x85,0xD2,0x77,0x05,0xC5,0xF8,0x57,0xC0,0xC3,0xC5,0xFB,0x10,0x00,0xB9,0x01,0x00,0x00,0x00,0x83,0xFA,0x01,0x7E,0x19,0x4C,0x63,0xC1,0xC4,0xA1,0x7B,0x10,0x0C,0xC0,0xC5,0xF9,0x2E,0xC1,0x76,0x04,0xC5,0xF8,0x28,0xC1,0xFF,0xC1,0x3B,0xCA,0x7C,0xE7,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mod(sbyte lhs, sbyte rhs)
; location: [7FFDDDBC9860h, 7FFDDDBC9874h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]                        encoding(4 bytes) = 48 0f be ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mod(byte lhs, byte rhs)
; location: [7FFDDDBC9890h, 7FFDDDBC98A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mod(short lhs, short rhs)
; location: [7FFDDDBC98C0h, 7FFDDDBC98D4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                  ; MOVSX(Movsx_r64_rm16) [RCX,DX]                       encoding(4 bytes) = 48 0f bf ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mod(ushort lhs, ushort rhs)
; location: [7FFDDDBC98F0h, 7FFDDDBC9901h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x99,0xF7,0xF9,0x0F,0xB7,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mod(int lhs, int rhs)
; location: [7FFDDDBC9920h, 7FFDDDBC9930h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod(uint lhs, uint rhs)
; location: [7FFDDDBC9950h, 7FFDDDBC9961h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mod(long lhs, long rhs)
; location: [7FFDDDBC9980h, 7FFDDDBC9993h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mod(ulong lhs, ulong rhs)
; location: [7FFDDDBC99B0h, 7FFDDDBC99C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte mod(ref sbyte lhs, in sbyte rhs)
; location: [7FFDDDBC99E0h, 7FFDDDBC99F6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h movsx r8,byte ptr [rdx]       ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RDX:br,DS:sr)]       encoding(4 bytes) = 4c 0f be 02
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
0011h mov [rcx],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),DL]            encoding(2 bytes) = 88 11
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x4C,0x0F,0xBE,0x02,0x99,0x41,0xF7,0xF8,0x88,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte mod(ref byte lhs, in byte rhs)
; location: [7FFDDDBC9A10h, 7FFDDDBC9A25h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h movzx r8d,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RDX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 02
000ch cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000dh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
0010h mov [rcx],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),DL]            encoding(2 bytes) = 88 11
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x44,0x0F,0xB6,0x02,0x99,0x41,0xF7,0xF8,0x88,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short mod(ref short lhs, in short rhs)
; location: [7FFDDDBC9A40h, 7FFDDDBC9A57h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h movsx r8,word ptr [rdx]       ; MOVSX(Movsx_r64_rm16) [R8,mem(16i,RDX:br,DS:sr)]     encoding(4 bytes) = 4c 0f bf 02
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
0011h mov [rcx],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 11
0014h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x4C,0x0F,0xBF,0x02,0x99,0x41,0xF7,0xF8,0x66,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort mod(ref ushort lhs, in ushort rhs)
; location: [7FFDDDBC9A70h, 7FFDDDBC9A86h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h movzx r8d,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RDX:br,DS:sr)]    encoding(4 bytes) = 44 0f b7 02
000ch cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000dh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
0010h mov [rcx],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 11
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x44,0x0F,0xB7,0x02,0x99,0x41,0xF7,0xF8,0x66,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int mod(ref int lhs, in int rhs)
; location: [7FFDDDBC9AA0h, 7FFDDDBC9AB3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv dword ptr [r8]           ; IDIV(Idiv_rm32) [mem(32i,R8:br,DS:sr)]               encoding(3 bytes) = 41 f7 38
000eh mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x8B,0x01,0x99,0x41,0xF7,0x38,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint mod(ref uint lhs, in uint rhs)
; location: [7FFDDDBC9AD0h, 7FFDDDBC9AE4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div dword ptr [r8]            ; DIV(Div_rm32) [mem(32u,R8:br,DS:sr)]                 encoding(3 bytes) = 41 f7 30
000fh mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x8B,0x01,0x33,0xD2,0x41,0xF7,0x30,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long mod(ref long lhs, in long rhs)
; location: [7FFDDDBC9B00h, 7FFDDDBC9B16h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv qword ptr [r8]           ; IDIV(Idiv_rm64) [mem(64i,R8:br,DS:sr)]               encoding(3 bytes) = 49 f7 38
0010h mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0x01,0x48,0x99,0x49,0xF7,0x38,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mod(ref ulong lhs, in ulong rhs)
; location: [7FFDDDBC9B30h, 7FFDDDBC9B46h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div qword ptr [r8]            ; DIV(Div_rm64) [mem(64u,R8:br,DS:sr)]                 encoding(3 bytes) = 49 f7 30
0010h mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0x01,0x33,0xD2,0x49,0xF7,0x30,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mul(sbyte lhs, sbyte rhs)
; location: [7FFDDDBC9B60h, 7FFDDDBC9B74h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mul(byte lhs, byte rhs)
; location: [7FFDDDBC9B90h, 7FFDDDBC9BA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mul(short lhs, short rhs)
; location: [7FFDDDBC9BC0h, 7FFDDDBC9BD4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mul(ushort lhs, ushort rhs)
; location: [7FFDDDBC9BF0h, 7FFDDDBC9C01h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mul(int lhs, int rhs)
; location: [7FFDDDBC9C20h, 7FFDDDBC9C2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul(uint lhs, uint rhs)
; location: [7FFDDDBC9C40h, 7FFDDDBC9C4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mul(long lhs, long rhs)
; location: [7FFDDDBC9C60h, 7FFDDDBC9C6Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul(ulong lhs, ulong rhs)
; location: [7FFDDDBC9C80h, 7FFDDDBC9C8Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte mul(ref sbyte lhs, sbyte rhs)
; location: [7FFDDDBC9CA0h, 7FFDDDBC9CB5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte mul(ref byte lhs, byte rhs)
; location: [7FFDDDBC9CD0h, 7FFDDDBC9CE3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short mul(ref short lhs, short rhs)
; location: [7FFDDDBC9D00h, 7FFDDDBC9D16h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort mul(ref ushort lhs, ushort rhs)
; location: [7FFDDDBC9D30h, 7FFDDDBC9D44h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int mul(ref int lhs, int rhs)
; location: [7FFDDDBC9D60h, 7FFDDDBC9D6Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,[rcx]                ; IMUL(Imul_r32_rm32) [EDX,mem(32i,RCX:br,DS:sr)]      encoding(3 bytes) = 0f af 11
0008h mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0x11,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint mul(ref uint lhs, uint rhs)
; location: [7FFDDDBC9D80h, 7FFDDDBC9D8Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,[rcx]                ; IMUL(Imul_r32_rm32) [EDX,mem(32i,RCX:br,DS:sr)]      encoding(3 bytes) = 0f af 11
0008h mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0x11,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long mul(ref long lhs, long rhs)
; location: [7FFDDDBC9DA0h, 7FFDDDBC9DAFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,[rcx]                ; IMUL(Imul_r64_rm64) [RDX,mem(64i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f af 11
0009h mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0x11,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mul(ref ulong lhs, ulong rhs)
; location: [7FFDDDBC9DC0h, 7FFDDDBC9DCFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,[rcx]                ; IMUL(Imul_r64_rm64) [RDX,mem(64i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f af 11
0009h mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0x11,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte negate(sbyte src)
; location: [7FFDDDBC9DE0h, 7FFDDDBC9DEFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte negate(byte src)
; location: [7FFDDDBC9E00h, 7FFDDDBC9E0Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short negate(short src)
; location: [7FFDDDBC9E20h, 7FFDDDBC9E2Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort negate(ushort src)
; location: [7FFDDDBC9E40h, 7FFDDDBC9E4Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int negate(int src)
; location: [7FFDDDBC9E60h, 7FFDDDBC9E69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint negate(uint src)
; location: [7FFDDDBC9E80h, 7FFDDDBC9E8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long negate(long src)
; location: [7FFDDDBC9EA0h, 7FFDDDBC9EABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h neg rax                       ; NEG(Neg_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong negate(ulong src)
; location: [7FFDDDBC9EC0h, 7FFDDDBC9ECEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float negate(float src)
; location: [7FFDDDBC9EE0h, 7FFDDDBC9EF1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFDDDBC9EF8h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double negate(double src)
; location: [7FFDDDBC9F10h, 7FFDDDBC9F21h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFDDDBC9F28h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte negate(ref sbyte src)
; location: [7FFDDDBC9F40h, 7FFDDDBC9F4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h neg byte ptr [rcx]            ; NEG(Neg_rm8) [mem(8i,RCX:br,DS:sr)]                  encoding(2 bytes) = f6 19
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0x19,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte negate(ref byte src)
; location: [7FFDDDBC9F60h, 7FFDDDBC9F71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xF7,0xD0,0xFF,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short negate(ref short src)
; location: [7FFDDDBC9F90h, 7FFDDDBC9F9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h neg word ptr [rcx]            ; NEG(Neg_rm16) [mem(16i,RCX:br,DS:sr)]                encoding(3 bytes) = 66 f7 19
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xF7,0x19,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort negate(ref ushort src)
; location: [7FFDDDBC9FB0h, 7FFDDDBC9FC2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xF7,0xD0,0xFF,0xC0,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int negate(ref int src)
; location: [7FFDDDBC9FE0h, 7FFDDDBC9FEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h neg dword ptr [rcx]           ; NEG(Neg_rm32) [mem(32i,RCX:br,DS:sr)]                encoding(2 bytes) = f7 19
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF7,0x19,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint negate(ref uint src)
; location: [7FFDDDBCA000h, 7FFDDDBCA010h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0xF7,0xD0,0xFF,0xC0,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long negate(ref long src)
; location: [7FFDDDBCA030h, 7FFDDDBCA03Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h neg qword ptr [rcx]           ; NEG(Neg_rm64) [mem(64i,RCX:br,DS:sr)]                encoding(3 bytes) = 48 f7 19
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xF7,0x19,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong negate(ref ulong src)
; location: [7FFDDDBCA050h, 7FFDDDBCA064h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float negate(ref float src)
; location: [7FFDDDBCA080h, 7FFDDDBCA09Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
0009h vmovss xmm1,dword ptr [7FFDDDBCA0A8h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 17 00 00 00
0011h vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0015h vmovss dword ptr [rcx],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 01
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x10,0x0D,0x17,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC5,0xFA,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double negate(ref double src)
; location: [7FFDDDBCA0C0h, 7FFDDDBCA0DCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
0009h vmovsd xmm1,qword ptr [7FFDDDBCA0E8h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 17 00 00 00
0011h vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0015h vmovsd qword ptr [rcx],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 01
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x10,0x0D,0x17,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC5,0xFB,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte negate(sbyte src, ref sbyte dst)
; location: [7FFDDDBCA100h, 7FFDDDBCA110h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
000dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x88,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte negate(byte src, ref byte dst)
; location: [7FFDDDBCA130h, 7FFDDDBCA141h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x88,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short negate(short src, ref short dst)
; location: [7FFDDDBCA160h, 7FFDDDBCA171h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x66,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort negate(ushort src, ref ushort dst)
; location: [7FFDDDBCA190h, 7FFDDDBCA1A2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x66,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int negate(int src, ref int dst)
; location: [7FFDDDBCA1C0h, 7FFDDDBCA1CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0009h mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint negate(uint src, ref uint dst)
; location: [7FFDDDBCA1E0h, 7FFDDDBCA1F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
000dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long negate(long src, ref long dst)
; location: [7FFDDDBCA210h, 7FFDDDBCA221h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h neg rax                       ; NEG(Neg_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d8
000bh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0x48,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong negate(ulong src, ref ulong dst)
; location: [7FFDDDBCA240h, 7FFDDDBCA254h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0011h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0x48,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float negate(float src, ref float dst)
; location: [7FFDDDBCA270h, 7FFDDDBCA288h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFDDDBCA290h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 13 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h vmovss dword ptr [rdx],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 02
0015h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x13,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC5,0xFA,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double negate(double src, ref double dst)
; location: [7FFDDDBCA2B0h, 7FFDDDBCA2C8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFDDDBCA2D0h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 13 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h vmovsd qword ptr [rdx],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 02
0015h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x13,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC5,0xFB,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(sbyte lhs, sbyte rhs)
; location: [7FFDDDBCA2F0h, 7FFDDDBCA305h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(byte lhs, byte rhs)
; location: [7FFDDDBCA320h, 7FFDDDBCA333h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(short lhs, short rhs)
; location: [7FFDDDBCA350h, 7FFDDDBCA365h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(ushort lhs, ushort rhs)
; location: [7FFDDDBCA380h, 7FFDDDBCA393h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(int lhs, int rhs)
; location: [7FFDDDBCA3B0h, 7FFDDDBCA3BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(uint lhs, uint rhs)
; location: [7FFDDDBCA3D0h, 7FFDDDBCA3DDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(long lhs, long rhs)
; location: [7FFDDDBCA3F0h, 7FFDDDBCA3FEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(ulong lhs, ulong rhs)
; location: [7FFDDDBCA410h, 7FFDDDBCA41Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(float lhs, float rhs)
; location: [7FFDDDBCA430h, 7FFDDDBCA444h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setp al                       ; SETP(Setp_rm8) [AL]                                  encoding(3 bytes) = 0f 9a c0
000ch jp short 0011h                ; JP(Jp_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7a 03
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(double lhs, double rhs)
; location: [7FFDDDBCA460h, 7FFDDDBCA474h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setp al                       ; SETP(Setp_rm8) [AL]                                  encoding(3 bytes) = 0f 9a c0
000ch jp short 0011h                ; JP(Jp_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7a 03
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(in sbyte lhs, in sbyte rhs)
; location: [7FFDDDBCA490h, 7FFDDDBCA4A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h cmp al,[rdx]                  ; CMP(Cmp_r8_rm8) [AL,mem(8u,RDX:br,DS:sr)]            encoding(2 bytes) = 3a 02
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x3A,0x02,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(in byte lhs, in byte rhs)
; location: [7FFDDDBCA4C0h, 7FFDDDBCA4D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h cmp al,[rdx]                  ; CMP(Cmp_r8_rm8) [AL,mem(8u,RDX:br,DS:sr)]            encoding(2 bytes) = 3a 02
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x3A,0x02,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(in short lhs, in short rhs)
; location: [7FFDDDBCA4F0h, 7FFDDDBCA502h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h cmp ax,[rdx]                  ; CMP(Cmp_r16_rm16) [AX,mem(16u,RDX:br,DS:sr)]         encoding(3 bytes) = 66 3b 02
000ch setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x66,0x3B,0x02,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(in ushort lhs, in ushort rhs)
; location: [7FFDDDBCA520h, 7FFDDDBCA531h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h cmp ax,[rdx]                  ; CMP(Cmp_r16_rm16) [AX,mem(16u,RDX:br,DS:sr)]         encoding(3 bytes) = 66 3b 02
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x66,0x3B,0x02,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(in int lhs, in int rhs)
; location: [7FFDDDBCA550h, 7FFDDDBCA55Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h cmp eax,[rdx]                 ; CMP(Cmp_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 3b 02
0009h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x3B,0x02,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(in uint lhs, in uint rhs)
; location: [7FFDDDBCA570h, 7FFDDDBCA57Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h cmp eax,[rdx]                 ; CMP(Cmp_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 3b 02
0009h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x3B,0x02,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(in long lhs, in long rhs)
; location: [7FFDDDBCA590h, 7FFDDDBCA5A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h cmp rax,[rdx]                 ; CMP(Cmp_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 3b 02
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x3B,0x02,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(in ulong lhs, in ulong rhs)
; location: [7FFDDDBCA5C0h, 7FFDDDBCA5D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h cmp rax,[rdx]                 ; CMP(Cmp_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 3b 02
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x3B,0x02,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(in float lhs, in float rhs)
; location: [7FFDDDBCA5F0h, 7FFDDDBCA608h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
0009h vucomiss xmm0,dword ptr [rdx] ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,mem(Float32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f8 2e 02
000dh setp al                       ; SETP(Setp_rm8) [AL]                                  encoding(3 bytes) = 0f 9a c0
0010h jp short 0015h                ; JP(Jp_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 7a 03
0012h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x01,0xC5,0xF8,0x2E,0x02,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(in double lhs, in double rhs)
; location: [7FFDDDBCA620h, 7FFDDDBCA638h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
0009h vucomisd xmm0,qword ptr [rdx] ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,mem(Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 2e 02
000dh setp al                       ; SETP(Setp_rm8) [AL]                                  encoding(3 bytes) = 0f 9a c0
0010h jp short 0015h                ; JP(Jp_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 7a 03
0012h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x01,0xC5,0xF9,0x2E,0x02,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(sbyte src)
; location: [7FFDDDBCA650h, 7FFDDDBCA661h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(byte src)
; location: [7FFDDDBCA680h, 7FFDDDBCA68Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(short src)
; location: [7FFDDDBCA6A0h, 7FFDDDBCA6B1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(ushort src)
; location: [7FFDDDBCA6D0h, 7FFDDDBCA6E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(int src)
; location: [7FFDDDBCA700h, 7FFDDDBCA70Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(uint src)
; location: [7FFDDDBCA720h, 7FFDDDBCA72Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(long src)
; location: [7FFDDDBCA740h, 7FFDDDBCA74Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(ulong src)
; location: [7FFDDDBCA760h, 7FFDDDBCA76Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(float src)
; location: [7FFDDDBCA780h, 7FFDDDBCA798h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
000dh setp al                       ; SETP(Setp_rm8) [AL]                                  encoding(3 bytes) = 0f 9a c0
0010h jp short 0015h                ; JP(Jp_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 7a 03
0012h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(double src)
; location: [7FFDDDBCA7B0h, 7FFDDDBCA7C8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
000dh setp al                       ; SETP(Setp_rm8) [AL]                                  encoding(3 bytes) = 0f 9a c0
0010h jp short 0015h                ; JP(Jp_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 7a 03
0012h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte or(sbyte lhs, sbyte rhs)
; location: [7FFDDDBCA7E0h, 7FFDDDBCA7F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte or(byte lhs, byte rhs)
; location: [7FFDDDBCA810h, 7FFDDDBCA820h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short or(short lhs, short rhs)
; location: [7FFDDDBCA840h, 7FFDDDBCA853h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort or(ushort lhs, ushort rhs)
; location: [7FFDDDBCA870h, 7FFDDDBCA880h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int or(int lhs, int rhs)
; location: [7FFDDDBCA8A0h, 7FFDDDBCA8A9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint or(uint lhs, uint rhs)
; location: [7FFDDDBCA8C0h, 7FFDDDBCA8C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long div(ref long lhs, in long rhs)
; location: [7FFDDDBCA8E0h, 7FFDDDBCA8F6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv qword ptr [r8]           ; IDIV(Idiv_rm64) [mem(64i,R8:br,DS:sr)]               encoding(3 bytes) = 49 f7 38
0010h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0x01,0x48,0x99,0x49,0xF7,0x38,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong div(ref ulong lhs, in ulong rhs)
; location: [7FFDDDBCA910h, 7FFDDDBCA926h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div qword ptr [r8]            ; DIV(Div_rm64) [mem(64u,R8:br,DS:sr)]                 encoding(3 bytes) = 49 f7 30
0010h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0x01,0x33,0xD2,0x49,0xF7,0x30,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides(sbyte lhs, sbyte rhs)
; location: [7FFDDDBCA940h, 7FFDDDBCA958h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dividesBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x48,0x0F,0xBE,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides(byte lhs, byte rhs)
; location: [7FFDDDBCA970h, 7FFDDDBCA986h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dividesBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x0F,0xB6,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides(short lhs, short rhs)
; location: [7FFDDDBCA9A0h, 7FFDDDBCA9B8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dividesBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x48,0x0F,0xBF,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides(ushort lhs, ushort rhs)
; location: [7FFDDDBCA9D0h, 7FFDDDBCA9E6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dividesBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x0F,0xB7,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides(int lhs, int rhs)
; location: [7FFDDDBCAA00h, 7FFDDDBCAA12h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0008h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000ah test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000ch sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dividesBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides(uint lhs, uint rhs)
; location: [7FFDDDBCAA30h, 7FFDDDBCAA43h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0009h div ecx                       ; DIV(Div_rm32) [ECX]                                  encoding(2 bytes) = f7 f1
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dividesBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x33,0xD2,0xF7,0xF1,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides(long lhs, long rhs)
; location: [7FFDDDBCAA60h, 7FFDDDBCAA76h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000ah idiv rcx                      ; IDIV(Idiv_rm64) [RCX]                                encoding(3 bytes) = 48 f7 f9
000dh test rdx,rdx                  ; TEST(Test_rm64_r64) [RDX,RDX]                        encoding(3 bytes) = 48 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dividesBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x99,0x48,0xF7,0xF9,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides(ulong lhs, ulong rhs)
; location: [7FFDDDBCAA90h, 7FFDDDBCAAA6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ah div rcx                       ; DIV(Div_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 f1
000dh test rdx,rdx                  ; TEST(Test_rm64_r64) [RDX,RDX]                        encoding(3 bytes) = 48 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dividesBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x33,0xD2,0x48,0xF7,0xF1,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte dot(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
; location: [7FFDDDBCAEC0h, 7FFDDDBCAF87h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000ah mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000dh mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0010h mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 01
0013h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
0016h mov esi,1Ch                   ; MOV(Mov_r32_imm32) [ESI,1ch:imm32]                   encoding(5 bytes) = be 1c 00 00 00
001bh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0020h mov ebx,ecx                   ; MOV(Mov_r32_rm32) [EBX,ECX]                          encoding(2 bytes) = 8b d9
0022h mov ebp,edx                   ; MOV(Mov_r32_rm32) [EBP,EDX]                          encoding(2 bytes) = 8b ea
0024h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0026h jne short 0069h               ; JNE(Jne_rel8_64) [69h:jmp64]                         encoding(2 bytes) = 75 41
0028h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
002bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
002eh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0030h jle short 005bh               ; JLE(Jle_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 7e 29
0032h movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
0035h movsx rbx,byte ptr [r8+r11]   ; MOVSX(Movsx_r64_rm8) [RBX,mem(8i,R8:br,DS:sr)]       encoding(5 bytes) = 4b 0f be 1c 18
003ah cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
003dh jae near ptr 00c2h            ; JAE(Jae_rel32_64) [C2h:jmp64]                        encoding(6 bytes) = 0f 83 7f 00 00 00
0043h movsx r11,byte ptr [rax+r11]  ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,RAX:br,DS:sr)]      encoding(5 bytes) = 4e 0f be 1c 18
0048h imul r11d,ebx                 ; IMUL(Imul_r32_rm32) [R11D,EBX]                       encoding(4 bytes) = 44 0f af db
004ch add r9d,r11d                  ; ADD(Add_r32_rm32) [R9D,R11D]                         encoding(3 bytes) = 45 03 cb
004fh movsx r9,r9b                  ; MOVSX(Movsx_r64_rm8) [R9,R9L]                        encoding(4 bytes) = 4d 0f be c9
0053h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0056h cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
0059h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c d7
005bh mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
005eh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0062h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0063h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0064h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0065h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0066h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0069h mov ecx,125h                  ; MOV(Mov_r32_imm32) [ECX,125h:imm32]                  encoding(5 bytes) = b9 25 01 00 00
006eh mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0078h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F654820h:jmp64]                encoding(5 bytes) = e8 a3 47 65 5f
007dh mov r14,rax                   ; MOV(Mov_r64_rm64) [R14,RAX]                          encoding(3 bytes) = 4c 8b f0
0080h mov ecx,0B4Dh                 ; MOV(Mov_r32_imm32) [ECX,b4dh:imm32]                  encoding(5 bytes) = b9 4d 0b 00 00
0085h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
008fh call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F654820h:jmp64]                encoding(5 bytes) = e8 8c 47 65 5f
0094h mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
0097h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
009ch mov [r8],dil                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),DIL]            encoding(3 bytes) = 41 88 38
009fh mov [r8+4],esi                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ESI]         encoding(4 bytes) = 41 89 70 04
00a3h mov r8,r14                    ; MOV(Mov_r64_rm64) [R8,R14]                           encoding(3 bytes) = 4d 8b c6
00a6h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
00a8h mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00aah mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00afh mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00b4h call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD2AA28h:jmp64]        encoding(5 bytes) = e8 6f a9 d2 ff
00b9h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00bch call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DF630h:jmp64]                encoding(5 bytes) = e8 6f f5 4d 5f
00c1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00c2h call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F654040h:jmp64]                encoding(5 bytes) = e8 79 3f 65 5f
00c7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> dotBytes => new byte[200]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0x02,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x8B,0x49,0x08,0xBE,0x1C,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0x8B,0xD9,0x8B,0xEA,0x3B,0xCA,0x75,0x41,0x45,0x33,0xC9,0x45,0x33,0xD2,0x85,0xC9,0x7E,0x29,0x4D,0x63,0xDA,0x4B,0x0F,0xBE,0x1C,0x18,0x44,0x3B,0xD2,0x0F,0x83,0x7F,0x00,0x00,0x00,0x4E,0x0F,0xBE,0x1C,0x18,0x44,0x0F,0xAF,0xDB,0x45,0x03,0xCB,0x4D,0x0F,0xBE,0xC9,0x41,0xFF,0xC2,0x44,0x3B,0xD1,0x7C,0xD7,0x41,0x8B,0xC1,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xB9,0x25,0x01,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0xA3,0x47,0x65,0x5F,0x4C,0x8B,0xF0,0xB9,0x4D,0x0B,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x8C,0x47,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0x41,0x88,0x38,0x41,0x89,0x70,0x04,0x4D,0x8B,0xC6,0x8B,0xCB,0x8B,0xD5,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0xE8,0x6F,0xA9,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0x6F,0xF5,0x4D,0x5F,0xCC,0xE8,0x79,0x3F,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte dot(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
; location: [7FFDDDBCAFB0h, 7FFDDDBCB077h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000ah mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000dh mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0010h mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 01
0013h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
0016h mov esi,2Ah                   ; MOV(Mov_r32_imm32) [ESI,2ah:imm32]                   encoding(5 bytes) = be 2a 00 00 00
001bh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0020h mov ebx,ecx                   ; MOV(Mov_r32_rm32) [EBX,ECX]                          encoding(2 bytes) = 8b d9
0022h mov ebp,edx                   ; MOV(Mov_r32_rm32) [EBP,EDX]                          encoding(2 bytes) = 8b ea
0024h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0026h jne short 0069h               ; JNE(Jne_rel8_64) [69h:jmp64]                         encoding(2 bytes) = 75 41
0028h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
002bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
002eh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0030h jle short 005bh               ; JLE(Jle_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 7e 29
0032h movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
0035h movzx ebx,byte ptr [r8+r11]   ; MOVZX(Movzx_r32_rm8) [EBX,mem(8u,R8:br,DS:sr)]       encoding(5 bytes) = 43 0f b6 1c 18
003ah cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
003dh jae near ptr 00c2h            ; JAE(Jae_rel32_64) [C2h:jmp64]                        encoding(6 bytes) = 0f 83 7f 00 00 00
0043h movzx r11d,byte ptr [rax+r11] ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RAX:br,DS:sr)]     encoding(5 bytes) = 46 0f b6 1c 18
0048h imul r11d,ebx                 ; IMUL(Imul_r32_rm32) [R11D,EBX]                       encoding(4 bytes) = 44 0f af db
004ch add r9d,r11d                  ; ADD(Add_r32_rm32) [R9D,R11D]                         encoding(3 bytes) = 45 03 cb
004fh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0053h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0056h cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
0059h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c d7
005bh mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
005eh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0062h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0063h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0064h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0065h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0066h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0069h mov ecx,125h                  ; MOV(Mov_r32_imm32) [ECX,125h:imm32]                  encoding(5 bytes) = b9 25 01 00 00
006eh mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0078h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F654730h:jmp64]                encoding(5 bytes) = e8 b3 46 65 5f
007dh mov r14,rax                   ; MOV(Mov_r64_rm64) [R14,RAX]                          encoding(3 bytes) = 4c 8b f0
0080h mov ecx,0B4Dh                 ; MOV(Mov_r32_imm32) [ECX,b4dh:imm32]                  encoding(5 bytes) = b9 4d 0b 00 00
0085h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
008fh call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F654730h:jmp64]                encoding(5 bytes) = e8 9c 46 65 5f
0094h mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
0097h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
009ch mov [r8],dil                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),DIL]            encoding(3 bytes) = 41 88 38
009fh mov [r8+4],esi                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ESI]         encoding(4 bytes) = 41 89 70 04
00a3h mov r8,r14                    ; MOV(Mov_r64_rm64) [R8,R14]                           encoding(3 bytes) = 4d 8b c6
00a6h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
00a8h mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00aah mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00afh mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00b4h call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD2A938h:jmp64]        encoding(5 bytes) = e8 7f a8 d2 ff
00b9h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00bch call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DF540h:jmp64]                encoding(5 bytes) = e8 7f f4 4d 5f
00c1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00c2h call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F653F50h:jmp64]                encoding(5 bytes) = e8 89 3e 65 5f
00c7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> dotBytes => new byte[200]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0x02,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x8B,0x49,0x08,0xBE,0x2A,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0x8B,0xD9,0x8B,0xEA,0x3B,0xCA,0x75,0x41,0x45,0x33,0xC9,0x45,0x33,0xD2,0x85,0xC9,0x7E,0x29,0x4D,0x63,0xDA,0x43,0x0F,0xB6,0x1C,0x18,0x44,0x3B,0xD2,0x0F,0x83,0x7F,0x00,0x00,0x00,0x46,0x0F,0xB6,0x1C,0x18,0x44,0x0F,0xAF,0xDB,0x45,0x03,0xCB,0x45,0x0F,0xB6,0xC9,0x41,0xFF,0xC2,0x44,0x3B,0xD1,0x7C,0xD7,0x41,0x8B,0xC1,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xB9,0x25,0x01,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0xB3,0x46,0x65,0x5F,0x4C,0x8B,0xF0,0xB9,0x4D,0x0B,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x9C,0x46,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0x41,0x88,0x38,0x41,0x89,0x70,0x04,0x4D,0x8B,0xC6,0x8B,0xCB,0x8B,0xD5,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0xE8,0x7F,0xA8,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0x7F,0xF4,0x4D,0x5F,0xCC,0xE8,0x89,0x3E,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short dot(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
; location: [7FFDDDBCB0A0h, 7FFDDDBCB167h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000ah mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000dh mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0010h mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 01
0013h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
0016h mov esi,38h                   ; MOV(Mov_r32_imm32) [ESI,38h:imm32]                   encoding(5 bytes) = be 38 00 00 00
001bh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0020h mov ebx,ecx                   ; MOV(Mov_r32_rm32) [EBX,ECX]                          encoding(2 bytes) = 8b d9
0022h mov ebp,edx                   ; MOV(Mov_r32_rm32) [EBP,EDX]                          encoding(2 bytes) = 8b ea
0024h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0026h jne short 0069h               ; JNE(Jne_rel8_64) [69h:jmp64]                         encoding(2 bytes) = 75 41
0028h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
002bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
002eh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0030h jle short 005bh               ; JLE(Jle_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 7e 29
0032h movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
0035h movsx rbx,word ptr [r8+r11*2] ; MOVSX(Movsx_r64_rm16) [RBX,mem(16i,R8:br,DS:sr)]     encoding(5 bytes) = 4b 0f bf 1c 58
003ah cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
003dh jae near ptr 00c2h            ; JAE(Jae_rel32_64) [C2h:jmp64]                        encoding(6 bytes) = 0f 83 7f 00 00 00
0043h movsx r11,word ptr [rax+r11*2]; MOVSX(Movsx_r64_rm16) [R11,mem(16i,RAX:br,DS:sr)]    encoding(5 bytes) = 4e 0f bf 1c 58
0048h imul r11d,ebx                 ; IMUL(Imul_r32_rm32) [R11D,EBX]                       encoding(4 bytes) = 44 0f af db
004ch add r9d,r11d                  ; ADD(Add_r32_rm32) [R9D,R11D]                         encoding(3 bytes) = 45 03 cb
004fh movsx r9,r9w                  ; MOVSX(Movsx_r64_rm16) [R9,R9W]                       encoding(4 bytes) = 4d 0f bf c9
0053h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0056h cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
0059h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c d7
005bh mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
005eh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0062h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0063h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0064h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0065h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0066h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0069h mov ecx,125h                  ; MOV(Mov_r32_imm32) [ECX,125h:imm32]                  encoding(5 bytes) = b9 25 01 00 00
006eh mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0078h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F654640h:jmp64]                encoding(5 bytes) = e8 c3 45 65 5f
007dh mov r14,rax                   ; MOV(Mov_r64_rm64) [R14,RAX]                          encoding(3 bytes) = 4c 8b f0
0080h mov ecx,0B4Dh                 ; MOV(Mov_r32_imm32) [ECX,b4dh:imm32]                  encoding(5 bytes) = b9 4d 0b 00 00
0085h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
008fh call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F654640h:jmp64]                encoding(5 bytes) = e8 ac 45 65 5f
0094h mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
0097h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
009ch mov [r8],dil                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),DIL]            encoding(3 bytes) = 41 88 38
009fh mov [r8+4],esi                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ESI]         encoding(4 bytes) = 41 89 70 04
00a3h mov r8,r14                    ; MOV(Mov_r64_rm64) [R8,R14]                           encoding(3 bytes) = 4d 8b c6
00a6h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
00a8h mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00aah mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00afh mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00b4h call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD2A848h:jmp64]        encoding(5 bytes) = e8 8f a7 d2 ff
00b9h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00bch call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DF450h:jmp64]                encoding(5 bytes) = e8 8f f3 4d 5f
00c1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00c2h call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F653E60h:jmp64]                encoding(5 bytes) = e8 99 3d 65 5f
00c7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> dotBytes => new byte[200]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0x02,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x8B,0x49,0x08,0xBE,0x38,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0x8B,0xD9,0x8B,0xEA,0x3B,0xCA,0x75,0x41,0x45,0x33,0xC9,0x45,0x33,0xD2,0x85,0xC9,0x7E,0x29,0x4D,0x63,0xDA,0x4B,0x0F,0xBF,0x1C,0x58,0x44,0x3B,0xD2,0x0F,0x83,0x7F,0x00,0x00,0x00,0x4E,0x0F,0xBF,0x1C,0x58,0x44,0x0F,0xAF,0xDB,0x45,0x03,0xCB,0x4D,0x0F,0xBF,0xC9,0x41,0xFF,0xC2,0x44,0x3B,0xD1,0x7C,0xD7,0x41,0x8B,0xC1,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xB9,0x25,0x01,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0xC3,0x45,0x65,0x5F,0x4C,0x8B,0xF0,0xB9,0x4D,0x0B,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0xAC,0x45,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0x41,0x88,0x38,0x41,0x89,0x70,0x04,0x4D,0x8B,0xC6,0x8B,0xCB,0x8B,0xD5,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0xE8,0x8F,0xA7,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0x8F,0xF3,0x4D,0x5F,0xCC,0xE8,0x99,0x3D,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort dot(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
; location: [7FFDDDBCB190h, 7FFDDDBCB257h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000ah mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000dh mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0010h mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 01
0013h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
0016h mov esi,46h                   ; MOV(Mov_r32_imm32) [ESI,46h:imm32]                   encoding(5 bytes) = be 46 00 00 00
001bh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0020h mov ebx,ecx                   ; MOV(Mov_r32_rm32) [EBX,ECX]                          encoding(2 bytes) = 8b d9
0022h mov ebp,edx                   ; MOV(Mov_r32_rm32) [EBP,EDX]                          encoding(2 bytes) = 8b ea
0024h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0026h jne short 0069h               ; JNE(Jne_rel8_64) [69h:jmp64]                         encoding(2 bytes) = 75 41
0028h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
002bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
002eh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0030h jle short 005bh               ; JLE(Jle_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 7e 29
0032h movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
0035h movzx ebx,word ptr [r8+r11*2] ; MOVZX(Movzx_r32_rm16) [EBX,mem(16u,R8:br,DS:sr)]     encoding(5 bytes) = 43 0f b7 1c 58
003ah cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
003dh jae near ptr 00c2h            ; JAE(Jae_rel32_64) [C2h:jmp64]                        encoding(6 bytes) = 0f 83 7f 00 00 00
0043h movzx r11d,word ptr [rax+r11*2]; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,DS:sr)]  encoding(5 bytes) = 46 0f b7 1c 58
0048h imul r11d,ebx                 ; IMUL(Imul_r32_rm32) [R11D,EBX]                       encoding(4 bytes) = 44 0f af db
004ch add r9d,r11d                  ; ADD(Add_r32_rm32) [R9D,R11D]                         encoding(3 bytes) = 45 03 cb
004fh movzx r9d,r9w                 ; MOVZX(Movzx_r32_rm16) [R9D,R9W]                      encoding(4 bytes) = 45 0f b7 c9
0053h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0056h cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
0059h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c d7
005bh mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
005eh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0062h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0063h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0064h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0065h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0066h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0069h mov ecx,125h                  ; MOV(Mov_r32_imm32) [ECX,125h:imm32]                  encoding(5 bytes) = b9 25 01 00 00
006eh mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0078h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F654550h:jmp64]                encoding(5 bytes) = e8 d3 44 65 5f
007dh mov r14,rax                   ; MOV(Mov_r64_rm64) [R14,RAX]                          encoding(3 bytes) = 4c 8b f0
0080h mov ecx,0B4Dh                 ; MOV(Mov_r32_imm32) [ECX,b4dh:imm32]                  encoding(5 bytes) = b9 4d 0b 00 00
0085h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
008fh call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F654550h:jmp64]                encoding(5 bytes) = e8 bc 44 65 5f
0094h mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
0097h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
009ch mov [r8],dil                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),DIL]            encoding(3 bytes) = 41 88 38
009fh mov [r8+4],esi                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ESI]         encoding(4 bytes) = 41 89 70 04
00a3h mov r8,r14                    ; MOV(Mov_r64_rm64) [R8,R14]                           encoding(3 bytes) = 4d 8b c6
00a6h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
00a8h mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00aah mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00afh mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00b4h call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD2A758h:jmp64]        encoding(5 bytes) = e8 9f a6 d2 ff
00b9h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00bch call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DF360h:jmp64]                encoding(5 bytes) = e8 9f f2 4d 5f
00c1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00c2h call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F653D70h:jmp64]                encoding(5 bytes) = e8 a9 3c 65 5f
00c7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> dotBytes => new byte[200]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0x02,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x8B,0x49,0x08,0xBE,0x46,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0x8B,0xD9,0x8B,0xEA,0x3B,0xCA,0x75,0x41,0x45,0x33,0xC9,0x45,0x33,0xD2,0x85,0xC9,0x7E,0x29,0x4D,0x63,0xDA,0x43,0x0F,0xB7,0x1C,0x58,0x44,0x3B,0xD2,0x0F,0x83,0x7F,0x00,0x00,0x00,0x46,0x0F,0xB7,0x1C,0x58,0x44,0x0F,0xAF,0xDB,0x45,0x03,0xCB,0x45,0x0F,0xB7,0xC9,0x41,0xFF,0xC2,0x44,0x3B,0xD1,0x7C,0xD7,0x41,0x8B,0xC1,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xB9,0x25,0x01,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0xD3,0x44,0x65,0x5F,0x4C,0x8B,0xF0,0xB9,0x4D,0x0B,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0xBC,0x44,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0x41,0x88,0x38,0x41,0x89,0x70,0x04,0x4D,0x8B,0xC6,0x8B,0xCB,0x8B,0xD5,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0xE8,0x9F,0xA6,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0x9F,0xF2,0x4D,0x5F,0xCC,0xE8,0xA9,0x3C,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int dot(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
; location: [7FFDDDBCB280h, 7FFDDDBCB33Dh]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000ah mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000dh mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0010h mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 01
0013h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
0016h mov esi,54h                   ; MOV(Mov_r32_imm32) [ESI,54h:imm32]                   encoding(5 bytes) = be 54 00 00 00
001bh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0020h mov ebx,ecx                   ; MOV(Mov_r32_rm32) [EBX,ECX]                          encoding(2 bytes) = 8b d9
0022h mov ebp,edx                   ; MOV(Mov_r32_rm32) [EBP,EDX]                          encoding(2 bytes) = 8b ea
0024h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0026h jne short 005fh               ; JNE(Jne_rel8_64) [5Fh:jmp64]                         encoding(2 bytes) = 75 37
0028h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
002bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
002eh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0030h jle short 0051h               ; JLE(Jle_rel8_64) [51h:jmp64]                         encoding(2 bytes) = 7e 1f
0032h movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
0035h mov ebx,[r8+r11*4]            ; MOV(Mov_r32_rm32) [EBX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 43 8b 1c 98
0039h cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
003ch jae short 00b8h               ; JAE(Jae_rel8_64) [B8h:jmp64]                         encoding(2 bytes) = 73 7a
003eh mov r11d,[rax+r11*4]          ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 46 8b 1c 98
0042h imul r11d,ebx                 ; IMUL(Imul_r32_rm32) [R11D,EBX]                       encoding(4 bytes) = 44 0f af db
0046h add r9d,r11d                  ; ADD(Add_r32_rm32) [R9D,R11D]                         encoding(3 bytes) = 45 03 cb
0049h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004ch cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
004fh jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c e1
0051h mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
0054h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0058h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0059h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
005ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005ch pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005fh mov ecx,125h                  ; MOV(Mov_r32_imm32) [ECX,125h:imm32]                  encoding(5 bytes) = b9 25 01 00 00
0064h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
006eh call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F654460h:jmp64]                encoding(5 bytes) = e8 ed 43 65 5f
0073h mov r14,rax                   ; MOV(Mov_r64_rm64) [R14,RAX]                          encoding(3 bytes) = 4c 8b f0
0076h mov ecx,0B4Dh                 ; MOV(Mov_r32_imm32) [ECX,b4dh:imm32]                  encoding(5 bytes) = b9 4d 0b 00 00
007bh mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0085h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F654460h:jmp64]                encoding(5 bytes) = e8 d6 43 65 5f
008ah mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
008dh lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
0092h mov [r8],dil                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),DIL]            encoding(3 bytes) = 41 88 38
0095h mov [r8+4],esi                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ESI]         encoding(4 bytes) = 41 89 70 04
0099h mov r8,r14                    ; MOV(Mov_r64_rm64) [R8,R14]                           encoding(3 bytes) = 4d 8b c6
009ch mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
009eh mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00a0h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00a5h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00aah call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD2A668h:jmp64]        encoding(5 bytes) = e8 b9 a5 d2 ff
00afh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00b2h call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DF270h:jmp64]                encoding(5 bytes) = e8 b9 f1 4d 5f
00b7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00b8h call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F653C80h:jmp64]                encoding(5 bytes) = e8 c3 3b 65 5f
00bdh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> dotBytes => new byte[190]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0x02,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x8B,0x49,0x08,0xBE,0x54,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0x8B,0xD9,0x8B,0xEA,0x3B,0xCA,0x75,0x37,0x45,0x33,0xC9,0x45,0x33,0xD2,0x85,0xC9,0x7E,0x1F,0x4D,0x63,0xDA,0x43,0x8B,0x1C,0x98,0x44,0x3B,0xD2,0x73,0x7A,0x46,0x8B,0x1C,0x98,0x44,0x0F,0xAF,0xDB,0x45,0x03,0xCB,0x41,0xFF,0xC2,0x44,0x3B,0xD1,0x7C,0xE1,0x41,0x8B,0xC1,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xB9,0x25,0x01,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0xED,0x43,0x65,0x5F,0x4C,0x8B,0xF0,0xB9,0x4D,0x0B,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0xD6,0x43,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0x41,0x88,0x38,0x41,0x89,0x70,0x04,0x4D,0x8B,0xC6,0x8B,0xCB,0x8B,0xD5,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0xE8,0xB9,0xA5,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0xB9,0xF1,0x4D,0x5F,0xCC,0xE8,0xC3,0x3B,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dot(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
; location: [7FFDDDBCB360h, 7FFDDDBCB41Dh]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000ah mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000dh mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0010h mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 01
0013h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
0016h mov esi,62h                   ; MOV(Mov_r32_imm32) [ESI,62h:imm32]                   encoding(5 bytes) = be 62 00 00 00
001bh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0020h mov ebx,ecx                   ; MOV(Mov_r32_rm32) [EBX,ECX]                          encoding(2 bytes) = 8b d9
0022h mov ebp,edx                   ; MOV(Mov_r32_rm32) [EBP,EDX]                          encoding(2 bytes) = 8b ea
0024h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0026h jne short 005fh               ; JNE(Jne_rel8_64) [5Fh:jmp64]                         encoding(2 bytes) = 75 37
0028h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
002bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
002eh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0030h jle short 0051h               ; JLE(Jle_rel8_64) [51h:jmp64]                         encoding(2 bytes) = 7e 1f
0032h movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
0035h mov ebx,[r8+r11*4]            ; MOV(Mov_r32_rm32) [EBX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 43 8b 1c 98
0039h cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
003ch jae short 00b8h               ; JAE(Jae_rel8_64) [B8h:jmp64]                         encoding(2 bytes) = 73 7a
003eh mov r11d,[rax+r11*4]          ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 46 8b 1c 98
0042h imul r11d,ebx                 ; IMUL(Imul_r32_rm32) [R11D,EBX]                       encoding(4 bytes) = 44 0f af db
0046h add r9d,r11d                  ; ADD(Add_r32_rm32) [R9D,R11D]                         encoding(3 bytes) = 45 03 cb
0049h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004ch cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
004fh jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c e1
0051h mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
0054h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0058h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0059h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
005ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005ch pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005fh mov ecx,125h                  ; MOV(Mov_r32_imm32) [ECX,125h:imm32]                  encoding(5 bytes) = b9 25 01 00 00
0064h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
006eh call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F654380h:jmp64]                encoding(5 bytes) = e8 0d 43 65 5f
0073h mov r14,rax                   ; MOV(Mov_r64_rm64) [R14,RAX]                          encoding(3 bytes) = 4c 8b f0
0076h mov ecx,0B4Dh                 ; MOV(Mov_r32_imm32) [ECX,b4dh:imm32]                  encoding(5 bytes) = b9 4d 0b 00 00
007bh mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0085h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F654380h:jmp64]                encoding(5 bytes) = e8 f6 42 65 5f
008ah mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
008dh lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
0092h mov [r8],dil                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),DIL]            encoding(3 bytes) = 41 88 38
0095h mov [r8+4],esi                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ESI]         encoding(4 bytes) = 41 89 70 04
0099h mov r8,r14                    ; MOV(Mov_r64_rm64) [R8,R14]                           encoding(3 bytes) = 4d 8b c6
009ch mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
009eh mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00a0h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00a5h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00aah call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD2A588h:jmp64]        encoding(5 bytes) = e8 d9 a4 d2 ff
00afh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00b2h call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DF190h:jmp64]                encoding(5 bytes) = e8 d9 f0 4d 5f
00b7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00b8h call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F653BA0h:jmp64]                encoding(5 bytes) = e8 e3 3a 65 5f
00bdh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> dotBytes => new byte[190]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0x02,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x8B,0x49,0x08,0xBE,0x62,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0x8B,0xD9,0x8B,0xEA,0x3B,0xCA,0x75,0x37,0x45,0x33,0xC9,0x45,0x33,0xD2,0x85,0xC9,0x7E,0x1F,0x4D,0x63,0xDA,0x43,0x8B,0x1C,0x98,0x44,0x3B,0xD2,0x73,0x7A,0x46,0x8B,0x1C,0x98,0x44,0x0F,0xAF,0xDB,0x45,0x03,0xCB,0x41,0xFF,0xC2,0x44,0x3B,0xD1,0x7C,0xE1,0x41,0x8B,0xC1,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xB9,0x25,0x01,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x0D,0x43,0x65,0x5F,0x4C,0x8B,0xF0,0xB9,0x4D,0x0B,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0xF6,0x42,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0x41,0x88,0x38,0x41,0x89,0x70,0x04,0x4D,0x8B,0xC6,0x8B,0xCB,0x8B,0xD5,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0xE8,0xD9,0xA4,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0xD9,0xF0,0x4D,0x5F,0xCC,0xE8,0xE3,0x3A,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long dot(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
; location: [7FFDDDBCB440h, 7FFDDDBCB4FDh]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000ah mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000dh mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0010h mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 01
0013h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
0016h mov esi,70h                   ; MOV(Mov_r32_imm32) [ESI,70h:imm32]                   encoding(5 bytes) = be 70 00 00 00
001bh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0020h mov ebx,ecx                   ; MOV(Mov_r32_rm32) [EBX,ECX]                          encoding(2 bytes) = 8b d9
0022h mov ebp,edx                   ; MOV(Mov_r32_rm32) [EBP,EDX]                          encoding(2 bytes) = 8b ea
0024h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0026h jne short 005fh               ; JNE(Jne_rel8_64) [5Fh:jmp64]                         encoding(2 bytes) = 75 37
0028h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
002bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
002eh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0030h jle short 0051h               ; JLE(Jle_rel8_64) [51h:jmp64]                         encoding(2 bytes) = 7e 1f
0032h movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
0035h mov rbx,[r8+r11*8]            ; MOV(Mov_r64_rm64) [RBX,mem(64u,R8:br,DS:sr)]         encoding(4 bytes) = 4b 8b 1c d8
0039h cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
003ch jae short 00b8h               ; JAE(Jae_rel8_64) [B8h:jmp64]                         encoding(2 bytes) = 73 7a
003eh mov r11,[rax+r11*8]           ; MOV(Mov_r64_rm64) [R11,mem(64u,RAX:br,DS:sr)]        encoding(4 bytes) = 4e 8b 1c d8
0042h imul r11,rbx                  ; IMUL(Imul_r64_rm64) [R11,RBX]                        encoding(4 bytes) = 4c 0f af db
0046h add r9,r11                    ; ADD(Add_r64_rm64) [R9,R11]                           encoding(3 bytes) = 4d 03 cb
0049h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004ch cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
004fh jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c e1
0051h mov rax,r9                    ; MOV(Mov_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 8b c1
0054h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0058h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0059h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
005ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005ch pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005fh mov ecx,125h                  ; MOV(Mov_r32_imm32) [ECX,125h:imm32]                  encoding(5 bytes) = b9 25 01 00 00
0064h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
006eh call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6542A0h:jmp64]                encoding(5 bytes) = e8 2d 42 65 5f
0073h mov r14,rax                   ; MOV(Mov_r64_rm64) [R14,RAX]                          encoding(3 bytes) = 4c 8b f0
0076h mov ecx,0B4Dh                 ; MOV(Mov_r32_imm32) [ECX,b4dh:imm32]                  encoding(5 bytes) = b9 4d 0b 00 00
007bh mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0085h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6542A0h:jmp64]                encoding(5 bytes) = e8 16 42 65 5f
008ah mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
008dh lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
0092h mov [r8],dil                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),DIL]            encoding(3 bytes) = 41 88 38
0095h mov [r8+4],esi                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ESI]         encoding(4 bytes) = 41 89 70 04
0099h mov r8,r14                    ; MOV(Mov_r64_rm64) [R8,R14]                           encoding(3 bytes) = 4d 8b c6
009ch mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
009eh mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00a0h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00a5h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00aah call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD2A4A8h:jmp64]        encoding(5 bytes) = e8 f9 a3 d2 ff
00afh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00b2h call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DF0B0h:jmp64]                encoding(5 bytes) = e8 f9 ef 4d 5f
00b7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00b8h call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F653AC0h:jmp64]                encoding(5 bytes) = e8 03 3a 65 5f
00bdh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> dotBytes => new byte[190]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0x02,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x8B,0x49,0x08,0xBE,0x70,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0x8B,0xD9,0x8B,0xEA,0x3B,0xCA,0x75,0x37,0x45,0x33,0xC9,0x45,0x33,0xD2,0x85,0xC9,0x7E,0x1F,0x4D,0x63,0xDA,0x4B,0x8B,0x1C,0xD8,0x44,0x3B,0xD2,0x73,0x7A,0x4E,0x8B,0x1C,0xD8,0x4C,0x0F,0xAF,0xDB,0x4D,0x03,0xCB,0x41,0xFF,0xC2,0x44,0x3B,0xD1,0x7C,0xE1,0x49,0x8B,0xC1,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xB9,0x25,0x01,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x2D,0x42,0x65,0x5F,0x4C,0x8B,0xF0,0xB9,0x4D,0x0B,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x16,0x42,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0x41,0x88,0x38,0x41,0x89,0x70,0x04,0x4D,0x8B,0xC6,0x8B,0xCB,0x8B,0xD5,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0xE8,0xF9,0xA3,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0xF9,0xEF,0x4D,0x5F,0xCC,0xE8,0x03,0x3A,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dot(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
; location: [7FFDDDBCB520h, 7FFDDDBCB5DDh]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000ah mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000dh mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0010h mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 01
0013h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
0016h mov esi,7Eh                   ; MOV(Mov_r32_imm32) [ESI,7eh:imm32]                   encoding(5 bytes) = be 7e 00 00 00
001bh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0020h mov ebx,ecx                   ; MOV(Mov_r32_rm32) [EBX,ECX]                          encoding(2 bytes) = 8b d9
0022h mov ebp,edx                   ; MOV(Mov_r32_rm32) [EBP,EDX]                          encoding(2 bytes) = 8b ea
0024h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0026h jne short 005fh               ; JNE(Jne_rel8_64) [5Fh:jmp64]                         encoding(2 bytes) = 75 37
0028h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
002bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
002eh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0030h jle short 0051h               ; JLE(Jle_rel8_64) [51h:jmp64]                         encoding(2 bytes) = 7e 1f
0032h movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
0035h mov rbx,[r8+r11*8]            ; MOV(Mov_r64_rm64) [RBX,mem(64u,R8:br,DS:sr)]         encoding(4 bytes) = 4b 8b 1c d8
0039h cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
003ch jae short 00b8h               ; JAE(Jae_rel8_64) [B8h:jmp64]                         encoding(2 bytes) = 73 7a
003eh mov r11,[rax+r11*8]           ; MOV(Mov_r64_rm64) [R11,mem(64u,RAX:br,DS:sr)]        encoding(4 bytes) = 4e 8b 1c d8
0042h imul r11,rbx                  ; IMUL(Imul_r64_rm64) [R11,RBX]                        encoding(4 bytes) = 4c 0f af db
0046h add r9,r11                    ; ADD(Add_r64_rm64) [R9,R11]                           encoding(3 bytes) = 4d 03 cb
0049h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004ch cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
004fh jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c e1
0051h mov rax,r9                    ; MOV(Mov_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 8b c1
0054h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0058h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0059h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
005ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005ch pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005fh mov ecx,125h                  ; MOV(Mov_r32_imm32) [ECX,125h:imm32]                  encoding(5 bytes) = b9 25 01 00 00
0064h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
006eh call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6541C0h:jmp64]                encoding(5 bytes) = e8 4d 41 65 5f
0073h mov r14,rax                   ; MOV(Mov_r64_rm64) [R14,RAX]                          encoding(3 bytes) = 4c 8b f0
0076h mov ecx,0B4Dh                 ; MOV(Mov_r32_imm32) [ECX,b4dh:imm32]                  encoding(5 bytes) = b9 4d 0b 00 00
007bh mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0085h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6541C0h:jmp64]                encoding(5 bytes) = e8 36 41 65 5f
008ah mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
008dh lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
0092h mov [r8],dil                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),DIL]            encoding(3 bytes) = 41 88 38
0095h mov [r8+4],esi                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ESI]         encoding(4 bytes) = 41 89 70 04
0099h mov r8,r14                    ; MOV(Mov_r64_rm64) [R8,R14]                           encoding(3 bytes) = 4d 8b c6
009ch mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
009eh mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00a0h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00a5h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00aah call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD2A3C8h:jmp64]        encoding(5 bytes) = e8 19 a3 d2 ff
00afh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00b2h call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DEFD0h:jmp64]                encoding(5 bytes) = e8 19 ef 4d 5f
00b7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00b8h call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F6539E0h:jmp64]                encoding(5 bytes) = e8 23 39 65 5f
00bdh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> dotBytes => new byte[190]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0x02,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x8B,0x49,0x08,0xBE,0x7E,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0x8B,0xD9,0x8B,0xEA,0x3B,0xCA,0x75,0x37,0x45,0x33,0xC9,0x45,0x33,0xD2,0x85,0xC9,0x7E,0x1F,0x4D,0x63,0xDA,0x4B,0x8B,0x1C,0xD8,0x44,0x3B,0xD2,0x73,0x7A,0x4E,0x8B,0x1C,0xD8,0x4C,0x0F,0xAF,0xDB,0x4D,0x03,0xCB,0x41,0xFF,0xC2,0x44,0x3B,0xD1,0x7C,0xE1,0x49,0x8B,0xC1,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xB9,0x25,0x01,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x4D,0x41,0x65,0x5F,0x4C,0x8B,0xF0,0xB9,0x4D,0x0B,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x36,0x41,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0x41,0x88,0x38,0x41,0x89,0x70,0x04,0x4D,0x8B,0xC6,0x8B,0xCB,0x8B,0xD5,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0xE8,0x19,0xA3,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0x19,0xEF,0x4D,0x5F,0xCC,0xE8,0x23,0x39,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq(sbyte lhs, sbyte rhs)
; location: [7FFDDDBCB600h, 7FFDDDBCB615h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eqBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq(byte lhs, byte rhs)
; location: [7FFDDDBCB630h, 7FFDDDBCB643h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eqBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq(short lhs, short rhs)
; location: [7FFDDDBCB660h, 7FFDDDBCB675h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eqBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq(ushort lhs, ushort rhs)
; location: [7FFDDDBCB690h, 7FFDDDBCB6A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eqBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq(int lhs, int rhs)
; location: [7FFDDDBCB6C0h, 7FFDDDBCB6CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq(uint lhs, uint rhs)
; location: [7FFDDDBCB6E0h, 7FFDDDBCB6EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq(long lhs, long rhs)
; location: [7FFDDDBCB700h, 7FFDDDBCB70Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq(ulong lhs, ulong rhs)
; location: [7FFDDDBCB720h, 7FFDDDBCB72Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte flip(sbyte src)
; location: [7FFDDDBCB740h, 7FFDDDBCB74Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte flip(byte src)
; location: [7FFDDDBCB760h, 7FFDDDBCB76Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short flip(short src)
; location: [7FFDDDBCB780h, 7FFDDDBCB78Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort flip(ushort src)
; location: [7FFDDDBCB7A0h, 7FFDDDBCB7ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int flip(int src)
; location: [7FFDDDBCB7C0h, 7FFDDDBCB7C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint flip(uint src)
; location: [7FFDDDBCB7E0h, 7FFDDDBCB7E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long flip(long src)
; location: [7FFDDDBCB800h, 7FFDDDBCB80Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong flip(ulong src)
; location: [7FFDDDBCB820h, 7FFDDDBCB82Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte flip(ref sbyte src)
; location: [7FFDDDBCB840h, 7FFDDDBCB84Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not byte ptr [rcx]            ; NOT(Not_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = f6 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte flip(ref byte src)
; location: [7FFDDDBCB860h, 7FFDDDBCB86Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not byte ptr [rcx]            ; NOT(Not_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = f6 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short flip(ref short src)
; location: [7FFDDDBCB880h, 7FFDDDBCB88Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not word ptr [rcx]            ; NOT(Not_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 f7 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort flip(ref ushort src)
; location: [7FFDDDBCB8A0h, 7FFDDDBCB8ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not word ptr [rcx]            ; NOT(Not_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 f7 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int flip(ref int src)
; location: [7FFDDDBCB8C0h, 7FFDDDBCB8CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not dword ptr [rcx]           ; NOT(Not_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = f7 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint flip(ref uint src)
; location: [7FFDDDBCB8E0h, 7FFDDDBCB8EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not dword ptr [rcx]           ; NOT(Not_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = f7 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long flip(ref long src)
; location: [7FFDDDBCB900h, 7FFDDDBCB90Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not qword ptr [rcx]           ; NOT(Not_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 f7 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong flip(ref ulong src)
; location: [7FFDDDBCB920h, 7FFDDDBCB92Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not qword ptr [rcx]           ; NOT(Not_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 f7 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte flip(in sbyte src, ref sbyte dst)
; location: [7FFDDDBCB940h, 7FFDDDBCB950h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
000dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0xF7,0xD0,0x88,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte flip(in byte src, ref byte dst)
; location: [7FFDDDBCB970h, 7FFDDDBCB97Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
000ch mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xF7,0xD0,0x88,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short flip(in short src, ref short dst)
; location: [7FFDDDBCB990h, 7FFDDDBCB9A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0xF7,0xD0,0x66,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort flip(in ushort src, ref ushort dst)
; location: [7FFDDDBCB9C0h, 7FFDDDBCB9D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
000dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xF7,0xD0,0x66,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int flip(in int src, ref int dst)
; location: [7FFDDDBCB9F0h, 7FFDDDBCB9FEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0xF7,0xD0,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint flip(in uint src, ref uint dst)
; location: [7FFDDDBCBA10h, 7FFDDDBCBA1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0xF7,0xD0,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long flip(in long src, ref long dst)
; location: [7FFDDDBCBA30h, 7FFDDDBCBA41h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0xF7,0xD0,0x48,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong flip(in ulong src, ref ulong dst)
; location: [7FFDDDBCBA60h, 7FFDDDBCBA71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0xF7,0xD0,0x48,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte fma(sbyte x, sbyte y, sbyte z)
; location: [7FFDDDBCBA90h, 7FFDDDBCBAAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0014h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0016h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fmaBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x49,0x0F,0xBE,0xD0,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte fma(byte x, byte y, byte z)
; location: [7FFDDDBCBAC0h, 7FFDDDBCBAD7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0012h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fmaBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x41,0x0F,0xB6,0xD0,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short fma(short x, short y, short z)
; location: [7FFDDDBCBAF0h, 7FFDDDBCBB0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0014h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0016h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fmaBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x49,0x0F,0xBF,0xD0,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort fma(ushort x, ushort y, ushort z)
; location: [7FFDDDBCBB20h, 7FFDDDBCBB37h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0012h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fmaBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x41,0x0F,0xB7,0xD0,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int fma(int x, int y, int z)
; location: [7FFDDDBCBB50h, 7FFDDDBCBB5Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fmaBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0x41,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint fma(uint x, uint y, uint z)
; location: [7FFDDDBCBB70h, 7FFDDDBCBB7Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fmaBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0x41,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long fma(long x, long y, long z)
; location: [7FFDDDBCBB90h, 7FFDDDBCBB9Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fmaBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong fma(ulong x, ulong y, ulong z)
; location: [7FFDDDBCBBB0h, 7FFDDDBCBBBFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fmaBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte gcd(sbyte lhs, sbyte rhs)
; location: [7FFDDDBCBBD0h, 7FFDDDBCBC13h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000bh sar ecx,7                     ; SAR(Sar_rm32_imm8) [ECX,7h:imm8]                     encoding(3 bytes) = c1 f9 07
000eh add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
0010h xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0012h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0016h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
001ah mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001ch sar ecx,7                     ; SAR(Sar_rm32_imm8) [ECX,7h:imm8]                     encoding(3 bytes) = c1 f9 07
001fh add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0021h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0023h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]                        encoding(4 bytes) = 48 0f be ca
0027h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0029h je short 0041h                ; JE(Je_rel8_64) [41h:jmp64]                           encoding(2 bytes) = 74 16
002bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
002ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
002eh movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0032h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0034h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0036h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0038h jne short 003dh               ; JNE(Jne_rel8_64) [3Dh:jmp64]                         encoding(2 bytes) = 75 03
003ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
003fh jmp short 002bh               ; JMP(Jmp_rel8_64) [2Bh:jmp64]                         encoding(2 bytes) = eb ea
0041h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0043h jmp short 003ah               ; JMP(Jmp_rel8_64) [3Ah:jmp64]                         encoding(2 bytes) = eb f5
; static ReadOnlySpan<byte> gcdBytes => new byte[69]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xC8,0xC1,0xF9,0x07,0x03,0xC1,0x33,0xC1,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xD2,0x8B,0xCA,0xC1,0xF9,0x07,0x03,0xD1,0x33,0xD1,0x48,0x0F,0xBE,0xCA,0x85,0xC9,0x74,0x16,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC2,0x8B,0xD1,0x8B,0xC8,0x85,0xC9,0x75,0x03,0x8B,0xC2,0xC3,0x8B,0xC2,0xEB,0xEA,0x8B,0xD0,0xEB,0xF5};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gcd(byte lhs, byte rhs)
; location: [7FFDDDBCBC30h, 7FFDDDBCBC4Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
0007h je short 0019h                ; JE(Je_rel8_64) [19h:jmp64]                           encoding(2 bytes) = 74 10
0009h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
000ch movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000fh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0010h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
0017h jne short 0009h               ; JNE(Jne_rel8_64) [9h:jmp64]                          encoding(2 bytes) = 75 f0
0019h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xD2,0x74,0x10,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xD2,0x84,0xD2,0x75,0xF0,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short gcd(short lhs, short rhs)
; location: [7FFDDDBCBC60h, 7FFDDDBCBCA3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000bh sar ecx,0Fh                   ; SAR(Sar_rm32_imm8) [ECX,fh:imm8]                     encoding(3 bytes) = c1 f9 0f
000eh add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
0010h xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0012h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0016h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
001ah mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001ch sar ecx,0Fh                   ; SAR(Sar_rm32_imm8) [ECX,fh:imm8]                     encoding(3 bytes) = c1 f9 0f
001fh add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0021h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0023h movsx rcx,dx                  ; MOVSX(Movsx_r64_rm16) [RCX,DX]                       encoding(4 bytes) = 48 0f bf ca
0027h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0029h je short 0041h                ; JE(Je_rel8_64) [41h:jmp64]                           encoding(2 bytes) = 74 16
002bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
002ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
002eh movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0032h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0034h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0036h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0038h jne short 003dh               ; JNE(Jne_rel8_64) [3Dh:jmp64]                         encoding(2 bytes) = 75 03
003ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
003fh jmp short 002bh               ; JMP(Jmp_rel8_64) [2Bh:jmp64]                         encoding(2 bytes) = eb ea
0041h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0043h jmp short 003ah               ; JMP(Jmp_rel8_64) [3Ah:jmp64]                         encoding(2 bytes) = eb f5
; static ReadOnlySpan<byte> gcdBytes => new byte[69]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xC8,0xC1,0xF9,0x0F,0x03,0xC1,0x33,0xC1,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xD2,0x8B,0xCA,0xC1,0xF9,0x0F,0x03,0xD1,0x33,0xD1,0x48,0x0F,0xBF,0xCA,0x85,0xC9,0x74,0x16,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC2,0x8B,0xD1,0x8B,0xC8,0x85,0xC9,0x75,0x03,0x8B,0xC2,0xC3,0x8B,0xC2,0xEB,0xEA,0x8B,0xD0,0xEB,0xF5};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gcd(ushort lhs, ushort rhs)
; location: [7FFDDDBCBCC0h, 7FFDDDBCBCE2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah je short 001fh                ; JE(Je_rel8_64) [1Fh:jmp64]                           encoding(2 bytes) = 74 13
000ch movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
000fh movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
0012h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0013h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0015h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0018h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
001bh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001dh jne short 000ch               ; JNE(Jne_rel8_64) [Ch:jmp64]                          encoding(2 bytes) = 75 ed
001fh movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x85,0xC0,0x74,0x13,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x99,0xF7,0xF9,0x0F,0xB7,0xD2,0x0F,0xB7,0xC2,0x85,0xC0,0x75,0xED,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int gcd(int lhs, int rhs)
; location: [7FFDDDBCBD00h, 7FFDDDBCBD29h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
000ah add ecx,eax                   ; ADD(Add_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 03 c8
000ch xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
0013h lea r8d,[rdx+rcx]             ; LEA(Lea_r32_m) [R8D,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8d 04 0a
0017h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
001ah test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ch je short 0029h                ; JE(Je_rel8_64) [29h:jmp64]                           encoding(2 bytes) = 74 0b
001eh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
001fh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0021h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0023h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0025h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0027h jne short 001eh               ; JNE(Jne_rel8_64) [1Eh:jmp64]                         encoding(2 bytes) = 75 f5
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdBytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x03,0xC8,0x33,0xC1,0x8B,0xCA,0xC1,0xF9,0x1F,0x44,0x8D,0x04,0x0A,0x41,0x33,0xC8,0x85,0xC9,0x74,0x0B,0x99,0xF7,0xF9,0x8B,0xC1,0x8B,0xCA,0x85,0xC9,0x75,0xF5,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gcd(uint lhs, uint rhs)
; location: [7FFDDDBCBD40h, 7FFDDDBCBD5Ah]
0000h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0002h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0005h test r8d,r8d                  ; TEST(Test_rm32_r32) [R8D,R8D]                        encoding(3 bytes) = 45 85 c0
0008h je short 001ah                ; JE(Je_rel8_64) [1Ah:jmp64]                           encoding(2 bytes) = 74 10
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0012h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0015h test r8d,r8d                  ; TEST(Test_rm32_r32) [R8D,R8D]                        encoding(3 bytes) = 45 85 c0
0018h jne short 000ah               ; JNE(Jne_rel8_64) [Ah:jmp64]                          encoding(2 bytes) = 75 f0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdBytes => new byte[27]{0x8B,0xC1,0x44,0x8B,0xC2,0x45,0x85,0xC0,0x74,0x10,0x33,0xD2,0x41,0xF7,0xF0,0x41,0x8B,0xC0,0x44,0x8B,0xC2,0x45,0x85,0xC0,0x75,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long gcd(long lhs, long rhs)
; location: [7FFDDDBCBD70h, 7FFDDDBCBDA5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sar rax,3Fh                   ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f8 3f
000ch add rcx,rax                   ; ADD(Add_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 03 c8
000fh xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0012h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0015h sar rcx,3Fh                   ; SAR(Sar_rm64_imm8) [RCX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f9 3f
0019h lea r8,[rdx+rcx]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RDX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 04 0a
001dh xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
0020h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0023h je short 0035h                ; JE(Je_rel8_64) [35h:jmp64]                           encoding(2 bytes) = 74 10
0025h cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
0027h idiv rcx                      ; IDIV(Idiv_rm64) [RCX]                                encoding(3 bytes) = 48 f7 f9
002ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002dh mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0030h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0033h jne short 0025h               ; JNE(Jne_rel8_64) [25h:jmp64]                         encoding(2 bytes) = 75 f0
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdBytes => new byte[54]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xF8,0x3F,0x48,0x03,0xC8,0x48,0x33,0xC1,0x48,0x8B,0xCA,0x48,0xC1,0xF9,0x3F,0x4C,0x8D,0x04,0x0A,0x49,0x33,0xC8,0x48,0x85,0xC9,0x74,0x10,0x48,0x99,0x48,0xF7,0xF9,0x48,0x8B,0xC1,0x48,0x8B,0xCA,0x48,0x85,0xC9,0x75,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gcd(ulong lhs, ulong rhs)
; location: [7FFDDDBCBDC0h, 7FFDDDBCBDDBh]
0000h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0003h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0006h test r8,r8                    ; TEST(Test_rm64_r64) [R8,R8]                          encoding(3 bytes) = 4d 85 c0
0009h je short 001bh                ; JE(Je_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 74 10
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0013h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0016h test r8,r8                    ; TEST(Test_rm64_r64) [R8,R8]                          encoding(3 bytes) = 4d 85 c0
0019h jne short 000bh               ; JNE(Jne_rel8_64) [Bh:jmp64]                          encoding(2 bytes) = 75 f0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdBytes => new byte[28]{0x48,0x8B,0xC1,0x4C,0x8B,0xC2,0x4D,0x85,0xC0,0x74,0x10,0x33,0xD2,0x49,0xF7,0xF0,0x49,0x8B,0xC0,0x4C,0x8B,0xC2,0x4D,0x85,0xC0,0x75,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gcdbin(uint u, uint v)
; location: [7FFDDDBCBDF0h, 7FFDDDBCBE4Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h je short 0044h                ; JE(Je_rel8_64) [44h:jmp64]                           encoding(2 bytes) = 74 3b
0009h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
000bh je short 0048h                ; JE(Je_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 74 3b
000dh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000fh je short 004ch                ; JE(Je_rel8_64) [4Ch:jmp64]                           encoding(2 bytes) = 74 3b
0011h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0013h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0015h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
0017h je short 0022h                ; JE(Je_rel8_64) [22h:jmp64]                           encoding(2 bytes) = 74 09
0019h test dl,1                     ; TEST(Test_rm8_imm8) [DL,1h:imm8]                     encoding(3 bytes) = f6 c2 01
001ch je short 0050h                ; JE(Je_rel8_64) [50h:jmp64]                           encoding(2 bytes) = 74 32
001eh shr ecx,1                     ; SHR(Shr_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e9
0020h jmp short 0005h               ; JMP(Jmp_rel8_64) [5h:jmp64]                          encoding(2 bytes) = eb e3
0022h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0024h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0026h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
0028h je short 002eh                ; JE(Je_rel8_64) [2Eh:jmp64]                           encoding(2 bytes) = 74 04
002ah shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
002ch jmp short 0005h               ; JMP(Jmp_rel8_64) [5h:jmp64]                          encoding(2 bytes) = eb d7
002eh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0030h jbe short 0038h               ; JBE(Jbe_rel8_64) [38h:jmp64]                         encoding(2 bytes) = 76 06
0032h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0034h shr ecx,1                     ; SHR(Shr_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e9
0036h jmp short 0005h               ; JMP(Jmp_rel8_64) [5h:jmp64]                          encoding(2 bytes) = eb cd
0038h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
003ah shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
003ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
003eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0040h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0042h jmp short 0005h               ; JMP(Jmp_rel8_64) [5h:jmp64]                          encoding(2 bytes) = eb c1
0044h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0046h jmp short 005bh               ; JMP(Jmp_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = eb 13
0048h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
004ah jmp short 005bh               ; JMP(Jmp_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = eb 0f
004ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
004eh jmp short 005bh               ; JMP(Jmp_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = eb 0b
0050h shr ecx,1                     ; SHR(Shr_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e9
0052h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0054h call 7FFDDD605620h            ; CALL(Call_rel32_64) [FFFFFFFFFFA39830h:jmp64]        encoding(5 bytes) = e8 d7 97 a3 ff
0059h shl eax,1                     ; SHL(Shl_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e0
005bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdbinBytes => new byte[96]{0x48,0x83,0xEC,0x28,0x90,0x3B,0xCA,0x74,0x3B,0x85,0xC9,0x74,0x3B,0x85,0xD2,0x74,0x3B,0x8B,0xC1,0xF7,0xD0,0xA8,0x01,0x74,0x09,0xF6,0xC2,0x01,0x74,0x32,0xD1,0xE9,0xEB,0xE3,0x8B,0xC2,0xF7,0xD0,0xA8,0x01,0x74,0x04,0xD1,0xEA,0xEB,0xD7,0x3B,0xCA,0x76,0x06,0x2B,0xCA,0xD1,0xE9,0xEB,0xCD,0x2B,0xD1,0xD1,0xEA,0x8B,0xC1,0x8B,0xCA,0x8B,0xD0,0xEB,0xC1,0x8B,0xC1,0xEB,0x13,0x8B,0xC2,0xEB,0x0F,0x8B,0xC1,0xEB,0x0B,0xD1,0xE9,0xD1,0xEA,0xE8,0xD7,0x97,0xA3,0xFF,0xD1,0xE0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gcdbin(ulong u, ulong v)
; location: [7FFDDDBCBE70h, 7FFDDDBCBEE7h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h je short 0056h                ; JE(Je_rel8_64) [56h:jmp64]                           encoding(2 bytes) = 74 4c
000ah test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
000dh je short 005bh                ; JE(Je_rel8_64) [5Bh:jmp64]                           encoding(2 bytes) = 74 4c
000fh test rdx,rdx                  ; TEST(Test_rm64_r64) [RDX,RDX]                        encoding(3 bytes) = 48 85 d2
0012h je short 0060h                ; JE(Je_rel8_64) [60h:jmp64]                           encoding(2 bytes) = 74 4c
0014h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0017h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
001ah test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
001ch je short 0029h                ; JE(Je_rel8_64) [29h:jmp64]                           encoding(2 bytes) = 74 0b
001eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0020h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
0022h je short 0065h                ; JE(Je_rel8_64) [65h:jmp64]                           encoding(2 bytes) = 74 41
0024h shr rcx,1                     ; SHR(Shr_rm64_1) [RCX,1h:imm8]                        encoding(3 bytes) = 48 d1 e9
0027h jmp short 0005h               ; JMP(Jmp_rel8_64) [5h:jmp64]                          encoding(2 bytes) = eb dc
0029h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
002ch not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
002fh test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
0031h je short 0038h                ; JE(Je_rel8_64) [38h:jmp64]                           encoding(2 bytes) = 74 05
0033h shr rdx,1                     ; SHR(Shr_rm64_1) [RDX,1h:imm8]                        encoding(3 bytes) = 48 d1 ea
0036h jmp short 0005h               ; JMP(Jmp_rel8_64) [5h:jmp64]                          encoding(2 bytes) = eb cd
0038h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
003bh jbe short 0045h               ; JBE(Jbe_rel8_64) [45h:jmp64]                         encoding(2 bytes) = 76 08
003dh sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
0040h shr rcx,1                     ; SHR(Shr_rm64_1) [RCX,1h:imm8]                        encoding(3 bytes) = 48 d1 e9
0043h jmp short 0005h               ; JMP(Jmp_rel8_64) [5h:jmp64]                          encoding(2 bytes) = eb c0
0045h sub rdx,rcx                   ; SUB(Sub_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 2b d1
0048h shr rdx,1                     ; SHR(Shr_rm64_1) [RDX,1h:imm8]                        encoding(3 bytes) = 48 d1 ea
004bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004eh mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0051h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0054h jmp short 0005h               ; JMP(Jmp_rel8_64) [5h:jmp64]                          encoding(2 bytes) = eb af
0056h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0059h jmp short 0073h               ; JMP(Jmp_rel8_64) [73h:jmp64]                         encoding(2 bytes) = eb 18
005bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
005eh jmp short 0073h               ; JMP(Jmp_rel8_64) [73h:jmp64]                         encoding(2 bytes) = eb 13
0060h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0063h jmp short 0073h               ; JMP(Jmp_rel8_64) [73h:jmp64]                         encoding(2 bytes) = eb 0e
0065h shr rcx,1                     ; SHR(Shr_rm64_1) [RCX,1h:imm8]                        encoding(3 bytes) = 48 d1 e9
0068h shr rdx,1                     ; SHR(Shr_rm64_1) [RDX,1h:imm8]                        encoding(3 bytes) = 48 d1 ea
006bh call 7FFDDD605628h            ; CALL(Call_rel32_64) [FFFFFFFFFFA397B8h:jmp64]        encoding(5 bytes) = e8 48 97 a3 ff
0070h shl rax,1                     ; SHL(Shl_rm64_1) [RAX,1h:imm8]                        encoding(3 bytes) = 48 d1 e0
0073h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0077h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdbinBytes => new byte[120]{0x48,0x83,0xEC,0x28,0x90,0x48,0x3B,0xCA,0x74,0x4C,0x48,0x85,0xC9,0x74,0x4C,0x48,0x85,0xD2,0x74,0x4C,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xA8,0x01,0x74,0x0B,0x8B,0xC2,0xA8,0x01,0x74,0x41,0x48,0xD1,0xE9,0xEB,0xDC,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xA8,0x01,0x74,0x05,0x48,0xD1,0xEA,0xEB,0xCD,0x48,0x3B,0xCA,0x76,0x08,0x48,0x2B,0xCA,0x48,0xD1,0xE9,0xEB,0xC0,0x48,0x2B,0xD1,0x48,0xD1,0xEA,0x48,0x8B,0xC1,0x48,0x8B,0xCA,0x48,0x8B,0xD0,0xEB,0xAF,0x48,0x8B,0xC1,0xEB,0x18,0x48,0x8B,0xC2,0xEB,0x13,0x48,0x8B,0xC1,0xEB,0x0E,0x48,0xD1,0xE9,0x48,0xD1,0xEA,0xE8,0x48,0x97,0xA3,0xFF,0x48,0xD1,0xE0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gcdbin(byte u, byte v)
; location: [7FFDDDBCBF00h, 7FFDDDBCBF17h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh call 7FFDDDBCBDF0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEF0h:jmp64]        encoding(5 bytes) = e8 e0 fe ff ff
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdbinBytes => new byte[24]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0xE8,0xE0,0xFE,0xFF,0xFF,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gcdbin(ushort u, ushort v)
; location: [7FFDDDBCBF30h, 7FFDDDBCBF47h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh call 7FFDDDBCBDF0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEC0h:jmp64]        encoding(5 bytes) = e8 b0 fe ff ff
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdbinBytes => new byte[24]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB7,0xC9,0x0F,0xB7,0xD2,0xE8,0xB0,0xFE,0xFF,0xFF,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt(sbyte lhs, sbyte rhs)
; location: [7FFDDDBCBF60h, 7FFDDDBCBF75h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gtBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt(byte lhs, byte rhs)
; location: [7FFDDDBCBF90h, 7FFDDDBCBFA3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gtBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt(short lhs, short rhs)
; location: [7FFDDDBCBFC0h, 7FFDDDBCBFD5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gtBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt(ushort lhs, ushort rhs)
; location: [7FFDDDBCBFF0h, 7FFDDDBCC003h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gtBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt(int lhs, int rhs)
; location: [7FFDDDBCC020h, 7FFDDDBCC02Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gtBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt(uint lhs, uint rhs)
; location: [7FFDDDBCC040h, 7FFDDDBCC04Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gtBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt(long lhs, long rhs)
; location: [7FFDDDBCC060h, 7FFDDDBCC06Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gtBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt(ulong lhs, ulong rhs)
; location: [7FFDDDBCC080h, 7FFDDDBCC08Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gtBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq(sbyte lhs, sbyte rhs)
; location: [7FFDDDBCC0A0h, 7FFDDDBCC0B5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteqBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq(byte lhs, byte rhs)
; location: [7FFDDDBCC0D0h, 7FFDDDBCC0E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteqBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq(short lhs, short rhs)
; location: [7FFDDDBCC100h, 7FFDDDBCC115h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteqBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq(ushort lhs, ushort rhs)
; location: [7FFDDDBCC130h, 7FFDDDBCC143h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteqBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq(int lhs, int rhs)
; location: [7FFDDDBCC160h, 7FFDDDBCC16Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq(uint lhs, uint rhs)
; location: [7FFDDDBCC180h, 7FFDDDBCC18Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq(long lhs, long rhs)
; location: [7FFDDDBCC1A0h, 7FFDDDBCC1AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq(ulong lhs, ulong rhs)
; location: [7FFDDDBCC1C0h, 7FFDDDBCC1CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte inc(sbyte src)
; location: [7FFDDDBCC1E0h, 7FFDDDBCC1F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC0,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte inc(byte src)
; location: [7FFDDDBCC210h, 7FFDDDBCC220h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short inc(short src)
; location: [7FFDDDBCC240h, 7FFDDDBCC253h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC0,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort inc(ushort src)
; location: [7FFDDDBCC270h, 7FFDDDBCC280h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC0,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int inc(int src)
; location: [7FFDDDBCC2A0h, 7FFDDDBCC2A8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inc(uint src)
; location: [7FFDDDBCC2C0h, 7FFDDDBCC2C8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long inc(long src)
; location: [7FFDDDBCC2E0h, 7FFDDDBCC2E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 01
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inc(ulong src)
; location: [7FFDDDBCC300h, 7FFDDDBCC309h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 01
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte inc(ref sbyte src)
; location: [7FFDDDBCC320h, 7FFDDDBCC32Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc byte ptr [rcx]            ; INC(Inc_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = fe 01
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFE,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte inc(ref byte src)
; location: [7FFDDDBCC340h, 7FFDDDBCC34Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc byte ptr [rcx]            ; INC(Inc_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = fe 01
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFE,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short inc(ref short src)
; location: [7FFDDDBCC360h, 7FFDDDBCC36Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc word ptr [rcx]            ; INC(Inc_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 ff 01
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort inc(ref ushort src)
; location: [7FFDDDBCC380h, 7FFDDDBCC38Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc word ptr [rcx]            ; INC(Inc_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 ff 01
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int inc(ref int src)
; location: [7FFDDDBCC3A0h, 7FFDDDBCC3AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc dword ptr [rcx]           ; INC(Inc_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = ff 01
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint inc(ref uint src)
; location: [7FFDDDBCC3C0h, 7FFDDDBCC3CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc dword ptr [rcx]           ; INC(Inc_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = ff 01
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long inc(ref long src)
; location: [7FFDDDBCC3E0h, 7FFDDDBCC3EBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc qword ptr [rcx]           ; INC(Inc_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 ff 01
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong inc(ref ulong src)
; location: [7FFDDDBCC400h, 7FFDDDBCC40Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc qword ptr [rcx]           ; INC(Inc_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 ff 01
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool isPow2(sbyte src)
; location: [7FFDDDBCC420h, 7FFDDDBCC434h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000ch test eax,edx                  ; TEST(Test_rm32_r32) [EDX,EAX]                        encoding(2 bytes) = 85 c2
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> isPow2Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8D,0x50,0xFF,0x85,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool isPow2(byte src)
; location: [7FFDDDBCC450h, 7FFDDDBCC463h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000bh test eax,edx                  ; TEST(Test_rm32_r32) [EDX,EAX]                        encoding(2 bytes) = 85 c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> isPow2Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8D,0x50,0xFF,0x85,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool isPow2(short src)
; location: [7FFDDDBCC480h, 7FFDDDBCC494h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000ch test eax,edx                  ; TEST(Test_rm32_r32) [EDX,EAX]                        encoding(2 bytes) = 85 c2
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> isPow2Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8D,0x50,0xFF,0x85,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool isPow2(ushort src)
; location: [7FFDDDBCC4B0h, 7FFDDDBCC4C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000bh test eax,edx                  ; TEST(Test_rm32_r32) [EDX,EAX]                        encoding(2 bytes) = 85 c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> isPow2Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8D,0x50,0xFF,0x85,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool isPow2(int src)
; location: [7FFDDDBCC4E0h, 7FFDDDBCC4F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h test ecx,eax                  ; TEST(Test_rm32_r32) [EAX,ECX]                        encoding(2 bytes) = 85 c8
000ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> isPow2Bytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0x85,0xC8,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool isPow2(uint src)
; location: [7FFDDDBCC510h, 7FFDDDBCC520h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h test ecx,eax                  ; TEST(Test_rm32_r32) [EAX,ECX]                        encoding(2 bytes) = 85 c8
000ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> isPow2Bytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0x85,0xC8,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool isPow2(long src)
; location: [7FFDDDBCC540h, 7FFDDDBCC552h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h test rcx,rax                  ; TEST(Test_rm64_r64) [RAX,RCX]                        encoding(3 bytes) = 48 85 c8
000ch sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> isPow2Bytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0x48,0x85,0xC8,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool isPow2(ulong src)
; location: [7FFDDDBCC570h, 7FFDDDBCC582h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h test rcx,rax                  ; TEST(Test_rm64_r64) [RAX,RCX]                        encoding(3 bytes) = 48 85 c8
000ch sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> isPow2Bytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0x48,0x85,0xC8,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong log2(ref ulong dst, ref ulong x, ulong power)
; location: [7FFDDDBCC5A0h, 7FFDDDBCC5C2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
000eh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0011h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0014h cmp [rdx],r9                  ; CMP(Cmp_rm64_r64) [mem(64u,RDX:br,DS:sr),R9]         encoding(3 bytes) = 4c 39 0a
0017h jb short 0022h                ; JB(Jb_rel8_64) [22h:jmp64]                           encoding(2 bytes) = 72 09
0019h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001ch shr qword ptr [rdx],cl        ; SHR(Shr_rm64_CL) [mem(64u,RDX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 2a
001fh or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]           encoding(3 bytes) = 4c 09 00
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x49,0xD3,0xE1,0x4C,0x39,0x0A,0x72,0x09,0x41,0x8B,0xC8,0x48,0xD3,0x2A,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong log2(ulong src)
; location: [7FFDDDBCC5E0h, 7FFDDDBCC684h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0003h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
000dh mov rax,100000000h            ; MOV(Mov_r64_imm64) [RAX,100000000h:imm64]            encoding(10 bytes) = 48 b8 00 00 00 00 01 00 00 00
0017h cmp rcx,rax                   ; CMP(Cmp_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 3b c8
001ah jb short 002ch                ; JB(Jb_rel8_64) [2Ch:jmp64]                           encoding(2 bytes) = 72 10
001ch shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
0020h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
0024h or rax,20h                    ; OR(Or_rm64_imm8) [RAX,20h:imm64]                     encoding(4 bytes) = 48 83 c8 20
0028h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
002ch cmp rcx,10000h                ; CMP(Cmp_rm64_imm32) [RCX,10000h:imm64]               encoding(7 bytes) = 48 81 f9 00 00 01 00
0033h jb short 0045h                ; JB(Jb_rel8_64) [45h:jmp64]                           encoding(2 bytes) = 72 10
0035h shr rcx,10h                   ; SHR(Shr_rm64_imm8) [RCX,10h:imm8]                    encoding(4 bytes) = 48 c1 e9 10
0039h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
003dh or rax,10h                    ; OR(Or_rm64_imm8) [RAX,10h:imm64]                     encoding(4 bytes) = 48 83 c8 10
0041h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0045h cmp rcx,100h                  ; CMP(Cmp_rm64_imm32) [RCX,100h:imm64]                 encoding(7 bytes) = 48 81 f9 00 01 00 00
004ch jb short 005eh                ; JB(Jb_rel8_64) [5Eh:jmp64]                           encoding(2 bytes) = 72 10
004eh shr rcx,8                     ; SHR(Shr_rm64_imm8) [RCX,8h:imm8]                     encoding(4 bytes) = 48 c1 e9 08
0052h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
0056h or rax,8                      ; OR(Or_rm64_imm8) [RAX,8h:imm64]                      encoding(4 bytes) = 48 83 c8 08
005ah mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
005eh cmp rcx,10h                   ; CMP(Cmp_rm64_imm8) [RCX,10h:imm64]                   encoding(4 bytes) = 48 83 f9 10
0062h jb short 0074h                ; JB(Jb_rel8_64) [74h:jmp64]                           encoding(2 bytes) = 72 10
0064h shr rcx,4                     ; SHR(Shr_rm64_imm8) [RCX,4h:imm8]                     encoding(4 bytes) = 48 c1 e9 04
0068h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
006ch or rax,4                      ; OR(Or_rm64_imm8) [RAX,4h:imm64]                      encoding(4 bytes) = 48 83 c8 04
0070h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0074h cmp rcx,4                     ; CMP(Cmp_rm64_imm8) [RCX,4h:imm64]                    encoding(4 bytes) = 48 83 f9 04
0078h jb short 008ah                ; JB(Jb_rel8_64) [8Ah:jmp64]                           encoding(2 bytes) = 72 10
007ah shr rcx,2                     ; SHR(Shr_rm64_imm8) [RCX,2h:imm8]                     encoding(4 bytes) = 48 c1 e9 02
007eh mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
0082h or rax,2                      ; OR(Or_rm64_imm8) [RAX,2h:imm64]                      encoding(4 bytes) = 48 83 c8 02
0086h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
008ah cmp rcx,2                     ; CMP(Cmp_rm64_imm8) [RCX,2h:imm64]                    encoding(4 bytes) = 48 83 f9 02
008eh jb short 009ch                ; JB(Jb_rel8_64) [9Ch:jmp64]                           encoding(2 bytes) = 72 0c
0090h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
0094h or rax,1                      ; OR(Or_rm64_imm8) [RAX,1h:imm64]                      encoding(4 bytes) = 48 83 c8 01
0098h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
009ch mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
00a0h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
00a4h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[165]{0x50,0x33,0xC0,0x48,0x89,0x04,0x24,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0xB8,0x00,0x00,0x00,0x00,0x01,0x00,0x00,0x00,0x48,0x3B,0xC8,0x72,0x10,0x48,0xC1,0xE9,0x20,0x48,0x8B,0x04,0x24,0x48,0x83,0xC8,0x20,0x48,0x89,0x04,0x24,0x48,0x81,0xF9,0x00,0x00,0x01,0x00,0x72,0x10,0x48,0xC1,0xE9,0x10,0x48,0x8B,0x04,0x24,0x48,0x83,0xC8,0x10,0x48,0x89,0x04,0x24,0x48,0x81,0xF9,0x00,0x01,0x00,0x00,0x72,0x10,0x48,0xC1,0xE9,0x08,0x48,0x8B,0x04,0x24,0x48,0x83,0xC8,0x08,0x48,0x89,0x04,0x24,0x48,0x83,0xF9,0x10,0x72,0x10,0x48,0xC1,0xE9,0x04,0x48,0x8B,0x04,0x24,0x48,0x83,0xC8,0x04,0x48,0x89,0x04,0x24,0x48,0x83,0xF9,0x04,0x72,0x10,0x48,0xC1,0xE9,0x02,0x48,0x8B,0x04,0x24,0x48,0x83,0xC8,0x02,0x48,0x89,0x04,0x24,0x48,0x83,0xF9,0x02,0x72,0x0C,0x48,0x8B,0x04,0x24,0x48,0x83,0xC8,0x01,0x48,0x89,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong log2(int src)
; location: [7FFDDDBCC6A0h, 7FFDDDBCC747h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
000bh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
000fh movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0012h mov rdx,100000000h            ; MOV(Mov_r64_imm64) [RDX,100000000h:imm64]            encoding(10 bytes) = 48 ba 00 00 00 00 01 00 00 00
001ch cmp rax,rdx                   ; CMP(Cmp_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 3b c2
001fh jb short 0031h                ; JB(Jb_rel8_64) [31h:jmp64]                           encoding(2 bytes) = 72 10
0021h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0025h mov rdx,[rsp]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 14 24
0029h or rdx,20h                    ; OR(Or_rm64_imm8) [RDX,20h:imm64]                     encoding(4 bytes) = 48 83 ca 20
002dh mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
0031h cmp rax,10000h                ; CMP(Cmp_RAX_imm32) [RAX,10000h:imm64]                encoding(6 bytes) = 48 3d 00 00 01 00
0037h jb short 0049h                ; JB(Jb_rel8_64) [49h:jmp64]                           encoding(2 bytes) = 72 10
0039h shr rax,10h                   ; SHR(Shr_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e8 10
003dh mov rdx,[rsp]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 14 24
0041h or rdx,10h                    ; OR(Or_rm64_imm8) [RDX,10h:imm64]                     encoding(4 bytes) = 48 83 ca 10
0045h mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
0049h cmp rax,100h                  ; CMP(Cmp_RAX_imm32) [RAX,100h:imm64]                  encoding(6 bytes) = 48 3d 00 01 00 00
004fh jb short 0061h                ; JB(Jb_rel8_64) [61h:jmp64]                           encoding(2 bytes) = 72 10
0051h shr rax,8                     ; SHR(Shr_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e8 08
0055h mov rdx,[rsp]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 14 24
0059h or rdx,8                      ; OR(Or_rm64_imm8) [RDX,8h:imm64]                      encoding(4 bytes) = 48 83 ca 08
005dh mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
0061h cmp rax,10h                   ; CMP(Cmp_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 f8 10
0065h jb short 0077h                ; JB(Jb_rel8_64) [77h:jmp64]                           encoding(2 bytes) = 72 10
0067h shr rax,4                     ; SHR(Shr_rm64_imm8) [RAX,4h:imm8]                     encoding(4 bytes) = 48 c1 e8 04
006bh mov rdx,[rsp]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 14 24
006fh or rdx,4                      ; OR(Or_rm64_imm8) [RDX,4h:imm64]                      encoding(4 bytes) = 48 83 ca 04
0073h mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
0077h cmp rax,4                     ; CMP(Cmp_rm64_imm8) [RAX,4h:imm64]                    encoding(4 bytes) = 48 83 f8 04
007bh jb short 008dh                ; JB(Jb_rel8_64) [8Dh:jmp64]                           encoding(2 bytes) = 72 10
007dh shr rax,2                     ; SHR(Shr_rm64_imm8) [RAX,2h:imm8]                     encoding(4 bytes) = 48 c1 e8 02
0081h mov rdx,[rsp]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 14 24
0085h or rdx,2                      ; OR(Or_rm64_imm8) [RDX,2h:imm64]                      encoding(4 bytes) = 48 83 ca 02
0089h mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
008dh cmp rax,2                     ; CMP(Cmp_rm64_imm8) [RAX,2h:imm64]                    encoding(4 bytes) = 48 83 f8 02
0091h jb short 009fh                ; JB(Jb_rel8_64) [9Fh:jmp64]                           encoding(2 bytes) = 72 0c
0093h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
0097h or rax,1                      ; OR(Or_rm64_imm8) [RAX,1h:imm64]                      encoding(4 bytes) = 48 83 c8 01
009bh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
009fh mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
00a3h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
00a7h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[168]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x89,0x04,0x24,0x48,0x63,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x01,0x00,0x00,0x00,0x48,0x3B,0xC2,0x72,0x10,0x48,0xC1,0xE8,0x20,0x48,0x8B,0x14,0x24,0x48,0x83,0xCA,0x20,0x48,0x89,0x14,0x24,0x48,0x3D,0x00,0x00,0x01,0x00,0x72,0x10,0x48,0xC1,0xE8,0x10,0x48,0x8B,0x14,0x24,0x48,0x83,0xCA,0x10,0x48,0x89,0x14,0x24,0x48,0x3D,0x00,0x01,0x00,0x00,0x72,0x10,0x48,0xC1,0xE8,0x08,0x48,0x8B,0x14,0x24,0x48,0x83,0xCA,0x08,0x48,0x89,0x14,0x24,0x48,0x83,0xF8,0x10,0x72,0x10,0x48,0xC1,0xE8,0x04,0x48,0x8B,0x14,0x24,0x48,0x83,0xCA,0x04,0x48,0x89,0x14,0x24,0x48,0x83,0xF8,0x04,0x72,0x10,0x48,0xC1,0xE8,0x02,0x48,0x8B,0x14,0x24,0x48,0x83,0xCA,0x02,0x48,0x89,0x14,0x24,0x48,0x83,0xF8,0x02,0x72,0x0C,0x48,0x8B,0x04,0x24,0x48,0x83,0xC8,0x01,0x48,0x89,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong log2(uint src)
; location: [7FFDDDBCC760h, 7FFDDDBCC806h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
000bh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
000fh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0011h mov rdx,100000000h            ; MOV(Mov_r64_imm64) [RDX,100000000h:imm64]            encoding(10 bytes) = 48 ba 00 00 00 00 01 00 00 00
001bh cmp rax,rdx                   ; CMP(Cmp_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 3b c2
001eh jb short 0030h                ; JB(Jb_rel8_64) [30h:jmp64]                           encoding(2 bytes) = 72 10
0020h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0024h mov rdx,[rsp]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 14 24
0028h or rdx,20h                    ; OR(Or_rm64_imm8) [RDX,20h:imm64]                     encoding(4 bytes) = 48 83 ca 20
002ch mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
0030h cmp rax,10000h                ; CMP(Cmp_RAX_imm32) [RAX,10000h:imm64]                encoding(6 bytes) = 48 3d 00 00 01 00
0036h jb short 0048h                ; JB(Jb_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 72 10
0038h shr rax,10h                   ; SHR(Shr_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e8 10
003ch mov rdx,[rsp]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 14 24
0040h or rdx,10h                    ; OR(Or_rm64_imm8) [RDX,10h:imm64]                     encoding(4 bytes) = 48 83 ca 10
0044h mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
0048h cmp rax,100h                  ; CMP(Cmp_RAX_imm32) [RAX,100h:imm64]                  encoding(6 bytes) = 48 3d 00 01 00 00
004eh jb short 0060h                ; JB(Jb_rel8_64) [60h:jmp64]                           encoding(2 bytes) = 72 10
0050h shr rax,8                     ; SHR(Shr_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e8 08
0054h mov rdx,[rsp]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 14 24
0058h or rdx,8                      ; OR(Or_rm64_imm8) [RDX,8h:imm64]                      encoding(4 bytes) = 48 83 ca 08
005ch mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
0060h cmp rax,10h                   ; CMP(Cmp_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 f8 10
0064h jb short 0076h                ; JB(Jb_rel8_64) [76h:jmp64]                           encoding(2 bytes) = 72 10
0066h shr rax,4                     ; SHR(Shr_rm64_imm8) [RAX,4h:imm8]                     encoding(4 bytes) = 48 c1 e8 04
006ah mov rdx,[rsp]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 14 24
006eh or rdx,4                      ; OR(Or_rm64_imm8) [RDX,4h:imm64]                      encoding(4 bytes) = 48 83 ca 04
0072h mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
0076h cmp rax,4                     ; CMP(Cmp_rm64_imm8) [RAX,4h:imm64]                    encoding(4 bytes) = 48 83 f8 04
007ah jb short 008ch                ; JB(Jb_rel8_64) [8Ch:jmp64]                           encoding(2 bytes) = 72 10
007ch shr rax,2                     ; SHR(Shr_rm64_imm8) [RAX,2h:imm8]                     encoding(4 bytes) = 48 c1 e8 02
0080h mov rdx,[rsp]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 14 24
0084h or rdx,2                      ; OR(Or_rm64_imm8) [RDX,2h:imm64]                      encoding(4 bytes) = 48 83 ca 02
0088h mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
008ch cmp rax,2                     ; CMP(Cmp_rm64_imm8) [RAX,2h:imm64]                    encoding(4 bytes) = 48 83 f8 02
0090h jb short 009eh                ; JB(Jb_rel8_64) [9Eh:jmp64]                           encoding(2 bytes) = 72 0c
0092h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
0096h or rax,1                      ; OR(Or_rm64_imm8) [RAX,1h:imm64]                      encoding(4 bytes) = 48 83 c8 01
009ah mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
009eh mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
00a2h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
00a6h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[167]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x89,0x04,0x24,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x01,0x00,0x00,0x00,0x48,0x3B,0xC2,0x72,0x10,0x48,0xC1,0xE8,0x20,0x48,0x8B,0x14,0x24,0x48,0x83,0xCA,0x20,0x48,0x89,0x14,0x24,0x48,0x3D,0x00,0x00,0x01,0x00,0x72,0x10,0x48,0xC1,0xE8,0x10,0x48,0x8B,0x14,0x24,0x48,0x83,0xCA,0x10,0x48,0x89,0x14,0x24,0x48,0x3D,0x00,0x01,0x00,0x00,0x72,0x10,0x48,0xC1,0xE8,0x08,0x48,0x8B,0x14,0x24,0x48,0x83,0xCA,0x08,0x48,0x89,0x14,0x24,0x48,0x83,0xF8,0x10,0x72,0x10,0x48,0xC1,0xE8,0x04,0x48,0x8B,0x14,0x24,0x48,0x83,0xCA,0x04,0x48,0x89,0x14,0x24,0x48,0x83,0xF8,0x04,0x72,0x10,0x48,0xC1,0xE8,0x02,0x48,0x8B,0x14,0x24,0x48,0x83,0xCA,0x02,0x48,0x89,0x14,0x24,0x48,0x83,0xF8,0x02,0x72,0x0C,0x48,0x8B,0x04,0x24,0x48,0x83,0xC8,0x01,0x48,0x89,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt(sbyte lhs, sbyte rhs)
; location: [7FFDDDBCC820h, 7FFDDDBCC835h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ltBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt(byte lhs, byte rhs)
; location: [7FFDDDBCC850h, 7FFDDDBCC863h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ltBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt(short lhs, short rhs)
; location: [7FFDDDBCC880h, 7FFDDDBCC895h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ltBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt(ushort lhs, ushort rhs)
; location: [7FFDDDBCC8B0h, 7FFDDDBCC8C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ltBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt(int lhs, int rhs)
; location: [7FFDDDBCC8E0h, 7FFDDDBCC8EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ltBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt(uint lhs, uint rhs)
; location: [7FFDDDBCC900h, 7FFDDDBCC90Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ltBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt(long lhs, long rhs)
; location: [7FFDDDBCC920h, 7FFDDDBCC92Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ltBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt(ulong lhs, ulong rhs)
; location: [7FFDDDBCC940h, 7FFDDDBCC94Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ltBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq(sbyte lhs, sbyte rhs)
; location: [7FFDDDBCC960h, 7FFDDDBCC975h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteqBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq(byte lhs, byte rhs)
; location: [7FFDDDBCC990h, 7FFDDDBCC9A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteqBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq(short lhs, short rhs)
; location: [7FFDDDBCC9C0h, 7FFDDDBCC9D5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteqBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq(ushort lhs, ushort rhs)
; location: [7FFDDDBCC9F0h, 7FFDDDBCCA03h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteqBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq(int lhs, int rhs)
; location: [7FFDDDBCCA20h, 7FFDDDBCCA2Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq(uint lhs, uint rhs)
; location: [7FFDDDBCCA40h, 7FFDDDBCCA4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte abs(sbyte src)
; location: [7FFDDDBCCA60h, 7FFDDDBCCA76h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh sar edx,7                     ; SAR(Sar_rm32_imm8) [EDX,7h:imm8]                     encoding(3 bytes) = c1 fa 07
000eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0010h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0012h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xD0,0xC1,0xFA,0x07,0x03,0xC2,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short abs(short src)
; location: [7FFDDDBCCA90h, 7FFDDDBCCAA6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh sar edx,0Fh                   ; SAR(Sar_rm32_imm8) [EDX,fh:imm8]                     encoding(3 bytes) = c1 fa 0f
000eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0010h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0012h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xD0,0xC1,0xFA,0x0F,0x03,0xC2,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int abs(int src)
; location: [7FFDDDBCCAC0h, 7FFDDDBCCACFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
000ah lea edx,[rcx+rax]             ; LEA(Lea_r32_m) [EDX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 14 01
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x8D,0x14,0x01,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long abs(long src)
; location: [7FFDDDBCCAE0h, 7FFDDDBCCAF3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sar rax,3Fh                   ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f8 3f
000ch lea rdx,[rcx+rax]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 14 01
0010h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xF8,0x3F,0x48,0x8D,0x14,0x01,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float abs(float src)
; location: [7FFDDDBCCB10h, 7FFDDDBCCB21h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFDDDBCCB28h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vandps xmm0,xmm0,xmm1         ; VANDPS(VEX_Vandps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 54 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x54,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double abs(double src)
; location: [7FFDDDBCCB40h, 7FFDDDBCCB51h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFDDDBCCB58h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vandps xmm0,xmm0,xmm1         ; VANDPS(VEX_Vandps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 54 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x54,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte abs(ref sbyte src)
; location: [7FFDDDBCCB70h, 7FFDDDBCCB87h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh sar edx,7                     ; SAR(Sar_rm32_imm8) [EDX,7h:imm8]                     encoding(3 bytes) = c1 fa 07
000eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0010h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0012h mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
0014h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x8B,0xD0,0xC1,0xFA,0x07,0x03,0xC2,0x33,0xC2,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short abs(ref short src)
; location: [7FFDDDBCCBA0h, 7FFDDDBCCBB8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh sar edx,0Fh                   ; SAR(Sar_rm32_imm8) [EDX,fh:imm8]                     encoding(3 bytes) = c1 fa 0f
000eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0010h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0012h mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x8B,0xD0,0xC1,0xFA,0x0F,0x03,0xC2,0x33,0xC2,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int abs(ref int src)
; location: [7FFDDDBCCBD0h, 7FFDDDBCCBE5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0009h sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
000ch add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000eh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0010h mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8B,0xD0,0xC1,0xFA,0x1F,0x03,0xC2,0x33,0xC2,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long abs(ref long src)
; location: [7FFDDDBCCC00h, 7FFDDDBCCC1Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
000bh sar rdx,3Fh                   ; SAR(Sar_rm64_imm8) [RDX,3fh:imm8]                    encoding(4 bytes) = 48 c1 fa 3f
000fh add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0012h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0015h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8B,0xD0,0x48,0xC1,0xFA,0x3F,0x48,0x03,0xC2,0x48,0x33,0xC2,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<sbyte> abs(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
; location: [7FFDDDBCD040h, 7FFDDDBCD111h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000ah mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 00
000dh mov r8d,[r8+8]                ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 45 8b 40 08
0011h mov r9,[rdx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 0a
0014h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0017h mov esi,6Dh                   ; MOV(Mov_r32_imm32) [ESI,6dh:imm32]                   encoding(5 bytes) = be 6d 00 00 00
001ch mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0021h mov ebx,edx                   ; MOV(Mov_r32_rm32) [EBX,EDX]                          encoding(2 bytes) = 8b da
0023h mov ebp,r8d                   ; MOV(Mov_r32_rm32) [EBP,R8D]                          encoding(3 bytes) = 41 8b e8
0026h cmp edx,r8d                   ; CMP(Cmp_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 3b d0
0029h jne short 0073h               ; JNE(Jne_rel8_64) [73h:jmp64]                         encoding(2 bytes) = 75 48
002bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
002eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0030h jle short 005eh               ; JLE(Jle_rel8_64) [5Eh:jmp64]                         encoding(2 bytes) = 7e 2c
0032h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
0035h jae near ptr 00cch            ; JAE(Jae_rel32_64) [CCh:jmp64]                        encoding(6 bytes) = 0f 83 91 00 00 00
003bh movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
003eh lea rbx,[rax+r11]             ; LEA(Lea_r64_m) [RBX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 4a 8d 1c 18
0042h movsx r11,byte ptr [r9+r11]   ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,R9:br,DS:sr)]       encoding(5 bytes) = 4f 0f be 1c 19
0047h mov ebp,r11d                  ; MOV(Mov_r32_rm32) [EBP,R11D]                         encoding(3 bytes) = 41 8b eb
004ah sar ebp,7                     ; SAR(Sar_rm32_imm8) [EBP,7h:imm8]                     encoding(3 bytes) = c1 fd 07
004dh add r11d,ebp                  ; ADD(Add_r32_rm32) [R11D,EBP]                         encoding(3 bytes) = 44 03 dd
0050h xor r11d,ebp                  ; XOR(Xor_r32_rm32) [R11D,EBP]                         encoding(3 bytes) = 44 33 dd
0053h mov [rbx],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RBX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 1b
0056h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0059h cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
005ch jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c d4
005eh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0061h mov [rcx+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 41 08
0065h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0068h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
006ch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
006dh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
006eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0070h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0072h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0073h mov ecx,0A45h                 ; MOV(Mov_r32_imm32) [ECX,a45h:imm32]                  encoding(5 bytes) = b9 45 0a 00 00
0078h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0082h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6526A0h:jmp64]                encoding(5 bytes) = e8 19 26 65 5f
0087h mov r14,rax                   ; MOV(Mov_r64_rm64) [R14,RAX]                          encoding(3 bytes) = 4c 8b f0
008ah mov ecx,0A4Dh                 ; MOV(Mov_r32_imm32) [ECX,a4dh:imm32]                  encoding(5 bytes) = b9 4d 0a 00 00
008fh mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0099h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6526A0h:jmp64]                encoding(5 bytes) = e8 02 26 65 5f
009eh mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
00a1h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
00a6h mov [r8],dil                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),DIL]            encoding(3 bytes) = 41 88 38
00a9h mov [r8+4],esi                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ESI]         encoding(4 bytes) = 41 89 70 04
00adh mov r8,r14                    ; MOV(Mov_r64_rm64) [R8,R14]                           encoding(3 bytes) = 4d 8b c6
00b0h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
00b2h mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00b4h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00b9h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00beh call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD288A8h:jmp64]        encoding(5 bytes) = e8 e5 87 d2 ff
00c3h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00c6h call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DD4B0h:jmp64]                encoding(5 bytes) = e8 e5 d3 4d 5f
00cbh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00cch call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F651EC0h:jmp64]                encoding(5 bytes) = e8 ef 1d 65 5f
00d1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> absBytes => new byte[210]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x49,0x8B,0x00,0x45,0x8B,0x40,0x08,0x4C,0x8B,0x0A,0x8B,0x52,0x08,0xBE,0x6D,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0x8B,0xDA,0x41,0x8B,0xE8,0x41,0x3B,0xD0,0x75,0x48,0x45,0x33,0xD2,0x85,0xD2,0x7E,0x2C,0x45,0x3B,0xD0,0x0F,0x83,0x91,0x00,0x00,0x00,0x4D,0x63,0xDA,0x4A,0x8D,0x1C,0x18,0x4F,0x0F,0xBE,0x1C,0x19,0x41,0x8B,0xEB,0xC1,0xFD,0x07,0x44,0x03,0xDD,0x44,0x33,0xDD,0x44,0x88,0x1B,0x41,0xFF,0xC2,0x44,0x3B,0xD2,0x7C,0xD4,0x48,0x89,0x01,0x44,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xB9,0x45,0x0A,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x19,0x26,0x65,0x5F,0x4C,0x8B,0xF0,0xB9,0x4D,0x0A,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x02,0x26,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0x41,0x88,0x38,0x41,0x89,0x70,0x04,0x4D,0x8B,0xC6,0x8B,0xCB,0x8B,0xD5,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0xE8,0xE5,0x87,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0xE5,0xD3,0x4D,0x5F,0xCC,0xE8,0xEF,0x1D,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<short> abs(ReadOnlySpan<short> src, Span<short> dst)
; location: [7FFDDDBCD130h, 7FFDDDBCD202h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000ah mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 00
000dh mov r8d,[r8+8]                ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 45 8b 40 08
0011h mov r9,[rdx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 0a
0014h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0017h mov esi,75h                   ; MOV(Mov_r32_imm32) [ESI,75h:imm32]                   encoding(5 bytes) = be 75 00 00 00
001ch mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0021h mov ebx,edx                   ; MOV(Mov_r32_rm32) [EBX,EDX]                          encoding(2 bytes) = 8b da
0023h mov ebp,r8d                   ; MOV(Mov_r32_rm32) [EBP,R8D]                          encoding(3 bytes) = 41 8b e8
0026h cmp edx,r8d                   ; CMP(Cmp_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 3b d0
0029h jne short 0074h               ; JNE(Jne_rel8_64) [74h:jmp64]                         encoding(2 bytes) = 75 49
002bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
002eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0030h jle short 005fh               ; JLE(Jle_rel8_64) [5Fh:jmp64]                         encoding(2 bytes) = 7e 2d
0032h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
0035h jae near ptr 00cdh            ; JAE(Jae_rel32_64) [CDh:jmp64]                        encoding(6 bytes) = 0f 83 92 00 00 00
003bh movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
003eh lea rbx,[rax+r11*2]           ; LEA(Lea_r64_m) [RBX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 4a 8d 1c 58
0042h movsx r11,word ptr [r9+r11*2] ; MOVSX(Movsx_r64_rm16) [R11,mem(16i,R9:br,DS:sr)]     encoding(5 bytes) = 4f 0f bf 1c 59
0047h mov ebp,r11d                  ; MOV(Mov_r32_rm32) [EBP,R11D]                         encoding(3 bytes) = 41 8b eb
004ah sar ebp,0Fh                   ; SAR(Sar_rm32_imm8) [EBP,fh:imm8]                     encoding(3 bytes) = c1 fd 0f
004dh add r11d,ebp                  ; ADD(Add_r32_rm32) [R11D,EBP]                         encoding(3 bytes) = 44 03 dd
0050h xor r11d,ebp                  ; XOR(Xor_r32_rm32) [R11D,EBP]                         encoding(3 bytes) = 44 33 dd
0053h mov [rbx],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RBX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 1b
0057h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
005ah cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
005dh jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c d3
005fh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0062h mov [rcx+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 41 08
0066h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0069h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
006dh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
006eh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
006fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0070h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0071h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0073h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0074h mov ecx,0A45h                 ; MOV(Mov_r32_imm32) [ECX,a45h:imm32]                  encoding(5 bytes) = b9 45 0a 00 00
0079h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0083h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6525B0h:jmp64]                encoding(5 bytes) = e8 28 25 65 5f
0088h mov r14,rax                   ; MOV(Mov_r64_rm64) [R14,RAX]                          encoding(3 bytes) = 4c 8b f0
008bh mov ecx,0A4Dh                 ; MOV(Mov_r32_imm32) [ECX,a4dh:imm32]                  encoding(5 bytes) = b9 4d 0a 00 00
0090h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
009ah call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6525B0h:jmp64]                encoding(5 bytes) = e8 11 25 65 5f
009fh mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
00a2h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
00a7h mov [r8],dil                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),DIL]            encoding(3 bytes) = 41 88 38
00aah mov [r8+4],esi                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ESI]         encoding(4 bytes) = 41 89 70 04
00aeh mov r8,r14                    ; MOV(Mov_r64_rm64) [R8,R14]                           encoding(3 bytes) = 4d 8b c6
00b1h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
00b3h mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00b5h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00bah mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00bfh call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD287B8h:jmp64]        encoding(5 bytes) = e8 f4 86 d2 ff
00c4h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00c7h call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DD3C0h:jmp64]                encoding(5 bytes) = e8 f4 d2 4d 5f
00cch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00cdh call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F651DD0h:jmp64]                encoding(5 bytes) = e8 fe 1c 65 5f
00d2h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> absBytes => new byte[211]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x49,0x8B,0x00,0x45,0x8B,0x40,0x08,0x4C,0x8B,0x0A,0x8B,0x52,0x08,0xBE,0x75,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0x8B,0xDA,0x41,0x8B,0xE8,0x41,0x3B,0xD0,0x75,0x49,0x45,0x33,0xD2,0x85,0xD2,0x7E,0x2D,0x45,0x3B,0xD0,0x0F,0x83,0x92,0x00,0x00,0x00,0x4D,0x63,0xDA,0x4A,0x8D,0x1C,0x58,0x4F,0x0F,0xBF,0x1C,0x59,0x41,0x8B,0xEB,0xC1,0xFD,0x0F,0x44,0x03,0xDD,0x44,0x33,0xDD,0x66,0x44,0x89,0x1B,0x41,0xFF,0xC2,0x44,0x3B,0xD2,0x7C,0xD3,0x48,0x89,0x01,0x44,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xB9,0x45,0x0A,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x28,0x25,0x65,0x5F,0x4C,0x8B,0xF0,0xB9,0x4D,0x0A,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x11,0x25,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0x41,0x88,0x38,0x41,0x89,0x70,0x04,0x4D,0x8B,0xC6,0x8B,0xCB,0x8B,0xD5,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0xE8,0xF4,0x86,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0xF4,0xD2,0x4D,0x5F,0xCC,0xE8,0xFE,0x1C,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<int> abs(ReadOnlySpan<int> src, Span<int> dst)
; location: [7FFDDDBCD220h, 7FFDDDBCD2F0h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000ah mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 00
000dh mov r8d,[r8+8]                ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 45 8b 40 08
0011h mov r9,[rdx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 0a
0014h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0017h mov esi,7Dh                   ; MOV(Mov_r32_imm32) [ESI,7dh:imm32]                   encoding(5 bytes) = be 7d 00 00 00
001ch mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0021h mov ebx,edx                   ; MOV(Mov_r32_rm32) [EBX,EDX]                          encoding(2 bytes) = 8b da
0023h mov ebp,r8d                   ; MOV(Mov_r32_rm32) [EBP,R8D]                          encoding(3 bytes) = 41 8b e8
0026h cmp edx,r8d                   ; CMP(Cmp_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 3b d0
0029h jne short 0072h               ; JNE(Jne_rel8_64) [72h:jmp64]                         encoding(2 bytes) = 75 47
002bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
002eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0030h jle short 005dh               ; JLE(Jle_rel8_64) [5Dh:jmp64]                         encoding(2 bytes) = 7e 2b
0032h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
0035h jae near ptr 00cbh            ; JAE(Jae_rel32_64) [CBh:jmp64]                        encoding(6 bytes) = 0f 83 90 00 00 00
003bh movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
003eh lea rbx,[rax+r11*4]           ; LEA(Lea_r64_m) [RBX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 4a 8d 1c 98
0042h mov r11d,[r9+r11*4]           ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 47 8b 1c 99
0046h mov ebp,r11d                  ; MOV(Mov_r32_rm32) [EBP,R11D]                         encoding(3 bytes) = 41 8b eb
0049h sar ebp,1Fh                   ; SAR(Sar_rm32_imm8) [EBP,1fh:imm8]                    encoding(3 bytes) = c1 fd 1f
004ch add r11d,ebp                  ; ADD(Add_r32_rm32) [R11D,EBP]                         encoding(3 bytes) = 44 03 dd
004fh xor r11d,ebp                  ; XOR(Xor_r32_rm32) [R11D,EBP]                         encoding(3 bytes) = 44 33 dd
0052h mov [rbx],r11d                ; MOV(Mov_rm32_r32) [mem(32u,RBX:br,DS:sr),R11D]       encoding(3 bytes) = 44 89 1b
0055h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0058h cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
005bh jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c d5
005dh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0060h mov [rcx+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 41 08
0064h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0067h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
006bh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
006ch pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
006dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006eh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
006fh pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0071h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0072h mov ecx,0A45h                 ; MOV(Mov_r32_imm32) [ECX,a45h:imm32]                  encoding(5 bytes) = b9 45 0a 00 00
0077h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0081h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6524C0h:jmp64]                encoding(5 bytes) = e8 3a 24 65 5f
0086h mov r14,rax                   ; MOV(Mov_r64_rm64) [R14,RAX]                          encoding(3 bytes) = 4c 8b f0
0089h mov ecx,0A4Dh                 ; MOV(Mov_r32_imm32) [ECX,a4dh:imm32]                  encoding(5 bytes) = b9 4d 0a 00 00
008eh mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0098h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6524C0h:jmp64]                encoding(5 bytes) = e8 23 24 65 5f
009dh mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
00a0h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
00a5h mov [r8],dil                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),DIL]            encoding(3 bytes) = 41 88 38
00a8h mov [r8+4],esi                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ESI]         encoding(4 bytes) = 41 89 70 04
00ach mov r8,r14                    ; MOV(Mov_r64_rm64) [R8,R14]                           encoding(3 bytes) = 4d 8b c6
00afh mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
00b1h mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00b3h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00b8h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00bdh call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD286C8h:jmp64]        encoding(5 bytes) = e8 06 86 d2 ff
00c2h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00c5h call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DD2D0h:jmp64]                encoding(5 bytes) = e8 06 d2 4d 5f
00cah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00cbh call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F651CE0h:jmp64]                encoding(5 bytes) = e8 10 1c 65 5f
00d0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> absBytes => new byte[209]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x49,0x8B,0x00,0x45,0x8B,0x40,0x08,0x4C,0x8B,0x0A,0x8B,0x52,0x08,0xBE,0x7D,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0x8B,0xDA,0x41,0x8B,0xE8,0x41,0x3B,0xD0,0x75,0x47,0x45,0x33,0xD2,0x85,0xD2,0x7E,0x2B,0x45,0x3B,0xD0,0x0F,0x83,0x90,0x00,0x00,0x00,0x4D,0x63,0xDA,0x4A,0x8D,0x1C,0x98,0x47,0x8B,0x1C,0x99,0x41,0x8B,0xEB,0xC1,0xFD,0x1F,0x44,0x03,0xDD,0x44,0x33,0xDD,0x44,0x89,0x1B,0x41,0xFF,0xC2,0x44,0x3B,0xD2,0x7C,0xD5,0x48,0x89,0x01,0x44,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xB9,0x45,0x0A,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x3A,0x24,0x65,0x5F,0x4C,0x8B,0xF0,0xB9,0x4D,0x0A,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x23,0x24,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0x41,0x88,0x38,0x41,0x89,0x70,0x04,0x4D,0x8B,0xC6,0x8B,0xCB,0x8B,0xD5,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0xE8,0x06,0x86,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0x06,0xD2,0x4D,0x5F,0xCC,0xE8,0x10,0x1C,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<long> abs(ReadOnlySpan<long> src, Span<long> dst)
; location: [7FFDDDBCD310h, 7FFDDDBCD3E1h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000ah mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 00
000dh mov r8d,[r8+8]                ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 45 8b 40 08
0011h mov r9,[rdx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 0a
0014h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0017h mov esi,85h                   ; MOV(Mov_r32_imm32) [ESI,85h:imm32]                   encoding(5 bytes) = be 85 00 00 00
001ch mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0021h mov ebx,edx                   ; MOV(Mov_r32_rm32) [EBX,EDX]                          encoding(2 bytes) = 8b da
0023h mov ebp,r8d                   ; MOV(Mov_r32_rm32) [EBP,R8D]                          encoding(3 bytes) = 41 8b e8
0026h cmp edx,r8d                   ; CMP(Cmp_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 3b d0
0029h jne short 0073h               ; JNE(Jne_rel8_64) [73h:jmp64]                         encoding(2 bytes) = 75 48
002bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
002eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0030h jle short 005eh               ; JLE(Jle_rel8_64) [5Eh:jmp64]                         encoding(2 bytes) = 7e 2c
0032h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
0035h jae near ptr 00cch            ; JAE(Jae_rel32_64) [CCh:jmp64]                        encoding(6 bytes) = 0f 83 91 00 00 00
003bh movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
003eh lea rbx,[rax+r11*8]           ; LEA(Lea_r64_m) [RBX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 4a 8d 1c d8
0042h mov r11,[r9+r11*8]            ; MOV(Mov_r64_rm64) [R11,mem(64u,R9:br,DS:sr)]         encoding(4 bytes) = 4f 8b 1c d9
0046h mov rbp,r11                   ; MOV(Mov_r64_rm64) [RBP,R11]                          encoding(3 bytes) = 49 8b eb
0049h sar rbp,3Fh                   ; SAR(Sar_rm64_imm8) [RBP,3fh:imm8]                    encoding(4 bytes) = 48 c1 fd 3f
004dh add r11,rbp                   ; ADD(Add_r64_rm64) [R11,RBP]                          encoding(3 bytes) = 4c 03 dd
0050h xor r11,rbp                   ; XOR(Xor_r64_rm64) [R11,RBP]                          encoding(3 bytes) = 4c 33 dd
0053h mov [rbx],r11                 ; MOV(Mov_rm64_r64) [mem(64u,RBX:br,DS:sr),R11]        encoding(3 bytes) = 4c 89 1b
0056h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0059h cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
005ch jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c d4
005eh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0061h mov [rcx+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 41 08
0065h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0068h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
006ch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
006dh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
006eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0070h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0072h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0073h mov ecx,0A45h                 ; MOV(Mov_r32_imm32) [ECX,a45h:imm32]                  encoding(5 bytes) = b9 45 0a 00 00
0078h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0082h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6523D0h:jmp64]                encoding(5 bytes) = e8 49 23 65 5f
0087h mov r14,rax                   ; MOV(Mov_r64_rm64) [R14,RAX]                          encoding(3 bytes) = 4c 8b f0
008ah mov ecx,0A4Dh                 ; MOV(Mov_r32_imm32) [ECX,a4dh:imm32]                  encoding(5 bytes) = b9 4d 0a 00 00
008fh mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
0099h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6523D0h:jmp64]                encoding(5 bytes) = e8 32 23 65 5f
009eh mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
00a1h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
00a6h mov [r8],dil                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),DIL]            encoding(3 bytes) = 41 88 38
00a9h mov [r8+4],esi                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ESI]         encoding(4 bytes) = 41 89 70 04
00adh mov r8,r14                    ; MOV(Mov_r64_rm64) [R8,R14]                           encoding(3 bytes) = 4d 8b c6
00b0h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
00b2h mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00b4h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00b9h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00beh call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD285D8h:jmp64]        encoding(5 bytes) = e8 15 85 d2 ff
00c3h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00c6h call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DD1E0h:jmp64]                encoding(5 bytes) = e8 15 d1 4d 5f
00cbh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00cch call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F651BF0h:jmp64]                encoding(5 bytes) = e8 1f 1b 65 5f
00d1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> absBytes => new byte[210]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x49,0x8B,0x00,0x45,0x8B,0x40,0x08,0x4C,0x8B,0x0A,0x8B,0x52,0x08,0xBE,0x85,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0x8B,0xDA,0x41,0x8B,0xE8,0x41,0x3B,0xD0,0x75,0x48,0x45,0x33,0xD2,0x85,0xD2,0x7E,0x2C,0x45,0x3B,0xD0,0x0F,0x83,0x91,0x00,0x00,0x00,0x4D,0x63,0xDA,0x4A,0x8D,0x1C,0xD8,0x4F,0x8B,0x1C,0xD9,0x49,0x8B,0xEB,0x48,0xC1,0xFD,0x3F,0x4C,0x03,0xDD,0x4C,0x33,0xDD,0x4C,0x89,0x1B,0x41,0xFF,0xC2,0x44,0x3B,0xD2,0x7C,0xD4,0x48,0x89,0x01,0x44,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xB9,0x45,0x0A,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x49,0x23,0x65,0x5F,0x4C,0x8B,0xF0,0xB9,0x4D,0x0A,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x32,0x23,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0x41,0x88,0x38,0x41,0x89,0x70,0x04,0x4D,0x8B,0xC6,0x8B,0xCB,0x8B,0xD5,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0xE8,0x15,0x85,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0x15,0xD1,0x4D,0x5F,0xCC,0xE8,0x1F,0x1B,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<sbyte> abs(Span<sbyte> src)
; location: [7FFDDDBCD400h, 7FFDDDBCD43Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
000eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0010h jle short 0034h               ; JLE(Jle_rel8_64) [34h:jmp64]                         encoding(2 bytes) = 7e 22
0012h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0015h add r9,rax                    ; ADD(Add_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 03 c8
0018h movsx r10,byte ptr [r9]       ; MOVSX(Movsx_r64_rm8) [R10,mem(8i,R9:br,DS:sr)]       encoding(4 bytes) = 4d 0f be 11
001ch mov r11d,r10d                 ; MOV(Mov_r32_rm32) [R11D,R10D]                        encoding(3 bytes) = 45 8b da
001fh sar r11d,7                    ; SAR(Sar_rm32_imm8) [R11D,7h:imm8]                    encoding(4 bytes) = 41 c1 fb 07
0023h add r10d,r11d                 ; ADD(Add_r32_rm32) [R10D,R11D]                        encoding(3 bytes) = 45 03 d3
0026h xor r10d,r11d                 ; XOR(Xor_r32_rm32) [R10D,R11D]                        encoding(3 bytes) = 45 33 d3
0029h mov [r9],r10b                 ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),R10L]           encoding(3 bytes) = 45 88 11
002ch inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
002fh cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0032h jl short 0012h                ; JL(Jl_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 7c de
0034h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0037h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
003ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[62]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0x52,0x08,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x22,0x4D,0x63,0xC8,0x4C,0x03,0xC8,0x4D,0x0F,0xBE,0x11,0x45,0x8B,0xDA,0x41,0xC1,0xFB,0x07,0x45,0x03,0xD3,0x45,0x33,0xD3,0x45,0x88,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC2,0x7C,0xDE,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<short> abs(Span<short> src)
; location: [7FFDDDBCD450h, 7FFDDDBCD48Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
000eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0010h jle short 0036h               ; JLE(Jle_rel8_64) [36h:jmp64]                         encoding(2 bytes) = 7e 24
0012h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0015h lea r9,[rax+r9*2]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4e 8d 0c 48
0019h movsx r10,word ptr [r9]       ; MOVSX(Movsx_r64_rm16) [R10,mem(16i,R9:br,DS:sr)]     encoding(4 bytes) = 4d 0f bf 11
001dh mov r11d,r10d                 ; MOV(Mov_r32_rm32) [R11D,R10D]                        encoding(3 bytes) = 45 8b da
0020h sar r11d,0Fh                  ; SAR(Sar_rm32_imm8) [R11D,fh:imm8]                    encoding(4 bytes) = 41 c1 fb 0f
0024h add r10d,r11d                 ; ADD(Add_r32_rm32) [R10D,R11D]                        encoding(3 bytes) = 45 03 d3
0027h xor r10d,r11d                 ; XOR(Xor_r32_rm32) [R10D,R11D]                        encoding(3 bytes) = 45 33 d3
002ah mov [r9],r10w                 ; MOV(Mov_rm16_r16) [mem(16u,R9:br,DS:sr),R10W]        encoding(4 bytes) = 66 45 89 11
002eh inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0031h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0034h jl short 0012h                ; JL(Jl_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 7c dc
0036h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0039h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
003ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[64]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0x52,0x08,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x24,0x4D,0x63,0xC8,0x4E,0x8D,0x0C,0x48,0x4D,0x0F,0xBF,0x11,0x45,0x8B,0xDA,0x41,0xC1,0xFB,0x0F,0x45,0x03,0xD3,0x45,0x33,0xD3,0x66,0x45,0x89,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC2,0x7C,0xDC,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<int> abs(Span<int> src)
; location: [7FFDDDBCD4A0h, 7FFDDDBCD4DDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
000eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0010h jle short 0034h               ; JLE(Jle_rel8_64) [34h:jmp64]                         encoding(2 bytes) = 7e 22
0012h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0015h lea r9,[rax+r9*4]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4e 8d 0c 88
0019h mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
001ch mov r11d,r10d                 ; MOV(Mov_r32_rm32) [R11D,R10D]                        encoding(3 bytes) = 45 8b da
001fh sar r11d,1Fh                  ; SAR(Sar_rm32_imm8) [R11D,1fh:imm8]                   encoding(4 bytes) = 41 c1 fb 1f
0023h add r10d,r11d                 ; ADD(Add_r32_rm32) [R10D,R11D]                        encoding(3 bytes) = 45 03 d3
0026h xor r10d,r11d                 ; XOR(Xor_r32_rm32) [R10D,R11D]                        encoding(3 bytes) = 45 33 d3
0029h mov [r9],r10d                 ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),R10D]        encoding(3 bytes) = 45 89 11
002ch inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
002fh cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0032h jl short 0012h                ; JL(Jl_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 7c de
0034h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0037h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
003ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[62]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0x52,0x08,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x22,0x4D,0x63,0xC8,0x4E,0x8D,0x0C,0x88,0x45,0x8B,0x11,0x45,0x8B,0xDA,0x41,0xC1,0xFB,0x1F,0x45,0x03,0xD3,0x45,0x33,0xD3,0x45,0x89,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC2,0x7C,0xDE,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<long> abs(Span<long> src)
; location: [7FFDDDBCD4F0h, 7FFDDDBCD52Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
000eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0010h jle short 0034h               ; JLE(Jle_rel8_64) [34h:jmp64]                         encoding(2 bytes) = 7e 22
0012h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0015h lea r9,[rax+r9*8]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4e 8d 0c c8
0019h mov r10,[r9]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R9:br,DS:sr)]         encoding(3 bytes) = 4d 8b 11
001ch mov r11,r10                   ; MOV(Mov_r64_rm64) [R11,R10]                          encoding(3 bytes) = 4d 8b da
001fh sar r11,3Fh                   ; SAR(Sar_rm64_imm8) [R11,3fh:imm8]                    encoding(4 bytes) = 49 c1 fb 3f
0023h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0026h xor r10,r11                   ; XOR(Xor_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 33 d3
0029h mov [r9],r10                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),R10]         encoding(3 bytes) = 4d 89 11
002ch inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
002fh cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0032h jl short 0012h                ; JL(Jl_rel8_64) [12h:jmp64]                           encoding(2 bytes) = 7c de
0034h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0037h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
003ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[62]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0x52,0x08,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x22,0x4D,0x63,0xC8,0x4E,0x8D,0x0C,0xC8,0x4D,0x8B,0x11,0x4D,0x8B,0xDA,0x49,0xC1,0xFB,0x3F,0x4D,0x03,0xD3,0x4D,0x33,0xD3,0x4D,0x89,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC2,0x7C,0xDE,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte add(sbyte lhs, sbyte rhs)
; location: [7FFDDDBCD540h, 7FFDDDBCD553h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte add(byte lhs, byte rhs)
; location: [7FFDDDBCD570h, 7FFDDDBCD580h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short add(short lhs, short rhs)
; location: [7FFDDDBCD5A0h, 7FFDDDBCD5B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort add(ushort lhs, ushort rhs)
; location: [7FFDDDBCD5D0h, 7FFDDDBCD5E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add(int lhs, int rhs)
; location: [7FFDDDBCD600h, 7FFDDDBCD608h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add(uint lhs, uint rhs)
; location: [7FFDDDBCD620h, 7FFDDDBCD628h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long add(long lhs, long rhs)
; location: [7FFDDDBCD640h, 7FFDDDBCD649h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong add(ulong lhs, ulong rhs)
; location: [7FFDDDBCD660h, 7FFDDDBCD669h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte add(ref sbyte lhs, sbyte rhs)
; location: [7FFDDDBCD680h, 7FFDDDBCD68Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h add [rcx],al                  ; ADD(Add_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 00 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x00,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte add(ref byte lhs, byte rhs)
; location: [7FFDDDBCD6A0h, 7FFDDDBCD6ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h add [rcx],al                  ; ADD(Add_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 00 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x00,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short add(ref short lhs, short rhs)
; location: [7FFDDDBCD6C0h, 7FFDDDBCD6CFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h add [rcx],ax                  ; ADD(Add_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 01 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x66,0x01,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort add(ref ushort lhs, ushort rhs)
; location: [7FFDDDBCD6E0h, 7FFDDDBCD6EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h add [rcx],ax                  ; ADD(Add_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 01 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x66,0x01,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int add(ref int lhs, int rhs)
; location: [7FFDDDBCD700h, 7FFDDDBCD70Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add [rcx],edx                 ; ADD(Add_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 01 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x01,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint add(ref uint lhs, uint rhs)
; location: [7FFDDDBCD720h, 7FFDDDBCD72Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add [rcx],edx                 ; ADD(Add_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 01 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x01,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long add(ref long lhs, long rhs)
; location: [7FFDDDBCD740h, 7FFDDDBCD74Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add [rcx],rdx                 ; ADD(Add_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 01 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x01,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong add(ref ulong lhs, ulong rhs)
; location: [7FFDDDBCD760h, 7FFDDDBCD76Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add [rcx],rdx                 ; ADD(Add_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 01 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x01,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte and(sbyte lhs, sbyte rhs)
; location: [7FFDDDBCD780h, 7FFDDDBCD793h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x23,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte and(byte lhs, byte rhs)
; location: [7FFDDDBCD7B0h, 7FFDDDBCD7C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short and(short lhs, short rhs)
; location: [7FFDDDBCD7E0h, 7FFDDDBCD7F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x23,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort and(ushort lhs, ushort rhs)
; location: [7FFDDDBCD810h, 7FFDDDBCD820h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x23,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int and(int lhs, int rhs)
; location: [7FFDDDBCD840h, 7FFDDDBCD849h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and(uint lhs, uint rhs)
; location: [7FFDDDBCD860h, 7FFDDDBCD869h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long and(long lhs, long rhs)
; location: [7FFDDDBCD880h, 7FFDDDBCD88Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong and(ulong lhs, ulong rhs)
; location: [7FFDDDBCD8A0h, 7FFDDDBCD8ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float and(float lhs, float rhs)
; location: [7FFDDDBCD8C0h, 7FFDDDBCD8E9h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h and eax,[rsp+10h]             ; AND(And_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 23 44 24 10
001bh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x23,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double and(double lhs, double rhs)
; location: [7FFDDDBCD910h, 7FFDDDBCD93Ah]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h and rax,[rsp+8]               ; AND(And_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 44 24 08
001dh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x23,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte and(in sbyte lhs, in sbyte rhs, ref sbyte dst)
; location: [7FFDDDBCD960h, 7FFDDDBCD975h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h movsx rdx,byte ptr [rdx]      ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RDX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 12
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0012h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x48,0x0F,0xBE,0x12,0x23,0xC2,0x41,0x88,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte and(in byte lhs, in byte rhs, ref byte dst)
; location: [7FFDDDBCD990h, 7FFDDDBCD9A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h movzx edx,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RDX:br,DS:sr)]      encoding(3 bytes) = 0f b6 12
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0010h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x0F,0xB6,0x12,0x23,0xC2,0x41,0x88,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short and(in short lhs, in short rhs, ref short dst)
; location: [7FFDDDBCD9C0h, 7FFDDDBCD9D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h movsx rdx,word ptr [rdx]      ; MOVSX(Movsx_r64_rm16) [RDX,mem(16i,RDX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 12
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),AX]          encoding(4 bytes) = 66 41 89 00
0013h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x48,0x0F,0xBF,0x12,0x23,0xC2,0x66,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort and(in ushort lhs, in ushort rhs, ref ushort dst)
; location: [7FFDDDBCD9F0h, 7FFDDDBCDA04h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h movzx edx,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EDX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 12
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),AX]          encoding(4 bytes) = 66 41 89 00
0011h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x0F,0xB7,0x12,0x23,0xC2,0x66,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int and(in int lhs, in int rhs, ref int dst)
; location: [7FFDDDBCDA20h, 7FFDDDBCDA2Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h and eax,[rdx]                 ; AND(And_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 23 02
0009h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x23,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint and(in uint lhs, in uint rhs, ref uint dst)
; location: [7FFDDDBCDA40h, 7FFDDDBCDA4Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h and eax,[rdx]                 ; AND(And_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 23 02
0009h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x23,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long and(in long lhs, in long rhs, ref long dst)
; location: [7FFDDDBCDA60h, 7FFDDDBCDA71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h and rax,[rdx]                 ; AND(And_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 23 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x23,0x02,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong and(in ulong lhs, in ulong rhs, ref ulong dst)
; location: [7FFDDDBCDA90h, 7FFDDDBCDAA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h and rax,[rdx]                 ; AND(And_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 23 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x23,0x02,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float and(in float lhs, in float rhs, ref float dst)
; location: [7FFDDDBCDAC0h, 7FFDDDBCDAF9h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
000bh vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
0011h mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0015h vmovss xmm0,dword ptr [rdx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 02
0019h vmovss dword ptr [rsp+10h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 10
001fh and eax,[rsp+10h]             ; AND(And_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 23 44 24 10
0023h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0027h vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
002dh vmovss dword ptr [r8],xmm0    ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 11 00
0032h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0035h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[58]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x10,0x02,0xC5,0xFA,0x11,0x44,0x24,0x10,0x23,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0xC4,0xC1,0x7A,0x11,0x00,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double and(in double lhs, in double rhs, ref double dst)
; location: [7FFDDDBCDB20h, 7FFDDDBCDB5Ah]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
000bh vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0011h mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0016h vmovsd xmm0,qword ptr [rdx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 02
001ah vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
0020h and rax,[rsp+8]               ; AND(And_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 44 24 08
0025h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0029h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
002eh vmovsd qword ptr [r8],xmm0    ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7b 11 00
0033h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0036h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[59]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x10,0x02,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x23,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0xC4,0xC1,0x7B,0x11,0x00,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte and(ref sbyte lhs, sbyte rhs)
; location: [7FFDDDBCDB80h, 7FFDDDBCDB8Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h and [rcx],al                  ; AND(And_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 20 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x20,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte and(ref byte lhs, byte rhs)
; location: [7FFDDDBCDBA0h, 7FFDDDBCDBADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h and [rcx],al                  ; AND(And_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 20 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x20,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short and(ref short lhs, short rhs)
; location: [7FFDDDBCDBC0h, 7FFDDDBCDBCFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h and [rcx],ax                  ; AND(And_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 21 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x66,0x21,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort and(ref ushort lhs, ushort rhs)
; location: [7FFDDDBCDBE0h, 7FFDDDBCDBEEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h and [rcx],ax                  ; AND(And_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 21 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x66,0x21,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int and(ref int lhs, int rhs)
; location: [7FFDDDBCDC00h, 7FFDDDBCDC0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and [rcx],edx                 ; AND(And_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 21 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x21,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint and(ref uint lhs, uint rhs)
; location: [7FFDDDBCDC20h, 7FFDDDBCDC2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and [rcx],edx                 ; AND(And_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 21 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x21,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long and(ref long lhs, long rhs)
; location: [7FFDDDBCDC40h, 7FFDDDBCDC4Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and [rcx],rdx                 ; AND(And_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 21 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x21,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong and(ref ulong lhs, ulong rhs)
; location: [7FFDDDBCDC60h, 7FFDDDBCDC6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and [rcx],rdx                 ; AND(And_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 21 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x21,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float and(ref float lhs, float rhs)
; location: [7FFDDDBCDC80h, 7FFDDDBCDCB4h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
000bh vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
0011h mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0015h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
001bh and eax,[rsp+10h]             ; AND(And_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 23 44 24 10
001fh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0023h vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0029h vmovss dword ptr [rcx],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[53]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x23,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0xC5,0xFA,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double and(ref double lhs, double rhs)
; location: [7FFDDDBCDCD0h, 7FFDDDBCDD05h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
000bh vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0011h mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0016h vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
001ch and rax,[rsp+8]               ; AND(And_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 44 24 08
0021h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0025h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
002ah vmovsd qword ptr [rcx],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 01
002eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0031h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[54]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x23,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0xC5,0xFB,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte avgz(byte lhs, byte rhs)
; location: [7FFDDDBCDD20h, 7FFDDDBCDD38h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000dh and ecx,edx                   ; AND(And_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 23 ca
000fh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0011h sar eax,1                     ; SAR(Sar_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 f8
0013h add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgzBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x8B,0xC8,0x23,0xCA,0x33,0xC2,0xD1,0xF8,0x03,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort avgz(ushort lhs, ushort rhs)
; location: [7FFDDDBCDD50h, 7FFDDDBCDD68h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000dh and ecx,edx                   ; AND(And_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 23 ca
000fh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0011h sar eax,1                     ; SAR(Sar_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 f8
0013h add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgzBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x8B,0xC8,0x23,0xCA,0x33,0xC2,0xD1,0xF8,0x03,0xC1,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint avgz(uint lhs, uint rhs)
; location: [7FFDDDBCDD80h, 7FFDDDBCDD8Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
000bh shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgzBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0x33,0xD1,0xD1,0xEA,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong avgz(ulong lhs, ulong rhs)
; location: [7FFDDDBCDDA0h, 7FFDDDBCDDB4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000eh shr rdx,1                     ; SHR(Shr_rm64_1) [RDX,1h:imm8]                        encoding(3 bytes) = 48 d1 ea
0011h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgzBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0x48,0x33,0xD1,0x48,0xD1,0xEA,0x48,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte avgz(ref byte lhs, in byte rhs)
; location: [7FFDDDBCDDD0h, 7FFDDDBCDDEDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h movzx edx,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RDX:br,DS:sr)]      encoding(3 bytes) = 0f b6 12
000bh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000eh and r8d,edx                   ; AND(And_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 23 c2
0011h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0013h sar eax,1                     ; SAR(Sar_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 f8
0015h add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
0018h mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
001ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgzBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x0F,0xB6,0x12,0x44,0x8B,0xC0,0x44,0x23,0xC2,0x33,0xC2,0xD1,0xF8,0x41,0x03,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort avgz(ref ushort lhs, in ushort rhs)
; location: [7FFDDDBCDE00h, 7FFDDDBCDE1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h movzx edx,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EDX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 12
000bh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000eh and r8d,edx                   ; AND(And_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 23 c2
0011h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0013h sar eax,1                     ; SAR(Sar_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 f8
0015h add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
0018h mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgzBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x0F,0xB7,0x12,0x44,0x8B,0xC0,0x44,0x23,0xC2,0x33,0xC2,0xD1,0xF8,0x41,0x03,0xC0,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint avgz(ref uint lhs, in uint rhs)
; location: [7FFDDDBCDE30h, 7FFDDDBCDE4Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch and r8d,edx                   ; AND(And_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 23 c2
000fh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0011h shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
0013h add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
0016h mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgzBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8B,0x12,0x44,0x8B,0xC0,0x44,0x23,0xC2,0x33,0xC2,0xD1,0xE8,0x41,0x03,0xC0,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong avgz(ref ulong lhs, in ulong rhs)
; location: [7FFDDDBCDE60h, 7FFDDDBCDE80h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
000bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
000eh and r8,rdx                    ; AND(And_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 23 c2
0011h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0014h shr rax,1                     ; SHR(Shr_rm64_1) [RAX,1h:imm8]                        encoding(3 bytes) = 48 d1 e8
0017h add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
001ah mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgzBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8B,0x12,0x4C,0x8B,0xC0,0x4C,0x23,0xC2,0x48,0x33,0xC2,0x48,0xD1,0xE8,0x49,0x03,0xC0,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> avgz(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
; location: [7FFDDDBCDEA0h, 7FFDDDBCDFABh]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push r13                      ; PUSH(Push_r64) [R13]                                 encoding(2 bytes) = 41 55
0006h push r12                      ; PUSH(Push_r64) [R12]                                 encoding(2 bytes) = 41 54
0008h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0009h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
000ah push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
000bh push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
000ch sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0010h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0013h mov rdi,[r8]                  ; MOV(Mov_r64_rm64) [RDI,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 38
0016h mov ebx,[r8+8]                ; MOV(Mov_r32_rm32) [EBX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 41 8b 58 08
001ah mov rbp,[rdx]                 ; MOV(Mov_r64_rm64) [RBP,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 2a
001dh mov r14d,[rdx+8]              ; MOV(Mov_r32_rm32) [R14D,mem(32u,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8b 72 08
0021h mov r15d,70h                  ; MOV(Mov_r32_imm32) [R15D,70h:imm32]                  encoding(6 bytes) = 41 bf 70 00 00 00
0027h mov r12d,1                    ; MOV(Mov_r32_imm32) [R12D,1h:imm32]                   encoding(6 bytes) = 41 bc 01 00 00 00
002dh mov r13d,r14d                 ; MOV(Mov_r32_rm32) [R13D,R14D]                        encoding(3 bytes) = 45 8b ee
0030h mov eax,ebx                   ; MOV(Mov_r32_rm32) [EAX,EBX]                          encoding(2 bytes) = 8b c3
0032h cmp r14d,ebx                  ; CMP(Cmp_r32_rm32) [R14D,EBX]                         encoding(3 bytes) = 44 3b f3
0035h jne short 00aah               ; JNE(Jne_rel8_64) [AAh:jmp64]                         encoding(2 bytes) = 75 73
0037h movsxd rdx,r14d               ; MOVSXD(Movsxd_r64_rm32) [RDX,R14D]                   encoding(3 bytes) = 49 63 d6
003ah mov rcx,7FFDDD5CEA10h         ; MOV(Mov_r64_imm64) [RCX,7ffddd5cea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 5c dd fd 7f 00 00
0044h call 7FFE3D0F45E0h            ; CALL(Call_rel32_64) [5F526740h:jmp64]                encoding(5 bytes) = e8 f7 66 52 5f
0049h lea rcx,[rax+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 48 10
004dh mov eax,[rax+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 08
0050h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0052h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0054h jle short 0090h               ; JLE(Jle_rel8_64) [90h:jmp64]                         encoding(2 bytes) = 7e 3a
0056h movsxd r8,edx                 ; MOVSXD(Movsxd_r64_rm32) [R8,EDX]                     encoding(3 bytes) = 4c 63 c2
0059h lea r9,[rcx+r8]               ; LEA(Lea_r64_m) [R9,mem(Unknown,RCX:br,DS:sr)]        encoding(4 bytes) = 4e 8d 0c 01
005dh cmp edx,r14d                  ; CMP(Cmp_r32_rm32) [EDX,R14D]                         encoding(3 bytes) = 41 3b d6
0060h jae near ptr 0106h            ; JAE(Jae_rel32_64) [106h:jmp64]                       encoding(6 bytes) = 0f 83 a0 00 00 00
0066h movzx r10d,byte ptr [r8+rbp]  ; MOVZX(Movzx_r32_rm8) [R10D,mem(8u,R8:br,DS:sr)]      encoding(5 bytes) = 45 0f b6 14 28
006bh cmp edx,ebx                   ; CMP(Cmp_r32_rm32) [EDX,EBX]                          encoding(2 bytes) = 3b d3
006dh jae near ptr 0106h            ; JAE(Jae_rel32_64) [106h:jmp64]                       encoding(6 bytes) = 0f 83 93 00 00 00
0073h movzx r8d,byte ptr [rdi+r8]   ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RDI:br,DS:sr)]      encoding(5 bytes) = 46 0f b6 04 07
0078h mov r11d,r10d                 ; MOV(Mov_r32_rm32) [R11D,R10D]                        encoding(3 bytes) = 45 8b da
007bh and r11d,r8d                  ; AND(And_r32_rm32) [R11D,R8D]                         encoding(3 bytes) = 45 23 d8
007eh xor r8d,r10d                  ; XOR(Xor_r32_rm32) [R8D,R10D]                         encoding(3 bytes) = 45 33 c2
0081h sar r8d,1                     ; SAR(Sar_rm32_1) [R8D,1h:imm8]                        encoding(3 bytes) = 41 d1 f8
0084h add r8d,r11d                  ; ADD(Add_r32_rm32) [R8D,R11D]                         encoding(3 bytes) = 45 03 c3
0087h mov [r9],r8b                  ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),R8L]            encoding(3 bytes) = 45 88 01
008ah inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
008ch cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
008eh jl short 0056h                ; JL(Jl_rel8_64) [56h:jmp64]                           encoding(2 bytes) = 7c c6
0090h mov [rsi],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RCX]        encoding(3 bytes) = 48 89 0e
0093h mov [rsi+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(3 bytes) = 89 46 08
0096h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0099h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
009dh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
009eh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
009fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00a0h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00a1h pop r12                       ; POP(Pop_r64) [R12]                                   encoding(2 bytes) = 41 5c
00a3h pop r13                       ; POP(Pop_r64) [R13]                                   encoding(2 bytes) = 41 5d
00a5h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00a7h pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
00a9h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00aah mov esi,eax                   ; MOV(Mov_r32_rm32) [ESI,EAX]                          encoding(2 bytes) = 8b f0
00ach mov ecx,0AC3h                 ; MOV(Mov_r32_imm32) [ECX,ac3h:imm32]                  encoding(5 bytes) = b9 c3 0a 00 00
00b1h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
00bbh call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F651840h:jmp64]                encoding(5 bytes) = e8 80 17 65 5f
00c0h mov rdi,rax                   ; MOV(Mov_r64_rm64) [RDI,RAX]                          encoding(3 bytes) = 48 8b f8
00c3h mov ecx,0ACDh                 ; MOV(Mov_r32_imm32) [ECX,acdh:imm32]                  encoding(5 bytes) = b9 cd 0a 00 00
00c8h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
00d2h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F651840h:jmp64]                encoding(5 bytes) = e8 69 17 65 5f
00d7h mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
00dah lea r8,[rsp+30h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 30
00dfh mov [r8],r12b                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R12L]           encoding(3 bytes) = 45 88 20
00e2h mov [r8+4],r15d               ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),R15D]        encoding(4 bytes) = 45 89 78 04
00e6h mov r8,rdi                    ; MOV(Mov_r64_rm64) [R8,RDI]                           encoding(3 bytes) = 4c 8b c7
00e9h mov ecx,r13d                  ; MOV(Mov_r32_rm32) [ECX,R13D]                         encoding(3 bytes) = 41 8b cd
00ech mov edx,esi                   ; MOV(Mov_r32_rm32) [EDX,ESI]                          encoding(2 bytes) = 8b d6
00eeh mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
00f3h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00f8h call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD27A48h:jmp64]        encoding(5 bytes) = e8 4b 79 d2 ff
00fdh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0100h call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DC650h:jmp64]                encoding(5 bytes) = e8 4b c5 4d 5f
0105h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0106h call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F651060h:jmp64]                encoding(5 bytes) = e8 55 0f 65 5f
010bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgzBytes => new byte[268]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x38,0x48,0x8B,0xF1,0x49,0x8B,0x38,0x41,0x8B,0x58,0x08,0x48,0x8B,0x2A,0x44,0x8B,0x72,0x08,0x41,0xBF,0x70,0x00,0x00,0x00,0x41,0xBC,0x01,0x00,0x00,0x00,0x45,0x8B,0xEE,0x8B,0xC3,0x44,0x3B,0xF3,0x75,0x73,0x49,0x63,0xD6,0x48,0xB9,0x10,0xEA,0x5C,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0xF7,0x66,0x52,0x5F,0x48,0x8D,0x48,0x10,0x8B,0x40,0x08,0x33,0xD2,0x85,0xC0,0x7E,0x3A,0x4C,0x63,0xC2,0x4E,0x8D,0x0C,0x01,0x41,0x3B,0xD6,0x0F,0x83,0xA0,0x00,0x00,0x00,0x45,0x0F,0xB6,0x14,0x28,0x3B,0xD3,0x0F,0x83,0x93,0x00,0x00,0x00,0x46,0x0F,0xB6,0x04,0x07,0x45,0x8B,0xDA,0x45,0x23,0xD8,0x45,0x33,0xC2,0x41,0xD1,0xF8,0x45,0x03,0xC3,0x45,0x88,0x01,0xFF,0xC2,0x3B,0xD0,0x7C,0xC6,0x48,0x89,0x0E,0x89,0x46,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x38,0x5B,0x5D,0x5E,0x5F,0x41,0x5C,0x41,0x5D,0x41,0x5E,0x41,0x5F,0xC3,0x8B,0xF0,0xB9,0xC3,0x0A,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x80,0x17,0x65,0x5F,0x48,0x8B,0xF8,0xB9,0xCD,0x0A,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x69,0x17,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x30,0x45,0x88,0x20,0x45,0x89,0x78,0x04,0x4C,0x8B,0xC7,0x41,0x8B,0xCD,0x8B,0xD6,0x48,0x8B,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x20,0xE8,0x4B,0x79,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0x4B,0xC5,0x4D,0x5F,0xCC,0xE8,0x55,0x0F,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> avgi(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
; location: [7FFDDDBCDFD0h, 7FFDDDBCE0DBh]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push r13                      ; PUSH(Push_r64) [R13]                                 encoding(2 bytes) = 41 55
0006h push r12                      ; PUSH(Push_r64) [R12]                                 encoding(2 bytes) = 41 54
0008h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0009h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
000ah push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
000bh push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
000ch sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0010h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0013h mov rdi,[r8]                  ; MOV(Mov_r64_rm64) [RDI,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 38
0016h mov ebx,[r8+8]                ; MOV(Mov_r32_rm32) [EBX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 41 8b 58 08
001ah mov rbp,[rdx]                 ; MOV(Mov_r64_rm64) [RBP,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 2a
001dh mov r14d,[rdx+8]              ; MOV(Mov_r32_rm32) [R14D,mem(32u,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8b 72 08
0021h mov r15d,78h                  ; MOV(Mov_r32_imm32) [R15D,78h:imm32]                  encoding(6 bytes) = 41 bf 78 00 00 00
0027h mov r12d,1                    ; MOV(Mov_r32_imm32) [R12D,1h:imm32]                   encoding(6 bytes) = 41 bc 01 00 00 00
002dh mov r13d,r14d                 ; MOV(Mov_r32_rm32) [R13D,R14D]                        encoding(3 bytes) = 45 8b ee
0030h mov eax,ebx                   ; MOV(Mov_r32_rm32) [EAX,EBX]                          encoding(2 bytes) = 8b c3
0032h cmp r14d,ebx                  ; CMP(Cmp_r32_rm32) [R14D,EBX]                         encoding(3 bytes) = 44 3b f3
0035h jne short 00aah               ; JNE(Jne_rel8_64) [AAh:jmp64]                         encoding(2 bytes) = 75 73
0037h movsxd rdx,r14d               ; MOVSXD(Movsxd_r64_rm32) [RDX,R14D]                   encoding(3 bytes) = 49 63 d6
003ah mov rcx,7FFDDD5CEA10h         ; MOV(Mov_r64_imm64) [RCX,7ffddd5cea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 5c dd fd 7f 00 00
0044h call 7FFE3D0F45E0h            ; CALL(Call_rel32_64) [5F526610h:jmp64]                encoding(5 bytes) = e8 c7 65 52 5f
0049h lea rcx,[rax+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 48 10
004dh mov eax,[rax+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 08
0050h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0052h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0054h jle short 0090h               ; JLE(Jle_rel8_64) [90h:jmp64]                         encoding(2 bytes) = 7e 3a
0056h movsxd r8,edx                 ; MOVSXD(Movsxd_r64_rm32) [R8,EDX]                     encoding(3 bytes) = 4c 63 c2
0059h lea r9,[rcx+r8]               ; LEA(Lea_r64_m) [R9,mem(Unknown,RCX:br,DS:sr)]        encoding(4 bytes) = 4e 8d 0c 01
005dh cmp edx,r14d                  ; CMP(Cmp_r32_rm32) [EDX,R14D]                         encoding(3 bytes) = 41 3b d6
0060h jae near ptr 0106h            ; JAE(Jae_rel32_64) [106h:jmp64]                       encoding(6 bytes) = 0f 83 a0 00 00 00
0066h movzx r10d,byte ptr [r8+rbp]  ; MOVZX(Movzx_r32_rm8) [R10D,mem(8u,R8:br,DS:sr)]      encoding(5 bytes) = 45 0f b6 14 28
006bh cmp edx,ebx                   ; CMP(Cmp_r32_rm32) [EDX,EBX]                          encoding(2 bytes) = 3b d3
006dh jae near ptr 0106h            ; JAE(Jae_rel32_64) [106h:jmp64]                       encoding(6 bytes) = 0f 83 93 00 00 00
0073h movzx r8d,byte ptr [rdi+r8]   ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RDI:br,DS:sr)]      encoding(5 bytes) = 46 0f b6 04 07
0078h mov r11d,r10d                 ; MOV(Mov_r32_rm32) [R11D,R10D]                        encoding(3 bytes) = 45 8b da
007bh or r11d,r8d                   ; OR(Or_r32_rm32) [R11D,R8D]                           encoding(3 bytes) = 45 0b d8
007eh xor r8d,r10d                  ; XOR(Xor_r32_rm32) [R8D,R10D]                         encoding(3 bytes) = 45 33 c2
0081h sar r8d,1                     ; SAR(Sar_rm32_1) [R8D,1h:imm8]                        encoding(3 bytes) = 41 d1 f8
0084h sub r11d,r8d                  ; SUB(Sub_r32_rm32) [R11D,R8D]                         encoding(3 bytes) = 45 2b d8
0087h mov [r9],r11b                 ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),R11L]           encoding(3 bytes) = 45 88 19
008ah inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
008ch cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
008eh jl short 0056h                ; JL(Jl_rel8_64) [56h:jmp64]                           encoding(2 bytes) = 7c c6
0090h mov [rsi],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RCX]        encoding(3 bytes) = 48 89 0e
0093h mov [rsi+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(3 bytes) = 89 46 08
0096h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0099h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
009dh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
009eh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
009fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00a0h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00a1h pop r12                       ; POP(Pop_r64) [R12]                                   encoding(2 bytes) = 41 5c
00a3h pop r13                       ; POP(Pop_r64) [R13]                                   encoding(2 bytes) = 41 5d
00a5h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00a7h pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
00a9h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00aah mov esi,eax                   ; MOV(Mov_r32_rm32) [ESI,EAX]                          encoding(2 bytes) = 8b f0
00ach mov ecx,0B43h                 ; MOV(Mov_r32_imm32) [ECX,b43h:imm32]                  encoding(5 bytes) = b9 43 0b 00 00
00b1h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
00bbh call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F651710h:jmp64]                encoding(5 bytes) = e8 50 16 65 5f
00c0h mov rdi,rax                   ; MOV(Mov_r64_rm64) [RDI,RAX]                          encoding(3 bytes) = 48 8b f8
00c3h mov ecx,0ACDh                 ; MOV(Mov_r32_imm32) [ECX,acdh:imm32]                  encoding(5 bytes) = b9 cd 0a 00 00
00c8h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
00d2h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F651710h:jmp64]                encoding(5 bytes) = e8 39 16 65 5f
00d7h mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
00dah lea r8,[rsp+30h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 30
00dfh mov [r8],r12b                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R12L]           encoding(3 bytes) = 45 88 20
00e2h mov [r8+4],r15d               ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),R15D]        encoding(4 bytes) = 45 89 78 04
00e6h mov r8,rdi                    ; MOV(Mov_r64_rm64) [R8,RDI]                           encoding(3 bytes) = 4c 8b c7
00e9h mov ecx,r13d                  ; MOV(Mov_r32_rm32) [ECX,R13D]                         encoding(3 bytes) = 41 8b cd
00ech mov edx,esi                   ; MOV(Mov_r32_rm32) [EDX,ESI]                          encoding(2 bytes) = 8b d6
00eeh mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
00f3h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00f8h call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD27918h:jmp64]        encoding(5 bytes) = e8 1b 78 d2 ff
00fdh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0100h call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DC520h:jmp64]                encoding(5 bytes) = e8 1b c4 4d 5f
0105h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0106h call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F650F30h:jmp64]                encoding(5 bytes) = e8 25 0e 65 5f
010bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgiBytes => new byte[268]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x38,0x48,0x8B,0xF1,0x49,0x8B,0x38,0x41,0x8B,0x58,0x08,0x48,0x8B,0x2A,0x44,0x8B,0x72,0x08,0x41,0xBF,0x78,0x00,0x00,0x00,0x41,0xBC,0x01,0x00,0x00,0x00,0x45,0x8B,0xEE,0x8B,0xC3,0x44,0x3B,0xF3,0x75,0x73,0x49,0x63,0xD6,0x48,0xB9,0x10,0xEA,0x5C,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0xC7,0x65,0x52,0x5F,0x48,0x8D,0x48,0x10,0x8B,0x40,0x08,0x33,0xD2,0x85,0xC0,0x7E,0x3A,0x4C,0x63,0xC2,0x4E,0x8D,0x0C,0x01,0x41,0x3B,0xD6,0x0F,0x83,0xA0,0x00,0x00,0x00,0x45,0x0F,0xB6,0x14,0x28,0x3B,0xD3,0x0F,0x83,0x93,0x00,0x00,0x00,0x46,0x0F,0xB6,0x04,0x07,0x45,0x8B,0xDA,0x45,0x0B,0xD8,0x45,0x33,0xC2,0x41,0xD1,0xF8,0x45,0x2B,0xD8,0x45,0x88,0x19,0xFF,0xC2,0x3B,0xD0,0x7C,0xC6,0x48,0x89,0x0E,0x89,0x46,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x38,0x5B,0x5D,0x5E,0x5F,0x41,0x5C,0x41,0x5D,0x41,0x5E,0x41,0x5F,0xC3,0x8B,0xF0,0xB9,0x43,0x0B,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x50,0x16,0x65,0x5F,0x48,0x8B,0xF8,0xB9,0xCD,0x0A,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x39,0x16,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x30,0x45,0x88,0x20,0x45,0x89,0x78,0x04,0x4C,0x8B,0xC7,0x41,0x8B,0xCD,0x8B,0xD6,0x48,0x8B,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x20,0xE8,0x1B,0x78,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0x1B,0xC4,0x4D,0x5F,0xCC,0xE8,0x25,0x0E,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<ushort> avgi(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
; location: [7FFDDDBCE100h, 7FFDDDBCE20Dh]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push r13                      ; PUSH(Push_r64) [R13]                                 encoding(2 bytes) = 41 55
0006h push r12                      ; PUSH(Push_r64) [R12]                                 encoding(2 bytes) = 41 54
0008h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0009h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
000ah push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
000bh push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
000ch sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0010h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0013h mov rdi,[r8]                  ; MOV(Mov_r64_rm64) [RDI,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 38
0016h mov ebx,[r8+8]                ; MOV(Mov_r32_rm32) [EBX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 41 8b 58 08
001ah mov rbp,[rdx]                 ; MOV(Mov_r64_rm64) [RBP,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 2a
001dh mov r14d,[rdx+8]              ; MOV(Mov_r32_rm32) [R14D,mem(32u,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8b 72 08
0021h mov r15d,80h                  ; MOV(Mov_r32_imm32) [R15D,80h:imm32]                  encoding(6 bytes) = 41 bf 80 00 00 00
0027h mov r12d,1                    ; MOV(Mov_r32_imm32) [R12D,1h:imm32]                   encoding(6 bytes) = 41 bc 01 00 00 00
002dh mov r13d,r14d                 ; MOV(Mov_r32_rm32) [R13D,R14D]                        encoding(3 bytes) = 45 8b ee
0030h mov eax,ebx                   ; MOV(Mov_r32_rm32) [EAX,EBX]                          encoding(2 bytes) = 8b c3
0032h cmp r14d,ebx                  ; CMP(Cmp_r32_rm32) [R14D,EBX]                         encoding(3 bytes) = 44 3b f3
0035h jne short 00ach               ; JNE(Jne_rel8_64) [ACh:jmp64]                         encoding(2 bytes) = 75 75
0037h movsxd rdx,r14d               ; MOVSXD(Movsxd_r64_rm32) [RDX,R14D]                   encoding(3 bytes) = 49 63 d6
003ah mov rcx,7FFDDDA72BD0h         ; MOV(Mov_r64_imm64) [RCX,7ffddda72bd0h:imm64]         encoding(10 bytes) = 48 b9 d0 2b a7 dd fd 7f 00 00
0044h call 7FFE3D0F45E0h            ; CALL(Call_rel32_64) [5F5264E0h:jmp64]                encoding(5 bytes) = e8 97 64 52 5f
0049h lea rcx,[rax+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 48 10
004dh mov eax,[rax+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 08
0050h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0052h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0054h jle short 0092h               ; JLE(Jle_rel8_64) [92h:jmp64]                         encoding(2 bytes) = 7e 3c
0056h movsxd r8,edx                 ; MOVSXD(Movsxd_r64_rm32) [R8,EDX]                     encoding(3 bytes) = 4c 63 c2
0059h lea r9,[rcx+r8*2]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RCX:br,DS:sr)]        encoding(4 bytes) = 4e 8d 0c 41
005dh cmp edx,r14d                  ; CMP(Cmp_r32_rm32) [EDX,R14D]                         encoding(3 bytes) = 41 3b d6
0060h jae near ptr 0108h            ; JAE(Jae_rel32_64) [108h:jmp64]                       encoding(6 bytes) = 0f 83 a2 00 00 00
0066h movzx r10d,word ptr [rbp+r8*2]; MOVZX(Movzx_r32_rm16) [R10D,mem(16u,RBP:br,SS:sr)]   encoding(6 bytes) = 46 0f b7 54 45 00
006ch cmp edx,ebx                   ; CMP(Cmp_r32_rm32) [EDX,EBX]                          encoding(2 bytes) = 3b d3
006eh jae near ptr 0108h            ; JAE(Jae_rel32_64) [108h:jmp64]                       encoding(6 bytes) = 0f 83 94 00 00 00
0074h movzx r8d,word ptr [rdi+r8*2] ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RDI:br,DS:sr)]    encoding(5 bytes) = 46 0f b7 04 47
0079h mov r11d,r10d                 ; MOV(Mov_r32_rm32) [R11D,R10D]                        encoding(3 bytes) = 45 8b da
007ch or r11d,r8d                   ; OR(Or_r32_rm32) [R11D,R8D]                           encoding(3 bytes) = 45 0b d8
007fh xor r8d,r10d                  ; XOR(Xor_r32_rm32) [R8D,R10D]                         encoding(3 bytes) = 45 33 c2
0082h sar r8d,1                     ; SAR(Sar_rm32_1) [R8D,1h:imm8]                        encoding(3 bytes) = 41 d1 f8
0085h sub r11d,r8d                  ; SUB(Sub_r32_rm32) [R11D,R8D]                         encoding(3 bytes) = 45 2b d8
0088h mov [r9],r11w                 ; MOV(Mov_rm16_r16) [mem(16u,R9:br,DS:sr),R11W]        encoding(4 bytes) = 66 45 89 19
008ch inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
008eh cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
0090h jl short 0056h                ; JL(Jl_rel8_64) [56h:jmp64]                           encoding(2 bytes) = 7c c4
0092h mov [rsi],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RCX]        encoding(3 bytes) = 48 89 0e
0095h mov [rsi+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(3 bytes) = 89 46 08
0098h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
009bh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
009fh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00a0h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00a1h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00a2h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00a3h pop r12                       ; POP(Pop_r64) [R12]                                   encoding(2 bytes) = 41 5c
00a5h pop r13                       ; POP(Pop_r64) [R13]                                   encoding(2 bytes) = 41 5d
00a7h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00a9h pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
00abh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00ach mov esi,eax                   ; MOV(Mov_r32_rm32) [ESI,EAX]                          encoding(2 bytes) = 8b f0
00aeh mov ecx,0B43h                 ; MOV(Mov_r32_imm32) [ECX,b43h:imm32]                  encoding(5 bytes) = b9 43 0b 00 00
00b3h mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
00bdh call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6515E0h:jmp64]                encoding(5 bytes) = e8 1e 15 65 5f
00c2h mov rdi,rax                   ; MOV(Mov_r64_rm64) [RDI,RAX]                          encoding(3 bytes) = 48 8b f8
00c5h mov ecx,0ACDh                 ; MOV(Mov_r32_imm32) [ECX,acdh:imm32]                  encoding(5 bytes) = b9 cd 0a 00 00
00cah mov rdx,7FFDDD72C6C8h         ; MOV(Mov_r64_imm64) [RDX,7ffddd72c6c8h:imm64]         encoding(10 bytes) = 48 ba c8 c6 72 dd fd 7f 00 00
00d4h call 7FFE3D21F6E0h            ; CALL(Call_rel32_64) [5F6515E0h:jmp64]                encoding(5 bytes) = e8 07 15 65 5f
00d9h mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
00dch lea r8,[rsp+30h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 30
00e1h mov [r8],r12b                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R12L]           encoding(3 bytes) = 45 88 20
00e4h mov [r8+4],r15d               ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),R15D]        encoding(4 bytes) = 45 89 78 04
00e8h mov r8,rdi                    ; MOV(Mov_r64_rm64) [R8,RDI]                           encoding(3 bytes) = 4c 8b c7
00ebh mov ecx,r13d                  ; MOV(Mov_r32_rm32) [ECX,R13D]                         encoding(3 bytes) = 41 8b cd
00eeh mov edx,esi                   ; MOV(Mov_r32_rm32) [EDX,ESI]                          encoding(2 bytes) = 8b d6
00f0h mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
00f5h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
00fah call 7FFDDD8F58E8h            ; CALL(Call_rel32_64) [FFFFFFFFFFD277E8h:jmp64]        encoding(5 bytes) = e8 e9 76 d2 ff
00ffh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0102h call 7FFE3D0AA4F0h            ; CALL(Call_rel32_64) [5F4DC3F0h:jmp64]                encoding(5 bytes) = e8 e9 c2 4d 5f
0107h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0108h call 7FFE3D21EF00h            ; CALL(Call_rel32_64) [5F650E00h:jmp64]                encoding(5 bytes) = e8 f3 0c 65 5f
010dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgiBytes => new byte[270]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x38,0x48,0x8B,0xF1,0x49,0x8B,0x38,0x41,0x8B,0x58,0x08,0x48,0x8B,0x2A,0x44,0x8B,0x72,0x08,0x41,0xBF,0x80,0x00,0x00,0x00,0x41,0xBC,0x01,0x00,0x00,0x00,0x45,0x8B,0xEE,0x8B,0xC3,0x44,0x3B,0xF3,0x75,0x75,0x49,0x63,0xD6,0x48,0xB9,0xD0,0x2B,0xA7,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x97,0x64,0x52,0x5F,0x48,0x8D,0x48,0x10,0x8B,0x40,0x08,0x33,0xD2,0x85,0xC0,0x7E,0x3C,0x4C,0x63,0xC2,0x4E,0x8D,0x0C,0x41,0x41,0x3B,0xD6,0x0F,0x83,0xA2,0x00,0x00,0x00,0x46,0x0F,0xB7,0x54,0x45,0x00,0x3B,0xD3,0x0F,0x83,0x94,0x00,0x00,0x00,0x46,0x0F,0xB7,0x04,0x47,0x45,0x8B,0xDA,0x45,0x0B,0xD8,0x45,0x33,0xC2,0x41,0xD1,0xF8,0x45,0x2B,0xD8,0x66,0x45,0x89,0x19,0xFF,0xC2,0x3B,0xD0,0x7C,0xC4,0x48,0x89,0x0E,0x89,0x46,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x38,0x5B,0x5D,0x5E,0x5F,0x41,0x5C,0x41,0x5D,0x41,0x5E,0x41,0x5F,0xC3,0x8B,0xF0,0xB9,0x43,0x0B,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x1E,0x15,0x65,0x5F,0x48,0x8B,0xF8,0xB9,0xCD,0x0A,0x00,0x00,0x48,0xBA,0xC8,0xC6,0x72,0xDD,0xFD,0x7F,0x00,0x00,0xE8,0x07,0x15,0x65,0x5F,0x4C,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x30,0x45,0x88,0x20,0x45,0x89,0x78,0x04,0x4C,0x8B,0xC7,0x41,0x8B,0xCD,0x8B,0xD6,0x48,0x8B,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x20,0xE8,0xE9,0x76,0xD2,0xFF,0x48,0x8B,0xC8,0xE8,0xE9,0xC2,0x4D,0x5F,0xCC,0xE8,0xF3,0x0C,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong avgz(ReadOnlySpan<ulong> src)
; location: [7FFDDDBCE240h, 7FFDDDBCE298h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0003h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0007h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 11
000ah mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000dh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
000fh ja short 0018h                ; JA(Ja_rel8_64) [18h:jmp64]                           encoding(2 bytes) = 77 07
0011h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0013h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0018h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
001bh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
001fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0024h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0027h jle short 0050h               ; JLE(Jle_rel8_64) [50h:jmp64]                         encoding(2 bytes) = 7e 27
0029h movsxd r8,eax                 ; MOVSXD(Movsxd_r64_rm32) [R8,EAX]                     encoding(3 bytes) = 4c 63 c0
002ch lea r8,[rdx+r8*8]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RDX:br,DS:sr)]        encoding(4 bytes) = 4e 8d 04 c2
0030h mov r9,[rsp]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(4 bytes) = 4c 8b 0c 24
0034h mov r8,[r8]                   ; MOV(Mov_r64_rm64) [R8,mem(64u,R8:br,DS:sr)]          encoding(3 bytes) = 4d 8b 00
0037h mov r10,r9                    ; MOV(Mov_r64_rm64) [R10,R9]                           encoding(3 bytes) = 4d 8b d1
003ah and r10,r8                    ; AND(And_r64_rm64) [R10,R8]                           encoding(3 bytes) = 4d 23 d0
003dh xor r8,r9                     ; XOR(Xor_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 33 c1
0040h shr r8,1                      ; SHR(Shr_rm64_1) [R8,1h:imm8]                         encoding(3 bytes) = 49 d1 e8
0043h add r8,r10                    ; ADD(Add_r64_rm64) [R8,R10]                           encoding(3 bytes) = 4d 03 c2
0046h mov [rsp],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R8]         encoding(4 bytes) = 4c 89 04 24
004ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
004ch cmp eax,ecx                   ; CMP(Cmp_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 3b c1
004eh jl short 0029h                ; JL(Jl_rel8_64) [29h:jmp64]                           encoding(2 bytes) = 7c d9
0050h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
0054h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0058h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgzBytes => new byte[89]{0x50,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x8B,0x11,0x8B,0x49,0x08,0x85,0xC9,0x77,0x07,0x33,0xC0,0x48,0x83,0xC4,0x08,0xC3,0x48,0x8B,0x02,0x48,0x89,0x04,0x24,0xB8,0x01,0x00,0x00,0x00,0x83,0xF9,0x01,0x7E,0x27,0x4C,0x63,0xC0,0x4E,0x8D,0x04,0xC2,0x4C,0x8B,0x0C,0x24,0x4D,0x8B,0x00,0x4D,0x8B,0xD1,0x4D,0x23,0xD0,0x4D,0x33,0xC1,0x49,0xD1,0xE8,0x4D,0x03,0xC2,0x4C,0x89,0x04,0x24,0xFF,0xC0,0x3B,0xC1,0x7C,0xD9,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte avgi(byte lhs, byte rhs)
; location: [7FFDDDBCE2B0h, 7FFDDDBCE2C8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000dh or ecx,edx                    ; OR(Or_r32_rm32) [ECX,EDX]                            encoding(2 bytes) = 0b ca
000fh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0011h sar eax,1                     ; SAR(Sar_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 f8
0013h sub ecx,eax                   ; SUB(Sub_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 2b c8
0015h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgiBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x8B,0xC8,0x0B,0xCA,0x33,0xC2,0xD1,0xF8,0x2B,0xC8,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort avgi(ushort lhs, ushort rhs)
; location: [7FFDDDBCE2E0h, 7FFDDDBCE2F8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000dh or ecx,edx                    ; OR(Or_r32_rm32) [ECX,EDX]                            encoding(2 bytes) = 0b ca
000fh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0011h sar eax,1                     ; SAR(Sar_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 f8
0013h sub ecx,eax                   ; SUB(Sub_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 2b c8
0015h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgiBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x8B,0xC8,0x0B,0xCA,0x33,0xC2,0xD1,0xF8,0x2B,0xC8,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint avgi(uint lhs, uint rhs)
; location: [7FFDDDBCE310h, 7FFDDDBCE31Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
000bh shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgiBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0x33,0xD1,0xD1,0xEA,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong avgi(ulong lhs, ulong rhs)
; location: [7FFDDDBCE330h, 7FFDDDBCE344h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000eh shr rdx,1                     ; SHR(Shr_rm64_1) [RDX,1h:imm8]                        encoding(3 bytes) = 48 d1 ea
0011h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgiBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0x48,0x33,0xD1,0x48,0xD1,0xEA,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte avg(ReadOnlySpan<sbyte> src)
; location: [7FFDDDBCE360h, 7FFDDDBCE3B0h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 002fh               ; JLE(Jle_rel8_64) [2Fh:jmp64]                         encoding(2 bytes) = 7e 1b
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h movsx r9,byte ptr [rax+r9]    ; MOVSX(Movsx_r64_rm8) [R9,mem(8i,RAX:br,DS:sr)]       encoding(5 bytes) = 4e 0f be 0c 08
001ch movsxd r9,r9d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R9D]                     encoding(3 bytes) = 4d 63 c9
001fh add rcx,r9                    ; ADD(Add_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 03 c9
0022h jo short 004bh                ; JO(Jo_rel8_64) [4Bh:jmp64]                           encoding(2 bytes) = 70 27
0024h add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0028h jo short 004bh                ; JO(Jo_rel8_64) [4Bh:jmp64]                           encoding(2 bytes) = 70 21
002ah cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
002dh jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c e5
002fh movsxd r8,edx                 ; MOVSXD(Movsxd_r64_rm32) [R8,EDX]                     encoding(3 bytes) = 4c 63 c2
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
0037h idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
003ah cmp rax,7Fh                   ; CMP(Cmp_rm64_imm8) [RAX,7fh:imm64]                   encoding(4 bytes) = 48 83 f8 7f
003eh jg short 004bh                ; JG(Jg_rel8_64) [4Bh:jmp64]                           encoding(2 bytes) = 7f 0b
0040h cmp rax,0FFFFFFFFFFFFFF80h    ; CMP(Cmp_rm64_imm8) [RAX,ffffffffffffff80h:imm64]     encoding(4 bytes) = 48 83 f8 80
0044h jl short 004bh                ; JL(Jl_rel8_64) [4Bh:jmp64]                           encoding(2 bytes) = 7c 05
0046h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004bh call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F6509F0h:jmp64]                encoding(5 bytes) = e8 a0 09 65 5f
0050h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgBytes => new byte[81]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x1B,0x4D,0x63,0xC8,0x4E,0x0F,0xBE,0x0C,0x08,0x4D,0x63,0xC9,0x49,0x03,0xC9,0x70,0x27,0x41,0x83,0xC0,0x01,0x70,0x21,0x44,0x3B,0xC2,0x7C,0xE5,0x4C,0x63,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0x48,0x83,0xF8,0x7F,0x7F,0x0B,0x48,0x83,0xF8,0x80,0x7C,0x05,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xA0,0x09,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte avg(ReadOnlySpan<byte> src)
; location: [7FFDDDBCE3D0h, 7FFDDDBCE41Dh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 002ch               ; JLE(Jle_rel8_64) [2Ch:jmp64]                         encoding(2 bytes) = 7e 18
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h movzx r9d,byte ptr [rax+r9]   ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 46 0f b6 0c 08
001ch add rcx,r9                    ; ADD(Add_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 03 c9
001fh jb short 0048h                ; JB(Jb_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 72 27
0021h add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0025h jo short 0048h                ; JO(Jo_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 70 21
0027h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
002ah jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c e8
002ch test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
002eh jl short 0048h                ; JL(Jl_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 7c 18
0030h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0033h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0036h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0038h div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
003bh cmp rax,0FFh                  ; CMP(Cmp_RAX_imm32) [RAX,ffh:imm64]                   encoding(6 bytes) = 48 3d ff 00 00 00
0041h ja short 0048h                ; JA(Ja_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 77 05
0043h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0047h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0048h call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F650980h:jmp64]                encoding(5 bytes) = e8 33 09 65 5f
004dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgBytes => new byte[78]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x18,0x4D,0x63,0xC8,0x46,0x0F,0xB6,0x0C,0x08,0x49,0x03,0xC9,0x72,0x27,0x41,0x83,0xC0,0x01,0x70,0x21,0x44,0x3B,0xC2,0x7C,0xE8,0x85,0xD2,0x7C,0x18,0x44,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x48,0x3D,0xFF,0x00,0x00,0x00,0x77,0x05,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x33,0x09,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short avg(ReadOnlySpan<short> src)
; location: [7FFDDDBCE440h, 7FFDDDBCE494h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 002fh               ; JLE(Jle_rel8_64) [2Fh:jmp64]                         encoding(2 bytes) = 7e 1b
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h movsx r9,word ptr [rax+r9*2]  ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,RAX:br,DS:sr)]     encoding(5 bytes) = 4e 0f bf 0c 48
001ch movsxd r9,r9d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R9D]                     encoding(3 bytes) = 4d 63 c9
001fh add rcx,r9                    ; ADD(Add_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 03 c9
0022h jo short 004fh                ; JO(Jo_rel8_64) [4Fh:jmp64]                           encoding(2 bytes) = 70 2b
0024h add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0028h jo short 004fh                ; JO(Jo_rel8_64) [4Fh:jmp64]                           encoding(2 bytes) = 70 25
002ah cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
002dh jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c e5
002fh movsxd r8,edx                 ; MOVSXD(Movsxd_r64_rm32) [R8,EDX]                     encoding(3 bytes) = 4c 63 c2
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
0037h idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
003ah cmp rax,7FFFh                 ; CMP(Cmp_RAX_imm32) [RAX,7fffh:imm64]                 encoding(6 bytes) = 48 3d ff 7f 00 00
0040h jg short 004fh                ; JG(Jg_rel8_64) [4Fh:jmp64]                           encoding(2 bytes) = 7f 0d
0042h cmp rax,0FFFFFFFFFFFF8000h    ; CMP(Cmp_RAX_imm32) [RAX,ffffffffffff8000h:imm64]     encoding(6 bytes) = 48 3d 00 80 ff ff
0048h jl short 004fh                ; JL(Jl_rel8_64) [4Fh:jmp64]                           encoding(2 bytes) = 7c 05
004ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004fh call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F650910h:jmp64]                encoding(5 bytes) = e8 bc 08 65 5f
0054h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgBytes => new byte[85]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x1B,0x4D,0x63,0xC8,0x4E,0x0F,0xBF,0x0C,0x48,0x4D,0x63,0xC9,0x49,0x03,0xC9,0x70,0x2B,0x41,0x83,0xC0,0x01,0x70,0x25,0x44,0x3B,0xC2,0x7C,0xE5,0x4C,0x63,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0x48,0x3D,0xFF,0x7F,0x00,0x00,0x7F,0x0D,0x48,0x3D,0x00,0x80,0xFF,0xFF,0x7C,0x05,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xBC,0x08,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort avg(ReadOnlySpan<ushort> src)
; location: [7FFDDDBCE4B0h, 7FFDDDBCE4FDh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 002ch               ; JLE(Jle_rel8_64) [2Ch:jmp64]                         encoding(2 bytes) = 7e 18
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h movzx r9d,word ptr [rax+r9*2] ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,RAX:br,DS:sr)]    encoding(5 bytes) = 46 0f b7 0c 48
001ch add rcx,r9                    ; ADD(Add_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 03 c9
001fh jb short 0048h                ; JB(Jb_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 72 27
0021h add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0025h jo short 0048h                ; JO(Jo_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 70 21
0027h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
002ah jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c e8
002ch test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
002eh jl short 0048h                ; JL(Jl_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 7c 18
0030h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0033h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0036h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0038h div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
003bh cmp rax,0FFFFh                ; CMP(Cmp_RAX_imm32) [RAX,ffffh:imm64]                 encoding(6 bytes) = 48 3d ff ff 00 00
0041h ja short 0048h                ; JA(Ja_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 77 05
0043h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0047h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0048h call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F6508A0h:jmp64]                encoding(5 bytes) = e8 53 08 65 5f
004dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgBytes => new byte[78]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x18,0x4D,0x63,0xC8,0x46,0x0F,0xB7,0x0C,0x48,0x49,0x03,0xC9,0x72,0x27,0x41,0x83,0xC0,0x01,0x70,0x21,0x44,0x3B,0xC2,0x7C,0xE8,0x85,0xD2,0x7C,0x18,0x44,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x48,0x3D,0xFF,0xFF,0x00,0x00,0x77,0x05,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x53,0x08,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int avg(ReadOnlySpan<int> src)
; location: [7FFDDDBCE520h, 7FFDDDBCE573h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 002eh               ; JLE(Jle_rel8_64) [2Eh:jmp64]                         encoding(2 bytes) = 7e 1a
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h mov r9d,[rax+r9*4]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 46 8b 0c 88
001bh movsxd r9,r9d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R9D]                     encoding(3 bytes) = 4d 63 c9
001eh add rcx,r9                    ; ADD(Add_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 03 c9
0021h jo short 004eh                ; JO(Jo_rel8_64) [4Eh:jmp64]                           encoding(2 bytes) = 70 2b
0023h add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0027h jo short 004eh                ; JO(Jo_rel8_64) [4Eh:jmp64]                           encoding(2 bytes) = 70 25
0029h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
002ch jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c e6
002eh movsxd r8,edx                 ; MOVSXD(Movsxd_r64_rm32) [R8,EDX]                     encoding(3 bytes) = 4c 63 c2
0031h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0034h cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
0036h idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0039h cmp rax,7FFFFFFFh             ; CMP(Cmp_RAX_imm32) [RAX,7fffffffh:imm64]             encoding(6 bytes) = 48 3d ff ff ff 7f
003fh jg short 004eh                ; JG(Jg_rel8_64) [4Eh:jmp64]                           encoding(2 bytes) = 7f 0d
0041h cmp rax,0FFFFFFFF80000000h    ; CMP(Cmp_RAX_imm32) [RAX,ffffffff80000000h:imm64]     encoding(6 bytes) = 48 3d 00 00 00 80
0047h jl short 004eh                ; JL(Jl_rel8_64) [4Eh:jmp64]                           encoding(2 bytes) = 7c 05
0049h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004eh call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F650830h:jmp64]                encoding(5 bytes) = e8 dd 07 65 5f
0053h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgBytes => new byte[84]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x1A,0x4D,0x63,0xC8,0x46,0x8B,0x0C,0x88,0x4D,0x63,0xC9,0x49,0x03,0xC9,0x70,0x2B,0x41,0x83,0xC0,0x01,0x70,0x25,0x44,0x3B,0xC2,0x7C,0xE6,0x4C,0x63,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0x48,0x3D,0xFF,0xFF,0xFF,0x7F,0x7F,0x0D,0x48,0x3D,0x00,0x00,0x00,0x80,0x7C,0x05,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xDD,0x07,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint avg(ReadOnlySpan<uint> src)
; location: [7FFDDDBCE590h, 7FFDDDBCE5DDh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 002bh               ; JLE(Jle_rel8_64) [2Bh:jmp64]                         encoding(2 bytes) = 7e 17
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h mov r9d,[rax+r9*4]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 46 8b 0c 88
001bh add rcx,r9                    ; ADD(Add_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 03 c9
001eh jb short 0048h                ; JB(Jb_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 72 28
0020h add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0024h jo short 0048h                ; JO(Jo_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 70 22
0026h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0029h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c e9
002bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
002dh jl short 0048h                ; JL(Jl_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 7c 19
002fh mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0037h div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
003ah mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
003dh shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0041h jne short 0048h               ; JNE(Jne_rel8_64) [48h:jmp64]                         encoding(2 bytes) = 75 05
0043h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0047h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0048h call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F6507C0h:jmp64]                encoding(5 bytes) = e8 73 07 65 5f
004dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgBytes => new byte[78]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x17,0x4D,0x63,0xC8,0x46,0x8B,0x0C,0x88,0x49,0x03,0xC9,0x72,0x28,0x41,0x83,0xC0,0x01,0x70,0x22,0x44,0x3B,0xC2,0x7C,0xE9,0x85,0xD2,0x7C,0x19,0x44,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x48,0x8B,0xD0,0x48,0xC1,0xEA,0x20,0x75,0x05,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x73,0x07,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long avg(ReadOnlySpan<long> src)
; location: [7FFDDDBCE600h, 7FFDDDBCE63Dh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 0028h               ; JLE(Jle_rel8_64) [28h:jmp64]                         encoding(2 bytes) = 7e 14
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h add rcx,[rax+r9*8]            ; ADD(Add_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(4 bytes) = 4a 03 0c c8
001bh jo short 0038h                ; JO(Jo_rel8_64) [38h:jmp64]                           encoding(2 bytes) = 70 1b
001dh add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0021h jo short 0038h                ; JO(Jo_rel8_64) [38h:jmp64]                           encoding(2 bytes) = 70 15
0023h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0026h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c ec
0028h movsxd r8,edx                 ; MOVSXD(Movsxd_r64_rm32) [R8,EDX]                     encoding(3 bytes) = 4c 63 c2
002bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002eh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
0030h idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0033h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0038h call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F650750h:jmp64]                encoding(5 bytes) = e8 13 07 65 5f
003dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgBytes => new byte[62]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x14,0x4D,0x63,0xC8,0x4A,0x03,0x0C,0xC8,0x70,0x1B,0x41,0x83,0xC0,0x01,0x70,0x15,0x44,0x3B,0xC2,0x7C,0xEC,0x4C,0x63,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x13,0x07,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong avg(ReadOnlySpan<ulong> src)
; location: [7FFDDDBCE660h, 7FFDDDBCE6A1h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h jle short 0028h               ; JLE(Jle_rel8_64) [28h:jmp64]                         encoding(2 bytes) = 7e 14
0014h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0017h add rcx,[rax+r9*8]            ; ADD(Add_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(4 bytes) = 4a 03 0c c8
001bh jb short 003ch                ; JB(Jb_rel8_64) [3Ch:jmp64]                           encoding(2 bytes) = 72 1f
001dh add r8d,1                     ; ADD(Add_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 c0 01
0021h jo short 003ch                ; JO(Jo_rel8_64) [3Ch:jmp64]                           encoding(2 bytes) = 70 19
0023h cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
0026h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c ec
0028h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
002ah jl short 003ch                ; JL(Jl_rel8_64) [3Ch:jmp64]                           encoding(2 bytes) = 7c 10
002ch mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
002fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0032h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0034h div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0037h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003ch call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F6506F0h:jmp64]                encoding(5 bytes) = e8 af 06 65 5f
0041h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgBytes => new byte[66]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x14,0x4D,0x63,0xC8,0x4A,0x03,0x0C,0xC8,0x72,0x1F,0x41,0x83,0xC0,0x01,0x70,0x19,0x44,0x3B,0xC2,0x7C,0xEC,0x85,0xD2,0x7C,0x10,0x44,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xAF,0x06,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float avg(ReadOnlySpan<float> src)
; location: [7FFDDDBCE6C0h, 7FFDDDBCE70Bh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000ah mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000dh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0011h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0013h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0015h jle short 002dh               ; JLE(Jle_rel8_64) [2Dh:jmp64]                         encoding(2 bytes) = 7e 16
0017h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
001ah vcvtss2sd xmm1,xmm1,dword ptr [rax+r8*4]; VCVTSS2SD(VEX_Vcvtss2sd_xmm_xmm_xmmm32) [XMM1,XMM1,mem(Float32,RAX:br,DS:sr)] encoding(VEX, 6 bytes) = c4 a1 72 5a 0c 80
0020h vaddsd xmm0,xmm0,xmm1         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 58 c1
0024h add ecx,1                     ; ADD(Add_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 c1 01
0027h jo short 0046h                ; JO(Jo_rel8_64) [46h:jmp64]                           encoding(2 bytes) = 70 1d
0029h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
002bh jl short 0017h                ; JL(Jl_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7c ea
002dh vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0031h vcvtsi2ss xmm1,xmm1,edx       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM1,XMM1,EDX] encoding(VEX, 4 bytes) = c5 f2 2a ca
0035h vcvtss2sd xmm1,xmm1,xmm1      ; VCVTSS2SD(VEX_Vcvtss2sd_xmm_xmm_xmmm32) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f2 5a c9
0039h vdivsd xmm0,xmm0,xmm1         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5e c1
003dh vcvtsd2ss xmm0,xmm0,xmm0      ; VCVTSD2SS(VEX_Vcvtsd2ss_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fb 5a c0
0041h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0046h call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F650690h:jmp64]                encoding(5 bytes) = e8 45 06 65 5f
004bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgBytes => new byte[76]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x8B,0x51,0x08,0xC5,0xF8,0x57,0xC0,0x33,0xC9,0x85,0xD2,0x7E,0x16,0x4C,0x63,0xC1,0xC4,0xA1,0x72,0x5A,0x0C,0x80,0xC5,0xFB,0x58,0xC1,0x83,0xC1,0x01,0x70,0x1D,0x3B,0xCA,0x7C,0xEA,0xC5,0xF0,0x57,0xC9,0xC5,0xF2,0x2A,0xCA,0xC5,0xF2,0x5A,0xC9,0xC5,0xFB,0x5E,0xC1,0xC5,0xFB,0x5A,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x45,0x06,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double avg(ReadOnlySpan<double> src)
; location: [7FFDDDBCE730h, 7FFDDDBCE76Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000ah mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000dh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0011h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0013h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0015h jle short 0029h               ; JLE(Jle_rel8_64) [29h:jmp64]                         encoding(2 bytes) = 7e 12
0017h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
001ah vaddsd xmm0,xmm0,qword ptr [rax+r8*8]; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,mem(Float64,RAX:br,DS:sr)] encoding(VEX, 6 bytes) = c4 a1 7b 58 04 c0
0020h add ecx,1                     ; ADD(Add_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 c1 01
0023h jo short 003ah                ; JO(Jo_rel8_64) [3Ah:jmp64]                           encoding(2 bytes) = 70 15
0025h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0027h jl short 0017h                ; JL(Jl_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7c ee
0029h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
002dh vcvtsi2sd xmm1,xmm1,edx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM1,XMM1,EDX] encoding(VEX, 4 bytes) = c5 f3 2a ca
0031h vdivsd xmm0,xmm0,xmm1         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5e c1
0035h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003ah call 7FFE3D21ED50h            ; CALL(Call_rel32_64) [5F650620h:jmp64]                encoding(5 bytes) = e8 e1 05 65 5f
003fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> avgBytes => new byte[64]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x8B,0x51,0x08,0xC5,0xF8,0x57,0xC0,0x33,0xC9,0x85,0xD2,0x7E,0x12,0x4C,0x63,0xC1,0xC4,0xA1,0x7B,0x58,0x04,0xC0,0x83,0xC1,0x01,0x70,0x15,0x3B,0xCA,0x7C,0xEE,0xC5,0xF0,0x57,0xC9,0xC5,0xF3,0x2A,0xCA,0xC5,0xFB,0x5E,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xE1,0x05,0x65,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between(byte x, byte a, byte b)
; location: [7FFDDDBCE790h, 7FFDDDBCE7AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c 0d
000fh movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0013h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0015h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001ch xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x7C,0x0D,0x41,0x0F,0xB6,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between(sbyte x, sbyte a, sbyte b)
; location: [7FFDDDBCE7C0h, 7FFDDDBCE7E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jl short 001eh                ; JL(Jl_rel8_64) [1Eh:jmp64]                           encoding(2 bytes) = 7c 0d
0011h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0015h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0017h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7C,0x0D,0x49,0x0F,0xBE,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between(short x, short a, short b)
; location: [7FFDDDBCE800h, 7FFDDDBCE820h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jl short 001eh                ; JL(Jl_rel8_64) [1Eh:jmp64]                           encoding(2 bytes) = 7c 0d
0011h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0015h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0017h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7C,0x0D,0x49,0x0F,0xBF,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between(ushort x, ushort a, ushort b)
; location: [7FFDDDBCE840h, 7FFDDDBCE85Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c 0d
000fh movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0013h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0015h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001ch xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x7C,0x0D,0x41,0x0F,0xB7,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between(int x, int a, int b)
; location: [7FFDDDBCE870h, 7FFDDDBCE885h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jl short 0013h                ; JL(Jl_rel8_64) [13h:jmp64]                           encoding(2 bytes) = 7c 0a
0009h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
000ch setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0013h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x0A,0x41,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between(uint x, uint a, uint b)
; location: [7FFDDDBCE8A0h, 7FFDDDBCE8B5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jb short 0013h                ; JB(Jb_rel8_64) [13h:jmp64]                           encoding(2 bytes) = 72 0a
0009h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
000ch setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0013h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x0A,0x41,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between(long x, long a, long b)
; location: [7FFDDDBCE8D0h, 7FFDDDBCE8E6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c 0a
000ah cmp rcx,r8                    ; CMP(Cmp_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 3b c8
000dh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x0A,0x49,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between(ulong x, ulong a, ulong b)
; location: [7FFDDDBCE900h, 7FFDDDBCE916h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jb short 0014h                ; JB(Jb_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 72 0a
000ah cmp rcx,r8                    ; CMP(Cmp_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 3b c8
000dh setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x0A,0x49,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte dec(sbyte src)
; location: [7FFDDDBCE930h, 7FFDDDBCE93Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte dec(byte src)
; location: [7FFDDDBCE950h, 7FFDDDBCE95Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short dec(short src)
; location: [7FFDDDBCE970h, 7FFDDDBCE97Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort dec(ushort src)
; location: [7FFDDDBCE990h, 7FFDDDBCE99Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int dec(int src)
; location: [7FFDDDBCE9B0h, 7FFDDDBCE9B8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dec(uint src)
; location: [7FFDDDBCE9D0h, 7FFDDDBCE9D8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long dec(long src)
; location: [7FFDDDBCE9F0h, 7FFDDDBCE9F9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dec(ulong src)
; location: [7FFDDDBCEA10h, 7FFDDDBCEA19h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte dec(ref sbyte src)
; location: [7FFDDDBCEA30h, 7FFDDDBCEA3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec byte ptr [rcx]            ; DEC(Dec_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = fe 09
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFE,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte dec(ref byte src)
; location: [7FFDDDBCEA50h, 7FFDDDBCEA5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec byte ptr [rcx]            ; DEC(Dec_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = fe 09
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFE,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short dec(ref short src)
; location: [7FFDDDBCEA70h, 7FFDDDBCEA7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec word ptr [rcx]            ; DEC(Dec_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 ff 09
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort dec(ref ushort src)
; location: [7FFDDDBCEA90h, 7FFDDDBCEA9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec word ptr [rcx]            ; DEC(Dec_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 ff 09
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int dec(ref int src)
; location: [7FFDDDBCEAB0h, 7FFDDDBCEABAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec dword ptr [rcx]           ; DEC(Dec_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = ff 09
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint dec(ref uint src)
; location: [7FFDDDBCEAD0h, 7FFDDDBCEADAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec dword ptr [rcx]           ; DEC(Dec_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = ff 09
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long dec(ref long src)
; location: [7FFDDDBCEAF0h, 7FFDDDBCEAFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec qword ptr [rcx]           ; DEC(Dec_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 ff 09
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong dec(ref ulong src)
; location: [7FFDDDBCEB10h, 7FFDDDBCEB1Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec qword ptr [rcx]           ; DEC(Dec_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 ff 09
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte div(sbyte lhs, sbyte rhs)
; location: [7FFDDDBCEB30h, 7FFDDDBCEB44h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]                        encoding(4 bytes) = 48 0f be ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte div(byte lhs, byte rhs)
; location: [7FFDDDBCEB60h, 7FFDDDBCEB71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short div(short lhs, short rhs)
; location: [7FFDDDBCEB90h, 7FFDDDBCEBA4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                  ; MOVSX(Movsx_r64_rm16) [RCX,DX]                       encoding(4 bytes) = 48 0f bf ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort div(ushort lhs, ushort rhs)
; location: [7FFDDDBCEBC0h, 7FFDDDBCEBD1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x99,0xF7,0xF9,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int div(int lhs, int rhs)
; location: [7FFDDDBCEBF0h, 7FFDDDBCEBFEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div(uint lhs, uint rhs)
; location: [7FFDDDBCEC10h, 7FFDDDBCEC1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long div(long lhs, long rhs)
; location: [7FFDDDBCEC30h, 7FFDDDBCEC40h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong div(ulong lhs, ulong rhs)
; location: [7FFDDDBCEC60h, 7FFDDDBCEC70h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte div(ref sbyte lhs, in sbyte rhs)
; location: [7FFDDDBCEC90h, 7FFDDDBCECA6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h movsx r8,byte ptr [rdx]       ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RDX:br,DS:sr)]       encoding(4 bytes) = 4c 0f be 02
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
0011h mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x4C,0x0F,0xBE,0x02,0x99,0x41,0xF7,0xF8,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte div(ref byte lhs, in byte rhs)
; location: [7FFDDDBCECC0h, 7FFDDDBCECD5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h movzx r8d,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RDX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 02
000ch cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000dh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
0010h mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x44,0x0F,0xB6,0x02,0x99,0x41,0xF7,0xF8,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short div(ref short lhs, in short rhs)
; location: [7FFDDDBCECF0h, 7FFDDDBCED07h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h movsx r8,word ptr [rdx]       ; MOVSX(Movsx_r64_rm16) [R8,mem(16i,RDX:br,DS:sr)]     encoding(4 bytes) = 4c 0f bf 02
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
0011h mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0014h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x4C,0x0F,0xBF,0x02,0x99,0x41,0xF7,0xF8,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort div(ref ushort lhs, in ushort rhs)
; location: [7FFDDDBCED20h, 7FFDDDBCED36h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h movzx r8d,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RDX:br,DS:sr)]    encoding(4 bytes) = 44 0f b7 02
000ch cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000dh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
0010h mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x44,0x0F,0xB7,0x02,0x99,0x41,0xF7,0xF8,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int div(ref int lhs, in int rhs)
; location: [7FFDDDBCED50h, 7FFDDDBCED63h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv dword ptr [r8]           ; IDIV(Idiv_rm32) [mem(32i,R8:br,DS:sr)]               encoding(3 bytes) = 41 f7 38
000eh mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x8B,0x01,0x99,0x41,0xF7,0x38,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint div(ref uint lhs, in uint rhs)
; location: [7FFDDDBCED80h, 7FFDDDBCED94h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div dword ptr [r8]            ; DIV(Div_rm32) [mem(32u,R8:br,DS:sr)]                 encoding(3 bytes) = 41 f7 30
000fh mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x8B,0x01,0x33,0xD2,0x41,0xF7,0x30,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
