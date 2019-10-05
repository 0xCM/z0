# vpblendd

<https://www.felixcloutier.com/x86/vpblendd>

IF(imm8[0] == 1) THEN DEST[31:0]←SRC2[31:0] ELSE DEST[31:0]←SRC1[31:0]
IF(imm8[1] == 1) THEN DEST[63:32]←SRC2[63:32] ELSE DEST[63:32]←SRC1[63:32]
IF(imm8[2] == 1) THEN DEST[95:64]←SRC2[95:64] ELSE DEST[95:64]←SRC1[95:64]
IF(imm8[3] == 1) THEN DEST[127:96]←SRC2[127:96] ELSE DEST[127:96]←SRC1[127:96]

DEST[MAXVL-1:128] ← 0

## Choices

N0 | N1 > x0 | y0
N2 | N3 > x1 | y1
N4 | N5 > x2 | y2
N6 | N7 > x3 | y3
