; 2019-10-09 16:40:43:933
; function: sbyte square(sbyte src)
; location: [7FFDDBEB7040h, 7FFDDBEB7050h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte square(byte src)
; location: [7FFDDBEB7070h, 7FFDDBEB707Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short square(short src)
; location: [7FFDDBEB7090h, 7FFDDBEB70A0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort square(ushort src)
; location: [7FFDDBEB70C0h, 7FFDDBEB70CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int square(int src)
; location: [7FFDDBEB70E0h, 7FFDDBEB70EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint square(uint src)
; location: [7FFDDBEB7100h, 7FFDDBEB710Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long square(long src)
; location: [7FFDDBEB7120h, 7FFDDBEB7137h]
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
; location: [7FFDDBEB7150h, 7FFDDBEB715Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte square(ref sbyte src)
; location: [7FFDDBEB7170h, 7FFDDBEB7181h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x0F,0xAF,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte square(ref byte src)
; location: [7FFDDBEB71A0h, 7FFDDBEB71B0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x0F,0xAF,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short square(ref short src)
; location: [7FFDDBEB71D0h, 7FFDDBEB71E2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x0F,0xAF,0xC0,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort square(ref ushort src)
; location: [7FFDDBEB7200h, 7FFDDBEB7211h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x0F,0xAF,0xC0,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int square(ref int src)
; location: [7FFDDBEB7230h, 7FFDDBEB723Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ah mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x0F,0xAF,0xC0,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint square(ref uint src)
; location: [7FFDDBEB7250h, 7FFDDBEB725Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ah mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x0F,0xAF,0xC0,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long square(ref long src)
; location: [7FFDDBEB7270h, 7FFDDBEB7282h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h imul rax,rax                  ; IMUL(Imul_r64_rm64) [RAX,RAX]                        encoding(4 bytes) = 48 0f af c0
000ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x0F,0xAF,0xC0,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong square(ref ulong src)
; location: [7FFDDBEB72A0h, 7FFDDBEB72B2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h imul rax,rax                  ; IMUL(Imul_r64_rm64) [RAX,RAX]                        encoding(4 bytes) = 48 0f af c0
000ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> squareBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x0F,0xAF,0xC0,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sub(sbyte lhs, sbyte rhs)
; location: [7FFDDBEB72D0h, 7FFDDBEB72E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x2B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sub(byte lhs, byte rhs)
; location: [7FFDDBEB7300h, 7FFDDBEB7310h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x2B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sub(short lhs, short rhs)
; location: [7FFDDBEB7330h, 7FFDDBEB7343h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x2B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sub(ushort lhs, ushort rhs)
; location: [7FFDDBEB7360h, 7FFDDBEB7370h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x2B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sub(int lhs, int rhs)
; location: [7FFDDBEB7390h, 7FFDDBEB7399h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sub(uint lhs, uint rhs)
; location: [7FFDDBEB73B0h, 7FFDDBEB73B9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sub(long lhs, long rhs)
; location: [7FFDDBEB73D0h, 7FFDDBEB73DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sub(ulong lhs, ulong rhs)
; location: [7FFDDBEB73F0h, 7FFDDBEB73FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte sub(ref sbyte lhs, sbyte rhs)
; location: [7FFDDBEB7410h, 7FFDDBEB741Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h sub [rcx],al                  ; SUB(Sub_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 28 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x28,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte sub(ref byte lhs, byte rhs)
; location: [7FFDDBEB7430h, 7FFDDBEB743Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub [rcx],al                  ; SUB(Sub_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 28 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x28,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short sub(ref short lhs, short rhs)
; location: [7FFDDBEB7450h, 7FFDDBEB745Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h sub [rcx],ax                  ; SUB(Sub_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 29 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x66,0x29,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort sub(ref ushort lhs, ushort rhs)
; location: [7FFDDBEB7470h, 7FFDDBEB747Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h sub [rcx],ax                  ; SUB(Sub_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 29 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x66,0x29,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int sub(ref int lhs, int rhs)
; location: [7FFDDBEB7490h, 7FFDDBEB749Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub [rcx],edx                 ; SUB(Sub_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 29 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x29,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint sub(ref uint lhs, uint rhs)
; location: [7FFDDBEB74B0h, 7FFDDBEB74BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub [rcx],edx                 ; SUB(Sub_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 29 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x29,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long sub(ref long lhs, long rhs)
; location: [7FFDDBEB74D0h, 7FFDDBEB74DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub [rcx],rdx                 ; SUB(Sub_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 29 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x29,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong sub(ref ulong lhs, ulong rhs)
; location: [7FFDDBEB74F0h, 7FFDDBEB74FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub [rcx],rdx                 ; SUB(Sub_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 29 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x29,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool within(byte lhs, byte rhs, byte epsilon)
; location: [7FFDDBEB7510h, 7FFDDBEB753Ch]
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
; location: [7FFDDBEB7550h, 7FFDDBEB757Eh]
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
; location: [7FFDDBEB7590h, 7FFDDBEB75BEh]
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
; location: [7FFDDBEB75D0h, 7FFDDBEB75FCh]
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
; location: [7FFDDBEB7610h, 7FFDDBEB7630h]
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
; location: [7FFDDBEB7650h, 7FFDDBEB7670h]
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
; location: [7FFDDBEB7690h, 7FFDDBEB76B3h]
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
; location: [7FFDDBEB76D0h, 7FFDDBEB76F3h]
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
; function: ref short min(ref short lhs, short rhs)
; location: [7FFDDBEB7710h, 7FFDDBEB7738h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx rax,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 00
000ch movsx r8,dx                   ; MOVSX(Movsx_r64_rm16) [R8,DX]                        encoding(4 bytes) = 4c 0f bf c2
0010h cmp eax,r8d                   ; CMP(Cmp_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 3b c0
0013h jl short 001bh                ; JL(Jl_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 7c 06
0015h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0019h jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 07
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh movsx rax,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 00
0022h mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0025h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xBF,0x00,0x4C,0x0F,0xBF,0xC2,0x41,0x3B,0xC0,0x7C,0x06,0x48,0x0F,0xBF,0xC2,0xEB,0x07,0x48,0x8B,0xC1,0x48,0x0F,0xBF,0x00,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort min(ref ushort lhs, ushort rhs)
; location: [7FFDDBEB7750h, 7FFDDBEB7775h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx eax,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 00
000bh movzx r8d,dx                  ; MOVZX(Movzx_r32_rm16) [R8D,DX]                       encoding(4 bytes) = 44 0f b7 c2
000fh cmp eax,r8d                   ; CMP(Cmp_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 3b c0
0012h jl short 0019h                ; JL(Jl_rel8_64) [19h:jmp64]                           encoding(2 bytes) = 7c 05
0014h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0017h jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 06
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch movzx eax,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 00
001fh mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0022h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB7,0x00,0x44,0x0F,0xB7,0xC2,0x41,0x3B,0xC0,0x7C,0x05,0x0F,0xB7,0xC2,0xEB,0x06,0x48,0x8B,0xC1,0x0F,0xB7,0x00,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int min(ref int lhs, int rhs)
; location: [7FFDDBEB7790h, 7FFDDBEB77A8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h cmp [rax],edx                 ; CMP(Cmp_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 39 10
000ah jl short 000eh                ; JL(Jl_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 7c 02
000ch jmp short 0013h               ; JMP(Jmp_rel8_64) [13h:jmp64]                         encoding(2 bytes) = eb 05
000eh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0011h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0013h mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x39,0x10,0x7C,0x02,0xEB,0x05,0x48,0x8B,0xD1,0x8B,0x12,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint min(ref uint lhs, uint rhs)
; location: [7FFDDBEB77C0h, 7FFDDBEB77D8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h cmp [rax],edx                 ; CMP(Cmp_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 39 10
000ah jb short 000eh                ; JB(Jb_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 72 02
000ch jmp short 0013h               ; JMP(Jmp_rel8_64) [13h:jmp64]                         encoding(2 bytes) = eb 05
000eh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0011h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0013h mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x39,0x10,0x72,0x02,0xEB,0x05,0x48,0x8B,0xD1,0x8B,0x12,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long min(ref long lhs, long rhs)
; location: [7FFDDBEB77F0h, 7FFDDBEB780Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h cmp [rax],rdx                 ; CMP(Cmp_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 39 10
000bh jl short 000fh                ; JL(Jl_rel8_64) [Fh:jmp64]                            encoding(2 bytes) = 7c 02
000dh jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 06
000fh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0012h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0015h mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x39,0x10,0x7C,0x02,0xEB,0x06,0x48,0x8B,0xD1,0x48,0x8B,0x12,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong min(ref ulong lhs, ulong rhs)
; location: [7FFDDBEB7820h, 7FFDDBEB783Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h cmp [rax],rdx                 ; CMP(Cmp_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 39 10
000bh jb short 000fh                ; JB(Jb_rel8_64) [Fh:jmp64]                            encoding(2 bytes) = 72 02
000dh jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 06
000fh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0012h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0015h mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x39,0x10,0x72,0x02,0xEB,0x06,0x48,0x8B,0xD1,0x48,0x8B,0x12,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mod(sbyte lhs, sbyte rhs)
; location: [7FFDDBEB7850h, 7FFDDBEB7864h]
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
; location: [7FFDDBEB7880h, 7FFDDBEB7891h]
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
; location: [7FFDDBEB78B0h, 7FFDDBEB78C4h]
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
; location: [7FFDDBEB78E0h, 7FFDDBEB78F1h]
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
; location: [7FFDDBEB7910h, 7FFDDBEB7920h]
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
; location: [7FFDDBEB7940h, 7FFDDBEB7951h]
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
; location: [7FFDDBEB7970h, 7FFDDBEB7983h]
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
; location: [7FFDDBEB79A0h, 7FFDDBEB79B3h]
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
; location: [7FFDDBEB79D0h, 7FFDDBEB79E6h]
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
; location: [7FFDDBEB7A00h, 7FFDDBEB7A15h]
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
; location: [7FFDDBEB7A30h, 7FFDDBEB7A47h]
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
; location: [7FFDDBEB7A60h, 7FFDDBEB7A76h]
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
; location: [7FFDDBEB7A90h, 7FFDDBEB7AA3h]
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
; location: [7FFDDBEB7AC0h, 7FFDDBEB7AD4h]
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
; location: [7FFDDBEB7AF0h, 7FFDDBEB7B06h]
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
; location: [7FFDDBEB7B20h, 7FFDDBEB7B36h]
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
; location: [7FFDDBEB7B50h, 7FFDDBEB7B64h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mul(byte lhs, byte rhs)
; location: [7FFDDBEB7B80h, 7FFDDBEB7B91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mul(short lhs, short rhs)
; location: [7FFDDBEB7BB0h, 7FFDDBEB7BC4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mul(ushort lhs, ushort rhs)
; location: [7FFDDBEB7BE0h, 7FFDDBEB7BF1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mul(int lhs, int rhs)
; location: [7FFDDBEB7C10h, 7FFDDBEB7C1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul(uint lhs, uint rhs)
; location: [7FFDDBEB7C30h, 7FFDDBEB7C3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mul(long lhs, long rhs)
; location: [7FFDDBEB7C50h, 7FFDDBEB7C5Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul(ulong lhs, ulong rhs)
; location: [7FFDDBEB7C70h, 7FFDDBEB7C7Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte mul(ref sbyte lhs, sbyte rhs)
; location: [7FFDDBEB7C90h, 7FFDDBEB7CA5h]
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
; location: [7FFDDBEB7CC0h, 7FFDDBEB7CD3h]
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
; location: [7FFDDBEB7CF0h, 7FFDDBEB7D06h]
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
; location: [7FFDDBEB7D20h, 7FFDDBEB7D34h]
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
; location: [7FFDDBEB7D50h, 7FFDDBEB7D5Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,[rcx]                ; IMUL(Imul_r32_rm32) [EDX,mem(32i,RCX:br,DS:sr)]      encoding(3 bytes) = 0f af 11
0008h mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0x11,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint mul(ref uint lhs, uint rhs)
; location: [7FFDDBEB7D70h, 7FFDDBEB7D7Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,[rcx]                ; IMUL(Imul_r32_rm32) [EDX,mem(32i,RCX:br,DS:sr)]      encoding(3 bytes) = 0f af 11
0008h mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0x11,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long mul(ref long lhs, long rhs)
; location: [7FFDDBEB7D90h, 7FFDDBEB7D9Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,[rcx]                ; IMUL(Imul_r64_rm64) [RDX,mem(64i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f af 11
0009h mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0x11,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mul(ref ulong lhs, ulong rhs)
; location: [7FFDDBEB7DB0h, 7FFDDBEB7DBFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,[rcx]                ; IMUL(Imul_r64_rm64) [RDX,mem(64i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f af 11
0009h mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0x11,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte negate(sbyte src)
; location: [7FFDDBEB7DD0h, 7FFDDBEB7DDFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte negate(byte src)
; location: [7FFDDBEB7DF0h, 7FFDDBEB7DFFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short negate(short src)
; location: [7FFDDBEB7E10h, 7FFDDBEB7E1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort negate(ushort src)
; location: [7FFDDBEB7E30h, 7FFDDBEB7E3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int negate(int src)
; location: [7FFDDBEB7E50h, 7FFDDBEB7E59h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint negate(uint src)
; location: [7FFDDBEB7E70h, 7FFDDBEB7E7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long negate(long src)
; location: [7FFDDBEB7E90h, 7FFDDBEB7E9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h neg rax                       ; NEG(Neg_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong negate(ulong src)
; location: [7FFDDBEB7EB0h, 7FFDDBEB7EBEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float negate(float src)
; location: [7FFDDBEB7ED0h, 7FFDDBEB7EE1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFDDBEB7EE8h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double negate(double src)
; location: [7FFDDBEB7F00h, 7FFDDBEB7F11h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFDDBEB7F18h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte negate(ref sbyte src)
; location: [7FFDDBEB7F30h, 7FFDDBEB7F3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h neg byte ptr [rcx]            ; NEG(Neg_rm8) [mem(8i,RCX:br,DS:sr)]                  encoding(2 bytes) = f6 19
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0x19,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte negate(ref byte src)
; location: [7FFDDBEB7F50h, 7FFDDBEB7F61h]
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
; location: [7FFDDBEB7F80h, 7FFDDBEB7F8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h neg word ptr [rcx]            ; NEG(Neg_rm16) [mem(16i,RCX:br,DS:sr)]                encoding(3 bytes) = 66 f7 19
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xF7,0x19,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort negate(ref ushort src)
; location: [7FFDDBEB7FA0h, 7FFDDBEB7FB2h]
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
; location: [7FFDDBEB7FD0h, 7FFDDBEB7FDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h neg dword ptr [rcx]           ; NEG(Neg_rm32) [mem(32i,RCX:br,DS:sr)]                encoding(2 bytes) = f7 19
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF7,0x19,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint negate(ref uint src)
; location: [7FFDDBEB7FF0h, 7FFDDBEB8000h]
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
; location: [7FFDDBEB8020h, 7FFDDBEB802Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h neg qword ptr [rcx]           ; NEG(Neg_rm64) [mem(64i,RCX:br,DS:sr)]                encoding(3 bytes) = 48 f7 19
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xF7,0x19,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong negate(ref ulong src)
; location: [7FFDDBEB8040h, 7FFDDBEB8054h]
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
; location: [7FFDDBEB8070h, 7FFDDBEB808Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
0009h vmovss xmm1,dword ptr [7FFDDBEB8098h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 17 00 00 00
0011h vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0015h vmovss dword ptr [rcx],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 01
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x10,0x0D,0x17,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC5,0xFA,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double negate(ref double src)
; location: [7FFDDBEB80B0h, 7FFDDBEB80CCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
0009h vmovsd xmm1,qword ptr [7FFDDBEB80D8h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 17 00 00 00
0011h vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0015h vmovsd qword ptr [rcx],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 01
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x10,0x0D,0x17,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC5,0xFB,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte negate(sbyte src, ref sbyte dst)
; location: [7FFDDBEB80F0h, 7FFDDBEB8100h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
000dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x88,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte negate(byte src, ref byte dst)
; location: [7FFDDBEB8120h, 7FFDDBEB8131h]
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
; location: [7FFDDBEB8150h, 7FFDDBEB8161h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x66,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort negate(ushort src, ref ushort dst)
; location: [7FFDDBEB8180h, 7FFDDBEB8192h]
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
; location: [7FFDDBEB81B0h, 7FFDDBEB81BEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0009h mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint negate(uint src, ref uint dst)
; location: [7FFDDBEB81D0h, 7FFDDBEB81E0h]
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
; location: [7FFDDBEB8200h, 7FFDDBEB8211h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h neg rax                       ; NEG(Neg_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d8
000bh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0x48,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong negate(ulong src, ref ulong dst)
; location: [7FFDDBEB8230h, 7FFDDBEB8244h]
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
; location: [7FFDDBEB8260h, 7FFDDBEB8278h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFDDBEB8280h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 13 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h vmovss dword ptr [rdx],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 02
0015h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x13,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC5,0xFA,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double negate(double src, ref double dst)
; location: [7FFDDBEB82A0h, 7FFDDBEB82B8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFDDBEB82C0h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 13 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h vmovsd qword ptr [rdx],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 02
0015h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x13,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC5,0xFB,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative(sbyte x)
; location: [7FFDDBEB82E0h, 7FFDDBEB82F1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negativeBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative(short x)
; location: [7FFDDBEB8310h, 7FFDDBEB8321h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negativeBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative(int x)
; location: [7FFDDBEB8340h, 7FFDDBEB834Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negativeBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative(long x)
; location: [7FFDDBEB8360h, 7FFDDBEB836Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negativeBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative(float x)
; location: [7FFDDBEB8380h, 7FFDDBEB8393h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm1,xmm0            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0]        encoding(VEX, 4 bytes) = c5 f8 2e c8
000dh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negativeBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative(double x)
; location: [7FFDDBEB83B0h, 7FFDDBEB83C3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm1,xmm0            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0]        encoding(VEX, 4 bytes) = c5 f9 2e c8
000dh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negativeBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(sbyte src)
; location: [7FFDDBEB83E0h, 7FFDDBEB83F1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(byte src)
; location: [7FFDDBEB8410h, 7FFDDBEB841Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(short src)
; location: [7FFDDBEB8430h, 7FFDDBEB8441h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(ushort src)
; location: [7FFDDBEB8460h, 7FFDDBEB8470h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(int src)
; location: [7FFDDBEB8490h, 7FFDDBEB849Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(uint src)
; location: [7FFDDBEB84B0h, 7FFDDBEB84BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(long src)
; location: [7FFDDBEB84D0h, 7FFDDBEB84DEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(ulong src)
; location: [7FFDDBEB84F0h, 7FFDDBEB84FEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzeroBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero(float src)
; location: [7FFDDBEB8510h, 7FFDDBEB8528h]
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
; location: [7FFDDBEB8540h, 7FFDDBEB8558h]
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
; function: sbyte parse(string src, out sbyte dst)
; location: [7FFDDBEB8570h, 7FFDDBEB8606h]
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
0027h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EE63020h:jmp64]                encoding(5 bytes) = e8 f4 2f e6 5e
002ch mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002fh lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0034h mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0037h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
003ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
003fh lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
0044h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0049h call 7FFE3AD0C710h            ; CALL(Call_rel32_64) [5EE541A0h:jmp64]                encoding(5 bytes) = e8 52 41 e5 5e
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
007bh call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA0A170h:jmp64]        encoding(5 bytes) = e8 f0 a0 a0 ff
0080h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0081h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0086h call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1DD28h:jmp64]        encoding(5 bytes) = e8 9d dc a1 ff
008bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
008ch mov ecx,5                     ; MOV(Mov_r32_imm32) [ECX,5h:imm32]                    encoding(5 bytes) = b9 05 00 00 00
0091h call 7FFDDB8D62A0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1DD30h:jmp64]        encoding(5 bytes) = e8 9a dc a1 ff
0096h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[151]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x56,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xF4,0x2F,0xE6,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0x52,0x41,0xE5,0x5E,0x8B,0xC8,0x85,0xC9,0x75,0x2D,0x8B,0x44,0x24,0x38,0x05,0x80,0x00,0x00,0x00,0x3D,0xFF,0x00,0x00,0x00,0x77,0x28,0x8B,0x44,0x24,0x38,0x48,0x0F,0xBE,0xC0,0x88,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xF0,0xA0,0xA0,0xFF,0xCC,0xBA,0x05,0x00,0x00,0x00,0xE8,0x9D,0xDC,0xA1,0xFF,0xCC,0xB9,0x05,0x00,0x00,0x00,0xE8,0x9A,0xDC,0xA1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte parse(string src, out byte dst)
; location: [7FFDDBEB8620h, 7FFDDBEB86AFh]
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
0027h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EE62F70h:jmp64]                encoding(5 bytes) = e8 44 2f e6 5e
002ch mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002fh lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0034h mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0037h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
003ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
003fh lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
0044h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0049h call 7FFDDB8D6200h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1DBE0h:jmp64]        encoding(5 bytes) = e8 92 db a1 ff
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
0074h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA0A0C0h:jmp64]        encoding(5 bytes) = e8 47 a0 a0 ff
0079h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007ah mov edx,6                     ; MOV(Mov_r32_imm32) [EDX,6h:imm32]                    encoding(5 bytes) = ba 06 00 00 00
007fh call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1DC78h:jmp64]        encoding(5 bytes) = e8 f4 db a1 ff
0084h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0085h mov ecx,6                     ; MOV(Mov_r32_imm32) [ECX,6h:imm32]                    encoding(5 bytes) = b9 06 00 00 00
008ah call 7FFDDB8D62A0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1DC80h:jmp64]        encoding(5 bytes) = e8 f1 db a1 ff
008fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[144]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x4F,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x44,0x2F,0xE6,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0x92,0xDB,0xA1,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x26,0x81,0x7C,0x24,0x38,0xFF,0x00,0x00,0x00,0x77,0x27,0x8B,0x44,0x24,0x38,0x0F,0xB6,0xC0,0x88,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x47,0xA0,0xA0,0xFF,0xCC,0xBA,0x06,0x00,0x00,0x00,0xE8,0xF4,0xDB,0xA1,0xFF,0xCC,0xB9,0x06,0x00,0x00,0x00,0xE8,0xF1,0xDB,0xA1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short parse(string src, out short dst)
; location: [7FFDDBEB86D0h, 7FFDDBEB8767h]
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
0027h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EE62EC0h:jmp64]                encoding(5 bytes) = e8 94 2e e6 5e
002ch mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002fh lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0034h mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0037h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
003ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
003fh lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
0044h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0049h call 7FFE3AD0C710h            ; CALL(Call_rel32_64) [5EE54040h:jmp64]                encoding(5 bytes) = e8 f2 3f e5 5e
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
007ch call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA0A010h:jmp64]        encoding(5 bytes) = e8 8f 9f a0 ff
0081h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0082h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0087h call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1DBC8h:jmp64]        encoding(5 bytes) = e8 3c db a1 ff
008ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
008dh mov ecx,7                     ; MOV(Mov_r32_imm32) [ECX,7h:imm32]                    encoding(5 bytes) = b9 07 00 00 00
0092h call 7FFDDB8D62A0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1DBD0h:jmp64]        encoding(5 bytes) = e8 39 db a1 ff
0097h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[152]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x57,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x94,0x2E,0xE6,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0xF2,0x3F,0xE5,0x5E,0x8B,0xC8,0x85,0xC9,0x75,0x2E,0x8B,0x44,0x24,0x38,0x05,0x00,0x80,0x00,0x00,0x3D,0xFF,0xFF,0x00,0x00,0x77,0x29,0x8B,0x44,0x24,0x38,0x48,0x0F,0xBF,0xC0,0x66,0x89,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x8F,0x9F,0xA0,0xFF,0xCC,0xBA,0x07,0x00,0x00,0x00,0xE8,0x3C,0xDB,0xA1,0xFF,0xCC,0xB9,0x07,0x00,0x00,0x00,0xE8,0x39,0xDB,0xA1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort parse(string src, out ushort dst)
; location: [7FFDDBEB8780h, 7FFDDBEB8810h]
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
0027h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EE62E10h:jmp64]                encoding(5 bytes) = e8 e4 2d e6 5e
002ch mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002fh lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0034h mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0037h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
003ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
003fh lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
0044h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0049h call 7FFDDB8D6200h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1DA80h:jmp64]        encoding(5 bytes) = e8 32 da a1 ff
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
0075h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA09F60h:jmp64]        encoding(5 bytes) = e8 e6 9e a0 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007bh mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
0080h call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1DB18h:jmp64]        encoding(5 bytes) = e8 93 da a1 ff
0085h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0086h mov ecx,8                     ; MOV(Mov_r32_imm32) [ECX,8h:imm32]                    encoding(5 bytes) = b9 08 00 00 00
008bh call 7FFDDB8D62A0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1DB20h:jmp64]        encoding(5 bytes) = e8 90 da a1 ff
0090h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[145]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x50,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xE4,0x2D,0xE6,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0x32,0xDA,0xA1,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x27,0x81,0x7C,0x24,0x38,0xFF,0xFF,0x00,0x00,0x77,0x28,0x8B,0x44,0x24,0x38,0x0F,0xB7,0xC0,0x66,0x89,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xE6,0x9E,0xA0,0xFF,0xCC,0xBA,0x08,0x00,0x00,0x00,0xE8,0x93,0xDA,0xA1,0xFF,0xCC,0xB9,0x08,0x00,0x00,0x00,0xE8,0x90,0xDA,0xA1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int parse(string src, out int dst)
; location: [7FFDDBEB8830h, 7FFDDBEB8884h]
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
002bh call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EE62D60h:jmp64]                encoding(5 bytes) = e8 30 2d e6 5e
0030h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0033h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0038h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003dh call 7FFDDB8D6198h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1D968h:jmp64]        encoding(5 bytes) = e8 26 d9 a1 ff
0042h mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 89 06
0044h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0048h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0049h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004ah mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004fh call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA09EB0h:jmp64]        encoding(5 bytes) = e8 5c 9e a0 ff
0054h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[85]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x31,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x30,0x2D,0xE6,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x26,0xD9,0xA1,0xFF,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x5C,0x9E,0xA0,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint parse(string src, out uint dst)
; location: [7FFDDBEB88A0h, 7FFDDBEB88F4h]
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
002bh call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EE62CF0h:jmp64]                encoding(5 bytes) = e8 c0 2c e6 5e
0030h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0033h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0038h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003dh call 7FFDDB8D61A8h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1D908h:jmp64]        encoding(5 bytes) = e8 c6 d8 a1 ff
0042h mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 89 06
0044h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0048h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0049h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004ah mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004fh call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA09E40h:jmp64]        encoding(5 bytes) = e8 ec 9d a0 ff
0054h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[85]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x31,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xC0,0x2C,0xE6,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0xC6,0xD8,0xA1,0xFF,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xEC,0x9D,0xA0,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long parse(string src, out long dst)
; location: [7FFDDBEB8910h, 7FFDDBEB8965h]
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
002bh call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EE62C80h:jmp64]                encoding(5 bytes) = e8 50 2c e6 5e
0030h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0033h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0038h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003dh call 7FFDDB8D61A0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1D890h:jmp64]        encoding(5 bytes) = e8 4e d8 a1 ff
0042h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0045h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004bh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0050h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA09DD0h:jmp64]        encoding(5 bytes) = e8 7b 9d a0 ff
0055h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[86]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x32,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x50,0x2C,0xE6,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x4E,0xD8,0xA1,0xFF,0x48,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x7B,0x9D,0xA0,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong parse(string src, out ulong dst)
; location: [7FFDDBEB8980h, 7FFDDBEB89D5h]
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
002bh call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EE62C10h:jmp64]                encoding(5 bytes) = e8 e0 2b e6 5e
0030h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0033h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0038h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003dh call 7FFE3ADEB840h            ; CALL(Call_rel32_64) [5EF32EC0h:jmp64]                encoding(5 bytes) = e8 7e 2e f3 5e
0042h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0045h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004bh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0050h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA09D60h:jmp64]        encoding(5 bytes) = e8 0b 9d a0 ff
0055h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[86]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x32,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xE0,0x2B,0xE6,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x7E,0x2E,0xF3,0x5E,0x48,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x0B,0x9D,0xA0,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float parse(string src, out float dst)
; location: [7FFDDBEB89F0h, 7FFDDBEB8A6Dh]
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
0029h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EE62BA0h:jmp64]                encoding(5 bytes) = e8 72 2b e6 5e
002eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0031h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0036h mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0039h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
003ch lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0041h lea r9,[rsp+3Ch]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 3c
0046h mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
004bh call 7FFDDB8D6260h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1D870h:jmp64]        encoding(5 bytes) = e8 20 d8 a1 ff
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
006bh call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA09CF0h:jmp64]        encoding(5 bytes) = e8 80 9c a0 ff
0070h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0071h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0076h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0078h call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1D8A8h:jmp64]        encoding(5 bytes) = e8 2b d8 a1 ff
007dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[126]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x89,0x44,0x24,0x3C,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x44,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x72,0x2B,0xE6,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x3C,0xBA,0xE7,0x00,0x00,0x00,0xE8,0x20,0xD8,0xA1,0xFF,0x85,0xC0,0x74,0x1D,0xC5,0xFA,0x10,0x44,0x24,0x3C,0xC5,0xFA,0x11,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x80,0x9C,0xA0,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0x2B,0xD8,0xA1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double parse(string src, out double dst)
; location: [7FFDDBEB8A90h, 7FFDDBEB8B0Eh]
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
002ah call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EE62B00h:jmp64]                encoding(5 bytes) = e8 d1 2a e6 5e
002fh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0032h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0037h mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
003ah mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
003dh lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0042h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
0047h mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
004ch call 7FFDDB8D6258h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1D7C8h:jmp64]        encoding(5 bytes) = e8 77 d7 a1 ff
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
006ch call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFA09C50h:jmp64]        encoding(5 bytes) = e8 df 9b a0 ff
0071h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0072h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0077h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0079h call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFFA1D808h:jmp64]        encoding(5 bytes) = e8 8a d7 a1 ff
007eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parseBytes => new byte[127]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x44,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xD1,0x2A,0xE6,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0xE7,0x00,0x00,0x00,0xE8,0x77,0xD7,0xA1,0xFF,0x85,0xC0,0x74,0x1D,0xC5,0xFB,0x10,0x44,0x24,0x38,0xC5,0xFB,0x11,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xDF,0x9B,0xA0,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0x8A,0xD7,0xA1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive(sbyte x)
; location: [7FFDDBEB8B30h, 7FFDDBEB8B41h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positiveBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive(byte x)
; location: [7FFDDBEB8B60h, 7FFDDBEB8B6Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positiveBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive(short x)
; location: [7FFDDBEB8B80h, 7FFDDBEB8B91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positiveBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive(ushort x)
; location: [7FFDDBEB8BB0h, 7FFDDBEB8BC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positiveBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive(int x)
; location: [7FFDDBEB8BE0h, 7FFDDBEB8BEDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positiveBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive(uint x)
; location: [7FFDDBEB8C00h, 7FFDDBEB8C0Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positiveBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive(long x)
; location: [7FFDDBEB8C20h, 7FFDDBEB8C2Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positiveBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive(ulong x)
; location: [7FFDDBEB8C40h, 7FFDDBEB8C4Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positiveBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive(float x)
; location: [7FFDDBEB8C60h, 7FFDDBEB8C73h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
000dh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positiveBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive(double x)
; location: [7FFDDBEB8C90h, 7FFDDBEB8CA3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
000dh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positiveBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte pow(sbyte b, uint exp)
; location: [7FFDDBEB8CC0h, 7FFDDBEB8CFCh]
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
; location: [7FFDDBEB8D10h, 7FFDDBEB8D4Ah]
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
; location: [7FFDDBEB8D60h, 7FFDDBEB8D9Ch]
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
; location: [7FFDDBEB8DB0h, 7FFDDBEB8DEAh]
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
; location: [7FFDDBEB8E00h, 7FFDDBEB8E27h]
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
; location: [7FFDDBEB8E40h, 7FFDDBEB8E67h]
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
; location: [7FFDDBEB8E80h, 7FFDDBEB8EA9h]
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
; location: [7FFDDBEB8EC0h, 7FFDDBEB8EE9h]
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
; location: [7FFDDBEB8F00h, 7FFDDBEB8F1Bh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h movsx rcx,byte ptr [rsi]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RSI:br,DS:sr)]      encoding(4 bytes) = 48 0f be 0e
000ch call 7FFDDBEB8CC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFDC0h:jmp64]        encoding(5 bytes) = e8 af fd ff ff
0011h mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]            encoding(2 bytes) = 88 06
0013h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0016h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
001ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[28]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x0F,0xBE,0x0E,0xE8,0xAF,0xFD,0xFF,0xFF,0x88,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte pow(ref byte src, uint exp)
; location: [7FFDDBEB8F30h, 7FFDDBEB8F4Ah]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h movzx ecx,byte ptr [rsi]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSI:br,DS:sr)]      encoding(3 bytes) = 0f b6 0e
000bh call 7FFDDBEB8D10h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFDE0h:jmp64]        encoding(5 bytes) = e8 d0 fd ff ff
0010h mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]            encoding(2 bytes) = 88 06
0012h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0015h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0019h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[27]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x0F,0xB6,0x0E,0xE8,0xD0,0xFD,0xFF,0xFF,0x88,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short pow(ref short src, uint exp)
; location: [7FFDDBEB8F60h, 7FFDDBEB8F7Ch]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h movsx rcx,word ptr [rsi]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RSI:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 0e
000ch call 7FFDDBEB8D60h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE00h:jmp64]        encoding(5 bytes) = e8 ef fd ff ff
0011h mov [rsi],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSI:br,DS:sr),AX]         encoding(3 bytes) = 66 89 06
0014h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0017h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
001bh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[29]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x0F,0xBF,0x0E,0xE8,0xEF,0xFD,0xFF,0xFF,0x66,0x89,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort pow(ref ushort src, uint exp)
; location: [7FFDDBEB8FA0h, 7FFDDBEB8FBBh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h movzx ecx,word ptr [rsi]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RSI:br,DS:sr)]    encoding(3 bytes) = 0f b7 0e
000bh call 7FFDDBEB8DB0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE10h:jmp64]        encoding(5 bytes) = e8 00 fe ff ff
0010h mov [rsi],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSI:br,DS:sr),AX]         encoding(3 bytes) = 66 89 06
0013h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0016h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
001ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[28]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x0F,0xB7,0x0E,0xE8,0x00,0xFE,0xFF,0xFF,0x66,0x89,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int pow(ref int src, uint exp)
; location: [7FFDDBEB8FD0h, 7FFDDBEB8FE9h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov ecx,[rsi]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSI:br,DS:sr)]        encoding(2 bytes) = 8b 0e
000ah call 7FFDDBEB8E00h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE30h:jmp64]        encoding(5 bytes) = e8 21 fe ff ff
000fh mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 89 06
0011h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0014h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0018h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[26]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x8B,0x0E,0xE8,0x21,0xFE,0xFF,0xFF,0x89,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pow(ref uint src, uint exp)
; location: [7FFDDBEB9000h, 7FFDDBEB9019h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov ecx,[rsi]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSI:br,DS:sr)]        encoding(2 bytes) = 8b 0e
000ah call 7FFDDBEB8E40h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE40h:jmp64]        encoding(5 bytes) = e8 31 fe ff ff
000fh mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 89 06
0011h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0014h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0018h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[26]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x8B,0x0E,0xE8,0x31,0xFE,0xFF,0xFF,0x89,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long pow(ref long src, uint exp)
; location: [7FFDDBEB9030h, 7FFDDBEB904Bh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
000bh call 7FFDDBEB8E80h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE50h:jmp64]        encoding(5 bytes) = e8 40 fe ff ff
0010h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0013h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0016h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
001ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[28]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0x0E,0xE8,0x40,0xFE,0xFF,0xFF,0x48,0x89,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong pow(ref ulong src, uint exp)
; location: [7FFDDBEB9060h, 7FFDDBEB907Bh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
000bh call 7FFDDBEB8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE60h:jmp64]        encoding(5 bytes) = e8 50 fe ff ff
0010h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0013h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0016h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
001ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[28]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0x0E,0xE8,0x50,0xFE,0xFF,0xFF,0x48,0x89,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(sbyte src)
; location: [7FFDDBEB9090h, 7FFDDBEB90A7h]
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
; location: [7FFDDBEB90C0h, 7FFDDBEB90CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signumBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(short src)
; location: [7FFDDBEB90E0h, 7FFDDBEB90F7h]
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
; location: [7FFDDBEB9110h, 7FFDDBEB9120h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signumBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(int src)
; location: [7FFDDBEB9140h, 7FFDDBEB9153h]
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
; location: [7FFDDBEB9170h, 7FFDDBEB917Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signumBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum(long src)
; location: [7FFDDBEB9190h, 7FFDDBEB91AAh]
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
; location: [7FFDDBEB91C0h, 7FFDDBEB91CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signumBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short div(ref short lhs, in short rhs)
; location: [7FFDDBEB91E0h, 7FFDDBEB91F7h]
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
; location: [7FFDDBEB9210h, 7FFDDBEB9226h]
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
; location: [7FFDDBEB9240h, 7FFDDBEB9253h]
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
; location: [7FFDDBEB9270h, 7FFDDBEB9284h]
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
; function: ref long div(ref long lhs, in long rhs)
; location: [7FFDDBEB92A0h, 7FFDDBEB92B6h]
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
; location: [7FFDDBEB92D0h, 7FFDDBEB92E6h]
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
; function: bool eq(sbyte lhs, sbyte rhs)
; location: [7FFDDBEB9300h, 7FFDDBEB9315h]
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
; location: [7FFDDBEB9330h, 7FFDDBEB9343h]
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
; location: [7FFDDBEB9360h, 7FFDDBEB9375h]
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
; location: [7FFDDBEB9390h, 7FFDDBEB93A3h]
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
; location: [7FFDDBEB93C0h, 7FFDDBEB93CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq(uint lhs, uint rhs)
; location: [7FFDDBEB93E0h, 7FFDDBEB93EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq(long lhs, long rhs)
; location: [7FFDDBEB9400h, 7FFDDBEB940Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq(ulong lhs, ulong rhs)
; location: [7FFDDBEB9420h, 7FFDDBEB942Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(sbyte lhs, sbyte rhs)
; location: [7FFDDBEB9440h, 7FFDDBEB9455h]
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
; location: [7FFDDBEB9470h, 7FFDDBEB9483h]
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
; location: [7FFDDBEB94A0h, 7FFDDBEB94B5h]
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
; location: [7FFDDBEB94D0h, 7FFDDBEB94E3h]
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
; location: [7FFDDBEB9500h, 7FFDDBEB950Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(uint lhs, uint rhs)
; location: [7FFDDBEB9520h, 7FFDDBEB952Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(long lhs, long rhs)
; location: [7FFDDBEB9540h, 7FFDDBEB954Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq(ulong lhs, ulong rhs)
; location: [7FFDDBEB9560h, 7FFDDBEB956Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte fma(sbyte x, sbyte y, sbyte z)
; location: [7FFDDBEB9580h, 7FFDDBEB959Ah]
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
; location: [7FFDDBEB95B0h, 7FFDDBEB95C7h]
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
; location: [7FFDDBEB95E0h, 7FFDDBEB95FAh]
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
; location: [7FFDDBEB9610h, 7FFDDBEB9627h]
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
; location: [7FFDDBEB9640h, 7FFDDBEB964Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fmaBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0x41,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint fma(uint x, uint y, uint z)
; location: [7FFDDBEB9660h, 7FFDDBEB966Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fmaBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0x41,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long fma(long x, long y, long z)
; location: [7FFDDBEB9680h, 7FFDDBEB968Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fmaBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong fma(ulong x, ulong y, ulong z)
; location: [7FFDDBEB96A0h, 7FFDDBEB96AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fmaBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte gcd(sbyte lhs, sbyte rhs)
; location: [7FFDDBEB96C0h, 7FFDDBEB9703h]
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
; location: [7FFDDBEB9720h, 7FFDDBEB973Ch]
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
; location: [7FFDDBEB9750h, 7FFDDBEB9793h]
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
; location: [7FFDDBEB97B0h, 7FFDDBEB97D2h]
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
; location: [7FFDDBEB97F0h, 7FFDDBEB9819h]
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
; location: [7FFDDBEB9830h, 7FFDDBEB984Ah]
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
; location: [7FFDDBEB9860h, 7FFDDBEB9895h]
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
; location: [7FFDDBEB98B0h, 7FFDDBEB98CBh]
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
; location: [7FFDDBEB98E0h, 7FFDDBEB993Fh]
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
0054h call 7FFDDB8B4E98h            ; CALL(Call_rel32_64) [FFFFFFFFFF9FB5B8h:jmp64]        encoding(5 bytes) = e8 5f b5 9f ff
0059h shl eax,1                     ; SHL(Shl_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e0
005bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdbinBytes => new byte[96]{0x48,0x83,0xEC,0x28,0x90,0x3B,0xCA,0x74,0x3B,0x85,0xC9,0x74,0x3B,0x85,0xD2,0x74,0x3B,0x8B,0xC1,0xF7,0xD0,0xA8,0x01,0x74,0x09,0xF6,0xC2,0x01,0x74,0x32,0xD1,0xE9,0xEB,0xE3,0x8B,0xC2,0xF7,0xD0,0xA8,0x01,0x74,0x04,0xD1,0xEA,0xEB,0xD7,0x3B,0xCA,0x76,0x06,0x2B,0xCA,0xD1,0xE9,0xEB,0xCD,0x2B,0xD1,0xD1,0xEA,0x8B,0xC1,0x8B,0xCA,0x8B,0xD0,0xEB,0xC1,0x8B,0xC1,0xEB,0x13,0x8B,0xC2,0xEB,0x0F,0x8B,0xC1,0xEB,0x0B,0xD1,0xE9,0xD1,0xEA,0xE8,0x5F,0xB5,0x9F,0xFF,0xD1,0xE0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gcdbin(ulong u, ulong v)
; location: [7FFDDBEB9960h, 7FFDDBEB99D7h]
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
006bh call 7FFDDB8B4EA0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9FB540h:jmp64]        encoding(5 bytes) = e8 d0 b4 9f ff
0070h shl rax,1                     ; SHL(Shl_rm64_1) [RAX,1h:imm8]                        encoding(3 bytes) = 48 d1 e0
0073h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0077h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdbinBytes => new byte[120]{0x48,0x83,0xEC,0x28,0x90,0x48,0x3B,0xCA,0x74,0x4C,0x48,0x85,0xC9,0x74,0x4C,0x48,0x85,0xD2,0x74,0x4C,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xA8,0x01,0x74,0x0B,0x8B,0xC2,0xA8,0x01,0x74,0x41,0x48,0xD1,0xE9,0xEB,0xDC,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xA8,0x01,0x74,0x05,0x48,0xD1,0xEA,0xEB,0xCD,0x48,0x3B,0xCA,0x76,0x08,0x48,0x2B,0xCA,0x48,0xD1,0xE9,0xEB,0xC0,0x48,0x2B,0xD1,0x48,0xD1,0xEA,0x48,0x8B,0xC1,0x48,0x8B,0xCA,0x48,0x8B,0xD0,0xEB,0xAF,0x48,0x8B,0xC1,0xEB,0x18,0x48,0x8B,0xC2,0xEB,0x13,0x48,0x8B,0xC1,0xEB,0x0E,0x48,0xD1,0xE9,0x48,0xD1,0xEA,0xE8,0xD0,0xB4,0x9F,0xFF,0x48,0xD1,0xE0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gcdbin(byte u, byte v)
; location: [7FFDDBEB99F0h, 7FFDDBEB9A07h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh call 7FFDDBEB98E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEF0h:jmp64]        encoding(5 bytes) = e8 e0 fe ff ff
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdbinBytes => new byte[24]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0xE8,0xE0,0xFE,0xFF,0xFF,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gcdbin(ushort u, ushort v)
; location: [7FFDDBEB9A20h, 7FFDDBEB9A37h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh call 7FFDDBEB98E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEC0h:jmp64]        encoding(5 bytes) = e8 b0 fe ff ff
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gcdbinBytes => new byte[24]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB7,0xC9,0x0F,0xB7,0xD2,0xE8,0xB0,0xFE,0xFF,0xFF,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt(sbyte lhs, sbyte rhs)
; location: [7FFDDBEB9A50h, 7FFDDBEB9A65h]
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
; location: [7FFDDBEB9A80h, 7FFDDBEB9A93h]
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
; location: [7FFDDBEB9AB0h, 7FFDDBEB9AC5h]
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
; location: [7FFDDBEB9AE0h, 7FFDDBEB9AF3h]
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
; location: [7FFDDBEB9B10h, 7FFDDBEB9B1Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gtBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt(uint lhs, uint rhs)
; location: [7FFDDBEB9B30h, 7FFDDBEB9B3Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gtBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt(long lhs, long rhs)
; location: [7FFDDBEB9B50h, 7FFDDBEB9B5Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gtBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt(ulong lhs, ulong rhs)
; location: [7FFDDBEB9B70h, 7FFDDBEB9B7Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gtBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq(sbyte lhs, sbyte rhs)
; location: [7FFDDBEB9B90h, 7FFDDBEB9BA5h]
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
; location: [7FFDDBEB9BC0h, 7FFDDBEB9BD3h]
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
; location: [7FFDDBEB9BF0h, 7FFDDBEB9C05h]
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
; location: [7FFDDBEB9C20h, 7FFDDBEB9C33h]
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
; location: [7FFDDBEB9C50h, 7FFDDBEB9C5Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq(uint lhs, uint rhs)
; location: [7FFDDBEB9C70h, 7FFDDBEB9C7Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq(long lhs, long rhs)
; location: [7FFDDBEB9C90h, 7FFDDBEB9C9Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq(ulong lhs, ulong rhs)
; location: [7FFDDBEB9CB0h, 7FFDDBEB9CBEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte inc(sbyte src)
; location: [7FFDDBEB9CD0h, 7FFDDBEB9CE3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC0,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte inc(byte src)
; location: [7FFDDBEB9D00h, 7FFDDBEB9D10h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short inc(short src)
; location: [7FFDDBEB9D30h, 7FFDDBEB9D43h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC0,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort inc(ushort src)
; location: [7FFDDBEB9D60h, 7FFDDBEB9D70h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC0,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int inc(int src)
; location: [7FFDDBEB9D90h, 7FFDDBEB9D98h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inc(uint src)
; location: [7FFDDBEB9DB0h, 7FFDDBEB9DB8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long inc(long src)
; location: [7FFDDBEB9DD0h, 7FFDDBEB9DD9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 01
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inc(ulong src)
; location: [7FFDDBEB9DF0h, 7FFDDBEB9DF9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 01
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte inc(ref sbyte src)
; location: [7FFDDBEB9E10h, 7FFDDBEB9E1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc byte ptr [rcx]            ; INC(Inc_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = fe 01
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFE,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte inc(ref byte src)
; location: [7FFDDBEB9E30h, 7FFDDBEB9E3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc byte ptr [rcx]            ; INC(Inc_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = fe 01
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFE,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short inc(ref short src)
; location: [7FFDDBEB9E50h, 7FFDDBEB9E5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc word ptr [rcx]            ; INC(Inc_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 ff 01
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort inc(ref ushort src)
; location: [7FFDDBEB9E70h, 7FFDDBEB9E7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc word ptr [rcx]            ; INC(Inc_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 ff 01
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int inc(ref int src)
; location: [7FFDDBEB9E90h, 7FFDDBEB9E9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc dword ptr [rcx]           ; INC(Inc_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = ff 01
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint inc(ref uint src)
; location: [7FFDDBEB9EB0h, 7FFDDBEB9EBAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc dword ptr [rcx]           ; INC(Inc_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = ff 01
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long inc(ref long src)
; location: [7FFDDBEB9ED0h, 7FFDDBEB9EDBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc qword ptr [rcx]           ; INC(Inc_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 ff 01
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong inc(ref ulong src)
; location: [7FFDDBEB9EF0h, 7FFDDBEB9EFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc qword ptr [rcx]           ; INC(Inc_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 ff 01
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool isPow2(sbyte src)
; location: [7FFDDBEB9F10h, 7FFDDBEB9F24h]
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
; location: [7FFDDBEB9F40h, 7FFDDBEB9F53h]
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
; location: [7FFDDBEB9F70h, 7FFDDBEB9F84h]
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
; location: [7FFDDBEB9FA0h, 7FFDDBEB9FB3h]
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
; location: [7FFDDBEB9FD0h, 7FFDDBEB9FE0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h test ecx,eax                  ; TEST(Test_rm32_r32) [EAX,ECX]                        encoding(2 bytes) = 85 c8
000ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> isPow2Bytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0x85,0xC8,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool isPow2(uint src)
; location: [7FFDDBEBA000h, 7FFDDBEBA010h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h test ecx,eax                  ; TEST(Test_rm32_r32) [EAX,ECX]                        encoding(2 bytes) = 85 c8
000ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> isPow2Bytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0x85,0xC8,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool isPow2(long src)
; location: [7FFDDBEBA030h, 7FFDDBEBA042h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h test rcx,rax                  ; TEST(Test_rm64_r64) [RAX,RCX]                        encoding(3 bytes) = 48 85 c8
000ch sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> isPow2Bytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0x48,0x85,0xC8,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool isPow2(ulong src)
; location: [7FFDDBEBA060h, 7FFDDBEBA072h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h test rcx,rax                  ; TEST(Test_rm64_r64) [RAX,RCX]                        encoding(3 bytes) = 48 85 c8
000ch sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> isPow2Bytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0x48,0x85,0xC8,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong log2(ref ulong dst, ref ulong x, ulong power)
; location: [7FFDDBEBA090h, 7FFDDBEBA0B2h]
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
; location: [7FFDDBEBA0D0h, 7FFDDBEBA174h]
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
; location: [7FFDDBEBA190h, 7FFDDBEBA237h]
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
; location: [7FFDDBEBA250h, 7FFDDBEBA2F6h]
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
; location: [7FFDDBEBA310h, 7FFDDBEBA325h]
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
; location: [7FFDDBEBA340h, 7FFDDBEBA353h]
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
; location: [7FFDDBEBA370h, 7FFDDBEBA385h]
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
; location: [7FFDDBEBA3A0h, 7FFDDBEBA3B3h]
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
; location: [7FFDDBEBA3D0h, 7FFDDBEBA3DDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ltBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt(uint lhs, uint rhs)
; location: [7FFDDBEBA3F0h, 7FFDDBEBA3FDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ltBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt(long lhs, long rhs)
; location: [7FFDDBEBA410h, 7FFDDBEBA41Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ltBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt(ulong lhs, ulong rhs)
; location: [7FFDDBEBA430h, 7FFDDBEBA43Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ltBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq(sbyte lhs, sbyte rhs)
; location: [7FFDDBEBA450h, 7FFDDBEBA465h]
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
; location: [7FFDDBEBA480h, 7FFDDBEBA493h]
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
; location: [7FFDDBEBA4B0h, 7FFDDBEBA4C5h]
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
; location: [7FFDDBEBA4E0h, 7FFDDBEBA4F3h]
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
; location: [7FFDDBEBA510h, 7FFDDBEBA51Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq(uint lhs, uint rhs)
; location: [7FFDDBEBA530h, 7FFDDBEBA53Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteqBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq(long lhs, long rhs)
; location: [7FFDDBEBA550h, 7FFDDBEBA55Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq(ulong lhs, ulong rhs)
; location: [7FFDDBEBA570h, 7FFDDBEBA57Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteqBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte max(sbyte lhs, sbyte rhs)
; location: [7FFDDBEBA590h, 7FFDDBEBA5A4h]
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
; location: [7FFDDBEBA5C0h, 7FFDDBEBA5D2h]
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
; location: [7FFDDBEBA5F0h, 7FFDDBEBA604h]
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
; location: [7FFDDBEBA620h, 7FFDDBEBA632h]
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
; location: [7FFDDBEBA650h, 7FFDDBEBA65Eh]
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
; location: [7FFDDBEBA670h, 7FFDDBEBA67Eh]
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
; location: [7FFDDBEBA690h, 7FFDDBEBA6A1h]
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
; location: [7FFDDBEBA6C0h, 7FFDDBEBA6D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h ja short 000eh                ; JA(Ja_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 77 04
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x77,0x04,0x48,0x8B,0xC2,0xC3,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte max(ref sbyte lhs, sbyte rhs)
; location: [7FFDDBEBA6F0h, 7FFDDBEBA717h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx rax,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 00
000ch movsx r8,dl                   ; MOVSX(Movsx_r64_rm8) [R8,DL]                         encoding(4 bytes) = 4c 0f be c2
0010h cmp eax,r8d                   ; CMP(Cmp_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 3b c0
0013h jg short 001bh                ; JG(Jg_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 7f 06
0015h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0019h jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 07
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh movsx rax,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 00
0022h mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
0024h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xBE,0x00,0x4C,0x0F,0xBE,0xC2,0x41,0x3B,0xC0,0x7F,0x06,0x48,0x0F,0xBE,0xC2,0xEB,0x07,0x48,0x8B,0xC1,0x48,0x0F,0xBE,0x00,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte max(ref byte lhs, byte rhs)
; location: [7FFDDBEBA730h, 7FFDDBEBA754h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 00
000bh movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
000fh cmp eax,r8d                   ; CMP(Cmp_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 3b c0
0012h jg short 0019h                ; JG(Jg_rel8_64) [19h:jmp64]                           encoding(2 bytes) = 7f 05
0014h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0017h jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 06
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 00
001fh mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB6,0x00,0x44,0x0F,0xB6,0xC2,0x41,0x3B,0xC0,0x7F,0x05,0x0F,0xB6,0xC2,0xEB,0x06,0x48,0x8B,0xC1,0x0F,0xB6,0x00,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short max(ref short lhs, short rhs)
; location: [7FFDDBEBA770h, 7FFDDBEBA798h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx rax,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 00
000ch movsx r8,dx                   ; MOVSX(Movsx_r64_rm16) [R8,DX]                        encoding(4 bytes) = 4c 0f bf c2
0010h cmp eax,r8d                   ; CMP(Cmp_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 3b c0
0013h jg short 001bh                ; JG(Jg_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 7f 06
0015h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0019h jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 07
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh movsx rax,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 00
0022h mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0025h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xBF,0x00,0x4C,0x0F,0xBF,0xC2,0x41,0x3B,0xC0,0x7F,0x06,0x48,0x0F,0xBF,0xC2,0xEB,0x07,0x48,0x8B,0xC1,0x48,0x0F,0xBF,0x00,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort max(ref ushort lhs, ushort rhs)
; location: [7FFDDBEBA7B0h, 7FFDDBEBA7D5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx eax,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 00
000bh movzx r8d,dx                  ; MOVZX(Movzx_r32_rm16) [R8D,DX]                       encoding(4 bytes) = 44 0f b7 c2
000fh cmp eax,r8d                   ; CMP(Cmp_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 3b c0
0012h jg short 0019h                ; JG(Jg_rel8_64) [19h:jmp64]                           encoding(2 bytes) = 7f 05
0014h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0017h jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 06
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch movzx eax,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 00
001fh mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0022h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB7,0x00,0x44,0x0F,0xB7,0xC2,0x41,0x3B,0xC0,0x7F,0x05,0x0F,0xB7,0xC2,0xEB,0x06,0x48,0x8B,0xC1,0x0F,0xB7,0x00,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int max(ref int lhs, int rhs)
; location: [7FFDDBEBA7F0h, 7FFDDBEBA808h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h cmp [rax],edx                 ; CMP(Cmp_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 39 10
000ah jg short 000eh                ; JG(Jg_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 7f 02
000ch jmp short 0013h               ; JMP(Jmp_rel8_64) [13h:jmp64]                         encoding(2 bytes) = eb 05
000eh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0011h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0013h mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x39,0x10,0x7F,0x02,0xEB,0x05,0x48,0x8B,0xD1,0x8B,0x12,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint max(ref uint lhs, uint rhs)
; location: [7FFDDBEBA820h, 7FFDDBEBA838h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h cmp [rax],edx                 ; CMP(Cmp_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 39 10
000ah ja short 000eh                ; JA(Ja_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 77 02
000ch jmp short 0013h               ; JMP(Jmp_rel8_64) [13h:jmp64]                         encoding(2 bytes) = eb 05
000eh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0011h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0013h mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x39,0x10,0x77,0x02,0xEB,0x05,0x48,0x8B,0xD1,0x8B,0x12,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long max(ref long lhs, long rhs)
; location: [7FFDDBEBA850h, 7FFDDBEBA86Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h cmp [rax],rdx                 ; CMP(Cmp_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 39 10
000bh jg short 000fh                ; JG(Jg_rel8_64) [Fh:jmp64]                            encoding(2 bytes) = 7f 02
000dh jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 06
000fh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0012h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0015h mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x39,0x10,0x7F,0x02,0xEB,0x06,0x48,0x8B,0xD1,0x48,0x8B,0x12,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong max(ref ulong lhs, ulong rhs)
; location: [7FFDDBEBA880h, 7FFDDBEBA89Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h cmp [rax],rdx                 ; CMP(Cmp_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 39 10
000bh ja short 000fh                ; JA(Ja_rel8_64) [Fh:jmp64]                            encoding(2 bytes) = 77 02
000dh jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 06
000fh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0012h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0015h mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x39,0x10,0x77,0x02,0xEB,0x06,0x48,0x8B,0xD1,0x48,0x8B,0x12,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte min(sbyte lhs, sbyte rhs)
; location: [7FFDDBEBA8B0h, 7FFDDBEBA8C4h]
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
; location: [7FFDDBEBA8E0h, 7FFDDBEBA8F2h]
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
; location: [7FFDDBEBA910h, 7FFDDBEBA924h]
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
; location: [7FFDDBEBA940h, 7FFDDBEBA952h]
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
; location: [7FFDDBEBA970h, 7FFDDBEBA97Eh]
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
; location: [7FFDDBEBA990h, 7FFDDBEBA99Eh]
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
; location: [7FFDDBEBA9B0h, 7FFDDBEBA9C1h]
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
; location: [7FFDDBEBA9E0h, 7FFDDBEBA9F1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jb short 000eh                ; JB(Jb_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 72 04
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x04,0x48,0x8B,0xC2,0xC3,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte min(ref sbyte lhs, sbyte rhs)
; location: [7FFDDBEBAA10h, 7FFDDBEBAA37h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx rax,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 00
000ch movsx r8,dl                   ; MOVSX(Movsx_r64_rm8) [R8,DL]                         encoding(4 bytes) = 4c 0f be c2
0010h cmp eax,r8d                   ; CMP(Cmp_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 3b c0
0013h jl short 001bh                ; JL(Jl_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 7c 06
0015h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0019h jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 07
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh movsx rax,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 00
0022h mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
0024h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xBE,0x00,0x4C,0x0F,0xBE,0xC2,0x41,0x3B,0xC0,0x7C,0x06,0x48,0x0F,0xBE,0xC2,0xEB,0x07,0x48,0x8B,0xC1,0x48,0x0F,0xBE,0x00,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte min(ref byte lhs, byte rhs)
; location: [7FFDDBEBAA50h, 7FFDDBEBAA74h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 00
000bh movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
000fh cmp eax,r8d                   ; CMP(Cmp_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 3b c0
0012h jl short 0019h                ; JL(Jl_rel8_64) [19h:jmp64]                           encoding(2 bytes) = 7c 05
0014h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0017h jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 06
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 00
001fh mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB6,0x00,0x44,0x0F,0xB6,0xC2,0x41,0x3B,0xC0,0x7C,0x05,0x0F,0xB6,0xC2,0xEB,0x06,0x48,0x8B,0xC1,0x0F,0xB6,0x00,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long srl(long src, int offset)
; location: [7FFDDBEBAA90h, 7FFDDBEBAA9Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl(ulong src, int offset)
; location: [7FFDDBEBAAB0h, 7FFDDBEBAABDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte srl(ref sbyte src, int offset)
; location: [7FFDDBEBAAD0h, 7FFDDBEBAAE4h]
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
; location: [7FFDDBEBAB00h, 7FFDDBEBAB14h]
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
; location: [7FFDDBEBAB30h, 7FFDDBEBAB45h]
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
; location: [7FFDDBEBAB60h, 7FFDDBEBAB75h]
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
; location: [7FFDDBEBAB90h, 7FFDDBEBABA3h]
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
; location: [7FFDDBEBABC0h, 7FFDDBEBABD3h]
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
; location: [7FFDDBEBABF0h, 7FFDDBEBAC03h]
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
; location: [7FFDDBEBAC20h, 7FFDDBEBAC33h]
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
; location: [7FFDDBEBAC50h, 7FFDDBEBAC5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint srl32u(uint src, int offset)
; location: [7FFDDBEBAC70h, 7FFDDBEBAC7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long srl64i(long src, int offset)
; location: [7FFDDBEBAC90h, 7FFDDBEBAC9Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl64u(ulong src, int offset)
; location: [7FFDDBEBACB0h, 7FFDDBEBACBDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xor(sbyte lhs, sbyte rhs)
; location: [7FFDDBEBACD0h, 7FFDDBEBACE3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xor(byte lhs, byte rhs)
; location: [7FFDDBEBAD00h, 7FFDDBEBAD10h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xor(short lhs, short rhs)
; location: [7FFDDBEBAD30h, 7FFDDBEBAD43h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xor(ushort lhs, ushort rhs)
; location: [7FFDDBEBAD60h, 7FFDDBEBAD70h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xor(int lhs, int rhs)
; location: [7FFDDBEBAD90h, 7FFDDBEBAD99h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xor(uint lhs, uint rhs)
; location: [7FFDDBEBADB0h, 7FFDDBEBADB9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xor(long lhs, long rhs)
; location: [7FFDDBEBADD0h, 7FFDDBEBADDBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor(ulong lhs, ulong rhs)
; location: [7FFDDBEBADF0h, 7FFDDBEBADFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte xor(ref sbyte lhs, sbyte rhs)
; location: [7FFDDBEBAE10h, 7FFDDBEBAE1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h xor [rcx],al                  ; XOR(Xor_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 30 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x30,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte xor(ref byte lhs, byte rhs)
; location: [7FFDDBEBAE30h, 7FFDDBEBAE3Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h xor [rcx],al                  ; XOR(Xor_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 30 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x30,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short xor(ref short lhs, short rhs)
; location: [7FFDDBEBAE50h, 7FFDDBEBAE5Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h xor [rcx],ax                  ; XOR(Xor_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 31 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x66,0x31,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort xor(ref ushort lhs, ushort rhs)
; location: [7FFDDBEBAE70h, 7FFDDBEBAE7Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h xor [rcx],ax                  ; XOR(Xor_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 31 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x66,0x31,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int xor(ref int lhs, int rhs)
; location: [7FFDDBEBAE90h, 7FFDDBEBAE9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor [rcx],edx                 ; XOR(Xor_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 31 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x31,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint xor(ref uint lhs, uint rhs)
; location: [7FFDDBEBAEB0h, 7FFDDBEBAEBAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor [rcx],edx                 ; XOR(Xor_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 31 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x31,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long xor(ref long lhs, long rhs)
; location: [7FFDDBEBAED0h, 7FFDDBEBAEDBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor [rcx],rdx                 ; XOR(Xor_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 31 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x31,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong xor(ref ulong lhs, ulong rhs)
; location: [7FFDDBEBAEF0h, 7FFDDBEBAEFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor [rcx],rdx                 ; XOR(Xor_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 31 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x31,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte xor(in sbyte lhs, in sbyte rhs, ref sbyte dst)
; location: [7FFDDBEBAF10h, 7FFDDBEBAF25h]
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
; location: [7FFDDBEBAF40h, 7FFDDBEBAF53h]
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
; location: [7FFDDBEBAF70h, 7FFDDBEBAF86h]
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
; location: [7FFDDBEBAFA0h, 7FFDDBEBAFB4h]
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
; location: [7FFDDBEBAFD0h, 7FFDDBEBAFDFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h xor eax,[rdx]                 ; XOR(Xor_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 33 02
0009h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x33,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint xor(in uint lhs, in uint rhs, ref uint dst)
; location: [7FFDDBEBAFF0h, 7FFDDBEBAFFFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h xor eax,[rdx]                 ; XOR(Xor_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 33 02
0009h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x33,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long xor(in long lhs, in long rhs, ref long dst)
; location: [7FFDDBEBB010h, 7FFDDBEBB021h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h xor rax,[rdx]                 ; XOR(Xor_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 33 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x33,0x02,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong xor(in ulong lhs, in ulong rhs, ref ulong dst)
; location: [7FFDDBEBB040h, 7FFDDBEBB051h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h xor rax,[rdx]                 ; XOR(Xor_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 33 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x33,0x02,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float xor(in float lhs, in float rhs, ref float dst)
; location: [7FFDDBEBB070h, 7FFDDBEBB0A9h]
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
; location: [7FFDDBEBB0D0h, 7FFDDBEBB10Ah]
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
; function: bool divides(sbyte lhs, sbyte rhs)
; location: [7FFDDBEBB130h, 7FFDDBEBB148h]
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
; location: [7FFDDBEBB160h, 7FFDDBEBB176h]
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
; location: [7FFDDBEBB190h, 7FFDDBEBB1A8h]
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
; location: [7FFDDBEBB1C0h, 7FFDDBEBB1D6h]
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
; location: [7FFDDBEBB1F0h, 7FFDDBEBB202h]
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
; location: [7FFDDBEBB220h, 7FFDDBEBB233h]
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
; location: [7FFDDBEBB250h, 7FFDDBEBB266h]
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
; location: [7FFDDBEBB280h, 7FFDDBEBB296h]
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
; function: sbyte abs(sbyte src)
; location: [7FFDDBEBB2B0h, 7FFDDBEBB2C6h]
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
; location: [7FFDDBEBB2E0h, 7FFDDBEBB2F6h]
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
; location: [7FFDDBEBB310h, 7FFDDBEBB31Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
000ah lea edx,[rcx+rax]             ; LEA(Lea_r32_m) [EDX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 14 01
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x8D,0x14,0x01,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long abs(long src)
; location: [7FFDDBEBB330h, 7FFDDBEBB343h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sar rax,3Fh                   ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f8 3f
000ch lea rdx,[rcx+rax]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 14 01
0010h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xF8,0x3F,0x48,0x8D,0x14,0x01,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float abs(float src)
; location: [7FFDDBEBB4C0h, 7FFDDBEBB4D1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFDDBEBB4D8h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vandps xmm0,xmm0,xmm1         ; VANDPS(VEX_Vandps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 54 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x54,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double abs(double src)
; location: [7FFDDBEBB4F0h, 7FFDDBEBB501h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFDDBEBB508h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vandps xmm0,xmm0,xmm1         ; VANDPS(VEX_Vandps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 54 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> absBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x54,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte abs(ref sbyte src)
; location: [7FFDDBEBB520h, 7FFDDBEBB537h]
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
; location: [7FFDDBEBB550h, 7FFDDBEBB568h]
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
; location: [7FFDDBEBB580h, 7FFDDBEBB595h]
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
; location: [7FFDDBEBB5B0h, 7FFDDBEBB5CBh]
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
; function: sbyte add(sbyte lhs, sbyte rhs)
; location: [7FFDDBEBB5E0h, 7FFDDBEBB5F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte add(byte lhs, byte rhs)
; location: [7FFDDBEBB610h, 7FFDDBEBB620h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short add(short lhs, short rhs)
; location: [7FFDDBEBB640h, 7FFDDBEBB653h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort add(ushort lhs, ushort rhs)
; location: [7FFDDBEBB670h, 7FFDDBEBB680h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add(int lhs, int rhs)
; location: [7FFDDBEBB6A0h, 7FFDDBEBB6A8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add(uint lhs, uint rhs)
; location: [7FFDDBEBB6C0h, 7FFDDBEBB6C8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long add(long lhs, long rhs)
; location: [7FFDDBEBB6E0h, 7FFDDBEBB6E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong add(ulong lhs, ulong rhs)
; location: [7FFDDBEBB700h, 7FFDDBEBB709h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte add(ref sbyte lhs, sbyte rhs)
; location: [7FFDDBEBB720h, 7FFDDBEBB72Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h add [rcx],al                  ; ADD(Add_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 00 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x00,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte add(ref byte lhs, byte rhs)
; location: [7FFDDBEBB740h, 7FFDDBEBB74Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h add [rcx],al                  ; ADD(Add_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 00 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x00,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short add(ref short lhs, short rhs)
; location: [7FFDDBEBB760h, 7FFDDBEBB76Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h add [rcx],ax                  ; ADD(Add_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 01 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x66,0x01,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort add(ref ushort lhs, ushort rhs)
; location: [7FFDDBEBB780h, 7FFDDBEBB78Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h add [rcx],ax                  ; ADD(Add_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 01 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x66,0x01,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int add(ref int lhs, int rhs)
; location: [7FFDDBEBB7A0h, 7FFDDBEBB7AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add [rcx],edx                 ; ADD(Add_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 01 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x01,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint add(ref uint lhs, uint rhs)
; location: [7FFDDBEBB7C0h, 7FFDDBEBB7CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add [rcx],edx                 ; ADD(Add_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 01 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x01,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long add(ref long lhs, long rhs)
; location: [7FFDDBEBB7E0h, 7FFDDBEBB7EBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add [rcx],rdx                 ; ADD(Add_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 01 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x01,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong add(ref ulong lhs, ulong rhs)
; location: [7FFDDBEBB800h, 7FFDDBEBB80Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add [rcx],rdx                 ; ADD(Add_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 01 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x01,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte avgz(byte lhs, byte rhs)
; location: [7FFDDBEBB820h, 7FFDDBEBB838h]
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
; location: [7FFDDBEBB850h, 7FFDDBEBB868h]
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
; location: [7FFDDBEBB880h, 7FFDDBEBB88Fh]
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
; location: [7FFDDBEBB8A0h, 7FFDDBEBB8B4h]
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
; location: [7FFDDBEBB8D0h, 7FFDDBEBB8EDh]
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
; location: [7FFDDBEBB900h, 7FFDDBEBB91Eh]
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
; location: [7FFDDBEBB930h, 7FFDDBEBB94Bh]
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
; location: [7FFDDBEBB960h, 7FFDDBEBB980h]
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
; function: byte avgi(byte lhs, byte rhs)
; location: [7FFDDBEBB9A0h, 7FFDDBEBB9B8h]
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
; location: [7FFDDBEBB9D0h, 7FFDDBEBB9E8h]
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
; location: [7FFDDBEBBA00h, 7FFDDBEBBA0Fh]
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
; location: [7FFDDBEBBA20h, 7FFDDBEBBA34h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000eh shr rdx,1                     ; SHR(Shr_rm64_1) [RDX,1h:imm8]                        encoding(3 bytes) = 48 d1 ea
0011h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgiBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0x48,0x33,0xD1,0x48,0xD1,0xEA,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between(byte x, byte a, byte b)
; location: [7FFDDBEBBA50h, 7FFDDBEBBA6Eh]
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
; location: [7FFDDBEBBA80h, 7FFDDBEBBAA0h]
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
; location: [7FFDDBEBBAC0h, 7FFDDBEBBAE0h]
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
; location: [7FFDDBEBBB00h, 7FFDDBEBBB1Eh]
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
; location: [7FFDDBEBBB30h, 7FFDDBEBBB45h]
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
; location: [7FFDDBEBBB60h, 7FFDDBEBBB75h]
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
; location: [7FFDDBEBBB90h, 7FFDDBEBBBA6h]
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
; location: [7FFDDBEBBBC0h, 7FFDDBEBBBD6h]
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
; location: [7FFDDBEBBBF0h, 7FFDDBEBBBFFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte dec(byte src)
; location: [7FFDDBEBBC10h, 7FFDDBEBBC1Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short dec(short src)
; location: [7FFDDBEBBC30h, 7FFDDBEBBC3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort dec(ushort src)
; location: [7FFDDBEBBC50h, 7FFDDBEBBC5Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int dec(int src)
; location: [7FFDDBEBBC70h, 7FFDDBEBBC78h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dec(uint src)
; location: [7FFDDBEBBC90h, 7FFDDBEBBC98h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long dec(long src)
; location: [7FFDDBEBBCB0h, 7FFDDBEBBCB9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dec(ulong src)
; location: [7FFDDBEBBCD0h, 7FFDDBEBBCD9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte dec(ref sbyte src)
; location: [7FFDDBEBBCF0h, 7FFDDBEBBCFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec byte ptr [rcx]            ; DEC(Dec_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = fe 09
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFE,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte dec(ref byte src)
; location: [7FFDDBEBBD10h, 7FFDDBEBBD1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec byte ptr [rcx]            ; DEC(Dec_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = fe 09
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFE,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short dec(ref short src)
; location: [7FFDDBEBBD30h, 7FFDDBEBBD3Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec word ptr [rcx]            ; DEC(Dec_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 ff 09
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort dec(ref ushort src)
; location: [7FFDDBEBBD50h, 7FFDDBEBBD5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec word ptr [rcx]            ; DEC(Dec_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 ff 09
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int dec(ref int src)
; location: [7FFDDBEBBD70h, 7FFDDBEBBD7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec dword ptr [rcx]           ; DEC(Dec_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = ff 09
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint dec(ref uint src)
; location: [7FFDDBEBBD90h, 7FFDDBEBBD9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec dword ptr [rcx]           ; DEC(Dec_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = ff 09
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long dec(ref long src)
; location: [7FFDDBEBBDB0h, 7FFDDBEBBDBBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec qword ptr [rcx]           ; DEC(Dec_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 ff 09
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong dec(ref ulong src)
; location: [7FFDDBEBBDD0h, 7FFDDBEBBDDBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec qword ptr [rcx]           ; DEC(Dec_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 ff 09
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist(byte a, byte b)
; location: [7FFDDBEBBDF0h, 7FFDDBEBBE0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
0011h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0015h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0017h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0x3B,0xCA,0x7D,0x06,0x2B,0xD1,0x48,0x63,0xC2,0xC3,0x2B,0xCA,0x48,0x63,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist(sbyte a, sbyte b)
; location: [7FFDDBEBBE20h, 7FFDDBEBBE3Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
000fh jge short 0017h               ; JGE(Jge_rel8_64) [17h:jmp64]                         encoding(2 bytes) = 7d 06
0011h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
0013h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0017h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0019h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC9,0x48,0x0F,0xBE,0xD2,0x3B,0xCA,0x7D,0x06,0x2B,0xD1,0x48,0x63,0xC2,0xC3,0x2B,0xCA,0x48,0x63,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist(short a, short b)
; location: [7FFDDBEBBE50h, 7FFDDBEBBE6Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
000fh jge short 0017h               ; JGE(Jge_rel8_64) [17h:jmp64]                         encoding(2 bytes) = 7d 06
0011h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
0013h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0017h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0019h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC9,0x48,0x0F,0xBF,0xD2,0x3B,0xCA,0x7D,0x06,0x2B,0xD1,0x48,0x63,0xC2,0xC3,0x2B,0xCA,0x48,0x63,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist(ushort a, ushort b)
; location: [7FFDDBEBBE80h, 7FFDDBEBBE9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
0011h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0015h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0017h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC9,0x0F,0xB7,0xD2,0x3B,0xCA,0x7D,0x06,0x2B,0xD1,0x48,0x63,0xC2,0xC3,0x2B,0xCA,0x48,0x63,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist(int a, int b)
; location: [7FFDDBEBBEB0h, 7FFDDBEBBEC4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jge short 000fh               ; JGE(Jge_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 7d 06
0009h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
000bh movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000fh sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0011h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7D,0x06,0x2B,0xD1,0x48,0x63,0xC2,0xC3,0x2B,0xCA,0x48,0x63,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist(uint a, uint b)
; location: [7FFDDBEBBEE0h, 7FFDDBEBBEF2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jae short 000eh               ; JAE(Jae_rel8_64) [Eh:jmp64]                          encoding(2 bytes) = 73 05
0009h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
000bh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000eh sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0010h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x73,0x05,0x2B,0xD1,0x8B,0xC2,0xC3,0x2B,0xCA,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist(long a, long b)
; location: [7FFDDBEBBF10h, 7FFDDBEBBF27h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jge short 0011h               ; JGE(Jge_rel8_64) [11h:jmp64]                         encoding(2 bytes) = 7d 07
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh sub rax,rcx                   ; SUB(Sub_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 2b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0011h sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
0014h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7D,0x07,0x48,0x8B,0xC2,0x48,0x2B,0xC1,0xC3,0x48,0x2B,0xCA,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist(ulong a, ulong b)
; location: [7FFDDBEBBF40h, 7FFDDBEBBF57h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jae short 0011h               ; JAE(Jae_rel8_64) [11h:jmp64]                         encoding(2 bytes) = 73 07
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh sub rax,rcx                   ; SUB(Sub_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 2b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0011h sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
0014h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x73,0x07,0x48,0x8B,0xC2,0x48,0x2B,0xC1,0xC3,0x48,0x2B,0xCA,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte div(sbyte lhs, sbyte rhs)
; location: [7FFDDBEBBF70h, 7FFDDBEBBF84h]
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
; location: [7FFDDBEBBFA0h, 7FFDDBEBBFB1h]
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
; location: [7FFDDBEBBFD0h, 7FFDDBEBBFE4h]
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
; location: [7FFDDBEBC000h, 7FFDDBEBC011h]
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
; location: [7FFDDBEBC030h, 7FFDDBEBC03Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div(uint lhs, uint rhs)
; location: [7FFDDBEBC050h, 7FFDDBEBC05Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long div(long lhs, long rhs)
; location: [7FFDDBEBC070h, 7FFDDBEBC080h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong div(ulong lhs, ulong rhs)
; location: [7FFDDBEBC0A0h, 7FFDDBEBC0B0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte div(ref sbyte lhs, in sbyte rhs)
; location: [7FFDDBEBC0D0h, 7FFDDBEBC0E6h]
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
; location: [7FFDDBEBC100h, 7FFDDBEBC115h]
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
; function: sbyte and(sbyte lhs, sbyte rhs)
; location: [7FFDDBEBC130h, 7FFDDBEBC143h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x23,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte and(byte lhs, byte rhs)
; location: [7FFDDBEBC160h, 7FFDDBEBC170h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short and(short lhs, short rhs)
; location: [7FFDDBEBC190h, 7FFDDBEBC1A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x23,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort and(ushort lhs, ushort rhs)
; location: [7FFDDBEBC1C0h, 7FFDDBEBC1D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x23,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int and(int lhs, int rhs)
; location: [7FFDDBEBC1F0h, 7FFDDBEBC1F9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and(uint lhs, uint rhs)
; location: [7FFDDBEBC210h, 7FFDDBEBC219h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long and(long lhs, long rhs)
; location: [7FFDDBEBC230h, 7FFDDBEBC23Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong and(ulong lhs, ulong rhs)
; location: [7FFDDBEBC250h, 7FFDDBEBC25Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float and(float lhs, float rhs)
; location: [7FFDDBEBC270h, 7FFDDBEBC299h]
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
; location: [7FFDDBEBC2C0h, 7FFDDBEBC2EAh]
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
; location: [7FFDDBEBC310h, 7FFDDBEBC325h]
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
; location: [7FFDDBEBC340h, 7FFDDBEBC353h]
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
; location: [7FFDDBEBC370h, 7FFDDBEBC386h]
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
; location: [7FFDDBEBC3A0h, 7FFDDBEBC3B4h]
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
; location: [7FFDDBEBC3D0h, 7FFDDBEBC3DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h and eax,[rdx]                 ; AND(And_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 23 02
0009h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x23,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint and(in uint lhs, in uint rhs, ref uint dst)
; location: [7FFDDBEBC3F0h, 7FFDDBEBC3FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h and eax,[rdx]                 ; AND(And_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 23 02
0009h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x23,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long and(in long lhs, in long rhs, ref long dst)
; location: [7FFDDBEBC410h, 7FFDDBEBC421h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h and rax,[rdx]                 ; AND(And_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 23 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x23,0x02,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong and(in ulong lhs, in ulong rhs, ref ulong dst)
; location: [7FFDDBEBC440h, 7FFDDBEBC451h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h and rax,[rdx]                 ; AND(And_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 23 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x23,0x02,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float and(in float lhs, in float rhs, ref float dst)
; location: [7FFDDBEBC470h, 7FFDDBEBC4A9h]
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
; location: [7FFDDBEBC4D0h, 7FFDDBEBC50Ah]
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
; location: [7FFDDBEBC530h, 7FFDDBEBC53Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h and [rcx],al                  ; AND(And_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 20 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x20,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte and(ref byte lhs, byte rhs)
; location: [7FFDDBEBC550h, 7FFDDBEBC55Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h and [rcx],al                  ; AND(And_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 20 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x20,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short and(ref short lhs, short rhs)
; location: [7FFDDBEBC570h, 7FFDDBEBC57Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h and [rcx],ax                  ; AND(And_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 21 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x66,0x21,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort and(ref ushort lhs, ushort rhs)
; location: [7FFDDBEBC590h, 7FFDDBEBC59Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h and [rcx],ax                  ; AND(And_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 21 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x66,0x21,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int and(ref int lhs, int rhs)
; location: [7FFDDBEBC5B0h, 7FFDDBEBC5BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and [rcx],edx                 ; AND(And_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 21 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x21,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint and(ref uint lhs, uint rhs)
; location: [7FFDDBEBC5D0h, 7FFDDBEBC5DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and [rcx],edx                 ; AND(And_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 21 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x21,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long and(ref long lhs, long rhs)
; location: [7FFDDBEBC5F0h, 7FFDDBEBC5FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and [rcx],rdx                 ; AND(And_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 21 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x21,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong and(ref ulong lhs, ulong rhs)
; location: [7FFDDBEBC610h, 7FFDDBEBC61Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and [rcx],rdx                 ; AND(And_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 21 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x21,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float and(ref float lhs, float rhs)
; location: [7FFDDBEBC630h, 7FFDDBEBC664h]
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
; location: [7FFDDBEBC680h, 7FFDDBEBC6B5h]
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
; function: sbyte flip(sbyte src)
; location: [7FFDDBEBC6D0h, 7FFDDBEBC6DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte flip(byte src)
; location: [7FFDDBEBC6F0h, 7FFDDBEBC6FDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short flip(short src)
; location: [7FFDDBEBC710h, 7FFDDBEBC71Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort flip(ushort src)
; location: [7FFDDBEBC730h, 7FFDDBEBC73Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int flip(int src)
; location: [7FFDDBEBC750h, 7FFDDBEBC759h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint flip(uint src)
; location: [7FFDDBEBC770h, 7FFDDBEBC779h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long flip(long src)
; location: [7FFDDBEBC790h, 7FFDDBEBC79Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong flip(ulong src)
; location: [7FFDDBEBC7B0h, 7FFDDBEBC7BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte flip(ref sbyte src)
; location: [7FFDDBEBC7D0h, 7FFDDBEBC7DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not byte ptr [rcx]            ; NOT(Not_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = f6 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte flip(ref byte src)
; location: [7FFDDBEBC7F0h, 7FFDDBEBC7FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not byte ptr [rcx]            ; NOT(Not_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = f6 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short flip(ref short src)
; location: [7FFDDBEBC810h, 7FFDDBEBC81Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not word ptr [rcx]            ; NOT(Not_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 f7 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort flip(ref ushort src)
; location: [7FFDDBEBC830h, 7FFDDBEBC83Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not word ptr [rcx]            ; NOT(Not_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 f7 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int flip(ref int src)
; location: [7FFDDBEBC850h, 7FFDDBEBC85Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not dword ptr [rcx]           ; NOT(Not_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = f7 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint flip(ref uint src)
; location: [7FFDDBEBC870h, 7FFDDBEBC87Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not dword ptr [rcx]           ; NOT(Not_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = f7 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long flip(ref long src)
; location: [7FFDDBEBC890h, 7FFDDBEBC89Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not qword ptr [rcx]           ; NOT(Not_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 f7 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong flip(ref ulong src)
; location: [7FFDDBEBC8B0h, 7FFDDBEBC8BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not qword ptr [rcx]           ; NOT(Not_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 f7 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte or(sbyte lhs, sbyte rhs)
; location: [7FFDDBEBC8D0h, 7FFDDBEBC8E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte or(byte lhs, byte rhs)
; location: [7FFDDBEBC900h, 7FFDDBEBC910h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short or(short lhs, short rhs)
; location: [7FFDDBEBC930h, 7FFDDBEBC943h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort or(ushort lhs, ushort rhs)
; location: [7FFDDBEBC960h, 7FFDDBEBC970h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int or(int lhs, int rhs)
; location: [7FFDDBEBC990h, 7FFDDBEBC999h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint or(uint lhs, uint rhs)
; location: [7FFDDBEBC9B0h, 7FFDDBEBC9B9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long or(long lhs, long rhs)
; location: [7FFDDBEBC9D0h, 7FFDDBEBC9DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong or(ulong lhs, ulong rhs)
; location: [7FFDDBEBC9F0h, 7FFDDBEBC9FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float or(float lhs, float rhs)
; location: [7FFDDBEBCA10h, 7FFDDBEBCA39h]
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
; location: [7FFDDBEBCA60h, 7FFDDBEBCA8Ah]
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
; location: [7FFDDBEBCAB0h, 7FFDDBEBCABEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h or [rcx],al                   ; OR(Or_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]              encoding(2 bytes) = 08 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x08,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte or(ref byte lhs, byte rhs)
; location: [7FFDDBEBCAD0h, 7FFDDBEBCADDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h or [rcx],al                   ; OR(Or_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]              encoding(2 bytes) = 08 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x08,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short or(ref short lhs, short rhs)
; location: [7FFDDBEBCAF0h, 7FFDDBEBCAFFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h or [rcx],ax                   ; OR(Or_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]           encoding(3 bytes) = 66 09 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x66,0x09,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort or(ref ushort lhs, ushort rhs)
; location: [7FFDDBEBCB10h, 7FFDDBEBCB1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h or [rcx],ax                   ; OR(Or_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]           encoding(3 bytes) = 66 09 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x66,0x09,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int or(ref int lhs, int rhs)
; location: [7FFDDBEBCB30h, 7FFDDBEBCB3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or [rcx],edx                  ; OR(Or_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]          encoding(2 bytes) = 09 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x09,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint or(ref uint lhs, uint rhs)
; location: [7FFDDBEBCB50h, 7FFDDBEBCB5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or [rcx],edx                  ; OR(Or_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]          encoding(2 bytes) = 09 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x09,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long or(ref long lhs, long rhs)
; location: [7FFDDBEBCB70h, 7FFDDBEBCB7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or [rcx],rdx                  ; OR(Or_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x09,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong or(ref ulong lhs, ulong rhs)
; location: [7FFDDBEBCB90h, 7FFDDBEBCB9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or [rcx],rdx                  ; OR(Or_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x09,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float or(ref float lhs, float rhs)
; location: [7FFDDBEBCBB0h, 7FFDDBEBCBE4h]
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
; location: [7FFDDBEBCC00h, 7FFDDBEBCC35h]
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
; location: [7FFDDBEBCC50h, 7FFDDBEBCC65h]
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
; location: [7FFDDBEBCC80h, 7FFDDBEBCC93h]
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
; location: [7FFDDBEBCCB0h, 7FFDDBEBCCC6h]
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
; location: [7FFDDBEBCCE0h, 7FFDDBEBCCF4h]
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
; location: [7FFDDBEBCD10h, 7FFDDBEBCD1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h or eax,[rdx]                  ; OR(Or_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]          encoding(2 bytes) = 0b 02
0009h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x0B,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint or(in uint lhs, in uint rhs, ref uint dst)
; location: [7FFDDBEBCD30h, 7FFDDBEBCD3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h or eax,[rdx]                  ; OR(Or_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]          encoding(2 bytes) = 0b 02
0009h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x0B,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long or(in long lhs, in long rhs, ref long dst)
; location: [7FFDDBEBCD50h, 7FFDDBEBCD61h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h or rax,[rdx]                  ; OR(Or_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]          encoding(3 bytes) = 48 0b 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x0B,0x02,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong or(in ulong lhs, in ulong rhs, ref ulong dst)
; location: [7FFDDBEBCD80h, 7FFDDBEBCD91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h or rax,[rdx]                  ; OR(Or_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]          encoding(3 bytes) = 48 0b 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x0B,0x02,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sal(sbyte src, int offset)
; location: [7FFDDBEBCDB0h, 7FFDDBEBCDC1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sal(byte src, int offset)
; location: [7FFDDBEBCDE0h, 7FFDDBEBCDEFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sal(short src, int offset)
; location: [7FFDDBEBCE00h, 7FFDDBEBCE11h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sal(ushort src, int offset)
; location: [7FFDDBEBCE30h, 7FFDDBEBCE3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sal(int src, int offset)
; location: [7FFDDBEBCE50h, 7FFDDBEBCE5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sal(uint src, int offset)
; location: [7FFDDBEBCE70h, 7FFDDBEBCE7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sal(long src, int offset)
; location: [7FFDDBEBCE90h, 7FFDDBEBCE9Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sal(ulong src, int offset)
; location: [7FFDDBEBCEB0h, 7FFDDBEBCEBDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte sal(ref sbyte src, int offset)
; location: [7FFDDBEBCED0h, 7FFDDBEBCEE4h]
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
; location: [7FFDDBEBCF00h, 7FFDDBEBCF14h]
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
; location: [7FFDDBEBCF30h, 7FFDDBEBCF45h]
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
; location: [7FFDDBEBCF60h, 7FFDDBEBCF75h]
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
; location: [7FFDDBEBCF90h, 7FFDDBEBCF9Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0xD3,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint sal(ref uint src, int offset)
; location: [7FFDDBEBCFB0h, 7FFDDBEBCFBCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0xD3,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long sal(ref long src, int offset)
; location: [7FFDDBEBCFD0h, 7FFDDBEBCFDDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong sal(ref ulong src, int offset)
; location: [7FFDDBEBCFF0h, 7FFDDBEBCFFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> salBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sar(sbyte src, int offset)
; location: [7FFDDBEBD010h, 7FFDDBEBD021h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sar(byte src, int offset)
; location: [7FFDDBEBD040h, 7FFDDBEBD04Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sar(short src, int offset)
; location: [7FFDDBEBD060h, 7FFDDBEBD071h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sar(ushort src, int offset)
; location: [7FFDDBEBD090h, 7FFDDBEBD09Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sar(int src, int offset)
; location: [7FFDDBEBD0B0h, 7FFDDBEBD0BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sar(uint src, int offset)
; location: [7FFDDBEBD0D0h, 7FFDDBEBD0DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sar(long src, int offset)
; location: [7FFDDBEBD0F0h, 7FFDDBEBD0FDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar rax,cl                    ; SAR(Sar_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 f8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sar(ulong src, int offset)
; location: [7FFDDBEBD110h, 7FFDDBEBD11Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte sar(ref sbyte src, int offset)
; location: [7FFDDBEBD130h, 7FFDDBEBD144h]
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
; location: [7FFDDBEBD160h, 7FFDDBEBD174h]
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
; location: [7FFDDBEBD190h, 7FFDDBEBD1A5h]
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
; location: [7FFDDBEBD1C0h, 7FFDDBEBD1D5h]
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
; location: [7FFDDBEBD1F0h, 7FFDDBEBD1FCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar dword ptr [rax],cl        ; SAR(Sar_rm32_CL) [mem(32i,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 38
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0xD3,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint sar(ref uint src, int offset)
; location: [7FFDDBEBD210h, 7FFDDBEBD21Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr dword ptr [rax],cl        ; SHR(Shr_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 28
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0xD3,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long sar(ref long src, int offset)
; location: [7FFDDBEBD230h, 7FFDDBEBD23Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar qword ptr [rax],cl        ; SAR(Sar_rm64_CL) [mem(64i,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 38
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong sar(ref ulong src, int offset)
; location: [7FFDDBEBD250h, 7FFDDBEBD25Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr qword ptr [rax],cl        ; SHR(Shr_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 28
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sarBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sll(sbyte src, int offset)
; location: [7FFDDBEBD270h, 7FFDDBEBD29Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movsx rcx,byte ptr [rsp+8]    ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 4c 24 08
000fh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0011h sar eax,7                     ; SAR(Sar_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 f8 07
0014h add ecx,eax                   ; ADD(Add_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 03 c8
0016h xor ecx,eax                   ; XOR(Xor_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 33 c8
0018h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
001ch mov [rsp+8],cl                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 08
0020h movsx rax,byte ptr [rsp+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 44 24 08
0026h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0028h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
002ah movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x0F,0xBE,0x4C,0x24,0x08,0x8B,0xC1,0xC1,0xF8,0x07,0x03,0xC8,0x33,0xC8,0x48,0x0F,0xBE,0xC9,0x88,0x4C,0x24,0x08,0x48,0x0F,0xBE,0x44,0x24,0x08,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sll(byte src, int offset)
; location: [7FFDDBEBD2B0h, 7FFDDBEBD2BFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sll(short src, int offset)
; location: [7FFDDBEBD2D0h, 7FFDDBEBD2FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movsx rcx,word ptr [rsp+8]    ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 4c 24 08
000fh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0011h sar eax,0Fh                   ; SAR(Sar_rm32_imm8) [EAX,fh:imm8]                     encoding(3 bytes) = c1 f8 0f
0014h add ecx,eax                   ; ADD(Add_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 03 c8
0016h xor ecx,eax                   ; XOR(Xor_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 33 c8
0018h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
001ch mov [rsp+8],cx                ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 08
0021h movsx rax,word ptr [rsp+8]    ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 44 24 08
0027h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0029h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
002bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[48]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x0F,0xBF,0x4C,0x24,0x08,0x8B,0xC1,0xC1,0xF8,0x0F,0x03,0xC8,0x33,0xC8,0x48,0x0F,0xBF,0xC9,0x66,0x89,0x4C,0x24,0x08,0x48,0x0F,0xBF,0x44,0x24,0x08,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sll(ushort src, int offset)
; location: [7FFDDBEBD310h, 7FFDDBEBD31Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sll(int src, int offset)
; location: [7FFDDBEBD330h, 7FFDDBEBD344h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0009h sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
000ch add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
000eh xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xC8,0xC1,0xF9,0x1F,0x03,0xC1,0x33,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sll(uint src, int offset)
; location: [7FFDDBEBD360h, 7FFDDBEBD36Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sll(long src, int offset)
; location: [7FFDDBEBD380h, 7FFDDBEBD39Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
000bh sar rcx,3Fh                   ; SAR(Sar_rm64_imm8) [RCX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f9 3f
000fh add rax,rcx                   ; ADD(Add_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 03 c1
0012h xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0015h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0017h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x8B,0xC8,0x48,0xC1,0xF9,0x3F,0x48,0x03,0xC1,0x48,0x33,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sll(ulong src, int offset)
; location: [7FFDDBEBD3B0h, 7FFDDBEBD3BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte sll(ref sbyte src, int offset)
; location: [7FFDDBEBD3D0h, 7FFDDBEBD3F7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx rcx,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 08
000ch mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
000fh sar r8d,7                     ; SAR(Sar_rm32_imm8) [R8D,7h:imm8]                     encoding(4 bytes) = 41 c1 f8 07
0013h add ecx,r8d                   ; ADD(Add_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 03 c8
0016h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
0019h mov [rax],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),CL]            encoding(2 bytes) = 88 08
001bh movsx r8,byte ptr [rax]       ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 0f be 00
001fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0021h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0024h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xBE,0x08,0x44,0x8B,0xC1,0x41,0xC1,0xF8,0x07,0x41,0x03,0xC8,0x41,0x33,0xC8,0x88,0x08,0x4C,0x0F,0xBE,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte sll(ref byte src, int offset)
; location: [7FFDDBEBD410h, 7FFDDBEBD424h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0011h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB6,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short sll(ref short src, int offset)
; location: [7FFDDBEBD440h, 7FFDDBEBD469h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx rcx,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 08
000ch mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
000fh sar r8d,0Fh                   ; SAR(Sar_rm32_imm8) [R8D,fh:imm8]                     encoding(4 bytes) = 41 c1 f8 0f
0013h add ecx,r8d                   ; ADD(Add_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 03 c8
0016h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
0019h mov [rax],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),CX]         encoding(3 bytes) = 66 89 08
001ch movsx r8,word ptr [rax]       ; MOVSX(Movsx_r64_rm16) [R8,mem(16i,RAX:br,DS:sr)]     encoding(4 bytes) = 4c 0f bf 00
0020h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0022h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0025h mov [rax],r8w                 ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R8W]        encoding(4 bytes) = 66 44 89 00
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xBF,0x08,0x44,0x8B,0xC1,0x41,0xC1,0xF8,0x0F,0x41,0x03,0xC8,0x41,0x33,0xC8,0x66,0x89,0x08,0x4C,0x0F,0xBF,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x66,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort sll(ref ushort src, int offset)
; location: [7FFDDBEBD480h, 7FFDDBEBD495h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RAX:br,DS:sr)]    encoding(4 bytes) = 44 0f b7 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0011h mov [rax],r8w                 ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R8W]        encoding(4 bytes) = 66 44 89 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB7,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x66,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int sll(ref int src, int offset)
; location: [7FFDDBEBD4B0h, 7FFDDBEBD4CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
000ah mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
000dh sar r8d,1Fh                   ; SAR(Sar_rm32_imm8) [R8D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f8 1f
0011h add ecx,r8d                   ; ADD(Add_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 03 c8
0014h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
0017h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
0019h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001bh shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0x08,0x44,0x8B,0xC1,0x41,0xC1,0xF8,0x1F,0x41,0x03,0xC8,0x41,0x33,0xC8,0x89,0x08,0x8B,0xCA,0xD3,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint sll(ref uint src, int offset)
; location: [7FFDDBEBD4E0h, 7FFDDBEBD4ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0xD3,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long sll(ref long src, int offset)
; location: [7FFDDBEBD500h, 7FFDDBEBD520h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
000bh mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
000eh sar r8,3Fh                    ; SAR(Sar_rm64_imm8) [R8,3fh:imm8]                     encoding(4 bytes) = 49 c1 f8 3f
0012h add rcx,r8                    ; ADD(Add_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 03 c8
0015h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
0018h mov [rax],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RCX]        encoding(3 bytes) = 48 89 08
001bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001dh shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x8B,0x08,0x4C,0x8B,0xC1,0x49,0xC1,0xF8,0x3F,0x49,0x03,0xC8,0x49,0x33,0xC8,0x48,0x89,0x08,0x8B,0xCA,0x48,0xD3,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong sll(ref ulong src, int offset)
; location: [7FFDDBEBD540h, 7FFDDBEBD54Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte srl(sbyte src, int offset)
; location: [7FFDDBEBD560h, 7FFDDBEBD571h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte srl(byte src, int offset)
; location: [7FFDDBEBD590h, 7FFDDBEBD59Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short srl(short src, int offset)
; location: [7FFDDBEBD5B0h, 7FFDDBEBD5C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort srl(ushort src, int offset)
; location: [7FFDDBEBD5E0h, 7FFDDBEBD5EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int srl(int src, int offset)
; location: [7FFDDBEBD600h, 7FFDDBEBD60Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint srl(uint src, int offset)
; location: [7FFDDBEBD620h, 7FFDDBEBD62Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
