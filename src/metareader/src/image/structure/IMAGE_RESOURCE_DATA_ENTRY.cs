//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    /// <summary>
    /// Each resource data entry describes a leaf node in the resource directory
    /// tree.  It contains an offset, relative to the beginning of the resource
    /// directory of the data for the resource, a size field that gives the number
    /// of bytes of data at that offset, a CodePage that should be used when
    /// decoding code point values within the resource data.  Typically for new
    /// applications the code page would be the unicode code page.
    /// </summary>
    public struct IMAGE_RESOURCE_DATA_ENTRY
    {
        public int RvaToData;
    
        public int Size;
    
        public int CodePage;
    
        public int Reserved;
    }        

}