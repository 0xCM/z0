# Vsib Addressing, AMD Vol4.1.3

Specific AVX2 instructions utilize a vectorized form of indexed register-indirect addressing called
vector SIB (VSIB) addressing. In contrast to the standard indexed register-indirect address mode,
which generates a single effective address to access a single memory operand, VSIB addressing gen-
erates an array of effective addresses which is used to access data from multiple memory locations in
a single operation.

VSIB addressing is encoded using three or six bytes following the opcode byte, augmented by the X
and B bits from the VEX prefix. The first byte is the ModRM byte with the standard mod, reg, and
r/m fields (although allowed values for the mod and r/m fields are restricted). The second is the VSIB
byte which replaces the SIB byte in the encoding. The VSIB byte specifies a GPR which serves as a
base address register and an XMM/YMM register that contains a packed array of index values. The
two-bit scale field specifies a common scaling factor to be applied to all of the index values. A con-
stant displacement value is encoded in the one or four bytes that follow the VSIB byte.

VSIB:=[SS:[7 6] | index:[5 4 3] | base:[2 1 0]]

VSIB.SS (Bits [7:6]). The SS field is used to specify the scale factor to be used in the computation
of each of the effective addresses. The scale factor scale is equal to 2SS (two raised to power of the
value of the SS field). Therefore, if SS = 00b, scale = 1; if SS = 01b, scale = 2; if SS = 10b, scale = 4;
and if SS = 11b, scale = 8.

VSIB.index (Bits [5:3]). This field is concatenated with the complement of the VEX.X bit ({X,
index}) to specify the YMM/XMM register that contains the packed array of index values index[i] to
be used in the computation of the array of effective addresses effective address[i].

VSIB.base (Bits [2:0]). This field is concatenated with the complement of the VEX.B bit ({B,
base}) to specify the general-purpose register (base GPR) that contains the base address base to be
used in the computation of each of the effective addresses.

## Effective Address Array Computation

Each element i of the effective address array is computed using the formula:
effective address[i] = scale * index[i] + base + displacement.
Where,
* index[i] is the ith element of the XMM/YMM register specified by {X,VSIB.index}.
* An index element is either 32 or 64 bits wide and is treated as a signed integer.
* Variants of this mode use either an eight-bit or a 32-bit displacement value.
* One variant sets the base to zero.
* The value of the ModRM.mod field specifies the specific variant of VSIB addressing mode, as shown in [Table1]('./vsib.csv)
* In the table, the notation [XMMn/YMMn] indicates the XMM/YMM register that contains the packed index array and
[base GPR] means the contents of the base GPR selected by {B, base}.
