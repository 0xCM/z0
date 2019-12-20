; 2019-12-19 21:55:24:319
; function: byte pack_8(ConstBlock64<byte> src)
; location: [7FF7C7ED4160h, 7FF7C7ED417Fh]
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
; static ReadOnlySpan<byte> pack_8Bytes => new byte[32]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0x48,0x8B,0x00,0xC4,0xE1,0xF9,0x6E,0xC0,0xC5,0xF9,0x73,0xF0,0x07,0xC5,0xF9,0xD7,0xC0,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pack_16(ConstBlock128<byte> src)
; location: [7FF7C7ED41A0h, 7FF7C7ED41B8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h vlddqu xmm0,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 00
000ch vpsllq xmm0,xmm0,7            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM0,XMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 f9 73 f0 07
0011h vpmovmskb eax,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EAX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 c0
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack_16Bytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0xC5,0xFB,0xF0,0x00,0xC5,0xF9,0x73,0xF0,0x07,0xC5,0xF9,0xD7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack_32(ConstBlock256<byte> src)
; location: [7FF7C7ED45E0h, 7FF7C7ED45F8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
000ch vpsllq ymm0,ymm0,7            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM0,YMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 fd 73 f0 07
0011h vpmovmskb eax,ymm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM0]          encoding(VEX, 4 bytes) = c5 fd d7 c0
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack_32Bytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x73,0xF0,0x07,0xC5,0xFD,0xD7,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack_64(ConstBlock512<byte> src)
; location: [7FF7C7ED4A20h, 7FF7C7ED4A5Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
000bh vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
000fh vpsllq ymm0,ymm0,7            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM0,YMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 fd 73 f0 07
0014h vpmovmskb edx,ymm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EDX,YMM0]          encoding(VEX, 4 bytes) = c5 fd d7 d0
0018h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
001ah add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
001eh vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
0022h vpsllq ymm0,ymm0,7            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM0,YMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 fd 73 f0 07
0027h vpmovmskb eax,ymm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM0]          encoding(VEX, 4 bytes) = c5 fd d7 c0
002bh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
002dh shl rax,20h                   ; SHL(Shl_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e0 20
0031h or rdx,rax                    ; OR(Or_r64_rm64) [RDX,RAX]                            encoding(3 bytes) = 48 0b d0
0034h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0037h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack_64Bytes => new byte[59]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0x48,0x8B,0xD0,0xC5,0xFF,0xF0,0x02,0xC5,0xFD,0x73,0xF0,0x07,0xC5,0xFD,0xD7,0xD0,0x8B,0xD2,0x48,0x83,0xC0,0x20,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x73,0xF0,0x07,0xC5,0xFD,0xD7,0xC0,0x8B,0xC0,0x48,0xC1,0xE0,0x20,0x48,0x0B,0xD0,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack_8(byte src, Block64<byte> dst)
; location: [7FF7C7ED4E80h, 7FF7C7ED4EB3h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 08
000bh cmp rcx,8                     ; CMP(Cmp_rm64_imm8) [RCX,8h:imm64]                    encoding(4 bytes) = 48 83 f9 08
000fh jb short 002eh                ; JB(Jb_rel8_64) [2Eh:jmp64]                           encoding(2 bytes) = 72 1d
0011h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
0021h pdep rax,rax,rcx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RCX]            encoding(VEX, 5 bytes) = c4 e2 fb f5 c1
0026h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0029h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
002eh call 7FF7C775D230h            ; CALL(Call_rel32_64) [FFFFFFFFFF8883B0h:jmp64]        encoding(5 bytes) = e8 7d 83 88 ff
0033h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack_8Bytes => new byte[52]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC1,0x8B,0x4A,0x08,0x48,0x83,0xF9,0x08,0x72,0x1D,0x48,0x8B,0x12,0x0F,0xB6,0xC0,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xFB,0xF5,0xC1,0x48,0x89,0x02,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x7D,0x83,0x88,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack_16(ushort src, Block128<byte> dst)
; location: [7FF7C7ED4ED0h, 7FF7C7ED4F18h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 08
000bh cmp rcx,10h                   ; CMP(Cmp_rm64_imm8) [RCX,10h:imm64]                   encoding(4 bytes) = 48 83 f9 10
000fh jb short 0043h                ; JB(Jb_rel8_64) [43h:jmp64]                           encoding(2 bytes) = 72 32
0011h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
001ah mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
0024h pdep rcx,rcx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,R8]             encoding(VEX, 5 bytes) = c4 c2 f3 f5 c8
0029h mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RCX]          encoding(3 bytes) = 48 89 0a
002ch add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0030h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
0033h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0036h pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
003bh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
003eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0043h call 7FF7C775D230h            ; CALL(Call_rel32_64) [FFFFFFFFFF888360h:jmp64]        encoding(5 bytes) = e8 18 83 88 ff
0048h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack_16Bytes => new byte[73]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB7,0xC1,0x8B,0x4A,0x08,0x48,0x83,0xF9,0x10,0x72,0x32,0x48,0x8B,0x12,0x0F,0xB7,0xC0,0x0F,0xB6,0xC8,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xF3,0xF5,0xC8,0x48,0x89,0x0A,0x48,0x83,0xC2,0x08,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0x48,0x89,0x02,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x18,0x83,0x88,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack_32(uint src, Block256<byte> dst)
; location: [7FF7C7ED5340h, 7FF7C7ED53BAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov eax,[rdx+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 42 08
0008h cmp rax,20h                   ; CMP(Cmp_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 f8 20
000ch jb short 0075h                ; JB(Jb_rel8_64) [75h:jmp64]                           encoding(2 bytes) = 72 67
000eh mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0011h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0014h mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
001eh pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
0023h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0026h lea rdx,[rax+8]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 08
002ah mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
002dh shr r8d,8                     ; SHR(Shr_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e8 08
0031h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0035h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
003fh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0044h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0047h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 10
004bh mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
004eh shr r8d,10h                   ; SHR(Shr_rm32_imm8) [R8D,10h:imm8]                    encoding(4 bytes) = 41 c1 e8 10
0052h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0056h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
005bh mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
005eh add rax,18h                   ; ADD(Add_rm64_imm8) [RAX,18h:imm64]                   encoding(4 bytes) = 48 83 c0 18
0062h shr ecx,18h                   ; SHR(Shr_rm32_imm8) [ECX,18h:imm8]                    encoding(3 bytes) = c1 e9 18
0065h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0068h pdep rdx,rdx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R9]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d1
006dh mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0070h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0074h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0075h call 7FF7C775D230h            ; CALL(Call_rel32_64) [FFFFFFFFFF887EF0h:jmp64]        encoding(5 bytes) = e8 76 7e 88 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack_32Bytes => new byte[123]{0x48,0x83,0xEC,0x28,0x90,0x8B,0x42,0x08,0x48,0x83,0xF8,0x20,0x72,0x67,0x48,0x8B,0x02,0x0F,0xB6,0xD1,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0x48,0x8D,0x50,0x08,0x44,0x8B,0xC1,0x41,0xC1,0xE8,0x08,0x45,0x0F,0xB6,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x10,0x44,0x8B,0xC1,0x41,0xC1,0xE8,0x10,0x45,0x0F,0xB6,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x83,0xC0,0x18,0xC1,0xE9,0x18,0x0F,0xB6,0xD1,0xC4,0xC2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x76,0x7E,0x88,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack_64(ulong src, Block512<byte> dst)
; location: [7FF7C7ED57E0h, 7FF7C7ED58B6h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov eax,[rdx+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 42 08
0008h cmp rax,40h                   ; CMP(Cmp_rm64_imm8) [RAX,40h:imm64]                   encoding(4 bytes) = 48 83 f8 40
000ch jb near ptr 00d1h             ; JB(Jb_rel32_64) [D1h:jmp64]                          encoding(6 bytes) = 0f 82 bf 00 00 00
0012h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0015h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0017h movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
001bh mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
0025h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
002ah mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
002dh lea r8,[rax+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 08
0031h mov r9d,edx                   ; MOV(Mov_r32_rm32) [R9D,EDX]                          encoding(3 bytes) = 44 8b ca
0034h shr r9d,8                     ; SHR(Shr_rm32_imm8) [R9D,8h:imm8]                     encoding(4 bytes) = 41 c1 e9 08
0038h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
003ch mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0046h pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
004bh mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),R9]            encoding(3 bytes) = 4d 89 08
004eh lea r8,[rax+10h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 10
0052h mov r9d,edx                   ; MOV(Mov_r32_rm32) [R9D,EDX]                          encoding(3 bytes) = 44 8b ca
0055h shr r9d,10h                   ; SHR(Shr_rm32_imm8) [R9D,10h:imm8]                    encoding(4 bytes) = 41 c1 e9 10
0059h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
005dh pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
0062h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),R9]            encoding(3 bytes) = 4d 89 08
0065h lea r8,[rax+18h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 18
0069h shr edx,18h                   ; SHR(Shr_rm32_imm8) [EDX,18h:imm8]                    encoding(3 bytes) = c1 ea 18
006ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
006fh pdep rdx,rdx,r10              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R10]            encoding(VEX, 5 bytes) = c4 c2 eb f5 d2
0074h mov [r8],rdx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RDX]           encoding(3 bytes) = 49 89 10
0077h add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
007bh shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
007fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0081h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0084h pdep rcx,rcx,r10              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,R10]            encoding(VEX, 5 bytes) = c4 c2 f3 f5 ca
0089h mov [rax],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RCX]          encoding(3 bytes) = 48 89 08
008ch lea rcx,[rax+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 48 08
0090h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0093h shr r8d,8                     ; SHR(Shr_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e8 08
0097h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
009bh pdep r8,r8,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R10]              encoding(VEX, 5 bytes) = c4 42 bb f5 c2
00a0h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
00a3h lea rcx,[rax+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 48 10
00a7h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
00aah shr r8d,10h                   ; SHR(Shr_rm32_imm8) [R8D,10h:imm8]                    encoding(4 bytes) = 41 c1 e8 10
00aeh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
00b2h pdep r8,r8,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R10]              encoding(VEX, 5 bytes) = c4 42 bb f5 c2
00b7h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
00bah add rax,18h                   ; ADD(Add_rm64_imm8) [RAX,18h:imm64]                   encoding(4 bytes) = 48 83 c0 18
00beh shr edx,18h                   ; SHR(Shr_rm32_imm8) [EDX,18h:imm8]                    encoding(3 bytes) = c1 ea 18
00c1h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00c4h pdep rdx,rdx,r10              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R10]            encoding(VEX, 5 bytes) = c4 c2 eb f5 d2
00c9h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
00cch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00d0h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00d1h call 7FF7C775D230h            ; CALL(Call_rel32_64) [FFFFFFFFFF887A50h:jmp64]        encoding(5 bytes) = e8 7a 79 88 ff
00d6h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack_64Bytes => new byte[215]{0x48,0x83,0xEC,0x28,0x90,0x8B,0x42,0x08,0x48,0x83,0xF8,0x40,0x0F,0x82,0xBF,0x00,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x44,0x0F,0xB6,0xC2,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x4C,0x8D,0x40,0x08,0x44,0x8B,0xCA,0x41,0xC1,0xE9,0x08,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x4C,0x8D,0x40,0x10,0x44,0x8B,0xCA,0x41,0xC1,0xE9,0x10,0x45,0x0F,0xB6,0xC9,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x4C,0x8D,0x40,0x18,0xC1,0xEA,0x18,0x0F,0xB6,0xD2,0xC4,0xC2,0xEB,0xF5,0xD2,0x49,0x89,0x10,0x48,0x83,0xC0,0x20,0x48,0xC1,0xE9,0x20,0x8B,0xD1,0x0F,0xB6,0xCA,0xC4,0xC2,0xF3,0xF5,0xCA,0x48,0x89,0x08,0x48,0x8D,0x48,0x08,0x44,0x8B,0xC2,0x41,0xC1,0xE8,0x08,0x45,0x0F,0xB6,0xC0,0xC4,0x42,0xBB,0xF5,0xC2,0x4C,0x89,0x01,0x48,0x8D,0x48,0x10,0x44,0x8B,0xC2,0x41,0xC1,0xE8,0x10,0x45,0x0F,0xB6,0xC0,0xC4,0x42,0xBB,0xF5,0xC2,0x4C,0x89,0x01,0x48,0x83,0xC0,0x18,0xC1,0xEA,0x18,0x0F,0xB6,0xD2,0xC4,0xC2,0xEB,0xF5,0xD2,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x7A,0x79,0x88,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong broadcast_8x64(byte pattern)
; location: [7FF7C7ED58D0h, 7FF7C7ED58F1h]
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
; location: [7FF7C7ED5910h, 7FF7C7ED5932h]
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
