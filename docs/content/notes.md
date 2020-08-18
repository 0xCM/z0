# Notation

// ~ --------------------------------------------------------------------------
// ~ scalar := 8u      | 16u      | 32u       | 64u
// ~        := u[0..8] | u[0..16] | u[0..32] | u[0..64]
// ~        := u[8]    | u[16]    | u[32]    | u[64]
// ~
// ~ vector := v128      | v256      | v512
// ~        := v[0..128] | v[0..256] | v[0..512]
// ~        := v[128]    | v[256]    | v[512]
// ~
// ~ vector granularity
// ~ v128xG := v128x8 | v128x16 | v128x32 | v128x64
// ~ v256xG := v256x8 | v256x16 | v256x32 | v256x64
// ~ cellwidth(v128 | v256) := cellwidth(v128x8  | v256x8)  |
// ~                           cellwidth(v128x16 | v256x16) |
// ~                           cellwidth(v128x32 | v256x32) |
// ~                           cellwidth(v128x64 | v256x64)
// ~                        = 8 | 16 | 32 | 64
// ~ cellcount(v128) := length(v128) := 16 | 8 | 4 | 2
// ~ cellcount(v256) := length(v256) := 32 | 16 | 8 | 4
// ~ bitseg := (u | v)[i..j]
// ~ vbits  := v[a..b, c..d, ..., i..j]
// ~ vcells := v[0, 1, ..., n - 1]
// ~ vcell[i] := v[0 | 1 | ... n - 1]
// ~
// ~
// ~ Functions
// ~ --------------------------------------------------------------------------
// ~ [vcompact, vinflate]
// ~ 16:8 <-> 16 | Packs 2 128x16 vectors into 1 128x8 vector and the inverse
// ~ 16:8 <-> 32
// ~ 32:8 <-> 32
// ~ 32:8 <-> 16 | Packs 2 256x16 vectors int 1 256x8 vector and the inverse
// ~ 16:8 <-> 16
// ~ 8:16 <-> 32
// ~ 16x16 <-> 32
// ~ 4:32 <-> 64
// ~ 8:32 <-> 64
// ~
// ~ vloadblock
// ~ 2:8 -> 64  | Projects 2 8-bit values onto a 128x64 vector
// ~ 4:8 -> 32  | Projects 4 8-bit values onto a 128x32 vector
// ~ 4:8 -> 64  | Projects 4 8-bit values onto a 256x64 vector
// ~ 8:8 -> 16  | Projects 8 8-bit values onto a 128x16 vector
// ~ 8:8 -> 32  | Projects 8 8-bit values onto a 256x32 vector
// ~ 16:8 -> 16 | Projects 8 8-bit values onto a 256x16 vector
// ~ 2:16 -> 64 | Projects 2 16-bit values onto a 128x64 vector
// ~ 4:16 -> 32
// ~ 4:16 -> 64
// ~ 8:16 -> 32
// ~ 2:32 -> 64
// ~
// ~ vscalar_128: (8 | 16 | 32 | 64) -> 128[0..8 | 0..16 | 0..32 | 0..64]
// ~ vscalar_256: (8 | 16 | 32 | 64) -> 256[0..8 | 0..16 | 0..32 | 0..64]
// ~
// ~ vbroadcast_128: scalar -> v128[scalar, scalar, ..., scalar]
// ~ vbroadcast_128: scalar -> v256[scalar, scalar, ..., scalar]
// ~
// ~ vmovemask[128]: 8x16[7, 15, ..., 127] -> u16[0..15]
// ~ vmovemask[256]: 8x32[7, 15, ..., 255] -> u32[0..15]
// ~
// ~ vcover
// ~ 8x16w -> 16x8w
// ~ 16x16w -> 32x8w
// ~ 4x8w -> 8x16w
// ~ 8x32w -> 16x16w
// ~ 2x64w -> 4x32w
// ~ 2x64w -> 4x32w
// ~ 4x64w -> 8x32w
// ~ 4x32w -> 16x8w
// ~ 8x32w -> 32x8w
// ~ 2x64w -> 16x8w
// ~ 4x64w -> 32x8w
// ~
// ~ shift
// ~ shift dir<L | R> cellwidth<8 | 16 | 32 | 64 | 128> granularity<1 | 8 >
