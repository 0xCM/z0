//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Runtime.InteropServices;
    using System.Text;

    using static Part;
    using static memory;

    partial class SRM
    {
        unsafe partial struct MemoryBlock
        {
            // When reference has at most 24 bits.
            [Op]
            public int PeekReference(int offset, bool smallRefSize)
            {
                if (smallRefSize)
                {
                    return PeekUInt16(offset);
                }

                uint value = PeekUInt32(offset);

                if (!TokenTypeIds.IsValidRowId(value))
                {
                    //Throw.ReferenceOverflow();
                }

                return (int)value;
            }

            // Use when searching for a tagged or non-tagged reference.
            // The result may be an invalid reference and shall only be used to compare with a valid reference.
            [MethodImpl(Inline), Op]
            public uint PeekReferenceUnchecked(int offset, bool smallRefSize)
                => smallRefSize ? PeekUInt16(offset) : PeekUInt32(offset);
        }
    }
}