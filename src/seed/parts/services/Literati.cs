//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;

    using NBI = NumericBaseIndicator;

    [ApiHost]
    public class Literati : IApiHost<Literati>
    {
        [MethodImpl(Inline), Op]
        public static BinaryLiteral define(Base2 @base2, string name, object value, string text)
            => new BinaryLiteral(name,value,text);

        [MethodImpl(Inline), Op]
        public static BinaryLiteral<T> define<T>(Base2 @base2, string name, T value, string text)
            where T : unmanaged
                => new BinaryLiteral<T>(name, value, text);

        /// <summary>
        /// Selects the binary literals declared by a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static IEnumerable<BinaryLiteral> attributed(Base2 @base, Type src)
            => from f in src.LiteralFields()
               where f.Tagged<BinaryLiteralAttribute>()
               let a = f.Tag<BinaryLiteralAttribute>().Require()
               select define(@base, f.Name, f.GetRawConstantValue(), a.Text);

        /// <summary>
        /// Selects the binary literals declared by a type that are of a specified parametric primal type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The primal literal type</typeparam>
        public static IEnumerable<BinaryLiteral<T>> attributed<T>(Base2 @base, Type src)
            where T : unmanaged
                => from f in src.LiteralFields()
                   where f.FieldType == typeof(T) && f.Tagged<BinaryLiteralAttribute>()
                   let a = f.Tag<BinaryLiteralAttribute>().Require()
                   select define(@base, f.Name, (T)f.GetRawConstantValue(), a.Text);

        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline)]
        public static NumericKind kind<T>(BinaryLiteral<T> src)
            where T : unmanaged
                => NumericKinds.kind<T>();

        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline)]
        public static NumericKind kind(BinaryLiteral src)
            => src.Data?.GetType()?.NumericKind() ?? NumericKind.None;

        public static T[] values<T>(Base2 @base, Type declarer)
            where T : unmanaged
        {
            var literals = attributed<T>(@base, declarer).ToReadOnlySpan();        
            var count = literals.Length;
            var dst = Control.alloc<T>(count);

            Span<T> target = dst;
            
            for(var i=0; i< count; i++)        
                Control.seek(target,i) = Control.skip(literals,i).Data;
            return dst;            
        }

        public static string format(BinaryLiteral src) 
            => $"{src.Name}({src.Data}:{kind(src).Keyword()}) := " + text.enquote(src.Text);

        public static string format<T>(BinaryLiteral<T> src) 
            where T : unmanaged
                => $"{src.Name}({src.Data}:{kind(src).Keyword()}) := " + text.enquote(src.Text);
        public static NumericLiteral[] numeric(LiteralInfo src, object value = null)
        {
            if(src.MultiLiteral)
            {
                var content = text.unbracket(src.Text);
                if(!text.empty(content))
                {
                    var components = content.SplitClean(Chars.Pipe);
                    var count = components.Length;
                    var dst = Control.alloc<NumericLiteral>(count);
                    for(var i=0; i<components.Length; i++)
                    {
                        var component = components[i];
                        var length = component.Length;
                        if(length > 0)
                        {
                            var indicator = NumericBases.indicator(component[0]);

                            if(indicator != 0)
                                dst[i] = NumericLiteral.Define(
                                    src.Name,
                                    value,
                                    component.Substring(1),
                                    NumericBases.kind(indicator) 
                                    );
                            else
                            {
                                indicator = NumericBases.indicator(component[length - 1]);
                                indicator = indicator != 0 ? indicator : NBI.Base2;
                                dst[i] = NumericLiteral.Define(
                                    src.Name,
                                    value,
                                    component.Substring(0, length - 1),
                                    NumericBases.kind(indicator)                                    
                                    );
                            }                            
                        }
                        else
                            dst[i] = NumericLiteral.Empty;
                    }
                }
            }   
            return Control.array<NumericLiteral>();
        }        
    }
}