# Tool - procdump

## Capture Usage

   procdump.exe [-mm] [-ma] [-mp] [-mc Mask] [-md Callback_DLL] [-mk]
                [-n Count]
                [-s Seconds]
                [-c|-cl CPU_Usage [-u]]
                [-m|-ml Commit_Usage]
                [-p|-pl Counter_Threshold]
                [-h]
                [-e [1 [-g] [-b]]]
                [-l]
                [-t]
                [-f  Include_Filter, ...]
                [-fx Exclude_Filter, ...]
                [-o]
                [-r [1..5] [-a]]
                [-wer]
                [-64]
                {
                 {{[-w] Process_Name | Service_Name | PID} [Dump_File | Dump_Folder]}
                |
                 {-x Dump_Folder Image_File [Argument, ...]}
                }

## Uninstall Usage:
   procdump.exe -u

## Options
   -mm     Write a 'Mini' dump file. (default)
           Includes the Process, Thread, Module, Handle and Address Space info.
   -ma     Write a 'Full' dump file.
           Includes All the Image, Mapped and Private memory.
   -mp     Write a 'MiniPlus' dump file.
           Includes all Private memory and all Read/Write Image or Mapped memory.
           To minimize size, the largest Private memory area over 512MB is excluded.
           A memory area is defined as the sum of same-sized memory allocations.
           The dump is as detailed as a Full dump but 10%-75% the size.
           Note: CLR processes are dumped as Full (-ma) due to debugging limitations.
   -mc     Write a 'Custom' dump file.
           Include memory defined by the specified MINIDUMP_TYPE mask (Hex).
   -md     Write a 'Callback' dump file.
           Include memory defined by the MiniDumpWriteDump callback routine
           named MiniDumpCallbackRoutine of the specified DLL.
   -mk     Also write a 'Kernel' dump file.
           Includes the kernel stacks of the threads in the process.
           OS doesn't support a kernel dump (-mk) when using a clone (-r).
           When using multiple dump sizes, a kernel dump is taken for each dump size.

   -a      Avoid outage. Requires -r. If the trigger will cause the target
           to suspend for a prolonged time due to an exceeded concurrent
           dump limit, the trigger will be skipped.
   -b      Treat debug breakpoints as exceptions (otherwise ignore them).
   -c      CPU threshold above which to create a dump of the process.
   -cl     CPU threshold below which to create a dump of the process.
   -e      Write a dump when the process encounters an unhandled exception.
           Include the 1 to create dump on first chance exceptions.
   -f      Filter (include) on the content of exceptions and debug logging.
           Wildcards (*) are supported.
   -fx     Filter (exclude) on the content of exceptions and debug logging.
           Wildcards (*) are supported.
   -g      Run as a native debugger in a managed process (no interop).
   -h      Write dump if process has a hung window (does not respond to
           window messages for at least 5 seconds).
   -i      Install ProcDump as the AeDebug postmortem debugger.
           Only -mm, -ma, -mp, -mc, -md and -r are supported as additional options.
           Uninstall (-u only) restores the previous configuration.
   -k      Kill the process after cloning (-r), or at end of dump collection.
   -l      Display the debug logging of the process.
   -m      Memory commit threshold in MB at which to create a dump.
   -ml     Trigger when memory commit drops below specified MB value.
   -n      Number of dumps to write before exiting.
   -o      Overwrite an existing dump file.
   -p      Trigger on the specified performance counter when the threshold
           is exceeded. Note: to specify a process counter when there are
           multiple instances of the process running, use the process ID
           with the following syntax: "\Process(<name>_<pid>)\counter"
   -pl     Trigger when performance counter falls below the specified value.
   -r      Dump using a clone. Concurrent limit is optional (default 1, max 5).
           OS doesn't support a kernel dump (-mk) when using a clone (-r).
           CAUTION: a high concurrency value may impact system performance.
           - Windows 7   : Uses Reflection. OS doesn't support -e.
           - Windows 8.0 : Uses Reflection. OS doesn't support -e.
           - Windows 8.1+: Uses PSS. All trigger types are supported.
   -s      Consecutive seconds before dump is written (default is 10).
   -t      Write a dump when the process terminates.
   -u      Treat CPU usage relative to a single core (used with -c).
           As the only option, Uninstalls ProcDump as the postmortem debugger.
   -w      Wait for the specified process to launch if it's not running.
   -wer    Queue the (largest) dump to Windows Error Reporting.
   -x      Launch the specified image with optional arguments.
           If it is a Store Application or Package, ProcDump will start
           on the next activation (only).
   -64     By default ProcDump will capture a 32-bit dump of a 32-bit process
           when running on 64-bit Windows. This option overrides to create a
           64-bit dump. Only use for WOW64 subsystem debugging.

## Examples

-------------------------------------------------------------------------------
- Write a Mini dump of a process named 'notepad' (only one match can exist):
    C:\>procdump notepad

-------------------------------------------------------------------------------
- Write a Full dump of a process with PID '4572':
    C:\>procdump -ma 4572

-------------------------------------------------------------------------------
- Write a Mini first, and then a Full dump of a process with PID '4572':
    C:\>procdump -mm -ma 4572

-------------------------------------------------------------------------------
- Write 3 Mini dumps 5 seconds apart of a process named 'notepad':
    C:\>procdump -n 3 -s 5 notepad

-------------------------------------------------------------------------------
- Write up to 3 Mini dumps of a process named 'consume' when it exceeds
         20% CPU usage for five seconds:
    C:\>procdump -n 3 -s 5 -c 20 consume

-------------------------------------------------------------------------------
- Write a Mini dump for a process named 'hang.exe' when one of its
         windows is unresponsive for more than 5 seconds:
    C:\>procdump -h hang.exe

- Write a Full and Kernel dump for a process named 'hang.exe' when one of its
         windows is unresponsive for more than 5 seconds:
    C:\>procdump -ma -mk -h hang.exe

-------------------------------------------------------------------------------
- Write a Mini dump of a process named 'outlook' when total system CPU
         usage exceeds 20% for 10 seconds:
    C:\>procdump outlook -p "\Processor(_Total)\% Processor Time" 20

- Write a Full dump of a process named 'outlook' when Outlook's handle count
         exceeds 10,000:
    C:\>procdump -ma outlook -p "\Process(Outlook)\Handle Count" 10000

-------------------------------------------------------------------------------
- Writes a Full dump for a 2nd chance exception:
    C:\>procdump -ma -e w3wp.exe

- Writes a Full dump for a 1st or 2nd chance exception:
    C:\>procdump -ma -e 1 w3wp.exe

- Writes a Full dump for a debug string message:
    C:\>procdump -ma -l w3wp.exe

- Write up to 10 Full dumps of each 1st or 2nd chance exception of w3wp.exe:
    C:\>procdump -ma -n 10 -e 1 w3wp.exe

- Write up to 10 Full dumps if an exception's code/name/msg contains 'NotFound':
    C:\>procdump -ma -n 10 -e 1 -f NotFound w3wp.exe

- Write up to 10 a Full dump if a debug string message contains 'NotFound':
    C:\>procdump -ma -n 10 -l -f NotFound w3wp.exe

-------------------------------------------------------------------------------
- Wait for a process called 'notepad' (and monitor it for exceptions):
    C:\>procdump -e -w notepad

- Launch a process called 'notepad' (and monitor it for exceptions):
    C:\>procdump -e -x c:\dumps notepad

- Register for launch, and attempt to activate, a store 'application'.
         A new ProcDump instance will start when it is activated:
    C:\>procdump -e -x c:\dumps Microsoft.BingMaps_8wekyb3d8bbwe!AppexMaps

- Register for launch of a store 'package'.
         A new ProcDump instance will start when it is (manually) activated:
    C:\>procdump -e -x c:\dumps Microsoft.BingMaps_1.2.0.136_x64__8wekyb3d8bbwe

-------------------------------------------------------------------------------
- Windows 7/8.0; Use Reflection to reduce outage for 5 consecutive triggers:
    C:\>procdump -r -ma -n 5 -s 15 wmplayer.exe

- Windows 8.1+; Use PSS to reduce outage for 5 concurrent triggers:
    C:\>procdump -r 5 -ma -n 5 -s 15 wmplayer.exe

-------------------------------------------------------------------------------
- Install ProcDump as the (AeDebug) postmortem debugger:
    C:\>procdump -ma -i c:\dumps
    ..or..
    C:\Dumps>procdump -ma -i

- Uninstall ProcDump as the (AeDebug) postmortem debugger:
    C:\>procdump -u
