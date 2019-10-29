; 2019-10-29 02:32:27:057
; function: ushort segment(ushort src, int i0, int i1)
; location: [7FFDDBAC70C0h, 7FFDDBAC70E2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
001ah bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short segment(short src, int i0, int i1)
; location: [7FFDDBAC7100h, 7FFDDBAC7124h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
001bh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0020h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int segment(int src, int i0, int i1)
; location: [7FFDDBAC7140h, 7FFDDBAC715Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint segment(uint src, int i0, int i1)
; location: [7FFDDBAC7170h, 7FFDDBAC718Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long segment(long src, int i0, int i1)
; location: [7FFDDBAC71A0h, 7FFDDBAC71BCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong segment(ulong src, int i0, int i1)
; location: [7FFDDBAC71D0h, 7FFDDBAC71ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float segment(float src, int i0, int i1)
; location: [7FFDDBAC7200h, 7FFDDBAC7232h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0012h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0016h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0019h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
001eh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0021h bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
0026h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
0029h vmovss xmm0,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 10 04 24
002eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[51]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC8,0xC1,0xE1,0x08,0x0F,0xB6,0xD2,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x89,0x04,0x24,0xC5,0xFA,0x10,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double segment(double src, int i0, int i1)
; location: [7FFDDBAC7250h, 7FFDDBAC7288h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0015h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0019h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
001ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001fh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0021h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0024h bextr rax,rax,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RAX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 c0
0029h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
002eh vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0034h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[57]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC8,0xC1,0xE1,0x08,0x0F,0xB6,0xD2,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xC0,0x48,0x89,0x44,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(byte src, out byte x0, out byte x1)
; location: [7FFDDBAC72A0h, 7FFDDBAC72B5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000ah and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
000dh mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]            encoding(2 bytes) = 88 0a
000fh sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0012h mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xC8,0x83,0xE1,0x0F,0x88,0x0A,0xC1,0xF8,0x04,0x41,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ValueTuple<sbyte,sbyte> split(short src, N2 parts)
; location: [7FFDDBAC72D0h, 7FFDDBAC72FDh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,al                  ; MOVSX(Movsx_r64_rm8) [RDX,AL]                        encoding(4 bytes) = 48 0f be d0
000dh mov byte ptr [rsp],0          ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(4 bytes) = c6 04 24 00
0011h mov byte ptr [rsp+1],0        ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 01 00
0016h mov [rsp],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(3 bytes) = 88 14 24
0019h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
001ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0020h mov [rsp+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 01
0024h movsx rax,word ptr [rsp]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RSP:br,SS:sr)]    encoding(5 bytes) = 48 0f bf 04 24
0029h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[46]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBE,0xD0,0xC6,0x04,0x24,0x00,0xC6,0x44,0x24,0x01,0x00,0x88,0x14,0x24,0xC1,0xF8,0x08,0x48,0x0F,0xBE,0xC0,0x88,0x44,0x24,0x01,0x48,0x0F,0xBF,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ushort src, out byte x0, out byte x1)
; location: [7FFDDBAC7320h, 7FFDDBAC7330h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]            encoding(2 bytes) = 88 0a
0007h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
000ah sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
000dh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x88,0x0A,0x0F,0xB7,0xC1,0xC1,0xF8,0x08,0x41,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ValueTuple<short,short> split(int src, N2 parts)
; location: [7FFDDBAC7750h, 7FFDDBAC777Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov word ptr [rsp],0          ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,SS:sr),0h:imm16] encoding(6 bytes) = 66 c7 04 24 00 00
000fh mov word ptr [rsp+2],0        ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,SS:sr),0h:imm16] encoding(7 bytes) = 66 c7 44 24 02 00 00
0016h mov [rsp],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),AX]         encoding(4 bytes) = 66 89 04 24
001ah sar ecx,10h                   ; SAR(Sar_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 f9 10
001dh movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0021h mov [rsp+2],ax                ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),AX]         encoding(5 bytes) = 66 89 44 24 02
0026h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0029h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[46]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x0F,0xBF,0xC1,0x66,0xC7,0x04,0x24,0x00,0x00,0x66,0xC7,0x44,0x24,0x02,0x00,0x00,0x66,0x89,0x04,0x24,0xC1,0xF9,0x10,0x48,0x0F,0xBF,0xC1,0x66,0x89,0x44,0x24,0x02,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(uint src, out ushort x0, out ushort x1)
; location: [7FFDDBAC77A0h, 7FFDDBAC77AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),CX]         encoding(3 bytes) = 66 89 0a
0008h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
000bh mov [r8],cx                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),CX]          encoding(4 bytes) = 66 41 89 08
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x66,0x89,0x0A,0xC1,0xE9,0x10,0x66,0x41,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(long src, out int x0, out int x1)
; location: [7FFDDBAC77C0h, 7FFDDBAC77D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
0007h sar rcx,20h                   ; SAR(Sar_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 f9 20
000bh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000dh mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x0A,0x48,0xC1,0xF9,0x20,0x8B,0xC1,0x41,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ulong src, out uint x0, out uint x1)
; location: [7FFDDBAC77F0h, 7FFDDBAC7800h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
0007h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
000bh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000dh mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x0A,0x48,0xC1,0xE9,0x20,0x8B,0xC1,0x41,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(uint src, out byte x0, out byte x1, out byte x2, out byte x3)
; location: [7FFDDBAC7820h, 7FFDDBAC7841h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]            encoding(2 bytes) = 88 0a
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
000ch mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
000fh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0011h shr eax,10h                   ; SHR(Shr_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 e8 10
0014h mov [r9],al                   ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),AL]             encoding(3 bytes) = 41 88 01
0017h shr ecx,18h                   ; SHR(Shr_rm32_imm8) [ECX,18h:imm8]                    encoding(3 bytes) = c1 e9 18
001ah mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
001fh mov [rax],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),CL]            encoding(2 bytes) = 88 08
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x88,0x0A,0x8B,0xC1,0xC1,0xE8,0x08,0x41,0x88,0x00,0x8B,0xC1,0xC1,0xE8,0x10,0x41,0x88,0x01,0xC1,0xE9,0x18,0x48,0x8B,0x44,0x24,0x28,0x88,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ulong src, out byte x0, out byte x1, out byte x2, out byte x3, out byte x4, out byte x5, out byte x6, out byte x7)
; location: [7FFDDBAC7860h, 7FFDDBAC78BEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]            encoding(2 bytes) = 88 0a
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah shr rax,8                     ; SHR(Shr_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e8 08
000eh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h shr rax,10h                   ; SHR(Shr_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e8 10
0018h mov [r9],al                   ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),AL]             encoding(3 bytes) = 41 88 01
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh shr rax,18h                   ; SHR(Shr_rm64_imm8) [RAX,18h:imm8]                    encoding(4 bytes) = 48 c1 e8 18
0022h mov rdx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 28
0027h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0029h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ch shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0030h mov rdx,[rsp+30h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 30
0035h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah shr rax,28h                   ; SHR(Shr_rm64_imm8) [RAX,28h:imm8]                    encoding(4 bytes) = 48 c1 e8 28
003eh mov rdx,[rsp+38h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 38
0043h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0045h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0048h shr rax,30h                   ; SHR(Shr_rm64_imm8) [RAX,30h:imm8]                    encoding(4 bytes) = 48 c1 e8 30
004ch mov rdx,[rsp+40h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 40
0051h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0053h shr rcx,38h                   ; SHR(Shr_rm64_imm8) [RCX,38h:imm8]                    encoding(4 bytes) = 48 c1 e9 38
0057h mov rax,[rsp+48h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 48
005ch mov [rax],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),CL]            encoding(2 bytes) = 88 08
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[95]{0x0F,0x1F,0x44,0x00,0x00,0x88,0x0A,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x08,0x41,0x88,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x10,0x41,0x88,0x01,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x18,0x48,0x8B,0x54,0x24,0x28,0x88,0x02,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x20,0x48,0x8B,0x54,0x24,0x30,0x88,0x02,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x28,0x48,0x8B,0x54,0x24,0x38,0x88,0x02,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x30,0x48,0x8B,0x54,0x24,0x40,0x88,0x02,0x48,0xC1,0xE9,0x38,0x48,0x8B,0x44,0x24,0x48,0x88,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(uint src, int index, out uint x0, out uint x1)
; location: [7FFDDBAC78D0h, 7FFDDBAC7906h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rdx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RDX:br,DS:sr)]       encoding(3 bytes) = 8d 42 ff
0008h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000bh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0016h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0019h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
001bh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001dh add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0026h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0029h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
002bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
002eh bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0033h mov [r9],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 01
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x42,0xFF,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0x41,0x89,0x00,0x8B,0xC2,0xF7,0xD8,0x83,0xC0,0x1F,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0x41,0x89,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ulong src, int index, out ulong x0, out ulong x1)
; location: [7FFDDBAC7920h, 7FFDDBAC7956h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rdx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RDX:br,DS:sr)]       encoding(3 bytes) = 8d 42 ff
0008h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000bh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0016h mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
0019h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
001bh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001dh add eax,3Fh                   ; ADD(Add_rm32_imm8) [EAX,3fh:imm32]                   encoding(3 bytes) = 83 c0 3f
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0026h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0029h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
002bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
002eh bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0033h mov [r9],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 01
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x42,0xFF,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0x49,0x89,0x00,0x8B,0xC2,0xF7,0xD8,0x83,0xC0,0x3F,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0x49,0x89,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(sbyte src, int pos)
; location: [7FFDDBAC7970h, 7FFDDBAC79A2h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
0012h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0015h jb short 001bh                ; JB(Jb_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 72 04
0017h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0019h jmp short 0020h               ; JMP(Jmp_rel8_64) [20h:jmp64]                         encoding(2 bytes) = eb 05
001bh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0020h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0022h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0025h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0028h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[51]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x0F,0xBE,0xC9,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(byte src, int pos)
; location: [7FFDDBAC79C0h, 7FFDDBAC79F1h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0011h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0014h jb short 001ah                ; JB(Jb_rel8_64) [1Ah:jmp64]                           encoding(2 bytes) = 72 04
0016h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0018h jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 05
001ah mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001fh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0021h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0024h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0027h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
002ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[50]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x0F,0xB6,0xC9,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(short src, int pos)
; location: [7FFDDBAC7A10h, 7FFDDBAC7A42h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
0012h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0015h jb short 001bh                ; JB(Jb_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 72 04
0017h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0019h jmp short 0020h               ; JMP(Jmp_rel8_64) [20h:jmp64]                         encoding(2 bytes) = eb 05
001bh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0020h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0022h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0025h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0028h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[51]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x0F,0xBF,0xC9,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(ushort src, int pos)
; location: [7FFDDBAC7A60h, 7FFDDBAC7A91h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0011h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0014h jb short 001ah                ; JB(Jb_rel8_64) [1Ah:jmp64]                           encoding(2 bytes) = 72 04
0016h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0018h jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 05
001ah mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001fh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0021h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0024h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0027h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
002ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[50]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x0F,0xB7,0xC9,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(int src, int pos)
; location: [7FFDDBAC7AB0h, 7FFDDBAC7ADEh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0011h jb short 0017h                ; JB(Jb_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 72 04
0013h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0015h jmp short 001ch               ; JMP(Jmp_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = eb 05
0017h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001ch mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
001eh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0021h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0024h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[47]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(uint src, int pos)
; location: [7FFDDBAC7B00h, 7FFDDBAC7B2Eh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0011h jb short 0017h                ; JB(Jb_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 72 04
0013h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0015h jmp short 001ch               ; JMP(Jmp_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = eb 05
0017h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001ch mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
001eh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0021h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0024h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[47]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(long src, int pos)
; location: [7FFDDBAC7B50h, 7FFDDBAC7B5Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(ulong src, int pos)
; location: [7FFDDBAC7B70h, 7FFDDBAC7B9Fh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0012h jb short 0018h                ; JB(Jb_rel8_64) [18h:jmp64]                           encoding(2 bytes) = 72 04
0014h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0016h jmp short 001dh               ; JMP(Jmp_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = eb 05
0018h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001dh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
001fh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0022h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[48]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(float src, int pos)
; location: [7FFDDBAC7BC0h, 7FFDDBAC7BFDh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0011h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0013h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0017h lea rcx,[rsp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 08
001ch bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
001fh jb short 0025h                ; JB(Jb_rel8_64) [25h:jmp64]                           encoding(2 bytes) = 72 04
0021h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0023h jmp short 002ah               ; JMP(Jmp_rel8_64) [2Ah:jmp64]                         encoding(2 bytes) = eb 05
0025h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
002ah mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
002ch mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
0030h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0033h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0036h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0039h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[62]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x33,0xC9,0x89,0x4C,0x24,0x08,0x48,0x8D,0x4C,0x24,0x08,0x0F,0xA3,0xD0,0x72,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x01,0x8B,0x44,0x24,0x08,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(double src, int pos)
; location: [7FFDDBAC7C20h, 7FFDDBAC7C5Fh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0014h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0018h lea rcx,[rsp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 08
001dh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0021h jb short 0027h                ; JB(Jb_rel8_64) [27h:jmp64]                           encoding(2 bytes) = 72 04
0023h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0025h jmp short 002ch               ; JMP(Jmp_rel8_64) [2Ch:jmp64]                         encoding(2 bytes) = eb 05
0027h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
002ch mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
002eh mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
0032h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0035h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0038h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003bh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[64]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0x33,0xC9,0x89,0x4C,0x24,0x08,0x48,0x8D,0x4C,0x24,0x08,0x48,0x0F,0xA3,0xD0,0x72,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x01,0x8B,0x44,0x24,0x08,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte toggle(sbyte src, int pos)
; location: [7FFDDBAC7C80h, 7FFDDBAC7CA2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0011h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0014h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0018h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001ah movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001eh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte toggle(byte src, int pos)
; location: [7FFDDBAC7CC0h, 7FFDDBAC7CDFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0017h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short toggle(short src, int pos)
; location: [7FFDDBAC7CF0h, 7FFDDBAC7D12h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0011h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0014h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0018h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001ah movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001eh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort toggle(ushort src, int pos)
; location: [7FFDDBAC7D30h, 7FFDDBAC7D4Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0017h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0019h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x33,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int toggle(int src, int pos)
; location: [7FFDDBAC7D60h, 7FFDDBAC7D75h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000fh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0012h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint toggle(uint src, int pos)
; location: [7FFDDBAC7D90h, 7FFDDBAC7DA5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000fh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0012h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long toggle(long src, int pos)
; location: [7FFDDBAC7DC0h, 7FFDDBAC7DD6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong toggle(ulong src, int pos)
; location: [7FFDDBAC7DF0h, 7FFDDBAC7E06h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float toggle(float src, int pos)
; location: [7FFDDBAC7E20h, 7FFDDBAC7E44h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss dword ptr [rsp+8],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 08
000bh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0010h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0016h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0018h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
001bh xor [rax],r8d                 ; XOR(Xor_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(3 bytes) = 44 31 00
001eh vmovss xmm0,dword ptr [rsp+8] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[37]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x11,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x31,0x00,0xC5,0xFA,0x10,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double toggle(double src, int pos)
; location: [7FFDDBAC7E60h, 7FFDDBAC7E84h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
000bh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0010h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0016h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0018h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
001bh xor [rax],r8                  ; XOR(Xor_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 31 00
001eh vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[37]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x31,0x00,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte toggle(ref sbyte src, int pos)
; location: [7FFDDBAC7EA0h, 7FFDDBAC7EB9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0017h xor [rax],dl                  ; XOR(Xor_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 30 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x30,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte toggle(ref byte src, int pos)
; location: [7FFDDBAC7ED0h, 7FFDDBAC7EE9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0017h xor [rax],dl                  ; XOR(Xor_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 30 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x30,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short toggle(ref short src, int pos)
; location: [7FFDDBAC7F00h, 7FFDDBAC7F1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0017h xor [rax],dx                  ; XOR(Xor_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 31 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x66,0x31,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort toggle(ref ushort src, int pos)
; location: [7FFDDBAC7F30h, 7FFDDBAC7F4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0017h xor [rax],dx                  ; XOR(Xor_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 31 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x66,0x31,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int toggle(ref int src, int pos)
; location: [7FFDDBAC7F60h, 7FFDDBAC7F76h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h xor [rax],r8d                 ; XOR(Xor_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(3 bytes) = 44 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint toggle(ref uint src, int pos)
; location: [7FFDDBAC7F90h, 7FFDDBAC7FA6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h xor [rax],r8d                 ; XOR(Xor_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(3 bytes) = 44 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long toggle(ref long src, int pos)
; location: [7FFDDBAC7FC0h, 7FFDDBAC7FD6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor [rax],r8                  ; XOR(Xor_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong toggle(ref ulong src, int pos)
; location: [7FFDDBAC7FF0h, 7FFDDBAC8006h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor [rax],r8                  ; XOR(Xor_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float toggle(ref float src, int pos)
; location: [7FFDDBAC8020h, 7FFDDBAC8036h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h xor [rax],r8d                 ; XOR(Xor_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(3 bytes) = 44 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double toggle(ref double src, int pos)
; location: [7FFDDBAC8050h, 7FFDDBAC8066h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor [rax],r8                  ; XOR(Xor_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitSize width(in byte src)
; location: [7FFDDBAC8080h, 7FFDDBAC8094h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFE8h            ; ADD(Add_rm32_imm8) [EAX,ffffffffffffffe8h:imm32]     encoding(3 bytes) = 83 c0 e8
000fh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0011h add eax,8                     ; ADD(Add_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 c0 08
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xE8,0xF7,0xD8,0x83,0xC0,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitSize width(in ushort src)
; location: [7FFDDBAC80B0h, 7FFDDBAC80C4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [EAX,fffffffffffffff0h:imm32]     encoding(3 bytes) = 83 c0 f0
000fh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0011h add eax,10h                   ; ADD(Add_rm32_imm8) [EAX,10h:imm32]                   encoding(3 bytes) = 83 c0 10
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xF0,0xF7,0xD8,0x83,0xC0,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitSize width(in uint src)
; location: [7FFDDBAC80E0h, 7FFDDBAC80F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt eax,[rcx]               ; LZCNT(Lzcnt_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]    encoding(4 bytes) = f3 0f bd 01
000bh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000dh add eax,20h                   ; ADD(Add_rm32_imm8) [EAX,20h:imm32]                   encoding(3 bytes) = 83 c0 20
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBD,0x01,0xF7,0xD8,0x83,0xC0,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitSize width(in ulong src)
; location: [7FFDDBAC8110h, 7FFDDBAC8121h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt rax,[rcx]               ; LZCNT(Lzcnt_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]    encoding(5 bytes) = f3 48 0f bd 01
000ch neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000eh add eax,40h                   ; ADD(Add_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 c0 40
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBD,0x01,0xF7,0xD8,0x83,0xC0,0x40,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xorsl(sbyte src, int offset)
; location: [7FFDDBAC8140h, 7FFDDBAC815Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000eh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0011h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0015h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0017h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xorsl(byte src, int offset)
; location: [7FFDDBAC8170h, 7FFDDBAC8189h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0014h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xorsl(short src, int offset)
; location: [7FFDDBAC81A0h, 7FFDDBAC81BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000eh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0011h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0015h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0017h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xorsl(ushort src, int offset)
; location: [7FFDDBAC81D0h, 7FFDDBAC81E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0014h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0016h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xorsl(int src, int offset)
; location: [7FFDDBAC8200h, 7FFDDBAC8212h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
000fh xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xorsl(uint src, int offset)
; location: [7FFDDBAC8230h, 7FFDDBAC8242h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
000fh xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xorsl(long src, int offset)
; location: [7FFDDBAC8260h, 7FFDDBAC8273h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
000dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0010h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x4C,0x8B,0xC0,0x49,0xD3,0xE0,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xorsl(ulong src, int offset)
; location: [7FFDDBAC8290h, 7FFDDBAC82A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
000dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0010h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x4C,0x8B,0xC0,0x49,0xD3,0xE0,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte xorsl(ref sbyte src, int offset)
; location: [7FFDDBAC82C0h, 7FFDDBAC82DDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,byte ptr [rax]       ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 0f be 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0014h movsx rdx,r9b                 ; MOVSX(Movsx_r64_rm8) [RDX,R9L]                       encoding(4 bytes) = 49 0f be d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBE,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE1,0x49,0x0F,0xBE,0xD1,0x41,0x33,0xD0,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte xorsl(ref byte src, int offset)
; location: [7FFDDBAC82F0h, 7FFDDBAC830Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0014h movzx edx,r9b                 ; MOVZX(Movzx_r32_rm8) [EDX,R9L]                       encoding(4 bytes) = 41 0f b6 d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB6,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE1,0x41,0x0F,0xB6,0xD1,0x41,0x33,0xD0,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short xorsl(ref short src, int offset)
; location: [7FFDDBAC8320h, 7FFDDBAC833Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,word ptr [rax]       ; MOVSX(Movsx_r64_rm16) [R8,mem(16i,RAX:br,DS:sr)]     encoding(4 bytes) = 4c 0f bf 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0014h movsx rdx,r9w                 ; MOVSX(Movsx_r64_rm16) [RDX,R9W]                      encoding(4 bytes) = 49 0f bf d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBF,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE1,0x49,0x0F,0xBF,0xD1,0x41,0x33,0xD0,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort xorsl(ref ushort src, int offset)
; location: [7FFDDBAC8350h, 7FFDDBAC836Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RAX:br,DS:sr)]    encoding(4 bytes) = 44 0f b7 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0014h movzx edx,r9w                 ; MOVZX(Movzx_r32_rm16) [EDX,R9W]                      encoding(4 bytes) = 41 0f b7 d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB7,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE1,0x41,0x0F,0xB7,0xD1,0x41,0x33,0xD0,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int xorsl(ref int src, int offset)
; location: [7FFDDBAC8380h, 7FFDDBAC8399h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0010h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0013h xor r9d,r8d                   ; XOR(Xor_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 33 c8
0016h mov [rax],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE1,0x45,0x33,0xC8,0x44,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint xorsl(ref uint src, int offset)
; location: [7FFDDBAC83B0h, 7FFDDBAC83C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0010h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0013h xor r9d,r8d                   ; XOR(Xor_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 33 c8
0016h mov [rax],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE1,0x45,0x33,0xC8,0x44,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long xorsl(ref long src, int offset)
; location: [7FFDDBAC83E0h, 7FFDDBAC83F9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9,r8                     ; MOV(Mov_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 8b c8
0010h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0013h xor r9,r8                     ; XOR(Xor_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 33 c8
0016h mov [rax],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x00,0x8B,0xCA,0x4D,0x8B,0xC8,0x49,0xD3,0xE1,0x4D,0x33,0xC8,0x4C,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong xorsl(ref ulong src, int offset)
; location: [7FFDDBAC8410h, 7FFDDBAC8429h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9,r8                     ; MOV(Mov_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 8b c8
0010h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0013h xor r9,r8                     ; XOR(Xor_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 33 c8
0016h mov [rax],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x00,0x8B,0xCA,0x4D,0x8B,0xC8,0x49,0xD3,0xE1,0x4D,0x33,0xC8,0x4C,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xorsr(sbyte src, int offset)
; location: [7FFDDBAC8440h, 7FFDDBAC845Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000eh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0011h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0015h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0017h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x49,0x0F,0xBE,0xD0,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xorsr(byte src, int offset)
; location: [7FFDDBAC8470h, 7FFDDBAC8489h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0014h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xorsr(short src, int offset)
; location: [7FFDDBAC84A0h, 7FFDDBAC84BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000eh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0011h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0015h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0017h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x49,0x0F,0xBF,0xD0,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xorsr(ushort src, int offset)
; location: [7FFDDBAC84D0h, 7FFDDBAC84E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0014h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0016h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x41,0x0F,0xB7,0xD0,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xorsr(int src, int offset)
; location: [7FFDDBAC8500h, 7FFDDBAC8512h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
000fh xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xorsr(uint src, int offset)
; location: [7FFDDBAC8530h, 7FFDDBAC8542h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
000fh xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE8,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xorsr(long src, int offset)
; location: [7FFDDBAC8560h, 7FFDDBAC8573h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
000dh sar r8,cl                     ; SAR(Sar_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 f8
0010h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x4C,0x8B,0xC0,0x49,0xD3,0xF8,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xorsr(ulong src, int offset)
; location: [7FFDDBAC8590h, 7FFDDBAC85A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
000dh shr r8,cl                     ; SHR(Shr_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e8
0010h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x4C,0x8B,0xC0,0x49,0xD3,0xE8,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte xorsr(ref sbyte src, int offset)
; location: [7FFDDBAC85C0h, 7FFDDBAC85DDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,byte ptr [rax]       ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 0f be 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h sar r9d,cl                    ; SAR(Sar_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 f9
0014h movsx rdx,r9b                 ; MOVSX(Movsx_r64_rm8) [RDX,R9L]                       encoding(4 bytes) = 49 0f be d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBE,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xF9,0x49,0x0F,0xBE,0xD1,0x41,0x33,0xD0,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte xorsr(ref byte src, int offset)
; location: [7FFDDBAC85F0h, 7FFDDBAC860Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h sar r9d,cl                    ; SAR(Sar_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 f9
0014h movzx edx,r9b                 ; MOVZX(Movzx_r32_rm8) [EDX,R9L]                       encoding(4 bytes) = 41 0f b6 d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB6,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xF9,0x41,0x0F,0xB6,0xD1,0x41,0x33,0xD0,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short xorsr(ref short src, int offset)
; location: [7FFDDBAC8620h, 7FFDDBAC863Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,word ptr [rax]       ; MOVSX(Movsx_r64_rm16) [R8,mem(16i,RAX:br,DS:sr)]     encoding(4 bytes) = 4c 0f bf 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h sar r9d,cl                    ; SAR(Sar_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 f9
0014h movsx rdx,r9w                 ; MOVSX(Movsx_r64_rm16) [RDX,R9W]                      encoding(4 bytes) = 49 0f bf d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBF,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xF9,0x49,0x0F,0xBF,0xD1,0x41,0x33,0xD0,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort xorsr(ref ushort src, int offset)
; location: [7FFDDBAC8650h, 7FFDDBAC866Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RAX:br,DS:sr)]    encoding(4 bytes) = 44 0f b7 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h sar r9d,cl                    ; SAR(Sar_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 f9
0014h movzx edx,r9w                 ; MOVZX(Movzx_r32_rm16) [EDX,R9W]                      encoding(4 bytes) = 41 0f b7 d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB7,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xF9,0x41,0x0F,0xB7,0xD1,0x41,0x33,0xD0,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int xorsr(ref int src, int offset)
; location: [7FFDDBAC8680h, 7FFDDBAC8699h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0010h sar r9d,cl                    ; SAR(Sar_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 f9
0013h xor r9d,r8d                   ; XOR(Xor_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 33 c8
0016h mov [rax],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xF9,0x45,0x33,0xC8,0x44,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint xorsr(ref uint src, int offset)
; location: [7FFDDBAC86B0h, 7FFDDBAC86C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0010h shr r9d,cl                    ; SHR(Shr_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e9
0013h xor r9d,r8d                   ; XOR(Xor_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 33 c8
0016h mov [rax],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE9,0x45,0x33,0xC8,0x44,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long xorsr(ref long src, int offset)
; location: [7FFDDBAC86E0h, 7FFDDBAC86F9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9,r8                     ; MOV(Mov_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 8b c8
0010h sar r9,cl                     ; SAR(Sar_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 f9
0013h xor r9,r8                     ; XOR(Xor_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 33 c8
0016h mov [rax],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x00,0x8B,0xCA,0x4D,0x8B,0xC8,0x49,0xD3,0xF9,0x4D,0x33,0xC8,0x4C,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong xorsr(ref ulong src, int offset)
; location: [7FFDDBAC8710h, 7FFDDBAC8729h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9,r8                     ; MOV(Mov_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 8b c8
0010h shr r9,cl                     ; SHR(Shr_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e9
0013h xor r9,r8                     ; XOR(Xor_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 33 c8
0016h mov [rax],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x00,0x8B,0xCA,0x4D,0x8B,0xC8,0x49,0xD3,0xE9,0x4D,0x33,0xC8,0x4C,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int lo(long src)
; location: [7FFDDBAC8740h, 7FFDDBAC8747h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint lo(ulong src)
; location: [7FFDDBAC8760h, 7FFDDBAC8767h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte loff(ref sbyte src)
; location: [7FFDDBAC8780h, 7FFDDBAC8797h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000ch movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0010h and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0012h mov [rcx],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),DL]            encoding(2 bytes) = 88 11
0014h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x8D,0x50,0xFF,0x48,0x0F,0xBE,0xD2,0x23,0xD0,0x88,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte loff(ref byte src)
; location: [7FFDDBAC87B0h, 7FFDDBAC87C5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000eh and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0010h mov [rcx],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),DL]            encoding(2 bytes) = 88 11
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x8D,0x50,0xFF,0x0F,0xB6,0xD2,0x23,0xD0,0x88,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short loff(ref short src)
; location: [7FFDDBAC87E0h, 7FFDDBAC87F8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000ch movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
0010h and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0012h mov [rcx],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 11
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x8D,0x50,0xFF,0x48,0x0F,0xBF,0xD2,0x23,0xD0,0x66,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort loff(ref ushort src)
; location: [7FFDDBAC8810h, 7FFDDBAC8826h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000eh and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0010h mov [rcx],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 11
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x8D,0x50,0xFF,0x0F,0xB7,0xD2,0x23,0xD0,0x66,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int loff(ref int src)
; location: [7FFDDBAC8840h, 7FFDDBAC8851h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000ah and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
000ch mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8D,0x50,0xFF,0x23,0xD0,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint loff(ref uint src)
; location: [7FFDDBAC8870h, 7FFDDBAC8881h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000ah and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
000ch mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8D,0x50,0xFF,0x23,0xD0,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long loff(ref long src)
; location: [7FFDDBAC88A0h, 7FFDDBAC88B5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h lea rdx,[rax-1]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 ff
000ch and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
000fh mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8D,0x50,0xFF,0x48,0x23,0xD0,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong loff(ref ulong src)
; location: [7FFDDBAC88D0h, 7FFDDBAC88E5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h lea rdx,[rax-1]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 ff
000ch and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
000fh mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8D,0x50,0xFF,0x48,0x23,0xD0,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint log2(byte src)
; location: [7FFDDBAC8900h, 7FFDDBAC8919h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 04
000ch xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000eh jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 09
0010h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
0014h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0016h add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint log2(ushort src)
; location: [7FFDDBAC8930h, 7FFDDBAC8949h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 04
000ch xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000eh jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 09
0010h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
0014h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0016h add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint log2(uint src)
; location: [7FFDDBAC8960h, 7FFDDBAC8978h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h jne short 000dh               ; JNE(Jne_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = 75 04
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh jmp short 0018h               ; JMP(Jmp_rel8_64) [18h:jmp64]                         encoding(2 bytes) = eb 0b
000dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000fh lzcnt eax,ecx                 ; LZCNT(Lzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bd c1
0013h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0015h add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x75,0x04,0x33,0xC0,0xEB,0x0B,0x33,0xC0,0xF3,0x0F,0xBD,0xC1,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint log2(ulong src)
; location: [7FFDDBAC8990h, 7FFDDBAC89AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h jne short 000eh               ; JNE(Jne_rel8_64) [Eh:jmp64]                          encoding(2 bytes) = 75 04
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch jmp short 001ah               ; JMP(Jmp_rel8_64) [1Ah:jmp64]                         encoding(2 bytes) = eb 0c
000eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0010h lzcnt rax,rcx                 ; LZCNT(Lzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bd c1
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,3Fh                   ; ADD(Add_rm32_imm8) [EAX,3fh:imm32]                   encoding(3 bytes) = 83 c0 3f
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x75,0x04,0x33,0xC0,0xEB,0x0C,0x33,0xC0,0xF3,0x48,0x0F,0xBD,0xC1,0xF7,0xD8,0x83,0xC0,0x3F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0)
; location: [7FFDDBAC89C0h, 7FFDDBAC89D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]           encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1)
; location: [7FFDDBAC89F0h, 7FFDDBAC8A14h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0013h or [rax],r9                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]           encoding(3 bytes) = 4c 09 08
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x4C,0x09,0x08,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2)
; location: [7FFDDBAC8A30h, 7FFDDBAC8A62h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R10]          encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3)
; location: [7FFDDBAC8A80h, 7FFDDBAC8AC1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R10]          encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0032h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0037h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 28
003bh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003eh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4)
; location: [7FFDDBAC8AE0h, 7FFDDBAC8B30h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R10]          encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0032h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0037h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 28
003bh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003eh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0041h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0046h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
004ah shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
004dh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[81]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x48,0xD3,0xE2,0x48,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
; location: [7FFDDBAC8B50h, 7FFDDBAC8BAFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R10]          encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0032h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0037h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 28
003bh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003eh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0041h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0046h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
004ah shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
004dh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0050h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0055h mov ecx,[rsp+38h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 38
0059h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
005ch or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[96]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x38,0x48,0xD3,0xE2,0x48,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
; location: [7FFDDBAC8BC0h, 7FFDDBAC8C2Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R10]          encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0032h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0037h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 28
003bh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003eh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0041h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0046h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
004ah shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
004dh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0050h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0055h mov ecx,[rsp+38h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 38
0059h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
005ch or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
005fh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0064h mov ecx,[rsp+40h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 40
0068h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
006bh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
006eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[111]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x38,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x40,0x48,0xD3,0xE2,0x48,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6, int exp7)
; location: [7FFDDBAC8C40h, 7FFDDBAC8CB9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or r10,[rax]                  ; OR(Or_r64_rm64) [R10,mem(64u,RAX:br,DS:sr)]          encoding(3 bytes) = 4c 0b 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or rdx,r10                    ; OR(Or_r64_rm64) [RDX,R10]                            encoding(3 bytes) = 49 0b d2
0024h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
002ah mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0030h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0033h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0039h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 28
003dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0040h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0043h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0049h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
004dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0050h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0053h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0059h mov ecx,[rsp+40h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 40
005dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0060h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0063h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0066h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
006ch mov ecx,[rsp+48h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 48
0070h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0073h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0076h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0079h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[122]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x0B,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x49,0x0B,0xD2,0x41,0xB8,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x40,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x48,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint nlz(in byte src)
; location: [7FFDDBAC8CD0h, 7FFDDBAC8CDFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFE8h            ; ADD(Add_rm32_imm8) [EAX,ffffffffffffffe8h:imm32]     encoding(3 bytes) = 83 c0 e8
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint nlz(in ushort src)
; location: [7FFDDBAC8CF0h, 7FFDDBAC8CFFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [EAX,fffffffffffffff0h:imm32]     encoding(3 bytes) = 83 c0 f0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint nlz(in uint src)
; location: [7FFDDBAC8D10h, 7FFDDBAC8D1Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt eax,[rcx]               ; LZCNT(Lzcnt_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]    encoding(4 bytes) = f3 0f bd 01
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBD,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint nlz(in ulong src)
; location: [7FFDDBAC8D30h, 7FFDDBAC8D3Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt rax,[rcx]               ; LZCNT(Lzcnt_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]    encoding(5 bytes) = f3 48 0f bd 01
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBD,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(sbyte src)
; location: [7FFDDBAC8D50h, 7FFDDBAC8D5Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(byte src)
; location: [7FFDDBAC8D70h, 7FFDDBAC8D7Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(short src)
; location: [7FFDDBAC8D90h, 7FFDDBAC8D9Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(ushort src)
; location: [7FFDDBAC8DB0h, 7FFDDBAC8DBCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(int src)
; location: [7FFDDBAC8DD0h, 7FFDDBAC8DDBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt eax,ecx                 ; TZCNT(Tzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bc c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(uint src)
; location: [7FFDDBAC8DF0h, 7FFDDBAC8DFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt eax,ecx                 ; TZCNT(Tzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bc c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(long src)
; location: [7FFDDBAC8E10h, 7FFDDBAC8E1Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt rax,rcx                 ; TZCNT(Tzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bc c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(ulong src)
; location: [7FFDDBAC8E30h, 7FFDDBAC8E3Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt rax,rcx                 ; TZCNT(Tzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bc c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pack(byte x0, byte x1)
; location: [7FFDDBAC8E50h, 7FFDDBAC8E63h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(ushort x0, ushort x1)
; location: [7FFDDBAC8E80h, 7FFDDBAC8E90h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC1,0xE2,0x10,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(in uint x0, in uint x1)
; location: [7FFDDBAC8EB0h, 7FFDDBAC8EC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0009h shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
000dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8B,0x12,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(byte x0, byte x1, byte x2, byte x3)
; location: [7FFDDBAC8EE0h, 7FFDDBAC8F02h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0014h shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
0017h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0019h movzx edx,r9b                 ; MOVZX(Movzx_r32_rm8) [EDX,R9L]                       encoding(4 bytes) = 41 0f b6 d1
001dh shl edx,18h                   ; SHL(Shl_rm32_imm8) [EDX,18h:imm8]                    encoding(3 bytes) = c1 e2 18
0020h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x10,0x0B,0xC2,0x41,0x0F,0xB6,0xD1,0xC1,0xE2,0x18,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(ushort x0, ushort x1, ushort x2, ushort x3)
; location: [7FFDDBAC8F20h, 7FFDDBAC8F46h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
000eh shl rcx,10h                   ; SHL(Shl_rm64_imm8) [RCX,10h:imm8]                    encoding(4 bytes) = 48 c1 e1 10
0012h or rax,rcx                    ; OR(Or_r64_rm64) [RAX,RCX]                            encoding(3 bytes) = 48 0b c1
0015h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0018h shl rcx,20h                   ; SHL(Shl_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e1 20
001ch or rax,rcx                    ; OR(Or_r64_rm64) [RAX,RCX]                            encoding(3 bytes) = 48 0b c1
001fh shl rdx,30h                   ; SHL(Shl_rm64_imm8) [RDX,30h:imm8]                    encoding(4 bytes) = 48 c1 e2 30
0023h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x48,0x8B,0xCA,0x48,0xC1,0xE1,0x10,0x48,0x0B,0xC1,0x48,0x8B,0xCA,0x48,0xC1,0xE1,0x20,0x48,0x0B,0xC1,0x48,0xC1,0xE2,0x30,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
; location: [7FFDDBAC8F60h, 7FFDDBAC8FC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh shl rdx,8                     ; SHL(Shl_rm64_imm8) [RDX,8h:imm8]                     encoding(4 bytes) = 48 c1 e2 08
000fh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0012h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0016h shl rdx,10h                   ; SHL(Shl_rm64_imm8) [RDX,10h:imm8]                    encoding(4 bytes) = 48 c1 e2 10
001ah or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
001dh movzx edx,r9b                 ; MOVZX(Movzx_r32_rm8) [EDX,R9L]                       encoding(4 bytes) = 41 0f b6 d1
0021h shl rdx,18h                   ; SHL(Shl_rm64_imm8) [RDX,18h:imm8]                    encoding(4 bytes) = 48 c1 e2 18
0025h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0028h mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
002ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002fh shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
0033h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0036h mov edx,[rsp+30h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 30
003ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003dh shl rdx,28h                   ; SHL(Shl_rm64_imm8) [RDX,28h:imm8]                    encoding(4 bytes) = 48 c1 e2 28
0041h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0044h mov edx,[rsp+38h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 38
0048h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
004bh shl rdx,30h                   ; SHL(Shl_rm64_imm8) [RDX,30h:imm8]                    encoding(4 bytes) = 48 c1 e2 30
004fh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0052h mov edx,[rsp+40h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 40
0056h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0059h shl rdx,38h                   ; SHL(Shl_rm64_imm8) [RDX,38h:imm8]                    encoding(4 bytes) = 48 c1 e2 38
005dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0060h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[97]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x08,0x48,0x0B,0xC2,0x41,0x0F,0xB6,0xD0,0x48,0xC1,0xE2,0x10,0x48,0x0B,0xC2,0x41,0x0F,0xB6,0xD1,0x48,0xC1,0xE2,0x18,0x48,0x0B,0xC2,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0x8B,0x54,0x24,0x30,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x28,0x48,0x0B,0xC2,0x8B,0x54,0x24,0x38,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x30,0x48,0x0B,0xC2,0x8B,0x54,0x24,0x40,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x38,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte pos, ref byte dst)
; location: [7FFDDBAC8FE0h, 7FFDDBAC916Dh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0005h mov rax,[rsp+98h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 98 00 00 00
000dh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0010h mov [rsp+38h],r10d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(5 bytes) = 44 89 54 24 38
0015h lea r10,[rsp+38h]             ; LEA(Lea_r64_m) [R10,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 4c 8d 54 24 38
001ah movzx r11d,cl                 ; MOVZX(Movzx_r32_rm8) [R11D,CL]                       encoding(4 bytes) = 44 0f b6 d9
001eh mov ecx,[rsp+90h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 90 00 00 00
0025h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0028h mov esi,1                     ; MOV(Mov_r32_imm32) [ESI,1h:imm32]                    encoding(5 bytes) = be 01 00 00 00
002dh shl esi,cl                    ; SHL(Shl_rm32_CL) [ESI,CL]                            encoding(2 bytes) = d3 e6
002fh test r11d,esi                 ; TEST(Test_rm32_r32) [ESI,R11D]                       encoding(3 bytes) = 44 85 de
0032h jne short 0038h               ; JNE(Jne_rel8_64) [38h:jmp64]                         encoding(2 bytes) = 75 04
0034h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0036h jmp short 003dh               ; JMP(Jmp_rel8_64) [3Dh:jmp64]                         encoding(2 bytes) = eb 05
0038h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
003dh mov [r10],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,R10:br,DS:sr),ECX]        encoding(3 bytes) = 41 89 0a
0040h mov ecx,[rsp+38h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 38
0044h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0047h jne short 004ch               ; JNE(Jne_rel8_64) [4Ch:jmp64]                         encoding(2 bytes) = 75 03
0049h or byte ptr [rax],1           ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),1h:imm8]       encoding(3 bytes) = 80 08 01
004ch xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
004eh mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
0052h lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0057h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
005ah test edx,esi                  ; TEST(Test_rm32_r32) [ESI,EDX]                        encoding(2 bytes) = 85 d6
005ch jne short 0062h               ; JNE(Jne_rel8_64) [62h:jmp64]                         encoding(2 bytes) = 75 04
005eh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0060h jmp short 0067h               ; JMP(Jmp_rel8_64) [67h:jmp64]                         encoding(2 bytes) = eb 05
0062h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0067h mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
0069h mov edx,[rsp+30h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 30
006dh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0070h jne short 0075h               ; JNE(Jne_rel8_64) [75h:jmp64]                         encoding(2 bytes) = 75 03
0072h or byte ptr [rax],2           ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),2h:imm8]       encoding(3 bytes) = 80 08 02
0075h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0077h mov [rsp+28h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 28
007bh lea rdx,[rsp+28h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 28
0080h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0084h test ecx,esi                  ; TEST(Test_rm32_r32) [ESI,ECX]                        encoding(2 bytes) = 85 ce
0086h jne short 008ch               ; JNE(Jne_rel8_64) [8Ch:jmp64]                         encoding(2 bytes) = 75 04
0088h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
008ah jmp short 0091h               ; JMP(Jmp_rel8_64) [91h:jmp64]                         encoding(2 bytes) = eb 05
008ch mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0091h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
0093h mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
0097h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
009ah jne short 009fh               ; JNE(Jne_rel8_64) [9Fh:jmp64]                         encoding(2 bytes) = 75 03
009ch or byte ptr [rax],4           ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),4h:imm8]       encoding(3 bytes) = 80 08 04
009fh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
00a1h mov [rsp+20h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 20
00a5h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
00aah movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
00aeh test ecx,esi                  ; TEST(Test_rm32_r32) [ESI,ECX]                        encoding(2 bytes) = 85 ce
00b0h jne short 00b6h               ; JNE(Jne_rel8_64) [B6h:jmp64]                         encoding(2 bytes) = 75 04
00b2h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
00b4h jmp short 00bbh               ; JMP(Jmp_rel8_64) [BBh:jmp64]                         encoding(2 bytes) = eb 05
00b6h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
00bbh mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
00bdh mov edx,[rsp+20h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 20
00c1h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
00c4h jne short 00c9h               ; JNE(Jne_rel8_64) [C9h:jmp64]                         encoding(2 bytes) = 75 03
00c6h or byte ptr [rax],8           ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),8h:imm8]       encoding(3 bytes) = 80 08 08
00c9h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
00cbh mov [rsp+18h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 18
00cfh lea rdx,[rsp+18h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 18
00d4h mov r8d,[rsp+70h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(5 bytes) = 44 8b 44 24 70
00d9h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
00ddh test ecx,esi                  ; TEST(Test_rm32_r32) [ESI,ECX]                        encoding(2 bytes) = 85 ce
00dfh jne short 00e5h               ; JNE(Jne_rel8_64) [E5h:jmp64]                         encoding(2 bytes) = 75 04
00e1h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
00e3h jmp short 00eah               ; JMP(Jmp_rel8_64) [EAh:jmp64]                         encoding(2 bytes) = eb 05
00e5h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
00eah mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
00ech mov edx,[rsp+18h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 18
00f0h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
00f3h jne short 00f8h               ; JNE(Jne_rel8_64) [F8h:jmp64]                         encoding(2 bytes) = 75 03
00f5h or byte ptr [rax],10h         ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),10h:imm8]      encoding(3 bytes) = 80 08 10
00f8h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
00fah mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
00feh lea rdx,[rsp+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 10
0103h mov r8d,[rsp+78h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(5 bytes) = 44 8b 44 24 78
0108h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
010ch test ecx,esi                  ; TEST(Test_rm32_r32) [ESI,ECX]                        encoding(2 bytes) = 85 ce
010eh jne short 0114h               ; JNE(Jne_rel8_64) [114h:jmp64]                        encoding(2 bytes) = 75 04
0110h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0112h jmp short 0119h               ; JMP(Jmp_rel8_64) [119h:jmp64]                        encoding(2 bytes) = eb 05
0114h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0119h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
011bh mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 10
011fh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0122h jne short 0127h               ; JNE(Jne_rel8_64) [127h:jmp64]                        encoding(2 bytes) = 75 03
0124h or byte ptr [rax],20h         ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),20h:imm8]      encoding(3 bytes) = 80 08 20
0127h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0129h mov [rsp+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 08
012dh lea rdx,[rsp+8]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 08
0132h mov r8d,[rsp+80h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 80 00 00 00
013ah movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
013eh test ecx,esi                  ; TEST(Test_rm32_r32) [ESI,ECX]                        encoding(2 bytes) = 85 ce
0140h jne short 0146h               ; JNE(Jne_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 75 04
0142h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0144h jmp short 014bh               ; JMP(Jmp_rel8_64) [14Bh:jmp64]                        encoding(2 bytes) = eb 05
0146h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
014bh mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
014dh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0151h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0154h jne short 0159h               ; JNE(Jne_rel8_64) [159h:jmp64]                        encoding(2 bytes) = 75 03
0156h or byte ptr [rax],40h         ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),40h:imm8]      encoding(3 bytes) = 80 08 40
0159h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
015bh mov [rsp],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(3 bytes) = 89 14 24
015eh lea rdx,[rsp]                 ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 14 24
0162h mov r8d,[rsp+88h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 88 00 00 00
016ah movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
016eh test ecx,esi                  ; TEST(Test_rm32_r32) [ESI,ECX]                        encoding(2 bytes) = 85 ce
0170h jne short 0176h               ; JNE(Jne_rel8_64) [176h:jmp64]                        encoding(2 bytes) = 75 04
0172h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0174h jmp short 017bh               ; JMP(Jmp_rel8_64) [17Bh:jmp64]                        encoding(2 bytes) = eb 05
0176h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
017bh mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
017dh mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
0180h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0183h jne short 0188h               ; JNE(Jne_rel8_64) [188h:jmp64]                        encoding(2 bytes) = 75 03
0185h or byte ptr [rax],80h         ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),80h:imm8]      encoding(3 bytes) = 80 08 80
0188h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
018ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
018dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[398]{0x56,0x48,0x83,0xEC,0x40,0x48,0x8B,0x84,0x24,0x98,0x00,0x00,0x00,0x45,0x33,0xD2,0x44,0x89,0x54,0x24,0x38,0x4C,0x8D,0x54,0x24,0x38,0x44,0x0F,0xB6,0xD9,0x8B,0x8C,0x24,0x90,0x00,0x00,0x00,0x0F,0xB6,0xC9,0xBE,0x01,0x00,0x00,0x00,0xD3,0xE6,0x44,0x85,0xDE,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x41,0x89,0x0A,0x8B,0x4C,0x24,0x38,0x83,0xF9,0x01,0x75,0x03,0x80,0x08,0x01,0x33,0xC9,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0x0F,0xB6,0xD2,0x85,0xD6,0x75,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x11,0x8B,0x54,0x24,0x30,0x83,0xFA,0x01,0x75,0x03,0x80,0x08,0x02,0x33,0xD2,0x89,0x54,0x24,0x28,0x48,0x8D,0x54,0x24,0x28,0x41,0x0F,0xB6,0xC8,0x85,0xCE,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x89,0x0A,0x8B,0x54,0x24,0x28,0x83,0xFA,0x01,0x75,0x03,0x80,0x08,0x04,0x33,0xD2,0x89,0x54,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x41,0x0F,0xB6,0xC9,0x85,0xCE,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x89,0x0A,0x8B,0x54,0x24,0x20,0x83,0xFA,0x01,0x75,0x03,0x80,0x08,0x08,0x33,0xD2,0x89,0x54,0x24,0x18,0x48,0x8D,0x54,0x24,0x18,0x44,0x8B,0x44,0x24,0x70,0x41,0x0F,0xB6,0xC8,0x85,0xCE,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x89,0x0A,0x8B,0x54,0x24,0x18,0x83,0xFA,0x01,0x75,0x03,0x80,0x08,0x10,0x33,0xD2,0x89,0x54,0x24,0x10,0x48,0x8D,0x54,0x24,0x10,0x44,0x8B,0x44,0x24,0x78,0x41,0x0F,0xB6,0xC8,0x85,0xCE,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x89,0x0A,0x8B,0x54,0x24,0x10,0x83,0xFA,0x01,0x75,0x03,0x80,0x08,0x20,0x33,0xD2,0x89,0x54,0x24,0x08,0x48,0x8D,0x54,0x24,0x08,0x44,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x41,0x0F,0xB6,0xC8,0x85,0xCE,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x89,0x0A,0x8B,0x54,0x24,0x08,0x83,0xFA,0x01,0x75,0x03,0x80,0x08,0x40,0x33,0xD2,0x89,0x14,0x24,0x48,0x8D,0x14,0x24,0x44,0x8B,0x84,0x24,0x88,0x00,0x00,0x00,0x41,0x0F,0xB6,0xC8,0x85,0xCE,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x89,0x0A,0x8B,0x14,0x24,0x83,0xFA,0x01,0x75,0x03,0x80,0x08,0x80,0x48,0x83,0xC4,0x40,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack2(bool b0, bool b1)
; location: [7FFDDBAC9190h, 7FFDDBAC91C8h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0003h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
000dh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
000fh je short 001dh                ; JE(Je_rel8_64) [1Dh:jmp64]                           encoding(2 bytes) = 74 0c
0011h movzx eax,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 04
0016h or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
0019h mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
001dh test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
001fh je short 002dh                ; JE(Je_rel8_64) [2Dh:jmp64]                           encoding(2 bytes) = 74 0c
0021h movzx eax,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 04
0026h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
0029h mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
002dh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
0031h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0034h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack2Bytes => new byte[57]{0x50,0x33,0xC0,0x89,0x44,0x24,0x04,0x33,0xC0,0x89,0x44,0x24,0x04,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x04,0x83,0xC8,0x01,0x88,0x44,0x24,0x04,0x84,0xD2,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x04,0x83,0xC8,0x02,0x88,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack3(bool b0, bool b1, bool b2)
; location: [7FFDDBAC91E0h, 7FFDDBAC9234h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0003h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000fh mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
0012h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0014h je short 0020h                ; JE(Je_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 74 0a
0016h movzx eax,byte ptr [rsp]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(4 bytes) = 0f b6 04 24
001ah or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
001dh mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0020h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
0022h je short 002eh                ; JE(Je_rel8_64) [2Eh:jmp64]                           encoding(2 bytes) = 74 0a
0024h movzx eax,byte ptr [rsp]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(4 bytes) = 0f b6 04 24
0028h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
002bh mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
002eh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0031h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0034h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
0038h test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
003bh je short 0049h                ; JE(Je_rel8_64) [49h:jmp64]                           encoding(2 bytes) = 74 0c
003dh movzx eax,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 04
0042h or eax,4                      ; OR(Or_rm32_imm8) [EAX,4h:imm32]                      encoding(3 bytes) = 83 c8 04
0045h mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
0049h mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
004dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0050h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0054h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack3Bytes => new byte[85]{0x50,0x33,0xC0,0x89,0x44,0x24,0x04,0x89,0x04,0x24,0x33,0xC0,0x89,0x04,0x24,0x89,0x04,0x24,0x84,0xC9,0x74,0x0A,0x0F,0xB6,0x04,0x24,0x83,0xC8,0x01,0x88,0x04,0x24,0x84,0xD2,0x74,0x0A,0x0F,0xB6,0x04,0x24,0x83,0xC8,0x02,0x88,0x04,0x24,0x8B,0x04,0x24,0x0F,0xB6,0xC0,0x89,0x44,0x24,0x04,0x45,0x84,0xC0,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x04,0x83,0xC8,0x04,0x88,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack4(bool b0, bool b1, bool b2, bool b3)
; location: [7FFDDBAC9250h, 7FFDDBAC92D3h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
000ah mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
000eh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0012h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0014h mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
0018h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
001ch mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0020h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0022h je short 0030h                ; JE(Je_rel8_64) [30h:jmp64]                           encoding(2 bytes) = 74 0c
0024h movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
0029h or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
002ch mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0030h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
0032h je short 0040h                ; JE(Je_rel8_64) [40h:jmp64]                           encoding(2 bytes) = 74 0c
0034h movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
0039h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
003ch mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0040h mov eax,[rsp+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 0c
0044h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0047h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
004bh test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
004eh je short 005ch                ; JE(Je_rel8_64) [5Ch:jmp64]                           encoding(2 bytes) = 74 0c
0050h movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
0055h or eax,4                      ; OR(Or_rm32_imm8) [EAX,4h:imm32]                      encoding(3 bytes) = 83 c8 04
0058h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
005ch mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
0060h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0063h mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
0067h test r9b,r9b                  ; TEST(Test_rm8_r8) [R9L,R9L]                          encoding(3 bytes) = 45 84 c9
006ah je short 0078h                ; JE(Je_rel8_64) [78h:jmp64]                           encoding(2 bytes) = 74 0c
006ch movzx eax,byte ptr [rsp+14h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 14
0071h or eax,8                      ; OR(Or_rm32_imm8) [EAX,8h:imm32]                      encoding(3 bytes) = 83 c8 08
0074h mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
0078h mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
007ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
007fh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0083h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack4Bytes => new byte[132]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x89,0x44,0x24,0x14,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x33,0xC0,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x89,0x44,0x24,0x0C,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x01,0x88,0x44,0x24,0x0C,0x84,0xD2,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x02,0x88,0x44,0x24,0x0C,0x8B,0x44,0x24,0x0C,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x45,0x84,0xC0,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x10,0x83,0xC8,0x04,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x89,0x44,0x24,0x14,0x45,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x14,0x83,0xC8,0x08,0x88,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack5(bool b0, bool b1, bool b2, bool b3, bool b4)
; location: [7FFDDBAC92F0h, 7FFDDBAC9399h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
000ah mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
000eh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0012h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 08
0016h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0018h mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
001ch mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0020h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 08
0024h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 08
0028h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
002ah je short 0038h                ; JE(Je_rel8_64) [38h:jmp64]                           encoding(2 bytes) = 74 0c
002ch movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
0031h or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
0034h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0038h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
003ah je short 0048h                ; JE(Je_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 74 0c
003ch movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
0041h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
0044h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0048h mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
004ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004fh mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0053h test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
0056h je short 0064h                ; JE(Je_rel8_64) [64h:jmp64]                           encoding(2 bytes) = 74 0c
0058h movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
005dh or eax,4                      ; OR(Or_rm32_imm8) [EAX,4h:imm32]                      encoding(3 bytes) = 83 c8 04
0060h mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0064h mov eax,[rsp+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 0c
0068h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
006bh mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
006fh test r9b,r9b                  ; TEST(Test_rm8_r8) [R9L,R9L]                          encoding(3 bytes) = 45 84 c9
0072h je short 0080h                ; JE(Je_rel8_64) [80h:jmp64]                           encoding(2 bytes) = 74 0c
0074h movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
0079h or eax,8                      ; OR(Or_rm32_imm8) [EAX,8h:imm32]                      encoding(3 bytes) = 83 c8 08
007ch mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0080h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
0084h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0087h mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
008bh cmp byte ptr [rsp+40h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 40 00
0090h je short 009eh                ; JE(Je_rel8_64) [9Eh:jmp64]                           encoding(2 bytes) = 74 0c
0092h movzx eax,byte ptr [rsp+14h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 14
0097h or eax,10h                    ; OR(Or_rm32_imm8) [EAX,10h:imm32]                     encoding(3 bytes) = 83 c8 10
009ah mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
009eh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
00a2h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00a5h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
00a9h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack5Bytes => new byte[170]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x89,0x44,0x24,0x14,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x89,0x44,0x24,0x08,0x33,0xC0,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x89,0x44,0x24,0x08,0x89,0x44,0x24,0x08,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x08,0x83,0xC8,0x01,0x88,0x44,0x24,0x08,0x84,0xD2,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x08,0x83,0xC8,0x02,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x0C,0x45,0x84,0xC0,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x04,0x88,0x44,0x24,0x0C,0x8B,0x44,0x24,0x0C,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x45,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x10,0x83,0xC8,0x08,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x89,0x44,0x24,0x14,0x80,0x7C,0x24,0x40,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x14,0x83,0xC8,0x10,0x88,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack6(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5)
; location: [7FFDDBAC93B0h, 7FFDDBAC9481h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp+4]               ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 7c 24 04
000eh mov ecx,5                     ; MOV(Mov_r32_imm32) [ECX,5h:imm32]                    encoding(5 bytes) = b9 05 00 00 00
0013h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0015h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0017h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001ch mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
0020h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0024h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 08
0028h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
002ch mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
0030h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0032h je short 0040h                ; JE(Je_rel8_64) [40h:jmp64]                           encoding(2 bytes) = 74 0c
0034h movzx eax,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 04
0039h or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
003ch mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
0040h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
0042h je short 0050h                ; JE(Je_rel8_64) [50h:jmp64]                           encoding(2 bytes) = 74 0c
0044h movzx eax,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 04
0049h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
004ch mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
0050h mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
0054h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0057h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
005bh test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
005eh je short 006ch                ; JE(Je_rel8_64) [6Ch:jmp64]                           encoding(2 bytes) = 74 0c
0060h movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
0065h or eax,4                      ; OR(Or_rm32_imm8) [EAX,4h:imm32]                      encoding(3 bytes) = 83 c8 04
0068h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
006ch mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
0070h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0073h mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0077h test r9b,r9b                  ; TEST(Test_rm8_r8) [R9L,R9L]                          encoding(3 bytes) = 45 84 c9
007ah je short 0088h                ; JE(Je_rel8_64) [88h:jmp64]                           encoding(2 bytes) = 74 0c
007ch movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
0081h or eax,8                      ; OR(Or_rm32_imm8) [EAX,8h:imm32]                      encoding(3 bytes) = 83 c8 08
0084h mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0088h mov eax,[rsp+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 0c
008ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
008fh mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0093h cmp byte ptr [rsp+50h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 50 00
0098h je short 00a6h                ; JE(Je_rel8_64) [A6h:jmp64]                           encoding(2 bytes) = 74 0c
009ah movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
009fh or eax,10h                    ; OR(Or_rm32_imm8) [EAX,10h:imm32]                     encoding(3 bytes) = 83 c8 10
00a2h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
00a6h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
00aah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00adh mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
00b1h cmp byte ptr [rsp+58h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 58 00
00b6h je short 00c4h                ; JE(Je_rel8_64) [C4h:jmp64]                           encoding(2 bytes) = 74 0c
00b8h movzx eax,byte ptr [rsp+14h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 14
00bdh or eax,20h                    ; OR(Or_rm32_imm8) [EAX,20h:imm32]                     encoding(3 bytes) = 83 c8 20
00c0h mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
00c4h mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
00c8h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00cbh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
00cfh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00d0h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00d1h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack6Bytes => new byte[210]{0x57,0x56,0x48,0x83,0xEC,0x18,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x04,0xB9,0x05,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x33,0xC0,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x89,0x44,0x24,0x08,0x89,0x44,0x24,0x04,0x89,0x44,0x24,0x04,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x04,0x83,0xC8,0x01,0x88,0x44,0x24,0x04,0x84,0xD2,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x04,0x83,0xC8,0x02,0x88,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x45,0x84,0xC0,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x08,0x83,0xC8,0x04,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x0C,0x45,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x08,0x88,0x44,0x24,0x0C,0x8B,0x44,0x24,0x0C,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x80,0x7C,0x24,0x50,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x10,0x83,0xC8,0x10,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x89,0x44,0x24,0x14,0x80,0x7C,0x24,0x58,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x14,0x83,0xC8,0x20,0x88,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack7(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5, bool b6)
; location: [7FFDDBAC94A0h, 7FFDDBAC958Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp]                 ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 3c 24
000dh mov ecx,6                     ; MOV(Mov_r32_imm32) [ECX,6h:imm32]                    encoding(5 bytes) = b9 06 00 00 00
0012h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0014h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0016h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0019h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001bh mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
001fh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0023h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 08
0027h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
002bh mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
002eh mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
0031h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0033h je short 003fh                ; JE(Je_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 74 0a
0035h movzx eax,byte ptr [rsp]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(4 bytes) = 0f b6 04 24
0039h or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
003ch mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
003fh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0041h je short 004dh                ; JE(Je_rel8_64) [4Dh:jmp64]                           encoding(2 bytes) = 74 0a
0043h movzx eax,byte ptr [rsp]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(4 bytes) = 0f b6 04 24
0047h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
004ah mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
004dh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0050h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0053h mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
0057h test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
005ah je short 0068h                ; JE(Je_rel8_64) [68h:jmp64]                           encoding(2 bytes) = 74 0c
005ch movzx eax,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 04
0061h or eax,4                      ; OR(Or_rm32_imm8) [EAX,4h:imm32]                      encoding(3 bytes) = 83 c8 04
0064h mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
0068h mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
006ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
006fh mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0073h test r9b,r9b                  ; TEST(Test_rm8_r8) [R9L,R9L]                          encoding(3 bytes) = 45 84 c9
0076h je short 0084h                ; JE(Je_rel8_64) [84h:jmp64]                           encoding(2 bytes) = 74 0c
0078h movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
007dh or eax,8                      ; OR(Or_rm32_imm8) [EAX,8h:imm32]                      encoding(3 bytes) = 83 c8 08
0080h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0084h mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
0088h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
008bh mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
008fh cmp byte ptr [rsp+50h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 50 00
0094h je short 00a2h                ; JE(Je_rel8_64) [A2h:jmp64]                           encoding(2 bytes) = 74 0c
0096h movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
009bh or eax,10h                    ; OR(Or_rm32_imm8) [EAX,10h:imm32]                     encoding(3 bytes) = 83 c8 10
009eh mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
00a2h mov eax,[rsp+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 0c
00a6h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00a9h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
00adh cmp byte ptr [rsp+58h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 58 00
00b2h je short 00c0h                ; JE(Je_rel8_64) [C0h:jmp64]                           encoding(2 bytes) = 74 0c
00b4h movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
00b9h or eax,20h                    ; OR(Or_rm32_imm8) [EAX,20h:imm32]                     encoding(3 bytes) = 83 c8 20
00bch mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
00c0h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
00c4h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00c7h mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
00cbh cmp byte ptr [rsp+60h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 60 00
00d0h je short 00deh                ; JE(Je_rel8_64) [DEh:jmp64]                           encoding(2 bytes) = 74 0c
00d2h movzx eax,byte ptr [rsp+14h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 14
00d7h or eax,40h                    ; OR(Or_rm32_imm8) [EAX,40h:imm32]                     encoding(3 bytes) = 83 c8 40
00dah mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
00deh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
00e2h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00e5h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
00e9h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00eah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00ebh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack7Bytes => new byte[236]{0x57,0x56,0x48,0x83,0xEC,0x18,0x48,0x8B,0xF1,0x48,0x8D,0x3C,0x24,0xB9,0x06,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x33,0xC0,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x89,0x44,0x24,0x08,0x89,0x44,0x24,0x04,0x89,0x04,0x24,0x89,0x04,0x24,0x84,0xC9,0x74,0x0A,0x0F,0xB6,0x04,0x24,0x83,0xC8,0x01,0x88,0x04,0x24,0x84,0xC9,0x74,0x0A,0x0F,0xB6,0x04,0x24,0x83,0xC8,0x02,0x88,0x04,0x24,0x8B,0x04,0x24,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x04,0x45,0x84,0xC0,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x04,0x83,0xC8,0x04,0x88,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x45,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x08,0x83,0xC8,0x08,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x0C,0x80,0x7C,0x24,0x50,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x10,0x88,0x44,0x24,0x0C,0x8B,0x44,0x24,0x0C,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x80,0x7C,0x24,0x58,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x10,0x83,0xC8,0x20,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x89,0x44,0x24,0x14,0x80,0x7C,0x24,0x60,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x14,0x83,0xC8,0x40,0x88,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack8(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5, bool b6, bool b7)
; location: [7FFDDBAC95B0h, 7FFDDBAC96C7h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 7c 24 0c
000eh mov ecx,7                     ; MOV(Mov_r32_imm32) [ECX,7h:imm32]                    encoding(5 bytes) = b9 07 00 00 00
0013h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0015h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0017h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001ch mov [rsp+20h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 20
0020h mov [rsp+1Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 1c
0024h mov [rsp+18h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 18
0028h mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
002ch mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
0030h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0034h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0038h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
003ah je short 0048h                ; JE(Je_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 74 0c
003ch movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
0041h or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
0044h mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0048h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
004ah je short 0058h                ; JE(Je_rel8_64) [58h:jmp64]                           encoding(2 bytes) = 74 0c
004ch movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
0051h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
0054h mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0058h mov eax,[rsp+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 0c
005ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
005fh mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0063h test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
0066h je short 0074h                ; JE(Je_rel8_64) [74h:jmp64]                           encoding(2 bytes) = 74 0c
0068h movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
006dh or eax,4                      ; OR(Or_rm32_imm8) [EAX,4h:imm32]                      encoding(3 bytes) = 83 c8 04
0070h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0074h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
0078h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
007bh mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
007fh test r9b,r9b                  ; TEST(Test_rm8_r8) [R9L,R9L]                          encoding(3 bytes) = 45 84 c9
0082h je short 0090h                ; JE(Je_rel8_64) [90h:jmp64]                           encoding(2 bytes) = 74 0c
0084h movzx eax,byte ptr [rsp+14h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 14
0089h or eax,8                      ; OR(Or_rm32_imm8) [EAX,8h:imm32]                      encoding(3 bytes) = 83 c8 08
008ch mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
0090h mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0094h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0097h mov [rsp+18h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 18
009bh cmp byte ptr [rsp+60h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 60 00
00a0h je short 00aeh                ; JE(Je_rel8_64) [AEh:jmp64]                           encoding(2 bytes) = 74 0c
00a2h movzx eax,byte ptr [rsp+18h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 18
00a7h or eax,10h                    ; OR(Or_rm32_imm8) [EAX,10h:imm32]                     encoding(3 bytes) = 83 c8 10
00aah mov [rsp+18h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 18
00aeh mov eax,[rsp+18h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 18
00b2h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00b5h mov [rsp+1Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 1c
00b9h cmp byte ptr [rsp+68h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 68 00
00beh je short 00cch                ; JE(Je_rel8_64) [CCh:jmp64]                           encoding(2 bytes) = 74 0c
00c0h movzx eax,byte ptr [rsp+1Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 1c
00c5h or eax,20h                    ; OR(Or_rm32_imm8) [EAX,20h:imm32]                     encoding(3 bytes) = 83 c8 20
00c8h mov [rsp+1Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 1c
00cch mov eax,[rsp+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 1c
00d0h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00d3h mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 20
00d7h cmp byte ptr [rsp+70h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 70 00
00dch je short 00eah                ; JE(Je_rel8_64) [EAh:jmp64]                           encoding(2 bytes) = 74 0c
00deh movzx eax,byte ptr [rsp+20h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 20
00e3h or eax,40h                    ; OR(Or_rm32_imm8) [EAX,40h:imm32]                     encoding(3 bytes) = 83 c8 40
00e6h mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 20
00eah mov eax,[rsp+20h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 20
00eeh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00f1h mov [rsp+24h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 24
00f5h cmp byte ptr [rsp+78h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 78 00
00fah je short 010ah                ; JE(Je_rel8_64) [10Ah:jmp64]                          encoding(2 bytes) = 74 0e
00fch movzx eax,byte ptr [rsp+24h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 24
0101h or eax,80h                    ; OR(Or_EAX_imm32) [EAX,80h:imm32]                     encoding(5 bytes) = 0d 80 00 00 00
0106h mov [rsp+24h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 24
010ah mov eax,[rsp+24h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 24
010eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0111h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0115h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0116h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0117h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack8Bytes => new byte[280]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x0C,0xB9,0x07,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x33,0xC0,0x89,0x44,0x24,0x20,0x89,0x44,0x24,0x1C,0x89,0x44,0x24,0x18,0x89,0x44,0x24,0x14,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x89,0x44,0x24,0x0C,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x01,0x88,0x44,0x24,0x0C,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x02,0x88,0x44,0x24,0x0C,0x8B,0x44,0x24,0x0C,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x45,0x84,0xC0,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x10,0x83,0xC8,0x04,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x14,0x45,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x14,0x83,0xC8,0x08,0x88,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x18,0x80,0x7C,0x24,0x60,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x18,0x83,0xC8,0x10,0x88,0x44,0x24,0x18,0x8B,0x44,0x24,0x18,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x1C,0x80,0x7C,0x24,0x68,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x1C,0x83,0xC8,0x20,0x88,0x44,0x24,0x1C,0x8B,0x44,0x24,0x1C,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x20,0x80,0x7C,0x24,0x70,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x20,0x83,0xC8,0x40,0x88,0x44,0x24,0x20,0x8B,0x44,0x24,0x20,0x0F,0xB6,0xC0,0x89,0x44,0x24,0x24,0x80,0x7C,0x24,0x78,0x00,0x74,0x0E,0x0F,0xB6,0x44,0x24,0x24,0x0D,0x80,0x00,0x00,0x00,0x88,0x44,0x24,0x24,0x8B,0x44,0x24,0x24,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> pack(ReadOnlySpan<bit> src)
; location: [7FFDDBAC96E0h, 7FFDDBAC9762h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
000eh mov [rsp+38h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 38
0013h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
0018h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
001dh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0020h mov edi,[rdx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 7a 08
0023h mov ecx,edi                   ; MOV(Mov_r32_rm32) [ECX,EDI]                          encoding(2 bytes) = 8b cf
0025h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0027h sar eax,3                     ; SAR(Sar_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 f8 03
002ah test cl,7                     ; TEST(Test_rm8_imm8) [CL,7h:imm8]                     encoding(3 bytes) = f6 c1 07
002dh je short 0031h                ; JE(Je_rel8_64) [31h:jmp64]                           encoding(2 bytes) = 74 02
002fh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0031h mov rbx,[rdx]                 ; MOV(Mov_r64_rm64) [RBX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 1a
0034h movsxd rdx,eax                ; MOVSXD(Movsxd_r64_rm32) [RDX,EAX]                    encoding(3 bytes) = 48 63 d0
0037h mov rcx,7FFDDB3EEA10h         ; MOV(Mov_r64_imm64) [RCX,7ffddb3eea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 3e db fd 7f 00 00
0041h call 7FFE3AF245E0h            ; CALL(Call_rel32_64) [5F45AF00h:jmp64]                encoding(5 bytes) = e8 ba ae 45 5f
0046h lea rcx,[rax+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 48 10
004ah mov edx,[rax+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 50 08
004dh mov r8,rsi                    ; MOV(Mov_r64_rm64) [R8,RSI]                           encoding(3 bytes) = 4c 8b c6
0050h lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 30
0055h mov [rax],rbx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RBX]        encoding(3 bytes) = 48 89 18
0058h mov [rax+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDI]        encoding(3 bytes) = 89 78 08
005bh lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 20
0060h mov [rax],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RCX]        encoding(3 bytes) = 48 89 08
0063h mov [rax+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(3 bytes) = 89 50 08
0066h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
0069h lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 30
006eh lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0073h call 7FFDDB4256A0h            ; CALL(Call_rel32_64) [FFFFFFFFFF95BFC0h:jmp64]        encoding(5 bytes) = e8 48 bf 95 ff
0078h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
007bh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
007fh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0080h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0081h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0082h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[131]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF1,0x8B,0x7A,0x08,0x8B,0xCF,0x8B,0xC1,0xC1,0xF8,0x03,0xF6,0xC1,0x07,0x74,0x02,0xFF,0xC0,0x48,0x8B,0x1A,0x48,0x63,0xD0,0x48,0xB9,0x10,0xEA,0x3E,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0xBA,0xAE,0x45,0x5F,0x48,0x8D,0x48,0x10,0x8B,0x50,0x08,0x4C,0x8B,0xC6,0x48,0x8D,0x44,0x24,0x30,0x48,0x89,0x18,0x89,0x78,0x08,0x48,0x8D,0x44,0x24,0x20,0x48,0x89,0x08,0x89,0x50,0x08,0x49,0x8B,0xC8,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0xE8,0x48,0xBF,0x95,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> pack(bit[] src)
; location: [7FFDDBAC9780h, 7FFDDBAC984Ah]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0005h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0006h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0007h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0008h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
000ch mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000fh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0012h mov ebx,[rsi+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 5e 08
0015h mov edx,ebx                   ; MOV(Mov_r32_rm32) [EDX,EBX]                          encoding(2 bytes) = 8b d3
0017h mov ebp,edx                   ; MOV(Mov_r32_rm32) [EBP,EDX]                          encoding(2 bytes) = 8b ea
0019h mov rdx,2000000000000000h     ; MOV(Mov_r64_imm64) [RDX,2000000000000000h:imm64]     encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 20
0023h mulx rdx,rdx,rbp              ; MULX(VEX_Mulx_r64_r64_rm64) [RDX,RDX,RBP]            encoding(VEX, 5 bytes) = c4 e2 eb f6 d5
0028h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
002ah mov rdx,rbp                   ; MOV(Mov_r64_rm64) [RDX,RBP]                          encoding(3 bytes) = 48 8b d5
002dh shl rdx,3Dh                   ; SHL(Shl_rm64_imm8) [RDX,3dh:imm8]                    encoding(4 bytes) = 48 c1 e2 3d
0031h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0036h mulx rdx,rdx,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RDX,RDX,RAX]            encoding(VEX, 5 bytes) = c4 e2 eb f6 d0
003bh mov ecx,ecx                   ; MOV(Mov_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 8b c9
003dh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
003fh jne short 0045h               ; JNE(Jne_rel8_64) [45h:jmp64]                         encoding(2 bytes) = 75 04
0041h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0043h jmp short 004ah               ; JMP(Jmp_rel8_64) [4Ah:jmp64]                         encoding(2 bytes) = eb 05
0045h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
004ah movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
004dh add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0050h mov rcx,7FFDDB3EEA10h         ; MOV(Mov_r64_imm64) [RCX,7ffddb3eea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 3e db fd 7f 00 00
005ah call 7FFE3AF245E0h            ; CALL(Call_rel32_64) [5F45AE60h:jmp64]                encoding(5 bytes) = e8 01 ae 45 5f
005fh lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
0063h mov r8d,[rax+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 08
0067h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
006ah test rbp,rbp                  ; TEST(Test_rm64_r64) [RBP,RBP]                        encoding(3 bytes) = 48 85 ed
006dh jle short 00aeh               ; JLE(Jle_rel8_64) [AEh:jmp64]                         encoding(2 bytes) = 7e 3f
006fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0071h movsxd r10,r9d                ; MOVSXD(Movsxd_r64_rm32) [R10,R9D]                    encoding(3 bytes) = 4d 63 d1
0074h cmp eax,r8d                   ; CMP(Cmp_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 3b c0
0077h jae short 00c5h               ; JAE(Jae_rel8_64) [C5h:jmp64]                         encoding(2 bytes) = 73 4c
0079h movsxd r11,eax                ; MOVSXD(Movsxd_r64_rm32) [R11,EAX]                    encoding(3 bytes) = 4c 63 d8
007ch add r11,rdx                   ; ADD(Add_r64_rm64) [R11,RDX]                          encoding(3 bytes) = 4c 03 da
007fh movzx r14d,byte ptr [r11]     ; MOVZX(Movzx_r32_rm8) [R14D,mem(8u,R11:br,DS:sr)]     encoding(4 bytes) = 45 0f b6 33
0083h cmp r9d,ebx                   ; CMP(Cmp_r32_rm32) [R9D,EBX]                          encoding(3 bytes) = 44 3b cb
0086h jae short 00c5h               ; JAE(Jae_rel8_64) [C5h:jmp64]                         encoding(2 bytes) = 73 3d
0088h mov r15d,[rsi+r10*4+10h]      ; MOV(Mov_r32_rm32) [R15D,mem(32u,RSI:br,DS:sr)]       encoding(5 bytes) = 46 8b 7c 96 10
008dh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
008fh shl r15d,cl                   ; SHL(Shl_rm32_CL) [R15D,CL]                           encoding(3 bytes) = 41 d3 e7
0092h movzx ecx,r15b                ; MOVZX(Movzx_r32_rm8) [ECX,R15L]                      encoding(4 bytes) = 41 0f b6 cf
0096h or ecx,r14d                   ; OR(Or_r32_rm32) [ECX,R14D]                           encoding(3 bytes) = 41 0b ce
0099h mov [r11],cl                  ; MOV(Mov_rm8_r8) [mem(8u,R11:br,DS:sr),CL]            encoding(3 bytes) = 41 88 0b
009ch inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
009eh cmp eax,8                     ; CMP(Cmp_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 f8 08
00a1h jl short 0074h                ; JL(Jl_rel8_64) [74h:jmp64]                           encoding(2 bytes) = 7c d1
00a3h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
00a6h movsxd rax,r9d                ; MOVSXD(Movsxd_r64_rm32) [RAX,R9D]                    encoding(3 bytes) = 49 63 c1
00a9h cmp rax,rbp                   ; CMP(Cmp_r64_rm64) [RAX,RBP]                          encoding(3 bytes) = 48 3b c5
00ach jl short 006fh                ; JL(Jl_rel8_64) [6Fh:jmp64]                           encoding(2 bytes) = 7c c1
00aeh mov [rdi],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 17
00b1h mov [rdi+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 47 08
00b5h mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
00b8h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00bch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00bdh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00beh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00bfh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00c0h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00c2h pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
00c4h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00c5h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F585780h:jmp64]                encoding(5 bytes) = e8 b6 56 58 5f
00cah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[203]{0x41,0x57,0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x8B,0x5E,0x08,0x8B,0xD3,0x8B,0xEA,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x20,0xC4,0xE2,0xEB,0xF6,0xD5,0x8B,0xCA,0x48,0x8B,0xD5,0x48,0xC1,0xE2,0x3D,0xB8,0x08,0x00,0x00,0x00,0xC4,0xE2,0xEB,0xF6,0xD0,0x8B,0xC9,0x85,0xD2,0x75,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x48,0x63,0xD2,0x48,0x03,0xD1,0x48,0xB9,0x10,0xEA,0x3E,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x01,0xAE,0x45,0x5F,0x48,0x8D,0x50,0x10,0x44,0x8B,0x40,0x08,0x45,0x33,0xC9,0x48,0x85,0xED,0x7E,0x3F,0x33,0xC0,0x4D,0x63,0xD1,0x41,0x3B,0xC0,0x73,0x4C,0x4C,0x63,0xD8,0x4C,0x03,0xDA,0x45,0x0F,0xB6,0x33,0x44,0x3B,0xCB,0x73,0x3D,0x46,0x8B,0x7C,0x96,0x10,0x8B,0xC8,0x41,0xD3,0xE7,0x41,0x0F,0xB6,0xCF,0x41,0x0B,0xCE,0x41,0x88,0x0B,0xFF,0xC0,0x83,0xF8,0x08,0x7C,0xD1,0x41,0xFF,0xC1,0x49,0x63,0xC1,0x48,0x3B,0xC5,0x7C,0xC1,0x48,0x89,0x17,0x44,0x89,0x47,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0xB6,0x56,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(N8 n, Span<bit> src)
; location: [7FFDDBAC9870h, 7FFDDBAC98FAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 75
0010h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0012h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0015h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 6e
0017h mov r8d,[rax+4]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 04
001bh shl r8d,1                     ; SHL(Shl_rm32_1) [R8D,1h:imm8]                        encoding(3 bytes) = 41 d1 e0
001eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0021h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0024h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 5f
0026h mov r8d,[rax+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 08
002ah shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
002eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0031h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0034h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 4f
0036h mov r8d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 0c
003ah shl r8d,3                     ; SHL(Shl_rm32_imm8) [R8D,3h:imm8]                     encoding(4 bytes) = 41 c1 e0 03
003eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0041h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0044h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 3f
0046h mov r8d,[rax+10h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 10
004ah shl r8d,4                     ; SHL(Shl_rm32_imm8) [R8D,4h:imm8]                     encoding(4 bytes) = 41 c1 e0 04
004eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0051h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0054h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 2f
0056h mov r8d,[rax+14h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 14
005ah shl r8d,5                     ; SHL(Shl_rm32_imm8) [R8D,5h:imm8]                     encoding(4 bytes) = 41 c1 e0 05
005eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0061h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0064h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 1f
0066h mov r8d,[rax+18h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 18
006ah shl r8d,6                     ; SHL(Shl_rm32_imm8) [R8D,6h:imm8]                     encoding(4 bytes) = 41 c1 e0 06
006eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0071h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0074h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 0f
0076h mov eax,[rax+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 1c
0079h shl eax,7                     ; SHL(Shl_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 e0 07
007ch or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
007eh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0080h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0084h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0085h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F585690h:jmp64]                encoding(5 bytes) = e8 06 56 58 5f
008ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[139]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x75,0x8B,0x08,0x83,0xFA,0x01,0x76,0x6E,0x44,0x8B,0x40,0x04,0x41,0xD1,0xE0,0x41,0x0B,0xC8,0x83,0xFA,0x02,0x76,0x5F,0x44,0x8B,0x40,0x08,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xC8,0x83,0xFA,0x03,0x76,0x4F,0x44,0x8B,0x40,0x0C,0x41,0xC1,0xE0,0x03,0x41,0x0B,0xC8,0x83,0xFA,0x04,0x76,0x3F,0x44,0x8B,0x40,0x10,0x41,0xC1,0xE0,0x04,0x41,0x0B,0xC8,0x83,0xFA,0x05,0x76,0x2F,0x44,0x8B,0x40,0x14,0x41,0xC1,0xE0,0x05,0x41,0x0B,0xC8,0x83,0xFA,0x06,0x76,0x1F,0x44,0x8B,0x40,0x18,0x41,0xC1,0xE0,0x06,0x41,0x0B,0xC8,0x83,0xFA,0x07,0x76,0x0F,0x8B,0x40,0x1C,0xC1,0xE0,0x07,0x0B,0xC8,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x06,0x56,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(N16 n, Span<bit> src)
; location: [7FFDDBAC9910h, 7FFDDBAC9A5Bh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 32 01 00 00
0014h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0016h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0019h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 27 01 00 00
001fh mov r8d,[rax+4]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 04
0023h shl r8d,1                     ; SHL(Shl_rm32_1) [R8D,1h:imm8]                        encoding(3 bytes) = 41 d1 e0
0026h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0029h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
002ch jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 14 01 00 00
0032h mov r8d,[rax+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 08
0036h shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
003ah or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
003dh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0040h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 00 01 00 00
0046h mov r8d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 0c
004ah shl r8d,3                     ; SHL(Shl_rm32_imm8) [R8D,3h:imm8]                     encoding(4 bytes) = 41 c1 e0 03
004eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0051h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0054h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 ec 00 00 00
005ah mov r8d,[rax+10h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 10
005eh shl r8d,4                     ; SHL(Shl_rm32_imm8) [R8D,4h:imm8]                     encoding(4 bytes) = 41 c1 e0 04
0062h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0065h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0068h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 d8 00 00 00
006eh mov r8d,[rax+14h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 14
0072h shl r8d,5                     ; SHL(Shl_rm32_imm8) [R8D,5h:imm8]                     encoding(4 bytes) = 41 c1 e0 05
0076h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0079h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
007ch jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 c4 00 00 00
0082h mov r8d,[rax+18h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 18
0086h shl r8d,6                     ; SHL(Shl_rm32_imm8) [R8D,6h:imm8]                     encoding(4 bytes) = 41 c1 e0 06
008ah or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
008dh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0090h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 b0 00 00 00
0096h mov r8d,[rax+1Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 1c
009ah shl r8d,7                     ; SHL(Shl_rm32_imm8) [R8D,7h:imm8]                     encoding(4 bytes) = 41 c1 e0 07
009eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
00a1h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
00a4h jb near ptr 0140h             ; JB(Jb_rel32_64) [140h:jmp64]                         encoding(6 bytes) = 0f 82 96 00 00 00
00aah add edx,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [EDX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 c2 f8
00adh add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
00b1h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
00b4h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 8c 00 00 00
00bah mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
00bdh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
00c0h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 80 00 00 00
00c6h mov r9d,[rax+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 04
00cah shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
00cdh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
00d0h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
00d3h jbe short 0146h               ; JBE(Jbe_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 76 71
00d5h mov r9d,[rax+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 08
00d9h shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
00ddh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
00e0h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
00e3h jbe short 0146h               ; JBE(Jbe_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 76 61
00e5h mov r9d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 0c
00e9h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
00edh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
00f0h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00f3h jbe short 0146h               ; JBE(Jbe_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 76 51
00f5h mov r9d,[rax+10h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 10
00f9h shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
00fdh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0100h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0103h jbe short 0146h               ; JBE(Jbe_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 76 41
0105h mov r9d,[rax+14h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 14
0109h shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
010dh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0110h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0113h jbe short 0146h               ; JBE(Jbe_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 76 31
0115h mov r9d,[rax+18h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 18
0119h shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
011dh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0120h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0123h jbe short 0146h               ; JBE(Jbe_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 76 21
0125h mov eax,[rax+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 1c
0128h shl eax,7                     ; SHL(Shl_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 e0 07
012bh or r8d,eax                    ; OR(Or_r32_rm32) [R8D,EAX]                            encoding(3 bytes) = 44 0b c0
012eh mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0131h shl rax,8                     ; SHL(Shl_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e0 08
0135h or rcx,rax                    ; OR(Or_r64_rm64) [RCX,RAX]                            encoding(3 bytes) = 48 0b c8
0138h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
013bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
013fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0140h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966CB8h:jmp64]        encoding(5 bytes) = e8 73 6b 96 ff
0145h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0146h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F5855F0h:jmp64]                encoding(5 bytes) = e8 a5 54 58 5f
014bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[332]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x32,0x01,0x00,0x00,0x8B,0x08,0x83,0xFA,0x01,0x0F,0x86,0x27,0x01,0x00,0x00,0x44,0x8B,0x40,0x04,0x41,0xD1,0xE0,0x41,0x0B,0xC8,0x83,0xFA,0x02,0x0F,0x86,0x14,0x01,0x00,0x00,0x44,0x8B,0x40,0x08,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xC8,0x83,0xFA,0x03,0x0F,0x86,0x00,0x01,0x00,0x00,0x44,0x8B,0x40,0x0C,0x41,0xC1,0xE0,0x03,0x41,0x0B,0xC8,0x83,0xFA,0x04,0x0F,0x86,0xEC,0x00,0x00,0x00,0x44,0x8B,0x40,0x10,0x41,0xC1,0xE0,0x04,0x41,0x0B,0xC8,0x83,0xFA,0x05,0x0F,0x86,0xD8,0x00,0x00,0x00,0x44,0x8B,0x40,0x14,0x41,0xC1,0xE0,0x05,0x41,0x0B,0xC8,0x83,0xFA,0x06,0x0F,0x86,0xC4,0x00,0x00,0x00,0x44,0x8B,0x40,0x18,0x41,0xC1,0xE0,0x06,0x41,0x0B,0xC8,0x83,0xFA,0x07,0x0F,0x86,0xB0,0x00,0x00,0x00,0x44,0x8B,0x40,0x1C,0x41,0xC1,0xE0,0x07,0x41,0x0B,0xC8,0x83,0xFA,0x08,0x0F,0x82,0x96,0x00,0x00,0x00,0x83,0xC2,0xF8,0x48,0x83,0xC0,0x20,0x83,0xFA,0x00,0x0F,0x86,0x8C,0x00,0x00,0x00,0x44,0x8B,0x00,0x83,0xFA,0x01,0x0F,0x86,0x80,0x00,0x00,0x00,0x44,0x8B,0x48,0x04,0x41,0xD1,0xE1,0x45,0x0B,0xC1,0x83,0xFA,0x02,0x76,0x71,0x44,0x8B,0x48,0x08,0x41,0xC1,0xE1,0x02,0x45,0x0B,0xC1,0x83,0xFA,0x03,0x76,0x61,0x44,0x8B,0x48,0x0C,0x41,0xC1,0xE1,0x03,0x45,0x0B,0xC1,0x83,0xFA,0x04,0x76,0x51,0x44,0x8B,0x48,0x10,0x41,0xC1,0xE1,0x04,0x45,0x0B,0xC1,0x83,0xFA,0x05,0x76,0x41,0x44,0x8B,0x48,0x14,0x41,0xC1,0xE1,0x05,0x45,0x0B,0xC1,0x83,0xFA,0x06,0x76,0x31,0x44,0x8B,0x48,0x18,0x41,0xC1,0xE1,0x06,0x45,0x0B,0xC1,0x83,0xFA,0x07,0x76,0x21,0x8B,0x40,0x1C,0xC1,0xE0,0x07,0x44,0x0B,0xC0,0x41,0x8B,0xC0,0x48,0xC1,0xE0,0x08,0x48,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x73,0x6B,0x96,0xFF,0xCC,0xE8,0xA5,0x54,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(N32 n, Span<bit> src)
; location: [7FFDDBAC9A70h, 7FFDDBAC9D46h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
000eh mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0011h cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
0015h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 b6 02 00 00
001bh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
001eh cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
0022h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 a9 02 00 00
0028h mov r10d,[rcx+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 04
002ch shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
002fh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0032h cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
0036h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 95 02 00 00
003ch mov r10d,[rcx+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 08
0040h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0044h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0047h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
004bh jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 80 02 00 00
0051h mov r10d,[rcx+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 0c
0055h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
0059h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
005ch cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0060h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 6b 02 00 00
0066h mov r10d,[rcx+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 10
006ah shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
006eh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0071h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
0075h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 56 02 00 00
007bh mov r10d,[rcx+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 14
007fh shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
0083h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0086h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
008ah jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 41 02 00 00
0090h mov r10d,[rcx+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 18
0094h shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
0098h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
009bh cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
009fh jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 2c 02 00 00
00a5h mov ecx,[rcx+1Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 1c
00a8h shl ecx,7                     ; SHL(Shl_rm32_imm8) [ECX,7h:imm8]                     encoding(3 bytes) = c1 e1 07
00abh or r9d,ecx                    ; OR(Or_r32_rm32) [R9D,ECX]                            encoding(3 bytes) = 44 0b c9
00aeh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
00b1h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
00b4h jb near ptr 02bfh             ; JB(Jb_rel32_64) [2BFh:jmp64]                         encoding(6 bytes) = 0f 82 05 02 00 00
00bah lea r8d,[rdx-8]               ; LEA(Lea_r32_m) [R8D,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8d 42 f8
00beh lea r9,[rax+20h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 20
00c2h cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
00c6h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 05 02 00 00
00cch mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
00cfh cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
00d3h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 f8 01 00 00
00d9h mov r11d,[r9+4]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 04
00ddh shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
00e0h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00e3h cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
00e7h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 e4 01 00 00
00edh mov r11d,[r9+8]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 08
00f1h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
00f5h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00f8h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
00fch jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 cf 01 00 00
0102h mov r11d,[r9+0Ch]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 0c
0106h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
010ah or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
010dh cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0111h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 ba 01 00 00
0117h mov r11d,[r9+10h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 10
011bh shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
011fh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0122h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
0126h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 a5 01 00 00
012ch mov r11d,[r9+14h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 14
0130h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0134h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0137h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
013bh jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 90 01 00 00
0141h mov r11d,[r9+18h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 18
0145h shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
0149h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
014ch cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
0150h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 7b 01 00 00
0156h mov r8d,[r9+1Ch]              ; MOV(Mov_r32_rm32) [R8D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 41 1c
015ah shl r8d,7                     ; SHL(Shl_rm32_imm8) [R8D,7h:imm8]                     encoding(4 bytes) = 41 c1 e0 07
015eh or r10d,r8d                   ; OR(Or_r32_rm32) [R10D,R8D]                           encoding(3 bytes) = 45 0b d0
0161h mov r8d,r10d                  ; MOV(Mov_r32_rm32) [R8D,R10D]                         encoding(3 bytes) = 45 8b c2
0164h shl r8,8                      ; SHL(Shl_rm64_imm8) [R8,8h:imm8]                      encoding(4 bytes) = 49 c1 e0 08
0168h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
016bh cmp edx,10h                   ; CMP(Cmp_rm32_imm8) [EDX,10h:imm32]                   encoding(3 bytes) = 83 fa 10
016eh jb near ptr 02c5h             ; JB(Jb_rel32_64) [2C5h:jmp64]                         encoding(6 bytes) = 0f 82 51 01 00 00
0174h add edx,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [EDX,fffffffffffffff0h:imm32]     encoding(3 bytes) = 83 c2 f0
0177h add rax,40h                   ; ADD(Add_rm64_imm8) [RAX,40h:imm64]                   encoding(4 bytes) = 48 83 c0 40
017bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
017eh jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 4d 01 00 00
0184h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
0187h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
018ah jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 41 01 00 00
0190h mov r9d,[rax+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 04
0194h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
0197h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
019ah cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
019dh jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 2e 01 00 00
01a3h mov r9d,[rax+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 08
01a7h shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
01abh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
01aeh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
01b1h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 1a 01 00 00
01b7h mov r9d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 0c
01bbh shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
01bfh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
01c2h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
01c5h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 06 01 00 00
01cbh mov r9d,[rax+10h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 10
01cfh shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
01d3h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
01d6h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
01d9h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 f2 00 00 00
01dfh mov r9d,[rax+14h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 14
01e3h shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
01e7h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
01eah cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
01edh jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 de 00 00 00
01f3h mov r9d,[rax+18h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 18
01f7h shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
01fbh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
01feh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0201h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 ca 00 00 00
0207h mov r9d,[rax+1Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 1c
020bh shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
020fh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0212h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
0215h jb near ptr 02cbh             ; JB(Jb_rel32_64) [2CBh:jmp64]                         encoding(6 bytes) = 0f 82 b0 00 00 00
021bh add edx,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [EDX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 c2 f8
021eh add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
0222h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
0225h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 a6 00 00 00
022bh mov r9d,[rax]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 08
022eh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0231h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 9a 00 00 00
0237h mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 04
023bh shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
023eh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0241h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0244h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 87 00 00 00
024ah mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 08
024eh shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0252h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0255h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0258h jbe short 02d1h               ; JBE(Jbe_rel8_64) [2D1h:jmp64]                        encoding(2 bytes) = 76 77
025ah mov r10d,[rax+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 0c
025eh shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
0262h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0265h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0268h jbe short 02d1h               ; JBE(Jbe_rel8_64) [2D1h:jmp64]                        encoding(2 bytes) = 76 67
026ah mov r10d,[rax+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 10
026eh shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
0272h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0275h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0278h jbe short 02d1h               ; JBE(Jbe_rel8_64) [2D1h:jmp64]                        encoding(2 bytes) = 76 57
027ah mov r10d,[rax+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 14
027eh shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
0282h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0285h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0288h jbe short 02d1h               ; JBE(Jbe_rel8_64) [2D1h:jmp64]                        encoding(2 bytes) = 76 47
028ah mov r10d,[rax+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 18
028eh shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
0292h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0295h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0298h jbe short 02d1h               ; JBE(Jbe_rel8_64) [2D1h:jmp64]                        encoding(2 bytes) = 76 37
029ah mov eax,[rax+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 1c
029dh shl eax,7                     ; SHL(Shl_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 e0 07
02a0h or r9d,eax                    ; OR(Or_r32_rm32) [R9D,EAX]                            encoding(3 bytes) = 44 0b c8
02a3h mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
02a6h shl rax,8                     ; SHL(Shl_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e0 08
02aah or r8,rax                     ; OR(Or_r64_rm64) [R8,RAX]                             encoding(3 bytes) = 4c 0b c0
02adh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
02b0h shl rax,10h                   ; SHL(Shl_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e0 10
02b4h or rcx,rax                    ; OR(Or_r64_rm64) [RCX,RAX]                            encoding(3 bytes) = 48 0b c8
02b7h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
02bah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
02beh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
02bfh call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966B58h:jmp64]        encoding(5 bytes) = e8 94 68 96 ff
02c4h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
02c5h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966B58h:jmp64]        encoding(5 bytes) = e8 8e 68 96 ff
02cah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
02cbh call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966B58h:jmp64]        encoding(5 bytes) = e8 88 68 96 ff
02d0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
02d1h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F585490h:jmp64]                encoding(5 bytes) = e8 ba 51 58 5f
02d6h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[727]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x48,0x8B,0xC8,0x44,0x8B,0xC2,0x41,0x83,0xF8,0x00,0x0F,0x86,0xB6,0x02,0x00,0x00,0x44,0x8B,0x09,0x41,0x83,0xF8,0x01,0x0F,0x86,0xA9,0x02,0x00,0x00,0x44,0x8B,0x51,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x02,0x0F,0x86,0x95,0x02,0x00,0x00,0x44,0x8B,0x51,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x03,0x0F,0x86,0x80,0x02,0x00,0x00,0x44,0x8B,0x51,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x04,0x0F,0x86,0x6B,0x02,0x00,0x00,0x44,0x8B,0x51,0x10,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x05,0x0F,0x86,0x56,0x02,0x00,0x00,0x44,0x8B,0x51,0x14,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x06,0x0F,0x86,0x41,0x02,0x00,0x00,0x44,0x8B,0x51,0x18,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x07,0x0F,0x86,0x2C,0x02,0x00,0x00,0x8B,0x49,0x1C,0xC1,0xE1,0x07,0x44,0x0B,0xC9,0x41,0x8B,0xC9,0x83,0xFA,0x08,0x0F,0x82,0x05,0x02,0x00,0x00,0x44,0x8D,0x42,0xF8,0x4C,0x8D,0x48,0x20,0x41,0x83,0xF8,0x00,0x0F,0x86,0x05,0x02,0x00,0x00,0x45,0x8B,0x11,0x41,0x83,0xF8,0x01,0x0F,0x86,0xF8,0x01,0x00,0x00,0x45,0x8B,0x59,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x02,0x0F,0x86,0xE4,0x01,0x00,0x00,0x45,0x8B,0x59,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x03,0x0F,0x86,0xCF,0x01,0x00,0x00,0x45,0x8B,0x59,0x0C,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x04,0x0F,0x86,0xBA,0x01,0x00,0x00,0x45,0x8B,0x59,0x10,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x05,0x0F,0x86,0xA5,0x01,0x00,0x00,0x45,0x8B,0x59,0x14,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x06,0x0F,0x86,0x90,0x01,0x00,0x00,0x45,0x8B,0x59,0x18,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x07,0x0F,0x86,0x7B,0x01,0x00,0x00,0x45,0x8B,0x41,0x1C,0x41,0xC1,0xE0,0x07,0x45,0x0B,0xD0,0x45,0x8B,0xC2,0x49,0xC1,0xE0,0x08,0x49,0x0B,0xC8,0x83,0xFA,0x10,0x0F,0x82,0x51,0x01,0x00,0x00,0x83,0xC2,0xF0,0x48,0x83,0xC0,0x40,0x83,0xFA,0x00,0x0F,0x86,0x4D,0x01,0x00,0x00,0x44,0x8B,0x00,0x83,0xFA,0x01,0x0F,0x86,0x41,0x01,0x00,0x00,0x44,0x8B,0x48,0x04,0x41,0xD1,0xE1,0x45,0x0B,0xC1,0x83,0xFA,0x02,0x0F,0x86,0x2E,0x01,0x00,0x00,0x44,0x8B,0x48,0x08,0x41,0xC1,0xE1,0x02,0x45,0x0B,0xC1,0x83,0xFA,0x03,0x0F,0x86,0x1A,0x01,0x00,0x00,0x44,0x8B,0x48,0x0C,0x41,0xC1,0xE1,0x03,0x45,0x0B,0xC1,0x83,0xFA,0x04,0x0F,0x86,0x06,0x01,0x00,0x00,0x44,0x8B,0x48,0x10,0x41,0xC1,0xE1,0x04,0x45,0x0B,0xC1,0x83,0xFA,0x05,0x0F,0x86,0xF2,0x00,0x00,0x00,0x44,0x8B,0x48,0x14,0x41,0xC1,0xE1,0x05,0x45,0x0B,0xC1,0x83,0xFA,0x06,0x0F,0x86,0xDE,0x00,0x00,0x00,0x44,0x8B,0x48,0x18,0x41,0xC1,0xE1,0x06,0x45,0x0B,0xC1,0x83,0xFA,0x07,0x0F,0x86,0xCA,0x00,0x00,0x00,0x44,0x8B,0x48,0x1C,0x41,0xC1,0xE1,0x07,0x45,0x0B,0xC1,0x83,0xFA,0x08,0x0F,0x82,0xB0,0x00,0x00,0x00,0x83,0xC2,0xF8,0x48,0x83,0xC0,0x20,0x83,0xFA,0x00,0x0F,0x86,0xA6,0x00,0x00,0x00,0x44,0x8B,0x08,0x83,0xFA,0x01,0x0F,0x86,0x9A,0x00,0x00,0x00,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x83,0xFA,0x02,0x0F,0x86,0x87,0x00,0x00,0x00,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x83,0xFA,0x03,0x76,0x77,0x44,0x8B,0x50,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x83,0xFA,0x04,0x76,0x67,0x44,0x8B,0x50,0x10,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x83,0xFA,0x05,0x76,0x57,0x44,0x8B,0x50,0x14,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x83,0xFA,0x06,0x76,0x47,0x44,0x8B,0x50,0x18,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x83,0xFA,0x07,0x76,0x37,0x8B,0x40,0x1C,0xC1,0xE0,0x07,0x44,0x0B,0xC8,0x41,0x8B,0xC1,0x48,0xC1,0xE0,0x08,0x4C,0x0B,0xC0,0x49,0x8B,0xC0,0x48,0xC1,0xE0,0x10,0x48,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x94,0x68,0x96,0xFF,0xCC,0xE8,0x8E,0x68,0x96,0xFF,0xCC,0xE8,0x88,0x68,0x96,0xFF,0xCC,0xE8,0xBA,0x51,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(N64 n, Span<bit> src)
; location: [7FFDDBAC9D60h, 7FFDDBACA32Dh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
000eh mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0011h cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
0015h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 ad 05 00 00
001bh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
001eh cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
0022h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 a0 05 00 00
0028h mov r10d,[rcx+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 04
002ch shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
002fh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0032h cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
0036h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 8c 05 00 00
003ch mov r10d,[rcx+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 08
0040h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0044h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0047h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
004bh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 77 05 00 00
0051h mov r10d,[rcx+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 0c
0055h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
0059h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
005ch cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0060h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 62 05 00 00
0066h mov r10d,[rcx+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 10
006ah shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
006eh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0071h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
0075h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 4d 05 00 00
007bh mov r10d,[rcx+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 14
007fh shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
0083h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0086h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
008ah jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 38 05 00 00
0090h mov r10d,[rcx+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 18
0094h shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
0098h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
009bh cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
009fh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 23 05 00 00
00a5h mov ecx,[rcx+1Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 1c
00a8h shl ecx,7                     ; SHL(Shl_rm32_imm8) [ECX,7h:imm8]                     encoding(3 bytes) = c1 e1 07
00abh or r9d,ecx                    ; OR(Or_r32_rm32) [R9D,ECX]                            encoding(3 bytes) = 44 0b c9
00aeh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
00b1h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
00b4h jb near ptr 059eh             ; JB(Jb_rel32_64) [59Eh:jmp64]                         encoding(6 bytes) = 0f 82 e4 04 00 00
00bah lea r8d,[rdx-8]               ; LEA(Lea_r32_m) [R8D,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8d 42 f8
00beh lea r9,[rax+20h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 20
00c2h cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
00c6h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 fc 04 00 00
00cch mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
00cfh cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
00d3h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 ef 04 00 00
00d9h mov r11d,[r9+4]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 04
00ddh shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
00e0h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00e3h cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
00e7h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 db 04 00 00
00edh mov r11d,[r9+8]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 08
00f1h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
00f5h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00f8h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
00fch jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 c6 04 00 00
0102h mov r11d,[r9+0Ch]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 0c
0106h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
010ah or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
010dh cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0111h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 b1 04 00 00
0117h mov r11d,[r9+10h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 10
011bh shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
011fh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0122h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
0126h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 9c 04 00 00
012ch mov r11d,[r9+14h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 14
0130h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0134h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0137h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
013bh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 87 04 00 00
0141h mov r11d,[r9+18h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 18
0145h shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
0149h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
014ch cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
0150h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 72 04 00 00
0156h mov r8d,[r9+1Ch]              ; MOV(Mov_r32_rm32) [R8D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 41 1c
015ah shl r8d,7                     ; SHL(Shl_rm32_imm8) [R8D,7h:imm8]                     encoding(4 bytes) = 41 c1 e0 07
015eh or r10d,r8d                   ; OR(Or_r32_rm32) [R10D,R8D]                           encoding(3 bytes) = 45 0b d0
0161h mov r8d,r10d                  ; MOV(Mov_r32_rm32) [R8D,R10D]                         encoding(3 bytes) = 45 8b c2
0164h shl r8,8                      ; SHL(Shl_rm64_imm8) [R8,8h:imm8]                      encoding(4 bytes) = 49 c1 e0 08
0168h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
016bh cmp edx,10h                   ; CMP(Cmp_rm32_imm8) [EDX,10h:imm32]                   encoding(3 bytes) = 83 fa 10
016eh jb near ptr 05a4h             ; JB(Jb_rel32_64) [5A4h:jmp64]                         encoding(6 bytes) = 0f 82 30 04 00 00
0174h lea r8d,[rdx-10h]             ; LEA(Lea_r32_m) [R8D,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8d 42 f0
0178h lea r9,[rax+40h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 40
017ch cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
0180h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 42 04 00 00
0186h mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
0189h cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
018dh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 35 04 00 00
0193h mov r11d,[r9+4]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 04
0197h shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
019ah or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
019dh cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
01a1h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 21 04 00 00
01a7h mov r11d,[r9+8]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 08
01abh shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
01afh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
01b2h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
01b6h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 0c 04 00 00
01bch mov r11d,[r9+0Ch]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 0c
01c0h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
01c4h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
01c7h cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
01cbh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 f7 03 00 00
01d1h mov r11d,[r9+10h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 10
01d5h shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
01d9h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
01dch cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
01e0h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 e2 03 00 00
01e6h mov r11d,[r9+14h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 14
01eah shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
01eeh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
01f1h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
01f5h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 cd 03 00 00
01fbh mov r11d,[r9+18h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 18
01ffh shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
0203h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0206h cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
020ah jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 b8 03 00 00
0210h mov r11d,[r9+1Ch]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 1c
0214h shl r11d,7                    ; SHL(Shl_rm32_imm8) [R11D,7h:imm8]                    encoding(4 bytes) = 41 c1 e3 07
0218h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
021bh cmp r8d,8                     ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 f8 08
021fh jb near ptr 05aah             ; JB(Jb_rel32_64) [5AAh:jmp64]                         encoding(6 bytes) = 0f 82 85 03 00 00
0225h add r8d,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [R8D,fffffffffffffff8h:imm32]     encoding(4 bytes) = 41 83 c0 f8
0229h add r9,20h                    ; ADD(Add_rm64_imm8) [R9,20h:imm64]                    encoding(4 bytes) = 49 83 c1 20
022dh cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
0231h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 91 03 00 00
0237h mov r11d,[r9]                 ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 19
023ah cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
023eh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 84 03 00 00
0244h mov esi,[r9+4]                ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 04
0248h shl esi,1                     ; SHL(Shl_rm32_1) [ESI,1h:imm8]                        encoding(2 bytes) = d1 e6
024ah or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
024dh cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
0251h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 71 03 00 00
0257h mov esi,[r9+8]                ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 08
025bh shl esi,2                     ; SHL(Shl_rm32_imm8) [ESI,2h:imm8]                     encoding(3 bytes) = c1 e6 02
025eh or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0261h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
0265h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 5d 03 00 00
026bh mov esi,[r9+0Ch]              ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 0c
026fh shl esi,3                     ; SHL(Shl_rm32_imm8) [ESI,3h:imm8]                     encoding(3 bytes) = c1 e6 03
0272h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0275h cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0279h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 49 03 00 00
027fh mov esi,[r9+10h]              ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 10
0283h shl esi,4                     ; SHL(Shl_rm32_imm8) [ESI,4h:imm8]                     encoding(3 bytes) = c1 e6 04
0286h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0289h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
028dh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 35 03 00 00
0293h mov esi,[r9+14h]              ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 14
0297h shl esi,5                     ; SHL(Shl_rm32_imm8) [ESI,5h:imm8]                     encoding(3 bytes) = c1 e6 05
029ah or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
029dh cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
02a1h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 21 03 00 00
02a7h mov esi,[r9+18h]              ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 18
02abh shl esi,6                     ; SHL(Shl_rm32_imm8) [ESI,6h:imm8]                     encoding(3 bytes) = c1 e6 06
02aeh or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
02b1h cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
02b5h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 0d 03 00 00
02bbh mov r8d,[r9+1Ch]              ; MOV(Mov_r32_rm32) [R8D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 41 1c
02bfh shl r8d,7                     ; SHL(Shl_rm32_imm8) [R8D,7h:imm8]                     encoding(4 bytes) = 41 c1 e0 07
02c3h or r11d,r8d                   ; OR(Or_r32_rm32) [R11D,R8D]                           encoding(3 bytes) = 45 0b d8
02c6h mov r8d,r11d                  ; MOV(Mov_r32_rm32) [R8D,R11D]                         encoding(3 bytes) = 45 8b c3
02c9h shl r8,8                      ; SHL(Shl_rm64_imm8) [R8,8h:imm8]                      encoding(4 bytes) = 49 c1 e0 08
02cdh or r10,r8                     ; OR(Or_r64_rm64) [R10,R8]                             encoding(3 bytes) = 4d 0b d0
02d0h mov r8,r10                    ; MOV(Mov_r64_rm64) [R8,R10]                           encoding(3 bytes) = 4d 8b c2
02d3h shl r8,10h                    ; SHL(Shl_rm64_imm8) [R8,10h:imm8]                     encoding(4 bytes) = 49 c1 e0 10
02d7h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
02dah cmp edx,20h                   ; CMP(Cmp_rm32_imm8) [EDX,20h:imm32]                   encoding(3 bytes) = 83 fa 20
02ddh jb near ptr 05b0h             ; JB(Jb_rel32_64) [5B0h:jmp64]                         encoding(6 bytes) = 0f 82 cd 02 00 00
02e3h add edx,0FFFFFFE0h            ; ADD(Add_rm32_imm8) [EDX,ffffffffffffffe0h:imm32]     encoding(3 bytes) = 83 c2 e0
02e6h add rax,80h                   ; ADD(Add_RAX_imm32) [RAX,80h:imm64]                   encoding(6 bytes) = 48 05 80 00 00 00
02ech cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
02efh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 d3 02 00 00
02f5h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
02f8h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
02fbh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 c7 02 00 00
0301h mov r9d,[rax+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 04
0305h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
0308h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
030bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
030eh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 b4 02 00 00
0314h mov r9d,[rax+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 08
0318h shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
031ch or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
031fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0322h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 a0 02 00 00
0328h mov r9d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 0c
032ch shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0330h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0333h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0336h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 8c 02 00 00
033ch mov r9d,[rax+10h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 10
0340h shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
0344h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0347h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
034ah jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 78 02 00 00
0350h mov r9d,[rax+14h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 14
0354h shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
0358h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
035bh cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
035eh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 64 02 00 00
0364h mov r9d,[rax+18h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 18
0368h shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
036ch or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
036fh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0372h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 50 02 00 00
0378h mov r9d,[rax+1Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 1c
037ch shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
0380h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0383h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
0386h jb near ptr 05b6h             ; JB(Jb_rel32_64) [5B6h:jmp64]                         encoding(6 bytes) = 0f 82 2a 02 00 00
038ch lea r9d,[rdx-8]               ; LEA(Lea_r32_m) [R9D,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8d 4a f8
0390h lea r10,[rax+20h]             ; LEA(Lea_r64_m) [R10,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 8d 50 20
0394h cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
0398h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 2a 02 00 00
039eh mov r11d,[r10]                ; MOV(Mov_r32_rm32) [R11D,mem(32u,R10:br,DS:sr)]       encoding(3 bytes) = 45 8b 1a
03a1h cmp r9d,1                     ; CMP(Cmp_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 f9 01
03a5h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 1d 02 00 00
03abh mov esi,[r10+4]               ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 04
03afh shl esi,1                     ; SHL(Shl_rm32_1) [ESI,1h:imm8]                        encoding(2 bytes) = d1 e6
03b1h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
03b4h cmp r9d,2                     ; CMP(Cmp_rm32_imm8) [R9D,2h:imm32]                    encoding(4 bytes) = 41 83 f9 02
03b8h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 0a 02 00 00
03beh mov esi,[r10+8]               ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 08
03c2h shl esi,2                     ; SHL(Shl_rm32_imm8) [ESI,2h:imm8]                     encoding(3 bytes) = c1 e6 02
03c5h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
03c8h cmp r9d,3                     ; CMP(Cmp_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 f9 03
03cch jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 f6 01 00 00
03d2h mov esi,[r10+0Ch]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 0c
03d6h shl esi,3                     ; SHL(Shl_rm32_imm8) [ESI,3h:imm8]                     encoding(3 bytes) = c1 e6 03
03d9h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
03dch cmp r9d,4                     ; CMP(Cmp_rm32_imm8) [R9D,4h:imm32]                    encoding(4 bytes) = 41 83 f9 04
03e0h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 e2 01 00 00
03e6h mov esi,[r10+10h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 10
03eah shl esi,4                     ; SHL(Shl_rm32_imm8) [ESI,4h:imm8]                     encoding(3 bytes) = c1 e6 04
03edh or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
03f0h cmp r9d,5                     ; CMP(Cmp_rm32_imm8) [R9D,5h:imm32]                    encoding(4 bytes) = 41 83 f9 05
03f4h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 ce 01 00 00
03fah mov esi,[r10+14h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 14
03feh shl esi,5                     ; SHL(Shl_rm32_imm8) [ESI,5h:imm8]                     encoding(3 bytes) = c1 e6 05
0401h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0404h cmp r9d,6                     ; CMP(Cmp_rm32_imm8) [R9D,6h:imm32]                    encoding(4 bytes) = 41 83 f9 06
0408h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 ba 01 00 00
040eh mov esi,[r10+18h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 18
0412h shl esi,6                     ; SHL(Shl_rm32_imm8) [ESI,6h:imm8]                     encoding(3 bytes) = c1 e6 06
0415h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0418h cmp r9d,7                     ; CMP(Cmp_rm32_imm8) [R9D,7h:imm32]                    encoding(4 bytes) = 41 83 f9 07
041ch jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 a6 01 00 00
0422h mov r9d,[r10+1Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 45 8b 4a 1c
0426h shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
042ah or r11d,r9d                   ; OR(Or_r32_rm32) [R11D,R9D]                           encoding(3 bytes) = 45 0b d9
042dh mov r9d,r11d                  ; MOV(Mov_r32_rm32) [R9D,R11D]                         encoding(3 bytes) = 45 8b cb
0430h shl r9,8                      ; SHL(Shl_rm64_imm8) [R9,8h:imm8]                      encoding(4 bytes) = 49 c1 e1 08
0434h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0437h cmp edx,10h                   ; CMP(Cmp_rm32_imm8) [EDX,10h:imm32]                   encoding(3 bytes) = 83 fa 10
043ah jb near ptr 05bch             ; JB(Jb_rel32_64) [5BCh:jmp64]                         encoding(6 bytes) = 0f 82 7c 01 00 00
0440h add edx,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [EDX,fffffffffffffff0h:imm32]     encoding(3 bytes) = 83 c2 f0
0443h add rax,40h                   ; ADD(Add_rm64_imm8) [RAX,40h:imm64]                   encoding(4 bytes) = 48 83 c0 40
0447h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
044ah jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 78 01 00 00
0450h mov r9d,[rax]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 08
0453h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0456h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 6c 01 00 00
045ch mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 04
0460h shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
0463h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0466h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0469h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 59 01 00 00
046fh mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 08
0473h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0477h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
047ah cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
047dh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 45 01 00 00
0483h mov r10d,[rax+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 0c
0487h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
048bh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
048eh cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0491h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 31 01 00 00
0497h mov r10d,[rax+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 10
049bh shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
049fh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
04a2h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
04a5h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 1d 01 00 00
04abh mov r10d,[rax+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 14
04afh shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
04b3h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
04b6h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
04b9h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 09 01 00 00
04bfh mov r10d,[rax+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 18
04c3h shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
04c7h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
04cah cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
04cdh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 f5 00 00 00
04d3h mov r10d,[rax+1Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 1c
04d7h shl r10d,7                    ; SHL(Shl_rm32_imm8) [R10D,7h:imm8]                    encoding(4 bytes) = 41 c1 e2 07
04dbh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
04deh cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
04e1h jb near ptr 05c2h             ; JB(Jb_rel32_64) [5C2h:jmp64]                         encoding(6 bytes) = 0f 82 db 00 00 00
04e7h add edx,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [EDX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 c2 f8
04eah add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
04eeh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
04f1h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 d1 00 00 00
04f7h mov r10d,[rax]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(3 bytes) = 44 8b 10
04fah cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
04fdh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 c5 00 00 00
0503h mov r11d,[rax+4]              ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 58 04
0507h shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
050ah or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
050dh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0510h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 b2 00 00 00
0516h mov r11d,[rax+8]              ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 58 08
051ah shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
051eh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0521h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0524h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 9e 00 00 00
052ah mov r11d,[rax+0Ch]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 58 0c
052eh shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
0532h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0535h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0538h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 8a 00 00 00
053eh mov r11d,[rax+10h]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 58 10
0542h shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
0546h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0549h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
054ch jbe short 05c8h               ; JBE(Jbe_rel8_64) [5C8h:jmp64]                        encoding(2 bytes) = 76 7a
054eh mov r11d,[rax+14h]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 58 14
0552h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0556h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0559h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
055ch jbe short 05c8h               ; JBE(Jbe_rel8_64) [5C8h:jmp64]                        encoding(2 bytes) = 76 6a
055eh mov r11d,[rax+18h]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 58 18
0562h shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
0566h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0569h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
056ch jbe short 05c8h               ; JBE(Jbe_rel8_64) [5C8h:jmp64]                        encoding(2 bytes) = 76 5a
056eh mov eax,[rax+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 1c
0571h shl eax,7                     ; SHL(Shl_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 e0 07
0574h or r10d,eax                   ; OR(Or_r32_rm32) [R10D,EAX]                           encoding(3 bytes) = 44 0b d0
0577h mov eax,r10d                  ; MOV(Mov_r32_rm32) [EAX,R10D]                         encoding(3 bytes) = 41 8b c2
057ah shl rax,8                     ; SHL(Shl_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e0 08
057eh or r9,rax                     ; OR(Or_r64_rm64) [R9,RAX]                             encoding(3 bytes) = 4c 0b c8
0581h mov rax,r9                    ; MOV(Mov_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 8b c1
0584h shl rax,10h                   ; SHL(Shl_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e0 10
0588h or r8,rax                     ; OR(Or_r64_rm64) [R8,RAX]                             encoding(3 bytes) = 4c 0b c0
058bh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
058eh shl rax,20h                   ; SHL(Shl_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e0 20
0592h or rcx,rax                    ; OR(Or_r64_rm64) [RCX,RAX]                            encoding(3 bytes) = 48 0b c8
0595h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0598h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
059ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
059dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
059eh call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966868h:jmp64]        encoding(5 bytes) = e8 c5 62 96 ff
05a3h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05a4h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966868h:jmp64]        encoding(5 bytes) = e8 bf 62 96 ff
05a9h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05aah call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966868h:jmp64]        encoding(5 bytes) = e8 b9 62 96 ff
05afh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05b0h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966868h:jmp64]        encoding(5 bytes) = e8 b3 62 96 ff
05b5h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05b6h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966868h:jmp64]        encoding(5 bytes) = e8 ad 62 96 ff
05bbh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05bch call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966868h:jmp64]        encoding(5 bytes) = e8 a7 62 96 ff
05c1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05c2h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966868h:jmp64]        encoding(5 bytes) = e8 a1 62 96 ff
05c7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05c8h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F5851A0h:jmp64]                encoding(5 bytes) = e8 d3 4b 58 5f
05cdh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[1486]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0x02,0x8B,0x52,0x08,0x48,0x8B,0xC8,0x44,0x8B,0xC2,0x41,0x83,0xF8,0x00,0x0F,0x86,0xAD,0x05,0x00,0x00,0x44,0x8B,0x09,0x41,0x83,0xF8,0x01,0x0F,0x86,0xA0,0x05,0x00,0x00,0x44,0x8B,0x51,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x02,0x0F,0x86,0x8C,0x05,0x00,0x00,0x44,0x8B,0x51,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x03,0x0F,0x86,0x77,0x05,0x00,0x00,0x44,0x8B,0x51,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x04,0x0F,0x86,0x62,0x05,0x00,0x00,0x44,0x8B,0x51,0x10,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x05,0x0F,0x86,0x4D,0x05,0x00,0x00,0x44,0x8B,0x51,0x14,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x06,0x0F,0x86,0x38,0x05,0x00,0x00,0x44,0x8B,0x51,0x18,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x07,0x0F,0x86,0x23,0x05,0x00,0x00,0x8B,0x49,0x1C,0xC1,0xE1,0x07,0x44,0x0B,0xC9,0x41,0x8B,0xC9,0x83,0xFA,0x08,0x0F,0x82,0xE4,0x04,0x00,0x00,0x44,0x8D,0x42,0xF8,0x4C,0x8D,0x48,0x20,0x41,0x83,0xF8,0x00,0x0F,0x86,0xFC,0x04,0x00,0x00,0x45,0x8B,0x11,0x41,0x83,0xF8,0x01,0x0F,0x86,0xEF,0x04,0x00,0x00,0x45,0x8B,0x59,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x02,0x0F,0x86,0xDB,0x04,0x00,0x00,0x45,0x8B,0x59,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x03,0x0F,0x86,0xC6,0x04,0x00,0x00,0x45,0x8B,0x59,0x0C,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x04,0x0F,0x86,0xB1,0x04,0x00,0x00,0x45,0x8B,0x59,0x10,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x05,0x0F,0x86,0x9C,0x04,0x00,0x00,0x45,0x8B,0x59,0x14,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x06,0x0F,0x86,0x87,0x04,0x00,0x00,0x45,0x8B,0x59,0x18,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x07,0x0F,0x86,0x72,0x04,0x00,0x00,0x45,0x8B,0x41,0x1C,0x41,0xC1,0xE0,0x07,0x45,0x0B,0xD0,0x45,0x8B,0xC2,0x49,0xC1,0xE0,0x08,0x49,0x0B,0xC8,0x83,0xFA,0x10,0x0F,0x82,0x30,0x04,0x00,0x00,0x44,0x8D,0x42,0xF0,0x4C,0x8D,0x48,0x40,0x41,0x83,0xF8,0x00,0x0F,0x86,0x42,0x04,0x00,0x00,0x45,0x8B,0x11,0x41,0x83,0xF8,0x01,0x0F,0x86,0x35,0x04,0x00,0x00,0x45,0x8B,0x59,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x02,0x0F,0x86,0x21,0x04,0x00,0x00,0x45,0x8B,0x59,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x03,0x0F,0x86,0x0C,0x04,0x00,0x00,0x45,0x8B,0x59,0x0C,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x04,0x0F,0x86,0xF7,0x03,0x00,0x00,0x45,0x8B,0x59,0x10,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x05,0x0F,0x86,0xE2,0x03,0x00,0x00,0x45,0x8B,0x59,0x14,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x06,0x0F,0x86,0xCD,0x03,0x00,0x00,0x45,0x8B,0x59,0x18,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x07,0x0F,0x86,0xB8,0x03,0x00,0x00,0x45,0x8B,0x59,0x1C,0x41,0xC1,0xE3,0x07,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x08,0x0F,0x82,0x85,0x03,0x00,0x00,0x41,0x83,0xC0,0xF8,0x49,0x83,0xC1,0x20,0x41,0x83,0xF8,0x00,0x0F,0x86,0x91,0x03,0x00,0x00,0x45,0x8B,0x19,0x41,0x83,0xF8,0x01,0x0F,0x86,0x84,0x03,0x00,0x00,0x41,0x8B,0x71,0x04,0xD1,0xE6,0x44,0x0B,0xDE,0x41,0x83,0xF8,0x02,0x0F,0x86,0x71,0x03,0x00,0x00,0x41,0x8B,0x71,0x08,0xC1,0xE6,0x02,0x44,0x0B,0xDE,0x41,0x83,0xF8,0x03,0x0F,0x86,0x5D,0x03,0x00,0x00,0x41,0x8B,0x71,0x0C,0xC1,0xE6,0x03,0x44,0x0B,0xDE,0x41,0x83,0xF8,0x04,0x0F,0x86,0x49,0x03,0x00,0x00,0x41,0x8B,0x71,0x10,0xC1,0xE6,0x04,0x44,0x0B,0xDE,0x41,0x83,0xF8,0x05,0x0F,0x86,0x35,0x03,0x00,0x00,0x41,0x8B,0x71,0x14,0xC1,0xE6,0x05,0x44,0x0B,0xDE,0x41,0x83,0xF8,0x06,0x0F,0x86,0x21,0x03,0x00,0x00,0x41,0x8B,0x71,0x18,0xC1,0xE6,0x06,0x44,0x0B,0xDE,0x41,0x83,0xF8,0x07,0x0F,0x86,0x0D,0x03,0x00,0x00,0x45,0x8B,0x41,0x1C,0x41,0xC1,0xE0,0x07,0x45,0x0B,0xD8,0x45,0x8B,0xC3,0x49,0xC1,0xE0,0x08,0x4D,0x0B,0xD0,0x4D,0x8B,0xC2,0x49,0xC1,0xE0,0x10,0x49,0x0B,0xC8,0x83,0xFA,0x20,0x0F,0x82,0xCD,0x02,0x00,0x00,0x83,0xC2,0xE0,0x48,0x05,0x80,0x00,0x00,0x00,0x83,0xFA,0x00,0x0F,0x86,0xD3,0x02,0x00,0x00,0x44,0x8B,0x00,0x83,0xFA,0x01,0x0F,0x86,0xC7,0x02,0x00,0x00,0x44,0x8B,0x48,0x04,0x41,0xD1,0xE1,0x45,0x0B,0xC1,0x83,0xFA,0x02,0x0F,0x86,0xB4,0x02,0x00,0x00,0x44,0x8B,0x48,0x08,0x41,0xC1,0xE1,0x02,0x45,0x0B,0xC1,0x83,0xFA,0x03,0x0F,0x86,0xA0,0x02,0x00,0x00,0x44,0x8B,0x48,0x0C,0x41,0xC1,0xE1,0x03,0x45,0x0B,0xC1,0x83,0xFA,0x04,0x0F,0x86,0x8C,0x02,0x00,0x00,0x44,0x8B,0x48,0x10,0x41,0xC1,0xE1,0x04,0x45,0x0B,0xC1,0x83,0xFA,0x05,0x0F,0x86,0x78,0x02,0x00,0x00,0x44,0x8B,0x48,0x14,0x41,0xC1,0xE1,0x05,0x45,0x0B,0xC1,0x83,0xFA,0x06,0x0F,0x86,0x64,0x02,0x00,0x00,0x44,0x8B,0x48,0x18,0x41,0xC1,0xE1,0x06,0x45,0x0B,0xC1,0x83,0xFA,0x07,0x0F,0x86,0x50,0x02,0x00,0x00,0x44,0x8B,0x48,0x1C,0x41,0xC1,0xE1,0x07,0x45,0x0B,0xC1,0x83,0xFA,0x08,0x0F,0x82,0x2A,0x02,0x00,0x00,0x44,0x8D,0x4A,0xF8,0x4C,0x8D,0x50,0x20,0x41,0x83,0xF9,0x00,0x0F,0x86,0x2A,0x02,0x00,0x00,0x45,0x8B,0x1A,0x41,0x83,0xF9,0x01,0x0F,0x86,0x1D,0x02,0x00,0x00,0x41,0x8B,0x72,0x04,0xD1,0xE6,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x02,0x0F,0x86,0x0A,0x02,0x00,0x00,0x41,0x8B,0x72,0x08,0xC1,0xE6,0x02,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x03,0x0F,0x86,0xF6,0x01,0x00,0x00,0x41,0x8B,0x72,0x0C,0xC1,0xE6,0x03,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x04,0x0F,0x86,0xE2,0x01,0x00,0x00,0x41,0x8B,0x72,0x10,0xC1,0xE6,0x04,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x05,0x0F,0x86,0xCE,0x01,0x00,0x00,0x41,0x8B,0x72,0x14,0xC1,0xE6,0x05,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x06,0x0F,0x86,0xBA,0x01,0x00,0x00,0x41,0x8B,0x72,0x18,0xC1,0xE6,0x06,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x07,0x0F,0x86,0xA6,0x01,0x00,0x00,0x45,0x8B,0x4A,0x1C,0x41,0xC1,0xE1,0x07,0x45,0x0B,0xD9,0x45,0x8B,0xCB,0x49,0xC1,0xE1,0x08,0x4D,0x0B,0xC1,0x83,0xFA,0x10,0x0F,0x82,0x7C,0x01,0x00,0x00,0x83,0xC2,0xF0,0x48,0x83,0xC0,0x40,0x83,0xFA,0x00,0x0F,0x86,0x78,0x01,0x00,0x00,0x44,0x8B,0x08,0x83,0xFA,0x01,0x0F,0x86,0x6C,0x01,0x00,0x00,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x83,0xFA,0x02,0x0F,0x86,0x59,0x01,0x00,0x00,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x83,0xFA,0x03,0x0F,0x86,0x45,0x01,0x00,0x00,0x44,0x8B,0x50,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x83,0xFA,0x04,0x0F,0x86,0x31,0x01,0x00,0x00,0x44,0x8B,0x50,0x10,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x83,0xFA,0x05,0x0F,0x86,0x1D,0x01,0x00,0x00,0x44,0x8B,0x50,0x14,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x83,0xFA,0x06,0x0F,0x86,0x09,0x01,0x00,0x00,0x44,0x8B,0x50,0x18,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x83,0xFA,0x07,0x0F,0x86,0xF5,0x00,0x00,0x00,0x44,0x8B,0x50,0x1C,0x41,0xC1,0xE2,0x07,0x45,0x0B,0xCA,0x83,0xFA,0x08,0x0F,0x82,0xDB,0x00,0x00,0x00,0x83,0xC2,0xF8,0x48,0x83,0xC0,0x20,0x83,0xFA,0x00,0x0F,0x86,0xD1,0x00,0x00,0x00,0x44,0x8B,0x10,0x83,0xFA,0x01,0x0F,0x86,0xC5,0x00,0x00,0x00,0x44,0x8B,0x58,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x83,0xFA,0x02,0x0F,0x86,0xB2,0x00,0x00,0x00,0x44,0x8B,0x58,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x83,0xFA,0x03,0x0F,0x86,0x9E,0x00,0x00,0x00,0x44,0x8B,0x58,0x0C,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x83,0xFA,0x04,0x0F,0x86,0x8A,0x00,0x00,0x00,0x44,0x8B,0x58,0x10,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x83,0xFA,0x05,0x76,0x7A,0x44,0x8B,0x58,0x14,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x83,0xFA,0x06,0x76,0x6A,0x44,0x8B,0x58,0x18,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x83,0xFA,0x07,0x76,0x5A,0x8B,0x40,0x1C,0xC1,0xE0,0x07,0x44,0x0B,0xD0,0x41,0x8B,0xC2,0x48,0xC1,0xE0,0x08,0x4C,0x0B,0xC8,0x49,0x8B,0xC1,0x48,0xC1,0xE0,0x10,0x4C,0x0B,0xC0,0x49,0x8B,0xC0,0x48,0xC1,0xE0,0x20,0x48,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x20,0x5E,0xC3,0xE8,0xC5,0x62,0x96,0xFF,0xCC,0xE8,0xBF,0x62,0x96,0xFF,0xCC,0xE8,0xB9,0x62,0x96,0xFF,0xCC,0xE8,0xB3,0x62,0x96,0xFF,0xCC,0xE8,0xAD,0x62,0x96,0xFF,0xCC,0xE8,0xA7,0x62,0x96,0xFF,0xCC,0xE8,0xA1,0x62,0x96,0xFF,0xCC,0xE8,0xD3,0x4B,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pack(Span<bit> src, out ulong lo, out ulong hi)
; location: [7FFDDBACA350h, 7FFDDBACB648h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,320h                  ; SUB(Sub_rm64_imm32) [RSP,320h:imm64]                 encoding(7 bytes) = 48 81 ec 20 03 00 00
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0013h lea rdi,[rsp+68h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 7c 24 68
0018h mov ecx,0ACh                  ; MOV(Mov_r32_imm32) [ECX,ach:imm32]                   encoding(5 bytes) = b9 ac 00 00 00
001dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001fh rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0021h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0024h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0027h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
002ah mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
002dh mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0030h mov r11,r9                    ; MOV(Mov_r64_rm64) [R11,R9]                           encoding(3 bytes) = 4d 8b d9
0033h mov esi,r10d                  ; MOV(Mov_r32_rm32) [ESI,R10D]                         encoding(3 bytes) = 41 8b f2
0036h cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
003ah jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 b3 12 00 00
0040h mov edi,[r9]                  ; MOV(Mov_r32_rm32) [EDI,mem(32u,R9:br,DS:sr)]         encoding(3 bytes) = 41 8b 39
0043h cmp r10d,1                    ; CMP(Cmp_rm32_imm8) [R10D,1h:imm32]                   encoding(4 bytes) = 41 83 fa 01
0047h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 a6 12 00 00
004dh mov ebx,[r9+4]                ; MOV(Mov_r32_rm32) [EBX,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 59 04
0051h shl ebx,1                     ; SHL(Shl_rm32_1) [EBX,1h:imm8]                        encoding(2 bytes) = d1 e3
0053h or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
0055h cmp r10d,2                    ; CMP(Cmp_rm32_imm8) [R10D,2h:imm32]                   encoding(4 bytes) = 41 83 fa 02
0059h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 94 12 00 00
005fh mov ebx,[r9+8]                ; MOV(Mov_r32_rm32) [EBX,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 59 08
0063h shl ebx,2                     ; SHL(Shl_rm32_imm8) [EBX,2h:imm8]                     encoding(3 bytes) = c1 e3 02
0066h or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
0068h cmp r10d,3                    ; CMP(Cmp_rm32_imm8) [R10D,3h:imm32]                   encoding(4 bytes) = 41 83 fa 03
006ch jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 81 12 00 00
0072h mov ebx,[r9+0Ch]              ; MOV(Mov_r32_rm32) [EBX,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 59 0c
0076h shl ebx,3                     ; SHL(Shl_rm32_imm8) [EBX,3h:imm8]                     encoding(3 bytes) = c1 e3 03
0079h or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
007bh cmp r10d,4                    ; CMP(Cmp_rm32_imm8) [R10D,4h:imm32]                   encoding(4 bytes) = 41 83 fa 04
007fh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 6e 12 00 00
0085h mov ebx,[r9+10h]              ; MOV(Mov_r32_rm32) [EBX,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 59 10
0089h shl ebx,4                     ; SHL(Shl_rm32_imm8) [EBX,4h:imm8]                     encoding(3 bytes) = c1 e3 04
008ch or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
008eh cmp r10d,5                    ; CMP(Cmp_rm32_imm8) [R10D,5h:imm32]                   encoding(4 bytes) = 41 83 fa 05
0092h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 5b 12 00 00
0098h mov ebx,[r9+14h]              ; MOV(Mov_r32_rm32) [EBX,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 59 14
009ch shl ebx,5                     ; SHL(Shl_rm32_imm8) [EBX,5h:imm8]                     encoding(3 bytes) = c1 e3 05
009fh or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
00a1h cmp r10d,6                    ; CMP(Cmp_rm32_imm8) [R10D,6h:imm32]                   encoding(4 bytes) = 41 83 fa 06
00a5h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 48 12 00 00
00abh mov r9d,[r9+18h]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 18
00afh shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
00b3h or edi,r9d                    ; OR(Or_r32_rm32) [EDI,R9D]                            encoding(3 bytes) = 41 0b f9
00b6h cmp esi,7                     ; CMP(Cmp_rm32_imm8) [ESI,7h:imm32]                    encoding(3 bytes) = 83 fe 07
00b9h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 34 12 00 00
00bfh mov r9d,[r11+1Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 45 8b 4b 1c
00c3h shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
00c7h or edi,r9d                    ; OR(Or_r32_rm32) [EDI,R9D]                            encoding(3 bytes) = 41 0b f9
00cah mov r9d,edi                   ; MOV(Mov_r32_rm32) [R9D,EDI]                          encoding(3 bytes) = 44 8b cf
00cdh cmp ecx,8                     ; CMP(Cmp_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 f9 08
00d0h jb near ptr 1299h             ; JB(Jb_rel32_64) [1299h:jmp64]                        encoding(6 bytes) = 0f 82 c3 11 00 00
00d6h lea r10d,[rcx-8]              ; LEA(Lea_r32_m) [R10D,mem(Unknown,RCX:br,DS:sr)]      encoding(4 bytes) = 44 8d 51 f8
00dah lea r11,[rax+20h]             ; LEA(Lea_r64_m) [R11,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 8d 58 20
00deh cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
00e2h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 0b 12 00 00
00e8h mov esi,[r11]                 ; MOV(Mov_r32_rm32) [ESI,mem(32u,R11:br,DS:sr)]        encoding(3 bytes) = 41 8b 33
00ebh cmp r10d,1                    ; CMP(Cmp_rm32_imm8) [R10D,1h:imm32]                   encoding(4 bytes) = 41 83 fa 01
00efh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 fe 11 00 00
00f5h mov edi,[r11+4]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 04
00f9h shl edi,1                     ; SHL(Shl_rm32_1) [EDI,1h:imm8]                        encoding(2 bytes) = d1 e7
00fbh or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
00fdh cmp r10d,2                    ; CMP(Cmp_rm32_imm8) [R10D,2h:imm32]                   encoding(4 bytes) = 41 83 fa 02
0101h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 ec 11 00 00
0107h mov edi,[r11+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 08
010bh shl edi,2                     ; SHL(Shl_rm32_imm8) [EDI,2h:imm8]                     encoding(3 bytes) = c1 e7 02
010eh or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
0110h cmp r10d,3                    ; CMP(Cmp_rm32_imm8) [R10D,3h:imm32]                   encoding(4 bytes) = 41 83 fa 03
0114h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 d9 11 00 00
011ah mov edi,[r11+0Ch]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 0c
011eh shl edi,3                     ; SHL(Shl_rm32_imm8) [EDI,3h:imm8]                     encoding(3 bytes) = c1 e7 03
0121h or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
0123h cmp r10d,4                    ; CMP(Cmp_rm32_imm8) [R10D,4h:imm32]                   encoding(4 bytes) = 41 83 fa 04
0127h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 c6 11 00 00
012dh mov edi,[r11+10h]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 10
0131h shl edi,4                     ; SHL(Shl_rm32_imm8) [EDI,4h:imm8]                     encoding(3 bytes) = c1 e7 04
0134h or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
0136h cmp r10d,5                    ; CMP(Cmp_rm32_imm8) [R10D,5h:imm32]                   encoding(4 bytes) = 41 83 fa 05
013ah jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 b3 11 00 00
0140h mov edi,[r11+14h]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 14
0144h shl edi,5                     ; SHL(Shl_rm32_imm8) [EDI,5h:imm8]                     encoding(3 bytes) = c1 e7 05
0147h or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
0149h cmp r10d,6                    ; CMP(Cmp_rm32_imm8) [R10D,6h:imm32]                   encoding(4 bytes) = 41 83 fa 06
014dh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 a0 11 00 00
0153h mov edi,[r11+18h]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 18
0157h shl edi,6                     ; SHL(Shl_rm32_imm8) [EDI,6h:imm8]                     encoding(3 bytes) = c1 e7 06
015ah or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
015ch cmp r10d,7                    ; CMP(Cmp_rm32_imm8) [R10D,7h:imm32]                   encoding(4 bytes) = 41 83 fa 07
0160h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 8d 11 00 00
0166h mov r10d,[r11+1Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R11:br,DS:sr)]       encoding(4 bytes) = 45 8b 53 1c
016ah shl r10d,7                    ; SHL(Shl_rm32_imm8) [R10D,7h:imm8]                    encoding(4 bytes) = 41 c1 e2 07
016eh or esi,r10d                   ; OR(Or_r32_rm32) [ESI,R10D]                           encoding(3 bytes) = 41 0b f2
0171h mov r10d,esi                  ; MOV(Mov_r32_rm32) [R10D,ESI]                         encoding(3 bytes) = 44 8b d6
0174h shl r10,8                     ; SHL(Shl_rm64_imm8) [R10,8h:imm8]                     encoding(4 bytes) = 49 c1 e2 08
0178h or r9,r10                     ; OR(Or_r64_rm64) [R9,R10]                             encoding(3 bytes) = 4d 0b ca
017bh cmp ecx,10h                   ; CMP(Cmp_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 f9 10
017eh jb near ptr 129fh             ; JB(Jb_rel32_64) [129Fh:jmp64]                        encoding(6 bytes) = 0f 82 1b 11 00 00
0184h lea r10d,[rcx-10h]            ; LEA(Lea_r32_m) [R10D,mem(Unknown,RCX:br,DS:sr)]      encoding(4 bytes) = 44 8d 51 f0
0188h lea r11,[rax+40h]             ; LEA(Lea_r64_m) [R11,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 8d 58 40
018ch cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
0190h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 5d 11 00 00
0196h mov esi,[r11]                 ; MOV(Mov_r32_rm32) [ESI,mem(32u,R11:br,DS:sr)]        encoding(3 bytes) = 41 8b 33
0199h cmp r10d,1                    ; CMP(Cmp_rm32_imm8) [R10D,1h:imm32]                   encoding(4 bytes) = 41 83 fa 01
019dh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 50 11 00 00
01a3h mov edi,[r11+4]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 04
01a7h shl edi,1                     ; SHL(Shl_rm32_1) [EDI,1h:imm8]                        encoding(2 bytes) = d1 e7
01a9h or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
01abh cmp r10d,2                    ; CMP(Cmp_rm32_imm8) [R10D,2h:imm32]                   encoding(4 bytes) = 41 83 fa 02
01afh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 3e 11 00 00
01b5h mov edi,[r11+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 08
01b9h shl edi,2                     ; SHL(Shl_rm32_imm8) [EDI,2h:imm8]                     encoding(3 bytes) = c1 e7 02
01bch or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
01beh cmp r10d,3                    ; CMP(Cmp_rm32_imm8) [R10D,3h:imm32]                   encoding(4 bytes) = 41 83 fa 03
01c2h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 2b 11 00 00
01c8h mov edi,[r11+0Ch]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 0c
01cch shl edi,3                     ; SHL(Shl_rm32_imm8) [EDI,3h:imm8]                     encoding(3 bytes) = c1 e7 03
01cfh or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
01d1h cmp r10d,4                    ; CMP(Cmp_rm32_imm8) [R10D,4h:imm32]                   encoding(4 bytes) = 41 83 fa 04
01d5h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 18 11 00 00
01dbh mov edi,[r11+10h]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 10
01dfh shl edi,4                     ; SHL(Shl_rm32_imm8) [EDI,4h:imm8]                     encoding(3 bytes) = c1 e7 04
01e2h or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
01e4h cmp r10d,5                    ; CMP(Cmp_rm32_imm8) [R10D,5h:imm32]                   encoding(4 bytes) = 41 83 fa 05
01e8h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 05 11 00 00
01eeh mov edi,[r11+14h]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 14
01f2h shl edi,5                     ; SHL(Shl_rm32_imm8) [EDI,5h:imm8]                     encoding(3 bytes) = c1 e7 05
01f5h or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
01f7h cmp r10d,6                    ; CMP(Cmp_rm32_imm8) [R10D,6h:imm32]                   encoding(4 bytes) = 41 83 fa 06
01fbh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 f2 10 00 00
0201h mov edi,[r11+18h]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 18
0205h shl edi,6                     ; SHL(Shl_rm32_imm8) [EDI,6h:imm8]                     encoding(3 bytes) = c1 e7 06
0208h or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
020ah cmp r10d,7                    ; CMP(Cmp_rm32_imm8) [R10D,7h:imm32]                   encoding(4 bytes) = 41 83 fa 07
020eh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 df 10 00 00
0214h mov edi,[r11+1Ch]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 1c
0218h shl edi,7                     ; SHL(Shl_rm32_imm8) [EDI,7h:imm8]                     encoding(3 bytes) = c1 e7 07
021bh or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
021dh cmp r10d,8                    ; CMP(Cmp_rm32_imm8) [R10D,8h:imm32]                   encoding(4 bytes) = 41 83 fa 08
0221h jb near ptr 12a5h             ; JB(Jb_rel32_64) [12A5h:jmp64]                        encoding(6 bytes) = 0f 82 7e 10 00 00
0227h add r10d,0FFFFFFF8h           ; ADD(Add_rm32_imm8) [R10D,fffffffffffffff8h:imm32]    encoding(4 bytes) = 41 83 c2 f8
022bh add r11,20h                   ; ADD(Add_rm64_imm8) [R11,20h:imm64]                   encoding(4 bytes) = 49 83 c3 20
022fh cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
0233h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 ba 10 00 00
0239h mov edi,[r11]                 ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(3 bytes) = 41 8b 3b
023ch cmp r10d,1                    ; CMP(Cmp_rm32_imm8) [R10D,1h:imm32]                   encoding(4 bytes) = 41 83 fa 01
0240h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 ad 10 00 00
0246h mov ebx,[r11+4]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 04
024ah shl ebx,1                     ; SHL(Shl_rm32_1) [EBX,1h:imm8]                        encoding(2 bytes) = d1 e3
024ch or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
024eh cmp r10d,2                    ; CMP(Cmp_rm32_imm8) [R10D,2h:imm32]                   encoding(4 bytes) = 41 83 fa 02
0252h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 9b 10 00 00
0258h mov ebx,[r11+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 08
025ch shl ebx,2                     ; SHL(Shl_rm32_imm8) [EBX,2h:imm8]                     encoding(3 bytes) = c1 e3 02
025fh or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
0261h cmp r10d,3                    ; CMP(Cmp_rm32_imm8) [R10D,3h:imm32]                   encoding(4 bytes) = 41 83 fa 03
0265h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 88 10 00 00
026bh mov ebx,[r11+0Ch]             ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 0c
026fh shl ebx,3                     ; SHL(Shl_rm32_imm8) [EBX,3h:imm8]                     encoding(3 bytes) = c1 e3 03
0272h or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
0274h cmp r10d,4                    ; CMP(Cmp_rm32_imm8) [R10D,4h:imm32]                   encoding(4 bytes) = 41 83 fa 04
0278h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 75 10 00 00
027eh mov ebx,[r11+10h]             ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 10
0282h shl ebx,4                     ; SHL(Shl_rm32_imm8) [EBX,4h:imm8]                     encoding(3 bytes) = c1 e3 04
0285h or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
0287h cmp r10d,5                    ; CMP(Cmp_rm32_imm8) [R10D,5h:imm32]                   encoding(4 bytes) = 41 83 fa 05
028bh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 62 10 00 00
0291h mov ebx,[r11+14h]             ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 14
0295h shl ebx,5                     ; SHL(Shl_rm32_imm8) [EBX,5h:imm8]                     encoding(3 bytes) = c1 e3 05
0298h or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
029ah cmp r10d,6                    ; CMP(Cmp_rm32_imm8) [R10D,6h:imm32]                   encoding(4 bytes) = 41 83 fa 06
029eh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 4f 10 00 00
02a4h mov ebx,[r11+18h]             ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 18
02a8h shl ebx,6                     ; SHL(Shl_rm32_imm8) [EBX,6h:imm8]                     encoding(3 bytes) = c1 e3 06
02abh or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
02adh cmp r10d,7                    ; CMP(Cmp_rm32_imm8) [R10D,7h:imm32]                   encoding(4 bytes) = 41 83 fa 07
02b1h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 3c 10 00 00
02b7h mov r10d,[r11+1Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R11:br,DS:sr)]       encoding(4 bytes) = 45 8b 53 1c
02bbh shl r10d,7                    ; SHL(Shl_rm32_imm8) [R10D,7h:imm8]                    encoding(4 bytes) = 41 c1 e2 07
02bfh or edi,r10d                   ; OR(Or_r32_rm32) [EDI,R10D]                           encoding(3 bytes) = 41 0b fa
02c2h mov r10d,edi                  ; MOV(Mov_r32_rm32) [R10D,EDI]                         encoding(3 bytes) = 44 8b d7
02c5h shl r10,8                     ; SHL(Shl_rm64_imm8) [R10,8h:imm8]                     encoding(4 bytes) = 49 c1 e2 08
02c9h or rsi,r10                    ; OR(Or_r64_rm64) [RSI,R10]                            encoding(3 bytes) = 49 0b f2
02cch mov r10,rsi                   ; MOV(Mov_r64_rm64) [R10,RSI]                          encoding(3 bytes) = 4c 8b d6
02cfh shl r10,10h                   ; SHL(Shl_rm64_imm8) [R10,10h:imm8]                    encoding(4 bytes) = 49 c1 e2 10
02d3h or r9,r10                     ; OR(Or_r64_rm64) [R9,R10]                             encoding(3 bytes) = 4d 0b ca
02d6h cmp ecx,20h                   ; CMP(Cmp_rm32_imm8) [ECX,20h:imm32]                   encoding(3 bytes) = 83 f9 20
02d9h jb near ptr 12abh             ; JB(Jb_rel32_64) [12ABh:jmp64]                        encoding(6 bytes) = 0f 82 cc 0f 00 00
02dfh lea r10d,[rcx-20h]            ; LEA(Lea_r32_m) [R10D,mem(Unknown,RCX:br,DS:sr)]      encoding(4 bytes) = 44 8d 51 e0
02e3h lea r11,[rax+80h]             ; LEA(Lea_r64_m) [R11,mem(Unknown,RAX:br,DS:sr)]       encoding(7 bytes) = 4c 8d 98 80 00 00 00
02eah cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
02eeh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 ff 0f 00 00
02f4h mov esi,[r11]                 ; MOV(Mov_r32_rm32) [ESI,mem(32u,R11:br,DS:sr)]        encoding(3 bytes) = 41 8b 33
02f7h cmp r10d,1                    ; CMP(Cmp_rm32_imm8) [R10D,1h:imm32]                   encoding(4 bytes) = 41 83 fa 01
02fbh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 f2 0f 00 00
0301h mov edi,[r11+4]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 04
0305h shl edi,1                     ; SHL(Shl_rm32_1) [EDI,1h:imm8]                        encoding(2 bytes) = d1 e7
0307h or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
0309h cmp r10d,2                    ; CMP(Cmp_rm32_imm8) [R10D,2h:imm32]                   encoding(4 bytes) = 41 83 fa 02
030dh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 e0 0f 00 00
0313h mov edi,[r11+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 08
0317h shl edi,2                     ; SHL(Shl_rm32_imm8) [EDI,2h:imm8]                     encoding(3 bytes) = c1 e7 02
031ah or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
031ch cmp r10d,3                    ; CMP(Cmp_rm32_imm8) [R10D,3h:imm32]                   encoding(4 bytes) = 41 83 fa 03
0320h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 cd 0f 00 00
0326h mov edi,[r11+0Ch]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 0c
032ah shl edi,3                     ; SHL(Shl_rm32_imm8) [EDI,3h:imm8]                     encoding(3 bytes) = c1 e7 03
032dh or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
032fh cmp r10d,4                    ; CMP(Cmp_rm32_imm8) [R10D,4h:imm32]                   encoding(4 bytes) = 41 83 fa 04
0333h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 ba 0f 00 00
0339h mov edi,[r11+10h]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 10
033dh shl edi,4                     ; SHL(Shl_rm32_imm8) [EDI,4h:imm8]                     encoding(3 bytes) = c1 e7 04
0340h or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
0342h cmp r10d,5                    ; CMP(Cmp_rm32_imm8) [R10D,5h:imm32]                   encoding(4 bytes) = 41 83 fa 05
0346h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 a7 0f 00 00
034ch mov edi,[r11+14h]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 14
0350h shl edi,5                     ; SHL(Shl_rm32_imm8) [EDI,5h:imm8]                     encoding(3 bytes) = c1 e7 05
0353h or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
0355h cmp r10d,6                    ; CMP(Cmp_rm32_imm8) [R10D,6h:imm32]                   encoding(4 bytes) = 41 83 fa 06
0359h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 94 0f 00 00
035fh mov edi,[r11+18h]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 18
0363h shl edi,6                     ; SHL(Shl_rm32_imm8) [EDI,6h:imm8]                     encoding(3 bytes) = c1 e7 06
0366h or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
0368h cmp r10d,7                    ; CMP(Cmp_rm32_imm8) [R10D,7h:imm32]                   encoding(4 bytes) = 41 83 fa 07
036ch jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 81 0f 00 00
0372h mov edi,[r11+1Ch]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 7b 1c
0376h shl edi,7                     ; SHL(Shl_rm32_imm8) [EDI,7h:imm8]                     encoding(3 bytes) = c1 e7 07
0379h or esi,edi                    ; OR(Or_r32_rm32) [ESI,EDI]                            encoding(2 bytes) = 0b f7
037bh cmp r10d,8                    ; CMP(Cmp_rm32_imm8) [R10D,8h:imm32]                   encoding(4 bytes) = 41 83 fa 08
037fh jb near ptr 12b1h             ; JB(Jb_rel32_64) [12B1h:jmp64]                        encoding(6 bytes) = 0f 82 2c 0f 00 00
0385h lea edi,[r10-8]               ; LEA(Lea_r32_m) [EDI,mem(Unknown,R10:br,DS:sr)]       encoding(4 bytes) = 41 8d 7a f8
0389h lea rbx,[r11+20h]             ; LEA(Lea_r64_m) [RBX,mem(Unknown,R11:br,DS:sr)]       encoding(4 bytes) = 49 8d 5b 20
038dh cmp edi,0                     ; CMP(Cmp_rm32_imm8) [EDI,0h:imm32]                    encoding(3 bytes) = 83 ff 00
0390h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 5d 0f 00 00
0396h mov ebp,[rbx]                 ; MOV(Mov_r32_rm32) [EBP,mem(32u,RBX:br,DS:sr)]        encoding(2 bytes) = 8b 2b
0398h cmp edi,1                     ; CMP(Cmp_rm32_imm8) [EDI,1h:imm32]                    encoding(3 bytes) = 83 ff 01
039bh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 52 0f 00 00
03a1h mov r14d,[rbx+4]              ; MOV(Mov_r32_rm32) [R14D,mem(32u,RBX:br,DS:sr)]       encoding(4 bytes) = 44 8b 73 04
03a5h shl r14d,1                    ; SHL(Shl_rm32_1) [R14D,1h:imm8]                       encoding(3 bytes) = 41 d1 e6
03a8h or ebp,r14d                   ; OR(Or_r32_rm32) [EBP,R14D]                           encoding(3 bytes) = 41 0b ee
03abh cmp edi,2                     ; CMP(Cmp_rm32_imm8) [EDI,2h:imm32]                    encoding(3 bytes) = 83 ff 02
03aeh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 3f 0f 00 00
03b4h mov r14d,[rbx+8]              ; MOV(Mov_r32_rm32) [R14D,mem(32u,RBX:br,DS:sr)]       encoding(4 bytes) = 44 8b 73 08
03b8h shl r14d,2                    ; SHL(Shl_rm32_imm8) [R14D,2h:imm8]                    encoding(4 bytes) = 41 c1 e6 02
03bch or ebp,r14d                   ; OR(Or_r32_rm32) [EBP,R14D]                           encoding(3 bytes) = 41 0b ee
03bfh cmp edi,3                     ; CMP(Cmp_rm32_imm8) [EDI,3h:imm32]                    encoding(3 bytes) = 83 ff 03
03c2h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 2b 0f 00 00
03c8h mov r14d,[rbx+0Ch]            ; MOV(Mov_r32_rm32) [R14D,mem(32u,RBX:br,DS:sr)]       encoding(4 bytes) = 44 8b 73 0c
03cch shl r14d,3                    ; SHL(Shl_rm32_imm8) [R14D,3h:imm8]                    encoding(4 bytes) = 41 c1 e6 03
03d0h or ebp,r14d                   ; OR(Or_r32_rm32) [EBP,R14D]                           encoding(3 bytes) = 41 0b ee
03d3h cmp edi,4                     ; CMP(Cmp_rm32_imm8) [EDI,4h:imm32]                    encoding(3 bytes) = 83 ff 04
03d6h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 17 0f 00 00
03dch mov r14d,[rbx+10h]            ; MOV(Mov_r32_rm32) [R14D,mem(32u,RBX:br,DS:sr)]       encoding(4 bytes) = 44 8b 73 10
03e0h shl r14d,4                    ; SHL(Shl_rm32_imm8) [R14D,4h:imm8]                    encoding(4 bytes) = 41 c1 e6 04
03e4h or ebp,r14d                   ; OR(Or_r32_rm32) [EBP,R14D]                           encoding(3 bytes) = 41 0b ee
03e7h cmp edi,5                     ; CMP(Cmp_rm32_imm8) [EDI,5h:imm32]                    encoding(3 bytes) = 83 ff 05
03eah jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 03 0f 00 00
03f0h mov r14d,[rbx+14h]            ; MOV(Mov_r32_rm32) [R14D,mem(32u,RBX:br,DS:sr)]       encoding(4 bytes) = 44 8b 73 14
03f4h shl r14d,5                    ; SHL(Shl_rm32_imm8) [R14D,5h:imm8]                    encoding(4 bytes) = 41 c1 e6 05
03f8h or ebp,r14d                   ; OR(Or_r32_rm32) [EBP,R14D]                           encoding(3 bytes) = 41 0b ee
03fbh cmp edi,6                     ; CMP(Cmp_rm32_imm8) [EDI,6h:imm32]                    encoding(3 bytes) = 83 ff 06
03feh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 ef 0e 00 00
0404h mov r14d,[rbx+18h]            ; MOV(Mov_r32_rm32) [R14D,mem(32u,RBX:br,DS:sr)]       encoding(4 bytes) = 44 8b 73 18
0408h shl r14d,6                    ; SHL(Shl_rm32_imm8) [R14D,6h:imm8]                    encoding(4 bytes) = 41 c1 e6 06
040ch or ebp,r14d                   ; OR(Or_r32_rm32) [EBP,R14D]                           encoding(3 bytes) = 41 0b ee
040fh cmp edi,7                     ; CMP(Cmp_rm32_imm8) [EDI,7h:imm32]                    encoding(3 bytes) = 83 ff 07
0412h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 db 0e 00 00
0418h mov edi,[rbx+1Ch]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,RBX:br,DS:sr)]        encoding(3 bytes) = 8b 7b 1c
041bh shl edi,7                     ; SHL(Shl_rm32_imm8) [EDI,7h:imm8]                     encoding(3 bytes) = c1 e7 07
041eh or ebp,edi                    ; OR(Or_r32_rm32) [EBP,EDI]                            encoding(2 bytes) = 0b ef
0420h mov edi,ebp                   ; MOV(Mov_r32_rm32) [EDI,EBP]                          encoding(2 bytes) = 8b fd
0422h shl rdi,8                     ; SHL(Shl_rm64_imm8) [RDI,8h:imm8]                     encoding(4 bytes) = 48 c1 e7 08
0426h or rsi,rdi                    ; OR(Or_r64_rm64) [RSI,RDI]                            encoding(3 bytes) = 48 0b f7
0429h cmp r10d,10h                  ; CMP(Cmp_rm32_imm8) [R10D,10h:imm32]                  encoding(4 bytes) = 41 83 fa 10
042dh jb near ptr 12b7h             ; JB(Jb_rel32_64) [12B7h:jmp64]                        encoding(6 bytes) = 0f 82 84 0e 00 00
0433h add r10d,0FFFFFFF0h           ; ADD(Add_rm32_imm8) [R10D,fffffffffffffff0h:imm32]    encoding(4 bytes) = 41 83 c2 f0
0437h add r11,40h                   ; ADD(Add_rm64_imm8) [R11,40h:imm64]                   encoding(4 bytes) = 49 83 c3 40
043bh cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
043fh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 ae 0e 00 00
0445h mov edi,[r11]                 ; MOV(Mov_r32_rm32) [EDI,mem(32u,R11:br,DS:sr)]        encoding(3 bytes) = 41 8b 3b
0448h cmp r10d,1                    ; CMP(Cmp_rm32_imm8) [R10D,1h:imm32]                   encoding(4 bytes) = 41 83 fa 01
044ch jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 a1 0e 00 00
0452h mov ebx,[r11+4]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 04
0456h shl ebx,1                     ; SHL(Shl_rm32_1) [EBX,1h:imm8]                        encoding(2 bytes) = d1 e3
0458h or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
045ah cmp r10d,2                    ; CMP(Cmp_rm32_imm8) [R10D,2h:imm32]                   encoding(4 bytes) = 41 83 fa 02
045eh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 8f 0e 00 00
0464h mov ebx,[r11+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 08
0468h shl ebx,2                     ; SHL(Shl_rm32_imm8) [EBX,2h:imm8]                     encoding(3 bytes) = c1 e3 02
046bh or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
046dh cmp r10d,3                    ; CMP(Cmp_rm32_imm8) [R10D,3h:imm32]                   encoding(4 bytes) = 41 83 fa 03
0471h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 7c 0e 00 00
0477h mov ebx,[r11+0Ch]             ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 0c
047bh shl ebx,3                     ; SHL(Shl_rm32_imm8) [EBX,3h:imm8]                     encoding(3 bytes) = c1 e3 03
047eh or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
0480h cmp r10d,4                    ; CMP(Cmp_rm32_imm8) [R10D,4h:imm32]                   encoding(4 bytes) = 41 83 fa 04
0484h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 69 0e 00 00
048ah mov ebx,[r11+10h]             ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 10
048eh shl ebx,4                     ; SHL(Shl_rm32_imm8) [EBX,4h:imm8]                     encoding(3 bytes) = c1 e3 04
0491h or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
0493h cmp r10d,5                    ; CMP(Cmp_rm32_imm8) [R10D,5h:imm32]                   encoding(4 bytes) = 41 83 fa 05
0497h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 56 0e 00 00
049dh mov ebx,[r11+14h]             ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 14
04a1h shl ebx,5                     ; SHL(Shl_rm32_imm8) [EBX,5h:imm8]                     encoding(3 bytes) = c1 e3 05
04a4h or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
04a6h cmp r10d,6                    ; CMP(Cmp_rm32_imm8) [R10D,6h:imm32]                   encoding(4 bytes) = 41 83 fa 06
04aah jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 43 0e 00 00
04b0h mov ebx,[r11+18h]             ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 18
04b4h shl ebx,6                     ; SHL(Shl_rm32_imm8) [EBX,6h:imm8]                     encoding(3 bytes) = c1 e3 06
04b7h or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
04b9h cmp r10d,7                    ; CMP(Cmp_rm32_imm8) [R10D,7h:imm32]                   encoding(4 bytes) = 41 83 fa 07
04bdh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 30 0e 00 00
04c3h mov ebx,[r11+1Ch]             ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 5b 1c
04c7h shl ebx,7                     ; SHL(Shl_rm32_imm8) [EBX,7h:imm8]                     encoding(3 bytes) = c1 e3 07
04cah or edi,ebx                    ; OR(Or_r32_rm32) [EDI,EBX]                            encoding(2 bytes) = 0b fb
04cch cmp r10d,8                    ; CMP(Cmp_rm32_imm8) [R10D,8h:imm32]                   encoding(4 bytes) = 41 83 fa 08
04d0h jb near ptr 12bdh             ; JB(Jb_rel32_64) [12BDh:jmp64]                        encoding(6 bytes) = 0f 82 e7 0d 00 00
04d6h add r10d,0FFFFFFF8h           ; ADD(Add_rm32_imm8) [R10D,fffffffffffffff8h:imm32]    encoding(4 bytes) = 41 83 c2 f8
04dah add r11,20h                   ; ADD(Add_rm64_imm8) [R11,20h:imm64]                   encoding(4 bytes) = 49 83 c3 20
04deh cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
04e2h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 0b 0e 00 00
04e8h mov ebx,[r11]                 ; MOV(Mov_r32_rm32) [EBX,mem(32u,R11:br,DS:sr)]        encoding(3 bytes) = 41 8b 1b
04ebh cmp r10d,1                    ; CMP(Cmp_rm32_imm8) [R10D,1h:imm32]                   encoding(4 bytes) = 41 83 fa 01
04efh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 fe 0d 00 00
04f5h mov ebp,[r11+4]               ; MOV(Mov_r32_rm32) [EBP,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 6b 04
04f9h shl ebp,1                     ; SHL(Shl_rm32_1) [EBP,1h:imm8]                        encoding(2 bytes) = d1 e5
04fbh or ebx,ebp                    ; OR(Or_r32_rm32) [EBX,EBP]                            encoding(2 bytes) = 0b dd
04fdh cmp r10d,2                    ; CMP(Cmp_rm32_imm8) [R10D,2h:imm32]                   encoding(4 bytes) = 41 83 fa 02
0501h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 ec 0d 00 00
0507h mov ebp,[r11+8]               ; MOV(Mov_r32_rm32) [EBP,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 6b 08
050bh shl ebp,2                     ; SHL(Shl_rm32_imm8) [EBP,2h:imm8]                     encoding(3 bytes) = c1 e5 02
050eh or ebx,ebp                    ; OR(Or_r32_rm32) [EBX,EBP]                            encoding(2 bytes) = 0b dd
0510h cmp r10d,3                    ; CMP(Cmp_rm32_imm8) [R10D,3h:imm32]                   encoding(4 bytes) = 41 83 fa 03
0514h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 d9 0d 00 00
051ah mov ebp,[r11+0Ch]             ; MOV(Mov_r32_rm32) [EBP,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 6b 0c
051eh shl ebp,3                     ; SHL(Shl_rm32_imm8) [EBP,3h:imm8]                     encoding(3 bytes) = c1 e5 03
0521h or ebx,ebp                    ; OR(Or_r32_rm32) [EBX,EBP]                            encoding(2 bytes) = 0b dd
0523h cmp r10d,4                    ; CMP(Cmp_rm32_imm8) [R10D,4h:imm32]                   encoding(4 bytes) = 41 83 fa 04
0527h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 c6 0d 00 00
052dh mov ebp,[r11+10h]             ; MOV(Mov_r32_rm32) [EBP,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 6b 10
0531h shl ebp,4                     ; SHL(Shl_rm32_imm8) [EBP,4h:imm8]                     encoding(3 bytes) = c1 e5 04
0534h or ebx,ebp                    ; OR(Or_r32_rm32) [EBX,EBP]                            encoding(2 bytes) = 0b dd
0536h cmp r10d,5                    ; CMP(Cmp_rm32_imm8) [R10D,5h:imm32]                   encoding(4 bytes) = 41 83 fa 05
053ah jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 b3 0d 00 00
0540h mov ebp,[r11+14h]             ; MOV(Mov_r32_rm32) [EBP,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 6b 14
0544h shl ebp,5                     ; SHL(Shl_rm32_imm8) [EBP,5h:imm8]                     encoding(3 bytes) = c1 e5 05
0547h or ebx,ebp                    ; OR(Or_r32_rm32) [EBX,EBP]                            encoding(2 bytes) = 0b dd
0549h cmp r10d,6                    ; CMP(Cmp_rm32_imm8) [R10D,6h:imm32]                   encoding(4 bytes) = 41 83 fa 06
054dh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 a0 0d 00 00
0553h mov ebp,[r11+18h]             ; MOV(Mov_r32_rm32) [EBP,mem(32u,R11:br,DS:sr)]        encoding(4 bytes) = 41 8b 6b 18
0557h shl ebp,6                     ; SHL(Shl_rm32_imm8) [EBP,6h:imm8]                     encoding(3 bytes) = c1 e5 06
055ah or ebx,ebp                    ; OR(Or_r32_rm32) [EBX,EBP]                            encoding(2 bytes) = 0b dd
055ch cmp r10d,7                    ; CMP(Cmp_rm32_imm8) [R10D,7h:imm32]                   encoding(4 bytes) = 41 83 fa 07
0560h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 8d 0d 00 00
0566h mov r10d,[r11+1Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R11:br,DS:sr)]       encoding(4 bytes) = 45 8b 53 1c
056ah shl r10d,7                    ; SHL(Shl_rm32_imm8) [R10D,7h:imm8]                    encoding(4 bytes) = 41 c1 e2 07
056eh or ebx,r10d                   ; OR(Or_r32_rm32) [EBX,R10D]                           encoding(3 bytes) = 41 0b da
0571h mov r10d,ebx                  ; MOV(Mov_r32_rm32) [R10D,EBX]                         encoding(3 bytes) = 44 8b d3
0574h shl r10,8                     ; SHL(Shl_rm64_imm8) [R10,8h:imm8]                     encoding(4 bytes) = 49 c1 e2 08
0578h or rdi,r10                    ; OR(Or_r64_rm64) [RDI,R10]                            encoding(3 bytes) = 49 0b fa
057bh mov r10,rdi                   ; MOV(Mov_r64_rm64) [R10,RDI]                          encoding(3 bytes) = 4c 8b d7
057eh shl r10,10h                   ; SHL(Shl_rm64_imm8) [R10,10h:imm8]                    encoding(4 bytes) = 49 c1 e2 10
0582h or rsi,r10                    ; OR(Or_r64_rm64) [RSI,R10]                            encoding(3 bytes) = 49 0b f2
0585h mov r10,rsi                   ; MOV(Mov_r64_rm64) [R10,RSI]                          encoding(3 bytes) = 4c 8b d6
0588h shl r10,20h                   ; SHL(Shl_rm64_imm8) [R10,20h:imm8]                    encoding(4 bytes) = 49 c1 e2 20
058ch or r9,r10                     ; OR(Or_r64_rm64) [R9,R10]                             encoding(3 bytes) = 4d 0b ca
058fh mov [rdx],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 0a
0592h cmp ecx,40h                   ; CMP(Cmp_rm32_imm8) [ECX,40h:imm32]                   encoding(3 bytes) = 83 f9 40
0595h jb near ptr 12c3h             ; JB(Jb_rel32_64) [12C3h:jmp64]                        encoding(6 bytes) = 0f 82 28 0d 00 00
059bh add ecx,0FFFFFFC0h            ; ADD(Add_rm32_imm8) [ECX,ffffffffffffffc0h:imm32]     encoding(3 bytes) = 83 c1 c0
059eh add rax,100h                  ; ADD(Add_RAX_imm32) [RAX,100h:imm64]                  encoding(6 bytes) = 48 05 00 01 00 00
05a4h cmp ecx,0                     ; CMP(Cmp_rm32_imm8) [ECX,0h:imm32]                    encoding(3 bytes) = 83 f9 00
05a7h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 46 0d 00 00
05adh mov edx,[rax]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 10
05afh cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
05b2h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 3b 0d 00 00
05b8h mov r9d,[rax+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 04
05bch shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
05bfh or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
05c2h cmp ecx,2                     ; CMP(Cmp_rm32_imm8) [ECX,2h:imm32]                    encoding(3 bytes) = 83 f9 02
05c5h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 28 0d 00 00
05cbh mov r9d,[rax+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 08
05cfh shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
05d3h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
05d6h cmp ecx,3                     ; CMP(Cmp_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 f9 03
05d9h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 14 0d 00 00
05dfh mov r9d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 0c
05e3h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
05e7h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
05eah cmp ecx,4                     ; CMP(Cmp_rm32_imm8) [ECX,4h:imm32]                    encoding(3 bytes) = 83 f9 04
05edh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 00 0d 00 00
05f3h mov r9d,[rax+10h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 10
05f7h shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
05fbh or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
05feh cmp ecx,5                     ; CMP(Cmp_rm32_imm8) [ECX,5h:imm32]                    encoding(3 bytes) = 83 f9 05
0601h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 ec 0c 00 00
0607h mov r9d,[rax+14h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 14
060bh shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
060fh or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
0612h cmp ecx,6                     ; CMP(Cmp_rm32_imm8) [ECX,6h:imm32]                    encoding(3 bytes) = 83 f9 06
0615h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 d8 0c 00 00
061bh mov r9d,[rax+18h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 18
061fh shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
0623h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
0626h cmp ecx,7                     ; CMP(Cmp_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 f9 07
0629h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 c4 0c 00 00
062fh mov r9d,[rax+1Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 1c
0633h shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
0637h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
063ah cmp ecx,8                     ; CMP(Cmp_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 f9 08
063dh jb near ptr 12c9h             ; JB(Jb_rel32_64) [12C9h:jmp64]                        encoding(6 bytes) = 0f 82 86 0c 00 00
0643h lea r9d,[rcx-8]               ; LEA(Lea_r32_m) [R9D,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8d 49 f8
0647h lea r10,[rax+20h]             ; LEA(Lea_r64_m) [R10,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 8d 50 20
064bh cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
064fh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 9e 0c 00 00
0655h mov r11d,[r10]                ; MOV(Mov_r32_rm32) [R11D,mem(32u,R10:br,DS:sr)]       encoding(3 bytes) = 45 8b 1a
0658h cmp r9d,1                     ; CMP(Cmp_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 f9 01
065ch jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 91 0c 00 00
0662h mov esi,[r10+4]               ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 04
0666h shl esi,1                     ; SHL(Shl_rm32_1) [ESI,1h:imm8]                        encoding(2 bytes) = d1 e6
0668h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
066bh cmp r9d,2                     ; CMP(Cmp_rm32_imm8) [R9D,2h:imm32]                    encoding(4 bytes) = 41 83 f9 02
066fh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 7e 0c 00 00
0675h mov esi,[r10+8]               ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 08
0679h shl esi,2                     ; SHL(Shl_rm32_imm8) [ESI,2h:imm8]                     encoding(3 bytes) = c1 e6 02
067ch or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
067fh cmp r9d,3                     ; CMP(Cmp_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 f9 03
0683h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 6a 0c 00 00
0689h mov esi,[r10+0Ch]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 0c
068dh shl esi,3                     ; SHL(Shl_rm32_imm8) [ESI,3h:imm8]                     encoding(3 bytes) = c1 e6 03
0690h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0693h cmp r9d,4                     ; CMP(Cmp_rm32_imm8) [R9D,4h:imm32]                    encoding(4 bytes) = 41 83 f9 04
0697h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 56 0c 00 00
069dh mov esi,[r10+10h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 10
06a1h shl esi,4                     ; SHL(Shl_rm32_imm8) [ESI,4h:imm8]                     encoding(3 bytes) = c1 e6 04
06a4h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
06a7h cmp r9d,5                     ; CMP(Cmp_rm32_imm8) [R9D,5h:imm32]                    encoding(4 bytes) = 41 83 f9 05
06abh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 42 0c 00 00
06b1h mov esi,[r10+14h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 14
06b5h shl esi,5                     ; SHL(Shl_rm32_imm8) [ESI,5h:imm8]                     encoding(3 bytes) = c1 e6 05
06b8h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
06bbh cmp r9d,6                     ; CMP(Cmp_rm32_imm8) [R9D,6h:imm32]                    encoding(4 bytes) = 41 83 f9 06
06bfh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 2e 0c 00 00
06c5h mov esi,[r10+18h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 18
06c9h shl esi,6                     ; SHL(Shl_rm32_imm8) [ESI,6h:imm8]                     encoding(3 bytes) = c1 e6 06
06cch or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
06cfh cmp r9d,7                     ; CMP(Cmp_rm32_imm8) [R9D,7h:imm32]                    encoding(4 bytes) = 41 83 f9 07
06d3h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 1a 0c 00 00
06d9h mov r9d,[r10+1Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 45 8b 4a 1c
06ddh mov [rsp+318h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 18 03 00 00
06e5h mov r9d,[rsp+318h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 18 03 00 00
06edh shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
06f1h or r11d,r9d                   ; OR(Or_r32_rm32) [R11D,R9D]                           encoding(3 bytes) = 45 0b d9
06f4h mov r9d,r11d                  ; MOV(Mov_r32_rm32) [R9D,R11D]                         encoding(3 bytes) = 45 8b cb
06f7h shl r9,8                      ; SHL(Shl_rm64_imm8) [R9,8h:imm8]                      encoding(4 bytes) = 49 c1 e1 08
06fbh or rdx,r9                     ; OR(Or_r64_rm64) [RDX,R9]                             encoding(3 bytes) = 49 0b d1
06feh cmp ecx,10h                   ; CMP(Cmp_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 f9 10
0701h jb near ptr 12cfh             ; JB(Jb_rel32_64) [12CFh:jmp64]                        encoding(6 bytes) = 0f 82 c8 0b 00 00
0707h lea r9,[rsp+308h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 08 03 00 00
070fh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0713h vmovdqu xmmword ptr [r9],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R9:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 01
0718h lea r9d,[rcx-10h]             ; LEA(Lea_r32_m) [R9D,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8d 49 f0
071ch lea r10,[rax+40h]             ; LEA(Lea_r64_m) [R10,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 8d 50 40
0720h mov [rsp+300h],r10            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R10]        encoding(8 bytes) = 4c 89 94 24 00 03 00 00
0728h mov r10,[rsp+300h]            ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 94 24 00 03 00 00
0730h lea r11,[rsp+308h]            ; LEA(Lea_r64_m) [R11,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 4c 8d 9c 24 08 03 00 00
0738h mov [r11],r10                 ; MOV(Mov_rm64_r64) [mem(64u,R11:br,DS:sr),R10]        encoding(3 bytes) = 4d 89 13
073bh mov [rsp+310h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 10 03 00 00
0743h lea r9,[rsp+308h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 08 03 00 00
074bh mov r10,[r9]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R9:br,DS:sr)]         encoding(3 bytes) = 4d 8b 11
074eh mov r9d,[r9+8]                ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 08
0752h lea r11,[rsp+2F0h]            ; LEA(Lea_r64_m) [R11,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 4c 8d 9c 24 f0 02 00 00
075ah mov [r11],r10                 ; MOV(Mov_rm64_r64) [mem(64u,R11:br,DS:sr),R10]        encoding(3 bytes) = 4d 89 13
075dh mov [r11+8],r9d               ; MOV(Mov_rm32_r32) [mem(32u,R11:br,DS:sr),R9D]        encoding(4 bytes) = 45 89 4b 08
0761h vmovdqu xmm0,xmmword ptr [rsp+2F0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 f0 02 00 00
076ah vmovdqu xmmword ptr [rsp+2D0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 d0 02 00 00
0773h cmp dword ptr [rsp+2D8h],0    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),0h:imm32]  encoding(8 bytes) = 83 bc 24 d8 02 00 00 00
077bh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 72 0b 00 00
0781h mov r9,[rsp+2D0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 d0 02 00 00
0789h mov r9d,[r9]                  ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(3 bytes) = 45 8b 09
078ch mov [rsp+2C8h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 c8 02 00 00
0794h mov r9d,[rsp+2C8h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 c8 02 00 00
079ch cmp dword ptr [rsp+2D8h],1    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(8 bytes) = 83 bc 24 d8 02 00 00 01
07a4h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 49 0b 00 00
07aah mov r10,[rsp+2D0h]            ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 94 24 d0 02 00 00
07b2h mov r10d,[r10+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 04
07b6h mov [rsp+2C0h],r10d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(8 bytes) = 44 89 94 24 c0 02 00 00
07beh mov r10d,[rsp+2C0h]           ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 94 24 c0 02 00 00
07c6h shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
07c9h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
07cch cmp dword ptr [rsp+2D8h],2    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),2h:imm32]  encoding(8 bytes) = 83 bc 24 d8 02 00 00 02
07d4h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 19 0b 00 00
07dah mov r10,[rsp+2D0h]            ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 94 24 d0 02 00 00
07e2h mov r10d,[r10+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 08
07e6h mov [rsp+2B8h],r10d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(8 bytes) = 44 89 94 24 b8 02 00 00
07eeh mov r10d,[rsp+2B8h]           ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 94 24 b8 02 00 00
07f6h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
07fah or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
07fdh cmp dword ptr [rsp+2D8h],3    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),3h:imm32]  encoding(8 bytes) = 83 bc 24 d8 02 00 00 03
0805h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 e8 0a 00 00
080bh mov r10,[rsp+2D0h]            ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 94 24 d0 02 00 00
0813h mov r10d,[r10+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 0c
0817h mov [rsp+2B0h],r10d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(8 bytes) = 44 89 94 24 b0 02 00 00
081fh mov r10d,[rsp+2B0h]           ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 94 24 b0 02 00 00
0827h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
082bh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
082eh cmp dword ptr [rsp+2D8h],4    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),4h:imm32]  encoding(8 bytes) = 83 bc 24 d8 02 00 00 04
0836h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 b7 0a 00 00
083ch mov r10,[rsp+2D0h]            ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 94 24 d0 02 00 00
0844h mov r10d,[r10+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 10
0848h mov [rsp+2A8h],r10d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(8 bytes) = 44 89 94 24 a8 02 00 00
0850h mov r10d,[rsp+2A8h]           ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 94 24 a8 02 00 00
0858h shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
085ch or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
085fh cmp dword ptr [rsp+2D8h],5    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),5h:imm32]  encoding(8 bytes) = 83 bc 24 d8 02 00 00 05
0867h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 86 0a 00 00
086dh mov r10,[rsp+2D0h]            ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 94 24 d0 02 00 00
0875h mov r10d,[r10+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 14
0879h mov [rsp+2A0h],r10d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(8 bytes) = 44 89 94 24 a0 02 00 00
0881h mov r10d,[rsp+2A0h]           ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 94 24 a0 02 00 00
0889h shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
088dh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0890h cmp dword ptr [rsp+2D8h],6    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),6h:imm32]  encoding(8 bytes) = 83 bc 24 d8 02 00 00 06
0898h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 55 0a 00 00
089eh mov r10,[rsp+2D0h]            ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 94 24 d0 02 00 00
08a6h mov r10d,[r10+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 18
08aah mov [rsp+298h],r10d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(8 bytes) = 44 89 94 24 98 02 00 00
08b2h mov r10d,[rsp+298h]           ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 94 24 98 02 00 00
08bah shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
08beh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
08c1h cmp dword ptr [rsp+2D8h],7    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),7h:imm32]  encoding(8 bytes) = 83 bc 24 d8 02 00 00 07
08c9h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 24 0a 00 00
08cfh mov r10,[rsp+2D0h]            ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 94 24 d0 02 00 00
08d7h mov r10d,[r10+1Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 1c
08dbh mov [rsp+290h],r10d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(8 bytes) = 44 89 94 24 90 02 00 00
08e3h mov r10d,[rsp+290h]           ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 94 24 90 02 00 00
08ebh shl r10d,7                    ; SHL(Shl_rm32_imm8) [R10D,7h:imm8]                    encoding(4 bytes) = 41 c1 e2 07
08efh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
08f2h cmp dword ptr [rsp+2F8h],8    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),8h:imm32]  encoding(8 bytes) = 83 bc 24 f8 02 00 00 08
08fah jb near ptr 12d5h             ; JB(Jb_rel32_64) [12D5h:jmp64]                        encoding(6 bytes) = 0f 82 d5 09 00 00
0900h mov r10,[rsp+2F0h]            ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 94 24 f0 02 00 00
0908h lea r11,[rsp+280h]            ; LEA(Lea_r64_m) [R11,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 4c 8d 9c 24 80 02 00 00
0910h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0914h vmovdqu xmmword ptr [r11],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R11:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 03
0919h mov r11d,[rsp+2F8h]           ; MOV(Mov_r32_rm32) [R11D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 9c 24 f8 02 00 00
0921h add r11d,0FFFFFFF8h           ; ADD(Add_rm32_imm8) [R11D,fffffffffffffff8h:imm32]    encoding(4 bytes) = 41 83 c3 f8
0925h add r10,20h                   ; ADD(Add_rm64_imm8) [R10,20h:imm64]                   encoding(4 bytes) = 49 83 c2 20
0929h mov [rsp+278h],r10            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R10]        encoding(8 bytes) = 4c 89 94 24 78 02 00 00
0931h mov r10,[rsp+278h]            ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 94 24 78 02 00 00
0939h lea rsi,[rsp+280h]            ; LEA(Lea_r64_m) [RSI,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d b4 24 80 02 00 00
0941h mov [rsi],r10                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),R10]        encoding(3 bytes) = 4c 89 16
0944h mov [rsp+288h],r11d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R11D]       encoding(8 bytes) = 44 89 9c 24 88 02 00 00
094ch vmovdqu xmm0,xmmword ptr [rsp+280h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 80 02 00 00
0955h vmovdqu xmmword ptr [rsp+2E0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 e0 02 00 00
095eh vmovdqu xmm0,xmmword ptr [rsp+2E0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 e0 02 00 00
0967h vmovdqu xmmword ptr [rsp+268h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 68 02 00 00
0970h cmp dword ptr [rsp+270h],0    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),0h:imm32]  encoding(8 bytes) = 83 bc 24 70 02 00 00 00
0978h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 75 09 00 00
097eh mov r10,[rsp+268h]            ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 94 24 68 02 00 00
0986h mov r10d,[r10]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(3 bytes) = 45 8b 12
0989h mov [rsp+260h],r10d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(8 bytes) = 44 89 94 24 60 02 00 00
0991h mov r10d,[rsp+260h]           ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 94 24 60 02 00 00
0999h cmp dword ptr [rsp+270h],1    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(8 bytes) = 83 bc 24 70 02 00 00 01
09a1h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 4c 09 00 00
09a7h mov r11,[rsp+268h]            ; MOV(Mov_r64_rm64) [R11,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 9c 24 68 02 00 00
09afh mov r11d,[r11+4]              ; MOV(Mov_r32_rm32) [R11D,mem(32u,R11:br,DS:sr)]       encoding(4 bytes) = 45 8b 5b 04
09b3h mov [rsp+258h],r11d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R11D]       encoding(8 bytes) = 44 89 9c 24 58 02 00 00
09bbh mov r11d,[rsp+258h]           ; MOV(Mov_r32_rm32) [R11D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 9c 24 58 02 00 00
09c3h shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
09c6h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
09c9h cmp dword ptr [rsp+270h],2    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),2h:imm32]  encoding(8 bytes) = 83 bc 24 70 02 00 00 02
09d1h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 1c 09 00 00
09d7h mov r11,[rsp+268h]            ; MOV(Mov_r64_rm64) [R11,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 9c 24 68 02 00 00
09dfh mov r11d,[r11+8]              ; MOV(Mov_r32_rm32) [R11D,mem(32u,R11:br,DS:sr)]       encoding(4 bytes) = 45 8b 5b 08
09e3h mov [rsp+250h],r11d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R11D]       encoding(8 bytes) = 44 89 9c 24 50 02 00 00
09ebh mov r11d,[rsp+250h]           ; MOV(Mov_r32_rm32) [R11D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 9c 24 50 02 00 00
09f3h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
09f7h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
09fah cmp dword ptr [rsp+270h],3    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),3h:imm32]  encoding(8 bytes) = 83 bc 24 70 02 00 00 03
0a02h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 eb 08 00 00
0a08h mov r11,[rsp+268h]            ; MOV(Mov_r64_rm64) [R11,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 9c 24 68 02 00 00
0a10h mov r11d,[r11+0Ch]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,R11:br,DS:sr)]       encoding(4 bytes) = 45 8b 5b 0c
0a14h mov [rsp+248h],r11d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R11D]       encoding(8 bytes) = 44 89 9c 24 48 02 00 00
0a1ch mov r11d,[rsp+248h]           ; MOV(Mov_r32_rm32) [R11D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 9c 24 48 02 00 00
0a24h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
0a28h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0a2bh cmp dword ptr [rsp+270h],4    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),4h:imm32]  encoding(8 bytes) = 83 bc 24 70 02 00 00 04
0a33h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 ba 08 00 00
0a39h mov r11,[rsp+268h]            ; MOV(Mov_r64_rm64) [R11,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 9c 24 68 02 00 00
0a41h mov r11d,[r11+10h]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,R11:br,DS:sr)]       encoding(4 bytes) = 45 8b 5b 10
0a45h mov [rsp+240h],r11d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R11D]       encoding(8 bytes) = 44 89 9c 24 40 02 00 00
0a4dh mov r11d,[rsp+240h]           ; MOV(Mov_r32_rm32) [R11D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 9c 24 40 02 00 00
0a55h shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
0a59h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0a5ch cmp dword ptr [rsp+270h],5    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),5h:imm32]  encoding(8 bytes) = 83 bc 24 70 02 00 00 05
0a64h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 89 08 00 00
0a6ah mov r11,[rsp+268h]            ; MOV(Mov_r64_rm64) [R11,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 9c 24 68 02 00 00
0a72h mov r11d,[r11+14h]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,R11:br,DS:sr)]       encoding(4 bytes) = 45 8b 5b 14
0a76h mov [rsp+238h],r11d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R11D]       encoding(8 bytes) = 44 89 9c 24 38 02 00 00
0a7eh mov r11d,[rsp+238h]           ; MOV(Mov_r32_rm32) [R11D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 9c 24 38 02 00 00
0a86h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0a8ah or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0a8dh cmp dword ptr [rsp+270h],6    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),6h:imm32]  encoding(8 bytes) = 83 bc 24 70 02 00 00 06
0a95h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 58 08 00 00
0a9bh mov r11,[rsp+268h]            ; MOV(Mov_r64_rm64) [R11,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 9c 24 68 02 00 00
0aa3h mov r11d,[r11+18h]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,R11:br,DS:sr)]       encoding(4 bytes) = 45 8b 5b 18
0aa7h mov [rsp+230h],r11d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R11D]       encoding(8 bytes) = 44 89 9c 24 30 02 00 00
0aafh mov r11d,[rsp+230h]           ; MOV(Mov_r32_rm32) [R11D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 9c 24 30 02 00 00
0ab7h shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
0abbh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0abeh cmp dword ptr [rsp+270h],7    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),7h:imm32]  encoding(8 bytes) = 83 bc 24 70 02 00 00 07
0ac6h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 27 08 00 00
0acch mov r11,[rsp+268h]            ; MOV(Mov_r64_rm64) [R11,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8b 9c 24 68 02 00 00
0ad4h mov r11d,[r11+1Ch]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,R11:br,DS:sr)]       encoding(4 bytes) = 45 8b 5b 1c
0ad8h mov [rsp+228h],r11d           ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R11D]       encoding(8 bytes) = 44 89 9c 24 28 02 00 00
0ae0h mov r11d,[rsp+228h]           ; MOV(Mov_r32_rm32) [R11D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 9c 24 28 02 00 00
0ae8h shl r11d,7                    ; SHL(Shl_rm32_imm8) [R11D,7h:imm8]                    encoding(4 bytes) = 41 c1 e3 07
0aech or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0aefh shl r10,8                     ; SHL(Shl_rm64_imm8) [R10,8h:imm8]                     encoding(4 bytes) = 49 c1 e2 08
0af3h or r9,r10                     ; OR(Or_r64_rm64) [R9,R10]                             encoding(3 bytes) = 4d 0b ca
0af6h shl r9,10h                    ; SHL(Shl_rm64_imm8) [R9,10h:imm8]                     encoding(4 bytes) = 49 c1 e1 10
0afah or rdx,r9                     ; OR(Or_r64_rm64) [RDX,R9]                             encoding(3 bytes) = 49 0b d1
0afdh cmp ecx,20h                   ; CMP(Cmp_rm32_imm8) [ECX,20h:imm32]                   encoding(3 bytes) = 83 f9 20
0b00h jb near ptr 12dbh             ; JB(Jb_rel32_64) [12DBh:jmp64]                        encoding(6 bytes) = 0f 82 d5 07 00 00
0b06h lea r9,[rsp+218h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 18 02 00 00
0b0eh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0b12h vmovdqu xmmword ptr [r9],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R9:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 01
0b17h add ecx,0FFFFFFE0h            ; ADD(Add_rm32_imm8) [ECX,ffffffffffffffe0h:imm32]     encoding(3 bytes) = 83 c1 e0
0b1ah add rax,80h                   ; ADD(Add_RAX_imm32) [RAX,80h:imm64]                   encoding(6 bytes) = 48 05 80 00 00 00
0b20h mov [rsp+210h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 10 02 00 00
0b28h mov rax,[rsp+210h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 10 02 00 00
0b30h lea r9,[rsp+218h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 18 02 00 00
0b38h mov [r9],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 01
0b3bh mov [rsp+220h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 20 02 00 00
0b42h lea rax,[rsp+218h]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 84 24 18 02 00 00
0b4ah mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0b4dh mov eax,[rax+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 08
0b50h lea r9,[rsp+200h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 00 02 00 00
0b58h mov [r9],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 09
0b5bh mov [r9+8],eax                ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),EAX]         encoding(4 bytes) = 41 89 41 08
0b5fh vmovdqu xmm0,xmmword ptr [rsp+200h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 00 02 00 00
0b68h vmovdqu xmmword ptr [rsp+1E0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 e0 01 00 00
0b71h vmovdqu xmm0,xmmword ptr [rsp+1E0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 e0 01 00 00
0b7ah vmovdqu xmmword ptr [rsp+1C0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 c0 01 00 00
0b83h mov eax,[rsp+1C8h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 c8 01 00 00
0b8ah cmp eax,0                     ; CMP(Cmp_rm32_imm8) [EAX,0h:imm32]                    encoding(3 bytes) = 83 f8 00
0b8dh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 60 07 00 00
0b93h mov rcx,[rsp+1C0h]            ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 8c 24 c0 01 00 00
0b9bh mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
0b9dh mov [rsp+1B8h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 b8 01 00 00
0ba4h mov ecx,[rsp+1B8h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 b8 01 00 00
0babh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0baeh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 3f 07 00 00
0bb4h mov r9,[rsp+1C0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 c0 01 00 00
0bbch mov r9d,[r9+4]                ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 04
0bc0h mov [rsp+1B0h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 b0 01 00 00
0bc8h mov r9d,[rsp+1B0h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 b0 01 00 00
0bd0h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
0bd3h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0bd6h cmp eax,2                     ; CMP(Cmp_rm32_imm8) [EAX,2h:imm32]                    encoding(3 bytes) = 83 f8 02
0bd9h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 14 07 00 00
0bdfh mov r9,[rsp+1C0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 c0 01 00 00
0be7h mov r9d,[r9+8]                ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 08
0bebh mov [rsp+1A8h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 a8 01 00 00
0bf3h mov r9d,[rsp+1A8h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 a8 01 00 00
0bfbh shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
0bffh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0c02h cmp eax,3                     ; CMP(Cmp_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 f8 03
0c05h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 e8 06 00 00
0c0bh mov r9,[rsp+1C0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 c0 01 00 00
0c13h mov r9d,[r9+0Ch]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 0c
0c17h mov [rsp+1A0h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 a0 01 00 00
0c1fh mov r9d,[rsp+1A0h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 a0 01 00 00
0c27h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0c2bh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0c2eh cmp eax,4                     ; CMP(Cmp_rm32_imm8) [EAX,4h:imm32]                    encoding(3 bytes) = 83 f8 04
0c31h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 bc 06 00 00
0c37h mov r9,[rsp+1C0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 c0 01 00 00
0c3fh mov r9d,[r9+10h]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 10
0c43h mov [rsp+198h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 98 01 00 00
0c4bh mov r9d,[rsp+198h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 98 01 00 00
0c53h shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
0c57h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0c5ah cmp eax,5                     ; CMP(Cmp_rm32_imm8) [EAX,5h:imm32]                    encoding(3 bytes) = 83 f8 05
0c5dh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 90 06 00 00
0c63h mov r9,[rsp+1C0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 c0 01 00 00
0c6bh mov r9d,[r9+14h]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 14
0c6fh mov [rsp+190h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 90 01 00 00
0c77h mov r9d,[rsp+190h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 90 01 00 00
0c7fh shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
0c83h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0c86h cmp eax,6                     ; CMP(Cmp_rm32_imm8) [EAX,6h:imm32]                    encoding(3 bytes) = 83 f8 06
0c89h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 64 06 00 00
0c8fh mov r9,[rsp+1C0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 c0 01 00 00
0c97h mov r9d,[r9+18h]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 18
0c9bh mov [rsp+188h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 88 01 00 00
0ca3h mov r9d,[rsp+188h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 88 01 00 00
0cabh shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
0cafh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0cb2h cmp eax,7                     ; CMP(Cmp_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 f8 07
0cb5h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 38 06 00 00
0cbbh mov r9,[rsp+1C0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 c0 01 00 00
0cc3h mov r9d,[r9+1Ch]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 1c
0cc7h mov [rsp+180h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 80 01 00 00
0ccfh mov r9d,[rsp+180h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 80 01 00 00
0cd7h shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
0cdbh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0cdeh cmp eax,8                     ; CMP(Cmp_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 f8 08
0ce1h jb near ptr 12e1h             ; JB(Jb_rel32_64) [12E1h:jmp64]                        encoding(6 bytes) = 0f 82 fa 05 00 00
0ce7h mov r9,[rsp+1E0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 e0 01 00 00
0cefh lea r10,[rsp+170h]            ; LEA(Lea_r64_m) [R10,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 4c 8d 94 24 70 01 00 00
0cf7h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0cfbh vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
0d00h add eax,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [EAX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 c0 f8
0d03h add r9,20h                    ; ADD(Add_rm64_imm8) [R9,20h:imm64]                    encoding(4 bytes) = 49 83 c1 20
0d07h mov [rsp+168h],r9             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(8 bytes) = 4c 89 8c 24 68 01 00 00
0d0fh mov r9,[rsp+168h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 68 01 00 00
0d17h lea r10,[rsp+170h]            ; LEA(Lea_r64_m) [R10,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 4c 8d 94 24 70 01 00 00
0d1fh mov [r10],r9                  ; MOV(Mov_rm64_r64) [mem(64u,R10:br,DS:sr),R9]         encoding(3 bytes) = 4d 89 0a
0d22h mov [rsp+178h],eax            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(7 bytes) = 89 84 24 78 01 00 00
0d29h vmovdqu xmm0,xmmword ptr [rsp+170h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 70 01 00 00
0d32h vmovdqu xmmword ptr [rsp+1D0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 d0 01 00 00
0d3bh vmovdqu xmm0,xmmword ptr [rsp+1D0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 d0 01 00 00
0d44h vmovdqu xmmword ptr [rsp+158h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 58 01 00 00
0d4dh cmp dword ptr [rsp+160h],0    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),0h:imm32]  encoding(8 bytes) = 83 bc 24 60 01 00 00 00
0d55h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 98 05 00 00
0d5bh mov rax,[rsp+158h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 58 01 00 00
0d63h mov eax,[rax]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 00
0d65h mov [rsp+150h],eax            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(7 bytes) = 89 84 24 50 01 00 00
0d6ch mov eax,[rsp+150h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 50 01 00 00
0d73h cmp dword ptr [rsp+160h],1    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(8 bytes) = 83 bc 24 60 01 00 00 01
0d7bh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 72 05 00 00
0d81h mov r9,[rsp+158h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 58 01 00 00
0d89h mov r9d,[r9+4]                ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 04
0d8dh mov [rsp+148h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 48 01 00 00
0d95h mov r9d,[rsp+148h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 48 01 00 00
0d9dh shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
0da0h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0da3h cmp dword ptr [rsp+160h],2    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),2h:imm32]  encoding(8 bytes) = 83 bc 24 60 01 00 00 02
0dabh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 42 05 00 00
0db1h mov r9,[rsp+158h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 58 01 00 00
0db9h mov r9d,[r9+8]                ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 08
0dbdh mov [rsp+140h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 40 01 00 00
0dc5h mov r9d,[rsp+140h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 40 01 00 00
0dcdh shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
0dd1h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0dd4h cmp dword ptr [rsp+160h],3    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),3h:imm32]  encoding(8 bytes) = 83 bc 24 60 01 00 00 03
0ddch jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 11 05 00 00
0de2h mov r9,[rsp+158h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 58 01 00 00
0deah mov r9d,[r9+0Ch]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 0c
0deeh mov [rsp+138h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 38 01 00 00
0df6h mov r9d,[rsp+138h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 38 01 00 00
0dfeh shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0e02h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0e05h cmp dword ptr [rsp+160h],4    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),4h:imm32]  encoding(8 bytes) = 83 bc 24 60 01 00 00 04
0e0dh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 e0 04 00 00
0e13h mov r9,[rsp+158h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 58 01 00 00
0e1bh mov r9d,[r9+10h]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 10
0e1fh mov [rsp+130h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 30 01 00 00
0e27h mov r9d,[rsp+130h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 30 01 00 00
0e2fh shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
0e33h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0e36h cmp dword ptr [rsp+160h],5    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),5h:imm32]  encoding(8 bytes) = 83 bc 24 60 01 00 00 05
0e3eh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 af 04 00 00
0e44h mov r9,[rsp+158h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 58 01 00 00
0e4ch mov r9d,[r9+14h]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 14
0e50h mov [rsp+128h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 28 01 00 00
0e58h mov r9d,[rsp+128h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 28 01 00 00
0e60h shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
0e64h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0e67h cmp dword ptr [rsp+160h],6    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),6h:imm32]  encoding(8 bytes) = 83 bc 24 60 01 00 00 06
0e6fh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 7e 04 00 00
0e75h mov r9,[rsp+158h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 58 01 00 00
0e7dh mov r9d,[r9+18h]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 18
0e81h mov [rsp+120h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 20 01 00 00
0e89h mov r9d,[rsp+120h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 20 01 00 00
0e91h shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
0e95h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0e98h cmp dword ptr [rsp+160h],7    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),7h:imm32]  encoding(8 bytes) = 83 bc 24 60 01 00 00 07
0ea0h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 4d 04 00 00
0ea6h mov r9,[rsp+158h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 58 01 00 00
0eaeh mov r9d,[r9+1Ch]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 1c
0eb2h mov [rsp+118h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 18 01 00 00
0ebah mov r9d,[rsp+118h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 18 01 00 00
0ec2h shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
0ec6h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0ec9h shl rax,8                     ; SHL(Shl_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e0 08
0ecdh or rcx,rax                    ; OR(Or_r64_rm64) [RCX,RAX]                            encoding(3 bytes) = 48 0b c8
0ed0h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0ed3h cmp dword ptr [rsp+208h],10h  ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),10h:imm32] encoding(8 bytes) = 83 bc 24 08 02 00 00 10
0edbh jb near ptr 12e7h             ; JB(Jb_rel32_64) [12E7h:jmp64]                        encoding(6 bytes) = 0f 82 06 04 00 00
0ee1h mov rcx,[rsp+200h]            ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 8c 24 00 02 00 00
0ee9h lea r9,[rsp+108h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 08 01 00 00
0ef1h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0ef5h vmovdqu xmmword ptr [r9],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R9:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 01
0efah mov r9d,[rsp+208h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 08 02 00 00
0f02h add r9d,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [R9D,fffffffffffffff0h:imm32]     encoding(4 bytes) = 41 83 c1 f0
0f06h add rcx,40h                   ; ADD(Add_rm64_imm8) [RCX,40h:imm64]                   encoding(4 bytes) = 48 83 c1 40
0f0ah mov [rsp+100h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 00 01 00 00
0f12h mov rcx,[rsp+100h]            ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 8c 24 00 01 00 00
0f1ah lea r10,[rsp+108h]            ; LEA(Lea_r64_m) [R10,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 4c 8d 94 24 08 01 00 00
0f22h mov [r10],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,R10:br,DS:sr),RCX]        encoding(3 bytes) = 49 89 0a
0f25h mov [rsp+110h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 10 01 00 00
0f2dh vmovdqu xmm0,xmmword ptr [rsp+108h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 08 01 00 00
0f36h vmovdqu xmmword ptr [rsp+1F0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 f0 01 00 00
0f3fh vmovdqu xmm0,xmmword ptr [rsp+1F0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 f0 01 00 00
0f48h vmovdqu xmmword ptr [rsp+0F0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 f0 00 00 00
0f51h vmovdqu xmm0,xmmword ptr [rsp+0F0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 f0 00 00 00
0f5ah vmovdqu xmmword ptr [rsp+0D0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 d0 00 00 00
0f63h cmp dword ptr [rsp+0D8h],0    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),0h:imm32]  encoding(8 bytes) = 83 bc 24 d8 00 00 00 00
0f6bh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 82 03 00 00
0f71h mov rcx,[rsp+0D0h]            ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 8c 24 d0 00 00 00
0f79h mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
0f7bh mov [rsp+0C8h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 c8 00 00 00
0f82h mov ecx,[rsp+0C8h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 c8 00 00 00
0f89h cmp dword ptr [rsp+0D8h],1    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(8 bytes) = 83 bc 24 d8 00 00 00 01
0f91h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 5c 03 00 00
0f97h mov r9,[rsp+0D0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 d0 00 00 00
0f9fh mov r9d,[r9+4]                ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 04
0fa3h mov [rsp+0C0h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 c0 00 00 00
0fabh mov r9d,[rsp+0C0h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 c0 00 00 00
0fb3h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
0fb6h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0fb9h cmp dword ptr [rsp+0D8h],2    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),2h:imm32]  encoding(8 bytes) = 83 bc 24 d8 00 00 00 02
0fc1h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 2c 03 00 00
0fc7h mov r9,[rsp+0D0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 d0 00 00 00
0fcfh mov r9d,[r9+8]                ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 08
0fd3h mov [rsp+0B8h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 b8 00 00 00
0fdbh mov r9d,[rsp+0B8h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 b8 00 00 00
0fe3h shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
0fe7h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0feah cmp dword ptr [rsp+0D8h],3    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),3h:imm32]  encoding(8 bytes) = 83 bc 24 d8 00 00 00 03
0ff2h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 fb 02 00 00
0ff8h mov r9,[rsp+0D0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 d0 00 00 00
1000h mov r9d,[r9+0Ch]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 0c
1004h mov [rsp+0B0h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 b0 00 00 00
100ch mov r9d,[rsp+0B0h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 b0 00 00 00
1014h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
1018h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
101bh cmp dword ptr [rsp+0D8h],4    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),4h:imm32]  encoding(8 bytes) = 83 bc 24 d8 00 00 00 04
1023h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 ca 02 00 00
1029h mov r9,[rsp+0D0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 d0 00 00 00
1031h mov r9d,[r9+10h]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 10
1035h mov [rsp+0A8h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 a8 00 00 00
103dh mov r9d,[rsp+0A8h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 a8 00 00 00
1045h shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
1049h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
104ch cmp dword ptr [rsp+0D8h],5    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),5h:imm32]  encoding(8 bytes) = 83 bc 24 d8 00 00 00 05
1054h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 99 02 00 00
105ah mov r9,[rsp+0D0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 d0 00 00 00
1062h mov r9d,[r9+14h]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 14
1066h mov [rsp+0A0h],r9d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 a0 00 00 00
106eh mov r9d,[rsp+0A0h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 a0 00 00 00
1076h shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
107ah or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
107dh cmp dword ptr [rsp+0D8h],6    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),6h:imm32]  encoding(8 bytes) = 83 bc 24 d8 00 00 00 06
1085h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 68 02 00 00
108bh mov r9,[rsp+0D0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 d0 00 00 00
1093h mov r9d,[r9+18h]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 18
1097h mov [rsp+98h],r9d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 98 00 00 00
109fh mov r9d,[rsp+98h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 98 00 00 00
10a7h shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
10abh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
10aeh cmp dword ptr [rsp+0D8h],7    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),7h:imm32]  encoding(8 bytes) = 83 bc 24 d8 00 00 00 07
10b6h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 37 02 00 00
10bch mov r9,[rsp+0D0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 d0 00 00 00
10c4h mov r9d,[r9+1Ch]              ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 49 1c
10c8h mov [rsp+90h],r9d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(8 bytes) = 44 89 8c 24 90 00 00 00
10d0h mov r9d,[rsp+90h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 90 00 00 00
10d8h shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
10dch or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
10dfh cmp dword ptr [rsp+0F8h],8    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),8h:imm32]  encoding(8 bytes) = 83 bc 24 f8 00 00 00 08
10e7h jb near ptr 12edh             ; JB(Jb_rel32_64) [12EDh:jmp64]                        encoding(6 bytes) = 0f 82 00 02 00 00
10edh mov r9,[rsp+0F0h]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(8 bytes) = 4c 8b 8c 24 f0 00 00 00
10f5h lea r10,[rsp+80h]             ; LEA(Lea_r64_m) [R10,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 4c 8d 94 24 80 00 00 00
10fdh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
1101h vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
1106h mov r10d,[rsp+0F8h]           ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 94 24 f8 00 00 00
110eh add r10d,0FFFFFFF8h           ; ADD(Add_rm32_imm8) [R10D,fffffffffffffff8h:imm32]    encoding(4 bytes) = 41 83 c2 f8
1112h add r9,20h                    ; ADD(Add_rm64_imm8) [R9,20h:imm64]                    encoding(4 bytes) = 49 83 c1 20
1116h mov [rsp+78h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 78
111bh mov r9,[rsp+78h]              ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(5 bytes) = 4c 8b 4c 24 78
1120h lea r11,[rsp+80h]             ; LEA(Lea_r64_m) [R11,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 4c 8d 9c 24 80 00 00 00
1128h mov [r11],r9                  ; MOV(Mov_rm64_r64) [mem(64u,R11:br,DS:sr),R9]         encoding(3 bytes) = 4d 89 0b
112bh mov [rsp+88h],r10d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(8 bytes) = 44 89 94 24 88 00 00 00
1133h vmovdqu xmm0,xmmword ptr [rsp+80h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 80 00 00 00
113ch vmovdqu xmmword ptr [rsp+0E0h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 e0 00 00 00
1145h vmovdqu xmm0,xmmword ptr [rsp+0E0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 e0 00 00 00
114eh vmovdqu xmmword ptr [rsp+68h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 68
1154h cmp dword ptr [rsp+70h],0     ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),0h:imm32]  encoding(5 bytes) = 83 7c 24 70 00
1159h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 94 01 00 00
115fh mov r9,[rsp+68h]              ; MOV(Mov_r64_rm64) [R9,mem(64u,RSP:br,SS:sr)]         encoding(5 bytes) = 4c 8b 4c 24 68
1164h mov r9d,[r9]                  ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,DS:sr)]         encoding(3 bytes) = 45 8b 09
1167h mov [rsp+60h],r9d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(5 bytes) = 44 89 4c 24 60
116ch mov r9d,[rsp+60h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(5 bytes) = 44 8b 4c 24 60
1171h cmp dword ptr [rsp+70h],1     ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(5 bytes) = 83 7c 24 70 01
1176h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 77 01 00 00
117ch mov r10,[rsp+68h]             ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8b 54 24 68
1181h mov r10d,[r10+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 04
1185h mov [rsp+58h],r10d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(5 bytes) = 44 89 54 24 58
118ah mov r10d,[rsp+58h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(5 bytes) = 44 8b 54 24 58
118fh shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
1192h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
1195h cmp dword ptr [rsp+70h],2     ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),2h:imm32]  encoding(5 bytes) = 83 7c 24 70 02
119ah jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 53 01 00 00
11a0h mov r10,[rsp+68h]             ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8b 54 24 68
11a5h mov r10d,[r10+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 08
11a9h mov [rsp+50h],r10d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(5 bytes) = 44 89 54 24 50
11aeh mov r10d,[rsp+50h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(5 bytes) = 44 8b 54 24 50
11b3h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
11b7h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
11bah cmp dword ptr [rsp+70h],3     ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),3h:imm32]  encoding(5 bytes) = 83 7c 24 70 03
11bfh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 2e 01 00 00
11c5h mov r10,[rsp+68h]             ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8b 54 24 68
11cah mov r10d,[r10+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 0c
11ceh mov [rsp+48h],r10d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(5 bytes) = 44 89 54 24 48
11d3h mov r10d,[rsp+48h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(5 bytes) = 44 8b 54 24 48
11d8h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
11dch or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
11dfh cmp dword ptr [rsp+70h],4     ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),4h:imm32]  encoding(5 bytes) = 83 7c 24 70 04
11e4h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 09 01 00 00
11eah mov r10,[rsp+68h]             ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8b 54 24 68
11efh mov r10d,[r10+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 10
11f3h mov [rsp+40h],r10d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(5 bytes) = 44 89 54 24 40
11f8h mov r10d,[rsp+40h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(5 bytes) = 44 8b 54 24 40
11fdh shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
1201h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
1204h cmp dword ptr [rsp+70h],5     ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),5h:imm32]  encoding(5 bytes) = 83 7c 24 70 05
1209h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 e4 00 00 00
120fh mov r10,[rsp+68h]             ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8b 54 24 68
1214h mov r10d,[r10+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 14
1218h mov [rsp+38h],r10d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(5 bytes) = 44 89 54 24 38
121dh mov r10d,[rsp+38h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(5 bytes) = 44 8b 54 24 38
1222h shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
1226h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
1229h cmp dword ptr [rsp+70h],6     ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),6h:imm32]  encoding(5 bytes) = 83 7c 24 70 06
122eh jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 bf 00 00 00
1234h mov r10,[rsp+68h]             ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8b 54 24 68
1239h mov r10d,[r10+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 18
123dh mov [rsp+30h],r10d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(5 bytes) = 44 89 54 24 30
1242h mov r10d,[rsp+30h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(5 bytes) = 44 8b 54 24 30
1247h shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
124bh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
124eh cmp dword ptr [rsp+70h],7     ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),7h:imm32]  encoding(5 bytes) = 83 7c 24 70 07
1253h jbe near ptr 12f3h            ; JBE(Jbe_rel32_64) [12F3h:jmp64]                      encoding(6 bytes) = 0f 86 9a 00 00 00
1259h mov r10,[rsp+68h]             ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8b 54 24 68
125eh mov r10d,[r10+1Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,DS:sr)]       encoding(4 bytes) = 45 8b 52 1c
1262h mov [rsp+28h],r10d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(5 bytes) = 44 89 54 24 28
1267h mov r10d,[rsp+28h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(5 bytes) = 44 8b 54 24 28
126ch shl r10d,7                    ; SHL(Shl_rm32_imm8) [R10D,7h:imm8]                    encoding(4 bytes) = 41 c1 e2 07
1270h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
1273h shl r9,8                      ; SHL(Shl_rm64_imm8) [R9,8h:imm8]                      encoding(4 bytes) = 49 c1 e1 08
1277h or rcx,r9                     ; OR(Or_r64_rm64) [RCX,R9]                             encoding(3 bytes) = 49 0b c9
127ah shl rcx,10h                   ; SHL(Shl_rm64_imm8) [RCX,10h:imm8]                    encoding(4 bytes) = 48 c1 e1 10
127eh or rax,rcx                    ; OR(Or_r64_rm64) [RAX,RCX]                            encoding(3 bytes) = 48 0b c1
1281h shl rax,20h                   ; SHL(Shl_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e0 20
1285h or rdx,rax                    ; OR(Or_r64_rm64) [RDX,RAX]                            encoding(3 bytes) = 48 0b d0
1288h mov [r8],rdx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RDX]         encoding(3 bytes) = 49 89 10
128bh add rsp,320h                  ; ADD(Add_rm64_imm32) [RSP,320h:imm64]                 encoding(7 bytes) = 48 81 c4 20 03 00 00
1292h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
1293h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
1294h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
1295h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
1296h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
1298h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
1299h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 da 4f 96 ff
129eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
129fh call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 d4 4f 96 ff
12a4h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12a5h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 ce 4f 96 ff
12aah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12abh call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 c8 4f 96 ff
12b0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12b1h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 c2 4f 96 ff
12b6h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12b7h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 bc 4f 96 ff
12bch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12bdh call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 b6 4f 96 ff
12c2h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12c3h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 b0 4f 96 ff
12c8h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12c9h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 aa 4f 96 ff
12ceh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12cfh call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 a4 4f 96 ff
12d4h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12d5h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 9e 4f 96 ff
12dah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12dbh call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 98 4f 96 ff
12e0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12e1h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 92 4f 96 ff
12e6h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12e7h call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 8c 4f 96 ff
12ech int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12edh call 7FFDDB4305C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966278h:jmp64]        encoding(5 bytes) = e8 86 4f 96 ff
12f2h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
12f3h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F584BB0h:jmp64]                encoding(5 bytes) = e8 b8 38 58 5f
12f8h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[4857]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x81,0xEC,0x20,0x03,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x68,0xB9,0xAC,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8B,0x01,0x8B,0x49,0x08,0x4C,0x8B,0xC8,0x44,0x8B,0xD1,0x4D,0x8B,0xD9,0x41,0x8B,0xF2,0x41,0x83,0xFA,0x00,0x0F,0x86,0xB3,0x12,0x00,0x00,0x41,0x8B,0x39,0x41,0x83,0xFA,0x01,0x0F,0x86,0xA6,0x12,0x00,0x00,0x41,0x8B,0x59,0x04,0xD1,0xE3,0x0B,0xFB,0x41,0x83,0xFA,0x02,0x0F,0x86,0x94,0x12,0x00,0x00,0x41,0x8B,0x59,0x08,0xC1,0xE3,0x02,0x0B,0xFB,0x41,0x83,0xFA,0x03,0x0F,0x86,0x81,0x12,0x00,0x00,0x41,0x8B,0x59,0x0C,0xC1,0xE3,0x03,0x0B,0xFB,0x41,0x83,0xFA,0x04,0x0F,0x86,0x6E,0x12,0x00,0x00,0x41,0x8B,0x59,0x10,0xC1,0xE3,0x04,0x0B,0xFB,0x41,0x83,0xFA,0x05,0x0F,0x86,0x5B,0x12,0x00,0x00,0x41,0x8B,0x59,0x14,0xC1,0xE3,0x05,0x0B,0xFB,0x41,0x83,0xFA,0x06,0x0F,0x86,0x48,0x12,0x00,0x00,0x45,0x8B,0x49,0x18,0x41,0xC1,0xE1,0x06,0x41,0x0B,0xF9,0x83,0xFE,0x07,0x0F,0x86,0x34,0x12,0x00,0x00,0x45,0x8B,0x4B,0x1C,0x41,0xC1,0xE1,0x07,0x41,0x0B,0xF9,0x44,0x8B,0xCF,0x83,0xF9,0x08,0x0F,0x82,0xC3,0x11,0x00,0x00,0x44,0x8D,0x51,0xF8,0x4C,0x8D,0x58,0x20,0x41,0x83,0xFA,0x00,0x0F,0x86,0x0B,0x12,0x00,0x00,0x41,0x8B,0x33,0x41,0x83,0xFA,0x01,0x0F,0x86,0xFE,0x11,0x00,0x00,0x41,0x8B,0x7B,0x04,0xD1,0xE7,0x0B,0xF7,0x41,0x83,0xFA,0x02,0x0F,0x86,0xEC,0x11,0x00,0x00,0x41,0x8B,0x7B,0x08,0xC1,0xE7,0x02,0x0B,0xF7,0x41,0x83,0xFA,0x03,0x0F,0x86,0xD9,0x11,0x00,0x00,0x41,0x8B,0x7B,0x0C,0xC1,0xE7,0x03,0x0B,0xF7,0x41,0x83,0xFA,0x04,0x0F,0x86,0xC6,0x11,0x00,0x00,0x41,0x8B,0x7B,0x10,0xC1,0xE7,0x04,0x0B,0xF7,0x41,0x83,0xFA,0x05,0x0F,0x86,0xB3,0x11,0x00,0x00,0x41,0x8B,0x7B,0x14,0xC1,0xE7,0x05,0x0B,0xF7,0x41,0x83,0xFA,0x06,0x0F,0x86,0xA0,0x11,0x00,0x00,0x41,0x8B,0x7B,0x18,0xC1,0xE7,0x06,0x0B,0xF7,0x41,0x83,0xFA,0x07,0x0F,0x86,0x8D,0x11,0x00,0x00,0x45,0x8B,0x53,0x1C,0x41,0xC1,0xE2,0x07,0x41,0x0B,0xF2,0x44,0x8B,0xD6,0x49,0xC1,0xE2,0x08,0x4D,0x0B,0xCA,0x83,0xF9,0x10,0x0F,0x82,0x1B,0x11,0x00,0x00,0x44,0x8D,0x51,0xF0,0x4C,0x8D,0x58,0x40,0x41,0x83,0xFA,0x00,0x0F,0x86,0x5D,0x11,0x00,0x00,0x41,0x8B,0x33,0x41,0x83,0xFA,0x01,0x0F,0x86,0x50,0x11,0x00,0x00,0x41,0x8B,0x7B,0x04,0xD1,0xE7,0x0B,0xF7,0x41,0x83,0xFA,0x02,0x0F,0x86,0x3E,0x11,0x00,0x00,0x41,0x8B,0x7B,0x08,0xC1,0xE7,0x02,0x0B,0xF7,0x41,0x83,0xFA,0x03,0x0F,0x86,0x2B,0x11,0x00,0x00,0x41,0x8B,0x7B,0x0C,0xC1,0xE7,0x03,0x0B,0xF7,0x41,0x83,0xFA,0x04,0x0F,0x86,0x18,0x11,0x00,0x00,0x41,0x8B,0x7B,0x10,0xC1,0xE7,0x04,0x0B,0xF7,0x41,0x83,0xFA,0x05,0x0F,0x86,0x05,0x11,0x00,0x00,0x41,0x8B,0x7B,0x14,0xC1,0xE7,0x05,0x0B,0xF7,0x41,0x83,0xFA,0x06,0x0F,0x86,0xF2,0x10,0x00,0x00,0x41,0x8B,0x7B,0x18,0xC1,0xE7,0x06,0x0B,0xF7,0x41,0x83,0xFA,0x07,0x0F,0x86,0xDF,0x10,0x00,0x00,0x41,0x8B,0x7B,0x1C,0xC1,0xE7,0x07,0x0B,0xF7,0x41,0x83,0xFA,0x08,0x0F,0x82,0x7E,0x10,0x00,0x00,0x41,0x83,0xC2,0xF8,0x49,0x83,0xC3,0x20,0x41,0x83,0xFA,0x00,0x0F,0x86,0xBA,0x10,0x00,0x00,0x41,0x8B,0x3B,0x41,0x83,0xFA,0x01,0x0F,0x86,0xAD,0x10,0x00,0x00,0x41,0x8B,0x5B,0x04,0xD1,0xE3,0x0B,0xFB,0x41,0x83,0xFA,0x02,0x0F,0x86,0x9B,0x10,0x00,0x00,0x41,0x8B,0x5B,0x08,0xC1,0xE3,0x02,0x0B,0xFB,0x41,0x83,0xFA,0x03,0x0F,0x86,0x88,0x10,0x00,0x00,0x41,0x8B,0x5B,0x0C,0xC1,0xE3,0x03,0x0B,0xFB,0x41,0x83,0xFA,0x04,0x0F,0x86,0x75,0x10,0x00,0x00,0x41,0x8B,0x5B,0x10,0xC1,0xE3,0x04,0x0B,0xFB,0x41,0x83,0xFA,0x05,0x0F,0x86,0x62,0x10,0x00,0x00,0x41,0x8B,0x5B,0x14,0xC1,0xE3,0x05,0x0B,0xFB,0x41,0x83,0xFA,0x06,0x0F,0x86,0x4F,0x10,0x00,0x00,0x41,0x8B,0x5B,0x18,0xC1,0xE3,0x06,0x0B,0xFB,0x41,0x83,0xFA,0x07,0x0F,0x86,0x3C,0x10,0x00,0x00,0x45,0x8B,0x53,0x1C,0x41,0xC1,0xE2,0x07,0x41,0x0B,0xFA,0x44,0x8B,0xD7,0x49,0xC1,0xE2,0x08,0x49,0x0B,0xF2,0x4C,0x8B,0xD6,0x49,0xC1,0xE2,0x10,0x4D,0x0B,0xCA,0x83,0xF9,0x20,0x0F,0x82,0xCC,0x0F,0x00,0x00,0x44,0x8D,0x51,0xE0,0x4C,0x8D,0x98,0x80,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x0F,0x86,0xFF,0x0F,0x00,0x00,0x41,0x8B,0x33,0x41,0x83,0xFA,0x01,0x0F,0x86,0xF2,0x0F,0x00,0x00,0x41,0x8B,0x7B,0x04,0xD1,0xE7,0x0B,0xF7,0x41,0x83,0xFA,0x02,0x0F,0x86,0xE0,0x0F,0x00,0x00,0x41,0x8B,0x7B,0x08,0xC1,0xE7,0x02,0x0B,0xF7,0x41,0x83,0xFA,0x03,0x0F,0x86,0xCD,0x0F,0x00,0x00,0x41,0x8B,0x7B,0x0C,0xC1,0xE7,0x03,0x0B,0xF7,0x41,0x83,0xFA,0x04,0x0F,0x86,0xBA,0x0F,0x00,0x00,0x41,0x8B,0x7B,0x10,0xC1,0xE7,0x04,0x0B,0xF7,0x41,0x83,0xFA,0x05,0x0F,0x86,0xA7,0x0F,0x00,0x00,0x41,0x8B,0x7B,0x14,0xC1,0xE7,0x05,0x0B,0xF7,0x41,0x83,0xFA,0x06,0x0F,0x86,0x94,0x0F,0x00,0x00,0x41,0x8B,0x7B,0x18,0xC1,0xE7,0x06,0x0B,0xF7,0x41,0x83,0xFA,0x07,0x0F,0x86,0x81,0x0F,0x00,0x00,0x41,0x8B,0x7B,0x1C,0xC1,0xE7,0x07,0x0B,0xF7,0x41,0x83,0xFA,0x08,0x0F,0x82,0x2C,0x0F,0x00,0x00,0x41,0x8D,0x7A,0xF8,0x49,0x8D,0x5B,0x20,0x83,0xFF,0x00,0x0F,0x86,0x5D,0x0F,0x00,0x00,0x8B,0x2B,0x83,0xFF,0x01,0x0F,0x86,0x52,0x0F,0x00,0x00,0x44,0x8B,0x73,0x04,0x41,0xD1,0xE6,0x41,0x0B,0xEE,0x83,0xFF,0x02,0x0F,0x86,0x3F,0x0F,0x00,0x00,0x44,0x8B,0x73,0x08,0x41,0xC1,0xE6,0x02,0x41,0x0B,0xEE,0x83,0xFF,0x03,0x0F,0x86,0x2B,0x0F,0x00,0x00,0x44,0x8B,0x73,0x0C,0x41,0xC1,0xE6,0x03,0x41,0x0B,0xEE,0x83,0xFF,0x04,0x0F,0x86,0x17,0x0F,0x00,0x00,0x44,0x8B,0x73,0x10,0x41,0xC1,0xE6,0x04,0x41,0x0B,0xEE,0x83,0xFF,0x05,0x0F,0x86,0x03,0x0F,0x00,0x00,0x44,0x8B,0x73,0x14,0x41,0xC1,0xE6,0x05,0x41,0x0B,0xEE,0x83,0xFF,0x06,0x0F,0x86,0xEF,0x0E,0x00,0x00,0x44,0x8B,0x73,0x18,0x41,0xC1,0xE6,0x06,0x41,0x0B,0xEE,0x83,0xFF,0x07,0x0F,0x86,0xDB,0x0E,0x00,0x00,0x8B,0x7B,0x1C,0xC1,0xE7,0x07,0x0B,0xEF,0x8B,0xFD,0x48,0xC1,0xE7,0x08,0x48,0x0B,0xF7,0x41,0x83,0xFA,0x10,0x0F,0x82,0x84,0x0E,0x00,0x00,0x41,0x83,0xC2,0xF0,0x49,0x83,0xC3,0x40,0x41,0x83,0xFA,0x00,0x0F,0x86,0xAE,0x0E,0x00,0x00,0x41,0x8B,0x3B,0x41,0x83,0xFA,0x01,0x0F,0x86,0xA1,0x0E,0x00,0x00,0x41,0x8B,0x5B,0x04,0xD1,0xE3,0x0B,0xFB,0x41,0x83,0xFA,0x02,0x0F,0x86,0x8F,0x0E,0x00,0x00,0x41,0x8B,0x5B,0x08,0xC1,0xE3,0x02,0x0B,0xFB,0x41,0x83,0xFA,0x03,0x0F,0x86,0x7C,0x0E,0x00,0x00,0x41,0x8B,0x5B,0x0C,0xC1,0xE3,0x03,0x0B,0xFB,0x41,0x83,0xFA,0x04,0x0F,0x86,0x69,0x0E,0x00,0x00,0x41,0x8B,0x5B,0x10,0xC1,0xE3,0x04,0x0B,0xFB,0x41,0x83,0xFA,0x05,0x0F,0x86,0x56,0x0E,0x00,0x00,0x41,0x8B,0x5B,0x14,0xC1,0xE3,0x05,0x0B,0xFB,0x41,0x83,0xFA,0x06,0x0F,0x86,0x43,0x0E,0x00,0x00,0x41,0x8B,0x5B,0x18,0xC1,0xE3,0x06,0x0B,0xFB,0x41,0x83,0xFA,0x07,0x0F,0x86,0x30,0x0E,0x00,0x00,0x41,0x8B,0x5B,0x1C,0xC1,0xE3,0x07,0x0B,0xFB,0x41,0x83,0xFA,0x08,0x0F,0x82,0xE7,0x0D,0x00,0x00,0x41,0x83,0xC2,0xF8,0x49,0x83,0xC3,0x20,0x41,0x83,0xFA,0x00,0x0F,0x86,0x0B,0x0E,0x00,0x00,0x41,0x8B,0x1B,0x41,0x83,0xFA,0x01,0x0F,0x86,0xFE,0x0D,0x00,0x00,0x41,0x8B,0x6B,0x04,0xD1,0xE5,0x0B,0xDD,0x41,0x83,0xFA,0x02,0x0F,0x86,0xEC,0x0D,0x00,0x00,0x41,0x8B,0x6B,0x08,0xC1,0xE5,0x02,0x0B,0xDD,0x41,0x83,0xFA,0x03,0x0F,0x86,0xD9,0x0D,0x00,0x00,0x41,0x8B,0x6B,0x0C,0xC1,0xE5,0x03,0x0B,0xDD,0x41,0x83,0xFA,0x04,0x0F,0x86,0xC6,0x0D,0x00,0x00,0x41,0x8B,0x6B,0x10,0xC1,0xE5,0x04,0x0B,0xDD,0x41,0x83,0xFA,0x05,0x0F,0x86,0xB3,0x0D,0x00,0x00,0x41,0x8B,0x6B,0x14,0xC1,0xE5,0x05,0x0B,0xDD,0x41,0x83,0xFA,0x06,0x0F,0x86,0xA0,0x0D,0x00,0x00,0x41,0x8B,0x6B,0x18,0xC1,0xE5,0x06,0x0B,0xDD,0x41,0x83,0xFA,0x07,0x0F,0x86,0x8D,0x0D,0x00,0x00,0x45,0x8B,0x53,0x1C,0x41,0xC1,0xE2,0x07,0x41,0x0B,0xDA,0x44,0x8B,0xD3,0x49,0xC1,0xE2,0x08,0x49,0x0B,0xFA,0x4C,0x8B,0xD7,0x49,0xC1,0xE2,0x10,0x49,0x0B,0xF2,0x4C,0x8B,0xD6,0x49,0xC1,0xE2,0x20,0x4D,0x0B,0xCA,0x4C,0x89,0x0A,0x83,0xF9,0x40,0x0F,0x82,0x28,0x0D,0x00,0x00,0x83,0xC1,0xC0,0x48,0x05,0x00,0x01,0x00,0x00,0x83,0xF9,0x00,0x0F,0x86,0x46,0x0D,0x00,0x00,0x8B,0x10,0x83,0xF9,0x01,0x0F,0x86,0x3B,0x0D,0x00,0x00,0x44,0x8B,0x48,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xD1,0x83,0xF9,0x02,0x0F,0x86,0x28,0x0D,0x00,0x00,0x44,0x8B,0x48,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xD1,0x83,0xF9,0x03,0x0F,0x86,0x14,0x0D,0x00,0x00,0x44,0x8B,0x48,0x0C,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xD1,0x83,0xF9,0x04,0x0F,0x86,0x00,0x0D,0x00,0x00,0x44,0x8B,0x48,0x10,0x41,0xC1,0xE1,0x04,0x41,0x0B,0xD1,0x83,0xF9,0x05,0x0F,0x86,0xEC,0x0C,0x00,0x00,0x44,0x8B,0x48,0x14,0x41,0xC1,0xE1,0x05,0x41,0x0B,0xD1,0x83,0xF9,0x06,0x0F,0x86,0xD8,0x0C,0x00,0x00,0x44,0x8B,0x48,0x18,0x41,0xC1,0xE1,0x06,0x41,0x0B,0xD1,0x83,0xF9,0x07,0x0F,0x86,0xC4,0x0C,0x00,0x00,0x44,0x8B,0x48,0x1C,0x41,0xC1,0xE1,0x07,0x41,0x0B,0xD1,0x83,0xF9,0x08,0x0F,0x82,0x86,0x0C,0x00,0x00,0x44,0x8D,0x49,0xF8,0x4C,0x8D,0x50,0x20,0x41,0x83,0xF9,0x00,0x0F,0x86,0x9E,0x0C,0x00,0x00,0x45,0x8B,0x1A,0x41,0x83,0xF9,0x01,0x0F,0x86,0x91,0x0C,0x00,0x00,0x41,0x8B,0x72,0x04,0xD1,0xE6,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x02,0x0F,0x86,0x7E,0x0C,0x00,0x00,0x41,0x8B,0x72,0x08,0xC1,0xE6,0x02,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x03,0x0F,0x86,0x6A,0x0C,0x00,0x00,0x41,0x8B,0x72,0x0C,0xC1,0xE6,0x03,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x04,0x0F,0x86,0x56,0x0C,0x00,0x00,0x41,0x8B,0x72,0x10,0xC1,0xE6,0x04,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x05,0x0F,0x86,0x42,0x0C,0x00,0x00,0x41,0x8B,0x72,0x14,0xC1,0xE6,0x05,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x06,0x0F,0x86,0x2E,0x0C,0x00,0x00,0x41,0x8B,0x72,0x18,0xC1,0xE6,0x06,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x07,0x0F,0x86,0x1A,0x0C,0x00,0x00,0x45,0x8B,0x4A,0x1C,0x44,0x89,0x8C,0x24,0x18,0x03,0x00,0x00,0x44,0x8B,0x8C,0x24,0x18,0x03,0x00,0x00,0x41,0xC1,0xE1,0x07,0x45,0x0B,0xD9,0x45,0x8B,0xCB,0x49,0xC1,0xE1,0x08,0x49,0x0B,0xD1,0x83,0xF9,0x10,0x0F,0x82,0xC8,0x0B,0x00,0x00,0x4C,0x8D,0x8C,0x24,0x08,0x03,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x01,0x44,0x8D,0x49,0xF0,0x4C,0x8D,0x50,0x40,0x4C,0x89,0x94,0x24,0x00,0x03,0x00,0x00,0x4C,0x8B,0x94,0x24,0x00,0x03,0x00,0x00,0x4C,0x8D,0x9C,0x24,0x08,0x03,0x00,0x00,0x4D,0x89,0x13,0x44,0x89,0x8C,0x24,0x10,0x03,0x00,0x00,0x4C,0x8D,0x8C,0x24,0x08,0x03,0x00,0x00,0x4D,0x8B,0x11,0x45,0x8B,0x49,0x08,0x4C,0x8D,0x9C,0x24,0xF0,0x02,0x00,0x00,0x4D,0x89,0x13,0x45,0x89,0x4B,0x08,0xC5,0xFA,0x6F,0x84,0x24,0xF0,0x02,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xD0,0x02,0x00,0x00,0x83,0xBC,0x24,0xD8,0x02,0x00,0x00,0x00,0x0F,0x86,0x72,0x0B,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xD0,0x02,0x00,0x00,0x45,0x8B,0x09,0x44,0x89,0x8C,0x24,0xC8,0x02,0x00,0x00,0x44,0x8B,0x8C,0x24,0xC8,0x02,0x00,0x00,0x83,0xBC,0x24,0xD8,0x02,0x00,0x00,0x01,0x0F,0x86,0x49,0x0B,0x00,0x00,0x4C,0x8B,0x94,0x24,0xD0,0x02,0x00,0x00,0x45,0x8B,0x52,0x04,0x44,0x89,0x94,0x24,0xC0,0x02,0x00,0x00,0x44,0x8B,0x94,0x24,0xC0,0x02,0x00,0x00,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x83,0xBC,0x24,0xD8,0x02,0x00,0x00,0x02,0x0F,0x86,0x19,0x0B,0x00,0x00,0x4C,0x8B,0x94,0x24,0xD0,0x02,0x00,0x00,0x45,0x8B,0x52,0x08,0x44,0x89,0x94,0x24,0xB8,0x02,0x00,0x00,0x44,0x8B,0x94,0x24,0xB8,0x02,0x00,0x00,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x83,0xBC,0x24,0xD8,0x02,0x00,0x00,0x03,0x0F,0x86,0xE8,0x0A,0x00,0x00,0x4C,0x8B,0x94,0x24,0xD0,0x02,0x00,0x00,0x45,0x8B,0x52,0x0C,0x44,0x89,0x94,0x24,0xB0,0x02,0x00,0x00,0x44,0x8B,0x94,0x24,0xB0,0x02,0x00,0x00,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x83,0xBC,0x24,0xD8,0x02,0x00,0x00,0x04,0x0F,0x86,0xB7,0x0A,0x00,0x00,0x4C,0x8B,0x94,0x24,0xD0,0x02,0x00,0x00,0x45,0x8B,0x52,0x10,0x44,0x89,0x94,0x24,0xA8,0x02,0x00,0x00,0x44,0x8B,0x94,0x24,0xA8,0x02,0x00,0x00,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x83,0xBC,0x24,0xD8,0x02,0x00,0x00,0x05,0x0F,0x86,0x86,0x0A,0x00,0x00,0x4C,0x8B,0x94,0x24,0xD0,0x02,0x00,0x00,0x45,0x8B,0x52,0x14,0x44,0x89,0x94,0x24,0xA0,0x02,0x00,0x00,0x44,0x8B,0x94,0x24,0xA0,0x02,0x00,0x00,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x83,0xBC,0x24,0xD8,0x02,0x00,0x00,0x06,0x0F,0x86,0x55,0x0A,0x00,0x00,0x4C,0x8B,0x94,0x24,0xD0,0x02,0x00,0x00,0x45,0x8B,0x52,0x18,0x44,0x89,0x94,0x24,0x98,0x02,0x00,0x00,0x44,0x8B,0x94,0x24,0x98,0x02,0x00,0x00,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x83,0xBC,0x24,0xD8,0x02,0x00,0x00,0x07,0x0F,0x86,0x24,0x0A,0x00,0x00,0x4C,0x8B,0x94,0x24,0xD0,0x02,0x00,0x00,0x45,0x8B,0x52,0x1C,0x44,0x89,0x94,0x24,0x90,0x02,0x00,0x00,0x44,0x8B,0x94,0x24,0x90,0x02,0x00,0x00,0x41,0xC1,0xE2,0x07,0x45,0x0B,0xCA,0x83,0xBC,0x24,0xF8,0x02,0x00,0x00,0x08,0x0F,0x82,0xD5,0x09,0x00,0x00,0x4C,0x8B,0x94,0x24,0xF0,0x02,0x00,0x00,0x4C,0x8D,0x9C,0x24,0x80,0x02,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x03,0x44,0x8B,0x9C,0x24,0xF8,0x02,0x00,0x00,0x41,0x83,0xC3,0xF8,0x49,0x83,0xC2,0x20,0x4C,0x89,0x94,0x24,0x78,0x02,0x00,0x00,0x4C,0x8B,0x94,0x24,0x78,0x02,0x00,0x00,0x48,0x8D,0xB4,0x24,0x80,0x02,0x00,0x00,0x4C,0x89,0x16,0x44,0x89,0x9C,0x24,0x88,0x02,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x80,0x02,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xE0,0x02,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xE0,0x02,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x68,0x02,0x00,0x00,0x83,0xBC,0x24,0x70,0x02,0x00,0x00,0x00,0x0F,0x86,0x75,0x09,0x00,0x00,0x4C,0x8B,0x94,0x24,0x68,0x02,0x00,0x00,0x45,0x8B,0x12,0x44,0x89,0x94,0x24,0x60,0x02,0x00,0x00,0x44,0x8B,0x94,0x24,0x60,0x02,0x00,0x00,0x83,0xBC,0x24,0x70,0x02,0x00,0x00,0x01,0x0F,0x86,0x4C,0x09,0x00,0x00,0x4C,0x8B,0x9C,0x24,0x68,0x02,0x00,0x00,0x45,0x8B,0x5B,0x04,0x44,0x89,0x9C,0x24,0x58,0x02,0x00,0x00,0x44,0x8B,0x9C,0x24,0x58,0x02,0x00,0x00,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x83,0xBC,0x24,0x70,0x02,0x00,0x00,0x02,0x0F,0x86,0x1C,0x09,0x00,0x00,0x4C,0x8B,0x9C,0x24,0x68,0x02,0x00,0x00,0x45,0x8B,0x5B,0x08,0x44,0x89,0x9C,0x24,0x50,0x02,0x00,0x00,0x44,0x8B,0x9C,0x24,0x50,0x02,0x00,0x00,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x83,0xBC,0x24,0x70,0x02,0x00,0x00,0x03,0x0F,0x86,0xEB,0x08,0x00,0x00,0x4C,0x8B,0x9C,0x24,0x68,0x02,0x00,0x00,0x45,0x8B,0x5B,0x0C,0x44,0x89,0x9C,0x24,0x48,0x02,0x00,0x00,0x44,0x8B,0x9C,0x24,0x48,0x02,0x00,0x00,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x83,0xBC,0x24,0x70,0x02,0x00,0x00,0x04,0x0F,0x86,0xBA,0x08,0x00,0x00,0x4C,0x8B,0x9C,0x24,0x68,0x02,0x00,0x00,0x45,0x8B,0x5B,0x10,0x44,0x89,0x9C,0x24,0x40,0x02,0x00,0x00,0x44,0x8B,0x9C,0x24,0x40,0x02,0x00,0x00,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x83,0xBC,0x24,0x70,0x02,0x00,0x00,0x05,0x0F,0x86,0x89,0x08,0x00,0x00,0x4C,0x8B,0x9C,0x24,0x68,0x02,0x00,0x00,0x45,0x8B,0x5B,0x14,0x44,0x89,0x9C,0x24,0x38,0x02,0x00,0x00,0x44,0x8B,0x9C,0x24,0x38,0x02,0x00,0x00,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x83,0xBC,0x24,0x70,0x02,0x00,0x00,0x06,0x0F,0x86,0x58,0x08,0x00,0x00,0x4C,0x8B,0x9C,0x24,0x68,0x02,0x00,0x00,0x45,0x8B,0x5B,0x18,0x44,0x89,0x9C,0x24,0x30,0x02,0x00,0x00,0x44,0x8B,0x9C,0x24,0x30,0x02,0x00,0x00,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x83,0xBC,0x24,0x70,0x02,0x00,0x00,0x07,0x0F,0x86,0x27,0x08,0x00,0x00,0x4C,0x8B,0x9C,0x24,0x68,0x02,0x00,0x00,0x45,0x8B,0x5B,0x1C,0x44,0x89,0x9C,0x24,0x28,0x02,0x00,0x00,0x44,0x8B,0x9C,0x24,0x28,0x02,0x00,0x00,0x41,0xC1,0xE3,0x07,0x45,0x0B,0xD3,0x49,0xC1,0xE2,0x08,0x4D,0x0B,0xCA,0x49,0xC1,0xE1,0x10,0x49,0x0B,0xD1,0x83,0xF9,0x20,0x0F,0x82,0xD5,0x07,0x00,0x00,0x4C,0x8D,0x8C,0x24,0x18,0x02,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x01,0x83,0xC1,0xE0,0x48,0x05,0x80,0x00,0x00,0x00,0x48,0x89,0x84,0x24,0x10,0x02,0x00,0x00,0x48,0x8B,0x84,0x24,0x10,0x02,0x00,0x00,0x4C,0x8D,0x8C,0x24,0x18,0x02,0x00,0x00,0x49,0x89,0x01,0x89,0x8C,0x24,0x20,0x02,0x00,0x00,0x48,0x8D,0x84,0x24,0x18,0x02,0x00,0x00,0x48,0x8B,0x08,0x8B,0x40,0x08,0x4C,0x8D,0x8C,0x24,0x00,0x02,0x00,0x00,0x49,0x89,0x09,0x41,0x89,0x41,0x08,0xC5,0xFA,0x6F,0x84,0x24,0x00,0x02,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xE0,0x01,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xE0,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xC0,0x01,0x00,0x00,0x8B,0x84,0x24,0xC8,0x01,0x00,0x00,0x83,0xF8,0x00,0x0F,0x86,0x60,0x07,0x00,0x00,0x48,0x8B,0x8C,0x24,0xC0,0x01,0x00,0x00,0x8B,0x09,0x89,0x8C,0x24,0xB8,0x01,0x00,0x00,0x8B,0x8C,0x24,0xB8,0x01,0x00,0x00,0x83,0xF8,0x01,0x0F,0x86,0x3F,0x07,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xC0,0x01,0x00,0x00,0x45,0x8B,0x49,0x04,0x44,0x89,0x8C,0x24,0xB0,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0xB0,0x01,0x00,0x00,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x83,0xF8,0x02,0x0F,0x86,0x14,0x07,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xC0,0x01,0x00,0x00,0x45,0x8B,0x49,0x08,0x44,0x89,0x8C,0x24,0xA8,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0xA8,0x01,0x00,0x00,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x83,0xF8,0x03,0x0F,0x86,0xE8,0x06,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xC0,0x01,0x00,0x00,0x45,0x8B,0x49,0x0C,0x44,0x89,0x8C,0x24,0xA0,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0xA0,0x01,0x00,0x00,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC9,0x83,0xF8,0x04,0x0F,0x86,0xBC,0x06,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xC0,0x01,0x00,0x00,0x45,0x8B,0x49,0x10,0x44,0x89,0x8C,0x24,0x98,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0x98,0x01,0x00,0x00,0x41,0xC1,0xE1,0x04,0x41,0x0B,0xC9,0x83,0xF8,0x05,0x0F,0x86,0x90,0x06,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xC0,0x01,0x00,0x00,0x45,0x8B,0x49,0x14,0x44,0x89,0x8C,0x24,0x90,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0x90,0x01,0x00,0x00,0x41,0xC1,0xE1,0x05,0x41,0x0B,0xC9,0x83,0xF8,0x06,0x0F,0x86,0x64,0x06,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xC0,0x01,0x00,0x00,0x45,0x8B,0x49,0x18,0x44,0x89,0x8C,0x24,0x88,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0x88,0x01,0x00,0x00,0x41,0xC1,0xE1,0x06,0x41,0x0B,0xC9,0x83,0xF8,0x07,0x0F,0x86,0x38,0x06,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xC0,0x01,0x00,0x00,0x45,0x8B,0x49,0x1C,0x44,0x89,0x8C,0x24,0x80,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0x80,0x01,0x00,0x00,0x41,0xC1,0xE1,0x07,0x41,0x0B,0xC9,0x83,0xF8,0x08,0x0F,0x82,0xFA,0x05,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xE0,0x01,0x00,0x00,0x4C,0x8D,0x94,0x24,0x70,0x01,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x02,0x83,0xC0,0xF8,0x49,0x83,0xC1,0x20,0x4C,0x89,0x8C,0x24,0x68,0x01,0x00,0x00,0x4C,0x8B,0x8C,0x24,0x68,0x01,0x00,0x00,0x4C,0x8D,0x94,0x24,0x70,0x01,0x00,0x00,0x4D,0x89,0x0A,0x89,0x84,0x24,0x78,0x01,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x70,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xD0,0x01,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xD0,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x58,0x01,0x00,0x00,0x83,0xBC,0x24,0x60,0x01,0x00,0x00,0x00,0x0F,0x86,0x98,0x05,0x00,0x00,0x48,0x8B,0x84,0x24,0x58,0x01,0x00,0x00,0x8B,0x00,0x89,0x84,0x24,0x50,0x01,0x00,0x00,0x8B,0x84,0x24,0x50,0x01,0x00,0x00,0x83,0xBC,0x24,0x60,0x01,0x00,0x00,0x01,0x0F,0x86,0x72,0x05,0x00,0x00,0x4C,0x8B,0x8C,0x24,0x58,0x01,0x00,0x00,0x45,0x8B,0x49,0x04,0x44,0x89,0x8C,0x24,0x48,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0x48,0x01,0x00,0x00,0x41,0xD1,0xE1,0x41,0x0B,0xC1,0x83,0xBC,0x24,0x60,0x01,0x00,0x00,0x02,0x0F,0x86,0x42,0x05,0x00,0x00,0x4C,0x8B,0x8C,0x24,0x58,0x01,0x00,0x00,0x45,0x8B,0x49,0x08,0x44,0x89,0x8C,0x24,0x40,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0x40,0x01,0x00,0x00,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC1,0x83,0xBC,0x24,0x60,0x01,0x00,0x00,0x03,0x0F,0x86,0x11,0x05,0x00,0x00,0x4C,0x8B,0x8C,0x24,0x58,0x01,0x00,0x00,0x45,0x8B,0x49,0x0C,0x44,0x89,0x8C,0x24,0x38,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0x38,0x01,0x00,0x00,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC1,0x83,0xBC,0x24,0x60,0x01,0x00,0x00,0x04,0x0F,0x86,0xE0,0x04,0x00,0x00,0x4C,0x8B,0x8C,0x24,0x58,0x01,0x00,0x00,0x45,0x8B,0x49,0x10,0x44,0x89,0x8C,0x24,0x30,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0x30,0x01,0x00,0x00,0x41,0xC1,0xE1,0x04,0x41,0x0B,0xC1,0x83,0xBC,0x24,0x60,0x01,0x00,0x00,0x05,0x0F,0x86,0xAF,0x04,0x00,0x00,0x4C,0x8B,0x8C,0x24,0x58,0x01,0x00,0x00,0x45,0x8B,0x49,0x14,0x44,0x89,0x8C,0x24,0x28,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0x28,0x01,0x00,0x00,0x41,0xC1,0xE1,0x05,0x41,0x0B,0xC1,0x83,0xBC,0x24,0x60,0x01,0x00,0x00,0x06,0x0F,0x86,0x7E,0x04,0x00,0x00,0x4C,0x8B,0x8C,0x24,0x58,0x01,0x00,0x00,0x45,0x8B,0x49,0x18,0x44,0x89,0x8C,0x24,0x20,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0x20,0x01,0x00,0x00,0x41,0xC1,0xE1,0x06,0x41,0x0B,0xC1,0x83,0xBC,0x24,0x60,0x01,0x00,0x00,0x07,0x0F,0x86,0x4D,0x04,0x00,0x00,0x4C,0x8B,0x8C,0x24,0x58,0x01,0x00,0x00,0x45,0x8B,0x49,0x1C,0x44,0x89,0x8C,0x24,0x18,0x01,0x00,0x00,0x44,0x8B,0x8C,0x24,0x18,0x01,0x00,0x00,0x41,0xC1,0xE1,0x07,0x41,0x0B,0xC1,0x48,0xC1,0xE0,0x08,0x48,0x0B,0xC8,0x48,0x8B,0xC1,0x83,0xBC,0x24,0x08,0x02,0x00,0x00,0x10,0x0F,0x82,0x06,0x04,0x00,0x00,0x48,0x8B,0x8C,0x24,0x00,0x02,0x00,0x00,0x4C,0x8D,0x8C,0x24,0x08,0x01,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x01,0x44,0x8B,0x8C,0x24,0x08,0x02,0x00,0x00,0x41,0x83,0xC1,0xF0,0x48,0x83,0xC1,0x40,0x48,0x89,0x8C,0x24,0x00,0x01,0x00,0x00,0x48,0x8B,0x8C,0x24,0x00,0x01,0x00,0x00,0x4C,0x8D,0x94,0x24,0x08,0x01,0x00,0x00,0x49,0x89,0x0A,0x44,0x89,0x8C,0x24,0x10,0x01,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x08,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xF0,0x01,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xF0,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xF0,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xF0,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xD0,0x00,0x00,0x00,0x83,0xBC,0x24,0xD8,0x00,0x00,0x00,0x00,0x0F,0x86,0x82,0x03,0x00,0x00,0x48,0x8B,0x8C,0x24,0xD0,0x00,0x00,0x00,0x8B,0x09,0x89,0x8C,0x24,0xC8,0x00,0x00,0x00,0x8B,0x8C,0x24,0xC8,0x00,0x00,0x00,0x83,0xBC,0x24,0xD8,0x00,0x00,0x00,0x01,0x0F,0x86,0x5C,0x03,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xD0,0x00,0x00,0x00,0x45,0x8B,0x49,0x04,0x44,0x89,0x8C,0x24,0xC0,0x00,0x00,0x00,0x44,0x8B,0x8C,0x24,0xC0,0x00,0x00,0x00,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x83,0xBC,0x24,0xD8,0x00,0x00,0x00,0x02,0x0F,0x86,0x2C,0x03,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xD0,0x00,0x00,0x00,0x45,0x8B,0x49,0x08,0x44,0x89,0x8C,0x24,0xB8,0x00,0x00,0x00,0x44,0x8B,0x8C,0x24,0xB8,0x00,0x00,0x00,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x83,0xBC,0x24,0xD8,0x00,0x00,0x00,0x03,0x0F,0x86,0xFB,0x02,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xD0,0x00,0x00,0x00,0x45,0x8B,0x49,0x0C,0x44,0x89,0x8C,0x24,0xB0,0x00,0x00,0x00,0x44,0x8B,0x8C,0x24,0xB0,0x00,0x00,0x00,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC9,0x83,0xBC,0x24,0xD8,0x00,0x00,0x00,0x04,0x0F,0x86,0xCA,0x02,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xD0,0x00,0x00,0x00,0x45,0x8B,0x49,0x10,0x44,0x89,0x8C,0x24,0xA8,0x00,0x00,0x00,0x44,0x8B,0x8C,0x24,0xA8,0x00,0x00,0x00,0x41,0xC1,0xE1,0x04,0x41,0x0B,0xC9,0x83,0xBC,0x24,0xD8,0x00,0x00,0x00,0x05,0x0F,0x86,0x99,0x02,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xD0,0x00,0x00,0x00,0x45,0x8B,0x49,0x14,0x44,0x89,0x8C,0x24,0xA0,0x00,0x00,0x00,0x44,0x8B,0x8C,0x24,0xA0,0x00,0x00,0x00,0x41,0xC1,0xE1,0x05,0x41,0x0B,0xC9,0x83,0xBC,0x24,0xD8,0x00,0x00,0x00,0x06,0x0F,0x86,0x68,0x02,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xD0,0x00,0x00,0x00,0x45,0x8B,0x49,0x18,0x44,0x89,0x8C,0x24,0x98,0x00,0x00,0x00,0x44,0x8B,0x8C,0x24,0x98,0x00,0x00,0x00,0x41,0xC1,0xE1,0x06,0x41,0x0B,0xC9,0x83,0xBC,0x24,0xD8,0x00,0x00,0x00,0x07,0x0F,0x86,0x37,0x02,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xD0,0x00,0x00,0x00,0x45,0x8B,0x49,0x1C,0x44,0x89,0x8C,0x24,0x90,0x00,0x00,0x00,0x44,0x8B,0x8C,0x24,0x90,0x00,0x00,0x00,0x41,0xC1,0xE1,0x07,0x41,0x0B,0xC9,0x83,0xBC,0x24,0xF8,0x00,0x00,0x00,0x08,0x0F,0x82,0x00,0x02,0x00,0x00,0x4C,0x8B,0x8C,0x24,0xF0,0x00,0x00,0x00,0x4C,0x8D,0x94,0x24,0x80,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x02,0x44,0x8B,0x94,0x24,0xF8,0x00,0x00,0x00,0x41,0x83,0xC2,0xF8,0x49,0x83,0xC1,0x20,0x4C,0x89,0x4C,0x24,0x78,0x4C,0x8B,0x4C,0x24,0x78,0x4C,0x8D,0x9C,0x24,0x80,0x00,0x00,0x00,0x4D,0x89,0x0B,0x44,0x89,0x94,0x24,0x88,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x44,0x24,0x68,0x83,0x7C,0x24,0x70,0x00,0x0F,0x86,0x94,0x01,0x00,0x00,0x4C,0x8B,0x4C,0x24,0x68,0x45,0x8B,0x09,0x44,0x89,0x4C,0x24,0x60,0x44,0x8B,0x4C,0x24,0x60,0x83,0x7C,0x24,0x70,0x01,0x0F,0x86,0x77,0x01,0x00,0x00,0x4C,0x8B,0x54,0x24,0x68,0x45,0x8B,0x52,0x04,0x44,0x89,0x54,0x24,0x58,0x44,0x8B,0x54,0x24,0x58,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x83,0x7C,0x24,0x70,0x02,0x0F,0x86,0x53,0x01,0x00,0x00,0x4C,0x8B,0x54,0x24,0x68,0x45,0x8B,0x52,0x08,0x44,0x89,0x54,0x24,0x50,0x44,0x8B,0x54,0x24,0x50,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x83,0x7C,0x24,0x70,0x03,0x0F,0x86,0x2E,0x01,0x00,0x00,0x4C,0x8B,0x54,0x24,0x68,0x45,0x8B,0x52,0x0C,0x44,0x89,0x54,0x24,0x48,0x44,0x8B,0x54,0x24,0x48,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x83,0x7C,0x24,0x70,0x04,0x0F,0x86,0x09,0x01,0x00,0x00,0x4C,0x8B,0x54,0x24,0x68,0x45,0x8B,0x52,0x10,0x44,0x89,0x54,0x24,0x40,0x44,0x8B,0x54,0x24,0x40,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x83,0x7C,0x24,0x70,0x05,0x0F,0x86,0xE4,0x00,0x00,0x00,0x4C,0x8B,0x54,0x24,0x68,0x45,0x8B,0x52,0x14,0x44,0x89,0x54,0x24,0x38,0x44,0x8B,0x54,0x24,0x38,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x83,0x7C,0x24,0x70,0x06,0x0F,0x86,0xBF,0x00,0x00,0x00,0x4C,0x8B,0x54,0x24,0x68,0x45,0x8B,0x52,0x18,0x44,0x89,0x54,0x24,0x30,0x44,0x8B,0x54,0x24,0x30,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x83,0x7C,0x24,0x70,0x07,0x0F,0x86,0x9A,0x00,0x00,0x00,0x4C,0x8B,0x54,0x24,0x68,0x45,0x8B,0x52,0x1C,0x44,0x89,0x54,0x24,0x28,0x44,0x8B,0x54,0x24,0x28,0x41,0xC1,0xE2,0x07,0x45,0x0B,0xCA,0x49,0xC1,0xE1,0x08,0x49,0x0B,0xC9,0x48,0xC1,0xE1,0x10,0x48,0x0B,0xC1,0x48,0xC1,0xE0,0x20,0x48,0x0B,0xD0,0x49,0x89,0x10,0x48,0x81,0xC4,0x20,0x03,0x00,0x00,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xE8,0xDA,0x4F,0x96,0xFF,0xCC,0xE8,0xD4,0x4F,0x96,0xFF,0xCC,0xE8,0xCE,0x4F,0x96,0xFF,0xCC,0xE8,0xC8,0x4F,0x96,0xFF,0xCC,0xE8,0xC2,0x4F,0x96,0xFF,0xCC,0xE8,0xBC,0x4F,0x96,0xFF,0xCC,0xE8,0xB6,0x4F,0x96,0xFF,0xCC,0xE8,0xB0,0x4F,0x96,0xFF,0xCC,0xE8,0xAA,0x4F,0x96,0xFF,0xCC,0xE8,0xA4,0x4F,0x96,0xFF,0xCC,0xE8,0x9E,0x4F,0x96,0xFF,0xCC,0xE8,0x98,0x4F,0x96,0xFF,0xCC,0xE8,0x92,0x4F,0x96,0xFF,0xCC,0xE8,0x8C,0x4F,0x96,0xFF,0xCC,0xE8,0x86,0x4F,0x96,0xFF,0xCC,0xE8,0xB8,0x38,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> pack(ReadOnlySpan<bit> src, Span<byte> dst)
; location: [7FFDDBACB690h, 7FFDDBACB6F8h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0009h mov r9,[r8]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R8:br,DS:sr)]          encoding(3 bytes) = 4d 8b 08
000ch mov r8d,[r8+8]                ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 45 8b 40 08
0010h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 4c 8b 12
0013h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0016h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0019h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
001bh jle short 0055h               ; JLE(Jle_rel8_64) [55h:jmp64]                         encoding(2 bytes) = 7e 38
001dh movsxd rcx,r11d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R11D]                   encoding(3 bytes) = 49 63 cb
0020h mov ecx,[r10+rcx*4]           ; MOV(Mov_r32_rm32) [ECX,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 0c 8a
0024h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0027h jne short 004dh               ; JNE(Jne_rel8_64) [4Dh:jmp64]                         encoding(2 bytes) = 75 24
0029h mov ecx,r11d                  ; MOV(Mov_r32_rm32) [ECX,R11D]                         encoding(3 bytes) = 41 8b cb
002ch sar ecx,3                     ; SAR(Sar_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 f9 03
002fh cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
0032h jae short 0063h               ; JAE(Jae_rel8_64) [63h:jmp64]                         encoding(2 bytes) = 73 2f
0034h movsxd rsi,ecx                ; MOVSXD(Movsxd_r64_rm32) [RSI,ECX]                    encoding(3 bytes) = 48 63 f1
0037h add rsi,r9                    ; ADD(Add_r64_rm64) [RSI,R9]                           encoding(3 bytes) = 49 03 f1
003ah mov ecx,r11d                  ; MOV(Mov_r32_rm32) [ECX,R11D]                         encoding(3 bytes) = 41 8b cb
003dh and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0040h mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0045h shl edi,cl                    ; SHL(Shl_rm32_CL) [EDI,CL]                            encoding(2 bytes) = d3 e7
0047h movzx ecx,dil                 ; MOVZX(Movzx_r32_rm8) [ECX,DIL]                       encoding(4 bytes) = 40 0f b6 cf
004bh or [rsi],cl                   ; OR(Or_rm8_r8) [mem(8u,RSI:br,DS:sr),CL]              encoding(2 bytes) = 08 0e
004dh inc r11d                      ; INC(Inc_rm32) [R11D]                                 encoding(3 bytes) = 41 ff c3
0050h cmp r11d,edx                  ; CMP(Cmp_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 3b da
0053h jl short 001dh                ; JL(Jl_rel8_64) [1Dh:jmp64]                           encoding(2 bytes) = 7c c8
0055h mov [rax],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 08
0058h mov [rax+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 40 08
005ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0060h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0061h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0063h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F583870h:jmp64]                encoding(5 bytes) = e8 08 38 58 5f
0068h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[105]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0x4D,0x8B,0x08,0x45,0x8B,0x40,0x08,0x4C,0x8B,0x12,0x8B,0x52,0x08,0x45,0x33,0xDB,0x85,0xD2,0x7E,0x38,0x49,0x63,0xCB,0x41,0x8B,0x0C,0x8A,0x83,0xF9,0x01,0x75,0x24,0x41,0x8B,0xCB,0xC1,0xF9,0x03,0x41,0x3B,0xC8,0x73,0x2F,0x48,0x63,0xF1,0x49,0x03,0xF1,0x41,0x8B,0xCB,0x83,0xE1,0x07,0xBF,0x01,0x00,0x00,0x00,0xD3,0xE7,0x40,0x0F,0xB6,0xCF,0x08,0x0E,0x41,0xFF,0xC3,0x44,0x3B,0xDA,0x7C,0xC8,0x4C,0x89,0x08,0x44,0x89,0x40,0x08,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3,0xE8,0x08,0x38,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> pack(ReadOnlySpan<byte> src, Span<byte> dst)
; location: [7FFDDBACB720h, 7FFDDBACB786h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0009h mov r9,[r8]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R8:br,DS:sr)]          encoding(3 bytes) = 4d 8b 08
000ch mov r8d,[r8+8]                ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 45 8b 40 08
0010h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 4c 8b 12
0013h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0016h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0019h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
001bh jle short 0053h               ; JLE(Jle_rel8_64) [53h:jmp64]                         encoding(2 bytes) = 7e 36
001dh movsxd rcx,r11d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R11D]                   encoding(3 bytes) = 49 63 cb
0020h cmp byte ptr [r10+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,R10:br,DS:sr),1h:imm8]     encoding(5 bytes) = 41 80 3c 0a 01
0025h jne short 004bh               ; JNE(Jne_rel8_64) [4Bh:jmp64]                         encoding(2 bytes) = 75 24
0027h mov ecx,r11d                  ; MOV(Mov_r32_rm32) [ECX,R11D]                         encoding(3 bytes) = 41 8b cb
002ah sar ecx,3                     ; SAR(Sar_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 f9 03
002dh cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
0030h jae short 0061h               ; JAE(Jae_rel8_64) [61h:jmp64]                         encoding(2 bytes) = 73 2f
0032h movsxd rsi,ecx                ; MOVSXD(Movsxd_r64_rm32) [RSI,ECX]                    encoding(3 bytes) = 48 63 f1
0035h add rsi,r9                    ; ADD(Add_r64_rm64) [RSI,R9]                           encoding(3 bytes) = 49 03 f1
0038h mov ecx,r11d                  ; MOV(Mov_r32_rm32) [ECX,R11D]                         encoding(3 bytes) = 41 8b cb
003bh and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
003eh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0043h shl edi,cl                    ; SHL(Shl_rm32_CL) [EDI,CL]                            encoding(2 bytes) = d3 e7
0045h movzx ecx,dil                 ; MOVZX(Movzx_r32_rm8) [ECX,DIL]                       encoding(4 bytes) = 40 0f b6 cf
0049h or [rsi],cl                   ; OR(Or_rm8_r8) [mem(8u,RSI:br,DS:sr),CL]              encoding(2 bytes) = 08 0e
004bh inc r11d                      ; INC(Inc_rm32) [R11D]                                 encoding(3 bytes) = 41 ff c3
004eh cmp r11d,edx                  ; CMP(Cmp_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 3b da
0051h jl short 001dh                ; JL(Jl_rel8_64) [1Dh:jmp64]                           encoding(2 bytes) = 7c ca
0053h mov [rax],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 08
0056h mov [rax+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 40 08
005ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
005eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0060h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0061h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F5837E0h:jmp64]                encoding(5 bytes) = e8 7a 37 58 5f
0066h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[103]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0x4D,0x8B,0x08,0x45,0x8B,0x40,0x08,0x4C,0x8B,0x12,0x8B,0x52,0x08,0x45,0x33,0xDB,0x85,0xD2,0x7E,0x36,0x49,0x63,0xCB,0x41,0x80,0x3C,0x0A,0x01,0x75,0x24,0x41,0x8B,0xCB,0xC1,0xF9,0x03,0x41,0x3B,0xC8,0x73,0x2F,0x48,0x63,0xF1,0x49,0x03,0xF1,0x41,0x8B,0xCB,0x83,0xE1,0x07,0xBF,0x01,0x00,0x00,0x00,0xD3,0xE7,0x40,0x0F,0xB6,0xCF,0x08,0x0E,0x41,0xFF,0xC3,0x44,0x3B,0xDA,0x7C,0xCA,0x4C,0x89,0x08,0x44,0x89,0x40,0x08,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3,0xE8,0x7A,0x37,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> pack(Boolean[] src)
; location: [7FFDDBACB7A0h, 7FFDDBACB82Ch]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000ah mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000dh mov ebx,[rsi+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 5e 08
0010h mov edx,ebx                   ; MOV(Mov_r32_rm32) [EDX,EBX]                          encoding(2 bytes) = 8b d3
0012h sar edx,3                     ; SAR(Sar_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 fa 03
0015h test bl,7                     ; TEST(Test_rm8_imm8) [BL,7h:imm8]                     encoding(3 bytes) = f6 c3 07
0018h je short 001ch                ; JE(Je_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 74 02
001ah inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
001ch movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001fh mov rcx,7FFDDB3EEA10h         ; MOV(Mov_r64_imm64) [RCX,7ffddb3eea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 3e db fd 7f 00 00
0029h call 7FFE3AF245E0h            ; CALL(Call_rel32_64) [5F458E40h:jmp64]                encoding(5 bytes) = e8 12 8e 45 5f
002eh lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
0032h mov r8d,[rax+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 08
0036h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0039h test ebx,ebx                  ; TEST(Test_rm32_r32) [EBX,EBX]                        encoding(2 bytes) = 85 db
003bh jle short 0075h               ; JLE(Jle_rel8_64) [75h:jmp64]                         encoding(2 bytes) = 7e 38
003dh movsxd rcx,r9d                ; MOVSXD(Movsxd_r64_rm32) [RCX,R9D]                    encoding(3 bytes) = 49 63 c9
0040h cmp byte ptr [rsi+rcx+10h],0  ; CMP(Cmp_rm8_imm8) [mem(8u,RSI:br,DS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 0e 10 00
0045h je short 006dh                ; JE(Je_rel8_64) [6Dh:jmp64]                           encoding(2 bytes) = 74 26
0047h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
004ah sar ecx,3                     ; SAR(Sar_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 f9 03
004dh cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
0050h jae short 0087h               ; JAE(Jae_rel8_64) [87h:jmp64]                         encoding(2 bytes) = 73 35
0052h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0055h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0058h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
005bh and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
005eh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0064h shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
0067h movzx ecx,r10b                ; MOVZX(Movzx_r32_rm8) [ECX,R10L]                      encoding(4 bytes) = 41 0f b6 ca
006bh or [rax],cl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,DS:sr),CL]              encoding(2 bytes) = 08 08
006dh inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0070h cmp r9d,ebx                   ; CMP(Cmp_r32_rm32) [R9D,EBX]                          encoding(3 bytes) = 44 3b cb
0073h jl short 003dh                ; JL(Jl_rel8_64) [3Dh:jmp64]                           encoding(2 bytes) = 7c c8
0075h mov [rdi],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 17
0078h mov [rdi+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 47 08
007ch mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
007fh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0083h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0084h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0085h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0086h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0087h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F583760h:jmp64]                encoding(5 bytes) = e8 d4 36 58 5f
008ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[141]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x8B,0x5E,0x08,0x8B,0xD3,0xC1,0xFA,0x03,0xF6,0xC3,0x07,0x74,0x02,0xFF,0xC2,0x48,0x63,0xD2,0x48,0xB9,0x10,0xEA,0x3E,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x12,0x8E,0x45,0x5F,0x48,0x8D,0x50,0x10,0x44,0x8B,0x40,0x08,0x45,0x33,0xC9,0x85,0xDB,0x7E,0x38,0x49,0x63,0xC9,0x80,0x7C,0x0E,0x10,0x00,0x74,0x26,0x41,0x8B,0xC9,0xC1,0xF9,0x03,0x41,0x3B,0xC8,0x73,0x35,0x48,0x63,0xC1,0x48,0x03,0xC2,0x41,0x8B,0xC9,0x83,0xE1,0x07,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0xD3,0xE2,0x41,0x0F,0xB6,0xCA,0x08,0x08,0x41,0xFF,0xC1,0x44,0x3B,0xCB,0x7C,0xC8,0x48,0x89,0x17,0x44,0x89,0x47,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3,0xE8,0xD4,0x36,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte packseq(ReadOnlySpan<byte> src, out byte dst)
; location: [7FFDDBACB850h, 7FFDDBACB8ADh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 41 08
000ch mov byte ptr [rdx],0          ; MOV(Mov_rm8_imm8) [mem(8u,RDX:br,DS:sr),0h:imm8]     encoding(3 bytes) = c6 02 00
000fh cmp r8d,8                     ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 f8 08
0013h jge short 001ah               ; JGE(Jge_rel8_64) [1Ah:jmp64]                         encoding(2 bytes) = 7d 05
0015h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0018h jmp short 0020h               ; JMP(Jmp_rel8_64) [20h:jmp64]                         encoding(2 bytes) = eb 06
001ah mov r9d,8                     ; MOV(Mov_r32_imm32) [R9D,8h:imm32]                    encoding(6 bytes) = 41 b9 08 00 00 00
0020h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0023h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0026h jle short 0050h               ; JLE(Jle_rel8_64) [50h:jmp64]                         encoding(2 bytes) = 7e 28
0028h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002bh jae short 0058h               ; JAE(Jae_rel8_64) [58h:jmp64]                         encoding(2 bytes) = 73 2b
002dh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0030h cmp byte ptr [rax+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,DS:sr),1h:imm8]     encoding(4 bytes) = 80 3c 08 01
0034h jne short 0048h               ; JNE(Jne_rel8_64) [48h:jmp64]                         encoding(2 bytes) = 75 12
0036h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003ch mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
003fh shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0042h movzx ecx,r11b                ; MOVZX(Movzx_r32_rm8) [ECX,R11L]                      encoding(4 bytes) = 41 0f b6 cb
0046h or [rdx],cl                   ; OR(Or_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]              encoding(2 bytes) = 08 0a
0048h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004bh cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004eh jl short 0028h                ; JL(Jl_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7c d8
0050h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0053h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0058h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F5836B0h:jmp64]                encoding(5 bytes) = e8 53 36 58 5f
005dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[94]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0xC6,0x02,0x00,0x41,0x83,0xF8,0x08,0x7D,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x08,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x28,0x45,0x3B,0xD0,0x73,0x2B,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x12,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB6,0xCB,0x08,0x0A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD8,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x53,0x36,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte packseq(out byte dst, Byte[] src)
; location: [7FFDDBACB8D0h, 7FFDDBACB92Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0007h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,DS:sr),0h:imm8]     encoding(3 bytes) = c6 00 00
000ah mov r8d,[rdx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 42 08
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h cmp r9d,8                     ; CMP(Cmp_rm32_imm8) [R9D,8h:imm32]                    encoding(4 bytes) = 41 83 f9 08
0015h jge short 0019h               ; JGE(Jge_rel8_64) [19h:jmp64]                         encoding(2 bytes) = 7d 02
0017h jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 06
0019h mov r9d,8                     ; MOV(Mov_r32_imm32) [R9D,8h:imm32]                    encoding(6 bytes) = 41 b9 08 00 00 00
001fh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0022h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0025h jle short 0050h               ; JLE(Jle_rel8_64) [50h:jmp64]                         encoding(2 bytes) = 7e 29
0027h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002ah jae short 0055h               ; JAE(Jae_rel8_64) [55h:jmp64]                         encoding(2 bytes) = 73 29
002ch movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
002fh cmp byte ptr [rdx+rcx+10h],1  ; CMP(Cmp_rm8_imm8) [mem(8u,RDX:br,DS:sr),1h:imm8]     encoding(5 bytes) = 80 7c 0a 10 01
0034h jne short 0048h               ; JNE(Jne_rel8_64) [48h:jmp64]                         encoding(2 bytes) = 75 12
0036h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003ch mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
003fh shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0042h movzx ecx,r11b                ; MOVZX(Movzx_r32_rm8) [ECX,R11L]                      encoding(4 bytes) = 41 0f b6 cb
0046h or [rax],cl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,DS:sr),CL]              encoding(2 bytes) = 08 08
0048h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004bh cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004eh jl short 0027h                ; JL(Jl_rel8_64) [27h:jmp64]                           encoding(2 bytes) = 7c d7
0050h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0054h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0055h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F583630h:jmp64]                encoding(5 bytes) = e8 d6 35 58 5f
005ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[91]{0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0xC6,0x00,0x00,0x44,0x8B,0x42,0x08,0x45,0x8B,0xC8,0x41,0x83,0xF9,0x08,0x7D,0x02,0xEB,0x06,0x41,0xB9,0x08,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x29,0x45,0x3B,0xD0,0x73,0x29,0x49,0x63,0xCA,0x80,0x7C,0x0A,0x10,0x01,0x75,0x12,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB6,0xCB,0x08,0x08,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD7,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xD6,0x35,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint packseq(out uint dst, Byte[] src)
; location: [7FFDDBACB940h, 7FFDDBACB99Bh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0007h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0009h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
000bh mov r8d,[rdx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 42 08
000fh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0012h cmp r9d,20h                   ; CMP(Cmp_rm32_imm8) [R9D,20h:imm32]                   encoding(4 bytes) = 41 83 f9 20
0016h jge short 001ah               ; JGE(Jge_rel8_64) [1Ah:jmp64]                         encoding(2 bytes) = 7d 02
0018h jmp short 0020h               ; JMP(Jmp_rel8_64) [20h:jmp64]                         encoding(2 bytes) = eb 06
001ah mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
0020h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0023h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0026h jle short 0051h               ; JLE(Jle_rel8_64) [51h:jmp64]                         encoding(2 bytes) = 7e 29
0028h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002bh jae short 0056h               ; JAE(Jae_rel8_64) [56h:jmp64]                         encoding(2 bytes) = 73 29
002dh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0030h cmp byte ptr [rdx+rcx+10h],1  ; CMP(Cmp_rm8_imm8) [mem(8u,RDX:br,DS:sr),1h:imm8]     encoding(5 bytes) = 80 7c 0a 10 01
0035h jne short 0049h               ; JNE(Jne_rel8_64) [49h:jmp64]                         encoding(2 bytes) = 75 12
0037h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003dh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0040h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0043h movzx ecx,r11b                ; MOVZX(Movzx_r32_rm8) [ECX,R11L]                      encoding(4 bytes) = 41 0f b6 cb
0047h or [rax],ecx                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]          encoding(2 bytes) = 09 08
0049h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004ch cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004fh jl short 0028h                ; JL(Jl_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7c d7
0051h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0055h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0056h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F5835C0h:jmp64]                encoding(5 bytes) = e8 65 35 58 5f
005bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[92]{0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0x33,0xC9,0x89,0x08,0x44,0x8B,0x42,0x08,0x45,0x8B,0xC8,0x41,0x83,0xF9,0x20,0x7D,0x02,0xEB,0x06,0x41,0xB9,0x20,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x29,0x45,0x3B,0xD0,0x73,0x29,0x49,0x63,0xCA,0x80,0x7C,0x0A,0x10,0x01,0x75,0x12,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB6,0xCB,0x09,0x08,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD7,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x65,0x35,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort packseq(ReadOnlySpan<byte> src, out ushort dst)
; location: [7FFDDBACB9B0h, 7FFDDBACBA10h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 41 08
000ch mov word ptr [rdx],0          ; MOV(Mov_rm16_imm16) [mem(16u,RDX:br,DS:sr),0h:imm16] encoding(5 bytes) = 66 c7 02 00 00
0011h cmp r8d,10h                   ; CMP(Cmp_rm32_imm8) [R8D,10h:imm32]                   encoding(4 bytes) = 41 83 f8 10
0015h jge short 001ch               ; JGE(Jge_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = 7d 05
0017h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
001ah jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 06
001ch mov r9d,10h                   ; MOV(Mov_r32_imm32) [R9D,10h:imm32]                   encoding(6 bytes) = 41 b9 10 00 00 00
0022h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0025h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0028h jle short 0053h               ; JLE(Jle_rel8_64) [53h:jmp64]                         encoding(2 bytes) = 7e 29
002ah cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002dh jae short 005bh               ; JAE(Jae_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 73 2c
002fh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0032h cmp byte ptr [rax+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,DS:sr),1h:imm8]     encoding(4 bytes) = 80 3c 08 01
0036h jne short 004bh               ; JNE(Jne_rel8_64) [4Bh:jmp64]                         encoding(2 bytes) = 75 13
0038h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003eh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0041h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0044h movzx ecx,r11w                ; MOVZX(Movzx_r32_rm16) [ECX,R11W]                     encoding(4 bytes) = 41 0f b7 cb
0048h or [rdx],cx                   ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),CX]           encoding(3 bytes) = 66 09 0a
004bh inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004eh cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
0051h jl short 002ah                ; JL(Jl_rel8_64) [2Ah:jmp64]                           encoding(2 bytes) = 7c d7
0053h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0056h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005bh call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F583550h:jmp64]                encoding(5 bytes) = e8 f0 34 58 5f
0060h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[97]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0x66,0xC7,0x02,0x00,0x00,0x41,0x83,0xF8,0x10,0x7D,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x10,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x29,0x45,0x3B,0xD0,0x73,0x2C,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x13,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB7,0xCB,0x66,0x09,0x0A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD7,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF0,0x34,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint packseq(ReadOnlySpan<byte> src, out uint dst)
; location: [7FFDDBACBA30h, 7FFDDBACBA8Bh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 41 08
000ch xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000eh mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
0010h cmp r8d,20h                   ; CMP(Cmp_rm32_imm8) [R8D,20h:imm32]                   encoding(4 bytes) = 41 83 f8 20
0014h jge short 001bh               ; JGE(Jge_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = 7d 05
0016h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0019h jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 06
001bh mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
0021h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0024h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0027h jle short 004eh               ; JLE(Jle_rel8_64) [4Eh:jmp64]                         encoding(2 bytes) = 7e 25
0029h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002ch jae short 0056h               ; JAE(Jae_rel8_64) [56h:jmp64]                         encoding(2 bytes) = 73 28
002eh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0031h cmp byte ptr [rax+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,DS:sr),1h:imm8]     encoding(4 bytes) = 80 3c 08 01
0035h jne short 0046h               ; JNE(Jne_rel8_64) [46h:jmp64]                         encoding(2 bytes) = 75 0f
0037h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003dh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0040h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0043h or [rdx],r11d                 ; OR(Or_rm32_r32) [mem(32u,RDX:br,DS:sr),R11D]         encoding(3 bytes) = 44 09 1a
0046h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0049h cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004ch jl short 0029h                ; JL(Jl_rel8_64) [29h:jmp64]                           encoding(2 bytes) = 7c db
004eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0051h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0055h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0056h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F5834D0h:jmp64]                encoding(5 bytes) = e8 75 34 58 5f
005bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[92]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0x33,0xC9,0x89,0x0A,0x41,0x83,0xF8,0x20,0x7D,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x20,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x25,0x45,0x3B,0xD0,0x73,0x28,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x0F,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x44,0x09,0x1A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xDB,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x75,0x34,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong packseq(ReadOnlySpan<byte> src, out ulong dst)
; location: [7FFDDBACBAA0h, 7FFDDBACBAFCh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 41 08
000ch xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000eh mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RCX]        encoding(3 bytes) = 48 89 0a
0011h cmp r8d,40h                   ; CMP(Cmp_rm32_imm8) [R8D,40h:imm32]                   encoding(4 bytes) = 41 83 f8 40
0015h jge short 001ch               ; JGE(Jge_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = 7d 05
0017h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
001ah jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 06
001ch mov r9d,40h                   ; MOV(Mov_r32_imm32) [R9D,40h:imm32]                   encoding(6 bytes) = 41 b9 40 00 00 00
0022h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0025h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0028h jle short 004fh               ; JLE(Jle_rel8_64) [4Fh:jmp64]                         encoding(2 bytes) = 7e 25
002ah cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002dh jae short 0057h               ; JAE(Jae_rel8_64) [57h:jmp64]                         encoding(2 bytes) = 73 28
002fh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0032h cmp byte ptr [rax+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,DS:sr),1h:imm8]     encoding(4 bytes) = 80 3c 08 01
0036h jne short 0047h               ; JNE(Jne_rel8_64) [47h:jmp64]                         encoding(2 bytes) = 75 0f
0038h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003eh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0041h shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
0044h or [rdx],r11                  ; OR(Or_rm64_r64) [mem(64u,RDX:br,DS:sr),R11]          encoding(3 bytes) = 4c 09 1a
0047h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004ah cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004dh jl short 002ah                ; JL(Jl_rel8_64) [2Ah:jmp64]                           encoding(2 bytes) = 7c db
004fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0052h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0057h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F583460h:jmp64]                encoding(5 bytes) = e8 04 34 58 5f
005ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[93]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0x33,0xC9,0x48,0x89,0x0A,0x41,0x83,0xF8,0x40,0x7D,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x40,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x25,0x45,0x3B,0xD0,0x73,0x28,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x0F,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x4C,0x09,0x1A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xDB,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x04,0x34,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(sbyte src)
; location: [7FFDDBACBB20h, 7FFDDBACBB2Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(byte src)
; location: [7FFDDBACBB40h, 7FFDDBACBB4Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(short src)
; location: [7FFDDBACBB60h, 7FFDDBACBB6Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ushort src)
; location: [7FFDDBACBB80h, 7FFDDBACBB8Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(int src)
; location: [7FFDDBACBBA0h, 7FFDDBACBBABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt eax,ecx                ; POPCNT(Popcnt_r32_rm32) [EAX,ECX]                    encoding(4 bytes) = f3 0f b8 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(uint src)
; location: [7FFDDBACBBC0h, 7FFDDBACBBCBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt eax,ecx                ; POPCNT(Popcnt_r32_rm32) [EAX,ECX]                    encoding(4 bytes) = f3 0f b8 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(long src)
; location: [7FFDDBACBBE0h, 7FFDDBACBBECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong src)
; location: [7FFDDBACBC00h, 7FFDDBACBC0Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong x0, ulong x1)
; location: [7FFDDBACBC20h, 7FFDDBACBC33h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong x0, ulong x1, ulong x2, ulong x3)
; location: [7FFDDBACBC50h, 7FFDDBACBC75h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0013h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0015h popcnt rdx,r8                 ; POPCNT(Popcnt_r64_rm64) [RDX,R8]                     encoding(5 bytes) = f3 49 0f b8 d0
001ah add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
001ch xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
001eh popcnt rdx,r9                 ; POPCNT(Popcnt_r64_rm64) [RDX,R9]                     encoding(5 bytes) = f3 49 0f b8 d1
0023h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD0,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD1,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong x0, ulong x1, ulong x2, ulong x3, ulong x4, ulong x5, ulong x6, ulong x7)
; location: [7FFDDBACBC90h, 7FFDDBACBCE1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0013h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0015h popcnt rdx,r8                 ; POPCNT(Popcnt_r64_rm64) [RDX,R8]                     encoding(5 bytes) = f3 49 0f b8 d0
001ah add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
001ch xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
001eh popcnt rdx,r9                 ; POPCNT(Popcnt_r64_rm64) [RDX,R9]                     encoding(5 bytes) = f3 49 0f b8 d1
0023h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0025h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0027h popcnt rdx,[rsp+28h]          ; POPCNT(Popcnt_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]  encoding(7 bytes) = f3 48 0f b8 54 24 28
002eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0030h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0032h popcnt rdx,[rsp+30h]          ; POPCNT(Popcnt_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]  encoding(7 bytes) = f3 48 0f b8 54 24 30
0039h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
003bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
003dh popcnt rdx,[rsp+38h]          ; POPCNT(Popcnt_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]  encoding(7 bytes) = f3 48 0f b8 54 24 38
0044h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0046h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0048h popcnt rdx,[rsp+40h]          ; POPCNT(Popcnt_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]  encoding(7 bytes) = f3 48 0f b8 54 24 40
004fh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0051h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[82]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD0,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD1,0x03,0xC2,0x33,0xD2,0xF3,0x48,0x0F,0xB8,0x54,0x24,0x28,0x03,0xC2,0x33,0xD2,0xF3,0x48,0x0F,0xB8,0x54,0x24,0x30,0x03,0xC2,0x33,0xD2,0xF3,0x48,0x0F,0xB8,0x54,0x24,0x38,0x03,0xC2,0x33,0xD2,0xF3,0x48,0x0F,0xB8,0x54,0x24,0x40,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint posl(byte src)
; location: [7FFDDBACBD00h, 7FFDDBACBD21h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jne short 0018h               ; JNE(Jne_rel8_64) [18h:jmp64]                         encoding(2 bytes) = 75 04
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 09
0018h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
001ch neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001eh add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> poslBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB6,0xC0,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint posl(ushort src)
; location: [7FFDDBACBD40h, 7FFDDBACBD61h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jne short 0018h               ; JNE(Jne_rel8_64) [18h:jmp64]                         encoding(2 bytes) = 75 04
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 09
0018h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
001ch neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001eh add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> poslBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB7,0xC0,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint posl(uint src)
; location: [7FFDDBACBD80h, 7FFDDBACBD9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi eax,ecx                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,ECX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d9
000ah test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ch jne short 0012h               ; JNE(Jne_rel8_64) [12h:jmp64]                         encoding(2 bytes) = 75 04
000eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0010h jmp short 001bh               ; JMP(Jmp_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = eb 09
0012h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
0016h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0018h add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> poslBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD9,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint posl(ulong src)
; location: [7FFDDBACBDB0h, 7FFDDBACBDCDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi rax,rcx                  ; BLSI(VEX_Blsi_r64_rm64) [RAX,RCX]                    encoding(VEX, 5 bytes) = c4 e2 f8 f3 d9
000ah test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
000dh jne short 0013h               ; JNE(Jne_rel8_64) [13h:jmp64]                         encoding(2 bytes) = 75 04
000fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0011h jmp short 001dh               ; JMP(Jmp_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = eb 0a
0013h lzcnt rax,rax                 ; LZCNT(Lzcnt_r64_rm64) [RAX,RAX]                      encoding(5 bytes) = f3 48 0f bd c0
0018h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001ah add eax,3Fh                   ; ADD(Add_rm32_imm8) [EAX,3fh:imm32]                   encoding(3 bytes) = 83 c0 3f
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> poslBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD9,0x48,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x0A,0xF3,0x48,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x3F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte range(sbyte src, BitPos i0, BitPos i1)
; location: [7FFDDBACC1F0h, 7FFDDBACC21Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000dh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
001fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0022h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0x0F,0xB6,0xD2,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte range(byte src, BitPos i0, BitPos i1)
; location: [7FFDDBACC230h, 7FFDDBACC256h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000dh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
001eh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0023h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort range(ushort src, BitPos i0, BitPos i1)
; location: [7FFDDBACC270h, 7FFDDBACC296h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000dh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
001eh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0023h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short range(short src, BitPos i0, BitPos i1)
; location: [7FFDDBACC2B0h, 7FFDDBACC2DEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000dh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
001fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0022h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0027h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
002ah movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint range(uint src, BitPos i0, BitPos i1)
; location: [7FFDDBACC2F0h, 7FFDDBACC310h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000dh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int range(int src, BitPos i0, BitPos i1)
; location: [7FFDDBACC330h, 7FFDDBACC350h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000dh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long range(long src, BitPos i0, BitPos i1)
; location: [7FFDDBACC370h, 7FFDDBACC390h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000dh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong range(ulong src, BitPos i0, BitPos i1)
; location: [7FFDDBACC3B0h, 7FFDDBACC3D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000dh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float range(float src, BitPos i0, BitPos i1)
; location: [7FFDDBACC3F0h, 7FFDDBACC426h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0012h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0020h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0022h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0025h bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
002ah mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
002dh vmovss xmm0,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 10 04 24
0032h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[55]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xCA,0x41,0x2B,0xD0,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x89,0x04,0x24,0xC5,0xFA,0x10,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double range(double src, BitPos i0, BitPos i1)
; location: [7FFDDBACC440h, 7FFDDBACC47Ch]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0015h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
0018h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
001ah movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h bextr rax,rax,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RAX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 c0
002dh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0032h vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0038h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[61]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xCA,0x41,0x2B,0xD0,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xC0,0x48,0x89,0x44,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(byte src, int pos)
; location: [7FFDDBACC4A0h, 7FFDDBACC4C7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
001bh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xF7,0xD8,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(sbyte src, int pos)
; location: [7FFDDBACC4E0h, 7FFDDBACC50Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
001ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001fh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
002bh popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[48]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xF7,0xD8,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0x0F,0xB6,0xD2,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xC0,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(short src, int pos)
; location: [7FFDDBACC520h, 7FFDDBACC54Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
001ch movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001fh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0024h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0027h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
002bh popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[48]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xF7,0xD8,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xC0,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(ushort src, int pos)
; location: [7FFDDBACC560h, 7FFDDBACC587h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
001bh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0020h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0023h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xF7,0xD8,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(int src, int pos)
; location: [7FFDDBACC5A0h, 7FFDDBACC5C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
001dh popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xF7,0xD8,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(uint src, int pos)
; location: [7FFDDBACC5E0h, 7FFDDBACC601h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
001dh popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xF7,0xD8,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(long src, int pos)
; location: [7FFDDBACC620h, 7FFDDBACC642h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
001dh popcnt rax,rax                ; POPCNT(Popcnt_r64_rm64) [RAX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xF7,0xD8,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xF3,0x48,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(ulong src, int pos)
; location: [7FFDDBACC660h, 7FFDDBACC682h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
001dh popcnt rax,rax                ; POPCNT(Popcnt_r64_rm64) [RAX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xF7,0xD8,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xF3,0x48,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rev(byte src)
; location: [7FFDDBACC6A0h, 7FFDDBACC6D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov edx,80200802h             ; MOV(Mov_r32_imm32) [EDX,80200802h:imm32]             encoding(5 bytes) = ba 02 08 20 80
000dh imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
0011h mov rdx,884422110h            ; MOV(Mov_r64_imm64) [RDX,884422110h:imm64]            encoding(10 bytes) = 48 ba 10 21 42 84 08 00 00 00
001bh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
001eh mov rdx,101010101h            ; MOV(Mov_r64_imm64) [RDX,101010101h:imm64]            encoding(10 bytes) = 48 ba 01 01 01 01 01 00 00 00
0028h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
002ch shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0030h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xBA,0x02,0x08,0x20,0x80,0x48,0x0F,0xAF,0xC2,0x48,0xBA,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x48,0x23,0xC2,0x48,0xBA,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x48,0x0F,0xAF,0xC2,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rev(ushort src)
; location: [7FFDDBACC6F0h, 7FFDDBACC761h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h mov ecx,80200802h             ; MOV(Mov_r32_imm32) [ECX,80200802h:imm32]             encoding(5 bytes) = b9 02 08 20 80
0015h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0019h mov rcx,884422110h            ; MOV(Mov_r64_imm64) [RCX,884422110h:imm64]            encoding(10 bytes) = 48 b9 10 21 42 84 08 00 00 00
0023h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0026h mov rcx,101010101h            ; MOV(Mov_r64_imm64) [RCX,101010101h:imm64]            encoding(10 bytes) = 48 b9 01 01 01 01 01 00 00 00
0030h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0034h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0038h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003eh mov ecx,80200802h             ; MOV(Mov_r32_imm32) [ECX,80200802h:imm32]             encoding(5 bytes) = b9 02 08 20 80
0043h imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
0047h mov rcx,884422110h            ; MOV(Mov_r64_imm64) [RCX,884422110h:imm64]            encoding(10 bytes) = 48 b9 10 21 42 84 08 00 00 00
0051h and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0054h mov rcx,101010101h            ; MOV(Mov_r64_imm64) [RCX,101010101h:imm64]            encoding(10 bytes) = 48 b9 01 01 01 01 01 00 00 00
005eh imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
0062h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0066h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0069h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
006ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
006eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0071h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[114]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0xB9,0x02,0x08,0x20,0x80,0x48,0x0F,0xAF,0xD1,0x48,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x48,0x23,0xD1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0xB9,0x02,0x08,0x20,0x80,0x48,0x0F,0xAF,0xC1,0x48,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x48,0x23,0xC1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x48,0x0F,0xAF,0xC1,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rev(uint src)
; location: [7FFDDBACC780h, 7FFDDBACC86Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h shr eax,10h                   ; SHR(Shr_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 e8 10
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000fh sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h mov r8d,80200802h             ; MOV(Mov_r32_imm32) [R8D,80200802h:imm32]             encoding(6 bytes) = 41 b8 02 08 20 80
001bh imul rdx,r8                   ; IMUL(Imul_r64_rm64) [RDX,R8]                         encoding(4 bytes) = 49 0f af d0
001fh mov r8,884422110h             ; MOV(Mov_r64_imm64) [R8,884422110h:imm64]             encoding(10 bytes) = 49 b8 10 21 42 84 08 00 00 00
0029h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
002ch mov r8,101010101h             ; MOV(Mov_r64_imm64) [R8,101010101h:imm64]             encoding(10 bytes) = 49 b8 01 01 01 01 01 00 00 00
0036h imul rdx,r8                   ; IMUL(Imul_r64_rm64) [RDX,R8]                         encoding(4 bytes) = 49 0f af d0
003ah shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
003eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0041h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0044h mov r8d,80200802h             ; MOV(Mov_r32_imm32) [R8D,80200802h:imm32]             encoding(6 bytes) = 41 b8 02 08 20 80
004ah imul rax,r8                   ; IMUL(Imul_r64_rm64) [RAX,R8]                         encoding(4 bytes) = 49 0f af c0
004eh mov r8,884422110h             ; MOV(Mov_r64_imm64) [R8,884422110h:imm64]             encoding(10 bytes) = 49 b8 10 21 42 84 08 00 00 00
0058h and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
005bh mov r8,101010101h             ; MOV(Mov_r64_imm64) [R8,101010101h:imm64]             encoding(10 bytes) = 49 b8 01 01 01 01 01 00 00 00
0065h imul rax,r8                   ; IMUL(Imul_r64_rm64) [RAX,R8]                         encoding(4 bytes) = 49 0f af c0
0069h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
006dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0070h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0073h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0075h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0078h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
007bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
007dh sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
0080h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0083h mov r8d,80200802h             ; MOV(Mov_r32_imm32) [R8D,80200802h:imm32]             encoding(6 bytes) = 41 b8 02 08 20 80
0089h imul rcx,r8                   ; IMUL(Imul_r64_rm64) [RCX,R8]                         encoding(4 bytes) = 49 0f af c8
008dh mov r8,884422110h             ; MOV(Mov_r64_imm64) [R8,884422110h:imm64]             encoding(10 bytes) = 49 b8 10 21 42 84 08 00 00 00
0097h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
009ah mov r8,101010101h             ; MOV(Mov_r64_imm64) [R8,101010101h:imm64]             encoding(10 bytes) = 49 b8 01 01 01 01 01 00 00 00
00a4h imul rcx,r8                   ; IMUL(Imul_r64_rm64) [RCX,R8]                         encoding(4 bytes) = 49 0f af c8
00a8h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
00ach movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
00afh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00b2h mov r8d,80200802h             ; MOV(Mov_r32_imm32) [R8D,80200802h:imm32]             encoding(6 bytes) = 41 b8 02 08 20 80
00b8h imul rdx,r8                   ; IMUL(Imul_r64_rm64) [RDX,R8]                         encoding(4 bytes) = 49 0f af d0
00bch mov r8,884422110h             ; MOV(Mov_r64_imm64) [R8,884422110h:imm64]             encoding(10 bytes) = 49 b8 10 21 42 84 08 00 00 00
00c6h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
00c9h mov r8,101010101h             ; MOV(Mov_r64_imm64) [R8,101010101h:imm64]             encoding(10 bytes) = 49 b8 01 01 01 01 01 00 00 00
00d3h imul rdx,r8                   ; IMUL(Imul_r64_rm64) [RDX,R8]                         encoding(4 bytes) = 49 0f af d0
00d7h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
00dbh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00deh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
00e1h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
00e3h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
00e6h shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
00e9h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00ebh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[236]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xE8,0x10,0x0F,0xB7,0xC0,0x8B,0xD0,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0x41,0xB8,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xD0,0x49,0xB8,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xD0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xD0,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x41,0xB8,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xC0,0x49,0xB8,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xC0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xC0,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0x8B,0xCA,0xC1,0xF9,0x08,0x0F,0xB6,0xC9,0x41,0xB8,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xC8,0x49,0xB8,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xC8,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xC8,0x48,0xC1,0xE9,0x20,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0x41,0xB8,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xD0,0x49,0xB8,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xD0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xD0,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC1,0xE2,0x10,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rev2(uint x)
; location: [7FFDDBACC880h, 7FFDDBACC8DCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,0AAAAAAAAh            ; AND(And_EAX_imm32) [EAX,aaaaaaaah:imm32]             encoding(5 bytes) = 25 aa aa aa aa
000ch shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
000eh and ecx,55555555h             ; AND(And_rm32_imm32) [ECX,55555555h:imm32]            encoding(6 bytes) = 81 e1 55 55 55 55
0014h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0016h or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
0018h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
001ah and eax,0CCCCCCCCh            ; AND(And_EAX_imm32) [EAX,cccccccch:imm32]             encoding(5 bytes) = 25 cc cc cc cc
001fh shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
0022h and ecx,33333333h             ; AND(And_rm32_imm32) [ECX,33333333h:imm32]            encoding(6 bytes) = 81 e1 33 33 33 33
0028h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
002bh or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
002dh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002fh and eax,0F0F0F0F0h            ; AND(And_EAX_imm32) [EAX,f0f0f0f0h:imm32]             encoding(5 bytes) = 25 f0 f0 f0 f0
0034h shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0037h and ecx,0F0F0F0Fh             ; AND(And_rm32_imm32) [ECX,f0f0f0fh:imm32]             encoding(6 bytes) = 81 e1 0f 0f 0f 0f
003dh shl ecx,4                     ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e1 04
0040h or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
0042h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0044h and eax,0FF00FF00h            ; AND(And_EAX_imm32) [EAX,ff00ff00h:imm32]             encoding(5 bytes) = 25 00 ff 00 ff
0049h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
004ch and ecx,0FF00FFh              ; AND(And_rm32_imm32) [ECX,ff00ffh:imm32]              encoding(6 bytes) = 81 e1 ff 00 ff 00
0052h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0055h or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
0057h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0059h rol eax,10h                   ; ROL(Rol_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 c0 10
005ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rev2Bytes => new byte[93]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0xAA,0xAA,0xAA,0xAA,0xD1,0xE8,0x81,0xE1,0x55,0x55,0x55,0x55,0xD1,0xE1,0x0B,0xC8,0x8B,0xC1,0x25,0xCC,0xCC,0xCC,0xCC,0xC1,0xE8,0x02,0x81,0xE1,0x33,0x33,0x33,0x33,0xC1,0xE1,0x02,0x0B,0xC8,0x8B,0xC1,0x25,0xF0,0xF0,0xF0,0xF0,0xC1,0xE8,0x04,0x81,0xE1,0x0F,0x0F,0x0F,0x0F,0xC1,0xE1,0x04,0x0B,0xC8,0x8B,0xC1,0x25,0x00,0xFF,0x00,0xFF,0xC1,0xE8,0x08,0x81,0xE1,0xFF,0x00,0xFF,0x00,0xC1,0xE1,0x08,0x0B,0xC8,0x8B,0xC1,0xC1,0xC0,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rev(ulong src)
; location: [7FFDDBACC8F0h, 7FFDDBACCAE7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0011h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0014h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0017h sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0025h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
0029h mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0033h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
0036h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
0040h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
0044h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
0048h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
004ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
004fh mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0055h imul rdx,r9                   ; IMUL(Imul_r64_rm64) [RDX,R9]                         encoding(4 bytes) = 49 0f af d1
0059h mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0063h and rdx,r9                    ; AND(And_r64_rm64) [RDX,R9]                           encoding(3 bytes) = 49 23 d1
0066h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
0070h imul rdx,r9                   ; IMUL(Imul_r64_rm64) [RDX,R9]                         encoding(4 bytes) = 49 0f af d1
0074h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0078h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
007bh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
007eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0081h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0084h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0087h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
008ah sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
008eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0092h mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0098h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
009ch mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
00a6h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
00a9h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
00b3h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
00b7h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
00bbh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
00bfh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00c2h mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
00c8h imul rax,r9                   ; IMUL(Imul_r64_rm64) [RAX,R9]                         encoding(4 bytes) = 49 0f af c1
00cch mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
00d6h and rax,r9                    ; AND(And_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 23 c1
00d9h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
00e3h imul rax,r9                   ; IMUL(Imul_r64_rm64) [RAX,R9]                         encoding(4 bytes) = 49 0f af c1
00e7h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
00ebh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00eeh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
00f1h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
00f4h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00f7h shl eax,10h                   ; SHL(Shl_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 e0 10
00fah or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00fch mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
00feh shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0101h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0104h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0107h sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
010bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
010fh mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0115h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
0119h mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0123h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
0126h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
0130h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
0134h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
0138h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
013ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
013fh mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0145h imul rdx,r9                   ; IMUL(Imul_r64_rm64) [RDX,R9]                         encoding(4 bytes) = 49 0f af d1
0149h mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0153h and rdx,r9                    ; AND(And_r64_rm64) [RDX,R9]                           encoding(3 bytes) = 49 23 d1
0156h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
0160h imul rdx,r9                   ; IMUL(Imul_r64_rm64) [RDX,R9]                         encoding(4 bytes) = 49 0f af d1
0164h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0168h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
016bh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
016eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0171h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0174h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0177h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
017ah sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
017eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0182h mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0188h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
018ch mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0196h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
0199h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
01a3h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
01a7h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
01abh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
01afh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
01b2h mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
01b8h imul rcx,r9                   ; IMUL(Imul_r64_rm64) [RCX,R9]                         encoding(4 bytes) = 49 0f af c9
01bch mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
01c6h and rcx,r9                    ; AND(And_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 23 c9
01c9h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
01d3h imul rcx,r9                   ; IMUL(Imul_r64_rm64) [RCX,R9]                         encoding(4 bytes) = 49 0f af c9
01d7h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
01dbh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
01deh shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
01e1h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
01e4h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
01e7h shl ecx,10h                   ; SHL(Shl_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e1 10
01eah or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
01ech mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
01eeh mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
01f0h shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
01f4h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
01f7h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[504]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x20,0x8B,0xD0,0xC1,0xEA,0x10,0x0F,0xB7,0xD2,0x44,0x8B,0xC2,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x4D,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x4D,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x4D,0x0F,0xAF,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x41,0xB9,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xD1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xD1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xD1,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x44,0x8B,0xC0,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x4D,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x4D,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x4D,0x0F,0xAF,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xC1,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC1,0xE0,0x10,0x0B,0xC2,0x8B,0xD1,0xC1,0xEA,0x10,0x0F,0xB7,0xD2,0x44,0x8B,0xC2,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x4D,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x4D,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x4D,0x0F,0xAF,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x41,0xB9,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xD1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xD1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xD1,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x0F,0xB7,0xC9,0x44,0x8B,0xC1,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x4D,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x4D,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x4D,0x0F,0xAF,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xC9,0x41,0xB9,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xC9,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xC9,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xC9,0x48,0xC1,0xE9,0x20,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x41,0x0B,0xC8,0x0F,0xB7,0xC9,0xC1,0xE1,0x10,0x0B,0xD1,0x8B,0xC0,0x8B,0xD2,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotl(byte src, byte offset)
; location: [7FFDDBACCB00h, 7FFDDBACCB22h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0017h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
001ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
001ch or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotl(ushort src, ushort offset)
; location: [7FFDDBACCB40h, 7FFDDBACCB62h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0017h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
001ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
001ch or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x10,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotl(uint src, uint offset)
; location: [7FFDDBACCB80h, 7FFDDBACCB8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotl(ulong src, ulong offset)
; location: [7FFDDBACCBA0h, 7FFDDBACCBADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah rol rax,cl                    ; ROL(Rol_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotl(byte src, int offset)
; location: [7FFDDBACCBC0h, 7FFDDBACCBDFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0017h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotl(ushort src, int offset)
; location: [7FFDDBACCBF0h, 7FFDDBACCC0Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
0017h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x10,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotl(uint src, int offset)
; location: [7FFDDBACCC20h, 7FFDDBACCC2Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotl(ulong src, int offset)
; location: [7FFDDBACCC40h, 7FFDDBACCC4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah rol rax,cl                    ; ROL(Rol_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr(byte src, byte offset)
; location: [7FFDDBACCC60h, 7FFDDBACCC82h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0010h sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0017h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
001ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
001ch or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr(byte src, int offset)
; location: [7FFDDBACCCA0h, 7FFDDBACCCBFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0017h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotr(ushort src, ushort offset)
; location: [7FFDDBACCCD0h, 7FFDDBACCCF2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0010h sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0017h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
001ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
001ch or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x10,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotr(ushort src, int offset)
; location: [7FFDDBACCD10h, 7FFDDBACCD2Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
0017h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x10,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotr(uint src, uint offset)
; location: [7FFDDBACCD40h, 7FFDDBACCD4Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotr(uint src, int offset)
; location: [7FFDDBACCD60h, 7FFDDBACCD6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotr(ulong src, ulong offset)
; location: [7FFDDBACCD80h, 7FFDDBACCD8Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah ror rax,cl                    ; ROR(Ror_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotr(ulong src, int offset)
; location: [7FFDDBACCDA0h, 7FFDDBACCDADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah ror rax,cl                    ; ROR(Ror_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte scatter(sbyte src, sbyte mask)
; location: [7FFDDBACCDC0h, 7FFDDBACCDDFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000ch movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xD2,0x0F,0xB6,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte scatter(byte src, byte mask)
; location: [7FFDDBACCDF0h, 7FFDDBACCE03h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short scatter(short src, short mask)
; location: [7FFDDBACCE20h, 7FFDDBACCE3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
0010h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0013h pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD2,0x0F,0xB7,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort scatter(ushort src, ushort mask)
; location: [7FFDDBACCE50h, 7FFDDBACCE63h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int scatter(int src, int mask)
; location: [7FFDDBACCE80h, 7FFDDBACCE8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint scatter(uint src, uint mask)
; location: [7FFDDBACCEA0h, 7FFDDBACCEAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long scatter(long src, long mask)
; location: [7FFDDBACCEC0h, 7FFDDBACCECAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong scatter(ulong src, ulong mask)
; location: [7FFDDBACCEE0h, 7FFDDBACCEEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte segment(sbyte src, int i0, int i1)
; location: [7FFDDBACCF00h, 7FFDDBACCF24h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
001bh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0020h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte segment(byte src, int i0, int i1)
; location: [7FFDDBACCF40h, 7FFDDBACCF62h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
001ah bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector128 clmul_ref(BitVector64 x, BitVector64 y)
; location: [7FFDDBACCF80h, 7FFDDBACD3F0h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,60h                   ; SUB(Sub_rm64_imm8) [RSP,60h:imm64]                   encoding(4 bytes) = 48 83 ec 60
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+50h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 50
000eh mov [rsp+58h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 58
0013h mov [rsp+40h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 40
0018h mov [rsp+48h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 48
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0022h mov [rsp+50h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 50
0027h mov [rsp+58h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 58
002ch mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
0031h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
0036h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0039h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
003bh mov [rsp+38h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 38
003fh lea rcx,[rsp+38h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 38
0044h test dl,1                     ; TEST(Test_rm8_imm8) [DL,1h:imm8]                     encoding(3 bytes) = f6 c2 01
0047h jne short 004eh               ; JNE(Jne_rel8_64) [4Eh:jmp64]                         encoding(2 bytes) = 75 05
0049h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
004ch jmp short 0054h               ; JMP(Jmp_rel8_64) [54h:jmp64]                         encoding(2 bytes) = eb 06
004eh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0054h mov [rcx],r10d                ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R10D]       encoding(3 bytes) = 44 89 11
0057h mov ecx,[rsp+38h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 38
005bh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
005eh mov [rsp+30h],r10d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(5 bytes) = 44 89 54 24 30
0063h lea r10,[rsp+30h]             ; LEA(Lea_r64_m) [R10,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 4c 8d 54 24 30
0068h bt r8,r9                      ; BT(Bt_rm64_r64) [R8,R9]                              encoding(4 bytes) = 4d 0f a3 c8
006ch jb short 0073h                ; JB(Jb_rel8_64) [73h:jmp64]                           encoding(2 bytes) = 72 05
006eh xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0071h jmp short 0079h               ; JMP(Jmp_rel8_64) [79h:jmp64]                         encoding(2 bytes) = eb 06
0073h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
0079h mov [r10],r11d                ; MOV(Mov_rm32_r32) [mem(32u,R10:br,DS:sr),R11D]       encoding(3 bytes) = 45 89 1a
007ch mov r10d,[rsp+30h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(5 bytes) = 44 8b 54 24 30
0081h and ecx,r10d                  ; AND(And_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 23 ca
0084h cmp r9d,40h                   ; CMP(Cmp_rm32_imm8) [R9D,40h:imm32]                   encoding(4 bytes) = 41 83 f9 40
0088h jge short 00d6h               ; JGE(Jge_rel8_64) [D6h:jmp64]                         encoding(2 bytes) = 7d 4c
008ah movzx r10d,r9b                ; MOVZX(Movzx_r32_rm8) [R10D,R9L]                      encoding(4 bytes) = 45 0f b6 d1
008eh cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0091h jne short 00aeh               ; JNE(Jne_rel8_64) [AEh:jmp64]                         encoding(2 bytes) = 75 1b
0093h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
0099h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
009ch shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
009fh mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
00a2h or rcx,[rsp+40h]              ; OR(Or_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 4c 24 40
00a7h mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
00ach jmp short 00cah               ; JMP(Jmp_rel8_64) [CAh:jmp64]                         encoding(2 bytes) = eb 1c
00aeh mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
00b4h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
00b7h shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
00bah mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
00bdh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
00c0h and rcx,[rsp+40h]             ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 4c 24 40
00c5h mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
00cah mov rcx,[rsp+40h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 40
00cfh mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
00d4h jmp short 0120h               ; JMP(Jmp_rel8_64) [120h:jmp64]                        encoding(2 bytes) = eb 4a
00d6h movzx r10d,r9b                ; MOVZX(Movzx_r32_rm8) [R10D,R9L]                      encoding(4 bytes) = 45 0f b6 d1
00dah cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
00ddh jne short 00fah               ; JNE(Jne_rel8_64) [FAh:jmp64]                         encoding(2 bytes) = 75 1b
00dfh mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
00e5h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
00e8h shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
00ebh mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
00eeh or rcx,[rsp+48h]              ; OR(Or_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 4c 24 48
00f3h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
00f8h jmp short 0116h               ; JMP(Jmp_rel8_64) [116h:jmp64]                        encoding(2 bytes) = eb 1c
00fah mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
0100h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0103h shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
0106h mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
0109h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
010ch and rcx,[rsp+48h]             ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 4c 24 48
0111h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
0116h mov rcx,[rsp+48h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 48
011bh mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
0120h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0126h cmp r9d,1                     ; CMP(Cmp_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 f9 01
012ah jl near ptr 01f2h             ; JL(Jl_rel32_64) [1F2h:jmp64]                         encoding(6 bytes) = 0f 8c c2 00 00 00
0130h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0132h mov [rsp+28h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 28
0136h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
013bh bt rdx,r10                    ; BT(Bt_rm64_r64) [RDX,R10]                            encoding(4 bytes) = 4c 0f a3 d2
013fh jb short 0145h                ; JB(Jb_rel8_64) [145h:jmp64]                          encoding(2 bytes) = 72 04
0141h xor esi,esi                   ; XOR(Xor_r32_rm32) [ESI,ESI]                          encoding(2 bytes) = 33 f6
0143h jmp short 014ah               ; JMP(Jmp_rel8_64) [14Ah:jmp64]                        encoding(2 bytes) = eb 05
0145h mov esi,1                     ; MOV(Mov_r32_imm32) [ESI,1h:imm32]                    encoding(5 bytes) = be 01 00 00 00
014ah mov [rcx],esi                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),ESI]        encoding(2 bytes) = 89 31
014ch mov esi,[rsp+28h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 74 24 28
0150h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0152h mov [rsp+20h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 20
0156h lea rdi,[rsp+20h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 7c 24 20
015bh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
015eh sub ecx,r10d                  ; SUB(Sub_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 2b ca
0161h mov ebx,1                     ; MOV(Mov_r32_imm32) [EBX,1h:imm32]                    encoding(5 bytes) = bb 01 00 00 00
0166h shl rbx,cl                    ; SHL(Shl_rm64_CL) [RBX,CL]                            encoding(3 bytes) = 48 d3 e3
0169h test rbx,r8                   ; TEST(Test_rm64_r64) [R8,RBX]                         encoding(3 bytes) = 49 85 d8
016ch jne short 0172h               ; JNE(Jne_rel8_64) [172h:jmp64]                        encoding(2 bytes) = 75 04
016eh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0170h jmp short 0177h               ; JMP(Jmp_rel8_64) [177h:jmp64]                        encoding(2 bytes) = eb 05
0172h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0177h mov [rdi],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,DS:sr),ECX]        encoding(2 bytes) = 89 0f
0179h mov ecx,[rsp+20h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 20
017dh and ecx,esi                   ; AND(And_r32_rm32) [ECX,ESI]                          encoding(2 bytes) = 23 ce
017fh xor ecx,0                     ; XOR(Xor_rm32_imm8) [ECX,0h:imm32]                    encoding(3 bytes) = 83 f1 00
0182h cmp r9d,40h                   ; CMP(Cmp_rm32_imm8) [R9D,40h:imm32]                   encoding(4 bytes) = 41 83 f9 40
0186h jge short 01b8h               ; JGE(Jge_rel8_64) [1B8h:jmp64]                        encoding(2 bytes) = 7d 30
0188h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
018bh jne short 019ch               ; JNE(Jne_rel8_64) [19Ch:jmp64]                        encoding(2 bytes) = 75 0f
018dh mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
0190h or rcx,[rsp+40h]              ; OR(Or_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 4c 24 40
0195h mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
019ah jmp short 01ach               ; JMP(Jmp_rel8_64) [1ACh:jmp64]                        encoding(2 bytes) = eb 10
019ch mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
019fh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
01a2h and rcx,[rsp+40h]             ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 4c 24 40
01a7h mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
01ach mov rcx,[rsp+40h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 40
01b1h mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
01b6h jmp short 01e6h               ; JMP(Jmp_rel8_64) [1E6h:jmp64]                        encoding(2 bytes) = eb 2e
01b8h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
01bbh jne short 01cch               ; JNE(Jne_rel8_64) [1CCh:jmp64]                        encoding(2 bytes) = 75 0f
01bdh mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
01c0h or rcx,[rsp+48h]              ; OR(Or_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 4c 24 48
01c5h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
01cah jmp short 01dch               ; JMP(Jmp_rel8_64) [1DCh:jmp64]                        encoding(2 bytes) = eb 10
01cch mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
01cfh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
01d2h and rcx,[rsp+48h]             ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 4c 24 48
01d7h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
01dch mov rcx,[rsp+48h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 48
01e1h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
01e6h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
01e9h cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
01ech jle near ptr 0130h            ; JLE(Jle_rel32_64) [130h:jmp64]                       encoding(6 bytes) = 0f 8e 3e ff ff ff
01f2h cmp r9d,40h                   ; CMP(Cmp_rm32_imm8) [R9D,40h:imm32]                   encoding(4 bytes) = 41 83 f9 40
01f6h jge short 0214h               ; JGE(Jge_rel8_64) [214h:jmp64]                        encoding(2 bytes) = 7d 1c
01f8h mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
01fbh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
01feh and rcx,[rsp+50h]             ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 4c 24 50
0203h mov [rsp+50h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 50
0208h mov rcx,[rsp+50h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 50
020dh mov [rsp+50h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 50
0212h jmp short 022eh               ; JMP(Jmp_rel8_64) [22Eh:jmp64]                        encoding(2 bytes) = eb 1a
0214h mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
0217h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
021ah and rcx,[rsp+58h]             ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 4c 24 58
021fh mov [rsp+58h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 58
0224h mov rcx,[rsp+58h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 58
0229h mov [rsp+58h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 58
022eh inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0231h cmp r9d,40h                   ; CMP(Cmp_rm32_imm8) [R9D,40h:imm32]                   encoding(4 bytes) = 41 83 f9 40
0235h jl near ptr 0039h             ; JL(Jl_rel32_64) [39h:jmp64]                          encoding(6 bytes) = 0f 8c fe fd ff ff
023bh mov r9d,40h                   ; MOV(Mov_r32_imm32) [R9D,40h:imm32]                   encoding(6 bytes) = 41 b9 40 00 00 00
0241h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0243h mov [rsp+18h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 18
0247h lea rcx,[rsp+18h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 18
024ch xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
024fh mov [rcx],r10d                ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R10D]       encoding(3 bytes) = 44 89 11
0252h mov ecx,[rsp+18h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 18
0256h cmp r9d,40h                   ; CMP(Cmp_rm32_imm8) [R9D,40h:imm32]                   encoding(4 bytes) = 41 83 f9 40
025ah jge short 02a8h               ; JGE(Jge_rel8_64) [2A8h:jmp64]                        encoding(2 bytes) = 7d 4c
025ch movzx r10d,r9b                ; MOVZX(Movzx_r32_rm8) [R10D,R9L]                      encoding(4 bytes) = 45 0f b6 d1
0260h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0263h jne short 0280h               ; JNE(Jne_rel8_64) [280h:jmp64]                        encoding(2 bytes) = 75 1b
0265h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
026bh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
026eh shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
0271h mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
0274h or rcx,[rsp+40h]              ; OR(Or_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 4c 24 40
0279h mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
027eh jmp short 029ch               ; JMP(Jmp_rel8_64) [29Ch:jmp64]                        encoding(2 bytes) = eb 1c
0280h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
0286h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0289h shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
028ch mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
028fh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0292h and rcx,[rsp+40h]             ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 4c 24 40
0297h mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
029ch mov rcx,[rsp+40h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 40
02a1h mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
02a6h jmp short 02f2h               ; JMP(Jmp_rel8_64) [2F2h:jmp64]                        encoding(2 bytes) = eb 4a
02a8h movzx r10d,r9b                ; MOVZX(Movzx_r32_rm8) [R10D,R9L]                      encoding(4 bytes) = 45 0f b6 d1
02ach cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
02afh jne short 02cch               ; JNE(Jne_rel8_64) [2CCh:jmp64]                        encoding(2 bytes) = 75 1b
02b1h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
02b7h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
02bah shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
02bdh mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
02c0h or rcx,[rsp+48h]              ; OR(Or_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 4c 24 48
02c5h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
02cah jmp short 02e8h               ; JMP(Jmp_rel8_64) [2E8h:jmp64]                        encoding(2 bytes) = eb 1c
02cch mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
02d2h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
02d5h shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
02d8h mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
02dbh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
02deh and rcx,[rsp+48h]             ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 4c 24 48
02e3h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
02e8h mov rcx,[rsp+48h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 48
02edh mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
02f2h lea r10d,[r9-3Fh]             ; LEA(Lea_r32_m) [R10D,mem(Unknown,R9:br,DS:sr)]       encoding(4 bytes) = 45 8d 51 c1
02f6h cmp r10d,40h                  ; CMP(Cmp_rm32_imm8) [R10D,40h:imm32]                  encoding(4 bytes) = 41 83 fa 40
02fah jge near ptr 03c3h            ; JGE(Jge_rel32_64) [3C3h:jmp64]                       encoding(6 bytes) = 0f 8d c3 00 00 00
0300h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0302h mov [rsp+10h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 10
0306h lea rcx,[rsp+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 10
030bh bt rdx,r10                    ; BT(Bt_rm64_r64) [RDX,R10]                            encoding(4 bytes) = 4c 0f a3 d2
030fh jb short 0315h                ; JB(Jb_rel8_64) [315h:jmp64]                          encoding(2 bytes) = 72 04
0311h xor esi,esi                   ; XOR(Xor_r32_rm32) [ESI,ESI]                          encoding(2 bytes) = 33 f6
0313h jmp short 031ah               ; JMP(Jmp_rel8_64) [31Ah:jmp64]                        encoding(2 bytes) = eb 05
0315h mov esi,1                     ; MOV(Mov_r32_imm32) [ESI,1h:imm32]                    encoding(5 bytes) = be 01 00 00 00
031ah mov [rcx],esi                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),ESI]        encoding(2 bytes) = 89 31
031ch mov esi,[rsp+10h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 74 24 10
0320h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0322h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0326h lea rdi,[rsp+8]               ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 7c 24 08
032bh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
032eh sub ecx,r10d                  ; SUB(Sub_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 2b ca
0331h mov ebx,1                     ; MOV(Mov_r32_imm32) [EBX,1h:imm32]                    encoding(5 bytes) = bb 01 00 00 00
0336h shl rbx,cl                    ; SHL(Shl_rm64_CL) [RBX,CL]                            encoding(3 bytes) = 48 d3 e3
0339h test rbx,r8                   ; TEST(Test_rm64_r64) [R8,RBX]                         encoding(3 bytes) = 49 85 d8
033ch jne short 0342h               ; JNE(Jne_rel8_64) [342h:jmp64]                        encoding(2 bytes) = 75 04
033eh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0340h jmp short 0347h               ; JMP(Jmp_rel8_64) [347h:jmp64]                        encoding(2 bytes) = eb 05
0342h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0347h mov [rdi],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,DS:sr),ECX]        encoding(2 bytes) = 89 0f
0349h mov ecx,[rsp+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 08
034dh and ecx,esi                   ; AND(And_r32_rm32) [ECX,ESI]                          encoding(2 bytes) = 23 ce
034fh xor ecx,0                     ; XOR(Xor_rm32_imm8) [ECX,0h:imm32]                    encoding(3 bytes) = 83 f1 00
0352h cmp r9d,40h                   ; CMP(Cmp_rm32_imm8) [R9D,40h:imm32]                   encoding(4 bytes) = 41 83 f9 40
0356h jge short 0388h               ; JGE(Jge_rel8_64) [388h:jmp64]                        encoding(2 bytes) = 7d 30
0358h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
035bh jne short 036ch               ; JNE(Jne_rel8_64) [36Ch:jmp64]                        encoding(2 bytes) = 75 0f
035dh mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
0360h or rcx,[rsp+40h]              ; OR(Or_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 4c 24 40
0365h mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
036ah jmp short 037ch               ; JMP(Jmp_rel8_64) [37Ch:jmp64]                        encoding(2 bytes) = eb 10
036ch mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
036fh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0372h and rcx,[rsp+40h]             ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 4c 24 40
0377h mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
037ch mov rcx,[rsp+40h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 40
0381h mov [rsp+40h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 40
0386h jmp short 03b6h               ; JMP(Jmp_rel8_64) [3B6h:jmp64]                        encoding(2 bytes) = eb 2e
0388h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
038bh jne short 039ch               ; JNE(Jne_rel8_64) [39Ch:jmp64]                        encoding(2 bytes) = 75 0f
038dh mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
0390h or rcx,[rsp+48h]              ; OR(Or_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 4c 24 48
0395h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
039ah jmp short 03ach               ; JMP(Jmp_rel8_64) [3ACh:jmp64]                        encoding(2 bytes) = eb 10
039ch mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
039fh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
03a2h and rcx,[rsp+48h]             ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 4c 24 48
03a7h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
03ach mov rcx,[rsp+48h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 48
03b1h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
03b6h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
03b9h cmp r10d,40h                  ; CMP(Cmp_rm32_imm8) [R10D,40h:imm32]                  encoding(4 bytes) = 41 83 fa 40
03bdh jl near ptr 0300h             ; JL(Jl_rel32_64) [300h:jmp64]                         encoding(6 bytes) = 0f 8c 3d ff ff ff
03c3h cmp r9d,40h                   ; CMP(Cmp_rm32_imm8) [R9D,40h:imm32]                   encoding(4 bytes) = 41 83 f9 40
03c7h jge short 03e5h               ; JGE(Jge_rel8_64) [3E5h:jmp64]                        encoding(2 bytes) = 7d 1c
03c9h mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
03cch not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
03cfh and rcx,[rsp+50h]             ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 4c 24 50
03d4h mov [rsp+50h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 50
03d9h mov rcx,[rsp+50h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 50
03deh mov [rsp+50h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 50
03e3h jmp short 03ffh               ; JMP(Jmp_rel8_64) [3FFh:jmp64]                        encoding(2 bytes) = eb 1a
03e5h mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
03e8h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
03ebh and rcx,[rsp+58h]             ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 4c 24 58
03f0h mov [rsp+58h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 58
03f5h mov rcx,[rsp+58h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 58
03fah mov [rsp+58h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 58
03ffh inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0402h cmp r9d,80h                   ; CMP(Cmp_rm32_imm32) [R9D,80h:imm32]                  encoding(7 bytes) = 41 81 f9 80 00 00 00
0409h jl near ptr 0241h             ; JL(Jl_rel32_64) [241h:jmp64]                         encoding(6 bytes) = 0f 8c 32 fe ff ff
040fh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0411h mov [rsp],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(3 bytes) = 89 14 24
0414h lea rdx,[rsp]                 ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 14 24
0418h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
041ah mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
041ch mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
041fh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0422h jne short 043ah               ; JNE(Jne_rel8_64) [43Ah:jmp64]                        encoding(2 bytes) = 75 16
0424h mov rdx,8000000000000000h     ; MOV(Mov_r64_imm64) [RDX,8000000000000000h:imm64]     encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 80
042eh or rdx,[rsp+58h]              ; OR(Or_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 54 24 58
0433h mov [rsp+58h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 58
0438h jmp short 044eh               ; JMP(Jmp_rel8_64) [44Eh:jmp64]                        encoding(2 bytes) = eb 14
043ah mov rdx,7FFFFFFFFFFFFFFFh     ; MOV(Mov_r64_imm64) [RDX,7fffffffffffffffh:imm64]     encoding(10 bytes) = 48 ba ff ff ff ff ff ff ff 7f
0444h and rdx,[rsp+58h]             ; AND(And_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 54 24 58
0449h mov [rsp+58h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 58
044eh mov rdx,[rsp+58h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 58
0453h mov [rsp+58h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 58
0458h mov rdx,[rsp+50h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 50
045dh mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0460h mov rdx,[rsp+58h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 58
0465h mov [rax+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(4 bytes) = 48 89 50 08
0469h add rsp,60h                   ; ADD(Add_rm64_imm8) [RSP,60h:imm64]                   encoding(4 bytes) = 48 83 c4 60
046dh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
046eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
046fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0470h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clmul_refBytes => new byte[1137]{0x57,0x56,0x53,0x48,0x83,0xEC,0x60,0x33,0xC0,0x48,0x89,0x44,0x24,0x50,0x48,0x89,0x44,0x24,0x58,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x48,0x48,0x8B,0xC1,0x33,0xC9,0x48,0x89,0x4C,0x24,0x50,0x48,0x89,0x4C,0x24,0x58,0x48,0x89,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x48,0x45,0x33,0xC9,0x33,0xC9,0x89,0x4C,0x24,0x38,0x48,0x8D,0x4C,0x24,0x38,0xF6,0xC2,0x01,0x75,0x05,0x45,0x33,0xD2,0xEB,0x06,0x41,0xBA,0x01,0x00,0x00,0x00,0x44,0x89,0x11,0x8B,0x4C,0x24,0x38,0x45,0x33,0xD2,0x44,0x89,0x54,0x24,0x30,0x4C,0x8D,0x54,0x24,0x30,0x4D,0x0F,0xA3,0xC8,0x72,0x05,0x45,0x33,0xDB,0xEB,0x06,0x41,0xBB,0x01,0x00,0x00,0x00,0x45,0x89,0x1A,0x44,0x8B,0x54,0x24,0x30,0x41,0x23,0xCA,0x41,0x83,0xF9,0x40,0x7D,0x4C,0x45,0x0F,0xB6,0xD1,0x83,0xF9,0x01,0x75,0x1B,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x49,0x8B,0xCB,0x48,0x0B,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x40,0xEB,0x1C,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x48,0x23,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x40,0x48,0x8B,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x40,0xEB,0x4A,0x45,0x0F,0xB6,0xD1,0x83,0xF9,0x01,0x75,0x1B,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x49,0x8B,0xCB,0x48,0x0B,0x4C,0x24,0x48,0x48,0x89,0x4C,0x24,0x48,0xEB,0x1C,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x48,0x23,0x4C,0x24,0x48,0x48,0x89,0x4C,0x24,0x48,0x48,0x8B,0x4C,0x24,0x48,0x48,0x89,0x4C,0x24,0x48,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xF9,0x01,0x0F,0x8C,0xC2,0x00,0x00,0x00,0x33,0xC9,0x89,0x4C,0x24,0x28,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x0F,0xA3,0xD2,0x72,0x04,0x33,0xF6,0xEB,0x05,0xBE,0x01,0x00,0x00,0x00,0x89,0x31,0x8B,0x74,0x24,0x28,0x33,0xC9,0x89,0x4C,0x24,0x20,0x48,0x8D,0x7C,0x24,0x20,0x41,0x8B,0xC9,0x41,0x2B,0xCA,0xBB,0x01,0x00,0x00,0x00,0x48,0xD3,0xE3,0x49,0x85,0xD8,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x89,0x0F,0x8B,0x4C,0x24,0x20,0x23,0xCE,0x83,0xF1,0x00,0x41,0x83,0xF9,0x40,0x7D,0x30,0x83,0xF9,0x01,0x75,0x0F,0x49,0x8B,0xCB,0x48,0x0B,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x40,0xEB,0x10,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x48,0x23,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x40,0x48,0x8B,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x40,0xEB,0x2E,0x83,0xF9,0x01,0x75,0x0F,0x49,0x8B,0xCB,0x48,0x0B,0x4C,0x24,0x48,0x48,0x89,0x4C,0x24,0x48,0xEB,0x10,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x48,0x23,0x4C,0x24,0x48,0x48,0x89,0x4C,0x24,0x48,0x48,0x8B,0x4C,0x24,0x48,0x48,0x89,0x4C,0x24,0x48,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x0F,0x8E,0x3E,0xFF,0xFF,0xFF,0x41,0x83,0xF9,0x40,0x7D,0x1C,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x48,0x23,0x4C,0x24,0x50,0x48,0x89,0x4C,0x24,0x50,0x48,0x8B,0x4C,0x24,0x50,0x48,0x89,0x4C,0x24,0x50,0xEB,0x1A,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x48,0x23,0x4C,0x24,0x58,0x48,0x89,0x4C,0x24,0x58,0x48,0x8B,0x4C,0x24,0x58,0x48,0x89,0x4C,0x24,0x58,0x41,0xFF,0xC1,0x41,0x83,0xF9,0x40,0x0F,0x8C,0xFE,0xFD,0xFF,0xFF,0x41,0xB9,0x40,0x00,0x00,0x00,0x33,0xC9,0x89,0x4C,0x24,0x18,0x48,0x8D,0x4C,0x24,0x18,0x45,0x33,0xD2,0x44,0x89,0x11,0x8B,0x4C,0x24,0x18,0x41,0x83,0xF9,0x40,0x7D,0x4C,0x45,0x0F,0xB6,0xD1,0x83,0xF9,0x01,0x75,0x1B,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x49,0x8B,0xCB,0x48,0x0B,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x40,0xEB,0x1C,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x48,0x23,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x40,0x48,0x8B,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x40,0xEB,0x4A,0x45,0x0F,0xB6,0xD1,0x83,0xF9,0x01,0x75,0x1B,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x49,0x8B,0xCB,0x48,0x0B,0x4C,0x24,0x48,0x48,0x89,0x4C,0x24,0x48,0xEB,0x1C,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x48,0x23,0x4C,0x24,0x48,0x48,0x89,0x4C,0x24,0x48,0x48,0x8B,0x4C,0x24,0x48,0x48,0x89,0x4C,0x24,0x48,0x45,0x8D,0x51,0xC1,0x41,0x83,0xFA,0x40,0x0F,0x8D,0xC3,0x00,0x00,0x00,0x33,0xC9,0x89,0x4C,0x24,0x10,0x48,0x8D,0x4C,0x24,0x10,0x4C,0x0F,0xA3,0xD2,0x72,0x04,0x33,0xF6,0xEB,0x05,0xBE,0x01,0x00,0x00,0x00,0x89,0x31,0x8B,0x74,0x24,0x10,0x33,0xC9,0x89,0x4C,0x24,0x08,0x48,0x8D,0x7C,0x24,0x08,0x41,0x8B,0xC9,0x41,0x2B,0xCA,0xBB,0x01,0x00,0x00,0x00,0x48,0xD3,0xE3,0x49,0x85,0xD8,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x89,0x0F,0x8B,0x4C,0x24,0x08,0x23,0xCE,0x83,0xF1,0x00,0x41,0x83,0xF9,0x40,0x7D,0x30,0x83,0xF9,0x01,0x75,0x0F,0x49,0x8B,0xCB,0x48,0x0B,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x40,0xEB,0x10,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x48,0x23,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x40,0x48,0x8B,0x4C,0x24,0x40,0x48,0x89,0x4C,0x24,0x40,0xEB,0x2E,0x83,0xF9,0x01,0x75,0x0F,0x49,0x8B,0xCB,0x48,0x0B,0x4C,0x24,0x48,0x48,0x89,0x4C,0x24,0x48,0xEB,0x10,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x48,0x23,0x4C,0x24,0x48,0x48,0x89,0x4C,0x24,0x48,0x48,0x8B,0x4C,0x24,0x48,0x48,0x89,0x4C,0x24,0x48,0x41,0xFF,0xC2,0x41,0x83,0xFA,0x40,0x0F,0x8C,0x3D,0xFF,0xFF,0xFF,0x41,0x83,0xF9,0x40,0x7D,0x1C,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x48,0x23,0x4C,0x24,0x50,0x48,0x89,0x4C,0x24,0x50,0x48,0x8B,0x4C,0x24,0x50,0x48,0x89,0x4C,0x24,0x50,0xEB,0x1A,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x48,0x23,0x4C,0x24,0x58,0x48,0x89,0x4C,0x24,0x58,0x48,0x8B,0x4C,0x24,0x58,0x48,0x89,0x4C,0x24,0x58,0x41,0xFF,0xC1,0x41,0x81,0xF9,0x80,0x00,0x00,0x00,0x0F,0x8C,0x32,0xFE,0xFF,0xFF,0x33,0xD2,0x89,0x14,0x24,0x48,0x8D,0x14,0x24,0x33,0xC9,0x89,0x0A,0x8B,0x14,0x24,0x83,0xFA,0x01,0x75,0x16,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x0B,0x54,0x24,0x58,0x48,0x89,0x54,0x24,0x58,0xEB,0x14,0x48,0xBA,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x7F,0x48,0x23,0x54,0x24,0x58,0x48,0x89,0x54,0x24,0x58,0x48,0x8B,0x54,0x24,0x58,0x48,0x89,0x54,0x24,0x58,0x48,0x8B,0x54,0x24,0x50,0x48,0x89,0x10,0x48,0x8B,0x54,0x24,0x58,0x48,0x89,0x50,0x08,0x48,0x83,0xC4,0x60,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<sbyte> vpackss(in Vec128<short> lhs, in Vec128<short> rhs)
; location: [7FFDDBACD410h, 7FFDDBACD429h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpacksswb xmm0,xmm0,xmm1      ; VPACKSSWB(VEX_Vpacksswb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 63 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpackssBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x63,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<byte> vpackus(in Vec128<short> lhs, in Vec128<short> rhs)
; location: [7FFDDBACD440h, 7FFDDBACD459h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpackuswb xmm0,xmm0,xmm1      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 67 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpackusBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x67,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<short> vpackss(in Vec128<int> lhs, in Vec128<int> rhs)
; location: [7FFDDBACD470h, 7FFDDBACD489h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpackssdw xmm0,xmm0,xmm1      ; VPACKSSDW(VEX_Vpackssdw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 6b c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpackssBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x6B,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<sbyte> vpackss(in Vec256<short> lhs, in Vec256<short> rhs)
; location: [7FFDDBACD8B0h, 7FFDDBACD8CCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpacksswb ymm0,ymm0,ymm1      ; VPACKSSWB(VEX_Vpacksswb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 63 c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpackssBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0x63,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<short> vpackss(in Vec256<int> lhs, in Vec256<int> rhs)
; location: [7FFDDBACD8E0h, 7FFDDBACD8FCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpackssdw ymm0,ymm0,ymm1      ; VPACKSSDW(VEX_Vpackssdw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 6b c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpackssBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0x6B,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ushort> vpackus(in Vec256<int> lhs, in Vec256<int> rhs)
; location: [7FFDDBACD910h, 7FFDDBACD92Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpackusdw ymm0,ymm0,ymm1      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 2b c1
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpackusBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x2B,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt128 and(in UInt128 lhs, in UInt128 rhs)
; location: [7FFDDBACD940h, 7FFDDBACD984h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000ah mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
000eh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0013h vpinsrq xmm0,xmm0,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c2 01
0019h mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 00
001ch mov rdx,[r8+8]                ; MOV(Mov_r64_rm64) [RDX,mem(64u,R8:br,DS:sr)]         encoding(4 bytes) = 49 8b 50 08
0020h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0025h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
002bh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
002fh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0034h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0039h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
003dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0040h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[69]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0x49,0x8B,0x00,0x49,0x8B,0x50,0x08,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref UInt128 and(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
; location: [7FFDDBACD9A0h, 7FFDDBACD9E5h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000ah mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 49 08
000eh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0013h vpinsrq xmm0,xmm0,rcx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RCX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c1 01
0019h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
001ch mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
0020h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0025h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
002bh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
002fh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0034h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0039h vmovdqu xmmword ptr [r8],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
003eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0041h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[70]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x48,0x8B,0x49,0x08,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC1,0x01,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC4,0xC1,0x7A,0x7F,0x00,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt128 or(in UInt128 lhs, in UInt128 rhs)
; location: [7FFDDBACDA00h, 7FFDDBACDA44h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000ah mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
000eh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0013h vpinsrq xmm0,xmm0,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c2 01
0019h mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 00
001ch mov rdx,[r8+8]                ; MOV(Mov_r64_rm64) [RDX,mem(64u,R8:br,DS:sr)]         encoding(4 bytes) = 49 8b 50 08
0020h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0025h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
002bh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
002fh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0034h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0039h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
003dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0040h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[69]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0x49,0x8B,0x00,0x49,0x8B,0x50,0x08,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref UInt128 or(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
; location: [7FFDDBACDA60h, 7FFDDBACDAA5h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000ah mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 49 08
000eh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0013h vpinsrq xmm0,xmm0,rcx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RCX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c1 01
0019h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
001ch mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
0020h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0025h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
002bh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
002fh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0034h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0039h vmovdqu xmmword ptr [r8],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
003eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0041h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[70]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x48,0x8B,0x49,0x08,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC1,0x01,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC4,0xC1,0x7A,0x7F,0x00,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt128 xor(in UInt128 lhs, in UInt128 rhs)
; location: [7FFDDBACDAC0h, 7FFDDBACDB04h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000ah mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
000eh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0013h vpinsrq xmm0,xmm0,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c2 01
0019h mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 00
001ch mov rdx,[r8+8]                ; MOV(Mov_r64_rm64) [RDX,mem(64u,R8:br,DS:sr)]         encoding(4 bytes) = 49 8b 50 08
0020h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0025h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
002bh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
002fh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0034h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0039h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
003dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0040h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[69]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0x49,0x8B,0x00,0x49,0x8B,0x50,0x08,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref UInt128 xor(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
; location: [7FFDDBACDB20h, 7FFDDBACDB65h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000ah mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 49 08
000eh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0013h vpinsrq xmm0,xmm0,rcx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RCX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c1 01
0019h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
001ch mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
0020h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0025h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
002bh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
002fh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0034h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0039h vmovdqu xmmword ptr [r8],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
003eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0041h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[70]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x48,0x8B,0x49,0x08,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC1,0x01,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC4,0xC1,0x7A,0x7F,0x00,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt128 bslli(UInt128 src, byte bytes)
; location: [7FFDDBACDB80h, 7FFDDBACDBD4h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ah mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
000fh mov [rsp+38h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 38
0014h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0017h mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 0a
001ah mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
001eh vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
0023h vpinsrq xmm0,xmm0,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c2 01
0029h lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
002eh vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
0034h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0039h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
003dh call 7FFDDB418B50h            ; CALL(Call_rel32_64) [FFFFFFFFFF94AFD0h:jmp64]        encoding(5 bytes) = e8 8e af 94 ff
0042h vmovdqu xmm0,xmmword ptr [rsp+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 30
0048h vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
004ch mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
004fh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0053h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0054h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bslliBytes => new byte[85]{0x56,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x38,0x48,0x8B,0xF1,0x48,0x8B,0x0A,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0x48,0x8D,0x4C,0x24,0x30,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0x8E,0xAF,0x94,0xFF,0xC5,0xFA,0x6F,0x44,0x24,0x30,0xC5,0xFA,0x7F,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x40,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte between(sbyte src, byte i0, byte i1)
; location: [7FFDDBACDBF0h, 7FFDDBACDC18h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
001fh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0024h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte between(byte src, byte i0, byte i1)
; location: [7FFDDBACDC30h, 7FFDDBACDC56h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
001eh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0023h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short between(short src, byte i0, byte i1)
; location: [7FFDDBACDC70h, 7FFDDBACDC98h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
001fh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0024h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort between(ushort src, byte i0, byte i1)
; location: [7FFDDBACDCB0h, 7FFDDBACDCD6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
001eh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0023h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint between(uint src, byte i0, byte i1)
; location: [7FFDDBACDCF0h, 7FFDDBACDD10h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int between(int src, byte i0, byte i1)
; location: [7FFDDBACDD30h, 7FFDDBACDD50h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong between(ulong src, byte i0, byte i1)
; location: [7FFDDBACDD70h, 7FFDDBACDD90h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long between(long src, byte i0, byte i1)
; location: [7FFDDBACDDB0h, 7FFDDBACDDD0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float between(float src, byte i0, byte i1)
; location: [7FFDDBACDDF0h, 7FFDDBACDE26h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0013h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0016h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0018h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
001ah movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
001dh shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0020h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0022h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0025h bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
002ah mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
002dh vmovss xmm0,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 10 04 24
0032h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[55]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x41,0x0F,0xB6,0xC8,0x0F,0xB6,0xD2,0x2B,0xCA,0xFF,0xC1,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x89,0x04,0x24,0xC5,0xFA,0x10,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double between(double src, byte i0, byte i1)
; location: [7FFDDBACDE40h, 7FFDDBACDE7Ch]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0016h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0019h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
001bh inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
001dh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0020h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0023h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h bextr rax,rax,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RAX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 c0
002dh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0032h vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0038h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[61]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0x41,0x0F,0xB6,0xC8,0x0F,0xB6,0xD2,0x2B,0xCA,0xFF,0xC1,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xC0,0x48,0x89,0x44,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte bitmap(in sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
; location: [7FFDDBACDEA0h, 7FFDDBACDEE1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 4c 0f be 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movsx rcx,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 08
001fh movsx r9,byte ptr [r10]       ; MOVSX(Movsx_r64_rm8) [R9,mem(8i,R10:br,DS:sr)]       encoding(4 bytes) = 4d 0f be 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
003dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003fh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBE,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x48,0x0F,0xBE,0x08,0x4D,0x0F,0xBE,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBE,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
; location: [7FFDDBACDF00h, 7FFDDBACDF3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,byte ptr [rax]     ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RAX:br,DS:sr)]     encoding(4 bytes) = 44 0f b6 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 08
001eh movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
0022h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0025h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0029h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002dh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0030h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0033h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0038h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003bh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[64]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB6,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x0F,0xB6,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref short dst)
; location: [7FFDDBACDF50h, 7FFDDBACDF92h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [R11,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 4c 0f bf 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movsx rcx,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 08
0020h movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
0024h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0027h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002bh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002fh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0032h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0035h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
003ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003fh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[67]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBF,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x48,0x0F,0xBF,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDDBACDFB0h, 7FFDDBACDFF1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,DS:sr)]   encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 08
001fh movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003eh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref int dst)
; location: [7FFDDBACE010h, 7FFDDBACE046h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
0019h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ch movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0020h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0024h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0027h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ah bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0032h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0034h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDDBACE060h, 7FFDDBACE096h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
0019h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ch movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0020h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0024h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0027h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ah bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0032h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0034h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDDBACE0B0h, 7FFDDBACE0EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0022h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0026h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0029h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ch bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0031h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0034h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0037h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDDBACE100h, 7FFDDBACE13Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0022h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0026h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0029h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ch bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0031h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0034h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0037h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
; location: [7FFDDBACE150h, 7FFDDBACE195h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 4c 0f be 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movsx rcx,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 08
001fh movsx r9,word ptr [r10]       ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,R10:br,DS:sr)]     encoding(4 bytes) = 4d 0f bf 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003dh movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0041h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0043h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[70]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBE,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x48,0x0F,0xBE,0x08,0x4D,0x0F,0xBF,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBE,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
; location: [7FFDDBACE1B0h, 7FFDDBACE1F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,byte ptr [rax]     ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RAX:br,DS:sr)]     encoding(4 bytes) = 44 0f b6 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 08
001eh movsx r9,word ptr [r10]       ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,R10:br,DS:sr)]     encoding(4 bytes) = 4d 0f bf 0a
0022h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0025h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0029h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002dh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0030h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0033h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0038h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003fh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0041h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[68]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB6,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x0F,0xB6,0x08,0x4D,0x0F,0xBF,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBF,0xD2,0x0F,0xB6,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
; location: [7FFDDBACE210h, 7FFDDBACE253h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [R11,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 4c 0f bf 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movsx rcx,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 08
0020h movsx r9,word ptr [r10]       ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,R10:br,DS:sr)]     encoding(4 bytes) = 4d 0f bf 0a
0024h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0027h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002bh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002fh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0032h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0035h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
003ah movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0040h mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[68]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBF,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x48,0x0F,0xBF,0x08,0x4D,0x0F,0xBF,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBF,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDDBACE270h, 7FFDDBACE2B5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,DS:sr)]   encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 08
001fh movsx r9,word ptr [r10]       ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,R10:br,DS:sr)]     encoding(4 bytes) = 4d 0f bf 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0040h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0042h mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[70]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x4D,0x0F,0xBF,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBF,0xD2,0x0F,0xB7,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDDBACE2D0h, 7FFDDBACE311h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,DS:sr)]   encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 08
001fh movzx r9d,word ptr [r10]      ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,R10:br,DS:sr)]    encoding(4 bytes) = 45 0f b7 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
003ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003eh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x45,0x0F,0xB7,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB7,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap(in ushort src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDDBACE330h, 7FFDDBACE366h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h movzx r9d,word ptr [r10]      ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,R10:br,DS:sr)]    encoding(4 bytes) = 45 0f b7 0a
0019h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ch movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0020h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0024h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0027h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ah bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0032h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0034h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x0F,0xB7,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB7,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDDBACE380h, 7FFDDBACE3BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h movzx r9d,word ptr [r10]      ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,R10:br,DS:sr)]    encoding(4 bytes) = 45 0f b7 0a
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0022h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0026h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0029h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ch bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0037h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x45,0x0F,0xB7,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB7,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int bitmap(in int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
; location: [7FFDDBACE3D0h, 7FFDDBACE402h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0023h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0030h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap(in int src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDDBACE420h, 7FFDDBACE459h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0030h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0033h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0036h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[58]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x63,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(in int src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDDBACE470h, 7FFDDBACE4A8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0030h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
0032h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0035h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[57]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x8B,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDDBACE4C0h, 7FFDDBACE4F2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0023h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0030h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(in uint src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDDBACE510h, 7FFDDBACE548h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0030h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
0032h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0035h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[57]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x8B,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap(in long src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDDBACE560h, 7FFDDBACE596h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0030h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0033h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
; location: [7FFDDBACE5B0h, 7FFDDBACE5F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 4c 0f be 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movsx rcx,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 08
001fh mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
0022h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0025h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0029h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002dh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0030h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0033h bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0038h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
003ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003eh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[65]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBE,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x48,0x0F,0xBE,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0F,0xBE,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
; location: [7FFDDBACE610h, 7FFDDBACE64Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,byte ptr [rax]     ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RAX:br,DS:sr)]     encoding(4 bytes) = 44 0f b6 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 08
001eh mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
0021h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0024h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0028h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002ch or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0032h bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0037h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003ah or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003ch mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[63]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB6,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x0F,0xB6,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref short dst)
; location: [7FFDDBACE660h, 7FFDDBACE6A2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [R11,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 4c 0f bf 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movsx rcx,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 08
0020h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0039h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003fh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[67]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBF,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x48,0x0F,0xBF,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0F,0xBF,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDDBACE6C0h, 7FFDDBACE700h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,DS:sr)]   encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 08
001fh mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
0022h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0025h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0029h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002dh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0030h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0033h bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0038h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
003bh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003dh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[65]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x0F,0xB7,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref int dst)
; location: [7FFDDBACE720h, 7FFDDBACE752h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0023h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
002eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0030h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDDBACE770h, 7FFDDBACE7A2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0023h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
002eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0030h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDDBACE7C0h, 7FFDDBACE7F6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0030h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0033h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDDBACE810h, 7FFDDBACE846h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0030h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0033h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float bitmap(in float src, byte srcOffset, byte len, byte dstOffset, ref float dst)
; location: [7FFDDBACE860h, 7FFDDBACE8C8h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rsp+40h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 40
000ch vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
0010h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
0016h mov ecx,[rsp+14h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 14
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr edx,ecx,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,ECX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 d1
0030h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0034h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0036h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
003ah vcvtsi2ss xmm0,xmm0,edx       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,EDX] encoding(VEX, 4 bytes) = c5 fa 2a c2
003eh vmovss xmm1,dword ptr [rax]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 08
0042h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0048h mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 10
004ch vmovss dword ptr [rsp+0Ch],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 0c
0052h or edx,[rsp+0Ch]              ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 54 24 0c
0056h mov [rsp+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 08
005ah vmovss xmm0,dword ptr [rsp+8] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 08
0060h vmovss dword ptr [rax],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 00
0064h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[105]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x40,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x4C,0x24,0x14,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xD1,0x41,0x0F,0xB6,0xC9,0xD3,0xE2,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC2,0xC5,0xFA,0x10,0x08,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x8B,0x54,0x24,0x10,0xC5,0xFA,0x11,0x44,0x24,0x0C,0x0B,0x54,0x24,0x0C,0x89,0x54,0x24,0x08,0xC5,0xFA,0x10,0x44,0x24,0x08,0xC5,0xFA,0x11,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double bitmap(in double src, byte srcOffset, byte len, byte dstOffset, ref double dst)
; location: [7FFDDBACE8F0h, 7FFDDBACE95Eh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rsp+50h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 50
000ch vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
0010h vmovsd qword ptr [rsp+20h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 20
0016h mov rcx,[rsp+20h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 20
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0022h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0026h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0029h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ch bextr rdx,rcx,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,RCX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 d1
0031h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0035h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0038h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
003ch vcvtsi2sd xmm0,xmm0,rdx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RDX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c2
0041h vmovsd xmm1,qword ptr [rax]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 08
0045h vmovsd qword ptr [rsp+18h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 18
004bh mov rdx,[rsp+18h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 18
0050h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0056h or rdx,[rsp+10h]              ; OR(Or_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 54 24 10
005bh mov [rsp+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 08
0060h vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0066h vmovsd qword ptr [rax],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 00
006ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
006eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[111]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x50,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x11,0x44,0x24,0x20,0x48,0x8B,0x4C,0x24,0x20,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xD1,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0xE2,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC2,0xC5,0xFB,0x10,0x08,0xC5,0xFB,0x11,0x4C,0x24,0x18,0x48,0x8B,0x54,0x24,0x18,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x0B,0x54,0x24,0x10,0x48,0x89,0x54,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC5,0xFB,0x11,0x00,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsi(byte src)
; location: [7FFDDBACE980h, 7FFDDBACE990h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsi(ushort src)
; location: [7FFDDBACE9B0h, 7FFDDBACE9C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsi(uint src)
; location: [7FFDDBACE9E0h, 7FFDDBACE9EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi eax,ecx                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,ECX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsi(ulong src)
; location: [7FFDDBACEA00h, 7FFDDBACEA0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi rax,rcx                  ; BLSI(VEX_Blsi_r64_rm64) [RAX,RCX]                    encoding(VEX, 5 bytes) = c4 e2 f8 f3 d9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsic(byte src)
; location: [7FFDDBACEA20h, 7FFDDBACEA33h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000ch dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC8,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsic(ushort src)
; location: [7FFDDBACEA50h, 7FFDDBACEA63h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000ch dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC8,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsic(uint src)
; location: [7FFDDBACEA80h, 7FFDDBACEA8Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
000bh or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC9,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsic(ulong src)
; location: [7FFDDBACEAA0h, 7FFDDBACEAB1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh dec rcx                       ; DEC(Dec_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c9
000eh or rax,rcx                    ; OR(Or_r64_rm64) [RAX,RCX]                            encoding(3 bytes) = 48 0b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC9,0x48,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsmsk(byte src)
; location: [7FFDDBACEAD0h, 7FFDDBACEAE0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsmsk(ushort src)
; location: [7FFDDBACEB00h, 7FFDDBACEB10h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsmsk(uint src)
; location: [7FFDDBACEB30h, 7FFDDBACEB3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk eax,ecx                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,ECX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsmsk(ulong src)
; location: [7FFDDBACEB50h, 7FFDDBACEB5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk rax,rcx                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RAX,RCX]                encoding(VEX, 5 bytes) = c4 e2 f8 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsr(byte src)
; location: [7FFDDBACEB70h, 7FFDDBACEB80h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsr eax,eax                  ; BLSR(VEX_Blsr_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 c8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xC8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsr(ushort src)
; location: [7FFDDBACEBA0h, 7FFDDBACEBB0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsr eax,eax                  ; BLSR(VEX_Blsr_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 c8
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xC8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsr(uint src)
; location: [7FFDDBACEBD0h, 7FFDDBACEBDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsr eax,ecx                  ; BLSR(VEX_Blsr_r32_rm32) [EAX,ECX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 c9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xC9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsr(ulong src)
; location: [7FFDDBACEBF0h, 7FFDDBACEBFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsr rax,rcx                  ; BLSR(VEX_Blsr_r64_rm64) [RAX,RCX]                    encoding(VEX, 5 bytes) = c4 e2 f8 f3 c9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xC9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte bzhi(byte src, uint index)
; location: [7FFDDBACEC10h, 7FFDDBACEC20h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort bzhi(ushort src, uint index)
; location: [7FFDDBACEC40h, 7FFDDBACEC50h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint bzhi(uint src, uint index)
; location: [7FFDDBACEC70h, 7FFDDBACEC7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,ecx,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong bzhi(ulong src, uint index)
; location: [7FFDDBACEC90h, 7FFDDBACEC9Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,rcx,rax              ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f8 f5 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bzhi(ref byte src, uint index)
; location: [7FFDDBACECB0h, 7FFDDBACECC2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xC4,0xE2,0x68,0xF5,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bzhi(ref ushort src, uint index)
; location: [7FFDDBACECE0h, 7FFDDBACECF3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xC4,0xE2,0x68,0xF5,0xC0,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bzhi(ref uint src, uint index)
; location: [7FFDDBACED10h, 7FFDDBACED1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,[rcx],edx            ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,mem(32u,RCX:br,DS:sr),EDX] encoding(VEX, 5 bytes) = c4 e2 68 f5 01
000ah mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0x01,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bzhi(ref ulong src, uint index)
; location: [7FFDDBACED30h, 7FFDDBACED42h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,[rcx],rax            ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,mem(64u,RCX:br,DS:sr),RAX] encoding(VEX, 5 bytes) = c4 e2 f8 f5 01
000ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0x01,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte extract(sbyte src, byte start, byte length)
; location: [7FFDDBACED60h, 7FFDDBACED81h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
0018h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte extract(byte src, byte start, byte length)
; location: [7FFDDBACEDA0h, 7FFDDBACEDBFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0017h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short extract(short src, byte start, byte length)
; location: [7FFDDBACEDD0h, 7FFDDBACEDF1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
0018h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort extract(ushort src, byte start, byte length)
; location: [7FFDDBACEE10h, 7FFDDBACEE2Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
0017h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint extract(uint src, byte start, byte length)
; location: [7FFDDBACEE40h, 7FFDDBACEE59h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int extract(int src, byte start, byte length)
; location: [7FFDDBACEE70h, 7FFDDBACEE89h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long extract(long src, byte start, byte length)
; location: [7FFDDBACEEA0h, 7FFDDBACEEB9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong extract(ulong src, byte start, byte length)
; location: [7FFDDBACEED0h, 7FFDDBACEEE9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint extract(float src, byte start, byte length)
; location: [7FFDDBACEF00h, 7FFDDBACEF27h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0016h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0019h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
001bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001eh bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong extract(double src, byte start, byte length)
; location: [7FFDDBACEF40h, 7FFDDBACEF66h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
000eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0011h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0015h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0018h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
001ah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001dh bextr rax,rax,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RAX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 c0
0022h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[39]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gather(byte src, byte mask)
; location: [7FFDDBACEF80h, 7FFDDBACEF93h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte gather(sbyte src, sbyte mask)
; location: [7FFDDBACEFB0h, 7FFDDBACEFC6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short gather(short src, short mask)
; location: [7FFDDBACEFE0h, 7FFDDBACEFF6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gather(ushort src, ushort mask)
; location: [7FFDDBACF010h, 7FFDDBACF023h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int gather(int src, int mask)
; location: [7FFDDBACF040h, 7FFDDBACF04Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather(uint src, uint mask)
; location: [7FFDDBACF060h, 7FFDDBACF06Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long gather(long src, long mask)
; location: [7FFDDBACF080h, 7FFDDBACF08Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather(ulong src, ulong mask)
; location: [7FFDDBACF0A0h, 7FFDDBACF0AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather(float src, uint mask)
; location: [7FFDDBACF0C0h, 7FFDDBACF0D8h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0014h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[25]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0xC4,0xE2,0x7A,0xF5,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather(double src, ulong mask)
; location: [7FFDDBACF0F0h, 7FFDDBACF107h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
000eh pext rax,rax,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 c2
0013h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[24]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0xC4,0xE2,0xFA,0xF5,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gather(byte src, BitMask8:byte mask)
; location: [7FFDDBACF120h, 7FFDDBACF133h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gather(ushort src, BitMask16:ushort mask)
; location: [7FFDDBACF150h, 7FFDDBACF163h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather(uint src, BitMask32:uint mask)
; location: [7FFDDBACF180h, 7FFDDBACF18Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather(ulong src, BitMask64:ulong mask)
; location: [7FFDDBACF1A0h, 7FFDDBACF1AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte gather(byte src, byte mask, ref byte dst)
; location: [7FFDDBACF1C0h, 7FFDDBACF1D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0013h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x41,0x88,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte gather(sbyte src, sbyte mask, ref sbyte dst)
; location: [7FFDDBACF1F0h, 7FFDDBACF208h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0015h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x41,0x88,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short gather(short src, short mask, ref short dst)
; location: [7FFDDBACF220h, 7FFDDBACF239h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),AX]          encoding(4 bytes) = 66 41 89 00
0016h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x66,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort gather(ushort src, ushort mask, ref ushort dst)
; location: [7FFDDBACF250h, 7FFDDBACF267h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),AX]          encoding(4 bytes) = 66 41 89 00
0014h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x66,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int gather(int src, int mask, ref int dst)
; location: [7FFDDBACF280h, 7FFDDBACF290h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint gather(uint src, uint mask, ref uint dst)
; location: [7FFDDBACF2B0h, 7FFDDBACF2C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long gather(long src, long mask, ref long dst)
; location: [7FFDDBACF2E0h, 7FFDDBACF2F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong gather(ulong src, ulong mask, ref ulong dst)
; location: [7FFDDBACF310h, 7FFDDBACF320h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte hi(sbyte src)
; location: [7FFDDBACF340h, 7FFDDBACF350h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC1,0xF8,0x04,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte hi(byte src)
; location: [7FFDDBACF370h, 7FFDDBACF37Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC1,0xF8,0x04,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte hi(short src)
; location: [7FFDDBACF390h, 7FFDDBACF3A0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC1,0xF8,0x08,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte hi(ushort src)
; location: [7FFDDBACF3C0h, 7FFDDBACF3CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short hi(int src)
; location: [7FFDDBACF3E0h, 7FFDDBACF3ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sar ecx,10h                   ; SAR(Sar_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 f9 10
0008h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0xC1,0xF9,0x10,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort hi(uint src)
; location: [7FFDDBACF400h, 7FFDDBACF40Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
0008h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0xC1,0xE9,0x10,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int hi(long src)
; location: [7FFDDBACF420h, 7FFDDBACF42Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sar rcx,20h                   ; SAR(Sar_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 f9 20
0009h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xC1,0xF9,0x20,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint hi(ulong src)
; location: [7FFDDBACF440h, 7FFDDBACF44Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
0009h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xC1,0xE9,0x20,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort puthi(byte src, ref ushort dst)
; location: [7FFDDBACF460h, 7FFDDBACF482h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 02
0008h mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
000eh bzhi eax,eax,r8d              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,R8D]            encoding(VEX, 5 bytes) = c4 e2 38 f5 c0
0013h mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
0016h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0019h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
001ch or [rdx],ax                   ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]           encoding(3 bytes) = 66 09 02
001fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> puthiBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x02,0x41,0xB8,0x08,0x00,0x00,0x00,0xC4,0xE2,0x38,0xF5,0xC0,0x66,0x89,0x02,0x0F,0xB6,0xC1,0xC1,0xE0,0x08,0x66,0x09,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint puthi(ushort src, ref uint dst)
; location: [7FFDDBACF4A0h, 7FFDDBACF4BCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
000ah bzhi eax,[rdx],eax            ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,mem(32u,RDX:br,DS:sr),EAX] encoding(VEX, 5 bytes) = c4 e2 78 f5 02
000fh mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
0011h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0014h shl eax,10h                   ; SHL(Shl_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 e0 10
0017h or [rdx],eax                  ; OR(Or_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]          encoding(2 bytes) = 09 02
0019h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> puthiBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x00,0x00,0x00,0xC4,0xE2,0x78,0xF5,0x02,0x89,0x02,0x0F,0xB7,0xC1,0xC1,0xE0,0x10,0x09,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong puthi(uint src, ref ulong dst)
; location: [7FFDDBACF4D0h, 7FFDDBACF4EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
000ah bzhi rax,[rdx],rax            ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,mem(64u,RDX:br,DS:sr),RAX] encoding(VEX, 5 bytes) = c4 e2 f8 f5 02
000fh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0012h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0014h shl rax,20h                   ; SHL(Shl_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e0 20
0018h or [rdx],rax                  ; OR(Or_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]          encoding(3 bytes) = 48 09 02
001bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> puthiBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x20,0x00,0x00,0x00,0xC4,0xE2,0xF8,0xF5,0x02,0x48,0x89,0x02,0x8B,0xC1,0x48,0xC1,0xE0,0x20,0x48,0x09,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte lo(sbyte src)
; location: [7FFDDBACF500h, 7FFDDBACF50Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x83,0xE0,0x0F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte lo(byte src)
; location: [7FFDDBACF520h, 7FFDDBACF52Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x83,0xE0,0x0F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte lo(short src)
; location: [7FFDDBACF540h, 7FFDDBACF54Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte lo(ushort src)
; location: [7FFDDBACF560h, 7FFDDBACF56Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short lo(int src)
; location: [7FFDDBACF580h, 7FFDDBACF589h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort lo(uint src)
; location: [7FFDDBACF5A0h, 7FFDDBACF5A8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
