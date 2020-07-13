//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct PartFileKinds
    {
        [MethodImpl(Inline), Op]
        public static PartFileKind define(PartFileClass @class, string ext)
            => new PartFileKind(@class, ext);

        [MethodImpl(Inline), Op]
        public static PartFileKind from(PartFileClass @class)
        {
            var offset = (byte)@class;
            var src = Known;
            ref readonly var x = ref @as<PartFileKinds,PartFileKind>(src);

            return skip(@as<PartFileKinds,PartFileKind>(src), offset);
        }

        [MethodImpl(Inline), Op]
        public static FileExt ext(PartFileClass @class)
            => from(@class).Ext;


        [MethodImpl(Inline), Op]
        static PartFileKinds known()
            => Known;

        public static PartFileKinds Known
        {
           [MethodImpl(Inline)]
           get => new PartFileKinds(0);
        }
        
        public readonly ExtractFileKind Extract;                

        public readonly ParsedFileKind Parsed;

        public readonly AsmFileKind Asm; 

        public readonly HexFileKind Hex;

        public readonly CilFileKind Cil;

        [MethodImpl(Inline)]
        PartFileKinds(int i)
            : this()
        {

        }
    }
}