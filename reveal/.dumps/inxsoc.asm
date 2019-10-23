; 2019-10-22 17:23:22:928
; function: float inxs_add_32f(float x, float y)
; location: [7FFDD9B79260h, 7FFDD9B7927Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss dword ptr [rsp+8],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 08
000bh vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0011h vmovss xmm0,dword ptr [rsp+8] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 08
0017h vaddss xmm0,xmm0,dword ptr [rsp+10h]; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 58 44 24 10
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inxs_add_32fBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x11,0x44,0x24,0x08,0xC5,0xFA,0x11,0x4C,0x24,0x10,0xC5,0xFA,0x10,0x44,0x24,0x08,0xC5,0xFA,0x58,0x44,0x24,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double inxs_add64f(double x, double y)
; location: [7FFDD9B799B0h, 7FFDD9B799D1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
000bh vmovsd qword ptr [rsp+10h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 10
0011h vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0017h vmovsd xmm1,qword ptr [rsp+10h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 4c 24 10
001dh vaddsd xmm0,xmm0,xmm1         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 58 c1
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inxs_add64fBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x11,0x44,0x24,0x08,0xC5,0xFB,0x11,0x4C,0x24,0x10,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC5,0xFB,0x10,0x4C,0x24,0x10,0xC5,0xFB,0x58,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float inxs_sub32f(float x, float y)
; location: [7FFDD9B799F0h, 7FFDD9B79A13h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh vmovss dword ptr [rsp],xmm1   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 5 bytes) = c5 fa 11 0c 24
0010h vmovss xmm0,dword ptr [rsp+4] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 04
0016h vmovss xmm1,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 10 0c 24
001bh vsubss xmm0,xmm0,xmm1         ; VSUBSS(VEX_Vsubss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5c c1
001fh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inxs_sub32fBytes => new byte[36]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0xC5,0xFA,0x11,0x0C,0x24,0xC5,0xFA,0x10,0x44,0x24,0x04,0xC5,0xFA,0x10,0x0C,0x24,0xC5,0xFA,0x5C,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double inxs_sub64f(double x, double y)
; location: [7FFDD9B79A30h, 7FFDD9B79A57h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0013h vmovsd xmm0,qword ptr [rsp+10h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 10
0019h vmovsd xmm1,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 4c 24 08
001fh vsubsd xmm0,xmm0,xmm1         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5c c1
0023h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inxs_sub64fBytes => new byte[40]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x10,0xC5,0xFB,0x10,0x4C,0x24,0x08,0xC5,0xFB,0x5C,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float inxs_mul32f(float x, float y)
; location: [7FFDD9B79A80h, 7FFDD9B79AA3h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh vmovss dword ptr [rsp],xmm1   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 5 bytes) = c5 fa 11 0c 24
0010h vmovss xmm0,dword ptr [rsp+4] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 04
0016h vmovss xmm1,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 10 0c 24
001bh vmulss xmm0,xmm0,xmm1         ; VMULSS(VEX_Vmulss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 59 c1
001fh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inxs_mul32fBytes => new byte[36]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0xC5,0xFA,0x11,0x0C,0x24,0xC5,0xFA,0x10,0x44,0x24,0x04,0xC5,0xFA,0x10,0x0C,0x24,0xC5,0xFA,0x59,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double inxs_mul64f(double x, double y)
; location: [7FFDD9B79AC0h, 7FFDD9B79AE7h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0013h vmovsd xmm0,qword ptr [rsp+10h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 10
0019h vmovsd xmm1,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 4c 24 08
001fh vmulsd xmm0,xmm0,xmm1         ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 59 c1
0023h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inxs_mul64fBytes => new byte[40]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x10,0xC5,0xFB,0x10,0x4C,0x24,0x08,0xC5,0xFB,0x59,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float inxs_div32f(float x, float y)
; location: [7FFDD9B79B10h, 7FFDD9B79B33h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh vmovss dword ptr [rsp],xmm1   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 5 bytes) = c5 fa 11 0c 24
0010h vmovss xmm0,dword ptr [rsp+4] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 04
0016h vmovss xmm1,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 10 0c 24
001bh vdivss xmm0,xmm0,xmm1         ; VDIVSS(VEX_Vdivss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5e c1
001fh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inxs_div32fBytes => new byte[36]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0xC5,0xFA,0x11,0x0C,0x24,0xC5,0xFA,0x10,0x44,0x24,0x04,0xC5,0xFA,0x10,0x0C,0x24,0xC5,0xFA,0x5E,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double inxs_div64f(double x, double y)
; location: [7FFDD9B79B50h, 7FFDD9B79B77h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0013h vmovsd xmm0,qword ptr [rsp+10h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 10
0019h vmovsd xmm1,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 4c 24 08
001fh vdivsd xmm0,xmm0,xmm1         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5e c1
0023h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inxs_div64fBytes => new byte[40]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x10,0xC5,0xFB,0x10,0x4C,0x24,0x08,0xC5,0xFB,0x5E,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float inxs_max32f(float x, float y)
; location: [7FFDD9B79BA0h, 7FFDD9B79BC3h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh vmovss dword ptr [rsp],xmm1   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 5 bytes) = c5 fa 11 0c 24
0010h vmovss xmm0,dword ptr [rsp+4] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 04
0016h vmovss xmm1,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 10 0c 24
001bh vmaxss xmm0,xmm0,xmm1         ; VMAXSS(VEX_Vmaxss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5f c1
001fh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inxs_max32fBytes => new byte[36]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0xC5,0xFA,0x11,0x0C,0x24,0xC5,0xFA,0x10,0x44,0x24,0x04,0xC5,0xFA,0x10,0x0C,0x24,0xC5,0xFA,0x5F,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double inxs_max64f(double x, double y)
; location: [7FFDD9B79BE0h, 7FFDD9B79C07h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0013h vmovsd xmm0,qword ptr [rsp+10h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 10
0019h vmovsd xmm1,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 4c 24 08
001fh vmaxsd xmm0,xmm0,xmm1         ; VMAXSD(VEX_Vmaxsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5f c1
0023h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inxs_max64fBytes => new byte[40]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x10,0xC5,0xFB,0x10,0x4C,0x24,0x08,0xC5,0xFB,0x5F,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float inxs_min32f(float x, float y)
; location: [7FFDD9B79C30h, 7FFDD9B79C53h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh vmovss dword ptr [rsp],xmm1   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 5 bytes) = c5 fa 11 0c 24
0010h vmovss xmm0,dword ptr [rsp+4] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 04
0016h vmovss xmm1,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 10 0c 24
001bh vminss xmm0,xmm0,xmm1         ; VMINSS(VEX_Vminss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5d c1
001fh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inxs_min32fBytes => new byte[36]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0xC5,0xFA,0x11,0x0C,0x24,0xC5,0xFA,0x10,0x44,0x24,0x04,0xC5,0xFA,0x10,0x0C,0x24,0xC5,0xFA,0x5D,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double inxs_min64f(double x, double y)
; location: [7FFDD9B79C70h, 7FFDD9B79C97h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0013h vmovsd xmm0,qword ptr [rsp+10h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 10
0019h vmovsd xmm1,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 4c 24 08
001fh vminsd xmm0,xmm0,xmm1         ; VMINSD(VEX_Vminsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5d c1
0023h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inxs_min64fBytes => new byte[40]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x10,0xC5,0xFB,0x10,0x4C,0x24,0x08,0xC5,0xFB,0x5D,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt128 clmul(ulong x, ulong y)
; location: [7FFDD9B79CC0h, 7FFDD9B79D0Eh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
000eh mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 10
0013h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
0018h vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
001dh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0023h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0028h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 10
002dh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0032h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0036h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
003bh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
003eh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0043h mov [rcx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(4 bytes) = 48 89 41 08
0047h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004ah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
004eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clmulBytes => new byte[79]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x00,0x48,0x8B,0x44,0x24,0x08,0x48,0x89,0x01,0x48,0x8B,0x44,0x24,0x10,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref UInt128 clmul(ulong x, ulong y, ref UInt128 dst)
; location: [7FFDD9B79D30h, 7FFDD9B79D4Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
000ah vmovq xmm1,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e ca
000fh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0015h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0018h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
001ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clmulBytes => new byte[32]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xE1,0xF9,0x6E,0xCA,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x49,0x8B,0xC0,0xC5,0xFA,0x7F,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong clmulr8u(ulong a, ulong b, ulong poly)
; location: [7FFDD9B79D70h, 7FFDD9B79E44h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000eh mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
0013h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0018h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
001dh vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
0022h vmovq xmm1,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e ca
0027h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
002dh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0032h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0036h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
003bh mov rdx,[rax]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 10
003eh mov rcx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 28
0043h shr rcx,8                     ; SHR(Shr_rm64_imm8) [RCX,8h:imm8]                     encoding(4 bytes) = 48 c1 e9 08
0047h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
004ah mov [rsp+18h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 18
004fh mov [rsp+20h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 20
0054h vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
0059h vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
005eh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0064h mov [rsp+18h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 18
0069h mov [rsp+20h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 20
006eh lea rcx,[rsp+18h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 18
0073h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0077h mov rcx,[rsp+18h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 18
007ch xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
007fh mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0082h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0087h mov rdx,[rax]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 10
008ah mov rcx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 28
008fh shr rcx,8                     ; SHR(Shr_rm64_imm8) [RCX,8h:imm8]                     encoding(4 bytes) = 48 c1 e9 08
0093h mov [rsp+8],r9                ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 08
0098h mov [rsp+10h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 10
009dh vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
00a2h vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
00a7h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
00adh mov [rsp+8],r9                ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 08
00b2h mov [rsp+10h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 10
00b7h lea rcx,[rsp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 08
00bch vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
00c0h mov rcx,[rsp+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 08
00c5h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
00c8h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
00cbh mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00d0h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00d4h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clmulr8uBytes => new byte[213]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xE1,0xF9,0x6E,0xCA,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x00,0x48,0x8D,0x44,0x24,0x28,0x48,0x8B,0x10,0x48,0x8B,0x4C,0x24,0x28,0x48,0xC1,0xE9,0x08,0x45,0x33,0xC9,0x4C,0x89,0x4C,0x24,0x18,0x4C,0x89,0x4C,0x24,0x20,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x4C,0x89,0x4C,0x24,0x18,0x4C,0x89,0x4C,0x24,0x20,0x48,0x8D,0x4C,0x24,0x18,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0x4C,0x24,0x18,0x48,0x33,0xD1,0x48,0x89,0x10,0x48,0x8D,0x44,0x24,0x28,0x48,0x8B,0x10,0x48,0x8B,0x4C,0x24,0x28,0x48,0xC1,0xE9,0x08,0x4C,0x89,0x4C,0x24,0x08,0x4C,0x89,0x4C,0x24,0x10,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x4C,0x89,0x4C,0x24,0x08,0x4C,0x89,0x4C,0x24,0x10,0x48,0x8D,0x4C,0x24,0x08,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0x4C,0x24,0x08,0x48,0x33,0xD1,0x48,0x89,0x10,0x48,0x8B,0x44,0x24,0x28,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
