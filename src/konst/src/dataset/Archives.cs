//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct Archives
    {        
        [MethodImpl(Inline), Op]
        public static TableArchive tables(FolderPath root)
            => new TableArchive(root);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Literal<T> literal<T>(string declarer, string name, uint index, T value, LiteralKind kind, bool refinement)
            => new Literal<T>(declarer, name, index, value, kind, refinement);
                
        [MethodImpl(Inline)]
        public static TableStore<F,R> tablestore<F,R>()
            where F : unmanaged, Enum
            where R : ITabular
                => default;

        [MethodImpl(Inline), Op]
        public static Publications pulications()
            => default(Publications);

        [MethodImpl(Inline)]
        public static Publication<R> publication<R>(R[] src, FilePath dst)
            where R : ITabular
                => new Publication<R>(src,dst);            
    }
}