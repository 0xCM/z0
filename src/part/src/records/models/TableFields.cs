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

    public readonly struct TableFields
    {
        [Op]
        public static TableFields discover(Type type)
        {
            if(!type.IsStruct() || type.IsPrimitive)
                return TableFields.Empty;

            var declared = type.Fields();
            var count = declared.Length;
            var buffer = alloc<TableField>(count);

            map(declared, buffer);

            return new TableFields(buffer);
        }

        [Op]
        public static TableFields discover(Type src, bool recurse)
        {
            var collected = list<TableField>();
            ushort j = 0;
            if(src.IsStruct() && !src.IsPrimitive)
            {
                var defs = @readonly(src.DeclaredInstanceFields());
                var count = defs.Length;
                for(var i=0u; i<count; i++)
                {
                    ref readonly var def = ref skip(defs,i);
                    var dst = new TableField();
                    map(def, j++, ref dst);
                    var ft = def.FieldType;
                    if(ft.IsStruct() && !ft.IsPrimitive && recurse)
                    {
                        var subfields = discover(ft, recurse);
                        collected.AddRange(subfields.Storage);
                    }
                }
            }

            var final = collected.ToArray();
            var fCount = final.Length;
            ref var f = ref first(span(final));
            for(ushort index = 0; index<fCount; index++)
                seek(f,index).Index = index;

            return final;
        }

        static void map(ReadOnlySpan<FieldInfo> src, Span<TableField> dst)
        {
            var count = (ushort)src.Length;
            for(var i=z16; i<count; i++)
                map(skip(src, i), i, ref seek(dst, i));
        }

        [MethodImpl(Inline), Op]
        static ref TableField map(FieldInfo src, ushort index, ref TableField dst)
        {
            dst.Index = index;
            dst.RecordType = src.DeclaringType;
            dst.DataType = src.FieldType;
            dst.RenderWidth = 16;
            dst.Definition = src;
            return ref dst;
        }

        readonly Index<TableField> Data;

        [MethodImpl(Inline)]
        public TableFields(TableField[] src)
            => Data = src;

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref TableField this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref TableField this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public Option<TableField> this[string name]
        {
            [MethodImpl(Inline)]
            get
            {
                for(var i=0u; i<Count; i++)
                {
                    ref readonly var current = ref this[i];
                    if(current.Name == name)
                        return current;
                }
                return root.none<TableField>();
            }
        }

        public Option<TableField> this[in string name]
        {
            [MethodImpl(Inline)]
            get
            {
                for(var i=0u; i<Count; i++)
                {
                    ref readonly var current = ref this[i];
                    if(current.Name == name)
                        return current;
                }
                return root.none<TableField>();
            }
        }

        public ReadOnlySpan<TableField> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<TableField> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public TableField[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public static TableFields Empty
            => new TableFields(sys.empty<TableField>());

        [MethodImpl(Inline)]
        public TableFields Refresh(TableField[] src)
            => src;

        [MethodImpl(Inline)]
        public static implicit operator TableFields(TableField[] src)
            => new TableFields(src);
    }
}