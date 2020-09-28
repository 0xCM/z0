//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    public enum DirectoryKey : ushort
    {
        Export,

        Import,

        Resource,

        Exception,

        Certificate,

        BaseRelocation,

        Debug,

        Copyright,

        GlobalPointer,

        ThreadLocalStorage,

        LoadConfig,

        BoundImport,

        ImportAddress,

        DelayImport,

        COR20Header,

        Reserved,

        Cor20HeaderMetaData,

        Cor20HeaderResources,

        Cor20HeaderStrongNameSignature,

        Cor20HeaderCodeManagerTable,

        Cor20HeaderVtableFixups,

        Cor20HeaderExportAddressTableJumps,

        Cor20HeaderManagedNativeHeader,
    }
}