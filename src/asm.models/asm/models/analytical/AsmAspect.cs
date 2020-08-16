//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmAspect
    {
        /// <summary>
        /// The aspect name
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The defining source
        /// </summary>
        public readonly object Source;

        /// <summary>
        /// The aspect value
        /// </summary>
        public readonly object Value;

        /// <summary>
        /// An informative description
        /// </summary>
        public readonly string Description;

        [MethodImpl(Inline)]
        public static AsmAspect Create(string name, object src, object value, string description)
            => (name,value,src,description);

        [MethodImpl(Inline)]
        public static implicit operator AsmAspect((string name, object src, object value, string description) src)
            => new AsmAspect(src.name, src.src, src.value, src.description);

        [MethodImpl(Inline)]
        public AsmAspect(string name, object src, object value, string description)
        {
            Name = name;
            Source = Null.Banish(src);
            Value = Null.Banish(value);
            Description = Null.Banish(description);
        }
                
        public string Format(string delimiter)
            => Name + delimiter + Description;

        public AsmAspect Zero 
            => Empty;

        public bool IsEmpty 
            => text.blank(Name) && text.blank(Description) && Null.Is(Source) && Null.Is(Value);

        public bool IsNonEmpty 
            => !IsEmpty;

        public string Format()
            => text.concat(Source, text.bracket(Name)," = ", Description); 

        public override string ToString()
            => Format();

        public static AsmAspect Empty 
            => (string.Empty, Null.Value, Null.Value, string.Empty);
        
        const string DefaultSep 
            = CharText.Space + CharText.Pipe + CharText.Space;        
    }
}