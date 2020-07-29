//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_COR20_HEADER
    {
        /// <summary>
        /// Header versioning
        /// </summary>
        public uint cb;
        
        public ushort MajorRuntimeVersion;
        
        public ushort MinorRuntimeVersion;

        /// <summary>
        /// Symbol table and startup information
        /// </summary>
        public IMAGE_DATA_DIRECTORY MetaData;
        
        public uint Flags;

        /// <summary>
        /// The main program if it is an EXE (not used if a DLL?)
        /// If COMIMAGE_FLAGS_NATIVE_ENTRYPOINT is not set, EntryPointToken represents a managed entrypoint.
        /// If COMIMAGE_FLAGS_NATIVE_ENTRYPOINT is set, EntryPointRVA represents an RVA to a native entrypoint
        /// (depricated for DLLs, use modules constructors intead).
        /// </summary>
        public IMAGE_COR20_HEADER_ENTRYPOINT EntryPoint;

        /// <summary>
        /// This is the blob of managed resources. Fetched using code:AssemblyNative.GetResource and 
        /// code:PEFile.GetResource and accessible from managed code from System.Assembly.GetManifestResourceStream.  
        /// The meta data has a table that maps names to offsets into this blob, so logically the blob is a set of resources.
        /// </summary>
        public IMAGE_DATA_DIRECTORY Resources;

        /// <summary>
        /// IL assemblies can be signed with a public-private key to validate who created it.  
        /// The signature goes here if this feature is used.
        /// </summary>
        public IMAGE_DATA_DIRECTORY StrongNameSignature;

        /// <summary>
        /// Deprecated, not used; Used for manged code that has unmaanaged code inside it 
        /// (or exports methods as unmanaged entry points)
        /// </summary>
        public IMAGE_DATA_DIRECTORY CodeManagerTable;
                                                    
        public IMAGE_DATA_DIRECTORY VTableFixups;

        public IMAGE_DATA_DIRECTORY ExportAddressTableJumps;

        /// <summary>
        /// null for ordinary IL images.  NGEN images it points at a code:CORCOMPILE_HEADER structure
        /// </summary>
        public IMAGE_DATA_DIRECTORY ManagedNativeHeader;
    }            
}