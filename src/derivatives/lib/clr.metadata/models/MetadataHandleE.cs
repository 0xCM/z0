//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MetadataHandleE
    {
        // bits:
        //     31: IsVirtual
        // 24..30: type
        //  0..23: row id
        public readonly uint Data;

        [MethodImpl(Inline)]
        public MetadataHandleE(uint src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator MetadataHandleE(uint src)
            => new MetadataHandleE(src);

        public uint RowId
        {
            [MethodImpl(Inline)]
            get { return (Data & TokenTypeIdsX.RIDMask); }
        }

        public uint Type
        {
            [MethodImpl(Inline)]
            get { return Data & TokenTypeIdsX.TypeMask; }
        }

        public uint VType
        {
            [MethodImpl(Inline)]
            get { return Data & (TokenTypeIdsX.VirtualBit | TokenTypeIdsX.TypeMask);}
        }

        public bool IsVirtual
        {
            [MethodImpl(Inline)]
            get { return (Data & TokenTypeIdsX.VirtualBit) != 0; }
        }

        public bool IsNil
        {
            [MethodImpl(Inline)]
            // virtual handle is never nil
            get { return (Data & (TokenTypeIdsX.VirtualBit | TokenTypeIdsX.RIDMask)) == 0; }
        }

        public HandleKind Kind
        {
            [MethodImpl(Inline)]
            get
            {
                // EntityHandles cannot be StringHandles and therefore we do not need
                // to handle stripping the extra non-virtual string type bits here.
                return (HandleKind)(Type >> TokenTypeIdsX.RowIdBitCount);
            }
        }
    }

}