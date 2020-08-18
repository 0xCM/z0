//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct RenderPattern : ITextual
    {
        readonly FieldInfo Source;

        readonly StringRef Content;
        
        [MethodImpl(Inline)]
        public RenderPattern(FieldInfo src, string content)
        {
            Source = src;
            Content = content;
        }     

        public string Format()
            => StringRefs.format("{0}: {1}", Source.Name, Content);

        public string Apply<T0>(T0 t0)   
        {
            try
            {
                return text.format(Content, t0);
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }        

        public string Apply<T0,T1>(T0 t0, T1 t1)   
        {
            try
            {
                return text.format(Content, t0, t1);
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }                

        public string Apply<T0,T1,T2>(T0 t0, T1 t1, T2 t2)   
        {
            try
            {
                return text.format(Content, t0, t1, t2);
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }                

        public string Apply<T0,T1,T2,T3>(T0 t0, T1 t1, T2 t2, T3 t3)   
        {
            try
            {
                return text.format(Content, t0, t1, t2, t3);
            }
            catch(Exception e)
            {
                return e.ToString();
            }
       }                

        public string Apply<T0,T1,T2,T3,T4>(T0 t0, T1 t1, T2 t2, T3 t3,T4 t4)   
        {
            try
            {
                return text.format(Content, t0, t1, t2, t3, t4);
            }
            catch(Exception e)
            {
                return e.ToString();
            }
       }                

        public string Apply(params object[] args)   
        {
            try
            {
                return text.format(Content, args);
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }
    }
}