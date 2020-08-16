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
    public readonly partial struct ImageRecords
    {
        public static ImgStringRecord Strings => default;
        
        public static ImgBlobRecord Blobs => default;
        
        public static ImgConstantRecord Constants => default;

        public static ImgFieldRecord Fields => default;

        public static ImgFieldRva FieldRva => default;

        public static PeHeaderRecord PeHeader => default;

        public static ImgMethodBody MethodBody => default;

        public static ImgLiteralFieldRecord LiteralFields => default;
    }
}