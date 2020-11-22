//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface IMetaType
    {
        /// <summary>
        /// The runtime type described by the reifying metatype
        /// </summary>
        Type RuntimeType {get;}
    }

    public interface IMetaType<M,T> : IMetaType
        where M : IMetaType<M,T>
    {
        Type IMetaType.RuntimeType
            => typeof(T);
    }

    [ApiHost]
    public readonly struct MetaTypes
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Array<T> array<T>()
            => default;

        public readonly struct DataCell<T>
            where T : unmanaged, IDataCell<T>
        {

        }

        public readonly struct PrimalCell<T>
            where T : unmanaged
        {

        }

        public readonly struct Array<T> : IMetaType<Array<T>,T[]>
        {
            public Type CellType
                => typeof(T);

            public Type RuntimeType
                => typeof(T[]);

            [MethodImpl(Inline)]
            public static implicit operator Array(Array<T> src)
                => new Array(src.CellType, src.RuntimeType);
        }

        public readonly struct Array : IMetaType
        {
            public Type CellType {get;}

            public Type RuntimeType {get;}

            [MethodImpl(Inline)]
            internal Array(Type cell, Type rt)
            {
                CellType = cell;
                RuntimeType = rt;
            }
        }
    }
}
