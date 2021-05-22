//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISemanticIndex
    {
        uint EntryCount {get;}

        Type KeyType {get;}

        ClrEnumKind KeyKind {get;}

        ReadOnlySpan<string> KeyNames {get;}
    }

    [Free]
    public interface ISemanticIndex<K> : ISemanticIndex
        where K : unmanaged, Enum
    {
        Type ISemanticIndex.KeyType
            => typeof(K);

        ClrEnumKind ISemanticIndex.KeyKind
            => Enums.@base<K>();

        ReadOnlySpan<string> ISemanticIndex.KeyNames
            => Enums.names<K>();

        ReadOnlySpan<K> KeyValues
            => Enums.literals<K>();

        ReadOnlySpan<EnumLiteralDetail<K>> KeyIndex
            => Enums.details<K>().View;
    }

    [Free]
    public interface ISemanticIndex<K,T> : ISemanticIndex<K>
        where K : unmanaged, Enum
    {
        ReadOnlySpan<T> View {get;}

        Span<T> Edit {get;}

        ref T this[K index]{get;}

        uint ISemanticIndex.EntryCount
            => (uint)View.Length;
    }

     [Free]
    public interface ISemanticIndex<H,K,T> : ISemanticIndex<K,T>
        where H : struct, ISemanticIndex<H,K,T>
        where K : unmanaged, Enum
    {

    }
}