; 2020-01-22 01:43:39:630
; Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> vand_delgate()
; vand_delgate_61347601[0x7ff7c85ab870, 0x7ff7c85ab95b][235] = {57 56 53 48 83 ec 60 c5 f8 77 48 b9 98 27 f0 c7 f7 7f 00 00 e8 67 37 39 5f 48 8b f0 48 b9 88 77 ef c7 f7 7f 00 00 ba 02 00 00 00 e8 a0 b5 3e 5f 48 8b f8 48 b9 30 42 4a c8 f7 7f 00 00 e8 3e 37 39 5f 48 8b d8 4c 8b c3 48 8b cf 33 d2 e8 4e a6 3e 5f 4c 8b c3 48 8b cf ba 01 00 00 00 e8 3e a6 3e 5f c7 44 24 20 03 00 00 00 48 89 7c 24 28 33 d2 48 89 54 24 30 48 ba 18 e1 87 bd 17 02 00 00 48 8b 12 48 8b ce 41 b8 1c 00 00 00 45 33 c9 e8 ac 15 80 5d 48 8b c8 c5 fc 57 c0 c5 fd 11 44 24 40 48 8d 54 24 40 e8 ad f0 ff ff 48 8b f0 48 b9 20 1e 6d c8 f7 7f 00 00 e8 c3 36 39 5f 48 8b d0 48 8b ce 48 8b 06 48 8b 40 68 ff 50 10 48 8b d0 48 b9 20 1e 6d c8 f7 7f 00 00 e8 b1 35 33 5f 90 c5 f8 77 48 83 c4 60 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,60h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 60}
0007h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000ah mov rcx,7FF7C7F02798h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 98 27 f0 c7 f7 7f 00 00}
0014h call 7FF82793EFF0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 67 37 39 5f}
0019h mov rsi,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f0}
001ch mov rcx,7FF7C7EF7788h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 88 77 ef c7 f7 7f 00 00}
0026h mov edx,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 02 00 00 00}
002bh call 7FF827996E40h                      ; CALL rel32 || E8 cd || encoded[5]{e8 a0 b5 3e 5f}
0030h mov rdi,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f8}
0033h mov rcx,7FF7C84A4230h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 30 42 4a c8 f7 7f 00 00}
003dh call 7FF82793EFF0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 3e 37 39 5f}
0042h mov rbx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d8}
0045h mov r8,rbx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c3}
0048h mov rcx,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cf}
004bh xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
004dh call 7FF827995F10h                      ; CALL rel32 || E8 cd || encoded[5]{e8 4e a6 3e 5f}
0052h mov r8,rbx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c3}
0055h mov rcx,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cf}
0058h mov edx,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 01 00 00 00}
005dh call 7FF827995F10h                      ; CALL rel32 || E8 cd || encoded[5]{e8 3e a6 3e 5f}
0062h mov dword ptr [rsp+20h],3               ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 20 03 00 00 00}
006ah mov [rsp+28h],rdi                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 7c 24 28}
006fh xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0071h mov [rsp+30h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 30}
0076h mov rdx,217BD87E118h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 18 e1 87 bd 17 02 00 00}
0080h mov rdx,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 12}
0083h mov rcx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ce}
0086h mov r8d,1Ch                             ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 b8 1c 00 00 00}
008ch xor r9d,r9d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c9}
008fh call 7FF825DACEB0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 ac 15 80 5d}
0094h mov rcx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c8}
0097h vxorps ymm0,ymm0,ymm0                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 fc 57 c0}
009bh vmovupd [rsp+40h],ymm0                  ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[6]{c5 fd 11 44 24 40}
00a1h lea rdx,[rsp+40h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 40}
00a6h call 7FF7C85AA9C8h                      ; CALL rel32 || E8 cd || encoded[5]{e8 ad f0 ff ff}
00abh mov rsi,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f0}
00aeh mov rcx,7FF7C86D1E20h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 20 1e 6d c8 f7 7f 00 00}
00b8h call 7FF82793EFF0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 c3 36 39 5f}
00bdh mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
00c0h mov rcx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ce}
00c3h mov rax,[rsi]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 06}
00c6h mov rax,[rax+68h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 40 68}
00cah call qword ptr [rax+10h]                ; CALL r/m64 || FF /2 || encoded[3]{ff 50 10}
00cdh mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
00d0h mov rcx,7FF7C86D1E20h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 20 1e 6d c8 f7 7f 00 00}
00dah call 7FF8278DEF00h                      ; CALL rel32 || E8 cd || encoded[5]{e8 b1 35 33 5f}
00dfh nop                                     ; NOP || o32 90 || encoded[1]{90}
00e0h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
00e3h add rsp,60h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 60}
00e7h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
00e8h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
00e9h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
00eah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<uint> vand_dynamic(Vector256<uint> a, Vector256<uint> b)
; vand_dynamic_256x32u[0x7ff7c85ab980, 0x7ff7c85ab9b0][48] = {57 56 53 48 83 ec 20 48 8b d9 48 8b f2 49 8b f8 e8 db fe ff ff 48 8b 48 08 48 8b d3 4c 8b c6 4c 8b cf ff 50 18 48 8b c3 48 83 c4 20 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,20h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 20}
0007h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
000ah mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
000dh mov rdi,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f8}
0010h call 7FF7C85AB870h                      ; CALL rel32 || E8 cd || encoded[5]{e8 db fe ff ff}
0015h mov rcx,[rax+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 48 08}
0019h mov rdx,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d3}
001ch mov r8,rsi                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c6}
001fh mov r9,rdi                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b cf}
0022h call qword ptr [rax+18h]                ; CALL r/m64 || FF /2 || encoded[3]{ff 50 18}
0025h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0028h add rsp,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 20}
002ch pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
002dh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
002eh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
002fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector512<ulong> vperm2x128(Vector512<ulong> src)
; vperm2x128_512x64u[0x7ff7c85abdd0, 0x7ff7c85abe02][50] = {c5 f8 77 66 90 c5 fd 10 02 c5 fd 10 4a 20 c5 fc 28 d0 c5 fc 28 d9 c4 e3 6d 46 d3 30 c4 e3 7d 46 c1 21 c5 fd 11 11 c5 fd 11 41 20 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[rdx+20h]                  ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c5 fd 10 4a 20}
000eh vmovaps ymm2,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d0}
0012h vmovaps ymm3,ymm1                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d9}
0016h vperm2i128 ymm2,ymm2,ymm3,30h           ; VPERM2I128 ymm1, ymm2, ymm3/m256, imm8 || VEX.256.66.0F3A.W0 46 /r ib || encoded[6]{c4 e3 6d 46 d3 30}
001ch vperm2i128 ymm0,ymm0,ymm1,21h           ; VPERM2I128 ymm1, ymm2, ymm3/m256, imm8 || VEX.256.66.0F3A.W0 46 /r ib || encoded[6]{c4 e3 7d 46 c1 21}
0022h vmovupd [rcx],ymm2                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 11}
0026h vmovupd [rcx+20h],ymm0                  ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[5]{c5 fd 11 41 20}
002bh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
002eh vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0031h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ushort> vbswap_128x16u(Vector128<ushort> x)
; vbswap_128x16u_128x16u[0x7ff7c85abe20, 0x7ff7c85abe44][36] = {c5 f8 77 66 90 c5 f9 10 02 48 b8 c9 52 6b c6 17 02 00 00 c5 fb f0 08 c4 e2 79 00 c1 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h mov rax,217C66B52C9h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 c9 52 6b c6 17 02 00 00}
0013h vlddqu xmm1,xmmword ptr [rax]           ; VLDDQU xmm1, m128 || VEX.128.F2.0F.WIG F0 /r || encoded[4]{c5 fb f0 08}
0017h vpshufb xmm0,xmm0,xmm1                  ; VPSHUFB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 00 /r || encoded[5]{c4 e2 79 00 c1}
001ch vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0020h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<uint> spec)
; vpermvar8x32_256x32i_256x32i_256x32u[0x7ff7c85abe60, 0x7ff7c85abe7e][30] = {c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c4 e2 75 36 c0 c5 fd 11 01 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpermd ymm0,ymm1,ymm0                   ; VPERMD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.W0 36 /r || encoded[5]{c4 e2 75 36 c0}
0013h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
; vpermvar8x32_256x32u_256x32u[0x7ff7c85abe90, 0x7ff7c85abeae][30] = {c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c4 e2 75 36 c0 c5 fd 11 01 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpermd ymm0,ymm1,ymm0                   ; VPERMD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.W0 36 /r || encoded[5]{c4 e2 75 36 c0}
0013h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
; vpermvar32x8_256x8u_256x8u[0x7ff7c85abec0, 0x7ff7c85abf11][81] = {c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 48 b8 15 7a 09 c6 17 02 00 00 c5 ff f0 10 c5 f5 fc d2 c4 e2 7d 00 d2 c4 e3 7d 46 c0 03 48 b8 45 78 09 c6 17 02 00 00 c5 ff f0 18 c5 f5 fc cb c4 e2 7d 00 c1 c5 ed eb c0 c5 fd 11 01 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh mov rax,217C6097A15h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 15 7a 09 c6 17 02 00 00}
0018h vlddqu ymm2,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 10}
001ch vpaddb ymm2,ymm1,ymm2                   ; VPADDB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG FC /r || encoded[4]{c5 f5 fc d2}
0020h vpshufb ymm2,ymm0,ymm2                  ; VPSHUFB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 00 /r || encoded[5]{c4 e2 7d 00 d2}
0025h vperm2i128 ymm0,ymm0,ymm0,3             ; VPERM2I128 ymm1, ymm2, ymm3/m256, imm8 || VEX.256.66.0F3A.W0 46 /r ib || encoded[6]{c4 e3 7d 46 c0 03}
002bh mov rax,217C6097845h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 45 78 09 c6 17 02 00 00}
0035h vlddqu ymm3,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 18}
0039h vpaddb ymm1,ymm1,ymm3                   ; VPADDB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG FC /r || encoded[4]{c5 f5 fc cb}
003dh vpshufb ymm0,ymm0,ymm1                  ; VPSHUFB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 00 /r || encoded[5]{c4 e2 7d 00 c1}
0042h vpor ymm0,ymm2,ymm0                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 ed eb c0}
0046h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
004ah mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
004dh vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0050h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
; vshuffle_128x8u_128x8u[0x7ff7c85abf30, 0x7ff7c85abf4b][27] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c4 e2 79 00 c1 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpshufb xmm0,xmm0,xmm1                  ; VPSHUFB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 00 /r || encoded[5]{c4 e2 79 00 c1}
0013h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
; vshuffle_128x8i_128x8i[0x7ff7c85abf60, 0x7ff7c85abf7b][27] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c4 e2 79 00 c1 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpshufb xmm0,xmm0,xmm1                  ; VPSHUFB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 00 /r || encoded[5]{c4 e2 79 00 c1}
0013h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
; vshuffle_256x8u_256x8u[0x7ff7c85abf90, 0x7ff7c85abfae][30] = {c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c4 e2 7d 00 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpshufb ymm0,ymm0,ymm1                  ; VPSHUFB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 00 /r || encoded[5]{c4 e2 7d 00 c1}
0013h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
; vshuffle_256x8i_256x8i[0x7ff7c85abfc0, 0x7ff7c85abfde][30] = {c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c4 e2 7d 00 c1 c5 fd 11 01 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpshufb ymm0,ymm0,ymm1                  ; VPSHUFB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 00 /r || encoded[5]{c4 e2 7d 00 c1}
0013h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void vtranspose(ref Vector128<uint> row0, ref Vector128<uint> row1, ref Vector128<uint> row2, ref Vector128<uint> row3)
; vtranspose_128x32u_128x32u_128x32u_128x32u[0x7ff7c85abff0, 0x7ff7c85ac052][98] = {c5 f8 77 66 90 c5 f9 10 01 c5 f8 28 c8 c5 f9 10 12 c5 f8 28 da c5 f0 c6 cb 44 c5 f8 c6 c2 ee c4 c1 79 10 10 c5 f8 28 da c4 c1 79 10 21 c5 f8 28 ec c5 e0 c6 dd 44 c5 e8 c6 d4 ee c5 f0 c6 e3 88 c5 f9 11 21 c5 f0 c6 cb dd c5 f9 11 0a c5 f8 c6 ca 88 c4 c1 79 11 08 c5 f8 c6 c2 dd c4 c1 79 11 01 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovaps xmm1,xmm0                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 c8}
000dh vmovupd xmm2,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 12}
0011h vmovaps xmm3,xmm2                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 da}
0015h vshufps xmm1,xmm1,xmm3,44h              ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 f0 c6 cb 44}
001ah vshufps xmm0,xmm0,xmm2,0EEh             ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 f8 c6 c2 ee}
001fh vmovupd xmm2,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 10}
0024h vmovaps xmm3,xmm2                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 da}
0028h vmovupd xmm4,[r9]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 21}
002dh vmovaps xmm5,xmm4                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 ec}
0031h vshufps xmm3,xmm3,xmm5,44h              ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 e0 c6 dd 44}
0036h vshufps xmm2,xmm2,xmm4,0EEh             ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 e8 c6 d4 ee}
003bh vshufps xmm4,xmm1,xmm3,88h              ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 f0 c6 e3 88}
0040h vmovupd [rcx],xmm4                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 21}
0044h vshufps xmm1,xmm1,xmm3,0DDh             ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 f0 c6 cb dd}
0049h vmovupd [rdx],xmm1                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 0a}
004dh vshufps xmm1,xmm0,xmm2,88h              ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 f8 c6 ca 88}
0052h vmovupd [r8],xmm1                       ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[5]{c4 c1 79 11 08}
0057h vshufps xmm0,xmm0,xmm2,0DDh             ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 f8 c6 c2 dd}
005ch vmovupd [r9],xmm0                       ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[5]{c4 c1 79 11 01}
0061h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
