; 2019-12-04 23:04:08:080
; function: Vector128<uint> vcompact(Vector128<ulong> x0, Vector128<ulong> x1, out Vector128<uint> dst)
; location: [7FFDDAF26120h, 7FFDDAF26166h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0013h vpextrq rdx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c2 01
0019h vmovq r8,xmm1                 ; VMOVQ(VEX_Vmovq_rm64_xmm) [R8,XMM1]                  encoding(VEX, 5 bytes) = c4 c1 f9 7e c8
001eh vpextrq r10,xmm1,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [R10,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 c3 f9 16 ca 01
0024h vmovd xmm0,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c0
0028h vpinsrd xmm0,xmm0,edx,1       ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,EDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 22 c2 01
002eh vpinsrd xmm0,xmm0,r8d,2       ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,R8D,2h:imm8] encoding(VEX, 6 bytes) = c4 c3 79 22 c0 02
0034h vpinsrd xmm0,xmm0,r10d,3      ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,R10D,3h:imm8] encoding(VEX, 6 bytes) = c4 c3 79 22 c2 03
003ah vmovupd [r9],xmm0             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 79 11 01
003fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0043h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0046h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompactBytes => new byte[71]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC2,0x01,0xC4,0xC1,0xF9,0x7E,0xC8,0xC4,0xC3,0xF9,0x16,0xCA,0x01,0xC5,0xF9,0x6E,0xC0,0xC4,0xE3,0x79,0x22,0xC2,0x01,0xC4,0xC3,0x79,0x22,0xC0,0x02,0xC4,0xC3,0x79,0x22,0xC2,0x03,0xC4,0xC1,0x79,0x11,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gather_d8u(byte src, byte mask)
; location: [7FFDDAF27140h, 7FFDDAF27153h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gather_g8u(byte src, byte mask)
; location: [7FFDDAF27570h, 7FFDDAF27586h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gather_d16u(ushort src, ushort mask)
; location: [7FFDDAF275A0h, 7FFDDAF275B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gather_g16u(ushort src, ushort mask)
; location: [7FFDDAF275D0h, 7FFDDAF275E6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0013h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather_d32u(uint src, uint mask)
; location: [7FFDDAF27600h, 7FFDDAF2760Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather_g32u(uint src, uint mask)
; location: [7FFDDAF27620h, 7FFDDAF2762Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather_d64u(ulong src, ulong mask)
; location: [7FFDDAF27640h, 7FFDDAF2764Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_d64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather_g64u(ulong src, ulong mask)
; location: [7FFDDAF27660h, 7FFDDAF2766Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_g64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint max_val_nbv_4()
; location: [7FFDDAF27980h, 7FFDDAF2798Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0Fh                   ; MOV(Mov_r32_imm32) [EAX,fh:imm32]                    encoding(5 bytes) = b8 0f 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_val_nbv_4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x0F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint max_val_nbv_8()
; location: [7FFDDAF27F10h, 7FFDDAF27F1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFh                  ; MOV(Mov_r32_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = b8 ff 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_val_nbv_8Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector<N8,uint> add(BitVector<N8,uint> x, BitVector<N8,uint> y)
; location: [7FFDDAF28340h, 7FFDDAF28367h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h add ecx,edx                   ; ADD(Add_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 03 ca
0007h mov edx,80808081h             ; MOV(Mov_r32_imm32) [EDX,80808081h:imm32]             encoding(5 bytes) = ba 81 80 80 80
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh mul edx                       ; MUL(Mul_rm32) [EDX]                                  encoding(2 bytes) = f7 e2
0010h shr edx,7                     ; SHR(Shr_rm32_imm8) [EDX,7h:imm8]                     encoding(3 bytes) = c1 ea 07
0013h imul eax,edx,0FFh             ; IMUL(Imul_r32_rm32_imm32) [EAX,EDX,ffh:imm32]        encoding(6 bytes) = 69 c2 ff 00 00 00
0019h sub ecx,eax                   ; SUB(Sub_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 2b c8
001bh and ecx,0FFh                  ; AND(And_rm32_imm32) [ECX,ffh:imm32]                  encoding(6 bytes) = 81 e1 ff 00 00 00
0021h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[40]{0x50,0x0F,0x1F,0x40,0x00,0x03,0xCA,0xBA,0x81,0x80,0x80,0x80,0x8B,0xC1,0xF7,0xE2,0xC1,0xEA,0x07,0x69,0xC2,0xFF,0x00,0x00,0x00,0x2B,0xC8,0x81,0xE1,0xFF,0x00,0x00,0x00,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector<N8,uint> inc(BitVector<N8,uint> src)
; location: [7FFDDAF28570h, 7FFDDAF28593h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,0FFh                  ; CMP(Cmp_rm32_imm32) [ECX,ffh:imm32]                  encoding(6 bytes) = 81 f9 ff 00 00 00
000bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0013h jne short 0019h               ; JNE(Jne_rel8_64) [19h:jmp64]                         encoding(2 bytes) = 75 04
0015h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
0017h jmp short 001bh               ; JMP(Jmp_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = eb 02
0019h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
001bh and ecx,0FFh                  ; AND(And_rm32_imm32) [ECX,ffh:imm32]                  encoding(6 bytes) = 81 e1 ff 00 00 00
0021h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x81,0xF9,0xFF,0x00,0x00,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x75,0x04,0xFF,0xC1,0xEB,0x02,0x33,0xC9,0x81,0xE1,0xFF,0x00,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector<N8,uint> dec(BitVector<N8,uint> src)
; location: [7FFDDAF285B0h, 7FFDDAF285D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000fh jne short 0018h               ; JNE(Jne_rel8_64) [18h:jmp64]                         encoding(2 bytes) = 75 07
0011h mov eax,0FFh                  ; MOV(Mov_r32_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = b8 ff 00 00 00
0016h jmp short 001ch               ; JMP(Jmp_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = eb 04
0018h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
001ah mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
001ch and eax,0FFh                  ; AND(And_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 25 ff 00 00 00
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x75,0x07,0xB8,0xFF,0x00,0x00,0x00,0xEB,0x04,0xFF,0xC9,0x8B,0xC1,0x25,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit mod_prod_nbv(BitVector<N23,uint> x, BitVector<N23,uint> y)
; location: [7FFDDAF29C40h, 7FFDDAF29C99h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
000ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
000dh jmp short 003ah               ; JMP(Jmp_rel8_64) [3Ah:jmp64]                         encoding(2 bytes) = eb 2b
000fh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0013h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0019h shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
001ch test eax,r10d                 ; TEST(Test_rm32_r32) [R10D,EAX]                       encoding(3 bytes) = 41 85 c2
001fh setne cl                      ; SETNE(Setne_rm8) [CL]                                encoding(3 bytes) = 0f 95 c1
0022h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0025h test edx,r10d                 ; TEST(Test_rm32_r32) [R10D,EDX]                       encoding(3 bytes) = 41 85 d2
0028h setne r10b                    ; SETNE(Setne_rm8) [R10L]                              encoding(4 bytes) = 41 0f 95 c2
002ch movzx r10d,r10b               ; MOVZX(Movzx_r32_rm8) [R10D,R10L]                     encoding(4 bytes) = 45 0f b6 d2
0030h imul ecx,r10d                 ; IMUL(Imul_r32_rm32) [ECX,R10D]                       encoding(4 bytes) = 41 0f af ca
0034h add r8d,ecx                   ; ADD(Add_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 03 c1
0037h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
003ah mov byte ptr [rsp],0          ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(4 bytes) = c6 04 24 00
003eh lea rcx,[rsp]                 ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 0c 24
0042h mov byte ptr [rcx],0          ; MOV(Mov_rm8_imm8) [mem(8u,RCX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 01 00
0045h cmp r9d,17h                   ; CMP(Cmp_rm32_imm8) [R9D,17h:imm32]                   encoding(4 bytes) = 41 83 f9 17
0049h jl short 000fh                ; JL(Jl_rel8_64) [Fh:jmp64]                            encoding(2 bytes) = 7c c4
004bh test r8b,1                    ; TEST(Test_rm8_imm8) [R8L,1h:imm8]                    encoding(4 bytes) = 41 f6 c0 01
004fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0052h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0055h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0059h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_prod_nbvBytes => new byte[90]{0x50,0x0F,0x1F,0x40,0x00,0x8B,0xC1,0x45,0x33,0xC0,0x45,0x33,0xC9,0xEB,0x2B,0x41,0x0F,0xB6,0xC9,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0xD3,0xE2,0x41,0x85,0xC2,0x0F,0x95,0xC1,0x0F,0xB6,0xC9,0x41,0x85,0xD2,0x41,0x0F,0x95,0xC2,0x45,0x0F,0xB6,0xD2,0x41,0x0F,0xAF,0xCA,0x44,0x03,0xC1,0x41,0xFF,0xC1,0xC6,0x04,0x24,0x00,0x48,0x8D,0x0C,0x24,0xC6,0x01,0x00,0x41,0x83,0xF9,0x17,0x7C,0xC4,0x41,0xF6,0xC0,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte inject_8u(byte src, byte dst, int start, int len)
; location: [7FFDDAF29CB0h, 7FFDDAF29D04h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000bh add r9d,r8d                   ; ADD(Add_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 03 c8
000eh bzhi edx,eax,r8d              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EDX,EAX,R8D]            encoding(VEX, 5 bytes) = c4 e2 38 f5 d0
0013h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0016h movzx r10d,cl                 ; MOVZX(Movzx_r32_rm8) [R10D,CL]                       encoding(4 bytes) = 44 0f b6 d1
001ah mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001dh shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
0020h movzx r8d,r10b                ; MOVZX(Movzx_r32_rm8) [R8D,R10L]                      encoding(4 bytes) = 45 0f b6 c2
0024h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0027h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0029h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
002ch movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
002fh shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0032h movzx r10d,r9b                ; MOVZX(Movzx_r32_rm8) [R10D,R9L]                      encoding(4 bytes) = 45 0f b6 d1
0036h or ecx,r10d                   ; OR(Or_r32_rm32) [ECX,R10D]                           encoding(3 bytes) = 41 0b ca
0039h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
003ch bextr ecx,eax,ecx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [ECX,EAX,ECX]          encoding(VEX, 5 bytes) = c4 e2 70 f7 c8
0041h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0044h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0047h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0049h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004ch or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
004fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0051h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0054h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inject_8uBytes => new byte[85]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC9,0x0F,0xB6,0xC2,0x45,0x03,0xC8,0xC4,0xE2,0x38,0xF5,0xD0,0x0F,0xB6,0xD2,0x44,0x0F,0xB6,0xD1,0x41,0x8B,0xC8,0x41,0xD3,0xE2,0x45,0x0F,0xB6,0xC2,0x41,0x8B,0xC9,0xF7,0xD9,0x83,0xC1,0x08,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x45,0x0F,0xB6,0xD1,0x41,0x0B,0xCA,0x0F,0xB7,0xC9,0xC4,0xE2,0x70,0xF7,0xC8,0x0F,0xB6,0xC1,0x41,0x8B,0xC9,0xD3,0xE0,0x0F,0xB6,0xC0,0x41,0x0B,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort inject_16u(ushort src, ushort dst, int start, int len)
; location: [7FFDDAF29D20h, 7FFDDAF29D74h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
000bh add r9d,r8d                   ; ADD(Add_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 03 c8
000eh bzhi edx,eax,r8d              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EDX,EAX,R8D]            encoding(VEX, 5 bytes) = c4 e2 38 f5 d0
0013h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0016h movzx r10d,cx                 ; MOVZX(Movzx_r32_rm16) [R10D,CX]                      encoding(4 bytes) = 44 0f b7 d1
001ah mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001dh shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
0020h movzx r8d,r10w                ; MOVZX(Movzx_r32_rm16) [R8D,R10W]                     encoding(4 bytes) = 45 0f b7 c2
0024h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0027h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0029h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
002ch movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
002fh shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0032h movzx r10d,r9b                ; MOVZX(Movzx_r32_rm8) [R10D,R9L]                      encoding(4 bytes) = 45 0f b6 d1
0036h or ecx,r10d                   ; OR(Or_r32_rm32) [ECX,R10D]                           encoding(3 bytes) = 41 0b ca
0039h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
003ch bextr ecx,eax,ecx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [ECX,EAX,ECX]          encoding(VEX, 5 bytes) = c4 e2 70 f7 c8
0041h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0044h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0047h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0049h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
004ch or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
004fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0051h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0054h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inject_16uBytes => new byte[85]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC9,0x0F,0xB7,0xC2,0x45,0x03,0xC8,0xC4,0xE2,0x38,0xF5,0xD0,0x0F,0xB7,0xD2,0x44,0x0F,0xB7,0xD1,0x41,0x8B,0xC8,0x41,0xD3,0xE2,0x45,0x0F,0xB7,0xC2,0x41,0x8B,0xC9,0xF7,0xD9,0x83,0xC1,0x10,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x45,0x0F,0xB6,0xD1,0x41,0x0B,0xCA,0x0F,0xB7,0xC9,0xC4,0xE2,0x70,0xF7,0xC8,0x0F,0xB7,0xC1,0x41,0x8B,0xC9,0xD3,0xE0,0x0F,0xB7,0xC0,0x41,0x0B,0xD0,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inject_32u(uint src, uint dst, int start, int len)
; location: [7FFDDAF29D90h, 7FFDDAF29DCBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h add r9d,r8d                   ; ADD(Add_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 03 c8
000ah bzhi r10d,edx,r8d             ; BZHI(VEX_Bzhi_r32_rm32_r32) [R10D,EDX,R8D]           encoding(VEX, 5 bytes) = c4 62 38 f5 d2
000fh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0012h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0014h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0017h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0019h add ecx,20h                   ; ADD(Add_rm32_imm8) [ECX,20h:imm32]                   encoding(3 bytes) = 83 c1 20
001ch movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
001fh shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0022h movzx r8d,r9b                 ; MOVZX(Movzx_r32_rm8) [R8D,R9L]                       encoding(4 bytes) = 45 0f b6 c1
0026h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0029h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
002ch bextr edx,edx,ecx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,EDX,ECX]          encoding(VEX, 5 bytes) = c4 e2 70 f7 d2
0031h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0034h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0036h or eax,r10d                   ; OR(Or_r32_rm32) [EAX,R10D]                           encoding(3 bytes) = 41 0b c2
0039h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inject_32uBytes => new byte[60]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x45,0x03,0xC8,0xC4,0x62,0x38,0xF5,0xD2,0x41,0x8B,0xC8,0xD3,0xE0,0x41,0x8B,0xC9,0xF7,0xD9,0x83,0xC1,0x20,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x45,0x0F,0xB6,0xC1,0x41,0x0B,0xC8,0x0F,0xB7,0xC9,0xC4,0xE2,0x70,0xF7,0xD2,0x41,0x8B,0xC9,0xD3,0xE2,0x41,0x0B,0xC2,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inject_64u(ulong src, ulong dst, int start, int len)
; location: [7FFDDAF29DE0h, 7FFDDAF29E22h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h add r9d,r8d                   ; ADD(Add_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 03 c8
000bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
000eh bzhi r10,rdx,rcx              ; BZHI(VEX_Bzhi_r64_rm64_r64) [R10,RDX,RCX]            encoding(VEX, 5 bytes) = c4 62 f0 f5 d2
0013h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0016h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0019h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
001ch neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
001eh add ecx,40h                   ; ADD(Add_rm32_imm8) [ECX,40h:imm32]                   encoding(3 bytes) = 83 c1 40
0021h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0024h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0027h movzx r8d,r9b                 ; MOVZX(Movzx_r32_rm8) [R8D,R9L]                       encoding(4 bytes) = 45 0f b6 c1
002bh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
002eh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0031h bextr rdx,rdx,rcx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,RDX,RCX]          encoding(VEX, 5 bytes) = c4 e2 f0 f7 d2
0036h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0039h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003ch or rax,r10                    ; OR(Or_r64_rm64) [RAX,R10]                            encoding(3 bytes) = 49 0b c2
003fh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inject_64uBytes => new byte[67]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x45,0x03,0xC8,0x41,0x8B,0xC8,0xC4,0x62,0xF0,0xF5,0xD2,0x41,0x8B,0xC8,0x48,0xD3,0xE0,0x41,0x8B,0xC9,0xF7,0xD9,0x83,0xC1,0x40,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x45,0x0F,0xB6,0xC1,0x41,0x0B,0xC8,0x0F,0xB7,0xC9,0xC4,0xE2,0xF0,0xF7,0xD2,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x49,0x0B,0xC2,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 bitrange_32_a(BitVector32 src, int i, int j)
; location: [7FFDDAF29FF0h, 7FFDDAF2A013h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch sub edx,eax                   ; SUB(Sub_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 2b d0
000eh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001eh bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitrange_32_aBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x2B,0xD0,0xFF,0xC2,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0F,0xB6,0xC0,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong clear_64(ulong src, int p0, int p1)
; location: [7FFDDAF2A030h, 7FFDDAF2A07Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0013h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0016h neg r9d                       ; NEG(Neg_rm32) [R9D]                                  encoding(3 bytes) = 41 f7 d9
0019h add r9d,40h                   ; ADD(Add_rm32_imm8) [R9D,40h:imm32]                   encoding(4 bytes) = 41 83 c1 40
001dh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0021h shl r9d,8                     ; SHL(Shl_rm32_imm8) [R9D,8h:imm8]                     encoding(4 bytes) = 41 c1 e1 08
0025h lea r10d,[r8+1]               ; LEA(Lea_r32_m) [R10D,mem(Unknown,R8:br,:sr)]         encoding(4 bytes) = 45 8d 50 01
0029h movzx r10d,r10b               ; MOVZX(Movzx_r32_rm8) [R10D,R10L]                     encoding(4 bytes) = 45 0f b6 d2
002dh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0030h movzx r9d,r9w                 ; MOVZX(Movzx_r32_rm16) [R9D,R9W]                      encoding(4 bytes) = 45 0f b7 c9
0034h bextr r9,rcx,r9               ; BEXTR(VEX_Bextr_r64_rm64_r64) [R9,RCX,R9]            encoding(VEX, 5 bytes) = c4 62 b0 f7 c9
0039h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
003ch mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
003fh shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0042h lea ecx,[rdx+1]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDX:br,:sr)]         encoding(3 bytes) = 8d 4a 01
0045h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0048h or rax,r9                     ; OR(Or_r64_rm64) [RAX,R9]                             encoding(3 bytes) = 49 0b c1
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clear_64Bytes => new byte[76]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0x45,0x8B,0xC8,0x41,0xF7,0xD9,0x41,0x83,0xC1,0x40,0x45,0x0F,0xB6,0xC9,0x41,0xC1,0xE1,0x08,0x45,0x8D,0x50,0x01,0x45,0x0F,0xB6,0xD2,0x45,0x0B,0xCA,0x45,0x0F,0xB7,0xC9,0xC4,0x62,0xB0,0xF7,0xC9,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0x49,0xD3,0xE1,0x8D,0x4A,0x01,0x49,0xD3,0xE1,0x49,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inject_64(ulong src, ulong dst, byte index, byte length)
; location: [7FFDDAF2A090h, 7FFDDAF2A0D7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
000ch movzx r8d,r9b                 ; MOVZX(Movzx_r32_rm8) [R8D,R9L]                       encoding(4 bytes) = 45 0f b6 c1
0010h add r8d,ecx                   ; ADD(Add_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 03 c1
0013h mov r9d,ecx                   ; MOV(Mov_r32_rm32) [R9D,ECX]                          encoding(3 bytes) = 44 8b c9
0016h bzhi r9,rdx,r9                ; BZHI(VEX_Bzhi_r64_rm64_r64) [R9,RDX,R9]              encoding(VEX, 5 bytes) = c4 62 b0 f5 ca
001bh shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
001eh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0021h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0023h add ecx,40h                   ; ADD(Add_rm32_imm8) [ECX,40h:imm32]                   encoding(3 bytes) = 83 c1 40
0026h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0029h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
002ch movzx r10d,r8b                ; MOVZX(Movzx_r32_rm8) [R10D,R8L]                      encoding(4 bytes) = 45 0f b6 d0
0030h or ecx,r10d                   ; OR(Or_r32_rm32) [ECX,R10D]                           encoding(3 bytes) = 41 0b ca
0033h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0036h bextr rdx,rdx,rcx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,RDX,RCX]          encoding(VEX, 5 bytes) = c4 e2 f0 f7 d2
003bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
003eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0041h or rax,r9                     ; OR(Or_r64_rm64) [RAX,R9]                             encoding(3 bytes) = 49 0b c1
0044h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0047h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inject_64Bytes => new byte[72]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0x0F,0xB6,0xC8,0x45,0x0F,0xB6,0xC1,0x44,0x03,0xC1,0x44,0x8B,0xC9,0xC4,0x62,0xB0,0xF5,0xCA,0x48,0xD3,0xE0,0x41,0x8B,0xC8,0xF7,0xD9,0x83,0xC1,0x40,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x45,0x0F,0xB6,0xD0,0x41,0x0B,0xCA,0x0F,0xB7,0xC9,0xC4,0xE2,0xF0,0xF7,0xD2,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x49,0x0B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int pop_bitstore_8(byte src)
; location: [7FFDDAF2A660h, 7FFDDAF2A679h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000bh mov rdx,275E92FBEB9h          ; MOV(Mov_r64_imm64) [RDX,275e92fbeb9h:imm64]          encoding(10 bytes) = 48 ba b9 be 2f e9 75 02 00 00
0015h movzx eax,byte ptr [rax+rdx]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 04 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop_bitstore_8Bytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x48,0x63,0xC0,0x48,0xBA,0xB9,0xBE,0x2F,0xE9,0x75,0x02,0x00,0x00,0x0F,0xB6,0x04,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int pop_bitstore_32(uint src)
; location: [7FFDDAF2A690h, 7FFDDAF2A6F6h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 04
000bh mov [rsp+4],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),ECX]          encoding(4 bytes) = 89 4c 24 04
000fh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0014h movzx edx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 10
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah mov rcx,275E92FBEB9h          ; MOV(Mov_r64_imm64) [RCX,275e92fbeb9h:imm64]          encoding(10 bytes) = 48 b9 b9 be 2f e9 75 02 00 00
0024h movzx edx,byte ptr [rdx+rcx]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RDX:br,:sr)]        encoding(4 bytes) = 0f b6 14 0a
0028h movzx ecx,byte ptr [rax+1]    ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 48 01
002ch movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
002fh mov r8,275E92FBEB9h           ; MOV(Mov_r64_imm64) [R8,275e92fbeb9h:imm64]           encoding(10 bytes) = 49 b8 b9 be 2f e9 75 02 00 00
0039h movzx ecx,byte ptr [rcx+r8]   ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,:sr)]        encoding(5 bytes) = 42 0f b6 0c 01
003eh add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0040h movzx ecx,byte ptr [rax+2]    ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 48 02
0044h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0047h movzx ecx,byte ptr [rcx+r8]   ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,:sr)]        encoding(5 bytes) = 42 0f b6 0c 01
004ch add ecx,edx                   ; ADD(Add_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 03 ca
004eh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0050h movzx eax,byte ptr [rax+3]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 40 03
0054h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0057h movzx eax,byte ptr [rax+r8]   ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(5 bytes) = 42 0f b6 04 00
005ch add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
005eh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0060h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0062h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0066h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop_bitstore_32Bytes => new byte[103]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x44,0x24,0x04,0x89,0x4C,0x24,0x04,0x48,0x8D,0x44,0x24,0x04,0x0F,0xB6,0x10,0x48,0x63,0xD2,0x48,0xB9,0xB9,0xBE,0x2F,0xE9,0x75,0x02,0x00,0x00,0x0F,0xB6,0x14,0x0A,0x0F,0xB6,0x48,0x01,0x48,0x63,0xC9,0x49,0xB8,0xB9,0xBE,0x2F,0xE9,0x75,0x02,0x00,0x00,0x42,0x0F,0xB6,0x0C,0x01,0x03,0xD1,0x0F,0xB6,0x48,0x02,0x48,0x63,0xC9,0x42,0x0F,0xB6,0x0C,0x01,0x03,0xCA,0x8B,0xD1,0x0F,0xB6,0x40,0x03,0x48,0x63,0xC0,0x42,0x0F,0xB6,0x04,0x00,0x03,0xC2,0x8B,0xD0,0x8B,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int pop_bitstore_64(ulong src)
; location: [7FFDDAF2A710h, 7FFDDAF2A7B5h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000bh mov [rsp],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RCX]          encoding(4 bytes) = 48 89 0c 24
000fh lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0013h movzx edx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 10
0016h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0019h mov rcx,275E92FBEB9h          ; MOV(Mov_r64_imm64) [RCX,275e92fbeb9h:imm64]          encoding(10 bytes) = 48 b9 b9 be 2f e9 75 02 00 00
0023h movzx edx,byte ptr [rdx+rcx]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RDX:br,:sr)]        encoding(4 bytes) = 0f b6 14 0a
0027h movzx ecx,byte ptr [rax+1]    ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 48 01
002bh movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
002eh mov r8,275E92FBEB9h           ; MOV(Mov_r64_imm64) [R8,275e92fbeb9h:imm64]           encoding(10 bytes) = 49 b8 b9 be 2f e9 75 02 00 00
0038h movzx ecx,byte ptr [rcx+r8]   ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,:sr)]        encoding(5 bytes) = 42 0f b6 0c 01
003dh add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
003fh movzx ecx,byte ptr [rax+2]    ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 48 02
0043h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0046h movzx ecx,byte ptr [rcx+r8]   ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,:sr)]        encoding(5 bytes) = 42 0f b6 0c 01
004bh add ecx,edx                   ; ADD(Add_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 03 ca
004dh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
004fh movzx ecx,byte ptr [rax+3]    ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 48 03
0053h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0056h movzx ecx,byte ptr [rcx+r8]   ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,:sr)]        encoding(5 bytes) = 42 0f b6 0c 01
005bh add ecx,edx                   ; ADD(Add_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 03 ca
005dh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
005fh movzx ecx,byte ptr [rax+4]    ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 48 04
0063h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0066h movzx ecx,byte ptr [rcx+r8]   ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,:sr)]        encoding(5 bytes) = 42 0f b6 0c 01
006bh add ecx,edx                   ; ADD(Add_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 03 ca
006dh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
006fh movzx ecx,byte ptr [rax+5]    ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 48 05
0073h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0076h movzx ecx,byte ptr [rcx+r8]   ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,:sr)]        encoding(5 bytes) = 42 0f b6 0c 01
007bh add ecx,edx                   ; ADD(Add_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 03 ca
007dh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
007fh movzx ecx,byte ptr [rax+6]    ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 48 06
0083h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0086h movzx ecx,byte ptr [rcx+r8]   ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,:sr)]        encoding(5 bytes) = 42 0f b6 0c 01
008bh add ecx,edx                   ; ADD(Add_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 03 ca
008dh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
008fh movzx eax,byte ptr [rax+7]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 40 07
0093h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0096h movzx eax,byte ptr [rax+r8]   ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(5 bytes) = 42 0f b6 04 00
009bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
009dh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
009fh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
00a1h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
00a5h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop_bitstore_64Bytes => new byte[166]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x89,0x0C,0x24,0x48,0x8D,0x04,0x24,0x0F,0xB6,0x10,0x48,0x63,0xD2,0x48,0xB9,0xB9,0xBE,0x2F,0xE9,0x75,0x02,0x00,0x00,0x0F,0xB6,0x14,0x0A,0x0F,0xB6,0x48,0x01,0x48,0x63,0xC9,0x49,0xB8,0xB9,0xBE,0x2F,0xE9,0x75,0x02,0x00,0x00,0x42,0x0F,0xB6,0x0C,0x01,0x03,0xD1,0x0F,0xB6,0x48,0x02,0x48,0x63,0xC9,0x42,0x0F,0xB6,0x0C,0x01,0x03,0xCA,0x8B,0xD1,0x0F,0xB6,0x48,0x03,0x48,0x63,0xC9,0x42,0x0F,0xB6,0x0C,0x01,0x03,0xCA,0x8B,0xD1,0x0F,0xB6,0x48,0x04,0x48,0x63,0xC9,0x42,0x0F,0xB6,0x0C,0x01,0x03,0xCA,0x8B,0xD1,0x0F,0xB6,0x48,0x05,0x48,0x63,0xC9,0x42,0x0F,0xB6,0x0C,0x01,0x03,0xCA,0x8B,0xD1,0x0F,0xB6,0x48,0x06,0x48,0x63,0xC9,0x42,0x0F,0xB6,0x0C,0x01,0x03,0xCA,0x8B,0xD1,0x0F,0xB6,0x40,0x07,0x48,0x63,0xC0,0x42,0x0F,0xB6,0x04,0x00,0x03,0xC2,0x8B,0xD0,0x8B,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop_3x64(ulong x, ulong y, ulong z)
; location: [7FFDDAF2A7D0h, 7FFDDAF2A88Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
000eh and r9,r8                     ; AND(And_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 23 c8
0011h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0014h or rdx,r9                     ; OR(Or_r64_rm64) [RDX,R9]                             encoding(3 bytes) = 49 0b d1
0017h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
001ah mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
001dh shr rcx,1                     ; SHR(Shr_rm64_1) [RCX,1h:imm8]                        encoding(3 bytes) = 48 d1 e9
0020h mov r8,5555555555555555h      ; MOV(Mov_r64_imm64) [R8,5555555555555555h:imm64]      encoding(10 bytes) = 49 b8 55 55 55 55 55 55 55 55
002ah and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
002dh sub rdx,rcx                   ; SUB(Sub_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 2b d1
0030h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0033h shr rcx,1                     ; SHR(Shr_rm64_1) [RCX,1h:imm8]                        encoding(3 bytes) = 48 d1 e9
0036h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0039h sub rax,rcx                   ; SUB(Sub_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 2b c1
003ch mov rcx,3333333333333333h     ; MOV(Mov_r64_imm64) [RCX,3333333333333333h:imm64]     encoding(10 bytes) = 48 b9 33 33 33 33 33 33 33 33
0046h and rcx,rdx                   ; AND(And_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 23 ca
0049h shr rdx,2                     ; SHR(Shr_rm64_imm8) [RDX,2h:imm8]                     encoding(4 bytes) = 48 c1 ea 02
004dh mov r8,3333333333333333h      ; MOV(Mov_r64_imm64) [R8,3333333333333333h:imm64]      encoding(10 bytes) = 49 b8 33 33 33 33 33 33 33 33
0057h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
005ah add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
005dh and r8,rax                    ; AND(And_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 23 c0
0060h shr rax,2                     ; SHR(Shr_rm64_imm8) [RAX,2h:imm8]                     encoding(4 bytes) = 48 c1 e8 02
0064h mov rcx,3333333333333333h     ; MOV(Mov_r64_imm64) [RCX,3333333333333333h:imm64]     encoding(10 bytes) = 48 b9 33 33 33 33 33 33 33 33
006eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0071h add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
0074h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0077h shr rcx,4                     ; SHR(Shr_rm64_imm8) [RCX,4h:imm8]                     encoding(4 bytes) = 48 c1 e9 04
007bh add rcx,rdx                   ; ADD(Add_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 03 ca
007eh mov rdx,0F0F0F0F0F0F0F0Fh     ; MOV(Mov_r64_imm64) [RDX,f0f0f0f0f0f0f0fh:imm64]      encoding(10 bytes) = 48 ba 0f 0f 0f 0f 0f 0f 0f 0f
0088h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
008bh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
008eh shr rcx,4                     ; SHR(Shr_rm64_imm8) [RCX,4h:imm8]                     encoding(4 bytes) = 48 c1 e9 04
0092h add rcx,rax                   ; ADD(Add_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 03 c8
0095h mov rax,0F0F0F0F0F0F0F0Fh     ; MOV(Mov_r64_imm64) [RAX,f0f0f0f0f0f0f0fh:imm64]      encoding(10 bytes) = 48 b8 0f 0f 0f 0f 0f 0f 0f 0f
009fh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
00a2h add rdx,rdx                   ; ADD(Add_r64_rm64) [RDX,RDX]                          encoding(3 bytes) = 48 03 d2
00a5h add rdx,rax                   ; ADD(Add_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 03 d0
00a8h mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
00b2h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
00b6h shr rax,38h                   ; SHR(Shr_rm64_imm8) [RAX,38h:imm8]                    encoding(4 bytes) = 48 c1 e8 38
00bah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop_3x64Bytes => new byte[187]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0x4C,0x8B,0xC8,0x4D,0x23,0xC8,0x48,0x23,0xD1,0x49,0x0B,0xD1,0x49,0x33,0xC0,0x48,0x8B,0xCA,0x48,0xD1,0xE9,0x49,0xB8,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x49,0x23,0xC8,0x48,0x2B,0xD1,0x48,0x8B,0xC8,0x48,0xD1,0xE9,0x49,0x23,0xC8,0x48,0x2B,0xC1,0x48,0xB9,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x48,0x23,0xCA,0x48,0xC1,0xEA,0x02,0x49,0xB8,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x49,0x23,0xD0,0x48,0x03,0xD1,0x4C,0x23,0xC0,0x48,0xC1,0xE8,0x02,0x48,0xB9,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x48,0x23,0xC1,0x49,0x03,0xC0,0x48,0x8B,0xCA,0x48,0xC1,0xE9,0x04,0x48,0x03,0xCA,0x48,0xBA,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x48,0x23,0xD1,0x48,0x8B,0xC8,0x48,0xC1,0xE9,0x04,0x48,0x03,0xC8,0x48,0xB8,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x48,0x23,0xC1,0x48,0x03,0xD2,0x48,0x03,0xD0,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x48,0x0F,0xAF,0xC2,0x48,0xC1,0xE8,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop_3x128(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z)
; location: [7FFDDAF2A8A0h, 7FFDDAF2AA04h]
0000h sub rsp,58h                   ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 ec 58
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps [rsp+40h],xmm6        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 6 bytes) = c5 f8 29 74 24 40
000dh vmovaps [rsp+30h],xmm7        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 6 bytes) = c5 f8 29 7c 24 30
0013h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0017h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
001bh vmovupd xmm2,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 10
0020h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0022h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
0027h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
002ch mov rax,5555555555555555h     ; MOV(Mov_r64_imm64) [RAX,5555555555555555h:imm64]     encoding(10 bytes) = 48 b8 55 55 55 55 55 55 55 55
0036h mov [rsp+18h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 18
003bh lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 18
0040h vpbroadcastq xmm3,qword ptr [rsp+18h]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM3,mem(64i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 59 5c 24 18
0047h mov rax,3333333333333333h     ; MOV(Mov_r64_imm64) [RAX,3333333333333333h:imm64]     encoding(10 bytes) = 48 b8 33 33 33 33 33 33 33 33
0051h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
0056h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
005bh vpbroadcastq xmm4,qword ptr [rsp+10h]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM4,mem(64i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 59 64 24 10
0062h mov rax,0F0F0F0F0F0F0F0Fh     ; MOV(Mov_r64_imm64) [RAX,f0f0f0f0f0f0f0fh:imm64]      encoding(10 bytes) = 48 b8 0f 0f 0f 0f 0f 0f 0f 0f
006ch mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0071h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0076h vpbroadcastq xmm5,qword ptr [rsp+8]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM5,mem(64i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 59 6c 24 08
007dh vpxor xmm6,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM6,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef f1
0081h vpand xmm6,xmm6,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM6,XMM6,XMM2]    encoding(VEX, 4 bytes) = c5 c9 db f2
0085h vpand xmm7,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM7,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db f9
0089h vpor xmm6,xmm6,xmm7           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM6,XMM6,XMM7]      encoding(VEX, 4 bytes) = c5 c9 eb f7
008dh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0091h vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
0095h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
009ah vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
009eh vpsrlq xmm1,xmm6,xmm1         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM1,XMM6,XMM1]  encoding(VEX, 4 bytes) = c5 c9 d3 c9
00a2h vpand xmm1,xmm1,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM3]    encoding(VEX, 4 bytes) = c5 f1 db cb
00a6h vpsubq xmm6,xmm6,xmm1         ; VPSUBQ(VEX_Vpsubq_xmm_xmm_xmmm128) [XMM6,XMM6,XMM1]  encoding(VEX, 4 bytes) = c5 c9 fb f1
00aah vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
00aeh vpsrlq xmm1,xmm0,xmm1         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM1,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 d3 c9
00b2h vpand xmm1,xmm1,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM3]    encoding(VEX, 4 bytes) = c5 f1 db cb
00b6h vpsubq xmm0,xmm0,xmm1         ; VPSUBQ(VEX_Vpsubq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fb c1
00bah vpand xmm1,xmm6,xmm4          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM6,XMM4]    encoding(VEX, 4 bytes) = c5 c9 db cc
00beh mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
00c3h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
00c7h vpsrlq xmm2,xmm6,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM2,XMM6,XMM2]  encoding(VEX, 4 bytes) = c5 c9 d3 d2
00cbh vpand xmm2,xmm2,xmm4          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM4]    encoding(VEX, 4 bytes) = c5 e9 db d4
00cfh vpaddq xmm6,xmm1,xmm2         ; VPADDQ(VEX_Vpaddq_xmm_xmm_xmmm128) [XMM6,XMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f1 d4 f2
00d3h vpand xmm1,xmm0,xmm4          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM0,XMM4]    encoding(VEX, 4 bytes) = c5 f9 db cc
00d7h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
00dbh vpsrlq xmm0,xmm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d3 c2
00dfh vpand xmm0,xmm0,xmm4          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM4]    encoding(VEX, 4 bytes) = c5 f9 db c4
00e3h vpaddq xmm0,xmm1,xmm0         ; VPADDQ(VEX_Vpaddq_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]  encoding(VEX, 4 bytes) = c5 f1 d4 c0
00e7h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
00ech vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
00f0h vpsrlq xmm1,xmm6,xmm1         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM1,XMM6,XMM1]  encoding(VEX, 4 bytes) = c5 c9 d3 c9
00f4h vpaddq xmm1,xmm6,xmm1         ; VPADDQ(VEX_Vpaddq_xmm_xmm_xmmm128) [XMM1,XMM6,XMM1]  encoding(VEX, 4 bytes) = c5 c9 d4 c9
00f8h vpand xmm6,xmm1,xmm5          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM6,XMM1,XMM5]    encoding(VEX, 4 bytes) = c5 f1 db f5
00fch vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0100h vpsrlq xmm1,xmm0,xmm1         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM1,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 d3 c9
0104h vpaddq xmm0,xmm0,xmm1         ; VPADDQ(VEX_Vpaddq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 d4 c1
0108h vpand xmm0,xmm0,xmm5          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM5]    encoding(VEX, 4 bytes) = c5 f9 db c5
010ch vpaddq xmm1,xmm6,xmm6         ; VPADDQ(VEX_Vpaddq_xmm_xmm_xmmm128) [XMM1,XMM6,XMM6]  encoding(VEX, 4 bytes) = c5 c9 d4 ce
0110h vpaddq xmm0,xmm1,xmm0         ; VPADDQ(VEX_Vpaddq_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]  encoding(VEX, 4 bytes) = c5 f1 d4 c0
0114h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0116h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
011bh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
0120h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
0125h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0129h mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
0133h imul rax,[rsp+20h]            ; IMUL(Imul_r64_rm64) [RAX,mem(64i,RSP:br,:sr)]        encoding(6 bytes) = 48 0f af 44 24 20
0139h shr rax,38h                   ; SHR(Shr_rm64_imm8) [RAX,38h:imm8]                    encoding(4 bytes) = 48 c1 e8 38
013dh mov rdx,101010101010101h      ; MOV(Mov_r64_imm64) [RDX,101010101010101h:imm64]      encoding(10 bytes) = 48 ba 01 01 01 01 01 01 01 01
0147h imul rdx,[rsp+28h]            ; IMUL(Imul_r64_rm64) [RDX,mem(64i,RSP:br,:sr)]        encoding(6 bytes) = 48 0f af 54 24 28
014dh shr rdx,38h                   ; SHR(Shr_rm64_imm8) [RDX,38h:imm8]                    encoding(4 bytes) = 48 c1 ea 38
0151h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0154h vmovaps xmm6,[rsp+40h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f8 28 74 24 40
015ah vmovaps xmm7,[rsp+30h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f8 28 7c 24 30
0160h add rsp,58h                   ; ADD(Add_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 c4 58
0164h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop_3x128Bytes => new byte[357]{0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0x74,0x24,0x40,0xC5,0xF8,0x29,0x7C,0x24,0x30,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xC1,0x79,0x10,0x10,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0xB8,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x48,0x89,0x44,0x24,0x18,0x48,0x8D,0x44,0x24,0x18,0xC4,0xE2,0x79,0x59,0x5C,0x24,0x18,0x48,0xB8,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x48,0x89,0x44,0x24,0x10,0x48,0x8D,0x44,0x24,0x10,0xC4,0xE2,0x79,0x59,0x64,0x24,0x10,0x48,0xB8,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC4,0xE2,0x79,0x59,0x6C,0x24,0x08,0xC5,0xF9,0xEF,0xF1,0xC5,0xC9,0xDB,0xF2,0xC5,0xF9,0xDB,0xF9,0xC5,0xC9,0xEB,0xF7,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0xEF,0xC2,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xC9,0xD3,0xC9,0xC5,0xF1,0xDB,0xCB,0xC5,0xC9,0xFB,0xF1,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xD3,0xC9,0xC5,0xF1,0xDB,0xCB,0xC5,0xF9,0xFB,0xC1,0xC5,0xC9,0xDB,0xCC,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xC9,0xD3,0xD2,0xC5,0xE9,0xDB,0xD4,0xC5,0xF1,0xD4,0xF2,0xC5,0xF9,0xDB,0xCC,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD3,0xC2,0xC5,0xF9,0xDB,0xC4,0xC5,0xF1,0xD4,0xC0,0xB8,0x04,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xC9,0xD3,0xC9,0xC5,0xC9,0xD4,0xC9,0xC5,0xF1,0xDB,0xF5,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xD3,0xC9,0xC5,0xF9,0xD4,0xC1,0xC5,0xF9,0xDB,0xC5,0xC5,0xC9,0xD4,0xCE,0xC5,0xF1,0xD4,0xC0,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8D,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x00,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x48,0x0F,0xAF,0x44,0x24,0x20,0x48,0xC1,0xE8,0x38,0x48,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x48,0x0F,0xAF,0x54,0x24,0x28,0x48,0xC1,0xEA,0x38,0x48,0x03,0xC2,0xC5,0xF8,0x28,0x74,0x24,0x40,0xC5,0xF8,0x28,0x7C,0x24,0x30,0x48,0x83,0xC4,0x58,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop_3x256(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z)
; location: [7FFDDAF2AA50h, 7FFDDAF2ABF1h]
0000h sub rsp,68h                   ; SUB(Sub_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 ec 68
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps [rsp+50h],xmm6        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 6 bytes) = c5 f8 29 74 24 50
000dh vmovaps [rsp+40h],xmm7        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 6 bytes) = c5 f8 29 7c 24 40
0013h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0017h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
001bh vmovupd ymm2,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 10
0020h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
0025h vxorps xmm3,xmm3,xmm3         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM3,XMM3,XMM3]  encoding(VEX, 4 bytes) = c5 e0 57 db
0029h vmovdqu xmmword ptr [rax],xmm3; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM3] encoding(VEX, 4 bytes) = c5 fa 7f 18
002dh vmovdqu xmmword ptr [rax+10h],xmm3; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM3] encoding(VEX, 5 bytes) = c5 fa 7f 58 10
0032h mov rax,5555555555555555h     ; MOV(Mov_r64_imm64) [RAX,5555555555555555h:imm64]     encoding(10 bytes) = 48 b8 55 55 55 55 55 55 55 55
003ch mov [rsp+18h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 18
0041h lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 18
0046h vpbroadcastq ymm3,qword ptr [rsp+18h]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM3,mem(64i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 59 5c 24 18
004dh mov rax,3333333333333333h     ; MOV(Mov_r64_imm64) [RAX,3333333333333333h:imm64]     encoding(10 bytes) = 48 b8 33 33 33 33 33 33 33 33
0057h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
005ch lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0061h vpbroadcastq ymm4,qword ptr [rsp+10h]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM4,mem(64i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 59 64 24 10
0068h mov rax,0F0F0F0F0F0F0F0Fh     ; MOV(Mov_r64_imm64) [RAX,f0f0f0f0f0f0f0fh:imm64]      encoding(10 bytes) = 48 b8 0f 0f 0f 0f 0f 0f 0f 0f
0072h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0077h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
007ch vpbroadcastq ymm5,qword ptr [rsp+8]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM5,mem(64i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 59 6c 24 08
0083h vpxor ymm6,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM6,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef f1
0087h vpand ymm6,ymm6,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM6,YMM6,YMM2]    encoding(VEX, 4 bytes) = c5 cd db f2
008bh vpand ymm7,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM7,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db f9
008fh vpor ymm6,ymm6,ymm7           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM6,YMM6,YMM7]      encoding(VEX, 4 bytes) = c5 cd eb f7
0093h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0097h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
009bh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
00a0h vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
00a4h vpsrlq ymm1,ymm6,xmm1         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM1,YMM6,XMM1]  encoding(VEX, 4 bytes) = c5 cd d3 c9
00a8h vpand ymm1,ymm1,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]    encoding(VEX, 4 bytes) = c5 f5 db cb
00ach vpsubq ymm6,ymm6,ymm1         ; VPSUBQ(VEX_Vpsubq_ymm_ymm_ymmm256) [YMM6,YMM6,YMM1]  encoding(VEX, 4 bytes) = c5 cd fb f1
00b0h vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
00b4h vpsrlq ymm1,ymm0,xmm1         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM1,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd d3 c9
00b8h vpand ymm1,ymm1,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]    encoding(VEX, 4 bytes) = c5 f5 db cb
00bch vpsubq ymm0,ymm0,ymm1         ; VPSUBQ(VEX_Vpsubq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd fb c1
00c0h vpand ymm1,ymm6,ymm4          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM6,YMM4]    encoding(VEX, 4 bytes) = c5 cd db cc
00c4h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
00c9h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
00cdh vpsrlq ymm2,ymm6,xmm2         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM2,YMM6,XMM2]  encoding(VEX, 4 bytes) = c5 cd d3 d2
00d1h vpand ymm2,ymm2,ymm4          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM4]    encoding(VEX, 4 bytes) = c5 ed db d4
00d5h vpaddq ymm6,ymm1,ymm2         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM6,YMM1,YMM2]  encoding(VEX, 4 bytes) = c5 f5 d4 f2
00d9h vpand ymm1,ymm0,ymm4          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM0,YMM4]    encoding(VEX, 4 bytes) = c5 fd db cc
00ddh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
00e1h vpsrlq ymm0,ymm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d3 c2
00e5h vpand ymm0,ymm0,ymm4          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM4]    encoding(VEX, 4 bytes) = c5 fd db c4
00e9h vpaddq ymm0,ymm1,ymm0         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]  encoding(VEX, 4 bytes) = c5 f5 d4 c0
00edh mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
00f2h vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
00f6h vpsrlq ymm1,ymm6,xmm1         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM1,YMM6,XMM1]  encoding(VEX, 4 bytes) = c5 cd d3 c9
00fah vpaddq ymm1,ymm6,ymm1         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM1,YMM6,YMM1]  encoding(VEX, 4 bytes) = c5 cd d4 c9
00feh vpand ymm6,ymm1,ymm5          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM6,YMM1,YMM5]    encoding(VEX, 4 bytes) = c5 f5 db f5
0102h vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0106h vpsrlq ymm1,ymm0,xmm1         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM1,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd d3 c9
010ah vpaddq ymm0,ymm0,ymm1         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd d4 c1
010eh vpand ymm0,ymm0,ymm5          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM5]    encoding(VEX, 4 bytes) = c5 fd db c5
0112h vpaddq ymm1,ymm6,ymm6         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM1,YMM6,YMM6]  encoding(VEX, 4 bytes) = c5 cd d4 ce
0116h vpaddq ymm0,ymm1,ymm0         ; VPADDQ(VEX_Vpaddq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]  encoding(VEX, 4 bytes) = c5 f5 d4 c0
011ah lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
011fh vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0123h vmovdqu xmmword ptr [rax],xmm1; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM1] encoding(VEX, 4 bytes) = c5 fa 7f 08
0127h vmovdqu xmmword ptr [rax+10h],xmm1; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fa 7f 48 10
012ch lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
0131h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0134h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
0138h mov rdx,101010101010101h      ; MOV(Mov_r64_imm64) [RDX,101010101010101h:imm64]      encoding(10 bytes) = 48 ba 01 01 01 01 01 01 01 01
0142h imul rdx,[rax]                ; IMUL(Imul_r64_rm64) [RDX,mem(64i,RAX:br,:sr)]        encoding(4 bytes) = 48 0f af 10
0146h shr rdx,38h                   ; SHR(Shr_rm64_imm8) [RDX,38h:imm8]                    encoding(4 bytes) = 48 c1 ea 38
014ah mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
0154h imul rcx,[rax+8]              ; IMUL(Imul_r64_rm64) [RCX,mem(64i,RAX:br,:sr)]        encoding(5 bytes) = 48 0f af 48 08
0159h shr rcx,38h                   ; SHR(Shr_rm64_imm8) [RCX,38h:imm8]                    encoding(4 bytes) = 48 c1 e9 38
015dh add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0160h mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
016ah imul rcx,[rax+10h]            ; IMUL(Imul_r64_rm64) [RCX,mem(64i,RAX:br,:sr)]        encoding(5 bytes) = 48 0f af 48 10
016fh shr rcx,38h                   ; SHR(Shr_rm64_imm8) [RCX,38h:imm8]                    encoding(4 bytes) = 48 c1 e9 38
0173h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0176h mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
0180h imul rcx,[rax+18h]            ; IMUL(Imul_r64_rm64) [RCX,mem(64i,RAX:br,:sr)]        encoding(5 bytes) = 48 0f af 48 18
0185h shr rcx,38h                   ; SHR(Shr_rm64_imm8) [RCX,38h:imm8]                    encoding(4 bytes) = 48 c1 e9 38
0189h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
018ch mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
018eh vmovaps xmm6,[rsp+50h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f8 28 74 24 50
0194h vmovaps xmm7,[rsp+40h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f8 28 7c 24 40
019ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
019dh add rsp,68h                   ; ADD(Add_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 c4 68
01a1h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop_3x256Bytes => new byte[418]{0x48,0x83,0xEC,0x68,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0x74,0x24,0x50,0xC5,0xF8,0x29,0x7C,0x24,0x40,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xC1,0x7D,0x10,0x10,0x48,0x8D,0x44,0x24,0x20,0xC5,0xE0,0x57,0xDB,0xC5,0xFA,0x7F,0x18,0xC5,0xFA,0x7F,0x58,0x10,0x48,0xB8,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x48,0x89,0x44,0x24,0x18,0x48,0x8D,0x44,0x24,0x18,0xC4,0xE2,0x7D,0x59,0x5C,0x24,0x18,0x48,0xB8,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x48,0x89,0x44,0x24,0x10,0x48,0x8D,0x44,0x24,0x10,0xC4,0xE2,0x7D,0x59,0x64,0x24,0x10,0x48,0xB8,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC4,0xE2,0x7D,0x59,0x6C,0x24,0x08,0xC5,0xFD,0xEF,0xF1,0xC5,0xCD,0xDB,0xF2,0xC5,0xFD,0xDB,0xF9,0xC5,0xCD,0xEB,0xF7,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0xEF,0xC2,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xCD,0xD3,0xC9,0xC5,0xF5,0xDB,0xCB,0xC5,0xCD,0xFB,0xF1,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xD3,0xC9,0xC5,0xF5,0xDB,0xCB,0xC5,0xFD,0xFB,0xC1,0xC5,0xCD,0xDB,0xCC,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xCD,0xD3,0xD2,0xC5,0xED,0xDB,0xD4,0xC5,0xF5,0xD4,0xF2,0xC5,0xFD,0xDB,0xCC,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD3,0xC2,0xC5,0xFD,0xDB,0xC4,0xC5,0xF5,0xD4,0xC0,0xB8,0x04,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xCD,0xD3,0xC9,0xC5,0xCD,0xD4,0xC9,0xC5,0xF5,0xDB,0xF5,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xD3,0xC9,0xC5,0xFD,0xD4,0xC1,0xC5,0xFD,0xDB,0xC5,0xC5,0xCD,0xD4,0xCE,0xC5,0xF5,0xD4,0xC0,0x48,0x8D,0x44,0x24,0x20,0xC5,0xF0,0x57,0xC9,0xC5,0xFA,0x7F,0x08,0xC5,0xFA,0x7F,0x48,0x10,0x48,0x8D,0x44,0x24,0x20,0x48,0x8B,0xD0,0xC5,0xFE,0x7F,0x02,0x48,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x48,0x0F,0xAF,0x10,0x48,0xC1,0xEA,0x38,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x48,0x0F,0xAF,0x48,0x08,0x48,0xC1,0xE9,0x38,0x48,0x03,0xD1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x48,0x0F,0xAF,0x48,0x10,0x48,0xC1,0xE9,0x38,0x48,0x03,0xD1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x48,0x0F,0xAF,0x48,0x18,0x48,0xC1,0xE9,0x38,0x48,0x03,0xD1,0x8B,0xC2,0xC5,0xF8,0x28,0x74,0x24,0x50,0xC5,0xF8,0x28,0x7C,0x24,0x40,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x68,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x1_byte(ulong src, Span<byte> dst)
; location: [7FFDDAF2B450h, 7FFDDAF2B500h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,101010101010101h      ; MOV(Mov_r64_imm64) [RDX,101010101010101h:imm64]      encoding(10 bytes) = 48 ba 01 01 01 01 01 01 01 01
0012h pdep rdx,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 d2
0017h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
001ah lea rdx,[rax+8]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 08
001eh mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
0021h shr r8,8                      ; SHR(Shr_rm64_imm8) [R8,8h:imm8]                      encoding(4 bytes) = 49 c1 e8 08
0025h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
002fh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0034h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0037h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 10
003bh mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
003eh shr r8,10h                    ; SHR(Shr_rm64_imm8) [R8,10h:imm8]                     encoding(4 bytes) = 49 c1 e8 10
0042h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0047h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
004ah lea rdx,[rax+18h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 18
004eh mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
0051h shr r8,18h                    ; SHR(Shr_rm64_imm8) [R8,18h:imm8]                     encoding(4 bytes) = 49 c1 e8 18
0055h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
005ah mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
005dh lea rdx,[rax+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 20
0061h mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
0064h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
0068h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
006dh mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0070h lea rdx,[rax+28h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 28
0074h mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
0077h shr r8,28h                    ; SHR(Shr_rm64_imm8) [R8,28h:imm8]                     encoding(4 bytes) = 49 c1 e8 28
007bh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0080h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0083h lea rdx,[rax+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 30
0087h mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
008ah shr r8,30h                    ; SHR(Shr_rm64_imm8) [R8,30h:imm8]                     encoding(4 bytes) = 49 c1 e8 30
008eh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0093h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0096h add rax,38h                   ; ADD(Add_rm64_imm8) [RAX,38h:imm64]                   encoding(4 bytes) = 48 83 c0 38
009ah shr rcx,38h                   ; SHR(Shr_rm64_imm8) [RCX,38h:imm8]                    encoding(4 bytes) = 48 c1 e9 38
009eh pdep rdx,rcx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RCX,R9]             encoding(VEX, 5 bytes) = c4 c2 f3 f5 d1
00a3h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
00a6h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00aah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00abh call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F623900h:jmp64]                encoding(5 bytes) = e8 50 38 62 5f
00b0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part64x1_byteBytes => new byte[177]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x48,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xD2,0x48,0x89,0x10,0x48,0x8D,0x50,0x08,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x08,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x10,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x10,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x18,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x18,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x20,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x20,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x28,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x28,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x30,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x30,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x83,0xC0,0x38,0x48,0xC1,0xE9,0x38,0xC4,0xC2,0xF3,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x50,0x38,0x62,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x1_bit(ulong src, Span<bit> dst)
; location: [7FFDDAF2B520h, 7FFDDAF2B572h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0007h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 02
000ah mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 08
000dh shl rcx,2                     ; SHL(Shl_rm64_imm8) [RCX,2h:imm8]                     encoding(4 bytes) = 48 c1 e1 02
0011h shr rcx,3                     ; SHR(Shr_rm64_imm8) [RCX,3h:imm8]                     encoding(4 bytes) = 48 c1 e9 03
0015h cmp rcx,7FFFFFFFh             ; CMP(Cmp_rm64_imm32) [RCX,7fffffffh:imm64]            encoding(7 bytes) = 48 81 f9 ff ff ff 7f
001ch ja short 004dh                ; JA(Ja_rel8_64) [4Dh:jmp64]                           encoding(2 bytes) = 77 2f
001eh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0020h movsxd rcx,edx                ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]                    encoding(3 bytes) = 48 63 ca
0023h lea r9,[r8+rcx*8]             ; LEA(Lea_r64_m) [R9,mem(Unknown,R8:br,:sr)]           encoding(4 bytes) = 4d 8d 0c c8
0027h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0029h mov r10,rax                   ; MOV(Mov_r64_rm64) [R10,RAX]                          encoding(3 bytes) = 4c 8b d0
002ch shr r10,cl                    ; SHR(Shr_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 ea
002fh mov rcx,100000001h            ; MOV(Mov_r64_imm64) [RCX,100000001h:imm64]            encoding(10 bytes) = 48 b9 01 00 00 00 01 00 00 00
0039h pdep rcx,r10,rcx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,R10,RCX]            encoding(VEX, 5 bytes) = c4 e2 ab f5 c9
003eh mov [r9],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RCX]           encoding(3 bytes) = 49 89 09
0041h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0043h cmp edx,20h                   ; CMP(Cmp_rm32_imm8) [EDX,20h:imm32]                   encoding(3 bytes) = 83 fa 20
0046h jl short 0020h                ; JL(Jl_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 7c d8
0048h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004dh call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F623830h:jmp64]                encoding(5 bytes) = e8 de 37 62 5f
0052h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part64x1_bitBytes => new byte[83]{0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0x4C,0x8B,0x02,0x8B,0x4A,0x08,0x48,0xC1,0xE1,0x02,0x48,0xC1,0xE9,0x03,0x48,0x81,0xF9,0xFF,0xFF,0xFF,0x7F,0x77,0x2F,0x33,0xD2,0x48,0x63,0xCA,0x4D,0x8D,0x0C,0xC8,0x8B,0xCA,0x4C,0x8B,0xD0,0x49,0xD3,0xEA,0x48,0xB9,0x01,0x00,0x00,0x00,0x01,0x00,0x00,0x00,0xC4,0xE2,0xAB,0xF5,0xC9,0x49,0x89,0x09,0xFF,0xC2,0x83,0xFA,0x20,0x7C,0xD8,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xDE,0x37,0x62,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_20()
; location: [7FFDDAF2B990h, 7FFDDAF2B99Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,100000h               ; MOV(Mov_r32_imm32) [EAX,100000h:imm32]               encoding(5 bytes) = b8 00 00 10 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_20Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x00,0x10,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_20()
; location: [7FFDDAF2B9B0h, 7FFDDAF2B9BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFh               ; MOV(Mov_r32_imm32) [EAX,fffffh:imm32]                encoding(5 bytes) = b8 ff ff 0f 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_20Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0x0F,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_33()
; location: [7FFDDAF2BDE0h, 7FFDDAF2BDEFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,200000000h            ; MOV(Mov_r64_imm64) [RAX,200000000h:imm64]            encoding(10 bytes) = 48 b8 00 00 00 00 02 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_33Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0x00,0x00,0x00,0x02,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_33()
; location: [7FFDDAF2BE00h, 7FFDDAF2BE0Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,1FFFFFFFFh            ; MOV(Mov_r64_imm64) [RAX,1ffffffffh:imm64]            encoding(10 bytes) = 48 b8 ff ff ff ff 01 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_33Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xFF,0xFF,0xFF,0xFF,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_1()
; location: [7FFDDAF2BE20h, 7FFDDAF2BE2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_1Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_1()
; location: [7FFDDAF2BE40h, 7FFDDAF2BE4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_1Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_2()
; location: [7FFDDAF2BE60h, 7FFDDAF2BE6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x04,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_2()
; location: [7FFDDAF2BE80h, 7FFDDAF2BE8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3                     ; MOV(Mov_r32_imm32) [EAX,3h:imm32]                    encoding(5 bytes) = b8 03 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_3()
; location: [7FFDDAF2BEA0h, 7FFDDAF2BEAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x08,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_3()
; location: [7FFDDAF2BEC0h, 7FFDDAF2BECAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x07,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_4()
; location: [7FFDDAF2BEE0h, 7FFDDAF2BEEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_4()
; location: [7FFDDAF2BF00h, 7FFDDAF2BF0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0Fh                   ; MOV(Mov_r32_imm32) [EAX,fh:imm32]                    encoding(5 bytes) = b8 0f 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x0F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_5()
; location: [7FFDDAF2BF20h, 7FFDDAF2BF2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_5Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x20,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_5()
; location: [7FFDDAF2BF40h, 7FFDDAF2BF4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1Fh                   ; MOV(Mov_r32_imm32) [EAX,1fh:imm32]                   encoding(5 bytes) = b8 1f 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_5Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x1F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_6()
; location: [7FFDDAF2BF60h, 7FFDDAF2BF6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,40h                   ; MOV(Mov_r32_imm32) [EAX,40h:imm32]                   encoding(5 bytes) = b8 40 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_6Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x40,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_6()
; location: [7FFDDAF2BF80h, 7FFDDAF2BF8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3Fh                   ; MOV(Mov_r32_imm32) [EAX,3fh:imm32]                   encoding(5 bytes) = b8 3f 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_6Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x3F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_7()
; location: [7FFDDAF2BFA0h, 7FFDDAF2BFAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,80h                   ; MOV(Mov_r32_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = b8 80 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_7Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x80,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_7()
; location: [7FFDDAF2BFC0h, 7FFDDAF2BFCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7Fh                   ; MOV(Mov_r32_imm32) [EAX,7fh:imm32]                   encoding(5 bytes) = b8 7f 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_7Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x7F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_8()
; location: [7FFDDAF2BFE0h, 7FFDDAF2BFEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,100h                  ; MOV(Mov_r32_imm32) [EAX,100h:imm32]                  encoding(5 bytes) = b8 00 01 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_8Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x01,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_8()
; location: [7FFDDAF2C000h, 7FFDDAF2C00Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFh                  ; MOV(Mov_r32_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = b8 ff 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_8Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
