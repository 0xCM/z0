//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct PartFileKinds
    {
        const int KindCount = 4;

        readonly FileKind[] Data;

        public static PartFileKinds Service()
        {
            var kindSize = z.size<FileKind>();
            var buffer = sys.alloc<FileKind>(KindCount + 1);
            var dst = buffer.ToSpan();
            z.seek(dst,0) = None;
            z.seek(dst,1) = Extract;
            z.seek(dst,2) = Parsed;
            z.seek(dst,3) = Asm;
            z.seek(dst,4) = Hex;            
            return new PartFileKinds(buffer);
        }
                
        internal PartFileKinds(FileKind[] data)
        {
            Data = data;
        }

        public static FileKind<PartFileKind> None
        {
            [MethodImpl(Inline)]
            get => default;
        }
        
        public static ApiExtractFile Extract
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static ApiParseFile Parsed 
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static ApiAsmFile Asm 
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static ApiHexFile Hex 
        {
            [MethodImpl(Inline)]
            get => default;
        }

        [MethodImpl(Inline), Op]
        public FileKind<PartFileKind> kind(PartFileKind k)
            => z.cast<FileKind,FileKind<PartFileKind>>(Data[(int)k]);
    }
}