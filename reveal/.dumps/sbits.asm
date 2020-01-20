; 2020-01-20 01:59:21:024
; void split_g64(ulong src, int index, out ulong x0, out ulong x1)
; static ReadOnlySpan<byte> split_g64_64uBytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x83,0xE2,0x3F,0x8B,0xCA,0x4C,0x8B,0xD0,0x49,0xD3,0xEA,0x41,0xBB,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE3,0x49,0xFF,0xCB,0x49,0x23,0xC3,0x49,0x89,0x00,0x4D,0x89,0x11,0xC3};
; [0x7ff7c8391f80, 0x7ff7c8391fab], 43 bytes
; 2020-01-20 01:59:21:024
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h and edx,3Fh                             ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e2 3f}
000bh mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
000dh mov r10,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b d0}
0010h shr r10,cl                              ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{49 d3 ea}
0013h mov r11d,1                              ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 bb 01 00 00 00}
0019h mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
001bh shl r11,cl                              ; SHL r/m64, CL || REX.W D3 /4 || encoded[3]{49 d3 e3}
001eh dec r11                                 ; DEC r/m64 || REX.W FF /1 || encoded[3]{49 ff cb}
0021h and rax,r11                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{49 23 c3}
0024h mov [r8],rax                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 00}
0027h mov [r9],r10                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 11}
002ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void split_64(ulong src, int index, out ulong x0, out ulong x1)
; static ReadOnlySpan<byte> split_64_64uBytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x83,0xE2,0x3F,0x8B,0xCA,0x4C,0x8B,0xD0,0x49,0xD3,0xEA,0x4D,0x89,0x11,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x49,0xFF,0xC9,0x49,0x23,0xC1,0x49,0x89,0x00,0xC3};
; [0x7ff7c8391fc0, 0x7ff7c8391feb], 43 bytes
; 2020-01-20 01:59:21:024
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h and edx,3Fh                             ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e2 3f}
000bh mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
000dh mov r10,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b d0}
0010h shr r10,cl                              ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{49 d3 ea}
0013h mov [r9],r10                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 11}
0016h mov r9d,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 b9 01 00 00 00}
001ch mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
001eh shl r9,cl                               ; SHL r/m64, CL || REX.W D3 /4 || encoded[3]{49 d3 e1}
0021h dec r9                                  ; DEC r/m64 || REX.W FF /1 || encoded[3]{49 ff c9}
0024h and rax,r9                              ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{49 23 c1}
0027h mov [r8],rax                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 00}
002ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void split_exact(ulong src, out uint x0, out uint x1)
; static ReadOnlySpan<byte> split_exact_64uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x0A,0x48,0xC1,0xE9,0x20,0x8B,0xC1,0x41,0x89,0x00,0xC3};
; [0x7ff7c8392000, 0x7ff7c8392011], 17 bytes
; 2020-01-20 01:59:21:024
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov [rdx],ecx                           ; MOV r/m32, r32 || o32 89 /r || encoded[2]{89 0a}
0007h shr rcx,20h                             ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{48 c1 e9 20}
000bh mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
000dh mov [r8],eax                            ; MOV r/m32, r32 || o32 89 /r || encoded[3]{41 89 00}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2_20()
; static ReadOnlySpan<byte> pow2_20_206039Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x00,0x10,0x00,0xC3};
; [0x7ff7c8392030, 0x7ff7c839203b], 11 bytes
; 2020-01-20 01:59:21:024
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,100000h                         ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 00 00 10 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2m1_20()
; static ReadOnlySpan<byte> pow2m1_20_1854355Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0x0F,0x00,0xC3};
; [0x7ff7c8392050, 0x7ff7c839205b], 11 bytes
; 2020-01-20 01:59:21:024
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,0FFFFFh                         ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 ff ff 0f 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2_33()
; static ReadOnlySpan<byte> pow2_33_16689200Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0x00,0x00,0x00,0x02,0x00,0x00,0x00,0xC3};
; [0x7ff7c8392070, 0x7ff7c8392080], 16 bytes
; 2020-01-20 01:59:21:024
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,200000000h                      ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 00 00 00 00 02 00 00 00}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2m1_33()
; static ReadOnlySpan<byte> pow2m1_33_15985080Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xFF,0xFF,0xFF,0xFF,0x01,0x00,0x00,0x00,0xC3};
; [0x7ff7c8392090, 0x7ff7c83920a0], 16 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,1FFFFFFFFh                      ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 ff ff ff ff 01 00 00 00}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2_1()
; static ReadOnlySpan<byte> pow2_1_9647994Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
; [0x7ff7c83920b0, 0x7ff7c83920bb], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 02 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2m1_1()
; static ReadOnlySpan<byte> pow2m1_1_19723089Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
; [0x7ff7c83920d0, 0x7ff7c83920db], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 01 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2_2()
; static ReadOnlySpan<byte> pow2_2_43290077Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x04,0x00,0x00,0x00,0xC3};
; [0x7ff7c83920f0, 0x7ff7c83920fb], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,4                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 04 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2m1_2()
; static ReadOnlySpan<byte> pow2m1_2_54066375Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
; [0x7ff7c8392110, 0x7ff7c839211b], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,3                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 03 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2_3()
; static ReadOnlySpan<byte> pow2_3_16835328Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x08,0x00,0x00,0x00,0xC3};
; [0x7ff7c8392130, 0x7ff7c839213b], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 08 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2m1_3()
; static ReadOnlySpan<byte> pow2m1_3_17300225Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x07,0x00,0x00,0x00,0xC3};
; [0x7ff7c8392150, 0x7ff7c839215b], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,7                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 07 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2_4()
; static ReadOnlySpan<byte> pow2_4_21484299Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x00,0x00,0x00,0xC3};
; [0x7ff7c8392170, 0x7ff7c839217b], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,10h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 10 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2m1_4()
; static ReadOnlySpan<byte> pow2m1_4_59140967Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x0F,0x00,0x00,0x00,0xC3};
; [0x7ff7c8392190, 0x7ff7c839219b], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,0Fh                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 0f 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2_5()
; static ReadOnlySpan<byte> pow2_5_62506663Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x20,0x00,0x00,0x00,0xC3};
; [0x7ff7c83921b0, 0x7ff7c83921bb], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,20h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 20 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2m1_5()
; static ReadOnlySpan<byte> pow2m1_5_25689059Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x1F,0x00,0x00,0x00,0xC3};
; [0x7ff7c83921d0, 0x7ff7c83921db], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,1Fh                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 1f 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2_6()
; static ReadOnlySpan<byte> pow2_6_29874939Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x40,0x00,0x00,0x00,0xC3};
; [0x7ff7c83921f0, 0x7ff7c83921fb], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,40h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 40 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2m1_6()
; static ReadOnlySpan<byte> pow2m1_6_439002Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x3F,0x00,0x00,0x00,0xC3};
; [0x7ff7c8392210, 0x7ff7c839221b], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,3Fh                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 3f 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2_7()
; static ReadOnlySpan<byte> pow2_7_3951024Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x80,0x00,0x00,0x00,0xC3};
; [0x7ff7c8392230, 0x7ff7c839223b], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,80h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 80 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2m1_7()
; static ReadOnlySpan<byte> pow2m1_7_35559222Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x7F,0x00,0x00,0x00,0xC3};
; [0x7ff7c8392250, 0x7ff7c839225b], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,7Fh                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 7f 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2_8()
; static ReadOnlySpan<byte> pow2_8_51597550Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x01,0x00,0x00,0xC3};
; [0x7ff7c8392270, 0x7ff7c839227b], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,100h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 00 01 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong pow2m1_8()
; static ReadOnlySpan<byte> pow2m1_8_61724767Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x00,0x00,0x00,0xC3};
; [0x7ff7c8392290, 0x7ff7c839229b], 11 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,0FFh                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 ff 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint set_bit(uint src, byte pos, bit state)
; static ReadOnlySpan<byte> set_bit_18651996Bytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x45,0x85,0xC0,0x74,0x0E,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x0B,0xC2,0xEB,0x10,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0xF7,0xD2,0x23,0xD0,0x8B,0xC2,0xC3};
; [0x7ff7c83922b0, 0x7ff7c83922db], 43 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h test r8d,r8d                            ; TEST r/m32, r32 || o32 85 /r || encoded[3]{45 85 c0}
000ah je short 001ah                          ; JE rel8 || 74 cb || encoded[2]{74 0e}
000ch movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000fh mov edx,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 01 00 00 00}
0014h shl edx,cl                              ; SHL r/m32, CL || o32 D3 /4 || encoded[2]{d3 e2}
0016h or eax,edx                              ; OR r32, r/m32 || o32 0B /r || encoded[2]{0b c2}
0018h jmp short 002ah                         ; JMP rel8 || EB cb || encoded[2]{eb 10}
001ah movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
001dh mov edx,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 01 00 00 00}
0022h shl edx,cl                              ; SHL r/m32, CL || o32 D3 /4 || encoded[2]{d3 e2}
0024h not edx                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d2}
0026h and edx,eax                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 d0}
0028h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
002ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint set_bit_nb(uint src, byte pos, bit state)
; static ReadOnlySpan<byte> set_bit_nb_33650236Bytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xD2,0x83,0xE2,0x1F,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE1,0x41,0xF7,0xD1,0x41,0xFF,0xC1,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x23,0xC1,0x41,0x23,0xC0,0xC3};
; [0x7ff7c8392700, 0x7ff7c839272a], 42 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000ah and edx,1Fh                             ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e2 1f}
000dh mov r9d,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 b9 01 00 00 00}
0013h mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
0015h shl r9d,cl                              ; SHL r/m32, CL || o32 D3 /4 || encoded[3]{41 d3 e1}
0018h not r9d                                 ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d1}
001bh inc r9d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c1}
001eh mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
0020h shl r8d,cl                              ; SHL r/m32, CL || o32 D3 /4 || encoded[3]{41 d3 e0}
0023h and eax,r9d                             ; AND r32, r/m32 || o32 23 /r || encoded[3]{41 23 c1}
0026h and eax,r8d                             ; AND r32, r/m32 || o32 23 /r || encoded[3]{41 23 c0}
0029h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint set_bit_on(uint src, byte pos)
; static ReadOnlySpan<byte> set_bit_on_32uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x0B,0xC2,0xC3};
; [0x7ff7c8392740, 0x7ff7c8392754], 20 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah mov edx,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 01 00 00 00}
000fh shl edx,cl                              ; SHL r/m32, CL || o32 D3 /4 || encoded[2]{d3 e2}
0011h or eax,edx                              ; OR r32, r/m32 || o32 0B /r || encoded[2]{0b c2}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint set_bit_off(uint src, byte pos)
; static ReadOnlySpan<byte> set_bit_off_32uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0xF7,0xD2,0x23,0xC2,0xC3};
; [0x7ff7c8392770, 0x7ff7c8392786], 22 bytes
; 2020-01-20 01:59:21:025
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah mov edx,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 01 00 00 00}
000fh shl edx,cl                              ; SHL r/m32, CL || o32 D3 /4 || encoded[2]{d3 e2}
0011h not edx                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d2}
0013h and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
