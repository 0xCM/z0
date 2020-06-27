//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Reflection;

    using static Konst;
    
    class AspectMeta
    {
        public static string FormatValue(object value)
        {
            if(value is null)
               return "null";
            else if(value is ITextual t)
                return t.Format();
            else
                return value.ToString();
        }

        public static AppMsg ContractMismatch(string host, string contract) 
            => AppMsg.NoCaller($"The source type {host} does not reify {contract}", AppMsgKind.Error);

        public static PropertyInfo[] Props(Type contract)
            => contract.Properties().Instance().Where(p => p.NotIgnored());

        public static string Label(PropertyInfo src)
            => AspectLabels.GetOrAdd(src, p =>  LabelAttribute.TargetLabel(p));

        public static string Label(Type src)
            => TypeLabels.GetOrAdd(src, t =>  LabelAttribute.TargetLabel(t));

        static ConcurrentDictionary<Type, string> TypeLabels {get;}
            = new ConcurrentDictionary<Type, string>();

        static ConcurrentDictionary<PropertyInfo, string> AspectLabels {get;}
            = new ConcurrentDictionary<PropertyInfo, string>();        
    }

}