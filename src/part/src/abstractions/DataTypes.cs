//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines the canonical shape of a bitwise shift function
    /// </summary>
    /// <param name="a">The source value</param>
    /// <param name="count">The shift amount, typically in bits</param>
    /// <typeparam name="T">The operand type</typeparam>
    [Free]
    public delegate T Shifter<T>(T a, byte count)
        where T : unmanaged;

    [ApiHost]
    public readonly struct DataTypes
    {
        [Op]
        public static uint search(Assembly src, IList<DataType> dst)
        {
            var candidates = src.DefinedTypes.Span();
            var count = candidates.Length;
            var found = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var candidate = ref skip(candidates,i);
                var dt = metadata(candidate);
                if(dt.IsNonEmpty)
                {
                    found++;
                    dst.Add(dt);
                }
            }
            return found;
        }

        [Op]
        public static Index<DataType> search(params Assembly[] src)
        {
            var count = src.Length;
            var dst = root.list<DataType>(128);
            var view = @readonly(src);
            var found = 0u;
            for(var i=0; i<count; i++)
                found += search(skip(view,i),dst);
            return dst.ToArray();
        }

        [MethodImpl(Inline), Op]
        public static DataType empty()
            => new DataType(new EmptyDataType());

        [Op]
        public static DataType metadata(Type src)
        {
            var interfaces = src.Interfaces();
            var itype = typeof(IDataType);
            if(metadata(src, out var datatype))
                return datatype;
            else
                return DataType.Empty;
        }

        [Op]
        public static bool metadata(Type src, out DataType dst)
        {
            var interfaces = src.Interfaces();
            if(Index.contains(interfaces, typeof(IDataType)))
            {
                if(src.IsStruct())
                {
                    if(src.IsConcrete())
                        dst = metadata((IDataType)Activator.CreateInstance(src));
                    else
                        dst = new DataType(0, src, typeof(void));
                    return true;
                }
            }

            dst = DataType.Empty;
            return false;
        }

        [MethodImpl(Inline)]
        public static DataType metadata<T>(T src, uint width = 0)
            where T : IDataType
                => new DataType(src, width);
    }
}