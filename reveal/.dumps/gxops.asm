; 2020-01-20 01:59:22:031
; uint bl_and32(uint a, uint b)
; static ReadOnlySpan<byte> bl_and32_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
; [0x7ff7c860b8c0, 0x7ff7c860b8ca], 10 bytes
; 2020-01-20 01:59:22:031
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and edx,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint logic_machine(uint a, uint b)
; static ReadOnlySpan<byte> logic_machine_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xCA,0x33,0xD1,0x8B,0xC2,0xC3};
; [0x7ff7c860bdf0, 0x7ff7c860bdfc], 12 bytes
; 2020-01-20 01:59:22:031
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and ecx,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 ca}
0007h xor edx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d1}
0009h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vlogic_machine(Vector128<uint> a, Vector128<uint> b)
; static ReadOnlySpan<byte> vlogic_machine_128x32uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF9,0xDB,0xC2,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c860be10, 0x7ff7c860be32], 34 bytes
; 2020-01-20 01:59:22:031
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vmovaps xmm2,xmm1                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 d1}
0012h vpand xmm0,xmm0,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c2}
0016h vpxor xmm0,xmm0,xmm1                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f9 ef c1}
001ah vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
001eh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0021h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit eq_d16u(ushort a, ushort b)
; static ReadOnlySpan<byte> eq_d16u_16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860be50, 0x7ff7c860be64], 20 bytes
; 2020-01-20 01:59:22:031
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c1}
0008h movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
000bh cmp eax,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c2}
000dh sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0010h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit eq_g16u(ushort a, ushort b)
; static ReadOnlySpan<byte> eq_g16u_16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860be80, 0x7ff7c860be97], 23 bytes
; 2020-01-20 01:59:22:031
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c1}
0008h movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
000bh movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
000eh cmp eax,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c2}
0010h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0013h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit eq_o16u(ushort a, ushort b)
; static ReadOnlySpan<byte> eq_o16u_16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860beb0, 0x7ff7c860bec7], 23 bytes
; 2020-01-20 01:59:22:031
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c1}
0008h movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
000bh movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
000eh cmp eax,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c2}
0010h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0013h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; string eq_moniker()
; static ReadOnlySpan<byte> eq_moniker_39838562Bytes => new byte[47]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0xC6,0x44,0x24,0x28,0x00,0x48,0x0F,0xBE,0x4C,0x24,0x28,0x88,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0xF7,0xFD,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x38,0xC3};
; [0x7ff7c860bee0, 0x7ff7c860bf0f], 47 bytes
; 2020-01-20 01:59:22:031
0000h sub rsp,38h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 38}
0004h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0006h mov [rsp+30h],rax                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 30}
000bh mov [rsp+28h],rax                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 28}
0010h mov byte ptr [rsp+28h],0                ; MOV r/m8, imm8 || C6 /0 ib || encoded[5]{c6 44 24 28 00}
0015h movsx rcx,byte ptr [rsp+28h]            ; MOVSX r64, r/m8 || REX.W 0F BE /r || encoded[6]{48 0f be 4c 24 28}
001bh mov [rsp+30h],cl                        ; MOV r/m8, r8 || 88 /r || encoded[4]{88 4c 24 30}
001fh lea rcx,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 30}
0024h call 7FF7C860BD00h                      ; CALL rel32 || E8 cd || encoded[5]{e8 f7 fd ff ff}
0029h nop                                     ; NOP || o32 90 || encoded[1]{90}
002ah add rsp,38h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 38}
002eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; string the_name()
; static ReadOnlySpan<byte> the_name_23002745Bytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xC8,0x77,0x9D,0x93,0x4C,0x02,0x00,0x00,0x48,0x8B,0x00,0xC3};
; [0x7ff7c860bf30, 0x7ff7c860bf43], 19 bytes
; 2020-01-20 01:59:22:031
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,24C939D77C8h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 c8 77 9d 93 4c 02 00 00}
000fh mov rax,[rax]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 00}
0012h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
