; 2019-11-30 01:56:09:123
; function: bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
; location: [7FFDDAF28870h, 7FFDDAF28890h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x8uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
; location: [7FFDDAF29300h, 7FFDDAF29320h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x8uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
; location: [7FFDDAF29340h, 7FFDDAF29360h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x16iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
; location: [7FFDDAF29780h, 7FFDDAF297A0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x16iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
; location: [7FFDDAF297C0h, 7FFDDAF297E0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x16uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
; location: [7FFDDAF29800h, 7FFDDAF29820h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x16uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
; location: [7FFDDAF29840h, 7FFDDAF29860h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x32iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
; location: [7FFDDAF29880h, 7FFDDAF298A0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x32iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
; location: [7FFDDAF298C0h, 7FFDDAF298E0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x32uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
; location: [7FFDDAF29D00h, 7FFDDAF29D20h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x32uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
; location: [7FFDDAF29D40h, 7FFDDAF29D60h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x64iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
; location: [7FFDDAF29D80h, 7FFDDAF29DA0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x64iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
; location: [7FFDDAF29DC0h, 7FFDDAF29DE0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x64uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
; location: [7FFDDAF29E00h, 7FFDDAF29E20h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x64uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
; location: [7FFDDAF29E40h, 7FFDDAF29E63h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x8iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
; location: [7FFDDAF2A280h, 7FFDDAF2A2A3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x8iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
; location: [7FFDDAF2A2C0h, 7FFDDAF2A2E3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x8uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
; location: [7FFDDAF2A300h, 7FFDDAF2A323h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x8uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
; location: [7FFDDAF2A340h, 7FFDDAF2A363h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x16iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
; location: [7FFDDAF2A380h, 7FFDDAF2A3A3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x16iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
; location: [7FFDDAF2A3C0h, 7FFDDAF2A3E3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x16uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
; location: [7FFDDAF2A800h, 7FFDDAF2A823h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x16uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
; location: [7FFDDAF2A840h, 7FFDDAF2A863h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x32iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
; location: [7FFDDAF2A880h, 7FFDDAF2A8A3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x32iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
; location: [7FFDDAF2A8C0h, 7FFDDAF2A8E3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x32uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
; location: [7FFDDAF2A900h, 7FFDDAF2A923h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x32uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
; location: [7FFDDAF2A940h, 7FFDDAF2A963h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x64iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
; location: [7FFDDAF2AD80h, 7FFDDAF2ADA3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x64iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
; location: [7FFDDAF2ADC0h, 7FFDDAF2ADE3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x64uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
; location: [7FFDDAF2AE00h, 7FFDDAF2AE23h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x64uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt128 clmul(ulong x, ulong y)
; location: [7FFDDAF2B240h, 7FFDDAF2B28Eh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
000eh mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
0013h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
0018h vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
001dh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0023h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0028h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
002dh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0032h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0036h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 08
003bh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
003eh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 10
0043h mov [rcx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(4 bytes) = 48 89 41 08
0047h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004ah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
004eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clmulBytes => new byte[79]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x00,0x48,0x8B,0x44,0x24,0x08,0x48,0x89,0x01,0x48,0x8B,0x44,0x24,0x10,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref UInt128 clmul(ulong x, ulong y, ref UInt128 dst)
; location: [7FFDDAF2B2B0h, 7FFDDAF2B2CFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
000ah vmovq xmm1,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e ca
000fh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0015h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0018h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
001ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clmulBytes => new byte[32]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xE1,0xF9,0x6E,0xCA,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x49,0x8B,0xC0,0xC5,0xFA,0x7F,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong clmulr8u(ulong a, ulong b, ulong poly)
; location: [7FFDDAF2B2F0h, 7FFDDAF2B3C4h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000eh mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 30
0013h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
0018h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 30
001dh vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
0022h vmovq xmm1,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e ca
0027h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
002dh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 28
0032h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0036h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 28
003bh mov rdx,[rax]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 10
003eh mov rcx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 4c 24 28
0043h shr rcx,8                     ; SHR(Shr_rm64_imm8) [RCX,8h:imm8]                     encoding(4 bytes) = 48 c1 e9 08
0047h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
004ah mov [rsp+18h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R9]           encoding(5 bytes) = 4c 89 4c 24 18
004fh mov [rsp+20h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R9]           encoding(5 bytes) = 4c 89 4c 24 20
0054h vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
0059h vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
005eh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0064h mov [rsp+18h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R9]           encoding(5 bytes) = 4c 89 4c 24 18
0069h mov [rsp+20h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R9]           encoding(5 bytes) = 4c 89 4c 24 20
006eh lea rcx,[rsp+18h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 18
0073h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0077h mov rcx,[rsp+18h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 4c 24 18
007ch xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
007fh mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0082h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 28
0087h mov rdx,[rax]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 10
008ah mov rcx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 4c 24 28
008fh shr rcx,8                     ; SHR(Shr_rm64_imm8) [RCX,8h:imm8]                     encoding(4 bytes) = 48 c1 e9 08
0093h mov [rsp+8],r9                ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R9]           encoding(5 bytes) = 4c 89 4c 24 08
0098h mov [rsp+10h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R9]           encoding(5 bytes) = 4c 89 4c 24 10
009dh vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
00a2h vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
00a7h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
00adh mov [rsp+8],r9                ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R9]           encoding(5 bytes) = 4c 89 4c 24 08
00b2h mov [rsp+10h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R9]           encoding(5 bytes) = 4c 89 4c 24 10
00b7h lea rcx,[rsp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 08
00bch vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
00c0h mov rcx,[rsp+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 4c 24 08
00c5h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
00c8h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
00cbh mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
00d0h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00d4h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clmulr8uBytes => new byte[213]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xE1,0xF9,0x6E,0xCA,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x00,0x48,0x8D,0x44,0x24,0x28,0x48,0x8B,0x10,0x48,0x8B,0x4C,0x24,0x28,0x48,0xC1,0xE9,0x08,0x45,0x33,0xC9,0x4C,0x89,0x4C,0x24,0x18,0x4C,0x89,0x4C,0x24,0x20,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x4C,0x89,0x4C,0x24,0x18,0x4C,0x89,0x4C,0x24,0x20,0x48,0x8D,0x4C,0x24,0x18,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0x4C,0x24,0x18,0x48,0x33,0xD1,0x48,0x89,0x10,0x48,0x8D,0x44,0x24,0x28,0x48,0x8B,0x10,0x48,0x8B,0x4C,0x24,0x28,0x48,0xC1,0xE9,0x08,0x4C,0x89,0x4C,0x24,0x08,0x4C,0x89,0x4C,0x24,0x10,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x4C,0x89,0x4C,0x24,0x08,0x4C,0x89,0x4C,0x24,0x10,0x48,0x8D,0x4C,0x24,0x08,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0x4C,0x24,0x08,0x48,0x33,0xD1,0x48,0x89,0x10,0x48,0x8B,0x44,0x24,0x28,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<sbyte> vadd_d128x8i(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
; location: [7FFDDAF2B3E0h, 7FFDDAF2B3F9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_d128x8iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<sbyte> vadd_g128x8i(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
; location: [7FFDDAF2B410h, 7FFDDAF2B429h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x8iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vadd_g128x8u(Vector128<byte> lhs, Vector128<byte> rhs)
; location: [7FFDDAF2B850h, 7FFDDAF2B869h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x8uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vadd_g128x16i(Vector128<short> lhs, Vector128<short> rhs)
; location: [7FFDDAF2B880h, 7FFDDAF2B899h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddw xmm0,xmm0,xmm1         ; VPADDW(VEX_Vpaddw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fd c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x16iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFD,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vadd_g128x16u(Vector128<ushort> lhs, Vector128<ushort> rhs)
; location: [7FFDDAF2B8B0h, 7FFDDAF2B8C9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddw xmm0,xmm0,xmm1         ; VPADDW(VEX_Vpaddw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fd c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x16uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFD,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<int> vadd_g128x32i(Vector128<int> lhs, Vector128<int> rhs)
; location: [7FFDDAF2B8E0h, 7FFDDAF2B8F9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddd xmm0,xmm0,xmm1         ; VPADDD(VEX_Vpaddd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fe c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x32iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFE,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vadd_g128x32u(Vector128<uint> lhs, Vector128<uint> rhs)
; location: [7FFDDAF2BD20h, 7FFDDAF2BD39h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddd xmm0,xmm0,xmm1         ; VPADDD(VEX_Vpaddd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fe c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x32uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFE,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<long> vadd_g128x64i(Vector128<long> lhs, Vector128<long> rhs)
; location: [7FFDDAF2BD50h, 7FFDDAF2BD69h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddq xmm0,xmm0,xmm1         ; VPADDQ(VEX_Vpaddq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 d4 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x64iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xD4,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vadd_g128x64u(Vector128<ulong> lhs, Vector128<ulong> rhs)
; location: [7FFDDAF2BD80h, 7FFDDAF2BD99h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddq xmm0,xmm0,xmm1         ; VPADDQ(VEX_Vpaddq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 d4 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xD4,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<float> vadd_g128x32f(Vector128<float> lhs, Vector128<float> rhs)
; location: [7FFDDAF2C920h, 7FFDDAF2C944h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
0010h vmovapd [rsp],xmm1            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 f9 29 0c 24
0015h vaddps xmm0,xmm0,xmm0         ; VADDPS(VEX_Vaddps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 58 c0
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x32fBytes => new byte[37]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x29,0x0C,0x24,0xC5,0xF8,0x58,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<double> vadd_g128x64f(Vector128<double> lhs, Vector128<double> rhs)
; location: [7FFDDAF2C960h, 7FFDDAF2C979h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vaddpd xmm0,xmm0,xmm1         ; VADDPD(VEX_Vaddpd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 58 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x64fBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x58,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vreverse_128x64u(Vector128<ulong> x)
; location: [7FFDDAF2C990h, 7FFDDAF2C9D0h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000fh vmovq r8,xmm0                 ; VMOVQ(VEX_Vmovq_rm64_xmm) [R8,XMM0]                  encoding(VEX, 5 bytes) = c4 c1 f9 7e c0
0014h vpextrq rcx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RCX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c1 01
001ah vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
001fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0022h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
0028h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 20
002dh mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0033h call 7FFDDA900248h            ; CALL(Call_rel32_64) [FFFFFFFFFF9D38B8h:jmp64]        encoding(5 bytes) = e8 80 38 9d ff
0038h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
003bh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
003fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vreverse_128x64uBytes => new byte[65]{0x56,0x48,0x83,0xEC,0x30,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC1,0x01,0xC4,0xE1,0xF9,0x6E,0xC1,0x48,0x8B,0xCE,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x41,0xB9,0x01,0x00,0x00,0x00,0xE8,0x80,0x38,0x9D,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vreverse_128x8u(Vector128<byte> x)
; location: [7FFDDAF2D2B0h, 7FFDDAF2D2DFh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh mov rax,1CDAB0980A1h          ; MOV(Mov_r64_imm64) [RAX,1cdab0980a1h:imm64]          encoding(10 bytes) = 48 b8 a1 80 09 ab cd 01 00 00
0015h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0019h vpshufb xmm0,xmm0,xmm1        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
001eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0022h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0025h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
002ah call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F621AA0h:jmp64]                encoding(5 bytes) = e8 71 1a 62 5f
002fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> vreverse_128x8uBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0x48,0xB8,0xA1,0x80,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x71,0x1A,0x62,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vreverse_256x8u(Vector256<byte> x)
; location: [7FFDDAF2D300h, 7FFDDAF2D357h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000bh vextractf128 xmm1,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 01
0011h mov rax,1CDAB0980A1h          ; MOV(Mov_r64_imm64) [RAX,1cdab0980a1h:imm64]          encoding(10 bytes) = 48 b8 a1 80 09 ab cd 01 00 00
001bh vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
001fh vpshufb xmm1,xmm1,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 00 ca
0024h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
002ah vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
002eh vpshufb xmm0,xmm0,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2] encoding(VEX, 5 bytes) = c4 e2 79 00 c2
0033h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0037h vinserti128 ymm1,ymm2,xmm1,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM2,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c9 00
003dh vinserti128 ymm0,ymm1,xmm0,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM1,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 38 c0 01
0043h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0047h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
004dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0051h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0052h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F621A50h:jmp64]                encoding(5 bytes) = e8 f9 19 62 5f
0057h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> vreverse_256x8uBytes => new byte[88]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xFD,0x10,0x02,0xC4,0xE3,0x7D,0x19,0xC1,0x01,0x48,0xB8,0xA1,0x80,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x71,0x00,0xCA,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x79,0x00,0xC2,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC9,0x00,0xC4,0xE3,0x75,0x38,0xC0,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF9,0x19,0x62,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vrotlx_n8(Vector128<byte> x)
; location: [7FFDDAF2D380h, 7FFDDAF2D3A3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,1CDAB0982F1h          ; MOV(Mov_r64_imm64) [RAX,1cdab0982f1h:imm64]          encoding(10 bytes) = 48 b8 f1 82 09 ab cd 01 00 00
0013h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0017h vpshufb xmm0,xmm0,xmm1        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
001ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vrotlx_n8Bytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0xF1,0x82,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vrotlx_8(Vector128<ulong> x)
; location: [7FFDDAF2D3C0h, 7FFDDAF2D486h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,80h                   ; SUB(Sub_rm64_imm32) [RSP,80h:imm64]                  encoding(7 bytes) = 48 81 ec 80 00 00 00
0008h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000bh vmovaps [rsp+70h],xmm6        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 6 bytes) = c5 f8 29 74 24 70
0011h vmovaps [rsp+60h],xmm7        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 6 bytes) = c5 f8 29 7c 24 60
0017h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
001ah vmovupd xmm6,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM6,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 32
001eh vmovaps xmm7,xmm6             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,XMM6]         encoding(VEX, 4 bytes) = c5 f8 28 fe
0022h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0026h vmovapd [rsp+50h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 50
002ch vmovaps xmm0,xmm7             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM7]         encoding(VEX, 4 bytes) = c5 f8 28 c7
0030h lea rcx,[rsp+50h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 50
0035h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
003bh lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 20
0040h mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
0046h call 7FFDDA8E8B50h            ; CALL(Call_rel32_64) [FFFFFFFFFF9BB790h:jmp64]        encoding(5 bytes) = e8 45 b7 9b ff
004bh mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0050h vmovd xmm0,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e c1
0054h vpsllq xmm0,xmm7,xmm0         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM7,XMM0]  encoding(VEX, 4 bytes) = c5 c1 f3 c0
0058h vmovapd xmm1,[rsp+50h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f9 28 4c 24 50
005eh mov ecx,3Fh                   ; MOV(Mov_r32_imm32) [ECX,3fh:imm32]                   encoding(5 bytes) = b9 3f 00 00 00
0063h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0067h vpsrlq xmm1,xmm1,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f1 d3 ca
006bh vpor xmm7,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM7,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb f9
006fh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0073h vmovapd [rsp+40h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 40
0079h lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 30
007eh vmovapd [rsp+20h],xmm6        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM6] encoding(VEX, 6 bytes) = c5 f9 29 74 24 20
0084h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 20
0089h mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
008fh call 7FFDDA8E8C10h            ; CALL(Call_rel32_64) [FFFFFFFFFF9BB850h:jmp64]        encoding(5 bytes) = e8 bc b7 9b ff
0094h vmovapd xmm0,[rsp+30h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f9 28 44 24 30
009ah mov eax,3Fh                   ; MOV(Mov_r32_imm32) [EAX,3fh:imm32]                   encoding(5 bytes) = b8 3f 00 00 00
009fh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
00a3h vpsrlq xmm0,xmm0,xmm1         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 d3 c1
00a7h vpor xmm0,xmm7,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM7,XMM0]      encoding(VEX, 4 bytes) = c5 c1 eb c0
00abh vmovupd [rsi],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 06
00afh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00b2h vmovaps xmm6,[rsp+70h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f8 28 74 24 70
00b8h vmovaps xmm7,[rsp+60h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f8 28 7c 24 60
00beh add rsp,80h                   ; ADD(Add_rm64_imm32) [RSP,80h:imm64]                  encoding(7 bytes) = 48 81 c4 80 00 00 00
00c5h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00c6h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vrotlx_8Bytes => new byte[199]{0x56,0x48,0x81,0xEC,0x80,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0x74,0x24,0x70,0xC5,0xF8,0x29,0x7C,0x24,0x60,0x48,0x8B,0xF1,0xC5,0xF9,0x10,0x32,0xC5,0xF8,0x28,0xFE,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x50,0xC5,0xF8,0x28,0xC7,0x48,0x8D,0x4C,0x24,0x50,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x41,0xB8,0x08,0x00,0x00,0x00,0xE8,0x45,0xB7,0x9B,0xFF,0xB9,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC1,0xC5,0xC1,0xF3,0xC0,0xC5,0xF9,0x28,0x4C,0x24,0x50,0xB9,0x3F,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF1,0xD3,0xCA,0xC5,0xF9,0xEB,0xF9,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x40,0x48,0x8D,0x4C,0x24,0x30,0xC5,0xF9,0x29,0x74,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x41,0xB8,0x08,0x00,0x00,0x00,0xE8,0xBC,0xB7,0x9B,0xFF,0xC5,0xF9,0x28,0x44,0x24,0x30,0xB8,0x3F,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xD3,0xC1,0xC5,0xC1,0xEB,0xC0,0xC5,0xF9,0x11,0x06,0x48,0x8B,0xC6,0xC5,0xF8,0x28,0x74,0x24,0x70,0xC5,0xF8,0x28,0x7C,0x24,0x60,0x48,0x81,0xC4,0x80,0x00,0x00,0x00,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_LLLLLLLL(Vector128<short> x, Vector128<short> y)
; location: [7FFDDAF2D4C0h, 7FFDDAF2D4DBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0     ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 00
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_LLLLLLLLBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_RRRRRRRR(Vector128<short> x, Vector128<short> y)
; location: [7FFDDAF2D4F0h, 7FFDDAF2D50Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0FFh  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,ffh:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 ff
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_RRRRRRRRBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0xFF,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_LLLLRRRR(Vector128<short> x, Vector128<short> y)
; location: [7FFDDAF2D520h, 7FFDDAF2D53Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0F0h  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,f0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 f0
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_LLLLRRRRBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0xF0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_RRRRLLLL(Vector128<short> x, Vector128<short> y)
; location: [7FFDDAF2D550h, 7FFDDAF2D56Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0Fh   ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,fh:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 0f
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_RRRRLLLLBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0x0F,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_LRLRLRLR(Vector128<short> x, Vector128<short> y)
; location: [7FFDDAF2D580h, 7FFDDAF2D59Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0AAh  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,aah:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 aa
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_LRLRLRLRBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0xAA,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_RLRLRLRL(Vector128<short> x, Vector128<short> y)
; location: [7FFDDAF2D5B0h, 7FFDDAF2D5CBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,55h   ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,55h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 55
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_RLRLRLRLBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0x55,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void xor_block256(ConstBlock256<uint> xs, ConstBlock256<uint> ys, Block256<uint> zs)
; location: [7FFDDAFC0DA0h, 7FFDDAFC0E42h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+18h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 18
000eh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0013h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0017h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
001ah sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
001eh and r9d,7                     ; AND(And_rm32_imm8) [R9D,7h:imm32]                    encoding(4 bytes) = 41 83 e1 07
0022h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0025h sar eax,3                     ; SAR(Sar_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 f8 03
0028h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
002bh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
002dh jle short 009bh               ; JLE(Jle_rel8_64) [9Bh:jmp64]                         encoding(2 bytes) = 7e 6c
002fh vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0033h vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
0039h lea r10,[rsp+18h]             ; LEA(Lea_r64_m) [R10,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 4c 8d 54 24 18
003eh mov r10,[r10]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,R10:br,:sr)]          encoding(3 bytes) = 4d 8b 12
0041h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0044h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
0048h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
004bh lea r10,[r10+r11*4]           ; LEA(Lea_r64_m) [R10,mem(Unknown,R10:br,:sr)]         encoding(4 bytes) = 4f 8d 14 9a
004fh vlddqu ymm0,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 02
0054h vmovdqu xmm1,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM1,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 0a
0058h vmovdqu xmmword ptr [rsp+8],xmm1; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 7f 4c 24 08
005eh lea r10,[rsp+8]               ; LEA(Lea_r64_m) [R10,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 4c 8d 54 24 08
0063h mov r10,[r10]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,R10:br,:sr)]          encoding(3 bytes) = 4d 8b 12
0066h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0069h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
006dh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
0070h lea r10,[r10+r11*4]           ; LEA(Lea_r64_m) [R10,mem(Unknown,R10:br,:sr)]         encoding(4 bytes) = 4f 8d 14 9a
0074h vlddqu ymm1,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 0a
0079h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
007dh mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
0080h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0083h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
0087h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
008ah lea r10,[r10+r11*4]           ; LEA(Lea_r64_m) [R10,mem(Unknown,R10:br,:sr)]         encoding(4 bytes) = 4f 8d 14 9a
008eh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0093h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0096h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
0099h jl short 002fh                ; JL(Jl_rel8_64) [2Fh:jmp64]                           encoding(2 bytes) = 7c 94
009bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
009eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00a2h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_block256Bytes => new byte[163]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x18,0x48,0x89,0x44,0x24,0x08,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x07,0x41,0x03,0xC1,0xC1,0xF8,0x03,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x6C,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x44,0x24,0x18,0x4C,0x8D,0x54,0x24,0x18,0x4D,0x8B,0x12,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x03,0x4D,0x63,0xDB,0x4F,0x8D,0x14,0x9A,0xC4,0xC1,0x7F,0xF0,0x02,0xC5,0xFA,0x6F,0x0A,0xC5,0xFA,0x7F,0x4C,0x24,0x08,0x4C,0x8D,0x54,0x24,0x08,0x4D,0x8B,0x12,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x03,0x4D,0x63,0xDB,0x4F,0x8D,0x14,0x9A,0xC4,0xC1,0x7F,0xF0,0x0A,0xC5,0xFD,0xEF,0xC1,0x4D,0x8B,0x10,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x03,0x4D,0x63,0xDB,0x4F,0x8D,0x14,0x9A,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0x94,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<int> vcmplt_128x32i(Vector128<int> x, Vector128<int> y)
; location: [7FFDDAFC0E60h, 7FFDDAFC0E79h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x32iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<int> vcmplt_g128x32i(Vector128<int> x, Vector128<int> y)
; location: [7FFDDAFC0E90h, 7FFDDAFC0EA9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x32iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vcmplt_128x32u(Vector128<uint> x, Vector128<uint> y)
; location: [7FFDDAFC0EC0h, 7FFDDAFC0EF9h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],80000000h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),80000000h:imm32] encoding(8 bytes) = c7 44 24 04 00 00 00 80
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
0022h vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
0026h vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
002ah vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
002eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x32uBytes => new byte[58]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0x00,0x00,0x00,0x80,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xEF,0xCA,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vcmplt_g128x32u(Vector128<uint> x, Vector128<uint> y)
; location: [7FFDDAFC0F20h, 7FFDDAFC0F59h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],80000000h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),80000000h:imm32] encoding(8 bytes) = c7 44 24 04 00 00 00 80
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
0022h vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
0026h vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
002ah vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
002eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x32uBytes => new byte[58]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0x00,0x00,0x00,0x80,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xEF,0xCA,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<long> vcmplt_128x64i(Vector128<long> x, Vector128<long> y)
; location: [7FFDDAFC0F80h, 7FFDDAFC1058h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,0E0h                  ; SUB(Sub_rm64_imm32) [RSP,e0h:imm64]                  encoding(7 bytes) = 48 81 ec e0 00 00 00
0008h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000bh vmovaps [rsp+0D0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 d0 00 00 00
0014h vmovaps [rsp+0C0h],xmm7       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 c0 00 00 00
001dh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0020h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0024h vmovupd xmm6,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM6,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 30
0029h vxorps ymm7,ymm7,ymm7         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM7,YMM7,YMM7]  encoding(VEX, 4 bytes) = c5 c4 57 ff
002dh vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
0031h vmovupd [rsp+70h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 70
0037h lea rcx,[rsp+70h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 70
003ch vmovupd [rsp+30h],ymm7        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM7] encoding(VEX, 6 bytes) = c5 fd 11 7c 24 30
0042h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
0048h lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 30
004dh lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 44 24 20
0052h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0055h call 7FFDDA8EA6F0h            ; CALL(Call_rel32_64) [FFFFFFFFFF929770h:jmp64]        encoding(5 bytes) = e8 16 97 92 ff
005ah vmovupd ymm0,[rsp+70h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 70
0060h vmovupd [rsp+90h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 90 00 00 00
0069h vxorps ymm7,ymm7,ymm7         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM7,YMM7,YMM7]  encoding(VEX, 4 bytes) = c5 c4 57 ff
006dh vmovaps ymm1,ymm7             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM7]         encoding(VEX, 4 bytes) = c5 fc 28 cf
0071h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0075h vmovupd [rsp+50h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 50
007bh lea rcx,[rsp+50h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 50
0080h vmovupd [rsp+30h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 30
0086h vmovapd [rsp+20h],xmm6        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM6] encoding(VEX, 6 bytes) = c5 f9 29 74 24 20
008ch lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 30
0091h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 44 24 20
0096h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0099h call 7FFDDA8EA6F0h            ; CALL(Call_rel32_64) [FFFFFFFFFF929770h:jmp64]        encoding(5 bytes) = e8 d2 96 92 ff
009eh vmovupd ymm0,[rsp+50h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 50
00a4h vpcmpgtq ymm0,ymm0,[rsp+90h]  ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Int64,RSP:br,:sr)] encoding(VEX, 10 bytes) = c4 e2 7d 37 84 24 90 00 00 00
00aeh vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
00b4h vmovupd [rsi],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 06
00b8h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00bbh vmovaps xmm6,[rsp+0D0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 d0 00 00 00
00c4h vmovaps xmm7,[rsp+0C0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 c0 00 00 00
00cdh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00d0h add rsp,0E0h                  ; ADD(Add_rm64_imm32) [RSP,e0h:imm64]                  encoding(7 bytes) = 48 81 c4 e0 00 00 00
00d7h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00d8h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x64iBytes => new byte[217]{0x56,0x48,0x81,0xEC,0xE0,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0xD0,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0xC0,0x00,0x00,0x00,0x48,0x8B,0xF1,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x30,0xC5,0xC4,0x57,0xFF,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x4C,0x24,0x70,0x48,0x8D,0x4C,0x24,0x70,0xC5,0xFD,0x11,0x7C,0x24,0x30,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0x45,0x33,0xC9,0xE8,0x16,0x97,0x92,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x70,0xC5,0xFD,0x11,0x84,0x24,0x90,0x00,0x00,0x00,0xC5,0xC4,0x57,0xFF,0xC5,0xFC,0x28,0xCF,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x50,0x48,0x8D,0x4C,0x24,0x50,0xC5,0xFD,0x11,0x4C,0x24,0x30,0xC5,0xF9,0x29,0x74,0x24,0x20,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0x45,0x33,0xC9,0xE8,0xD2,0x96,0x92,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x50,0xC4,0xE2,0x7D,0x37,0x84,0x24,0x90,0x00,0x00,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x06,0x48,0x8B,0xC6,0xC5,0xF8,0x28,0xB4,0x24,0xD0,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0xC0,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xE0,0x00,0x00,0x00,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<long> vcmplt_g128x64i(Vector128<long> x, Vector128<long> y)
; location: [7FFDDAFC1090h, 7FFDDAFC1168h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,0E0h                  ; SUB(Sub_rm64_imm32) [RSP,e0h:imm64]                  encoding(7 bytes) = 48 81 ec e0 00 00 00
0008h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000bh vmovaps [rsp+0D0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 d0 00 00 00
0014h vmovaps [rsp+0C0h],xmm7       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 c0 00 00 00
001dh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0020h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0024h vmovupd xmm6,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM6,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 30
0029h vxorps ymm7,ymm7,ymm7         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM7,YMM7,YMM7]  encoding(VEX, 4 bytes) = c5 c4 57 ff
002dh vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
0031h vmovupd [rsp+70h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 70
0037h lea rcx,[rsp+70h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 70
003ch vmovupd [rsp+30h],ymm7        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM7] encoding(VEX, 6 bytes) = c5 fd 11 7c 24 30
0042h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
0048h lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 30
004dh lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 44 24 20
0052h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0055h call 7FFDDA8EA6F0h            ; CALL(Call_rel32_64) [FFFFFFFFFF929660h:jmp64]        encoding(5 bytes) = e8 06 96 92 ff
005ah vmovupd ymm0,[rsp+70h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 70
0060h vmovupd [rsp+90h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 90 00 00 00
0069h vxorps ymm7,ymm7,ymm7         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM7,YMM7,YMM7]  encoding(VEX, 4 bytes) = c5 c4 57 ff
006dh vmovaps ymm1,ymm7             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM7]         encoding(VEX, 4 bytes) = c5 fc 28 cf
0071h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0075h vmovupd [rsp+50h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 50
007bh lea rcx,[rsp+50h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 50
0080h vmovupd [rsp+30h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 30
0086h vmovapd [rsp+20h],xmm6        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM6] encoding(VEX, 6 bytes) = c5 f9 29 74 24 20
008ch lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 30
0091h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 44 24 20
0096h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0099h call 7FFDDA8EA6F0h            ; CALL(Call_rel32_64) [FFFFFFFFFF929660h:jmp64]        encoding(5 bytes) = e8 c2 95 92 ff
009eh vmovupd ymm0,[rsp+50h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 50
00a4h vpcmpgtq ymm0,ymm0,[rsp+90h]  ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Int64,RSP:br,:sr)] encoding(VEX, 10 bytes) = c4 e2 7d 37 84 24 90 00 00 00
00aeh vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
00b4h vmovupd [rsi],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 06
00b8h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00bbh vmovaps xmm6,[rsp+0D0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 d0 00 00 00
00c4h vmovaps xmm7,[rsp+0C0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 c0 00 00 00
00cdh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00d0h add rsp,0E0h                  ; ADD(Add_rm64_imm32) [RSP,e0h:imm64]                  encoding(7 bytes) = 48 81 c4 e0 00 00 00
00d7h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00d8h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x64iBytes => new byte[217]{0x56,0x48,0x81,0xEC,0xE0,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0xD0,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0xC0,0x00,0x00,0x00,0x48,0x8B,0xF1,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x30,0xC5,0xC4,0x57,0xFF,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x4C,0x24,0x70,0x48,0x8D,0x4C,0x24,0x70,0xC5,0xFD,0x11,0x7C,0x24,0x30,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0x45,0x33,0xC9,0xE8,0x06,0x96,0x92,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x70,0xC5,0xFD,0x11,0x84,0x24,0x90,0x00,0x00,0x00,0xC5,0xC4,0x57,0xFF,0xC5,0xFC,0x28,0xCF,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x50,0x48,0x8D,0x4C,0x24,0x50,0xC5,0xFD,0x11,0x4C,0x24,0x30,0xC5,0xF9,0x29,0x74,0x24,0x20,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0x45,0x33,0xC9,0xE8,0xC2,0x95,0x92,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x50,0xC4,0xE2,0x7D,0x37,0x84,0x24,0x90,0x00,0x00,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x06,0x48,0x8B,0xC6,0xC5,0xF8,0x28,0xB4,0x24,0xD0,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0xC0,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xE0,0x00,0x00,0x00,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vcmplt_128x64u(Vector128<ulong> x, Vector128<ulong> y)
; location: [7FFDDAFC15B0h, 7FFDDAFC16B8h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,100h                  ; SUB(Sub_rm64_imm32) [RSP,100h:imm64]                 encoding(7 bytes) = 48 81 ec 00 01 00 00
0008h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000bh vmovaps [rsp+0F0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 f0 00 00 00
0014h vmovaps [rsp+0E0h],xmm7       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 e0 00 00 00
001dh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0020h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0024h vmovupd xmm6,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM6,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 30
0029h vxorps ymm7,ymm7,ymm7         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM7,YMM7,YMM7]  encoding(VEX, 4 bytes) = c5 c4 57 ff
002dh vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
0031h vmovupd [rsp+90h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM1] encoding(VEX, 9 bytes) = c5 fd 11 8c 24 90 00 00 00
003ah lea rcx,[rsp+90h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 8c 24 90 00 00 00
0042h vmovupd [rsp+30h],ymm7        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM7] encoding(VEX, 6 bytes) = c5 fd 11 7c 24 30
0048h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
004eh lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 30
0053h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 44 24 20
0058h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
005bh call 7FFDDA8EA6F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF929148h:jmp64]        encoding(5 bytes) = e8 e8 90 92 ff
0060h vmovupd ymm0,[rsp+90h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 90 00 00 00
0069h vmovupd [rsp+0B0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 b0 00 00 00
0072h vxorps ymm7,ymm7,ymm7         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM7,YMM7,YMM7]  encoding(VEX, 4 bytes) = c5 c4 57 ff
0076h vmovaps ymm1,ymm7             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM7]         encoding(VEX, 4 bytes) = c5 fc 28 cf
007ah vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
007eh vmovupd [rsp+70h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 70
0084h lea rcx,[rsp+70h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 70
0089h vmovupd [rsp+30h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 30
008fh vmovapd [rsp+20h],xmm6        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM6] encoding(VEX, 6 bytes) = c5 f9 29 74 24 20
0095h lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 30
009ah lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 44 24 20
009fh xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
00a2h call 7FFDDA8EA6F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF929148h:jmp64]        encoding(5 bytes) = e8 a1 90 92 ff
00a7h vmovupd ymm0,[rsp+70h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 70
00adh mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
00b7h mov [rsp+68h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 68
00bch lea rax,[rsp+68h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 68
00c1h vpbroadcastq ymm1,qword ptr [rsp+68h]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 59 4c 24 68
00c8h vmovupd ymm2,[rsp+0B0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fd 10 94 24 b0 00 00 00
00d1h vpxor ymm2,ymm2,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed ef d1
00d5h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
00d9h vpcmpgtq ymm0,ymm0,ymm2       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 37 c2
00deh vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
00e4h vmovupd [rsi],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 06
00e8h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00ebh vmovaps xmm6,[rsp+0F0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 f0 00 00 00
00f4h vmovaps xmm7,[rsp+0E0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 e0 00 00 00
00fdh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0100h add rsp,100h                  ; ADD(Add_rm64_imm32) [RSP,100h:imm64]                 encoding(7 bytes) = 48 81 c4 00 01 00 00
0107h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0108h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x64uBytes => new byte[265]{0x56,0x48,0x81,0xEC,0x00,0x01,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0xF0,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0xE0,0x00,0x00,0x00,0x48,0x8B,0xF1,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x30,0xC5,0xC4,0x57,0xFF,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x8C,0x24,0x90,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0x90,0x00,0x00,0x00,0xC5,0xFD,0x11,0x7C,0x24,0x30,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0x45,0x33,0xC9,0xE8,0xE8,0x90,0x92,0xFF,0xC5,0xFD,0x10,0x84,0x24,0x90,0x00,0x00,0x00,0xC5,0xFD,0x11,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0xC4,0x57,0xFF,0xC5,0xFC,0x28,0xCF,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x70,0x48,0x8D,0x4C,0x24,0x70,0xC5,0xFD,0x11,0x4C,0x24,0x30,0xC5,0xF9,0x29,0x74,0x24,0x20,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0x45,0x33,0xC9,0xE8,0xA1,0x90,0x92,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x70,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x44,0x24,0x68,0x48,0x8D,0x44,0x24,0x68,0xC4,0xE2,0x7D,0x59,0x4C,0x24,0x68,0xC5,0xFD,0x10,0x94,0x24,0xB0,0x00,0x00,0x00,0xC5,0xED,0xEF,0xD1,0xC5,0xFD,0xEF,0xC1,0xC4,0xE2,0x7D,0x37,0xC2,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x06,0x48,0x8B,0xC6,0xC5,0xF8,0x28,0xB4,0x24,0xF0,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0xE0,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x00,0x01,0x00,0x00,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vcmplt_g128x64u(Vector128<ulong> x, Vector128<ulong> y)
; location: [7FFDDAFC16F0h, 7FFDDAFC17F8h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,100h                  ; SUB(Sub_rm64_imm32) [RSP,100h:imm64]                 encoding(7 bytes) = 48 81 ec 00 01 00 00
0008h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000bh vmovaps [rsp+0F0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 f0 00 00 00
0014h vmovaps [rsp+0E0h],xmm7       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 e0 00 00 00
001dh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0020h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0024h vmovupd xmm6,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM6,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 30
0029h vxorps ymm7,ymm7,ymm7         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM7,YMM7,YMM7]  encoding(VEX, 4 bytes) = c5 c4 57 ff
002dh vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
0031h vmovupd [rsp+90h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM1] encoding(VEX, 9 bytes) = c5 fd 11 8c 24 90 00 00 00
003ah lea rcx,[rsp+90h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 8c 24 90 00 00 00
0042h vmovupd [rsp+30h],ymm7        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM7] encoding(VEX, 6 bytes) = c5 fd 11 7c 24 30
0048h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
004eh lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 30
0053h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 44 24 20
0058h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
005bh call 7FFDDA8EA6F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF929008h:jmp64]        encoding(5 bytes) = e8 a8 8f 92 ff
0060h vmovupd ymm0,[rsp+90h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 90 00 00 00
0069h vmovupd [rsp+0B0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 b0 00 00 00
0072h vxorps ymm7,ymm7,ymm7         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM7,YMM7,YMM7]  encoding(VEX, 4 bytes) = c5 c4 57 ff
0076h vmovaps ymm1,ymm7             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM7]         encoding(VEX, 4 bytes) = c5 fc 28 cf
007ah vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
007eh vmovupd [rsp+70h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 70
0084h lea rcx,[rsp+70h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 70
0089h vmovupd [rsp+30h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 30
008fh vmovapd [rsp+20h],xmm6        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM6] encoding(VEX, 6 bytes) = c5 f9 29 74 24 20
0095h lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 30
009ah lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 44 24 20
009fh xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
00a2h call 7FFDDA8EA6F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF929008h:jmp64]        encoding(5 bytes) = e8 61 8f 92 ff
00a7h vmovupd ymm0,[rsp+70h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 70
00adh mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
00b7h mov [rsp+68h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 68
00bch lea rax,[rsp+68h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 68
00c1h vpbroadcastq ymm1,qword ptr [rsp+68h]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 59 4c 24 68
00c8h vmovupd ymm2,[rsp+0B0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fd 10 94 24 b0 00 00 00
00d1h vpxor ymm2,ymm2,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed ef d1
00d5h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
00d9h vpcmpgtq ymm0,ymm0,ymm2       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 37 c2
00deh vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
00e4h vmovupd [rsi],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 06
00e8h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00ebh vmovaps xmm6,[rsp+0F0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 f0 00 00 00
00f4h vmovaps xmm7,[rsp+0E0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 e0 00 00 00
00fdh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0100h add rsp,100h                  ; ADD(Add_rm64_imm32) [RSP,100h:imm64]                 encoding(7 bytes) = 48 81 c4 00 01 00 00
0107h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0108h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x64uBytes => new byte[265]{0x56,0x48,0x81,0xEC,0x00,0x01,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0xF0,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0xE0,0x00,0x00,0x00,0x48,0x8B,0xF1,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x30,0xC5,0xC4,0x57,0xFF,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x8C,0x24,0x90,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0x90,0x00,0x00,0x00,0xC5,0xFD,0x11,0x7C,0x24,0x30,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0x45,0x33,0xC9,0xE8,0xA8,0x8F,0x92,0xFF,0xC5,0xFD,0x10,0x84,0x24,0x90,0x00,0x00,0x00,0xC5,0xFD,0x11,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0xC4,0x57,0xFF,0xC5,0xFC,0x28,0xCF,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x70,0x48,0x8D,0x4C,0x24,0x70,0xC5,0xFD,0x11,0x4C,0x24,0x30,0xC5,0xF9,0x29,0x74,0x24,0x20,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0x45,0x33,0xC9,0xE8,0x61,0x8F,0x92,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x70,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x44,0x24,0x68,0x48,0x8D,0x44,0x24,0x68,0xC4,0xE2,0x7D,0x59,0x4C,0x24,0x68,0xC5,0xFD,0x10,0x94,0x24,0xB0,0x00,0x00,0x00,0xC5,0xED,0xEF,0xD1,0xC5,0xFD,0xEF,0xC1,0xC4,0xE2,0x7D,0x37,0xC2,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x06,0x48,0x8B,0xC6,0xC5,0xF8,0x28,0xB4,0x24,0xF0,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0xE0,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x00,0x01,0x00,0x00,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vcmplt_256x8u(Vector256<byte> x, Vector256<byte> y)
; location: [7FFDDAFC1830h, 7FFDDAFC186Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],80h     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),80h:imm32]  encoding(8 bytes) = c7 44 24 04 80 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastb ymm2,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM2,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 54 24 04
0022h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0026h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002ah vpcmpgtb ymm0,ymm1,ymm0       ; VPCMPGTB(VEX_Vpcmpgtb_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 4 bytes) = c5 f5 64 c0
002eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0038h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_256x8uBytes => new byte[61]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0x80,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x78,0x54,0x24,0x04,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC5,0xF5,0x64,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vcmplt_g256x8u(Vector256<byte> x, Vector256<byte> y)
; location: [7FFDDAFC1890h, 7FFDDAFC18CCh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],80h     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),80h:imm32]  encoding(8 bytes) = c7 44 24 04 80 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastb ymm2,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM2,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 54 24 04
0022h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0026h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002ah vpcmpgtb ymm0,ymm1,ymm0       ; VPCMPGTB(VEX_Vpcmpgtb_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 4 bytes) = c5 f5 64 c0
002eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0038h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g256x8uBytes => new byte[61]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0x80,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x78,0x54,0x24,0x04,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC5,0xF5,0x64,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<long> vcmplt_256x64i(Vector256<long> x, Vector256<long> y)
; location: [7FFDDAFC18F0h, 7FFDDAFC190Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_256x64iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<long> vcmplt_g256x64i(Vector256<long> x, Vector256<long> y)
; location: [7FFDDAFC1920h, 7FFDDAFC193Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g256x64iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vcmplt_256x64u(Vector256<ulong> x, Vector256<ulong> y)
; location: [7FFDDAFC1950h, 7FFDDAFC1991h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
0018h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
001ch lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0020h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
0026h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
002ah vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0033h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_256x64uBytes => new byte[66]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vcmplt_g256x64u(Vector256<ulong> x, Vector256<ulong> y)
; location: [7FFDDAFC19B0h, 7FFDDAFC19F1h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
0018h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
001ch lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0020h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
0026h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
002ah vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0033h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g256x64uBytes => new byte[66]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint item_get_128x32u_1(Vector128<uint> x)
; location: [7FFDDAFC1A10h, 7FFDDAFC1A1Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpextrd eax,xmm0,1            ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c0 01
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> item_get_128x32u_1Bytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE3,0x79,0x16,0xC0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint item_get_128x32u_2(Vector128<uint> x)
; location: [7FFDDAFC1A40h, 7FFDDAFC1A4Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpextrd eax,xmm0,2            ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EAX,XMM0,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c0 02
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> item_get_128x32u_2Bytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE3,0x79,0x16,0xC0,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> item_set_128x32u_2(Vector128<uint> x, uint value)
; location: [7FFDDAFC1A70h, 7FFDDAFC1A86h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpinsrd xmm0,xmm0,r8d,2       ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,R8D,2h:imm8] encoding(VEX, 6 bytes) = c4 c3 79 22 c0 02
000fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> item_set_128x32u_2Bytes => new byte[23]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC3,0x79,0x22,0xC0,0x02,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> avxpack1(NatSpan<N8,uint> src, int offset)
; location: [7FFDDAFC1EB0h, 7FFDDAFC1F0Fh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
000eh vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0012h vmovdqu xmmword ptr [rsp+8],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 08
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0020h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0023h vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
0027h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0029h lea r9d,[r8+rdx]              ; LEA(Lea_r32_m) [R9D,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 45 8d 0c 10
002dh movsxd r10,r9d                ; MOVSXD(Movsxd_r64_rm32) [R10,R9D]                    encoding(3 bytes) = 4d 63 d1
0030h lea r10,[rax+r10*4]           ; LEA(Lea_r64_m) [R10,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 4e 8d 14 90
0034h vlddqu ymm1,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 0a
0039h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
003dh vmovd xmm2,r9d                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,R9D]                 encoding(VEX, 5 bytes) = c4 c1 79 6e d1
0042h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
0046h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
004ah inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
004ch cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
004fh jl short 0029h                ; JL(Jl_rel8_64) [29h:jmp64]                           encoding(2 bytes) = 7c d8
0051h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0055h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0058h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005bh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avxpack1Bytes => new byte[96]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x08,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x48,0x8B,0x00,0x48,0x8B,0xD0,0xC5,0xFF,0xF0,0x02,0x33,0xD2,0x45,0x8D,0x0C,0x10,0x4D,0x63,0xD1,0x4E,0x8D,0x14,0x90,0xC4,0xC1,0x7F,0xF0,0x0A,0x45,0x0F,0xB6,0xC9,0xC4,0xC1,0x79,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xFF,0xC2,0x83,0xFA,0x08,0x7C,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sum_256x64u(Vector256<ulong> src)
; location: [7FFDDAFC1F30h, 7FFDDAFC1F69h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0016h vpextrq rdx,xmm1,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 ca 01
001ch add rdx,rax                   ; ADD(Add_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 03 d0
001fh vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0025h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
002ah vpextrq rcx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RCX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c1 01
0030h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0033h add rax,rcx                   ; ADD(Add_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 03 c1
0036h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sum_256x64uBytes => new byte[58]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0xF9,0x16,0xCA,0x01,0x48,0x03,0xD0,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC1,0x01,0x48,0x03,0xC2,0x48,0x03,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sum_256x64u(Vector128<ulong> src)
; location: [7FFDDAFC1F80h, 7FFDDAFC1F97h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
000eh vpextrq rdx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c2 01
0014h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sum_256x64uBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC2,0x01,0x48,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pop64_scalar(ulong a, ulong b, ulong c, ulong d)
; location: [7FFDDAFC23C0h, 7FFDDAFC23E8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0011h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0014h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0016h popcnt rdx,r8                 ; POPCNT(Popcnt_r64_rm64) [RDX,R8]                     encoding(5 bytes) = f3 49 0f b8 d0
001bh add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
001eh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0020h popcnt rdx,r9                 ; POPCNT(Popcnt_r64_rm64) [RDX,R9]                     encoding(5 bytes) = f3 49 0f b8 d1
0025h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop64_scalarBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x48,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD0,0x48,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD1,0x48,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pop64_vector(Vector256<ulong> x)
; location: [7FFDDAFC2400h, 7FFDDAFC2452h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0016h vpextrq rdx,xmm1,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 ca 01
001ch xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
001eh popcnt rcx,rax                ; POPCNT(Popcnt_r64_rm64) [RCX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c8
0023h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0026h popcnt r8,rdx                 ; POPCNT(Popcnt_r64_rm64) [R8,RDX]                     encoding(5 bytes) = f3 4c 0f b8 c2
002bh add rcx,r8                    ; ADD(Add_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 03 c8
002eh vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0034h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0039h vpextrq rdx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c2 01
003fh popcnt rax,rax                ; POPCNT(Popcnt_r64_rm64) [RAX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c0
0044h add rax,rcx                   ; ADD(Add_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 03 c1
0047h popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
004ch add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
004fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0052h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop64_vectorBytes => new byte[83]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0xF9,0x16,0xCA,0x01,0x33,0xC9,0xF3,0x48,0x0F,0xB8,0xC8,0x45,0x33,0xC0,0xF3,0x4C,0x0F,0xB8,0xC2,0x49,0x03,0xC8,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC2,0x01,0xF3,0x48,0x0F,0xB8,0xC0,0x48,0x03,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x48,0x03,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vcsa_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c, out Vector256<ulong> lo, out Vector256<ulong> hi)
; location: [7FFDDAFC2470h, 7FFDDAFC24B7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vmovupd ymm2,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 10
0012h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0016h vmovaps ymm4,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 e1
001ah vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
001eh vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0022h vmovaps ymm1,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 cb
0026h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
002ah vpand ymm1,ymm1,ymm4          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM4]    encoding(VEX, 4 bytes) = c5 f5 db cc
002eh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0032h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
0037h vmovupd [rax],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RAX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 00
003bh vpxor ymm0,ymm3,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM3,YMM2]    encoding(VEX, 4 bytes) = c5 e5 ef c2
003fh vmovupd [r9],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R9:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 01
0044h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0047h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcsa_256x64uBytes => new byte[72]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xC1,0x7D,0x10,0x10,0xC5,0xFC,0x28,0xD8,0xC5,0xFC,0x28,0xE1,0xC5,0xE5,0xEF,0xDC,0xC5,0xFD,0xDB,0xC1,0xC5,0xFC,0x28,0xCB,0xC5,0xFC,0x28,0xE2,0xC5,0xF5,0xDB,0xCC,0xC5,0xFD,0xEB,0xC1,0x48,0x8B,0x44,0x24,0x28,0xC5,0xFD,0x11,0x00,0xC5,0xE5,0xEF,0xC2,0xC4,0xC1,0x7D,0x11,0x01,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void csa_64u(ulong a, ulong b, ulong c, out ulong lo, out ulong hi)
; location: [7FFDDAFC24E0h, 7FFDDAFC2505h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0011h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0014h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0017h mov rcx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 4c 24 28
001ch mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(3 bytes) = 48 89 11
001fh xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0022h mov [r9],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RAX]           encoding(3 bytes) = 49 89 01
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> csa_64uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0x48,0x23,0xD1,0x48,0x8B,0xC8,0x49,0x23,0xC8,0x48,0x0B,0xD1,0x48,0x8B,0x4C,0x24,0x28,0x48,0x89,0x11,0x49,0x33,0xC0,0x49,0x89,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vtranspose(ref Vector128<uint> row0, ref Vector128<uint> row1, ref Vector128<uint> row2, ref Vector128<uint> row3)
; location: [7FFDDAFC2520h, 7FFDDAFC2581h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovaps xmm1,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 c8
000dh vmovupd xmm2,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 12
0011h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0015h vshufps xmm1,xmm1,xmm3,44h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM1,XMM3,44h:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 cb 44
001ah vshufps xmm0,xmm0,xmm2,0EEh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM2,eeh:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 c2 ee
001fh vmovupd xmm2,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 10
0024h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0028h vmovupd xmm4,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM4,mem(Packed128_Float64,R9:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 21
002dh vmovaps xmm5,xmm4             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM5,XMM4]         encoding(VEX, 4 bytes) = c5 f8 28 ec
0031h vshufps xmm3,xmm3,xmm5,44h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM3,XMM3,XMM5,44h:imm8] encoding(VEX, 5 bytes) = c5 e0 c6 dd 44
0036h vshufps xmm2,xmm2,xmm4,0EEh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM2,XMM2,XMM4,eeh:imm8] encoding(VEX, 5 bytes) = c5 e8 c6 d4 ee
003bh vshufps xmm4,xmm1,xmm3,88h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM4,XMM1,XMM3,88h:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 e3 88
0040h vmovupd [rcx],xmm4            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM4] encoding(VEX, 4 bytes) = c5 f9 11 21
0044h vshufps xmm1,xmm1,xmm3,0DDh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM1,XMM3,ddh:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 cb dd
0049h vmovupd [rdx],xmm1            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,:sr),XMM1] encoding(VEX, 4 bytes) = c5 f9 11 0a
004dh vshufps xmm1,xmm0,xmm2,88h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM0,XMM2,88h:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 ca 88
0052h vmovupd [r8],xmm1             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R8:br,:sr),XMM1] encoding(VEX, 5 bytes) = c4 c1 79 11 08
0057h vshufps xmm0,xmm0,xmm2,0DDh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM2,ddh:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 c2 dd
005ch vmovupd [r9],xmm0             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 79 11 01
0061h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtransposeBytes => new byte[98]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF8,0x28,0xC8,0xC5,0xF9,0x10,0x12,0xC5,0xF8,0x28,0xDA,0xC5,0xF0,0xC6,0xCB,0x44,0xC5,0xF8,0xC6,0xC2,0xEE,0xC4,0xC1,0x79,0x10,0x10,0xC5,0xF8,0x28,0xDA,0xC4,0xC1,0x79,0x10,0x21,0xC5,0xF8,0x28,0xEC,0xC5,0xE0,0xC6,0xDD,0x44,0xC5,0xE8,0xC6,0xD4,0xEE,0xC5,0xF0,0xC6,0xE3,0x88,0xC5,0xF9,0x11,0x21,0xC5,0xF0,0xC6,0xCB,0xDD,0xC5,0xF9,0x11,0x0A,0xC5,0xF8,0xC6,0xCA,0x88,0xC4,0xC1,0x79,0x11,0x08,0xC5,0xF8,0xC6,0xC2,0xDD,0xC4,0xC1,0x79,0x11,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vcell_0_256x64u(Vector256<ulong> src)
; location: [7FFDDAFC25B0h, 7FFDDAFC25C1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
000eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_0_256x64uBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vcell_1_256x64u(Vector256<ulong> src)
; location: [7FFDDAFC25E0h, 7FFDDAFC25F2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_1_256x64uBytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vcell_1_128x8u(Vector128<byte> src)
; location: [7FFDDAFC2610h, 7FFDDAFC2621h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpextrb eax,xmm0,1            ; VPEXTRB(VEX_Vpextrb_r32m8_xmm_imm8) [EAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 14 c0 01
000fh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_1_128x8uBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE3,0x79,0x14,0xC0,0x01,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vcell_2_256x64u(Vector256<ulong> src)
; location: [7FFDDAFC2640h, 7FFDDAFC2657h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0014h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_2_256x64uBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte vcell_3_256x64u(Vector256<byte> src)
; location: [7FFDDAFC2670h, 7FFDDAFC2682h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrb eax,xmm0,3            ; VPEXTRB(VEX_Vpextrb_r32m8_xmm_imm8) [EAX,XMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 14 c0 03
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_3_256x64uBytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x14,0xC0,0x03,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vcell_256x32u_1(Vector256<uint> src)
; location: [7FFDDAFC2AA0h, 7FFDDAFC2AB2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrd eax,xmm0,1            ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c0 01
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_256x32u_1Bytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x16,0xC0,0x01,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vcell_256x32u_2(Vector256<uint> src)
; location: [7FFDDAFC2AD0h, 7FFDDAFC2AE2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrd eax,xmm0,2            ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EAX,XMM0,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c0 02
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_256x32u_2Bytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x16,0xC0,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> swap_hl(Vector128<byte> src)
; location: [7FFDDAFC2B00h, 7FFDDAFC2B56h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000fh vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0013h vmovapd [rsp+30h],xmm1        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 29 4c 24 30
0019h vmovq r8,xmm0                 ; VMOVQ(VEX_Vmovq_rm64_xmm) [R8,XMM0]                  encoding(VEX, 5 bytes) = c4 c1 f9 7e c0
001eh vpextrq rcx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RCX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c1 01
0024h vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
0029h lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 30
002eh vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
0034h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 20
0039h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
003fh call 7FFDDA900248h            ; CALL(Call_rel32_64) [FFFFFFFFFF93D748h:jmp64]        encoding(5 bytes) = e8 04 d7 93 ff
0044h vmovapd xmm0,[rsp+30h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f9 28 44 24 30
004ah vmovupd [rsi],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 06
004eh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0051h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0055h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> swap_hlBytes => new byte[87]{0x56,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0xC5,0xF9,0x10,0x02,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x29,0x4C,0x24,0x30,0xC4,0xC1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC1,0x01,0xC4,0xE1,0xF9,0x6E,0xC1,0x48,0x8D,0x4C,0x24,0x30,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x41,0xB9,0x01,0x00,0x00,0x00,0xE8,0x04,0xD7,0x93,0xFF,0xC5,0xF9,0x28,0x44,0x24,0x30,0xC5,0xF9,0x11,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x40,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> hi_128x64u(Vector128<ulong> src)
; location: [7FFDDAFC2B80h, 7FFDDAFC2B9Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
000fh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hi_128x64uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC4,0xE1,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> hi_128x8u(Vector128<byte> src)
; location: [7FFDDAFC2BB0h, 7FFDDAFC2BCBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
000fh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hi_128x8uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC4,0xE1,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> lo_128x64u(Vector128<ulong> src)
; location: [7FFDDAFC2BE0h, 7FFDDAFC2BF4h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovq xmm0,xmm0               ; VMOVQ(VEX_Vmovq_xmm_xmmm64) [XMM0,XMM0]              encoding(VEX, 4 bytes) = c5 fa 7e c0
000dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lo_128x64uBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xFA,0x7E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> lo_128x8u(Vector128<byte> src)
; location: [7FFDDAFC2C10h, 7FFDDAFC2C24h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovq xmm0,xmm0               ; VMOVQ(VEX_Vmovq_xmm_xmmm64) [XMM0,XMM0]              encoding(VEX, 4 bytes) = c5 fa 7e c0
000dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lo_128x8uBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xFA,0x7E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vlo_256x8u_out(Vector256<byte> src, out ulong x0, out ulong x1)
; location: [7FFDDAFC2C40h, 7FFDDAFC2C61h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x8u_outBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> vlo_256x8u_pair(Vector256<byte> src, ref Pair<ulong> dst)
; location: [7FFDDAFC2C80h, 7FFDDAFC2CA5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [rdx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(4 bytes) = 48 89 42 08
001fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x8u_pairBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x42,0x08,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vlo_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
; location: [7FFDDAFC2CC0h, 7FFDDAFC2CE1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x64u_outBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> vlo_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
; location: [7FFDDAFC2D00h, 7FFDDAFC2D25h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [rdx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(4 bytes) = 48 89 42 08
001fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x64u_pairBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x42,0x08,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vhi_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
; location: [7FFDDAFC2D40h, 7FFDDAFC2D63h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0014h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0017h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001dh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vhi_256x64u_outBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> vhi_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
; location: [7FFDDAFC2D80h, 7FFDDAFC2DA7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0014h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0017h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001dh mov [rdx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(4 bytes) = 48 89 42 08
0021h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0024h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vhi_256x64u_pairBytes => new byte[40]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x42,0x08,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
; location: [7FFDDAFC2DC0h, 7FFDDAFC2DDAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpshufb xmm0,xmm0,xmm1        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_128x8uBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
; location: [7FFDDAFC2DF0h, 7FFDDAFC2E0Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpshufb xmm0,xmm0,xmm1        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_128x8iBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
; location: [7FFDDAFC2E20h, 7FFDDAFC2E3Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_256x8uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
; location: [7FFDDAFC2E50h, 7FFDDAFC2E6Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_256x8iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void gparts_xor_8u(int partcount, int partwidth, in byte a, in byte b, ref byte z)
; location: [7FFDDAFC3290h, 7FFDDAFC3308h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+80h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 80 00 00 00
0012h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0015h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0018h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ah jle short 006eh               ; JLE(Jle_rel8_64) [6Eh:jmp64]                         encoding(2 bytes) = 7e 52
001ch movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001fh lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 3c 30
0023h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 1c 31
0027h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002bh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0031h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0035h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
003ah vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
003eh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0044h vlddqu ymm0,ymmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RBX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 03
0048h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
004dh vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0053h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
0058h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
005ch add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
005fh vmovdqu ymmword ptr [rsi],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RSI:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 06
0063h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0066h add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
0069h cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
006ch jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c ae
006eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0071h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0075h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0076h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0077h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0078h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gparts_xor_8uBytes => new byte[121]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x52,0x49,0x63,0xF3,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAE,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void gparts_xor_16u(int partcount, int partwidth, in ushort a, in ushort b, ref ushort z)
; location: [7FFDDAFC3330h, 7FFDDAFC33ABh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+80h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 80 00 00 00
0012h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0015h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0018h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ah jle short 0071h               ; JLE(Jle_rel8_64) [71h:jmp64]                         encoding(2 bytes) = 7e 55
001ch movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001fh shl rsi,1                     ; SHL(Shl_rm64_1) [RSI,1h:imm8]                        encoding(3 bytes) = 48 d1 e6
0022h lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 3c 30
0026h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 1c 31
002ah vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002eh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0034h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0038h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
003dh vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
0041h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0047h vlddqu ymm0,ymmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RBX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 03
004bh vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0050h vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0056h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
005bh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
005fh add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
0062h vmovdqu ymmword ptr [rsi],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RSI:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 06
0066h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0069h add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
006ch cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
006fh jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c ab
0071h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0074h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0078h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0079h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
007bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gparts_xor_16uBytes => new byte[124]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x55,0x49,0x63,0xF3,0x48,0xD1,0xE6,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAB,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void gparts_xor_32u(int partcount, int partwidth, in uint a, in uint b, ref uint z)
; location: [7FFDDAFC33D0h, 7FFDDAFC344Ch]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+80h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 80 00 00 00
0012h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0015h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0018h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ah jle short 0072h               ; JLE(Jle_rel8_64) [72h:jmp64]                         encoding(2 bytes) = 7e 56
001ch movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001fh shl rsi,2                     ; SHL(Shl_rm64_imm8) [RSI,2h:imm8]                     encoding(4 bytes) = 48 c1 e6 02
0023h lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 3c 30
0027h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 1c 31
002bh vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002fh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0035h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0039h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
003eh vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
0042h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0048h vlddqu ymm0,ymmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RBX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 03
004ch vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0051h vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0057h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
005ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0060h add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
0063h vmovdqu ymmword ptr [rsi],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RSI:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 06
0067h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
006ah add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
006dh cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
0070h jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c aa
0072h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0075h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0079h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
007ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
007ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gparts_xor_32uBytes => new byte[125]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x56,0x49,0x63,0xF3,0x48,0xC1,0xE6,0x02,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAA,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void gparts_xor_64u(int partcount, int partwidth, in ulong a, in ulong b, ref ulong z)
; location: [7FFDDAFC3480h, 7FFDDAFC34FCh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+80h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 80 00 00 00
0012h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0015h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0018h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ah jle short 0072h               ; JLE(Jle_rel8_64) [72h:jmp64]                         encoding(2 bytes) = 7e 56
001ch movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001fh shl rsi,3                     ; SHL(Shl_rm64_imm8) [RSI,3h:imm8]                     encoding(4 bytes) = 48 c1 e6 03
0023h lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 3c 30
0027h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 1c 31
002bh vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002fh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0035h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0039h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
003eh vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
0042h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0048h vlddqu ymm0,ymmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RBX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 03
004ch vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0051h vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0057h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
005ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0060h add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
0063h vmovdqu ymmword ptr [rsi],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RSI:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 06
0067h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
006ah add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
006dh cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
0070h jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c aa
0072h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0075h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0079h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
007ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
007ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gparts_xor_64uBytes => new byte[125]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x56,0x49,0x63,0xF3,0x48,0xC1,0xE6,0x03,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAA,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vmov_idx3_128x8u(byte src, Vector128<byte> dst)
; location: [7FFDDAFC3530h, 7FFDDAFC354Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000dh vpinsrb xmm0,xmm0,eax,3       ; VPINSRB(VEX_Vpinsrb_xmm_xmm_r32m8_imm8) [XMM0,XMM0,EAX,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 20 c0 03
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx3_128x8uBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0x0F,0xB6,0xC2,0xC4,0xE3,0x79,0x20,0xC0,0x03,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vmov_idx4_128x16u(ushort src, Vector128<ushort> dst)
; location: [7FFDDAFC3560h, 7FFDDAFC3579h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
000dh vpinsrw xmm0,xmm0,eax,4       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM0,XMM0,EAX,4h:imm8] encoding(VEX, 5 bytes) = c5 f9 c4 c0 04
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx4_128x16uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0x0F,0xB7,0xC2,0xC5,0xF9,0xC4,0xC0,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vmov_idx2_128x32u(uint src, Vector128<uint> dst)
; location: [7FFDDAFC39A0h, 7FFDDAFC39B7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah vpinsrd xmm0,xmm0,edx,2       ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 22 c2 02
0010h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0014h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx2_128x32uBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xE3,0x79,0x22,0xC2,0x02,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vmov_idx3_256x8u(byte src, Vector256<byte> dst)
; location: [7FFDDAFC39D0h, 7FFDDAFC39F7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000eh movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0011h vpinsrb xmm1,xmm1,eax,3       ; VPINSRB(VEX_Vpinsrb_xmm_xmm_r32m8_imm8) [XMM1,XMM1,EAX,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 20 c8 03
0017h vinsertf128 ymm0,ymm0,xmm1,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
001dh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx3_256x8uBytes => new byte[40]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0x0F,0xB6,0xC2,0xC4,0xE3,0x71,0x20,0xC8,0x03,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vmov_idx4_256x16u(ushort src, Vector256<ushort> dst)
; location: [7FFDDAFC3A10h, 7FFDDAFC3A36h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000eh movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0011h vpinsrw xmm1,xmm1,eax,4       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM1,XMM1,EAX,4h:imm8] encoding(VEX, 5 bytes) = c5 f1 c4 c8 04
0016h vinsertf128 ymm0,ymm0,xmm1,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx4_256x16uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0x0F,0xB7,0xC2,0xC5,0xF1,0xC4,0xC8,0x04,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vmov_idx2_256x32u(uint src, Vector256<uint> dst)
; location: [7FFDDAFC3A50h, 7FFDDAFC3A74h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000eh vpinsrd xmm1,xmm1,edx,2       ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 22 ca 02
0014h vinsertf128 ymm0,ymm0,xmm1,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
001ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx2_256x32uBytes => new byte[37]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x71,0x22,0xCA,0x02,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vmov_idx4x2_256x32u(uint a, uint b, Vector256<uint> dst)
; location: [7FFDDAFC3A90h, 7FFDDAFC3AC6h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R9:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 01
000ah vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000eh vpinsrd xmm1,xmm1,edx,2       ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 22 ca 02
0014h vinsertf128 ymm0,ymm0,xmm1,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
001ah vextractf128 xmm1,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 01
0020h vpinsrd xmm1,xmm1,r8d,0       ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,R8D,0h:imm8] encoding(VEX, 6 bytes) = c4 c3 71 22 c8 00
0026h vinsertf128 ymm0,ymm0,xmm1,1  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 01
002ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0030h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0033h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx4x2_256x32uBytes => new byte[55]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x71,0x22,0xCA,0x02,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC1,0x01,0xC4,0xC3,0x71,0x22,0xC8,0x00,0xC4,0xE3,0x7D,0x18,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vmov128x8u(byte src)
; location: [7FFDDAFC3AE0h, 7FFDDAFC3AF3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h vmovd xmm0,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c0
000ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov128x8uBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB6,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vmov128x16u(ushort src)
; location: [7FFDDAFC3B10h, 7FFDDAFC3B23h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h vmovd xmm0,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c0
000ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov128x16uBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vmov128x32u(uint src)
; location: [7FFDDAFC3B40h, 7FFDDAFC3B50h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovd xmm0,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e c2
0009h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov128x32uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x6E,0xC2,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vmov128x64u(ulong src)
; location: [7FFDDAFC3B70h, 7FFDDAFC3B81h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
000ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov128x64uBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xF9,0x6E,0xC2,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<double> vmov128x64u(double src)
; location: [7FFDDAFC3BA0h, 7FFDDAFC3BACh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd [rcx],xmm1            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM1] encoding(VEX, 4 bytes) = c5 f9 11 09
0009h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov128x64uBytes => new byte[13]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x11,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vmov256x8u(byte src)
; location: [7FFDDAFC3BC0h, 7FFDDAFC3BD6h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h vmovd xmm0,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c0
000ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov256x8uBytes => new byte[23]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB6,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vmov256x16u(ushort src)
; location: [7FFDDAFC3BF0h, 7FFDDAFC3C06h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h vmovd xmm0,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c0
000ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov256x16uBytes => new byte[23]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vmov256x32u(uint src)
; location: [7FFDDAFC3C20h, 7FFDDAFC3C33h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovd xmm0,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e c2
0009h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov256x32uBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x6E,0xC2,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vmov256x64u(ulong src)
; location: [7FFDDAFC3C50h, 7FFDDAFC3C64h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
000ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov256x64uBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xF9,0x6E,0xC2,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<double> vmov256x64u(double src)
; location: [7FFDDAFC4080h, 7FFDDAFC408Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd [rcx],ymm1            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM1] encoding(VEX, 4 bytes) = c5 fd 11 09
0009h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov256x64uBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x11,0x09,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vconvert_v256x16u_v2x256x64u(Vector256<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
; location: [7FFDDAFC40B0h, 7FFDDAFC40DBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
000fh vpmovzxwq ymm1,xmm1           ; VPMOVZXWQ(VEX_Vpmovzxwq_ymm_xmmm64) [YMM1,XMM1]      encoding(VEX, 5 bytes) = c4 e2 7d 34 c9
0014h vmovupd [rdx],ymm1            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,:sr),YMM1] encoding(VEX, 4 bytes) = c5 fd 11 0a
0018h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
001eh vpmovzxwq ymm0,xmm0           ; VPMOVZXWQ(VEX_Vpmovzxwq_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 34 c0
0023h vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
0028h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_v256x16u_v2x256x64uBytes => new byte[44]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE2,0x7D,0x34,0xC9,0xC5,0xFD,0x11,0x0A,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x34,0xC0,0xC4,0xC1,0x7D,0x11,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vconvert_yspan16u_v2x256x64u(Block256<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
; location: [7FFDDAFC40F0h, 7FFDDAFC4115h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
000bh vpmovzxwq ymm0,qword ptr [rcx]; VPMOVZXWQ(VEX_Vpmovzxwq_ymm_xmmm64) [YMM0,mem(Packed64_UInt16,RCX:br,:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 34 01
0010h vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0014h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0018h vpmovzxwq ymm0,qword ptr [rax]; VPMOVZXWQ(VEX_Vpmovzxwq_ymm_xmmm64) [YMM0,mem(Packed64_UInt16,RAX:br,:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 34 00
001dh vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_yspan16u_v2x256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0x48,0x8B,0xC8,0xC4,0xE2,0x7D,0x34,0x01,0xC5,0xFD,0x11,0x02,0x48,0x83,0xC0,0x10,0xC4,0xE2,0x7D,0x34,0x00,0xC4,0xC1,0x7D,0x11,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vconvert_xspan32u_v256x64u(Block128<uint> src, out Vector256<ulong> dst)
; location: [7FFDDAFC4530h, 7FFDDAFC4551h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h vpmovsxdq ymm0,xmmword ptr [rax]; VPMOVSXDQ(VEX_Vpmovsxdq_ymm_xmmm128) [YMM0,mem(Packed128_Int32,RAX:br,:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 25 00
000dh vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
0012h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
0017h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_xspan32u_v256x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0xC4,0xE2,0x7D,0x25,0x00,0xC4,0xC1,0x7D,0x11,0x00,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vconvert_ymem32u_v2x256x64u(Block256<uint> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
; location: [7FFDDAFC4570h, 7FFDDAFC4595h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
000bh vpmovsxdq ymm0,xmmword ptr [rcx]; VPMOVSXDQ(VEX_Vpmovsxdq_ymm_xmmm128) [YMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 25 01
0010h vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0014h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0018h vpmovsxdq ymm0,xmmword ptr [rax]; VPMOVSXDQ(VEX_Vpmovsxdq_ymm_xmmm128) [YMM0,mem(Packed128_Int32,RAX:br,:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 25 00
001dh vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_ymem32u_v2x256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0x48,0x8B,0xC8,0xC4,0xE2,0x7D,0x25,0x01,0xC5,0xFD,0x11,0x02,0x48,0x83,0xC0,0x10,0xC4,0xE2,0x7D,0x25,0x00,0xC4,0xC1,0x7D,0x11,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> valignr256x4n(Vector256<byte> x, Vector256<byte> y)
; location: [7FFDDAFC45B0h, 7FFDDAFC45CEh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpalignr ymm0,ymm0,ymm1,4     ; VPALIGNR(VEX_Vpalignr_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM1,4h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 0f c1 04
0014h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> valignr256x4nBytes => new byte[31]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE3,0x7D,0x0F,0xC1,0x04,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> valignr256x4(Vector256<byte> x, Vector256<byte> y)
; location: [7FFDDAFC45F0h, 7FFDDAFC460Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpalignr ymm0,ymm0,ymm1,4     ; VPALIGNR(VEX_Vpalignr_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM1,4h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 0f c1 04
0014h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> valignr256x4Bytes => new byte[31]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE3,0x7D,0x0F,0xC1,0x04,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> valignr128x4n(Vector128<byte> x, Vector128<byte> y)
; location: [7FFDDAFC4630h, 7FFDDAFC464Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpalignr xmm0,xmm0,xmm1,4     ; VPALIGNR(VEX_Vpalignr_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,4h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0f c1 04
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> valignr128x4nBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0F,0xC1,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> valignr128x4(Vector128<byte> x, Vector128<byte> y)
; location: [7FFDDAFC4660h, 7FFDDAFC467Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpalignr xmm0,xmm0,xmm1,4     ; VPALIGNR(VEX_Vpalignr_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,4h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0f c1 04
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> valignr128x4Bytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0F,0xC1,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> packus(Vector128<ushort> x, Vector128<ushort> y)
; location: [7FFDDAFC4690h, 7FFDDAFC46A9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpackuswb xmm0,xmm0,xmm1      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 67 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packusBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x67,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> packus(Vector256<ushort> x, Vector256<ushort> y)
; location: [7FFDDAFC46C0h, 7FFDDAFC46DCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpackuswb ymm0,ymm0,ymm1      ; VPACKUSWB(VEX_Vpackuswb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 67 c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packusBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0x67,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> ones_128x8u()
; location: [7FFDDAFC4B00h, 7FFDDAFC4B18h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vpcmpeqb xmm0,xmm0,xmm1       ; VPCMPEQB(VEX_Vpcmpeqb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 74 c1
0011h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_128x8uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x74,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> ones_128x64u()
; location: [7FFDDAFC4B30h, 7FFDDAFC4B49h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vpcmpeqq xmm0,xmm0,xmm1       ; VPCMPEQQ(VEX_Vpcmpeqq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 29 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC4,0xE2,0x79,0x29,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> ones_256x8u()
; location: [7FFDDAFC4B60h, 7FFDDAFC4B7Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vpcmpeqb ymm0,ymm0,ymm1       ; VPCMPEQB(VEX_Vpcmpeqb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 74 c1
0011h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_256x8uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x74,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> ones_256x64u()
; location: [7FFDDAFC4B90h, 7FFDDAFC4BACh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vpcmpeqq ymm0,ymm0,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 29 c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC4,0xE2,0x7D,0x29,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<double> ones_256x64f()
; location: [7FFDDAFC4BC0h, 7FFDDAFC4BDCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vcmpeq_uqpd ymm0,ymm0,ymm1    ; VCMPPD(VEX_Vcmppd_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM1,8h:imm8] encoding(VEX, 5 bytes) = c5 fd c2 c1 08
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_256x64fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0xC2,0xC1,0x08,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<sbyte> vperm4x64(Vector256<sbyte> x)
; location: [7FFDDAFC50D0h, 7FFDDAFC50E9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpermq ymm0,ymm0,0E4h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,e4h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 e4
000fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vperm4x64Bytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xE3,0xFD,0x00,0xC0,0xE4,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<uint> spec)
; location: [7FFDDAFC5100h, 7FFDDAFC511Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpermd ymm0,ymm1,ymm0         ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]  encoding(VEX, 5 bytes) = c4 e2 75 36 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar8x32_256x32iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
; location: [7FFE3925D1D0h, 7FFE3925D1E0h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call qword ptr [7FFE38E7F6C8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,:sr)]        encoding(6 bytes) = ff 15 ed 24 c2 ff
000bh nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar8x32_256x32uBytes => new byte[17]{0x48,0x83,0xEC,0x28,0x90,0xFF,0x15,0xED,0x24,0xC2,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
; location: [7FFDDAFC5160h, 7FFDDAFC51B0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,1CDAB098121h          ; MOV(Mov_r64_imm64) [RAX,1cdab098121h:imm64]          encoding(10 bytes) = 48 b8 21 81 09 ab cd 01 00 00
0018h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
001ch vpaddb ymm2,ymm1,ymm2         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM2,YMM1,YMM2]  encoding(VEX, 4 bytes) = c5 f5 fc d2
0020h vpshufb ymm2,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 d2
0025h vperm2i128 ymm0,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c0 03
002bh mov rax,1CDAB098381h          ; MOV(Mov_r64_imm64) [RAX,1cdab098381h:imm64]          encoding(10 bytes) = 48 b8 81 83 09 ab cd 01 00 00
0035h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0039h vpaddb ymm1,ymm1,ymm3         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]  encoding(VEX, 4 bytes) = c5 f5 fc cb
003dh vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0042h vpor ymm0,ymm2,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]      encoding(VEX, 4 bytes) = c5 ed eb c0
0046h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
004ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar32x8_256x8uBytes => new byte[81]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0x21,0x81,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xF5,0xFC,0xD2,0xC4,0xE2,0x7D,0x00,0xD2,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0x81,0x83,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xF5,0xFC,0xCB,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xED,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> rotl_128x16_pattern()
; location: [7FFDDAFC51D0h, 7FFDDAFC51EAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,1CDAB098301h          ; MOV(Mov_r64_imm64) [RAX,1cdab098301h:imm64]          encoding(10 bytes) = 48 b8 01 83 09 ab cd 01 00 00
000fh vlddqu xmm0,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 00
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_128x16_patternBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0x01,0x83,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> rotl_128x32_pattern()
; location: [7FFDDAFC5200h, 7FFDDAFC521Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,1CDAB098321h          ; MOV(Mov_r64_imm64) [RAX,1cdab098321h:imm64]          encoding(10 bytes) = 48 b8 21 83 09 ab cd 01 00 00
000fh vlddqu xmm0,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 00
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_128x32_patternBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0x21,0x83,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> rotl_g128x8u(Vector128<byte> src, byte offset)
; location: [7FFDDAFC5230h, 7FFDDAFC533Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vmovaps xmm1,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 c8
000fh vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
0014h mov rax,1CDAB098181h          ; MOV(Mov_r64_imm64) [RAX,1cdab098181h:imm64]          encoding(10 bytes) = 48 b8 81 81 09 ab cd 01 00 00
001eh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
0022h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0026h vmovd xmm3,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM3,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d8
002ah vpsllw ymm0,ymm0,xmm3         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM0,YMM0,XMM3]  encoding(VEX, 4 bytes) = c5 fd f1 c3
002eh vpshufb ymm0,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 c2
0033h mov rax,1CDAB098051h          ; MOV(Mov_r64_imm64) [RAX,1cdab098051h:imm64]          encoding(10 bytes) = 48 b8 51 80 09 ab cd 01 00 00
003dh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
0041h mov rax,1CDAB098121h          ; MOV(Mov_r64_imm64) [RAX,1cdab098121h:imm64]          encoding(10 bytes) = 48 b8 21 81 09 ab cd 01 00 00
004bh vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
004fh vpaddb ymm3,ymm2,ymm3         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM2,YMM3]  encoding(VEX, 4 bytes) = c5 ed fc db
0053h vpshufb ymm3,ymm0,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM0,YMM3] encoding(VEX, 5 bytes) = c4 e2 7d 00 db
0058h vperm2i128 ymm0,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c0 03
005eh mov rax,1CDAB098381h          ; MOV(Mov_r64_imm64) [RAX,1cdab098381h:imm64]          encoding(10 bytes) = 48 b8 81 83 09 ab cd 01 00 00
0068h vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
006ch vpaddb ymm2,ymm2,ymm4         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM4]  encoding(VEX, 4 bytes) = c5 ed fc d4
0070h vpshufb ymm0,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 c2
0075h vpor ymm0,ymm3,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM3,YMM0]      encoding(VEX, 4 bytes) = c5 e5 eb c0
0079h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
007fh vpmovzxbw ymm1,xmm1           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c9
0084h mov rax,1CDAB098181h          ; MOV(Mov_r64_imm64) [RAX,1cdab098181h:imm64]          encoding(10 bytes) = 48 b8 81 81 09 ab cd 01 00 00
008eh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
0092h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0096h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0098h add eax,8                     ; ADD(Add_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 c0 08
009bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
009eh vmovd xmm3,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM3,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d8
00a2h vpsrlw ymm1,ymm1,xmm3         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM1,YMM1,XMM3]  encoding(VEX, 4 bytes) = c5 f5 d1 cb
00a6h vpshufb ymm1,ymm1,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2] encoding(VEX, 5 bytes) = c4 e2 75 00 ca
00abh mov rax,1CDAB098051h          ; MOV(Mov_r64_imm64) [RAX,1cdab098051h:imm64]          encoding(10 bytes) = 48 b8 51 80 09 ab cd 01 00 00
00b5h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
00b9h mov rax,1CDAB098121h          ; MOV(Mov_r64_imm64) [RAX,1cdab098121h:imm64]          encoding(10 bytes) = 48 b8 21 81 09 ab cd 01 00 00
00c3h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
00c7h vpaddb ymm3,ymm2,ymm3         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM2,YMM3]  encoding(VEX, 4 bytes) = c5 ed fc db
00cbh vpshufb ymm3,ymm1,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM1,YMM3] encoding(VEX, 5 bytes) = c4 e2 75 00 db
00d0h vperm2i128 ymm1,ymm1,ymm1,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM1,YMM1,YMM1,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 46 c9 03
00d6h mov rax,1CDAB098381h          ; MOV(Mov_r64_imm64) [RAX,1cdab098381h:imm64]          encoding(10 bytes) = 48 b8 81 83 09 ab cd 01 00 00
00e0h vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
00e4h vpaddb ymm2,ymm2,ymm4         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM4]  encoding(VEX, 4 bytes) = c5 ed fc d4
00e8h vpshufb ymm1,ymm1,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2] encoding(VEX, 5 bytes) = c4 e2 75 00 ca
00edh vpor ymm1,ymm3,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM3,YMM1]      encoding(VEX, 4 bytes) = c5 e5 eb c9
00f1h vextractf128 xmm1,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 00
00f7h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
00fbh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
00ffh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0102h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0105h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0109h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
010ah call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F589B20h:jmp64]                encoding(5 bytes) = e8 11 9a 58 5f
010fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rotl_g128x8uBytes => new byte[272]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC5,0xF8,0x28,0xC8,0xC4,0xE2,0x7D,0x30,0xC0,0x48,0xB8,0x81,0x81,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD8,0xC5,0xFD,0xF1,0xC3,0xC4,0xE2,0x7D,0x00,0xC2,0x48,0xB8,0x51,0x80,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0x48,0xB8,0x21,0x81,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xED,0xFC,0xDB,0xC4,0xE2,0x7D,0x00,0xDB,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0x81,0x83,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xED,0xFC,0xD4,0xC4,0xE2,0x7D,0x00,0xC2,0xC5,0xE5,0xEB,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC4,0xE2,0x7D,0x30,0xC9,0x48,0xB8,0x81,0x81,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0x41,0x0F,0xB6,0xC0,0xF7,0xD8,0x83,0xC0,0x08,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD8,0xC5,0xF5,0xD1,0xCB,0xC4,0xE2,0x75,0x00,0xCA,0x48,0xB8,0x51,0x80,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0x48,0xB8,0x21,0x81,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xED,0xFC,0xDB,0xC4,0xE2,0x75,0x00,0xDB,0xC4,0xE3,0x75,0x46,0xC9,0x03,0x48,0xB8,0x81,0x83,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xED,0xFC,0xD4,0xC4,0xE2,0x75,0x00,0xCA,0xC5,0xE5,0xEB,0xC9,0xC4,0xE3,0x7D,0x19,0xC9,0x00,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x11,0x9A,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> rotl_g128x16u(Vector128<ushort> src, byte offset)
; location: [7FFDDAFC5370h, 7FFDDAFC53A0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllw xmm1,xmm0,xmm1         ; VPSLLW(VEX_Vpsllw_xmm_xmm_xmmm128) [XMM1,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f1 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,10h                   ; ADD(Add_rm32_imm8) [EAX,10h:imm32]                   encoding(3 bytes) = 83 c0 10
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlw xmm0,xmm0,xmm2         ; VPSRLW(VEX_Vpsrlw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d1 c2
0025h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0029h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x16uBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF1,0xC9,0xF7,0xD8,0x83,0xC0,0x10,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD1,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> rotl_g128x32u(Vector128<uint> src, byte offset)
; location: [7FFDDAFC53C0h, 7FFDDAFC53F0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpslld xmm1,xmm0,xmm1         ; VPSLLD(VEX_Vpslld_xmm_xmm_xmmm128) [XMM1,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f2 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,20h                   ; ADD(Add_rm32_imm8) [EAX,20h:imm32]                   encoding(3 bytes) = 83 c0 20
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrld xmm0,xmm0,xmm2         ; VPSRLD(VEX_Vpsrld_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d2 c2
0025h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0029h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x32uBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF2,0xC9,0xF7,0xD8,0x83,0xC0,0x20,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD2,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> rotl_g128x64u(Vector128<ulong> src, byte offset)
; location: [7FFDDAFC5410h, 7FFDDAFC5440h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllq xmm1,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM1,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,40h                   ; ADD(Add_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 c0 40
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlq xmm0,xmm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d3 c2
0025h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0029h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x64uBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC9,0xF7,0xD8,0x83,0xC0,0x40,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD3,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> rotl_g256x8u(Vector256<byte> src, byte offset)
; location: [7FFDDAFC5460h, 7FFDDAFC5662h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps [rsp+20h],xmm6        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 6 bytes) = c5 f8 29 74 24 20
000dh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0011h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0015h vextractf128 xmm2,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 00
001bh vpmovzxbw ymm2,xmm2           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 30 d2
0020h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0026h vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
002bh mov rax,1CDAB098181h          ; MOV(Mov_r64_imm64) [RAX,1cdab098181h:imm64]          encoding(10 bytes) = 48 b8 81 81 09 ab cd 01 00 00
0035h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0039h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
003dh vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0041h vpsllw ymm2,ymm2,xmm4         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM2,YMM2,XMM4]  encoding(VEX, 4 bytes) = c5 ed f1 d4
0045h vpshufb ymm2,ymm2,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 00 d3
004ah movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
004eh vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0052h vpsllw ymm0,ymm0,xmm4         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM0,YMM0,XMM4]  encoding(VEX, 4 bytes) = c5 fd f1 c4
0056h vpshufb ymm0,ymm0,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3] encoding(VEX, 5 bytes) = c4 e2 7d 00 c3
005bh mov rax,1CDAB098051h          ; MOV(Mov_r64_imm64) [RAX,1cdab098051h:imm64]          encoding(10 bytes) = 48 b8 51 80 09 ab cd 01 00 00
0065h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0069h vmovaps ymm4,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 e3
006dh mov rax,1CDAB098121h          ; MOV(Mov_r64_imm64) [RAX,1cdab098121h:imm64]          encoding(10 bytes) = 48 b8 21 81 09 ab cd 01 00 00
0077h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
007bh vpaddb ymm5,ymm4,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM4,YMM5]  encoding(VEX, 4 bytes) = c5 dd fc ed
007fh vpshufb ymm5,ymm2,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM2,YMM5] encoding(VEX, 5 bytes) = c4 e2 6d 00 ed
0084h vperm2i128 ymm2,ymm2,ymm2,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM2,YMM2,YMM2,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 46 d2 03
008ah mov rax,1CDAB098381h          ; MOV(Mov_r64_imm64) [RAX,1cdab098381h:imm64]          encoding(10 bytes) = 48 b8 81 83 09 ab cd 01 00 00
0094h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
0098h vpaddb ymm4,ymm4,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6]  encoding(VEX, 4 bytes) = c5 dd fc e6
009ch vpshufb ymm2,ymm2,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM4] encoding(VEX, 5 bytes) = c4 e2 6d 00 d4
00a1h vpor ymm2,ymm5,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM2,YMM5,YMM2]      encoding(VEX, 4 bytes) = c5 d5 eb d2
00a5h vextractf128 xmm2,ymm2,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d2 00
00abh mov rax,1CDAB098121h          ; MOV(Mov_r64_imm64) [RAX,1cdab098121h:imm64]          encoding(10 bytes) = 48 b8 21 81 09 ab cd 01 00 00
00b5h vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
00b9h vpaddb ymm4,ymm3,ymm4         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM4,YMM3,YMM4]  encoding(VEX, 4 bytes) = c5 e5 fc e4
00bdh vpshufb ymm4,ymm0,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM0,YMM4] encoding(VEX, 5 bytes) = c4 e2 7d 00 e4
00c2h vperm2i128 ymm0,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c0 03
00c8h mov rax,1CDAB098381h          ; MOV(Mov_r64_imm64) [RAX,1cdab098381h:imm64]          encoding(10 bytes) = 48 b8 81 83 09 ab cd 01 00 00
00d2h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00d6h vpaddb ymm3,ymm3,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM5]  encoding(VEX, 4 bytes) = c5 e5 fc dd
00dah vpshufb ymm0,ymm0,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3] encoding(VEX, 5 bytes) = c4 e2 7d 00 c3
00dfh vpor ymm0,ymm4,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM4,YMM0]      encoding(VEX, 4 bytes) = c5 dd eb c0
00e3h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
00e9h vxorps ymm3,ymm3,ymm3         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM3,YMM3,YMM3]  encoding(VEX, 4 bytes) = c5 e4 57 db
00edh vinserti128 ymm2,ymm3,xmm2,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM2,YMM3,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 38 d2 00
00f3h vinserti128 ymm0,ymm2,xmm0,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 01
00f9h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
00fdh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
00ffh add eax,8                     ; ADD(Add_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 c0 08
0102h vextractf128 xmm2,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 ca 00
0108h vpmovzxbw ymm2,xmm2           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 30 d2
010dh vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
0113h vpmovzxbw ymm1,xmm1           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c9
0118h mov rdx,1CDAB098181h          ; MOV(Mov_r64_imm64) [RDX,1cdab098181h:imm64]          encoding(10 bytes) = 48 ba 81 81 09 ab cd 01 00 00
0122h vlddqu ymm3,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 1a
0126h movzx edx,al                  ; MOVZX(Movzx_r32_rm8) [EDX,AL]                        encoding(3 bytes) = 0f b6 d0
0129h vmovd xmm4,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e e2
012dh vpsrlw ymm2,ymm2,xmm4         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM2,YMM2,XMM4]  encoding(VEX, 4 bytes) = c5 ed d1 d4
0131h vpshufb ymm2,ymm2,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 00 d3
0136h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0139h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
013dh vpsrlw ymm1,ymm1,xmm4         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM1,YMM1,XMM4]  encoding(VEX, 4 bytes) = c5 f5 d1 cc
0141h vpshufb ymm1,ymm1,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3] encoding(VEX, 5 bytes) = c4 e2 75 00 cb
0146h mov rax,1CDAB098051h          ; MOV(Mov_r64_imm64) [RAX,1cdab098051h:imm64]          encoding(10 bytes) = 48 b8 51 80 09 ab cd 01 00 00
0150h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0154h vmovaps ymm4,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 e3
0158h mov rax,1CDAB098121h          ; MOV(Mov_r64_imm64) [RAX,1cdab098121h:imm64]          encoding(10 bytes) = 48 b8 21 81 09 ab cd 01 00 00
0162h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
0166h vpaddb ymm5,ymm4,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM4,YMM5]  encoding(VEX, 4 bytes) = c5 dd fc ed
016ah vpshufb ymm5,ymm2,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM2,YMM5] encoding(VEX, 5 bytes) = c4 e2 6d 00 ed
016fh vperm2i128 ymm2,ymm2,ymm2,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM2,YMM2,YMM2,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 46 d2 03
0175h mov rax,1CDAB098381h          ; MOV(Mov_r64_imm64) [RAX,1cdab098381h:imm64]          encoding(10 bytes) = 48 b8 81 83 09 ab cd 01 00 00
017fh vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
0183h vpaddb ymm4,ymm4,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6]  encoding(VEX, 4 bytes) = c5 dd fc e6
0187h vpshufb ymm2,ymm2,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM4] encoding(VEX, 5 bytes) = c4 e2 6d 00 d4
018ch vpor ymm2,ymm5,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM2,YMM5,YMM2]      encoding(VEX, 4 bytes) = c5 d5 eb d2
0190h vextractf128 xmm2,ymm2,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d2 00
0196h mov rax,1CDAB098121h          ; MOV(Mov_r64_imm64) [RAX,1cdab098121h:imm64]          encoding(10 bytes) = 48 b8 21 81 09 ab cd 01 00 00
01a0h vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
01a4h vpaddb ymm4,ymm3,ymm4         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM4,YMM3,YMM4]  encoding(VEX, 4 bytes) = c5 e5 fc e4
01a8h vpshufb ymm4,ymm1,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM1,YMM4] encoding(VEX, 5 bytes) = c4 e2 75 00 e4
01adh vperm2i128 ymm1,ymm1,ymm1,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM1,YMM1,YMM1,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 46 c9 03
01b3h mov rax,1CDAB098381h          ; MOV(Mov_r64_imm64) [RAX,1cdab098381h:imm64]          encoding(10 bytes) = 48 b8 81 83 09 ab cd 01 00 00
01bdh vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
01c1h vpaddb ymm3,ymm3,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM5]  encoding(VEX, 4 bytes) = c5 e5 fc dd
01c5h vpshufb ymm1,ymm1,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3] encoding(VEX, 5 bytes) = c4 e2 75 00 cb
01cah vpor ymm1,ymm4,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM4,YMM1]      encoding(VEX, 4 bytes) = c5 dd eb c9
01ceh vextractf128 xmm1,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 00
01d4h vxorps ymm3,ymm3,ymm3         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM3,YMM3,YMM3]  encoding(VEX, 4 bytes) = c5 e4 57 db
01d8h vinserti128 ymm2,ymm3,xmm2,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM2,YMM3,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 38 d2 00
01deh vinserti128 ymm1,ymm2,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM2,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c9 01
01e4h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
01e8h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
01ech mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
01efh vmovaps xmm6,[rsp+20h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f8 28 74 24 20
01f5h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
01f8h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
01fch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
01fdh call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F5898F0h:jmp64]                encoding(5 bytes) = e8 ee 96 58 5f
0202h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rotl_g256x8uBytes => new byte[515]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0x74,0x24,0x20,0xC5,0xFD,0x10,0x02,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x30,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x30,0xC0,0x48,0xB8,0x81,0x81,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xE0,0xC5,0xED,0xF1,0xD4,0xC4,0xE2,0x6D,0x00,0xD3,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xE0,0xC5,0xFD,0xF1,0xC4,0xC4,0xE2,0x7D,0x00,0xC3,0x48,0xB8,0x51,0x80,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xFC,0x28,0xE3,0x48,0xB8,0x21,0x81,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xDD,0xFC,0xED,0xC4,0xE2,0x6D,0x00,0xED,0xC4,0xE3,0x6D,0x46,0xD2,0x03,0x48,0xB8,0x81,0x83,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xDD,0xFC,0xE6,0xC4,0xE2,0x6D,0x00,0xD4,0xC5,0xD5,0xEB,0xD2,0xC4,0xE3,0x7D,0x19,0xD2,0x00,0x48,0xB8,0x21,0x81,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xE5,0xFC,0xE4,0xC4,0xE2,0x7D,0x00,0xE4,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0x81,0x83,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xE5,0xFC,0xDD,0xC4,0xE2,0x7D,0x00,0xC3,0xC5,0xDD,0xEB,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xE4,0x57,0xDB,0xC4,0xE3,0x65,0x38,0xD2,0x00,0xC4,0xE3,0x6D,0x38,0xC0,0x01,0x41,0x0F,0xB6,0xC0,0xF7,0xD8,0x83,0xC0,0x08,0xC4,0xE3,0x7D,0x19,0xCA,0x00,0xC4,0xE2,0x7D,0x30,0xD2,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x30,0xC9,0x48,0xBA,0x81,0x81,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x1A,0x0F,0xB6,0xD0,0xC5,0xF9,0x6E,0xE2,0xC5,0xED,0xD1,0xD4,0xC4,0xE2,0x6D,0x00,0xD3,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xE0,0xC5,0xF5,0xD1,0xCC,0xC4,0xE2,0x75,0x00,0xCB,0x48,0xB8,0x51,0x80,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xFC,0x28,0xE3,0x48,0xB8,0x21,0x81,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xDD,0xFC,0xED,0xC4,0xE2,0x6D,0x00,0xED,0xC4,0xE3,0x6D,0x46,0xD2,0x03,0x48,0xB8,0x81,0x83,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xDD,0xFC,0xE6,0xC4,0xE2,0x6D,0x00,0xD4,0xC5,0xD5,0xEB,0xD2,0xC4,0xE3,0x7D,0x19,0xD2,0x00,0x48,0xB8,0x21,0x81,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xE5,0xFC,0xE4,0xC4,0xE2,0x75,0x00,0xE4,0xC4,0xE3,0x75,0x46,0xC9,0x03,0x48,0xB8,0x81,0x83,0x09,0xAB,0xCD,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xE5,0xFC,0xDD,0xC4,0xE2,0x75,0x00,0xCB,0xC5,0xDD,0xEB,0xC9,0xC4,0xE3,0x7D,0x19,0xC9,0x00,0xC5,0xE4,0x57,0xDB,0xC4,0xE3,0x65,0x38,0xD2,0x00,0xC4,0xE3,0x6D,0x38,0xC9,0x01,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0x74,0x24,0x20,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3,0xE8,0xEE,0x96,0x58,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> rotl_g256x16u(Vector256<ushort> src, byte offset)
; location: [7FFDDAFC56B0h, 7FFDDAFC56E3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllw ymm1,ymm0,xmm1         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM1,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f1 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,10h                   ; ADD(Add_rm32_imm8) [EAX,10h:imm32]                   encoding(3 bytes) = 83 c0 10
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlw ymm0,ymm0,xmm2         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d1 c2
0025h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0029h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x16uBytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF1,0xC9,0xF7,0xD8,0x83,0xC0,0x10,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD1,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> rotl_g256x32u(Vector256<uint> src, byte offset)
; location: [7FFDDAFC5700h, 7FFDDAFC5733h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpslld ymm1,ymm0,xmm1         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f2 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,20h                   ; ADD(Add_rm32_imm8) [EAX,20h:imm32]                   encoding(3 bytes) = 83 c0 20
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrld ymm0,ymm0,xmm2         ; VPSRLD(VEX_Vpsrld_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d2 c2
0025h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0029h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x32uBytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF2,0xC9,0xF7,0xD8,0x83,0xC0,0x20,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD2,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> rotl_g256x64u(Vector256<ulong> src, byte offset)
; location: [7FFDDAFC5750h, 7FFDDAFC5783h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllq ymm1,ymm0,xmm1         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM1,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f3 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,40h                   ; ADD(Add_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 c0 40
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlq ymm0,ymm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d3 c2
0025h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0029h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x64uBytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF3,0xC9,0xF7,0xD8,0x83,0xC0,0x40,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD3,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
; location: [7FFDDAFC57A0h, 7FFDDAFC57C0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x8iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
; location: [7FFDDAFC57E0h, 7FFDDAFC5800h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x8iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
