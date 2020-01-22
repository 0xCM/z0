; 2020-01-22 01:44:40:382
; Vector128<int> vlt_128x32i(Vector128<int> x, Vector128<int> y)
; vlt_128x32i_128x32i[0x7ff7c85a3340, 0x7ff7c85a335a][26] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f1 66 c0 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpcmpgtd xmm0,xmm1,xmm0                 ; VPCMPGTD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 66 /r || encoded[4]{c5 f1 66 c0}
0012h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<int> vlt_g128x32i(Vector128<int> x, Vector128<int> y)
; vlt_g128x32i_128x32i[0x7ff7c85a3370, 0x7ff7c85a338a][26] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f1 66 c0 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpcmpgtd xmm0,xmm1,xmm0                 ; VPCMPGTD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 66 /r || encoded[4]{c5 f1 66 c0}
0012h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<int> vlt_o128x32i(Vector128<int> x, Vector128<int> y)
; vlt_o128x32i_128x32i[0x7ff7c85a37b0, 0x7ff7c85a37ca][26] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 f1 66 c0 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpcmpgtd xmm0,xmm1,xmm0                 ; VPCMPGTD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 66 /r || encoded[4]{c5 f1 66 c0}
0012h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vlt_128x32u(Vector128<uint> x, Vector128<uint> y)
; vlt_128x32u_128x32u[0x7ff7c85a37e0, 0x7ff7c85a381a][58] = {50 c5 f8 77 90 c5 f9 10 02 c4 c1 79 10 08 c7 44 24 04 00 00 00 80 48 8d 44 24 04 c4 e2 79 58 54 24 04 c5 f9 ef c2 c5 f1 ef ca c5 f1 66 c0 c5 f9 11 01 48 8b c1 48 83 c4 08 c3}
; Capture completion code, None
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh mov dword ptr [rsp+4],80000000h         ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 04 00 00 00 80}
0016h lea rax,[rsp+4]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 04}
001bh vpbroadcastd xmm2,dword ptr [rsp+4]     ; VPBROADCASTD xmm1, xmm2/m32 || VEX.128.66.0F38.W0 58 /r || encoded[7]{c4 e2 79 58 54 24 04}
0022h vpxor xmm0,xmm0,xmm2                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f9 ef c2}
0026h vpxor xmm1,xmm1,xmm2                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f1 ef ca}
002ah vpcmpgtd xmm0,xmm1,xmm0                 ; VPCMPGTD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 66 /r || encoded[4]{c5 f1 66 c0}
002eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0032h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0035h add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
0039h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vlt_g128x32u(Vector128<uint> x, Vector128<uint> y)
; vlt_g128x32u_128x32u[0x7ff7c85a3840, 0x7ff7c85a387a][58] = {50 c5 f8 77 90 c5 f9 10 02 c4 c1 79 10 08 c7 44 24 04 00 00 00 80 48 8d 44 24 04 c4 e2 79 58 54 24 04 c5 f9 ef c2 c5 f1 ef ca c5 f1 66 c0 c5 f9 11 01 48 8b c1 48 83 c4 08 c3}
; Capture completion code, None
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh mov dword ptr [rsp+4],80000000h         ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 04 00 00 00 80}
0016h lea rax,[rsp+4]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 04}
001bh vpbroadcastd xmm2,dword ptr [rsp+4]     ; VPBROADCASTD xmm1, xmm2/m32 || VEX.128.66.0F38.W0 58 /r || encoded[7]{c4 e2 79 58 54 24 04}
0022h vpxor xmm0,xmm0,xmm2                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f9 ef c2}
0026h vpxor xmm1,xmm1,xmm2                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f1 ef ca}
002ah vpcmpgtd xmm0,xmm1,xmm0                 ; VPCMPGTD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 66 /r || encoded[4]{c5 f1 66 c0}
002eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0032h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0035h add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
0039h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vlt_o128x32u(Vector128<uint> x, Vector128<uint> y)
; vlt_o128x32u_128x32u[0x7ff7c85a38a0, 0x7ff7c85a38da][58] = {50 c5 f8 77 90 c5 f9 10 02 c4 c1 79 10 08 c7 44 24 04 00 00 00 80 48 8d 44 24 04 c4 e2 79 58 54 24 04 c5 f9 ef c2 c5 f1 ef ca c5 f1 66 c0 c5 f9 11 01 48 8b c1 48 83 c4 08 c3}
; Capture completion code, None
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh mov dword ptr [rsp+4],80000000h         ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 04 00 00 00 80}
0016h lea rax,[rsp+4]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 04}
001bh vpbroadcastd xmm2,dword ptr [rsp+4]     ; VPBROADCASTD xmm1, xmm2/m32 || VEX.128.66.0F38.W0 58 /r || encoded[7]{c4 e2 79 58 54 24 04}
0022h vpxor xmm0,xmm0,xmm2                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f9 ef c2}
0026h vpxor xmm1,xmm1,xmm2                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f1 ef ca}
002ah vpcmpgtd xmm0,xmm1,xmm0                 ; VPCMPGTD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 66 /r || encoded[4]{c5 f1 66 c0}
002eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0032h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0035h add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
0039h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<long> vlt_128x64i(Vector128<long> x, Vector128<long> y)
; vlt_128x64i_128x64i[0x7ff7c85a3900, 0x7ff7c85a393a][58] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 ec 57 d2 c4 e3 6d 38 c0 00 c4 e3 7d 38 c1 01 c4 e3 7d 46 c8 03 c4 e2 75 37 c0 c4 e3 7d 19 c0 00 c5 f9 11 01 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vxorps ymm2,ymm2,ymm2                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 ec 57 d2}
0012h vinserti128 ymm0,ymm2,xmm0,0            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 6d 38 c0 00}
0018h vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 7d 38 c1 01}
001eh vperm2i128 ymm1,ymm0,ymm0,3             ; VPERM2I128 ymm1, ymm2, ymm3/m256, imm8 || VEX.256.66.0F3A.W0 46 /r ib || encoded[6]{c4 e3 7d 46 c8 03}
0024h vpcmpgtq ymm0,ymm1,ymm0                 ; VPCMPGTQ ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 37 /r || encoded[5]{c4 e2 75 37 c0}
0029h vextractf128 xmm0,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 00}
002fh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0033h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0036h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0039h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<long> vlt_g128x64i(Vector128<long> x, Vector128<long> y)
; vlt_g128x64i_128x64i[0x7ff7c85a3d60, 0x7ff7c85a3d9a][58] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 ec 57 d2 c4 e3 6d 38 c0 00 c4 e3 7d 38 c1 01 c4 e3 7d 46 c8 03 c4 e2 75 37 c0 c4 e3 7d 19 c0 00 c5 f9 11 01 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vxorps ymm2,ymm2,ymm2                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 ec 57 d2}
0012h vinserti128 ymm0,ymm2,xmm0,0            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 6d 38 c0 00}
0018h vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 7d 38 c1 01}
001eh vperm2i128 ymm1,ymm0,ymm0,3             ; VPERM2I128 ymm1, ymm2, ymm3/m256, imm8 || VEX.256.66.0F3A.W0 46 /r ib || encoded[6]{c4 e3 7d 46 c8 03}
0024h vpcmpgtq ymm0,ymm1,ymm0                 ; VPCMPGTQ ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 37 /r || encoded[5]{c4 e2 75 37 c0}
0029h vextractf128 xmm0,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 00}
002fh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0033h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0036h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0039h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<long> vlt_o128x64i(Vector128<long> x, Vector128<long> y)
; vlt_o128x64i_128x64i[0x7ff7c85a3db0, 0x7ff7c85a3dea][58] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c5 ec 57 d2 c4 e3 6d 38 c0 00 c4 e3 7d 38 c1 01 c4 e3 7d 46 c8 03 c4 e2 75 37 c0 c4 e3 7d 19 c0 00 c5 f9 11 01 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vxorps ymm2,ymm2,ymm2                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 ec 57 d2}
0012h vinserti128 ymm0,ymm2,xmm0,0            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 6d 38 c0 00}
0018h vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 7d 38 c1 01}
001eh vperm2i128 ymm1,ymm0,ymm0,3             ; VPERM2I128 ymm1, ymm2, ymm3/m256, imm8 || VEX.256.66.0F3A.W0 46 /r ib || encoded[6]{c4 e3 7d 46 c8 03}
0024h vpcmpgtq ymm0,ymm1,ymm0                 ; VPCMPGTQ ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 37 /r || encoded[5]{c4 e2 75 37 c0}
0029h vextractf128 xmm0,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 00}
002fh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0033h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0036h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0039h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> vlt_256x8u(Vector256<byte> x, Vector256<byte> y)
; vlt_256x8u_256x8u[0x7ff7c85a3e00, 0x7ff7c85a3e3d][61] = {50 c5 f8 77 90 c5 fd 10 02 c4 c1 7d 10 08 c7 44 24 04 80 00 00 00 48 8d 44 24 04 c4 e2 7d 78 54 24 04 c5 fd ef c2 c5 f5 ef ca c5 f5 64 c0 c5 fd 11 01 48 8b c1 c5 f8 77 48 83 c4 08 c3}
; Capture completion code, None
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh mov dword ptr [rsp+4],80h               ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 04 80 00 00 00}
0016h lea rax,[rsp+4]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 04}
001bh vpbroadcastb ymm2,byte ptr [rsp+4]      ; VPBROADCASTB ymm1, xmm2/m8 || VEX.256.66.0F38.W0 78 /r || encoded[7]{c4 e2 7d 78 54 24 04}
0022h vpxor ymm0,ymm0,ymm2                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 fd ef c2}
0026h vpxor ymm1,ymm1,ymm2                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 f5 ef ca}
002ah vpcmpgtb ymm0,ymm1,ymm0                 ; VPCMPGTB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 64 /r || encoded[4]{c5 f5 64 c0}
002eh vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0032h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0035h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0038h add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
003ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> vlt_g256x8u(Vector256<byte> x, Vector256<byte> y)
; vlt_g256x8u_256x8u[0x7ff7c85a3e60, 0x7ff7c85a3e9d][61] = {50 c5 f8 77 90 c5 fd 10 02 c4 c1 7d 10 08 c7 44 24 04 80 00 00 00 48 8d 44 24 04 c4 e2 7d 78 54 24 04 c5 fd ef c2 c5 f5 ef ca c5 f5 64 c0 c5 fd 11 01 48 8b c1 c5 f8 77 48 83 c4 08 c3}
; Capture completion code, None
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh mov dword ptr [rsp+4],80h               ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 04 80 00 00 00}
0016h lea rax,[rsp+4]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 04}
001bh vpbroadcastb ymm2,byte ptr [rsp+4]      ; VPBROADCASTB ymm1, xmm2/m8 || VEX.256.66.0F38.W0 78 /r || encoded[7]{c4 e2 7d 78 54 24 04}
0022h vpxor ymm0,ymm0,ymm2                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 fd ef c2}
0026h vpxor ymm1,ymm1,ymm2                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 f5 ef ca}
002ah vpcmpgtb ymm0,ymm1,ymm0                 ; VPCMPGTB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 64 /r || encoded[4]{c5 f5 64 c0}
002eh vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0032h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0035h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0038h add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
003ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> vlt_o256x8u(Vector256<byte> x, Vector256<byte> y)
; vlt_o256x8u_256x8u[0x7ff7c85a42c0, 0x7ff7c85a42fd][61] = {50 c5 f8 77 90 c5 fd 10 02 c4 c1 7d 10 08 c7 44 24 04 80 00 00 00 48 8d 44 24 04 c4 e2 7d 78 54 24 04 c5 fd ef c2 c5 f5 ef ca c5 f5 64 c0 c5 fd 11 01 48 8b c1 c5 f8 77 48 83 c4 08 c3}
; Capture completion code, None
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh mov dword ptr [rsp+4],80h               ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 04 80 00 00 00}
0016h lea rax,[rsp+4]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 04}
001bh vpbroadcastb ymm2,byte ptr [rsp+4]      ; VPBROADCASTB ymm1, xmm2/m8 || VEX.256.66.0F38.W0 78 /r || encoded[7]{c4 e2 7d 78 54 24 04}
0022h vpxor ymm0,ymm0,ymm2                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 fd ef c2}
0026h vpxor ymm1,ymm1,ymm2                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 f5 ef ca}
002ah vpcmpgtb ymm0,ymm1,ymm0                 ; VPCMPGTB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 64 /r || encoded[4]{c5 f5 64 c0}
002eh vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0032h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0035h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0038h add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
003ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
; vtestz_d128x8i_128x8i_128x8i[0x7ff7c85a4320, 0x7ff7c85a4341][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
; vtestz_g128x8i_128x8i_128x8i[0x7ff7c85a4360, 0x7ff7c85a4381][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
; vtestz_d128x8u_128x8u_128x8u[0x7ff7c85a43a0, 0x7ff7c85a43c1][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
; vtestz_g128x8u_128x8u_128x8u[0x7ff7c85a43e0, 0x7ff7c85a4401][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d128x16i(Vector128<Int16> src, Vector128<Int16> mask)
; vtestz_d128x16i_128x16i_128x16i[0x7ff7c85a4420, 0x7ff7c85a4441][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g128x16i(Vector128<Int16> src, Vector128<Int16> mask)
; vtestz_g128x16i_128x16i_128x16i[0x7ff7c85a4460, 0x7ff7c85a4481][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
; vtestz_d128x16u_128x16u_128x16u[0x7ff7c85a44a0, 0x7ff7c85a44c1][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
; vtestz_g128x16u_128x16u_128x16u[0x7ff7c85a44e0, 0x7ff7c85a4501][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
; vtestz_d128x32i_128x32i_128x32i[0x7ff7c85a4520, 0x7ff7c85a4541][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
; vtestz_g128x32i_128x32i_128x32i[0x7ff7c85a4560, 0x7ff7c85a4581][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
; vtestz_d128x32u_128x32u_128x32u[0x7ff7c85a45a0, 0x7ff7c85a45c1][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
; vtestz_g128x32u_128x32u_128x32u[0x7ff7c85a45e0, 0x7ff7c85a4601][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
; vtestz_d128x64i_128x64i_128x64i[0x7ff7c85a4620, 0x7ff7c85a4641][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
; vtestz_g128x64i_128x64i_128x64i[0x7ff7c85a4a60, 0x7ff7c85a4a81][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
; vtestz_d128x64u_128x64u_128x64u[0x7ff7c85a4aa0, 0x7ff7c85a4ac1][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
; vtestz_g128x64u_128x64u_128x64u[0x7ff7c85a4ae0, 0x7ff7c85a4b01][33] = {c5 f8 77 66 90 c5 f9 10 01 c5 f9 10 0a c4 e2 79 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
000dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
; vtestz_d256x8i_256x8i_256x8i[0x7ff7c85a4b20, 0x7ff7c85a4b44][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
; vtestz_g256x8i_256x8i_256x8i[0x7ff7c85a4b60, 0x7ff7c85a4b84][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
; vtestz_d256x8u_256x8u_256x8u[0x7ff7c85a4ba0, 0x7ff7c85a4bc4][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
; vtestz_g256x8u_256x8u_256x8u[0x7ff7c85a4be0, 0x7ff7c85a4c04][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d256x16i(Vector256<Int16> src, Vector256<Int16> mask)
; vtestz_d256x16i_256x16i_256x16i[0x7ff7c85a4c20, 0x7ff7c85a4c44][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g256x16i(Vector256<Int16> src, Vector256<Int16> mask)
; vtestz_g256x16i_256x16i_256x16i[0x7ff7c85a4c60, 0x7ff7c85a4c84][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
; vtestz_d256x16u_256x16u_256x16u[0x7ff7c85a4ca0, 0x7ff7c85a4cc4][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
; vtestz_g256x16u_256x16u_256x16u[0x7ff7c85a4ce0, 0x7ff7c85a4d04][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
; vtestz_d256x32i_256x32i_256x32i[0x7ff7c85a4d20, 0x7ff7c85a4d44][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
; vtestz_g256x32i_256x32i_256x32i[0x7ff7c85a4d60, 0x7ff7c85a4d84][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
; vtestz_d256x32u_256x32u_256x32u[0x7ff7c85a4da0, 0x7ff7c85a4dc4][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
; vtestz_g256x32u_256x32u_256x32u[0x7ff7c85a4de0, 0x7ff7c85a4e04][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
; vtestz_d256x64i_256x64i_256x64i[0x7ff7c85a4e20, 0x7ff7c85a4e44][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
; vtestz_g256x64i_256x64i_256x64i[0x7ff7c85a4e60, 0x7ff7c85a4e84][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
; vtestz_d256x64u_256x64u_256x64u[0x7ff7c85a4ea0, 0x7ff7c85a4ec4][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
; vtestz_g256x64u_256x64u_256x64u[0x7ff7c85a4ee0, 0x7ff7c85a4f04][36] = {c5 f8 77 66 90 c5 fd 10 01 c5 fd 10 0a c4 e2 7d 17 c1 0f 94 c0 0f b6 c0 85 c0 0f 95 c0 0f b6 c0 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh vptest ymm0,ymm1                        ; VPTEST ymm1, ymm2/m256 || VEX.256.66.0F38.WIG 17 /r || encoded[5]{c4 e2 7d 17 c1}
0012h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0015h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0018h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
001ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
001dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0020h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
