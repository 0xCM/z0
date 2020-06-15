//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using API = Literati;

    public readonly struct BinaryLiteral<T> : ILiteral<BinaryLiteral<T>,T>
        where T : unmanaged
    {                
        public static BinaryLiteral<T> Empty 
            => new BinaryLiteral<T>(string.Empty,default, string.Empty);                 
        
        public string Name {get;}
        
        public T Data {get;}

        public string Text {get;}
        
        [MethodImpl(Inline)]
        public BinaryLiteral(string name, T value, string text)
        {
            this.Name = name;
            this.Data = value;
            this.Text = text;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Name) && text.empty(Text) && Data.Equals(default);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public BinaryLiteral<T> Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => API.format(this);

        public override string ToString()
            => Format();


        [MethodImpl(Inline)]
        public bool Equals(BinaryLiteral<T> src)
            => string.Equals(Text,src.Text) 
            && object.Equals(Data, src.Data) 
            && string.Equals(Name, src.Name);

    }
}