//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    using F = EnumLiteral.Fields;

    [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
    public struct EnumLiteral
    {
        public const string TableId = "enum.literals";

        public const byte FieldCount = 6;

        /// <summary>
        /// Defines the fields into which a literal table is partitioned
        /// </summary>
        public enum Fields : uint
        {
            /// <summary>
            /// The defining type, such as an enum or a type that declares constant fields
            /// </summary>
            TypeName = 0 | (32 << WidthOffset),

            /// <summary>
            /// The declaration order of the literal relative to other literals in the same dataset
            /// </summary>
            Index = 1 | (12 << WidthOffset),

            /// <summary>
            /// The literal name
            /// </summary>
            Name = 2 | (32 << WidthOffset),

            /// <summary>
            /// The literal's value in base-16
            /// </summary>
            Hex = 3 | (10 << WidthOffset),

            /// <summary>
            /// The literal's bitstring representation
            /// </summary>
            BitString = 4 | (32 << WidthOffset),

            /// <summary>
            ///  A description of the literal if it exist
            /// </summary>
            Description = 5 | (4 << WidthOffset)
        }

        public string TypeName;

        public uint Index;

        public string Name;

        public string Hex;

        public string BitString;

        public string Description;

        [MethodImpl(Inline)]
        public EnumLiteral(string type, uint index, string name, string hex, string bits, string description)
        {
            TypeName = type;
            Index = index;
            Name = name;
            Hex = hex;
            BitString = bits;
            Description = description ?? EmptyString;
        }

        public string DelimitedText(char delimiter)
        {
            var formatter = Table.formatter<F>(delimiter);
            formatter.Append(F.TypeName, TypeName);
            formatter.Delimit(F.Index, Index);
            formatter.Delimit(F.Name, Name);
            formatter.Delimit(F.Hex, Hex);
            formatter.Delimit(F.BitString, BitString);
            formatter.Delimit(F.Description, Description);
            return formatter.ToString();
        }

        public override string ToString()
            => DelimitedText(FieldDelimiter);
    }
}