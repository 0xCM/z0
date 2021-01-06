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

    using DW = DataWidth;

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
        public static RelativeAddress<T> relative<T>(T offset)
            where T : unmanaged
                => new RelativeAddress<T>(offset);

        /// <summary>
        /// Defines a <see cref='RelativeAddress'/> offset with a <see cref='byte'/> valued offset
        /// </summary>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static RelativeAddress relative(byte offset)
            => new RelativeAddress(offset, DW.W8);

        /// <summary>
        /// Defines a <see cref='RelativeAddress'/> offset with a <see cref='ushort'/> valued offset
        /// </summary>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static RelativeAddress relative(ushort offset)
            => new RelativeAddress(offset, DW.W16);

        /// <summary>
        /// Defines a <see cref='RelativeAddress'/> offset with a <see cref='uint'/> valued offset
        /// </summary>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static RelativeAddress relative(uint offset)
            => new RelativeAddress(offset, DW.W32);

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
            => src.Offset.FormatSmallHex(true);

        [Op, Closures(Closure)]
        public static string format<T>(RelativeAddress<T> src)
            where T : unmanaged
        {
            if(bitwidth<T>() == 8)
                return @as<T,byte>(src.Offset).FormatAsmHex();
            else if(bitwidth<T>() == 16)
                return @as<T,ushort>(src.Offset).FormatAsmHex();
            else if(bitwidth<T>() == 32)
                return @as<T,uint>(src.Offset).FormatAsmHex();
            else
                return @as<T,ulong>(src.Offset).FormatAsmHex();
        }

        [MethodImpl(Inline), Op]
        public static bool equals(RelativeAddress a, RelativeAddress b)
            => a.Offset == b.Offset && a.Grain == b.Grain;

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