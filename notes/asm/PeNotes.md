# PeNotes

## COFF_HEADER
Every image file has an optional header that provides information to the loader. This header is optional in the 
sense that some files (specifically, object files) do not have it. For image files, this header is required. 
An object file can have an optional header, but generally this header has no function in an object file except 
to increase its size.

Note that the size of the optional header is not fixed. The SizeOfOptionalHeader field in the COFF header must 
be used to validate that a probe into the file for a particular data directory does not go beyond 
SizeOfOptionalHeader. For more information, see COFF File Header (Object and Image).

The NumberOfRvaAndSizes field of the optional header should also be used to ensure that no probe for a 
particular data directory entry goes beyond the optional header. In addition, it is important to validate the 
optional header magic number for format compatibility.

The optional header magic number determines whether an image is a PE32 or PE32+ executable.
The first eight fields of the optional header are standard fields that are defined for every implementation 
of COFF. These fields contain general information that is useful for loading and running an executable file. 
They are unchanged for the PE32+ format.

## COFF_SYMBOL_TABLE

The symbol table in this section is inherited from the traditional COFF format. It is distinct from Microsoft Visual 
C++ debug information. A file can contain both a COFF symbol table and Visual C++ debug information, 
and the two are kept separate. Some Microsoft tools use the symbol table for limited but important purposes, 
such as communicating COMDAT information to the linker. Section names and file names, as well as code and data 
symbols, are listed in the symbol table.

The location of the symbol table is indicated in the COFF header.

The symbol table is an array of records, each 18 bytes long. Each record is either a standard or auxiliary 
symbol-table record. A standard record defines a symbol or name and has the following format.

## IMAGE_RESOURCE_DIRECTORY_ENTRY

The directory entries make up the rows of a table. Each resource directory entry has the following format. 
Whether the entry is a Name or ID entry is indicated by the resource directory table, which indicates how 
many Name and ID entries follow it (remember that all the Name entries precede all the ID entries for the table). 
All entries for the table are sorted in ascending order: the Name entries by case-sensitive string and the 
ID entries by numeric value. Offsets are relative to the address in the IMAGE_DIRECTORY_ENTRY_RESOURCE 
DataDirectory. See Peering Inside the PE: A Tour of the Win32 Portable Executable File Format for more information.

## IMAGE_SECTION_HEADER

Each row of the section table is, in effect, a section header. This table immediately follows 
the optional header, if any. This positioning is required because the file header does not 
contain a direct pointer to the section table. Instead, the location of the section table is determined 
by calculating the location of the first byte after the headers. Make sure to use the size of the optional
 header as specified in the file header.

The number of entries in the section table is given by the NumberOfSections field in the file header. 
Entries in the section table are numbered starting from one (1). The code and data memory section entries are 
in the order chosen by the linker.

In an image file, the VAs for sections must be assigned by the linker so that they are in ascending order and 
adjacent, and they must be a multiple of the SectionAlignment value in the optional header.

Each section header (section table entry) has the following format, for a total of 40 bytes per entry.

## IMAGE_LOAD_CONFIG_DIRECTORY

The load configuration structure (IMAGE_LOAD_CONFIG_DIRECTORY) was formerly used in very limited cases in the 
Windows NT operating system itself to describe various features too difficult or too large to describe in the 
file header or optional header of the image. Current versions of the Microsoft linker and Windows XP and later 
versions of Windows use a new version of this structure for 32-bit x86-based systems that include reserved SEH 
technology. This provides a list of safe structured exception handlers that the operating system uses during 
exception dispatching. If the handler address resides in an image's VA range and is marked as reserved SEH-aware 
(that is, IMAGE_DLLCHARACTERISTICS_NO_SEH is clear in the DllCharacteristics field of the optional header, 
as described earlier), then the handler must be in the list of known safe handlers for that image. Otherwise, 
the operating system terminates the application. This helps prevent the "x86 exception handler hijacking" 
exploit that has been used in the past to take control of the operating system.

The Microsoft linker automatically provides a default load configuration structure to include the reserved 
SEH data. If the user code already provides a load configuration structure, it must include the new reserved
SEH fields. Otherwise, the linker cannot include the reserved SEH data and the image is not marked as containing 
reserved SEH.

The data directory entry for a pre-reserved SEH load configuration structure must specify a particular 
size of the load configuration structure because the operating system loader always expects it to be a 
certain value. In that regard, the size is really only a version check. For compatibility with Windows 
XP and earlier versions of Windows, the size must be 64 for x86 images.

## .rsrc 

Resources are indexed by a multiple-level binary-sorted tree structure. The general design can incorporate 
2**31 levels. By convention, however, Windows uses three levels:

Type Name Language
A series of resource directory tables relates all of the levels in the following way: 
Each directory table is followed by a series of directory entries that give the name or identifier (ID) 
for that level (Type, Name, or Language level) and an address of either a data description or another 
directory table. If the address points to a data description, then the data is a leaf in the tree. 
If the address points to another directory table, then that table lists directory entries at the next 
level down.

A leaf's Type, Name, and Language IDs are determined by the path that is taken through directory tables to 
reach the leaf. The first table determines Type ID, the second table (pointed to by the directory entry in 
the first table) determines Name ID, and the third table determines Language ID.

## OptionalHeaderDataDirectories

Each data directory gives the address and size of a table or string that Windows uses. These data directory entries 
are all loaded into memory so that the system can use them at run time. A data directory is an 8-byte field 
that has the following declaration:

typedef struct _IMAGE_DATA_DIRECTORY {
    DWORD   VirtualAddress;
    DWORD   Size;
} IMAGE_DATA_DIRECTORY, *PIMAGE_DATA_DIRECTORY;

The first field, VirtualAddress, is actually the RVA of the table. The RVA is the address of the table relative 
to the base address of the image when the table is loaded. The second field gives the size in bytes. The data 
directories, which form the last part of the optional header, are listed in the following table.

Note that the number of directories is not fixed. Before looking for a specific directory, check the 
NumberOfRvaAndSizes field in the optional header.

Also, do not assume that the RVAs in this table point to the beginning of a section or that the sections that contain 
specific tables have specific names.
