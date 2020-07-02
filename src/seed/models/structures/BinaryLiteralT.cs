//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BinaryLiteral<T> : ILiteral<BinaryLiteral<T>,T>
        where T : unmanaged
    {                
        public string Name {get;}
        
        public T Data {get;}

        public string Text {get;}
        
        [MethodImpl(Inline)]
        public BinaryLiteral(string name, T value, string text)
        {
            Name = name;
            Data = value;
            Text = text;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => BinaryLiteral.empty(this);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => BinaryLiteral.nonempty(this);
        }

        public BinaryLiteral<T> Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => BinaryLiteral.format(this); 

        public override string ToString()
            => Format();


        [MethodImpl(Inline)]
        public bool Equals(BinaryLiteral<T> src)
            => BinaryLiteral.eq(this, src); 

        public static BinaryLiteral<T> Empty 
            => new BinaryLiteral<T>(EmptyString, default, EmptyString);
    }
}