//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ISemanticIndex
    {
        CellCount EntryCount {get;}

        Type KeyType {get;}

        EnumScalarKind KeyKind {get;}
        
        ReadOnlySpan<string> KeyNames {get;}
        
    }

    public interface ISemanticIndex<K> : ISemanticIndex
        where K : unmanaged, Enum
    {
        Type ISemanticIndex.KeyType
            => typeof(K);
        
        EnumScalarKind ISemanticIndex.KeyKind
            => Enums.kind<K>();
        
        EnumLiteralNames<K> KeyNameIndex
            => Enums.NameIndex<K>();

        ReadOnlySpan<string> ISemanticIndex.KeyNames 
            => Enums.names<K>();
        
        ReadOnlySpan<K> KeyValues 
            => Enums.literals<K>();
        
        ReadOnlySpan<EnumLiteralDetail<K>> KeyIndex
            => Enums.index<K>().Content;
    }

    public interface ISemanticIndex<H,K,P,T> : ISemanticIndex<K,T>
        where H : struct, ISemanticIndex<H,K,P,T>
        where K : unmanaged, Enum
        where P : unmanaged
    {
        new ReadOnlySpan<EnumLiteralDetail<K,P>> KeyIndex 
            => Enums.values<K,P>().Content;

    }

    public interface ILiteralSemanticIndex<K> : ISemanticIndex<K>
        where K : unmanaged, Enum
    {

    }


    public interface ILiteralStringIndex<K>
    {

    }
    
    public interface ISemanticIndex<K,T> : ISemanticIndex<K>
        where K : unmanaged, Enum
    {
        ReadOnlySpan<T> View {get;}

        Span<T> Edit {get;}

        ref T this[K index]{get;}

        CellCount ISemanticIndex.EntryCount
            => View.Length;
    }
    
    public interface ISemanticIndex<H,K,T> : ISemanticIndex<K,T>
        where H : struct, ISemanticIndex<H,K,T>
        where K : unmanaged, Enum
    {

    }


}