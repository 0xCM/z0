# _AMX

## TDPBF16PS - _tile_dpbf16ps

| TDPBF16PS_TMMf32_TMMu32_TMMu32

--------------------------------------------------------------------------------------------------------------
Compute dot-product of BF16 (16-bit) floating-point pairs in tiles "a" and "b", accumulating the intermediate
single-precision (32-bit) floating-point elements with elements in "dst", and store the 32-bit result back to
tile "dst".

[algorithm]

FOR m := 0 TO dst.rows - 1
    tmp := dst.row[m]
    FOR k := 0 TO (a.colsb / 4) - 1
        FOR n := 0 TO (dst.colsb / 4) - 1
            tmp.fp32[n] += FP32(a.row[m].bf16[2*k+0]) * FP32(b.row[k].bf16[2*n+0])
            tmp.fp32[n] += FP32(a.row[m].bf16[2*k+1]) * FP32(b.row[k].bf16[2*n+1])
        ENDFOR
    ENDFOR
    write_row_and_zero(dst, m, tmp, dst.colsb)
ENDFOR
zero_upper_rows(dst, dst.rows)
zero_tileconfig_start()

--------------------------------------------------------------------------------------------------------------

## TDPBSUD - _tile_dpbsud

| TDPBSUD_TMMi32_TMMu32_TMMu32

--------------------------------------------------------------------------------------------------------------
Compute dot-product of bytes in tiles with a source/destination accumulator. Multiply groups of 4 adjacent
pairs of signed 8-bit integers in "a" with corresponding unsigned 8-bit integers in "b", producing 4
intermediate 32-bit results. Sum these 4 results with the corresponding 32-bit integer in "dst", and store the
32-bit result back to tile "dst".

[algorithm]

DEFINE DPBD(c, x, y) {
    tmp1 := SignExtend32(x.byte[0]) * ZeroExtend32(y.byte[0])
    tmp2 := SignExtend32(x.byte[1]) * ZeroExtend32(y.byte[1])
    tmp3 := SignExtend32(x.byte[2]) * ZeroExtend32(y.byte[2])
    tmp4 := SignExtend32(x.byte[3]) * ZeroExtend32(y.byte[3])
    
    RETURN c + tmp1 + tmp2 + tmp3 + tmp4
}
FOR m := 0 TO dst.rows - 1
    tmp := dst.row[m]
    FOR k := 0 TO (a.colsb / 4) - 1
        FOR n := 0 TO (dst.colsb / 4) - 1
            tmp.dword[n] := DPBD(tmp.dword[n], a.row[m].dword[k], b.row[k].dword[n])
        ENDFOR
    ENDFOR
    write_row_and_zero(dst, m, tmp, dst.colsb)
ENDFOR
zero_upper_rows(dst, dst.rows)
zero_tileconfig_start()

--------------------------------------------------------------------------------------------------------------

## TDPBUSD - _tile_dpbusd

| TDPBUSD_TMMi32_TMMu32_TMMu32

--------------------------------------------------------------------------------------------------------------
Compute dot-product of bytes in tiles with a source/destination accumulator. Multiply groups of 4 adjacent
pairs of unsigned 8-bit integers in "a" with corresponding signed 8-bit integers in "b", producing 4
intermediate 32-bit results. Sum these 4 results with the corresponding 32-bit integer in "dst", and store the
32-bit result back to tile "dst".

[algorithm]

DEFINE DPBD(c, x, y) {
    tmp1 := ZeroExtend32(x.byte[0]) * SignExtend32(y.byte[0])
    tmp2 := ZeroExtend32(x.byte[1]) * SignExtend32(y.byte[1])
    tmp3 := ZeroExtend32(x.byte[2]) * SignExtend32(y.byte[2])
    tmp4 := ZeroExtend32(x.byte[3]) * SignExtend32(y.byte[3])
    
    RETURN c + tmp1 + tmp2 + tmp3 + tmp4
}
FOR m := 0 TO dst.rows - 1
    tmp := dst.row[m]
    FOR k := 0 TO (a.colsb / 4) - 1
        FOR n := 0 TO (dst.colsb / 4) - 1
            tmp.dword[n] := DPBD(tmp.dword[n], a.row[m].dword[k], b.row[k].dword[n])
        ENDFOR
    ENDFOR
    write_row_and_zero(dst, m, tmp, dst.colsb)
ENDFOR
zero_upper_rows(dst, dst.rows)
zero_tileconfig_start()

--------------------------------------------------------------------------------------------------------------

## TDPBUUD - _tile_dpbuud

| TDPBUUD_TMMu32_TMMu32_TMMu32

--------------------------------------------------------------------------------------------------------------
Compute dot-product of bytes in tiles with a source/destination accumulator. Multiply groups of 4 adjacent
pairs of unsigned 8-bit integers in "a" with corresponding unsigned 8-bit integers in "b", producing 4
intermediate 32-bit results. Sum these 4 results with the corresponding 32-bit integer in "dst", and store the
32-bit result back to tile "dst".

[algorithm]

DEFINE DPBD(c, x, y) {
    tmp1 := ZeroExtend32(x.byte[0]) * ZeroExtend32(y.byte[0])
    tmp2 := ZeroExtend32(x.byte[1]) * ZeroExtend32(y.byte[1])
    tmp3 := ZeroExtend32(x.byte[2]) * ZeroExtend32(y.byte[2])
    tmp4 := ZeroExtend32(x.byte[3]) * ZeroExtend32(y.byte[3])
    
    RETURN c + tmp1 + tmp2 + tmp3 + tmp4
}
FOR m := 0 TO dst.rows - 1
    tmp := dst.row[m]
    FOR k := 0 TO (a.colsb / 4) - 1
        FOR n := 0 TO (dst.colsb / 4) - 1
            tmp.dword[n] := DPBD(tmp.dword[n], a.row[m].dword[k], b.row[k].dword[n])
        ENDFOR
    ENDFOR
    write_row_and_zero(dst, m, tmp, dst.colsb)
ENDFOR
zero_upper_rows(dst, dst.rows)
zero_tileconfig_start()

--------------------------------------------------------------------------------------------------------------

## TDPBSSD - _tile_dpbssd

| TDPBSSD_TMMi32_TMMu32_TMMu32

--------------------------------------------------------------------------------------------------------------
Compute dot-product of bytes in tiles with a source/destination accumulator. Multiply groups of 4 adjacent
pairs of signed 8-bit integers in "a" with corresponding signed 8-bit integers in "b", producing 4 intermediate
32-bit results. Sum these 4 results with the corresponding 32-bit integer in "dst", and store the 32-bit result
back to tile "dst".

[algorithm]

DEFINE DPBD(c, x, y) {
    tmp1 := SignExtend32(x.byte[0]) * SignExtend32(y.byte[0])
    tmp2 := SignExtend32(x.byte[1]) * SignExtend32(y.byte[1])
    tmp3 := SignExtend32(x.byte[2]) * SignExtend32(y.byte[2])
    tmp4 := SignExtend32(x.byte[3]) * SignExtend32(y.byte[3])
    
    RETURN c + tmp1 + tmp2 + tmp3 + tmp4
}
FOR m := 0 TO dst.rows - 1
    tmp := dst.row[m]
    FOR k := 0 TO (a.colsb / 4) - 1
        FOR n := 0 TO (dst.colsb / 4) - 1
            tmp.dword[n] := DPBD(tmp.dword[n], a.row[m].dword[k], b.row[k].dword[n])
        ENDFOR
    ENDFOR
    write_row_and_zero(dst, m, tmp, dst.colsb)
ENDFOR
zero_upper_rows(dst, dst.rows)
zero_tileconfig_start()

--------------------------------------------------------------------------------------------------------------

## LDTILECFG - _tile_loadconfig

| LDTILECFG_MEM

--------------------------------------------------------------------------------------------------------------
Load tile configuration from a 64-byte memory location specified by "mem_addr". The tile configuration format
is specified below, and includes the tile type pallette, the number of bytes per row, and the number of rows.
If the specified pallette_id is zero, that signifies the init state for both the tile config and the tile data,
and the tiles are zeroed. Any invalid configurations will result in #GP fault.

[algorithm]

//    format of memory payload. each field is a byte.
//         0: palette_id
//         1: startRow (8b)
//     2-15: reserved (must be zero)
//    16-17: tile0.colsb -- bytes_per_row
//    18-19: tile1.colsb
//    20-21: tile2.colsb
//            ...
//    46-47: tile15.colsb
//        48: tile0.rows
//        49: tile1.rows
//        50: tile2.rows
//             ...
//        63: tile15.rows

--------------------------------------------------------------------------------------------------------------

## STTILECFG - _tile_storeconfig

| STTILECFG_MEM

--------------------------------------------------------------------------------------------------------------
Stores the current tile configuration to a 64-byte memory location specified by "mem_addr". The tile
configuration format is specified below, and includes the tile type pallette, the number of bytes per row, and
the number of rows. If tiles are not configured, all zeroes will be stored to memory.

[algorithm]

//    format of memory payload. each field is a byte.
//         0: palette_id
//         1: startRow (8b)
//     2-15: reserved (must be zero)
//    16-17: tile0.colsb -- bytes_per_row
//    18-19: tile1.colsb
//    20-21: tile2.colsb
//            ...
//    46-47: tile15.colsb
//        48: tile0.rows
//        49: tile1.rows
//        50: tile2.rows
//             ...
//        63: tile15.rows

--------------------------------------------------------------------------------------------------------------

## TILELOADD - _tile_loadd

| TILELOADD_TMMu32_MEMu32

--------------------------------------------------------------------------------------------------------------
Load tile rows from memory specifieid by "base" address and "stride" into destination tile "dst" using the
tile configuration previously configured via "_tile_loadconfig".

[algorithm]

start := tileconfig.startRow
IF start == 0 // not restarting, zero incoming state
    tilezero(dst)
FI
nbytes := dst.colsb
DO WHILE start &lt; dst.rows
    memptr := base + start * stride
    write_row_and_zero(dst, start, read_memory(memptr, nbytes), nbytes)
    start := start + 1
OD
zero_upper_rows(dst, dst.rows)
zero_tileconfig_start()

--------------------------------------------------------------------------------------------------------------

## TILELOADDT1 - _tile_stream_loadd

| TILELOADDT1_TMMu32_MEMu32

--------------------------------------------------------------------------------------------------------------
Load tile rows from memory specifieid by "base" address and "stride" into destination tile "dst" using the
tile configuration previously configured via "_tile_loadconfig". This intrinsic provides a hint to the
implementation that the data will likely not be reused in the near future and the data caching can be optimized
accordingly.

[algorithm]

start := tileconfig.startRow
IF start == 0 // not restarting, zero incoming state
    tilezero(dst)
FI
nbytes := dst.colsb
DO WHILE start &lt; dst.rows
    memptr := base + start * stride
    write_row_and_zero(dst, start, read_memory(memptr, nbytes), nbytes)
    start := start + 1
OD
zero_upper_rows(dst, dst.rows)
zero_tileconfig_start()

--------------------------------------------------------------------------------------------------------------

## TILERELEASE - _tile_release

| TILERELEASE

--------------------------------------------------------------------------------------------------------------
Release the tile configuration to return to the init state, which releases all storage it currently holds.

[missing]

--------------------------------------------------------------------------------------------------------------

## TILESTORED - _tile_stored

| TILESTORED_MEMu32_TMMu32

--------------------------------------------------------------------------------------------------------------
Store the tile specified by "src" to memory specifieid by "base" address and "stride" using the tile
configuration previously configured via "_tile_loadconfig".

[algorithm]

start := tileconfig.startRow
DO WHILE start &lt; src.rows
    memptr := base + start * stride
    write_memory(memptr, src.colsb, src.row[start])
    start := start + 1
OD
zero_tileconfig_start()

--------------------------------------------------------------------------------------------------------------

## TILEZERO - _tile_zero

| TILEZERO_TMMu32

--------------------------------------------------------------------------------------------------------------
Zero the tile specified by "tdest".

[algorithm]

nbytes := palette_table[tileconfig.palette_id].bytes_per_row
FOR i := 0 TO palette_table[tileconfig.palette_id].max_rows-1
    FOR j := 0 TO nbytes-1
        tdest.row[i].byte[j] := 0
    ENDFOR
ENDFOR

--------------------------------------------------------------------------------------------------------------
