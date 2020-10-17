# DUMPBIN

## Usage Summary

usage: DUMPBIN [options] [files]

   options:

      /ALL
      /ARCHIVEMEMBERS
      /CLRHEADER
      /DEPENDENTS
      /DIRECTIVES
      /DISASM[:{BYTES|NOBYTES}]
      /ERRORREPORT:{NONE|PROMPT|QUEUE|SEND}
      /EXPORTS
      /FPO
      /HEADERS
      /IMPORTS[:filename]
      /LINENUMBERS
      /LINKERMEMBER[:{1|2}]
      /LOADCONFIG
      /NOLOGO
      /NOPDB
      /OUT:filename
      /PDATA
      /PDBPATH[:VERBOSE]
      /RANGE:vaMin[,vaMax]
      /RAWDATA[:{NONE|1|2|4|8}[,#]]
      /RELOCATIONS
      /SECTION:name
      /SUMMARY
      /SYMBOLS
      /TLS
      /UNWINDINFO

## ALL
-------------------------------------------------------------------------------------------------

This option displays all available information except code disassembly. Use /DISASM to display 
disassembly. You can use /RAWDATA:NONE with /ALL to omit the raw binary details of the file.

## ARCHIVEMEMBERS
-------------------------------------------------------------------------------------------------
This option displays minimal information about member objects in a library.

## CLRHEADER file
-------------------------------------------------------------------------------------------------
Display CLR-specific information.

## Arguments

### file
An image file built with /clr.

### Remarks
/CLRHEADER displays information about the .NET headers used in any managed program. The output 
shows the location and size, in bytes, of the .NET header and sections in the header.

When /CLRHEADER is used on a file that was compiled with /clr, there will be a clr Header: section 
in the dumpbin output. The value of flags indicates which /clr option was used:

0 -- /clr (image may contain native code).
You can also programmatically check if an image was built for the common language runtime. 

The /clr:pure and /clr:safe compiler options are deprecated in Visual Studio 2015 and unsupported 
in Visual Studio 2017 and later. Code that must be "pure" or "safe" should be ported to C#.

## DEPENDENTS
-------------------------------------------------------------------------------------------------
This option applies to all the executable files specified on the command line. It doesn't take 
any arguments.

Remarks
The /DEPENDENTS option adds the names of the DLLs from which the image imports functions to the 
output. This option does not dump the names of the imported functions. To see the names of the 
imported functions, use the /IMPORTS option.

Only the /HEADERS DUMPBIN option is available for use on files produced with the /GL compiler option.

## DIRECTIVES
-------------------------------------------------------------------------------------------------
This option dumps the compiler-generated .drective section of an image.

Only the /HEADERS DUMPBIN option is available for use on files produced with the /GL compiler option.

## DISASM[:{BYTES|NOBYTES}]
-------------------------------------------------------------------------------------------------

### Arguments
-------------------------------------------------------------------------------------------------
#### BYTES

Includes the instruction bytes together with the interpreted opcodes and arguments in the disassembly 
output. This is the default option.

#### NOBYTES
Does not include the instruction bytes in the disassembly output.

### Remarks
-------------------------------------------------------------------------------------------------
The /DISASM option displays disassembly of code sections in the file. It uses debug symbols if 
they are present in the file.

/DISASM should only be used on native, not managed, images. The equivalent tool for managed 
code is ILDASM.

Only the /HEADERS DUMPBIN option is available for use on files produced by the /GL 
(Whole program optimization) compiler option.

## EXPORTS
-------------------------------------------------------------------------------------------------
This option displays all definitions exported from an executable file or DLL.

## FPO
-------------------------------------------------------------------------------------------------
This option displays frame pointer optimization (FPO) records.

# HEADERS
-------------------------------------------------------------------------------------------------
This option displays the file header and the header for each section. When used with a library, 
it displays the header for each member object.

# IMPORTS[:filename]
-------------------------------------------------------------------------------------------------
This option displays the list of DLLs (both statically linked and delay loaded) that are imported 
to an executable file or DLL and all the individual imports from each of these DLLs.

The optional file specification allows you to specify that the imports for only that DLL will 
be displayed. For example, dumpbin /IMPORTS:msvcrt.dll

## LINENUMBERS
-------------------------------------------------------------------------------------------------
This option displays COFF line numbers. Line numbers exist in an object file if it was compiled 
with Program Database (/Zi), C7 Compatible (/Z7), or Line Numbers Only (/Zd). An executable file 
or DLL contains COFF line numbers if it was linked with Generate Debug Info (/DEBUG).

# LINKERMEMBER[:{1|2}]
-------------------------------------------------------------------------------------------------
This option displays public symbols defined in a library. Specify the 1 argument to display 
symbols in object order, along with their offsets. Specify the 2 argument to display offsets 
and index numbers of objects, and then list the symbols in alphabetical order, along with the 
object index for each. To get both outputs, specify /LINKERMEMBER without the number argument.

## LOADCONFIG
-------------------------------------------------------------------------------------------------
This option dumps the IMAGE_LOAD_CONFIG_DIRECTORY structure, an optional structure that is used 
by the Windows NT loader and defined in WINNT.H.

## NOLOGO
-------------------------------------------------------------------------------------------------

## NOPDB
-------------------------------------------------------------------------------------------------
By default, DUMPBIN attempts to load PDB files for its target executables. DUMPBIN uses this 
information to match addresses to symbol names. The process can be time-consuming if the PDB files 
are large, or must be loaded from a remote server. The /NOPDB option tells DUMPBIN to skip this 
step. It only prints the addresses and symbol information available in the executable.

## OUT:filename
-------------------------------------------------------------------------------------------------

## PDBPATH[:VERBOSE]
-------------------------------------------------------------------------------------------------
/PDBPATH will search your computer along the same paths that the debugger would search for a .pdb 
file and will report which, if any, .pdb files correspond to the file specified in filename.

When using the Visual Studio debugger, you may experience a problem due to the fact that the 
debugger is using a .pdb file for a different version of the file you are debugging.

### Parameters

#### filename

The name of the .dll or .exe file for which you want to find the matching .pdb file.

#### VERBOSE

Reports all directories where an attempt was made to locate the .pdb file.

### Remarks

/PDBPATH will search for .pdb files along the following paths:

* Check the location where the executable resides.
* Check the location of the PDB written into the executable. This is usually the location at the time the image was linked.
* Check along the search path configured in the Visual Studio IDE.
* Check along the paths in the _NT_SYMBOL_PATH and _NT_ALT_SYMBOL_PATH environment variables.
* Check in the Windows directory.

## RANGE:vaMin[,vaMax]
-------------------------------------------------------------------------------------------------

Modifies the output of dumpbin when used with other dumpbin options, such as /RAWDATA or /DISASM.

### Parameters

#### vaMin

The virtual address at which you want the dumpbin operation to begin.

#### vaMax

The virtual address at which you want the dumpbin operation to end. If not specified, dumpbin 
will go to the end of the file.

### Remarks

To see the virtual addresses for an image, use the map file for the image (RVA + Base), the 
/DISASM or /HEADERS option of dumpbin, or the disassembly window in the Visual Studio debugger.

### Example
In this example, /range is used to modify the display of the /disasm option. In this example, 
the starting value is expressed as a decimal number and the ending value is specified as a hex 
number.

dumpbin /disasm /range:4219334,0x004061CD t.exe

## RAWDATA[:{NONE|1|2|4|8}[,#]]
-------------------------------------------------------------------------------------------------
This option displays the raw contents of each section in the file

| Argument | Result                                                                                                                        |
| 1        | The default. Contents are displayed in hexadecimal bytes, and also as ASCII characters if they have a printed representation. |
| 2        | Contents are displayed as hexadecimal 2-byte values.                                                                          |
| 4        | Contents are displayed as hexadecimal 4-byte values.                                                                          |
| 8        | Contents are displayed as hexadecimal 8-byte values.                                                                          |
| NONE     | Raw data is suppressed. This argument is useful to control the output of /ALL.                                                |
| Number   | Displayed lines are set to a width that holds number values per line.                                                         |

## RELOCATIONS
-------------------------------------------------------------------------------------------------
This option displays any relocations in the object or image.

## SECTION:name
-------------------------------------------------------------------------------------------------
This option restricts the output to information on the specified section. Use the /HEADERS 
option to get a list of sections in the file.

## SUMMARY
-------------------------------------------------------------------------------------------------
This option displays minimal information about sections, including total size. This option 
is the default if no other option is specified.

## SYMBOLS
-------------------------------------------------------------------------------------------------
This option displays the COFF symbol table. Symbol tables exist in all object files. 
A COFF symbol table appears in an image file only if it is linked with /DEBUG.

The following description, for lines that begin with a symbol number, describes columns that have 
information relevant to users:

* The first three-digit number is the symbol index/number.
* If the third column contains SECTx, the symbol is defined in that section of the object file. 
   But if UNDEF appears, it is not defined in that object and must be resolved elsewhere.
* The fifth column (Static, External) tells whether the symbol is visible only within that object, 
  or whether it is public (visible externally). A Static symbol, _sym, wouldn't be linked to a Public 
  symbol _sym; these would be two different instances of functions named _sym.
* The last column in a numbered line is the symbol name, both decorated and undecorated.

## TLS
-------------------------------------------------------------------------------------------------
Displays the IMAGE_TLS_DIRECTORY structure from an executable.

### Remarks

/TLS displays the fields of the TLS structure as well as the addresses of the TLS callback functions.
If a program does not use thread local storage, its image will not contain a TLS structure. 
See thread for more information. IMAGE_TLS_DIRECTORY is defined in winnt.h.
