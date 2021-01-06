//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Records
    {
        /// <summary>
        /// Defines a <typeparamref name='T'/> record emitter
        /// </summary>
        /// <param name="formatter">The record formatter</param>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RecordEmitter<T> emitter<T>(RecordFormatter<T> formatter, FS.FilePath dst)
            where T : struct, IRecord<T>
                => new RecordEmitter<T>(formatter, dst);

        /// <summary>
        /// Defines a <typeparamref name='T'/> record emitter
        /// </summary>
        /// <param name="formatter">The record formatter</param>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RecordEmitter<T> emitter<T>(ReadOnlySpan<byte> widths, FS.FilePath dst)
            where T : struct, IRecord<T>
                => new RecordEmitter<T>(formatter<T>(widths), dst);

        /// <summary>
        /// Defines a <typeparamref name='T'/> record emitter
        /// </summary>
        /// <param name="formatter">The record formatter</param>
        /// <typeparam name="T">The record type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RecordEmitter<T> emitter<E,T>(FS.FilePath dst)
            where T : struct, IRecord<T>
            where E : unmanaged, Enum
                => new RecordEmitter<T>(formatter<E,T>(), dst);
    }
}