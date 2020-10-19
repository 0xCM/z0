//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Reflection;

    using static Konst;

    public readonly struct Aspects
    {
        public static string[] Values<T>(object src)
            => From<T>(src).FormatValues();

        public static string[] Names<T>()
        {
            var props = Props(typeof(T));
            var count = props.Length;
            var names = new string[count];
            for(var i=0; i<count; i++)
                names[i] = Label(props[i]);
            return names;
        }

        public static Aspects From<T>(object src)
        {
            var contractType = typeof(T);
            var contractLabel = Label(contractType);

            var hostType = src.GetType();
            var hostLabel = Label(hostType);

            if(!src.GetType().Reifies<T>())
                return new Aspects(new AspectRow("Error", hostType, src, ContractMismatch(hostLabel, contractLabel).Format()));

            var dst = text.build();
            var props = Props(contractType);
            var propcount = props.Length;
            var aspects = new AspectRow[propcount];

            for(var i=0; i< propcount; i++)
            {
                var prop = props[i];
                var name = Label(prop);
                var val = props[i].GetValue(src);
                var description = FormatValue(val);
                aspects[i] = (name, hostLabel, (val is null) ? "null" : val, description);
            }

            return aspects;
        }

        public readonly AspectRow[] Data {get;}

        [MethodImpl(Inline)]
        public static implicit operator Aspects(AspectRow[] data)
            => new Aspects(data);

        [MethodImpl(Inline)]
        public Aspects(params AspectRow[] data)
        {
            Data = data;
        }

        [MethodImpl(Inline)]
        public ref readonly AspectRow Aspect(uint index)
            => ref Data[index];

        public ref readonly AspectRow this[uint index]
        {
             [MethodImpl(Inline)]
             get => ref Aspect(index);
        }

        public int Count
            => Data.Length;

        const string DefaultSep = CharText.Space + CharText.Pipe + CharText.Space;

        public string Format(string sep)
        {
            var dst = text.build();
            for(var i=0u; i<Count; i++)
                dst.Append(FormatItem(i, sep));
            return dst.ToString();
        }

        string FormatValue(uint index)
            => Aspect(index).Description;

        public string[] FormatValues()
        {
            var dst = z.alloc<string>(Count);
            for(var i=0u; i<dst.Length; i++)
                dst[i] = FormatValue(i);
            return dst;
        }

        public string Format()
            => Format(DefaultSep);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        static string FormatDelimiter(uint index)
            => index != 0 ? DefaultSep : string.Empty;

        [MethodImpl(Inline)]
        string FormatItem(uint index, string sep)
            => FormatDelimiter(index) + this[index].Format();

        public static Aspects Empty
            => new Aspects(sys.empty<AspectRow>());

        public static string FormatValue(object value)
        {
            if(value is null)
               return "null";
            else if(value is ITextual t)
                return t.Format();
            else
                return value.ToString();
        }

        static AppMsg ContractMismatch(string host, string contract)
            => AppMsg.define($"The source type {host} does not reify {contract}", LogLevel.Error);

        static PropertyInfo[] Props(Type contract)
            => contract.Properties().Instance().Where(p => p.NotIgnored());

        static string Label(PropertyInfo src)
            => AspectLabels.GetOrAdd(src, p =>  LabelAttribute.TargetLabel(p));

        static string Label(Type src)
            => TypeLabels.GetOrAdd(src, t =>  LabelAttribute.TargetLabel(t));

        static ConcurrentDictionary<Type, string> TypeLabels {get;}
            = new ConcurrentDictionary<Type, string>();

        static ConcurrentDictionary<PropertyInfo, string> AspectLabels {get;}
            = new ConcurrentDictionary<PropertyInfo, string>();
    }
}