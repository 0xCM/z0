; 2020-01-20 01:59:20:883
; void deposit(in ulong src, ref Fixed128 dst)
; static ReadOnlySpan<byte> deposit_19590229Bytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
; [0x7ff7c838d610, 0x7ff7c838d61e], 14 bytes
; 2020-01-20 01:59:20:883
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovdqu xmm0,xmmword ptr [rcx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 01}
0009h vmovdqu xmmword ptr [rdx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 02}
000dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void deposit_4_0(in uint src, ref Fixed128 dst)
; static ReadOnlySpan<byte> deposit_4_0_18018639Bytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
; [0x7ff7c838d630, 0x7ff7c838d63e], 14 bytes
; 2020-01-20 01:59:20:883
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovdqu xmm0,xmmword ptr [rcx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 01}
0009h vmovdqu xmmword ptr [rdx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 02}
000dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void deposit_2_2(in uint src, ref Fixed128 dst)
; static ReadOnlySpan<byte> deposit_2_2_27950026Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x83,0xC2,0x08,0x48,0x8B,0x01,0x48,0x89,0x02,0xC3};
; [0x7ff7c838d650, 0x7ff7c838d660], 16 bytes
; 2020-01-20 01:59:20:883
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h add rdx,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c2 08}
0009h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
000ch mov [rdx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 02}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Span<byte> bc_bytes_16u(ushort a)
; static ReadOnlySpan<byte> bc_bytes_16u_16uBytes => new byte[64]{0x56,0x48,0x83,0xEC,0x20,0x89,0x54,0x24,0x38,0x48,0x8B,0xF1,0x48,0xB9,0x10,0xEA,0xE3,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x02,0x00,0x00,0x00,0xE8,0x50,0x97,0x60,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x02,0x00,0x00,0x00,0x0F,0xB7,0x4C,0x24,0x38,0x66,0x89,0x08,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
; [0x7ff7c838d670, 0x7ff7c838d6b0], 64 bytes
; 2020-01-20 01:59:20:883
0000h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0001h sub rsp,20h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 20}
0005h mov [rsp+38h],edx                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 54 24 38}
0009h mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
000ch mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0016h mov edx,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 02 00 00 00}
001bh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 50 97 60 5f}
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
; static ReadOnlySpan<byte> bc_bytes_64u_64uBytes => new byte[60]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8B,0xFA,0x48,0xB9,0x10,0xEA,0xE3,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x08,0x00,0x00,0x00,0xE8,0xF0,0x96,0x60,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x08,0x00,0x00,0x00,0x48,0x89,0x38,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
; [0x7ff7c838d6d0, 0x7ff7c838d70c], 60 bytes
; 2020-01-20 01:59:20:883
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0006h mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0009h mov rdi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fa}
000ch mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0016h mov edx,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 08 00 00 00}
001bh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 f0 96 60 5f}
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
; static ReadOnlySpan<byte> bc_bytes_fixed256_49359659Bytes => new byte[78]{0x57,0x56,0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0xB9,0x10,0xEA,0xE3,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x20,0x00,0x00,0x00,0xE8,0x8D,0x92,0x60,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x20,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x06,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x46,0x10,0xC5,0xFA,0x7F,0x40,0x10,0x48,0x89,0x07,0x89,0x57,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
; [0x7ff7c838db30, 0x7ff7c838db7e], 78 bytes
; 2020-01-20 01:59:20:884
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0006h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0009h mov rdi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f9}
000ch mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
000fh mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0019h mov edx,20h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 20 00 00 00}
001eh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 8d 92 60 5f}
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
; static ReadOnlySpan<byte> bc_bytes_fixed512_38709481Bytes => new byte[98]{0x57,0x56,0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0xB9,0x10,0xEA,0xE3,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x40,0x00,0x00,0x00,0xE8,0x1D,0x92,0x60,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x40,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x06,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x46,0x10,0xC5,0xFA,0x7F,0x40,0x10,0xC5,0xFA,0x6F,0x46,0x20,0xC5,0xFA,0x7F,0x40,0x20,0xC5,0xFA,0x6F,0x46,0x30,0xC5,0xFA,0x7F,0x40,0x30,0x48,0x89,0x07,0x89,0x57,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
; [0x7ff7c838dba0, 0x7ff7c838dc02], 98 bytes
; 2020-01-20 01:59:20:884
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0006h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0009h mov rdi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f9}
000ch mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
000fh mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0019h mov edx,40h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 40 00 00 00}
001eh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 1d 92 60 5f}
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
; static ReadOnlySpan<byte> bc_bytes_fixed1024_48460267Bytes => new byte[81]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0xB9,0x10,0xEA,0xE3,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x80,0x00,0x00,0x00,0xE8,0x8E,0x91,0x60,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xD8,0xBD,0x80,0x00,0x00,0x00,0x48,0x8B,0xCB,0x48,0x8B,0xD6,0x41,0xB8,0x80,0x00,0x00,0x00,0xE8,0xE1,0x83,0x60,0x5F,0x48,0x89,0x1F,0x89,0x6F,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0xC3};
; [0x7ff7c838dc30, 0x7ff7c838dc81], 81 bytes
; 2020-01-20 01:59:20:884
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0003h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0004h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0008h mov rdi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f9}
000bh mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
000eh mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0018h mov edx,80h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 80 00 00 00}
001dh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 8e 91 60 5f}
0022h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
0026h mov rbx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d8}
0029h mov ebp,80h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{bd 80 00 00 00}
002eh mov rcx,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cb}
0031h mov rdx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d6}
0034h mov r8d,80h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 b8 80 00 00 00}
003ah call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 e1 83 60 5f}
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
; static ReadOnlySpan<byte> bc_bytes_fixed2048_32967578Bytes => new byte[81]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0xB9,0x10,0xEA,0xE3,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x00,0x01,0x00,0x00,0xE8,0x1E,0x91,0x60,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xD8,0xBD,0x00,0x01,0x00,0x00,0x48,0x8B,0xCB,0x48,0x8B,0xD6,0x41,0xB8,0x00,0x01,0x00,0x00,0xE8,0x71,0x83,0x60,0x5F,0x48,0x89,0x1F,0x89,0x6F,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0xC3};
; [0x7ff7c838dca0, 0x7ff7c838dcf1], 81 bytes
; 2020-01-20 01:59:20:884
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0003h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0004h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0008h mov rdi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f9}
000bh mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
000eh mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0018h mov edx,100h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 00 01 00 00}
001dh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 1e 91 60 5f}
0022h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
0026h mov rbx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d8}
0029h mov ebp,100h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{bd 00 01 00 00}
002eh mov rcx,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cb}
0031h mov rdx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d6}
0034h mov r8d,100h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 b8 00 01 00 00}
003ah call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 71 83 60 5f}
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
; static ReadOnlySpan<byte> bc_bytes_fixed4096_53128157Bytes => new byte[81]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0xB9,0x10,0xEA,0xE3,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x00,0x02,0x00,0x00,0xE8,0xAE,0x90,0x60,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xD8,0xBD,0x00,0x02,0x00,0x00,0x48,0x8B,0xCB,0x48,0x8B,0xD6,0x41,0xB8,0x00,0x02,0x00,0x00,0xE8,0x01,0x83,0x60,0x5F,0x48,0x89,0x1F,0x89,0x6F,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0xC3};
; [0x7ff7c838dd10, 0x7ff7c838dd61], 81 bytes
; 2020-01-20 01:59:20:884
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0003h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0004h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0008h mov rdi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f9}
000bh mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
000eh mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0018h mov edx,200h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 00 02 00 00}
001dh call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 ae 90 60 5f}
0022h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
0026h mov rbx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d8}
0029h mov ebp,200h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{bd 00 02 00 00}
002eh mov rcx,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cb}
0031h mov rdx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d6}
0034h mov r8d,200h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 b8 00 02 00 00}
003ah call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 01 83 60 5f}
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
