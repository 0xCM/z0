//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Tables
    {
        /// <summary>
        /// Defines a <typeparamref name='T'/> record emitter
        /// </summary>
        /// <param name="formatter">The record formatter</param>
        /// <typeparam name="T">The record type</typeparam>
        public static IRecordEmitter<T> emitter<T>(ReadOnlySpan<byte> widths, FS.FilePath dst)
            where T : struct, IRecord<T>
                => emitter<T>(formatter<T>(widths), dst);

        /// <summary>
        /// Defines a <typeparamref name='T'/> record emitter
        /// </summary>
        /// <param name="formatter">The record formatter</param>
        /// <typeparam name="T">The record type</typeparam>
        public static IRecordEmitter<T> emitter<E,T>(FS.FilePath dst)
            where T : struct, IRecord<T>
            where E : unmanaged, Enum
                => emitter<T>(formatter<E,T>(), dst);

        /// <summary>
        /// Defines a <typeparamref name='T'/> record emitter
        /// </summary>
        /// <param name="formatter">The record formatter</param>
        /// <typeparam name="T">The record type</typeparam>
        public static IRecordEmitter<T> emitter<T>(IRecordFormatter<T> formatter, FS.FilePath dst)
            where T : struct, IRecord<T>
                => new RecordEmitter<T>(formatter, dst);
    }
}