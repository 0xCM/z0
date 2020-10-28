# symstore:<https://github.com/MicrosoftDocs/win32/blob/docs/desktop-src/Debug/using-symstore.md>

## Using SymStore
SymStore (symstore.exe) is a tool for creating symbol stores. It is included in the Debugging Tools for Windows package.

SymStore stores symbols in a format that enables the debugger to look up the symbols based on the time stamp and size of
the image (for a .dbg or executable file), or signature and age (for a .pdb file). The advantage of the symbol store over
the traditional symbol storage format is that all symbols can be stored or referenced on the same server and retrieved by
the debugger without any prior knowledge of which product contains the corresponding symbol.

Note that multiple versions of .pdb symbol files (for example, public and private versions) cannot be stored on the same server,
because they each contain the same signature and age.

## SymStore Transactions
Every call to SymStore is recorded as a transaction. There are two types of transactions: add and delete.

When the symbol store is created, a directory, called "000admin", is created under the root of the server. The 000admin directory
contains one file for each transaction, as well as the log files Server.txt and History.txt. The Server.txt file contains a list
of all transactions that are currently on the server. The History.txt file contains a chronological history of all transactions.

Each time SymStore stores or removes symbol files, a new transaction number is created. Then, a file, whose name is this
transaction number, is created in 000admin. This file contains a list of all the files or pointers that have been added
to the symbol store during this transaction. If a transaction is deleted, SymStore will read through its transaction file to determine
which files and pointers it should delete.

The add and del options specify whether an add or delete transaction is to be performed. Including the /p option with an add operation
specifies that a pointer is to be added; omitting the /p option specifies that the actual symbol file is to be added.

It is also possible to create the symbol store in two separate stages. In the first stage, you use SymStore with the /x option to
create an index file. In the second stage, you use SymStore with the /y option to create the actual store of files or pointers
from the information in the index file.

This can be a useful technique for a variety of reasons. For instance, this allows the symbol store to be easily recreated if the
store is somehow lost, as long as the index file still exists. Or perhaps the computer containing the symbol files has a slow network
connection to the computer on which the symbol store will be created. In this case, you can create the index file on the same machine
as the symbol files, transfer the index file to the second machine, and then create the store on the second machine.

For a full listing of all SymStore parameters, see SymStore Command-Line Options.

[!Note]
SymStore does not support simultaneous transactions from multiple users. It is recommended that one user be designated "administrator" of the symbol store and be responsible for all add and del transactions.

Transaction Examples
Here are two examples of SymStore adding symbol pointers for build 3790 of Windows Server 2003 to \\sampledir\symsrv:

symstore add /r /p /f \\BuildServer\BuildShare\3790free\symbols\*.*
   /s \\sampledir\symsrv /t "Windows Server 2003" /v "Build 3790 x86 free"
   /c "Sample add"
symstore add /r /p /f \\BuildServer\BuildShare\3790Chk\symbols\*.*
   /s \\sampledir\symsrv /t "Windows Server 2003" /v "Build 3790 x86 checked"
   /c "Sample add"

In the following example, SymStore adds the actual symbol files for an application project in \\largeapp\appserver\bins to \\testdir\symsrv:

symstore add /r /f \\largeapp\appserver\bins\*.* /s \\testdir\symsrv
   /t "Large Application" /v "Build 432" /c "Sample add"

Here is an example of how an index file is used. First, SymStore creates an index file based on the collection of symbol files in \\largeapp\appserver\bins\. In this case, the index file is placed on a third computer, \\hubserver\hubshare. You use the /g option to specify that the file prefix "\\largeapp\appserver" might change in the future:

symstore add /r /p /g \\largeapp\appserver /f \\largeapp\appserver\bins\*.* /x \\hubserver\hubshare\myindex.txt



Now suppose you move all the symbol files off of the machine \\largeapp\appserver and put them on \\myarchive\appserver. You can then create the symbol store itself from the index file \\hubserver\hubshare\myindex.txt as follows:

symstore add /y \\hubserver\hubshare\myindex.txt
   /g \\myarchive\appserver /s \\sampledir\symsrv /p
   /t "Large Application" /v "Build 432" /c "Sample Add from Index"

Finally, here is an example of SymStore deleting a file added by a previous transaction. See the following section for an explanation of how to determine the transaction ID (in this case, 0000000096).

symstore del /i 0000000096 /s \\sampledir\symsrv

## Compressed Files

SymStore can be used with compressed files in two different ways.

Use SymStore with the /p option to store pointers to the symbol files. After SymStore finishes, compress the files that the pointers refer to.
Use SymStore with the /x option to create an index file. After SymStore finishes, compress the files listed in the index file. Then use SymStore with the /y option (and, if you wish, the /p option) to store the files or pointers to the files in the symbol store. (SymStore will not need to uncompress the files to perform this operation.)
Your symbol server will be responsible for uncompressing the files when they are needed.

If you are using SymSrv as your symbol server, any compression should be done using the compress.exe tool that is distributed with the Microsoft Windows Software Development Kit (SDK). Compressed files should have an underscore as the last character in their file extensions (for example, module1.pd_ or module2.db_). For details, see Using SymSrv.

The server.txt and history.txt Files
When a transaction is added, several items of information are added to server.txt and history.txt for future lookup capability. The following is an example of a line in server.txt and history.txt for an add transaction:

0000000096,add,ptr,10/09/99,00:08:32,Windows XP,x86 fre 1.156c-RTM-2,Added from \\mybuilds\symbols,
This is a comma-separated line. The fields are defined as follows.

Field	Description
0000000096	Transaction ID number, as created by SymStore.
add	Type of transaction. This field can be either add or del.
ptr	Whether files or pointers were added. This field can be either file or ptr.
10/09/99	Date when transaction occurred.
00:08:32	Time when transaction started.
Windows XP	Product.
x86 fre	Version (optional).
Added from	Comment (optional)
Unused	(Reserved for later use.)


Here are some sample lines from the transaction file 0000000096. Each line records the directory and the location of the file or pointer that was added to the directory.

canon800.dbg\35d9fd51b000,\\mybuilds\symbols\sp4\dll\canon800.dbg
canonlbp.dbg\35d9fd521c000,\\mybuilds\symbols\sp4\dll\canonlbp.dbg
certadm.dbg\352bf2f48000,\\mybuilds\symbols\sp4\dll\certadm.dbg
certcli.dbg\352bf2f1b000,\\mybuilds\symbols\sp4\dll\certcli.dbg
certcrpt.dbg\352bf04911000,\\mybuilds\symbols\sp4\dll\certcrpt.dbg
certenc.dbg\352bf2f7f000,\\mybuilds\symbols\sp4\dll\certenc.dbg
If you use a del transaction to undo the original add transactions, these lines will be removed from server.txt, and the following line will be added to history.txt:

0000000105,del,0000000096
The fields for the delete transaction are defined as follows.

Field	Description
0000000105	Transaction ID number, as created by SymStore.
del	Type of transaction. This field can be either add or del.
0000000096	Transaction that was deleted.


Symbol Storage Format
SymStore uses the file system itself as a database. It creates a large tree of directories, with directory names based on such things as the symbol file time stamps, signatures, age, and other data.

For example, after several different acpi.dbg files have been added to the server, the directories could look like this:

Directory of \\mybuilds\symsrv\acpi.dbg
10/06/1999  05:46p      <DIR>          .
10/06/1999  05:46p      <DIR>          ..
10/04/1999  01:54p      <DIR>          37cdb03962040
10/04/1999  01:49p      <DIR>          37cdb04027740
10/04/1999  12:56p      <DIR>          37e3eb1c62060
10/04/1999  12:51p      <DIR>          37e3ebcc27760
10/04/1999  12:45p      <DIR>          37ed151662060
10/04/1999  12:39p      <DIR>          37ed15dd27760
10/04/1999  11:33a      <DIR>          37f03ce962020
10/04/1999  11:21a      <DIR>          37f03cf7277c0
10/06/1999  05:38p      <DIR>          37fa7f00277e0
10/06/1999  05:46p      <DIR>          37fa7f01620a0
In this example, the lookup path for the acpi.dbg symbol file might look something like this: \\mybuilds\symsrv\acpi.dbg\37cdb03962040.

Three files may exist inside the lookup directory:

If the file was stored, then acpi.dbg will exist there.
If a pointer was stored, then a file called file.ptr will exist and contain the path to the actual symbol file.
A file called refs.ptr, which contains a list of all the current locations for acpi.dbg with this timestamp and image size that are currently added to the symbol store.
Displaying the directory listing of \\mybuilds\symsrv\acpi.dbg\37cdb03962040 gives the following:

10/04/1999  01:54p                  52 file.ptr
10/04/1999  01:54p                  67 refs.ptr
The file file.ptr contains the text string "\\mybuilds\symbols\x86\2128.chk\symbols\sys\acpi.dbg". Since there is no file called acpi.dbg in this directory, the debugger will try to find the file at \\mybuilds\symbols\x86\2128.chk\symbols\sys\acpi.dbg.

The contents of refs.ptr are used only by SymStore, not the debugger. This file contains a record of all transactions that have taken place in this directory. A sample line from refs.ptr might be:

0000000026,ptr,\\mybuilds\symbols\x86\2128.chk\symbols\sys\acpi.dbg
This shows that a pointer to \\mybuilds\symbols\x86\2128.chk\symbols\sys\acpi.dbg was added with transaction "0000000026".

Some symbol files stay constant through various products or builds or a particular product. One example of this is the file msvcrt.pdb. Doing a directory of \\mybuilds\symsrv\msvcrt.pdb shows that only two versions of msvcrt.pdb have been added to the symbols server:

Directory of \\mybuilds\symsrv\msvcrt.pdb
10/06/1999  05:37p      <DIR>          .
10/06/1999  05:37p      <DIR>          ..
10/04/1999  11:19a      <DIR>          37a8f40e2
10/06/1999  05:37p      <DIR>          37f2c2272
However, doing a directory of \\mybuilds\symsrv\msvcrt.pdb\37a8f40e2 shows that refs.ptr has several pointers in it.

Directory of \\mybuilds\symsrv\msvcrt.pdb\37a8f40e2
10/05/1999  02:50p              54     file.ptr
10/05/1999  02:50p           2,039     refs.ptr
The contents of \\mybuilds\symsrv\msvcrt.pdb\37a8f40e2\refs.ptr are the following:

0000000001,ptr,\\mybuilds\symbols\x86\2137\symbols\dll\msvcrt.pdb
0000000002,ptr,\\mybuilds\symbols\x86\2137.chk\symbols\dll\msvcrt.pdb
0000000003,ptr,\\mybuilds\symbols\x86\2138\symbols\dll\msvcrt.pdb
0000000004,ptr,\\mybuilds\symbols\x86\2138.chk\symbols\dll\msvcrt.pdb
0000000005,ptr,\\mybuilds\symbols\x86\2139\symbols\dll\msvcrt.pdb
0000000006,ptr,\\mybuilds\symbols\x86\2139.chk\symbols\dll\msvcrt.pdb
0000000007,ptr,\\mybuilds\symbols\x86\2140\symbols\dll\msvcrt.pdb
0000000008,ptr,\\mybuilds\symbols\x86\2140.chk\symbols\dll\msvcrt.pdb
0000000009,ptr,\\mybuilds\symbols\x86\2136\symbols\dll\msvcrt.pdb
0000000010,ptr,\\mybuilds\symbols\x86\2136.chk\symbols\dll\msvcrt.pdb
0000000011,ptr,\\mybuilds\symbols\x86\2135\symbols\dll\msvcrt.pdb
0000000012,ptr,\\mybuilds\symbols\x86\2135.chk\symbols\dll\msvcrt.pdb
0000000013,ptr,\\mybuilds\symbols\x86\2134\symbols\dll\msvcrt.pdb
0000000014,ptr,\\mybuilds\symbols\x86\2134.chk\symbols\dll\msvcrt.pdb
0000000015,ptr,\\mybuilds\symbols\x86\2133\symbols\dll\msvcrt.pdb
0000000016,ptr,\\mybuilds\symbols\x86\2133.chk\symbols\dll\msvcrt.pdb
0000000017,ptr,\\mybuilds\symbols\x86\2132\symbols\dll\msvcrt.pdb
0000000018,ptr,\\mybuilds\symbols\x86\2132.chk\symbols\dll\msvcrt.pdb
0000000019,ptr,\\mybuilds\symbols\x86\2131\symbols\dll\msvcrt.pdb
0000000020,ptr,\\mybuilds\symbols\x86\2131.chk\symbols\dll\msvcrt.pdb
0000000021,ptr,\\mybuilds\symbols\x86\2130\symbols\dll\msvcrt.pdb
0000000022,ptr,\\mybuilds\symbols\x86\2130.chk\symbols\dll\msvcrt.pdb
0000000023,ptr,\\mybuilds\symbols\x86\2129\symbols\dll\msvcrt.pdb
0000000024,ptr,\\mybuilds\symbols\x86\2129.chk\symbols\dll\msvcrt.pdb
0000000025,ptr,\\mybuilds\symbols\x86\2128\symbols\dll\msvcrt.pdb
0000000026,ptr,\\mybuilds\symbols\x86\2128.chk\symbols\dll\msvcrt.pdb
0000000027,ptr,\\mybuilds\symbols\x86\2141\symbols\dll\msvcrt.pdb
0000000028,ptr,\\mybuilds\symbols\x86\2141.chk\symbols\dll\msvcrt.pdb
0000000029,ptr,\\mybuilds\symbols\x86\2142\symbols\dll\msvcrt.pdb
0000000030,ptr,\\mybuilds\symbols\x86\2142.chk\symbols\dll\msvcrt.pdb
This shows that the same msvcrt.pdb was used for multiple builds of symbols stored on \\mybuilds\symsrv.

Here is an example of a directory that contains a mixture of file and pointer additions:

Directory of E:\symsrv\dbghelp.dbg\38039ff439000
10/12/1999  01:54p         141,232     dbghelp.dbg
10/13/1999  04:57p              49     file.ptr
10/13/1999  04:57p             306     refs.ptr
In this case, refs.ptr has the following contents:

0000000043,file,e:\binaries\symbols\retail\dll\dbghelp.dbg
0000000044,file,f:\binaries\symbols\retail\dll\dbghelp.dbg
0000000045,file,g:\binaries\symbols\retail\dll\dbghelp.dbg
0000000046,ptr,\\sampledir\bin\symbols\retail\dll\dbghelp.dbg
0000000047,ptr,\\sampledir2\bin\symbols\retail\dll\dbghelp.dbg
Thus, transactions 43, 44, and 45 added the same file to the server, and transactions 46 and 47 added pointers. If transactions 43, 44, and 45 are deleted, then the file dbghelp.dbg will be deleted from the directory. The directory will then have the following contents:

Directory of e:\symsrv\dbghelp.dbg\38039ff439000
10/13/1999  05:01p                   49 file.ptr
10/13/1999  05:01p                 130 refs.ptr
Now file.ptr contains "\\sampledir2\bin\symbols\retail\dll\dbghelp.dbg", and refs.ptr contains

0000000046,ptr,\\sampledir\bin\symbols\retail\dll\dbghelp.dbg
0000000047,ptr,\\sampledir2\bin\symbols\retail\dll\dbghelp.dbg
Whenever the final entry in refs.ptr is a pointer, the file file.ptr will exist and contain the path to the associated file. Whenever the final entry in refs.ptr is a file, no file.ptr will exist in this directory. Therefore, any delete operation that removes the final entry in refs.ptr may result in file.ptr being created, deleted, or changed.


## SymStore Command-Line Options
The following syntax forms are supported for SymStore transactions. The first parameter must always be add or del. The order of the other parameters does not matter.

symstore add [/l /o /p /r /compress] [-:MSG Message] [-:REL] [-:NOREFS] /f File /s Store /t Product [/v Version] [/c Comment] [/d LogFile]

symstore add [/a /l /o /p /r] [-:REL] [-:NOREFS] /g Share /f File /x IndexFile [/d LogFile]

symstore add [/o /compress] [ /p [-:MSG |Message] [-:REL] [-:NOREFS]] /y IndexFile /g Share /s Store /t Product [/v Version] [/c Comment] [/d LogFile]

symstore query [/o /r] /f File /s Store [/d LogFile]

symstore del /i ID /s Store [/o] [/d LogFile]

symstore /?


| Parameter | Meaning |
| /a | Causes SymStore to append new indexing information to an existing index file. (This option is only used with the /x option.) |
| /c Comment | Specifies a comment for the transaction. |
| /compress | Causes SymStore to create a compressed version of each file copied to the symbol store instead of using an uncompressed copy of the file. This option is only valid when storing files and not pointers, and cannot be used with the /p option. |
| /d LogFile | Specifies a log file to be used for command output. If this is not included, transaction information and other output is sent to stdout. |
| /f File | Specifies one or more file paths (or directories) to add. If a specified file path begins with an '@' symbol, a response file containing a list of files to be added (one file path per line) is expected. |
| /g Share | Specifies the server and share where the symbol files were originally stored. When used with /f, Share should be identical to the beginning of the File specifier. When used with /y, Share should be the location of the original symbol files (not the index file). This allows you to later change this portion of the file path in case you move the symbol files to a different server and share. |
| /i ID | Specifies the transaction ID string. |
| /l | Allows the file to be in a local directory rather than a network path. (This option is only used with the /p option.) |
| /o | Causes SymStore to display verbose output. |
| /p | Causes SymStore to store a pointer to the file, rather than the file itself. |
| /r | Causes SymStore to add files or directories recursively. |
| /s Store | Specifies the root directory for the symbol store. |
| /t Product | Specifies the name of the product. |
| /v Version | Specifies the version of the product. |
| /x IndexFile | Causes SymStore not to store the actual symbol files. Instead, SymStore records information in the IndexFile that will enable SymStore to access the symbol files at a later time. |
| /y IndexFile | Causes SymStore to read the data from a file created with /x. |
| -:MSG Message | Adds the specified Message to each file. (This option can only be used when /p is used.) |
| -:REL | Allows the paths in the file pointers to be relative. This option implies the /l option. (This option can only be used when /p is used.) |
| -:NOREFS | Omits the creation of reference pointer files for the files and pointers being stored. This option is only valid during the initial creation of a symbol store if the store being changed was created with this option. |
| /? | Displays help text for the SymStore command. |