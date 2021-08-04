//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static core;
    using static Root;

    partial struct Tables
    {
        [MethodImpl(Inline), Op]
        public static ReflectedTable reflected(Type type, TableId id, RecordField[] fields, LayoutKind? kind = null, CharSet? charset = null, byte? pack = null, uint? size = null)
            => new ReflectedTable(type, id, fields, kind, charset, pack, size);

        [Op]
        public static ReflectedTable reflected(Type type)
        {
            var layout = type.Tag<StructLayoutAttribute>();
            var id = TableId.identify(type);
            var _fields = RecordFields.discover(type);
            LayoutKind? kind = null;
            CharSet? charset = null;
            byte? pack = null;
            uint? size = null;
            layout.OnSome(a =>{
                kind = a.Value;
                charset = a.CharSet;
                pack = (byte)a.Pack;
                size = (uint)a.Size;
            });

            return reflected(type, id, _fields, kind, charset, pack,size);
        }
    }
}