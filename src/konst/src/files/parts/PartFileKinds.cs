//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct PartFileKinds
    {
        [MethodImpl(Inline), Op]
        public static PartFileKind kind(PartFileClass @class)
            => skip(@as<PartFileKinds,PartFileKind>(default(PartFileKinds)), (byte)@class);

        [MethodImpl(Inline), Op]
        public static unsafe char* hex()
            => pchar2(HexFileKind.ExtensionName);

        [MethodImpl(Inline), Op]
        public static unsafe char* asm()
            => pchar2(AsmFileKind.ExtensionName);

        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> locations(byte offset)
        {
            ref var src =  ref add8(@as<PartFileKinds,byte>(default(PartFileKinds)), offset);
            return vparts(w256, 
                locate(add8(src, 0)), 
                locate(add8(src, 1)), 
                locate(add8(src, 2)), 
                locate(add8(src, 3))
                );
        }

        [MethodImpl(Inline), Op]
        public static StringRef ext(PartFileClass @class)
            => kind(@class).Ext;

        public readonly HexFileKind Hex; //00

        public readonly AsmFileKind Asm; //01

        public readonly CilFileKind Cil; //02

        public readonly CsvFileKind Csv; //03
 
        public readonly DllFileKind Dll; //04

        public readonly ExeFileKind Exe; //05

        public readonly TxtFileKind Txt; //06

        public readonly XmlFileKind Xml; //07

        public readonly XmlFileKind Json; //08

        public readonly ExtractFileKind Extract; //09

        public readonly ParsedFileKind Parsed; //0a
    }
}