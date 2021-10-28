//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines an indexed/labeled sequence that forms a partition over som domain
    /// </summary>
    public class Classifier<T> : IClassifier
    {
        public Label ClassName {get;}

        internal Index<Label> _ClassNames;

        internal Index<LabeledValue<T>> _Values;

        internal Index<Sym> _Symbols;

        internal Index<Class<T>> _Classes;

        [MethodImpl(Inline)]
        public Classifier(Label name, Label[] names, Sym[] symbols, LabeledValue<T>[] values, Class<T>[] classes)
        {
            ClassName = name;
            _Symbols = symbols;
            _ClassNames = names;
            _Values = values;
            _Classes = classes;
        }

        public uint ClassCount
        {
            [MethodImpl(Inline)]
            get => _Classes.Count;
        }

        public ReadOnlySpan<Label> ClassNames
        {
            [MethodImpl(Inline)]
            get => _ClassNames.View;
        }

        public ReadOnlySpan<Sym> ClassSymbols
        {
            [MethodImpl(Inline)]
            get => _Symbols.View;
        }

        public ReadOnlySpan<LabeledValue<T>> Values
        {
            [MethodImpl(Inline)]
            get => _Values.View;
        }

        public ReadOnlySpan<Class<T>> Classes
        {
            [MethodImpl(Inline)]
            get => _Classes.View;
        }
    }
}