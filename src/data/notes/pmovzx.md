# PMOVZX — Packed Move with Zero Extend

## Operation
----------------------------------------------------------------------------------
Packed_Zero_Extend_BYTE_to_WORD(DEST, SRC) ¶
DEST[15:0] ←ZeroExtend(SRC[7:0]);
DEST[31:16] ←ZeroExtend(SRC[15:8]);
DEST[47:32] ←ZeroExtend(SRC[23:16]);
DEST[63:48] ←ZeroExtend(SRC[31:24]);
DEST[79:64] ←ZeroExtend(SRC[39:32]);
DEST[95:80] ←ZeroExtend(SRC[47:40]);
DEST[111:96] ←ZeroExtend(SRC[55:48]);
DEST[127:112] ←ZeroExtend(SRC[63:56]);

### Packed_Zero_Extend_BYTE_to_DWORD(DEST, SRC) ¶

DEST[31:0] ←ZeroExtend(SRC[7:0]);
DEST[63:32] ←ZeroExtend(SRC[15:8]);
DEST[95:64] ←ZeroExtend(SRC[23:16]);
DEST[127:96] ←ZeroExtend(SRC[31:24]);

### Packed_Zero_Extend_BYTE_to_QWORD(DEST, SRC) ¶

DEST[63:0] ←ZeroExtend(SRC[7:0]);
DEST[127:64] ←ZeroExtend(SRC[15:8]);

### Packed_Zero_Extend_WORD_to_DWORD(DEST, SRC) ¶

DEST[31:0] ←ZeroExtend(SRC[15:0]);
DEST[63:32] ←ZeroExtend(SRC[31:16]);
DEST[95:64] ←ZeroExtend(SRC[47:32]);
DEST[127:96] ←ZeroExtend(SRC[63:48]);

### Packed_Zero_Extend_WORD_to_QWORD(DEST, SRC) ¶

DEST[63:0] ←ZeroExtend(SRC[15:0]);
DEST[127:64] ←ZeroExtend(SRC[31:16]);

### Packed_Zero_Extend_DWORD_to_QWORD(DEST, SRC) ¶

DEST[63:0] ←ZeroExtend(SRC[31:0]);
DEST[127:64] ←ZeroExtend(SRC[63:32]);