// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Z0.Schemas.Ecma
{

    public readonly struct TokenTypes
    {
        public const uint Module = (uint)CliTableKind.Module << RowIdWidth;

        public const uint TypeRef = (uint)CliTableKind.TypeRef << RowIdWidth;

        public const uint TypeDef = (uint)CliTableKind.TypeDef << RowIdWidth;

        public const uint FieldDef = (uint)CliTableKind.Field << RowIdWidth;

        public const uint MethodDef = (uint)CliTableKind.MethodDef << RowIdWidth;

        public const uint ParamDef = (uint)CliTableKind.Param << RowIdWidth;

        public const uint InterfaceImpl = (uint)CliTableKind.InterfaceImpl << RowIdWidth;

        public const uint MemberRef = (uint)CliTableKind.MemberRef << RowIdWidth;

        public const uint Constant = (uint)CliTableKind.Constant << RowIdWidth;

        public const uint CustomAttribute = (uint)CliTableKind.CustomAttribute << RowIdWidth;

        public const uint DeclSecurity = (uint)CliTableKind.DeclSecurity << RowIdWidth;

        public const uint Signature = (uint)CliTableKind.StandAloneSig << RowIdWidth;

        public const uint EventMap = (uint)CliTableKind.EventMap << RowIdWidth;

        public const uint Event = (uint)CliTableKind.Event << RowIdWidth;

        public const uint PropertyMap = (uint)CliTableKind.PropertyMap << RowIdWidth;

        public const uint Property = (uint)CliTableKind.Property << RowIdWidth;

        public const uint MethodSemantics = (uint)CliTableKind.MethodSemantics << RowIdWidth;

        public const uint MethodImpl = (uint)CliTableKind.MethodImpl << RowIdWidth;

        public const uint ModuleRef = (uint)CliTableKind.ModuleRef << RowIdWidth;

        public const uint TypeSpec = (uint)CliTableKind.TypeSpec << RowIdWidth;

        public const uint Assembly = (uint)CliTableKind.Assembly << RowIdWidth;

        public const uint AssemblyRef = (uint)CliTableKind.AssemblyRef << RowIdWidth;

        public const uint File = (uint)CliTableKind.File << RowIdWidth;

        public const uint ExportedType = (uint)CliTableKind.ExportedType << RowIdWidth;

        public const uint ManifestResource = (uint)CliTableKind.ManifestResource << RowIdWidth;

        public const uint NestedClass = (uint)CliTableKind.NestedClass << RowIdWidth;

        public const uint GenericParam = (uint)CliTableKind.GenericParam << RowIdWidth;

        public const uint MethodSpec = (uint)CliTableKind.MethodSpec << RowIdWidth;

        public const uint GenericParamConstraint = (uint)CliTableKind.GenericParamConstraint << RowIdWidth;

        // debug tables:
        public const uint Document = (uint)CliTableKind.Document << RowIdWidth;

        public const uint MethodDebugInformation = (uint)CliTableKind.MethodDebugInformation << RowIdWidth;

        public const uint LocalScope = (uint)CliTableKind.LocalScope << RowIdWidth;

        public const uint LocalVariable = (uint)CliTableKind.LocalVariable << RowIdWidth;

        public const uint LocalConstant = (uint)CliTableKind.LocalConstant << RowIdWidth;

        public const uint ImportScope = (uint)CliTableKind.ImportScope << RowIdWidth;

        public const uint AsyncMethod = (uint)CliTableKind.StateMachineMethod << RowIdWidth;

        public const uint CustomDebugInformation = (uint)CliTableKind.CustomDebugInformation << RowIdWidth;

        public const uint UserString = (uint)HeapKind.UserString << RowIdWidth;

        public const byte RowIdWidth = 24;

        public const uint RIDMask = (1 << RowIdWidth) - 1;

        public const uint TypeMask = 0x7F << RowIdWidth;

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