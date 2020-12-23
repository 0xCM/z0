//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    partial struct Sinks
    {
        /// <summary>
        /// Creates a <see cref='Sink{T}'/> from a <see cref='Receiver{T}'/>
        /// </summary>
        /// <param name="dst">The target receiver</param>
        /// <typeparam name="T">The reception type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sink<T> create<T>(Receiver<T> dst)
            => new Sink<T>(dst);

        /// <summary>
        /// Creates a <see cref='Sink{T}'/> from a <see cref='StreamWriter'/>
        /// </summary>
        /// <param name="dst">The target writer</param>
        /// <typeparam name="T">The reception type</typeparam>
        public static Sink<T> create<T>(StreamWriter dst)
        {
            void Target(in T src) => dst.WriteLine(src);
            return new Sink<T>(Target);
        }

        /// <summary>
        /// Creates a <see cref='Sink{T}'/> from a <see cref='StreamWriter'/>
        /// </summary>
        /// <param name="dst">The target writer</param>
        /// <typeparam name="T">The reception type</typeparam>
        public static Sink<T> create<T>(FileStream dst)
        {
            void Target(in T src)
                => FS.write(src?.ToString() ?? EmptyString, dst);

            return new Sink<T>(Target);
        }
    }
}