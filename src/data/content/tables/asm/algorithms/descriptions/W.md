# W

## WRSSD - _wrssd

| WRSSD_MEMu32_GPR32u32

--------------------------------------------------------------------------------------------------------------
Write 32-bit value in "val" to a shadow stack page in memory specified by "p".

[missing]

--------------------------------------------------------------------------------------------------------------

## WRSSQ - _wrssq

| WRSSQ_MEMu64_GPR64u64

--------------------------------------------------------------------------------------------------------------
Write 64-bit value in "val" to a shadow stack page in memory specified by "p".

[missing]

--------------------------------------------------------------------------------------------------------------

## WRUSSD - _wrussd

| WRUSSD_MEMu32_GPR32u32

--------------------------------------------------------------------------------------------------------------
Write 32-bit value in "val" to a user shadow stack page in memory specified by "p".

[missing]

--------------------------------------------------------------------------------------------------------------

## WRUSSQ - _wrussq

| WRUSSQ_MEMu64_GPR64u64

--------------------------------------------------------------------------------------------------------------
Write 64-bit value in "val" to a user shadow stack page in memory specified by "p".

[missing]

--------------------------------------------------------------------------------------------------------------

## WRFSBASE - _writefsbase_u32

| WRFSBASE_GPRy

--------------------------------------------------------------------------------------------------------------
Write the unsigned 32-bit integer "a" to the FS segment base register.

[algorithm]

FS_Segment_Base_Register[31:0] := a[31:0]
FS_Segment_Base_Register[63:32] := 0

--------------------------------------------------------------------------------------------------------------

## WRFSBASE - _writefsbase_u64

| WRFSBASE_GPRy

--------------------------------------------------------------------------------------------------------------
Write the unsigned 64-bit integer "a" to the FS segment base register.

[algorithm]

FS_Segment_Base_Register[63:0] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## WRGSBASE - _writegsbase_u32

| WRGSBASE_GPRy

--------------------------------------------------------------------------------------------------------------
Write the unsigned 32-bit integer "a" to the GS segment base register.

[algorithm]

GS_Segment_Base_Register[31:0] := a[31:0]
GS_Segment_Base_Register[63:32] := 0

--------------------------------------------------------------------------------------------------------------

## WRGSBASE - _writegsbase_u64

| WRGSBASE_GPRy

--------------------------------------------------------------------------------------------------------------
Write the unsigned 64-bit integer "a" to the GS segment base register.

[algorithm]

GS_Segment_Base_Register[63:0] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## WBINVD - _wbinvd

| WBINVD

--------------------------------------------------------------------------------------------------------------
Write back and flush internal caches.
		Initiate writing-back and flushing of external
		caches.

[missing]

--------------------------------------------------------------------------------------------------------------

## WBNOINVD - _wbnoinvd

| WBNOINVD

--------------------------------------------------------------------------------------------------------------
Write back and do not flush internal caches.
		Initiate writing-back without flushing of external
		caches.

[missing]

--------------------------------------------------------------------------------------------------------------
