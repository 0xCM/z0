; 2020-01-02 03:46:23:488
; function: MemStack64 ss_alloc_64()
; location: [7FF7C7B94F60h, 7FF7C7B94F67h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_alloc_64Bytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack128 ss_alloc_128()
; location: [7FF7C7B94F80h, 7FF7C7B94F91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
000ah mov [rcx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(4 bytes) = 48 89 41 08
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_alloc_128Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x48,0x89,0x01,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack256 ss_alloc_256()
; location: [7FF7C7B94FB0h, 7FF7C7B94FC5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
000dh vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_alloc_256Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack512 ss_alloc_512()
; location: [7FF7C7B94FE0h, 7FF7C7B94FFFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
000dh vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
0012h vmovdqu xmmword ptr [rcx+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 20
0017h vmovdqu xmmword ptr [rcx+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 30
001ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_alloc_512Bytes => new byte[32]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack1024 ss_alloc_1024()
; location: [7FF7C7B95020h, 7FF7C7B95053h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
000dh vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
0012h vmovdqu xmmword ptr [rcx+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 20
0017h vmovdqu xmmword ptr [rcx+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 30
001ch vmovdqu xmmword ptr [rcx+40h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 40
0021h vmovdqu xmmword ptr [rcx+50h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 50
0026h vmovdqu xmmword ptr [rcx+60h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 60
002bh vmovdqu xmmword ptr [rcx+70h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 70
0030h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_alloc_1024Bytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0xC5,0xFA,0x7F,0x41,0x40,0xC5,0xFA,0x7F,0x41,0x50,0xC5,0xFA,0x7F,0x41,0x60,0xC5,0xFA,0x7F,0x41,0x70,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void ss_store_128(in byte src, uint count, ref MemStack128 dst)
; location: [7FF7C7B95070h, 7FF7C7B95087h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
000bh mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
000eh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0011h call 7FF826FA6050h            ; CALL(Call_rel32_64) [5F410FE0h:jmp64]                encoding(5 bytes) = e8 ca 0f 41 5f
0016h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_store_128Bytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x49,0x8B,0xC8,0x44,0x8B,0xC2,0x48,0x8B,0xD0,0xE8,0xCA,0x0F,0x41,0x5F,0x90,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> ss_span_128x8(ref MemStack128 src)
; location: [7FF7C7B950A0h, 7FF7C7B950BCh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(3 bytes) = 48 89 11
0008h mov dword ptr [rcx+8],10h     ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,:sr),10h:imm32]  encoding(7 bytes) = c7 41 08 10 00 00 00
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0017h call 7FF8270CFC20h            ; CALL(Call_rel32_64) [5F53AB80h:jmp64]                encoding(5 bytes) = e8 64 ab 53 5f
001ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> ss_span_128x8Bytes => new byte[29]{0x48,0x83,0xEC,0x28,0x90,0x48,0x89,0x11,0xC7,0x41,0x08,0x10,0x00,0x00,0x00,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x64,0xAB,0x53,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> ss_span_256x8(ref MemStack256 src)
; location: [7FF7C7B950E0h, 7FF7C7B950FCh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(3 bytes) = 48 89 11
0008h mov dword ptr [rcx+8],20h     ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,:sr),20h:imm32]  encoding(7 bytes) = c7 41 08 20 00 00 00
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0017h call 7FF8270CFC20h            ; CALL(Call_rel32_64) [5F53AB40h:jmp64]                encoding(5 bytes) = e8 24 ab 53 5f
001ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> ss_span_256x8Bytes => new byte[29]{0x48,0x83,0xEC,0x28,0x90,0x48,0x89,0x11,0xC7,0x41,0x08,0x20,0x00,0x00,0x00,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x24,0xAB,0x53,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte ss_head_128x8(ref MemStack128 src)
; location: [7FF7C7B95120h, 7FF7C7B95128h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_head_128x8Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort ss_head_128x16(ref MemStack128 src)
; location: [7FF7C7B95140h, 7FF7C7B95148h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_head_128x16Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint ss_head_128x32(ref MemStack128 src)
; location: [7FF7C7B95160h, 7FF7C7B95168h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_head_128x32Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong ss_head_128x64(ref MemStack128 src)
; location: [7FF7C7B95180h, 7FF7C7B95188h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_head_128x64Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte ss_value_128x8(ref MemStack128 src, int index)
; location: [7FF7C7B951A0h, 7FF7C7B951ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0008h add rax,rcx                   ; ADD(Add_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 03 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_value_128x8Bytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x03,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort ss_value_128x16(ref MemStack128 src, int index)
; location: [7FF7C7B951C0h, 7FF7C7B951CCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0008h lea rax,[rcx+rax*2]           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 04 41
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_value_128x16Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x8D,0x04,0x41,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint ss_value_128x32(ref MemStack128 src, int index)
; location: [7FF7C7B951E0h, 7FF7C7B951ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0008h lea rax,[rcx+rax*4]           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 04 81
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_value_128x32Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x8D,0x04,0x81,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong ss_value_128x64(ref MemStack128 src, int index)
; location: [7FF7C7B95200h, 7FF7C7B9520Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0008h lea rax,[rcx+rax*8]           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 04 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_value_128x64Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x8D,0x04,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte ss_value_256x8(ref MemStack256 src, int index)
; location: [7FF7C7B95220h, 7FF7C7B9522Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0008h add rax,rcx                   ; ADD(Add_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 03 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_value_256x8Bytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x03,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort ss_value_256x16(ref MemStack256 src, int index)
; location: [7FF7C7B95240h, 7FF7C7B9524Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0008h lea rax,[rcx+rax*2]           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 04 41
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_value_256x16Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x8D,0x04,0x41,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint ss_value_256x32(ref MemStack256 src, int index)
; location: [7FF7C7B95260h, 7FF7C7B9526Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0008h lea rax,[rcx+rax*4]           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 04 81
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_value_256x32Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x8D,0x04,0x81,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong ss_value_256x64(ref MemStack256 src, int index)
; location: [7FF7C7B95280h, 7FF7C7B9528Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0008h lea rax,[rcx+rax*8]           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 04 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_value_256x64Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x8D,0x04,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: CharStack4 ss_alloc_c4()
; location: [7FF7C7B952A0h, 7FF7C7B952B3h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000bh mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
000fh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_alloc_c4Bytes => new byte[20]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: CharStack8 ss_alloc_c8()
; location: [7FF7C7B952D0h, 7FF7C7B952E0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_alloc_c8Bytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: CharStack32 ss_alloc_c32()
; location: [7FF7C7B95300h, 7FF7C7B9531Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
000dh vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
0012h vmovdqu xmmword ptr [rcx+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 20
0017h vmovdqu xmmword ptr [rcx+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 30
001ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_alloc_c32Bytes => new byte[32]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: CharStack64 ss_alloc_c64()
; location: [7FF7C7B95340h, 7FF7C7B95373h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
000dh vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
0012h vmovdqu xmmword ptr [rcx+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 20
0017h vmovdqu xmmword ptr [rcx+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 30
001ch vmovdqu xmmword ptr [rcx+40h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 40
0021h vmovdqu xmmword ptr [rcx+50h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 50
0026h vmovdqu xmmword ptr [rcx+60h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 60
002bh vmovdqu xmmword ptr [rcx+70h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 70
0030h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_alloc_c64Bytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0xC5,0xFA,0x7F,0x41,0x40,0xC5,0xFA,0x7F,0x41,0x50,0xC5,0xFA,0x7F,0x41,0x60,0xC5,0xFA,0x7F,0x41,0x70,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: CharStack8 ss_concat_8x8(CharStack4 head, CharStack4 tail)
; location: [7FF7C7B957A0h, 7FF7C7B95800h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+28h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 28
000ch mov [rsp+30h],r8              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R8]           encoding(5 bytes) = 4c 89 44 24 30
0011h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0016h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
001ah vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
001eh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0023h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0027h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
002bh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 28
0030h lea rdx,[rsp+8]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 08
0035h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0038h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
003bh lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 30
0040h lea rdx,[rsp+8]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 08
0045h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0049h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
004ch mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
004fh vmovdqu xmm0,xmmword ptr [rsp+8]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 08
0055h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0059h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005ch add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0060h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_concat_8x8Bytes => new byte[97]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x89,0x54,0x24,0x28,0x4C,0x89,0x44,0x24,0x30,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0x48,0x8D,0x44,0x24,0x28,0x48,0x8D,0x54,0x24,0x08,0x48,0x8B,0x00,0x48,0x89,0x02,0x48,0x8D,0x44,0x24,0x30,0x48,0x8D,0x54,0x24,0x08,0x48,0x83,0xC2,0x08,0x48,0x8B,0x00,0x48,0x89,0x02,0xC5,0xFA,0x6F,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref CharStack32 ss_concat_2x16_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
; location: [7FF7C7B95820h, 7FF7C7B95852h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0009h vmovdqu xmmword ptr [r8],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
000eh vmovdqu xmm0,xmmword ptr [rcx+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 41 10
0013h vmovdqu xmmword ptr [r8+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,:sr),XMM0] encoding(VEX, 6 bytes) = c4 c1 7a 7f 40 10
0019h lea rax,[r8+20h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 40 20
001dh vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0021h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0025h vmovdqu xmm0,xmmword ptr [rdx+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 10
002ah vmovdqu xmmword ptr [rax+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
002fh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_concat_2x16_bufferedBytes => new byte[51]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x00,0xC5,0xFA,0x6F,0x41,0x10,0xC4,0xC1,0x7A,0x7F,0x40,0x10,0x49,0x8D,0x40,0x20,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x42,0x10,0xC5,0xFA,0x7F,0x40,0x10,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref CharStack32 ss_concat_2x32_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
; location: [7FF7C7B95870h, 7FF7C7B958A2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0009h vmovdqu xmmword ptr [r8],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
000eh vmovdqu xmm0,xmmword ptr [rcx+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 41 10
0013h vmovdqu xmmword ptr [r8+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,:sr),XMM0] encoding(VEX, 6 bytes) = c4 c1 7a 7f 40 10
0019h lea rax,[r8+20h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 40 20
001dh vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0021h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0025h vmovdqu xmm0,xmmword ptr [rdx+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 10
002ah vmovdqu xmmword ptr [rax+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
002fh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ss_concat_2x32_bufferedBytes => new byte[51]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x00,0xC5,0xFA,0x6F,0x41,0x10,0xC4,0xC1,0x7A,0x7F,0x40,0x10,0x49,0x8D,0x40,0x20,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x42,0x10,0xC5,0xFA,0x7F,0x40,0x10,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack64 init_64x8(in byte src)
; location: [7FF7C7B958C0h, 7FF7C7B958E1h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000bh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000fh lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0013h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 11
0016h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0019h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
001dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> init_64x8Bytes => new byte[34]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x8B,0x11,0x48,0x89,0x10,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack64 init_64x16(in ushort src)
; location: [7FF7C7B95900h, 7FF7C7B95921h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000bh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000fh lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0013h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 11
0016h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0019h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
001dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> init_64x16Bytes => new byte[34]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x8B,0x11,0x48,0x89,0x10,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack64 init_64x32(in uint src)
; location: [7FF7C7B95940h, 7FF7C7B95961h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000bh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000fh lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0013h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 11
0016h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0019h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
001dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> init_64x32Bytes => new byte[34]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x8B,0x11,0x48,0x89,0x10,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack64 init_64x64(in ulong src)
; location: [7FF7C7B95980h, 7FF7C7B959A1h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000bh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000fh lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0013h mov rdx,[rcx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 11
0016h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0019h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
001dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> init_64x64Bytes => new byte[34]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x8B,0x11,0x48,0x89,0x10,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack128 init_128x8(in byte src)
; location: [7FF7C7B959C0h, 7FF7C7B95A09h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
000ch mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
0011h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0016h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
001bh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0020h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 02
0023h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
0026h add rax,8                     ; ADD(Add_rm64_imm8) [RAX,8h:imm64]                    encoding(4 bytes) = 48 83 c0 08
002ah mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
002eh mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0031h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 08
0036h mov rdx,[rsp+10h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 10
003bh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
003eh mov [rcx+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(4 bytes) = 48 89 51 08
0042h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0045h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0049h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> init_128x8Bytes => new byte[74]{0x48,0x83,0xEC,0x18,0x90,0x33,0xC0,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0x8D,0x44,0x24,0x08,0x4C,0x8B,0x02,0x4C,0x89,0x00,0x48,0x83,0xC0,0x08,0x48,0x8B,0x52,0x08,0x48,0x89,0x10,0x48,0x8B,0x44,0x24,0x08,0x48,0x8B,0x54,0x24,0x10,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack256 init_256x8(in byte src)
; location: [7FF7C7B95A20h, 7FF7C7B95AABh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
000ch vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0010h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0014h vmovdqu xmmword ptr [rax+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
0019h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001eh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0022h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0026h vmovdqu xmmword ptr [rax+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
002bh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0030h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 02
0033h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
0036h lea r8,[rax+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 08
003ah mov r9,[rdx+8]                ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)]           encoding(4 bytes) = 4c 8b 4a 08
003eh mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),R9]            encoding(3 bytes) = 4d 89 08
0041h lea r8,[rax+10h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 10
0045h mov r9,[rdx+10h]              ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)]           encoding(4 bytes) = 4c 8b 4a 10
0049h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),R9]            encoding(3 bytes) = 4d 89 08
004ch add rax,18h                   ; ADD(Add_rm64_imm8) [RAX,18h:imm64]                   encoding(4 bytes) = 48 83 c0 18
0050h mov rdx,[rdx+18h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 18
0054h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0057h vmovdqu xmm0,xmmword ptr [rsp+8]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 08
005dh vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0063h vmovdqu xmm0,xmmword ptr [rsp+18h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 18
0069h vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
006fh vmovdqu xmm0,xmmword ptr [rsp+28h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 28
0075h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0079h vmovdqu xmm0,xmmword ptr [rsp+38h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 38
007fh vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
0084h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0087h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
008bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> init_256x8Bytes => new byte[140]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x48,0x8D,0x44,0x24,0x08,0x4C,0x8B,0x02,0x4C,0x89,0x00,0x4C,0x8D,0x40,0x08,0x4C,0x8B,0x4A,0x08,0x4D,0x89,0x08,0x4C,0x8D,0x40,0x10,0x4C,0x8B,0x4A,0x10,0x4D,0x89,0x08,0x48,0x83,0xC0,0x18,0x48,0x8B,0x52,0x18,0x48,0x89,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xFA,0x6F,0x44,0x24,0x18,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xFA,0x6F,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x38,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack256 init_256x32(in uint src)
; location: [7FF7C7B95AD0h, 7FF7C7B95B5Bh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
000ch vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0010h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0014h vmovdqu xmmword ptr [rax+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
0019h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001eh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0022h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0026h vmovdqu xmmword ptr [rax+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
002bh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0030h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 02
0033h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
0036h lea r8,[rax+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 08
003ah mov r9,[rdx+8]                ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)]           encoding(4 bytes) = 4c 8b 4a 08
003eh mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),R9]            encoding(3 bytes) = 4d 89 08
0041h lea r8,[rax+10h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 10
0045h mov r9,[rdx+10h]              ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)]           encoding(4 bytes) = 4c 8b 4a 10
0049h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),R9]            encoding(3 bytes) = 4d 89 08
004ch add rax,18h                   ; ADD(Add_rm64_imm8) [RAX,18h:imm64]                   encoding(4 bytes) = 48 83 c0 18
0050h mov rdx,[rdx+18h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 18
0054h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0057h vmovdqu xmm0,xmmword ptr [rsp+8]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 08
005dh vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0063h vmovdqu xmm0,xmmword ptr [rsp+18h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 18
0069h vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
006fh vmovdqu xmm0,xmmword ptr [rsp+28h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 28
0075h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0079h vmovdqu xmm0,xmmword ptr [rsp+38h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 38
007fh vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
0084h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0087h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
008bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> init_256x32Bytes => new byte[140]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x48,0x8D,0x44,0x24,0x08,0x4C,0x8B,0x02,0x4C,0x89,0x00,0x4C,0x8D,0x40,0x08,0x4C,0x8B,0x4A,0x08,0x4D,0x89,0x08,0x4C,0x8D,0x40,0x10,0x4C,0x8B,0x4A,0x10,0x4D,0x89,0x08,0x48,0x83,0xC0,0x18,0x48,0x8B,0x52,0x18,0x48,0x89,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xFA,0x6F,0x44,0x24,0x18,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xFA,0x6F,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x38,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack512 init_512x8(in byte src)
; location: [7FF7C7B95B80h, 7FF7C7B95C1Ch]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
000ch vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0010h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0014h vmovdqu xmmword ptr [rax+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
0019h vmovdqu xmmword ptr [rax+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 20
001eh vmovdqu xmmword ptr [rax+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 30
0023h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0028h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
002ch vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0030h vmovdqu xmmword ptr [rax+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
0035h vmovdqu xmmword ptr [rax+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 20
003ah vmovdqu xmmword ptr [rax+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 30
003fh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0044h vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0048h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
004ch vmovdqu xmm0,xmmword ptr [rdx+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 10
0051h vmovdqu xmmword ptr [rax+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
0056h vmovdqu xmm0,xmmword ptr [rdx+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 20
005bh vmovdqu xmmword ptr [rax+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 20
0060h vmovdqu xmm0,xmmword ptr [rdx+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 30
0065h vmovdqu xmmword ptr [rax+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 30
006ah vmovdqu xmm0,xmmword ptr [rsp+8]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 08
0070h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0074h vmovdqu xmm0,xmmword ptr [rsp+18h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 18
007ah vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
007fh vmovdqu xmm0,xmmword ptr [rsp+28h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 28
0085h vmovdqu xmmword ptr [rcx+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 20
008ah vmovdqu xmm0,xmmword ptr [rsp+38h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 38
0090h vmovdqu xmmword ptr [rcx+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 30
0095h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0098h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
009ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> init_512x8Bytes => new byte[157]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0xC5,0xFA,0x7F,0x40,0x20,0xC5,0xFA,0x7F,0x40,0x30,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0xC5,0xFA,0x7F,0x40,0x20,0xC5,0xFA,0x7F,0x40,0x30,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x42,0x10,0xC5,0xFA,0x7F,0x40,0x10,0xC5,0xFA,0x6F,0x42,0x20,0xC5,0xFA,0x7F,0x40,0x20,0xC5,0xFA,0x6F,0x42,0x30,0xC5,0xFA,0x7F,0x40,0x30,0xC5,0xFA,0x6F,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x18,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x6F,0x44,0x24,0x38,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: MemStack1024 init_1024x8(in byte src)
; location: [7FF7C7B95C50h, 7FF7C7B95CE8h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,80h                   ; SUB(Sub_rm64_imm32) [RSP,80h:imm64]                  encoding(7 bytes) = 48 81 ec 80 00 00 00
0008h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000bh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000eh lea rcx,[rsp]                 ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 0c 24
0012h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0016h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
001ah vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
001fh vmovdqu xmmword ptr [rcx+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 20
0024h vmovdqu xmmword ptr [rcx+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 30
0029h vmovdqu xmmword ptr [rcx+40h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 40
002eh vmovdqu xmmword ptr [rcx+50h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 50
0033h vmovdqu xmmword ptr [rcx+60h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 60
0038h vmovdqu xmmword ptr [rcx+70h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 70
003dh lea rcx,[rsp]                 ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 0c 24
0041h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0045h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0049h vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
004eh vmovdqu xmmword ptr [rcx+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 20
0053h vmovdqu xmmword ptr [rcx+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 30
0058h vmovdqu xmmword ptr [rcx+40h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 40
005dh vmovdqu xmmword ptr [rcx+50h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 50
0062h vmovdqu xmmword ptr [rcx+60h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 60
0067h vmovdqu xmmword ptr [rcx+70h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 70
006ch lea rcx,[rsp]                 ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 0c 24
0070h mov r8d,80h                   ; MOV(Mov_r32_imm32) [R8D,80h:imm32]                   encoding(6 bytes) = 41 b8 80 00 00 00
0076h call 7FF826FA6050h            ; CALL(Call_rel32_64) [5F410400h:jmp64]                encoding(5 bytes) = e8 85 03 41 5f
007bh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
007eh lea rdx,[rsp]                 ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 14 24
0082h mov r8d,80h                   ; MOV(Mov_r32_imm32) [R8D,80h:imm32]                   encoding(6 bytes) = 41 b8 80 00 00 00
0088h call 7FF826FA6050h            ; CALL(Call_rel32_64) [5F410400h:jmp64]                encoding(5 bytes) = e8 73 03 41 5f
008dh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0090h add rsp,80h                   ; ADD(Add_rm64_imm32) [RSP,80h:imm64]                  encoding(7 bytes) = 48 81 c4 80 00 00 00
0097h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0098h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> init_1024x8Bytes => new byte[153]{0x56,0x48,0x81,0xEC,0x80,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x0C,0x24,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0xC5,0xFA,0x7F,0x41,0x40,0xC5,0xFA,0x7F,0x41,0x50,0xC5,0xFA,0x7F,0x41,0x60,0xC5,0xFA,0x7F,0x41,0x70,0x48,0x8D,0x0C,0x24,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0xC5,0xFA,0x7F,0x41,0x40,0xC5,0xFA,0x7F,0x41,0x50,0xC5,0xFA,0x7F,0x41,0x60,0xC5,0xFA,0x7F,0x41,0x70,0x48,0x8D,0x0C,0x24,0x41,0xB8,0x80,0x00,0x00,0x00,0xE8,0x85,0x03,0x41,0x5F,0x48,0x8B,0xCE,0x48,0x8D,0x14,0x24,0x41,0xB8,0x80,0x00,0x00,0x00,0xE8,0x73,0x03,0x41,0x5F,0x48,0x8B,0xC6,0x48,0x81,0xC4,0x80,0x00,0x00,0x00,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
