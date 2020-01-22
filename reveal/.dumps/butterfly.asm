; 2020-01-22 01:43:39:000
; uint bfly_1x32(uint src)
; bfly_1x32_32u[0x7ff7c8380a30, 0x7ff7c8380a4e][30] = {0f 1f 44 00 00 8b c1 25 66 66 66 66 8b d0 d1 e2 33 d0 d1 e8 33 c2 25 66 66 66 66 33 c1 c3}
; Capture completion code, None
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
; bfly_1x32_op_32u[0x7ff7c8380a60, 0x7ff7c8380a7e][30] = {0f 1f 44 00 00 8b c1 25 66 66 66 66 8b d0 d1 e2 33 d0 d1 e8 33 c2 25 66 66 66 66 33 c1 c3}
; Capture completion code, None
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
; bfly_2x32_32u[0x7ff7c8380a90, 0x7ff7c8380ab0][32] = {0f 1f 44 00 00 8b c1 25 3c 3c 3c 3c 8b d0 c1 e2 02 33 d0 c1 e8 02 33 c2 25 3c 3c 3c 3c 33 c1 c3}
; Capture completion code, None
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
; bfly_2x32_op_32u[0x7ff7c8380ac0, 0x7ff7c8380ae0][32] = {0f 1f 44 00 00 8b c1 25 3c 3c 3c 3c 8b d0 c1 e2 02 33 d0 c1 e8 02 33 c2 25 3c 3c 3c 3c 33 c1 c3}
; Capture completion code, None
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
; bfly_4x32_32u[0x7ff7c8380af0, 0x7ff7c8380b10][32] = {0f 1f 44 00 00 8b c1 25 f0 0f f0 0f 8b d0 c1 e2 04 33 d0 c1 e8 04 33 c2 25 f0 0f f0 0f 33 c1 c3}
; Capture completion code, None
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
; bfly_4x32_op_32u[0x7ff7c8380b20, 0x7ff7c8380b40][32] = {0f 1f 44 00 00 8b c1 25 f0 0f f0 0f 8b d0 c1 e2 04 33 d0 c1 e8 04 33 c2 25 f0 0f f0 0f 33 c1 c3}
; Capture completion code, None
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
