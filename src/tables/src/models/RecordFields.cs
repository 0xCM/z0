//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    public readonly struct RecordFields : IIndex<RecordField>
    {
        /// <summary>
        /// Discerns a <see cref='RecordFields'/> for a parametrically-identified record type
        /// </summary>
        /// <typeparam name="T">The record type</typeparam>
        public static RecordField[] discover<T>()
            where T : struct
                => discover(typeof(T));

        public static string name(FieldInfo def)
            => def.Tag<LabelAttribute>().MapValueOrDefault(a => a.Label, def.Name);

        /// <summary>
        /// Discerns a <see cref='RecordFields'/> for a specified record type
        /// </summary>
        /// <param name="src">The record type</typeparam>
        public static RecordField[] discover(Type src)
        {
            var fields = src.DeclaredPublicInstanceFields().ToReadOnlySpan();
            var count = fields.Length;
            var buffer = sys.alloc<RecordField>(count);
            ref var dst = ref first(buffer);
            for(var i=z16; i<count; i++)
            {
                ref readonly var f = ref skip(fields,i);
                seek(dst, i) = new RecordField(i, f, name(f));
            }
            return buffer;
        }

        readonly Index<RecordField> Data;

        [MethodImpl(Inline)]
        public RecordFields(RecordField[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref RecordField this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref RecordField this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ReadOnlySpan<RecordField> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<RecordField> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public RecordField[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public static RecordFields Empty
            => new RecordFields(sys.empty<RecordField>());

        [MethodImpl(Inline)]
        public RecordFields Refresh(RecordField[] src)
            => src;

        [MethodImpl(Inline)]
        public static implicit operator RecordFields(RecordField[] src)
            => new RecordFields(src);
    }
}