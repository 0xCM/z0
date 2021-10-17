//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    public interface ISyntaxNode
    {
        Identifier NodeName {get;}
    }

    public class SyntaxNodes<T> : ISyntaxNode
        where T : ISyntaxNode, new()
    {
        List<T> Data;

        public Identifier NodeName => new T().NodeName + "Nodes";

        public SyntaxNodes()
        {
            Data = new();
        }

        public ReadOnlySpan<T> Nodes
        {
            get => Data.ViewDeposited();
        }

        public void Append(T node)
        {
            Data.Add(node);
        }
    }

    public abstract class SyntaxModel<T>
        where T : SyntaxModel<T>, new()
    {
        public abstract class SyntaxNode<S> : ISyntaxNode
            where S : SyntaxNode<S>, new()
        {

            public Identifier NodeName
                => typeof(S).Name;
        }

        public class NamedValue<V> : ISyntaxNode
        {
            public Identifier Name;

            public V Value;

            public Identifier NodeName
                => nameof(NamedValue<V>);
        }

        public class Attribute<V> : ISyntaxNode
        {
            public Identifier Name;

            public V Value;

            public Identifier NodeName
                => nameof(Attribute<V>);
        }
    }

    sealed class ObjectInfoSyntax : SyntaxModel<ObjectInfoSyntax>
    {

        public sealed class ImageFileHeader : SyntaxNode<ImageFileHeader>
        {

        }

        public sealed class Sections : SyntaxNodes<Section>
        {

        }

        public sealed class Section : SyntaxNode<Section>
        {

        }

        public sealed class Characteristics : SyntaxNode<Characteristics>
        {

        }

        public sealed class SectionData : SyntaxNode<SectionData>
        {

        }
    }
}