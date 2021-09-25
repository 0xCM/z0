//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class)]
    public class TextParserAttribute : Attribute
    {
        public TextParserAttribute(Type target)
        {
            TargetType = target;
        }

        public Type TargetType {get;}
    }

    [Free]
    public interface ITextParser
    {
        Type TargetType {get;}

        Outcome Parse(string src, out dynamic dst);
    }

    [Free]
    public interface ITextParser<T> : ITextParser
    {
        Outcome Parse(string src, out T dst);

        Type ITextParser.TargetType
            => typeof(T);

        Outcome ITextParser.Parse(string src, out dynamic dst)
        {
            var result = Parse(src, out var x);
            if(result)
            {
                dst = x;
            }
            else
            {
                dst = default(T);
            }
            return result;
        }
    }
}