//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using K = MdR.HandleKind;
    
    partial struct MdR
    {                
        public static SignatureTypeCode GetConstantTypeCode(object? value)
        {
            if (value == null)
            {
                // The encoding of Type for the nullref value for FieldInit is ELEMENT_TYPE_CLASS with a Value of a zero.
                return (SignatureTypeCode)0x12; // TODO
            }

            // Perf: Note that JIT optimizes each expression val.GetType() == typeof(T) to a single register comparison.
            // Also the checks are sorted by commonality of the checked types.

            if (value.GetType() == typeof(int))
            {
                return SignatureTypeCode.Int32;
            }

            if (value.GetType() == typeof(string))
            {
                return SignatureTypeCode.String;
            }

            if (value.GetType() == typeof(bool))
            {
                return SignatureTypeCode.Boolean;
            }

            if (value.GetType() == typeof(char))
            {
                return SignatureTypeCode.Char;
            }

            if (value.GetType() == typeof(byte))
            {
                return SignatureTypeCode.Byte;
            }

            if (value.GetType() == typeof(long))
            {
                return SignatureTypeCode.Int64;
            }

            if (value.GetType() == typeof(double))
            {
                return SignatureTypeCode.Double;
            }

            if (value.GetType() == typeof(short))
            {
                return SignatureTypeCode.Int16;
            }

            if (value.GetType() == typeof(ushort))
            {
                return SignatureTypeCode.UInt16;
            }

            if (value.GetType() == typeof(uint))
            {
                return SignatureTypeCode.UInt32;
            }

            if (value.GetType() == typeof(sbyte))
            {
                return SignatureTypeCode.SByte;
            }

            if (value.GetType() == typeof(ulong))
            {
                return SignatureTypeCode.UInt64;
            }

            if (value.GetType() == typeof(float))
            {
                return SignatureTypeCode.Single;
            }

            return 0;
        }

        internal static void SerializeRowCounts(BlobBuilder writer, int[] rowCounts)
        {
            for (int i = 0; i < rowCounts.Length; i++)
            {
                int rowCount = rowCounts[i];
                if (rowCount > 0)
                {
                    writer.WriteInt32(rowCount);
                }
            }
        }

        public interface IMetadataHandle
        {

            HandleKind Kind {get;}
        }    

        public interface IMetadataHandle<T> : IMetadataHandle
        {

        }    

        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct MetadataHandle<T>
        {

        }
        
        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct MetadataHandle
        {
            
        }

        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct MethodDefinitionHandle
        {
            public HandleKind Kind => K.MethodDefinition;
        }
        
        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct EventDefinitionHandle
        {
            public HandleKind Kind => K.EventDefinition;
        }

        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct LocalVariableHandle
        {
            public HandleKind Kind => K.LocalVariable;
        }        

        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public readonly struct StringHandle
        {
            public HandleKind Kind => K.String;
        }        
         
    }
}