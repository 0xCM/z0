namespace Windows
{
    using System;

    // From minidumpapiset.h
    // A normal minidump contains just the information
    // necessary to capture stack traces for all of the
    // existing threads in a process.
    //
    // A minidump with data segments includes all of the data
    // sections from loaded modules in order to capture
    // global variable contents.  This can make the dump much
    // larger if many modules have global data.
    //
    // A minidump with full memory includes all of the accessible
    // memory in the process and can be very large.  A minidump
    // with full memory always has the raw memory data at the end
    // of the dump so that the initial structures in the dump can
    // be mapped directly without having to include the raw
    // memory information.
    //
    // Stack and backing store memory can be filtered to remove
    // data unnecessary for stack walking.  This can improve
    // compression of stacks and also deletes data that may
    // be private and should not be stored in a dump.
    // Memory can also be scanned to see what modules are
    // referenced by stack and backing store memory to allow
    // omission of other modules to reduce dump size.
    // In either of these modes the ModuleReferencedByMemory flag
    // is set for all modules referenced before the base
    // module callbacks occur.
    //
    // On some operating systems a list of modules that were
    // recently unloaded is kept in addition to the currently
    // loaded module list.  This information can be saved in
    // the dump if desired.
    //
    // Stack and backing store memory can be scanned for referenced
    // pages in order to pick up data referenced by locals or other
    // stack memory.  This can increase the size of a dump significantly.
    //
    // Module paths may contain undesired information such as user names
    // or other important directory names so they can be stripped.  This
    // option reduces the ability to locate the proper image later
    // and should only be used in certain situations.
    //
    // Complete operating system per-process and per-thread information can
    // be gathered and stored in the dump.
    //
    // The virtual address space can be scanned for various types
    // of memory to be included in the dump.
    //
    // Code which is concerned with potentially private information
    // getting into the minidump can set a flag that automatically
    // modifies all existing and future flags to avoid placing
    // unnecessary data in the dump.  Basic data, such as stack
    // information, will still be included but optional data, such
    // as indirect memory, will not.
    //
    // When doing a full memory dump it's possible to store all
    // of the enumerated memory region descriptive information
    // in a memory information stream.
    //
    // Additional thread information beyond the basic thread
    // structure can be collected if desired.
    //
    // A minidump with code segments includes all of the code
    // and code-related sections from loaded modules in order
    // to capture executable content.
    //
    // MiniDumpWithoutAuxiliaryState turns off any secondary,
    // auxiliary-supported memory gathering.
    //
    // MiniDumpWithFullAuxiliaryState asks any present auxiliary
    // data providers to include all of their state in the dump.
    // The exact set of what is provided depends on the auxiliary.
    // This can be quite large.

    [Flags]
    public enum MINIDUMP_TYPE : uint
    {
        MiniDumpNormal = 0x00000000,

        MiniDumpWithDataSegs    = 0x00000001,

        MiniDumpWithFullMemory  = 0x00000002,

        MiniDumpWithHandleData  = 0x00000004,

        MiniDumpFilterMemory    = 0x00000008,

        MiniDumpScanMemory      = 0x00000010,

        MiniDumpWithUnloadedModules = 0x00000020,

        MiniDumpWithIndirectlyReferencedMemory = 0x00000040,

        MiniDumpFilterModulePaths = 0x00000080,

        MiniDumpWithProcessThreadData  = 0x00000100,

        MiniDumpWithPrivateReadWriteMemory = 0x00000200,

        MiniDumpWithoutOptionalData = 0x00000400,

        MiniDumpWithFullMemoryInfo = 0x00000800,

        MiniDumpWithThreadInfo = 0x00001000,

        MiniDumpWithCodeSegs = 0x00002000,

        MiniDumpWithoutAuxiliaryState = 0x00004000,

        MiniDumpWithFullAuxiliaryState = 0x00008000,

        MiniDumpWithPrivateWriteCopyMemory     = 0x00010000,

        MiniDumpIgnoreInaccessibleMemory = 0x00020000,

        MiniDumpWithTokenInformation = 0x00040000,

        MiniDumpWithModuleHeaders = 0x00080000,

        MiniDumpFilterTriage = 0x00100000,

        MiniDumpWithAvxXStateContext = 0x00200000,

        MiniDumpWithIptTrace  = 0x00400000,

        MiniDumpScanInaccessiblePartialPages = 0x00800000,

        MiniDumpValidTypeFlags  = 0x00ffffff,
    }
}