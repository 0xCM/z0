//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct Pipes
    {
        const NumericKind Closure = AllNumeric;

        [Op, Closures(Closure)]
        public static void flow<T>(ReadOnlySpan<T> src, ReadOnlySpan<IReceiver<T>> dst)
        {
            var kSources = src.Length;
            var kTargets = dst.Length;
            for(var i=0; i<kSources; i++)
            {
                ref readonly var input = ref skip(src,i);
                for(var j=0; j<kTargets; j++)
                    skip(dst,j).Deposit(input);
            }
        }

        [Op, Closures(Closure)]
        public static uint flow<T>(Pipe<T> src, Pipe<T> dst)
        {
            var count = 0u;
            while(src.Emit(out var cell))
            {
                dst.Deposit(cell);
                count++;
            }
            return count;
        }

        [Op, Closures(Closure)]
        public static uint flow<T>(ReadOnlySpan<T> src, Pipe<T> dst)
        {
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
                dst.Deposit(skip(src,i));
            return count;
        }

        /// <summary>
        /// Creates a <see cref='Sink{T}'/> from a <see cref='Receiver{T}'/>
        /// </summary>
        /// <param name="dst">The target receiver</param>
        /// <typeparam name="T">The reception type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sink<T> sink<T>(Receiver<T> dst)
            => new Sink<T>(dst);

        /// <summary>
        /// Creates a <see cref='Sink{T}'/> from a <see cref='StreamWriter'/>
        /// </summary>
        /// <param name="dst">The target writer</param>
        /// <typeparam name="T">The reception type</typeparam>
        public static Sink<T> sink<T>(StreamWriter dst)
        {
            void Target(in T src) => dst.WriteLine(src);
            return new Sink<T>(Target);
        }

        /// <summary>
        /// Creates a <see cref='Sink{T}'/> from a <see cref='StreamWriter'/>
        /// </summary>
        /// <param name="dst">The target writer</param>
        /// <typeparam name="T">The reception type</typeparam>
        public static Sink<T> sink<T>(FileStream dst)
        {
            void Target(in T src)
                => FS.write(src?.ToString() ?? EmptyString, dst);

            return new Sink<T>(Target);
        }
    }
}