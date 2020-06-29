# CMP AL, imm8
------------------------------------------------------------------------------------------------------------------------
; bit testc<byte>(BitVector<byte> src), located://bitvectors/api?testc#testc_g[8u](BitVector[byte])
; public static ReadOnlySpan<byte> testc_gᐸ8uᐳᐤBitVectorᐸbyteᐳᐤ => new byte[28]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x25,0xff,0x00,0x00,0x00,0x0f,0xb6,0xc0,0x0f,0xb6,0xc0,0x3c,0xff,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};
; Base = 7ff9aeb6bbc0h
; TermCode = CTC_RET_SBB
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h and eax,0ffh                            ; AND EAX, imm32 || o32 25 id || encoded[5]{25 ff 00 00 00}
000dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0010h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0013h cmp al,0ffh                             ; CMP AL, imm8 || 3C ib || encoded[2]{3c ff}
0015h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0018h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
001bh ret                                     ; RET || C3 || encoded[1]{c3}

# CMP r/m8, imm8
------------------------------------------------------------------------------------------------------------------------
; bool cmp(Lt kind, byte x), located://canonical/asm.expr?cmp#cmp_(Lt,8u)
; public static ReadOnlySpan<byte> cmp_ᐤLtㆍ8uᐤ => new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x41,0x80,0xf8,0xff,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xc3};
; Base = 7ff9aebb4790h
; TermCode = CTC_RET_SBB
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h cmp r8b,0ffh                            ; CMP r/m8, imm8 || 80 /7 ib || encoded[4]{41 80 f8 ff}
0009h setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
000ch movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
000fh ret                                     ; RET || C3 || encoded[1]{c3}

# CMP r8, r/m8
------------------------------------------------------------------------------------------------------------------------
; bool equals<byte>(byte lhs, byte rhs), located://konst/sys?equals#equals_g[8u](8u,8u)
; public static ReadOnlySpan<byte> equals_gᐸ8uᐳᐤ8uㆍ8uᐤ => new byte[50]{0x56,0x48,0x83,0xec,0x20,0x89,0x4c,0x24,0x30,0x8b,0xf2,0x48,0xb9,0x58,0x77,0x0f,0xad,0xf9,0x7f,0x00,0x00,0xe8,0x26,0xe2,0x82,0x5e,0x40,0x88,0x70,0x08,0x0f,0xb6,0x54,0x24,0x30,0x3a,0x50,0x08,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x20,0x5e,0xc3};
; Base = 7ff9ae4094d0h
; TermCode = CTC_RET_Zx3
0000h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0001h sub rsp,20h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 20}
0005h mov [rsp+30h],ecx                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 4c 24 30}
0009h mov esi,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b f2}
000bh mov rcx,7ff9ad0f7758h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 58 77 0f ad f9 7f 00 00}
0015h call 7ffa0cc37710h                      ; CALL rel32 || E8 cd || encoded[5]{e8 26 e2 82 5e}
001ah mov [rax+8],sil                         ; MOV r/m8, r8 || 88 /r || encoded[4]{40 88 70 08}
001eh movzx edx,byte ptr [rsp+30h]            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{0f b6 54 24 30}
0023h cmp dl,[rax+8]                          ; CMP r8, r/m8 || 3A /r || encoded[3]{3a 50 08}
0026h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0029h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
002ch add rsp,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 20}
0030h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0031h ret                                     ; RET || C3 || encoded[1]{c3}

# CMP EAX, imm32
------------------------------------------------------------------------------------------------------------------------
; byte effsize<ushort>(ushort src), located://bitcore/generic?effsize#effsize_g[16u](16u)
; public static ReadOnlySpan<byte> effsize_gᐸ16uᐳᐤ16uᐤ => new byte[28]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x3d,0xff,0x00,0x00,0x00,0x7f,0x07,0xb8,0x01,0x00,0x00,0x00,0xeb,0x05,0xb8,0x02,0x00,0x00,0x00,0xc3};
; Base = 7ff9aeafa780h
; TermCode = CTC_RET_SBB
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c1}
0008h cmp eax,0ffh                            ; CMP EAX, imm32 || o32 3D id || encoded[5]{3d ff 00 00 00}
000dh jg short 0016h                          ; JG rel8 || 7F cb || encoded[2]{7f 07}
000fh mov eax,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 01 00 00 00}
0014h jmp short 001bh                         ; JMP rel8 || EB cb || encoded[2]{eb 05}
0016h mov eax,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 02 00 00 00}
001bh ret                                     ; RET || C3 || encoded[1]{c3}

# CMP RAX, imm32
------------------------------------------------------------------------------------------------------------------------
; uint pop(in BitMatrix32 A), located://bitmatrix/api?pop#pop_(bm32x32u~in)
; public static ReadOnlySpan<byte> pop_ᐤbm32x32uᕀinᐤ => new byte[33]{0x48,0x83,0xec,0x28,0x90,0x48,0x8b,0x01,0x8b,0x41,0x08,0x48,0xc1,0xe0,0x02,0x48,0xc1,0xe8,0x03,0x48,0x3d,0xff,0xff,0xff,0x7f,0x77,0x07,0x33,0xc0,0x48,0x83,0xc4,0x28};
; Base = 7ff9aeb480e0h
; TermCode = CTC_Zx7
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
0008h mov eax,[rcx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 41 08}
000bh shl rax,2                               ; SHL r/m64, imm8 || REX.W C1 /4 ib || encoded[4]{48 c1 e0 02}
000fh shr rax,3                               ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{48 c1 e8 03}
0013h cmp rax,7fffffffh                       ; CMP RAX, imm32 || REX.W 3D id || encoded[6]{48 3d ff ff ff 7f}
0019h ja short 0022h                          ; JA rel8 || 77 cb || encoded[2]{77 07}
001bh xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
001dh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}


# CMP r/m32, imm32
------------------------------------------------------------------------------------------------------------------------
; byte effsize<uint>(uint src), located://bitcore/generic?effsize#effsize_g[32u](32u)
; public static ReadOnlySpan<byte> effsize_gᐸ32uᐳᐤ32uᐤ => new byte[56]{0x0f,0x1f,0x44,0x00,0x00,0x81,0xf9,0xff,0x00,0x00,0x00,0x77,0x07,0xb8,0x01,0x00,0x00,0x00,0xeb,0x23,0x81,0xf9,0xff,0xff,0x00,0x00,0x77,0x07,0xb8,0x02,0x00,0x00,0x00,0xeb,0x14,0x81,0xf9,0xff,0xff,0xff,0x00,0x77,0x07,0xb8,0x03,0x00,0x00,0x00,0xeb,0x05,0xb8,0x04,0x00,0x00,0x00,0xc3};
; Base = 7ff9aeafa7e0h
; TermCode = CTC_RET_SBB
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h cmp ecx,0ffh                            ; CMP r/m32, imm32 || o32 81 /7 id || encoded[6]{81 f9 ff 00 00 00}
000bh ja short 0014h                          ; JA rel8 || 77 cb || encoded[2]{77 07}
000dh mov eax,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 01 00 00 00}
0012h jmp short 0037h                         ; JMP rel8 || EB cb || encoded[2]{eb 23}
0014h cmp ecx,0ffffh                          ; CMP r/m32, imm32 || o32 81 /7 id || encoded[6]{81 f9 ff ff 00 00}
001ah ja short 0023h                          ; JA rel8 || 77 cb || encoded[2]{77 07}
001ch mov eax,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 02 00 00 00}
0021h jmp short 0037h                         ; JMP rel8 || EB cb || encoded[2]{eb 14}
0023h cmp ecx,0ffffffh                        ; CMP r/m32, imm32 || o32 81 /7 id || encoded[6]{81 f9 ff ff ff 00}
0029h ja short 0032h                          ; JA rel8 || 77 cb || encoded[2]{77 07}
002bh mov eax,3                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 03 00 00 00}
0030h jmp short 0037h                         ; JMP rel8 || EB cb || encoded[2]{eb 05}
0032h mov eax,4                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 04 00 00 00}
0037h ret                                     ; RET || C3 || encoded[1]{c3}

# CMP r/m32, r32
------------------------------------------------------------------------------------------------------------------------
; ref Pair<ulong> mul(ulong x, ulong y, out Pair<ulong> dst), located://math/scalarpairs?mul#mul_(64u,64u,Pair[ulong]~out)
; public static ReadOnlySpan<byte> mul_ᐤ64uㆍ64uㆍPairᐸulongᐳᕀoutᐤ => new byte[49]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x45,0x39,0x00,0x49,0x8d,0x40,0x08,0x45,0x33,0xc9,0x4d,0x89,0x08,0x4d,0x8b,0xc8,0x4c,0x8b,0x54,0x24,0x10,0x48,0x8b,0xd1,0xc4,0xc2,0xa3,0xf6,0xd2,0x4d,0x89,0x19,0x48,0x89,0x10,0x49,0x8b,0xc0,0xc3};
; Base = 7ff9af300530h
; TermCode = CTC_RET_Zx3
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov [rsp+10h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 10}
000ah cmp [r8],r8d                            ; CMP r/m32, r32 || o32 39 /r || encoded[3]{45 39 00}
000dh lea rax,[r8+8]                          ; LEA r64, m || REX.W 8D /r || encoded[4]{49 8d 40 08}
0011h xor r9d,r9d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c9}
0014h mov [r8],r9                             ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 08}
0017h mov r9,r8                               ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b c8}
001ah mov r10,[rsp+10h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{4c 8b 54 24 10}
001fh mov rdx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d1}
0022h mulx rdx,r11,r10                        ; MULX r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F6 /r || encoded[5]{c4 c2 a3 f6 d2}
0027h mov [r9],r11                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 19}
002ah mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
002dh mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
0030h ret                                     ; RET || C3 || encoded[1]{c3}

# CMP r64, r/m64
------------------------------------------------------------------------------------------------------------------------
; bool ngt(Vector128<double> x, Vector128<double> y), located://fvec/dinxsfp?ngt#ngt_(v128x64f,v128x64f)
; public static ReadOnlySpan<byte> ngt_ᐤv128x64fㆍv128x64fᐤ => new byte[60]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xfb,0xc2,0x02,0x02,0xc5,0xfb,0x11,0x04,0x24,0x48,0x8b,0x04,0x24,0x48,0xba,0xff,0xff,0xff,0xff,0xff,0xff,0xff,0x7f,0x48,0x23,0xc2,0x48,0xba,0x00,0x00,0x00,0x00,0x00,0x00,0xf0,0x7f,0x48,0x3b,0xc2,0x0f,0x9f,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x08,0xc3};
; Base = 7ff9af219200h
; TermCode = CTC_RET_INTR
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vcmplesd xmm0,xmm0,qword ptr [rdx]      ; VCMPSD xmm1, xmm2, xmm3/m64, imm8 || VEX.LIG.F2.0F.WIG C2 /r ib || encoded[5]{c5 fb c2 02 02}
000eh vmovsd qword ptr [rsp],xmm0             ; VMOVSD m64, xmm1 || VEX.LIG.F2.0F.WIG 11 /r || encoded[5]{c5 fb 11 04 24}
0013h mov rax,[rsp]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 04 24}
0017h mov rdx,7fffffffffffffffh               ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba ff ff ff ff ff ff ff 7f}
0021h and rax,rdx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 c2}
0024h mov rdx,7ff0000000000000h               ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 00 00 00 00 00 00 f0 7f}
002eh cmp rax,rdx                             ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{48 3b c2}
0031h setg al                                 ; SETG r/m8 || 0F 9F /r || encoded[3]{0f 9f c0}
0034h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0037h add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
003bh ret                                     ; RET || C3 || encoded[1]{c3}
