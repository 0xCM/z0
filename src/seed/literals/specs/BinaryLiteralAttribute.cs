//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    /// <summary>
    /// Attaches a binary literal value to a target
    /// </summary>
    public class BinaryLiteralAttribute : Attribute
    {
        public BinaryLiteralAttribute(string src)
        {
            Text = src ?? string.Empty;
        }

        public string Text {get;}            

        [MethodImpl(Inline)]
        public static bool Attached(FieldInfo target)
            => Attribute.IsDefined(target, typeof(BinaryLiteralAttribute));

        public static NumericLiteral TargetValue(FieldInfo target, object value)
        {
            if(!Attached(target))
                return NumericLiteral.Empty;                        
            
            return NumericLiteral.Base2(target.Name, value, 
                target.Tag<BinaryLiteralAttribute>().Value.Text);
        }
    }
}