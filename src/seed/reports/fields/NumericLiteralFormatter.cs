//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = NumericLiteralField;
    using R = NumericLiteral;

    public enum NumericLiteralField : uint
    {
        Name = 0 | (30 << WidthOffset),

        Base = 1 | (10 << WidthOffset),

        Data = 2  | (80 << WidthOffset),

        Text = 3 | (80 << WidthOffset),

    }
            
    public readonly struct NumericLiteralFormatter : IValueFormatter<F,R>
    {                                    
        public static ValueFormatter<F,R> Service 
            => ValueFormatter.from(default(NumericLiteralFormatter));

        static string Format(Base2 @base, NumericLiteral src)
            => BitFormatter.format(src.Data, src.TypeCode);

        public void Format(in R src, IDatasetFormatter<F> dst)
        {
            dst.Delimit(NumericLiteralField.Name, src.Name);
            dst.Delimit(NumericLiteralField.Base, src.Base);
            dst.Delimit(NumericLiteralField.Data, Format(base2, src));        
            dst.Delimit(NumericLiteralField.Text, src.Text);
        }
    }
}