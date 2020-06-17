//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AspectMeta;

    public readonly struct Aspects : IValues<Aspects, Aspect>
    {
        public static string[] Values<T>(object src)
            where T : class
                => Aspects.From<T>(src).FormatValues();

        public static string[] Names<T>()
            where T : class
        {
            var props = Props(typeof(T));
            var count = props.Length;
            var names = new string[count];

            for(var i=0; i<count; i++)
                names[i] = Label(props[i]);
            
            return names;
        }        

        public static Aspects From<T>(object src)
            where T : class
        {
            var contractType = typeof(T);
            var contractLabel = Label(contractType);
            
            var hostType = src.GetType();
            var hostLabel = Label(hostType);
            
            if(!src.GetType().Reifies<T>())
                return new Aspects(
                    Asm.Aspect.Create("Error", hostType, src, ContractMismatch(hostLabel, contractLabel).Format()));
                
            var dst = text.build();
            var props = Props(contractType);
            var propcount = props.Length;
            var aspects = new Aspect[propcount];

            for(var i=0; i< propcount; i++)
            {
                var prop = props[i];
                var name = Label(prop);
                var val = props[i].GetValue(src);
                var description = AspectMeta.FormatValue(val);                    
                aspects[i] = (name, hostLabel, (val is null) ? "null" : val, description);
            }
            
            return aspects;
        }

        public readonly Aspect[] Data {get;}
        
        [MethodImpl(Inline)]
        public static implicit operator Aspects(Aspect[] data)
            => new Aspects(data);
        
        [MethodImpl(Inline)]
        public Aspects(params Aspect[] data)
        {
            Data = data;
        }
        
        [MethodImpl(Inline)]
        public ref readonly Aspect Aspect(int index) 
            => ref Data[index];
        
        public ref readonly Aspect this[int index] { [MethodImpl(Inline)] get => ref Aspect(index);}
        
        public int Length => Data.Length;

        public int Count => Data.Length;

        const string DefaultSep = CharText.Space + CharText.Pipe + CharText.Space;

        public string Format(string sep)
        {
            var dst = text.build();
            for(var i=0; i<Count; i++)
                dst.Append(FormatItem(i, sep));
            return dst.ToString();
        }

        string FormatValue(int index)
            => Aspect(index).Description;

        public string[] FormatValues()
        {
            var dst = Control.alloc<string>(Count);
            for(var i=0; i<dst.Length; i++)
                dst[i] = FormatValue(i);
            return dst;
        }
                
        public string Format()
            => Format(DefaultSep);
 
        public override string ToString() 
            => Format();

        [MethodImpl(Inline)]
        static string FormatDelimiter(int index)
            => index != 0 ? DefaultSep : string.Empty;

        [MethodImpl(Inline)]
        string FormatItem(int index, string sep)
            => FormatDelimiter(index) + this[index].Format();

        public static Aspects Empty 
            => new Aspects(Control.array<Aspect>());

        public Aspects Zero => Empty;
    }
}