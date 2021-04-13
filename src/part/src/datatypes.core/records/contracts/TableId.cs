//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TableId : ITableId
    {
        /// <summary>
        /// Computes the <see cref='TableId'/> of a parametrically-identified record
        /// </summary>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline)]
        public static TableId identify<T>()
            where T : struct, IRecord<T>
                => identify(typeof(T));

        /// <summary>
        /// Computes the <see cref='TableId'/> of a specified record type
        /// </summary>
        /// <param name="src">The record type</typeparam>
        [Op]
        public static TableId identify(Type src)
            => src.Tag<RecordAttribute>().MapValueOrElse(
                    a => new TableId(src, a.TableId),
                    () => new TableId(src, src.Name));

        public Name RecordType {get;}

        public Name Identifier {get;}

        [MethodImpl(Inline)]
        public TableId(Type shape, string name)
        {
            RecordType = name;
            Identifier = name;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Identifier.Format();

        public override string ToString()
            => Format();
    }
}