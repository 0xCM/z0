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

    using static Part;

    public readonly struct Aspects
    {
        public static string[] values<T>(object src)
            => load<T>(src).FormatValues();

        public static string[] names<T>()
        {
            var props = typeof(T).Properties().Instance().Where(p => p.NotIgnored());
            var count = props.Length;
            var names = new string[count];
            for(var i=0; i<count; i++)
                names[i] = label(props[i]);
            return names;
        }

        public static Aspects load<T>(object src)
        {
            var contractType = typeof(T);
            var contractLabel = label(contractType);

            var hostType = src.GetType();
            var hostLabel = label(hostType);

            if(!hostType.Reifies(contractType))
            {
                var msg = Msg.ContractMismatch.Format(hostType, contractType);
                return new Aspects(new Aspect("Error", hostType, src, msg));
            }

            var dst = text.build();
            var props = Aspects.props(contractType);
            var propcount = props.Length;
            var aspects = new Aspect[propcount];

            for(var i=0; i< propcount; i++)
            {
                var prop = props[i];
                var name = label(prop);
                var val = props[i].GetValue(src);
                var description = FormatValue(val);
                aspects[i] = (name, hostLabel, (val is null) ? "null" : val, description);
            }

            return aspects;
        }

        public Aspect[] Data {get;}

        [MethodImpl(Inline)]
        public Aspects(params Aspect[] data)
            => Data = data;

        [MethodImpl(Inline)]
        public ref readonly Aspect Aspect(uint index)
            => ref Data[index];

        public ref readonly Aspect this[uint index]
        {
             [MethodImpl(Inline)]
             get => ref Aspect(index);
        }

        public int Count
            => Data.Length;

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
            var dst = memory.alloc<string>(Count);
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

        [MethodImpl(Inline)]
        public static implicit operator Aspects(Aspect[] data)
            => new Aspects(data);

        public static Aspects Empty
            => new Aspects(sys.empty<Aspect>());

        public static string FormatValue(object value)
        {
            if(value is null)
               return "null";
            else if(value is ITextual t)
                return t.Format();
            else
                return value.ToString();
        }

        const string DefaultSep = " | ";

        static PropertyInfo[] props(Type contract)
            => contract.Properties().Instance().Where(p => p.NotIgnored());

        static string label(PropertyInfo src)
            => AspectLabels.GetOrAdd(src, p =>  Labels.from(p));

        static string label(Type src)
            => TypeLabels.GetOrAdd(src, t => Labels.from(t));

        static ConcurrentDictionary<Type, string> TypeLabels {get;}
            = new ConcurrentDictionary<Type, string>();

        static ConcurrentDictionary<PropertyInfo, string> AspectLabels {get;}
            = new ConcurrentDictionary<PropertyInfo, string>();
    }
}