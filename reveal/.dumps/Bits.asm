; 2019-11-04 04:06:03:567
; function: sbyte toggle(sbyte src, int pos)
; location: [7FFDDBB07890h, 7FFDDBB078B2h]
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
; location: [7FFDDBB078D0h, 7FFDDBB078EFh]
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
; location: [7FFDDBB07900h, 7FFDDBB07922h]
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
; location: [7FFDDBB07940h, 7FFDDBB0795Fh]
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
; location: [7FFDDBB07970h, 7FFDDBB07985h]
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
; location: [7FFDDBB079A0h, 7FFDDBB079B5h]
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
; location: [7FFDDBB079D0h, 7FFDDBB079E6h]
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
; location: [7FFDDBB07A00h, 7FFDDBB07A16h]
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
; location: [7FFDDBB07A30h, 7FFDDBB07A54h]
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
; location: [7FFDDBB07A70h, 7FFDDBB07A94h]
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
; location: [7FFDDBB07AB0h, 7FFDDBB07AC9h]
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
; location: [7FFDDBB07AE0h, 7FFDDBB07AF9h]
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
; location: [7FFDDBB07B10h, 7FFDDBB07B2Ah]
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
; location: [7FFDDBB07B40h, 7FFDDBB07B5Ah]
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
; location: [7FFDDBB07B70h, 7FFDDBB07B86h]
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
; location: [7FFDDBB07BA0h, 7FFDDBB07BB6h]
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
; location: [7FFDDBB07BD0h, 7FFDDBB07BE6h]
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
; location: [7FFDDBB07C00h, 7FFDDBB07C16h]
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
; location: [7FFDDBB07C30h, 7FFDDBB07C46h]
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
; location: [7FFDDBB07C60h, 7FFDDBB07C76h]
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
; location: [7FFDDBB07C90h, 7FFDDBB07CA4h]
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
; location: [7FFDDBB07CC0h, 7FFDDBB07CD4h]
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
; location: [7FFDDBB07CF0h, 7FFDDBB07D00h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt eax,[rcx]               ; LZCNT(Lzcnt_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]    encoding(4 bytes) = f3 0f bd 01
000bh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000dh add eax,20h                   ; ADD(Add_rm32_imm8) [EAX,20h:imm32]                   encoding(3 bytes) = 83 c0 20
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBD,0x01,0xF7,0xD8,0x83,0xC0,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitSize width(in ulong src)
; location: [7FFDDBB07D20h, 7FFDDBB07D31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt rax,[rcx]               ; LZCNT(Lzcnt_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]    encoding(5 bytes) = f3 48 0f bd 01
000ch neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000eh add eax,40h                   ; ADD(Add_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 c0 40
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBD,0x01,0xF7,0xD8,0x83,0xC0,0x40,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xorsl(sbyte src, int offset)
; location: [7FFDDBB07D50h, 7FFDDBB07D6Bh]
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
; location: [7FFDDBB07D80h, 7FFDDBB07D99h]
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
; location: [7FFDDBB07DB0h, 7FFDDBB07DCBh]
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
; location: [7FFDDBB07DE0h, 7FFDDBB07DF9h]
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
; location: [7FFDDBB07E10h, 7FFDDBB07E22h]
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
; location: [7FFDDBB07E40h, 7FFDDBB07E52h]
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
; location: [7FFDDBB07E70h, 7FFDDBB07E83h]
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
; location: [7FFDDBB07EA0h, 7FFDDBB07EB3h]
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
; location: [7FFDDBB07ED0h, 7FFDDBB07EEDh]
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
; location: [7FFDDBB07F00h, 7FFDDBB07F1Dh]
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
; location: [7FFDDBB07F30h, 7FFDDBB07F4Eh]
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
; location: [7FFDDBB07F60h, 7FFDDBB07F7Eh]
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
; location: [7FFDDBB07F90h, 7FFDDBB07FA9h]
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
; location: [7FFDDBB07FC0h, 7FFDDBB07FD9h]
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
; location: [7FFDDBB07FF0h, 7FFDDBB08009h]
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
; location: [7FFDDBB08020h, 7FFDDBB08039h]
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
; location: [7FFDDBB08050h, 7FFDDBB0806Bh]
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
; location: [7FFDDBB08080h, 7FFDDBB08099h]
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
; location: [7FFDDBB080B0h, 7FFDDBB080CBh]
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
; location: [7FFDDBB080E0h, 7FFDDBB080F9h]
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
; location: [7FFDDBB08110h, 7FFDDBB08122h]
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
; location: [7FFDDBB08140h, 7FFDDBB08152h]
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
; location: [7FFDDBB08170h, 7FFDDBB08183h]
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
; location: [7FFDDBB081A0h, 7FFDDBB081B3h]
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
; location: [7FFDDBB081D0h, 7FFDDBB081EDh]
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
; location: [7FFDDBB08200h, 7FFDDBB0821Dh]
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
; location: [7FFDDBB08230h, 7FFDDBB0824Eh]
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
; location: [7FFDDBB08260h, 7FFDDBB0827Eh]
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
; location: [7FFDDBB08290h, 7FFDDBB082A9h]
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
; location: [7FFDDBB082C0h, 7FFDDBB082D9h]
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
; location: [7FFDDBB082F0h, 7FFDDBB08309h]
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
; location: [7FFDDBB08320h, 7FFDDBB08339h]
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
; function: ushort lo(uint src)
; location: [7FFDDBB08350h, 7FFDDBB08358h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int lo(long src)
; location: [7FFDDBB08370h, 7FFDDBB08377h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint lo(ulong src)
; location: [7FFDDBB08390h, 7FFDDBB08397h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte loff(ref sbyte src)
; location: [7FFDDBB083B0h, 7FFDDBB083C7h]
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
; location: [7FFDDBB083E0h, 7FFDDBB083F5h]
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
; location: [7FFDDBB08410h, 7FFDDBB08428h]
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
; location: [7FFDDBB08440h, 7FFDDBB08456h]
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
; location: [7FFDDBB08470h, 7FFDDBB08481h]
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
; location: [7FFDDBB084A0h, 7FFDDBB084B1h]
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
; location: [7FFDDBB084D0h, 7FFDDBB084E5h]
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
; location: [7FFDDBB08500h, 7FFDDBB08515h]
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
; location: [7FFDDBB08530h, 7FFDDBB08549h]
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
; location: [7FFDDBB08560h, 7FFDDBB08579h]
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
; location: [7FFDDBB08590h, 7FFDDBB085A8h]
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
; location: [7FFDDBB085C0h, 7FFDDBB085DAh]
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
; location: [7FFDDBB085F0h, 7FFDDBB08606h]
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
; location: [7FFDDBB08620h, 7FFDDBB08644h]
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
; location: [7FFDDBB08660h, 7FFDDBB08692h]
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
; location: [7FFDDBB086B0h, 7FFDDBB086F1h]
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
; location: [7FFDDBB08710h, 7FFDDBB08760h]
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
; location: [7FFDDBB08780h, 7FFDDBB087DFh]
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
; location: [7FFDDBB087F0h, 7FFDDBB0885Eh]
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
; location: [7FFDDBB08870h, 7FFDDBB088E9h]
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
; location: [7FFDDBB08900h, 7FFDDBB0890Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFE8h            ; ADD(Add_rm32_imm8) [EAX,ffffffffffffffe8h:imm32]     encoding(3 bytes) = 83 c0 e8
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint nlz(in ushort src)
; location: [7FFDDBB08920h, 7FFDDBB0892Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [EAX,fffffffffffffff0h:imm32]     encoding(3 bytes) = 83 c0 f0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint nlz(in uint src)
; location: [7FFDDBB08940h, 7FFDDBB0894Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt eax,[rcx]               ; LZCNT(Lzcnt_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]    encoding(4 bytes) = f3 0f bd 01
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBD,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint nlz(in ulong src)
; location: [7FFDDBB08960h, 7FFDDBB0896Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt rax,[rcx]               ; LZCNT(Lzcnt_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]    encoding(5 bytes) = f3 48 0f bd 01
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBD,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(sbyte src)
; location: [7FFDDBB08980h, 7FFDDBB0898Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(byte src)
; location: [7FFDDBB089A0h, 7FFDDBB089ACh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(short src)
; location: [7FFDDBB089C0h, 7FFDDBB089CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(ushort src)
; location: [7FFDDBB089E0h, 7FFDDBB089ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(int src)
; location: [7FFDDBB08A00h, 7FFDDBB08A0Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt eax,ecx                 ; TZCNT(Tzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bc c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(uint src)
; location: [7FFDDBB08A20h, 7FFDDBB08A2Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt eax,ecx                 ; TZCNT(Tzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bc c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(long src)
; location: [7FFDDBB08A40h, 7FFDDBB08A4Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt rax,rcx                 ; TZCNT(Tzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bc c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(ulong src)
; location: [7FFDDBB08A60h, 7FFDDBB08A6Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt rax,rcx                 ; TZCNT(Tzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bc c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(bit b0, bit b1)
; location: [7FFDDBB08A80h, 7FFDDBB08A8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0xD1,0xE2,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(bit b0, bit b1, bit b2)
; location: [7FFDDBB08AA0h, 7FFDDBB08AB2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000bh shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
000fh or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0xD1,0xE2,0x8B,0xC1,0x0B,0xC2,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(bit b0, bit b1, bit b2, bit b3)
; location: [7FFDDBB08AD0h, 7FFDDBB08AE9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000bh shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
000fh or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
0012h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0016h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0xD1,0xE2,0x8B,0xC1,0x0B,0xC2,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xC0,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(bit b0, bit b1, bit b2, bit b3, bit b4)
; location: [7FFDDBB08B00h, 7FFDDBB08B22h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000bh shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
000fh or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
0012h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0016h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0019h mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
001dh shl edx,4                     ; SHL(Shl_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 e2 04
0020h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0xD1,0xE2,0x8B,0xC1,0x0B,0xC2,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xC0,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC1,0x8B,0x54,0x24,0x28,0xC1,0xE2,0x04,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(bit b0, bit b1, bit b2, bit b3, bit b4, bit b5, bit b6, bit b7)
; location: [7FFDDBB08B40h, 7FFDDBB08B78h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0007h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0009h shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
000dh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0010h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0014h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
0017h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
001bh shl eax,1                     ; SHL(Shl_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e0
001dh or eax,[rsp+28h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 44 24 28
0021h mov ecx,[rsp+38h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 38
0025h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0028h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
002ah mov ecx,[rsp+40h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 40
002eh shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0031h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0033h shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0036h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[57]{0x0F,0x1F,0x44,0x00,0x00,0xD1,0xE2,0x0B,0xD1,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xD0,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xD1,0x8B,0x44,0x24,0x30,0xD1,0xE0,0x0B,0x44,0x24,0x28,0x8B,0x4C,0x24,0x38,0xC1,0xE1,0x02,0x0B,0xC1,0x8B,0x4C,0x24,0x40,0xC1,0xE1,0x03,0x0B,0xC1,0xC1,0xE0,0x04,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N1 n, in bit src, ref uint dst)
; location: [7FFDDBB08B90h, 7FFDDBB08BA2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0008h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
000ah or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000fh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x12,0x0B,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N2 n, in bit src, ref uint dst)
; location: [7FFDDBB08BC0h, 7FFDDBB08BDFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0008h mov ecx,[rdx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 0a
000ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000fh mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0012h mov edx,[rdx+4]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 04
0015h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0017h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0019h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
001ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x0A,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x52,0x04,0xD1,0xE2,0x0B,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N3 n, in bit src, ref uint dst)
; location: [7FFDDBB08BF0h, 7FFDDBB08C1Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0008h mov ecx,[rdx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 0a
000ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000fh mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0012h mov ecx,[rdx+4]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 04
0015h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0017h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0019h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
001ch mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
001fh mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0022h shl edx,2                     ; SHL(Shl_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 e2 02
0025h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0027h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
002ah mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[46]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x0A,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x04,0xD1,0xE1,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x52,0x08,0xC1,0xE2,0x02,0x0B,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N4 n, in bit src, ref uint dst)
; location: [7FFDDBB08C30h, 7FFDDBB08C6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0008h mov ecx,[rdx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 0a
000ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000fh mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0012h mov ecx,[rdx+4]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 04
0015h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0017h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0019h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
001ch mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
001fh mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 08
0022h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0025h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0027h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
002ah mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
002dh mov edx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 0c
0030h shl edx,3                     ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 e2 03
0033h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0035h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0038h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[60]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x0A,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x04,0xD1,0xE1,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x08,0xC1,0xE1,0x02,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x52,0x0C,0xC1,0xE2,0x03,0x0B,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N8 n, in bit src, ref uint dst)
; location: [7FFDDBB08C80h, 7FFDDBB08CF6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0008h mov ecx,[rdx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 0a
000ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000fh mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0012h mov ecx,[rdx+4]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 04
0015h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0017h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0019h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
001ch mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
001fh mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 08
0022h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0025h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0027h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
002ah mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
002dh mov ecx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 0c
0030h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0033h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0035h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0038h add rdx,10h                   ; ADD(Add_rm64_imm8) [RDX,10h:imm64]                   encoding(4 bytes) = 48 83 c2 10
003ch lea rax,[r8+10h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 49 8d 40 10
0040h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0042h mov r9d,[rdx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 0a
0045h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0048h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
004ah mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
004ch mov r9d,[rdx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 04
0050h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
0053h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0056h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
0058h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
005ah mov r9d,[rdx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 08
005eh shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
0062h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0065h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
0067h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0069h mov edx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 0c
006ch shl edx,3                     ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 e2 03
006fh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0071h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0073h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0076h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[119]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x0A,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x04,0xD1,0xE1,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x08,0xC1,0xE1,0x02,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x0C,0xC1,0xE1,0x03,0x0B,0xC1,0x41,0x89,0x00,0x48,0x83,0xC2,0x10,0x49,0x8D,0x40,0x10,0x8B,0x08,0x44,0x8B,0x0A,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x8B,0x52,0x0C,0xC1,0xE2,0x03,0x0B,0xD1,0x89,0x10,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N16 n, in bit src, ref uint dst)
; location: [7FFDDBB08D10h, 7FFDDBB08E07h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0008h mov ecx,[rdx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 0a
000ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000fh mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0012h mov ecx,[rdx+4]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 04
0015h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0017h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0019h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
001ch mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
001fh mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 08
0022h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0025h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0027h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
002ah mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
002dh mov ecx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 0c
0030h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0033h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0035h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0038h lea rax,[rdx+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 48 8d 42 10
003ch lea rcx,[r8+10h]              ; LEA(Lea_r64_m) [RCX,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 49 8d 48 10
0040h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
0043h mov r10d,[rax]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(3 bytes) = 44 8b 10
0046h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0049h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
004ch mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
004fh mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 04
0053h shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
0056h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0059h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
005ch mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
005fh mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 08
0063h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0067h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
006ah mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
006dh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
0070h mov eax,[rax+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 0c
0073h shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
0076h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0079h mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
007bh add rdx,20h                   ; ADD(Add_rm64_imm8) [RDX,20h:imm64]                   encoding(4 bytes) = 48 83 c2 20
007fh lea rax,[r8+20h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 49 8d 40 20
0083h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0085h mov r9d,[rdx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 0a
0088h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
008bh mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
008dh mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
008fh mov r9d,[rdx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 04
0093h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
0096h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0099h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
009bh mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
009dh mov r9d,[rdx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 08
00a1h shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
00a5h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
00a8h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
00aah mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
00ach mov r9d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 0c
00b0h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
00b4h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
00b7h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
00b9h add rdx,10h                   ; ADD(Add_rm64_imm8) [RDX,10h:imm64]                   encoding(4 bytes) = 48 83 c2 10
00bdh add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
00c1h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
00c3h mov r9d,[rdx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 0a
00c6h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
00c9h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
00cbh mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
00cdh mov r9d,[rdx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 04
00d1h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
00d4h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
00d7h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
00d9h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
00dbh mov r9d,[rdx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 08
00dfh shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
00e3h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
00e6h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
00e8h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
00eah mov edx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 0c
00edh shl edx,3                     ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 e2 03
00f0h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
00f2h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
00f4h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
00f7h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[248]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x0A,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x04,0xD1,0xE1,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x08,0xC1,0xE1,0x02,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x0C,0xC1,0xE1,0x03,0x0B,0xC1,0x41,0x89,0x00,0x48,0x8D,0x42,0x10,0x49,0x8D,0x48,0x10,0x44,0x8B,0x09,0x44,0x8B,0x10,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x8B,0x40,0x0C,0xC1,0xE0,0x03,0x41,0x0B,0xC1,0x89,0x01,0x48,0x83,0xC2,0x20,0x49,0x8D,0x40,0x20,0x8B,0x08,0x44,0x8B,0x0A,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x0C,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC9,0x89,0x08,0x48,0x83,0xC2,0x10,0x48,0x83,0xC0,0x10,0x8B,0x08,0x44,0x8B,0x0A,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x8B,0x52,0x0C,0xC1,0xE2,0x03,0x0B,0xD1,0x89,0x10,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N32 n, in bit src, ref uint dst)
; location: [7FFDDBB08E20h, 7FFDDBB09022h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0008h mov ecx,[rdx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 0a
000ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000fh mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
0012h mov ecx,[rdx+4]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 04
0015h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0017h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0019h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
001ch mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
001fh mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 08
0022h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0025h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0027h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
002ah mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,DS:sr)]         encoding(3 bytes) = 41 8b 00
002dh mov ecx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 0c
0030h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0033h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0035h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0038h lea rax,[rdx+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 48 8d 42 10
003ch lea rcx,[r8+10h]              ; LEA(Lea_r64_m) [RCX,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 49 8d 48 10
0040h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
0043h mov r10d,[rax]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(3 bytes) = 44 8b 10
0046h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0049h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
004ch mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
004fh mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 04
0053h shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
0056h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0059h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
005ch mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
005fh mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 08
0063h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0067h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
006ah mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
006dh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
0070h mov eax,[rax+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 0c
0073h shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
0076h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0079h mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
007bh lea rax,[rdx+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 48 8d 42 20
007fh lea rcx,[r8+20h]              ; LEA(Lea_r64_m) [RCX,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 49 8d 48 20
0083h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
0086h mov r10d,[rax]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(3 bytes) = 44 8b 10
0089h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
008ch mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
008fh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
0092h mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 04
0096h shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
0099h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
009ch mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
009fh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
00a2h mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 08
00a6h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
00aah or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
00adh mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
00b0h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
00b3h mov r10d,[rax+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 0c
00b7h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
00bbh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
00beh mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
00c1h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
00c5h add rcx,10h                   ; ADD(Add_rm64_imm8) [RCX,10h:imm64]                   encoding(4 bytes) = 48 83 c1 10
00c9h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
00cch mov r10d,[rax]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(3 bytes) = 44 8b 10
00cfh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
00d2h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
00d5h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
00d8h mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 04
00dch shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
00dfh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
00e2h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
00e5h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
00e8h mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 08
00ech shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
00f0h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
00f3h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 09
00f6h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
00f9h mov eax,[rax+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 0c
00fch shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
00ffh or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0102h mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
0104h add rdx,40h                   ; ADD(Add_rm64_imm8) [RDX,40h:imm64]                   encoding(4 bytes) = 48 83 c2 40
0108h lea rax,[r8+40h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 49 8d 40 40
010ch mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
010eh mov r9d,[rdx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 0a
0111h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0114h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
0116h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0118h mov r9d,[rdx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 04
011ch shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
011fh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0122h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
0124h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0126h mov r9d,[rdx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 08
012ah shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
012eh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0131h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
0133h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0135h mov r9d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 0c
0139h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
013dh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0140h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
0142h lea rcx,[rdx+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 48 8d 4a 10
0146h lea r9,[rax+10h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 10
014ah mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
014dh mov r11d,[rcx]                ; MOV(Mov_r32_rm32) [R11D,mem(32u,RCX:br,DS:sr)]       encoding(3 bytes) = 44 8b 19
0150h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0153h mov [r9],r10d                 ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),R10D]        encoding(3 bytes) = 45 89 11
0156h mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
0159h mov r11d,[rcx+4]              ; MOV(Mov_r32_rm32) [R11D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 59 04
015dh shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
0160h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0163h mov [r9],r10d                 ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),R10D]        encoding(3 bytes) = 45 89 11
0166h mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
0169h mov r11d,[rcx+8]              ; MOV(Mov_r32_rm32) [R11D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 59 08
016dh shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
0171h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0174h mov [r9],r10d                 ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),R10D]        encoding(3 bytes) = 45 89 11
0177h mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
017ah mov ecx,[rcx+0Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 0c
017dh shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0180h or ecx,r10d                   ; OR(Or_r32_rm32) [ECX,R10D]                           encoding(3 bytes) = 41 0b ca
0183h mov [r9],ecx                  ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),ECX]         encoding(3 bytes) = 41 89 09
0186h add rdx,20h                   ; ADD(Add_rm64_imm8) [RDX,20h:imm64]                   encoding(4 bytes) = 48 83 c2 20
018ah add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
018eh mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0190h mov r9d,[rdx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 0a
0193h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0196h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
0198h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
019ah mov r9d,[rdx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 04
019eh shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
01a1h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
01a4h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
01a6h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
01a8h mov r9d,[rdx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 08
01ach shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
01b0h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
01b3h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
01b5h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
01b7h mov r9d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 0c
01bbh shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
01bfh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
01c2h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
01c4h add rdx,10h                   ; ADD(Add_rm64_imm8) [RDX,10h:imm64]                   encoding(4 bytes) = 48 83 c2 10
01c8h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
01cch mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
01ceh mov r9d,[rdx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 0a
01d1h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
01d4h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
01d6h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
01d8h mov r9d,[rdx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 04
01dch shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
01dfh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
01e2h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
01e4h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
01e6h mov r9d,[rdx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 4a 08
01eah shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
01eeh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
01f1h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
01f3h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
01f5h mov edx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 0c
01f8h shl edx,3                     ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 e2 03
01fbh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
01fdh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
01ffh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0202h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[515]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x0A,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x04,0xD1,0xE1,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x08,0xC1,0xE1,0x02,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x0C,0xC1,0xE1,0x03,0x0B,0xC1,0x41,0x89,0x00,0x48,0x8D,0x42,0x10,0x49,0x8D,0x48,0x10,0x44,0x8B,0x09,0x44,0x8B,0x10,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x8B,0x40,0x0C,0xC1,0xE0,0x03,0x41,0x0B,0xC1,0x89,0x01,0x48,0x8D,0x42,0x20,0x49,0x8D,0x48,0x20,0x44,0x8B,0x09,0x44,0x8B,0x10,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x44,0x89,0x09,0x48,0x83,0xC0,0x10,0x48,0x83,0xC1,0x10,0x44,0x8B,0x09,0x44,0x8B,0x10,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x8B,0x40,0x0C,0xC1,0xE0,0x03,0x41,0x0B,0xC1,0x89,0x01,0x48,0x83,0xC2,0x40,0x49,0x8D,0x40,0x40,0x8B,0x08,0x44,0x8B,0x0A,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x0C,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC9,0x89,0x08,0x48,0x8D,0x4A,0x10,0x4C,0x8D,0x48,0x10,0x45,0x8B,0x11,0x44,0x8B,0x19,0x45,0x0B,0xD3,0x45,0x89,0x11,0x45,0x8B,0x11,0x44,0x8B,0x59,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x45,0x89,0x11,0x45,0x8B,0x11,0x44,0x8B,0x59,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x45,0x89,0x11,0x45,0x8B,0x11,0x8B,0x49,0x0C,0xC1,0xE1,0x03,0x41,0x0B,0xCA,0x41,0x89,0x09,0x48,0x83,0xC2,0x20,0x48,0x83,0xC0,0x20,0x8B,0x08,0x44,0x8B,0x0A,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x0C,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC9,0x89,0x08,0x48,0x83,0xC2,0x10,0x48,0x83,0xC0,0x10,0x8B,0x08,0x44,0x8B,0x0A,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x8B,0x52,0x0C,0xC1,0xE2,0x03,0x0B,0xD1,0x89,0x10,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pack(byte x0, byte x1)
; location: [7FFDDBB09040h, 7FFDDBB09053h]
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
; location: [7FFDDBB09070h, 7FFDDBB09080h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC1,0xE2,0x10,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(in uint x0, in uint x1)
; location: [7FFDDBB090A0h, 7FFDDBB090B0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0009h shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
000dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8B,0x12,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(byte x0, byte x1, byte x2, byte x3)
; location: [7FFDDBB090D0h, 7FFDDBB090F2h]
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
; function: ulong pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
; location: [7FFDDBB09110h, 7FFDDBB09170h]
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
; function: ref byte packseq(ReadOnlySpan<byte> src, out byte dst)
; location: [7FFDDBB09190h, 7FFDDBB091EDh]
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
0058h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F545D70h:jmp64]                encoding(5 bytes) = e8 13 5d 54 5f
005dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[94]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0xC6,0x02,0x00,0x41,0x83,0xF8,0x08,0x7D,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x08,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x28,0x45,0x3B,0xD0,0x73,0x2B,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x12,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB6,0xCB,0x08,0x0A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD8,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x13,0x5D,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte packseq(out byte dst, Byte[] src)
; location: [7FFDDBB09210h, 7FFDDBB0926Ah]
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
0055h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F545CF0h:jmp64]                encoding(5 bytes) = e8 96 5c 54 5f
005ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[91]{0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0xC6,0x00,0x00,0x44,0x8B,0x42,0x08,0x45,0x8B,0xC8,0x41,0x83,0xF9,0x08,0x7D,0x02,0xEB,0x06,0x41,0xB9,0x08,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x29,0x45,0x3B,0xD0,0x73,0x29,0x49,0x63,0xCA,0x80,0x7C,0x0A,0x10,0x01,0x75,0x12,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB6,0xCB,0x08,0x08,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD7,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x96,0x5C,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint packseq(out uint dst, Byte[] src)
; location: [7FFDDBB09280h, 7FFDDBB092DBh]
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
0056h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F545C80h:jmp64]                encoding(5 bytes) = e8 25 5c 54 5f
005bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[92]{0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0x33,0xC9,0x89,0x08,0x44,0x8B,0x42,0x08,0x45,0x8B,0xC8,0x41,0x83,0xF9,0x20,0x7D,0x02,0xEB,0x06,0x41,0xB9,0x20,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x29,0x45,0x3B,0xD0,0x73,0x29,0x49,0x63,0xCA,0x80,0x7C,0x0A,0x10,0x01,0x75,0x12,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB6,0xCB,0x09,0x08,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD7,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x25,0x5C,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort packseq(ReadOnlySpan<byte> src, out ushort dst)
; location: [7FFDDBB092F0h, 7FFDDBB09350h]
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
005bh call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F545C10h:jmp64]                encoding(5 bytes) = e8 b0 5b 54 5f
0060h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[97]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0x66,0xC7,0x02,0x00,0x00,0x41,0x83,0xF8,0x10,0x7D,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x10,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x29,0x45,0x3B,0xD0,0x73,0x2C,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x13,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB7,0xCB,0x66,0x09,0x0A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD7,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xB0,0x5B,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint packseq(ReadOnlySpan<byte> src, out uint dst)
; location: [7FFDDBB09370h, 7FFDDBB093CBh]
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
0056h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F545B90h:jmp64]                encoding(5 bytes) = e8 35 5b 54 5f
005bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[92]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0x33,0xC9,0x89,0x0A,0x41,0x83,0xF8,0x20,0x7D,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x20,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x25,0x45,0x3B,0xD0,0x73,0x28,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x0F,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x44,0x09,0x1A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xDB,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x35,0x5B,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong packseq(ReadOnlySpan<byte> src, out ulong dst)
; location: [7FFDDBB093E0h, 7FFDDBB0943Ch]
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
0057h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F545B20h:jmp64]                encoding(5 bytes) = e8 c4 5a 54 5f
005ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[93]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0x33,0xC9,0x48,0x89,0x0A,0x41,0x83,0xF8,0x40,0x7D,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x40,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x25,0x45,0x3B,0xD0,0x73,0x28,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x0F,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x4C,0x09,0x1A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xDB,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xC4,0x5A,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(sbyte src)
; location: [7FFDDBB09460h, 7FFDDBB0946Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(byte src)
; location: [7FFDDBB09480h, 7FFDDBB0948Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(short src)
; location: [7FFDDBB094A0h, 7FFDDBB094ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ushort src)
; location: [7FFDDBB094C0h, 7FFDDBB094CCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(int src)
; location: [7FFDDBB094E0h, 7FFDDBB094EBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt eax,ecx                ; POPCNT(Popcnt_r32_rm32) [EAX,ECX]                    encoding(4 bytes) = f3 0f b8 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(uint src)
; location: [7FFDDBB09500h, 7FFDDBB0950Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt eax,ecx                ; POPCNT(Popcnt_r32_rm32) [EAX,ECX]                    encoding(4 bytes) = f3 0f b8 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(long src)
; location: [7FFDDBB09520h, 7FFDDBB0952Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong src)
; location: [7FFDDBB09540h, 7FFDDBB0954Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong x0, ulong x1)
; location: [7FFDDBB09560h, 7FFDDBB09573h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong x0, ulong x1, ulong x2, ulong x3)
; location: [7FFDDBB09590h, 7FFDDBB095B5h]
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
; location: [7FFDDBB095D0h, 7FFDDBB09621h]
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
; location: [7FFDDBB09640h, 7FFDDBB09661h]
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
; location: [7FFDDBB09680h, 7FFDDBB096A1h]
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
; location: [7FFDDBB096C0h, 7FFDDBB096DBh]
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
; location: [7FFDDBB096F0h, 7FFDDBB0970Dh]
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
; function: byte range(byte a, uint min, uint max)
; location: [7FFDDBB09720h, 7FFDDBB09745h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
000bh movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000fh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ah movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
001dh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0xFF,0xC0,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort range(ushort a, uint min, uint max)
; location: [7FFDDBB09760h, 7FFDDBB09785h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
000bh movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000fh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ah movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
001dh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0022h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0xFF,0xC0,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint range(uint a, uint min, uint max)
; location: [7FFDDBB097A0h, 7FFDDBB097BFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
000bh movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000fh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ah bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0xFF,0xC0,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong range(ulong a, uint min, uint max)
; location: [7FFDDBB097D0h, 7FFDDBB097EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
000bh movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000fh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ah bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0xFF,0xC0,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(byte src, uint pos)
; location: [7FFDDBB09800h, 7FFDDBB0981Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0007h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000ah shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0013h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC2,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(ushort src, uint pos)
; location: [7FFDDBB09830h, 7FFDDBB0984Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0007h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000ah shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
0013h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC2,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(uint src, uint pos)
; location: [7FFDDBB09860h, 7FFDDBB09879h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0007h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000ah shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0015h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC2,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(ulong src, uint pos)
; location: [7FFDDBB09890h, 7FFDDBB098AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0007h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000ah shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0015h popcnt rax,rax                ; POPCNT(Popcnt_r64_rm64) [RAX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC2,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xF3,0x48,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rev(byte src)
; location: [7FFDDBB098C0h, 7FFDDBB098F3h]
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
; location: [7FFDDBB09910h, 7FFDDBB09981h]
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
; function: uint rev(uint x)
; location: [7FFDDBB099A0h, 7FFDDBB099FCh]
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
; static ReadOnlySpan<byte> revBytes => new byte[93]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0xAA,0xAA,0xAA,0xAA,0xD1,0xE8,0x81,0xE1,0x55,0x55,0x55,0x55,0xD1,0xE1,0x0B,0xC8,0x8B,0xC1,0x25,0xCC,0xCC,0xCC,0xCC,0xC1,0xE8,0x02,0x81,0xE1,0x33,0x33,0x33,0x33,0xC1,0xE1,0x02,0x0B,0xC8,0x8B,0xC1,0x25,0xF0,0xF0,0xF0,0xF0,0xC1,0xE8,0x04,0x81,0xE1,0x0F,0x0F,0x0F,0x0F,0xC1,0xE1,0x04,0x0B,0xC8,0x8B,0xC1,0x25,0x00,0xFF,0x00,0xFF,0xC1,0xE8,0x08,0x81,0xE1,0xFF,0x00,0xFF,0x00,0xC1,0xE1,0x08,0x0B,0xC8,0x8B,0xC1,0xC1,0xC0,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rev(ulong src)
; location: [7FFDDBB09A10h, 7FFDDBB09AD7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh and edx,0AAAAAAAAh            ; AND(And_rm32_imm32) [EDX,aaaaaaaah:imm32]            encoding(6 bytes) = 81 e2 aa aa aa aa
0014h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0016h and eax,55555555h             ; AND(And_EAX_imm32) [EAX,55555555h:imm32]             encoding(5 bytes) = 25 55 55 55 55
001bh shl eax,1                     ; SHL(Shl_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e0
001dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001fh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0021h and edx,0CCCCCCCCh            ; AND(And_rm32_imm32) [EDX,cccccccch:imm32]            encoding(6 bytes) = 81 e2 cc cc cc cc
0027h shr edx,2                     ; SHR(Shr_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 ea 02
002ah and eax,33333333h             ; AND(And_EAX_imm32) [EAX,33333333h:imm32]             encoding(5 bytes) = 25 33 33 33 33
002fh shl eax,2                     ; SHL(Shl_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e0 02
0032h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0034h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0036h and edx,0F0F0F0F0h            ; AND(And_rm32_imm32) [EDX,f0f0f0f0h:imm32]            encoding(6 bytes) = 81 e2 f0 f0 f0 f0
003ch shr edx,4                     ; SHR(Shr_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 ea 04
003fh and eax,0F0F0F0Fh             ; AND(And_EAX_imm32) [EAX,f0f0f0fh:imm32]              encoding(5 bytes) = 25 0f 0f 0f 0f
0044h shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0047h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0049h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
004bh and edx,0FF00FF00h            ; AND(And_rm32_imm32) [EDX,ff00ff00h:imm32]            encoding(6 bytes) = 81 e2 00 ff 00 ff
0051h shr edx,8                     ; SHR(Shr_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 ea 08
0054h and eax,0FF00FFh              ; AND(And_EAX_imm32) [EAX,ff00ffh:imm32]               encoding(5 bytes) = 25 ff 00 ff 00
0059h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
005ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
005eh rol eax,10h                   ; ROL(Rol_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 c0 10
0061h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0063h and edx,0AAAAAAAAh            ; AND(And_rm32_imm32) [EDX,aaaaaaaah:imm32]            encoding(6 bytes) = 81 e2 aa aa aa aa
0069h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
006bh and ecx,55555555h             ; AND(And_rm32_imm32) [ECX,55555555h:imm32]            encoding(6 bytes) = 81 e1 55 55 55 55
0071h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0073h or ecx,edx                    ; OR(Or_r32_rm32) [ECX,EDX]                            encoding(2 bytes) = 0b ca
0075h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0077h and edx,0CCCCCCCCh            ; AND(And_rm32_imm32) [EDX,cccccccch:imm32]            encoding(6 bytes) = 81 e2 cc cc cc cc
007dh shr edx,2                     ; SHR(Shr_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 ea 02
0080h and ecx,33333333h             ; AND(And_rm32_imm32) [ECX,33333333h:imm32]            encoding(6 bytes) = 81 e1 33 33 33 33
0086h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0089h or ecx,edx                    ; OR(Or_r32_rm32) [ECX,EDX]                            encoding(2 bytes) = 0b ca
008bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
008dh and edx,0F0F0F0F0h            ; AND(And_rm32_imm32) [EDX,f0f0f0f0h:imm32]            encoding(6 bytes) = 81 e2 f0 f0 f0 f0
0093h shr edx,4                     ; SHR(Shr_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 ea 04
0096h and ecx,0F0F0F0Fh             ; AND(And_rm32_imm32) [ECX,f0f0f0fh:imm32]             encoding(6 bytes) = 81 e1 0f 0f 0f 0f
009ch shl ecx,4                     ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e1 04
009fh or ecx,edx                    ; OR(Or_r32_rm32) [ECX,EDX]                            encoding(2 bytes) = 0b ca
00a1h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
00a3h and edx,0FF00FF00h            ; AND(And_rm32_imm32) [EDX,ff00ff00h:imm32]            encoding(6 bytes) = 81 e2 00 ff 00 ff
00a9h shr edx,8                     ; SHR(Shr_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 ea 08
00ach and ecx,0FF00FFh              ; AND(And_rm32_imm32) [ECX,ff00ffh:imm32]              encoding(6 bytes) = 81 e1 ff 00 ff 00
00b2h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
00b5h or ecx,edx                    ; OR(Or_r32_rm32) [ECX,EDX]                            encoding(2 bytes) = 0b ca
00b7h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
00b9h rol edx,10h                   ; ROL(Rol_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 c2 10
00bch mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
00beh mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
00c0h shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
00c4h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
00c7h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[200]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x20,0x8B,0xD0,0x81,0xE2,0xAA,0xAA,0xAA,0xAA,0xD1,0xEA,0x25,0x55,0x55,0x55,0x55,0xD1,0xE0,0x0B,0xC2,0x8B,0xD0,0x81,0xE2,0xCC,0xCC,0xCC,0xCC,0xC1,0xEA,0x02,0x25,0x33,0x33,0x33,0x33,0xC1,0xE0,0x02,0x0B,0xC2,0x8B,0xD0,0x81,0xE2,0xF0,0xF0,0xF0,0xF0,0xC1,0xEA,0x04,0x25,0x0F,0x0F,0x0F,0x0F,0xC1,0xE0,0x04,0x0B,0xC2,0x8B,0xD0,0x81,0xE2,0x00,0xFF,0x00,0xFF,0xC1,0xEA,0x08,0x25,0xFF,0x00,0xFF,0x00,0xC1,0xE0,0x08,0x0B,0xC2,0xC1,0xC0,0x10,0x8B,0xD1,0x81,0xE2,0xAA,0xAA,0xAA,0xAA,0xD1,0xEA,0x81,0xE1,0x55,0x55,0x55,0x55,0xD1,0xE1,0x0B,0xCA,0x8B,0xD1,0x81,0xE2,0xCC,0xCC,0xCC,0xCC,0xC1,0xEA,0x02,0x81,0xE1,0x33,0x33,0x33,0x33,0xC1,0xE1,0x02,0x0B,0xCA,0x8B,0xD1,0x81,0xE2,0xF0,0xF0,0xF0,0xF0,0xC1,0xEA,0x04,0x81,0xE1,0x0F,0x0F,0x0F,0x0F,0xC1,0xE1,0x04,0x0B,0xCA,0x8B,0xD1,0x81,0xE2,0x00,0xFF,0x00,0xFF,0xC1,0xEA,0x08,0x81,0xE1,0xFF,0x00,0xFF,0x00,0xC1,0xE1,0x08,0x0B,0xCA,0x8B,0xD1,0xC1,0xC2,0x10,0x8B,0xC0,0x8B,0xD2,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotl(byte src, byte offset)
; location: [7FFDDBB09AF0h, 7FFDDBB09B12h]
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
; location: [7FFDDBB09B30h, 7FFDDBB09B52h]
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
; location: [7FFDDBB09B70h, 7FFDDBB09B7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotl(ulong src, ulong offset)
; location: [7FFDDBB09B90h, 7FFDDBB09B9Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah rol rax,cl                    ; ROL(Rol_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotl(byte src, int offset)
; location: [7FFDDBB09BB0h, 7FFDDBB09BCFh]
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
; location: [7FFDDBB09BE0h, 7FFDDBB09BFFh]
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
; location: [7FFDDBB09C10h, 7FFDDBB09C1Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotl(ulong src, int offset)
; location: [7FFDDBB09C30h, 7FFDDBB09C3Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah rol rax,cl                    ; ROL(Rol_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr(byte src, byte offset)
; location: [7FFDDBB09C50h, 7FFDDBB09C72h]
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
; location: [7FFDDBB09C90h, 7FFDDBB09CAFh]
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
; location: [7FFDDBB09CC0h, 7FFDDBB09CE2h]
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
; location: [7FFDDBB09D00h, 7FFDDBB09D1Fh]
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
; location: [7FFDDBB09D30h, 7FFDDBB09D3Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotr(uint src, int offset)
; location: [7FFDDBB09D50h, 7FFDDBB09D5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotr(ulong src, ulong offset)
; location: [7FFDDBB09D70h, 7FFDDBB09D7Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah ror rax,cl                    ; ROR(Ror_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotr(ulong src, int offset)
; location: [7FFDDBB09D90h, 7FFDDBB09D9Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah ror rax,cl                    ; ROR(Ror_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte scatter(sbyte src, sbyte mask)
; location: [7FFDDBB09DB0h, 7FFDDBB09DCFh]
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
; location: [7FFDDBB09DE0h, 7FFDDBB09DF3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short scatter(short src, short mask)
; location: [7FFDDBB09E10h, 7FFDDBB09E2Fh]
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
; location: [7FFDDBB09E40h, 7FFDDBB09E53h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int scatter(int src, int mask)
; location: [7FFDDBB09E70h, 7FFDDBB09E7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint scatter(uint src, uint mask)
; location: [7FFDDBB09E90h, 7FFDDBB09E9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long scatter(long src, long mask)
; location: [7FFDDBB09EB0h, 7FFDDBB09EBAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong scatter(ulong src, ulong mask)
; location: [7FFDDBB09ED0h, 7FFDDBB09EDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(byte src, out byte x0, out byte x1)
; location: [7FFDDBB09EF0h, 7FFDDBB09F05h]
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
; location: [7FFDDBB09F20h, 7FFDDBB09F4Dh]
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
; location: [7FFDDBB09F70h, 7FFDDBB09F80h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]            encoding(2 bytes) = 88 0a
0007h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
000ah sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
000dh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x88,0x0A,0x0F,0xB7,0xC1,0xC1,0xF8,0x08,0x41,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ValueTuple<short,short> split(int src, N2 parts)
; location: [7FFDDBB09FA0h, 7FFDDBB09FCDh]
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
; location: [7FFDDBB09FF0h, 7FFDDBB09FFFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),CX]         encoding(3 bytes) = 66 89 0a
0008h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
000bh mov [r8],cx                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),CX]          encoding(4 bytes) = 66 41 89 08
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x66,0x89,0x0A,0xC1,0xE9,0x10,0x66,0x41,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(long src, out int x0, out int x1)
; location: [7FFDDBB0A010h, 7FFDDBB0A020h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
0007h sar rcx,20h                   ; SAR(Sar_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 f9 20
000bh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000dh mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x0A,0x48,0xC1,0xF9,0x20,0x8B,0xC1,0x41,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ulong src, out uint x0, out uint x1)
; location: [7FFDDBB0A040h, 7FFDDBB0A050h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
0007h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
000bh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000dh mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x0A,0x48,0xC1,0xE9,0x20,0x8B,0xC1,0x41,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(uint src, out byte x0, out byte x1, out byte x2, out byte x3)
; location: [7FFDDBB0A070h, 7FFDDBB0A091h]
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
; location: [7FFDDBB0A0B0h, 7FFDDBB0A10Eh]
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
; function: bool test(sbyte src, int pos)
; location: [7FFDDBB0A120h, 7FFDDBB0A13Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(byte src, int pos)
; location: [7FFDDBB0A150h, 7FFDDBB0A16Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0014h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(short src, int pos)
; location: [7FFDDBB0A180h, 7FFDDBB0A19Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(ushort src, int pos)
; location: [7FFDDBB0A1B0h, 7FFDDBB0A1CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0014h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(int src, int pos)
; location: [7FFDDBB0A1E0h, 7FFDDBB0A1F7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0011h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(uint src, int pos)
; location: [7FFDDBB0A210h, 7FFDDBB0A227h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0011h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(long src, int pos)
; location: [7FFDDBB0A240h, 7FFDDBB0A24Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(ulong src, int pos)
; location: [7FFDDBB0A260h, 7FFDDBB0A278h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(float src, int pos)
; location: [7FFDDBB0A290h, 7FFDDBB0A2B5h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
001bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[38]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(double src, int pos)
; location: [7FFDDBB0A2D0h, 7FFDDBB0A2F5h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
000eh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
001bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[38]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit dot(Vector128<ulong> x, Vector128<ulong> y)
; location: [7FFDDBB0A310h, 7FFDDBB0A3A0h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
000bh vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000fh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0013h vpsrlw xmm1,xmm0,1            ; VPSRLW(VEX_Vpsrlw_xmm_xmm_imm8) [XMM1,XMM0,1h:imm8]  encoding(VEX, 5 bytes) = c5 f1 71 d0 01
0018h mov dword ptr [rsp+14h],55h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),55h:imm32] encoding(8 bytes) = c7 44 24 14 55 00 00 00
0020h lea rax,[rsp+14h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 14
0025h vpbroadcastb xmm2,byte ptr [rsp+14h]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM2,mem(8i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 54 24 14
002ch vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
0030h vpsubb xmm0,xmm0,xmm1         ; VPSUBB(VEX_Vpsubb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f8 c1
0034h vpsrlw xmm1,xmm0,2            ; VPSRLW(VEX_Vpsrlw_xmm_xmm_imm8) [XMM1,XMM0,2h:imm8]  encoding(VEX, 5 bytes) = c5 f1 71 d0 02
0039h mov dword ptr [rsp+10h],33h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),33h:imm32] encoding(8 bytes) = c7 44 24 10 33 00 00 00
0041h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 10
0046h vpbroadcastb xmm2,byte ptr [rsp+10h]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM2,mem(8i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 54 24 10
004dh vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
0051h vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
0055h vpsrlw xmm1,xmm0,4            ; VPSRLW(VEX_Vpsrlw_xmm_xmm_imm8) [XMM1,XMM0,4h:imm8]  encoding(VEX, 5 bytes) = c5 f1 71 d0 04
005ah vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
005eh mov dword ptr [rsp+0Ch],0Fh   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),fh:imm32] encoding(8 bytes) = c7 44 24 0c 0f 00 00 00
0066h lea rax,[rsp+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 0c
006bh vpbroadcastb xmm1,byte ptr [rsp+0Ch]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM1,mem(8i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 4c 24 0c
0072h vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0076h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
007ah vpsadbw xmm0,xmm0,xmm1        ; VPSADBW(VEX_Vpsadbw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 f6 c1
007eh vpextrq rax,xmm0,0            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 00
0084h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
0086h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0089h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
008ch add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0090h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dotBytes => new byte[145]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC5,0xF9,0xDB,0xC1,0xC5,0xF1,0x71,0xD0,0x01,0xC7,0x44,0x24,0x14,0x55,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x14,0xC4,0xE2,0x79,0x78,0x54,0x24,0x14,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xF8,0xC1,0xC5,0xF1,0x71,0xD0,0x02,0xC7,0x44,0x24,0x10,0x33,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC4,0xE2,0x79,0x78,0x54,0x24,0x10,0xC5,0xF9,0xDB,0xC2,0xC5,0xF9,0xFC,0xC1,0xC5,0xF1,0x71,0xD0,0x04,0xC5,0xF9,0xFC,0xC1,0xC7,0x44,0x24,0x0C,0x0F,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x0C,0xC4,0xE2,0x79,0x78,0x4C,0x24,0x0C,0xC5,0xF9,0xDB,0xC1,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0xF6,0xC1,0xC4,0xE3,0xF9,0x16,0xC0,0x00,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit dot(Vector256<ulong> x, Vector256<ulong> y)
; location: [7FFDDBB0A3D0h, 7FFDDBB0A478h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
000bh vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000fh vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0013h vpsrlw ymm1,ymm0,1            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM1,YMM0,1h:imm8]  encoding(VEX, 5 bytes) = c5 f5 71 d0 01
0018h mov dword ptr [rsp+14h],55h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),55h:imm32] encoding(8 bytes) = c7 44 24 14 55 00 00 00
0020h lea rax,[rsp+14h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 14
0025h vpbroadcastb ymm2,byte ptr [rsp+14h]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM2,mem(8i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 54 24 14
002ch vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
0030h vpsubb ymm0,ymm0,ymm1         ; VPSUBB(VEX_Vpsubb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd f8 c1
0034h vpsrlw ymm1,ymm0,2            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM1,YMM0,2h:imm8]  encoding(VEX, 5 bytes) = c5 f5 71 d0 02
0039h mov dword ptr [rsp+10h],33h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),33h:imm32] encoding(8 bytes) = c7 44 24 10 33 00 00 00
0041h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 10
0046h vpbroadcastb ymm2,byte ptr [rsp+10h]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM2,mem(8i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 54 24 10
004dh vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
0051h vpaddb ymm0,ymm0,ymm1         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd fc c1
0055h vpsrlw ymm1,ymm0,4            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM1,YMM0,4h:imm8]  encoding(VEX, 5 bytes) = c5 f5 71 d0 04
005ah vpaddb ymm0,ymm0,ymm1         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]  encoding(VEX, 4 bytes) = c5 fd fc c1
005eh mov dword ptr [rsp+0Ch],0Fh   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),fh:imm32] encoding(8 bytes) = c7 44 24 0c 0f 00 00 00
0066h lea rax,[rsp+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 0c
006bh vpbroadcastb ymm1,byte ptr [rsp+0Ch]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM1,mem(8i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 4c 24 0c
0072h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0076h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
007ah vpsadbw ymm0,ymm0,ymm1        ; VPSADBW(VEX_Vpsadbw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd f6 c1
007eh vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
0084h vpextrq rax,xmm1,0            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c8 00
008ah vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0090h vpextrq rdx,xmm0,0            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c2 00
0096h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0099h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
009bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
009eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00a1h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00a4h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
00a8h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dotBytes => new byte[169]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC5,0xFD,0xDB,0xC1,0xC5,0xF5,0x71,0xD0,0x01,0xC7,0x44,0x24,0x14,0x55,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x14,0xC4,0xE2,0x7D,0x78,0x54,0x24,0x14,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0xF8,0xC1,0xC5,0xF5,0x71,0xD0,0x02,0xC7,0x44,0x24,0x10,0x33,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC4,0xE2,0x7D,0x78,0x54,0x24,0x10,0xC5,0xFD,0xDB,0xC2,0xC5,0xFD,0xFC,0xC1,0xC5,0xF5,0x71,0xD0,0x04,0xC5,0xFD,0xFC,0xC1,0xC7,0x44,0x24,0x0C,0x0F,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x0C,0xC4,0xE2,0x7D,0x78,0x4C,0x24,0x0C,0xC5,0xFD,0xDB,0xC1,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0xF6,0xC1,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0xF9,0x16,0xC8,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE3,0xF9,0x16,0xC2,0x00,0x48,0x03,0xC2,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<sbyte> vpackss(in Vec128<short> lhs, in Vec128<short> rhs)
; location: [7FFDDBB0A8B0h, 7FFDDBB0A8C9h]
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
; location: [7FFDDBB0A8E0h, 7FFDDBB0A8F9h]
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
; location: [7FFDDBB0A910h, 7FFDDBB0A929h]
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
; location: [7FFDDBB0AD50h, 7FFDDBB0AD6Ch]
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
; location: [7FFDDBB0AD80h, 7FFDDBB0AD9Ch]
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
; location: [7FFDDBB0ADB0h, 7FFDDBB0ADCDh]
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
; location: [7FFDDBB0ADE0h, 7FFDDBB0AE24h]
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
; location: [7FFDDBB0AE40h, 7FFDDBB0AE85h]
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
; location: [7FFDDBB0AEA0h, 7FFDDBB0AEE4h]
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
; location: [7FFDDBB0AF00h, 7FFDDBB0AF45h]
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
; location: [7FFDDBB0AF60h, 7FFDDBB0AFA4h]
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
; location: [7FFDDBB0AFC0h, 7FFDDBB0B005h]
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
; location: [7FFDDBB0B020h, 7FFDDBB0B074h]
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
003dh call 7FFDDB428B50h            ; CALL(Call_rel32_64) [FFFFFFFFFF91DB30h:jmp64]        encoding(5 bytes) = e8 ee da 91 ff
0042h vmovdqu xmm0,xmmword ptr [rsp+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 30
0048h vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
004ch mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
004fh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0053h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0054h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bslliBytes => new byte[85]{0x56,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x38,0x48,0x8B,0xF1,0x48,0x8B,0x0A,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0x48,0x8D,0x4C,0x24,0x30,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0xEE,0xDA,0x91,0xFF,0xC5,0xFA,0x6F,0x44,0x24,0x30,0xC5,0xFA,0x7F,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x40,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte between(sbyte src, byte i0, byte i1)
; location: [7FFDDBB0B090h, 7FFDDBB0B0B8h]
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
; location: [7FFDDBB0B0D0h, 7FFDDBB0B0F6h]
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
; location: [7FFDDBB0B110h, 7FFDDBB0B138h]
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
; location: [7FFDDBB0B150h, 7FFDDBB0B176h]
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
; location: [7FFDDBB0B190h, 7FFDDBB0B1B0h]
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
; location: [7FFDDBB0B1D0h, 7FFDDBB0B1F0h]
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
; location: [7FFDDBB0B210h, 7FFDDBB0B230h]
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
; location: [7FFDDBB0B250h, 7FFDDBB0B270h]
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
; location: [7FFDDBB0B290h, 7FFDDBB0B2C6h]
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
; location: [7FFDDBB0B2E0h, 7FFDDBB0B31Ch]
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
; location: [7FFDDBB0B340h, 7FFDDBB0B381h]
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
; location: [7FFDDBB0B3A0h, 7FFDDBB0B3DFh]
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
; location: [7FFDDBB0B3F0h, 7FFDDBB0B432h]
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
; location: [7FFDDBB0B450h, 7FFDDBB0B491h]
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
; location: [7FFDDBB0B4B0h, 7FFDDBB0B4E6h]
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
; location: [7FFDDBB0B500h, 7FFDDBB0B536h]
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
; location: [7FFDDBB0B550h, 7FFDDBB0B58Ah]
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
; location: [7FFDDBB0B5A0h, 7FFDDBB0B5DAh]
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
; location: [7FFDDBB0B5F0h, 7FFDDBB0B635h]
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
; location: [7FFDDBB0B650h, 7FFDDBB0B693h]
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
; location: [7FFDDBB0B6B0h, 7FFDDBB0B6F3h]
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
; location: [7FFDDBB0B710h, 7FFDDBB0B755h]
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
; location: [7FFDDBB0B770h, 7FFDDBB0B7B1h]
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
; location: [7FFDDBB0B7D0h, 7FFDDBB0B806h]
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
; location: [7FFDDBB0B820h, 7FFDDBB0B85Ah]
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
; location: [7FFDDBB0B870h, 7FFDDBB0B8A2h]
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
; location: [7FFDDBB0B8C0h, 7FFDDBB0B8F9h]
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
; location: [7FFDDBB0B910h, 7FFDDBB0B948h]
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
; location: [7FFDDBB0B960h, 7FFDDBB0B992h]
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
; location: [7FFDDBB0B9B0h, 7FFDDBB0B9E8h]
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
; location: [7FFDDBB0BA00h, 7FFDDBB0BA36h]
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
; location: [7FFDDBB0BA50h, 7FFDDBB0BA90h]
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
; location: [7FFDDBB0BAB0h, 7FFDDBB0BAEEh]
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
; location: [7FFDDBB0BB00h, 7FFDDBB0BB42h]
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
; location: [7FFDDBB0BB60h, 7FFDDBB0BBA0h]
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
; location: [7FFDDBB0BBC0h, 7FFDDBB0BBF2h]
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
; location: [7FFDDBB0BC10h, 7FFDDBB0BC42h]
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
; location: [7FFDDBB0BC60h, 7FFDDBB0BC96h]
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
; location: [7FFDDBB0BCB0h, 7FFDDBB0BCE6h]
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
; location: [7FFDDBB0BD00h, 7FFDDBB0BD68h]
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
; location: [7FFDDBB0BD90h, 7FFDDBB0BDFEh]
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
; location: [7FFDDBB0BE20h, 7FFDDBB0BE30h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsi(ushort src)
; location: [7FFDDBB0BE50h, 7FFDDBB0BE60h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsi(uint src)
; location: [7FFDDBB0BE80h, 7FFDDBB0BE8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi eax,ecx                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,ECX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsi(ulong src)
; location: [7FFDDBB0BEA0h, 7FFDDBB0BEAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi rax,rcx                  ; BLSI(VEX_Blsi_r64_rm64) [RAX,RCX]                    encoding(VEX, 5 bytes) = c4 e2 f8 f3 d9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsic(byte src)
; location: [7FFDDBB0BEC0h, 7FFDDBB0BED3h]
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
; location: [7FFDDBB0BEF0h, 7FFDDBB0BF03h]
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
; location: [7FFDDBB0BF20h, 7FFDDBB0BF2Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
000bh or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC9,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsic(ulong src)
; location: [7FFDDBB0BF40h, 7FFDDBB0BF51h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh dec rcx                       ; DEC(Dec_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c9
000eh or rax,rcx                    ; OR(Or_r64_rm64) [RAX,RCX]                            encoding(3 bytes) = 48 0b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC9,0x48,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsmsk(byte src)
; location: [7FFDDBB0BF70h, 7FFDDBB0BF80h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsmsk(ushort src)
; location: [7FFDDBB0BFA0h, 7FFDDBB0BFB0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsmsk(uint src)
; location: [7FFDDBB0BFD0h, 7FFDDBB0BFDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk eax,ecx                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,ECX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsmsk(ulong src)
; location: [7FFDDBB0BFF0h, 7FFDDBB0BFFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk rax,rcx                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RAX,RCX]                encoding(VEX, 5 bytes) = c4 e2 f8 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsr(byte src)
; location: [7FFDDBB0C010h, 7FFDDBB0C020h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsr eax,eax                  ; BLSR(VEX_Blsr_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 c8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xC8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsr(ushort src)
; location: [7FFDDBB0C040h, 7FFDDBB0C050h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsr eax,eax                  ; BLSR(VEX_Blsr_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 c8
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xC8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsr(uint src)
; location: [7FFDDBB0C070h, 7FFDDBB0C07Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsr eax,ecx                  ; BLSR(VEX_Blsr_r32_rm32) [EAX,ECX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 c9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xC9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsr(ulong src)
; location: [7FFDDBB0C090h, 7FFDDBB0C09Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsr rax,rcx                  ; BLSR(VEX_Blsr_r64_rm64) [RAX,RCX]                    encoding(VEX, 5 bytes) = c4 e2 f8 f3 c9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xC9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte bzhi(byte src, uint index)
; location: [7FFDDBB0C0B0h, 7FFDDBB0C0C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort bzhi(ushort src, uint index)
; location: [7FFDDBB0C0E0h, 7FFDDBB0C0F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint bzhi(uint src, uint index)
; location: [7FFDDBB0C110h, 7FFDDBB0C11Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,ecx,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong bzhi(ulong src, uint index)
; location: [7FFDDBB0C130h, 7FFDDBB0C13Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,rcx,rax              ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f8 f5 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bzhi(ref byte src, uint index)
; location: [7FFDDBB0C150h, 7FFDDBB0C162h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xC4,0xE2,0x68,0xF5,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bzhi(ref ushort src, uint index)
; location: [7FFDDBB0C180h, 7FFDDBB0C193h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xC4,0xE2,0x68,0xF5,0xC0,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bzhi(ref uint src, uint index)
; location: [7FFDDBB0C1B0h, 7FFDDBB0C1BFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,[rcx],edx            ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,mem(32u,RCX:br,DS:sr),EDX] encoding(VEX, 5 bytes) = c4 e2 68 f5 01
000ah mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0x01,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bzhi(ref ulong src, uint index)
; location: [7FFDDBB0C1D0h, 7FFDDBB0C1E2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,[rcx],rax            ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,mem(64u,RCX:br,DS:sr),RAX] encoding(VEX, 5 bytes) = c4 e2 f8 f5 01
000ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0x01,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte extract(sbyte src, byte start, byte length)
; location: [7FFDDBB0C200h, 7FFDDBB0C221h]
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
; location: [7FFDDBB0C240h, 7FFDDBB0C25Fh]
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
; location: [7FFDDBB0C270h, 7FFDDBB0C291h]
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
; location: [7FFDDBB0C2B0h, 7FFDDBB0C2CFh]
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
; location: [7FFDDBB0C2E0h, 7FFDDBB0C2F9h]
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
; location: [7FFDDBB0C310h, 7FFDDBB0C329h]
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
; location: [7FFDDBB0C340h, 7FFDDBB0C359h]
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
; location: [7FFDDBB0C370h, 7FFDDBB0C389h]
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
; location: [7FFDDBB0C3A0h, 7FFDDBB0C3C7h]
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
; location: [7FFDDBB0C3E0h, 7FFDDBB0C406h]
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
; location: [7FFDDBB0C420h, 7FFDDBB0C433h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte gather(sbyte src, sbyte mask)
; location: [7FFDDBB0C450h, 7FFDDBB0C466h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short gather(short src, short mask)
; location: [7FFDDBB0C480h, 7FFDDBB0C496h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gather(ushort src, ushort mask)
; location: [7FFDDBB0C4B0h, 7FFDDBB0C4C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int gather(int src, int mask)
; location: [7FFDDBB0C4E0h, 7FFDDBB0C4EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather(uint src, uint mask)
; location: [7FFDDBB0C500h, 7FFDDBB0C50Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long gather(long src, long mask)
; location: [7FFDDBB0C520h, 7FFDDBB0C52Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather(ulong src, ulong mask)
; location: [7FFDDBB0C540h, 7FFDDBB0C54Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather(float src, uint mask)
; location: [7FFDDBB0C560h, 7FFDDBB0C578h]
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
; location: [7FFDDBB0C590h, 7FFDDBB0C5A7h]
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
; location: [7FFDDBB0C5C0h, 7FFDDBB0C5D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gather(ushort src, BitMask16:ushort mask)
; location: [7FFDDBB0C5F0h, 7FFDDBB0C603h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather(uint src, BitMask32:uint mask)
; location: [7FFDDBB0C620h, 7FFDDBB0C62Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather(ulong src, BitMask64:ulong mask)
; location: [7FFDDBB0C640h, 7FFDDBB0C64Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte gather(byte src, byte mask, ref byte dst)
; location: [7FFDDBB0C660h, 7FFDDBB0C676h]
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
; location: [7FFDDBB0C690h, 7FFDDBB0C6A8h]
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
; location: [7FFDDBB0C6C0h, 7FFDDBB0C6D9h]
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
; location: [7FFDDBB0C6F0h, 7FFDDBB0C707h]
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
; location: [7FFDDBB0C720h, 7FFDDBB0C730h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint gather(uint src, uint mask, ref uint dst)
; location: [7FFDDBB0C750h, 7FFDDBB0C760h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long gather(long src, long mask, ref long dst)
; location: [7FFDDBB0C780h, 7FFDDBB0C790h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong gather(ulong src, ulong mask, ref ulong dst)
; location: [7FFDDBB0C7B0h, 7FFDDBB0C7C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte hi(sbyte src)
; location: [7FFDDBB0C7E0h, 7FFDDBB0C7F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC1,0xF8,0x04,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte hi(byte src)
; location: [7FFDDBB0C810h, 7FFDDBB0C81Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC1,0xF8,0x04,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte hi(short src)
; location: [7FFDDBB0C830h, 7FFDDBB0C840h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC1,0xF8,0x08,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte hi(ushort src)
; location: [7FFDDBB0C860h, 7FFDDBB0C86Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short hi(int src)
; location: [7FFDDBB0C880h, 7FFDDBB0C88Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sar ecx,10h                   ; SAR(Sar_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 f9 10
0008h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0xC1,0xF9,0x10,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort hi(uint src)
; location: [7FFDDBB0C8A0h, 7FFDDBB0C8ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
0008h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0xC1,0xE9,0x10,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int hi(long src)
; location: [7FFDDBB0C8C0h, 7FFDDBB0C8CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sar rcx,20h                   ; SAR(Sar_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 f9 20
0009h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xC1,0xF9,0x20,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint hi(ulong src)
; location: [7FFDDBB0C8E0h, 7FFDDBB0C8EBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
0009h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xC1,0xE9,0x20,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort puthi(byte src, ref ushort dst)
; location: [7FFDDBB0C900h, 7FFDDBB0C922h]
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
; location: [7FFDDBB0C940h, 7FFDDBB0C95Ch]
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
; location: [7FFDDBB0C970h, 7FFDDBB0C98Eh]
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
; location: [7FFDDBB0C9A0h, 7FFDDBB0C9ACh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x83,0xE0,0x0F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte lo(byte src)
; location: [7FFDDBB0C9C0h, 7FFDDBB0C9CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x83,0xE0,0x0F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte lo(short src)
; location: [7FFDDBB0C9E0h, 7FFDDBB0C9EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte lo(ushort src)
; location: [7FFDDBB0CA00h, 7FFDDBB0CA0Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short lo(int src)
; location: [7FFDDBB0CA20h, 7FFDDBB0CA29h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
