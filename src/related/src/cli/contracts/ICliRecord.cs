//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;

    public interface ICliRecord<T>  : IRecord<T>
        where T : unmanaged, ICliRecord<T>
    {
        CliTableKind TableKind {get;}

        CliRowKey Key => @as<ICliRecord<T>,CliRowKey>(this);
    }

    public interface ICliRecord<T,K> : ICliRecord<T>
        where T : unmanaged, ICliRecord<T>
        where K : unmanaged, ICliTableKind<K>
    {
        new K TableKind => default(K);

        CliTableKind ICliRecord<T>.TableKind
            => TableKind.TableKind;

        new CliRowKey<K> Key => @as<ICliRecord<T>,CliRowKey<K>>(this);
    }
}