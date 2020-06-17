//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Aspect : IValued<Aspect>
    {
        /// <summary>
        /// The aspect name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The defining oject
        /// </summary>
        public object Source {get;}

        /// <summary>
        /// The aspect value
        /// </summary>
        public object Value {get;}

        /// <summary>
        /// An informative description
        /// </summary>
        public string Description {get;}

        [MethodImpl(Inline)]
        public static Aspect Create(string name, object src, object value, string description)
            => (name,value,src,description);

        [MethodImpl(Inline)]
        public static implicit operator Aspect((string name, object src, object value, string description) src)
            => new Aspect(src.name, src.src, src.value, src.description);

        [MethodImpl(Inline)]
        public Aspect(string name, object src, object value, string description)
        {
            Name = name;
            Source = Null.Banish(src);
            Value = Null.Banish(value);
            Description = Null.Banish(description);
        }
                
        public string Format(string delimiter)
            => Name + delimiter + Description;

        public Aspect Zero 
            => Empty;

        public bool IsEmpty 
            => text.empty(Name) && text.empty(Description) && Null.Is(Source) && Null.Is(Value);

        public bool IsNonEmpty 
            => !IsEmpty;

        public string Format()
            => text.concat(Source, text.bracket(Name)," = ", Description); 

        public override string ToString()
            => Format();

        public static Aspect Empty => (string.Empty, Null.Value, Null.Value, string.Empty);
        
        const string DefaultSep = CharText.Space + CharText.Pipe + CharText.Space;        
    }
}