; 2020-01-22 01:43:39:159
; void deposit(in ulong src, ref Fixed128 dst)
; deposit_20798117[0x7ff7c838bdd0, 0x7ff7c838bdde][14] = {c5 f8 77 66 90 c5 fa 6f 01 c5 fa 7f 02 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovdqu xmm0,xmmword ptr [rcx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 01}
0009h vmovdqu xmmword ptr [rdx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 02}
000dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void deposit_4_0(in uint src, ref Fixed128 dst)
; deposit_4_0_24129853[0x7ff7c838bdf0, 0x7ff7c838bdfe][14] = {c5 f8 77 66 90 c5 fa 6f 01 c5 fa 7f 02 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovdqu xmm0,xmmword ptr [rcx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 01}
0009h vmovdqu xmmword ptr [rdx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 02}
000dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void deposit_2_2(in uint src, ref Fixed128 dst)
; deposit_2_2_15842089[0x7ff7c838be10, 0x7ff7c838be20][16] = {0f 1f 44 00 00 48 83 c2 08 48 8b 01 48 89 02 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h add rdx,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c2 08}
0009h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
000ch mov [rdx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 02}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Span<byte> bc_bytes_16u(ushort a)
; bc_bytes_16u_16u[0x7ff7c838be30, 0x7ff7c838be70][64] = {56 48 83 ec 20 89 54 24 38 48 8b f1 48 b9 10 ea e3 c7 f7 7f 00 00 ba 02 00 00 00 e8 90 af 60 5f 48 83 c0 10 ba 02 00 00 00 0f b7 4c 24 38 66 89 08 48 89 06 89 56 08 48 8b c6 48 83 c4 20 5e c3}
; Capture completion code, None
0000h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0001h sub rsp,20h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 20}
0005h mov [rsp+38h],edx                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 54 24 38}
0009h mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
000ch mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0016h mov edx,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 02 00 00 00}
001bh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 90 af 60 5f}
0020h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
0024h mov edx,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 02 00 00 00}
0029h movzx ecx,word ptr [rsp+38h]            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[5]{0f b7 4c 24 38}
002eh mov [rax],cx                            ; MOV r/m16, r16 || o16 89 /r || encoded[3]{66 89 08}
0031h mov [rsi],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 06}
0034h mov [rsi+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 56 08}
0037h mov rax,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c6}
003ah add rsp,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 20}
003eh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
003fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Span<byte> bc_bytes_64u(ulong a)
; bc_bytes_64u_64u[0x7ff7c838be90, 0x7ff7c838becc][60] = {57 56 48 83 ec 28 48 8b f1 48 8b fa 48 b9 10 ea e3 c7 f7 7f 00 00 ba 08 00 00 00 e8 30 af 60 5f 48 83 c0 10 ba 08 00 00 00 48 89 38 48 89 06 89 56 08 48 8b c6 48 83 c4 28 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0006h mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0009h mov rdi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fa}
000ch mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0016h mov edx,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 08 00 00 00}
001bh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 30 af 60 5f}
0020h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
0024h mov edx,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 08 00 00 00}
0029h mov [rax],rdi                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 38}
002ch mov [rsi],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 06}
002fh mov [rsi+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 56 08}
0032h mov rax,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c6}
0035h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0039h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
003ah pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
003bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Span<byte> bc_bytes_fixed256(Fixed256 a)
; bc_bytes_fixed256_8140857[0x7ff7c838c2f0, 0x7ff7c838c33e][78] = {57 56 48 83 ec 28 c5 f8 77 48 8b f9 48 8b f2 48 b9 10 ea e3 c7 f7 7f 00 00 ba 20 00 00 00 e8 cd aa 60 5f 48 83 c0 10 ba 20 00 00 00 c5 fa 6f 06 c5 fa 7f 00 c5 fa 6f 46 10 c5 fa 7f 40 10 48 89 07 89 57 08 48 8b c7 48 83 c4 28 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0006h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0009h mov rdi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f9}
000ch mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
000fh mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0019h mov edx,20h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 20 00 00 00}
001eh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 cd aa 60 5f}
0023h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
0027h mov edx,20h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 20 00 00 00}
002ch vmovdqu xmm0,xmmword ptr [rsi]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 06}
0030h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0034h vmovdqu xmm0,xmmword ptr [rsi+10h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[5]{c5 fa 6f 46 10}
0039h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
003eh mov [rdi],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 07}
0041h mov [rdi+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 57 08}
0044h mov rax,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c7}
0047h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
004bh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
004ch pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
004dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Span<byte> bc_bytes_fixed512(Fixed512 a)
; bc_bytes_fixed512_55429698[0x7ff7c838c360, 0x7ff7c838c3c2][98] = {57 56 48 83 ec 28 c5 f8 77 48 8b f9 48 8b f2 48 b9 10 ea e3 c7 f7 7f 00 00 ba 40 00 00 00 e8 5d aa 60 5f 48 83 c0 10 ba 40 00 00 00 c5 fa 6f 06 c5 fa 7f 00 c5 fa 6f 46 10 c5 fa 7f 40 10 c5 fa 6f 46 20 c5 fa 7f 40 20 c5 fa 6f 46 30 c5 fa 7f 40 30 48 89 07 89 57 08 48 8b c7 48 83 c4 28 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0006h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0009h mov rdi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f9}
000ch mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
000fh mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0019h mov edx,40h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 40 00 00 00}
001eh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 5d aa 60 5f}
0023h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
0027h mov edx,40h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 40 00 00 00}
002ch vmovdqu xmm0,xmmword ptr [rsi]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 06}
0030h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0034h vmovdqu xmm0,xmmword ptr [rsi+10h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[5]{c5 fa 6f 46 10}
0039h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
003eh vmovdqu xmm0,xmmword ptr [rsi+20h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[5]{c5 fa 6f 46 20}
0043h vmovdqu xmmword ptr [rax+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 20}
0048h vmovdqu xmm0,xmmword ptr [rsi+30h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[5]{c5 fa 6f 46 30}
004dh vmovdqu xmmword ptr [rax+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 30}
0052h mov [rdi],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 07}
0055h mov [rdi+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 57 08}
0058h mov rax,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c7}
005bh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
005fh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0060h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0061h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Span<byte> bc_bytes_fixed1024(Fixed1024 a)
; bc_bytes_fixed1024_60620523[0x7ff7c838c3f0, 0x7ff7c838c441][81] = {57 56 55 53 48 83 ec 28 48 8b f9 48 8b f2 48 b9 10 ea e3 c7 f7 7f 00 00 ba 80 00 00 00 e8 ce a9 60 5f 48 83 c0 10 48 8b d8 bd 80 00 00 00 48 8b cb 48 8b d6 41 b8 80 00 00 00 e8 21 9c 60 5f 48 89 1f 89 6f 08 48 8b c7 48 83 c4 28 5b 5d 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0003h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0004h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0008h mov rdi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f9}
000bh mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
000eh mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0018h mov edx,80h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 80 00 00 00}
001dh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 ce a9 60 5f}
0022h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
0026h mov rbx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d8}
0029h mov ebp,80h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{bd 80 00 00 00}
002eh mov rcx,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cb}
0031h mov rdx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d6}
0034h mov r8d,80h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 b8 80 00 00 00}
003ah call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 21 9c 60 5f}
003fh mov [rdi],rbx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 1f}
0042h mov [rdi+8],ebp                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 6f 08}
0045h mov rax,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c7}
0048h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
004ch pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
004dh pop rbp                                 ; POP r64 || 58+ro || encoded[1]{5d}
004eh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
004fh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0050h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Span<byte> bc_bytes_fixed2048(Fixed2048 a)
; bc_bytes_fixed2048_11315292[0x7ff7c838c460, 0x7ff7c838c4b1][81] = {57 56 55 53 48 83 ec 28 48 8b f9 48 8b f2 48 b9 10 ea e3 c7 f7 7f 00 00 ba 00 01 00 00 e8 5e a9 60 5f 48 83 c0 10 48 8b d8 bd 00 01 00 00 48 8b cb 48 8b d6 41 b8 00 01 00 00 e8 b1 9b 60 5f 48 89 1f 89 6f 08 48 8b c7 48 83 c4 28 5b 5d 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0003h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0004h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0008h mov rdi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f9}
000bh mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
000eh mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0018h mov edx,100h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 00 01 00 00}
001dh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 5e a9 60 5f}
0022h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
0026h mov rbx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d8}
0029h mov ebp,100h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{bd 00 01 00 00}
002eh mov rcx,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cb}
0031h mov rdx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d6}
0034h mov r8d,100h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 b8 00 01 00 00}
003ah call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 b1 9b 60 5f}
003fh mov [rdi],rbx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 1f}
0042h mov [rdi+8],ebp                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 6f 08}
0045h mov rax,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c7}
0048h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
004ch pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
004dh pop rbp                                 ; POP r64 || 58+ro || encoded[1]{5d}
004eh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
004fh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0050h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Span<byte> bc_bytes_fixed4096(Fixed4096 a)
; bc_bytes_fixed4096_44123454[0x7ff7c838c4d0, 0x7ff7c838c521][81] = {57 56 55 53 48 83 ec 28 48 8b f9 48 8b f2 48 b9 10 ea e3 c7 f7 7f 00 00 ba 00 02 00 00 e8 ee a8 60 5f 48 83 c0 10 48 8b d8 bd 00 02 00 00 48 8b cb 48 8b d6 41 b8 00 02 00 00 e8 41 9b 60 5f 48 89 1f 89 6f 08 48 8b c7 48 83 c4 28 5b 5d 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0003h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0004h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0008h mov rdi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f9}
000bh mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
000eh mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0018h mov edx,200h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 00 02 00 00}
001dh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 ee a8 60 5f}
0022h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
0026h mov rbx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d8}
0029h mov ebp,200h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{bd 00 02 00 00}
002eh mov rcx,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cb}
0031h mov rdx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d6}
0034h mov r8d,200h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 b8 00 02 00 00}
003ah call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 41 9b 60 5f}
003fh mov [rdi],rbx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 1f}
0042h mov [rdi+8],ebp                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 6f 08}
0045h mov rax,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c7}
0048h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
004ch pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
004dh pop rbp                                 ; POP r64 || 58+ro || encoded[1]{5d}
004eh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
004fh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0050h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
