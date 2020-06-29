# SETA r/m8
------------------------------------------------------------------------------------------------------------------------
; bit vtestznc(Vector128<short> x, Vector128<short> y), located://dvec/api?vtestznc#vtestznc_(v128x16i,v128x16i)
; public static ReadOnlySpan<byte> vtestznc_ᐤv128x16iㆍv128x16iᐤ => new byte[21]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc4,0xe2,0x79,0x17,0x02,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};
; Base = 7ff9af1f7cf0h
; TermCode = CTC_RET_INTR
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vptest xmm0,xmmword ptr [rdx]           ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 02}
000eh seta al                                 ; SETA r/m8 || 0F 97 /r || encoded[3]{0f 97 c0}
0011h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0014h ret                                     ; RET || C3 || encoded[1]{c3}

# SETAE r/m8
------------------------------------------------------------------------------------------------------------------------
; bit lteq<float>(float lhs, float rhs), located://gmath/gfp?lteq#lteq_g[32f](32f,32f)
; public static ReadOnlySpan<byte> lteq_gᐸ32fᐳᐤ32fㆍ32fᐤ => new byte[16]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf8,0x2e,0xc8,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};
; Base = 7ff9af240a20h
; TermCode = CTC_RET_INTR
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vucomiss xmm1,xmm0                      ; VUCOMISS xmm1, xmm2/m32 || VEX.LIG.0F.WIG 2E /r || encoded[4]{c5 f8 2e c8}
0009h setae al                                ; SETAE r/m8 || 0F 93 /r || encoded[3]{0f 93 c0}
000ch movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
000fh ret                                     ; RET || C3 || encoded[1]{c3}

# SETB r/m8
------------------------------------------------------------------------------------------------------------------------
; bit testbit<sbyte>(sbyte src, byte pos), located://bitcore/generic?testbit#testbit_g[8i](8i,8u)
; public static ReadOnlySpan<byte> testbit_gᐸ8iᐳᐤ8iㆍ8uᐤ => new byte[22]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x0f,0xb6,0xd2,0x0f,0xa3,0xd0,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xc3};
; Base = 7ff9aeaf53d0h
; TermCode = CTC_RET_Zx3
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movsx rax,cl                            ; MOVSX r64, r/m8 || REX.W 0F BE /r || encoded[4]{48 0f be c1}
0009h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000ch bt eax,edx                              ; BT r/m32, r32 || o32 0F A3 /r || encoded[3]{0f a3 d0}
000fh setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
0012h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0015h ret                                     ; RET || C3 || encoded[1]{c3}

# SETBE r/m8
------------------------------------------------------------------------------------------------------------------------
; bit lteq<byte>(num<byte> a, num<byte> b), located://gmath/num?lteq#lteq_g[8u](num[byte],num[byte])
; public static ReadOnlySpan<byte> lteq_gᐸ8uᐳᐤnumᐸbyteᐳㆍnumᐸbyteᐳᐤ => new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x3b,0xc2,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xc3};
; Base = 7ff9af23bb80h
; TermCode = CTC_RET_SBB
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh cmp eax,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c2}
000dh setbe al                                ; SETBE r/m8 || 0F 96 /r || encoded[3]{0f 96 c0}
0010h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0013h ret                                     ; RET || C3 || encoded[1]{c3}

# SETE r/m8
------------------------------------------------------------------------------------------------------------------------
; bit testc<byte>(byte a), located://bitcore/numericlogix?testc#testc_g[8u](8u)
; public static ReadOnlySpan<byte> testc_gᐸ8uᐳᐤ8uᐤ => new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0xf3,0x0f,0xb8,0xc0,0x48,0x83,0xf8,0x08,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};
; Base = 7ff9aeb0b8f0h
; TermCode = CTC_RET_ZED_SBB
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h popcnt eax,eax                          ; POPCNT r32, r/m32 || o32 F3 0F B8 /r || encoded[4]{f3 0f b8 c0}
000ch cmp rax,8                               ; CMP r/m64, imm8 || REX.W 83 /7 ib || encoded[4]{48 83 f8 08}
0010h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0013h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0016h ret                                     ; RET || C3 || encoded[1]{c3}

# SETG r/m8
------------------------------------------------------------------------------------------------------------------------
; bit positive<byte>(byte a), located://gmath/api?positive#positive_g[8u](8u)
; public static ReadOnlySpan<byte> positive_gᐸ8uᐳᐤ8uᐤ => new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x85,0xc0,0x0f,0x9f,0xc0,0x0f,0xb6,0xc0,0xc3};
; Base = 7ff9af21cdc0h
; TermCode = CTC_RET_Zx3
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000ah setg al                                 ; SETG r/m8 || 0F 9F /r || encoded[3]{0f 9f c0}
000dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
