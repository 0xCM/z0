//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISemanticLookup
    {
        Count EntryCount {get;}

        Type KeyType {get;}

        EnumScalarKind KeyKind {get;}

        ReadOnlySpan<string> KeyNames {get;}
    }

    [Free]
    public interface ISemanticLookup<K> : ISemanticLookup
        where K : unmanaged, Enum
    {
        Type ISemanticLookup.KeyType
            => typeof(K);

        EnumScalarKind ISemanticLookup.KeyKind
            => Enums.kind<K>();

        EnumLiteralNames<K> KeyNameIndex
            => Enums.NameIndex<K>();

        ReadOnlySpan<string> ISemanticLookup.KeyNames
            => Enums.names<K>();

        ReadOnlySpan<K> KeyValues
            => Enums.literals<K>();

        ReadOnlySpan<EnumLiteralDetail<K>> KeyIndex
            => Enums.index<K>().Content;
    }

    public interface ISemanticLookup<H,K,P,T> : ISemanticLookup<K,T>
        where H : struct, ISemanticLookup<H,K,P,T>
        where K : unmanaged, Enum
        where P : unmanaged
    {
        new ReadOnlySpan<EnumLiteralDetail<K,P>> KeyIndex
            => Enums.values<K,P>().Storage;
    }

    [Free]
    public interface ISemanticLookup<K,T> : ISemanticLookup<K>
        where K : unmanaged, Enum
    {
        ReadOnlySpan<T> View {get;}

        Span<T> Edit {get;}

        ref T this[K index]{get;}

        Count ISemanticLookup.EntryCount
            => View.Length;
    }

     [Free]
    public interface ISemanticIndex<H,K,T> : ISemanticLookup<K,T>
        where H : struct, ISemanticIndex<H,K,T>
        where K : unmanaged, Enum
    {

    }
}