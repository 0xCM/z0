## MINIDUMP_HEADER

<https://docs.microsoft.com/en-us/windows/win32/api/minidumpapiset/ns-minidumpapiset-minidump_header>

### Signature

The signature. Set this member to MINIDUMP_SIGNATURE.

### Version

The version of the minidump format. The low-order word is MINIDUMP_VERSION. The high-order word is an internal value that is implementation specific.

### NumberOfStreams

The number of streams in the minidump directory.

### StreamDirectoryRva

The base RVA of the minidump directory. The directory is an array of MINIDUMP_DIRECTORY structures.

### CheckSum

The checksum for the minidump file. This member can be zero.

### Reserved

This member is reserved.

### TimeDateStamp

Time and date, in time_t format.

### Flags

One or more values from the MINIDUMP_TYPE enumeration type.


## MINIDUMP_FUNCTION_TABLE_STREAM

<https://docs.microsoft.com/en-us/windows/win32/api/minidumpapiset/ns-minidumpapiset-minidump_function_table_stream>

### SizeOfHeader

The size of header information for the stream, in bytes. This value is sizeof(MINIDUMP_FUNCTION_TABLE_STREAM).

### SizeOfDescriptor

The size of a descriptor in the stream, in bytes. This value is sizeof(MINIDUMP_FUNCTION_TABLE_DESCRIPTOR).

### SizeOfNativeDescriptor

The size of a raw system descriptor in the stream, in bytes. This value depends on the particular platform and system version on which the minidump was generated.

### SizeOfFunctionEntry

The size of a raw system function table entry, in bytes. This value depends on the particular platform and system version on which the minidump was generated.

### NumberOfDescriptors

The number of descriptors in the stream.

### SizeOfAlignPad

The size of alignment padding that follows the header, in bytes.

Remarks
In this context, a data stream is a set of data in a minidump file. This header structure is followed by NumberOfDescriptors function tables. For each function table there is a MINIDUMP_FUNCTION_TABLE_DESCRIPTOR structure, then the raw system descriptor for the table, then the raw system function entry data. If necessary, alignment padding is placed between tables to properly align the initial structures.