//-----------------------------------------------------------------------------
// Copyright   :  Microsoft
// License     : MIT via .Net Foundation
// Extracted from System.Reflection.MetadataReader library code
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    partial class MetadataFlags
    {
        internal static class TokenTypeIds
        {
            internal const uint Module = HandleType.Module << RowIdBitCount;
            internal const uint TypeRef = HandleType.TypeRef << RowIdBitCount;
            internal const uint TypeDef = HandleType.TypeDef << RowIdBitCount;
            internal const uint FieldDef = HandleType.FieldDef << RowIdBitCount;
            internal const uint MethodDef = HandleType.MethodDef << RowIdBitCount;
            internal const uint ParamDef = HandleType.ParamDef << RowIdBitCount;
            internal const uint InterfaceImpl = HandleType.InterfaceImpl << RowIdBitCount;
            internal const uint MemberRef = HandleType.MemberRef << RowIdBitCount;
            internal const uint Constant = HandleType.Constant << RowIdBitCount;
            internal const uint CustomAttribute = HandleType.CustomAttribute << RowIdBitCount;
            internal const uint DeclSecurity = HandleType.DeclSecurity << RowIdBitCount;
            internal const uint Signature = HandleType.Signature << RowIdBitCount;
            internal const uint EventMap = HandleType.EventMap << RowIdBitCount;
            internal const uint Event = HandleType.Event << RowIdBitCount;
            internal const uint PropertyMap = HandleType.PropertyMap << RowIdBitCount;
            internal const uint Property = HandleType.Property << RowIdBitCount;
            internal const uint MethodSemantics = HandleType.MethodSemantics << RowIdBitCount;
            internal const uint MethodImpl = HandleType.MethodImpl << RowIdBitCount;
            internal const uint ModuleRef = HandleType.ModuleRef << RowIdBitCount;
            internal const uint TypeSpec = HandleType.TypeSpec << RowIdBitCount;
            internal const uint Assembly = HandleType.Assembly << RowIdBitCount;
            internal const uint AssemblyRef = HandleType.AssemblyRef << RowIdBitCount;
            internal const uint File = HandleType.File << RowIdBitCount;
            internal const uint ExportedType = HandleType.ExportedType << RowIdBitCount;
            internal const uint ManifestResource = HandleType.ManifestResource << RowIdBitCount;
            internal const uint NestedClass = HandleType.NestedClass << RowIdBitCount;
            internal const uint GenericParam = HandleType.GenericParam << RowIdBitCount;
            internal const uint MethodSpec = HandleType.MethodSpec << RowIdBitCount;
            internal const uint GenericParamConstraint = HandleType.GenericParamConstraint << RowIdBitCount;

            // debug tables:
            internal const uint Document = HandleType.Document << RowIdBitCount;
            internal const uint MethodDebugInformation = HandleType.MethodDebugInformation << RowIdBitCount;
            internal const uint LocalScope = HandleType.LocalScope << RowIdBitCount;
            internal const uint LocalVariable = HandleType.LocalVariable << RowIdBitCount;
            internal const uint LocalConstant = HandleType.LocalConstant << RowIdBitCount;
            internal const uint ImportScope = HandleType.ImportScope << RowIdBitCount;
            internal const uint AsyncMethod = HandleType.AsyncMethod << RowIdBitCount;
            internal const uint CustomDebugInformation = HandleType.CustomDebugInformation << RowIdBitCount;

            internal const uint UserString = HandleType.UserString << RowIdBitCount;

            internal const int RowIdBitCount = 24;
            internal const uint RIDMask = (1 << RowIdBitCount) - 1;
            internal const uint TypeMask = HandleType.TypeMask << RowIdBitCount;

            /// <summary>
            /// Use the highest bit to mark tokens that are virtual (synthesized).
            /// We create virtual tokens to represent projected WinMD entities.
            /// </summary>
            internal const uint VirtualBit = 0x80000000;

            /// <summary>
            /// Returns true if the token value can escape the metadata reader.
            /// We don't allow virtual tokens and heap tokens other than UserString to escape
            /// since the token type ids are internal to the reader and not specified by ECMA spec.
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
            internal static bool IsEntityOrUserStringToken(uint vToken)
            {
                return (vToken & TypeMask) <= UserString;
            }

            internal static bool IsEntityToken(uint vToken)
            {
                return (vToken & TypeMask) < UserString;
            }

            internal static bool IsValidRowId(uint rowId)
            {
                return (rowId & ~RIDMask) == 0;
            }

            internal static bool IsValidRowId(int rowId)
            {
                return (rowId & ~RIDMask) == 0;
            }
        }                
    }
}