; 2019-11-13 09:54:09:619
; function: uint mod_const_16(uint a)
; location: [7FFDD9EE65D0h, 7FFDD9EE65E5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h shl rdx,3Ch                   ; SHL(Shl_rm64_imm8) [RDX,3ch:imm8]                    encoding(4 bytes) = 48 c1 e2 3c
000bh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0010h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_16Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xC1,0xE2,0x3C,0xB8,0x10,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_16(uint a)
; location: [7FFDD9EE6600h, 7FFDD9EE6616h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,1000000000000000h     ; MOV(Mov_r64_imm64) [RDX,1000000000000000h:imm64]     encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 10
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_16Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x10,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_25(uint a)
; location: [7FFDD9EE6630h, 7FFDD9EE664Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h mov rax,0A3D70A3D70A3D71h     ; MOV(Mov_r64_imm64) [RAX,a3d70a3d70a3d71h:imm64]      encoding(10 bytes) = 48 b8 71 3d 0a d7 a3 70 3d 0a
0011h imul rdx,rax                  ; IMUL(Imul_r64_rm64) [RDX,RAX]                        encoding(4 bytes) = 48 0f af d0
0015h mov eax,19h                   ; MOV(Mov_r32_imm32) [EAX,19h:imm32]                   encoding(5 bytes) = b8 19 00 00 00
001ah mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_25Bytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xB8,0x71,0x3D,0x0A,0xD7,0xA3,0x70,0x3D,0x0A,0x48,0x0F,0xAF,0xD0,0xB8,0x19,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_25(uint a)
; location: [7FFDD9EE6660h, 7FFDD9EE6676h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,0A3D70A3D70A3D71h     ; MOV(Mov_r64_imm64) [RDX,a3d70a3d70a3d71h:imm64]      encoding(10 bytes) = 48 ba 71 3d 0a d7 a3 70 3d 0a
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_25Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x71,0x3D,0x0A,0xD7,0xA3,0x70,0x3D,0x0A,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_32(uint a)
; location: [7FFDD9EE6690h, 7FFDD9EE66A5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h shl rdx,3Bh                   ; SHL(Shl_rm64_imm8) [RDX,3bh:imm8]                    encoding(4 bytes) = 48 c1 e2 3b
000bh mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
0010h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_32Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xC1,0xE2,0x3B,0xB8,0x20,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_32(uint a)
; location: [7FFDD9EE66C0h, 7FFDD9EE66D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,800000000000000h      ; MOV(Mov_r64_imm64) [RDX,800000000000000h:imm64]      encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 08
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_32Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void mul_full_64u(in Pair<ulong> src, ref Pair<ulong> dst)
; location: [7FFDD9EE66F0h, 7FFDD9EE6718h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 49 08
000ch mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 10
0011h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0014h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0017h mulx rax,r9,rcx               ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,R9,RCX]             encoding(VEX, 5 bytes) = c4 e2 b3 f6 c1
001ch mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),R9]            encoding(3 bytes) = 4d 89 08
001fh mov rdx,[rsp+10h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 10
0024h mov [rdx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(4 bytes) = 48 89 42 08
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_full_64uBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8B,0x49,0x08,0x48,0x89,0x54,0x24,0x10,0x4C,0x8B,0xC2,0x48,0x8B,0xD0,0xC4,0xE2,0xB3,0xF6,0xC1,0x4D,0x89,0x08,0x48,0x8B,0x54,0x24,0x10,0x48,0x89,0x42,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void mul_full_32u(in Pair<uint> src, ref Pair<uint> dst)
; location: [7FFDD9EE6730h, 7FFDD9EE6754h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)]          encoding(2 bytes) = 8b 01
0007h mov ecx,[rcx+4]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 49 04
000ah mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 10
000fh mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0012h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0014h mulx eax,r9d,ecx              ; MULX(VEX_Mulx_r32_r32_rm32) [EAX,R9D,ECX]            encoding(VEX, 5 bytes) = c4 e2 33 f6 c1
0019h mov [r8],r9d                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),R9D]           encoding(3 bytes) = 45 89 08
001ch mov rdx,[rsp+10h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 10
0021h mov [rdx+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,:sr),EAX]          encoding(3 bytes) = 89 42 04
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_full_32uBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8B,0x49,0x04,0x48,0x89,0x54,0x24,0x10,0x4C,0x8B,0xC2,0x8B,0xD0,0xC4,0xE2,0x33,0xF6,0xC1,0x45,0x89,0x08,0x48,0x8B,0x54,0x24,0x10,0x89,0x42,0x04,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<Char> hexdigits(ushort a)
; location: [7FFDD9EE6B70h, 7FFDD9EE6B82h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0008h mov rax,7FFDD9EE6790h         ; MOV(Mov_r64_imm64) [RAX,7ffdd9ee6790h:imm64]         encoding(10 bytes) = 48 b8 90 67 ee d9 fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> hexdigitsBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xD2,0x48,0xB8,0x90,0x67,0xEE,0xD9,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char hexdigit(byte a)
; location: [7FFDD9EE6BA0h, 7FFDD9EE6BBCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000bh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000eh mov rdx,2BC7CF5F765h          ; MOV(Mov_r64_imm64) [RDX,2bc7cf5f765h:imm64]          encoding(10 bytes) = 48 ba 65 f7 f5 7c bc 02 00 00
0018h movzx eax,byte ptr [rax+rdx]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 04 10
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hexdigitBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x83,0xE0,0x0F,0x48,0x63,0xC0,0x48,0xBA,0x65,0xF7,0xF5,0x7C,0xBC,0x02,0x00,0x00,0x0F,0xB6,0x04,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void hexdigits(byte a, out Char d0, out Char d1)
; location: [7FFDD9EE6BD0h, 7FFDD9EE6C04h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000ah and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
000dh movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0010h mov r9,2BC7CF5F765h           ; MOV(Mov_r64_imm64) [R9,2bc7cf5f765h:imm64]           encoding(10 bytes) = 49 b9 65 f7 f5 7c bc 02 00 00
001ah movzx ecx,byte ptr [rcx+r9]   ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,:sr)]        encoding(5 bytes) = 42 0f b6 0c 09
001fh mov [rdx],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,:sr),CX]           encoding(3 bytes) = 66 89 0a
0022h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0025h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
0028h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
002bh movzx eax,byte ptr [rax+r9]   ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(5 bytes) = 42 0f b6 04 08
0030h mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,:sr),AX]            encoding(4 bytes) = 66 41 89 00
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hexdigitsBytes => new byte[53]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xC8,0x83,0xE1,0x0F,0x48,0x63,0xC9,0x49,0xB9,0x65,0xF7,0xF5,0x7C,0xBC,0x02,0x00,0x00,0x42,0x0F,0xB6,0x0C,0x09,0x66,0x89,0x0A,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x48,0x63,0xC0,0x42,0x0F,0xB6,0x04,0x08,0x66,0x41,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void datablock_store(in byte src, uint count, ref Block128 dst)
; location: [7FFDD9EE6C20h, 7FFDD9EE6C37h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
000bh mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
000eh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0011h call 7FFE39363850h            ; CALL(Call_rel32_64) [5F47CC30h:jmp64]                encoding(5 bytes) = e8 1a cc 47 5f
0016h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> datablock_storeBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x49,0x8B,0xC8,0x44,0x8B,0xC2,0x48,0x8B,0xD0,0xE8,0x1A,0xCC,0x47,0x5F,0x90,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void datablock_bytes(ref Block128 src)
; location: [7FFDD9EE6C50h, 7FFDD9EE6C73h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000bh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0010h mov [rsp+28h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RCX]          encoding(5 bytes) = 48 89 4c 24 28
0015h mov [rsp+30h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 30
0019h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001eh call 7FFE3948ED50h            ; CALL(Call_rel32_64) [5F5A8100h:jmp64]                encoding(5 bytes) = e8 dd 80 5a 5f
0023h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> datablock_bytesBytes => new byte[36]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0xB8,0x10,0x00,0x00,0x00,0x48,0x89,0x4C,0x24,0x28,0x89,0x44,0x24,0x30,0x48,0x83,0xC4,0x38,0xC3,0xE8,0xDD,0x80,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq(byte value)
; location: [7FFDD9EE7090h, 7FFDD9EE70D1h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
000bh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000dh add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0011h cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
0018h ja short 003ch                ; JA(Ja_rel8_64) [3Ch:jmp64]                           encoding(2 bytes) = 77 22
001ah movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
001dh mov rdx,2BC7CF5EE85h          ; MOV(Mov_r64_imm64) [RDX,2bc7cf5ee85h:imm64]          encoding(10 bytes) = 48 ba 85 ee f5 7c bc 02 00 00
0027h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
002ah mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
002dh mov dword ptr [rcx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,:sr),8h:imm32]   encoding(7 bytes) = c7 41 08 08 00 00 00
0034h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0037h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003ch call 7FFDD984DEA8h            ; CALL(Call_rel32_64) [FFFFFFFFFF966E18h:jmp64]        encoding(5 bytes) = e8 d7 6d 96 ff
0041h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseqBytes => new byte[66]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xC1,0xE0,0x03,0x8B,0xD0,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x77,0x22,0x48,0x63,0xC0,0x48,0xBA,0x85,0xEE,0xF5,0x7C,0xBC,0x02,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0xC7,0x41,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xD7,0x6D,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> bitseq2(ulong value)
; location: [7FFDD9EE7460h, 7FFDD9EE74B8h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
000ch mov rcx,7FFDD980EA10h         ; MOV(Mov_r64_imm64) [RCX,7ffdd980ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 80 d9 fd 7f 00 00
0016h mov edx,40h                   ; MOV(Mov_r32_imm32) [EDX,40h:imm32]                   encoding(5 bytes) = ba 40 00 00 00
001bh call 7FFE393645E0h            ; CALL(Call_rel32_64) [5F47D180h:jmp64]                encoding(5 bytes) = e8 60 d1 47 5f
0020h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0024h mov edx,40h                   ; MOV(Mov_r32_imm32) [EDX,40h:imm32]                   encoding(5 bytes) = ba 40 00 00 00
0029h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
002bh jmp short 0044h               ; JMP(Jmp_rel8_64) [44h:jmp64]                         encoding(2 bytes) = eb 17
002dh movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
0030h add r8,rax                    ; ADD(Add_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 03 c0
0033h bt rdi,rcx                    ; BT(Bt_rm64_r64) [RDI,RCX]                            encoding(4 bytes) = 48 0f a3 cf
0037h setb r9b                      ; SETB(Setb_rm8) [R9L]                                 encoding(4 bytes) = 41 0f 92 c1
003bh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
003fh mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(3 bytes) = 45 88 08
0042h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
0044h cmp ecx,40h                   ; CMP(Cmp_rm32_imm8) [ECX,40h:imm32]                   encoding(3 bytes) = 83 f9 40
0047h jl short 002dh                ; JL(Jl_rel8_64) [2Dh:jmp64]                           encoding(2 bytes) = 7c e4
0049h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RAX]          encoding(3 bytes) = 48 89 06
004ch mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),EDX]          encoding(3 bytes) = 89 56 08
004fh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0052h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0056h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0057h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0058h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq2Bytes => new byte[89]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8B,0xFA,0x48,0xB9,0x10,0xEA,0x80,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x40,0x00,0x00,0x00,0xE8,0x60,0xD1,0x47,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x40,0x00,0x00,0x00,0x33,0xC9,0xEB,0x17,0x4C,0x63,0xC1,0x4C,0x03,0xC0,0x48,0x0F,0xA3,0xCF,0x41,0x0F,0x92,0xC1,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0xFF,0xC1,0x83,0xF9,0x40,0x7C,0xE4,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq(int offset, int count)
; location: [7FFDD9EE74E0h, 7FFDD9EE7519h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
000ah add rax,r9                    ; ADD(Add_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 03 c1
000dh cmp rax,800h                  ; CMP(Cmp_RAX_imm32) [RAX,800h:imm64]                  encoding(6 bytes) = 48 3d 00 08 00 00
0013h ja short 0034h                ; JA(Ja_rel8_64) [34h:jmp64]                           encoding(2 bytes) = 77 1f
0015h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0018h mov rdx,2BC7CF5EE85h          ; MOV(Mov_r64_imm64) [RDX,2bc7cf5ee85h:imm64]          encoding(10 bytes) = 48 ba 85 ee f5 7c bc 02 00 00
0022h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0025h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
0028h mov [rcx+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R8D]          encoding(4 bytes) = 44 89 41 08
002ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002fh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0034h call 7FFDD984DEA8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9669C8h:jmp64]        encoding(5 bytes) = e8 8f 69 96 ff
0039h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseqBytes => new byte[58]{0x48,0x83,0xEC,0x28,0x90,0x8B,0xC2,0x45,0x8B,0xC8,0x49,0x03,0xC1,0x48,0x3D,0x00,0x08,0x00,0x00,0x77,0x1F,0x48,0x63,0xC2,0x48,0xBA,0x85,0xEE,0xF5,0x7C,0xBC,0x02,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0x44,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x8F,0x69,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq8u(byte src)
; location: [7FFDD9EE7940h, 7FFDD9EE79ACh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov [rsp+48h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX]          encoding(4 bytes) = 89 54 24 48
000ah mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000dh movzx edi,byte ptr [rsp+48h]  ; MOVZX(Movzx_r32_rm8) [EDI,mem(8u,RSP:br,:sr)]        encoding(6 bytes) = 40 0f b6 7c 24 48
0013h mov rcx,7FFDD98F7F78h         ; MOV(Mov_r64_imm64) [RCX,7ffdd98f7f78h:imm64]         encoding(10 bytes) = 48 b9 78 7f 8f d9 fd 7f 00 00
001dh mov edx,5Ah                   ; MOV(Mov_r32_imm32) [EDX,5ah:imm32]                   encoding(5 bytes) = ba 5a 00 00 00
0022h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47CF70h:jmp64]                encoding(5 bytes) = e8 49 cf 47 5f
0027h mov rax,2BC10005790h          ; MOV(Mov_r64_imm64) [RAX,2bc10005790h:imm64]          encoding(10 bytes) = 48 b8 90 57 00 10 bc 02 00 00
0031h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0034h cmp edi,[rax+8]               ; CMP(Cmp_r32_rm32) [EDI,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 3b 78 08
0037h jae short 0067h               ; JAE(Jae_rel8_64) [67h:jmp64]                         encoding(2 bytes) = 73 2e
0039h movsxd rdx,edi                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDI]                    encoding(3 bytes) = 48 63 d7
003ch shl rdx,5                     ; SHL(Shl_rm64_imm8) [RDX,5h:imm8]                     encoding(4 bytes) = 48 c1 e2 05
0040h mov rax,[rax+rdx+10h]         ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(5 bytes) = 48 8b 44 10 10
0045h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0048h jne short 0050h               ; JNE(Jne_rel8_64) [50h:jmp64]                         encoding(2 bytes) = 75 06
004ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
004ch xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
004eh jmp short 0057h               ; JMP(Jmp_rel8_64) [57h:jmp64]                         encoding(2 bytes) = eb 07
0050h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 10
0054h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 8b 48 08
0057h mov [rsi],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RDX]          encoding(3 bytes) = 48 89 16
005ah mov [rsi+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),ECX]          encoding(3 bytes) = 89 4e 08
005dh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0060h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0064h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0065h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0066h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0067h call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F5A75C0h:jmp64]                encoding(5 bytes) = e8 54 75 5a 5f
006ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseq8uBytes => new byte[109]{0x57,0x56,0x48,0x83,0xEC,0x28,0x89,0x54,0x24,0x48,0x48,0x8B,0xF1,0x40,0x0F,0xB6,0x7C,0x24,0x48,0x48,0xB9,0x78,0x7F,0x8F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x5A,0x00,0x00,0x00,0xE8,0x49,0xCF,0x47,0x5F,0x48,0xB8,0x90,0x57,0x00,0x10,0xBC,0x02,0x00,0x00,0x48,0x8B,0x00,0x3B,0x78,0x08,0x73,0x2E,0x48,0x63,0xD7,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x44,0x10,0x10,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x48,0x89,0x16,0x89,0x4E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3,0xE8,0x54,0x75,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte enable_d8i(ref sbyte src, int pos)
; location: [7FFDD9EE79D0h, 7FFDD9EE79E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0017h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,:sr),DL]                encoding(2 bytes) = 08 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte enable_g8i(ref sbyte src, int pos)
; location: [7FFDD9EE7A00h, 7FFDD9EE7A19h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0017h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,:sr),DL]                encoding(2 bytes) = 08 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte enable_d8u(ref byte src, int pos)
; location: [7FFDD9EE7A30h, 7FFDD9EE7A49h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0017h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,:sr),DL]                encoding(2 bytes) = 08 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d8uBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte enable_g8u(ref byte src, int pos)
; location: [7FFDD9EE7A60h, 7FFDD9EE7A79h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0017h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,:sr),DL]                encoding(2 bytes) = 08 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g8uBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short enable_d16i(ref short src, int pos)
; location: [7FFDD9EE7A90h, 7FFDD9EE7AAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0017h or [rax],dx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,:sr),DX]             encoding(3 bytes) = 66 09 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d16iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x66,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short enable_g16i(ref short src, int pos)
; location: [7FFDD9EE7AC0h, 7FFDD9EE7ADAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0017h or [rax],dx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,:sr),DX]             encoding(3 bytes) = 66 09 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g16iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x66,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort enable_d16u(ref ushort src, int pos)
; location: [7FFDD9EE7AF0h, 7FFDD9EE7B0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0017h or [rax],dx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,:sr),DX]             encoding(3 bytes) = 66 09 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d16uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x66,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort enable_g16u(ref ushort src, int pos)
; location: [7FFDD9EE7B20h, 7FFDD9EE7B3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0017h or [rax],dx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,:sr),DX]             encoding(3 bytes) = 66 09 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g16uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x66,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int enable_d32i(ref int src, int pos)
; location: [7FFDD9EE7B50h, 7FFDD9EE7B66h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h or [rax],r8d                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,:sr),R8D]            encoding(3 bytes) = 44 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int enable_g32i(ref int src, int pos)
; location: [7FFDD9EE7B80h, 7FFDD9EE7B96h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h or [rax],r8d                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,:sr),R8D]            encoding(3 bytes) = 44 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint enable_d32u(ref uint src, int pos)
; location: [7FFDD9EE7BB0h, 7FFDD9EE7BC6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h or [rax],r8d                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,:sr),R8D]            encoding(3 bytes) = 44 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint enable_g32u(ref uint src, int pos)
; location: [7FFDD9EE7BE0h, 7FFDD9EE7BF6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h or [rax],r8d                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,:sr),R8D]            encoding(3 bytes) = 44 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long enable_d64i(ref long src, int pos)
; location: [7FFDD9EE7C10h, 7FFDD9EE7C26h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R8]             encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d64iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long enable_g64i(ref long src, int pos)
; location: [7FFDD9EE7C40h, 7FFDD9EE7C56h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R8]             encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g64iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong enable_d64u(ref ulong src, int pos)
; location: [7FFDD9EE7C70h, 7FFDD9EE7C86h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R8]             encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong enable_g64u(ref ulong src, int pos)
; location: [7FFDD9EE7CA0h, 7FFDD9EE7CB6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R8]             encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float enable_d32f(ref float src, int pos)
; location: [7FFDD9EE7CD0h, 7FFDD9EE7D06h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h vmovss xmm0,dword ptr [rax]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 10 00
000ch vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
0012h mov r8d,[rsp+4]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,:sr)]          encoding(5 bytes) = 44 8b 44 24 04
0017h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001fh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0022h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0025h mov [rsp],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),R8D]          encoding(4 bytes) = 44 89 04 24
0029h vmovss xmm0,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 10 04 24
002eh vmovss dword ptr [rax],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 00
0032h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d32fBytes => new byte[55]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0xC1,0xC5,0xFA,0x10,0x00,0xC5,0xFA,0x11,0x44,0x24,0x04,0x44,0x8B,0x44,0x24,0x04,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE1,0x45,0x0B,0xC1,0x44,0x89,0x04,0x24,0xC5,0xFA,0x10,0x04,0x24,0xC5,0xFA,0x11,0x00,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float enable_g32f(ref float src, int pos)
; location: [7FFDD9EE7D20h, 7FFDD9EE7D56h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h vmovss xmm0,dword ptr [rax]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 10 00
000ch vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
0012h mov r8d,[rsp+4]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,:sr)]          encoding(5 bytes) = 44 8b 44 24 04
0017h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001fh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0022h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0025h mov [rsp],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),R8D]          encoding(4 bytes) = 44 89 04 24
0029h vmovss xmm0,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 10 04 24
002eh vmovss dword ptr [rax],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 00
0032h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g32fBytes => new byte[55]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0xC1,0xC5,0xFA,0x10,0x00,0xC5,0xFA,0x11,0x44,0x24,0x04,0x44,0x8B,0x44,0x24,0x04,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE1,0x45,0x0B,0xC1,0x44,0x89,0x04,0x24,0xC5,0xFA,0x10,0x04,0x24,0xC5,0xFA,0x11,0x00,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double enable_d64f(ref double src, int pos)
; location: [7FFDD9EE7D70h, 7FFDD9EE7DAAh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah vmovsd xmm0,qword ptr [rax]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb 10 00
000eh vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0014h mov r8,[rsp+10h]              ; MOV(Mov_r64_rm64) [R8,mem(64u,RSP:br,:sr)]           encoding(5 bytes) = 4c 8b 44 24 10
0019h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0021h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0024h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0027h mov [rsp+8],r8                ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R8]           encoding(5 bytes) = 4c 89 44 24 08
002ch vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0032h vmovsd qword ptr [rax],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 00
0036h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d64fBytes => new byte[59]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0xC1,0xC5,0xFB,0x10,0x00,0xC5,0xFB,0x11,0x44,0x24,0x10,0x4C,0x8B,0x44,0x24,0x10,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x4D,0x0B,0xC1,0x4C,0x89,0x44,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC5,0xFB,0x11,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double enable_g64f(ref double src, int pos)
; location: [7FFDD9EE7DD0h, 7FFDD9EE7E0Ah]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah vmovsd xmm0,qword ptr [rax]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb 10 00
000eh vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0014h mov r8,[rsp+10h]              ; MOV(Mov_r64_rm64) [R8,mem(64u,RSP:br,:sr)]           encoding(5 bytes) = 4c 8b 44 24 10
0019h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0021h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0024h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0027h mov [rsp+8],r8                ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R8]           encoding(5 bytes) = 4c 89 44 24 08
002ch vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0032h vmovsd qword ptr [rax],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 00
0036h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g64fBytes => new byte[59]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0xC1,0xC5,0xFB,0x10,0x00,0xC5,0xFB,0x11,0x44,0x24,0x10,0x4C,0x8B,0x44,0x24,0x10,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x4D,0x0B,0xC1,0x4C,0x89,0x44,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC5,0xFB,0x11,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d8i(sbyte src, int pos)
; location: [7FFDD9EE7E30h, 7FFDD9EE7E4Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d8iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g8i(sbyte src, int pos)
; location: [7FFDD9EE7E60h, 7FFDD9EE7E7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g8iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d8u(byte src, int pos)
; location: [7FFDD9EE7E90h, 7FFDD9EE7EAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0014h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d8uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g8u(byte src, int pos)
; location: [7FFDD9EE7EC0h, 7FFDD9EE7EDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0014h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g8uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d16i(short src, int pos)
; location: [7FFDD9EE7EF0h, 7FFDD9EE7F0Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d16iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g16i(short src, int pos)
; location: [7FFDD9EE7F20h, 7FFDD9EE7F3Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g16iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d16u(ushort src, int pos)
; location: [7FFDD9EE7F50h, 7FFDD9EE7F6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0014h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d16uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g16u(ushort src, int pos)
; location: [7FFDD9EE8390h, 7FFDD9EE83AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0014h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g16uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d32i(int src, int pos)
; location: [7FFDD9EE83C0h, 7FFDD9EE83D7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0011h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d32iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g32i(int src, int pos)
; location: [7FFDD9EE83F0h, 7FFDD9EE8407h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0011h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g32iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d32u(uint src, int pos)
; location: [7FFDD9EE8420h, 7FFDD9EE8437h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0011h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d32uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g32u(uint src, int pos)
; location: [7FFDD9EE8450h, 7FFDD9EE8467h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0011h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g32uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d64i(long src, int pos)
; location: [7FFDD9EE8480h, 7FFDD9EE848Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g64i(long src, int pos)
; location: [7FFDD9EE84A0h, 7FFDD9EE84B8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g64iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d64u(ulong src, int pos)
; location: [7FFDD9EE84D0h, 7FFDD9EE84E8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d64uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g64u(ulong src, int pos)
; location: [7FFDD9EE8500h, 7FFDD9EE8518h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g64uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d32f(float src, int pos)
; location: [7FFDD9EE8530h, 7FFDD9EE8555h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 04
000fh bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
001bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d32fBytes => new byte[38]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g32f(float src, int pos)
; location: [7FFDD9EE8570h, 7FFDD9EE8595h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 04
000fh bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
001bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g32fBytes => new byte[38]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d64f(double src, int pos)
; location: [7FFDD9EE85B0h, 7FFDD9EE85D5h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
000eh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
001bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d64fBytes => new byte[38]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g64f(double src, int pos)
; location: [7FFDD9EE85F0h, 7FFDD9EE8615h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
000eh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
001bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g64fBytes => new byte[38]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_and(UInt8 a, UInt8 b)
; location: [7FFDD9EE8630h, 7FFDD9EE8639h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_andBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_sll(UInt8 a, int offset)
; location: [7FFDD9EE8650h, 7FFDD9EE8660h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh and eax,0FFh                  ; AND(And_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 25 ff 00 00 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_sllBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0x25,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_rotl(UInt8 a, int offset)
; location: [7FFDD9EE8680h, 7FFDD9EE86A2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
000fh and r8d,0FFh                  ; AND(And_rm32_imm32) [R8D,ffh:imm32]                  encoding(7 bytes) = 41 81 e0 ff 00 00 00
0016h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0018h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
001ah add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
001dh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
001fh or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_rotlBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x41,0x81,0xE0,0xFF,0x00,0x00,0x00,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xE8,0x41,0x0B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_rotr(UInt8 a, int offset)
; location: [7FFDD9EE86C0h, 7FFDD9EE86E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
000fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0011h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0013h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0016h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0018h and eax,0FFh                  ; AND(And_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 25 ff 00 00 00
001dh or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_rotrBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xE0,0x25,0xFF,0x00,0x00,0x00,0x41,0x0B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_mul(UInt8 a, UInt8 b)
; location: [7FFDD9EE8700h, 7FFDD9EE870Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah and eax,0FFh                  ; AND(And_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 25 ff 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_mulBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0x25,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_or(UInt8 a, UInt8 b)
; location: [7FFDD9EE8720h, 7FFDD9EE8729h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_orBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
