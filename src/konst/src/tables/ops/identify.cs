//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Table
    {
        [Op]
        public static string identifier(Type src)
            => src.Tag<RecordAttribute>().MapValueOrElse(a => a.TableId, () => src.Name);

        [MethodImpl(Inline)]
        public static TableId id<T>()
            where T : struct
                => id(typeof(T));

        [Op]
        public static TableId id(Type src)
            => src.Tag<RecordAttribute>().MapValueOrElse(
                    a => new TableId(src.MetadataToken, a.TableId),
                    () => new TableId(src.MetadataToken, src.Name));
    }
}