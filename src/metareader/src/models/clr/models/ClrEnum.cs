//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;

    using Z0.MS;
    
    partial struct ClrDataModel
    {
        public sealed class ClrEnum
        {
            public ClrType Type { get; }

            public ClrElementType ElementType { get; }

            private readonly (string, object?)[] _values;

            public ClrEnum(ClrType type)
            {
                Type = type ?? throw new ArgumentNullException(nameof(type));

                if (!type.IsEnum)
                    throw new InvalidOperationException($"{type.Name ?? nameof(ClrType)} is not an enum.  You must call {nameof(ClrType)}.{nameof(ClrType.IsEnum)} before using {nameof(ClrEnum)}.");

                MetadataImport? import = type.Module?.MetadataImport;
                if (import != null)
                {
                    _values = EnumerateValues(import, out ClrElementType elementType).ToArray();
                    ElementType = elementType;
                }
                else
                {
                    _values = Array.Empty<(string, object?)>();
                }
            }

            public T GetEnumValue<T>(string name) where T : unmanaged
            {
                object? value = _values.Single(v => v.Item1 == name).Item2;
                if (value is null)
                    throw new InvalidOperationException($"Enum {Type.Name} had null '{name}' value.");

                return (T)value;
            }

            public IEnumerable<string> GetEnumNames() => _values.Select(v => v.Item1);
            public IEnumerable<(string, object?)> EnumerateValues() => _values;

            private (string, object?)[] EnumerateValues(MetadataImport import, out ClrElementType elementType)
            {
                List<(string, object?)> values = new List<(string, object?)>();
                elementType = ClrElementType.Unknown;

                foreach (int token in import.EnumerateFields(Type.MetadataToken))
                {
                    if (import.GetFieldProps(token, out string? name, out FieldAttributes attr, out IntPtr ppvSigBlob, out int pcbSigBlob, out int pdwCPlusTypeFlag, out IntPtr ppValue))
                    {
                        if (name == null)
                            continue;

                        if ((int)attr == 0x606 && name == "value__")
                        {
                            ClrSigParser parser = new ClrSigParser(ppvSigBlob, pcbSigBlob);
                            if (parser.GetCallingConvInfo(out _) && parser.GetElemType(out int elemType))
                                elementType = (ClrElementType)elemType;
                        }

                        // public, static, literal, has default
                        if ((int)attr == 0x8056)
                        {
                            ClrSigParser parser = new ClrSigParser(ppvSigBlob, pcbSigBlob);
                            parser.GetCallingConvInfo(out _);
                            parser.GetElemType(out _);

                            Type? underlying = ((ClrElementType)pdwCPlusTypeFlag).GetTypeForElementType();
                            if (underlying != null)
                            {
                                object o = Marshal.PtrToStructure(ppValue, underlying)!;
                                values.Add((name, o));
                            }
                            else
                            {
                                values.Add((name, null));
                            }
                        }
                    }
                }

                return values.ToArray();
            }
        }
    }
}