; 2019-10-29 02:32:28:406
; function: Vector128<sbyte> vadd_d128x8i(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
; location: [7FFDDBAEEFA0h, 7FFDDBAEEFB9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_d128x8iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<sbyte> vadd_g128x8i(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
; location: [7FFDDBAEF3E0h, 7FFDDBAEF3F9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x8iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vadd_g128x8u(Vector128<byte> lhs, Vector128<byte> rhs)
; location: [7FFDDBAEF410h, 7FFDDBAEF429h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x8uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vadd_g128x16i(Vector128<short> lhs, Vector128<short> rhs)
; location: [7FFDDBAEF440h, 7FFDDBAEF459h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddw xmm0,xmm0,xmm1         ; VPADDW(VEX_Vpaddw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fd c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x16iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFD,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vadd_g128x16u(Vector128<ushort> lhs, Vector128<ushort> rhs)
; location: [7FFDDBAEF470h, 7FFDDBAEF489h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddw xmm0,xmm0,xmm1         ; VPADDW(VEX_Vpaddw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fd c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x16uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFD,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<int> vadd_g128x32i(Vector128<int> lhs, Vector128<int> rhs)
; location: [7FFDDBAEF4A0h, 7FFDDBAEF4B9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddd xmm0,xmm0,xmm1         ; VPADDD(VEX_Vpaddd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fe c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x32iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFE,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vadd_g128x32u(Vector128<uint> lhs, Vector128<uint> rhs)
; location: [7FFDDBAEF8E0h, 7FFDDBAEF8F9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddd xmm0,xmm0,xmm1         ; VPADDD(VEX_Vpaddd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fe c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x32uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFE,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<long> vadd_g128x64i(Vector128<long> lhs, Vector128<long> rhs)
; location: [7FFDDBAEF910h, 7FFDDBAEF929h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddq xmm0,xmm0,xmm1         ; VPADDQ(VEX_Vpaddq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 d4 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x64iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xD4,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vadd_g128x64u(Vector128<ulong> lhs, Vector128<ulong> rhs)
; location: [7FFDDBAEF940h, 7FFDDBAEF959h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddq xmm0,xmm0,xmm1         ; VPADDQ(VEX_Vpaddq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 d4 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xD4,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<float> vadd_g128x32f(Vector128<float> lhs, Vector128<float> rhs)
; location: [7FFDDBAEF970h, 7FFDDBAEF994h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
0010h vmovapd [rsp],xmm1            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 5 bytes) = c5 f9 29 0c 24
0015h vaddps xmm0,xmm0,xmm0         ; VADDPS(VEX_Vaddps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 58 c0
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x32fBytes => new byte[37]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x29,0x0C,0x24,0xC5,0xF8,0x58,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<double> vadd_g128x64f(Vector128<double> lhs, Vector128<double> rhs)
; location: [7FFDDBAEFDC0h, 7FFDDBAEFDD9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vaddpd xmm0,xmm0,xmm1         ; VADDPD(VEX_Vaddpd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 58 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x64fBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x58,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_LLLLLLLL(Vector128<short> x, Vector128<short> y)
; location: [7FFDDBAEFDF0h, 7FFDDBAEFE0Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0     ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 00
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_LLLLLLLLBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_RRRRRRRR(Vector128<short> x, Vector128<short> y)
; location: [7FFDDBAEFE20h, 7FFDDBAEFE3Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0FFh  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,ffh:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 ff
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_RRRRRRRRBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0xFF,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_LLLLRRRR(Vector128<short> x, Vector128<short> y)
; location: [7FFDDBAEFE50h, 7FFDDBAEFE6Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0F0h  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,f0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 f0
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_LLLLRRRRBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0xF0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_RRRRLLLL(Vector128<short> x, Vector128<short> y)
; location: [7FFDDBAEFE80h, 7FFDDBAEFE9Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0Fh   ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,fh:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 0f
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_RRRRLLLLBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0x0F,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_LRLRLRLR(Vector128<short> x, Vector128<short> y)
; location: [7FFDDBAEFEB0h, 7FFDDBAEFECBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0AAh  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,aah:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 aa
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_LRLRLRLRBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0xAA,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_RLRLRLRL(Vector128<short> x, Vector128<short> y)
; location: [7FFDDBAEFEE0h, 7FFDDBAEFEFBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,55h   ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,55h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 55
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_RLRLRLRLBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0x55,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<short> vconvert_128x8i_to_128x16i(Vector128<sbyte> src, out Vector128<short> dst)
; location: [7FFDDBAEFF10h, 7FFDDBAEFF25h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxbw xmm0,xmm0           ; VPMOVSXBW(VEX_Vpmovsxbw_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 20 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8i_to_128x16iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x20,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<int> vconvert_128x8i_to_128x32i(Vector128<sbyte> src, out Vector128<int> dst)
; location: [7FFDDBAEFF40h, 7FFDDBAEFF55h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxbd xmm0,xmm0           ; VPMOVSXBD(VEX_Vpmovsxbd_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 21 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8i_to_128x32iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x21,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<long> vconvert_128x8i_to_128x64i(Vector128<sbyte> src, out Vector128<long> dst)
; location: [7FFDDBAEFF70h, 7FFDDBAEFF85h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxbq xmm0,xmm0           ; VPMOVSXBQ(VEX_Vpmovsxbq_xmm_xmmm16) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 22 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8i_to_128x64iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x22,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<short> vconvert_128x8u_to_128x16i(Vector128<byte> src, out Vector128<short> dst)
; location: [7FFDDBAEFFA0h, 7FFDDBAEFFB5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbw xmm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 30 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_128x16iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x30,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<ushort> vconvert_128x8u_to_128x16u(Vector128<byte> src, out Vector128<ushort> dst)
; location: [7FFDDBAEFFD0h, 7FFDDBAEFFE5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbw xmm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 30 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_128x16uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x30,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<int> vconvert_128x8u_to_128x32i(Vector128<byte> src, out Vector128<int> dst)
; location: [7FFDDBAF0000h, 7FFDDBAF0015h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbd xmm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 31 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_128x32iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x31,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<uint> vconvert_128x8u_to_128x32u(Vector128<byte> src, out Vector128<uint> dst)
; location: [7FFDDBAF0030h, 7FFDDBAF0045h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbd xmm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 31 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_128x32uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x31,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<long> vconvert_128x8u_to_128x64i(Vector128<byte> src, out Vector128<long> dst)
; location: [7FFDDBAF0060h, 7FFDDBAF0075h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbq xmm0,xmm0           ; VPMOVZXBQ(VEX_Vpmovzxbq_xmm_xmmm16) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 32 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_128x64iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x32,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<ulong> vconvert_128x8u_to_128x64u(Vector128<byte> src, out Vector128<ulong> dst)
; location: [7FFDDBAF0090h, 7FFDDBAF00A5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbq xmm0,xmm0           ; VPMOVZXBQ(VEX_Vpmovzxbq_xmm_xmmm16) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 32 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_128x64uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x32,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<int> vconvert_128x16i_to_128x32i(Vector128<short> src, out Vector128<int> dst)
; location: [7FFDDBAF00C0h, 7FFDDBAF00D5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxwd xmm0,xmm0           ; VPMOVSXWD(VEX_Vpmovsxwd_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 23 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16i_to_128x32iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x23,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<long> vconvert_128x16i_to_128x64i(Vector128<short> src, out Vector128<long> dst)
; location: [7FFDDBAF00F0h, 7FFDDBAF0105h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxwq xmm0,xmm0           ; VPMOVSXWQ(VEX_Vpmovsxwq_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 24 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16i_to_128x64iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x24,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<int> vconvert_128x16u_to_128x32i(Vector128<ushort> src, out Vector128<int> dst)
; location: [7FFDDBAF0120h, 7FFDDBAF0135h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwd xmm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 33 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_128x32iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x33,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<uint> vconvert_128x16u_to_128x32u(Vector128<ushort> src, out Vector128<uint> dst)
; location: [7FFDDBAF0150h, 7FFDDBAF0165h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwd xmm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 33 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_128x32uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x33,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<long> vconvert_128x16u_to_128x64i(Vector128<ushort> src, out Vector128<long> dst)
; location: [7FFDDBAF0180h, 7FFDDBAF0195h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwq xmm0,xmm0           ; VPMOVZXWQ(VEX_Vpmovzxwq_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 34 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_128x64iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x34,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<ulong> vconvert_128x16u_to_128x64u(Vector128<ushort> src, out Vector128<ulong> dst)
; location: [7FFDDBAF01B0h, 7FFDDBAF01C5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwq xmm0,xmm0           ; VPMOVZXWQ(VEX_Vpmovzxwq_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 34 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_128x64uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x34,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<long> vconvert_128x32i_to_128x64i(Vector128<int> src, out Vector128<long> dst)
; location: [7FFDDBAF01E0h, 7FFDDBAF01F5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxdq xmm0,xmm0           ; VPMOVSXDQ(VEX_Vpmovsxdq_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 25 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x32i_to_128x64iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x25,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<long> vconvert_128x32u_to_128x64i(Vector128<uint> src, out Vector128<long> dst)
; location: [7FFDDBAF0210h, 7FFDDBAF0225h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxdq xmm0,xmm0           ; VPMOVZXDQ(VEX_Vpmovzxdq_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 35 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x32u_to_128x64iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x35,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<ulong> vconvert_128x32u_to_128x64u(Vector128<uint> src, out Vector128<ulong> dst)
; location: [7FFDDBAF0240h, 7FFDDBAF0255h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxdq xmm0,xmm0           ; VPMOVZXDQ(VEX_Vpmovzxdq_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 35 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x32u_to_128x64uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x35,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<short> vconvert_128x8i_to_256x16i(Vector128<sbyte> src, out Vector256<short> dst)
; location: [7FFDDBAF0270h, 7FFDDBAF0288h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxbw ymm0,xmm0           ; VPMOVSXBW(VEX_Vpmovsxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 20 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8i_to_256x16iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x20,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<int> vconvert_128x8i_to_256x32i(Vector128<sbyte> src, out Vector256<int> dst)
; location: [7FFDDBAF02A0h, 7FFDDBAF02B8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxbd ymm0,xmm0           ; VPMOVSXBD(VEX_Vpmovsxbd_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 21 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8i_to_256x32iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x21,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vconvert_128x8i_to_256x64i(Vector128<sbyte> src, out Vector256<long> dst)
; location: [7FFDDBAF02D0h, 7FFDDBAF02E8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxbq ymm0,xmm0           ; VPMOVSXBQ(VEX_Vpmovsxbq_ymm_xmmm32) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 22 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8i_to_256x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x22,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<short> vconvert_128x8u_to_256x16i(Vector128<byte> src, out Vector256<short> dst)
; location: [7FFDDBAF0300h, 7FFDDBAF0318h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_256x16iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x30,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<ushort> vconvert_128x8u_to_256x16u(Vector128<byte> src, out Vector256<ushort> dst)
; location: [7FFDDBAF0330h, 7FFDDBAF0348h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_256x16uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x30,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<int> vconvert_128x8u_to_256x32i(Vector128<byte> src, out Vector256<int> dst)
; location: [7FFDDBAF0360h, 7FFDDBAF0378h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbd ymm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 31 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_256x32iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x31,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<uint> vconvert_128x8u_to_256x32u(Vector128<byte> src, out Vector256<uint> dst)
; location: [7FFDDBAF0390h, 7FFDDBAF03A8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbd ymm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 31 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_256x32uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x31,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vconvert_128x8u_to_256x64i(Vector128<byte> src, out Vector256<long> dst)
; location: [7FFDDBAF03C0h, 7FFDDBAF03D8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbq ymm0,xmm0           ; VPMOVZXBQ(VEX_Vpmovzxbq_ymm_xmmm32) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 32 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_256x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x32,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<ulong> vconvert_128x8u_to_256x64u(Vector128<byte> src, out Vector256<ulong> dst)
; location: [7FFDDBAF03F0h, 7FFDDBAF0408h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbq ymm0,xmm0           ; VPMOVZXBQ(VEX_Vpmovzxbq_ymm_xmmm32) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 32 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_256x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x32,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<int> vconvert_128x16i_to_256x32i(Vector128<short> src, out Vector256<int> dst)
; location: [7FFDDBAF0420h, 7FFDDBAF0438h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxwd ymm0,xmm0           ; VPMOVSXWD(VEX_Vpmovsxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 23 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16i_to_256x32iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x23,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vconvert_128x16i_to_256x64i(Vector128<short> src, out Vector256<long> dst)
; location: [7FFDDBAF0450h, 7FFDDBAF0468h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxwq ymm0,xmm0           ; VPMOVSXWQ(VEX_Vpmovsxwq_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 24 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16i_to_256x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x24,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<int> vconvert_128x16u_to_256x32i(Vector128<ushort> src, out Vector256<int> dst)
; location: [7FFDDBAF0480h, 7FFDDBAF0498h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_256x32iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<uint> vconvert_128x16u_to_256x32u(Vector128<ushort> src, out Vector256<uint> dst)
; location: [7FFDDBAF04B0h, 7FFDDBAF04C8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_256x32uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vconvert_128x16u_to_256x64i(Vector128<ushort> src, out Vector256<long> dst)
; location: [7FFDDBAF04E0h, 7FFDDBAF04F8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwq ymm0,xmm0           ; VPMOVZXWQ(VEX_Vpmovzxwq_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 34 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_256x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x34,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<ulong> vconvert_128x16u_to_256x64u(Vector128<ushort> src, out Vector256<ulong> dst)
; location: [7FFDDBAF0510h, 7FFDDBAF0528h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwq ymm0,xmm0           ; VPMOVZXWQ(VEX_Vpmovzxwq_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 34 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_256x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x34,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vconvert_128x32i_to_256x64i(Vector128<int> src, out Vector256<long> dst)
; location: [7FFDDBAF0540h, 7FFDDBAF0558h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxdq ymm0,xmm0           ; VPMOVSXDQ(VEX_Vpmovsxdq_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 25 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x32i_to_256x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x25,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vconvert_128x32u_to_256x64i(Vector128<uint> src, out Vector256<long> dst)
; location: [7FFDDBAF0570h, 7FFDDBAF0588h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxdq ymm0,xmm0           ; VPMOVZXDQ(VEX_Vpmovzxdq_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 35 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x32u_to_256x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x35,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<ulong> vconvert_128x32u_to_256x64u(Vector128<uint> src, out Vector256<ulong> dst)
; location: [7FFDDBAF05A0h, 7FFDDBAF05B8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxdq ymm0,xmm0           ; VPMOVZXDQ(VEX_Vpmovzxdq_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 35 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x32u_to_256x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x35,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<int> spec)
; location: [7FFDDBAF05D0h, 7FFDDBAF05EDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpermd ymm0,ymm1,ymm0         ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]  encoding(VEX, 5 bytes) = c4 e2 75 36 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar8x32_256x32iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
; location: [7FFDDBAF0600h, 7FFDDBAF061Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpermd ymm0,ymm1,ymm0         ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]  encoding(VEX, 5 bytes) = c4 e2 75 36 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar8x32_256x32uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<float> vpermvar8x32_256x32f(Vector256<float> src, Vector256<int> spec)
; location: [7FFDDBAF0630h, 7FFDDBAF064Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpermps ymm0,ymm1,ymm0        ; VPERMPS(VEX_Vpermps_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 16 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar8x32_256x32fBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x16,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
; location: [7FFDDBAF0660h, 7FFDDBAF06B0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,1CFE055D8F3h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d8f3h:imm64]          encoding(10 bytes) = 48 b8 f3 d8 55 e0 cf 01 00 00
0018h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
001ch vpaddb ymm2,ymm1,ymm2         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM2,YMM1,YMM2]  encoding(VEX, 4 bytes) = c5 f5 fc d2
0020h vpshufb ymm2,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 d2
0025h vperm2i128 ymm0,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c0 03
002bh mov rax,1CFE055DA03h          ; MOV(Mov_r64_imm64) [RAX,1cfe055da03h:imm64]          encoding(10 bytes) = 48 b8 03 da 55 e0 cf 01 00 00
0035h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0039h vpaddb ymm1,ymm1,ymm3         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]  encoding(VEX, 4 bytes) = c5 f5 fc cb
003dh vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0042h vpor ymm0,ymm2,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]      encoding(VEX, 4 bytes) = c5 ed eb c0
0046h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
004ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar32x8_256x8uBytes => new byte[81]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0xF3,0xD8,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xF5,0xFC,0xD2,0xC4,0xE2,0x7D,0x00,0xD2,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0x03,0xDA,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xF5,0xFC,0xCB,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xED,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
; location: [7FFDDBAF06D0h, 7FFDDBAF06EAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpshufb xmm0,xmm0,xmm1        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_128x8uBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
; location: [7FFDDBAF0700h, 7FFDDBAF071Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpshufb xmm0,xmm0,xmm1        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_128x8iBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
; location: [7FFDDBAF0730h, 7FFDDBAF074Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_256x8uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
; location: [7FFDDBAF0760h, 7FFDDBAF077Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_256x8iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> rotl_g128x8u(Vector128<byte> src, byte offset)
; location: [7FFDDBAF0790h, 7FFDDBAF08C6h]
0000h sub rsp,98h                   ; SUB(Sub_rm64_imm32) [RSP,98h:imm64]                  encoding(7 bytes) = 48 81 ec 98 00 00 00
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000eh vmovaps xmm1,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 c8
0012h vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
0017h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
001bh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
001fh vpsllw ymm0,ymm0,xmm2         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd f1 c2
0023h mov rax,1CFE055D923h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d923h:imm64]          encoding(10 bytes) = 48 b8 23 d9 55 e0 cf 01 00 00
002dh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
0031h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0035h vmovupd [rsp+60h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 60
003bh vpshufb ymm0,ymm0,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3] encoding(VEX, 5 bytes) = c4 e2 7d 00 c3
0040h mov rax,1CFE055D893h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d893h:imm64]          encoding(10 bytes) = 48 b8 93 d8 55 e0 cf 01 00 00
004ah vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
004eh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0052h vmovupd [rsp+40h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 40
0058h mov rax,1CFE055D8F3h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d8f3h:imm64]          encoding(10 bytes) = 48 b8 f3 d8 55 e0 cf 01 00 00
0062h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
0066h vpaddb ymm2,ymm3,ymm2         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM2,YMM3,YMM2]  encoding(VEX, 4 bytes) = c5 e5 fc d2
006ah vpshufb ymm2,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 d2
006fh vperm2i128 ymm0,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c0 03
0075h mov rax,1CFE055DA03h          ; MOV(Mov_r64_imm64) [RAX,1cfe055da03h:imm64]          encoding(10 bytes) = 48 b8 03 da 55 e0 cf 01 00 00
007fh vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
0083h vpaddb ymm3,ymm3,ymm4         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]  encoding(VEX, 4 bytes) = c5 e5 fc dc
0087h vpshufb ymm0,ymm0,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3] encoding(VEX, 5 bytes) = c4 e2 7d 00 c3
008ch vpor ymm0,ymm2,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]      encoding(VEX, 4 bytes) = c5 ed eb c0
0090h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
0096h vpmovzxbw ymm1,xmm1           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c9
009bh movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
009fh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
00a1h add eax,8                     ; ADD(Add_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 c0 08
00a4h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00a7h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
00abh vpsrlw ymm1,ymm1,xmm2         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 d1 ca
00afh mov rax,1CFE055D923h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d923h:imm64]          encoding(10 bytes) = 48 b8 23 d9 55 e0 cf 01 00 00
00b9h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
00bdh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
00c1h vmovupd [rsp+20h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 20
00c7h vpshufb ymm1,ymm1,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3] encoding(VEX, 5 bytes) = c4 e2 75 00 cb
00cch mov rax,1CFE055D893h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d893h:imm64]          encoding(10 bytes) = 48 b8 93 d8 55 e0 cf 01 00 00
00d6h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
00dah vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
00deh vmovupd [rsp],ymm2            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 5 bytes) = c5 fd 11 14 24
00e3h mov rax,1CFE055D8F3h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d8f3h:imm64]          encoding(10 bytes) = 48 b8 f3 d8 55 e0 cf 01 00 00
00edh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
00f1h vpaddb ymm2,ymm3,ymm2         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM2,YMM3,YMM2]  encoding(VEX, 4 bytes) = c5 e5 fc d2
00f5h vpshufb ymm2,ymm1,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM1,YMM2] encoding(VEX, 5 bytes) = c4 e2 75 00 d2
00fah vperm2i128 ymm1,ymm1,ymm1,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM1,YMM1,YMM1,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 46 c9 03
0100h mov rax,1CFE055DA03h          ; MOV(Mov_r64_imm64) [RAX,1cfe055da03h:imm64]          encoding(10 bytes) = 48 b8 03 da 55 e0 cf 01 00 00
010ah vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
010eh vpaddb ymm3,ymm3,ymm4         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]  encoding(VEX, 4 bytes) = c5 e5 fc dc
0112h vpshufb ymm1,ymm1,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3] encoding(VEX, 5 bytes) = c4 e2 75 00 cb
0117h vpor ymm1,ymm2,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]      encoding(VEX, 4 bytes) = c5 ed eb c9
011bh vextractf128 xmm1,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 00
0121h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0125h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0129h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
012ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
012fh add rsp,98h                   ; ADD(Add_rm64_imm32) [RSP,98h:imm64]                  encoding(7 bytes) = 48 81 c4 98 00 00 00
0136h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x8uBytes => new byte[311]{0x48,0x81,0xEC,0x98,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC5,0xF8,0x28,0xC8,0xC4,0xE2,0x7D,0x30,0xC0,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xF1,0xC2,0x48,0xB8,0x23,0xD9,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xFC,0x28,0xDA,0xC5,0xFD,0x11,0x54,0x24,0x60,0xC4,0xE2,0x7D,0x00,0xC3,0x48,0xB8,0x93,0xD8,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xFC,0x28,0xDA,0xC5,0xFD,0x11,0x54,0x24,0x40,0x48,0xB8,0xF3,0xD8,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xE5,0xFC,0xD2,0xC4,0xE2,0x7D,0x00,0xD2,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0x03,0xDA,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xE5,0xFC,0xDC,0xC4,0xE2,0x7D,0x00,0xC3,0xC5,0xED,0xEB,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC4,0xE2,0x7D,0x30,0xC9,0x41,0x0F,0xB6,0xC0,0xF7,0xD8,0x83,0xC0,0x08,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF5,0xD1,0xCA,0x48,0xB8,0x23,0xD9,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xFC,0x28,0xDA,0xC5,0xFD,0x11,0x54,0x24,0x20,0xC4,0xE2,0x75,0x00,0xCB,0x48,0xB8,0x93,0xD8,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xFC,0x28,0xDA,0xC5,0xFD,0x11,0x14,0x24,0x48,0xB8,0xF3,0xD8,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xE5,0xFC,0xD2,0xC4,0xE2,0x75,0x00,0xD2,0xC4,0xE3,0x75,0x46,0xC9,0x03,0x48,0xB8,0x03,0xDA,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xE5,0xFC,0xDC,0xC4,0xE2,0x75,0x00,0xCB,0xC5,0xED,0xEB,0xC9,0xC4,0xE3,0x7D,0x19,0xC9,0x00,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x98,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> rotl_g128x16u(Vector128<ushort> src, byte offset)
; location: [7FFDDBAF0900h, 7FFDDBAF0930h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllw xmm1,xmm0,xmm1         ; VPSLLW(VEX_Vpsllw_xmm_xmm_xmmm128) [XMM1,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f1 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,10h                   ; ADD(Add_rm32_imm8) [EAX,10h:imm32]                   encoding(3 bytes) = 83 c0 10
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlw xmm0,xmm0,xmm2         ; VPSRLW(VEX_Vpsrlw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d1 c2
0025h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0029h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x16uBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF1,0xC9,0xF7,0xD8,0x83,0xC0,0x10,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD1,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> rotl_g128x32u(Vector128<uint> src, byte offset)
; location: [7FFDDBAF0950h, 7FFDDBAF0980h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpslld xmm1,xmm0,xmm1         ; VPSLLD(VEX_Vpslld_xmm_xmm_xmmm128) [XMM1,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f2 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,20h                   ; ADD(Add_rm32_imm8) [EAX,20h:imm32]                   encoding(3 bytes) = 83 c0 20
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrld xmm0,xmm0,xmm2         ; VPSRLD(VEX_Vpsrld_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d2 c2
0025h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0029h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x32uBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF2,0xC9,0xF7,0xD8,0x83,0xC0,0x20,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD2,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> rotl_g128x64u(Vector128<ulong> src, byte offset)
; location: [7FFDDBAF09A0h, 7FFDDBAF09D0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllq xmm1,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM1,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,40h                   ; ADD(Add_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 c0 40
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlq xmm0,xmm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d3 c2
0025h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0029h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x64uBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC9,0xF7,0xD8,0x83,0xC0,0x40,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD3,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> rotl_g256x8u(Vector256<byte> src, byte offset)
; location: [7FFDDBAF09F0h, 7FFDDBAF0C1Ch]
0000h sub rsp,98h                   ; SUB(Sub_rm64_imm32) [RSP,98h:imm64]                  encoding(7 bytes) = 48 81 ec 98 00 00 00
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah vmovaps [rsp+80h],xmm6        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 80 00 00 00
0013h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0017h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
001bh vextractf128 xmm2,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 00
0021h vpmovzxbw ymm2,xmm2           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 30 d2
0026h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
002ch vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
0031h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0035h vmovd xmm3,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM3,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d8
0039h vpsllw ymm2,ymm2,xmm3         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM2,YMM2,XMM3]  encoding(VEX, 4 bytes) = c5 ed f1 d3
003dh movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0041h vmovd xmm3,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM3,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d8
0045h vpsllw ymm0,ymm0,xmm3         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM0,YMM0,XMM3]  encoding(VEX, 4 bytes) = c5 fd f1 c3
0049h mov rax,1CFE055D923h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d923h:imm64]          encoding(10 bytes) = 48 b8 23 d9 55 e0 cf 01 00 00
0053h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0057h vmovaps ymm4,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 e3
005bh vmovupd [rsp+60h],ymm3        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM3] encoding(VEX, 6 bytes) = c5 fd 11 5c 24 60
0061h vpshufb ymm2,ymm2,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM4] encoding(VEX, 5 bytes) = c4 e2 6d 00 d4
0066h vpshufb ymm0,ymm0,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM4] encoding(VEX, 5 bytes) = c4 e2 7d 00 c4
006bh mov rax,1CFE055D893h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d893h:imm64]          encoding(10 bytes) = 48 b8 93 d8 55 e0 cf 01 00 00
0075h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0079h vmovaps ymm4,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 e3
007dh vmovupd [rsp+40h],ymm3        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM3] encoding(VEX, 6 bytes) = c5 fd 11 5c 24 40
0083h vmovaps ymm3,ymm4             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM4]         encoding(VEX, 4 bytes) = c5 fc 28 dc
0087h mov rax,1CFE055D8F3h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d8f3h:imm64]          encoding(10 bytes) = 48 b8 f3 d8 55 e0 cf 01 00 00
0091h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
0095h vpaddb ymm5,ymm3,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM3,YMM5]  encoding(VEX, 4 bytes) = c5 e5 fc ed
0099h vpshufb ymm5,ymm2,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM2,YMM5] encoding(VEX, 5 bytes) = c4 e2 6d 00 ed
009eh vperm2i128 ymm2,ymm2,ymm2,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM2,YMM2,YMM2,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 46 d2 03
00a4h mov rax,1CFE055DA03h          ; MOV(Mov_r64_imm64) [RAX,1cfe055da03h:imm64]          encoding(10 bytes) = 48 b8 03 da 55 e0 cf 01 00 00
00aeh vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
00b2h vpaddb ymm3,ymm3,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM6]  encoding(VEX, 4 bytes) = c5 e5 fc de
00b6h vpshufb ymm2,ymm2,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 00 d3
00bbh vpor ymm2,ymm5,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM2,YMM5,YMM2]      encoding(VEX, 4 bytes) = c5 d5 eb d2
00bfh mov rax,1CFE055D8F3h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d8f3h:imm64]          encoding(10 bytes) = 48 b8 f3 d8 55 e0 cf 01 00 00
00c9h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
00cdh vpaddb ymm3,ymm4,ymm3         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM4,YMM3]  encoding(VEX, 4 bytes) = c5 dd fc db
00d1h vpshufb ymm3,ymm0,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM0,YMM3] encoding(VEX, 5 bytes) = c4 e2 7d 00 db
00d6h vperm2i128 ymm0,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c0 03
00dch mov rax,1CFE055DA03h          ; MOV(Mov_r64_imm64) [RAX,1cfe055da03h:imm64]          encoding(10 bytes) = 48 b8 03 da 55 e0 cf 01 00 00
00e6h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00eah vpaddb ymm4,ymm4,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5]  encoding(VEX, 4 bytes) = c5 dd fc e5
00eeh vpshufb ymm0,ymm0,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM4] encoding(VEX, 5 bytes) = c4 e2 7d 00 c4
00f3h vpor ymm0,ymm3,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM3,YMM0]      encoding(VEX, 4 bytes) = c5 e5 eb c0
00f7h vextractf128 xmm2,ymm2,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d2 00
00fdh vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
0103h vxorps ymm3,ymm3,ymm3         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM3,YMM3,YMM3]  encoding(VEX, 4 bytes) = c5 e4 57 db
0107h vinserti128 ymm2,ymm3,xmm2,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM2,YMM3,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 38 d2 00
010dh vinserti128 ymm0,ymm2,xmm0,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 01
0113h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0117h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0119h add eax,8                     ; ADD(Add_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 c0 08
011ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
011fh vextractf128 xmm2,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 ca 00
0125h vpmovzxbw ymm2,xmm2           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 30 d2
012ah vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
0130h vpmovzxbw ymm1,xmm1           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c9
0135h vmovd xmm3,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM3,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d8
0139h vpsrlw ymm2,ymm2,xmm3         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM2,YMM2,XMM3]  encoding(VEX, 4 bytes) = c5 ed d1 d3
013dh vmovd xmm3,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM3,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d8
0141h vpsrlw ymm1,ymm1,xmm3         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM1,YMM1,XMM3]  encoding(VEX, 4 bytes) = c5 f5 d1 cb
0145h mov rax,1CFE055D923h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d923h:imm64]          encoding(10 bytes) = 48 b8 23 d9 55 e0 cf 01 00 00
014fh vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0153h vmovaps ymm4,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 e3
0157h vmovupd [rsp+20h],ymm3        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM3] encoding(VEX, 6 bytes) = c5 fd 11 5c 24 20
015dh vpshufb ymm2,ymm2,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM4] encoding(VEX, 5 bytes) = c4 e2 6d 00 d4
0162h vpshufb ymm1,ymm1,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM4] encoding(VEX, 5 bytes) = c4 e2 75 00 cc
0167h mov rax,1CFE055D893h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d893h:imm64]          encoding(10 bytes) = 48 b8 93 d8 55 e0 cf 01 00 00
0171h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0175h vmovaps ymm4,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 e3
0179h vmovupd [rsp],ymm3            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM3] encoding(VEX, 5 bytes) = c5 fd 11 1c 24
017eh vmovaps ymm3,ymm4             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM4]         encoding(VEX, 4 bytes) = c5 fc 28 dc
0182h mov rax,1CFE055D8F3h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d8f3h:imm64]          encoding(10 bytes) = 48 b8 f3 d8 55 e0 cf 01 00 00
018ch vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
0190h vpaddb ymm5,ymm3,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM3,YMM5]  encoding(VEX, 4 bytes) = c5 e5 fc ed
0194h vpshufb ymm5,ymm2,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM2,YMM5] encoding(VEX, 5 bytes) = c4 e2 6d 00 ed
0199h vperm2i128 ymm2,ymm2,ymm2,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM2,YMM2,YMM2,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 46 d2 03
019fh mov rax,1CFE055DA03h          ; MOV(Mov_r64_imm64) [RAX,1cfe055da03h:imm64]          encoding(10 bytes) = 48 b8 03 da 55 e0 cf 01 00 00
01a9h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
01adh vpaddb ymm3,ymm3,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM6]  encoding(VEX, 4 bytes) = c5 e5 fc de
01b1h vpshufb ymm2,ymm2,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 00 d3
01b6h vpor ymm2,ymm5,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM2,YMM5,YMM2]      encoding(VEX, 4 bytes) = c5 d5 eb d2
01bah mov rax,1CFE055D8F3h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d8f3h:imm64]          encoding(10 bytes) = 48 b8 f3 d8 55 e0 cf 01 00 00
01c4h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
01c8h vpaddb ymm3,ymm4,ymm3         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM4,YMM3]  encoding(VEX, 4 bytes) = c5 dd fc db
01cch vpshufb ymm3,ymm1,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM1,YMM3] encoding(VEX, 5 bytes) = c4 e2 75 00 db
01d1h vperm2i128 ymm1,ymm1,ymm1,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM1,YMM1,YMM1,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 46 c9 03
01d7h mov rax,1CFE055DA03h          ; MOV(Mov_r64_imm64) [RAX,1cfe055da03h:imm64]          encoding(10 bytes) = 48 b8 03 da 55 e0 cf 01 00 00
01e1h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
01e5h vpaddb ymm4,ymm4,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5]  encoding(VEX, 4 bytes) = c5 dd fc e5
01e9h vpshufb ymm1,ymm1,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM4] encoding(VEX, 5 bytes) = c4 e2 75 00 cc
01eeh vpor ymm1,ymm3,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM3,YMM1]      encoding(VEX, 4 bytes) = c5 e5 eb c9
01f2h vextractf128 xmm2,ymm2,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d2 00
01f8h vextractf128 xmm1,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 00
01feh vxorps ymm3,ymm3,ymm3         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM3,YMM3,YMM3]  encoding(VEX, 4 bytes) = c5 e4 57 db
0202h vinserti128 ymm2,ymm3,xmm2,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM2,YMM3,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 38 d2 00
0208h vinserti128 ymm1,ymm2,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM2,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c9 01
020eh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0212h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0216h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0219h vmovaps xmm6,[rsp+80h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 80 00 00 00
0222h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0225h add rsp,98h                   ; ADD(Add_rm64_imm32) [RSP,98h:imm64]                  encoding(7 bytes) = 48 81 c4 98 00 00 00
022ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x8uBytes => new byte[557]{0x48,0x81,0xEC,0x98,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0x80,0x00,0x00,0x00,0xC5,0xFD,0x10,0x02,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x30,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x30,0xC0,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD8,0xC5,0xED,0xF1,0xD3,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD8,0xC5,0xFD,0xF1,0xC3,0x48,0xB8,0x23,0xD9,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xFC,0x28,0xE3,0xC5,0xFD,0x11,0x5C,0x24,0x60,0xC4,0xE2,0x6D,0x00,0xD4,0xC4,0xE2,0x7D,0x00,0xC4,0x48,0xB8,0x93,0xD8,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xFC,0x28,0xE3,0xC5,0xFD,0x11,0x5C,0x24,0x40,0xC5,0xFC,0x28,0xDC,0x48,0xB8,0xF3,0xD8,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xE5,0xFC,0xED,0xC4,0xE2,0x6D,0x00,0xED,0xC4,0xE3,0x6D,0x46,0xD2,0x03,0x48,0xB8,0x03,0xDA,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xE5,0xFC,0xDE,0xC4,0xE2,0x6D,0x00,0xD3,0xC5,0xD5,0xEB,0xD2,0x48,0xB8,0xF3,0xD8,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xDD,0xFC,0xDB,0xC4,0xE2,0x7D,0x00,0xDB,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0x03,0xDA,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xDD,0xFC,0xE5,0xC4,0xE2,0x7D,0x00,0xC4,0xC5,0xE5,0xEB,0xC0,0xC4,0xE3,0x7D,0x19,0xD2,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xE4,0x57,0xDB,0xC4,0xE3,0x65,0x38,0xD2,0x00,0xC4,0xE3,0x6D,0x38,0xC0,0x01,0x41,0x0F,0xB6,0xC0,0xF7,0xD8,0x83,0xC0,0x08,0x0F,0xB6,0xC0,0xC4,0xE3,0x7D,0x19,0xCA,0x00,0xC4,0xE2,0x7D,0x30,0xD2,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x30,0xC9,0xC5,0xF9,0x6E,0xD8,0xC5,0xED,0xD1,0xD3,0xC5,0xF9,0x6E,0xD8,0xC5,0xF5,0xD1,0xCB,0x48,0xB8,0x23,0xD9,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xFC,0x28,0xE3,0xC5,0xFD,0x11,0x5C,0x24,0x20,0xC4,0xE2,0x6D,0x00,0xD4,0xC4,0xE2,0x75,0x00,0xCC,0x48,0xB8,0x93,0xD8,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xFC,0x28,0xE3,0xC5,0xFD,0x11,0x1C,0x24,0xC5,0xFC,0x28,0xDC,0x48,0xB8,0xF3,0xD8,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xE5,0xFC,0xED,0xC4,0xE2,0x6D,0x00,0xED,0xC4,0xE3,0x6D,0x46,0xD2,0x03,0x48,0xB8,0x03,0xDA,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xE5,0xFC,0xDE,0xC4,0xE2,0x6D,0x00,0xD3,0xC5,0xD5,0xEB,0xD2,0x48,0xB8,0xF3,0xD8,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xDD,0xFC,0xDB,0xC4,0xE2,0x75,0x00,0xDB,0xC4,0xE3,0x75,0x46,0xC9,0x03,0x48,0xB8,0x03,0xDA,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xDD,0xFC,0xE5,0xC4,0xE2,0x75,0x00,0xCC,0xC5,0xE5,0xEB,0xC9,0xC4,0xE3,0x7D,0x19,0xD2,0x00,0xC4,0xE3,0x7D,0x19,0xC9,0x00,0xC5,0xE4,0x57,0xDB,0xC4,0xE3,0x65,0x38,0xD2,0x00,0xC4,0xE3,0x6D,0x38,0xC9,0x01,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0xB4,0x24,0x80,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x98,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> rotl_g256x16u(Vector256<ushort> src, byte offset)
; location: [7FFDDBAF0C70h, 7FFDDBAF0CA3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllw ymm1,ymm0,xmm1         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM1,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f1 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,10h                   ; ADD(Add_rm32_imm8) [EAX,10h:imm32]                   encoding(3 bytes) = 83 c0 10
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlw ymm0,ymm0,xmm2         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d1 c2
0025h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0029h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x16uBytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF1,0xC9,0xF7,0xD8,0x83,0xC0,0x10,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD1,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> rotl_g256x32u(Vector256<uint> src, byte offset)
; location: [7FFDDBAF0CC0h, 7FFDDBAF0CF3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpslld ymm1,ymm0,xmm1         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f2 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,20h                   ; ADD(Add_rm32_imm8) [EAX,20h:imm32]                   encoding(3 bytes) = 83 c0 20
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrld ymm0,ymm0,xmm2         ; VPSRLD(VEX_Vpsrld_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d2 c2
0025h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0029h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x32uBytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF2,0xC9,0xF7,0xD8,0x83,0xC0,0x20,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD2,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> rotl_g256x64u(Vector256<ulong> src, byte offset)
; location: [7FFDDBAF0D10h, 7FFDDBAF0D43h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllq ymm1,ymm0,xmm1         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM1,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f3 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,40h                   ; ADD(Add_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 c0 40
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlq ymm0,ymm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d3 c2
0025h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0029h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x64uBytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF3,0xC9,0xF7,0xD8,0x83,0xC0,0x40,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD3,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<int> vcmplt_128x32i(Vector128<int> x, Vector128<int> y)
; location: [7FFDDBAF0D60h, 7FFDDBAF0D79h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x32iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<int> vcmplt_g128x32i(Vector128<int> x, Vector128<int> y)
; location: [7FFDDBAF11A0h, 7FFDDBAF11B9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x32iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vcmplt_128x32u(Vector128<uint> x, Vector128<uint> y)
; location: [7FFDDBAF11D0h, 7FFDDBAF1209h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],80000000h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),80000000h:imm32] encoding(8 bytes) = c7 44 24 04 00 00 00 80
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
0022h vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
0026h vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
002ah vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
002eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x32uBytes => new byte[58]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0x00,0x00,0x00,0x80,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xEF,0xCA,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vcmplt_g128x32u(Vector128<uint> x, Vector128<uint> y)
; location: [7FFDDBAF1230h, 7FFDDBAF1269h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],80000000h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),80000000h:imm32] encoding(8 bytes) = c7 44 24 04 00 00 00 80
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
0022h vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
0026h vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
002ah vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
002eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x32uBytes => new byte[58]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0x00,0x00,0x00,0x80,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xEF,0xCA,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<long> vcmplt_128x64i(Vector128<long> x, Vector128<long> y)
; location: [7FFDDBAF1290h, 7FFDDBAF12C7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0012h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0018h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
001ch vinserti128 ymm1,ymm2,xmm1,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM2,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c9 00
0022h vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0027h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
002dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0031h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0034h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x64iBytes => new byte[56]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC9,0x00,0xC4,0xE2,0x75,0x37,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<long> vcmplt_g128x64i(Vector128<long> x, Vector128<long> y)
; location: [7FFDDBAF12E0h, 7FFDDBAF1317h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0012h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0018h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
001ch vinserti128 ymm1,ymm2,xmm1,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM2,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c9 00
0022h vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0027h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
002dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0031h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0034h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x64iBytes => new byte[56]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC9,0x00,0xC4,0xE2,0x75,0x37,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vcmplt_128x64u(Vector128<ulong> x, Vector128<ulong> y)
; location: [7FFDDBAF1330h, 7FFDDBAF138Bh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0012h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0018h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
001ch vinserti128 ymm1,ymm2,xmm1,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM2,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c9 00
0022h mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
002ch mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0030h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
0034h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
003ah vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
003eh vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
0042h vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0047h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
004dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0051h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0054h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0057h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x64uBytes => new byte[92]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC9,0x00,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vcmplt_g128x64u(Vector128<ulong> x, Vector128<ulong> y)
; location: [7FFDDBAF13B0h, 7FFDDBAF140Bh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0012h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0018h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
001ch vinserti128 ymm1,ymm2,xmm1,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM2,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c9 00
0022h mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
002ch mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0030h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
0034h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
003ah vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
003eh vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
0042h vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0047h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
004dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0051h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0054h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0057h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x64uBytes => new byte[92]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC9,0x00,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vcmplt_256x8u(Vector256<byte> x, Vector256<byte> y)
; location: [7FFDDBAF1430h, 7FFDDBAF146Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],80h     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),80h:imm32] encoding(8 bytes) = c7 44 24 04 80 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastb ymm2,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM2,mem(8i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 54 24 04
0022h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0026h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002ah vpcmpgtb ymm0,ymm1,ymm0       ; VPCMPGTB(VEX_Vpcmpgtb_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 4 bytes) = c5 f5 64 c0
002eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0038h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_256x8uBytes => new byte[61]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0x80,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x78,0x54,0x24,0x04,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC5,0xF5,0x64,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vcmplt_g256x8u(Vector256<byte> x, Vector256<byte> y)
; location: [7FFDDBAF1490h, 7FFDDBAF14CCh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],80h     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),80h:imm32] encoding(8 bytes) = c7 44 24 04 80 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastb ymm2,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM2,mem(8i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 54 24 04
0022h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0026h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002ah vpcmpgtb ymm0,ymm1,ymm0       ; VPCMPGTB(VEX_Vpcmpgtb_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 4 bytes) = c5 f5 64 c0
002eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0038h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g256x8uBytes => new byte[61]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0x80,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x78,0x54,0x24,0x04,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC5,0xF5,0x64,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<long> vcmplt_256x64i(Vector256<long> x, Vector256<long> y)
; location: [7FFDDBAF14F0h, 7FFDDBAF150Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_256x64iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<long> vcmplt_g256x64i(Vector256<long> x, Vector256<long> y)
; location: [7FFDDBAF1520h, 7FFDDBAF153Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g256x64iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vcmplt_256x64u(Vector256<ulong> x, Vector256<ulong> y)
; location: [7FFDDBAF1550h, 7FFDDBAF1591h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
0018h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
001ch lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
0020h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
0026h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
002ah vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0033h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_256x64uBytes => new byte[66]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vcmplt_g256x64u(Vector256<ulong> x, Vector256<ulong> y)
; location: [7FFDDBAF15B0h, 7FFDDBAF15F1h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
0018h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
001ch lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
0020h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
0026h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
002ah vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0033h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g256x64uBytes => new byte[66]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
; location: [7FFDDBAF1610h, 7FFDDBAF1628h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x8iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
; location: [7FFDDBAF1640h, 7FFDDBAF1658h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x8iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
; location: [7FFDDBAF1670h, 7FFDDBAF1688h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x8uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
; location: [7FFDDBAF16A0h, 7FFDDBAF16B8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x8uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
; location: [7FFDDBAF16D0h, 7FFDDBAF16E8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x16iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
; location: [7FFDDBAF1700h, 7FFDDBAF1718h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x16iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
; location: [7FFDDBAF1730h, 7FFDDBAF1748h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x16uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
; location: [7FFDDBAF1760h, 7FFDDBAF1778h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x16uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
; location: [7FFDDBAF1790h, 7FFDDBAF17A8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x32iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
; location: [7FFDDBAF17C0h, 7FFDDBAF17D8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x32iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
; location: [7FFDDBAF17F0h, 7FFDDBAF1808h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x32uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
; location: [7FFDDBAF1820h, 7FFDDBAF1838h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x32uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
; location: [7FFDDBAF1850h, 7FFDDBAF1868h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
; location: [7FFDDBAF1880h, 7FFDDBAF1898h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
; location: [7FFDDBAF18B0h, 7FFDDBAF18C8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
; location: [7FFDDBAF18E0h, 7FFDDBAF18F8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
; location: [7FFDDBAF1910h, 7FFDDBAF192Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x8iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
; location: [7FFDDBAF1D50h, 7FFDDBAF1D6Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x8iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
; location: [7FFDDBAF1D80h, 7FFDDBAF1D9Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x8uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
; location: [7FFDDBAF1DB0h, 7FFDDBAF1DCBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x8uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
; location: [7FFDDBAF1DE0h, 7FFDDBAF1DFBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x16iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
; location: [7FFDDBAF1E10h, 7FFDDBAF1E2Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x16iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
; location: [7FFDDBAF1E40h, 7FFDDBAF1E5Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x16uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
; location: [7FFDDBAF1E70h, 7FFDDBAF1E8Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x16uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
; location: [7FFDDBAF1EA0h, 7FFDDBAF1EBBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x32iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
; location: [7FFDDBAF1ED0h, 7FFDDBAF1EEBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x32iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
; location: [7FFDDBAF1F00h, 7FFDDBAF1F1Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x32uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
; location: [7FFDDBAF1F30h, 7FFDDBAF1F4Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x32uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
; location: [7FFDDBAF1F60h, 7FFDDBAF1F7Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x64iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
; location: [7FFDDBAF1F90h, 7FFDDBAF1FABh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x64iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
; location: [7FFDDBAF1FC0h, 7FFDDBAF1FDBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x64uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
; location: [7FFDDBAF1FF0h, 7FFDDBAF200Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x64uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> ones_128x8u()
; location: [7FFDDBAF2020h, 7FFDDBAF2038h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vpcmpeqb xmm0,xmm0,xmm1       ; VPCMPEQB(VEX_Vpcmpeqb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 74 c1
0011h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_128x8uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x74,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> ones_128x64u()
; location: [7FFDDBAF2050h, 7FFDDBAF2069h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vpcmpeqq xmm0,xmm0,xmm1       ; VPCMPEQQ(VEX_Vpcmpeqq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 29 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC4,0xE2,0x79,0x29,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> ones_256x8u()
; location: [7FFDDBAF2080h, 7FFDDBAF209Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vpcmpeqb ymm0,ymm0,ymm1       ; VPCMPEQB(VEX_Vpcmpeqb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 74 c1
0011h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_256x8uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x74,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> ones_256x64u()
; location: [7FFDDBAF20B0h, 7FFDDBAF20CCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vpcmpeqq ymm0,ymm0,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 29 c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC4,0xE2,0x7D,0x29,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<double> ones_256x64f()
; location: [7FFDDBAF24F0h, 7FFDDBAF250Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vcmpeq_uqpd ymm0,ymm0,ymm1    ; VCMPPD(VEX_Vcmppd_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM1,8h:imm8] encoding(VEX, 5 bytes) = c5 fd c2 c1 08
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_256x64fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0xC2,0xC1,0x08,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> pattern_lanemerge_256x8u()
; location: [7FFDDBAF2530h, 7FFDDBAF255Ch]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,1CFE055D893h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d893h:imm64]          encoding(10 bytes) = 48 b8 93 d8 55 e0 cf 01 00 00
0011h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
0015h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0019h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
001eh vmovupd [rcx],ymm1            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM1] encoding(VEX, 4 bytes) = c5 fd 11 09
0022h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0025h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0028h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pattern_lanemerge_256x8uBytes => new byte[45]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x48,0xB8,0x93,0xD8,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x00,0xC5,0xFC,0x28,0xC8,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x11,0x09,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> pattern_lanemerge_256x16u()
; location: [7FFDDBAF2580h, 7FFDDBAF25ACh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,1CFE055D983h          ; MOV(Mov_r64_imm64) [RAX,1cfe055d983h:imm64]          encoding(10 bytes) = 48 b8 83 d9 55 e0 cf 01 00 00
0011h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
0015h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0019h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
001eh vmovupd [rcx],ymm1            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM1] encoding(VEX, 4 bytes) = c5 fd 11 09
0022h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0025h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0028h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pattern_lanemerge_256x16uBytes => new byte[45]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x48,0xB8,0x83,0xD9,0x55,0xE0,0xCF,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x00,0xC5,0xFC,0x28,0xC8,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x11,0x09,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
