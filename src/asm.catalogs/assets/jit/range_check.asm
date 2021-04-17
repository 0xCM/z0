; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte range_check(Byte[] src)::located://asmlang/prototypes?range_check#range_check_(array_8u)
; public static ReadOnlySpan<byte> range_check_ᐤarray_8uᐤ => new byte[30]{0x48,0x83,0xec,0x28,0x90,0x83,0x79,0x08,0x03,0x76,0x09,0x0f,0xb6,0x41,0x13,0x48,0x83,0xc4,0x28,0xc3,0xe8,0xa7,0x45,0xf8,0x59,0xcc,0x00,0x00,0x19,0x04};
; BaseAddress = 7ffe637ab760h
; TermCode = CTC_Zx7
7ffe637ab760h 0000h sub rsp,28h                             ; SUB r/m64, imm8                  | REX.W 83 /5 ib                   | 4   | 48 83 ec 28
7ffe637ab764h 0004h nop                                     ; NOP                              | 90                               | 1   | 90
7ffe637ab765h 0005h cmp dword ptr [rcx+8],3                 ; CMP r/m32, imm8                  | 83 /7 ib                         | 4   | 83 79 08 03
7ffe637ab769h 0009h jbe short 0014h                         ; JBE rel8                         | 76 cb                            | 2   | 76 09
7ffe637ab76bh 000bh movzx eax,byte ptr [rcx+13h]            ; MOVZX r32, r/m8                  | 0F B6 /r                         | 4   | 0f b6 41 13
7ffe637ab76fh 000fh add rsp,28h                             ; ADD r/m64, imm8                  | REX.W 83 /0 ib                   | 4   | 48 83 c4 28
7ffe637ab773h 0013h ret                                     ; RET                              | C3                               | 1   | c3
7ffe637ab774h 0014h call 7ffebd72fd20h                      ; CALL rel32                       | E8 cd                            | 5   | e8 a7 45 f8 59
7ffe637ab779h 0019h int 3                                   ; INT3                             | CC                               | 1   | cc
