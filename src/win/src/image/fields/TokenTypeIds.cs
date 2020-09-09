//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    using H = TableIndex;

    public static class TokenTypeIds
    {
        public const uint Module = (uint)H.Module << RowIdBitCount;

        public const uint TypeRef = (uint)H.TypeRef << RowIdBitCount;

        public const uint TypeDef = (uint)H.TypeDef << RowIdBitCount;

        public const uint FieldDef = (uint)H.Field << RowIdBitCount;

        public const uint MethodDef = (uint)H.MethodDef << RowIdBitCount;

        public const uint ParamDef = (uint)H.Param << RowIdBitCount;

        public const uint InterfaceImpl = (uint)H.InterfaceImpl << RowIdBitCount;

        public const uint MemberRef = (uint)H.MemberRef << RowIdBitCount;

        public const uint Constant =(uint)H.Constant << RowIdBitCount;

        public const uint CustomAttribute = (uint)H.CustomAttribute << RowIdBitCount;
        public const uint DeclSecurity = (uint)H.DeclSecurity << RowIdBitCount;

        public const uint Signature = (uint)H.StandAloneSig << RowIdBitCount;

        public const uint EventMap = (uint)H.EventMap << RowIdBitCount;

        public const uint Event = (uint)H.Event << RowIdBitCount;

        public const uint PropertyMap = (uint)H.PropertyMap << RowIdBitCount;

        public const uint Property = (uint)H.Property << RowIdBitCount;

        public const uint MethodSemantics = (uint)H.MethodSemantics << RowIdBitCount;

        public const uint MethodImpl = (uint)H.MethodImpl << RowIdBitCount;

        public const uint ModuleRef = (uint)H.ModuleRef << RowIdBitCount;

        public const uint TypeSpec = (uint)H.TypeSpec << RowIdBitCount;

        public const uint Assembly = (uint)H.Assembly << RowIdBitCount;

        public const uint AssemblyRef = (uint)H.AssemblyRef << RowIdBitCount;

        public const uint File = (uint)H.File << RowIdBitCount;

        public const uint ExportedType = (uint)H.ExportedType << RowIdBitCount;

        public const uint ManifestResource = (uint)H.ManifestResource << RowIdBitCount;

        public const uint NestedClass = (uint)H.NestedClass << RowIdBitCount;

        public const uint GenericParam = (uint)H.GenericParam << RowIdBitCount;

        public const uint MethodSpec = (uint)H.MethodSpec << RowIdBitCount;

        public const uint GenericParamConstraint = (uint)H.GenericParamConstraint << RowIdBitCount;

        // debug tables:
        public const uint Document = (uint)H.Document << RowIdBitCount;

        public const uint MethodDebugInformation = (uint)H.MethodDebugInformation << RowIdBitCount;

        public const uint LocalScope = (uint)H.LocalScope << RowIdBitCount;

        public const uint LocalVariable = (uint)H.LocalVariable << RowIdBitCount;

        public const uint LocalConstant = (uint)H.LocalConstant << RowIdBitCount;

        public const uint ImportScope = (uint)H.ImportScope << RowIdBitCount;

        public const uint AsyncMethod = (uint)H.StateMachineMethod << RowIdBitCount;

        public const uint CustomDebugInformation = (uint)H.CustomDebugInformation << RowIdBitCount;

        public const uint UserString = (uint)H.UserString << RowIdBitCount;

        public const int RowIdBitCount = 24;

        public const uint RIDMask = (1 << RowIdBitCount) - 1;

        public const uint TypeMask = HandleType.TypeMask << RowIdBitCount;

        /// <summary>
        /// Use the highest bit to mark tokens that are virtual (synthesized).
        /// We create virtual tokens to represent projected WinMD entities.
        /// </summary>
        public const uint VirtualBit = 0x80000000;

        /// <summary>
        /// Returns true if the token value can escape the metadata reader.
        /// We don't allow virtual tokens and heap tokens other than UserString to escape
        /// since the token type ids are public to the reader and not specified by ECMA spec.
        ///
        /// Spec (Partition III, 1.9 Metadata tokens):
        /// Many CIL instructions are followed by a "metadata token". This is a 4-byte value, that specifies a row in a
        /// metadata table, or a starting byte offset in the User String heap.
        ///
        /// For example, a value of 0x02 specifies the TypeDef table; a value of 0x70 specifies the User
        /// String heap.The value corresponds to the number assigned to that metadata table (see Partition II for the full
        /// list of tables) or to 0x70 for the User String heap.The least-significant 3 bytes specify the target row within that
        /// metadata table, or starting byte offset within the User String heap.
        /// </summary>
        public static bool IsEntityOrUserStringToken(uint vToken)
        {
            return (vToken & TypeMask) <= UserString;
        }

        public static bool IsEntityToken(uint vToken)
        {
            return (vToken & TypeMask) < UserString;
        }

        public static bool IsValidRowId(uint rowId)
        {
            return (rowId & ~RIDMask) == 0;
        }

        public static bool IsValidRowId(int rowId)
        {
            return (rowId & ~RIDMask) == 0;
        }
    }
}