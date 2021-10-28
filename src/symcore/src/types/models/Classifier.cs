//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    /// <summary>
    /// Defines an indexed/labeled sequence that forms a partition over som domain
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public class Classifier : IClassifier
    {
        public Label ClassName {get;}

        readonly Index<Label> _KindNames;

        readonly Index<LabeledValue<ulong>> _Values;

        readonly Index<Sym> _Symbols;

        readonly Index<Class> _Classes;

        [MethodImpl(Inline)]
        public Classifier(Label name, Label[] names, Sym[] symbols, LabeledValue<ulong>[] values, Class[] classes)
        {
            ClassName = name;
            _Symbols = symbols;
            _KindNames = names;
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
            get => _KindNames.View;
        }

        public ReadOnlySpan<Sym> ClassSymbols
        {
            [MethodImpl(Inline)]
            get => _Symbols.View;
        }

        public ReadOnlySpan<LabeledValue<ulong>> Values
        {
            [MethodImpl(Inline)]
            get => _Values.View;
        }

        public ReadOnlySpan<Class> Classes
        {
            [MethodImpl(Inline)]
            get => _Classes.View;
        }
    }
}