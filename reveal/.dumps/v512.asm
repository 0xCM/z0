; 2020-01-20 01:59:21:283
; Vector512<uint> add_512x32u(Vector512<uint> x, Vector512<uint> y)
; static ReadOnlySpan<byte> add_512x32u_512x32uBytes => new byte[41]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xFE,0x00,0xC5,0xFD,0x10,0x4A,0x20,0xC4,0xC1,0x75,0xFE,0x48,0x20,0xC5,0xFD,0x11,0x01,0xC5,0xFD,0x11,0x49,0x20,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f0f40, 0x7ff7c85f0f69], 41 bytes
; 2020-01-20 01:59:21:283
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vpaddd ymm0,ymm0,[r8]                   ; VPADDD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG FE /r || encoded[5]{c4 c1 7d fe 00}
000eh vmovupd ymm1,[rdx+20h]                  ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c5 fd 10 4a 20}
0013h vpaddd ymm1,ymm1,[r8+20h]               ; VPADDD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG FE /r || encoded[6]{c4 c1 75 fe 48 20}
0019h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
001dh vmovupd [rcx+20h],ymm1                  ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[5]{c5 fd 11 49 20}
0022h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0025h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0028h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void add_2x256x32u(Vector256<uint> x0, Vector256<uint> y0, Vector256<uint> x1, Vector256<uint> y1, out Vector256<uint> z0, out Vector256<uint> z1)
; static ReadOnlySpan<byte> add_2x256x32u_256x32u_256x32u_256x32u_256x32u_256x0x_256x0xBytes => new byte[45]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0xFE,0x02,0x48,0x8B,0x44,0x24,0x28,0xC5,0xFD,0x11,0x00,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xC1,0x7D,0xFE,0x01,0x48,0x8B,0x44,0x24,0x30,0xC5,0xFD,0x11,0x00,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f0f80, 0x7ff7c85f0fad], 45 bytes
; 2020-01-20 01:59:21:283
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 01}
0009h vpaddd ymm0,ymm0,[rdx]                  ; VPADDD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG FE /r || encoded[4]{c5 fd fe 02}
000dh mov rax,[rsp+28h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 28}
0012h vmovupd [rax],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 00}
0016h vmovupd ymm0,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 00}
001bh vpaddd ymm0,ymm0,[r9]                   ; VPADDD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG FE /r || encoded[5]{c4 c1 7d fe 01}
0020h mov rax,[rsp+30h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 30}
0025h vmovupd [rax],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 00}
0029h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
002ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
