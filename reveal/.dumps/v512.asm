; 2020-01-05 02:30:51:836
; function: Vector512<uint> add_512x32u(Vector512<uint> x, Vector512<uint> y)
; location: [7FF7C7BBE0E0h, 7FF7C7BBE108h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpaddd ymm0,ymm0,[r8]         ; VPADDD(VEX_Vpaddd_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Int32,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d fe 00
000eh vmovupd ymm1,[rdx+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 4a 20
0013h vpaddd ymm1,ymm1,[r8+20h]     ; VPADDD(VEX_Vpaddd_ymm_ymm_ymmm256) [YMM1,YMM1,mem(Packed256_Int32,R8:br,:sr)] encoding(VEX, 6 bytes) = c4 c1 75 fe 48 20
0019h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001dh vmovupd [rcx+20h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM1] encoding(VEX, 5 bytes) = c5 fd 11 49 20
0022h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0025h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_512x32uBytes => new byte[41]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xFE,0x00,0xC5,0xFD,0x10,0x4A,0x20,0xC4,0xC1,0x75,0xFE,0x48,0x20,0xC5,0xFD,0x11,0x01,0xC5,0xFD,0x11,0x49,0x20,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void add_2x256x32u(Vector256<uint> x0, Vector256<uint> y0, Vector256<uint> x1, Vector256<uint> y1, out Vector256<uint> z0, out Vector256<uint> z1)
; location: [7FF7C7BBE120h, 7FF7C7BBE14Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpaddd ymm0,ymm0,[rdx]        ; VPADDD(VEX_Vpaddd_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Int32,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd fe 02
000dh mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
0012h vmovupd [rax],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RAX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 00
0016h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
001bh vpaddd ymm0,ymm0,[r9]         ; VPADDD(VEX_Vpaddd_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Int32,R9:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d fe 01
0020h mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 30
0025h vmovupd [rax],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RAX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 00
0029h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_2x256x32uBytes => new byte[45]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0xFE,0x02,0x48,0x8B,0x44,0x24,0x28,0xC5,0xFD,0x11,0x00,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xC1,0x7D,0xFE,0x01,0x48,0x8B,0x44,0x24,0x30,0xC5,0xFD,0x11,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
