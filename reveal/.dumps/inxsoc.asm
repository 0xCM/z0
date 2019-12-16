; 2019-12-16 03:16:41:502
; function: void unpack(byte src, in Block64<byte> dst)
; location: [7FF7C6A53E70h, 7FF7C6A53E8Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
000bh mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
0015h pdep rdx,rdx,rcx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,RCX]            encoding(VEX, 5 bytes) = c4 e2 eb f5 d1
001ah mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> unpackBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x0F,0xB6,0xD1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack(ushort src, in Block128<byte> dst)
; location: [7FF7C6A53EA0h, 7FF7C6A53ED2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
000bh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000eh mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
0018h pdep rcx,rcx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,R8]             encoding(VEX, 5 bytes) = c4 c2 f3 f5 c8
001dh mov [rax],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RCX]          encoding(3 bytes) = 48 89 08
0020h add rax,8                     ; ADD(Add_rm64_imm8) [RAX,8h:imm64]                    encoding(4 bytes) = 48 83 c0 08
0024h sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
0027h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002ah pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
002fh mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> unpackBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x0F,0xB7,0xD1,0x0F,0xB6,0xCA,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xF3,0xF5,0xC8,0x48,0x89,0x08,0x48,0x83,0xC0,0x08,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack64x8u(ConstBlock64<byte> src)
; location: [7FF7C6A542F0h, 7FF7C6A5430Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
000bh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0010h vpsllq xmm0,xmm0,7            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM0,XMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 f9 73 f0 07
0015h vpmovmskb eax,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EAX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 c0
0019h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack64x8uBytes => new byte[32]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0x48,0x8B,0x00,0xC4,0xE1,0xF9,0x6E,0xC0,0xC5,0xF9,0x73,0xF0,0x07,0xC5,0xF9,0xD7,0xC0,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack128x8u(ConstBlock128<byte> src)
; location: [7FF7C6A54330h, 7FF7C6A54348h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h vlddqu xmm0,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 00
000ch vpsllq xmm0,xmm0,7            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM0,XMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 f9 73 f0 07
0011h vpmovmskb eax,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EAX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 c0
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack128x8uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0xC5,0xFB,0xF0,0x00,0xC5,0xF9,0x73,0xF0,0x07,0xC5,0xF9,0xD7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack_32u(ConstBlock256<byte> src)
; location: [7FF7C6A54770h, 7FF7C6A54788h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
000ch vpsllq ymm0,ymm0,7            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM0,YMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 fd 73 f0 07
0011h vpmovmskb eax,ymm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM0]          encoding(VEX, 4 bytes) = c5 fd d7 c0
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack_32uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x73,0xF0,0x07,0xC5,0xFD,0xD7,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack_32u(uint src, Block256<byte> dst)
; location: [7FF7C6A547A0h, 7FF7C6A54807h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
000bh mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
0015h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
001ah mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
001dh lea rdx,[rax+8]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 08
0021h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
0024h shr r8d,8                     ; SHR(Shr_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e8 08
0028h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ch mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
0036h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
003bh mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
003eh lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 10
0042h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
0045h shr r8d,10h                   ; SHR(Shr_rm32_imm8) [R8D,10h:imm8]                    encoding(4 bytes) = 41 c1 e8 10
0049h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
004dh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0052h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0055h add rax,18h                   ; ADD(Add_rm64_imm8) [RAX,18h:imm64]                   encoding(4 bytes) = 48 83 c0 18
0059h shr ecx,18h                   ; SHR(Shr_rm32_imm8) [ECX,18h:imm8]                    encoding(3 bytes) = c1 e9 18
005ch movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
005fh pdep rdx,rdx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R9]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d1
0064h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0067h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> unpack_32uBytes => new byte[104]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x0F,0xB6,0xD1,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0x48,0x8D,0x50,0x08,0x44,0x8B,0xC1,0x41,0xC1,0xE8,0x08,0x45,0x0F,0xB6,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x10,0x44,0x8B,0xC1,0x41,0xC1,0xE8,0x10,0x45,0x0F,0xB6,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x83,0xC0,0x18,0xC1,0xE9,0x18,0x0F,0xB6,0xD1,0xC4,0xC2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack_64u(ConstBlock256<byte> lo, ConstBlock256<byte> hi)
; location: [7FF7C6A54820h, 7FF7C6A54853h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
000ch vpsllq ymm0,ymm0,7            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM0,YMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 fd 73 f0 07
0011h vpmovmskb eax,ymm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM0]          encoding(VEX, 4 bytes) = c5 fd d7 c0
0015h mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
0017h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
001ah vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
001eh vpsllq ymm0,ymm0,7            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM0,YMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 fd 73 f0 07
0023h vpmovmskb edx,ymm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EDX,YMM0]          encoding(VEX, 4 bytes) = c5 fd d7 d0
0027h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
0029h shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
002dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack_64uBytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x73,0xF0,0x07,0xC5,0xFD,0xD7,0xC0,0x8B,0xC0,0x48,0x8B,0x12,0xC5,0xFF,0xF0,0x02,0xC5,0xFD,0x73,0xF0,0x07,0xC5,0xFD,0xD7,0xD0,0x8B,0xD2,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack_64u(ulong src, Block256<byte> dst)
; location: [7FF7C6A54870h, 7FF7C6A54932h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 02
000ah movzx r9d,al                  ; MOVZX(Movzx_r32_rm8) [R9D,AL]                        encoding(4 bytes) = 44 0f b6 c8
000eh mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0018h pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
001dh mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),R9]            encoding(3 bytes) = 4d 89 08
0020h lea r9,[r8+8]                 ; LEA(Lea_r64_m) [R9,mem(Unknown,R8:br,:sr)]           encoding(4 bytes) = 4d 8d 48 08
0024h mov r10d,eax                  ; MOV(Mov_r32_rm32) [R10D,EAX]                         encoding(3 bytes) = 44 8b d0
0027h shr r10d,8                    ; SHR(Shr_rm32_imm8) [R10D,8h:imm8]                    encoding(4 bytes) = 41 c1 ea 08
002bh movzx r10d,r10b               ; MOVZX(Movzx_r32_rm8) [R10D,R10L]                     encoding(4 bytes) = 45 0f b6 d2
002fh mov r11,101010101010101h      ; MOV(Mov_r64_imm64) [R11,101010101010101h:imm64]      encoding(10 bytes) = 49 bb 01 01 01 01 01 01 01 01
0039h pdep r10,r10,r11              ; PDEP(VEX_Pdep_r64_r64_rm64) [R10,R10,R11]            encoding(VEX, 5 bytes) = c4 42 ab f5 d3
003eh mov [r9],r10                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),R10]           encoding(3 bytes) = 4d 89 11
0041h lea r9,[r8+10h]               ; LEA(Lea_r64_m) [R9,mem(Unknown,R8:br,:sr)]           encoding(4 bytes) = 4d 8d 48 10
0045h mov r10d,eax                  ; MOV(Mov_r32_rm32) [R10D,EAX]                         encoding(3 bytes) = 44 8b d0
0048h shr r10d,10h                  ; SHR(Shr_rm32_imm8) [R10D,10h:imm8]                   encoding(4 bytes) = 41 c1 ea 10
004ch movzx r10d,r10b               ; MOVZX(Movzx_r32_rm8) [R10D,R10L]                     encoding(4 bytes) = 45 0f b6 d2
0050h pdep r10,r10,r11              ; PDEP(VEX_Pdep_r64_r64_rm64) [R10,R10,R11]            encoding(VEX, 5 bytes) = c4 42 ab f5 d3
0055h mov [r9],r10                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),R10]           encoding(3 bytes) = 4d 89 11
0058h add r8,18h                    ; ADD(Add_rm64_imm8) [R8,18h:imm64]                    encoding(4 bytes) = 49 83 c0 18
005ch shr eax,18h                   ; SHR(Shr_rm32_imm8) [EAX,18h:imm8]                    encoding(3 bytes) = c1 e8 18
005fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0062h pdep rax,rax,r11              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R11]            encoding(VEX, 5 bytes) = c4 c2 fb f5 c3
0067h mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
006ah shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
006eh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0070h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
0073h add rdx,20h                   ; ADD(Add_rm64_imm8) [RDX,20h:imm64]                   encoding(4 bytes) = 48 83 c2 20
0077h movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
007ah pdep rcx,rcx,r11              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,R11]            encoding(VEX, 5 bytes) = c4 c2 f3 f5 cb
007fh mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RCX]          encoding(3 bytes) = 48 89 0a
0082h lea rcx,[rdx+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 4a 08
0086h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0089h shr r8d,8                     ; SHR(Shr_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e8 08
008dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0091h pdep r8,r8,r11                ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R11]              encoding(VEX, 5 bytes) = c4 42 bb f5 c3
0096h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
0099h lea rcx,[rdx+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 4a 10
009dh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
00a0h shr r8d,10h                   ; SHR(Shr_rm32_imm8) [R8D,10h:imm8]                    encoding(4 bytes) = 41 c1 e8 10
00a4h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
00a8h pdep r8,r8,r11                ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R11]              encoding(VEX, 5 bytes) = c4 42 bb f5 c3
00adh mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
00b0h add rdx,18h                   ; ADD(Add_rm64_imm8) [RDX,18h:imm64]                   encoding(4 bytes) = 48 83 c2 18
00b4h shr eax,18h                   ; SHR(Shr_rm32_imm8) [EAX,18h:imm8]                    encoding(3 bytes) = c1 e8 18
00b7h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00bah pdep rax,rax,r11              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R11]            encoding(VEX, 5 bytes) = c4 c2 fb f5 c3
00bfh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
00c2h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> unpack_64uBytes => new byte[195]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x4C,0x8B,0x02,0x44,0x0F,0xB6,0xC8,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x4D,0x8D,0x48,0x08,0x44,0x8B,0xD0,0x41,0xC1,0xEA,0x08,0x45,0x0F,0xB6,0xD2,0x49,0xBB,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xAB,0xF5,0xD3,0x4D,0x89,0x11,0x4D,0x8D,0x48,0x10,0x44,0x8B,0xD0,0x41,0xC1,0xEA,0x10,0x45,0x0F,0xB6,0xD2,0xC4,0x42,0xAB,0xF5,0xD3,0x4D,0x89,0x11,0x49,0x83,0xC0,0x18,0xC1,0xE8,0x18,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC3,0x49,0x89,0x00,0x48,0xC1,0xE9,0x20,0x8B,0xC1,0x48,0x8B,0x12,0x48,0x83,0xC2,0x20,0x0F,0xB6,0xC8,0xC4,0xC2,0xF3,0xF5,0xCB,0x48,0x89,0x0A,0x48,0x8D,0x4A,0x08,0x44,0x8B,0xC0,0x41,0xC1,0xE8,0x08,0x45,0x0F,0xB6,0xC0,0xC4,0x42,0xBB,0xF5,0xC3,0x4C,0x89,0x01,0x48,0x8D,0x4A,0x10,0x44,0x8B,0xC0,0x41,0xC1,0xE8,0x10,0x45,0x0F,0xB6,0xC0,0xC4,0x42,0xBB,0xF5,0xC3,0x4C,0x89,0x01,0x48,0x83,0xC2,0x18,0xC1,0xE8,0x18,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC3,0x48,0x89,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong broadcast_8x64(byte pattern)
; location: [7FF7C6A54950h, 7FF7C6A54971h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),AL]              encoding(4 bytes) = 88 44 24 04
000ch lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0011h vpbroadcastb xmm0,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 44 24 04
0018h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
001dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> broadcast_8x64Bytes => new byte[34]{0x50,0xC5,0xF8,0x77,0x90,0x0F,0xB6,0xC1,0x88,0x44,0x24,0x04,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x78,0x44,0x24,0x04,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong broadcast_8x64_const()
; location: [7FF7C6A54990h, 7FF7C6A549B2h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0CCh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),cch:imm32]  encoding(8 bytes) = c7 44 24 04 cc 00 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastb xmm0,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 44 24 04
0019h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
001eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> broadcast_8x64_constBytes => new byte[35]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0xCC,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x78,0x44,0x24,0x04,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
