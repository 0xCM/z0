//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct Addresses
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Defines a <typeparamname name='T'/> valued <see cref='RelativeAddress{T}'/> relative to a specified offset
        /// </summary>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The offset type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RelativeAddress<T> relative<T>(MemoryAddress @base, T offset)
            where T : unmanaged
                => new RelativeAddress<T>(@base, offset);

        /// <summary>
        /// Defines a <see cref='RelativeAddress'/> offset with a specified offset
        /// </summary>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static RelativeAddress relative(MemoryAddress @base, ulong offset)
            => new RelativeAddress(@base, offset);

        /// <summary>
        /// Computes the <see cref='MemberAddress'/> of a specified <see cref='MethodInfo'/>
        /// </summary>
        /// <param name="src">The source member</param>
        [MethodImpl(Inline), Op]
        public static unsafe MemberAddress member(MethodInfo src)
            => new MemberAddress(src, src.MethodHandle.Value.ToPointer());

        /// <summary>
        /// Computes the <see cref='MemberAddress'/> of a specified <see cref='FieldInfo'/>
        /// </summary>
        /// <param name="src">The source member</param>
        [MethodImpl(Inline), Op]
        public static unsafe MemberAddress member(FieldInfo src)
            => new MemberAddress(src, src.FieldHandle.Value.ToPointer());

        [Op]
        public static void locations(MemorySegments store, Span<MemoryAddress> results)
        {
            var sources = store.View;
            var kSources = sources.Length;
            for(var i=0u; i<kSources; i++)
            {
                ref readonly var source = ref memory.skip(sources,i);
                var length = source.Length;
                var data = MemoryStore.Service.load(source);

                if(data.Length == length)
                {
                    for(var j = 0u; j<length; j++)
                    {
                        ref readonly var x = ref memory.skip(data,j);
                        if(j == 0)
                        {
                            var a = memory.address(x);
                            if(source.BaseAddress == a)
                                memory.seek(results,i) = a;
                        }
                    }
                }
            }
        }

        [Op]
        public static string format(RelativeAddress src)
            => src.Offset.FormatAsmHex(4);

        [Op, Closures(Closure)]
        public static string format<T>(RelativeAddress<T> src)
            where T : unmanaged
        {
            if(width<T>() == 8)
                return string.Format("{0} + {1}", src.Base, @as<T,byte>(src.Offset).FormatAsmHex());
            else if(width<T>() == 16)
                return string.Format("{0} + {1}", src.Base, @as<T,ushort>(src.Offset).FormatAsmHex());
            else if(width<T>() == 32)
                return string.Format("{0} + {1}", src.Base, @as<T,uint>(src.Offset).FormatAsmHex());
            else
                return string.Format("{0} + {1}", src.Base, @as<T,ulong>(src.Offset).FormatAsmHex());
        }

        [MethodImpl(Inline), Op]
        public static bool equals(RelativeAddress a, RelativeAddress b)
            => a.Absolute == b.Absolute;

        /// <summary>
        /// Computes the whole number of T-cells identified by a reference
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint count<T>(in MemorySegment src)
            => (uint)(src.Length/size<T>());

        /// <summary>
        /// Covers a memory reference with a readonly span
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> view<T>(in MemorySegment src)
            => cover(src.BaseAddress.Ref<T>(), count<T>(src));
    }
}