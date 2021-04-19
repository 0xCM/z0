//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Part;

    [ApiHost]
    public class ClrDb
    {
        static ClrDb _Service;

        [FixedAddressValueType]
        static Storage Data;

        static ClrDb()
        {
            Data = new Storage(0);
            _Service = new();
        }

        [MethodImpl(Inline)]
        public static ClrDb service()
            => _Service;

        [Op]
        public FieldInfo[] Fields(Type src)
            => Data.Fields(src);

        [Op]
        public PropertyInfo[] Properties(Type src)
            => Data.Properties(src);

        [Op]
        public MethodInfo[] Methods(Type src)
            => Data.Methods(src);

        [Op]
        public Type[] Types(Assembly src)
            => Data.Types(src);

        public ClrDbSnapshot Snapshot()
        {
            var dst = new ClrDbSnapshot();
            dst.Types = Data.Types();
            dst.Fields = Data.Fields();
            dst.Properties = Data.Properties();
            dst.Methods = Data.Methods();
            return dst;
        }
        struct Storage
        {
            public Storage(byte x)
            {
                _Fields = new();
                _Methods = new();
                _Types = new();
                _Properties = new();
            }

            [MethodImpl(Inline)]
            public Index<Type[]> Types()
                => _Types.Values.Array();

            [MethodImpl(Inline)]
            public Index<FieldInfo[]> Fields()
                => _Fields.Values.Array();

            [MethodImpl(Inline)]
            public Index<MethodInfo[]> Methods()
                => _Methods.Values.Array();

            [MethodImpl(Inline)]
            public Index<PropertyInfo[]> Properties()
                => _Properties.Values.Array();

            [MethodImpl(Inline)]
            public Type[] Types(Assembly src)
                => _Types.GetOrAdd(Clr.key(src), k => Clr.types(src, out var _));

            [MethodImpl(Inline)]
            public FieldInfo[] Fields(Type src)
                => _Fields.GetOrAdd(Clr.key(src), k => Clr.fields(src, out var _));

            [MethodImpl(Inline)]
            public MethodInfo[] Methods(Type src)
                => _Methods.GetOrAdd(Clr.key(src), k => Clr.methods(src, out var _));

            [MethodImpl(Inline)]
            public PropertyInfo[] Properties(Type src)
                => _Properties.GetOrAdd(Clr.key(src), k => Clr.properties(src, out var _));

            ConcurrentDictionary<ulong,FieldInfo[]> _Fields;

            ConcurrentDictionary<ulong,MethodInfo[]> _Methods;

            ConcurrentDictionary<ulong,Type[]> _Types;

            ConcurrentDictionary<ulong,PropertyInfo[]> _Properties;
        }
    }
}