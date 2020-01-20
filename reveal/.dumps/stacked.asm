; 2020-01-20 01:59:20:910
; MemStack64 ss_alloc_64()
; static ReadOnlySpan<byte> ss_alloc_64_32922880Bytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
; [0x7ff7c838dd80, 0x7ff7c838dd88], 8 bytes
; 2020-01-20 01:59:20:910
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack128 ss_alloc_128()
; static ReadOnlySpan<byte> ss_alloc_128_42915540Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x48,0x89,0x01,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c838dda0, 0x7ff7c838ddb2], 18 bytes
; 2020-01-20 01:59:20:910
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
000ah mov [rcx+8],rax                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 41 08}
000eh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0011h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack256 ss_alloc_256()
; static ReadOnlySpan<byte> ss_alloc_256_53606711Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c838ddd0, 0x7ff7c838dde6], 22 bytes
; 2020-01-20 01:59:20:910
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0009h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
000dh vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack512 ss_alloc_512()
; static ReadOnlySpan<byte> ss_alloc_512_47176343Bytes => new byte[32]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c838de00, 0x7ff7c838de20], 32 bytes
; 2020-01-20 01:59:20:910
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0009h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
000dh vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
0012h vmovdqu xmmword ptr [rcx+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 20}
0017h vmovdqu xmmword ptr [rcx+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 30}
001ch mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack1024 ss_alloc_1024()
; static ReadOnlySpan<byte> ss_alloc_1024_63187419Bytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0xC5,0xFA,0x7F,0x41,0x40,0xC5,0xFA,0x7F,0x41,0x50,0xC5,0xFA,0x7F,0x41,0x60,0xC5,0xFA,0x7F,0x41,0x70,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c838de40, 0x7ff7c838de74], 52 bytes
; 2020-01-20 01:59:20:910
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0009h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
000dh vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
0012h vmovdqu xmmword ptr [rcx+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 20}
0017h vmovdqu xmmword ptr [rcx+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 30}
001ch vmovdqu xmmword ptr [rcx+40h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 40}
0021h vmovdqu xmmword ptr [rcx+50h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 50}
0026h vmovdqu xmmword ptr [rcx+60h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 60}
002bh vmovdqu xmmword ptr [rcx+70h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 70}
0030h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0033h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void ss_store_128(in byte src, uint count, ref MemStack128 dst)
; static ReadOnlySpan<byte> ss_store_128_26948044Bytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x49,0x8B,0xC8,0x44,0x8B,0xC2,0x48,0x8B,0xD0,0xE8,0xAA,0x81,0x60,0x5F,0x90,0xC3};
; [0x7ff7c838de90, 0x7ff7c838dea8], 24 bytes
; 2020-01-20 01:59:20:910
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h mov rcx,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c8}
000bh mov r8d,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c2}
000eh mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
0011h call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 aa 81 60 5f}
0016h nop                                     ; NOP || o32 90 || encoded[1]{90}
0017h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Span<byte> ss_span_128x8(ref MemStack128 src)
; static ReadOnlySpan<byte> ss_span_128x8_41205809Bytes => new byte[29]{0x48,0x83,0xEC,0x28,0x90,0x48,0x89,0x11,0xC7,0x41,0x08,0x10,0x00,0x00,0x00,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x44,0x1D,0x73,0x5F,0xCC};
; [0x7ff7c838dec0, 0x7ff7c838dedd], 29 bytes
; 2020-01-20 01:59:20:916
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov [rcx],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 11}
0008h mov dword ptr [rcx+8],10h               ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[7]{c7 41 08 10 00 00 00}
000fh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0012h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
0017h call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 44 1d 73 5f}
001ch int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Span<byte> ss_span_256x8(ref MemStack256 src)
; static ReadOnlySpan<byte> ss_span_256x8_49336210Bytes => new byte[29]{0x48,0x83,0xEC,0x28,0x90,0x48,0x89,0x11,0xC7,0x41,0x08,0x20,0x00,0x00,0x00,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x04,0x1D,0x73,0x5F,0xCC};
; [0x7ff7c838df00, 0x7ff7c838df1d], 29 bytes
; 2020-01-20 01:59:20:916
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov [rcx],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 11}
0008h mov dword ptr [rcx+8],20h               ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[7]{c7 41 08 20 00 00 00}
000fh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0012h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
0017h call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 04 1d 73 5f}
001ch int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref byte ss_head_128x8(ref MemStack128 src)
; static ReadOnlySpan<byte> ss_head_128x8_41372713Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c838df40, 0x7ff7c838df49], 9 bytes
; 2020-01-20 01:59:20:916
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref ushort ss_head_128x16(ref MemStack128 src)
; static ReadOnlySpan<byte> ss_head_128x16_36810105Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c838df60, 0x7ff7c838df69], 9 bytes
; 2020-01-20 01:59:20:916
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref uint ss_head_128x32(ref MemStack128 src)
; static ReadOnlySpan<byte> ss_head_128x32_62855489Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c838df80, 0x7ff7c838df89], 9 bytes
; 2020-01-20 01:59:20:916
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref ulong ss_head_128x64(ref MemStack128 src)
; static ReadOnlySpan<byte> ss_head_128x64_28828491Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c838dfa0, 0x7ff7c838dfa9], 9 bytes
; 2020-01-20 01:59:20:916
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref byte ss_value_128x8(ref MemStack128 src, int index)
; static ReadOnlySpan<byte> ss_value_128x8_58129833Bytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x03,0xC1,0xC3};
; [0x7ff7c838dfc0, 0x7ff7c838dfcc], 12 bytes
; 2020-01-20 01:59:20:916
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movsxd rax,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c2}
0008h add rax,rcx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c1}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref ushort ss_value_128x16(ref MemStack128 src, int index)
; static ReadOnlySpan<byte> ss_value_128x16_53406450Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x8D,0x04,0x41,0xC3};
; [0x7ff7c838dfe0, 0x7ff7c838dfed], 13 bytes
; 2020-01-20 01:59:20:916
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movsxd rax,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c2}
0008h lea rax,[rcx+rax*2]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 41}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref uint ss_value_128x32(ref MemStack128 src, int index)
; static ReadOnlySpan<byte> ss_value_128x32_10896009Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x8D,0x04,0x81,0xC3};
; [0x7ff7c838e000, 0x7ff7c838e00d], 13 bytes
; 2020-01-20 01:59:20:916
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movsxd rax,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c2}
0008h lea rax,[rcx+rax*4]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 81}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref ulong ss_value_128x64(ref MemStack128 src, int index)
; static ReadOnlySpan<byte> ss_value_128x64_30955222Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x8D,0x04,0xC1,0xC3};
; [0x7ff7c838e020, 0x7ff7c838e02d], 13 bytes
; 2020-01-20 01:59:20:916
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movsxd rax,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c2}
0008h lea rax,[rcx+rax*8]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 c1}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref byte ss_value_256x8(ref MemStack256 src, int index)
; static ReadOnlySpan<byte> ss_value_256x8_10161546Bytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x03,0xC1,0xC3};
; [0x7ff7c838e040, 0x7ff7c838e04c], 12 bytes
; 2020-01-20 01:59:20:916
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movsxd rax,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c2}
0008h add rax,rcx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c1}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref ushort ss_value_256x16(ref MemStack256 src, int index)
; static ReadOnlySpan<byte> ss_value_256x16_24345054Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x8D,0x04,0x41,0xC3};
; [0x7ff7c838e060, 0x7ff7c838e06d], 13 bytes
; 2020-01-20 01:59:20:916
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movsxd rax,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c2}
0008h lea rax,[rcx+rax*2]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 41}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref uint ss_value_256x32(ref MemStack256 src, int index)
; static ReadOnlySpan<byte> ss_value_256x32_17778899Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x8D,0x04,0x81,0xC3};
; [0x7ff7c838e080, 0x7ff7c838e08d], 13 bytes
; 2020-01-20 01:59:20:916
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movsxd rax,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c2}
0008h lea rax,[rcx+rax*4]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 81}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref ulong ss_value_256x64(ref MemStack256 src, int index)
; static ReadOnlySpan<byte> ss_value_256x64_25792371Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0x8D,0x04,0xC1,0xC3};
; [0x7ff7c838e0a0, 0x7ff7c838e0ad], 13 bytes
; 2020-01-20 01:59:20:916
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movsxd rax,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c2}
0008h lea rax,[rcx+rax*8]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 c1}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; CharStack4 ss_alloc_c4()
; static ReadOnlySpan<byte> ss_alloc_c4_30804749Bytes => new byte[20]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
; [0x7ff7c838e0c0, 0x7ff7c838e0d4], 20 bytes
; 2020-01-20 01:59:20:916
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h nop dword ptr [rax]                     ; NOP r/m32 || o32 0F 1F /0 || encoded[4]{0f 1f 40 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov [rsp],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 04 24}
000bh mov rax,[rsp]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 04 24}
000fh add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; CharStack8 ss_alloc_c8()
; static ReadOnlySpan<byte> ss_alloc_c8_12156768Bytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c838e0f0, 0x7ff7c838e101], 17 bytes
; 2020-01-20 01:59:20:916
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0009h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
000dh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; CharStack32 ss_alloc_c32()
; static ReadOnlySpan<byte> ss_alloc_c32_45174131Bytes => new byte[32]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c838e120, 0x7ff7c838e140], 32 bytes
; 2020-01-20 01:59:20:916
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0009h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
000dh vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
0012h vmovdqu xmmword ptr [rcx+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 20}
0017h vmovdqu xmmword ptr [rcx+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 30}
001ch mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; CharStack64 ss_alloc_c64()
; static ReadOnlySpan<byte> ss_alloc_c64_35225966Bytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0xC5,0xFA,0x7F,0x41,0x40,0xC5,0xFA,0x7F,0x41,0x50,0xC5,0xFA,0x7F,0x41,0x60,0xC5,0xFA,0x7F,0x41,0x70,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c838e160, 0x7ff7c838e194], 52 bytes
; 2020-01-20 01:59:20:916
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0009h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
000dh vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
0012h vmovdqu xmmword ptr [rcx+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 20}
0017h vmovdqu xmmword ptr [rcx+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 30}
001ch vmovdqu xmmword ptr [rcx+40h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 40}
0021h vmovdqu xmmword ptr [rcx+50h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 50}
0026h vmovdqu xmmword ptr [rcx+60h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 60}
002bh vmovdqu xmmword ptr [rcx+70h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 70}
0030h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0033h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; CharStack8 ss_concat_8x8(CharStack4 head, CharStack4 tail)
; static ReadOnlySpan<byte> ss_concat_8x8_34731002Bytes => new byte[97]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x89,0x54,0x24,0x28,0x4C,0x89,0x44,0x24,0x30,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0x48,0x8D,0x44,0x24,0x28,0x48,0x8D,0x54,0x24,0x08,0x48,0x8B,0x00,0x48,0x89,0x02,0x48,0x8D,0x44,0x24,0x30,0x48,0x8D,0x54,0x24,0x08,0x48,0x83,0xC2,0x08,0x48,0x8B,0x00,0x48,0x89,0x02,0xC5,0xFA,0x6F,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
; [0x7ff7c838e1b0, 0x7ff7c838e211], 97 bytes
; 2020-01-20 01:59:20:916
0000h sub rsp,18h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 18}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h mov [rsp+28h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 28}
000ch mov [rsp+30h],r8                        ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{4c 89 44 24 30}
0011h lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
0016h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
001ah vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
001eh lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
0023h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0027h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
002bh lea rax,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 28}
0030h lea rdx,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 08}
0035h mov rax,[rax]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 00}
0038h mov [rdx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 02}
003bh lea rax,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 30}
0040h lea rdx,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 08}
0045h add rdx,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c2 08}
0049h mov rax,[rax]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 00}
004ch mov [rdx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 02}
004fh vmovdqu xmm0,xmmword ptr [rsp+8]        ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 08}
0055h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0059h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
005ch add rsp,18h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 18}
0060h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref CharStack32 ss_concat_2x16_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
; static ReadOnlySpan<byte> ss_concat_2x16_buffered_18859061Bytes => new byte[51]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x00,0xC5,0xFA,0x6F,0x41,0x10,0xC4,0xC1,0x7A,0x7F,0x40,0x10,0x49,0x8D,0x40,0x20,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x42,0x10,0xC5,0xFA,0x7F,0x40,0x10,0x49,0x8B,0xC0,0xC3};
; [0x7ff7c838e230, 0x7ff7c838e263], 51 bytes
; 2020-01-20 01:59:20:916
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovdqu xmm0,xmmword ptr [rcx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 01}
0009h vmovdqu xmmword ptr [r8],xmm0           ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7a 7f 00}
000eh vmovdqu xmm0,xmmword ptr [rcx+10h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[5]{c5 fa 6f 41 10}
0013h vmovdqu xmmword ptr [r8+10h],xmm0       ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c4 c1 7a 7f 40 10}
0019h lea rax,[r8+20h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{49 8d 40 20}
001dh vmovdqu xmm0,xmmword ptr [rdx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 02}
0021h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0025h vmovdqu xmm0,xmmword ptr [rdx+10h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[5]{c5 fa 6f 42 10}
002ah vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
002fh mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
0032h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref CharStack32 ss_concat_2x32_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
; static ReadOnlySpan<byte> ss_concat_2x32_buffered_51188993Bytes => new byte[51]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x00,0xC5,0xFA,0x6F,0x41,0x10,0xC4,0xC1,0x7A,0x7F,0x40,0x10,0x49,0x8D,0x40,0x20,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x42,0x10,0xC5,0xFA,0x7F,0x40,0x10,0x49,0x8B,0xC0,0xC3};
; [0x7ff7c838e280, 0x7ff7c838e2b3], 51 bytes
; 2020-01-20 01:59:20:916
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovdqu xmm0,xmmword ptr [rcx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 01}
0009h vmovdqu xmmword ptr [r8],xmm0           ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7a 7f 00}
000eh vmovdqu xmm0,xmmword ptr [rcx+10h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[5]{c5 fa 6f 41 10}
0013h vmovdqu xmmword ptr [r8+10h],xmm0       ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c4 c1 7a 7f 40 10}
0019h lea rax,[r8+20h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{49 8d 40 20}
001dh vmovdqu xmm0,xmmword ptr [rdx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 02}
0021h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0025h vmovdqu xmm0,xmmword ptr [rdx+10h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[5]{c5 fa 6f 42 10}
002ah vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
002fh mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
0032h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack64 init_64x8(in byte src)
; static ReadOnlySpan<byte> init_64x8_8uBytes => new byte[34]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x8B,0x11,0x48,0x89,0x10,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
; [0x7ff7c838e2d0, 0x7ff7c838e2f2], 34 bytes
; 2020-01-20 01:59:20:916
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h nop dword ptr [rax]                     ; NOP r/m32 || o32 0F 1F /0 || encoded[4]{0f 1f 40 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov [rsp],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 04 24}
000bh mov [rsp],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 04 24}
000fh lea rax,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 24}
0013h mov rdx,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 11}
0016h mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
0019h mov rax,[rsp]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 04 24}
001dh add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
0021h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack64 init_64x16(in ushort src)
; static ReadOnlySpan<byte> init_64x16_16uBytes => new byte[34]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x8B,0x11,0x48,0x89,0x10,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
; [0x7ff7c838e710, 0x7ff7c838e732], 34 bytes
; 2020-01-20 01:59:20:916
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h nop dword ptr [rax]                     ; NOP r/m32 || o32 0F 1F /0 || encoded[4]{0f 1f 40 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov [rsp],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 04 24}
000bh mov [rsp],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 04 24}
000fh lea rax,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 24}
0013h mov rdx,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 11}
0016h mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
0019h mov rax,[rsp]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 04 24}
001dh add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
0021h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack64 init_64x32(in uint src)
; static ReadOnlySpan<byte> init_64x32_32uBytes => new byte[34]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x8B,0x11,0x48,0x89,0x10,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
; [0x7ff7c838e750, 0x7ff7c838e772], 34 bytes
; 2020-01-20 01:59:20:916
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h nop dword ptr [rax]                     ; NOP r/m32 || o32 0F 1F /0 || encoded[4]{0f 1f 40 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov [rsp],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 04 24}
000bh mov [rsp],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 04 24}
000fh lea rax,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 24}
0013h mov rdx,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 11}
0016h mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
0019h mov rax,[rsp]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 04 24}
001dh add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
0021h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack64 init_64x64(in ulong src)
; static ReadOnlySpan<byte> init_64x64_64uBytes => new byte[34]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x8B,0x11,0x48,0x89,0x10,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
; [0x7ff7c838e790, 0x7ff7c838e7b2], 34 bytes
; 2020-01-20 01:59:20:916
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h nop dword ptr [rax]                     ; NOP r/m32 || o32 0F 1F /0 || encoded[4]{0f 1f 40 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov [rsp],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 04 24}
000bh mov [rsp],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 04 24}
000fh lea rax,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 24}
0013h mov rdx,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 11}
0016h mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
0019h mov rax,[rsp]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 04 24}
001dh add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
0021h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack128 init_128x8(in byte src)
; static ReadOnlySpan<byte> init_128x8_8uBytes => new byte[74]{0x48,0x83,0xEC,0x18,0x90,0x33,0xC0,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0x8D,0x44,0x24,0x08,0x4C,0x8B,0x02,0x4C,0x89,0x00,0x48,0x83,0xC0,0x08,0x48,0x8B,0x52,0x08,0x48,0x89,0x10,0x48,0x8B,0x44,0x24,0x08,0x48,0x8B,0x54,0x24,0x10,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
; [0x7ff7c838e7d0, 0x7ff7c838e81a], 74 bytes
; 2020-01-20 01:59:20:916
0000h sub rsp,18h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 18}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov [rsp+8],rax                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 08}
000ch mov [rsp+10h],rax                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 10}
0011h mov [rsp+8],rax                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 08}
0016h mov [rsp+10h],rax                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 10}
001bh lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
0020h mov r8,[rdx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 02}
0023h mov [rax],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 00}
0026h add rax,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 08}
002ah mov rdx,[rdx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 52 08}
002eh mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
0031h mov rax,[rsp+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 08}
0036h mov rdx,[rsp+10h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 54 24 10}
003bh mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
003eh mov [rcx+8],rdx                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 51 08}
0042h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0045h add rsp,18h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 18}
0049h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack256 init_256x8(in byte src)
; static ReadOnlySpan<byte> init_256x8_8uBytes => new byte[140]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x48,0x8D,0x44,0x24,0x08,0x4C,0x8B,0x02,0x4C,0x89,0x00,0x4C,0x8D,0x40,0x08,0x4C,0x8B,0x4A,0x08,0x4D,0x89,0x08,0x4C,0x8D,0x40,0x10,0x4C,0x8B,0x4A,0x10,0x4D,0x89,0x08,0x48,0x83,0xC0,0x18,0x48,0x8B,0x52,0x18,0x48,0x89,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xFA,0x6F,0x44,0x24,0x18,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xFA,0x6F,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x38,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
; [0x7ff7c838e830, 0x7ff7c838e8bc], 140 bytes
; 2020-01-20 01:59:20:916
0000h sub rsp,48h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 48}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
000ch vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0010h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0014h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
0019h lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
001eh vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0022h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0026h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
002bh lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
0030h mov r8,[rdx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 02}
0033h mov [rax],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 00}
0036h lea r8,[rax+8]                          ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 40 08}
003ah mov r9,[rdx+8]                          ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4c 8b 4a 08}
003eh mov [r8],r9                             ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 08}
0041h lea r8,[rax+10h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 40 10}
0045h mov r9,[rdx+10h]                        ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4c 8b 4a 10}
0049h mov [r8],r9                             ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 08}
004ch add rax,18h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 18}
0050h mov rdx,[rdx+18h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 52 18}
0054h mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
0057h vmovdqu xmm0,xmmword ptr [rsp+8]        ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 08}
005dh vmovdqu xmmword ptr [rsp+28h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 28}
0063h vmovdqu xmm0,xmmword ptr [rsp+18h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 18}
0069h vmovdqu xmmword ptr [rsp+38h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 38}
006fh vmovdqu xmm0,xmmword ptr [rsp+28h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 28}
0075h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0079h vmovdqu xmm0,xmmword ptr [rsp+38h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 38}
007fh vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
0084h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0087h add rsp,48h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 48}
008bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack256 init_256x32(in uint src)
; static ReadOnlySpan<byte> init_256x32_32uBytes => new byte[140]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x48,0x8D,0x44,0x24,0x08,0x4C,0x8B,0x02,0x4C,0x89,0x00,0x4C,0x8D,0x40,0x08,0x4C,0x8B,0x4A,0x08,0x4D,0x89,0x08,0x4C,0x8D,0x40,0x10,0x4C,0x8B,0x4A,0x10,0x4D,0x89,0x08,0x48,0x83,0xC0,0x18,0x48,0x8B,0x52,0x18,0x48,0x89,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xFA,0x6F,0x44,0x24,0x18,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xFA,0x6F,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x38,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
; [0x7ff7c838e8e0, 0x7ff7c838e96c], 140 bytes
; 2020-01-20 01:59:20:916
0000h sub rsp,48h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 48}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
000ch vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0010h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0014h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
0019h lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
001eh vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0022h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0026h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
002bh lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
0030h mov r8,[rdx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 02}
0033h mov [rax],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 00}
0036h lea r8,[rax+8]                          ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 40 08}
003ah mov r9,[rdx+8]                          ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4c 8b 4a 08}
003eh mov [r8],r9                             ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 08}
0041h lea r8,[rax+10h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 40 10}
0045h mov r9,[rdx+10h]                        ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4c 8b 4a 10}
0049h mov [r8],r9                             ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 08}
004ch add rax,18h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 18}
0050h mov rdx,[rdx+18h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 52 18}
0054h mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
0057h vmovdqu xmm0,xmmword ptr [rsp+8]        ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 08}
005dh vmovdqu xmmword ptr [rsp+28h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 28}
0063h vmovdqu xmm0,xmmword ptr [rsp+18h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 18}
0069h vmovdqu xmmword ptr [rsp+38h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 38}
006fh vmovdqu xmm0,xmmword ptr [rsp+28h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 28}
0075h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0079h vmovdqu xmm0,xmmword ptr [rsp+38h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 38}
007fh vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
0084h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0087h add rsp,48h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 48}
008bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack512 init_512x8(in byte src)
; static ReadOnlySpan<byte> init_512x8_8uBytes => new byte[157]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0xC5,0xFA,0x7F,0x40,0x20,0xC5,0xFA,0x7F,0x40,0x30,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0xC5,0xFA,0x7F,0x40,0x20,0xC5,0xFA,0x7F,0x40,0x30,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x42,0x10,0xC5,0xFA,0x7F,0x40,0x10,0xC5,0xFA,0x6F,0x42,0x20,0xC5,0xFA,0x7F,0x40,0x20,0xC5,0xFA,0x6F,0x42,0x30,0xC5,0xFA,0x7F,0x40,0x30,0xC5,0xFA,0x6F,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x18,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x6F,0x44,0x24,0x38,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
; [0x7ff7c838e990, 0x7ff7c838ea2d], 157 bytes
; 2020-01-20 01:59:20:916
0000h sub rsp,48h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 48}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
000ch vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0010h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0014h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
0019h vmovdqu xmmword ptr [rax+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 20}
001eh vmovdqu xmmword ptr [rax+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 30}
0023h lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
0028h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
002ch vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0030h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
0035h vmovdqu xmmword ptr [rax+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 20}
003ah vmovdqu xmmword ptr [rax+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 30}
003fh lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
0044h vmovdqu xmm0,xmmword ptr [rdx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 02}
0048h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
004ch vmovdqu xmm0,xmmword ptr [rdx+10h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[5]{c5 fa 6f 42 10}
0051h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
0056h vmovdqu xmm0,xmmword ptr [rdx+20h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[5]{c5 fa 6f 42 20}
005bh vmovdqu xmmword ptr [rax+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 20}
0060h vmovdqu xmm0,xmmword ptr [rdx+30h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[5]{c5 fa 6f 42 30}
0065h vmovdqu xmmword ptr [rax+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 30}
006ah vmovdqu xmm0,xmmword ptr [rsp+8]        ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 08}
0070h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0074h vmovdqu xmm0,xmmword ptr [rsp+18h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 18}
007ah vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
007fh vmovdqu xmm0,xmmword ptr [rsp+28h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 28}
0085h vmovdqu xmmword ptr [rcx+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 20}
008ah vmovdqu xmm0,xmmword ptr [rsp+38h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 38}
0090h vmovdqu xmmword ptr [rcx+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 30}
0095h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0098h add rsp,48h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 48}
009ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; MemStack1024 init_1024x8(in byte src)
; static ReadOnlySpan<byte> init_1024x8_8uBytes => new byte[153]{0x56,0x48,0x81,0xEC,0x80,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x0C,0x24,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0xC5,0xFA,0x7F,0x41,0x40,0xC5,0xFA,0x7F,0x41,0x50,0xC5,0xFA,0x7F,0x41,0x60,0xC5,0xFA,0x7F,0x41,0x70,0x48,0x8D,0x0C,0x24,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0xC5,0xFA,0x7F,0x41,0x40,0xC5,0xFA,0x7F,0x41,0x50,0xC5,0xFA,0x7F,0x41,0x60,0xC5,0xFA,0x7F,0x41,0x70,0x48,0x8D,0x0C,0x24,0x41,0xB8,0x80,0x00,0x00,0x00,0xE8,0x75,0x75,0x60,0x5F,0x48,0x8B,0xCE,0x48,0x8D,0x14,0x24,0x41,0xB8,0x80,0x00,0x00,0x00,0xE8,0x63,0x75,0x60,0x5F,0x48,0x8B,0xC6,0x48,0x81,0xC4,0x80,0x00,0x00,0x00,0x5E,0xC3};
; [0x7ff7c838ea60, 0x7ff7c838eaf9], 153 bytes
; 2020-01-20 01:59:20:917
0000h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0001h sub rsp,80h                             ; SUB r/m64, imm32 || REX.W 81 /5 id || encoded[7]{48 81 ec 80 00 00 00}
0008h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000bh mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
000eh lea rcx,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 0c 24}
0012h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0016h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
001ah vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
001fh vmovdqu xmmword ptr [rcx+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 20}
0024h vmovdqu xmmword ptr [rcx+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 30}
0029h vmovdqu xmmword ptr [rcx+40h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 40}
002eh vmovdqu xmmword ptr [rcx+50h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 50}
0033h vmovdqu xmmword ptr [rcx+60h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 60}
0038h vmovdqu xmmword ptr [rcx+70h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 70}
003dh lea rcx,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 0c 24}
0041h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0045h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0049h vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
004eh vmovdqu xmmword ptr [rcx+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 20}
0053h vmovdqu xmmword ptr [rcx+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 30}
0058h vmovdqu xmmword ptr [rcx+40h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 40}
005dh vmovdqu xmmword ptr [rcx+50h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 50}
0062h vmovdqu xmmword ptr [rcx+60h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 60}
0067h vmovdqu xmmword ptr [rcx+70h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 70}
006ch lea rcx,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 0c 24}
0070h mov r8d,80h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 b8 80 00 00 00}
0076h call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 75 75 60 5f}
007bh mov rcx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ce}
007eh lea rdx,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 14 24}
0082h mov r8d,80h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 b8 80 00 00 00}
0088h call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 63 75 60 5f}
008dh mov rax,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c6}
0090h add rsp,80h                             ; ADD r/m64, imm32 || REX.W 81 /0 id || encoded[7]{48 81 c4 80 00 00 00}
0097h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0098h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
