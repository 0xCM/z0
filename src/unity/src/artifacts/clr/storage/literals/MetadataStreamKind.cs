//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    partial struct ClrStorage
    {
        public enum MetadataStreamKind
        {
            Illegal,

            Compressed,

            UnCompressed,
        }
    }
}