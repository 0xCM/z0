//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Part;
    using static core;

    [ApiHost, RecordSet]
    public readonly partial struct CliRows : IRecordSet<CliRows>
    {
        [MethodImpl(Inline)]
        public static T create<T>()
            where T : unmanaged, ICliRecord<T>
                => new T();

        [MethodImpl(Inline)]
        public static ref T create<T>(out T dst)
            where T : unmanaged, ICliRecord<T>
        {
            dst = create<T>();
            return ref dst;
        }

        public static CliTableKind kind<T>(T t = default)
            where T : unmanaged, ICliRecord<T>
                => typeof(T).Tag<CliRecordAttribute>().MapValueOrDefault(x => x.TableKind, CliTableKind.Invalid);

        public static Type[] types()
            => typeof(CliRows).GetNestedTypes();

    }
}