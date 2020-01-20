; 2020-01-20 01:59:20:686
; uint bfly_1x32(uint src)
; static ReadOnlySpan<byte> bfly_1x32_32uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0x66,0x66,0x66,0x66,0x8B,0xD0,0xD1,0xE2,0x33,0xD0,0xD1,0xE8,0x33,0xC2,0x25,0x66,0x66,0x66,0x66,0x33,0xC1,0xC3};
; [0x7ff7c83825b0, 0x7ff7c83825ce], 30 bytes
; 2020-01-20 01:59:20:686
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h and eax,66666666h                       ; AND EAX, imm32 || o32 25 id || encoded[5]{25 66 66 66 66}
000ch mov edx,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d0}
000eh shl edx,1                               ; SHL r/m32, 1 || o32 D1 /4 || encoded[2]{d1 e2}
0010h xor edx,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d0}
0012h shr eax,1                               ; SHR r/m32, 1 || o32 D1 /5 || encoded[2]{d1 e8}
0014h xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
0016h and eax,66666666h                       ; AND EAX, imm32 || o32 25 id || encoded[5]{25 66 66 66 66}
001bh xor eax,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c1}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint bfly_1x32_op(uint src)
; static ReadOnlySpan<byte> bfly_1x32_op_32uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0x66,0x66,0x66,0x66,0x8B,0xD0,0xD1,0xE2,0x33,0xD0,0xD1,0xE8,0x33,0xC2,0x25,0x66,0x66,0x66,0x66,0x33,0xC1,0xC3};
; [0x7ff7c83825e0, 0x7ff7c83825fe], 30 bytes
; 2020-01-20 01:59:20:686
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h and eax,66666666h                       ; AND EAX, imm32 || o32 25 id || encoded[5]{25 66 66 66 66}
000ch mov edx,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d0}
000eh shl edx,1                               ; SHL r/m32, 1 || o32 D1 /4 || encoded[2]{d1 e2}
0010h xor edx,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d0}
0012h shr eax,1                               ; SHR r/m32, 1 || o32 D1 /5 || encoded[2]{d1 e8}
0014h xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
0016h and eax,66666666h                       ; AND EAX, imm32 || o32 25 id || encoded[5]{25 66 66 66 66}
001bh xor eax,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c1}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint bfly_2x32(uint src)
; static ReadOnlySpan<byte> bfly_2x32_32uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0x3C,0x3C,0x3C,0x3C,0x8B,0xD0,0xC1,0xE2,0x02,0x33,0xD0,0xC1,0xE8,0x02,0x33,0xC2,0x25,0x3C,0x3C,0x3C,0x3C,0x33,0xC1,0xC3};
; [0x7ff7c8382610, 0x7ff7c8382630], 32 bytes
; 2020-01-20 01:59:20:686
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h and eax,3C3C3C3Ch                       ; AND EAX, imm32 || o32 25 id || encoded[5]{25 3c 3c 3c 3c}
000ch mov edx,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d0}
000eh shl edx,2                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e2 02}
0011h xor edx,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d0}
0013h shr eax,2                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e8 02}
0016h xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
0018h and eax,3C3C3C3Ch                       ; AND EAX, imm32 || o32 25 id || encoded[5]{25 3c 3c 3c 3c}
001dh xor eax,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c1}
001fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint bfly_2x32_op(uint src)
; static ReadOnlySpan<byte> bfly_2x32_op_32uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0x3C,0x3C,0x3C,0x3C,0x8B,0xD0,0xC1,0xE2,0x02,0x33,0xD0,0xC1,0xE8,0x02,0x33,0xC2,0x25,0x3C,0x3C,0x3C,0x3C,0x33,0xC1,0xC3};
; [0x7ff7c8382640, 0x7ff7c8382660], 32 bytes
; 2020-01-20 01:59:20:686
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h and eax,3C3C3C3Ch                       ; AND EAX, imm32 || o32 25 id || encoded[5]{25 3c 3c 3c 3c}
000ch mov edx,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d0}
000eh shl edx,2                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e2 02}
0011h xor edx,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d0}
0013h shr eax,2                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e8 02}
0016h xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
0018h and eax,3C3C3C3Ch                       ; AND EAX, imm32 || o32 25 id || encoded[5]{25 3c 3c 3c 3c}
001dh xor eax,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c1}
001fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint bfly_4x32(uint src)
; static ReadOnlySpan<byte> bfly_4x32_32uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0xF0,0x0F,0xF0,0x0F,0x8B,0xD0,0xC1,0xE2,0x04,0x33,0xD0,0xC1,0xE8,0x04,0x33,0xC2,0x25,0xF0,0x0F,0xF0,0x0F,0x33,0xC1,0xC3};
; [0x7ff7c8382670, 0x7ff7c8382690], 32 bytes
; 2020-01-20 01:59:20:687
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h and eax,0FF00FF0h                       ; AND EAX, imm32 || o32 25 id || encoded[5]{25 f0 0f f0 0f}
000ch mov edx,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d0}
000eh shl edx,4                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e2 04}
0011h xor edx,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d0}
0013h shr eax,4                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e8 04}
0016h xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
0018h and eax,0FF00FF0h                       ; AND EAX, imm32 || o32 25 id || encoded[5]{25 f0 0f f0 0f}
001dh xor eax,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c1}
001fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint bfly_4x32_op(uint src)
; static ReadOnlySpan<byte> bfly_4x32_op_32uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0xF0,0x0F,0xF0,0x0F,0x8B,0xD0,0xC1,0xE2,0x04,0x33,0xD0,0xC1,0xE8,0x04,0x33,0xC2,0x25,0xF0,0x0F,0xF0,0x0F,0x33,0xC1,0xC3};
; [0x7ff7c83826a0, 0x7ff7c83826c0], 32 bytes
; 2020-01-20 01:59:20:687
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h and eax,0FF00FF0h                       ; AND EAX, imm32 || o32 25 id || encoded[5]{25 f0 0f f0 0f}
000ch mov edx,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d0}
000eh shl edx,4                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e2 04}
0011h xor edx,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d0}
0013h shr eax,4                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e8 04}
0016h xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
0018h and eax,0FF00FF0h                       ; AND EAX, imm32 || o32 25 id || encoded[5]{25 f0 0f f0 0f}
001dh xor eax,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c1}
001fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
