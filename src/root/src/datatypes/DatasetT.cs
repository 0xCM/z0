//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IDataset
    {
        Name Identity {get;}
    }

    public interface IDataset<T> : IDataset
    {
        new T Identity {get;}

        Name IDataset.Identity
            => Identity.ToString();
    }

    public readonly struct Dataset<T> : IDataset<T>
    {
        public T Identity {get;}

        [MethodImpl(Inline)]
        public Dataset(T id)
        {
            Identity = id;
        }

        [MethodImpl(Inline)]
        public static implicit operator Dataset<T>(T id)
            => new Dataset<T>(id);

        [MethodImpl(Inline)]
        public static implicit operator Dataset(Dataset<T> ds)
            => new Dataset(ds.ToString());

    }
}