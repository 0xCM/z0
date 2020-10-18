//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Linq;
    using System.IO;

    [ApiHost("api")]
    public readonly partial struct Part
    {
        /// <summary>
        /// Retrieves the part identifier, if any, of the entry assembly
        /// </summary>
        public static PartId ExecutingPart
            => id(Assembly.GetEntryAssembly());

        public static string AppName
            => Assembly.GetEntryAssembly().GetName().Name;

        public static string ShellExeDir
            => Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        public static PartId[] identities(Assembly[] src)
            => src.Where(test).Select(x => Part.@base(x.Id()));

        public static PartId CallingPart
            => id(Assembly.GetCallingAssembly());

        [MethodImpl(Inline), Op]
        public static PartId withoutTest(PartId a)
            => a & ~ PartId.Test;

        [MethodImpl(Inline), Op]
        public static PartId withTest(PartId a)
            => a | PartId.Test;

        [MethodImpl(Inline), Op]
        public static PartId withoutSvc(PartId a)
            => a & ~ PartId.Svc;

        [MethodImpl(Inline), Op]
        public static PartId withSvc(PartId a)
            => a | PartId.Svc;

        [MethodImpl(Inline)]
        public static uint uint32<T>(T src)
            => Unsafe.As<T,uint>(ref src);

        /// <summary>
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        internal static T[] map<S,T>(IEnumerable<S> src, Func<S,T> f)
        {
            Span<S> source = src.ToArray();
            var count = source.Length;
            var buffer = new T[count];
            Span<T> target = buffer;
            for(var i=0; i<count; i++)
                target[i] = f(source[i]);
            return buffer;
        }

        /// <summary>
        /// Allocates and populates a new array by filtering the source array with a specified predicate
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The array element type</typeparam>
        [MethodImpl(Inline)]
        internal static T[] where<T>(ReadOnlySpan<T> src, Func<T,bool> f)
        {
            var length = src.Length;
            Span<T> dst = new T[length];
            var count = 0;
            for(var i=0; i<length; i++)
            {
                ref readonly var test = ref src[i];
                if(f(test))
                    dst[count++] = test;
            }
            return dst.Slice(0, (int)count).ToArray();
        }
    }

    public static partial class XTend
    {

    }
}