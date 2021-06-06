# PACKSSWB/PACKSSDW — Pack with Signed Saturation

## Description

Converts packed signed word integers into packed signed byte integers (PACKSSWB) or converts packed signed doubleword integers into packed signed word integers (PACKSSDW), using saturation to handle overflow conditions. See Figure 4-6 for an example of the packing operation.

## Operation

### PACKSSWB instruction (128-bit Legacy SSE version)

DEST[7:0]←SaturateSignedWordToSignedByte (DEST[15:0]);
DEST[15:8]←SaturateSignedWordToSignedByte (DEST[31:16]);
DEST[23:16]←SaturateSignedWordToSignedByte (DEST[47:32]);
DEST[31:24]←SaturateSignedWordToSignedByte (DEST[63:48]);
DEST[39:32]←SaturateSignedWordToSignedByte (DEST[79:64]);
DEST[47:40]←SaturateSignedWordToSignedByte (DEST[95:80]);
DEST[55:48]←SaturateSignedWordToSignedByte (DEST[111:96]);
DEST[63:56]←SaturateSignedWordToSignedByte (DEST[127:112]);
DEST[71:64]←SaturateSignedWordToSignedByte (SRC[15:0]);
DEST[79:72]←SaturateSignedWordToSignedByte (SRC[31:16]);
DEST[87:80]←SaturateSignedWordToSignedByte (SRC[47:32]);
DEST[95:88]←SaturateSignedWordToSignedByte (SRC[63:48]);
DEST[103:96]←SaturateSignedWordToSignedByte (SRC[79:64]);
DEST[111:104]←SaturateSignedWordToSignedByte (SRC[95:80]);
DEST[119:112]←SaturateSignedWordToSignedByte (SRC[111:96]);
DEST[127:120]←SaturateSignedWordToSignedByte (SRC[127:112]);
DEST[MAXVL-1:128] (Unmodified)

### PACKSSDW instruction (128-bit Legacy SSE version)

DEST[15:0]←SaturateSignedDwordToSignedWord (DEST[31:0]);
DEST[31:16]←SaturateSignedDwordToSignedWord (DEST[63:32]);
DEST[47:32]←SaturateSignedDwordToSignedWord (DEST[95:64]);
DEST[63:48]←SaturateSignedDwordToSignedWord (DEST[127:96]);
DEST[79:64]←SaturateSignedDwordToSignedWord (SRC[31:0]);
DEST[95:80]←SaturateSignedDwordToSignedWord (SRC[63:32]);
DEST[111:96]←SaturateSignedDwordToSignedWord (SRC[95:64]);
DEST[127:112]←SaturateSignedDwordToSignedWord (SRC[127:96]);
DEST[MAXVL-1:128] (Unmodified)

### VPACKSSWB instruction (VEX.128 encoded version)

DEST[7:0]←SaturateSignedWordToSignedByte (SRC1[15:0]);
DEST[15:8]←SaturateSignedWordToSignedByte (SRC1[31:16]);
DEST[23:16]←SaturateSignedWordToSignedByte (SRC1[47:32]);
DEST[31:24]←SaturateSignedWordToSignedByte (SRC1[63:48]);
DEST[39:32]←SaturateSignedWordToSignedByte (SRC1[79:64]);
DEST[47:40]←SaturateSignedWordToSignedByte (SRC1[95:80]);
DEST[55:48]←SaturateSignedWordToSignedByte (SRC1[111:96]);
DEST[63:56]←SaturateSignedWordToSignedByte (SRC1[127:112]);
DEST[71:64]←SaturateSignedWordToSignedByte (SRC2[15:0]);
DEST[79:72]←SaturateSignedWordToSignedByte (SRC2[31:16]);
DEST[87:80]←SaturateSignedWordToSignedByte (SRC2[47:32]);
DEST[95:88]←SaturateSignedWordToSignedByte (SRC2[63:48]);
DEST[103:96]←SaturateSignedWordToSignedByte (SRC2[79:64]);
DEST[111:104]←SaturateSignedWordToSignedByte (SRC2[95:80]);
DEST[119:112]←SaturateSignedWordToSignedByte (SRC2[111:96]);
DEST[127:120]←SaturateSignedWordToSignedByte (SRC2[127:112]);
DEST[MAXVL-1:128] ← 0;

### VPACKSSDW instruction (VEX.128 encoded version)

DEST[15:0]←SaturateSignedDwordToSignedWord (SRC1[31:0]);
DEST[31:16]←SaturateSignedDwordToSignedWord (SRC1[63:32]);
DEST[47:32]←SaturateSignedDwordToSignedWord (SRC1[95:64]);
DEST[63:48]←SaturateSignedDwordToSignedWord (SRC1[127:96]);
DEST[79:64]←SaturateSignedDwordToSignedWord (SRC2[31:0]);
DEST[95:80]←SaturateSignedDwordToSignedWord (SRC2[63:32]);
DEST[111:96]←SaturateSignedDwordToSignedWord (SRC2[95:64]);
DEST[127:112]←SaturateSignedDwordToSignedWord (SRC2[127:96]);
DEST[MAXVL-1:128] ← 0;

### VPACKSSWB instruction (VEX.256 encoded version)

DEST[7:0]←SaturateSignedWordToSignedByte (SRC1[15:0]);
DEST[15:8]←SaturateSignedWordToSignedByte (SRC1[31:16]);
DEST[23:16]←SaturateSignedWordToSignedByte (SRC1[47:32]);
DEST[31:24]←SaturateSignedWordToSignedByte (SRC1[63:48]);
DEST[39:32]←SaturateSignedWordToSignedByte (SRC1[79:64]);
DEST[47:40]←SaturateSignedWordToSignedByte (SRC1[95:80]);
DEST[55:48]←SaturateSignedWordToSignedByte (SRC1[111:96]);
DEST[63:56]←SaturateSignedWordToSignedByte (SRC1[127:112]);
DEST[71:64]←SaturateSignedWordToSignedByte (SRC2[15:0]);
DEST[79:72]←SaturateSignedWordToSignedByte (SRC2[31:16]);
DEST[87:80]←SaturateSignedWordToSignedByte (SRC2[47:32]);
DEST[95:88]←SaturateSignedWordToSignedByte (SRC2[63:48]);
DEST[103:96]←SaturateSignedWordToSignedByte (SRC2[79:64]);
DEST[111:104]←SaturateSignedWordToSignedByte (SRC2[95:80]);
DEST[119:112]←SaturateSignedWordToSignedByte (SRC2[111:96]);
DEST[127:120]←SaturateSignedWordToSignedByte (SRC2[127:112]);
DEST[135:128]←SaturateSignedWordToSignedByte (SRC1[143:128]);
DEST[143:136]←SaturateSignedWordToSignedByte (SRC1[159:144]);
DEST[151:144]←SaturateSignedWordToSignedByte (SRC1[175:160]);
DEST[159:152]←SaturateSignedWordToSignedByte (SRC1[191:176]);
DEST[167:160]←SaturateSignedWordToSignedByte (SRC1[207:192]);
DEST[175:168]←SaturateSignedWordToSignedByte (SRC1[223:208]);
DEST[183:176]←SaturateSignedWordToSignedByte (SRC1[239:224]);
DEST[191:184]←SaturateSignedWordToSignedByte (SRC1[255:240]);
DEST[199:192]←SaturateSignedWordToSignedByte (SRC2[143:128]);
DEST[207:200]←SaturateSignedWordToSignedByte (SRC2[159:144]);
DEST[215:208]←SaturateSignedWordToSignedByte (SRC2[175:160]);
DEST[223:216]←SaturateSignedWordToSignedByte (SRC2[191:176]);
DEST[231:224]←SaturateSignedWordToSignedByte (SRC2[207:192]);
DEST[239:232]←SaturateSignedWordToSignedByte (SRC2[223:208]);
DEST[247:240]←SaturateSignedWordToSignedByte (SRC2[239:224]);
DEST[255:248]←SaturateSignedWordToSignedByte (SRC2[255:240]);
DEST[MAXVL-1:256] ← 0;

### VPACKSSDW instruction (VEX.256 encoded version)
DEST[15:0]←SaturateSignedDwordToSignedWord (SRC1[31:0]);
DEST[31:16]←SaturateSignedDwordToSignedWord (SRC1[63:32]);
DEST[47:32]←SaturateSignedDwordToSignedWord (SRC1[95:64]);
DEST[63:48]←SaturateSignedDwordToSignedWord (SRC1[127:96]);
DEST[79:64]←SaturateSignedDwordToSignedWord (SRC2[31:0]);
DEST[95:80]←SaturateSignedDwordToSignedWord (SRC2[63:32]);
DEST[111:96]←SaturateSignedDwordToSignedWord (SRC2[95:64]);
DEST[127:112]←SaturateSignedDwordToSignedWord (SRC2[127:96]);
DEST[143:128]←SaturateSignedDwordToSignedWord (SRC1[159:128]);
DEST[159:144]←SaturateSignedDwordToSignedWord (SRC1[191:160]);
DEST[175:160]←SaturateSignedDwordToSignedWord (SRC1[223:192]);
DEST[191:176]←SaturateSignedDwordToSignedWord (SRC1[255:224]);
DEST[207:192]←SaturateSignedDwordToSignedWord (SRC2[159:128]);
DEST[223:208]←SaturateSignedDwordToSignedWord (SRC2[191:160]);
DEST[239:224]←SaturateSignedDwordToSignedWord (SRC2[223:192]);
DEST[255:240]←SaturateSignedDwordToSignedWord (SRC2[255:224]);
DEST[MAXVL-1:256] ← 0;

### VPACKSSWB (EVEX encoded versions)

(KL, VL) = (16, 128), (32, 256), (64, 512)
TMP_DEST[7:0]←SaturateSignedWordToSignedByte (SRC1[15:0]);
TMP_DEST[15:8]←SaturateSignedWordToSignedByte (SRC1[31:16]);
TMP_DEST[23:16]←SaturateSignedWordToSignedByte (SRC1[47:32]);
TMP_DEST[31:24]←SaturateSignedWordToSignedByte (SRC1[63:48]);
TMP_DEST[39:32]←SaturateSignedWordToSignedByte (SRC1[79:64]);
TMP_DEST[47:40]←SaturateSignedWordToSignedByte (SRC1[95:80]);
TMP_DEST[55:48]←SaturateSignedWordToSignedByte (SRC1[111:96]);
TMP_DEST[63:56]←SaturateSignedWordToSignedByte (SRC1[127:112]);
TMP_DEST[71:64]←SaturateSignedWordToSignedByte (SRC2[15:0]);
TMP_DEST[79:72]←SaturateSignedWordToSignedByte (SRC2[31:16]);
TMP_DEST[87:80]←SaturateSignedWordToSignedByte (SRC2[47:32]);
TMP_DEST[95:88]←SaturateSignedWordToSignedByte (SRC2[63:48]);
TMP_DEST[103:96]←SaturateSignedWordToSignedByte (SRC2[79:64]);
TMP_DEST[111:104]←SaturateSignedWordToSignedByte (SRC2[95:80]);
TMP_DEST[119:112]←SaturateSignedWordToSignedByte (SRC2[111:96]);
TMP_DEST[127:120]←SaturateSignedWordToSignedByte (SRC2[127:112]);
IF VL >= 256
    TMP_DEST[135:128]←SaturateSignedWordToSignedByte (SRC1[143:128]);
    TMP_DEST[143:136]←SaturateSignedWordToSignedByte (SRC1[159:144]);
    TMP_DEST[151:144]←SaturateSignedWordToSignedByte (SRC1[175:160]);
    TMP_DEST[159:152]←SaturateSignedWordToSignedByte (SRC1[191:176]);
    TMP_DEST[167:160]←SaturateSignedWordToSignedByte (SRC1[207:192]);
    TMP_DEST[175:168]←SaturateSignedWordToSignedByte (SRC1[223:208]);
    TMP_DEST[183:176]←SaturateSignedWordToSignedByte (SRC1[239:224]);
    TMP_DEST[191:184]←SaturateSignedWordToSignedByte (SRC1[255:240]);
    TMP_DEST[199:192]←SaturateSignedWordToSignedByte (SRC2[143:128]);
    TMP_DEST[207:200]←SaturateSignedWordToSignedByte (SRC2[159:144]);
    TMP_DEST[215:208]←SaturateSignedWordToSignedByte (SRC2[175:160]);
    TMP_DEST[223:216]←SaturateSignedWordToSignedByte (SRC2[191:176]);
    TMP_DEST[231:224]←SaturateSignedWordToSignedByte (SRC2[207:192]);
    TMP_DEST[239:232]←SaturateSignedWordToSignedByte (SRC2[223:208]);
    TMP_DEST[247:240]←SaturateSignedWordToSignedByte (SRC2[239:224]);
    TMP_DEST[255:248]←SaturateSignedWordToSignedByte (SRC2[255:240]);
FI;
IF VL >= 512
    TMP_DEST[263:256]←SaturateSignedWordToSignedByte (SRC1[271:256]);
    TMP_DEST[271:264]←SaturateSignedWordToSignedByte (SRC1[287:272]);
    TMP_DEST[279:272]←SaturateSignedWordToSignedByte (SRC1[303:288]);
    TMP_DEST[287:280]←SaturateSignedWordToSignedByte (SRC1[319:304]);
    TMP_DEST[295:288]←SaturateSignedWordToSignedByte (SRC1[335:320]);
    TMP_DEST[303:296]←SaturateSignedWordToSignedByte (SRC1[351:336]);
    TMP_DEST[311:304]←SaturateSignedWordToSignedByte (SRC1[367:352]);
    TMP_DEST[319:312]←SaturateSignedWordToSignedByte (SRC1[383:368]);
    TMP_DEST[327:320]←SaturateSignedWordToSignedByte (SRC2[271:256]);
    TMP_DEST[335:328]←SaturateSignedWordToSignedByte (SRC2[287:272]);
    TMP_DEST[343:336]←SaturateSignedWordToSignedByte (SRC2[303:288]);
    TMP_DEST[351:344]←SaturateSignedWordToSignedByte (SRC2[319:304]);
    TMP_DEST[359:352]←SaturateSignedWordToSignedByte (SRC2[335:320]);
    TMP_DEST[367:360]←SaturateSignedWordToSignedByte (SRC2[351:336]);
    TMP_DEST[375:368]←SaturateSignedWordToSignedByte (SRC2[367:352]);
    TMP_DEST[383:376]←SaturateSignedWordToSignedByte (SRC2[383:368]);
    TMP_DEST[391:384]←SaturateSignedWordToSignedByte (SRC1[399:384]);
    TMP_DEST[399:392]←SaturateSignedWordToSignedByte (SRC1[415:400]);
    TMP_DEST[407:400]←SaturateSignedWordToSignedByte (SRC1[431:416]);
    TMP_DEST[415:408]←SaturateSignedWordToSignedByte (SRC1[447:432]);
    TMP_DEST[423:416]←SaturateSignedWordToSignedByte (SRC1[463:448]);
    TMP_DEST[431:424]←SaturateSignedWordToSignedByte (SRC1[479:464]);
    TMP_DEST[439:432]←SaturateSignedWordToSignedByte (SRC1[495:480]);
    TMP_DEST[447:440]←SaturateSignedWordToSignedByte (SRC1[511:496]);
    TMP_DEST[455:448]←SaturateSignedWordToSignedByte (SRC2[399:384]);
    TMP_DEST[463:456]←SaturateSignedWordToSignedByte (SRC2[415:400]);
    TMP_DEST[471:464]←SaturateSignedWordToSignedByte (SRC2[431:416]);
    TMP_DEST[479:472]←SaturateSignedWordToSignedByte (SRC2[447:432]);
    TMP_DEST[487:480]←SaturateSignedWordToSignedByte (SRC2[463:448]);
    TMP_DEST[495:488]←SaturateSignedWordToSignedByte (SRC2[479:464]);
    TMP_DEST[503:496]←SaturateSignedWordToSignedByte (SRC2[495:480]);
    TMP_DEST[511:504]←SaturateSignedWordToSignedByte (SRC2[511:496]);
FI;
FOR j←0 TO KL-1
    i←j * 8
    IF k1[j] OR *no writemask*
        THEN
            DEST[i+7:i] ← TMP_DEST[i+7:i]
        ELSE
            IF *merging-masking* ; merging-masking
                THEN *DEST[i+7:i] remains unchanged*
                ELSE *zeroing-masking*
                        ; zeroing-masking
                    DEST[i+7:i] ← 0
            FI
    FI;
ENDFOR;
DEST[MAXVL-1:VL] ← 0
VPACKSSDW (EVEX encoded versions) ¶
(KL, VL) = (8, 128), (16, 256), (32, 512)
FOR j←0 TO ((KL/2) - 1)
    i←j * 32
    IF (EVEX.b == 1) AND (SRC2 *is memory*)
        THEN
            TMP_SRC2[i+31:i] ← SRC2[31:0]
        ELSE
            TMP_SRC2[i+31:i] ← SRC2[i+31:i]
    FI;
ENDFOR;
TMP_DEST[15:0]←SaturateSignedDwordToSignedWord (SRC1[31:0]);
TMP_DEST[31:16]←SaturateSignedDwordToSignedWord (SRC1[63:32]);
TMP_DEST[47:32]←SaturateSignedDwordToSignedWord (SRC1[95:64]);
TMP_DEST[63:48]←SaturateSignedDwordToSignedWord (SRC1[127:96]);
TMP_DEST[79:64]←SaturateSignedDwordToSignedWord (TMP_SRC2[31:0]);
TMP_DEST[95:80]←SaturateSignedDwordToSignedWord (TMP_SRC2[63:32]);
TMP_DEST[111:96]←SaturateSignedDwordToSignedWord (TMP_SRC2[95:64]);
TMP_DEST[127:112]←SaturateSignedDwordToSignedWord (TMP_SRC2[127:96]);
IF VL >= 256
    TMP_DEST[143:128]←SaturateSignedDwordToSignedWord (SRC1[159:128]);
    TMP_DEST[159:144]←SaturateSignedDwordToSignedWord (SRC1[191:160]);
    TMP_DEST[175:160]←SaturateSignedDwordToSignedWord (SRC1[223:192]);
    TMP_DEST[191:176]←SaturateSignedDwordToSignedWord (SRC1[255:224]);
    TMP_DEST[207:192]←SaturateSignedDwordToSignedWord (TMP_SRC2[159:128]);
    TMP_DEST[223:208]←SaturateSignedDwordToSignedWord (TMP_SRC2[191:160]);
    TMP_DEST[239:224]←SaturateSignedDwordToSignedWord (TMP_SRC2[223:192]);
    TMP_DEST[255:240]←SaturateSignedDwordToSignedWord (TMP_SRC2[255:224]);
FI;
IF VL >= 512
    TMP_DEST[271:256]←SaturateSignedDwordToSignedWord (SRC1[287:256]);
    TMP_DEST[287:272]←SaturateSignedDwordToSignedWord (SRC1[319:288]);
    TMP_DEST[303:288]←SaturateSignedDwordToSignedWord (SRC1[351:320]);
    TMP_DEST[319:304]←SaturateSignedDwordToSignedWord (SRC1[383:352]);
    TMP_DEST[335:320]←SaturateSignedDwordToSignedWord (TMP_SRC2[287:256]);
    TMP_DEST[351:336]←SaturateSignedDwordToSignedWord (TMP_SRC2[319:288]);
    TMP_DEST[367:352]←SaturateSignedDwordToSignedWord (TMP_SRC2[351:320]);
    TMP_DEST[383:368]←SaturateSignedDwordToSignedWord (TMP_SRC2[383:352]);
    TMP_DEST[399:384]←SaturateSignedDwordToSignedWord (SRC1[415:384]);
    TMP_DEST[415:400]←SaturateSignedDwordToSignedWord (SRC1[447:416]);
    TMP_DEST[431:416]←SaturateSignedDwordToSignedWord (SRC1[479:448]);
    TMP_DEST[447:432]←SaturateSignedDwordToSignedWord (SRC1[511:480]);
    TMP_DEST[463:448]←SaturateSignedDwordToSignedWord (TMP_SRC2[415:384]);
    TMP_DEST[479:464]←SaturateSignedDwordToSignedWord (TMP_SRC2[447:416]);
    TMP_DEST[495:480]←SaturateSignedDwordToSignedWord (TMP_SRC2[479:448]);
    TMP_DEST[511:496]←SaturateSignedDwordToSignedWord (TMP_SRC2[511:480]);
FI;
FOR j←0 TO KL-1
    i←j * 16
    IF k1[j] OR *no writemask*
        THEN DEST[i+15:i]←TMP_DEST[i+15:i]
        ELSE
            IF *merging-masking*
                        ; merging-masking
                THEN *DEST[i+15:i] remains unchanged*
                ELSE *zeroing-masking*
                            ; zeroing-masking
                    DEST[i+15:i] ← 0
            FI
    FI;
ENDFOR;
DEST[MAXVL-1:VL] ← 0